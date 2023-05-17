<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmJobResearch
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmJobResearch))
        Me.grpJobSelect = New System.Windows.Forms.GroupBox()
        Me.jobSoftwareDeveloper = New JobResearch.Job()
        Me.jobProjectManager = New JobResearch.Job()
        Me.jobDBAdmin = New JobResearch.Job()
        Me.jobProgrammer = New JobResearch.Job()
        Me.jobWebDeveloper = New JobResearch.Job()
        Me.jobSupportSpecialist = New JobResearch.Job()
        Me.jobSecurityAnalyst = New JobResearch.Job()
        Me.grpDetails = New System.Windows.Forms.GroupBox()
        Me.txtDetails = New System.Windows.Forms.RichTextBox()
        Me.grpEducation = New System.Windows.Forms.GroupBox()
        Me.txtEducation = New System.Windows.Forms.RichTextBox()
        Me.grpImage = New System.Windows.Forms.GroupBox()
        Me.picJobPicture = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpSalary = New System.Windows.Forms.GroupBox()
        Me.txtSalary = New System.Windows.Forms.RichTextBox()
        Me.grpJobSelect.SuspendLayout()
        Me.grpDetails.SuspendLayout()
        Me.grpEducation.SuspendLayout()
        Me.grpImage.SuspendLayout()
        CType(Me.picJobPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSalary.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpJobSelect
        '
        Me.grpJobSelect.BackColor = System.Drawing.Color.LightCyan
        Me.grpJobSelect.Controls.Add(Me.jobSoftwareDeveloper)
        Me.grpJobSelect.Controls.Add(Me.jobProjectManager)
        Me.grpJobSelect.Controls.Add(Me.jobDBAdmin)
        Me.grpJobSelect.Controls.Add(Me.jobProgrammer)
        Me.grpJobSelect.Controls.Add(Me.jobWebDeveloper)
        Me.grpJobSelect.Controls.Add(Me.jobSupportSpecialist)
        Me.grpJobSelect.Controls.Add(Me.jobSecurityAnalyst)
        Me.grpJobSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpJobSelect.Location = New System.Drawing.Point(12, 6)
        Me.grpJobSelect.Name = "grpJobSelect"
        Me.grpJobSelect.Size = New System.Drawing.Size(200, 244)
        Me.grpJobSelect.TabIndex = 0
        Me.grpJobSelect.TabStop = False
        Me.grpJobSelect.Text = "Select A Job"
        '
        'jobSoftwareDeveloper
        '
        Me.jobSoftwareDeveloper.BackColor = System.Drawing.Color.LightCyan
        Me.jobSoftwareDeveloper.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.jobSoftwareDeveloper.FlatAppearance.BorderSize = 2
        Me.jobSoftwareDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobSoftwareDeveloper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobSoftwareDeveloper.Location = New System.Drawing.Point(8, 207)
        Me.jobSoftwareDeveloper.Name = "jobSoftwareDeveloper"
        Me.jobSoftwareDeveloper.picJobImage = Global.JobResearch.My.Resources.Resources.Software_Developer
        Me.jobSoftwareDeveloper.Size = New System.Drawing.Size(187, 25)
        Me.jobSoftwareDeveloper.strDetails = resources.GetString("jobSoftwareDeveloper.strDetails")
        Me.jobSoftwareDeveloper.strEducation = resources.GetString("jobSoftwareDeveloper.strEducation")
        Me.jobSoftwareDeveloper.strSalary = "57k-100k"
        Me.jobSoftwareDeveloper.TabIndex = 10
        Me.jobSoftwareDeveloper.Text = "Software/Systems Developer"
        Me.jobSoftwareDeveloper.UseVisualStyleBackColor = False
        '
        'jobProjectManager
        '
        Me.jobProjectManager.BackColor = System.Drawing.Color.LightCyan
        Me.jobProjectManager.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.jobProjectManager.FlatAppearance.BorderSize = 2
        Me.jobProjectManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobProjectManager.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobProjectManager.Location = New System.Drawing.Point(7, 176)
        Me.jobProjectManager.Name = "jobProjectManager"
        Me.jobProjectManager.picJobImage = Global.JobResearch.My.Resources.Resources.Project_Lead
        Me.jobProjectManager.Size = New System.Drawing.Size(187, 25)
        Me.jobProjectManager.strDetails = resources.GetString("jobProjectManager.strDetails")
        Me.jobProjectManager.strEducation = resources.GetString("jobProjectManager.strEducation")
        Me.jobProjectManager.strSalary = "61k-140k"
        Me.jobProjectManager.TabIndex = 9
        Me.jobProjectManager.Text = "Project Lead/Manager "
        Me.jobProjectManager.UseVisualStyleBackColor = False
        '
        'jobDBAdmin
        '
        Me.jobDBAdmin.BackColor = System.Drawing.Color.LightCyan
        Me.jobDBAdmin.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.jobDBAdmin.FlatAppearance.BorderSize = 2
        Me.jobDBAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobDBAdmin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobDBAdmin.Location = New System.Drawing.Point(8, 144)
        Me.jobDBAdmin.Name = "jobDBAdmin"
        Me.jobDBAdmin.picJobImage = Global.JobResearch.My.Resources.Resources.Database_Admin
        Me.jobDBAdmin.Size = New System.Drawing.Size(187, 25)
        Me.jobDBAdmin.strDetails = resources.GetString("jobDBAdmin.strDetails")
        Me.jobDBAdmin.strEducation = resources.GetString("jobDBAdmin.strEducation")
        Me.jobDBAdmin.strSalary = "47k-110k"
        Me.jobDBAdmin.TabIndex = 8
        Me.jobDBAdmin.Text = "Database Administrator "
        Me.jobDBAdmin.UseVisualStyleBackColor = False
        '
        'jobProgrammer
        '
        Me.jobProgrammer.BackColor = System.Drawing.Color.LightCyan
        Me.jobProgrammer.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.jobProgrammer.FlatAppearance.BorderSize = 2
        Me.jobProgrammer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobProgrammer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobProgrammer.Location = New System.Drawing.Point(8, 19)
        Me.jobProgrammer.Name = "jobProgrammer"
        Me.jobProgrammer.picJobImage = Global.JobResearch.My.Resources.Resources.Computer_Programmer
        Me.jobProgrammer.Size = New System.Drawing.Size(187, 25)
        Me.jobProgrammer.strDetails = resources.GetString("jobProgrammer.strDetails")
        Me.jobProgrammer.strEducation = "The recommended Education for a computer programmer is a bachelor's degree" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In " &
    "addition, you will need prior experience and knowledge for the specific language" &
    " and system that you'll be working with"
        Me.jobProgrammer.strSalary = "41k-99k"
        Me.jobProgrammer.TabIndex = 7
        Me.jobProgrammer.Text = "Computer Programmer"
        Me.jobProgrammer.UseVisualStyleBackColor = False
        '
        'jobWebDeveloper
        '
        Me.jobWebDeveloper.BackColor = System.Drawing.Color.LightCyan
        Me.jobWebDeveloper.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.jobWebDeveloper.FlatAppearance.BorderSize = 2
        Me.jobWebDeveloper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobWebDeveloper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobWebDeveloper.Location = New System.Drawing.Point(8, 51)
        Me.jobWebDeveloper.Name = "jobWebDeveloper"
        Me.jobWebDeveloper.picJobImage = Global.JobResearch.My.Resources.Resources.Web_Developer
        Me.jobWebDeveloper.Size = New System.Drawing.Size(187, 25)
        Me.jobWebDeveloper.strDetails = resources.GetString("jobWebDeveloper.strDetails")
        Me.jobWebDeveloper.strEducation = "The recommended education for a web developer is a bachelor's degree" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This job " &
    "also requires background knowledge in the specific backend and frontend framewor" &
    "ks that your website will use."
        Me.jobWebDeveloper.strSalary = "41k-86k"
        Me.jobWebDeveloper.TabIndex = 6
        Me.jobWebDeveloper.Text = "Web Developer"
        Me.jobWebDeveloper.UseVisualStyleBackColor = False
        '
        'jobSupportSpecialist
        '
        Me.jobSupportSpecialist.BackColor = System.Drawing.Color.LightCyan
        Me.jobSupportSpecialist.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.jobSupportSpecialist.FlatAppearance.BorderSize = 2
        Me.jobSupportSpecialist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobSupportSpecialist.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobSupportSpecialist.Location = New System.Drawing.Point(8, 82)
        Me.jobSupportSpecialist.Name = "jobSupportSpecialist"
        Me.jobSupportSpecialist.picJobImage = Global.JobResearch.My.Resources.Resources.Support_Specialist
        Me.jobSupportSpecialist.Size = New System.Drawing.Size(187, 25)
        Me.jobSupportSpecialist.strDetails = resources.GetString("jobSupportSpecialist.strDetails")
        Me.jobSupportSpecialist.strEducation = "The recommended education for a user support specialist is 1-2 years of training" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This job also needs well versed knowledge in the system that you're supportin" &
    "g."
        Me.jobSupportSpecialist.strSalary = "47k"
        Me.jobSupportSpecialist.TabIndex = 5
        Me.jobSupportSpecialist.Text = "User Support Specialist"
        Me.jobSupportSpecialist.UseVisualStyleBackColor = False
        '
        'jobSecurityAnalyst
        '
        Me.jobSecurityAnalyst.BackColor = System.Drawing.Color.LightCyan
        Me.jobSecurityAnalyst.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.jobSecurityAnalyst.FlatAppearance.BorderSize = 2
        Me.jobSecurityAnalyst.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.jobSecurityAnalyst.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jobSecurityAnalyst.Location = New System.Drawing.Point(8, 113)
        Me.jobSecurityAnalyst.Name = "jobSecurityAnalyst"
        Me.jobSecurityAnalyst.picJobImage = Global.JobResearch.My.Resources.Resources.Information_Security_Analyst
        Me.jobSecurityAnalyst.Size = New System.Drawing.Size(187, 25)
        Me.jobSecurityAnalyst.strDetails = resources.GetString("jobSecurityAnalyst.strDetails")
        Me.jobSecurityAnalyst.strEducation = resources.GetString("jobSecurityAnalyst.strEducation")
        Me.jobSecurityAnalyst.strSalary = "48k-88k"
        Me.jobSecurityAnalyst.TabIndex = 4
        Me.jobSecurityAnalyst.Text = "Information Security Analyst"
        Me.jobSecurityAnalyst.UseVisualStyleBackColor = False
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.txtDetails)
        Me.grpDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpDetails.Location = New System.Drawing.Point(218, 6)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(262, 403)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Details"
        '
        'txtDetails
        '
        Me.txtDetails.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetails.CausesValidation = False
        Me.txtDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetails.Location = New System.Drawing.Point(6, 19)
        Me.txtDetails.Name = "txtDetails"
        Me.txtDetails.ReadOnly = True
        Me.txtDetails.Size = New System.Drawing.Size(250, 377)
        Me.txtDetails.TabIndex = 2
        Me.txtDetails.Text = "Details for the job you select will be put here"
        '
        'grpEducation
        '
        Me.grpEducation.BackColor = System.Drawing.Color.LightCyan
        Me.grpEducation.Controls.Add(Me.txtEducation)
        Me.grpEducation.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpEducation.Location = New System.Drawing.Point(486, 232)
        Me.grpEducation.Name = "grpEducation"
        Me.grpEducation.Size = New System.Drawing.Size(302, 239)
        Me.grpEducation.TabIndex = 2
        Me.grpEducation.TabStop = False
        Me.grpEducation.Text = "Education"
        '
        'txtEducation
        '
        Me.txtEducation.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtEducation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEducation.CausesValidation = False
        Me.txtEducation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.1!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEducation.Location = New System.Drawing.Point(6, 21)
        Me.txtEducation.Name = "txtEducation"
        Me.txtEducation.ReadOnly = True
        Me.txtEducation.Size = New System.Drawing.Size(290, 211)
        Me.txtEducation.TabIndex = 1
        Me.txtEducation.Text = "Recommended education for the job you select will be put here"
        '
        'grpImage
        '
        Me.grpImage.Controls.Add(Me.picJobPicture)
        Me.grpImage.Location = New System.Drawing.Point(486, 6)
        Me.grpImage.Name = "grpImage"
        Me.grpImage.Size = New System.Drawing.Size(302, 227)
        Me.grpImage.TabIndex = 3
        Me.grpImage.TabStop = False
        Me.grpImage.Text = "Image"
        '
        'picJobPicture
        '
        Me.picJobPicture.BackColor = System.Drawing.SystemColors.Control
        Me.picJobPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.picJobPicture.Image = Global.JobResearch.My.Resources.Resources.No_Job2
        Me.picJobPicture.Location = New System.Drawing.Point(6, 19)
        Me.picJobPicture.Name = "picJobPicture"
        Me.picJobPicture.Size = New System.Drawing.Size(290, 201)
        Me.picJobPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picJobPicture.TabIndex = 0
        Me.picJobPicture.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightCyan
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(21, 447)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(186, 24)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'grpSalary
        '
        Me.grpSalary.BackColor = System.Drawing.Color.LightCyan
        Me.grpSalary.Controls.Add(Me.txtSalary)
        Me.grpSalary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpSalary.Location = New System.Drawing.Point(218, 409)
        Me.grpSalary.Name = "grpSalary"
        Me.grpSalary.Size = New System.Drawing.Size(262, 62)
        Me.grpSalary.TabIndex = 5
        Me.grpSalary.TabStop = False
        Me.grpSalary.Text = "Salary"
        '
        'txtSalary
        '
        Me.txtSalary.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSalary.BackColor = System.Drawing.Color.FromArgb(CType(CType(163, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.txtSalary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalary.CausesValidation = False
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalary.Location = New System.Drawing.Point(6, 19)
        Me.txtSalary.Multiline = False
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.ReadOnly = True
        Me.txtSalary.Size = New System.Drawing.Size(247, 36)
        Me.txtSalary.TabIndex = 3
        Me.txtSalary.Text = "$0k/year"
        '
        'frmJobResearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(800, 485)
        Me.Controls.Add(Me.grpSalary)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.grpImage)
        Me.Controls.Add(Me.grpEducation)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.grpJobSelect)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmJobResearch"
        Me.ShowIcon = False
        Me.Text = "Job Research"
        Me.grpJobSelect.ResumeLayout(False)
        Me.grpDetails.ResumeLayout(False)
        Me.grpEducation.ResumeLayout(False)
        Me.grpImage.ResumeLayout(False)
        CType(Me.picJobPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSalary.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpJobSelect As GroupBox
    Friend WithEvents grpDetails As GroupBox
    Friend WithEvents txtDetails As RichTextBox
    Friend WithEvents grpEducation As GroupBox
    Friend WithEvents txtEducation As RichTextBox
    Friend WithEvents grpImage As GroupBox
    Friend WithEvents picJobPicture As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents jobProgrammer As Job
    Friend WithEvents jobWebDeveloper As Job
    Friend WithEvents jobSupportSpecialist As Job
    Friend WithEvents jobSecurityAnalyst As Job
    Friend WithEvents jobSoftwareDeveloper As Job
    Friend WithEvents jobProjectManager As Job
    Friend WithEvents jobDBAdmin As Job
    Friend WithEvents grpSalary As GroupBox
    Friend WithEvents txtSalary As RichTextBox
End Class
