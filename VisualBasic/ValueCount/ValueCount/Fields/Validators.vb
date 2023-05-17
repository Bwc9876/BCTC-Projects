Friend Module Validators

    Function IsntEmpty(strValue As String, Optional blnTrim As Boolean = True) As Boolean

        Return If(blnTrim, strValue.Trim(), strValue) <> ""

    End Function

    Function GetVarFromStrAndType(strValue As String, ttyType As TextType)

        Try

            Select Case ttyType

                Case TextType.Text
                    Return strValue

                Case TextType.Money
                    Return Convert.ToDecimal(strValue)

                Case TextType.Whole
                    Return Convert.ToInt32(strValue)

                Case TextType.Decimal_Point
                    Return Convert.ToDouble(strValue)

                Case Else
                    Return Nothing

            End Select

        Catch ex As Exception

            Return Nothing

        End Try

    End Function

    Function CanConvert(ttyType As TextType, strValue As String, ByRef strReason As String, Optional blnForceWhole As Boolean = False) As Boolean

        Try

            Dim anyTestValue = GetVarFromStrAndType(strValue, ttyType)

            If anyTestValue Is Nothing Then

                Throw New FormatException()

            End If

            If ttyType = TextType.Whole AndAlso blnForceWhole AndAlso anyTestValue Mod 1 <> 0 Then

                strReason = "Isn't A Whole Number"
                Return False

            Else

                Return True

            End If

        Catch fe As FormatException

            strReason = "Must Be Numeric"
            Return False

        Catch oe As OverflowException

            strReason = "Too Big"
            Return False

        End Try

    End Function

    Function InCharRange(strValue As String, intMin As Integer, intMax As Integer, Optional blnTrim As Boolean = False) As Boolean

        Dim strTestValue As String = If(blnTrim, strValue.Trim(), strValue)

        If intMax = -1 And intMin = -1 Then

            Return True

        ElseIf intMax = -1 And intMin <> -1 Then

            Return strTestValue.Length >= intMin

        ElseIf intMin = -1 And intMax <> -1 Then

            Return strTestValue.Length <= intMax

        Else

            Return strTestValue.Length >= intMin And strTestValue.Length <= intMax

        End If

    End Function

    Function InNumberRange(strValue As String, ttyType As TextType, dblMin As Double, dblMax As Double) As Boolean

        Dim anyTestValue = GetVarFromStrAndType(strValue, ttyType)

        If dblMax = Nothing And dblMin = Nothing Then

            Return True

        ElseIf dblMax = Nothing And dblMin <> Nothing Then

            Return anyTestValue >= dblMin

        ElseIf dblMin = Nothing And dblMax <> Nothing Then

            Return anyTestValue <= dblMax

        Else

            Return anyTestValue >= dblMin And anyTestValue <= dblMax

        End If

    End Function

End Module
