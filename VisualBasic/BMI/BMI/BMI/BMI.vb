'Program Name: BMI
'Programmer  : b_crocker
'Date		 : 9/20/2021 1:04:21 PM
'Purpose     : To calulate the BMI in both imperial and metric and display a message about it

'Test Cases:
'
' > 100
' > 60
' > Imperial
' < 19
' < Normal
'
' > 45
' > 1.5
' > Metric
' < 20
' < Normal


Option Strict On

Public Class BMI

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed

        cmbSelector.SelectedIndex = -1
        btnCalculate.Enabled = False
        txtHeight.Clear()
        txtWeight.Clear()
        LabelsVisible(False)

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Sub LabelsVisible(blnVisible As Boolean)

        lblBMI.Visible = blnVisible
        lblMessage.Visible = blnVisible

    End Sub

    Private Function CalcBMI(dblWeight As Double, dblHeight As Double, blnMetric As Boolean) As Double

        Return dblWeight * If(blnMetric, 1, 703) / (dblHeight * dblHeight)

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        '(Insert what it does after that here)

        If CheckAllValid() Then

            Dim dblWeight As Double = Convert.ToDouble(txtWeight.GetValue())
            Dim dblHeight As Double = Convert.ToDouble(txtHeight.GetValue())
            Dim blnMetric As Boolean = cmbSelector.SelectedItem.ToString() = "Metric (kg/m)"

            Dim dblBMI As Double = CalcBMI(dblWeight, dblHeight, blnMetric)

            Dim strMessage As String

            Select Case dblBMI

                Case Is < 18.5
                    strMessage = "Under Weight"
                Case 18.5 To 24.9
                    strMessage = "Normal Weight"
                Case 25 To 29.9
                    strMessage = "Over Weight"
                Case Else
                    strMessage = "Obesity"

            End Select

            lblBMI.Text = dblBMI.ToString("f2")
            lblBMI.Text &= " " & If(blnMetric, "kg/m²", "lbs/in²")
            lblMessage.Text = strMessage
            LabelsVisible(True)

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

    Private Sub BMI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts

        Threading.Thread.Sleep(1000)

        txtHeight.SetName("Height")
        txtWeight.SetName("Weight")

        txtHeight.SetType(Fields.TextType.Decimal_Point)
        txtWeight.SetType(Fields.TextType.Decimal_Point)

        txtHeight.SetNumberMinMax(0, Double.MaxValue)
        txtWeight.SetNumberMinMax(0, Double.MaxValue)

    End Sub

    Private Sub cmbSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSelector.SelectedIndexChanged

        btnCalculate.Enabled = cmbSelector.SelectedIndex <> -1

    End Sub


End Class
