<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gadget001
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
        Me.txt_SdateEdate = New PSMGlobal.SelectPeaceCalDou()
        Me.txt_GCODE = New PSMGlobal.SelectMulti()
        Me.txt_CustomerName = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSite = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSpecStatus = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SpecNoRef = New PSMGlobal.SelectLabelText()
        Me.txt_cdSpecState = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSpecKind = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSizeRange = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialName = New PSMGlobal.SelectLabelText()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.txt_MoldName = New PSMGlobal.SelectLabelText()
        Me.txt_LastName = New PSMGlobal.SelectLabelText()
        Me.txt_Incharge = New PSMGlobal.SelectPeaceHLPButton()
        Me.pCheckRequest = New System.Windows.Forms.Panel()
        Me.opt_CheckRequest9 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_CheckRequest0 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.lbt_CheckRequest = New PSMGlobal.SelectLabelText()
        Me.pCheckUse = New System.Windows.Forms.Panel()
        Me.chk_checkUse2 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_checkUse1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.txt_CheckUse = New PSMGlobal.SelectLabelText()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pCheckRequest.SuspendLayout()
        Me.pCheckUse.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 18)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 511.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(367, 550)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SdateEdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_GCODE)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_CustomerName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSite)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSpecStatus)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SpecNoRef)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSpecState)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSpecKind)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSizeRange)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Line)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Article)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MaterialName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_ColorName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MoldName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_LastName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Incharge)
        Me.FlowLayoutPanel1.Controls.Add(Me.pCheckRequest)
        Me.FlowLayoutPanel1.Controls.Add(Me.pCheckUse)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(365, 548)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'txt_SdateEdate
        '
        Me.txt_SdateEdate.ButtonTitle = "Period"
        Me.txt_SdateEdate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SdateEdate.Location = New System.Drawing.Point(1, 1)
        Me.txt_SdateEdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.txt_SdateEdate.Name = "txt_SdateEdate"
        Me.txt_SdateEdate.Size = New System.Drawing.Size(361, 21)
        Me.txt_SdateEdate.TabIndex = 0
        Me.txt_SdateEdate.text1 = ""
        Me.txt_SdateEdate.text2 = ""
        Me.txt_SdateEdate.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        '
        'txt_GCODE
        '
        Me.txt_GCODE.BackColor = System.Drawing.SystemColors.Control
        Me.txt_GCODE.ButtonTitle = "Customer Multi"
        Me.txt_GCODE.CheckBoxEnabled = True
        Me.txt_GCODE.CheckBoxTitle = Nothing
        Me.txt_GCODE.ComboBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_GCODE.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_GCODE.Layoutpercent = "34,10,33,23"
        Me.txt_GCODE.Location = New System.Drawing.Point(1, 25)
        Me.txt_GCODE.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GCODE.Name = "txt_GCODE"
        Me.txt_GCODE.SelectTitle = "Multiple"
        Me.txt_GCODE.Size = New System.Drawing.Size(361, 24)
        Me.txt_GCODE.TabIndex = 1
        Me.txt_GCODE.Visible = False
        '
        'txt_CustomerName
        '
        Me.txt_CustomerName.BackYesno = False
        Me.txt_CustomerName.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerName.ButtonEnabled = True
        Me.txt_CustomerName.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerName.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerName.ButtonName = Nothing
        Me.txt_CustomerName.ButtonTitle = "Customer"
        Me.txt_CustomerName.Code = ""
        Me.txt_CustomerName.Data = ""
        Me.txt_CustomerName.DataDecimal = 0
        Me.txt_CustomerName.DataLen = 0
        Me.txt_CustomerName.DataValue = 0
        Me.txt_CustomerName.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_CustomerName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerName.Location = New System.Drawing.Point(1, 51)
        Me.txt_CustomerName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerName.Name = "txt_CustomerName"
        Me.txt_CustomerName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerName.Size = New System.Drawing.Size(361, 24)
        Me.txt_CustomerName.TabIndex = 2
        Me.txt_CustomerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerName.TextBoxAutoComplete = False
        Me.txt_CustomerName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerName.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_CustomerName.TextEnabled = True
        Me.txt_CustomerName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerName.TextMaxLength = 32767
        Me.txt_CustomerName.TextMultiLine = False
        Me.txt_CustomerName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerName.UseSendTab = True
        '
        'txt_cdSite
        '
        Me.txt_cdSite.BackYesno = False
        Me.txt_cdSite.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSite.ButtonEnabled = True
        Me.txt_cdSite.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSite.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.ButtonName = Nothing
        Me.txt_cdSite.ButtonTitle = "Site/Company"
        Me.txt_cdSite.Code = ""
        Me.txt_cdSite.Data = ""
        Me.txt_cdSite.DataDecimal = 0
        Me.txt_cdSite.DataLen = 0
        Me.txt_cdSite.DataValue = 0
        Me.txt_cdSite.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSite.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSite.Location = New System.Drawing.Point(1, 77)
        Me.txt_cdSite.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSite.Name = "txt_cdSite"
        Me.txt_cdSite.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSite.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdSite.TabIndex = 3
        Me.txt_cdSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSite.TextBoxAutoComplete = False
        Me.txt_cdSite.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSite.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSite.TextEnabled = True
        Me.txt_cdSite.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.TextMaxLength = 32767
        Me.txt_cdSite.TextMultiLine = False
        Me.txt_cdSite.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSite.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSite.UseSendTab = True
        '
        'txt_cdSpecStatus
        '
        Me.txt_cdSpecStatus.BackYesno = False
        Me.txt_cdSpecStatus.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecStatus.ButtonEnabled = True
        Me.txt_cdSpecStatus.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSpecStatus.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecStatus.ButtonName = Nothing
        Me.txt_cdSpecStatus.ButtonTitle = "Spec Status"
        Me.txt_cdSpecStatus.Code = ""
        Me.txt_cdSpecStatus.Data = ""
        Me.txt_cdSpecStatus.DataDecimal = 0
        Me.txt_cdSpecStatus.DataLen = 0
        Me.txt_cdSpecStatus.DataValue = 0
        Me.txt_cdSpecStatus.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSpecStatus.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSpecStatus.Location = New System.Drawing.Point(1, 103)
        Me.txt_cdSpecStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecStatus.Name = "txt_cdSpecStatus"
        Me.txt_cdSpecStatus.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecStatus.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdSpecStatus.TabIndex = 4
        Me.txt_cdSpecStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecStatus.TextBoxAutoComplete = False
        Me.txt_cdSpecStatus.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecStatus.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSpecStatus.TextEnabled = True
        Me.txt_cdSpecStatus.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecStatus.TextMaxLength = 32767
        Me.txt_cdSpecStatus.TextMultiLine = False
        Me.txt_cdSpecStatus.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecStatus.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecStatus.UseSendTab = True
        '
        'txt_SpecNoRef
        '
        Me.txt_SpecNoRef.BackYesno = False
        Me.txt_SpecNoRef.ButtonTitle = Nothing
        Me.txt_SpecNoRef.Code = Nothing
        Me.txt_SpecNoRef.Data = ""
        Me.txt_SpecNoRef.DataDecimal = 0
        Me.txt_SpecNoRef.DataLen = 0
        Me.txt_SpecNoRef.DataValue = 0
        Me.txt_SpecNoRef.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SpecNoRef.FormatDecimal = 0
        Me.txt_SpecNoRef.FormatValue = False
        Me.txt_SpecNoRef.LableBackColor = System.Drawing.Color.Empty
        Me.txt_SpecNoRef.LableEnabled = True
        Me.txt_SpecNoRef.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SpecNoRef.LableForeColor = System.Drawing.Color.Black
        Me.txt_SpecNoRef.LableTitle = "SpecNo Ref"
        Me.txt_SpecNoRef.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SpecNoRef.Location = New System.Drawing.Point(1, 129)
        Me.txt_SpecNoRef.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SpecNoRef.Name = "txt_SpecNoRef"
        Me.txt_SpecNoRef.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SpecNoRef.Size = New System.Drawing.Size(361, 24)
        Me.txt_SpecNoRef.TabIndex = 5
        Me.txt_SpecNoRef.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SpecNoRef.TextBoxAutoComplete = False
        Me.txt_SpecNoRef.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SpecNoRef.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SpecNoRef.TextEnabled = True
        Me.txt_SpecNoRef.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SpecNoRef.TextMaxLength = 32767
        Me.txt_SpecNoRef.TextMultiLine = False
        Me.txt_SpecNoRef.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SpecNoRef.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SpecNoRef.UseSendTab = True
        Me.txt_SpecNoRef.Visible = False
        '
        'txt_cdSpecState
        '
        Me.txt_cdSpecState.BackYesno = False
        Me.txt_cdSpecState.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecState.ButtonEnabled = True
        Me.txt_cdSpecState.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSpecState.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.ButtonName = Nothing
        Me.txt_cdSpecState.ButtonTitle = "Spec State"
        Me.txt_cdSpecState.Code = ""
        Me.txt_cdSpecState.Data = ""
        Me.txt_cdSpecState.DataDecimal = 0
        Me.txt_cdSpecState.DataLen = 0
        Me.txt_cdSpecState.DataValue = 0
        Me.txt_cdSpecState.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSpecState.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSpecState.Location = New System.Drawing.Point(1, 155)
        Me.txt_cdSpecState.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecState.Name = "txt_cdSpecState"
        Me.txt_cdSpecState.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecState.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdSpecState.TabIndex = 6
        Me.txt_cdSpecState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecState.TextBoxAutoComplete = False
        Me.txt_cdSpecState.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSpecState.TextEnabled = True
        Me.txt_cdSpecState.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.TextMaxLength = 32767
        Me.txt_cdSpecState.TextMultiLine = False
        Me.txt_cdSpecState.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecState.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecState.UseSendTab = True
        '
        'txt_cdSpecKind
        '
        Me.txt_cdSpecKind.BackYesno = False
        Me.txt_cdSpecKind.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecKind.ButtonEnabled = True
        Me.txt_cdSpecKind.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSpecKind.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecKind.ButtonName = Nothing
        Me.txt_cdSpecKind.ButtonTitle = "Spec Kind"
        Me.txt_cdSpecKind.Code = ""
        Me.txt_cdSpecKind.Data = ""
        Me.txt_cdSpecKind.DataDecimal = 0
        Me.txt_cdSpecKind.DataLen = 0
        Me.txt_cdSpecKind.DataValue = 0
        Me.txt_cdSpecKind.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSpecKind.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSpecKind.Location = New System.Drawing.Point(1, 181)
        Me.txt_cdSpecKind.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecKind.Name = "txt_cdSpecKind"
        Me.txt_cdSpecKind.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecKind.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdSpecKind.TabIndex = 7
        Me.txt_cdSpecKind.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecKind.TextBoxAutoComplete = False
        Me.txt_cdSpecKind.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecKind.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSpecKind.TextEnabled = True
        Me.txt_cdSpecKind.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecKind.TextMaxLength = 32767
        Me.txt_cdSpecKind.TextMultiLine = False
        Me.txt_cdSpecKind.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecKind.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecKind.UseSendTab = True
        Me.txt_cdSpecKind.Visible = False
        '
        'txt_cdSizeRange
        '
        Me.txt_cdSizeRange.BackYesno = False
        Me.txt_cdSizeRange.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSizeRange.ButtonEnabled = True
        Me.txt_cdSizeRange.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSizeRange.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSizeRange.ButtonName = Nothing
        Me.txt_cdSizeRange.ButtonTitle = "Size Range"
        Me.txt_cdSizeRange.Code = ""
        Me.txt_cdSizeRange.Data = ""
        Me.txt_cdSizeRange.DataDecimal = 0
        Me.txt_cdSizeRange.DataLen = 0
        Me.txt_cdSizeRange.DataValue = 0
        Me.txt_cdSizeRange.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSizeRange.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSizeRange.Location = New System.Drawing.Point(1, 207)
        Me.txt_cdSizeRange.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSizeRange.Name = "txt_cdSizeRange"
        Me.txt_cdSizeRange.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSizeRange.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdSizeRange.TabIndex = 8
        Me.txt_cdSizeRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSizeRange.TextBoxAutoComplete = False
        Me.txt_cdSizeRange.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSizeRange.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSizeRange.TextEnabled = True
        Me.txt_cdSizeRange.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSizeRange.TextMaxLength = 32767
        Me.txt_cdSizeRange.TextMultiLine = False
        Me.txt_cdSizeRange.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSizeRange.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSizeRange.UseSendTab = True
        Me.txt_cdSizeRange.Visible = False
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
        Me.txt_Line.LableTitle = "SO/WI#"
        Me.txt_Line.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Line.Location = New System.Drawing.Point(1, 233)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(361, 24)
        Me.txt_Line.TabIndex = 10
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
        Me.txt_Article.LableTitle = "Article/Item Name"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Article.Location = New System.Drawing.Point(1, 259)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(361, 24)
        Me.txt_Article.TabIndex = 9
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
        Me.txt_MaterialName.Location = New System.Drawing.Point(1, 285)
        Me.txt_MaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialName.Size = New System.Drawing.Size(361, 24)
        Me.txt_MaterialName.TabIndex = 11
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
        Me.txt_MaterialName.Visible = False
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
        Me.txt_ColorName.Location = New System.Drawing.Point(1, 311)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(361, 24)
        Me.txt_ColorName.TabIndex = 12
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
        Me.txt_ColorName.Visible = False
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
        Me.txt_MoldName.Location = New System.Drawing.Point(1, 337)
        Me.txt_MoldName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MoldName.Name = "txt_MoldName"
        Me.txt_MoldName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MoldName.Size = New System.Drawing.Size(361, 24)
        Me.txt_MoldName.TabIndex = 13
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
        Me.txt_MoldName.Visible = False
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
        Me.txt_LastName.Location = New System.Drawing.Point(1, 363)
        Me.txt_LastName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LastName.Size = New System.Drawing.Size(361, 24)
        Me.txt_LastName.TabIndex = 14
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
        Me.txt_LastName.Visible = False
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
        Me.txt_Incharge.Location = New System.Drawing.Point(1, 389)
        Me.txt_Incharge.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Incharge.Name = "txt_Incharge"
        Me.txt_Incharge.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Incharge.Size = New System.Drawing.Size(361, 24)
        Me.txt_Incharge.TabIndex = 15
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
        Me.pCheckRequest.Location = New System.Drawing.Point(1, 415)
        Me.pCheckRequest.Margin = New System.Windows.Forms.Padding(1)
        Me.pCheckRequest.Name = "pCheckRequest"
        Me.pCheckRequest.Size = New System.Drawing.Size(361, 86)
        Me.pCheckRequest.TabIndex = 16
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
        'pCheckUse
        '
        Me.pCheckUse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCheckUse.Controls.Add(Me.chk_checkUse2)
        Me.pCheckUse.Controls.Add(Me.chk_checkUse1)
        Me.pCheckUse.Controls.Add(Me.txt_CheckUse)
        Me.pCheckUse.Location = New System.Drawing.Point(1, 503)
        Me.pCheckUse.Margin = New System.Windows.Forms.Padding(1)
        Me.pCheckUse.Name = "pCheckUse"
        Me.pCheckUse.Size = New System.Drawing.Size(361, 28)
        Me.pCheckUse.TabIndex = 17
        Me.pCheckUse.Visible = False
        '
        'chk_checkUse2
        '
        Me.chk_checkUse2.ButtonTitle = Nothing
        Me.chk_checkUse2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_checkUse2.Location = New System.Drawing.Point(260, 1)
        Me.chk_checkUse2.Name = "chk_checkUse2"
        Me.chk_checkUse2.Size = New System.Drawing.Size(96, 24)
        Me.chk_checkUse2.TabIndex = 3
        Me.chk_checkUse2.Text = "No"
        Me.chk_checkUse2.UseVisualStyleBackColor = True
        '
        'chk_checkUse1
        '
        Me.chk_checkUse1.ButtonTitle = Nothing
        Me.chk_checkUse1.Checked = True
        Me.chk_checkUse1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_checkUse1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_checkUse1.Location = New System.Drawing.Point(130, 1)
        Me.chk_checkUse1.Name = "chk_checkUse1"
        Me.chk_checkUse1.Size = New System.Drawing.Size(100, 24)
        Me.chk_checkUse1.TabIndex = 2
        Me.chk_checkUse1.Text = "Yes"
        Me.chk_checkUse1.UseVisualStyleBackColor = True
        '
        'txt_CheckUse
        '
        Me.txt_CheckUse.BackYesno = False
        Me.txt_CheckUse.ButtonTitle = Nothing
        Me.txt_CheckUse.Code = Nothing
        Me.txt_CheckUse.Data = ""
        Me.txt_CheckUse.DataDecimal = 0
        Me.txt_CheckUse.DataLen = 0
        Me.txt_CheckUse.DataValue = 0
        Me.txt_CheckUse.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_CheckUse.FormatDecimal = 0
        Me.txt_CheckUse.FormatValue = False
        Me.txt_CheckUse.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CheckUse.LableEnabled = True
        Me.txt_CheckUse.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_CheckUse.LableForeColor = System.Drawing.Color.Black
        Me.txt_CheckUse.LableTitle = "Use"
        Me.txt_CheckUse.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_CheckUse.Location = New System.Drawing.Point(1, 1)
        Me.txt_CheckUse.Name = "txt_CheckUse"
        Me.txt_CheckUse.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CheckUse.Size = New System.Drawing.Size(120, 24)
        Me.txt_CheckUse.TabIndex = 1
        Me.txt_CheckUse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CheckUse.TextBoxAutoComplete = False
        Me.txt_CheckUse.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CheckUse.TextBoxFont = Nothing
        Me.txt_CheckUse.TextEnabled = True
        Me.txt_CheckUse.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CheckUse.TextMaxLength = 32767
        Me.txt_CheckUse.TextMultiLine = False
        Me.txt_CheckUse.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CheckUse.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CheckUse.UseSendTab = True
        '
        'Gadget001
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Gadget001"
        Me.Size = New System.Drawing.Size(404, 626)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pCheckRequest.ResumeLayout(False)
        Me.pCheckUse.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_SdateEdate As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents txt_GCODE As PSMGlobal.SelectMulti
    Friend WithEvents txt_cdSite As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSpecStatus As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_SpecNoRef As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdSpecState As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSpecKind As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSizeRange As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Incharge As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents pCheckRequest As System.Windows.Forms.Panel
    Friend WithEvents opt_CheckRequest9 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_CheckRequest0 As PSMGlobal.PeaceRadioButton
    Friend WithEvents lbt_CheckRequest As PSMGlobal.SelectLabelText
    Friend WithEvents chk_checkUse2 As PSMGlobal.PeaceCheckbox
    Friend WithEvents chk_checkUse1 As PSMGlobal.PeaceCheckbox
    Friend WithEvents txt_CheckUse As PSMGlobal.SelectLabelText
    Friend WithEvents txt_CustomerName As PSMGlobal.SelectPeaceHLPButton
    Private WithEvents txt_MaterialName As PSMGlobal.SelectLabelText
    Private WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Private WithEvents txt_MoldName As PSMGlobal.SelectLabelText
    Private WithEvents txt_LastName As PSMGlobal.SelectLabelText
    Private WithEvents pCheckUse As System.Windows.Forms.Panel

End Class
