Imports System.Data.OleDb
Public Class Diary

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        'Warning msgbox will double check if the user wants to go back out of diary without saving.
        Dim result As DialogResult
        result = MessageBox.Show("Are you sure you want to close your diary? " & Environment.NewLine & "Any unsaved changes will be lost.", "Close diary", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            NotesMenu.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Diary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GLOBALS.openConnection()
        Dim diarycontents As String = "New Note"
        GLOBALS.ConnToDb()
        GLOBALS.myqry = "SELECT Diary FROM Student WHERE StudentUsername = '" & Login.username & "'"
        GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
        GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
        While GLOBALS.mydr.Read()
            diarycontents = (GLOBALS.mydr("Diary")).ToString
            DiaryTxt.Text = diarycontents
        End While
    End Sub
    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        'this try catch loop converts the text input into a string fixing errors involving apostrophes.
        Try
            GLOBALS.openConnection()
            GLOBALS.mycmd.CommandText = "UPDATE student SET Diary = ? WHERE studentusername = ?"
            GLOBALS.mycmd.Parameters.Add("Diary", OleDbType.LongVarChar, 512)
            GLOBALS.mycmd.Parameters.Add("studentusername", OleDbType.VarChar, 64)
            GLOBALS.mycmd.Parameters(0).Value = DiaryTxt.Text
            GLOBALS.mycmd.Parameters(1).Value = Login.username

            GLOBALS.mycmd.Prepare()
            GLOBALS.mycmd.ExecuteNonQuery()
            MessageBox.Show("Diary is edited")
            'XFSDSD
            'GLOBALS.myqry = "UPDATE student SET Diary = '" & DiaryTxt.Text & "' WHERE studentusername = '" & Login.username & "'"
            'MessageBox.Show("Diary Edited Successfully")
            'With GLOBALS.mycmd
            '.CommandText = GLOBALS.myqry
            '.Connection = GLOBALS.conn
            '.ExecuteNonQuery()
            'End With
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class