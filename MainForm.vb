Public Class MainForm
    Public Shared te_code As Boolean
    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        說明.Visible = False
        挑戰.Visible = False
        作答.Visible = False
        Dim te As DateTime = DateTime.Now
        Dim d As DateTime = New DateTime(2014, 9, 21)
        Dim b As DateTime = New DateTime(2014, 7, 21)
        Dim yn As Integer
        If te > d Then
            yn = MsgBox("已經過了作答期限,您是否要繼續考驗自己的智商?", 36, "IQ180大挑戰 活動已過期")
            If yn = 6 Then
                te_code = True
                作答.Enabled = False
            Else
                End
            End If
        ElseIf te < b Then
            yn = MsgBox("活動尚未開始，您在此時不能看題目! 否則會影響其他人的作答公平權! 在7月21日後才能開啟", 64, "IQ180大挑戰 活動尚未開始")
            End
        End If
    End Sub

    Private Sub 密碼確定_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 密碼確定.Click
        If 輸入密碼.Text = "ekids1764" Then
            說明.Visible = True
            挑戰.Visible = True
            作答.Visible = True
            輸入密碼.Visible = False
            密碼確定.Visible = False
        Else
            MsgBox("密碼錯誤!! 如果您還不知道密碼，請向製作單位領取。", 16, "警告")
            輸入密碼.Text = ""
        End If
    End Sub

    Private Sub 說明_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 說明.Click
        Dim hfrom As New HELPForm
        hfrom.ShowDialog()
    End Sub

    Private Sub 挑戰_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 挑戰.Click
        Dim qfrom As New QForm
        qfrom.ShowDialog()
    End Sub

    Private Sub 作答_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 作答.Click
        Dim afrom As New ANSAForm
        afrom.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        End
    End Sub
End Class
