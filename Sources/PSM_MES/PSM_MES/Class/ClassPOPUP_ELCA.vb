
Imports System.Runtime.InteropServices
Public Class ClassPOPUP_ELCA
    Inherits ContextMenuStrip
    Public Indexx As Integer = -1

    Private Structure PointAPI
        Public x As Integer
        Public y As Integer
    End Structure
    Private Declare Function GetCursorPos Lib "user32" (ByRef lpPoint As PointAPI) As Boolean

    Public Function PopupNew(ByVal sender As Object, ByVal x As Integer, ByVal y As Integer, ByVal ParamArray Chuoi() As String) As Integer
        PopupNew = -1
        Dim MenuAt As New ContextMenuStrip
        Dim i As Integer
        For i = 0 To UBound(Chuoi)
            MenuAt.Items.Add(Chuoi(i))
        Next

        AddHandler MenuAt.ItemClicked, AddressOf MenuClick
        AddHandler MenuAt.Closed, AddressOf MenuClose

        MenuAt.Show(sender, New System.Drawing.Point(x, y))
    End Function

    Public Function PopupNew(ByVal sender As Object, ByVal ParamArray Chuoi() As String) As Integer
        PopupNew = -1
        Dim MenuAt As New ContextMenuStrip
        Dim pt As PointAPI

        Dim i As Integer
        For i = 0 To UBound(Chuoi)
            MenuAt.Items.Add(Chuoi(i))
        Next

        AddHandler MenuAt.ItemClicked, AddressOf MenuClick
        AddHandler MenuAt.Closed, AddressOf MenuClose


        If GetCursorPos(pt) Then
            If pt.y > 120 Then MenuAt.Show(sender, New System.Drawing.Point(pt.x, pt.y - 120))
        End If
    End Function

    Public Sub MenuClose(sender As Object, e As EventArgs)
        If Indexx = -1 Then Indexx = 0
    End Sub
    Public Sub MenuClick(sender As Object, e As ToolStripItemClickedEventArgs)
        Indexx = -1
        Dim MenuAt As ContextMenuStrip
        MenuAt = CType(sender, ContextMenuStrip)
        Try
            If MenuAt.Items(0).Selected = True Then
                Indexx = 1
            ElseIf MenuAt.Items(1).Selected = True Then
                Indexx = 2
            ElseIf MenuAt.Items(2).Selected = True Then
                Indexx = 3
            ElseIf MenuAt.Items(3).Selected = True Then
                Indexx = 4
            ElseIf MenuAt.Items(4).Selected = True Then
                Indexx = 5
            ElseIf MenuAt.Items(5).Selected = True Then
                Indexx = 6
            ElseIf MenuAt.Items(6).Selected = True Then
                Indexx = 7
            ElseIf MenuAt.Items(7).Selected = True Then
                Indexx = 8
            ElseIf MenuAt.Items(8).Selected = True Then
                Indexx = 9
            ElseIf MenuAt.Items(9).Selected = True Then
                Indexx = 10

            ElseIf MenuAt.Items(10).Selected = True Then
                Indexx = 11
            ElseIf MenuAt.Items(11).Selected = True Then
                Indexx = 12
            ElseIf MenuAt.Items(12).Selected = True Then
                Indexx = 13
            ElseIf MenuAt.Items(13).Selected = True Then
                Indexx = 14
            ElseIf MenuAt.Items(14).Selected = True Then
                Indexx = 15
            ElseIf MenuAt.Items(15).Selected = True Then
                Indexx = 16
            ElseIf MenuAt.Items(16).Selected = True Then
                Indexx = 17
            ElseIf MenuAt.Items(17).Selected = True Then
                Indexx = 18
            ElseIf MenuAt.Items(18).Selected = True Then
                Indexx = 19
            ElseIf MenuAt.Items(19).Selected = True Then
                Indexx = 20

            ElseIf MenuAt.Items(20).Selected = True Then
                Indexx = 21
            ElseIf MenuAt.Items(21).Selected = True Then
                Indexx = 22
            ElseIf MenuAt.Items(22).Selected = True Then
                Indexx = 23
            ElseIf MenuAt.Items(23).Selected = True Then
                Indexx = 24
            ElseIf MenuAt.Items(24).Selected = True Then
                Indexx = 25
            ElseIf MenuAt.Items(25).Selected = True Then
                Indexx = 26
            ElseIf MenuAt.Items(26).Selected = True Then
                Indexx = 27
            ElseIf MenuAt.Items(27).Selected = True Then
                Indexx = 28
            ElseIf MenuAt.Items(28).Selected = True Then
                Indexx = 29
            ElseIf MenuAt.Items(29).Selected = True Then
                Indexx = 30

            ElseIf MenuAt.Items(30).Selected = True Then
                Indexx = 31
            ElseIf MenuAt.Items(31).Selected = True Then
                Indexx = 32
            ElseIf MenuAt.Items(32).Selected = True Then
                Indexx = 33
            ElseIf MenuAt.Items(33).Selected = True Then
                Indexx = 34
            ElseIf MenuAt.Items(34).Selected = True Then
                Indexx = 35
            ElseIf MenuAt.Items(35).Selected = True Then
                Indexx = 36
            ElseIf MenuAt.Items(36).Selected = True Then
                Indexx = 37
            ElseIf MenuAt.Items(37).Selected = True Then
                Indexx = 38
            ElseIf MenuAt.Items(38).Selected = True Then
                Indexx = 39
            ElseIf MenuAt.Items(39).Selected = True Then
                Indexx = 40

            ElseIf MenuAt.Items(40).Selected = True Then
                Indexx = 41
            ElseIf MenuAt.Items(41).Selected = True Then
                Indexx = 42
            ElseIf MenuAt.Items(42).Selected = True Then
                Indexx = 43
            ElseIf MenuAt.Items(43).Selected = True Then
                Indexx = 44
            ElseIf MenuAt.Items(44).Selected = True Then
                Indexx = 45
            ElseIf MenuAt.Items(45).Selected = True Then
                Indexx = 46
            ElseIf MenuAt.Items(46).Selected = True Then
                Indexx = 47
            ElseIf MenuAt.Items(47).Selected = True Then
                Indexx = 48
            ElseIf MenuAt.Items(48).Selected = True Then
                Indexx = 49
            ElseIf MenuAt.Items(49).Selected = True Then
                Indexx = 50
            End If
        Catch ex As Exception

        End Try
        
    End Sub
End Class
