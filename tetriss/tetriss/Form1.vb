Imports System.Diagnostics.CodeAnalysis

Public Class Form1
    Dim movements As New Dictionary(Of String, Collection)
    Dim tracks As New Dictionary(Of String, Integer)

    Dim score As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        move(bullet, 30, 0)
        pace(bullet, bullet_tregetry, 150)

        follow(ememy4, a, 8, 8)
        score_lable.Text = score
    End Sub
    Sub pace(e As PictureBox, p As PictureBox, speed As Integer)
        Dim dir As Integer
        dir = e.Tag
        If e.Location.X > p.Location.X Then
            e.Location += New Point(-speed * dir, 0)
            dir = -dir
        Else
            e.Location += New Point(speed * dir, 0)
        End If
    End Sub

    Sub follow(e As PictureBox, a As PictureBox, xspeed As Integer, yspeed As Integer)
        If e.Location.Y < a.Location.Y Then
            move(e, 0, yspeed)
        Else
            move(e, 0, -yspeed)
        End If

        If e.Location.X < a.Location.X Then
            move(e, xspeed, 0)
        Else
            move(e, -xspeed, 0)
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(a, 30, 0)
            move(bullet_tregetry, 30, 0)
        End If
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(a, -30, 0)
            move(bullet_tregetry, -30, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(a, 0, 30)
            move(bullet_tregetry, 0, 30)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(a, 0, -30)
            move(bullet_tregetry, 0, -30)
        End If
        If e.KeyCode = Keys.Space Then
            bullet.Location = bullet_tregetry.Location
        End If
        a.Refresh()
        If a.Bounds.IntersectsWith(coin_1.Bounds) Then
            coin_1.Visible = False
        End If
    End Sub

    Private Sub time_Tick(sender As Object, e As EventArgs) Handles time.Tick
        score += 1
        If score < -200 Then
            you_won.Visible = True
            health_200.Visible = False
        End If
        time_lable.Text = score
    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)


        If IntersectsWith(p, "wall") Then
            p.Location -= New Point(xdir, ydir)
        End If
        If IntersectsWith(p, "mario") Then
            score -= 1
        End If
        If IntersectsWith(a, "dead") Then
            loosed.Visible = True
        End If

        If Not movements.ContainsKey(p.Name) Then
            movements.Add(p.Name, New Collection)
        End If
        movements(p.Name).Add(p.Location)


    End Sub
    Function IntersectsWith(p As PictureBox, tag As String) As Boolean
        For Each o In Controls
            Dim obj As PictureBox
            obj = TryCast(o, PictureBox)
            If Not obj Is Nothing Then
                If p.Bounds.IntersectsWith(obj.Bounds) And UCase(obj.Tag) = UCase(tag) Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        water_gun.Visible = True
        water.Visible = True
        squrt.Visible = True
        cannon_ball.Visible = True
        PictureBox11.Visible = True
        PictureBox12.Visible = True
        PictureBox13.Visible = True
        PictureBox14.Visible = True
        PictureBox15.Visible = True
        PictureBox16.Visible = True

    End Sub
    Sub Track(e As PictureBox, a As PictureBox)
        If Not tracks.ContainsKey(e.Name & a.Name) Then
            tracks.Add(e.Name & a.Name, 1)
        End If
        Dim idx As Integer
        idx = tracks(e.Name & a.Name)
        If movements.ContainsKey(a.Name) AndAlso idx < movements(a.Name).Count Then
            e.Location = movements(a.Name).Item(idx)
            tracks(e.Name & a.Name) = idx + 1
        End If
    End Sub

    Private Sub you_won_Click(sender As Object, e As EventArgs) Handles you_won.Click

    End Sub
End Class
