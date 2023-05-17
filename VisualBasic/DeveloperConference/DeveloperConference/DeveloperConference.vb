'Program Name: DeveloperConference
'Programmer  : Ben Crocker
'Date		 : 1/7/2021
'Purpose     : Determine the cost based off number of people attending

'Test Cases:
'
'   Test Case 1:
'       > 10 People
'       > Didn't Attend Last Year
'       < $3,850
'   Test Case 2:
'       > 10 People
'       > Did Attend Last Year
'       < $3272.20
'
'


Option Strict On

Public Class DeveloperConference

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed
        'It first clears the attendees inputbox
        'It the resets the results text
        'Finally, it unckecks the previously attended checkbox

        txtAttendees.Clear()
        lblResult.Text = "Results Will Appear Here"
        btnPrevious.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Const _cdblDiscount As Double = 15
    Private Const _cintMaxPeople As Integer = 16
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'It then gets the number of people from the text box
        'It then determines the cost per person based on the number of people
        'Then, it the total by multiplying the amount of people by the cost per person
        'Finally, it applies a discount if appllicable and displays the cost

        If txtAttendees.IsValid() Then

            Dim intAmountOfPeople As Integer = Convert.ToInt32(txtAttendees.GetValue())
            Dim blnApplyDiscount As Boolean = btnPrevious.Checked

            Dim decCostPerPerson As Decimal

            Select Case intAmountOfPeople
                Case 1
                    decCostPerPerson = 795D
                Case 2 To 4
                    decCostPerPerson = 645D
                Case 5 To 7
                    decCostPerPerson = 475D
                Case 8 To 16
                    decCostPerPerson = 385D
                Case Else
                    decCostPerPerson = 0D
            End Select

            Dim decSubTotal As Decimal = decCostPerPerson * intAmountOfPeople

            If blnApplyDiscount Then
                decSubTotal -= decSubTotal * Convert.ToDecimal(_cdblDiscount / 100)
            End If

            lblResult.Text = "Total Cost: " & decSubTotal.ToString("C")

        End If

    End Sub

    Private Sub DeveloperConference_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts
        'It first sets up the atendees text box
        'It then displays constants to the user

        txtAttendees.SetName("Attendees")
        txtAttendees.SetNumberMinMax(1, _cintMaxPeople)
        txtAttendees.SetType(Fields.TextType.Whole)

        lblDiscount.Text &= _cdblDiscount.ToString() & "%"
        lblMaxPeople.Text &= _cintMaxPeople

    End Sub

End Class
