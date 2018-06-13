Imports System.Data
Public Class LookUp_Item
    Dim oItem As New DMT_ITEM_C


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub


    Private Sub SearchData(ByVal inputSearch As String)
        Dim dt As New DataTable

        'dt = oInventory.GET_PRODUCT_LIST
        dt = oItem.GET_ITEM_LIST()
        Dim dv As DataView = dt.DefaultView

        dv.RowFilter = "ItemDescription like '%" & inputSearch & "%'"

        If (dv.Count > 0) Then
            dgItemList.DataSource = dv
        Else
            dgItemList.DataSource = dt

        End If

    End Sub

    Private Sub GetItemSelected()
        'frmDebitMemoRequest.txtItem.Text = dgItemList.SelectedCells.Item(1).Value
        Me.Dispose()
    End Sub

    Private Sub DisplayItemList()
        Dim dt As New DataTable

        dt = oItem.GET_ITEM_LIST()
        dgItemList.DataSource = dt
    End Sub

    Private Sub LookUp_Item_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtItemSearch.Focus()
        DisplayItemList()
    End Sub

    Private Sub txtItemSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtItemSearch.KeyPress
        If Asc(e.KeyChar) = 13 Then
            GetItemSelected()
        End If
    End Sub

   

  
    Private Sub txtItemSearch_TextChanged(sender As Object, e As EventArgs) Handles txtItemSearch.TextChanged
        SearchData(txtItemSearch.Text)
    End Sub

    Private Sub dgItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemList.CellClick
        GetItemSelected()
    End Sub

   

    Private Sub dgItemList_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dgItemList.KeyPress
        GetItemSelected()
    End Sub

End Class