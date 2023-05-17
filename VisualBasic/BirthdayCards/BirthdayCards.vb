
Option Strict On
Public Class Form1

    Private Function CheckForInvalidCharacters(strToCheck As String) As Boolean

        Dim blnValid As Boolean = True

        For Each chrLetter As Char In strToCheck.ToCharArray()

            If Char.IsLetter(chrLetter) = False And chrLetter <> ","c Then

                blnValid = False
                Exit For

            End If

        Next

        Return blnValid

    End Function

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        Dim strRawFriends As String = txtRawFriends.Text
        Dim strSenderName As String = txtSenderName.Text

        If strRawFriends.Length > 0 And strSenderName.Length > 0 Then

            If CheckForInvalidCharacters(strRawFriends) And CheckForInvalidCharacters(strSenderName) Then

                Dim strFriends As List(Of String) = New List(Of String)(strRawFriends.Split(","c))

                For Each strFriend As String In strFriends

                    lstFriends.Items.Add(strFriend)

                Next

                lblSignature.Text = $"From, {strSenderName}"
                btnSaveCurrent.Enabled = True
                btnSaveAll.Enabled = True
                btnPrint.Enabled = True
                btnPrintForm.Enabled = True

            Else

                MsgBox("Input Contains Invalid Characters!",, "Invalid Input")
                btnSaveCurrent.Enabled = False
                btnSaveAll.Enabled = False
                btnPrint.Enabled = False
                btnPrintForm.Enabled = False

            End If

        Else

            MsgBox("Inputs Can't Be Empty!",, "Invalid Input")
            btnSaveCurrent.Enabled = False
            btnSaveAll.Enabled = False
            btnPrint.Enabled = False
            btnPrintForm.Enabled = False

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblGreeting.Text = "Dear, Friend"
        lblSignature.Text = "From, You"
        lstFriends.Items.Clear()
        txtRawFriends.Clear()
        txtSenderName.Clear()
        btnSaveCurrent.Enabled = False
        btnSaveAll.Enabled = False
        btnPrint.Enabled = False
        btnPrintForm.Enabled = False

    End Sub

    Private Sub lstFriends_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFriends.SelectedIndexChanged

        lblGreeting.Text = $"Dear, {lstFriends.SelectedItem}"

    End Sub

    Private Sub Save(strPath As String)

        Using bmpToSave As Bitmap = New Bitmap(grpCard.Width, grpCard.Height)

            grpCard.DrawToBitmap(bmpToSave, New Rectangle(0, 0, bmpToSave.Width, bmpToSave.Height))
            bmpToSave.Save(strPath)

        End Using

    End Sub

    Private Sub btnSaveCurrent_Click(sender As Object, e As EventArgs) Handles btnSaveCurrent.Click

        If lstFriends.SelectedIndex <> -1 Then

            Dim sfdDialog As SaveFileDialog = New SaveFileDialog

            sfdDialog.Filter = "Picture (*.png)|*.png"
            sfdDialog.FileName = $"{lstFriends.SelectedItem}-Invite.png"
            sfdDialog.Title = "Save Card"

            If sfdDialog.ShowDialog() = DialogResult.OK And sfdDialog.FileName <> "" Then

                Save(sfdDialog.FileName)

            End If

        Else

            MsgBox("Select a friend from the list first!",, "Select A Friend")

        End If

    End Sub


    Private Sub btnSaveAll_Click(sender As Object, e As EventArgs) Handles btnSaveAll.Click

        Dim fsdDialog As FolderBrowserDialog = New FolderBrowserDialog

        fsdDialog.Description = "Save Cards To..."

        If fsdDialog.ShowDialog() = DialogResult.OK Then

            Cursor.Current = Cursors.WaitCursor

            For Each strFriend As String In lstFriends.Items

                lblGreeting.Text = $"Dear, {strFriend}"
                Save(fsdDialog.SelectedPath & "\" & strFriend & "-Invite.png")

            Next

        End If

        Cursor.Current = Cursors.Default

        lblGreeting.Text = "Dear, Friend"

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Close()

    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        PrintDocument1.PrinterSettings.Copies = 1
        Dim diaPrint As PrintDialog = New PrintDialog
        If diaPrint.ShowDialog = DialogResult.OK Then

            PrintDocument1.PrinterSettings = diaPrint.PrinterSettings
            PrintDocument1.Print()

        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim fntFont As Font = lblGreeting.Font
        e.Graphics.DrawString($"{lblGreeting.Text.ToString()}", fntFont, Brushes.Black, 100, 100)
        e.Graphics.DrawString($"{lblBody.Text.ToString()}", fntFont, Brushes.Black, 100, 400)
        e.Graphics.DrawString($"{lblSignature.Text.ToString()}", fntFont, Brushes.Black, 100, 700)

    End Sub

    Private Sub btnPrintForm_Click(sender As Object, e As EventArgs) Handles btnPrintForm.Click

        PrintForm1.Print()

    End Sub

End Class
