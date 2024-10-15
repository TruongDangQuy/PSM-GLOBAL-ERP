<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7271A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7271A))
        Me.frm_Condition = New PSMGlobal.PeacePanel(Me.components)
        Me.Frame4 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_DEL = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.Bloack2 = New PSMGlobal.PeacePanel()
        Me.txt_cdWarehouseGroup = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_cdWarehouseCode = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_WarehousePositionCode = New PSMGlobal.SelectLabelText()
        Me.txt_DevelopmentCode = New PSMGlobal.SelectLabelText()
        Me.txt_WarehousePositionName = New PSMGlobal.SelectLabelText()
        Me.txt_WarehousePositionNameSimply = New PSMGlobal.SelectLabelText()
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.rad_CheckUse2 = New System.Windows.Forms.RadioButton()
        Me.rad_CheckUse1 = New System.Windows.Forms.RadioButton()
        Me.txt_QtyMaxBase = New PSMGlobal.SelectLabelText()
        Me.txt_UnitBase = New PSMGlobal.SelectPeaceHLPButton()
        Me.txt_WarehousePositionEname = New PSMGlobal.SelectLabelText()
        Me.txt_GroupPosition = New PSMGlobal.SelectLabelText()
        Me.txt_DisplaySeq = New PSMGlobal.SelectLabelText()
        Me.txt_HorizontalPosition = New PSMGlobal.SelectLabelText()
        Me.txt_VerticalPosition = New PSMGlobal.SelectLabelText()
        Me.txt_Remark = New PSMGlobal.SelectLabelText()
        Me.txt_RollRemainder = New PSMGlobal.SelectLabelText()
        Me.txt_WgtRemainder = New PSMGlobal.SelectLabelText()
        Me.txt_MtsRemainder = New PSMGlobal.SelectLabelText()
        Me.txt_YdsRemainder = New PSMGlobal.SelectLabelText()
        Me.frm_Condition.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Bloack2.SuspendLayout()
        Me.PeacePanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'frm_Condition
        '
        Me.frm_Condition.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.frm_Condition.Controls.Add(Me.Frame4)
        Me.frm_Condition.Controls.Add(Me.Bloack2)
        Me.frm_Condition.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frm_Condition.Location = New System.Drawing.Point(0, 0)
        Me.frm_Condition.Name = "frm_Condition"
        Me.frm_Condition.Size = New System.Drawing.Size(666, 459)
        Me.frm_Condition.TabIndex = 1
        '
        'Frame4
        '
        Me.Frame4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Frame4.Controls.Add(Me.cmd_DEL)
        Me.Frame4.Controls.Add(Me.cmd_Cancel)
        Me.Frame4.Controls.Add(Me.cmd_OK)
        Me.Frame4.Location = New System.Drawing.Point(12, 417)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Size = New System.Drawing.Size(648, 36)
        Me.Frame4.TabIndex = 0
        '
        'cmd_DEL
        '
        Me.cmd_DEL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmd_DEL.Code = Nothing
        Me.cmd_DEL.Data = Nothing
        Me.cmd_DEL.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_DEL.Image = CType(resources.GetObject("cmd_DEL.Image"), System.Drawing.Image)
        Me.cmd_DEL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_DEL.Location = New System.Drawing.Point(1, 1)
        Me.cmd_DEL.Margin = New System.Windows.Forms.Padding(0)
        Me.cmd_DEL.Name = "cmd_DEL"
        Me.cmd_DEL.Size = New System.Drawing.Size(164, 32)
        Me.cmd_DEL.TabIndex = 2
        Me.cmd_DEL.Text = "DELETE(&D)"
        Me.cmd_DEL.UseVisualStyleBackColor = False
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.None
        Me.cmd_Cancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Cancel.Image = CType(resources.GetObject("cmd_Cancel.Image"), System.Drawing.Image)
        Me.cmd_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_Cancel.Location = New System.Drawing.Point(481, 2)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(161, 30)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "CLOSE(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_OK.Image = CType(resources.GetObject("cmd_OK.Image"), System.Drawing.Image)
        Me.cmd_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmd_OK.Location = New System.Drawing.Point(318, 2)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(161, 31)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'Bloack2
        '
        Me.Bloack2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.Bloack2.Controls.Add(Me.txt_cdWarehouseGroup)
        Me.Bloack2.Controls.Add(Me.txt_cdWarehouseCode)
        Me.Bloack2.Controls.Add(Me.txt_WarehousePositionCode)
        Me.Bloack2.Controls.Add(Me.txt_DevelopmentCode)
        Me.Bloack2.Controls.Add(Me.txt_WarehousePositionName)
        Me.Bloack2.Controls.Add(Me.txt_WarehousePositionNameSimply)
        Me.Bloack2.Controls.Add(Me.PeaceLabel1)
        Me.Bloack2.Controls.Add(Me.PeacePanel2)
        Me.Bloack2.Controls.Add(Me.txt_QtyMaxBase)
        Me.Bloack2.Controls.Add(Me.txt_UnitBase)
        Me.Bloack2.Controls.Add(Me.txt_WarehousePositionEname)
        Me.Bloack2.Controls.Add(Me.txt_GroupPosition)
        Me.Bloack2.Controls.Add(Me.txt_DisplaySeq)
        Me.Bloack2.Controls.Add(Me.txt_HorizontalPosition)
        Me.Bloack2.Controls.Add(Me.txt_VerticalPosition)
        Me.Bloack2.Controls.Add(Me.txt_Remark)
        Me.Bloack2.Controls.Add(Me.txt_RollRemainder)
        Me.Bloack2.Controls.Add(Me.txt_WgtRemainder)
        Me.Bloack2.Controls.Add(Me.txt_MtsRemainder)
        Me.Bloack2.Controls.Add(Me.txt_YdsRemainder)
        Me.Bloack2.Location = New System.Drawing.Point(10, 3)
        Me.Bloack2.Name = "Bloack2"
        Me.Bloack2.Size = New System.Drawing.Size(649, 412)
        Me.Bloack2.TabIndex = 40
        '
        'txt_cdWarehouseGroup
        '
        Me.txt_cdWarehouseGroup.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdWarehouseGroup.ButtonEnabled = True
        Me.txt_cdWarehouseGroup.ButtonFont = Nothing
        Me.txt_cdWarehouseGroup.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdWarehouseGroup.ButtonName = "Const_WareHouseGroup"
        Me.txt_cdWarehouseGroup.ButtonTitle = "Warehouse Group"
        Me.txt_cdWarehouseGroup.Code = Nothing
        Me.txt_cdWarehouseGroup.Data = Nothing
        Me.txt_cdWarehouseGroup.DataDecimal = 0
        Me.txt_cdWarehouseGroup.DataLen = 0
        Me.txt_cdWarehouseGroup.DataValue = 1
        Me.txt_cdWarehouseGroup.Layoutpercent = New Decimal(New Integer() {335, 0, 0, 196608})
        Me.txt_cdWarehouseGroup.Location = New System.Drawing.Point(1, 1)
        Me.txt_cdWarehouseGroup.Margin = New System.Windows.Forms.Padding(1, 1, 583, 1)
        Me.txt_cdWarehouseGroup.Name = "txt_cdWarehouseGroup"
        Me.txt_cdWarehouseGroup.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdWarehouseGroup.Size = New System.Drawing.Size(482, 29)
        Me.txt_cdWarehouseGroup.TabIndex = 15
        Me.txt_cdWarehouseGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdWarehouseGroup.TextBoxAutoComplete = True
        Me.txt_cdWarehouseGroup.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdWarehouseGroup.TextEnabled = True
        Me.txt_cdWarehouseGroup.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdWarehouseGroup.TextMaxLength = 32767
        Me.txt_cdWarehouseGroup.TextMultiLine = False
        Me.txt_cdWarehouseGroup.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdWarehouseGroup.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdWarehouseGroup.UseSendTab = True
        '
        'txt_cdWarehouseCode
        '
        Me.txt_cdWarehouseCode.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdWarehouseCode.ButtonEnabled = True
        Me.txt_cdWarehouseCode.ButtonFont = Nothing
        Me.txt_cdWarehouseCode.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdWarehouseCode.ButtonName = ""
        Me.txt_cdWarehouseCode.ButtonTitle = "Warehouse Name"
        Me.txt_cdWarehouseCode.Code = Nothing
        Me.txt_cdWarehouseCode.Data = Nothing
        Me.txt_cdWarehouseCode.DataDecimal = 0
        Me.txt_cdWarehouseCode.DataLen = 0
        Me.txt_cdWarehouseCode.DataValue = 1
        Me.txt_cdWarehouseCode.Layoutpercent = New Decimal(New Integer() {335, 0, 0, 196608})
        Me.txt_cdWarehouseCode.Location = New System.Drawing.Point(1, 32)
        Me.txt_cdWarehouseCode.Margin = New System.Windows.Forms.Padding(1, 1, 583, 1)
        Me.txt_cdWarehouseCode.Name = "txt_cdWarehouseCode"
        Me.txt_cdWarehouseCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdWarehouseCode.Size = New System.Drawing.Size(482, 29)
        Me.txt_cdWarehouseCode.TabIndex = 16
        Me.txt_cdWarehouseCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdWarehouseCode.TextBoxAutoComplete = True
        Me.txt_cdWarehouseCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_cdWarehouseCode.TextEnabled = True
        Me.txt_cdWarehouseCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdWarehouseCode.TextMaxLength = 32767
        Me.txt_cdWarehouseCode.TextMultiLine = False
        Me.txt_cdWarehouseCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdWarehouseCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdWarehouseCode.UseSendTab = True
        '
        'txt_WarehousePositionCode
        '
        Me.txt_WarehousePositionCode.BackYesno = True
        Me.txt_WarehousePositionCode.Code = Nothing
        Me.txt_WarehousePositionCode.Data = Nothing
        Me.txt_WarehousePositionCode.DataDecimal = 0
        Me.txt_WarehousePositionCode.DataLen = 1
        Me.txt_WarehousePositionCode.DataValue = 0
        Me.txt_WarehousePositionCode.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_WarehousePositionCode.LableEnabled = True
        Me.txt_WarehousePositionCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionCode.LableTitle = "Warehouse Position"
        Me.txt_WarehousePositionCode.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_WarehousePositionCode.Location = New System.Drawing.Point(1, 63)
        Me.txt_WarehousePositionCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_WarehousePositionCode.Name = "txt_WarehousePositionCode"
        Me.txt_WarehousePositionCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_WarehousePositionCode.Size = New System.Drawing.Size(318, 29)
        Me.txt_WarehousePositionCode.TabIndex = 12
        Me.txt_WarehousePositionCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_WarehousePositionCode.TextBoxAutoComplete = False
        Me.txt_WarehousePositionCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionCode.TextEnabled = False
        Me.txt_WarehousePositionCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionCode.TextMaxLength = 32767
        Me.txt_WarehousePositionCode.TextMultiLine = False
        Me.txt_WarehousePositionCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_WarehousePositionCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_WarehousePositionCode.UseSendTab = True
        '
        'txt_DevelopmentCode
        '
        Me.txt_DevelopmentCode.BackYesno = False
        Me.txt_DevelopmentCode.Code = Nothing
        Me.txt_DevelopmentCode.Data = Nothing
        Me.txt_DevelopmentCode.DataDecimal = 0
        Me.txt_DevelopmentCode.DataLen = 0
        Me.txt_DevelopmentCode.DataValue = 0
        Me.txt_DevelopmentCode.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DevelopmentCode.LableEnabled = True
        Me.txt_DevelopmentCode.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DevelopmentCode.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.LableTitle = "Development"
        Me.txt_DevelopmentCode.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_DevelopmentCode.Location = New System.Drawing.Point(321, 63)
        Me.txt_DevelopmentCode.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DevelopmentCode.Name = "txt_DevelopmentCode"
        Me.txt_DevelopmentCode.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DevelopmentCode.Size = New System.Drawing.Size(319, 29)
        Me.txt_DevelopmentCode.TabIndex = 13
        Me.txt_DevelopmentCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DevelopmentCode.TextBoxAutoComplete = False
        Me.txt_DevelopmentCode.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DevelopmentCode.TextEnabled = True
        Me.txt_DevelopmentCode.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DevelopmentCode.TextMaxLength = 32767
        Me.txt_DevelopmentCode.TextMultiLine = False
        Me.txt_DevelopmentCode.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DevelopmentCode.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DevelopmentCode.UseSendTab = True
        '
        'txt_WarehousePositionName
        '
        Me.txt_WarehousePositionName.BackYesno = False
        Me.txt_WarehousePositionName.Code = Nothing
        Me.txt_WarehousePositionName.Data = Nothing
        Me.txt_WarehousePositionName.DataDecimal = 0
        Me.txt_WarehousePositionName.DataLen = 0
        Me.txt_WarehousePositionName.DataValue = 0
        Me.txt_WarehousePositionName.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_WarehousePositionName.LableEnabled = True
        Me.txt_WarehousePositionName.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionName.LableForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionName.LableTitle = "Position Name"
        Me.txt_WarehousePositionName.Layoutpercent = New Decimal(New Integer() {254, 0, 0, 196608})
        Me.txt_WarehousePositionName.Location = New System.Drawing.Point(1, 94)
        Me.txt_WarehousePositionName.Margin = New System.Windows.Forms.Padding(1, 1, 583, 1)
        Me.txt_WarehousePositionName.Name = "txt_WarehousePositionName"
        Me.txt_WarehousePositionName.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_WarehousePositionName.Size = New System.Drawing.Size(639, 29)
        Me.txt_WarehousePositionName.TabIndex = 72
        Me.txt_WarehousePositionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_WarehousePositionName.TextBoxAutoComplete = False
        Me.txt_WarehousePositionName.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionName.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionName.TextEnabled = True
        Me.txt_WarehousePositionName.TextForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionName.TextMaxLength = 32767
        Me.txt_WarehousePositionName.TextMultiLine = False
        Me.txt_WarehousePositionName.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_WarehousePositionName.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_WarehousePositionName.UseSendTab = True
        '
        'txt_WarehousePositionNameSimply
        '
        Me.txt_WarehousePositionNameSimply.BackYesno = False
        Me.txt_WarehousePositionNameSimply.Code = Nothing
        Me.txt_WarehousePositionNameSimply.Data = Nothing
        Me.txt_WarehousePositionNameSimply.DataDecimal = 0
        Me.txt_WarehousePositionNameSimply.DataLen = 0
        Me.txt_WarehousePositionNameSimply.DataValue = 0
        Me.txt_WarehousePositionNameSimply.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_WarehousePositionNameSimply.LableEnabled = True
        Me.txt_WarehousePositionNameSimply.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionNameSimply.LableForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionNameSimply.LableTitle = "Simple Name"
        Me.txt_WarehousePositionNameSimply.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_WarehousePositionNameSimply.Location = New System.Drawing.Point(1, 125)
        Me.txt_WarehousePositionNameSimply.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_WarehousePositionNameSimply.Name = "txt_WarehousePositionNameSimply"
        Me.txt_WarehousePositionNameSimply.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_WarehousePositionNameSimply.Size = New System.Drawing.Size(318, 29)
        Me.txt_WarehousePositionNameSimply.TabIndex = 75
        Me.txt_WarehousePositionNameSimply.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_WarehousePositionNameSimply.TextBoxAutoComplete = False
        Me.txt_WarehousePositionNameSimply.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionNameSimply.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionNameSimply.TextEnabled = True
        Me.txt_WarehousePositionNameSimply.TextForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionNameSimply.TextMaxLength = 32767
        Me.txt_WarehousePositionNameSimply.TextMultiLine = False
        Me.txt_WarehousePositionNameSimply.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_WarehousePositionNameSimply.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_WarehousePositionNameSimply.UseSendTab = True
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceLabel1.Code = Nothing
        Me.PeaceLabel1.Data = Nothing
        Me.PeaceLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceLabel1.Location = New System.Drawing.Point(321, 125)
        Me.PeaceLabel1.Margin = New System.Windows.Forms.Padding(1)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.Size = New System.Drawing.Size(161, 29)
        Me.PeaceLabel1.TabIndex = 77
        Me.PeaceLabel1.Text = "Use"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'PeacePanel2
        '
        Me.PeacePanel2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeacePanel2.Controls.Add(Me.rad_CheckUse2)
        Me.PeacePanel2.Controls.Add(Me.rad_CheckUse1)
        Me.PeacePanel2.Location = New System.Drawing.Point(483, 125)
        Me.PeacePanel2.Margin = New System.Windows.Forms.Padding(0, 1, 1, 1)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(156, 29)
        Me.PeacePanel2.TabIndex = 78
        '
        'rad_CheckUse2
        '
        Me.rad_CheckUse2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse2.Location = New System.Drawing.Point(80, 3)
        Me.rad_CheckUse2.Name = "rad_CheckUse2"
        Me.rad_CheckUse2.Size = New System.Drawing.Size(62, 16)
        Me.rad_CheckUse2.TabIndex = 1
        Me.rad_CheckUse2.Text = "No"
        Me.rad_CheckUse2.UseVisualStyleBackColor = True
        '
        'rad_CheckUse1
        '
        Me.rad_CheckUse1.Checked = True
        Me.rad_CheckUse1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.rad_CheckUse1.Location = New System.Drawing.Point(13, 1)
        Me.rad_CheckUse1.Name = "rad_CheckUse1"
        Me.rad_CheckUse1.Size = New System.Drawing.Size(52, 22)
        Me.rad_CheckUse1.TabIndex = 0
        Me.rad_CheckUse1.TabStop = True
        Me.rad_CheckUse1.Text = "Yes"
        Me.rad_CheckUse1.UseVisualStyleBackColor = True
        '
        'txt_QtyMaxBase
        '
        Me.txt_QtyMaxBase.BackYesno = False
        Me.txt_QtyMaxBase.Code = Nothing
        Me.txt_QtyMaxBase.Data = Nothing
        Me.txt_QtyMaxBase.DataDecimal = 0
        Me.txt_QtyMaxBase.DataLen = 0
        Me.txt_QtyMaxBase.DataValue = 0
        Me.txt_QtyMaxBase.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_QtyMaxBase.LableEnabled = True
        Me.txt_QtyMaxBase.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyMaxBase.LableForeColor = System.Drawing.Color.Empty
        Me.txt_QtyMaxBase.LableTitle = "Max Capacity"
        Me.txt_QtyMaxBase.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_QtyMaxBase.Location = New System.Drawing.Point(1, 156)
        Me.txt_QtyMaxBase.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_QtyMaxBase.Name = "txt_QtyMaxBase"
        Me.txt_QtyMaxBase.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_QtyMaxBase.Size = New System.Drawing.Size(318, 29)
        Me.txt_QtyMaxBase.TabIndex = 86
        Me.txt_QtyMaxBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_QtyMaxBase.TextBoxAutoComplete = True
        Me.txt_QtyMaxBase.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_QtyMaxBase.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_QtyMaxBase.TextEnabled = True
        Me.txt_QtyMaxBase.TextForeColor = System.Drawing.Color.Empty
        Me.txt_QtyMaxBase.TextMaxLength = 32767
        Me.txt_QtyMaxBase.TextMultiLine = False
        Me.txt_QtyMaxBase.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_QtyMaxBase.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_QtyMaxBase.UseSendTab = True
        '
        'txt_UnitBase
        '
        Me.txt_UnitBase.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_UnitBase.ButtonEnabled = True
        Me.txt_UnitBase.ButtonFont = Nothing
        Me.txt_UnitBase.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_UnitBase.ButtonName = "Const_UnitMaterial"
        Me.txt_UnitBase.ButtonTitle = "Capacity Unit"
        Me.txt_UnitBase.Code = Nothing
        Me.txt_UnitBase.Data = Nothing
        Me.txt_UnitBase.DataDecimal = 0
        Me.txt_UnitBase.DataLen = 0
        Me.txt_UnitBase.DataValue = 0
        Me.txt_UnitBase.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_UnitBase.Location = New System.Drawing.Point(321, 156)
        Me.txt_UnitBase.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_UnitBase.Name = "txt_UnitBase"
        Me.txt_UnitBase.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_UnitBase.Size = New System.Drawing.Size(318, 29)
        Me.txt_UnitBase.TabIndex = 85
        Me.txt_UnitBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_UnitBase.TextBoxAutoComplete = True
        Me.txt_UnitBase.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_UnitBase.TextEnabled = True
        Me.txt_UnitBase.TextForeColor = System.Drawing.Color.Empty
        Me.txt_UnitBase.TextMaxLength = 32767
        Me.txt_UnitBase.TextMultiLine = False
        Me.txt_UnitBase.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_UnitBase.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_UnitBase.UseSendTab = True
        '
        'txt_WarehousePositionEname
        '
        Me.txt_WarehousePositionEname.BackYesno = False
        Me.txt_WarehousePositionEname.Code = Nothing
        Me.txt_WarehousePositionEname.Data = Nothing
        Me.txt_WarehousePositionEname.DataDecimal = 0
        Me.txt_WarehousePositionEname.DataLen = 0
        Me.txt_WarehousePositionEname.DataValue = 0
        Me.txt_WarehousePositionEname.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_WarehousePositionEname.LableEnabled = True
        Me.txt_WarehousePositionEname.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionEname.LableForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionEname.LableTitle = "Position Foreign Name"
        Me.txt_WarehousePositionEname.Layoutpercent = New Decimal(New Integer() {254, 0, 0, 196608})
        Me.txt_WarehousePositionEname.Location = New System.Drawing.Point(1, 187)
        Me.txt_WarehousePositionEname.Margin = New System.Windows.Forms.Padding(1, 1, 583, 1)
        Me.txt_WarehousePositionEname.Name = "txt_WarehousePositionEname"
        Me.txt_WarehousePositionEname.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_WarehousePositionEname.Size = New System.Drawing.Size(639, 29)
        Me.txt_WarehousePositionEname.TabIndex = 79
        Me.txt_WarehousePositionEname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_WarehousePositionEname.TextBoxAutoComplete = False
        Me.txt_WarehousePositionEname.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionEname.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WarehousePositionEname.TextEnabled = True
        Me.txt_WarehousePositionEname.TextForeColor = System.Drawing.Color.Empty
        Me.txt_WarehousePositionEname.TextMaxLength = 32767
        Me.txt_WarehousePositionEname.TextMultiLine = False
        Me.txt_WarehousePositionEname.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_WarehousePositionEname.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_WarehousePositionEname.UseSendTab = True
        '
        'txt_GroupPosition
        '
        Me.txt_GroupPosition.BackYesno = False
        Me.txt_GroupPosition.Code = Nothing
        Me.txt_GroupPosition.Data = Nothing
        Me.txt_GroupPosition.DataDecimal = 0
        Me.txt_GroupPosition.DataLen = 0
        Me.txt_GroupPosition.DataValue = 0
        Me.txt_GroupPosition.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_GroupPosition.LableEnabled = True
        Me.txt_GroupPosition.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_GroupPosition.LableForeColor = System.Drawing.Color.Empty
        Me.txt_GroupPosition.LableTitle = "Position Group"
        Me.txt_GroupPosition.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_GroupPosition.Location = New System.Drawing.Point(1, 218)
        Me.txt_GroupPosition.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_GroupPosition.Name = "txt_GroupPosition"
        Me.txt_GroupPosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_GroupPosition.Size = New System.Drawing.Size(318, 29)
        Me.txt_GroupPosition.TabIndex = 80
        Me.txt_GroupPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_GroupPosition.TextBoxAutoComplete = False
        Me.txt_GroupPosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_GroupPosition.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_GroupPosition.TextEnabled = True
        Me.txt_GroupPosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_GroupPosition.TextMaxLength = 32767
        Me.txt_GroupPosition.TextMultiLine = False
        Me.txt_GroupPosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_GroupPosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_GroupPosition.UseSendTab = True
        '
        'txt_DisplaySeq
        '
        Me.txt_DisplaySeq.BackYesno = False
        Me.txt_DisplaySeq.Code = Nothing
        Me.txt_DisplaySeq.Data = Nothing
        Me.txt_DisplaySeq.DataDecimal = 0
        Me.txt_DisplaySeq.DataLen = 0
        Me.txt_DisplaySeq.DataValue = 0
        Me.txt_DisplaySeq.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_DisplaySeq.LableEnabled = True
        Me.txt_DisplaySeq.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DisplaySeq.LableForeColor = System.Drawing.Color.Empty
        Me.txt_DisplaySeq.LableTitle = "Display Seq"
        Me.txt_DisplaySeq.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_DisplaySeq.Location = New System.Drawing.Point(321, 218)
        Me.txt_DisplaySeq.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_DisplaySeq.Name = "txt_DisplaySeq"
        Me.txt_DisplaySeq.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_DisplaySeq.Size = New System.Drawing.Size(318, 29)
        Me.txt_DisplaySeq.TabIndex = 84
        Me.txt_DisplaySeq.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_DisplaySeq.TextBoxAutoComplete = False
        Me.txt_DisplaySeq.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_DisplaySeq.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_DisplaySeq.TextEnabled = True
        Me.txt_DisplaySeq.TextForeColor = System.Drawing.Color.Empty
        Me.txt_DisplaySeq.TextMaxLength = 32767
        Me.txt_DisplaySeq.TextMultiLine = False
        Me.txt_DisplaySeq.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_DisplaySeq.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_DisplaySeq.UseSendTab = True
        '
        'txt_HorizontalPosition
        '
        Me.txt_HorizontalPosition.BackYesno = False
        Me.txt_HorizontalPosition.Code = Nothing
        Me.txt_HorizontalPosition.Data = Nothing
        Me.txt_HorizontalPosition.DataDecimal = 0
        Me.txt_HorizontalPosition.DataLen = 0
        Me.txt_HorizontalPosition.DataValue = 0
        Me.txt_HorizontalPosition.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_HorizontalPosition.LableEnabled = True
        Me.txt_HorizontalPosition.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_HorizontalPosition.LableForeColor = System.Drawing.Color.Empty
        Me.txt_HorizontalPosition.LableTitle = "Horizon Line (X)"
        Me.txt_HorizontalPosition.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_HorizontalPosition.Location = New System.Drawing.Point(1, 249)
        Me.txt_HorizontalPosition.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_HorizontalPosition.Name = "txt_HorizontalPosition"
        Me.txt_HorizontalPosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_HorizontalPosition.Size = New System.Drawing.Size(318, 29)
        Me.txt_HorizontalPosition.TabIndex = 83
        Me.txt_HorizontalPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_HorizontalPosition.TextBoxAutoComplete = False
        Me.txt_HorizontalPosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_HorizontalPosition.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_HorizontalPosition.TextEnabled = True
        Me.txt_HorizontalPosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_HorizontalPosition.TextMaxLength = 32767
        Me.txt_HorizontalPosition.TextMultiLine = False
        Me.txt_HorizontalPosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_HorizontalPosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_HorizontalPosition.UseSendTab = True
        '
        'txt_VerticalPosition
        '
        Me.txt_VerticalPosition.BackYesno = False
        Me.txt_VerticalPosition.Code = Nothing
        Me.txt_VerticalPosition.Data = Nothing
        Me.txt_VerticalPosition.DataDecimal = 0
        Me.txt_VerticalPosition.DataLen = 0
        Me.txt_VerticalPosition.DataValue = 0
        Me.txt_VerticalPosition.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_VerticalPosition.LableEnabled = True
        Me.txt_VerticalPosition.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerticalPosition.LableForeColor = System.Drawing.Color.Empty
        Me.txt_VerticalPosition.LableTitle = "Vertical Line (Y)"
        Me.txt_VerticalPosition.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_VerticalPosition.Location = New System.Drawing.Point(321, 249)
        Me.txt_VerticalPosition.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_VerticalPosition.Name = "txt_VerticalPosition"
        Me.txt_VerticalPosition.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_VerticalPosition.Size = New System.Drawing.Size(318, 29)
        Me.txt_VerticalPosition.TabIndex = 84
        Me.txt_VerticalPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_VerticalPosition.TextBoxAutoComplete = True
        Me.txt_VerticalPosition.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_VerticalPosition.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_VerticalPosition.TextEnabled = True
        Me.txt_VerticalPosition.TextForeColor = System.Drawing.Color.Empty
        Me.txt_VerticalPosition.TextMaxLength = 32767
        Me.txt_VerticalPosition.TextMultiLine = False
        Me.txt_VerticalPosition.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_VerticalPosition.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_VerticalPosition.UseSendTab = True
        '
        'txt_Remark
        '
        Me.txt_Remark.BackYesno = False
        Me.txt_Remark.Code = Nothing
        Me.txt_Remark.Data = Nothing
        Me.txt_Remark.DataDecimal = 0
        Me.txt_Remark.DataLen = 0
        Me.txt_Remark.DataValue = 0
        Me.txt_Remark.LableBackColor = System.Drawing.SystemColors.Control
        Me.txt_Remark.LableEnabled = True
        Me.txt_Remark.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.LableForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.LableTitle = "Remark"
        Me.txt_Remark.Layoutpercent = New Decimal(New Integer() {253, 0, 0, 196608})
        Me.txt_Remark.Location = New System.Drawing.Point(1, 280)
        Me.txt_Remark.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_Remark.Name = "txt_Remark"
        Me.txt_Remark.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_Remark.Size = New System.Drawing.Size(642, 65)
        Me.txt_Remark.TabIndex = 18
        Me.txt_Remark.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_Remark.TextBoxAutoComplete = False
        Me.txt_Remark.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_Remark.TextEnabled = True
        Me.txt_Remark.TextForeColor = System.Drawing.Color.Empty
        Me.txt_Remark.TextMaxLength = 32767
        Me.txt_Remark.TextMultiLine = True
        Me.txt_Remark.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_Remark.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_Remark.UseSendTab = True
        '
        'txt_RollRemainder
        '
        Me.txt_RollRemainder.BackYesno = False
        Me.txt_RollRemainder.Code = Nothing
        Me.txt_RollRemainder.Data = Nothing
        Me.txt_RollRemainder.DataDecimal = 0
        Me.txt_RollRemainder.DataLen = 1
        Me.txt_RollRemainder.DataValue = 0
        Me.txt_RollRemainder.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_RollRemainder.LableEnabled = True
        Me.txt_RollRemainder.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RollRemainder.LableForeColor = System.Drawing.Color.Empty
        Me.txt_RollRemainder.LableTitle = "Roll Inventory"
        Me.txt_RollRemainder.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_RollRemainder.Location = New System.Drawing.Point(1, 347)
        Me.txt_RollRemainder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_RollRemainder.Name = "txt_RollRemainder"
        Me.txt_RollRemainder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_RollRemainder.Size = New System.Drawing.Size(318, 29)
        Me.txt_RollRemainder.TabIndex = 87
        Me.txt_RollRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_RollRemainder.TextBoxAutoComplete = False
        Me.txt_RollRemainder.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_RollRemainder.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_RollRemainder.TextEnabled = False
        Me.txt_RollRemainder.TextForeColor = System.Drawing.Color.Empty
        Me.txt_RollRemainder.TextMaxLength = 32767
        Me.txt_RollRemainder.TextMultiLine = False
        Me.txt_RollRemainder.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_RollRemainder.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_RollRemainder.UseSendTab = True
        '
        'txt_WgtRemainder
        '
        Me.txt_WgtRemainder.BackYesno = False
        Me.txt_WgtRemainder.Code = Nothing
        Me.txt_WgtRemainder.Data = Nothing
        Me.txt_WgtRemainder.DataDecimal = 0
        Me.txt_WgtRemainder.DataLen = 1
        Me.txt_WgtRemainder.DataValue = 0
        Me.txt_WgtRemainder.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_WgtRemainder.LableEnabled = True
        Me.txt_WgtRemainder.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WgtRemainder.LableForeColor = System.Drawing.Color.Empty
        Me.txt_WgtRemainder.LableTitle = "Weight Inventory"
        Me.txt_WgtRemainder.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_WgtRemainder.Location = New System.Drawing.Point(321, 347)
        Me.txt_WgtRemainder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_WgtRemainder.Name = "txt_WgtRemainder"
        Me.txt_WgtRemainder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_WgtRemainder.Size = New System.Drawing.Size(318, 29)
        Me.txt_WgtRemainder.TabIndex = 88
        Me.txt_WgtRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_WgtRemainder.TextBoxAutoComplete = False
        Me.txt_WgtRemainder.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_WgtRemainder.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_WgtRemainder.TextEnabled = False
        Me.txt_WgtRemainder.TextForeColor = System.Drawing.Color.Empty
        Me.txt_WgtRemainder.TextMaxLength = 32767
        Me.txt_WgtRemainder.TextMultiLine = False
        Me.txt_WgtRemainder.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_WgtRemainder.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_WgtRemainder.UseSendTab = True
        '
        'txt_MtsRemainder
        '
        Me.txt_MtsRemainder.BackYesno = False
        Me.txt_MtsRemainder.Code = Nothing
        Me.txt_MtsRemainder.Data = Nothing
        Me.txt_MtsRemainder.DataDecimal = 0
        Me.txt_MtsRemainder.DataLen = 1
        Me.txt_MtsRemainder.DataValue = 0
        Me.txt_MtsRemainder.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_MtsRemainder.LableEnabled = True
        Me.txt_MtsRemainder.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MtsRemainder.LableForeColor = System.Drawing.Color.Empty
        Me.txt_MtsRemainder.LableTitle = "Mts Inventory"
        Me.txt_MtsRemainder.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_MtsRemainder.Location = New System.Drawing.Point(1, 378)
        Me.txt_MtsRemainder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_MtsRemainder.Name = "txt_MtsRemainder"
        Me.txt_MtsRemainder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_MtsRemainder.Size = New System.Drawing.Size(318, 29)
        Me.txt_MtsRemainder.TabIndex = 89
        Me.txt_MtsRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_MtsRemainder.TextBoxAutoComplete = False
        Me.txt_MtsRemainder.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_MtsRemainder.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_MtsRemainder.TextEnabled = False
        Me.txt_MtsRemainder.TextForeColor = System.Drawing.Color.Empty
        Me.txt_MtsRemainder.TextMaxLength = 32767
        Me.txt_MtsRemainder.TextMultiLine = False
        Me.txt_MtsRemainder.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_MtsRemainder.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_MtsRemainder.UseSendTab = True
        '
        'txt_YdsRemainder
        '
        Me.txt_YdsRemainder.BackYesno = False
        Me.txt_YdsRemainder.Code = Nothing
        Me.txt_YdsRemainder.Data = Nothing
        Me.txt_YdsRemainder.DataDecimal = 0
        Me.txt_YdsRemainder.DataLen = 1
        Me.txt_YdsRemainder.DataValue = 0
        Me.txt_YdsRemainder.LableBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txt_YdsRemainder.LableEnabled = True
        Me.txt_YdsRemainder.LableFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_YdsRemainder.LableForeColor = System.Drawing.Color.Empty
        Me.txt_YdsRemainder.LableTitle = "Yds Inventory"
        Me.txt_YdsRemainder.Layoutpercent = New Decimal(New Integer() {51, 0, 0, 131072})
        Me.txt_YdsRemainder.Location = New System.Drawing.Point(321, 378)
        Me.txt_YdsRemainder.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_YdsRemainder.Name = "txt_YdsRemainder"
        Me.txt_YdsRemainder.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_YdsRemainder.Size = New System.Drawing.Size(318, 29)
        Me.txt_YdsRemainder.TabIndex = 90
        Me.txt_YdsRemainder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_YdsRemainder.TextBoxAutoComplete = False
        Me.txt_YdsRemainder.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_YdsRemainder.TextBoxFont = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_YdsRemainder.TextEnabled = False
        Me.txt_YdsRemainder.TextForeColor = System.Drawing.Color.Empty
        Me.txt_YdsRemainder.TextMaxLength = 32767
        Me.txt_YdsRemainder.TextMultiLine = False
        Me.txt_YdsRemainder.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_YdsRemainder.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_YdsRemainder.UseSendTab = True
        '
        'ISUD7271A
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(666, 459)
        Me.Controls.Add(Me.frm_Condition)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "ISUD7271A"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WAREHOUSE CODE PROCESSING (ISUD7271A)"
        Me.frm_Condition.ResumeLayout(False)
        Me.Frame4.ResumeLayout(False)
        Me.Bloack2.ResumeLayout(False)
        Me.PeacePanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents frm_Condition As PSMGlobal.PeacePanel
    Friend WithEvents Frame4 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_DEL As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents Bloack2 As PSMGlobal.PeacePanel
    Friend WithEvents txt_WarehousePositionCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_cdWarehouseGroup As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_cdWarehouseCode As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_Remark As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DevelopmentCode As PSMGlobal.SelectLabelText
    Friend WithEvents txt_WarehousePositionName As PSMGlobal.SelectLabelText
    Friend WithEvents txt_WarehousePositionNameSimply As PSMGlobal.SelectLabelText
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents rad_CheckUse2 As System.Windows.Forms.RadioButton
    Friend WithEvents rad_CheckUse1 As System.Windows.Forms.RadioButton
    Friend WithEvents txt_WarehousePositionEname As PSMGlobal.SelectLabelText
    Friend WithEvents txt_GroupPosition As PSMGlobal.SelectLabelText
    Friend WithEvents txt_HorizontalPosition As PSMGlobal.SelectLabelText
    Friend WithEvents txt_DisplaySeq As PSMGlobal.SelectLabelText
    Friend WithEvents txt_VerticalPosition As PSMGlobal.SelectLabelText
    Friend WithEvents txt_QtyMaxBase As PSMGlobal.SelectLabelText
    Friend WithEvents txt_UnitBase As PSMGlobal.SelectPeaceHLPButton
    Friend WithEvents txt_RollRemainder As PSMGlobal.SelectLabelText
    Friend WithEvents txt_WgtRemainder As PSMGlobal.SelectLabelText
    Friend WithEvents txt_MtsRemainder As PSMGlobal.SelectLabelText
    Friend WithEvents txt_YdsRemainder As PSMGlobal.SelectLabelText
End Class
