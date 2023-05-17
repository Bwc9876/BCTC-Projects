from enum import IntEnum


class EncryptionMode(IntEnum):
    ENCRYPT = 0
    DECRYPT = 1


class SourceType(IntEnum):
    STRING = 0
    FILE = 1
