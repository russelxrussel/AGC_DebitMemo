Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class repDMTotalSummary
    Dim oSystem As New DMT_SYSTEM_C
    Dim oUtil As New UTILITY

    Private Sub repDMTotalSummary_Load(sender As Object, e As EventArgs) Handles Me.Load
        dtFrom.Text = oSystem.GET_SERVER_DATE_TIME
        dtTo.Text = oSystem.GET_SERVER_DATE_TIME


        loadReportsList()

        displayReport()
    End Sub

    Private Sub displayReport()
      
        Dim RptDocument As New ReportDocument

        Dim reportPath As String = cmbReports.SelectedValue.ToString()

        RptDocument.Load(Application.StartupPath & "\Reports\" & reportPath & ".rpt")


        Dim myRangeValue As New ParameterRangeValue
        myRangeValue.StartValue = Convert.ToDateTime(dtFrom.Text)
        myRangeValue.EndValue = Convert.ToDateTime(dtTo.Text)
        RptDocument.SetParameterValue("DateRange", myRangeValue)



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

    Private Sub loadReportsList()
        Dim dt As DataTable = oUtil.GET_REPORTS


    
        With cmbReports
            .DataSource = dt
            .DisplayMember = dt.Columns("reportDescription").ToString()
            .ValueMember = dt.Columns("reportFileName").ToString()
          
        End With

    End Sub

    Private Sub lnkPreview_Click(sender As Object, e As EventArgs) Handles lnkPreview.Click
        displayReport()
    End Sub
End Class