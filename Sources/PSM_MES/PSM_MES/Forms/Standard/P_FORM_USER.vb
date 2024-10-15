'Public Class P_FORM_USER
'#Region "Variable"
'    Private checkrn As Boolean = False
'    Private W9916 As T9916_AREA


'    Private formA As Boolean


'#End Region

'#Region "Form_load"
'    Public Function Link_ISUD_P_FORM_USER(job As Integer, _proname1 As String, Optional CheckName As String = "") As Boolean
'        Me.Tag = CheckName
'        txt_Program.Data = _proname1
'        Link_ISUD_P_FORM_USER = False

'        formA = False
'        Me.ShowDialog()

'        Link_ISUD_P_FORM_USER = isudCHK
'    End Function
'    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        form_int()
'        data_int()
'        Call DATA_SEARCH01()
'    End Sub
'    Private Sub form_int()

'    End Sub
'    Private Sub data_int()

'    End Sub
'#End Region

'    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean

'        DATA_SEARCH01 = False

'        vS1.Enabled = False

'        DS1 = PrcDS("USP_ISUD9916_SEARCH_VS1", cn, txt_Program.Data)

'        If GetDsRc(DS1) = 0 Then
'            SPR_PRO_NEW(vS1, DS1, "USP_ISUD9916_SEARCH_VS1", "Vs1")
'            vS1.Enabled = True

'            Exit Function
'        End If

'        SPR_PRO_NEW(vS1, DS1, "USP_ISUD9916_SEARCH_VS1", "Vs1")
'        DATA_SEARCH01 = True

'        vS1.Enabled = True
'    End Function



'#Region "Event"

'    Private Sub cmd_K9912_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
'        Dim i As Integer

'        Try
'            For i = 0 To vS1.ActiveSheet.RowCount - 1
'                If K9916_MOVE(vS1, i, W9916, getData(vS1, getColumIndex(vS1, "ProgramNo"), i), getData(vS1, getColumIndex(vS1, "ItemCode"), i), getData(vS1, getColumIndex(vS1, "ItemName"), i)) Then
'                    Call REWRITE_PFK9916(W9916)
'                End If
'            Next
'            Me.Dispose()
'        Catch ex As Exception

'        End Try
'    End Sub
'#End Region

'    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
'        Me.Dispose()
'    End Sub

'    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
'        If READ_PFK9916_2(txt_Program.Data) Then
'            If DELETE_PFK9916_1(D9916) Then
'                Me.Dispose()
'            End If
'        End If
'    End Sub
'End Class


Public Class P_FORM_USER
#Region "Variable"
    Private checkrn As Boolean = False
    Private W9916 As T9916_AREA


    Private formA As Boolean


#End Region

#Region "Form_load"
    Public Function Link_ISUD_P_FORM_USER(job As Integer, _proname1 As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName
        txt_Program.Data = _proname1
        Link_ISUD_P_FORM_USER = False

        formA = False
        Me.ShowDialog()

        Link_ISUD_P_FORM_USER = isudCHK
    End Function
    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_int()
        data_int()
        Call DATA_SEARCH01()
    End Sub
    Private Sub form_int()

    End Sub
    Private Sub data_int()

    End Sub
#End Region

    Private Function DATA_SEARCH01(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH01 = False

        vS1.Enabled = False

        DS1 = PrcDS("USP_ISUD9916_SEARCH_VS1", cn, txt_Program.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD9916_SEARCH_VS1", "Vs1")
            vS1.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_ISUD9916_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        vS1.Enabled = True
    End Function



#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim i As Integer
        Dim StrChk As String = ""

        If Data_Check() = False Then Exit Sub

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If K9916_MOVE(vS1, i, W9916, getData(vS1, getColumIndex(vS1, "ProgramNo"), i), getData(vS1, getColumIndex(vS1, "ItemCode"), i), getData(vS1, getColumIndex(vS1, "ItemName"), i)) Then
                    Call REWRITE_PFK9916(W9916)
                End If
            Next
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer
        Dim StrChk As String = ""

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "CheckDev"), i) = "1" Then

                    StrChk = getData(vS1, getColumIndex(vS1, "REMK"), i)

                    If StrChk.Contains(";") Then
                        Select Case Split(StrChk, ";")(0)
                            Case 8
                                StrChk = Split(StrChk, ";")(1)
                                If READ_PFK7171("000", StrChk) = False Then MsgBoxP("Error at" & W9916.ItemName) : Exit Select

                        End Select

                    End If

                End If

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        If READ_PFK9916_2(txt_Program.Data) Then
            If DELETE_PFK9916_1(D9916) Then
                Me.Dispose()
            End If
        End If
    End Sub
End Class