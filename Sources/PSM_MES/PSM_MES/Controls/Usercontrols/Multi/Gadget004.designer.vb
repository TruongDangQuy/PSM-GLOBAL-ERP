<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gadget004
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
        Me.txt_SupplierCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSeason = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_PurchasingNo = New PSMGlobal.SelectLabelText()
        Me.txt_cdLargeGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSemiGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDetailGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MaterialCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDepartment = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdPaymentCondition = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Incharge = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckIOType1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckIOType0 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.lbt_Warehouse = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckMaterialType1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckMaterialType0 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel5 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckProcessMaterial1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckProcessMaterial0 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceLabel4 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel4 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckMarketType1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckMarketType0 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceLabel3 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel7 = New PSMGlobal.PeacePanel(Me.components)
        Me.opt_ChkDetail = New System.Windows.Forms.RadioButton()
        Me.opt_ChkGroup = New System.Windows.Forms.RadioButton()
        Me.PeaceLabel5 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_CheckRelationType1 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.chk_CheckRelationType0 = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.PeaceLabel6 = New PSMGlobal.PeaceLabel(Me.components)
        Me.pCheckRequest = New System.Windows.Forms.Panel()
        Me.opt_SEL5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL0 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.SelectLabelText1 = New PSMGlobal.SelectLabelText()
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        CType(Me.PeacePanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel5.SuspendLayout()
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel4.SuspendLayout()
        CType(Me.PeacePanel7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel7.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.pCheckRequest.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(14, 9)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 511.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(340, 682)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SdateEdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_GCODE)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SupplierCode)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSeason)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_PurchasingNo)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdLargeGroupMaterial)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSemiGroupMaterial)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdDetailGroupMaterial)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MaterialCode)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdDepartment)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdPaymentCondition)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Incharge)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeacePanel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeacePanel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeacePanel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeacePanel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeacePanel7)
        Me.FlowLayoutPanel1.Controls.Add(Me.PeacePanel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.pCheckRequest)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_CustomerCode)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Article)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Line)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(338, 680)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'txt_SdateEdate
        '
        Me.txt_SdateEdate.ButtonTitle = "Period"
        Me.txt_SdateEdate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SdateEdate.Location = New System.Drawing.Point(1, 1)
        Me.txt_SdateEdate.Margin = New System.Windows.Forms.Padding(1, 1, 1, 2)
        Me.txt_SdateEdate.Name = "txt_SdateEdate"
        Me.txt_SdateEdate.Size = New System.Drawing.Size(333, 21)
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
        Me.txt_GCODE.Size = New System.Drawing.Size(333, 24)
        Me.txt_GCODE.TabIndex = 1
        '
        'txt_SupplierCode
        '
        Me.txt_SupplierCode.BackYesno = False
        Me.txt_SupplierCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SupplierCode.ButtonEnabled = True
        Me.txt_SupplierCode.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_SupplierCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_SupplierCode.ButtonName = Nothing
        Me.txt_SupplierCode.ButtonTitle = "Supplier"
        Me.txt_SupplierCode.Code = ""
        Me.txt_SupplierCode.Data = ""
        Me.txt_SupplierCode.DataDecimal = 0
        Me.txt_SupplierCode.DataLen = 0
        Me.txt_SupplierCode.DataValue = 0
        Me.txt_SupplierCode.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SupplierCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SupplierCode.Location = New System.Drawing.Point(1, 51)
        Me.txt_SupplierCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SupplierCode.Name = "txt_SupplierCode"
        Me.txt_SupplierCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SupplierCode.Size = New System.Drawing.Size(333, 24)
        Me.txt_SupplierCode.TabIndex = 2
        Me.txt_SupplierCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SupplierCode.TextBoxAutoComplete = False
        Me.txt_SupplierCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SupplierCode.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SupplierCode.TextEnabled = True
        Me.txt_SupplierCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SupplierCode.TextMaxLength = 32767
        Me.txt_SupplierCode.TextMultiLine = False
        Me.txt_SupplierCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SupplierCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SupplierCode.UseSendTab = True
        '
        'txt_cdSeason
        '
        Me.txt_cdSeason.BackYesno = False
        Me.txt_cdSeason.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSeason.ButtonEnabled = True
        Me.txt_cdSeason.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSeason.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.ButtonName = Nothing
        Me.txt_cdSeason.ButtonTitle = "Season"
        Me.txt_cdSeason.Code = ""
        Me.txt_cdSeason.Data = ""
        Me.txt_cdSeason.DataDecimal = 0
        Me.txt_cdSeason.DataLen = 0
        Me.txt_cdSeason.DataValue = 0
        Me.txt_cdSeason.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSeason.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSeason.Location = New System.Drawing.Point(1, 77)
        Me.txt_cdSeason.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSeason.Name = "txt_cdSeason"
        Me.txt_cdSeason.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSeason.Size = New System.Drawing.Size(333, 24)
        Me.txt_cdSeason.TabIndex = 275
        Me.txt_cdSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSeason.TextBoxAutoComplete = False
        Me.txt_cdSeason.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSeason.TextEnabled = True
        Me.txt_cdSeason.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextMaxLength = 32767
        Me.txt_cdSeason.TextMultiLine = False
        Me.txt_cdSeason.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSeason.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSeason.UseSendTab = True
        Me.txt_cdSeason.Visible = False
        '
        'txt_PurchasingNo
        '
        Me.txt_PurchasingNo.BackYesno = False
        Me.txt_PurchasingNo.ButtonTitle = Nothing
        Me.txt_PurchasingNo.Code = Nothing
        Me.txt_PurchasingNo.Data = ""
        Me.txt_PurchasingNo.DataDecimal = 0
        Me.txt_PurchasingNo.DataLen = 0
        Me.txt_PurchasingNo.DataValue = 0
        Me.txt_PurchasingNo.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_PurchasingNo.FormatDecimal = 0
        Me.txt_PurchasingNo.FormatValue = False
        Me.txt_PurchasingNo.LableBackColor = System.Drawing.Color.Empty
        Me.txt_PurchasingNo.LableEnabled = True
        Me.txt_PurchasingNo.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_PurchasingNo.LableForeColor = System.Drawing.Color.Black
        Me.txt_PurchasingNo.LableTitle = "PO#"
        Me.txt_PurchasingNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_PurchasingNo.Location = New System.Drawing.Point(1, 103)
        Me.txt_PurchasingNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_PurchasingNo.Name = "txt_PurchasingNo"
        Me.txt_PurchasingNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_PurchasingNo.Size = New System.Drawing.Size(333, 24)
        Me.txt_PurchasingNo.TabIndex = 274
        Me.txt_PurchasingNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_PurchasingNo.TextBoxAutoComplete = False
        Me.txt_PurchasingNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_PurchasingNo.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_PurchasingNo.TextEnabled = True
        Me.txt_PurchasingNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_PurchasingNo.TextMaxLength = 32767
        Me.txt_PurchasingNo.TextMultiLine = False
        Me.txt_PurchasingNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_PurchasingNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_PurchasingNo.UseSendTab = True
        '
        'txt_cdLargeGroupMaterial
        '
        Me.txt_cdLargeGroupMaterial.BackYesno = False
        Me.txt_cdLargeGroupMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLargeGroupMaterial.ButtonEnabled = True
        Me.txt_cdLargeGroupMaterial.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLargeGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.ButtonName = Nothing
        Me.txt_cdLargeGroupMaterial.ButtonTitle = "Large Group"
        Me.txt_cdLargeGroupMaterial.Code = ""
        Me.txt_cdLargeGroupMaterial.Data = ""
        Me.txt_cdLargeGroupMaterial.DataDecimal = 0
        Me.txt_cdLargeGroupMaterial.DataLen = 0
        Me.txt_cdLargeGroupMaterial.DataValue = 0
        Me.txt_cdLargeGroupMaterial.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdLargeGroupMaterial.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdLargeGroupMaterial.Location = New System.Drawing.Point(1, 129)
        Me.txt_cdLargeGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLargeGroupMaterial.Name = "txt_cdLargeGroupMaterial"
        Me.txt_cdLargeGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLargeGroupMaterial.Size = New System.Drawing.Size(333, 24)
        Me.txt_cdLargeGroupMaterial.TabIndex = 3
        Me.txt_cdLargeGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLargeGroupMaterial.TextBoxAutoComplete = False
        Me.txt_cdLargeGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdLargeGroupMaterial.TextEnabled = True
        Me.txt_cdLargeGroupMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.TextMaxLength = 32767
        Me.txt_cdLargeGroupMaterial.TextMultiLine = False
        Me.txt_cdLargeGroupMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLargeGroupMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLargeGroupMaterial.UseSendTab = True
        '
        'txt_cdSemiGroupMaterial
        '
        Me.txt_cdSemiGroupMaterial.BackYesno = False
        Me.txt_cdSemiGroupMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSemiGroupMaterial.ButtonEnabled = True
        Me.txt_cdSemiGroupMaterial.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSemiGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.ButtonName = Nothing
        Me.txt_cdSemiGroupMaterial.ButtonTitle = "Semi Group"
        Me.txt_cdSemiGroupMaterial.Code = ""
        Me.txt_cdSemiGroupMaterial.Data = ""
        Me.txt_cdSemiGroupMaterial.DataDecimal = 0
        Me.txt_cdSemiGroupMaterial.DataLen = 0
        Me.txt_cdSemiGroupMaterial.DataValue = 0
        Me.txt_cdSemiGroupMaterial.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSemiGroupMaterial.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSemiGroupMaterial.Location = New System.Drawing.Point(1, 155)
        Me.txt_cdSemiGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSemiGroupMaterial.Name = "txt_cdSemiGroupMaterial"
        Me.txt_cdSemiGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSemiGroupMaterial.Size = New System.Drawing.Size(333, 24)
        Me.txt_cdSemiGroupMaterial.TabIndex = 4
        Me.txt_cdSemiGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSemiGroupMaterial.TextBoxAutoComplete = False
        Me.txt_cdSemiGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSemiGroupMaterial.TextEnabled = True
        Me.txt_cdSemiGroupMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.TextMaxLength = 32767
        Me.txt_cdSemiGroupMaterial.TextMultiLine = False
        Me.txt_cdSemiGroupMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSemiGroupMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSemiGroupMaterial.UseSendTab = True
        '
        'txt_cdDetailGroupMaterial
        '
        Me.txt_cdDetailGroupMaterial.BackYesno = False
        Me.txt_cdDetailGroupMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDetailGroupMaterial.ButtonEnabled = True
        Me.txt_cdDetailGroupMaterial.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdDetailGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.ButtonName = Nothing
        Me.txt_cdDetailGroupMaterial.ButtonTitle = "Detail Group"
        Me.txt_cdDetailGroupMaterial.Code = ""
        Me.txt_cdDetailGroupMaterial.Data = ""
        Me.txt_cdDetailGroupMaterial.DataDecimal = 0
        Me.txt_cdDetailGroupMaterial.DataLen = 0
        Me.txt_cdDetailGroupMaterial.DataValue = 0
        Me.txt_cdDetailGroupMaterial.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdDetailGroupMaterial.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDetailGroupMaterial.Location = New System.Drawing.Point(1, 181)
        Me.txt_cdDetailGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDetailGroupMaterial.Name = "txt_cdDetailGroupMaterial"
        Me.txt_cdDetailGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDetailGroupMaterial.Size = New System.Drawing.Size(333, 24)
        Me.txt_cdDetailGroupMaterial.TabIndex = 6
        Me.txt_cdDetailGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDetailGroupMaterial.TextBoxAutoComplete = False
        Me.txt_cdDetailGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdDetailGroupMaterial.TextEnabled = True
        Me.txt_cdDetailGroupMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.TextMaxLength = 32767
        Me.txt_cdDetailGroupMaterial.TextMultiLine = False
        Me.txt_cdDetailGroupMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDetailGroupMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDetailGroupMaterial.UseSendTab = True
        '
        'txt_MaterialCode
        '
        Me.txt_MaterialCode.BackYesno = False
        Me.txt_MaterialCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_MaterialCode.ButtonEnabled = True
        Me.txt_MaterialCode.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_MaterialCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.ButtonName = Nothing
        Me.txt_MaterialCode.ButtonTitle = "Material Code"
        Me.txt_MaterialCode.Code = ""
        Me.txt_MaterialCode.Data = ""
        Me.txt_MaterialCode.DataDecimal = 0
        Me.txt_MaterialCode.DataLen = 0
        Me.txt_MaterialCode.DataValue = 0
        Me.txt_MaterialCode.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_MaterialCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MaterialCode.Location = New System.Drawing.Point(1, 207)
        Me.txt_MaterialCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialCode.Name = "txt_MaterialCode"
        Me.txt_MaterialCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialCode.Size = New System.Drawing.Size(333, 24)
        Me.txt_MaterialCode.TabIndex = 7
        Me.txt_MaterialCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialCode.TextBoxAutoComplete = False
        Me.txt_MaterialCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_MaterialCode.TextEnabled = True
        Me.txt_MaterialCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.TextMaxLength = 32767
        Me.txt_MaterialCode.TextMultiLine = False
        Me.txt_MaterialCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialCode.UseSendTab = True
        '
        'txt_cdDepartment
        '
        Me.txt_cdDepartment.BackYesno = False
        Me.txt_cdDepartment.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDepartment.ButtonEnabled = True
        Me.txt_cdDepartment.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdDepartment.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.ButtonName = Nothing
        Me.txt_cdDepartment.ButtonTitle = "Department"
        Me.txt_cdDepartment.Code = ""
        Me.txt_cdDepartment.Data = ""
        Me.txt_cdDepartment.DataDecimal = 0
        Me.txt_cdDepartment.DataLen = 0
        Me.txt_cdDepartment.DataValue = 0
        Me.txt_cdDepartment.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdDepartment.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDepartment.Location = New System.Drawing.Point(1, 233)
        Me.txt_cdDepartment.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDepartment.Name = "txt_cdDepartment"
        Me.txt_cdDepartment.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDepartment.Size = New System.Drawing.Size(333, 24)
        Me.txt_cdDepartment.TabIndex = 8
        Me.txt_cdDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDepartment.TextBoxAutoComplete = False
        Me.txt_cdDepartment.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdDepartment.TextEnabled = True
        Me.txt_cdDepartment.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextMaxLength = 32767
        Me.txt_cdDepartment.TextMultiLine = False
        Me.txt_cdDepartment.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDepartment.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDepartment.UseSendTab = True
        '
        'txt_cdPaymentCondition
        '
        Me.txt_cdPaymentCondition.BackYesno = False
        Me.txt_cdPaymentCondition.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdPaymentCondition.ButtonEnabled = True
        Me.txt_cdPaymentCondition.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdPaymentCondition.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdPaymentCondition.ButtonName = Nothing
        Me.txt_cdPaymentCondition.ButtonTitle = "Payment"
        Me.txt_cdPaymentCondition.Code = ""
        Me.txt_cdPaymentCondition.Data = ""
        Me.txt_cdPaymentCondition.DataDecimal = 0
        Me.txt_cdPaymentCondition.DataLen = 0
        Me.txt_cdPaymentCondition.DataValue = 0
        Me.txt_cdPaymentCondition.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdPaymentCondition.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdPaymentCondition.Location = New System.Drawing.Point(1, 259)
        Me.txt_cdPaymentCondition.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdPaymentCondition.Name = "txt_cdPaymentCondition"
        Me.txt_cdPaymentCondition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdPaymentCondition.Size = New System.Drawing.Size(333, 24)
        Me.txt_cdPaymentCondition.TabIndex = 15
        Me.txt_cdPaymentCondition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdPaymentCondition.TextBoxAutoComplete = False
        Me.txt_cdPaymentCondition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdPaymentCondition.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdPaymentCondition.TextEnabled = True
        Me.txt_cdPaymentCondition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdPaymentCondition.TextMaxLength = 32767
        Me.txt_cdPaymentCondition.TextMultiLine = False
        Me.txt_cdPaymentCondition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdPaymentCondition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdPaymentCondition.UseSendTab = True
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
        Me.txt_Incharge.Location = New System.Drawing.Point(1, 285)
        Me.txt_Incharge.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Incharge.Name = "txt_Incharge"
        Me.txt_Incharge.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Incharge.Size = New System.Drawing.Size(333, 24)
        Me.txt_Incharge.TabIndex = 18
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
        'PeacePanel3
        '
        Me.PeacePanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.chk_CheckIOType1)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckIOType0)
        Me.PeacePanel3.Controls.Add(Me.lbt_Warehouse)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(3, 313)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(329, 28)
        Me.PeacePanel3.TabIndex = 168
        Me.PeacePanel3.Tag = ""
        Me.PeacePanel3.Visible = False
        '
        'chk_CheckIOType1
        '
        Me.chk_CheckIOType1.AutoSize = True
        Me.chk_CheckIOType1.ButtonTitle = Nothing
        Me.chk_CheckIOType1.Checked = True
        Me.chk_CheckIOType1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckIOType1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckIOType1.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckIOType1.Location = New System.Drawing.Point(226, 5)
        Me.chk_CheckIOType1.Name = "chk_CheckIOType1"
        Me.chk_CheckIOType1.Size = New System.Drawing.Size(89, 18)
        Me.chk_CheckIOType1.TabIndex = 1
        Me.chk_CheckIOType1.Text = "OutBound"
        Me.chk_CheckIOType1.UseVisualStyleBackColor = True
        '
        'chk_CheckIOType0
        '
        Me.chk_CheckIOType0.AutoSize = True
        Me.chk_CheckIOType0.ButtonTitle = Nothing
        Me.chk_CheckIOType0.Checked = True
        Me.chk_CheckIOType0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckIOType0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckIOType0.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckIOType0.Location = New System.Drawing.Point(127, 5)
        Me.chk_CheckIOType0.Name = "chk_CheckIOType0"
        Me.chk_CheckIOType0.Size = New System.Drawing.Size(79, 18)
        Me.chk_CheckIOType0.TabIndex = 0
        Me.chk_CheckIOType0.Text = "InBound"
        Me.chk_CheckIOType0.UseVisualStyleBackColor = True
        '
        'lbt_Warehouse
        '
        Me.lbt_Warehouse.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lbt_Warehouse.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbt_Warehouse.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbt_Warehouse.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbt_Warehouse.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbt_Warehouse.ButtonTitle = Nothing
        Me.lbt_Warehouse.Code = ""
        Me.lbt_Warehouse.Data = ""
        Me.lbt_Warehouse.DTDec = 0
        Me.lbt_Warehouse.DTLen = 0
        Me.lbt_Warehouse.DTValue = 0
        Me.lbt_Warehouse.Location = New System.Drawing.Point(0, 0)
        Me.lbt_Warehouse.Name = "lbt_Warehouse"
        Me.lbt_Warehouse.NoClear = False
        Me.lbt_Warehouse.Size = New System.Drawing.Size(109, 24)
        Me.lbt_Warehouse.TabIndex = 167
        Me.lbt_Warehouse.Tag = ""
        Me.lbt_Warehouse.Text = "Warehouse"
        Me.lbt_Warehouse.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Controls.Add(Me.chk_CheckMaterialType1)
        Me.PeacePanel2.Controls.Add(Me.chk_CheckMaterialType0)
        Me.PeacePanel2.Controls.Add(Me.PeaceLabel1)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Location = New System.Drawing.Point(3, 347)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(328, 27)
        Me.PeacePanel2.TabIndex = 166
        Me.PeacePanel2.Tag = ""
        Me.PeacePanel2.Visible = False
        '
        'chk_CheckMaterialType1
        '
        Me.chk_CheckMaterialType1.AutoSize = True
        Me.chk_CheckMaterialType1.ButtonTitle = Nothing
        Me.chk_CheckMaterialType1.Checked = True
        Me.chk_CheckMaterialType1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckMaterialType1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckMaterialType1.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckMaterialType1.Location = New System.Drawing.Point(225, 3)
        Me.chk_CheckMaterialType1.Name = "chk_CheckMaterialType1"
        Me.chk_CheckMaterialType1.Size = New System.Drawing.Size(70, 18)
        Me.chk_CheckMaterialType1.TabIndex = 1
        Me.chk_CheckMaterialType1.Text = "Sample"
        Me.chk_CheckMaterialType1.UseVisualStyleBackColor = True
        '
        'chk_CheckMaterialType0
        '
        Me.chk_CheckMaterialType0.AutoSize = True
        Me.chk_CheckMaterialType0.ButtonTitle = Nothing
        Me.chk_CheckMaterialType0.Checked = True
        Me.chk_CheckMaterialType0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckMaterialType0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckMaterialType0.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckMaterialType0.Location = New System.Drawing.Point(127, 6)
        Me.chk_CheckMaterialType0.Name = "chk_CheckMaterialType0"
        Me.chk_CheckMaterialType0.Size = New System.Drawing.Size(68, 18)
        Me.chk_CheckMaterialType0.TabIndex = 0
        Me.chk_CheckMaterialType0.Text = "Normal"
        Me.chk_CheckMaterialType0.UseVisualStyleBackColor = True
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(1, 0)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(107, 24)
        Me.PeaceLabel1.TabIndex = 165
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "Material Type"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel5
        '
        Me.PeacePanel5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel5.Code = ""
        Me.PeacePanel5.Controls.Add(Me.chk_CheckProcessMaterial1)
        Me.PeacePanel5.Controls.Add(Me.chk_CheckProcessMaterial0)
        Me.PeacePanel5.Controls.Add(Me.PeaceLabel4)
        Me.PeacePanel5.Data = ""
        Me.PeacePanel5.Location = New System.Drawing.Point(3, 380)
        Me.PeacePanel5.Name = "PeacePanel5"
        Me.PeacePanel5.Size = New System.Drawing.Size(329, 29)
        Me.PeacePanel5.TabIndex = 164
        Me.PeacePanel5.Tag = ""
        Me.PeacePanel5.Visible = False
        '
        'chk_CheckProcessMaterial1
        '
        Me.chk_CheckProcessMaterial1.AutoSize = True
        Me.chk_CheckProcessMaterial1.ButtonTitle = Nothing
        Me.chk_CheckProcessMaterial1.Checked = True
        Me.chk_CheckProcessMaterial1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckProcessMaterial1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckProcessMaterial1.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckProcessMaterial1.Location = New System.Drawing.Point(226, 7)
        Me.chk_CheckProcessMaterial1.Name = "chk_CheckProcessMaterial1"
        Me.chk_CheckProcessMaterial1.Size = New System.Drawing.Size(69, 18)
        Me.chk_CheckProcessMaterial1.TabIndex = 1
        Me.chk_CheckProcessMaterial1.Text = "Return"
        Me.chk_CheckProcessMaterial1.UseVisualStyleBackColor = True
        '
        'chk_CheckProcessMaterial0
        '
        Me.chk_CheckProcessMaterial0.AutoSize = True
        Me.chk_CheckProcessMaterial0.ButtonTitle = Nothing
        Me.chk_CheckProcessMaterial0.Checked = True
        Me.chk_CheckProcessMaterial0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckProcessMaterial0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckProcessMaterial0.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckProcessMaterial0.Location = New System.Drawing.Point(127, 6)
        Me.chk_CheckProcessMaterial0.Name = "chk_CheckProcessMaterial0"
        Me.chk_CheckProcessMaterial0.Size = New System.Drawing.Size(95, 18)
        Me.chk_CheckProcessMaterial0.TabIndex = 0
        Me.chk_CheckProcessMaterial0.Text = "PurChasing"
        Me.chk_CheckProcessMaterial0.UseVisualStyleBackColor = True
        '
        'PeaceLabel4
        '
        Me.PeaceLabel4.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel4.ButtonTitle = Nothing
        Me.PeaceLabel4.Code = ""
        Me.PeaceLabel4.Data = ""
        Me.PeaceLabel4.DTDec = 0
        Me.PeaceLabel4.DTLen = 0
        Me.PeaceLabel4.DTValue = 0
        Me.PeaceLabel4.Location = New System.Drawing.Point(1, 2)
        Me.PeaceLabel4.Name = "PeaceLabel4"
        Me.PeaceLabel4.NoClear = False
        Me.PeaceLabel4.Size = New System.Drawing.Size(107, 24)
        Me.PeaceLabel4.TabIndex = 163
        Me.PeaceLabel4.Tag = ""
        Me.PeaceLabel4.Text = "Process"
        Me.PeaceLabel4.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel4
        '
        Me.PeacePanel4.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeacePanel4.Appearance.Options.UseBackColor = True
        Me.PeacePanel4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel4.Code = ""
        Me.PeacePanel4.Controls.Add(Me.chk_CheckMarketType1)
        Me.PeacePanel4.Controls.Add(Me.chk_CheckMarketType0)
        Me.PeacePanel4.Controls.Add(Me.PeaceLabel3)
        Me.PeacePanel4.Data = ""
        Me.PeacePanel4.Location = New System.Drawing.Point(3, 415)
        Me.PeacePanel4.Name = "PeacePanel4"
        Me.PeacePanel4.Size = New System.Drawing.Size(329, 27)
        Me.PeacePanel4.TabIndex = 162
        Me.PeacePanel4.Tag = ""
        Me.PeacePanel4.Visible = False
        '
        'chk_CheckMarketType1
        '
        Me.chk_CheckMarketType1.AutoSize = True
        Me.chk_CheckMarketType1.ButtonTitle = Nothing
        Me.chk_CheckMarketType1.Checked = True
        Me.chk_CheckMarketType1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckMarketType1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckMarketType1.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckMarketType1.Location = New System.Drawing.Point(226, 4)
        Me.chk_CheckMarketType1.Name = "chk_CheckMarketType1"
        Me.chk_CheckMarketType1.Size = New System.Drawing.Size(82, 18)
        Me.chk_CheckMarketType1.TabIndex = 1
        Me.chk_CheckMarketType1.Text = "Domestic"
        Me.chk_CheckMarketType1.UseVisualStyleBackColor = True
        '
        'chk_CheckMarketType0
        '
        Me.chk_CheckMarketType0.AutoSize = True
        Me.chk_CheckMarketType0.ButtonTitle = Nothing
        Me.chk_CheckMarketType0.Checked = True
        Me.chk_CheckMarketType0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckMarketType0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckMarketType0.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckMarketType0.Location = New System.Drawing.Point(127, 4)
        Me.chk_CheckMarketType0.Name = "chk_CheckMarketType0"
        Me.chk_CheckMarketType0.Size = New System.Drawing.Size(67, 18)
        Me.chk_CheckMarketType0.TabIndex = 0
        Me.chk_CheckMarketType0.Text = "Export"
        Me.chk_CheckMarketType0.UseVisualStyleBackColor = True
        '
        'PeaceLabel3
        '
        Me.PeaceLabel3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel3.ButtonTitle = Nothing
        Me.PeaceLabel3.Code = ""
        Me.PeaceLabel3.Data = ""
        Me.PeaceLabel3.DTDec = 0
        Me.PeaceLabel3.DTLen = 0
        Me.PeaceLabel3.DTValue = 0
        Me.PeaceLabel3.Location = New System.Drawing.Point(1, 0)
        Me.PeaceLabel3.Name = "PeaceLabel3"
        Me.PeaceLabel3.NoClear = False
        Me.PeaceLabel3.Size = New System.Drawing.Size(109, 24)
        Me.PeaceLabel3.TabIndex = 161
        Me.PeaceLabel3.Tag = ""
        Me.PeaceLabel3.Text = "Market Type"
        Me.PeaceLabel3.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel7
        '
        Me.PeacePanel7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel7.Code = ""
        Me.PeacePanel7.Controls.Add(Me.opt_ChkDetail)
        Me.PeacePanel7.Controls.Add(Me.opt_ChkGroup)
        Me.PeacePanel7.Controls.Add(Me.PeaceLabel5)
        Me.PeacePanel7.Data = ""
        Me.PeacePanel7.Location = New System.Drawing.Point(1, 446)
        Me.PeacePanel7.Margin = New System.Windows.Forms.Padding(1)
        Me.PeacePanel7.Name = "PeacePanel7"
        Me.PeacePanel7.Size = New System.Drawing.Size(331, 28)
        Me.PeacePanel7.TabIndex = 273
        Me.PeacePanel7.Tag = ""
        '
        'opt_ChkDetail
        '
        Me.opt_ChkDetail.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.opt_ChkDetail.Location = New System.Drawing.Point(228, 3)
        Me.opt_ChkDetail.Margin = New System.Windows.Forms.Padding(1)
        Me.opt_ChkDetail.Name = "opt_ChkDetail"
        Me.opt_ChkDetail.Size = New System.Drawing.Size(82, 22)
        Me.opt_ChkDetail.TabIndex = 4
        Me.opt_ChkDetail.Text = "Detail"
        Me.opt_ChkDetail.UseVisualStyleBackColor = True
        '
        'opt_ChkGroup
        '
        Me.opt_ChkGroup.Checked = True
        Me.opt_ChkGroup.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.opt_ChkGroup.Location = New System.Drawing.Point(133, 2)
        Me.opt_ChkGroup.Margin = New System.Windows.Forms.Padding(1)
        Me.opt_ChkGroup.Name = "opt_ChkGroup"
        Me.opt_ChkGroup.Size = New System.Drawing.Size(76, 22)
        Me.opt_ChkGroup.TabIndex = 3
        Me.opt_ChkGroup.TabStop = True
        Me.opt_ChkGroup.Text = "Group"
        Me.opt_ChkGroup.UseVisualStyleBackColor = True
        '
        'PeaceLabel5
        '
        Me.PeaceLabel5.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel5.ButtonTitle = Nothing
        Me.PeaceLabel5.Code = ""
        Me.PeaceLabel5.Data = ""
        Me.PeaceLabel5.DTDec = 0
        Me.PeaceLabel5.DTLen = 0
        Me.PeaceLabel5.DTValue = 0
        Me.PeaceLabel5.Location = New System.Drawing.Point(2, 0)
        Me.PeaceLabel5.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel5.Name = "PeaceLabel5"
        Me.PeaceLabel5.NoClear = False
        Me.PeaceLabel5.Size = New System.Drawing.Size(109, 25)
        Me.PeaceLabel5.TabIndex = 274
        Me.PeaceLabel5.Tag = ""
        Me.PeaceLabel5.Text = "Base"
        Me.PeaceLabel5.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.chk_CheckRelationType1)
        Me.PeacePanel1.Controls.Add(Me.chk_CheckRelationType0)
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel6)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(1, 476)
        Me.PeacePanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(331, 28)
        Me.PeacePanel1.TabIndex = 275
        Me.PeacePanel1.Tag = ""
        '
        'chk_CheckRelationType1
        '
        Me.chk_CheckRelationType1.AutoSize = True
        Me.chk_CheckRelationType1.ButtonTitle = Nothing
        Me.chk_CheckRelationType1.Checked = True
        Me.chk_CheckRelationType1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckRelationType1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckRelationType1.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckRelationType1.Location = New System.Drawing.Point(230, 5)
        Me.chk_CheckRelationType1.Name = "chk_CheckRelationType1"
        Me.chk_CheckRelationType1.Size = New System.Drawing.Size(77, 18)
        Me.chk_CheckRelationType1.TabIndex = 276
        Me.chk_CheckRelationType1.Text = "Request"
        Me.chk_CheckRelationType1.UseVisualStyleBackColor = True
        '
        'chk_CheckRelationType0
        '
        Me.chk_CheckRelationType0.AutoSize = True
        Me.chk_CheckRelationType0.ButtonTitle = Nothing
        Me.chk_CheckRelationType0.Checked = True
        Me.chk_CheckRelationType0.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_CheckRelationType0.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckRelationType0.ForeColor = System.Drawing.Color.Black
        Me.chk_CheckRelationType0.Location = New System.Drawing.Point(133, 5)
        Me.chk_CheckRelationType0.Name = "chk_CheckRelationType0"
        Me.chk_CheckRelationType0.Size = New System.Drawing.Size(60, 18)
        Me.chk_CheckRelationType0.TabIndex = 275
        Me.chk_CheckRelationType0.Text = "Order"
        Me.chk_CheckRelationType0.UseVisualStyleBackColor = True
        '
        'PeaceLabel6
        '
        Me.PeaceLabel6.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel6.ButtonTitle = Nothing
        Me.PeaceLabel6.Code = ""
        Me.PeaceLabel6.Data = ""
        Me.PeaceLabel6.DTDec = 0
        Me.PeaceLabel6.DTLen = 0
        Me.PeaceLabel6.DTValue = 0
        Me.PeaceLabel6.Location = New System.Drawing.Point(2, 0)
        Me.PeaceLabel6.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel6.Name = "PeaceLabel6"
        Me.PeaceLabel6.NoClear = False
        Me.PeaceLabel6.Size = New System.Drawing.Size(109, 25)
        Me.PeaceLabel6.TabIndex = 274
        Me.PeaceLabel6.Tag = ""
        Me.PeaceLabel6.Text = "Kind"
        Me.PeaceLabel6.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'pCheckRequest
        '
        Me.pCheckRequest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pCheckRequest.Controls.Add(Me.opt_SEL5)
        Me.pCheckRequest.Controls.Add(Me.opt_SEL4)
        Me.pCheckRequest.Controls.Add(Me.opt_SEL3)
        Me.pCheckRequest.Controls.Add(Me.opt_SEL2)
        Me.pCheckRequest.Controls.Add(Me.opt_SEL1)
        Me.pCheckRequest.Controls.Add(Me.opt_SEL0)
        Me.pCheckRequest.Controls.Add(Me.SelectLabelText1)
        Me.pCheckRequest.Location = New System.Drawing.Point(1, 506)
        Me.pCheckRequest.Margin = New System.Windows.Forms.Padding(1)
        Me.pCheckRequest.Name = "pCheckRequest"
        Me.pCheckRequest.Size = New System.Drawing.Size(332, 86)
        Me.pCheckRequest.TabIndex = 16
        '
        'opt_SEL5
        '
        Me.opt_SEL5.ButtonTitle = Nothing
        Me.opt_SEL5.Checked = True
        Me.opt_SEL5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL5.Location = New System.Drawing.Point(234, 54)
        Me.opt_SEL5.Name = "opt_SEL5"
        Me.opt_SEL5.Size = New System.Drawing.Size(96, 24)
        Me.opt_SEL5.TabIndex = 6
        Me.opt_SEL5.TabStop = True
        Me.opt_SEL5.Text = "Total"
        Me.opt_SEL5.UseVisualStyleBackColor = True
        '
        'opt_SEL4
        '
        Me.opt_SEL4.ButtonTitle = Nothing
        Me.opt_SEL4.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL4.Location = New System.Drawing.Point(234, 29)
        Me.opt_SEL4.Name = "opt_SEL4"
        Me.opt_SEL4.Size = New System.Drawing.Size(96, 24)
        Me.opt_SEL4.TabIndex = 5
        Me.opt_SEL4.Text = "Pending"
        Me.opt_SEL4.UseVisualStyleBackColor = True
        '
        'opt_SEL3
        '
        Me.opt_SEL3.ButtonTitle = Nothing
        Me.opt_SEL3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL3.Location = New System.Drawing.Point(234, 4)
        Me.opt_SEL3.Name = "opt_SEL3"
        Me.opt_SEL3.Size = New System.Drawing.Size(96, 24)
        Me.opt_SEL3.TabIndex = 4
        Me.opt_SEL3.Text = "Cancel"
        Me.opt_SEL3.UseVisualStyleBackColor = True
        '
        'opt_SEL2
        '
        Me.opt_SEL2.ButtonTitle = Nothing
        Me.opt_SEL2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL2.Location = New System.Drawing.Point(130, 54)
        Me.opt_SEL2.Name = "opt_SEL2"
        Me.opt_SEL2.Size = New System.Drawing.Size(100, 24)
        Me.opt_SEL2.TabIndex = 3
        Me.opt_SEL2.Text = "Approval"
        Me.opt_SEL2.UseVisualStyleBackColor = True
        '
        'opt_SEL1
        '
        Me.opt_SEL1.ButtonTitle = Nothing
        Me.opt_SEL1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL1.Location = New System.Drawing.Point(130, 29)
        Me.opt_SEL1.Name = "opt_SEL1"
        Me.opt_SEL1.Size = New System.Drawing.Size(100, 24)
        Me.opt_SEL1.TabIndex = 2
        Me.opt_SEL1.Text = "Complete"
        Me.opt_SEL1.UseVisualStyleBackColor = True
        '
        'opt_SEL0
        '
        Me.opt_SEL0.ButtonTitle = Nothing
        Me.opt_SEL0.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL0.Location = New System.Drawing.Point(130, 4)
        Me.opt_SEL0.Name = "opt_SEL0"
        Me.opt_SEL0.Size = New System.Drawing.Size(100, 24)
        Me.opt_SEL0.TabIndex = 1
        Me.opt_SEL0.Text = "Not Approval"
        Me.opt_SEL0.UseVisualStyleBackColor = True
        '
        'SelectLabelText1
        '
        Me.SelectLabelText1.BackYesno = False
        Me.SelectLabelText1.ButtonTitle = Nothing
        Me.SelectLabelText1.Code = Nothing
        Me.SelectLabelText1.Data = ""
        Me.SelectLabelText1.DataDecimal = 0
        Me.SelectLabelText1.DataLen = 0
        Me.SelectLabelText1.DataValue = 0
        Me.SelectLabelText1.Font = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.SelectLabelText1.FormatDecimal = 0
        Me.SelectLabelText1.FormatValue = False
        Me.SelectLabelText1.LableBackColor = System.Drawing.SystemColors.Control
        Me.SelectLabelText1.LableEnabled = True
        Me.SelectLabelText1.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.SelectLabelText1.LableForeColor = System.Drawing.Color.Black
        Me.SelectLabelText1.LableTitle = "Check Request"
        Me.SelectLabelText1.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.SelectLabelText1.Location = New System.Drawing.Point(1, 1)
        Me.SelectLabelText1.Name = "SelectLabelText1"
        Me.SelectLabelText1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.SelectLabelText1.Size = New System.Drawing.Size(109, 82)
        Me.SelectLabelText1.TabIndex = 0
        Me.SelectLabelText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.SelectLabelText1.TextBoxAutoComplete = False
        Me.SelectLabelText1.TextboxBackColor = System.Drawing.Color.Empty
        Me.SelectLabelText1.TextBoxFont = Nothing
        Me.SelectLabelText1.TextEnabled = True
        Me.SelectLabelText1.TextForeColor = System.Drawing.Color.Empty
        Me.SelectLabelText1.TextMaxLength = 32767
        Me.SelectLabelText1.TextMultiLine = False
        Me.SelectLabelText1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.SelectLabelText1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.SelectLabelText1.UseSendTab = True
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = Nothing
        Me.txt_CustomerCode.ButtonTitle = "Customer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 0
        Me.txt_CustomerCode.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(1, 594)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(332, 24)
        Me.txt_CustomerCode.TabIndex = 3
        Me.txt_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerCode.TextBoxAutoComplete = False
        Me.txt_CustomerCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_CustomerCode.TextEnabled = True
        Me.txt_CustomerCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextMaxLength = 32767
        Me.txt_CustomerCode.TextMultiLine = False
        Me.txt_CustomerCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerCode.UseSendTab = True
        Me.txt_CustomerCode.Visible = False
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
        Me.txt_Article.Location = New System.Drawing.Point(1, 620)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(332, 24)
        Me.txt_Article.TabIndex = 276
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
        Me.txt_Article.Visible = False
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
        Me.txt_Line.Location = New System.Drawing.Point(1, 646)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(332, 24)
        Me.txt_Line.TabIndex = 277
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
        Me.txt_Line.Visible = False
        '
        'Gadget004
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Gadget004"
        Me.Size = New System.Drawing.Size(372, 699)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel3.PerformLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        Me.PeacePanel2.PerformLayout()
        CType(Me.PeacePanel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel5.ResumeLayout(False)
        Me.PeacePanel5.PerformLayout()
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel4.ResumeLayout(False)
        Me.PeacePanel4.PerformLayout()
        CType(Me.PeacePanel7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel7.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        Me.pCheckRequest.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_SdateEdate As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents txt_GCODE As PSMGlobal.SelectMulti
    Friend WithEvents txt_cdLargeGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSemiGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDetailGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_MaterialCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDepartment As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdPaymentCondition As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents pCheckRequest As System.Windows.Forms.Panel
    Friend WithEvents opt_SEL5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL0 As PSMGlobal.PeaceRadioButton
    Friend WithEvents SelectLabelText1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SupplierCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Incharge As PSMGlobal.SelectPeaceHLPButton
    Public WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Public WithEvents chk_CheckIOType1 As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckIOType0 As PSMGlobal.PeaceCheckbox
    Public WithEvents lbt_Warehouse As PSMGlobal.PeaceLabel
    Public WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Public WithEvents chk_CheckMaterialType1 As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckMaterialType0 As PSMGlobal.PeaceCheckbox
    Public WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Public WithEvents PeacePanel5 As PSMGlobal.PeacePanel
    Public WithEvents chk_CheckProcessMaterial1 As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckProcessMaterial0 As PSMGlobal.PeaceCheckbox
    Public WithEvents PeaceLabel4 As PSMGlobal.PeaceLabel
    Public WithEvents PeacePanel4 As PSMGlobal.PeacePanel
    Public WithEvents chk_CheckMarketType1 As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckMarketType0 As PSMGlobal.PeaceCheckbox
    Public WithEvents PeaceLabel3 As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel7 As PSMGlobal.PeacePanel
    Friend WithEvents opt_ChkDetail As System.Windows.Forms.RadioButton
    Friend WithEvents opt_ChkGroup As System.Windows.Forms.RadioButton
    Friend WithEvents PeaceLabel5 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_PurchasingNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdSeason As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents PeaceLabel6 As PSMGlobal.PeaceLabel
    Public WithEvents chk_CheckRelationType1 As PSMGlobal.PeaceCheckbox
    Public WithEvents chk_CheckRelationType0 As PSMGlobal.PeaceCheckbox
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText

End Class
