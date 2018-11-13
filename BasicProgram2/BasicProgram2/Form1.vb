Public Class FrmSum
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles LbName1.Click

    End Sub

    Private Sub TbNum1_TextChanged(sender As Object, e As EventArgs) Handles TbNum1.TextChanged

    End Sub

    Private Sub TbNum2_TextChanged(sender As Object, e As EventArgs) Handles TbNum2.TextChanged

    End Sub

    Private Sub BtSum_Click(sender As Object, e As EventArgs) Handles BtSum.Click
        Dim num1 As Integer = TbNum1.Text
        Dim num2 As Integer = TbNum2.Text
        Dim Sum As Integer = num1 + num2
        MessageBox.Show(Sum, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        TbNum1.Text = ""
        TbNum2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
