'Program Name: Job Research
'Developer: Ben Crocker
'Date: 9-14-20
'Purpose: Inform the user of multiple jobs in the IT programming field

'Imports namespaces so I can use the multiline text editor in the properties window
Imports System.ComponentModel
Imports System.Drawing.Design

Public Class frmJobResearch

    'This property represents the currently selected job
    Private Property jobSelected As Job

    Sub frmJobResearch_Load(sender As Object, e As System.EventArgs) Handles MyBase.Load
        'This code is executed when the program starts, it goes trough every control in the form,
        'checks if it's a Job object, and if it is,
        'it adds the jobClicked handler to it.

        For Each ctrJob As Control In grpJobSelect.Controls

            If ctrJob.GetType() Is GetType(Job) Then

                Dim job As Job = CType(ctrJob, Job)
                AddHandler job.Click, AddressOf jobClicked

            End If

        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This code is executed when the user clicks the exit button, it exits the application.

        Close()

    End Sub

    Private Sub jobClicked(sender As Job, e As EventArgs)
        'This code is executed whenever a job is clicked
        'it first checks to see if the selected job is the same as the one clicked,
        'if it is, then nothing needs to be changed and the function returns.
        'It then Deactivates the currently selected job and then
        'it sets the text of txtDetails, txtSalary, and txtEducation
        'to the job's details, salary, and education respectively
        'it also sets the Image of imgJobPicture to the job's image.
        'Finally, the selected job is set to the clicked job and the clicked job is activated

        If jobSelected Is sender Then
            Return
        End If

        jobSelected?.DeActivate()
        txtDetails.Text = sender.strDetails
        txtSalary.Text = "$" + sender.strSalary + "/Year"
        txtEducation.Text = sender.strEducation
        picJobPicture.Image = sender.picJobImage
        jobSelected = sender
        jobSelected.Activate()

    End Sub

End Class



Partial Class Job
    'This is a class that represents a job,
    'it has the details of the job, the education for the job, 
    'the salary for the job, and the image for the job as variables.
    'It inherits from a button, making it so I can easily place it in the form editor and set variables there

    Inherits Button
    <Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design", GetType(UITypeEditor))>
    Public Property strDetails As String
    <Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design", GetType(UITypeEditor))>
    Public Property strEducation As String
    Public Property picJobImage As Image
    Public Property strSalary As String

    Public Sub Activate()
        'This code is called from the form, it sets the BackColor of the job to green to signify it is selected

        BackColor = Color.FromArgb(100, 163, 227, 1)

    End Sub

    Public Sub DeActivate()
        'This code is called from the form, it sets the BackColor of the job to the form's (LightCyan) to signify it is not selected

        BackColor = Color.LightCyan

    End Sub

End Class
