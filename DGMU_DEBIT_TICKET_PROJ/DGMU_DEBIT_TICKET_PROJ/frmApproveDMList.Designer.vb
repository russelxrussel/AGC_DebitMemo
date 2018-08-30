<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmApproveDMList
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDMApproveList = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgApprove_List_Item = New System.Windows.Forms.DataGridView()
        Me.lnkCancel = New MetroFramework.Controls.MetroLink()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lnkAttachment = New System.Windows.Forms.LinkLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDMApproveList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgApprove_List_Item, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgDMApproveList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(654, 226)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Approve Debit Memo"
        '
        'dgDMApproveList
        '
        Me.dgDMApproveList.AllowUserToAddRows = False
        Me.dgDMApproveList.AllowUserToDeleteRows = False
        Me.dgDMApproveList.AllowUserToOrderColumns = True
        Me.dgDMApproveList.AllowUserToResizeColumns = False
        Me.dgDMApproveList.AllowUserToResizeRows = False
        Me.dgDMApproveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDMApproveList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDMApproveList.Location = New System.Drawing.Point(3, 19)
        Me.dgDMApproveList.Name = "dgDMApproveList"
        Me.dgDMApproveList.ReadOnly = True
        Me.dgDMApproveList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgDMApproveList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgDMApproveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDMApproveList.ShowEditingIcon = False
        Me.dgDMApproveList.Size = New System.Drawing.Size(648, 204)
        Me.dgDMApproveList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgApprove_List_Item)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(765, 210)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List of Items"
        '
        'dgApprove_List_Item
        '
        Me.dgApprove_List_Item.AllowUserToAddRows = False
        Me.dgApprove_List_Item.AllowUserToDeleteRows = False
        Me.dgApprove_List_Item.AllowUserToOrderColumns = True
        Me.dgApprove_List_Item.AllowUserToResizeColumns = False
        Me.dgApprove_List_Item.AllowUserToResizeRows = False
        Me.dgApprove_List_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgApprove_List_Item.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgApprove_List_Item.Location = New System.Drawing.Point(3, 19)
        Me.dgApprove_List_Item.Name = "dgApprove_List_Item"
        Me.dgApprove_List_Item.ReadOnly = True
        Me.dgApprove_List_Item.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgApprove_List_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgApprove_List_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgApprove_List_Item.ShowEditingIcon = False
        Me.dgApprove_List_Item.Size = New System.Drawing.Size(759, 188)
        Me.dgApprove_List_Item.TabIndex = 0
        '
        'lnkCancel
        '
        Me.lnkCancel.BackColor = System.Drawing.Color.Transparent
        Me.lnkCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkCancel.DisplayFocus = True
        Me.lnkCancel.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.cancel_24
        Me.lnkCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkCancel.ImageSize = 24
        Me.lnkCancel.Location = New System.Drawing.Point(672, 75)
        Me.lnkCancel.Name = "lnkCancel"
        Me.lnkCancel.Size = New System.Drawing.Size(110, 23)
        Me.lnkCancel.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkCancel.TabIndex = 107
        Me.lnkCancel.Text = "CANCEL"
        Me.lnkCancel.UseCustomBackColor = True
        Me.lnkCancel.UseSelectable = True
        Me.lnkCancel.UseStyleColors = True
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
        'lnkAttachment
        '
        Me.lnkAttachment.AutoSize = True
        Me.lnkAttachment.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAttachment.Location = New System.Drawing.Point(672, 117)
        Me.lnkAttachment.Name = "lnkAttachment"
        Me.lnkAttachment.Size = New System.Drawing.Size(116, 18)
        Me.lnkAttachment.TabIndex = 108
        Me.lnkAttachment.TabStop = True
        Me.lnkAttachment.Text = "View Attachment"
        '
        'frmApproveDMList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 532)
        Me.Controls.Add(Me.lnkAttachment)
        Me.Controls.Add(Me.lnkCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmApproveDMList"
        Me.Text = "Approve Debit Memo List"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDMApproveList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgApprove_List_Item, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgDMApproveList As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgApprove_List_Item As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lnkCancel As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkAttachment As LinkLabel
End Class
