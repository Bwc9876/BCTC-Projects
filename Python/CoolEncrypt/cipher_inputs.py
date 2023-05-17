import ciphers
import console.inputs


class CipherTextInput(console.inputs.BaseInput):
    """
        Handles taking cipher text

        :ivar cipher: the cipher to validate with
        :ivar mode: True if decrypting, False if encrypting
    """

    def __init__(self, cipher, mode, *args, **kwargs):
        """
            Initializes the input
        """

        self.cipher = cipher
        self.mode = mode
        super().__init__(*args, **kwargs)
        self.options.errors['cipher'] = '{message}'

    def _validate(self, raw_str: str) -> None:
        """
            Validates the given text against the cipher to make sure the cipher can process it

            :param raw_str: raw string to validate
        """

        try:
            self.cipher.validate(raw_str, self.mode)
        except ciphers.CipherError as e:
            self._invalidate('cipher', message=str(e))


class CipherFileInput(console.inputs.FileInput):
    """
        Handles validating file content against a cipher

        :ivar cipher: The cipher to validate against
        :ivar mode: True if decrypting, False if encrypting
    """

    def __init__(self, cipher, mode, *args, **kwargs):
        """
            Initialize the input
        """

        super().__init__(*args, **kwargs)
        self.cipher = cipher
        self.mode = mode
        self.options.errors['cipher'] = '{message}'

    def _validate(self, raw_str: str) -> None:
        """
            Validates a given file path against the cipher to ensure that the cipher can process the file

            :param raw_str: The path to the file to check
        """

        super(CipherFileInput, self)._validate(raw_str)
        content = console.inputs.Path(raw_str).read_text()
        try:
            self.cipher.validate(content, self.mode)
        except ciphers.CipherError as e:
            self._invalidate('cipher', message=str(e))
