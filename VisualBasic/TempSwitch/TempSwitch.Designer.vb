<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TempSwitch
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
        Me.grpResult = New System.Windows.Forms.GroupBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.picImage = New System.Windows.Forms.PictureBox()
        Me.grpInputs = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.grpResult.SuspendLayout()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpInputs.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpResult
        '
        Me.grpResult.Controls.Add(Me.lblMessage)
        Me.grpResult.Controls.Add(Me.picImage)
        Me.grpResult.Location = New System.Drawing.Point(226, 12)
        Me.grpResult.Name = "grpResult"
        Me.grpResult.Size = New System.Drawing.Size(562, 426)
        Me.grpResult.TabIndex = 0
        Me.grpResult.TabStop = False
        Me.grpResult.Text = "Result"
        '
        'lblMessage
        '
        Me.lblMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(6, 361)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(550, 62)
        Me.lblMessage.TabIndex = 1
        Me.lblMessage.Text = "Message"
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picImage
        '
        Me.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picImage.Location = New System.Drawing.Point(6, 19)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(550, 339)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picImage.TabIndex = 0
        Me.picImage.TabStop = False
        '
        'grpInputs
        '
        Me.grpInputs.Controls.Add(Me.Label1)
        Me.grpInputs.Controls.Add(Me.btnExit)
        Me.grpInputs.Controls.Add(Me.lblInstructions)
        Me.grpInputs.Controls.Add(Me.btnEnter)
        Me.grpInputs.Controls.Add(Me.txtTemp)
        Me.grpInputs.Location = New System.Drawing.Point(12, 12)
        Me.grpInputs.Name = "grpInputs"
        Me.grpInputs.Size = New System.Drawing.Size(208, 426)
        Me.grpInputs.TabIndex = 1
        Me.grpInputs.TabStop = False
        Me.grpInputs.Text = "Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(184, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "°C"
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(6, 389)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(196, 22)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(30, 175)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(153, 13)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Enter The Degrees In Celcius"
        '
        'btnEnter
        '
        Me.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnter.Location = New System.Drawing.Point(6, 361)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(196, 22)
        Me.btnEnter.TabIndex = 1
        Me.btnEnter.Text = "Submit"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'txtTemp
        '
        Me.txtTemp.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.Location = New System.Drawing.Point(6, 207)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(177, 25)
        Me.txtTemp.TabIndex = 0
        '
        'TempSwitch
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grpInputs)
        Me.Controls.Add(Me.grpResult)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TempSwitch"
        Me.ShowIcon = False
        Me.Text = "Temperature Converter"
        Me.grpResult.ResumeLayout(False)
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpInputs.ResumeLayout(False)
        Me.grpInputs.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpResult As GroupBox
    Friend WithEvents lblMessage As Label
    Friend WithEvents picImage As PictureBox
    Friend WithEvents grpInputs As GroupBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
End Class
