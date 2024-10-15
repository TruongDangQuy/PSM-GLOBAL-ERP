<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectLabel2Text
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
        Me.text2 = New PSMGlobal.PeaceTextbox(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.text1 = New PSMGlobal.PeaceTextbox(Me.components)
        Me.lbl_name = New PSMGlobal.PeaceLabel(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'text2
        '
        Me.text2.Code = Nothing
        Me.text2.Data = Nothing
        Me.text2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.text2.Location = New System.Drawing.Point(205, 0)
        Me.text2.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.text2.MaxLength = 22
        Me.text2.Multiline = True
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(205, 30)
        Me.text2.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.66!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.34!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.text1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.text2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lbl_name, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'text1
        '
        Me.text1.Code = Nothing
        Me.text1.Data = Nothing
        Me.text1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.text1.Location = New System.Drawing.Point(139, 0)
        Me.text1.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
        Me.text1.MaxLength = 22
        Me.text1.Multiline = True
        Me.text1.Name = "text1"
        Me.text1.Size = New System.Drawing.Size(65, 30)
        Me.text1.TabIndex = 1
        '
        'lbl_name
        '
        Me.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_name.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(0, 0)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(138, 30)
        Me.lbl_name.TabIndex = 0
        Me.lbl_name.Text = "LABLE NAME"
        Me.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'SelectLabel2Text
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = Windows.Forms.AutoScaleMode.None
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "SelectLabel2Text"
        Me.Size = New System.Drawing.Size(410, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents text2 As PSMGlobal.PeaceTextbox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbl_name As PSMGlobal.PeaceLabel
    Friend WithEvents text1 As PSMGlobal.PeaceTextbox

End Class
