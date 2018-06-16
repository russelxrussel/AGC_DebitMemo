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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsCreate = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.tsSave = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbItemGroup = New System.Windows.Forms.ComboBox()
        Me.txtItemDescription = New System.Windows.Forms.TextBox()
        Me.cmbUOM = New System.Windows.Forms.ComboBox()
        Me.tpItemUOM = New System.Windows.Forms.TabPage()
        Me.tpItemGroup = New System.Windows.Forms.TabPage()
        Me.DsItemList = New DGMU_DEBIT_TICKET_PROJ.dsItemList()
        Me.SpGETDMITEMLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SpGET_DM_ITEM_LISTTableAdapter = New DGMU_DEBIT_TICKET_PROJ.dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UomDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tpItem.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TabControl1.Size = New System.Drawing.Size(400, 408)
        Me.TabControl1.TabIndex = 0
        '
        'tpItem
        '
        Me.tpItem.Controls.Add(Me.Label3)
        Me.tpItem.Controls.Add(Me.ToolStrip1)
        Me.tpItem.Controls.Add(Me.Label2)
        Me.tpItem.Controls.Add(Me.GroupBox1)
        Me.tpItem.Controls.Add(Me.Label1)
        Me.tpItem.Controls.Add(Me.cmbItemGroup)
        Me.tpItem.Controls.Add(Me.txtItemDescription)
        Me.tpItem.Controls.Add(Me.cmbUOM)
        Me.tpItem.Location = New System.Drawing.Point(4, 27)
        Me.tpItem.Margin = New System.Windows.Forms.Padding(4)
        Me.tpItem.Name = "tpItem"
        Me.tpItem.Padding = New System.Windows.Forms.Padding(4)
        Me.tpItem.Size = New System.Drawing.Size(392, 377)
        Me.tpItem.TabIndex = 0
        Me.tpItem.Text = "Item Master"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Item Group"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsCreate, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.tsSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(384, 31)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Unit of Measure"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(4, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 217)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Item Details"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemIDDataGridViewTextBoxColumn, Me.ItemDescriptionDataGridViewTextBoxColumn, Me.UomDescriptionDataGridViewTextBoxColumn, Me.GroupNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SpGETDMITEMLISTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(9, 63)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(372, 150)
        Me.DataGridView1.TabIndex = 5
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
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(67, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(308, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Item Name"
        '
        'cmbItemGroup
        '
        Me.cmbItemGroup.FormattingEnabled = True
        Me.cmbItemGroup.Location = New System.Drawing.Point(133, 115)
        Me.cmbItemGroup.Name = "cmbItemGroup"
        Me.cmbItemGroup.Size = New System.Drawing.Size(240, 26)
        Me.cmbItemGroup.TabIndex = 2
        '
        'txtItemDescription
        '
        Me.txtItemDescription.Location = New System.Drawing.Point(133, 51)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(240, 26)
        Me.txtItemDescription.TabIndex = 0
        '
        'cmbUOM
        '
        Me.cmbUOM.FormattingEnabled = True
        Me.cmbUOM.Location = New System.Drawing.Point(133, 83)
        Me.cmbUOM.Name = "cmbUOM"
        Me.cmbUOM.Size = New System.Drawing.Size(240, 26)
        Me.cmbUOM.TabIndex = 1
        '
        'tpItemUOM
        '
        Me.tpItemUOM.BackColor = System.Drawing.SystemColors.Control
        Me.tpItemUOM.Location = New System.Drawing.Point(4, 27)
        Me.tpItemUOM.Name = "tpItemUOM"
        Me.tpItemUOM.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItemUOM.Size = New System.Drawing.Size(392, 377)
        Me.tpItemUOM.TabIndex = 2
        Me.tpItemUOM.Text = "Item UOM"
        '
        'tpItemGroup
        '
        Me.tpItemGroup.Location = New System.Drawing.Point(4, 27)
        Me.tpItemGroup.Margin = New System.Windows.Forms.Padding(4)
        Me.tpItemGroup.Name = "tpItemGroup"
        Me.tpItemGroup.Padding = New System.Windows.Forms.Padding(4)
        Me.tpItemGroup.Size = New System.Drawing.Size(392, 377)
        Me.tpItemGroup.TabIndex = 1
        Me.tpItemGroup.Text = "Item Group"
        '
        'DsItemList
        '
        Me.DsItemList.DataSetName = "dsItemList"
        Me.DsItemList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SpGETDMITEMLISTBindingSource
        '
        Me.SpGETDMITEMLISTBindingSource.DataMember = "spGET_DM_ITEM_LIST"
        Me.SpGETDMITEMLISTBindingSource.DataSource = Me.DsItemList
        '
        'SpGET_DM_ITEM_LISTTableAdapter
        '
        Me.SpGET_DM_ITEM_LISTTableAdapter.ClearBeforeFill = True
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        Me.ItemIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemDescriptionDataGridViewTextBoxColumn
        '
        Me.ItemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.HeaderText = "ItemDescription"
        Me.ItemDescriptionDataGridViewTextBoxColumn.Name = "ItemDescriptionDataGridViewTextBoxColumn"
        '
        'UomDescriptionDataGridViewTextBoxColumn
        '
        Me.UomDescriptionDataGridViewTextBoxColumn.DataPropertyName = "uomDescription"
        Me.UomDescriptionDataGridViewTextBoxColumn.HeaderText = "uomDescription"
        Me.UomDescriptionDataGridViewTextBoxColumn.Name = "UomDescriptionDataGridViewTextBoxColumn"
        '
        'GroupNameDataGridViewTextBoxColumn
        '
        Me.GroupNameDataGridViewTextBoxColumn.DataPropertyName = "groupName"
        Me.GroupNameDataGridViewTextBoxColumn.HeaderText = "groupName"
        Me.GroupNameDataGridViewTextBoxColumn.Name = "GroupNameDataGridViewTextBoxColumn"
        '
        'frmItemMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 421)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmItemMaintenance"
        Me.Text = "Item Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.tpItem.ResumeLayout(False)
        Me.tpItem.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DsItemList As dsItemList
    Friend WithEvents SpGETDMITEMLISTBindingSource As BindingSource
    Friend WithEvents SpGET_DM_ITEM_LISTTableAdapter As dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UomDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GroupNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
