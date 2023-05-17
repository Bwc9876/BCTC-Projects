<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TextField
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.grpField = New System.Windows.Forms.GroupBox()
        Me.lblErrorText = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.grpField.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpField
        '
        Me.grpField.Controls.Add(Me.lblErrorText)
        Me.grpField.Controls.Add(Me.txtInput)
        Me.grpField.Location = New System.Drawing.Point(0, 0)
        Me.grpField.Name = "grpField"
        Me.grpField.Size = New System.Drawing.Size(183, 95)
        Me.grpField.TabIndex = 0
        Me.grpField.TabStop = False
        Me.grpField.Text = "Field Name"
        '
        'lblErrorText
        '
        Me.lblErrorText.BackColor = System.Drawing.SystemColors.Control
        Me.lblErrorText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorText.ForeColor = System.Drawing.Color.Red
        Me.lblErrorText.Location = New System.Drawing.Point(6, 52)
        Me.lblErrorText.Name = "lblErrorText"
        Me.lblErrorText.Size = New System.Drawing.Size(171, 40)
        Me.lblErrorText.TabIndex = 1
        Me.lblErrorText.Text = "Error Text"
        Me.lblErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.White
        Me.txtInput.Location = New System.Drawing.Point(22, 29)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(138, 20)
        Me.txtInput.TabIndex = 0
        '
        'TextField
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.grpField)
        Me.Name = "TextField"
        Me.Size = New System.Drawing.Size(183, 96)
        Me.grpField.ResumeLayout(False)
        Me.grpField.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpField As GroupBox
    Friend WithEvents lblErrorText As Label
    Friend WithEvents txtInput As TextBox
End Class
