<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPayRoll
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
        Me.grpInfo = New System.Windows.Forms.GroupBox()
        Me.lblHourRange = New System.Windows.Forms.Label()
        Me.lblPayRange = New System.Windows.Forms.Label()
        Me.lblFamilyRate = New System.Windows.Forms.Label()
        Me.lblSingleRate = New System.Windows.Forms.Label()
        Me.grpRates = New System.Windows.Forms.GroupBox()
        Me.btnFamily = New System.Windows.Forms.RadioButton()
        Me.btnSingle = New System.Windows.Forms.RadioButton()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.inpHourPay = New PayRoll.InputField()
        Me.inpHours = New PayRoll.InputField()
        Me.inpName = New PayRoll.InputField()
        Me.grpInfo.SuspendLayout()
        Me.grpRates.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInfo
        '
        Me.grpInfo.BackColor = System.Drawing.Color.MistyRose
        Me.grpInfo.Controls.Add(Me.lblHourRange)
        Me.grpInfo.Controls.Add(Me.lblPayRange)
        Me.grpInfo.Controls.Add(Me.lblFamilyRate)
        Me.grpInfo.Controls.Add(Me.lblSingleRate)
        Me.grpInfo.Location = New System.Drawing.Point(12, 12)
        Me.grpInfo.Name = "grpInfo"
        Me.grpInfo.Size = New System.Drawing.Size(462, 104)
        Me.grpInfo.TabIndex = 1
        Me.grpInfo.TabStop = False
        Me.grpInfo.Text = "Info"
        '
        'lblHourRange
        '
        Me.lblHourRange.AutoSize = True
        Me.lblHourRange.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourRange.Location = New System.Drawing.Point(206, 30)
        Me.lblHourRange.Name = "lblHourRange"
        Me.lblHourRange.Size = New System.Drawing.Size(102, 20)
        Me.lblHourRange.TabIndex = 3
        Me.lblHourRange.Text = "HOUR RANGE"
        '
        'lblPayRange
        '
        Me.lblPayRange.AutoSize = True
        Me.lblPayRange.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayRange.Location = New System.Drawing.Point(206, 65)
        Me.lblPayRange.Name = "lblPayRange"
        Me.lblPayRange.Size = New System.Drawing.Size(85, 20)
        Me.lblPayRange.TabIndex = 2
        Me.lblPayRange.Text = "PAY RANGE"
        '
        'lblFamilyRate
        '
        Me.lblFamilyRate.AutoSize = True
        Me.lblFamilyRate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFamilyRate.Location = New System.Drawing.Point(6, 65)
        Me.lblFamilyRate.Name = "lblFamilyRate"
        Me.lblFamilyRate.Size = New System.Drawing.Size(124, 20)
        Me.lblFamilyRate.TabIndex = 1
        Me.lblFamilyRate.Text = "FAMILY TAX RATE"
        '
        'lblSingleRate
        '
        Me.lblSingleRate.AutoSize = True
        Me.lblSingleRate.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSingleRate.Location = New System.Drawing.Point(6, 30)
        Me.lblSingleRate.Name = "lblSingleRate"
        Me.lblSingleRate.Size = New System.Drawing.Size(125, 20)
        Me.lblSingleRate.TabIndex = 0
        Me.lblSingleRate.Text = "SINGLE TAX RATE"
        '
        'grpRates
        '
        Me.grpRates.BackColor = System.Drawing.Color.MistyRose
        Me.grpRates.Controls.Add(Me.btnFamily)
        Me.grpRates.Controls.Add(Me.btnSingle)
        Me.grpRates.Location = New System.Drawing.Point(12, 218)
        Me.grpRates.Name = "grpRates"
        Me.grpRates.Size = New System.Drawing.Size(462, 99)
        Me.grpRates.TabIndex = 5
        Me.grpRates.TabStop = False
        Me.grpRates.Text = "Select Tax Rate Type"
        '
        'btnFamily
        '
        Me.btnFamily.AutoSize = True
        Me.btnFamily.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFamily.Location = New System.Drawing.Point(312, 44)
        Me.btnFamily.Name = "btnFamily"
        Me.btnFamily.Size = New System.Drawing.Size(83, 29)
        Me.btnFamily.TabIndex = 1
        Me.btnFamily.Text = "Family"
        Me.btnFamily.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnFamily.UseVisualStyleBackColor = True
        '
        'btnSingle
        '
        Me.btnSingle.AutoSize = True
        Me.btnSingle.Checked = True
        Me.btnSingle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSingle.Location = New System.Drawing.Point(68, 44)
        Me.btnSingle.Name = "btnSingle"
        Me.btnSingle.Size = New System.Drawing.Size(82, 29)
        Me.btnSingle.TabIndex = 0
        Me.btnSingle.TabStop = True
        Me.btnSingle.Text = "Single"
        Me.btnSingle.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSalmon
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.btnCalculate.FlatAppearance.BorderSize = 4
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Location = New System.Drawing.Point(81, 484)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(330, 41)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.MistyRose
        Me.lblOutput.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(12, 320)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(462, 161)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "Payment Info Will Appear Here"
        Me.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightSalmon
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.btnExit.FlatAppearance.BorderSize = 4
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(417, 484)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(59, 41)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.LightSalmon
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose
        Me.btnClear.FlatAppearance.BorderSize = 4
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Location = New System.Drawing.Point(12, 484)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(63, 41)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'inpHourPay
        '
        Me.inpHourPay.BackColor = System.Drawing.Color.MistyRose
        Me.inpHourPay.Location = New System.Drawing.Point(324, 122)
        Me.inpHourPay.Name = "inpHourPay"
        Me.inpHourPay.Size = New System.Drawing.Size(150, 90)
        Me.inpHourPay.TabIndex = 15
        Me.inpHourPay.TabStop = False
        Me.inpHourPay.Text = "Pay Per Hour"
        '
        'inpHours
        '
        Me.inpHours.BackColor = System.Drawing.Color.MistyRose
        Me.inpHours.Location = New System.Drawing.Point(168, 122)
        Me.inpHours.Name = "inpHours"
        Me.inpHours.Size = New System.Drawing.Size(150, 90)
        Me.inpHours.TabIndex = 14
        Me.inpHours.TabStop = False
        Me.inpHours.Text = "Hours Worked"
        '
        'inpName
        '
        Me.inpName.BackColor = System.Drawing.Color.MistyRose
        Me.inpName.Location = New System.Drawing.Point(12, 122)
        Me.inpName.Name = "inpName"
        Me.inpName.Size = New System.Drawing.Size(150, 90)
        Me.inpName.TabIndex = 13
        Me.inpName.TabStop = False
        Me.inpName.Text = "Employee Name"
        '
        'frmPayRoll
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(484, 539)
        Me.Controls.Add(Me.inpHourPay)
        Me.Controls.Add(Me.inpHours)
        Me.Controls.Add(Me.inpName)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpRates)
        Me.Controls.Add(Me.grpInfo)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPayRoll"
        Me.ShowIcon = False
        Me.Text = "Pay Roll Calculator"
        Me.grpInfo.ResumeLayout(False)
        Me.grpInfo.PerformLayout()
        Me.grpRates.ResumeLayout(False)
        Me.grpRates.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpInfo As GroupBox
    Friend WithEvents grpRates As GroupBox
    Friend WithEvents btnFamily As RadioButton
    Friend WithEvents btnSingle As RadioButton
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblHourRange As Label
    Friend WithEvents lblPayRange As Label
    Friend WithEvents lblFamilyRate As Label
    Friend WithEvents lblSingleRate As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents inpHourPay As InputField
    Friend WithEvents inpHours As InputField
    Friend WithEvents inpName As InputField
End Class
