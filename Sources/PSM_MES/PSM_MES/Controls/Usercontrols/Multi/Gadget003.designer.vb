<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gadget003
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
        Me.txt_Customer = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSite = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDepartment = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdMainProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSpecStatus = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSizeRange = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdIncharge = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SpecNo = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialName = New PSMGlobal.SelectLabelText()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.txt_MoldName = New PSMGlobal.SelectLabelText()
        Me.txt_LastName = New PSMGlobal.SelectLabelText()
        Me.pCheckRequest = New System.Windows.Forms.Panel()
        Me.opt_SEL5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.opt_SEL0 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.SelectLabelText1 = New PSMGlobal.SelectLabelText()
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(18, 21)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 527.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(366, 527)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SdateEdate)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_GCODE)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Customer)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSite)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdDepartment)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdMainProcess)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSpecStatus)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSizeRange)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdIncharge)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_SpecNo)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Article)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Line)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MaterialName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_ColorName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_MoldName)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_LastName)
        Me.FlowLayoutPanel1.Controls.Add(Me.pCheckRequest)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 1)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(364, 525)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'txt_SdateEdate
        '
        Me.txt_SdateEdate.ButtonTitle = "Period"
        Me.txt_SdateEdate.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_SdateEdate.Location = New System.Drawing.Point(1, 1)
        Me.txt_SdateEdate.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SdateEdate.Name = "txt_SdateEdate"
        Me.txt_SdateEdate.Size = New System.Drawing.Size(361, 24)
        Me.txt_SdateEdate.TabIndex = 0
        Me.txt_SdateEdate.text1 = ""
        Me.txt_SdateEdate.text2 = ""
        Me.txt_SdateEdate.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        '
        'txt_GCODE
        '
        Me.txt_GCODE.ButtonTitle = "CustomerMulti"
        Me.txt_GCODE.CheckBoxEnabled = True
        Me.txt_GCODE.CheckBoxTitle = ""
        Me.txt_GCODE.ComboBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_GCODE.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_GCODE.Layoutpercent = "33,6,37,20"
        Me.txt_GCODE.Location = New System.Drawing.Point(1, 27)
        Me.txt_GCODE.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GCODE.Name = "txt_GCODE"
        Me.txt_GCODE.SelectTitle = "Click!"
        Me.txt_GCODE.Size = New System.Drawing.Size(361, 26)
        Me.txt_GCODE.TabIndex = 18
        '
        'txt_Customer
        '
        Me.txt_Customer.BackYesno = False
        Me.txt_Customer.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_Customer.ButtonEnabled = True
        Me.txt_Customer.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_Customer.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_Customer.ButtonName = Nothing
        Me.txt_Customer.ButtonTitle = "Customer"
        Me.txt_Customer.Code = ""
        Me.txt_Customer.Data = ""
        Me.txt_Customer.DataDecimal = 0
        Me.txt_Customer.DataLen = 0
        Me.txt_Customer.DataValue = 0
        Me.txt_Customer.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Customer.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Customer.Location = New System.Drawing.Point(1, 55)
        Me.txt_Customer.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Customer.Name = "txt_Customer"
        Me.txt_Customer.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Customer.Size = New System.Drawing.Size(361, 24)
        Me.txt_Customer.TabIndex = 19
        Me.txt_Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Customer.TextBoxAutoComplete = False
        Me.txt_Customer.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Customer.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_Customer.TextEnabled = True
        Me.txt_Customer.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Customer.TextMaxLength = 32767
        Me.txt_Customer.TextMultiLine = False
        Me.txt_Customer.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Customer.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Customer.UseSendTab = True
        '
        'txt_cdSite
        '
        Me.txt_cdSite.BackYesno = False
        Me.txt_cdSite.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSite.ButtonEnabled = True
        Me.txt_cdSite.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSite.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.ButtonName = Nothing
        Me.txt_cdSite.ButtonTitle = "Site"
        Me.txt_cdSite.Code = ""
        Me.txt_cdSite.Data = ""
        Me.txt_cdSite.DataDecimal = 0
        Me.txt_cdSite.DataLen = 0
        Me.txt_cdSite.DataValue = 0
        Me.txt_cdSite.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdSite.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSite.Location = New System.Drawing.Point(1, 81)
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
        Me.txt_cdDepartment.Location = New System.Drawing.Point(1, 107)
        Me.txt_cdDepartment.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDepartment.Name = "txt_cdDepartment"
        Me.txt_cdDepartment.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDepartment.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdDepartment.TabIndex = 4
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
        'txt_cdMainProcess
        '
        Me.txt_cdMainProcess.BackYesno = False
        Me.txt_cdMainProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess.ButtonEnabled = True
        Me.txt_cdMainProcess.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.ButtonName = Nothing
        Me.txt_cdMainProcess.ButtonTitle = "Main Process"
        Me.txt_cdMainProcess.Code = ""
        Me.txt_cdMainProcess.Data = ""
        Me.txt_cdMainProcess.DataDecimal = 0
        Me.txt_cdMainProcess.DataLen = 0
        Me.txt_cdMainProcess.DataValue = 0
        Me.txt_cdMainProcess.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdMainProcess.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdMainProcess.Location = New System.Drawing.Point(1, 133)
        Me.txt_cdMainProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdMainProcess.Name = "txt_cdMainProcess"
        Me.txt_cdMainProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdMainProcess.TabIndex = 6
        Me.txt_cdMainProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMainProcess.TextBoxAutoComplete = False
        Me.txt_cdMainProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdMainProcess.TextEnabled = True
        Me.txt_cdMainProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextMaxLength = 32767
        Me.txt_cdMainProcess.TextMultiLine = False
        Me.txt_cdMainProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdMainProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdMainProcess.UseSendTab = True
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
        Me.txt_cdSpecStatus.Location = New System.Drawing.Point(1, 159)
        Me.txt_cdSpecStatus.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecStatus.Name = "txt_cdSpecStatus"
        Me.txt_cdSpecStatus.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecStatus.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdSpecStatus.TabIndex = 7
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
        Me.txt_cdSizeRange.Location = New System.Drawing.Point(1, 185)
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
        '
        'txt_cdIncharge
        '
        Me.txt_cdIncharge.BackYesno = False
        Me.txt_cdIncharge.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdIncharge.ButtonEnabled = True
        Me.txt_cdIncharge.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_cdIncharge.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdIncharge.ButtonName = Nothing
        Me.txt_cdIncharge.ButtonTitle = "Incharge"
        Me.txt_cdIncharge.Code = ""
        Me.txt_cdIncharge.Data = ""
        Me.txt_cdIncharge.DataDecimal = 0
        Me.txt_cdIncharge.DataLen = 0
        Me.txt_cdIncharge.DataValue = 0
        Me.txt_cdIncharge.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdIncharge.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdIncharge.Location = New System.Drawing.Point(1, 211)
        Me.txt_cdIncharge.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdIncharge.Name = "txt_cdIncharge"
        Me.txt_cdIncharge.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdIncharge.Size = New System.Drawing.Size(361, 24)
        Me.txt_cdIncharge.TabIndex = 15
        Me.txt_cdIncharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdIncharge.TextBoxAutoComplete = False
        Me.txt_cdIncharge.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdIncharge.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_cdIncharge.TextEnabled = True
        Me.txt_cdIncharge.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdIncharge.TextMaxLength = 32767
        Me.txt_cdIncharge.TextMultiLine = False
        Me.txt_cdIncharge.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdIncharge.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdIncharge.UseSendTab = True
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
        Me.txt_SpecNo.Location = New System.Drawing.Point(1, 237)
        Me.txt_SpecNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SpecNo.Name = "txt_SpecNo"
        Me.txt_SpecNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SpecNo.Size = New System.Drawing.Size(361, 24)
        Me.txt_SpecNo.TabIndex = 5
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
        Me.txt_Article.Location = New System.Drawing.Point(1, 263)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(361, 24)
        Me.txt_Article.TabIndex = 20
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
        Me.txt_Line.Location = New System.Drawing.Point(1, 289)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(361, 24)
        Me.txt_Line.TabIndex = 21
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
        Me.txt_MaterialName.Location = New System.Drawing.Point(1, 315)
        Me.txt_MaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialName.Size = New System.Drawing.Size(361, 24)
        Me.txt_MaterialName.TabIndex = 22
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
        Me.txt_ColorName.Location = New System.Drawing.Point(1, 341)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(361, 24)
        Me.txt_ColorName.TabIndex = 23
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
        Me.txt_MoldName.Location = New System.Drawing.Point(1, 367)
        Me.txt_MoldName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MoldName.Name = "txt_MoldName"
        Me.txt_MoldName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MoldName.Size = New System.Drawing.Size(361, 24)
        Me.txt_MoldName.TabIndex = 24
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
        Me.txt_LastName.Location = New System.Drawing.Point(1, 393)
        Me.txt_LastName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LastName.Name = "txt_LastName"
        Me.txt_LastName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LastName.Size = New System.Drawing.Size(361, 24)
        Me.txt_LastName.TabIndex = 25
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
        Me.pCheckRequest.Location = New System.Drawing.Point(1, 419)
        Me.pCheckRequest.Margin = New System.Windows.Forms.Padding(1)
        Me.pCheckRequest.Name = "pCheckRequest"
        Me.pCheckRequest.Size = New System.Drawing.Size(360, 86)
        Me.pCheckRequest.TabIndex = 27
        '
        'opt_SEL5
        '
        Me.opt_SEL5.ButtonTitle = Nothing
        Me.opt_SEL5.Checked = True
        Me.opt_SEL5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.opt_SEL5.Location = New System.Drawing.Point(260, 54)
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
        Me.opt_SEL4.Location = New System.Drawing.Point(260, 29)
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
        Me.opt_SEL3.Location = New System.Drawing.Point(260, 4)
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
        Me.SelectLabelText1.Size = New System.Drawing.Size(120, 82)
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
        'Gadget003
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Gadget003"
        Me.Size = New System.Drawing.Size(403, 571)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pCheckRequest.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_SdateEdate As PSMGlobal.SelectPeaceCalDou
    Friend WithEvents txt_cdSite As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDepartment As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_SpecNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdMainProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSpecStatus As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSizeRange As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdIncharge As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_GCODE As PSMGlobal.SelectMulti
    Friend WithEvents txt_Customer As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MaterialName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MoldName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LastName As PSMGlobal.SelectLabelText
    Friend WithEvents pCheckRequest As System.Windows.Forms.Panel
    Friend WithEvents opt_SEL5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents opt_SEL0 As PSMGlobal.PeaceRadioButton
    Friend WithEvents SelectLabelText1 As PSMGlobal.SelectLabelText

End Class
