<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AutoUpdate
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
        Me.Button2 = New PSMGlobal.PeaceButton()
        Me.Button1 = New PSMGlobal.PeaceButton()
        Me.Version = New PSMGlobal.PeaceTextbox(Me.components)
        Me.PeacePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PeacePanel1
        '
        Me.PeacePanel1.BackColor = System.Drawing.SystemColors.Control
        Me.PeacePanel1.Controls.Add(Me.PeaceLabel1)
        Me.PeacePanel1.Controls.Add(Me.Button2)
        Me.PeacePanel1.Controls.Add(Me.Button1)
        Me.PeacePanel1.Controls.Add(Me.Version)
        Me.PeacePanel1.Location = New System.Drawing.Point(12, 12)
        Me.PeacePanel1.Name = "PeacePanel1"
        Me.PeacePanel1.Size = New System.Drawing.Size(256, 108)
        Me.PeacePanel1.TabIndex = 1
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.AutoSize = True
        Me.PeaceLabel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PeaceLabel1.Location = New System.Drawing.Point(3, 24)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.Size = New System.Drawing.Size(57, 15)
        Me.PeaceLabel1.TabIndex = 12
        Me.PeaceLabel1.Text = "Password"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(144, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(76, 49)
        Me.Button2.TabIndex = 11
        Me.Button2.TabStop = False
        Me.Button2.Text = "CLOSE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(39, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 49)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "LOGIN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Version
        '
        Me.Version.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(67, 16)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(177, 29)
        Me.Version.TabIndex = 1
        '
        'AutoUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(280, 132)
        Me.Controls.Add(Me.PeacePanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "AutoUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AutoUpdate"
        Me.PeacePanel1.ResumeLayout(False)
        Me.PeacePanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeacePanel1 As PSMGlobal.PeacePanel
    Friend WithEvents Version As PSMGlobal.PeaceTextbox
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel
    Friend WithEvents Button2 As PSMGlobal.PeaceButton
    Friend WithEvents Button1 As PSMGlobal.PeaceButton
End Class
