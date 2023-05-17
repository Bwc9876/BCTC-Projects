'Program Name: VideoGames
'Programmer  : BenCro855
'Date		 : 9/6/2022 2:34:45 PM
'Purpose     : Display the cool games of 2022


Option Strict On

Imports System.IO

Public Class VideoGames

    ''' <summary>
    ''' Represents a top game of 2022
    ''' </summary>
    Private Class Game

        Implements IComparable(Of Game)

        ''' <summary>
        ''' Constructs a new Game object
        ''' </summary>
        ''' <param name="name">The name of the new game</param>
        ''' <param name="downloads">The downloads the game has</param>
        Sub New(name As String, downloads As Integer)
            Me.Downloads = downloads
            Me.Name = name
        End Sub

        ''' <summary>
        ''' Display the name of the Game in list boxes and other form elements
        ''' </summary>
        ''' <returns>The name of the game</returns>
        Public Overrides Function ToString() As String
            Return Name
        End Function

        ''' <summary>
        ''' Makes it so when sorting a list with Games, it'll use download count to compare
        ''' </summary>
        ''' <param name="other">The other game to compare to</param>
        ''' <returns>A signed integer value representing which game has higher downloads, or 0 if they're equal</returns>
        Public Function CompareTo(other As Game) As Integer Implements IComparable(Of Game).CompareTo
            Return Downloads.CompareTo(other.Downloads) * -1
        End Function

        ''' <summary>
        ''' The name of the game
        ''' </summary>
        Public ReadOnly Property Name As String

        ''' <summary>
        ''' The downloads the game got this year
        ''' </summary>
        Public ReadOnly Property Downloads As Integer
    End Class

    Private Const FilePath As String = "C:\Users\bencro855\Downloads\mobile.txt"

    ''' <summary>
    ''' Loads the games text file into the list box and computes total downloads
    ''' </summary>
    Private Sub VideoGames_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstLines = File.ReadAllLines(FilePath)

        Dim lstRawGames As New List(Of Game)()

        For intLineNumber = 0 To lstLines.Length - 1 Step 2
            Try
                lstRawGames.Add(New Game(lstLines(intLineNumber), Convert.ToInt32(lstLines(intLineNumber + 1))))
            Catch fe As FormatException
                MessageBox.Show("Can't load games!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Close()
            End Try
        Next

        ' Sorts by download count
        lstRawGames.Sort()

        lstGames.Items.AddRange(lstRawGames.ToArray())
        lblTotal.Text = lstRawGames.Sum(Function(game) game.Downloads).ToString()
    End Sub

    ''' <summary>
    ''' Changes which download count to display, hides if nothing is selected
    ''' </summary>
    Private Sub lstGames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstGames.SelectedIndexChanged

        lblDownloads.Visible = lstGames.SelectedIndex <> -1

        If lstGames.SelectedIndex <> -1 Then
            lblDownloads.Text = CType(lstGames.SelectedItem, Game).Downloads.ToString()
        End If
    End Sub

    ''' <summary>
    ''' Exits
    ''' </summary>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    ''' <summary>
    ''' Sorts the game list by the name of each game and displays it in a message box
    ''' </summary>
    Private Sub btnAlpha_Click(sender As Object, e As EventArgs) Handles btnAlpha.Click
        Dim linGames = New List(Of Game)(lstGames.Items.OfType(Of Game))
        linGames.Sort(Function(a, b) a.Name.CompareTo(b.Name))
        MessageBox.Show(String.Join(", ", linGames))
    End Sub

End Class
