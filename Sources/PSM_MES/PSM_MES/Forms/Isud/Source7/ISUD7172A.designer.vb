<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7172A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7172A))
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.Block1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_AccCode = New PSMGlobal.SelectLabelText()
        Me.txt_AccSeq = New PSMGlobal.SelectLabelText()
        Me.txt_AccSel = New PSMGlobal.SelectLabelText()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_BasicName = New PSMGlobal.SelectLabelText()
        Me.txt_ForeignName1 = New PSMGlobal.SelectLabelText()
        Me.txt_NameSimply = New PSMGlobal.SelectLabelText()
        Me.txt_ForeignName2 = New PSMGlobal.SelectLabelText()
        Me.check1 = New PSMGlobal.SelectLabelText()
        Me.Checkname1 = New PSMGlobal.SelectLabelText()
        Me.check6 = New PSMGlobal.SelectLabelText()
        Me.Checkname6 = New PSMGlobal.SelectLabelText()
        Me.check2 = New PSMGlobal.SelectLabelText()
        Me.Checkname2 = New PSMGlobal.SelectLabelText()
        Me.check7 = New PSMGlobal.SelectLabelText()
        Me.Checkname7 = New PSMGlobal.SelectLabelText()
        Me.check3 = New PSMGlobal.SelectLabelText()
        Me.Checkname3 = New PSMGlobal.SelectLabelText()
        Me.check8 = New PSMGlobal.SelectLabelText()
        Me.Checkname8 = New PSMGlobal.SelectLabelText()
        Me.check4 = New PSMGlobal.SelectLabelText()
        Me.Checkname4 = New PSMGlobal.SelectLabelText()
        Me.check9 = New PSMGlobal.SelectLabelText()
        Me.Checkname9 = New PSMGlobal.SelectLabelText()
        Me.check5 = New PSMGlobal.SelectLabelText()
        Me.Checkname5 = New PSMGlobal.SelectLabelText()
        Me.check10 = New PSMGlobal.SelectLabelText()
        Me.Checkname10 = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.UseCheck2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.UseCheck1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.DisplaySeq = New PSMGlobal.SelectLabelText()
        Me.txt_remark = New PSMGlobal.SelectLabelText()
        Me.txt_Selremark = New PSMGlobal.SelectLabelText()
        Me.FlowLayoutPanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_DevelopmentCode = New PSMGlobal.SelectLabelText()
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Block1.SuspendLayout()
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
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Controls.Add(Me.Frame4)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Controls.Add(Me.FlowLayoutPanel3)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(849, 576)
        Me.frm_Condition.TabIndex = 0
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.txt_AccCode)
        Me.Block1.Controls.Add(Me.txt_AccSeq)
        Me.Block1.Controls.Add(Me.txt_AccSel)
        Me.Block1.Data = ""
        Me.Block1.Location = New System.Drawing.Point(8, 3)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(828, 37)
        Me.Block1.TabIndex = 39
        '
        'txt_AccCode
        '
        Me.txt_AccCode.BackYesno = False
        Me.txt_AccCode.ButtonTitle = Nothing
        Me.txt_AccCode.Code = Nothing
        Me.txt_AccCode.Data = ""
        Me.txt_AccCode.DataDecimal = 0
        Me.txt_AccCode.DataLen = 0
        Me.txt_AccCode.DataValue = 0
        Me.txt_AccCode.FormatDecimal = 0
        Me.txt_AccCode.FormatValue = False
        Me.txt_AccCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_AccCode.LableEnabled = True
        Me.txt_AccCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccCode.LableForeColor = System.Drawing.Color.Red
        Me.txt_AccCode.LableTitle = "Acc Code"
        Me.txt_AccCode.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_AccCode.Location = New System.Drawing.Point(2, 2)
        Me.txt_AccCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_AccCode.Name = "txt_AccCode"
        Me.txt_AccCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccCode.Size = New System.Drawing.Size(204, 29)
        Me.txt_AccCode.TabIndex = 0
        Me.txt_AccCode.TabStop = False
        Me.txt_AccCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccCode.TextBoxAutoComplete = False
        Me.txt_AccCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccCode.TextEnabled = False
        Me.txt_AccCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_AccCode.TextMaxLength = 32767
        Me.txt_AccCode.TextMultiLine = False
        Me.txt_AccCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccCode.UseSendTab = True
        '
        'txt_AccSeq
        '
        Me.txt_AccSeq.BackYesno = False
        Me.txt_AccSeq.ButtonTitle = Nothing
        Me.txt_AccSeq.Code = Nothing
        Me.txt_AccSeq.Data = ""
        Me.txt_AccSeq.DataDecimal = 0
        Me.txt_AccSeq.DataLen = 0
        Me.txt_AccSeq.DataValue = 0
        Me.txt_AccSeq.FormatDecimal = 0
        Me.txt_AccSeq.FormatValue = False
        Me.txt_AccSeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_AccSeq.LableEnabled = True
        Me.txt_AccSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_AccSeq.LableForeColor = System.Drawing.Color.Blue
        Me.txt_AccSeq.LableTitle = "Acc Seq"
        Me.txt_AccSeq.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_AccSeq.Location = New System.Drawing.Point(210, 2)
        Me.txt_AccSeq.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_AccSeq.Name = "txt_AccSeq"
        Me.txt_AccSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccSeq.Size = New System.Drawing.Size(204, 29)
        Me.txt_AccSeq.TabIndex = 1
        Me.txt_AccSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccSeq.TextBoxAutoComplete = False
        Me.txt_AccSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccSeq.TextEnabled = True
        Me.txt_AccSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_AccSeq.TextMaxLength = 32767
        Me.txt_AccSeq.TextMultiLine = False
        Me.txt_AccSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccSeq.UseSendTab = True
        '
        'txt_AccSel
        '
        Me.txt_AccSel.BackYesno = False
        Me.txt_AccSel.ButtonTitle = Nothing
        Me.txt_AccSel.Code = Nothing
        Me.txt_AccSel.Data = ""
        Me.txt_AccSel.DataDecimal = 0
        Me.txt_AccSel.DataLen = 0
        Me.txt_AccSel.DataValue = 0
        Me.txt_AccSel.FormatDecimal = 0
        Me.txt_AccSel.FormatValue = False
        Me.txt_AccSel.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_AccSel.LableEnabled = True
        Me.txt_AccSel.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_AccSel.LableForeColor = System.Drawing.Color.Blue
        Me.txt_AccSel.LableTitle = "Acc Sel"
        Me.txt_AccSel.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_AccSel.Location = New System.Drawing.Point(418, 2)
        Me.txt_AccSel.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_AccSel.Name = "txt_AccSel"
        Me.txt_AccSel.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccSel.Size = New System.Drawing.Size(204, 29)
        Me.txt_AccSel.TabIndex = 2
        Me.txt_AccSel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccSel.TextBoxAutoComplete = False
        Me.txt_AccSel.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccSel.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccSel.TextEnabled = True
        Me.txt_AccSel.TextForeColor = System.Drawing.Color.Empty
        Me.txt_AccSel.TextMaxLength = 32767
        Me.txt_AccSel.TextMultiLine = False
        Me.txt_AccSel.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccSel.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccSel.UseSendTab = True
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
        Me.Frame4.Location = New System.Drawing.Point(9, 533)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(828, 39)
        Me.Frame4.TabIndex = 0
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
        Me.Bloack2.Controls.Add(Me.check1)
        Me.Bloack2.Controls.Add(Me.Checkname1)
        Me.Bloack2.Controls.Add(Me.check6)
        Me.Bloack2.Controls.Add(Me.Checkname6)
        Me.Bloack2.Controls.Add(Me.check2)
        Me.Bloack2.Controls.Add(Me.Checkname2)
        Me.Bloack2.Controls.Add(Me.check7)
        Me.Bloack2.Controls.Add(Me.Checkname7)
        Me.Bloack2.Controls.Add(Me.check3)
        Me.Bloack2.Controls.Add(Me.Checkname3)
        Me.Bloack2.Controls.Add(Me.check8)
        Me.Bloack2.Controls.Add(Me.Checkname8)
        Me.Bloack2.Controls.Add(Me.check4)
        Me.Bloack2.Controls.Add(Me.Checkname4)
        Me.Bloack2.Controls.Add(Me.check9)
        Me.Bloack2.Controls.Add(Me.Checkname9)
        Me.Bloack2.Controls.Add(Me.check5)
        Me.Bloack2.Controls.Add(Me.Checkname5)
        Me.Bloack2.Controls.Add(Me.check10)
        Me.Bloack2.Controls.Add(Me.Checkname10)
        Me.Bloack2.Controls.Add(Me.tit_Use)
        Me.Bloack2.Controls.Add(Me.Panel5)
        Me.Bloack2.Controls.Add(Me.DisplaySeq)
        Me.Bloack2.Controls.Add(Me.txt_remark)
        Me.Bloack2.Controls.Add(Me.txt_Selremark)
        Me.Bloack2.Data = ""
        Me.Bloack2.Location = New System.Drawing.Point(9, 77)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(827, 454)
        Me.Bloack2.TabIndex = 40
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
        'check1
        '
        Me.check1.BackYesno = False
        Me.check1.ButtonTitle = Nothing
        Me.check1.Code = Nothing
        Me.check1.Data = ""
        Me.check1.DataDecimal = 0
        Me.check1.DataLen = 0
        Me.check1.DataValue = 0
        Me.check1.FormatDecimal = 0
        Me.check1.FormatValue = False
        Me.check1.LableBackColor = System.Drawing.SystemColors.Control
        Me.check1.LableEnabled = True
        Me.check1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check1.LableForeColor = System.Drawing.Color.Empty
        Me.check1.LableTitle = "Check 1"
        Me.check1.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check1.Location = New System.Drawing.Point(1, 63)
        Me.check1.Margin = New System.Windows.Forms.Padding(1)
        Me.check1.Name = "check1"
        Me.check1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check1.Size = New System.Drawing.Size(205, 29)
        Me.check1.TabIndex = 7
        Me.check1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check1.TextBoxAutoComplete = False
        Me.check1.TextboxBackColor = System.Drawing.Color.Empty
        Me.check1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check1.TextEnabled = True
        Me.check1.TextForeColor = System.Drawing.Color.Empty
        Me.check1.TextMaxLength = 32767
        Me.check1.TextMultiLine = False
        Me.check1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check1.UseSendTab = True
        '
        'Checkname1
        '
        Me.Checkname1.BackYesno = False
        Me.Checkname1.ButtonTitle = Nothing
        Me.Checkname1.Code = Nothing
        Me.Checkname1.Data = ""
        Me.Checkname1.DataDecimal = 0
        Me.Checkname1.DataLen = 0
        Me.Checkname1.DataValue = 0
        Me.Checkname1.FormatDecimal = 0
        Me.Checkname1.FormatValue = False
        Me.Checkname1.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname1.LableEnabled = True
        Me.Checkname1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname1.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname1.LableTitle = "CHECK 1"
        Me.Checkname1.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname1.Location = New System.Drawing.Point(208, 63)
        Me.Checkname1.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname1.Name = "Checkname1"
        Me.Checkname1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname1.Size = New System.Drawing.Size(203, 29)
        Me.Checkname1.TabIndex = 8
        Me.Checkname1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname1.TextBoxAutoComplete = False
        Me.Checkname1.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname1.TextEnabled = True
        Me.Checkname1.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname1.TextMaxLength = 32767
        Me.Checkname1.TextMultiLine = False
        Me.Checkname1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname1.UseSendTab = True
        '
        'check6
        '
        Me.check6.BackYesno = False
        Me.check6.ButtonTitle = Nothing
        Me.check6.Code = Nothing
        Me.check6.Data = ""
        Me.check6.DataDecimal = 0
        Me.check6.DataLen = 0
        Me.check6.DataValue = 0
        Me.check6.FormatDecimal = 0
        Me.check6.FormatValue = False
        Me.check6.LableBackColor = System.Drawing.SystemColors.Control
        Me.check6.LableEnabled = True
        Me.check6.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check6.LableForeColor = System.Drawing.Color.Empty
        Me.check6.LableTitle = "Check 6"
        Me.check6.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check6.Location = New System.Drawing.Point(413, 63)
        Me.check6.Margin = New System.Windows.Forms.Padding(1)
        Me.check6.Name = "check6"
        Me.check6.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check6.Size = New System.Drawing.Size(205, 29)
        Me.check6.TabIndex = 17
        Me.check6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check6.TextBoxAutoComplete = False
        Me.check6.TextboxBackColor = System.Drawing.Color.Empty
        Me.check6.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check6.TextEnabled = True
        Me.check6.TextForeColor = System.Drawing.Color.Empty
        Me.check6.TextMaxLength = 32767
        Me.check6.TextMultiLine = False
        Me.check6.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check6.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check6.UseSendTab = True
        '
        'Checkname6
        '
        Me.Checkname6.BackYesno = False
        Me.Checkname6.ButtonTitle = Nothing
        Me.Checkname6.Code = Nothing
        Me.Checkname6.Data = ""
        Me.Checkname6.DataDecimal = 0
        Me.Checkname6.DataLen = 0
        Me.Checkname6.DataValue = 0
        Me.Checkname6.FormatDecimal = 0
        Me.Checkname6.FormatValue = False
        Me.Checkname6.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname6.LableEnabled = True
        Me.Checkname6.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname6.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname6.LableTitle = "CHECK 1"
        Me.Checkname6.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname6.Location = New System.Drawing.Point(620, 63)
        Me.Checkname6.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname6.Name = "Checkname6"
        Me.Checkname6.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname6.Size = New System.Drawing.Size(203, 29)
        Me.Checkname6.TabIndex = 18
        Me.Checkname6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname6.TextBoxAutoComplete = False
        Me.Checkname6.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname6.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname6.TextEnabled = True
        Me.Checkname6.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname6.TextMaxLength = 32767
        Me.Checkname6.TextMultiLine = False
        Me.Checkname6.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname6.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname6.UseSendTab = True
        '
        'check2
        '
        Me.check2.BackYesno = False
        Me.check2.ButtonTitle = Nothing
        Me.check2.Code = Nothing
        Me.check2.Data = ""
        Me.check2.DataDecimal = 0
        Me.check2.DataLen = 0
        Me.check2.DataValue = 0
        Me.check2.FormatDecimal = 0
        Me.check2.FormatValue = False
        Me.check2.LableBackColor = System.Drawing.SystemColors.Control
        Me.check2.LableEnabled = True
        Me.check2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check2.LableForeColor = System.Drawing.Color.Empty
        Me.check2.LableTitle = "Check 2"
        Me.check2.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check2.Location = New System.Drawing.Point(1, 94)
        Me.check2.Margin = New System.Windows.Forms.Padding(1)
        Me.check2.Name = "check2"
        Me.check2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check2.Size = New System.Drawing.Size(205, 29)
        Me.check2.TabIndex = 9
        Me.check2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check2.TextBoxAutoComplete = False
        Me.check2.TextboxBackColor = System.Drawing.Color.Empty
        Me.check2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check2.TextEnabled = True
        Me.check2.TextForeColor = System.Drawing.Color.Empty
        Me.check2.TextMaxLength = 32767
        Me.check2.TextMultiLine = False
        Me.check2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check2.UseSendTab = True
        '
        'Checkname2
        '
        Me.Checkname2.BackYesno = False
        Me.Checkname2.ButtonTitle = Nothing
        Me.Checkname2.Code = Nothing
        Me.Checkname2.Data = ""
        Me.Checkname2.DataDecimal = 0
        Me.Checkname2.DataLen = 0
        Me.Checkname2.DataValue = 0
        Me.Checkname2.FormatDecimal = 0
        Me.Checkname2.FormatValue = False
        Me.Checkname2.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname2.LableEnabled = True
        Me.Checkname2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname2.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname2.LableTitle = "CHECK 1"
        Me.Checkname2.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname2.Location = New System.Drawing.Point(208, 94)
        Me.Checkname2.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname2.Name = "Checkname2"
        Me.Checkname2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname2.Size = New System.Drawing.Size(203, 29)
        Me.Checkname2.TabIndex = 10
        Me.Checkname2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname2.TextBoxAutoComplete = False
        Me.Checkname2.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname2.TextEnabled = True
        Me.Checkname2.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname2.TextMaxLength = 32767
        Me.Checkname2.TextMultiLine = False
        Me.Checkname2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname2.UseSendTab = True
        '
        'check7
        '
        Me.check7.BackYesno = False
        Me.check7.ButtonTitle = Nothing
        Me.check7.Code = Nothing
        Me.check7.Data = ""
        Me.check7.DataDecimal = 0
        Me.check7.DataLen = 0
        Me.check7.DataValue = 0
        Me.check7.FormatDecimal = 0
        Me.check7.FormatValue = False
        Me.check7.LableBackColor = System.Drawing.SystemColors.Control
        Me.check7.LableEnabled = True
        Me.check7.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check7.LableForeColor = System.Drawing.Color.Empty
        Me.check7.LableTitle = "Check 7"
        Me.check7.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check7.Location = New System.Drawing.Point(413, 94)
        Me.check7.Margin = New System.Windows.Forms.Padding(1)
        Me.check7.Name = "check7"
        Me.check7.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check7.Size = New System.Drawing.Size(205, 29)
        Me.check7.TabIndex = 19
        Me.check7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check7.TextBoxAutoComplete = False
        Me.check7.TextboxBackColor = System.Drawing.Color.Empty
        Me.check7.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check7.TextEnabled = True
        Me.check7.TextForeColor = System.Drawing.Color.Empty
        Me.check7.TextMaxLength = 32767
        Me.check7.TextMultiLine = False
        Me.check7.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check7.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check7.UseSendTab = True
        '
        'Checkname7
        '
        Me.Checkname7.BackYesno = False
        Me.Checkname7.ButtonTitle = Nothing
        Me.Checkname7.Code = Nothing
        Me.Checkname7.Data = ""
        Me.Checkname7.DataDecimal = 0
        Me.Checkname7.DataLen = 0
        Me.Checkname7.DataValue = 0
        Me.Checkname7.FormatDecimal = 0
        Me.Checkname7.FormatValue = False
        Me.Checkname7.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname7.LableEnabled = True
        Me.Checkname7.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname7.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname7.LableTitle = "CHECK 1"
        Me.Checkname7.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname7.Location = New System.Drawing.Point(620, 94)
        Me.Checkname7.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname7.Name = "Checkname7"
        Me.Checkname7.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname7.Size = New System.Drawing.Size(203, 29)
        Me.Checkname7.TabIndex = 20
        Me.Checkname7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname7.TextBoxAutoComplete = False
        Me.Checkname7.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname7.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname7.TextEnabled = True
        Me.Checkname7.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname7.TextMaxLength = 32767
        Me.Checkname7.TextMultiLine = False
        Me.Checkname7.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname7.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname7.UseSendTab = True
        '
        'check3
        '
        Me.check3.BackYesno = False
        Me.check3.ButtonTitle = Nothing
        Me.check3.Code = Nothing
        Me.check3.Data = ""
        Me.check3.DataDecimal = 0
        Me.check3.DataLen = 0
        Me.check3.DataValue = 0
        Me.check3.FormatDecimal = 0
        Me.check3.FormatValue = False
        Me.check3.LableBackColor = System.Drawing.SystemColors.Control
        Me.check3.LableEnabled = True
        Me.check3.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check3.LableForeColor = System.Drawing.Color.Empty
        Me.check3.LableTitle = "Check 3"
        Me.check3.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check3.Location = New System.Drawing.Point(1, 125)
        Me.check3.Margin = New System.Windows.Forms.Padding(1)
        Me.check3.Name = "check3"
        Me.check3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check3.Size = New System.Drawing.Size(205, 29)
        Me.check3.TabIndex = 11
        Me.check3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check3.TextBoxAutoComplete = False
        Me.check3.TextboxBackColor = System.Drawing.Color.Empty
        Me.check3.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check3.TextEnabled = True
        Me.check3.TextForeColor = System.Drawing.Color.Empty
        Me.check3.TextMaxLength = 32767
        Me.check3.TextMultiLine = False
        Me.check3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check3.UseSendTab = True
        '
        'Checkname3
        '
        Me.Checkname3.BackYesno = False
        Me.Checkname3.ButtonTitle = Nothing
        Me.Checkname3.Code = Nothing
        Me.Checkname3.Data = ""
        Me.Checkname3.DataDecimal = 0
        Me.Checkname3.DataLen = 0
        Me.Checkname3.DataValue = 0
        Me.Checkname3.FormatDecimal = 0
        Me.Checkname3.FormatValue = False
        Me.Checkname3.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname3.LableEnabled = True
        Me.Checkname3.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname3.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname3.LableTitle = "CHECK 1"
        Me.Checkname3.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname3.Location = New System.Drawing.Point(208, 125)
        Me.Checkname3.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname3.Name = "Checkname3"
        Me.Checkname3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname3.Size = New System.Drawing.Size(203, 29)
        Me.Checkname3.TabIndex = 12
        Me.Checkname3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname3.TextBoxAutoComplete = False
        Me.Checkname3.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname3.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname3.TextEnabled = True
        Me.Checkname3.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname3.TextMaxLength = 32767
        Me.Checkname3.TextMultiLine = False
        Me.Checkname3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname3.UseSendTab = True
        '
        'check8
        '
        Me.check8.BackYesno = False
        Me.check8.ButtonTitle = Nothing
        Me.check8.Code = Nothing
        Me.check8.Data = ""
        Me.check8.DataDecimal = 0
        Me.check8.DataLen = 0
        Me.check8.DataValue = 0
        Me.check8.FormatDecimal = 0
        Me.check8.FormatValue = False
        Me.check8.LableBackColor = System.Drawing.SystemColors.Control
        Me.check8.LableEnabled = True
        Me.check8.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check8.LableForeColor = System.Drawing.Color.Empty
        Me.check8.LableTitle = "Check 8"
        Me.check8.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check8.Location = New System.Drawing.Point(413, 125)
        Me.check8.Margin = New System.Windows.Forms.Padding(1)
        Me.check8.Name = "check8"
        Me.check8.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check8.Size = New System.Drawing.Size(205, 29)
        Me.check8.TabIndex = 21
        Me.check8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check8.TextBoxAutoComplete = False
        Me.check8.TextboxBackColor = System.Drawing.Color.Empty
        Me.check8.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check8.TextEnabled = True
        Me.check8.TextForeColor = System.Drawing.Color.Empty
        Me.check8.TextMaxLength = 32767
        Me.check8.TextMultiLine = False
        Me.check8.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check8.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check8.UseSendTab = True
        '
        'Checkname8
        '
        Me.Checkname8.BackYesno = False
        Me.Checkname8.ButtonTitle = Nothing
        Me.Checkname8.Code = Nothing
        Me.Checkname8.Data = ""
        Me.Checkname8.DataDecimal = 0
        Me.Checkname8.DataLen = 0
        Me.Checkname8.DataValue = 0
        Me.Checkname8.FormatDecimal = 0
        Me.Checkname8.FormatValue = False
        Me.Checkname8.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname8.LableEnabled = True
        Me.Checkname8.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname8.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname8.LableTitle = "CHECK 1"
        Me.Checkname8.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname8.Location = New System.Drawing.Point(620, 125)
        Me.Checkname8.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname8.Name = "Checkname8"
        Me.Checkname8.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname8.Size = New System.Drawing.Size(203, 29)
        Me.Checkname8.TabIndex = 22
        Me.Checkname8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname8.TextBoxAutoComplete = False
        Me.Checkname8.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname8.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname8.TextEnabled = True
        Me.Checkname8.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname8.TextMaxLength = 32767
        Me.Checkname8.TextMultiLine = False
        Me.Checkname8.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname8.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname8.UseSendTab = True
        '
        'check4
        '
        Me.check4.BackYesno = False
        Me.check4.ButtonTitle = Nothing
        Me.check4.Code = Nothing
        Me.check4.Data = ""
        Me.check4.DataDecimal = 0
        Me.check4.DataLen = 0
        Me.check4.DataValue = 0
        Me.check4.FormatDecimal = 0
        Me.check4.FormatValue = False
        Me.check4.LableBackColor = System.Drawing.SystemColors.Control
        Me.check4.LableEnabled = True
        Me.check4.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check4.LableForeColor = System.Drawing.Color.Empty
        Me.check4.LableTitle = "Check 4"
        Me.check4.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check4.Location = New System.Drawing.Point(1, 156)
        Me.check4.Margin = New System.Windows.Forms.Padding(1)
        Me.check4.Name = "check4"
        Me.check4.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check4.Size = New System.Drawing.Size(205, 29)
        Me.check4.TabIndex = 13
        Me.check4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check4.TextBoxAutoComplete = False
        Me.check4.TextboxBackColor = System.Drawing.Color.Empty
        Me.check4.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check4.TextEnabled = True
        Me.check4.TextForeColor = System.Drawing.Color.Empty
        Me.check4.TextMaxLength = 32767
        Me.check4.TextMultiLine = False
        Me.check4.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check4.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check4.UseSendTab = True
        '
        'Checkname4
        '
        Me.Checkname4.BackYesno = False
        Me.Checkname4.ButtonTitle = Nothing
        Me.Checkname4.Code = Nothing
        Me.Checkname4.Data = ""
        Me.Checkname4.DataDecimal = 0
        Me.Checkname4.DataLen = 0
        Me.Checkname4.DataValue = 0
        Me.Checkname4.FormatDecimal = 0
        Me.Checkname4.FormatValue = False
        Me.Checkname4.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname4.LableEnabled = True
        Me.Checkname4.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname4.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname4.LableTitle = "CHECK 1"
        Me.Checkname4.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname4.Location = New System.Drawing.Point(208, 156)
        Me.Checkname4.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname4.Name = "Checkname4"
        Me.Checkname4.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname4.Size = New System.Drawing.Size(203, 29)
        Me.Checkname4.TabIndex = 14
        Me.Checkname4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname4.TextBoxAutoComplete = False
        Me.Checkname4.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname4.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname4.TextEnabled = True
        Me.Checkname4.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname4.TextMaxLength = 32767
        Me.Checkname4.TextMultiLine = False
        Me.Checkname4.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname4.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname4.UseSendTab = True
        '
        'check9
        '
        Me.check9.BackYesno = False
        Me.check9.ButtonTitle = Nothing
        Me.check9.Code = Nothing
        Me.check9.Data = ""
        Me.check9.DataDecimal = 0
        Me.check9.DataLen = 0
        Me.check9.DataValue = 0
        Me.check9.FormatDecimal = 0
        Me.check9.FormatValue = False
        Me.check9.LableBackColor = System.Drawing.SystemColors.Control
        Me.check9.LableEnabled = True
        Me.check9.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check9.LableForeColor = System.Drawing.Color.Empty
        Me.check9.LableTitle = "Check 9"
        Me.check9.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check9.Location = New System.Drawing.Point(413, 156)
        Me.check9.Margin = New System.Windows.Forms.Padding(1)
        Me.check9.Name = "check9"
        Me.check9.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check9.Size = New System.Drawing.Size(205, 29)
        Me.check9.TabIndex = 23
        Me.check9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check9.TextBoxAutoComplete = False
        Me.check9.TextboxBackColor = System.Drawing.Color.Empty
        Me.check9.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check9.TextEnabled = True
        Me.check9.TextForeColor = System.Drawing.Color.Empty
        Me.check9.TextMaxLength = 32767
        Me.check9.TextMultiLine = False
        Me.check9.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check9.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check9.UseSendTab = True
        '
        'Checkname9
        '
        Me.Checkname9.BackYesno = False
        Me.Checkname9.ButtonTitle = Nothing
        Me.Checkname9.Code = Nothing
        Me.Checkname9.Data = ""
        Me.Checkname9.DataDecimal = 0
        Me.Checkname9.DataLen = 0
        Me.Checkname9.DataValue = 0
        Me.Checkname9.FormatDecimal = 0
        Me.Checkname9.FormatValue = False
        Me.Checkname9.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname9.LableEnabled = True
        Me.Checkname9.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname9.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname9.LableTitle = "CHECK 1"
        Me.Checkname9.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname9.Location = New System.Drawing.Point(620, 156)
        Me.Checkname9.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname9.Name = "Checkname9"
        Me.Checkname9.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname9.Size = New System.Drawing.Size(203, 29)
        Me.Checkname9.TabIndex = 24
        Me.Checkname9.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname9.TextBoxAutoComplete = False
        Me.Checkname9.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname9.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname9.TextEnabled = True
        Me.Checkname9.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname9.TextMaxLength = 32767
        Me.Checkname9.TextMultiLine = False
        Me.Checkname9.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname9.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname9.UseSendTab = True
        '
        'check5
        '
        Me.check5.BackYesno = False
        Me.check5.ButtonTitle = Nothing
        Me.check5.Code = Nothing
        Me.check5.Data = ""
        Me.check5.DataDecimal = 0
        Me.check5.DataLen = 0
        Me.check5.DataValue = 0
        Me.check5.FormatDecimal = 0
        Me.check5.FormatValue = False
        Me.check5.LableBackColor = System.Drawing.SystemColors.Control
        Me.check5.LableEnabled = True
        Me.check5.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check5.LableForeColor = System.Drawing.Color.Empty
        Me.check5.LableTitle = "Check 5"
        Me.check5.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check5.Location = New System.Drawing.Point(1, 187)
        Me.check5.Margin = New System.Windows.Forms.Padding(1)
        Me.check5.Name = "check5"
        Me.check5.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check5.Size = New System.Drawing.Size(205, 29)
        Me.check5.TabIndex = 15
        Me.check5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check5.TextBoxAutoComplete = False
        Me.check5.TextboxBackColor = System.Drawing.Color.Empty
        Me.check5.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check5.TextEnabled = True
        Me.check5.TextForeColor = System.Drawing.Color.Empty
        Me.check5.TextMaxLength = 32767
        Me.check5.TextMultiLine = False
        Me.check5.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check5.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check5.UseSendTab = True
        '
        'Checkname5
        '
        Me.Checkname5.BackYesno = False
        Me.Checkname5.ButtonTitle = Nothing
        Me.Checkname5.Code = Nothing
        Me.Checkname5.Data = ""
        Me.Checkname5.DataDecimal = 0
        Me.Checkname5.DataLen = 0
        Me.Checkname5.DataValue = 0
        Me.Checkname5.FormatDecimal = 0
        Me.Checkname5.FormatValue = False
        Me.Checkname5.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname5.LableEnabled = True
        Me.Checkname5.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname5.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname5.LableTitle = "CHECK 1"
        Me.Checkname5.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname5.Location = New System.Drawing.Point(208, 187)
        Me.Checkname5.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname5.Name = "Checkname5"
        Me.Checkname5.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname5.Size = New System.Drawing.Size(203, 29)
        Me.Checkname5.TabIndex = 16
        Me.Checkname5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname5.TextBoxAutoComplete = False
        Me.Checkname5.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname5.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname5.TextEnabled = True
        Me.Checkname5.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname5.TextMaxLength = 32767
        Me.Checkname5.TextMultiLine = False
        Me.Checkname5.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname5.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname5.UseSendTab = True
        '
        'check10
        '
        Me.check10.BackYesno = False
        Me.check10.ButtonTitle = Nothing
        Me.check10.Code = Nothing
        Me.check10.Data = ""
        Me.check10.DataDecimal = 0
        Me.check10.DataLen = 0
        Me.check10.DataValue = 0
        Me.check10.FormatDecimal = 0
        Me.check10.FormatValue = False
        Me.check10.LableBackColor = System.Drawing.SystemColors.Control
        Me.check10.LableEnabled = True
        Me.check10.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check10.LableForeColor = System.Drawing.Color.Empty
        Me.check10.LableTitle = "Check 10"
        Me.check10.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.check10.Location = New System.Drawing.Point(413, 187)
        Me.check10.Margin = New System.Windows.Forms.Padding(1)
        Me.check10.Name = "check10"
        Me.check10.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.check10.Size = New System.Drawing.Size(205, 29)
        Me.check10.TabIndex = 25
        Me.check10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.check10.TextBoxAutoComplete = False
        Me.check10.TextboxBackColor = System.Drawing.Color.Empty
        Me.check10.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.check10.TextEnabled = True
        Me.check10.TextForeColor = System.Drawing.Color.Empty
        Me.check10.TextMaxLength = 32767
        Me.check10.TextMultiLine = False
        Me.check10.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.check10.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.check10.UseSendTab = True
        '
        'Checkname10
        '
        Me.Checkname10.BackYesno = False
        Me.Checkname10.ButtonTitle = Nothing
        Me.Checkname10.Code = Nothing
        Me.Checkname10.Data = ""
        Me.Checkname10.DataDecimal = 0
        Me.Checkname10.DataLen = 0
        Me.Checkname10.DataValue = 0
        Me.Checkname10.FormatDecimal = 0
        Me.Checkname10.FormatValue = False
        Me.Checkname10.LableBackColor = System.Drawing.SystemColors.Control
        Me.Checkname10.LableEnabled = True
        Me.Checkname10.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname10.LableForeColor = System.Drawing.Color.Empty
        Me.Checkname10.LableTitle = "CHECK 1"
        Me.Checkname10.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.Checkname10.Location = New System.Drawing.Point(620, 187)
        Me.Checkname10.Margin = New System.Windows.Forms.Padding(1)
        Me.Checkname10.Name = "Checkname10"
        Me.Checkname10.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Checkname10.Size = New System.Drawing.Size(203, 29)
        Me.Checkname10.TabIndex = 26
        Me.Checkname10.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Checkname10.TextBoxAutoComplete = False
        Me.Checkname10.TextboxBackColor = System.Drawing.Color.Empty
        Me.Checkname10.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Checkname10.TextEnabled = True
        Me.Checkname10.TextForeColor = System.Drawing.Color.Empty
        Me.Checkname10.TextMaxLength = 32767
        Me.Checkname10.TextMultiLine = False
        Me.Checkname10.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.Checkname10.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Checkname10.UseSendTab = True
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
        Me.tit_Use.Text = "Use"
        Me.tit_Use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Controls.Add(Me.UseCheck2, 1, 0)
        Me.Panel5.Controls.Add(Me.UseCheck1, 0, 0)
        Me.Panel5.Location = New System.Drawing.Point(141, 218)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(128, 29)
        Me.Panel5.TabIndex = 109
        '
        'UseCheck2
        '
        Me.UseCheck2.AutoSize = True
        Me.UseCheck2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UseCheck2.Location = New System.Drawing.Point(67, 4)
        Me.UseCheck2.Name = "UseCheck2"
        Me.UseCheck2.Size = New System.Drawing.Size(41, 18)
        Me.UseCheck2.TabIndex = 3
        Me.UseCheck2.TabStop = True
        Me.UseCheck2.Text = "No"
        Me.UseCheck2.UseVisualStyleBackColor = True
        '
        'UseCheck1
        '
        Me.UseCheck1.AutoSize = True
        Me.UseCheck1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.UseCheck1.Location = New System.Drawing.Point(4, 4)
        Me.UseCheck1.Name = "UseCheck1"
        Me.UseCheck1.Size = New System.Drawing.Size(45, 18)
        Me.UseCheck1.TabIndex = 2
        Me.UseCheck1.TabStop = True
        Me.UseCheck1.Text = "Yes"
        Me.UseCheck1.UseVisualStyleBackColor = True
        '
        'DisplaySeq
        '
        Me.DisplaySeq.BackYesno = False
        Me.DisplaySeq.ButtonTitle = Nothing
        Me.DisplaySeq.Code = Nothing
        Me.DisplaySeq.Data = ""
        Me.DisplaySeq.DataDecimal = 0
        Me.DisplaySeq.DataLen = 0
        Me.DisplaySeq.DataValue = 0
        Me.DisplaySeq.FormatDecimal = 0
        Me.DisplaySeq.FormatValue = False
        Me.DisplaySeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.DisplaySeq.LableEnabled = True
        Me.DisplaySeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DisplaySeq.LableForeColor = System.Drawing.Color.Empty
        Me.DisplaySeq.LableTitle = "Display Seq"
        Me.DisplaySeq.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.DisplaySeq.Location = New System.Drawing.Point(413, 218)
        Me.DisplaySeq.Margin = New System.Windows.Forms.Padding(143, 1, 1, 1)
        Me.DisplaySeq.Name = "DisplaySeq"
        Me.DisplaySeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.DisplaySeq.Size = New System.Drawing.Size(205, 29)
        Me.DisplaySeq.TabIndex = 27
        Me.DisplaySeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.DisplaySeq.TextBoxAutoComplete = False
        Me.DisplaySeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.DisplaySeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.DisplaySeq.TextEnabled = True
        Me.DisplaySeq.TextForeColor = System.Drawing.Color.Empty
        Me.DisplaySeq.TextMaxLength = 32767
        Me.DisplaySeq.TextMultiLine = False
        Me.DisplaySeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DisplaySeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.DisplaySeq.UseSendTab = True
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
        Me.txt_remark.LableTitle = "Basic Code Remark"
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
        'txt_Selremark
        '
        Me.txt_Selremark.BackYesno = False
        Me.txt_Selremark.ButtonTitle = Nothing
        Me.txt_Selremark.Code = Nothing
        Me.txt_Selremark.Data = ""
        Me.txt_Selremark.DataDecimal = 0
        Me.txt_Selremark.DataLen = 1
        Me.txt_Selremark.DataValue = 0
        Me.txt_Selremark.FormatDecimal = 0
        Me.txt_Selremark.FormatValue = False
        Me.txt_Selremark.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Selremark.LableEnabled = True
        Me.txt_Selremark.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Selremark.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Selremark.LableTitle = "Basic Sel Remark"
        Me.txt_Selremark.Layoutpercent = New Decimal(New Integer() {169, 0, 0, 196608})
        Me.txt_Selremark.Location = New System.Drawing.Point(2, 352)
        Me.txt_Selremark.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Selremark.Name = "txt_Selremark"
        Me.txt_Selremark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Selremark.Size = New System.Drawing.Size(826, 98)
        Me.txt_Selremark.TabIndex = 42
        Me.txt_Selremark.TabStop = False
        Me.txt_Selremark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Selremark.TextBoxAutoComplete = False
        Me.txt_Selremark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Selremark.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Selremark.TextEnabled = False
        Me.txt_Selremark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Selremark.TextMaxLength = 32767
        Me.txt_Selremark.TextMultiLine = True
        Me.txt_Selremark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Selremark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Selremark.UseSendTab = True
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel3.Code = ""
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_DevelopmentCode)
        Me.FlowLayoutPanel3.Data = ""
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(9, 40)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(212, 37)
        Me.FlowLayoutPanel3.TabIndex = 41
        '
        'txt_DevelopmentCode
        '
        Me.txt_DevelopmentCode.BackYesno = False
        Me.txt_DevelopmentCode.ButtonTitle = Nothing
        Me.txt_DevelopmentCode.Code = Nothing
        Me.txt_DevelopmentCode.Data = ""
        Me.txt_DevelopmentCode.DataDecimal = 0
        Me.txt_DevelopmentCode.DataLen = 0
        Me.txt_DevelopmentCode.DataValue = 0
        Me.txt_DevelopmentCode.FormatDecimal = 0
        Me.txt_DevelopmentCode.FormatValue = False
        Me.txt_DevelopmentCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DevelopmentCode.LableEnabled = True
        Me.txt_DevelopmentCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DevelopmentCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.LableTitle = "Develop Code"
        Me.txt_DevelopmentCode.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_DevelopmentCode.Location = New System.Drawing.Point(2, 2)
        Me.txt_DevelopmentCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_DevelopmentCode.Name = "txt_DevelopmentCode"
        Me.txt_DevelopmentCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DevelopmentCode.Size = New System.Drawing.Size(204, 29)
        Me.txt_DevelopmentCode.TabIndex = 2
        Me.txt_DevelopmentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DevelopmentCode.TextBoxAutoComplete = False
        Me.txt_DevelopmentCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DevelopmentCode.TextEnabled = True
        Me.txt_DevelopmentCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.TextMaxLength = 32767
        Me.txt_DevelopmentCode.TextMultiLine = False
        Me.txt_DevelopmentCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DevelopmentCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DevelopmentCode.UseSendTab = True
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
        'ISUD7172A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(849, 576)
        Me.Controls.Add(Me.frm_Condition)
        Me.KeyPreview = True
        Me.Name = "ISUD7172A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNTING CODE PROCESSING (ISUD7172A)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block1.ResumeLayout(False)
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
    Friend WithEvents txt_AccCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ForeignName2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ForeignName1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DevelopmentCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_NameSimply As PSMGlobal.SelectLabelText
    Friend WithEvents txt_BasicName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_AccSeq As PSMGlobal.SelectLabelText
    Friend WithEvents DisplaySeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_remark As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname10 As PSMGlobal.SelectLabelText
    Friend WithEvents check10 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname9 As PSMGlobal.SelectLabelText
    Friend WithEvents check9 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname8 As PSMGlobal.SelectLabelText
    Friend WithEvents check8 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname7 As PSMGlobal.SelectLabelText
    Friend WithEvents check7 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname6 As PSMGlobal.SelectLabelText
    Friend WithEvents check6 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname5 As PSMGlobal.SelectLabelText
    Friend WithEvents check5 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname4 As PSMGlobal.SelectLabelText
    Friend WithEvents check4 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname3 As PSMGlobal.SelectLabelText
    Friend WithEvents check3 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname2 As PSMGlobal.SelectLabelText
    Friend WithEvents check2 As PSMGlobal.SelectLabelText
    Friend WithEvents Checkname1 As PSMGlobal.SelectLabelText
    Friend WithEvents check1 As PSMGlobal.SelectLabelText
    Friend WithEvents Block1 As PSMGlobal.PeacePanel
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel3 As PSMGlobal.PeacePanel
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents UseCheck2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents UseCheck1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_Selremark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_AccSel As PSMGlobal.SelectLabelText
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
End Class
