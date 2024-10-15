<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4001P
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
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_WorkOrderStatus2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_WorkOrderStatus3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_WorkOrderStatus1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_WorkOrderStatus4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_WorkOrderStatus5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
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
        Me.Frame1.Size = New System.Drawing.Size(498, 76)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(489, 68)
        Me.FlowLayoutPanel1.TabIndex = 102
        '
        'Panel5
        '
        Me.Panel5.ColumnCount = 5
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.03771!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00452!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.00452!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.59125!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.Panel5.Controls.Add(Me.rad_WorkOrderStatus2, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_WorkOrderStatus3, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_WorkOrderStatus1, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_WorkOrderStatus4, 3, 0)
        Me.Panel5.Controls.Add(Me.rad_WorkOrderStatus5, 4, 0)
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel5.Size = New System.Drawing.Size(484, 30)
        Me.Panel5.TabIndex = 108
        '
        'rad_WorkOrderStatus2
        '
        Me.rad_WorkOrderStatus2.AutoSize = True
        Me.rad_WorkOrderStatus2.ButtonTitle = Nothing
        Me.rad_WorkOrderStatus2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_WorkOrderStatus2.Location = New System.Drawing.Point(124, 3)
        Me.rad_WorkOrderStatus2.Name = "rad_WorkOrderStatus2"
        Me.rad_WorkOrderStatus2.Size = New System.Drawing.Size(86, 23)
        Me.rad_WorkOrderStatus2.TabIndex = 4
        Me.rad_WorkOrderStatus2.Text = "Complete"
        Me.rad_WorkOrderStatus2.UseVisualStyleBackColor = True
        '
        'rad_WorkOrderStatus3
        '
        Me.rad_WorkOrderStatus3.AutoSize = True
        Me.rad_WorkOrderStatus3.ButtonTitle = Nothing
        Me.rad_WorkOrderStatus3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_WorkOrderStatus3.Location = New System.Drawing.Point(216, 3)
        Me.rad_WorkOrderStatus3.Name = "rad_WorkOrderStatus3"
        Me.rad_WorkOrderStatus3.Size = New System.Drawing.Size(82, 23)
        Me.rad_WorkOrderStatus3.TabIndex = 3
        Me.rad_WorkOrderStatus3.Text = "Approval"
        Me.rad_WorkOrderStatus3.UseVisualStyleBackColor = True
        '
        'rad_WorkOrderStatus1
        '
        Me.rad_WorkOrderStatus1.AutoSize = True
        Me.rad_WorkOrderStatus1.ButtonTitle = Nothing
        Me.rad_WorkOrderStatus1.Checked = True
        Me.rad_WorkOrderStatus1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_WorkOrderStatus1.Location = New System.Drawing.Point(3, 3)
        Me.rad_WorkOrderStatus1.Name = "rad_WorkOrderStatus1"
        Me.rad_WorkOrderStatus1.Size = New System.Drawing.Size(109, 23)
        Me.rad_WorkOrderStatus1.TabIndex = 2
        Me.rad_WorkOrderStatus1.TabStop = True
        Me.rad_WorkOrderStatus1.Text = "Not Approval"
        Me.rad_WorkOrderStatus1.UseVisualStyleBackColor = True
        '
        'rad_WorkOrderStatus4
        '
        Me.rad_WorkOrderStatus4.AutoSize = True
        Me.rad_WorkOrderStatus4.ButtonTitle = Nothing
        Me.rad_WorkOrderStatus4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_WorkOrderStatus4.Location = New System.Drawing.Point(308, 3)
        Me.rad_WorkOrderStatus4.Name = "rad_WorkOrderStatus4"
        Me.rad_WorkOrderStatus4.Size = New System.Drawing.Size(67, 23)
        Me.rad_WorkOrderStatus4.TabIndex = 3
        Me.rad_WorkOrderStatus4.Text = "Cancel"
        Me.rad_WorkOrderStatus4.UseVisualStyleBackColor = True
        '
        'rad_WorkOrderStatus5
        '
        Me.rad_WorkOrderStatus5.AutoSize = True
        Me.rad_WorkOrderStatus5.ButtonTitle = Nothing
        Me.rad_WorkOrderStatus5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.rad_WorkOrderStatus5.Location = New System.Drawing.Point(388, 3)
        Me.rad_WorkOrderStatus5.Name = "rad_WorkOrderStatus5"
        Me.rad_WorkOrderStatus5.Size = New System.Drawing.Size(76, 23)
        Me.rad_WorkOrderStatus5.TabIndex = 3
        Me.rad_WorkOrderStatus5.Text = "Pending"
        Me.rad_WorkOrderStatus5.UseVisualStyleBackColor = True
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(1, 33)
        Me.cmd_OK.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(239, 30)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(242, 33)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(244, 30)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'ISUD4001P
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(498, 76)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "ISUD4001P"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WORKORDER APPROVAL PROCESSING (ISUD4001P)"
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_WorkOrderStatus3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_WorkOrderStatus1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_WorkOrderStatus2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_WorkOrderStatus4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_WorkOrderStatus5 As PSMGlobal.PeaceRadioButton
End Class
