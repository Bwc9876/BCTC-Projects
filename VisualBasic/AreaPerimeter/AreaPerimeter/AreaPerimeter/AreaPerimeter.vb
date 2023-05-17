'Program Name: AreaPerimeter
'Programmer  : b_crocker
'Date		 : 9/20/2021 12:30:20 PM
'Purpose     : To calculate the area or perimeter of a 4-sided shape

'Test Cases:
'
' > 5
' > 5
' > Area
' < 25
'
' > 5
' > 5
' > Perimeter
' < 20
'



Option Strict On

Public Class AreaPerimeter

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed

        cmbSelector.SelectedIndex = -1
        btnCalculate.Enabled = False
        txtSide1.Clear()
        txtSide2.Clear()
        lblResults.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Sub cmbSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelector.SelectedIndexChanged

        btnCalculate.Enabled = cmbSelector.SelectedIndex <> -1

    End Sub

    Private Function CalcArea(dblSide1 As Double, dblSide2 As Double) As Double

        Return dblSide1 * dblSide2

    End Function

    Private Function CalcPerimeter(dblSide1 As Double, dblSide2 As Double) As Double

        Return dblSide1 * 2.0 + dblSide2 * 2.0

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing

        If CheckAllValid() Then

            Dim blnArea As Boolean = cmbSelector.SelectedItem.ToString() = "Area"
            Dim dblSide1 As Double = Convert.ToDouble(txtSide1.GetValue())
            Dim dblSide2 As Double = Convert.ToDouble(txtSide2.GetValue())

            Dim dblResult As Double

            If blnArea Then

                dblResult = CalcArea(dblSide1, dblSide2)

            Else

                dblResult = CalcPerimeter(dblSide1, dblSide2)

            End If

            lblResults.Text = $"{dblResult.ToString()} {If(blnArea, "u²", "u")}"
            lblResults.Visible = True

        End If

    End Sub

    Private Function CheckAllValid() As Boolean
        'Use this code to check if all TextFields are valid
        'It loops through each text field and checks if its valid
        'If any are invalid, it will return false

        Dim blnIsValid As Boolean = True

        For Each txtField As Fields.TextField In Controls.OfType(Of Fields.TextField)

            txtField.Validate()

            If txtField.IsValid() <> True Then

                blnIsValid = False

            End If


        Next

        Return blnIsValid

    End Function

    Private Sub AreaPerimeter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts

        Threading.Thread.Sleep(1000)

        txtSide1.SetName("Side 1")
        txtSide2.SetName("Side 2")
        txtSide1.SetType(Fields.TextType.Decimal_Point)
        txtSide2.SetType(Fields.TextType.Decimal_Point)

    End Sub

End Class
