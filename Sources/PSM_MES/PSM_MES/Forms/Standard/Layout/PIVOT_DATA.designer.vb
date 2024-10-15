<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIVOT_DATA
    'Inherits System.Windows.Forms.Form
    Inherits PeaceForm
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
        Me.Pivot_Gird = New DevExpress.XtraPivotGrid.PivotGridControl()
        CType(Me.Pivot_Gird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pivot_Gird
        '
        Me.Pivot_Gird.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pivot_Gird.Location = New System.Drawing.Point(0, 0)
        Me.Pivot_Gird.Name = "Pivot_Gird"
        Me.Pivot_Gird.Size = New System.Drawing.Size(1230, 635)
        Me.Pivot_Gird.TabIndex = 0
        '
        'PIVOT_DATA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 635)
        Me.Controls.Add(Me.Pivot_Gird)
        Me.KeyPreview = True
        Me.Name = "PIVOT_DATA"
        Me.Text = "PIVOT_DATA"
        CType(Me.Pivot_Gird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pivot_Gird As DevExpress.XtraPivotGrid.PivotGridControl
End Class
