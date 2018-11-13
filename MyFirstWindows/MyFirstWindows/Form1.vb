Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MessageBox.Show("Student ID: 58121039-0" + Environment.NewLine +
            "Full name: Kitsana Phongarm" + Environment.NewLine +
            "Major/Branch: IT" + Environment.NewLine +
            "Grade: 2.37", "Student Details", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class
