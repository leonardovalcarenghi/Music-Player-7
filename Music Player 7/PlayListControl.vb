Public Class PlayListControl

    Private Sub PlayListControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        ' Me.BackColor = Color.Transparent
    End Sub

    Private Sub Btn_AddMusicOnList_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_AddMusicOnList.MouseClick
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            Dim FM As String() = OpenFileDialog1.FileNames
            For Each a As String In FM
                PlayerForm.AddMusicOnList(a)
            Next

            PlayerForm.PlayerCtrl.URL = PlayerForm.LIST_MusicsOnList.Item(0)
            PlayerForm.Player_Play()
        End If
    End Sub
    Private Sub Btn_AddMusicOnList_MouseEnter(sender As Object, e As EventArgs) Handles Btn_AddMusicOnList.MouseEnter
        Btn_AddMusicOnList.BackColor = Color.FromArgb(40, 40, 40)
    End Sub
    Private Sub Btn_AddMusicOnList_MouseLeave(sender As Object, e As EventArgs) Handles Btn_AddMusicOnList.MouseLeave
        Btn_AddMusicOnList.BackColor = Color.Transparent
    End Sub



    Private Sub Btn_DownloadMusic_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_DownloadMusic.MouseClick
        With PlayerForm.SidePanelWithControls_Panel
            .Controls.Clear()
            .Controls.Add(PlayerForm.PAGE_DownloadMusic)
            .BringToFront()
            .Width = PlayerForm.Controls_Panel.Width
        End With
    End Sub
    Private Sub Btn_DownloadMusic_MouseEnter(sender As Object, e As EventArgs) Handles Btn_DownloadMusic.MouseEnter
        Btn_DownloadMusic.BackColor = Color.FromArgb(40, 40, 40)
    End Sub
    Private Sub Btn_DownloadMusic_MouseLeave(sender As Object, e As EventArgs) Handles Btn_DownloadMusic.MouseLeave
        Btn_DownloadMusic.BackColor = Color.Transparent
    End Sub



    Private Sub Btn_HidePlayList_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_HidePlayList.MouseClick
        'Player
        PlayerForm.SidePanelWithControls_Panel.Width = 0
        PlayerForm.Btn_ShowPlayList.Show()

        'iPhone
        ModeIphone.SidePanelWithControls_Panel.Width = 0
    End Sub
    Private Sub Btn_HidePlayList_MouseEnter(sender As Object, e As EventArgs) Handles Btn_HidePlayList.MouseEnter
        Btn_HidePlayList.BackColor = Color.FromArgb(40, 40, 40)
    End Sub
    Private Sub Btn_HidePlayList_MouseLeave(sender As Object, e As EventArgs) Handles Btn_HidePlayList.MouseLeave
        Btn_HidePlayList.BackColor = Color.Transparent
    End Sub
End Class
