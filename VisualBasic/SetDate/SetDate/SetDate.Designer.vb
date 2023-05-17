<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetDate
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
        Me.dtpTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnSetDate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtpTimePicker
        '
        Me.dtpTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder
        Me.dtpTimePicker.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTimePicker.Location = New System.Drawing.Point(37, 21)
        Me.dtpTimePicker.Name = "dtpTimePicker"
        Me.dtpTimePicker.Size = New System.Drawing.Size(210, 22)
        Me.dtpTimePicker.TabIndex = 0
        '
        'btnSetDate
        '
        Me.btnSetDate.BackColor = System.Drawing.SystemColors.Info
        Me.btnSetDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetDate.ForeColor = System.Drawing.Color.Black
        Me.btnSetDate.Location = New System.Drawing.Point(37, 47)
        Me.btnSetDate.Name = "btnSetDate"
        Me.btnSetDate.Size = New System.Drawing.Size(210, 32)
        Me.btnSetDate.TabIndex = 1
        Me.btnSetDate.Text = "Set Date"
        Me.btnSetDate.UseVisualStyleBackColor = False
        '
        'SetDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(284, 91)
        Me.Controls.Add(Me.btnSetDate)
        Me.Controls.Add(Me.dtpTimePicker)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "SetDate"
        Me.Text = "Set Date & Time"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtpTimePicker As DateTimePicker
    Friend WithEvents btnSetDate As Button
End Class
