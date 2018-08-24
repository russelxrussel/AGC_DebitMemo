Public Class frmCompanyMaintenance

    Dim oUtility As New UTILITY
    Dim oSystem As New DMT_SYSTEM_C

    Dim oItem As New DMT_ITEM_C
    Private G_ACTION As Boolean = True

    Private G_ACTION_COMPANY As Boolean = True

    Private G_SUPERVISORID As Integer = 0

    Private Sub frmItemMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Display_Supervisor_List()
        Display_Company_List()

        '  LoadToCombo()

    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSaveSupervisor.Click
        'Create New Item

        If Not IsNothing(txtSupervisorName.Text) Then
            If (G_ACTION = False) Then
                oUtility.INSERT_SUPERVISOR(txtSupervisorName.Text, frmMain.tsUserCode.Text)
                MsgBox("New Supervisor successfully created.", vbInformation)

            ElseIf (G_ACTION = True) Then
                'UPDATE
                oUtility.UPDATE_SUPERVISOR(G_SUPERVISORID, txtSupervisorName.Text, chkIsActiveSupervisor.Checked, frmMain.tsUserCode.Text)
                MsgBox(txtSupervisorName.Text & " successfully updated!", vbInformation)

            End If

            gbSupervisorEntry.Enabled = False
            clearInputs_Supervisor()
            dgSupervisorList.DataSource = oUtility.GET_SUPERVISORS
        Else
            MsgBox("Required filled must fill up.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
    End Sub



#Region "USER DEFINED FUNCTIONS"
    'LOAD TO COMBO BOX

    Private Sub LoadToCombo()
        Dim dt As DataTable = oUtility.GET_SUPERVISORS

        Dim dr As DataRow = dt.NewRow()
        dr("SupervisorName") = "---Select Supervisor---"
        dr("SupervisorID") = 0
        dt.Rows.InsertAt(dr, 0)



        Dim dt2 As DataTable = oUtility.GET_PARTNERS

        Dim dr2 As DataRow = dt2.NewRow()
        dr2("partnerName") = "---Select Business Partner---"
        dr2("partnerCode") = 0
        dt2.Rows.InsertAt(dr2, 0)


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
                chkIsActiveSupervisor.Checked = Convert.ToBoolean(drv("IsActive"))
                gbSupervisorEntry.Enabled = True


                G_ACTION = True
                G_SUPERVISORID = _supervisorID

            Next
        End If
    End Sub

    Private Sub displayCompanyForEdit(ByVal _companyID As Integer)
        Dim dt As New DataTable
        dt = oSystem.GET_COMPANY_DATA
        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "CompanyID = '" + _companyID.ToString() + "'"

        If (dv.Count > 0) Then
            For Each drv As DataRowView In dv
                txtCompanyCode.Text = drv("CompanyCode").ToString()
                txtCompanyName.Text = drv("Company_Name").ToString()

                gbBranchEntry.Enabled = True
                txtCompanyCode.Enabled = False
                txtCompanyName.Focus()
            Next

            G_ACTION_COMPANY = True
        End If
    End Sub

    Private Sub clearInputs_Supervisor()
        txtSupervisorName.Text = ""
        chkIsActiveSupervisor.Checked = False
        gbSupervisorEntry.Enabled = False
    End Sub

    Private Sub clearInputs_Branch()
        txtCompanyCode.Text = ""
        txtCompanyName.Text = ""

    End Sub

    'Display list of Supervisor
    Private Sub Display_Supervisor_List()
        Dim dt As New DataTable
        dt = oUtility.GET_SUPERVISORS
        dt.DefaultView.Sort = "Supervisorname ASC"

        dgSupervisorList.DataSource = dt
    End Sub

    'Display list of Branch
    Private Sub Display_Company_List()
        Dim dt As New DataTable
        dt = oSystem.GET_COMPANY_DATA
        dt.DefaultView.Sort = "Company_Name ASC"

        dgCompanyList.DataSource = dt
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
        gbSupervisorEntry.Enabled = True
        clearInputs_Supervisor()
        G_ACTION = False
        txtSupervisorName.Focus()
        chkIsActiveSupervisor.Checked = True
    End Sub

    Private Sub txtSearchBranch_TextChanged(sender As Object, e As EventArgs) Handles txtSearchCompany.TextChanged
        Dim dt As New DataTable
        dt = oUtility.GET_BRANCHES

        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "BranchName like '%" + txtSearchCompany.Text + "%'"
        dv.Sort = "BranchName ASC"

        dgCompanyList.DataSource = dv
    End Sub

    Private Sub dgBranchList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCompanyList.CellClick
        If e.ColumnIndex = 0 Then
            Dim i As Integer

            i = dgCompanyList.CurrentRow.Index

            Dim CompanyID As Integer = dgCompanyList.Item(1, i).Value

            displayCompanyForEdit(CompanyID)
        End If
    End Sub

    Private Sub tsNewBranch_Click(sender As Object, e As EventArgs) Handles tsNewCompany.Click
        clearInputs_Branch()

        G_ACTION_COMPANY = False

        With txtCompanyCode
            .Focus()
            .Enabled = True
        End With

        chkIsActiveCompany.Checked = True

    End Sub

    Private Sub tsSaveCompany_Click(sender As Object, e As EventArgs) Handles tsSaveCompany.Click
        'CHECK USER INPUT
        If Not IsNothing(txtCompanyCode.Text) And Not IsNothing(txtCompanyName.Text) Then
            If (G_ACTION = False) Then
                ' oUtility.INSERT_SUPERVISOR(txtSupervisorName.Text, frmMain.tsUserCode.Text)
                'MsgBox("New Supervisor successfully created.", vbInformation)

            ElseIf (G_ACTION = True) Then
                'UPDATE
                'oUtility.UPDATE_SUPERVISOR(G_SUPERVISORID, txtSupervisorName.Text, chkIsActiveSupervisor.Checked, frmMain.tsUserCode.Text)
                'MsgBox(txtSupervisorName.Text & " successfully updated!", vbInformation)

            End If

        End If
    End Sub
End Class