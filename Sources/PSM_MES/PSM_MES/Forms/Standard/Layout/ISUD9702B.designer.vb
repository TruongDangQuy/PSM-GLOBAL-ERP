<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD9702B
    Inherits DevExpress.XtraLayout.Customization.UserCustomizationForm

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
        Me.ButtonsPanel1 = New DevExpress.XtraLayout.Customization.Controls.ButtonsPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.HiddenItemsList1 = New DevExpress.XtraLayout.Customization.Controls.HiddenItemsList()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LayoutTreeView1 = New DevExpress.XtraLayout.Customization.Controls.LayoutTreeView()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.CustomizationPropertyGrid1 = New DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.HiddenItemsList1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonsPanel1
        '
        Me.ButtonsPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonsPanel1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonsPanel1.Name = "ButtonsPanel1"
        Me.ButtonsPanel1.Size = New System.Drawing.Size(535, 27)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(261, 647)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.HiddenItemsList1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(253, 621)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Hidden Items"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'HiddenItemsList1
        '
        Me.HiddenItemsList1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.HiddenItemsList1.Location = New System.Drawing.Point(3, 3)
        Me.HiddenItemsList1.Name = "HiddenItemsList1"
        Me.HiddenItemsList1.Size = New System.Drawing.Size(247, 615)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.LayoutTreeView1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(253, 621)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Layout Tree View"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'LayoutTreeView1
        '
        Me.LayoutTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutTreeView1.Location = New System.Drawing.Point(3, 3)
        Me.LayoutTreeView1.Name = "LayoutTreeView1"
        Me.LayoutTreeView1.Role = DevExpress.XtraLayout.Customization.Controls.TreeViewRoles.LayoutTreeView
        Me.LayoutTreeView1.ShowHiddenItemsInTreeView = True
        Me.LayoutTreeView1.Size = New System.Drawing.Size(247, 615)
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CustomizationPropertyGrid1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 27)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(535, 653)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'CustomizationPropertyGrid1
        '
        Me.CustomizationPropertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomizationPropertyGrid1.Location = New System.Drawing.Point(270, 3)
        Me.CustomizationPropertyGrid1.Name = "CustomizationPropertyGrid1"
        Me.CustomizationPropertyGrid1.Size = New System.Drawing.Size(262, 647)
        '
        'CUSTOMIZATION_LAYOUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 680)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ButtonsPanel1)
        Me.MinimumSize = New System.Drawing.Size(206, 107)
        Me.Name = "CUSTOMIZATION_LAYOUT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customization Form"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.HiddenItemsList1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ButtonsPanel1 As DevExpress.XtraLayout.Customization.Controls.ButtonsPanel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents HiddenItemsList1 As DevExpress.XtraLayout.Customization.Controls.HiddenItemsList
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents LayoutTreeView1 As DevExpress.XtraLayout.Customization.Controls.LayoutTreeView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents CustomizationPropertyGrid1 As DevExpress.XtraLayout.Customization.Controls.CustomizationPropertyGrid
End Class
