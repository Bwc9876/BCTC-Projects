<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPizzaSelection
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.btnDeepDish = New System.Windows.Forms.Button()
        Me.btnThinCrust = New System.Windows.Forms.Button()
        Me.btnSelectPizza = New System.Windows.Forms.Button()
        Me.lblDirections = New System.Windows.Forms.Label()
        Me.lblEnjoy = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picThinCrust = New System.Windows.Forms.PictureBox()
        Me.picDeepDish = New System.Windows.Forms.PictureBox()
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.Red
        Me.lblHeading.Location = New System.Drawing.Point(116, 9)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(179, 27)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Pizza Selection"
        '
        'btnDeepDish
        '
        Me.btnDeepDish.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDeepDish.Location = New System.Drawing.Point(33, 214)
        Me.btnDeepDish.Name = "btnDeepDish"
        Me.btnDeepDish.Size = New System.Drawing.Size(98, 29)
        Me.btnDeepDish.TabIndex = 3
        Me.btnDeepDish.Text = "Deep Dish"
        Me.btnDeepDish.UseVisualStyleBackColor = False
        '
        'btnThinCrust
        '
        Me.btnThinCrust.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnThinCrust.Location = New System.Drawing.Point(281, 214)
        Me.btnThinCrust.Name = "btnThinCrust"
        Me.btnThinCrust.Size = New System.Drawing.Size(98, 29)
        Me.btnThinCrust.TabIndex = 4
        Me.btnThinCrust.Text = "Thin Crust"
        Me.btnThinCrust.UseVisualStyleBackColor = False
        '
        'btnSelectPizza
        '
        Me.btnSelectPizza.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSelectPizza.Enabled = False
        Me.btnSelectPizza.Location = New System.Drawing.Point(157, 214)
        Me.btnSelectPizza.Name = "btnSelectPizza"
        Me.btnSelectPizza.Size = New System.Drawing.Size(98, 29)
        Me.btnSelectPizza.TabIndex = 5
        Me.btnSelectPizza.Text = "Select Pizza"
        Me.btnSelectPizza.UseVisualStyleBackColor = False
        '
        'lblDirections
        '
        Me.lblDirections.AutoSize = True
        Me.lblDirections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirections.Location = New System.Drawing.Point(30, 255)
        Me.lblDirections.Name = "lblDirections"
        Me.lblDirections.Size = New System.Drawing.Size(344, 17)
        Me.lblDirections.TabIndex = 6
        Me.lblDirections.Text = "Choose a pizza type and click the Select Pizza button"
        '
        'lblEnjoy
        '
        Me.lblEnjoy.AutoSize = True
        Me.lblEnjoy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnjoy.Location = New System.Drawing.Point(118, 282)
        Me.lblEnjoy.Name = "lblEnjoy"
        Me.lblEnjoy.Size = New System.Drawing.Size(172, 17)
        Me.lblEnjoy.TabIndex = 7
        Me.lblEnjoy.Text = "Enjoy your pizza selection"
        Me.lblEnjoy.Visible = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnExit.Enabled = False
        Me.btnExit.Location = New System.Drawing.Point(157, 315)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(98, 29)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'picThinCrust
        '
        Me.picThinCrust.Image = Global.PizzaSelection.My.Resources.Resources.Thin_Crust
        Me.picThinCrust.Location = New System.Drawing.Point(217, 48)
        Me.picThinCrust.Name = "picThinCrust"
        Me.picThinCrust.Size = New System.Drawing.Size(185, 150)
        Me.picThinCrust.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picThinCrust.TabIndex = 2
        Me.picThinCrust.TabStop = False
        Me.picThinCrust.Visible = False
        '
        'picDeepDish
        '
        Me.picDeepDish.Image = Global.PizzaSelection.My.Resources.Resources.DeepDish
        Me.picDeepDish.Location = New System.Drawing.Point(12, 48)
        Me.picDeepDish.Name = "picDeepDish"
        Me.picDeepDish.Size = New System.Drawing.Size(185, 150)
        Me.picDeepDish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDeepDish.TabIndex = 1
        Me.picDeepDish.TabStop = False
        Me.picDeepDish.Visible = False
        '
        'frmPizzaSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(414, 356)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblEnjoy)
        Me.Controls.Add(Me.lblDirections)
        Me.Controls.Add(Me.btnSelectPizza)
        Me.Controls.Add(Me.btnThinCrust)
        Me.Controls.Add(Me.btnDeepDish)
        Me.Controls.Add(Me.picThinCrust)
        Me.Controls.Add(Me.picDeepDish)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmPizzaSelection"
        Me.Text = "Pizza Selection"
        CType(Me.picThinCrust, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDeepDish, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picDeepDish As PictureBox
    Friend WithEvents picThinCrust As PictureBox
    Friend WithEvents btnDeepDish As Button
    Friend WithEvents btnThinCrust As Button
    Friend WithEvents btnSelectPizza As Button
    Friend WithEvents lblDirections As Label
    Friend WithEvents lblEnjoy As Label
    Friend WithEvents btnExit As Button
End Class
