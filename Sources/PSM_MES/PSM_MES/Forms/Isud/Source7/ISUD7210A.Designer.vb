<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7210A
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
        Me.txt_CartonCode = New PSMGlobal.SelectLabelText()
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_InchargeCarton = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_CTNetWeight = New PSMGlobal.SelectLabelText()
        Me.txt_CBM = New PSMGlobal.SelectLabelText()
        Me.txt_CartonType = New PSMGlobal.SelectLabelText()
        Me.txt_CTHeight = New PSMGlobal.SelectLabelText()
        Me.txt_CTLength = New PSMGlobal.SelectLabelText()
        Me.txt_CTWidth = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
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
        Me.frm_Condition.Controls.Add(Me.txt_CustomerCode)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 38)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(842, 204)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.txt_CartonCode)
        Me.Block1.Data = ""
        Me.Block1.Location = New System.Drawing.Point(7, 5)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(341, 38)
        Me.Block1.TabIndex = 0
        Me.Block1.Tag = ""
        '
        'txt_CartonCode
        '
        Me.txt_CartonCode.BackYesno = False
        Me.txt_CartonCode.ButtonTitle = Nothing
        Me.txt_CartonCode.Code = Nothing
        Me.txt_CartonCode.Data = ""
        Me.txt_CartonCode.DataDecimal = 0
        Me.txt_CartonCode.DataLen = 0
        Me.txt_CartonCode.DataValue = 0
        Me.txt_CartonCode.FormatDecimal = 0
        Me.txt_CartonCode.FormatValue = False
        Me.txt_CartonCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CartonCode.LableEnabled = True
        Me.txt_CartonCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CartonCode.LableForeColor = System.Drawing.Color.Blue
        Me.txt_CartonCode.LableTitle = "Carton Code"
        Me.txt_CartonCode.Layoutpercent = New Decimal(New Integer() {415, 0, 0, 196608})
        Me.txt_CartonCode.Location = New System.Drawing.Point(5, 4)
        Me.txt_CartonCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_CartonCode.Name = "txt_CartonCode"
        Me.txt_CartonCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CartonCode.Size = New System.Drawing.Size(329, 27)
        Me.txt_CartonCode.TabIndex = 0
        Me.txt_CartonCode.TabStop = False
        Me.txt_CartonCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CartonCode.TextBoxAutoComplete = False
        Me.txt_CartonCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CartonCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CartonCode.TextEnabled = False
        Me.txt_CartonCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CartonCode.TextMaxLength = 32767
        Me.txt_CartonCode.TextMultiLine = False
        Me.txt_CartonCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CartonCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CartonCode.UseSendTab = True
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Code = ""
        Me.Bloack2.Controls.Add(Me.txt_InchargeCarton)
        Me.Bloack2.Controls.Add(Me.txt_CTNetWeight)
        Me.Bloack2.Controls.Add(Me.txt_CBM)
        Me.Bloack2.Controls.Add(Me.txt_CartonType)
        Me.Bloack2.Controls.Add(Me.txt_CTHeight)
        Me.Bloack2.Controls.Add(Me.txt_CTLength)
        Me.Bloack2.Controls.Add(Me.txt_CTWidth)
        Me.Bloack2.Controls.Add(Me.tit_Use)
        Me.Bloack2.Controls.Add(Me.Panel5)
        Me.Bloack2.Data = ""
        Me.Bloack2.Location = New System.Drawing.Point(3, 43)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(834, 148)
        Me.Bloack2.TabIndex = 40
        Me.Bloack2.Tag = ""
        '
        'txt_InchargeCarton
        '
        Me.txt_InchargeCarton.BackYesno = False
        Me.txt_InchargeCarton.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeCarton.ButtonEnabled = True
        Me.txt_InchargeCarton.ButtonFont = Nothing
        Me.txt_InchargeCarton.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeCarton.ButtonName = ""
        Me.txt_InchargeCarton.ButtonTitle = "Incharge"
        Me.txt_InchargeCarton.Code = ""
        Me.txt_InchargeCarton.Data = ""
        Me.txt_InchargeCarton.DataDecimal = 0
        Me.txt_InchargeCarton.DataLen = 0
        Me.txt_InchargeCarton.DataValue = 1
        Me.txt_InchargeCarton.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_InchargeCarton.Location = New System.Drawing.Point(6, 34)
        Me.txt_InchargeCarton.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeCarton.Name = "txt_InchargeCarton"
        Me.txt_InchargeCarton.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeCarton.Size = New System.Drawing.Size(410, 27)
        Me.txt_InchargeCarton.TabIndex = 1
        Me.txt_InchargeCarton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeCarton.TextBoxAutoComplete = False
        Me.txt_InchargeCarton.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeCarton.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeCarton.TextEnabled = True
        Me.txt_InchargeCarton.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeCarton.TextMaxLength = 32767
        Me.txt_InchargeCarton.TextMultiLine = False
        Me.txt_InchargeCarton.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeCarton.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeCarton.UseSendTab = True
        '
        'txt_CTNetWeight
        '
        Me.txt_CTNetWeight.BackYesno = False
        Me.txt_CTNetWeight.ButtonTitle = Nothing
        Me.txt_CTNetWeight.Code = Nothing
        Me.txt_CTNetWeight.Data = ""
        Me.txt_CTNetWeight.DataDecimal = 0
        Me.txt_CTNetWeight.DataLen = 0
        Me.txt_CTNetWeight.DataValue = 1
        Me.txt_CTNetWeight.FormatDecimal = 0
        Me.txt_CTNetWeight.FormatValue = False
        Me.txt_CTNetWeight.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CTNetWeight.LableEnabled = True
        Me.txt_CTNetWeight.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTNetWeight.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CTNetWeight.LableTitle = "Net Weight"
        Me.txt_CTNetWeight.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CTNetWeight.Location = New System.Drawing.Point(419, 89)
        Me.txt_CTNetWeight.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CTNetWeight.Name = "txt_CTNetWeight"
        Me.txt_CTNetWeight.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CTNetWeight.Size = New System.Drawing.Size(410, 26)
        Me.txt_CTNetWeight.TabIndex = 5
        Me.txt_CTNetWeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CTNetWeight.TextBoxAutoComplete = False
        Me.txt_CTNetWeight.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CTNetWeight.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTNetWeight.TextEnabled = True
        Me.txt_CTNetWeight.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CTNetWeight.TextMaxLength = 32767
        Me.txt_CTNetWeight.TextMultiLine = False
        Me.txt_CTNetWeight.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CTNetWeight.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CTNetWeight.UseSendTab = True
        '
        'txt_CBM
        '
        Me.txt_CBM.BackYesno = False
        Me.txt_CBM.ButtonTitle = Nothing
        Me.txt_CBM.Code = Nothing
        Me.txt_CBM.Data = ""
        Me.txt_CBM.DataDecimal = 0
        Me.txt_CBM.DataLen = 0
        Me.txt_CBM.DataValue = 1
        Me.txt_CBM.FormatDecimal = 0
        Me.txt_CBM.FormatValue = False
        Me.txt_CBM.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CBM.LableEnabled = True
        Me.txt_CBM.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CBM.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CBM.LableTitle = "CBM"
        Me.txt_CBM.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CBM.Location = New System.Drawing.Point(419, 119)
        Me.txt_CBM.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CBM.Name = "txt_CBM"
        Me.txt_CBM.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CBM.Size = New System.Drawing.Size(410, 26)
        Me.txt_CBM.TabIndex = 6
        Me.txt_CBM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CBM.TextBoxAutoComplete = False
        Me.txt_CBM.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CBM.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CBM.TextEnabled = True
        Me.txt_CBM.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CBM.TextMaxLength = 32767
        Me.txt_CBM.TextMultiLine = False
        Me.txt_CBM.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CBM.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CBM.UseSendTab = True
        '
        'txt_CartonType
        '
        Me.txt_CartonType.BackYesno = False
        Me.txt_CartonType.ButtonTitle = Nothing
        Me.txt_CartonType.Code = Nothing
        Me.txt_CartonType.Data = ""
        Me.txt_CartonType.DataDecimal = 0
        Me.txt_CartonType.DataLen = 0
        Me.txt_CartonType.DataValue = 1
        Me.txt_CartonType.FormatDecimal = 0
        Me.txt_CartonType.FormatValue = False
        Me.txt_CartonType.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CartonType.LableEnabled = True
        Me.txt_CartonType.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CartonType.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CartonType.LableTitle = "Carton Name"
        Me.txt_CartonType.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CartonType.Location = New System.Drawing.Point(6, 4)
        Me.txt_CartonType.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CartonType.Name = "txt_CartonType"
        Me.txt_CartonType.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CartonType.Size = New System.Drawing.Size(410, 27)
        Me.txt_CartonType.TabIndex = 0
        Me.txt_CartonType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CartonType.TextBoxAutoComplete = False
        Me.txt_CartonType.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CartonType.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CartonType.TextEnabled = True
        Me.txt_CartonType.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CartonType.TextMaxLength = 32767
        Me.txt_CartonType.TextMultiLine = False
        Me.txt_CartonType.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CartonType.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CartonType.UseSendTab = True
        '
        'txt_CTHeight
        '
        Me.txt_CTHeight.BackYesno = False
        Me.txt_CTHeight.ButtonTitle = Nothing
        Me.txt_CTHeight.Code = Nothing
        Me.txt_CTHeight.Data = ""
        Me.txt_CTHeight.DataDecimal = 0
        Me.txt_CTHeight.DataLen = 0
        Me.txt_CTHeight.DataValue = 1
        Me.txt_CTHeight.FormatDecimal = 0
        Me.txt_CTHeight.FormatValue = False
        Me.txt_CTHeight.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CTHeight.LableEnabled = True
        Me.txt_CTHeight.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTHeight.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CTHeight.LableTitle = "Height"
        Me.txt_CTHeight.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CTHeight.Location = New System.Drawing.Point(419, 3)
        Me.txt_CTHeight.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CTHeight.Name = "txt_CTHeight"
        Me.txt_CTHeight.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CTHeight.Size = New System.Drawing.Size(410, 25)
        Me.txt_CTHeight.TabIndex = 2
        Me.txt_CTHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CTHeight.TextBoxAutoComplete = False
        Me.txt_CTHeight.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CTHeight.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTHeight.TextEnabled = True
        Me.txt_CTHeight.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CTHeight.TextMaxLength = 32767
        Me.txt_CTHeight.TextMultiLine = False
        Me.txt_CTHeight.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CTHeight.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CTHeight.UseSendTab = True
        '
        'txt_CTLength
        '
        Me.txt_CTLength.BackYesno = False
        Me.txt_CTLength.ButtonTitle = Nothing
        Me.txt_CTLength.Code = Nothing
        Me.txt_CTLength.Data = ""
        Me.txt_CTLength.DataDecimal = 0
        Me.txt_CTLength.DataLen = 0
        Me.txt_CTLength.DataValue = 1
        Me.txt_CTLength.FormatDecimal = 0
        Me.txt_CTLength.FormatValue = False
        Me.txt_CTLength.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CTLength.LableEnabled = True
        Me.txt_CTLength.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTLength.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CTLength.LableTitle = "Length"
        Me.txt_CTLength.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CTLength.Location = New System.Drawing.Point(419, 31)
        Me.txt_CTLength.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CTLength.Name = "txt_CTLength"
        Me.txt_CTLength.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CTLength.Size = New System.Drawing.Size(410, 26)
        Me.txt_CTLength.TabIndex = 3
        Me.txt_CTLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CTLength.TextBoxAutoComplete = False
        Me.txt_CTLength.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CTLength.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTLength.TextEnabled = True
        Me.txt_CTLength.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CTLength.TextMaxLength = 32767
        Me.txt_CTLength.TextMultiLine = False
        Me.txt_CTLength.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CTLength.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CTLength.UseSendTab = True
        '
        'txt_CTWidth
        '
        Me.txt_CTWidth.BackYesno = False
        Me.txt_CTWidth.ButtonTitle = Nothing
        Me.txt_CTWidth.Code = Nothing
        Me.txt_CTWidth.Data = ""
        Me.txt_CTWidth.DataDecimal = 0
        Me.txt_CTWidth.DataLen = 0
        Me.txt_CTWidth.DataValue = 1
        Me.txt_CTWidth.FormatDecimal = 0
        Me.txt_CTWidth.FormatValue = False
        Me.txt_CTWidth.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CTWidth.LableEnabled = True
        Me.txt_CTWidth.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTWidth.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CTWidth.LableTitle = "Width"
        Me.txt_CTWidth.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CTWidth.Location = New System.Drawing.Point(419, 61)
        Me.txt_CTWidth.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CTWidth.Name = "txt_CTWidth"
        Me.txt_CTWidth.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CTWidth.Size = New System.Drawing.Size(410, 26)
        Me.txt_CTWidth.TabIndex = 4
        Me.txt_CTWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CTWidth.TextBoxAutoComplete = False
        Me.txt_CTWidth.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CTWidth.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CTWidth.TextEnabled = True
        Me.txt_CTWidth.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CTWidth.TextMaxLength = 32767
        Me.txt_CTWidth.TextMultiLine = False
        Me.txt_CTWidth.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CTWidth.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CTWidth.UseSendTab = True
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
        Me.tit_Use.TabIndex = 7
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
        Me.Panel5.TabIndex = 8
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
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = Nothing
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = ""
        Me.txt_CustomerCode.ButtonTitle = "Customer Code"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 1
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(422, 9)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(410, 27)
        Me.txt_CustomerCode.TabIndex = 0
        Me.txt_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerCode.TextBoxAutoComplete = False
        Me.txt_CustomerCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerCode.TextEnabled = True
        Me.txt_CustomerCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextMaxLength = 32767
        Me.txt_CustomerCode.TextMultiLine = False
        Me.txt_CustomerCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerCode.UseSendTab = True
        '
        'ISUD7210A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(842, 242)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.Name = "ISUD7210A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CARTON CODE PROCESSING (ISUD7210A)"
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
    Friend WithEvents txt_CartonCode As PSMGlobal.SelectLabelText
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_CartonType As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CTHeight As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CTLength As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CTWidth As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_CTNetWeight As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CBM As PSMGlobal.SelectLabelText
    Friend WithEvents txt_InchargeCarton As PSMGlobal.SelectPeaceHLPButton

End Class
