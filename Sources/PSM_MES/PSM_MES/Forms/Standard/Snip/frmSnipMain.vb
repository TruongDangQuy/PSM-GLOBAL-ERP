Public Class frmSnipMain
#Region "Variable"
    Dim FolderBrowser As New FolderBrowserDialog
    Dim DefaultLocation As String

    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

    Public Shared selectPen As New Pen(Color.Red)
    Private formA As Boolean
#End Region

#Region "Form_Load"

    Public Function frmSnipMain_Link(_FormName As String, Value As String) As Boolean
        FormTableName = _FormName
        FormTablePara = Value

        frmSnipMain_Link = False
        formA = False

        Me.Tag = Tag
        Me.ShowDialog()

        frmSnipMain_Link = isudCHK
    End Function

    Private Sub Main_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not System.IO.File.Exists(AppDomain.CurrentDomain.BaseDirectory.ToString() + "DefaultLocation.txt") Then
            Dim file As System.IO.FileStream
            file = System.IO.File.Create(AppDomain.CurrentDomain.BaseDirectory.ToString() + "DefaultLocation.txt")
            file.Close()
        Else
            DefaultLocation = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory.ToString() + "DefaultLocation.txt")
            txtDefaultLocation.Text = DefaultLocation
        End If
        Me.Width = txtDefaultLocation.Width
        Me.Cursor = Cursors.Default
    End Sub
#End Region

#Region "Function"

#End Region

#Region "Event"
    Private Sub tstNew_Click(sender As Object, e As EventArgs) Handles tstNew.Click
        tstDropDownButton1.DropDown.Show()
        tstDropDownButton1.DropDownDirection = ToolStripDropDownDirection.BelowRight
    End Sub

    Private Sub tstDropDownButton_Click(sender As Object, e As EventArgs) Handles tstDropDownButton1.Click
        tstDropDownButton1.DropDown.Show()
        tstDropDownButton1.DropDownDirection = ToolStripDropDownDirection.BelowRight
    End Sub

    Private Sub tstOption_Click(sender As Object, e As EventArgs) Handles tstOption.Click
        tstDropDownButton2.ShowDropDown()
        tstDropDownButton2.DropDownDirection = ToolStripDropDownDirection.BelowRight
    End Sub

    Friend Sub mniRect_Click(sender As Object, e As EventArgs) Handles mniRect.Click
        Me.Opacity = 0
        mniRect.Checked = True
        mniFull.Checked = False
        SnippedRect.Snip()
    End Sub

    Private Sub mniFull_Click(sender As Object, e As EventArgs) Handles mniFull.Click
        Me.Opacity = 0
        mniFull.Checked = True
        mniRect.Checked = False
        SnippedFull.Snip()
    End Sub

    Public Sub mniChangeDefaultLocation_Click(sender As Object, e As EventArgs) Handles mniChageDefaultLocation.Click
        If FolderBrowser.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtDefaultLocation.Text = FolderBrowser.SelectedPath
            DefaultLocation = FolderBrowser.SelectedPath
            System.IO.File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory.ToString() + "DefaultLocation.txt", DefaultLocation)
        End If
    End Sub

 
#End Region
End Class