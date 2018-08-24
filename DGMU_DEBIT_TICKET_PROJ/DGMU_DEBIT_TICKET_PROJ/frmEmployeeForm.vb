Imports System.IO
Imports MetroFramework

Public Class frmEmployeeForm
    Dim oSystem As New System_C
    Dim oEmployee As New Employee_C

    Private G_ACTION_ITEM As Boolean = False
    Private Sub frmCA_RequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        initState()


    End Sub

    Private Sub initState()
        'Server Date and Time
        dtBirthDate.Value = oSystem.GET_SERVER_DATE_TIME()

        'Default photo
        imgEmpPhoto.ImageLocation = "Images/default/default_employee.png"

        lblPhotoPath.Text = imgEmpPhoto.ImageLocation

        'Display data in Combo Lists
        displayGenderList()
        displayMaritaList()
        displayCompanyList()
        displayJobPositionList()
        displayDepartmentList()
        displayEmploymentStatusList()

        'Display List of Employee
        displayListOfEmployee()


    End Sub

    Private Sub displayGenderList()
        Dim dt As DataTable = oEmployee.GET_GENDER_LIST

        With cmbGender
            .DataSource = dt
            .DisplayMember = dt.Columns("GenderDescription").ToString()
            .ValueMember = dt.Columns("GenderCode").ToString()
        End With
    End Sub

    Private Sub displayListOfEmployee()
        Dim dt As DataTable = oEmployee.GET_EMPLOYEE_LIST_FOR_DISPLAY

        Dim dv As DataView = dt.DefaultView
        dv.Sort = "EmployeeName ASC"

        dgListOfEmployee.DataSource = dv

        'Dim lnkEdit As New DataGridViewLinkColumn
        'dgListOfEmployee.Columns.Add(lnkEdit)
        'With lnkEdit
        '    .HeaderText = "Edit"
        '    .Text = "Edit"
        'End With
    End Sub

    Private Sub displayListOfEmployee(ByVal _searchText As String)
        Dim dt As DataTable = oEmployee.GET_EMPLOYEE_LIST_FOR_DISPLAY
        'dgListOfEmployee.DataSource = dt

        Dim dv As DataView = dt.DefaultView
        dv.RowFilter = "EmployeeName like '%" & _searchText & "%'"
        dv.Sort = "EmployeeName ASC"

        dgListOfEmployee.DataSource = dv
    End Sub

    Private Sub displayMaritaList()
        Dim dt As DataTable = oEmployee.GET_MARITAL_STATUS_LIST

        With cmbMaritalStatus
            .DataSource = dt
            .DisplayMember = dt.Columns("MaritalStatus").ToString()
            .ValueMember = dt.Columns("maritalCode").ToString()
        End With
    End Sub

    Private Sub displayDepartmentList()
        Dim dt As DataTable = oEmployee.GET_DEPARTMENT_LIST

        With cmbDepartmentList
            .DataSource = dt
            .DisplayMember = dt.Columns("Department").ToString()
            .ValueMember = dt.Columns("DepartmentCode").ToString()
        End With
    End Sub

    Private Sub displayEmploymentStatusList()
        Dim dt As DataTable = oEmployee.GET_EMPLOYMENT_STATUS_LIST

        With cmbEmploymentStatus
            .DataSource = dt
            .DisplayMember = dt.Columns("EmpStatus").ToString()
            .ValueMember = dt.Columns("EmpStatusCode").ToString()
        End With
    End Sub


    Private Sub displayCompanyList()
        Dim dt As DataTable = oSystem.GET_COMPANY_DATA
        With cmbCompanyList
            .DataSource = dt
            .DisplayMember = dt.Columns("Company_Name").ToString()
            .ValueMember = dt.Columns("CompanyCode").ToString()
        End With
    End Sub

    Private Sub displayJobPositionList()
        Dim dt As DataTable = oEmployee.GET_JOB_POSITION_LIST
        With cmbJobPosition
            .DataSource = dt
            .DisplayMember = dt.Columns("Position").ToString()
            .ValueMember = dt.Columns("JPCode").ToString()
        End With
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image (*.jpg;*.png ) | *.jpg; *.png"

        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then

            imgEmpPhoto.ImageLocation = opf.FileName
            lblPhotoPath.Text = opf.FileName

            lblImageSize.Text = opf.FileName.Length
        End If


    End Sub

    Private Sub tsSave_Click(sender As Object, e As EventArgs) Handles tsSave.Click

        If (Not String.IsNullOrEmpty(txtLastName.Text) And Not String.IsNullOrEmpty(txtFirstName.Text)) Then
            'SAVE INFORMATION
            Dim bEmpPhoto As Byte()
            Dim iFileSize As Integer

            If G_ACTION_ITEM = False Then


                bEmpPhoto = IO.File.ReadAllBytes(lblPhotoPath.Text)
                iFileSize = bEmpPhoto.Length

                'oEmployee.INSERT_EMPLOYEE_PHOTO(cmbRequestee.SelectedValue.ToString(), bAttachment)

                oEmployee.INSERT_EMPLOYEE_INFORMATION(oSystem.GENERATE_SERIES_NUMBER_5DIGITS(cmbCompanyList.SelectedValue), txtLastName.Text, txtFirstName.Text, txtMiddleName.Text, "", Convert.ToDateTime(dtBirthDate.Value), cmbGender.SelectedValue,
                                              cmbMaritalStatus.SelectedValue, txtAddress.Text, txtContactNumber.Text, txtContactPerson.Text,
                                              txtTIN.Text, txtSSS.Text, txtPagibig.Text, txtPhilHealth.Text, Convert.ToDateTime(dtDateHired.Value), cmbCompanyList.SelectedValue, cmbJobPosition.SelectedValue, cmbDepartmentList.SelectedValue, cmbEmploymentStatus.SelectedValue, iFileSize, bEmpPhoto)


                MetroMessageBox.Show(Me, "New Employee successfully added.", "HRIS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                Dim bIsPhotoChange As Boolean


                'CHECK IF Employee photo has been changed
                If Convert.ToInt32(lblImageSize.Text) > 0 Then
                    bIsPhotoChange = True
                    bEmpPhoto = IO.File.ReadAllBytes(lblPhotoPath.Text)
                Else
                    bIsPhotoChange = False

                    'The default image will not be safe.
                    'This statement avoid error on image.
                    'Conditional statement was on Stored Procedure
                    bEmpPhoto = IO.File.ReadAllBytes("Images/default/default_employee.png")
                End If


                oEmployee.UPDATE_EMPLOYEE_INFORMATION(lblEmployeeCode.Text, txtLastName.Text, txtFirstName.Text, txtMiddleName.Text, "", Convert.ToDateTime(dtBirthDate.Value), cmbGender.SelectedValue,
                                              cmbMaritalStatus.SelectedValue, txtAddress.Text, txtContactNumber.Text, txtContactPerson.Text,
                                              txtTIN.Text, txtSSS.Text, txtPagibig.Text, txtPhilHealth.Text, Convert.ToDateTime(dtDateHired.Value), cmbCompanyList.SelectedValue, cmbJobPosition.SelectedValue, cmbDepartmentList.SelectedValue, cmbEmploymentStatus.SelectedValue, bIsPhotoChange, bEmpPhoto)

                MetroMessageBox.Show(Me, "Employee Data successfully updated.", "HRIS", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

            'RELOAD FORM
            Controls.Clear()
            InitializeComponent()
            Show()

            initState()
        Else
            MessageBox.Show("Please fill up required input, highligted with red color")
            Exit Sub
        End If

    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        'Display List of Filter Search
        displayListOfEmployee(txtSearch.Text)
    End Sub

    Private Sub tsSearch_Click(sender As Object, e As EventArgs) Handles tsSearch.Click
        gbListOfEmployee.Visible = True
    End Sub

    Private Sub lnkCloseListOfEmployee_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkCloseListOfEmployee.LinkClicked
        gbListOfEmployee.Visible = False
    End Sub



    Private Sub dgListOfEmployee_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListOfEmployee.CellClick

        If e.ColumnIndex = 0 Then
            Dim i As Integer

            i = dgListOfEmployee.CurrentRow.Index

            Dim empCode As String = dgListOfEmployee.Item(1, i).Value

            'DISPLAY INFORMATION
            displayEmployeeForEdit(empCode)
            gbListOfEmployee.Visible = False

            'EDIT MODE
            G_ACTION_ITEM = True
            gbInput.Enabled = True

            lblPhotoPath.Text = ""

        End If

    End Sub

    Private Sub displayEmployeeForEdit(ByVal _employeeCode As String)
        Dim dt As New DataTable
        dt = oEmployee.GET_EMPLOYEE_LIST
        Dim dv As New DataView
        dv = dt.DefaultView

        dv.RowFilter = "EmpCode = '" + _employeeCode + "'"

        If (dv.Count > 0) Then
            For Each drv As DataRowView In dv

                lblEmployeeCode.Text = drv("EmpCode").ToString()
                txtLastName.Text = drv("E_LastName").ToString()
                txtFirstName.Text = drv("E_FirstName").ToString()
                txtMiddleName.Text = drv("E_MiddleName").ToString()

                dtBirthDate.Value = Convert.ToDateTime(drv("BirthDate"))
                cmbGender.SelectedValue = drv("GenderCode").ToString()
                cmbMaritalStatus.SelectedValue = drv("MaritalCode").ToString()

                txtAddress.Text = drv("Address").ToString()
                txtContactNumber.Text = drv("Contact_Number").ToString()
                txtContactPerson.Text = drv("Contact_Person").ToString()

                cmbEmploymentStatus.SelectedValue = drv("EmpStatusCode").ToString()
                dtDateHired.Value = Convert.ToDateTime(drv("date_Hired"))
                cmbCompanyList.SelectedValue = drv("CompanyCode").ToString()
                cmbDepartmentList.SelectedValue = drv("DepartmentCode").ToString()
                cmbJobPosition.SelectedValue = drv("JPCode").ToString()

                txtTIN.Text = drv("TIN").ToString()
                txtSSS.Text = drv("SSS").ToString()
                txtPagibig.Text = drv("HDMF").ToString()
                txtPhilHealth.Text = drv("PhilHealth").ToString()



                G_ACTION_ITEM = True
                'G_ITEMID = _itemID

                Dim empPhoto As Byte() = drv("EmpPhoto")
                If Not empPhoto Is Nothing Then
                    Using ms As New MemoryStream(empPhoto, 0, empPhoto.Length)
                        ms.Write(empPhoto, 0, empPhoto.Length)
                        imgEmpPhoto.Image = Image.FromStream(ms, True)

                    End Using
                Else
                    imgEmpPhoto.Image = Nothing
                End If

            Next
        End If
    End Sub

    Private Sub tsNew_Click(sender As Object, e As EventArgs) Handles tsNew.Click
        'RELOAD FORM
        Controls.Clear()
        InitializeComponent()
        Show()

        initState()
        gbInput.Enabled = True
        txtLastName.Focus()
        G_ACTION_ITEM = False
    End Sub
End Class