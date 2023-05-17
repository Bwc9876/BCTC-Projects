'Program Name: Credit Cards
'Programmer  : Ben Crocker
'Date        : 12/3/20
'Purpose     : Have the user select a credit card and show information about it

Option Strict On
Public Class CreditCards

    Private Sub CardSelected(sender As Object, e As EventArgs)
        'This code is run whenever the Checked value of a card type is changed
        'It first determines what picBox to show to the user
        'It then checks if the Checked value of the button is set to true
        'If it is, make the text black, show the image, and display the credit line
        'It it isn't, make the text grey and hide the image

        Dim picCardImage As PictureBox
        Dim btnSelectedCard As RadioButton = CType(sender, RadioButton)
        Dim decCreditLine As Decimal

        Select Case btnSelectedCard.Name

            Case "btnMaster"
                picCardImage = picMaster
                decCreditLine = 1500D
            Case "btnDiscover"
                picCardImage = picDiscover
                decCreditLine = 2000D
            Case "btnVisa"
                picCardImage = picVisa
                decCreditLine = 5000D
            Case "btnAmerican"
                picCardImage = picAmerican
                decCreditLine = 7500D
            Case Else
                picCardImage = picMaster
                decCreditLine = 0D

        End Select

        If btnSelectedCard.Checked Then

            btnSelectedCard.ForeColor = Color.Black
            picCardImage.Visible = True
            lblCreditLine.Text = btnSelectedCard.Text & " Credit Line Is: " & decCreditLine.ToString("C0")

        Else

            btnSelectedCard.ForeColor = Color.Gray
            picCardImage.Visible = False

        End If

    End Sub

    Private Sub CreditCards_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run at the start of the program
        'It loops thorugh each card type and adds the CardSelected CheckChanged handler to it

        For Each btnCardType As RadioButton In grpCards.Controls.OfType(Of RadioButton)

            AddHandler btnCardType.CheckedChanged, AddressOf CardSelected

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run when the exit button is clicked
        'It exits the program

        Close()

    End Sub

End Class
