'Program Name: Asterisks
'Programmer  : b_crocker
'Date		 : 3/1/2021 2:15:07 PM
'Purpose     : Show numbers and how many times they can be divided by two in asterisks


Option Strict On

Public Class Asterisks

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'It then loops through each of the numbers specified inputs
        'Then, it gets the amount of times its divisable by two and disaplys it as asterisks

        If CheckAllValid() Then

            lstResults.Items.Clear()

            Dim intStartingValue As Integer = Convert.ToInt32(txtStart.GetValue())
            Dim intEndingValue As Integer = Convert.ToInt32(txtEnd.GetValue())
            Dim intIterator As Integer = Convert.ToInt32(txtIterator.GetValue())

            For intCurrentNumber = intStartingValue To intEndingValue Step intIterator

                Dim strAsterisks As String = ""
                Dim intNumberCountdown = intCurrentNumber
                Dim intCurrentRemainder = 0

                Do While intCurrentRemainder = 0 And intNumberCountdown > 0

                    intCurrentRemainder = intNumberCountdown Mod 2
                    If intCurrentRemainder = 0 Then
                        strAsterisks &= "*"
                    End If
                    intNumberCountdown -= 2

                Loop

                lstResults.Items.Add(intCurrentNumber.ToString() & " " & strAsterisks)

            Next

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

    Private Sub Asterisks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts
        'It sets up input fields

        txtStart.SetName("Starting Value")
        txtEnd.SetName("Ending Value")
        txtIterator.SetName("Iterator")

        txtStart.SetType(Fields.TextType.Whole)
        txtEnd.SetType(Fields.TextType.Whole)
        txtIterator.SetType(Fields.TextType.Whole)

        txtStart.SetNumberMinMax(0, 100)
        txtEnd.SetNumberMinMax(0, 100)
        txtIterator.SetNumberMinMax(0, 100)

    End Sub

End Class
