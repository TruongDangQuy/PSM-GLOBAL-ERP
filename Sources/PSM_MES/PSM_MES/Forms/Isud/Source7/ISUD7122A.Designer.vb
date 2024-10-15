<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7122A
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
        Dim EnhancedFocusIndicatorRenderer1 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
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
        Dim EnhancedInterfaceRenderer1 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer2 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer3 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7122A))
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.vs1 = New PSMGlobal.PeaceFarpoint()
        Me.vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdLargeGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSemiGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDetailGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_SpecCode = New PSMGlobal.SelectLabelText()
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bloack2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.vs1)
        Me.frm_Condition.Controls.Add(Me.Frame4)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(841, 466)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'vs1
        '
        Me.vs1.CopyPasteChk = False
        Me.vs1.FocusRenderer = EnhancedFocusIndicatorRenderer1
        Me.vs1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vs1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vs1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.vs1.HorizontalScrollBar.TabIndex = 28
        Me.vs1.InsChk = False
        Me.vs1.Location = New System.Drawing.Point(325, 5)
        Me.vs1.Name = "vs1"
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
        Me.vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.vs1.ReportName = Nothing
        Me.vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vs1_Sheet1})
        Me.vs1.Size = New System.Drawing.Size(507, 409)
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
        Me.vs1.Skin = SpreadSkin1
        Me.vs1.SpreadWjob = 0
        Me.vs1.TabIndex = 3
        Me.vs1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.vs1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.vs1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.vs1.VerticalScrollBar.TabIndex = 29
        '
        'vs1_Sheet1
        '
        Me.vs1_Sheet1.Reset()
        Me.vs1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vs1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vs1_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        Me.vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vs1_Sheet1.DefaultStyle.Parent = "Style5"
        Me.vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vs1_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vs1_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_AttachID)
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Location = New System.Drawing.Point(3, 420)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(834, 41)
        Me.Frame4.TabIndex = 1
        Me.Frame4.Tag = ""
        '
        'cmd_AttachID
        '
        Me.cmd_AttachID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_AttachID.Appearance.Options.UseFont = True
        Me.cmd_AttachID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_AttachID.ButtonTitle = Nothing
        Me.cmd_AttachID.Code = Nothing
        Me.cmd_AttachID.Data = Nothing
        Me.cmd_AttachID.Image = CType(resources.GetObject("cmd_AttachID.Image"), System.Drawing.Image)
        Me.cmd_AttachID.ImageAlign = 16
        Me.cmd_AttachID.Location = New System.Drawing.Point(238, 4)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 2
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
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
        Me.cmd_DEL.Location = New System.Drawing.Point(5, 3)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 3
        Me.cmd_DEL.Text = "Delete (&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(688, 3)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "Close (&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(543, 3)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "Save (&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Code = ""
        Me.Bloack2.Controls.Add(Me.txt_cdLargeGroupMaterial)
        Me.Bloack2.Controls.Add(Me.txt_cdSemiGroupMaterial)
        Me.Bloack2.Controls.Add(Me.txt_cdDetailGroupMaterial)
        Me.Bloack2.Controls.Add(Me.txt_SpecCode)
        Me.Bloack2.Controls.Add(Me.tit_Use)
        Me.Bloack2.Controls.Add(Me.Panel5)
        Me.Bloack2.Data = ""
        Me.Bloack2.Location = New System.Drawing.Point(3, 5)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(316, 409)
        Me.Bloack2.TabIndex = 0
        Me.Bloack2.Tag = ""
        '
        'txt_cdLargeGroupMaterial
        '
        Me.txt_cdLargeGroupMaterial.BackYesno = False
        Me.txt_cdLargeGroupMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdLargeGroupMaterial.ButtonEnabled = True
        Me.txt_cdLargeGroupMaterial.ButtonFont = Nothing
        Me.txt_cdLargeGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.ButtonName = "Const_LargeGroupMaterial"
        Me.txt_cdLargeGroupMaterial.ButtonTitle = "Large Grouping"
        Me.txt_cdLargeGroupMaterial.Code = ""
        Me.txt_cdLargeGroupMaterial.Data = ""
        Me.txt_cdLargeGroupMaterial.DataDecimal = 0
        Me.txt_cdLargeGroupMaterial.DataLen = 0
        Me.txt_cdLargeGroupMaterial.DataValue = 1
        Me.txt_cdLargeGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLargeGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdLargeGroupMaterial.Location = New System.Drawing.Point(7, 34)
        Me.txt_cdLargeGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLargeGroupMaterial.Name = "txt_cdLargeGroupMaterial"
        Me.txt_cdLargeGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLargeGroupMaterial.Size = New System.Drawing.Size(302, 24)
        Me.txt_cdLargeGroupMaterial.TabIndex = 1
        Me.txt_cdLargeGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdLargeGroupMaterial.TextBoxAutoComplete = True
        Me.txt_cdLargeGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdLargeGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
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
        Me.txt_cdSemiGroupMaterial.ButtonFont = Nothing
        Me.txt_cdSemiGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.ButtonName = "Const_SemiGroupMaterial"
        Me.txt_cdSemiGroupMaterial.ButtonTitle = "Semi Grouping"
        Me.txt_cdSemiGroupMaterial.Code = ""
        Me.txt_cdSemiGroupMaterial.Data = ""
        Me.txt_cdSemiGroupMaterial.DataDecimal = 0
        Me.txt_cdSemiGroupMaterial.DataLen = 0
        Me.txt_cdSemiGroupMaterial.DataValue = 0
        Me.txt_cdSemiGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdSemiGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdSemiGroupMaterial.Location = New System.Drawing.Point(5, 60)
        Me.txt_cdSemiGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSemiGroupMaterial.Name = "txt_cdSemiGroupMaterial"
        Me.txt_cdSemiGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSemiGroupMaterial.Size = New System.Drawing.Size(304, 24)
        Me.txt_cdSemiGroupMaterial.TabIndex = 2
        Me.txt_cdSemiGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSemiGroupMaterial.TextBoxAutoComplete = True
        Me.txt_cdSemiGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSemiGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
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
        Me.txt_cdDetailGroupMaterial.ButtonFont = Nothing
        Me.txt_cdDetailGroupMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.ButtonName = "Const_DetailGroupMaterial"
        Me.txt_cdDetailGroupMaterial.ButtonTitle = "Detailed Grouping"
        Me.txt_cdDetailGroupMaterial.Code = ""
        Me.txt_cdDetailGroupMaterial.Data = ""
        Me.txt_cdDetailGroupMaterial.DataDecimal = 0
        Me.txt_cdDetailGroupMaterial.DataLen = 0
        Me.txt_cdDetailGroupMaterial.DataValue = 0
        Me.txt_cdDetailGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdDetailGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdDetailGroupMaterial.Location = New System.Drawing.Point(5, 86)
        Me.txt_cdDetailGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDetailGroupMaterial.Name = "txt_cdDetailGroupMaterial"
        Me.txt_cdDetailGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDetailGroupMaterial.Size = New System.Drawing.Size(304, 24)
        Me.txt_cdDetailGroupMaterial.TabIndex = 3
        Me.txt_cdDetailGroupMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDetailGroupMaterial.TextBoxAutoComplete = True
        Me.txt_cdDetailGroupMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdDetailGroupMaterial.TextEnabled = True
        Me.txt_cdDetailGroupMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDetailGroupMaterial.TextMaxLength = 32767
        Me.txt_cdDetailGroupMaterial.TextMultiLine = False
        Me.txt_cdDetailGroupMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDetailGroupMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDetailGroupMaterial.UseSendTab = True
        '
        'txt_SpecCode
        '
        Me.txt_SpecCode.BackYesno = False
        Me.txt_SpecCode.ButtonTitle = Nothing
        Me.txt_SpecCode.Code = Nothing
        Me.txt_SpecCode.Data = ""
        Me.txt_SpecCode.DataDecimal = 0
        Me.txt_SpecCode.DataLen = 0
        Me.txt_SpecCode.DataValue = 1
        Me.txt_SpecCode.Enabled = False
        Me.txt_SpecCode.FormatDecimal = 0
        Me.txt_SpecCode.FormatValue = False
        Me.txt_SpecCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_SpecCode.LableEnabled = True
        Me.txt_SpecCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SpecCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_SpecCode.LableTitle = "Spec Code"
        Me.txt_SpecCode.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_SpecCode.Location = New System.Drawing.Point(5, 5)
        Me.txt_SpecCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SpecCode.Name = "txt_SpecCode"
        Me.txt_SpecCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SpecCode.Size = New System.Drawing.Size(304, 24)
        Me.txt_SpecCode.TabIndex = 0
        Me.txt_SpecCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SpecCode.TextBoxAutoComplete = False
        Me.txt_SpecCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SpecCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_SpecCode.TextEnabled = True
        Me.txt_SpecCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SpecCode.TextMaxLength = 32767
        Me.txt_SpecCode.TextMultiLine = False
        Me.txt_SpecCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SpecCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SpecCode.UseSendTab = True
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
        Me.tit_Use.Location = New System.Drawing.Point(5, 112)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(124, 25)
        Me.tit_Use.TabIndex = 5
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
        Me.Panel5.Location = New System.Drawing.Point(131, 112)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(178, 25)
        Me.Panel5.TabIndex = 6
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.AutoSize = True
        Me.rad_CheckUse2.ButtonTitle = Nothing
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(92, 4)
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
        'ISUD7122A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(841, 466)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "ISUD7122A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SPEC CODE PROCESSING (ISUD7122A)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        CType(Me.vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bloack2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_SpecCode As PSMGlobal.SelectLabelText
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
    Friend WithEvents ColorDialog As System.Windows.Forms.ColorDialog
    Friend WithEvents txt_cdLargeGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSemiGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDetailGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Public WithEvents vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vs1_Sheet1 As FarPoint.Win.Spread.SheetView

End Class
