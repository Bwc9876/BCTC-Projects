<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestProject
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
        Me.txtTest = New Fields.TextField()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTest
        '
        Me.txtTest.Location = New System.Drawing.Point(12, 12)
        Me.txtTest.Name = "txtTest"
        Me.txtTest.Size = New System.Drawing.Size(183, 96)
        Me.txtTest.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(54, 182)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 1
        Me.btnSubmit.Text = "Button1"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'TestProject
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 450)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtTest)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "TestProject"
        Me.ShowIcon = False
        Me.Text = "TestProject"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txtTest As Fields.TextField
    Friend WithEvents btnSubmit As Button
End Class
