<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ISUD7231U
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ISUD7231U))
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_cdUnitMaterial = New PSMGlobal.SelectPeaceHLPButton()
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeacePanel1.Appearance.Options.UseBackColor = True
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.txt_cdUnitMaterial)
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel1)
        Me.PeacePanel1.Controls.Add(Me.cmd_Cancel)
        Me.PeacePanel1.Controls.Add(Me.cmd_OK)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(5, 6)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(259, 96)
        Me.PeacePanel1.TabIndex = 1
        Me.PeacePanel1.Tag = ""
        '
        'txt_cdUnitMaterial
        '
        Me.txt_cdUnitMaterial.BackYesno = False
        Me.txt_cdUnitMaterial.ButtonBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txt_cdUnitMaterial.ButtonEnabled = True
        Me.txt_cdUnitMaterial.ButtonFont = Nothing
        Me.txt_cdUnitMaterial.ButtonForeColor = System.Drawing.Color.Empty
        Me.txt_cdUnitMaterial.ButtonName = ""
        Me.txt_cdUnitMaterial.ButtonTitle = "Unit Material"
        Me.txt_cdUnitMaterial.Code = ""
        Me.txt_cdUnitMaterial.Data = ""
        Me.txt_cdUnitMaterial.DataDecimal = 0
        Me.txt_cdUnitMaterial.DataLen = 0
        Me.txt_cdUnitMaterial.DataValue = 1
        Me.txt_cdUnitMaterial.Layoutpercent = New Decimal(New Integer() {4, 0, 0, 65536})
        Me.txt_cdUnitMaterial.Location = New System.Drawing.Point(8, 29)
        Me.txt_cdUnitMaterial.Margin = New System.Windows.Forms.Padding(1)
        Me.txt_cdUnitMaterial.Name = "txt_cdUnitMaterial"
        Me.txt_cdUnitMaterial.PanelStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.txt_cdUnitMaterial.Size = New System.Drawing.Size(244, 21)
        Me.txt_cdUnitMaterial.TabIndex = 120
        Me.txt_cdUnitMaterial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txt_cdUnitMaterial.TextBoxAutoComplete = False
        Me.txt_cdUnitMaterial.TextboxBackColor = System.Drawing.Color.Empty
        Me.txt_cdUnitMaterial.TextBoxFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.txt_cdUnitMaterial.TextEnabled = True
        Me.txt_cdUnitMaterial.TextForeColor = System.Drawing.Color.Empty
        Me.txt_cdUnitMaterial.TextMaxLength = 32767
        Me.txt_cdUnitMaterial.TextMultiLine = False
        Me.txt_cdUnitMaterial.TextScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt_cdUnitMaterial.TextStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_cdUnitMaterial.UseSendTab = True
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(8, 10)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(157, 15)
        Me.PeaceLabel1.TabIndex = 16
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "Choose Unit Material"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(131, 58)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(121, 33)
        Me.cmd_Cancel.TabIndex = 15
        Me.cmd_Cancel.Text = "CLOSE(&X)"
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
        Me.cmd_OK.Location = New System.Drawing.Point(7, 58)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(121, 33)
        Me.cmd_OK.TabIndex = 14
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'ISUD7231U
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(271, 111)
        Me.Controls.Add(Me.PeacePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "ISUD7231U"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdate"
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_cdUnitMaterial As PSMGlobal.SelectPeaceHLPButton
End Class
