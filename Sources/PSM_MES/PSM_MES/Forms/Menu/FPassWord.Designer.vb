<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPassWord
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
        Me.cmd_OK = New PSMGlobal.PeaceButton(Me.components)
        Me.TXT_PASSWORD = New System.Windows.Forms.TextBox()
        Me.Button2 = New PSMGlobal.PeaceButton(Me.components)
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.cmd_Cancel = New PSMGlobal.PeaceButton(Me.components)
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_OK
        '
        Me.cmd_OK.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmd_OK.Appearance.Options.UseFont = True
        Me.cmd_OK.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_OK.ButtonTitle = Nothing
        Me.cmd_OK.Code = Nothing
        Me.cmd_OK.Data = Nothing
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.Edit_16x16
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(3, 28)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(86, 21)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "Save (&F2)"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'TXT_PASSWORD
        '
        Me.TXT_PASSWORD.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TXT_PASSWORD.Location = New System.Drawing.Point(94, 3)
        Me.TXT_PASSWORD.Name = "TXT_PASSWORD"
        Me.TXT_PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TXT_PASSWORD.Size = New System.Drawing.Size(93, 22)
        Me.TXT_PASSWORD.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Button2.Appearance.Options.UseFont = True
        Me.Button2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.Button2.ButtonTitle = Nothing
        Me.Button2.Code = Nothing
        Me.Button2.Data = Nothing
        Me.Button2.ImageAlign = 0
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 21)
        Me.Button2.TabIndex = 0
        Me.Button2.Text = "Password"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Controls.Add(Me.TXT_PASSWORD)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(7, 4)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(192, 52)
        Me.FlowLayoutPanel1.TabIndex = 2
        Me.FlowLayoutPanel1.Tag = ""
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cmd_Cancel.Appearance.Options.UseFont = True
        Me.cmd_Cancel.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Cancel.ButtonTitle = Nothing
        Me.cmd_Cancel.Code = Nothing
        Me.cmd_Cancel.Data = Nothing
        Me.cmd_Cancel.Image = Global.PSMGlobal.My.Resources.Resources.delete
        Me.cmd_Cancel.ImageAlign = 16
        Me.cmd_Cancel.Location = New System.Drawing.Point(94, 30)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(92, 18)
        Me.cmd_Cancel.TabIndex = 2
        Me.cmd_Cancel.Text = "Close (&F4)"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'FPassWord
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(204, 59)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FPassWord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PASSWORDFORM"
        Me.TopMost = True
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents TXT_PASSWORD As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As PSMGlobal.PeaceButton
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
End Class
