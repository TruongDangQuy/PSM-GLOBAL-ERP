<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7501B
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7501B))
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_Check10 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check9 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check8 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check7 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check6 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check5 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check4 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check3 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_Check1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.txt_BasicName = New PSMGlobal.SelectLabelText()
        Me.txt_ForeignName1 = New PSMGlobal.SelectLabelText()
        Me.txt_NameSimply = New PSMGlobal.SelectLabelText()
        Me.txt_ForeignName2 = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_UseCheck2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_UseCheck1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_DisplaySeq = New PSMGlobal.SelectLabelText()
        Me.txt_remark = New PSMGlobal.SelectLabelText()
        Me.FlowLayoutPanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_DevelopmentCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_AccCode = New PSMGlobal.SelectLabelText()
        Me.frm_Condition.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Bloack2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.Frame4)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Controls.Add(Me.FlowLayoutPanel3)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(849, 481)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Location = New System.Drawing.Point(9, 437)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(828, 39)
        Me.Frame4.TabIndex = 0
        Me.Frame4.Tag = ""
        '
        'cmd_DEL
        '
        Me.cmd_DEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_DEL.Location = New System.Drawing.Point(1, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(140, 35)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancel.Location = New System.Drawing.Point(683, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(140, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_OK.Location = New System.Drawing.Point(542, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(140, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Code = ""
        Me.Bloack2.Controls.Add(Me.chk_Check10)
        Me.Bloack2.Controls.Add(Me.chk_Check9)
        Me.Bloack2.Controls.Add(Me.chk_Check8)
        Me.Bloack2.Controls.Add(Me.chk_Check7)
        Me.Bloack2.Controls.Add(Me.chk_Check6)
        Me.Bloack2.Controls.Add(Me.chk_Check5)
        Me.Bloack2.Controls.Add(Me.chk_Check4)
        Me.Bloack2.Controls.Add(Me.chk_Check3)
        Me.Bloack2.Controls.Add(Me.chk_Check2)
        Me.Bloack2.Controls.Add(Me.chk_Check1)
        Me.Bloack2.Controls.Add(Me.txt_BasicName)
        Me.Bloack2.Controls.Add(Me.txt_ForeignName1)
        Me.Bloack2.Controls.Add(Me.txt_NameSimply)
        Me.Bloack2.Controls.Add(Me.txt_ForeignName2)
        Me.Bloack2.Controls.Add(Me.tit_Use)
        Me.Bloack2.Controls.Add(Me.Panel5)
        Me.Bloack2.Controls.Add(Me.txt_DisplaySeq)
        Me.Bloack2.Controls.Add(Me.txt_remark)
        Me.Bloack2.Data = ""
        Me.Bloack2.Location = New System.Drawing.Point(9, 77)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(827, 354)
        Me.Bloack2.TabIndex = 40
        Me.Bloack2.Tag = ""
        '
        'chk_Check10
        '
        Me.chk_Check10.AutoSize = True
        Me.chk_Check10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check10.Location = New System.Drawing.Point(415, 183)
        Me.chk_Check10.Name = "chk_Check10"
        Me.chk_Check10.Size = New System.Drawing.Size(118, 20)
        Me.chk_Check10.TabIndex = 119
        Me.chk_Check10.Text = "Cash/Bank Use"
        Me.chk_Check10.UseVisualStyleBackColor = True
        Me.chk_Check10.Visible = False
        '
        'chk_Check9
        '
        Me.chk_Check9.AutoSize = True
        Me.chk_Check9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check9.Location = New System.Drawing.Point(413, 157)
        Me.chk_Check9.Name = "chk_Check9"
        Me.chk_Check9.Size = New System.Drawing.Size(118, 20)
        Me.chk_Check9.TabIndex = 118
        Me.chk_Check9.Text = "Cash/Bank Use"
        Me.chk_Check9.UseVisualStyleBackColor = True
        Me.chk_Check9.Visible = False
        '
        'chk_Check8
        '
        Me.chk_Check8.AutoSize = True
        Me.chk_Check8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check8.Location = New System.Drawing.Point(413, 131)
        Me.chk_Check8.Name = "chk_Check8"
        Me.chk_Check8.Size = New System.Drawing.Size(118, 20)
        Me.chk_Check8.TabIndex = 117
        Me.chk_Check8.Text = "Cash/Bank Use"
        Me.chk_Check8.UseVisualStyleBackColor = True
        Me.chk_Check8.Visible = False
        '
        'chk_Check7
        '
        Me.chk_Check7.AutoSize = True
        Me.chk_Check7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check7.Location = New System.Drawing.Point(413, 105)
        Me.chk_Check7.Name = "chk_Check7"
        Me.chk_Check7.Size = New System.Drawing.Size(118, 20)
        Me.chk_Check7.TabIndex = 116
        Me.chk_Check7.Text = "Cash/Bank Use"
        Me.chk_Check7.UseVisualStyleBackColor = True
        Me.chk_Check7.Visible = False
        '
        'chk_Check6
        '
        Me.chk_Check6.AutoSize = True
        Me.chk_Check6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check6.Location = New System.Drawing.Point(413, 79)
        Me.chk_Check6.Name = "chk_Check6"
        Me.chk_Check6.Size = New System.Drawing.Size(118, 20)
        Me.chk_Check6.TabIndex = 115
        Me.chk_Check6.Text = "Cash/Bank Use"
        Me.chk_Check6.UseVisualStyleBackColor = True
        Me.chk_Check6.Visible = False
        '
        'chk_Check5
        '
        Me.chk_Check5.AutoSize = True
        Me.chk_Check5.Checked = True
        Me.chk_Check5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Check5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check5.Location = New System.Drawing.Point(23, 183)
        Me.chk_Check5.Name = "chk_Check5"
        Me.chk_Check5.Size = New System.Drawing.Size(92, 20)
        Me.chk_Check5.TabIndex = 114
        Me.chk_Check5.Text = "Report Use"
        Me.chk_Check5.UseVisualStyleBackColor = True
        '
        'chk_Check4
        '
        Me.chk_Check4.AutoSize = True
        Me.chk_Check4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check4.Location = New System.Drawing.Point(21, 157)
        Me.chk_Check4.Name = "chk_Check4"
        Me.chk_Check4.Size = New System.Drawing.Size(101, 20)
        Me.chk_Check4.TabIndex = 113
        Me.chk_Check4.Text = "Payable Use"
        Me.chk_Check4.UseVisualStyleBackColor = True
        '
        'chk_Check3
        '
        Me.chk_Check3.AutoSize = True
        Me.chk_Check3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check3.Location = New System.Drawing.Point(21, 131)
        Me.chk_Check3.Name = "chk_Check3"
        Me.chk_Check3.Size = New System.Drawing.Size(116, 20)
        Me.chk_Check3.TabIndex = 112
        Me.chk_Check3.Text = "Receivable Use"
        Me.chk_Check3.UseVisualStyleBackColor = True
        '
        'chk_Check2
        '
        Me.chk_Check2.AutoSize = True
        Me.chk_Check2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check2.Location = New System.Drawing.Point(21, 105)
        Me.chk_Check2.Name = "chk_Check2"
        Me.chk_Check2.Size = New System.Drawing.Size(156, 20)
        Me.chk_Check2.TabIndex = 111
        Me.chk_Check2.Text = "Expense [Output Use]"
        Me.chk_Check2.UseVisualStyleBackColor = True
        '
        'chk_Check1
        '
        Me.chk_Check1.AutoSize = True
        Me.chk_Check1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Check1.Location = New System.Drawing.Point(21, 79)
        Me.chk_Check1.Name = "chk_Check1"
        Me.chk_Check1.Size = New System.Drawing.Size(158, 20)
        Me.chk_Check1.TabIndex = 110
        Me.chk_Check1.Text = "Cash/Bank [Input Use]"
        Me.chk_Check1.UseVisualStyleBackColor = True
        '
        'txt_BasicName
        '
        Me.txt_BasicName.BackYesno = False
        Me.txt_BasicName.ButtonTitle = Nothing
        Me.txt_BasicName.Code = Nothing
        Me.txt_BasicName.Data = Nothing
        Me.txt_BasicName.DataDecimal = 0
        Me.txt_BasicName.DataLen = 0
        Me.txt_BasicName.DataValue = 0
        Me.txt_BasicName.FormatDecimal = 0
        Me.txt_BasicName.FormatValue = False
        Me.txt_BasicName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_BasicName.LableEnabled = True
        Me.txt_BasicName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_BasicName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_BasicName.LableTitle = "Baisc Name"
        Me.txt_BasicName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_BasicName.Location = New System.Drawing.Point(1, 1)
        Me.txt_BasicName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_BasicName.Name = "txt_BasicName"
        Me.txt_BasicName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BasicName.Size = New System.Drawing.Size(410, 29)
        Me.txt_BasicName.TabIndex = 3
        Me.txt_BasicName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BasicName.TextBoxAutoComplete = False
        Me.txt_BasicName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_BasicName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_BasicName.TextEnabled = True
        Me.txt_BasicName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_BasicName.TextMaxLength = 32767
        Me.txt_BasicName.TextMultiLine = False
        Me.txt_BasicName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BasicName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BasicName.UseSendTab = True
        '
        'txt_ForeignName1
        '
        Me.txt_ForeignName1.BackYesno = False
        Me.txt_ForeignName1.ButtonTitle = Nothing
        Me.txt_ForeignName1.Code = Nothing
        Me.txt_ForeignName1.Data = Nothing
        Me.txt_ForeignName1.DataDecimal = 0
        Me.txt_ForeignName1.DataLen = 0
        Me.txt_ForeignName1.DataValue = 0
        Me.txt_ForeignName1.FormatDecimal = 0
        Me.txt_ForeignName1.FormatValue = False
        Me.txt_ForeignName1.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ForeignName1.LableEnabled = True
        Me.txt_ForeignName1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ForeignName1.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ForeignName1.LableTitle = "Foreign Name 1"
        Me.txt_ForeignName1.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ForeignName1.Location = New System.Drawing.Point(413, 1)
        Me.txt_ForeignName1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ForeignName1.Name = "txt_ForeignName1"
        Me.txt_ForeignName1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ForeignName1.Size = New System.Drawing.Size(410, 29)
        Me.txt_ForeignName1.TabIndex = 5
        Me.txt_ForeignName1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ForeignName1.TextBoxAutoComplete = False
        Me.txt_ForeignName1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ForeignName1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ForeignName1.TextEnabled = True
        Me.txt_ForeignName1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ForeignName1.TextMaxLength = 32767
        Me.txt_ForeignName1.TextMultiLine = False
        Me.txt_ForeignName1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ForeignName1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ForeignName1.UseSendTab = True
        '
        'txt_NameSimply
        '
        Me.txt_NameSimply.BackYesno = False
        Me.txt_NameSimply.ButtonTitle = Nothing
        Me.txt_NameSimply.Code = Nothing
        Me.txt_NameSimply.Data = Nothing
        Me.txt_NameSimply.DataDecimal = 0
        Me.txt_NameSimply.DataLen = 0
        Me.txt_NameSimply.DataValue = 0
        Me.txt_NameSimply.FormatDecimal = 0
        Me.txt_NameSimply.FormatValue = False
        Me.txt_NameSimply.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_NameSimply.LableEnabled = True
        Me.txt_NameSimply.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NameSimply.LableForeColor = System.Drawing.Color.Empty
        Me.txt_NameSimply.LableTitle = "Simple Name"
        Me.txt_NameSimply.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_NameSimply.Location = New System.Drawing.Point(1, 32)
        Me.txt_NameSimply.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_NameSimply.Name = "txt_NameSimply"
        Me.txt_NameSimply.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_NameSimply.Size = New System.Drawing.Size(410, 29)
        Me.txt_NameSimply.TabIndex = 4
        Me.txt_NameSimply.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_NameSimply.TextBoxAutoComplete = False
        Me.txt_NameSimply.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_NameSimply.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NameSimply.TextEnabled = True
        Me.txt_NameSimply.TextForeColor = System.Drawing.Color.Empty
        Me.txt_NameSimply.TextMaxLength = 32767
        Me.txt_NameSimply.TextMultiLine = False
        Me.txt_NameSimply.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_NameSimply.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_NameSimply.UseSendTab = True
        '
        'txt_ForeignName2
        '
        Me.txt_ForeignName2.BackYesno = False
        Me.txt_ForeignName2.ButtonTitle = Nothing
        Me.txt_ForeignName2.Code = Nothing
        Me.txt_ForeignName2.Data = Nothing
        Me.txt_ForeignName2.DataDecimal = 0
        Me.txt_ForeignName2.DataLen = 0
        Me.txt_ForeignName2.DataValue = 0
        Me.txt_ForeignName2.FormatDecimal = 0
        Me.txt_ForeignName2.FormatValue = False
        Me.txt_ForeignName2.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ForeignName2.LableEnabled = True
        Me.txt_ForeignName2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ForeignName2.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ForeignName2.LableTitle = "Foreign Name 2"
        Me.txt_ForeignName2.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ForeignName2.Location = New System.Drawing.Point(413, 32)
        Me.txt_ForeignName2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ForeignName2.Name = "txt_ForeignName2"
        Me.txt_ForeignName2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ForeignName2.Size = New System.Drawing.Size(410, 29)
        Me.txt_ForeignName2.TabIndex = 6
        Me.txt_ForeignName2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ForeignName2.TextBoxAutoComplete = False
        Me.txt_ForeignName2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ForeignName2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ForeignName2.TextEnabled = True
        Me.txt_ForeignName2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ForeignName2.TextMaxLength = 32767
        Me.txt_ForeignName2.TextMultiLine = False
        Me.txt_ForeignName2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ForeignName2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ForeignName2.UseSendTab = True
        '
        'tit_Use
        '
        Me.tit_Use.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Use.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_Use.Code = ""
        Me.tit_Use.Data = ""
        Me.tit_Use.DTDec = 0
        Me.tit_Use.DTLen = 0
        Me.tit_Use.DTValue = 0
        Me.tit_Use.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tit_Use.ForeColor = System.Drawing.Color.Black
        Me.tit_Use.Location = New System.Drawing.Point(1, 218)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(138, 29)
        Me.tit_Use.TabIndex = 15
        Me.tit_Use.Tag = ""
        Me.tit_Use.Text = "Use"
        Me.tit_Use.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel5
        '
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Controls.Add(Me.chk_UseCheck2, 1, 0)
        Me.Panel5.Controls.Add(Me.chk_UseCheck1, 0, 0)
        Me.Panel5.Location = New System.Drawing.Point(141, 218)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(128, 29)
        Me.Panel5.TabIndex = 109
        '
        'chk_UseCheck2
        '
        Me.chk_UseCheck2.AutoSize = True
        Me.chk_UseCheck2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_UseCheck2.Location = New System.Drawing.Point(67, 4)
        Me.chk_UseCheck2.Name = "chk_UseCheck2"
        Me.chk_UseCheck2.Size = New System.Drawing.Size(40, 19)
        Me.chk_UseCheck2.TabIndex = 3
        Me.chk_UseCheck2.Text = "No"
        Me.chk_UseCheck2.UseVisualStyleBackColor = True
        '
        'chk_UseCheck1
        '
        Me.chk_UseCheck1.AutoSize = True
        Me.chk_UseCheck1.Checked = True
        Me.chk_UseCheck1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_UseCheck1.Location = New System.Drawing.Point(4, 4)
        Me.chk_UseCheck1.Name = "chk_UseCheck1"
        Me.chk_UseCheck1.Size = New System.Drawing.Size(45, 19)
        Me.chk_UseCheck1.TabIndex = 2
        Me.chk_UseCheck1.TabStop = True
        Me.chk_UseCheck1.Text = "Yes"
        Me.chk_UseCheck1.UseVisualStyleBackColor = True
        '
        'txt_DisplaySeq
        '
        Me.txt_DisplaySeq.BackYesno = False
        Me.txt_DisplaySeq.ButtonTitle = Nothing
        Me.txt_DisplaySeq.Code = Nothing
        Me.txt_DisplaySeq.Data = Nothing
        Me.txt_DisplaySeq.DataDecimal = 0
        Me.txt_DisplaySeq.DataLen = 0
        Me.txt_DisplaySeq.DataValue = 0
        Me.txt_DisplaySeq.FormatDecimal = 0
        Me.txt_DisplaySeq.FormatValue = False
        Me.txt_DisplaySeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DisplaySeq.LableEnabled = True
        Me.txt_DisplaySeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DisplaySeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DisplaySeq.LableTitle = "Display Seq"
        Me.txt_DisplaySeq.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_DisplaySeq.Location = New System.Drawing.Point(413, 218)
        Me.txt_DisplaySeq.Margin = New System.Windows.Forms.Padding(143, 1, 1, 1)
        Me.txt_DisplaySeq.Name = "txt_DisplaySeq"
        Me.txt_DisplaySeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DisplaySeq.Size = New System.Drawing.Size(205, 29)
        Me.txt_DisplaySeq.TabIndex = 27
        Me.txt_DisplaySeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DisplaySeq.TextBoxAutoComplete = False
        Me.txt_DisplaySeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DisplaySeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DisplaySeq.TextEnabled = True
        Me.txt_DisplaySeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DisplaySeq.TextMaxLength = 32767
        Me.txt_DisplaySeq.TextMultiLine = False
        Me.txt_DisplaySeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DisplaySeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DisplaySeq.UseSendTab = True
        '
        'txt_remark
        '
        Me.txt_remark.BackYesno = False
        Me.txt_remark.ButtonTitle = Nothing
        Me.txt_remark.Code = Nothing
        Me.txt_remark.Data = Nothing
        Me.txt_remark.DataDecimal = 0
        Me.txt_remark.DataLen = 0
        Me.txt_remark.DataValue = 0
        Me.txt_remark.FormatDecimal = 0
        Me.txt_remark.FormatValue = False
        Me.txt_remark.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_remark.LableEnabled = True
        Me.txt_remark.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_remark.LableForeColor = System.Drawing.Color.Empty
        Me.txt_remark.LableTitle = "Remark"
        Me.txt_remark.Layoutpercent = New Decimal(New Integer() {169, 0, 0, 196608})
        Me.txt_remark.Location = New System.Drawing.Point(2, 250)
        Me.txt_remark.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_remark.Size = New System.Drawing.Size(821, 98)
        Me.txt_remark.TabIndex = 28
        Me.txt_remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_remark.TextBoxAutoComplete = False
        Me.txt_remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_remark.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_remark.TextEnabled = True
        Me.txt_remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_remark.TextMaxLength = 32767
        Me.txt_remark.TextMultiLine = True
        Me.txt_remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_remark.UseSendTab = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel3.Code = ""
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_DevelopmentCode)
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_AccCode)
        Me.FlowLayoutPanel3.Data = ""
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(9, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(827, 66)
        Me.FlowLayoutPanel3.TabIndex = 41
        Me.FlowLayoutPanel3.Tag = ""
        '
        'txt_DevelopmentCode
        '
        Me.txt_DevelopmentCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DevelopmentCode.ButtonEnabled = True
        Me.txt_DevelopmentCode.ButtonFont = Nothing
        Me.txt_DevelopmentCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.ButtonName = "Const_AccCode"
        Me.txt_DevelopmentCode.ButtonTitle = "Account Main"
        Me.txt_DevelopmentCode.Code = Nothing
        Me.txt_DevelopmentCode.Data = Nothing
        Me.txt_DevelopmentCode.DataDecimal = 0
        Me.txt_DevelopmentCode.DataLen = 0
        Me.txt_DevelopmentCode.DataValue = 1
        Me.txt_DevelopmentCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_DevelopmentCode.Location = New System.Drawing.Point(2, 34)
        Me.txt_DevelopmentCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DevelopmentCode.Name = "txt_DevelopmentCode"
        Me.txt_DevelopmentCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DevelopmentCode.Size = New System.Drawing.Size(409, 26)
        Me.txt_DevelopmentCode.TabIndex = 117
        Me.txt_DevelopmentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DevelopmentCode.TextBoxAutoComplete = False
        Me.txt_DevelopmentCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DevelopmentCode.TextEnabled = True
        Me.txt_DevelopmentCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.TextMaxLength = 32767
        Me.txt_DevelopmentCode.TextMultiLine = False
        Me.txt_DevelopmentCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DevelopmentCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DevelopmentCode.UseSendTab = True
        '
        'txt_AccCode
        '
        Me.txt_AccCode.BackYesno = False
        Me.txt_AccCode.ButtonTitle = Nothing
        Me.txt_AccCode.Code = Nothing
        Me.txt_AccCode.Data = Nothing
        Me.txt_AccCode.DataDecimal = 0
        Me.txt_AccCode.DataLen = 0
        Me.txt_AccCode.DataValue = 0
        Me.txt_AccCode.FormatDecimal = 0
        Me.txt_AccCode.FormatValue = False
        Me.txt_AccCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_AccCode.LableEnabled = True
        Me.txt_AccCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_AccCode.LableTitle = "Account Code"
        Me.txt_AccCode.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_AccCode.Location = New System.Drawing.Point(2, 2)
        Me.txt_AccCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_AccCode.Name = "txt_AccCode"
        Me.txt_AccCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccCode.Size = New System.Drawing.Size(277, 29)
        Me.txt_AccCode.TabIndex = 2
        Me.txt_AccCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccCode.TextBoxAutoComplete = False
        Me.txt_AccCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccCode.TextEnabled = True
        Me.txt_AccCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_AccCode.TextMaxLength = 32767
        Me.txt_AccCode.TextMultiLine = False
        Me.txt_AccCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccCode.UseSendTab = True
        '
        'ISUD7501B
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(849, 481)
        Me.Controls.Add(Me.frm_Condition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.KeyPreview = True
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "ISUD7501B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNTING CODE PROCESSING (ISUD7501A)"
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Bloack2.ResumeLayout(False)
        Me.Bloack2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents txt_ForeignName2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ForeignName1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_AccCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_NameSimply As PSMGlobal.SelectLabelText
    Friend WithEvents txt_BasicName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DisplaySeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_remark As PSMGlobal.SelectLabelText
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel3 As PSMGlobal.PeacePanel
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chk_UseCheck2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_UseCheck1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_DevelopmentCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents chk_Check10 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check9 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check8 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check7 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check6 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check5 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check4 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check3 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_Check1 As PSMGlobal.PeaceCheckbox
End Class
