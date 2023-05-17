Public Class ArtFinals
    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim strSQL As String = "SELECT * FROM ARTIST"

        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=D:\School\BCTC\Database\Access\Art.accdb"
        Dim odaArtist As New OleDb.OleDbDataAdapter(strSQL, strPath)

        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        odaArtist.Fill(datValue)
        odaArtist.Dispose()

        For intCount = 0 To datValue.Rows.Count - 1

            decTotalValue += Convert.ToDecimal(datValue.Rows(intCount)("Retail Price"))

        Next

        lblResults.Text = "Total Retail Value Is: " & decTotalValue.ToString("c")

    End Sub

End Class
