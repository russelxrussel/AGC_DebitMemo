<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmViewAttachment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmViewAttachment))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgAttachment = New System.Windows.Forms.DataGridView()
        Me.lblDMRNum = New System.Windows.Forms.Label()
        Me.Attachment = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1344, 678)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.dgAttachment)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1344, 678)
        Me.Panel2.TabIndex = 1
        '
        'dgAttachment
        '
        Me.dgAttachment.AllowUserToAddRows = False
        Me.dgAttachment.AllowUserToDeleteRows = False
        Me.dgAttachment.AllowUserToResizeColumns = False
        Me.dgAttachment.AllowUserToResizeRows = False
        Me.dgAttachment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAttachment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgAttachment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAttachment.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Attachment})
        Me.dgAttachment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAttachment.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgAttachment.Location = New System.Drawing.Point(0, 0)
        Me.dgAttachment.Name = "dgAttachment"
        Me.dgAttachment.ReadOnly = True
        Me.dgAttachment.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAttachment.RowTemplate.Height = 800
        Me.dgAttachment.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgAttachment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgAttachment.ShowCellErrors = False
        Me.dgAttachment.ShowCellToolTips = False
        Me.dgAttachment.ShowEditingIcon = False
        Me.dgAttachment.ShowRowErrors = False
        Me.dgAttachment.Size = New System.Drawing.Size(1344, 678)
        Me.dgAttachment.TabIndex = 0
        '
        'lblDMRNum
        '
        Me.lblDMRNum.AutoSize = True
        Me.lblDMRNum.Location = New System.Drawing.Point(15, 15)
        Me.lblDMRNum.Name = "lblDMRNum"
        Me.lblDMRNum.Size = New System.Drawing.Size(10, 15)
        Me.lblDMRNum.TabIndex = 1
        Me.lblDMRNum.Text = "."
        '
        'Attachment
        '
        Me.Attachment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Attachment.DataPropertyName = "Attachment"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter
        DataGridViewCellStyle1.NullValue = CType(resources.GetObject("DataGridViewCellStyle1.NullValue"), Object)
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Attachment.DefaultCellStyle = DataGridViewCellStyle1
        Me.Attachment.HeaderText = "Image"
        Me.Attachment.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.Attachment.Name = "Attachment"
        Me.Attachment.ReadOnly = True
        '
        'frmViewAttachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1344, 678)
        Me.Controls.Add(Me.lblDMRNum)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmViewAttachment"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attachment Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgAttachment As System.Windows.Forms.DataGridView
    Friend WithEvents lblDMRNum As System.Windows.Forms.Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Attachment As DataGridViewImageColumn
End Class
