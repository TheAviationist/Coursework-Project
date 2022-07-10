Imports System.Data.OleDb
Public Class SignUp
    Private Sub SignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GLOBALS.ConnToDb()
    End Sub

    Private Sub BtnConfirmSignUp_Click(sender As Object, e As EventArgs) Handles BtnConfirmSignUp.Click
        If Username.Text = "" Then
            MessageBox.Show("Username field cannot be empty")
        ElseIf CreatePassword.Text = "" Then
            MessageBox.Show("Create Password field cannot be empty")
        ElseIf RetypePassword.Text = "" Then
            MessageBox.Show("Retype Password field cannot be empty")
        ElseIf CreatePassword.Text.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters")
        ElseIf CreatePassword.Text <> RetypePassword.Text Then
            MessageBox.Show("Entered Passwords must match")
        Else
            GLOBALS.myqry = "SELECT Studentusername FROM Student WHERE Studentusername = '" & Username.Text & "'"
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            If GLOBALS.mydr.HasRows = True Then
                MessageBox.Show("Username already exists, please choose a new one")
            Else
                Try
                    GLOBALS.openConnection()
                    GLOBALS.myqry = "INSERT INTO Student(StudentUsername, Password1)"
                    GLOBALS.myqry = GLOBALS.myqry + " VALUES('" & Username.Text & "', '" & CreatePassword.Text & "')"
                    With GLOBALS.mycmd
                        .CommandText = GLOBALS.myqry
                        .Connection = GLOBALS.conn
                        .ExecuteNonQuery()
                    End With
                    MessageBox.Show("Successful Login, Welcome " & Username.Text & "!")
                Catch ex As Exception
                    MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
                Login.Show()
                Hide()
            End If
        End If
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class