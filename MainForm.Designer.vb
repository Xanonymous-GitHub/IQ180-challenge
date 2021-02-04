<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.說明 = New System.Windows.Forms.Button()
        Me.挑戰 = New System.Windows.Forms.Button()
        Me.作答 = New System.Windows.Forms.Button()
        Me.輸入密碼 = New System.Windows.Forms.TextBox()
        Me.密碼確定 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        '說明
        '
        Me.說明.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.說明.Location = New System.Drawing.Point(12, 237)
        Me.說明.Name = "說明"
        Me.說明.Size = New System.Drawing.Size(150, 70)
        Me.說明.TabIndex = 0
        Me.說明.Text = "說明"
        Me.說明.UseVisualStyleBackColor = True
        '
        '挑戰
        '
        Me.挑戰.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.挑戰.Location = New System.Drawing.Point(168, 237)
        Me.挑戰.Name = "挑戰"
        Me.挑戰.Size = New System.Drawing.Size(150, 70)
        Me.挑戰.TabIndex = 1
        Me.挑戰.Text = "挑戰"
        Me.挑戰.UseVisualStyleBackColor = True
        '
        '作答
        '
        Me.作答.Font = New System.Drawing.Font("微軟正黑體", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.作答.Location = New System.Drawing.Point(324, 237)
        Me.作答.Name = "作答"
        Me.作答.Size = New System.Drawing.Size(150, 70)
        Me.作答.TabIndex = 2
        Me.作答.Text = "作答"
        Me.作答.UseVisualStyleBackColor = True
        '
        '輸入密碼
        '
        Me.輸入密碼.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.輸入密碼.Location = New System.Drawing.Point(33, 209)
        Me.輸入密碼.Name = "輸入密碼"
        Me.輸入密碼.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.輸入密碼.Size = New System.Drawing.Size(415, 23)
        Me.輸入密碼.TabIndex = 3
        Me.輸入密碼.UseSystemPasswordChar = True
        Me.輸入密碼.WordWrap = False
        '
        '密碼確定
        '
        Me.密碼確定.Font = New System.Drawing.Font("微軟正黑體", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.密碼確定.Location = New System.Drawing.Point(135, 266)
        Me.密碼確定.Name = "密碼確定"
        Me.密碼確定.Size = New System.Drawing.Size(206, 35)
        Me.密碼確定.TabIndex = 4
        Me.密碼確定.Text = "確定"
        Me.密碼確定.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("微軟正黑體", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(451, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 41)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "×"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(494, 368)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.密碼確定)
        Me.Controls.Add(Me.輸入密碼)
        Me.Controls.Add(Me.作答)
        Me.Controls.Add(Me.挑戰)
        Me.Controls.Add(Me.說明)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IQ180大挑戰"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents 說明 As System.Windows.Forms.Button
    Friend WithEvents 挑戰 As System.Windows.Forms.Button
    Friend WithEvents 作答 As System.Windows.Forms.Button
    Friend WithEvents 輸入密碼 As System.Windows.Forms.TextBox
    Friend WithEvents 密碼確定 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
