Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Reflection.Emit
Module Module1
    Public dbCON As New OleDb.OleDbConnection
    Public dbCMD As New OleDb.OleDbCommand
    Public dbADAP As New OleDb.OleDbDataAdapter
    Public dbDS As New DataSet

    Public RecPointer As Integer
    Public TotalRec As Integer
    Public SaveOnly As Boolean
    Public OldId As String
    Public LoggedInUserRole As String = ""
    Public Toggle As Boolean

    Public Sub database_connection()
        dbCON = New OleDb.OleDbConnection
        dbCON.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\Database\dbase.mdb"
        dbCON.Open()

    End Sub



    Sub Connection_State()
        If dbCON.State = ConnectionState.Closed Then
            dbCON.Open()
        End If
    End Sub





End Module
