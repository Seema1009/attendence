Imports System.Data.OleDb
Module databasemodule

    'Create OLE objects.
    Public myConn As OleDbConnection
    Public myCmd As OleDbCommand
    Public mydataadapter As OleDbDataAdapter
    Public mytable As DataTable

    'statistics parameters
    Public Recordcount As Integer
    Public Exception As String
    Public FORM_MODE As String = "ADD"

    Public Sub ExecQuery(Query As String)
        'reset stats params
        Recordcount = 0
        Exception = ""

        Try

            myCmd = New OleDbCommand(Query, myConn)

            'execute the command  and fill datatable
            mytable = New DataTable
            mydataadapter = New OleDbDataAdapter(myCmd)
            Recordcount = mydataadapter.Fill(mytable)

        Catch ex As Exception
            Exception = ex.Message
        End Try

    End Sub
    Public Sub OpenConnection()

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

    End Sub
    Public Sub CloseConnection()
        If myConn.State = ConnectionState.Open Then
            myConn.Close()
        End If
    End Sub

End Module
