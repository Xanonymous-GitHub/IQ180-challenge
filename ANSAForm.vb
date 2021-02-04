Public Class ANSAForm
    Dim xs As Boolean = False
    Public Shared ans_s As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans_1 As String, ans_2 As String
        If xs = True Then
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox11.Text = "" Then
                MsgBox("輸入不完全,有空缺項!", 16, "注意")
            Else
                ans_1 = ans1(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text, TextBox11.Text)
                ANSAForm.ans_s = ans_1
                ans.ShowDialog()
            End If
        Else
            If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
                MsgBox("輸入不完全,有空缺項!", 16, "注意")
            Else
                ans_2 = ans2(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text, TextBox10.Text)
                ANSAForm.ans_s = ans_2
                ans.ShowDialog()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox11.Visible = True
            Label12.Visible = True
            xs = True
        Else
            TextBox11.Visible = False
            Label12.Visible = False
            xs = False
        End If
    End Sub

    Private Sub ANSAForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox11.Visible = False
        Label12.Visible = False
    End Sub
    Function ans1(ByVal a1 As String, ByVal a2 As String, ByVal a3 As String, ByVal a4 As String, ByVal a5 As String, ByVal a6 As String, ByVal a7 As String, ByVal a8 As String, ByVal a9 As String, ByVal a10 As String, ByVal a11 As String)
        Dim ans As String = ""
        ans &= IIf(a1 = "貝多芬", "r3x4", "i7q3")
        ans &= IIf(a2 = "愛因斯坦", "o7z9", "g3i1")
        ans &= IIf(a3 = "玫瑰", "e9d8", "d5j6")
        ans &= IIf(a4 = "上", "q1s5", "l7g4")
        ans &= IIf(a5 = "三", "p7q3", "n5c2")
        ans &= IIf(a6 = "2925", "a8q6", "d7l9")
        ans &= IIf(a7 = "c", "c2k9", "m7o8")
        ans &= IIf(a8 = "無", "h9w9", "r9n9")
        ans &= IIf(a9 = "卡", "y6b4", "d4f8")
        ans &= IIf(a10 = "interesting", "x8f4", "u2z1")
        ans &= IIf(a11 = "電腦", "h9t6", "g8t8")
        ans1 = ans
    End Function
    Function ans2(ByVal a1 As String, ByVal a2 As String, ByVal a3 As String, ByVal a4 As String, ByVal a5 As String, ByVal a6 As String, ByVal a7 As String, ByVal a8 As String, ByVal a9 As String, ByVal a10 As String)
        Dim ans As String = ""
        ans &= IIf(a1 = "貝多芬", "r3x4", "i7q3")
        ans &= IIf(a2 = "愛因斯坦", "o7z9", "g3i1")
        ans &= IIf(a3 = "玫瑰", "e9d8", "d5j6")
        ans &= IIf(a4 = "上", "q1s5", "l7g4")
        ans &= IIf(a5 = "三", "p7q3", "n5c2")
        ans &= IIf(a6 = "2925", "a8q6", "d7l9")
        ans &= IIf(a7 = "c", "c2k9", "m7o8")
        ans &= IIf(a8 = "無", "h9w9", "r9n9")
        ans &= IIf(a9 = "卡", "y6b4", "d4f8")
        ans &= IIf(a10 = "interesting", "x8f4", "u2z1")
        ans &= "8h8h"
        ans2 = ans
    End Function
End Class