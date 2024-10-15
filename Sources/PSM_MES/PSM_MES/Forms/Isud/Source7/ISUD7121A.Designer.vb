<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7121A
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
        Me.txt_ColorCode = New PSMGlobal.SelectLabelText()
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_ColorPosition = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckBase2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckBase1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_cdColorCategory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.txt_ColorNameSimple = New PSMGlobal.SelectLabelText()
        Me.txt_cdColorBase = New PSMGlobal.SelectPeaceHLPButton()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.txt_ColorNameS1 = New PSMGlobal.SelectLabelText()
        Me.txt_ColorNameS2 = New PSMGlobal.SelectLabelText()
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Block1.SuspendLayout()
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bloack2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Location = New System.Drawing.Point(0, 42)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(621, 206)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.txt_ColorCode)
        Me.Block1.Data = ""
        Me.Block1.Location = New System.Drawing.Point(7, 5)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(315, 32)
        Me.Block1.TabIndex = 0
        Me.Block1.Tag = ""
        '
        'txt_ColorCode
        '
        Me.txt_ColorCode.BackYesno = False
        Me.txt_ColorCode.ButtonTitle = Nothing
        Me.txt_ColorCode.Code = Nothing
        Me.txt_ColorCode.Data = ""
        Me.txt_ColorCode.DataDecimal = 0
        Me.txt_ColorCode.DataLen = 0
        Me.txt_ColorCode.DataValue = 0
        Me.txt_ColorCode.FormatDecimal = 0
        Me.txt_ColorCode.FormatValue = False
        Me.txt_ColorCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ColorCode.LableEnabled = True
        Me.txt_ColorCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ColorCode.LableForeColor = System.Drawing.Color.Blue
        Me.txt_ColorCode.LableTitle = "Color Code"
        Me.txt_ColorCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorCode.Location = New System.Drawing.Point(5, 4)
        Me.txt_ColorCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ColorCode.Name = "txt_ColorCode"
        Me.txt_ColorCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorCode.Size = New System.Drawing.Size(300, 22)
        Me.txt_ColorCode.TabIndex = 0
        Me.txt_ColorCode.TabStop = False
        Me.txt_ColorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorCode.TextBoxAutoComplete = False
        Me.txt_ColorCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorCode.TextEnabled = False
        Me.txt_ColorCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.TextMaxLength = 32767
        Me.txt_ColorCode.TextMultiLine = False
        Me.txt_ColorCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorCode.UseSendTab = True
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Code = ""
        Me.Bloack2.Controls.Add(Me.txt_ColorNameS2)
        Me.Bloack2.Controls.Add(Me.txt_ColorNameS1)
        Me.Bloack2.Controls.Add(Me.txt_CustomerCode)
        Me.Bloack2.Controls.Add(Me.txt_ColorPosition)
        Me.Bloack2.Controls.Add(Me.PeaceLabel1)
        Me.Bloack2.Controls.Add(Me.TableLayoutPanel1)
        Me.Bloack2.Controls.Add(Me.txt_cdColorCategory)
        Me.Bloack2.Controls.Add(Me.txt_ColorName)
        Me.Bloack2.Controls.Add(Me.txt_ColorNameSimple)
        Me.Bloack2.Controls.Add(Me.txt_cdColorBase)
        Me.Bloack2.Controls.Add(Me.tit_Use)
        Me.Bloack2.Controls.Add(Me.Panel5)
        Me.Bloack2.Data = ""
        Me.Bloack2.Location = New System.Drawing.Point(3, 51)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(613, 148)
        Me.Bloack2.TabIndex = 2
        Me.Bloack2.Tag = ""
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = Nothing
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = ""
        Me.txt_CustomerCode.ButtonTitle = "Customer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 0
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(307, 91)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(300, 22)
        Me.txt_CustomerCode.TabIndex = 1
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
        'txt_ColorPosition
        '
        Me.txt_ColorPosition.BackYesno = False
        Me.txt_ColorPosition.ButtonBackColor = System.Drawing.Color.White
        Me.txt_ColorPosition.ButtonEnabled = True
        Me.txt_ColorPosition.ButtonFont = Nothing
        Me.txt_ColorPosition.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_ColorPosition.ButtonName = ""
        Me.txt_ColorPosition.ButtonTitle = "Background"
        Me.txt_ColorPosition.Code = ""
        Me.txt_ColorPosition.Data = ""
        Me.txt_ColorPosition.DataDecimal = 0
        Me.txt_ColorPosition.DataLen = 0
        Me.txt_ColorPosition.DataValue = 0
        Me.txt_ColorPosition.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorPosition.Location = New System.Drawing.Point(307, 121)
        Me.txt_ColorPosition.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorPosition.Name = "txt_ColorPosition"
        Me.txt_ColorPosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorPosition.Size = New System.Drawing.Size(300, 22)
        Me.txt_ColorPosition.TabIndex = 4
        Me.txt_ColorPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorPosition.TextBoxAutoComplete = False
        Me.txt_ColorPosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorPosition.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ColorPosition.TextEnabled = True
        Me.txt_ColorPosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorPosition.TextMaxLength = 32767
        Me.txt_ColorPosition.TextMultiLine = False
        Me.txt_ColorPosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorPosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorPosition.UseSendTab = True
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(5, 92)
        Me.PeaceLabel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(101, 25)
        Me.PeaceLabel1.TabIndex = 5
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "Base"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rad_CheckBase2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_CheckBase1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(108, 92)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(197, 25)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'rad_CheckBase2
        '
        Me.rad_CheckBase2.AutoSize = True
        Me.rad_CheckBase2.ButtonTitle = Nothing
        Me.rad_CheckBase2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.rad_CheckBase2.Location = New System.Drawing.Point(102, 4)
        Me.rad_CheckBase2.Name = "rad_CheckBase2"
        Me.rad_CheckBase2.Size = New System.Drawing.Size(53, 17)
        Me.rad_CheckBase2.TabIndex = 1
        Me.rad_CheckBase2.Text = "Order"
        Me.rad_CheckBase2.UseVisualStyleBackColor = True
        '
        'rad_CheckBase1
        '
        Me.rad_CheckBase1.AutoSize = True
        Me.rad_CheckBase1.ButtonTitle = Nothing
        Me.rad_CheckBase1.Checked = True
        Me.rad_CheckBase1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.rad_CheckBase1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckBase1.Name = "rad_CheckBase1"
        Me.rad_CheckBase1.Size = New System.Drawing.Size(63, 17)
        Me.rad_CheckBase1.TabIndex = 0
        Me.rad_CheckBase1.TabStop = True
        Me.rad_CheckBase1.Text = "Material"
        Me.rad_CheckBase1.UseVisualStyleBackColor = True
        '
        'txt_cdColorCategory
        '
        Me.txt_cdColorCategory.BackYesno = False
        Me.txt_cdColorCategory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdColorCategory.ButtonEnabled = True
        Me.txt_cdColorCategory.ButtonFont = Nothing
        Me.txt_cdColorCategory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdColorCategory.ButtonName = ""
        Me.txt_cdColorCategory.ButtonTitle = "Color Category"
        Me.txt_cdColorCategory.Code = ""
        Me.txt_cdColorCategory.Data = ""
        Me.txt_cdColorCategory.DataDecimal = 0
        Me.txt_cdColorCategory.DataLen = 0
        Me.txt_cdColorCategory.DataValue = 0
        Me.txt_cdColorCategory.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdColorCategory.Location = New System.Drawing.Point(307, 61)
        Me.txt_cdColorCategory.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdColorCategory.Name = "txt_cdColorCategory"
        Me.txt_cdColorCategory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdColorCategory.Size = New System.Drawing.Size(300, 22)
        Me.txt_cdColorCategory.TabIndex = 1
        Me.txt_cdColorCategory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdColorCategory.TextBoxAutoComplete = False
        Me.txt_cdColorCategory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdColorCategory.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdColorCategory.TextEnabled = True
        Me.txt_cdColorCategory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdColorCategory.TextMaxLength = 32767
        Me.txt_cdColorCategory.TextMultiLine = False
        Me.txt_cdColorCategory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdColorCategory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdColorCategory.UseSendTab = True
        '
        'txt_ColorName
        '
        Me.txt_ColorName.BackYesno = False
        Me.txt_ColorName.ButtonTitle = Nothing
        Me.txt_ColorName.Code = Nothing
        Me.txt_ColorName.Data = ""
        Me.txt_ColorName.DataDecimal = 0
        Me.txt_ColorName.DataLen = 0
        Me.txt_ColorName.DataValue = 1
        Me.txt_ColorName.FormatDecimal = 0
        Me.txt_ColorName.FormatValue = False
        Me.txt_ColorName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ColorName.LableEnabled = True
        Me.txt_ColorName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ColorName.LableTitle = "Color Name"
        Me.txt_ColorName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorName.Location = New System.Drawing.Point(5, 33)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(300, 22)
        Me.txt_ColorName.TabIndex = 2
        Me.txt_ColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorName.TextBoxAutoComplete = False
        Me.txt_ColorName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorName.TextEnabled = True
        Me.txt_ColorName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextMaxLength = 32767
        Me.txt_ColorName.TextMultiLine = False
        Me.txt_ColorName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorName.UseSendTab = True
        '
        'txt_ColorNameSimple
        '
        Me.txt_ColorNameSimple.BackYesno = False
        Me.txt_ColorNameSimple.ButtonTitle = Nothing
        Me.txt_ColorNameSimple.Code = Nothing
        Me.txt_ColorNameSimple.Data = ""
        Me.txt_ColorNameSimple.DataDecimal = 0
        Me.txt_ColorNameSimple.DataLen = 0
        Me.txt_ColorNameSimple.DataValue = 0
        Me.txt_ColorNameSimple.FormatDecimal = 0
        Me.txt_ColorNameSimple.FormatValue = False
        Me.txt_ColorNameSimple.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ColorNameSimple.LableEnabled = True
        Me.txt_ColorNameSimple.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorNameSimple.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ColorNameSimple.LableTitle = "Simple Name"
        Me.txt_ColorNameSimple.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorNameSimple.Location = New System.Drawing.Point(5, 63)
        Me.txt_ColorNameSimple.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorNameSimple.Name = "txt_ColorNameSimple"
        Me.txt_ColorNameSimple.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorNameSimple.Size = New System.Drawing.Size(300, 22)
        Me.txt_ColorNameSimple.TabIndex = 3
        Me.txt_ColorNameSimple.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorNameSimple.TextBoxAutoComplete = False
        Me.txt_ColorNameSimple.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorNameSimple.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorNameSimple.TextEnabled = True
        Me.txt_ColorNameSimple.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorNameSimple.TextMaxLength = 32767
        Me.txt_ColorNameSimple.TextMultiLine = False
        Me.txt_ColorNameSimple.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorNameSimple.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorNameSimple.UseSendTab = True
        '
        'txt_cdColorBase
        '
        Me.txt_cdColorBase.BackYesno = False
        Me.txt_cdColorBase.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdColorBase.ButtonEnabled = True
        Me.txt_cdColorBase.ButtonFont = Nothing
        Me.txt_cdColorBase.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdColorBase.ButtonName = ""
        Me.txt_cdColorBase.ButtonTitle = "Color Base"
        Me.txt_cdColorBase.Code = ""
        Me.txt_cdColorBase.Data = ""
        Me.txt_cdColorBase.DataDecimal = 0
        Me.txt_cdColorBase.DataLen = 0
        Me.txt_cdColorBase.DataValue = 0
        Me.txt_cdColorBase.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdColorBase.Location = New System.Drawing.Point(5, 3)
        Me.txt_cdColorBase.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdColorBase.Name = "txt_cdColorBase"
        Me.txt_cdColorBase.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdColorBase.Size = New System.Drawing.Size(300, 22)
        Me.txt_cdColorBase.TabIndex = 0
        Me.txt_cdColorBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdColorBase.TextBoxAutoComplete = False
        Me.txt_cdColorBase.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdColorBase.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdColorBase.TextEnabled = True
        Me.txt_cdColorBase.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdColorBase.TextMaxLength = 32767
        Me.txt_cdColorBase.TextMultiLine = False
        Me.txt_cdColorBase.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdColorBase.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdColorBase.UseSendTab = True
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
        Me.tit_Use.Size = New System.Drawing.Size(101, 25)
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
        Me.Panel5.Location = New System.Drawing.Point(108, 119)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(197, 25)
        Me.Panel5.TabIndex = 8
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.AutoSize = True
        Me.rad_CheckUse2.ButtonTitle = Nothing
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(102, 4)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(38, 17)
        Me.rad_CheckUse2.TabIndex = 1
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.AutoSize = True
        Me.rad_CheckUse1.ButtonTitle = Nothing
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(42, 17)
        Me.rad_CheckUse1.TabIndex = 0
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'txt_ColorNameS1
        '
        Me.txt_ColorNameS1.BackYesno = False
        Me.txt_ColorNameS1.ButtonTitle = Nothing
        Me.txt_ColorNameS1.Code = Nothing
        Me.txt_ColorNameS1.Data = ""
        Me.txt_ColorNameS1.DataDecimal = 0
        Me.txt_ColorNameS1.DataLen = 0
        Me.txt_ColorNameS1.DataValue = 0
        Me.txt_ColorNameS1.FormatDecimal = 0
        Me.txt_ColorNameS1.FormatValue = False
        Me.txt_ColorNameS1.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ColorNameS1.LableEnabled = True
        Me.txt_ColorNameS1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorNameS1.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ColorNameS1.LableTitle = "Sub Color 1"
        Me.txt_ColorNameS1.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorNameS1.Location = New System.Drawing.Point(307, 3)
        Me.txt_ColorNameS1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorNameS1.Name = "txt_ColorNameS1"
        Me.txt_ColorNameS1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorNameS1.Size = New System.Drawing.Size(300, 22)
        Me.txt_ColorNameS1.TabIndex = 9
        Me.txt_ColorNameS1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorNameS1.TextBoxAutoComplete = False
        Me.txt_ColorNameS1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorNameS1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorNameS1.TextEnabled = True
        Me.txt_ColorNameS1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorNameS1.TextMaxLength = 32767
        Me.txt_ColorNameS1.TextMultiLine = False
        Me.txt_ColorNameS1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorNameS1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorNameS1.UseSendTab = True
        '
        'txt_ColorNameS2
        '
        Me.txt_ColorNameS2.BackYesno = False
        Me.txt_ColorNameS2.ButtonTitle = Nothing
        Me.txt_ColorNameS2.Code = Nothing
        Me.txt_ColorNameS2.Data = ""
        Me.txt_ColorNameS2.DataDecimal = 0
        Me.txt_ColorNameS2.DataLen = 0
        Me.txt_ColorNameS2.DataValue = 0
        Me.txt_ColorNameS2.FormatDecimal = 0
        Me.txt_ColorNameS2.FormatValue = False
        Me.txt_ColorNameS2.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_ColorNameS2.LableEnabled = True
        Me.txt_ColorNameS2.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorNameS2.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ColorNameS2.LableTitle = "Sub Color 2"
        Me.txt_ColorNameS2.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorNameS2.Location = New System.Drawing.Point(307, 33)
        Me.txt_ColorNameS2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorNameS2.Name = "txt_ColorNameS2"
        Me.txt_ColorNameS2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorNameS2.Size = New System.Drawing.Size(300, 22)
        Me.txt_ColorNameS2.TabIndex = 10
        Me.txt_ColorNameS2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorNameS2.TextBoxAutoComplete = False
        Me.txt_ColorNameS2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorNameS2.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorNameS2.TextEnabled = True
        Me.txt_ColorNameS2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorNameS2.TextMaxLength = 32767
        Me.txt_ColorNameS2.TextMultiLine = False
        Me.txt_ColorNameS2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorNameS2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorNameS2.UseSendTab = True
        '
        'ISUD7121A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(625, 251)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.Name = "ISUD7121A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "NO"
        Me.Text = "COLOR CODE PROCESSING (ISUD7121A)"
        Me.Controls.SetChildIndex(Me.frm_Condition, 0)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block1.ResumeLayout(False)
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bloack2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Block1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_ColorCode As PSMGlobal.SelectLabelText
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorNameSimple As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdColorBase As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdColorCategory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckBase2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckBase1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_ColorPosition As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents txt_ColorNameS2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorNameS1 As PSMGlobal.SelectLabelText

End Class
