<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7231T
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7231T))
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Print = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_SizeRangeTool = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_ColorName = New PSMGlobal.SelectLabelText()
        Me.txt_Height = New PSMGlobal.SelectLabelText()
        Me.txt_Sizename = New PSMGlobal.SelectLabelText()
        Me.txt_Width = New PSMGlobal.SelectLabelText()
        Me.txt_cdLargeGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MaterialForeign1 = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialSimple = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialName = New PSMGlobal.SelectLabelText()
        Me.txt_cdSemiGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdDetailGroupMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_MaterialForeign2 = New PSMGlobal.SelectLabelText()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.rad_CheckMarketType2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckMarketType1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.PeaceLabel3 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_Check1 = New PSMGlobal.SelectLabelText()
        Me.txt_Check3 = New PSMGlobal.SelectLabelText()
        Me.txt_Check2 = New PSMGlobal.SelectLabelText()
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdDepartment = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_DevelopmentCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_AccountCode = New PSMGlobal.SelectLabelText()
        Me.txt_ImportCode = New PSMGlobal.SelectLabelText()
        Me.txt_MaterialCode = New PSMGlobal.SelectLabelText()
        Me.Tlp_1 = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel2.SuspendLayout()
        Me.Tlp_1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Code = ""
        Me.Frame4.Controls.Add(Me.cmd_AttachID)
        Me.Frame4.Controls.Add(Me.cmd_Print)
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Data = ""
        Me.Frame4.Location = New System.Drawing.Point(3, 463)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(927, 37)
        Me.Frame4.TabIndex = 0
        Me.Frame4.Tag = ""
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
        Me.cmd_AttachID.Location = New System.Drawing.Point(249, 0)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 3
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
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
        Me.cmd_Print.Image = Global.PSMGlobal.My.Resources.Resources.PrintViaPDF_16x16
        Me.cmd_Print.ImageAlign = 0
        Me.cmd_Print.Location = New System.Drawing.Point(393, 0)
        Me.cmd_Print.Name = "cmd_Print"
        Me.cmd_Print.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Print.TabIndex = 4
        Me.cmd_Print.Text = "BARCODE(&P)"
        Me.cmd_Print.UseVisualStyleBackColor = False
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_DEL.ButtonTitle = Nothing
        Me.cmd_DEL.Code = ""
        Me.cmd_DEL.Data = ""
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = 0
        Me.cmd_DEL.Location = New System.Drawing.Point(3, -1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(135, 35)
        Me.cmd_DEL.TabIndex = 2
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
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = ""
        Me.cmd_Cancel.Data = ""
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.Close_16x16
        Me.cmd_Cancel.ImageAlign = 0
        Me.cmd_Cancel.Location = New System.Drawing.Point(786, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(138, 33)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Tag = ""
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = ""
        Me.cmd_OK.Data = ""
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.Save_16x16
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(647, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(138, 34)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Tag = ""
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'PeacePanel3
        '
        Me.PeacePanel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PeacePanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.txt_SizeRangeTool)
        Me.PeacePanel3.Controls.Add(Me.txt_ColorName)
        Me.PeacePanel3.Controls.Add(Me.txt_Height)
        Me.PeacePanel3.Controls.Add(Me.txt_Sizename)
        Me.PeacePanel3.Controls.Add(Me.txt_Width)
        Me.PeacePanel3.Controls.Add(Me.txt_cdLargeGroupMaterial)
        Me.PeacePanel3.Controls.Add(Me.txt_MaterialForeign1)
        Me.PeacePanel3.Controls.Add(Me.txt_MaterialSimple)
        Me.PeacePanel3.Controls.Add(Me.txt_MaterialName)
        Me.PeacePanel3.Controls.Add(Me.txt_cdSemiGroupMaterial)
        Me.PeacePanel3.Controls.Add(Me.txt_cdDetailGroupMaterial)
        Me.PeacePanel3.Controls.Add(Me.txt_MaterialForeign2)
        Me.PeacePanel3.Controls.Add(Me.PeacePanel1)
        Me.PeacePanel3.Controls.Add(Me.PeaceLabel3)
        Me.PeacePanel3.Controls.Add(Me.txt_Check1)
        Me.PeacePanel3.Controls.Add(Me.txt_Check3)
        Me.PeacePanel3.Controls.Add(Me.txt_Check2)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(3, 65)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(927, 392)
        Me.PeacePanel3.TabIndex = 1
        Me.PeacePanel3.Tag = ""
        '
        'txt_SizeRangeTool
        '
        Me.txt_SizeRangeTool.BackYesno = False
        Me.txt_SizeRangeTool.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_SizeRangeTool.ButtonEnabled = True
        Me.txt_SizeRangeTool.ButtonFont = Nothing
        Me.txt_SizeRangeTool.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeTool.ButtonName = ""
        Me.txt_SizeRangeTool.ButtonTitle = "Size Range"
        Me.txt_SizeRangeTool.Code = ""
        Me.txt_SizeRangeTool.Data = ""
        Me.txt_SizeRangeTool.DataDecimal = 0
        Me.txt_SizeRangeTool.DataLen = 0
        Me.txt_SizeRangeTool.DataValue = 0
        Me.txt_SizeRangeTool.Enabled = False
        Me.txt_SizeRangeTool.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_SizeRangeTool.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_SizeRangeTool.Location = New System.Drawing.Point(618, 135)
        Me.txt_SizeRangeTool.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_SizeRangeTool.Name = "txt_SizeRangeTool"
        Me.txt_SizeRangeTool.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_SizeRangeTool.Size = New System.Drawing.Size(302, 24)
        Me.txt_SizeRangeTool.TabIndex = 51
        Me.txt_SizeRangeTool.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_SizeRangeTool.TextBoxAutoComplete = True
        Me.txt_SizeRangeTool.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeTool.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_SizeRangeTool.TextEnabled = True
        Me.txt_SizeRangeTool.TextForeColor = System.Drawing.Color.Empty
        Me.txt_SizeRangeTool.TextMaxLength = 32767
        Me.txt_SizeRangeTool.TextMultiLine = False
        Me.txt_SizeRangeTool.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_SizeRangeTool.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_SizeRangeTool.UseSendTab = True
        '
        'txt_ColorName
        '
        Me.txt_ColorName.BackYesno = False
        Me.txt_ColorName.ButtonTitle = Nothing
        Me.txt_ColorName.Code = ""
        Me.txt_ColorName.Data = ""
        Me.txt_ColorName.DataDecimal = 0
        Me.txt_ColorName.DataLen = 0
        Me.txt_ColorName.DataValue = 0
        Me.txt_ColorName.Enabled = False
        Me.txt_ColorName.FormatDecimal = 0
        Me.txt_ColorName.FormatValue = False
        Me.txt_ColorName.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_ColorName.LableEnabled = True
        Me.txt_ColorName.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ColorName.LableForeColor = System.Drawing.Color.Black
        Me.txt_ColorName.LableTitle = "Color Name"
        Me.txt_ColorName.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_ColorName.Location = New System.Drawing.Point(310, 135)
        Me.txt_ColorName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ColorName.Name = "txt_ColorName"
        Me.txt_ColorName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ColorName.Size = New System.Drawing.Size(305, 24)
        Me.txt_ColorName.TabIndex = 11
        Me.txt_ColorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ColorName.TextBoxAutoComplete = False
        Me.txt_ColorName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_ColorName.TextEnabled = True
        Me.txt_ColorName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_ColorName.TextMaxLength = 32767
        Me.txt_ColorName.TextMultiLine = False
        Me.txt_ColorName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ColorName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ColorName.UseSendTab = True
        '
        'txt_Height
        '
        Me.txt_Height.BackYesno = False
        Me.txt_Height.ButtonTitle = Nothing
        Me.txt_Height.Code = ""
        Me.txt_Height.Data = ""
        Me.txt_Height.DataDecimal = 0
        Me.txt_Height.DataLen = 0
        Me.txt_Height.DataValue = 0
        Me.txt_Height.Enabled = False
        Me.txt_Height.FormatDecimal = 0
        Me.txt_Height.FormatValue = False
        Me.txt_Height.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_Height.LableEnabled = True
        Me.txt_Height.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Height.LableForeColor = System.Drawing.Color.Black
        Me.txt_Height.LableTitle = "Height"
        Me.txt_Height.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_Height.Location = New System.Drawing.Point(310, 109)
        Me.txt_Height.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Height.Name = "txt_Height"
        Me.txt_Height.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Height.Size = New System.Drawing.Size(305, 24)
        Me.txt_Height.TabIndex = 9
        Me.txt_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Height.TextBoxAutoComplete = False
        Me.txt_Height.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Height.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_Height.TextEnabled = True
        Me.txt_Height.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Height.TextMaxLength = 32767
        Me.txt_Height.TextMultiLine = False
        Me.txt_Height.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Height.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Height.UseSendTab = True
        '
        'txt_Sizename
        '
        Me.txt_Sizename.BackYesno = False
        Me.txt_Sizename.ButtonTitle = Nothing
        Me.txt_Sizename.Code = ""
        Me.txt_Sizename.Data = ""
        Me.txt_Sizename.DataDecimal = 0
        Me.txt_Sizename.DataLen = 0
        Me.txt_Sizename.DataValue = 0
        Me.txt_Sizename.Enabled = False
        Me.txt_Sizename.FormatDecimal = 0
        Me.txt_Sizename.FormatValue = False
        Me.txt_Sizename.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_Sizename.LableEnabled = True
        Me.txt_Sizename.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Sizename.LableForeColor = System.Drawing.Color.Black
        Me.txt_Sizename.LableTitle = "Size"
        Me.txt_Sizename.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_Sizename.Location = New System.Drawing.Point(3, 135)
        Me.txt_Sizename.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Sizename.Name = "txt_Sizename"
        Me.txt_Sizename.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Sizename.Size = New System.Drawing.Size(305, 24)
        Me.txt_Sizename.TabIndex = 10
        Me.txt_Sizename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Sizename.TextBoxAutoComplete = False
        Me.txt_Sizename.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Sizename.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_Sizename.TextEnabled = True
        Me.txt_Sizename.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Sizename.TextMaxLength = 32767
        Me.txt_Sizename.TextMultiLine = False
        Me.txt_Sizename.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Sizename.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Sizename.UseSendTab = True
        '
        'txt_Width
        '
        Me.txt_Width.BackYesno = False
        Me.txt_Width.ButtonTitle = Nothing
        Me.txt_Width.Code = ""
        Me.txt_Width.Data = ""
        Me.txt_Width.DataDecimal = 0
        Me.txt_Width.DataLen = 0
        Me.txt_Width.DataValue = 0
        Me.txt_Width.Enabled = False
        Me.txt_Width.FormatDecimal = 0
        Me.txt_Width.FormatValue = False
        Me.txt_Width.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_Width.LableEnabled = True
        Me.txt_Width.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Width.LableForeColor = System.Drawing.Color.Black
        Me.txt_Width.LableTitle = "Width"
        Me.txt_Width.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_Width.Location = New System.Drawing.Point(3, 109)
        Me.txt_Width.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Width.Name = "txt_Width"
        Me.txt_Width.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Width.Size = New System.Drawing.Size(305, 24)
        Me.txt_Width.TabIndex = 8
        Me.txt_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt_Width.TextBoxAutoComplete = False
        Me.txt_Width.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Width.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_Width.TextEnabled = True
        Me.txt_Width.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Width.TextMaxLength = 32767
        Me.txt_Width.TextMultiLine = False
        Me.txt_Width.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Width.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Width.UseSendTab = True
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
        Me.txt_cdLargeGroupMaterial.Enabled = False
        Me.txt_cdLargeGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdLargeGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdLargeGroupMaterial.Location = New System.Drawing.Point(5, 6)
        Me.txt_cdLargeGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdLargeGroupMaterial.Name = "txt_cdLargeGroupMaterial"
        Me.txt_cdLargeGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdLargeGroupMaterial.Size = New System.Drawing.Size(307, 24)
        Me.txt_cdLargeGroupMaterial.TabIndex = 0
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
        'txt_MaterialForeign1
        '
        Me.txt_MaterialForeign1.BackYesno = False
        Me.txt_MaterialForeign1.ButtonTitle = Nothing
        Me.txt_MaterialForeign1.Code = ""
        Me.txt_MaterialForeign1.Data = ""
        Me.txt_MaterialForeign1.DataDecimal = 0
        Me.txt_MaterialForeign1.DataLen = 0
        Me.txt_MaterialForeign1.DataValue = 0
        Me.txt_MaterialForeign1.Enabled = False
        Me.txt_MaterialForeign1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialForeign1.FormatDecimal = 0
        Me.txt_MaterialForeign1.FormatValue = False
        Me.txt_MaterialForeign1.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_MaterialForeign1.LableEnabled = True
        Me.txt_MaterialForeign1.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialForeign1.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialForeign1.LableTitle = "Vietnamese Name"
        Me.txt_MaterialForeign1.Layoutpercent = New Decimal(New Integer() {206, 0, 0, 196608})
        Me.txt_MaterialForeign1.Location = New System.Drawing.Point(5, 56)
        Me.txt_MaterialForeign1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialForeign1.Name = "txt_MaterialForeign1"
        Me.txt_MaterialForeign1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialForeign1.Size = New System.Drawing.Size(611, 24)
        Me.txt_MaterialForeign1.TabIndex = 5
        Me.txt_MaterialForeign1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialForeign1.TextBoxAutoComplete = False
        Me.txt_MaterialForeign1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialForeign1.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_MaterialForeign1.TextEnabled = True
        Me.txt_MaterialForeign1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialForeign1.TextMaxLength = 32767
        Me.txt_MaterialForeign1.TextMultiLine = False
        Me.txt_MaterialForeign1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialForeign1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialForeign1.UseSendTab = True
        '
        'txt_MaterialSimple
        '
        Me.txt_MaterialSimple.BackYesno = False
        Me.txt_MaterialSimple.ButtonTitle = Nothing
        Me.txt_MaterialSimple.Code = ""
        Me.txt_MaterialSimple.Data = ""
        Me.txt_MaterialSimple.DataDecimal = 0
        Me.txt_MaterialSimple.DataLen = 0
        Me.txt_MaterialSimple.DataValue = 0
        Me.txt_MaterialSimple.Enabled = False
        Me.txt_MaterialSimple.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialSimple.FormatDecimal = 3
        Me.txt_MaterialSimple.FormatValue = True
        Me.txt_MaterialSimple.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_MaterialSimple.LableEnabled = True
        Me.txt_MaterialSimple.LableFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialSimple.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialSimple.LableTitle = "Simple Name"
        Me.txt_MaterialSimple.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_MaterialSimple.Location = New System.Drawing.Point(618, 32)
        Me.txt_MaterialSimple.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialSimple.Name = "txt_MaterialSimple"
        Me.txt_MaterialSimple.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialSimple.Size = New System.Drawing.Size(303, 22)
        Me.txt_MaterialSimple.TabIndex = 4
        Me.txt_MaterialSimple.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialSimple.TextBoxAutoComplete = False
        Me.txt_MaterialSimple.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialSimple.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MaterialSimple.TextEnabled = True
        Me.txt_MaterialSimple.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialSimple.TextMaxLength = 32767
        Me.txt_MaterialSimple.TextMultiLine = False
        Me.txt_MaterialSimple.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialSimple.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialSimple.UseSendTab = True
        '
        'txt_MaterialName
        '
        Me.txt_MaterialName.BackYesno = False
        Me.txt_MaterialName.ButtonTitle = Nothing
        Me.txt_MaterialName.Code = ""
        Me.txt_MaterialName.Data = ""
        Me.txt_MaterialName.DataDecimal = 0
        Me.txt_MaterialName.DataLen = 0
        Me.txt_MaterialName.DataValue = 0
        Me.txt_MaterialName.Enabled = False
        Me.txt_MaterialName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialName.FormatDecimal = 0
        Me.txt_MaterialName.FormatValue = False
        Me.txt_MaterialName.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_MaterialName.LableEnabled = True
        Me.txt_MaterialName.LableFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialName.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialName.LableTitle = "Prod Name"
        Me.txt_MaterialName.Layoutpercent = New Decimal(New Integer() {206, 0, 0, 196608})
        Me.txt_MaterialName.Location = New System.Drawing.Point(5, 32)
        Me.txt_MaterialName.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialName.Size = New System.Drawing.Size(611, 22)
        Me.txt_MaterialName.TabIndex = 3
        Me.txt_MaterialName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialName.TextBoxAutoComplete = False
        Me.txt_MaterialName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MaterialName.TextEnabled = True
        Me.txt_MaterialName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialName.TextMaxLength = 32767
        Me.txt_MaterialName.TextMultiLine = False
        Me.txt_MaterialName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialName.UseSendTab = True
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
        Me.txt_cdSemiGroupMaterial.DataValue = 1
        Me.txt_cdSemiGroupMaterial.Enabled = False
        Me.txt_cdSemiGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdSemiGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdSemiGroupMaterial.Location = New System.Drawing.Point(312, 7)
        Me.txt_cdSemiGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdSemiGroupMaterial.Name = "txt_cdSemiGroupMaterial"
        Me.txt_cdSemiGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdSemiGroupMaterial.Size = New System.Drawing.Size(304, 24)
        Me.txt_cdSemiGroupMaterial.TabIndex = 1
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
        Me.txt_cdDetailGroupMaterial.Enabled = False
        Me.txt_cdDetailGroupMaterial.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdDetailGroupMaterial.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdDetailGroupMaterial.Location = New System.Drawing.Point(618, 7)
        Me.txt_cdDetailGroupMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDetailGroupMaterial.Name = "txt_cdDetailGroupMaterial"
        Me.txt_cdDetailGroupMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDetailGroupMaterial.Size = New System.Drawing.Size(304, 24)
        Me.txt_cdDetailGroupMaterial.TabIndex = 2
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
        'txt_MaterialForeign2
        '
        Me.txt_MaterialForeign2.BackYesno = False
        Me.txt_MaterialForeign2.ButtonTitle = Nothing
        Me.txt_MaterialForeign2.Code = ""
        Me.txt_MaterialForeign2.Data = ""
        Me.txt_MaterialForeign2.DataDecimal = 0
        Me.txt_MaterialForeign2.DataLen = 0
        Me.txt_MaterialForeign2.DataValue = 0
        Me.txt_MaterialForeign2.Enabled = False
        Me.txt_MaterialForeign2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialForeign2.FormatDecimal = 0
        Me.txt_MaterialForeign2.FormatValue = False
        Me.txt_MaterialForeign2.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_MaterialForeign2.LableEnabled = True
        Me.txt_MaterialForeign2.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialForeign2.LableForeColor = System.Drawing.SystemColors.ControlText
        Me.txt_MaterialForeign2.LableTitle = "Korean Name"
        Me.txt_MaterialForeign2.Layoutpercent = New Decimal(New Integer() {206, 0, 0, 196608})
        Me.txt_MaterialForeign2.Location = New System.Drawing.Point(5, 82)
        Me.txt_MaterialForeign2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialForeign2.Name = "txt_MaterialForeign2"
        Me.txt_MaterialForeign2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialForeign2.Size = New System.Drawing.Size(611, 24)
        Me.txt_MaterialForeign2.TabIndex = 7
        Me.txt_MaterialForeign2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialForeign2.TextBoxAutoComplete = False
        Me.txt_MaterialForeign2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialForeign2.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_MaterialForeign2.TextEnabled = True
        Me.txt_MaterialForeign2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MaterialForeign2.TextMaxLength = 32767
        Me.txt_MaterialForeign2.TextMultiLine = False
        Me.txt_MaterialForeign2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialForeign2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialForeign2.UseSendTab = True
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.rad_CheckMarketType2)
        Me.PeacePanel1.Controls.Add(Me.rad_CheckMarketType1)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Enabled = False
        Me.PeacePanel1.Location = New System.Drawing.Point(743, 56)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(178, 26)
        Me.PeacePanel1.TabIndex = 6
        Me.PeacePanel1.Tag = ""
        '
        'rad_CheckMarketType2
        '
        Me.rad_CheckMarketType2.AutoSize = True
        Me.rad_CheckMarketType2.ButtonTitle = Nothing
        Me.rad_CheckMarketType2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_CheckMarketType2.Location = New System.Drawing.Point(93, 2)
        Me.rad_CheckMarketType2.Margin = New System.Windows.Forms.Padding(1)
        Me.rad_CheckMarketType2.Name = "rad_CheckMarketType2"
        Me.rad_CheckMarketType2.Size = New System.Drawing.Size(75, 18)
        Me.rad_CheckMarketType2.TabIndex = 1
        Me.rad_CheckMarketType2.Text = "Domestic"
        Me.rad_CheckMarketType2.UseVisualStyleBackColor = True
        '
        'rad_CheckMarketType1
        '
        Me.rad_CheckMarketType1.AutoSize = True
        Me.rad_CheckMarketType1.ButtonTitle = Nothing
        Me.rad_CheckMarketType1.Checked = True
        Me.rad_CheckMarketType1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_CheckMarketType1.Location = New System.Drawing.Point(7, 3)
        Me.rad_CheckMarketType1.Margin = New System.Windows.Forms.Padding(1)
        Me.rad_CheckMarketType1.Name = "rad_CheckMarketType1"
        Me.rad_CheckMarketType1.Size = New System.Drawing.Size(62, 18)
        Me.rad_CheckMarketType1.TabIndex = 0
        Me.rad_CheckMarketType1.TabStop = True
        Me.rad_CheckMarketType1.Text = "Import"
        Me.rad_CheckMarketType1.UseVisualStyleBackColor = True
        '
        'PeaceLabel3
        '
        Me.PeaceLabel3.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PeaceLabel3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel3.ButtonTitle = Nothing
        Me.PeaceLabel3.Code = ""
        Me.PeaceLabel3.Data = ""
        Me.PeaceLabel3.DTDec = 0
        Me.PeaceLabel3.DTLen = 0
        Me.PeaceLabel3.DTValue = 0
        Me.PeaceLabel3.Enabled = False
        Me.PeaceLabel3.Location = New System.Drawing.Point(618, 56)
        Me.PeaceLabel3.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel3.Name = "PeaceLabel3"
        Me.PeaceLabel3.NoClear = False
        Me.PeaceLabel3.Size = New System.Drawing.Size(123, 26)
        Me.PeaceLabel3.TabIndex = 6
        Me.PeaceLabel3.Tag = ""
        Me.PeaceLabel3.Text = "Market"
        Me.PeaceLabel3.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_Check1
        '
        Me.txt_Check1.BackYesno = False
        Me.txt_Check1.ButtonTitle = Nothing
        Me.txt_Check1.Code = ""
        Me.txt_Check1.Data = "0"
        Me.txt_Check1.DataDecimal = 0
        Me.txt_Check1.DataLen = 0
        Me.txt_Check1.DataValue = 0
        Me.txt_Check1.FormatDecimal = 0
        Me.txt_Check1.FormatValue = False
        Me.txt_Check1.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_Check1.LableEnabled = True
        Me.txt_Check1.LableFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Check1.LableForeColor = System.Drawing.Color.Black
        Me.txt_Check1.LableTitle = "INPUT TIME"
        Me.txt_Check1.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_Check1.Location = New System.Drawing.Point(5, 161)
        Me.txt_Check1.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Check1.Name = "txt_Check1"
        Me.txt_Check1.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Check1.Size = New System.Drawing.Size(303, 74)
        Me.txt_Check1.TabIndex = 27
        Me.txt_Check1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Check1.TextBoxAutoComplete = False
        Me.txt_Check1.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Check1.TextBoxFont = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txt_Check1.TextEnabled = True
        Me.txt_Check1.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Check1.TextMaxLength = 32767
        Me.txt_Check1.TextMultiLine = False
        Me.txt_Check1.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Check1.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Check1.UseSendTab = True
        '
        'txt_Check3
        '
        Me.txt_Check3.BackYesno = False
        Me.txt_Check3.ButtonTitle = Nothing
        Me.txt_Check3.Code = ""
        Me.txt_Check3.Data = "0"
        Me.txt_Check3.DataDecimal = 0
        Me.txt_Check3.DataLen = 0
        Me.txt_Check3.DataValue = 0
        Me.txt_Check3.FormatDecimal = 0
        Me.txt_Check3.FormatValue = False
        Me.txt_Check3.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Check3.LableEnabled = True
        Me.txt_Check3.LableFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Check3.LableForeColor = System.Drawing.Color.Black
        Me.txt_Check3.LableTitle = "OUTPUT TIME"
        Me.txt_Check3.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_Check3.Location = New System.Drawing.Point(6, 313)
        Me.txt_Check3.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Check3.Name = "txt_Check3"
        Me.txt_Check3.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Check3.Size = New System.Drawing.Size(302, 74)
        Me.txt_Check3.TabIndex = 29
        Me.txt_Check3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Check3.TextBoxAutoComplete = False
        Me.txt_Check3.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Check3.TextBoxFont = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txt_Check3.TextEnabled = True
        Me.txt_Check3.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Check3.TextMaxLength = 32767
        Me.txt_Check3.TextMultiLine = False
        Me.txt_Check3.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Check3.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Check3.UseSendTab = True
        '
        'txt_Check2
        '
        Me.txt_Check2.BackYesno = False
        Me.txt_Check2.ButtonTitle = Nothing
        Me.txt_Check2.Code = ""
        Me.txt_Check2.Data = "0"
        Me.txt_Check2.DataDecimal = 0
        Me.txt_Check2.DataLen = 0
        Me.txt_Check2.DataValue = 0
        Me.txt_Check2.FormatDecimal = 0
        Me.txt_Check2.FormatValue = False
        Me.txt_Check2.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Check2.LableEnabled = True
        Me.txt_Check2.LableFont = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Check2.LableForeColor = System.Drawing.Color.Black
        Me.txt_Check2.LableTitle = "PROCESSING TIME"
        Me.txt_Check2.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_Check2.Location = New System.Drawing.Point(5, 237)
        Me.txt_Check2.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Check2.Name = "txt_Check2"
        Me.txt_Check2.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Check2.Size = New System.Drawing.Size(303, 74)
        Me.txt_Check2.TabIndex = 28
        Me.txt_Check2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Check2.TextBoxAutoComplete = False
        Me.txt_Check2.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Check2.TextBoxFont = New System.Drawing.Font("Tahoma", 20.0!)
        Me.txt_Check2.TextEnabled = True
        Me.txt_Check2.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Check2.TextMaxLength = 32767
        Me.txt_Check2.TextMultiLine = False
        Me.txt_Check2.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Check2.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Check2.UseSendTab = True
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Controls.Add(Me.txt_cdDepartment)
        Me.PeacePanel2.Controls.Add(Me.txt_DevelopmentCode)
        Me.PeacePanel2.Controls.Add(Me.txt_AccountCode)
        Me.PeacePanel2.Controls.Add(Me.txt_ImportCode)
        Me.PeacePanel2.Controls.Add(Me.txt_MaterialCode)
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeacePanel2.Location = New System.Drawing.Point(3, 3)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(927, 56)
        Me.PeacePanel2.TabIndex = 0
        Me.PeacePanel2.Tag = ""
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
        Me.txt_cdDepartment.Enabled = False
        Me.txt_cdDepartment.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cdDepartment.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_cdDepartment.Location = New System.Drawing.Point(617, 28)
        Me.txt_cdDepartment.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDepartment.Name = "txt_cdDepartment"
        Me.txt_cdDepartment.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDepartment.Size = New System.Drawing.Size(304, 25)
        Me.txt_cdDepartment.TabIndex = 4
        Me.txt_cdDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDepartment.TextBoxAutoComplete = False
        Me.txt_cdDepartment.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cdDepartment.TextEnabled = True
        Me.txt_cdDepartment.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDepartment.TextMaxLength = 32767
        Me.txt_cdDepartment.TextMultiLine = False
        Me.txt_cdDepartment.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDepartment.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDepartment.UseSendTab = True
        '
        'txt_DevelopmentCode
        '
        Me.txt_DevelopmentCode.BackYesno = False
        Me.txt_DevelopmentCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_DevelopmentCode.ButtonEnabled = True
        Me.txt_DevelopmentCode.ButtonFont = Nothing
        Me.txt_DevelopmentCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.ButtonName = ""
        Me.txt_DevelopmentCode.ButtonTitle = "Development Code"
        Me.txt_DevelopmentCode.Code = ""
        Me.txt_DevelopmentCode.Data = ""
        Me.txt_DevelopmentCode.DataDecimal = 0
        Me.txt_DevelopmentCode.DataLen = 0
        Me.txt_DevelopmentCode.DataValue = 0
        Me.txt_DevelopmentCode.Enabled = False
        Me.txt_DevelopmentCode.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_DevelopmentCode.Layoutpercent = New Decimal(New Integer() {205, 0, 0, 196608})
        Me.txt_DevelopmentCode.Location = New System.Drawing.Point(311, 3)
        Me.txt_DevelopmentCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DevelopmentCode.Name = "txt_DevelopmentCode"
        Me.txt_DevelopmentCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DevelopmentCode.Size = New System.Drawing.Size(610, 24)
        Me.txt_DevelopmentCode.TabIndex = 1
        Me.txt_DevelopmentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DevelopmentCode.TextBoxAutoComplete = True
        Me.txt_DevelopmentCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_DevelopmentCode.TextEnabled = True
        Me.txt_DevelopmentCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.TextMaxLength = 32767
        Me.txt_DevelopmentCode.TextMultiLine = False
        Me.txt_DevelopmentCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DevelopmentCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DevelopmentCode.UseSendTab = True
        '
        'txt_AccountCode
        '
        Me.txt_AccountCode.BackYesno = False
        Me.txt_AccountCode.ButtonTitle = Nothing
        Me.txt_AccountCode.Code = ""
        Me.txt_AccountCode.Data = ""
        Me.txt_AccountCode.DataDecimal = 0
        Me.txt_AccountCode.DataLen = 0
        Me.txt_AccountCode.DataValue = 0
        Me.txt_AccountCode.Enabled = False
        Me.txt_AccountCode.FormatDecimal = 0
        Me.txt_AccountCode.FormatValue = False
        Me.txt_AccountCode.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_AccountCode.LableEnabled = True
        Me.txt_AccountCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_AccountCode.LableForeColor = System.Drawing.Color.Black
        Me.txt_AccountCode.LableTitle = "Accounting Code"
        Me.txt_AccountCode.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_AccountCode.Location = New System.Drawing.Point(311, 30)
        Me.txt_AccountCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_AccountCode.Name = "txt_AccountCode"
        Me.txt_AccountCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccountCode.Size = New System.Drawing.Size(303, 23)
        Me.txt_AccountCode.TabIndex = 3
        Me.txt_AccountCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccountCode.TextBoxAutoComplete = False
        Me.txt_AccountCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccountCode.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_AccountCode.TextEnabled = True
        Me.txt_AccountCode.TextForeColor = System.Drawing.Color.Blue
        Me.txt_AccountCode.TextMaxLength = 32767
        Me.txt_AccountCode.TextMultiLine = False
        Me.txt_AccountCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccountCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccountCode.UseSendTab = True
        '
        'txt_ImportCode
        '
        Me.txt_ImportCode.BackYesno = False
        Me.txt_ImportCode.ButtonTitle = Nothing
        Me.txt_ImportCode.Code = ""
        Me.txt_ImportCode.Data = ""
        Me.txt_ImportCode.DataDecimal = 0
        Me.txt_ImportCode.DataLen = 0
        Me.txt_ImportCode.DataValue = 0
        Me.txt_ImportCode.Enabled = False
        Me.txt_ImportCode.FormatDecimal = 0
        Me.txt_ImportCode.FormatValue = False
        Me.txt_ImportCode.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_ImportCode.LableEnabled = True
        Me.txt_ImportCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ImportCode.LableForeColor = System.Drawing.Color.Black
        Me.txt_ImportCode.LableTitle = "Import Code"
        Me.txt_ImportCode.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_ImportCode.Location = New System.Drawing.Point(5, 30)
        Me.txt_ImportCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_ImportCode.Name = "txt_ImportCode"
        Me.txt_ImportCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_ImportCode.Size = New System.Drawing.Size(304, 23)
        Me.txt_ImportCode.TabIndex = 2
        Me.txt_ImportCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_ImportCode.TextBoxAutoComplete = False
        Me.txt_ImportCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_ImportCode.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_ImportCode.TextEnabled = True
        Me.txt_ImportCode.TextForeColor = System.Drawing.Color.Blue
        Me.txt_ImportCode.TextMaxLength = 32767
        Me.txt_ImportCode.TextMultiLine = False
        Me.txt_ImportCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_ImportCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_ImportCode.UseSendTab = True
        '
        'txt_MaterialCode
        '
        Me.txt_MaterialCode.BackYesno = False
        Me.txt_MaterialCode.ButtonTitle = Nothing
        Me.txt_MaterialCode.Code = ""
        Me.txt_MaterialCode.Data = ""
        Me.txt_MaterialCode.DataDecimal = 0
        Me.txt_MaterialCode.DataLen = 0
        Me.txt_MaterialCode.DataValue = 0
        Me.txt_MaterialCode.Enabled = False
        Me.txt_MaterialCode.FormatDecimal = 0
        Me.txt_MaterialCode.FormatValue = False
        Me.txt_MaterialCode.LableBackColor = System.Drawing.SystemColors.ButtonFace
        Me.txt_MaterialCode.LableEnabled = True
        Me.txt_MaterialCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MaterialCode.LableForeColor = System.Drawing.Color.Black
        Me.txt_MaterialCode.LableTitle = "Code"
        Me.txt_MaterialCode.Layoutpercent = New Decimal(New Integer() {41, 0, 0, 131072})
        Me.txt_MaterialCode.Location = New System.Drawing.Point(5, 5)
        Me.txt_MaterialCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MaterialCode.Name = "txt_MaterialCode"
        Me.txt_MaterialCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MaterialCode.Size = New System.Drawing.Size(304, 23)
        Me.txt_MaterialCode.TabIndex = 0
        Me.txt_MaterialCode.TabStop = False
        Me.txt_MaterialCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MaterialCode.TextBoxAutoComplete = False
        Me.txt_MaterialCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MaterialCode.TextBoxFont = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_MaterialCode.TextEnabled = False
        Me.txt_MaterialCode.TextForeColor = System.Drawing.Color.Blue
        Me.txt_MaterialCode.TextMaxLength = 32767
        Me.txt_MaterialCode.TextMultiLine = False
        Me.txt_MaterialCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MaterialCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MaterialCode.UseSendTab = True
        '
        'Tlp_1
        '
        Me.Tlp_1.ColumnCount = 1
        Me.Tlp_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.Controls.Add(Me.Frame4, 0, 2)
        Me.Tlp_1.Controls.Add(Me.PeacePanel3, 0, 1)
        Me.Tlp_1.Controls.Add(Me.PeacePanel2, 0, 0)
        Me.Tlp_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tlp_1.Location = New System.Drawing.Point(0, 0)
        Me.Tlp_1.Name = "Tlp_1"
        Me.Tlp_1.RowCount = 3
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.Tlp_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43.0!))
        Me.Tlp_1.Size = New System.Drawing.Size(933, 503)
        Me.Tlp_1.TabIndex = 1
        '
        'ISUD7231T
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(933, 503)
        Me.Controls.Add(Me.Tlp_1)
        Me.KeyPreview = True
        Me.Name = "ISUD7231T"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TOOL CODE PROCESSING (ISUD7231T)"
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel2.ResumeLayout(False)
        Me.Tlp_1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_MaterialName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MaterialForeign1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Check2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Check3 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Check1 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MaterialForeign2 As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdDetailGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdSemiGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_MaterialCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdLargeGroupMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents rad_CheckMarketType2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckMarketType1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents PeaceLabel3 As PSMGlobal.PeaceLabel
    Friend WithEvents cmd_Print As PSMGlobal.PeaceButton
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents txt_MaterialSimple As PSMGlobal.SelectLabelText
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_AccountCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_ImportCode As PSMGlobal.SelectLabelText
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
    Friend WithEvents txt_cdDepartment As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_DevelopmentCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_ColorName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Height As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Sizename As PSMGlobal.SelectLabelText
    Friend WithEvents txt_Width As PSMGlobal.SelectLabelText
    Friend WithEvents txt_SizeRangeTool As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents Tlp_1 As System.Windows.Forms.TableLayoutPanel
End Class
