<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayListControl
    Inherits System.Windows.Forms.UserControl

    'Descartar substituições de UserControl para limpar lista de componentes.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MusicsList_Panel = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Btn_HidePlayList = New System.Windows.Forms.PictureBox()
        Me.Btn_DownloadMusic = New System.Windows.Forms.PictureBox()
        Me.Btn_AddMusicOnList = New System.Windows.Forms.PictureBox()
        Me.PlayerControls_Panel = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Header_Panel = New System.Windows.Forms.Panel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.Btn_HidePlayList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_DownloadMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_AddMusicOnList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PlayerControls_Panel.SuspendLayout()
        Me.Header_Panel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 391)
        Me.Panel1.TabIndex = 0
        '
        'MusicsList_Panel
        '
        Me.MusicsList_Panel.AutoScroll = True
        Me.MusicsList_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MusicsList_Panel.Location = New System.Drawing.Point(1, 10)
        Me.MusicsList_Panel.Name = "MusicsList_Panel"
        Me.MusicsList_Panel.Size = New System.Drawing.Size(299, 391)
        Me.MusicsList_Panel.TabIndex = 1
        '
        'Btn_HidePlayList
        '
        Me.Btn_HidePlayList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_HidePlayList.Image = Global.Music_Player_7.My.Resources.Resources.icons8_fechar_painel_24
        Me.Btn_HidePlayList.Location = New System.Drawing.Point(211, 15)
        Me.Btn_HidePlayList.Name = "Btn_HidePlayList"
        Me.Btn_HidePlayList.Size = New System.Drawing.Size(30, 30)
        Me.Btn_HidePlayList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_HidePlayList.TabIndex = 6
        Me.Btn_HidePlayList.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_HidePlayList, "Enconder Lista de Músicas")
        '
        'Btn_DownloadMusic
        '
        Me.Btn_DownloadMusic.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_DownloadMusic.Image = Global.Music_Player_7.My.Resources.Resources.icons8_instalando_atualizações_24
        Me.Btn_DownloadMusic.Location = New System.Drawing.Point(135, 15)
        Me.Btn_DownloadMusic.Name = "Btn_DownloadMusic"
        Me.Btn_DownloadMusic.Size = New System.Drawing.Size(30, 30)
        Me.Btn_DownloadMusic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_DownloadMusic.TabIndex = 5
        Me.Btn_DownloadMusic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_DownloadMusic, "Baixar Músicas (Abrir Navegador Interno)")
        '
        'Btn_AddMusicOnList
        '
        Me.Btn_AddMusicOnList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_AddMusicOnList.Image = Global.Music_Player_7.My.Resources.Resources.icons8_soma_24
        Me.Btn_AddMusicOnList.Location = New System.Drawing.Point(59, 15)
        Me.Btn_AddMusicOnList.Name = "Btn_AddMusicOnList"
        Me.Btn_AddMusicOnList.Size = New System.Drawing.Size(30, 30)
        Me.Btn_AddMusicOnList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_AddMusicOnList.TabIndex = 3
        Me.Btn_AddMusicOnList.TabStop = False
        Me.ToolTip1.SetToolTip(Me.Btn_AddMusicOnList, "Adicionar Músicas")
        '
        'PlayerControls_Panel
        '
        Me.PlayerControls_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_HidePlayList)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_DownloadMusic)
        Me.PlayerControls_Panel.Controls.Add(Me.Panel4)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_AddMusicOnList)
        Me.PlayerControls_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PlayerControls_Panel.Location = New System.Drawing.Point(0, 401)
        Me.PlayerControls_Panel.Name = "PlayerControls_Panel"
        Me.PlayerControls_Panel.Size = New System.Drawing.Size(300, 60)
        Me.PlayerControls_Panel.TabIndex = 6
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(300, 1)
        Me.Panel4.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 9)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(300, 1)
        Me.Panel3.TabIndex = 5
        '
        'Header_Panel
        '
        Me.Header_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header_Panel.Controls.Add(Me.Panel3)
        Me.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Header_Panel.Name = "Header_Panel"
        Me.Header_Panel.Size = New System.Drawing.Size(300, 10)
        Me.Header_Panel.TabIndex = 7
        Me.Header_Panel.Visible = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Arquivos de Música |*.mp3"
        Me.OpenFileDialog1.Multiselect = True
        Me.OpenFileDialog1.Title = "Procurar Músicas"
        '
        'PlayListControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Controls.Add(Me.MusicsList_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PlayerControls_Panel)
        Me.Controls.Add(Me.Header_Panel)
        Me.Name = "PlayListControl"
        Me.Size = New System.Drawing.Size(300, 461)
        CType(Me.Btn_HidePlayList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_DownloadMusic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_AddMusicOnList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PlayerControls_Panel.ResumeLayout(False)
        Me.Header_Panel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MusicsList_Panel As System.Windows.Forms.Panel
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents PlayerControls_Panel As System.Windows.Forms.Panel
    Friend WithEvents Btn_DownloadMusic As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Btn_AddMusicOnList As System.Windows.Forms.PictureBox
    Friend WithEvents Btn_HidePlayList As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Header_Panel As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
