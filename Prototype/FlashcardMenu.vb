Imports System.Data.OleDb

Public Class FlashcardMenu

    Dim selectedFlashCards As List(Of String()) = New List(Of String())

    Dim ignoreEvent As Boolean = False

    Private Sub SetListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SetListbox.SelectedIndexChanged
        'Store the selected set name in a global variable
        GVariables.CurrentSetName = SetListbox.GetItemText(SetListbox.SelectedItem)

        'Disable buttons and load cards
        DisableButtons()
        loadCards()

        If selectedFlashCards.Count > 1 Then
            nextBtn.Enabled = True
        End If

        flipBtn.Enabled = True
        addCardBtn.Enabled = True
        DeleteSetBtn.Enabled = True
        flashCardWindow.Enabled = True

        ignoreEvent = True
        flashCardWindow.Text = (selectedFlashCards(0))(1)
        ignoreEvent = False

        GVariables.CurrentCardState = 1
        GVariables.CurrentFlashcardID = 0
        FrontBack.Text = "Question:"

        cardCount.Text = "1/" & selectedFlashCards.Count
        DeleteFlashcardBtn.Enabled = True

    End Sub

    Private Sub FlashcardMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSets()
    End Sub

    Private Sub loadSets()
        'Clear the currently loaded list box
        SetListbox.Items.Clear()

        Try
            GLOBALS.openConnection()
            GLOBALS.myqry = "SELECT SetName FROM Flashcard_Set WHERE StudentID = " & GVariables.StudentID
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            While GLOBALS.mydr.Read()
                SetListbox.Items.Add(GLOBALS.mydr("SetName").ToString)
            End While
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message)
        End Try
    End Sub

    Private Sub loadCards()
        'Fetch the ID of the selected set name
        Try
            GLOBALS.openConnection()
            GLOBALS.mycmd.CommandText = "SELECT SetID FROM Flashcard_Set WHERE SetName = '" + GVariables.CurrentSetName + "'"

            GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader()

            While GLOBALS.mydr.Read()
                'Store the ID of the selected set in a global variable
                GVariables.CurrentSetID = Convert.ToInt32(GLOBALS.mydr("SetID"))
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        selectedFlashCards.Clear()

        'Fetch all the flashcards for a given set
        Try
            GLOBALS.openConnection()
            Dim command As New OleDbCommand
            command.Connection = GLOBALS.conn

            'command.CommandText = "SELECT FlashcardID, Front, Back FROM Flashcard WHERE SetID = ?"
            'command.Parameters.Add("SetID", OleDbType.Integer, 8)
            'command.Parameters(0).Value = GVariables.CurrentSetID
            'command.Prepare()


            'GLOBALS.openConnection()
            GLOBALS.myqry = "SELECT FlashcardID, Front, Back FROM Flashcard WHERE SetID = " & GVariables.CurrentSetID
            GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
            'GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
            'While GLOBALS.mydr.Read()
            '    SetListbox.Items.Add(GLOBALS.mydr("SetName").ToString)
            'End While


            Dim reader As OleDbDataReader = GLOBALS.mycmd.ExecuteReader()
            If reader.HasRows Then
                While reader.Read()
#Disable Warning BC42016 ' Implicit conversion
                    selectedFlashCards.Add({reader.GetInt32(reader.GetOrdinal("FlashcardID")), reader.GetString(reader.GetOrdinal("Front")), reader.GetString(reader.GetOrdinal("Back"))})
