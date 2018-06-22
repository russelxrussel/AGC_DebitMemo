<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupervisorMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
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
        Me.tpBranch = New System.Windows.Forms.TabPage()
        Me.gbBranchEntry = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbBusinessPartner = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbSupervisor = New System.Windows.Forms.ComboBox()
        Me.txtBranchName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkIsActiveBranch = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBranchCode = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgBranchList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSearchBranch = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsNewBranch = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSaveBranch = New System.Windows.Forms.ToolStripButton()
        Me.tpPartners = New System.Windows.Forms.TabPage()
        Me.SpGETDMITEMLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsItemList = New DGMU_DEBIT_TICKET_PROJ.dsItemList()
        Me.SpGET_DM_ITEM_LISTTableAdapter2 = New DGMU_DEBIT_TICKET_PROJ.dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.tpItem.SuspendLayout()
        Me.gbSupervisorEntry.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSupervisorList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpBranch.SuspendLayout()
        Me.gbBranchEntry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgBranchList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpBranch)
        Me.TabControl1.Controls.Add(Me.tpItem)
        Me.TabControl1.Controls.Add(Me.tpPartners)
        Me.TabControl1.Location = New System.Drawing.Point(2, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(840, 408)
        Me.TabControl1.TabIndex = 0
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
        'tpBranch
        '
        Me.tpBranch.BackColor = System.Drawing.SystemColors.Control
        Me.tpBranch.Controls.Add(Me.gbBranchEntry)
        Me.tpBranch.Controls.Add(Me.GroupBox2)
        Me.tpBranch.Controls.Add(Me.ToolStrip2)
        Me.tpBranch.Location = New System.Drawing.Point(4, 27)
        Me.tpBranch.Name = "tpBranch"
        Me.tpBranch.Padding = New System.Windows.Forms.Padding(3)
        Me.tpBranch.Size = New System.Drawing.Size(832, 377)
        Me.tpBranch.TabIndex = 2
        Me.tpBranch.Text = "Branch"
        '
        'gbBranchEntry
        '
        Me.gbBranchEntry.Controls.Add(Me.Label7)
        Me.gbBranchEntry.Controls.Add(Me.cmbBusinessPartner)
        Me.gbBranchEntry.Controls.Add(Me.Label6)
        Me.gbBranchEntry.Controls.Add(Me.cmbSupervisor)
        Me.gbBranchEntry.Controls.Add(Me.txtBranchName)
        Me.gbBranchEntry.Controls.Add(Me.Label5)
        Me.gbBranchEntry.Controls.Add(Me.chkIsActiveBranch)
        Me.gbBranchEntry.Controls.Add(Me.Label3)
        Me.gbBranchEntry.Controls.Add(Me.txtBranchCode)
        Me.gbBranchEntry.Enabled = False
        Me.gbBranchEntry.Location = New System.Drawing.Point(471, 37)
        Me.gbBranchEntry.Name = "gbBranchEntry"
        Me.gbBranchEntry.Size = New System.Drawing.Size(338, 194)
        Me.gbBranchEntry.TabIndex = 4
        Me.gbBranchEntry.TabStop = False
        Me.gbBranchEntry.Text = "Branch Data Entry"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 18)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Business Part"
        '
        'cmbBusinessPartner
        '
        Me.cmbBusinessPartner.FormattingEnabled = True
        Me.cmbBusinessPartner.Location = New System.Drawing.Point(107, 125)
        Me.cmbBusinessPartner.Name = "cmbBusinessPartner"
        Me.cmbBusinessPartner.Size = New System.Drawing.Size(216, 26)
        Me.cmbBusinessPartner.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Supervisor"
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.FormattingEnabled = True
        Me.cmbSupervisor.Location = New System.Drawing.Point(107, 92)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(216, 26)
        Me.cmbSupervisor.TabIndex = 7
        '
        'txtBranchName
        '
        Me.txtBranchName.Location = New System.Drawing.Point(107, 60)
        Me.txtBranchName.Name = "txtBranchName"
        Me.txtBranchName.Size = New System.Drawing.Size(216, 26)
        Me.txtBranchName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Branch Name"
        '
        'chkIsActiveBranch
        '
        Me.chkIsActiveBranch.AutoSize = True
        Me.chkIsActiveBranch.Location = New System.Drawing.Point(107, 157)
        Me.chkIsActiveBranch.Name = "chkIsActiveBranch"
        Me.chkIsActiveBranch.Size = New System.Drawing.Size(65, 22)
        Me.chkIsActiveBranch.TabIndex = 4
        Me.chkIsActiveBranch.Text = "Active"
        Me.chkIsActiveBranch.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 18)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Branch Code"
        '
        'txtBranchCode
        '
        Me.txtBranchCode.Location = New System.Drawing.Point(107, 28)
        Me.txtBranchCode.Name = "txtBranchCode"
        Me.txtBranchCode.Size = New System.Drawing.Size(216, 26)
        Me.txtBranchCode.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgBranchList)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtSearchBranch)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 331)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Branch List"
        '
        'dgBranchList
        '
        Me.dgBranchList.AllowUserToAddRows = False
        Me.dgBranchList.AllowUserToDeleteRows = False
        Me.dgBranchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBranchList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLinkColumn1})
        Me.dgBranchList.Location = New System.Drawing.Point(9, 63)
        Me.dgBranchList.Name = "dgBranchList"
        Me.dgBranchList.ReadOnly = True
        Me.dgBranchList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgBranchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgBranchList.Size = New System.Drawing.Size(429, 262)
        Me.dgBranchList.TabIndex = 5
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
        'txtSearchBranch
        '
        Me.txtSearchBranch.Location = New System.Drawing.Point(67, 25)
        Me.txtSearchBranch.Name = "txtSearchBranch"
        Me.txtSearchBranch.Size = New System.Drawing.Size(371, 26)
        Me.txtSearchBranch.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsNewBranch, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.tsSaveBranch})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(826, 31)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsNewBranch
        '
        Me.tsNewBranch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsNewBranch.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.add_image_24
        Me.tsNewBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsNewBranch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNewBranch.Name = "tsNewBranch"
        Me.tsNewBranch.Size = New System.Drawing.Size(28, 28)
        Me.tsNewBranch.Text = "Create"
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
        'tsSaveBranch
        '
        Me.tsSaveBranch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSaveBranch.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.approval_24
        Me.tsSaveBranch.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSaveBranch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSaveBranch.Name = "tsSaveBranch"
        Me.tsSaveBranch.Size = New System.Drawing.Size(28, 28)
        Me.tsSaveBranch.Text = "Update"
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
        'frmSupervisorMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSupervisorMaintenance"
        Me.Text = "Personnel / Branch Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.tpItem.ResumeLayout(False)
        Me.tpItem.PerformLayout()
        Me.gbSupervisorEntry.ResumeLayout(False)
        Me.gbSupervisorEntry.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgSupervisorList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpBranch.ResumeLayout(False)
        Me.tpBranch.PerformLayout()
        Me.gbBranchEntry.ResumeLayout(False)
        Me.gbBranchEntry.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgBranchList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
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
    Friend WithEvents tpBranch As System.Windows.Forms.TabPage
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
    Friend WithEvents dgBranchList As DataGridView
    Friend WithEvents DataGridViewLinkColumn1 As DataGridViewLinkColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchBranch As TextBox
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsNewBranch As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tsSaveBranch As ToolStripButton
    Friend WithEvents gbBranchEntry As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkIsActiveBranch As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBranchCode As TextBox
    Friend WithEvents txtBranchName As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbBusinessPartner As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmbSupervisor As ComboBox
End Class
