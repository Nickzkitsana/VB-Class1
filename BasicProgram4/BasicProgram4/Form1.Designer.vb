<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TbNum1 = New System.Windows.Forms.TextBox()
        Me.TbNum2 = New System.Windows.Forms.TextBox()
        Me.TbSum = New System.Windows.Forms.TextBox()
        Me.LbNum1 = New System.Windows.Forms.Label()
        Me.LbNum2 = New System.Windows.Forms.Label()
        Me.LbResult = New System.Windows.Forms.Label()
        Me.BtPlus = New System.Windows.Forms.Button()
        Me.BtMinus = New System.Windows.Forms.Button()
        Me.BtDouble = New System.Windows.Forms.Button()
        Me.BtMod = New System.Windows.Forms.Button()
        Me.BtClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbNum1
        '
        Me.TbNum1.Location = New System.Drawing.Point(120, 34)
        Me.TbNum1.Name = "TbNum1"
        Me.TbNum1.Size = New System.Drawing.Size(100, 20)
        Me.TbNum1.TabIndex = 0
        '
        'TbNum2
        '
        Me.TbNum2.Location = New System.Drawing.Point(120, 90)
        Me.TbNum2.Name = "TbNum2"
        Me.TbNum2.Size = New System.Drawing.Size(100, 20)
        Me.TbNum2.TabIndex = 1
        '
        'TbSum
        '
        Me.TbSum.Location = New System.Drawing.Point(120, 148)
        Me.TbSum.Name = "TbSum"
        Me.TbSum.ReadOnly = True
        Me.TbSum.Size = New System.Drawing.Size(100, 20)
        Me.TbSum.TabIndex = 2
        '
        'LbNum1
        '
        Me.LbNum1.AutoSize = True
        Me.LbNum1.Location = New System.Drawing.Point(24, 37)
        Me.LbNum1.Name = "LbNum1"
        Me.LbNum1.Size = New System.Drawing.Size(53, 13)
        Me.LbNum1.TabIndex = 3
        Me.LbNum1.Text = "Number 1"
        '
        'LbNum2
        '
        Me.LbNum2.AutoSize = True
        Me.LbNum2.Location = New System.Drawing.Point(24, 93)
        Me.LbNum2.Name = "LbNum2"
        Me.LbNum2.Size = New System.Drawing.Size(53, 13)
        Me.LbNum2.TabIndex = 4
        Me.LbNum2.Text = "Number 2"
        '
        'LbResult
        '
        Me.LbResult.AutoSize = True
        Me.LbResult.Location = New System.Drawing.Point(24, 151)
        Me.LbResult.Name = "LbResult"
        Me.LbResult.Size = New System.Drawing.Size(37, 13)
        Me.LbResult.TabIndex = 5
        Me.LbResult.Text = "Result"
        '
        'BtPlus
        '
        Me.BtPlus.Location = New System.Drawing.Point(246, 29)
        Me.BtPlus.Name = "BtPlus"
        Me.BtPlus.Size = New System.Drawing.Size(41, 29)
        Me.BtPlus.TabIndex = 6
        Me.BtPlus.Text = "+"
        Me.BtPlus.UseVisualStyleBackColor = True
        '
        'BtMinus
        '
        Me.BtMinus.Location = New System.Drawing.Point(296, 29)
        Me.BtMinus.Name = "BtMinus"
        Me.BtMinus.Size = New System.Drawing.Size(41, 29)
        Me.BtMinus.TabIndex = 7
        Me.BtMinus.Text = "-"
        Me.BtMinus.UseVisualStyleBackColor = True
        '
        'BtDouble
        '
        Me.BtDouble.Location = New System.Drawing.Point(246, 85)
        Me.BtDouble.Name = "BtDouble"
        Me.BtDouble.Size = New System.Drawing.Size(41, 29)
        Me.BtDouble.TabIndex = 8
        Me.BtDouble.Text = "x"
        Me.BtDouble.UseVisualStyleBackColor = True
        '
        'BtMod
        '
        Me.BtMod.Location = New System.Drawing.Point(296, 85)
        Me.BtMod.Name = "BtMod"
        Me.BtMod.Size = New System.Drawing.Size(41, 29)
        Me.BtMod.TabIndex = 9
        Me.BtMod.Text = "/"
        Me.BtMod.UseVisualStyleBackColor = True
        '
        'BtClear
        '
        Me.BtClear.Location = New System.Drawing.Point(246, 142)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(89, 30)
        Me.BtClear.TabIndex = 10
        Me.BtClear.Text = "Clear"
        Me.BtClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 199)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.BtMod)
        Me.Controls.Add(Me.BtDouble)
        Me.Controls.Add(Me.BtMinus)
        Me.Controls.Add(Me.BtPlus)
        Me.Controls.Add(Me.LbResult)
        Me.Controls.Add(Me.LbNum2)
        Me.Controls.Add(Me.LbNum1)
        Me.Controls.Add(Me.TbSum)
        Me.Controls.Add(Me.TbNum2)
        Me.Controls.Add(Me.TbNum1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbNum1 As TextBox
    Friend WithEvents TbNum2 As TextBox
    Friend WithEvents TbSum As TextBox
    Friend WithEvents LbNum1 As Label
    Friend WithEvents LbNum2 As Label
    Friend WithEvents LbResult As Label
    Friend WithEvents BtPlus As Button
    Friend WithEvents BtMinus As Button
    Friend WithEvents BtDouble As Button
    Friend WithEvents BtMod As Button
    Friend WithEvents BtClear As Button
End Class
