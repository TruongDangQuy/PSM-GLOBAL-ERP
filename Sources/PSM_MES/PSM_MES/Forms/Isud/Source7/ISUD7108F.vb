
Public Class ISUD7108F
#Region "Variable"
    Private checkrn As Boolean = False

    Private W7231 As T7231_AREA
    Private W7421 As T7421_AREA

    Private W7108 As T7108_AREA
    Private L7108 As T7108_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private formA As Boolean

#End Region

#Region "Link"
    Public Function Link_ISUD7108F(job As Integer, _proname1 As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName

        L7108.GroupComponentBOM = _proname1

        Link_ISUD7108F = False

        formA = False
        Me.ShowDialog()

        Link_ISUD7108F = isudCHK
    End Function
#End Region

#Region "Form_load"

    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call FORM_INIT()
        Call DATA_INIT()

        Call DATA_SEARCH_vS1()
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

        DS1 = PrcDS("USP_ISUD7108F_SEARCH_vS1", cn, L7108.GroupComponentBOM)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7108F_SEARCH_vS1", "vS1")
            vS1.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_ISUD7108F_SEARCH_vS1", "vS1")
        DATA_SEARCH_vS1 = True

        vS1.Enabled = True
    End Function

    Private Function DATA_SEARCH_VS2(ByVal mMaterialCode As String, Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS2 = False

        Dim mMaterialType As String

        Try
            vS2.Enabled = False

            mMaterialType = "2"  ' 1.Main 2.R&D
            DS1 = PrcDS("USP_ISUD7108F_SEARCH_vS2", cn, mMaterialCode, mMaterialType)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS2, DS1, "USP_ISUD7108F_SEARCH_vS2", "vS2")
                vS2.Enabled = True

                Exit Function
            End If

            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7108F_SEARCH_vS2", "vS2")
            DATA_SEARCH_VS2 = True

            vS2.Enabled = True

        Catch ex As Exception

        End Try
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean

        Dim RS01 As DataRow = Nothing

        Vs1.Enabled = False

        LINE_MOVE_DISPLAY01 = False

        DS1 = PrcDS("USP_ISUD7108F_SEARCH_vS1_LINE", cn, getData(vS1, getColumIndex(vS1, "KEY_GroupComponentBOM"), vS1.ActiveSheet.ActiveRowIndex), _
                                                         getData(vS1, getColumIndex(vS1, "KEY_GroupComponentSeq"), vS1.ActiveSheet.ActiveRowIndex))

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Exit Function
        End If

        READ_SPREAD(vS1, DS1, "USP_ISUD7108F_SEARCH_vS1", "Vs1", vS1.ActiveSheet.ActiveRowIndex)

        LINE_MOVE_DISPLAY01 = True

        Vs1.Enabled = True
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
            For i = 0 To vS1.ActiveSheet.RowCount - 1

                If getData(vS1, getColumIndex(vS1, "KEY_GroupComponentBOM"), i) <> "" Then

                    W7109.GroupComponentBOM = getData(vS1, getColumIndex(vS1, "KEY_CustomerCode"), vS1.ActiveSheet.ActiveRowIndex)
                    W7109.GroupComponentSeq = getData(vS1, getColumIndex(vS1, "KEY_CustomerCode"), vS1.ActiveSheet.ActiveRowIndex)

                    If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) = True Then
                        W7109 = D7109

                        W7109.SupplierCode = getData(vS1, getColumIndex(vS1, "KEY_CustomerCode"), vS1.ActiveSheet.ActiveRowIndex)

                        Call REWRITE_PFK7109(W7109)

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
    Private Sub vS1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        Try

            W7231.MaterialCode = getData(vS1, getColumIndex(vS1, "KEY_MaterialCode"), vS1.ActiveSheet.ActiveRowIndex)

            If W7231.MaterialCode = "" Then Exit Sub


            Call DATA_SEARCH_VS2(W7231.MaterialCode)

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Sub
    'Private Sub vS2_CellClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellClick
    '    Try

    '        W7109.MaterialCode = getData(vS2, getColumIndex(vS2, "KEY_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)
    '        W7109.SupplierCode = getData(vS2, getColumIndex(vS2, "KEY_CustomerCode"), vS2.ActiveSheet.ActiveRowIndex)

    '        W7109.GroupComponentBOM = getData(vS1, getColumIndex(vS1, "KEY_GroupComponentBOM"), vS1.ActiveSheet.ActiveRowIndex)
    '        W7109.GroupComponentSeq = getData(vS1, getColumIndex(vS1, "KEY_GroupComponentSeq"), vS1.ActiveSheet.ActiveRowIndex)

    '        If Trim$(W7109.SupplierCode) = "" Then Exit Sub

    '        If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) = True Then
    '            W7109 = D7109

    '            W7109.SupplierCode = getData(vS2, getColumIndex(vS2, "KEY_CustomerCode"), vS2.ActiveSheet.ActiveRowIndex)

    '            Call REWRITE_PFK7109(W7109)

    '        End If

    '        Call LINE_MOVE_DISPLAY01()

    '    Catch ex As Exception
    '        Call MsgBoxP("1", "DATE_SEARCH01")
    '    End Try
    'End Sub
    Private Sub vS2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
        Try

            W7109.MaterialCode = getData(vS2, getColumIndex(vS2, "KEY_MaterialCode"), vS2.ActiveSheet.ActiveRowIndex)
            W7109.SupplierCode = getData(vS2, getColumIndex(vS2, "KEY_CustomerCode"), vS2.ActiveSheet.ActiveRowIndex)

            W7109.GroupComponentBOM = getData(vS1, getColumIndex(vS1, "KEY_GroupComponentBOM"), vS1.ActiveSheet.ActiveRowIndex)
            W7109.GroupComponentSeq = getData(vS1, getColumIndex(vS1, "KEY_GroupComponentSeq"), vS1.ActiveSheet.ActiveRowIndex)

            If Trim$(W7109.SupplierCode) = "" Then Exit Sub

            If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) = True Then
                W7109 = D7109

                W7109.SupplierCode = getData(vS2, getColumIndex(vS2, "KEY_CustomerCode"), vS2.ActiveSheet.ActiveRowIndex)

                Call REWRITE_PFK7109(W7109)

            End If

            Call LINE_MOVE_DISPLAY01()

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try

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