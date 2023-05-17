'Program Name: Item Tracker
'Programmer:   Ben Crocker
'Date:         10/26/20
'Purpose:      Assist the user in organizing items and moving them

'Test Case:
'   Input:
'       Item 1: Pizza52A4356
'       Item 2: Donut45C3489
'       Item 3: Bagel52A4786
'   Expected Output:
'       Item 1: Pizza62B4356
'       Item 2: Donut45C3489
'       Item 3: Bagel62B4786

Option Strict On

Public Class ItemTracker

    Private Class Item
        'A class that represents an item

        Public Property strWarehouse As String
        Private Property strDescription As String
        Private Property intShelf As Integer
        Private Property intBin As Integer

        Public Sub New(strRawItem As String)
            'This constructor takes a string
            'It then gets data from the string regarding the item

            strDescription = strRawItem.Substring(0, 5)
            strWarehouse = strRawItem.Substring(5, 3)
            intShelf = Convert.ToInt32(strRawItem.Substring(8, 2))
            intBin = Convert.ToInt32(strRawItem.Substring(10, 2))

        End Sub

        Public Overrides Function ToString() As String
            'This overrides the ToString method
            'It returns the item details seperated by hyphens so they can be properly displayed

            Return strDescription & "-" & strWarehouse & "-" & intShelf.ToString() & "-" & intBin.ToString()

        End Function

        Public Function ToRawString() As String
            'This function returns the item in it's raw form

            Return strDescription & strWarehouse & intShelf.ToString() & intBin.ToString()

        End Function

    End Class

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        'This code is executed everytime the user clicks the add item button
        'It first gets and stores teh value of the ItemAdd textbox
        'It then checks the value to make sure it isn't empty, and that the last 4 characters are numeric
        'Then, it adds an item to the lstcurrent ListBox using the value in txtItemAdd as the source for the constructor
        'Finally, it clears the textbox so the user can easily type in another value

        Dim strRawItem As String = txtItemAdd.Text

        If strRawItem.Length = 12 Then

            If IsNumeric(strRawItem.Substring(8, 4)) Then

                lstCurrent.Items.Add(New Item(strRawItem))
                txtItemAdd.Clear()
                txtItemAdd.Select()

            Else

                MsgBox("Item Shelf # and Bin # Must be numeric!",, "Invalid Input")

            End If

        Else

            MsgBox("Item Identifier Must Be 12 Characters!",, "Invalid Input")

        End If

    End Sub


    Const strWarehouseOnFire As String = "52A"
    Const strNewWarehouse As String = "62B"

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click
        'This code is executed everytime the Process button is pressed
        'It first clears the current items in the lstUpdated list box
        'It then goes through each item in the lstCurrent List Box and copies it to itmToAdd
        'Then, it see if the warehouse the item is in is on fire, if it is, we move it to the new one
        'Finally, we add itmToAdd to the lstUpdated ListBox

        lstUpdated.Items.Clear()

        For Each itmItem As Item In lstCurrent.Items

            Dim itmToAdd As Item = New Item(itmItem.ToRawString())

            If itmToAdd.strWarehouse = strWarehouseOnFire Then

                itmToAdd.strWarehouse = strNewWarehouse

            End If

            lstUpdated.Items.Add(itmToAdd)

        Next

    End Sub

    Private Sub ItemTracker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run when the form is loaded
        'It informs the user which warehouse is on fire

        lblFireWarning.Text = $"Wharehouse {strWarehouseOnFire} Is On fire, Items In It Will Be Moved To {strNewWarehouse}"

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run everytime the user clicks the clear button
        'It clears both listboxes and the ItemAdd text box

        lstCurrent.Items.Clear()
        lstUpdated.Items.Clear()
        txtItemAdd.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is executed whenever he user clicks the Exit button
        'It exits the program

        Close()

    End Sub

End Class
