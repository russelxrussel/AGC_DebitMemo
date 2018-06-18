Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data

'Public Class DMT_C
'    Inherits Base_C

'End Class

Public Class DMT_ITEM_C
    Inherits Base_C


#Region "GET SECTION"

    Public Function GET_ITEM_LIST() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[MASTER].[spGET_DM_ITEM_LIST]")
        Return dt
    End Function

    Public Function GET_UOM_LIST() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[UTIL].[spGET_DM_UOM_LIST]")
        Return dt
    End Function

    Public Function GET_GROUP_ITEM_LIST() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[UTIL].[spGET_DM_ITEM_GROUP_LIST]")
        Return dt
    End Function


#End Region


#Region "CREATE / UPDATE SECTION"

    Public Sub INSERT_NEW_ITEM(ByVal _itemDescription As String, ByVal _uom As String, ByVal _itemGroupCode As String, ByVal _userCode As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[TRANSACTION].[spINSERT_DM_ITEM]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ITEM_DESCRIPTION", _itemDescription)
                    .Parameters.AddWithValue("@UOM", _uom)
                    .Parameters.AddWithValue("@ITEM_GROUP", _itemGroupCode)
                    .Parameters.AddWithValue("@USER_CODE", _userCode)


                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Public Sub UPDATE_ITEM(ByVal _itemID As Integer, ByVal _itemDescription As String, ByVal _uom As String, ByVal _itemGroupCode As String, ByVal _userCode As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[TRANSACTION].[spUPDATE_DM_ITEM]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@ITEM_DESCRIPTION", _itemDescription)
                    .Parameters.AddWithValue("@UOM", _uom)
                    .Parameters.AddWithValue("@ITEM_GROUP", _itemGroupCode)
                    .Parameters.AddWithValue("@USER_CODE", _userCode)
                    .Parameters.AddWithValue("@ITEM_ID", _itemID)


                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub
#End Region


End Class




Public Class UTILITY
    Inherits Base_C

    Public Function GET_SUPERVISORS() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[UTIL].[spGET_SUPERVISOR_LIST]")
        Return dt
    End Function

    Public Function GET_BRANCHES() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[TRANSACTION].[GET_DM_BRANCH_LIST]")
        Return dt
    End Function

    Public Function GET_REPORTS() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[UTIL].[spGET_DM_REPORTS_LIST]")
        Return dt
    End Function


#Region "CREATE / UPDATE TRANS"

    Public Sub INSERT_SUPERVISOR(ByVal _supervisorName As String, ByVal _userCode As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[UTIL].[spINSERT_DM_SUPERVISOR]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@SUPERVISOR_NAME", _supervisorName)
                    .Parameters.AddWithValue("@USER_CODE", _userCode)

                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Public Sub UPDATE_SUPERVISOR(ByVal _supervisorID As Integer, ByVal _supervisorName As String, ByVal _IsActive As Boolean, ByVal _userCode As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[UTIL].[spUPDATE_DM_SUPERVISOR]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@SUPERVISORID", _supervisorID)
                    .Parameters.AddWithValue("@SUPERVISOR_NAME", _supervisorName)
                    .Parameters.AddWithValue("@IS_ACTIVE", _IsActive)
                    .Parameters.AddWithValue("@USER_CODE", _userCode)
                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub
#End Region
End Class


Public Class DMT_DEBITMEMO_C
    Inherits Base_C

#Region "GET SECTION"


    Public Function GET_ALL_REQUEST_LIST() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[TRANSACTION].[spGET_DM_REQUEST_LIST]")
        Return dt
    End Function

    Public Function GET_ALL_REQUEST_ITEM() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[TRANSACTION].[spGET_DM_ALL_REQUEST_ITEM]")
        Return dt
    End Function
    Public Function GET_FOR_APPROVAL_DM() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[TRANSACTION].[spGET_DM_FOR_APPROVAL_REQUEST]")
        Return dt
    End Function

    Public Function GET_REQUEST_STATUS_LIST() As DataTable
        Dim dt As New DataTable
        dt = queryCommandDT_SP("[TRANSACTION].[spGET_DM_REQUEST_STATUS]")
        Return dt
    End Function

    Public Function GET_USER_REQUEST_LIST(ByVal _usercode As String) As DataTable
        Dim dt As New DataTable
        Using cn As New SqlConnection(_CONSTRING)
            Dim cmd As New SqlCommand("[TRANSACTION].[spGET_DM_USER_REQUESTED_LIST]", cn)
            Dim sqlDA As New SqlDataAdapter(cmd)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@USERCODE", _usercode)
            End With

            sqlDA.Fill(dt)

            cn.Open()

        End Using

        Return dt
    End Function

    Public Function GET_USER_ITEM_REQUEST_LIST(ByVal _dmrNum As String) As DataTable
        Dim dt As New DataTable
        Using cn As New SqlConnection(_CONSTRING)
            Dim cmd As New SqlCommand("[TRANSACTION].[spGET_DM_USER_REQUESTED_ITEM_LIST]", cn)
            Dim sqlDA As New SqlDataAdapter(cmd)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@DMRNUM", _dmrNum)
            End With

            sqlDA.Fill(dt)

            cn.Open()

        End Using

        Return dt
    End Function


    Public Function GET_LIST_ITEM_FOR_APPROVAL(ByVal _dmrnum As String) As DataTable
        Dim dt As New DataTable
        Using cn As New SqlConnection(_CONSTRING)
            Dim cmd As New SqlCommand("[TRANSACTION].[spGET_DM_ITEM_FOR_APPROVAL]", cn)
            Dim sqlDA As New SqlDataAdapter(cmd)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@DMRNUM", _dmrnum)
            End With

            sqlDA.Fill(dt)

            cn.Open()
            
        End Using

        Return dt
    End Function

    Public Function GET_ATTACHMENT(ByVal _dmrnum As String) As DataTable
        Dim dt As New DataTable
        Using cn As New SqlConnection(_CONSTRING)
            Dim cmd As New SqlCommand("[TRANSACTION].[spGET_DM_ATTACHMENT]", cn)
            Dim sqlDA As New SqlDataAdapter(cmd)
            With cmd
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@DMRNUM", _dmrnum)
            End With

            sqlDA.Fill(dt)

            cn.Open()

        End Using

        Return dt
    End Function

#End Region

#Region "TRANSACTION"
    Public Sub INSERT_DEBIT_MEMO_REQUEST(ByVal _dmrNum As String, ByVal _branchCode As String, ByVal _supervisorID As Integer,
                                         ByVal _itemID As Integer, ByVal _ItemDescription As String, ByVal _quantity As Double, ByVal _amount As Double,
                                         ByVal _othersDetail As String, ByVal _requesterNotes As String,
                                         ByVal _isAttachment As Boolean, ByVal _attachment As Byte(), ByVal _dateRequest As DateTime, _
                                         ByVal _userCode As String)

        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[TRANSACTION].[spINSERT_DM_DEBIT_MEMO]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@DMRNUM", _dmrNum)
                    .Parameters.AddWithValue("@BRANCHCODE", _branchCode)
                    .Parameters.AddWithValue("@SUPERVISORID", _supervisorID)
                    .Parameters.AddWithValue("@ITEMID", _itemID)
                    .Parameters.AddWithValue("@ITEMDESCRIPTION", _ItemDescription)
                    .Parameters.AddWithValue("@QUANTITY", _quantity)
                    .Parameters.AddWithValue("@AMOUNT", _amount)
                    .Parameters.AddWithValue("@OTHERS_DETAIL", _othersDetail)
                    .Parameters.AddWithValue("@REQUESTER_NOTES", _requesterNotes)
                    .Parameters.AddWithValue("@ATTACHMENT", _attachment)
                    .Parameters.AddWithValue("@ISATTACHMENT", _isAttachment)
                    .Parameters.AddWithValue("@DATEREQUEST", _dateRequest)
                    .Parameters.AddWithValue("@USERCODE", _userCode)
                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using


    End Sub

    Public Sub UPDATE_DEBITMEMO_HEADER(ByVal _dmrNum As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[TRANSACTION].[spUPDATE_DM_DEBIT_MEMO_HEADER_COMPLETE_STATUS]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@DMRNUM", _dmrNum)

                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub
    Public Sub UPDATE_APPROVAL_DECISION(ByVal _dmrNum As String, ByVal _requestStatus As String, ByVal _id As Integer, ByVal _approverNotes As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[TRANSACTION].[spUPDATE_DM_APPROVAL_DEBIT_MEMO]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@DMRNUM", _dmrNum)
                    .Parameters.AddWithValue("@REQUESTSTATUS", _requestStatus)
                    .Parameters.AddWithValue("@ID", _id)
                    .Parameters.AddWithValue("@APPROVER_NOTES", _approverNotes)
                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub


    Public Sub UPDATE_APPROVE_POSTING(ByVal _dmrNum As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[TRANSACTION].[spUPDATE_DM_POST_APPROVED]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@DMRNUM", _dmrNum)
                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub

    Public Sub UPDATE_APPROVE_PRINTED(ByVal _dmrNum As String)
        Using cn As New SqlConnection(_CONSTRING)

            Using cmd As New SqlCommand("[TRANSACTION].[spUPDATE_DM_PRINTED_APPROVED]", cn)
                With cmd
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@DMRNUM", _dmrNum)
                End With
                cn.Open()
                cmd.ExecuteNonQuery()

            End Using
        End Using
    End Sub

#End Region

End Class


Public Class DMT_SYSTEM_C
    Inherits Base_C

    Public SERIESNUMBER As Integer

#Region "GET DATA"



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


#End Region


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
