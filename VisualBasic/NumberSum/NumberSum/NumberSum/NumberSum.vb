'Program Name: NumberSum
'Programmer  : b_crocker
'Date		 : 3/2/2021 12:39:31 PM
'Purpose     : Gets many numbers from the user and displays the sum of them


Option Strict On

Public Class NumberSum

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'This code is run when the go button is pressed
        'It keeps asking the user for a number until they enter 0
        'At the end, it displays the total number

        Const _cstrCancelString As String = ""
        Dim intNumber As Integer = 1
        Dim intTotal As Integer = 0

        Do Until intNumber <= 0

            Dim strRawNumber As String = InputBox("Enter Number", "Input Data", "1")

            If strRawNumber = _cstrCancelString Then

                intNumber = -1

            Else

                Try

                    intNumber = Convert.ToInt32(strRawNumber)
                    intTotal += intNumber

                Catch fe As FormatException

                    MsgBox("Number must be numeric!",, "Input Error")

                Catch oe As OverflowException

                    MsgBox("Number Too Big!",, "Input Error")

                End Try

            End If

        Loop

        If intNumber <> -1 Then

            lblTotal.Text = "Total: " & intTotal.ToString()

        End If

    End Sub

End Class
