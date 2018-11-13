<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVat
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
        Me.TbPrice = New System.Windows.Forms.TextBox()
        Me.TbTotal = New System.Windows.Forms.TextBox()
        Me.LbPrice = New System.Windows.Forms.Label()
        Me.LbVat = New System.Windows.Forms.Label()
        Me.LbTotal = New System.Windows.Forms.Label()
        Me.Bt7p = New System.Windows.Forms.Button()
        Me.Bt10p = New System.Windows.Forms.Button()
        Me.Bt15p = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TbPrice
        '
        Me.TbPrice.Location = New System.Drawing.Point(80, 27)
        Me.TbPrice.Name = "TbPrice"
        Me.TbPrice.Size = New System.Drawing.Size(125, 20)
        Me.TbPrice.TabIndex = 0
        '
        'TbTotal
        '
        Me.TbTotal.Location = New System.Drawing.Point(82, 109)
        Me.TbTotal.Name = "TbTotal"
        Me.TbTotal.ReadOnly = True
        Me.TbTotal.Size = New System.Drawing.Size(123, 20)
        Me.TbTotal.TabIndex = 1
        '
        'LbPrice
        '
        Me.LbPrice.AutoSize = True
        Me.LbPrice.Location = New System.Drawing.Point(21, 30)
        Me.LbPrice.Name = "LbPrice"
        Me.LbPrice.Size = New System.Drawing.Size(31, 13)
        Me.LbPrice.TabIndex = 2
        Me.LbPrice.Text = "Price"
        '
        'LbVat
        '
        Me.LbVat.AutoSize = True
        Me.LbVat.Location = New System.Drawing.Point(21, 70)
        Me.LbVat.Name = "LbVat"
        Me.LbVat.Size = New System.Drawing.Size(23, 13)
        Me.LbVat.TabIndex = 3
        Me.LbVat.Text = "Vat"
        '
        'LbTotal
        '
        Me.LbTotal.AutoSize = True
        Me.LbTotal.Location = New System.Drawing.Point(21, 112)
        Me.LbTotal.Name = "LbTotal"
        Me.LbTotal.Size = New System.Drawing.Size(31, 13)
        Me.LbTotal.TabIndex = 4
        Me.LbTotal.Text = "Total"
        '
        'Bt7p
        '
        Me.Bt7p.Location = New System.Drawing.Point(82, 67)
        Me.Bt7p.Name = "Bt7p"
        Me.Bt7p.Size = New System.Drawing.Size(37, 21)
        Me.Bt7p.TabIndex = 5
        Me.Bt7p.Text = "7%"
        Me.Bt7p.UseVisualStyleBackColor = True
        '
        'Bt10p
        '
        Me.Bt10p.Location = New System.Drawing.Point(125, 67)
        Me.Bt10p.Name = "Bt10p"
        Me.Bt10p.Size = New System.Drawing.Size(37, 21)
        Me.Bt10p.TabIndex = 6
        Me.Bt10p.Text = "10%"
        Me.Bt10p.UseVisualStyleBackColor = True
        '
        'Bt15p
        '
        Me.Bt15p.Location = New System.Drawing.Point(168, 67)
        Me.Bt15p.Name = "Bt15p"
        Me.Bt15p.Size = New System.Drawing.Size(37, 21)
        Me.Bt15p.TabIndex = 7
        Me.Bt15p.Text = "15%"
        Me.Bt15p.UseVisualStyleBackColor = True
        '
        'FrmVat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 162)
        Me.Controls.Add(Me.Bt15p)
        Me.Controls.Add(Me.Bt10p)
        Me.Controls.Add(Me.Bt7p)
        Me.Controls.Add(Me.LbTotal)
        Me.Controls.Add(Me.LbVat)
        Me.Controls.Add(Me.LbPrice)
        Me.Controls.Add(Me.TbTotal)
        Me.Controls.Add(Me.TbPrice)
        Me.Name = "FrmVat"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TbPrice As TextBox
    Friend WithEvents TbTotal As TextBox
    Friend WithEvents LbPrice As Label
    Friend WithEvents LbVat As Label
    Friend WithEvents LbTotal As Label
    Friend WithEvents Bt7p As Button
    Friend WithEvents Bt10p As Button
    Friend WithEvents Bt15p As Button
End Class
