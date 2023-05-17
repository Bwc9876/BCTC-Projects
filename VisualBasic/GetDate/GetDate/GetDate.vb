'Program Name: Get Date
'Programmer:   Ben Crocker
'Date:         10-19-20
'Purpose:      Give the user the date/time in many formats

Option Strict On

Public Class GetDate

    Private Sub btnGetDate_Click(sender As Object, e As EventArgs) Handles btnGetDate.Click
        'This code is run whenever the Get Date button is clicked
        'It first gets the current date and stores it
        'It then Outputs the date, short date, month/year/day, and hour/minute/second

        Dim timCurrentDateTime As Date = Now

        MsgBox("Date: " & timCurrentDateTime.ToLongDateString(), , "Date/Time")

        MsgBox("Short Date: " & timCurrentDateTime.ToShortDateString(), , "Short Date")

        MsgBox("Month: " & timCurrentDateTime.Month.ToString() & Environment.NewLine &
               "Year: " & timCurrentDateTime.Year.ToString() & Environment.NewLine &
               "Day: " & timCurrentDateTime.Day.ToString(), , "Date")

        MsgBox("Hours: " & timCurrentDateTime.TimeOfDay.Hours.ToString() & Environment.NewLine &
               "Minutes: " & timCurrentDateTime.TimeOfDay.Minutes.ToString() & Environment.NewLine &
               "Seconds: " & timCurrentDateTime.TimeOfDay.Seconds.ToString(), , "Current Time")

    End Sub

End Class
