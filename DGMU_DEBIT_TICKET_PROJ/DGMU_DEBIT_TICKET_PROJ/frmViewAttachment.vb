Public Class frmViewAttachment
    Dim oDebitMemo As New DMT_DEBITMEMO_C



    Private Sub frmViewAttachment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        dt = oDebitMemo.GET_ATTACHMENT(lblDMRNum.Text)

        dgAttachment.DataSource = dt


    End Sub
End Class