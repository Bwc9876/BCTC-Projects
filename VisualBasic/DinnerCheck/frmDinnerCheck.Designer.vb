<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDinnerCheck
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
        Me.txtDinner1 = New System.Windows.Forms.TextBox()
        Me.txtDinner2 = New System.Windows.Forms.TextBox()
        Me.txtDinner3 = New System.Windows.Forms.TextBox()
        Me.txtPercentTip = New System.Windows.Forms.TextBox()
        Me.lblDinner1 = New System.Windows.Forms.Label()
        Me.lblDinner2 = New System.Windows.Forms.Label()
        Me.lblDinner3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblPercentTip = New System.Windows.Forms.Label()
        Me.lblPercent = New System.Windows.Forms.Label()
        Me.lblDollar1 = New System.Windows.Forms.Label()
        Me.lblDollar2 = New System.Windows.Forms.Label()
        Me.lblDollar3 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblTotalTip = New System.Windows.Forms.Label()
        Me.lblTotalTipLabel = New System.Windows.Forms.Label()
        Me.lblTotalBillLabel = New System.Windows.Forms.Label()
        Me.lblTotalBill = New System.Windows.Forms.Label()
        Me.lblCostPerPersonLabel = New System.Windows.Forms.Label()
        Me.lblCostPerPerson = New System.Windows.Forms.Label()
        Me.lblDinnerSumLabel = New System.Windows.Forms.Label()
        Me.lblDinnerSum = New System.Windows.Forms.Label()
        Me.grpValues = New System.Windows.Forms.GroupBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpResults = New System.Windows.Forms.GroupBox()
        Me.grpValues.SuspendLayout()
        Me.grpResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDinner1
        '
        Me.txtDinner1.BackColor = System.Drawing.Color.Honeydew
        Me.txtDinner1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDinner1.Location = New System.Drawing.Point(25, 64)
        Me.txtDinner1.Name = "txtDinner1"
        Me.txtDinner1.Size = New System.Drawing.Size(161, 22)
        Me.txtDinner1.TabIndex = 0
        '
        'txtDinner2
        '
        Me.txtDinner2.BackColor = System.Drawing.Color.Honeydew
        Me.txtDinner2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDinner2.Location = New System.Drawing.Point(25, 123)
        Me.txtDinner2.Name = "txtDinner2"
        Me.txtDinner2.Size = New System.Drawing.Size(161, 22)
        Me.txtDinner2.TabIndex = 1
        '
        'txtDinner3
        '
        Me.txtDinner3.BackColor = System.Drawing.Color.Honeydew
        Me.txtDinner3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDinner3.Location = New System.Drawing.Point(25, 182)
        Me.txtDinner3.Name = "txtDinner3"
        Me.txtDinner3.Size = New System.Drawing.Size(161, 22)
        Me.txtDinner3.TabIndex = 2
        '
        'txtPercentTip
        '
        Me.txtPercentTip.BackColor = System.Drawing.Color.Honeydew
        Me.txtPercentTip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPercentTip.Location = New System.Drawing.Point(46, 242)
        Me.txtPercentTip.Name = "txtPercentTip"
        Me.txtPercentTip.Size = New System.Drawing.Size(118, 22)
        Me.txtPercentTip.TabIndex = 3
        '
        'lblDinner1
        '
        Me.lblDinner1.AutoSize = True
        Me.lblDinner1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinner1.Location = New System.Drawing.Point(63, 38)
        Me.lblDinner1.Name = "lblDinner1"
        Me.lblDinner1.Size = New System.Drawing.Size(77, 13)
        Me.lblDinner1.TabIndex = 4
        Me.lblDinner1.Text = "Dinner 1 Cost"
        '
        'lblDinner2
        '
        Me.lblDinner2.AutoSize = True
        Me.lblDinner2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinner2.Location = New System.Drawing.Point(64, 97)
        Me.lblDinner2.Name = "lblDinner2"
        Me.lblDinner2.Size = New System.Drawing.Size(77, 13)
        Me.lblDinner2.TabIndex = 5
        Me.lblDinner2.Text = "Dinner 2 Cost"
        '
        'lblDinner3
        '
        Me.lblDinner3.AutoSize = True
        Me.lblDinner3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinner3.Location = New System.Drawing.Point(63, 156)
        Me.lblDinner3.Name = "lblDinner3"
        Me.lblDinner3.Size = New System.Drawing.Size(77, 13)
        Me.lblDinner3.TabIndex = 6
        Me.lblDinner3.Text = "Dinner 3 Cost"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.SystemColors.Control
        Me.btnCalculate.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen
        Me.btnCalculate.FlatAppearance.BorderSize = 2
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalculate.Font = New System.Drawing.Font("Segoe UI Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnCalculate.Location = New System.Drawing.Point(25, 278)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(161, 35)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblPercentTip
        '
        Me.lblPercentTip.AutoSize = True
        Me.lblPercentTip.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercentTip.Location = New System.Drawing.Point(65, 216)
        Me.lblPercentTip.Name = "lblPercentTip"
        Me.lblPercentTip.Size = New System.Drawing.Size(65, 13)
        Me.lblPercentTip.TabIndex = 9
        Me.lblPercentTip.Text = "Percent Tip"
        '
        'lblPercent
        '
        Me.lblPercent.AutoSize = True
        Me.lblPercent.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPercent.Location = New System.Drawing.Point(21, 242)
        Me.lblPercent.Name = "lblPercent"
        Me.lblPercent.Size = New System.Drawing.Size(23, 21)
        Me.lblPercent.TabIndex = 10
        Me.lblPercent.Text = "%"
        '
        'lblDollar1
        '
        Me.lblDollar1.AutoSize = True
        Me.lblDollar1.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollar1.Location = New System.Drawing.Point(5, 64)
        Me.lblDollar1.Name = "lblDollar1"
        Me.lblDollar1.Size = New System.Drawing.Size(18, 21)
        Me.lblDollar1.TabIndex = 11
        Me.lblDollar1.Text = "$"
        '
        'lblDollar2
        '
        Me.lblDollar2.AutoSize = True
        Me.lblDollar2.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollar2.Location = New System.Drawing.Point(5, 123)
        Me.lblDollar2.Name = "lblDollar2"
        Me.lblDollar2.Size = New System.Drawing.Size(18, 21)
        Me.lblDollar2.TabIndex = 12
        Me.lblDollar2.Text = "$"
        '
        'lblDollar3
        '
        Me.lblDollar3.AutoSize = True
        Me.lblDollar3.Font = New System.Drawing.Font("Segoe UI Semilight", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDollar3.Location = New System.Drawing.Point(5, 182)
        Me.lblDollar3.Name = "lblDollar3"
        Me.lblDollar3.Size = New System.Drawing.Size(18, 21)
        Me.lblDollar3.TabIndex = 13
        Me.lblDollar3.Text = "$"
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Font = New System.Drawing.Font("Segoe UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Brown
        Me.lblError.Location = New System.Drawing.Point(8, 15)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(87, 25)
        Me.lblError.TabIndex = 0
        Me.lblError.Text = "Error Text"
        Me.lblError.Visible = False
        '
        'lblTotalTip
        '
        Me.lblTotalTip.AutoSize = True
        Me.lblTotalTip.BackColor = System.Drawing.Color.PaleGreen
        Me.lblTotalTip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalTip.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTip.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTip.Location = New System.Drawing.Point(99, 116)
        Me.lblTotalTip.Name = "lblTotalTip"
        Me.lblTotalTip.Size = New System.Drawing.Size(83, 27)
        Me.lblTotalTip.TabIndex = 14
        Me.lblTotalTip.Text = "Total Tip"
        Me.lblTotalTip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotalTip.Visible = False
        '
        'lblTotalTipLabel
        '
        Me.lblTotalTipLabel.AutoSize = True
        Me.lblTotalTipLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTipLabel.ForeColor = System.Drawing.Color.Black
        Me.lblTotalTipLabel.Location = New System.Drawing.Point(6, 114)
        Me.lblTotalTipLabel.Name = "lblTotalTipLabel"
        Me.lblTotalTipLabel.Size = New System.Drawing.Size(87, 25)
        Me.lblTotalTipLabel.TabIndex = 15
        Me.lblTotalTipLabel.Text = "Total Tip:"
        Me.lblTotalTipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalBillLabel
        '
        Me.lblTotalBillLabel.AutoSize = True
        Me.lblTotalBillLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBillLabel.ForeColor = System.Drawing.Color.Black
        Me.lblTotalBillLabel.Location = New System.Drawing.Point(6, 195)
        Me.lblTotalBillLabel.Name = "lblTotalBillLabel"
        Me.lblTotalBillLabel.Size = New System.Drawing.Size(87, 25)
        Me.lblTotalBillLabel.TabIndex = 17
        Me.lblTotalBillLabel.Text = "Total Bill:"
        Me.lblTotalBillLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalBill
        '
        Me.lblTotalBill.AutoSize = True
        Me.lblTotalBill.BackColor = System.Drawing.Color.PaleGreen
        Me.lblTotalBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalBill.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBill.ForeColor = System.Drawing.Color.Black
        Me.lblTotalBill.Location = New System.Drawing.Point(99, 195)
        Me.lblTotalBill.Name = "lblTotalBill"
        Me.lblTotalBill.Size = New System.Drawing.Size(81, 27)
        Me.lblTotalBill.TabIndex = 16
        Me.lblTotalBill.Text = "Total Bill"
        Me.lblTotalBill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotalBill.Visible = False
        '
        'lblCostPerPersonLabel
        '
        Me.lblCostPerPersonLabel.AutoSize = True
        Me.lblCostPerPersonLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerPersonLabel.ForeColor = System.Drawing.Color.Black
        Me.lblCostPerPersonLabel.Location = New System.Drawing.Point(6, 276)
        Me.lblCostPerPersonLabel.Name = "lblCostPerPersonLabel"
        Me.lblCostPerPersonLabel.Size = New System.Drawing.Size(160, 25)
        Me.lblCostPerPersonLabel.TabIndex = 19
        Me.lblCostPerPersonLabel.Text = "Each Person Pays:"
        Me.lblCostPerPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCostPerPerson
        '
        Me.lblCostPerPerson.AutoSize = True
        Me.lblCostPerPerson.BackColor = System.Drawing.Color.PaleGreen
        Me.lblCostPerPerson.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCostPerPerson.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostPerPerson.ForeColor = System.Drawing.Color.Black
        Me.lblCostPerPerson.Location = New System.Drawing.Point(172, 276)
        Me.lblCostPerPerson.Name = "lblCostPerPerson"
        Me.lblCostPerPerson.Size = New System.Drawing.Size(140, 27)
        Me.lblCostPerPerson.TabIndex = 18
        Me.lblCostPerPerson.Text = "Cost Per Person"
        Me.lblCostPerPerson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCostPerPerson.Visible = False
        '
        'lblDinnerSumLabel
        '
        Me.lblDinnerSumLabel.AutoSize = True
        Me.lblDinnerSumLabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinnerSumLabel.ForeColor = System.Drawing.Color.Black
        Me.lblDinnerSumLabel.Location = New System.Drawing.Point(6, 33)
        Me.lblDinnerSumLabel.Name = "lblDinnerSumLabel"
        Me.lblDinnerSumLabel.Size = New System.Drawing.Size(148, 25)
        Me.lblDinnerSumLabel.TabIndex = 21
        Me.lblDinnerSumLabel.Text = "Sum Of Dinners:"
        Me.lblDinnerSumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDinnerSum
        '
        Me.lblDinnerSum.AutoSize = True
        Me.lblDinnerSum.BackColor = System.Drawing.Color.PaleGreen
        Me.lblDinnerSum.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDinnerSum.Font = New System.Drawing.Font("Segoe UI Semilight", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDinnerSum.ForeColor = System.Drawing.Color.Black
        Me.lblDinnerSum.Location = New System.Drawing.Point(160, 33)
        Me.lblDinnerSum.Name = "lblDinnerSum"
        Me.lblDinnerSum.Size = New System.Drawing.Size(108, 27)
        Me.lblDinnerSum.TabIndex = 20
        Me.lblDinnerSum.Text = "Dinner Sum"
        Me.lblDinnerSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDinnerSum.Visible = False
        '
        'grpValues
        '
        Me.grpValues.Controls.Add(Me.btnExit)
        Me.grpValues.Controls.Add(Me.lblDollar3)
        Me.grpValues.Controls.Add(Me.lblDollar2)
        Me.grpValues.Controls.Add(Me.lblDollar1)
        Me.grpValues.Controls.Add(Me.lblPercent)
        Me.grpValues.Controls.Add(Me.lblPercentTip)
        Me.grpValues.Controls.Add(Me.btnCalculate)
        Me.grpValues.Controls.Add(Me.lblDinner3)
        Me.grpValues.Controls.Add(Me.lblDinner2)
        Me.grpValues.Controls.Add(Me.lblDinner1)
        Me.grpValues.Controls.Add(Me.txtPercentTip)
        Me.grpValues.Controls.Add(Me.txtDinner3)
        Me.grpValues.Controls.Add(Me.txtDinner2)
        Me.grpValues.Controls.Add(Me.txtDinner1)
        Me.grpValues.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpValues.Location = New System.Drawing.Point(367, 15)
        Me.grpValues.Name = "grpValues"
        Me.grpValues.Size = New System.Drawing.Size(211, 352)
        Me.grpValues.TabIndex = 22
        Me.grpValues.TabStop = False
        Me.grpValues.Text = "Enter Values"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.Location = New System.Drawing.Point(46, 318)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(118, 28)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'grpResults
        '
        Me.grpResults.Controls.Add(Me.lblDinnerSum)
        Me.grpResults.Controls.Add(Me.lblTotalBill)
        Me.grpResults.Controls.Add(Me.lblTotalTip)
        Me.grpResults.Controls.Add(Me.lblCostPerPerson)
        Me.grpResults.Controls.Add(Me.lblDinnerSumLabel)
        Me.grpResults.Controls.Add(Me.lblTotalTipLabel)
        Me.grpResults.Controls.Add(Me.lblCostPerPersonLabel)
        Me.grpResults.Controls.Add(Me.lblTotalBillLabel)
        Me.grpResults.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpResults.Location = New System.Drawing.Point(12, 46)
        Me.grpResults.Name = "grpResults"
        Me.grpResults.Size = New System.Drawing.Size(350, 321)
        Me.grpResults.TabIndex = 23
        Me.grpResults.TabStop = False
        Me.grpResults.Text = "Results"
        '
        'frmDinnerCheck
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 374)
        Me.Controls.Add(Me.grpResults)
        Me.Controls.Add(Me.grpValues)
        Me.Controls.Add(Me.lblError)
        Me.Name = "frmDinnerCheck"
        Me.Text = "Dinner Check"
        Me.grpValues.ResumeLayout(False)
        Me.grpValues.PerformLayout()
        Me.grpResults.ResumeLayout(False)
        Me.grpResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDinner1 As TextBox
    Friend WithEvents txtDinner2 As TextBox
    Friend WithEvents txtDinner3 As TextBox
    Friend WithEvents txtPercentTip As TextBox
    Friend WithEvents lblDinner1 As Label
    Friend WithEvents lblDinner2 As Label
    Friend WithEvents lblDinner3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblPercentTip As Label
    Friend WithEvents lblPercent As Label
    Friend WithEvents lblDollar1 As Label
    Friend WithEvents lblDollar2 As Label
    Friend WithEvents lblDollar3 As Label
    Friend WithEvents lblError As Label
    Friend WithEvents lblCostPerPersonLabel As Label
    Friend WithEvents lblCostPerPerson As Label
    Friend WithEvents lblTotalBillLabel As Label
    Friend WithEvents lblTotalBill As Label
    Friend WithEvents lblTotalTipLabel As Label
    Friend WithEvents lblTotalTip As Label
    Friend WithEvents lblDinnerSum As Label
    Friend WithEvents lblDinnerSumLabel As Label
    Friend WithEvents grpValues As GroupBox
    Friend WithEvents grpResults As GroupBox
    Friend WithEvents btnExit As Button
End Class
