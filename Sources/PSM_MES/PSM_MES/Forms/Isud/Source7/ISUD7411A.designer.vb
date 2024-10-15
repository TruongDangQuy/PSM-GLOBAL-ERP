<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7411A
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
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.Block1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txt_IDNO = New PSMGlobal.SelectLabelText()
        Me.txt_DevelopmenetCode = New PSMGlobal.SelectLabelText()
        Me.txt_Name = New PSMGlobal.SelectLabelText()
        Me.txt_ForeignName = New PSMGlobal.SelectLabelText()
        Me.txt_cdSite = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdNationality = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDepartment = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdOnePosition = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdPosition = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdInCharge = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdMainProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSubProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineProd = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_IDCard = New PSMGlobal.SelectLabelText()
        Me.txt_IDHRCode = New PSMGlobal.SelectLabelText()
        Me.lbla_use = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.rad_CheckUse1 = New System.Windows.Forms.RadioButton()
        Me.rad_CheckUse2 = New System.Windows.Forms.RadioButton()
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Block1.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame1.Code = ""
        Me.Frame1.Controls.Add(Me.Block1)
        Me.Frame1.Data = ""
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 38)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(634, 289)
        Me.Frame1.TabIndex = 3
        Me.Frame1.Tag = ""
        '
        'Block1
        '
        Me.Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Block1.Controls.Add(Me.txt_IDNO)
        Me.Block1.Controls.Add(Me.txt_DevelopmenetCode)
        Me.Block1.Controls.Add(Me.txt_Name)
        Me.Block1.Controls.Add(Me.txt_ForeignName)
        Me.Block1.Controls.Add(Me.txt_cdSite)
        Me.Block1.Controls.Add(Me.txt_cdNationality)
        Me.Block1.Controls.Add(Me.txt_cdDepartment)
        Me.Block1.Controls.Add(Me.txt_cdOnePosition)
        Me.Block1.Controls.Add(Me.txt_cdPosition)
        Me.Block1.Controls.Add(Me.txt_cdInCharge)
        Me.Block1.Controls.Add(Me.txt_cdMainProcess)
        Me.Block1.Controls.Add(Me.txt_cdSubProcess)
        Me.Block1.Controls.Add(Me.txt_cdFactory)
        Me.Block1.Controls.Add(Me.txt_cdLineProd)
        Me.Block1.Controls.Add(Me.txt_IDCard)
        Me.Block1.Controls.Add(Me.txt_IDHRCode)
        Me.Block1.Controls.Add(Me.lbla_use)
        Me.Block1.Controls.Add(Me.PeacePanel1)
        Me.Block1.Location = New System.Drawing.Point(6, 3)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(624, 280)
        Me.Block1.TabIndex = 111
        '
        'txt_IDNO
        '
        Me.txt_IDNO.BackYesno = False
        Me.txt_IDNO.ButtonTitle = Nothing
        Me.txt_IDNO.Code = Nothing
        Me.txt_IDNO.Data = ""
        Me.txt_IDNO.DataDecimal = 0
        Me.txt_IDNO.DataLen = 0
        Me.txt_IDNO.DataValue = 0
        Me.txt_IDNO.FormatDecimal = 0
        Me.txt_IDNO.FormatValue = False
        Me.txt_IDNO.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_IDNO.LableEnabled = True
        Me.txt_IDNO.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_IDNO.LableForeColor = System.Drawing.Color.Empty
        Me.txt_IDNO.LableTitle = "Idno"
        Me.txt_IDNO.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_IDNO.Location = New System.Drawing.Point(2, 2)
        Me.txt_IDNO.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_IDNO.Name = "txt_IDNO"
        Me.txt_IDNO.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_IDNO.Size = New System.Drawing.Size(306, 23)
        Me.txt_IDNO.TabIndex = 0
        Me.txt_IDNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_IDNO.TextBoxAutoComplete = False
        Me.txt_IDNO.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_IDNO.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_IDNO.TextEnabled = True
        Me.txt_IDNO.TextForeColor = System.Drawing.Color.Empty
        Me.txt_IDNO.TextMaxLength = 32767
        Me.txt_IDNO.TextMultiLine = False
        Me.txt_IDNO.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_IDNO.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_IDNO.UseSendTab = True
        '
        'txt_DevelopmenetCode
        '
        Me.txt_DevelopmenetCode.BackYesno = False
        Me.txt_DevelopmenetCode.ButtonTitle = Nothing
        Me.txt_DevelopmenetCode.Code = Nothing
        Me.txt_DevelopmenetCode.Data = ""
        Me.txt_DevelopmenetCode.DataDecimal = 0
        Me.txt_DevelopmenetCode.DataLen = 0
        Me.txt_DevelopmenetCode.DataValue = 0
        Me.txt_DevelopmenetCode.FormatDecimal = 0
        Me.txt_DevelopmenetCode.FormatValue = False
        Me.txt_DevelopmenetCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DevelopmenetCode.LableEnabled = True
        Me.txt_DevelopmenetCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DevelopmenetCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmenetCode.LableTitle = "Dev Code"
        Me.txt_DevelopmenetCode.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_DevelopmenetCode.Location = New System.Drawing.Point(312, 2)
        Me.txt_DevelopmenetCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_DevelopmenetCode.Name = "txt_DevelopmenetCode"
        Me.txt_DevelopmenetCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DevelopmenetCode.Size = New System.Drawing.Size(306, 23)
        Me.txt_DevelopmenetCode.TabIndex = 4
        Me.txt_DevelopmenetCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DevelopmenetCode.TextBoxAutoComplete = False
        Me.txt_DevelopmenetCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DevelopmenetCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DevelopmenetCode.TextEnabled = True
        Me.txt_DevelopmenetCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmenetCode.TextMaxLength = 32767
        Me.txt_DevelopmenetCode.TextMultiLine = False
        Me.txt_DevelopmenetCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DevelopmenetCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DevelopmenetCode.UseSendTab = True
        '
        'txt_Name
        '
        Me.txt_Name.BackYesno = False
        Me.txt_Name.ButtonTitle = Nothing
        Me.txt_Name.Code = Nothing
        Me.txt_Name.Data = ""
        Me.txt_Name.DataDecimal = 0
        Me.txt_Name.DataLen = 0
        Me.txt_Name.DataValue = 0
        Me.txt_Name.FormatDecimal = 0
        Me.txt_Name.FormatValue = False
        Me.txt_Name.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Name.LableEnabled = True
        Me.txt_Name.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Name.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Name.LableTitle = "Employee Name"
        Me.txt_Name.Layoutpercent = New Decimal(New Integer() {225, 0, 0, 196608})
        Me.txt_Name.Location = New System.Drawing.Point(2, 29)
        Me.txt_Name.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Name.Size = New System.Drawing.Size(614, 21)
        Me.txt_Name.TabIndex = 1
        Me.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Name.TextBoxAutoComplete = False
        Me.txt_Name.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Name.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Name.TextEnabled = True
        Me.txt_Name.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Name.TextMaxLength = 32767
        Me.txt_Name.TextMultiLine = False
        Me.txt_Name.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Name.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Name.UseSendTab = True
        '
        'txt_ForeignName
        '
        Me.txt_ForeignName.BackYesno = False
        Me.txt_ForeignName.ButtonTitle = Nothing
        Me.txt_ForeignName.Code = Nothing
        Me.txt_ForeignName.Data = ""
        Me.txt_ForeignName.DataDecimal = 0
        Me.txt_ForeignName.DataLen = 0
        Me.txt_ForeignName.DataValue = 0
        Me.txt_ForeignName.FormatDecimal = 0
        Me.txt_ForeignName.FormatValue = False
        Me.txt_ForeignName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ForeignName.LableEnabled = True
        Me.txt_ForeignName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ForeignName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ForeignName.LableTitle = "Foreign Name"
        Me.txt_ForeignName.Layoutpercent = New Decimal(New Integer() {225, 0, 0, 196608})
        Me.txt_ForeignName.Location = New System.Drawing.Point(2, 54)
        Me.txt_ForeignName.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ForeignName.Name = "txt_ForeignName"
        Me.txt_ForeignName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ForeignName.Size = New System.Drawing.Size(616, 21)
        Me.txt_ForeignName.TabIndex = 2
        Me.txt_ForeignName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ForeignName.TextBoxAutoComplete = False
        Me.txt_ForeignName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ForeignName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ForeignName.TextEnabled = True
        Me.txt_ForeignName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ForeignName.TextMaxLength = 32767
        Me.txt_ForeignName.TextMultiLine = False
        Me.txt_ForeignName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ForeignName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ForeignName.UseSendTab = True
        '
        'txt_cdSite
        '
        Me.txt_cdSite.BackYesno = False
        Me.txt_cdSite.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSite.ButtonEnabled = True
        Me.txt_cdSite.ButtonFont = Nothing
        Me.txt_cdSite.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.ButtonName = "Const_Site"
        Me.txt_cdSite.ButtonTitle = "Company Site"
        Me.txt_cdSite.Code = ""
        Me.txt_cdSite.Data = ""
        Me.txt_cdSite.DataDecimal = 0
        Me.txt_cdSite.DataLen = 0
        Me.txt_cdSite.DataValue = 0
        Me.txt_cdSite.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdSite.Location = New System.Drawing.Point(2, 79)
        Me.txt_cdSite.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdSite.Name = "txt_cdSite"
        Me.txt_cdSite.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSite.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdSite.TabIndex = 3
        Me.txt_cdSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSite.TextBoxAutoComplete = False
        Me.txt_cdSite.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSite.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSite.TextEnabled = True
        Me.txt_cdSite.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.TextMaxLength = 32767
        Me.txt_cdSite.TextMultiLine = False
        Me.txt_cdSite.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSite.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSite.UseSendTab = True
        '
        'txt_cdNationality
        '
        Me.txt_cdNationality.BackYesno = False
        Me.txt_cdNationality.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdNationality.ButtonEnabled = True
        Me.txt_cdNationality.ButtonFont = Nothing
        Me.txt_cdNationality.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdNationality.ButtonName = "Const_Nationality"
        Me.txt_cdNationality.ButtonTitle = "Nationality"
        Me.txt_cdNationality.Code = ""
        Me.txt_cdNationality.Data = ""
        Me.txt_cdNationality.DataDecimal = 0
        Me.txt_cdNationality.DataLen = 0
        Me.txt_cdNationality.DataValue = 0
        Me.txt_cdNationality.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdNationality.Location = New System.Drawing.Point(312, 79)
        Me.txt_cdNationality.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdNationality.Name = "txt_cdNationality"
        Me.txt_cdNationality.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdNationality.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdNationality.TabIndex = 4
        Me.txt_cdNationality.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdNationality.TextBoxAutoComplete = False
        Me.txt_cdNationality.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdNationality.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdNationality.TextEnabled = True
        Me.txt_cdNationality.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdNationality.TextMaxLength = 32767
        Me.txt_cdNationality.TextMultiLine = False
        Me.txt_cdNationality.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdNationality.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdNationality.UseSendTab = True
        '
        'txt_cdDepartment
        '
        Me.txt_cdDepartment.BackYesno = False
        Me.txt_cdDepartment.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDepartment.ButtonEnabled = True
        Me.txt_cdDepartment.ButtonFont = Nothing
        Me.txt_cdDepartment.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.ButtonName = "Const_Department"
        Me.txt_cdDepartment.ButtonTitle = "Department"
        Me.txt_cdDepartment.Code = ""
        Me.txt_cdDepartment.Data = ""
        Me.txt_cdDepartment.DataDecimal = 0
        Me.txt_cdDepartment.DataLen = 0
        Me.txt_cdDepartment.DataValue = 0
        Me.txt_cdDepartment.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdDepartment.Location = New System.Drawing.Point(2, 108)
        Me.txt_cdDepartment.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdDepartment.Name = "txt_cdDepartment"
        Me.txt_cdDepartment.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDepartment.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdDepartment.TabIndex = 5
        Me.txt_cdDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDepartment.TextBoxAutoComplete = False
        Me.txt_cdDepartment.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdDepartment.TextEnabled = True
        Me.txt_cdDepartment.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextMaxLength = 32767
        Me.txt_cdDepartment.TextMultiLine = False
        Me.txt_cdDepartment.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDepartment.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDepartment.UseSendTab = True
        '
        'txt_cdOnePosition
        '
        Me.txt_cdOnePosition.BackYesno = False
        Me.txt_cdOnePosition.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdOnePosition.ButtonEnabled = True
        Me.txt_cdOnePosition.ButtonFont = Nothing
        Me.txt_cdOnePosition.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdOnePosition.ButtonName = "Const_OnePosition"
        Me.txt_cdOnePosition.ButtonTitle = "One Position"
        Me.txt_cdOnePosition.Code = ""
        Me.txt_cdOnePosition.Data = ""
        Me.txt_cdOnePosition.DataDecimal = 0
        Me.txt_cdOnePosition.DataLen = 0
        Me.txt_cdOnePosition.DataValue = 0
        Me.txt_cdOnePosition.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdOnePosition.Location = New System.Drawing.Point(312, 108)
        Me.txt_cdOnePosition.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdOnePosition.Name = "txt_cdOnePosition"
        Me.txt_cdOnePosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdOnePosition.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdOnePosition.TabIndex = 6
        Me.txt_cdOnePosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdOnePosition.TextBoxAutoComplete = False
        Me.txt_cdOnePosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdOnePosition.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdOnePosition.TextEnabled = True
        Me.txt_cdOnePosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdOnePosition.TextMaxLength = 32767
        Me.txt_cdOnePosition.TextMultiLine = False
        Me.txt_cdOnePosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdOnePosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdOnePosition.UseSendTab = True
        '
        'txt_cdPosition
        '
        Me.txt_cdPosition.BackYesno = False
        Me.txt_cdPosition.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdPosition.ButtonEnabled = True
        Me.txt_cdPosition.ButtonFont = Nothing
        Me.txt_cdPosition.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdPosition.ButtonName = "Const_Position"
        Me.txt_cdPosition.ButtonTitle = "Position"
        Me.txt_cdPosition.Code = ""
        Me.txt_cdPosition.Data = ""
        Me.txt_cdPosition.DataDecimal = 0
        Me.txt_cdPosition.DataLen = 0
        Me.txt_cdPosition.DataValue = 0
        Me.txt_cdPosition.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdPosition.Location = New System.Drawing.Point(2, 137)
        Me.txt_cdPosition.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdPosition.Name = "txt_cdPosition"
        Me.txt_cdPosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdPosition.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdPosition.TabIndex = 7
        Me.txt_cdPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdPosition.TextBoxAutoComplete = False
        Me.txt_cdPosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdPosition.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdPosition.TextEnabled = True
        Me.txt_cdPosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdPosition.TextMaxLength = 32767
        Me.txt_cdPosition.TextMultiLine = False
        Me.txt_cdPosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdPosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdPosition.UseSendTab = True
        '
        'txt_cdInCharge
        '
        Me.txt_cdInCharge.BackYesno = False
        Me.txt_cdInCharge.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdInCharge.ButtonEnabled = True
        Me.txt_cdInCharge.ButtonFont = Nothing
        Me.txt_cdInCharge.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdInCharge.ButtonName = "Const_InCharge"
        Me.txt_cdInCharge.ButtonTitle = "In-charge"
        Me.txt_cdInCharge.Code = ""
        Me.txt_cdInCharge.Data = ""
        Me.txt_cdInCharge.DataDecimal = 0
        Me.txt_cdInCharge.DataLen = 0
        Me.txt_cdInCharge.DataValue = 0
        Me.txt_cdInCharge.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdInCharge.Location = New System.Drawing.Point(312, 137)
        Me.txt_cdInCharge.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdInCharge.Name = "txt_cdInCharge"
        Me.txt_cdInCharge.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdInCharge.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdInCharge.TabIndex = 8
        Me.txt_cdInCharge.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdInCharge.TextBoxAutoComplete = False
        Me.txt_cdInCharge.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdInCharge.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdInCharge.TextEnabled = True
        Me.txt_cdInCharge.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdInCharge.TextMaxLength = 32767
        Me.txt_cdInCharge.TextMultiLine = False
        Me.txt_cdInCharge.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdInCharge.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdInCharge.UseSendTab = True
        '
        'txt_cdMainProcess
        '
        Me.txt_cdMainProcess.BackYesno = False
        Me.txt_cdMainProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess.ButtonEnabled = True
        Me.txt_cdMainProcess.ButtonFont = Nothing
        Me.txt_cdMainProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.ButtonName = "Const_Position"
        Me.txt_cdMainProcess.ButtonTitle = "Main Process"
        Me.txt_cdMainProcess.Code = ""
        Me.txt_cdMainProcess.Data = ""
        Me.txt_cdMainProcess.DataDecimal = 0
        Me.txt_cdMainProcess.DataLen = 0
        Me.txt_cdMainProcess.DataValue = 0
        Me.txt_cdMainProcess.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdMainProcess.Location = New System.Drawing.Point(2, 166)
        Me.txt_cdMainProcess.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdMainProcess.Name = "txt_cdMainProcess"
        Me.txt_cdMainProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdMainProcess.TabIndex = 9
        Me.txt_cdMainProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMainProcess.TextBoxAutoComplete = False
        Me.txt_cdMainProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess.TextEnabled = True
        Me.txt_cdMainProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextMaxLength = 32767
        Me.txt_cdMainProcess.TextMultiLine = False
        Me.txt_cdMainProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdMainProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdMainProcess.UseSendTab = True
        '
        'txt_cdSubProcess
        '
        Me.txt_cdSubProcess.BackYesno = False
        Me.txt_cdSubProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSubProcess.ButtonEnabled = True
        Me.txt_cdSubProcess.ButtonFont = Nothing
        Me.txt_cdSubProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.ButtonName = "Const_InCharge"
        Me.txt_cdSubProcess.ButtonTitle = "Sub-Process"
        Me.txt_cdSubProcess.Code = ""
        Me.txt_cdSubProcess.Data = ""
        Me.txt_cdSubProcess.DataDecimal = 0
        Me.txt_cdSubProcess.DataLen = 0
        Me.txt_cdSubProcess.DataValue = 0
        Me.txt_cdSubProcess.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdSubProcess.Location = New System.Drawing.Point(312, 166)
        Me.txt_cdSubProcess.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdSubProcess.Name = "txt_cdSubProcess"
        Me.txt_cdSubProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSubProcess.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdSubProcess.TabIndex = 10
        Me.txt_cdSubProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSubProcess.TextBoxAutoComplete = False
        Me.txt_cdSubProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSubProcess.TextEnabled = True
        Me.txt_cdSubProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.TextMaxLength = 32767
        Me.txt_cdSubProcess.TextMultiLine = False
        Me.txt_cdSubProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSubProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSubProcess.UseSendTab = True
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = Nothing
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = "Const_Position"
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 0
        Me.txt_cdFactory.DataLen = 0
        Me.txt_cdFactory.DataValue = 0
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdFactory.Location = New System.Drawing.Point(2, 195)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdFactory.TabIndex = 15
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = False
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdFactory.TextEnabled = True
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_cdLineProd
        '
        Me.txt_cdLineProd.BackYesno = False
        Me.txt_cdLineProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd.ButtonEnabled = True
        Me.txt_cdLineProd.ButtonFont = Nothing
        Me.txt_cdLineProd.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.ButtonName = "Const_InCharge"
        Me.txt_cdLineProd.ButtonTitle = "Line Prod"
        Me.txt_cdLineProd.Code = ""
        Me.txt_cdLineProd.Data = ""
        Me.txt_cdLineProd.DataDecimal = 0
        Me.txt_cdLineProd.DataLen = 0
        Me.txt_cdLineProd.DataValue = 0
        Me.txt_cdLineProd.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_cdLineProd.Location = New System.Drawing.Point(312, 195)
        Me.txt_cdLineProd.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_cdLineProd.Name = "txt_cdLineProd"
        Me.txt_cdLineProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd.Size = New System.Drawing.Size(306, 25)
        Me.txt_cdLineProd.TabIndex = 16
        Me.txt_cdLineProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd.TextBoxAutoComplete = False
        Me.txt_cdLineProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLineProd.TextEnabled = True
        Me.txt_cdLineProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextMaxLength = 32767
        Me.txt_cdLineProd.TextMultiLine = False
        Me.txt_cdLineProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd.UseSendTab = True
        '
        'txt_IDCard
        '
        Me.txt_IDCard.BackYesno = False
        Me.txt_IDCard.ButtonTitle = Nothing
        Me.txt_IDCard.Code = Nothing
        Me.txt_IDCard.Data = ""
        Me.txt_IDCard.DataDecimal = 0
        Me.txt_IDCard.DataLen = 0
        Me.txt_IDCard.DataValue = 0
        Me.txt_IDCard.FormatDecimal = 0
        Me.txt_IDCard.FormatValue = False
        Me.txt_IDCard.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_IDCard.LableEnabled = True
        Me.txt_IDCard.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_IDCard.LableForeColor = System.Drawing.Color.Empty
        Me.txt_IDCard.LableTitle = "ID Card"
        Me.txt_IDCard.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_IDCard.Location = New System.Drawing.Point(2, 224)
        Me.txt_IDCard.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_IDCard.Name = "txt_IDCard"
        Me.txt_IDCard.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_IDCard.Size = New System.Drawing.Size(306, 21)
        Me.txt_IDCard.TabIndex = 13
        Me.txt_IDCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_IDCard.TextBoxAutoComplete = False
        Me.txt_IDCard.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_IDCard.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_IDCard.TextEnabled = True
        Me.txt_IDCard.TextForeColor = System.Drawing.Color.Empty
        Me.txt_IDCard.TextMaxLength = 32767
        Me.txt_IDCard.TextMultiLine = False
        Me.txt_IDCard.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_IDCard.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_IDCard.UseSendTab = True
        '
        'txt_IDHRCode
        '
        Me.txt_IDHRCode.BackYesno = False
        Me.txt_IDHRCode.ButtonTitle = Nothing
        Me.txt_IDHRCode.Code = Nothing
        Me.txt_IDHRCode.Data = ""
        Me.txt_IDHRCode.DataDecimal = 0
        Me.txt_IDHRCode.DataLen = 0
        Me.txt_IDHRCode.DataValue = 0
        Me.txt_IDHRCode.FormatDecimal = 0
        Me.txt_IDHRCode.FormatValue = False
        Me.txt_IDHRCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_IDHRCode.LableEnabled = True
        Me.txt_IDHRCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_IDHRCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_IDHRCode.LableTitle = "IDHRCode"
        Me.txt_IDHRCode.Layoutpercent = New Decimal(New Integer() {46, 0, 0, 131072})
        Me.txt_IDHRCode.Location = New System.Drawing.Point(312, 224)
        Me.txt_IDHRCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_IDHRCode.Name = "txt_IDHRCode"
        Me.txt_IDHRCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_IDHRCode.Size = New System.Drawing.Size(306, 21)
        Me.txt_IDHRCode.TabIndex = 14
        Me.txt_IDHRCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_IDHRCode.TextBoxAutoComplete = False
        Me.txt_IDHRCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_IDHRCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_IDHRCode.TextEnabled = True
        Me.txt_IDHRCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_IDHRCode.TextMaxLength = 32767
        Me.txt_IDHRCode.TextMultiLine = False
        Me.txt_IDHRCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_IDHRCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_IDHRCode.UseSendTab = True
        '
        'lbla_use
        '
        Me.lbla_use.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbla_use.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbla_use.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbla_use.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbla_use.ButtonTitle = Nothing
        Me.lbla_use.Code = ""
        Me.lbla_use.Data = ""
        Me.lbla_use.DTDec = 0
        Me.lbla_use.DTLen = 0
        Me.lbla_use.DTValue = 0
        Me.lbla_use.Location = New System.Drawing.Point(2, 249)
        Me.lbla_use.Margin = New System.Windows.Forms.Padding(2)
        Me.lbla_use.Name = "lbla_use"
        Me.lbla_use.NoClear = False
        Me.lbla_use.Size = New System.Drawing.Size(135, 24)
        Me.lbla_use.TabIndex = 11
        Me.lbla_use.Tag = ""
        Me.lbla_use.Text = "Use"
        Me.lbla_use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.rad_CheckUse1)
        Me.PeacePanel1.Controls.Add(Me.rad_CheckUse2)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(140, 248)
        Me.PeacePanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(476, 25)
        Me.PeacePanel1.TabIndex = 12
        Me.PeacePanel1.Tag = ""
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(14, 1)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(60, 22)
        Me.rad_CheckUse1.TabIndex = 1
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(100, 5)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(77, 16)
        Me.rad_CheckUse2.TabIndex = 0
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'ISUD7411A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(634, 327)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "ISUD7411A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HR BASIC PROCESSING (ISUD7411A)"
        Me.Controls.SetChildIndex(Me.Frame1, 0)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Block1.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_cdNationality As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdPosition As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDepartment As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSite As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdInCharge As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdOnePosition As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Name As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ForeignName As PSMGlobal.SelectLabelText
    Friend WithEvents Block1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents txt_IDNO As PSMGlobal.SelectLabelText
    Friend WithEvents lbla_use As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents rad_CheckUse2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad_CheckUse1 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_DevelopmenetCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdMainProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSubProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_IDCard As PSMGlobal.SelectLabelText
    Friend WithEvents txt_IDHRCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineProd As PSMGlobal.SelectPeaceHLPButton
End Class
