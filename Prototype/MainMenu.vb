Public Class MainMenu


    Private Sub BtnFlashcards_Click(sender As Object, e As EventArgs) Handles BtnFlashcards.Click
        FlashcardMenu.Show()
        Me.Hide()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Login.Show()
        Me.Close()
    End Sub

    Private Sub BtnNotes_Click(sender As Object, e As EventArgs) Handles BtnNotes.Click
        NotesMenu.Show()
        Me.Hide()
    End Sub

    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WelcomeUserLbl.Text = Login.username
    End Sub
End Class