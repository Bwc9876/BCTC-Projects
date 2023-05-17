
Option Strict On

Friend Module Validation
    Class ValidationError

        Inherits Exception

        Public Property strReason As String

        Public Sub New(strReason As String)

            Me.strReason = strReason

        End Sub

    End Class


    Class Validator

        Public Overridable Function clean(strInput As String) As String

            Return strInput

        End Function

    End Class


    Class NotEmpty

        Inherits Validator

        Public Overrides Function clean(strInput As String) As String

            strInput = MyBase.clean(strInput)

            If strInput = "" Then

                Throw New ValidationError("Can't be empty")

            End If

            Return strInput

        End Function


    End Class


    Class NumericValidator

        Inherits NotEmpty

        Public Overrides Function clean(strInput As String) As String

            strInput = MyBase.clean(strInput)

            If IsNumeric(strInput) = False Then

                Throw New ValidationError("Not Numeric")

            End If

            Return strInput

        End Function

    End Class

    Class InCharRange

        Inherits NotEmpty

        Private Property intMin As Integer = 0
        Private Property intMax As Integer = Integer.MaxValue

        Public Sub New(Optional intMin As Integer = 0, Optional intMax As Integer = Integer.MaxValue)

            Me.intMin = intMin
            Me.intMax = intMax

        End Sub

        Public Overrides Function clean(strInput As String) As String

            strInput = MyBase.clean(strInput)

            If strInput.Length > intMax OrElse strInput.Length < intMin Then

                Throw New ValidationError("Not In Character Range")

            End If

            Return strInput

        End Function

    End Class


    Class InNumRange

        Inherits NumericValidator

        Private Property dblMin As Double = Double.MinValue
        Private Property dblMax As Double = Double.MaxValue

        Public Sub New(Optional dblMin As Double = Double.MinValue, Optional dblMax As Double = Double.MaxValue)

            Me.dblMin = dblMin
            Me.dblMax = dblMax

        End Sub

        Public Overrides Function clean(strInput As String) As String

            strInput = MyBase.clean(strInput)

            Dim dblNum As Double = Convert.ToDouble(strInput)

            If dblNum > dblMax OrElse dblNum < dblMin Then

                Throw New ValidationError("Not In Number Range")

            End If

            Return strInput

        End Function

    End Class

    Class IsWhole

        Inherits NumericValidator

        Public Overrides Function clean(strInput As String) As String

            strInput = MyBase.clean(strInput)

            Dim dblNum As Double = Convert.ToDouble(strInput)

            If dblNum Mod 1 <> 0 Then

                Throw New ValidationError("Must be a whole number")

            End If

            Return strInput

        End Function

    End Class

End Module