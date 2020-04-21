<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModeIphone
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.IphoneScreen_Panel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SidePanelWithControls_Panel = New System.Windows.Forms.Panel()
        Me.AppControls_Panel = New System.Windows.Forms.Panel()
        Me.Header_Panel = New System.Windows.Forms.Panel()
        Me.Btn_ShowPlayList = New System.Windows.Forms.PictureBox()
        Me.AlbumPicture_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ArtistName_Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MusicName_Label = New System.Windows.Forms.Label()
        Me.PlayerControls_Panel = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Btn_BackMusic = New System.Windows.Forms.PictureBox()
        Me.Btn_NextMusic = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BateryPorcentage_Label = New System.Windows.Forms.Label()
        Me.Time_Label = New System.Windows.Forms.Label()
        Me.Btn_PlayPause = New System.Windows.Forms.PictureBox()
        Me.TimerTime = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_CrazyBatery = New System.Windows.Forms.Timer(Me.components)
        Me.IphoneScreen_Panel.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.AppControls_Panel.SuspendLayout()
        Me.Header_Panel.SuspendLayout()
        CType(Me.Btn_ShowPlayList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbumPicture_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerControls_Panel.SuspendLayout()
        CType(Me.Btn_BackMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_NextMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Btn_PlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IphoneScreen_Panel
        '
        Me.IphoneScreen_Panel.BackColor = System.Drawing.Color.Black
        Me.IphoneScreen_Panel.Controls.Add(Me.Panel4)
        Me.IphoneScreen_Panel.Controls.Add(Me.Panel1)
        Me.IphoneScreen_Panel.Location = New System.Drawing.Point(77, 70)
        Me.IphoneScreen_Panel.Name = "IphoneScreen_Panel"
        Me.IphoneScreen_Panel.Size = New System.Drawing.Size(246, 440)
        Me.IphoneScreen_Panel.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SidePanelWithControls_Panel)
        Me.Panel4.Controls.Add(Me.AppControls_Panel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 20)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 420)
        Me.Panel4.TabIndex = 8
        '
        'SidePanelWithControls_Panel
        '
        Me.SidePanelWithControls_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanelWithControls_Panel.Location = New System.Drawing.Point(236, 0)
        Me.SidePanelWithControls_Panel.Name = "SidePanelWithControls_Panel"
        Me.SidePanelWithControls_Panel.Size = New System.Drawing.Size(10, 420)
        Me.SidePanelWithControls_Panel.TabIndex = 8
        '
        'AppControls_Panel
        '
        Me.AppControls_Panel.Controls.Add(Me.Header_Panel)
        Me.AppControls_Panel.Controls.Add(Me.PlayerControls_Panel)
        Me.AppControls_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppControls_Panel.Location = New System.Drawing.Point(0, 0)
        Me.AppControls_Panel.Name = "AppControls_Panel"
        Me.AppControls_Panel.Size = New System.Drawing.Size(246, 420)
        Me.AppControls_Panel.TabIndex = 7
        '
        'Header_Panel
        '
        Me.Header_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header_Panel.Controls.Add(Me.Btn_ShowPlayList)
        Me.Header_Panel.Controls.Add(Me.AlbumPicture_PictureBox)
        Me.Header_Panel.Controls.Add(Me.ArtistName_Label)
        Me.Header_Panel.Controls.Add(Me.Panel2)
        Me.Header_Panel.Controls.Add(Me.MusicName_Label)
        Me.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Header_Panel.Name = "Header_Panel"
        Me.Header_Panel.Size = New System.Drawing.Size(246, 60)
        Me.Header_Panel.TabIndex = 8
        '
        'Btn_ShowPlayList
        '
        Me.Btn_ShowPlayList.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_ShowPlayList.Image = Global.Music_Player_7.My.Resources.Resources.icons8_lista_de_reprodução_24
        Me.Btn_ShowPlayList.Location = New System.Drawing.Point(204, 15)
        Me.Btn_ShowPlayList.Name = "Btn_ShowPlayList"
        Me.Btn_ShowPlayList.Size = New System.Drawing.Size(30, 30)
        Me.Btn_ShowPlayList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_ShowPlayList.TabIndex = 9
        Me.Btn_ShowPlayList.TabStop = False
        '
        'AlbumPicture_PictureBox
        '
        Me.AlbumPicture_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AlbumPicture_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.AlbumPicture_PictureBox.Image = Global.Music_Player_7.My.Resources.Resources.icons8_notas_musicais_32
        Me.AlbumPicture_PictureBox.Location = New System.Drawing.Point(10, 13)
        Me.AlbumPicture_PictureBox.Name = "AlbumPicture_PictureBox"
        Me.AlbumPicture_PictureBox.Size = New System.Drawing.Size(35, 35)
        Me.AlbumPicture_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlbumPicture_PictureBox.TabIndex = 8
        Me.AlbumPicture_PictureBox.TabStop = False
        '
        'ArtistName_Label
        '
        Me.ArtistName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ArtistName_Label.AutoEllipsis = True
        Me.ArtistName_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistName_Label.Location = New System.Drawing.Point(49, 33)
        Me.ArtistName_Label.Name = "ArtistName_Label"
        Me.ArtistName_Label.Size = New System.Drawing.Size(149, 15)
        Me.ArtistName_Label.TabIndex = 7
        Me.ArtistName_Label.Text = "The Chaninsmokers"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 1)
        Me.Panel2.TabIndex = 5
        '
        'MusicName_Label
        '
        Me.MusicName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MusicName_Label.AutoEllipsis = True
        Me.MusicName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicName_Label.Location = New System.Drawing.Point(48, 13)
        Me.MusicName_Label.Name = "MusicName_Label"
        Me.MusicName_Label.Size = New System.Drawing.Size(150, 19)
        Me.MusicName_Label.TabIndex = 6
        Me.MusicName_Label.Text = "Sick Boy"
        '
        'PlayerControls_Panel
        '
        Me.PlayerControls_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PlayerControls_Panel.Controls.Add(Me.Panel3)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_BackMusic)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_NextMusic)
        Me.PlayerControls_Panel.Controls.Add(Me.PictureBox1)
        Me.PlayerControls_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PlayerControls_Panel.Location = New System.Drawing.Point(0, 360)
        Me.PlayerControls_Panel.Name = "PlayerControls_Panel"
        Me.PlayerControls_Panel.Size = New System.Drawing.Size(246, 60)
        Me.PlayerControls_Panel.TabIndex = 7
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 1)
        Me.Panel3.TabIndex = 4
        '
        'Btn_BackMusic
        '
        Me.Btn_BackMusic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_BackMusic.Image = Global.Music_Player_7.My.Resources.Resources.icons8_início_32
        Me.Btn_BackMusic.Location = New System.Drawing.Point(52, 10)
        Me.Btn_BackMusic.Name = "Btn_BackMusic"
        Me.Btn_BackMusic.Size = New System.Drawing.Size(40, 40)
        Me.Btn_BackMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_BackMusic.TabIndex = 3
        Me.Btn_BackMusic.TabStop = False
        '
        'Btn_NextMusic
        '
        Me.Btn_NextMusic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_NextMusic.Image = Global.Music_Player_7.My.Resources.Resources.icons8_fim_32
        Me.Btn_NextMusic.Location = New System.Drawing.Point(154, 10)
        Me.Btn_NextMusic.Name = "Btn_NextMusic"
        Me.Btn_NextMusic.Size = New System.Drawing.Size(40, 40)
        Me.Btn_NextMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_NextMusic.TabIndex = 2
        Me.Btn_NextMusic.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox1.Image = Global.Music_Player_7.My.Resources.Resources.icons8_play_dentro_de_um_círculo_48
        Me.PictureBox1.Location = New System.Drawing.Point(98, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BateryPorcentage_Label)
        Me.Panel1.Controls.Add(Me.Time_Label)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 20)
        Me.Panel1.TabIndex = 5
        '
        'BateryPorcentage_Label
        '
        Me.BateryPorcentage_Label.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BateryPorcentage_Label.AutoSize = True
        Me.BateryPorcentage_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.BateryPorcentage_Label.Location = New System.Drawing.Point(212, 3)
        Me.BateryPorcentage_Label.Name = "BateryPorcentage_Label"
        Me.BateryPorcentage_Label.Size = New System.Drawing.Size(34, 15)
        Me.BateryPorcentage_Label.TabIndex = 9
        Me.BateryPorcentage_Label.Text = "100%"
        '
        'Time_Label
        '
        Me.Time_Label.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Time_Label.AutoSize = True
        Me.Time_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!)
        Me.Time_Label.Location = New System.Drawing.Point(106, 3)
        Me.Time_Label.Name = "Time_Label"
        Me.Time_Label.Size = New System.Drawing.Size(35, 15)
        Me.Time_Label.TabIndex = 8
        Me.Time_Label.Text = "22:54"
        '
        'Btn_PlayPause
        '
        Me.Btn_PlayPause.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_PlayPause.Image = Global.Music_Player_7.My.Resources.Resources.icons8_círculo_32
        Me.Btn_PlayPause.Location = New System.Drawing.Point(175, 516)
        Me.Btn_PlayPause.Name = "Btn_PlayPause"
        Me.Btn_PlayPause.Size = New System.Drawing.Size(50, 50)
        Me.Btn_PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_PlayPause.TabIndex = 1
        Me.Btn_PlayPause.TabStop = False
        '
        'TimerTime
        '
        Me.TimerTime.Enabled = True
        Me.TimerTime.Interval = 1
        '
        'Timer_CrazyBatery
        '
        Me.Timer_CrazyBatery.Enabled = True
        Me.Timer_CrazyBatery.Interval = 1
        '
        'ModeIphone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Music_Player_7.My.Resources.Resources.apple_iphone8plus_gold_1_3x
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(400, 580)
        Me.Controls.Add(Me.Btn_PlayPause)
        Me.Controls.Add(Me.IphoneScreen_Panel)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModeIphone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModeIphone"
        Me.IphoneScreen_Panel.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.AppControls_Panel.ResumeLayout(False)
        Me.Header_Panel.ResumeLayout(False)
        CType(Me.Btn_ShowPlayList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbumPicture_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayerControls_Panel.ResumeLayout(False)
        CType(Me.Btn_BackMusic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_NextMusic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Btn_PlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents IphoneScreen_Panel As System.Windows.Forms.Panel
    Friend WithEvents Btn_PlayPause As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BateryPorcentage_Label As System.Windows.Forms.Label
    Friend WithEvents Time_Label As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents AppControls_Panel As System.Windows.Forms.Panel
    Friend WithEvents Header_Panel As System.Windows.Forms.Panel
    Friend WithEvents Btn_ShowPlayList As System.Windows.Forms.PictureBox
    Friend WithEvents AlbumPicture_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ArtistName_Label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MusicName_Label As System.Windows.Forms.Label
    Friend WithEvents PlayerControls_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Btn_BackMusic As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_NextMusic As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SidePanelWithControls_Panel As System.Windows.Forms.Panel
    Friend WithEvents TimerTime As System.Windows.Forms.Timer
    Friend WithEvents Timer_CrazyBatery As System.Windows.Forms.Timer
End Class
