Public Class Form1
    Private Sub LbResult_Click(sender As Object, e As EventArgs) Handles LbResult.Click

    End Sub

    Private Sub BtPlus_Click(sender As Object, e As EventArgs) Handles BtPlus.Click
        Dim Num1 As Double = TbNum1.Text
        Dim Num2 As Double = TbNum2.Text

        Dim Sum As Double = Num1 + Num2

        TbSum.Text = Sum
    End Sub

    Private Sub BtMinus_Click(sender As Object, e As EventArgs) Handles BtMinus.Click
        Dim Num1 As Double = TbNum1.Text
        Dim Num2 As Double = TbNum2.Text

        Dim Sum As Double = Num1 - Num2

        TbSum.Text = Sum
    End Sub

    Private Sub BtDouble_Click(sender As Object, e As EventArgs) Handles BtDouble.Click
        Dim Num1 As Double = TbNum1.Text
        Dim Num2 As Double = TbNum2.Text

        Dim Sum As Double = Num1 * Num2

        TbSum.Text = Sum
    End Sub

    Private Sub BtMod_Click(sender As Object, e As EventArgs) Handles BtMod.Click
        Dim Num1 As Double = TbNum1.Text
        Dim Num2 As Double = TbNum2.Text

        Dim Sum As Double = Num1 / Num2

        TbSum.Text = Sum
    End Sub

    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        TbNum1.Text = ""
        TbNum2.Text = ""
        TbSum.Text = ""
    End Sub

    Private Sub TbNum1_TextChanged(sender As Object, e As EventArgs) Handles TbNum1.TextChanged

    End Sub

    Private Sub TbNum2_TextChanged(sender As Object, e As EventArgs) Handles TbNum2.TextChanged

    End Sub
End Class
