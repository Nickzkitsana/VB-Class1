Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TbName.TextChanged

    End Sub

    Private Sub LbName_Click(sender As Object, e As EventArgs) Handles LbName.Click

    End Sub

    Private Sub BtOk_Click(sender As Object, e As EventArgs) Handles BtOk.Click
        Dim msg As String = TbName.Text
        LbName.Text = msg
    End Sub
End Class
