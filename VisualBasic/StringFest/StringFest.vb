'Program Name: String Festival
'Programmer  : Ben Crocker
'Date        : 10/23/20
'Purpose     : Reformat the user's name

'Test Case: Benjamin Wade Crocker
'Expected: CROCKER, BENJAMIN WADE

Option Strict On

Public Class StringFest

    Private Sub btnProccess_Click(sender As Object, e As EventArgs) Handles btnProccess.Click
        'This code is executed whenever the user clicks the Proccess button
        'It first gets the value of the name input field
        'It then makes sure that the name input field is not empty
        'Then, it gets the position of the first and last space in the string
        'If it can't find a space, or both the first and last are the same, then there aren't enough spaces to proccess the name, so we inform the user
        'Next it gets the first, middle, and last names using the SubString method
        'Finally, it outputs the reformatted name

        Dim strInputName As String = txtInputName.Text
        Dim intInputNameLength = strInputName.Length

        If intInputNameLength > 0 Then

            Dim intFirstSpaceIndex As Integer = strInputName.IndexOf(" "c)
            Dim intLastSpaceIndex As Integer = strInputName.LastIndexOf(" "c)

            If intFirstSpaceIndex * intLastSpaceIndex > 0 And intFirstSpaceIndex <> intLastSpaceIndex Then

                Dim strFirstName As String = strInputName.Substring(0, intFirstSpaceIndex)
                Dim strMiddleName As String = strInputName.Substring(intFirstSpaceIndex, intLastSpaceIndex - intFirstSpaceIndex)
                Dim strLastName As String = strInputName.Substring(intLastSpaceIndex, intInputNameLength - intLastSpaceIndex)

                lblOutputName.Text = $"Your Formatted Name: {strLastName.ToUpper()}, {strFirstName.ToUpper()} {strMiddleName.ToUpper()}"
                lblOutputName.Visible = True

            Else

                MsgBox("Name must have two spaces that arent at the beggining/end!")
                lblOutputName.Visible = False

            End If

        Else

            MsgBox("Name Cannot Be empty!")
            lblOutputName.Visible = False

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed
        'It clears the current value of the name input field

        txtInputName.Clear()
        lblOutputName.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run whenever the exit button is pressed
        'It exits the program

        Close()

    End Sub

End Class
