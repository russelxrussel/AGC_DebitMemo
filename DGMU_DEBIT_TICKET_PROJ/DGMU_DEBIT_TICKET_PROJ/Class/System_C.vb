Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data
Public Class System_C
    Inherits Base_C

    Public SERIESNUMBER As Integer
    Public Function GET_SERVER_DATE_TIME() As DateTime


        Dim ServerDT As DateTime

        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[xSys].[GET_SERVER_DATE_TIME]", cn)


                cn.Open()

                ServerDT = Convert.ToDateTime(cmd.ExecuteScalar())


                Return ServerDT
            End Using
        End Using

    End Function

    Public Function GET_USER_DATA() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[xSys].[spGET_USER_LIST]")
        Return dt
    End Function


    Public Function GET_COMPANY_DATA() As DataTable
        Dim dt As DataTable = queryCommandDT_SP("[xSys].[spGET_COMPANY_LIST]")
        Return dt
    End Function




    Public Function GENERATE_SERIES_NUMBER(ByVal _prefixCode As String)
        SERIESNUMBER = 0
        Dim PrefixCode As String = ""
        Dim AutoNumberSeries As String = ""
        Dim IsNumberOnly As Boolean = False

        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[xSys].[GET_SERIES_NUMBER]", cn)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@PREFIXCODE", _prefixCode)
                End With

                cn.Open()

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                If dr.HasRows = True Then
                    While (dr.Read)
                        PrefixCode = dr("PrefixCode").ToString()
                        IsNumberOnly = Convert.ToBoolean(dr("IsNumberOnly"))


                        If Convert.ToInt32(dr("Series")) > 0 Then
                            SERIESNUMBER = Convert.ToInt32(dr("Series")) + 1

                            'Format Transaction AutoNumber
                            ' UP TO 999999 AutoNumbers
                            '

                            If SERIESNUMBER > 999999 Then

                                If IsNumberOnly = True Then

                                    AutoNumberSeries = SERIESNUMBER.ToString()

                                Else

                                    AutoNumberSeries = PrefixCode & "-" & SERIESNUMBER

                                End If

                            ElseIf SERIESNUMBER > 99999 Then

                                If IsNumberOnly = True Then
                                    AutoNumberSeries = "0" & SERIESNUMBER
                                Else
                                    AutoNumberSeries = PrefixCode & "-0" & SERIESNUMBER
                                End If

                            ElseIf SERIESNUMBER > 9999 Then

                                If IsNumberOnly = True Then
                                    AutoNumberSeries = "00" & SERIESNUMBER
                                Else
                                    AutoNumberSeries = PrefixCode & "-00" & SERIESNUMBER
                                End If

                            ElseIf SERIESNUMBER > 999 Then

                                If IsNumberOnly = True Then
                                    AutoNumberSeries = "000" & SERIESNUMBER
                                Else
                                    AutoNumberSeries = PrefixCode & "-000" & SERIESNUMBER
                                End If

                            ElseIf SERIESNUMBER > 99 Then

                                If IsNumberOnly = True Then
                                    AutoNumberSeries = "0000" & SERIESNUMBER
                                Else
                                    AutoNumberSeries = PrefixCode & "-0000" & SERIESNUMBER
                                End If

                            ElseIf SERIESNUMBER > 9 Then

                                If IsNumberOnly = True Then
                                    AutoNumberSeries = "00000" & SERIESNUMBER
                                Else
                                    AutoNumberSeries = PrefixCode & "-00000" & SERIESNUMBER
                                End If

                            Else

                                If IsNumberOnly = True Then
                                    AutoNumberSeries = "000000" & SERIESNUMBER
                                Else
                                    AutoNumberSeries = PrefixCode & "-000000" & SERIESNUMBER

                                End If

                            End If
                        Else
                            SERIESNUMBER = SERIESNUMBER + 1

                            If IsNumberOnly = True Then
                                AutoNumberSeries = "000000" & SERIESNUMBER
                            Else
                                AutoNumberSeries = PrefixCode & "-000000" & SERIESNUMBER

                            End If


                        End If
                    End While
                End If


            End Using
        End Using



        Return AutoNumberSeries
    End Function

    Public Function GENERATE_SERIES_NUMBER_5DIGITS(ByVal _prefixCode As String)
        SERIESNUMBER = 0
        Dim PrefixCode As String = ""
        Dim AutoNumberSeries As String = ""
        Dim IsNumberOnly As Boolean = False

        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[xSys].[GET_SERIES_NUMBER]", cn)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@PREFIXCODE", _prefixCode)
                End With

                cn.Open()

                Dim dr As SqlDataReader = cmd.ExecuteReader()

                If dr.HasRows = True Then
                    While (dr.Read)
                        PrefixCode = dr("PrefixCode").ToString()
                        IsNumberOnly = Convert.ToBoolean(dr("IsNumberOnly"))


                        If Convert.ToInt32(dr("Series")) > 0 Then
                            SERIESNUMBER = Convert.ToInt32(dr("Series")) + 1

                            'Format Transaction AutoNumber
                            ' UP TO 999999 AutoNumbers
                            '

                            If SERIESNUMBER > 9999 Then


                                AutoNumberSeries = PrefixCode & "-" & SERIESNUMBER


                            ElseIf SERIESNUMBER > 999 Then


                                AutoNumberSeries = PrefixCode & "-0" & SERIESNUMBER


                            ElseIf SERIESNUMBER > 99 Then


                                AutoNumberSeries = PrefixCode & "-00" & SERIESNUMBER

                            ElseIf SERIESNUMBER > 9 Then

                                AutoNumberSeries = PrefixCode & "-000" & SERIESNUMBER

                            Else

                                AutoNumberSeries = PrefixCode & "-0000" & SERIESNUMBER


                            End If

                        Else
                            SERIESNUMBER = SERIESNUMBER + 1

                            AutoNumberSeries = PrefixCode & "-0000" & SERIESNUMBER



                        End If
                    End While
                End If


            End Using
        End Using



        Return AutoNumberSeries
    End Function
    Public Sub UPDATE_SERIES_NUMBER(ByVal _prefixCode As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[xSys].[UPDATE_SERIES_NUMBER]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@PREFIXCODE", _prefixCode)
                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using


    End Sub

    Public Sub UPDATE_USER_PASSWORD(ByVal _userCode As String, ByVal _newPassword As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[xSys].[UPDATE_USER_PASSWORD]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@USERCODE", _userCode)
                    .Parameters.AddWithValue("@NEW_PASSWORD", _newPassword)
                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Public Function GET_TRANSACTION_TYPE_LIST() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[xSystem].[GET_TRANSACTION_TYPE_LIST]")
        Return dt
    End Function

    Public Function GET_FINGER_ENROLLED_DESCRIPTION(ByVal _customerCode As String) As String
        Dim str = ""
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[xSystem].[GET_ENROLLED_FINGER]", cn)

                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@CUSTOMERCODE", _customerCode)
                End With

                cn.Open()

                Dim dr As SqlDataReader = cmd.ExecuteReader()
                If dr.HasRows = True Then

                    While dr.Read
                        str = dr("Description")
                    End While
                Else
                    str = ""
                End If

            End Using
        End Using

        Return str
    End Function
End Class
