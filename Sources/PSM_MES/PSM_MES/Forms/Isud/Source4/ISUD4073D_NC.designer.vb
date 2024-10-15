<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4073D_NC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD4073D_NC))
        Dim EnhancedScrollBarRenderer1 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim NamedStyle1 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style2")
        Dim BevelBorder1 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle2 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style3")
        Dim BevelBorder2 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle3 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim BevelBorder3 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle4 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style4")
        Dim BevelBorder4 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle5 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style5")
        Dim GeneralCellType1 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim SpreadSkin1 As FarPoint.Win.Spread.SpreadSkin = New FarPoint.Win.Spread.SpreadSkin()
        Dim EnhancedFocusIndicatorRenderer1 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
        Dim EnhancedInterfaceRenderer1 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer2 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer3 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim vS1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim vS1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.Block1 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_SLNoD = New PSMGlobal.SelectLabelText()
        Me.txt_SizeRange = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_LastCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MoldCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MCODEName = New PSMGlobal.SelectLabelText()
        Me.txt_PONO = New PSMGlobal.SelectLabelText()
        Me.txt_JobCard = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_Qtybase = New PSMGlobal.SelectLabelText()
        Me.txt_MachineName = New PSMGlobal.SelectLabelText()
        Me.txt_DatePlan = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_ProcessSeq = New PSMGlobal.SelectLabelText()
        Me.txt_LineTno = New PSMGlobal.SelectLabelText()
        Me.txt_cdLineProd = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_InchargePlan = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdMainProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdReasonBatch = New PSMGlobal.SelectPeaceHLPButton()
        Me.chk_CheckComplete3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete6 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_cdFactory = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Barcode = New PSMGlobal.SelectLabelText()
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        vS1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Block1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(1236, 356)
        Me.frm_Condition.TabIndex = 3
        Me.frm_Condition.Tag = ""
        '
        'Block1
        '
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.TableLayoutPanel1)
        Me.Block1.Data = ""
        Me.Block1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Block1.Location = New System.Drawing.Point(2, 2)
        Me.Block1.Margin = New System.Windows.Forms.Padding(0)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(1232, 352)
        Me.Block1.TabIndex = 2
        Me.Block1.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeacePanel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.vS1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1228, 348)
        Me.TableLayoutPanel1.TabIndex = 159
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.Frame4, 2)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 306)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1222, 39)
        Me.Frame4.TabIndex = 0
        Me.Frame4.Tag = ""
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(1080, 2)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(138, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(939, 2)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(138, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel1, 3)
        Me.Panel1.Size = New System.Drawing.Size(324, 297)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_SLNoD)
        Me.GroupBox3.Controls.Add(Me.txt_SizeRange)
        Me.GroupBox3.Controls.Add(Me.txt_LastCode)
        Me.GroupBox3.Controls.Add(Me.txt_MoldCode)
        Me.GroupBox3.Controls.Add(Me.txt_MCODEName)
        Me.GroupBox3.Controls.Add(Me.txt_PONO)
        Me.GroupBox3.Controls.Add(Me.txt_JobCard)
        Me.GroupBox3.Controls.Add(Me.txt_Article)
        Me.GroupBox3.Controls.Add(Me.txt_Line)
        Me.GroupBox3.Controls.Add(Me.txt_ColorName)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(315, 256)
        Me.GroupBox3.TabIndex = 120
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "BT SECTION"
        '
        'txt_SLNoD
        '
        Me.txt_SLNoD.BackYesno = False
        Me.txt_SLNoD.ButtonTitle = Nothing
        Me.txt_SLNoD.Code = Nothing
        Me.txt_SLNoD.Data = ""
        Me.txt_SLNoD.DataDecimal = 1
        Me.txt_SLNoD.DataLen = 0
        Me.txt_SLNoD.DataValue = 0
        Me.txt_SLNoD.FormatDecimal = 0
        Me.txt_SLNoD.FormatValue = False
        Me.txt_SLNoD.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SLNoD.LableEnabled = True
        Me.txt_SLNoD.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SLNoD.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SLNoD.LableTitle = "Seal No"
        Me.txt_SLNoD.Layoutpercent = New Decimal(New Integer() {52, 0, 0, 131072})
        Me.txt_SLNoD.Location = New System.Drawing.Point(0, 44)
        Me.txt_SLNoD.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SLNoD.Name = "txt_SLNoD"
        Me.txt_SLNoD.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SLNoD.Size = New System.Drawing.Size(240, 25)
        Me.txt_SLNoD.TabIndex = 140
        Me.txt_SLNoD.TabStop = False
        Me.txt_SLNoD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_SLNoD.TextBoxAutoComplete = False
        Me.txt_SLNoD.TextboxBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_SLNoD.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SLNoD.TextEnabled = False
        Me.txt_SLNoD.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SLNoD.TextMaxLength = 32767
        Me.txt_SLNoD.TextMultiLine = False
        Me.txt_SLNoD.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SLNoD.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SLNoD.UseSendTab = True
        '
        'txt_SizeRange
        '
        Me.txt_SizeRange.BackYesno = False
        Me.txt_SizeRange.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SizeRange.ButtonEnabled = True
        Me.txt_SizeRange.ButtonFont = Nothing
        Me.txt_SizeRange.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.ButtonName = ""
        Me.txt_SizeRange.ButtonTitle = "Size Range"
        Me.txt_SizeRange.Code = ""
        Me.txt_SizeRange.Data = ""
        Me.txt_SizeRange.DataDecimal = 0
        Me.txt_SizeRange.DataLen = 0
        Me.txt_SizeRange.DataValue = 0
        Me.txt_SizeRange.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_SizeRange.Location = New System.Drawing.Point(2, 228)
        Me.txt_SizeRange.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeRange.Name = "txt_SizeRange"
        Me.txt_SizeRange.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeRange.Size = New System.Drawing.Size(307, 24)
        Me.txt_SizeRange.TabIndex = 139
        Me.txt_SizeRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeRange.TextBoxAutoComplete = False
        Me.txt_SizeRange.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_SizeRange.TextEnabled = True
        Me.txt_SizeRange.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRange.TextMaxLength = 32767
        Me.txt_SizeRange.TextMultiLine = False
        Me.txt_SizeRange.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeRange.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeRange.UseSendTab = True
        '
        'txt_LastCode
        '
        Me.txt_LastCode.BackYesno = False
        Me.txt_LastCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_LastCode.ButtonEnabled = True
        Me.txt_LastCode.ButtonFont = Nothing
        Me.txt_LastCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_LastCode.ButtonName = ""
        Me.txt_LastCode.ButtonTitle = "Last Code"
        Me.txt_LastCode.Code = ""
        Me.txt_LastCode.Data = ""
        Me.txt_LastCode.DataDecimal = 0
        Me.txt_LastCode.DataLen = 0
        Me.txt_LastCode.DataValue = 0
        Me.txt_LastCode.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_LastCode.Location = New System.Drawing.Point(2, 174)
        Me.txt_LastCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LastCode.Name = "txt_LastCode"
        Me.txt_LastCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LastCode.Size = New System.Drawing.Size(307, 24)
        Me.txt_LastCode.TabIndex = 137
        Me.txt_LastCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LastCode.TextBoxAutoComplete = False
        Me.txt_LastCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LastCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_LastCode.TextEnabled = True
        Me.txt_LastCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LastCode.TextMaxLength = 32767
        Me.txt_LastCode.TextMultiLine = False
        Me.txt_LastCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LastCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LastCode.UseSendTab = True
        '
        'txt_MoldCode
        '
        Me.txt_MoldCode.BackYesno = False
        Me.txt_MoldCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_MoldCode.ButtonEnabled = True
        Me.txt_MoldCode.ButtonFont = Nothing
        Me.txt_MoldCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_MoldCode.ButtonName = ""
        Me.txt_MoldCode.ButtonTitle = "Molde Code"
        Me.txt_MoldCode.Code = ""
        Me.txt_MoldCode.Data = ""
        Me.txt_MoldCode.DataDecimal = 0
        Me.txt_MoldCode.DataLen = 0
        Me.txt_MoldCode.DataValue = 0
        Me.txt_MoldCode.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_MoldCode.Location = New System.Drawing.Point(2, 201)
        Me.txt_MoldCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MoldCode.Name = "txt_MoldCode"
        Me.txt_MoldCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MoldCode.Size = New System.Drawing.Size(307, 24)
        Me.txt_MoldCode.TabIndex = 138
        Me.txt_MoldCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MoldCode.TextBoxAutoComplete = False
        Me.txt_MoldCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MoldCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_MoldCode.TextEnabled = True
        Me.txt_MoldCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MoldCode.TextMaxLength = 32767
        Me.txt_MoldCode.TextMultiLine = False
        Me.txt_MoldCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MoldCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MoldCode.UseSendTab = True
        '
        'txt_MCODEName
        '
        Me.txt_MCODEName.BackYesno = False
        Me.txt_MCODEName.ButtonTitle = Nothing
        Me.txt_MCODEName.Code = Nothing
        Me.txt_MCODEName.Data = ""
        Me.txt_MCODEName.DataDecimal = 0
        Me.txt_MCODEName.DataLen = 0
        Me.txt_MCODEName.DataValue = 0
        Me.txt_MCODEName.FormatDecimal = 0
        Me.txt_MCODEName.FormatValue = False
        Me.txt_MCODEName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MCODEName.LableEnabled = True
        Me.txt_MCODEName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MCODEName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MCODEName.LableTitle = "Material Name"
        Me.txt_MCODEName.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_MCODEName.Location = New System.Drawing.Point(2, 148)
        Me.txt_MCODEName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MCODEName.Name = "txt_MCODEName"
        Me.txt_MCODEName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MCODEName.Size = New System.Drawing.Size(307, 24)
        Me.txt_MCODEName.TabIndex = 136
        Me.txt_MCODEName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MCODEName.TextBoxAutoComplete = False
        Me.txt_MCODEName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MCODEName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MCODEName.TextEnabled = True
        Me.txt_MCODEName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MCODEName.TextMaxLength = 32767
        Me.txt_MCODEName.TextMultiLine = False
        Me.txt_MCODEName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MCODEName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MCODEName.UseSendTab = True
        '
        'txt_PONO
        '
        Me.txt_PONO.BackYesno = False
        Me.txt_PONO.ButtonTitle = Nothing
        Me.txt_PONO.Code = Nothing
        Me.txt_PONO.Data = ""
        Me.txt_PONO.DataDecimal = 1
        Me.txt_PONO.DataLen = 0
        Me.txt_PONO.DataValue = 0
        Me.txt_PONO.FormatDecimal = 0
        Me.txt_PONO.FormatValue = False
        Me.txt_PONO.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_PONO.LableEnabled = True
        Me.txt_PONO.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_PONO.LableForeColor = System.Drawing.Color.Empty
        Me.txt_PONO.LableTitle = "PONO"
        Me.txt_PONO.Layoutpercent = New Decimal(New Integer() {52, 0, 0, 131072})
        Me.txt_PONO.Location = New System.Drawing.Point(1, 45)
        Me.txt_PONO.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_PONO.Name = "txt_PONO"
        Me.txt_PONO.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_PONO.Size = New System.Drawing.Size(239, 23)
        Me.txt_PONO.TabIndex = 134
        Me.txt_PONO.TabStop = False
        Me.txt_PONO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_PONO.TextBoxAutoComplete = False
        Me.txt_PONO.TextboxBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_PONO.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_PONO.TextEnabled = False
        Me.txt_PONO.TextForeColor = System.Drawing.Color.Empty
        Me.txt_PONO.TextMaxLength = 32767
        Me.txt_PONO.TextMultiLine = False
        Me.txt_PONO.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_PONO.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_PONO.UseSendTab = True
        '
        'txt_JobCard
        '
        Me.txt_JobCard.BackYesno = False
        Me.txt_JobCard.ButtonTitle = Nothing
        Me.txt_JobCard.Code = Nothing
        Me.txt_JobCard.Data = ""
        Me.txt_JobCard.DataDecimal = 1
        Me.txt_JobCard.DataLen = 0
        Me.txt_JobCard.DataValue = 0
        Me.txt_JobCard.FormatDecimal = 0
        Me.txt_JobCard.FormatValue = False
        Me.txt_JobCard.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_JobCard.LableEnabled = True
        Me.txt_JobCard.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_JobCard.LableForeColor = System.Drawing.Color.Empty
        Me.txt_JobCard.LableTitle = "Job Card"
        Me.txt_JobCard.Layoutpercent = New Decimal(New Integer() {52, 0, 0, 131072})
        Me.txt_JobCard.Location = New System.Drawing.Point(1, 20)
        Me.txt_JobCard.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_JobCard.Name = "txt_JobCard"
        Me.txt_JobCard.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_JobCard.Size = New System.Drawing.Size(239, 23)
        Me.txt_JobCard.TabIndex = 132
        Me.txt_JobCard.TabStop = False
        Me.txt_JobCard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_JobCard.TextBoxAutoComplete = False
        Me.txt_JobCard.TextboxBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_JobCard.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_JobCard.TextEnabled = False
        Me.txt_JobCard.TextForeColor = System.Drawing.Color.Empty
        Me.txt_JobCard.TextMaxLength = 32767
        Me.txt_JobCard.TextMultiLine = False
        Me.txt_JobCard.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_JobCard.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_JobCard.UseSendTab = True
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = Nothing
        Me.txt_Article.Code = Nothing
        Me.txt_Article.Data = ""
        Me.txt_Article.DataDecimal = 1
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 0
        Me.txt_Article.FormatDecimal = 0
        Me.txt_Article.FormatValue = False
        Me.txt_Article.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Article.LableEnabled = True
        Me.txt_Article.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Article.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Article.LableTitle = "Article"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_Article.Location = New System.Drawing.Point(1, 96)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(309, 23)
        Me.txt_Article.TabIndex = 127
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
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
        Me.txt_Line.DataDecimal = 1
        Me.txt_Line.DataLen = 0
        Me.txt_Line.DataValue = 0
        Me.txt_Line.FormatDecimal = 0
        Me.txt_Line.FormatValue = False
        Me.txt_Line.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Line.LableEnabled = True
        Me.txt_Line.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Line.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Line.LableTitle = "Line"
        Me.txt_Line.Layoutpercent = New Decimal(New Integer() {52, 0, 0, 131072})
        Me.txt_Line.Location = New System.Drawing.Point(1, 71)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(239, 23)
        Me.txt_Line.TabIndex = 103
        Me.txt_Line.TabStop = False
        Me.txt_Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Line.TextBoxAutoComplete = False
        Me.txt_Line.TextboxBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Line.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Line.TextEnabled = False
        Me.txt_Line.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Line.TextMaxLength = 32767
        Me.txt_Line.TextMultiLine = False
        Me.txt_Line.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Line.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Line.UseSendTab = True
        '
        'txt_ColorName
        '
        Me.txt_ColorName.BackYesno = True
        Me.txt_ColorName.ButtonTitle = Nothing
        Me.txt_ColorName.Code = Nothing
        Me.txt_ColorName.Data = ""
        Me.txt_ColorName.DataDecimal = 0
        Me.txt_ColorName.DataLen = 0
        Me.txt_ColorName.DataValue = 0
        Me.txt_ColorName.FormatDecimal = 0
        Me.txt_ColorName.FormatValue = False
        Me.txt_ColorName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ColorName.LableEnabled = True
        Me.txt_ColorName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ColorName.LableTitle = "Color Name"
        Me.txt_ColorName.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_ColorName.Location = New System.Drawing.Point(2, 122)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(307, 24)
        Me.txt_ColorName.TabIndex = 122
        Me.txt_ColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorName.TextBoxAutoComplete = False
        Me.txt_ColorName.TextboxBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ColorName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorName.TextEnabled = True
        Me.txt_ColorName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextMaxLength = 32767
        Me.txt_ColorName.TextMultiLine = False
        Me.txt_ColorName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorName.UseSendTab = True
        '
        'PeacePanel2
        '
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Controls.Add(Me.txt_Qtybase)
        Me.PeacePanel2.Controls.Add(Me.txt_MachineName)
        Me.PeacePanel2.Controls.Add(Me.txt_DatePlan)
        Me.PeacePanel2.Controls.Add(Me.txt_ProcessSeq)
        Me.PeacePanel2.Controls.Add(Me.txt_LineTno)
        Me.PeacePanel2.Controls.Add(Me.txt_cdLineProd)
        Me.PeacePanel2.Controls.Add(Me.txt_InchargePlan)
        Me.PeacePanel2.Controls.Add(Me.txt_cdMainProcess)
        Me.PeacePanel2.Controls.Add(Me.PeacePanel3)
        Me.PeacePanel2.Controls.Add(Me.txt_cdFactory)
        Me.PeacePanel2.Controls.Add(Me.txt_Barcode)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel2.Location = New System.Drawing.Point(333, 3)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(892, 144)
        Me.PeacePanel2.TabIndex = 141
        Me.PeacePanel2.Tag = ""
        '
        'txt_Qtybase
        '
        Me.txt_Qtybase.BackYesno = False
        Me.txt_Qtybase.ButtonTitle = Nothing
        Me.txt_Qtybase.Code = Nothing
        Me.txt_Qtybase.Data = "10"
        Me.txt_Qtybase.DataDecimal = 1
        Me.txt_Qtybase.DataLen = 0
        Me.txt_Qtybase.DataValue = 0
        Me.txt_Qtybase.FormatDecimal = 0
        Me.txt_Qtybase.FormatValue = False
        Me.txt_Qtybase.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Qtybase.LableEnabled = True
        Me.txt_Qtybase.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Qtybase.LableForeColor = System.Drawing.Color.Black
        Me.txt_Qtybase.LableTitle = "Barcode #"
        Me.txt_Qtybase.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_Qtybase.Location = New System.Drawing.Point(487, 87)
        Me.txt_Qtybase.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Qtybase.Name = "txt_Qtybase"
        Me.txt_Qtybase.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Qtybase.Size = New System.Drawing.Size(81, 51)
        Me.txt_Qtybase.TabIndex = 157
        Me.txt_Qtybase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_Qtybase.TextBoxAutoComplete = False
        Me.txt_Qtybase.TextboxBackColor = System.Drawing.Color.White
        Me.txt_Qtybase.TextBoxFont = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txt_Qtybase.TextEnabled = True
        Me.txt_Qtybase.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Qtybase.TextMaxLength = 32767
        Me.txt_Qtybase.TextMultiLine = False
        Me.txt_Qtybase.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Qtybase.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Qtybase.UseSendTab = True
        '
        'txt_MachineName
        '
        Me.txt_MachineName.BackYesno = False
        Me.txt_MachineName.ButtonTitle = Nothing
        Me.txt_MachineName.Code = Nothing
        Me.txt_MachineName.Data = ""
        Me.txt_MachineName.DataDecimal = 1
        Me.txt_MachineName.DataLen = 0
        Me.txt_MachineName.DataValue = 0
        Me.txt_MachineName.FormatDecimal = 0
        Me.txt_MachineName.FormatValue = False
        Me.txt_MachineName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MachineName.LableEnabled = True
        Me.txt_MachineName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MachineName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.LableTitle = "Date Prepared"
        Me.txt_MachineName.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_MachineName.Location = New System.Drawing.Point(289, 57)
        Me.txt_MachineName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MachineName.Name = "txt_MachineName"
        Me.txt_MachineName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MachineName.Size = New System.Drawing.Size(196, 24)
        Me.txt_MachineName.TabIndex = 155
        Me.txt_MachineName.TabStop = False
        Me.txt_MachineName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_MachineName.TextBoxAutoComplete = True
        Me.txt_MachineName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_MachineName.TextEnabled = False
        Me.txt_MachineName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MachineName.TextMaxLength = 32767
        Me.txt_MachineName.TextMultiLine = False
        Me.txt_MachineName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MachineName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MachineName.UseSendTab = True
        '
        'txt_DatePlan
        '
        Me.txt_DatePlan.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DatePlan.ButtonEnabled = True
        Me.txt_DatePlan.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DatePlan.ButtonName = Nothing
        Me.txt_DatePlan.ButtonTitle = "Plan Date"
        Me.txt_DatePlan.Code = ""
        Me.txt_DatePlan.Data = "20150101"
        Me.txt_DatePlan.DataDecimal = 1
        Me.txt_DatePlan.DataLen = 0
        Me.txt_DatePlan.DataValue = 0
        Me.txt_DatePlan.FormatDecimal = 0
        Me.txt_DatePlan.FormatValue = False
        Me.txt_DatePlan.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_DatePlan.Location = New System.Drawing.Point(289, 5)
        Me.txt_DatePlan.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DatePlan.Name = "txt_DatePlan"
        Me.txt_DatePlan.Size = New System.Drawing.Size(280, 24)
        Me.txt_DatePlan.TabIndex = 156
        Me.txt_DatePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DatePlan.TextBoxAutoComplete = False
        Me.txt_DatePlan.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DatePlan.TextEnabled = True
        Me.txt_DatePlan.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DatePlan.TextMaxLength = 32767
        Me.txt_DatePlan.TextMultiLine = True
        Me.txt_DatePlan.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_ProcessSeq
        '
        Me.txt_ProcessSeq.BackYesno = True
        Me.txt_ProcessSeq.ButtonTitle = Nothing
        Me.txt_ProcessSeq.Code = Nothing
        Me.txt_ProcessSeq.Data = ""
        Me.txt_ProcessSeq.DataDecimal = 0
        Me.txt_ProcessSeq.DataLen = 0
        Me.txt_ProcessSeq.DataValue = 0
        Me.txt_ProcessSeq.FormatDecimal = 0
        Me.txt_ProcessSeq.FormatValue = False
        Me.txt_ProcessSeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProcessSeq.LableEnabled = True
        Me.txt_ProcessSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProcessSeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProcessSeq.LableTitle = "B/T NO"
        Me.txt_ProcessSeq.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ProcessSeq.Location = New System.Drawing.Point(423, 87)
        Me.txt_ProcessSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProcessSeq.Name = "txt_ProcessSeq"
        Me.txt_ProcessSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProcessSeq.Size = New System.Drawing.Size(62, 51)
        Me.txt_ProcessSeq.TabIndex = 131
        Me.txt_ProcessSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_ProcessSeq.TextBoxAutoComplete = False
        Me.txt_ProcessSeq.TextboxBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProcessSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txt_ProcessSeq.TextEnabled = True
        Me.txt_ProcessSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProcessSeq.TextMaxLength = 32767
        Me.txt_ProcessSeq.TextMultiLine = False
        Me.txt_ProcessSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProcessSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProcessSeq.UseSendTab = True
        '
        'txt_LineTno
        '
        Me.txt_LineTno.BackYesno = False
        Me.txt_LineTno.ButtonTitle = Nothing
        Me.txt_LineTno.Code = Nothing
        Me.txt_LineTno.Data = ""
        Me.txt_LineTno.DataDecimal = 1
        Me.txt_LineTno.DataLen = 0
        Me.txt_LineTno.DataValue = 0
        Me.txt_LineTno.FormatDecimal = 0
        Me.txt_LineTno.FormatValue = False
        Me.txt_LineTno.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_LineTno.LableEnabled = True
        Me.txt_LineTno.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LineTno.LableForeColor = System.Drawing.Color.Empty
        Me.txt_LineTno.LableTitle = "Date Prepared"
        Me.txt_LineTno.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_LineTno.Location = New System.Drawing.Point(487, 56)
        Me.txt_LineTno.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LineTno.Name = "txt_LineTno"
        Me.txt_LineTno.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LineTno.Size = New System.Drawing.Size(81, 26)
        Me.txt_LineTno.TabIndex = 155
        Me.txt_LineTno.TabStop = False
        Me.txt_LineTno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_LineTno.TextBoxAutoComplete = True
        Me.txt_LineTno.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LineTno.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_LineTno.TextEnabled = False
        Me.txt_LineTno.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LineTno.TextMaxLength = 32767
        Me.txt_LineTno.TextMultiLine = False
        Me.txt_LineTno.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LineTno.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LineTno.UseSendTab = True
        '
        'txt_cdLineProd
        '
        Me.txt_cdLineProd.BackYesno = False
        Me.txt_cdLineProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd.ButtonEnabled = True
        Me.txt_cdLineProd.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLineProd.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.ButtonName = ""
        Me.txt_cdLineProd.ButtonTitle = "Line Prod"
        Me.txt_cdLineProd.Code = ""
        Me.txt_cdLineProd.Data = ""
        Me.txt_cdLineProd.DataDecimal = 1
        Me.txt_cdLineProd.DataLen = 0
        Me.txt_cdLineProd.DataValue = 1
        Me.txt_cdLineProd.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdLineProd.Location = New System.Drawing.Point(5, 58)
        Me.txt_cdLineProd.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdLineProd.Name = "txt_cdLineProd"
        Me.txt_cdLineProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd.Size = New System.Drawing.Size(280, 24)
        Me.txt_cdLineProd.TabIndex = 153
        Me.txt_cdLineProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd.TextBoxAutoComplete = True
        Me.txt_cdLineProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdLineProd.TextEnabled = False
        Me.txt_cdLineProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextMaxLength = 32767
        Me.txt_cdLineProd.TextMultiLine = False
        Me.txt_cdLineProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd.UseSendTab = True
        '
        'txt_InchargePlan
        '
        Me.txt_InchargePlan.BackYesno = False
        Me.txt_InchargePlan.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargePlan.ButtonEnabled = True
        Me.txt_InchargePlan.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargePlan.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargePlan.ButtonName = "Const_Emp117"
        Me.txt_InchargePlan.ButtonTitle = "Incharge"
        Me.txt_InchargePlan.Code = ""
        Me.txt_InchargePlan.Data = ""
        Me.txt_InchargePlan.DataDecimal = 1
        Me.txt_InchargePlan.DataLen = 0
        Me.txt_InchargePlan.DataValue = 1
        Me.txt_InchargePlan.Layoutpercent = New Decimal(New Integer() {42, 0, 0, 131072})
        Me.txt_InchargePlan.Location = New System.Drawing.Point(289, 31)
        Me.txt_InchargePlan.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_InchargePlan.Name = "txt_InchargePlan"
        Me.txt_InchargePlan.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargePlan.Size = New System.Drawing.Size(280, 24)
        Me.txt_InchargePlan.TabIndex = 152
        Me.txt_InchargePlan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargePlan.TextBoxAutoComplete = True
        Me.txt_InchargePlan.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargePlan.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_InchargePlan.TextEnabled = True
        Me.txt_InchargePlan.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargePlan.TextMaxLength = 32767
        Me.txt_InchargePlan.TextMultiLine = False
        Me.txt_InchargePlan.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargePlan.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargePlan.UseSendTab = True
        '
        'txt_cdMainProcess
        '
        Me.txt_cdMainProcess.BackYesno = False
        Me.txt_cdMainProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdMainProcess.ButtonEnabled = True
        Me.txt_cdMainProcess.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdMainProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.ButtonName = ""
        Me.txt_cdMainProcess.ButtonTitle = "Process"
        Me.txt_cdMainProcess.Code = ""
        Me.txt_cdMainProcess.Data = ""
        Me.txt_cdMainProcess.DataDecimal = 1
        Me.txt_cdMainProcess.DataLen = 0
        Me.txt_cdMainProcess.DataValue = 1
        Me.txt_cdMainProcess.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdMainProcess.Location = New System.Drawing.Point(5, 31)
        Me.txt_cdMainProcess.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdMainProcess.Name = "txt_cdMainProcess"
        Me.txt_cdMainProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdMainProcess.Size = New System.Drawing.Size(280, 24)
        Me.txt_cdMainProcess.TabIndex = 151
        Me.txt_cdMainProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdMainProcess.TextBoxAutoComplete = True
        Me.txt_cdMainProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdMainProcess.TextEnabled = False
        Me.txt_cdMainProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdMainProcess.TextMaxLength = 32767
        Me.txt_cdMainProcess.TextMultiLine = False
        Me.txt_cdMainProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdMainProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdMainProcess.UseSendTab = True
        '
        'PeacePanel3
        '
        Me.PeacePanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.txt_cdReasonBatch)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete3)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete4)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete5)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete6)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete1)
        Me.PeacePanel3.Controls.Add(Me.chk_CheckComplete2)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(572, 0)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(480, 141)
        Me.PeacePanel3.TabIndex = 150
        Me.PeacePanel3.Tag = ""
        '
        'txt_cdReasonBatch
        '
        Me.txt_cdReasonBatch.BackYesno = False
        Me.txt_cdReasonBatch.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdReasonBatch.ButtonEnabled = True
        Me.txt_cdReasonBatch.ButtonFont = Nothing
        Me.txt_cdReasonBatch.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdReasonBatch.ButtonName = ""
        Me.txt_cdReasonBatch.ButtonTitle = "Reason Batch"
        Me.txt_cdReasonBatch.Code = ""
        Me.txt_cdReasonBatch.Data = ""
        Me.txt_cdReasonBatch.DataDecimal = 0
        Me.txt_cdReasonBatch.DataLen = 0
        Me.txt_cdReasonBatch.DataValue = 0
        Me.txt_cdReasonBatch.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdReasonBatch.Location = New System.Drawing.Point(3, 112)
        Me.txt_cdReasonBatch.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdReasonBatch.Name = "txt_cdReasonBatch"
        Me.txt_cdReasonBatch.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdReasonBatch.Size = New System.Drawing.Size(307, 24)
        Me.txt_cdReasonBatch.TabIndex = 141
        Me.txt_cdReasonBatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdReasonBatch.TextBoxAutoComplete = False
        Me.txt_cdReasonBatch.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdReasonBatch.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdReasonBatch.TextEnabled = True
        Me.txt_cdReasonBatch.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdReasonBatch.TextMaxLength = 32767
        Me.txt_cdReasonBatch.TextMultiLine = False
        Me.txt_cdReasonBatch.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdReasonBatch.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdReasonBatch.UseSendTab = True
        '
        'chk_CheckComplete3
        '
        Me.chk_CheckComplete3.AutoSize = True
        Me.chk_CheckComplete3.ButtonTitle = Nothing
        Me.chk_CheckComplete3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete3.Location = New System.Drawing.Point(17, 39)
        Me.chk_CheckComplete3.Name = "chk_CheckComplete3"
        Me.chk_CheckComplete3.Size = New System.Drawing.Size(56, 18)
        Me.chk_CheckComplete3.TabIndex = 6
        Me.chk_CheckComplete3.Text = "STOP"
        Me.chk_CheckComplete3.UseVisualStyleBackColor = True
        '
        'chk_CheckComplete4
        '
        Me.chk_CheckComplete4.AutoSize = True
        Me.chk_CheckComplete4.ButtonTitle = Nothing
        Me.chk_CheckComplete4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete4.Location = New System.Drawing.Point(118, 39)
        Me.chk_CheckComplete4.Name = "chk_CheckComplete4"
        Me.chk_CheckComplete4.Size = New System.Drawing.Size(82, 18)
        Me.chk_CheckComplete4.TabIndex = 7
        Me.chk_CheckComplete4.Text = "ACCIDENT"
        Me.chk_CheckComplete4.UseVisualStyleBackColor = True
        '
        'chk_CheckComplete5
        '
        Me.chk_CheckComplete5.AutoSize = True
        Me.chk_CheckComplete5.ButtonTitle = Nothing
        Me.chk_CheckComplete5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete5.Location = New System.Drawing.Point(17, 68)
        Me.chk_CheckComplete5.Name = "chk_CheckComplete5"
        Me.chk_CheckComplete5.Size = New System.Drawing.Size(72, 18)
        Me.chk_CheckComplete5.TabIndex = 4
        Me.chk_CheckComplete5.Text = "RECEIPT"
        Me.chk_CheckComplete5.UseVisualStyleBackColor = True
        '
        'chk_CheckComplete6
        '
        Me.chk_CheckComplete6.AutoSize = True
        Me.chk_CheckComplete6.ButtonTitle = Nothing
        Me.chk_CheckComplete6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete6.Location = New System.Drawing.Point(118, 68)
        Me.chk_CheckComplete6.Name = "chk_CheckComplete6"
        Me.chk_CheckComplete6.Size = New System.Drawing.Size(84, 18)
        Me.chk_CheckComplete6.TabIndex = 5
        Me.chk_CheckComplete6.Text = "PROGRESS"
        Me.chk_CheckComplete6.UseVisualStyleBackColor = True
        '
        'chk_CheckComplete1
        '
        Me.chk_CheckComplete1.AutoSize = True
        Me.chk_CheckComplete1.ButtonTitle = Nothing
        Me.chk_CheckComplete1.Checked = True
        Me.chk_CheckComplete1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete1.Location = New System.Drawing.Point(17, 10)
        Me.chk_CheckComplete1.Name = "chk_CheckComplete1"
        Me.chk_CheckComplete1.Size = New System.Drawing.Size(54, 18)
        Me.chk_CheckComplete1.TabIndex = 2
        Me.chk_CheckComplete1.TabStop = True
        Me.chk_CheckComplete1.Text = "PLAN"
        Me.chk_CheckComplete1.UseVisualStyleBackColor = True
        '
        'chk_CheckComplete2
        '
        Me.chk_CheckComplete2.AutoSize = True
        Me.chk_CheckComplete2.ButtonTitle = Nothing
        Me.chk_CheckComplete2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.chk_CheckComplete2.Location = New System.Drawing.Point(118, 10)
        Me.chk_CheckComplete2.Name = "chk_CheckComplete2"
        Me.chk_CheckComplete2.Size = New System.Drawing.Size(85, 18)
        Me.chk_CheckComplete2.TabIndex = 3
        Me.chk_CheckComplete2.Text = "COMPLETE"
        Me.chk_CheckComplete2.UseVisualStyleBackColor = True
        '
        'txt_cdFactory
        '
        Me.txt_cdFactory.BackYesno = False
        Me.txt_cdFactory.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdFactory.ButtonEnabled = True
        Me.txt_cdFactory.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdFactory.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.ButtonName = ""
        Me.txt_cdFactory.ButtonTitle = "Factory"
        Me.txt_cdFactory.Code = ""
        Me.txt_cdFactory.Data = ""
        Me.txt_cdFactory.DataDecimal = 1
        Me.txt_cdFactory.DataLen = 0
        Me.txt_cdFactory.DataValue = 1
        Me.txt_cdFactory.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdFactory.Location = New System.Drawing.Point(5, 5)
        Me.txt_cdFactory.Margin = New System.Windows.Forms.Padding(1, 1, 171, 1)
        Me.txt_cdFactory.Name = "txt_cdFactory"
        Me.txt_cdFactory.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdFactory.Size = New System.Drawing.Size(280, 24)
        Me.txt_cdFactory.TabIndex = 11
        Me.txt_cdFactory.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdFactory.TextBoxAutoComplete = True
        Me.txt_cdFactory.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdFactory.TextEnabled = False
        Me.txt_cdFactory.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdFactory.TextMaxLength = 32767
        Me.txt_cdFactory.TextMultiLine = False
        Me.txt_cdFactory.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdFactory.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdFactory.UseSendTab = True
        '
        'txt_Barcode
        '
        Me.txt_Barcode.BackYesno = False
        Me.txt_Barcode.ButtonTitle = Nothing
        Me.txt_Barcode.Code = Nothing
        Me.txt_Barcode.Data = ""
        Me.txt_Barcode.DataDecimal = 0
        Me.txt_Barcode.DataLen = 0
        Me.txt_Barcode.DataValue = 0
        Me.txt_Barcode.FormatDecimal = 0
        Me.txt_Barcode.FormatValue = False
        Me.txt_Barcode.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Barcode.LableEnabled = True
        Me.txt_Barcode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_Barcode.LableForeColor = System.Drawing.Color.Black
        Me.txt_Barcode.LableTitle = "Barcode #"
        Me.txt_Barcode.Layoutpercent = New Decimal(New Integer() {26, 0, 0, 131072})
        Me.txt_Barcode.Location = New System.Drawing.Point(5, 88)
        Me.txt_Barcode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Barcode.Size = New System.Drawing.Size(416, 50)
        Me.txt_Barcode.TabIndex = 10
        Me.txt_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Barcode.TextBoxAutoComplete = False
        Me.txt_Barcode.TextboxBackColor = System.Drawing.Color.White
        Me.txt_Barcode.TextBoxFont = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txt_Barcode.TextEnabled = True
        Me.txt_Barcode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Barcode.TextMaxLength = 32767
        Me.txt_Barcode.TextMultiLine = False
        Me.txt_Barcode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Barcode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Barcode.UseSendTab = True
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = ""
        Me.vS1.AllowDragFill = True
        Me.vS1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.vS1.CopyPasteChk = False
        Me.vS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vS1.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.vS1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.vS1.HorizontalScrollBar.TabIndex = 4
        Me.vS1.InsChk = False
        Me.vS1.Location = New System.Drawing.Point(333, 153)
        Me.vS1.Name = "vS1"
        NamedStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle1.Border = BevelBorder1
        NamedStyle1.CanFocus = False
        TextCellType1.WordWrap = True
        NamedStyle1.CellType = TextCellType1
        NamedStyle1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle1.ForeColor = System.Drawing.Color.White
        NamedStyle1.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle1.Locked = False
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = TextCellType1
        NamedStyle1.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle1.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle2.Border = BevelBorder2
        NamedStyle2.CellType = TextCellType2
        NamedStyle2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle2.Locked = False
        NamedStyle2.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle2.Renderer = TextCellType2
        NamedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle3.Border = BevelBorder3
        NamedStyle3.CanFocus = False
        NamedStyle3.CellType = TextCellType3
        NamedStyle3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle3.ForeColor = System.Drawing.Color.White
        NamedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle3.Locked = False
        NamedStyle3.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle3.Renderer = TextCellType3
        NamedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle3.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle4.Border = BevelBorder4
        NamedStyle4.CellType = TextCellType4
        NamedStyle4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle4.Locked = False
        NamedStyle4.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle4.Renderer = TextCellType4
        NamedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle5.BackColor = System.Drawing.SystemColors.Window
        NamedStyle5.CellType = GeneralCellType1
        NamedStyle5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        NamedStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle5.Locked = False
        NamedStyle5.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle5.Renderer = GeneralCellType1
        Me.vS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.vS1.ReportName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(892, 114)
        SpreadSkin1.ColumnFooterDefaultStyle = NamedStyle2
        SpreadSkin1.ColumnHeaderDefaultStyle = NamedStyle1
        SpreadSkin1.CornerDefaultStyle = NamedStyle4
        SpreadSkin1.DefaultStyle = NamedStyle5
        SpreadSkin1.FocusRenderer = EnhancedFocusIndicatorRenderer1
        EnhancedInterfaceRenderer1.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.TabStripBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        SpreadSkin1.InterfaceRenderer = EnhancedInterfaceRenderer1
        SpreadSkin1.Name = "KhanhHung1"
        SpreadSkin1.RowHeaderDefaultStyle = NamedStyle3
        EnhancedScrollBarRenderer2.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer2.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer2.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        SpreadSkin1.ScrollBarRenderer = EnhancedScrollBarRenderer2
        SpreadSkin1.SelectionRenderer = New FarPoint.Win.Spread.DefaultSelectionRenderer()
        Me.vS1.Skin = SpreadSkin1
        Me.vS1.SpreadWjob = 0
        Me.vS1.TabIndex = 117
        Me.vS1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.vS1.VerticalScrollBar.TabIndex = 5
        vS1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.V, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.X, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Delete, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectRow)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        vS1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.vS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, vS1_InputMapWhenFocusedNormal)
        vS1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfRows)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfColumns)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectColumn)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectSheet)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.DateTimeNow)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.vS1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, vS1_InputMapWhenAncestorOfFocusedNormal)
        '
        'vS1_Sheet1
        '
        Me.vS1_Sheet1.Reset()
        Me.vS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        TextCellType5.WordWrap = True
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.vS1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.DefaultStyle.Parent = "Style5"
        Me.vS1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.vS1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.vS1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.vS1_Sheet1.Rows.Default.Height = 22.0!
        Me.vS1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.vS1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.vS1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PrintDocument1
        '
        '
        'ISUD4073D_NC
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1236, 356)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "ISUD4073D_NC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STITCHING PLANNING PROCESSING (ISUD4073D)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel3.PerformLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Block1 As PSMGlobal.PeacePanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents chk_CheckComplete2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_cdFactory As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Barcode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_InchargePlan As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdMainProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents txt_LineTno As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ProcessSeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DatePlan As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_MachineName As PSMGlobal.SelectLabelText
    Friend WithEvents chk_CheckComplete3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete6 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_PONO As PSMGlobal.SelectLabelText
    Friend WithEvents txt_JobCard As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MCODEName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SizeRange As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_LastCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_MoldCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdLineProd As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents txt_SLNoD As PSMGlobal.SelectLabelText
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_cdReasonBatch As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_Qtybase As PSMGlobal.SelectLabelText
End Class
