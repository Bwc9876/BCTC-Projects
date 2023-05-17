'Program Name: EvenOdd
'Programmer  : b_crocker
'Date		 : 9/7/2021
'Purpose     : Display and export even and odd numbers from a data file


Option Strict On

Public Class EvenOdd

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed
        'It Clears the even and odd lists and resets the file browse field

        lstEven.Items.Clear()
        lstOdd.Items.Clear()
        btnExport.Enabled = False
        txtFilePath.Text = "No File Selected"

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

    Private Sub ParseFileForLists(strFilePath As String)
        'This function takes a file path and adds the numbers in the file to their appropriate list boxes

        Dim EmployeeReader As New IO.StreamReader(strFilePath)

        Dim strLine As String = "Primed"

        While strLine IsNot Nothing

            strLine = EmployeeReader.ReadLine()
            Dim intNewNumber As Integer = Convert.ToInt32(strLine)
            If intNewNumber Mod 2 = 0 Then
                lstEven.Items.Add(intNewNumber)
            Else
                lstOdd.Items.Add(intNewNumber)
            End If

        End While

    End Sub

    Private Sub sortListBox(lstList As ListBox)
        'This function was made because .NET doesnt have a built-in way to sort Lists
        'Which really makes no sense considering internally the List class probably uses arrays
        'Or even if they did use something like a BinaryTree, it would be as simple as traversing said binary tree to get a sorted list
        'Like seriously why don't they have this?

        Dim intTempList(lstList.Items.Count) As Integer

        For intIndex As Integer = 0 To lstList.Items.Count - 1

            intTempList(intIndex) = Convert.ToInt32(lstList.Items(intIndex))

        Next

        Array.Sort(intTempList)

        lstList.Items.Clear()

        For intIndex As Integer = 0 To intTempList.Length - 1

            lstList.Items.Add(intTempList(intIndex))

        Next

        While lstList.Items.Contains(0)

            lstList.Items.Remove(0)

        End While

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        ' This code is run when the user clicks the Browse button
        ' It prompts the user for a data file and then loads that file into listboxes
        ' It then enables the export button

        Dim strDataFilePath As String = BrowseForDataFile()

        If strDataFilePath IsNot Nothing Then

            ParseFileForLists(strDataFilePath)
            txtFilePath.Text = strDataFilePath
            sortListBox(lstEven)
            sortListBox(lstOdd)
            lstEven.Visible = True
            lstOdd.Visible = True
            btnExport.Enabled = True

        End If

    End Sub

    Private Sub saveListBox(lstList As ListBox, strDisplayName As String)
        ' This function is used to export a listbox to a file the user specifies

        Dim sfdSaveDialog As SaveFileDialog = New SaveFileDialog()

        sfdSaveDialog.Title = $"Save {strDisplayName}s To File"
        sfdSaveDialog.FileName = $"{strDisplayName}.txt"
        sfdSaveDialog.Filter = "Data File (*.txt)|*.txt"

        If sfdSaveDialog.ShowDialog() = DialogResult.OK And sfdSaveDialog.FileName <> "" Then

            Dim fileWrite As IO.StreamWriter = New IO.StreamWriter(sfdSaveDialog.FileName)

            For Each intNumber As Integer In lstList.Items

                fileWrite.WriteLine(intNumber.ToString())

            Next

            fileWrite.Close()

        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' This code is run when the user presses the export button
        ' It saves both the Even and Odd listboxes to wherever the user selects

        saveListBox(lstEven, "Even")
        saveListBox(lstOdd, "Odd")

    End Sub

    Private Sub lstOdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOdd.SelectedIndexChanged

    End Sub
End Class
