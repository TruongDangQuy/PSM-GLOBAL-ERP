<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceHLPButton
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
        Me.PeaceButton1 = New PSMGlobal.PeaceButton(Me.components)
        Me.PeaceTextbox1 = New PSMGlobal.PeaceTextbox(Me.components)
        Me.ttpMain = New PSMGlobal.PeaceTooltip(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PeaceTextbox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceTextbox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PeaceButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Appearance.Options.UseBackColor = True
        Me.PeaceButton1.Appearance.Options.UseFont = True
        Me.PeaceButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PeaceButton1.ButtonTitle = Nothing
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.ImageAlign = 0
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(137, 30)
        Me.PeaceButton1.TabIndex = 2
        Me.PeaceButton1.TabStop = False
        Me.PeaceButton1.Text = "PeaceButton"
        Me.PeaceButton1.UseVisualStyleBackColor = False
        '
        'PeaceTextbox1
        '
        Me.PeaceTextbox1.Code = Nothing
        Me.PeaceTextbox1.Data = Nothing
        Me.PeaceTextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceTextbox1.DTDec = 0
        Me.PeaceTextbox1.DTLen = 0
        Me.PeaceTextbox1.DTValue = 0
        Me.PeaceTextbox1.Location = New System.Drawing.Point(138, 0)
        Me.PeaceTextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceTextbox1.MaxLength = 22
        Me.PeaceTextbox1.MultiLine = True
        Me.PeaceTextbox1.Name = "PeaceTextbox1"
        Me.PeaceTextbox1.NoClear = False
        Me.PeaceTextbox1.Properties.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.PeaceTextbox1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceTextbox1.Properties.Appearance.Options.UseBackColor = True
        Me.PeaceTextbox1.Properties.Appearance.Options.UseFont = True
        Me.PeaceTextbox1.Properties.AutoHeight = False
        Me.PeaceTextbox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceTextbox1.ScrollBars = False
        Me.PeaceTextbox1.Size = New System.Drawing.Size(272, 30)
        Me.PeaceTextbox1.TabIndex = 3
        Me.PeaceTextbox1.TextAlign = 0
        '
        'ttpMain
        '
        Me.ttpMain.AutoPopDelay = 5000
        Me.ttpMain.InitialDelay = 250
        Me.ttpMain.IsBalloon = True
        Me.ttpMain.ReshowDelay = 100
        Me.ttpMain.ShowAlways = True
        Me.ttpMain.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttpMain.ToolTipTitle = "Information"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'SelectPeaceHLPButton
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectPeaceHLPButton"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PeaceTextbox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceTextbox1 As PSMGlobal.PeaceTextbox
    Friend WithEvents ttpMain As PSMGlobal.PeaceTooltip
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

End Class
