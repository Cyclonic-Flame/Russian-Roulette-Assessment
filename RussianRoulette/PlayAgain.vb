Public Class PlayAgain
    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Hide()
        ClearScore()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Hide()
        Game.Hide()
        Welcome.Show()
        ClearScore()
    End Sub

    'Code clears score as to prevent unfair totals
    Public Sub ClearScore()
        Gun.Score = 0
    End Sub

End Class