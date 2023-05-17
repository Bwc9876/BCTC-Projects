<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileField
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.grpFileSelect = New System.Windows.Forms.GroupBox()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.grpFileSelect.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFileSelect
        '
        Me.grpFileSelect.Controls.Add(Me.txtFilePath)
        Me.grpFileSelect.Controls.Add(Me.btnBrowse)
        Me.grpFileSelect.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFileSelect.Location = New System.Drawing.Point(0, 0)
        Me.grpFileSelect.Name = "grpFileSelect"
        Me.grpFileSelect.Size = New System.Drawing.Size(320, 63)
        Me.grpFileSelect.TabIndex = 4
        Me.grpFileSelect.TabStop = False
        Me.grpFileSelect.Text = "Select File"
        '
        'txtFilePath
        '
        Me.txtFilePath.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtFilePath.Location = New System.Drawing.Point(110, 21)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.ReadOnly = True
        Me.txtFilePath.Size = New System.Drawing.Size(204, 22)
        Me.txtFilePath.TabIndex = 1
        Me.txtFilePath.Text = "No File Selected"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(40, 21)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(64, 20)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "Browse..."
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'FileField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpFileSelect)
        Me.Name = "FileField"
        Me.Size = New System.Drawing.Size(320, 63)
        Me.grpFileSelect.ResumeLayout(False)
        Me.grpFileSelect.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpFileSelect As GroupBox
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnBrowse As Button
End Class
