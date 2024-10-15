<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class P_PIVOT
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
        Me.PLinqServerModeSource1 = New DevExpress.Data.PLinq.PLinqServerModeSource()
        Me.Pivot_Gird = New DevExpress.XtraPivotGrid.PivotGridControl()
        CType(Me.PLinqServerModeSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pivot_Gird, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pivot_Gird
        '
        Me.Pivot_Gird.Appearance.CustomTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pivot_Gird.Appearance.CustomTotalCell.Options.UseBackColor = True
        Me.Pivot_Gird.Appearance.FieldValueGrandTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pivot_Gird.Appearance.FieldValueGrandTotal.Options.UseBackColor = True
        Me.Pivot_Gird.Appearance.FieldValueTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pivot_Gird.Appearance.FieldValueTotal.Options.UseBackColor = True
        Me.Pivot_Gird.Appearance.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Pivot_Gird.Appearance.GrandTotalCell.Options.UseBackColor = True
        Me.Pivot_Gird.Appearance.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pivot_Gird.Appearance.TotalCell.Options.UseBackColor = True
        Me.Pivot_Gird.AppearancePrint.FieldValueTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pivot_Gird.AppearancePrint.FieldValueTotal.Options.UseBackColor = True
        Me.Pivot_Gird.AppearancePrint.GrandTotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Pivot_Gird.AppearancePrint.GrandTotalCell.Options.UseBackColor = True
        Me.Pivot_Gird.AppearancePrint.TotalCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Pivot_Gird.AppearancePrint.TotalCell.Options.UseBackColor = True
        Me.Pivot_Gird.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pivot_Gird.Location = New System.Drawing.Point(0, 0)
        Me.Pivot_Gird.Name = "Pivot_Gird"
        Me.Pivot_Gird.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
        Me.Pivot_Gird.Size = New System.Drawing.Size(874, 561)
        Me.Pivot_Gird.TabIndex = 0
        '
        'P_PIVOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 561)
        Me.Controls.Add(Me.Pivot_Gird)
        Me.Name = "P_PIVOT"
        Me.Text = "Pivot data"
        CType(Me.PLinqServerModeSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pivot_Gird, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PLinqServerModeSource1 As DevExpress.Data.PLinq.PLinqServerModeSource
    Friend WithEvents Pivot_Gird As DevExpress.XtraPivotGrid.PivotGridControl
End Class
