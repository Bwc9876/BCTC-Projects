import re
from abc import ABCMeta, abstractmethod
from re import findall
from typing import AnyStr, Callable


class CipherError(Exception):
    pass


class EncryptionHandlerMeta(ABCMeta):

    def __new__(mcs, name, bases, namespace, **kwargs):
        if 'ABSTRACT' not in namespace.keys():
            namespace['ABSTRACT'] = False
        if namespace['ABSTRACT'] is False:
            if 'TEST_DATA' not in namespace.keys() or namespace['TEST_DATA'] is None or len(
                    namespace['TEST_DATA']) != 3:
                raise TypeError(f"Invalid TEST_DATA on {name}")
        return super(EncryptionHandlerMeta, mcs).__new__(mcs, name, bases, namespace, **kwargs)

    def __str__(self):
        return ' '.join(findall(r'[A-Z](?:[a-z]+|[A-Z]*(?=[A-Z]|$))', self.__name__)).title()


class EncryptionHandler(metaclass=EncryptionHandlerMeta):
    ABSTRACT: bool = True
    MESSAGES: dict[str, str] = {}
    INIT_VALIDATORS: dict[str, Callable[[str, Callable[[str], None]], None]] = {}
    TEST_DATA: tuple[list, dict, AnyStr] = None

    def __init__(self, *args, **kwargs):
        pass

    def validate(self, input_str: str, encrypted: bool) -> None:
        pass

    @abstractmethod
    def encrypt(self, raw_str: AnyStr) -> AnyStr:
        pass

    @abstractmethod
    def decrypt(self, encrypted_str: AnyStr) -> AnyStr:
        pass


class EchoCipher(EncryptionHandler):
    TEST_DATA = ([], {}, "Hello World!")
    MESSAGES = {}

    def encrypt(self, raw_str: AnyStr) -> AnyStr:
        return raw_str

    def decrypt(self, encrypted_str: AnyStr) -> AnyStr:
        return encrypted_str


class CaesarCipher(EncryptionHandler):
    MAX_CHAR_CODE = 126
    MIN_CHAR_CODE = 33
    MESSAGES = {
        'offset': "Enter the amount to shift by"
    }
    TEST_DATA = ([3], {}, "ABC123~~~!!!")

    def __init__(self, offset: int, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.offset = offset

    def shift(self, char: str, amount: int) -> str:
        code = ord(char)
        if (self.MIN_CHAR_CODE < code < self.MAX_CHAR_CODE) is False:
            return char
        else:
            new_code = ord(char) + amount
            while new_code > self.MAX_CHAR_CODE:
                new_code -= self.MAX_CHAR_CODE
            while new_code < self.MIN_CHAR_CODE:
                new_code += self.MAX_CHAR_CODE
            return chr(new_code)

    def encrypt(self, raw_str: AnyStr) -> AnyStr:
        return ''.join([self.shift(c, self.offset) for c in raw_str])

    def decrypt(self, encrypted_str: AnyStr) -> AnyStr:
        return ''.join([self.shift(c, -self.offset) for c in encrypted_str])


MAP_PATTERN = re.compile(r"(.=.);.*?")


def parse_map(raw_map: str) -> dict[int, int]:
    new_map = {}
    for match in MAP_PATTERN.finditer(raw_map.replace(' ', '') + ';'):
        split_item = match.group(1).split('=')
        new_map[ord(split_item[0])] = ord(split_item[1])
    return new_map


def substitution_validate_map(raw_map: str, invalidate):
    parsed_map = parse_map(raw_map)
    check_list = []
    if len(parsed_map) == 0:
        invalidate("Invalid substitution map")
    for value in parsed_map.values():
        if value in check_list:
            invalidate("Ambiguity detected, substitution cipher won't work")
        check_list.append(value)


class SubstitutionCipher(EncryptionHandler):
    MESSAGES = {
        'raw_map': "Enter the substitution map (x=y delimited by ';')"
    }
    INIT_VALIDATORS = {
        'raw_map': substitution_validate_map
    }
    TEST_DATA = (["H=M"], {}, "Hello World!")

    def __init__(self, raw_map: str, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.map = parse_map(raw_map)

    def encrypt(self, raw_str: AnyStr) -> AnyStr:
        return raw_str.translate(self.map)

    def decrypt(self, encrypted_str: AnyStr) -> AnyStr:
        return encrypted_str.translate({v: k for k, v in self.map.items()})


class ColumnCipher(EncryptionHandler):
    MESSAGES = {
        'keyword': "Enter the keyword"
    }
    TEST_DATA = (['Nantucket'], {}, "Hello World!")

    def __init__(self, keyword: str, *args, **kwargs):
        super().__init__(*args, **kwargs)
        self.keyword = keyword

    def construct_base_table(self, keyword) -> list[list[str]]:
        return [[x] for x in keyword]

    def construct_table_encryption(self, content: str, base_table: list[list[str]]) -> list[list[str]]:
        current_col = 0
        table = [r.copy() for r in base_table]
        max_col = len(table) - 1
        for character in content:
            if current_col > max_col:
                current_col = 0
            table[current_col].append(character)
            current_col += 1
        if current_col < max_col + 1:
            for col in table[current_col:max_col + 1]:
                col.append('-')
        return table

    def construct_table_decryption(self, content: str, base_table: list[list[str]]) -> list[list[str]]:
        content_list = list(content)
        key_count = len(content) // len(base_table)
        out = []
        for i in range(0, len(content_list), key_count):
            out.append(content_list[i:i + key_count])
        return [base_table[i] + l for i, l in enumerate(out)]

    def flatten_table_encryption(self, table: list[list[str]]) -> str:
        return ''.join([''.join(r[1:]) for r in table])

    def flatten_table_decryption(self, table: list[list[str]]) -> str:
        output_str = ''
        for row in range(len(table[0])):
            output_str += ''.join([col[row] for col in table])
        return output_str

    def encrypt(self, raw_str: AnyStr) -> AnyStr:
        base_table = self.construct_base_table(self.keyword)
        table = self.construct_table_encryption(raw_str, base_table)
        table.sort(key=lambda r: r[0])
        return self.flatten_table_encryption(table)

    def decrypt(self, encrypted_str: AnyStr) -> AnyStr:
        base_table = self.construct_base_table(sorted(self.keyword))
        table = self.construct_table_decryption(encrypted_str, base_table)
        decrypted_table = [None for _ in table]
        iter_keyword = list(self.keyword)
        for col in table:
            i = iter_keyword.index(col[0])
            decrypted_table[i] = col
            iter_keyword[i] = None
        return self.flatten_table_decryption([col[1:] for col in decrypted_table]).replace('-', '')
