<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD1320A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD1320A))
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
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_PRINT = New PSMGlobal.PeaceButton(Me.components)
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdSite = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Remark = New PSMGlobal.SelectLabelText()
        Me.txt_DateDelivery = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_InchargeRequest = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_DateTest = New PSMGlobal.SelectPeaceCalSin()
        Me.txt_TestOrder = New PSMGlobal.SelectLabelText()
        Me.Tlp_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New PSMGlobal.PeaceSplitContainer()
        Me.vS1 = New PSMGlobal.PeaceFarpoint()
        Me.vS1_Sheet1 = New FarPoint.Win.Spread.SheetView()
        Me.Panel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.chk_TestStatus2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_TestStatus1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.PeaceLabel24 = New PSMGlobal.PeaceLabel(Me.components)
        Me.chk_TestStatus3 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_TestStatus4 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.chk_TestStatus5 = New PSMGlobal.PeaceRadioButton(Me.components)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Tlp_1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
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
        Me.cmd_OK.Location = New System.Drawing.Point(806, 1)
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
        Me.cmd_DEL.Location = New System.Drawing.Point(2, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(141, 35)
        Me.cmd_DEL.TabIndex = 2
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(948, 1)
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
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Controls.Add(Me.cmd_AttachID)
        Me.Frame4.Controls.Add(Me.cmd_PRINT)
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Data = ""
        Me.Frame4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame4.Location = New System.Drawing.Point(3, 600)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(1092, 39)
        Me.Frame4.TabIndex = 2
        Me.Frame4.Tag = ""
        '
        'cmd_AttachID
        '
        Me.cmd_AttachID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_AttachID.Appearance.Options.UseFont = True
        Me.cmd_AttachID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_AttachID.Code = Nothing
        Me.cmd_AttachID.Data = Nothing
        Me.cmd_AttachID.Image = CType(resources.GetObject("cmd_AttachID.Image"), System.Drawing.Image)
        Me.cmd_AttachID.ImageAlign = 16
        Me.cmd_AttachID.Location = New System.Drawing.Point(295, 2)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 3
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
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
        Me.cmd_PRINT.Location = New System.Drawing.Point(436, 2)
        Me.cmd_PRINT.Name = "cmd_PRINT"
        Me.cmd_PRINT.Size = New System.Drawing.Size(138, 35)
        Me.cmd_PRINT.TabIndex = 4
        Me.cmd_PRINT.TabStop = False
        Me.cmd_PRINT.Tag = ""
        Me.cmd_PRINT.Text = "PRINT(&P)"
        Me.cmd_PRINT.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.PeaceLabel24)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_CustomerCode)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_cdSite)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_Remark)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_DateDelivery)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_InchargeRequest)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_DateTest)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_TestOrder)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1092, 106)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = ""
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = ""
        Me.txt_CustomerCode.ButtonTitle = "Customer"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 1
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(1, 4)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(291, 24)
        Me.txt_CustomerCode.TabIndex = 1
        Me.txt_CustomerCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_CustomerCode.TextBoxAutoComplete = False
        Me.txt_CustomerCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.TextBoxFont = New System.Drawing.Font("Tahoma", 8.5!)
        Me.txt_CustomerCode.TextEnabled = True
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
        Me.txt_cdSite.ButtonEnabled = True
        Me.txt_cdSite.ButtonFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_cdSite.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdSite.ButtonName = ""
        Me.txt_cdSite.ButtonTitle = "Site"
        Me.txt_cdSite.Code = ""
        Me.txt_cdSite.Data = ""
        Me.txt_cdSite.DataDecimal = 0
        Me.txt_cdSite.DataLen = 0
        Me.txt_cdSite.DataValue = 1
        Me.txt_cdSite.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdSite.Location = New System.Drawing.Point(1, 29)
        Me.txt_cdSite.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSite.Name = "txt_cdSite"
        Me.txt_cdSite.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSite.Size = New System.Drawing.Size(291, 24)
        Me.txt_cdSite.TabIndex = 2
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
        Me.txt_Remark.Layoutpercent = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.txt_Remark.Location = New System.Drawing.Point(294, 30)
        Me.txt_Remark.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Remark.Size = New System.Drawing.Size(602, 75)
        Me.txt_Remark.TabIndex = 0
        Me.txt_Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Remark.TextBoxAutoComplete = False
        Me.txt_Remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_Remark.TextEnabled = True
        Me.txt_Remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextMaxLength = 32767
        Me.txt_Remark.TextMultiLine = True
        Me.txt_Remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Remark.UseSendTab = True
        '
        'txt_DateDelivery
        '
        Me.txt_DateDelivery.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateDelivery.ButtonEnabled = True
        Me.txt_DateDelivery.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateDelivery.ButtonName = Nothing
        Me.txt_DateDelivery.ButtonTitle = "Date Delivery"
        Me.txt_DateDelivery.Code = ""
        Me.txt_DateDelivery.Data = "20150101"
        Me.txt_DateDelivery.DataDecimal = 0
        Me.txt_DateDelivery.DataLen = 0
        Me.txt_DateDelivery.DataValue = 0
        Me.txt_DateDelivery.FormatDecimal = 0
        Me.txt_DateDelivery.FormatValue = False
        Me.txt_DateDelivery.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateDelivery.Location = New System.Drawing.Point(588, 3)
        Me.txt_DateDelivery.Margin = New System.Windows.Forms.Padding(1, 1, 138, 1)
        Me.txt_DateDelivery.Name = "txt_DateDelivery"
        Me.txt_DateDelivery.Size = New System.Drawing.Size(307, 24)
        Me.txt_DateDelivery.TabIndex = 6
        Me.txt_DateDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateDelivery.TextBoxAutoComplete = False
        Me.txt_DateDelivery.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateDelivery.TextEnabled = True
        Me.txt_DateDelivery.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateDelivery.TextMaxLength = 32767
        Me.txt_DateDelivery.TextMultiLine = True
        Me.txt_DateDelivery.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        '
        'txt_InchargeRequest
        '
        Me.txt_InchargeRequest.BackYesno = False
        Me.txt_InchargeRequest.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeRequest.ButtonEnabled = True
        Me.txt_InchargeRequest.ButtonFont = Nothing
        Me.txt_InchargeRequest.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeRequest.ButtonName = "Const_EMP81"
        Me.txt_InchargeRequest.ButtonTitle = "In-Charge"
        Me.txt_InchargeRequest.Code = ""
        Me.txt_InchargeRequest.Data = ""
        Me.txt_InchargeRequest.DataDecimal = 0
        Me.txt_InchargeRequest.DataLen = 0
        Me.txt_InchargeRequest.DataValue = 1
        Me.txt_InchargeRequest.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_InchargeRequest.Location = New System.Drawing.Point(1, 54)
        Me.txt_InchargeRequest.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeRequest.Name = "txt_InchargeRequest"
        Me.txt_InchargeRequest.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeRequest.Size = New System.Drawing.Size(291, 24)
        Me.txt_InchargeRequest.TabIndex = 3
        Me.txt_InchargeRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeRequest.TextBoxAutoComplete = False
        Me.txt_InchargeRequest.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeRequest.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_InchargeRequest.TextEnabled = True
        Me.txt_InchargeRequest.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeRequest.TextMaxLength = 32767
        Me.txt_InchargeRequest.TextMultiLine = False
        Me.txt_InchargeRequest.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeRequest.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeRequest.UseSendTab = True
        '
        'txt_DateTest
        '
        Me.txt_DateTest.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DateTest.ButtonEnabled = True
        Me.txt_DateTest.ButtonFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_DateTest.ButtonName = Nothing
        Me.txt_DateTest.ButtonTitle = "Date Test"
        Me.txt_DateTest.Code = ""
        Me.txt_DateTest.Data = "20150101"
        Me.txt_DateTest.DataDecimal = 0
        Me.txt_DateTest.DataLen = 0
        Me.txt_DateTest.DataValue = 0
        Me.txt_DateTest.FormatDecimal = 0
        Me.txt_DateTest.FormatValue = False
        Me.txt_DateTest.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_DateTest.Location = New System.Drawing.Point(295, 4)
        Me.txt_DateTest.Margin = New System.Windows.Forms.Padding(1, 1, 138, 1)
        Me.txt_DateTest.Name = "txt_DateTest"
        Me.txt_DateTest.Size = New System.Drawing.Size(289, 24)
        Me.txt_DateTest.TabIndex = 5
        Me.txt_DateTest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_DateTest.TextBoxAutoComplete = False
        Me.txt_DateTest.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DateTest.TextEnabled = True
        Me.txt_DateTest.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DateTest.TextMaxLength = 32767
        Me.txt_DateTest.TextMultiLine = True
        Me.txt_DateTest.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
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
        Me.txt_TestOrder.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_TestOrder.LableEnabled = True
        Me.txt_TestOrder.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_TestOrder.LableForeColor = System.Drawing.Color.Black
        Me.txt_TestOrder.LableTitle = "Test Order"
        Me.txt_TestOrder.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_TestOrder.Location = New System.Drawing.Point(1, 80)
        Me.txt_TestOrder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TestOrder.Name = "txt_TestOrder"
        Me.txt_TestOrder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TestOrder.Size = New System.Drawing.Size(291, 24)
        Me.txt_TestOrder.TabIndex = 4
        Me.txt_TestOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TestOrder.TextBoxAutoComplete = False
        Me.txt_TestOrder.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TestOrder.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txt_TestOrder.TextEnabled = True
        Me.txt_TestOrder.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TestOrder.TextMaxLength = 32767
        Me.txt_TestOrder.TextMultiLine = False
        Me.txt_TestOrder.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TestOrder.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TestOrder.UseSendTab = True
        '
        'Tlp_1
        '
        Me.Tlp_1.ColumnCount = 1
        Me.Tlp_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.Controls.Add(Me.Frame4, 0, 2)
        Me.Tlp_1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.Tlp_1.Controls.Add(Me.SplitContainer1, 0, 1)
        Me.Tlp_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tlp_1.Location = New System.Drawing.Point(0, 0)
        Me.Tlp_1.Name = "Tlp_1"
        Me.Tlp_1.RowCount = 3
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.Tlp_1.Size = New System.Drawing.Size(1098, 642)
        Me.Tlp_1.TabIndex = 103
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 115)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Panel1Collapsed = True
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.vS1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1092, 479)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.TabIndex = 3
        '
        'vS1
        '
        Me.vS1.AccessibleDescription = "Vs2, Sheet1, Row 0, Column 0, "
        Me.vS1.AllowEditorReservedLocations = False
        Me.vS1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.vS1.CopyPasteChk = True
        Me.vS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.vS1.FocusRenderer = EnhancedFocusIndicatorRenderer1
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
        Me.vS1.HorizontalScrollBar.TabIndex = 26
        Me.vS1.InsChk = True
        Me.vS1.Location = New System.Drawing.Point(0, 0)
        Me.vS1.Name = "vS1"
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
        Me.vS1.NamedStyles.AddRange(New FarPoint.Win.Spread.NamedStyle() {NamedStyle1, NamedStyle2, NamedStyle3, NamedStyle4, NamedStyle5, NamedStyle6})
        Me.vS1.ReportName = Nothing
        Me.vS1.Sheets.AddRange(New FarPoint.Win.Spread.SheetView() {Me.vS1_Sheet1})
        Me.vS1.Size = New System.Drawing.Size(1092, 479)
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
        Me.vS1.Skin = SpreadSkin1
        Me.vS1.SpreadWjob = 0
        Me.vS1.TabIndex = 2
        Me.vS1.TabStop = False
        Me.vS1.TabStrip.DefaultSheetTab.BackColor = System.Drawing.Color.White
        Me.vS1.TabStrip.DefaultSheetTab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.vS1.VerticalScrollBar.TabIndex = 27
        '
        'vS1_Sheet1
        '
        Me.vS1_Sheet1.Reset()
        Me.vS1_Sheet1.SheetName = "Sheet1"
        'Formulas and custom names must be loaded with R1C1 reference style
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1
        Me.vS1_Sheet1.ColumnCount = 29
        Me.vS1_Sheet1.RowCount = 10
        Me.vS1_Sheet1.ActiveSkin = New FarPoint.Win.Spread.SheetSkin("SheetSkin1", System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(172, Byte), Integer)), FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer)), System.Drawing.Color.White, System.Drawing.Color.White, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.White, System.Drawing.SystemColors.ButtonFace, False, False, False, True, True, True, False, True, "RowHeaderDefault", "RowHeaderDefault", "RowHeaderDefault", "DataAreaDefault", "RowHeaderDefault")
        Me.vS1_Sheet1.ColumnFooter.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.ColumnFooter.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnFooter.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.ColumnFooterSheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.Cells.Get(0, 0).Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.ColumnHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ColumnHeader.Rows.Get(0).Height = 25.0!
        Me.vS1_Sheet1.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.DefaultStyle.ForeColor = System.Drawing.Color.Black
        Me.vS1_Sheet1.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.DefaultStyle.Parent = "DataAreaDefault"
        Me.vS1_Sheet1.DefaultStyle.VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center
        Me.vS1_Sheet1.FilterBar.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.FilterBar.DefaultStyle.Parent = "FilterBarDefaultEnhanced"
        Me.vS1_Sheet1.FilterBarHeaderStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.FilterBarHeaderStyle.Parent = "RowHeaderDefaultEnhanced"
        Me.vS1_Sheet1.GroupBarInfo.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vS1_Sheet1.NullFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.vS1_Sheet1.OperationMode = FarPoint.Win.Spread.OperationMode.SingleSelect
        Me.vS1_Sheet1.RowHeader.Columns.Default.Resizable = False
        Me.vS1_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.RowHeader.DefaultStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.RowHeader.DefaultStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.RowHeader.DefaultStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.Rows.Default.Height = 22.0!
        Me.vS1_Sheet1.SelectionPolicy = FarPoint.Win.Spread.Model.SelectionPolicy.[Single]
        Me.vS1_Sheet1.SelectionStyle = FarPoint.Win.Spread.SelectionStyles.SelectionColors
        Me.vS1_Sheet1.SelectionUnit = FarPoint.Win.Spread.Model.SelectionUnit.Row
        Me.vS1_Sheet1.SheetCornerStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.vS1_Sheet1.SheetCornerStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.vS1_Sheet1.SheetCornerStyle.ForeColor = System.Drawing.Color.White
        Me.vS1_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red
        Me.vS1_Sheet1.SheetCornerStyle.Parent = "RowHeaderDefault"
        Me.vS1_Sheet1.SheetCornerStyle.VisualStyles = FarPoint.Win.VisualStyles.Off
        Me.vS1_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.Panel5.ColumnCount = 2
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.91398!))
        Me.Panel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.08602!))
        Me.Panel5.Controls.Add(Me.chk_TestStatus1, 0, 0)
        Me.Panel5.Controls.Add(Me.chk_TestStatus2, 1, 0)
        Me.Panel5.Controls.Add(Me.chk_TestStatus3, 0, 1)
        Me.Panel5.Controls.Add(Me.chk_TestStatus4, 1, 1)
        Me.Panel5.Controls.Add(Me.chk_TestStatus5, 0, 2)
        Me.Panel5.Location = New System.Drawing.Point(898, 30)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.RowCount = 3
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.Panel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Panel5.Size = New System.Drawing.Size(191, 73)
        Me.Panel5.TabIndex = 110
        '
        'chk_TestStatus2
        '
        Me.chk_TestStatus2.AutoSize = True
        Me.chk_TestStatus2.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_TestStatus2.Location = New System.Drawing.Point(109, 3)
        Me.chk_TestStatus2.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_TestStatus2.Name = "chk_TestStatus2"
        Me.chk_TestStatus2.Size = New System.Drawing.Size(79, 16)
        Me.chk_TestStatus2.TabIndex = 3
        Me.chk_TestStatus2.Text = "Complete"
        Me.chk_TestStatus2.UseVisualStyleBackColor = True
        '
        'chk_TestStatus1
        '
        Me.chk_TestStatus1.AutoSize = True
        Me.chk_TestStatus1.Checked = True
        Me.chk_TestStatus1.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_TestStatus1.Location = New System.Drawing.Point(3, 3)
        Me.chk_TestStatus1.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_TestStatus1.Name = "chk_TestStatus1"
        Me.chk_TestStatus1.Size = New System.Drawing.Size(98, 16)
        Me.chk_TestStatus1.TabIndex = 2
        Me.chk_TestStatus1.Text = "Not Approval"
        Me.chk_TestStatus1.UseVisualStyleBackColor = True
        '
        'PeaceLabel24
        '
        Me.PeaceLabel24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeaceLabel24.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel24.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel24.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel24.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel24.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel24.Code = ""
        Me.PeaceLabel24.Data = ""
        Me.PeaceLabel24.DTDec = 0
        Me.PeaceLabel24.DTLen = 0
        Me.PeaceLabel24.DTValue = 0
        Me.PeaceLabel24.Location = New System.Drawing.Point(898, 3)
        Me.PeaceLabel24.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceLabel24.Name = "PeaceLabel24"
        Me.PeaceLabel24.NoClear = False
        Me.PeaceLabel24.Size = New System.Drawing.Size(191, 24)
        Me.PeaceLabel24.TabIndex = 259
        Me.PeaceLabel24.Tag = ""
        Me.PeaceLabel24.Text = "Check Status"
        Me.PeaceLabel24.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'chk_TestStatus3
        '
        Me.chk_TestStatus3.AutoSize = True
        Me.chk_TestStatus3.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_TestStatus3.Location = New System.Drawing.Point(3, 24)
        Me.chk_TestStatus3.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_TestStatus3.Name = "chk_TestStatus3"
        Me.chk_TestStatus3.Size = New System.Drawing.Size(76, 16)
        Me.chk_TestStatus3.TabIndex = 2
        Me.chk_TestStatus3.Text = "Approval"
        Me.chk_TestStatus3.UseVisualStyleBackColor = True
        '
        'chk_TestStatus4
        '
        Me.chk_TestStatus4.AutoSize = True
        Me.chk_TestStatus4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.chk_TestStatus4.Location = New System.Drawing.Point(109, 24)
        Me.chk_TestStatus4.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_TestStatus4.Name = "chk_TestStatus4"
        Me.chk_TestStatus4.Size = New System.Drawing.Size(64, 16)
        Me.chk_TestStatus4.TabIndex = 2
        Me.chk_TestStatus4.Text = "Cancel"
        Me.chk_TestStatus4.UseVisualStyleBackColor = True
        '
        'chk_TestStatus5
        '
        Me.chk_TestStatus5.AutoSize = True
        Me.chk_TestStatus5.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.chk_TestStatus5.Location = New System.Drawing.Point(3, 45)
        Me.chk_TestStatus5.Margin = New System.Windows.Forms.Padding(2)
        Me.chk_TestStatus5.Name = "chk_TestStatus5"
        Me.chk_TestStatus5.Size = New System.Drawing.Size(70, 17)
        Me.chk_TestStatus5.TabIndex = 2
        Me.chk_TestStatus5.Text = "Pending"
        Me.chk_TestStatus5.UseVisualStyleBackColor = True
        '
        'ISUD1320A
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1098, 642)
        Me.Controls.Add(Me.Tlp_1)
        Me.KeyPreview = True
        Me.Name = "ISUD1320A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TESTING ORDER PROCESSING (ISUD1320A)"
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Tlp_1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.vS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vS1_Sheet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents txt_TestOrder As PSMGlobal.SelectLabelText
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_DateTest As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents cmd_PRINT As PSMGlobal.PeaceButton
    Friend WithEvents txt_InchargeRequest As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DateDelivery As PSMGlobal.SelectPeaceCalSin
    Friend WithEvents Tlp_1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents txt_cdSite As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
    Public WithEvents vS1 As PSMGlobal.PeaceFarpoint
    Friend WithEvents vS1_Sheet1 As FarPoint.Win.Spread.SheetView
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents SplitContainer1 As PSMGlobal.PeaceSplitContainer
    Friend WithEvents Panel5 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents chk_TestStatus1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_TestStatus2 As PSMGlobal.PeaceRadioButton
    Public WithEvents PeaceLabel24 As PSMGlobal.PeaceLabel
    Friend WithEvents chk_TestStatus3 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_TestStatus4 As PSMGlobal.PeaceRadioButton
    Friend WithEvents chk_TestStatus5 As PSMGlobal.PeaceRadioButton
End Class
