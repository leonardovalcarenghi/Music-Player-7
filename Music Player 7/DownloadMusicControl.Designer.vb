<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DownloadMusicControl
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Header_Panel = New System.Windows.Forms.Panel()
        Me.Search_TextBox = New System.Windows.Forms.TextBox()
        Me.MusicName_Label = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PlayerControls_Panel = New System.Windows.Forms.Panel()
        Me.Btn_HidePlayList = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ArtistName_Label = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.Header_Panel.SuspendLayout()
        Me.PlayerControls_Panel.SuspendLayout()
        CType(Me.Btn_HidePlayList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.WebBrowser1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(855, 416)
        Me.Panel2.TabIndex = 2
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.IsWebBrowserContextMenuEnabled = False
        Me.WebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.ScriptErrorsSuppressed = True
        Me.WebBrowser1.Size = New System.Drawing.Size(855, 416)
        Me.WebBrowser1.TabIndex = 10
        Me.WebBrowser1.Url = New System.Uri("https://www.youtube.com/", System.UriKind.Absolute)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 486)
        Me.Panel1.TabIndex = 3
        '
        'Header_Panel
        '
        Me.Header_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Header_Panel.Controls.Add(Me.Search_TextBox)
        Me.Header_Panel.Controls.Add(Me.MusicName_Label)
        Me.Header_Panel.Controls.Add(Me.Panel3)
        Me.Header_Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Header_Panel.Location = New System.Drawing.Point(1, 0)
        Me.Header_Panel.Name = "Header_Panel"
        Me.Header_Panel.Size = New System.Drawing.Size(855, 70)
        Me.Header_Panel.TabIndex = 8
        '
        'Search_TextBox
        '
        Me.Search_TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.Search_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Search_TextBox.Font = New System.Drawing.Font("Segoe UI Semilight", 10.0!)
        Me.Search_TextBox.ForeColor = System.Drawing.Color.White
        Me.Search_TextBox.Location = New System.Drawing.Point(14, 33)
        Me.Search_TextBox.Name = "Search_TextBox"
        Me.Search_TextBox.Size = New System.Drawing.Size(272, 25)
        Me.Search_TextBox.TabIndex = 8
        '
        'MusicName_Label
        '
        Me.MusicName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MusicName_Label.AutoSize = True
        Me.MusicName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicName_Label.Location = New System.Drawing.Point(10, 10)
        Me.MusicName_Label.Name = "MusicName_Label"
        Me.MusicName_Label.Size = New System.Drawing.Size(200, 19)
        Me.MusicName_Label.TabIndex = 7
        Me.MusicName_Label.Text = "Qual música você quer baixar?"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 69)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(855, 1)
        Me.Panel3.TabIndex = 5
        '
        'PlayerControls_Panel
        '
        Me.PlayerControls_Panel.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.PlayerControls_Panel.Controls.Add(Me.ArtistName_Label)
        Me.PlayerControls_Panel.Controls.Add(Me.Btn_HidePlayList)
        Me.PlayerControls_Panel.Controls.Add(Me.Panel4)
        Me.PlayerControls_Panel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PlayerControls_Panel.Location = New System.Drawing.Point(0, 486)
        Me.PlayerControls_Panel.Name = "PlayerControls_Panel"
        Me.PlayerControls_Panel.Size = New System.Drawing.Size(856, 60)
        Me.PlayerControls_Panel.TabIndex = 10
        '
        'Btn_HidePlayList
        '
        Me.Btn_HidePlayList.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Btn_HidePlayList.Image = Global.Music_Player_7.My.Resources.Resources.icons8_fechar_painel_24
        Me.Btn_HidePlayList.Location = New System.Drawing.Point(413, 15)
        Me.Btn_HidePlayList.Name = "Btn_HidePlayList"
        Me.Btn_HidePlayList.Size = New System.Drawing.Size(30, 30)
        Me.Btn_HidePlayList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Btn_HidePlayList.TabIndex = 6
        Me.Btn_HidePlayList.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(856, 1)
        Me.Panel4.TabIndex = 4
        '
        'ArtistName_Label
        '
        Me.ArtistName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ArtistName_Label.AutoSize = True
        Me.ArtistName_Label.Enabled = False
        Me.ArtistName_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistName_Label.Location = New System.Drawing.Point(12, 24)
        Me.ArtistName_Label.Name = "ArtistName_Label"
        Me.ArtistName_Label.Size = New System.Drawing.Size(106, 13)
        Me.ArtistName_Label.TabIndex = 9
        Me.ArtistName_Label.Text = "Powered by YouTube"
        '
        'DownloadMusicControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Header_Panel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PlayerControls_Panel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "DownloadMusicControl"
        Me.Size = New System.Drawing.Size(856, 546)
        Me.Panel2.ResumeLayout(False)
        Me.Header_Panel.ResumeLayout(False)
        Me.Header_Panel.PerformLayout()
        Me.PlayerControls_Panel.ResumeLayout(False)
        Me.PlayerControls_Panel.PerformLayout()
        CType(Me.Btn_HidePlayList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Header_Panel As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Search_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents MusicName_Label As System.Windows.Forms.Label
    Friend WithEvents PlayerControls_Panel As System.Windows.Forms.Panel
    Friend WithEvents Btn_HidePlayList As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents ArtistName_Label As System.Windows.Forms.Label

End Class
