'Program Name: CookTurkey
'Programmer  : b_crocker
'Date		 : 3/1/2021 1:53:38 PM
'Purpose     : Show the time it takes to cook a turkey in a range of pounds


Option Strict On

Public Class CookTurkey

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        lstResults.Items.Clear()

        Const _cintMinutesPerPound As Integer = 17

        For intCurrentPounds = 8 To 30

            Dim intMinutesTaken As Integer = intCurrentPounds * _cintMinutesPerPound
            Dim intHoursTaken = intMinutesTaken \ 60
            Dim intMinutesRemaining = intMinutesTaken Mod 60
            lstResults.Items.Add(intCurrentPounds & " - " & intHoursTaken.ToString() & " Hours " & intMinutesRemaining.ToString() & " Minutes")

        Next

    End Sub


End Class
