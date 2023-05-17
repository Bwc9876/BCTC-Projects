'Program Name: Mulch Calculator
'Programmer:   Ben Crocker
'Date:         10-8-20
'Purpose:      Assist the user in calculating the cost
'              of ordering mulch for a playground


Option Strict On

Public Class frmMulchCalculator

    Private Sub ChangeResultVisibility(blnVisible As Boolean)
        'This code is run to change the visiblity of the results
        'It loops through each control in the grpResults group box
        'And then sets the visibility of the control to the passed in visibility

        For Each Output As Control In grpResults.Controls

            Output.Visible = blnVisible

        Next

    End Sub

    Private Function DimensionIsValid(Field As InputField) As Boolean
        'This code is run to check if the input is valid
        'It first stores the Text property of txtInput in a string and declares a blnValid variable to store whether the input is valid or not
        'First, the program checks to see if the textbox is empty, if it is, the program let's the user know that the input is invalid
        'Next, the program checks to see if the value entered in the textbox is numeric, if it isn't then we need to let the usr know
        'Next, the prorgam attempts to cast the value in txtInput to a decimal
        'If the number is too big, the program makes sure to stop an exception from happening and alerts the user
        'For the final check, the program makes sure that the number isn't negative, if it is, we tell the user
        'If we make it through everything without an error, then that means our input is valid
        'Finally, we return wether or not the input is valid

        Dim blnValid As Boolean = True
        Dim strToCheck As String = Field.strValue

        If strToCheck.Length > 0 Then

            Try

                Dim dblToCheck As Double = Convert.ToDouble(strToCheck)

                If dblToCheck <= 0 Then

                    blnValid = False
                    ChangeResultVisibility(False)
                    Field.InvalidInput("Can't Be Negative!")

                End If

            Catch fe As FormatException

                blnValid = False
                ChangeResultVisibility(False)
                Field.InvalidInput("Must Be Numeric!")

            Catch oe As OverflowException

                blnValid = False
                ChangeResultVisibility(False)
                Field.InvalidInput("Too big!")

            End Try

            Return blnValid

        Else

            blnValid = False
            ChangeResultVisibility(False)
            Field.InvalidInput("Can't be Empty!")

        End If

    End Function

    Private Sub frmMulchCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run everytime the form is loaded
        'It first loops thorugh each InputField in the grpInputs group box
        'It sets the validity handler for the InputField to DimensionIsValid
        'Then, displays the constants to teh suer, to keep them informed

        For Each Field In grpInputs.Controls.OfType(Of InputField)

            Field.funValidityHandler = AddressOf DimensionIsValid

        Next

        lblPricePerFoot.Text = "Price Per Cubic Foot: " & _cdecPricePerFoot.ToString("C")
        lblDeliveryFee.Text = "Delivery Fee: " & _cdecDeliveryFee.ToString("C")

    End Sub

    Const _cdecPricePerFoot As Decimal = 9.87D
    Const _cdecDeliveryFee As Decimal = 25D

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is executed everytime the user clicks the calculate button
        'It first checks if any of the InputFields are invalid, if none ar einvalid, then we an move on
        'It then calculates the volume of the playground
        'Then, it multiplies the volume by the cost per ft³ constant
        'It then adds the delivery fee to the total price
        'Finally, it outputs all of the results and sets the result labels to visible

        Dim blnValid As Boolean = True

        For Each Field As InputField In grpInputs.Controls.OfType(Of InputField)

            Field.Validate()

            If Not Field.blnIsValid Then

                blnValid = False

            End If

        Next

        If blnValid Then

            Dim dblLengthOfPlayground As Double = Convert.ToDouble(grpLength.strValue)
            Dim dblWidthOfPlayground As Double = Convert.ToDouble(grpWidth.strValue)
            Dim dblDepthOfPlayground As Double = Convert.ToDouble(grpDepth.strValue)

            Dim dblVolume As Double = dblLengthOfPlayground * dblWidthOfPlayground * dblDepthOfPlayground
            Dim decSubTotal As Decimal = Convert.ToDecimal(dblVolume * _cdecPricePerFoot)
            Dim decTotal As Decimal = decSubTotal + _cdecDeliveryFee

            lblVolume.Text = dblVolume.ToString("N") & "ft³"
            lblSubTotal.Text = decSubTotal.ToString("C")
            lblTotal.Text = decTotal.ToString("C")

            ChangeResultVisibility(True)

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This codeis executed everytime the user clicks the clear button
        'It loops through each InputField in the grpInputs group box and clears them
        'It then sets all teh result labels to invisible

        For Each Field As InputField In grpInputs.Controls.OfType(Of InputField)

            Field.Clear()

        Next

        ChangeResultVisibility(False)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is executed everytime the user clicks the exit button
        'It exits the program

        Close()

    End Sub

