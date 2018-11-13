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
        Me.TbName = New System.Windows.Forms.TextBox()
        Me.LbName = New System.Windows.Forms.Label()
        Me.BtOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbName
        '
        Me.TbName.Location = New System.Drawing.Point(54, 56)
        Me.TbName.Name = "TbName"
        Me.TbName.Size = New System.Drawing.Size(232, 20)
        Me.TbName.TabIndex = 0
        Me.TbName.Text = "( Input your name )"
        '
        'LbName
        '
        Me.LbName.AutoSize = True
        Me.LbName.Location = New System.Drawing.Point(54, 102)
        Me.LbName.Name = "LbName"
        Me.LbName.Size = New System.Drawing.Size(0, 13)
        Me.LbName.TabIndex = 1
        '
        'BtOk
        '
        Me.BtOk.Location = New System.Drawing.Point(54, 144)
        Me.BtOk.Name = "BtOk"
        Me.BtOk.Size = New System.Drawing.Size(154, 26)
        Me.BtOk.TabIndex = 2
        Me.BtOk.Text = "OK"
        Me.BtOk.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 219)
        Me.Controls.Add(Me.BtOk)
        Me.Controls.Add(Me.LbName)
        Me.Controls.Add(Me.TbName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbName As TextBox
    Friend WithEvents LbName As Label
    Friend WithEvents BtOk As Button
End Class
