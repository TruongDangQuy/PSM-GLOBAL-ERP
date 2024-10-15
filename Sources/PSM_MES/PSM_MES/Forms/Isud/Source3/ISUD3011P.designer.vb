<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD3011P
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
        Me.rad_CheckOrderMaterial2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrderMaterial3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrderMaterial1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrderMaterial4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOrderMaterial5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
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
        Me.Frame1.Size = New System.Drawing.Size(474, 64)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel1.Controls.Add(Me.Block)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(474, 64)
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
        Me.Block.Controls.Add(Me.rad_CheckOrderMaterial2, 0, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrderMaterial3, 1, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrderMaterial1, 0, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrderMaterial4, 3, 0)
        Me.Block.Controls.Add(Me.rad_CheckOrderMaterial5, 4, 0)
        Me.Block.Location = New System.Drawing.Point(1, 1)
        Me.Block.Margin = New System.Windows.Forms.Padding(1)
        Me.Block.Name = "Block"
        Me.Block.RowCount = 1
        Me.Block.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Block.Size = New System.Drawing.Size(468, 30)
        Me.Block.TabIndex = 108
        '
        'rad_CheckOrderMaterial2
        '
        Me.rad_CheckOrderMaterial2.AutoSize = True
        Me.rad_CheckOrderMaterial2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrderMaterial2.Location = New System.Drawing.Point(126, 3)
        Me.rad_CheckOrderMaterial2.Name = "rad_CheckOrderMaterial2"
        Me.rad_CheckOrderMaterial2.Size = New System.Drawing.Size(86, 20)
        Me.rad_CheckOrderMaterial2.TabIndex = 4
        Me.rad_CheckOrderMaterial2.Text = "Complete"
        Me.rad_CheckOrderMaterial2.UseVisualStyleBackColor = True
        '
        'rad_CheckOrderMaterial3
        '
        Me.rad_CheckOrderMaterial3.AutoSize = True
        Me.rad_CheckOrderMaterial3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrderMaterial3.Location = New System.Drawing.Point(222, 3)
        Me.rad_CheckOrderMaterial3.Name = "rad_CheckOrderMaterial3"
        Me.rad_CheckOrderMaterial3.Size = New System.Drawing.Size(82, 20)
        Me.rad_CheckOrderMaterial3.TabIndex = 3
        Me.rad_CheckOrderMaterial3.Text = "Approval"
        Me.rad_CheckOrderMaterial3.UseVisualStyleBackColor = True
        '
        'rad_CheckOrderMaterial1
        '
        Me.rad_CheckOrderMaterial1.AutoSize = True
        Me.rad_CheckOrderMaterial1.Checked = True
        Me.rad_CheckOrderMaterial1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrderMaterial1.Location = New System.Drawing.Point(3, 3)
        Me.rad_CheckOrderMaterial1.Name = "rad_CheckOrderMaterial1"
        Me.rad_CheckOrderMaterial1.Size = New System.Drawing.Size(106, 20)
        Me.rad_CheckOrderMaterial1.TabIndex = 2
        Me.rad_CheckOrderMaterial1.TabStop = True
        Me.rad_CheckOrderMaterial1.Text = "Not Approval"
        Me.rad_CheckOrderMaterial1.UseVisualStyleBackColor = True
        '
        'rad_CheckOrderMaterial4
        '
        Me.rad_CheckOrderMaterial4.AutoSize = True
        Me.rad_CheckOrderMaterial4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrderMaterial4.Location = New System.Drawing.Point(312, 3)
        Me.rad_CheckOrderMaterial4.Name = "rad_CheckOrderMaterial4"
        Me.rad_CheckOrderMaterial4.Size = New System.Drawing.Size(67, 20)
        Me.rad_CheckOrderMaterial4.TabIndex = 3
        Me.rad_CheckOrderMaterial4.Text = "Cancel"
        Me.rad_CheckOrderMaterial4.UseVisualStyleBackColor = True
        '
        'rad_CheckOrderMaterial5
        '
        Me.rad_CheckOrderMaterial5.AutoSize = True
        Me.rad_CheckOrderMaterial5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckOrderMaterial5.Location = New System.Drawing.Point(385, 3)
        Me.rad_CheckOrderMaterial5.Name = "rad_CheckOrderMaterial5"
        Me.rad_CheckOrderMaterial5.Size = New System.Drawing.Size(78, 20)
        Me.rad_CheckOrderMaterial5.TabIndex = 3
        Me.rad_CheckOrderMaterial5.Text = "Pending"
        Me.rad_CheckOrderMaterial5.UseVisualStyleBackColor = True
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_OK.Location = New System.Drawing.Point(1, 33)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(231, 27)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancel.Location = New System.Drawing.Point(234, 33)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(236, 27)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'ISUD3011P
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(474, 64)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "ISUD3011P"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PR APPROVAL PROCESSING (ISUD3011P)"
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
    Friend WithEvents rad_CheckOrderMaterial3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrderMaterial1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrderMaterial2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrderMaterial4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOrderMaterial5 As PSMGlobal.PeaceRadioButton
End Class
