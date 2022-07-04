Imports System.Data.OleDb
Module Connection
    Public Class GLOBALS
        Public Shared conn As New OleDb.OleDbConnection
        Public Shared myqry As String = Nothing
        Public Shared mycmd As New OleDbCommand
        Public Shared mydr As OleDbDataReader
        Public Shared Sub ConnToDb()
            Try
                With conn
                    If .State = ConnectionState.Open Then .Close()
                    .ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PrototypeDB1.accdb")
                    .Open()
                End With
            Catch ex As Exception
                MessageBox.Show("Unable to connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub
        Public Shared Sub openConnection()
            With GLOBALS.conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\PrototypeDB1.accdb")
                .Open()
            End With
        End Sub
    End Class
End Module
