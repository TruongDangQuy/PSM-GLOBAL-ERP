<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7106A
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
        Dim vS0_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim vS0_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim TextCellType11 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_VerSAM = New PSMGlobal.SelectLabelText()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txt_ShoesCode = New PSMGlobal.SelectLabelText()
        Me.Block2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_TargetPrice = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_PriceUSD = New PSMGlobal.PeaceNumericupdown(Me.components)
        Me.txt_InchargeDesigner = New PSMGlobal.SelectPeaceHLPButton()
        Me.chk_CopyAll = New System.Windows.Forms.CheckBox()
        Me.vS0 = New PSMGlobal.PeaceFarpoint()
        Me.vS0_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.txt_Remark = New PSMGlobal.PeaceMemo(Me.components)
        Me.txt_cdProductSize = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdProductType = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_VerJob = New PSMGlobal.SelectLabelText()
        Me.txt_ProductCode = New PSMGlobal.SelectLabelText()
        Me.txt_VERROT = New PSMGlobal.SelectLabelText()
        Me.txt_VerCBD = New PSMGlobal.SelectLabelText()
        Me.txt_VerBOM = New PSMGlobal.SelectLabelText()
        Me.chk_Job = New System.Windows.Forms.CheckBox()
        Me.chk_CBD = New System.Windows.Forms.CheckBox()
        Me.cmd_JOB = New PSMGlobal.SelectPeaceHLPButton()
        Me.chk_Process = New System.Windows.Forms.CheckBox()
        Me.txt_SizeRange = New PSMGlobal.SelectPeaceHLPButton()
        Me.chk_CheckParent = New System.Windows.Forms.CheckBox()
        Me.cmd_Process = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_CBDProcess = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_ShoesParent = New PSMGlobal.SelectLabelText()
        Me.txt_cdSpecState = New PSMGlobal.SelectPeaceHLPButton()
        Me.chk_Group = New System.Windows.Forms.CheckBox()
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_CustSpecNo = New PSMGlobal.SelectLabelText()
        Me.cmd_GC = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSeason = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Style = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_MCODE = New PSMGlobal.SelectLabelText()
        Me.txt_MCODEName = New PSMGlobal.SelectLabelText()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.txt_ColorCode = New PSMGlobal.SelectLabelText()
        Me.txt_cdGender = New PSMGlobal.SelectPeaceHLPButton()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.Cms_1 = New PSMGlobal.PeaceContextMenuStrip(Me.components)
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        vS0_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS0_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        vS0_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.Block2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Block2.SuspendLayout()
        CType(Me.txt_PriceUSD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS0_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_Remark.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.txt_VerSAM)
        Me.frm_Condition.Controls.Add(Me.CheckBox1)
        Me.frm_Condition.Controls.Add(Me.txt_ShoesCode)
        Me.frm_Condition.Controls.Add(Me.Block2)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Location = New System.Drawing.Point(0, 41)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(597, 518)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'txt_VerSAM
        '
        Me.txt_VerSAM.BackYesno = False
        Me.txt_VerSAM.ButtonTitle = Nothing
        Me.txt_VerSAM.Code = Nothing
        Me.txt_VerSAM.Data = ""
        Me.txt_VerSAM.DataDecimal = 0
        Me.txt_VerSAM.DataLen = 0
        Me.txt_VerSAM.DataValue = 0
        Me.txt_VerSAM.FormatDecimal = 0
        Me.txt_VerSAM.FormatValue = False
        Me.txt_VerSAM.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VerSAM.LableEnabled = True
        Me.txt_VerSAM.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerSAM.LableForeColor = System.Drawing.Color.Empty
        Me.txt_VerSAM.LableTitle = "SAM Ver"
        Me.txt_VerSAM.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_VerSAM.Location = New System.Drawing.Point(440, 7)
        Me.txt_VerSAM.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_VerSAM.Name = "txt_VerSAM"
        Me.txt_VerSAM.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VerSAM.Size = New System.Drawing.Size(150, 22)
        Me.txt_VerSAM.TabIndex = 130
        Me.txt_VerSAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VerSAM.TextBoxAutoComplete = False
        Me.txt_VerSAM.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VerSAM.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerSAM.TextEnabled = True
        Me.txt_VerSAM.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VerSAM.TextMaxLength = 32767
        Me.txt_VerSAM.TextMultiLine = False
        Me.txt_VerSAM.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VerSAM.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VerSAM.UseSendTab = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(320, 9)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 129
        Me.CheckBox1.Text = "Check Version"
        Me.CheckBox1.UseVisualStyleBackColor = True
        Me.CheckBox1.Visible = False
        '
        'txt_ShoesCode
        '
        Me.txt_ShoesCode.BackYesno = False
        Me.txt_ShoesCode.ButtonTitle = Nothing
        Me.txt_ShoesCode.Code = Nothing
        Me.txt_ShoesCode.Data = ""
        Me.txt_ShoesCode.DataDecimal = 0
        Me.txt_ShoesCode.DataLen = 0
        Me.txt_ShoesCode.DataValue = 0
        Me.txt_ShoesCode.FormatDecimal = 0
        Me.txt_ShoesCode.FormatValue = False
        Me.txt_ShoesCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ShoesCode.LableEnabled = True
        Me.txt_ShoesCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_ShoesCode.LableForeColor = System.Drawing.Color.Blue
        Me.txt_ShoesCode.LableTitle = "Item Code"
        Me.txt_ShoesCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ShoesCode.Location = New System.Drawing.Point(10, 4)
        Me.txt_ShoesCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ShoesCode.Name = "txt_ShoesCode"
        Me.txt_ShoesCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ShoesCode.Size = New System.Drawing.Size(300, 24)
        Me.txt_ShoesCode.TabIndex = 0
        Me.txt_ShoesCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ShoesCode.TextBoxAutoComplete = False
        Me.txt_ShoesCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ShoesCode.TextEnabled = True
        Me.txt_ShoesCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesCode.TextMaxLength = 32767
        Me.txt_ShoesCode.TextMultiLine = False
        Me.txt_ShoesCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ShoesCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ShoesCode.UseSendTab = True
        '
        'Block2
        '
        Me.Block2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Block2.Code = ""
        Me.Block2.Controls.Add(Me.txt_Line)
        Me.Block2.Controls.Add(Me.txt_TargetPrice)
        Me.Block2.Controls.Add(Me.txt_PriceUSD)
        Me.Block2.Controls.Add(Me.txt_InchargeDesigner)
        Me.Block2.Controls.Add(Me.chk_CopyAll)
        Me.Block2.Controls.Add(Me.vS0)
        Me.Block2.Controls.Add(Me.txt_Remark)
        Me.Block2.Controls.Add(Me.txt_cdProductSize)
        Me.Block2.Controls.Add(Me.txt_cdProductType)
        Me.Block2.Controls.Add(Me.txt_VerJob)
        Me.Block2.Controls.Add(Me.txt_ProductCode)
        Me.Block2.Controls.Add(Me.txt_VERROT)
        Me.Block2.Controls.Add(Me.txt_VerCBD)
        Me.Block2.Controls.Add(Me.txt_VerBOM)
        Me.Block2.Controls.Add(Me.chk_Job)
        Me.Block2.Controls.Add(Me.chk_CBD)
        Me.Block2.Controls.Add(Me.cmd_JOB)
        Me.Block2.Controls.Add(Me.chk_Process)
        Me.Block2.Controls.Add(Me.txt_SizeRange)
        Me.Block2.Controls.Add(Me.chk_CheckParent)
        Me.Block2.Controls.Add(Me.cmd_Process)
        Me.Block2.Controls.Add(Me.txt_CBDProcess)
        Me.Block2.Controls.Add(Me.txt_ShoesParent)
        Me.Block2.Controls.Add(Me.txt_cdSpecState)
        Me.Block2.Controls.Add(Me.chk_Group)
        Me.Block2.Controls.Add(Me.txt_CustomerCode)
        Me.Block2.Controls.Add(Me.txt_CustSpecNo)
        Me.Block2.Controls.Add(Me.cmd_GC)
        Me.Block2.Controls.Add(Me.txt_cdSeason)
        Me.Block2.Controls.Add(Me.txt_Style)
        Me.Block2.Controls.Add(Me.txt_Article)
        Me.Block2.Controls.Add(Me.txt_MCODE)
        Me.Block2.Controls.Add(Me.txt_MCODEName)
        Me.Block2.Controls.Add(Me.txt_ColorName)
        Me.Block2.Controls.Add(Me.txt_ColorCode)
        Me.Block2.Controls.Add(Me.txt_cdGender)
        Me.Block2.Controls.Add(Me.tit_Use)
        Me.Block2.Controls.Add(Me.Panel5)
        Me.Block2.Data = ""
        Me.Block2.Location = New System.Drawing.Point(3, 31)
        Me.Block2.Name = "Block2"
        Me.Block2.Size = New System.Drawing.Size(593, 496)
        Me.Block2.TabIndex = 1
        Me.Block2.Tag = ""
        '
        'txt_TargetPrice
        '
        Me.txt_TargetPrice.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txt_TargetPrice.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TargetPrice.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_TargetPrice.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_TargetPrice.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_TargetPrice.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TargetPrice.ButtonTitle = Nothing
        Me.txt_TargetPrice.Code = ""
        Me.txt_TargetPrice.Data = ""
        Me.txt_TargetPrice.DTDec = 0
        Me.txt_TargetPrice.DTLen = 0
        Me.txt_TargetPrice.DTValue = 0
        Me.txt_TargetPrice.Location = New System.Drawing.Point(336, 149)
        Me.txt_TargetPrice.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TargetPrice.Name = "txt_TargetPrice"
        Me.txt_TargetPrice.NoClear = False
        Me.txt_TargetPrice.Size = New System.Drawing.Size(99, 20)
        Me.txt_TargetPrice.TabIndex = 61
        Me.txt_TargetPrice.Tag = ""
        Me.txt_TargetPrice.Text = "TGP ($)"
        Me.txt_TargetPrice.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_PriceUSD
        '
        Me.txt_PriceUSD.DecimalPlaces = 4
        Me.txt_PriceUSD.Location = New System.Drawing.Point(437, 148)
        Me.txt_PriceUSD.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_PriceUSD.Name = "txt_PriceUSD"
        Me.txt_PriceUSD.Size = New System.Drawing.Size(143, 21)
        Me.txt_PriceUSD.TabIndex = 60
        Me.txt_PriceUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_InchargeDesigner
        '
        Me.txt_InchargeDesigner.BackYesno = False
        Me.txt_InchargeDesigner.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeDesigner.ButtonEnabled = True
        Me.txt_InchargeDesigner.ButtonFont = Nothing
        Me.txt_InchargeDesigner.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeDesigner.ButtonName = ""
        Me.txt_InchargeDesigner.ButtonTitle = "PIC Designer"
        Me.txt_InchargeDesigner.Code = ""
        Me.txt_InchargeDesigner.Data = ""
        Me.txt_InchargeDesigner.DataDecimal = 0
        Me.txt_InchargeDesigner.DataLen = 0
        Me.txt_InchargeDesigner.DataValue = 1
        Me.txt_InchargeDesigner.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_InchargeDesigner.Location = New System.Drawing.Point(336, 119)
        Me.txt_InchargeDesigner.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeDesigner.Name = "txt_InchargeDesigner"
        Me.txt_InchargeDesigner.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeDesigner.Size = New System.Drawing.Size(250, 22)
        Me.txt_InchargeDesigner.TabIndex = 59
        Me.txt_InchargeDesigner.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeDesigner.TextBoxAutoComplete = False
        Me.txt_InchargeDesigner.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeDesigner.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeDesigner.TextEnabled = True
        Me.txt_InchargeDesigner.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeDesigner.TextMaxLength = 32767
        Me.txt_InchargeDesigner.TextMultiLine = False
        Me.txt_InchargeDesigner.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeDesigner.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeDesigner.UseSendTab = True
        '
        'chk_CopyAll
        '
        Me.chk_CopyAll.AutoSize = True
        Me.chk_CopyAll.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.chk_CopyAll.ForeColor = System.Drawing.Color.Blue
        Me.chk_CopyAll.Location = New System.Drawing.Point(504, 461)
        Me.chk_CopyAll.Name = "chk_CopyAll"
        Me.chk_CopyAll.Size = New System.Drawing.Size(76, 17)
        Me.chk_CopyAll.TabIndex = 58
        Me.chk_CopyAll.Text = "Copy all !"
        Me.chk_CopyAll.UseVisualStyleBackColor = True
        Me.chk_CopyAll.Visible = False
        '
        'vS0
        '
        Me.vS0.AccessibleDescription = ""
        Me.vS0.AllowDragFill = True
        Me.vS0.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.vS0.CopyPasteChk = False
        Me.vS0.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.vS0.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS0.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS0.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS0.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.vS0.HorizontalScrollBar.TabIndex = 2
        Me.vS0.InsChk = True
        Me.vS0.Location = New System.Drawing.Point(317, 177)
        Me.vS0.Name = "vS0"
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
        Me.vS0.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.vS0.ReportName = Nothing
        Me.vS0.SheetDSName = Nothing
        Me.vS0.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS0_Sheet1})
        Me.vS0.Size = New System.Drawing.Size(272, 274)
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
        Me.vS0.Skin = SpreadSkin1
        Me.vS0.SpreadWjob = 0
        Me.vS0.TabIndex = 3
        Me.vS0.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vS0.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vS0.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.vS0.VerticalScrollBar.TabIndex = 3
        Me.vS0.Visible = False
        vS0_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS0_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.V, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.X, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Delete, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectRow)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        vS0_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.vS0.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, vS0_InputMapWhenFocusedNormal)
        vS0_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS0_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfRows)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfRows)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfColumns)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfColumns)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstColumn)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastColumn)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstCell)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastCell)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectColumn)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectSheet)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.DateTimeNow)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        vS0_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.vS0.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, vS0_InputMapWhenAncestorOfFocusedNormal)
        '
        'vS0_Sheet1
        '
        Me.vS0_Sheet1.Reset()
        Me.vS0_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vS0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vS0_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS0_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        TextCellType11.WordWrap = True
        Me.vS0_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType11
        Me.vS0_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS0_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS0_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.vS0_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType11
        Me.vS0_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS0_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS0_Sheet1.DefaultStyle.Parent = "Style5"
        Me.vS0_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.vS0_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS0_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.vS0_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.vS0_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType11
        Me.vS0_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS0_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS0_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.vS0_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType11
        Me.vS0_Sheet1.Rows.Default.Height = 22.0!
        Me.vS0_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.vS0_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.vS0_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS0_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.vS0_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'txt_Remark
        '
        Me.txt_Remark.Code = Nothing
        Me.txt_Remark.Data = Nothing
        Me.txt_Remark.Location = New System.Drawing.Point(317, 177)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.Properties.Appearance.Options.UseFont = True
        Me.txt_Remark.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Remark.Size = New System.Drawing.Size(271, 275)
        Me.txt_Remark.TabIndex = 57
        '
        'txt_cdProductSize
        '
        Me.txt_cdProductSize.BackYesno = False
        Me.txt_cdProductSize.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdProductSize.ButtonEnabled = True
        Me.txt_cdProductSize.ButtonFont = Nothing
        Me.txt_cdProductSize.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductSize.ButtonName = ""
        Me.txt_cdProductSize.ButtonTitle = "Prod Size"
        Me.txt_cdProductSize.Code = ""
        Me.txt_cdProductSize.Data = ""
        Me.txt_cdProductSize.DataDecimal = 0
        Me.txt_cdProductSize.DataLen = 0
        Me.txt_cdProductSize.DataValue = 1
        Me.txt_cdProductSize.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdProductSize.Location = New System.Drawing.Point(7, 107)
        Me.txt_cdProductSize.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdProductSize.Name = "txt_cdProductSize"
        Me.txt_cdProductSize.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdProductSize.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdProductSize.TabIndex = 4
        Me.txt_cdProductSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdProductSize.TextBoxAutoComplete = False
        Me.txt_cdProductSize.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdProductSize.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdProductSize.TextEnabled = True
        Me.txt_cdProductSize.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductSize.TextMaxLength = 32767
        Me.txt_cdProductSize.TextMultiLine = False
        Me.txt_cdProductSize.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdProductSize.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdProductSize.UseSendTab = True
        '
        'txt_cdProductType
        '
        Me.txt_cdProductType.BackYesno = False
        Me.txt_cdProductType.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdProductType.ButtonEnabled = True
        Me.txt_cdProductType.ButtonFont = Nothing
        Me.txt_cdProductType.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductType.ButtonName = ""
        Me.txt_cdProductType.ButtonTitle = "Prod Type"
        Me.txt_cdProductType.Code = ""
        Me.txt_cdProductType.Data = ""
        Me.txt_cdProductType.DataDecimal = 0
        Me.txt_cdProductType.DataLen = 0
        Me.txt_cdProductType.DataValue = 1
        Me.txt_cdProductType.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdProductType.Location = New System.Drawing.Point(7, 81)
        Me.txt_cdProductType.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdProductType.Name = "txt_cdProductType"
        Me.txt_cdProductType.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdProductType.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdProductType.TabIndex = 3
        Me.txt_cdProductType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdProductType.TextBoxAutoComplete = False
        Me.txt_cdProductType.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdProductType.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdProductType.TextEnabled = True
        Me.txt_cdProductType.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdProductType.TextMaxLength = 32767
        Me.txt_cdProductType.TextMultiLine = False
        Me.txt_cdProductType.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdProductType.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdProductType.UseSendTab = True
        '
        'txt_VerJob
        '
        Me.txt_VerJob.BackYesno = False
        Me.txt_VerJob.ButtonTitle = Nothing
        Me.txt_VerJob.Code = Nothing
        Me.txt_VerJob.Data = ""
        Me.txt_VerJob.DataDecimal = 0
        Me.txt_VerJob.DataLen = 0
        Me.txt_VerJob.DataValue = 0
        Me.txt_VerJob.FormatDecimal = 0
        Me.txt_VerJob.FormatValue = False
        Me.txt_VerJob.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VerJob.LableEnabled = True
        Me.txt_VerJob.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerJob.LableForeColor = System.Drawing.Color.Empty
        Me.txt_VerJob.LableTitle = "CMT Ver"
        Me.txt_VerJob.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_VerJob.Location = New System.Drawing.Point(438, 90)
        Me.txt_VerJob.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_VerJob.Name = "txt_VerJob"
        Me.txt_VerJob.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VerJob.Size = New System.Drawing.Size(150, 22)
        Me.txt_VerJob.TabIndex = 20
        Me.txt_VerJob.TabStop = False
        Me.txt_VerJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VerJob.TextBoxAutoComplete = False
        Me.txt_VerJob.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VerJob.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerJob.TextEnabled = False
        Me.txt_VerJob.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VerJob.TextMaxLength = 32767
        Me.txt_VerJob.TextMultiLine = False
        Me.txt_VerJob.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VerJob.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VerJob.UseSendTab = True
        '
        'txt_ProductCode
        '
        Me.txt_ProductCode.BackYesno = False
        Me.txt_ProductCode.ButtonTitle = Nothing
        Me.txt_ProductCode.Code = Nothing
        Me.txt_ProductCode.Data = ""
        Me.txt_ProductCode.DataDecimal = 0
        Me.txt_ProductCode.DataLen = 0
        Me.txt_ProductCode.DataValue = 0
        Me.txt_ProductCode.FormatDecimal = 0
        Me.txt_ProductCode.FormatValue = False
        Me.txt_ProductCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ProductCode.LableEnabled = True
        Me.txt_ProductCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProductCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ProductCode.LableTitle = "Product Code"
        Me.txt_ProductCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ProductCode.Location = New System.Drawing.Point(7, 3)
        Me.txt_ProductCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ProductCode.Name = "txt_ProductCode"
        Me.txt_ProductCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ProductCode.Size = New System.Drawing.Size(300, 24)
        Me.txt_ProductCode.TabIndex = 0
        Me.txt_ProductCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ProductCode.TextBoxAutoComplete = False
        Me.txt_ProductCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ProductCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ProductCode.TextEnabled = True
        Me.txt_ProductCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ProductCode.TextMaxLength = 32767
        Me.txt_ProductCode.TextMultiLine = False
        Me.txt_ProductCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ProductCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ProductCode.UseSendTab = True
        '
        'txt_VERROT
        '
        Me.txt_VERROT.BackYesno = False
        Me.txt_VERROT.ButtonTitle = Nothing
        Me.txt_VERROT.Code = Nothing
        Me.txt_VERROT.Data = ""
        Me.txt_VERROT.DataDecimal = 0
        Me.txt_VERROT.DataLen = 0
        Me.txt_VERROT.DataValue = 0
        Me.txt_VERROT.FormatDecimal = 0
        Me.txt_VERROT.FormatValue = False
        Me.txt_VERROT.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VERROT.LableEnabled = True
        Me.txt_VERROT.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VERROT.LableForeColor = System.Drawing.Color.Empty
        Me.txt_VERROT.LableTitle = "ROT Ver"
        Me.txt_VERROT.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_VERROT.Location = New System.Drawing.Point(438, 61)
        Me.txt_VERROT.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_VERROT.Name = "txt_VERROT"
        Me.txt_VERROT.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VERROT.Size = New System.Drawing.Size(150, 22)
        Me.txt_VERROT.TabIndex = 19
        Me.txt_VERROT.TabStop = False
        Me.txt_VERROT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VERROT.TextBoxAutoComplete = False
        Me.txt_VERROT.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VERROT.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VERROT.TextEnabled = False
        Me.txt_VERROT.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VERROT.TextMaxLength = 32767
        Me.txt_VERROT.TextMultiLine = False
        Me.txt_VERROT.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VERROT.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VERROT.UseSendTab = True
        '
        'txt_VerCBD
        '
        Me.txt_VerCBD.BackYesno = False
        Me.txt_VerCBD.ButtonTitle = Nothing
        Me.txt_VerCBD.Code = Nothing
        Me.txt_VerCBD.Data = ""
        Me.txt_VerCBD.DataDecimal = 0
        Me.txt_VerCBD.DataLen = 0
        Me.txt_VerCBD.DataValue = 0
        Me.txt_VerCBD.FormatDecimal = 0
        Me.txt_VerCBD.FormatValue = False
        Me.txt_VerCBD.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VerCBD.LableEnabled = True
        Me.txt_VerCBD.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerCBD.LableForeColor = System.Drawing.Color.Empty
        Me.txt_VerCBD.LableTitle = "CBD Ver"
        Me.txt_VerCBD.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_VerCBD.Location = New System.Drawing.Point(438, 32)
        Me.txt_VerCBD.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_VerCBD.Name = "txt_VerCBD"
        Me.txt_VerCBD.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VerCBD.Size = New System.Drawing.Size(150, 22)
        Me.txt_VerCBD.TabIndex = 18
        Me.txt_VerCBD.TabStop = False
        Me.txt_VerCBD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VerCBD.TextBoxAutoComplete = False
        Me.txt_VerCBD.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VerCBD.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerCBD.TextEnabled = False
        Me.txt_VerCBD.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VerCBD.TextMaxLength = 32767
        Me.txt_VerCBD.TextMultiLine = False
        Me.txt_VerCBD.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VerCBD.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VerCBD.UseSendTab = True
        '
        'txt_VerBOM
        '
        Me.txt_VerBOM.BackYesno = False
        Me.txt_VerBOM.ButtonTitle = Nothing
        Me.txt_VerBOM.Code = Nothing
        Me.txt_VerBOM.Data = ""
        Me.txt_VerBOM.DataDecimal = 0
        Me.txt_VerBOM.DataLen = 0
        Me.txt_VerBOM.DataValue = 0
        Me.txt_VerBOM.FormatDecimal = 0
        Me.txt_VerBOM.FormatValue = False
        Me.txt_VerBOM.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VerBOM.LableEnabled = True
        Me.txt_VerBOM.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerBOM.LableForeColor = System.Drawing.Color.Empty
        Me.txt_VerBOM.LableTitle = "BOM Ver"
        Me.txt_VerBOM.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_VerBOM.Location = New System.Drawing.Point(438, 3)
        Me.txt_VerBOM.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_VerBOM.Name = "txt_VerBOM"
        Me.txt_VerBOM.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VerBOM.Size = New System.Drawing.Size(150, 22)
        Me.txt_VerBOM.TabIndex = 17
        Me.txt_VerBOM.TabStop = False
        Me.txt_VerBOM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VerBOM.TextBoxAutoComplete = False
        Me.txt_VerBOM.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VerBOM.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerBOM.TextEnabled = False
        Me.txt_VerBOM.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VerBOM.TextMaxLength = 32767
        Me.txt_VerBOM.TextMultiLine = False
        Me.txt_VerBOM.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VerBOM.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VerBOM.UseSendTab = True
        '
        'chk_Job
        '
        Me.chk_Job.AutoSize = True
        Me.chk_Job.Location = New System.Drawing.Point(317, 95)
        Me.chk_Job.Name = "chk_Job"
        Me.chk_Job.Size = New System.Drawing.Size(15, 14)
        Me.chk_Job.TabIndex = 56
        Me.chk_Job.UseVisualStyleBackColor = True
        '
        'chk_CBD
        '
        Me.chk_CBD.AutoSize = True
        Me.chk_CBD.Location = New System.Drawing.Point(317, 38)
        Me.chk_CBD.Name = "chk_CBD"
        Me.chk_CBD.Size = New System.Drawing.Size(15, 14)
        Me.chk_CBD.TabIndex = 56
        Me.chk_CBD.UseVisualStyleBackColor = True
        '
        'cmd_JOB
        '
        Me.cmd_JOB.BackYesno = False
        Me.cmd_JOB.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_JOB.ButtonEnabled = True
        Me.cmd_JOB.ButtonFont = Nothing
        Me.cmd_JOB.ButtonForeColor = System.Drawing.Color.Empty
        Me.cmd_JOB.ButtonName = ""
        Me.cmd_JOB.ButtonTitle = "CMT Process"
        Me.cmd_JOB.Code = ""
        Me.cmd_JOB.Data = ""
        Me.cmd_JOB.DataDecimal = 0
        Me.cmd_JOB.DataLen = 0
        Me.cmd_JOB.DataValue = 0
        Me.cmd_JOB.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmd_JOB.Location = New System.Drawing.Point(336, 90)
        Me.cmd_JOB.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_JOB.Name = "cmd_JOB"
        Me.cmd_JOB.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.cmd_JOB.Size = New System.Drawing.Size(100, 22)
        Me.cmd_JOB.TabIndex = 24
        Me.cmd_JOB.TabStop = False
        Me.cmd_JOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmd_JOB.TextBoxAutoComplete = False
        Me.cmd_JOB.TextboxBackColor = System.Drawing.Color.Empty
        Me.cmd_JOB.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_JOB.TextEnabled = True
        Me.cmd_JOB.TextForeColor = System.Drawing.Color.Empty
        Me.cmd_JOB.TextMaxLength = 32767
        Me.cmd_JOB.TextMultiLine = False
        Me.cmd_JOB.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cmd_JOB.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_JOB.UseSendTab = True
        '
        'chk_Process
        '
        Me.chk_Process.AutoSize = True
        Me.chk_Process.Location = New System.Drawing.Point(317, 65)
        Me.chk_Process.Name = "chk_Process"
        Me.chk_Process.Size = New System.Drawing.Size(15, 14)
        Me.chk_Process.TabIndex = 55
        Me.chk_Process.UseVisualStyleBackColor = True
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
        Me.txt_SizeRange.DataValue = 1
        Me.txt_SizeRange.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_SizeRange.Location = New System.Drawing.Point(7, 378)
        Me.txt_SizeRange.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeRange.Name = "txt_SizeRange"
        Me.txt_SizeRange.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeRange.Size = New System.Drawing.Size(300, 24)
        Me.txt_SizeRange.TabIndex = 13
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
        Me.txt_SizeRange.Visible = False
        '
        'chk_CheckParent
        '
        Me.chk_CheckParent.AutoSize = True
        Me.chk_CheckParent.Location = New System.Drawing.Point(9, 461)
        Me.chk_CheckParent.Name = "chk_CheckParent"
        Me.chk_CheckParent.Size = New System.Drawing.Size(80, 17)
        Me.chk_CheckParent.TabIndex = 55
        Me.chk_CheckParent.Text = "Check Item"
        Me.chk_CheckParent.UseVisualStyleBackColor = True
        '
        'cmd_Process
        '
        Me.cmd_Process.BackYesno = False
        Me.cmd_Process.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_Process.ButtonEnabled = True
        Me.cmd_Process.ButtonFont = Nothing
        Me.cmd_Process.ButtonForeColor = System.Drawing.Color.Empty
        Me.cmd_Process.ButtonName = ""
        Me.cmd_Process.ButtonTitle = "Routing Process"
        Me.cmd_Process.Code = ""
        Me.cmd_Process.Data = ""
        Me.cmd_Process.DataDecimal = 0
        Me.cmd_Process.DataLen = 0
        Me.cmd_Process.DataValue = 0
        Me.cmd_Process.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmd_Process.Location = New System.Drawing.Point(336, 61)
        Me.cmd_Process.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_Process.Name = "cmd_Process"
        Me.cmd_Process.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.cmd_Process.Size = New System.Drawing.Size(100, 22)
        Me.cmd_Process.TabIndex = 23
        Me.cmd_Process.TabStop = False
        Me.cmd_Process.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmd_Process.TextBoxAutoComplete = False
        Me.cmd_Process.TextboxBackColor = System.Drawing.Color.Empty
        Me.cmd_Process.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Process.TextEnabled = True
        Me.cmd_Process.TextForeColor = System.Drawing.Color.Empty
        Me.cmd_Process.TextMaxLength = 32767
        Me.cmd_Process.TextMultiLine = False
        Me.cmd_Process.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cmd_Process.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_Process.UseSendTab = True
        '
        'txt_CBDProcess
        '
        Me.txt_CBDProcess.BackYesno = False
        Me.txt_CBDProcess.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CBDProcess.ButtonEnabled = True
        Me.txt_CBDProcess.ButtonFont = Nothing
        Me.txt_CBDProcess.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CBDProcess.ButtonName = ""
        Me.txt_CBDProcess.ButtonTitle = "CBD Process"
        Me.txt_CBDProcess.Code = ""
        Me.txt_CBDProcess.Data = ""
        Me.txt_CBDProcess.DataDecimal = 0
        Me.txt_CBDProcess.DataLen = 0
        Me.txt_CBDProcess.DataValue = 0
        Me.txt_CBDProcess.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_CBDProcess.Location = New System.Drawing.Point(336, 32)
        Me.txt_CBDProcess.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CBDProcess.Name = "txt_CBDProcess"
        Me.txt_CBDProcess.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CBDProcess.Size = New System.Drawing.Size(100, 22)
        Me.txt_CBDProcess.TabIndex = 22
        Me.txt_CBDProcess.TabStop = False
        Me.txt_CBDProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CBDProcess.TextBoxAutoComplete = False
        Me.txt_CBDProcess.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CBDProcess.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CBDProcess.TextEnabled = True
        Me.txt_CBDProcess.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CBDProcess.TextMaxLength = 32767
        Me.txt_CBDProcess.TextMultiLine = False
        Me.txt_CBDProcess.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CBDProcess.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CBDProcess.UseSendTab = True
        '
        'txt_ShoesParent
        '
        Me.txt_ShoesParent.BackYesno = False
        Me.txt_ShoesParent.ButtonTitle = Nothing
        Me.txt_ShoesParent.Code = Nothing
        Me.txt_ShoesParent.Data = ""
        Me.txt_ShoesParent.DataDecimal = 0
        Me.txt_ShoesParent.DataLen = 0
        Me.txt_ShoesParent.DataValue = 0
        Me.txt_ShoesParent.FormatDecimal = 0
        Me.txt_ShoesParent.FormatValue = False
        Me.txt_ShoesParent.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ShoesParent.LableEnabled = True
        Me.txt_ShoesParent.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ShoesParent.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesParent.LableTitle = "Item Parent"
        Me.txt_ShoesParent.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ShoesParent.Location = New System.Drawing.Point(7, 430)
        Me.txt_ShoesParent.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ShoesParent.Name = "txt_ShoesParent"
        Me.txt_ShoesParent.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ShoesParent.Size = New System.Drawing.Size(300, 24)
        Me.txt_ShoesParent.TabIndex = 15
        Me.txt_ShoesParent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ShoesParent.TextBoxAutoComplete = False
        Me.txt_ShoesParent.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ShoesParent.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ShoesParent.TextEnabled = True
        Me.txt_ShoesParent.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ShoesParent.TextMaxLength = 32767
        Me.txt_ShoesParent.TextMultiLine = False
        Me.txt_ShoesParent.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ShoesParent.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ShoesParent.UseSendTab = True
        '
        'txt_cdSpecState
        '
        Me.txt_cdSpecState.BackYesno = False
        Me.txt_cdSpecState.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSpecState.ButtonEnabled = True
        Me.txt_cdSpecState.ButtonFont = Nothing
        Me.txt_cdSpecState.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.ButtonName = ""
        Me.txt_cdSpecState.ButtonTitle = "Dev Stage"
        Me.txt_cdSpecState.Code = ""
        Me.txt_cdSpecState.Data = ""
        Me.txt_cdSpecState.DataDecimal = 0
        Me.txt_cdSpecState.DataLen = 0
        Me.txt_cdSpecState.DataValue = 1
        Me.txt_cdSpecState.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSpecState.Location = New System.Drawing.Point(7, 55)
        Me.txt_cdSpecState.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSpecState.Name = "txt_cdSpecState"
        Me.txt_cdSpecState.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSpecState.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdSpecState.TabIndex = 2
        Me.txt_cdSpecState.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSpecState.TextBoxAutoComplete = False
        Me.txt_cdSpecState.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSpecState.TextEnabled = True
        Me.txt_cdSpecState.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSpecState.TextMaxLength = 32767
        Me.txt_cdSpecState.TextMultiLine = False
        Me.txt_cdSpecState.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSpecState.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSpecState.UseSendTab = True
        '
        'chk_Group
        '
        Me.chk_Group.AutoSize = True
        Me.chk_Group.Location = New System.Drawing.Point(317, 10)
        Me.chk_Group.Name = "chk_Group"
        Me.chk_Group.Size = New System.Drawing.Size(15, 14)
        Me.chk_Group.TabIndex = 54
        Me.chk_Group.UseVisualStyleBackColor = True
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = Nothing
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = ""
        Me.txt_CustomerCode.ButtonTitle = "Buyer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 0
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(7, 29)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(300, 24)
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
        'txt_CustSpecNo
        '
        Me.txt_CustSpecNo.BackYesno = False
        Me.txt_CustSpecNo.ButtonTitle = Nothing
        Me.txt_CustSpecNo.Code = Nothing
        Me.txt_CustSpecNo.Data = ""
        Me.txt_CustSpecNo.DataDecimal = 0
        Me.txt_CustSpecNo.DataLen = 0
        Me.txt_CustSpecNo.DataValue = 0
        Me.txt_CustSpecNo.FormatDecimal = 0
        Me.txt_CustSpecNo.FormatValue = False
        Me.txt_CustSpecNo.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_CustSpecNo.LableEnabled = True
        Me.txt_CustSpecNo.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CustSpecNo.LableForeColor = System.Drawing.Color.Empty
        Me.txt_CustSpecNo.LableTitle = "Cust SpecNo"
        Me.txt_CustSpecNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustSpecNo.Location = New System.Drawing.Point(6, 211)
        Me.txt_CustSpecNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustSpecNo.Name = "txt_CustSpecNo"
        Me.txt_CustSpecNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustSpecNo.Size = New System.Drawing.Size(300, 24)
        Me.txt_CustSpecNo.TabIndex = 7
        Me.txt_CustSpecNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustSpecNo.TextBoxAutoComplete = False
        Me.txt_CustSpecNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustSpecNo.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_CustSpecNo.TextEnabled = True
        Me.txt_CustSpecNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustSpecNo.TextMaxLength = 32767
        Me.txt_CustSpecNo.TextMultiLine = False
        Me.txt_CustSpecNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustSpecNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustSpecNo.UseSendTab = True
        '
        'cmd_GC
        '
        Me.cmd_GC.BackYesno = False
        Me.cmd_GC.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_GC.ButtonEnabled = True
        Me.cmd_GC.ButtonFont = Nothing
        Me.cmd_GC.ButtonForeColor = System.Drawing.Color.Empty
        Me.cmd_GC.ButtonName = ""
        Me.cmd_GC.ButtonTitle = "BOM Process"
        Me.cmd_GC.Code = ""
        Me.cmd_GC.Data = ""
        Me.cmd_GC.DataDecimal = 0
        Me.cmd_GC.DataLen = 0
        Me.cmd_GC.DataValue = 0
        Me.cmd_GC.Layoutpercent = New Decimal(New Integer() {1, 0, 0, 0})
        Me.cmd_GC.Location = New System.Drawing.Point(336, 3)
        Me.cmd_GC.Margin = New System.Windows.Forms.Padding(1)
        Me.cmd_GC.Name = "cmd_GC"
        Me.cmd_GC.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.cmd_GC.Size = New System.Drawing.Size(100, 22)
        Me.cmd_GC.TabIndex = 21
        Me.cmd_GC.TabStop = False
        Me.cmd_GC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.cmd_GC.TextBoxAutoComplete = False
        Me.cmd_GC.TextboxBackColor = System.Drawing.Color.Empty
        Me.cmd_GC.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_GC.TextEnabled = True
        Me.cmd_GC.TextForeColor = System.Drawing.Color.Empty
        Me.cmd_GC.TextMaxLength = 32767
        Me.cmd_GC.TextMultiLine = False
        Me.cmd_GC.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.cmd_GC.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.cmd_GC.UseSendTab = True
        '
        'txt_cdSeason
        '
        Me.txt_cdSeason.BackYesno = False
        Me.txt_cdSeason.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSeason.ButtonEnabled = True
        Me.txt_cdSeason.ButtonFont = Nothing
        Me.txt_cdSeason.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.ButtonName = ""
        Me.txt_cdSeason.ButtonTitle = "Season"
        Me.txt_cdSeason.Code = ""
        Me.txt_cdSeason.Data = "test"
        Me.txt_cdSeason.DataDecimal = 0
        Me.txt_cdSeason.DataLen = 0
        Me.txt_cdSeason.DataValue = 0
        Me.txt_cdSeason.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSeason.Location = New System.Drawing.Point(317, 177)
        Me.txt_cdSeason.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSeason.Name = "txt_cdSeason"
        Me.txt_cdSeason.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSeason.Size = New System.Drawing.Size(300, 22)
        Me.txt_cdSeason.TabIndex = 2
        Me.txt_cdSeason.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSeason.TextBoxAutoComplete = False
        Me.txt_cdSeason.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSeason.TextEnabled = True
        Me.txt_cdSeason.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSeason.TextMaxLength = 32767
        Me.txt_cdSeason.TextMultiLine = False
        Me.txt_cdSeason.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSeason.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSeason.UseSendTab = True
        Me.txt_cdSeason.Visible = False
        '
        'txt_Style
        '
        Me.txt_Style.BackYesno = False
        Me.txt_Style.ButtonTitle = Nothing
        Me.txt_Style.Code = Nothing
        Me.txt_Style.Data = ""
        Me.txt_Style.DataDecimal = 0
        Me.txt_Style.DataLen = 0
        Me.txt_Style.DataValue = 0
        Me.txt_Style.FormatDecimal = 0
        Me.txt_Style.FormatValue = False
        Me.txt_Style.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Style.LableEnabled = True
        Me.txt_Style.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Style.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Style.LableTitle = "Style/SKU#"
        Me.txt_Style.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Style.Location = New System.Drawing.Point(6, 237)
        Me.txt_Style.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Style.Name = "txt_Style"
        Me.txt_Style.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Style.Size = New System.Drawing.Size(300, 24)
        Me.txt_Style.TabIndex = 8
        Me.txt_Style.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Style.TextBoxAutoComplete = False
        Me.txt_Style.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Style.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Style.TextEnabled = True
        Me.txt_Style.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Style.TextMaxLength = 32767
        Me.txt_Style.TextMultiLine = False
        Me.txt_Style.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Style.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Style.UseSendTab = True
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = Nothing
        Me.txt_Article.Code = Nothing
        Me.txt_Article.Data = ""
        Me.txt_Article.DataDecimal = 0
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 1
        Me.txt_Article.FormatDecimal = 0
        Me.txt_Article.FormatValue = False
        Me.txt_Article.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Article.LableEnabled = True
        Me.txt_Article.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Article.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Article.LableTitle = "Spec#/Article"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Article.Location = New System.Drawing.Point(6, 159)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(300, 24)
        Me.txt_Article.TabIndex = 6
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Article.TextEnabled = True
        Me.txt_Article.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Article.TextMaxLength = 32767
        Me.txt_Article.TextMultiLine = False
        Me.txt_Article.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Article.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Article.UseSendTab = True
        '
        'txt_MCODE
        '
        Me.txt_MCODE.BackYesno = False
        Me.txt_MCODE.ButtonTitle = Nothing
        Me.txt_MCODE.Code = Nothing
        Me.txt_MCODE.Data = ""
        Me.txt_MCODE.DataDecimal = 0
        Me.txt_MCODE.DataLen = 0
        Me.txt_MCODE.DataValue = 0
        Me.txt_MCODE.FormatDecimal = 0
        Me.txt_MCODE.FormatValue = False
        Me.txt_MCODE.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_MCODE.LableEnabled = True
        Me.txt_MCODE.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MCODE.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MCODE.LableTitle = "Material Code"
        Me.txt_MCODE.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MCODE.Location = New System.Drawing.Point(6, 315)
        Me.txt_MCODE.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MCODE.Name = "txt_MCODE"
        Me.txt_MCODE.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MCODE.Size = New System.Drawing.Size(300, 24)
        Me.txt_MCODE.TabIndex = 11
        Me.txt_MCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MCODE.TextBoxAutoComplete = False
        Me.txt_MCODE.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MCODE.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MCODE.TextEnabled = True
        Me.txt_MCODE.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MCODE.TextMaxLength = 32767
        Me.txt_MCODE.TextMultiLine = False
        Me.txt_MCODE.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MCODE.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MCODE.UseSendTab = True
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
        Me.txt_MCODEName.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_MCODEName.Location = New System.Drawing.Point(6, 263)
        Me.txt_MCODEName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MCODEName.Name = "txt_MCODEName"
        Me.txt_MCODEName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MCODEName.Size = New System.Drawing.Size(300, 24)
        Me.txt_MCODEName.TabIndex = 9
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
        Me.txt_ColorName.Location = New System.Drawing.Point(6, 289)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(300, 24)
        Me.txt_ColorName.TabIndex = 10
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
        'txt_ColorCode
        '
        Me.txt_ColorCode.BackYesno = False
        Me.txt_ColorCode.ButtonTitle = Nothing
        Me.txt_ColorCode.Code = Nothing
        Me.txt_ColorCode.Data = "1/0"
        Me.txt_ColorCode.DataDecimal = 0
        Me.txt_ColorCode.DataLen = 0
        Me.txt_ColorCode.DataValue = 0
        Me.txt_ColorCode.FormatDecimal = 0
        Me.txt_ColorCode.FormatValue = False
        Me.txt_ColorCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_ColorCode.LableEnabled = True
        Me.txt_ColorCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.LableTitle = "VER"
        Me.txt_ColorCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_ColorCode.Location = New System.Drawing.Point(7, 341)
        Me.txt_ColorCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorCode.Name = "txt_ColorCode"
        Me.txt_ColorCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorCode.Size = New System.Drawing.Size(300, 24)
        Me.txt_ColorCode.TabIndex = 12
        Me.txt_ColorCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorCode.TextBoxAutoComplete = False
        Me.txt_ColorCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ColorCode.TextEnabled = True
        Me.txt_ColorCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorCode.TextMaxLength = 32767
        Me.txt_ColorCode.TextMultiLine = False
        Me.txt_ColorCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorCode.UseSendTab = True
        '
        'txt_cdGender
        '
        Me.txt_cdGender.BackYesno = False
        Me.txt_cdGender.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdGender.ButtonEnabled = True
        Me.txt_cdGender.ButtonFont = Nothing
        Me.txt_cdGender.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdGender.ButtonName = "Const_CustomerDivision"
        Me.txt_cdGender.ButtonTitle = "Gender"
        Me.txt_cdGender.Code = ""
        Me.txt_cdGender.Data = ""
        Me.txt_cdGender.DataDecimal = 0
        Me.txt_cdGender.DataLen = 0
        Me.txt_cdGender.DataValue = 0
        Me.txt_cdGender.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdGender.Location = New System.Drawing.Point(7, 133)
        Me.txt_cdGender.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdGender.Name = "txt_cdGender"
        Me.txt_cdGender.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdGender.Size = New System.Drawing.Size(300, 24)
        Me.txt_cdGender.TabIndex = 5
        Me.txt_cdGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdGender.TextBoxAutoComplete = False
        Me.txt_cdGender.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdGender.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdGender.TextEnabled = True
        Me.txt_cdGender.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdGender.TextMaxLength = 32767
        Me.txt_cdGender.TextMultiLine = False
        Me.txt_cdGender.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdGender.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdGender.UseSendTab = True
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
        Me.tit_Use.Location = New System.Drawing.Point(6, 404)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(99, 24)
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
        Me.Panel5.Location = New System.Drawing.Point(107, 404)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(200, 24)
        Me.Panel5.TabIndex = 14
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.ButtonTitle = Nothing
        Me.rad_CheckUse2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(100, 1)
        Me.rad_CheckUse2.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(99, 22)
        Me.rad_CheckUse2.TabIndex = 1
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.ButtonTitle = Nothing
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(1, 1)
        Me.rad_CheckUse1.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(98, 22)
        Me.rad_CheckUse1.TabIndex = 0
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'Cms_1
        '
        Me.Cms_1.Name = "Cms_1"
        Me.Cms_1.Size = New System.Drawing.Size(61, 4)
        '
        'txt_Line
        '
        Me.txt_Line.BackYesno = False
        Me.txt_Line.ButtonTitle = Nothing
        Me.txt_Line.Code = Nothing
        Me.txt_Line.Data = ""
        Me.txt_Line.DataDecimal = 0
        Me.txt_Line.DataLen = 0
        Me.txt_Line.DataValue = 1
        Me.txt_Line.FormatDecimal = 0
        Me.txt_Line.FormatValue = False
        Me.txt_Line.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Line.LableEnabled = True
        Me.txt_Line.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Line.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Line.LableTitle = "Line/Style Name"
        Me.txt_Line.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Line.Location = New System.Drawing.Point(6, 185)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(300, 24)
        Me.txt_Line.TabIndex = 62
        Me.txt_Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Line.TextBoxAutoComplete = False
        Me.txt_Line.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Line.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Line.TextEnabled = True
        Me.txt_Line.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Line.TextMaxLength = 32767
        Me.txt_Line.TextMultiLine = False
        Me.txt_Line.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Line.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Line.UseSendTab = True
        Me.txt_Line.Visible = False
        '
        'ISUD7106A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(599, 561)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.Name = "ISUD7106A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITEM CODE PROCESSING (ISUD7106A)"
        Me.Controls.SetChildIndex(Me.frm_Condition, 0)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        CType(Me.Block2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block2.ResumeLayout(False)
        Me.Block2.PerformLayout()
        CType(Me.txt_PriceUSD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS0_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_Remark.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents txt_ShoesCode As PSMGlobal.SelectLabelText
    Friend WithEvents Block2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_Style As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MCODE As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MCODEName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ColorCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdGender As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSeason As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_CustSpecNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ProductCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdSpecState As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents cmd_JOB As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents cmd_Process As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents cmd_GC As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents chk_Job As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Process As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Group As System.Windows.Forms.CheckBox
    Friend WithEvents chk_CBD As System.Windows.Forms.CheckBox
    Friend WithEvents txt_CBDProcess As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_ShoesParent As PSMGlobal.SelectLabelText
    Friend WithEvents chk_CheckParent As System.Windows.Forms.CheckBox
    Friend WithEvents txt_SizeRange As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_VerJob As PSMGlobal.SelectLabelText
    Friend WithEvents txt_VERROT As PSMGlobal.SelectLabelText
    Friend WithEvents txt_VerCBD As PSMGlobal.SelectLabelText
    Friend WithEvents txt_VerBOM As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdProductSize As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdProductType As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Remark As PSMGlobal.PeaceMemo
    Friend WithEvents txt_VerSAM As PSMGlobal.SelectLabelText
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Public WithEvents vS0 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS0_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Cms_1 As PSMGlobal.PeaceContextMenuStrip
    Friend WithEvents chk_CopyAll As System.Windows.Forms.CheckBox
    Friend WithEvents txt_InchargeDesigner As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_TargetPrice As PSMGlobal.PeaceLabel
    Friend WithEvents txt_PriceUSD As PSMGlobal.PeaceNumericupdown
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText

End Class
