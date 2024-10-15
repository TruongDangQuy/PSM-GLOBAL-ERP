<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PrintPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_PrintPreview))
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.chk_Bold = New PSMGlobal.PeaceCheckbox(Me.components)
        Me.cmd_FontDialog = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_POSY = New PSMGlobal.PeaceNumericupdown(Me.components)
        Me.PeaceLabel4 = New PSMGlobal.PeaceLabel(Me.components)
        Me.PeaceLabel3 = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_FontSize = New PSMGlobal.PeaceNumericupdown(Me.components)
        Me.txt_MaterialName = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_FontName = New PSMGlobal.PeaceLabel(Me.components)
        Me.txt_POSX = New PSMGlobal.PeaceNumericupdown(Me.components)
        Me.cmd_Preview = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        CType(Me.txt_POSY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_FontSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_POSX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeacePanel1.Appearance.Options.UseBackColor = True
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.chk_Bold)
        Me.PeacePanel1.Controls.Add(Me.cmd_FontDialog)
        Me.PeacePanel1.Controls.Add(Me.txt_POSY)
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel4)
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel3)
        Me.PeacePanel1.Controls.Add(Me.txt_FontSize)
        Me.PeacePanel1.Controls.Add(Me.txt_MaterialName)
        Me.PeacePanel1.Controls.Add(Me.txt_FontName)
        Me.PeacePanel1.Controls.Add(Me.txt_POSX)
        Me.PeacePanel1.Controls.Add(Me.cmd_Preview)
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel1)
        Me.PeacePanel1.Controls.Add(Me.cmd_Cancel)
        Me.PeacePanel1.Controls.Add(Me.cmd_OK)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(5, 6)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(429, 291)
        Me.PeacePanel1.TabIndex = 1
        Me.PeacePanel1.Tag = ""
        '
        'chk_Bold
        '
        Me.chk_Bold.AutoSize = True
        Me.chk_Bold.ButtonTitle = Nothing
        Me.chk_Bold.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Bold.Location = New System.Drawing.Point(350, 101)
        Me.chk_Bold.Name = "chk_Bold"
        Me.chk_Bold.Size = New System.Drawing.Size(50, 17)
        Me.chk_Bold.TabIndex = 26
        Me.chk_Bold.Text = "Bold"
        Me.chk_Bold.UseVisualStyleBackColor = True
        '
        'cmd_FontDialog
        '
        Me.cmd_FontDialog.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_FontDialog.Appearance.Options.UseFont = True
        Me.cmd_FontDialog.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_FontDialog.ButtonTitle = Nothing
        Me.cmd_FontDialog.Code = Nothing
        Me.cmd_FontDialog.Data = Nothing
        Me.cmd_FontDialog.ImageAlign = 0
        Me.cmd_FontDialog.Location = New System.Drawing.Point(11, 91)
        Me.cmd_FontDialog.Name = "cmd_FontDialog"
        Me.cmd_FontDialog.Size = New System.Drawing.Size(126, 38)
        Me.cmd_FontDialog.TabIndex = 25
        Me.cmd_FontDialog.Text = "Font Click"
        Me.cmd_FontDialog.UseVisualStyleBackColor = False
        '
        'txt_POSY
        '
        Me.txt_POSY.DecimalPlaces = 2
        Me.txt_POSY.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSY.Location = New System.Drawing.Point(280, 189)
        Me.txt_POSY.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_POSY.Name = "txt_POSY"
        Me.txt_POSY.Size = New System.Drawing.Size(120, 38)
        Me.txt_POSY.TabIndex = 24
        Me.txt_POSY.Value = New Decimal(New Integer() {3, 0, 0, 65536})
        '
        'PeaceLabel4
        '
        Me.PeaceLabel4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel4.ButtonTitle = Nothing
        Me.PeaceLabel4.Code = ""
        Me.PeaceLabel4.Data = ""
        Me.PeaceLabel4.DTDec = 0
        Me.PeaceLabel4.DTLen = 0
        Me.PeaceLabel4.DTValue = 0
        Me.PeaceLabel4.Location = New System.Drawing.Point(7, 189)
        Me.PeaceLabel4.Name = "PeaceLabel4"
        Me.PeaceLabel4.NoClear = False
        Me.PeaceLabel4.Size = New System.Drawing.Size(184, 43)
        Me.PeaceLabel4.TabIndex = 23
        Me.PeaceLabel4.Tag = ""
        Me.PeaceLabel4.Text = "POSTION Y"
        Me.PeaceLabel4.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'PeaceLabel3
        '
        Me.PeaceLabel3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel3.ButtonTitle = Nothing
        Me.PeaceLabel3.Code = ""
        Me.PeaceLabel3.Data = ""
        Me.PeaceLabel3.DTDec = 0
        Me.PeaceLabel3.DTLen = 0
        Me.PeaceLabel3.DTValue = 0
        Me.PeaceLabel3.Location = New System.Drawing.Point(7, 136)
        Me.PeaceLabel3.Name = "PeaceLabel3"
        Me.PeaceLabel3.NoClear = False
        Me.PeaceLabel3.Size = New System.Drawing.Size(192, 43)
        Me.PeaceLabel3.TabIndex = 22
        Me.PeaceLabel3.Tag = ""
        Me.PeaceLabel3.Text = "POSITION X"
        Me.PeaceLabel3.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_FontSize
        '
        Me.txt_FontSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_FontSize.Location = New System.Drawing.Point(276, 92)
        Me.txt_FontSize.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txt_FontSize.Name = "txt_FontSize"
        Me.txt_FontSize.Size = New System.Drawing.Size(68, 38)
        Me.txt_FontSize.TabIndex = 21
        Me.txt_FontSize.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'txt_MaterialName
        '
        Me.txt_MaterialName.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.txt_MaterialName.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.txt_MaterialName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_MaterialName.ButtonTitle = Nothing
        Me.txt_MaterialName.Code = ""
        Me.txt_MaterialName.Data = ""
        Me.txt_MaterialName.DTDec = 0
        Me.txt_MaterialName.DTLen = 0
        Me.txt_MaterialName.DTValue = 0
        Me.txt_MaterialName.Location = New System.Drawing.Point(7, 25)
        Me.txt_MaterialName.Name = "txt_MaterialName"
        Me.txt_MaterialName.NoClear = False
        Me.txt_MaterialName.Size = New System.Drawing.Size(0, 43)
        Me.txt_MaterialName.TabIndex = 20
        Me.txt_MaterialName.Tag = ""
        Me.txt_MaterialName.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_FontName
        '
        Me.txt_FontName.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.txt_FontName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_FontName.ButtonTitle = Nothing
        Me.txt_FontName.Code = ""
        Me.txt_FontName.Data = ""
        Me.txt_FontName.DTDec = 0
        Me.txt_FontName.DTLen = 0
        Me.txt_FontName.DTValue = 0
        Me.txt_FontName.Location = New System.Drawing.Point(143, 99)
        Me.txt_FontName.Name = "txt_FontName"
        Me.txt_FontName.NoClear = False
        Me.txt_FontName.Size = New System.Drawing.Size(35, 20)
        Me.txt_FontName.TabIndex = 19
        Me.txt_FontName.Tag = ""
        Me.txt_FontName.Text = "Tahoma"
        Me.txt_FontName.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'txt_POSX
        '
        Me.txt_POSX.DecimalPlaces = 2
        Me.txt_POSX.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_POSX.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.txt_POSX.Location = New System.Drawing.Point(280, 136)
        Me.txt_POSX.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_POSX.Name = "txt_POSX"
        Me.txt_POSX.Size = New System.Drawing.Size(120, 38)
        Me.txt_POSX.TabIndex = 18
        Me.txt_POSX.Value = New Decimal(New Integer() {1, 0, 0, 65536})
        '
        'cmd_Preview
        '
        Me.cmd_Preview.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Preview.Appearance.Options.UseFont = True
        Me.cmd_Preview.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Preview.ButtonTitle = Nothing
        Me.cmd_Preview.Code = Nothing
        Me.cmd_Preview.Data = Nothing
        Me.cmd_Preview.Image = Global.PSMGlobal.My.Resources.Resources.edit
        Me.cmd_Preview.ImageAlign = 16
        Me.cmd_Preview.Location = New System.Drawing.Point(143, 246)
        Me.cmd_Preview.Name = "cmd_Preview"
        Me.cmd_Preview.Size = New System.Drawing.Size(131, 33)
        Me.cmd_Preview.TabIndex = 17
        Me.cmd_Preview.Text = "PREVIEW(&S)"
        Me.cmd_Preview.UseVisualStyleBackColor = False
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
        Me.PeaceLabel1.Size = New System.Drawing.Size(161, 15)
        Me.PeaceLabel1.TabIndex = 16
        Me.PeaceLabel1.Tag = ""
        Me.PeaceLabel1.Text = "Choose report name to print"
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(280, 246)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(131, 33)
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
        Me.cmd_OK.Location = New System.Drawing.Point(6, 246)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(131, 33)
        Me.cmd_OK.TabIndex = 14
        Me.cmd_OK.Text = "SAVE(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frm_PrintPreview
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(445, 309)
        Me.Controls.Add(Me.PeacePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "frm_PrintPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdate"
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        CType(Me.txt_POSY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_FontSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_POSX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents cmd_Preview As PSMGlobal.PeaceButton
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents txt_FontName As PSMGlobal.PeaceLabel
    Friend WithEvents txt_POSX As PSMGlobal.PeaceNumericupdown
    Friend WithEvents PeaceLabel4 As PSMGlobal.PeaceLabel
    Friend WithEvents PeaceLabel3 As PSMGlobal.PeaceLabel
    Friend WithEvents txt_FontSize As PSMGlobal.PeaceNumericupdown
    Friend WithEvents txt_MaterialName As PSMGlobal.PeaceLabel
    Friend WithEvents cmd_FontDialog As PSMGlobal.PeaceButton
    Friend WithEvents txt_POSY As PSMGlobal.PeaceNumericupdown
    Friend WithEvents chk_Bold As PSMGlobal.PeaceCheckbox
End Class
