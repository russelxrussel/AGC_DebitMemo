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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTotalBeforeDiscount = New System.Windows.Forms.Label()
        Me.lblTotalAllDiscount = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblTotalItemDiscount = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTotalDiscount2 = New System.Windows.Forms.TextBox()
        Me.txtTotalDiscount1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgVoucherItemList = New MetroFramework.Controls.MetroGrid()
        Me.txtItemDiscount = New System.Windows.Forms.TextBox()
        Me.txtItemAmount = New System.Windows.Forms.TextBox()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgVoucherItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttachImage
        '
        Me.btnAttachImage.Location = New System.Drawing.Point(667, 117)
        Me.btnAttachImage.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAttachImage.Name = "btnAttachImage"
        Me.btnAttachImage.Size = New System.Drawing.Size(107, 32)
        Me.btnAttachImage.TabIndex = 4
        Me.btnAttachImage.Text = "A&ttachment"
        Me.btnAttachImage.UseSelectable = True
        '
        'btnAddRequestItem
        '
        Me.btnAddRequestItem.Location = New System.Drawing.Point(624, 27)
        Me.btnAddRequestItem.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddRequestItem.Name = "btnAddRequestItem"
        Me.btnAddRequestItem.Size = New System.Drawing.Size(107, 32)
        Me.btnAddRequestItem.TabIndex = 3
        Me.btnAddRequestItem.Text = "&Add"
        Me.btnAddRequestItem.UseSelectable = True
        '
        'lblVoucherSeries
        '
        Me.lblVoucherSeries.AutoSize = True
        Me.lblVoucherSeries.BackColor = System.Drawing.Color.Transparent
        Me.lblVoucherSeries.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblVoucherSeries.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblVoucherSeries.Location = New System.Drawing.Point(12, 9)
        Me.lblVoucherSeries.Name = "lblVoucherSeries"
        Me.lblVoucherSeries.Size = New System.Drawing.Size(70, 25)
        Me.lblVoucherSeries.TabIndex = 10
        Me.lblVoucherSeries.Text = "SERIES"
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProcess.Location = New System.Drawing.Point(7, 134)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(726, 38)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseSelectable = True
        '
        'dtRequest
        '
        Me.dtRequest.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRequest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRequest.Location = New System.Drawing.Point(117, 42)
        Me.dtRequest.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtRequest.Name = "dtRequest"
        Me.dtRequest.Size = New System.Drawing.Size(125, 26)
        Me.dtRequest.TabIndex = 0
        Me.dtRequest.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'ddCompany
        '
        Me.ddCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddCompany.FormattingEnabled = True
        Me.ddCompany.Location = New System.Drawing.Point(531, 42)
        Me.ddCompany.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ddCompany.Name = "ddCompany"
        Me.ddCompany.Size = New System.Drawing.Size(243, 26)
        Me.ddCompany.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Voucher Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(451, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Company :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(408, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Supplier / Payee :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Description :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(376, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Discount :"
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Location = New System.Drawing.Point(573, 808)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(112, 26)
        Me.nudQuantity.TabIndex = 7
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(376, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Amount :"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(109, 27)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDescription.Size = New System.Drawing.Size(258, 51)
        Me.txtDescription.TabIndex = 0
        '
        'pbAttachment
        '
        Me.pbAttachment.Location = New System.Drawing.Point(261, 343)
        Me.pbAttachment.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pbAttachment.Name = "pbAttachment"
        Me.pbAttachment.Size = New System.Drawing.Size(134, 65)
        Me.pbAttachment.TabIndex = 27
        Me.pbAttachment.TabStop = False
        Me.pbAttachment.Visible = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(528, 117)
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
        Me.ddSupplier_Payee.Location = New System.Drawing.Point(531, 77)
        Me.ddSupplier_Payee.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ddSupplier_Payee.Name = "ddSupplier_Payee"
        Me.ddSupplier_Payee.Size = New System.Drawing.Size(243, 26)
        Me.ddSupplier_Payee.TabIndex = 3
        '
        'ddVoucherType
        '
        Me.ddVoucherType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddVoucherType.FormattingEnabled = True
        Me.ddVoucherType.Location = New System.Drawing.Point(117, 77)
        Me.ddVoucherType.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ddVoucherType.Name = "ddVoucherType"
        Me.ddVoucherType.Size = New System.Drawing.Size(243, 26)
        Me.ddVoucherType.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(28, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(709, 36)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(635, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 32)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Document Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocumentRemarks
        '
        Me.txtDocumentRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentRemarks.Location = New System.Drawing.Point(153, 117)
        Me.txtDocumentRemarks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDocumentRemarks.Multiline = True
        Me.txtDocumentRemarks.Name = "txtDocumentRemarks"
        Me.txtDocumentRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocumentRemarks.Size = New System.Drawing.Size(364, 50)
        Me.txtDocumentRemarks.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(-1, 177)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(790, 2)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Label11"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(419, 79)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalAmount.TabIndex = 36
        Me.lblTotalAmount.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(13, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 18)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Voucher Type :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dgVoucherItemList)
        Me.GroupBox1.Controls.Add(Me.txtItemDiscount)
        Me.GroupBox1.Controls.Add(Me.txtItemAmount)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.btnAddRequestItem)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 183)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(766, 465)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Particular"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalBeforeDiscount)
        Me.GroupBox2.Controls.Add(Me.lblTotalAllDiscount)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblTotalItemDiscount)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtTotalDiscount2)
        Me.GroupBox2.Controls.Add(Me.txtTotalDiscount1)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblTotalAmount)
        Me.GroupBox2.Controls.Add(Me.btnProcess)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 177)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(751, 193)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Total Breakdown "
        '
        'lblTotalBeforeDiscount
        '
        Me.lblTotalBeforeDiscount.AutoSize = True
        Me.lblTotalBeforeDiscount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalBeforeDiscount.Location = New System.Drawing.Point(419, 23)
        Me.lblTotalBeforeDiscount.Name = "lblTotalBeforeDiscount"
        Me.lblTotalBeforeDiscount.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalBeforeDiscount.TabIndex = 43
        Me.lblTotalBeforeDiscount.Text = "0"
        '
        'lblTotalAllDiscount
        '
        Me.lblTotalAllDiscount.AutoSize = True
        Me.lblTotalAllDiscount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAllDiscount.Location = New System.Drawing.Point(161, 112)
        Me.lblTotalAllDiscount.Name = "lblTotalAllDiscount"
        Me.lblTotalAllDiscount.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalAllDiscount.TabIndex = 42
        Me.lblTotalAllDiscount.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(125, 18)
        Me.Label15.TabIndex = 41
        Me.Label15.Text = "Total All Discount  :"
        '
        'lblTotalItemDiscount
        '
        Me.lblTotalItemDiscount.AutoSize = True
        Me.lblTotalItemDiscount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalItemDiscount.Location = New System.Drawing.Point(161, 23)
        Me.lblTotalItemDiscount.Name = "lblTotalItemDiscount"
        Me.lblTotalItemDiscount.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalItemDiscount.TabIndex = 40
        Me.lblTotalItemDiscount.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(137, 18)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Total Item Discount  :"
        '
        'txtTotalDiscount2
        '
        Me.txtTotalDiscount2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscount2.Location = New System.Drawing.Point(161, 79)
        Me.txtTotalDiscount2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalDiscount2.Name = "txtTotalDiscount2"
        Me.txtTotalDiscount2.Size = New System.Drawing.Size(148, 23)
        Me.txtTotalDiscount2.TabIndex = 1
        '
        'txtTotalDiscount1
        '
        Me.txtTotalDiscount1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalDiscount1.Location = New System.Drawing.Point(161, 50)
        Me.txtTotalDiscount1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTotalDiscount1.Name = "txtTotalDiscount1"
        Me.txtTotalDiscount1.Size = New System.Drawing.Size(148, 23)
        Me.txtTotalDiscount1.TabIndex = 0
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(71, 79)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 18)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Discount 2 :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(72, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(79, 18)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Discount 1 :"
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
        Me.dgVoucherItemList.Location = New System.Drawing.Point(9, 89)
        Me.dgVoucherItemList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
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
        Me.dgVoucherItemList.Size = New System.Drawing.Size(751, 80)
        Me.dgVoucherItemList.TabIndex = 33
        Me.dgVoucherItemList.UseCustomBackColor = True
        '
        'txtItemDiscount
        '
        Me.txtItemDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemDiscount.Location = New System.Drawing.Point(459, 58)
        Me.txtItemDiscount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemDiscount.Name = "txtItemDiscount"
        Me.txtItemDiscount.Size = New System.Drawing.Size(148, 23)
        Me.txtItemDiscount.TabIndex = 2
        '
        'txtItemAmount
        '
        Me.txtItemAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtItemAmount.Location = New System.Drawing.Point(458, 27)
        Me.txtItemAmount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtItemAmount.Name = "txtItemAmount"
        Me.txtItemAmount.Size = New System.Drawing.Size(148, 23)
        Me.txtItemAmount.TabIndex = 1
        '
        'frmVoucherModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(783, 559)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDocumentRemarks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ddVoucherType)
        Me.Controls.Add(Me.ddSupplier_Payee)
        Me.Controls.Add(Me.pbAttachment)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.btnAttachImage)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddCompany)
        Me.Controls.Add(Me.dtRequest)
        Me.Controls.Add(Me.lblVoucherSeries)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmVoucherModule"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Voucher"
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgVoucherItemList, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents lblTotalAllDiscount As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblTotalBeforeDiscount As Label
End Class
