<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCompanyMaintenance
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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpCompany = New System.Windows.Forms.TabPage()
        Me.gbBranchEntry = New System.Windows.Forms.GroupBox()
        Me.txtCompanyName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkIsActiveCompany = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCompanyCode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgCompanyList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchCompany = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsNewCompany = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSaveCompany = New System.Windows.Forms.ToolStripButton()
        Me.tpItem = New System.Windows.Forms.TabPage()
        Me.gbSupervisorEntry = New System.Windows.Forms.GroupBox()
        Me.chkIsActiveSupervisor = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSupervisorName = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsCreateSupervisor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSaveSupervisor = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgSupervisorList = New System.Windows.Forms.DataGridView()
        Me.dgEdit = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearchSupervisor = New System.Windows.Forms.TextBox()
        Me.tpPartners = New System.Windows.Forms.TabPage()
        Me.SpGETDMITEMLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsItemList = New DGMU_DEBIT_TICKET_PROJ.dsItemList()
        Me.SpGET_DM_ITEM_LISTTableAdapter2 = New DGMU_DEBIT_TICKET_PROJ.dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.tpCompany.SuspendLayout()
        Me.gbBranchEntry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgCompanyList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.tpItem.SuspendLayout()
        Me.gbSupervisorEntry.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSupervisorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCompany)
        Me.TabControl1.Controls.Add(Me.tpItem)
        Me.TabControl1.Controls.Add(Me.tpPartners)
        Me.TabControl1.Location = New System.Drawing.Point(2, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(840, 408)
        Me.TabControl1.TabIndex = 0
        '
        'tpCompany
        '
        Me.tpCompany.BackColor = System.Drawing.SystemColors.Control
        Me.tpCompany.Controls.Add(Me.gbBranchEntry)
        Me.tpCompany.Controls.Add(Me.GroupBox2)
        Me.tpCompany.Controls.Add(Me.ToolStrip2)
        Me.tpCompany.Location = New System.Drawing.Point(4, 27)
        Me.tpCompany.Name = "tpCompany"
        Me.tpCompany.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCompany.Size = New System.Drawing.Size(832, 377)
        Me.tpCompany.TabIndex = 2
        Me.tpCompany.Text = "Company"
        '
        'gbBranchEntry
        '
        Me.gbBranchEntry.Controls.Add(Me.txtCompanyName)
        Me.gbBranchEntry.Controls.Add(Me.Label5)
        Me.gbBranchEntry.Controls.Add(Me.chkIsActiveCompany)
        Me.gbBranchEntry.Controls.Add(Me.Label3)
        Me.gbBranchEntry.Controls.Add(Me.txtCompanyCode)
        Me.gbBranchEntry.Enabled = False
        Me.gbBranchEntry.Location = New System.Drawing.Point(471, 37)
        Me.gbBranchEntry.Name = "gbBranchEntry"
        Me.gbBranchEntry.Size = New System.Drawing.Size(338, 194)
        Me.gbBranchEntry.TabIndex = 4
        Me.gbBranchEntry.TabStop = False
        Me.gbBranchEntry.Text = "Company Data Entry"
        '
        'txtCompanyName
        '
        Me.txtCompanyName.Location = New System.Drawing.Point(107, 60)
        Me.txtCompanyName.Name = "txtCompanyName"
        Me.txtCompanyName.Size = New System.Drawing.Size(216, 26)
        Me.txtCompanyName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Name"
        '
        'chkIsActiveCompany
        '
        Me.chkIsActiveCompany.AutoSize = True
        Me.chkIsActiveCompany.Location = New System.Drawing.Point(107, 103)
        Me.chkIsActiveCompany.Name = "chkIsActiveCompany"
        Me.chkIsActiveCompany.Size = New System.Drawing.Size(65, 22)
        Me.chkIsActiveCompany.TabIndex = 4
        Me.chkIsActiveCompany.Text = "Active"
        Me.chkIsActiveCompany.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(61, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Code"
        '
        'txtCompanyCode
        '
        Me.txtCompanyCode.Location = New System.Drawing.Point(107, 28)
        Me.txtCompanyCode.Name = "txtCompanyCode"
        Me.txtCompanyCode.Size = New System.Drawing.Size(216, 26)
        Me.txtCompanyCode.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgCompanyList)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSearchCompany)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 331)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Company List"
        '
        'dgCompanyList
        '
        Me.dgCompanyList.AllowUserToAddRows = False
        Me.dgCompanyList.AllowUserToDeleteRows = False
        Me.dgCompanyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCompanyList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLinkColumn1})
        Me.dgCompanyList.Location = New System.Drawing.Point(9, 63)
        Me.dgCompanyList.Name = "dgCompanyList"
        Me.dgCompanyList.ReadOnly = True
        Me.dgCompanyList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgCompanyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgCompanyList.Size = New System.Drawing.Size(429, 262)
        Me.dgCompanyList.TabIndex = 5
        '
        'DataGridViewLinkColumn1
        '
        Me.DataGridViewLinkColumn1.HeaderText = "Edit"
        Me.DataGridViewLinkColumn1.Name = "DataGridViewLinkColumn1"
        Me.DataGridViewLinkColumn1.ReadOnly = True
        Me.DataGridViewLinkColumn1.Text = "Edit"
        Me.DataGridViewLinkColumn1.UseColumnTextForLinkValue = True
        Me.DataGridViewLinkColumn1.Width = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Search"
        '
        'txtSearchCompany
        '
        Me.txtSearchCompany.Location = New System.Drawing.Point(67, 25)
        Me.txtSearchCompany.Name = "txtSearchCompany"
        Me.txtSearchCompany.Size = New System.Drawing.Size(371, 26)
        Me.txtSearchCompany.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNewCompany, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.tsSaveCompany})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(826, 31)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsNewCompany
        '
        Me.tsNewCompany.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsNewCompany.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.add_image_24
        Me.tsNewCompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsNewCompany.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNewCompany.Name = "tsNewCompany"
        Me.tsNewCompany.Size = New System.Drawing.Size(28, 28)
        Me.tsNewCompany.Text = "Create"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(73, 28)
        Me.ToolStripLabel2.Text = "                      "
        '
        'tsSaveCompany
        '
        Me.tsSaveCompany.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSaveCompany.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.approval_24
        Me.tsSaveCompany.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSaveCompany.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSaveCompany.Name = "tsSaveCompany"
        Me.tsSaveCompany.Size = New System.Drawing.Size(28, 28)
        Me.tsSaveCompany.Text = "Update"
        '
        'tpItem
        '
        Me.tpItem.Controls.Add(Me.gbSupervisorEntry)
        Me.tpItem.Controls.Add(Me.ToolStrip1)
        Me.tpItem.Controls.Add(Me.GroupBox1)
        Me.tpItem.Location = New System.Drawing.Point(4, 27)
        Me.tpItem.Margin = New System.Windows.Forms.Padding(4)
        Me.tpItem.Name = "tpItem"
        Me.tpItem.Padding = New System.Windows.Forms.Padding(4)
        Me.tpItem.Size = New System.Drawing.Size(832, 377)
        Me.tpItem.TabIndex = 0
        Me.tpItem.Text = "Supervisor"
        '
        'gbSupervisorEntry
        '
        Me.gbSupervisorEntry.Controls.Add(Me.chkIsActiveSupervisor)
        Me.gbSupervisorEntry.Controls.Add(Me.Label1)
        Me.gbSupervisorEntry.Controls.Add(Me.txtSupervisorName)
        Me.gbSupervisorEntry.Enabled = False
        Me.gbSupervisorEntry.Location = New System.Drawing.Point(472, 38)
        Me.gbSupervisorEntry.Name = "gbSupervisorEntry"
        Me.gbSupervisorEntry.Size = New System.Drawing.Size(355, 104)
        Me.gbSupervisorEntry.TabIndex = 2
        Me.gbSupervisorEntry.TabStop = False
        Me.gbSupervisorEntry.Text = "Supervisor Data Entry"
        '
        'chkIsActiveSupervisor
        '
        Me.chkIsActiveSupervisor.AutoSize = True
        Me.chkIsActiveSupervisor.Location = New System.Drawing.Point(133, 63)
        Me.chkIsActiveSupervisor.Name = "chkIsActiveSupervisor"
        Me.chkIsActiveSupervisor.Size = New System.Drawing.Size(65, 22)
        Me.chkIsActiveSupervisor.TabIndex = 4
        Me.chkIsActiveSupervisor.Text = "Active"
        Me.chkIsActiveSupervisor.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Supervisor Name"
        '
        'txtSupervisorName
        '
        Me.txtSupervisorName.Location = New System.Drawing.Point(133, 28)
        Me.txtSupervisorName.Name = "txtSupervisorName"
        Me.txtSupervisorName.Size = New System.Drawing.Size(216, 26)
        Me.txtSupervisorName.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCreateSupervisor, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.tsSaveSupervisor})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(824, 31)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsCreateSupervisor
        '
        Me.tsCreateSupervisor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsCreateSupervisor.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.add_image_24
        Me.tsCreateSupervisor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCreateSupervisor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCreateSupervisor.Name = "tsCreateSupervisor"
        Me.tsCreateSupervisor.Size = New System.Drawing.Size(28, 28)
        Me.tsCreateSupervisor.Text = "Create"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(73, 28)
        Me.ToolStripLabel1.Text = "                      "
        '
        'tsSaveSupervisor
        '
        Me.tsSaveSupervisor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSaveSupervisor.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.approval_24
        Me.tsSaveSupervisor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSaveSupervisor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSaveSupervisor.Name = "tsSaveSupervisor"
        Me.tsSaveSupervisor.Size = New System.Drawing.Size(28, 28)
        Me.tsSaveSupervisor.Text = "Update"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgSupervisorList)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSearchSupervisor)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 331)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Supervisor Details"
        '
        'dgSupervisorList
        '
        Me.dgSupervisorList.AllowUserToAddRows = False
        Me.dgSupervisorList.AllowUserToDeleteRows = False
        Me.dgSupervisorList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgSupervisorList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgEdit})
        Me.dgSupervisorList.Location = New System.Drawing.Point(9, 63)
        Me.dgSupervisorList.Name = "dgSupervisorList"
        Me.dgSupervisorList.ReadOnly = True
        Me.dgSupervisorList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgSupervisorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSupervisorList.Size = New System.Drawing.Size(429, 262)
        Me.dgSupervisorList.TabIndex = 5
        '
        'dgEdit
        '
        Me.dgEdit.HeaderText = "Edit"
        Me.dgEdit.Name = "dgEdit"
        Me.dgEdit.ReadOnly = True
        Me.dgEdit.Text = "Edit"
        Me.dgEdit.UseColumnTextForLinkValue = True
        Me.dgEdit.Width = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Search"
        '
        'txtSearchSupervisor
        '
        Me.txtSearchSupervisor.Location = New System.Drawing.Point(67, 25)
        Me.txtSearchSupervisor.Name = "txtSearchSupervisor"
        Me.txtSearchSupervisor.Size = New System.Drawing.Size(371, 26)
        Me.txtSearchSupervisor.TabIndex = 1
        '
        'tpPartners
        '
        Me.tpPartners.Location = New System.Drawing.Point(4, 27)
        Me.tpPartners.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPartners.Name = "tpPartners"
        Me.tpPartners.Padding = New System.Windows.Forms.Padding(4)
        Me.tpPartners.Size = New System.Drawing.Size(832, 377)
        Me.tpPartners.TabIndex = 1
        Me.tpPartners.Text = "Business Partner"
        '
        'SpGETDMITEMLISTBindingSource
        '
        Me.SpGETDMITEMLISTBindingSource.DataMember = "spGET_DM_ITEM_LIST"
        Me.SpGETDMITEMLISTBindingSource.DataSource = Me.DsItemList
        '
        'DsItemList
        '
        Me.DsItemList.DataSetName = "dsItemList"
        Me.DsItemList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGET_DM_ITEM_LISTTableAdapter2
        '
        Me.SpGET_DM_ITEM_LISTTableAdapter2.ClearBeforeFill = True
        '
        'frmCompanyMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCompanyMaintenance"
        Me.Text = "Company / Supplier Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.tpCompany.ResumeLayout(False)
        Me.tpCompany.PerformLayout()
        Me.gbBranchEntry.ResumeLayout(False)
        Me.gbBranchEntry.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgCompanyList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.tpItem.ResumeLayout(False)
        Me.tpItem.PerformLayout()
        Me.gbSupervisorEntry.ResumeLayout(False)
        Me.gbSupervisorEntry.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgSupervisorList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpItem As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtSupervisorName As TextBox
    Friend WithEvents tpPartners As TabPage
    Friend WithEvents tsCreateSupervisor As ToolStripButton
    Friend WithEvents tsSaveSupervisor As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tpCompany As System.Windows.Forms.TabPage
    Friend WithEvents txtSearchSupervisor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgSupervisorList As DataGridView
    Friend WithEvents SpGET_DM_ITEM_LISTTableAdapter As dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UomDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsItemList1 As DGMU_DEBIT_TICKET_PROJ.dsItemList
    Friend WithEvents SpGET_DM_ITEM_LISTTableAdapter1 As DGMU_DEBIT_TICKET_PROJ.dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ItemGroupCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsItemList As DGMU_DEBIT_TICKET_PROJ.dsItemList
    Friend WithEvents SpGETDMITEMLISTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpGET_DM_ITEM_LISTTableAdapter2 As DGMU_DEBIT_TICKET_PROJ.dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter
    Friend WithEvents dgEdit As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents gbSupervisorEntry As System.Windows.Forms.GroupBox
    Friend WithEvents chkIsActiveSupervisor As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgCompanyList As DataGridView
    Friend WithEvents DataGridViewLinkColumn1 As DataGridViewLinkColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchCompany As TextBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsNewCompany As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tsSaveCompany As ToolStripButton
    Friend WithEvents gbBranchEntry As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkIsActiveCompany As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCompanyCode As TextBox
    Friend WithEvents txtCompanyName As TextBox
End Class
