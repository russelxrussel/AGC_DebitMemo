Public Class frmItemMaintenance

    Dim oItem As New DMT_ITEM_C
    Private G_ACTION As Boolean = True
    Private G_ITEMID As Integer = 0

    Private Sub frmItemMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsItemList.spGET_DM_ITEM_LIST' table. You can move, or remove it, as needed.
        Me.SpGET_DM_ITEM_LISTTableAdapter2.Fill(Me.DsItemList.spGET_DM_ITEM_LIST)


        LoadToCombo()

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        'Create New Item

        If Not IsNothing(txtItemDescription.Text) And cmbItemGroup.SelectedIndex <> 0 And cmbUOM.SelectedIndex <> 0 Then
            If (G_ACTION = False) Then
                oItem.INSERT_NEW_ITEM(txtItemDescription.Text.ToUpper, cmbUOM.SelectedValue, cmbItemGroup.SelectedValue, frmMain.tsUserCode.Text)
                MsgBox("New Item successfully created.", vbInformation)
               
            ElseIf (G_ACTION = True) Then
                'UPDATE
                oItem.UPDATE_ITEM(G_ITEMID, txtItemDescription.Text.ToUpper, cmbUOM.SelectedValue, cmbItemGroup.SelectedValue, frmMain.tsUserCode.Text)
                MsgBox(txtItemDescription.Text & " successfully updated!", vbInformation)

            End If

            gbCreateItem.Enabled = False
            clearInputs()
            dgItemList.DataSource = Me.SpGET_DM_ITEM_LISTTableAdapter2.GetData_ItemList
        Else
            MsgBox("Required filled must fill up.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
    End Sub



#Region "USER DEFINED FUNCTIONS"
    'LOAD TO COMBO BOX

    Private Sub LoadToCombo()
        Dim dt As DataTable = oItem.GET_UOM_LIST

        Dim dr As DataRow = dt.NewRow()
        dr("uomDescription") = "---Select Measurement---"
        dr("uomCode") = 0
        dt.Rows.InsertAt(dr, 0)

        With cmbUOM
            .DataSource = dt
            .DisplayMember = dt.Columns("uomDescription").ToString()
            .ValueMember = dt.Columns("uomCode").ToString()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = 0

        End With

        Dim dt2 As DataTable = oItem.GET_GROUP_ITEM_LIST

        Dim dr2 As DataRow = dt2.NewRow()
        dr2("groupName") = "---Select Item Group---"
        dr2("ItemgroupCode") = 0
        dt2.Rows.InsertAt(dr2, 0)

        With cmbItemGroup
            .DataSource = dt2
            .DisplayMember = dt2.Columns("groupName").ToString()
            .ValueMember = dt2.Columns("ItemgroupCode").ToString()
            .AutoCompleteMode = AutoCompleteMode.SuggestAppend
            .AutoCompleteSource = AutoCompleteSource.ListItems
            .SelectedIndex = 0

        End With




    End Sub

    Private Sub displayItemForEdit(ByVal _itemID As Integer)
        Dim dt As New DataTable
        dt = Me.SpGET_DM_ITEM_LISTTableAdapter2.GetData_ItemList
        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "ItemID = '" + _itemID.ToString() + "'"

        If (dv.Count > 0) Then
            For Each drv As DataRowView In dv
                txtItemDescription.Text = drv("ItemDescription").ToString()
                cmbItemGroup.SelectedValue = drv("ItemGroupCode").ToString()
                cmbUOM.SelectedValue = drv("UomCode").ToString()

                gbCreateItem.Enabled = True


                G_ACTION = True
                G_ITEMID = _itemID

            Next
        End If
    End Sub

    Private Sub clearInputs()
        txtItemDescription.Text = ""
        cmbUOM.SelectedIndex = 0
        cmbItemGroup.SelectedIndex = 0
    End Sub
#End Region

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim dt As New DataTable
        dt = Me.SpGET_DM_ITEM_LISTTableAdapter2.GetData_ItemList

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "ItemDescription like '%" + txtSearch.Text + "%'"

        dgItemList.DataSource = dv
    End Sub


    Private Sub dgItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgItemList.CellClick


        If e.ColumnIndex = 0 Then
            Dim i As Integer

            i = dgItemList.CurrentRow.Index

            Dim itemID As Integer = dgItemList.Item(1, i).Value

            displayItemForEdit(itemID)
        End If

    End Sub

    Private Sub tsCreate_Click(sender As Object, e As EventArgs) Handles tsCreate.Click
        gbCreateItem.Enabled = True
        clearInputs()
        G_ACTION = False
    End Sub
End Class