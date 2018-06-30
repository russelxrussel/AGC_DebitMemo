<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDebitMemoRequest
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAttachImage = New MetroFramework.Controls.MetroButton()
        Me.btnAddRequestItem = New MetroFramework.Controls.MetroButton()
        Me.lblDMRSeries = New MetroFramework.Controls.MetroLabel()
        Me.lblTotalAmount = New MetroFramework.Controls.MetroLabel()
        Me.btnProcess = New MetroFramework.Controls.MetroButton()
        Me.dgRequestList = New MetroFramework.Controls.MetroGrid()
        Me.dtRequest = New System.Windows.Forms.DateTimePicker()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOthers = New System.Windows.Forms.TextBox()
        Me.pbAttachment = New System.Windows.Forms.PictureBox()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.cmbSupervisor = New System.Windows.Forms.ComboBox()
        Me.cmbItem = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDocumentRemarks = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.dgRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttachImage
        '
        Me.btnAttachImage.Location = New System.Drawing.Point(405, 144)
        Me.btnAttachImage.Name = "btnAttachImage"
        Me.btnAttachImage.Size = New System.Drawing.Size(81, 25)
        Me.btnAttachImage.TabIndex = 10
        Me.btnAttachImage.Text = "A&ttachment"
        Me.btnAttachImage.UseSelectable = True
        '
        'btnAddRequestItem
        '
        Me.btnAddRequestItem.Location = New System.Drawing.Point(405, 184)
        Me.btnAddRequestItem.Name = "btnAddRequestItem"
        Me.btnAddRequestItem.Size = New System.Drawing.Size(81, 25)
        Me.btnAddRequestItem.TabIndex = 11
        Me.btnAddRequestItem.Text = "&Add"
        Me.btnAddRequestItem.UseSelectable = True
        '
        'lblDMRSeries
        '
        Me.lblDMRSeries.AutoSize = True
        Me.lblDMRSeries.BackColor = System.Drawing.Color.Transparent
        Me.lblDMRSeries.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDMRSeries.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblDMRSeries.Location = New System.Drawing.Point(12, 9)
        Me.lblDMRSeries.Name = "lblDMRSeries"
        Me.lblDMRSeries.Size = New System.Drawing.Size(70, 25)
        Me.lblDMRSeries.TabIndex = 10
        Me.lblDMRSeries.Text = "SERIES"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalAmount.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblTotalAmount.Location = New System.Drawing.Point(12, 406)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(17, 19)
        Me.lblTotalAmount.TabIndex = 10
        Me.lblTotalAmount.Text = "0"
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProcess.Location = New System.Drawing.Point(384, 348)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(104, 32)
        Me.btnProcess.TabIndex = 14
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseSelectable = True
        '
        'dgRequestList
        '
        Me.dgRequestList.AllowUserToAddRows = False
        Me.dgRequestList.AllowUserToDeleteRows = False
        Me.dgRequestList.AllowUserToResizeRows = False
        Me.dgRequestList.BackgroundColor = System.Drawing.Color.Ivory
        Me.dgRequestList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgRequestList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgRequestList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRequestList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRequestList.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgRequestList.EnableHeadersVisualStyles = False
        Me.dgRequestList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgRequestList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestList.Location = New System.Drawing.Point(12, 222)
        Me.dgRequestList.Name = "dgRequestList"
        Me.dgRequestList.ReadOnly = True
        Me.dgRequestList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRequestList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgRequestList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRequestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRequestList.Size = New System.Drawing.Size(476, 108)
        Me.dgRequestList.TabIndex = 15
        Me.dgRequestList.UseCustomBackColor = True
        '
        'dtRequest
        '
        Me.dtRequest.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRequest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRequest.Location = New System.Drawing.Point(106, 50)
        Me.dtRequest.Name = "dtRequest"
        Me.dtRequest.Size = New System.Drawing.Size(95, 22)
        Me.dtRequest.TabIndex = 0
        Me.dtRequest.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(305, 48)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(183, 22)
        Me.cmbBranch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 14)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date Request :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(248, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Branch :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 14)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sr/Supervisor :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 127)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 14)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Item :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 14)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Quantity :"
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Location = New System.Drawing.Point(107, 147)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(84, 22)
        Me.nudQuantity.TabIndex = 7
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(107, 175)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(112, 23)
        Me.txtUnitPrice.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 184)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 14)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Unit Price:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(295, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 14)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Detail :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOthers
        '
        Me.txtOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.Location = New System.Drawing.Point(348, 119)
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOthers.Size = New System.Drawing.Size(138, 23)
        Me.txtOthers.TabIndex = 9
        '
        'pbAttachment
        '
        Me.pbAttachment.Location = New System.Drawing.Point(388, -7)
        Me.pbAttachment.Name = "pbAttachment"
        Me.pbAttachment.Size = New System.Drawing.Size(100, 50)
        Me.pbAttachment.TabIndex = 27
        Me.pbAttachment.TabStop = False
        Me.pbAttachment.Visible = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(345, 164)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(13, 14)
        Me.lblFileName.TabIndex = 28
        Me.lblFileName.Text = ".."
        '
        'cmbSupervisor
        '
        Me.cmbSupervisor.BackColor = System.Drawing.Color.White
        Me.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSupervisor.FormattingEnabled = True
        Me.cmbSupervisor.Location = New System.Drawing.Point(305, 76)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(183, 22)
        Me.cmbSupervisor.TabIndex = 29
        '
        'cmbItem
        '
        Me.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(106, 120)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(183, 22)
        Me.cmbItem.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(393, 351)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 36)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(414, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 25)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 334)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 14)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Document Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocumentRemarks
        '
        Me.txtDocumentRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentRemarks.Location = New System.Drawing.Point(12, 351)
        Me.txtDocumentRemarks.Multiline = True
        Me.txtDocumentRemarks.Name = "txtDocumentRemarks"
        Me.txtDocumentRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocumentRemarks.Size = New System.Drawing.Size(252, 52)
        Me.txtDocumentRemarks.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(-6, 106)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(535, 3)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Label11"
        '
        'frmDebitMemoRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(505, 433)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtDocumentRemarks)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbItem)
        Me.Controls.Add(Me.cmbSupervisor)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.pbAttachment)
        Me.Controls.Add(Me.txtOthers)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnAddRequestItem)
        Me.Controls.Add(Me.dgRequestList)
        Me.Controls.Add(Me.btnAttachImage)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbBranch)
        Me.Controls.Add(Me.dtRequest)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.lblTotalAmount)
        Me.Controls.Add(Me.lblDMRSeries)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDebitMemoRequest"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Debit Memo Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgRequestList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddRequestItem As MetroFramework.Controls.MetroButton
    Friend WithEvents dgRequestList As MetroFramework.Controls.MetroGrid
    Friend WithEvents lblDMRSeries As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnProcess As MetroFramework.Controls.MetroButton
    Friend WithEvents lblTotalAmount As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnAttachImage As MetroFramework.Controls.MetroButton
    Friend WithEvents dtRequest As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtUnitPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtOthers As System.Windows.Forms.TextBox
    Friend WithEvents pbAttachment As System.Windows.Forms.PictureBox
    Friend WithEvents lblFileName As System.Windows.Forms.Label
    Friend WithEvents cmbSupervisor As ComboBox
    Friend WithEvents cmbItem As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDocumentRemarks As TextBox
    Friend WithEvents Label11 As Label
End Class
