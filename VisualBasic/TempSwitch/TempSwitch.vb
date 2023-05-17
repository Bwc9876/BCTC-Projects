'Program Name: TempSwitch
'Programmer  : Ben Crocker
'Date        : 12/3/20
'Purpose     : Let the user convert from C to F and and display a message


Option Strict On
Public Class TempSwitch

    Private Function IsValid(strValue As String) As String
        'This code is run to the the validity of the entered temperature
        'It first checks to make sure the value isnt empty
        'It then checks to see that it can be converterted to and integer
        'Finally, if the data is valid, it returns 'No Error'

        If strValue.Length > 0 Then

            Try

                Dim intTestValue As Integer = Convert.ToInt32(strValue)

                Return "No Error"

            Catch fe As FormatException

                Return "Value Must Be Numeric!"

            Catch oe As OverflowException

                Return "Value Is Too Big!"

            End Try

        Else

            Return "Value Can't Be Empty!"

        End If

    End Function

    Private Function convertToF(intTemp As Integer) As Integer
        'This code is run to convert Celcius to Farenhite

        Return Convert.ToInt32((intTemp * 1.8) + 32)

    End Function

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'This code is run whenever the Enter button is clicked
        'It first gets the text from the txtTemp textbox and validates it
        'It then casts the value to an integer and converts it to Farenhite
        'Finally, it shows a picture and a message depending on the converted temperature

        Dim strTemp As String = txtTemp.Text
        Dim strIsValid As String = IsValid(strTemp)

        If strIsValid = "No Error" Then

            Dim intFTemp As Integer = Convert.ToInt32(strTemp)
            Dim intTemp As Integer = convertToF(intFTemp)
            lblMessage.Text = intTemp.ToString() & "°F: "
            lblMessage.Visible = True

            If intTemp <= 32 Then

                picImage.Image = My.Resources.Coldest
                lblMessage.Text &= "It's Freezing!"

            ElseIf intTemp <= 45 Then

                picImage.Image = My.Resources.Colder
                lblMessage.Text &= "Pretty Cold"

            ElseIf intTemp <= 55 Then

                picImage.Image = My.Resources.Cold
                lblMessage.Text &= "Spring Incoming!"

            ElseIf intTemp <= 65 Then

                picImage.Image = My.Resources.Perfect
                lblMessage.Text &= "Perfection!"

            ElseIf intTemp <= 75 Then

                picImage.Image = My.Resources.Warm
                lblMessage.Text &= "A Bit Warm Out"

            ElseIf intTemp <= 85 Then

                picImage.Image = My.Resources.Hot
                lblMessage.Text &= "Crank the AC!"

            Else

                picImage.Image = My.Resources.Hotter
                lblMessage.Text &= "You Better Have AC!"

            End If

            Select Case intTemp
                Case Is < 33
                    picImage.Image = My.Resources.Coldest
                    lblMessage.Text &= "It's Freezing!"
                Case 33 To 45
                    picImage.Image = My.Resources.Colder
                    lblMessage.Text &= "Pretty Cold"
                Case 46 To 55
                    picImage.Image = My.Resources.Cold
                    lblMessage.Text &= "Spring Incoming!"
                Case 56 To 65
                    picImage.Image = My.Resources.Perfect
                    lblMessage.Text &= "Perfection!"
                Case 66 To 75
                    picImage.Image = My.Resources.Warm
                    lblMessage.Text &= "A Bit Warm Out"
                Case 76 To 85
                    picImage.Image = My.Resources.Hot
                    lblMessage.Text &= "Crank the AC!"
                Case Is > 85
                    picImage.Image = My.Resources.Hotter
                    lblMessage.Text &= "You Better Have AC!"
            End Select

        Else

            MsgBox(strIsValid,, "Input Error")

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run whenever the exit button is clicked
        'It exits the program

        Close()

    End Sub

End Class
