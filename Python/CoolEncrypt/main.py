"""
    Name: CoolEncrypt
    Programmer: Ben Crocker
    Date: 3/23/22
    Purpose: Encrypt and Decrypt data
"""

import argparse
import sys
from inspect import getmembers, isclass, signature
from typing import AnyStr

import ciphers
import console.inputs
from cipher_inputs import CipherTextInput, CipherFileInput
from console.output import FourBitConsoleColors, ConsoleTextStyle, color_text
from enums import EncryptionMode, SourceType

SELECTION_PROMPT = console.inputs.SelectionInput(console.inputs.SelectionInputOptions(cancel_codes=[]))
FILE_INPUT_OPTIONS = {'require_exists': True, 'exists_ok': True, 'required_perms': console.inputs.os.R_OK,
                      'cancel_codes': []}
FILE_SAVE_INPUT = console.inputs.FileInput(
    console.inputs.FileInputOptions(require_exists=False, exists_ok=True, required_perms=console.inputs.os.W_OK,
                                    cancel_codes=[]))
SUCCESS_STYLE = ConsoleTextStyle(fg_color=FourBitConsoleColors.GREEN, bold=True)
QUITTING_STYLE = ConsoleTextStyle(fg_color=FourBitConsoleColors.RED, bold=True)
QUIT_PROMPT = console.inputs.BooleanInput(console.inputs.BooleanInputOptions(cancel_codes=[]))
AVAILABLE_HANDLERS = [cls[1] for cls in getmembers(ciphers, isclass) if
                      issubclass(cls[1], ciphers.EncryptionHandler) and cls[1] != ciphers.EncryptionHandler]
HANDLER_NAME_TO_CLS = {str(h): h for h in AVAILABLE_HANDLERS}

def print_success(msg: str, after: str = '') -> None:
    print(color_text(msg, SUCCESS_STYLE), after)


def prompt_for_encryption_mode() -> EncryptionMode:
    result, selected_mode = SELECTION_PROMPT("What would you like to do?", ("Encrypt", "Decrypt"))
    if result == console.inputs.InputResult.SUCCESS:
        return EncryptionMode(selected_mode)
    else:
        return None


def prompt_for_source_type() -> SourceType:
    result, selected_source = SELECTION_PROMPT("What would you like to encrypt?", ("Input", "File"))
    if result == console.inputs.InputResult.SUCCESS:
        return SourceType(selected_source)
    else:
        return None


def prompt_for_handler() -> type(ciphers.EncryptionHandler):
    result, selected_handler = SELECTION_PROMPT("What cipher would you like to use?", AVAILABLE_HANDLERS)
    if result == console.inputs.InputResult.SUCCESS:
        return AVAILABLE_HANDLERS[selected_handler]
    else:
        return None


def prompt_for_cipher(handler: type(ciphers.EncryptionHandler)) -> ciphers.EncryptionHandler:
    args = []
    for param in signature(handler.__init__).parameters.values():
        if param.name not in ("self", "args", "kwargs"):
            prompt = console.inputs.TYPE_MAPPINGS[param.annotation.__name__]
            if param.name in handler.INIT_VALIDATORS.keys():
                prompt.options.additional_validation = handler.INIT_VALIDATORS[param.name]
            args.append(prompt(handler.MESSAGES.get(param.name, param.name))[1])
            prompt.options.additional_validation = lambda x, y: None
    return handler(*args)


def prompt_for_source(verb: str, mode: EncryptionMode, source_type: SourceType,
                      cipher: ciphers.EncryptionHandler) -> AnyStr:
    if source_type == SourceType.FILE:
        options = console.inputs.FileInputOptions(**FILE_INPUT_OPTIONS)
        file_input = CipherFileInput(cipher, mode == EncryptionMode.DECRYPT, options)
        return file_input(f"Enter the path to the file to {verb}")[1].read_text()
    elif source_type == SourceType.STRING:
        message_input = CipherTextInput(cipher, mode == EncryptionMode.DECRYPT, console.inputs.BaseInputOptions())
        return message_input(f"Enter the message to {verb}")[1]
    else:
        return None


def get_output(cipher: ciphers.EncryptionHandler, mode: EncryptionMode, source: str) -> str:
    if mode == EncryptionMode.DECRYPT:
        return cipher.decrypt(source)
    elif mode == EncryptionMode.ENCRYPT:
        return cipher.encrypt(source)
    else:
        return None


def output_data(source: str | console.inputs.Path, output: AnyStr, verb: str, source_type: SourceType):
    if source_type == SourceType.STRING:
        print_success(f"Your {verb}ed message is:", after=output)
    elif source_type == SourceType.FILE:
        with source.open(mode='w+', encoding='utf-8') as file:
            file.write(output)
        print_success(f"Your newly {verb}ed file has been saved")


def main_loop():
    mode = prompt_for_encryption_mode()
    verb = 'decrypt' if mode == EncryptionMode.DECRYPT else 'encrypt'
    source_type = prompt_for_source_type()
    handler = prompt_for_handler()
    cipher = prompt_for_cipher(handler)
    source = prompt_for_source(verb, mode, source_type, cipher)
    output = get_output(cipher, mode, source)
    output_data(source, output, verb, source_type)


def main():
    should_quit = False
    while should_quit is False:
        main_loop()
        _, should_quit = QUIT_PROMPT("Would you like to quit?")
    print(color_text("Quitting...", QUITTING_STYLE))


def get_arg_parser():
    arg_parser = argparse.ArgumentParser(description="Encrypt or decrypt a message", epilog="Type 'main.py {cipher} --help' for help with a specific cipher")

    subparser = arg_parser.add_subparsers(title='cipher', dest='cipher', metavar='cipher')
    for handler in AVAILABLE_HANDLERS:
        cipher_parser = subparser.add_parser(str(handler).replace(' ', ''), help=f"{str(handler)} help")
        for param in signature(handler.__init__).parameters.values():
            if param.name not in ('self', 'args', 'kwargs'):
                cipher_parser.add_argument(param.name, help=handler.MESSAGES.get(param.name, ''), type=param.annotation)
        cipher_parser.add_argument('message')

    arg_parser.add_argument('-l, -ls, --list', dest='list', action='store_true', help="List all available ciphers")

    return arg_parser


if __name__ == '__main__':
    parser = get_arg_parser()
    try:
        if len(sys.argv) == 1:
            main()
        else:
            args = parser.parse_args()
            if args.list is True:
                print('\n'.join([str(h).replace(' ', '') for h in AVAILABLE_HANDLERS]))
            else:
                init_kwargs = []
                handler = HANDLER_NAME_TO_CLS[args.cipher]
                for param in signature(handler.__init__).parameters.values():
                    if param not in ('self', 'args', 'kwargs', 'message'):
                        init_kwargs[param.name] = getattr()
                cipher = HANDLER_NAME_TO_CLS[args.cipher]
    except KeyboardInterrupt:
        color_text("^C Received, Exiting...", QUITTING_STYLE)
