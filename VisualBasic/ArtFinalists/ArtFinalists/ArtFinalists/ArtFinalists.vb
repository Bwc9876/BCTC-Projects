'Program Name: ArtFinalists
'Programmer  : b_crocker
'Date	    : 10/26/2021 2:21:27 PM
'Purpose     : Purpose Goes Here

'Test Cases:
'
'
'



Option Strict On

Public Class ArtFinalists

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run whenever the clear button is pressed

        'Insert your code for clearing here

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run everytime the exit button is pressed
        'It exits the program

        Close()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs)
        'This code is run whenever the submit button is clicked
        'It first checks to see if everything is valid before continuing
        '(Insert what it does after that here)

    End Sub

    Private Sub ArtFinalists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)
        'This code is run when the program starts

        'Initialize fields and other stuff here

    End Sub

    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub
End Class
