<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVoucherModule
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAttachImage = New MetroFramework.Controls.MetroButton()
        Me.btnAddRequestItem = New MetroFramework.Controls.MetroButton()
        Me.lblVoucherSeries = New MetroFramework.Controls.MetroLabel()
        Me.btnProcess = New MetroFramework.Controls.MetroButton()
        Me.dtRequest = New System.Windows.Forms.DateTimePicker()
        Me.ddCompany = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.pbAttachment = New System.Windows.Forms.PictureBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.ddSupplier_Payee = New System.Windows.Forms.ComboBox()
        Me.ddVoucherType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDocumentRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgVoucherItemList = New MetroFramework.Controls.MetroGrid()
        Me.txtItemDiscount = New System.Windows.Forms.TextBox()
        Me.txtItemAmount = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTotalDiscount2 = New System.Windows.Forms.TextBox()
        Me.txtTotalDiscount1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotalItemDiscount = New System.Windows.Forms.Label()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgVoucherItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAttachImage
        '
        Me.btnAttachImage.Location = New System.Drawing.Point(17, 168)
        Me.btnAttachImage.Name = "btnAttachImage"
        Me.btnAttachImage.Size = New System.Drawing.Size(94, 27)
        Me.btnAttachImage.TabIndex = 10
        Me.btnAttachImage.Text = "A&ttachment"
        Me.btnAttachImage.UseSelectable = True
        '
        'btnAddRequestItem
        '
        Me.btnAddRequestItem.Location = New System.Drawing.Point(251, 168)
        Me.btnAddRequestItem.Name = "btnAddRequestItem"
        Me.btnAddRequestItem.Size = New System.Drawing.Size(94, 27)
        Me.btnAddRequestItem.TabIndex = 11
        Me.btnAddRequestItem.Text = "&Add"
        Me.btnAddRequestItem.UseSelectable = True
        '
        'lblVoucherSeries
        '
        Me.lblVoucherSeries.AutoSize = True
        Me.lblVoucherSeries.BackColor = System.Drawing.Color.Transparent
        Me.lblVoucherSeries.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblVoucherSeries.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblVoucherSeries.Location = New System.Drawing.Point(14, 10)
        Me.lblVoucherSeries.Name = "lblVoucherSeries"
        Me.lblVoucherSeries.Size = New System.Drawing.Size(70, 25)
        Me.lblVoucherSeries.TabIndex = 10
        Me.lblVoucherSeries.Text = "SERIES"
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProcess.Location = New System.Drawing.Point(14, 162)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(355, 34)
        Me.btnProcess.TabIndex = 14
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseSelectable = True
        '
        'dtRequest
        '
        Me.dtRequest.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRequest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRequest.Location = New System.Drawing.Point(132, 81)
        Me.dtRequest.Name = "dtRequest"
        Me.dtRequest.Size = New System.Drawing.Size(110, 23)
        Me.dtRequest.TabIndex = 0
        Me.dtRequest.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'ddCompany
        '
        Me.ddCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddCompany.FormattingEnabled = True
        Me.ddCompany.Location = New System.Drawing.Point(132, 110)
        Me.ddCompany.Name = "ddCompany"
        Me.ddCompany.Size = New System.Drawing.Size(213, 23)
        Me.ddCompany.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Voucher Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(44, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Company :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Supplier / Payee :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 15)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Description :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(28, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 15)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Discount :"
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Location = New System.Drawing.Point(184, 565)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(98, 23)
        Me.nudQuantity.TabIndex = 7
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(35, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Amount :"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(100, 35)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(264, 51)
        Me.txtDescription.TabIndex = 9
        '
        'pbAttachment
        '
        Me.pbAttachment.Location = New System.Drawing.Point(228, 286)
        Me.pbAttachment.Name = "pbAttachment"
        Me.pbAttachment.Size = New System.Drawing.Size(117, 54)
        Me.pbAttachment.TabIndex = 27
        Me.pbAttachment.TabStop = False
        Me.pbAttachment.Visible = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(14, 197)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(13, 14)
        Me.lblFileName.TabIndex = 28
        Me.lblFileName.Text = ".."
        '
        'ddSupplier_Payee
        '
        Me.ddSupplier_Payee.BackColor = System.Drawing.Color.White
        Me.ddSupplier_Payee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddSupplier_Payee.FormattingEnabled = True
        Me.ddSupplier_Payee.Location = New System.Drawing.Point(132, 139)
        Me.ddSupplier_Payee.Name = "ddSupplier_Payee"
        Me.ddSupplier_Payee.Size = New System.Drawing.Size(213, 23)
        Me.ddSupplier_Payee.TabIndex = 29
        '
        'ddVoucherType
        '
        Me.ddVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddVoucherType.FormattingEnabled = True
        Me.ddVoucherType.Location = New System.Drawing.Point(132, 52)
        Me.ddVoucherType.Name = "ddVoucherType"
        Me.ddVoucherType.Size = New System.Drawing.Size(213, 23)
        Me.ddVoucherType.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(350, 31)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(262, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 27)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 15)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Document Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocumentRemarks
        '
        Me.txtDocumentRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentRemarks.Location = New System.Drawing.Point(8, 200)
        Me.txtDocumentRemarks.Multiline = True
        Me.txtDocumentRemarks.Name = "txtDocumentRemarks"
        Me.txtDocumentRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocumentRemarks.Size = New System.Drawing.Size(337, 64)
        Me.txtDocumentRemarks.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(-61, 271)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(406, 5)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Label11"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(28, 127)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalAmount.TabIndex = 36
        Me.lblTotalAmount.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 15)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Voucher Type :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgVoucherItemList)
        Me.GroupBox1.Controls.Add(Me.txtItemDiscount)
        Me.GroupBox1.Controls.Add(Me.txtItemAmount)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.btnAttachImage)
        Me.GroupBox1.Controls.Add(Me.lblFileName)
        Me.GroupBox1.Controls.Add(Me.btnAddRequestItem)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(362, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 330)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Particular"
        '
        'dgVoucherItemList
        '
        Me.dgVoucherItemList.AllowUserToAddRows = False
        Me.dgVoucherItemList.AllowUserToDeleteRows = False
        Me.dgVoucherItemList.AllowUserToResizeRows = False
        Me.dgVoucherItemList.BackgroundColor = System.Drawing.Color.Ivory
        Me.dgVoucherItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgVoucherItemList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgVoucherItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVoucherItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgVoucherItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgVoucherItemList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgVoucherItemList.EnableHeadersVisualStyles = False
        Me.dgVoucherItemList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgVoucherItemList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgVoucherItemList.Location = New System.Drawing.Point(12, 223)
        Me.dgVoucherItemList.Name = "dgVoucherItemList"
        Me.dgVoucherItemList.ReadOnly = True
        Me.dgVoucherItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgVoucherItemList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgVoucherItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgVoucherItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVoucherItemList.Size = New System.Drawing.Size(358, 98)
        Me.dgVoucherItemList.TabIndex = 33
        Me.dgVoucherItemList.UseCustomBackColor = True
        '
        'txtItemDiscount
        '
        Me.txtItemDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDiscount.Location = New System.Drawing.Point(100, 130)
        Me.txtItemDiscount.Name = "txtItemDiscount"
        Me.txtItemDiscount.Size = New System.Drawing.Size(130, 23)
        Me.txtItemDiscount.TabIndex = 26
        '
        'txtItemAmount
        '
        Me.txtItemAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemAmount.Location = New System.Drawing.Point(100, 98)
        Me.txtItemAmount.Name = "txtItemAmount"
        Me.txtItemAmount.Size = New System.Drawing.Size(130, 23)
        Me.txtItemAmount.TabIndex = 25
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalItemDiscount)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtTotalDiscount2)
        Me.GroupBox2.Controls.Add(Me.txtTotalDiscount1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox2.Controls.Add(Me.btnProcess)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(362, 346)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 217)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Breakdown "
        '
        'txtTotalDiscount2
        '
        Me.txtTotalDiscount2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscount2.Location = New System.Drawing.Point(141, 79)
        Me.txtTotalDiscount2.Name = "txtTotalDiscount2"
        Me.txtTotalDiscount2.Size = New System.Drawing.Size(130, 23)
        Me.txtTotalDiscount2.TabIndex = 38
        '
        'txtTotalDiscount1
        '
        Me.txtTotalDiscount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscount1.Location = New System.Drawing.Point(141, 49)
        Me.txtTotalDiscount1.Name = "txtTotalDiscount1"
        Me.txtTotalDiscount1.Size = New System.Drawing.Size(130, 23)
        Me.txtTotalDiscount1.TabIndex = 37
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(63, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 15)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Discount 2 :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 55)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 15)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Discount 1 :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 28)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(122, 15)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Total Item Discount  :"
        '
        'lblTotalItemDiscount
        '
        Me.lblTotalItemDiscount.AutoSize = True
        Me.lblTotalItemDiscount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItemDiscount.Location = New System.Drawing.Point(141, 25)
        Me.lblTotalItemDiscount.Name = "lblTotalItemDiscount"
        Me.lblTotalItemDiscount.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalItemDiscount.TabIndex = 40
        Me.lblTotalItemDiscount.Text = "0"
        '
        'frmVoucherModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(752, 564)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDocumentRemarks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ddVoucherType)
        Me.Controls.Add(Me.ddSupplier_Payee)
        Me.Controls.Add(Me.pbAttachment)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddCompany)
        Me.Controls.Add(Me.dtRequest)
        Me.Controls.Add(Me.lblVoucherSeries)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmVoucherModule"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Voucher"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgVoucherItemList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddRequestItem As MetroFramework.Controls.MetroButton
    Friend WithEvents lblVoucherSeries As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnProcess As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAttachImage As MetroFramework.Controls.MetroButton
    Friend WithEvents dtRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents ddCompany As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents pbAttachment As System.Windows.Forms.PictureBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents ddSupplier_Payee As ComboBox
    Friend WithEvents ddVoucherType As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDocumentRemarks As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtItemDiscount As TextBox
    Friend WithEvents txtItemAmount As TextBox
    Friend WithEvents dgVoucherItemList As MetroFramework.Controls.MetroGrid
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalDiscount2 As TextBox
    Friend WithEvents txtTotalDiscount1 As TextBox
    Friend WithEvents lblTotalItemDiscount As Label
    Friend WithEvents Label14 As Label
End Class
