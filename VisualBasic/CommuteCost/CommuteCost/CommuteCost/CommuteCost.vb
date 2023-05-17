'Program Name: CommuteCost
'Programmer  : b_crocker
'Date		 : 4/30/2021 1:26:12 PM
'Purpose     : Calculate the cost of commuting using various methods for one year

'Test Cases:
'
' > Car
' > 15
' > 20
' > 40
' > 20.00
' > 45.00
' > 53.45
' < 2981.40
'
' > Bus
' > 5
' > 20
' < 1200
'

Option Strict On

Public Class CommuteCost

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'This code is run whenever the clear button is pressed
        'It clears all input fields
        'It then hides all panels and disables the calculate buttton
        'Finally, it hides the results label

        ClearAllInputsIn(pnlCar)
        ClearAllInputsIn(pnlOther)
        btnSubmit.Enabled = False
        pnlCar.Visible = False
        pnlOther.Visible = False
        cmbType.SelectedIndex = -1
        lblResult.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Function CalculateGallonsUsed(dblDistanceTraveled As Double, dblMileage As Double) As Double
        'This function calculates the gallons used from the mileage and the miles traveled

        Return dblDistanceTraveled / dblMileage

    End Function

    Private Function CalculateMoneySpentOnGas(dblGallons As Double, decRate As Decimal) As Decimal
        'This function calculates how much money was spent on gas given the gallons used and the rate

        Return Convert.ToDecimal(dblGallons) * decRate

    End Function

    Private Function CalculateMonthly(decCost As Decimal, dblDaysWorked As Double) As Decimal
        'This function calculates what the monthly cost would be from the daily cost and the days worked in a month

        Return decCost * Convert.ToDecimal(dblDaysWorked)

    End Function

    Private Function CalculateYearly(decCost As Decimal) As Decimal
        'This function calculates what the yearly cost would be from the monthly cost

        Return decCost * 12D

    End Function

    Private Function AddFees(decCost As Decimal, decMaintenance As Decimal, decParking As Decimal) As Decimal
        'This function adds fees onto the current commute cost

        Return decCost + decMaintenance + decParking

    End Function

    Private Function CalculateCarCommute(dblDistanceTraveled As Double, dblDaysWorked As Double, dblMileage As Double, decGas As Decimal, decMaintenance As Decimal, decParking As Decimal) As Decimal
        'This function calculates the commute cost yearly for a Car

        Dim dblGallonsUsed As Double = CalculateGallonsUsed(dblDistanceTraveled, dblMileage)
        Dim decTotalCostDaily As Decimal = CalculateMoneySpentOnGas(dblGallonsUsed, decGas)
        Dim decTotalCostMonthly As Decimal = CalculateMonthly(decTotalCostDaily, dblDaysWorked)
        Dim decTotalCostYearly As Decimal = CalculateYearly(AddFees(decTotalCostMonthly, decMaintenance, decParking))

        Return decTotalCostYearly

    End Function

    Private Function CalculateOtherCommute(decFare As Decimal, dblDaysWorked As Double) As Decimal
        'This function calculates the yearly commute cost for a transportation method other than car

        Return CalculateYearly(CalculateMonthly(decFare, dblDaysWorked))

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'It then calculates the cost of commuting with a different algorithm depending on the transport type
        'Finally, it shows the results in lblResult

        Dim strTransportMethod As String = cmbType.SelectedItem.ToString()

        If strTransportMethod = "Car" Then

            If CheckAllValid(pnlCar) Then

                Dim dblDistanceTraveled As Double = Convert.ToDouble(txtRoundtrip.GetValue())
                Dim dblDaysWorked As Double = Convert.ToDouble(txtDays.GetValue())
                Dim dblMileage As Double = Convert.ToDouble(txtMileage.GetValue())
                Dim decGas As Decimal = Convert.ToDecimal(txtGas.GetValue())
                Dim decMaintenance As Decimal = Convert.ToDecimal(txtMaintenance.GetValue())
                Dim decParking As Decimal = Convert.ToDecimal(txtParking.GetValue())

                Dim decTotalCost As Decimal = CalculateCarCommute(dblDistanceTraveled, dblDaysWorked, dblMileage, decGas, decMaintenance, decParking)

                lblResult.Text = "Cost for commuting one year via Car: " & Environment.NewLine & decTotalCost.ToString("c")
                lblResult.Visible = True

            End If

        Else

            If CheckAllValid(pnlOther) Then

                Dim decFare As Decimal = Convert.ToDecimal(txtFare.GetValue())
                Dim dblDays As Double = Convert.ToDouble(txtDaysWorked.GetValue())

                Dim decTotalCost As Decimal = CalculateOtherCommute(decFare, dblDays)

                lblResult.Text = "Cost for commuting one year via " & strTransportMethod & ":" & Environment.NewLine & decTotalCost.ToString("c")
                lblResult.Visible = True

            End If

        End If

    End Sub

    Private Function CheckAllValid(pnlPanel As Panel) As Boolean
        'Use this code to check if all TextFields are valid in a given panel
        'It loops through each text field in the panel and checks if its valid
        'If any are invalid, it will return false

        Dim blnIsValid As Boolean = True

        For Each txtField As Fields.TextField In pnlPanel.Controls.OfType(Of Fields.TextField)

            txtField.Validate()

            If txtField.IsValid() <> True Then

                blnIsValid = False

            End If

        Next

        Return blnIsValid

    End Function


    Private Sub ClearAllInputsIn(pnlPanel As Panel)
        'This function is used to clear all input fields in a panel
        'It loops through each input field in the panel and clears it

        For Each txtField As Fields.TextField In pnlPanel.Controls.OfType(Of Fields.TextField)

            txtField.Clear()

        Next

    End Sub



    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged
        'This function is run when the selected item in the combobox is changed
        'It gets the selected type and reveals the sorresponding panel with all the inputs
        'Finally, it makes the calculate button enabled if a valid value was selected

        Dim strSelectedType As String = If(cmbType.SelectedIndex = -1, "", cmbType.SelectedItem.ToString())

        If strSelectedType = "Car" Then

            pnlCar.Visible = True
            pnlOther.Visible = False
            ClearAllInputsIn(pnlCar)

        ElseIf strSelectedType <> "" Then

            pnlOther.Visible = True
            pnlCar.Visible = False
            ClearAllInputsIn(pnlOther)

        End If

        btnSubmit.Enabled = strSelectedType <> ""

    End Sub

    Private Sub CommuteCost_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts
        'It configures all the input fields

        For Each txtField As Fields.TextField In pnlCar.Controls.OfType(Of Fields.TextField)

            txtField.SetNumberMinMax(1, Integer.MaxValue)

        Next

        For Each txtField As Fields.TextField In pnlOther.Controls.OfType(Of Fields.TextField)

            txtField.SetNumberMinMax(1, Integer.MaxValue)

        Next

        txtRoundtrip.SetName("Rountrip Distance")
        txtDays.SetName("Days Worked")
        txtMileage.SetName("Mileage")
        txtGas.SetName("Gas Cost")
        txtMaintenance.SetName("Maintenance Cost")
        txtParking.SetName("Parking Cost")
        txtFare.SetName("Trip Fare")
        txtDaysWorked.SetName("Days Worked")

        txtRoundtrip.SetType(Fields.TextType.Decimal_Point)
        txtDays.SetType(Fields.TextType.Decimal_Point)
        txtDaysWorked.SetType(Fields.TextType.Decimal_Point)
        txtMileage.SetType(Fields.TextType.Decimal_Point)
        txtGas.SetType(Fields.TextType.Money)
        txtMaintenance.SetType(Fields.TextType.Money)
        txtParking.SetType(Fields.TextType.Money)
        txtFare.SetType(Fields.TextType.Money)

    End Sub

End Class
