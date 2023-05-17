'Program Name: MultiplicationTable
'Programmer  : b_crocker
'Date		 : 3/8/2021 1:00:11 PM
'Purpose     : Give teh multiplication table for a selected number

'Test Cases:
'
' > 5
' < 5, 10, 15, 20, 25, 30, 35, ... 
'
'


Option Strict On

Public Class MultiplicationTable

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        'It then loops through 1-10, finding each product of the currentNumber and the multiplier entered
        'Then, it displays the product and teh equation in the lstResults Listbox

        Const _cintStartingNumber As Integer = 1
        Const _cintEndingNumber As Integer = 10

        If CheckAllValid() Then

            lstResults.Items.Clear()

            Dim intMulitplier As Integer = Convert.ToInt32(txtMultiplier.GetValue())

            For intCurrentNumber = _cintStartingNumber To _cintEndingNumber

                Dim intProduct As Integer = intMulitplier * intCurrentNumber
                Dim strResult As String = intMulitplier.ToString() & "*" & intCurrentNumber.ToString() & "= " & intProduct.ToString()
                lstResults.Items.Add(strResult)

            Next


        End If

    End Sub

    Private Function CheckAllValid() As Boolean
        'Use this code to check if all TextFields are valid
        'It loops through each text field and checks if its valid
        'If any are invalid, it will return false

        txtMultiplier.Validate()

        Dim blnIsValid As Boolean = False

        If txtMultiplier.IsValid Then

            Dim intValue As Integer = Convert.ToInt32(txtMultiplier.GetValue())

            If intValue > 0 Then

                blnIsValid = True

            Else

                txtMultiplier.InvalidInput("Must Be Over 0!")

            End If

        End If

        Return blnIsValid


    End Function

    Private Sub MultiplicationTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the program starts

        txtMultiplier.SetName("Multiplier")
        txtMultiplier.SetType(Fields.TextType.Whole)

    End Sub

End Class
