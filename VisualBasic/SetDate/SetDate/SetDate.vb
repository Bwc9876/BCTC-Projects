'Program Name: Set Time
'Programmer: Ben Crocker
'Date: 10-19-20
'Purpose: Allows the user to modify the date

Option Strict On

Public Class SetDate

    Private Sub btnSetDate_Click(sender As Object, e As EventArgs) Handles btnSetDate.Click
        'This code is run whenever the SetDate button is clicked
        'It first gets the date from the DatePicker
        'It then displays the date
        'It then adds 6 days to the date and outputs the result
        'It then subtracts two months from the date and outputs the result
        'It finally adds three years to the date and outputs the result

        Dim timSetDate As Date = dtpTimePicker.Value

        MsgBox("Date: " & timSetDate.ToLongDateString(), , "Set Date")

        MsgBox("Date + 6 Days: " & timSetDate.AddDays(6).ToLongDateString(), , "Modified Date")

        MsgBox("Date - 2 Months: " & timSetDate.AddMonths(-2).ToLongDateString(), , "Modified Date")

        MsgBox("Date + 3 Years: " & timSetDate.AddYears(3).ToLongDateString(), , "Modified Date")

    End Sub

End Class
