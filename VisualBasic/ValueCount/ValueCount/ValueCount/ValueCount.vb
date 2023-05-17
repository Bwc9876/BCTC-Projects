'Program Name: ValueCount
'Programmer  : b_crocker
'Date		 : 3/11/2021 2:19:53 PM
'Purpose     : Tell the users the amount of negatives, positives, and zeroes



Option Strict On

Public Class ValueCount

    Private Function ValidateInput(strInput As String) As String

        If strInput <> "" Then

            Try

                Dim intParsedValue As Integer = Convert.ToInt32(strInput)

                Return "None"

            Catch fe As FormatException

                Return "Must Be A Number!"

            Catch oe As OverflowException

                Return "Too Big!"

            End Try

        Else

            Return "Empty"

        End If

    End Function


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'It loops thorugh as many times as the user wnats asking for values
        'It then shows how many values were above/below zero, aswell as 0s
        'It then displays the results in a label object


        Dim strInput As String

        Dim intNegatives As Integer = 0
        Dim intZeroes As Integer = 0
        Dim intPositives As Integer = 0

        Do

            strInput = InputBox("Enter Next Number", "Input Data")

            Dim strErrors As String = ValidateInput(strInput)

            If strErrors = "None" Then

                Dim intNewValue As Integer = Convert.ToInt32(strInput)

                Select Case intNewValue

                    Case 0

                        intZeroes += 1

                    Case Is < 0

                        intNegatives += 1

                    Case Is > 0

                        intPositives += 1

                End Select

            ElseIf strErrors = "Empty" Then

                Dim mbrWillCancel As MsgBoxResult = MsgBox("Would you like to stop?", MsgBoxStyle.YesNo, "Stop?")

                If mbrWillCancel = MsgBoxResult.Yes Then

                    strInput = ""

                Else

                    strInput = "a"

                End If

            Else

                MsgBox(strErrors,, "Input Error")

            End If

        Loop Until strInput = ""

        lblResults.Text = "Positives: " & intPositives.ToString() & Environment.NewLine &
            " Zeros: " & intZeroes.ToString() & Environment.NewLine &
            " Negatives: " & intNegatives.ToString()


    End Sub

End Class
