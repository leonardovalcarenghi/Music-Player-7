<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PlayerForm))
        Me.Controls_Panel = New System.Windows.Forms.Panel()
        Me.Player_Panel = New System.Windows.Forms.Panel()
        Me.PlayerControls_Panel = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_BackMusic = New System.Windows.Forms.PictureBox()
        Me.Btn_NextMusic = New System.Windows.Forms.PictureBox()
        Me.Btn_PlayPause = New System.Windows.Forms.PictureBox()
        Me.Header_Panel = New System.Windows.Forms.Panel()
        Me.Btn_ModeiPhone = New System.Windows.Forms.PictureBox()
        Me.Btn_ShowPlayList = New System.Windows.Forms.PictureBox()
        Me.AlbumPicture_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ArtistName_Label = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MusicName_Label = New System.Windows.Forms.Label()
        Me.SidePanelWithControls_Panel = New System.Windows.Forms.Panel()
        Me.MusicInformations_Panel = New System.Windows.Forms.Panel()
        Me.Title_Panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayerCtrl = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Controls_Panel.SuspendLayout()
        Me.Player_Panel.SuspendLayout()
        Me.PlayerControls_Panel.SuspendLayout()
        CType(Me.Btn_BackMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_NextMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_PlayPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Header_Panel.SuspendLayout()
        CType(Me.Btn_ModeiPhone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_ShowPlayList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlbumPicture_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MusicInformations_Panel.SuspendLayout()
        Me.Title_Panel.SuspendLayout()
        CType(Me.PlayerCtrl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Controls_Panel
        '
        Me.Controls_Panel.Controls.Add(Me.Player_Panel)
        Me.Controls_Panel.Controls.Add(Me.PlayerControls_Panel)
        Me.Controls_Panel.Controls.Add(Me.Header_Panel)
        Me.Controls_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Controls_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Controls_Panel.Name = "Controls_Panel"
        Me.Controls_Panel.Size = New System.Drawing.Size(874, 461)
        Me.Controls_Panel.TabIndex = 4
        '
        'Player_Panel
        '
        Me.Player_Panel.Controls.Add(Me.PlayerCtrl)
        Me.Player_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Player_Panel.Location = New System.Drawing.Point(0, 70)
        Me.Player_Panel.Name = "Player_Panel"
        Me.Player_Panel.Size = New System.Drawing.Size(874, 331)
        Me.Player_Panel.TabIndex = 5
        '
        'PlayerControls_Panel
        '
        Me.PlayerControls_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PlayerControls_Panel.Controls.Add(Me.Panel1)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_BackMusic)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_NextMusic)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_PlayPause)
        Me.PlayerControls_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PlayerControls_Panel.Location = New System.Drawing.Point(0, 401)
        Me.PlayerControls_Panel.Name = "PlayerControls_Panel"
        Me.PlayerControls_Panel.Size = New System.Drawing.Size(874, 60)
        Me.PlayerControls_Panel.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(874, 1)
        Me.Panel1.TabIndex = 4
        '
        'Btn_BackMusic
        '
        Me.Btn_BackMusic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_BackMusic.Image = Global.Music_Player_7.My.Resources.Resources.icons8_início_32
        Me.Btn_BackMusic.Location = New System.Drawing.Point(366, 10)
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
        Me.Btn_NextMusic.Location = New System.Drawing.Point(468, 10)
        Me.Btn_NextMusic.Name = "Btn_NextMusic"
        Me.Btn_NextMusic.Size = New System.Drawing.Size(40, 40)
        Me.Btn_NextMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_NextMusic.TabIndex = 2
        Me.Btn_NextMusic.TabStop = False
        '
        'Btn_PlayPause
        '
        Me.Btn_PlayPause.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Btn_PlayPause.Image = Global.Music_Player_7.My.Resources.Resources.icons8_play_dentro_de_um_círculo_48
        Me.Btn_PlayPause.Location = New System.Drawing.Point(412, 5)
        Me.Btn_PlayPause.Name = "Btn_PlayPause"
        Me.Btn_PlayPause.Size = New System.Drawing.Size(50, 50)
        Me.Btn_PlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_PlayPause.TabIndex = 0
        Me.Btn_PlayPause.TabStop = False
        '
        'Header_Panel
        '
        Me.Header_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header_Panel.Controls.Add(Me.Title_Panel)
        Me.Header_Panel.Controls.Add(Me.MusicInformations_Panel)
        Me.Header_Panel.Controls.Add(Me.Btn_ModeiPhone)
        Me.Header_Panel.Controls.Add(Me.Btn_ShowPlayList)
        Me.Header_Panel.Controls.Add(Me.Panel2)
        Me.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Header_Panel.Name = "Header_Panel"
        Me.Header_Panel.Size = New System.Drawing.Size(874, 70)
        Me.Header_Panel.TabIndex = 3
        '
        'Btn_ModeiPhone
        '
        Me.Btn_ModeiPhone.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_ModeiPhone.Image = Global.Music_Player_7.My.Resources.Resources.icons8_iphone_24
        Me.Btn_ModeiPhone.Location = New System.Drawing.Point(796, 20)
        Me.Btn_ModeiPhone.Name = "Btn_ModeiPhone"
        Me.Btn_ModeiPhone.Size = New System.Drawing.Size(30, 30)
        Me.Btn_ModeiPhone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_ModeiPhone.TabIndex = 10
        Me.Btn_ModeiPhone.TabStop = False
        '
        'Btn_ShowPlayList
        '
        Me.Btn_ShowPlayList.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Btn_ShowPlayList.Image = Global.Music_Player_7.My.Resources.Resources.icons8_lista_de_reprodução_24
        Me.Btn_ShowPlayList.Location = New System.Drawing.Point(832, 20)
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
        Me.AlbumPicture_PictureBox.Location = New System.Drawing.Point(20, 14)
        Me.AlbumPicture_PictureBox.Name = "AlbumPicture_PictureBox"
        Me.AlbumPicture_PictureBox.Size = New System.Drawing.Size(40, 40)
        Me.AlbumPicture_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlbumPicture_PictureBox.TabIndex = 8
        Me.AlbumPicture_PictureBox.TabStop = False
        '
        'ArtistName_Label
        '
        Me.ArtistName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ArtistName_Label.AutoSize = True
        Me.ArtistName_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistName_Label.Location = New System.Drawing.Point(66, 35)
        Me.ArtistName_Label.Name = "ArtistName_Label"
        Me.ArtistName_Label.Size = New System.Drawing.Size(38, 19)
        Me.ArtistName_Label.TabIndex = 7
        Me.ArtistName_Label.Text = "artist"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 69)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(874, 1)
        Me.Panel2.TabIndex = 5
        '
        'MusicName_Label
        '
        Me.MusicName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MusicName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicName_Label.Location = New System.Drawing.Point(66, 15)
        Me.MusicName_Label.Name = "MusicName_Label"
        Me.MusicName_Label.Size = New System.Drawing.Size(358, 39)
        Me.MusicName_Label.TabIndex = 6
        Me.MusicName_Label.Text = "music"
        Me.MusicName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SidePanelWithControls_Panel
        '
        Me.SidePanelWithControls_Panel.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanelWithControls_Panel.Location = New System.Drawing.Point(874, 0)
        Me.SidePanelWithControls_Panel.Name = "SidePanelWithControls_Panel"
        Me.SidePanelWithControls_Panel.Size = New System.Drawing.Size(10, 461)
        Me.SidePanelWithControls_Panel.TabIndex = 5
        '
        'MusicInformations_Panel
        '
        Me.MusicInformations_Panel.Controls.Add(Me.AlbumPicture_PictureBox)
        Me.MusicInformations_Panel.Controls.Add(Me.MusicName_Label)
        Me.MusicInformations_Panel.Controls.Add(Me.ArtistName_Label)
        Me.MusicInformations_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.MusicInformations_Panel.Location = New System.Drawing.Point(0, 0)
        Me.MusicInformations_Panel.Name = "MusicInformations_Panel"
        Me.MusicInformations_Panel.Size = New System.Drawing.Size(500, 69)
        Me.MusicInformations_Panel.TabIndex = 11
        Me.MusicInformations_Panel.Visible = False
        '
        'Title_Panel
        '
        Me.Title_Panel.Controls.Add(Me.Label1)
        Me.Title_Panel.Dock = System.Windows.Forms.DockStyle.Left
        Me.Title_Panel.Location = New System.Drawing.Point(500, 0)
        Me.Title_Panel.Name = "Title_Panel"
        Me.Title_Panel.Size = New System.Drawing.Size(229, 69)
        Me.Title_Panel.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Music Player 7"
        '
        'PlayerCtrl
        '
        Me.PlayerCtrl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PlayerCtrl.Enabled = True
        Me.PlayerCtrl.Location = New System.Drawing.Point(0, 0)
        Me.PlayerCtrl.Name = "PlayerCtrl"
        Me.PlayerCtrl.OcxState = CType(resources.GetObject("PlayerCtrl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.PlayerCtrl.Size = New System.Drawing.Size(874, 331)
        Me.PlayerCtrl.TabIndex = 0
        '
        'PlayerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(884, 461)
        Me.Controls.Add(Me.Controls_Panel)
        Me.Controls.Add(Me.SidePanelWithControls_Panel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "PlayerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Music Player 7"
        Me.Controls_Panel.ResumeLayout(False)
        Me.Player_Panel.ResumeLayout(False)
        Me.PlayerControls_Panel.ResumeLayout(False)
        CType(Me.Btn_BackMusic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_NextMusic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_PlayPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Header_Panel.ResumeLayout(False)
        CType(Me.Btn_ModeiPhone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_ShowPlayList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlbumPicture_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MusicInformations_Panel.ResumeLayout(False)
        Me.MusicInformations_Panel.PerformLayout()
        Me.Title_Panel.ResumeLayout(False)
        Me.Title_Panel.PerformLayout()
        CType(Me.PlayerCtrl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Controls_Panel As System.Windows.Forms.Panel
    Friend WithEvents Player_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlayerControls_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Btn_BackMusic As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_NextMusic As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_PlayPause As System.Windows.Forms.PictureBox
    Friend WithEvents Header_Panel As System.Windows.Forms.Panel
    Friend WithEvents Btn_ShowPlayList As System.Windows.Forms.PictureBox
    Friend WithEvents AlbumPicture_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ArtistName_Label As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MusicName_Label As System.Windows.Forms.Label
    Friend WithEvents SidePanelWithControls_Panel As System.Windows.Forms.Panel
    Friend WithEvents Btn_ModeiPhone As System.Windows.Forms.PictureBox
    Friend WithEvents Title_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MusicInformations_Panel As System.Windows.Forms.Panel
    Friend WithEvents PlayerCtrl As AxWMPLib.AxWindowsMediaPlayer

End Class
