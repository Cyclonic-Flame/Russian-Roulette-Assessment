Imports System.IO
Public Class CharacterSelect

    Dim Path As String
    Dim ImagePath As String

    Private Sub Filedialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        ImagePath = OpenFileDialog1.FileName
        pbCharacter.Image = Image.FromFile(ImagePath)
        'Exception is thrown if user types unintended file type manually.
    End Sub

    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        'Code checks for both picture and name
        If pbCharacter.Image IsNot Nothing Then
            If rtbName.Text > "" Then

                Me.Hide()
                Game.Show()

            Else

                MsgBox("Please type a name")

            End If

        Else

            MsgBox("Please select an image")

        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Welcome.Show()
    End Sub

    Private Sub btnPicture_Click(sender As Object, e As EventArgs) Handles btnPicture.Click
        'Code allows user to select ONLY image files
        OpenFileDialog1.Title = "Select a picture"
        OpenFileDialog1.Filter = "All Image Files (*.bmp, *.jpg, *.png, *.gif,)|*.bmp; *.jpg; *.png; *.gif;"
        OpenFileDialog1.ShowDialog()
        'User if forced to choose an image file unless file and extension is manually imputed.
    End Sub
End Class