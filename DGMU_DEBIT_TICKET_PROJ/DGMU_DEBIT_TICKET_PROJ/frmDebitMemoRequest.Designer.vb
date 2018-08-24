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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnAttachImage = New MetroFramework.Controls.MetroButton()
        Me.btnAddRequestItem = New MetroFramework.Controls.MetroButton()
        Me.lblDMRSeries = New MetroFramework.Controls.MetroLabel()
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
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.dgRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAttachImage
        '
        Me.btnAttachImage.Location = New System.Drawing.Point(540, 168)
        Me.btnAttachImage.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAttachImage.Name = "btnAttachImage"
        Me.btnAttachImage.Size = New System.Drawing.Size(108, 32)
        Me.btnAttachImage.TabIndex = 10
        Me.btnAttachImage.Text = "A&ttachment"
        Me.btnAttachImage.UseSelectable = True
        '
        'btnAddRequestItem
        '
        Me.btnAddRequestItem.Location = New System.Drawing.Point(540, 215)
        Me.btnAddRequestItem.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddRequestItem.Name = "btnAddRequestItem"
        Me.btnAddRequestItem.Size = New System.Drawing.Size(108, 32)
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
        Me.lblDMRSeries.Location = New System.Drawing.Point(15, 3)
        Me.lblDMRSeries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDMRSeries.Name = "lblDMRSeries"
        Me.lblDMRSeries.Size = New System.Drawing.Size(70, 25)
        Me.lblDMRSeries.TabIndex = 10
        Me.lblDMRSeries.Text = "SERIES"
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProcess.Location = New System.Drawing.Point(509, 462)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(139, 41)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRequestList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgRequestList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer), CType(CType(136, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgRequestList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgRequestList.EnableHeadersVisualStyles = False
        Me.dgRequestList.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.dgRequestList.GridColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgRequestList.Location = New System.Drawing.Point(16, 260)
        Me.dgRequestList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgRequestList.Name = "dgRequestList"
        Me.dgRequestList.ReadOnly = True
        Me.dgRequestList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(247, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(17, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgRequestList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgRequestList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgRequestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgRequestList.Size = New System.Drawing.Size(632, 154)
        Me.dgRequestList.TabIndex = 15
        Me.dgRequestList.UseCustomBackColor = True
        '
        'dtRequest
        '
        Me.dtRequest.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtRequest.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtRequest.Location = New System.Drawing.Point(123, 40)
        Me.dtRequest.Margin = New System.Windows.Forms.Padding(4)
        Me.dtRequest.Name = "dtRequest"
        Me.dtRequest.Size = New System.Drawing.Size(125, 26)
        Me.dtRequest.TabIndex = 0
        Me.dtRequest.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'cmbBranch
        '
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.FormattingEnabled = True
        Me.cmbBranch.Location = New System.Drawing.Point(407, 46)
        Me.cmbBranch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(243, 26)
        Me.cmbBranch.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Date Request :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Branch :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(282, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Sr/Supervisor :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 130)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 18)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Item :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 168)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Quantity :"
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Location = New System.Drawing.Point(143, 168)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(4)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(112, 26)
        Me.nudQuantity.TabIndex = 7
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnitPrice.Location = New System.Drawing.Point(141, 215)
        Me.txtUnitPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(148, 23)
        Me.txtUnitPrice.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 215)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Unit Price:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(393, 130)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 18)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Detail :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOthers
        '
        Me.txtOthers.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthers.Location = New System.Drawing.Point(464, 130)
        Me.txtOthers.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOthers.Name = "txtOthers"
        Me.txtOthers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOthers.Size = New System.Drawing.Size(183, 23)
        Me.txtOthers.TabIndex = 9
        '
        'pbAttachment
        '
        Me.pbAttachment.Location = New System.Drawing.Point(515, -27)
        Me.pbAttachment.Margin = New System.Windows.Forms.Padding(4)
        Me.pbAttachment.Name = "pbAttachment"
        Me.pbAttachment.Size = New System.Drawing.Size(133, 64)
        Me.pbAttachment.TabIndex = 27
        Me.pbAttachment.TabStop = False
        Me.pbAttachment.Visible = False
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.Location = New System.Drawing.Point(461, 198)
        Me.lblFileName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.cmbSupervisor.Location = New System.Drawing.Point(408, 80)
        Me.cmbSupervisor.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSupervisor.Name = "cmbSupervisor"
        Me.cmbSupervisor.Size = New System.Drawing.Size(243, 26)
        Me.cmbSupervisor.TabIndex = 29
        '
        'cmbItem
        '
        Me.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(141, 130)
        Me.cmbItem.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(243, 26)
        Me.cmbItem.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(521, 466)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 46)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(552, 223)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 32)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 440)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 18)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Document Remarks :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDocumentRemarks
        '
        Me.txtDocumentRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDocumentRemarks.Location = New System.Drawing.Point(15, 462)
        Me.txtDocumentRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDocumentRemarks.Multiline = True
        Me.txtDocumentRemarks.Name = "txtDocumentRemarks"
        Me.txtDocumentRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDocumentRemarks.Size = New System.Drawing.Size(335, 51)
        Me.txtDocumentRemarks.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(-8, 113)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(713, 4)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Label11"
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.AutoSize = True
        Me.lblTotalAmount.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmount.Location = New System.Drawing.Point(17, 418)
        Me.lblTotalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(15, 18)
        Me.lblTotalAmount.TabIndex = 36
        Me.lblTotalAmount.Text = "0"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(-8, 436)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(713, 4)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Label12"
        '
        'frmDebitMemoRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(659, 520)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lblTotalAmount)
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
        Me.Controls.Add(Me.lblDMRSeries)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents Label12 As Label
End Class
