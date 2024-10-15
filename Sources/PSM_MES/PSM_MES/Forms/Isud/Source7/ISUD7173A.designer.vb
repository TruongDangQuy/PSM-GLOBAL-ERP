<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7173A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7173A))
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_BasicName = New PSMGlobal.SelectLabelText()
        Me.txt_ForeignName1 = New PSMGlobal.SelectLabelText()
        Me.txt_NameSimply = New PSMGlobal.SelectLabelText()
        Me.txt_ForeignName2 = New PSMGlobal.SelectLabelText()
        Me.txt_check1 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname1 = New PSMGlobal.SelectLabelText()
        Me.txt_check6 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname6 = New PSMGlobal.SelectLabelText()
        Me.txt_check2 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname2 = New PSMGlobal.SelectLabelText()
        Me.txt_check7 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname7 = New PSMGlobal.SelectLabelText()
        Me.txt_check3 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname3 = New PSMGlobal.SelectLabelText()
        Me.txt_check8 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname8 = New PSMGlobal.SelectLabelText()
        Me.txt_check4 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname4 = New PSMGlobal.SelectLabelText()
        Me.txt_check9 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname9 = New PSMGlobal.SelectLabelText()
        Me.txt_check5 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname5 = New PSMGlobal.SelectLabelText()
        Me.txt_check10 = New PSMGlobal.SelectLabelText()
        Me.txt_Checkname10 = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_UseCheck2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_UseCheck1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_DisplaySeq = New PSMGlobal.SelectLabelText()
        Me.txt_remark = New PSMGlobal.SelectLabelText()
        Me.FlowLayoutPanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_AccountCode = New PSMGlobal.SelectLabelText()
        Me.txt_BankCode = New PSMGlobal.SelectLabelText()
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bloack2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.FlowLayoutPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Frame4.Controls.Add(Me.cmd_AttachID)
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
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 16
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
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(683, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(140, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
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
        Me.Bloack2.Controls.Add(Me.txt_BasicName)
        Me.Bloack2.Controls.Add(Me.txt_ForeignName1)
        Me.Bloack2.Controls.Add(Me.txt_NameSimply)
        Me.Bloack2.Controls.Add(Me.txt_ForeignName2)
        Me.Bloack2.Controls.Add(Me.txt_check1)
        Me.Bloack2.Controls.Add(Me.txt_Checkname1)
        Me.Bloack2.Controls.Add(Me.txt_check6)
        Me.Bloack2.Controls.Add(Me.txt_Checkname6)
        Me.Bloack2.Controls.Add(Me.txt_check2)
        Me.Bloack2.Controls.Add(Me.txt_Checkname2)
        Me.Bloack2.Controls.Add(Me.txt_check7)
        Me.Bloack2.Controls.Add(Me.txt_Checkname7)
        Me.Bloack2.Controls.Add(Me.txt_check3)
        Me.Bloack2.Controls.Add(Me.txt_Checkname3)
        Me.Bloack2.Controls.Add(Me.txt_check8)
        Me.Bloack2.Controls.Add(Me.txt_Checkname8)
        Me.Bloack2.Controls.Add(Me.txt_check4)
        Me.Bloack2.Controls.Add(Me.txt_Checkname4)
        Me.Bloack2.Controls.Add(Me.txt_check9)
        Me.Bloack2.Controls.Add(Me.txt_Checkname9)
        Me.Bloack2.Controls.Add(Me.txt_check5)
        Me.Bloack2.Controls.Add(Me.txt_Checkname5)
        Me.Bloack2.Controls.Add(Me.txt_check10)
        Me.Bloack2.Controls.Add(Me.txt_Checkname10)
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
        'txt_BasicName
        '
        Me.txt_BasicName.BackYesno = False
        Me.txt_BasicName.ButtonTitle = Nothing
        Me.txt_BasicName.Code = Nothing
        Me.txt_BasicName.Data = ""
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
        Me.txt_ForeignName1.Data = ""
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
        Me.txt_NameSimply.Data = ""
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
        Me.txt_ForeignName2.Data = ""
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
        'txt_check1
        '
        Me.txt_check1.BackYesno = False
        Me.txt_check1.ButtonTitle = Nothing
        Me.txt_check1.Code = Nothing
        Me.txt_check1.Data = ""
        Me.txt_check1.DataDecimal = 0
        Me.txt_check1.DataLen = 0
        Me.txt_check1.DataValue = 0
        Me.txt_check1.FormatDecimal = 0
        Me.txt_check1.FormatValue = False
        Me.txt_check1.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check1.LableEnabled = True
        Me.txt_check1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check1.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check1.LableTitle = "Check 1"
        Me.txt_check1.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check1.Location = New System.Drawing.Point(1, 63)
        Me.txt_check1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check1.Name = "txt_check1"
        Me.txt_check1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check1.Size = New System.Drawing.Size(205, 29)
        Me.txt_check1.TabIndex = 7
        Me.txt_check1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check1.TextBoxAutoComplete = False
        Me.txt_check1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check1.TextEnabled = True
        Me.txt_check1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check1.TextMaxLength = 32767
        Me.txt_check1.TextMultiLine = False
        Me.txt_check1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check1.UseSendTab = True
        '
        'txt_Checkname1
        '
        Me.txt_Checkname1.BackYesno = False
        Me.txt_Checkname1.ButtonTitle = Nothing
        Me.txt_Checkname1.Code = Nothing
        Me.txt_Checkname1.Data = ""
        Me.txt_Checkname1.DataDecimal = 0
        Me.txt_Checkname1.DataLen = 0
        Me.txt_Checkname1.DataValue = 0
        Me.txt_Checkname1.FormatDecimal = 0
        Me.txt_Checkname1.FormatValue = False
        Me.txt_Checkname1.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname1.LableEnabled = True
        Me.txt_Checkname1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname1.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname1.LableTitle = "CHECK 1"
        Me.txt_Checkname1.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname1.Location = New System.Drawing.Point(208, 63)
        Me.txt_Checkname1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname1.Name = "txt_Checkname1"
        Me.txt_Checkname1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname1.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname1.TabIndex = 8
        Me.txt_Checkname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname1.TextBoxAutoComplete = False
        Me.txt_Checkname1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname1.TextEnabled = True
        Me.txt_Checkname1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname1.TextMaxLength = 32767
        Me.txt_Checkname1.TextMultiLine = False
        Me.txt_Checkname1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname1.UseSendTab = True
        '
        'txt_check6
        '
        Me.txt_check6.BackYesno = False
        Me.txt_check6.ButtonTitle = Nothing
        Me.txt_check6.Code = Nothing
        Me.txt_check6.Data = ""
        Me.txt_check6.DataDecimal = 0
        Me.txt_check6.DataLen = 0
        Me.txt_check6.DataValue = 0
        Me.txt_check6.FormatDecimal = 0
        Me.txt_check6.FormatValue = False
        Me.txt_check6.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check6.LableEnabled = True
        Me.txt_check6.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check6.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check6.LableTitle = "Check 6"
        Me.txt_check6.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check6.Location = New System.Drawing.Point(413, 63)
        Me.txt_check6.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check6.Name = "txt_check6"
        Me.txt_check6.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check6.Size = New System.Drawing.Size(205, 29)
        Me.txt_check6.TabIndex = 17
        Me.txt_check6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check6.TextBoxAutoComplete = False
        Me.txt_check6.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check6.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check6.TextEnabled = True
        Me.txt_check6.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check6.TextMaxLength = 32767
        Me.txt_check6.TextMultiLine = False
        Me.txt_check6.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check6.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check6.UseSendTab = True
        '
        'txt_Checkname6
        '
        Me.txt_Checkname6.BackYesno = False
        Me.txt_Checkname6.ButtonTitle = Nothing
        Me.txt_Checkname6.Code = Nothing
        Me.txt_Checkname6.Data = ""
        Me.txt_Checkname6.DataDecimal = 0
        Me.txt_Checkname6.DataLen = 0
        Me.txt_Checkname6.DataValue = 0
        Me.txt_Checkname6.FormatDecimal = 0
        Me.txt_Checkname6.FormatValue = False
        Me.txt_Checkname6.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname6.LableEnabled = True
        Me.txt_Checkname6.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname6.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname6.LableTitle = "CHECK 1"
        Me.txt_Checkname6.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname6.Location = New System.Drawing.Point(620, 63)
        Me.txt_Checkname6.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname6.Name = "txt_Checkname6"
        Me.txt_Checkname6.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname6.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname6.TabIndex = 18
        Me.txt_Checkname6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname6.TextBoxAutoComplete = False
        Me.txt_Checkname6.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname6.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname6.TextEnabled = True
        Me.txt_Checkname6.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname6.TextMaxLength = 32767
        Me.txt_Checkname6.TextMultiLine = False
        Me.txt_Checkname6.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname6.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname6.UseSendTab = True
        '
        'txt_check2
        '
        Me.txt_check2.BackYesno = False
        Me.txt_check2.ButtonTitle = Nothing
        Me.txt_check2.Code = Nothing
        Me.txt_check2.Data = ""
        Me.txt_check2.DataDecimal = 0
        Me.txt_check2.DataLen = 0
        Me.txt_check2.DataValue = 0
        Me.txt_check2.FormatDecimal = 0
        Me.txt_check2.FormatValue = False
        Me.txt_check2.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check2.LableEnabled = True
        Me.txt_check2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check2.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check2.LableTitle = "Check 2"
        Me.txt_check2.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check2.Location = New System.Drawing.Point(1, 94)
        Me.txt_check2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check2.Name = "txt_check2"
        Me.txt_check2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check2.Size = New System.Drawing.Size(205, 29)
        Me.txt_check2.TabIndex = 9
        Me.txt_check2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check2.TextBoxAutoComplete = False
        Me.txt_check2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check2.TextEnabled = True
        Me.txt_check2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check2.TextMaxLength = 32767
        Me.txt_check2.TextMultiLine = False
        Me.txt_check2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check2.UseSendTab = True
        '
        'txt_Checkname2
        '
        Me.txt_Checkname2.BackYesno = False
        Me.txt_Checkname2.ButtonTitle = Nothing
        Me.txt_Checkname2.Code = Nothing
        Me.txt_Checkname2.Data = ""
        Me.txt_Checkname2.DataDecimal = 0
        Me.txt_Checkname2.DataLen = 0
        Me.txt_Checkname2.DataValue = 0
        Me.txt_Checkname2.FormatDecimal = 0
        Me.txt_Checkname2.FormatValue = False
        Me.txt_Checkname2.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname2.LableEnabled = True
        Me.txt_Checkname2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname2.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname2.LableTitle = "CHECK 1"
        Me.txt_Checkname2.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname2.Location = New System.Drawing.Point(208, 94)
        Me.txt_Checkname2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname2.Name = "txt_Checkname2"
        Me.txt_Checkname2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname2.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname2.TabIndex = 10
        Me.txt_Checkname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname2.TextBoxAutoComplete = False
        Me.txt_Checkname2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname2.TextEnabled = True
        Me.txt_Checkname2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname2.TextMaxLength = 32767
        Me.txt_Checkname2.TextMultiLine = False
        Me.txt_Checkname2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname2.UseSendTab = True
        '
        'txt_check7
        '
        Me.txt_check7.BackYesno = False
        Me.txt_check7.ButtonTitle = Nothing
        Me.txt_check7.Code = Nothing
        Me.txt_check7.Data = ""
        Me.txt_check7.DataDecimal = 0
        Me.txt_check7.DataLen = 0
        Me.txt_check7.DataValue = 0
        Me.txt_check7.FormatDecimal = 0
        Me.txt_check7.FormatValue = False
        Me.txt_check7.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check7.LableEnabled = True
        Me.txt_check7.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check7.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check7.LableTitle = "Check 7"
        Me.txt_check7.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check7.Location = New System.Drawing.Point(413, 94)
        Me.txt_check7.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check7.Name = "txt_check7"
        Me.txt_check7.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check7.Size = New System.Drawing.Size(205, 29)
        Me.txt_check7.TabIndex = 19
        Me.txt_check7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check7.TextBoxAutoComplete = False
        Me.txt_check7.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check7.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check7.TextEnabled = True
        Me.txt_check7.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check7.TextMaxLength = 32767
        Me.txt_check7.TextMultiLine = False
        Me.txt_check7.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check7.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check7.UseSendTab = True
        '
        'txt_Checkname7
        '
        Me.txt_Checkname7.BackYesno = False
        Me.txt_Checkname7.ButtonTitle = Nothing
        Me.txt_Checkname7.Code = Nothing
        Me.txt_Checkname7.Data = ""
        Me.txt_Checkname7.DataDecimal = 0
        Me.txt_Checkname7.DataLen = 0
        Me.txt_Checkname7.DataValue = 0
        Me.txt_Checkname7.FormatDecimal = 0
        Me.txt_Checkname7.FormatValue = False
        Me.txt_Checkname7.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname7.LableEnabled = True
        Me.txt_Checkname7.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname7.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname7.LableTitle = "CHECK 1"
        Me.txt_Checkname7.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname7.Location = New System.Drawing.Point(620, 94)
        Me.txt_Checkname7.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname7.Name = "txt_Checkname7"
        Me.txt_Checkname7.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname7.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname7.TabIndex = 20
        Me.txt_Checkname7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname7.TextBoxAutoComplete = False
        Me.txt_Checkname7.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname7.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname7.TextEnabled = True
        Me.txt_Checkname7.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname7.TextMaxLength = 32767
        Me.txt_Checkname7.TextMultiLine = False
        Me.txt_Checkname7.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname7.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname7.UseSendTab = True
        '
        'txt_check3
        '
        Me.txt_check3.BackYesno = False
        Me.txt_check3.ButtonTitle = Nothing
        Me.txt_check3.Code = Nothing
        Me.txt_check3.Data = ""
        Me.txt_check3.DataDecimal = 0
        Me.txt_check3.DataLen = 0
        Me.txt_check3.DataValue = 0
        Me.txt_check3.FormatDecimal = 0
        Me.txt_check3.FormatValue = False
        Me.txt_check3.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check3.LableEnabled = True
        Me.txt_check3.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check3.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check3.LableTitle = "Check 3"
        Me.txt_check3.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check3.Location = New System.Drawing.Point(1, 125)
        Me.txt_check3.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check3.Name = "txt_check3"
        Me.txt_check3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check3.Size = New System.Drawing.Size(205, 29)
        Me.txt_check3.TabIndex = 11
        Me.txt_check3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check3.TextBoxAutoComplete = False
        Me.txt_check3.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check3.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check3.TextEnabled = True
        Me.txt_check3.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check3.TextMaxLength = 32767
        Me.txt_check3.TextMultiLine = False
        Me.txt_check3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check3.UseSendTab = True
        '
        'txt_Checkname3
        '
        Me.txt_Checkname3.BackYesno = False
        Me.txt_Checkname3.ButtonTitle = Nothing
        Me.txt_Checkname3.Code = Nothing
        Me.txt_Checkname3.Data = ""
        Me.txt_Checkname3.DataDecimal = 0
        Me.txt_Checkname3.DataLen = 0
        Me.txt_Checkname3.DataValue = 0
        Me.txt_Checkname3.FormatDecimal = 0
        Me.txt_Checkname3.FormatValue = False
        Me.txt_Checkname3.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname3.LableEnabled = True
        Me.txt_Checkname3.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname3.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname3.LableTitle = "CHECK 1"
        Me.txt_Checkname3.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname3.Location = New System.Drawing.Point(208, 125)
        Me.txt_Checkname3.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname3.Name = "txt_Checkname3"
        Me.txt_Checkname3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname3.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname3.TabIndex = 12
        Me.txt_Checkname3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname3.TextBoxAutoComplete = False
        Me.txt_Checkname3.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname3.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname3.TextEnabled = True
        Me.txt_Checkname3.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname3.TextMaxLength = 32767
        Me.txt_Checkname3.TextMultiLine = False
        Me.txt_Checkname3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname3.UseSendTab = True
        '
        'txt_check8
        '
        Me.txt_check8.BackYesno = False
        Me.txt_check8.ButtonTitle = Nothing
        Me.txt_check8.Code = Nothing
        Me.txt_check8.Data = ""
        Me.txt_check8.DataDecimal = 0
        Me.txt_check8.DataLen = 0
        Me.txt_check8.DataValue = 0
        Me.txt_check8.FormatDecimal = 0
        Me.txt_check8.FormatValue = False
        Me.txt_check8.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check8.LableEnabled = True
        Me.txt_check8.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check8.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check8.LableTitle = "Check 8"
        Me.txt_check8.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check8.Location = New System.Drawing.Point(413, 125)
        Me.txt_check8.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check8.Name = "txt_check8"
        Me.txt_check8.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check8.Size = New System.Drawing.Size(205, 29)
        Me.txt_check8.TabIndex = 21
        Me.txt_check8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check8.TextBoxAutoComplete = False
        Me.txt_check8.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check8.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check8.TextEnabled = True
        Me.txt_check8.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check8.TextMaxLength = 32767
        Me.txt_check8.TextMultiLine = False
        Me.txt_check8.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check8.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check8.UseSendTab = True
        '
        'txt_Checkname8
        '
        Me.txt_Checkname8.BackYesno = False
        Me.txt_Checkname8.ButtonTitle = Nothing
        Me.txt_Checkname8.Code = Nothing
        Me.txt_Checkname8.Data = ""
        Me.txt_Checkname8.DataDecimal = 0
        Me.txt_Checkname8.DataLen = 0
        Me.txt_Checkname8.DataValue = 0
        Me.txt_Checkname8.FormatDecimal = 0
        Me.txt_Checkname8.FormatValue = False
        Me.txt_Checkname8.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname8.LableEnabled = True
        Me.txt_Checkname8.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname8.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname8.LableTitle = "CHECK 1"
        Me.txt_Checkname8.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname8.Location = New System.Drawing.Point(620, 125)
        Me.txt_Checkname8.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname8.Name = "txt_Checkname8"
        Me.txt_Checkname8.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname8.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname8.TabIndex = 22
        Me.txt_Checkname8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname8.TextBoxAutoComplete = False
        Me.txt_Checkname8.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname8.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname8.TextEnabled = True
        Me.txt_Checkname8.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname8.TextMaxLength = 32767
        Me.txt_Checkname8.TextMultiLine = False
        Me.txt_Checkname8.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname8.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname8.UseSendTab = True
        '
        'txt_check4
        '
        Me.txt_check4.BackYesno = False
        Me.txt_check4.ButtonTitle = Nothing
        Me.txt_check4.Code = Nothing
        Me.txt_check4.Data = ""
        Me.txt_check4.DataDecimal = 0
        Me.txt_check4.DataLen = 0
        Me.txt_check4.DataValue = 0
        Me.txt_check4.FormatDecimal = 0
        Me.txt_check4.FormatValue = False
        Me.txt_check4.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check4.LableEnabled = True
        Me.txt_check4.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check4.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check4.LableTitle = "Check 4"
        Me.txt_check4.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check4.Location = New System.Drawing.Point(1, 156)
        Me.txt_check4.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check4.Name = "txt_check4"
        Me.txt_check4.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check4.Size = New System.Drawing.Size(205, 29)
        Me.txt_check4.TabIndex = 13
        Me.txt_check4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check4.TextBoxAutoComplete = False
        Me.txt_check4.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check4.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check4.TextEnabled = True
        Me.txt_check4.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check4.TextMaxLength = 32767
        Me.txt_check4.TextMultiLine = False
        Me.txt_check4.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check4.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check4.UseSendTab = True
        '
        'txt_Checkname4
        '
        Me.txt_Checkname4.BackYesno = False
        Me.txt_Checkname4.ButtonTitle = Nothing
        Me.txt_Checkname4.Code = Nothing
        Me.txt_Checkname4.Data = ""
        Me.txt_Checkname4.DataDecimal = 0
        Me.txt_Checkname4.DataLen = 0
        Me.txt_Checkname4.DataValue = 0
        Me.txt_Checkname4.FormatDecimal = 0
        Me.txt_Checkname4.FormatValue = False
        Me.txt_Checkname4.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname4.LableEnabled = True
        Me.txt_Checkname4.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname4.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname4.LableTitle = "CHECK 1"
        Me.txt_Checkname4.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname4.Location = New System.Drawing.Point(208, 156)
        Me.txt_Checkname4.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname4.Name = "txt_Checkname4"
        Me.txt_Checkname4.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname4.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname4.TabIndex = 14
        Me.txt_Checkname4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname4.TextBoxAutoComplete = False
        Me.txt_Checkname4.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname4.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname4.TextEnabled = True
        Me.txt_Checkname4.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname4.TextMaxLength = 32767
        Me.txt_Checkname4.TextMultiLine = False
        Me.txt_Checkname4.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname4.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname4.UseSendTab = True
        '
        'txt_check9
        '
        Me.txt_check9.BackYesno = False
        Me.txt_check9.ButtonTitle = Nothing
        Me.txt_check9.Code = Nothing
        Me.txt_check9.Data = ""
        Me.txt_check9.DataDecimal = 0
        Me.txt_check9.DataLen = 0
        Me.txt_check9.DataValue = 0
        Me.txt_check9.FormatDecimal = 0
        Me.txt_check9.FormatValue = False
        Me.txt_check9.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check9.LableEnabled = True
        Me.txt_check9.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check9.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check9.LableTitle = "Check 9"
        Me.txt_check9.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check9.Location = New System.Drawing.Point(413, 156)
        Me.txt_check9.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check9.Name = "txt_check9"
        Me.txt_check9.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check9.Size = New System.Drawing.Size(205, 29)
        Me.txt_check9.TabIndex = 23
        Me.txt_check9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check9.TextBoxAutoComplete = False
        Me.txt_check9.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check9.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check9.TextEnabled = True
        Me.txt_check9.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check9.TextMaxLength = 32767
        Me.txt_check9.TextMultiLine = False
        Me.txt_check9.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check9.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check9.UseSendTab = True
        '
        'txt_Checkname9
        '
        Me.txt_Checkname9.BackYesno = False
        Me.txt_Checkname9.ButtonTitle = Nothing
        Me.txt_Checkname9.Code = Nothing
        Me.txt_Checkname9.Data = ""
        Me.txt_Checkname9.DataDecimal = 0
        Me.txt_Checkname9.DataLen = 0
        Me.txt_Checkname9.DataValue = 0
        Me.txt_Checkname9.FormatDecimal = 0
        Me.txt_Checkname9.FormatValue = False
        Me.txt_Checkname9.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname9.LableEnabled = True
        Me.txt_Checkname9.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname9.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname9.LableTitle = "CHECK 1"
        Me.txt_Checkname9.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname9.Location = New System.Drawing.Point(620, 156)
        Me.txt_Checkname9.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname9.Name = "txt_Checkname9"
        Me.txt_Checkname9.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname9.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname9.TabIndex = 24
        Me.txt_Checkname9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname9.TextBoxAutoComplete = False
        Me.txt_Checkname9.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname9.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname9.TextEnabled = True
        Me.txt_Checkname9.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname9.TextMaxLength = 32767
        Me.txt_Checkname9.TextMultiLine = False
        Me.txt_Checkname9.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname9.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname9.UseSendTab = True
        '
        'txt_check5
        '
        Me.txt_check5.BackYesno = False
        Me.txt_check5.ButtonTitle = Nothing
        Me.txt_check5.Code = Nothing
        Me.txt_check5.Data = ""
        Me.txt_check5.DataDecimal = 0
        Me.txt_check5.DataLen = 0
        Me.txt_check5.DataValue = 0
        Me.txt_check5.FormatDecimal = 0
        Me.txt_check5.FormatValue = False
        Me.txt_check5.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check5.LableEnabled = True
        Me.txt_check5.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check5.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check5.LableTitle = "Check 5"
        Me.txt_check5.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check5.Location = New System.Drawing.Point(1, 187)
        Me.txt_check5.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check5.Name = "txt_check5"
        Me.txt_check5.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check5.Size = New System.Drawing.Size(205, 29)
        Me.txt_check5.TabIndex = 15
        Me.txt_check5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check5.TextBoxAutoComplete = False
        Me.txt_check5.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check5.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check5.TextEnabled = True
        Me.txt_check5.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check5.TextMaxLength = 32767
        Me.txt_check5.TextMultiLine = False
        Me.txt_check5.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check5.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check5.UseSendTab = True
        '
        'txt_Checkname5
        '
        Me.txt_Checkname5.BackYesno = False
        Me.txt_Checkname5.ButtonTitle = Nothing
        Me.txt_Checkname5.Code = Nothing
        Me.txt_Checkname5.Data = ""
        Me.txt_Checkname5.DataDecimal = 0
        Me.txt_Checkname5.DataLen = 0
        Me.txt_Checkname5.DataValue = 0
        Me.txt_Checkname5.FormatDecimal = 0
        Me.txt_Checkname5.FormatValue = False
        Me.txt_Checkname5.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname5.LableEnabled = True
        Me.txt_Checkname5.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname5.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname5.LableTitle = "CHECK 1"
        Me.txt_Checkname5.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname5.Location = New System.Drawing.Point(208, 187)
        Me.txt_Checkname5.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname5.Name = "txt_Checkname5"
        Me.txt_Checkname5.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname5.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname5.TabIndex = 16
        Me.txt_Checkname5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname5.TextBoxAutoComplete = False
        Me.txt_Checkname5.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname5.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname5.TextEnabled = True
        Me.txt_Checkname5.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname5.TextMaxLength = 32767
        Me.txt_Checkname5.TextMultiLine = False
        Me.txt_Checkname5.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname5.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname5.UseSendTab = True
        '
        'txt_check10
        '
        Me.txt_check10.BackYesno = False
        Me.txt_check10.ButtonTitle = Nothing
        Me.txt_check10.Code = Nothing
        Me.txt_check10.Data = ""
        Me.txt_check10.DataDecimal = 0
        Me.txt_check10.DataLen = 0
        Me.txt_check10.DataValue = 0
        Me.txt_check10.FormatDecimal = 0
        Me.txt_check10.FormatValue = False
        Me.txt_check10.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_check10.LableEnabled = True
        Me.txt_check10.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check10.LableForeColor = System.Drawing.Color.Empty
        Me.txt_check10.LableTitle = "Check 10"
        Me.txt_check10.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_check10.Location = New System.Drawing.Point(413, 187)
        Me.txt_check10.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_check10.Name = "txt_check10"
        Me.txt_check10.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_check10.Size = New System.Drawing.Size(205, 29)
        Me.txt_check10.TabIndex = 25
        Me.txt_check10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_check10.TextBoxAutoComplete = False
        Me.txt_check10.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_check10.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_check10.TextEnabled = True
        Me.txt_check10.TextForeColor = System.Drawing.Color.Empty
        Me.txt_check10.TextMaxLength = 32767
        Me.txt_check10.TextMultiLine = False
        Me.txt_check10.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_check10.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_check10.UseSendTab = True
        '
        'txt_Checkname10
        '
        Me.txt_Checkname10.BackYesno = False
        Me.txt_Checkname10.ButtonTitle = Nothing
        Me.txt_Checkname10.Code = Nothing
        Me.txt_Checkname10.Data = ""
        Me.txt_Checkname10.DataDecimal = 0
        Me.txt_Checkname10.DataLen = 0
        Me.txt_Checkname10.DataValue = 0
        Me.txt_Checkname10.FormatDecimal = 0
        Me.txt_Checkname10.FormatValue = False
        Me.txt_Checkname10.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Checkname10.LableEnabled = True
        Me.txt_Checkname10.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname10.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname10.LableTitle = "CHECK 1"
        Me.txt_Checkname10.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Checkname10.Location = New System.Drawing.Point(620, 187)
        Me.txt_Checkname10.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Checkname10.Name = "txt_Checkname10"
        Me.txt_Checkname10.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Checkname10.Size = New System.Drawing.Size(203, 29)
        Me.txt_Checkname10.TabIndex = 26
        Me.txt_Checkname10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Checkname10.TextBoxAutoComplete = False
        Me.txt_Checkname10.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Checkname10.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Checkname10.TextEnabled = True
        Me.txt_Checkname10.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Checkname10.TextMaxLength = 32767
        Me.txt_Checkname10.TextMultiLine = False
        Me.txt_Checkname10.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Checkname10.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Checkname10.UseSendTab = True
        '
        'tit_Use
        '
        Me.tit_Use.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Use.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tit_Use.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tit_Use.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tit_Use.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tit_Use.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_Use.Code = ""
        Me.tit_Use.Data = ""
        Me.tit_Use.DTDec = 0
        Me.tit_Use.DTLen = 0
        Me.tit_Use.DTValue = 0
        Me.tit_Use.Location = New System.Drawing.Point(1, 218)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(138, 29)
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
        Me.chk_UseCheck2.Size = New System.Drawing.Size(41, 18)
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
        Me.chk_UseCheck1.Size = New System.Drawing.Size(45, 18)
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
        Me.txt_DisplaySeq.Data = ""
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
        Me.txt_remark.Data = ""
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
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_AccountCode)
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_BankCode)
        Me.FlowLayoutPanel3.Data = ""
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(9, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(827, 68)
        Me.FlowLayoutPanel3.TabIndex = 41
        Me.FlowLayoutPanel3.Tag = ""
        '
        'txt_AccountCode
        '
        Me.txt_AccountCode.BackYesno = False
        Me.txt_AccountCode.ButtonTitle = Nothing
        Me.txt_AccountCode.Code = Nothing
        Me.txt_AccountCode.Data = ""
        Me.txt_AccountCode.DataDecimal = 0
        Me.txt_AccountCode.DataLen = 0
        Me.txt_AccountCode.DataValue = 0
        Me.txt_AccountCode.FormatDecimal = 0
        Me.txt_AccountCode.FormatValue = False
        Me.txt_AccountCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_AccountCode.LableEnabled = True
        Me.txt_AccountCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccountCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_AccountCode.LableTitle = "Account Code"
        Me.txt_AccountCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_AccountCode.Location = New System.Drawing.Point(2, 33)
        Me.txt_AccountCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_AccountCode.Name = "txt_AccountCode"
        Me.txt_AccountCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccountCode.Size = New System.Drawing.Size(409, 29)
        Me.txt_AccountCode.TabIndex = 3
        Me.txt_AccountCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccountCode.TextBoxAutoComplete = False
        Me.txt_AccountCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccountCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccountCode.TextEnabled = True
        Me.txt_AccountCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_AccountCode.TextMaxLength = 32767
        Me.txt_AccountCode.TextMultiLine = False
        Me.txt_AccountCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccountCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccountCode.UseSendTab = True
        '
        'txt_BankCode
        '
        Me.txt_BankCode.BackYesno = False
        Me.txt_BankCode.ButtonTitle = Nothing
        Me.txt_BankCode.Code = Nothing
        Me.txt_BankCode.Data = ""
        Me.txt_BankCode.DataDecimal = 0
        Me.txt_BankCode.DataLen = 0
        Me.txt_BankCode.DataValue = 0
        Me.txt_BankCode.FormatDecimal = 0
        Me.txt_BankCode.FormatValue = False
        Me.txt_BankCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_BankCode.LableEnabled = True
        Me.txt_BankCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_BankCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_BankCode.LableTitle = "Bank Code"
        Me.txt_BankCode.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_BankCode.Location = New System.Drawing.Point(2, 2)
        Me.txt_BankCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_BankCode.Name = "txt_BankCode"
        Me.txt_BankCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BankCode.Size = New System.Drawing.Size(204, 29)
        Me.txt_BankCode.TabIndex = 2
        Me.txt_BankCode.TabStop = False
        Me.txt_BankCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BankCode.TextBoxAutoComplete = False
        Me.txt_BankCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_BankCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_BankCode.TextEnabled = False
        Me.txt_BankCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_BankCode.TextMaxLength = 32767
        Me.txt_BankCode.TextMultiLine = False
        Me.txt_BankCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BankCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BankCode.UseSendTab = True
        '
        'cmd_AttachID
        '
        Me.cmd_AttachID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_AttachID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_AttachID.Appearance.Options.UseFont = True
        Me.cmd_AttachID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_AttachID.Code = Nothing
        Me.cmd_AttachID.Data = Nothing
        Me.cmd_AttachID.Image = CType(resources.GetObject("cmd_AttachID.Image"), System.Drawing.Image)
        Me.cmd_AttachID.ImageAlign = 16
        Me.cmd_AttachID.Location = New System.Drawing.Point(345, 2)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 14
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
        '
        'ISUD7173A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(849, 481)
        Me.Controls.Add(Me.frm_Condition)
        Me.KeyPreview = True
        Me.Name = "ISUD7173A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BANK CODE PROCESSING (ISUD7173A)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bloack2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.FlowLayoutPanel3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txt_BankCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_NameSimply As PSMGlobal.SelectLabelText
    Friend WithEvents txt_BasicName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DisplaySeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname10 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check10 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname9 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check9 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname8 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check8 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname7 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check7 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname6 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check6 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname5 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check5 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname4 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check4 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname3 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check3 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Checkname1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_check1 As PSMGlobal.SelectLabelText
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel3 As PSMGlobal.PeacePanel
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chk_UseCheck2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_UseCheck1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_AccountCode As PSMGlobal.SelectLabelText
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
End Class
