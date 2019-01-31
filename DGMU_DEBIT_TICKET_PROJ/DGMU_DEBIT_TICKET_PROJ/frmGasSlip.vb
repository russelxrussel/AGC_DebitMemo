Imports MetroFramework
Public Class frmGasSlip

    Dim oItem As New DMT_ITEM_C
    Dim oUtility As New UTILITY
    Dim oSystem As New DMT_SYSTEM_C
    Dim oDMR As New DMT_DEBITMEMO_C
    Dim oVoucher As New VOUCHER_C

    Dim oGS As New GASOLINESLIP_C

    Dim prevGSNumber As String








    Private Sub frmDebitMemoRequest_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' AutoSearchItem()
        defaultInit()



    End Sub


#Region "Local Function"

    Private Sub defaultInit()


        generateSeriesNumber()

        LoadDriverList()
        LoadPlateNumberList()

        dtCreated.Text = oSystem.GET_SERVER_DATE_TIME



    End Sub



    Private Sub generateSeriesNumber()
        lblGasSlipSeries.Text = oSystem.GENERATE_SERIES_NUMBER("DGMUV") & oSystem.GET_SERVER_DATE_TIME().Month.ToString() & oSystem.GET_SERVER_DATE_TIME().Day.ToString() & oSystem.GET_SERVER_DATE_TIME().Year.ToString() & "-GS"

    End Sub



    Private Sub LoadDriverList()
        Dim dt As DataTable = oGS.GET_DRIVER_LIST()


        Dim dr As DataRow = dt.NewRow()
        dr("DriverName") = "---Select Driver---"
        dr("DriverID") = 0
        dt.Rows.InsertAt(dr, 0)

        With ddDriverList
            .DataSource = dt
            .DisplayMember = dt.Columns("DriverName").ToString()
            .ValueMember = dt.Columns("DriverID").ToString()
        End With

    End Sub

    Private Sub LoadPlateNumberList()
        Dim dt As DataTable = oGS.GET_PLATENUMBER_LIST()


        Dim dr As DataRow = dt.NewRow()
        dr("PlateNumber") = "---Plate Number---"
        dr("PlateNumberID") = 0
        dt.Rows.InsertAt(dr, 0)

        With ddPlateNumber
            .DataSource = dt
            .DisplayMember = dt.Columns("PlateNumber").ToString()
            .ValueMember = dt.Columns("PlateNumberID").ToString()
        End With

    End Sub



    Private Sub clearRequestItems()
        txtProduct.Text = ""
        txtRemarks.Text = ""
        defaultInit()
        dtCreated.Focus()
    End Sub

    Private Sub btnProcess_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnProcess_Click_1(sender As Object, e As EventArgs) Handles btnProcess.Click
        'PROMPT CONFIRMATION
        If (MetroMessageBox.Show(Me, "Please Press (YES) to Confirm?" & vbNewLine _
                                             & "Warning This request is not reversable after confirmation.", "Gasoline Slip", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = Windows.Forms.DialogResult.Yes) Then
            oGS.INSERT_GASOLINESLIP(lblGasSlipSeries.Text, Convert.ToDateTime(dtCreated.Text), ddDriverList.SelectedValue, ddPlateNumber.SelectedValue, txtProduct.Text, txtRemarks.Text)
            ' prevGSNumber = lblGasSlipSeries.Text

            Dim frmReport As New repGasolineFormSlip

            'GET GASOLINE SLIP NUMBER FOR PRINTING
            frmReport.GASSLIPNUMBER = lblGasSlipSeries.Text
            frmReport.Show()

            clearRequestItems()
        Else
            MetroMessageBox.Show(Me, "Request cancelled.", "Gasoline Slip", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            Exit Sub

        End If
    End Sub

    Private Sub lnkReprintGasSlip_Click(sender As Object, e As EventArgs) Handles lnkReprintGasSlip.Click
        frmReprintGasSlip.Show()
    End Sub







#End Region







End Class