Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Base_C


    Public _CONSTRING As String = "Data Source=192.168.3.55;Initial Catalog=AGC;Persist Security Info=True;User ID=sa;Password=p@ssw0rd"
    'Public _CONSTRING As String = "Data Source=.;Initial Catalog=AGC;Persist Security Info=True;User ID=sa;Password=p@ssw0rd"
    Public _SQLCON As New SqlConnection(_CONSTRING)

    Public Function DBCONNECT() As Boolean
        Try
            _SQLCON.Open()

            _SQLCON.Close()
            Return True
        Catch ex As Exception
            MsgBox("Error: " & ex.ToString())

            Return False
        End Try
    End Function

    Public Function queryCommandDT(ByVal sqlQuery) As DataTable
        Dim dt = New DataTable

        Using cn As New SqlConnection(_CONSTRING)
            Using cmd As New SqlCommand(sqlQuery, cn)
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        Return dt

    End Function

    Public Function queryCommandDT_SP(ByVal sqlQuery) As DataTable
        Dim dt = New DataTable

        Using cn As New SqlConnection(_CONSTRING)
            Using cmd As New SqlCommand(sqlQuery, cn)
                cmd.CommandType = CommandType.StoredProcedure
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
            End Using
        End Using

        Return dt

    End Function

End Class


