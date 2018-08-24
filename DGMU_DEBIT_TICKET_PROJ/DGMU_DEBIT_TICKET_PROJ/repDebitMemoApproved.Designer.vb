<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class repDebitMemoApproved
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lnkPrint = New MetroFramework.Controls.MetroLink()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(730, 707)
        Me.CrystalReportViewer1.TabIndex = 0
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lnkPrint)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.CrystalReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(927, 707)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 1
        '
        'lnkPrint
        '
        Me.lnkPrint.BackColor = System.Drawing.Color.Transparent
        Me.lnkPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkPrint.DisplayFocus = True
        Me.lnkPrint.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.print_24
        Me.lnkPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkPrint.ImageSize = 24
        Me.lnkPrint.Location = New System.Drawing.Point(12, 12)
        Me.lnkPrint.Name = "lnkPrint"
        Me.lnkPrint.Size = New System.Drawing.Size(141, 34)
        Me.lnkPrint.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkPrint.TabIndex = 108
        Me.lnkPrint.Text = "PRINT"
        Me.lnkPrint.UseCustomBackColor = True
        Me.lnkPrint.UseSelectable = True
        Me.lnkPrint.UseStyleColors = True
        '
        'repDebitMemoApproved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 707)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "repDebitMemoApproved"
        Me.Text = "Debit Memo Receipt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents lnkPrint As MetroFramework.Controls.MetroLink
End Class
