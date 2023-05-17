'Program Name: Kitchen Paint
'Programmer:   Ben Crocker
'Date:         9/27/20
'Purpose:      Assist the user in finding the cost
'              of painting their kitchen walls

'Test Case:    Kitchen Dimensions: 11*15*9
'              Cost / Gallon:      22.39
'              Coverage:           320

Option Strict On

Public Class frmKitchenPaint

    Private FieldColor As Color = Color.LightCyan
    Private FieldInvalidColor As Color = Color.LightPink

    Private Sub ErrorMessage(strMessage As String, txtOffender As TextBox)
        'This code is run whenever the user's input is invalid
        'It sets the text of the error label to the error message
        'Then it makes the error label visible
        'It then sets the textbox with invalid input's BackColor to pink
        'Finally, it hides all of the output labels

        lblError.Text = strMessage
        lblError.Visible = True
        txtOffender.BackColor = FieldInvalidColor
        lblSurfaceArea.Visible = False
        lblGallons.Visible = False
        lblTax.Visible = False
        lblTotal.Visible = False

    End Sub

    Private Sub UndoError()
        'This code is run to get rid of the error message on the form
        'It first hides the error label
        'It then sets the BackColor of all input fields to Light Cyan

        lblError.Visible = False
        txtCeilingHeight.BackColor = FieldColor
        txtFloorLength.BackColor = FieldColor
        txtFloorWidth.BackColor = FieldColor
        txtGallonPrice.BackColor = FieldColor
        txtCoverage.BackColor = FieldColor

    End Sub

    Private Function TextCheck(txtToCheck As TextBox) As Double
        'This code is used to get and check the input from a textbox
        'It first initializes a double to store the output
        'It then gets the text in the textbox and stores it in strInput
        'Now we can start checking the input
        'We first check if it's empty, if it is we alert the user
        'We then check if the value is numeric, if it isn't we alert the user
        'Then, we see if the number is going to be too big, if it is, we alert the user
        'Finally, we check if the number is negative, if it is, we alert the user
        'If we were able to make it through the entire function, that means the input is valid and we can pass it back

        Dim dblOutput As Double
        Dim strInput As String = txtToCheck.Text

        If strInput.Length > 0 Then

            If IsNumeric(txtToCheck.Text) Then

                Try

                    dblOutput = Convert.ToDouble(strInput)

                    If dblOutput <= 0 Then

                        ErrorMessage("Value Must be Over Zero!", txtToCheck)

                        dblOutput = -1

                    End If

                Catch oe As OverflowException

                    ErrorMessage("Value is too big!", txtToCheck)

                    dblOutput = -1

                End Try

            Else

                ErrorMessage("Value Must Be Numeric!", txtToCheck)

                dblOutput = -1

            End If

        Else

            ErrorMessage("Value Can't Be Empty!", txtToCheck)

            dblOutput = -1

        End If

        Return dblOutput

    End Function


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is executed when the calculate button is clicked or the enter button is pressed
        'It first undoes any errors currently in the form
        'Then, it gets and checks the value of each input textbox
        'Now we check to see if the procust of all values is greater than 0, if it is, then we continue with our code
        'We are now confident that the values will work in our arithmetic
        'Now we perform calculations to find the various outputs we need, and store them in output variables
        'Then, we set the text of the output textboxes to their respective output variables
        'Finally, we set all the output textboxes to be visible

        Const _cdblSalesTax As Double = 0.06

        UndoError()

        Dim dblFloorLength As Double = TextCheck(txtFloorLength)
        Dim dblFloorWidth As Double = TextCheck(txtFloorWidth)
        Dim dblCeilingHeight As Double = TextCheck(txtCeilingHeight)
        Dim decGallonPrice As Decimal = Convert.ToDecimal(TextCheck(txtGallonPrice))
        Dim intCoverage As Integer = Convert.ToInt32(TextCheck(txtCoverage))

        If dblCeilingHeight * dblFloorLength * dblFloorWidth * decGallonPrice * intCoverage > 0 Then

            Dim dblSurfaceArea As Double = (dblFloorWidth * dblCeilingHeight * 2) + (dblFloorLength * dblCeilingHeight * 2)
            Dim intGallons As Integer = Convert.ToInt32(CLng(dblSurfaceArea) \ intCoverage)

            If dblSurfaceArea Mod intCoverage > 0 Then

                intGallons += 1

            End If

            Dim decPrice As Decimal = intGallons * decGallonPrice
            Dim decTax As Decimal = Convert.ToDecimal(decPrice * _cdblSalesTax)
            Dim decTotal As Decimal = decPrice + decTax


            lblSurfaceArea.Text = dblSurfaceArea.ToString("N0") & " ft²"
            lblGallons.Text = intGallons.ToString("N0") & " Gallons"
            lblTax.Text = decTax.ToString("C")
            lblTotal.Text = decTotal.ToString("C")

            lblSurfaceArea.Visible = True
            lblGallons.Visible = True
            lblTax.Visible = True
            lblTotal.Visible = True

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is executed whenever the user hits the exit button or the escape button is pressed
        'It exits the program

        Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is executed whenever the user clicks the clear button
        'It clears all values in the input fields, hides the output labels, and undoes any shown errors

        txtFloorLength.Clear()
        txtFloorWidth.Clear()
        txtCeilingHeight.Clear()
        txtGallonPrice.Clear()
        txtCoverage.Clear()

        lblSurfaceArea.Visible = False
        lblGallons.Visible = False
        lblTax.Visible = False
        lblTotal.Visible = False

        UndoError()

    End Sub

End Class
