Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class repDMItemRequestMonitoring
    Dim oSystem As New DMT_SYSTEM_C
    Dim oUtil As New UTILITY

    Public _STATUSCODE As String

    Private Sub repDMTotalSummary_Load(sender As Object, e As EventArgs) Handles Me.Load

        displayReport()
    End Sub

    Private Sub displayReport()

        Dim RptDocument As New ReportDocument

        ' Dim reportPath As String = cmbReports.SelectedValue.ToString()

        If _STATUSCODE = "A" Then
            RptDocument.Load(Application.StartupPath & "\Reports\repDMRequestMonitoring_Approved.rpt")
        ElseIf _STATUSCODE = "F" Then
            RptDocument.Load(Application.StartupPath & "\Reports\repDMRequestMonitoring_ForApproval.rpt")
        ElseIf _STATUSCODE = "R" Then
            RptDocument.Load(Application.StartupPath & "\Reports\repDMRequestMonitoring_Reject.rpt")
        ElseIf _STATUSCODE = "P" Then
            RptDocument.Load(Application.StartupPath & "\Reports\repDMRequestMonitoring_Pending.rpt")
        End If


        'Set login info
        Dim myLogin As CrystalDecisions.Shared.TableLogOnInfo

        Dim myTable As Table
        For Each myTable In RptDocument.Database.Tables


            myLogin = myTable.LogOnInfo
            myLogin.ConnectionInfo.ServerName = "AGC_CON"
            myLogin.ConnectionInfo.DatabaseName = "AGC"
            myLogin.ConnectionInfo.UserID = "sa"
            myLogin.ConnectionInfo.Password = "p@ssw0rd"
            myTable.ApplyLogOnInfo(myLogin)
            myTable.Location = myTable.Location

            CrystalReportViewer1.ReportSource = RptDocument

            CrystalReportViewer1.Zoom(75%)
        Next

    End Sub



    Private Sub lnkPreview_Click(sender As Object, e As EventArgs)
        displayReport()
    End Sub
End Class