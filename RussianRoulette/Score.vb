Imports System.IO
Imports System.Environment
Public Class Score
    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim path As String
        Dim Line As String
        Dim Score() As String
        Dim rowcount As Integer = 0
        Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)

        path = (appData & "/Score.txt")

        Try
            Dim fileread As StreamReader
            fileread = New StreamReader(path)
            Do Until fileread.EndOfStream
                Line = fileread.ReadLine
                Score = Line.Split(",")
                dgvScore.Rows.Add()
                dgvScore.Rows(rowcount).Cells(0).Value = Score(0)
                dgvScore.Rows(rowcount).Cells(1).Value = Score(1)
                dgvScore.Rows(rowcount).Cells(2).Value = Score(2)
                rowcount = rowcount + 1

            Loop
            fileread.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub btnHighestShot_Click(sender As Object, e As EventArgs) Handles btnHighestShot.Click

        dgvScore.Sort(dgvScore.Columns(1),
        System.ComponentModel.ListSortDirection.Descending)

    End Sub

    Private Sub btnLowestShot_Click(sender As Object, e As EventArgs) Handles btnLowestShot.Click

        dgvScore.Sort(dgvScore.Columns(1),
        System.ComponentModel.ListSortDirection.Ascending)

    End Sub

    Private Sub btnName_Click(sender As Object, e As EventArgs) Handles btnName.Click

        dgvScore.Sort(dgvScore.Columns(0),
        System.ComponentModel.ListSortDirection.Ascending)

    End Sub

End Class