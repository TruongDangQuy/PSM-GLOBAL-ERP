<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7103A
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
        Me.Block1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_TypeCode = New PSMGlobal.SelectLabelText()
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdComponentType = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Standard4 = New PSMGlobal.SelectLabelText()
        Me.txt_Standard5 = New PSMGlobal.SelectLabelText()
        Me.txt_TypeName = New PSMGlobal.SelectLabelText()
        Me.txt_TypeSimpleName = New PSMGlobal.SelectLabelText()
        Me.txt_Standard1 = New PSMGlobal.SelectLabelText()
        Me.txt_Standard2 = New PSMGlobal.SelectLabelText()
        Me.txt_Standard3 = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_cdTypeCode = New PSMGlobal.SelectPeaceHLPButton()
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
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
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Controls.Add(Me.txt_cdTypeCode)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 38)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(842, 197)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.txt_TypeCode)
        Me.Block1.Data = ""
        Me.Block1.Location = New System.Drawing.Point(7, 5)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(341, 38)
        Me.Block1.TabIndex = 0
        Me.Block1.Tag = ""
        '
        'txt_TypeCode
        '
        Me.txt_TypeCode.BackYesno = False
        Me.txt_TypeCode.ButtonTitle = Nothing
        Me.txt_TypeCode.Code = Nothing
        Me.txt_TypeCode.Data = ""
        Me.txt_TypeCode.DataDecimal = 0
        Me.txt_TypeCode.DataLen = 0
        Me.txt_TypeCode.DataValue = 0
        Me.txt_TypeCode.FormatDecimal = 0
        Me.txt_TypeCode.FormatValue = False
        Me.txt_TypeCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TypeCode.LableEnabled = True
        Me.txt_TypeCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_TypeCode.LableForeColor = System.Drawing.Color.Blue
        Me.txt_TypeCode.LableTitle = "Type Code"
        Me.txt_TypeCode.Layoutpercent = New Decimal(New Integer() {415, 0, 0, 196608})
        Me.txt_TypeCode.Location = New System.Drawing.Point(5, 4)
        Me.txt_TypeCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_TypeCode.Name = "txt_TypeCode"
        Me.txt_TypeCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TypeCode.Size = New System.Drawing.Size(329, 27)
        Me.txt_TypeCode.TabIndex = 0
        Me.txt_TypeCode.TabStop = False
        Me.txt_TypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TypeCode.TextBoxAutoComplete = False
        Me.txt_TypeCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TypeCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TypeCode.TextEnabled = False
        Me.txt_TypeCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TypeCode.TextMaxLength = 32767
        Me.txt_TypeCode.TextMultiLine = False
        Me.txt_TypeCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TypeCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TypeCode.UseSendTab = True
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Code = ""
        Me.Bloack2.Controls.Add(Me.txt_cdComponentType)
        Me.Bloack2.Controls.Add(Me.txt_Standard4)
        Me.Bloack2.Controls.Add(Me.txt_Standard5)
        Me.Bloack2.Controls.Add(Me.txt_TypeName)
        Me.Bloack2.Controls.Add(Me.txt_TypeSimpleName)
        Me.Bloack2.Controls.Add(Me.txt_Standard1)
        Me.Bloack2.Controls.Add(Me.txt_Standard2)
        Me.Bloack2.Controls.Add(Me.txt_Standard3)
        Me.Bloack2.Controls.Add(Me.tit_Use)
        Me.Bloack2.Controls.Add(Me.Panel5)
        Me.Bloack2.Data = ""
        Me.Bloack2.Location = New System.Drawing.Point(3, 43)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(834, 148)
        Me.Bloack2.TabIndex = 40
        Me.Bloack2.Tag = ""
        '
        'txt_cdComponentType
        '
        Me.txt_cdComponentType.BackYesno = False
        Me.txt_cdComponentType.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdComponentType.ButtonEnabled = True
        Me.txt_cdComponentType.ButtonFont = Nothing
        Me.txt_cdComponentType.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdComponentType.ButtonName = ""
        Me.txt_cdComponentType.ButtonTitle = "Group Type"
        Me.txt_cdComponentType.Code = ""
        Me.txt_cdComponentType.Data = ""
        Me.txt_cdComponentType.DataDecimal = 0
        Me.txt_cdComponentType.DataLen = 0
        Me.txt_cdComponentType.DataValue = 1
        Me.txt_cdComponentType.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdComponentType.Location = New System.Drawing.Point(5, 3)
        Me.txt_cdComponentType.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdComponentType.Name = "txt_cdComponentType"
        Me.txt_cdComponentType.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdComponentType.Size = New System.Drawing.Size(410, 27)
        Me.txt_cdComponentType.TabIndex = 1
        Me.txt_cdComponentType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdComponentType.TextBoxAutoComplete = True
        Me.txt_cdComponentType.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdComponentType.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdComponentType.TextEnabled = True
        Me.txt_cdComponentType.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdComponentType.TextMaxLength = 32767
        Me.txt_cdComponentType.TextMultiLine = False
        Me.txt_cdComponentType.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdComponentType.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdComponentType.UseSendTab = True
        '
        'txt_Standard4
        '
        Me.txt_Standard4.BackYesno = False
        Me.txt_Standard4.ButtonTitle = Nothing
        Me.txt_Standard4.Code = Nothing
        Me.txt_Standard4.Data = ""
        Me.txt_Standard4.DataDecimal = 0
        Me.txt_Standard4.DataLen = 0
        Me.txt_Standard4.DataValue = 0
        Me.txt_Standard4.FormatDecimal = 0
        Me.txt_Standard4.FormatValue = False
        Me.txt_Standard4.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Standard4.LableEnabled = True
        Me.txt_Standard4.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard4.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Standard4.LableTitle = "Standard 4"
        Me.txt_Standard4.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Standard4.Location = New System.Drawing.Point(419, 89)
        Me.txt_Standard4.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Standard4.Name = "txt_Standard4"
        Me.txt_Standard4.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Standard4.Size = New System.Drawing.Size(410, 26)
        Me.txt_Standard4.TabIndex = 7
        Me.txt_Standard4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Standard4.TextBoxAutoComplete = False
        Me.txt_Standard4.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Standard4.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard4.TextEnabled = True
        Me.txt_Standard4.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Standard4.TextMaxLength = 32767
        Me.txt_Standard4.TextMultiLine = False
        Me.txt_Standard4.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Standard4.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Standard4.UseSendTab = True
        '
        'txt_Standard5
        '
        Me.txt_Standard5.BackYesno = False
        Me.txt_Standard5.ButtonTitle = Nothing
        Me.txt_Standard5.Code = Nothing
        Me.txt_Standard5.Data = ""
        Me.txt_Standard5.DataDecimal = 0
        Me.txt_Standard5.DataLen = 0
        Me.txt_Standard5.DataValue = 0
        Me.txt_Standard5.FormatDecimal = 0
        Me.txt_Standard5.FormatValue = False
        Me.txt_Standard5.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Standard5.LableEnabled = True
        Me.txt_Standard5.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard5.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Standard5.LableTitle = "Standard 5"
        Me.txt_Standard5.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Standard5.Location = New System.Drawing.Point(419, 119)
        Me.txt_Standard5.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Standard5.Name = "txt_Standard5"
        Me.txt_Standard5.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Standard5.Size = New System.Drawing.Size(410, 26)
        Me.txt_Standard5.TabIndex = 8
        Me.txt_Standard5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Standard5.TextBoxAutoComplete = False
        Me.txt_Standard5.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Standard5.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard5.TextEnabled = True
        Me.txt_Standard5.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Standard5.TextMaxLength = 32767
        Me.txt_Standard5.TextMultiLine = False
        Me.txt_Standard5.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Standard5.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Standard5.UseSendTab = True
        '
        'txt_TypeName
        '
        Me.txt_TypeName.BackYesno = False
        Me.txt_TypeName.ButtonTitle = Nothing
        Me.txt_TypeName.Code = Nothing
        Me.txt_TypeName.Data = ""
        Me.txt_TypeName.DataDecimal = 0
        Me.txt_TypeName.DataLen = 0
        Me.txt_TypeName.DataValue = 1
        Me.txt_TypeName.FormatDecimal = 0
        Me.txt_TypeName.FormatValue = False
        Me.txt_TypeName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TypeName.LableEnabled = True
        Me.txt_TypeName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TypeName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TypeName.LableTitle = "Type Name"
        Me.txt_TypeName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_TypeName.Location = New System.Drawing.Point(5, 32)
        Me.txt_TypeName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TypeName.Name = "txt_TypeName"
        Me.txt_TypeName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TypeName.Size = New System.Drawing.Size(410, 27)
        Me.txt_TypeName.TabIndex = 2
        Me.txt_TypeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TypeName.TextBoxAutoComplete = False
        Me.txt_TypeName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TypeName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TypeName.TextEnabled = True
        Me.txt_TypeName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TypeName.TextMaxLength = 32767
        Me.txt_TypeName.TextMultiLine = False
        Me.txt_TypeName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TypeName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TypeName.UseSendTab = True
        '
        'txt_TypeSimpleName
        '
        Me.txt_TypeSimpleName.BackYesno = False
        Me.txt_TypeSimpleName.ButtonTitle = Nothing
        Me.txt_TypeSimpleName.Code = Nothing
        Me.txt_TypeSimpleName.Data = ""
        Me.txt_TypeSimpleName.DataDecimal = 0
        Me.txt_TypeSimpleName.DataLen = 0
        Me.txt_TypeSimpleName.DataValue = 0
        Me.txt_TypeSimpleName.FormatDecimal = 0
        Me.txt_TypeSimpleName.FormatValue = False
        Me.txt_TypeSimpleName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TypeSimpleName.LableEnabled = True
        Me.txt_TypeSimpleName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TypeSimpleName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TypeSimpleName.LableTitle = "Simple Name"
        Me.txt_TypeSimpleName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_TypeSimpleName.Location = New System.Drawing.Point(5, 61)
        Me.txt_TypeSimpleName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TypeSimpleName.Name = "txt_TypeSimpleName"
        Me.txt_TypeSimpleName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TypeSimpleName.Size = New System.Drawing.Size(410, 27)
        Me.txt_TypeSimpleName.TabIndex = 3
        Me.txt_TypeSimpleName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TypeSimpleName.TextBoxAutoComplete = False
        Me.txt_TypeSimpleName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TypeSimpleName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TypeSimpleName.TextEnabled = True
        Me.txt_TypeSimpleName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TypeSimpleName.TextMaxLength = 32767
        Me.txt_TypeSimpleName.TextMultiLine = False
        Me.txt_TypeSimpleName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TypeSimpleName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TypeSimpleName.UseSendTab = True
        '
        'txt_Standard1
        '
        Me.txt_Standard1.BackYesno = False
        Me.txt_Standard1.ButtonTitle = Nothing
        Me.txt_Standard1.Code = Nothing
        Me.txt_Standard1.Data = ""
        Me.txt_Standard1.DataDecimal = 0
        Me.txt_Standard1.DataLen = 0
        Me.txt_Standard1.DataValue = 0
        Me.txt_Standard1.FormatDecimal = 0
        Me.txt_Standard1.FormatValue = False
        Me.txt_Standard1.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Standard1.LableEnabled = True
        Me.txt_Standard1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard1.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Standard1.LableTitle = "Standard 1"
        Me.txt_Standard1.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Standard1.Location = New System.Drawing.Point(419, 3)
        Me.txt_Standard1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Standard1.Name = "txt_Standard1"
        Me.txt_Standard1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Standard1.Size = New System.Drawing.Size(410, 25)
        Me.txt_Standard1.TabIndex = 4
        Me.txt_Standard1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Standard1.TextBoxAutoComplete = False
        Me.txt_Standard1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Standard1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard1.TextEnabled = True
        Me.txt_Standard1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Standard1.TextMaxLength = 32767
        Me.txt_Standard1.TextMultiLine = False
        Me.txt_Standard1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Standard1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Standard1.UseSendTab = True
        '
        'txt_Standard2
        '
        Me.txt_Standard2.BackYesno = False
        Me.txt_Standard2.ButtonTitle = Nothing
        Me.txt_Standard2.Code = Nothing
        Me.txt_Standard2.Data = ""
        Me.txt_Standard2.DataDecimal = 0
        Me.txt_Standard2.DataLen = 0
        Me.txt_Standard2.DataValue = 0
        Me.txt_Standard2.FormatDecimal = 0
        Me.txt_Standard2.FormatValue = False
        Me.txt_Standard2.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Standard2.LableEnabled = True
        Me.txt_Standard2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard2.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Standard2.LableTitle = "Standard 2"
        Me.txt_Standard2.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Standard2.Location = New System.Drawing.Point(419, 31)
        Me.txt_Standard2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Standard2.Name = "txt_Standard2"
        Me.txt_Standard2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Standard2.Size = New System.Drawing.Size(410, 26)
        Me.txt_Standard2.TabIndex = 5
        Me.txt_Standard2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Standard2.TextBoxAutoComplete = False
        Me.txt_Standard2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Standard2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard2.TextEnabled = True
        Me.txt_Standard2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Standard2.TextMaxLength = 32767
        Me.txt_Standard2.TextMultiLine = False
        Me.txt_Standard2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Standard2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Standard2.UseSendTab = True
        '
        'txt_Standard3
        '
        Me.txt_Standard3.BackYesno = False
        Me.txt_Standard3.ButtonTitle = Nothing
        Me.txt_Standard3.Code = Nothing
        Me.txt_Standard3.Data = ""
        Me.txt_Standard3.DataDecimal = 0
        Me.txt_Standard3.DataLen = 0
        Me.txt_Standard3.DataValue = 0
        Me.txt_Standard3.FormatDecimal = 0
        Me.txt_Standard3.FormatValue = False
        Me.txt_Standard3.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Standard3.LableEnabled = True
        Me.txt_Standard3.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard3.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Standard3.LableTitle = "Standard 3"
        Me.txt_Standard3.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Standard3.Location = New System.Drawing.Point(419, 61)
        Me.txt_Standard3.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Standard3.Name = "txt_Standard3"
        Me.txt_Standard3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Standard3.Size = New System.Drawing.Size(410, 26)
        Me.txt_Standard3.TabIndex = 6
        Me.txt_Standard3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Standard3.TextBoxAutoComplete = False
        Me.txt_Standard3.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Standard3.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Standard3.TextEnabled = True
        Me.txt_Standard3.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Standard3.TextMaxLength = 32767
        Me.txt_Standard3.TextMultiLine = False
        Me.txt_Standard3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Standard3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Standard3.UseSendTab = True
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
        Me.tit_Use.Location = New System.Drawing.Point(5, 119)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(138, 25)
        Me.tit_Use.TabIndex = 17
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
        Me.Panel5.Location = New System.Drawing.Point(145, 119)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(223, 25)
        Me.Panel5.TabIndex = 9
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.AutoSize = True
        Me.rad_CheckUse2.ButtonTitle = Nothing
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(115, 4)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(41, 17)
        Me.rad_CheckUse2.TabIndex = 1
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.AutoSize = True
        Me.rad_CheckUse1.ButtonTitle = Nothing
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(45, 17)
        Me.rad_CheckUse1.TabIndex = 0
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'txt_cdTypeCode
        '
        Me.txt_cdTypeCode.BackYesno = False
        Me.txt_cdTypeCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdTypeCode.ButtonEnabled = True
        Me.txt_cdTypeCode.ButtonFont = Nothing
        Me.txt_cdTypeCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdTypeCode.ButtonName = ""
        Me.txt_cdTypeCode.ButtonTitle = "Type Code"
        Me.txt_cdTypeCode.Code = ""
        Me.txt_cdTypeCode.Data = ""
        Me.txt_cdTypeCode.DataDecimal = 0
        Me.txt_cdTypeCode.DataLen = 0
        Me.txt_cdTypeCode.DataValue = 1
        Me.txt_cdTypeCode.Enabled = False
        Me.txt_cdTypeCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdTypeCode.Location = New System.Drawing.Point(422, 9)
        Me.txt_cdTypeCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdTypeCode.Name = "txt_cdTypeCode"
        Me.txt_cdTypeCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdTypeCode.Size = New System.Drawing.Size(410, 27)
        Me.txt_cdTypeCode.TabIndex = 1
        Me.txt_cdTypeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdTypeCode.TextBoxAutoComplete = False
        Me.txt_cdTypeCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdTypeCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdTypeCode.TextEnabled = True
        Me.txt_cdTypeCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdTypeCode.TextMaxLength = 32767
        Me.txt_cdTypeCode.TextMultiLine = False
        Me.txt_cdTypeCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdTypeCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdTypeCode.UseSendTab = True
        '
        'ISUD7103A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(842, 235)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.Name = "ISUD7103A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TYPE CODE PROCESSING (ISUD7103A)"
        Me.Controls.SetChildIndex(Me.frm_Condition, 0)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block1.ResumeLayout(False)
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bloack2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Block1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_TypeCode As PSMGlobal.SelectLabelText
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_TypeName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_TypeSimpleName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Standard1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Standard2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Standard3 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdTypeCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_Standard4 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Standard5 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdComponentType As PSMGlobal.SelectPeaceHLPButton

End Class
