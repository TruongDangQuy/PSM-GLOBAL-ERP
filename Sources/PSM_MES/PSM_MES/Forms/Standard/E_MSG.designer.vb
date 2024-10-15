<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_MSG
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_MSG))
        Me.tlpMain = New System.Windows.Forms.TableLayoutPanel()
        Me.pnlBottom = New System.Windows.Forms.Panel()
        Me.btnBR1 = New System.Windows.Forms.Button()
        Me.btnBR2 = New System.Windows.Forms.Button()
        Me.btnBR3 = New System.Windows.Forms.Button()
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picTitle = New System.Windows.Forms.PictureBox()
        Me.pnlMiddle = New System.Windows.Forms.Panel()
        Me.lblText = New System.Windows.Forms.Label()
        Me.tlpMain.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlTop.SuspendLayout()
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpMain
        '
        Me.tlpMain.ColumnCount = 1
        Me.tlpMain.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.Controls.Add(Me.pnlBottom, 0, 2)
        Me.tlpMain.Controls.Add(Me.pnlTop, 0, 0)
        Me.tlpMain.Controls.Add(Me.pnlMiddle, 0, 1)
        Me.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMain.Location = New System.Drawing.Point(3, 3)
        Me.tlpMain.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpMain.Name = "tlpMain"
        Me.tlpMain.RowCount = 3
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tlpMain.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.tlpMain.Size = New System.Drawing.Size(246, 185)
        Me.tlpMain.TabIndex = 0
        '
        'pnlBottom
        '
        Me.pnlBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlBottom.Controls.Add(Me.btnBR1)
        Me.pnlBottom.Controls.Add(Me.btnBR2)
        Me.pnlBottom.Controls.Add(Me.btnBR3)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 153)
        Me.pnlBottom.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(246, 32)
        Me.pnlBottom.TabIndex = 3
        '
        'btnBR1
        '
        Me.btnBR1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBR1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnBR1.Location = New System.Drawing.Point(39, 3)
        Me.btnBR1.Name = "btnBR1"
        Me.btnBR1.Size = New System.Drawing.Size(64, 23)
        Me.btnBR1.TabIndex = 0
        Me.btnBR1.Text = "YES"
        Me.btnBR1.UseVisualStyleBackColor = True
        '
        'btnBR2
        '
        Me.btnBR2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBR2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnBR2.Location = New System.Drawing.Point(109, 3)
        Me.btnBR2.Name = "btnBR2"
        Me.btnBR2.Size = New System.Drawing.Size(64, 23)
        Me.btnBR2.TabIndex = 1
        Me.btnBR2.Text = "NO"
        Me.btnBR2.UseVisualStyleBackColor = True
        '
        'btnBR3
        '
        Me.btnBR3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBR3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnBR3.Location = New System.Drawing.Point(178, 3)
        Me.btnBR3.Name = "btnBR3"
        Me.btnBR3.Size = New System.Drawing.Size(64, 23)
        Me.btnBR3.TabIndex = 2
        Me.btnBR3.Text = "CANCEL"
        Me.btnBR3.UseVisualStyleBackColor = True
        '
        'pnlTop
        '
        Me.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Controls.Add(Me.picTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(246, 25)
        Me.pnlTop.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTitle.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblTitle.Location = New System.Drawing.Point(20, 0)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(224, 23)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "PSM"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picTitle
        '
        Me.picTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.picTitle.Location = New System.Drawing.Point(0, 0)
        Me.picTitle.Margin = New System.Windows.Forms.Padding(0)
        Me.picTitle.Name = "picTitle"
        Me.picTitle.Size = New System.Drawing.Size(20, 23)
        Me.picTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picTitle.TabIndex = 3
        Me.picTitle.TabStop = False
        '
        'pnlMiddle
        '
        Me.pnlMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMiddle.Controls.Add(Me.lblText)
        Me.pnlMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlMiddle.Location = New System.Drawing.Point(0, 27)
        Me.pnlMiddle.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlMiddle.Name = "pnlMiddle"
        Me.pnlMiddle.Padding = New System.Windows.Forms.Padding(3)
        Me.pnlMiddle.Size = New System.Drawing.Size(246, 123)
        Me.pnlMiddle.TabIndex = 1
        '
        'lblText
        '
        Me.lblText.BackColor = System.Drawing.Color.White
        Me.lblText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblText.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblText.Location = New System.Drawing.Point(3, 3)
        Me.lblText.Margin = New System.Windows.Forms.Padding(0)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(238, 115)
        Me.lblText.TabIndex = 0
        Me.lblText.Text = "Text"
        Me.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'E_MSG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(252, 191)
        Me.Controls.Add(Me.tlpMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "E_MSG"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        Me.tlpMain.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlTop.ResumeLayout(False)
        CType(Me.picTitle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tlpMain As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pnlTop As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As Label
    Public WithEvents picTitle As PictureBox
    Friend WithEvents pnlMiddle As System.Windows.Forms.Panel
    Friend WithEvents lblText As Label
	Public WithEvents pnlBottom As System.Windows.Forms.Panel
    Friend WithEvents btnBR1 As Button
    Friend WithEvents btnBR2 As Button
    Friend WithEvents btnBR3 As Button
End Class
