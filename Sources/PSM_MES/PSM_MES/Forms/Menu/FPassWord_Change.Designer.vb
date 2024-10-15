<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPassWord_Change
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
        Me.txt_NewPW1 = New System.Windows.Forms.TextBox()
        Me.lbl_NewPW1 = New PSMGlobal.PeaceButton(Me.components)
        Me.FlowLayoutPanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.lbl_NewPW2 = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_NewPW2 = New System.Windows.Forms.TextBox()
        Me.lbl_OldPW = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_OldPW = New System.Windows.Forms.TextBox()
        Me.lbl_ID = New PSMGlobal.PeaceButton(Me.components)
        Me.txt_ID = New System.Windows.Forms.TextBox()
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
        Me.cmd_OK.Image = Global.PSMGlobal.My.Resources.Resources.save
        Me.cmd_OK.ImageAlign = 16
        Me.cmd_OK.Location = New System.Drawing.Point(5, 135)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(152, 32)
        Me.cmd_OK.TabIndex = 4
        Me.cmd_OK.Text = "OK"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'txt_NewPW1
        '
        Me.txt_NewPW1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NewPW1.Location = New System.Drawing.Point(159, 78)
        Me.txt_NewPW1.Name = "txt_NewPW1"
        Me.txt_NewPW1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_NewPW1.Size = New System.Drawing.Size(158, 22)
        Me.txt_NewPW1.TabIndex = 2
        '
        'lbl_NewPW1
        '
        Me.lbl_NewPW1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_NewPW1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_NewPW1.Appearance.Options.UseBackColor = True
        Me.lbl_NewPW1.Appearance.Options.UseFont = True
        Me.lbl_NewPW1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_NewPW1.ButtonTitle = Nothing
        Me.lbl_NewPW1.Code = Nothing
        Me.lbl_NewPW1.Data = Nothing
        Me.lbl_NewPW1.ImageAlign = 0
        Me.lbl_NewPW1.Location = New System.Drawing.Point(3, 77)
        Me.lbl_NewPW1.Name = "lbl_NewPW1"
        Me.lbl_NewPW1.Size = New System.Drawing.Size(152, 24)
        Me.lbl_NewPW1.TabIndex = 0
        Me.lbl_NewPW1.TabStop = False
        Me.lbl_NewPW1.Text = "New Password"
        Me.lbl_NewPW1.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.FlowLayoutPanel1.Code = ""
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_NewPW2)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_NewPW2)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_OldPW)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_OldPW)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_ID)
        Me.FlowLayoutPanel1.Controls.Add(Me.lbl_NewPW1)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_NewPW1)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_OK)
        Me.FlowLayoutPanel1.Controls.Add(Me.cmd_Cancel)
        Me.FlowLayoutPanel1.Data = ""
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(7, 4)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(323, 173)
        Me.FlowLayoutPanel1.TabIndex = 0
        Me.FlowLayoutPanel1.Tag = ""
        '
        'lbl_NewPW2
        '
        Me.lbl_NewPW2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_NewPW2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_NewPW2.Appearance.Options.UseBackColor = True
        Me.lbl_NewPW2.Appearance.Options.UseFont = True
        Me.lbl_NewPW2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_NewPW2.ButtonTitle = Nothing
        Me.lbl_NewPW2.Code = Nothing
        Me.lbl_NewPW2.Data = Nothing
        Me.lbl_NewPW2.ImageAlign = 0
        Me.lbl_NewPW2.Location = New System.Drawing.Point(3, 105)
        Me.lbl_NewPW2.Name = "lbl_NewPW2"
        Me.lbl_NewPW2.Size = New System.Drawing.Size(152, 24)
        Me.lbl_NewPW2.TabIndex = 7
        Me.lbl_NewPW2.TabStop = False
        Me.lbl_NewPW2.Text = "New Password Again"
        Me.lbl_NewPW2.UseVisualStyleBackColor = False
        '
        'txt_NewPW2
        '
        Me.txt_NewPW2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_NewPW2.Location = New System.Drawing.Point(159, 106)
        Me.txt_NewPW2.Name = "txt_NewPW2"
        Me.txt_NewPW2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_NewPW2.Size = New System.Drawing.Size(158, 22)
        Me.txt_NewPW2.TabIndex = 3
        '
        'lbl_OldPW
        '
        Me.lbl_OldPW.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_OldPW.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_OldPW.Appearance.Options.UseBackColor = True
        Me.lbl_OldPW.Appearance.Options.UseFont = True
        Me.lbl_OldPW.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_OldPW.ButtonTitle = Nothing
        Me.lbl_OldPW.Code = Nothing
        Me.lbl_OldPW.Data = Nothing
        Me.lbl_OldPW.ImageAlign = 0
        Me.lbl_OldPW.Location = New System.Drawing.Point(4, 36)
        Me.lbl_OldPW.Name = "lbl_OldPW"
        Me.lbl_OldPW.Size = New System.Drawing.Size(152, 23)
        Me.lbl_OldPW.TabIndex = 5
        Me.lbl_OldPW.TabStop = False
        Me.lbl_OldPW.Text = "Old Password"
        Me.lbl_OldPW.UseVisualStyleBackColor = False
        '
        'txt_OldPW
        '
        Me.txt_OldPW.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_OldPW.Location = New System.Drawing.Point(160, 36)
        Me.txt_OldPW.Name = "txt_OldPW"
        Me.txt_OldPW.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_OldPW.Size = New System.Drawing.Size(158, 22)
        Me.txt_OldPW.TabIndex = 1
        '
        'lbl_ID
        '
        Me.lbl_ID.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_ID.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_ID.Appearance.Options.UseBackColor = True
        Me.lbl_ID.Appearance.Options.UseFont = True
        Me.lbl_ID.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_ID.ButtonTitle = Nothing
        Me.lbl_ID.Code = Nothing
        Me.lbl_ID.Data = Nothing
        Me.lbl_ID.ImageAlign = 0
        Me.lbl_ID.Location = New System.Drawing.Point(4, 8)
        Me.lbl_ID.Name = "lbl_ID"
        Me.lbl_ID.Size = New System.Drawing.Size(152, 23)
        Me.lbl_ID.TabIndex = 3
        Me.lbl_ID.TabStop = False
        Me.lbl_ID.Text = "ID"
        Me.lbl_ID.UseVisualStyleBackColor = False
        '
        'txt_ID
        '
        Me.txt_ID.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_ID.Location = New System.Drawing.Point(160, 8)
        Me.txt_ID.Name = "txt_ID"
        Me.txt_ID.Size = New System.Drawing.Size(158, 22)
        Me.txt_ID.TabIndex = 0
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
        Me.cmd_Cancel.Location = New System.Drawing.Point(161, 138)
        Me.cmd_Cancel.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(158, 29)
        Me.cmd_Cancel.TabIndex = 5
        Me.cmd_Cancel.Text = "CANCEL"
        Me.cmd_Cancel.UseVisualStyleBackColor = False
        '
        'FPassWord_Change
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(345, 184)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FPassWord_Change"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PASSWORDFORM"
        Me.TopMost = True
        CType(Me.FlowLayoutPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents txt_NewPW1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NewPW1 As PSMGlobal.PeaceButton
    Friend WithEvents FlowLayoutPanel1 As PSMGlobal.PeacePanel
    Friend WithEvents cmd_Cancel As PSMGlobal.PeaceButton
    Friend WithEvents lbl_NewPW2 As PSMGlobal.PeaceButton
    Friend WithEvents txt_NewPW2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl_OldPW As PSMGlobal.PeaceButton
    Friend WithEvents txt_OldPW As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ID As PSMGlobal.PeaceButton
    Friend WithEvents txt_ID As System.Windows.Forms.TextBox
End Class
