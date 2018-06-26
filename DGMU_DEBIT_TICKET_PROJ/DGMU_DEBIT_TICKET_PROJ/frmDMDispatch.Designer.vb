<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDMDispatch
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
        Me.gbDispatch_Details = New System.Windows.Forms.GroupBox()
        Me.dtpDispatchDate = New System.Windows.Forms.DateTimePicker()
        Me.lnkDispatch = New MetroFramework.Controls.MetroLink()
        Me.txtDispatchPerson = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTempDMNumber = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgUserRequestList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbDispatch_Details.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgUserRequestList)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(825, 280)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List of Debit Memo"
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
        Me.dgUserRequestList.Location = New System.Drawing.Point(3, 23)
        Me.dgUserRequestList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgUserRequestList.Name = "dgUserRequestList"
        Me.dgUserRequestList.ReadOnly = True
        Me.dgUserRequestList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dgUserRequestList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgUserRequestList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgUserRequestList.ShowEditingIcon = False
        Me.dgUserRequestList.Size = New System.Drawing.Size(819, 253)
        Me.dgUserRequestList.TabIndex = 0
        '
        'gbDispatch_Details
        '
        Me.gbDispatch_Details.Controls.Add(Me.dtpDispatchDate)
        Me.gbDispatch_Details.Controls.Add(Me.lnkDispatch)
        Me.gbDispatch_Details.Controls.Add(Me.txtDispatchPerson)
        Me.gbDispatch_Details.Controls.Add(Me.Label2)
        Me.gbDispatch_Details.Controls.Add(Me.Label1)
        Me.gbDispatch_Details.Location = New System.Drawing.Point(12, 341)
        Me.gbDispatch_Details.Name = "gbDispatch_Details"
        Me.gbDispatch_Details.Size = New System.Drawing.Size(822, 97)
        Me.gbDispatch_Details.TabIndex = 1
        Me.gbDispatch_Details.TabStop = False
        Me.gbDispatch_Details.Text = "Debit Memo Dispatch Details"
        '
        'dtpDispatchDate
        '
        Me.dtpDispatchDate.CalendarFont = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDispatchDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDispatchDate.Location = New System.Drawing.Point(139, 29)
        Me.dtpDispatchDate.Name = "dtpDispatchDate"
        Me.dtpDispatchDate.Size = New System.Drawing.Size(115, 26)
        Me.dtpDispatchDate.TabIndex = 107
        Me.dtpDispatchDate.Value = New Date(2018, 3, 26, 0, 0, 0, 0)
        '
        'lnkDispatch
        '
        Me.lnkDispatch.BackColor = System.Drawing.Color.Transparent
        Me.lnkDispatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDispatch.DisplayFocus = True
        Me.lnkDispatch.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.in_transit_24
        Me.lnkDispatch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkDispatch.ImageSize = 24
        Me.lnkDispatch.Location = New System.Drawing.Point(702, 25)
        Me.lnkDispatch.Name = "lnkDispatch"
        Me.lnkDispatch.Size = New System.Drawing.Size(114, 23)
        Me.lnkDispatch.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkDispatch.TabIndex = 106
        Me.lnkDispatch.Text = "DISPATCH"
        Me.lnkDispatch.UseCustomBackColor = True
        Me.lnkDispatch.UseSelectable = True
        Me.lnkDispatch.UseStyleColors = True
        '
        'txtDispatchPerson
        '
        Me.txtDispatchPerson.Location = New System.Drawing.Point(139, 61)
        Me.txtDispatchPerson.Name = "txtDispatchPerson"
        Me.txtDispatchPerson.Size = New System.Drawing.Size(269, 26)
        Me.txtDispatchPerson.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dispatcher - c/o :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Dispatch Date :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Search"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(71, 20)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(349, 26)
        Me.txtSearch.TabIndex = 5
        '
        'lblTempDMNumber
        '
        Me.lblTempDMNumber.AutoSize = True
        Me.lblTempDMNumber.Location = New System.Drawing.Point(19, 456)
        Me.lblTempDMNumber.Name = "lblTempDMNumber"
        Me.lblTempDMNumber.Size = New System.Drawing.Size(48, 18)
        Me.lblTempDMNumber.TabIndex = 7
        Me.lblTempDMNumber.Text = "Label3"
        Me.lblTempDMNumber.Visible = False
        '
        'frmDMDispatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 481)
        Me.Controls.Add(Me.lblTempDMNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.gbDispatch_Details)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmDMDispatch"
        Me.Text = "Debit Memo Dispatching"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgUserRequestList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbDispatch_Details.ResumeLayout(False)
        Me.gbDispatch_Details.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgUserRequestList As DataGridView
    Friend WithEvents gbDispatch_Details As GroupBox
    Friend WithEvents txtDispatchPerson As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lnkDispatch As MetroFramework.Controls.MetroLink
    Friend WithEvents dtpDispatchDate As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTempDMNumber As Label
End Class
