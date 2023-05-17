<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreditCards
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
        Me.grpCards = New System.Windows.Forms.GroupBox()
        Me.btnMaster = New System.Windows.Forms.RadioButton()
        Me.btnDiscover = New System.Windows.Forms.RadioButton()
        Me.btnAmerican = New System.Windows.Forms.RadioButton()
        Me.btnVisa = New System.Windows.Forms.RadioButton()
        Me.picAmerican = New System.Windows.Forms.PictureBox()
        Me.picVisa = New System.Windows.Forms.PictureBox()
        Me.picDiscover = New System.Windows.Forms.PictureBox()
        Me.picMaster = New System.Windows.Forms.PictureBox()
        Me.lblCreditLine = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpCards.SuspendLayout()
        CType(Me.picAmerican, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picVisa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDiscover, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCards
        '
        Me.grpCards.Controls.Add(Me.btnAmerican)
        Me.grpCards.Controls.Add(Me.picAmerican)
        Me.grpCards.Controls.Add(Me.btnVisa)
        Me.grpCards.Controls.Add(Me.picVisa)
        Me.grpCards.Controls.Add(Me.btnDiscover)
        Me.grpCards.Controls.Add(Me.picDiscover)
        Me.grpCards.Controls.Add(Me.btnMaster)
        Me.grpCards.Controls.Add(Me.picMaster)
        Me.grpCards.Location = New System.Drawing.Point(16, 12)
        Me.grpCards.Name = "grpCards"
        Me.grpCards.Size = New System.Drawing.Size(919, 349)
        Me.grpCards.TabIndex = 2
        Me.grpCards.TabStop = False
        Me.grpCards.Text = "Select A Card"
        '
        'btnMaster
        '
        Me.btnMaster.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMaster.ForeColor = System.Drawing.Color.Gray
        Me.btnMaster.Location = New System.Drawing.Point(215, 19)
        Me.btnMaster.Name = "btnMaster"
        Me.btnMaster.Size = New System.Drawing.Size(252, 155)
        Me.btnMaster.TabIndex = 2
        Me.btnMaster.Text = "Master Card"
        Me.btnMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnMaster.UseVisualStyleBackColor = True
        '
        'btnDiscover
        '
        Me.btnDiscover.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscover.ForeColor = System.Drawing.Color.Gray
        Me.btnDiscover.Location = New System.Drawing.Point(215, 180)
        Me.btnDiscover.Name = "btnDiscover"
        Me.btnDiscover.Size = New System.Drawing.Size(252, 155)
        Me.btnDiscover.TabIndex = 4
        Me.btnDiscover.Text = "Discover"
        Me.btnDiscover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDiscover.UseVisualStyleBackColor = True
        '
        'btnAmerican
        '
        Me.btnAmerican.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAmerican.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAmerican.ForeColor = System.Drawing.Color.Gray
        Me.btnAmerican.Location = New System.Drawing.Point(473, 180)
        Me.btnAmerican.Name = "btnAmerican"
        Me.btnAmerican.Size = New System.Drawing.Size(231, 155)
        Me.btnAmerican.TabIndex = 8
        Me.btnAmerican.Text = "American Express"
        Me.btnAmerican.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAmerican.UseVisualStyleBackColor = True
        '
        'btnVisa
        '
        Me.btnVisa.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnVisa.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisa.ForeColor = System.Drawing.Color.Gray
        Me.btnVisa.Location = New System.Drawing.Point(473, 19)
        Me.btnVisa.Name = "btnVisa"
        Me.btnVisa.Size = New System.Drawing.Size(231, 155)
        Me.btnVisa.TabIndex = 6
        Me.btnVisa.Text = "Visa"
        Me.btnVisa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnVisa.UseVisualStyleBackColor = True
        '
        'picAmerican
        '
        Me.picAmerican.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAmerican.Image = Global.CreditCards.My.Resources.Resources.american
        Me.picAmerican.Location = New System.Drawing.Point(710, 180)
        Me.picAmerican.Name = "picAmerican"
        Me.picAmerican.Size = New System.Drawing.Size(203, 155)
        Me.picAmerican.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAmerican.TabIndex = 7
        Me.picAmerican.TabStop = False
        Me.picAmerican.Visible = False
        '
        'picVisa
        '
        Me.picVisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picVisa.Image = Global.CreditCards.My.Resources.Resources.Visa
        Me.picVisa.Location = New System.Drawing.Point(710, 19)
        Me.picVisa.Name = "picVisa"
        Me.picVisa.Size = New System.Drawing.Size(203, 155)
        Me.picVisa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picVisa.TabIndex = 5
        Me.picVisa.TabStop = False
        Me.picVisa.Visible = False
        '
        'picDiscover
        '
        Me.picDiscover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picDiscover.Image = Global.CreditCards.My.Resources.Resources.discover
        Me.picDiscover.Location = New System.Drawing.Point(6, 180)
        Me.picDiscover.Name = "picDiscover"
        Me.picDiscover.Size = New System.Drawing.Size(203, 155)
        Me.picDiscover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDiscover.TabIndex = 3
        Me.picDiscover.TabStop = False
        Me.picDiscover.Visible = False
        '
        'picMaster
        '
        Me.picMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picMaster.Image = Global.CreditCards.My.Resources.Resources.Master
        Me.picMaster.Location = New System.Drawing.Point(6, 19)
        Me.picMaster.Name = "picMaster"
        Me.picMaster.Size = New System.Drawing.Size(203, 155)
        Me.picMaster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMaster.TabIndex = 1
        Me.picMaster.TabStop = False
        Me.picMaster.Visible = False
        '
        'lblCreditLine
        '
        Me.lblCreditLine.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreditLine.Location = New System.Drawing.Point(17, 364)
        Me.lblCreditLine.Name = "lblCreditLine"
        Me.lblCreditLine.Size = New System.Drawing.Size(918, 79)
        Me.lblCreditLine.TabIndex = 3
        Me.lblCreditLine.Text = "Credit Line Will Appear Here"
        Me.lblCreditLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.OldLace
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(811, 367)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(124, 76)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'CreditCards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(947, 452)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCreditLine)
        Me.Controls.Add(Me.grpCards)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "CreditCards"
        Me.Text = "Credit Card Selection"
        Me.grpCards.ResumeLayout(False)
        CType(Me.picAmerican, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picVisa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDiscover, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMaster, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents picMaster As PictureBox
    Friend WithEvents grpCards As GroupBox
    Friend WithEvents btnMaster As RadioButton
    Friend WithEvents btnDiscover As RadioButton
    Friend WithEvents picDiscover As PictureBox
    Friend WithEvents btnAmerican As RadioButton
    Friend WithEvents picAmerican As PictureBox
    Friend WithEvents btnVisa As RadioButton
    Friend WithEvents picVisa As PictureBox
    Friend WithEvents lblCreditLine As Label
    Friend WithEvents btnExit As Button
End Class
