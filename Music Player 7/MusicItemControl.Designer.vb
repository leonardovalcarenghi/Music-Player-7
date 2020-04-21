<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MusicItemControl
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
        Me.Header_Panel = New System.Windows.Forms.Panel()
        Me.AlbumPicture_PictureBox = New System.Windows.Forms.PictureBox()
        Me.ArtistName_Label = New System.Windows.Forms.Label()
        Me.MusicName_Label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Header_Panel.SuspendLayout()
        CType(Me.AlbumPicture_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Header_Panel
        '
        Me.Header_Panel.Controls.Add(Me.AlbumPicture_PictureBox)
        Me.Header_Panel.Controls.Add(Me.ArtistName_Label)
        Me.Header_Panel.Controls.Add(Me.MusicName_Label)
        Me.Header_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Header_Panel.Location = New System.Drawing.Point(0, 0)
        Me.Header_Panel.Name = "Header_Panel"
        Me.Header_Panel.Size = New System.Drawing.Size(299, 50)
        Me.Header_Panel.TabIndex = 7
        '
        'AlbumPicture_PictureBox
        '
        Me.AlbumPicture_PictureBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.AlbumPicture_PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.AlbumPicture_PictureBox.Image = Global.Music_Player_7.My.Resources.Resources.icons8_notas_musicais_32
        Me.AlbumPicture_PictureBox.Location = New System.Drawing.Point(10, 7)
        Me.AlbumPicture_PictureBox.Name = "AlbumPicture_PictureBox"
        Me.AlbumPicture_PictureBox.Size = New System.Drawing.Size(36, 36)
        Me.AlbumPicture_PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.AlbumPicture_PictureBox.TabIndex = 8
        Me.AlbumPicture_PictureBox.TabStop = False
        '
        'ArtistName_Label
        '
        Me.ArtistName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ArtistName_Label.AutoSize = True
        Me.ArtistName_Label.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArtistName_Label.Location = New System.Drawing.Point(50, 27)
        Me.ArtistName_Label.Name = "ArtistName_Label"
        Me.ArtistName_Label.Size = New System.Drawing.Size(33, 15)
        Me.ArtistName_Label.TabIndex = 7
        Me.ArtistName_Label.Text = "artist"
        '
        'MusicName_Label
        '
        Me.MusicName_Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MusicName_Label.AutoSize = True
        Me.MusicName_Label.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MusicName_Label.Location = New System.Drawing.Point(49, 8)
        Me.MusicName_Label.Name = "MusicName_Label"
        Me.MusicName_Label.Size = New System.Drawing.Size(47, 19)
        Me.MusicName_Label.TabIndex = 6
        Me.MusicName_Label.Text = "Music"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MusicItemControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.Controls.Add(Me.Header_Panel)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "MusicItemControl"
        Me.Size = New System.Drawing.Size(299, 50)
        Me.Header_Panel.ResumeLayout(False)
        Me.Header_Panel.PerformLayout()
        CType(Me.AlbumPicture_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Header_Panel As System.Windows.Forms.Panel
    Friend WithEvents AlbumPicture_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents ArtistName_Label As System.Windows.Forms.Label
    Friend WithEvents MusicName_Label As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
