Imports MetroFramework
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
        Dim bCancel As Boolean = Convert.ToBoolean(dgUserRequestList.Item(5, i).Value)

        If (bComplete And bPosted And bCancel = False) Then
            flayoutControl.Visible = True
            lnkPost.Visible = False
            lnkPrint.Visible = True
            lnkCancel.Visible = False
        ElseIf (bComplete And bPosted = False And bCancel = False) Then
            flayoutControl.Visible = True
            lnkPost.Visible = True
            lnkPrint.Visible = False
            lnkCancel.Visible = False
        ElseIf (bCancel = True)
            flayoutControl.Visible = False
        Else
            flayoutControl.Visible = True
            lnkPost.Visible = False
            lnkPrint.Visible = False
            lnkCancel.Visible = True
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

        'For Each row As DataGridViewRow In dgUserRequestList.Rows
        '        Dim bCancel As Boolean = Convert.ToBoolean(row.Cells(4).Value)

        '        If bCancel Then
        '        row.ReadOnly = True
        '        row.DefaultCellStyle.BackColor = Color.Red
        '    End If

        '    Next
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
            frmMain.countForDispatchDBR()
            'RELOAD FORM
            Controls.Clear()
            InitializeComponent()
            Show()

            DisplayUserRequest()
            flayoutControl.Visible = False
            lnkPost.Visible = False
            lnkPrint.Visible = True

            Dim frmReport As New repDebitMemoApproved

            'UPDATE ISPRINT TO true
            oDebitMemo.UPDATE_APPROVE_PRINTED(sDMRNum)

            'GET DEBIT MEMO NUMBER FOR PRINTING
            frmReport.DEBIT_NUMBER = sDMRNum
            frmReport.Show()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        dt = oDebitMemo.GET_USER_REQUEST_LIST(frmMain.tsUserCode.Text)

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "BranchName like '%" + txtSearch.Text + "%'"

        dgUserRequestList.DataSource = dv
    End Sub

    Private Sub lnkCancel_Click(sender As Object, e As EventArgs) Handles lnkCancel.Click
        If (MetroMessageBox.Show(Me, "Cancellation" & vbNewLine _
                                       & "Warning cancellation of request will not reversable after confirming.", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then

            oDebitMemo.UPDATE_CANCELLATION_DM(sDMRNum)

            'RELOAD FORM
            Controls.Clear()
            InitializeComponent()
            Show()

            DisplayUserRequest()
        Else
            Exit Sub
        End If

    End Sub


#End Region
End Class