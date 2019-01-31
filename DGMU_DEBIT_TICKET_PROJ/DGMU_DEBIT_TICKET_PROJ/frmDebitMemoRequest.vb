Imports MetroFramework
Public Class frmDebitMemoRequest

    Dim oItem As New DMT_ITEM_C
    Dim oUtility As New UTILITY
    Dim oSystem As New DMT_SYSTEM_C
    Dim oDMR As New DMT_DEBITMEMO_C

    Private rowIndex As Integer = 0
    Private pTotalAmountPrice As Double = 0






    Private Sub btnAddRequestItem_Click(sender As Object, e As EventArgs) Handles btnAddRequestItem.Click
        'Condition
        If (cmbItem.SelectedIndex = 0 Or String.IsNullOrEmpty(txtUnitPrice.Text) Or txtUnitPrice.Text = "0" Or nudQuantity.Value = 0) Then
            MetroMessageBox.Show(Me, "Required Input needed.", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub
        Else
            addRequestItemToDataGrid()
            clearRequestItems()
        End If

    End Sub

    Private Sub frmDebitMemoRequest_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' AutoSearchItem()
        LoadBranchList()
        LoadSupervisorList()
        LoadItemsList()

        generateSeriesNumber()

        dtRequest.Text = oSystem.GET_SERVER_DATE_TIME

        ' InitAutoSearch()

        'Hide text of filename
        lblFileName.Text = ""


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
        lblDMRSeries.Text = oSystem.GENERATE_SERIES_NUMBER("DM")
    End Sub

    Private Sub addRequestItemToDataGrid()


        With dgRequestList
            .ColumnCount = 8
            .Columns(0).Name = "Item Description"
            .Columns(1).Name = "Qty"
            .Columns(2).Name = "U_Price"
            .Columns(3).Name = "Amount"
            .Columns(4).Name = "Purpose / Remarks"
            .Columns(5).Name = "Image Location"
            .Columns(6).Name = "Attach"
            .Columns(7).Name = "ItemID"
        End With

        Dim btn As New DataGridViewButtonColumn()
        dgRequestList.Columns.Add(btn)
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

        Dim itemAmount As Double = Double.Parse(nudQuantity.Value * txtUnitPrice.Text)

        Dim row As String() = New String() {cmbItem.Text, nudQuantity.Value, txtUnitPrice.Text, itemAmount, txtOthers.Text, fName, lblFileName.Text, cmbItem.SelectedValue.ToString()}
        dgRequestList.Rows.Add(row)

        computeTotalPrice()


    End Sub


    Private Sub dgRequestList_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgRequestList.CellClick
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

    Private Sub LoadBranchList()
        Dim dt As DataTable = oUtility.GET_BRANCHES()


        Dim dr As DataRow = dt.NewRow()
        dr("BranchName") = "---Select Branch---"
        dr("BranchCode") = 0
        dt.Rows.InsertAt(dr, 0)

        With cmbBranch
            .DataSource = dt
            .DisplayMember = dt.Columns("BranchName").ToString()
            .ValueMember = dt.Columns("BranchCode").ToString()

        End With




    End Sub

    Private Sub LoadSupervisorList()
        Dim dt As DataTable = oUtility.GET_SUPERVISORS


        Dim dr As DataRow = dt.NewRow()
        dr("SupervisorName") = "--Select Supervisor---"
        dr("supervisorID") = 0
        dt.Rows.InsertAt(dr, 0)

        With cmbSupervisor
            .DataSource = dt
            .DisplayMember = dt.Columns("SupervisorName").ToString()
            .ValueMember = dt.Columns("supervisorID").ToString()

        End With




    End Sub

    Private Sub LoadItemsList()
        Dim dt As DataTable = oItem.GET_ITEM_LIST()


        Dim dr As DataRow = dt.NewRow()
        dr("ItemDescription") = "--Select Item---"
        dr("ItemID") = 0
        dt.Rows.InsertAt(dr, 0)

        With cmbItem
            .DataSource = dt
            .DisplayMember = dt.Columns("ItemDescription").ToString()
            .ValueMember = dt.Columns("ItemID").ToString()

        End With



    End Sub

    Private Sub clearRequestItems()
        cmbItem.SelectedIndex = 0
        nudQuantity.Value = 1
        txtUnitPrice.Text = "0"
        txtOthers.Text = ""

        pbAttachment.ImageLocation = Nothing
        cmbItem.Focus()
        lblFileName.Text = ""
    End Sub


    Private Sub computeTotalPrice()
        Dim total As Double
        'Dim totalItems As Integer
        For i As Integer = 0 To dgRequestList.RowCount - 1
            total += Double.Parse(dgRequestList.Rows(i).Cells(3).Value)
            'totalItems += Integer.Parse(dgRequestList.Rows(i).Cells(2).Value)
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2

        Next
        pTotalAmountPrice = total
        'lblTotalItems.Text = totalItems.ToString()
        lblTotalAmount.Text = "Total Amount : " & String.Format("{0:n}", total)

    End Sub


    Private Sub removeSelectedItem()


        Dim index As Integer
        index = dgRequestList.CurrentCell.RowIndex
        dgRequestList.Rows.RemoveAt(index)

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
        If Not cmbBranch.SelectedIndex = 0 And Not cmbSupervisor.SelectedIndex = 0 Then

            If Not oDMR.CHECK_REQUEST_EXIST(Convert.ToDateTime(dtRequest.Value), Convert.ToInt32(cmbSupervisor.SelectedValue), cmbBranch.SelectedValue, pTotalAmountPrice) Then


                'PROMPT CONFIRMATION
                If (MetroMessageBox.Show(Me, "Please Press (YES) to Confirm request?" & vbNewLine _
                                             & "Warning This request is not reversable after confirmation.", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then

                    If dgRequestList.Rows.Count > 0 Then
                        For i As Integer = 0 To dgRequestList.RowCount - 1
                            'Dim sDMRNum As String = dgRequestList.Rows(i).Cells(0).Value.ToString()
                            Dim iItemID As Integer = Int32.Parse(dgRequestList.Rows(i).Cells(7).Value)
                            Dim sItemDescription As String = dgRequestList.Rows(i).Cells(0).Value.ToString()

                            Dim dQuantity As Double = Double.Parse(dgRequestList.Rows(i).Cells(1).Value)
                            Dim dUnitPrice As Double = Double.Parse(dgRequestList.Rows(i).Cells(2).Value)
                            Dim dAmount As Double = Double.Parse(dgRequestList.Rows(i).Cells(3).Value)
                            Dim sPurposeRemarks As String = dgRequestList.Rows(i).Cells(4).Value.ToString()

                            Dim bAttachment As Byte() = IO.File.ReadAllBytes(dgRequestList.Rows(i).Cells(5).Value.ToString())

                            Dim fIsAttachment As Boolean
                            If String.IsNullOrEmpty(dgRequestList.Rows(i).Cells(6).Value.ToString()) Then
                                fIsAttachment = False
                            Else
                                fIsAttachment = True
                            End If
                            'SAVE TO TABLE

                            oDMR.INSERT_DEBIT_MEMO_REQUEST(lblDMRSeries.Text, cmbBranch.SelectedValue, Convert.ToInt32(cmbSupervisor.SelectedValue), iItemID, sItemDescription, dQuantity, dUnitPrice,
                                                       dAmount, pTotalAmountPrice, sPurposeRemarks, txtDocumentRemarks.Text, fIsAttachment, bAttachment, Convert.ToDateTime(dtRequest.Text), frmMain.tsUserCode.Text)

                        Next


                        oSystem.UPDATE_SERIES_NUMBER("DM")

                        MetroMessageBox.Show(Me, "Debit Memo Request successfully sent for approval", "Debit Memo", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        pTotalAmountPrice = 0

                        frmMain.countForApprovalDBR()
                        'RELOAD FORM
                        Controls.Clear()
                        InitializeComponent()
                        Show()
                        generateSeriesNumber()
                        LoadBranchList()
                        LoadSupervisorList()
                        LoadItemsList()
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


    Private Sub txtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnitPrice.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 46 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class