<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LockScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LockScreen))
        txt_username = New TextBox()
        txt_password = New TextBox()
        lbl_countdown = New Label()
        lbl_shutdown = New Label()
        lbl_timer = New Label()
        lbl_reboot = New Label()
        lbl_login = New Label()
        SuspendLayout()
        ' 
        ' txt_username
        ' 
        txt_username.BackColor = Color.FromArgb(CByte(115), CByte(115), CByte(115))
        txt_username.BorderStyle = BorderStyle.None
        txt_username.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_username.ForeColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        txt_username.Location = New Point(766, 771)
        txt_username.Name = "txt_username"
        txt_username.Size = New Size(394, 28)
        txt_username.TabIndex = 0
        txt_username.Text = "Username"
        ' 
        ' txt_password
        ' 
        txt_password.BackColor = Color.FromArgb(CByte(115), CByte(115), CByte(115))
        txt_password.BorderStyle = BorderStyle.None
        txt_password.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txt_password.ForeColor = Color.FromArgb(CByte(217), CByte(217), CByte(217))
        txt_password.Location = New Point(766, 838)
        txt_password.Name = "txt_password"
        txt_password.Size = New Size(394, 28)
        txt_password.TabIndex = 1
        txt_password.Text = "Password"
        ' 
        ' lbl_countdown
        ' 
        lbl_countdown.AutoSize = True
        lbl_countdown.BackColor = Color.FromArgb(CByte(139), CByte(31), CByte(193))
        lbl_countdown.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_countdown.ForeColor = Color.White
        lbl_countdown.Location = New Point(1500, 22)
        lbl_countdown.Name = "lbl_countdown"
        lbl_countdown.Size = New Size(168, 17)
        lbl_countdown.TabIndex = 2
        lbl_countdown.Text = "System will Shutdown in: "
        ' 
        ' lbl_shutdown
        ' 
        lbl_shutdown.AutoSize = True
        lbl_shutdown.BackColor = Color.FromArgb(CByte(139), CByte(31), CByte(193))
        lbl_shutdown.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbl_shutdown.ForeColor = Color.White
        lbl_shutdown.Location = New Point(1723, 22)
        lbl_shutdown.Name = "lbl_shutdown"
        lbl_shutdown.Size = New Size(100, 17)
        lbl_shutdown.TabIndex = 4
        lbl_shutdown.Text = "Shutdown now"
        ' 
        ' lbl_timer
        ' 
        lbl_timer.AutoSize = True
        lbl_timer.BackColor = Color.FromArgb(CByte(139), CByte(31), CByte(193))
        lbl_timer.Font = New Font("Segoe UI Black", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_timer.ForeColor = Color.White
        lbl_timer.Location = New Point(1662, 20)
        lbl_timer.Name = "lbl_timer"
        lbl_timer.Size = New Size(38, 21)
        lbl_timer.TabIndex = 5
        lbl_timer.Text = "120"
        ' 
        ' lbl_reboot
        ' 
        lbl_reboot.AutoSize = True
        lbl_reboot.BackColor = Color.FromArgb(CByte(139), CByte(31), CByte(193))
        lbl_reboot.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lbl_reboot.ForeColor = Color.White
        lbl_reboot.Location = New Point(1829, 22)
        lbl_reboot.Name = "lbl_reboot"
        lbl_reboot.Size = New Size(52, 17)
        lbl_reboot.TabIndex = 6
        lbl_reboot.Text = "Reboot"
        ' 
        ' lbl_login
        ' 
        lbl_login.AutoSize = True
        lbl_login.BackColor = Color.FromArgb(CByte(139), CByte(31), CByte(193))
        lbl_login.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_login.ForeColor = Color.White
        lbl_login.Location = New Point(766, 913)
        lbl_login.Name = "lbl_login"
        lbl_login.Size = New Size(388, 32)
        lbl_login.TabIndex = 7
        lbl_login.Text = "                     LOGIN                      "
        ' 
        ' LockScreen
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1920, 1080)
        Controls.Add(lbl_login)
        Controls.Add(lbl_reboot)
        Controls.Add(lbl_timer)
        Controls.Add(lbl_shutdown)
        Controls.Add(lbl_countdown)
        Controls.Add(txt_password)
        Controls.Add(txt_username)
        FormBorderStyle = FormBorderStyle.None
        Name = "LockScreen"
        Text = "ICMS"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txt_username As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents lbl_countdown As Label
    Friend WithEvents lbl_shutdown As Label
    Friend WithEvents lbl_timer As Label
    Friend WithEvents lbl_reboot As Label
    Friend WithEvents lbl_login As Label
End Class
