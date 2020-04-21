Public Class DownloadMusicControl

    Private Sub DownloadMusicControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill

        Search_TextBox.Select() : Search_TextBox.Focus()
    End Sub


    Private Sub Btn_HidePlayList_MouseClick(sender As Object, e As MouseEventArgs) Handles Btn_HidePlayList.MouseClick
        PlayerForm.SidePanelWithControls_Panel.Width = 0
        PlayerForm.Btn_ShowPlayList.Show()
    End Sub
    Private Sub Btn_HidePlayList_MouseEnter(sender As Object, e As EventArgs) Handles Btn_HidePlayList.MouseEnter
        Btn_HidePlayList.BackColor = Color.FromArgb(40, 40, 40)
    End Sub
    Private Sub Btn_HidePlayList_MouseLeave(sender As Object, e As EventArgs) Handles Btn_HidePlayList.MouseLeave
        Btn_HidePlayList.BackColor = Color.Transparent
    End Sub

    Private Sub Search_TextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles Search_TextBox.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            WebBrowser1.Document.GetElementById("search_query").SetAttribute("value", Search_TextBox.Text)
            WebBrowser1.Document.GetElementById("search-btn").InvokeMember("click")
            WebBrowser1.Show()
        End If
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        If WebBrowser1.Url.ToString.Contains("https://www.youtube.com/results") Then
            ' Dim Link As String = WebBrowser1.Document.GetElementById("video-title").InnerText

            'yt-uix-tile-link yt-ui-ellipsis yt-ui-ellipsis-2 yt-uix-sessionlink spf-link 
            ' WebBrowser1.Document.GetElementsByTagName("")

            '      MsgBox(Link)



            Dim theElementCollection As HtmlElementCollection = Nothing
            theElementCollection = WebBrowser1.Document.GetElementsByTagName("a")
            For Each curElement As HtmlElement In theElementCollection
                'If curElement.GetAttribute("classname").ToString = "example"  It doesn't work.  
                ' This should be the work around.
                If InStr(curElement.GetAttribute("yt-uix-tile-link yt-ui-ellipsis yt-ui-ellipsis-2 yt-uix-sessionlink spf-link ").ToString, "closeWindow") Then
                    ' Doesn't even fire.
                    ' InvokeMember(test) after class is found.
                    'MessageBox.Show(curElement.GetAttribute("InnerText"))
                    curElement.InvokeMember("Click")
                    curElement.InvokeMember("MouseDown")
                    curElement.InvokeMember("MouseUp")
                    curElement.RaiseEvent("OnClick")
                    curElement.Focus()
                End If
            Next

        End If
    End Sub
End Class
