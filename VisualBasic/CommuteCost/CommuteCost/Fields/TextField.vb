Option Strict On

Public Enum TextType As Integer

    Text
    Money
    Decimal_Point
    Whole

End Enum

Public Class TextField

    'Properties

    Private Property clrNormalColor As Color
    Private Property blnIsValid As Boolean
    Private Property ttyType As TextType
    Private Property intMinChars As Integer = -1
    Private Property intMaxChars As Integer = -1
    Private Property dblMinNumber As Double
    Private Property dblMaxNumber As Double

    'Get Functions

    Public Function GetValue() As String

        Return txtInput.Text

    End Function

    Public Function IsValid() As Boolean

        Return blnIsValid

    End Function

    'Set Functions

    Public Sub SetName(strNewName As String)

        grpField.Text = strNewName

    End Sub

    Public Sub SetType(type As TextType)

        ttyType = type

    End Sub

    Public Sub SetCharMinMax(minChars As Integer, maxChars As Integer)

        intMinChars = minChars
        intMaxChars = maxChars

    End Sub

    Public Sub SetNumberMinMax(minNumber As Double, maxNumber As Double)

        dblMinNumber = minNumber
        dblMaxNumber = maxNumber

    End Sub

    'Reset Functions

    Private Sub Forgive()

        lblErrorText.Visible = False
        txtInput.BackColor = clrNormalColor
        ForeColor = DefaultForeColor
        txtInput.BackColor = Color.White

    End Sub

    Public Sub Clear()

        Forgive()
        txtInput.Clear()

    End Sub

    Public Sub Empty()

        txtInput.Clear()

    End Sub

    'Events

    Private Sub Me_Layout() Handles Me.Layout

        With txtInput

            .Size = New Size(Size.Width - 50, 20)
            .Location = New Point(Size.Width \ 2 - (txtInput.Size.Width \ 2), Size.Height \ 5 + 10)

        End With

        With lblErrorText

            .AutoSize = False
            .Size = New Size(Size.Width - 20, 20)
            .Location = New Point(10, txtInput.Size.Height + (Size.Height - txtInput.Size.Height) \ 2)
            .Text = "Error Text"
            .TextAlign = ContentAlignment.MiddleCenter
            .ForeColor = Color.Red
            .BackColor = BackColor
            .Visible = False

        End With

        With grpField

            .Size = Me.Size

        End With

    End Sub

    'Validation

    Private Sub ValidateForText()

        Dim strValue As String = GetValue()

        If Validators.IsntEmpty(strValue) Then

            If Validators.InCharRange(strValue, intMinChars, intMaxChars) Then

                blnIsValid = True

            Else

                InvalidInput("Too Short/Long!")

            End If
        Else

            InvalidInput("Can't Be Empty!")

        End If
    End Sub

    Private Sub InvalidInput(strMessage As String)

        blnIsValid = False
        lblErrorText.Visible = True
        lblErrorText.Text = strMessage
        ForeColor = Color.Red
        txtInput.BackColor = Color.LightPink

    End Sub

    Private Sub ValidateForNumber(Optional blnForceWhole As Boolean = False)

        Dim strValue As String = GetValue()
        ValidateForText()

        If blnIsValid Then

            Dim strReason As String = ""

            If Validators.CanConvert(ttyType, strValue, strReason, blnForceWhole) Then

                If Validators.InNumberRange(strValue, ttyType, dblMinNumber, dblMaxNumber) Then

                    blnIsValid = True

                Else

                    InvalidInput("Not In Range!")

                End If

            Else

                InvalidInput(strReason & "!")

            End If

        End If

    End Sub

    Public Overloads Sub Validate() Handles Me.Leave

        If ttyType = TextType.Text Then

            ValidateForText()

        Else

            ValidateForNumber(ttyType = TextType.Whole)

        End If

        If blnIsValid Then

            Forgive()

        End If

    End Sub

End Class
