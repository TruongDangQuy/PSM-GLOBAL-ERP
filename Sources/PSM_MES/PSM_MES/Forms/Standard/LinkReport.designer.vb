<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LinkReport
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
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.cmb_LinkReport = New PSMGlobal.PeaceCombobox(Me.components)
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeacePanel1.Appearance.Options.UseBackColor = True
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel1)
        Me.PeacePanel1.Controls.Add(Me.cmd_Cancel)
        Me.PeacePanel1.Controls.Add(Me.cmd_OK)
        Me.PeacePanel1.Controls.Add(Me.cmb_LinkReport)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(5, 6)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(390, 80)
        Me.PeacePanel1.TabIndex = 1
        Me.PeacePanel1.Tag = ""
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
        Me.PeaceLabel1.Text = "Choose report name to print"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.[Default]
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.Cancel_16x16
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(263, 54)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(121, 19)
        Me.cmd_Cancel.TabIndex = 15
        Me.cmd_Cancel.Text = "Close(&X)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.Save_16x16
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(7, 54)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(121, 19)
        Me.cmd_OK.TabIndex = 14
        Me.cmd_OK.Text = "Save(&S)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'cmb_LinkReport
        '
        Me.cmb_LinkReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LinkReport.DTDec = 0
        Me.cmb_LinkReport.DTLen = 0
        Me.cmb_LinkReport.DTValue = 0
        Me.cmb_LinkReport.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmb_LinkReport.FormattingEnabled = True
        Me.cmb_LinkReport.InSelected = -1
        Me.cmb_LinkReport.ListIndex = 0
        Me.cmb_LinkReport.Location = New System.Drawing.Point(7, 27)
        Me.cmb_LinkReport.Name = "cmb_LinkReport"
        Me.cmb_LinkReport.NoClear = False
        Me.cmb_LinkReport.Size = New System.Drawing.Size(378, 22)
        Me.cmb_LinkReport.TabIndex = 13
        '
        'LinkReport
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(401, 91)
        Me.Controls.Add(Me.PeacePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "LinkReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdate"
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents cmb_LinkReport As PSMGlobal.PeaceCombobox
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
End Class
