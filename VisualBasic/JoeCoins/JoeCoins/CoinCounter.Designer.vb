<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CoinCounter
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
        Me.btnCountCoins = New System.Windows.Forms.Button()
        Me.txtPennies = New System.Windows.Forms.TextBox()
        Me.lblCoinCount = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCountCoins
        '
        Me.btnCountCoins.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnCountCoins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCountCoins.FlatAppearance.BorderSize = 3
        Me.btnCountCoins.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCountCoins.Location = New System.Drawing.Point(12, 73)
        Me.btnCountCoins.Name = "btnCountCoins"
        Me.btnCountCoins.Size = New System.Drawing.Size(152, 23)
        Me.btnCountCoins.TabIndex = 0
        Me.btnCountCoins.Text = "Count Coins"
        Me.btnCountCoins.UseVisualStyleBackColor = False
        '
        'txtPennies
        '
        Me.txtPennies.BackColor = System.Drawing.Color.SlateBlue
        Me.txtPennies.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtPennies.Location = New System.Drawing.Point(12, 45)
        Me.txtPennies.Name = "txtPennies"
        Me.txtPennies.Size = New System.Drawing.Size(152, 22)
        Me.txtPennies.TabIndex = 1
        '
        'lblCoinCount
        '
        Me.lblCoinCount.BackColor = System.Drawing.Color.LightCoral
        Me.lblCoinCount.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCoinCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCoinCount.Location = New System.Drawing.Point(172, 9)
        Me.lblCoinCount.Name = "lblCoinCount"
        Me.lblCoinCount.Size = New System.Drawing.Size(163, 145)
        Me.lblCoinCount.TabIndex = 2
        Me.lblCoinCount.Text = "Coins Will Appear Here"
        Me.lblCoinCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClear.FlatAppearance.BorderSize = 3
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(12, 102)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(152, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.MediumAquamarine
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 3
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(12, 131)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(20, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Enter # Of Pennies"
        '
        'CoinCounter
        '
        Me.AcceptButton = Me.btnCountCoins
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(352, 166)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblCoinCount)
        Me.Controls.Add(Me.txtPennies)
        Me.Controls.Add(Me.btnCountCoins)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CoinCounter"
        Me.ShowIcon = False
        Me.Text = "Coin Counter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCountCoins As Button
    Friend WithEvents txtPennies As TextBox
    Friend WithEvents lblCoinCount As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
End Class
