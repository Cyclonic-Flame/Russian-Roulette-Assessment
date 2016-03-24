Public Class Welcome
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Me.Hide()
        CharacterSelect.Show()
    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Dispose()
        Rules.Dispose()
        Game.Dispose()
        Score.Dispose()
    End Sub

    Private Sub btnRules_Click(sender As Object, e As EventArgs) Handles btnRules.Click
        Rules.ShowDialog()
    End Sub

    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click


        Me.Hide()
        Score.Show()
    End Sub
End Class
