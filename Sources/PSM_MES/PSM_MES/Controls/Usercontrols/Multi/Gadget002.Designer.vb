<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gadget002
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_Period = New PSMGlobal.SelectPeaceCalDou()
        Me.txt_GCODE = New PSMGlobal.SelectMulti()
        Me.txt_SpecStatus = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialName = New PSMGlobal.SelectLabelText()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.txt_MoldName = New PSMGlobal.SelectLabelText()
        Me.txt_LastName = New PSMGlobal.SelectLabelText()
        Me.txt_SizeRange = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SpeciticSize = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SpecNo = New PSMGlobal.SelectLabelText()
        Me.txt_UnitMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_UnitPacking = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Incharge = New PSMGlobal.SelectPeaceHLPButton()
        Me.pCheckRequest = New System.Windows.Forms.Panel()
        Me.opt_CheckRequest9 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest0 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.lbt_CheckRequest = New PSMGlobal.SelectLabelText()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pCheckRequest.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 15)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 483.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 483)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Period)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_GCODE)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SpecStatus)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Article)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Line)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MaterialName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_ColorName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MoldName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_LastName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SizeRange)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SpeciticSize)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SpecNo)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_UnitMaterial)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_UnitPacking)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Incharge)
        Me.FlowLayoutPanel1.Controls.Add(Me.pCheckRequest)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(366, 477)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'txt_Period
        '
        Me.txt_Period.ButtonTitle = "Period"
        Me.txt_Period.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Period.Location = New System.Drawing.Point(1, 1)
        Me.txt_Period.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Period.Name = "txt_Period"
        Me.txt_Period.Size = New System.Drawing.Size(361, 24)
        Me.txt_Period.TabIndex = 0
        Me.txt_Period.text1 = ""
        Me.txt_Period.text2 = ""
        Me.txt_Period.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        '
        'txt_GCODE
        '
        Me.txt_GCODE.BackColor = System.Drawing.SystemColors.Control
        Me.txt_GCODE.ButtonTitle = "Customer"
        Me.txt_GCODE.CheckBoxEnabled = True
        Me.txt_GCODE.CheckBoxTitle = Nothing
        Me.txt_GCODE.ComboBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_GCODE.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_GCODE.Layoutpercent = "34,10,33,23"
        Me.txt_GCODE.Location = New System.Drawing.Point(1, 27)
        Me.txt_GCODE.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GCODE.Name = "txt_GCODE"
        Me.txt_GCODE.SelectTitle = "Multiple"
        Me.txt_GCODE.Size = New System.Drawing.Size(361, 24)
        Me.txt_GCODE.TabIndex = 1
        '
        'txt_SpecStatus
        '
        Me.txt_SpecStatus.BackYesno = False
        Me.txt_SpecStatus.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SpecStatus.ButtonEnabled = True
        Me.txt_SpecStatus.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SpecStatus.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_SpecStatus.ButtonName = Nothing
        Me.txt_SpecStatus.ButtonTitle = "Spec Status"
        Me.txt_SpecStatus.Code = ""
        Me.txt_SpecStatus.Data = ""
        Me.txt_SpecStatus.DataDecimal = 0
        Me.txt_SpecStatus.DataLen = 0
        Me.txt_SpecStatus.DataValue = 0
        Me.txt_SpecStatus.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SpecStatus.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SpecStatus.Location = New System.Drawing.Point(1, 53)
        Me.txt_SpecStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SpecStatus.Name = "txt_SpecStatus"
        Me.txt_SpecStatus.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SpecStatus.Size = New System.Drawing.Size(361, 24)
        Me.txt_SpecStatus.TabIndex = 4
        Me.txt_SpecStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SpecStatus.TextBoxAutoComplete = False
        Me.txt_SpecStatus.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SpecStatus.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SpecStatus.TextEnabled = True
        Me.txt_SpecStatus.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SpecStatus.TextMaxLength = 32767
        Me.txt_SpecStatus.TextMultiLine = False
        Me.txt_SpecStatus.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SpecStatus.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SpecStatus.UseSendTab = True
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = Nothing
        Me.txt_Article.Code = Nothing
        Me.txt_Article.Data = ""
        Me.txt_Article.DataDecimal = 0
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 0
        Me.txt_Article.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Article.FormatDecimal = 0
        Me.txt_Article.FormatValue = False
        Me.txt_Article.LableBackColor = System.Drawing.Color.Empty
        Me.txt_Article.LableEnabled = True
        Me.txt_Article.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Article.LableForeColor = System.Drawing.Color.Black
        Me.txt_Article.LableTitle = "Article"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Article.Location = New System.Drawing.Point(1, 79)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(361, 24)
        Me.txt_Article.TabIndex = 22
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Article.TextEnabled = True
        Me.txt_Article.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Article.TextMaxLength = 32767
        Me.txt_Article.TextMultiLine = False
        Me.txt_Article.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Article.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Article.UseSendTab = True
        '
        'txt_Line
        '
        Me.txt_Line.BackYesno = False
        Me.txt_Line.ButtonTitle = Nothing
        Me.txt_Line.Code = Nothing
        Me.txt_Line.Data = ""
        Me.txt_Line.DataDecimal = 0
        Me.txt_Line.DataLen = 0
        Me.txt_Line.DataValue = 0
        Me.txt_Line.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Line.FormatDecimal = 0
        Me.txt_Line.FormatValue = False
        Me.txt_Line.LableBackColor = System.Drawing.Color.Empty
        Me.txt_Line.LableEnabled = True
        Me.txt_Line.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Line.LableForeColor = System.Drawing.Color.Black
        Me.txt_Line.LableTitle = "Line"
        Me.txt_Line.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Line.Location = New System.Drawing.Point(1, 105)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(361, 24)
        Me.txt_Line.TabIndex = 23
        Me.txt_Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Line.TextBoxAutoComplete = False
        Me.txt_Line.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Line.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Line.TextEnabled = True
        Me.txt_Line.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Line.TextMaxLength = 32767
        Me.txt_Line.TextMultiLine = False
        Me.txt_Line.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Line.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Line.UseSendTab = True
        '
        'txt_MaterialName
        '
        Me.txt_MaterialName.BackYesno = False
        Me.txt_MaterialName.ButtonTitle = Nothing
        Me.txt_MaterialName.Code = Nothing
        Me.txt_MaterialName.Data = ""
        Me.txt_MaterialName.DataDecimal = 0
        Me.txt_MaterialName.DataLen = 0
        Me.txt_MaterialName.DataValue = 0
        Me.txt_MaterialName.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_MaterialName.FormatDecimal = 0
        Me.txt_MaterialName.FormatValue = False
        Me.txt_MaterialName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.LableEnabled = True
        Me.txt_MaterialName.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_MaterialName.LableForeColor = System.Drawing.Color.Black
        Me.txt_MaterialName.LableTitle = "Material Name"
        Me.txt_MaterialName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MaterialName.Location = New System.Drawing.Point(1, 131)
        Me.txt_MaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialName.Size = New System.Drawing.Size(361, 24)
        Me.txt_MaterialName.TabIndex = 24
        Me.txt_MaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialName.TextBoxAutoComplete = False
        Me.txt_MaterialName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_MaterialName.TextEnabled = True
        Me.txt_MaterialName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextMaxLength = 32767
        Me.txt_MaterialName.TextMultiLine = False
        Me.txt_MaterialName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialName.UseSendTab = True
        '
        'txt_ColorName
        '
        Me.txt_ColorName.BackYesno = False
        Me.txt_ColorName.ButtonTitle = Nothing
        Me.txt_ColorName.Code = Nothing
        Me.txt_ColorName.Data = ""
        Me.txt_ColorName.DataDecimal = 0
        Me.txt_ColorName.DataLen = 0
        Me.txt_ColorName.DataValue = 0
        Me.txt_ColorName.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_ColorName.FormatDecimal = 0
        Me.txt_ColorName.FormatValue = False
        Me.txt_ColorName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_ColorName.LableEnabled = True
        Me.txt_ColorName.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_ColorName.LableForeColor = System.Drawing.Color.Black
        Me.txt_ColorName.LableTitle = "Color Name"
        Me.txt_ColorName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorName.Location = New System.Drawing.Point(1, 157)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(361, 24)
        Me.txt_ColorName.TabIndex = 25
        Me.txt_ColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorName.TextBoxAutoComplete = False
        Me.txt_ColorName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_ColorName.TextEnabled = True
        Me.txt_ColorName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextMaxLength = 32767
        Me.txt_ColorName.TextMultiLine = False
        Me.txt_ColorName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorName.UseSendTab = True
        '
        'txt_MoldName
        '
        Me.txt_MoldName.BackYesno = False
        Me.txt_MoldName.ButtonTitle = Nothing
        Me.txt_MoldName.Code = Nothing
        Me.txt_MoldName.Data = ""
        Me.txt_MoldName.DataDecimal = 0
        Me.txt_MoldName.DataLen = 0
        Me.txt_MoldName.DataValue = 0
        Me.txt_MoldName.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_MoldName.FormatDecimal = 0
        Me.txt_MoldName.FormatValue = False
        Me.txt_MoldName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_MoldName.LableEnabled = True
        Me.txt_MoldName.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_MoldName.LableForeColor = System.Drawing.Color.Black
        Me.txt_MoldName.LableTitle = "Mold Name"
        Me.txt_MoldName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MoldName.Location = New System.Drawing.Point(1, 183)
        Me.txt_MoldName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MoldName.Name = "txt_MoldName"
        Me.txt_MoldName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MoldName.Size = New System.Drawing.Size(361, 24)
        Me.txt_MoldName.TabIndex = 26
        Me.txt_MoldName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MoldName.TextBoxAutoComplete = False
        Me.txt_MoldName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MoldName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_MoldName.TextEnabled = True
        Me.txt_MoldName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MoldName.TextMaxLength = 32767
        Me.txt_MoldName.TextMultiLine = False
        Me.txt_MoldName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MoldName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MoldName.UseSendTab = True
        '
        'txt_LastName
        '
        Me.txt_LastName.BackYesno = False
        Me.txt_LastName.ButtonTitle = Nothing
        Me.txt_LastName.Code = Nothing
        Me.txt_LastName.Data = ""
        Me.txt_LastName.DataDecimal = 0
        Me.txt_LastName.DataLen = 0
        Me.txt_LastName.DataValue = 0
        Me.txt_LastName.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_LastName.FormatDecimal = 0
        Me.txt_LastName.FormatValue = False
        Me.txt_LastName.LableBackColor = System.Drawing.Color.Empty
        Me.txt_LastName.LableEnabled = True
        Me.txt_LastName.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_LastName.LableForeColor = System.Drawing.Color.Black
        Me.txt_LastName.LableTitle = "Last Name"
        Me.txt_LastName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_LastName.Location = New System.Drawing.Point(1, 209)
        Me.txt_LastName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LastName.Size = New System.Drawing.Size(361, 24)
        Me.txt_LastName.TabIndex = 27
        Me.txt_LastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LastName.TextBoxAutoComplete = False
        Me.txt_LastName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LastName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_LastName.TextEnabled = True
        Me.txt_LastName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LastName.TextMaxLength = 32767
        Me.txt_LastName.TextMultiLine = False
        Me.txt_LastName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LastName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LastName.UseSendTab = True
        '
        'txt_SizeRange
        '
        Me.txt_SizeRange.BackYesno = False
        Me.txt_SizeRange.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SizeRange.ButtonEnabled = True
        Me.txt_SizeRange.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SizeRange.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.ButtonName = Nothing
        Me.txt_SizeRange.ButtonTitle = "Size Range"
        Me.txt_SizeRange.Code = ""
        Me.txt_SizeRange.Data = ""
        Me.txt_SizeRange.DataDecimal = 0
        Me.txt_SizeRange.DataLen = 0
        Me.txt_SizeRange.DataValue = 0
        Me.txt_SizeRange.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SizeRange.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SizeRange.Location = New System.Drawing.Point(1, 235)
        Me.txt_SizeRange.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeRange.Name = "txt_SizeRange"
        Me.txt_SizeRange.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeRange.Size = New System.Drawing.Size(361, 24)
        Me.txt_SizeRange.TabIndex = 21
        Me.txt_SizeRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeRange.TextBoxAutoComplete = False
        Me.txt_SizeRange.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SizeRange.TextEnabled = True
        Me.txt_SizeRange.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.TextMaxLength = 32767
        Me.txt_SizeRange.TextMultiLine = False
        Me.txt_SizeRange.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeRange.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeRange.UseSendTab = True
        '
        'txt_SpeciticSize
        '
        Me.txt_SpeciticSize.BackYesno = False
        Me.txt_SpeciticSize.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SpeciticSize.ButtonEnabled = True
        Me.txt_SpeciticSize.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SpeciticSize.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_SpeciticSize.ButtonName = Nothing
        Me.txt_SpeciticSize.ButtonTitle = "Specitic Size"
        Me.txt_SpeciticSize.Code = ""
        Me.txt_SpeciticSize.Data = ""
        Me.txt_SpeciticSize.DataDecimal = 0
        Me.txt_SpeciticSize.DataLen = 0
        Me.txt_SpeciticSize.DataValue = 0
        Me.txt_SpeciticSize.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SpeciticSize.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SpeciticSize.Location = New System.Drawing.Point(1, 261)
        Me.txt_SpeciticSize.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SpeciticSize.Name = "txt_SpeciticSize"
        Me.txt_SpeciticSize.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SpeciticSize.Size = New System.Drawing.Size(361, 24)
        Me.txt_SpeciticSize.TabIndex = 32
        Me.txt_SpeciticSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SpeciticSize.TextBoxAutoComplete = False
        Me.txt_SpeciticSize.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SpeciticSize.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SpeciticSize.TextEnabled = True
        Me.txt_SpeciticSize.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SpeciticSize.TextMaxLength = 32767
        Me.txt_SpeciticSize.TextMultiLine = False
        Me.txt_SpeciticSize.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SpeciticSize.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SpeciticSize.UseSendTab = True
        '
        'txt_SpecNo
        '
        Me.txt_SpecNo.BackYesno = False
        Me.txt_SpecNo.ButtonTitle = Nothing
        Me.txt_SpecNo.Code = Nothing
        Me.txt_SpecNo.Data = ""
        Me.txt_SpecNo.DataDecimal = 0
        Me.txt_SpecNo.DataLen = 0
        Me.txt_SpecNo.DataValue = 0
        Me.txt_SpecNo.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SpecNo.FormatDecimal = 0
        Me.txt_SpecNo.FormatValue = False
        Me.txt_SpecNo.LableBackColor = System.Drawing.Color.Empty
        Me.txt_SpecNo.LableEnabled = True
        Me.txt_SpecNo.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SpecNo.LableForeColor = System.Drawing.Color.Black
        Me.txt_SpecNo.LableTitle = "SpecNo"
        Me.txt_SpecNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SpecNo.Location = New System.Drawing.Point(1, 287)
        Me.txt_SpecNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SpecNo.Name = "txt_SpecNo"
        Me.txt_SpecNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SpecNo.Size = New System.Drawing.Size(361, 24)
        Me.txt_SpecNo.TabIndex = 31
        Me.txt_SpecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SpecNo.TextBoxAutoComplete = False
        Me.txt_SpecNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SpecNo.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SpecNo.TextEnabled = True
        Me.txt_SpecNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SpecNo.TextMaxLength = 32767
        Me.txt_SpecNo.TextMultiLine = False
        Me.txt_SpecNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SpecNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SpecNo.UseSendTab = True
        '
        'txt_UnitMaterial
        '
        Me.txt_UnitMaterial.BackYesno = False
        Me.txt_UnitMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_UnitMaterial.ButtonEnabled = True
        Me.txt_UnitMaterial.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_UnitMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_UnitMaterial.ButtonName = Nothing
        Me.txt_UnitMaterial.ButtonTitle = "Unit Material"
        Me.txt_UnitMaterial.Code = ""
        Me.txt_UnitMaterial.Data = ""
        Me.txt_UnitMaterial.DataDecimal = 0
        Me.txt_UnitMaterial.DataLen = 0
        Me.txt_UnitMaterial.DataValue = 0
        Me.txt_UnitMaterial.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_UnitMaterial.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_UnitMaterial.Location = New System.Drawing.Point(1, 313)
        Me.txt_UnitMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_UnitMaterial.Name = "txt_UnitMaterial"
        Me.txt_UnitMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_UnitMaterial.Size = New System.Drawing.Size(361, 24)
        Me.txt_UnitMaterial.TabIndex = 33
        Me.txt_UnitMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_UnitMaterial.TextBoxAutoComplete = False
        Me.txt_UnitMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_UnitMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_UnitMaterial.TextEnabled = True
        Me.txt_UnitMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_UnitMaterial.TextMaxLength = 32767
        Me.txt_UnitMaterial.TextMultiLine = False
        Me.txt_UnitMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_UnitMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_UnitMaterial.UseSendTab = True
        '
        'txt_UnitPacking
        '
        Me.txt_UnitPacking.BackYesno = False
        Me.txt_UnitPacking.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_UnitPacking.ButtonEnabled = True
        Me.txt_UnitPacking.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_UnitPacking.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_UnitPacking.ButtonName = Nothing
        Me.txt_UnitPacking.ButtonTitle = "Unit Packing"
        Me.txt_UnitPacking.Code = ""
        Me.txt_UnitPacking.Data = ""
        Me.txt_UnitPacking.DataDecimal = 0
        Me.txt_UnitPacking.DataLen = 0
        Me.txt_UnitPacking.DataValue = 0
        Me.txt_UnitPacking.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_UnitPacking.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_UnitPacking.Location = New System.Drawing.Point(1, 339)
        Me.txt_UnitPacking.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_UnitPacking.Name = "txt_UnitPacking"
        Me.txt_UnitPacking.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_UnitPacking.Size = New System.Drawing.Size(361, 24)
        Me.txt_UnitPacking.TabIndex = 34
        Me.txt_UnitPacking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_UnitPacking.TextBoxAutoComplete = False
        Me.txt_UnitPacking.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_UnitPacking.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_UnitPacking.TextEnabled = True
        Me.txt_UnitPacking.TextForeColor = System.Drawing.Color.Empty
        Me.txt_UnitPacking.TextMaxLength = 32767
        Me.txt_UnitPacking.TextMultiLine = False
        Me.txt_UnitPacking.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_UnitPacking.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_UnitPacking.UseSendTab = True
        '
        'txt_Incharge
        '
        Me.txt_Incharge.BackYesno = False
        Me.txt_Incharge.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Incharge.ButtonEnabled = True
        Me.txt_Incharge.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Incharge.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_Incharge.ButtonName = Nothing
        Me.txt_Incharge.ButtonTitle = "Incharge"
        Me.txt_Incharge.Code = ""
        Me.txt_Incharge.Data = ""
        Me.txt_Incharge.DataDecimal = 0
        Me.txt_Incharge.DataLen = 0
        Me.txt_Incharge.DataValue = 0
        Me.txt_Incharge.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Incharge.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Incharge.Location = New System.Drawing.Point(1, 365)
        Me.txt_Incharge.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Incharge.Name = "txt_Incharge"
        Me.txt_Incharge.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Incharge.Size = New System.Drawing.Size(361, 24)
        Me.txt_Incharge.TabIndex = 36
        Me.txt_Incharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Incharge.TextBoxAutoComplete = False
        Me.txt_Incharge.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Incharge.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Incharge.TextEnabled = True
        Me.txt_Incharge.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Incharge.TextMaxLength = 32767
        Me.txt_Incharge.TextMultiLine = False
        Me.txt_Incharge.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Incharge.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Incharge.UseSendTab = True
        '
        'pCheckRequest
        '
        Me.pCheckRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCheckRequest.Controls.Add(Me.opt_CheckRequest9)
        Me.pCheckRequest.Controls.Add(Me.opt_CheckRequest4)
        Me.pCheckRequest.Controls.Add(Me.opt_CheckRequest3)
        Me.pCheckRequest.Controls.Add(Me.opt_CheckRequest2)
        Me.pCheckRequest.Controls.Add(Me.opt_CheckRequest1)
        Me.pCheckRequest.Controls.Add(Me.opt_CheckRequest0)
        Me.pCheckRequest.Controls.Add(Me.lbt_CheckRequest)
        Me.pCheckRequest.Location = New System.Drawing.Point(1, 391)
        Me.pCheckRequest.Margin = New System.Windows.Forms.Padding(1)
        Me.pCheckRequest.Name = "pCheckRequest"
        Me.pCheckRequest.Size = New System.Drawing.Size(361, 86)
        Me.pCheckRequest.TabIndex = 37
        '
        'opt_CheckRequest9
        '
        Me.opt_CheckRequest9.ButtonTitle = Nothing
        Me.opt_CheckRequest9.Checked = True
        Me.opt_CheckRequest9.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRequest9.Location = New System.Drawing.Point(260, 54)
        Me.opt_CheckRequest9.Name = "opt_CheckRequest9"
        Me.opt_CheckRequest9.Size = New System.Drawing.Size(96, 24)
        Me.opt_CheckRequest9.TabIndex = 6
        Me.opt_CheckRequest9.TabStop = True
        Me.opt_CheckRequest9.Text = "Total"
        Me.opt_CheckRequest9.UseVisualStyleBackColor = True
        '
        'opt_CheckRequest4
        '
        Me.opt_CheckRequest4.ButtonTitle = Nothing
        Me.opt_CheckRequest4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRequest4.Location = New System.Drawing.Point(260, 29)
        Me.opt_CheckRequest4.Name = "opt_CheckRequest4"
        Me.opt_CheckRequest4.Size = New System.Drawing.Size(96, 24)
        Me.opt_CheckRequest4.TabIndex = 5
        Me.opt_CheckRequest4.Text = "Pending"
        Me.opt_CheckRequest4.UseVisualStyleBackColor = True
        '
        'opt_CheckRequest3
        '
        Me.opt_CheckRequest3.ButtonTitle = Nothing
        Me.opt_CheckRequest3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRequest3.Location = New System.Drawing.Point(260, 4)
        Me.opt_CheckRequest3.Name = "opt_CheckRequest3"
        Me.opt_CheckRequest3.Size = New System.Drawing.Size(96, 24)
        Me.opt_CheckRequest3.TabIndex = 4
        Me.opt_CheckRequest3.Text = "Cancel"
        Me.opt_CheckRequest3.UseVisualStyleBackColor = True
        '
        'opt_CheckRequest2
        '
        Me.opt_CheckRequest2.ButtonTitle = Nothing
        Me.opt_CheckRequest2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRequest2.Location = New System.Drawing.Point(130, 54)
        Me.opt_CheckRequest2.Name = "opt_CheckRequest2"
        Me.opt_CheckRequest2.Size = New System.Drawing.Size(100, 24)
        Me.opt_CheckRequest2.TabIndex = 3
        Me.opt_CheckRequest2.Text = "Approval"
        Me.opt_CheckRequest2.UseVisualStyleBackColor = True
        '
        'opt_CheckRequest1
        '
        Me.opt_CheckRequest1.ButtonTitle = Nothing
        Me.opt_CheckRequest1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRequest1.Location = New System.Drawing.Point(130, 29)
        Me.opt_CheckRequest1.Name = "opt_CheckRequest1"
        Me.opt_CheckRequest1.Size = New System.Drawing.Size(100, 24)
        Me.opt_CheckRequest1.TabIndex = 2
        Me.opt_CheckRequest1.Text = "Complete"
        Me.opt_CheckRequest1.UseVisualStyleBackColor = True
        '
        'opt_CheckRequest0
        '
        Me.opt_CheckRequest0.ButtonTitle = Nothing
        Me.opt_CheckRequest0.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_CheckRequest0.Location = New System.Drawing.Point(130, 4)
        Me.opt_CheckRequest0.Name = "opt_CheckRequest0"
        Me.opt_CheckRequest0.Size = New System.Drawing.Size(100, 24)
        Me.opt_CheckRequest0.TabIndex = 1
        Me.opt_CheckRequest0.Text = "Not Approval"
        Me.opt_CheckRequest0.UseVisualStyleBackColor = True
        '
        'lbt_CheckRequest
        '
        Me.lbt_CheckRequest.BackYesno = False
        Me.lbt_CheckRequest.ButtonTitle = Nothing
        Me.lbt_CheckRequest.Code = Nothing
        Me.lbt_CheckRequest.Data = ""
        Me.lbt_CheckRequest.DataDecimal = 0
        Me.lbt_CheckRequest.DataLen = 0
        Me.lbt_CheckRequest.DataValue = 0
        Me.lbt_CheckRequest.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lbt_CheckRequest.FormatDecimal = 0
        Me.lbt_CheckRequest.FormatValue = False
        Me.lbt_CheckRequest.LableBackColor = System.Drawing.SystemColors.Control
        Me.lbt_CheckRequest.LableEnabled = True
        Me.lbt_CheckRequest.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.lbt_CheckRequest.LableForeColor = System.Drawing.Color.Black
        Me.lbt_CheckRequest.LableTitle = "Check Request"
        Me.lbt_CheckRequest.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.lbt_CheckRequest.Location = New System.Drawing.Point(1, 1)
        Me.lbt_CheckRequest.Name = "lbt_CheckRequest"
        Me.lbt_CheckRequest.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.lbt_CheckRequest.Size = New System.Drawing.Size(120, 82)
        Me.lbt_CheckRequest.TabIndex = 0
        Me.lbt_CheckRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.lbt_CheckRequest.TextBoxAutoComplete = False
        Me.lbt_CheckRequest.TextboxBackColor = System.Drawing.Color.Empty
        Me.lbt_CheckRequest.TextBoxFont = Nothing
        Me.lbt_CheckRequest.TextEnabled = True
        Me.lbt_CheckRequest.TextForeColor = System.Drawing.Color.Empty
        Me.lbt_CheckRequest.TextMaxLength = 32767
        Me.lbt_CheckRequest.TextMultiLine = False
        Me.lbt_CheckRequest.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.lbt_CheckRequest.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbt_CheckRequest.UseSendTab = True
        '
        'Gadget002
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Gadget002"
        Me.Size = New System.Drawing.Size(412, 564)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pCheckRequest.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_Period As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents txt_GCODE As PSMGlobal.SelectMulti
    Friend WithEvents txt_SpecStatus As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MaterialName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MoldName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LastName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SizeRange As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_SpecNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SpeciticSize As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_UnitMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_UnitPacking As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Incharge As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents pCheckRequest As System.Windows.Forms.Panel
    Friend WithEvents opt_CheckRequest9 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest0 As PSMGlobal.PeaceRadioButton
    Friend WithEvents lbt_CheckRequest As PSMGlobal.SelectLabelText

End Class
