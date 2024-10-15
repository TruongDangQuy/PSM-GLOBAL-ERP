<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD1411P
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
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Block = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckOrder2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrder3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrder1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrder4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrder5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrder6 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Block.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Code = ""
        Me.Frame1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Frame1.Data = ""
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(737, 70)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.Block)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(733, 66)
        Me.FlowLayoutPanel1.TabIndex = 102
        '
        'Block
        '
        Me.Block.ColumnCount = 6
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.Block.Controls.Add(Me.rad_CheckOrder2, 0, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrder3, 1, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrder1, 0, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrder4, 3, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrder5, 4, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrder6, 5, 0)
        Me.Block.Location = New System.Drawing.Point(1, 1)
        Me.Block.Margin = New System.Windows.Forms.Padding(1)
        Me.Block.Name = "Block"
        Me.Block.RowCount = 1
        Me.Block.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Block.Size = New System.Drawing.Size(727, 30)
        Me.Block.TabIndex = 108
        '
        'rad_CheckOrder2
        '
        Me.rad_CheckOrder2.AutoSize = True
        Me.rad_CheckOrder2.ButtonTitle = Nothing
        Me.rad_CheckOrder2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrder2.Location = New System.Drawing.Point(124, 3)
        Me.rad_CheckOrder2.Name = "rad_CheckOrder2"
        Me.rad_CheckOrder2.Size = New System.Drawing.Size(84, 21)
        Me.rad_CheckOrder2.TabIndex = 4
        Me.rad_CheckOrder2.Text = "Complete"
        Me.rad_CheckOrder2.UseVisualStyleBackColor = True
        '
        'rad_CheckOrder3
        '
        Me.rad_CheckOrder3.AutoSize = True
        Me.rad_CheckOrder3.ButtonTitle = Nothing
        Me.rad_CheckOrder3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrder3.Location = New System.Drawing.Point(245, 3)
        Me.rad_CheckOrder3.Name = "rad_CheckOrder3"
        Me.rad_CheckOrder3.Size = New System.Drawing.Size(80, 21)
        Me.rad_CheckOrder3.TabIndex = 3
        Me.rad_CheckOrder3.Text = "Approval"
        Me.rad_CheckOrder3.UseVisualStyleBackColor = True
        '
        'rad_CheckOrder1
        '
        Me.rad_CheckOrder1.AutoSize = True
        Me.rad_CheckOrder1.ButtonTitle = Nothing
        Me.rad_CheckOrder1.Checked = True
        Me.rad_CheckOrder1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrder1.Location = New System.Drawing.Point(3, 3)
        Me.rad_CheckOrder1.Name = "rad_CheckOrder1"
        Me.rad_CheckOrder1.Size = New System.Drawing.Size(106, 21)
        Me.rad_CheckOrder1.TabIndex = 2
        Me.rad_CheckOrder1.TabStop = True
        Me.rad_CheckOrder1.Text = "Not Approval"
        Me.rad_CheckOrder1.UseVisualStyleBackColor = True
        '
        'rad_CheckOrder4
        '
        Me.rad_CheckOrder4.AutoSize = True
        Me.rad_CheckOrder4.ButtonTitle = Nothing
        Me.rad_CheckOrder4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrder4.Location = New System.Drawing.Point(366, 3)
        Me.rad_CheckOrder4.Name = "rad_CheckOrder4"
        Me.rad_CheckOrder4.Size = New System.Drawing.Size(66, 21)
        Me.rad_CheckOrder4.TabIndex = 3
        Me.rad_CheckOrder4.Text = "Cancel"
        Me.rad_CheckOrder4.UseVisualStyleBackColor = True
        '
        'rad_CheckOrder5
        '
        Me.rad_CheckOrder5.AutoSize = True
        Me.rad_CheckOrder5.ButtonTitle = Nothing
        Me.rad_CheckOrder5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrder5.Location = New System.Drawing.Point(487, 3)
        Me.rad_CheckOrder5.Name = "rad_CheckOrder5"
        Me.rad_CheckOrder5.Size = New System.Drawing.Size(75, 21)
        Me.rad_CheckOrder5.TabIndex = 3
        Me.rad_CheckOrder5.Text = "Pending"
        Me.rad_CheckOrder5.UseVisualStyleBackColor = True
        Me.rad_CheckOrder5.Visible = False
        '
        'rad_CheckOrder6
        '
        Me.rad_CheckOrder6.AutoSize = True
        Me.rad_CheckOrder6.ButtonTitle = Nothing
        Me.rad_CheckOrder6.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrder6.Location = New System.Drawing.Point(608, 3)
        Me.rad_CheckOrder6.Name = "rad_CheckOrder6"
        Me.rad_CheckOrder6.Size = New System.Drawing.Size(87, 21)
        Me.rad_CheckOrder6.TabIndex = 7
        Me.rad_CheckOrder6.Text = "Pending 2"
        Me.rad_CheckOrder6.UseVisualStyleBackColor = True
        Me.rad_CheckOrder6.Visible = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.Save_16x16
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(1, 33)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(353, 29)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.Close_16x16
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(356, 33)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(372, 29)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'ISUD1411P
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(737, 70)
        Me.Controls.Add(Me.Frame1)
        Me.KeyPreview = True
        Me.Name = "ISUD1411P"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ORDER APPROVAL PROCESSING (ISUD1411P)"
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Block.ResumeLayout(False)
        Me.Block.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Block As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckOrder3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrder1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrder2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrder4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrder5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrder6 As PSMGlobal.PeaceRadioButton
End Class
