<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GetDate
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
        Me.btnGetDate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnGetDate
        '
        Me.btnGetDate.BackColor = System.Drawing.SystemColors.Info
        Me.btnGetDate.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDate.ForeColor = System.Drawing.Color.Black
        Me.btnGetDate.Location = New System.Drawing.Point(38, 8)
        Me.btnGetDate.Name = "btnGetDate"
        Me.btnGetDate.Size = New System.Drawing.Size(227, 45)
        Me.btnGetDate.TabIndex = 0
        Me.btnGetDate.Text = "Get Date"
        Me.btnGetDate.UseVisualStyleBackColor = False
        '
        'GetDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(303, 61)
        Me.Controls.Add(Me.btnGetDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "GetDate"
        Me.Text = "Get Date and Time"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGetDate As Button
End Class
