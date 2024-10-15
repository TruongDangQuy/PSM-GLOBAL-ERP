
Public Class ISUD7421A
#Region "Variable"
    Private checkrn As Boolean = False
    Private W7421 As T7421_AREA


    Private formA As Boolean


#End Region

#Region "Link"
    Public Function Link_ISUD7421A(job As Integer, _proname1 As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName
        txt_IDNO.Data = _proname1
        Link_ISUD7421A = False

        formA = False
        Me.ShowDialog()

        Link_ISUD7421A = isudCHK
    End Function
#End Region

#Region "Form_load"
    
    Private Sub ISUD7421A_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FORM_INIT()
        DATA_INIT()

        Call DATA_SEARCH_vS1()
        Call DATA_SEARCH_VS2()
    End Sub
    Private Sub FORM_INIT()

    End Sub
    Private Sub DATA_INIT()

    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH_vS1(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH_vS1 = False

        vS1.Enabled = False

        DS1 = PrcDS("USP_ISUD7421_SEARCH_vS1", cn, Pub.GRP)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7421_SEARCH_vS1", "vS1")
            vS1.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_ISUD7421_SEARCH_vS1", "vS1")
        DATA_SEARCH_vS1 = True

        vS1.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS2(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH_VS2 = False

        vS2.Enabled = False

        DS1 = PrcDS("USP_ISUD7421_SEARCH_vS2", cn, Pub.SAW)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7421_SEARCH_vS2", "vS2")
            vS2.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_ISUD7421_SEARCH_vS2", "vS2")
        DATA_SEARCH_VS2 = True

        vS2.Enabled = True
    End Function
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer
        Dim StrChk As String = ""

        Try

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim i As Integer
        Dim StrChk As String = ""

        If Data_Check() = False Then Exit Sub

        Try
            For i = 0 To vS2.ActiveSheet.RowCount - 1
                If K7421_MOVE(vS2, i, W7421, getData(vS2, getColumIndex(vS2, "KEY_IDNO"), i), getData(vS2, getColumIndex(vS2, "KEY_ItemCode"), i)) Then
                    W7421.IDNO = Pub.SAW
                    Call REWRITE_PFK7421(W7421)
                Else
                    W7421.IDNO = Pub.SAW
                    If W7421.ItemCode <> "" Then
                        Call WRITE_PFK7421(W7421)
                    End If
                End If
            Next
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        Me.Dispose()
    End Sub

    Private Sub vS2_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS2.ButtonClicked
        If e.Column <> getColumIndex(vS2, "CLItemCode") Then Exit Sub

        If HLP9911ALL.Link_HLP9911A("") = False Then Exit Sub

        setData(vS2, getColumIndex(vS2, "ItemCode"), e.Row, D9911.ItemCode)
        setData(vS2, getColumIndex(vS2, "ItemName"), e.Row, D9911.ItemName)
    End Sub

    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim StrMsg As String = MsgBox("Do you want to delete!", vbYesNo)

            If StrMsg <> vbYes Then Exit Sub

            If READ_PFK7421(getData(vS2, getColumIndex(vS2, "KEY_IDNO"), vS2.ActiveSheet.ActiveRowIndex), getData(vS2, getColumIndex(vS2, "KEY_ItemCode"), vS2.ActiveSheet.ActiveRowIndex)) Then
                W7421 = D7421
                Call DELETE_PFK7421(W7421)

                SPR_DEL(sender, 0, vS2.ActiveSheet.ActiveRowIndex)

            End If

        End If
    End Sub
#End Region

End Class