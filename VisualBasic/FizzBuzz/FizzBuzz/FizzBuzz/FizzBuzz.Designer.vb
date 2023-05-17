<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FizzBuzz
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
        Me.lstMultipliers = New System.Windows.Forms.ListBox()
        Me.lstWords = New System.Windows.Forms.ListBox()
        Me.lblMultipliers = New System.Windows.Forms.Label()
        Me.lblWords = New System.Windows.Forms.Label()
        Me.btnMultAdd = New System.Windows.Forms.Button()
        Me.btnMultDelete = New System.Windows.Forms.Button()
        Me.btnMultShiftUp = New System.Windows.Forms.Button()
        Me.btnMultShiftDown = New System.Windows.Forms.Button()
        Me.btnWrdShiftDown = New System.Windows.Forms.Button()
        Me.btnWrdShiftUp = New System.Windows.Forms.Button()
        Me.btnWrdDelete = New System.Windows.Forms.Button()
        Me.btnWrdAdd = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.btnMultEdit = New System.Windows.Forms.Button()
        Me.btnWrdEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstMultipliers
        '
        Me.lstMultipliers.BackColor = System.Drawing.Color.Azure
        Me.lstMultipliers.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMultipliers.FormattingEnabled = True
        Me.lstMultipliers.ItemHeight = 17
        Me.lstMultipliers.Location = New System.Drawing.Point(12, 26)
        Me.lstMultipliers.Name = "lstMultipliers"
        Me.lstMultipliers.Size = New System.Drawing.Size(120, 140)
        Me.lstMultipliers.TabIndex = 0
        '
        'lstWords
        '
        Me.lstWords.BackColor = System.Drawing.Color.Azure
        Me.lstWords.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstWords.FormattingEnabled = True
        Me.lstWords.ItemHeight = 17
        Me.lstWords.Location = New System.Drawing.Point(158, 26)
        Me.lstWords.Name = "lstWords"
        Me.lstWords.Size = New System.Drawing.Size(120, 140)
        Me.lstWords.TabIndex = 1
        '
        'lblMultipliers
        '
        Me.lblMultipliers.Location = New System.Drawing.Point(11, 6)
        Me.lblMultipliers.Name = "lblMultipliers"
        Me.lblMultipliers.Size = New System.Drawing.Size(121, 17)
        Me.lblMultipliers.TabIndex = 2
        Me.lblMultipliers.Text = "Multipliers"
        Me.lblMultipliers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWords
        '
        Me.lblWords.Location = New System.Drawing.Point(155, 6)
        Me.lblWords.Name = "lblWords"
        Me.lblWords.Size = New System.Drawing.Size(121, 17)
        Me.lblWords.TabIndex = 3
        Me.lblWords.Text = "Words"
        Me.lblWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMultAdd
        '
        Me.btnMultAdd.BackColor = System.Drawing.Color.LightCyan
        Me.btnMultAdd.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnMultAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultAdd.Location = New System.Drawing.Point(11, 208)
        Me.btnMultAdd.Name = "btnMultAdd"
        Me.btnMultAdd.Size = New System.Drawing.Size(120, 28)
        Me.btnMultAdd.TabIndex = 4
        Me.btnMultAdd.Text = "Add"
        Me.btnMultAdd.UseVisualStyleBackColor = False
        '
        'btnMultDelete
        '
        Me.btnMultDelete.BackColor = System.Drawing.Color.LightCyan
        Me.btnMultDelete.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnMultDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultDelete.Location = New System.Drawing.Point(11, 270)
        Me.btnMultDelete.Name = "btnMultDelete"
        Me.btnMultDelete.Size = New System.Drawing.Size(120, 28)
        Me.btnMultDelete.TabIndex = 5
        Me.btnMultDelete.Text = "Delete"
        Me.btnMultDelete.UseVisualStyleBackColor = False
        '
        'btnMultShiftUp
        '
        Me.btnMultShiftUp.BackColor = System.Drawing.Color.LightCyan
        Me.btnMultShiftUp.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnMultShiftUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultShiftUp.Location = New System.Drawing.Point(11, 179)
        Me.btnMultShiftUp.Name = "btnMultShiftUp"
        Me.btnMultShiftUp.Size = New System.Drawing.Size(50, 23)
        Me.btnMultShiftUp.TabIndex = 6
        Me.btnMultShiftUp.Text = "↑"
        Me.btnMultShiftUp.UseVisualStyleBackColor = False
        '
        'btnMultShiftDown
        '
        Me.btnMultShiftDown.BackColor = System.Drawing.Color.LightCyan
        Me.btnMultShiftDown.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnMultShiftDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultShiftDown.Location = New System.Drawing.Point(79, 179)
        Me.btnMultShiftDown.Name = "btnMultShiftDown"
        Me.btnMultShiftDown.Size = New System.Drawing.Size(50, 23)
        Me.btnMultShiftDown.TabIndex = 7
        Me.btnMultShiftDown.Text = "↓"
        Me.btnMultShiftDown.UseVisualStyleBackColor = False
        '
        'btnWrdShiftDown
        '
        Me.btnWrdShiftDown.BackColor = System.Drawing.Color.LightCyan
        Me.btnWrdShiftDown.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnWrdShiftDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWrdShiftDown.Location = New System.Drawing.Point(228, 179)
        Me.btnWrdShiftDown.Name = "btnWrdShiftDown"
        Me.btnWrdShiftDown.Size = New System.Drawing.Size(50, 23)
        Me.btnWrdShiftDown.TabIndex = 11
        Me.btnWrdShiftDown.Text = "↓"
        Me.btnWrdShiftDown.UseVisualStyleBackColor = False
        '
        'btnWrdShiftUp
        '
        Me.btnWrdShiftUp.BackColor = System.Drawing.Color.LightCyan
        Me.btnWrdShiftUp.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnWrdShiftUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWrdShiftUp.Location = New System.Drawing.Point(158, 179)
        Me.btnWrdShiftUp.Name = "btnWrdShiftUp"
        Me.btnWrdShiftUp.Size = New System.Drawing.Size(50, 23)
        Me.btnWrdShiftUp.TabIndex = 10
        Me.btnWrdShiftUp.Text = "↑"
        Me.btnWrdShiftUp.UseVisualStyleBackColor = False
        '
        'btnWrdDelete
        '
        Me.btnWrdDelete.BackColor = System.Drawing.Color.LightCyan
        Me.btnWrdDelete.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnWrdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWrdDelete.Location = New System.Drawing.Point(159, 270)
        Me.btnWrdDelete.Name = "btnWrdDelete"
        Me.btnWrdDelete.Size = New System.Drawing.Size(120, 28)
        Me.btnWrdDelete.TabIndex = 9
        Me.btnWrdDelete.Text = "Delete"
        Me.btnWrdDelete.UseVisualStyleBackColor = False
        '
        'btnWrdAdd
        '
        Me.btnWrdAdd.BackColor = System.Drawing.Color.LightCyan
        Me.btnWrdAdd.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnWrdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWrdAdd.Location = New System.Drawing.Point(159, 208)
        Me.btnWrdAdd.Name = "btnWrdAdd"
        Me.btnWrdAdd.Size = New System.Drawing.Size(120, 28)
        Me.btnWrdAdd.TabIndex = 8
        Me.btnWrdAdd.Text = "Add"
        Me.btnWrdAdd.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.LightCyan
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(284, 26)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 272)
        Me.btnStart.TabIndex = 12
        Me.btnStart.Text = "--Calculate-->"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lstResults
        '
        Me.lstResults.BackColor = System.Drawing.Color.Azure
        Me.lstResults.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.ItemHeight = 17
        Me.lstResults.Location = New System.Drawing.Point(397, 23)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(120, 276)
        Me.lstResults.TabIndex = 13
        '
        'lblResults
        '
        Me.lblResults.Location = New System.Drawing.Point(396, 3)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(121, 17)
        Me.lblResults.TabIndex = 14
        Me.lblResults.Text = "Results"
        Me.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMultEdit
        '
        Me.btnMultEdit.BackColor = System.Drawing.Color.LightCyan
        Me.btnMultEdit.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnMultEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMultEdit.Location = New System.Drawing.Point(11, 239)
        Me.btnMultEdit.Name = "btnMultEdit"
        Me.btnMultEdit.Size = New System.Drawing.Size(120, 28)
        Me.btnMultEdit.TabIndex = 15
        Me.btnMultEdit.Text = "Edit"
        Me.btnMultEdit.UseVisualStyleBackColor = False
        '
        'btnWrdEdit
        '
        Me.btnWrdEdit.BackColor = System.Drawing.Color.LightCyan
        Me.btnWrdEdit.FlatAppearance.BorderColor = System.Drawing.Color.PaleTurquoise
        Me.btnWrdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWrdEdit.Location = New System.Drawing.Point(159, 239)
        Me.btnWrdEdit.Name = "btnWrdEdit"
        Me.btnWrdEdit.Size = New System.Drawing.Size(120, 28)
        Me.btnWrdEdit.TabIndex = 16
        Me.btnWrdEdit.Text = "Edit"
        Me.btnWrdEdit.UseVisualStyleBackColor = False
        '
        'FizzBuzz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.ClientSize = New System.Drawing.Size(528, 306)
        Me.Controls.Add(Me.btnWrdEdit)
        Me.Controls.Add(Me.btnMultEdit)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnWrdShiftDown)
        Me.Controls.Add(Me.btnWrdShiftUp)
        Me.Controls.Add(Me.btnWrdDelete)
        Me.Controls.Add(Me.btnWrdAdd)
        Me.Controls.Add(Me.btnMultShiftDown)
        Me.Controls.Add(Me.btnMultShiftUp)
        Me.Controls.Add(Me.btnMultDelete)
        Me.Controls.Add(Me.btnMultAdd)
        Me.Controls.Add(Me.lblWords)
        Me.Controls.Add(Me.lblMultipliers)
        Me.Controls.Add(Me.lstWords)
        Me.Controls.Add(Me.lstMultipliers)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FizzBuzz"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FizzBuzz"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstMultipliers As ListBox
    Friend WithEvents lstWords As ListBox
    Friend WithEvents lblMultipliers As Label
    Friend WithEvents lblWords As Label
    Friend WithEvents btnMultAdd As Button
    Friend WithEvents btnMultDelete As Button
    Friend WithEvents btnMultShiftUp As Button
    Friend WithEvents btnMultShiftDown As Button
    Friend WithEvents btnWrdShiftDown As Button
    Friend WithEvents btnWrdShiftUp As Button
    Friend WithEvents btnWrdDelete As Button
    Friend WithEvents btnWrdAdd As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lstResults As ListBox
    Friend WithEvents lblResults As Label
    Friend WithEvents btnMultEdit As Button
    Friend WithEvents btnWrdEdit As Button
End Class
