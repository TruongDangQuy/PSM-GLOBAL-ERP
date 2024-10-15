<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectISUDcheck
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
        Me.PeaceLabel1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PeaceTextbox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.65981!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.00003!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.34016!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceTextbox1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceLabel1, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 40)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceButton1.Appearance.Options.UseFont = True
        Me.PeaceButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.PeaceButton1.ButtonTitle = Nothing
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.ImageAlign = 0
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(138, 40)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.Text = "PeaceButton"
        Me.PeaceButton1.UseVisualStyleBackColor = True
        '
        'PeaceTextbox1
        '
        Me.PeaceTextbox1.Code = Nothing
        Me.PeaceTextbox1.Data = "1"
        Me.PeaceTextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceTextbox1.DTDec = 0
        Me.PeaceTextbox1.DTLen = 0
        Me.PeaceTextbox1.DTValue = 0
        Me.PeaceTextbox1.EditValue = "1"
        Me.PeaceTextbox1.Location = New System.Drawing.Point(138, 0)
        Me.PeaceTextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceTextbox1.MaxLength = 10
        Me.PeaceTextbox1.MultiLine = True
        Me.PeaceTextbox1.Name = "PeaceTextbox1"
        Me.PeaceTextbox1.NoClear = False
        Me.PeaceTextbox1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 18.0!)
        Me.PeaceTextbox1.Properties.Appearance.Options.UseFont = True
        Me.PeaceTextbox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceTextbox1.ScrollBars = False
        Me.PeaceTextbox1.Size = New System.Drawing.Size(41, 36)
        Me.PeaceTextbox1.TabIndex = 1
        Me.PeaceTextbox1.TextAlign = 2
        '
        'PeaceLabel1
        '
        Me.PeaceLabel1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.PeaceLabel1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.PeaceLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.PeaceLabel1.ButtonTitle = Nothing
        Me.PeaceLabel1.Code = ""
        Me.PeaceLabel1.Data = ""
        Me.PeaceLabel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceLabel1.DTDec = 0
        Me.PeaceLabel1.DTLen = 0
        Me.PeaceLabel1.DTValue = 0
        Me.PeaceLabel1.Location = New System.Drawing.Point(179, 0)
        Me.PeaceLabel1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceLabel1.Name = "PeaceLabel1"
        Me.PeaceLabel1.NoClear = False
        Me.PeaceLabel1.Size = New System.Drawing.Size(231, 40)
        Me.PeaceLabel1.TabIndex = 2
        Me.PeaceLabel1.Text = "( Check value 1)"
        Me.PeaceLabel1.TextAlign = DevExpress.Utils.HorzAlignment.Center
        '
        'SelectISUDcheck
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectISUDcheck"
        Me.Size = New System.Drawing.Size(410, 40)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.PeaceTextbox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton
    Friend WithEvents PeaceTextbox1 As PSMGlobal.PeaceTextbox
    Friend WithEvents PeaceLabel1 As PSMGlobal.PeaceLabel

End Class
