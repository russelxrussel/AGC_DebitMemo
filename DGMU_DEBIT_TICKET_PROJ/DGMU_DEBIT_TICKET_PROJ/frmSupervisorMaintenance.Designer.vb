﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.gbCreateItem = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbItemGroup = New System.Windows.Forms.ComboBox()
        Me.txtSupervisorName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbUOM = New System.Windows.Forms.ComboBox()
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
        Me.tpItemUOM = New System.Windows.Forms.TabPage()
        Me.tpItemGroup = New System.Windows.Forms.TabPage()
        Me.SpGETDMITEMLISTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsItemList = New DGMU_DEBIT_TICKET_PROJ.dsItemList()
        Me.SpGET_DM_ITEM_LISTTableAdapter2 = New DGMU_DEBIT_TICKET_PROJ.dsItemListTableAdapters.spGET_DM_ITEM_LISTTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.tpItem.SuspendLayout()
        Me.gbCreateItem.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgSupervisorList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpGETDMITEMLISTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsItemList, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.tpItem.Text = "Supervisor"
        '
        'gbCreateItem
        '
        Me.gbCreateItem.Controls.Add(Me.Label3)
        Me.gbCreateItem.Controls.Add(Me.Label1)
        Me.gbCreateItem.Controls.Add(Me.cmbItemGroup)
        Me.gbCreateItem.Controls.Add(Me.txtSupervisorName)
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
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Supervisor Name"
        '
        'cmbItemGroup
        '
        Me.cmbItemGroup.FormattingEnabled = True
        Me.cmbItemGroup.Location = New System.Drawing.Point(133, 92)
        Me.cmbItemGroup.Name = "cmbItemGroup"
        Me.cmbItemGroup.Size = New System.Drawing.Size(216, 26)
        Me.cmbItemGroup.TabIndex = 2
        '
        'txtSupervisorName
        '
        Me.txtSupervisorName.Location = New System.Drawing.Point(133, 28)
        Me.txtSupervisorName.Name = "txtSupervisorName"
        Me.txtSupervisorName.Size = New System.Drawing.Size(216, 26)
        Me.txtSupervisorName.TabIndex = 0
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
        Me.dgSupervisorList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgSupervisorList.Size = New System.Drawing.Size(429, 262)
        Me.dgSupervisorList.TabIndex = 5
        '
        'dgEdit
        '
        Me.dgEdit.HeaderText = "Edit"
        Me.dgEdit.Name = "dgEdit"
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
        'tpItemUOM
        '
        Me.tpItemUOM.BackColor = System.Drawing.SystemColors.Control
        Me.tpItemUOM.Location = New System.Drawing.Point(4, 27)
        Me.tpItemUOM.Name = "tpItemUOM"
        Me.tpItemUOM.Padding = New System.Windows.Forms.Padding(3)
        Me.tpItemUOM.Size = New System.Drawing.Size(832, 377)
        Me.tpItemUOM.TabIndex = 2
        Me.tpItemUOM.Text = "Item UOM"
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
        Me.Text = "Supervisor Maintenance"
        Me.TabControl1.ResumeLayout(False)
        Me.tpItem.ResumeLayout(False)
        Me.tpItem.PerformLayout()
        Me.gbCreateItem.ResumeLayout(False)
        Me.gbCreateItem.PerformLayout()
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
    Friend WithEvents cmbItemGroup As ComboBox
    Friend WithEvents cmbUOM As ComboBox
    Friend WithEvents txtSupervisorName As TextBox
    Friend WithEvents tpItemGroup As TabPage
    Friend WithEvents tsCreateSupervisor As ToolStripButton
    Friend WithEvents tsSaveSupervisor As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tpItemUOM As System.Windows.Forms.TabPage
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
    Friend WithEvents gbCreateItem As System.Windows.Forms.GroupBox
End Class
