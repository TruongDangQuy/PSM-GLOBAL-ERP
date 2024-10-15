Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Public Class PeaceContextMenuStrip
    Inherits Windows.Forms.ContextMenuStrip
    Private blnClose As Boolean = True

    Private Sub PeaceContextMenuStrip_Closing(sender As Object, e As ToolStripDropDownClosingEventArgs) Handles Me.Closing
        e.Cancel = Not blnClose
        blnClose = True
    End Sub

    Public Overridable Sub PeaceContextMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Me.ItemClicked

    End Sub

    Private Sub PeaceContextMenuStrip_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        blnClose = False
    End Sub
End Class
