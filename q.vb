Public Class q
    Dim qw As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        qw = 0
        Me.Close()
    End Sub
    Private Sub q_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        qw = QForm.s
        Label1.ForeColor = Color.Black
        Button2.Enabled = True
        RichTextBox1.Font = New Font("標楷體", 22)
        Select Case qw
            Case 1
                Label1.Text = "第1題,等級[C]"
                Label1.BackColor = Color.SpringGreen
                Button2.Enabled = False
                RichTextBox1.Text = "神童、失去、不敗、悲。(答為一人)"
            Case 2
                Label1.Text = "第2題,等級[C]"
                Label1.BackColor = Color.SpringGreen
                Button2.Enabled = False
                RichTextBox1.Text = "密碼、殘忍、當下為藝人。(答為一人)"
            Case 3
                Label1.Text = "第3題,等級[C]"
                Label1.BackColor = Color.SpringGreen
                Button2.Enabled = False
                RichTextBox1.Text = "狼牙狠,鮮紅的血液,愛與恨的化身,又迷人又痛恨,為何呢?(答為一花名)"
            Case 4
                Label1.Text = "第4題,等級[C]"
                Label1.BackColor = Color.SpringGreen
                RichTextBox1.Text = "解下列字元程式:             <2FT2F2FT2F2F3T2FT2F5T>"
            Case 5
                Label1.Text = "第5題,等級[B]"
                Label1.BackColor = Color.Gold
                RichTextBox1.Text = "ffffffffffffffffffff          tttttttttttttttttttt          fffffaaaaaaaaaafffff      tttttttttttttttttttt          abababababababababab   tttttttttttttttttttt          fafabbbbaaaaaaaaaabc    "
            Case 6
                Label1.Text = "第6題,等級[B]"
                Label1.BackColor = Color.Gold
                RichTextBox1.Text = "若B+A=無解,且●+B=143,求   (●-B)×25=?"
            Case 7
                Label1.Text = "第7題,等級[B]"
                Label1.BackColor = Color.Gold
                RichTextBox1.Text = "媽正準備要開使準備晚餐,她問小明:晚餐想吃什麼?小明說:      我吃瓜瓜蟲!要稀淡,裡多汁!   如果媽是個怕蟲怕得要死的人,那麼請問,小明晚餐吃了什麼?    [A:瓜瓜蟲,B:西瓜,C:南瓜仔,D:發芽馬鈴薯]"
            Case 8
                Label1.Text = "第8題,等級[A]"
                Label1.BackColor = Color.DarkGoldenrod
                RichTextBox1.Text = "decefegegepppppcspchytrgh     umumumumumumbrellahvreiri     rrrrrrrmrrrrrrrrrrrrrrrrr     hymtrlbyvgpeopleirsuiorio     lllllllllllleujhjhodjihgf     esesesesesesesesesnesnsea     ccccccccccccecccccccccccc     eoeoooooooeoeoeoeoeoeooeo     moonmountaintatantfidfigi     hooihpoofjhorjiofjhtrljjh     uinouuuiihhhooouiunhtyruy     sjhtjhehelejnsdhnwhihgild     biibiibiibiibiibiilovebii     reubvyioertniowerytieoerr     ei5ouvnoiertyeruto;erituo     ioerutnirutioeruf6jdj68dd"
            Case 9
                Label1.Text = "第9題,等級[A]"
                Label1.BackColor = Color.DarkGoldenrod
                RichTextBox1.Text = "解下列字元int雙方程式:       <2[3(2FT2F)2F2TF5T]>"
            Case 10
                Label1.Text = "第10題,等級[S]"
                Label1.BackColor = Color.DarkViolet
                RichTextBox1.Font = New Font("標楷體", 18)
                RichTextBox1.Text = "[57139311574]                         0(-2%1%2%2%3%2%5%2%6%2%7%1%8%2%10%2%)                         e(4%1%13%1%16%1%)                         試請還原""[]""中的數字,使它成為1個英文單字。"
            Case 11
                Label1.Text = "進階題,等級[X]"
                Label1.ForeColor = Color.Red
                Label1.BackColor = Color.Black
                RichTextBox1.Text = "上帝的雨,地上的皿。金和肉放在同一邊,直接表示的是對面的缺。第一名的光彩背叛你,數字將不存在。來吧!三把火匹配著三把鎖!找出那堆字母!找到那三把火光!試問:以上所形容之物之母親為?"
        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        qw = QForm.s
        If Button2.Text = "提示" Then
            Button2.Text = "題目"
            Select Case qw
                Case 1
                    Label1.Text = "第1題,等級[C]"
                    RichTextBox1.Text = ""
                Case 2
                    Label1.Text = "第2題,等級[C]"
                    RichTextBox1.Text = ""
                Case 3
                    Label1.Text = "第3題,等級[C]"
                    RichTextBox1.Text = ""
                Case 4
                    Label1.Text = "第4題,等級[C]"
                    RichTextBox1.Text = "解法:先把式子拆開,數字後的字要增加為數字的量,例:""2T""會拆成""TT"",""3T""會拆成""TTT"",而前面無數字的字就照寫一遍。畫一個5×5的方格,把拆開的字串由左往右填入表格,填好後,把F都擦掉,把T都塗色塗滿,答案就出現了..."
                Case 5
                    Label1.Text = "第5題,等級[B]"
                    RichTextBox1.Text = "畫一個20*5的方格,把字串由左往右填入表格,(a和b和c不用理它)填好後,把F都擦掉,把T都塗色塗滿,答案就出現了..."
                Case 6
                    Label1.Text = "第6題,等級[B]"
                    RichTextBox1.Text = "提示:答為一數字,且不會是無解,把""B""切一半,答案就出來"
                Case 7
                    Label1.Text = "第7題,等級[B]"
                    RichTextBox1.Text = "把小明說的那兩句話互相結合,答案便接曉!(注意!答案只能填入abcd的小寫)"
                Case 8
                    Label1.Text = "第8題,等級[A]"
                    RichTextBox1.Text = "從中找出以下英文單字:""紫色""""雨傘""""人""""山""""我們(受格)""""在...裡面""""在...上面""""他"",可以直橫斜,有些單字有兩個。"
                Case 9
                    Label1.Text = "第9題,等級[A]"
                    RichTextBox1.Text = "解法之前有講,本題只多做補充,int就是""轉向組合""。有算式   n(ab);設n等於2,則應分解成""abab"",不是""2a2b"""
                Case 10
                    Label1.Text = "第10題,等級[S]"
                    RichTextBox1.Text = "將""0""和""e""中的""那兩串字""依序以以下方式放入""[]""中:從""()""中的左邊第1個字開始往後算起,每4個字是1組(""%""也算),而這4字中(假設為""X%Y%""),X代表位置,Y代表數量。所以呢,就像這樣放:""在第X位數後,有Y個0(或e)"",(當然是放在""[57139311574]""中),但要注意,是先從0那串開始放,且當你放到""e""那串時,要將已放入的""0""的位置也算進去。以上做完後,應該會出現一條由數字和""e""所組成的亂碼,此時請依照已下方法翻譯:從左邊開始過目,只要看到有以下之結果就立刻轉換並將轉換過的字畫掉。A=""01"",B=""10""C=""02"",D=""20""...以此類推,但到""S""時,會變成""e001"",T=""e010"",U=""e100"",V=""e002""...以此類推,這裡做完後,答案便揭曉。"
                Case 11
                    Label1.Text = "進階題,等級[X]"
                    RichTextBox1.Text = "一個A級下載，臍帶"
            End Select
        Else
            Button2.Text = "提示"
            Select Case qw
                Case 1
                    Label1.Text = "第1題,等級[C]"
                    RichTextBox1.Text = "神童、失去、不敗、悲。(答為一人)"
                Case 2
                    Label1.Text = "第2題,等級[C]"
                    RichTextBox1.Text = "密碼、殘忍、當下為藝人。(答為一人)"
                Case 3
                    Label1.Text = "第3題,等級[C]"
                    RichTextBox1.Text = "狼牙狠,鮮紅的血液,愛與恨的化身,又迷人又痛恨,為何呢?(答為一花名)"
                Case 4
                    Label1.Text = "第4題,等級[C]"
                    RichTextBox1.Text = "解下列字元程式:             <2FT2F2FT2F2F3T2FT2F5T>"
                Case 5
                    Label1.Text = "第5題,等級[B]"
                    RichTextBox1.Text = "ffffffffffffffffffff          tttttttttttttttttttt          fffffaaaaaaaaaafffff      tttttttttttttttttttt          abababababababababab   tttttttttttttttttttt          fafabbbbaaaaaaaaaabc    "
                Case 6
                    Label1.Text = "第6題,等級[B]"
                    RichTextBox1.Text = "若B+A=無解,且●+B=143,求   (●-B)×25=?"
                Case 7
                    Label1.Text = "第7題,等級[B]"
                    RichTextBox1.Text = "媽正準備要開使準備晚餐,她問小明:晚餐想吃什麼?小明說:      我吃瓜瓜蟲!要稀淡,裡多汁!   如果媽是個怕蟲怕得要死的人,那麼請問,小明晚餐吃了什麼?    [A:瓜瓜蟲,B:西瓜,C:南瓜仔,D:發芽馬鈴薯]"
                Case 8
                    Label1.Text = "第8題,等級[A]"
                    RichTextBox1.Text = "decefegegepppppcspchytrgh     umumumumumumbrellahvreiri     rrrrrrrmrrrrrrrrrrrrrrrrr     hymtrlbyvgpeopleirsuiorio     lllllllllllleujhjhodjihgf     esesesesesesesesesnesnsea     ccccccccccccecccccccccccc     eoeoooooooeoeoeoeoeoeooeo     moonmountaintatantfidfigi     hooihpoofjhorjiofjhtrljjh     uinouuuiihhhooouiunhtyruy     sjhtjhehelejnsdhnwhihgild     biibiibiibiibiibiilovebii     reubvyioertniowerytieoerr     ei5ouvnoiertyeruto;erituo     ioerutnirutioeruf6jdj68dd"
                Case 9
                    Label1.Text = "第9題,等級[A]"
                    RichTextBox1.Text = "解下列字元int雙方程式:       <2[3(2FT2F)2F2TF5T]>"
                Case 10
                    Label1.Text = "第10題,等級[S]"
                    RichTextBox1.Text = "[57139311574]                         0(-2%1%2%2%3%2%5%2%6%2%7%1%8%2%10%2%)                         e(4%1%13%1%16%1%)                         試請還原""[]""中的數字,使它成為1個英文單字。"
                Case 11
                    Label1.Text = "進階題,等級[X]"
                    RichTextBox1.Text = "上帝的雨,地上的皿。金和肉放在同一邊,直接表示的是對面的缺。第一名的光彩背叛你,數字將不存在。來吧!三把火匹配著三把鎖!找出那堆字母!找到那三把火光!試問:以上所形容之物之母親為?"
            End Select
        End If
    End Sub
End Class