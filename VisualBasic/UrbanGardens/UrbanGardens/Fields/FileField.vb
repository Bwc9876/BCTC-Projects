Public Class FileField

    ' Properties

    Private Property strTitle As String = "Select File"
    Private Property strFilter As String = "All Files (*.*)|*.*"

    ' Events

    Public Event FileSelected(sender As Object, e As FileSelectedEventArgs)

    ' Setters

    Public Sub SetTitle(strNewTitle As String)

        strTitle = strNewTitle

    End Sub

    Public Sub SetFilter(strNewFilter As String)

        strFilter = strNewFilter

    End Sub

    ' Getters

    Public Function GetFilePath() As String

        If txtFilePath.Text = "No File Selected" Then

            Return Nothing

        Else

            Return txtFilePath.Text

        End If

    End Function

    ' Methods

    Public Sub Clear()

        txtFilePath.Text = "No File Selected"

    End Sub

    ' Events

    Private Sub Me_layout() Handles Me.Layout

        With btnBrowse

            .Size = New Size(Size.Width \ 4, Size.Height \ 3)
            .Location = New Point(15, Size.Height \ 3 + 5)

        End With

        With txtFilePath

            .Size = New Size(Size.Width - (btnBrowse.Width + 25) - 15, btnBrowse.Size.Height)
            .Location = New Point(25 + btnBrowse.Size.Width, Size.Height \ 3 + 5)

        End With

        With grpFileSelect

            .Size = Size

        End With

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click

        Dim ofdDialog As OpenFileDialog = New OpenFileDialog

        With ofdDialog

            .Title = strTitle
            .Filter = strFilter

        End With

        If ofdDialog.ShowDialog() = DialogResult.OK And ofdDialog.FileName <> "" Then

            txtFilePath.Text = ofdDialog.FileName
            Dim eventData As New FileSelectedEventArgs(ofdDialog.FileName)
            RaiseEvent FileSelected(Me, eventData)

        End If

    End Sub

End Class


Public Class FileSelectedEventArgs

    ' Inheritance

    Inherits EventArgs

    ' Properties

    Public ReadOnly Property strFilePath As String

    ' Constructor

    Public Sub New(strFilePath As String)

        Me.strFilePath = strFilePath

    End Sub

End Class
