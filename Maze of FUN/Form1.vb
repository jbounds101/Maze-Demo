Public Class Form1
    Dim N As Integer
    Private Sub GetNumber()
        N = Math.Ceiling(Rnd() * 4)
    End Sub
    'Sets all walls to a random color upon form load
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
        GetNumber()
        If N = 1 Then
            c1.BackColor = Drawing.Color.Lime
            c2.BackColor = Drawing.Color.Lime
            c3.BackColor = Drawing.Color.Lime
            c4.BackColor = Drawing.Color.Lime
            c5.BackColor = Drawing.Color.Lime
            c6.BackColor = Drawing.Color.Lime
            c7.BackColor = Drawing.Color.Lime
            c8.BackColor = Drawing.Color.Lime
            c9.BackColor = Drawing.Color.Lime
            c10.BackColor = Drawing.Color.Lime
            c11.BackColor = Drawing.Color.Lime
            c12.BackColor = Drawing.Color.Lime
            c13.BackColor = Drawing.Color.Lime
            c14.BackColor = Drawing.Color.Lime
            c15.BackColor = Drawing.Color.Lime
            c16.BackColor = Drawing.Color.Lime
            c17.BackColor = Drawing.Color.Lime
            c18.BackColor = Drawing.Color.Lime
            c19.BackColor = Drawing.Color.Lime
            c20.BackColor = Drawing.Color.Lime
            c21.BackColor = Drawing.Color.Lime
            c22.BackColor = Drawing.Color.Lime
            c23.BackColor = Drawing.Color.Lime
            c24.BackColor = Drawing.Color.Lime
            c25.BackColor = Drawing.Color.Lime
            Color.Text = "Green"

        ElseIf N = 2 Then
            c1.BackColor = Drawing.Color.Purple
            c2.BackColor = Drawing.Color.Purple
            c3.BackColor = Drawing.Color.Purple
            c4.BackColor = Drawing.Color.Purple
            c5.BackColor = Drawing.Color.Purple
            c6.BackColor = Drawing.Color.Purple
            c7.BackColor = Drawing.Color.Purple
            c8.BackColor = Drawing.Color.Purple
            c9.BackColor = Drawing.Color.Purple
            c10.BackColor = Drawing.Color.Purple
            c11.BackColor = Drawing.Color.Purple
            c12.BackColor = Drawing.Color.Purple
            c13.BackColor = Drawing.Color.Purple
            c14.BackColor = Drawing.Color.Purple
            c15.BackColor = Drawing.Color.Purple
            c16.BackColor = Drawing.Color.Purple
            c17.BackColor = Drawing.Color.Purple
            c18.BackColor = Drawing.Color.Purple
            c19.BackColor = Drawing.Color.Purple
            c20.BackColor = Drawing.Color.Purple
            c21.BackColor = Drawing.Color.Purple
            c22.BackColor = Drawing.Color.Purple
            c23.BackColor = Drawing.Color.Purple
            c24.BackColor = Drawing.Color.Purple
            c25.BackColor = Drawing.Color.Purple
            Color.Text = "Purple"
        ElseIf N = 3 Then
            c1.BackColor = Drawing.Color.Blue
            c2.BackColor = Drawing.Color.Blue
            c3.BackColor = Drawing.Color.Blue
            c4.BackColor = Drawing.Color.Blue
            c5.BackColor = Drawing.Color.Blue
            c6.BackColor = Drawing.Color.Blue
            c7.BackColor = Drawing.Color.Blue
            c8.BackColor = Drawing.Color.Blue
            c9.BackColor = Drawing.Color.Blue
            c10.BackColor = Drawing.Color.Blue
            c11.BackColor = Drawing.Color.Blue
            c12.BackColor = Drawing.Color.Blue
            c13.BackColor = Drawing.Color.Blue
            c14.BackColor = Drawing.Color.Blue
            c15.BackColor = Drawing.Color.Blue
            c16.BackColor = Drawing.Color.Blue
            c17.BackColor = Drawing.Color.Blue
            c18.BackColor = Drawing.Color.Blue
            c19.BackColor = Drawing.Color.Blue
            c20.BackColor = Drawing.Color.Blue
            c21.BackColor = Drawing.Color.Blue
            c22.BackColor = Drawing.Color.Blue
            c23.BackColor = Drawing.Color.Blue
            c24.BackColor = Drawing.Color.Blue
            c25.BackColor = Drawing.Color.Blue
            Color.Text = "Blue"
        ElseIf N = 4 Then
            c1.BackColor = Drawing.Color.Orange
            c2.BackColor = Drawing.Color.Orange
            c3.BackColor = Drawing.Color.Orange
            c4.BackColor = Drawing.Color.Orange
            c5.BackColor = Drawing.Color.Orange
            c6.BackColor = Drawing.Color.Orange
            c7.BackColor = Drawing.Color.Orange
            c8.BackColor = Drawing.Color.Orange
            c9.BackColor = Drawing.Color.Orange
            c10.BackColor = Drawing.Color.Orange
            c11.BackColor = Drawing.Color.Orange
            c12.BackColor = Drawing.Color.Orange
            c13.BackColor = Drawing.Color.Orange
            c14.BackColor = Drawing.Color.Orange
            c15.BackColor = Drawing.Color.Orange
            c16.BackColor = Drawing.Color.Orange
            c17.BackColor = Drawing.Color.Orange
            c18.BackColor = Drawing.Color.Orange
            c19.BackColor = Drawing.Color.Orange
            c20.BackColor = Drawing.Color.Orange
            c21.BackColor = Drawing.Color.Orange
            c22.BackColor = Drawing.Color.Orange
            c23.BackColor = Drawing.Color.Orange
            c24.BackColor = Drawing.Color.Orange
            c25.BackColor = Drawing.Color.Orange
            Color.Text = "Orange"
        End If
    End Sub
    'Enables timer when WASD is pressed
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Timer1.Enabled = True
        If e.KeyCode = Keys.W Or
             e.KeyCode = Keys.A Or
                 e.KeyCode = Keys.S Or
                     e.KeyCode = Keys.D Then
        End If

        'Moves the "player"
        If e.KeyCode = Keys.W Then
            lblMove.Top -= 3

        ElseIf e.KeyCode = Keys.D Then
            lblMove.Left += 3

        ElseIf e.KeyCode = Keys.S Then
            lblMove.Top += 3

        ElseIf e.KeyCode = Keys.A Then
            lblMove.Left -= 3
        End If

        If lblMove.Bounds.IntersectsWith(c1.Bounds) Or
            lblMove.Bounds.IntersectsWith(c2.Bounds) Or
            lblMove.Bounds.IntersectsWith(c3.Bounds) Or
            lblMove.Bounds.IntersectsWith(c4.Bounds) Or
            lblMove.Bounds.IntersectsWith(c5.Bounds) Or
            lblMove.Bounds.IntersectsWith(c6.Bounds) Or
            lblMove.Bounds.IntersectsWith(c7.Bounds) Or
            lblMove.Bounds.IntersectsWith(c8.Bounds) Or
            lblMove.Bounds.IntersectsWith(c9.Bounds) Or
            lblMove.Bounds.IntersectsWith(c10.Bounds) Or
            lblMove.Bounds.IntersectsWith(c11.Bounds) Or
            lblMove.Bounds.IntersectsWith(c12.Bounds) Or
            lblMove.Bounds.IntersectsWith(c13.Bounds) Or
            lblMove.Bounds.IntersectsWith(c14.Bounds) Or
            lblMove.Bounds.IntersectsWith(c15.Bounds) Or
            lblMove.Bounds.IntersectsWith(c16.Bounds) Or
            lblMove.Bounds.IntersectsWith(c17.Bounds) Or
            lblMove.Bounds.IntersectsWith(c18.Bounds) Or
            lblMove.Bounds.IntersectsWith(c19.Bounds) Or
            lblMove.Bounds.IntersectsWith(c20.Bounds) Or
            lblMove.Bounds.IntersectsWith(c21.Bounds) Or
            lblMove.Bounds.IntersectsWith(c22.Bounds) Or
            lblMove.Bounds.IntersectsWith(c23.Bounds) Or
            lblMove.Bounds.IntersectsWith(c24.Bounds) Or
            lblMove.Bounds.IntersectsWith(c25.Bounds) Then
            'Resets the "player" to the box
            lblMove.Left = 71
            lblMove.Top = 156
        End If

        'Moves the player to the next stage when reaching the red winning box
        If lblMove.Bounds.IntersectsWith(w1.Bounds) Then

            Me.Hide()
            Form2.Show()

        End If
    End Sub
    'Timer +1 every second
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TotalTime.Text = Val(TotalTime.Text) + 1

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If N = 1 Then
            c1.BackColor = Drawing.Color.Lime
            c2.BackColor = Drawing.Color.Lime
            c3.BackColor = Drawing.Color.Lime
            c4.BackColor = Drawing.Color.Lime
            c5.BackColor = Drawing.Color.Lime
            c6.BackColor = Drawing.Color.Lime
            c7.BackColor = Drawing.Color.Lime
            c8.BackColor = Drawing.Color.Lime
            c9.BackColor = Drawing.Color.Lime
            c10.BackColor = Drawing.Color.Lime
            c11.BackColor = Drawing.Color.Lime
            c12.BackColor = Drawing.Color.Lime
            c13.BackColor = Drawing.Color.Lime
            c14.BackColor = Drawing.Color.Lime
            c15.BackColor = Drawing.Color.Lime
            c16.BackColor = Drawing.Color.Lime
            c17.BackColor = Drawing.Color.Lime
            c18.BackColor = Drawing.Color.Lime
            c19.BackColor = Drawing.Color.Lime
            c20.BackColor = Drawing.Color.Lime
            c21.BackColor = Drawing.Color.Lime
            c22.BackColor = Drawing.Color.Lime
            c23.BackColor = Drawing.Color.Lime
            c24.BackColor = Drawing.Color.Lime
            c25.BackColor = Drawing.Color.Lime
            Color.Text = "Green"

        ElseIf N = 2 Then
            c1.BackColor = Drawing.Color.Purple
            c2.BackColor = Drawing.Color.Purple
            c3.BackColor = Drawing.Color.Purple
            c4.BackColor = Drawing.Color.Purple
            c5.BackColor = Drawing.Color.Purple
            c6.BackColor = Drawing.Color.Purple
            c7.BackColor = Drawing.Color.Purple
            c8.BackColor = Drawing.Color.Purple
            c9.BackColor = Drawing.Color.Purple
            c10.BackColor = Drawing.Color.Purple
            c11.BackColor = Drawing.Color.Purple
            c12.BackColor = Drawing.Color.Purple
            c13.BackColor = Drawing.Color.Purple
            c14.BackColor = Drawing.Color.Purple
            c15.BackColor = Drawing.Color.Purple
            c16.BackColor = Drawing.Color.Purple
            c17.BackColor = Drawing.Color.Purple
            c18.BackColor = Drawing.Color.Purple
            c19.BackColor = Drawing.Color.Purple
            c20.BackColor = Drawing.Color.Purple
            c21.BackColor = Drawing.Color.Purple
            c22.BackColor = Drawing.Color.Purple
            c23.BackColor = Drawing.Color.Purple
            c24.BackColor = Drawing.Color.Purple
            c25.BackColor = Drawing.Color.Purple
            Color.Text = "Purple"
        ElseIf N = 3 Then
            c1.BackColor = Drawing.Color.Blue
            c2.BackColor = Drawing.Color.Blue
            c3.BackColor = Drawing.Color.Blue
            c4.BackColor = Drawing.Color.Blue
            c5.BackColor = Drawing.Color.Blue
            c6.BackColor = Drawing.Color.Blue
            c7.BackColor = Drawing.Color.Blue
            c8.BackColor = Drawing.Color.Blue
            c9.BackColor = Drawing.Color.Blue
            c10.BackColor = Drawing.Color.Blue
            c11.BackColor = Drawing.Color.Blue
            c12.BackColor = Drawing.Color.Blue
            c13.BackColor = Drawing.Color.Blue
            c14.BackColor = Drawing.Color.Blue
            c15.BackColor = Drawing.Color.Blue
            c16.BackColor = Drawing.Color.Blue
            c17.BackColor = Drawing.Color.Blue
            c18.BackColor = Drawing.Color.Blue
            c19.BackColor = Drawing.Color.Blue
            c20.BackColor = Drawing.Color.Blue
            c21.BackColor = Drawing.Color.Blue
            c22.BackColor = Drawing.Color.Blue
            c23.BackColor = Drawing.Color.Blue
            c24.BackColor = Drawing.Color.Blue
            c25.BackColor = Drawing.Color.Blue
            Color.Text = "Blue"
        ElseIf N = 4 Then
            c1.BackColor = Drawing.Color.Orange
            c2.BackColor = Drawing.Color.Orange
            c3.BackColor = Drawing.Color.Orange
            c4.BackColor = Drawing.Color.Orange
            c5.BackColor = Drawing.Color.Orange
            c6.BackColor = Drawing.Color.Orange
            c7.BackColor = Drawing.Color.Orange
            c8.BackColor = Drawing.Color.Orange
            c9.BackColor = Drawing.Color.Orange
            c10.BackColor = Drawing.Color.Orange
            c11.BackColor = Drawing.Color.Orange
            c12.BackColor = Drawing.Color.Orange
            c13.BackColor = Drawing.Color.Orange
            c14.BackColor = Drawing.Color.Orange
            c15.BackColor = Drawing.Color.Orange
            c16.BackColor = Drawing.Color.Orange
            c17.BackColor = Drawing.Color.Orange
            c18.BackColor = Drawing.Color.Orange
            c19.BackColor = Drawing.Color.Orange
            c20.BackColor = Drawing.Color.Orange
            c21.BackColor = Drawing.Color.Orange
            c22.BackColor = Drawing.Color.Orange
            c23.BackColor = Drawing.Color.Orange
            c24.BackColor = Drawing.Color.Orange
            c25.BackColor = Drawing.Color.Orange
            Color.Text = "Orange"
        End If
    End Sub
End Class
