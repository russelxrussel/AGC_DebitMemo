Public Class frmItemMaintenance

    Dim oItem As New DMT_ITEM_C


    Private Sub frmItemMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If Not IsNothing(txtItemDescription.Text) Then
            oItem.INSERT_NEW_ITEM(txtItemDescription.Text.ToUpper, cmbUOM.Text, cmbItemGroup.Text, "1")
        End If
    End Sub



#Region "USER DEFINED FUNCTIONS"
   
#End Region
End Class