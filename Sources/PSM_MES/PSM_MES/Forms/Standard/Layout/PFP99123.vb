Imports DevExpress.Utils.Menu
Imports System.IO
Imports System.Text
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Imports System.Windows.Forms.TextBox

Public Class PFP99123

    Private W9701 As T9701_AREA
    Private W9705 As T9705_AREA

    Private stream As New MemoryStream()
    Public Sub Link_CONTROLLAYOUT_FORM(_FormName As String, _GroupUser As String)

        Me.Name = _FormName
        Layout_GroupUser = _GroupUser
        Me.ShowDialog()

    End Sub

    Private Sub LayoutControl1_PopupMenuShowing(ByVal sender As System.Object, ByVal e As PopupMenuShowingEventArgs) Handles LayoutControl.PopupMenuShowing
        e.Menu.Items.Add(New DXMenuItem("Save Layout", AddressOf SaveLayout))
        e.Menu.Items.Add(New DXMenuItem("Restore Layout", AddressOf RestoreLayout))
        e.Menu.Items.Add(New DXMenuItem("Save Layout To Server", AddressOf SaveLayoutToServerFile))
        e.Menu.Items.Add(New DXMenuItem("Restore Layout from Server", AddressOf LoadLayoutToServerFile))
        e.Menu.Items.Add(New DXMenuItem("Customization Layout", AddressOf Link_Layout))
    End Sub
    Private Sub CONTROLLAYOUT_FORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LayoutControl.RegisterUserCustomizationForm(GetType(ISUD9702B))

        If Me.Name = "CONTROLLAYOUT_FORM" Then
            PFP99125.Link_OPENLAYOUT("")
            If Layout_FormName <> String.Empty Then
                Me.Name = Layout_FormName
            End If
        End If

        Call LoadItemPEACE(Me.Name, LayoutControl)
        Call LoadLayout()

    End Sub

    Private Sub LoadLayout()

        Try
            Dim text As String = String.Empty
            SQL = "select top 1 * from PFK9701 where K9701_FormName = '" & Me.Name & "' and K9701_User = '" & Pub.SAW & "' and K9701_GroupUser = '" & Layout_GroupUser & "' Order by K9701_Version DESC "
            DS2 = SqlDS(SQL, cn)

            If GetDsRc(DS2) > 0 Then
                For Each RS01 As DataRow In DS2.Tables(0).Rows
                    text = RS01!K9701_Data
                Next
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                LayoutControl.RestoreLayoutFromStream(stream)
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub SaveLayout(ByVal sender As Object, ByVal e As EventArgs)

        Dim Link As String = "XML\" ' Lấy link từ server

        PFP99126.Link_SAVELAYOUT(Me.Name, Layout_GroupUser)

        Dim str As Stream = New System.IO.MemoryStream()
        LayoutControl.SaveLayoutToStream(str)
        str.Seek(0, System.IO.SeekOrigin.Begin)
        Dim reader As New StreamReader(str)
        Dim text As String = reader.ReadToEnd()

        W9701.FormName = Layout_FormName
        W9701.GroupUser = Layout_GroupUser
        W9701.User = Pub.SAW
        W9701.Data = text
        W9701.DateCreate = Layout_Date
        W9701.Version = Layout_Version
        W9701.Remark = Layout_Remark

        W9705.FormName = Layout_FormName
        W9705.GroupUser = Layout_GroupUser
        W9705.Data = text
        W9705.DateCreate = Layout_Date
        W9705.Version = Layout_Version

        ' Save cho table PEACE
        If READ_PFK9701(Layout_FormName, Pub.SAW, Layout_GroupUser, Layout_Version) = False Then
            Call WRITE_PFK9701(W9701)
        Else
            Call REWRITE_PFK9701(W9701)
        End If
        ' Save cho table User
        If READ_PFK9705(Layout_FormName, Layout_GroupUser) = False Then
            Call WRITE_PFK9705(W9705)
        Else
            Call REWRITE_PFK9705(W9705)
        End If

        'xuat File sau khi save
        Link = Link & Layout_FormName & "." & Layout_GroupUser & "." & Layout_Version & ".xml"

        LayoutControl.SaveLayoutToXml(Link)

    End Sub

    Private Sub SaveLayoutToServerFile()
        Dim Link As String = "XML\" ' Lấy link từ server

        PFP99126.Link_SAVELAYOUT(Me.Name, Layout_GroupUser)

        Link = Link & Layout_FormName & "." & Layout_GroupUser & "." & Layout_Version & ".xml"

        LayoutControl.SaveLayoutToXml(Link)

    End Sub

    Private Sub LoadLayoutToServerFile()
        Dim Link As String = "" ' Lấy link từ server
        Dim vERSION As String = InputBox("vERSION?")

        Call LoadLayout(vERSION)
        ' LayoutControl.RestoreLayoutFromXml(Link)

    End Sub

    Private Sub LoadLayout(VERSION)

        Try
            Dim text As String = String.Empty
            SQL = "select top 1 * from PFK9701 where K9701_FormName = '" & Me.Name & "' and K9701_User = '" & Pub.SAW & "' and K9701_GroupUser = '" & Layout_GroupUser & "' AND K9701_Version = '" & VERSION & "' "
            DS2 = SqlDS(SQL, cn)

            If GetDsRc(DS2) > 0 Then
                For Each RS01 As DataRow In DS2.Tables(0).Rows
                    text = RS01!K9701_Data
                Next
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                LayoutControl.RestoreLayoutFromStream(stream)
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RestoreLayout(ByVal sender As Object, ByVal e As EventArgs)
        While Me.LayoutControl.HiddenItems.Count > 0
            Me.LayoutControl.HiddenItems(0).RestoreFromCustomization()
        End While
    End Sub

    Private Sub Link_Layout(ByVal sender As Object, ByVal e As EventArgs)
        ISUD9702A.Link_COUSTOMIZATION_ISUD(Me.Name)
    End Sub
End Class