

Class ValidationError

    Inherits Exception

    Private Property strReason As String

    Public Sub New(strReason As String)

        Me.strReason = strReason

    End Sub

End Class


Class Validator

    Public Overridable Function clean(strInput As String) As String

        Return strInput

    End Function

End Class


Class NumericValidator

    Inherits Validator

    Public Overrides Function clean(strInput As String) As String

        If IsNumeric(strInput) = False Then

            Throw New ValidationError("Not Numeric")

        End If

        Return strInput

    End Function

End Class

Class InCharRange

    Inherits Validator

    Private Property intMin As Integer = -1
    Private Property intMax As Integer = -1

    Public Sub New(Optional intMin As Integer = -1, Optional intMax As Integer = -1)

        Me.intMin = intMin
        Me.intMax = intMax

    End Sub

    Public Overrides Function clean(strInput As String) As String

        If strInput.Length > intMax OrElse strInput.Length < intMin Then

            Throw New ValidationError("Not In Character Range")

        End If

        Return strInput

    End Function

End Class


Class InNumRange

    Inherits Validator

    Private Property intMin As Integer = Integer.MinValue
    Private Property intMax As Integer = Integer.MaxValue

    Public Sub New(Optional intMin As Integer = Integer.MinValue, Optional intMax As Integer = Integer.MaxValue)

        Me.intMin = intMin
        Me.intMax = intMax

    End Sub

    Public Overrides Function clean(strInput As String) As String

        Dim dblNum As Double = Convert.ToDouble(strInput)

        If dblNum > intMax OrElse dblNum < intMin Then

            Throw New ValidationError("Not In Number Range")

        End If

        Return strInput

    End Function

End Class

