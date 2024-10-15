<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class E_PRG
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(E_PRG))
        Me.timMain = New System.Windows.Forms.Timer(Me.components)
        Me.BGW = New System.ComponentModel.BackgroundWorker()
        Me.lbl_5 = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbl_3 = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbl_2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbl_1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbl_Percent = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbl_Max = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbl_Value = New PSMGlobal.PeaceLabel(Me.components)
        Me.lblMsg = New PSMGlobal.PeaceLabel(Me.components)
        Me.prgPRG = New PSMGlobal.PeaceProgressbar(Me.components)
        Me.SuspendLayout()
        '
        'timMain
        '
        Me.timMain.Enabled = True
        Me.timMain.Interval = 10
        '
        'BGW
        '
        Me.BGW.WorkerReportsProgress = True
        Me.BGW.WorkerSupportsCancellation = True
        '
        'lbl_5
        '
        Me.lbl_5.AutoSize = True
        Me.lbl_5.BackColor = System.Drawing.Color.White
        Me.lbl_5.Code = Nothing
        Me.lbl_5.Data = Nothing
        Me.lbl_5.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_5.Location = New System.Drawing.Point(640, 49)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(14, 19)
        Me.lbl_5.TabIndex = 10
        Me.lbl_5.Text = ")"
        '
        'lbl_3
        '
        Me.lbl_3.AutoSize = True
        Me.lbl_3.BackColor = System.Drawing.Color.White
        Me.lbl_3.Code = Nothing
        Me.lbl_3.Data = Nothing
        Me.lbl_3.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_3.Location = New System.Drawing.Point(554, 49)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(14, 19)
        Me.lbl_3.TabIndex = 6
        Me.lbl_3.Text = "("
        '
        'lbl_2
        '
        Me.lbl_2.AutoSize = True
        Me.lbl_2.BackColor = System.Drawing.Color.White
        Me.lbl_2.Code = Nothing
        Me.lbl_2.Data = Nothing
        Me.lbl_2.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_2.Location = New System.Drawing.Point(461, 49)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(23, 19)
        Me.lbl_2.TabIndex = 4
        Me.lbl_2.Text = "of"
        '
        'lbl_1
        '
        Me.lbl_1.AutoSize = True
        Me.lbl_1.BackColor = System.Drawing.Color.White
        Me.lbl_1.Code = Nothing
        Me.lbl_1.Data = Nothing
        Me.lbl_1.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_1.Location = New System.Drawing.Point(284, 49)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(98, 19)
        Me.lbl_1.TabIndex = 0
        Me.lbl_1.Text = "Loading: Unit"
        '
        'lbl_Percent
        '
        Me.lbl_Percent.AutoSize = True
        Me.lbl_Percent.BackColor = System.Drawing.Color.White
        Me.lbl_Percent.Code = Nothing
        Me.lbl_Percent.Data = Nothing
        Me.lbl_Percent.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Percent.Location = New System.Drawing.Point(574, 49)
        Me.lbl_Percent.Name = "lbl_Percent"
        Me.lbl_Percent.Size = New System.Drawing.Size(60, 19)
        Me.lbl_Percent.TabIndex = 7
        Me.lbl_Percent.Text = "Percent"
        '
        'lbl_Max
        '
        Me.lbl_Max.AutoSize = True
        Me.lbl_Max.BackColor = System.Drawing.Color.White
        Me.lbl_Max.Code = Nothing
        Me.lbl_Max.Data = Nothing
        Me.lbl_Max.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Max.Location = New System.Drawing.Point(499, 49)
        Me.lbl_Max.Name = "lbl_Max"
        Me.lbl_Max.Size = New System.Drawing.Size(38, 19)
        Me.lbl_Max.TabIndex = 5
        Me.lbl_Max.Text = "Max"
        '
        'lbl_Value
        '
        Me.lbl_Value.AutoSize = True
        Me.lbl_Value.BackColor = System.Drawing.Color.White
        Me.lbl_Value.Code = Nothing
        Me.lbl_Value.Data = Nothing
        Me.lbl_Value.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_Value.Location = New System.Drawing.Point(397, 49)
        Me.lbl_Value.Name = "lbl_Value"
        Me.lbl_Value.Size = New System.Drawing.Size(45, 19)
        Me.lbl_Value.TabIndex = 3
        Me.lbl_Value.Text = "Value"
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.White
        Me.lblMsg.Code = Nothing
        Me.lblMsg.Data = Nothing
        Me.lblMsg.Font = New System.Drawing.Font("Tahoma", 20.0!, System.Drawing.FontStyle.Bold)
        Me.lblMsg.ForeColor = System.Drawing.Color.Red
        Me.lblMsg.Location = New System.Drawing.Point(11, 10)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(942, 61)
        Me.lblMsg.TabIndex = 12
        Me.lblMsg.Text = "DATA LOADING..."
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'prgPRG
        '
        Me.prgPRG.BackColor = System.Drawing.Color.White
        Me.prgPRG.ForeColor = System.Drawing.Color.Black
        Me.prgPRG.Location = New System.Drawing.Point(6, 6)
        Me.prgPRG.Name = "prgPRG"
        Me.prgPRG.Size = New System.Drawing.Size(963, 81)
        Me.prgPRG.TabIndex = 1
        Me.prgPRG.Value = 50
        '
        'E_PRG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 93)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_5)
        Me.Controls.Add(Me.lbl_3)
        Me.Controls.Add(Me.lbl_2)
        Me.Controls.Add(Me.lbl_1)
        Me.Controls.Add(Me.lbl_Percent)
        Me.Controls.Add(Me.lbl_Max)
        Me.Controls.Add(Me.lbl_Value)
        Me.Controls.Add(Me.lblMsg)
        Me.Controls.Add(Me.prgPRG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = True
        Me.MinimizeBox = True
        Me.Name = "E_PRG"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E_PRG"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lblMsg As PSMGlobal.PeaceLabel
    Friend WithEvents prgPRG As PSMGlobal.PeaceProgressbar
    Friend WithEvents timMain As System.Windows.Forms.Timer
    Friend WithEvents lbl_1 As PSMGlobal.PeaceLabel
    Friend WithEvents lbl_Value As PSMGlobal.PeaceLabel
    Friend WithEvents lbl_2 As PSMGlobal.PeaceLabel
    Friend WithEvents lbl_Max As PSMGlobal.PeaceLabel
    Friend WithEvents lbl_3 As PSMGlobal.PeaceLabel
    Friend WithEvents lbl_Percent As PSMGlobal.PeaceLabel
    Friend WithEvents BGW As System.ComponentModel.BackgroundWorker
    Friend WithEvents lbl_5 As PSMGlobal.PeaceLabel
End Class