End Class


Public Class InputField
    'This is a class I made to make input validation easier and more efficient
    'It inherits a GroupBox, so it can contain any needed Controls within it

    Inherits GroupBox

    Private Property lblErrorText As Label
    Private Property clrNormalColor As Color
    Private Property txtInput As TextBox

    Public Property clrInvalidColor As Color
    Public Property funValidityHandler As Func(Of InputField, Boolean)
    Public Property blnIsValid As Boolean
    Public Property strValue As String = ""

    Public Sub New()
        'This code is run whenever an InputField is instantiated
        'It creates a textbox inside of it and centers it
        'It then creates a label that is used to show any errors to the user
        'This label is set to span teh entirety of the InputField, and is also set to invisible
        'We then add these controls to the InputField.Controls list

        Size = New Size(150, 90)

        txtInput = New TextBox
        With txtInput

            .Size = New Size(100, 20)
            .Location = New Point(Size.Width \ 2 - (txtInput.Size.Width \ 2), Size.Height \ 5 + 10)

        End With

        Controls.Add(txtInput)

        AddHandler txtInput.TextChanged, AddressOf txtInput_TextChanged

        lblErrorText = New Label
        With lblErrorText

            .AutoSize = False
            .Size = New Size(Size.Width - 20, 20)
            .Location = New Point(10, txtInput.Size.Height + (Size.Height - txtInput.Size.Height) \ 2)
            .Text = "Error Text"
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.Red
            .Visible = False

        End With

        Controls.Add(lblErrorText)

    End Sub

    Public Sub Validate() Handles Me.Leave
        'This code is run to validate the input field
        'It then uses the pre-defined ValidityHandler to check if the InputField is valid
        'It then checks if the inputfield is now valid, if it is, then we can forgive any errors

        blnIsValid = funValidityHandler.Invoke(Me)

        If blnIsValid Then

            Forgive()

        End If

    End Sub

    Public Sub InvalidInput(strMessage As String)
        'This code is run whenever the InputField is deemed invalid
        'It set sthe error text to visible, and sets the text to the passed message
        'It then sets the BackColor of the InputField to red and the label for it to red

        lblErrorText.Visible = True
        lblErrorText.Text = strMessage
        txtInput.BackColor = clrInvalidColor
        ForeColor = Color.Red

    End Sub

    Public Sub Forgive()
        'This code is executed whenever we want to undo any errors in the InputField 
        'It sets the erro text to invisible, and resets the Label and BackColors to the default

        lblErrorText.Visible = False
        txtInput.BackColor = clrNormalColor
        ForeColor = DefaultForeColor

    End Sub

    Public Sub Clear()
        'This code is run whenever the InputField needs to be cleared
        'It first forgives any errors and then clears the InputField

        Forgive()
        txtInput.Clear()

    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs)
        'This code is run everytime the text isnide of txtInput changes
        'It sets the value of strValue to the text inside of txtInput

        strValue = txtInput.Text

    End Sub

End Class
