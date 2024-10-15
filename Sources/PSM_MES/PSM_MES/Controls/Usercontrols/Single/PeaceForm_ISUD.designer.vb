<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeaceForm_ISUD
    Inherits PeaceForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeaceForm_ISUD))
        Me.Tst_Main = New System.Windows.Forms.ToolStrip()
        Me.Tst_iBack = New System.Windows.Forms.ToolStripButton()
        Me.Tst_iNext = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_iNew = New System.Windows.Forms.ToolStripButton()
        Me.tst_iEdit = New System.Windows.Forms.ToolStripButton()
        Me.tst_iSave = New System.Windows.Forms.ToolStripButton()
        Me.tst_iDelete = New System.Windows.Forms.ToolStripButton()
        Me.tst_iPrint = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tst_iPrint_Print = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_iUtilities = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tst_iAttach = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_iHistory = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_iStatus = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_iRefresh = New System.Windows.Forms.ToolStripButton()
        Me.tst_iSample = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tst_iStandard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_iCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_iExport = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tst_iExport_Excel = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_iExport_Pdf = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tst_iFeedback = New System.Windows.Forms.ToolStripButton()
        Me.tst_iSupport = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tst_iSupport_Instruction = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_iSupport_OnlineSupport = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_iSupport_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.tst_iClose = New System.Windows.Forms.ToolStripButton()
        Me.Tst_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tst_Main
        '
        Me.Tst_Main.BackColor = System.Drawing.Color.Transparent
        Me.Tst_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Tst_iBack, Me.Tst_iNext, Me.ToolStripSeparator1, Me.tst_iNew, Me.tst_iEdit, Me.tst_iSave, Me.tst_iDelete, Me.tst_iPrint, Me.tst_iUtilities, Me.ToolStripSeparator5, Me.tst_iStatus, Me.ToolStripSeparator2, Me.tst_iRefresh, Me.tst_iSample, Me.ToolStripSeparator3, Me.tst_iExport, Me.ToolStripSeparator4, Me.tst_iFeedback, Me.tst_iSupport, Me.tst_iClose})
        Me.Tst_Main.Location = New System.Drawing.Point(0, 0)
        Me.Tst_Main.Name = "Tst_Main"
        Me.Tst_Main.Size = New System.Drawing.Size(999, 38)
        Me.Tst_Main.TabIndex = 0
        Me.Tst_Main.Text = "ToolStrip1"
        '
        'Tst_iBack
        '
        Me.Tst_iBack.Image = Global.PSMGlobal.My.Resources.Resources.Backward_16x16
        Me.Tst_iBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tst_iBack.Name = "Tst_iBack"
        Me.Tst_iBack.Size = New System.Drawing.Size(36, 35)
        Me.Tst_iBack.Text = "Back"
        Me.Tst_iBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Tst_iBack.Visible = False
        '
        'Tst_iNext
        '
        Me.Tst_iNext.Image = Global.PSMGlobal.My.Resources.Resources.Forward_16x16
        Me.Tst_iNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Tst_iNext.Name = "Tst_iNext"
        Me.Tst_iNext.Size = New System.Drawing.Size(36, 35)
        Me.Tst_iNext.Text = "Next"
        Me.Tst_iNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Tst_iNext.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tst_iNew
        '
        Me.tst_iNew.Image = Global.PSMGlobal.My.Resources.Resources.Insert_16x16
        Me.tst_iNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iNew.Name = "tst_iNew"
        Me.tst_iNew.Size = New System.Drawing.Size(58, 35)
        Me.tst_iNew.Text = "New (&F1)"
        Me.tst_iNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iNew.Visible = False
        '
        'tst_iEdit
        '
        Me.tst_iEdit.Image = Global.PSMGlobal.My.Resources.Resources.Edit_16x16
        Me.tst_iEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iEdit.Name = "tst_iEdit"
        Me.tst_iEdit.Size = New System.Drawing.Size(31, 35)
        Me.tst_iEdit.Text = "Edit"
        Me.tst_iEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iEdit.Visible = False
        '
        'tst_iSave
        '
        Me.tst_iSave.Image = Global.PSMGlobal.My.Resources.Resources.Save_16x16
        Me.tst_iSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iSave.Name = "tst_iSave"
        Me.tst_iSave.Size = New System.Drawing.Size(58, 35)
        Me.tst_iSave.Text = "Save (&F2)"
        Me.tst_iSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_iDelete
        '
        Me.tst_iDelete.Image = Global.PSMGlobal.My.Resources.Resources.Delete_16x16
        Me.tst_iDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iDelete.Name = "tst_iDelete"
        Me.tst_iDelete.Size = New System.Drawing.Size(67, 35)
        Me.tst_iDelete.Text = "Delete (&F3)"
        Me.tst_iDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_iPrint
        '
        Me.tst_iPrint.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_iPrint_Print, Me.ToolStripMenuItem1, Me.PrintSettingsToolStripMenuItem})
        Me.tst_iPrint.Image = Global.PSMGlobal.My.Resources.Resources.Print_16x16
        Me.tst_iPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iPrint.Name = "tst_iPrint"
        Me.tst_iPrint.Size = New System.Drawing.Size(68, 35)
        Me.tst_iPrint.Text = "Print (&F5)"
        Me.tst_iPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_iPrint_Print
        '
        Me.tst_iPrint_Print.Image = Global.PSMGlobal.My.Resources.Resources.Print_16x16
        Me.tst_iPrint_Print.Name = "tst_iPrint_Print"
        Me.tst_iPrint_Print.Size = New System.Drawing.Size(144, 22)
        Me.tst_iPrint_Print.Text = "Print"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Image = Global.PSMGlobal.My.Resources.Resources.PrintDialog_16x16
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.ToolStripMenuItem1.Text = "Print Layout"
        '
        'PrintSettingsToolStripMenuItem
        '
        Me.PrintSettingsToolStripMenuItem.Image = Global.PSMGlobal.My.Resources.Resources.PageSetup_16x16
        Me.PrintSettingsToolStripMenuItem.Name = "PrintSettingsToolStripMenuItem"
        Me.PrintSettingsToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.PrintSettingsToolStripMenuItem.Text = "Print Settings"
        '
        'tst_iUtilities
        '
        Me.tst_iUtilities.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_iAttach, Me.tst_iHistory})
        Me.tst_iUtilities.Image = Global.PSMGlobal.My.Resources.Resources.UserGroup_16x16
        Me.tst_iUtilities.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iUtilities.Name = "tst_iUtilities"
        Me.tst_iUtilities.Size = New System.Drawing.Size(82, 35)
        Me.tst_iUtilities.Text = "Utilities (&F6)"
        Me.tst_iUtilities.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tst_iAttach
        '
        Me.tst_iAttach.Image = Global.PSMGlobal.My.Resources.Resources.AddFile_16x16
        Me.tst_iAttach.Name = "tst_iAttach"
        Me.tst_iAttach.Size = New System.Drawing.Size(143, 22)
        Me.tst_iAttach.Text = "Attach Files"
        '
        'tst_iHistory
        '
        Me.tst_iHistory.Image = Global.PSMGlobal.My.Resources.Resources.HistoryItem_16x16
        Me.tst_iHistory.Name = "tst_iHistory"
        Me.tst_iHistory.Size = New System.Drawing.Size(143, 22)
        Me.tst_iHistory.Text = "History Form"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'tst_iStatus
        '
        Me.tst_iStatus.Image = Global.PSMGlobal.My.Resources.Resources.EditTask_16x16
        Me.tst_iStatus.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iStatus.Name = "tst_iStatus"
        Me.tst_iStatus.Size = New System.Drawing.Size(43, 35)
        Me.tst_iStatus.Text = "Status"
        Me.tst_iStatus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iStatus.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        Me.ToolStripSeparator2.Visible = False
        '
        'tst_iRefresh
        '
        Me.tst_iRefresh.Image = Global.PSMGlobal.My.Resources.Resources.Refresh_16x16
        Me.tst_iRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iRefresh.Name = "tst_iRefresh"
        Me.tst_iRefresh.Size = New System.Drawing.Size(50, 35)
        Me.tst_iRefresh.Text = "Refresh"
        Me.tst_iRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iRefresh.Visible = False
        '
        'tst_iSample
        '
        Me.tst_iSample.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_iStandard, Me.tst_iCustomize})
        Me.tst_iSample.Image = Global.PSMGlobal.My.Resources.Resources.SendCSV_16x16
        Me.tst_iSample.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iSample.Name = "tst_iSample"
        Me.tst_iSample.Size = New System.Drawing.Size(59, 35)
        Me.tst_iSample.Text = "Sample"
        Me.tst_iSample.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iSample.Visible = False
        '
        'tst_iStandard
        '
        Me.tst_iStandard.Image = Global.PSMGlobal.My.Resources.Resources.Version_16x16
        Me.tst_iStandard.Name = "tst_iStandard"
        Me.tst_iStandard.Size = New System.Drawing.Size(172, 22)
        Me.tst_iStandard.Text = "Stardard Sample "
        '
        'tst_iCustomize
        '
        Me.tst_iCustomize.Image = Global.PSMGlobal.My.Resources.Resources.Scripts_16x16
        Me.tst_iCustomize.Name = "tst_iCustomize"
        Me.tst_iCustomize.Size = New System.Drawing.Size(172, 22)
        Me.tst_iCustomize.Text = "Customize Sample"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        Me.ToolStripSeparator3.Visible = False
        '
        'tst_iExport
        '
        Me.tst_iExport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_iExport_Excel, Me.tst_iExport_Pdf})
        Me.tst_iExport.Image = Global.PSMGlobal.My.Resources.Resources.Export_16x16
        Me.tst_iExport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iExport.Name = "tst_iExport"
        Me.tst_iExport.Size = New System.Drawing.Size(54, 35)
        Me.tst_iExport.Text = "Export"
        Me.tst_iExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iExport.Visible = False
        '
        'tst_iExport_Excel
        '
        Me.tst_iExport_Excel.Image = Global.PSMGlobal.My.Resources.Resources.ExportToXLSX_16x16
        Me.tst_iExport_Excel.Name = "tst_iExport_Excel"
        Me.tst_iExport_Excel.Size = New System.Drawing.Size(165, 22)
        Me.tst_iExport_Excel.Text = "Excel (*.xls,*,xlsx)"
        '
        'tst_iExport_Pdf
        '
        Me.tst_iExport_Pdf.Image = Global.PSMGlobal.My.Resources.Resources.ExportToPDF_16x16
        Me.tst_iExport_Pdf.Name = "tst_iExport_Pdf"
        Me.tst_iExport_Pdf.Size = New System.Drawing.Size(165, 22)
        Me.tst_iExport_Pdf.Text = "Pdf (*.pdf)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        Me.ToolStripSeparator4.Visible = False
        '
        'tst_iFeedback
        '
        Me.tst_iFeedback.Image = Global.PSMGlobal.My.Resources.Resources.Mail_16x16
        Me.tst_iFeedback.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iFeedback.Name = "tst_iFeedback"
        Me.tst_iFeedback.Size = New System.Drawing.Size(61, 35)
        Me.tst_iFeedback.Text = "Feedback"
        Me.tst_iFeedback.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iFeedback.Visible = False
        '
        'tst_iSupport
        '
        Me.tst_iSupport.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tst_iSupport_Instruction, Me.tst_iSupport_OnlineSupport, Me.tst_iSupport_About})
        Me.tst_iSupport.Image = Global.PSMGlobal.My.Resources.Resources.Home_16x16
        Me.tst_iSupport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iSupport.Name = "tst_iSupport"
        Me.tst_iSupport.Size = New System.Drawing.Size(62, 35)
        Me.tst_iSupport.Text = "Support"
        Me.tst_iSupport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tst_iSupport.Visible = False
        '
        'tst_iSupport_Instruction
        '
        Me.tst_iSupport_Instruction.Image = Global.PSMGlobal.My.Resources.Resources.Question_16x16
        Me.tst_iSupport_Instruction.Name = "tst_iSupport_Instruction"
        Me.tst_iSupport_Instruction.Size = New System.Drawing.Size(154, 22)
        Me.tst_iSupport_Instruction.Text = "Instruction"
        '
        'tst_iSupport_OnlineSupport
        '
        Me.tst_iSupport_OnlineSupport.Image = Global.PSMGlobal.My.Resources.Resources.IDE_16x16
        Me.tst_iSupport_OnlineSupport.Name = "tst_iSupport_OnlineSupport"
        Me.tst_iSupport_OnlineSupport.Size = New System.Drawing.Size(154, 22)
        Me.tst_iSupport_OnlineSupport.Text = "Online Support"
        '
        'tst_iSupport_About
        '
        Me.tst_iSupport_About.Image = Global.PSMGlobal.My.Resources.Resources.Point_16x16
        Me.tst_iSupport_About.Name = "tst_iSupport_About"
        Me.tst_iSupport_About.Size = New System.Drawing.Size(154, 22)
        Me.tst_iSupport_About.Text = "About"
        '
        'tst_iClose
        '
        Me.tst_iClose.Image = Global.PSMGlobal.My.Resources.Resources.Close_16x16
        Me.tst_iClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tst_iClose.Name = "tst_iClose"
        Me.tst_iClose.Size = New System.Drawing.Size(63, 35)
        Me.tst_iClose.Text = "Close (&F4)"
        Me.tst_iClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PeaceForm_ISUD
        '
        Me.ClientSize = New System.Drawing.Size(999, 535)
        Me.Controls.Add(Me.Tst_Main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PeaceForm_ISUD"
        Me.Tst_Main.ResumeLayout(False)
        Me.Tst_Main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tst_Main As System.Windows.Forms.ToolStrip
    Friend WithEvents Tst_iBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents Tst_iNext As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_iNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_iEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_iSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_iDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_iStatus As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_iRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_iUtilities As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tst_iSample As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_iPrint As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_iFeedback As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_iClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents tst_iAttach As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iHistory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iStandard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iCustomize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iExport As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tst_iExport_Excel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iExport_Pdf As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tst_iPrint_Print As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iSupport As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents tst_iSupport_Instruction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iSupport_OnlineSupport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tst_iSupport_About As System.Windows.Forms.ToolStripMenuItem

End Class
