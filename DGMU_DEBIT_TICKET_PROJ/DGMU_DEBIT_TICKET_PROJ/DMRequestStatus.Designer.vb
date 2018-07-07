<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMyDMRequest
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgUserRequestList = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgUser_Requested_List_Item = New System.Windows.Forms.DataGridView()
        Me.flayoutControl = New System.Windows.Forms.FlowLayoutPanel()
        Me.lnkPost = New MetroFramework.Controls.MetroLink()
        Me.lnkPrint = New MetroFramework.Controls.MetroLink()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUserRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgUser_Requested_List_Item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.flayoutControl.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgUserRequestList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of your request"
        '
        'dgUserRequestList
        '
        Me.dgUserRequestList.AllowUserToAddRows = False
        Me.dgUserRequestList.AllowUserToDeleteRows = False
        Me.dgUserRequestList.AllowUserToOrderColumns = True
        Me.dgUserRequestList.AllowUserToResizeColumns = False
        Me.dgUserRequestList.AllowUserToResizeRows = False
        Me.dgUserRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUserRequestList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUserRequestList.Location = New System.Drawing.Point(3, 19)
        Me.dgUserRequestList.Name = "dgUserRequestList"
        Me.dgUserRequestList.ReadOnly = True
        Me.dgUserRequestList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgUserRequestList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgUserRequestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUserRequestList.ShowEditingIcon = False
        Me.dgUserRequestList.Size = New System.Drawing.Size(575, 204)
        Me.dgUserRequestList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgUser_Requested_List_Item)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(708, 210)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Items"
        '
        'dgUser_Requested_List_Item
        '
        Me.dgUser_Requested_List_Item.AllowUserToAddRows = False
        Me.dgUser_Requested_List_Item.AllowUserToDeleteRows = False
        Me.dgUser_Requested_List_Item.AllowUserToOrderColumns = True
        Me.dgUser_Requested_List_Item.AllowUserToResizeColumns = False
        Me.dgUser_Requested_List_Item.AllowUserToResizeRows = False
        Me.dgUser_Requested_List_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUser_Requested_List_Item.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUser_Requested_List_Item.Location = New System.Drawing.Point(3, 19)
        Me.dgUser_Requested_List_Item.Name = "dgUser_Requested_List_Item"
        Me.dgUser_Requested_List_Item.ReadOnly = True
        Me.dgUser_Requested_List_Item.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgUser_Requested_List_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgUser_Requested_List_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUser_Requested_List_Item.ShowEditingIcon = False
        Me.dgUser_Requested_List_Item.Size = New System.Drawing.Size(702, 188)
        Me.dgUser_Requested_List_Item.TabIndex = 0
        '
        'flayoutControl
        '
        Me.flayoutControl.Controls.Add(Me.lnkPost)
        Me.flayoutControl.Controls.Add(Me.lnkPrint)
        Me.flayoutControl.Location = New System.Drawing.Point(603, 65)
        Me.flayoutControl.Name = "flayoutControl"
        Me.flayoutControl.Size = New System.Drawing.Size(117, 148)
        Me.flayoutControl.TabIndex = 6
        '
        'lnkPost
        '
        Me.lnkPost.BackColor = System.Drawing.Color.Transparent
        Me.lnkPost.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkPost.DisplayFocus = True
        Me.lnkPost.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.external_24
        Me.lnkPost.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkPost.ImageSize = 24
        Me.lnkPost.Location = New System.Drawing.Point(3, 3)
        Me.lnkPost.Name = "lnkPost"
        Me.lnkPost.Size = New System.Drawing.Size(102, 23)
        Me.lnkPost.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkPost.TabIndex = 105
        Me.lnkPost.Text = "POST"
        Me.lnkPost.UseCustomBackColor = True
        Me.lnkPost.UseSelectable = True
        Me.lnkPost.UseStyleColors = True
        '
        'lnkPrint
        '
        Me.lnkPrint.BackColor = System.Drawing.Color.Transparent
        Me.lnkPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkPrint.DisplayFocus = True
        Me.lnkPrint.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.print_24
        Me.lnkPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkPrint.ImageSize = 24
        Me.lnkPrint.Location = New System.Drawing.Point(3, 32)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(110, 23)
        Me.lnkPrint.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkPrint.TabIndex = 106
        Me.lnkPrint.Text = "RE-PRINT"
        Me.lnkPrint.UseCustomBackColor = True
        Me.lnkPrint.UseSelectable = True
        Me.lnkPrint.UseStyleColors = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(71, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(349, 23)
        Me.txtSearch.TabIndex = 7
        '
        'frmMyDMRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 532)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.flayoutControl)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMyDMRequest"
        Me.Text = "My Debit Memo"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgUserRequestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgUser_Requested_List_Item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.flayoutControl.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgUserRequestList As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgUser_Requested_List_Item As DataGridView
    Friend WithEvents flayoutControl As FlowLayoutPanel
    Friend WithEvents lnkPost As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
End Class
