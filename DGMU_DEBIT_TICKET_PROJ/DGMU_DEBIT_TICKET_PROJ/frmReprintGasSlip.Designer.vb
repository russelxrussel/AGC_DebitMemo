<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReprintGasSlip
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
        Me.dgGasolineSlipList = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnkReprintGasSlip = New MetroFramework.Controls.MetroLink()
        CType(Me.dgGasolineSlipList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgGasolineSlipList
        '
        Me.dgGasolineSlipList.AllowUserToAddRows = False
        Me.dgGasolineSlipList.AllowUserToDeleteRows = False
        Me.dgGasolineSlipList.AllowUserToOrderColumns = True
        Me.dgGasolineSlipList.AllowUserToResizeColumns = False
        Me.dgGasolineSlipList.AllowUserToResizeRows = False
        Me.dgGasolineSlipList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGasolineSlipList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGasolineSlipList.Location = New System.Drawing.Point(4, 19)
        Me.dgGasolineSlipList.Margin = New System.Windows.Forms.Padding(4)
        Me.dgGasolineSlipList.MultiSelect = False
        Me.dgGasolineSlipList.Name = "dgGasolineSlipList"
        Me.dgGasolineSlipList.ReadOnly = True
        Me.dgGasolineSlipList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgGasolineSlipList.RowHeadersWidth = 60
        Me.dgGasolineSlipList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgGasolineSlipList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgGasolineSlipList.ShowEditingIcon = False
        Me.dgGasolineSlipList.Size = New System.Drawing.Size(713, 281)
        Me.dgGasolineSlipList.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgGasolineSlipList)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 58)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(721, 304)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Item to Reprint"
        '
        'lnkReprintGasSlip
        '
        Me.lnkReprintGasSlip.BackColor = System.Drawing.Color.Transparent
        Me.lnkReprintGasSlip.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkReprintGasSlip.DisplayFocus = True
        Me.lnkReprintGasSlip.Image = Global.DGMU_DEBIT_TICKET_PROJ.My.Resources.Resources.print_24
        Me.lnkReprintGasSlip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkReprintGasSlip.ImageSize = 24
        Me.lnkReprintGasSlip.Location = New System.Drawing.Point(542, 28)
        Me.lnkReprintGasSlip.Name = "lnkReprintGasSlip"
        Me.lnkReprintGasSlip.Size = New System.Drawing.Size(193, 23)
        Me.lnkReprintGasSlip.Style = MetroFramework.MetroColorStyle.Purple
        Me.lnkReprintGasSlip.TabIndex = 107
        Me.lnkReprintGasSlip.Text = "Reprint Selected Item"
        Me.lnkReprintGasSlip.UseCustomBackColor = True
        Me.lnkReprintGasSlip.UseSelectable = True
        Me.lnkReprintGasSlip.UseStyleColors = True
        '
        'frmReprintGasSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 361)
        Me.Controls.Add(Me.lnkReprintGasSlip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmReprintGasSlip"
        Me.Text = "frmReprintGasSlip"
        CType(Me.dgGasolineSlipList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgGasolineSlipList As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lnkReprintGasSlip As MetroFramework.Controls.MetroLink
End Class
