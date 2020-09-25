Public Class Form3
    'Shows total time in both stages
    'If time is greater or equal to 100 - Display you lose, try again
    'If time is under 100 seconds - Display you win
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalTime.Text = Form2.TotalTime.Text
        If Val(TotalTime.Text) >= 100 Then
            WinLose.Text = "YOU LOSE, TRY GETTING UNDER 100 SECONDS"
            WinLose.ForeColor = Color.Red
        End If
    End Sub
    'Button closes all forms
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Close()
        Form2.Close()
        Me.Close()
    End Sub
End Class