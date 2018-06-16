Public Class frmItemMaintenance

    Dim oItem As New DMT_ITEM_C


    Private Sub frmItemMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsItemList.spGET_DM_ITEM_LIST' table. You can move, or remove it, as needed.
        Me.SpGET_DM_ITEM_LISTTableAdapter.Fill(Me.DsItemList.spGET_DM_ITEM_LIST)

        LoadToCombo()
    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click
        If Not IsNothing(txtItemDescription.Text) Then
            oItem.INSERT_NEW_ITEM(txtItemDescription.Text.ToUpper, cmbUOM.Text, cmbItemGroup.Text, "1")
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
#End Region
End Class