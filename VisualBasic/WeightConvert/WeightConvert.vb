'Program Name: Weight Converter
'Programmer  : Ben Crocker
'Date        : 12/9/20
'Purpose     : Assist the user in converting a patient's weight to a different unit
'
'Test Cases:
'
'Case 1:
'
'   > -5
'   < Input Must Be Positive!
'   
'Case 2:
'
'   > 50 kg.
'   < ~110.250 lbs.
'
'Case 3:
'
'   > 110.250 lbs.
'   < ~50.000 kg.
'

Option Strict On

Public Class WeightConvert

    Private Sub cmbUnit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnit.SelectedIndexChanged
        'This code is run whenever the unit combox's value is changed
        'It will only do something if there is an actual item selected
        'It first gets the unit from the combobox
        'It then sets the text of the button accordingly and enables it

        If cmbUnit.SelectedIndex <> -1 Then

            Dim strUnit As String = cmbUnit.SelectedItem.ToString()
            btnConvert.Text = "Convert To " & If(strUnit = "lbs.", "kg.", "lbs.")
            btnConvert.Enabled = True

        End If

    End Sub

    Private Function FindErrors(strInput As String) As String
        'This code is run to the the validity of the entered weight
        'It first checks to make sure the value isnt empty
        'It then checks to see that it can be converterted to a double
        'Finally, if the data is valid, it returns 'No Error'

        If strInput.Length > 0 Then

            Try

                Dim dblTestValue As Double = Convert.ToDouble(strInput)

                If dblTestValue > 0 Then

                    Return "No Error"

                Else

                    Return "Input Must Be Positive!"

                End If

            Catch fe As FormatException

                Return "Value Must Be Numeric!"

            Catch oe As OverflowException

                Return "Value Is Too Big!"

            End Try

        Else

            Return "Value Can't Be Empty!"

        End If

    End Function

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        'This code is run whenever the convert button is clicked
        'It first gets the unit and the weight from the inputs
        'It then validates the inputted weight
        'If there are no errors, it continues, otherwise it will show the error to the user
        'Then, it converts the weight to a double
        'Next, it checks to see whether it should divide or multiply depending on the unit we're converting to
        'Finally, it displays the converted weight and set sthe output label to visible

        Dim strUnit As String = cmbUnit.SelectedItem.ToString()
        Dim strOppositeUnit As String = If(strUnit = "lbs.", "kg.", "lbs.")
        Dim strWeight As String = txtWeight.Text

        Dim strError As String = FindErrors(strWeight)

        If strError = "No Error" Then

            Dim dblWeight As Double = Convert.ToDouble(strWeight)
            Dim dblConvertedWeight As Double

            If strOppositeUnit = "lbs." Then

                dblConvertedWeight = dblWeight * 2.20462

            Else

                dblConvertedWeight = dblWeight / 2.20462

            End If

            lblConvertedWeight.Text = dblConvertedWeight.ToString("F3") & " " & strOppositeUnit
            lblConvertedWeight.Visible = True

        Else

            MsgBox(strError,, "Input Error")
            lblConvertedWeight.Visible = False

        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the Clear button is clicked
        'It first sets the selected index of the unit combobox to -1 to signify there is nothing in it
        'It then disables and changes the text of the convert button
        'Then, it hides the output label
        'Finally, it clears the weight textbox

        cmbUnit.SelectedIndex = -1
        btnConvert.Enabled = False
        btnConvert.Text = "Please Select A Unit First"
        lblConvertedWeight.Visible = False
        txtWeight.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run whenever the exit button is clicked
        'It exits the program

        Close()

    End Sub

End Class
