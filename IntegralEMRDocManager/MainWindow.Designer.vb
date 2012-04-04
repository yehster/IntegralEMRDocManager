<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.dgFileStatuses = New System.Windows.Forms.DataGridView()
        Me.wbOpenEMRSession = New System.Windows.Forms.WebBrowser()
        CType(Me.dgFileStatuses, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgFileStatuses
        '
        Me.dgFileStatuses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFileStatuses.Location = New System.Drawing.Point(4, 2)
        Me.dgFileStatuses.Name = "dgFileStatuses"
        Me.dgFileStatuses.Size = New System.Drawing.Size(357, 279)
        Me.dgFileStatuses.TabIndex = 0
        '
        'wbOpenEMRSession
        '
        Me.wbOpenEMRSession.Location = New System.Drawing.Point(373, 11)
        Me.wbOpenEMRSession.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbOpenEMRSession.Name = "wbOpenEMRSession"
        Me.wbOpenEMRSession.Size = New System.Drawing.Size(262, 259)
        Me.wbOpenEMRSession.TabIndex = 1
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(635, 625)
        Me.Controls.Add(Me.wbOpenEMRSession)
        Me.Controls.Add(Me.dgFileStatuses)
        Me.Name = "MainWindow"
        Me.Text = "Integral EMR Document Manager"
        CType(Me.dgFileStatuses, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgFileStatuses As System.Windows.Forms.DataGridView
    Friend WithEvents wbOpenEMRSession As System.Windows.Forms.WebBrowser

End Class
