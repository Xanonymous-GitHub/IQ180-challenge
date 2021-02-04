Public Class QForm
    Public Shared s As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim q As New q
        QForm.s = 1
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim q As New q
        QForm.s = 2
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim q As New q
        QForm.s = 3
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim q As New q
        QForm.s = 4
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim q As New q
        QForm.s = 5
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim q As New q
        QForm.s = 6
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim q As New q
        QForm.s = 7
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim q As New q
        QForm.s = 8
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim q As New q
        QForm.s = 9
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim q As New q
        QForm.s = 10
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim q As New q
        QForm.s = 11
        Me.Hide()
        q.Owner = Me
        q.ShowDialog()
    End Sub
    Private Sub QForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim anscode As Boolean = MainForm.te_code
        If anscode = True Then
            Button13.Enabled = True
        End If
    End Sub
    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        AF.ShowDialog()
    End Sub
End Class