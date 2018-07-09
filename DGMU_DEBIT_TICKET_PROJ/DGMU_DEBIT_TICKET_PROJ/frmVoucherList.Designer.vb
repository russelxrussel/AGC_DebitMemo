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
        Me.dgUserRequestList = New System.Windows.Forms.DataGridView()
        Me.lnkPrint = New MetroFramework.Controls.MetroLink()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUserRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgUserRequestList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(581, 448)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of  Voucher"
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
        Me.dgUserRequestList.Size = New System.Drawing.Size(575, 426)
        Me.dgUserRequestList.TabIndex = 0
        '
        'lnkPrint
        '
        Me.lnkPrint.BackColor = System.Drawing.Color.Transparent
        Me.lnkPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkPrint.DisplayFocus = True
        Me.lnkPrint.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.print_24
        Me.lnkPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkPrint.ImageSize = 24
        Me.lnkPrint.Location = New System.Drawing.Point(509, 30)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(106, 23)
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
        Me.txtSearch.Size = New System.Drawing.Size(353, 23)
        Me.txtSearch.TabIndex = 7
        '
        'frmVoucherList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 516)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnkPrint)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmVoucherList"
        Me.Text = "Voucher List"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgUserRequestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgUserRequestList As DataGridView
    Friend WithEvents lnkPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
End Class
