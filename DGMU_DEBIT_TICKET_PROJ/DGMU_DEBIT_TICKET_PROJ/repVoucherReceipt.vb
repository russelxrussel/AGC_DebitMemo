Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class repVoucherReceipt


    Private _voucherNum As String
    Private _user As String
    Public Property VOUCHER_NUMBER() As String
        Get
            Return _voucherNum
        End Get
        Set(ByVal value As String)
            _voucherNum = value
        End Set
    End Property
    Public Property USERNAME() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property


    Private Sub repVoucherReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RptDocument As New ReportDocument

        RptDocument.Load(Application.StartupPath & "\Reports\repVoucher.rpt")
        RptDocument.SetParameterValue("paramVoucherNum", VOUCHER_NUMBER)


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
        Next

        ''PRINT now
        '' CrystalReportViewer1.PrintReport()

        'Dim prd As New System.Drawing.Printing.PrintDocument

        'RptDocument.PrintOptions.PrinterName = prd.PrinterSettings.PrinterName
        'RptDocument.PrintOptions.PaperSize = prd.PrinterSettings.DefaultPageSettings.PaperSize.RawKind
        'RptDocument.PrintToPrinter(1, False, 0, 0)
    End Sub
End Class