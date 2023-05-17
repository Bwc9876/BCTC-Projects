from inspect import getmembers, isclass

import ciphers

CIPHERS_TO_TEST = [cls[1] for cls in getmembers(ciphers, isclass) if
                   issubclass(cls[1], ciphers.EncryptionHandler) and cls[1] != ciphers.EncryptionHandler]


class TestCipherMeta(type):

    def __new__(mcs, name, bases, namespace, **kwargs):
        for cipher in CIPHERS_TO_TEST:
            def test_func():
                test_data = cipher.TEST_DATA
                i_cipher = cipher(*test_data[0], **test_data[1])
                assert test_data[2] == i_cipher.decrypt(i_cipher.encrypt(test_data[2]))

            namespace[f'test_{cipher.__name__.lower()}'] = staticmethod(test_func)
        return super(TestCipherMeta, mcs).__new__(mcs, name, bases, namespace, **kwargs)


class TestCiphers(metaclass=TestCipherMeta):
    pass
