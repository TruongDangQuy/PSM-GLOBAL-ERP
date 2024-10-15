Imports DevExpress.Utils.Menu
Imports System.IO
Imports System.Text
Imports DevExpress.XtraLayout
Imports DevExpress.XtraLayout.Utils

Imports System.Windows.Forms.TextBox

Public Class LAU00000

    Private W9701 As T9701_AREA

    Private stream As New MemoryStream()

    Private GroupName As String = String.Empty
    Public Sub Link_LAU00000(FormName As String)

        Me.Name = FormName
        Me.ShowDialog()

    End Sub

    Private Sub LAU00000_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LayoutControl.RegisterUserCustomizationForm(GetType(ISUD9702B))

        If READ_PFK9992(Pub.SITE, Pub.SAW) = False Then
            GroupName = "000"
        Else
            GroupName = D9992.GROUP
        End If

        Call LoadItemUser(Me.Name, GroupName, LayoutControl)
        Call LoadLayoutToServerFile()

    End Sub

    Private Sub LoadLayout()
        Try
            Dim text As String = String.Empty
            SQL = "select top 1 * from PFK9705 where K9705_FormName = '" & Me.Name & "' and K9705_GroupUser = '" & GroupName & "' Order by K9705_Version DESC "
            DS2 = SqlDS(SQL, cn)

            If GetDsRc(DS2) > 0 Then
                For Each RS01 As DataRow In DS2.Tables(0).Rows
                    text = RS01!K9705_Data
                Next
                Dim byteArray As Byte() = Encoding.ASCII.GetBytes(text)
                Dim stream As New MemoryStream(byteArray)
                LayoutControl.RestoreLayoutFromStream(stream)
            End If

        Catch ex As Exception

        End Try

    End Sub


    Private Sub LoadLayoutToServerFile()

        Try
            Dim Link As String = "XML\" ' Lấy link từ server
            Dim text As String = String.Empty

            SQL = "select top 1 * from PFK9705 where K9705_FormName = '" & Me.Name & "' and K9705_GroupUser = '" & GroupName & "' Order by K9705_Version DESC "
            DS2 = SqlDS(SQL, cn)

            If GetDsRc(DS2) > 0 Then
                For Each RS01 As DataRow In DS2.Tables(0).Rows
                    text = RS01!K9705_FormName & "." & RS01!K9705_GroupUser & "." & RS01!K9705_Version
                Next
            End If

            Link = Link & text & ".xml"
            LayoutControl.RestoreLayoutFromXml(Link)
        Catch ex As Exception

        End Try
    End Sub

   

End Class