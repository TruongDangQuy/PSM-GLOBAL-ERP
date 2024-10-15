<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD4107A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD4107A))
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
        Dim Vs10_InputMapWhenFocusedNormal As FarPoint.Win.Spread.InputMap
        Dim Vs10_InputMapWhenAncestorOfFocusedNormal As FarPoint.Win.Spread.InputMap
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.tbl_Main = New System.Windows.Forms.TableLayoutPanel()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_PRINT = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Vs10 = New PSMGlobal.PeaceFarpoint()
        Me.Vs10_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Block1 = New System.Windows.Forms.Panel()
        Me.txt_TotalPerPrescription = New PSMGlobal.SelectLabelText()
        Me.txt_TotalPerLoss = New PSMGlobal.SelectLabelText()
        Me.txt_TotalQtyPrescription = New PSMGlobal.SelectLabelText()
        Me.tit_Side = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_TotalQtyLoss = New PSMGlobal.SelectLabelText()
        Me.txt_LabRecipeNoSeq = New PSMGlobal.SelectLabelText()
        Me.txt_LabRecipeNo = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialCode = New PSMGlobal.SelectPeaceHLPButton()
        Vs10_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs10_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        Me.tbl_Main.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.Vs10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs10_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.tbl_Main)
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(1085, 505)
        Me.frm_Condition.TabIndex = 0
        Me.frm_Condition.Tag = ""
        '
        'tbl_Main
        '
        Me.tbl_Main.ColumnCount = 1
        Me.tbl_Main.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl_Main.Controls.Add(Me.Frame4, 0, 2)
        Me.tbl_Main.Controls.Add(Me.Vs10, 0, 1)
        Me.tbl_Main.Controls.Add(Me.Panel1, 0, 0)
        Me.tbl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbl_Main.Location = New System.Drawing.Point(2, 2)
        Me.tbl_Main.Name = "tbl_Main"
        Me.tbl_Main.RowCount = 3
        Me.tbl_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.tbl_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tbl_Main.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tbl_Main.Size = New System.Drawing.Size(1081, 501)
        Me.tbl_Main.TabIndex = 41
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_PRINT)
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 459)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1075, 39)
        Me.Frame4.TabIndex = 1
        Me.Frame4.Tag = ""
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(933, 2)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.TabStop = False
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_PRINT
        '
        Me.cmd_PRINT.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_PRINT.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_PRINT.Appearance.Options.UseFont = True
        Me.cmd_PRINT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_PRINT.Code = Nothing
        Me.cmd_PRINT.Data = Nothing
        Me.cmd_PRINT.Image = CType(resources.GetObject("cmd_PRINT.Image"), System.Drawing.Image)
        Me.cmd_PRINT.ImageAlign = 16
        Me.cmd_PRINT.Location = New System.Drawing.Point(487, 2)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(141, 35)
        Me.cmd_PRINT.TabIndex = 9
        Me.cmd_PRINT.TabStop = False
        Me.cmd_PRINT.Text = "PRINT(&P)"
        Me.cmd_PRINT.UseVisualStyleBackColor = False
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 16
        Me.cmd_DEL.Location = New System.Drawing.Point(1, 2)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.TabStop = False
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(787, 2)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.TabStop = False
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Vs10
        '
        Me.Vs10.AccessibleDescription = "Vs10, Sheet1, Row 0, Column 0, "
        Me.Vs10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Vs10.CopyPasteChk = False
        Me.Vs10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Vs10.EditModeReplace = True
        Me.Vs10.FocusRenderer = EnhancedFocusIndicatorRenderer1
        Me.Vs10.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs10.HorizontalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs10.HorizontalScrollBar.Name = ""
        EnhancedScrollBarRenderer1.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer1.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer1.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs10.HorizontalScrollBar.Renderer = EnhancedScrollBarRenderer1
        Me.Vs10.HorizontalScrollBar.TabIndex = 0
        Me.Vs10.InsChk = True
        Me.Vs10.Location = New System.Drawing.Point(3, 73)
        Me.Vs10.Name = "Vs10"
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
        Me.Vs10.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.Vs10.ReportName = Nothing
        Me.Vs10.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs10_Sheet1})
        Me.Vs10.Size = New System.Drawing.Size(1075, 380)
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
        Me.Vs10.Skin = SpreadSkin1
        Me.Vs10.SpreadWjob = 0
        Me.Vs10.TabIndex = 18
        Me.Vs10.TabStop = False
        Me.Vs10.VerticalScrollBar.Buttons = New FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton")
        Me.Vs10.VerticalScrollBar.Name = ""
        EnhancedScrollBarRenderer3.ButtonBackgroundColor = System.Drawing.Color.White
        EnhancedScrollBarRenderer3.ButtonBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonHoveredBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.ButtonSelectedBorderColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarBackgroundColor = System.Drawing.Color.Gainsboro
        EnhancedScrollBarRenderer3.TrackBarSelectedBackgroundColor = System.Drawing.Color.Gainsboro
        Me.Vs10.VerticalScrollBar.Renderer = EnhancedScrollBarRenderer3
        Me.Vs10.VerticalScrollBar.TabIndex = 31
        Vs10_InputMapWhenFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs10.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs10_InputMapWhenFocusedNormal)
        Vs10_InputMapWhenAncestorOfFocusedNormal.Put(New FarPoint.Win.Spread.Keystroke(System.Windows.Forms.Keys.[Return], System.Windows.Forms.Keys.None), FarPoint.Win.Spread.SpreadActions.MoveToNextColumnWrap)
        Me.Vs10.SetInputMap(FarPoint.Win.Spread.InputMapMode.WhenAncestorOfFocused, FarPoint.Win.Spread.OperationMode.Normal, Vs10_InputMapWhenAncestorOfFocusedNormal)
        '
        'Vs10_Sheet1
        '
        Me.Vs10_Sheet1.Reset()
        Me.Vs10_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.Vs10_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.Vs10_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs10_Sheet1.ColumnFooter.DefaultStyle.Parent = "Style3"
        Me.Vs10_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs10_Sheet1.ColumnHeader.DefaultStyle.Parent = "Style2"
        Me.Vs10_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Vs10_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs10_Sheet1.DefaultStyle.Parent = "Style5"
        Me.Vs10_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.Vs10_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs10_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.Vs10_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs10_Sheet1.RowHeader.DefaultStyle.Parent = "Style1"
        Me.Vs10_Sheet1.Rows.Default.Height = 22.0!
        Me.Vs10_Sheet1.SelectionBackColor = System.Drawing.Color.Aquamarine
        Me.Vs10_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.Vs10_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.Vs10_Sheet1.SheetCornerStyle.Parent = "Style4"
        Me.Vs10_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txt_TotalPerPrescription)
        Me.Panel1.Controls.Add(Me.txt_TotalPerLoss)
        Me.Panel1.Controls.Add(Me.txt_TotalQtyPrescription)
        Me.Panel1.Controls.Add(Me.tit_Side)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.txt_TotalQtyLoss)
        Me.Panel1.Controls.Add(Me.txt_LabRecipeNoSeq)
        Me.Panel1.Controls.Add(Me.txt_LabRecipeNo)
        Me.Panel1.Controls.Add(Me.txt_MaterialCode)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1075, 64)
        Me.Panel1.TabIndex = 19
        '
        'Block1
        '
        Me.Block1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Block1.Location = New System.Drawing.Point(8, 7)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(1351, 744)
        Me.Block1.TabIndex = 40
        '
        'txt_TotalPerPrescription
        '
        Me.txt_TotalPerPrescription.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_TotalPerPrescription.BackYesno = False
        Me.txt_TotalPerPrescription.ButtonTitle = Nothing
        Me.txt_TotalPerPrescription.Code = Nothing
        Me.txt_TotalPerPrescription.Data = ""
        Me.txt_TotalPerPrescription.DataDecimal = 0
        Me.txt_TotalPerPrescription.DataLen = 1
        Me.txt_TotalPerPrescription.DataValue = 1
        Me.txt_TotalPerPrescription.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalPerPrescription.FormatDecimal = 0
        Me.txt_TotalPerPrescription.FormatValue = False
        Me.txt_TotalPerPrescription.LableBackColor = System.Drawing.Color.White
        Me.txt_TotalPerPrescription.LableEnabled = True
        Me.txt_TotalPerPrescription.LableFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalPerPrescription.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TotalPerPrescription.LableTitle = "Total Per Presc"
        Me.txt_TotalPerPrescription.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_TotalPerPrescription.Location = New System.Drawing.Point(805, 34)
        Me.txt_TotalPerPrescription.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TotalPerPrescription.Name = "txt_TotalPerPrescription"
        Me.txt_TotalPerPrescription.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TotalPerPrescription.Size = New System.Drawing.Size(265, 24)
        Me.txt_TotalPerPrescription.TabIndex = 48
        Me.txt_TotalPerPrescription.TabStop = False
        Me.txt_TotalPerPrescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalPerPrescription.TextBoxAutoComplete = True
        Me.txt_TotalPerPrescription.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TotalPerPrescription.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalPerPrescription.TextEnabled = False
        Me.txt_TotalPerPrescription.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TotalPerPrescription.TextMaxLength = 32767
        Me.txt_TotalPerPrescription.TextMultiLine = False
        Me.txt_TotalPerPrescription.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TotalPerPrescription.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TotalPerPrescription.UseSendTab = True
        '
        'txt_TotalPerLoss
        '
        Me.txt_TotalPerLoss.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_TotalPerLoss.BackYesno = False
        Me.txt_TotalPerLoss.ButtonTitle = Nothing
        Me.txt_TotalPerLoss.Code = Nothing
        Me.txt_TotalPerLoss.Data = ""
        Me.txt_TotalPerLoss.DataDecimal = 0
        Me.txt_TotalPerLoss.DataLen = 1
        Me.txt_TotalPerLoss.DataValue = 1
        Me.txt_TotalPerLoss.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalPerLoss.FormatDecimal = 0
        Me.txt_TotalPerLoss.FormatValue = False
        Me.txt_TotalPerLoss.LableBackColor = System.Drawing.Color.White
        Me.txt_TotalPerLoss.LableEnabled = True
        Me.txt_TotalPerLoss.LableFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalPerLoss.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TotalPerLoss.LableTitle = "Total Per Loss"
        Me.txt_TotalPerLoss.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_TotalPerLoss.Location = New System.Drawing.Point(805, 9)
        Me.txt_TotalPerLoss.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TotalPerLoss.Name = "txt_TotalPerLoss"
        Me.txt_TotalPerLoss.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TotalPerLoss.Size = New System.Drawing.Size(265, 24)
        Me.txt_TotalPerLoss.TabIndex = 47
        Me.txt_TotalPerLoss.TabStop = False
        Me.txt_TotalPerLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalPerLoss.TextBoxAutoComplete = True
        Me.txt_TotalPerLoss.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TotalPerLoss.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalPerLoss.TextEnabled = False
        Me.txt_TotalPerLoss.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TotalPerLoss.TextMaxLength = 32767
        Me.txt_TotalPerLoss.TextMultiLine = False
        Me.txt_TotalPerLoss.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TotalPerLoss.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TotalPerLoss.UseSendTab = True
        '
        'txt_TotalQtyPrescription
        '
        Me.txt_TotalQtyPrescription.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_TotalQtyPrescription.BackYesno = False
        Me.txt_TotalQtyPrescription.ButtonTitle = Nothing
        Me.txt_TotalQtyPrescription.Code = Nothing
        Me.txt_TotalQtyPrescription.Data = ""
        Me.txt_TotalQtyPrescription.DataDecimal = 0
        Me.txt_TotalQtyPrescription.DataLen = 1
        Me.txt_TotalQtyPrescription.DataValue = 1
        Me.txt_TotalQtyPrescription.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalQtyPrescription.FormatDecimal = 0
        Me.txt_TotalQtyPrescription.FormatValue = False
        Me.txt_TotalQtyPrescription.LableBackColor = System.Drawing.Color.White
        Me.txt_TotalQtyPrescription.LableEnabled = True
        Me.txt_TotalQtyPrescription.LableFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalQtyPrescription.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TotalQtyPrescription.LableTitle = "Total Qty Presc"
        Me.txt_TotalQtyPrescription.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_TotalQtyPrescription.Location = New System.Drawing.Point(538, 34)
        Me.txt_TotalQtyPrescription.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TotalQtyPrescription.Name = "txt_TotalQtyPrescription"
        Me.txt_TotalQtyPrescription.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TotalQtyPrescription.Size = New System.Drawing.Size(265, 24)
        Me.txt_TotalQtyPrescription.TabIndex = 46
        Me.txt_TotalQtyPrescription.TabStop = False
        Me.txt_TotalQtyPrescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalQtyPrescription.TextBoxAutoComplete = True
        Me.txt_TotalQtyPrescription.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TotalQtyPrescription.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalQtyPrescription.TextEnabled = False
        Me.txt_TotalQtyPrescription.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TotalQtyPrescription.TextMaxLength = 32767
        Me.txt_TotalQtyPrescription.TextMultiLine = False
        Me.txt_TotalQtyPrescription.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TotalQtyPrescription.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TotalQtyPrescription.UseSendTab = True
        '
        'tit_Side
        '
        Me.tit_Side.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tit_Side.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.tit_Side.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.tit_Side.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tit_Side.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tit_Side.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.tit_Side.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.tit_Side.Code = ""
        Me.tit_Side.Data = ""
        Me.tit_Side.DTDec = 0
        Me.tit_Side.DTLen = 0
        Me.tit_Side.DTValue = 0
        Me.tit_Side.Location = New System.Drawing.Point(271, 34)
        Me.tit_Side.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Side.Name = "tit_Side"
        Me.tit_Side.NoClear = False
        Me.tit_Side.Size = New System.Drawing.Size(105, 24)
        Me.tit_Side.TabIndex = 45
        Me.tit_Side.Tag = ""
        Me.tit_Side.Text = "Use"
        Me.tit_Side.TextAlign = 32
        '
        'Panel5
        '
        Me.Panel5.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Controls.Add(Me.rad_CheckUse2, 1, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckUse1, 0, 0)
        Me.Panel5.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.Panel5.Location = New System.Drawing.Point(377, 34)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.Panel5.Size = New System.Drawing.Size(159, 24)
        Me.Panel5.TabIndex = 44
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(81, 2)
        Me.rad_CheckUse2.Margin = New System.Windows.Forms.Padding(1)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(76, 20)
        Me.rad_CheckUse2.TabIndex = 1
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(2, 2)
        Me.rad_CheckUse1.Margin = New System.Windows.Forms.Padding(1)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(75, 20)
        Me.rad_CheckUse1.TabIndex = 0
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'txt_TotalQtyLoss
        '
        Me.txt_TotalQtyLoss.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_TotalQtyLoss.BackYesno = False
        Me.txt_TotalQtyLoss.ButtonTitle = Nothing
        Me.txt_TotalQtyLoss.Code = Nothing
        Me.txt_TotalQtyLoss.Data = ""
        Me.txt_TotalQtyLoss.DataDecimal = 0
        Me.txt_TotalQtyLoss.DataLen = 1
        Me.txt_TotalQtyLoss.DataValue = 1
        Me.txt_TotalQtyLoss.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalQtyLoss.FormatDecimal = 0
        Me.txt_TotalQtyLoss.FormatValue = False
        Me.txt_TotalQtyLoss.LableBackColor = System.Drawing.Color.White
        Me.txt_TotalQtyLoss.LableEnabled = True
        Me.txt_TotalQtyLoss.LableFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalQtyLoss.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TotalQtyLoss.LableTitle = "Total Qty Loss"
        Me.txt_TotalQtyLoss.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_TotalQtyLoss.Location = New System.Drawing.Point(538, 9)
        Me.txt_TotalQtyLoss.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TotalQtyLoss.Name = "txt_TotalQtyLoss"
        Me.txt_TotalQtyLoss.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TotalQtyLoss.Size = New System.Drawing.Size(265, 24)
        Me.txt_TotalQtyLoss.TabIndex = 43
        Me.txt_TotalQtyLoss.TabStop = False
        Me.txt_TotalQtyLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_TotalQtyLoss.TextBoxAutoComplete = True
        Me.txt_TotalQtyLoss.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TotalQtyLoss.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_TotalQtyLoss.TextEnabled = False
        Me.txt_TotalQtyLoss.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TotalQtyLoss.TextMaxLength = 32767
        Me.txt_TotalQtyLoss.TextMultiLine = False
        Me.txt_TotalQtyLoss.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TotalQtyLoss.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TotalQtyLoss.UseSendTab = True
        '
        'txt_LabRecipeNoSeq
        '
        Me.txt_LabRecipeNoSeq.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_LabRecipeNoSeq.BackYesno = False
        Me.txt_LabRecipeNoSeq.ButtonTitle = Nothing
        Me.txt_LabRecipeNoSeq.Code = Nothing
        Me.txt_LabRecipeNoSeq.Data = ""
        Me.txt_LabRecipeNoSeq.DataDecimal = 0
        Me.txt_LabRecipeNoSeq.DataLen = 1
        Me.txt_LabRecipeNoSeq.DataValue = 1
        Me.txt_LabRecipeNoSeq.FormatDecimal = 0
        Me.txt_LabRecipeNoSeq.FormatValue = False
        Me.txt_LabRecipeNoSeq.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_LabRecipeNoSeq.LableEnabled = True
        Me.txt_LabRecipeNoSeq.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_LabRecipeNoSeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_LabRecipeNoSeq.LableTitle = "Lab RecipeNo Seq"
        Me.txt_LabRecipeNoSeq.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_LabRecipeNoSeq.Location = New System.Drawing.Point(4, 34)
        Me.txt_LabRecipeNoSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LabRecipeNoSeq.Name = "txt_LabRecipeNoSeq"
        Me.txt_LabRecipeNoSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LabRecipeNoSeq.Size = New System.Drawing.Size(265, 24)
        Me.txt_LabRecipeNoSeq.TabIndex = 42
        Me.txt_LabRecipeNoSeq.TabStop = False
        Me.txt_LabRecipeNoSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_LabRecipeNoSeq.TextBoxAutoComplete = True
        Me.txt_LabRecipeNoSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LabRecipeNoSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_LabRecipeNoSeq.TextEnabled = False
        Me.txt_LabRecipeNoSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LabRecipeNoSeq.TextMaxLength = 32767
        Me.txt_LabRecipeNoSeq.TextMultiLine = False
        Me.txt_LabRecipeNoSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LabRecipeNoSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LabRecipeNoSeq.UseSendTab = True
        '
        'txt_LabRecipeNo
        '
        Me.txt_LabRecipeNo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_LabRecipeNo.BackYesno = False
        Me.txt_LabRecipeNo.ButtonTitle = Nothing
        Me.txt_LabRecipeNo.Code = Nothing
        Me.txt_LabRecipeNo.Data = ""
        Me.txt_LabRecipeNo.DataDecimal = 0
        Me.txt_LabRecipeNo.DataLen = 1
        Me.txt_LabRecipeNo.DataValue = 1
        Me.txt_LabRecipeNo.FormatDecimal = 0
        Me.txt_LabRecipeNo.FormatValue = False
        Me.txt_LabRecipeNo.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_LabRecipeNo.LableEnabled = True
        Me.txt_LabRecipeNo.LableFont = New System.Drawing.Font("Tahoma", 8.5!, System.Drawing.FontStyle.Bold)
        Me.txt_LabRecipeNo.LableForeColor = System.Drawing.Color.Empty
        Me.txt_LabRecipeNo.LableTitle = "Lab Recipe No"
        Me.txt_LabRecipeNo.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_LabRecipeNo.Location = New System.Drawing.Point(4, 9)
        Me.txt_LabRecipeNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LabRecipeNo.Name = "txt_LabRecipeNo"
        Me.txt_LabRecipeNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LabRecipeNo.Size = New System.Drawing.Size(265, 24)
        Me.txt_LabRecipeNo.TabIndex = 40
        Me.txt_LabRecipeNo.TabStop = False
        Me.txt_LabRecipeNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_LabRecipeNo.TextBoxAutoComplete = True
        Me.txt_LabRecipeNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LabRecipeNo.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_LabRecipeNo.TextEnabled = False
        Me.txt_LabRecipeNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LabRecipeNo.TextMaxLength = 32767
        Me.txt_LabRecipeNo.TextMultiLine = False
        Me.txt_LabRecipeNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LabRecipeNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LabRecipeNo.UseSendTab = True
        '
        'txt_MaterialCode
        '
        Me.txt_MaterialCode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txt_MaterialCode.BackYesno = False
        Me.txt_MaterialCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_MaterialCode.ButtonEnabled = True
        Me.txt_MaterialCode.ButtonFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_MaterialCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.ButtonName = ""
        Me.txt_MaterialCode.ButtonTitle = "Material"
        Me.txt_MaterialCode.Code = ""
        Me.txt_MaterialCode.Data = ""
        Me.txt_MaterialCode.DataDecimal = 0
        Me.txt_MaterialCode.DataLen = 0
        Me.txt_MaterialCode.DataValue = 1
        Me.txt_MaterialCode.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_MaterialCode.Location = New System.Drawing.Point(271, 9)
        Me.txt_MaterialCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialCode.Name = "txt_MaterialCode"
        Me.txt_MaterialCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialCode.Size = New System.Drawing.Size(265, 24)
        Me.txt_MaterialCode.TabIndex = 41
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
        'ISUD4107A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1085, 505)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ISUD4107A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OUTSOLE RECIPE CONTROL (ISUD4107A)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.tbl_Main.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.Vs10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs10_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Block1 As System.Windows.Forms.Panel
    Friend WithEvents tbl_Main As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Vs10 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Vs10_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_PRINT As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt_TotalPerPrescription As PSMGlobal.SelectLabelText
    Friend WithEvents txt_TotalPerLoss As PSMGlobal.SelectLabelText
    Friend WithEvents txt_TotalQtyPrescription As PSMGlobal.SelectLabelText
    Friend WithEvents tit_Side As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_TotalQtyLoss As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LabRecipeNoSeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_LabRecipeNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MaterialCode As PSMGlobal.SelectPeaceHLPButton
End Class
