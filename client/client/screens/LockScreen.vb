

Public Class LockScreen

    Private WithEvents ShutdownTimer As New Timer()
    Private countdownValue As Integer = 160
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txt_username.Click
        txt_username.Clear()
        txt_username.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txt_password.Click
        txt_password.Clear()
        txt_password.ForeColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
    End Sub

    Private Sub lbl_login_Click(sender As Object, e As EventArgs) Handles lbl_login.Click
        MsgBox("loging in")
    End Sub

    Private Sub lbl_shutdown_Click(sender As Object, e As EventArgs) Handles lbl_shutdown.Click
        MsgBox("shutting down")
    End Sub

    Private Sub lbl_reboot_Click(sender As Object, e As EventArgs) Handles lbl_reboot.Click
        MsgBox("rebooting")
    End Sub

    Private Sub LockScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_timer.Text = countdownValue
        ShutdownTimer.Interval = 1000
        ShutdownTimer.Start()
        Me.KeyPreview = True
    End Sub

    Private Sub ShutdownTimer_Tick(sender As Object, e As EventArgs) Handles ShutdownTimer.Tick
        countdownValue -= 1
        lbl_timer.Text = countdownValue.ToString()

        If countdownValue <= 0 Then
            ShutdownTimer.Stop()
        End If
    End Sub

    Private Sub LockScreen_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim timerGuest As New TimerModalGuest
            timerGuest.Show()
        End If
        If e.KeyCode = Keys.F2 Then
            Dim timerMember As New TimerModalMember
            timerMember.Show()
        End If
    End Sub

    Private Sub lbl_timer_Click(sender As Object, e As EventArgs) Handles lbl_timer.Click

    End Sub
End Class