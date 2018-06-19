<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemMaintenance
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
        Me.gbCreateItem = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbItemGroup = New System.Windows.Forms.ComboBox()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbUOM = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsCreate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgItemList = New System.Windows.Forms.DataGridView()
        Me.dgEdit = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.SpGETDMITEMLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsItemList = New DGMU_DEBIT_TICKET_PROJ.dsItemList()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.tpItemUOM = New System.Windows.Forms.TabPage()
        Me.gbUOMDataEntry = New System.Windows.Forms.GroupBox()
        Me.txtUOMName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUOMCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgUOMList = New System.Windows.Forms.DataGridView()
        Me.DataGridViewLinkColumn1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsCreateUOM = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSaveUOM = New System.Windows.Forms.ToolStripButton()
        Me.tpItemGroup = New System.Windows.Forms.TabPage()
        Me.SpGET_DM_ITEM_LISTTableAdapter2 = New DGMU_DEBIT_TICKET_PROJ.dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.tpItem.SuspendLayout()
        Me.gbCreateItem.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpItemUOM.SuspendLayout()
        Me.gbUOMDataEntry.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgUOMList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpItem)
        Me.TabControl1.Controls.Add(Me.tpItemUOM)
        Me.TabControl1.Controls.Add(Me.tpItemGroup)
        Me.TabControl1.Location = New System.Drawing.Point(2, 13)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(840, 408)
        Me.TabControl1.TabIndex = 0
        '
        'tpItem
        '
        Me.tpItem.Controls.Add(Me.gbCreateItem)
        Me.tpItem.Controls.Add(Me.ToolStrip1)
        Me.tpItem.Controls.Add(Me.GroupBox1)
        Me.tpItem.Location = New System.Drawing.Point(4, 27)
        Me.tpItem.Margin = New System.Windows.Forms.Padding(4)
        Me.tpItem.Name = "tpItem"
        Me.tpItem.Padding = New System.Windows.Forms.Padding(4)
        Me.tpItem.Size = New System.Drawing.Size(832, 377)
        Me.tpItem.TabIndex = 0
        Me.tpItem.Text = "Item Master"
        '
        'gbCreateItem
        '
        Me.gbCreateItem.Controls.Add(Me.Label3)
        Me.gbCreateItem.Controls.Add(Me.Label1)
        Me.gbCreateItem.Controls.Add(Me.cmbItemGroup)
        Me.gbCreateItem.Controls.Add(Me.txtItemDescription)
        Me.gbCreateItem.Controls.Add(Me.Label2)
        Me.gbCreateItem.Controls.Add(Me.cmbUOM)
        Me.gbCreateItem.Enabled = False
        Me.gbCreateItem.Location = New System.Drawing.Point(472, 38)
        Me.gbCreateItem.Name = "gbCreateItem"
        Me.gbCreateItem.Size = New System.Drawing.Size(355, 127)
        Me.gbCreateItem.TabIndex = 2
        Me.gbCreateItem.TabStop = False
        Me.gbCreateItem.Text = "Create New Item"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Item Group"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Name"
        '
        'cmbItemGroup
        '
        Me.cmbItemGroup.FormattingEnabled = True
        Me.cmbItemGroup.Location = New System.Drawing.Point(133, 92)
        Me.cmbItemGroup.Name = "cmbItemGroup"
        Me.cmbItemGroup.Size = New System.Drawing.Size(216, 26)
        Me.cmbItemGroup.TabIndex = 2
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Location = New System.Drawing.Point(133, 28)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(216, 26)
        Me.txtItemDescription.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unit of Measure"
        '
        'cmbUOM
        '
        Me.cmbUOM.FormattingEnabled = True
        Me.cmbUOM.Location = New System.Drawing.Point(133, 60)
        Me.cmbUOM.Name = "cmbUOM"
        Me.cmbUOM.Size = New System.Drawing.Size(216, 26)
        Me.cmbUOM.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCreate, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.tsSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(824, 31)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsCreate
        '
        Me.tsCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsCreate.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.add_image_24
        Me.tsCreate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCreate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCreate.Name = "tsCreate"
        Me.tsCreate.Size = New System.Drawing.Size(28, 28)
        Me.tsCreate.Text = "Create"
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
        'tsSave
        '
        Me.tsSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSave.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.approval_24
        Me.tsSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSave.Name = "tsSave"
        Me.tsSave.Size = New System.Drawing.Size(28, 28)
        Me.tsSave.Text = "Update"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgItemList)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(460, 331)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Details"
        '
        'dgItemList
        '
        Me.dgItemList.AllowUserToAddRows = False
        Me.dgItemList.AllowUserToDeleteRows = False
        Me.dgItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgEdit})
        Me.dgItemList.Location = New System.Drawing.Point(9, 63)
        Me.dgItemList.Name = "dgItemList"
        Me.dgItemList.ReadOnly = True
        Me.dgItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgItemList.Size = New System.Drawing.Size(429, 262)
        Me.dgItemList.TabIndex = 5
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(67, 25)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(371, 26)
        Me.txtSearch.TabIndex = 1
        '
        'tpItemUOM
        '
        Me.tpItemUOM.BackColor = System.Drawing.SystemColors.Control
        Me.tpItemUOM.Controls.Add(Me.gbUOMDataEntry)
        Me.tpItemUOM.Controls.Add(Me.GroupBox2)
        Me.tpItemUOM.Controls.Add(Me.ToolStrip2)
        Me.tpItemUOM.Location = New System.Drawing.Point(4, 27)
        Me.tpItemUOM.Name = "tpItemUOM"
        Me.tpItemUOM.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItemUOM.Size = New System.Drawing.Size(832, 377)
        Me.tpItemUOM.TabIndex = 2
        Me.tpItemUOM.Text = "Item UOM"
        '
        'gbUOMDataEntry
        '
        Me.gbUOMDataEntry.Controls.Add(Me.txtUOMName)
        Me.gbUOMDataEntry.Controls.Add(Me.Label6)
        Me.gbUOMDataEntry.Controls.Add(Me.txtUOMCode)
        Me.gbUOMDataEntry.Controls.Add(Me.Label7)
        Me.gbUOMDataEntry.Enabled = False
        Me.gbUOMDataEntry.Location = New System.Drawing.Point(481, 37)
        Me.gbUOMDataEntry.Name = "gbUOMDataEntry"
        Me.gbUOMDataEntry.Size = New System.Drawing.Size(348, 114)
        Me.gbUOMDataEntry.TabIndex = 4
        Me.gbUOMDataEntry.TabStop = False
        Me.gbUOMDataEntry.Text = "Unit of Measurement Data Entry"
        '
        'txtUOMName
        '
        Me.txtUOMName.Location = New System.Drawing.Point(121, 63)
        Me.txtUOMName.Name = "txtUOMName"
        Me.txtUOMName.Size = New System.Drawing.Size(204, 26)
        Me.txtUOMName.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "UOM Code: "
        '
        'txtUOMCode
        '
        Me.txtUOMCode.Location = New System.Drawing.Point(121, 28)
        Me.txtUOMCode.MaxLength = 4
        Me.txtUOMCode.Name = "txtUOMCode"
        Me.txtUOMCode.Size = New System.Drawing.Size(204, 26)
        Me.txtUOMCode.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "UOM Name :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgUOMList)
        Me.GroupBox2.Location = New System.Drawing.Point(15, 37)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(449, 303)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "UOM List"
        '
        'dgUOMList
        '
        Me.dgUOMList.AllowUserToAddRows = False
        Me.dgUOMList.AllowUserToDeleteRows = False
        Me.dgUOMList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUOMList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewLinkColumn1})
        Me.dgUOMList.Location = New System.Drawing.Point(6, 25)
        Me.dgUOMList.Name = "dgUOMList"
        Me.dgUOMList.ReadOnly = True
        Me.dgUOMList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUOMList.Size = New System.Drawing.Size(429, 262)
        Me.dgUOMList.TabIndex = 5
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
        'ToolStrip2
        '
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCreateUOM, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.tsSaveUOM})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(826, 31)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsCreateUOM
        '
        Me.tsCreateUOM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsCreateUOM.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.add_image_24
        Me.tsCreateUOM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCreateUOM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCreateUOM.Name = "tsCreateUOM"
        Me.tsCreateUOM.Size = New System.Drawing.Size(28, 28)
        Me.tsCreateUOM.Text = "Create"
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
        'tsSaveUOM
        '
        Me.tsSaveUOM.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSaveUOM.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.approval_24
        Me.tsSaveUOM.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsSaveUOM.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSaveUOM.Name = "tsSaveUOM"
        Me.tsSaveUOM.Size = New System.Drawing.Size(28, 28)
        Me.tsSaveUOM.Text = "Update"
        '
        'tpItemGroup
        '
        Me.tpItemGroup.Location = New System.Drawing.Point(4, 27)
        Me.tpItemGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.tpItemGroup.Name = "tpItemGroup"
        Me.tpItemGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.tpItemGroup.Size = New System.Drawing.Size(832, 377)
        Me.tpItemGroup.TabIndex = 1
        Me.tpItemGroup.Text = "Item Group"
        '
        'SpGET_DM_ITEM_LISTTableAdapter2
        '
        Me.SpGET_DM_ITEM_LISTTableAdapter2.ClearBeforeFill = True
        '
        'frmItemMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmItemMaintenance"
        Me.Text = "Item Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.tpItem.ResumeLayout(False)
        Me.tpItem.PerformLayout()
        Me.gbCreateItem.ResumeLayout(False)
        Me.gbCreateItem.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpItemUOM.ResumeLayout(False)
        Me.tpItemUOM.PerformLayout()
        Me.gbUOMDataEntry.ResumeLayout(False)
        Me.gbUOMDataEntry.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgUOMList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpItem As TabPage
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbItemGroup As ComboBox
    Friend WithEvents cmbUOM As ComboBox
    Friend WithEvents txtItemDescription As TextBox
    Friend WithEvents tpItemGroup As TabPage
    Friend WithEvents tsCreate As ToolStripButton
    Friend WithEvents tsSave As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tpItemUOM As System.Windows.Forms.TabPage
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgItemList As DataGridView
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
    Friend WithEvents gbCreateItem As System.Windows.Forms.GroupBox
    Friend WithEvents gbUOMDataEntry As GroupBox
    Friend WithEvents txtUOMName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtUOMCode As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgUOMList As DataGridView
    Friend WithEvents DataGridViewLinkColumn1 As DataGridViewLinkColumn
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsCreateUOM As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tsSaveUOM As ToolStripButton
End Class
