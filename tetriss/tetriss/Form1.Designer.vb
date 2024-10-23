<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        a = New PictureBox()
        Timer1 = New Timer(components)
        coin_1 = New PictureBox()
        enemy = New PictureBox()
        bullet = New PictureBox()
        ememy4 = New PictureBox()
        bullet_tregetry = New PictureBox()
        time_lable = New Label()
        time = New Timer(components)
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PictureBox6 = New PictureBox()
        Timer2 = New Timer(components)
        coin_2 = New PictureBox()
        PictureBox2 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox8 = New PictureBox()
        water_gun = New PictureBox()
        water = New PictureBox()
        squrt = New PictureBox()
        cannon_ball = New PictureBox()
        PictureBox11 = New PictureBox()
        PictureBox12 = New PictureBox()
        PictureBox13 = New PictureBox()
        PictureBox14 = New PictureBox()
        PictureBox15 = New PictureBox()
        PictureBox16 = New PictureBox()
        score_lable = New Label()
        you_won = New PictureBox()
        health_200 = New Label()
        loosed = New PictureBox()
        CType(a, ComponentModel.ISupportInitialize).BeginInit()
        CType(coin_1, ComponentModel.ISupportInitialize).BeginInit()
        CType(enemy, ComponentModel.ISupportInitialize).BeginInit()
        CType(bullet, ComponentModel.ISupportInitialize).BeginInit()
        CType(ememy4, ComponentModel.ISupportInitialize).BeginInit()
        CType(bullet_tregetry, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(coin_2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(water_gun, ComponentModel.ISupportInitialize).BeginInit()
        CType(water, ComponentModel.ISupportInitialize).BeginInit()
        CType(squrt, ComponentModel.ISupportInitialize).BeginInit()
        CType(cannon_ball, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).BeginInit()
        CType(you_won, ComponentModel.ISupportInitialize).BeginInit()
        CType(loosed, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' a
        ' 
        a.Image = My.Resources.Resources.download__7_
        a.Location = New Point(584, 191)
        a.Name = "a"
        a.Size = New Size(99, 75)
        a.SizeMode = PictureBoxSizeMode.Zoom
        a.TabIndex = 0
        a.TabStop = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' coin_1
        ' 
        coin_1.Image = My.Resources.Resources.download__27_
        coin_1.Location = New Point(1003, 523)
        coin_1.Name = "coin_1"
        coin_1.Size = New Size(50, 45)
        coin_1.SizeMode = PictureBoxSizeMode.Zoom
        coin_1.TabIndex = 1
        coin_1.TabStop = False
        coin_1.Tag = "coin"
        coin_1.Visible = False
        ' 
        ' enemy
        ' 
        enemy.Image = My.Resources.Resources.download__28_1
        enemy.Location = New Point(22, 14)
        enemy.Name = "enemy"
        enemy.Size = New Size(62, 52)
        enemy.SizeMode = PictureBoxSizeMode.Zoom
        enemy.TabIndex = 2
        enemy.TabStop = False
        enemy.Tag = "dead"
        ' 
        ' bullet
        ' 
        bullet.Image = My.Resources.Resources.download__26_
        bullet.Location = New Point(665, 236)
        bullet.Name = "bullet"
        bullet.Size = New Size(80, 30)
        bullet.SizeMode = PictureBoxSizeMode.Zoom
        bullet.TabIndex = 4
        bullet.TabStop = False
        bullet.Tag = "-1"
        ' 
        ' ememy4
        ' 
        ememy4.Image = My.Resources.Resources.download__28_
        ememy4.Location = New Point(22, 536)
        ememy4.Name = "ememy4"
        ememy4.Size = New Size(62, 53)
        ememy4.SizeMode = PictureBoxSizeMode.Zoom
        ememy4.TabIndex = 5
        ememy4.TabStop = False
        ememy4.Tag = "dead"
        ' 
        ' bullet_tregetry
        ' 
        bullet_tregetry.Image = My.Resources.Resources.images__6_
        bullet_tregetry.Location = New Point(639, 272)
        bullet_tregetry.Name = "bullet_tregetry"
        bullet_tregetry.Size = New Size(44, 10)
        bullet_tregetry.SizeMode = PictureBoxSizeMode.StretchImage
        bullet_tregetry.TabIndex = 6
        bullet_tregetry.TabStop = False
        bullet_tregetry.Visible = False
        ' 
        ' time_lable
        ' 
        time_lable.AutoSize = True
        time_lable.ForeColor = SystemColors.ActiveCaptionText
        time_lable.Location = New Point(609, 168)
        time_lable.Name = "time_lable"
        time_lable.Size = New Size(0, 20)
        time_lable.TabIndex = 7
        time_lable.Visible = False
        ' 
        ' time
        ' 
        time.Enabled = True
        time.Interval = 1000
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.download__30_
        PictureBox1.Location = New Point(1079, 236)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(262, 362)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        PictureBox1.Tag = "mario"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.GradientInactiveCaption
        PictureBox3.Location = New Point(-5, 12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(11, 596)
        PictureBox3.TabIndex = 9
        PictureBox3.TabStop = False
        PictureBox3.Tag = "wall"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.GradientInactiveCaption
        PictureBox4.Location = New Point(1330, 12)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(11, 596)
        PictureBox4.TabIndex = 10
        PictureBox4.TabStop = False
        PictureBox4.Tag = "wall"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = SystemColors.GradientInactiveCaption
        PictureBox5.Location = New Point(-5, 598)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(1346, 10)
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        PictureBox5.Tag = "wall"
        ' 
        ' PictureBox6
        ' 
        PictureBox6.BackColor = SystemColors.GradientInactiveCaption
        PictureBox6.Location = New Point(-5, -2)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(1346, 10)
        PictureBox6.TabIndex = 12
        PictureBox6.TabStop = False
        PictureBox6.Tag = "wall"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 10000
        ' 
        ' coin_2
        ' 
        coin_2.Image = My.Resources.Resources.download__31_
        coin_2.Location = New Point(1007, 344)
        coin_2.Name = "coin_2"
        coin_2.Size = New Size(50, 45)
        coin_2.SizeMode = PictureBoxSizeMode.StretchImage
        coin_2.TabIndex = 13
        coin_2.TabStop = False
        coin_2.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.download__32_
        PictureBox2.Location = New Point(1120, -88)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(250, 206)
        PictureBox2.TabIndex = 14
        PictureBox2.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.download__32_1
        PictureBox7.Location = New Point(1108, -2)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(10, 137)
        PictureBox7.TabIndex = 15
        PictureBox7.TabStop = False
        PictureBox7.Tag = "wall"
        PictureBox7.Visible = False
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.download__32_1
        PictureBox8.Location = New Point(1108, 115)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(233, 20)
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        PictureBox8.Tag = "wall"
        PictureBox8.Visible = False
        ' 
        ' water_gun
        ' 
        water_gun.Image = My.Resources.Resources.download__33_
        water_gun.Location = New Point(1235, 168)
        water_gun.Name = "water_gun"
        water_gun.Size = New Size(106, 221)
        water_gun.SizeMode = PictureBoxSizeMode.StretchImage
        water_gun.TabIndex = 19
        water_gun.TabStop = False
        water_gun.Tag = "dead"
        water_gun.Visible = False
        ' 
        ' water
        ' 
        water.Image = My.Resources.Resources.images__9_
        water.Location = New Point(909, 182)
        water.Name = "water"
        water.Size = New Size(73, 346)
        water.SizeMode = PictureBoxSizeMode.StretchImage
        water.TabIndex = 20
        water.TabStop = False
        water.Tag = "dead"
        water.Visible = False
        ' 
        ' squrt
        ' 
        squrt.Image = My.Resources.Resources.download__8_
        squrt.Location = New Point(926, 141)
        squrt.Name = "squrt"
        squrt.Size = New Size(324, 89)
        squrt.SizeMode = PictureBoxSizeMode.StretchImage
        squrt.TabIndex = 21
        squrt.TabStop = False
        squrt.Tag = "dead"
        squrt.Visible = False
        ' 
        ' cannon_ball
        ' 
        cannon_ball.Image = My.Resources.Resources.download__36_
        cannon_ball.Location = New Point(697, 33)
        cannon_ball.Name = "cannon_ball"
        cannon_ball.Size = New Size(99, 85)
        cannon_ball.SizeMode = PictureBoxSizeMode.StretchImage
        cannon_ball.TabIndex = 22
        cannon_ball.TabStop = False
        cannon_ball.Tag = "dead"
        cannon_ball.Visible = False
        ' 
        ' PictureBox11
        ' 
        PictureBox11.Image = My.Resources.Resources.download__36_
        PictureBox11.Location = New Point(856, 33)
        PictureBox11.Name = "PictureBox11"
        PictureBox11.Size = New Size(99, 85)
        PictureBox11.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox11.TabIndex = 23
        PictureBox11.TabStop = False
        PictureBox11.Tag = "dead"
        PictureBox11.Visible = False
        ' 
        ' PictureBox12
        ' 
        PictureBox12.Image = My.Resources.Resources.download__36_
        PictureBox12.Location = New Point(549, 33)
        PictureBox12.Name = "PictureBox12"
        PictureBox12.Size = New Size(99, 85)
        PictureBox12.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox12.TabIndex = 24
        PictureBox12.TabStop = False
        PictureBox12.Tag = "dead"
        PictureBox12.Visible = False
        ' 
        ' PictureBox13
        ' 
        PictureBox13.Image = My.Resources.Resources.download__36_
        PictureBox13.Location = New Point(401, 33)
        PictureBox13.Name = "PictureBox13"
        PictureBox13.Size = New Size(99, 85)
        PictureBox13.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox13.TabIndex = 25
        PictureBox13.TabStop = False
        PictureBox13.Tag = "dead"
        PictureBox13.Visible = False
        ' 
        ' PictureBox14
        ' 
        PictureBox14.Image = My.Resources.Resources.download__36_
        PictureBox14.Location = New Point(254, 33)
        PictureBox14.Name = "PictureBox14"
        PictureBox14.Size = New Size(99, 85)
        PictureBox14.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox14.TabIndex = 26
        PictureBox14.TabStop = False
        PictureBox14.Tag = "dead"
        PictureBox14.Visible = False
        ' 
        ' PictureBox15
        ' 
        PictureBox15.Image = My.Resources.Resources.download__36_
        PictureBox15.Location = New Point(114, 33)
        PictureBox15.Name = "PictureBox15"
        PictureBox15.Size = New Size(99, 85)
        PictureBox15.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox15.TabIndex = 27
        PictureBox15.TabStop = False
        PictureBox15.Tag = "dead"
        PictureBox15.Visible = False
        ' 
        ' PictureBox16
        ' 
        PictureBox16.Image = My.Resources.Resources.download__36_
        PictureBox16.Location = New Point(1003, 33)
        PictureBox16.Name = "PictureBox16"
        PictureBox16.Size = New Size(99, 85)
        PictureBox16.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox16.TabIndex = 28
        PictureBox16.TabStop = False
        PictureBox16.Tag = "dead"
        PictureBox16.Visible = False
        ' 
        ' score_lable
        ' 
        score_lable.AutoSize = True
        score_lable.ForeColor = SystemColors.ActiveCaptionText
        score_lable.Location = New Point(1153, 236)
        score_lable.Name = "score_lable"
        score_lable.Size = New Size(53, 20)
        score_lable.TabIndex = 29
        score_lable.Text = "Label1"
        ' 
        ' you_won
        ' 
        you_won.Image = My.Resources.Resources.images__10_
        you_won.Location = New Point(-5, -11)
        you_won.Name = "you_won"
        you_won.Size = New Size(1346, 600)
        you_won.SizeMode = PictureBoxSizeMode.StretchImage
        you_won.TabIndex = 30
        you_won.TabStop = False
        you_won.Visible = False
        ' 
        ' health_200
        ' 
        health_200.AutoSize = True
        health_200.BackColor = SystemColors.ActiveCaptionText
        health_200.ForeColor = SystemColors.ActiveCaption
        health_200.Location = New Point(1133, 216)
        health_200.Name = "health_200"
        health_200.Size = New Size(84, 20)
        health_200.TabIndex = 31
        health_200.Text = "health -200"
        ' 
        ' loosed
        ' 
        loosed.Image = My.Resources.Resources.maxresdefault
        loosed.Location = New Point(-5, -18)
        loosed.Name = "loosed"
        loosed.Size = New Size(1346, 616)
        loosed.SizeMode = PictureBoxSizeMode.StretchImage
        loosed.TabIndex = 32
        loosed.TabStop = False
        loosed.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        BackColor = SystemColors.ButtonFace
        BackgroundImage = My.Resources.Resources.images__7_
        ClientSize = New Size(1339, 601)
        Controls.Add(loosed)
        Controls.Add(health_200)
        Controls.Add(you_won)
        Controls.Add(score_lable)
        Controls.Add(PictureBox16)
        Controls.Add(PictureBox15)
        Controls.Add(PictureBox14)
        Controls.Add(PictureBox13)
        Controls.Add(PictureBox12)
        Controls.Add(PictureBox11)
        Controls.Add(cannon_ball)
        Controls.Add(squrt)
        Controls.Add(water)
        Controls.Add(water_gun)
        Controls.Add(PictureBox8)
        Controls.Add(PictureBox7)
        Controls.Add(PictureBox2)
        Controls.Add(coin_2)
        Controls.Add(PictureBox6)
        Controls.Add(PictureBox5)
        Controls.Add(PictureBox4)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox1)
        Controls.Add(time_lable)
        Controls.Add(bullet_tregetry)
        Controls.Add(ememy4)
        Controls.Add(bullet)
        Controls.Add(enemy)
        Controls.Add(coin_1)
        Controls.Add(a)
        ForeColor = SystemColors.ControlLightLight
        Name = "Form1"
        Text = " "
        TransparencyKey = Color.Black
        CType(a, ComponentModel.ISupportInitialize).EndInit()
        CType(coin_1, ComponentModel.ISupportInitialize).EndInit()
        CType(enemy, ComponentModel.ISupportInitialize).EndInit()
        CType(bullet, ComponentModel.ISupportInitialize).EndInit()
        CType(ememy4, ComponentModel.ISupportInitialize).EndInit()
        CType(bullet_tregetry, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(coin_2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(water_gun, ComponentModel.ISupportInitialize).EndInit()
        CType(water, ComponentModel.ISupportInitialize).EndInit()
        CType(squrt, ComponentModel.ISupportInitialize).EndInit()
        CType(cannon_ball, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox11, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox12, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox13, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox14, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox15, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox16, ComponentModel.ISupportInitialize).EndInit()
        CType(you_won, ComponentModel.ISupportInitialize).EndInit()
        CType(loosed, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents a As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents coin_1 As PictureBox
    Friend WithEvents enemy As PictureBox
    Friend WithEvents bullet As PictureBox
    Friend WithEvents ememy4 As PictureBox
    Friend WithEvents bullet_tregetry As PictureBox
    Friend WithEvents time_lable As Label
    Friend WithEvents time As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents coin_2 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents water_gun As PictureBox
    Friend WithEvents water As PictureBox
    Friend WithEvents squrt As PictureBox
    Friend WithEvents cannon_ball As PictureBox
    Friend WithEvents PictureBox11 As PictureBox
    Friend WithEvents PictureBox12 As PictureBox
    Friend WithEvents PictureBox13 As PictureBox
    Friend WithEvents PictureBox14 As PictureBox
    Friend WithEvents PictureBox15 As PictureBox
    Friend WithEvents PictureBox16 As PictureBox
    Friend WithEvents score_lable As Label
    Friend WithEvents you_won As PictureBox
    Friend WithEvents health_200 As Label
    Friend WithEvents loosed As PictureBox

End Class
