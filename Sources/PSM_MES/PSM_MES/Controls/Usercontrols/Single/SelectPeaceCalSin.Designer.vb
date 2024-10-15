<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class SelectPeaceCalSin
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
        Me.PeaceMaskedtextbox1 = New PSMGlobal.PeaceTextbox(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PeaceMaskedtextbox1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PeaceMaskedtextbox1, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(478, 28)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'PeaceButton1
        '
        Me.PeaceButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PeaceButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.PeaceButton1.Appearance.Options.UseBackColor = True
        Me.PeaceButton1.Appearance.Options.UseFont = True
        Me.PeaceButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.PeaceButton1.Code = Nothing
        Me.PeaceButton1.Data = Nothing
        Me.PeaceButton1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceButton1.ImageAlign = 0
        Me.PeaceButton1.Location = New System.Drawing.Point(0, 0)
        Me.PeaceButton1.Margin = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.PeaceButton1.Name = "PeaceButton1"
        Me.PeaceButton1.Size = New System.Drawing.Size(159, 28)
        Me.PeaceButton1.TabIndex = 0
        Me.PeaceButton1.TabStop = False
        Me.PeaceButton1.Text = "DATE"
        Me.PeaceButton1.UseVisualStyleBackColor = False
        '
        'PeaceMaskedtextbox1
        '
        Me.PeaceMaskedtextbox1.Code = Nothing
        Me.PeaceMaskedtextbox1.Data = "____/__/__"
        Me.PeaceMaskedtextbox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PeaceMaskedtextbox1.DTDec = 0
        Me.PeaceMaskedtextbox1.DTLen = 0
        Me.PeaceMaskedtextbox1.DTValue = 0
        Me.PeaceMaskedtextbox1.EditValue = "____/__/__"
        Me.PeaceMaskedtextbox1.Location = New System.Drawing.Point(160, 0)
        Me.PeaceMaskedtextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PeaceMaskedtextbox1.MaxLength = 0
        Me.PeaceMaskedtextbox1.MultiLine = False
        Me.PeaceMaskedtextbox1.Name = "PeaceMaskedtextbox1"
        Me.PeaceMaskedtextbox1.NoClear = False
        Me.PeaceMaskedtextbox1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PeaceMaskedtextbox1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.PeaceMaskedtextbox1.Properties.Appearance.Options.UseBackColor = True
        Me.PeaceMaskedtextbox1.Properties.Appearance.Options.UseFont = True
        Me.PeaceMaskedtextbox1.Properties.AutoHeight = False
        Me.PeaceMaskedtextbox1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PeaceMaskedtextbox1.Properties.Mask.AutoComplete = DevExpress.XtraEditors.Mask.AutoCompleteType.Optimistic
        Me.PeaceMaskedtextbox1.Properties.Mask.BeepOnError = True
        Me.PeaceMaskedtextbox1.Properties.Mask.EditMask = "\d?\d\d?\d?/\d?\d?/\d\d"
        Me.PeaceMaskedtextbox1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular
        Me.PeaceMaskedtextbox1.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.PeaceMaskedtextbox1.ScrollBars = False
        Me.PeaceMaskedtextbox1.Size = New System.Drawing.Size(318, 28)
        Me.PeaceMaskedtextbox1.TabIndex = 3
        Me.PeaceMaskedtextbox1.TextAlign = 0
        '
        'SelectPeaceCalSin
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectPeaceCalSin"
        Me.Size = New System.Drawing.Size(478, 28)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PeaceMaskedtextbox1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents PeaceMaskedtextbox1 As PSMGlobal.PeaceTextbox
    Friend WithEvents PeaceButton1 As PSMGlobal.PeaceButton

End Class
