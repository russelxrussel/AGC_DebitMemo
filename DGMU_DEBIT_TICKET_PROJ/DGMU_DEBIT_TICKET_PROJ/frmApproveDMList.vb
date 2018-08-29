Imports MetroFramework
Public Class frmApproveDMList
    Dim oDebitMemo As New DMT_DEBITMEMO_C()
    Dim sDMRNum As String
    Private Sub frmMyDMRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayApproveList()

        ' flayoutControl.Visible = False

    End Sub

    Private Sub dgDMApproveList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgDMApproveList.CellClick
        Dim i As Integer

        i = dgDMApproveList.CurrentRow.Index

        sDMRNum = dgDMApproveList.Item(0, i).Value
        'Dim bPosted As Boolean = Convert.ToBoolean(dgDMApproveList.Item(3, i).Value)
        'Dim bComplete As Boolean = Convert.ToBoolean(dgDMApproveList.Item(4, i).Value)
        Dim bCancel As Boolean = Convert.ToBoolean(dgDMApproveList.Item(6, i).Value)

        'If (bComplete And bPosted And bCancel = False) Then
        '    flayoutControl.Visible = True
        '    lnkPost.Visible = False
        '    lnkPrint.Visible = True
        '    lnkCancel.Visible = False
        'ElseIf (bComplete And bPosted = False And bCancel = False) Then
        '    flayoutControl.Visible = True
        '    lnkPost.Visible = True
        '    lnkPrint.Visible = False
        '    lnkCancel.Visible = False
        'ElseIf (bCancel = True)
        '    flayoutControl.Visible = False
        'Else
        '    flayoutControl.Visible = True
        '    lnkPost.Visible = False
        '    lnkPrint.Visible = False
        '    lnkCancel.Visible = True
        'End If

        If bCancel Then
            lnkCancel.Visible = False
        Else
            lnkCancel.Visible = True
        End If


        DisplayUserRequestedItem(sDMRNum)



    End Sub



#Region "USER DEFINED FUNCTION"
    Public Sub DisplayApproveList()
        Dim dt = New DataTable
        dt = oDebitMemo.GET_APPROVED_DM_LIST

        dgDMApproveList.DataSource = dt


        'For Each row As DataGridViewRow In dgDMApproveList.Rows
        '    Dim bComplete As Boolean = Convert.ToBoolean(row.Cells(3).Value)


        '    If bComplete Then
        '        row.DefaultCellStyle.BackColor = Color.LightGreen
        '    End If

        'Next

        For Each row As DataGridViewRow In dgDMApproveList.Rows
            Dim bCancel As Boolean = Convert.ToBoolean(row.Cells(6).Value)

            If bCancel Then
                row.ReadOnly = True
                row.DefaultCellStyle.BackColor = Color.Red
            End If

        Next
    End Sub


    Public Sub DisplayUserRequestedItem(ByVal _dmrNum As String)
        Dim dt = New DataTable
        dt = oDebitMemo.GET_USER_ITEM_REQUEST_LIST(_dmrNum)

        dgApprove_List_Item.DataSource = dt

        'For Each row As DataGridViewRow In dgUser_Requested_List_Item.Rows
        '    Dim sRowStatus As String = row.Cells(6).Value.ToString()
        '    If sRowStatus = "R" Then
        '        row.DefaultCellStyle.BackColor = Color.OrangeRed
        '    End If

        'Next


    End Sub









    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        dt = oDebitMemo.GET_APPROVED_DM_LIST

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "BranchName like '%" + txtSearch.Text + "%'"

        dgDMApproveList.DataSource = dv
    End Sub

    Private Sub lnkCancel_Click(sender As Object, e As EventArgs) Handles lnkCancel.Click
        If (MetroMessageBox.Show(Me, "Cancellation" & vbNewLine _
                                       & "Warning cancellation of request will not reversable after confirming.", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then

            oDebitMemo.UPDATE_CANCELLATION_DM(sDMRNum)

            'RELOAD FORM
            Controls.Clear()
            InitializeComponent()
            Show()

            DisplayApproveList()
        Else
            Exit Sub
        End If

    End Sub


#End Region
End Class