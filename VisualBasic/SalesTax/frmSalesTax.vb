'Program Name: Sales Tax Calculator
'Developer:    Ben Crocker
'Date:         10-1-20
'Purpose:      Calculate the tax for an item
'              and display the total cost

Option Strict On

Public Class frmSalesTax

    Private Property blnNameIsValid As Boolean = False
    Private Property blnPriceIsValid As Boolean = False

    Private Sub ChangeOutputVisibility(blnVisible As Boolean)
        'This code is used so I can change the visibility of all the output labels at once
        'It takes an argument of blnVisible and sets the visible property of all output labels to it
        'It also sets the hint label to the oppisite of blnVisible

        lblCostLabel.Visible = blnVisible
        lblCost.Visible = blnVisible
        lblTaxLabel.Visible = blnVisible
        lblTax.Visible = blnVisible
        lblTotalLabel.Visible = blnVisible
        lblTotal.Visible = blnVisible
        lblHint.Visible = Not blnVisible

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run when the user clicks the exit button or presses escape
        'It exits the program

        Close()

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is clicked
        'It first sets all of the output labels' visiblity to false
        'It then clears the name and price inputs
        'Then, it makes the NameError label and Error label to not visible
        'Then, it disables the calculate button
        'Finally, it sets both of the isValid booleans for name and price to False

        ChangeOutputVisibility(False)
        txtName.Clear()
        txtPrice.Clear()
        lblPriceError.Visible = False
        lblNameError.Visible = False
        blnNameIsValid = False
        blnPriceIsValid = False
        btnCalculate.Enabled = False

    End Sub


    Private Sub ErrorMessage(strMessage As String)
        'This code is run whenever the user enters an invalid price
        'It first sets the text of lblError to the message, and makes the label visible
        'It then makes blnPriceIsValid variable false
        'Then, it disables the calculate button
        'Finally, it sets the visibility of the output variables to False

        lblPriceError.Text = strMessage
        lblPriceError.Visible = True
        blnPriceIsValid = False
        btnCalculate.Enabled = False
        ChangeOutputVisibility(False)

    End Sub

    Const _cintMaxCharacters As Integer = 13

    Private Sub txtName_Leave(sender As Object, e As EventArgs) Handles txtName.Leave
        'This code is run whenever the user goes off of txtName
        'It first gets the value of txtName.Text and stores it in a string
        'It then checks if the string is empty, if it is, it will tell the user
        'If  it makes it past the empty check, then the input is valid
        'We then set the boolean NameIsValid to true and hide the error label
        'Finally we check if the price input is valid, if it is, then both inputs are valid and we can enable the calculate button

        Dim strName As String = txtName.Text

        If strName.Length > 0 And strName.Length < _cintMaxCharacters Then

            blnNameIsValid = True
            lblNameError.Visible = False

            If blnPriceIsValid Then

                btnCalculate.Enabled = True

            End If

        Else

            lblNameError.Text = "Must Be 0-" & _cintMaxCharacters.ToString() & " Letters!"
            lblNameError.Visible = True
            btnCalculate.Enabled = False
            blnNameIsValid = False
            ChangeOutputVisibility(False)

        End If


    End Sub

    Private Sub txtPrice_Leave(sender As Object, e As EventArgs) Handles txtPrice.Leave
        'This code is run whenever the user goes off of txtPrice
        'It first stores the Text property of txtPrice in a string and declares a decPrice variable for later
        'First, the program checks to see if the textbox is empty, if it is, the program let's the user know that the input is invalid
        'Next, the program checks to see if the value entered in the textbox is numeric, if it isn't then we need to let the usr know
        'Next, the prorgam attempts to cast the value in txtPrice to a decimal
        'If the number is too big, the program makes sure to stop an exception from happening and alerts the user
        'For the final check, the program makes sure that the number isn't negative, if it is, we tell the user
        'If we make it through everything without an error, then that means our input is valid
        'We set the boolean blnPriceIsValid to true to reflect this and set the error label to invisible
        'Finally, we check to see if the Name Input is valid, if it is, then both of the inputs are valid and we can enable the calculate button

        Dim strPrice As String = txtPrice.Text
        Dim decPrice As Decimal

        If strPrice.Length > 0 Then

            If IsNumeric(strPrice) Then

                Try

                    decPrice = Convert.ToDecimal(strPrice)

                    If decPrice > 0 Then

                        blnPriceIsValid = True
                        lblPriceError.Visible = False

                        If blnNameIsValid Then

                            btnCalculate.Enabled = True

                        End If

                    Else

                        ErrorMessage("Value must be positive!")

                    End If

                Catch oe As OverflowException

                    ErrorMessage("Value is too big!")

                End Try

            Else

                ErrorMessage("Value must be numeric!")

            End If

        Else

            ErrorMessage("Value Can't Be Empty!")

        End If

    End Sub


    Const _cdblSalesTax As Double = 8.75

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is executed everytime the user clicks the calculate button
        'We are confident that this will work without error because all input needs to be valid before this button can be clicked
        'We first get the Name and Price values from their textboxes, and convert the price value into a Decimal
        'We then perform the calculations to determine the tax and total for the item
        'Then, we check to see if the item name starts with a vowel, if it does, then we need an "an" instead of a "a"
        'We then put the item name into the output label's labels
        'Then we set the values of the output labels to our outputs from our calculations
        'Finally, we set all the output labels to visible

        If (blnNameIsValid And blnPriceIsValid) Then

            Dim strName As String = txtName.Text
            Dim strPrice As String = txtPrice.Text
            Dim decPrice As Decimal = Convert.ToDecimal(strPrice)

            Dim decTax As Decimal = Convert.ToDecimal(decPrice * (_cdblSalesTax / 100))
            Dim decTotal As Decimal = decTax + decPrice

            Dim chrFirstLetter As Char = GetChar(strName.ToLower(), 1)
            Dim strArticle As String = If({"a", "e", "i", "o", "u"}.Contains(chrFirstLetter), " An ", " A ")

            lblCostLabel.Text = "The Price Of" & strArticle & strName & ":"
            lblTaxLabel.Text = "The Tax For" & strArticle & strName & ":"
            lblTotalLabel.Text = "The Total For" & strArticle & strName & ":"

            lblCost.Text = decPrice.ToString("C")
            lblTax.Text = decTax.ToString("C")
            lblTotal.Text = decTotal.ToString("C")

            ChangeOutputVisibility(True)

        End If

    End Sub

    Private Sub btnCalculate_EnabledChanged(sender As Object, e As EventArgs) Handles btnCalculate.EnabledChanged
        'This code is executed whenever the calculate button is enabled/disabled
        'It changes the color of the button to signify if it's enabled/disabled

        Dim clrCalculateEnabledColor As Color = Color.FromArgb(231, 100, 41)
        btnCalculate.BackColor = If(btnCalculate.Enabled, clrCalculateEnabledColor, Color.Gray)

    End Sub

    Private Sub frmSalesTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is executed whenever the form is open/loaded
        'It displays the current sales tax for the user

        lblSalesTax.Text = "The Current Sales Tax Is: " & _cdblSalesTax.ToString("N") & "%"

    End Sub

End Class
