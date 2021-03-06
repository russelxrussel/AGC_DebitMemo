﻿Public Class frmMain

    Dim oDBR As New DMT_DEBITMEMO_C()
    Dim oVoucher As New VOUCHER_C
    Private _accessType As String

    Public Property ACCESSTYPE() As String
        Get
            Return _accessType
        End Get
        Set(ByVal value As String)
            _accessType = value
        End Set
    End Property

    Private Sub lnkDBR_Click(sender As Object, e As EventArgs) Handles lnkDBR.Click

        With frmDebitMemoRequest
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmDebitMemoRequest.Show()
        Me.scPage.Panel2.Controls.Add(frmDebitMemoRequest)
        frmDebitMemoRequest.BringToFront()


    End Sub


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load


        Label1.Text = "Operating System: " & My.Computer.Info.OSFullName.ToString() & vbCrLf &
                      "Product : " & My.Application.Info.Description.ToString & vbCrLf &
                      "Registered to: " & My.Application.Info.CompanyName.ToString() & vbCrLf &
                      "Copyright: " & My.Application.Info.Copyright.ToString() & vbCrLf &
                      "System Version: " & My.Application.Info.Version.ToString


        countForApprovalDBR()

        countApproveDBR_ForPosting()

        countForDispatchDBR()

        countForVoucherPayment()

        tsCalendar.Text = DateTime.Now.ToShortDateString

        DISPLAY_STAT_COUNT()


        ControlUserAccess()
    End Sub

    Private Sub lnkApproval_Click(sender As Object, e As EventArgs) Handles lnkApproval.Click
        With frmApprover
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmApprover.Show()
        Me.scPage.Panel2.Controls.Add(frmApprover)
        frmApprover.BringToFront()
    End Sub

    Private Sub lnkLogOut_Click(sender As Object, e As EventArgs) Handles lnkLogOut.Click
        'Me.Close()
        'Login.ShowDialog()
        Application.Exit()
    End Sub

    Public Sub countForApprovalDBR()

        'Dim i As Integer = countDebitMemoStatus("IsCompleted = 0")
        Dim i As Integer = oDBR.GET_FOR_APPROVAL()
        If i <> 0 Then

            lnkApproval.Text = "Approval Request (" + i.ToString + ")"
        Else
            lnkApproval.Text = "Approval Request"
        End If

    End Sub
    Public Sub countApproveDBR_ForPosting()
        'Dim i As Integer = countDebitMemoStatus("IsPosted = 0 and IsCompleted = 1 and usercode = '" + tsUserCode.Text + "'")
        Dim i As Integer = oDBR.GET_APPROVED_STATUS_COUNT_PER_USER(tsUserCode.Text)
        If i <> 0 Then

            lnkMyRequest.Text = "My Request (" + i.ToString + ")"
        Else
            lnkMyRequest.Text = "My Request"
        End If
    End Sub


    Public Sub countForDispatchDBR()
        Dim i As Integer = oDBR.GET_FOR_DISPATCH_COUNT_PER_USER(tsUserCode.Text)
        ' countDebitMemoStatus("Isposted = 1 and IsCompleted = 1 and IsDispatch = 0")
        If i <> 0 Then
            lnkDispatching.Text = "For Dispatch (" + i.ToString + ")"
        Else
            lnkDispatching.Text = "For Dispatch"
        End If
    End Sub

    Public Function countDebitMemoStatus(ByVal strQuery As String) As Integer
        Dim i As Integer

        Dim dt As New DataTable

        dt = oDBR.GET_ALL_REQUEST_LIST()

        Dim dv As DataView = dt.DefaultView

        dv.RowFilter = strQuery
        i = dv.Count

        Return i
    End Function

    Public Function countVoucherPaymentRequest(ByVal strQuery As String) As Integer
        Dim i As Integer

        Dim dt As New DataTable

        dt = oVoucher.GET_VOUCHER_LIST()

        Dim dv As DataView = dt.DefaultView

        dv.RowFilter = strQuery
        i = dv.Count

        Return i
    End Function

    Public Sub DISPLAY_STAT_COUNT()
        'Dim dt As New DataTable
        'dt = oDBR.GET_ALL_REQUEST_ITEM

        'lblTotalDebitRequest.Text = dt.Rows.Count.ToString()

        ''Approve
        'Dim dvApprove As DataView = dt.DefaultView
        'dvApprove.RowFilter = "RequestStatus = '" + "A" + "'"
        'lblTotalApproveCount.Text = dvApprove.Count.ToString()

        ''Pending
        'Dim dvPending As DataView = dt.DefaultView
        'dvPending.RowFilter = "RequestStatus = '" + "P" + "'"
        'lblTotalPendingCount.Text = dvPending.Count.ToString()

        ''On Process
        'Dim dvOnProcess As DataView = dt.DefaultView
        'dvOnProcess.RowFilter = "RequestStatus = '" + "F" + "'"
        'lblOnProcessCount.Text = dvOnProcess.Count.ToString()

        ''Reject
        'Dim dvReject As DataView = dt.DefaultView
        'dvReject.RowFilter = "RequestStatus = '" + "R" + "'"
        'lblTotalRejectCount.Text = dvReject.Count.ToString()

        lblTotalApproveCount.Text = oDBR.GET_STATUS_COUNT("A").ToString()
        lblTotalPendingCount.Text = oDBR.GET_STATUS_COUNT("P").ToString()
        lblOnProcessCount.Text = oDBR.GET_STATUS_COUNT("F").ToString()
        lblTotalRejectCount.Text = oDBR.GET_STATUS_COUNT("R").ToString()


        lblTotalDebitRequest.Text = oDBR.GET_TOTA_ITEM_COUNT().ToString()
    End Sub

    Public Sub countForVoucherPayment()
        'Dim i As Integer = countDebitMemoStatus("IsPosted = 0 and IsCompleted = 1 and usercode = '" + tsUserCode.Text + "'")
        Dim i As Integer = countVoucherPaymentRequest("IsOpen = 1 and IsClose = 0")
        If i <> 0 Then

            lnkVoucherPaymentRequest.Text = " Voucher Payment (" + i.ToString + ")"
        Else
            lnkVoucherPaymentRequest.Text = " Voucher Payment"
        End If
    End Sub

    Private Sub lnkMyRequest_Click(sender As Object, e As EventArgs) Handles lnkMyRequest.Click
        With frmMyDMRequest
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmMyDMRequest.Show()
        Me.scPage.Panel2.Controls.Add(frmMyDMRequest)
        frmMyDMRequest.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tsTime.Text = DateTime.Now.ToLongTimeString
    End Sub


    Private Sub ControlUserAccess()
        If (ACCESSTYPE = "O") Then
            lnkApproval.Visible = False
            lnkApproveDMList.Visible = False
        End If
    End Sub




    Private Sub lnkReports_Click(sender As Object, e As EventArgs) Handles lnkReports.Click
        Dim frmReport As New repDMTotalSummary
        frmReport.Show()
    End Sub

    Private Sub lnkMaintenance_Click(sender As Object, e As EventArgs) Handles lnkMaintenance.Click
        With frmItemMaintenance
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmItemMaintenance.Show()
        Me.scPage.Panel2.Controls.Add(frmItemMaintenance)
        frmItemMaintenance.BringToFront()
    End Sub

    Private Sub lnkPersonnelMaintenance_Click(sender As Object, e As EventArgs) Handles lnkPersonnelMaintenance.Click
        With frmSupervisorMaintenance
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmSupervisorMaintenance.Show()
        Me.scPage.Panel2.Controls.Add(frmSupervisorMaintenance)
        frmSupervisorMaintenance.BringToFront()
    End Sub

    Private Sub lnkDispatching_Click(sender As Object, e As EventArgs) Handles lnkDispatching.Click
        With frmDMDispatch
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmDMDispatch.Show()
        Me.scPage.Panel2.Controls.Add(frmDMDispatch)
        frmDMDispatch.BringToFront()
    End Sub

    Private Sub lblOnProcessCount_Click(sender As Object, e As EventArgs) Handles lblOnProcessCount.Click
        repDMItemRequestMonitoring._STATUSCODE = "F"

        With repDMItemRequestMonitoring
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        repDMItemRequestMonitoring.Show()
        Me.scPage.Panel2.Controls.Add(repDMItemRequestMonitoring)
        repDMItemRequestMonitoring.BringToFront()
    End Sub

    Private Sub lblTotalApproveCount_Click(sender As Object, e As EventArgs) Handles lblTotalApproveCount.Click
        repDMItemRequestMonitoring._STATUSCODE = "A"

        With repDMItemRequestMonitoring
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        repDMItemRequestMonitoring.Show()
        Me.scPage.Panel2.Controls.Add(repDMItemRequestMonitoring)
        repDMItemRequestMonitoring.BringToFront()
    End Sub

    Private Sub lblTotalPendingCount_Click(sender As Object, e As EventArgs) Handles lblTotalPendingCount.Click
        repDMItemRequestMonitoring._STATUSCODE = "P"

        With repDMItemRequestMonitoring
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        repDMItemRequestMonitoring.Show()
        Me.scPage.Panel2.Controls.Add(repDMItemRequestMonitoring)
        repDMItemRequestMonitoring.BringToFront()
    End Sub

    Private Sub lblTotalRejectCount_Click(sender As Object, e As EventArgs) Handles lblTotalRejectCount.Click
        repDMItemRequestMonitoring._STATUSCODE = "R"

        With repDMItemRequestMonitoring
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        repDMItemRequestMonitoring.Show()
        Me.scPage.Panel2.Controls.Add(repDMItemRequestMonitoring)
        repDMItemRequestMonitoring.BringToFront()
    End Sub

    Private Sub lnkCreateVoucher_Click(sender As Object, e As EventArgs) Handles lnkCreateVoucher.Click
        With frmVoucherModule
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmVoucherModule.Show()
        Me.scPage.Panel2.Controls.Add(frmVoucherModule)
        frmVoucherModule.BringToFront()
    End Sub

    Private Sub lnkVoucherList_Click(sender As Object, e As EventArgs) Handles lnkVoucherList.Click
        With frmVoucherList
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmVoucherList.Show()
        Me.scPage.Panel2.Controls.Add(frmVoucherList)
        frmVoucherList.BringToFront()
    End Sub

    Private Sub lnkVoucherPaymentRequest_Click(sender As Object, e As EventArgs) Handles lnkVoucherPaymentRequest.Click
        With frmVoucherPaymentRequest
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmVoucherPaymentRequest.Show()
        Me.scPage.Panel2.Controls.Add(frmVoucherPaymentRequest)
        frmVoucherPaymentRequest.BringToFront()
    End Sub

    Private Sub lnkChangePassword_Click(sender As Object, e As EventArgs) Handles lnkChangePassword.Click
        With frmUserModification
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmUserModification.Show()
        Me.scPage.Panel2.Controls.Add(frmUserModification)
        frmUserModification.BringToFront()
    End Sub

    Private Sub lnkApproveDMList_Click(sender As Object, e As EventArgs) Handles lnkApproveDMList.Click
        With frmApproveDMList
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmApproveDMList.Show()
        Me.scPage.Panel2.Controls.Add(frmApproveDMList)
        frmApproveDMList.BringToFront()
    End Sub

    Private Sub lnkGasolineSlip_Click(sender As Object, e As EventArgs) Handles lnkGasolineSlip.Click
        With frmGasSlip
            .TopLevel = False
            .Left = 0
            .Top = 0
        End With

        frmGasSlip.Show()
        Me.scPage.Panel2.Controls.Add(frmGasSlip)
        frmGasSlip.BringToFront()
    End Sub
End Class