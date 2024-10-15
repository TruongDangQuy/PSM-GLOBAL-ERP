Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Public Class ISUBBIG

    Public Function Link_ISUBBIG(Spr As FarPoint.Win.Spread.FpSpread, Optional ByVal TAG As String = "") As Boolean
        Link_ISUBBIG = False
        Me.Text = Spr.Tag
        Me.vSPlan.Sheets.Add(Clone(Spr.ActiveSheet))

        Me.vSPlan.ActiveSheetIndex = 1
        Me.vSPlan.Sheets.RemoveAt(0)
        Me.BringToFront()
        Me.WindowState = FormWindowState.Maximized
        Me.Show()
    End Function

    Public Function CopySheet(sheet As FarPoint.Win.Spread.SheetView) As FarPoint.Win.Spread.SheetView
        Dim newSheet As FarPoint.Win.Spread.SheetView = Nothing
        If Not IsNothing(sheet) Then
            newSheet = FarPoint.Win.Serializer.LoadObjectXml(GetType(FarPoint.Win.Spread.SheetView), FarPoint.Win.Serializer.GetObjectXml(sheet, "CopySheet"), "CopySheet")
        End If
        Return newSheet
    End Function

    Private Function Clone(ByVal sheetView As SheetView) As SheetView
        Dim m As New MemoryStream
        Dim b As New BinaryFormatter
        sheetView.SheetName = "New"
        b.Serialize(m, sheetView)
        m.Position = 0

        Return b.Deserialize(m)
    End Function

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub ISUBBIG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs)

    End Sub
End Class