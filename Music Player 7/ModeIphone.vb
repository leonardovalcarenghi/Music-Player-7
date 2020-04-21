Public Class ModeIphone

    Public PAGE_PlayListIphone As PlayListControl = PlayerForm.PAGE_PlayList

    Private Sub ModeIphone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SidePanelWithControls_Panel.Width = 0
    End Sub

    Private Sub Btn_ShowPlayList_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_ShowPlayList.MouseClick
        If SidePanelWithControls_Panel.Width = 0 Then
            PAGE_PlayListIphone.Btn_DownloadMusic.Hide()
            SidePanelWithControls_Panel.Controls.Clear()
            SidePanelWithControls_Panel.Controls.Add(PAGE_PlayListIphone)
            SidePanelWithControls_Panel.SendToBack()
            SidePanelWithControls_Panel.Width = IphoneScreen_Panel.Width
        End If
    End Sub
    Private Sub Btn_ShowPlayList_MouseEnter(sender As Object, e As EventArgs) Handles Btn_ShowPlayList.MouseEnter
        Btn_ShowPlayList.BackColor = Color.FromArgb(65, 65, 65)
    End Sub
    Private Sub Btn_ShowPlayList_MouseLeave(sender As Object, e As EventArgs) Handles Btn_ShowPlayList.MouseLeave
        Btn_ShowPlayList.BackColor = Color.Transparent
    End Sub

    Private Sub TimerTime_Tick(sender As Object, e As EventArgs) Handles TimerTime.Tick
        Time_Label.Text = TimeOfDay.ToString("HH:mm")
    End Sub

    Dim LA As New List(Of Integer)
    Private Sub Timer_CrazyBatery_Tick(sender As Object, e As EventArgs) Handles Timer_CrazyBatery.Tick
        Dim r As New Random
        Dim A = r.Next(0, 101)
        If Not LA.Contains(A) Then
            LA.Add(A)
            BateryPorcentage_Label.Text = A & "%"
        End If

        If LA.Count = 100 Then LA.Clear()
    End Sub
    Private Sub Btn_PlayPause_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_PlayPause.MouseClick
        Me.Hide()
        PlayerForm.Show()
    End Sub
End Class