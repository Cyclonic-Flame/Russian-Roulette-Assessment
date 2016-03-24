Imports System.IO
Imports System.Environment
Public Class Gun
    Public Chamber As Integer
    Public RanCham As New Random
    Public Chance As Integer = 0
    'Public Shared Code to allow for access from PlayAgain.vb
    Public Shared Score As Integer = 0
    Public Away As Integer
    Public AwayII As Integer
    Public AwayChance As Integer
    Public Path As String
    Public Win As String

    'Load Gun
    Public Sub LoadGun()
        PlayLoadGun()
        Chamber = 1
    End Sub

    'Spin Chamber
    Public Sub SpinChamber()
        PlaySpinChamber()
        Chamber = RanCham.Next(4)
    End Sub

    'Shoot Gun
    Public Sub ShootGun()
        If Chance = Chamber Then
            PlayBullet()
            MsgBox("You lost")
            Win = "Loss"
            ResetGame()

        Else
            PlayEmptyChamber()
            Chance += 1
            Score = Score + 1

            CheckShotCount()

        End If
    End Sub

    'Shooting away from player

    Public Sub ShootAway()

        If Away = Chamber Then
            PlayBullet()
            MsgBox("You Win")
            Win = "Win"
            ResetGame()
        Else
            PlayEmptyChamber()
            AwayChance += 1
            Away += 1
            Chance += 1
            Score = Score + 1
            CheckShotCount()

        End If

        If AwayChance > 1 Then

            Chamber = Chance
            Game.btnAwayShot.Enabled = False
            CheckShotCount()

        End If

        'Counter for Away shots taken
        If AwayChance = 1 Then
            Game.pbChance1.Image = RussianRoulette.My.Resources.Resources.Cross

        ElseIf AwayChance = 2
            Game.pbChance2.Image = RussianRoulette.My.Resources.Resources.Cross

        End If
    End Sub

    Public Sub CheckShotCount()
        'This code shows a viusal representation of trigger pulls
        If Chance = 1 Then
            Game.pbBullet1.Image = Nothing

        ElseIf Chance = 2 Then
            Game.pbBullet2.Image = Nothing

        ElseIf Chance = 3 Then
            Game.pbBullet3.Image = Nothing

        ElseIf Chance = 4 Then
            Game.pbBullet4.Image = Nothing

        ElseIf Chance = 5 Then
            Game.pbBullet5.Image = Nothing

        ElseIf Chance = 6 Then
            Game.pbBullet6.Image = Nothing
        End If


    End Sub

    Public Sub ResetGame()
        'Clears game for next round
        Game.btnAwayShot.Enabled = False
        Game.btnSelfShot.Enabled = False
        Game.btnLoadBullet.Enabled = True
        AwayChance = 0
        Chance = 0
        ResetImages()
        SaveScore()
        PlayAgain.ShowDialog()

    End Sub

    'Resets images

    Public Sub ResetImages()
        Game.pbBullet1.Image = RussianRoulette.My.Resources.Resources.Bullet
        Game.pbBullet2.Image = RussianRoulette.My.Resources.Resources.Bullet
        Game.pbBullet3.Image = RussianRoulette.My.Resources.Resources.Bullet
        Game.pbBullet4.Image = RussianRoulette.My.Resources.Resources.Bullet
        Game.pbBullet5.Image = RussianRoulette.My.Resources.Resources.Bullet
        Game.pbBullet6.Image = RussianRoulette.My.Resources.Resources.Bullet
        Game.pbChance1.Image = Nothing
        Game.pbChance2.Image = Nothing

    End Sub

    'Code saves score for reading on Score.vb
    Sub SaveScore()
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
        Path = (appData & "/Score.txt")
        Try
            Dim FileSave As StreamWriter
            FileSave = File.AppendText(Path)
            FileSave.WriteLine(CharacterSelect.rtbName.Text & " , " & Score &
            " , " & Win)

            FileSave.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'This section of code plays all the game sounds
    Sub PlayLoadGun()
        My.Computer.Audio.Play(RussianRoulette.My.Resources.
        Gunreloadsoundeffect, AudioPlayMode.Background)
    End Sub

    Sub PlaySpinChamber()
        My.Computer.Audio.Play(RussianRoulette.My.Resources.
        RevolverChamberSpinSoundEffect, AudioPlayMode.
        Background)
    End Sub

    Sub PlayEmptyChamber()
        My.Computer.Audio.Play(RussianRoulette.My.Resources.
        Emptygunsoundeffect, AudioPlayMode.Background)
    End Sub

    Sub PlayBullet()
        My.Computer.Audio.Play(RussianRoulette.My.Resources.
        M9pistolsoundeffect, AudioPlayMode.Background)
    End Sub


End Class
