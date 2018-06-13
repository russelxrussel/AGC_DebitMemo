<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewAttachment
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgAttachment = New System.Windows.Forms.DataGridView()
        Me.lblDMRNum = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgAttachment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgAttachment)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(694, 423)
        Me.Panel1.TabIndex = 0
        '
        'dgAttachment
        '
        Me.dgAttachment.AllowUserToAddRows = False
        Me.dgAttachment.AllowUserToDeleteRows = False
        Me.dgAttachment.AllowUserToResizeColumns = False
        Me.dgAttachment.AllowUserToResizeRows = False
        Me.dgAttachment.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgAttachment.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgAttachment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgAttachment.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAttachment.Location = New System.Drawing.Point(0, 0)
        Me.dgAttachment.Name = "dgAttachment"
        Me.dgAttachment.ReadOnly = True
        Me.dgAttachment.Size = New System.Drawing.Size(694, 423)
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
        'frmViewAttachment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 498)
        Me.Controls.Add(Me.lblDMRNum)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmViewAttachment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attachment Viewer"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgAttachment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgAttachment As System.Windows.Forms.DataGridView
    Friend WithEvents lblDMRNum As System.Windows.Forms.Label
End Class
