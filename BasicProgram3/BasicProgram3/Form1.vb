Public Class FrmVat
    Private Sub Bt7p_Click(sender As Object, e As EventArgs) Handles Bt7p.Click
        Dim Percent As Double = TbPrice.Text
        Dim SevenPercent As Double = (Percent * 7) / 100
        Dim Sum As Double = Percent - SevenPercent
        TbTotal.Text = Format(Sum, "#,###.00 Baht")
    End Sub

    Private Sub Bt10p_Click(sender As Object, e As EventArgs) Handles Bt10p.Click
        Dim Percent As Double = TbPrice.Text
        Dim TenPercent As Double = (Percent * 10) / 100
        Dim Sum As Double = Percent - TenPercent
        TbTotal.Text = Format(Sum, "#,###.00 Baht")
    End Sub

    Private Sub Bt15p_Click(sender As Object, e As EventArgs) Handles Bt15p.Click
        Dim Percent As Double = TbPrice.Text
        Dim FifthteenPercent As Double = (Percent * 15) / 100
        Dim Sum As Double = Percent - FifthteenPercent
        TbTotal.Text = Format(Sum, "#,###.00 Baht")
    End Sub

    Private Sub TbPrice_TextChanged(sender As Object, e As EventArgs) Handles TbPrice.TextChanged

    End Sub

    Private Sub TbTotal_TextChanged(sender As Object, e As EventArgs) Handles TbTotal.TextChanged

    End Sub
End Class
