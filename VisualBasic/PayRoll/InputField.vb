Friend Class InputField
    'This is a class I made to make input validation easier and more efficient
    'It inherits a GroupBox, so it can contain any needed Controls within it

    Inherits GroupBox

    Private Property lblErrorText As Label
    Private Property clrNormalColor As Color
    Private Property txtInput As TextBox
    Private Property funValidityHandler As Func(Of InputField, Boolean)
    Private Property blnIsValid As Boolean

    Public Sub New()
        'This code is run whenever an InputField is instantiated
        'It creates a textbox inside of it and centers it
        'It then creates a label that is used to show any errors to the user
        'This label is set to span the entirety of the InputField, and is also set to invisible
        'We then add these controls to the InputField.Controls list

        Size = New Size(150, 90)

        txtInput = New TextBox

        With txtInput

            .Size = New Size(Size.Width - 50, 20)
            .Location = New Point(Size.Width \ 2 - (txtInput.Size.Width \ 2), Size.Height \ 5 + 10)

        End With

        Controls.Add(txtInput)

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

    Public Sub SetValidator(funValidator As Func(Of InputField, Boolean))
        'This code is run to set the function run in order to validate the input
        'It sets the funValidityHandler variable to the passed in function

        funValidityHandler = funValidator

    End Sub

    Public Function GetValue() As String
        'This code is run to get the value from the input field
        'It returns the text within the text box

        Return txtInput.Text

    End Function

    Public Function GetValid() As Boolean
        'This code is run to see if the inputfield is valid or not
        'It returns the blnIsValid variable

        Return blnIsValid

    End Function

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
        'It sets the error text to visible, and sets the text to the passed message
        'It then sets the BackColor of the InputField to red and the label for it to red

        lblErrorText.Visible = True
        lblErrorText.Text = strMessage
        ForeColor = Color.Red

    End Sub

    Private Sub Forgive()
        'This code is executed whenever we want to undo any errors in the InputField 
        'It sets the error text to invisible, and resets the Label and BackColors to the default

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

    Public Sub Empty()
        'This code is run to clear the contents of the inputfield
        'The main difference of this from the clear function is that it doesn't forgive

        txtInput.Clear()

    End Sub

End Class
