<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD3111P
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
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel()
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckProcessPurchsing2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckProcessPurchsing3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckProcessPurchsing1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckProcessPurchsing4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckProcessPurchsing5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.Frame1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(474, 80)
        Me.Frame1.TabIndex = 4
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(474, 80)
        Me.FlowLayoutPanel1.TabIndex = 102
        '
        'Panel5
        '
        Me.Panel5.ColumnCount = 5
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.28205!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.51282!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.59829!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16239!))
        Me.Panel5.Controls.Add(Me.rad_CheckProcessPurchsing2, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckProcessPurchsing3, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckProcessPurchsing1, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckProcessPurchsing4, 3, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckProcessPurchsing5, 4, 0)
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel5.Size = New System.Drawing.Size(468, 30)
        Me.Panel5.TabIndex = 108
        '
        'rad_CheckProcessPurchsing2
        '
        Me.rad_CheckProcessPurchsing2.AutoSize = True
        Me.rad_CheckProcessPurchsing2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckProcessPurchsing2.Location = New System.Drawing.Point(126, 3)
        Me.rad_CheckProcessPurchsing2.Name = "rad_CheckProcessPurchsing2"
        Me.rad_CheckProcessPurchsing2.Size = New System.Drawing.Size(86, 23)
        Me.rad_CheckProcessPurchsing2.TabIndex = 4
        Me.rad_CheckProcessPurchsing2.Text = "Complete"
        Me.rad_CheckProcessPurchsing2.UseVisualStyleBackColor = True
        '
        'rad_CheckProcessPurchsing3
        '
        Me.rad_CheckProcessPurchsing3.AutoSize = True
        Me.rad_CheckProcessPurchsing3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckProcessPurchsing3.Location = New System.Drawing.Point(222, 3)
        Me.rad_CheckProcessPurchsing3.Name = "rad_CheckProcessPurchsing3"
        Me.rad_CheckProcessPurchsing3.Size = New System.Drawing.Size(82, 23)
        Me.rad_CheckProcessPurchsing3.TabIndex = 3
        Me.rad_CheckProcessPurchsing3.Text = "Approval"
        Me.rad_CheckProcessPurchsing3.UseVisualStyleBackColor = True
        '
        'rad_CheckProcessPurchsing1
        '
        Me.rad_CheckProcessPurchsing1.AutoSize = True
        Me.rad_CheckProcessPurchsing1.Checked = True
        Me.rad_CheckProcessPurchsing1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckProcessPurchsing1.Location = New System.Drawing.Point(3, 3)
        Me.rad_CheckProcessPurchsing1.Name = "rad_CheckProcessPurchsing1"
        Me.rad_CheckProcessPurchsing1.Size = New System.Drawing.Size(109, 23)
        Me.rad_CheckProcessPurchsing1.TabIndex = 2
        Me.rad_CheckProcessPurchsing1.TabStop = True
        Me.rad_CheckProcessPurchsing1.Text = "Not Approval"
        Me.rad_CheckProcessPurchsing1.UseVisualStyleBackColor = True
        '
        'rad_CheckProcessPurchsing4
        '
        Me.rad_CheckProcessPurchsing4.AutoSize = True
        Me.rad_CheckProcessPurchsing4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckProcessPurchsing4.Location = New System.Drawing.Point(312, 3)
        Me.rad_CheckProcessPurchsing4.Name = "rad_CheckProcessPurchsing4"
        Me.rad_CheckProcessPurchsing4.Size = New System.Drawing.Size(67, 23)
        Me.rad_CheckProcessPurchsing4.TabIndex = 3
        Me.rad_CheckProcessPurchsing4.Text = "Cancel"
        Me.rad_CheckProcessPurchsing4.UseVisualStyleBackColor = True
        '
        'rad_CheckProcessPurchsing5
        '
        Me.rad_CheckProcessPurchsing5.AutoSize = True
        Me.rad_CheckProcessPurchsing5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_CheckProcessPurchsing5.Location = New System.Drawing.Point(385, 3)
        Me.rad_CheckProcessPurchsing5.Name = "rad_CheckProcessPurchsing5"
        Me.rad_CheckProcessPurchsing5.Size = New System.Drawing.Size(76, 23)
        Me.rad_CheckProcessPurchsing5.TabIndex = 3
        Me.rad_CheckProcessPurchsing5.Text = "Pending"
        Me.rad_CheckProcessPurchsing5.UseVisualStyleBackColor = True
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Location = New System.Drawing.Point(1, 33)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(231, 41)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "SAVE(&S)"
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Location = New System.Drawing.Point(234, 33)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(236, 41)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        '
        'ISUD3111P
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(474, 80)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "ISUD3111P"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PURCHASING YARN APPROVAL PROCESSING (ISUD3111P)"
        Me.Frame1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckProcessPurchsing3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckProcessPurchsing1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckProcessPurchsing2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckProcessPurchsing4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckProcessPurchsing5 As PSMGlobal.PeaceRadioButton
End Class
