Public Class frmSupervisorMaintenance

    Dim oUtility As New UTILITY

    Dim oItem As New DMT_ITEM_C
    Private G_ACTION As Boolean = True
    Private G_ITEMID As Integer = 0

    Private Sub frmItemMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        LoadToCombo()

        Display_Supervisor_List()

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSaveSupervisor.Click
        'Create New Item

        If Not IsNothing(txtSupervisorName.Text) Then
            If (G_ACTION = False) Then
                'oItem.INSERT_NEW_ITEM(txtItemDescription.Text.ToUpper, cmbUOM.SelectedValue, cmbItemGroup.SelectedValue, frmMain.tsUserCode.Text)
                oUtility.INSERT_SUPERVISOR(txtSupervisorName.Text, "1")
                MsgBox("New Supervisor successfully created.", vbInformation)

            ElseIf (G_ACTION = True) Then
                'UPDATE
                ' oItem.UPDATE_ITEM(G_ITEMID, txtSupervisorName.Text.ToUpper, cmbUOM.SelectedValue, cmbItemGroup.SelectedValue, frmMain.tsUserCode.Text)
                MsgBox(txtSupervisorName.Text & " successfully updated!", vbInformation)

            End If

            gbCreateItem.Enabled = False
            clearInputs()
            dgSupervisorList.DataSource = oUtility.GET_SUPERVISORS
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

    Private Sub displaySupervisorForEdit(ByVal _supervisorID As Integer)
        Dim dt As New DataTable
        dt = oUtility.GET_SUPERVISORS
        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "SupervisorID = '" + _supervisorID.ToString() + "'"

        If (dv.Count > 0) Then
            For Each drv As DataRowView In dv
                txtSupervisorName.Text = drv("SupervisorName").ToString()
                'cmbItemGroup.SelectedValue = drv("ItemGroupCode").ToString()
                'cmbUOM.SelectedValue = drv("UomCode").ToString()

                gbCreateItem.Enabled = True


                G_ACTION = True
                '  G_ITEMID = _itemID

            Next
        End If
    End Sub

    Private Sub clearInputs()
        txtSupervisorName.Text = ""
        cmbUOM.SelectedIndex = 0
        cmbItemGroup.SelectedIndex = 0
    End Sub

    'Display list of Supervisor
    Private Sub Display_Supervisor_List()
        Dim dt As New DataTable
        dt = oUtility.GET_SUPERVISORS
        dt.DefaultView.Sort = "Supervisorname ASC"

        dgSupervisorList.DataSource = dt
    End Sub

#End Region

    Private Sub txtSearchSupervisor_TextChanged(sender As Object, e As EventArgs) Handles txtSearchSupervisor.TextChanged
        Dim dt As New DataTable
        dt = oUtility.GET_SUPERVISORS

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "SupervisorName like '%" + txtSearchSupervisor.Text + "%'"
        dv.Sort = "SupervisorName ASC"

        dgSupervisorList.DataSource = dv
    End Sub


    Private Sub dgSupervisorList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgSupervisorList.CellClick


        If e.ColumnIndex = 0 Then
            Dim i As Integer

            i = dgSupervisorList.CurrentRow.Index

            Dim supervisorID As Integer = dgSupervisorList.Item(1, i).Value

            displaySupervisorForEdit(supervisorID)
        End If

    End Sub

    Private Sub tsCreate_Click(sender As Object, e As EventArgs) Handles tsCreateSupervisor.Click
        gbCreateItem.Enabled = True
        clearInputs()
        G_ACTION = False
    End Sub
End Class