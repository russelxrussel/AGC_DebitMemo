Imports MetroFramework
Public Class frmVoucherModule

    Dim oItem As New DMT_ITEM_C
    Dim oUtility As New UTILITY
    Dim oSystem As New DMT_SYSTEM_C
    Dim oDMR As New DMT_DEBITMEMO_C
    Dim oVoucher As New VOUCHER_C

    Private rowIndex As Integer = 0
    Private pTotalAmountPrice As Double = 0
    Private pTotalTransDiscount As Double = 0







    Private Sub btnAddRequestItem_Click(sender As Object, e As EventArgs) Handles btnAddRequestItem.Click
        'Condition
        If (ddVoucherType.SelectedIndex = 0 Or String.IsNullOrEmpty(txtItemAmount.Text) Or txtItemAmount.Text = "0") Then
            MetroMessageBox.Show(Me, "Required Input needed.", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            addRequestItemToDataGrid()
            clearRequestItems()
        End If

    End Sub

    Private Sub frmDebitMemoRequest_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' AutoSearchItem()
        LoadVoucherType()
        LoadSupplierList()
        LoadCompanyList()

        generateSeriesNumber()

        dtRequest.Text = oSystem.GET_SERVER_DATE_TIME


        txtTotalDiscount1.Text = "0"
        txtTotalDiscount2.Text = "0"
        ' InitAutoSearch()


    End Sub


#Region "Local Function"

    Private Sub AutoSearchItem(ByVal dc As AutoCompleteStringCollection)
        Dim dt As New DataTable
        dt = oItem.GET_ITEM_LIST()

        For Each row As DataRow In dt.Rows
            dc.Add(row(1).ToString())
        Next

    End Sub

    Private Sub SearchData(ByVal inputSearch As String)
        Dim dt As New DataTable

        'dt = oInventory.GET_PRODUCT_LIST
        dt = oItem.GET_ITEM_LIST()
        Dim dv As DataView = dt.DefaultView

        dv.RowFilter = "ItemDescription like '%" & inputSearch & "%'"

    End Sub

    Private Sub generateSeriesNumber()
        lblVoucherSeries.Text = oSystem.GENERATE_SERIES_NUMBER("CV")
    End Sub

    Private Sub addRequestItemToDataGrid()


        With dgVoucherItemList
            .ColumnCount = 5
            .Columns(0).Name = "Item Description"
            .Columns(1).Name = "Amount"
            .Columns(2).Name = "Discount"
            .Columns(3).Name = "Image Location"
            .Columns(4).Name = "Attach"
        End With

        Dim btn As New DataGridViewButtonColumn()
        dgVoucherItemList.Columns.Add(btn)
        btn.HeaderText = "Remove"
        btn.Text = "X"
        btn.Name = "btn"
        btn.UseColumnTextForButtonValue = True

        Dim fName As String

        If (pbAttachment.ImageLocation Is Nothing) Then
            fName = "images/x1.png"
        Else
            fName = pbAttachment.ImageLocation
        End If

        'Dim itemAmount As Double = Double.Parse(nudQuantity.Value * txtItemAmount.Text)

        Dim row As String() = New String() {txtDescription.Text, txtItemAmount.Text, txtItemDiscount.Text, fName, lblFileName.Text}
        dgVoucherItemList.Rows.Add(row)

        computeTotalPrice()


    End Sub


    Private Sub dgRequestList_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        If e.ColumnIndex = 8 Then
            'Confirmation
            If (MetroMessageBox.Show(Me, "Are you sure you want to remove selected item?", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes) Then
                'REMOVE Selected Item
                removeSelectedItem()
                computeTotalPrice()
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub LoadVoucherType()
        Dim dt As DataTable = oUtility.GET_VOUCHER_TYPE


        Dim dr As DataRow = dt.NewRow()
        dr("Voucher_Type_Description") = "---Select Voucher Type---"
        dr("VoucherTypeCode") = 0
        dt.Rows.InsertAt(dr, 0)

        With ddVoucherType
            .DataSource = dt
            .DisplayMember = dt.Columns("Voucher_Type_Description").ToString()
            .ValueMember = dt.Columns("VoucherTypeCode").ToString()

        End With




    End Sub

    Private Sub LoadSupplierList()
        Dim dt As DataTable = oUtility.GET_SUPPLIERS()

        Dim dr As DataRow = dt.NewRow()
        dr("Supplier_Name") = "--Select Supplier / Payee---"
        dr("SupplierID") = 0
        dt.Rows.InsertAt(dr, 0)

        With ddSupplier_Payee
            .DataSource = dt
            .DisplayMember = dt.Columns("Supplier_Name").ToString()
            .ValueMember = dt.Columns("SupplierID").ToString()

        End With




    End Sub



    Private Sub LoadCompanyList()
        Dim dt As DataTable = oSystem.GET_COMPANY_DATA()

        Dim dr As DataRow = dt.NewRow()
        dr("Company_Name") = "--Select Company---"
        dr("CompanyCode") = 0
        dt.Rows.InsertAt(dr, 0)

        With ddCompany
            .DataSource = dt
            .DisplayMember = dt.Columns("Company_Name").ToString()
            .ValueMember = dt.Columns("CompanyCode").ToString()

        End With



    End Sub

    Private Sub clearRequestItems()

        txtItemAmount.Text = "0"
        txtItemDiscount.Text = "0"
        txtDescription.Text = ""

        pbAttachment.ImageLocation = Nothing
        lblFileName.Text = ""
    End Sub


    Private Sub computeTotalPrice()
        Dim total As Double
        Dim itemDiscountTotal As Double
        'Dim totalItems As Integer
        For i As Integer = 0 To dgVoucherItemList.RowCount - 1
            total += Double.Parse(dgVoucherItemList.Rows(i).Cells(1).Value)
            'totalItems += Integer.Parse(dgRequestList.Rows(i).Cells(2).Value)
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
            itemDiscountTotal += Double.Parse(dgVoucherItemList.Rows(i).Cells(2).Value)
        Next

        lblTotalItemDiscount.Text = itemDiscountTotal.ToString()

        pTotalTransDiscount = Convert.ToDouble(txtTotalDiscount1.Text) + Convert.ToDouble(txtTotalDiscount2.Text)
        total = (total - itemDiscountTotal) - Convert.ToDouble(txtTotalDiscount1.Text) - Convert.ToDouble(txtTotalDiscount2.Text)


        'lblTotalItems.Text = totalItems.ToString()
        lblTotalAmount.Text = "Total Amount : " & String.Format("{0:n}", total)

    End Sub


    Private Sub removeSelectedItem()


        Dim index As Integer
        index = dgVoucherItemList.CurrentCell.RowIndex
        dgVoucherItemList.Rows.RemoveAt(index)

        computeTotalPrice()


    End Sub


    Private Function checkDuplicate(ByVal _dateRequest As DateTime, ByVal _supervisorID As Integer, ByVal _branchCode As String, ByVal _totalAmount As Double)
        Dim x As Boolean = False


        Return x
    End Function

#End Region



    Private Sub btnAttachImage_Click(sender As Object, e As EventArgs) Handles btnAttachImage.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image (*.jpg;*.png ) | *.jpg; *.png"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            pbAttachment.ImageLocation = opf.FileName
            lblFileName.Text = "Attachment: " & opf.FileName
        End If
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs) Handles btnProcess.Click

        'First Validation
        If Not ddCompany.SelectedIndex = 0 And Not ddSupplier_Payee.SelectedIndex = 0 Then

            If Not oDMR.CHECK_REQUEST_EXIST(Convert.ToDateTime(dtRequest.Value), Convert.ToInt32(ddSupplier_Payee.SelectedValue), ddCompany.SelectedValue, pTotalAmountPrice) Then


                'PROMPT CONFIRMATION
                If (MetroMessageBox.Show(Me, "Please Press (YES) to Confirm request?" & vbNewLine _
                                             & "Warning This request is not reversable after confirmation.", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then

                    If dgVoucherItemList.Rows.Count > 0 Then
                        'For i As Integer = 0 To dgVoucherItemList.RowCount - 1
                        '    'Dim sDMRNum As String = dgRequestList.Rows(i).Cells(0).Value.ToString()
                        '    Dim iItemID As Integer = Int32.Parse(dgVoucherItemList.Rows(i).Cells(7).Value)
                        '    Dim sItemDescription As String = dgVoucherItemList.Rows(i).Cells(0).Value.ToString()

                        '    Dim dQuantity As Double = Double.Parse(dgVoucherItemList.Rows(i).Cells(1).Value)
                        '    Dim dUnitPrice As Double = Double.Parse(dgVoucherItemList.Rows(i).Cells(2).Value)
                        '    Dim dAmount As Double = Double.Parse(dgVoucherItemList.Rows(i).Cells(3).Value)
                        '    Dim sPurposeRemarks As String = dgVoucherItemList.Rows(i).Cells(4).Value.ToString()

                        '    Dim bAttachment As Byte() = IO.File.ReadAllBytes(dgVoucherItemList.Rows(i).Cells(5).Value.ToString())

                        '    Dim fIsAttachment As Boolean
                        '    If String.IsNullOrEmpty(dgVoucherItemList.Rows(i).Cells(6).Value.ToString()) Then
                        '        fIsAttachment = False
                        '    Else
                        '        fIsAttachment = True
                        '    End If
                        '    'SAVE TO TABLE

                        '    oDMR.INSERT_DEBIT_MEMO_REQUEST(lblVoucherSeries.Text, ddCompany.SelectedValue, Convert.ToInt32(ddSupplier_Payee.SelectedValue), iItemID, sItemDescription, dQuantity, dUnitPrice,
                        '                               dAmount, pTotalAmountPrice, sPurposeRemarks, txtDocumentRemarks.Text, fIsAttachment, bAttachment, Convert.ToDateTime(dtRequest.Text), frmMain.tsUserCode.Text)

                        'Next

                        oVoucher.INSERT_VOUCHER(lblVoucherSeries.Text, ddVoucherType.SelectedValue, ddCompany.SelectedValue, Convert.ToDateTime(dtRequest.Text), Convert.ToInt32(ddSupplier_Payee.SelectedValue), Convert.ToDouble(txtTotalDiscount1.Text), Convert.ToDouble(txtTotalDiscount2.Text), "testUser")
                        oSystem.UPDATE_SERIES_NUMBER("CV")

                        MetroMessageBox.Show(Me, "Voucher successfully saved", "AGC Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        'pTotalAmountPrice = 0

                        'frmMain.countForApprovalDBR()
                        ''RELOAD FORM
                        'Controls.Clear()
                        'InitializeComponent()
                        'Show()
                        'generateSeriesNumber()
                        'LoadVoucherType()
                        'LoadSupplierList()

                    End If
                Else
                    MetroMessageBox.Show(Me, "No Request to Process", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    Exit Sub

                End If


            Else
                MetroMessageBox.Show(Me, "Request already exist.", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Exit Sub

            End If
        Else
            MetroMessageBox.Show(Me, "Branch and Supervisor required.", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End If
    End Sub




    Private Sub txtItemAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemAmount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtItemDiscount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemDiscount.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTotalDiscount1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalDiscount1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTotalDiscount2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalDiscount2.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtTotalDiscount1_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDiscount1.TextChanged
        Try
            computeTotalPrice()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtTotalDiscount2_TextChanged(sender As Object, e As EventArgs) Handles txtTotalDiscount2.TextChanged
        Try
            computeTotalPrice()

        Catch ex As Exception

        End Try
    End Sub
End Class