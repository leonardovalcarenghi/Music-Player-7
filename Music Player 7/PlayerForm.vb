Imports System.Environment
Imports System.IO

Public Class PlayerForm

    Public PAGE_PlayList As New PlayListControl
    Public PAGE_DownloadMusic As New DownloadMusicControl
    Public MUSIC_Tag As New MP3ID3v1

    Public LIST_MusicsOnList As New List(Of String)
    Public LIST_MusicsOnListControl As New List(Of MusicItemControl)

    Dim List_Musics As New List(Of String)
    Private Sub MyBase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arguments As String() = GetCommandLineArgs()

        If arguments.Length > 0 Then
            Dim sb As New System.Text.StringBuilder
            '
            For Each a As String In arguments
                sb.AppendLine(a)
            Next
            '
            '   MessageBox.Show(sb.ToString)
        End If

        SidePanelWithControls_Panel.Width = 0
    End Sub

    Private Sub Btn_ShowPlayList_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_ShowPlayList.MouseClick
        If SidePanelWithControls_Panel.Width = 0 Then
            PAGE_PlayList.Btn_DownloadMusic.Hide()
            SidePanelWithControls_Panel.Controls.Clear()
            SidePanelWithControls_Panel.Controls.Add(PAGE_PlayList)
            SidePanelWithControls_Panel.SendToBack()
            SidePanelWithControls_Panel.Width = 300
            Btn_ShowPlayList.Hide()
        End If
    End Sub
    Private Sub Btn_ShowPlayList_MouseEnter(sender As Object, e As EventArgs) Handles Btn_ShowPlayList.MouseEnter
        Btn_ShowPlayList.BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub Btn_ShowPlayList_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ShowPlayList.MouseLeave
        Btn_ShowPlayList.BackColor = Color.Transparent
    End Sub

    Private Sub PlayerForm_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        If SidePanelWithControls_Panel.Width <> 0 And SidePanelWithControls_Panel.Controls.Contains(PAGE_DownloadMusic) Then
            SidePanelWithControls_Panel.Width = Me.Controls_Panel.Width
        End If
    End Sub


    Private Sub Btn_ModeiPhone_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_ModeiPhone.MouseClick
        ModeIphone.Show()
        Me.Hide()
    End Sub
    Private Sub Btn_ModeiPhone_MouseEnter(sender As Object, e As EventArgs) Handles Btn_ModeiPhone.MouseEnter
        Btn_ModeiPhone.BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub Btn_ModeiPhone_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ModeiPhone.MouseLeave
        Btn_ModeiPhone.BackColor = Color.Transparent
    End Sub




    Public Sub AddMusicOnList(ByVal filemusic As String)
        Dim ItemMusic As New MusicItemControl
        Try

            MUSIC_Tag.Filename = filemusic

            ItemMusic = New MusicItemControl
            Dim F As FileInfo = New FileInfo(filemusic)
            ' MusicName_Label.AutoSize = True

            ItemMusic.Music_Title = MUSIC_Tag.Frame(MP3ID3v1.FrameTypes.Title)
            If ItemMusic.Music_Title = "" Then
                ItemMusic.Music_Title = F.Name.Replace(".mp3", "")
                '    MusicName_Label.AutoSize = False
            End If

            ItemMusic.Music_Artist = MUSIC_Tag.Frame(MP3ID3v1.FrameTypes.Artist)
            ItemMusic.Music_URL = filemusic

            Dim A As New Random
            Dim B As New Random
            Dim C As New Random
            ItemMusic.Music_Color = Color.FromArgb(A.Next(50, 255), B.Next(50, 255), C.Next(50, 255))

            LIST_MusicsOnList.Add(filemusic)
            LIST_MusicsOnListControl.Add(ItemMusic)

        Catch ex As Exception
            ItemMusic.Music_Artist = Nothing
            ItemMusic.Music_Color = Color.Transparent
            ItemMusic.Music_Title = "Error"
            ItemMusic.Music_Artist = "não conseguimos ler este arquivo..."
        End Try

        If ItemMusic.Music_Title <> "" Then _
        PAGE_PlayList.MusicsList_Panel.Controls.Add(ItemMusic)
        ItemMusic.BringToFront()
    End Sub


#Region "Controles do Player"

    Public Sub Player_Play()
        PlayerCtrl.Ctlcontrols.play()

       Player_ShowMusicInformations

        MusicInformations_Panel.Show()
        Title_Panel.Hide()
        Btn_PlayPause.Image = My.Resources.icons8_pausa_circular_48
    End Sub

    Public Sub Player_Pause()
        PlayerCtrl.Ctlcontrols.pause()

        MusicInformations_Panel.Hide()
        Title_Panel.Show()
        Btn_PlayPause.Image = My.Resources.icons8_play_dentro_de_um_círculo_48
    End Sub

    Public Sub Player_NextMusic()
        Dim a As String = LIST_MusicsOnList.IndexOf(PlayerCtrl.URL)
        Try
            PlayerCtrl.URL = LIST_MusicsOnList.Item(a + 1)
        Catch ex As Exception
            PlayerCtrl.URL = LIST_MusicsOnList.Item(0)
        End Try

       Player_ShowMusicInformations
    End Sub

    Public Sub Player_BackMusic()
        Dim a As String = LIST_MusicsOnList.IndexOf(PlayerCtrl.URL)
        Try
            PlayerCtrl.URL = LIST_MusicsOnList.Item(a - 1)
        Catch ex As Exception
            PlayerCtrl.URL = LIST_MusicsOnList.Item(LIST_MusicsOnList.Count - 1)
        End Try

   Player_ShowMusicInformations
    End Sub

    Public Sub Player_ShowMusicInformations()
        Dim F As FileInfo = New FileInfo(PlayerCtrl.URL)
        MusicName_Label.AutoSize = True
        MUSIC_Tag.Filename = PlayerCtrl.URL
        MusicName_Label.Text = MUSIC_Tag.Frame(MP3ID3v1.FrameTypes.Title)
        If MusicName_Label.Text = "" Then
            MusicName_Label.Text = F.Name.Replace(".mp3", "")
            MusicName_Label.AutoSize = False
            MusicName_Label.Width = 400
        End If

        ArtistName_Label.Text = MUSIC_Tag.Frame(MP3ID3v1.FrameTypes.Artist)
    End Sub

#End Region

    Private Sub Btn_PlayPause_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_PlayPause.MouseClick
        If PlayerCtrl.playState = WMPLib.WMPPlayState.wmppsPlaying Then
            Player_Pause()
        Else
            Player_Play()
        End If
    End Sub

    Private Sub Btn_BackMusic_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_BackMusic.MouseClick
        Player_BackMusic()
    End Sub

    Private Sub Btn_NextMusic_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_NextMusic.MouseClick
        Player_NextMusic()
    End Sub
End Class
