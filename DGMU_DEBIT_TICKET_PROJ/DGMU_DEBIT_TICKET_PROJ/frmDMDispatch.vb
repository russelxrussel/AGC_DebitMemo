Imports MetroFramework
Public Class frmDMDispatch
    Dim oDebitMemo As New DMT_DEBITMEMO_C()
    Dim oSystem As New DMT_SYSTEM_C
    Dim sDMRNum As String
    Private Sub frmMyDMRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUserRequest()

        dtpDispatchDate.Value = oSystem.GET_SERVER_DATE_TIME


    End Sub



#Region "USER DEFINED FUNCTION"
    Public Sub DisplayUserRequest()
        Dim dt = New DataTable
        dt = oDebitMemo.GET_USER_REQUEST_LIST_FOR_DISPATCH(frmMain.tsUserCode.Text)

        dgUserRequestList.DataSource = dt


    End Sub


    Public Sub DisplayUserRequestedItem(ByVal _dmrNum As String)
        Dim dt = New DataTable
        dt = oDebitMemo.GET_USER_ITEM_REQUEST_LIST(_dmrNum)



    End Sub

    Private Sub dgUserRequestList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUserRequestList.CellClick


        Dim i As Integer

        i = dgUserRequestList.CurrentRow.Index

        Dim sDMRNum As String = dgUserRequestList.Item(0, i).Value
        lblTempDMNumber.Text = sDMRNum

        Dim b As Boolean = Convert.ToBoolean(dgUserRequestList.Item(6, i).Value)

        If b = True Then
            dtpDispatchDate.Value = Convert.ToDateTime(dgUserRequestList.Item(4, i).Value)
            txtDispatchPerson.Text = dgUserRequestList.Item(5, i).Value
        Else
            dtpDispatchDate.Value = oSystem.GET_SERVER_DATE_TIME
            txtDispatchPerson.Text = ""
        End If

    End Sub

    Private Sub lnkPost_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lnkDispatch_Click(sender As Object, e As EventArgs) Handles lnkDispatch.Click
        If txtDispatchPerson.Text IsNot Nothing Then
            oDebitMemo.UPDATE_DISPATCHED(lblTempDMNumber.Text, Convert.ToDateTime(dtpDispatchDate.Value), txtDispatchPerson.Text)
            frmMain.countForDispatchDBR()
            DisplayUserRequest()
            txtDispatchPerson.Text = ""
            dtpDispatchDate.Value = DateTime.Now
            MetroMessageBox.Show(Me, "Dispatch process success.", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            MetroMessageBox.Show(Me, "Required Input needed.", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        End If

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        searchDisplay(txtSearch.Text)
    End Sub

    Private Sub searchDisplay(ByVal _searchText As String)
        Dim dt As New DataTable
        dt = oDebitMemo.GET_USER_REQUEST_LIST_FOR_DISPATCH(frmMain.tsUserCode.Text)

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "BranchName like '%" + _searchText + "%'"

        If dv.Count > 0 Then
            dgUserRequestList.DataSource = dv

        End If

    End Sub

#End Region
End Class