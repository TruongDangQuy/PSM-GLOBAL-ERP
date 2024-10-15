<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Etc_login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Etc_login))
        Me.txt_Infor = New System.Windows.Forms.TextBox()
        Me.chk_PW = New System.Windows.Forms.CheckBox()
        Me.cmd_Close = New PSMGlobal.PeaceButton(Me.components)
        Me.cmd_Login = New PSMGlobal.PeaceButton(Me.components)
        Me.cmb_SET = New System.Windows.Forms.ComboBox()
        Me.cmb_POS = New System.Windows.Forms.ComboBox()
        Me.cmb_NATION = New System.Windows.Forms.ComboBox()
        Me.cmb_ID = New System.Windows.Forms.ComboBox()
        Me.cmb_FACT = New System.Windows.Forms.ComboBox()
        Me.lbl_NameProject = New System.Windows.Forms.Label()
        Me.lbl_ContactERPTeam = New System.Windows.Forms.Label()
        Me.lbl_Login = New System.Windows.Forms.Label()
        Me.chk_ShowPassword = New System.Windows.Forms.CheckBox()
        Me.lbl_ChangePassword = New System.Windows.Forms.Label()
        Me.lbl_Password = New System.Windows.Forms.Label()
        Me.lbl_Username = New System.Windows.Forms.Label()
        Me.lbl_DoHaveAcount = New System.Windows.Forms.Label()
        Me.PeacePanel1 = New PSMGlobal.PeacePanel(Me.components)
        Me.PeacePanel2 = New PSMGlobal.PeacePanel(Me.components)
        Me.PeacePanel3 = New PSMGlobal.PeacePanel(Me.components)
        Me.txt_PASS = New System.Windows.Forms.TextBox()
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel1.SuspendLayout()
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PeacePanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_Infor
        '
        Me.txt_Infor.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_Infor.Location = New System.Drawing.Point(446, 430)
        Me.txt_Infor.Multiline = True
        Me.txt_Infor.Name = "txt_Infor"
        Me.txt_Infor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txt_Infor.Size = New System.Drawing.Size(566, 123)
        Me.txt_Infor.TabIndex = 7
        Me.txt_Infor.TabStop = False
        Me.txt_Infor.Text = "Chào mừng đến với hệ thống WHM của CHANG SHUEN CO., LTD!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Xin gửi đến toàn thể an" & _
    "h chị một ngày tốt lành." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Chúc anh chị một ngày làm việc hiệu quả và đầy thành c" & _
    "ông!"
        '
        'chk_PW
        '
        Me.chk_PW.AutoSize = True
        Me.chk_PW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_PW.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.chk_PW.Location = New System.Drawing.Point(108, 363)
        Me.chk_PW.Name = "chk_PW"
        Me.chk_PW.Size = New System.Drawing.Size(116, 23)
        Me.chk_PW.TabIndex = 5
        Me.chk_PW.TabStop = False
        Me.chk_PW.Text = "Remember Me"
        Me.chk_PW.UseVisualStyleBackColor = True
        '
        'cmd_Close
        '
        Me.cmd_Close.Appearance.BackColor = System.Drawing.Color.DarkGray
        Me.cmd_Close.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Close.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmd_Close.Appearance.Options.UseBackColor = True
        Me.cmd_Close.Appearance.Options.UseFont = True
        Me.cmd_Close.Appearance.Options.UseForeColor = True
        Me.cmd_Close.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Close.ButtonTitle = Nothing
        Me.cmd_Close.Code = Nothing
        Me.cmd_Close.Data = Nothing
        Me.cmd_Close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_Close.ImageAlign = 0
        Me.cmd_Close.Location = New System.Drawing.Point(102, 431)
        Me.cmd_Close.Name = "cmd_Close"
        Me.cmd_Close.Size = New System.Drawing.Size(291, 33)
        Me.cmd_Close.TabIndex = 9
        Me.cmd_Close.TabStop = False
        Me.cmd_Close.Text = "CLOSE"
        Me.cmd_Close.UseVisualStyleBackColor = False
        '
        'cmd_Login
        '
        Me.cmd_Login.Appearance.BackColor = System.Drawing.Color.DodgerBlue
        Me.cmd_Login.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cmd_Login.Appearance.ForeColor = System.Drawing.Color.White
        Me.cmd_Login.Appearance.Options.UseBackColor = True
        Me.cmd_Login.Appearance.Options.UseFont = True
        Me.cmd_Login.Appearance.Options.UseForeColor = True
        Me.cmd_Login.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.cmd_Login.ButtonTitle = Nothing
        Me.cmd_Login.Code = Nothing
        Me.cmd_Login.Data = Nothing
        Me.cmd_Login.ImageAlign = 0
        Me.cmd_Login.Location = New System.Drawing.Point(104, 392)
        Me.cmd_Login.Name = "cmd_Login"
        Me.cmd_Login.Size = New System.Drawing.Size(291, 33)
        Me.cmd_Login.TabIndex = 8
        Me.cmd_Login.Text = "LOGIN"
        Me.cmd_Login.UseVisualStyleBackColor = False
        '
        'cmb_SET
        '
        Me.cmb_SET.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SET.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cmb_SET.FormattingEnabled = True
        Me.cmb_SET.Location = New System.Drawing.Point(281, 147)
        Me.cmb_SET.Name = "cmb_SET"
        Me.cmb_SET.Size = New System.Drawing.Size(100, 26)
        Me.cmb_SET.TabIndex = 4
        Me.cmb_SET.TabStop = False
        Me.cmb_SET.Visible = False
        '
        'cmb_POS
        '
        Me.cmb_POS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_POS.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.cmb_POS.FormattingEnabled = True
        Me.cmb_POS.Location = New System.Drawing.Point(281, 246)
        Me.cmb_POS.Name = "cmb_POS"
        Me.cmb_POS.Size = New System.Drawing.Size(100, 25)
        Me.cmb_POS.TabIndex = 3
        Me.cmb_POS.TabStop = False
        '
        'cmb_NATION
        '
        Me.cmb_NATION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NATION.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.cmb_NATION.FormattingEnabled = True
        Me.cmb_NATION.Location = New System.Drawing.Point(187, 5)
        Me.cmb_NATION.Name = "cmb_NATION"
        Me.cmb_NATION.Size = New System.Drawing.Size(100, 25)
        Me.cmb_NATION.TabIndex = 6
        Me.cmb_NATION.TabStop = False
        '
        'cmb_ID
        '
        Me.cmb_ID.BackColor = System.Drawing.SystemColors.Control
        Me.cmb_ID.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.cmb_ID.FormattingEnabled = True
        Me.cmb_ID.Location = New System.Drawing.Point(99, 246)
        Me.cmb_ID.Name = "cmb_ID"
        Me.cmb_ID.Size = New System.Drawing.Size(179, 27)
        Me.cmb_ID.TabIndex = 1
        '
        'cmb_FACT
        '
        Me.cmb_FACT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FACT.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.cmb_FACT.FormattingEnabled = True
        Me.cmb_FACT.Location = New System.Drawing.Point(5, 5)
        Me.cmb_FACT.Name = "cmb_FACT"
        Me.cmb_FACT.Size = New System.Drawing.Size(179, 25)
        Me.cmb_FACT.TabIndex = 0
        Me.cmb_FACT.TabStop = False
        '
        'lbl_NameProject
        '
        Me.lbl_NameProject.AutoSize = True
        Me.lbl_NameProject.BackColor = System.Drawing.Color.White
        Me.lbl_NameProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_NameProject.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NameProject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lbl_NameProject.Location = New System.Drawing.Point(325, 63)
        Me.lbl_NameProject.Name = "lbl_NameProject"
        Me.lbl_NameProject.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lbl_NameProject.Size = New System.Drawing.Size(73, 27)
        Me.lbl_NameProject.TabIndex = 14
        Me.lbl_NameProject.Text = "WHM"
        Me.lbl_NameProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_ContactERPTeam
        '
        Me.lbl_ContactERPTeam.AutoSize = True
        Me.lbl_ContactERPTeam.BackColor = System.Drawing.Color.White
        Me.lbl_ContactERPTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ContactERPTeam.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ContactERPTeam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.lbl_ContactERPTeam.Location = New System.Drawing.Point(100, 123)
        Me.lbl_ContactERPTeam.Name = "lbl_ContactERPTeam"
        Me.lbl_ContactERPTeam.Size = New System.Drawing.Size(95, 14)
        Me.lbl_ContactERPTeam.TabIndex = 15
        Me.lbl_ContactERPTeam.Text = "Contact ERPTeam"
        '
        'lbl_Login
        '
        Me.lbl_Login.AutoSize = True
        Me.lbl_Login.BackColor = System.Drawing.Color.White
        Me.lbl_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Login.Font = New System.Drawing.Font("Times New Roman", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.lbl_Login.Location = New System.Drawing.Point(95, 63)
        Me.lbl_Login.Name = "lbl_Login"
        Me.lbl_Login.Size = New System.Drawing.Size(118, 45)
        Me.lbl_Login.TabIndex = 17
        Me.lbl_Login.Text = "Login"
        '
        'chk_ShowPassword
        '
        Me.chk_ShowPassword.AutoSize = True
        Me.chk_ShowPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.chk_ShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chk_ShowPassword.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ShowPassword.Location = New System.Drawing.Point(283, 323)
        Me.chk_ShowPassword.Name = "chk_ShowPassword"
        Me.chk_ShowPassword.Size = New System.Drawing.Size(100, 19)
        Me.chk_ShowPassword.TabIndex = 18
        Me.chk_ShowPassword.Text = "Show password"
        Me.chk_ShowPassword.UseVisualStyleBackColor = False
        '
        'lbl_ChangePassword
        '
        Me.lbl_ChangePassword.AutoSize = True
        Me.lbl_ChangePassword.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ChangePassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lbl_ChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_ChangePassword.Font = New System.Drawing.Font("Times New Roman", 10.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.lbl_ChangePassword.ForeColor = System.Drawing.Color.Blue
        Me.lbl_ChangePassword.Location = New System.Drawing.Point(280, 363)
        Me.lbl_ChangePassword.Name = "lbl_ChangePassword"
        Me.lbl_ChangePassword.Size = New System.Drawing.Size(115, 16)
        Me.lbl_ChangePassword.TabIndex = 19
        Me.lbl_ChangePassword.Text = "Change password !"
        '
        'lbl_Password
        '
        Me.lbl_Password.AutoSize = True
        Me.lbl_Password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_Password.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbl_Password.Location = New System.Drawing.Point(102, 294)
        Me.lbl_Password.Name = "lbl_Password"
        Me.lbl_Password.Size = New System.Drawing.Size(69, 19)
        Me.lbl_Password.TabIndex = 20
        Me.lbl_Password.Text = "Password"
        '
        'lbl_Username
        '
        Me.lbl_Username.AutoSize = True
        Me.lbl_Username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Username.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lbl_Username.Location = New System.Drawing.Point(104, 219)
        Me.lbl_Username.Name = "lbl_Username"
        Me.lbl_Username.Size = New System.Drawing.Size(70, 19)
        Me.lbl_Username.TabIndex = 21
        Me.lbl_Username.Text = "Username"
        '
        'lbl_DoHaveAcount
        '
        Me.lbl_DoHaveAcount.AutoSize = True
        Me.lbl_DoHaveAcount.BackColor = System.Drawing.Color.White
        Me.lbl_DoHaveAcount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbl_DoHaveAcount.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DoHaveAcount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(174, Byte), Integer))
        Me.lbl_DoHaveAcount.Location = New System.Drawing.Point(100, 109)
        Me.lbl_DoHaveAcount.Name = "lbl_DoHaveAcount"
        Me.lbl_DoHaveAcount.Size = New System.Drawing.Size(143, 14)
        Me.lbl_DoHaveAcount.TabIndex = 22
        Me.lbl_DoHaveAcount.Text = "Doesn't have an account yet?"
        '
        'PeacePanel1
        '
        Me.PeacePanel1.Code = ""
        Me.PeacePanel1.Controls.Add(Me.cmb_NATION)
        Me.PeacePanel1.Controls.Add(Me.cmb_FACT)
        Me.PeacePanel1.Data = ""
        Me.PeacePanel1.Location = New System.Drawing.Point(94, 174)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(293, 36)
        Me.PeacePanel1.TabIndex = 23
        Me.PeacePanel1.Tag = ""
        '
        'PeacePanel2
        '
        Me.PeacePanel2.Code = ""
        Me.PeacePanel2.Data = ""
        Me.PeacePanel2.Location = New System.Drawing.Point(94, 241)
        Me.PeacePanel2.Name = "PeacePanel2"
        Me.PeacePanel2.Size = New System.Drawing.Size(293, 36)
        Me.PeacePanel2.TabIndex = 24
        Me.PeacePanel2.Tag = ""
        '
        'PeacePanel3
        '
        Me.PeacePanel3.Code = ""
        Me.PeacePanel3.Controls.Add(Me.txt_PASS)
        Me.PeacePanel3.Data = ""
        Me.PeacePanel3.Location = New System.Drawing.Point(94, 313)
        Me.PeacePanel3.Name = "PeacePanel3"
        Me.PeacePanel3.Size = New System.Drawing.Size(293, 36)
        Me.PeacePanel3.TabIndex = 25
        Me.PeacePanel3.Tag = ""
        '
        'txt_PASS
        '
        Me.txt_PASS.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.txt_PASS.Location = New System.Drawing.Point(5, 6)
        Me.txt_PASS.Name = "txt_PASS"
        Me.txt_PASS.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_PASS.Size = New System.Drawing.Size(179, 26)
        Me.txt_PASS.TabIndex = 26
        Me.txt_PASS.UseSystemPasswordChar = True
        '
        'Etc_login
        '
        Me.AcceptButton = Me.cmd_Login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImage = Global.PSMGlobal.My.Resources.Resources.BackgroundImage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.cmd_Close
        Me.ClientSize = New System.Drawing.Size(1067, 600)
        Me.Controls.Add(Me.lbl_DoHaveAcount)
        Me.Controls.Add(Me.lbl_Username)
        Me.Controls.Add(Me.lbl_Password)
        Me.Controls.Add(Me.lbl_ChangePassword)
        Me.Controls.Add(Me.chk_ShowPassword)
        Me.Controls.Add(Me.lbl_NameProject)
        Me.Controls.Add(Me.lbl_ContactERPTeam)
        Me.Controls.Add(Me.lbl_Login)
        Me.Controls.Add(Me.txt_Infor)
        Me.Controls.Add(Me.chk_PW)
        Me.Controls.Add(Me.cmd_Close)
        Me.Controls.Add(Me.cmd_Login)
        Me.Controls.Add(Me.cmb_SET)
        Me.Controls.Add(Me.cmb_POS)
        Me.Controls.Add(Me.cmb_ID)
        Me.Controls.Add(Me.PeacePanel1)
        Me.Controls.Add(Me.PeacePanel2)
        Me.Controls.Add(Me.PeacePanel3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1067, 600)
        Me.MinimumSize = New System.Drawing.Size(1067, 600)
        Me.Name = "Etc_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng nhập"
        CType(Me.PeacePanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel1.ResumeLayout(False)
        CType(Me.PeacePanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PeacePanel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PeacePanel3.ResumeLayout(False)
        Me.PeacePanel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_FACT As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ID As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_NATION As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_POS As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_SET As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_Login As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Close As PSMGlobal.PeaceButton
    Friend WithEvents chk_PW As System.Windows.Forms.CheckBox
    Friend WithEvents txt_Infor As System.Windows.Forms.TextBox
    Friend WithEvents lbl_NameProject As System.Windows.Forms.Label
    Friend WithEvents lbl_ContactERPTeam As System.Windows.Forms.Label
    Friend WithEvents lbl_Login As System.Windows.Forms.Label
    Friend WithEvents chk_ShowPassword As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_ChangePassword As System.Windows.Forms.Label
    Friend WithEvents lbl_Password As System.Windows.Forms.Label
    Friend WithEvents lbl_Username As System.Windows.Forms.Label
    Friend WithEvents lbl_DoHaveAcount As System.Windows.Forms.Label
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents PeacePanel2 As PSMGlobal.PeacePanel
    Friend WithEvents PeacePanel3 As PSMGlobal.PeacePanel
    Friend WithEvents txt_PASS As System.Windows.Forms.TextBox
End Class
