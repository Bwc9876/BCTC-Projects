'Program Name: Factorial
'Programmer  : b_crocker
'Date		 : 4/19/2021 12:04:14 PM
'Purpose     : Find the factorial of the given number

'Test Cases:
'
' > 1
' < 1
'
' > 3
' < 6
'
' > 7
' < 5040
'


Option Strict On

Public Class Factorial

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'It then loops through 1 to the entered number and multiplies it with inProduct to get the result
        'Finally, it displays the product in the lblResult label

        lstResults.Items.Clear()
        Const _cintGoUntil As Integer = 12

        For intCurrent As Integer = 1 To _cintGoUntil
            Dim intProduct As Integer = 1
            For intNumber As Integer = 1 To intCurrent
                intProduct *= intNumber
            Next
            lstResults.Items.Add(intCurrent.ToString & "! = " & intProduct.ToString())
        Next

    End Sub

End Class
