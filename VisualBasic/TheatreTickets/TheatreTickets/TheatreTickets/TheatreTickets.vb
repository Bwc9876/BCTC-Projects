'Program Name: TheatreTickets
'Programmer  : b_crocker
'Date		 : 8/26/2021
'Purpose     : Calculate the gross and net cost of a movie theatre's revenue

'Test Cases:
'
'
' > 5
' > 10
' > 5
' > 10
' < Adult: $50, $10
' < Child: $50, $10
' < Total: $100, $20
'
'
' > 10
' > 300
' > 5
' > 350
' < Adult: $3000, $600
' < Child: $1750, $350
' < Total: $4750, $950
'

Option Strict On

Public Class TheatreTickets

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed
        'It loops through every input and clears it
        'It also hides the result labels

        For Each txtinput As Fields.TextField In grpInputs.Controls.OfType(Of Fields.TextField)

            txtinput.Clear()

        Next

        lblAdultResults.Visible = False
        lblChildResults.Visible = False
        lblTotalResults.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Const _cdblPercentageKept As Double = 20.0

    Private Function ValidateInput(strRawInput As String, ByRef strReason As String) As Boolean
        'This function is used to ensure entered values are correct
        'It checks if the string is empty, non-numeric, or a decimal

        If strRawInput <> "" Then

            Try

                Dim intNumber As Integer = Convert.ToInt32(strRawInput)
                Return True

            Catch fe As FormatException

                strReason = "Must Be A Numeric Whole Number!"
                Return False

            End Try

        Else

            strReason = "Can't Be Empty!"
            Return False

        End If

    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is run when the Begin button is pressed
        'It first checks if all text fields are correct
        'It loops through asking the amount of adults and children and adds it to the total

        If CheckAllValid() Then

            Dim intTotalAdults As Integer = 0
            Dim intTotalChildren As Integer = 0

            Dim blnIsDone As Boolean = False

            Do

                Dim strAdultAmountRaw As String = InputBox("Enter Adult Amount", "Enter Amount")
                Dim strError As String = ""

                If ValidateInput(strAdultAmountRaw, strError) Then

                    Dim strChildAmountRaw As String = InputBox("Enter Child Amount", "Enter Amount")

                    If ValidateInput(strChildAmountRaw, strError) Then
                        intTotalAdults += Convert.ToInt32(strAdultAmountRaw)
                        intTotalChildren += Convert.ToInt32(strChildAmountRaw)
                        blnIsDone = InputBox("Are there any more people in line? (enter y/n)", "Done?", "y").ToLower() = "n"
                    Else
                        MsgBox(strError,, "Input Error")
                    End If
                Else
                    MsgBox(strError,, "Input Error")
                End If

            Loop While Not blnIsDone

            CalculateRevenue(intTotalAdults, intTotalChildren)

        End If



    End Sub

    Private Sub CalculateRevenue(intAdultAmount As Integer, intChildAmount As Integer)
        'This code is run to calculate the total revenues
        'It first grabs the purchase data from the text fields
        'Then, it calculates the gross and net revenue for adult, children, and the total
        'Next, it displays these results in their corresponding text boxes
        'Finally, it shows the result labels

        Dim decAdultPrice As Decimal = Convert.ToDecimal(txtAdultCost.GetValue())
        Dim decChildPrice As Decimal = Convert.ToDecimal(txtChildCost.GetValue())

        Dim decGrossAdultRevenue As Decimal = decAdultPrice * Convert.ToDecimal(intAdultAmount)
        Dim decGrossChildrevenue As Decimal = decChildPrice * Convert.ToDecimal(intChildAmount)
        Dim decGrossTotalRevenue As Decimal = decGrossAdultRevenue + decGrossChildrevenue

        Dim decNetAdultRevenue As Decimal = decGrossAdultRevenue * Convert.ToDecimal(_cdblPercentageKept / 100.0)
        Dim decNetChildRevenue As Decimal = decGrossChildrevenue * Convert.ToDecimal(_cdblPercentageKept / 100.0)
        Dim decNetTotalRevenue As Decimal = decGrossTotalRevenue * Convert.ToDecimal(_cdblPercentageKept / 100.0)

        lblAdultResults.Text = $"Gross Revenue For Adults: {decGrossAdultRevenue.ToString("c")}" & Environment.NewLine _
        & $"Net Revenue for Adults: {decNetAdultRevenue.ToString("c")}"

        lblChildResults.Text = $"Gross Revenue For Children: {decGrossChildrevenue.ToString("c")}" & Environment.NewLine _
        & $"Net Revenue for Children: {decNetChildRevenue.ToString("c")}"

        lblTotalResults.Text = $"Gross Total: {decGrossTotalRevenue.ToString("c")}" & Environment.NewLine & $"Net Total: {decNetTotalRevenue.ToString("c")}"

        lblAdultResults.Visible = True
        lblChildResults.Visible = True
        lblTotalResults.Visible = True

    End Sub

    Private Function CheckAllValid() As Boolean
        'Use this code to check if all TextFields are valid
        'It loops through each text field and checks if its valid
        'If any are invalid, it will return false

        Dim blnIsValid As Boolean = True

        For Each txtField As Fields.TextField In grpInputs.Controls.OfType(Of Fields.TextField)

            txtField.Validate()

            If txtField.IsValid() <> True Then

                blnIsValid = False

            End If


        Next

        Return blnIsValid

    End Function

    Private Sub TheatreTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts
        'It first sets up the info label with the proper info
        'Then it sets up the text fields

        lblInfo.Text &= _cdblPercentageKept.ToString() & "%"

        txtAdultCost.SetName("Adult Ticket Price")
        txtChildCost.SetName("Child Ticket Price")

        txtAdultCost.SetType(Fields.TextType.Money)
        txtChildCost.SetType(Fields.TextType.Money)

    End Sub

End Class
