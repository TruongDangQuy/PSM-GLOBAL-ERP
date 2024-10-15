<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLabelLable
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
        Me.lbl_name1 = New PSMGlobal.PeaceLabel(Me.components)
        Me.lbl_name2 = New PSMGlobal.PeaceLabel(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.34!))
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name2, 1, 0)
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
        'lbl_name1
        '
        Me.lbl_name1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lbl_name1.Code = Nothing
        Me.lbl_name1.Data = Nothing
        Me.lbl_name1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_name1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name1.Location = New System.Drawing.Point(3, 0)
        Me.lbl_name1.Name = "lbl_name1"
        Me.lbl_name1.Size = New System.Drawing.Size(132, 30)
        Me.lbl_name1.TabIndex = 4
        Me.lbl_name1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_name2
        '
        Me.lbl_name2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_name2.Code = Nothing
        Me.lbl_name2.Data = Nothing
        Me.lbl_name2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_name2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name2.Location = New System.Drawing.Point(141, 0)
        Me.lbl_name2.Name = "lbl_name2"
        Me.lbl_name2.Size = New System.Drawing.Size(266, 30)
        Me.lbl_name2.TabIndex = 3
        Me.lbl_name2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SelectLabelLable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectLabelLable"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_name1 As PSMGlobal.PeaceLabel
    Friend WithEvents lbl_name2 As PSMGlobal.PeaceLabel

End Class
