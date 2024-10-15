<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7102B
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7102B))
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_VinaCode = New PSMGlobal.SelectLabelText()
        Me.Block1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_BankCode = New PSMGlobal.SelectLabelText()
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Bloack2 = New PSMGlobal.PeacePanel(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_CheckUse2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_CheckUse1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_CustomerCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_KindCustomer = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_KindCustomer2 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.rad_KindCustomer1 = New PSMGlobal.PeaceRadioButton(Me.components)
        Me.txt_AccountBankVND = New PSMGlobal.SelectLabelText()
        Me.txt_AccountBankUSD = New PSMGlobal.SelectLabelText()
        Me.txt_cdBank = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_NameBank = New PSMGlobal.SelectLabelText()
        Me.txt_remark = New PSMGlobal.SelectLabelText()
        Me.cmd_AttachID = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.frm_Condition.SuspendLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Block1.SuspendLayout()
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame4.SuspendLayout()
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Bloack2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Code = ""
        Me.frm_Condition.Controls.Add(Me.PeacePanel1)
        Me.frm_Condition.Controls.Add(Me.Block1)
        Me.frm_Condition.Controls.Add(Me.Frame4)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Data = ""
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(835, 275)
        Me.frm_Condition.TabIndex = 1
        '
        'PeacePanel1
        '
        Me.PeacePanel1.AutoSize = True
        Me.PeacePanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.txt_VinaCode)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(417, 5)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(277, 37)
        Me.PeacePanel1.TabIndex = 40
        '
        'txt_VinaCode
        '
        Me.txt_VinaCode.BackYesno = False
        Me.txt_VinaCode.ButtonTitle = Nothing
        Me.txt_VinaCode.Code = Nothing
        Me.txt_VinaCode.Data = ""
        Me.txt_VinaCode.DataDecimal = 0
        Me.txt_VinaCode.DataLen = 0
        Me.txt_VinaCode.DataValue = 0
        Me.txt_VinaCode.FormatDecimal = 0
        Me.txt_VinaCode.FormatValue = False
        Me.txt_VinaCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VinaCode.LableEnabled = True
        Me.txt_VinaCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_VinaCode.LableForeColor = System.Drawing.Color.Blue
        Me.txt_VinaCode.LableTitle = "Vina Code"
        Me.txt_VinaCode.Layoutpercent = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.txt_VinaCode.Location = New System.Drawing.Point(2, 2)
        Me.txt_VinaCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_VinaCode.Name = "txt_VinaCode"
        Me.txt_VinaCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VinaCode.Size = New System.Drawing.Size(269, 29)
        Me.txt_VinaCode.TabIndex = 0
        Me.txt_VinaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VinaCode.TextBoxAutoComplete = False
        Me.txt_VinaCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VinaCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VinaCode.TextEnabled = True
        Me.txt_VinaCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VinaCode.TextMaxLength = 32767
        Me.txt_VinaCode.TextMultiLine = False
        Me.txt_VinaCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VinaCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VinaCode.UseSendTab = True
        '
        'Block1
        '
        Me.Block1.AutoSize = True
        Me.Block1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Block1.Code = ""
        Me.Block1.Controls.Add(Me.txt_BankCode)
        Me.Block1.Data = ""
        Me.Block1.Location = New System.Drawing.Point(3, 5)
        Me.Block1.Name = "Block1"
        Me.Block1.Size = New System.Drawing.Size(212, 37)
        Me.Block1.TabIndex = 39
        '
        'txt_BankCode
        '
        Me.txt_BankCode.BackYesno = False
        Me.txt_BankCode.ButtonTitle = Nothing
        Me.txt_BankCode.Code = Nothing
        Me.txt_BankCode.Data = ""
        Me.txt_BankCode.DataDecimal = 0
        Me.txt_BankCode.DataLen = 0
        Me.txt_BankCode.DataValue = 0
        Me.txt_BankCode.FormatDecimal = 0
        Me.txt_BankCode.FormatValue = False
        Me.txt_BankCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_BankCode.LableEnabled = True
        Me.txt_BankCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_BankCode.LableForeColor = System.Drawing.Color.Blue
        Me.txt_BankCode.LableTitle = "Bank Code"
        Me.txt_BankCode.Layoutpercent = New Decimal(New Integer() {68, 0, 0, 131072})
        Me.txt_BankCode.Location = New System.Drawing.Point(2, 2)
        Me.txt_BankCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_BankCode.Name = "txt_BankCode"
        Me.txt_BankCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_BankCode.Size = New System.Drawing.Size(204, 29)
        Me.txt_BankCode.TabIndex = 0
        Me.txt_BankCode.TabStop = False
        Me.txt_BankCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_BankCode.TextBoxAutoComplete = False
        Me.txt_BankCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_BankCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_BankCode.TextEnabled = False
        Me.txt_BankCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_BankCode.TextMaxLength = 32767
        Me.txt_BankCode.TextMultiLine = False
        Me.txt_BankCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_BankCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_BankCode.UseSendTab = True
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
        Me.Frame4.Location = New System.Drawing.Point(3, 232)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(826, 39)
        Me.Frame4.TabIndex = 0
        '
        'cmd_DEL
        '
        Me.cmd_DEL.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Appearance.Options.UseFont = True
        Me.cmd_DEL.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
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
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(681, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(141, 35)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(540, 1)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(141, 35)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Code = ""
        Me.Bloack2.Controls.Add(Me.PeaceLabel1)
        Me.Bloack2.Controls.Add(Me.TableLayoutPanel1)
        Me.Bloack2.Controls.Add(Me.txt_CustomerCode)
        Me.Bloack2.Controls.Add(Me.txt_KindCustomer)
        Me.Bloack2.Controls.Add(Me.TableLayoutPanel2)
        Me.Bloack2.Controls.Add(Me.txt_AccountBankVND)
        Me.Bloack2.Controls.Add(Me.txt_AccountBankUSD)
        Me.Bloack2.Controls.Add(Me.txt_cdBank)
        Me.Bloack2.Controls.Add(Me.txt_NameBank)
        Me.Bloack2.Controls.Add(Me.txt_remark)
        Me.Bloack2.Data = ""
        Me.Bloack2.Location = New System.Drawing.Point(3, 43)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(827, 186)
        Me.Bloack2.TabIndex = 40
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(413, 32)
        Me.PeaceLabel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(138, 29)
        Me.PeaceLabel1.TabIndex = 51
        Me.PeaceLabel1.Text = "Check Use"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rad_CheckUse2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_CheckUse1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(553, 32)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(268, 29)
        Me.TableLayoutPanel1.TabIndex = 50
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.AutoSize = True
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(137, 4)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(41, 18)
        Me.rad_CheckUse2.TabIndex = 3
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.AutoSize = True
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(4, 4)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(45, 18)
        Me.rad_CheckUse1.TabIndex = 2
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'txt_CustomerCode
        '
        Me.txt_CustomerCode.BackYesno = False
        Me.txt_CustomerCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_CustomerCode.ButtonEnabled = True
        Me.txt_CustomerCode.ButtonFont = Nothing
        Me.txt_CustomerCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_CustomerCode.ButtonName = "btn_Customer"
        Me.txt_CustomerCode.ButtonTitle = "Account Name"
        Me.txt_CustomerCode.Code = ""
        Me.txt_CustomerCode.Data = ""
        Me.txt_CustomerCode.DataDecimal = 0
        Me.txt_CustomerCode.DataLen = 0
        Me.txt_CustomerCode.DataValue = 1
        Me.txt_CustomerCode.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_CustomerCode.Location = New System.Drawing.Point(1, 32)
        Me.txt_CustomerCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_CustomerCode.Name = "txt_CustomerCode"
        Me.txt_CustomerCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_CustomerCode.Size = New System.Drawing.Size(410, 29)
        Me.txt_CustomerCode.TabIndex = 49
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
        'txt_KindCustomer
        '
        Me.txt_KindCustomer.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.txt_KindCustomer.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_KindCustomer.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_KindCustomer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_KindCustomer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_KindCustomer.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_KindCustomer.Code = ""
        Me.txt_KindCustomer.Data = ""
        Me.txt_KindCustomer.DTDec = 0
        Me.txt_KindCustomer.DTLen = 0
        Me.txt_KindCustomer.DTValue = 0
        Me.txt_KindCustomer.Location = New System.Drawing.Point(414, 63)
        Me.txt_KindCustomer.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_KindCustomer.Name = "txt_KindCustomer"
        Me.txt_KindCustomer.NoClear = False
        Me.txt_KindCustomer.Size = New System.Drawing.Size(138, 29)
        Me.txt_KindCustomer.TabIndex = 48
        Me.txt_KindCustomer.Text = "Customer Kind"
        Me.txt_KindCustomer.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.rad_KindCustomer2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.rad_KindCustomer1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(554, 63)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(268, 29)
        Me.TableLayoutPanel2.TabIndex = 47
        '
        'rad_KindCustomer2
        '
        Me.rad_KindCustomer2.AutoSize = True
        Me.rad_KindCustomer2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_KindCustomer2.Location = New System.Drawing.Point(137, 4)
        Me.rad_KindCustomer2.Name = "rad_KindCustomer2"
        Me.rad_KindCustomer2.Size = New System.Drawing.Size(106, 18)
        Me.rad_KindCustomer2.TabIndex = 3
        Me.rad_KindCustomer2.Text = "Supplier Kind"
        Me.rad_KindCustomer2.UseVisualStyleBackColor = True
        '
        'rad_KindCustomer1
        '
        Me.rad_KindCustomer1.AutoSize = True
        Me.rad_KindCustomer1.Checked = True
        Me.rad_KindCustomer1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_KindCustomer1.Location = New System.Drawing.Point(4, 4)
        Me.rad_KindCustomer1.Name = "rad_KindCustomer1"
        Me.rad_KindCustomer1.Size = New System.Drawing.Size(115, 18)
        Me.rad_KindCustomer1.TabIndex = 2
        Me.rad_KindCustomer1.TabStop = True
        Me.rad_KindCustomer1.Text = "Customer Kind"
        Me.rad_KindCustomer1.UseVisualStyleBackColor = True
        '
        'txt_AccountBankVND
        '
        Me.txt_AccountBankVND.BackYesno = False
        Me.txt_AccountBankVND.ButtonTitle = Nothing
        Me.txt_AccountBankVND.Code = Nothing
        Me.txt_AccountBankVND.Data = ""
        Me.txt_AccountBankVND.DataDecimal = 0
        Me.txt_AccountBankVND.DataLen = 0
        Me.txt_AccountBankVND.DataValue = 0
        Me.txt_AccountBankVND.FormatDecimal = 0
        Me.txt_AccountBankVND.FormatValue = False
        Me.txt_AccountBankVND.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_AccountBankVND.LableEnabled = True
        Me.txt_AccountBankVND.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccountBankVND.LableForeColor = System.Drawing.Color.Empty
        Me.txt_AccountBankVND.LableTitle = "Bank ID VND"
        Me.txt_AccountBankVND.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_AccountBankVND.Location = New System.Drawing.Point(2, 94)
        Me.txt_AccountBankVND.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_AccountBankVND.Name = "txt_AccountBankVND"
        Me.txt_AccountBankVND.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccountBankVND.Size = New System.Drawing.Size(410, 29)
        Me.txt_AccountBankVND.TabIndex = 45
        Me.txt_AccountBankVND.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccountBankVND.TextBoxAutoComplete = False
        Me.txt_AccountBankVND.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccountBankVND.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccountBankVND.TextEnabled = True
        Me.txt_AccountBankVND.TextForeColor = System.Drawing.Color.Empty
        Me.txt_AccountBankVND.TextMaxLength = 32767
        Me.txt_AccountBankVND.TextMultiLine = False
        Me.txt_AccountBankVND.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccountBankVND.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccountBankVND.UseSendTab = True
        '
        'txt_AccountBankUSD
        '
        Me.txt_AccountBankUSD.BackYesno = False
        Me.txt_AccountBankUSD.ButtonTitle = Nothing
        Me.txt_AccountBankUSD.Code = Nothing
        Me.txt_AccountBankUSD.Data = ""
        Me.txt_AccountBankUSD.DataDecimal = 0
        Me.txt_AccountBankUSD.DataLen = 0
        Me.txt_AccountBankUSD.DataValue = 0
        Me.txt_AccountBankUSD.FormatDecimal = 0
        Me.txt_AccountBankUSD.FormatValue = False
        Me.txt_AccountBankUSD.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_AccountBankUSD.LableEnabled = True
        Me.txt_AccountBankUSD.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccountBankUSD.LableForeColor = System.Drawing.Color.Empty
        Me.txt_AccountBankUSD.LableTitle = "Bank ID USD"
        Me.txt_AccountBankUSD.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_AccountBankUSD.Location = New System.Drawing.Point(414, 94)
        Me.txt_AccountBankUSD.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_AccountBankUSD.Name = "txt_AccountBankUSD"
        Me.txt_AccountBankUSD.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_AccountBankUSD.Size = New System.Drawing.Size(408, 29)
        Me.txt_AccountBankUSD.TabIndex = 46
        Me.txt_AccountBankUSD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_AccountBankUSD.TextBoxAutoComplete = False
        Me.txt_AccountBankUSD.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_AccountBankUSD.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_AccountBankUSD.TextEnabled = True
        Me.txt_AccountBankUSD.TextForeColor = System.Drawing.Color.Empty
        Me.txt_AccountBankUSD.TextMaxLength = 32767
        Me.txt_AccountBankUSD.TextMultiLine = False
        Me.txt_AccountBankUSD.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_AccountBankUSD.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_AccountBankUSD.UseSendTab = True
        '
        'txt_cdBank
        '
        Me.txt_cdBank.BackYesno = False
        Me.txt_cdBank.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdBank.ButtonEnabled = True
        Me.txt_cdBank.ButtonFont = Nothing
        Me.txt_cdBank.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdBank.ButtonName = "Const_BankId"
        Me.txt_cdBank.ButtonTitle = "Bank ID"
        Me.txt_cdBank.Code = ""
        Me.txt_cdBank.Data = ""
        Me.txt_cdBank.DataDecimal = 0
        Me.txt_cdBank.DataLen = 0
        Me.txt_cdBank.DataValue = 1
        Me.txt_cdBank.Layoutpercent = New Decimal(New Integer() {3366, 0, 0, 262144})
        Me.txt_cdBank.Location = New System.Drawing.Point(1, 64)
        Me.txt_cdBank.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdBank.Name = "txt_cdBank"
        Me.txt_cdBank.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdBank.Size = New System.Drawing.Size(410, 29)
        Me.txt_cdBank.TabIndex = 44
        Me.txt_cdBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdBank.TextBoxAutoComplete = False
        Me.txt_cdBank.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdBank.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdBank.TextEnabled = True
        Me.txt_cdBank.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdBank.TextMaxLength = 32767
        Me.txt_cdBank.TextMultiLine = False
        Me.txt_cdBank.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdBank.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdBank.UseSendTab = True
        '
        'txt_NameBank
        '
        Me.txt_NameBank.BackYesno = False
        Me.txt_NameBank.ButtonTitle = Nothing
        Me.txt_NameBank.Code = Nothing
        Me.txt_NameBank.Data = ""
        Me.txt_NameBank.DataDecimal = 0
        Me.txt_NameBank.DataLen = 0
        Me.txt_NameBank.DataValue = 1
        Me.txt_NameBank.FormatDecimal = 0
        Me.txt_NameBank.FormatValue = False
        Me.txt_NameBank.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_NameBank.LableEnabled = True
        Me.txt_NameBank.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NameBank.LableForeColor = System.Drawing.Color.Empty
        Me.txt_NameBank.LableTitle = "Bank Name"
        Me.txt_NameBank.Layoutpercent = New Decimal(New Integer() {17, 0, 0, 131072})
        Me.txt_NameBank.Location = New System.Drawing.Point(1, 1)
        Me.txt_NameBank.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_NameBank.Name = "txt_NameBank"
        Me.txt_NameBank.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_NameBank.Size = New System.Drawing.Size(821, 29)
        Me.txt_NameBank.TabIndex = 0
        Me.txt_NameBank.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_NameBank.TextBoxAutoComplete = False
        Me.txt_NameBank.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_NameBank.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NameBank.TextEnabled = True
        Me.txt_NameBank.TextForeColor = System.Drawing.Color.Empty
        Me.txt_NameBank.TextMaxLength = 32767
        Me.txt_NameBank.TextMultiLine = False
        Me.txt_NameBank.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_NameBank.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_NameBank.UseSendTab = True
        '
        'txt_remark
        '
        Me.txt_remark.BackYesno = False
        Me.txt_remark.ButtonTitle = Nothing
        Me.txt_remark.Code = Nothing
        Me.txt_remark.Data = ""
        Me.txt_remark.DataDecimal = 0
        Me.txt_remark.DataLen = 0
        Me.txt_remark.DataValue = 0
        Me.txt_remark.FormatDecimal = 0
        Me.txt_remark.FormatValue = False
        Me.txt_remark.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_remark.LableEnabled = True
        Me.txt_remark.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_remark.LableForeColor = System.Drawing.Color.Empty
        Me.txt_remark.LableTitle = "Remark"
        Me.txt_remark.Layoutpercent = New Decimal(New Integer() {169, 0, 0, 196608})
        Me.txt_remark.Location = New System.Drawing.Point(1, 125)
        Me.txt_remark.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_remark.Name = "txt_remark"
        Me.txt_remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_remark.Size = New System.Drawing.Size(821, 57)
        Me.txt_remark.TabIndex = 18
        Me.txt_remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_remark.TextBoxAutoComplete = False
        Me.txt_remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_remark.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_remark.TextEnabled = True
        Me.txt_remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_remark.TextMaxLength = 32767
        Me.txt_remark.TextMultiLine = True
        Me.txt_remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_remark.UseSendTab = True
        '
        'cmd_AttachID
        '
        Me.cmd_AttachID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmd_AttachID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_AttachID.Appearance.Options.UseFont = True
        Me.cmd_AttachID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_AttachID.Code = Nothing
        Me.cmd_AttachID.Data = Nothing
        Me.cmd_AttachID.Image = CType(resources.GetObject("cmd_AttachID.Image"), System.Drawing.Image)
        Me.cmd_AttachID.ImageAlign = 16
        Me.cmd_AttachID.Location = New System.Drawing.Point(305, 1)
        Me.cmd_AttachID.Name = "cmd_AttachID"
        Me.cmd_AttachID.Size = New System.Drawing.Size(138, 34)
        Me.cmd_AttachID.TabIndex = 14
        Me.cmd_AttachID.Text = "Attachment"
        Me.cmd_AttachID.UseVisualStyleBackColor = False
        '
        'ISUD7102B
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(835, 275)
        Me.Controls.Add(Me.frm_Condition)
        Me.DoubleBuffered = True
        Me.KeyPreview = True
        Me.Name = "ISUD7102B"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BANK CODE PROCESSING (ISUD7102A)"
        CType(Me.frm_Condition, System.ComponentModel.ISupportInitialize).EndInit()
        Me.frm_Condition.ResumeLayout(False)
        Me.frm_Condition.PerformLayout()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        CType(Me.Block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Block1.ResumeLayout(False)
        CType(Me.Frame4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame4.ResumeLayout(False)
        CType(Me.Bloack2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Bloack2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Block1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_BankCode As PSMGlobal.SelectLabelText
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_NameBank As PSMGlobal.SelectLabelText
    Friend WithEvents txt_remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_KindCustomer As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_KindCustomer2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_KindCustomer1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents txt_AccountBankVND As PSMGlobal.SelectLabelText
    Friend WithEvents txt_AccountBankUSD As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdBank As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_CustomerCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_CheckUse2 As PSMGlobal.PeaceRadioButton
    Friend WithEvents rad_CheckUse1 As PSMGlobal.PeaceRadioButton
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_VinaCode As PSMGlobal.SelectLabelText
    Friend WithEvents cmd_AttachID As PSMGlobal.PeaceButton
End Class
