<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PFP99123
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
        Me.GroupLayout = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControl = New DevExpress.XtraLayout.LayoutControl()
        CType(Me.GroupLayout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupLayout
        '
        Me.GroupLayout.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.GroupLayout.GroupBordersVisible = False
        Me.GroupLayout.Location = New System.Drawing.Point(0, 0)
        Me.GroupLayout.Name = "GroupLayout"
        Me.GroupLayout.Size = New System.Drawing.Size(892, 533)
        Me.GroupLayout.TextVisible = False
        '
        'LayoutControl
        '
        Me.LayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl.Name = "LayoutControl"
        Me.LayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2535, 7, 250, 350)
        Me.LayoutControl.Root = Me.GroupLayout
        Me.LayoutControl.Size = New System.Drawing.Size(892, 533)
        Me.LayoutControl.TabIndex = 0
        Me.LayoutControl.Text = "LayoutControl1"
        '
        'CONTROLLAYOUT_FORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 533)
        Me.Controls.Add(Me.LayoutControl)
        Me.KeyPreview = True
        Me.Name = "CONTROLLAYOUT_FORM"
        Me.Text = "LAYOUT FORM CONTROL"
        CType(Me.GroupLayout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupLayout As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl As DevExpress.XtraLayout.LayoutControl
End Class
