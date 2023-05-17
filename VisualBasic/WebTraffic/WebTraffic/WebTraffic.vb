'Program Name: WebTraffic
'Programmer: Ben Crocker
'Date: 2/26/21
'Purpose: Given a set of metrics, display the average to the user

Option Strict On


'Test Cases:
'
'----1----
' > 1
' > 2
' > 3
' > 4
' > 5
' ... Up To 12
'
' < Average: 6.50 Seconds
'
'
'----2----
' > (Nothing)
' < Would you like to cancel?
' > Yes
' < *Cancels and closes input box*
' OR
' > No
' < *Doesnt cancel*


Public Class WebTraffic

    Private Function GetMetricFromUser(metricNumber As Integer) As Double
        'This code is run to  get a metric from the user
        'It first gets the metric via an InputBox
        'If the value is empty, ask the user if they want to cancel, and cancel if they say yes
        'Otherwise, try to convert it to an integer, if it fails, inform the user
        'Otherwise, check if the value is more than zero, if so, return it, otherwise inform the user

        Dim strRawMetric = InputBox("Enter Metric #" & metricNumber.ToString() & ":", "Enter Metric", "5")

        If strRawMetric = "" Then

            Dim resUserCancel As MsgBoxResult = MsgBox("Would You Like To Cancel?", MsgBoxStyle.YesNo, "Cancel?")

            If resUserCancel = MsgBoxResult.Yes Then

                Return -2.0

            Else

                Return -1.0

            End If

        Else

            Try

                Dim dblMetric As Double = Convert.ToDouble(strRawMetric)

                If dblMetric > 0.0 Then

                    Return dblMetric

                Else

                    MsgBox("Metric Must Be Positive!",, "Input Error")
                    Return -1.0

                End If

            Catch fe As FormatException

                MsgBox("Metric must be a number!",, "Input Error")
                Return -1.0

            Catch oe As OverflowException

                MsgBox("Metric too big!",, "Input Error")
                Return -1.0

            End Try

        End If

    End Function

    Private Sub btnEnterData_Click(sender As Object, e As EventArgs) Handles btnEnterData.Click
        'This code is run everytime the enter analytics button is pressed
        'It first loops through 12 times, getting the metric from the user and saving it or exiting if neccessary
        'It then makes sure the user didnt cancel
        'Then It disables the enter analytics button
        'Next, it loops through each item in the lstMetrics ListBox and adds them up, and then gets the average
        'Finally, it shows the average in lblResults

        Const _cintMaxMetrics As Integer = 12
        Dim blnUserExited As Boolean = False

        Do Until lstMetrics.Items.Count >= _cintMaxMetrics Or blnUserExited = True

            Dim dblMetric As Double = -1.0

            Do While dblMetric = -1.0

                dblMetric = GetMetricFromUser(lstMetrics.Items.Count + 1)

            Loop

            If dblMetric = -2.0 Then

                blnUserExited = True

            Else

                lstMetrics.Items.Add(dblMetric)

            End If

        Loop

        If blnUserExited Then

            btnClear.PerformClick()

        Else

            btnEnterData.Enabled = False

            Dim intCurrentIndex As Integer = 0
            Dim dblTotalMetrics As Double = 0

            Do While intCurrentIndex < _cintMaxMetrics

                dblTotalMetrics += Convert.ToDouble(lstMetrics.Items(intCurrentIndex))
                intCurrentIndex += 1

            Loop

            Dim dblAverage As Double = dblTotalMetrics / Convert.ToDouble(_cintMaxMetrics)

            lblResults.Text = "Average: " & dblAverage.ToString("f2") & " Seconds"
            lblResults.Visible = True

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This code is run when the clear button is pressed
        'It first re-enables the input metrics button
        'It then sets the reuslts label to visible
        'Finally, it clears the Items in lstMetrics

        btnEnterData.Enabled = True
        lblResults.Visible = False
        lstMetrics.Items.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is run whenever the exit button is pressed
        'It exits the program

        Close()

    End Sub


End Class
