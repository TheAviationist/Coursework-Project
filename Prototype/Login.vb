Imports System.Data.OleDb
Public Class Login
    Public Shared username As String
    'upon loading of login screen:
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GLOBALS.ConnToDb()
    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Form1.Show()
        Me.Hide()
    End Sub
    Private Sub BtnSignUp_Click(sender As Object, e As EventArgs) Handles BtnSignUp.Click
        SignUp.Show()
        Me.Hide()
    End Sub
    'when pressing confirm login button
    'then needs to repeatedly check database comparing both textbox values to one user, if both username and password match then continue to main menu
    Private Sub btnConfirmLogin_Click(sender As Object, e As EventArgs) Handles btnConfirmLogin.Click
        username = TxtUsername.Text
        If TxtUsername.Text = "" Then
            MessageBox.Show("Username field cannot be empty")
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("Password field cannot be empty")
        ElseIf TxtPassword.Text.Length < 8 Then
            MessageBox.Show("Password must be at least 8 characters")
        Else
            Try
                GLOBALS.openConnection()
                GLOBALS.myqry = "SELECT StudentID, Studentusername FROM Student WHERE StudentUsername = '" & TxtUsername.Text & "' AND Password1 = '" & TxtPassword.Text & "'"
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
                If GLOBALS.mydr.HasRows = True Then
                    'MessageBox.Show("Successful Login, Welcome " & TxtUsername.Text & "!")
                    While GLOBALS.mydr.Read()
                        GVariables.StudentID = Int32.Parse(GLOBALS.mydr("StudentID").ToString)
                    End While
                    MainMenu.Show()
                    Me.Close()
                Else
                    MsgBox("Incorrect Username or password")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class