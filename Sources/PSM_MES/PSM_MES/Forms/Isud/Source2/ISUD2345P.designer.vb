<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD2345P
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
        Me.rad_CheckPurchasing2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPurchasing3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPurchasing1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPurchasing4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckPurchasing5 = New PSMGlobal.PeaceRadioButton(Me.components)
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
        Me.Frame1.Size = New System.Drawing.Size(482, 69)
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
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(478, 65)
        Me.FlowLayoutPanel1.TabIndex = 102
        '
        'Block
        '
        Me.Block.ColumnCount = 5
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.28205!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.51282!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.59829!))
        Me.Block.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16239!))
        Me.Block.Controls.Add(Me.rad_CheckPurchasing2, 0, 0)
        Me.Block.Controls.Add(Me.rad_CheckPurchasing3, 1, 0)
        Me.Block.Controls.Add(Me.rad_CheckPurchasing1, 0, 0)
        Me.Block.Controls.Add(Me.rad_CheckPurchasing4, 3, 0)
        Me.Block.Controls.Add(Me.rad_CheckPurchasing5, 4, 0)
        Me.Block.Location = New System.Drawing.Point(1, 1)
        Me.Block.Margin = New System.Windows.Forms.Padding(1)
        Me.Block.Name = "Block"
        Me.Block.RowCount = 1
        Me.Block.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Block.Size = New System.Drawing.Size(468, 30)
        Me.Block.TabIndex = 108
        '
        'rad_CheckPurchasing2
        '
        Me.rad_CheckPurchasing2.AutoSize = True
        Me.rad_CheckPurchasing2.ButtonTitle = Nothing
        Me.rad_CheckPurchasing2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckPurchasing2.Location = New System.Drawing.Point(126, 3)
        Me.rad_CheckPurchasing2.Name = "rad_CheckPurchasing2"
        Me.rad_CheckPurchasing2.Size = New System.Drawing.Size(84, 21)
        Me.rad_CheckPurchasing2.TabIndex = 4
        Me.rad_CheckPurchasing2.Text = "Complete"
        Me.rad_CheckPurchasing2.UseVisualStyleBackColor = True
        '
        'rad_CheckPurchasing3
        '
        Me.rad_CheckPurchasing3.AutoSize = True
        Me.rad_CheckPurchasing3.ButtonTitle = Nothing
        Me.rad_CheckPurchasing3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckPurchasing3.Location = New System.Drawing.Point(222, 3)
        Me.rad_CheckPurchasing3.Name = "rad_CheckPurchasing3"
        Me.rad_CheckPurchasing3.Size = New System.Drawing.Size(80, 21)
        Me.rad_CheckPurchasing3.TabIndex = 3
        Me.rad_CheckPurchasing3.Text = "Approval"
        Me.rad_CheckPurchasing3.UseVisualStyleBackColor = True
        '
        'rad_CheckPurchasing1
        '
        Me.rad_CheckPurchasing1.AutoSize = True
        Me.rad_CheckPurchasing1.ButtonTitle = Nothing
        Me.rad_CheckPurchasing1.Checked = True
        Me.rad_CheckPurchasing1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckPurchasing1.Location = New System.Drawing.Point(3, 3)
        Me.rad_CheckPurchasing1.Name = "rad_CheckPurchasing1"
        Me.rad_CheckPurchasing1.Size = New System.Drawing.Size(106, 21)
        Me.rad_CheckPurchasing1.TabIndex = 2
        Me.rad_CheckPurchasing1.TabStop = True
        Me.rad_CheckPurchasing1.Text = "Not Approval"
        Me.rad_CheckPurchasing1.UseVisualStyleBackColor = True
        '
        'rad_CheckPurchasing4
        '
        Me.rad_CheckPurchasing4.AutoSize = True
        Me.rad_CheckPurchasing4.ButtonTitle = Nothing
        Me.rad_CheckPurchasing4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckPurchasing4.Location = New System.Drawing.Point(312, 3)
        Me.rad_CheckPurchasing4.Name = "rad_CheckPurchasing4"
        Me.rad_CheckPurchasing4.Size = New System.Drawing.Size(66, 21)
        Me.rad_CheckPurchasing4.TabIndex = 3
        Me.rad_CheckPurchasing4.Text = "Cancel"
        Me.rad_CheckPurchasing4.UseVisualStyleBackColor = True
        '
        'rad_CheckPurchasing5
        '
        Me.rad_CheckPurchasing5.AutoSize = True
        Me.rad_CheckPurchasing5.ButtonTitle = Nothing
        Me.rad_CheckPurchasing5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckPurchasing5.Location = New System.Drawing.Point(385, 3)
        Me.rad_CheckPurchasing5.Name = "rad_CheckPurchasing5"
        Me.rad_CheckPurchasing5.Size = New System.Drawing.Size(75, 21)
        Me.rad_CheckPurchasing5.TabIndex = 3
        Me.rad_CheckPurchasing5.Text = "Pending"
        Me.rad_CheckPurchasing5.UseVisualStyleBackColor = True
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
        Me.cmd_OK.Size = New System.Drawing.Size(229, 27)
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(232, 33)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(234, 27)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'ISUD2345P
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(482, 69)
        Me.Controls.Add(Me.Frame1)
        Me.KeyPreview = True
        Me.Name = "ISUD2345P"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISSUES PROCESSING (ISUD2345P)"
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
    Friend WithEvents rad_CheckPurchasing3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckPurchasing1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckPurchasing2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckPurchasing4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckPurchasing5 As PSMGlobal.PeaceRadioButton
End Class
