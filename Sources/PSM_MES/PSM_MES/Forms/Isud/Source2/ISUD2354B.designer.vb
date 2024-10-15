<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD2354B
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Frame1 = New PSMGlobal.PeacePanel(Me.components)
        Me.FlowLayoutPanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_LotGrade = New PSMGlobal.SelectLabelText()
        Me.txt_TimeQC = New PSMGlobal.SelectLabelText()
        Me.txt_InchargeQC = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_Barcode = New PSMGlobal.SelectLabelText()
        Me.lbl_CheckQC = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdDefectMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.rad_CheckQC1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckQC2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.PeaceLabel4 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_CntQC = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_CntInbound = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeaceButton2 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceMaskedtextbox1 = New PSMGlobal.PeaceMaskedtextbox(Me.components)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.FlowLayoutPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Frame1
        '
        Me.Frame1.Code = ""
        Me.Frame1.Controls.Add(Me.FlowLayoutPanel2)
        Me.Frame1.Data = ""
        Me.Frame1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Frame1.Location = New System.Drawing.Point(0, 38)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Size = New System.Drawing.Size(487, 385)
        Me.Frame1.TabIndex = 4
        Me.Frame1.Tag = ""
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel2.Code = ""
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_LotGrade)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_TimeQC)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_InchargeQC)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_Barcode)
        Me.FlowLayoutPanel2.Controls.Add(Me.lbl_CheckQC)
        Me.FlowLayoutPanel2.Controls.Add(Me.PeacePanel3)
        Me.FlowLayoutPanel2.Controls.Add(Me.PeaceLabel4)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_CntQC)
        Me.FlowLayoutPanel2.Controls.Add(Me.txt_CntInbound)
        Me.FlowLayoutPanel2.Data = ""
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(477, 373)
        Me.FlowLayoutPanel2.TabIndex = 101
        Me.FlowLayoutPanel2.Tag = ""
        '
        'txt_LotGrade
        '
        Me.txt_LotGrade.BackYesno = False
        Me.txt_LotGrade.ButtonTitle = Nothing
        Me.txt_LotGrade.Code = Nothing
        Me.txt_LotGrade.Data = ""
        Me.txt_LotGrade.DataDecimal = 0
        Me.txt_LotGrade.DataLen = 0
        Me.txt_LotGrade.DataValue = 1
        Me.txt_LotGrade.FormatDecimal = 0
        Me.txt_LotGrade.FormatValue = False
        Me.txt_LotGrade.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_LotGrade.LableEnabled = True
        Me.txt_LotGrade.LableFont = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_LotGrade.LableForeColor = System.Drawing.Color.Empty
        Me.txt_LotGrade.LableTitle = "Lot #"
        Me.txt_LotGrade.Layoutpercent = New Decimal(New Integer() {3, 0, 0, 65536})
        Me.txt_LotGrade.Location = New System.Drawing.Point(7, 312)
        Me.txt_LotGrade.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_LotGrade.Name = "txt_LotGrade"
        Me.txt_LotGrade.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_LotGrade.Size = New System.Drawing.Size(462, 47)
        Me.txt_LotGrade.TabIndex = 155
        Me.txt_LotGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_LotGrade.TextBoxAutoComplete = False
        Me.txt_LotGrade.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_LotGrade.TextBoxFont = New System.Drawing.Font("Tahoma", 18.0!)
        Me.txt_LotGrade.TextEnabled = True
        Me.txt_LotGrade.TextForeColor = System.Drawing.Color.Empty
        Me.txt_LotGrade.TextMaxLength = 32767
        Me.txt_LotGrade.TextMultiLine = False
        Me.txt_LotGrade.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_LotGrade.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_LotGrade.UseSendTab = True
        '
        'txt_TimeQC
        '
        Me.txt_TimeQC.BackYesno = False
        Me.txt_TimeQC.ButtonTitle = Nothing
        Me.txt_TimeQC.Code = Nothing
        Me.txt_TimeQC.Data = ""
        Me.txt_TimeQC.DataDecimal = 0
        Me.txt_TimeQC.DataLen = 0
        Me.txt_TimeQC.DataValue = 1
        Me.txt_TimeQC.FormatDecimal = 0
        Me.txt_TimeQC.FormatValue = False
        Me.txt_TimeQC.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_TimeQC.LableEnabled = True
        Me.txt_TimeQC.LableFont = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_TimeQC.LableForeColor = System.Drawing.Color.Empty
        Me.txt_TimeQC.LableTitle = "Time QC"
        Me.txt_TimeQC.Layoutpercent = New Decimal(New Integer() {3, 0, 0, 65536})
        Me.txt_TimeQC.Location = New System.Drawing.Point(7, 160)
        Me.txt_TimeQC.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_TimeQC.Name = "txt_TimeQC"
        Me.txt_TimeQC.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_TimeQC.Size = New System.Drawing.Size(465, 47)
        Me.txt_TimeQC.TabIndex = 154
        Me.txt_TimeQC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_TimeQC.TextBoxAutoComplete = False
        Me.txt_TimeQC.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_TimeQC.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_TimeQC.TextEnabled = True
        Me.txt_TimeQC.TextForeColor = System.Drawing.Color.Empty
        Me.txt_TimeQC.TextMaxLength = 32767
        Me.txt_TimeQC.TextMultiLine = False
        Me.txt_TimeQC.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_TimeQC.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_TimeQC.UseSendTab = True
        '
        'txt_InchargeQC
        '
        Me.txt_InchargeQC.BackYesno = False
        Me.txt_InchargeQC.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_InchargeQC.ButtonEnabled = True
        Me.txt_InchargeQC.ButtonFont = Nothing
        Me.txt_InchargeQC.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeQC.ButtonName = "Const_Emp003"
        Me.txt_InchargeQC.ButtonTitle = "Incharge"
        Me.txt_InchargeQC.Code = ""
        Me.txt_InchargeQC.Data = ""
        Me.txt_InchargeQC.DataDecimal = 0
        Me.txt_InchargeQC.DataLen = 0
        Me.txt_InchargeQC.DataValue = 1
        Me.txt_InchargeQC.Layoutpercent = New Decimal(New Integer() {3, 0, 0, 65536})
        Me.txt_InchargeQC.Location = New System.Drawing.Point(7, 108)
        Me.txt_InchargeQC.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_InchargeQC.Name = "txt_InchargeQC"
        Me.txt_InchargeQC.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_InchargeQC.Size = New System.Drawing.Size(465, 50)
        Me.txt_InchargeQC.TabIndex = 153
        Me.txt_InchargeQC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_InchargeQC.TextBoxAutoComplete = False
        Me.txt_InchargeQC.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_InchargeQC.TextBoxFont = New System.Drawing.Font("Tahoma", 18.0!)
        Me.txt_InchargeQC.TextEnabled = True
        Me.txt_InchargeQC.TextForeColor = System.Drawing.Color.Empty
        Me.txt_InchargeQC.TextMaxLength = 32767
        Me.txt_InchargeQC.TextMultiLine = False
        Me.txt_InchargeQC.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_InchargeQC.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_InchargeQC.UseSendTab = True
        '
        'txt_Barcode
        '
        Me.txt_Barcode.BackYesno = False
        Me.txt_Barcode.ButtonTitle = Nothing
        Me.txt_Barcode.Code = Nothing
        Me.txt_Barcode.Data = "###-#####-#####"
        Me.txt_Barcode.DataDecimal = 0
        Me.txt_Barcode.DataLen = 0
        Me.txt_Barcode.DataValue = 1
        Me.txt_Barcode.FormatDecimal = 0
        Me.txt_Barcode.FormatValue = False
        Me.txt_Barcode.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Barcode.LableEnabled = True
        Me.txt_Barcode.LableFont = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_Barcode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Barcode.LableTitle = "Barcode #"
        Me.txt_Barcode.Layoutpercent = New Decimal(New Integer() {3, 0, 0, 65536})
        Me.txt_Barcode.Location = New System.Drawing.Point(7, 2)
        Me.txt_Barcode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Barcode.Name = "txt_Barcode"
        Me.txt_Barcode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Barcode.Size = New System.Drawing.Size(466, 49)
        Me.txt_Barcode.TabIndex = 151
        Me.txt_Barcode.TabStop = False
        Me.txt_Barcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Barcode.TextBoxAutoComplete = False
        Me.txt_Barcode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Barcode.TextBoxFont = New System.Drawing.Font("Tahoma", 18.0!)
        Me.txt_Barcode.TextEnabled = False
        Me.txt_Barcode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Barcode.TextMaxLength = 32767
        Me.txt_Barcode.TextMultiLine = False
        Me.txt_Barcode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Barcode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Barcode.UseSendTab = True
        '
        'lbl_CheckQC
        '
        Me.lbl_CheckQC.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.lbl_CheckQC.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CheckQC.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_CheckQC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_CheckQC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_CheckQC.ButtonTitle = Nothing
        Me.lbl_CheckQC.Code = ""
        Me.lbl_CheckQC.Data = ""
        Me.lbl_CheckQC.DTDec = 0
        Me.lbl_CheckQC.DTLen = 0
        Me.lbl_CheckQC.DTValue = 0
        Me.lbl_CheckQC.Location = New System.Drawing.Point(7, 209)
        Me.lbl_CheckQC.Margin = New System.Windows.Forms.Padding(20, 1, 1, 1)
        Me.lbl_CheckQC.Name = "lbl_CheckQC"
        Me.lbl_CheckQC.NoClear = False
        Me.lbl_CheckQC.Size = New System.Drawing.Size(133, 100)
        Me.lbl_CheckQC.TabIndex = 119
        Me.lbl_CheckQC.Tag = ""
        Me.lbl_CheckQC.Text = "Check QC"
        Me.lbl_CheckQC.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel3
        '
        Me.PeacePanel3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.txt_cdDefectMaterial)
        Me.PeacePanel3.Controls.Add(Me.rad_CheckQC1)
        Me.PeacePanel3.Controls.Add(Me.rad_CheckQC2)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(141, 209)
        Me.PeacePanel3.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(331, 101)
        Me.PeacePanel3.TabIndex = 120
        Me.PeacePanel3.Tag = ""
        '
        'txt_cdDefectMaterial
        '
        Me.txt_cdDefectMaterial.BackYesno = False
        Me.txt_cdDefectMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdDefectMaterial.ButtonEnabled = True
        Me.txt_cdDefectMaterial.ButtonFont = Nothing
        Me.txt_cdDefectMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefectMaterial.ButtonName = "Const_Emp003"
        Me.txt_cdDefectMaterial.ButtonTitle = "Defect Type"
        Me.txt_cdDefectMaterial.Code = ""
        Me.txt_cdDefectMaterial.Data = ""
        Me.txt_cdDefectMaterial.DataDecimal = 0
        Me.txt_cdDefectMaterial.DataLen = 0
        Me.txt_cdDefectMaterial.DataValue = 1
        Me.txt_cdDefectMaterial.Layoutpercent = New Decimal(New Integer() {3, 0, 0, 65536})
        Me.txt_cdDefectMaterial.Location = New System.Drawing.Point(5, 46)
        Me.txt_cdDefectMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdDefectMaterial.Name = "txt_cdDefectMaterial"
        Me.txt_cdDefectMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdDefectMaterial.Size = New System.Drawing.Size(323, 52)
        Me.txt_cdDefectMaterial.TabIndex = 152
        Me.txt_cdDefectMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdDefectMaterial.TextBoxAutoComplete = False
        Me.txt_cdDefectMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdDefectMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 18.0!)
        Me.txt_cdDefectMaterial.TextEnabled = True
        Me.txt_cdDefectMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdDefectMaterial.TextMaxLength = 32767
        Me.txt_cdDefectMaterial.TextMultiLine = False
        Me.txt_cdDefectMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdDefectMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdDefectMaterial.UseSendTab = True
        Me.txt_cdDefectMaterial.Visible = False
        '
        'rad_CheckQC1
        '
        Me.rad_CheckQC1.AutoSize = True
        Me.rad_CheckQC1.ButtonTitle = Nothing
        Me.rad_CheckQC1.Checked = True
        Me.rad_CheckQC1.Font = New System.Drawing.Font("Tahoma", 25.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckQC1.ForeColor = System.Drawing.Color.Blue
        Me.rad_CheckQC1.Location = New System.Drawing.Point(16, 5)
        Me.rad_CheckQC1.Name = "rad_CheckQC1"
        Me.rad_CheckQC1.Size = New System.Drawing.Size(125, 45)
        Me.rad_CheckQC1.TabIndex = 6
        Me.rad_CheckQC1.TabStop = True
        Me.rad_CheckQC1.Text = "PASS"
        Me.rad_CheckQC1.UseVisualStyleBackColor = True
        '
        'rad_CheckQC2
        '
        Me.rad_CheckQC2.AutoSize = True
        Me.rad_CheckQC2.ButtonTitle = Nothing
        Me.rad_CheckQC2.Font = New System.Drawing.Font("Tahoma", 25.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckQC2.ForeColor = System.Drawing.Color.Red
        Me.rad_CheckQC2.Location = New System.Drawing.Point(158, 5)
        Me.rad_CheckQC2.Name = "rad_CheckQC2"
        Me.rad_CheckQC2.Size = New System.Drawing.Size(164, 45)
        Me.rad_CheckQC2.TabIndex = 4
        Me.rad_CheckQC2.Text = "REJECT"
        Me.rad_CheckQC2.UseVisualStyleBackColor = True
        '
        'PeaceLabel4
        '
        Me.PeaceLabel4.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel4.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceLabel4.Appearance.ForeColor = System.Drawing.Color.Red
        Me.PeaceLabel4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel4.ButtonTitle = Nothing
        Me.PeaceLabel4.Code = ""
        Me.PeaceLabel4.Data = ""
        Me.PeaceLabel4.DTDec = 0
        Me.PeaceLabel4.DTLen = 0
        Me.PeaceLabel4.DTValue = 0
        Me.PeaceLabel4.Location = New System.Drawing.Point(413, 53)
        Me.PeaceLabel4.Margin = New System.Windows.Forms.Padding(20, 1, 1, 1)
        Me.PeaceLabel4.Name = "PeaceLabel4"
        Me.PeaceLabel4.NoClear = False
        Me.PeaceLabel4.Size = New System.Drawing.Size(59, 54)
        Me.PeaceLabel4.TabIndex = 150
        Me.PeaceLabel4.Tag = ""
        Me.PeaceLabel4.Text = "QTY"
        Me.PeaceLabel4.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_CntQC
        '
        Me.txt_CntQC.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txt_CntQC.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CntQC.Appearance.ForeColor = System.Drawing.Color.Red
        Me.txt_CntQC.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_CntQC.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_CntQC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CntQC.ButtonTitle = Nothing
        Me.txt_CntQC.Code = ""
        Me.txt_CntQC.Data = ""
        Me.txt_CntQC.DTDec = 0
        Me.txt_CntQC.DTLen = 0
        Me.txt_CntQC.DTValue = 0
        Me.txt_CntQC.Location = New System.Drawing.Point(141, 53)
        Me.txt_CntQC.Margin = New System.Windows.Forms.Padding(20, 1, 1, 1)
        Me.txt_CntQC.Name = "txt_CntQC"
        Me.txt_CntQC.NoClear = False
        Me.txt_CntQC.Size = New System.Drawing.Size(268, 53)
        Me.txt_CntQC.TabIndex = 147
        Me.txt_CntQC.Tag = ""
        Me.txt_CntQC.Text = "0"
        Me.txt_CntQC.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'txt_CntInbound
        '
        Me.txt_CntInbound.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txt_CntInbound.Appearance.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.txt_CntInbound.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txt_CntInbound.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_CntInbound.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_CntInbound.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_CntInbound.ButtonTitle = Nothing
        Me.txt_CntInbound.Code = ""
        Me.txt_CntInbound.Data = ""
        Me.txt_CntInbound.DTDec = 0
        Me.txt_CntInbound.DTLen = 0
        Me.txt_CntInbound.DTValue = 0
        Me.txt_CntInbound.Location = New System.Drawing.Point(7, 53)
        Me.txt_CntInbound.Margin = New System.Windows.Forms.Padding(20, 1, 1, 1)
        Me.txt_CntInbound.Name = "txt_CntInbound"
        Me.txt_CntInbound.NoClear = False
        Me.txt_CntInbound.Size = New System.Drawing.Size(133, 53)
        Me.txt_CntInbound.TabIndex = 146
        Me.txt_CntInbound.Tag = ""
        Me.txt_CntInbound.Text = "0"
        Me.txt_CntInbound.TextAlign = DevExpress.Utils.HorzAlignment.Center
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
        'ISUD2354B
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(487, 423)
        Me.Controls.Add(Me.Frame1)
        Me.Name = "ISUD2354B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QC 1 PROCESSING - CHECKING (ISUD2354B)"
        Me.Controls.SetChildIndex(Me.Frame1, 0)
        CType(Me.Frame1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        CType(Me.FlowLayoutPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Frame1 As PSMGlobal.PeacePanel
    Friend WithEvents FlowLayoutPanel2 As PSMGlobal.PeacePanel
    Friend WithEvents PeaceButton2 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceMaskedtextbox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Public WithEvents PeaceLabel4 As PSMGlobal.PeaceLabel
    Public WithEvents txt_CntQC As PSMGlobal.PeaceLabel
    Public WithEvents txt_CntInbound As PSMGlobal.PeaceLabel
    Public WithEvents lbl_CheckQC As PSMGlobal.PeaceLabel
    Public WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents rad_CheckQC1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckQC2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_Barcode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_TimeQC As PSMGlobal.SelectLabelText
    Friend WithEvents txt_InchargeQC As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdDefectMaterial As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_LotGrade As PSMGlobal.SelectLabelText
End Class
