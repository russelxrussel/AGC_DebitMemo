Imports MetroFramework
Public Class frmVoucherPaymentRequest
    Dim oVoucher As New VOUCHER_C
    Dim oUtility As New UTILITY
    Dim sVoucherNum As String

    Dim iPayeeSupplierID As Integer

    Private Sub frmMyDMRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayVoucher()
        LoadAccountList()

    End Sub


#Region "USER DEFINED FUNCTION"
    Public Sub DisplayVoucher()
        Dim dt = New DataTable
        dt = oVoucher.GET_VOUCHER_LIST()

        dgUserVoucherList.DataSource = dt

        For Each row As DataGridViewRow In dgUserVoucherList.Rows
            Dim bClose As Boolean = Convert.ToBoolean(row.Cells(7).Value)
            If bClose Then
                row.DefaultCellStyle.BackColor = Color.LightGreen
            End If
        Next
    End Sub




    Private Sub LoadAccountList()
        Dim dt As DataTable = oUtility.GET_ACCOUNT_LIST()

        Dim dr As DataRow = dt.NewRow()
        dr("AccountNumber") = "---Select Account---"
        dr("BankID") = 0
        dt.Rows.InsertAt(dr, 0)

        With ddAccounts
            .DataSource = dt
            .DisplayMember = dt.Columns("AccountNumber").ToString()
            .ValueMember = dt.Columns("BankID").ToString()

        End With

    End Sub


    Private Sub displaySelectedItem()
        Dim i As Integer

        i = dgUserVoucherList.CurrentRow.Index

        sVoucherNum = dgUserVoucherList.Item(0, i).Value
        lblPayeeSupplierName.Text = dgUserVoucherList.Item(1, i).Value
        txtPayeeName.Text = dgUserVoucherList.Item(10, i).Value
        iPayeeSupplierID = dgUserVoucherList.Item(9, i).Value

        Dim bClose As Boolean = Convert.ToBoolean(dgUserVoucherList.Item(6, i).Value)
        Dim bVoid As Boolean = Convert.ToBoolean(dgUserVoucherList.Item(7, i).Value)

        If (bClose And bVoid = False) Then
            lnkPrint.Visible = True
        ElseIf (bClose = False) Then
            lnkPrint.Visible = False
        End If



    End Sub



#End Region


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        dt = oVoucher.GET_VOUCHER_LIST()

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "Supplier_Name like '%" + txtSearch.Text + "%'"

        dgUserVoucherList.DataSource = dv
    End Sub

    Private Sub dgUserVoucherList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUserVoucherList.CellClick
        displaySelectedItem()
    End Sub

    Private Sub dgUserVoucherList_SelectionChanged(sender As Object, e As EventArgs) Handles dgUserVoucherList.SelectionChanged
        Try
            displaySelectedItem()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub lnkPrint_Click(sender As Object, e As EventArgs) Handles lnkPrint.Click
        Dim frmReport As New repCheckPaymentRequest

        'GET DEBIT MEMO NUMBER FOR PRINTING
        With frmReport
            .VOUCHER_NUMBER = sVoucherNum
            .Show()
        End With

    End Sub

    Private Sub lnkProcessPayment_Click(sender As Object, e As EventArgs) Handles lnkProcessPayment.Click
        'Condition here
        oVoucher.INSERT_VOUCHER_PAYMENT(sVoucherNum, ddAccounts.SelectedValue, Convert.ToInt32(iPayeeSupplierID), txtPayeeName.Text, txtCheckNumber.Text, Convert.ToDateTime(dtRequest.Text), frmMain.tsUserCode.Text)
    End Sub

    Private Sub ddAccounts_SelectedValueChanged(sender As Object, e As EventArgs) Handles ddAccounts.SelectedValueChanged
        Try

            Dim dt As New DataTable
            dt = oUtility.GET_ACCOUNT_LIST

            Dim dv As DataView = dt.DefaultView

            dv.RowFilter = "BankID = '" & Convert.ToInt32(ddAccounts.SelectedValue) & "'"

            If (dv.Count > 0) Then
                For Each drv As DataRowView In dv
                    lblBankName.Text = drv("BankName").ToString()

                Next
            Else
                lblBankName.Text = ""
            End If

        Catch ex As Exception

        End Try

    End Sub
End Class