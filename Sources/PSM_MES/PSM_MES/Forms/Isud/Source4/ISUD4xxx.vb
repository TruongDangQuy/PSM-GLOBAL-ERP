
Public Class ISUD4xxx
    Private formA As Boolean
    Private _SizeRange As String
    Private _JobCard As String
    Private _MoldCode As String

    Public Function Link_ISUD4xxx(job As Integer, SizeRange As String, JobCard As String, Optional CheckName As String = "") As Boolean
        Batch_1 = Nothing

        _SizeRange = ""
        _SizeRange = SizeRange

        _JobCard = ""
        _JobCard = JobCard

        Link_ISUD4xxx = False
        Me.Tag = CheckName

        wJOB = job

        Select Case job
            Case 1, 5, 6

            Case Else

        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD4xxx = isudCHK
    End Function

    Public Function Link_ISUD4xxx_Mold(job As Integer, SizeRange As String, JobCard As String, MoldCode As String, Optional CheckName As String = "") As Boolean
        Batch_1 = Nothing

        _SizeRange = ""
        _SizeRange = SizeRange

        _JobCard = ""
        _JobCard = JobCard

        _MoldCode = ""
        _MoldCode = MoldCode

        Link_ISUD4xxx_Mold = False
        Me.Tag = CheckName

        wJOB = job

        Select Case job
            Case 1, 5, 6

            Case Else

        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD4xxx_Mold = isudCHK
    End Function

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        If formA = True Then Exit Sub

        Me.Form_KeyDown()
        Call DATA_INIT()
        Call DATA_SEARCH_VS1()

        formA = True
    End Sub

    Private Sub DATA_INIT()

    End Sub

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        If _MoldCode = "" Then
            DS1 = PrcDS("USP_ISUD4xxx_SEARCH_VS1", cn, _SizeRange, _JobCard)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD4xxx_SEARCH_VS1", "VS1")
                vS1.ActiveSheet.Rows(0).Locked = True
                vS1.ActiveSheet.Rows(1).Locked = True
                SPR_BACKCOLOR(vS1, Color.Lime, 0)
                SPR_BACKCOLOR(vS1, Color.LightYellow, 1)
                vS1.ActiveSheet.RowCount = 4
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_ISUD4xxx_SEARCH_VS1", "VS1")
            vS1.ActiveSheet.RowCount = 4
            vS1.ActiveSheet.Rows(0).Locked = True
            SPR_BACKCOLOR(vS1, Color.Lime, 0)
            vS1.ActiveSheet.Rows(1).Locked = True
            SPR_BACKCOLOR(vS1, Color.LightYellow, 1)
            vS1.ActiveSheet.RowCount = 4
            DATA_SEARCH_VS1 = True
        Else
            DS1 = PrcDS("USP_ISUD4xxx_INSERT_MOLDCODE", cn, _SizeRange, _JobCard, _MoldCode)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS1, DS1, "USP_ISUD4xxx_INSERT_MOLDCODE", "VS1")
                vS1.ActiveSheet.Rows(0).Locked = True
                vS1.ActiveSheet.Rows(1).Locked = True
                SPR_BACKCOLOR(vS1, Color.Lime, 0)
                SPR_BACKCOLOR(vS1, Color.LightYellow, 1)
                vS1.ActiveSheet.RowCount = 4
                Exit Function
            End If

            SPR_PRO_NEW(vS1, DS1, "USP_ISUD4xxx_INSERT_MOLDCODE", "VS1")
            vS1.ActiveSheet.RowCount = 4
            vS1.ActiveSheet.Rows(0).Locked = True
            SPR_BACKCOLOR(vS1, Color.Lime, 0)
            vS1.ActiveSheet.Rows(1).Locked = True
            SPR_BACKCOLOR(vS1, Color.LightYellow, 1)
            vS1.ActiveSheet.RowCount = 4
            DATA_SEARCH_VS1 = True
        End If

    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If CIntp(txt_BatchQty.Data) > 50 And CIntp(txt_BatchQty.Data) < 0 Then MsgBoxP("Batch Qty > 0 and <=50") : Exit Sub

        Try
            Batch_1.QtyBatch01 = CIntp(getData(vS1, 1, 2))
            Batch_1.QtyBatch02 = CIntp(getData(vS1, 2, 2))
            Batch_1.QtyBatch03 = CIntp(getData(vS1, 3, 2))
            Batch_1.QtyBatch04 = CIntp(getData(vS1, 4, 2))
            Batch_1.QtyBatch05 = CIntp(getData(vS1, 5, 2))
            Batch_1.QtyBatch06 = CIntp(getData(vS1, 6, 2))
            Batch_1.QtyBatch07 = CIntp(getData(vS1, 7, 2))
            Batch_1.QtyBatch08 = CIntp(getData(vS1, 8, 2))
            Batch_1.QtyBatch09 = CIntp(getData(vS1, 9, 2))
            Batch_1.QtyBatch10 = CIntp(getData(vS1, 10, 2))

            Batch_1.QtyBatch11 = CIntp(getData(vS1, 11, 2))
            Batch_1.QtyBatch12 = CIntp(getData(vS1, 12, 2))
            Batch_1.QtyBatch13 = CIntp(getData(vS1, 13, 2))
            Batch_1.QtyBatch14 = CIntp(getData(vS1, 14, 2))
            Batch_1.QtyBatch15 = CIntp(getData(vS1, 15, 2))
            Batch_1.QtyBatch16 = CIntp(getData(vS1, 16, 2))
            Batch_1.QtyBatch17 = CIntp(getData(vS1, 17, 2))
            Batch_1.QtyBatch18 = CIntp(getData(vS1, 18, 2))
            Batch_1.QtyBatch19 = CIntp(getData(vS1, 19, 2))
            Batch_1.QtyBatch20 = CIntp(getData(vS1, 20, 2))

            Batch_1.QtyBatch21 = CIntp(getData(vS1, 21, 2))
            Batch_1.QtyBatch22 = CIntp(getData(vS1, 22, 2))
            Batch_1.QtyBatch23 = CIntp(getData(vS1, 23, 2))
            Batch_1.QtyBatch24 = CIntp(getData(vS1, 24, 2))
            Batch_1.QtyBatch25 = CIntp(getData(vS1, 25, 2))
            Batch_1.QtyBatch26 = CIntp(getData(vS1, 26, 2))
            Batch_1.QtyBatch27 = CIntp(getData(vS1, 27, 2))
            Batch_1.QtyBatch28 = CIntp(getData(vS1, 28, 2))
            Batch_1.QtyBatch29 = CIntp(getData(vS1, 29, 2))
            Batch_1.QtyBatch30 = CIntp(getData(vS1, 30, 2))

            Batch_1.BatchQty01 = CIntp_S(txt_BatchQty.Data)

            'Batch_1.BatchQty01 = CIntp(getData(vS1, 1, 3))
            'Batch_1.BatchQty02 = CIntp(getData(vS1, 2, 3))
            'Batch_1.BatchQty03 = CIntp(getData(vS1, 3, 3))
            'Batch_1.BatchQty04 = CIntp(getData(vS1, 4, 3))
            'Batch_1.BatchQty05 = CIntp(getData(vS1, 5, 3))
            'Batch_1.BatchQty06 = CIntp(getData(vS1, 6, 3))
            'Batch_1.BatchQty07 = CIntp(getData(vS1, 7, 3))
            'Batch_1.BatchQty08 = CIntp(getData(vS1, 8, 3))
            'Batch_1.BatchQty09 = CIntp(getData(vS1, 9, 3))
            'Batch_1.BatchQty10 = CIntp(getData(vS1, 10, 3))

            'Batch_1.BatchQty11 = CIntp(getData(vS1, 11, 3))
            'Batch_1.BatchQty12 = CIntp(getData(vS1, 12, 3))
            'Batch_1.BatchQty13 = CIntp(getData(vS1, 13, 3))
            'Batch_1.BatchQty14 = CIntp(getData(vS1, 14, 3))
            'Batch_1.BatchQty15 = CIntp(getData(vS1, 15, 3))
            'Batch_1.BatchQty16 = CIntp(getData(vS1, 16, 3))
            'Batch_1.BatchQty17 = CIntp(getData(vS1, 17, 3))
            'Batch_1.BatchQty18 = CIntp(getData(vS1, 18, 3))
            'Batch_1.BatchQty19 = CIntp(getData(vS1, 19, 3))
            'Batch_1.BatchQty20 = CIntp(getData(vS1, 20, 3))

            'Batch_1.BatchQty21 = CIntp(getData(vS1, 21, 3))
            'Batch_1.BatchQty22 = CIntp(getData(vS1, 22, 3))
            'Batch_1.BatchQty23 = CIntp(getData(vS1, 23, 3))
            'Batch_1.BatchQty24 = CIntp(getData(vS1, 24, 3))
            'Batch_1.BatchQty25 = CIntp(getData(vS1, 25, 3))
            'Batch_1.BatchQty26 = CIntp(getData(vS1, 26, 3))
            'Batch_1.BatchQty27 = CIntp(getData(vS1, 27, 3))
            'Batch_1.BatchQty28 = CIntp(getData(vS1, 28, 3))
            'Batch_1.BatchQty29 = CIntp(getData(vS1, 29, 3))
            'Batch_1.BatchQty30 = CIntp(getData(vS1, 30, 3))

            isudCHK = True
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Batch_1 = Nothing

        isudCHK = False
        Me.Dispose()
    End Sub

    Private Sub vS1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        Try
            Dim QtyBatch As Integer
            Dim BatchQty As Integer
            Dim QtySeal As Integer

            QtyBatch = CIntp(getData(sender, e.Column, 2))
            QtySeal = CIntp(getData(sender, e.Column, 1))

            If QtyBatch > 0 Then
                BatchQty = QtySeal / QtyBatch
            Else
                BatchQty = Nothing
                QtyBatch = Nothing
            End If

            setData(sender, e.Column, 3, BatchQty)
        Catch ex As Exception

        End Try
    End Sub

End Class