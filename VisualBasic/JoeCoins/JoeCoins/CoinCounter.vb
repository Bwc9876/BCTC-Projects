'Program Name: Coin Counter
'Programmer:   Ben Crocker
'Date:         10/27/20
'Purpose:      Count the number of coins an amount of pennies are worth


' Test Cases:
'
'
'   Input: 
'       2311
'
'   Output:
'       23 Dollars
'       1 Dime
'       3 Pennies
'
'
'   Input: 
'       7333
'
'   Output:
'       73 Dollars
'       1 Quarter
'       1 Nickels
'       3 Pennies

Option Strict On

Public Class CoinCounter

    Private Sub btnCountCoins_Click(sender As Object, e As EventArgs) Handles btnCountCoins.Click
        'This code is run whenever the CountCoins button is clicked
        'It first validates txtPennies
        'It then gets the number of pennies from strPennies
        'Then, it loops through each key in the dictionary: 
        '   It First checks to see how many pennies can make the coin 
        '   Finally, it adds the result to the output
        'Then, it adds the amount of pennies left, if any to the output
        'Finally, it displays the output in the lblCoins label

        Dim strPennies As String = txtPennies.Text

        If strPennies.Length > 0 Then

            If IsNumeric(strPennies) Then

                Dim intPennies As Integer = Convert.ToInt32(strPennies)
                Dim intDollars As Integer = 0
                Dim intQuarters As Integer = 0
                Dim intDimes As Integer = 0
                Dim intNickels As Integer = 0

                intDollars = intPennies \ 100
                Dim intDollarRemainder As Integer = intPennies Mod 100
                intPennies -= intDollars * 100

                If intDollarRemainder > 0 Then

                    intQuarters = intPennies \ 25
                    Dim intQuarterRemainder As Integer = intPennies Mod 25
                    intPennies -= intQuarters * 25

                    If intQuarterRemainder > 0 Then

                        intDimes = intPennies \ 10
                        Dim intDimeRemainder As Integer = intPennies Mod 10
                        intPennies -= intDimes * 10

                        If intDimeRemainder > 0 Then

                            intNickels = intPennies \ 5
                            intPennies -= intNickels * 5

                        End If

                    End If

                End If

                lblCoinCount.Text = $"Dollars: {intDollars}" & Environment.NewLine & $"Quarters: {intQuarters}" & Environment.NewLine & $"Dimes: {intDimes}" & Environment.NewLine _
                    & $"Nickels: {intNickels}" & Environment.NewLine & $"Pennies: {intPennies}"

            Else

                MsgBox("Pennies must be numeric!")

            End If

        Else

            MsgBox("Pennies can't be empty!")

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed
        'It clears the form

        txtPennies.Clear()
        lblCoinCount.Text = "Coins will appear here"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run whenever the user clicks the exit button
        'It exits the program

        Close()

    End Sub

End Class
