<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceSelect
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnTitle = New PSMGlobal.PeaceLabel(Me.components)
        Me.clbText = New PSMGlobal.PeaceChecklistbox(Me.components)
        Me.ttpMain = New PSMGlobal.PeaceTooltip(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnTitle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.clbText, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'btnTitle
        '
        Me.btnTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnTitle.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.btnTitle.Code = Nothing
        Me.btnTitle.Data = Nothing
        Me.btnTitle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnTitle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTitle.Location = New System.Drawing.Point(0, 0)
        Me.btnTitle.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.btnTitle.Name = "btnTitle"
        Me.btnTitle.Size = New System.Drawing.Size(137, 30)
        Me.btnTitle.TabIndex = 2
        Me.btnTitle.Text = "LABLE NAME"
        Me.btnTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'clbText
        '
        Me.clbText.BackColor = System.Drawing.SystemColors.Control
        Me.clbText.CheckOnClick = True
        Me.clbText.ColumnWidth = 60
        Me.clbText.Dock = System.Windows.Forms.DockStyle.Fill
        Me.clbText.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clbText.FormattingEnabled = True
        Me.clbText.Location = New System.Drawing.Point(138, 0)
        Me.clbText.Margin = New System.Windows.Forms.Padding(0)
        Me.clbText.MultiColumn = True
        Me.clbText.Name = "clbText"
        Me.clbText.Size = New System.Drawing.Size(272, 30)
        Me.clbText.TabIndex = 3
        '
        'ttpMain
        '
        Me.ttpMain.AutoPopDelay = 5000
        Me.ttpMain.InitialDelay = 500
        Me.ttpMain.IsBalloon = True
        Me.ttpMain.ReshowDelay = 100
        Me.ttpMain.ShowAlways = True
        Me.ttpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpMain.ToolTipTitle = "Information"
        '
        'SelectPeaceSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectPeaceSelect"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnTitle As PSMGlobal.PeaceLabel
    Friend WithEvents ttpMain As PSMGlobal.PeaceTooltip
    Public WithEvents clbText As PSMGlobal.PeaceChecklistbox

End Class
