Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class repGasolineFormSlip

    Private _gasSlipNumber As String
    Private _cashier As String
    Public Property GASSLIPNUMBER() As String
        Get
            Return _gasSlipNumber
        End Get
        Set(ByVal value As String)
            _gasSlipNumber = value
        End Set
    End Property
    Public Property CASHIER() As String
        Get
            Return _cashier
        End Get
        Set(ByVal value As String)
            _cashier = value
        End Set
    End Property

    Private Sub repDebitMemoApproved_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim RptDocument As New ReportDocument

        RptDocument.Load(Application.StartupPath & "\Reports\repGasolineSlip.rpt")
        RptDocument.SetParameterValue("paramGSNum", GASSLIPNUMBER)
        'RptDocument.SetParameterValue("Cashier", CASHIER)


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

    Private Sub lnkPrint_Click(sender As Object, e As EventArgs) Handles lnkPrint.Click
        Dim RptDocument As New ReportDocument

        RptDocument.Load(Application.StartupPath & "\Reports\repGasolineSlip.rpt")
        RptDocument.SetParameterValue("paramGSNum", GASSLIPNUMBER)
        'RptDocument.SetParameterValue("Cashier", CASHIER)


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



        'PRINT now
        ' CrystalReportViewer1.PrintReport()

        Dim prd As New System.Drawing.Printing.PrintDocument

        RptDocument.PrintOptions.PrinterName = prd.PrinterSettings.PrinterName
        RptDocument.PrintOptions.PaperSize = prd.PrinterSettings.DefaultPageSettings.PaperSize.RawKind
        RptDocument.PrintToPrinter(1, False, 0, 0)

    End Sub
End Class