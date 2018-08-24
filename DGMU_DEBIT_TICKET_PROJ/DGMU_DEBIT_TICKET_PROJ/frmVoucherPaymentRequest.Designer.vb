<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoucherPaymentRequest
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblPayeeSupplierName = New System.Windows.Forms.Label()
        Me.ddAccounts = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPayeeName = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MetroLink2 = New MetroFramework.Controls.MetroLink()
        Me.lnkProcessPayment = New MetroFramework.Controls.MetroLink()
        Me.dtRequest = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCheckNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBankName = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUserVoucherList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgUserVoucherList)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 43)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(664, 246)
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
        Me.dgUserVoucherList.Size = New System.Drawing.Size(658, 219)
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
        Me.lnkPrint.Location = New System.Drawing.Point(537, 191)
        Me.lnkPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(103, 28)
        Me.lnkPrint.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkPrint.TabIndex = 106
        Me.lnkPrint.Text = "PRINT"
        Me.lnkPrint.UseCustomBackColor = True
        Me.lnkPrint.UseSelectable = True
        Me.lnkPrint.UseStyleColors = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(81, 13)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(593, 26)
        Me.txtSearch.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(384, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Bank Name :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblBankName)
        Me.GroupBox3.Controls.Add(Me.lblPayeeSupplierName)
        Me.GroupBox3.Controls.Add(Me.ddAccounts)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtPayeeName)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.MetroLink2)
        Me.GroupBox3.Controls.Add(Me.lnkProcessPayment)
        Me.GroupBox3.Controls.Add(Me.dtRequest)
        Me.GroupBox3.Controls.Add(Me.lnkPrint)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.txtCheckNumber)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(14, 311)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(664, 233)
        Me.GroupBox3.TabIndex = 108
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Voucher Payment Details"
        '
        'lblPayeeSupplierName
        '
        Me.lblPayeeSupplierName.AutoSize = True
        Me.lblPayeeSupplierName.Location = New System.Drawing.Point(171, 77)
        Me.lblPayeeSupplierName.Name = "lblPayeeSupplierName"
        Me.lblPayeeSupplierName.Size = New System.Drawing.Size(0, 18)
        Me.lblPayeeSupplierName.TabIndex = 113
        '
        'ddAccounts
        '
        Me.ddAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddAccounts.FormattingEnabled = True
        Me.ddAccounts.Location = New System.Drawing.Point(470, 26)
        Me.ddAccounts.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ddAccounts.Name = "ddAccounts"
        Me.ddAccounts.Size = New System.Drawing.Size(170, 26)
        Me.ddAccounts.TabIndex = 112
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(394, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 18)
        Me.Label7.TabIndex = 111
        Me.Label7.Text = "Account # :"
        '
        'txtPayeeName
        '
        Me.txtPayeeName.Location = New System.Drawing.Point(170, 110)
        Me.txtPayeeName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtPayeeName.MaxLength = 150
        Me.txtPayeeName.Name = "txtPayeeName"
        Me.txtPayeeName.Size = New System.Drawing.Size(199, 26)
        Me.txtPayeeName.TabIndex = 110
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 18)
        Me.Label6.TabIndex = 109
        Me.Label6.Text = "Check Payment Name :"
        '
        'MetroLink2
        '
        Me.MetroLink2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLink2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MetroLink2.DisplayFocus = True
        Me.MetroLink2.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.print_24
        Me.MetroLink2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MetroLink2.ImageSize = 24
        Me.MetroLink2.Location = New System.Drawing.Point(11, 193)
        Me.MetroLink2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MetroLink2.Name = "MetroLink2"
        Me.MetroLink2.Size = New System.Drawing.Size(197, 28)
        Me.MetroLink2.Style = MetroFramework.MetroColorStyle.Purple
        Me.MetroLink2.TabIndex = 108
        Me.MetroLink2.Text = "PRINT VOUCHER"
        Me.MetroLink2.UseCustomBackColor = True
        Me.MetroLink2.UseSelectable = True
        Me.MetroLink2.UseStyleColors = True
        '
        'lnkProcessPayment
        '
        Me.lnkProcessPayment.BackColor = System.Drawing.Color.Transparent
        Me.lnkProcessPayment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkProcessPayment.DisplayFocus = True
        Me.lnkProcessPayment.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.export_24
        Me.lnkProcessPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkProcessPayment.ImageSize = 24
        Me.lnkProcessPayment.Location = New System.Drawing.Point(537, 156)
        Me.lnkProcessPayment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lnkProcessPayment.Name = "lnkProcessPayment"
        Me.lnkProcessPayment.Size = New System.Drawing.Size(120, 28)
        Me.lnkProcessPayment.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkProcessPayment.TabIndex = 107
        Me.lnkProcessPayment.Text = "Process"
        Me.lnkProcessPayment.UseCustomBackColor = True
        Me.lnkProcessPayment.UseSelectable = True
        Me.lnkProcessPayment.UseStyleColors = True
        '
        'dtRequest
        '
        Me.dtRequest.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRequest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRequest.Location = New System.Drawing.Point(170, 26)
        Me.dtRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtRequest.Name = "dtRequest"
        Me.dtRequest.Size = New System.Drawing.Size(137, 26)
        Me.dtRequest.TabIndex = 21
        Me.dtRequest.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Payee / Supplier Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 18)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Check Payment Date :"
        '
        'txtCheckNumber
        '
        Me.txtCheckNumber.Location = New System.Drawing.Point(470, 110)
        Me.txtCheckNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCheckNumber.MaxLength = 10
        Me.txtCheckNumber.Name = "txtCheckNumber"
        Me.txtCheckNumber.Size = New System.Drawing.Size(170, 26)
        Me.txtCheckNumber.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(400, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 18)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Check # :"
        '
        'lblBankName
        '
        Me.lblBankName.AutoSize = True
        Me.lblBankName.Location = New System.Drawing.Point(467, 72)
        Me.lblBankName.Name = "lblBankName"
        Me.lblBankName.Size = New System.Drawing.Size(85, 18)
        Me.lblBankName.TabIndex = 114
        Me.lblBankName.Text = "Bank Name :"
        '
        'frmVoucherPaymentRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 557)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmVoucherPaymentRequest"
        Me.Text = "Voucher List"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgUserVoucherList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgUserVoucherList As DataGridView
    Friend WithEvents lnkPrint As MetroFramework.Controls.MetroLink
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents txtCheckNumber As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dtRequest As DateTimePicker
    Friend WithEvents MetroLink2 As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkProcessPayment As MetroFramework.Controls.MetroLink
    Friend WithEvents ddAccounts As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtPayeeName As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPayeeSupplierName As Label
    Friend WithEvents lblBankName As Label
End Class
