'Program Name: BobCatMotors
'Programmer  : Ben Crocker
'Date		 : 8/30/2021
'Purpose     : Displays the employees that match the code selected


Option Strict On

Public Class BobCatMotors

    Private Structure Employee
        'This struct issued to represent an employee

        Public strCode As String
        Public strName As String

    End Structure

    Private empEmployees(99) As Employee

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed
        'It first resets the browse file field and the results ListBox
        'It then clears the employees that were loadd from a data file
        'Finally, it resets the code selection ComboBox

        txtFilePath.Text = "No File Selected"
        lstResults.Visible = False
        lstResults.Items.Clear()
        For employee As Integer = 0 To empEmployees.Length - 1

            empEmployees(employee) = Nothing

        Next
        cmbCode.Items.Clear()
        cmbCode.Enabled = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Function BrowseForDataFile() As String
        'This function opens an OpenFileDialog and asks the user to select a data file
        'It then returns that file's path

        Dim ofdDialog As OpenFileDialog = New OpenFileDialog

        ofdDialog.Title = "Select Data File"
        ofdDialog.Filter = "Data File (*.txt)|*.txt"

        If ofdDialog.ShowDialog() = DialogResult.OK And ofdDialog.FileName <> "" Then

            Return ofdDialog.FileName

        End If

        Return Nothing

    End Function

    Private Function ReadFileAsList(strFilePath As String) As String()
        'This function takes a file path and returns the line of the file a a String array

        Dim EmployeeReader As New IO.StreamReader(strFilePath)
        Dim strLines(99) As String

        Dim strLine As String = EmployeeReader.ReadLine()
        Dim intCurrentLine As Integer = 0

        While strLine IsNot Nothing

            strLines(intCurrentLine) = strLine
            intCurrentLine += 1
            strLine = EmployeeReader.ReadLine()

        End While

        Return strLines

    End Function

    Private Sub ParseLines(strLines As String())
        'This Sub grabs the lines from a file and converts them into Employee objects
        'It then stores the employees as an Array in empEmployees

        For intIndex As Integer = 0 To strLines.Length - 1

            If strLines(intIndex) IsNot Nothing Then

                Dim newEmployee As New Employee
                Dim strSplitEmployee(2) As String
                strSplitEmployee = strLines(intIndex).Split("#"c)

                With newEmployee

                    .strCode = strSplitEmployee(0)
                    .strName = strSplitEmployee(1)

                End With

                If cmbCode.Items.Contains(strSplitEmployee(0)) = False Then

                    cmbCode.Items.Add(strSplitEmployee(0))

                End If

                empEmployees(intIndex) = newEmployee

            End If

        Next

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        'This code is run when the Browse button is clicked
        'It asks the user to select a file, reads it, and then parses it into the empEmployees list
        'Finally, it enables the code selection ComboBox to let people select a code

        Dim strFilePath As String = BrowseForDataFile()

        If strFilePath IsNot Nothing Then

            txtFilePath.Text = strFilePath
            Dim strLines As String() = ReadFileAsList(strFilePath)
            ParseLines(strLines)
            cmbCode.Enabled = True

        End If

    End Sub

    Private Sub cmbCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCode.SelectedIndexChanged
        'This code is run when the cmbCode ComboBox's selected item is changed
        'It loops through all employees and checks their code against the selected one
        'If its a match, it will display the employees in the lstResult listbox

        If cmbCode.SelectedIndex <> -1 Then

            lstResults.Items.Clear()

            For Each empEmployee As Employee In empEmployees

                If empEmployee.strCode = cmbCode.SelectedItem.ToString() Then

                    lstResults.Items.Add(empEmployee.strName)

                End If

            Next

            lstResults.Visible = True

        End If

    End Sub

End Class
