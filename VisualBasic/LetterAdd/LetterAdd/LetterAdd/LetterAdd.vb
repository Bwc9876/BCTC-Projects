'Program Name: LetterAdd
'Programmer  : b_crocker
'Date		 : 3/2/2021 12:50:35 PM
'Purpose     : Displays a string of entered letters


Option Strict On

Public Class LetterAdd

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'This code is run when the go button is pressed
        'It keeps asking the user for a lowecase letter
        'Once the user enters anything elese, it displays a string with every letter entered

        Const _cstrCancel As String = ""
        Dim chrCurrentCharacter As Char = "a"c
        Dim strTotalString = ""

        Do

            Try

                Dim strRawLetter As String = InputBox("Enter Lowercase Letter", "Input Data", "a")

                If strRawLetter = _cstrCancel Then

                    chrCurrentCharacter = "&"c

                Else

                    chrCurrentCharacter = Convert.ToChar(strRawLetter)

                    If chrCurrentCharacter >= "a"c And chrCurrentCharacter <= "z"c Then

                        strTotalString &= chrCurrentCharacter.ToString()

                    End If

                End If

            Catch fe As FormatException

                MsgBox("Must be a SINGLE letter!",, "Input Error")

            End Try

        Loop While chrCurrentCharacter >= "a"c And chrCurrentCharacter <= "z"c

        If chrCurrentCharacter <> "&"c Then

            lblResult.Text = "Result: " & strTotalString

        End If

    End Sub

End Class
