<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectPeaceLaTe
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
        Me.ptb = New PSMGlobal.PeaceTextbox(Me.components)
        Me.pbt = New PSMGlobal.PeaceButton(Me.components)
        Me.pl2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.ptb.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.65993!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.69989!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.64018!))
        Me.TableLayoutPanel1.Controls.Add(Me.ptb, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pbt, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.pl2, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'ptb
        '
        Me.ptb.Code = Nothing
        Me.ptb.Data = Nothing
        Me.ptb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ptb.DTDec = 0
        Me.ptb.DTLen = 0
        Me.ptb.DTValue = 0
        Me.ptb.Location = New System.Drawing.Point(139, 1)
        Me.ptb.Margin = New System.Windows.Forms.Padding(1)
        Me.ptb.MaxLength = 22
        Me.ptb.MultiLine = True
        Me.ptb.Name = "ptb"
        Me.ptb.NoClear = False
        Me.ptb.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.ptb.Properties.Appearance.Options.UseFont = True
        Me.ptb.Properties.AutoHeight = False
        Me.ptb.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.ptb.Properties.ValidateOnEnterKey = True
        Me.ptb.ScrollBars = False
        Me.ptb.Size = New System.Drawing.Size(214, 28)
        Me.ptb.TabIndex = 3
        Me.ptb.TextAlign = 0
        '
        'pbt
        '
        Me.pbt.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pbt.Appearance.Options.UseFont = True
        Me.pbt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.pbt.Code = Nothing
        Me.pbt.Data = Nothing
        Me.pbt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbt.ImageAlign = 0
        Me.pbt.Location = New System.Drawing.Point(0, 0)
        Me.pbt.Margin = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.pbt.Name = "pbt"
        Me.pbt.Size = New System.Drawing.Size(136, 30)
        Me.pbt.TabIndex = 0
        Me.pbt.Text = "PeaceButton"
        Me.pbt.UseVisualStyleBackColor = False
        '
        'pl2
        '
        Me.pl2.AutoSize = True
        Me.pl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pl2.Code = ""
        Me.pl2.Data = ""
        Me.pl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pl2.DTDec = 0
        Me.pl2.DTLen = 0
        Me.pl2.DTValue = 0
        Me.pl2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.pl2.Location = New System.Drawing.Point(355, 1)
        Me.pl2.Margin = New System.Windows.Forms.Padding(1)
        Me.pl2.Name = "pl2"
        Me.pl2.NoClear = False
        Me.pl2.Size = New System.Drawing.Size(54, 28)
        Me.pl2.TabIndex = 2
        Me.pl2.Text = "PeaceLabel2"
        Me.pl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectPeaceLaTe
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectPeaceLaTe"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.ptb.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents pbt As PSMGlobal.PeaceButton
    Friend WithEvents pl2 As PSMGlobal.PeaceLabel
    Friend WithEvents ptb As PSMGlobal.PeaceTextbox

End Class
