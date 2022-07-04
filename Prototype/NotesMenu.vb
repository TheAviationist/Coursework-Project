Public Class NotesMenu

    Private Sub CreateNoteBtn_Click(sender As Object, e As EventArgs) Handles CreateNoteBtn.Click

    End Sub
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub Diarybtn_Click(sender As Object, e As EventArgs) Handles Diarybtn.Click
        Diary.Show()
        Me.Close()
    End Sub
End Class