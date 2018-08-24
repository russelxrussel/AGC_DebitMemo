Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class repDebitMemoApproved


    Private _debitNumber As String
    Private _cashier As String
    Public Property DEBIT_NUMBER() As String
        Get
            Return _debitNumber
        End Get
        Set(ByVal value As String)
            _debitNumber = value
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

        RptDocument.Load(Application.StartupPath & "\Reports\repApprovedDM.rpt")
        RptDocument.SetParameterValue("paramDMRNum", DEBIT_NUMBER)
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

        RptDocument.Load(Application.StartupPath & "\Reports\repApprovedDM.rpt")
        RptDocument.SetParameterValue("paramDMRNum", DEBIT_NUMBER)
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