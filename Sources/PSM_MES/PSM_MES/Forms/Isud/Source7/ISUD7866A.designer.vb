<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7866A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7866A))
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
        Dim Vs1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim TextCellType5 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Print = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Download = New PSMGlobal.PeaceButton(Me.components)
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.FlowLayoutPanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_Solution = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_Data = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckStatus3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckStatus2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckStatus1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckStatus5 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckStatus4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_DateFinish = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_DateStart = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_BugExplain = New PSMGlobal.PeaceTextbox_New(Me.components)
        Me.txt_BugContent = New PSMGlobal.PeaceTextbox_New(Me.components)
        Me.txt_BugName = New PSMGlobal.SelectLabelText()
        Me.txt_DateAccept = New PSMGlobal.SelectPeaceCalSin()
        Me.lbl_CheckComplete = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_CheckComplete2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_CheckComplete1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_BugCode_001 = New PSMGlobal.SelectLabelText()
        Me.txt_InchargeConfirm = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_InchargeAccept = New PSMGlobal.SelectPeaceHLPButton()
        Me.lbl_CheckBugType = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckBugType2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckBugType1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_cdModule = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDepartment = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdProject = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_BugCode = New PSMGlobal.SelectLabelText()
        Me.txt_BugFunction = New PSMGlobal.SelectLabelText()
        Me.lbl_Status = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_DateConfirm = New PSMGlobal.SelectPeaceCalSin()
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FlowLayoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.cmd_OK.Location = New System.Drawing.Point(771, 2)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(125, 20)
        Me.cmd_OK.TabIndex = 1
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "Save(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
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
        Me.cmd_DEL.Location = New System.Drawing.Point(4, 2)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(125, 20)
        Me.cmd_DEL.TabIndex = 0
        Me.cmd_DEL.TabStop = False
        Me.cmd_DEL.Text = "Delete(&D)"
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(900, 2)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(125, 20)
        Me.cmd_Cancel.TabIndex = 2
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Text = "Close(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.Frame4, 2)
        Me.Frame4.Controls.Add(Me.cmd_Print)
        Me.Frame4.Controls.Add(Me.cmd_Download)
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 631)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1030, 25)
        Me.Frame4.TabIndex = 1
        Me.Frame4.Tag = ""
        '
        'cmd_Print
        '
        Me.cmd_Print.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Print.Appearance.Options.UseFont = True
        Me.cmd_Print.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Print.ButtonTitle = Nothing
        Me.cmd_Print.Code = Nothing
        Me.cmd_Print.Data = Nothing
        Me.cmd_Print.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.cmd_Print.ImageAlign = 16
        Me.cmd_Print.Location = New System.Drawing.Point(316, 2)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(125, 20)
        Me.cmd_Print.TabIndex = 8
        Me.cmd_Print.Text = "Print(&P)"
        Me.cmd_Print.UseVisualStyleBackColor = False
        '
        'cmd_Download
        '
        Me.cmd_Download.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Download.Appearance.Options.UseFont = True
        Me.cmd_Download.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Download.ButtonTitle = Nothing
        Me.cmd_Download.Code = Nothing
        Me.cmd_Download.Data = Nothing
        Me.cmd_Download.Image = CType(resources.GetObject("cmd_Download.Image"), System.Drawing.Image)
        Me.cmd_Download.ImageAlign = 16
        Me.cmd_Download.Location = New System.Drawing.Point(444, 2)
        Me.cmd_Download.Name = "cmd_Download"
        Me.cmd_Download.Size = New System.Drawing.Size(125, 20)
        Me.cmd_Download.TabIndex = 3
        Me.cmd_Download.Text = "Download(&D)"
        Me.cmd_Download.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.Code = ""
        Me.Frame1.Controls.Add(Me.TableLayoutPanel1)
        Me.Frame1.Data = ""
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 0)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(1040, 663)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Vs1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Frame4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(2, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 374.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1036, 659)
        Me.TableLayoutPanel1.TabIndex = 102
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = ""
        Me.Vs1.AllowDragFill = True
        Me.Vs1.AutoClipboard = False
        Me.Vs1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
        Me.TableLayoutPanel1.SetColumnSpan(Me.Vs1, 2)
        Me.Vs1.CopyPasteChk = False
        Me.Vs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vs1.FocusRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer(1)
        Me.Vs1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.Vs1.HorizontalScrollBar.TabIndex = 10
        Me.Vs1.InsChk = False
        Me.Vs1.Location = New System.Drawing.Point(3, 377)
        Me.Vs1.Name = "Vs1"
        NamedStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle1.Border = BevelBorder1
        NamedStyle1.CanFocus = False
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
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(1030, 248)
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
        Me.Vs1.Skin = SpreadSkin1
        Me.Vs1.SpreadWjob = 0
        Me.Vs1.TabIndex = 2
        Me.Vs1.TabStop = False
        Me.Vs1.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs1.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs1.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.Vs1.VerticalScrollBar.TabIndex = 11
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Back, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(Global.Microsoft.VisualBasic.ChrW(61)), FarPoint.Win.Spread.SpreadActions.StartEditingFormula)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.C, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.V, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.X, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCopy)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Delete, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardCut)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Insert, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ClipboardPasteAll)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectRow)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Z, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Undo)
        Vs1_InputMapWhenFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Y, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.Redo)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenFocusedNormal)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StartEditing)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextRow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Left, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Right, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextColumnVisual)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToNextPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfRows)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.PageUp, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToPreviousPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Next], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToNextPageOfColumns)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToFirstColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToLastColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToFirstCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToLastCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Home, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToFirstCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[End], CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ExtendToLastCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectColumn)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Space, CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.SelectSheet)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Escape, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.CancelEditing)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.StopEditing)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Tab, CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.MoveToPreviousColumnWrap)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F2, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ClearCell)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F3, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.DateTimeNow)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.F4, System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.ShowSubEditor)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Down, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.Up, CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.None), System.Windows.Forms.Keys)), FarPoint.Win.Spread.SpreadActions.ComboShowList)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenAncestorOfFocusedNormal)
        '
        'Vs1_Sheet1
        '
        Me.Vs1_Sheet1.Reset()
        Me.Vs1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        TextCellType5.WordWrap = True
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.DefaultStyle.Parent = "Style5"
        Me.Vs1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.GrayAreaBackColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.CellType = TextCellType5
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Renderer = TextCellType5
        Me.Vs1_Sheet1.Rows.Default.Height = 22.0!
        Me.Vs1_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.Vs1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.Vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel2.Code = ""
        Me.TableLayoutPanel1.SetColumnSpan(Me.FlowLayoutPanel2, 2)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_DateConfirm)
        Me.FlowLayoutPanel2.Controls.Add(Me.TableLayoutPanel5)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_Status)
        Me.FlowLayoutPanel2.Controls.Add(Me.TableLayoutPanel4)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_DateFinish)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_DateStart)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_BugExplain)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_BugContent)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_BugName)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_DateAccept)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_CheckComplete)
        Me.FlowLayoutPanel2.Controls.Add(Me.TableLayoutPanel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_BugCode_001)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_InchargeConfirm)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_InchargeAccept)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_CheckBugType)
        Me.FlowLayoutPanel2.Controls.Add(Me.TableLayoutPanel2)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdModule)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdDepartment)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_cdProject)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_BugCode)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_BugFunction)
        Me.FlowLayoutPanel2.Data = ""
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1030, 368)
        Me.FlowLayoutPanel2.TabIndex = 1
        Me.FlowLayoutPanel2.Tag = ""
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.rad_Solution, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.rad_Data, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(4, 342)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(228, 23)
        Me.TableLayoutPanel5.TabIndex = 112
        Me.TableLayoutPanel5.Visible = False
        '
        'rad_Solution
        '
        Me.rad_Solution.AutoSize = True
        Me.rad_Solution.ButtonTitle = Nothing
        Me.rad_Solution.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_Solution.Location = New System.Drawing.Point(114, 1)
        Me.rad_Solution.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_Solution.Name = "rad_Solution"
        Me.rad_Solution.Size = New System.Drawing.Size(71, 19)
        Me.rad_Solution.TabIndex = 1
        Me.rad_Solution.Text = "Solution"
        Me.rad_Solution.UseVisualStyleBackColor = True
        '
        'rad_Data
        '
        Me.rad_Data.AutoSize = True
        Me.rad_Data.ButtonTitle = Nothing
        Me.rad_Data.Checked = True
        Me.rad_Data.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_Data.Location = New System.Drawing.Point(1, 1)
        Me.rad_Data.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_Data.Name = "rad_Data"
        Me.rad_Data.Size = New System.Drawing.Size(51, 19)
        Me.rad_Data.TabIndex = 0
        Me.rad_Data.TabStop = True
        Me.rad_Data.Text = "Data"
        Me.rad_Data.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel4.ColumnCount = 5
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.rad_CheckStatus3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rad_CheckStatus2, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rad_CheckStatus1, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rad_CheckStatus5, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.rad_CheckStatus4, 3, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(797, 77)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(228, 23)
        Me.TableLayoutPanel4.TabIndex = 18
        '
        'rad_CheckStatus3
        '
        Me.rad_CheckStatus3.AutoSize = True
        Me.rad_CheckStatus3.ButtonTitle = Nothing
        Me.rad_CheckStatus3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckStatus3.Location = New System.Drawing.Point(91, 1)
        Me.rad_CheckStatus3.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckStatus3.Name = "rad_CheckStatus3"
        Me.rad_CheckStatus3.Size = New System.Drawing.Size(40, 19)
        Me.rad_CheckStatus3.TabIndex = 4
        Me.rad_CheckStatus3.Text = "AP"
        Me.rad_CheckStatus3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad_CheckStatus3.UseVisualStyleBackColor = True
        '
        'rad_CheckStatus2
        '
        Me.rad_CheckStatus2.AutoSize = True
        Me.rad_CheckStatus2.ButtonTitle = Nothing
        Me.rad_CheckStatus2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckStatus2.Location = New System.Drawing.Point(46, 1)
        Me.rad_CheckStatus2.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckStatus2.Name = "rad_CheckStatus2"
        Me.rad_CheckStatus2.Size = New System.Drawing.Size(38, 19)
        Me.rad_CheckStatus2.TabIndex = 3
        Me.rad_CheckStatus2.Text = "PE"
        Me.rad_CheckStatus2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad_CheckStatus2.UseVisualStyleBackColor = True
        '
        'rad_CheckStatus1
        '
        Me.rad_CheckStatus1.AutoSize = True
        Me.rad_CheckStatus1.ButtonTitle = Nothing
        Me.rad_CheckStatus1.Checked = True
        Me.rad_CheckStatus1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckStatus1.Location = New System.Drawing.Point(1, 1)
        Me.rad_CheckStatus1.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckStatus1.Name = "rad_CheckStatus1"
        Me.rad_CheckStatus1.Size = New System.Drawing.Size(42, 19)
        Me.rad_CheckStatus1.TabIndex = 2
        Me.rad_CheckStatus1.TabStop = True
        Me.rad_CheckStatus1.Text = "NA"
        Me.rad_CheckStatus1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad_CheckStatus1.UseVisualStyleBackColor = True
        '
        'rad_CheckStatus5
        '
        Me.rad_CheckStatus5.AutoSize = True
        Me.rad_CheckStatus5.ButtonTitle = Nothing
        Me.rad_CheckStatus5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckStatus5.Location = New System.Drawing.Point(181, 1)
        Me.rad_CheckStatus5.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckStatus5.Name = "rad_CheckStatus5"
        Me.rad_CheckStatus5.Size = New System.Drawing.Size(39, 19)
        Me.rad_CheckStatus5.TabIndex = 1
        Me.rad_CheckStatus5.Text = "CP"
        Me.rad_CheckStatus5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad_CheckStatus5.UseVisualStyleBackColor = True
        '
        'rad_CheckStatus4
        '
        Me.rad_CheckStatus4.AutoSize = True
        Me.rad_CheckStatus4.ButtonTitle = Nothing
        Me.rad_CheckStatus4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckStatus4.Location = New System.Drawing.Point(136, 1)
        Me.rad_CheckStatus4.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckStatus4.Name = "rad_CheckStatus4"
        Me.rad_CheckStatus4.Size = New System.Drawing.Size(40, 19)
        Me.rad_CheckStatus4.TabIndex = 0
        Me.rad_CheckStatus4.Text = "CA"
        Me.rad_CheckStatus4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rad_CheckStatus4.UseVisualStyleBackColor = True
        '
        'txt_DateFinish
        '
        Me.txt_DateFinish.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateFinish.ButtonEnabled = True
        Me.txt_DateFinish.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_DateFinish.ButtonName = Nothing
        Me.txt_DateFinish.ButtonTitle = "Date Finish"
        Me.txt_DateFinish.Code = ""
        Me.txt_DateFinish.Data = "20150101"
        Me.txt_DateFinish.DataDecimal = 0
        Me.txt_DateFinish.DataLen = 0
        Me.txt_DateFinish.DataValue = 0
        Me.txt_DateFinish.FormatDecimal = 0
        Me.txt_DateFinish.FormatValue = False
        Me.txt_DateFinish.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateFinish.Location = New System.Drawing.Point(856, 103)
        Me.txt_DateFinish.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DateFinish.Name = "txt_DateFinish"
        Me.txt_DateFinish.Size = New System.Drawing.Size(170, 23)
        Me.txt_DateFinish.TabIndex = 15
        Me.txt_DateFinish.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateFinish.TextBoxAutoComplete = False
        Me.txt_DateFinish.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateFinish.TextEnabled = True
        Me.txt_DateFinish.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateFinish.TextMaxLength = 32767
        Me.txt_DateFinish.TextMultiLine = True
        Me.txt_DateFinish.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_DateStart
        '
        Me.txt_DateStart.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateStart.ButtonEnabled = True
        Me.txt_DateStart.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_DateStart.ButtonName = Nothing
        Me.txt_DateStart.ButtonTitle = "Date Start"
        Me.txt_DateStart.Code = ""
        Me.txt_DateStart.Data = "20150101"
        Me.txt_DateStart.DataDecimal = 0
        Me.txt_DateStart.DataLen = 0
        Me.txt_DateStart.DataValue = 0
        Me.txt_DateStart.FormatDecimal = 0
        Me.txt_DateStart.FormatValue = False
        Me.txt_DateStart.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateStart.Location = New System.Drawing.Point(677, 103)
        Me.txt_DateStart.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DateStart.Name = "txt_DateStart"
        Me.txt_DateStart.Size = New System.Drawing.Size(178, 23)
        Me.txt_DateStart.TabIndex = 14
        Me.txt_DateStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateStart.TextBoxAutoComplete = False
        Me.txt_DateStart.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateStart.TextEnabled = True
        Me.txt_DateStart.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateStart.TextMaxLength = 32767
        Me.txt_DateStart.TextMultiLine = True
        Me.txt_DateStart.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_BugExplain
        '
        Me.txt_BugExplain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BugExplain.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_BugExplain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BugExplain.Code = Nothing
        Me.txt_BugExplain.Data = Nothing
        Me.txt_BugExplain.DTDec = 0
        Me.txt_BugExplain.DTLen = 0
        Me.txt_BugExplain.DTValue = 0
        Me.txt_BugExplain.Location = New System.Drawing.Point(4, 234)
        Me.txt_BugExplain.MaxLength = 0
        Me.txt_BugExplain.Multiline = True
        Me.txt_BugExplain.Name = "txt_BugExplain"
        Me.txt_BugExplain.NoClear = False
        Me.txt_BugExplain.Size = New System.Drawing.Size(1020, 102)
        Me.txt_BugExplain.TabIndex = 13
        '
        'txt_BugContent
        '
        Me.txt_BugContent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_BugContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_BugContent.Code = Nothing
        Me.txt_BugContent.Data = Nothing
        Me.txt_BugContent.DTDec = 0
        Me.txt_BugContent.DTLen = 0
        Me.txt_BugContent.DTValue = 0
        Me.txt_BugContent.Location = New System.Drawing.Point(5, 131)
        Me.txt_BugContent.MaxLength = 0
        Me.txt_BugContent.Multiline = True
        Me.txt_BugContent.Name = "txt_BugContent"
        Me.txt_BugContent.NoClear = False
        Me.txt_BugContent.Size = New System.Drawing.Size(1020, 97)
        Me.txt_BugContent.TabIndex = 12
        '
        'txt_BugName
        '
        Me.txt_BugName.BackYesno = False
        Me.txt_BugName.ButtonTitle = Nothing
        Me.txt_BugName.Code = Nothing
        Me.txt_BugName.Data = ""
        Me.txt_BugName.DataDecimal = 0
        Me.txt_BugName.DataLen = 0
        Me.txt_BugName.DataValue = 0
        Me.txt_BugName.FormatDecimal = 0
        Me.txt_BugName.FormatValue = False
        Me.txt_BugName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_BugName.LableEnabled = True
        Me.txt_BugName.LableFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_BugName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_BugName.LableTitle = "Name"
        Me.txt_BugName.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_BugName.Location = New System.Drawing.Point(335, 54)
        Me.txt_BugName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_BugName.Name = "txt_BugName"
        Me.txt_BugName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BugName.Size = New System.Drawing.Size(332, 23)
        Me.txt_BugName.TabIndex = 11
        Me.txt_BugName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BugName.TextBoxAutoComplete = False
        Me.txt_BugName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_BugName.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_BugName.TextEnabled = True
        Me.txt_BugName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_BugName.TextMaxLength = 32767
        Me.txt_BugName.TextMultiLine = False
        Me.txt_BugName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BugName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BugName.UseSendTab = True
        '
        'txt_DateAccept
        '
        Me.txt_DateAccept.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateAccept.ButtonEnabled = True
        Me.txt_DateAccept.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_DateAccept.ButtonName = Nothing
        Me.txt_DateAccept.ButtonTitle = "Date Accept"
        Me.txt_DateAccept.Code = ""
        Me.txt_DateAccept.Data = "20150101"
        Me.txt_DateAccept.DataDecimal = 0
        Me.txt_DateAccept.DataLen = 0
        Me.txt_DateAccept.DataValue = 0
        Me.txt_DateAccept.FormatDecimal = 0
        Me.txt_DateAccept.FormatValue = False
        Me.txt_DateAccept.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateAccept.Location = New System.Drawing.Point(6, 104)
        Me.txt_DateAccept.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DateAccept.Name = "txt_DateAccept"
        Me.txt_DateAccept.Size = New System.Drawing.Size(322, 23)
        Me.txt_DateAccept.TabIndex = 9
        Me.txt_DateAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateAccept.TextBoxAutoComplete = False
        Me.txt_DateAccept.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateAccept.TextEnabled = True
        Me.txt_DateAccept.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateAccept.TextMaxLength = 32767
        Me.txt_DateAccept.TextMultiLine = True
        Me.txt_DateAccept.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'lbl_CheckComplete
        '
        Me.lbl_CheckComplete.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_CheckComplete.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_CheckComplete.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_CheckComplete.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_CheckComplete.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_CheckComplete.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_CheckComplete.ButtonTitle = Nothing
        Me.lbl_CheckComplete.Code = ""
        Me.lbl_CheckComplete.Data = ""
        Me.lbl_CheckComplete.DTDec = 0
        Me.lbl_CheckComplete.DTLen = 0
        Me.lbl_CheckComplete.DTValue = 0
        Me.lbl_CheckComplete.Location = New System.Drawing.Point(676, 28)
        Me.lbl_CheckComplete.Margin = New System.Windows.Forms.Padding(1)
        Me.lbl_CheckComplete.Name = "lbl_CheckComplete"
        Me.lbl_CheckComplete.NoClear = False
        Me.lbl_CheckComplete.Size = New System.Drawing.Size(119, 23)
        Me.lbl_CheckComplete.TabIndex = 10
        Me.lbl_CheckComplete.Tag = ""
        Me.lbl_CheckComplete.Text = "Status"
        Me.lbl_CheckComplete.TextAlign = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_CheckComplete.Visible = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.chk_CheckComplete2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.chk_CheckComplete1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(797, 28)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(228, 23)
        Me.TableLayoutPanel3.TabIndex = 10
        Me.TableLayoutPanel3.Visible = False
        '
        'chk_CheckComplete2
        '
        Me.chk_CheckComplete2.AutoSize = True
        Me.chk_CheckComplete2.ButtonTitle = Nothing
        Me.chk_CheckComplete2.Checked = True
        Me.chk_CheckComplete2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckComplete2.Location = New System.Drawing.Point(114, 1)
        Me.chk_CheckComplete2.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_CheckComplete2.Name = "chk_CheckComplete2"
        Me.chk_CheckComplete2.Size = New System.Drawing.Size(103, 19)
        Me.chk_CheckComplete2.TabIndex = 1
        Me.chk_CheckComplete2.TabStop = True
        Me.chk_CheckComplete2.Text = "Not Complete"
        Me.chk_CheckComplete2.UseVisualStyleBackColor = True
        '
        'chk_CheckComplete1
        '
        Me.chk_CheckComplete1.AutoSize = True
        Me.chk_CheckComplete1.ButtonTitle = Nothing
        Me.chk_CheckComplete1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_CheckComplete1.Location = New System.Drawing.Point(1, 1)
        Me.chk_CheckComplete1.Margin = New System.Windows.Forms.Padding(0)
        Me.chk_CheckComplete1.Name = "chk_CheckComplete1"
        Me.chk_CheckComplete1.Size = New System.Drawing.Size(79, 19)
        Me.chk_CheckComplete1.TabIndex = 0
        Me.chk_CheckComplete1.Text = "Complete"
        Me.chk_CheckComplete1.UseVisualStyleBackColor = True
        '
        'txt_BugCode_001
        '
        Me.txt_BugCode_001.BackYesno = False
        Me.txt_BugCode_001.ButtonTitle = Nothing
        Me.txt_BugCode_001.Code = Nothing
        Me.txt_BugCode_001.Data = ""
        Me.txt_BugCode_001.DataDecimal = 0
        Me.txt_BugCode_001.DataLen = 0
        Me.txt_BugCode_001.DataValue = 0
        Me.txt_BugCode_001.FormatDecimal = 0
        Me.txt_BugCode_001.FormatValue = False
        Me.txt_BugCode_001.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_BugCode_001.LableEnabled = True
        Me.txt_BugCode_001.LableFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_BugCode_001.LableForeColor = System.Drawing.Color.Empty
        Me.txt_BugCode_001.LableTitle = "Bug Code"
        Me.txt_BugCode_001.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_BugCode_001.Location = New System.Drawing.Point(335, 3)
        Me.txt_BugCode_001.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_BugCode_001.Name = "txt_BugCode_001"
        Me.txt_BugCode_001.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BugCode_001.Size = New System.Drawing.Size(332, 23)
        Me.txt_BugCode_001.TabIndex = 5
        Me.txt_BugCode_001.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BugCode_001.TextBoxAutoComplete = False
        Me.txt_BugCode_001.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_BugCode_001.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_BugCode_001.TextEnabled = True
        Me.txt_BugCode_001.TextForeColor = System.Drawing.Color.Empty
        Me.txt_BugCode_001.TextMaxLength = 32767
        Me.txt_BugCode_001.TextMultiLine = False
        Me.txt_BugCode_001.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BugCode_001.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BugCode_001.UseSendTab = True
        '
        'txt_InchargeConfirm
        '
        Me.txt_InchargeConfirm.BackYesno = False
        Me.txt_InchargeConfirm.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeConfirm.ButtonEnabled = True
        Me.txt_InchargeConfirm.ButtonFont = Nothing
        Me.txt_InchargeConfirm.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeConfirm.ButtonName = ""
        Me.txt_InchargeConfirm.ButtonTitle = "PIC Confirm"
        Me.txt_InchargeConfirm.Code = ""
        Me.txt_InchargeConfirm.Data = ""
        Me.txt_InchargeConfirm.DataDecimal = 0
        Me.txt_InchargeConfirm.DataLen = 0
        Me.txt_InchargeConfirm.DataValue = 0
        Me.txt_InchargeConfirm.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_InchargeConfirm.Location = New System.Drawing.Point(335, 78)
        Me.txt_InchargeConfirm.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeConfirm.Name = "txt_InchargeConfirm"
        Me.txt_InchargeConfirm.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeConfirm.Size = New System.Drawing.Size(332, 23)
        Me.txt_InchargeConfirm.TabIndex = 7
        Me.txt_InchargeConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeConfirm.TextBoxAutoComplete = True
        Me.txt_InchargeConfirm.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeConfirm.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_InchargeConfirm.TextEnabled = True
        Me.txt_InchargeConfirm.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeConfirm.TextMaxLength = 32767
        Me.txt_InchargeConfirm.TextMultiLine = False
        Me.txt_InchargeConfirm.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeConfirm.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeConfirm.UseSendTab = True
        '
        'txt_InchargeAccept
        '
        Me.txt_InchargeAccept.BackYesno = False
        Me.txt_InchargeAccept.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeAccept.ButtonEnabled = True
        Me.txt_InchargeAccept.ButtonFont = Nothing
        Me.txt_InchargeAccept.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.ButtonName = ""
        Me.txt_InchargeAccept.ButtonTitle = "PIC Accept"
        Me.txt_InchargeAccept.Code = ""
        Me.txt_InchargeAccept.Data = ""
        Me.txt_InchargeAccept.DataDecimal = 0
        Me.txt_InchargeAccept.DataLen = 0
        Me.txt_InchargeAccept.DataValue = 0
        Me.txt_InchargeAccept.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_InchargeAccept.Location = New System.Drawing.Point(6, 79)
        Me.txt_InchargeAccept.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeAccept.Name = "txt_InchargeAccept"
        Me.txt_InchargeAccept.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeAccept.Size = New System.Drawing.Size(322, 23)
        Me.txt_InchargeAccept.TabIndex = 6
        Me.txt_InchargeAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeAccept.TextBoxAutoComplete = True
        Me.txt_InchargeAccept.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_InchargeAccept.TextEnabled = True
        Me.txt_InchargeAccept.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.TextMaxLength = 32767
        Me.txt_InchargeAccept.TextMultiLine = False
        Me.txt_InchargeAccept.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeAccept.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeAccept.UseSendTab = True
        '
        'lbl_CheckBugType
        '
        Me.lbl_CheckBugType.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_CheckBugType.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_CheckBugType.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_CheckBugType.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_CheckBugType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_CheckBugType.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_CheckBugType.ButtonTitle = Nothing
        Me.lbl_CheckBugType.Code = ""
        Me.lbl_CheckBugType.Data = ""
        Me.lbl_CheckBugType.DTDec = 0
        Me.lbl_CheckBugType.DTLen = 0
        Me.lbl_CheckBugType.DTValue = 0
        Me.lbl_CheckBugType.Location = New System.Drawing.Point(676, 52)
        Me.lbl_CheckBugType.Margin = New System.Windows.Forms.Padding(1)
        Me.lbl_CheckBugType.Name = "lbl_CheckBugType"
        Me.lbl_CheckBugType.NoClear = False
        Me.lbl_CheckBugType.Size = New System.Drawing.Size(119, 23)
        Me.lbl_CheckBugType.TabIndex = 3
        Me.lbl_CheckBugType.Tag = ""
        Me.lbl_CheckBugType.Text = "Kind"
        Me.lbl_CheckBugType.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckBugType2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_CheckBugType1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(797, 52)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(228, 23)
        Me.TableLayoutPanel2.TabIndex = 8
        '
        'rad_CheckBugType2
        '
        Me.rad_CheckBugType2.AutoSize = True
        Me.rad_CheckBugType2.ButtonTitle = Nothing
        Me.rad_CheckBugType2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckBugType2.Location = New System.Drawing.Point(114, 1)
        Me.rad_CheckBugType2.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckBugType2.Name = "rad_CheckBugType2"
        Me.rad_CheckBugType2.Size = New System.Drawing.Size(51, 19)
        Me.rad_CheckBugType2.TabIndex = 1
        Me.rad_CheckBugType2.Text = "New"
        Me.rad_CheckBugType2.UseVisualStyleBackColor = True
        '
        'rad_CheckBugType1
        '
        Me.rad_CheckBugType1.AutoSize = True
        Me.rad_CheckBugType1.ButtonTitle = Nothing
        Me.rad_CheckBugType1.Checked = True
        Me.rad_CheckBugType1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckBugType1.Location = New System.Drawing.Point(1, 1)
        Me.rad_CheckBugType1.Margin = New System.Windows.Forms.Padding(0)
        Me.rad_CheckBugType1.Name = "rad_CheckBugType1"
        Me.rad_CheckBugType1.Size = New System.Drawing.Size(47, 19)
        Me.rad_CheckBugType1.TabIndex = 0
        Me.rad_CheckBugType1.TabStop = True
        Me.rad_CheckBugType1.Text = "Bug"
        Me.rad_CheckBugType1.UseVisualStyleBackColor = True
        '
        'txt_cdModule
        '
        Me.txt_cdModule.BackYesno = False
        Me.txt_cdModule.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdModule.ButtonEnabled = True
        Me.txt_cdModule.ButtonFont = Nothing
        Me.txt_cdModule.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdModule.ButtonName = ""
        Me.txt_cdModule.ButtonTitle = "Module"
        Me.txt_cdModule.Code = ""
        Me.txt_cdModule.Data = ""
        Me.txt_cdModule.DataDecimal = 0
        Me.txt_cdModule.DataLen = 0
        Me.txt_cdModule.DataValue = 0
        Me.txt_cdModule.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdModule.Location = New System.Drawing.Point(6, 54)
        Me.txt_cdModule.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdModule.Name = "txt_cdModule"
        Me.txt_cdModule.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdModule.Size = New System.Drawing.Size(322, 23)
        Me.txt_cdModule.TabIndex = 3
        Me.txt_cdModule.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdModule.TextBoxAutoComplete = True
        Me.txt_cdModule.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdModule.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cdModule.TextEnabled = True
        Me.txt_cdModule.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdModule.TextMaxLength = 32767
        Me.txt_cdModule.TextMultiLine = False
        Me.txt_cdModule.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdModule.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdModule.UseSendTab = True
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
        Me.txt_cdDepartment.DataValue = 0
        Me.txt_cdDepartment.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdDepartment.Location = New System.Drawing.Point(6, 28)
        Me.txt_cdDepartment.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDepartment.Name = "txt_cdDepartment"
        Me.txt_cdDepartment.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDepartment.Size = New System.Drawing.Size(322, 23)
        Me.txt_cdDepartment.TabIndex = 2
        Me.txt_cdDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDepartment.TextBoxAutoComplete = True
        Me.txt_cdDepartment.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cdDepartment.TextEnabled = True
        Me.txt_cdDepartment.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextMaxLength = 32767
        Me.txt_cdDepartment.TextMultiLine = False
        Me.txt_cdDepartment.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDepartment.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDepartment.UseSendTab = True
        '
        'txt_cdProject
        '
        Me.txt_cdProject.BackYesno = False
        Me.txt_cdProject.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdProject.ButtonEnabled = True
        Me.txt_cdProject.ButtonFont = Nothing
        Me.txt_cdProject.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdProject.ButtonName = "Project"
        Me.txt_cdProject.ButtonTitle = "Project"
        Me.txt_cdProject.Code = ""
        Me.txt_cdProject.Data = ""
        Me.txt_cdProject.DataDecimal = 0
        Me.txt_cdProject.DataLen = 0
        Me.txt_cdProject.DataValue = 0
        Me.txt_cdProject.Layoutpercent = New Decimal(New Integer() {345, 0, 0, 196608})
        Me.txt_cdProject.Location = New System.Drawing.Point(676, 3)
        Me.txt_cdProject.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdProject.Name = "txt_cdProject"
        Me.txt_cdProject.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdProject.Size = New System.Drawing.Size(349, 23)
        Me.txt_cdProject.TabIndex = 1
        Me.txt_cdProject.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdProject.TextBoxAutoComplete = True
        Me.txt_cdProject.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdProject.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_cdProject.TextEnabled = True
        Me.txt_cdProject.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdProject.TextMaxLength = 32767
        Me.txt_cdProject.TextMultiLine = False
        Me.txt_cdProject.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdProject.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdProject.UseSendTab = True
        '
        'txt_BugCode
        '
        Me.txt_BugCode.BackYesno = False
        Me.txt_BugCode.ButtonTitle = Nothing
        Me.txt_BugCode.Code = Nothing
        Me.txt_BugCode.Data = ""
        Me.txt_BugCode.DataDecimal = 0
        Me.txt_BugCode.DataLen = 0
        Me.txt_BugCode.DataValue = 0
        Me.txt_BugCode.FormatDecimal = 0
        Me.txt_BugCode.FormatValue = False
        Me.txt_BugCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_BugCode.LableEnabled = True
        Me.txt_BugCode.LableFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_BugCode.LableForeColor = System.Drawing.Color.Blue
        Me.txt_BugCode.LableTitle = "Process No"
        Me.txt_BugCode.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_BugCode.Location = New System.Drawing.Point(7, 3)
        Me.txt_BugCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_BugCode.Name = "txt_BugCode"
        Me.txt_BugCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BugCode.Size = New System.Drawing.Size(321, 23)
        Me.txt_BugCode.TabIndex = 0
        Me.txt_BugCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BugCode.TextBoxAutoComplete = False
        Me.txt_BugCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_BugCode.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_BugCode.TextEnabled = True
        Me.txt_BugCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_BugCode.TextMaxLength = 32767
        Me.txt_BugCode.TextMultiLine = False
        Me.txt_BugCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BugCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BugCode.UseSendTab = True
        '
        'txt_BugFunction
        '
        Me.txt_BugFunction.BackYesno = False
        Me.txt_BugFunction.ButtonTitle = Nothing
        Me.txt_BugFunction.Code = Nothing
        Me.txt_BugFunction.Data = ""
        Me.txt_BugFunction.DataDecimal = 0
        Me.txt_BugFunction.DataLen = 0
        Me.txt_BugFunction.DataValue = 0
        Me.txt_BugFunction.FormatDecimal = 0
        Me.txt_BugFunction.FormatValue = False
        Me.txt_BugFunction.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_BugFunction.LableEnabled = True
        Me.txt_BugFunction.LableFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_BugFunction.LableForeColor = System.Drawing.Color.Empty
        Me.txt_BugFunction.LableTitle = "Function"
        Me.txt_BugFunction.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_BugFunction.Location = New System.Drawing.Point(335, 28)
        Me.txt_BugFunction.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_BugFunction.Name = "txt_BugFunction"
        Me.txt_BugFunction.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BugFunction.Size = New System.Drawing.Size(332, 23)
        Me.txt_BugFunction.TabIndex = 4
        Me.txt_BugFunction.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BugFunction.TextBoxAutoComplete = False
        Me.txt_BugFunction.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_BugFunction.TextBoxFont = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_BugFunction.TextEnabled = True
        Me.txt_BugFunction.TextForeColor = System.Drawing.Color.Empty
        Me.txt_BugFunction.TextMaxLength = 32767
        Me.txt_BugFunction.TextMultiLine = False
        Me.txt_BugFunction.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BugFunction.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BugFunction.UseSendTab = True
        '
        'lbl_Status
        '
        Me.lbl_Status.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_Status.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_Status.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_Status.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_Status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_Status.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_Status.ButtonTitle = Nothing
        Me.lbl_Status.Code = ""
        Me.lbl_Status.Data = ""
        Me.lbl_Status.DTDec = 0
        Me.lbl_Status.DTLen = 0
        Me.lbl_Status.DTValue = 0
        Me.lbl_Status.Location = New System.Drawing.Point(676, 77)
        Me.lbl_Status.Margin = New System.Windows.Forms.Padding(1)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.NoClear = False
        Me.lbl_Status.Size = New System.Drawing.Size(119, 23)
        Me.lbl_Status.TabIndex = 17
        Me.lbl_Status.Tag = ""
        Me.lbl_Status.Text = "Status"
        Me.lbl_Status.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_DateConfirm
        '
        Me.txt_DateConfirm.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateConfirm.ButtonEnabled = True
        Me.txt_DateConfirm.ButtonFont = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txt_DateConfirm.ButtonName = Nothing
        Me.txt_DateConfirm.ButtonTitle = "Date Confirm"
        Me.txt_DateConfirm.Code = ""
        Me.txt_DateConfirm.Data = "20150101"
        Me.txt_DateConfirm.DataDecimal = 0
        Me.txt_DateConfirm.DataLen = 0
        Me.txt_DateConfirm.DataValue = 0
        Me.txt_DateConfirm.FormatDecimal = 0
        Me.txt_DateConfirm.FormatValue = False
        Me.txt_DateConfirm.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateConfirm.Location = New System.Drawing.Point(335, 103)
        Me.txt_DateConfirm.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.txt_DateConfirm.Name = "txt_DateConfirm"
        Me.txt_DateConfirm.Size = New System.Drawing.Size(332, 23)
        Me.txt_DateConfirm.TabIndex = 113
        Me.txt_DateConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateConfirm.TextBoxAutoComplete = False
        Me.txt_DateConfirm.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateConfirm.TextEnabled = True
        Me.txt_DateConfirm.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateConfirm.TextMaxLength = 32767
        Me.txt_DateConfirm.TextMultiLine = True
        Me.txt_DateConfirm.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'ISUD7866A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1040, 663)
        Me.Controls.Add(Me.Frame1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "ISUD7866A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROJECT BUG PROCESSING (ISUD7866A)"
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FlowLayoutPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_BugFunction As PSMGlobal.SelectLabelText
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_BugCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdProject As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents FlowLayoutPanel2 As PSMGlobal.PeacePanel
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_InchargeConfirm As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_InchargeAccept As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents lbl_CheckBugType As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckBugType2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckBugType1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_cdModule As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDepartment As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_BugCode_001 As PSMGlobal.SelectLabelText
    Friend WithEvents cmd_Download As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Print As PSMGlobal.PeaceButton
    Friend WithEvents lbl_CheckComplete As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chk_CheckComplete2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_CheckComplete1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_DateAccept As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_BugName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_BugExplain As PSMGlobal.PeaceTextbox_New
    Friend WithEvents txt_BugContent As PSMGlobal.PeaceTextbox_New
    Friend WithEvents txt_DateFinish As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_DateStart As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckStatus3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckStatus2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckStatus1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckStatus5 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckStatus4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents TableLayoutPanel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_Solution As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_Data As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_DateConfirm As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents lbl_Status As PSMGlobal.PeaceLabel
End Class
