Public Class Game

    Dim MyGun As New Gun

    'Most code runs from the Gun Class
    Private Sub btnLoadBullet_Click(sender As Object, e As EventArgs) Handles btnLoadBullet.Click
        MyGun.LoadGun()
        btnLoadBullet.Enabled = False
        btnSpinChamber.Enabled = True

    End Sub

    Private Sub btnSpinChamber_Click(sender As Object, e As EventArgs) Handles btnSpinChamber.Click
        MyGun.SpinChamber()
        btnSpinChamber.Enabled = False
        btnSelfShot.Enabled = True
        btnAwayShot.Enabled = True

    End Sub

    Private Sub btnAwayShot_Click(sender As Object, e As EventArgs) Handles btnAwayShot.Click
        MyGun.ShootAway()
        MyGun.CheckShotCount()

    End Sub

    Private Sub btnSelfShot_Click(sender As Object, e As EventArgs) Handles btnSelfShot.Click
        MyGun.ShootGun()
        MyGun.CheckShotCount()

    End Sub

    Private Sub Game_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This code sets the picture and disables buttons to prevent premature
        'death/ cheating.
        pbCharacter.Image = CharacterSelect.pbCharacter.Image
        btnSpinChamber.Enabled = False
        btnSelfShot.Enabled = False
        btnAwayShot.Enabled = False
    End Sub

End Class