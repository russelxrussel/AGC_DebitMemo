<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGasSlip
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
        Me.lblGasSlipSeries = New MetroFramework.Controls.MetroLabel()
        Me.dtCreated = New System.Windows.Forms.DateTimePicker()
        Me.ddPlateNumber = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.ddDriverList = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnProcess = New MetroFramework.Controls.MetroButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.lnkReprintGasSlip = New MetroFramework.Controls.MetroButton()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGasSlipSeries
        '
        Me.lblGasSlipSeries.AutoSize = True
        Me.lblGasSlipSeries.BackColor = System.Drawing.Color.Transparent
        Me.lblGasSlipSeries.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblGasSlipSeries.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblGasSlipSeries.Location = New System.Drawing.Point(161, 18)
        Me.lblGasSlipSeries.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGasSlipSeries.Name = "lblGasSlipSeries"
        Me.lblGasSlipSeries.Size = New System.Drawing.Size(70, 25)
        Me.lblGasSlipSeries.TabIndex = 10
        Me.lblGasSlipSeries.Text = "SERIES"
        '
        'dtCreated
        '
        Me.dtCreated.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtCreated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtCreated.Location = New System.Drawing.Point(161, 60)
        Me.dtCreated.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dtCreated.Name = "dtCreated"
        Me.dtCreated.Size = New System.Drawing.Size(155, 31)
        Me.dtCreated.TabIndex = 0
        Me.dtCreated.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'ddPlateNumber
        '
        Me.ddPlateNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddPlateNumber.FormattingEnabled = True
        Me.ddPlateNumber.Location = New System.Drawing.Point(161, 157)
        Me.ddPlateNumber.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ddPlateNumber.Name = "ddPlateNumber"
        Me.ddPlateNumber.Size = New System.Drawing.Size(303, 31)
        Me.ddPlateNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Created Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 23)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Plate Number :"
        '
        'nudQuantity
        '
        Me.nudQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nudQuantity.Location = New System.Drawing.Point(716, 1032)
        Me.nudQuantity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(140, 31)
        Me.nudQuantity.TabIndex = 7
        Me.nudQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.nudQuantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudQuantity.Visible = False
        '
        'ddDriverList
        '
        Me.ddDriverList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddDriverList.FormattingEnabled = True
        Me.ddDriverList.Location = New System.Drawing.Point(161, 109)
        Me.ddDriverList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ddDriverList.Name = "ddDriverList"
        Me.ddDriverList.Size = New System.Drawing.Size(303, 31)
        Me.ddDriverList.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(20, 112)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(116, 23)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Driver Name :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 20)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(142, 23)
        Me.Label16.TabIndex = 39
        Me.Label16.Text = "Gas Slip Series #: "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(58, 226)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(80, 23)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "Product :"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProduct
        '
        Me.txtProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProduct.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProduct.Location = New System.Drawing.Point(159, 220)
        Me.txtProduct.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(306, 29)
        Me.txtProduct.TabIndex = 41
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 286)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Remarks / Notes:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(-2, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(501, 10)
        Me.Label4.TabIndex = 43
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnProcess.Location = New System.Drawing.Point(326, 431)
        Me.btnProcess.Margin = New System.Windows.Forms.Padding(4)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(139, 41)
        Me.btnProcess.TabIndex = 44
        Me.btnProcess.Text = "&Process"
        Me.btnProcess.UseSelectable = True
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(338, 435)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 46)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Label5"
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemarks.Location = New System.Drawing.Point(13, 313)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(465, 110)
        Me.txtRemarks.TabIndex = 46
        '
        'lnkReprintGasSlip
        '
        Me.lnkReprintGasSlip.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lnkReprintGasSlip.Location = New System.Drawing.Point(365, 60)
        Me.lnkReprintGasSlip.Margin = New System.Windows.Forms.Padding(4)
        Me.lnkReprintGasSlip.Name = "lnkReprintGasSlip"
        Me.lnkReprintGasSlip.Size = New System.Drawing.Size(104, 31)
        Me.lnkReprintGasSlip.TabIndex = 47
        Me.lnkReprintGasSlip.Text = "&Reprint Gas Slip"
        Me.lnkReprintGasSlip.UseSelectable = True
        '
        'frmGasSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(491, 504)
        Me.Controls.Add(Me.lnkReprintGasSlip)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ddDriverList)
        Me.Controls.Add(Me.nudQuantity)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ddPlateNumber)
        Me.Controls.Add(Me.dtCreated)
        Me.Controls.Add(Me.lblGasSlipSeries)
        Me.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmGasSlip"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Create Gasoline Slip"
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGasSlipSeries As MetroFramework.Controls.MetroLabel
    Friend WithEvents dtCreated As System.Windows.Forms.DateTimePicker
    Friend WithEvents ddPlateNumber As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents ddDriverList As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txtProduct As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnProcess As MetroFramework.Controls.MetroButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents lnkReprintGasSlip As MetroFramework.Controls.MetroButton
End Class
