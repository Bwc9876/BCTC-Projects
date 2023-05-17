'Program Name: FizzBuzz
'Programmer  : Benjamin Crocker
'Date		 : 3/1/2021 12:14:59 PM
'Purpose     : Play the game "FizzBuzz"

'Test Cases:
'
' {3, 5} {"Fizz", "Buzz"}
'
'    1: 1
'    2: 2
'    3: Fizz
'    4: 4
'    5: Buzz
'    ...
'    15: FizzBuzz
'
' {3, 5, 10} {"Fizz", "Buzz", "Pop"}
'
'    1: 1
'    2: 2
'    3: Fizz
'    4: 4
'    5: Buzz
'    ...
'    10: BuzzPop
'    ...
'    15: FizzBuzz
'    ...
'    30: FizzBuzzPop
'


Option Strict On

Public Class FizzBuzz

    Private Function getWord() As String
        'This function is used to get a word form the user
        'It gets the word, validates it, and then returns it

        Dim blnDone As Boolean = False
        Dim strWord As String

        Do While blnDone = False

            strWord = InputBox("Enter New Word", "Input Data")

            If strWord.Length <> 0 Then

                blnDone = True

            Else

                MsgBox("Word Cant Be Empty!",, "Input Error")

            End If

        Loop

        Return strWord


    End Function

    Private Function getMultiplier() As Integer
        'This code is run to get a multiplier from the user
        'It gets the multiplier, validates it, and returns it

        Dim blnDone As Boolean = False
        Dim intMultipler As Integer

        Do While blnDone = False

            Dim strRawMult As String = InputBox("Enter New Multiplier", "Input Data")

            If strRawMult.Length <> 0 Then

                Try

                    intMultipler = Convert.ToInt32(strRawMult)

                    If intMultipler > 0 Then

                        blnDone = True

                    Else

                        MsgBox("Mulitplier Must Be Over 0!",, "Input Error")
                        intMultipler = Nothing

                    End If

                Catch fe As FormatException

                    MsgBox("Multiplier Must Be Numeric!",, "Input Error")

                Catch oe As OverflowException

                    MsgBox("Multiplier Too Big!",, "Input Error")

                End Try

            Else

                MsgBox("Multiplier Cant Be Empty!",, "Input Error")

            End If

        Loop

        Return intMultipler

    End Function

    Private Sub btnMultAdd_Click(sender As Object, e As EventArgs) Handles btnMultAdd.Click
        'This code is run whenever the Add button is pressed under the multipliers listbox
        'It gets the new multiplier from the user and adds it

        Dim intNewMultiplier As Integer = getMultiplier()
        lstMultipliers.Items.Add(intNewMultiplier)

    End Sub

    Private Sub btnMultEdit_Click(sender As Object, e As EventArgs) Handles btnMultEdit.Click
        'This code is run whever the edit button under the multipliers list box is pressed
        'It makes sure that a multiplier is selected, and edits the selected one

        If lstMultipliers.SelectedIndex = -1 Then

            MsgBox("Please Select An Item First!")

        Else

            lstMultipliers.Items(lstMultipliers.SelectedIndex) = getMultiplier().ToString()

        End If

    End Sub

    Private Sub btnMultDelete_Click(sender As Object, e As EventArgs) Handles btnMultDelete.Click
        'This code is run whenever the Delete button under the multipliers listbox is pressed
        'It removes the selected multiplier (if any) from the listbox

        If lstMultipliers.SelectedIndex = -1 Then

            MsgBox("Select an item in the list first!",, "Please select an item")

        Else

            lstMultipliers.Items.RemoveAt(lstMultipliers.SelectedIndex)

        End If

    End Sub

    Private Sub btnMultShiftUp_Click(sender As Object, e As EventArgs) Handles btnMultShiftUp.Click
        'This code is run whenever the shift up button under the multipliers list box is pressed
        'It shifts the selected multiplier (if any) up

        If lstMultipliers.SelectedIndex = -1 Then

            MsgBox("Select an item in the list first!",, "Please select an item")

        Else

            Dim intCurrentIndex As Integer = lstMultipliers.SelectedIndex
            Dim intNewIndex As Integer

            intNewIndex = intCurrentIndex - 1

            If intNewIndex < 0 Then
                intNewIndex = 0
            End If

            Dim intTempItem As Integer = Convert.ToInt32(lstMultipliers.Items(intCurrentIndex))
            lstMultipliers.Items.RemoveAt(intCurrentIndex)
            lstMultipliers.Items.Insert(intNewIndex, intTempItem)
            lstMultipliers.SelectedIndex = intNewIndex

        End If

    End Sub

    Private Sub btnMultShiftDown_Click(sender As Object, e As EventArgs) Handles btnMultShiftDown.Click
        'This code is run whenever the shift down button under the multipliers list box is pressed
        'It shifts the selected multiplier (if any) down

        If lstMultipliers.SelectedIndex = -1 Then

            MsgBox("Select an item in the list first!",, "Please select an item")

        Else

            Dim intCurrentIndex As Integer = lstMultipliers.SelectedIndex
            Dim intNewIndex As Integer

            intNewIndex = intCurrentIndex + 1

            If intNewIndex > lstMultipliers.Items.Count - 1 Then
                intNewIndex = lstMultipliers.Items.Count - 1
            End If

            Dim intTempItem As Integer = Convert.ToInt32(lstMultipliers.Items(intCurrentIndex))
            lstMultipliers.Items.RemoveAt(intCurrentIndex)
            lstMultipliers.Items.Insert(intNewIndex, intTempItem)
            lstMultipliers.SelectedIndex = intNewIndex

        End If

    End Sub

    Private Sub btnWrdAdd_Click(sender As Object, e As EventArgs) Handles btnWrdAdd.Click
        'This code is run whenever the Add button is pressed under the words listbox
        'It gets the new multiplier from the user and adds it

        Dim strNewWord As String = getWord()
        lstWords.Items.Add(strNewWord)

    End Sub

    Private Sub btnWrdEdit_Click(sender As Object, e As EventArgs) Handles btnWrdEdit.Click
        'This code is run whever the edit button under the words list box is pressed
        'It makes sure that a word is selected, and edits the selected one

        If lstWords.SelectedIndex = -1 Then

            MsgBox("Please Select An Item First!")

        Else

            lstWords.Items(lstWords.SelectedIndex) = getWord()

        End If

    End Sub

    Private Sub btnWrdDelete_Click(sender As Object, e As EventArgs) Handles btnWrdDelete.Click
        'This code is run whenever the Delete button under the words listbox is pressed
        'It removes the selected word (if any) from the listbox

        If lstWords.SelectedIndex = -1 Then

            MsgBox("Select an item in the list first!",, "Please select an item")

        Else

            lstWords.Items.RemoveAt(lstWords.SelectedIndex)

        End If

    End Sub

    Private Sub btnWrdShiftUp_Click(sender As Object, e As EventArgs) Handles btnWrdShiftUp.Click
        'This code is run whenever the shift up button under the words list box is pressed
        'It shifts the selected word (if any) up

        If lstWords.SelectedIndex = -1 Then

            MsgBox("Select an item in the list first!",, "Please select an item")

        Else

            Dim intCurrentIndex As Integer = lstWords.SelectedIndex
            Dim intNewIndex As Integer

            intNewIndex = intCurrentIndex - 1

            If intNewIndex < 0 Then
                intNewIndex = 0
            End If

            Dim strTempItem As String = lstWords.Items(intCurrentIndex).ToString()
            lstWords.Items.RemoveAt(intCurrentIndex)
            lstWords.Items.Insert(intNewIndex, strTempItem)
            lstWords.SelectedIndex = intNewIndex

        End If

    End Sub

    Private Sub btnWrdShiftDown_Click(sender As Object, e As EventArgs) Handles btnWrdShiftDown.Click
        'This code is run whenever the shift down button under the words list box is pressed
        'It shifts the selected word (if any) down

        If lstWords.SelectedIndex = -1 Then

            MsgBox("Select an item in the list first!",, "Please select an item")

        Else

            Dim intCurrentIndex As Integer = lstWords.SelectedIndex
            Dim intNewIndex As Integer

            intNewIndex = intCurrentIndex + 1

            If intNewIndex > lstWords.Items.Count - 1 Then
                intNewIndex = lstWords.Items.Count - 1
            End If

            Dim strTempItem As String = lstWords.Items(intCurrentIndex).ToString()
            lstWords.Items.RemoveAt(intCurrentIndex)
            lstWords.Items.Insert(intNewIndex, strTempItem)
            lstWords.SelectedIndex = intNewIndex

        End If

    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        'This code is run whenever the start button is pressed
        'It first amkes sure there is an equal number of multipliers and words
        'It then clears the last results, and begins FizzBuzz
        'FizzBuzz works by first making an empty string, for every multiple in the list,
        'Add the corresponding word if applicable
        'In the end if the string is empty, replace it with the number itself
        'Finally, add that string to the results

        If lstMultipliers.Items.Count = lstWords.Items.Count Then

            lstResults.Items.Clear()

            For intCurrentNumber As Integer = 1 To 100

                Dim strOutputValue As String = ""

                For intCurrentIndex As Integer = 0 To lstMultipliers.Items.Count - 1

                    Dim intMultiplier As Integer = Convert.ToInt32(lstMultipliers.Items(intCurrentIndex))

                    If intCurrentNumber Mod intMultiplier = 0 Then

                        strOutputValue &= lstWords.Items(intCurrentIndex).ToString()

                    End If

                Next

                If strOutputValue = "" Then

                    strOutputValue = intCurrentNumber.ToString()

                End If

                lstResults.Items.Add(strOutputValue)

            Next

        Else

            MsgBox("Unbalanced Sides!")

        End If

    End Sub

    Private Sub FizzBuzz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code is run at the start fo the application
        'It adds the default multpliers and words to their corresponding lists
        'The defualt is the normal rules of fizzbuzz

        lstMultipliers.Items.Add(3)
        lstMultipliers.Items.Add(5)
        lstWords.Items.Add("Fizz")
        lstWords.Items.Add("Buzz")

    End Sub

End Class
