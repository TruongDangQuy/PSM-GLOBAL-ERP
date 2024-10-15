<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HLP99011A
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
        Me.components = New System.ComponentModel.Container()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chb_FactoryOutsole = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chb_FactoryRnD = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chb_Factory3 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chb_Factory2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chb_Factory1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(304, 237)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.chb_FactoryOutsole)
        Me.Panel1.Controls.Add(Me.chb_FactoryRnD)
        Me.Panel1.Controls.Add(Me.chb_Factory3)
        Me.Panel1.Controls.Add(Me.chb_Factory2)
        Me.Panel1.Controls.Add(Me.chb_Factory1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(298, 136)
        Me.Panel1.TabIndex = 0
        '
        'chb_FactoryOutsole
        '
        Me.chb_FactoryOutsole.AutoSize = True
        Me.chb_FactoryOutsole.ButtonTitle = Nothing
        Me.chb_FactoryOutsole.Location = New System.Drawing.Point(114, 26)
        Me.chb_FactoryOutsole.Name = "chb_FactoryOutsole"
        Me.chb_FactoryOutsole.Size = New System.Drawing.Size(100, 17)
        Me.chb_FactoryOutsole.TabIndex = 4
        Me.chb_FactoryOutsole.Text = "Factory Outsole"
        Me.chb_FactoryOutsole.UseVisualStyleBackColor = True
        '
        'chb_FactoryRnD
        '
        Me.chb_FactoryRnD.AutoSize = True
        Me.chb_FactoryRnD.ButtonTitle = Nothing
        Me.chb_FactoryRnD.Location = New System.Drawing.Point(114, 3)
        Me.chb_FactoryRnD.Name = "chb_FactoryRnD"
        Me.chb_FactoryRnD.Size = New System.Drawing.Size(86, 17)
        Me.chb_FactoryRnD.TabIndex = 3
        Me.chb_FactoryRnD.Text = "Factory RnD"
        Me.chb_FactoryRnD.UseVisualStyleBackColor = True
        '
        'chb_Factory3
        '
        Me.chb_Factory3.AutoSize = True
        Me.chb_Factory3.ButtonTitle = Nothing
        Me.chb_Factory3.Location = New System.Drawing.Point(9, 49)
        Me.chb_Factory3.Name = "chb_Factory3"
        Me.chb_Factory3.Size = New System.Drawing.Size(70, 17)
        Me.chb_Factory3.TabIndex = 2
        Me.chb_Factory3.Text = "Factory 3"
        Me.chb_Factory3.UseVisualStyleBackColor = True
        '
        'chb_Factory2
        '
        Me.chb_Factory2.AutoSize = True
        Me.chb_Factory2.ButtonTitle = Nothing
        Me.chb_Factory2.Location = New System.Drawing.Point(9, 26)
        Me.chb_Factory2.Name = "chb_Factory2"
        Me.chb_Factory2.Size = New System.Drawing.Size(70, 17)
        Me.chb_Factory2.TabIndex = 1
        Me.chb_Factory2.Text = "Factory 2"
        Me.chb_Factory2.UseVisualStyleBackColor = True
        '
        'chb_Factory1
        '
        Me.chb_Factory1.AutoSize = True
        Me.chb_Factory1.ButtonTitle = Nothing
        Me.chb_Factory1.Location = New System.Drawing.Point(9, 3)
        Me.chb_Factory1.Name = "chb_Factory1"
        Me.chb_Factory1.Size = New System.Drawing.Size(70, 17)
        Me.chb_Factory1.TabIndex = 0
        Me.chb_Factory1.Text = "Factory 1"
        Me.chb_Factory1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 192)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 42)
        Me.Panel2.TabIndex = 1
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(298, 42)
        Me.FlowLayoutPanel1.TabIndex = 46
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.cmd_Cancel.ImageAlign = 0
        Me.cmd_Cancel.Location = New System.Drawing.Point(157, 1)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(140, 28)
        Me.cmd_Cancel.TabIndex = 44
        Me.cmd_Cancel.Text = "Close(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.save
        Me.cmd_OK.ImageAlign = 0
        Me.cmd_OK.Location = New System.Drawing.Point(15, 1)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(140, 28)
        Me.cmd_OK.TabIndex = 45
        Me.cmd_OK.Text = "Save(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 41)
        Me.Panel3.TabIndex = 2
        '
        'HLP99011A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 237)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(320, 276)
        Me.MinimumSize = New System.Drawing.Size(320, 276)
        Me.Name = "HLP99011A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HLP99011A"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chb_FactoryOutsole As PSMGlobal.PeaceCheckbox
    Friend WithEvents chb_FactoryRnD As PSMGlobal.PeaceCheckbox
    Friend WithEvents chb_Factory3 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chb_Factory2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chb_Factory1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
