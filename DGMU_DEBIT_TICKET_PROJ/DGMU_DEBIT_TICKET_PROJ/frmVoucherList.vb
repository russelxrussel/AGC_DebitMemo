Imports MetroFramework
Public Class frmVoucherList
    Dim oVoucher As New VOUCHER_C
    Dim sVoucherNum As String
    Private Sub frmMyDMRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUserVoucher()

    End Sub


#Region "USER DEFINED FUNCTION"
    Public Sub DisplayUserVoucher()
        Dim dt = New DataTable
        dt = oVoucher.GET_USER_VOUCHER_LIST(frmMain.tsUserCode.Text)

        dgUserVoucherList.DataSource = dt

        For Each row As DataGridViewRow In dgUserVoucherList.Rows
            Dim bClose As Boolean = Convert.ToBoolean(row.Cells(7).Value)
            If bClose Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub


    Public Sub DisplayUserVoucherItem(ByVal _voucherNum As String)
        Dim dt = New DataTable
        dt = oVoucher.GET_USER_VOUCHER_ITEM_LIST(_voucherNum)

        dgUserVoucherItemList.DataSource = dt

        'For Each row As DataGridViewRow In dgUser_Requested_List_Item.Rows
        '    Dim sRowStatus As String = row.Cells(6).Value.ToString()
        '    If sRowStatus = "R" Then
        '        row.DefaultCellStyle.BackColor = Color.OrangeRed
        '    End If

        'Next


    End Sub


#End Region






    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        dt = oVoucher.GET_USER_VOUCHER_LIST(frmMain.tsUserCode.Text)

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "Supplier_Name like '%" + txtSearch.Text + "%'"

        dgUserVoucherList.DataSource = dv
    End Sub

    Private Sub dgUserVoucherList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUserVoucherList.CellClick
        Dim i As Integer

        i = dgUserVoucherList.CurrentRow.Index

        sVoucherNum = dgUserVoucherList.Item(0, i).Value
        'Dim bPosted As Boolean = Convert.ToBoolean(dgUserRequestList.Item(3, i).Value)
        'Dim bComplete As Boolean = Convert.ToBoolean(dgUserRequestList.Item(4, i).Value)

        'MsgBox("Voucher: " & sVoucherNum)
        DisplayUserVoucherItem(sVoucherNum)

    End Sub

    Private Sub dgUserVoucherList_SelectionChanged(sender As Object, e As EventArgs) Handles dgUserVoucherList.SelectionChanged
        Dim i As Integer

        i = dgUserVoucherList.CurrentRow.Index

        sVoucherNum = dgUserVoucherList.Item(0, i).Value
        'Dim bPosted As Boolean = Convert.ToBoolean(dgUserRequestList.Item(3, i).Value)
        'Dim bComplete As Boolean = Convert.ToBoolean(dgUserRequestList.Item(4, i).Value)

        'MsgBox("Voucher: " & sVoucherNum)
        DisplayUserVoucherItem(sVoucherNum)

        Dim bClose As Boolean = Convert.ToBoolean(dgUserVoucherList.Item(7, i).Value)
        Dim bVoid As Boolean = Convert.ToBoolean(dgUserVoucherList.Item(8, i).Value)

        If (bClose And bVoid = False) Then
            lnkPrint.Visible = True
        ElseIf (bClose = False) Then
            lnkPrint.Visible = False
        End If
    End Sub

    Private Sub lnkPrint_Click(sender As Object, e As EventArgs) Handles lnkPrint.Click
        Dim frmReport As New repVoucherReceipt

        'UPDATE ISPRINT TO true
        'oDebitMemo.UPDATE_APPROVE_PRINTED(sDMRNum)

        'GET DEBIT MEMO NUMBER FOR PRINTING
        With frmReport
            .VOUCHER_NUMBER = sVoucherNum
            .Show()
        End With

    End Sub
End Class