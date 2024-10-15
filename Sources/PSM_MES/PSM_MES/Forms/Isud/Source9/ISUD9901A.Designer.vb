<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD9901A
    Inherits PeaceForm_ISUD

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
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.Block1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_NotifyCateSeq = New PSMGlobal.SelectLabelText()
        Me.txt_NotifyCate = New PSMGlobal.SelectLabelText()
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_Dseq = New PSMGlobal.SelectLabelText()
        Me.txt_Name = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Block1.SuspendLayout()
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bloack2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.TableLayoutPanel1)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 38)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(535, 194)
        Me.frm_Condition.TabIndex = 1
        Me.frm_Condition.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Bloack2, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(531, 190)
        Me.TableLayoutPanel1.TabIndex = 43
        '
        'PeacePanel2
        '
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Controls.Add(Me.Block1)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel2.Location = New System.Drawing.Point(2, 2)
        Me.PeacePanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(527, 73)
        Me.PeacePanel2.TabIndex = 0
        Me.PeacePanel2.Tag = ""
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.txt_NotifyCateSeq)
        Me.Block1.Controls.Add(Me.txt_NotifyCate)
        Me.Block1.Data = ""
        Me.Block1.Location = New System.Drawing.Point(5, 3)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(414, 70)
        Me.Block1.TabIndex = 39
        Me.Block1.Tag = ""
        '
        'txt_NotifyCateSeq
        '
        Me.txt_NotifyCateSeq.BackYesno = False
        Me.txt_NotifyCateSeq.ButtonTitle = Nothing
        Me.txt_NotifyCateSeq.Code = Nothing
        Me.txt_NotifyCateSeq.Data = ""
        Me.txt_NotifyCateSeq.DataDecimal = 0
        Me.txt_NotifyCateSeq.DataLen = 0
        Me.txt_NotifyCateSeq.DataValue = 0
        Me.txt_NotifyCateSeq.FormatDecimal = 0
        Me.txt_NotifyCateSeq.FormatValue = False
        Me.txt_NotifyCateSeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_NotifyCateSeq.LableEnabled = True
        Me.txt_NotifyCateSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_NotifyCateSeq.LableForeColor = System.Drawing.Color.Blue
        Me.txt_NotifyCateSeq.LableTitle = "Notify Cate Seq"
        Me.txt_NotifyCateSeq.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_NotifyCateSeq.Location = New System.Drawing.Point(2, 35)
        Me.txt_NotifyCateSeq.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_NotifyCateSeq.Name = "txt_NotifyCateSeq"
        Me.txt_NotifyCateSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_NotifyCateSeq.Size = New System.Drawing.Size(406, 29)
        Me.txt_NotifyCateSeq.TabIndex = 1
        Me.txt_NotifyCateSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_NotifyCateSeq.TextBoxAutoComplete = False
        Me.txt_NotifyCateSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_NotifyCateSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NotifyCateSeq.TextEnabled = True
        Me.txt_NotifyCateSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_NotifyCateSeq.TextMaxLength = 32767
        Me.txt_NotifyCateSeq.TextMultiLine = False
        Me.txt_NotifyCateSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_NotifyCateSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_NotifyCateSeq.UseSendTab = True
        '
        'txt_NotifyCate
        '
        Me.txt_NotifyCate.BackYesno = False
        Me.txt_NotifyCate.ButtonTitle = Nothing
        Me.txt_NotifyCate.Code = Nothing
        Me.txt_NotifyCate.Data = ""
        Me.txt_NotifyCate.DataDecimal = 0
        Me.txt_NotifyCate.DataLen = 0
        Me.txt_NotifyCate.DataValue = 0
        Me.txt_NotifyCate.Enabled = False
        Me.txt_NotifyCate.FormatDecimal = 0
        Me.txt_NotifyCate.FormatValue = False
        Me.txt_NotifyCate.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_NotifyCate.LableEnabled = True
        Me.txt_NotifyCate.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_NotifyCate.LableForeColor = System.Drawing.Color.Red
        Me.txt_NotifyCate.LableTitle = "Notify Cate"
        Me.txt_NotifyCate.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_NotifyCate.Location = New System.Drawing.Point(2, 2)
        Me.txt_NotifyCate.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_NotifyCate.Name = "txt_NotifyCate"
        Me.txt_NotifyCate.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_NotifyCate.Size = New System.Drawing.Size(406, 29)
        Me.txt_NotifyCate.TabIndex = 0
        Me.txt_NotifyCate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_NotifyCate.TextBoxAutoComplete = False
        Me.txt_NotifyCate.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_NotifyCate.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NotifyCate.TextEnabled = True
        Me.txt_NotifyCate.TextForeColor = System.Drawing.Color.Empty
        Me.txt_NotifyCate.TextMaxLength = 32767
        Me.txt_NotifyCate.TextMultiLine = False
        Me.txt_NotifyCate.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_NotifyCate.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_NotifyCate.UseSendTab = True
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Code = ""
        Me.Bloack2.Controls.Add(Me.txt_Dseq)
        Me.Bloack2.Controls.Add(Me.txt_Name)
        Me.Bloack2.Controls.Add(Me.tit_Use)
        Me.Bloack2.Controls.Add(Me.Panel5)
        Me.Bloack2.Data = ""
        Me.Bloack2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Bloack2.Location = New System.Drawing.Point(4, 80)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(523, 106)
        Me.Bloack2.TabIndex = 40
        Me.Bloack2.Tag = ""
        '
        'txt_Dseq
        '
        Me.txt_Dseq.BackYesno = False
        Me.txt_Dseq.ButtonTitle = Nothing
        Me.txt_Dseq.Code = Nothing
        Me.txt_Dseq.Data = ""
        Me.txt_Dseq.DataDecimal = 0
        Me.txt_Dseq.DataLen = 0
        Me.txt_Dseq.DataValue = 0
        Me.txt_Dseq.FormatDecimal = 0
        Me.txt_Dseq.FormatValue = False
        Me.txt_Dseq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Dseq.LableEnabled = True
        Me.txt_Dseq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Dseq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Dseq.LableTitle = "Dseq"
        Me.txt_Dseq.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Dseq.Location = New System.Drawing.Point(5, 3)
        Me.txt_Dseq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Dseq.Name = "txt_Dseq"
        Me.txt_Dseq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Dseq.Size = New System.Drawing.Size(406, 29)
        Me.txt_Dseq.TabIndex = 110
        Me.txt_Dseq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Dseq.TextBoxAutoComplete = False
        Me.txt_Dseq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Dseq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Dseq.TextEnabled = True
        Me.txt_Dseq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Dseq.TextMaxLength = 32767
        Me.txt_Dseq.TextMultiLine = False
        Me.txt_Dseq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Dseq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Dseq.UseSendTab = True
        '
        'txt_Name
        '
        Me.txt_Name.BackYesno = False
        Me.txt_Name.ButtonTitle = Nothing
        Me.txt_Name.Code = Nothing
        Me.txt_Name.Data = ""
        Me.txt_Name.DataDecimal = 0
        Me.txt_Name.DataLen = 0
        Me.txt_Name.DataValue = 0
        Me.txt_Name.FormatDecimal = 0
        Me.txt_Name.FormatValue = False
        Me.txt_Name.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Name.LableEnabled = True
        Me.txt_Name.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Name.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Name.LableTitle = " Name"
        Me.txt_Name.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Name.Location = New System.Drawing.Point(5, 34)
        Me.txt_Name.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Name.Size = New System.Drawing.Size(406, 29)
        Me.txt_Name.TabIndex = 3
        Me.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Name.TextBoxAutoComplete = False
        Me.txt_Name.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Name.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Name.TextEnabled = True
        Me.txt_Name.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Name.TextMaxLength = 32767
        Me.txt_Name.TextMultiLine = False
        Me.txt_Name.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Name.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Name.UseSendTab = True
        '
        'tit_Use
        '
        Me.tit_Use.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Use.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tit_Use.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tit_Use.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tit_Use.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tit_Use.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_Use.ButtonTitle = Nothing
        Me.tit_Use.Code = ""
        Me.tit_Use.Data = ""
        Me.tit_Use.DTDec = 0
        Me.tit_Use.DTLen = 0
        Me.tit_Use.DTValue = 0
        Me.tit_Use.Location = New System.Drawing.Point(5, 65)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(137, 29)
        Me.tit_Use.TabIndex = 15
        Me.tit_Use.Tag = ""
        Me.tit_Use.Text = "Use"
        Me.tit_Use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Controls.Add(Me.rad_CheckUse2, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckUse1, 0, 0)
        Me.Panel5.Location = New System.Drawing.Point(144, 65)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(128, 29)
        Me.Panel5.TabIndex = 109
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.AutoSize = True
        Me.rad_CheckUse2.ButtonTitle = Nothing
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(67, 4)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(41, 18)
        Me.rad_CheckUse2.TabIndex = 3
        Me.rad_CheckUse2.TabStop = True
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.AutoSize = True
        Me.rad_CheckUse1.ButtonTitle = Nothing
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(45, 18)
        Me.rad_CheckUse1.TabIndex = 2
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'ISUD9901A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(535, 232)
        Me.Controls.Add(Me.frm_Condition)
        Me.Name = "ISUD9901A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ISUD9901"
        Me.Controls.SetChildIndex(Me.frm_Condition, 0)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        Me.PeacePanel2.PerformLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block1.ResumeLayout(False)
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bloack2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_Name As PSMGlobal.SelectLabelText
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents Block1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_NotifyCateSeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_NotifyCate As PSMGlobal.SelectLabelText
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_Dseq As PSMGlobal.SelectLabelText
End Class
