<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD3555A
    Inherits PeaceForm
    'Inherits PeaceForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD3555A))
        Dim EnhancedFocusIndicatorRenderer1 As FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer = New FarPoint.Win.Spread.EnhancedFocusIndicatorRenderer()
        Dim EnhancedScrollBarRenderer1 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim NamedStyle1 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("DataAreaDefault")
        Dim GeneralCellType1 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim NamedStyle2 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style2")
        Dim BevelBorder1 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType1 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle3 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style3")
        Dim BevelBorder2 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType2 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle4 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style1")
        Dim BevelBorder3 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType3 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle5 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style4")
        Dim BevelBorder4 As FarPoint.Win.BevelBorder = New FarPoint.Win.BevelBorder(FarPoint.Win.BevelBorderType.Lowered)
        Dim TextCellType4 As FarPoint.Win.Spread.CellType.TextCellType = New FarPoint.Win.Spread.CellType.TextCellType()
        Dim NamedStyle6 As FarPoint.Win.Spread.NamedStyle = New FarPoint.Win.Spread.NamedStyle("Style5")
        Dim GeneralCellType2 As FarPoint.Win.Spread.CellType.GeneralCellType = New FarPoint.Win.Spread.CellType.GeneralCellType()
        Dim SpreadSkin1 As FarPoint.Win.Spread.SpreadSkin = New FarPoint.Win.Spread.SpreadSkin()
        Dim EnhancedInterfaceRenderer1 As FarPoint.Win.Spread.EnhancedInterfaceRenderer = New FarPoint.Win.Spread.EnhancedInterfaceRenderer()
        Dim EnhancedScrollBarRenderer2 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim EnhancedScrollBarRenderer3 As FarPoint.Win.Spread.EnhancedScrollBarRenderer = New FarPoint.Win.Spread.EnhancedScrollBarRenderer()
        Dim Vs1_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs1_InputMapWhenAncestorOfFocusedSingleSelect As FarPoint.Win.Spread.InputMap
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_PRINT = New PSMGlobal.PeaceButton(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_DateAccept = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_InchargeAccept = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSite = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_TestOrder = New PSMGlobal.SelectLabelText()
        Me.txt_LABNo = New PSMGlobal.SelectLabelText()
        Me.panel = New PSMGlobal.PeacePanel(Me.components)
        Me.PeacePanel4 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_QtyTest = New PSMGlobal.SelectLabelText()
        Me.txt_QtyPass = New PSMGlobal.SelectLabelText()
        Me.txt_QtyFail = New PSMGlobal.SelectLabelText()
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_LABNo1 = New PSMGlobal.SelectLabelText()
        Me.txt_LABNoSeq = New PSMGlobal.SelectLabelText()
        Me.txt_TimeInspect = New PSMGlobal.SelectPeaceMaskText()
        Me.txt_InchargeInspect = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdDefect01 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDefect02 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDefect05 = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Remark = New PSMGlobal.SelectLabelText()
        Me.txt_cdDefect03 = New PSMGlobal.SelectPeaceHLPButton()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_TestStatus2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_TestStatus1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_cdDefect04 = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeaceLabel5 = New PSMGlobal.PeaceLabel(Me.components)
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect = New FarPoint.Win.Spread.InputMap()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        CType(Me.panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel.SuspendLayout()
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel4.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(965, 0)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_DEL.Code = ""
        Me.cmd_DEL.Data = ""
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 16
        Me.cmd_DEL.Location = New System.Drawing.Point(3, 0)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 3
        Me.cmd_DEL.TabStop = False
        Me.cmd_DEL.Tag = ""
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(1109, 0)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.TableLayoutPanel3.SetColumnSpan(Me.Frame4, 2)
        Me.Frame4.Controls.Add(Me.cmd_PRINT)
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 318)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1250, 36)
        Me.Frame4.TabIndex = 2
        Me.Frame4.Tag = ""
        '
        'cmd_PRINT
        '
        Me.cmd_PRINT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_PRINT.Appearance.Options.UseFont = True
        Me.cmd_PRINT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_PRINT.Code = ""
        Me.cmd_PRINT.Data = ""
        Me.cmd_PRINT.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.cmd_PRINT.ImageAlign = 16
        Me.cmd_PRINT.Location = New System.Drawing.Point(575, 0)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(152, 35)
        Me.cmd_PRINT.TabIndex = 2
        Me.cmd_PRINT.TabStop = False
        Me.cmd_PRINT.Tag = ""
        Me.cmd_PRINT.Text = "PRINT(&P)"
        Me.cmd_PRINT.UseVisualStyleBackColor = False
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 618.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Vs1, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.PeacePanel2, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.panel, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Frame4, 0, 2)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1256, 357)
        Me.TableLayoutPanel3.TabIndex = 23
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = "Vs2, Sheet1, Row 0, Column 0, "
        Me.Vs1.AllowEditorReservedLocations = False
        Me.Vs1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vs1.CopyPasteChk = True
        Me.Vs1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vs1.FocusRenderer = EnhancedFocusIndicatorRenderer1
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
        Me.Vs1.HorizontalScrollBar.TabIndex = 0
        Me.Vs1.InsChk = True
        Me.Vs1.Location = New System.Drawing.Point(0, 94)
        Me.Vs1.Margin = New System.Windows.Forms.Padding(0)
        Me.Vs1.Name = "Vs1"
        NamedStyle1.BackColor = System.Drawing.SystemColors.Window
        NamedStyle1.CellType = GeneralCellType1
        NamedStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle1.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle1.Renderer = GeneralCellType1
        NamedStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle2.Border = BevelBorder1
        NamedStyle2.CanFocus = False
        NamedStyle2.CellType = TextCellType1
        NamedStyle2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle2.ForeColor = System.Drawing.Color.White
        NamedStyle2.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle2.Locked = False
        NamedStyle2.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle2.Renderer = TextCellType1
        NamedStyle2.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle2.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle3.Border = BevelBorder2
        NamedStyle3.CellType = TextCellType2
        NamedStyle3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle3.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle3.Locked = False
        NamedStyle3.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle3.Renderer = TextCellType2
        NamedStyle3.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle4.Border = BevelBorder3
        NamedStyle4.CanFocus = False
        NamedStyle4.CellType = TextCellType3
        NamedStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NamedStyle4.ForeColor = System.Drawing.Color.White
        NamedStyle4.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle4.Locked = False
        NamedStyle4.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle4.Renderer = TextCellType3
        NamedStyle4.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle4.VisualStyles = FarPoint.Win.VisualStyles.Off
        NamedStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        NamedStyle5.Border = BevelBorder4
        NamedStyle5.CellType = TextCellType4
        NamedStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        NamedStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        NamedStyle5.HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center
        NamedStyle5.Locked = False
        NamedStyle5.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle5.Renderer = TextCellType4
        NamedStyle5.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        NamedStyle6.BackColor = System.Drawing.SystemColors.Window
        NamedStyle6.CellType = GeneralCellType2
        NamedStyle6.Font = New System.Drawing.Font("Tahoma", 9.0!)
        NamedStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        NamedStyle6.Locked = False
        NamedStyle6.NoteIndicatorColor = System.Drawing.Color.Red
        NamedStyle6.Renderer = GeneralCellType2
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5, NamedStyle6})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(618, 221)
        SpreadSkin1.ColumnFooterDefaultStyle = NamedStyle3
        SpreadSkin1.ColumnHeaderDefaultStyle = NamedStyle2
        SpreadSkin1.CornerDefaultStyle = NamedStyle5
        SpreadSkin1.DefaultStyle = NamedStyle6
        SpreadSkin1.FocusRenderer = EnhancedFocusIndicatorRenderer1
        EnhancedInterfaceRenderer1.ScrollBoxBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerActiveColor = System.Drawing.Color.FromArgb(CType(CType(183, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabLowerNormalColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperActiveColor = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(228, Byte), Integer), CType(CType(244, Byte), Integer))
        EnhancedInterfaceRenderer1.SheetTabUpperNormalColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(249, Byte), Integer))
        EnhancedInterfaceRenderer1.TabStripBackgroundColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(221, Byte), Integer))
        SpreadSkin1.InterfaceRenderer = EnhancedInterfaceRenderer1
        SpreadSkin1.Name = "Hung123"
        SpreadSkin1.RowHeaderDefaultStyle = NamedStyle4
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
        Me.Vs1.TabIndex = 25
        Me.Vs1.TabStop = False
        Me.Vs1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.Vs1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Vs1.VerticalScrollBar.TabIndex = 25
        Vs1_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenFocusedNormal)
        Vs1_InputMapWhenFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, Vs1_InputMapWhenFocusedSingleSelect)
        Vs1_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs1_InputMapWhenAncestorOfFocusedNormal)
        Vs1_InputMapWhenAncestorOfFocusedSingleSelect.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs1.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.SingleSelect, Vs1_InputMapWhenAncestorOfFocusedSingleSelect)
        '
        'Vs1_Sheet1
        '
        Me.Vs1_Sheet1.Reset()
        Me.Vs1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Vs1_Sheet1.ColumnCount = 29
        Me.Vs1_Sheet1.RowCount = 10
        Me.Vs1_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("SheetSkin1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
        Me.Vs1_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ColumnHeader.Rows.Get(0).Height = 25.0!
        Me.Vs1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.Vs1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.Vs1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.Vs1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.Vs1_Sheet1.GroupBarInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vs1_Sheet1.NullFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        Me.Vs1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Vs1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.Rows.Default.Height = 22.0!
        Me.Vs1_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.Vs1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.Vs1_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
        Me.Vs1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.Vs1_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Vs1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.Vs1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs1_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.Vs1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.Vs1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'PeacePanel2
        '
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Controls.Add(Me.txt_DateAccept)
        Me.PeacePanel2.Controls.Add(Me.txt_InchargeAccept)
        Me.PeacePanel2.Controls.Add(Me.txt_CustomerCode)
        Me.PeacePanel2.Controls.Add(Me.txt_cdSite)
        Me.PeacePanel2.Controls.Add(Me.txt_TestOrder)
        Me.PeacePanel2.Controls.Add(Me.txt_LABNo)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel2.Location = New System.Drawing.Point(3, 3)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(612, 88)
        Me.PeacePanel2.TabIndex = 24
        Me.PeacePanel2.Tag = ""
        Me.PeacePanel2.Visible = False
        '
        'txt_DateAccept
        '
        Me.txt_DateAccept.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateAccept.ButtonEnabled = False
        Me.txt_DateAccept.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateAccept.ButtonName = Nothing
        Me.txt_DateAccept.ButtonTitle = "Date Accept"
        Me.txt_DateAccept.Code = ""
        Me.txt_DateAccept.Data = "________"
        Me.txt_DateAccept.DataDecimal = 0
        Me.txt_DateAccept.DataLen = 0
        Me.txt_DateAccept.DataValue = 0
        Me.txt_DateAccept.FormatDecimal = 0
        Me.txt_DateAccept.FormatValue = False
        Me.txt_DateAccept.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_DateAccept.Location = New System.Drawing.Point(306, 58)
        Me.txt_DateAccept.Margin = New System.Windows.Forms.Padding(1, 1, 138, 1)
        Me.txt_DateAccept.Name = "txt_DateAccept"
        Me.txt_DateAccept.Size = New System.Drawing.Size(302, 25)
        Me.txt_DateAccept.TabIndex = 275
        Me.txt_DateAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateAccept.TextBoxAutoComplete = False
        Me.txt_DateAccept.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateAccept.TextEnabled = False
        Me.txt_DateAccept.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateAccept.TextMaxLength = 32767
        Me.txt_DateAccept.TextMultiLine = True
        Me.txt_DateAccept.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_InchargeAccept
        '
        Me.txt_InchargeAccept.BackYesno = False
        Me.txt_InchargeAccept.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeAccept.ButtonEnabled = False
        Me.txt_InchargeAccept.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeAccept.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.ButtonName = ""
        Me.txt_InchargeAccept.ButtonTitle = "Incharge"
        Me.txt_InchargeAccept.Code = ""
        Me.txt_InchargeAccept.Data = ""
        Me.txt_InchargeAccept.DataDecimal = 0
        Me.txt_InchargeAccept.DataLen = 0
        Me.txt_InchargeAccept.DataValue = 1
        Me.txt_InchargeAccept.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_InchargeAccept.Location = New System.Drawing.Point(3, 58)
        Me.txt_InchargeAccept.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_InchargeAccept.Name = "txt_InchargeAccept"
        Me.txt_InchargeAccept.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeAccept.Size = New System.Drawing.Size(302, 25)
        Me.txt_InchargeAccept.TabIndex = 274
        Me.txt_InchargeAccept.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeAccept.TextBoxAutoComplete = False
        Me.txt_InchargeAccept.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeAccept.TextEnabled = False
        Me.txt_InchargeAccept.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeAccept.TextMaxLength = 32767
        Me.txt_InchargeAccept.TextMultiLine = False
        Me.txt_InchargeAccept.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeAccept.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeAccept.UseSendTab = True
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = False
        Me.txt_CustomerCode.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = ""
        Me.txt_CustomerCode.ButtonTitle = "Customer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 1
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(306, 29)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(302, 25)
        Me.txt_CustomerCode.TabIndex = 272
        Me.txt_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerCode.TextBoxAutoComplete = False
        Me.txt_CustomerCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CustomerCode.TextEnabled = False
        Me.txt_CustomerCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextMaxLength = 32767
        Me.txt_CustomerCode.TextMultiLine = False
        Me.txt_CustomerCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_CustomerCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CustomerCode.UseSendTab = True
        '
        'txt_cdSite
        '
        Me.txt_cdSite.BackYesno = False
        Me.txt_cdSite.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdSite.ButtonEnabled = False
        Me.txt_cdSite.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSite.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.ButtonName = ""
        Me.txt_cdSite.ButtonTitle = "Site"
        Me.txt_cdSite.Code = ""
        Me.txt_cdSite.Data = ""
        Me.txt_cdSite.DataDecimal = 0
        Me.txt_cdSite.DataLen = 0
        Me.txt_cdSite.DataValue = 1
        Me.txt_cdSite.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdSite.Location = New System.Drawing.Point(306, 3)
        Me.txt_cdSite.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cdSite.Name = "txt_cdSite"
        Me.txt_cdSite.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSite.Size = New System.Drawing.Size(302, 25)
        Me.txt_cdSite.TabIndex = 271
        Me.txt_cdSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdSite.TextBoxAutoComplete = False
        Me.txt_cdSite.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdSite.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdSite.TextEnabled = False
        Me.txt_cdSite.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.TextMaxLength = 32767
        Me.txt_cdSite.TextMultiLine = False
        Me.txt_cdSite.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdSite.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdSite.UseSendTab = True
        '
        'txt_TestOrder
        '
        Me.txt_TestOrder.BackYesno = False
        Me.txt_TestOrder.ButtonTitle = Nothing
        Me.txt_TestOrder.Code = ""
        Me.txt_TestOrder.Data = ""
        Me.txt_TestOrder.DataDecimal = 0
        Me.txt_TestOrder.DataLen = 0
        Me.txt_TestOrder.DataValue = 0
        Me.txt_TestOrder.FormatDecimal = 0
        Me.txt_TestOrder.FormatValue = False
        Me.txt_TestOrder.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TestOrder.LableEnabled = True
        Me.txt_TestOrder.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TestOrder.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TestOrder.LableTitle = "Test Order"
        Me.txt_TestOrder.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_TestOrder.Location = New System.Drawing.Point(3, 32)
        Me.txt_TestOrder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TestOrder.Name = "txt_TestOrder"
        Me.txt_TestOrder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TestOrder.Size = New System.Drawing.Size(302, 25)
        Me.txt_TestOrder.TabIndex = 9
        Me.txt_TestOrder.TabStop = False
        Me.txt_TestOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TestOrder.TextBoxAutoComplete = False
        Me.txt_TestOrder.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TestOrder.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TestOrder.TextEnabled = False
        Me.txt_TestOrder.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TestOrder.TextMaxLength = 32767
        Me.txt_TestOrder.TextMultiLine = False
        Me.txt_TestOrder.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TestOrder.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TestOrder.UseSendTab = True
        '
        'txt_LABNo
        '
        Me.txt_LABNo.BackYesno = False
        Me.txt_LABNo.ButtonTitle = Nothing
        Me.txt_LABNo.Code = ""
        Me.txt_LABNo.Data = ""
        Me.txt_LABNo.DataDecimal = 0
        Me.txt_LABNo.DataLen = 0
        Me.txt_LABNo.DataValue = 0
        Me.txt_LABNo.FormatDecimal = 0
        Me.txt_LABNo.FormatValue = False
        Me.txt_LABNo.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_LABNo.LableEnabled = True
        Me.txt_LABNo.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LABNo.LableForeColor = System.Drawing.Color.Black
        Me.txt_LABNo.LableTitle = "LAB No"
        Me.txt_LABNo.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_LABNo.Location = New System.Drawing.Point(3, 5)
        Me.txt_LABNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LABNo.Name = "txt_LABNo"
        Me.txt_LABNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LABNo.Size = New System.Drawing.Size(302, 25)
        Me.txt_LABNo.TabIndex = 3
        Me.txt_LABNo.TabStop = False
        Me.txt_LABNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LABNo.TextBoxAutoComplete = False
        Me.txt_LABNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LABNo.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_LABNo.TextEnabled = False
        Me.txt_LABNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LABNo.TextMaxLength = 32767
        Me.txt_LABNo.TextMultiLine = False
        Me.txt_LABNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LABNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LABNo.UseSendTab = True
        '
        'panel
        '
        Me.panel.Code = ""
        Me.panel.Controls.Add(Me.PeacePanel4)
        Me.panel.Controls.Add(Me.PeacePanel3)
        Me.panel.Controls.Add(Me.PeacePanel1)
        Me.panel.Data = ""
        Me.panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel.Location = New System.Drawing.Point(621, 3)
        Me.panel.Name = "panel"
        Me.TableLayoutPanel3.SetRowSpan(Me.panel, 2)
        Me.panel.Size = New System.Drawing.Size(632, 309)
        Me.panel.TabIndex = 23
        Me.panel.Tag = ""
        Me.panel.Visible = False
        '
        'PeacePanel4
        '
        Me.PeacePanel4.Code = ""
        Me.PeacePanel4.Controls.Add(Me.txt_QtyTest)
        Me.PeacePanel4.Controls.Add(Me.txt_QtyPass)
        Me.PeacePanel4.Controls.Add(Me.txt_QtyFail)
        Me.PeacePanel4.Data = ""
        Me.PeacePanel4.Location = New System.Drawing.Point(316, 3)
        Me.PeacePanel4.Name = "PeacePanel4"
        Me.PeacePanel4.Size = New System.Drawing.Size(311, 87)
        Me.PeacePanel4.TabIndex = 289
        Me.PeacePanel4.Tag = ""
        Me.PeacePanel4.Visible = False
        '
        'txt_QtyTest
        '
        Me.txt_QtyTest.BackYesno = False
        Me.txt_QtyTest.ButtonTitle = Nothing
        Me.txt_QtyTest.Code = ""
        Me.txt_QtyTest.Data = ""
        Me.txt_QtyTest.DataDecimal = 0
        Me.txt_QtyTest.DataLen = 0
        Me.txt_QtyTest.DataValue = 0
        Me.txt_QtyTest.FormatDecimal = 0
        Me.txt_QtyTest.FormatValue = False
        Me.txt_QtyTest.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_QtyTest.LableEnabled = True
        Me.txt_QtyTest.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyTest.LableForeColor = System.Drawing.Color.Empty
        Me.txt_QtyTest.LableTitle = "Qty Test"
        Me.txt_QtyTest.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_QtyTest.Location = New System.Drawing.Point(3, 3)
        Me.txt_QtyTest.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyTest.Name = "txt_QtyTest"
        Me.txt_QtyTest.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyTest.Size = New System.Drawing.Size(302, 25)
        Me.txt_QtyTest.TabIndex = 279
        Me.txt_QtyTest.TabStop = False
        Me.txt_QtyTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_QtyTest.TextBoxAutoComplete = False
        Me.txt_QtyTest.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QtyTest.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_QtyTest.TextEnabled = False
        Me.txt_QtyTest.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QtyTest.TextMaxLength = 32767
        Me.txt_QtyTest.TextMultiLine = False
        Me.txt_QtyTest.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QtyTest.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QtyTest.UseSendTab = True
        '
        'txt_QtyPass
        '
        Me.txt_QtyPass.BackYesno = False
        Me.txt_QtyPass.ButtonTitle = Nothing
        Me.txt_QtyPass.Code = ""
        Me.txt_QtyPass.Data = ""
        Me.txt_QtyPass.DataDecimal = 0
        Me.txt_QtyPass.DataLen = 0
        Me.txt_QtyPass.DataValue = 0
        Me.txt_QtyPass.FormatDecimal = 0
        Me.txt_QtyPass.FormatValue = False
        Me.txt_QtyPass.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_QtyPass.LableEnabled = True
        Me.txt_QtyPass.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyPass.LableForeColor = System.Drawing.Color.Empty
        Me.txt_QtyPass.LableTitle = "Qty Pass"
        Me.txt_QtyPass.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_QtyPass.Location = New System.Drawing.Point(2, 30)
        Me.txt_QtyPass.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyPass.Name = "txt_QtyPass"
        Me.txt_QtyPass.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyPass.Size = New System.Drawing.Size(302, 25)
        Me.txt_QtyPass.TabIndex = 280
        Me.txt_QtyPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_QtyPass.TextBoxAutoComplete = False
        Me.txt_QtyPass.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QtyPass.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_QtyPass.TextEnabled = True
        Me.txt_QtyPass.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QtyPass.TextMaxLength = 32767
        Me.txt_QtyPass.TextMultiLine = False
        Me.txt_QtyPass.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QtyPass.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QtyPass.UseSendTab = True
        '
        'txt_QtyFail
        '
        Me.txt_QtyFail.BackYesno = False
        Me.txt_QtyFail.ButtonTitle = Nothing
        Me.txt_QtyFail.Code = ""
        Me.txt_QtyFail.Data = ""
        Me.txt_QtyFail.DataDecimal = 0
        Me.txt_QtyFail.DataLen = 0
        Me.txt_QtyFail.DataValue = 0
        Me.txt_QtyFail.FormatDecimal = 0
        Me.txt_QtyFail.FormatValue = False
        Me.txt_QtyFail.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_QtyFail.LableEnabled = True
        Me.txt_QtyFail.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyFail.LableForeColor = System.Drawing.Color.Empty
        Me.txt_QtyFail.LableTitle = "Qty Fail"
        Me.txt_QtyFail.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_QtyFail.Location = New System.Drawing.Point(3, 59)
        Me.txt_QtyFail.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyFail.Name = "txt_QtyFail"
        Me.txt_QtyFail.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyFail.Size = New System.Drawing.Size(302, 25)
        Me.txt_QtyFail.TabIndex = 281
        Me.txt_QtyFail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_QtyFail.TextBoxAutoComplete = False
        Me.txt_QtyFail.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QtyFail.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_QtyFail.TextEnabled = True
        Me.txt_QtyFail.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QtyFail.TextMaxLength = 32767
        Me.txt_QtyFail.TextMultiLine = False
        Me.txt_QtyFail.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QtyFail.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QtyFail.UseSendTab = True
        '
        'PeacePanel3
        '
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.txt_LABNo1)
        Me.PeacePanel3.Controls.Add(Me.txt_LABNoSeq)
        Me.PeacePanel3.Controls.Add(Me.txt_TimeInspect)
        Me.PeacePanel3.Controls.Add(Me.txt_InchargeInspect)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(5, 3)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(310, 86)
        Me.PeacePanel3.TabIndex = 289
        Me.PeacePanel3.Tag = ""
        Me.PeacePanel3.Visible = False
        '
        'txt_LABNo1
        '
        Me.txt_LABNo1.BackYesno = False
        Me.txt_LABNo1.ButtonTitle = Nothing
        Me.txt_LABNo1.Code = ""
        Me.txt_LABNo1.Data = ""
        Me.txt_LABNo1.DataDecimal = 0
        Me.txt_LABNo1.DataLen = 0
        Me.txt_LABNo1.DataValue = 0
        Me.txt_LABNo1.FormatDecimal = 0
        Me.txt_LABNo1.FormatValue = False
        Me.txt_LABNo1.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_LABNo1.LableEnabled = True
        Me.txt_LABNo1.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LABNo1.LableForeColor = System.Drawing.Color.Black
        Me.txt_LABNo1.LableTitle = "LAB No"
        Me.txt_LABNo1.Layoutpercent = New Decimal(New Integer() {435, 0, 0, 196608})
        Me.txt_LABNo1.Location = New System.Drawing.Point(3, 3)
        Me.txt_LABNo1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LABNo1.Name = "txt_LABNo1"
        Me.txt_LABNo1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LABNo1.Size = New System.Drawing.Size(230, 24)
        Me.txt_LABNo1.TabIndex = 269
        Me.txt_LABNo1.TabStop = False
        Me.txt_LABNo1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LABNo1.TextBoxAutoComplete = False
        Me.txt_LABNo1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LABNo1.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LABNo1.TextEnabled = False
        Me.txt_LABNo1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LABNo1.TextMaxLength = 32767
        Me.txt_LABNo1.TextMultiLine = False
        Me.txt_LABNo1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LABNo1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LABNo1.UseSendTab = True
        '
        'txt_LABNoSeq
        '
        Me.txt_LABNoSeq.BackYesno = False
        Me.txt_LABNoSeq.ButtonTitle = Nothing
        Me.txt_LABNoSeq.Code = ""
        Me.txt_LABNoSeq.Data = ""
        Me.txt_LABNoSeq.DataDecimal = 0
        Me.txt_LABNoSeq.DataLen = 0
        Me.txt_LABNoSeq.DataValue = 0
        Me.txt_LABNoSeq.FormatDecimal = 0
        Me.txt_LABNoSeq.FormatValue = False
        Me.txt_LABNoSeq.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_LABNoSeq.LableEnabled = True
        Me.txt_LABNoSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_LABNoSeq.LableForeColor = System.Drawing.Color.Black
        Me.txt_LABNoSeq.LableTitle = "LAB No"
        Me.txt_LABNoSeq.Layoutpercent = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_LABNoSeq.Location = New System.Drawing.Point(235, 3)
        Me.txt_LABNoSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LABNoSeq.Name = "txt_LABNoSeq"
        Me.txt_LABNoSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LABNoSeq.Size = New System.Drawing.Size(70, 24)
        Me.txt_LABNoSeq.TabIndex = 270
        Me.txt_LABNoSeq.TabStop = False
        Me.txt_LABNoSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LABNoSeq.TextBoxAutoComplete = False
        Me.txt_LABNoSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LABNoSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_LABNoSeq.TextEnabled = False
        Me.txt_LABNoSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LABNoSeq.TextMaxLength = 32767
        Me.txt_LABNoSeq.TextMultiLine = False
        Me.txt_LABNoSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LABNoSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LABNoSeq.UseSendTab = True
        '
        'txt_TimeInspect
        '
        Me.txt_TimeInspect.BackColor = System.Drawing.SystemColors.Control
        Me.txt_TimeInspect.ButtonBorderStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt_TimeInspect.ButtonEnabled = False
        Me.txt_TimeInspect.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_TimeInspect.ButtonForeColor = System.Drawing.Color.Black
        Me.txt_TimeInspect.ButtonTitle = "Time Inspect"
        Me.txt_TimeInspect.Code = ""
        Me.txt_TimeInspect.Data = "    /  /     :  :"
        Me.txt_TimeInspect.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TimeInspect.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_TimeInspect.Location = New System.Drawing.Point(3, 30)
        Me.txt_TimeInspect.Name = "txt_TimeInspect"
        Me.txt_TimeInspect.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TimeInspect.SetTextFocus = True
        Me.txt_TimeInspect.Size = New System.Drawing.Size(302, 29)
        Me.txt_TimeInspect.TabIndex = 277
        Me.txt_TimeInspect.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TimeInspect.TextBoxAutoComplete = False
        Me.txt_TimeInspect.TextBoxFont = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_TimeInspect.TextEnabled = False
        Me.txt_TimeInspect.TextForeColor = System.Drawing.Color.Black
        Me.txt_TimeInspect.TextMask = "####/##/## ##:##:##"
        Me.txt_TimeInspect.TextMaxLength = 32767
        Me.txt_TimeInspect.TextMultiLine = True
        Me.txt_TimeInspect.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TimeInspect.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TimeInspect.UseSendTab = True
        '
        'txt_InchargeInspect
        '
        Me.txt_InchargeInspect.BackYesno = False
        Me.txt_InchargeInspect.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeInspect.ButtonEnabled = False
        Me.txt_InchargeInspect.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeInspect.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeInspect.ButtonName = ""
        Me.txt_InchargeInspect.ButtonTitle = "Incharge"
        Me.txt_InchargeInspect.Code = ""
        Me.txt_InchargeInspect.Data = ""
        Me.txt_InchargeInspect.DataDecimal = 0
        Me.txt_InchargeInspect.DataLen = 0
        Me.txt_InchargeInspect.DataValue = 1
        Me.txt_InchargeInspect.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_InchargeInspect.Location = New System.Drawing.Point(3, 59)
        Me.txt_InchargeInspect.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_InchargeInspect.Name = "txt_InchargeInspect"
        Me.txt_InchargeInspect.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeInspect.Size = New System.Drawing.Size(302, 25)
        Me.txt_InchargeInspect.TabIndex = 278
        Me.txt_InchargeInspect.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeInspect.TextBoxAutoComplete = False
        Me.txt_InchargeInspect.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeInspect.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_InchargeInspect.TextEnabled = False
        Me.txt_InchargeInspect.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeInspect.TextMaxLength = 32767
        Me.txt_InchargeInspect.TextMultiLine = False
        Me.txt_InchargeInspect.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeInspect.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeInspect.UseSendTab = True
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.txt_cdDefect01)
        Me.PeacePanel1.Controls.Add(Me.txt_cdDefect02)
        Me.PeacePanel1.Controls.Add(Me.txt_cdDefect05)
        Me.PeacePanel1.Controls.Add(Me.txt_Remark)
        Me.PeacePanel1.Controls.Add(Me.txt_cdDefect03)
        Me.PeacePanel1.Controls.Add(Me.TableLayoutPanel2)
        Me.PeacePanel1.Controls.Add(Me.txt_cdDefect04)
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel5)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(5, 90)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(622, 214)
        Me.PeacePanel1.TabIndex = 288
        Me.PeacePanel1.Tag = ""
        Me.PeacePanel1.Visible = False
        '
        'txt_cdDefect01
        '
        Me.txt_cdDefect01.BackYesno = False
        Me.txt_cdDefect01.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDefect01.ButtonEnabled = True
        Me.txt_cdDefect01.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdDefect01.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect01.ButtonName = ""
        Me.txt_cdDefect01.ButtonTitle = "Defect 01"
        Me.txt_cdDefect01.Code = ""
        Me.txt_cdDefect01.Data = ""
        Me.txt_cdDefect01.DataDecimal = 0
        Me.txt_cdDefect01.DataLen = 0
        Me.txt_cdDefect01.DataValue = 1
        Me.txt_cdDefect01.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDefect01.Location = New System.Drawing.Point(3, 6)
        Me.txt_cdDefect01.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cdDefect01.Name = "txt_cdDefect01"
        Me.txt_cdDefect01.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDefect01.Size = New System.Drawing.Size(302, 25)
        Me.txt_cdDefect01.TabIndex = 282
        Me.txt_cdDefect01.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDefect01.TextBoxAutoComplete = False
        Me.txt_cdDefect01.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDefect01.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_cdDefect01.TextEnabled = True
        Me.txt_cdDefect01.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect01.TextMaxLength = 32767
        Me.txt_cdDefect01.TextMultiLine = False
        Me.txt_cdDefect01.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDefect01.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDefect01.UseSendTab = True
        '
        'txt_cdDefect02
        '
        Me.txt_cdDefect02.BackYesno = False
        Me.txt_cdDefect02.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDefect02.ButtonEnabled = True
        Me.txt_cdDefect02.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdDefect02.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect02.ButtonName = ""
        Me.txt_cdDefect02.ButtonTitle = "Defect 02"
        Me.txt_cdDefect02.Code = ""
        Me.txt_cdDefect02.Data = ""
        Me.txt_cdDefect02.DataDecimal = 0
        Me.txt_cdDefect02.DataLen = 0
        Me.txt_cdDefect02.DataValue = 1
        Me.txt_cdDefect02.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDefect02.Location = New System.Drawing.Point(3, 35)
        Me.txt_cdDefect02.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cdDefect02.Name = "txt_cdDefect02"
        Me.txt_cdDefect02.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDefect02.Size = New System.Drawing.Size(302, 25)
        Me.txt_cdDefect02.TabIndex = 283
        Me.txt_cdDefect02.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDefect02.TextBoxAutoComplete = False
        Me.txt_cdDefect02.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDefect02.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_cdDefect02.TextEnabled = True
        Me.txt_cdDefect02.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect02.TextMaxLength = 32767
        Me.txt_cdDefect02.TextMultiLine = False
        Me.txt_cdDefect02.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDefect02.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDefect02.UseSendTab = True
        '
        'txt_cdDefect05
        '
        Me.txt_cdDefect05.BackYesno = False
        Me.txt_cdDefect05.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDefect05.ButtonEnabled = True
        Me.txt_cdDefect05.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdDefect05.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect05.ButtonName = ""
        Me.txt_cdDefect05.ButtonTitle = "Defect 05"
        Me.txt_cdDefect05.Code = ""
        Me.txt_cdDefect05.Data = ""
        Me.txt_cdDefect05.DataDecimal = 0
        Me.txt_cdDefect05.DataLen = 0
        Me.txt_cdDefect05.DataValue = 1
        Me.txt_cdDefect05.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDefect05.Location = New System.Drawing.Point(314, 35)
        Me.txt_cdDefect05.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cdDefect05.Name = "txt_cdDefect05"
        Me.txt_cdDefect05.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDefect05.Size = New System.Drawing.Size(302, 26)
        Me.txt_cdDefect05.TabIndex = 286
        Me.txt_cdDefect05.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDefect05.TextBoxAutoComplete = False
        Me.txt_cdDefect05.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDefect05.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_cdDefect05.TextEnabled = True
        Me.txt_cdDefect05.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect05.TextMaxLength = 32767
        Me.txt_cdDefect05.TextMultiLine = False
        Me.txt_cdDefect05.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDefect05.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDefect05.UseSendTab = True
        '
        'txt_Remark
        '
        Me.txt_Remark.BackYesno = False
        Me.txt_Remark.ButtonTitle = Nothing
        Me.txt_Remark.Code = ""
        Me.txt_Remark.Data = ""
        Me.txt_Remark.DataDecimal = 0
        Me.txt_Remark.DataLen = 0
        Me.txt_Remark.DataValue = 0
        Me.txt_Remark.FormatDecimal = 0
        Me.txt_Remark.FormatValue = False
        Me.txt_Remark.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Remark.LableEnabled = True
        Me.txt_Remark.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.LableTitle = "Remark"
        Me.txt_Remark.Layoutpercent = New Decimal(New Integer() {165, 0, 0, 196608})
        Me.txt_Remark.Location = New System.Drawing.Point(3, 94)
        Me.txt_Remark.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Remark.Size = New System.Drawing.Size(613, 116)
        Me.txt_Remark.TabIndex = 287
        Me.txt_Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Remark.TextBoxAutoComplete = False
        Me.txt_Remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.TextEnabled = True
        Me.txt_Remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextMaxLength = 32767
        Me.txt_Remark.TextMultiLine = False
        Me.txt_Remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Remark.UseSendTab = True
        '
        'txt_cdDefect03
        '
        Me.txt_cdDefect03.BackYesno = False
        Me.txt_cdDefect03.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDefect03.ButtonEnabled = True
        Me.txt_cdDefect03.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdDefect03.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect03.ButtonName = ""
        Me.txt_cdDefect03.ButtonTitle = "Defect 03"
        Me.txt_cdDefect03.Code = ""
        Me.txt_cdDefect03.Data = ""
        Me.txt_cdDefect03.DataDecimal = 0
        Me.txt_cdDefect03.DataLen = 0
        Me.txt_cdDefect03.DataValue = 1
        Me.txt_cdDefect03.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDefect03.Location = New System.Drawing.Point(3, 64)
        Me.txt_cdDefect03.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cdDefect03.Name = "txt_cdDefect03"
        Me.txt_cdDefect03.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDefect03.Size = New System.Drawing.Size(302, 26)
        Me.txt_cdDefect03.TabIndex = 284
        Me.txt_cdDefect03.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDefect03.TextBoxAutoComplete = False
        Me.txt_cdDefect03.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDefect03.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_cdDefect03.TextEnabled = True
        Me.txt_cdDefect03.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect03.TextMaxLength = 32767
        Me.txt_cdDefect03.TextMultiLine = False
        Me.txt_cdDefect03.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDefect03.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDefect03.UseSendTab = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.rad_TestStatus2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_TestStatus1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(419, 65)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(196, 25)
        Me.TableLayoutPanel2.TabIndex = 267
        '
        'rad_TestStatus2
        '
        Me.rad_TestStatus2.AutoSize = True
        Me.rad_TestStatus2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rad_TestStatus2.Location = New System.Drawing.Point(101, 4)
        Me.rad_TestStatus2.Name = "rad_TestStatus2"
        Me.rad_TestStatus2.Size = New System.Drawing.Size(41, 17)
        Me.rad_TestStatus2.TabIndex = 1
        Me.rad_TestStatus2.Text = "Fail"
        Me.rad_TestStatus2.UseVisualStyleBackColor = True
        '
        'rad_TestStatus1
        '
        Me.rad_TestStatus1.AutoSize = True
        Me.rad_TestStatus1.Checked = True
        Me.rad_TestStatus1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.rad_TestStatus1.Location = New System.Drawing.Point(4, 4)
        Me.rad_TestStatus1.Name = "rad_TestStatus1"
        Me.rad_TestStatus1.Size = New System.Drawing.Size(48, 17)
        Me.rad_TestStatus1.TabIndex = 0
        Me.rad_TestStatus1.TabStop = True
        Me.rad_TestStatus1.Text = "Pass"
        Me.rad_TestStatus1.UseVisualStyleBackColor = True
        '
        'txt_cdDefect04
        '
        Me.txt_cdDefect04.BackYesno = False
        Me.txt_cdDefect04.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDefect04.ButtonEnabled = True
        Me.txt_cdDefect04.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdDefect04.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect04.ButtonName = ""
        Me.txt_cdDefect04.ButtonTitle = "Defect 04"
        Me.txt_cdDefect04.Code = ""
        Me.txt_cdDefect04.Data = ""
        Me.txt_cdDefect04.DataDecimal = 0
        Me.txt_cdDefect04.DataLen = 0
        Me.txt_cdDefect04.DataValue = 1
        Me.txt_cdDefect04.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdDefect04.Location = New System.Drawing.Point(314, 6)
        Me.txt_cdDefect04.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_cdDefect04.Name = "txt_cdDefect04"
        Me.txt_cdDefect04.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDefect04.Size = New System.Drawing.Size(302, 26)
        Me.txt_cdDefect04.TabIndex = 285
        Me.txt_cdDefect04.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDefect04.TextBoxAutoComplete = False
        Me.txt_cdDefect04.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDefect04.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_cdDefect04.TextEnabled = True
        Me.txt_cdDefect04.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefect04.TextMaxLength = 32767
        Me.txt_cdDefect04.TextMultiLine = False
        Me.txt_cdDefect04.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDefect04.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDefect04.UseSendTab = True
        '
        'PeaceLabel5
        '
        Me.PeaceLabel5.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PeaceLabel5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel5.Code = ""
        Me.PeaceLabel5.Data = ""
        Me.PeaceLabel5.DTDec = 0
        Me.PeaceLabel5.DTLen = 0
        Me.PeaceLabel5.DTValue = 0
        Me.PeaceLabel5.Location = New System.Drawing.Point(314, 65)
        Me.PeaceLabel5.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel5.Name = "PeaceLabel5"
        Me.PeaceLabel5.NoClear = False
        Me.PeaceLabel5.Size = New System.Drawing.Size(103, 25)
        Me.PeaceLabel5.TabIndex = 268
        Me.PeaceLabel5.Tag = ""
        Me.PeaceLabel5.Text = "Result"
        Me.PeaceLabel5.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'ISUD3555A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1256, 357)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ISUD3555A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LAB TEST PROCESSING (ISUD3555A)"
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        CType(Me.panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel.ResumeLayout(False)
        CType(Me.PeacePanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel4.ResumeLayout(False)
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_PRINT As PSMGlobal.PeaceButton
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Public WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_DateAccept As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_InchargeAccept As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSite As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_TestOrder As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LABNo As PSMGlobal.SelectLabelText
    Public WithEvents panel As PSMGlobal.PeacePanel
    Friend WithEvents txt_Remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdDefect05 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDefect04 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDefect03 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDefect02 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDefect01 As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_QtyFail As PSMGlobal.SelectLabelText
    Friend WithEvents txt_QtyPass As PSMGlobal.SelectLabelText
    Friend WithEvents txt_QtyTest As PSMGlobal.SelectLabelText
    Friend WithEvents txt_InchargeInspect As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_TimeInspect As PSMGlobal.SelectPeaceMaskText
    Friend WithEvents txt_LABNoSeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LABNo1 As PSMGlobal.SelectLabelText
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_TestStatus2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_TestStatus1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents PeaceLabel5 As PSMGlobal.PeaceLabel
    Public WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Public WithEvents PeacePanel4 As PSMGlobal.PeacePanel
    Public WithEvents PeacePanel3 As PSMGlobal.PeacePanel
End Class
