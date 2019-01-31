Public Class frmReprintGasSlip
    Dim oGS As New GASOLINESLIP_C
    Dim sGSNum As String
    Private Sub dgGasolineSlipList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgGasolineSlipList.CellClick
        Dim i As Integer

        i = dgGasolineSlipList.CurrentRow.Index

        sGSNum = dgGasolineSlipList.Item(0, i).Value

    End Sub

    Private Sub frmReprintGasSlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt = New DataTable
        dt = oGS.GET_GASOLINE_SLIP_OPEN_LIST

        dgGasolineSlipList.DataSource = dt

    End Sub

    Private Sub lnkReprintGasSlip_Click(sender As Object, e As EventArgs) Handles lnkReprintGasSlip.Click
        Dim frmReport As New repGasolineFormSlip

        'GET GASOLINE SLIP NUMBER FOR PRINTING
        frmReport.GASSLIPNUMBER = sGSNum
        frmReport.Show()
    End Sub
End Class