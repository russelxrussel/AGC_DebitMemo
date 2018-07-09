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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgAttachment = New System.Windows.Forms.DataGridView()
        Me.lblDMRNum = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(997, 498)
        Me.Panel1.TabIndex = 0
        '
        'dgAttachment
        '
        Me.dgAttachment.AllowUserToAddRows = False
        Me.dgAttachment.AllowUserToDeleteRows = False
        Me.dgAttachment.AllowUserToResizeColumns = False
        Me.dgAttachment.AllowUserToResizeRows = False
        Me.dgAttachment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgAttachment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgAttachment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAttachment.Location = New System.Drawing.Point(18, 43)
        Me.dgAttachment.Name = "dgAttachment"
        Me.dgAttachment.ReadOnly = True
        Me.dgAttachment.Size = New System.Drawing.Size(706, 499)
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
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.dgAttachment)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(997, 498)
        Me.Panel2.TabIndex = 1
        '
        'frmViewAttachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(997, 498)
        Me.Controls.Add(Me.lblDMRNum)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmViewAttachment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attachment Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgAttachment As System.Windows.Forms.DataGridView
    Friend WithEvents lblDMRNum As System.Windows.Forms.Label
    Friend WithEvents Panel2 As Panel
End Class
