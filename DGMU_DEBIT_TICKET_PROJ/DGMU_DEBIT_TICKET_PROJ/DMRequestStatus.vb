﻿Imports MetroFramework
Public Class frmMyDMRequest
    Dim oDebitMemo As New DMT_DEBITMEMO_C()
    Dim sDMRNum As String
    Private Sub frmMyDMRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUserRequest()

        flayoutControl.Visible = False

    End Sub

    Private Sub dgUserRequestList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUserRequestList.CellClick
        Dim i As Integer

        i = dgUserRequestList.CurrentRow.Index

        sDMRNum = dgUserRequestList.Item(0, i).Value
        Dim bPosted As Boolean = Convert.ToBoolean(dgUserRequestList.Item(3, i).Value)
        Dim bComplete As Boolean = Convert.ToBoolean(dgUserRequestList.Item(4, i).Value)

        If (bComplete And bPosted) Then
            flayoutControl.Visible = True
            lnkPost.Visible = False
            lnkPrint.Visible = True
        ElseIf (bComplete And bPosted = False) Then
            flayoutControl.Visible = True
            lnkPost.Visible = True
            lnkPrint.Visible = False
        Else
            flayoutControl.Visible = False



        End If


        DisplayUserRequestedItem(sDMRNum)



    End Sub



#Region "USER DEFINED FUNCTION"
    Public Sub DisplayUserRequest()
        Dim dt = New DataTable
        dt = oDebitMemo.GET_USER_REQUEST_LIST(frmMain.tsUserCode.Text)

        dgUserRequestList.DataSource = dt


        For Each row As DataGridViewRow In dgUserRequestList.Rows
            Dim bComplete As Boolean = Convert.ToBoolean(row.Cells(3).Value)
            If bComplete Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub


    Public Sub DisplayUserRequestedItem(ByVal _dmrNum As String)
        Dim dt = New DataTable
        dt = oDebitMemo.GET_USER_ITEM_REQUEST_LIST(_dmrNum)

        dgUser_Requested_List_Item.DataSource = dt

        For Each row As DataGridViewRow In dgUser_Requested_List_Item.Rows
            Dim sRowStatus As String = row.Cells(6).Value.ToString()
            If sRowStatus = "R" Then
                row.DefaultCellStyle.BackColor = Color.OrangeRed
            End If

        Next


    End Sub







    Private Sub lnkPrint_Click(sender As Object, e As EventArgs) Handles lnkPrint.Click
        Dim frmReport As New repDebitMemoApproved

        'UPDATE ISPRINT TO true
        oDebitMemo.UPDATE_APPROVE_PRINTED(sDMRNum)

        'GET DEBIT MEMO NUMBER FOR PRINTING
        frmReport.DEBIT_NUMBER = sDMRNum
        frmReport.Show()
    End Sub

    Private Sub lnkPost_Click(sender As Object, e As EventArgs) Handles lnkPost.Click
        If (MetroMessageBox.Show(Me, "Confirm posting" & vbNewLine _
                                       & "Warning posting your request will not reversable after confirming.", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then
            oDebitMemo.UPDATE_APPROVE_POSTING(sDMRNum)

            

            'Refresh Main Counting
            frmMain.countApproveDBR_ForPosting()

            'RELOAD FORM
            Controls.Clear()
            InitializeComponent()
            Show()

            DisplayUserRequest()
            flayoutControl.Visible = False
            lnkPost.Visible = False
            lnkPrint.Visible = True
        End If
    End Sub


#End Region
End Class