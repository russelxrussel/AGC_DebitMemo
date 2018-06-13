<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprover
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
        Me.gpDMRequest = New System.Windows.Forms.GroupBox()
        Me.dgListOfDM = New System.Windows.Forms.DataGridView()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.gpListOfRequest = New System.Windows.Forms.GroupBox()
        Me.txtApproverNotes = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbDMRDetails = New System.Windows.Forms.GroupBox()
        Me.txtRequesteeNotes = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblDebitMemoNumber = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblSupervisor = New System.Windows.Forms.Label()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.lblRequestDate = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkApprovedAll = New System.Windows.Forms.CheckBox()
        Me.lnkViewAttachment = New System.Windows.Forms.LinkLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnProcessDecision = New System.Windows.Forms.Button()
        Me.dgListOfRequestItems = New System.Windows.Forms.DataGridView()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.gpDMRequest.SuspendLayout()
        CType(Me.dgListOfDM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.gpListOfRequest.SuspendLayout()
        Me.gbDMRDetails.SuspendLayout()
        CType(Me.dgListOfRequestItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gpDMRequest
        '
        Me.gpDMRequest.Controls.Add(Me.dgListOfDM)
        Me.gpDMRequest.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpDMRequest.Location = New System.Drawing.Point(3, 3)
        Me.gpDMRequest.Name = "gpDMRequest"
        Me.gpDMRequest.Size = New System.Drawing.Size(687, 306)
        Me.gpDMRequest.TabIndex = 0
        Me.gpDMRequest.TabStop = False
        Me.gpDMRequest.Text = "List of Open Debit Request"
        '
        'dgListOfDM
        '
        Me.dgListOfDM.AllowUserToAddRows = False
        Me.dgListOfDM.AllowUserToDeleteRows = False
        Me.dgListOfDM.AllowUserToResizeColumns = False
        Me.dgListOfDM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgListOfDM.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgListOfDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListOfDM.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dgListOfDM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgListOfDM.Location = New System.Drawing.Point(3, 20)
        Me.dgListOfDM.Name = "dgListOfDM"
        Me.dgListOfDM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListOfDM.Size = New System.Drawing.Size(681, 283)
        Me.dgListOfDM.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.gpDMRequest)
        Me.FlowLayoutPanel1.Controls.Add(Me.gpListOfRequest)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(704, 747)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'gpListOfRequest
        '
        Me.gpListOfRequest.Controls.Add(Me.txtApproverNotes)
        Me.gpListOfRequest.Controls.Add(Me.Label5)
        Me.gpListOfRequest.Controls.Add(Me.gbDMRDetails)
        Me.gpListOfRequest.Controls.Add(Me.chkApprovedAll)
        Me.gpListOfRequest.Controls.Add(Me.lnkViewAttachment)
        Me.gpListOfRequest.Controls.Add(Me.Button2)
        Me.gpListOfRequest.Controls.Add(Me.btnProcessDecision)
        Me.gpListOfRequest.Controls.Add(Me.dgListOfRequestItems)
        Me.gpListOfRequest.Location = New System.Drawing.Point(3, 315)
        Me.gpListOfRequest.Name = "gpListOfRequest"
        Me.gpListOfRequest.Size = New System.Drawing.Size(699, 400)
        Me.gpListOfRequest.TabIndex = 1
        Me.gpListOfRequest.TabStop = False
        Me.gpListOfRequest.Text = "List of Request Item(s)"
        '
        'txtApproverNotes
        '
        Me.txtApproverNotes.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApproverNotes.Location = New System.Drawing.Point(10, 312)
        Me.txtApproverNotes.Multiline = True
        Me.txtApproverNotes.Name = "txtApproverNotes"
        Me.txtApproverNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtApproverNotes.Size = New System.Drawing.Size(375, 62)
        Me.txtApproverNotes.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(154, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Approver Remarks / Notes :"
        '
        'gbDMRDetails
        '
        Me.gbDMRDetails.Controls.Add(Me.txtRequesteeNotes)
        Me.gbDMRDetails.Controls.Add(Me.Label6)
        Me.gbDMRDetails.Controls.Add(Me.lblDebitMemoNumber)
        Me.gbDMRDetails.Controls.Add(Me.Label4)
        Me.gbDMRDetails.Controls.Add(Me.lblSupervisor)
        Me.gbDMRDetails.Controls.Add(Me.lblBranch)
        Me.gbDMRDetails.Controls.Add(Me.lblRequestDate)
        Me.gbDMRDetails.Controls.Add(Me.Label3)
        Me.gbDMRDetails.Controls.Add(Me.Label2)
        Me.gbDMRDetails.Controls.Add(Me.Label1)
        Me.gbDMRDetails.Location = New System.Drawing.Point(10, 21)
        Me.gbDMRDetails.Name = "gbDMRDetails"
        Me.gbDMRDetails.Size = New System.Drawing.Size(465, 101)
        Me.gbDMRDetails.TabIndex = 4
        Me.gbDMRDetails.TabStop = False
        '
        'txtRequesteeNotes
        '
        Me.txtRequesteeNotes.Enabled = False
        Me.txtRequesteeNotes.Location = New System.Drawing.Point(187, 57)
        Me.txtRequesteeNotes.Multiline = True
        Me.txtRequesteeNotes.Name = "txtRequesteeNotes"
        Me.txtRequesteeNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRequesteeNotes.Size = New System.Drawing.Size(272, 34)
        Me.txtRequesteeNotes.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(162, 14)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Requestee Remarks / Notes:"
        '
        'lblDebitMemoNumber
        '
        Me.lblDebitMemoNumber.AutoSize = True
        Me.lblDebitMemoNumber.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDebitMemoNumber.Location = New System.Drawing.Point(96, 18)
        Me.lblDebitMemoNumber.Name = "lblDebitMemoNumber"
        Me.lblDebitMemoNumber.Size = New System.Drawing.Size(10, 14)
        Me.lblDebitMemoNumber.TabIndex = 8
        Me.lblDebitMemoNumber.Text = "."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Debit Memo #:"
        '
        'lblSupervisor
        '
        Me.lblSupervisor.AutoSize = True
        Me.lblSupervisor.Location = New System.Drawing.Point(266, 36)
        Me.lblSupervisor.Name = "lblSupervisor"
        Me.lblSupervisor.Size = New System.Drawing.Size(10, 14)
        Me.lblSupervisor.TabIndex = 5
        Me.lblSupervisor.Text = "."
        '
        'lblBranch
        '
        Me.lblBranch.AutoSize = True
        Me.lblBranch.Location = New System.Drawing.Point(266, 19)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(10, 14)
        Me.lblBranch.TabIndex = 4
        Me.lblBranch.Text = "."
        '
        'lblRequestDate
        '
        Me.lblRequestDate.AutoSize = True
        Me.lblRequestDate.Location = New System.Drawing.Point(96, 36)
        Me.lblRequestDate.Name = "lblRequestDate"
        Me.lblRequestDate.Size = New System.Drawing.Size(10, 14)
        Me.lblRequestDate.TabIndex = 3
        Me.lblRequestDate.Text = "."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(190, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Supervisor :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Branch:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Request Date:"
        '
        'chkApprovedAll
        '
        Me.chkApprovedAll.AutoSize = True
        Me.chkApprovedAll.Location = New System.Drawing.Point(589, 103)
        Me.chkApprovedAll.Name = "chkApprovedAll"
        Me.chkApprovedAll.Size = New System.Drawing.Size(95, 18)
        Me.chkApprovedAll.TabIndex = 3
        Me.chkApprovedAll.Text = "Approved All"
        Me.chkApprovedAll.UseVisualStyleBackColor = True
        '
        'lnkViewAttachment
        '
        Me.lnkViewAttachment.AutoSize = True
        Me.lnkViewAttachment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkViewAttachment.Location = New System.Drawing.Point(481, 104)
        Me.lnkViewAttachment.Name = "lnkViewAttachment"
        Me.lnkViewAttachment.Size = New System.Drawing.Size(99, 14)
        Me.lnkViewAttachment.TabIndex = 6
        Me.lnkViewAttachment.TabStop = True
        Me.lnkViewAttachment.Text = "View Attachment"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(612, 335)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "&Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnProcessDecision
        '
        Me.btnProcessDecision.BackColor = System.Drawing.Color.LightGreen
        Me.btnProcessDecision.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcessDecision.Location = New System.Drawing.Point(531, 335)
        Me.btnProcessDecision.Name = "btnProcessDecision"
        Me.btnProcessDecision.Size = New System.Drawing.Size(75, 37)
        Me.btnProcessDecision.TabIndex = 1
        Me.btnProcessDecision.Text = "&Process"
        Me.btnProcessDecision.UseVisualStyleBackColor = False
        '
        'dgListOfRequestItems
        '
        Me.dgListOfRequestItems.AllowUserToAddRows = False
        Me.dgListOfRequestItems.AllowUserToDeleteRows = False
        Me.dgListOfRequestItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgListOfRequestItems.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgListOfRequestItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListOfRequestItems.Location = New System.Drawing.Point(6, 127)
        Me.dgListOfRequestItems.Name = "dgListOfRequestItems"
        Me.dgListOfRequestItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgListOfRequestItems.Size = New System.Drawing.Size(687, 150)
        Me.dgListOfRequestItems.TabIndex = 0
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "View"
        Me.DataGridViewImageColumn1.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.fine_print_24
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 638
        '
        'frmApprover
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 423)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmApprover"
        Me.Text = "Request Approval"
        Me.gpDMRequest.ResumeLayout(False)
        CType(Me.dgListOfDM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.gpListOfRequest.ResumeLayout(False)
        Me.gpListOfRequest.PerformLayout()
        Me.gbDMRDetails.ResumeLayout(False)
        Me.gbDMRDetails.PerformLayout()
        CType(Me.dgListOfRequestItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gpDMRequest As System.Windows.Forms.GroupBox
    Friend WithEvents dgListOfDM As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents gpListOfRequest As System.Windows.Forms.GroupBox
    Friend WithEvents dgListOfRequestItems As System.Windows.Forms.DataGridView
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnProcessDecision As System.Windows.Forms.Button
    Friend WithEvents chkApprovedAll As System.Windows.Forms.CheckBox
    Friend WithEvents gbDMRDetails As System.Windows.Forms.GroupBox
    Friend WithEvents lblSupervisor As System.Windows.Forms.Label
    Friend WithEvents lblBranch As System.Windows.Forms.Label
    Friend WithEvents lblRequestDate As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lnkViewAttachment As System.Windows.Forms.LinkLabel
    Friend WithEvents lblDebitMemoNumber As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApproverNotes As System.Windows.Forms.TextBox
    Friend WithEvents txtRequesteeNotes As TextBox
    Friend WithEvents Label6 As Label
End Class