#Enable Warning BC42016 ' Implicit conversion
                End While
            Else
                MessageBox.Show("No flashcards in set")
                Dim frontCard As String = InputBox("Enter a front", "Create Flashcard")
                Dim backCard As String = InputBox("Enter a back", "Create Flashcard")

                Try
                    GLOBALS.openConnection()
                    GLOBALS.mycmd = New OleDbCommand("INSERT INTO Flashcard(SetID, Front, Back) VALUES(?, ?, ?)", GLOBALS.conn)
                    GLOBALS.mycmd.Parameters.Add("SetID", OleDbType.Integer, 8)
                    GLOBALS.mycmd.Parameters.Add("Front", OleDbType.VarChar, 1024)
                    GLOBALS.mycmd.Parameters.Add("Back", OleDbType.VarChar, 1024)

                    GLOBALS.mycmd.Parameters(0).Value = GVariables.CurrentSetID
                    GLOBALS.mycmd.Parameters(1).Value = frontCard
                    GLOBALS.mycmd.Parameters(2).Value = backCard

                    GLOBALS.mycmd.Prepare()

                    GLOBALS.mycmd.ExecuteNonQuery()

                    loadCards()

                Catch ex As Exception
                    MessageBox.Show(ex.Message())
                End Try

            End If


        Catch ex As FormatException
            MessageBox.Show(ex.Message(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub DisableButtons()
        addCardBtn.Enabled = False
        SaveBtn.Enabled = False
        previousBtn.Enabled = False
        flipBtn.Enabled = False
        nextBtn.Enabled = False
        DeleteSetBtn.Enabled = False
        DeleteFlashcardBtn.Enabled = False
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        MainMenu.Show()
        Me.Hide()
    End Sub

    Private Sub addSetBtn_Click(sender As Object, e As EventArgs) Handles addSetBtn.Click
        'Adding a new set
        Dim setName As String = InputBox("Enter name of set: ", "Create Set")
        If setName = Nothing Then
            MessageBox.Show("Name cannot be blank")
            Return
        End If

        'Add set into database
        Try
            GLOBALS.openConnection()
            GLOBALS.mycmd = New OleDbCommand("INSERT INTO Flashcard_Set(StudentID, SetName) VALUES(?, ?)", GLOBALS.conn)

            GLOBALS.mycmd.Parameters.Add("StudentID", OleDbType.Integer)
            GLOBALS.mycmd.Parameters.Add("SetName", OleDbType.VarChar, 64)
            GLOBALS.mycmd.Parameters(0).Value = GVariables.StudentID
            GLOBALS.mycmd.Parameters(1).Value = setName
            GLOBALS.mycmd.Prepare()

            GLOBALS.mycmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Exception when inserting into Flashcard_Set: " & ex.Message)
        End Try

        'Refresh the set list
        loadSets()
    End Sub

    Private Sub DeleteSetBtn_Click(sender As Object, e As EventArgs) Handles DeleteSetBtn.Click
        ignoreEvent = True
        GLOBALS.myqry = "DELETE FROM Flashcard WHERE SetID = " & GVariables.CurrentSetID
        GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
        GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

        GLOBALS.myqry = "DELETE FROM Flashcard_Set WHERE SetID = " & GVariables.CurrentSetID
        GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
        GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

        DisableButtons()
        flashCardWindow.Text = ""
        loadSets()
        cardCount.Text = "0/0"
        selectedFlashCards.Clear()
        flashCardWindow.Enabled = False
        ignoreEvent = False

    End Sub

    Private Sub flipBtn_Click(sender As Object, e As EventArgs) Handles flipBtn.Click
        ignoreEvent = True
        'Check position
        If GVariables.CurrentCardState = 1 Then
            'Access list and fetch the oposite position's text for the currently selected card
            flashCardWindow.Text = (selectedFlashCards(GVariables.CurrentFlashcardID))(2)
            GVariables.CurrentCardState = 2
            FrontBack.Text = "Answer:"
        Else
            flashCardWindow.Text = (selectedFlashCards(GVariables.CurrentFlashcardID))(1)
            GVariables.CurrentCardState = 1
            FrontBack.Text = "Question:"
        End If
        ignoreEvent = False
    End Sub

    Private Sub flashCardWindow_TextChanged(sender As Object, e As EventArgs) Handles flashCardWindow.TextChanged
        If ignoreEvent Then Return
        DisableButtons()
        SaveBtn.Enabled = True
        flashCardWindow.Enabled = True

        SetListbox.Enabled = False


    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        ignoreEvent = True
        DisableButtons()
        Dim text As String = flashCardWindow.Text

        selectedFlashCards(GVariables.CurrentFlashcardID)(GVariables.CurrentCardState) = text

        If GVariables.CurrentCardState = 1 Then
            GLOBALS.myqry = "UPDATE Flashcard
            SET Front = '" & text & "'
            WHERE FlashcardID = " & selectedFlashCards(GVariables.CurrentFlashcardID)(0)
        Else
            GLOBALS.myqry = "UPDATE Flashcard
            SET Back = '" & text & "'
            WHERE FlashcardID = " & selectedFlashCards(GVariables.CurrentFlashcardID)(0)
        End If
        GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
        GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader
        DisableButtons()
        flipBtn.Enabled = True
        nextBtn.Enabled = True
        previousBtn.Enabled = True
        addCardBtn.Enabled = True
        SetListbox.Enabled = True
        ignoreEvent = False
    End Sub

    Private Sub addCardBtn_Click(sender As Object, e As EventArgs) Handles addCardBtn.Click
        Dim frontCard As String = InputBox("Enter a front", "Create Flashcard")
        Dim backCard As String = InputBox("Enter a back", "Create Flashcard")

        Try
            GLOBALS.openConnection()
            GLOBALS.mycmd = New OleDbCommand("INSERT INTO Flashcard(SetID, Front, Back) VALUES(?, ?, ?)", GLOBALS.conn)
            GLOBALS.mycmd.Parameters.Add("SetID", OleDbType.Integer, 8)
            GLOBALS.mycmd.Parameters.Add("Front", OleDbType.VarChar, 1024)
            GLOBALS.mycmd.Parameters.Add("Back", OleDbType.VarChar, 1024)

            GLOBALS.mycmd.Parameters(0).Value = GVariables.CurrentSetID
            GLOBALS.mycmd.Parameters(1).Value = frontCard
            GLOBALS.mycmd.Parameters(2).Value = backCard

            GLOBALS.mycmd.Prepare()

            GLOBALS.mycmd.ExecuteNonQuery()

            loadCards()

        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try
        UpdateOrder()
    End Sub

    Private Sub previousBtn_Click(sender As Object, e As EventArgs) Handles previousBtn.Click
        ignoreEvent = True
        DeleteFlashcardBtn.Enabled = True
        If GVariables.CurrentFlashcardID = 0 Then
            Return
        Else
            GVariables.CurrentFlashcardID -= 1
            flashCardWindow.Text = selectedFlashCards(GVariables.CurrentFlashcardID)(1)
            FrontBack.Text = "Question:"
        End If
        UpdateOrder()
        ignoreEvent = False
    End Sub

    Private Sub nextBtn_Click(sender As Object, e As EventArgs) Handles nextBtn.Click
        ignoreEvent = True
        DeleteFlashcardBtn.Enabled = True
        If GVariables.CurrentFlashcardID = selectedFlashCards.Count - 1 Then
            Return
        Else
            GVariables.CurrentFlashcardID += 1
            flashCardWindow.Text = selectedFlashCards(GVariables.CurrentFlashcardID)(1)
            FrontBack.Text = "Question:"
        End If
        UpdateOrder()
        ignoreEvent = False
    End Sub

    Private Sub UpdateOrder()
        cardCount.Text = GVariables.CurrentFlashcardID + 1 & "/" & selectedFlashCards.Count
        If selectedFlashCards.Count = 1 Then
            nextBtn.Enabled = False
            previousBtn.Enabled = False
        Else
            If GVariables.CurrentFlashcardID < 1 Then
                previousBtn.Enabled = False
                nextBtn.Enabled = True
            ElseIf GVariables.CurrentFlashcardID = selectedFlashCards.Count - 1 Then
                previousBtn.Enabled = True
                nextBtn.Enabled = False
            Else
                previousBtn.Enabled = True
                nextBtn.Enabled = True
            End If
        End If
    End Sub

    'Private Sub DeleteFlashcardBtn_Click(sender As Object, e As EventArgs) Handles DeleteFlashcardBtn.Click
    '    ignoreEvent = True

    '    GLOBALS.myqry = "DELETE FROM Flashcard WHERE FlashcardID = " & GVariables.CurrentFlashcardID
    '    GLOBALS.mycmd = New OleDbCommand(GLOBALS.myqry, GLOBALS.conn)
    '    GLOBALS.mydr = GLOBALS.mycmd.ExecuteReader

    '    ignoreEvent = False
    'End Sub
End Class

