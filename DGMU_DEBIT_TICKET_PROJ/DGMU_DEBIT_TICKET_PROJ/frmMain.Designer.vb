<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.scPage = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lnkUserName = New MetroFramework.Controls.MetroLink()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lnkMyRequest = New MetroFramework.Controls.MetroLink()
        Me.lnkDBR = New MetroFramework.Controls.MetroLink()
        Me.lnkDispatching = New MetroFramework.Controls.MetroLink()
        Me.lnkApproval = New MetroFramework.Controls.MetroLink()
        Me.lnkReports = New MetroFramework.Controls.MetroLink()
        Me.lnkMaintenance = New MetroFramework.Controls.MetroLink()
        Me.lnkPersonnelMaintenance = New MetroFramework.Controls.MetroLink()
        Me.lnkLogOut = New MetroFramework.Controls.MetroLink()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsUserCode = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsCalendar = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.panelStatistics = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lblOnProcessCount = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalApproveCount = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.lbl23 = New System.Windows.Forms.Label()
        Me.lblTotalPendingCount = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.lblTotalRejectCount = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblTotalDebitRequest = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.scPage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scPage.Panel1.SuspendLayout()
        Me.scPage.Panel2.SuspendLayout()
        Me.scPage.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.panelStatistics.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'scPage
        '
        Me.scPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scPage.Location = New System.Drawing.Point(0, 0)
        Me.scPage.Name = "scPage"
        '
        'scPage.Panel1
        '
        Me.scPage.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.scPage.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.scPage.Panel1.Controls.Add(Me.Label1)
        '
        'scPage.Panel2
        '
        Me.scPage.Panel2.Controls.Add(Me.StatusStrip1)
        Me.scPage.Panel2.Controls.Add(Me.panelStatistics)
        Me.scPage.Size = New System.Drawing.Size(1283, 642)
        Me.scPage.SplitterDistance = 201
        Me.scPage.SplitterWidth = 2
        Me.scPage.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkUserName)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkMyRequest)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkDBR)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkDispatching)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkApproval)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkReports)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkMaintenance)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkPersonnelMaintenance)
        Me.FlowLayoutPanel1.Controls.Add(Me.lnkLogOut)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 8)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(178, 357)
        Me.FlowLayoutPanel1.TabIndex = 102
        '
        'lnkUserName
        '
        Me.lnkUserName.BackColor = System.Drawing.Color.Transparent
        Me.lnkUserName.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkUserName.DisplayFocus = True
        Me.lnkUserName.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.voice_presentation_24
        Me.lnkUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkUserName.ImageSize = 24
        Me.lnkUserName.Location = New System.Drawing.Point(3, 3)
        Me.lnkUserName.Name = "lnkUserName"
        Me.lnkUserName.Size = New System.Drawing.Size(168, 23)
        Me.lnkUserName.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkUserName.TabIndex = 105
        Me.lnkUserName.Text = "My Request"
        Me.lnkUserName.UseCustomBackColor = True
        Me.lnkUserName.UseSelectable = True
        Me.lnkUserName.UseStyleColors = True
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(3, 32)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(171, 21)
        Me.Panel5.TabIndex = 105
        '
        'lnkMyRequest
        '
        Me.lnkMyRequest.BackColor = System.Drawing.Color.Transparent
        Me.lnkMyRequest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMyRequest.DisplayFocus = True
        Me.lnkMyRequest.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.faq_24
        Me.lnkMyRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkMyRequest.ImageSize = 24
        Me.lnkMyRequest.Location = New System.Drawing.Point(3, 59)
        Me.lnkMyRequest.Name = "lnkMyRequest"
        Me.lnkMyRequest.Size = New System.Drawing.Size(159, 23)
        Me.lnkMyRequest.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkMyRequest.TabIndex = 104
        Me.lnkMyRequest.Text = "My Request"
        Me.lnkMyRequest.UseCustomBackColor = True
        Me.lnkMyRequest.UseSelectable = True
        Me.lnkMyRequest.UseStyleColors = True
        '
        'lnkDBR
        '
        Me.lnkDBR.BackColor = System.Drawing.Color.Transparent
        Me.lnkDBR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDBR.DisplayFocus = True
        Me.lnkDBR.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.add_image_24
        Me.lnkDBR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkDBR.ImageSize = 24
        Me.lnkDBR.Location = New System.Drawing.Point(3, 88)
        Me.lnkDBR.Name = "lnkDBR"
        Me.lnkDBR.Size = New System.Drawing.Size(171, 23)
        Me.lnkDBR.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkDBR.TabIndex = 100
        Me.lnkDBR.Text = "Create Debit Memo"
        Me.lnkDBR.UseCustomBackColor = True
        Me.lnkDBR.UseSelectable = True
        Me.lnkDBR.UseStyleColors = True
        '
        'lnkDispatching
        '
        Me.lnkDispatching.BackColor = System.Drawing.Color.Transparent
        Me.lnkDispatching.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDispatching.DisplayFocus = True
        Me.lnkDispatching.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.in_transit_24
        Me.lnkDispatching.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkDispatching.ImageSize = 24
        Me.lnkDispatching.Location = New System.Drawing.Point(3, 117)
        Me.lnkDispatching.Name = "lnkDispatching"
        Me.lnkDispatching.Size = New System.Drawing.Size(133, 23)
        Me.lnkDispatching.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkDispatching.TabIndex = 109
        Me.lnkDispatching.Text = "Dispatching"
        Me.lnkDispatching.UseCustomBackColor = True
        Me.lnkDispatching.UseSelectable = True
        Me.lnkDispatching.UseStyleColors = True
        '
        'lnkApproval
        '
        Me.lnkApproval.BackColor = System.Drawing.Color.Transparent
        Me.lnkApproval.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkApproval.DisplayFocus = True
        Me.lnkApproval.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.about_24
        Me.lnkApproval.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkApproval.ImageSize = 24
        Me.lnkApproval.Location = New System.Drawing.Point(3, 146)
        Me.lnkApproval.Name = "lnkApproval"
        Me.lnkApproval.Size = New System.Drawing.Size(168, 23)
        Me.lnkApproval.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkApproval.TabIndex = 101
        Me.lnkApproval.Text = "Approval Request"
        Me.lnkApproval.UseCustomBackColor = True
        Me.lnkApproval.UseSelectable = True
        Me.lnkApproval.UseStyleColors = True
        '
        'lnkReports
        '
        Me.lnkReports.BackColor = System.Drawing.Color.Transparent
        Me.lnkReports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkReports.DisplayFocus = True
        Me.lnkReports.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.print_24
        Me.lnkReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkReports.ImageSize = 24
        Me.lnkReports.Location = New System.Drawing.Point(3, 175)
        Me.lnkReports.Name = "lnkReports"
        Me.lnkReports.Size = New System.Drawing.Size(146, 23)
        Me.lnkReports.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkReports.TabIndex = 106
        Me.lnkReports.Text = "View Reports"
        Me.lnkReports.UseCustomBackColor = True
        Me.lnkReports.UseSelectable = True
        Me.lnkReports.UseStyleColors = True
        '
        'lnkMaintenance
        '
        Me.lnkMaintenance.BackColor = System.Drawing.Color.Transparent
        Me.lnkMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMaintenance.DisplayFocus = True
        Me.lnkMaintenance.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.folder_24
        Me.lnkMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkMaintenance.ImageSize = 24
        Me.lnkMaintenance.Location = New System.Drawing.Point(3, 204)
        Me.lnkMaintenance.Name = "lnkMaintenance"
        Me.lnkMaintenance.Size = New System.Drawing.Size(159, 23)
        Me.lnkMaintenance.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkMaintenance.TabIndex = 107
        Me.lnkMaintenance.Text = "Item Maintenance"
        Me.lnkMaintenance.UseCustomBackColor = True
        Me.lnkMaintenance.UseSelectable = True
        Me.lnkMaintenance.UseStyleColors = True
        '
        'lnkPersonnelMaintenance
        '
        Me.lnkPersonnelMaintenance.BackColor = System.Drawing.Color.Transparent
        Me.lnkPersonnelMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkPersonnelMaintenance.DisplayFocus = True
        Me.lnkPersonnelMaintenance.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.flow_chart_24
        Me.lnkPersonnelMaintenance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkPersonnelMaintenance.ImageSize = 24
        Me.lnkPersonnelMaintenance.Location = New System.Drawing.Point(3, 233)
        Me.lnkPersonnelMaintenance.Name = "lnkPersonnelMaintenance"
        Me.lnkPersonnelMaintenance.Size = New System.Drawing.Size(168, 23)
        Me.lnkPersonnelMaintenance.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkPersonnelMaintenance.TabIndex = 108
        Me.lnkPersonnelMaintenance.Text = "Personnel / Branch"
        Me.lnkPersonnelMaintenance.UseCustomBackColor = True
        Me.lnkPersonnelMaintenance.UseSelectable = True
        Me.lnkPersonnelMaintenance.UseStyleColors = True
        '
        'lnkLogOut
        '
        Me.lnkLogOut.BackColor = System.Drawing.Color.Transparent
        Me.lnkLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkLogOut.DisplayFocus = True
        Me.lnkLogOut.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.lock_24
        Me.lnkLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkLogOut.ImageSize = 24
        Me.lnkLogOut.Location = New System.Drawing.Point(3, 262)
        Me.lnkLogOut.Name = "lnkLogOut"
        Me.lnkLogOut.Size = New System.Drawing.Size(119, 23)
        Me.lnkLogOut.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkLogOut.TabIndex = 102
        Me.lnkLogOut.Text = "Log - Out"
        Me.lnkLogOut.UseCustomBackColor = True
        Me.lnkLogOut.UseSelectable = True
        Me.lnkLogOut.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 630)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsUserCode, Me.tsCalendar, Me.tsTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 620)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1080, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsUserCode
        '
        Me.tsUserCode.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.automatic_24
        Me.tsUserCode.Name = "tsUserCode"
        Me.tsUserCode.Size = New System.Drawing.Size(77, 17)
        Me.tsUserCode.Text = "UserCode:"
        '
        'tsCalendar
        '
        Me.tsCalendar.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.calendar_24
        Me.tsCalendar.Name = "tsCalendar"
        Me.tsCalendar.Size = New System.Drawing.Size(16, 17)
        '
        'tsTime
        '
        Me.tsTime.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.clock_24
        Me.tsTime.Name = "tsTime"
        Me.tsTime.Size = New System.Drawing.Size(47, 17)
        Me.tsTime.Text = "time"
        '
        'panelStatistics
        '
        Me.panelStatistics.Controls.Add(Me.FlowLayoutPanel2)
        Me.panelStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelStatistics.Location = New System.Drawing.Point(0, 0)
        Me.panelStatistics.Name = "panelStatistics"
        Me.panelStatistics.Size = New System.Drawing.Size(1080, 642)
        Me.panelStatistics.TabIndex = 0
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel2.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 8)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(259, 483)
        Me.FlowLayoutPanel2.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.lblOnProcessCount)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(246, 87)
        Me.Panel2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Total On-Process Stage"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(176, 19)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(68, 59)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'lblOnProcessCount
        '
        Me.lblOnProcessCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblOnProcessCount.Font = New System.Drawing.Font("Segoe UI Symbol", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnProcessCount.ForeColor = System.Drawing.Color.White
        Me.lblOnProcessCount.Location = New System.Drawing.Point(6, 31)
        Me.lblOnProcessCount.Name = "lblOnProcessCount"
        Me.lblOnProcessCount.Size = New System.Drawing.Size(172, 47)
        Me.lblOnProcessCount.TabIndex = 5
        Me.lblOnProcessCount.Text = "0"
        Me.lblOnProcessCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.OliveDrab
        Me.Panel3.Controls.Add(Me.PictureBox4)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.lblTotalApproveCount)
        Me.Panel3.Location = New System.Drawing.Point(3, 96)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(246, 87)
        Me.Panel3.TabIndex = 2
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(179, 25)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(62, 59)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 5
        Me.PictureBox4.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(212, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total Item Approve Count"
        '
        'lblTotalApproveCount
        '
        Me.lblTotalApproveCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTotalApproveCount.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalApproveCount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTotalApproveCount.Location = New System.Drawing.Point(8, 34)
        Me.lblTotalApproveCount.Name = "lblTotalApproveCount"
        Me.lblTotalApproveCount.Size = New System.Drawing.Size(167, 37)
        Me.lblTotalApproveCount.TabIndex = 5
        Me.lblTotalApproveCount.Text = "0"
        Me.lblTotalApproveCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.DarkOrange
        Me.Panel6.Controls.Add(Me.PictureBox6)
        Me.Panel6.Controls.Add(Me.lbl23)
        Me.Panel6.Controls.Add(Me.lblTotalPendingCount)
        Me.Panel6.Location = New System.Drawing.Point(3, 189)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(246, 86)
        Me.Panel6.TabIndex = 4
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(179, 25)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(64, 59)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 5
        Me.PictureBox6.TabStop = False
        '
        'lbl23
        '
        Me.lbl23.AutoSize = True
        Me.lbl23.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl23.Location = New System.Drawing.Point(3, 3)
        Me.lbl23.Name = "lbl23"
        Me.lbl23.Size = New System.Drawing.Size(210, 21)
        Me.lbl23.TabIndex = 1
        Me.lbl23.Text = "Total Item Pending Count"
        '
        'lblTotalPendingCount
        '
        Me.lblTotalPendingCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTotalPendingCount.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPendingCount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTotalPendingCount.Location = New System.Drawing.Point(8, 34)
        Me.lblTotalPendingCount.Name = "lblTotalPendingCount"
        Me.lblTotalPendingCount.Size = New System.Drawing.Size(167, 37)
        Me.lblTotalPendingCount.TabIndex = 5
        Me.lblTotalPendingCount.Text = "0"
        Me.lblTotalPendingCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.CadetBlue
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.PictureBox5)
        Me.Panel4.Controls.Add(Me.lblTotalRejectCount)
        Me.Panel4.Location = New System.Drawing.Point(3, 281)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(246, 87)
        Me.Panel4.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Total Item Rejected Count"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(170, 22)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(70, 62)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 0
        Me.PictureBox5.TabStop = False
        '
        'lblTotalRejectCount
        '
        Me.lblTotalRejectCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblTotalRejectCount.Font = New System.Drawing.Font("Segoe UI Symbol", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRejectCount.ForeColor = System.Drawing.SystemColors.Window
        Me.lblTotalRejectCount.Location = New System.Drawing.Point(8, 34)
        Me.lblTotalRejectCount.Name = "lblTotalRejectCount"
        Me.lblTotalRejectCount.Size = New System.Drawing.Size(167, 37)
        Me.lblTotalRejectCount.TabIndex = 5
        Me.lblTotalRejectCount.Text = "0"
        Me.lblTotalRejectCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.lblTotalDebitRequest)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 374)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(246, 87)
        Me.Panel1.TabIndex = 0
        '
        'lblTotalDebitRequest
        '
        Me.lblTotalDebitRequest.Font = New System.Drawing.Font("Segoe UI Symbol", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDebitRequest.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTotalDebitRequest.Location = New System.Drawing.Point(7, 29)
        Me.lblTotalDebitRequest.Name = "lblTotalDebitRequest"
        Me.lblTotalDebitRequest.Size = New System.Drawing.Size(162, 57)
        Me.lblTotalDebitRequest.TabIndex = 4
        Me.lblTotalDebitRequest.Text = "1,500,000"
        Me.lblTotalDebitRequest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(175, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(209, 21)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Total Item Request Count"
        '
        'scMain
        '
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.IsSplitterFixed = True
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.scMain.Panel1.Controls.Add(Me.Label5)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.scPage)
        Me.scMain.Size = New System.Drawing.Size(1283, 749)
        Me.scMain.SplitterDistance = 103
        Me.scMain.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Symbol", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(546, 47)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ACES OF GRACE CORPORATION"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1283, 749)
        Me.Controls.Add(Me.scMain)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmMain"
        Me.Text = "Aces of Grace Corporation Debit Memo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.scPage.Panel1.ResumeLayout(False)
        Me.scPage.Panel1.PerformLayout()
        Me.scPage.Panel2.ResumeLayout(False)
        Me.scPage.Panel2.PerformLayout()
        CType(Me.scPage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scPage.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.panelStatistics.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel1.PerformLayout()
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents scPage As System.Windows.Forms.SplitContainer
    Friend WithEvents lnkDBR As MetroFramework.Controls.MetroLink
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lnkApproval As MetroFramework.Controls.MetroLink
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents lnkLogOut As MetroFramework.Controls.MetroLink
    Friend WithEvents panelStatistics As System.Windows.Forms.Panel
    Friend WithEvents lnkMyRequest As MetroFramework.Controls.MetroLink
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotalDebitRequest As Label
    Friend WithEvents lblOnProcessCount As Label
    Friend WithEvents lblTotalApproveCount As Label
    Friend WithEvents lnkUserName As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsCalendar As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents tsTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents tsUserCode As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lnkReports As MetroFramework.Controls.MetroLink
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents lblTotalRejectCount As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents lbl23 As Label
    Friend WithEvents lblTotalPendingCount As Label
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lnkMaintenance As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkPersonnelMaintenance As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkDispatching As MetroFramework.Controls.MetroLink
End Class
