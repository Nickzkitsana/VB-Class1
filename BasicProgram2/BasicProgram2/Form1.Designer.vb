<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSum
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
        Me.LbName1 = New System.Windows.Forms.Label()
        Me.LbNum2 = New System.Windows.Forms.Label()
        Me.BtSum = New System.Windows.Forms.Button()
        Me.BtClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbNum1
        '
        Me.TbNum1.Location = New System.Drawing.Point(120, 30)
        Me.TbNum1.Name = "TbNum1"
        Me.TbNum1.Size = New System.Drawing.Size(115, 20)
        Me.TbNum1.TabIndex = 0
        '
        'TbNum2
        '
        Me.TbNum2.Location = New System.Drawing.Point(120, 83)
        Me.TbNum2.Name = "TbNum2"
        Me.TbNum2.Size = New System.Drawing.Size(115, 20)
        Me.TbNum2.TabIndex = 1
        '
        'LbName1
        '
        Me.LbName1.AutoSize = True
        Me.LbName1.Location = New System.Drawing.Point(32, 33)
        Me.LbName1.Name = "LbName1"
        Me.LbName1.Size = New System.Drawing.Size(53, 13)
        Me.LbName1.TabIndex = 2
        Me.LbName1.Text = "Number 1"
        '
        'LbNum2
        '
        Me.LbNum2.AutoSize = True
        Me.LbNum2.Location = New System.Drawing.Point(32, 86)
        Me.LbNum2.Name = "LbNum2"
        Me.LbNum2.Size = New System.Drawing.Size(53, 13)
        Me.LbNum2.TabIndex = 3
        Me.LbNum2.Text = "Number 2"
        '
        'BtSum
        '
        Me.BtSum.Location = New System.Drawing.Point(32, 139)
        Me.BtSum.Name = "BtSum"
        Me.BtSum.Size = New System.Drawing.Size(85, 31)
        Me.BtSum.TabIndex = 4
        Me.BtSum.Text = "Sum"
        Me.BtSum.UseVisualStyleBackColor = True
        '
        'BtClear
        '
        Me.BtClear.Location = New System.Drawing.Point(166, 139)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(89, 32)
        Me.BtClear.TabIndex = 5
        Me.BtClear.Text = "Clear"
        Me.BtClear.UseVisualStyleBackColor = True
        '
        'FrmSum
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 184)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.BtSum)
        Me.Controls.Add(Me.LbNum2)
        Me.Controls.Add(Me.LbName1)
        Me.Controls.Add(Me.TbNum2)
        Me.Controls.Add(Me.TbNum1)
        Me.Name = "FrmSum"
        Me.Text = "Sum"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbNum1 As TextBox
    Friend WithEvents TbNum2 As TextBox
    Friend WithEvents LbName1 As Label
    Friend WithEvents LbNum2 As Label
    Friend WithEvents BtSum As Button
    Friend WithEvents BtClear As Button
End Class
