'Imports System.Data
Imports MetroFramework
Public Class frmApprover
    Dim oDebitMemo As New DMT_DEBITMEMO_C()




    Private Sub frmApprover_Load(sender As Object, e As EventArgs) Handles Me.Load
      
        gpListOfRequest.Visible = False
        displayForApproval()

    End Sub




#Region "USER-DEFINED METHODS"
    Public Sub displayForApproval()
        Dim dt = New DataTable
        dt = oDebitMemo.GET_FOR_APPROVAL_DM()

        dgListOfDM.DataSource = dt

        'Dim btn As New DataGridViewButtonColumn()
        'dgListOfDM.Columns.Add(btn)
        'btn.HeaderText = "View Request"
        'btn.Text = "View"
        'btn.Name = "btn"
        'btn.UseColumnTextForButtonValue = True

    End Sub


    Private Sub validateDebitMemoHeader()
        Dim dt As New DataTable
        dt = oDebitMemo.GET_LIST_ITEM_FOR_APPROVAL(lblDebitMemoNumber.Text)

        Dim dv As New DataView
        dv = dt.DefaultView
        dv.RowFilter = "RequestStatus = '" + "P" + "' or RequestStatus='" + "F" + "'"

        If dv.Count > 0 Then
            'DO NOTHING
            Exit Sub
        Else
            'COMPLETE THE DEBIT MEMO HEADER
            oDebitMemo.UPDATE_DEBITMEMO_HEADER(lblDebitMemoNumber.Text)
        End If
    End Sub
#End Region

    Private Sub dgListOfDM_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListOfDM.CellClick
        Dim dt2 As New DataTable
        dt2 = oDebitMemo.GET_REQUEST_STATUS_LIST()





        gpDMRequest.Visible = False
        gpListOfRequest.Visible = True

        Dim i As Integer

        i = dgListOfDM.CurrentRow.Index

        Dim sDMRNum As String = dgListOfDM.Item(0, i).Value
        Dim sDate As String = dgListOfDM.Item(1, i).Value
        Dim sBranch As String = dgListOfDM.Item(2, i).Value
        Dim sSupervisor As String = dgListOfDM.Item(3, i).Value
        Dim sRequesteeNotes As String = dgListOfDM.Item(4, i).Value
        'gbDMRDetails.Text = "Debit Memo Number: " & sDMRNum

        lblDebitMemoNumber.Text = sDMRNum
        lblRequestDate.Text = sDate
        lblBranch.Text = sBranch
        lblSupervisor.Text = sSupervisor
        txtRequesteeNotes.Text = sRequesteeNotes

        Dim dt As New DataTable
        dt = oDebitMemo.GET_LIST_ITEM_FOR_APPROVAL(sDMRNum)
        dgListOfRequestItems.DataSource = dt

        Me.dgListOfRequestItems.Columns("ID").Visible = False
        Me.dgListOfRequestItems.Columns("RequestStatus").Visible = False


        Dim cmbDecision As New DataGridViewComboBoxColumn()
        dgListOfRequestItems.Columns.Add(cmbDecision)
        With cmbDecision
            .HeaderText = "Decision"
            .DataSource = dt2
            .DisplayMember = dt2.Columns("RequestDescription").ToString()
            .ValueMember = dt2.Columns("RequestStatus").ToString()
        End With

        If dgListOfRequestItems.Rows.Count > 0 Then
            For x As Integer = 0 To dgListOfRequestItems.RowCount - 1
                'Dim sDMRNum As String = dgRequestList.Rows(i).Cells(0).Value.ToString()
                dgListOfRequestItems.Rows(x).Cells(7).Value = "P"
            Next
        End If

        computeTotalAmountRequest()




    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Confirmation
        If (MetroMessageBox.Show(Me, "Are you sure you want to cancel approval process?", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then
            ''REMOVE Selected Item
            ''removeSelectedItem()
            ''computeTotalPrice()
            'gpDMRequest.Visible = True
            'gpListOfRequest.Visible = False
            'RELOAD FORM
            Controls.Clear()
            InitializeComponent()
            Show()
            gpListOfRequest.Visible = False
            displayForApproval()
        Else
            Exit Sub
        End If


    End Sub

    Private Sub chkApprovedAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkApprovedAll.CheckedChanged
        If chkApprovedAll.Checked = True Then
            If dgListOfRequestItems.Rows.Count > 0 Then
                For i As Integer = 0 To dgListOfRequestItems.RowCount - 1
                    dgListOfRequestItems.Rows(i).Cells(7).Value = "A"
                Next
            End If

        Else
            If dgListOfRequestItems.Rows.Count > 0 Then
                For i As Integer = 0 To dgListOfRequestItems.RowCount - 1
                    dgListOfRequestItems.Rows(i).Cells(7).Value = "P"
                Next
            End If
        End If

    End Sub

    Private Sub btnProcessDecision_Click(sender As Object, e As EventArgs) Handles btnProcessDecision.Click
        If dgListOfRequestItems.Rows.Count > 0 Then
            If (MetroMessageBox.Show(Me, "Confirm your decision?", "Debit Memo Request", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes) Then

                For i As Integer = 0 To dgListOfRequestItems.RowCount - 1

                    Dim id As Integer = dgListOfRequestItems.Rows(i).Cells(0).Value
                    Dim requeststatus = dgListOfRequestItems.Rows(i).Cells(7).Value.ToString()


                    'UPDATE ALL REQUEST ITEM STATUS
                    oDebitMemo.UPDATE_APPROVAL_DECISION(lblDebitMemoNumber.Text, requeststatus, id, txtApproverNotes.Text, frmMain.tsUserCode.Text)


                Next

                'VALIDATE DEBIT MEMO HEADER 
                validateDebitMemoHeader()

                frmMain.countForApprovalDBR()
                frmMain.DISPLAY_STAT_COUNT()
                Controls.Clear()
                InitializeComponent()
                Show()
                gpListOfRequest.Visible = False
                displayForApproval()
            Else
                Exit Sub
            End If
        End If
    End Sub




    Private Sub lnkViewAttachment_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkViewAttachment.LinkClicked
        frmViewAttachment.lblDMRNum.Text = lblDebitMemoNumber.Text
        frmViewAttachment.ShowDialog()
    End Sub

    Private Sub computeTotalAmountRequest()
        Dim total As Double
        'Dim totalItems As Integer
        For i As Integer = 0 To dgListOfRequestItems.RowCount - 1
            total += Double.Parse(dgListOfRequestItems.Rows(i).Cells(4).Value)
            'totalItems += Integer.Parse(dgListOfRequestItems.Rows(i).Cells(2).Value)
            'Change the number 2 to your column index number (The first column has a 0 index column)
            'In this example the column index of Price is 2
        Next

        'lblTotalItems.Text = totalItems.ToString()
        lblTotalAmount.Text = String.Format("{0:n}", total)
    End Sub
End Class