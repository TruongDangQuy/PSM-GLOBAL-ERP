<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackUpDB
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
        Me.cmd_Path = New PSMGlobal.PeaceButton()
        Me.lbl_Path = New PSMGlobal.PeaceLabel(Me.components)
        Me.Button2 = New PSMGlobal.PeaceButton()
        Me.cmd_OK = New PSMGlobal.PeaceButton()
        Me.txt_FileName = New PSMGlobal.PeaceTextbox(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PeacePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BackColor = System.Drawing.SystemColors.Control
        Me.PeacePanel1.Controls.Add(Me.cmd_Path)
        Me.PeacePanel1.Controls.Add(Me.lbl_Path)
        Me.PeacePanel1.Controls.Add(Me.Button2)
        Me.PeacePanel1.Controls.Add(Me.cmd_OK)
        Me.PeacePanel1.Controls.Add(Me.txt_FileName)
        Me.PeacePanel1.Location = New System.Drawing.Point(12, 12)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(418, 108)
        Me.PeacePanel1.TabIndex = 1
        '
        'cmd_Path
        '
        Me.cmd_Path.BackColor = System.Drawing.Color.Gray
        Me.cmd_Path.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Path.ForeColor = System.Drawing.Color.White
        Me.cmd_Path.Location = New System.Drawing.Point(368, 14)
        Me.cmd_Path.Name = "cmd_Path"
        Me.cmd_Path.Size = New System.Drawing.Size(45, 33)
        Me.cmd_Path.TabIndex = 13
        Me.cmd_Path.TabStop = False
        Me.cmd_Path.Text = "..."
        Me.cmd_Path.UseVisualStyleBackColor = False
        '
        'lbl_Path
        '
        Me.lbl_Path.AutoSize = True
        Me.lbl_Path.Code = Nothing
        Me.lbl_Path.Data = Nothing
        Me.lbl_Path.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Path.Location = New System.Drawing.Point(3, 24)
        Me.lbl_Path.Name = "lbl_Path"
        Me.lbl_Path.Size = New System.Drawing.Size(31, 15)
        Me.lbl_Path.TabIndex = 12
        Me.lbl_Path.Text = "Path"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(207, 51)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 49)
        Me.Button2.TabIndex = 11
        Me.Button2.TabStop = False
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmd_OK
        '
        Me.cmd_OK.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmd_OK.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_OK.ForeColor = System.Drawing.Color.White
        Me.cmd_OK.Location = New System.Drawing.Point(67, 51)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(113, 49)
        Me.cmd_OK.TabIndex = 10
        Me.cmd_OK.Text = "SAVE"
        Me.cmd_OK.UseVisualStyleBackColor = False
        '
        'txt_FileName
        '
        Me.txt_FileName.Code = Nothing
        Me.txt_FileName.Data = ""
        Me.txt_FileName.DTDec = 0
        Me.txt_FileName.DTLen = 0
        Me.txt_FileName.DTValue = 0
        Me.txt_FileName.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_FileName.Location = New System.Drawing.Point(39, 20)
        Me.txt_FileName.Name = "txt_FileName"
        Me.txt_FileName.NoClear = False
        Me.txt_FileName.Size = New System.Drawing.Size(326, 23)
        Me.txt_FileName.TabIndex = 1
        '
        'BackUpDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(442, 132)
        Me.Controls.Add(Me.PeacePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "BackUpDB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdate"
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents txt_FileName As PSMGlobal.PeaceTextbox
    Friend WithEvents lbl_Path As PSMGlobal.PeaceLabel
    Friend WithEvents Button2 As PSMGlobal.PeaceButton
    Friend WithEvents cmd_OK As PSMGlobal.PeaceButton
    Friend WithEvents cmd_Path As PSMGlobal.PeaceButton
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
