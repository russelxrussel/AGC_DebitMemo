<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoucherList
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
        Me.dgUserVoucherList = New System.Windows.Forms.DataGridView()
        Me.lnkPrint = New MetroFramework.Controls.MetroLink()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgUserVoucherItemList = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUserVoucherList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgUserVoucherItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgUserVoucherList)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 54)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(664, 257)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of  Voucher"
        '
        'dgUserVoucherList
        '
        Me.dgUserVoucherList.AllowUserToAddRows = False
        Me.dgUserVoucherList.AllowUserToDeleteRows = False
        Me.dgUserVoucherList.AllowUserToOrderColumns = True
        Me.dgUserVoucherList.AllowUserToResizeColumns = False
        Me.dgUserVoucherList.AllowUserToResizeRows = False
        Me.dgUserVoucherList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUserVoucherList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUserVoucherList.Location = New System.Drawing.Point(3, 23)
        Me.dgUserVoucherList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgUserVoucherList.Name = "dgUserVoucherList"
        Me.dgUserVoucherList.ReadOnly = True
        Me.dgUserVoucherList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgUserVoucherList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgUserVoucherList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUserVoucherList.ShowEditingIcon = False
        Me.dgUserVoucherList.Size = New System.Drawing.Size(658, 230)
        Me.dgUserVoucherList.TabIndex = 0
        '
        'lnkPrint
        '
        Me.lnkPrint.BackColor = System.Drawing.Color.Transparent
        Me.lnkPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkPrint.DisplayFocus = True
        Me.lnkPrint.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.print_24
        Me.lnkPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkPrint.ImageSize = 24
        Me.lnkPrint.Location = New System.Drawing.Point(582, 23)
        Me.lnkPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(120, 28)
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
        Me.Label4.Location = New System.Drawing.Point(18, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(81, 19)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(403, 26)
        Me.txtSearch.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgUserVoucherItemList)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 319)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(664, 154)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Voucher Details"
        '
        'dgUserVoucherItemList
        '
        Me.dgUserVoucherItemList.AllowUserToAddRows = False
        Me.dgUserVoucherItemList.AllowUserToDeleteRows = False
        Me.dgUserVoucherItemList.AllowUserToOrderColumns = True
        Me.dgUserVoucherItemList.AllowUserToResizeColumns = False
        Me.dgUserVoucherItemList.AllowUserToResizeRows = False
        Me.dgUserVoucherItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUserVoucherItemList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgUserVoucherItemList.Location = New System.Drawing.Point(3, 23)
        Me.dgUserVoucherItemList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgUserVoucherItemList.Name = "dgUserVoucherItemList"
        Me.dgUserVoucherItemList.ReadOnly = True
        Me.dgUserVoucherItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgUserVoucherItemList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgUserVoucherItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUserVoucherItemList.ShowEditingIcon = False
        Me.dgUserVoucherItemList.Size = New System.Drawing.Size(658, 127)
        Me.dgUserVoucherItemList.TabIndex = 0
        '
        'frmVoucherList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 501)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnkPrint)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmVoucherList"
        Me.Text = "Voucher List"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgUserVoucherList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgUserVoucherItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgUserVoucherList As DataGridView
    Friend WithEvents lnkPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgUserVoucherItemList As DataGridView
End Class
