<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnSaveAll = New System.Windows.Forms.Button()
        Me.grpCard = New System.Windows.Forms.Panel()
        Me.lblSignature = New System.Windows.Forms.Label()
        Me.lblBody = New System.Windows.Forms.Label()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRawFriends = New System.Windows.Forms.TextBox()
        Me.lstFriends = New System.Windows.Forms.ListBox()
        Me.btnSaveCurrent = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSenderName = New System.Windows.Forms.TextBox()
        Me.lblEnterName = New System.Windows.Forms.Label()
        Me.lblFriends = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.btnPrintForm = New System.Windows.Forms.Button()
        Me.grpCard.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSaveAll
        '
        Me.btnSaveAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaveAll.Enabled = False
        Me.btnSaveAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnSaveAll.FlatAppearance.BorderSize = 2
        Me.btnSaveAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveAll.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveAll.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnSaveAll.Location = New System.Drawing.Point(420, 650)
        Me.btnSaveAll.Name = "btnSaveAll"
        Me.btnSaveAll.Size = New System.Drawing.Size(130, 32)
        Me.btnSaveAll.TabIndex = 5
        Me.btnSaveAll.Text = "Save All"
        Me.btnSaveAll.UseVisualStyleBackColor = False
        '
        'grpCard
        '
        Me.grpCard.BackgroundImage = Global.BirthdayCards.My.Resources.Resources.CardTemplateBG
        Me.grpCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.grpCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grpCard.Controls.Add(Me.lblSignature)
        Me.grpCard.Controls.Add(Me.lblBody)
        Me.grpCard.Controls.Add(Me.lblGreeting)
        Me.grpCard.Location = New System.Drawing.Point(17, 12)
        Me.grpCard.Name = "grpCard"
        Me.grpCard.Size = New System.Drawing.Size(634, 433)
        Me.grpCard.TabIndex = 1
        '
        'lblSignature
        '
        Me.lblSignature.AutoSize = True
        Me.lblSignature.BackColor = System.Drawing.Color.Transparent
        Me.lblSignature.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSignature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblSignature.Location = New System.Drawing.Point(19, 370)
        Me.lblSignature.Name = "lblSignature"
        Me.lblSignature.Size = New System.Drawing.Size(188, 40)
        Me.lblSignature.TabIndex = 2
        Me.lblSignature.Text = "From, You"
        '
        'lblBody
        '
        Me.lblBody.BackColor = System.Drawing.Color.Transparent
        Me.lblBody.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblBody.Location = New System.Drawing.Point(19, 107)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(377, 213)
        Me.lblBody.TabIndex = 1
        Me.lblBody.Text = "You Are invited to my birthday party! " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "I Hope to see you there!"
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.BackColor = System.Drawing.Color.Transparent
        Me.lblGreeting.Font = New System.Drawing.Font("Showcard Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreeting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblGreeting.Location = New System.Drawing.Point(19, 22)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(228, 40)
        Me.lblGreeting.TabIndex = 0
        Me.lblGreeting.Text = "Dear, Friend"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 554)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(512, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Enter the name of your friends seperated by commas below"
        '
        'txtRawFriends
        '
        Me.txtRawFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtRawFriends.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRawFriends.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRawFriends.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtRawFriends.Location = New System.Drawing.Point(17, 595)
        Me.txtRawFriends.Name = "txtRawFriends"
        Me.txtRawFriends.Size = New System.Drawing.Size(1000, 46)
        Me.txtRawFriends.TabIndex = 1
        '
        'lstFriends
        '
        Me.lstFriends.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.lstFriends.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstFriends.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFriends.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lstFriends.FormattingEnabled = True
        Me.lstFriends.ItemHeight = 25
        Me.lstFriends.Location = New System.Drawing.Point(819, 12)
        Me.lstFriends.Name = "lstFriends"
        Me.lstFriends.Size = New System.Drawing.Size(198, 454)
        Me.lstFriends.TabIndex = 4
        '
        'btnSaveCurrent
        '
        Me.btnSaveCurrent.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSaveCurrent.Enabled = False
        Me.btnSaveCurrent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnSaveCurrent.FlatAppearance.BorderSize = 2
        Me.btnSaveCurrent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCurrent.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveCurrent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnSaveCurrent.Location = New System.Drawing.Point(284, 650)
        Me.btnSaveCurrent.Name = "btnSaveCurrent"
        Me.btnSaveCurrent.Size = New System.Drawing.Size(130, 32)
        Me.btnSaveCurrent.TabIndex = 4
        Me.btnSaveCurrent.Text = "Save Selected "
        Me.btnSaveCurrent.UseVisualStyleBackColor = False
        '
        'btnLoad
        '
        Me.btnLoad.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLoad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnLoad.FlatAppearance.BorderSize = 2
        Me.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoad.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnLoad.Location = New System.Drawing.Point(17, 650)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(149, 32)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "Load From Input"
        Me.btnLoad.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 2
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(172, 650)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 32)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtSenderName
        '
        Me.txtSenderName.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSenderName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenderName.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSenderName.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.txtSenderName.Location = New System.Drawing.Point(17, 499)
        Me.txtSenderName.Name = "txtSenderName"
        Me.txtSenderName.Size = New System.Drawing.Size(1000, 46)
        Me.txtSenderName.TabIndex = 0
        '
        'lblEnterName
        '
        Me.lblEnterName.AutoSize = True
        Me.lblEnterName.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblEnterName.Location = New System.Drawing.Point(12, 459)
        Me.lblEnterName.Name = "lblEnterName"
        Me.lblEnterName.Size = New System.Drawing.Size(210, 25)
        Me.lblEnterName.TabIndex = 8
        Me.lblEnterName.Text = "Enter Your Name Below"
        '
        'lblFriends
        '
        Me.lblFriends.AutoSize = True
        Me.lblFriends.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFriends.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.lblFriends.Location = New System.Drawing.Point(687, 12)
        Me.lblFriends.Name = "lblFriends"
        Me.lblFriends.Size = New System.Drawing.Size(116, 25)
        Me.lblFriends.TabIndex = 10
        Me.lblFriends.Text = "Your Friends"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(887, 650)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(130, 32)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrint.Enabled = False
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnPrint.FlatAppearance.BorderSize = 2
        Me.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrint.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnPrint.Location = New System.Drawing.Point(556, 650)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(130, 32)
        Me.btnPrint.TabIndex = 12
        Me.btnPrint.Text = "Print Selected"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        Me.PrintDocument1.DocumentName = "BirthdayCard"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'btnPrintForm
        '
        Me.btnPrintForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPrintForm.Enabled = False
        Me.btnPrintForm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(1, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnPrintForm.FlatAppearance.BorderSize = 2
        Me.btnPrintForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintForm.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintForm.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(9, Byte), Integer), CType(CType(10, Byte), Integer))
        Me.btnPrintForm.Location = New System.Drawing.Point(692, 650)
        Me.btnPrintForm.Name = "btnPrintForm"
        Me.btnPrintForm.Size = New System.Drawing.Size(189, 32)
        Me.btnPrintForm.TabIndex = 13
        Me.btnPrintForm.Text = "Print Selected PrintForm"
        Me.btnPrintForm.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1029, 694)
        Me.Controls.Add(Me.btnPrintForm)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFriends)
        Me.Controls.Add(Me.txtSenderName)
        Me.Controls.Add(Me.lblEnterName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnSaveCurrent)
        Me.Controls.Add(Me.lstFriends)
        Me.Controls.Add(Me.txtRawFriends)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpCard)
        Me.Controls.Add(Me.btnSaveAll)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Birthday Cards"
        Me.grpCard.ResumeLayout(False)
        Me.grpCard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSaveAll As Button
    Friend WithEvents grpCard As Panel
    Friend WithEvents lblSignature As Label
    Friend WithEvents lblBody As Label
    Friend WithEvents lblGreeting As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRawFriends As TextBox
    Friend WithEvents lstFriends As ListBox
    Friend WithEvents btnSaveCurrent As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtSenderName As TextBox
    Friend WithEvents lblEnterName As Label
    Friend WithEvents lblFriends As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents btnPrintForm As Button
End Class
