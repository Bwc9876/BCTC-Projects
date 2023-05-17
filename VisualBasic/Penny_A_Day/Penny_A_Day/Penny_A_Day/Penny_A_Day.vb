'Program Name: Penny_A_Day
'Programmer  : b_crocker
'Date		 : 4/16/2021 1:05:40 PM
'Purpose     : Given the amount of days, and initial pay, calculate a users total pay

'Test Cases:
'
' > 19
' > Penny
' < $7.41
'
' > 16
' > Nickel
' < $52.80


Option Strict On

Public Class Penny_A_Day

    Dim _cintMinimumDaysForPenny As Integer = 19
    Dim _cintMinimumDaysForNickel As Integer = 16
    Dim _cintMaximumDaysForBoth As Integer = 22

    Private Function CleanInput(strInputString As String) As Integer

        If strInputString = "" Then

            Dim resUserCancel As MsgBoxResult = MsgBox("Would You Like To Cancel?", MsgBoxStyle.YesNo, "Cancel?")

            If resUserCancel = MsgBoxResult.Yes Then

                Return -2

            Else

                Return -1

            End If

        Else

            Try

                Dim intConvertedInput As Integer = Convert.ToInt32(strInputString)

                If radPenny.Checked And intConvertedInput < _cintMinimumDaysForPenny Then

                    MsgBox("Must Be Over " & _cintMinimumDaysForPenny.ToString(),, "Input Error")
                    Return -1

                ElseIf intConvertedInput < _cintMinimumDaysForNickel Then

                    MsgBox("Must Be Over " & _cintMinimumDaysForNickel.ToString(),, "Input Error")
                    Return -1

                End If

                If intConvertedInput > _cintMaximumDaysForBoth Then

                    MsgBox("Must Be Under " & _cintMaximumDaysForBoth.ToString(),, "Input Error")
                    Return -1

                Else

                    Return intConvertedInput

                End If

            Catch fe As FormatException

                MsgBox("Input must be a number!",, "Input Error")
                Return -1

            Catch oe As OverflowException

                MsgBox("Input Too Big",, "Input Error")
                Return -1

            End Try

        End If

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'It then makes sure if we have penny selected, the day is high enough
        'It then loops through, ddoubling and adding the pay to decTotalPay
        'Finally, it displays the total pay in the lblResult label

        Dim intDaysWorked As Integer = -1
        Dim intMin As Integer = If(radPenny.Checked, _cintMinimumDaysForPenny, _cintMinimumDaysForNickel)

        Do Until intDaysWorked <> -1

            Dim strDaysWorked As String = InputBox("Enter Work Period (" & intMin.ToString() & "-" & _cintMaximumDaysForBoth.ToString() & ")", "Enter Value", "20")
            intDaysWorked = CleanInput(strDaysWorked)

        Loop

        If intDaysWorked = -2 Then

            ClearToolStripMenuItem.PerformClick()

        Else

            Dim decInitialPay As Decimal = If(radPenny.Checked, 0.01D, 0.1D)
            Dim decTotalPay As Decimal = decInitialPay

            For intDay As Integer = 2 To intDaysWorked * 2

                decTotalPay += decInitialPay * Convert.ToDecimal(intDay)

            Next

            lblResult.Text = decTotalPay.ToString("c")
            btnSubmit.Enabled = False

        End If


    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'This code is run whenever the clear button is pressed

        lblResult.Text = "Result Will Appear Here"
        btnSubmit.Enabled = True


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()
    End Sub

End Class
