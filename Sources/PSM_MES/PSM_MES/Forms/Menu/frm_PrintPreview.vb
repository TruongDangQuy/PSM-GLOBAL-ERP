Imports System.IO
Imports System.Net


Public Class frm_PrintPreview

#Region "Variable"
    Private formA As Boolean
    Private checkisud As Boolean
    Private CHK(0 To 5) As String
    Private W7233 As T7233_AREA
#End Region

#Region "Form_Load"

#End Region

#Region "Methods"
    Public Sub LINKDATA(MaterialCode As String)
        txt_MaterialName.Code = MaterialCode

        If READ_PFK7231(MaterialCode) Then
            txt_MaterialName.Data = D7231.MaterialName
            txt_MaterialName.Code = D7231.MaterialCode
        End If

        If READ_PFK7233(MaterialCode) Then
            txt_FontName.Data = D7233.FontName

            txt_FontSize.Value = D7233.FontSize
            txt_POSX.Value = D7233.POSX
            txt_POSY.Value = D7233.POSY

            If D7233.FontBold = "1" Then chk_Bold.Checked = True Or chk_Bold.Checked = False

        End If

        Me.ShowDialog()

    End Sub
#End Region

#Region "Events"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If READ_PFK7233(txt_MaterialName.Code) = True Then
            W7233 = D7233
            W7233.FontName = txt_FontName.Data
            If W7233.FontName = "" Then W7233.FontName = "Tahoma"
            W7233.FontSize = txt_FontSize.Value
            W7233.POSX = txt_POSX.Value
            W7233.POSY = txt_POSY.Value
            If chk_Bold.Checked = True Then W7233.FontBold = "1" Else W7233.FontBold = "2"

            Call REWRITE_PFK7233(W7233)

        Else
            W7233.MaterialCode = txt_MaterialName.Code
            W7233.FontName = txt_FontName.Data
            If W7233.FontName = "" Then W7233.FontName = "Tahoma"
            W7233.FontSize = txt_FontSize.Value
            W7233.POSX = txt_POSX.Value
            W7233.POSY = txt_POSY.Value
            If chk_Bold.Checked = True Then W7233.FontBold = "1" Else W7233.FontBold = "2"

            Call WRITE_PFK7233(W7233)
        End If

        chk_Preview = False
        chk_Print = True
        Me.Close()
    End Sub

    Private Sub cmd_Preview_Click(sender As Object, e As EventArgs) Handles cmd_Preview.Click
        chk_Preview = True
        chk_Print = True
        Me.Close()
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        chk_Print = False
        Me.Close()
    End Sub

    Private Sub cmd_FontDialog_Click(sender As Object, e As EventArgs) Handles cmd_FontDialog.Click
        FontDialog1.ShowDialog()
        txt_FontName.Data = FontDialog1.Font.Name
        txt_FontSize.Value = FontDialog1.Font.Size
        If FontDialog1.Font.Bold = True Then
            chk_Bold.Checked = True
        Else
            chk_Bold.Checked = False
        End If
    End Sub
#End Region

End Class