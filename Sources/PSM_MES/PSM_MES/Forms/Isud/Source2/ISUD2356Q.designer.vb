<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD2356Q
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD2356Q))
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Bk_1 = New System.ComponentModel.BackgroundWorker()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Print = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_InchargeReceipt = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdLineProd = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_TimeMaterialOutBound = New PSMGlobal.SelectLabelText()
        Me.txt_cdDepartment = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSubProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_JobCardWorking = New PSMGlobal.SelectLabelText()
        Me.Pan_Process = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_FactOrderSeq = New PSMGlobal.SelectLabelText()
        Me.txt_FactOrderNo = New PSMGlobal.SelectLabelText()
        Me.txt_ProdSeq = New PSMGlobal.SelectLabelText()
        Me.rad_CheckOutSide6 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOutSide5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOutSide3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_ProdDate = New PSMGlobal.SelectLabelText()
        Me.rad_CheckOutSide4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOutSide1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckOutSide2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeaceButton2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceMaskedtextbox1 = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        vS1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.Pan_Process, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Process.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Bk_1
        '
        Me.Bk_1.WorkerReportsProgress = True
        Me.Bk_1.WorkerSupportsCancellation = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.vS1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(948, 650)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_Print)
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 608)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(942, 39)
        Me.Frame4.TabIndex = 1
        Me.Frame4.Tag = ""
        '
        'cmd_Print
        '
        Me.cmd_Print.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_Print.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Print.Appearance.Options.UseFont = True
        Me.cmd_Print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Print.ButtonTitle = Nothing
        Me.cmd_Print.Code = Nothing
        Me.cmd_Print.Data = Nothing
        Me.cmd_Print.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.cmd_Print.ImageAlign = 16
        Me.cmd_Print.Location = New System.Drawing.Point(401, 2)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Print.TabIndex = 6
        Me.cmd_Print.TabStop = False
        Me.cmd_Print.Text = "PRINT(&P)"
        Me.cmd_Print.UseVisualStyleBackColor = False
        '
        'cmd_DEL
        '
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
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.TabStop = False
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(799, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
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
        Me.cmd_OK.Location = New System.Drawing.Point(658, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.Pan_Process)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(942, 105)
        Me.Panel1.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_InchargeReceipt)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdLineProd)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_TimeMaterialOutBound)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdDepartment)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSubProcess)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_JobCardWorking)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(318, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(619, 98)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = ""
        '
        'txt_InchargeReceipt
        '
        Me.txt_InchargeReceipt.BackYesno = False
        Me.txt_InchargeReceipt.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeReceipt.ButtonEnabled = True
        Me.txt_InchargeReceipt.ButtonFont = Nothing
        Me.txt_InchargeReceipt.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeReceipt.ButtonName = ""
        Me.txt_InchargeReceipt.ButtonTitle = "Incharge"
        Me.txt_InchargeReceipt.Code = ""
        Me.txt_InchargeReceipt.Data = ""
        Me.txt_InchargeReceipt.DataDecimal = 1
        Me.txt_InchargeReceipt.DataLen = 0
        Me.txt_InchargeReceipt.DataValue = 1
        Me.txt_InchargeReceipt.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_InchargeReceipt.Location = New System.Drawing.Point(310, 3)
        Me.txt_InchargeReceipt.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeReceipt.Name = "txt_InchargeReceipt"
        Me.txt_InchargeReceipt.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeReceipt.Size = New System.Drawing.Size(306, 23)
        Me.txt_InchargeReceipt.TabIndex = 2
        Me.txt_InchargeReceipt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeReceipt.TextBoxAutoComplete = False
        Me.txt_InchargeReceipt.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeReceipt.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_InchargeReceipt.TextEnabled = True
        Me.txt_InchargeReceipt.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeReceipt.TextMaxLength = 32767
        Me.txt_InchargeReceipt.TextMultiLine = False
        Me.txt_InchargeReceipt.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeReceipt.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeReceipt.UseSendTab = True
        '
        'txt_cdLineProd
        '
        Me.txt_cdLineProd.BackYesno = False
        Me.txt_cdLineProd.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLineProd.ButtonEnabled = True
        Me.txt_cdLineProd.ButtonFont = Nothing
        Me.txt_cdLineProd.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.ButtonName = ""
        Me.txt_cdLineProd.ButtonTitle = "Line Prod"
        Me.txt_cdLineProd.Code = ""
        Me.txt_cdLineProd.Data = ""
        Me.txt_cdLineProd.DataDecimal = 0
        Me.txt_cdLineProd.DataLen = 0
        Me.txt_cdLineProd.DataValue = 1
        Me.txt_cdLineProd.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdLineProd.Location = New System.Drawing.Point(310, 28)
        Me.txt_cdLineProd.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLineProd.Name = "txt_cdLineProd"
        Me.txt_cdLineProd.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLineProd.Size = New System.Drawing.Size(306, 21)
        Me.txt_cdLineProd.TabIndex = 3
        Me.txt_cdLineProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLineProd.TextBoxAutoComplete = False
        Me.txt_cdLineProd.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdLineProd.TextEnabled = True
        Me.txt_cdLineProd.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdLineProd.TextMaxLength = 32767
        Me.txt_cdLineProd.TextMultiLine = False
        Me.txt_cdLineProd.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdLineProd.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdLineProd.UseSendTab = True
        '
        'txt_TimeMaterialOutBound
        '
        Me.txt_TimeMaterialOutBound.BackYesno = False
        Me.txt_TimeMaterialOutBound.ButtonTitle = Nothing
        Me.txt_TimeMaterialOutBound.Code = Nothing
        Me.txt_TimeMaterialOutBound.Data = ""
        Me.txt_TimeMaterialOutBound.DataDecimal = 0
        Me.txt_TimeMaterialOutBound.DataLen = 0
        Me.txt_TimeMaterialOutBound.DataValue = 0
        Me.txt_TimeMaterialOutBound.FormatDecimal = 0
        Me.txt_TimeMaterialOutBound.FormatValue = False
        Me.txt_TimeMaterialOutBound.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TimeMaterialOutBound.LableEnabled = True
        Me.txt_TimeMaterialOutBound.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TimeMaterialOutBound.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TimeMaterialOutBound.LableTitle = "Time Outbound"
        Me.txt_TimeMaterialOutBound.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_TimeMaterialOutBound.Location = New System.Drawing.Point(310, 53)
        Me.txt_TimeMaterialOutBound.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TimeMaterialOutBound.Name = "txt_TimeMaterialOutBound"
        Me.txt_TimeMaterialOutBound.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TimeMaterialOutBound.Size = New System.Drawing.Size(306, 40)
        Me.txt_TimeMaterialOutBound.TabIndex = 5
        Me.txt_TimeMaterialOutBound.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TimeMaterialOutBound.TextBoxAutoComplete = False
        Me.txt_TimeMaterialOutBound.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TimeMaterialOutBound.TextBoxFont = New System.Drawing.Font("Tahoma", 14.0!)
        Me.txt_TimeMaterialOutBound.TextEnabled = True
        Me.txt_TimeMaterialOutBound.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TimeMaterialOutBound.TextMaxLength = 32767
        Me.txt_TimeMaterialOutBound.TextMultiLine = False
        Me.txt_TimeMaterialOutBound.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TimeMaterialOutBound.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TimeMaterialOutBound.UseSendTab = True
        '
        'txt_cdDepartment
        '
        Me.txt_cdDepartment.BackYesno = False
        Me.txt_cdDepartment.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDepartment.ButtonEnabled = True
        Me.txt_cdDepartment.ButtonFont = Nothing
        Me.txt_cdDepartment.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.ButtonName = ""
        Me.txt_cdDepartment.ButtonTitle = "Department"
        Me.txt_cdDepartment.Code = ""
        Me.txt_cdDepartment.Data = ""
        Me.txt_cdDepartment.DataDecimal = 0
        Me.txt_cdDepartment.DataLen = 0
        Me.txt_cdDepartment.DataValue = 1
        Me.txt_cdDepartment.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDepartment.Location = New System.Drawing.Point(3, 26)
        Me.txt_cdDepartment.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDepartment.Name = "txt_cdDepartment"
        Me.txt_cdDepartment.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDepartment.Size = New System.Drawing.Size(306, 21)
        Me.txt_cdDepartment.TabIndex = 1
        Me.txt_cdDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDepartment.TextBoxAutoComplete = False
        Me.txt_cdDepartment.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdDepartment.TextEnabled = True
        Me.txt_cdDepartment.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextMaxLength = 32767
        Me.txt_cdDepartment.TextMultiLine = False
        Me.txt_cdDepartment.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDepartment.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDepartment.UseSendTab = True
        '
        'txt_cdSubProcess
        '
        Me.txt_cdSubProcess.BackYesno = False
        Me.txt_cdSubProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSubProcess.ButtonEnabled = True
        Me.txt_cdSubProcess.ButtonFont = Nothing
        Me.txt_cdSubProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSubProcess.ButtonName = ""
        Me.txt_cdSubProcess.ButtonTitle = "Sub Process"
        Me.txt_cdSubProcess.Code = ""
        Me.txt_cdSubProcess.Data = ""
        Me.txt_cdSubProcess.DataDecimal = 0
        Me.txt_cdSubProcess.DataLen = 0
        Me.txt_cdSubProcess.DataValue = 1
        Me.txt_cdSubProcess.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSubProcess.Location = New System.Drawing.Point(3, 3)
        Me.txt_cdSubProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSubProcess.Name = "txt_cdSubProcess"
        Me.txt_cdSubProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSubProcess.Size = New System.Drawing.Size(306, 21)
        Me.txt_cdSubProcess.TabIndex = 0
        Me.txt_cdSubProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSubProcess.TextBoxAutoComplete = False
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
        'txt_JobCardWorking
        '
        Me.txt_JobCardWorking.BackYesno = False
        Me.txt_JobCardWorking.ButtonTitle = Nothing
        Me.txt_JobCardWorking.Code = Nothing
        Me.txt_JobCardWorking.Data = ""
        Me.txt_JobCardWorking.DataDecimal = 0
        Me.txt_JobCardWorking.DataLen = 0
        Me.txt_JobCardWorking.DataValue = 0
        Me.txt_JobCardWorking.FormatDecimal = 0
        Me.txt_JobCardWorking.FormatValue = False
        Me.txt_JobCardWorking.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_JobCardWorking.LableEnabled = True
        Me.txt_JobCardWorking.LableFont = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_JobCardWorking.LableForeColor = System.Drawing.Color.Black
        Me.txt_JobCardWorking.LableTitle = "B#"
        Me.txt_JobCardWorking.Layoutpercent = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txt_JobCardWorking.Location = New System.Drawing.Point(1, 52)
        Me.txt_JobCardWorking.Margin = New System.Windows.Forms.Padding(1, 1, 100, 1)
        Me.txt_JobCardWorking.Name = "txt_JobCardWorking"
        Me.txt_JobCardWorking.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_JobCardWorking.Size = New System.Drawing.Size(306, 42)
        Me.txt_JobCardWorking.TabIndex = 4
        Me.txt_JobCardWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_JobCardWorking.TextBoxAutoComplete = True
        Me.txt_JobCardWorking.TextboxBackColor = System.Drawing.Color.White
        Me.txt_JobCardWorking.TextBoxFont = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_JobCardWorking.TextEnabled = True
        Me.txt_JobCardWorking.TextForeColor = System.Drawing.Color.Empty
        Me.txt_JobCardWorking.TextMaxLength = 1000
        Me.txt_JobCardWorking.TextMultiLine = False
        Me.txt_JobCardWorking.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_JobCardWorking.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_JobCardWorking.UseSendTab = True
        '
        'Pan_Process
        '
        Me.Pan_Process.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pan_Process.Code = ""
        Me.Pan_Process.Controls.Add(Me.txt_FactOrderSeq)
        Me.Pan_Process.Controls.Add(Me.txt_FactOrderNo)
        Me.Pan_Process.Controls.Add(Me.txt_ProdSeq)
        Me.Pan_Process.Controls.Add(Me.rad_CheckOutSide6)
        Me.Pan_Process.Controls.Add(Me.rad_CheckOutSide5)
        Me.Pan_Process.Controls.Add(Me.rad_CheckOutSide3)
        Me.Pan_Process.Controls.Add(Me.txt_ProdDate)
        Me.Pan_Process.Controls.Add(Me.rad_CheckOutSide4)
        Me.Pan_Process.Controls.Add(Me.rad_CheckOutSide1)
        Me.Pan_Process.Controls.Add(Me.rad_CheckOutSide2)
        Me.Pan_Process.Data = ""
        Me.Pan_Process.Location = New System.Drawing.Point(2, 4)
        Me.Pan_Process.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.Pan_Process.Name = "Pan_Process"
        Me.Pan_Process.Size = New System.Drawing.Size(312, 97)
        Me.Pan_Process.TabIndex = 0
        Me.Pan_Process.Tag = ""
        '
        'txt_FactOrderSeq
        '
        Me.txt_FactOrderSeq.BackYesno = False
        Me.txt_FactOrderSeq.ButtonTitle = Nothing
        Me.txt_FactOrderSeq.Code = Nothing
        Me.txt_FactOrderSeq.Data = ""
        Me.txt_FactOrderSeq.DataDecimal = 0
        Me.txt_FactOrderSeq.DataLen = 0
        Me.txt_FactOrderSeq.DataValue = 0
        Me.txt_FactOrderSeq.FormatDecimal = 0
        Me.txt_FactOrderSeq.FormatValue = False
        Me.txt_FactOrderSeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_FactOrderSeq.LableEnabled = True
        Me.txt_FactOrderSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_FactOrderSeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_FactOrderSeq.LableTitle = "Date"
        Me.txt_FactOrderSeq.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_FactOrderSeq.Location = New System.Drawing.Point(189, 27)
        Me.txt_FactOrderSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_FactOrderSeq.Name = "txt_FactOrderSeq"
        Me.txt_FactOrderSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_FactOrderSeq.Size = New System.Drawing.Size(120, 23)
        Me.txt_FactOrderSeq.TabIndex = 190
        Me.txt_FactOrderSeq.TabStop = False
        Me.txt_FactOrderSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_FactOrderSeq.TextBoxAutoComplete = False
        Me.txt_FactOrderSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_FactOrderSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_FactOrderSeq.TextEnabled = False
        Me.txt_FactOrderSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_FactOrderSeq.TextMaxLength = 32767
        Me.txt_FactOrderSeq.TextMultiLine = False
        Me.txt_FactOrderSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_FactOrderSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_FactOrderSeq.UseSendTab = True
        '
        'txt_FactOrderNo
        '
        Me.txt_FactOrderNo.BackYesno = False
        Me.txt_FactOrderNo.ButtonTitle = Nothing
        Me.txt_FactOrderNo.Code = Nothing
        Me.txt_FactOrderNo.Data = ""
        Me.txt_FactOrderNo.DataDecimal = 0
        Me.txt_FactOrderNo.DataLen = 0
        Me.txt_FactOrderNo.DataValue = 0
        Me.txt_FactOrderNo.FormatDecimal = 0
        Me.txt_FactOrderNo.FormatValue = False
        Me.txt_FactOrderNo.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_FactOrderNo.LableEnabled = True
        Me.txt_FactOrderNo.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_FactOrderNo.LableForeColor = System.Drawing.Color.Empty
        Me.txt_FactOrderNo.LableTitle = "Fact#"
        Me.txt_FactOrderNo.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_FactOrderNo.Location = New System.Drawing.Point(2, 27)
        Me.txt_FactOrderNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_FactOrderNo.Name = "txt_FactOrderNo"
        Me.txt_FactOrderNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_FactOrderNo.Size = New System.Drawing.Size(185, 23)
        Me.txt_FactOrderNo.TabIndex = 189
        Me.txt_FactOrderNo.TabStop = False
        Me.txt_FactOrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_FactOrderNo.TextBoxAutoComplete = False
        Me.txt_FactOrderNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_FactOrderNo.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_FactOrderNo.TextEnabled = False
        Me.txt_FactOrderNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_FactOrderNo.TextMaxLength = 32767
        Me.txt_FactOrderNo.TextMultiLine = False
        Me.txt_FactOrderNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_FactOrderNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_FactOrderNo.UseSendTab = True
        '
        'txt_ProdSeq
        '
        Me.txt_ProdSeq.BackYesno = False
        Me.txt_ProdSeq.ButtonTitle = Nothing
        Me.txt_ProdSeq.Code = Nothing
        Me.txt_ProdSeq.Data = ""
        Me.txt_ProdSeq.DataDecimal = 0
        Me.txt_ProdSeq.DataLen = 0
        Me.txt_ProdSeq.DataValue = 0
        Me.txt_ProdSeq.FormatDecimal = 0
        Me.txt_ProdSeq.FormatValue = False
        Me.txt_ProdSeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProdSeq.LableEnabled = True
        Me.txt_ProdSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdSeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProdSeq.LableTitle = "Date"
        Me.txt_ProdSeq.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_ProdSeq.Location = New System.Drawing.Point(189, 3)
        Me.txt_ProdSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProdSeq.Name = "txt_ProdSeq"
        Me.txt_ProdSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProdSeq.Size = New System.Drawing.Size(59, 23)
        Me.txt_ProdSeq.TabIndex = 187
        Me.txt_ProdSeq.TabStop = False
        Me.txt_ProdSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ProdSeq.TextBoxAutoComplete = False
        Me.txt_ProdSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ProdSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdSeq.TextEnabled = False
        Me.txt_ProdSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProdSeq.TextMaxLength = 32767
        Me.txt_ProdSeq.TextMultiLine = False
        Me.txt_ProdSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProdSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProdSeq.UseSendTab = True
        '
        'rad_CheckOutSide6
        '
        Me.rad_CheckOutSide6.AutoSize = True
        Me.rad_CheckOutSide6.ButtonTitle = Nothing
        Me.rad_CheckOutSide6.Enabled = False
        Me.rad_CheckOutSide6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckOutSide6.Location = New System.Drawing.Point(201, 73)
        Me.rad_CheckOutSide6.Name = "rad_CheckOutSide6"
        Me.rad_CheckOutSide6.Size = New System.Drawing.Size(93, 18)
        Me.rad_CheckOutSide6.TabIndex = 5
        Me.rad_CheckOutSide6.Text = "Return Pur"
        Me.rad_CheckOutSide6.UseVisualStyleBackColor = True
        '
        'rad_CheckOutSide5
        '
        Me.rad_CheckOutSide5.AutoSize = True
        Me.rad_CheckOutSide5.ButtonTitle = Nothing
        Me.rad_CheckOutSide5.Enabled = False
        Me.rad_CheckOutSide5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckOutSide5.Location = New System.Drawing.Point(103, 73)
        Me.rad_CheckOutSide5.Name = "rad_CheckOutSide5"
        Me.rad_CheckOutSide5.Size = New System.Drawing.Size(74, 18)
        Me.rad_CheckOutSide5.TabIndex = 4
        Me.rad_CheckOutSide5.Text = "OutSide"
        Me.rad_CheckOutSide5.UseVisualStyleBackColor = True
        '
        'rad_CheckOutSide3
        '
        Me.rad_CheckOutSide3.AutoSize = True
        Me.rad_CheckOutSide3.ButtonTitle = Nothing
        Me.rad_CheckOutSide3.Enabled = False
        Me.rad_CheckOutSide3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckOutSide3.ForeColor = System.Drawing.Color.Red
        Me.rad_CheckOutSide3.Location = New System.Drawing.Point(201, 51)
        Me.rad_CheckOutSide3.Name = "rad_CheckOutSide3"
        Me.rad_CheckOutSide3.Size = New System.Drawing.Size(58, 18)
        Me.rad_CheckOutSide3.TabIndex = 2
        Me.rad_CheckOutSide3.Text = "Trash"
        Me.rad_CheckOutSide3.UseVisualStyleBackColor = True
        '
        'txt_ProdDate
        '
        Me.txt_ProdDate.BackYesno = False
        Me.txt_ProdDate.ButtonTitle = Nothing
        Me.txt_ProdDate.Code = Nothing
        Me.txt_ProdDate.Data = ""
        Me.txt_ProdDate.DataDecimal = 0
        Me.txt_ProdDate.DataLen = 0
        Me.txt_ProdDate.DataValue = 0
        Me.txt_ProdDate.FormatDecimal = 0
        Me.txt_ProdDate.FormatValue = False
        Me.txt_ProdDate.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProdDate.LableEnabled = True
        Me.txt_ProdDate.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdDate.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProdDate.LableTitle = "Date"
        Me.txt_ProdDate.Layoutpercent = New Decimal(New Integer() {35, 0, 0, 131072})
        Me.txt_ProdDate.Location = New System.Drawing.Point(2, 3)
        Me.txt_ProdDate.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProdDate.Name = "txt_ProdDate"
        Me.txt_ProdDate.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProdDate.Size = New System.Drawing.Size(185, 23)
        Me.txt_ProdDate.TabIndex = 186
        Me.txt_ProdDate.TabStop = False
        Me.txt_ProdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ProdDate.TextBoxAutoComplete = False
        Me.txt_ProdDate.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ProdDate.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProdDate.TextEnabled = False
        Me.txt_ProdDate.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProdDate.TextMaxLength = 32767
        Me.txt_ProdDate.TextMultiLine = False
        Me.txt_ProdDate.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProdDate.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProdDate.UseSendTab = True
        '
        'rad_CheckOutSide4
        '
        Me.rad_CheckOutSide4.AutoSize = True
        Me.rad_CheckOutSide4.ButtonTitle = Nothing
        Me.rad_CheckOutSide4.Enabled = False
        Me.rad_CheckOutSide4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckOutSide4.Location = New System.Drawing.Point(8, 74)
        Me.rad_CheckOutSide4.Name = "rad_CheckOutSide4"
        Me.rad_CheckOutSide4.Size = New System.Drawing.Size(56, 18)
        Me.rad_CheckOutSide4.TabIndex = 3
        Me.rad_CheckOutSide4.Text = "Sales"
        Me.rad_CheckOutSide4.UseVisualStyleBackColor = True
        '
        'rad_CheckOutSide1
        '
        Me.rad_CheckOutSide1.AutoSize = True
        Me.rad_CheckOutSide1.ButtonTitle = Nothing
        Me.rad_CheckOutSide1.Checked = True
        Me.rad_CheckOutSide1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckOutSide1.ForeColor = System.Drawing.Color.Blue
        Me.rad_CheckOutSide1.Location = New System.Drawing.Point(7, 51)
        Me.rad_CheckOutSide1.Name = "rad_CheckOutSide1"
        Me.rad_CheckOutSide1.Size = New System.Drawing.Size(64, 18)
        Me.rad_CheckOutSide1.TabIndex = 0
        Me.rad_CheckOutSide1.TabStop = True
        Me.rad_CheckOutSide1.Text = "InSide"
        Me.rad_CheckOutSide1.UseVisualStyleBackColor = True
        '
        'rad_CheckOutSide2
        '
        Me.rad_CheckOutSide2.AutoSize = True
        Me.rad_CheckOutSide2.ButtonTitle = Nothing
        Me.rad_CheckOutSide2.Enabled = False
        Me.rad_CheckOutSide2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckOutSide2.ForeColor = System.Drawing.Color.Green
        Me.rad_CheckOutSide2.Location = New System.Drawing.Point(102, 51)
        Me.rad_CheckOutSide2.Name = "rad_CheckOutSide2"
        Me.rad_CheckOutSide2.Size = New System.Drawing.Size(71, 18)
        Me.rad_CheckOutSide2.TabIndex = 1
        Me.rad_CheckOutSide2.Text = "Balance"
        Me.rad_CheckOutSide2.UseVisualStyleBackColor = True
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = ""
        Me.vS1.AllowDragFill = True
        Me.vS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vS1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.vS1.CopyPasteChk = True
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
        Me.vS1.HorizontalScrollBar.TabIndex = 0
        Me.vS1.InsChk = True
        Me.vS1.Location = New System.Drawing.Point(3, 114)
        Me.vS1.Name = "vS1"
        NamedStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle1.Border = BevelBorder1
        NamedStyle1.CanFocus = False
        TextCellType1.WordWrap = True
        NamedStyle1.CellType = TextCellType1
        NamedStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle1.ForeColor = System.Drawing.Color.White
        NamedStyle1.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle1.Locked = False
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = TextCellType1
        NamedStyle1.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle1.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle2.Border = BevelBorder2
        NamedStyle2.CellType = TextCellType2
        NamedStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        NamedStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        NamedStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle4.Locked = False
        NamedStyle4.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle4.Renderer = TextCellType4
        NamedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle5.BackColor = System.Drawing.SystemColors.Window
        NamedStyle5.CellType = GeneralCellType1
        NamedStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NamedStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle5.Locked = False
        NamedStyle5.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle5.Renderer = GeneralCellType1
        Me.vS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.vS1.ReportName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(942, 488)
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
        SpreadSkin1.Name = "Hung123"
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
        Me.vS1.TabIndex = 0
        Me.vS1.TabStop = False
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
        Me.vS1.VerticalScrollBar.TabIndex = 9
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
        'PeaceButton2
        '
        Me.PeaceButton2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton2.Appearance.Options.UseFont = True
        Me.PeaceButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PeaceButton2.ButtonTitle = Nothing
        Me.PeaceButton2.Code = Nothing
        Me.PeaceButton2.Data = Nothing
        Me.PeaceButton2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton2.ImageAlign = 0
        Me.PeaceButton2.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton2.Name = "PeaceButton2"
        Me.PeaceButton2.Size = New System.Drawing.Size(137, 27)
        Me.PeaceButton2.TabIndex = 2
        Me.PeaceButton2.TabStop = False
        Me.PeaceButton2.Text = "Date Exchange"
        Me.PeaceButton2.UseVisualStyleBackColor = False
        '
        'PeaceMaskedtextbox1
        '
        Me.PeaceMaskedtextbox1.BackColor = System.Drawing.Color.White
        Me.PeaceMaskedtextbox1.Code = Nothing
        Me.PeaceMaskedtextbox1.Data = "2015/01/01"
        Me.PeaceMaskedtextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceMaskedtextbox1.DTDec = 0
        Me.PeaceMaskedtextbox1.DTLen = 0
        Me.PeaceMaskedtextbox1.DTValue = 0
        Me.PeaceMaskedtextbox1.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.PeaceMaskedtextbox1.Location = New System.Drawing.Point(137, 0)
        Me.PeaceMaskedtextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceMaskedtextbox1.Mask = "0000/00/00"
        Me.PeaceMaskedtextbox1.Name = "PeaceMaskedtextbox1"
        Me.PeaceMaskedtextbox1.NoClear = False
        Me.PeaceMaskedtextbox1.PromptChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.PeaceMaskedtextbox1.Size = New System.Drawing.Size(208, 25)
        Me.PeaceMaskedtextbox1.TabIndex = 3
        Me.PeaceMaskedtextbox1.Text = "20150101"
        Me.PeaceMaskedtextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ISUD2356Q
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(948, 650)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.KeyPreview = True
        Me.Name = "ISUD2356Q"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Material Receipt PROCESSING  (ISUD2356Q)"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.Pan_Process, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Process.ResumeLayout(False)
        Me.Pan_Process.PerformLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents PeaceButton2 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Bk_1 As System.ComponentModel.BackgroundWorker
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_JobCardWorking As PSMGlobal.SelectLabelText
    Public WithEvents Pan_Process As PSMGlobal.PeacePanel
    Friend WithEvents rad_CheckOutSide6 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOutSide5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOutSide3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOutSide4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOutSide1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckOutSide2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_ProdDate As PSMGlobal.SelectLabelText
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_TimeMaterialOutBound As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ProdSeq As PSMGlobal.SelectLabelText
    Friend WithEvents cmd_Print As PSMGlobal.PeaceButton
    Friend WithEvents txt_FactOrderSeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_FactOrderNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdLineProd As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDepartment As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSubProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_InchargeReceipt As PSMGlobal.SelectPeaceHLPButton
End Class
