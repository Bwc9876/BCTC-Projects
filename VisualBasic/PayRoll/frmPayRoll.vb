'Program Name: Payroll Calculator
'Programmer: Ben Crocker
'Date: 12/12/20
'Purpose: Calculate the user's net pay
'
'Test Cases (Invalid ones not included)
'
'   No Overtime:
'       >Greg
'       >10
'       >7.25
'       >Single
'       <Gross:72.50
'       <Tax:  15.95
'       <Net:  56.55
'   Overtime:
'       >Greg
'       >50
'       >7.25
'       >Single
'       <Overtime:  108.75
'       <Gross:  398.75
'       <Tax:  87.73
'       <Net:  311.02
'
'

Option Strict On


Public Class frmPayRoll

    Private Property strSelectedTaxRate As String

    Private Function validateNumber(inpField As InputField) As Boolean
        'This code is used to validate that string entered is a number
        'It first gets the value from the inputField passed in
        'It the makes sure the box isn't empty, is numeric, and isn't too big
        'If all checks pass, it returns True
        'Otherwise, it informs the user and returns False

        Dim strValue As String = inpField.GetValue()

        If strValue.Trim() <> "" Then

            Try

                Dim dblTestValue As Double = Convert.ToDouble(strValue)

                Return True

            Catch fe As FormatException

                inpField.InvalidInput("Must Be Numeric!")
                Return False

            Catch oe As OverflowException

                inpField.InvalidInput("Too Big!")
                Return False

            End Try

        Else

            inpField.InvalidInput("Can't Be Empty!")
            Return False

        End If

    End Function

    Const _cbytMinimumHours As Byte = 8
    Const _cbytMaximumHours As Byte = 60

    Private Function validateHours(inpField As InputField) As Boolean
        'This code is used to validate the hours entered
        'It makes sure that the input is a number
        'It then tests to see if the value is in the specified range
        'If if isn't in the range, inform the user and return False
        'Otherwise return True

        Dim blnIsValid As Boolean = validateNumber(inpField)

        If blnIsValid Then

            Try

                Dim bytTestValue As Byte = Convert.ToByte(inpField.GetValue())

                If bytTestValue < _cbytMinimumHours Or bytTestValue > _cbytMaximumHours Then

                    inpField.InvalidInput("Must Be In Range!")
                    blnIsValid = False

                End If

            Catch oe As OverflowException

                inpField.InvalidInput("Too Big!")
                Return False

            End Try

        End If

        Return blnIsValid

    End Function

    Const _cdecMinimumPay As Decimal = 7.25D
    Const _cdecMaximumPay As Decimal = 40D

    Private Function validatePayPerHour(inpField As InputField) As Boolean
        'This code is used to validate the pay per hour entered
        'It makes sure that the input is a number
        'It then tests to see if the value is in the specified range
        'If if isn't in the range, inform teh user and return False
        'Otherwise return True

        Dim blnIsValid As Boolean = validateNumber(inpField)

        If blnIsValid Then

            Dim decTestValue As Decimal = Convert.ToDecimal(inpField.GetValue)

            If decTestValue < _cdecMinimumPay Or decTestValue > _cdecMaximumPay Then

                inpField.InvalidInput("Must Be In Range!")
                blnIsValid = False

            End If

        End If

        Return blnIsValid

    End Function

    Private Function validateName(inpField As InputField) As Boolean
        'This code is used to validate the employee name entered
        'It checks to see if the input is empty
        'If it isn't, return True
        'Otherwise, inform the user it can't be empty and return False

        Dim strValue As String = inpField.GetValue()

        If strValue.Trim() <> "" Then

            Return True

        Else

            inpField.InvalidInput("Can't Be Empty!")
            Return False

        End If

    End Function

    Private Sub CheckedChanged(sender As Object, e As EventArgs)
        'This code is run whenever the checked property of a radiobutton is changed
        'It first checks to see if the radiobutton is checked
        'Ff it is, it sets the strSelectedTaxRate variable to the text in the label

        Dim btnChanged As RadioButton = CType(sender, RadioButton)

        If btnChanged.Checked Then

            strSelectedTaxRate = btnChanged.Text

        End If

    End Sub

    Const _cdblSingleTaxRate As Double = 22.0
    Const _cdblFamilyTaxRate As Double = 19.8
    Const _cbytMaxHoursUntilOvertime As Byte = 40

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is run whenever the calculate button is clicked
        'It first goes through each input field and checks if they are all valid
        'If any of them are invalid, do nothing
        'Otherwise, continue with the calculation
        'First, it reads all the values from the inputs, we're sure they are valid due to the loop from before
        'Then, it checks if the employee is working overtime (hours > 40) and calculates overtime pay accordingly
        'It then calculates the overtime pay (if applicable), grossPay, tax, and netPay variables and displays them all to the user

        Dim blnIsValid As Boolean = True

        For Each inpField As InputField In Controls.OfType(Of InputField)

            inpField.Validate()

            If inpField.GetValid() = False Then

                blnIsValid = False

            End If

        Next

        If blnIsValid Then

            Dim strName As String = inpName.GetValue()
            Dim bytHours As Byte = Convert.ToByte(inpHours.GetValue())
            Dim decPayPerHour As Decimal = Convert.ToDecimal(inpHourPay.GetValue())
            Dim dblTaxRate As Double = If(strSelectedTaxRate = "Single", _cdblSingleTaxRate, _cdblFamilyTaxRate)
            Dim blnIsWorkingOvertime As Boolean = bytHours > _cbytMaxHoursUntilOvertime
            Dim decOverTimePay As Decimal = 0D

            If blnIsWorkingOvertime Then

                Dim bytOverTimeHours As Byte = bytHours - _cbytMaxHoursUntilOvertime
                bytHours -= bytOverTimeHours
                Dim decTimeAndAHalf As Decimal = decPayPerHour * 1.5D
                decOverTimePay = decTimeAndAHalf * bytOverTimeHours

            End If

            Dim decGrossPay As Decimal = (bytHours * decPayPerHour) + decOverTimePay
            Dim decTax As Decimal = Convert.ToDecimal(decGrossPay * dblTaxRate / 100.0)
            Dim decNetPay As Decimal = decGrossPay - decTax

            lblOutput.Text = strName & "'s Payment Info: " & Environment.NewLine & Environment.NewLine
            If blnIsWorkingOvertime Then
                lblOutput.Text &= "Overtime Pay: " & decOverTimePay.ToString("C") & Environment.NewLine
            End If
            lblOutput.Text &= "Gross Pay: " & decGrossPay.ToString("C") & Environment.NewLine
            lblOutput.Text &= "Tax Amount: " & decTax.ToString("C") & Environment.NewLine
            lblOutput.Text &= "Net Pay: " & decNetPay.ToString("C")

        End If

    End Sub

    Private Sub frmPayRoll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program is first started
        'It first sets the validation function of the inputfield to their proper validators (check InputField.vb for more info)
        'It then displays all constants to the user inside of the info groupBox
        'Finally, it loops through each radiobutton in grpRates and sets it CheckChanged handler to CheckedChanged

        inpHours.SetValidator(AddressOf validateHours)
        inpHourPay.SetValidator(AddressOf validatePayPerHour)
        inpName.SetValidator(AddressOf validateName)
        strSelectedTaxRate = "Single"
        lblSingleRate.Text = "Single Tax Rate: %" & _cdblSingleTaxRate.ToString("F2")
        lblFamilyRate.Text = "Family Tax Rate: %" & _cdblFamilyTaxRate.ToString("F2")
        lblHourRange.Text = "Range For Hours: " & _cbytMinimumHours.ToString() & "-" & _cbytMaximumHours.ToString()
        lblPayRange.Text = "Range For Pay Rate: " & _cdecMinimumPay.ToString("C") & "-" & _cdecMaximumPay.ToString("C")

        For Each btnTaxRateType As RadioButton In grpRates.Controls.OfType(Of RadioButton)

            AddHandler btnTaxRateType.CheckedChanged, AddressOf CheckedChanged

        Next

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is clicked
        'It first loops through ever input field and clears it
        'It then activates the btnSingle radio button
        'Finally, it resets the text of the output label

        For Each inpField As InputField In Controls.OfType(Of InputField)

            inpField.Clear()

        Next

        btnSingle.Checked = True
        lblOutput.Text = "Payment Info Will Appear Here"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run whenever the exit button is clicked
        'It exits the program

        Close()

    End Sub


End Class
