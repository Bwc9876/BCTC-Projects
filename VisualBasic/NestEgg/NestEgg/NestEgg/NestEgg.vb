'Program Name: NestEgg
'Programmer  : b_crocker
'Date		 : 4/26/2021 1:18:47 PM
'Purpose     : Find out the amount a user will gain from a nest egg

'Test Cases:
'
' > 17000
' > 20000
' > 4
' > 5
'
' < 20,683.10
' < You will make your goal!

' > 17000
' > 20000
' > 4
' > 1
'
' < 17,680.00
' < You will not make your goal...


Option Strict On

Public Class NestEgg

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'This code is run whenever the clear button is pressed
        'It clears all inputs and hides the result labels, and then clears the result list

        txtCurrent.Clear()
        txtTarget.Clear()
        txtInterest.Clear()
        txtYears.Clear()
        grpResults.Visible = False
        lstYears.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Function EvaluateNestEgg(decCurrentPrincipal As Decimal, decTarget As Decimal, dblInterest As Double, intYears As Integer) As Boolean

        For intCurrentYear As Integer = 1 To intYears

            decCurrentPrincipal *= Convert.ToDecimal(1.0 + (dblInterest / 100.0))
            lstYears.Items.Add("Year " & intCurrentYear.ToString() & ": " & decCurrentPrincipal.ToString("c"))

        Next

        grpResults.Visible = True

        lblResult.Text = decCurrentPrincipal.ToString("c")

        Return decCurrentPrincipal >= decTarget

    End Function

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'Then, it clears the results list so that way we don't get duplicates
        'Next, it find out the principal value each year, and adding them to the years list
        'Then, it will show the final value
        'Finally, it will tell the user if they have met their goal

        If CheckAllValid() Then
            lstYears.Items.Clear()

            Dim decCurrentPrincipal As Decimal = Convert.ToDecimal(txtCurrent.GetValue())
            Dim decTarget As Decimal = Convert.ToDecimal(txtTarget.GetValue())
            Dim dblInterest As Double = Convert.ToDouble(txtInterest.GetValue())
            Dim intYears As Integer = Convert.ToInt32(txtYears.GetValue())

            Dim blnCanMeetGoal = EvaluateNestEgg(decCurrentPrincipal, decTarget, dblInterest, intYears)

            If blnCanMeetGoal Then

                With lblMetGoal

                    .Text = "You will meet your goal!"
                    .BackColor = Color.LightGreen
                    .ForeColor = Color.DarkGreen

                End With

            Else

                With lblMetGoal

                    .Text = "You will not meet your goal..."
                    .BackColor = Color.LightPink
                    .ForeColor = Color.DarkRed

                End With

            End If

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

    Private Sub NestEgg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts
        'It sets up some settigns for TextBoxes

        txtCurrent.SetName("Current Principal")
        txtTarget.SetName("Target Value")
        txtInterest.SetName("Interest Rate")
        txtYears.SetName("Years To Calculate")

        txtCurrent.SetType(Fields.TextType.Money)
        txtTarget.SetType(Fields.TextType.Money)
        txtInterest.SetType(Fields.TextType.Decimal_Point)
        txtYears.SetType(Fields.TextType.Whole)

        txtCurrent.SetNumberMinMax(0.0, Nothing)
        txtTarget.SetNumberMinMax(0.0, Nothing)
        txtInterest.SetNumberMinMax(0.0, Nothing)
        txtCurrent.SetNumberMinMax(0.0, Nothing)

    End Sub

End Class
