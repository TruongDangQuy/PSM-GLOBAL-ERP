<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7155A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7155A))
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_MachineCode = New PSMGlobal.SelectLabelText()
        Me.Block1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_cdMachineType = New PSMGlobal.SelectPeaceHLPButton()
        Me.Bloack2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MachineName = New PSMGlobal.SelectLabelText()
        Me.txt_MachineNameSimply = New PSMGlobal.SelectLabelText()
        Me.txt_MachineCapacity = New PSMGlobal.SelectLabelTextLable()
        Me.txt_RotationDayProduction = New PSMGlobal.SelectLabelTextLable()
        Me.txt_MachineRPM = New PSMGlobal.SelectLabelTextLable()
        Me.txt_RotationOnceProduction = New PSMGlobal.SelectLabelTextLable()
        Me.txt_RotationOnceTimeProduction = New PSMGlobal.SelectLabelTextLable()
        Me.txt_GroupMachine = New PSMGlobal.SelectLabelText()
        Me.txt_DisplaySeq = New PSMGlobal.SelectLabelText()
        Me.txt_VerticalPosition = New PSMGlobal.SelectLabelText()
        Me.txt_HorizontalPosition = New PSMGlobal.SelectLabelText()
        Me.lbl_use = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckFinalProcess2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckFinalProcess1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckProcess2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckProcess1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_ChecK1 = New PSMGlobal.SelectLabelText()
        Me.txt_ChecK2 = New PSMGlobal.SelectLabelText()
        Me.txt_cdSubProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeaceLabel2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_checkUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_checkUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_Remark = New PSMGlobal.SelectLabelText()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.Block1.SuspendLayout()
        Me.Bloack2.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.FlowLayoutPanel3)
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Location = New System.Drawing.Point(3, 3)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(833, 429)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FlowLayoutPanel3.Controls.Add(Me.txt_MachineCode)
        Me.FlowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(416, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(212, 34)
        Me.FlowLayoutPanel3.TabIndex = 42
        '
        'txt_MachineCode
        '
        Me.txt_MachineCode.BackYesno = False
        Me.txt_MachineCode.ButtonTitle = Nothing
        Me.txt_MachineCode.Code = Nothing
        Me.txt_MachineCode.Data = ""
        Me.txt_MachineCode.DataDecimal = 0
        Me.txt_MachineCode.DataLen = 0
        Me.txt_MachineCode.DataValue = 0
        Me.txt_MachineCode.Enabled = False
        Me.txt_MachineCode.FormatDecimal = 0
        Me.txt_MachineCode.FormatValue = False
        Me.txt_MachineCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineCode.LableEnabled = True
        Me.txt_MachineCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MachineCode.LableTitle = "Machine Code"
        Me.txt_MachineCode.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_MachineCode.Location = New System.Drawing.Point(3, 3)
        Me.txt_MachineCode.Name = "txt_MachineCode"
        Me.txt_MachineCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineCode.Size = New System.Drawing.Size(204, 26)
        Me.txt_MachineCode.TabIndex = 0
        Me.txt_MachineCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MachineCode.TextBoxAutoComplete = False
        Me.txt_MachineCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineCode.TextEnabled = True
        Me.txt_MachineCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineCode.TextMaxLength = 32767
        Me.txt_MachineCode.TextMultiLine = False
        Me.txt_MachineCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineCode.UseSendTab = True
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Block1.Controls.Add(Me.txt_cdMachineType)
        Me.Block1.Location = New System.Drawing.Point(2, 4)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(324, 34)
        Me.Block1.TabIndex = 39
        '
        'txt_cdMachineType
        '
        Me.txt_cdMachineType.BackYesno = False
        Me.txt_cdMachineType.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMachineType.ButtonEnabled = True
        Me.txt_cdMachineType.ButtonFont = Nothing
        Me.txt_cdMachineType.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMachineType.ButtonName = "Const_MachineType"
        Me.txt_cdMachineType.ButtonTitle = "Machine Type"
        Me.txt_cdMachineType.Code = ""
        Me.txt_cdMachineType.Data = ""
        Me.txt_cdMachineType.DataDecimal = 0
        Me.txt_cdMachineType.DataLen = 0
        Me.txt_cdMachineType.DataValue = 0
        Me.txt_cdMachineType.Layoutpercent = New Decimal(New Integer() {44, 0, 0, 131072})
        Me.txt_cdMachineType.Location = New System.Drawing.Point(3, 3)
        Me.txt_cdMachineType.Name = "txt_cdMachineType"
        Me.txt_cdMachineType.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMachineType.Size = New System.Drawing.Size(316, 26)
        Me.txt_cdMachineType.TabIndex = 0
        Me.txt_cdMachineType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMachineType.TextBoxAutoComplete = True
        Me.txt_cdMachineType.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMachineType.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMachineType.TextEnabled = True
        Me.txt_cdMachineType.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdMachineType.TextMaxLength = 32767
        Me.txt_cdMachineType.TextMultiLine = False
        Me.txt_cdMachineType.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdMachineType.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdMachineType.UseSendTab = True
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Bloack2.Controls.Add(Me.txt_cdFactory)
        Me.Bloack2.Controls.Add(Me.txt_cdSubProcess)
        Me.Bloack2.Controls.Add(Me.txt_MachineName)
        Me.Bloack2.Controls.Add(Me.txt_MachineNameSimply)
        Me.Bloack2.Controls.Add(Me.txt_MachineCapacity)
        Me.Bloack2.Controls.Add(Me.txt_RotationDayProduction)
        Me.Bloack2.Controls.Add(Me.txt_MachineRPM)
        Me.Bloack2.Controls.Add(Me.txt_RotationOnceProduction)
        Me.Bloack2.Controls.Add(Me.txt_RotationOnceTimeProduction)
        Me.Bloack2.Controls.Add(Me.txt_GroupMachine)
        Me.Bloack2.Controls.Add(Me.txt_DisplaySeq)
        Me.Bloack2.Controls.Add(Me.txt_VerticalPosition)
        Me.Bloack2.Controls.Add(Me.txt_HorizontalPosition)
        Me.Bloack2.Controls.Add(Me.lbl_use)
        Me.Bloack2.Controls.Add(Me.PeacePanel1)
        Me.Bloack2.Controls.Add(Me.PeaceLabel1)
        Me.Bloack2.Controls.Add(Me.PeacePanel2)
        Me.Bloack2.Controls.Add(Me.txt_ChecK1)
        Me.Bloack2.Controls.Add(Me.txt_ChecK2)
        Me.Bloack2.Controls.Add(Me.PeaceLabel2)
        Me.Bloack2.Controls.Add(Me.PeacePanel3)
        Me.Bloack2.Controls.Add(Me.txt_Remark)
        Me.Bloack2.Location = New System.Drawing.Point(4, 41)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(827, 388)
        Me.Bloack2.TabIndex = 0
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = Nothing
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = ""
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 0
        Me.txt_cdFactory.DataLen = 0
        Me.txt_cdFactory.DataValue = 1
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdFactory.Location = New System.Drawing.Point(3, 3)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(3, 3, 100, 3)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(408, 26)
        Me.txt_cdFactory.TabIndex = 0
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = True
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdFactory.TextEnabled = True
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_MachineName
        '
        Me.txt_MachineName.BackYesno = False
        Me.txt_MachineName.ButtonTitle = Nothing
        Me.txt_MachineName.Code = Nothing
        Me.txt_MachineName.Data = ""
        Me.txt_MachineName.DataDecimal = 0
        Me.txt_MachineName.DataLen = 0
        Me.txt_MachineName.DataValue = 1
        Me.txt_MachineName.FormatDecimal = 0
        Me.txt_MachineName.FormatValue = False
        Me.txt_MachineName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineName.LableEnabled = True
        Me.txt_MachineName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.LableTitle = "Machine Name"
        Me.txt_MachineName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MachineName.Location = New System.Drawing.Point(413, 33)
        Me.txt_MachineName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MachineName.Name = "txt_MachineName"
        Me.txt_MachineName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineName.Size = New System.Drawing.Size(410, 26)
        Me.txt_MachineName.TabIndex = 2
        Me.txt_MachineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MachineName.TextBoxAutoComplete = False
        Me.txt_MachineName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineName.TextEnabled = True
        Me.txt_MachineName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextMaxLength = 32767
        Me.txt_MachineName.TextMultiLine = False
        Me.txt_MachineName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineName.UseSendTab = True
        '
        'txt_MachineNameSimply
        '
        Me.txt_MachineNameSimply.BackYesno = False
        Me.txt_MachineNameSimply.ButtonTitle = Nothing
        Me.txt_MachineNameSimply.Code = Nothing
        Me.txt_MachineNameSimply.Data = ""
        Me.txt_MachineNameSimply.DataDecimal = 0
        Me.txt_MachineNameSimply.DataLen = 0
        Me.txt_MachineNameSimply.DataValue = 1
        Me.txt_MachineNameSimply.FormatDecimal = 0
        Me.txt_MachineNameSimply.FormatValue = False
        Me.txt_MachineNameSimply.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineNameSimply.LableEnabled = True
        Me.txt_MachineNameSimply.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineNameSimply.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MachineNameSimply.LableTitle = "Name Simply"
        Me.txt_MachineNameSimply.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MachineNameSimply.Location = New System.Drawing.Point(1, 61)
        Me.txt_MachineNameSimply.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MachineNameSimply.Name = "txt_MachineNameSimply"
        Me.txt_MachineNameSimply.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineNameSimply.Size = New System.Drawing.Size(410, 26)
        Me.txt_MachineNameSimply.TabIndex = 3
        Me.txt_MachineNameSimply.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MachineNameSimply.TextBoxAutoComplete = False
        Me.txt_MachineNameSimply.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineNameSimply.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineNameSimply.TextEnabled = True
        Me.txt_MachineNameSimply.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineNameSimply.TextMaxLength = 32767
        Me.txt_MachineNameSimply.TextMultiLine = False
        Me.txt_MachineNameSimply.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineNameSimply.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineNameSimply.UseSendTab = True
        '
        'txt_MachineCapacity
        '
        Me.txt_MachineCapacity.BackYesno = False
        Me.txt_MachineCapacity.ButtonTitle = Nothing
        Me.txt_MachineCapacity.Code = Nothing
        Me.txt_MachineCapacity.Data = Nothing
        Me.txt_MachineCapacity.DataDecimal = 0
        Me.txt_MachineCapacity.DataLen = 0
        Me.txt_MachineCapacity.DataValue = 1
        Me.txt_MachineCapacity.FormatDecimal = 0
        Me.txt_MachineCapacity.FormatValue = False
        Me.txt_MachineCapacity.Lable2BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MachineCapacity.Lable2Enabled = True
        Me.txt_MachineCapacity.Lable2Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineCapacity.Lable2ForeColor = System.Drawing.Color.Black
        Me.txt_MachineCapacity.Lable2Title = "KG"
        Me.txt_MachineCapacity.Lable2Width = 85
        Me.txt_MachineCapacity.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineCapacity.LableEnabled = True
        Me.txt_MachineCapacity.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineCapacity.LableForeColor = System.Drawing.Color.Black
        Me.txt_MachineCapacity.LableTitle = "Machine Capacity"
        Me.txt_MachineCapacity.Layoutpercent = New Decimal(New Integer() {425, 0, 0, 196608})
        Me.txt_MachineCapacity.Location = New System.Drawing.Point(413, 61)
        Me.txt_MachineCapacity.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MachineCapacity.Name = "txt_MachineCapacity"
        Me.txt_MachineCapacity.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineCapacity.Size = New System.Drawing.Size(410, 26)
        Me.txt_MachineCapacity.TabIndex = 4
        Me.txt_MachineCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MachineCapacity.TextBoxAutoComplete = False
        Me.txt_MachineCapacity.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineCapacity.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineCapacity.TextEnabled = True
        Me.txt_MachineCapacity.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineCapacity.TextMaxLength = 32767
        Me.txt_MachineCapacity.TextMultiLine = False
        Me.txt_MachineCapacity.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineCapacity.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineCapacity.UseSendTab = True
        '
        'txt_RotationDayProduction
        '
        Me.txt_RotationDayProduction.BackYesno = False
        Me.txt_RotationDayProduction.ButtonTitle = Nothing
        Me.txt_RotationDayProduction.Code = Nothing
        Me.txt_RotationDayProduction.Data = Nothing
        Me.txt_RotationDayProduction.DataDecimal = 0
        Me.txt_RotationDayProduction.DataLen = 0
        Me.txt_RotationDayProduction.DataValue = 1
        Me.txt_RotationDayProduction.FormatDecimal = 0
        Me.txt_RotationDayProduction.FormatValue = False
        Me.txt_RotationDayProduction.Lable2BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_RotationDayProduction.Lable2Enabled = True
        Me.txt_RotationDayProduction.Lable2Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationDayProduction.Lable2ForeColor = System.Drawing.Color.Black
        Me.txt_RotationDayProduction.Lable2Title = "/DAY"
        Me.txt_RotationDayProduction.Lable2Width = 85
        Me.txt_RotationDayProduction.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_RotationDayProduction.LableEnabled = True
        Me.txt_RotationDayProduction.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationDayProduction.LableForeColor = System.Drawing.Color.Black
        Me.txt_RotationDayProduction.LableTitle = "Machine Rotation"
        Me.txt_RotationDayProduction.Layoutpercent = New Decimal(New Integer() {425, 0, 0, 196608})
        Me.txt_RotationDayProduction.Location = New System.Drawing.Point(1, 89)
        Me.txt_RotationDayProduction.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_RotationDayProduction.Name = "txt_RotationDayProduction"
        Me.txt_RotationDayProduction.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_RotationDayProduction.Size = New System.Drawing.Size(410, 26)
        Me.txt_RotationDayProduction.TabIndex = 5
        Me.txt_RotationDayProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_RotationDayProduction.TextBoxAutoComplete = False
        Me.txt_RotationDayProduction.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_RotationDayProduction.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationDayProduction.TextEnabled = True
        Me.txt_RotationDayProduction.TextForeColor = System.Drawing.Color.Empty
        Me.txt_RotationDayProduction.TextMaxLength = 32767
        Me.txt_RotationDayProduction.TextMultiLine = False
        Me.txt_RotationDayProduction.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_RotationDayProduction.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_RotationDayProduction.UseSendTab = True
        '
        'txt_MachineRPM
        '
        Me.txt_MachineRPM.BackYesno = False
        Me.txt_MachineRPM.ButtonTitle = Nothing
        Me.txt_MachineRPM.Code = Nothing
        Me.txt_MachineRPM.Data = Nothing
        Me.txt_MachineRPM.DataDecimal = 0
        Me.txt_MachineRPM.DataLen = 0
        Me.txt_MachineRPM.DataValue = 1
        Me.txt_MachineRPM.FormatDecimal = 0
        Me.txt_MachineRPM.FormatValue = False
        Me.txt_MachineRPM.Lable2BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MachineRPM.Lable2Enabled = True
        Me.txt_MachineRPM.Lable2Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineRPM.Lable2ForeColor = System.Drawing.Color.Black
        Me.txt_MachineRPM.Lable2Title = "RPM"
        Me.txt_MachineRPM.Lable2Width = 85
        Me.txt_MachineRPM.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineRPM.LableEnabled = True
        Me.txt_MachineRPM.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineRPM.LableForeColor = System.Drawing.Color.Black
        Me.txt_MachineRPM.LableTitle = "Machine Speed"
        Me.txt_MachineRPM.Layoutpercent = New Decimal(New Integer() {425, 0, 0, 196608})
        Me.txt_MachineRPM.Location = New System.Drawing.Point(413, 89)
        Me.txt_MachineRPM.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MachineRPM.Name = "txt_MachineRPM"
        Me.txt_MachineRPM.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineRPM.Size = New System.Drawing.Size(410, 26)
        Me.txt_MachineRPM.TabIndex = 6
        Me.txt_MachineRPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MachineRPM.TextBoxAutoComplete = False
        Me.txt_MachineRPM.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineRPM.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineRPM.TextEnabled = True
        Me.txt_MachineRPM.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineRPM.TextMaxLength = 32767
        Me.txt_MachineRPM.TextMultiLine = False
        Me.txt_MachineRPM.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineRPM.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineRPM.UseSendTab = True
        '
        'txt_RotationOnceProduction
        '
        Me.txt_RotationOnceProduction.BackYesno = False
        Me.txt_RotationOnceProduction.ButtonTitle = Nothing
        Me.txt_RotationOnceProduction.Code = Nothing
        Me.txt_RotationOnceProduction.Data = Nothing
        Me.txt_RotationOnceProduction.DataDecimal = 0
        Me.txt_RotationOnceProduction.DataLen = 0
        Me.txt_RotationOnceProduction.DataValue = 1
        Me.txt_RotationOnceProduction.FormatDecimal = 0
        Me.txt_RotationOnceProduction.FormatValue = False
        Me.txt_RotationOnceProduction.Lable2BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_RotationOnceProduction.Lable2Enabled = True
        Me.txt_RotationOnceProduction.Lable2Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationOnceProduction.Lable2ForeColor = System.Drawing.Color.Black
        Me.txt_RotationOnceProduction.Lable2Title = "KG"
        Me.txt_RotationOnceProduction.Lable2Width = 85
        Me.txt_RotationOnceProduction.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_RotationOnceProduction.LableEnabled = True
        Me.txt_RotationOnceProduction.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationOnceProduction.LableForeColor = System.Drawing.Color.Black
        Me.txt_RotationOnceProduction.LableTitle = "Production Once"
        Me.txt_RotationOnceProduction.Layoutpercent = New Decimal(New Integer() {425, 0, 0, 196608})
        Me.txt_RotationOnceProduction.Location = New System.Drawing.Point(1, 117)
        Me.txt_RotationOnceProduction.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_RotationOnceProduction.Name = "txt_RotationOnceProduction"
        Me.txt_RotationOnceProduction.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_RotationOnceProduction.Size = New System.Drawing.Size(410, 26)
        Me.txt_RotationOnceProduction.TabIndex = 7
        Me.txt_RotationOnceProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_RotationOnceProduction.TextBoxAutoComplete = False
        Me.txt_RotationOnceProduction.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_RotationOnceProduction.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationOnceProduction.TextEnabled = True
        Me.txt_RotationOnceProduction.TextForeColor = System.Drawing.Color.Empty
        Me.txt_RotationOnceProduction.TextMaxLength = 32767
        Me.txt_RotationOnceProduction.TextMultiLine = False
        Me.txt_RotationOnceProduction.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_RotationOnceProduction.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_RotationOnceProduction.UseSendTab = True
        '
        'txt_RotationOnceTimeProduction
        '
        Me.txt_RotationOnceTimeProduction.BackYesno = False
        Me.txt_RotationOnceTimeProduction.ButtonTitle = Nothing
        Me.txt_RotationOnceTimeProduction.Code = Nothing
        Me.txt_RotationOnceTimeProduction.Data = Nothing
        Me.txt_RotationOnceTimeProduction.DataDecimal = 0
        Me.txt_RotationOnceTimeProduction.DataLen = 0
        Me.txt_RotationOnceTimeProduction.DataValue = 1
        Me.txt_RotationOnceTimeProduction.FormatDecimal = 0
        Me.txt_RotationOnceTimeProduction.FormatValue = False
        Me.txt_RotationOnceTimeProduction.Lable2BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_RotationOnceTimeProduction.Lable2Enabled = True
        Me.txt_RotationOnceTimeProduction.Lable2Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationOnceTimeProduction.Lable2ForeColor = System.Drawing.Color.Black
        Me.txt_RotationOnceTimeProduction.Lable2Title = "MINUTE"
        Me.txt_RotationOnceTimeProduction.Lable2Width = 85
        Me.txt_RotationOnceTimeProduction.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_RotationOnceTimeProduction.LableEnabled = True
        Me.txt_RotationOnceTimeProduction.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationOnceTimeProduction.LableForeColor = System.Drawing.Color.Black
        Me.txt_RotationOnceTimeProduction.LableTitle = "Production Minute"
        Me.txt_RotationOnceTimeProduction.Layoutpercent = New Decimal(New Integer() {425, 0, 0, 196608})
        Me.txt_RotationOnceTimeProduction.Location = New System.Drawing.Point(413, 145)
        Me.txt_RotationOnceTimeProduction.Margin = New System.Windows.Forms.Padding(413, 1, 1, 1)
        Me.txt_RotationOnceTimeProduction.Name = "txt_RotationOnceTimeProduction"
        Me.txt_RotationOnceTimeProduction.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_RotationOnceTimeProduction.Size = New System.Drawing.Size(410, 26)
        Me.txt_RotationOnceTimeProduction.TabIndex = 8
        Me.txt_RotationOnceTimeProduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_RotationOnceTimeProduction.TextBoxAutoComplete = False
        Me.txt_RotationOnceTimeProduction.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_RotationOnceTimeProduction.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RotationOnceTimeProduction.TextEnabled = True
        Me.txt_RotationOnceTimeProduction.TextForeColor = System.Drawing.Color.Empty
        Me.txt_RotationOnceTimeProduction.TextMaxLength = 32767
        Me.txt_RotationOnceTimeProduction.TextMultiLine = False
        Me.txt_RotationOnceTimeProduction.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_RotationOnceTimeProduction.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_RotationOnceTimeProduction.UseSendTab = True
        '
        'txt_GroupMachine
        '
        Me.txt_GroupMachine.BackYesno = False
        Me.txt_GroupMachine.ButtonTitle = Nothing
        Me.txt_GroupMachine.Code = Nothing
        Me.txt_GroupMachine.Data = ""
        Me.txt_GroupMachine.DataDecimal = 0
        Me.txt_GroupMachine.DataLen = 0
        Me.txt_GroupMachine.DataValue = 1
        Me.txt_GroupMachine.FormatDecimal = 0
        Me.txt_GroupMachine.FormatValue = False
        Me.txt_GroupMachine.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_GroupMachine.LableEnabled = True
        Me.txt_GroupMachine.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_GroupMachine.LableForeColor = System.Drawing.Color.Empty
        Me.txt_GroupMachine.LableTitle = "Group Machine"
        Me.txt_GroupMachine.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_GroupMachine.Location = New System.Drawing.Point(1, 173)
        Me.txt_GroupMachine.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GroupMachine.Name = "txt_GroupMachine"
        Me.txt_GroupMachine.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_GroupMachine.Size = New System.Drawing.Size(410, 26)
        Me.txt_GroupMachine.TabIndex = 9
        Me.txt_GroupMachine.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_GroupMachine.TextBoxAutoComplete = False
        Me.txt_GroupMachine.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_GroupMachine.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_GroupMachine.TextEnabled = True
        Me.txt_GroupMachine.TextForeColor = System.Drawing.Color.Empty
        Me.txt_GroupMachine.TextMaxLength = 32767
        Me.txt_GroupMachine.TextMultiLine = False
        Me.txt_GroupMachine.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_GroupMachine.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_GroupMachine.UseSendTab = True
        '
        'txt_DisplaySeq
        '
        Me.txt_DisplaySeq.BackYesno = False
        Me.txt_DisplaySeq.ButtonTitle = Nothing
        Me.txt_DisplaySeq.Code = Nothing
        Me.txt_DisplaySeq.Data = ""
        Me.txt_DisplaySeq.DataDecimal = 0
        Me.txt_DisplaySeq.DataLen = 0
        Me.txt_DisplaySeq.DataValue = 1
        Me.txt_DisplaySeq.FormatDecimal = 0
        Me.txt_DisplaySeq.FormatValue = False
        Me.txt_DisplaySeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DisplaySeq.LableEnabled = True
        Me.txt_DisplaySeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DisplaySeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DisplaySeq.LableTitle = "Disply Sequence"
        Me.txt_DisplaySeq.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_DisplaySeq.Location = New System.Drawing.Point(413, 173)
        Me.txt_DisplaySeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DisplaySeq.Name = "txt_DisplaySeq"
        Me.txt_DisplaySeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DisplaySeq.Size = New System.Drawing.Size(410, 26)
        Me.txt_DisplaySeq.TabIndex = 10
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
        'txt_VerticalPosition
        '
        Me.txt_VerticalPosition.BackYesno = False
        Me.txt_VerticalPosition.ButtonTitle = Nothing
        Me.txt_VerticalPosition.Code = Nothing
        Me.txt_VerticalPosition.Data = ""
        Me.txt_VerticalPosition.DataDecimal = 0
        Me.txt_VerticalPosition.DataLen = 0
        Me.txt_VerticalPosition.DataValue = 1
        Me.txt_VerticalPosition.FormatDecimal = 0
        Me.txt_VerticalPosition.FormatValue = False
        Me.txt_VerticalPosition.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VerticalPosition.LableEnabled = True
        Me.txt_VerticalPosition.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerticalPosition.LableForeColor = System.Drawing.Color.Empty
        Me.txt_VerticalPosition.LableTitle = "Vertical Line"
        Me.txt_VerticalPosition.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_VerticalPosition.Location = New System.Drawing.Point(1, 201)
        Me.txt_VerticalPosition.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_VerticalPosition.Name = "txt_VerticalPosition"
        Me.txt_VerticalPosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VerticalPosition.Size = New System.Drawing.Size(410, 26)
        Me.txt_VerticalPosition.TabIndex = 11
        Me.txt_VerticalPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VerticalPosition.TextBoxAutoComplete = False
        Me.txt_VerticalPosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VerticalPosition.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerticalPosition.TextEnabled = True
        Me.txt_VerticalPosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VerticalPosition.TextMaxLength = 32767
        Me.txt_VerticalPosition.TextMultiLine = False
        Me.txt_VerticalPosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VerticalPosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VerticalPosition.UseSendTab = True
        '
        'txt_HorizontalPosition
        '
        Me.txt_HorizontalPosition.BackYesno = False
        Me.txt_HorizontalPosition.ButtonTitle = Nothing
        Me.txt_HorizontalPosition.Code = Nothing
        Me.txt_HorizontalPosition.Data = ""
        Me.txt_HorizontalPosition.DataDecimal = 0
        Me.txt_HorizontalPosition.DataLen = 0
        Me.txt_HorizontalPosition.DataValue = 1
        Me.txt_HorizontalPosition.FormatDecimal = 0
        Me.txt_HorizontalPosition.FormatValue = False
        Me.txt_HorizontalPosition.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_HorizontalPosition.LableEnabled = True
        Me.txt_HorizontalPosition.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_HorizontalPosition.LableForeColor = System.Drawing.Color.Empty
        Me.txt_HorizontalPosition.LableTitle = "Horizon Line"
        Me.txt_HorizontalPosition.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_HorizontalPosition.Location = New System.Drawing.Point(413, 201)
        Me.txt_HorizontalPosition.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_HorizontalPosition.Name = "txt_HorizontalPosition"
        Me.txt_HorizontalPosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_HorizontalPosition.Size = New System.Drawing.Size(410, 26)
        Me.txt_HorizontalPosition.TabIndex = 12
        Me.txt_HorizontalPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_HorizontalPosition.TextBoxAutoComplete = False
        Me.txt_HorizontalPosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_HorizontalPosition.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_HorizontalPosition.TextEnabled = True
        Me.txt_HorizontalPosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_HorizontalPosition.TextMaxLength = 32767
        Me.txt_HorizontalPosition.TextMultiLine = False
        Me.txt_HorizontalPosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_HorizontalPosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_HorizontalPosition.UseSendTab = True
        '
        'lbl_use
        '
        Me.lbl_use.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_use.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_use.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_use.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_use.ButtonTitle = Nothing
        Me.lbl_use.Code = ""
        Me.lbl_use.Data = ""
        Me.lbl_use.DTDec = 0
        Me.lbl_use.DTLen = 0
        Me.lbl_use.DTValue = 0
        Me.lbl_use.Location = New System.Drawing.Point(1, 229)
        Me.lbl_use.Margin = New System.Windows.Forms.Padding(1)
        Me.lbl_use.Name = "lbl_use"
        Me.lbl_use.NoClear = False
        Me.lbl_use.Size = New System.Drawing.Size(137, 29)
        Me.lbl_use.TabIndex = 10
        Me.lbl_use.Tag = ""
        Me.lbl_use.Text = "Check Final"
        Me.lbl_use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.chk_CheckFinalProcess2)
        Me.PeacePanel1.Controls.Add(Me.chk_CheckFinalProcess1)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(139, 229)
        Me.PeacePanel1.Margin = New System.Windows.Forms.Padding(0, 1, 156, 1)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(116, 29)
        Me.PeacePanel1.TabIndex = 13
        Me.PeacePanel1.Tag = ""
        '
        'chk_CheckFinalProcess2
        '
        Me.chk_CheckFinalProcess2.AutoSize = True
        Me.chk_CheckFinalProcess2.ButtonTitle = Nothing
        Me.chk_CheckFinalProcess2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckFinalProcess2.Location = New System.Drawing.Point(65, 5)
        Me.chk_CheckFinalProcess2.Name = "chk_CheckFinalProcess2"
        Me.chk_CheckFinalProcess2.Size = New System.Drawing.Size(41, 18)
        Me.chk_CheckFinalProcess2.TabIndex = 1
        Me.chk_CheckFinalProcess2.Text = "No"
        Me.chk_CheckFinalProcess2.UseVisualStyleBackColor = True
        '
        'chk_CheckFinalProcess1
        '
        Me.chk_CheckFinalProcess1.AutoSize = True
        Me.chk_CheckFinalProcess1.ButtonTitle = Nothing
        Me.chk_CheckFinalProcess1.Checked = True
        Me.chk_CheckFinalProcess1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckFinalProcess1.Location = New System.Drawing.Point(11, 5)
        Me.chk_CheckFinalProcess1.Name = "chk_CheckFinalProcess1"
        Me.chk_CheckFinalProcess1.Size = New System.Drawing.Size(45, 18)
        Me.chk_CheckFinalProcess1.TabIndex = 0
        Me.chk_CheckFinalProcess1.TabStop = True
        Me.chk_CheckFinalProcess1.Text = "Yes"
        Me.chk_CheckFinalProcess1.UseVisualStyleBackColor = True
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(412, 229)
        Me.PeaceLabel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(138, 29)
        Me.PeaceLabel1.TabIndex = 67
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "Check Process"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Controls.Add(Me.chk_CheckProcess2)
        Me.PeacePanel2.Controls.Add(Me.chk_CheckProcess1)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Location = New System.Drawing.Point(551, 229)
        Me.PeacePanel2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(130, 29)
        Me.PeacePanel2.TabIndex = 14
        Me.PeacePanel2.Tag = ""
        '
        'chk_CheckProcess2
        '
        Me.chk_CheckProcess2.AutoSize = True
        Me.chk_CheckProcess2.ButtonTitle = Nothing
        Me.chk_CheckProcess2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckProcess2.Location = New System.Drawing.Point(67, 5)
        Me.chk_CheckProcess2.Name = "chk_CheckProcess2"
        Me.chk_CheckProcess2.Size = New System.Drawing.Size(41, 18)
        Me.chk_CheckProcess2.TabIndex = 1
        Me.chk_CheckProcess2.Text = "No"
        Me.chk_CheckProcess2.UseVisualStyleBackColor = True
        '
        'chk_CheckProcess1
        '
        Me.chk_CheckProcess1.AutoSize = True
        Me.chk_CheckProcess1.ButtonTitle = Nothing
        Me.chk_CheckProcess1.Checked = True
        Me.chk_CheckProcess1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckProcess1.Location = New System.Drawing.Point(14, 5)
        Me.chk_CheckProcess1.Name = "chk_CheckProcess1"
        Me.chk_CheckProcess1.Size = New System.Drawing.Size(45, 18)
        Me.chk_CheckProcess1.TabIndex = 0
        Me.chk_CheckProcess1.TabStop = True
        Me.chk_CheckProcess1.Text = "Yes"
        Me.chk_CheckProcess1.UseVisualStyleBackColor = True
        '
        'txt_ChecK1
        '
        Me.txt_ChecK1.BackYesno = False
        Me.txt_ChecK1.ButtonTitle = Nothing
        Me.txt_ChecK1.Code = Nothing
        Me.txt_ChecK1.Data = ""
        Me.txt_ChecK1.DataDecimal = 0
        Me.txt_ChecK1.DataLen = 1
        Me.txt_ChecK1.DataValue = 0
        Me.txt_ChecK1.FormatDecimal = 0
        Me.txt_ChecK1.FormatValue = False
        Me.txt_ChecK1.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ChecK1.LableEnabled = True
        Me.txt_ChecK1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ChecK1.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ChecK1.LableTitle = "Check 1"
        Me.txt_ChecK1.Layoutpercent = New Decimal(New Integer() {73, 0, 0, 131072})
        Me.txt_ChecK1.Location = New System.Drawing.Point(1, 260)
        Me.txt_ChecK1.Margin = New System.Windows.Forms.Padding(1, 1, 221, 1)
        Me.txt_ChecK1.Name = "txt_ChecK1"
        Me.txt_ChecK1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ChecK1.Size = New System.Drawing.Size(190, 26)
        Me.txt_ChecK1.TabIndex = 15
        Me.txt_ChecK1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ChecK1.TextBoxAutoComplete = False
        Me.txt_ChecK1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ChecK1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ChecK1.TextEnabled = True
        Me.txt_ChecK1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ChecK1.TextMaxLength = 32767
        Me.txt_ChecK1.TextMultiLine = False
        Me.txt_ChecK1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ChecK1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ChecK1.UseSendTab = True
        '
        'txt_ChecK2
        '
        Me.txt_ChecK2.BackYesno = False
        Me.txt_ChecK2.ButtonTitle = Nothing
        Me.txt_ChecK2.Code = Nothing
        Me.txt_ChecK2.Data = ""
        Me.txt_ChecK2.DataDecimal = 0
        Me.txt_ChecK2.DataLen = 1
        Me.txt_ChecK2.DataValue = 0
        Me.txt_ChecK2.FormatDecimal = 0
        Me.txt_ChecK2.FormatValue = False
        Me.txt_ChecK2.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ChecK2.LableEnabled = True
        Me.txt_ChecK2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ChecK2.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ChecK2.LableTitle = "Chek 2"
        Me.txt_ChecK2.Layoutpercent = New Decimal(New Integer() {73, 0, 0, 131072})
        Me.txt_ChecK2.Location = New System.Drawing.Point(413, 260)
        Me.txt_ChecK2.Margin = New System.Windows.Forms.Padding(1, 1, 221, 1)
        Me.txt_ChecK2.Name = "txt_ChecK2"
        Me.txt_ChecK2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ChecK2.Size = New System.Drawing.Size(190, 26)
        Me.txt_ChecK2.TabIndex = 16
        Me.txt_ChecK2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ChecK2.TextBoxAutoComplete = False
        Me.txt_ChecK2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ChecK2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ChecK2.TextEnabled = True
        Me.txt_ChecK2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ChecK2.TextMaxLength = 32767
        Me.txt_ChecK2.TextMultiLine = False
        Me.txt_ChecK2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ChecK2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ChecK2.UseSendTab = True
        '
        'txt_cdSubProcess
        '
        Me.txt_cdSubProcess.BackYesno = False
        Me.txt_cdSubProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSubProcess.ButtonEnabled = True
        Me.txt_cdSubProcess.ButtonFont = Nothing
        Me.txt_cdSubProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.ButtonName = ""
        Me.txt_cdSubProcess.ButtonTitle = "Prod Process"
        Me.txt_cdSubProcess.Code = ""
        Me.txt_cdSubProcess.Data = ""
        Me.txt_cdSubProcess.DataDecimal = 0
        Me.txt_cdSubProcess.DataLen = 0
        Me.txt_cdSubProcess.DataValue = 1
        Me.txt_cdSubProcess.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSubProcess.Location = New System.Drawing.Point(1, 33)
        Me.txt_cdSubProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSubProcess.Name = "txt_cdSubProcess"
        Me.txt_cdSubProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSubProcess.Size = New System.Drawing.Size(410, 26)
        Me.txt_cdSubProcess.TabIndex = 1
        Me.txt_cdSubProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSubProcess.TextBoxAutoComplete = True
        Me.txt_cdSubProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSubProcess.TextEnabled = True
        Me.txt_cdSubProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextMaxLength = 32767
        Me.txt_cdSubProcess.TextMultiLine = False
        Me.txt_cdSubProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSubProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSubProcess.UseSendTab = True
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
        Me.PeaceLabel2.Location = New System.Drawing.Point(1, 288)
        Me.PeaceLabel2.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel2.Name = "PeaceLabel2"
        Me.PeaceLabel2.NoClear = False
        Me.PeaceLabel2.Size = New System.Drawing.Size(137, 25)
        Me.PeaceLabel2.TabIndex = 71
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
        Me.PeacePanel3.Location = New System.Drawing.Point(139, 288)
        Me.PeacePanel3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(130, 25)
        Me.PeacePanel3.TabIndex = 17
        Me.PeacePanel3.Tag = ""
        '
        'chk_checkUse2
        '
        Me.chk_checkUse2.AutoSize = True
        Me.chk_checkUse2.ButtonTitle = Nothing
        Me.chk_checkUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_checkUse2.Location = New System.Drawing.Point(77, 6)
        Me.chk_checkUse2.Name = "chk_checkUse2"
        Me.chk_checkUse2.Size = New System.Drawing.Size(41, 18)
        Me.chk_checkUse2.TabIndex = 1
        Me.chk_checkUse2.Text = "No"
        Me.chk_checkUse2.UseVisualStyleBackColor = True
        '
        'chk_checkUse1
        '
        Me.chk_checkUse1.AutoSize = True
        Me.chk_checkUse1.ButtonTitle = Nothing
        Me.chk_checkUse1.Checked = True
        Me.chk_checkUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_checkUse1.Location = New System.Drawing.Point(17, 5)
        Me.chk_checkUse1.Name = "chk_checkUse1"
        Me.chk_checkUse1.Size = New System.Drawing.Size(45, 18)
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
        Me.txt_Remark.Location = New System.Drawing.Point(2, 316)
        Me.txt_Remark.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Remark.Size = New System.Drawing.Size(821, 67)
        Me.txt_Remark.TabIndex = 18
        Me.txt_Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Remark.TextBoxAutoComplete = False
        Me.txt_Remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.TextEnabled = True
        Me.txt_Remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextMaxLength = 32767
        Me.txt_Remark.TextMultiLine = False
        Me.txt_Remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Remark.UseSendTab = True
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
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 438)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(838, 39)
        Me.Frame4.TabIndex = 1
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
        Me.cmd_AttachID.Location = New System.Drawing.Point(348, 2)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 1
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_DEL.ButtonTitle = Nothing
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 16
        Me.cmd_DEL.Location = New System.Drawing.Point(2, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(143, 35)
        Me.cmd_DEL.TabIndex = 0
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 0
        Me.cmd_Cancel.Location = New System.Drawing.Point(693, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 3
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 0
        Me.cmd_OK.Location = New System.Drawing.Point(551, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 2
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.frm_Condition, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(844, 480)
        Me.TableLayoutPanel1.TabIndex = 44
        '
        'ISUD7155A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(844, 480)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "ISUD7155A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MACHINE CODE PROCESSING (ISUD7155A)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.Block1.ResumeLayout(False)
        Me.Bloack2.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        Me.PeacePanel2.PerformLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel3.PerformLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel3 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_MachineCode As PSMGlobal.SelectLabelText
    Friend WithEvents Block1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_cdMachineType As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Bloack2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_MachineName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MachineNameSimply As PSMGlobal.SelectLabelText
    Friend WithEvents txt_GroupMachine As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DisplaySeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ChecK1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ChecK2 As PSMGlobal.SelectLabelText
    Friend WithEvents lbl_use As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents chk_CheckFinalProcess2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckFinalProcess1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents chk_CheckProcess2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckProcess1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_HorizontalPosition As PSMGlobal.SelectLabelText
    Friend WithEvents txt_VerticalPosition As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdSubProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeaceLabel2 As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents chk_checkUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_checkUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_Remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MachineCapacity As PSMGlobal.SelectLabelTextLable
    Friend WithEvents txt_RotationDayProduction As PSMGlobal.SelectLabelTextLable
    Friend WithEvents txt_MachineRPM As PSMGlobal.SelectLabelTextLable
    Friend WithEvents txt_RotationOnceProduction As PSMGlobal.SelectLabelTextLable
    Friend WithEvents txt_RotationOnceTimeProduction As PSMGlobal.SelectLabelTextLable
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
End Class
