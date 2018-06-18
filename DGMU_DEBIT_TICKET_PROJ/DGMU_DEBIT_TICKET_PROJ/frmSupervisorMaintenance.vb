Public Class frmSupervisorMaintenance

    Dim oUtility As New UTILITY

    Dim oItem As New DMT_ITEM_C
    Private G_ACTION As Boolean = True
    Private G_SUPERVISORID As Integer = 0

    Private Sub frmItemMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Display_Supervisor_List()

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSaveSupervisor.Click
        'Create New Item

        If Not IsNothing(txtSupervisorName.Text) Then
            If (G_ACTION = False) Then
                oUtility.INSERT_SUPERVISOR(txtSupervisorName.Text, frmMain.tsUserCode.Text)
                MsgBox("New Supervisor successfully created.", vbInformation)

            ElseIf (G_ACTION = True) Then
                'UPDATE
                oUtility.UPDATE_SUPERVISOR(G_SUPERVISORID, txtSupervisorName.Text, chkIsActive.Checked, frmMain.tsUserCode.Text)
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
                chkIsActive.Checked = Convert.ToBoolean(drv("IsActive"))
                gbCreateItem.Enabled = True


                G_ACTION = True
                G_SUPERVISORID = _supervisorID

            Next
        End If
    End Sub

    Private Sub clearInputs()
        txtSupervisorName.Text = ""
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
        txtSupervisorName.Focus()
        chkIsActive.Checked = True
    End Sub
End Class