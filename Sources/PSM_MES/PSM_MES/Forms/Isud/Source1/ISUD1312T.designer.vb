<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD1312T
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD1312T))
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
        Me.Pal_2 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_PRINT = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        Me.Pal_1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_RemarkOther = New PSMGlobal.SelectLabelText()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_DateFitting = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_DateTesting = New PSMGlobal.SelectPeaceCalSin()
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckTesting1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckTesting3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckTesting2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.tit_Use = New PSMGlobal.PeaceLabel(Me.components)
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckFitting1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckFitting3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckFitting2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_OrderNoSeq = New PSMGlobal.SelectLabelText()
        Me.txt_Line = New PSMGlobal.SelectLabelText()
        Me.txt_Article = New PSMGlobal.SelectLabelText()
        Me.txt_OrderNo = New PSMGlobal.SelectLabelText()
        Me.txt_Color = New PSMGlobal.SelectLabelText()
        Me.Vs1 = New PSMGlobal.PeaceFarpoint()
        Me.Vs1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Tlp_1 = New System.Windows.Forms.TableLayoutPanel()
        Vs1_InputMapWhenFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal = New FarPoint.Win.Spread.InputMap()
        Vs1_InputMapWhenAncestorOfFocusedNormal.Parent = New FarPoint.Win.Spread.InputMap()
        CType(Me.Pal_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pal_2.SuspendLayout()
        CType(Me.Pal_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pal_1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tlp_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(710, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "SAVE(&S)"
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
        Me.cmd_DEL.Location = New System.Drawing.Point(1, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(851, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'Pal_2
        '
        Me.Pal_2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pal_2.Code = ""
        Me.Pal_2.Controls.Add(Me.cmd_PRINT)
        Me.Pal_2.Controls.Add(Me.cmd_AttachID)
        Me.Pal_2.Controls.Add(Me.cmd_Cancel)
        Me.Pal_2.Controls.Add(Me.cmd_DEL)
        Me.Pal_2.Controls.Add(Me.cmd_OK)
        Me.Pal_2.Data = ""
        Me.Pal_2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pal_2.Location = New System.Drawing.Point(3, 757)
        Me.Pal_2.Name = "Pal_2"
        Me.Pal_2.Size = New System.Drawing.Size(996, 39)
        Me.Pal_2.TabIndex = 1
        Me.Pal_2.Tag = ""
        '
        'cmd_PRINT
        '
        Me.cmd_PRINT.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_PRINT.Appearance.Options.UseFont = True
        Me.cmd_PRINT.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_PRINT.ButtonTitle = Nothing
        Me.cmd_PRINT.Code = ""
        Me.cmd_PRINT.Data = ""
        Me.cmd_PRINT.Image = Global.PSMGlobal.My.Resources.Resources.printer
        Me.cmd_PRINT.ImageAlign = 16
        Me.cmd_PRINT.Location = New System.Drawing.Point(483, 1)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(141, 35)
        Me.cmd_PRINT.TabIndex = 5
        Me.cmd_PRINT.TabStop = False
        Me.cmd_PRINT.Tag = ""
        Me.cmd_PRINT.Text = "PRINT(&P)"
        Me.cmd_PRINT.UseVisualStyleBackColor = False
        '
        'cmd_AttachID
        '
        Me.cmd_AttachID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_AttachID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_AttachID.Appearance.Options.UseFont = True
        Me.cmd_AttachID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_AttachID.ButtonTitle = Nothing
        Me.cmd_AttachID.Code = Nothing
        Me.cmd_AttachID.Data = Nothing
        Me.cmd_AttachID.Image = CType(resources.GetObject("cmd_AttachID.Image"), System.Drawing.Image)
        Me.cmd_AttachID.ImageAlign = 16
        Me.cmd_AttachID.Location = New System.Drawing.Point(342, 2)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 3
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
        Me.cmd_AttachID.Visible = False
        '
        'Pal_1
        '
        Me.Pal_1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Pal_1.Code = ""
        Me.Pal_1.Controls.Add(Me.txt_RemarkOther)
        Me.Pal_1.Controls.Add(Me.Panel1)
        Me.Pal_1.Controls.Add(Me.txt_OrderNoSeq)
        Me.Pal_1.Controls.Add(Me.txt_Line)
        Me.Pal_1.Controls.Add(Me.txt_Article)
        Me.Pal_1.Controls.Add(Me.txt_OrderNo)
        Me.Pal_1.Controls.Add(Me.txt_Color)
        Me.Pal_1.Data = ""
        Me.Pal_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Pal_1.Location = New System.Drawing.Point(3, 3)
        Me.Pal_1.Name = "Pal_1"
        Me.Pal_1.Size = New System.Drawing.Size(996, 131)
        Me.Pal_1.TabIndex = 0
        Me.Pal_1.Tag = ""
        '
        'txt_RemarkOther
        '
        Me.txt_RemarkOther.BackYesno = False
        Me.txt_RemarkOther.ButtonTitle = Nothing
        Me.txt_RemarkOther.Code = Nothing
        Me.txt_RemarkOther.Data = ""
        Me.txt_RemarkOther.DataDecimal = 0
        Me.txt_RemarkOther.DataLen = 0
        Me.txt_RemarkOther.DataValue = 0
        Me.txt_RemarkOther.FormatDecimal = 0
        Me.txt_RemarkOther.FormatValue = False
        Me.txt_RemarkOther.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_RemarkOther.LableEnabled = True
        Me.txt_RemarkOther.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RemarkOther.LableForeColor = System.Drawing.Color.Empty
        Me.txt_RemarkOther.LableTitle = "Remark"
        Me.txt_RemarkOther.Layoutpercent = New Decimal(New Integer() {123, 0, 0, 196608})
        Me.txt_RemarkOther.Location = New System.Drawing.Point(3, 89)
        Me.txt_RemarkOther.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_RemarkOther.Name = "txt_RemarkOther"
        Me.txt_RemarkOther.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_RemarkOther.Size = New System.Drawing.Size(989, 39)
        Me.txt_RemarkOther.TabIndex = 11
        Me.txt_RemarkOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_RemarkOther.TextBoxAutoComplete = False
        Me.txt_RemarkOther.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_RemarkOther.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_RemarkOther.TextEnabled = True
        Me.txt_RemarkOther.TextForeColor = System.Drawing.Color.Empty
        Me.txt_RemarkOther.TextMaxLength = 32767
        Me.txt_RemarkOther.TextMultiLine = False
        Me.txt_RemarkOther.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_RemarkOther.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_RemarkOther.UseSendTab = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txt_DateFitting)
        Me.Panel1.Controls.Add(Me.txt_DateTesting)
        Me.Panel1.Controls.Add(Me.PeaceLabel1)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.tit_Use)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Location = New System.Drawing.Point(370, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(622, 55)
        Me.Panel1.TabIndex = 10
        '
        'txt_DateFitting
        '
        Me.txt_DateFitting.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateFitting.ButtonEnabled = True
        Me.txt_DateFitting.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateFitting.ButtonName = Nothing
        Me.txt_DateFitting.ButtonTitle = "Date Fitting"
        Me.txt_DateFitting.Code = ""
        Me.txt_DateFitting.Data = "20150101"
        Me.txt_DateFitting.DataDecimal = 0
        Me.txt_DateFitting.DataLen = 0
        Me.txt_DateFitting.DataValue = 0
        Me.txt_DateFitting.FormatDecimal = 0
        Me.txt_DateFitting.FormatValue = False
        Me.txt_DateFitting.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateFitting.Location = New System.Drawing.Point(352, 29)
        Me.txt_DateFitting.Margin = New System.Windows.Forms.Padding(1, 1, 138, 1)
        Me.txt_DateFitting.Name = "txt_DateFitting"
        Me.txt_DateFitting.Size = New System.Drawing.Size(264, 24)
        Me.txt_DateFitting.TabIndex = 16
        Me.txt_DateFitting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateFitting.TextBoxAutoComplete = False
        Me.txt_DateFitting.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateFitting.TextEnabled = True
        Me.txt_DateFitting.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateFitting.TextMaxLength = 32767
        Me.txt_DateFitting.TextMultiLine = True
        Me.txt_DateFitting.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_DateTesting
        '
        Me.txt_DateTesting.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateTesting.ButtonEnabled = True
        Me.txt_DateTesting.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateTesting.ButtonName = Nothing
        Me.txt_DateTesting.ButtonTitle = "Date Testing"
        Me.txt_DateTesting.Code = ""
        Me.txt_DateTesting.Data = "20150101"
        Me.txt_DateTesting.DataDecimal = 0
        Me.txt_DateTesting.DataLen = 0
        Me.txt_DateTesting.DataValue = 0
        Me.txt_DateTesting.FormatDecimal = 0
        Me.txt_DateTesting.FormatValue = False
        Me.txt_DateTesting.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateTesting.Location = New System.Drawing.Point(353, 2)
        Me.txt_DateTesting.Margin = New System.Windows.Forms.Padding(1, 1, 138, 1)
        Me.txt_DateTesting.Name = "txt_DateTesting"
        Me.txt_DateTesting.Size = New System.Drawing.Size(264, 24)
        Me.txt_DateTesting.TabIndex = 15
        Me.txt_DateTesting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateTesting.TextBoxAutoComplete = False
        Me.txt_DateTesting.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateTesting.TextEnabled = True
        Me.txt_DateTesting.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateTesting.TextMaxLength = 32767
        Me.txt_DateTesting.TextMultiLine = True
        Me.txt_DateTesting.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(-2, 28)
        Me.PeaceLabel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(119, 25)
        Me.PeaceLabel1.TabIndex = 13
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "Testing"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.rad_CheckTesting1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_CheckTesting3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_CheckTesting2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(118, 28)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(229, 24)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'rad_CheckTesting1
        '
        Me.rad_CheckTesting1.AutoSize = True
        Me.rad_CheckTesting1.ButtonTitle = Nothing
        Me.rad_CheckTesting1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckTesting1.ForeColor = System.Drawing.Color.Blue
        Me.rad_CheckTesting1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckTesting1.Name = "rad_CheckTesting1"
        Me.rad_CheckTesting1.Size = New System.Drawing.Size(51, 16)
        Me.rad_CheckTesting1.TabIndex = 0
        Me.rad_CheckTesting1.Text = "Pass"
        Me.rad_CheckTesting1.UseVisualStyleBackColor = True
        '
        'rad_CheckTesting3
        '
        Me.rad_CheckTesting3.AutoSize = True
        Me.rad_CheckTesting3.ButtonTitle = Nothing
        Me.rad_CheckTesting3.Checked = True
        Me.rad_CheckTesting3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckTesting3.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckTesting3.Location = New System.Drawing.Point(156, 4)
        Me.rad_CheckTesting3.Name = "rad_CheckTesting3"
        Me.rad_CheckTesting3.Size = New System.Drawing.Size(69, 16)
        Me.rad_CheckTesting3.TabIndex = 2
        Me.rad_CheckTesting3.TabStop = True
        Me.rad_CheckTesting3.Text = "Pending"
        Me.rad_CheckTesting3.UseVisualStyleBackColor = True
        '
        'rad_CheckTesting2
        '
        Me.rad_CheckTesting2.AutoSize = True
        Me.rad_CheckTesting2.ButtonTitle = Nothing
        Me.rad_CheckTesting2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckTesting2.ForeColor = System.Drawing.Color.Red
        Me.rad_CheckTesting2.Location = New System.Drawing.Point(80, 4)
        Me.rad_CheckTesting2.Name = "rad_CheckTesting2"
        Me.rad_CheckTesting2.Size = New System.Drawing.Size(44, 16)
        Me.rad_CheckTesting2.TabIndex = 1
        Me.rad_CheckTesting2.Text = "Fail"
        Me.rad_CheckTesting2.UseVisualStyleBackColor = True
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
        Me.tit_Use.Location = New System.Drawing.Point(-1, 1)
        Me.tit_Use.Margin = New System.Windows.Forms.Padding(1)
        Me.tit_Use.Name = "tit_Use"
        Me.tit_Use.NoClear = False
        Me.tit_Use.Size = New System.Drawing.Size(117, 25)
        Me.tit_Use.TabIndex = 11
        Me.tit_Use.Tag = ""
        Me.tit_Use.Text = "Fitting"
        Me.tit_Use.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 3
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.Panel5.Controls.Add(Me.rad_CheckFitting1, 0, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckFitting3, 2, 0)
        Me.Panel5.Controls.Add(Me.rad_CheckFitting2, 1, 0)
        Me.Panel5.Location = New System.Drawing.Point(118, 1)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 1
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel5.Size = New System.Drawing.Size(229, 24)
        Me.Panel5.TabIndex = 12
        '
        'rad_CheckFitting1
        '
        Me.rad_CheckFitting1.AutoSize = True
        Me.rad_CheckFitting1.ButtonTitle = Nothing
        Me.rad_CheckFitting1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckFitting1.ForeColor = System.Drawing.Color.Blue
        Me.rad_CheckFitting1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckFitting1.Name = "rad_CheckFitting1"
        Me.rad_CheckFitting1.Size = New System.Drawing.Size(51, 16)
        Me.rad_CheckFitting1.TabIndex = 0
        Me.rad_CheckFitting1.Text = "Pass"
        Me.rad_CheckFitting1.UseVisualStyleBackColor = True
        '
        'rad_CheckFitting3
        '
        Me.rad_CheckFitting3.AutoSize = True
        Me.rad_CheckFitting3.ButtonTitle = Nothing
        Me.rad_CheckFitting3.Checked = True
        Me.rad_CheckFitting3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckFitting3.ForeColor = System.Drawing.Color.Black
        Me.rad_CheckFitting3.Location = New System.Drawing.Point(156, 4)
        Me.rad_CheckFitting3.Name = "rad_CheckFitting3"
        Me.rad_CheckFitting3.Size = New System.Drawing.Size(69, 16)
        Me.rad_CheckFitting3.TabIndex = 2
        Me.rad_CheckFitting3.TabStop = True
        Me.rad_CheckFitting3.Text = "Pending"
        Me.rad_CheckFitting3.UseVisualStyleBackColor = True
        '
        'rad_CheckFitting2
        '
        Me.rad_CheckFitting2.AutoSize = True
        Me.rad_CheckFitting2.ButtonTitle = Nothing
        Me.rad_CheckFitting2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckFitting2.ForeColor = System.Drawing.Color.Red
        Me.rad_CheckFitting2.Location = New System.Drawing.Point(80, 4)
        Me.rad_CheckFitting2.Name = "rad_CheckFitting2"
        Me.rad_CheckFitting2.Size = New System.Drawing.Size(44, 16)
        Me.rad_CheckFitting2.TabIndex = 1
        Me.rad_CheckFitting2.Text = "Fail"
        Me.rad_CheckFitting2.UseVisualStyleBackColor = True
        '
        'txt_OrderNoSeq
        '
        Me.txt_OrderNoSeq.BackYesno = False
        Me.txt_OrderNoSeq.ButtonTitle = Nothing
        Me.txt_OrderNoSeq.Code = Nothing
        Me.txt_OrderNoSeq.Data = ""
        Me.txt_OrderNoSeq.DataDecimal = 0
        Me.txt_OrderNoSeq.DataLen = 0
        Me.txt_OrderNoSeq.DataValue = 0
        Me.txt_OrderNoSeq.FormatDecimal = 0
        Me.txt_OrderNoSeq.FormatValue = False
        Me.txt_OrderNoSeq.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_OrderNoSeq.LableEnabled = True
        Me.txt_OrderNoSeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_OrderNoSeq.LableForeColor = System.Drawing.Color.Black
        Me.txt_OrderNoSeq.LableTitle = "Seq"
        Me.txt_OrderNoSeq.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_OrderNoSeq.Location = New System.Drawing.Point(248, 3)
        Me.txt_OrderNoSeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OrderNoSeq.Name = "txt_OrderNoSeq"
        Me.txt_OrderNoSeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OrderNoSeq.Size = New System.Drawing.Size(121, 25)
        Me.txt_OrderNoSeq.TabIndex = 8
        Me.txt_OrderNoSeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OrderNoSeq.TextBoxAutoComplete = False
        Me.txt_OrderNoSeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_OrderNoSeq.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_OrderNoSeq.TextEnabled = True
        Me.txt_OrderNoSeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_OrderNoSeq.TextMaxLength = 32767
        Me.txt_OrderNoSeq.TextMultiLine = False
        Me.txt_OrderNoSeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_OrderNoSeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_OrderNoSeq.UseSendTab = True
        '
        'txt_Line
        '
        Me.txt_Line.BackYesno = False
        Me.txt_Line.ButtonTitle = "Line"
        Me.txt_Line.Code = Nothing
        Me.txt_Line.Data = ""
        Me.txt_Line.DataDecimal = 0
        Me.txt_Line.DataLen = 0
        Me.txt_Line.DataValue = 0
        Me.txt_Line.FormatDecimal = 0
        Me.txt_Line.FormatValue = False
        Me.txt_Line.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Line.LableEnabled = True
        Me.txt_Line.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Line.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Line.LableTitle = "Line"
        Me.txt_Line.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Line.Location = New System.Drawing.Point(371, 3)
        Me.txt_Line.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Line.Name = "txt_Line"
        Me.txt_Line.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Line.Size = New System.Drawing.Size(349, 25)
        Me.txt_Line.TabIndex = 6
        Me.txt_Line.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Line.TextBoxAutoComplete = False
        Me.txt_Line.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Line.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_Line.TextEnabled = True
        Me.txt_Line.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Line.TextMaxLength = 32767
        Me.txt_Line.TextMultiLine = False
        Me.txt_Line.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Line.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Line.UseSendTab = True
        '
        'txt_Article
        '
        Me.txt_Article.BackYesno = False
        Me.txt_Article.ButtonTitle = "Article"
        Me.txt_Article.Code = Nothing
        Me.txt_Article.Data = ""
        Me.txt_Article.DataDecimal = 0
        Me.txt_Article.DataLen = 0
        Me.txt_Article.DataValue = 0
        Me.txt_Article.FormatDecimal = 0
        Me.txt_Article.FormatValue = False
        Me.txt_Article.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Article.LableEnabled = True
        Me.txt_Article.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Article.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Article.LableTitle = "Article"
        Me.txt_Article.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Article.Location = New System.Drawing.Point(3, 30)
        Me.txt_Article.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Article.Name = "txt_Article"
        Me.txt_Article.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Article.Size = New System.Drawing.Size(365, 25)
        Me.txt_Article.TabIndex = 2
        Me.txt_Article.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Article.TextBoxAutoComplete = False
        Me.txt_Article.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Article.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_Article.TextEnabled = True
        Me.txt_Article.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Article.TextMaxLength = 32767
        Me.txt_Article.TextMultiLine = False
        Me.txt_Article.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Article.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Article.UseSendTab = True
        '
        'txt_OrderNo
        '
        Me.txt_OrderNo.BackYesno = False
        Me.txt_OrderNo.ButtonTitle = Nothing
        Me.txt_OrderNo.Code = Nothing
        Me.txt_OrderNo.Data = ""
        Me.txt_OrderNo.DataDecimal = 0
        Me.txt_OrderNo.DataLen = 0
        Me.txt_OrderNo.DataValue = 0
        Me.txt_OrderNo.FormatDecimal = 0
        Me.txt_OrderNo.FormatValue = False
        Me.txt_OrderNo.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_OrderNo.LableEnabled = True
        Me.txt_OrderNo.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_OrderNo.LableForeColor = System.Drawing.Color.Black
        Me.txt_OrderNo.LableTitle = "Order No"
        Me.txt_OrderNo.Layoutpercent = New Decimal(New Integer() {508, 0, 0, 196608})
        Me.txt_OrderNo.Location = New System.Drawing.Point(3, 3)
        Me.txt_OrderNo.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_OrderNo.Name = "txt_OrderNo"
        Me.txt_OrderNo.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_OrderNo.Size = New System.Drawing.Size(243, 25)
        Me.txt_OrderNo.TabIndex = 0
        Me.txt_OrderNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_OrderNo.TextBoxAutoComplete = False
        Me.txt_OrderNo.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_OrderNo.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_OrderNo.TextEnabled = True
        Me.txt_OrderNo.TextForeColor = System.Drawing.Color.Empty
        Me.txt_OrderNo.TextMaxLength = 32767
        Me.txt_OrderNo.TextMultiLine = False
        Me.txt_OrderNo.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_OrderNo.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_OrderNo.UseSendTab = True
        '
        'txt_Color
        '
        Me.txt_Color.BackYesno = False
        Me.txt_Color.ButtonTitle = Nothing
        Me.txt_Color.Code = Nothing
        Me.txt_Color.Data = ""
        Me.txt_Color.DataDecimal = 0
        Me.txt_Color.DataLen = 0
        Me.txt_Color.DataValue = 0
        Me.txt_Color.FormatDecimal = 0
        Me.txt_Color.FormatValue = False
        Me.txt_Color.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Color.LableEnabled = True
        Me.txt_Color.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Color.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Color.LableTitle = "Color"
        Me.txt_Color.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_Color.Location = New System.Drawing.Point(3, 58)
        Me.txt_Color.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Color.Name = "txt_Color"
        Me.txt_Color.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Color.Size = New System.Drawing.Size(364, 25)
        Me.txt_Color.TabIndex = 1
        Me.txt_Color.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Color.TextBoxAutoComplete = False
        Me.txt_Color.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Color.TextBoxFont = New System.Drawing.Font("Tahoma", 12.0!)
        Me.txt_Color.TextEnabled = True
        Me.txt_Color.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Color.TextMaxLength = 32767
        Me.txt_Color.TextMultiLine = False
        Me.txt_Color.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Color.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Color.UseSendTab = True
        '
        'Vs1
        '
        Me.Vs1.AccessibleDescription = ""
        Me.Vs1.AllowDragFill = True
        Me.Vs1.ClipboardOptions = FarPoint.Win.Spread.ClipboardOptions.NoHeaders
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
        Me.Vs1.HorizontalScrollBar.TabIndex = 0
        Me.Vs1.InsChk = True
        Me.Vs1.Location = New System.Drawing.Point(3, 140)
        Me.Vs1.Name = "Vs1"
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
        Me.Vs1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5})
        Me.Vs1.ReportName = Nothing
        Me.Vs1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.Vs1_Sheet1})
        Me.Vs1.Size = New System.Drawing.Size(996, 611)
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
        Me.Vs1.Skin = SpreadSkin1
        Me.Vs1.SpreadWjob = 0
        Me.Vs1.TabIndex = 0
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
        Me.Vs1.VerticalScrollBar.TabIndex = 1
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
        'Tlp_1
        '
        Me.Tlp_1.ColumnCount = 1
        Me.Tlp_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.Controls.Add(Me.Pal_2, 0, 2)
        Me.Tlp_1.Controls.Add(Me.Pal_1, 0, 0)
        Me.Tlp_1.Controls.Add(Me.Vs1)
        Me.Tlp_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tlp_1.Location = New System.Drawing.Point(0, 0)
        Me.Tlp_1.Name = "Tlp_1"
        Me.Tlp_1.RowCount = 3
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.Tlp_1.Size = New System.Drawing.Size(1002, 799)
        Me.Tlp_1.TabIndex = 103
        '
        'ISUD1312T
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1002, 799)
        Me.Controls.Add(Me.Tlp_1)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "ISUD1312T"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TESTING AND FITTING PROCESSING (ISUD1312T)"
        CType(Me.Pal_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pal_2.ResumeLayout(False)
        CType(Me.Pal_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pal_1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Vs1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vs1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tlp_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Pal_2 As PSMGlobal.PeacePanel
    Friend WithEvents Vs1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents Pal_1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_OrderNo As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Color As PSMGlobal.SelectLabelText
    Public WithEvents Vs1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents Tlp_1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
    Friend WithEvents txt_Line As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Article As PSMGlobal.SelectLabelText
    Friend WithEvents cmd_PRINT As PSMGlobal.PeaceButton
    Friend WithEvents txt_OrderNoSeq As PSMGlobal.SelectLabelText
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckTesting1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckTesting2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents tit_Use As PSMGlobal.PeaceLabel
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckFitting1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckFitting2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckTesting3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckFitting3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_DateFitting As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_DateTesting As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents txt_RemarkOther As PSMGlobal.SelectLabelText
End Class
