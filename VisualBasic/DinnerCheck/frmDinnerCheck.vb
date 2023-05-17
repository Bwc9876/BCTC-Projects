'Program Name: Dinner Check
'Programmer:   Ben Crocker
'Date:         9/24/20
'Purpose:      Assist the user in calculating various
'              expenses when they pay for dinner.


Option Strict On


Public Class frmDinnerCheck

    Private Property _cclrFieldColor As Color = Color.Honeydew
    Private Property _cclrFieldInvalidColor As Color = Color.LightPink

    Private Sub ErrorMessage(strMessage As String, txtOffender As TextBox)
        'This code is run whenever the user makes an error while typing in their values
        'It first sets the backColor of the textbox with the invalid value to red
        'It then sets the lblError's text to the error message and shows the error text

        txtOffender.BackColor = _cclrFieldInvalidColor
        lblError.Visible = True
        lblError.Text = strMessage

    End Sub

    Private Sub ReleaseError()
        'This code is run to undo any changes that an error may have done to the form
        'It first sets the backColors of all TextBoxes back to the default to get rid of any red ones
        'It Then hides the error text again

        txtDinner1.BackColor = _cclrFieldColor
        txtDinner2.BackColor = _cclrFieldColor
        txtDinner3.BackColor = _cclrFieldColor
        txtPercentTip.BackColor = _cclrFieldColor
        lblError.Visible = False

    End Sub

    Private Function TextCheck(txtToCheck As TextBox) As Decimal
        'This code is run to test the input of a textBox to see if we can confidently calculate it without error
        'It first establishes the output variable, and then checks if the field is empty, if it is, the form sends an error to the user
        'It then checks to see if the textBox's value is numeric, or can be made inot a number, if it isn't then we cant' calculate with it, so we show another error
        'Then, It converts the value of the textBox to a Decimal and checks if said decimal is negative, we shouldn't have negative anything in this, so if it is negative, we show an error
        'Finally, If the function ran all the way thorugh, then that means we are confident that the value will work in our calculation, so we return said value

        Dim decDinnerCost As Decimal

        If (txtToCheck.Text = "") Then

            ErrorMessage("Value can't be empty!", txtToCheck)
            Return -1

        End If

        If (IsNumeric(txtToCheck.Text)) Then

            Try

                decDinnerCost = Convert.ToDecimal(txtToCheck.Text)

            Catch o As OverflowException

                ErrorMessage("Value is too big!", txtToCheck)
                Return -1

            End Try

        Else

            ErrorMessage("Value must be numeric!", txtToCheck)
            Return -1

        End If

        If (decDinnerCost < 0) Then

            ErrorMessage("Value can't be negative!", txtToCheck)
            Return -1

        End If

        Return decDinnerCost

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is run whenever the calculate button is hit or the user presses enter
        'It first undoes any errors already shown in the form
        'It then creates variables and sets them to the output of TextCheck
        'Then, it checks to see if any of the values are -1, if they are, then an error has occured and we should stop runnning the Sub
        'Then, it establishes output variables to store answers of certain calculations
        'It then does the calculation for TotalDinnerCost, TotalTip, TotalBill, and AmountPerPerson
        'It then sets the text value of the output labels to a currency string version of the output variables
        'Finally, it sets all the output labels to visible so the users can see their answers

        ReleaseError()

        Dim decDinner1Cost As Decimal = TextCheck(txtDinner1)
        Dim decDinner2Cost As Decimal = TextCheck(txtDinner2)
        Dim decDinner3Cost As Decimal = TextCheck(txtDinner3)
        Dim decPercentTip As Decimal = TextCheck(txtPercentTip)

        If {decDinner1Cost, decDinner2Cost, decDinner3Cost, decPercentTip}.Contains(-1) Then
            Return
        End If

        Dim decTotalDinnerCost As Decimal
        Dim decTotalTip As Decimal
        Dim decTotalBill As Decimal
        Dim decAmountPerPerson As Decimal

        decTotalDinnerCost = decDinner1Cost + decDinner2Cost + decDinner3Cost
        decTotalTip = decTotalDinnerCost * (decPercentTip / 100)
        decTotalBill = decTotalTip + decTotalDinnerCost
        decAmountPerPerson = decTotalBill / 3

        lblCostPerPerson.Text = decAmountPerPerson.ToString("C")
        lblTotalBill.Text = decTotalBill.ToString("C")
        lblTotalTip.Text = decTotalTip.ToString("C")
        lblDinnerSum.Text = decTotalDinnerCost.ToString("C")

        lblCostPerPerson.Visible = True
        lblTotalBill.Visible = True
        lblTotalTip.Visible = True
        lblDinnerSum.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run whenever the user clicks the exit button
        'It exits the program

        Close()

    End Sub

End Class

