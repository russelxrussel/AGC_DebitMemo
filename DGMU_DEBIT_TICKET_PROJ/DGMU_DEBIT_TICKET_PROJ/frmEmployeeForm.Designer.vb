<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeeForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtContactPerson = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtContactNumber = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPhotoPath = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbMaritalStatus = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbSuffix = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMiddleName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.imgEmpPhoto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsNew = New System.Windows.Forms.ToolStripButton()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSearch = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblEmployeeCode = New System.Windows.Forms.Label()
        Me.cmbEmploymentStatus = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbDepartmentList = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtDateHired = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCompanyList = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbJobPosition = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtPhilHealth = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPagibig = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSSS = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTIN = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.gbListOfEmployee = New System.Windows.Forms.GroupBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lnkCloseListOfEmployee = New System.Windows.Forms.LinkLabel()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dgListOfEmployee = New System.Windows.Forms.DataGridView()
        Me.EmpPhoto = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.gbInput = New System.Windows.Forms.GroupBox()
        Me.lblImageSize = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.imgEmpPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbListOfEmployee.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgListOfEmployee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblPhotoPath)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbMaritalStatus)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbGender)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtBirthDate)
        Me.GroupBox1.Controls.Add(Me.cmbSuffix)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtMiddleName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.Controls.Add(Me.imgEmpPhoto)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(470, 452)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Basic Information"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtAddress)
        Me.GroupBox5.Controls.Add(Me.Label23)
        Me.GroupBox5.Controls.Add(Me.txtContactPerson)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtContactNumber)
        Me.GroupBox5.Controls.Add(Me.Label21)
        Me.GroupBox5.Location = New System.Drawing.Point(6, 296)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(458, 125)
        Me.GroupBox5.TabIndex = 36
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Contact Details"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(125, 24)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(327, 26)
        Me.txtAddress.TabIndex = 0
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(54, 32)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(65, 18)
        Me.Label23.TabIndex = 38
        Me.Label23.Text = "Address :"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(125, 89)
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(196, 26)
        Me.txtContactPerson.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(14, 96)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(105, 18)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Contact Person:"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(125, 57)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(196, 26)
        Me.txtContactNumber.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(3, 65)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(116, 18)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "Contact Number :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(-3, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(641, 3)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "111"
        '
        'lblPhotoPath
        '
        Me.lblPhotoPath.AutoSize = True
        Me.lblPhotoPath.Location = New System.Drawing.Point(272, 144)
        Me.lblPhotoPath.Name = "lblPhotoPath"
        Me.lblPhotoPath.Size = New System.Drawing.Size(55, 18)
        Me.lblPhotoPath.TabIndex = 33
        Me.lblPhotoPath.Text = "Label11"
        Me.lblPhotoPath.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "BIRTH DATE :"
        '
        'cmbMaritalStatus
        '
        Me.cmbMaritalStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMaritalStatus.FormattingEnabled = True
        Me.cmbMaritalStatus.Location = New System.Drawing.Point(121, 247)
        Me.cmbMaritalStatus.Name = "cmbMaritalStatus"
        Me.cmbMaritalStatus.Size = New System.Drawing.Size(121, 26)
        Me.cmbMaritalStatus.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 18)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "CIVIL STATUS:"
        '
        'cmbGender
        '
        Me.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(121, 215)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(121, 26)
        Me.cmbGender.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "GENDER :"
        '
        'dtBirthDate
        '
        Me.dtBirthDate.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtBirthDate.Location = New System.Drawing.Point(121, 182)
        Me.dtBirthDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtBirthDate.Name = "dtBirthDate"
        Me.dtBirthDate.Size = New System.Drawing.Size(121, 26)
        Me.dtBirthDate.TabIndex = 18
        Me.dtBirthDate.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'cmbSuffix
        '
        Me.cmbSuffix.FormattingEnabled = True
        Me.cmbSuffix.Location = New System.Drawing.Point(121, 126)
        Me.cmbSuffix.Name = "cmbSuffix"
        Me.cmbSuffix.Size = New System.Drawing.Size(121, 26)
        Me.cmbSuffix.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "SUFFIX :"
        '
        'txtMiddleName
        '
        Me.txtMiddleName.Location = New System.Drawing.Point(121, 94)
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.Size = New System.Drawing.Size(196, 26)
        Me.txtMiddleName.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 18)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "MIDDLE NAME :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(121, 62)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(196, 26)
        Me.txtFirstName.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(12, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "FIRST NAME :"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(121, 30)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(196, 26)
        Me.txtLastName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "LAST NAME :"
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(333, 139)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(131, 29)
        Me.btnBrowse.TabIndex = 7
        Me.btnBrowse.Text = "Browse Photo"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'imgEmpPhoto
        '
        Me.imgEmpPhoto.Location = New System.Drawing.Point(336, 12)
        Me.imgEmpPhoto.Name = "imgEmpPhoto"
        Me.imgEmpPhoto.Size = New System.Drawing.Size(128, 121)
        Me.imgEmpPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgEmpPhoto.TabIndex = 6
        Me.imgEmpPhoto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNew, Me.tsSave, Me.ToolStripLabel1, Me.tsSearch})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(862, 36)
        Me.ToolStrip1.TabIndex = 33
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsNew
        '
        Me.tsNew.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsNew.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.plus_24
        Me.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNew.Name = "tsNew"
        Me.tsNew.Size = New System.Drawing.Size(36, 33)
        Me.tsNew.Text = "NEW"
        Me.tsNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsSave
        '
        Me.tsSave.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSave.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.survey_24
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(36, 33)
        Me.tsSave.Text = "SAVE"
        Me.tsSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(250, 33)
        '
        'tsSearch
        '
        Me.tsSearch.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsSearch.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.search_24
        Me.tsSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSearch.Name = "tsSearch"
        Me.tsSearch.Size = New System.Drawing.Size(52, 33)
        Me.tsSearch.Text = "SEARCH"
        Me.tsSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblEmployeeCode)
        Me.GroupBox2.Controls.Add(Me.cmbEmploymentStatus)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cmbDepartmentList)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.dtDateHired)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbCompanyList)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbJobPosition)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(497, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 254)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employment Details"
        '
        'lblEmployeeCode
        '
        Me.lblEmployeeCode.AutoSize = True
        Me.lblEmployeeCode.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmployeeCode.Location = New System.Drawing.Point(161, 29)
        Me.lblEmployeeCode.Name = "lblEmployeeCode"
        Me.lblEmployeeCode.Size = New System.Drawing.Size(13, 19)
        Me.lblEmployeeCode.TabIndex = 41
        Me.lblEmployeeCode.Text = "."
        '
        'cmbEmploymentStatus
        '
        Me.cmbEmploymentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEmploymentStatus.FormattingEnabled = True
        Me.cmbEmploymentStatus.Location = New System.Drawing.Point(165, 62)
        Me.cmbEmploymentStatus.Name = "cmbEmploymentStatus"
        Me.cmbEmploymentStatus.Size = New System.Drawing.Size(175, 26)
        Me.cmbEmploymentStatus.TabIndex = 0
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(102, 18)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "EMPLOYEE ID #:"
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(-3, 109)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(641, 3)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "111"
        '
        'cmbDepartmentList
        '
        Me.cmbDepartmentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDepartmentList.FormattingEnabled = True
        Me.cmbDepartmentList.Location = New System.Drawing.Point(113, 184)
        Me.cmbDepartmentList.Name = "cmbDepartmentList"
        Me.cmbDepartmentList.Size = New System.Drawing.Size(213, 26)
        Me.cmbDepartmentList.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(11, 187)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 18)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "DEPARTMENT :"
        '
        'dtDateHired
        '
        Me.dtDateHired.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDateHired.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDateHired.Location = New System.Drawing.Point(113, 116)
        Me.dtDateHired.Margin = New System.Windows.Forms.Padding(4)
        Me.dtDateHired.Name = "dtDateHired"
        Me.dtDateHired.Size = New System.Drawing.Size(97, 26)
        Me.dtDateHired.TabIndex = 1
        Me.dtDateHired.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(11, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(148, 18)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "EMPLOYMENT STATUS :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(11, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 18)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "DATE HIRED :"
        '
        'cmbCompanyList
        '
        Me.cmbCompanyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCompanyList.FormattingEnabled = True
        Me.cmbCompanyList.Location = New System.Drawing.Point(113, 149)
        Me.cmbCompanyList.Name = "cmbCompanyList"
        Me.cmbCompanyList.Size = New System.Drawing.Size(213, 26)
        Me.cmbCompanyList.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(11, 152)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 18)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "COMPANY :"
        '
        'cmbJobPosition
        '
        Me.cmbJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbJobPosition.FormattingEnabled = True
        Me.cmbJobPosition.Location = New System.Drawing.Point(113, 216)
        Me.cmbJobPosition.Name = "cmbJobPosition"
        Me.cmbJobPosition.Size = New System.Drawing.Size(213, 26)
        Me.cmbJobPosition.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(11, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 18)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "POSITION :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtPhilHealth)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtPagibig)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txtSSS)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.txtTIN)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(497, 295)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(346, 182)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Goverment ID's"
        '
        'txtPhilHealth
        '
        Me.txtPhilHealth.Location = New System.Drawing.Point(132, 129)
        Me.txtPhilHealth.Name = "txtPhilHealth"
        Me.txtPhilHealth.Size = New System.Drawing.Size(184, 26)
        Me.txtPhilHealth.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(11, 133)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 18)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "PHIL HEALTH :"
        '
        'txtPagibig
        '
        Me.txtPagibig.Location = New System.Drawing.Point(132, 97)
        Me.txtPagibig.Name = "txtPagibig"
        Me.txtPagibig.Size = New System.Drawing.Size(184, 26)
        Me.txtPagibig.TabIndex = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(11, 101)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(115, 18)
        Me.Label18.TabIndex = 20
        Me.Label18.Text = "HDMF (Pag-ibig) :"
        '
        'txtSSS
        '
        Me.txtSSS.Location = New System.Drawing.Point(132, 65)
        Me.txtSSS.Name = "txtSSS"
        Me.txtSSS.Size = New System.Drawing.Size(184, 26)
        Me.txtSSS.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(11, 69)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 18)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "SSS # :"
        '
        'txtTIN
        '
        Me.txtTIN.Location = New System.Drawing.Point(132, 33)
        Me.txtTIN.Name = "txtTIN"
        Me.txtTIN.Size = New System.Drawing.Size(184, 26)
        Me.txtTIN.TabIndex = 0
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(11, 37)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 18)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "TIN # :"
        '
        'gbListOfEmployee
        '
        Me.gbListOfEmployee.Controls.Add(Me.FlowLayoutPanel1)
        Me.gbListOfEmployee.Location = New System.Drawing.Point(6, 51)
        Me.gbListOfEmployee.Name = "gbListOfEmployee"
        Me.gbListOfEmployee.Size = New System.Drawing.Size(849, 488)
        Me.gbListOfEmployee.TabIndex = 37
        Me.gbListOfEmployee.TabStop = False
        Me.gbListOfEmployee.Text = "LIST OF EMPLOYEE"
        Me.gbListOfEmployee.Visible = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel1.Controls.Add(Me.dgListOfEmployee)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 22)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(843, 463)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lnkCloseListOfEmployee)
        Me.GroupBox4.Controls.Add(Me.txtSearch)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(818, 50)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'lnkCloseListOfEmployee
        '
        Me.lnkCloseListOfEmployee.AutoSize = True
        Me.lnkCloseListOfEmployee.Location = New System.Drawing.Point(766, 15)
        Me.lnkCloseListOfEmployee.Name = "lnkCloseListOfEmployee"
        Me.lnkCloseListOfEmployee.Size = New System.Drawing.Size(46, 18)
        Me.lnkCloseListOfEmployee.TabIndex = 2
        Me.lnkCloseListOfEmployee.TabStop = True
        Me.lnkCloseListOfEmployee.Text = "CLOSE"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(161, 12)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(276, 26)
        Me.txtSearch.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(149, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Type Employee Name :"
        '
        'dgListOfEmployee
        '
        Me.dgListOfEmployee.AllowUserToAddRows = False
        Me.dgListOfEmployee.AllowUserToDeleteRows = False
        Me.dgListOfEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgListOfEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListOfEmployee.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpPhoto, Me.Edit})
        Me.dgListOfEmployee.Location = New System.Drawing.Point(3, 59)
        Me.dgListOfEmployee.Name = "dgListOfEmployee"
        Me.dgListOfEmployee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgListOfEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListOfEmployee.Size = New System.Drawing.Size(818, 377)
        Me.dgListOfEmployee.TabIndex = 1
        '
        'EmpPhoto
        '
        Me.EmpPhoto.DataPropertyName = "EmpPhoto"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.NullValue = CType(resources.GetObject("DataGridViewCellStyle5.NullValue"), Object)
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EmpPhoto.DefaultCellStyle = DataGridViewCellStyle5
        Me.EmpPhoto.HeaderText = "Photo"
        Me.EmpPhoto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.EmpPhoto.Name = "EmpPhoto"
        Me.EmpPhoto.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Edit
        '
        Me.Edit.HeaderText = "Edit"
        Me.Edit.Name = "Edit"
        Me.Edit.Text = "Edit"
        Me.Edit.UseColumnTextForLinkValue = True
        '
        'gbInput
        '
        Me.gbInput.Controls.Add(Me.GroupBox1)
        Me.gbInput.Controls.Add(Me.GroupBox2)
        Me.gbInput.Controls.Add(Me.GroupBox3)
        Me.gbInput.Enabled = False
        Me.gbInput.Location = New System.Drawing.Point(12, 51)
        Me.gbInput.Name = "gbInput"
        Me.gbInput.Size = New System.Drawing.Size(849, 488)
        Me.gbInput.TabIndex = 38
        Me.gbInput.TabStop = False
        '
        'lblImageSize
        '
        Me.lblImageSize.AutoSize = True
        Me.lblImageSize.Location = New System.Drawing.Point(18, 558)
        Me.lblImageSize.Name = "lblImageSize"
        Me.lblImageSize.Size = New System.Drawing.Size(15, 18)
        Me.lblImageSize.TabIndex = 39
        Me.lblImageSize.Text = "0"
        '
        'frmEmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 542)
        Me.Controls.Add(Me.lblImageSize)
        Me.Controls.Add(Me.gbListOfEmployee)
        Me.Controls.Add(Me.gbInput)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmEmployeeForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Information"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.imgEmpPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.gbListOfEmployee.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.dgListOfEmployee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInput.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents imgEmpPhoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents cmbSuffix As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMiddleName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbMaritalStatus As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtBirthDate As DateTimePicker
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsNew As ToolStripButton
    Friend WithEvents tsSave As ToolStripButton
    Friend WithEvents lblPhotoPath As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbDepartmentList As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtDateHired As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbCompanyList As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbJobPosition As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents tsSearch As ToolStripButton
    Friend WithEvents cmbEmploymentStatus As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtPhilHealth As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtPagibig As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSSS As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtTIN As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents gbListOfEmployee As GroupBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents dgListOfEmployee As DataGridView
    Friend WithEvents EmpPhoto As DataGridViewImageColumn
    Friend WithEvents Edit As DataGridViewLinkColumn
    Friend WithEvents lnkCloseListOfEmployee As LinkLabel
    Friend WithEvents lblEmployeeCode As Label
    Friend WithEvents gbInput As GroupBox
    Friend WithEvents lblImageSize As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents txtContactPerson As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txtContactNumber As TextBox
    Friend WithEvents Label21 As Label
End Class
