<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD3550A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD3550A))
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_DateAccept = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_InchargeAccept = New PSMGlobal.SelectPeaceHLPButton()
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_LabTestStatus2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_LabTestStatus3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_LabTestStatus1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_LabTestStatus4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_LabTestStatus5 = New PSMGlobal.PeaceRadioButton(Me.components)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Frame1.Size = New System.Drawing.Size(475, 114)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_DateAccept)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_InchargeAccept)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(471, 110)
        Me.FlowLayoutPanel1.TabIndex = 102
        Me.FlowLayoutPanel1.Tag = ""
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(234, 65)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(237, 41)
        Me.cmd_Cancel.TabIndex = 275
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(0, 65)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(230, 41)
        Me.cmd_OK.TabIndex = 274
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'txt_DateAccept
        '
        Me.txt_DateAccept.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateAccept.ButtonEnabled = False
        Me.txt_DateAccept.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.txt_DateAccept.ButtonName = Nothing
        Me.txt_DateAccept.ButtonTitle = "Date Accept"
        Me.txt_DateAccept.Code = ""
        Me.txt_DateAccept.Data = "________"
        Me.txt_DateAccept.DataDecimal = 0
        Me.txt_DateAccept.DataLen = 0
        Me.txt_DateAccept.DataValue = 0
        Me.txt_DateAccept.FormatDecimal = 0
        Me.txt_DateAccept.FormatValue = False
        Me.txt_DateAccept.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_DateAccept.Location = New System.Drawing.Point(234, 33)
        Me.txt_DateAccept.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_DateAccept.Name = "txt_DateAccept"
        Me.txt_DateAccept.Size = New System.Drawing.Size(236, 29)
        Me.txt_DateAccept.TabIndex = 273
        Me.txt_DateAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateAccept.TextBoxAutoComplete = False
        Me.txt_DateAccept.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateAccept.TextEnabled = False
        Me.txt_DateAccept.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateAccept.TextMaxLength = 32767
        Me.txt_DateAccept.TextMultiLine = True
        Me.txt_DateAccept.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_InchargeAccept
        '
        Me.txt_InchargeAccept.BackYesno = False
        Me.txt_InchargeAccept.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeAccept.ButtonEnabled = True
        Me.txt_InchargeAccept.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeAccept.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.ButtonName = ""
        Me.txt_InchargeAccept.ButtonTitle = "Incharge"
        Me.txt_InchargeAccept.Code = ""
        Me.txt_InchargeAccept.Data = ""
        Me.txt_InchargeAccept.DataDecimal = 0
        Me.txt_InchargeAccept.DataLen = 0
        Me.txt_InchargeAccept.DataValue = 1
        Me.txt_InchargeAccept.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_InchargeAccept.Location = New System.Drawing.Point(0, 33)
        Me.txt_InchargeAccept.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_InchargeAccept.Name = "txt_InchargeAccept"
        Me.txt_InchargeAccept.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeAccept.Size = New System.Drawing.Size(231, 29)
        Me.txt_InchargeAccept.TabIndex = 272
        Me.txt_InchargeAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeAccept.TextBoxAutoComplete = False
        Me.txt_InchargeAccept.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeAccept.TextEnabled = True
        Me.txt_InchargeAccept.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.TextMaxLength = 32767
        Me.txt_InchargeAccept.TextMultiLine = False
        Me.txt_InchargeAccept.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeAccept.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeAccept.UseSendTab = True
        '
        'Panel5
        '
        Me.Panel5.ColumnCount = 5
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.28205!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.51282!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.23077!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.59829!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.16239!))
        Me.Panel5.Controls.Add(Me.rad_LabTestStatus2, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_LabTestStatus3, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_LabTestStatus1, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_LabTestStatus4, 3, 0)
        Me.Panel5.Controls.Add(Me.rad_LabTestStatus5, 4, 0)
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel5.Size = New System.Drawing.Size(468, 30)
        Me.Panel5.TabIndex = 108
        '
        'rad_LabTestStatus2
        '
        Me.rad_LabTestStatus2.AutoSize = True
        Me.rad_LabTestStatus2.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_LabTestStatus2.Location = New System.Drawing.Point(126, 3)
        Me.rad_LabTestStatus2.Name = "rad_LabTestStatus2"
        Me.rad_LabTestStatus2.Size = New System.Drawing.Size(84, 21)
        Me.rad_LabTestStatus2.TabIndex = 4
        Me.rad_LabTestStatus2.Text = "Complete"
        Me.rad_LabTestStatus2.UseVisualStyleBackColor = True
        '
        'rad_LabTestStatus3
        '
        Me.rad_LabTestStatus3.AutoSize = True
        Me.rad_LabTestStatus3.Checked = True
        Me.rad_LabTestStatus3.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_LabTestStatus3.Location = New System.Drawing.Point(222, 3)
        Me.rad_LabTestStatus3.Name = "rad_LabTestStatus3"
        Me.rad_LabTestStatus3.Size = New System.Drawing.Size(68, 21)
        Me.rad_LabTestStatus3.TabIndex = 3
        Me.rad_LabTestStatus3.TabStop = True
        Me.rad_LabTestStatus3.Text = "Accept"
        Me.rad_LabTestStatus3.UseVisualStyleBackColor = True
        '
        'rad_LabTestStatus1
        '
        Me.rad_LabTestStatus1.AutoSize = True
        Me.rad_LabTestStatus1.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_LabTestStatus1.Location = New System.Drawing.Point(3, 3)
        Me.rad_LabTestStatus1.Name = "rad_LabTestStatus1"
        Me.rad_LabTestStatus1.Size = New System.Drawing.Size(94, 21)
        Me.rad_LabTestStatus1.TabIndex = 2
        Me.rad_LabTestStatus1.Text = "Not Accept"
        Me.rad_LabTestStatus1.UseVisualStyleBackColor = True
        '
        'rad_LabTestStatus4
        '
        Me.rad_LabTestStatus4.AutoSize = True
        Me.rad_LabTestStatus4.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_LabTestStatus4.Location = New System.Drawing.Point(312, 3)
        Me.rad_LabTestStatus4.Name = "rad_LabTestStatus4"
        Me.rad_LabTestStatus4.Size = New System.Drawing.Size(66, 21)
        Me.rad_LabTestStatus4.TabIndex = 3
        Me.rad_LabTestStatus4.Text = "Cancel"
        Me.rad_LabTestStatus4.UseVisualStyleBackColor = True
        '
        'rad_LabTestStatus5
        '
        Me.rad_LabTestStatus5.AutoSize = True
        Me.rad_LabTestStatus5.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rad_LabTestStatus5.Location = New System.Drawing.Point(385, 3)
        Me.rad_LabTestStatus5.Name = "rad_LabTestStatus5"
        Me.rad_LabTestStatus5.Size = New System.Drawing.Size(75, 21)
        Me.rad_LabTestStatus5.TabIndex = 3
        Me.rad_LabTestStatus5.Text = "Pending"
        Me.rad_LabTestStatus5.UseVisualStyleBackColor = True
        '
        'ISUD3550A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(475, 114)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ISUD3550A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TEST ORDER REQUEST APPROVAL PROCESSING (ISUD3550A)"
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_LabTestStatus3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_LabTestStatus1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_LabTestStatus2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_LabTestStatus4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_LabTestStatus5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_InchargeAccept As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_DateAccept As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
End Class
