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
    Private Property intMinChars As Integer = 0
    Private Property intMaxChars As Integer = Integer.MaxValue
    Private Property dblMinNumber As Double = Double.MinValue
    Private Property dblMaxNumber As Double = Double.MaxValue

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

    Public Sub SetCharMinMax(Optional intMinChars As Integer = 0, Optional intMaxChars As Integer = Integer.MaxValue)

        intMinChars = intMinChars
        intMaxChars = intMaxChars

    End Sub

    Public Sub SetNumberMinMax(Optional dblMin As Double = Double.MinValue, Optional dblMax As Double = Double.MaxValue)

        dblMinNumber = dblMin
        dblMaxNumber = dblMax

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

            .Size = Size

        End With

    End Sub

    Private Sub InvalidInput(strMessage As String)

        blnIsValid = False
        lblErrorText.Visible = True
        lblErrorText.Text = strMessage
        ForeColor = Color.Red
        txtInput.BackColor = Color.LightPink

    End Sub

    Public Overloads Sub Validate() Handles Me.Leave

        Try

            Select Case ttyType
                Case TextType.Text
                    Dim strVal As String = New InCharRange(intMinChars, intMaxChars).clean(GetValue())
                Case TextType.Decimal_Point Or TextType.Money
                    Dim strVal As String = New InNumRange(dblMinNumber, dblMaxNumber).clean(GetValue())
                Case TextType.Whole
                    Dim strVal As String = New IsWhole().clean(New InNumRange(dblMinNumber, dblMaxNumber).clean(GetValue))
            End Select

            Forgive()

        Catch ve As ValidationError

            InvalidInput(ve.strReason)

        End Try

    End Sub

End Class
