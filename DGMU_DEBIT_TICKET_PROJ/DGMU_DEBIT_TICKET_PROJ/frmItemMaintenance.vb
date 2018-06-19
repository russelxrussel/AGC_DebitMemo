Public Class frmItemMaintenance

    Dim oItem As New DMT_ITEM_C
    Dim oUtil As New UTILITY

    Private G_ACTION_ITEM As Boolean = True
    Private G_ITEMID As Integer = 0

    Private G_ACTION_UOM As Boolean = True
    Private G_UOMID As Integer = 0



    Private Sub frmItemMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsItemList.spGET_DM_ITEM_LIST' table. You can move, or remove it, as needed.
        ' Me.SpGET_DM_ITEM_LISTTableAdapter2.Fill(Me.DsItemList.spGET_DM_ITEM_LIST)
        displayItemList()

        LoadToCombo()

        'UOM LIST
        displayUOMList()

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        'Create New Item
        If Not IsNothing(txtItemDescription.Text) And cmbItemGroup.SelectedIndex <> 0 And cmbUOM.SelectedIndex <> 0 Then
            If (G_ACTION_ITEM = False) Then
                oItem.INSERT_NEW_ITEM(txtItemDescription.Text.ToUpper, cmbUOM.SelectedValue, cmbItemGroup.SelectedValue, frmMain.tsUserCode.Text)
                MsgBox("New Item successfully created.", vbInformation)

            ElseIf (G_ACTION_ITEM = True) Then
                'UPDATE
                oItem.UPDATE_ITEM(G_ITEMID, txtItemDescription.Text.ToUpper, cmbUOM.SelectedValue, cmbItemGroup.SelectedValue, frmMain.tsUserCode.Text)
                MsgBox(txtItemDescription.Text & " successfully updated!", vbInformation)

            End If

            gbCreateItem.Enabled = False
            clear_Item_Inputs()
            displayItemList()
        Else
            MsgBox("Required filled must fill up.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
    End Sub



#Region "USER DEFINED FUNCTIONS"
    'LOAD TO COMBO BOX

    Private Sub LoadToCombo()
        Dim dt As DataTable = oUtil.GET_UOM_LIST

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

        Dim dt2 As DataTable = oUtil.GET_GROUP_ITEM_LIST

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

    Private Sub displayItemList()
        Dim dt As New DataTable
        dt = oItem.GET_ITEM_LIST
        dgItemList.DataSource = dt

    End Sub

    Private Sub displayItemForEdit(ByVal _itemID As Integer)
        Dim dt As New DataTable
        dt = oItem.GET_ITEM_LIST
        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "ItemID = '" + _itemID.ToString() + "'"

        If (dv.Count > 0) Then
            For Each drv As DataRowView In dv
                txtItemDescription.Text = drv("ItemDescription").ToString()
                cmbItemGroup.SelectedValue = drv("ItemGroupCode").ToString()
                cmbUOM.SelectedValue = drv("UomCode").ToString()

                gbCreateItem.Enabled = True


                G_ACTION_ITEM = True
                G_ITEMID = _itemID

            Next
        End If
    End Sub

    Private Sub displayUOMForEdit(ByVal _UOMID As Integer)
        Dim dt As New DataTable
        dt = oUtil.GET_UOM_LIST
        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "uomId = '" + _UOMID.ToString() + "'"

        If (dv.Count > 0) Then
            For Each drv As DataRowView In dv


                txtUOMCode.Text = drv("UOMCode").ToString()
                txtUOMName.Text = drv("UOMDescription").ToString()
                txtUOMCode.Enabled = False
                gbUOMDataEntry.Enabled = True
                txtUOMName.Focus()

                G_ACTION_UOM = True
                G_UOMID = _UOMID

            Next
        End If
    End Sub

    Private Sub clear_Item_Inputs()
        txtItemDescription.Text = ""
        cmbUOM.SelectedIndex = 0
        cmbItemGroup.SelectedIndex = 0
    End Sub

    Private Sub clear_UOM_Inputs()
        txtUOMCode.Text = ""
        txtUOMName.Text = ""
    End Sub

    Private Sub displayUOMList()
        Dim dt As New DataTable
        dt = oUtil.GET_UOM_LIST()

        dgUOMList.DataSource = dt
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
        clear_Item_Inputs()
        G_ACTION_ITEM = False
        txtItemDescription.Focus()
    End Sub

    Private Sub dgUOMList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUOMList.CellClick
        If e.ColumnIndex = 0 Then
            Dim i As Integer

            i = dgUOMList.CurrentRow.Index

            Dim UomID As Integer = dgUOMList.Item(1, i).Value

            displayUOMForEdit(UomID)
        End If
    End Sub

    Private Sub tsCreateUOM_Click(sender As Object, e As EventArgs) Handles tsCreateUOM.Click
        gbUOMDataEntry.Enabled = True
        txtUOMCode.Enabled = True
        txtUOMCode.Focus()
        G_ACTION_UOM = False
        txtItemDescription.Focus()
        clear_UOM_Inputs()
    End Sub

    Private Sub tsSaveUOM_Click(sender As Object, e As EventArgs) Handles tsSaveUOM.Click
        'Create New UOM
        If Not IsNothing(txtUOMCode.Text) And Not IsNothing(txtUOMName.Text) Then
            If (G_ACTION_UOM = False) Then
                oUtil.INSERT_UOM(txtUOMCode.Text, txtUOMName.Text, "1")
                'oItem.INSERT_NEW_ITEM(txtItemDescription.Text.ToUpper, cmbUOM.SelectedValue, cmbItemGroup.SelectedValue, frmMain.tsUserCode.Text)
                MsgBox("New Unit of Measurement successfully created.", vbInformation)

            ElseIf (G_ACTION_UOM = True) Then
                'UPDATE
                oUtil.UPDATE_UOM(G_UOMID, txtUOMName.Text, "1")
                MsgBox(txtUOMName.Text & " successfully updated!", vbInformation)

            End If

            gbUOMDataEntry.Enabled = False
            clear_UOM_Inputs()
            displayUOMList()
        Else
            MsgBox("Required filled must fill up.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
    End Sub
End Class