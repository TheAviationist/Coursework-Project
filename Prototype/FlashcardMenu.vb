Imports System.Data.OleDb

Public Class FlashcardMenu
    'two global variables are relevant for this page: CurrentSetName and CurrentSetID
    Private Sub flipBtn_Click(sender As Object, e As EventArgs) Handles flipBtn.Click
        'Change the text to the other side of the card
        If FrontBack.Text = "back" Then
            FrontBack.Text = "front"
        ElseIf FrontBack.Text = "front" Then
            FrontBack.Text = "back"
        End If
        If FrontBack.Text = "back" Then
            Try
                GLOBALS.openConnection()
                Dim flashcardcontents As String = "back flashcard contents"
                GLOBALS.ConnToDb()
                GLOBALS.myqry = "SELECT back FROM flashcard WHERE setID = " & GVariables.CurrentSetID
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
                While GLOBALS.mydr.Read()
                    flashcardcontents = (GLOBALS.mydr("back")).ToString
                    flashCardWindow.Text = flashcardcontents
                End While
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message)
            End Try
        ElseIf FrontBack.Text = "front" Then
            Try
                GLOBALS.openConnection()
                Dim flashcardcontents As String = "front flashcard contents"
                GLOBALS.ConnToDb()
                GLOBALS.myqry = "SELECT front FROM flashcard WHERE setID = " & GVariables.CurrentSetID
                GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
                GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
                While GLOBALS.mydr.Read()
                    flashcardcontents = (GLOBALS.mydr("front")).ToString
                    flashCardWindow.Text = flashcardcontents
                End While
            Catch ex As Exception
                MessageBox.Show("Error" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub FlashcardMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load flashcard sets
        'Populate the flash card set box with flashcard sets
        Try
            GLOBALS.openConnection()
            GLOBALS.myqry = "SELECT SetName FROM Flashcard_Set WHERE StudentID = " & GVariables.studentID
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read()
                SetListbox.Items.Add(GLOBALS.mydr("SetName").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
        'populate the front flashcard
        Try
            GLOBALS.openConnection()
            Dim flashcardcontents As String = "front flashcard contents"
            GLOBALS.ConnToDb()
            GLOBALS.myqry = "SELECT Front FROM Flashcard WHERE SetID = " & GVariables.CurrentSetID
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read()
                flashcardcontents = (GLOBALS.mydr("front")).ToString
                flashCardWindow.Text = flashcardcontents
            End While
        Catch ex As exception
            MessageBox.Show("Error" & ex.Message)
        End Try
        Try
            GLOBALS.openConnection()
            Dim flashcardcontents As String = "back flashcard contents"
            GLOBALS.ConnToDb()
            'does flashcard database name have to be case senstive? not sure dont think so
            GLOBALS.myqry = "SELECT Back FROM Flashcard WHERE SetID = " & GVariables.CurrentSetID
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read()
                flashcardcontents = (GLOBALS.mydr("back")).ToString
                flashCardWindow.Text = flashcardcontents
            End While
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub

    Private Sub SetListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SetListbox.SelectedIndexChanged

        'Grabs the name of the currently selected set
        GVariables.CurrentSetName = SetListbox.GetItemText(SetListbox.SelectedItem)
        Try
            'Open a connection
            GLOBALS.openConnection()
            'Setup a query for grabbing the ID of the set equal to the selected set name
            GLOBALS.mycmd.CommandText = "SELECT SetID FROM Flashcard_Set WHERE SetName = ?"
            GLOBALS.mycmd.Parameters.Add("SetName", OleDbType.VarChar, 64)
            GLOBALS.mycmd.Parameters(0).Value = GVariables.CurrentSetName
            GLOBALS.mycmd.Prepare()
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader()
            'Grab the ID if it exists
            While GLOBALS.mydr.Read()
                'Set current set ID
                GVariables.CurrentSetID = Convert.ToInt32(GLOBALS.mydr("SetID"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Dim selectedFlashCards()() As String

        Try
            'Open a connection
            GLOBALS.openConnection()
            Dim command As New OleDbCommand
            command.Connection = GLOBALS.conn
            command.CommandText = "SELECT Front, Back FROM Flashcard WHERE SetID = ?"
            command.Parameters.Add("setID", OleDbType.Integer, 8)
            command.Parameters(0).Value = GVariables.CurrentSetID
            command.Prepare()

            Dim reader As OleDbDataReader = command.ExecuteReader()

            If reader.HasRows <> True Then
                Dim frontCard As String = InputBox("Enter a front of the card:", "Create Flashcard", "1")
                Dim backCard As String = InputBox("Enter a back of the card: ", "Create Flashcard", "1")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        'If not less than 0 go back in array 
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        'If not last card go to next one
    End Sub

    Private Sub addCardBtn_Click(sender As Object, e As EventArgs) Handles addCardBtn.Click
        'Show popup with text box to add new card with front and back
        Try
            GLOBALS.openConnection()
            GLOBALS.myqry = "INSERT INTO Flashcard(front, back, SetID)"
            GLOBALS.myqry = GLOBALS.myqry + " VALUES('" & "Add a question here" & "', '" & "Add an answer here" & "', " & GVariables.CurrentSetID & ")"
            With GLOBALS.mycmd
                .CommandText = GLOBALS.myqry
                .Connection = GLOBALS.conn
                .ExecuteNonQuery()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub addSetBtn_Click(sender As Object, e As EventArgs) Handles addSetBtn.Click
        Dim SetName As String
        'Show popup with text box to add new set
        SetName = InputBox("enter the name Of your New Set: ")
        Try
            GLOBALS.openConnection()
            GLOBALS.myqry = "INSERT INTO Flashcard_Set(StudentID, SetName) VALUES(" & GVariables.StudentID & ", '" & SetName & "')"
            'MessageBox.Show(GLOBALS.myqry)
            'GLOBALS.myqry = GLOBALS.myqry + " VALUES('" & Username.Text & "', '" & CreatePassword.Text & "')"
            With GLOBALS.mycmd
                .CommandText = GLOBALS.myqry
                .Connection = GLOBALS.conn
                .ExecuteNonQuery()
            End With
            'MessageBox.Show("A new set has been created called: " & SetName)
            flashCardWindow.Text = "Add a question here..."
            SetListbox.Items.Add(SetName)
        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DeleteSetBtn_Click(sender As Object, e As EventArgs) Handles DeleteSetBtn.Click
        'CODE FOR DELETING A SET FROM THE DATABASE:
        GLOBALS.myqry = "DELETE From Flashcard_Set WHERE SetName = '" & SetListbox.GetItemText(SetListbox.SelectedItem) & "'"
        SetListbox.Items.Remove(SetListbox.SelectedItem)
        'MessageBox.Show(GLOBALS.myqry)
        Try
            GLOBALS.openConnection()
            With GLOBALS.mycmd
                .CommandText = GLOBALS.myqry
                .Connection = GLOBALS.conn
                .ExecuteNonQuery()
            End With
            MessageBox.Show("Card removed")
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        If FrontBack.Text = "back" Then
            Try
                GLOBALS.openConnection()
                GLOBALS.myqry = "UPDATE flashcard SET back = '" & flashCardWindow.Text & "' WHERE SETID = " & GVariables.CurrentSetID
                MessageBox.Show("back flashcard Edited Successfully")
                With GLOBALS.mycmd
                    .CommandText = GLOBALS.myqry
                    .Connection = GLOBALS.conn
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf FrontBack.Text = "front" Then
            Try
                GLOBALS.openConnection()
                GLOBALS.myqry = "UPDATE flashcard SET front = '" & flashCardWindow.Text & "' WHERE SETID = " & GVariables.CurrentSetID
                MessageBox.Show("front flashcard Edited Successfully")
                With GLOBALS.mycmd
                    .CommandText = GLOBALS.myqry
                    .Connection = GLOBALS.conn
                    .ExecuteNonQuery()
                End With
            Catch ex As Exception
                MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

End Class