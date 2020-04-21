Public Class MusicItemControl

    Private Sub MusicItemControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
        Me.BackColor = Color.Transparent
    End Sub

    Public Property Music_Title As String
        Get
            Return MusicName_Label.Text
        End Get
        Set(value As String)
            MusicName_Label.Text = value
        End Set
    End Property

    Public Property Music_Artist As String
        Get
            Return ArtistName_Label.Text
        End Get
        Set(value As String)
            ArtistName_Label.Text = value
        End Set
    End Property

    Public Property Music_Album As Image
        Get
            Return AlbumPicture_PictureBox.Image
        End Get
        Set(value As Image)
            AlbumPicture_PictureBox.Image = value
        End Set
    End Property

    Public Property Music_Color As Color
        Get
            Return AlbumPicture_PictureBox.BackColor
        End Get
        Set(value As Color)
            AlbumPicture_PictureBox.BackColor = value
        End Set
    End Property

    Public Property Music_URL As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PlayerForm.PlayerCtrl.URL = Me.Music_URL Then
            Me.Header_Panel.BackColor = Color.DeepSkyBlue
        Else
            Me.Header_Panel.BackColor = Color.Transparent
        End If
    End Sub
End Class
