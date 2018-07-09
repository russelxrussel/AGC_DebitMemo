Imports MetroFramework
Public Class frmVoucherList
    Dim oVoucher As New VOUCHER_C
    Dim sDMRNum As String
    Private Sub frmMyDMRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayUserVoucher()



    End Sub


#Region "USER DEFINED FUNCTION"
    Public Sub DisplayUserVoucher()
        Dim dt = New DataTable
        dt = oVoucher.GET_USER_VOUCHER_LIST("2")

        dgUserRequestList.DataSource = dt


        For Each row As DataGridViewRow In dgUserRequestList.Rows
            Dim bClose As Boolean = Convert.ToBoolean(row.Cells(6).Value)
            If bClose Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub










    'Private Sub lnkPrint_Click(sender As Object, e As EventArgs) Handles lnkPrint.Click
    '    Dim frmReport As New repDebitMemoApproved

    '    'UPDATE ISPRINT TO true
    '    oDebitMemo.UPDATE_APPROVE_PRINTED(sDMRNum)

    '    'GET DEBIT MEMO NUMBER FOR PRINTING
    '    frmReport.DEBIT_NUMBER = sDMRNum
    '    frmReport.Show()
    'End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        dt = oVoucher.GET_USER_VOUCHER_LIST("2")

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "Supplier_Name like '%" + txtSearch.Text + "%'"

        dgUserRequestList.DataSource = dv
    End Sub


#End Region
End Class