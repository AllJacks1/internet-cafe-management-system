<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TimerModalMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TimerModalMember))
        lbl_timer = New Label()
        btn_minimize = New PictureBox()
        btn_maximize = New PictureBox()
        btn_logout = New Label()
        btn_insertCoin = New Label()
        CType(btn_minimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(btn_maximize, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lbl_timer
        ' 
        lbl_timer.AutoSize = True
        lbl_timer.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(23))
        lbl_timer.Font = New Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbl_timer.ForeColor = Color.FromArgb(CByte(139), CByte(31), CByte(193))
        lbl_timer.Location = New Point(50, 35)
        lbl_timer.Name = "lbl_timer"
        lbl_timer.Size = New Size(90, 37)
        lbl_timer.TabIndex = 1
        lbl_timer.Text = "00:00"
        ' 
        ' btn_minimize
        ' 
        btn_minimize.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(23))
        btn_minimize.Cursor = Cursors.Hand
        btn_minimize.Image = CType(resources.GetObject("btn_minimize.Image"), Image)
        btn_minimize.Location = New Point(653, 6)
        btn_minimize.Name = "btn_minimize"
        btn_minimize.Size = New Size(20, 12)
        btn_minimize.SizeMode = PictureBoxSizeMode.StretchImage
        btn_minimize.TabIndex = 2
        btn_minimize.TabStop = False
        ' 
        ' btn_maximize
        ' 
        btn_maximize.BackColor = Color.FromArgb(CByte(19), CByte(21), CByte(23))
        btn_maximize.Cursor = Cursors.Hand
        btn_maximize.Image = CType(resources.GetObject("btn_maximize.Image"), Image)
        btn_maximize.Location = New Point(634, 6)
        btn_maximize.Name = "btn_maximize"
        btn_maximize.Size = New Size(13, 12)
        btn_maximize.SizeMode = PictureBoxSizeMode.StretchImage
        btn_maximize.TabIndex = 3
        btn_maximize.TabStop = False
        ' 
        ' btn_logout
        ' 
        btn_logout.AutoSize = True
        btn_logout.BackColor = Color.FromArgb(CByte(115), CByte(115), CByte(115))
        btn_logout.Cursor = Cursors.Hand
        btn_logout.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_logout.ForeColor = Color.White
        btn_logout.Location = New Point(263, 30)
        btn_logout.Name = "btn_logout"
        btn_logout.Size = New Size(154, 21)
        btn_logout.TabIndex = 6
        btn_logout.Text = "          LOGOUT          "
        ' 
        ' btn_insertCoin
        ' 
        btn_insertCoin.AutoSize = True
        btn_insertCoin.BackColor = Color.FromArgb(CByte(139), CByte(31), CByte(193))
        btn_insertCoin.Cursor = Cursors.Hand
        btn_insertCoin.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btn_insertCoin.ForeColor = Color.White
        btn_insertCoin.Location = New Point(468, 30)
        btn_insertCoin.Name = "btn_insertCoin"
        btn_insertCoin.Size = New Size(143, 21)
        btn_insertCoin.TabIndex = 7
        btn_insertCoin.Text = "     INSET COIN      "
        ' 
        ' TimerModalMember
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Lime
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(682, 81)
        Controls.Add(btn_insertCoin)
        Controls.Add(btn_logout)
        Controls.Add(btn_maximize)
        Controls.Add(btn_minimize)
        Controls.Add(lbl_timer)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Location = New Point(1920, 0)
        Name = "TimerModalMember"
        StartPosition = FormStartPosition.Manual
        Text = "Timer"
        CType(btn_minimize, ComponentModel.ISupportInitialize).EndInit()
        CType(btn_maximize, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lbl_timer As Label
    Friend WithEvents btn_minimize As PictureBox
    Friend WithEvents btn_maximize As PictureBox
    Friend WithEvents btn_logout As Label
    Friend WithEvents btn_insertCoin As Label
End Class
