Public Class LockScreen
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
        TextBox1.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
        TextBox2.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
    End Sub
End Class