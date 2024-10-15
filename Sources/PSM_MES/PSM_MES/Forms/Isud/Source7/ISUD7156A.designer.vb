<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7156A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7156A))
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_ToolCode = New PSMGlobal.SelectLabelText()
        Me.Block1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_cdToolGroup = New PSMGlobal.SelectPeaceHLPButton()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Bloack2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_ToolName = New PSMGlobal.SelectLabelText()
        Me.txt_ToolNameSimply = New PSMGlobal.SelectLabelText()
        Me.txt_ToolGroup = New PSMGlobal.SelectLabelText()
        Me.txt_BarcodeTool = New PSMGlobal.SelectLabelText()
        Me.txt_ToolWidth = New PSMGlobal.SelectLabelText()
        Me.txt_ToolWeight = New PSMGlobal.SelectLabelText()
        Me.txt_ToolSize = New PSMGlobal.SelectLabelText()
        Me.txt_JobCard = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdProcessProduction = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeaceLabel2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_checkUse2 = New System.Windows.Forms.RadioButton()
        Me.chk_checkUse1 = New System.Windows.Forms.RadioButton()
        Me.txt_Remark = New PSMGlobal.SelectLabelText()
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Block1.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.Bloack2.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.FlowLayoutPanel3)
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Controls.Add(Me.Frame4)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(837, 347)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_ToolCode)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(416, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(210, 36)
        Me.FlowLayoutPanel3.TabIndex = 1
        '
        'txt_ToolCode
        '
        Me.txt_ToolCode.BackYesno = False
        Me.txt_ToolCode.ButtonTitle = Nothing
        Me.txt_ToolCode.Code = Nothing
        Me.txt_ToolCode.Data = ""
        Me.txt_ToolCode.DataDecimal = 0
        Me.txt_ToolCode.DataLen = 0
        Me.txt_ToolCode.DataValue = 0
        Me.txt_ToolCode.Enabled = False
        Me.txt_ToolCode.FormatDecimal = 0
        Me.txt_ToolCode.FormatValue = False
        Me.txt_ToolCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ToolCode.LableEnabled = True
        Me.txt_ToolCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ToolCode.LableTitle = "Tool Code"
        Me.txt_ToolCode.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_ToolCode.Location = New System.Drawing.Point(2, 3)
        Me.txt_ToolCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ToolCode.Name = "txt_ToolCode"
        Me.txt_ToolCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ToolCode.Size = New System.Drawing.Size(204, 29)
        Me.txt_ToolCode.TabIndex = 0
        Me.txt_ToolCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ToolCode.TextBoxAutoComplete = False
        Me.txt_ToolCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ToolCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolCode.TextEnabled = True
        Me.txt_ToolCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ToolCode.TextMaxLength = 32767
        Me.txt_ToolCode.TextMultiLine = False
        Me.txt_ToolCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ToolCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ToolCode.UseSendTab = True
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Block1.Controls.Add(Me.txt_cdToolGroup)
        Me.Block1.Location = New System.Drawing.Point(4, 3)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(323, 35)
        Me.Block1.TabIndex = 0
        '
        'txt_cdToolGroup
        '
        Me.txt_cdToolGroup.BackYesno = False
        Me.txt_cdToolGroup.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdToolGroup.ButtonEnabled = True
        Me.txt_cdToolGroup.ButtonFont = Nothing
        Me.txt_cdToolGroup.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdToolGroup.ButtonName = "Const_ToolType"
        Me.txt_cdToolGroup.ButtonTitle = "Tool Type"
        Me.txt_cdToolGroup.Code = ""
        Me.txt_cdToolGroup.Data = ""
        Me.txt_cdToolGroup.DataDecimal = 0
        Me.txt_cdToolGroup.DataLen = 0
        Me.txt_cdToolGroup.DataValue = 1
        Me.txt_cdToolGroup.Layoutpercent = New Decimal(New Integer() {44, 0, 0, 131072})
        Me.txt_cdToolGroup.Location = New System.Drawing.Point(1, 1)
        Me.txt_cdToolGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdToolGroup.Name = "txt_cdToolGroup"
        Me.txt_cdToolGroup.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdToolGroup.Size = New System.Drawing.Size(316, 28)
        Me.txt_cdToolGroup.TabIndex = 0
        Me.txt_cdToolGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdToolGroup.TextBoxAutoComplete = True
        Me.txt_cdToolGroup.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdToolGroup.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdToolGroup.TextEnabled = True
        Me.txt_cdToolGroup.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdToolGroup.TextMaxLength = 32767
        Me.txt_cdToolGroup.TextMultiLine = False
        Me.txt_cdToolGroup.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdToolGroup.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdToolGroup.UseSendTab = True
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
        Me.Frame4.Location = New System.Drawing.Point(3, 305)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(827, 39)
        Me.Frame4.TabIndex = 0
        Me.Frame4.Tag = ""
        '
        'cmd_AttachID
        '
        Me.cmd_AttachID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_AttachID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_AttachID.Appearance.Options.UseFont = True
        Me.cmd_AttachID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_AttachID.ButtonTitle = Nothing
        Me.cmd_AttachID.Code = Nothing
        Me.cmd_AttachID.Data = Nothing
        Me.cmd_AttachID.Image = CType(resources.GetObject("cmd_AttachID.Image"), System.Drawing.Image)
        Me.cmd_AttachID.ImageAlign = 16
        Me.cmd_AttachID.Location = New System.Drawing.Point(344, 2)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 14
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_DEL.ButtonTitle = Nothing
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 0
        Me.cmd_DEL.Location = New System.Drawing.Point(0, 0)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 0
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 0
        Me.cmd_Cancel.Location = New System.Drawing.Point(682, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 2
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 0
        Me.cmd_OK.Location = New System.Drawing.Point(540, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 1
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bloack2.Controls.Add(Me.txt_ToolName)
        Me.Bloack2.Controls.Add(Me.txt_ToolNameSimply)
        Me.Bloack2.Controls.Add(Me.txt_ToolGroup)
        Me.Bloack2.Controls.Add(Me.txt_BarcodeTool)
        Me.Bloack2.Controls.Add(Me.txt_ToolWidth)
        Me.Bloack2.Controls.Add(Me.txt_ToolWeight)
        Me.Bloack2.Controls.Add(Me.txt_ToolSize)
        Me.Bloack2.Controls.Add(Me.txt_JobCard)
        Me.Bloack2.Controls.Add(Me.txt_MaterialCode)
        Me.Bloack2.Controls.Add(Me.txt_cdProcessProduction)
        Me.Bloack2.Controls.Add(Me.PeaceLabel2)
        Me.Bloack2.Controls.Add(Me.PeacePanel3)
        Me.Bloack2.Controls.Add(Me.txt_Remark)
        Me.Bloack2.Location = New System.Drawing.Point(4, 41)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(827, 260)
        Me.Bloack2.TabIndex = 2
        '
        'txt_ToolName
        '
        Me.txt_ToolName.BackYesno = False
        Me.txt_ToolName.ButtonTitle = Nothing
        Me.txt_ToolName.Code = Nothing
        Me.txt_ToolName.Data = ""
        Me.txt_ToolName.DataDecimal = 0
        Me.txt_ToolName.DataLen = 0
        Me.txt_ToolName.DataValue = 1
        Me.txt_ToolName.FormatDecimal = 0
        Me.txt_ToolName.FormatValue = False
        Me.txt_ToolName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ToolName.LableEnabled = True
        Me.txt_ToolName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ToolName.LableTitle = "Tool Name"
        Me.txt_ToolName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ToolName.Location = New System.Drawing.Point(1, 1)
        Me.txt_ToolName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ToolName.Name = "txt_ToolName"
        Me.txt_ToolName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ToolName.Size = New System.Drawing.Size(410, 29)
        Me.txt_ToolName.TabIndex = 0
        Me.txt_ToolName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ToolName.TextBoxAutoComplete = False
        Me.txt_ToolName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ToolName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolName.TextEnabled = True
        Me.txt_ToolName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ToolName.TextMaxLength = 32767
        Me.txt_ToolName.TextMultiLine = False
        Me.txt_ToolName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ToolName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ToolName.UseSendTab = True
        '
        'txt_ToolNameSimply
        '
        Me.txt_ToolNameSimply.BackYesno = False
        Me.txt_ToolNameSimply.ButtonTitle = Nothing
        Me.txt_ToolNameSimply.Code = Nothing
        Me.txt_ToolNameSimply.Data = ""
        Me.txt_ToolNameSimply.DataDecimal = 0
        Me.txt_ToolNameSimply.DataLen = 0
        Me.txt_ToolNameSimply.DataValue = 1
        Me.txt_ToolNameSimply.FormatDecimal = 0
        Me.txt_ToolNameSimply.FormatValue = False
        Me.txt_ToolNameSimply.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ToolNameSimply.LableEnabled = True
        Me.txt_ToolNameSimply.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolNameSimply.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ToolNameSimply.LableTitle = "Name Simply"
        Me.txt_ToolNameSimply.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ToolNameSimply.Location = New System.Drawing.Point(413, 1)
        Me.txt_ToolNameSimply.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ToolNameSimply.Name = "txt_ToolNameSimply"
        Me.txt_ToolNameSimply.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ToolNameSimply.Size = New System.Drawing.Size(410, 29)
        Me.txt_ToolNameSimply.TabIndex = 1
        Me.txt_ToolNameSimply.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ToolNameSimply.TextBoxAutoComplete = False
        Me.txt_ToolNameSimply.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ToolNameSimply.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolNameSimply.TextEnabled = True
        Me.txt_ToolNameSimply.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ToolNameSimply.TextMaxLength = 32767
        Me.txt_ToolNameSimply.TextMultiLine = False
        Me.txt_ToolNameSimply.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ToolNameSimply.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ToolNameSimply.UseSendTab = True
        '
        'txt_ToolGroup
        '
        Me.txt_ToolGroup.BackYesno = False
        Me.txt_ToolGroup.ButtonTitle = Nothing
        Me.txt_ToolGroup.Code = Nothing
        Me.txt_ToolGroup.Data = ""
        Me.txt_ToolGroup.DataDecimal = 0
        Me.txt_ToolGroup.DataLen = 0
        Me.txt_ToolGroup.DataValue = 1
        Me.txt_ToolGroup.FormatDecimal = 0
        Me.txt_ToolGroup.FormatValue = False
        Me.txt_ToolGroup.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ToolGroup.LableEnabled = True
        Me.txt_ToolGroup.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolGroup.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ToolGroup.LableTitle = "Group Tool"
        Me.txt_ToolGroup.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ToolGroup.Location = New System.Drawing.Point(1, 32)
        Me.txt_ToolGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ToolGroup.Name = "txt_ToolGroup"
        Me.txt_ToolGroup.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ToolGroup.Size = New System.Drawing.Size(410, 29)
        Me.txt_ToolGroup.TabIndex = 2
        Me.txt_ToolGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ToolGroup.TextBoxAutoComplete = False
        Me.txt_ToolGroup.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ToolGroup.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolGroup.TextEnabled = True
        Me.txt_ToolGroup.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ToolGroup.TextMaxLength = 32767
        Me.txt_ToolGroup.TextMultiLine = False
        Me.txt_ToolGroup.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ToolGroup.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ToolGroup.UseSendTab = True
        '
        'txt_BarcodeTool
        '
        Me.txt_BarcodeTool.BackYesno = True
        Me.txt_BarcodeTool.ButtonTitle = Nothing
        Me.txt_BarcodeTool.Code = Nothing
        Me.txt_BarcodeTool.Data = ""
        Me.txt_BarcodeTool.DataDecimal = 0
        Me.txt_BarcodeTool.DataLen = 0
        Me.txt_BarcodeTool.DataValue = 0
        Me.txt_BarcodeTool.FormatDecimal = 0
        Me.txt_BarcodeTool.FormatValue = False
        Me.txt_BarcodeTool.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_BarcodeTool.LableEnabled = True
        Me.txt_BarcodeTool.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_BarcodeTool.LableForeColor = System.Drawing.Color.Empty
        Me.txt_BarcodeTool.LableTitle = "Barcode Tool"
        Me.txt_BarcodeTool.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_BarcodeTool.Location = New System.Drawing.Point(413, 32)
        Me.txt_BarcodeTool.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_BarcodeTool.Name = "txt_BarcodeTool"
        Me.txt_BarcodeTool.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BarcodeTool.Size = New System.Drawing.Size(410, 29)
        Me.txt_BarcodeTool.TabIndex = 3
        Me.txt_BarcodeTool.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BarcodeTool.TextBoxAutoComplete = False
        Me.txt_BarcodeTool.TextboxBackColor = System.Drawing.Color.White
        Me.txt_BarcodeTool.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_BarcodeTool.TextEnabled = True
        Me.txt_BarcodeTool.TextForeColor = System.Drawing.Color.Black
        Me.txt_BarcodeTool.TextMaxLength = 32767
        Me.txt_BarcodeTool.TextMultiLine = False
        Me.txt_BarcodeTool.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BarcodeTool.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BarcodeTool.UseSendTab = True
        '
        'txt_ToolWidth
        '
        Me.txt_ToolWidth.BackYesno = False
        Me.txt_ToolWidth.ButtonTitle = Nothing
        Me.txt_ToolWidth.Code = Nothing
        Me.txt_ToolWidth.Data = ""
        Me.txt_ToolWidth.DataDecimal = 0
        Me.txt_ToolWidth.DataLen = 0
        Me.txt_ToolWidth.DataValue = 1
        Me.txt_ToolWidth.FormatDecimal = 0
        Me.txt_ToolWidth.FormatValue = False
        Me.txt_ToolWidth.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ToolWidth.LableEnabled = True
        Me.txt_ToolWidth.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolWidth.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ToolWidth.LableTitle = "Width Tool"
        Me.txt_ToolWidth.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ToolWidth.Location = New System.Drawing.Point(1, 63)
        Me.txt_ToolWidth.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ToolWidth.Name = "txt_ToolWidth"
        Me.txt_ToolWidth.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ToolWidth.Size = New System.Drawing.Size(410, 29)
        Me.txt_ToolWidth.TabIndex = 4
        Me.txt_ToolWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ToolWidth.TextBoxAutoComplete = False
        Me.txt_ToolWidth.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ToolWidth.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolWidth.TextEnabled = True
        Me.txt_ToolWidth.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ToolWidth.TextMaxLength = 32767
        Me.txt_ToolWidth.TextMultiLine = False
        Me.txt_ToolWidth.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ToolWidth.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ToolWidth.UseSendTab = True
        '
        'txt_ToolWeight
        '
        Me.txt_ToolWeight.BackYesno = False
        Me.txt_ToolWeight.ButtonTitle = Nothing
        Me.txt_ToolWeight.Code = Nothing
        Me.txt_ToolWeight.Data = ""
        Me.txt_ToolWeight.DataDecimal = 0
        Me.txt_ToolWeight.DataLen = 0
        Me.txt_ToolWeight.DataValue = 1
        Me.txt_ToolWeight.FormatDecimal = 0
        Me.txt_ToolWeight.FormatValue = False
        Me.txt_ToolWeight.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ToolWeight.LableEnabled = True
        Me.txt_ToolWeight.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolWeight.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ToolWeight.LableTitle = "Weight Tool"
        Me.txt_ToolWeight.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ToolWeight.Location = New System.Drawing.Point(413, 63)
        Me.txt_ToolWeight.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ToolWeight.Name = "txt_ToolWeight"
        Me.txt_ToolWeight.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ToolWeight.Size = New System.Drawing.Size(410, 29)
        Me.txt_ToolWeight.TabIndex = 5
        Me.txt_ToolWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ToolWeight.TextBoxAutoComplete = False
        Me.txt_ToolWeight.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ToolWeight.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolWeight.TextEnabled = True
        Me.txt_ToolWeight.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ToolWeight.TextMaxLength = 32767
        Me.txt_ToolWeight.TextMultiLine = False
        Me.txt_ToolWeight.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ToolWeight.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ToolWeight.UseSendTab = True
        '
        'txt_ToolSize
        '
        Me.txt_ToolSize.BackYesno = False
        Me.txt_ToolSize.ButtonTitle = Nothing
        Me.txt_ToolSize.Code = Nothing
        Me.txt_ToolSize.Data = ""
        Me.txt_ToolSize.DataDecimal = 0
        Me.txt_ToolSize.DataLen = 0
        Me.txt_ToolSize.DataValue = 1
        Me.txt_ToolSize.FormatDecimal = 0
        Me.txt_ToolSize.FormatValue = False
        Me.txt_ToolSize.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ToolSize.LableEnabled = True
        Me.txt_ToolSize.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolSize.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ToolSize.LableTitle = "Width Tool"
        Me.txt_ToolSize.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ToolSize.Location = New System.Drawing.Point(1, 94)
        Me.txt_ToolSize.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ToolSize.Name = "txt_ToolSize"
        Me.txt_ToolSize.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ToolSize.Size = New System.Drawing.Size(410, 29)
        Me.txt_ToolSize.TabIndex = 6
        Me.txt_ToolSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ToolSize.TextBoxAutoComplete = False
        Me.txt_ToolSize.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ToolSize.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ToolSize.TextEnabled = True
        Me.txt_ToolSize.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ToolSize.TextMaxLength = 32767
        Me.txt_ToolSize.TextMultiLine = False
        Me.txt_ToolSize.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ToolSize.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ToolSize.UseSendTab = True
        '
        'txt_JobCard
        '
        Me.txt_JobCard.BackYesno = False
        Me.txt_JobCard.ButtonTitle = Nothing
        Me.txt_JobCard.Code = Nothing
        Me.txt_JobCard.Data = ""
        Me.txt_JobCard.DataDecimal = 0
        Me.txt_JobCard.DataLen = 0
        Me.txt_JobCard.DataValue = 1
        Me.txt_JobCard.FormatDecimal = 0
        Me.txt_JobCard.FormatValue = False
        Me.txt_JobCard.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_JobCard.LableEnabled = True
        Me.txt_JobCard.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_JobCard.LableForeColor = System.Drawing.Color.Empty
        Me.txt_JobCard.LableTitle = "Width Tool"
        Me.txt_JobCard.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_JobCard.Location = New System.Drawing.Point(413, 94)
        Me.txt_JobCard.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_JobCard.Name = "txt_JobCard"
        Me.txt_JobCard.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_JobCard.Size = New System.Drawing.Size(410, 29)
        Me.txt_JobCard.TabIndex = 7
        Me.txt_JobCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_JobCard.TextBoxAutoComplete = False
        Me.txt_JobCard.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_JobCard.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_JobCard.TextEnabled = True
        Me.txt_JobCard.TextForeColor = System.Drawing.Color.Empty
        Me.txt_JobCard.TextMaxLength = 32767
        Me.txt_JobCard.TextMultiLine = False
        Me.txt_JobCard.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_JobCard.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_JobCard.UseSendTab = True
        '
        'txt_MaterialCode
        '
        Me.txt_MaterialCode.BackYesno = False
        Me.txt_MaterialCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_MaterialCode.ButtonEnabled = True
        Me.txt_MaterialCode.ButtonFont = Nothing
        Me.txt_MaterialCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.ButtonName = ""
        Me.txt_MaterialCode.ButtonTitle = "Material Code"
        Me.txt_MaterialCode.Code = ""
        Me.txt_MaterialCode.Data = ""
        Me.txt_MaterialCode.DataDecimal = 0
        Me.txt_MaterialCode.DataLen = 0
        Me.txt_MaterialCode.DataValue = 1
        Me.txt_MaterialCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MaterialCode.Location = New System.Drawing.Point(1, 125)
        Me.txt_MaterialCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialCode.Name = "txt_MaterialCode"
        Me.txt_MaterialCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialCode.Size = New System.Drawing.Size(410, 29)
        Me.txt_MaterialCode.TabIndex = 203
        Me.txt_MaterialCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialCode.TextBoxAutoComplete = False
        Me.txt_MaterialCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_MaterialCode.TextEnabled = True
        Me.txt_MaterialCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.TextMaxLength = 32767
        Me.txt_MaterialCode.TextMultiLine = False
        Me.txt_MaterialCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialCode.UseSendTab = True
        '
        'txt_cdProcessProduction
        '
        Me.txt_cdProcessProduction.BackYesno = False
        Me.txt_cdProcessProduction.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdProcessProduction.ButtonEnabled = True
        Me.txt_cdProcessProduction.ButtonFont = Nothing
        Me.txt_cdProcessProduction.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdProcessProduction.ButtonName = "Const_ProcessProduction"
        Me.txt_cdProcessProduction.ButtonTitle = "Prod Process"
        Me.txt_cdProcessProduction.Code = ""
        Me.txt_cdProcessProduction.Data = ""
        Me.txt_cdProcessProduction.DataDecimal = 0
        Me.txt_cdProcessProduction.DataLen = 0
        Me.txt_cdProcessProduction.DataValue = 1
        Me.txt_cdProcessProduction.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdProcessProduction.Location = New System.Drawing.Point(413, 125)
        Me.txt_cdProcessProduction.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdProcessProduction.Name = "txt_cdProcessProduction"
        Me.txt_cdProcessProduction.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdProcessProduction.Size = New System.Drawing.Size(410, 29)
        Me.txt_cdProcessProduction.TabIndex = 8
        Me.txt_cdProcessProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdProcessProduction.TextBoxAutoComplete = False
        Me.txt_cdProcessProduction.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdProcessProduction.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdProcessProduction.TextEnabled = True
        Me.txt_cdProcessProduction.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdProcessProduction.TextMaxLength = 32767
        Me.txt_cdProcessProduction.TextMultiLine = False
        Me.txt_cdProcessProduction.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdProcessProduction.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdProcessProduction.UseSendTab = True
        '
        'PeaceLabel2
        '
        Me.PeaceLabel2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel2.ButtonTitle = Nothing
        Me.PeaceLabel2.Code = ""
        Me.PeaceLabel2.Data = ""
        Me.PeaceLabel2.DTDec = 0
        Me.PeaceLabel2.DTLen = 0
        Me.PeaceLabel2.DTValue = 0
        Me.PeaceLabel2.Location = New System.Drawing.Point(1, 156)
        Me.PeaceLabel2.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel2.Name = "PeaceLabel2"
        Me.PeaceLabel2.NoClear = False
        Me.PeaceLabel2.Size = New System.Drawing.Size(137, 29)
        Me.PeaceLabel2.TabIndex = 9
        Me.PeaceLabel2.Tag = ""
        Me.PeaceLabel2.Text = "Use"
        Me.PeaceLabel2.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel3
        '
        Me.PeacePanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.chk_checkUse2)
        Me.PeacePanel3.Controls.Add(Me.chk_checkUse1)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(139, 156)
        Me.PeacePanel3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(183, 28)
        Me.PeacePanel3.TabIndex = 10
        Me.PeacePanel3.Tag = ""
        '
        'chk_checkUse2
        '
        Me.chk_checkUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_checkUse2.Location = New System.Drawing.Point(77, 5)
        Me.chk_checkUse2.Name = "chk_checkUse2"
        Me.chk_checkUse2.Size = New System.Drawing.Size(90, 17)
        Me.chk_checkUse2.TabIndex = 1
        Me.chk_checkUse2.Text = "No"
        Me.chk_checkUse2.UseVisualStyleBackColor = True
        '
        'chk_checkUse1
        '
        Me.chk_checkUse1.Checked = True
        Me.chk_checkUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_checkUse1.Location = New System.Drawing.Point(15, 3)
        Me.chk_checkUse1.Name = "chk_checkUse1"
        Me.chk_checkUse1.Size = New System.Drawing.Size(104, 24)
        Me.chk_checkUse1.TabIndex = 0
        Me.chk_checkUse1.TabStop = True
        Me.chk_checkUse1.Text = "Yes"
        Me.chk_checkUse1.UseVisualStyleBackColor = True
        '
        'txt_Remark
        '
        Me.txt_Remark.BackYesno = False
        Me.txt_Remark.ButtonTitle = Nothing
        Me.txt_Remark.Code = Nothing
        Me.txt_Remark.Data = ""
        Me.txt_Remark.DataDecimal = 0
        Me.txt_Remark.DataLen = 0
        Me.txt_Remark.DataValue = 0
        Me.txt_Remark.FormatDecimal = 0
        Me.txt_Remark.FormatValue = False
        Me.txt_Remark.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Remark.LableEnabled = True
        Me.txt_Remark.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.LableTitle = "Remark"
        Me.txt_Remark.Layoutpercent = New Decimal(New Integer() {167, 0, 0, 196608})
        Me.txt_Remark.Location = New System.Drawing.Point(2, 188)
        Me.txt_Remark.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Remark.Size = New System.Drawing.Size(820, 67)
        Me.txt_Remark.TabIndex = 13
        Me.txt_Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Remark.TextBoxAutoComplete = False
        Me.txt_Remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.TextEnabled = True
        Me.txt_Remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextMaxLength = 32767
        Me.txt_Remark.TextMultiLine = True
        Me.txt_Remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Remark.UseSendTab = True
        '
        'ISUD7156A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(837, 347)
        Me.Controls.Add(Me.frm_Condition)
        Me.KeyPreview = True
        Me.Name = "ISUD7156A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOOL CODE PROCESSING (ISUD7156A)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Block1.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.Bloack2.ResumeLayout(False)
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_ToolCode As PSMGlobal.SelectLabelText
    Friend WithEvents Block1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_cdToolGroup As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Bloack2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_ToolName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ToolNameSimply As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ToolGroup As PSMGlobal.SelectLabelText
    Friend WithEvents txt_BarcodeTool As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ToolWeight As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ToolWidth As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdProcessProduction As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeaceLabel2 As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents chk_checkUse2 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_checkUse1 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_Remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ToolSize As PSMGlobal.SelectLabelText
    Friend WithEvents txt_JobCard As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MaterialCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
End Class
