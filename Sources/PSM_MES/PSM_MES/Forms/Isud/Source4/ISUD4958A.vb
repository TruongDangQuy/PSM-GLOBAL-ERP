Public Class ISUD4958A

#Region "Variable"
    Private wJOB As Integer

    Private W4958 As New T4958_AREA
    Private L4958 As New T4958_AREA


    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"
    Public Function Link_ISUD4958A(job As Integer, PackingBatch As String, DatePacking As String, cdSeason As String, CustomerCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        PackingBatch = PackingBatch
        D4958.PackingBatch = PackingBatch
        D4958.DatePacking = DatePacking
        D4958.cdSeason = cdSeason
        D4958.CustomerCode = CustomerCode

        wJOB = job : L4958 = D4958

        Link_ISUD4958A = False
        Try

            Select Case job
                Case 1

                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4958A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Replacement PROCESSING"))
        End Try

    End Function

    Public Function Link_ISUD4958A_SLNO(job As Integer, ProductInBoundNo As String, ProductInBoundSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG


        D4958.ProductInBoundNo = ProductInBoundNo
        D4958.ProductInBoundSeq = ProductInBoundSeq

        If READ_PFK2651(ProductInBoundNo, ProductInBoundSeq) Then

            Call READ_PFK1312(D2651.OrderNo, D2651.OrderNoSeq)
            D4958.OrderNo = D1312.OrderNo
            D4958.OrderNoSeq = D1312.OrderNoSeq

            txt_OrderNo.Data = D1312.OrderNo
            txt_OrderNoSeq.Data = D1312.OrderNoSeq

            txt_PONO.Data = D1312.PONO
            If txt_CustomerCode.Code <> "000001" Then txt_PKONO.Data = D1312.PONO

            txt_Barcode.Data = D1312.SLNo
            txt_CustomerCode.Code = D2651.CustomerCode
            Call READ_PFK7101(D2651.CustomerCode)
            txt_CustomerCode.Data = D7101.CustomerName

            Call READ_PFK7106(D1312.ShoesCode)
            Call READ_PFK7171(ListCode("Season"), D7106.cdSeason)

            txt_cdSeason.Data = D7171.BasicName
            txt_cdSeason.Code = D7171.BasicCode

            Call READ_PFK7106(D1312.ShoesCode)
            txt_Line.Data = D7106.Line
            txt_Article.Data = D7106.Article
            txt_ColorCode.Data = D7106.ColorCode
            txt_ColorName.Data = D7106.ColorName
            txt_MCODE.Data = D7106.MCODE
            txt_MCODENAME.Data = D7106.MCODEName

            txt_ProductInBoundNo.Data = ProductInBoundNo
            txt_ProductInBoundSeq.Data = ProductInBoundSeq


        End If


            wJOB = job : L4958 = D4958

            Link_ISUD4958A_SLNO = False
            Try

                Select Case job
                    Case 1

                    Case Else
                        txt_Barcode.Enabled = True
                End Select

                formA = False
                Me.ShowDialog()

                Link_ISUD4958A_SLNO = isudCHK

            Catch ex As Exception
                Call MsgBoxP("61", WordConv("Replacement PROCESSING"))
            End Try

    End Function

    Public Function Link_ISUD4958A_SLNO_GX(job As Integer, ProductInBoundNo As String, ProductInBoundSeq As String, FactOrderNo As String, FactOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D4958.FactOrderNo = FactOrderNo
        D4958.FactOrderSeq = FactOrderSeq

        D4958.ProductInBoundNo = ProductInBoundNo
        D4958.ProductInBoundSeq = ProductInBoundSeq

        'If READ_PFK3452(FactOrderNo, FactOrderSeq) = False Then Exit Function

        If READ_PFK2651(ProductInBoundNo, ProductInBoundSeq) Then

            Call READ_PFK1312(D2651.OrderNo, D2651.OrderNoSeq)
            D4958.OrderNo = D1312.OrderNo
            D4958.OrderNoSeq = D1312.OrderNoSeq

            txt_OrderNo.Data = D1312.OrderNo
            txt_OrderNoSeq.Data = D1312.OrderNoSeq

            txt_PONO.Data = D1312.PONO
            txt_PKONO.Data = D3452.PKO

            txt_Barcode.Data = D1312.SLNo
            txt_CustomerCode.Code = D2651.CustomerCode
            Call READ_PFK7101(D2651.CustomerCode)
            txt_CustomerCode.Data = D7101.CustomerName

            Call READ_PFK7106(D1312.ShoesCode)
            Call READ_PFK7171(ListCode("Season"), D7106.cdSeason)

            txt_cdSeason.Data = D7171.BasicName
            txt_cdSeason.Code = D7171.BasicCode

            Call READ_PFK7106(D1312.ShoesCode)
            txt_Line.Data = D7106.Line
            txt_Article.Data = D7106.Article
            txt_ColorCode.Data = D7106.ColorCode
            txt_ColorName.Data = D7106.ColorName
            txt_MCODE.Data = D7106.MCODE
            txt_MCODENAME.Data = D7106.MCODEName

            txt_ProductInBoundNo.Data = ProductInBoundNo
            txt_ProductInBoundSeq.Data = ProductInBoundSeq

            txt_FactOrderNo.Data = FactOrderNo
            txt_FactOrderSeq.Data = FactOrderSeq

        End If


        wJOB = job : L4958 = D4958

        Link_ISUD4958A_SLNO_GX = False
        Try

            Select Case job
                Case 1

                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4958A_SLNO_GX = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Replacement PROCESSING"))
        End Try

    End Function
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        Control.CheckForIllegalCrossThreadCalls = False
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1, 5
                Me.Text = Me.Text & " - INSERT"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Show()

                KEY_COUNT()

                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                Call DATA_SEARCH_HEAD()

                Application.DoEvents()

                txt_DatePacking.Data = Pub.DAT
                txt_DatePacking.Code = Pub.DAT

                cmd_DEL.Visible = False

                Setfocus(txt_cdSeason)

                cmd_OK.Visible = True
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call DATA_SEARCH_HEAD()

                cmd_DEL.Visible = False
                cmd_OK.Visible = False
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call DATA_SEARCH_HEAD()

                cmd_OK.Visible = False
                cmd_DEL.Visible = False
            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_VS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Call DATA_SEARCH_HEAD()

                cmd_DEL.Visible = True

                cmd_OK.Visible = False
            Case 11
                Me.Text = Me.Text & " - INTERFACE"

                txt_DatePacking.Data = FSDate(System_Date_8())
                txt_DatePacking.Code = System_Date_8()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

                If DATA_SEARCH_HEAD_INSERT() = True Then

                    Call DATA_SEARCH_VS0()
                    Call DATA_SEARCH_VS1()
                    Call DATA_SEARCH_VS2()

                    Call KEY_COUNT()

                    txt_Barcode.TextEnabled = True
                    txt_Barcode.Enabled = True

                End If
                cmd_OK.Visible = False
                cmd_DEL.Visible = False

        End Select

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False
        DATA_SEARCH_HEAD_INSERT = True

        If READ_PFK7171(ListCode("Season"), D4958.cdSeason) = True Then
            txt_cdSeason.Data = D7171.BasicName
            txt_cdSeason.Code = D7171.BasicCode
        End If

        If READ_PFK7101(D4958.CustomerCode) = True Then
            txt_CustomerCode.Data = D7171.BasicName
            txt_CustomerCode.Code = D7171.BasicCode
        End If

        If READ_PFK7210(txt_CartonCode.Code) = True Then
            txt_CartonCode.Data = D7210.CartonType
            txt_CartonCode.Code = D7210.CartonCode
        End If

    End Function

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try

            DS1 = PrcDS("USP_ISUD4958B_SEARCH_HEAD", cn, L4958.PackingBatch)


            If GetDsRc(DS1) = 0 Then
                If READ_PFK7171(ListCode("Season"), D4958.cdSeason) = True Then
                    txt_cdSeason.Data = D7171.BasicName
                    txt_cdSeason.Code = D7171.BasicCode
                End If

                If READ_PFK7101(D4958.CustomerCode) = True Then
                    txt_CustomerCode.Data = D7171.BasicName
                    txt_CustomerCode.Code = D7171.BasicCode
                End If

                If READ_PFK7210(txt_CartonCode.Code) = True Then
                    txt_CartonCode.Data = D7210.CartonType
                    txt_CartonCode.Code = D7210.CartonCode
                End If

                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            L4958.JobCard = GetDsData(DS1, 0, "JobCard")

            If READ_PFK7210(txt_CartonCode.Code) = True Then
                txt_CartonCode.Data = D7210.CartonType
                txt_CartonCode.Code = D7210.CartonCode

                txt_CBM.Data = D7210.CBM
                txt_CTHeight.Data = D7210.CTHeight
                txt_CTWidth.Data = D7210.CTWidth
                txt_CTNetWeight.Data = D7210.CTNetWeight
                txt_CTLength.Data = D7210.CTLength

            End If

            DATA_SEARCH_HEAD = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_JOBCARD() As Boolean
        DATA_SEARCH_JOBCARD = False
        Try

            DS1 = PrcDS("USP_ISUD4958B_SEARCH_HEAD_JOBCARD", cn, txt_JobCard.Data)


            If GetDsRc(DS1) = 0 Then

                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            L4958.JobCard = GetDsData(DS1, 0, "JobCard")

            DATA_SEARCH_JOBCARD = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH_CARTONCODE() As Boolean
        DATA_SEARCH_CARTONCODE = False
        Try

            If READ_PFK7210(txt_CartonCode.Code) = True Then
                txt_CartonCode.Data = D7210.CartonType
                txt_CartonCode.Code = D7210.CartonCode

                txt_CBM.Data = D7210.CBM
                txt_CTHeight.Data = D7210.CTHeight
                txt_CTWidth.Data = D7210.CTWidth
                txt_CTNetWeight.Data = D7210.CTNetWeight
                txt_CTLength.Data = D7210.CTLength

            End If

            DATA_SEARCH_CARTONCODE = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        If L4958.OrderNo = "" Then Exit Function
        Try
            DS1 = PrcDS("USP_ISUD4958A_SEARCH_VS1_F1", cn, L4958.OrderNo, L4958.OrderNoSeq)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD4958A_SEARCH_VS1_F1", "vS1")

                vS1.Enabled = True

                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD4958A_SEARCH_VS1_F1", "Vs1")

            Call VsSizeRangeNew_one(vS1, "USP_VS_SIZERANGE_ORDERBASE", getColumIndex(vS1, "QtyTotal") + 1, getData(vS1, getColumIndex(vS1, "OrderNo"), 0), getData(vS1, getColumIndex(vS1, "OrderNoSeq"), 0))

            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        Dim PKONO As String

        PKONO = getData(vS0, getColumIndex(vS0, "PKONO"), vS0.ActiveSheet.ActiveRowIndex)

        Try
            If chk_Packing.Checked = False Then
                DS1 = PrcDS("USP_ISUD4958A_SEARCH_VS2", cn, L4958.PackingBatch, PKONO)


                If GetDsRc(DS1) = 0 Then
                    SPR_SET(vS2, , , , OperationMode.Normal)
                    SPR_PRO(vS2, DS1, "USP_ISUD4958A_SEARCH_vS2", "vS2")

                    vS2.ActiveSheet.RowCount = 1
                    vS2.Enabled = True

                    Exit Function
                End If

                SPR_SET(vS2, , , , OperationMode.Normal)
                SPR_PRO(vS2, DS1, "USP_ISUD4958A_SEARCH_vS2", "vS2")

                DATA_SEARCH_VS2 = True
            Else
                DS1 = PrcDS("USP_ISUD4958A_SEARCH_VS2_GROUP", cn, L4958.PackingBatch, PKONO)


                If GetDsRc(DS1) = 0 Then
                    SPR_SET(vS2, , , , OperationMode.Normal)
                    SPR_PRO(vS2, DS1, "USP_ISUD4958A_SEARCH_VS2_GROUP", "vS2")

                    vS2.ActiveSheet.RowCount = 1
                    vS2.Enabled = True

                    Exit Function
                End If

                SPR_SET(vS2, , , , OperationMode.Normal)
                SPR_PRO(vS2, DS1, "USP_ISUD4958A_SEARCH_VS2_GROUP", "vS2")

                DATA_SEARCH_VS2 = True
            End If
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_vS2")
        End Try
    End Function


    Private Function DATA_SEARCH_VS0() As Boolean
        DATA_SEARCH_VS0 = False

        Try
            DS1 = PrcDS("USP_ISUD4958A_SEARCH_VS0", cn, L4958.PackingBatch)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(VS0, , , , OperationMode.Normal)
                SPR_PRO(VS0, DS1, "USP_ISUD4958A_SEARCH_VS0", "VS0")

                VS0.ActiveSheet.RowCount = 1
                VS0.Enabled = True

                Exit Function
            End If

            SPR_SET(VS0, , , , OperationMode.Normal)
            SPR_PRO(vS0, DS1, "USP_ISUD4958A_SEARCH_VS0", "VS0")

            DATA_SEARCH_VS0 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS0")
        End Try
    End Function
#End Region

#Region "Function"


    Private Sub DATA_DELETE()
        Dim i As Integer

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "CheckDsel"), i) = "1" Then
                    DATA_LINE_DELETE(i)
                End If
            Next

            Call DATA_SEARCH_VS0()
            Call DATA_SEARCH_VS1()
            Call DATA_SEARCH_VS2()

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)
        Try

            If READ_PFK4958(getData(vS1, getColumIndex(vS1, "Autokey"), xrow)) = True Then
                W4958 = D4958

                If DELETE_PFK4958(W4958) = True Then
                    isudCHK = True
                End If

            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
            txt_DatePacking.Data = FSDate(L4958.DatePacking)
            txt_DatePacking.Code = FormatCut(L4958.DatePacking)

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargePacking.Data = D7411.Name
                txt_InchargePacking.Code = D7411.IDNO
            End If

            vS1.InsChk = False
            RemoveHandler txt_Barcode.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub
    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        YRNO = System_Date_8()

        L4958.PackingBatch = YRNO

        Try
            SQL = "SELECT MAX(CAST(ISNULL(K4958_PackingBatch, 0) AS DECIMAL)) AS MAX_MCODE FROM PFK4958 "
            SQL = SQL & " WHERE LEFT(K4958_PackingBatch,2) = '" & YRNO & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W4958.PackingBatch = YRNO & "00000001"
            Else
                W4958.PackingBatch = Format(CIntp(rd!MAX_MCODE + 1), "0000000000")
            End If

            rd.Close()

            txt_PackingBatch.Data = W4958.PackingBatch
            L4958.PackingBatch = W4958.PackingBatch

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub KEY_COUNT_CUS()
        Dim YRNO As String
        Dim LenYRNO As String

        Call READ_PFK7101(txt_CustomerCode.Code)

        YRNO = txt_cdSeason.Data & D7101.CustomerNameSimply
        LenYRNO = Len(YRNO)

        Try
            SQL = "SELECT MAX(CAST(ISNULL(K4958_PackingCusBatch, 0) AS DECIMAL)) AS MAX_MCODE FROM PFK4958 "
            SQL = SQL & " WHERE LEFT(K4958_PackingCusBatch," & LenYRNO & ") = '" & YRNO & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W4958.PackingCusBatch = YRNO & "000001"
            Else
                W4958.PackingCusBatch = Format(CIntp(rd!MAX_MCODE + 1), "0000000")
            End If

            rd.Close()

            txt_PackingCusBatch.Data = W4958.PackingCusBatch
            L4958.PackingCusBatch = W4958.PackingCusBatch

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_CARTION_NO()
        Dim YRNO As String
        Dim LenYRNO As String

        Try
            SQL = "SELECT MAX(CAST(ISNULL(K4958_CartonNo, 0) AS DECIMAL)) AS MAX_MCODE FROM PFK4958 "
            SQL = SQL & " WHERE K4958_PackingCusBatch = '" & txt_PackingCusBatch.Data & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W4958.CartonNo = 1
            Else
                W4958.CartonNo = Format(CIntp(rd!MAX_MCODE + 1))
            End If

            rd.Close()

            L4958.CartonNo = W4958.CartonNo

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
#End Region

#Region "Event"
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Dim colstart As Integer
        colstart = getColumIndex(vS1, "QtyTotal") + 1
        Dim SumQty As Decimal

        W4958.SizeQty01 = CDblp(getData(vS1, colstart, 3))
        W4958.SizeQty02 = CDblp(getData(vS1, colstart + 1, 3))
        W4958.SizeQty03 = CDblp(getData(vS1, colstart + 2, 3))
        W4958.SizeQty04 = CDblp(getData(vS1, colstart + 3, 3))
        W4958.SizeQty05 = CDblp(getData(vS1, colstart + 4, 3))
        W4958.SizeQty06 = CDblp(getData(vS1, colstart + 5, 3))
        W4958.SizeQty07 = CDblp(getData(vS1, colstart + 6, 3))
        W4958.SizeQty08 = CDblp(getData(vS1, colstart + 7, 3))
        W4958.SizeQty09 = CDblp(getData(vS1, colstart + 8, 3))
        W4958.SizeQty10 = CDblp(getData(vS1, colstart + 9, 3))
        W4958.SizeQty11 = CDblp(getData(vS1, colstart + 10, 3))
        W4958.SizeQty12 = CDblp(getData(vS1, colstart + 11, 3))
        W4958.SizeQty13 = CDblp(getData(vS1, colstart + 12, 3))
        W4958.SizeQty14 = CDblp(getData(vS1, colstart + 13, 3))
        W4958.SizeQty15 = CDblp(getData(vS1, colstart + 14, 3))
        W4958.SizeQty16 = CDblp(getData(vS1, colstart + 15, 3))
        W4958.SizeQty17 = CDblp(getData(vS1, colstart + 16, 3))
        W4958.SizeQty18 = CDblp(getData(vS1, colstart + 17, 3))
        W4958.SizeQty19 = CDblp(getData(vS1, colstart + 18, 3))
        W4958.SizeQty20 = CDblp(getData(vS1, colstart + 19, 3))
        W4958.SizeQty21 = CDblp(getData(vS1, colstart + 20, 3))
        W4958.SizeQty22 = CDblp(getData(vS1, colstart + 21, 3))
        W4958.SizeQty23 = CDblp(getData(vS1, colstart + 22, 3))
        W4958.SizeQty24 = CDblp(getData(vS1, colstart + 23, 3))
        W4958.SizeQty25 = CDblp(getData(vS1, colstart + 24, 3))
        W4958.SizeQty26 = CDblp(getData(vS1, colstart + 25, 3))
        W4958.SizeQty27 = CDblp(getData(vS1, colstart + 26, 3))
        W4958.SizeQty28 = CDblp(getData(vS1, colstart + 27, 3))
        W4958.SizeQty29 = CDblp(getData(vS1, colstart + 28, 3))
        W4958.SizeQty30 = CDblp(getData(vS1, colstart + 29, 3))

        SumQty = W4958.SizeQty01 +
                  W4958.SizeQty02 + _
                  W4958.SizeQty03 + _
                  W4958.SizeQty04 + _
                  W4958.SizeQty05 + _
                  W4958.SizeQty06 + _
                  W4958.SizeQty07 + _
                  W4958.SizeQty08 + _
                  W4958.SizeQty09 + _
                  W4958.SizeQty10 + _
                  W4958.SizeQty11 + _
                  W4958.SizeQty12 + _
                  W4958.SizeQty13 + _
                  W4958.SizeQty14 + _
                  W4958.SizeQty15 + _
                  W4958.SizeQty16 + _
                  W4958.SizeQty17 + _
                  W4958.SizeQty18 + _
                  W4958.SizeQty19 + _
                  W4958.SizeQty20 + _
                  W4958.SizeQty21 + _
                  W4958.SizeQty22 + _
                  W4958.SizeQty23 + _
                  W4958.SizeQty24 + _
                  W4958.SizeQty25 + _
                  W4958.SizeQty26 + _
                  W4958.SizeQty27 + _
                  W4958.SizeQty28 + _
                  W4958.SizeQty29 + _
                  W4958.SizeQty30

        If SumQty = 0 Then MsgBoxP("Quantity = 0 !") : Exit Function
        If txt_cdSeason.Code = "" Then MsgBoxP("Season !") : Exit Function
        If txt_CustomerCode.Code = "" Then MsgBoxP("CustomerCode !") : Exit Function

        If txt_PKONO.Data = "" Then MsgBoxP("PKONO !") : Exit Function

        If txt_PONO.Data = "" Then MsgBoxP("PONO !") : Exit Function
        If txt_CartonCode.Code = "" Then MsgBoxP("CartonCode !") : Exit Function

        Data_Check = True
    End Function
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            If Data_Check() = False Then Exit Sub


            Dim i As Integer
            Dim colstart As Integer
            colstart = getColumIndex(vS1, "QtyTotal") + 1

            Dim SumQty As Decimal

            If chk_New.Checked = True Then
                Call KEY_COUNT()
                Call KEY_COUNT_CUS()

                For i = 0 To txt_CartonCnt.Value - 1
                    Call KEY_COUNT_CARTION_NO()

                    W4958.CartonCode = txt_CartonCode.Code
                    W4958.DatePacking = Pub.DAT
                    W4958.CustomerCode = txt_CustomerCode.Code
                    W4958.OrderNo = txt_OrderNo.Data
                    W4958.OrderNoSeq = txt_OrderNoSeq.Data
                    W4958.JobCard = txt_JobCard.Data
                    W4958.SizeGroup = txt_SizeGroup.Data

                    W4958.ProductInBoundNo = txt_ProductInBoundNo.Data
                    W4958.ProductInBoundSeq = txt_ProductInBoundSeq.Data

                    W4958.FactOrderNo = txt_FactOrderNo.Data
                    W4958.FactOrderSeq = txt_FactOrderSeq.Data

                    W4958.SizeQty01 = CDblp(getData(vS1, colstart, 3))
                    W4958.SizeQty02 = CDblp(getData(vS1, colstart + 1, 3))
                    W4958.SizeQty03 = CDblp(getData(vS1, colstart + 2, 3))
                    W4958.SizeQty04 = CDblp(getData(vS1, colstart + 3, 3))
                    W4958.SizeQty05 = CDblp(getData(vS1, colstart + 4, 3))
                    W4958.SizeQty06 = CDblp(getData(vS1, colstart + 5, 3))
                    W4958.SizeQty07 = CDblp(getData(vS1, colstart + 6, 3))
                    W4958.SizeQty08 = CDblp(getData(vS1, colstart + 7, 3))
                    W4958.SizeQty09 = CDblp(getData(vS1, colstart + 8, 3))
                    W4958.SizeQty10 = CDblp(getData(vS1, colstart + 9, 3))
                    W4958.SizeQty11 = CDblp(getData(vS1, colstart + 10, 3))
                    W4958.SizeQty12 = CDblp(getData(vS1, colstart + 11, 3))
                    W4958.SizeQty13 = CDblp(getData(vS1, colstart + 12, 3))
                    W4958.SizeQty14 = CDblp(getData(vS1, colstart + 13, 3))
                    W4958.SizeQty15 = CDblp(getData(vS1, colstart + 14, 3))
                    W4958.SizeQty16 = CDblp(getData(vS1, colstart + 15, 3))
                    W4958.SizeQty17 = CDblp(getData(vS1, colstart + 16, 3))
                    W4958.SizeQty18 = CDblp(getData(vS1, colstart + 17, 3))
                    W4958.SizeQty19 = CDblp(getData(vS1, colstart + 18, 3))
                    W4958.SizeQty20 = CDblp(getData(vS1, colstart + 19, 3))
                    W4958.SizeQty21 = CDblp(getData(vS1, colstart + 20, 3))
                    W4958.SizeQty22 = CDblp(getData(vS1, colstart + 21, 3))
                    W4958.SizeQty23 = CDblp(getData(vS1, colstart + 22, 3))
                    W4958.SizeQty24 = CDblp(getData(vS1, colstart + 23, 3))
                    W4958.SizeQty25 = CDblp(getData(vS1, colstart + 24, 3))
                    W4958.SizeQty26 = CDblp(getData(vS1, colstart + 25, 3))
                    W4958.SizeQty27 = CDblp(getData(vS1, colstart + 26, 3))
                    W4958.SizeQty28 = CDblp(getData(vS1, colstart + 27, 3))
                    W4958.SizeQty29 = CDblp(getData(vS1, colstart + 28, 3))
                    W4958.SizeQty30 = CDblp(getData(vS1, colstart + 29, 3))

                    SumQty = W4958.SizeQty01 +
                    W4958.SizeQty02 + _
                    W4958.SizeQty03 + _
                    W4958.SizeQty04 + _
                    W4958.SizeQty05 + _
                    W4958.SizeQty06 + _
                    W4958.SizeQty07 + _
                    W4958.SizeQty08 + _
                    W4958.SizeQty09 + _
                    W4958.SizeQty10 + _
                    W4958.SizeQty11 + _
                    W4958.SizeQty12 + _
                    W4958.SizeQty13 + _
                    W4958.SizeQty14 + _
                    W4958.SizeQty15 + _
                    W4958.SizeQty16 + _
                    W4958.SizeQty17 + _
                    W4958.SizeQty18 + _
                    W4958.SizeQty19 + _
                    W4958.SizeQty20 + _
                    W4958.SizeQty21 + _
                    W4958.SizeQty22 + _
                    W4958.SizeQty23 + _
                    W4958.SizeQty24 + _
                    W4958.SizeQty25 + _
                    W4958.SizeQty26 + _
                    W4958.SizeQty27 + _
                    W4958.SizeQty28 + _
                    W4958.SizeQty29 + _
                    W4958.SizeQty30

                    W4958.PackingCMB = CDecp(txt_CBM.Data)
                    W4958.PackingGW = CDecp(txt_CTGrossWeight.Data)
                    W4958.PackingNW = CDecp(txt_CTNetWeight.Data)

                    W4958.QtyPrs = SumQty
                    SumQty = 0

                    W4958.JCPREFIX1 = txt_JCPREFIX1.Data
                    W4958.JCPREFIX2 = txt_JCPREFIX2.Data
                    W4958.PONO = txt_PONO.Data
                    W4958.PKONO = txt_PKONO.Data

                    W4958.cdSeason = txt_cdSeason.Code
                    W4958.seSeason = ListCode("Season")

                    W4958.cdPackingType = txt_cdPackingType.Code
                    W4958.sePackingType = ListCode("PackingType")

                    W4958.DateInsert = Pub.DAT
                    W4958.InchargeInsert = Pub.SAW


                    Call WRITE_PFK4958(W4958)
                Next

                chk_New.Checked = False

            Else

                For i = 0 To txt_CartonCnt.Value - 1
                    Call KEY_COUNT_CARTION_NO()

                    W4958.CartonCode = txt_CartonCode.Code
                    W4958.DatePacking = Pub.DAT
                    W4958.CustomerCode = txt_CustomerCode.Code
                    W4958.OrderNo = txt_OrderNo.Data
                    W4958.OrderNoSeq = txt_OrderNoSeq.Data
                    W4958.JobCard = txt_JobCard.Data
                    W4958.SizeGroup = txt_SizeGroup.Data

                    W4958.ProductInBoundNo = txt_ProductInBoundNo.Data
                    W4958.ProductInBoundSeq = txt_ProductInBoundSeq.Data

                    W4958.FactOrderNo = txt_FactOrderNo.Data
                    W4958.FactOrderSeq = txt_FactOrderSeq.Data

                    W4958.SizeQty01 = CDblp(getData(vS1, colstart, 3))
                    W4958.SizeQty02 = CDblp(getData(vS1, colstart + 1, 3))
                    W4958.SizeQty03 = CDblp(getData(vS1, colstart + 2, 3))
                    W4958.SizeQty04 = CDblp(getData(vS1, colstart + 3, 3))
                    W4958.SizeQty05 = CDblp(getData(vS1, colstart + 4, 3))
                    W4958.SizeQty06 = CDblp(getData(vS1, colstart + 5, 3))
                    W4958.SizeQty07 = CDblp(getData(vS1, colstart + 6, 3))
                    W4958.SizeQty08 = CDblp(getData(vS1, colstart + 7, 3))
                    W4958.SizeQty09 = CDblp(getData(vS1, colstart + 8, 3))
                    W4958.SizeQty10 = CDblp(getData(vS1, colstart + 9, 3))
                    W4958.SizeQty11 = CDblp(getData(vS1, colstart + 10, 3))
                    W4958.SizeQty12 = CDblp(getData(vS1, colstart + 11, 3))
                    W4958.SizeQty13 = CDblp(getData(vS1, colstart + 12, 3))
                    W4958.SizeQty14 = CDblp(getData(vS1, colstart + 13, 3))
                    W4958.SizeQty15 = CDblp(getData(vS1, colstart + 14, 3))
                    W4958.SizeQty16 = CDblp(getData(vS1, colstart + 15, 3))
                    W4958.SizeQty17 = CDblp(getData(vS1, colstart + 16, 3))
                    W4958.SizeQty18 = CDblp(getData(vS1, colstart + 17, 3))
                    W4958.SizeQty19 = CDblp(getData(vS1, colstart + 18, 3))
                    W4958.SizeQty20 = CDblp(getData(vS1, colstart + 19, 3))
                    W4958.SizeQty21 = CDblp(getData(vS1, colstart + 20, 3))
                    W4958.SizeQty22 = CDblp(getData(vS1, colstart + 21, 3))
                    W4958.SizeQty23 = CDblp(getData(vS1, colstart + 22, 3))
                    W4958.SizeQty24 = CDblp(getData(vS1, colstart + 23, 3))
                    W4958.SizeQty25 = CDblp(getData(vS1, colstart + 24, 3))
                    W4958.SizeQty26 = CDblp(getData(vS1, colstart + 25, 3))
                    W4958.SizeQty27 = CDblp(getData(vS1, colstart + 26, 3))
                    W4958.SizeQty28 = CDblp(getData(vS1, colstart + 27, 3))
                    W4958.SizeQty29 = CDblp(getData(vS1, colstart + 28, 3))
                    W4958.SizeQty30 = CDblp(getData(vS1, colstart + 29, 3))

                    SumQty = W4958.SizeQty01 +
                  W4958.SizeQty02 + _
                  W4958.SizeQty03 + _
                  W4958.SizeQty04 + _
                  W4958.SizeQty05 + _
                  W4958.SizeQty06 + _
                  W4958.SizeQty07 + _
                  W4958.SizeQty08 + _
                  W4958.SizeQty09 + _
                  W4958.SizeQty10 + _
                  W4958.SizeQty11 + _
                  W4958.SizeQty12 + _
                  W4958.SizeQty13 + _
                  W4958.SizeQty14 + _
                  W4958.SizeQty15 + _
                  W4958.SizeQty16 + _
                  W4958.SizeQty17 + _
                  W4958.SizeQty18 + _
                  W4958.SizeQty19 + _
                  W4958.SizeQty20 + _
                  W4958.SizeQty21 + _
                  W4958.SizeQty22 + _
                  W4958.SizeQty23 + _
                  W4958.SizeQty24 + _
                  W4958.SizeQty25 + _
                  W4958.SizeQty26 + _
                  W4958.SizeQty27 + _
                  W4958.SizeQty28 + _
                  W4958.SizeQty29 + _
                  W4958.SizeQty30


                    W4958.PackingCMB = CDecp(txt_CBM.Data)
                    W4958.PackingGW = CDecp(txt_CTGrossWeight.Data)
                    W4958.PackingNW = CDecp(txt_CTNetWeight.Data)

                    W4958.QtyPrs = SumQty
                    SumQty = 0

                    W4958.JCPREFIX1 = txt_JCPREFIX1.Data
                    W4958.JCPREFIX2 = txt_JCPREFIX2.Data
                    W4958.PONO = txt_PONO.Data
                    W4958.PKONO = txt_PKONO.Data

                    W4958.cdSeason = txt_cdSeason.Code
                    W4958.seSeason = ListCode("Season")

                    W4958.cdPackingType = txt_cdPackingType.Code
                    W4958.sePackingType = ListCode("PackingType")

                    W4958.DateInsert = Pub.DAT
                    W4958.InchargeInsert = Pub.SAW

                    Call WRITE_PFK4958(W4958)
                Next

            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete all roll?", vbYesNo)

        If str <> vbYes Then Exit Sub


        Call DATA_DELETE()
    End Sub


    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub
        Dim QtyOutBound As Integer
        Dim Barcode As String

        If READ_PFK4958(FormatCut(getData(vS2, getColumIndex(vS2, "KEY_Autokey"), xROW))) = True Then
            W4958 = D4958

            Barcode = W4958.SlNoD
        End If


    End Sub
    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown
        Dim xCol As Long
        Dim xRow As Long

        xCol = vS2.ActiveSheet.ActiveColumnIndex
        xRow = vS2.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Insert
                If getData(vS2, getColumIndex(vS2, "KEY_PackingBatch"), vS2.ActiveSheet.RowCount - 1) <> "" Then
                    vS2.ActiveSheet.RowCount += 1
                    vS2.ActiveSheet.ActiveRowIndex = vS2.ActiveSheet.RowCount - 1
                End If

            Case Keys.Delete
                If getData(vS2, getColumIndex(vS2, "Batchno"), xRow) = "" Then
                    Call SPR_DEL(vS2, 0, xRow)
                    Exit Sub
                End If

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)
                If Msg_Result <> vbYes Then Exit Sub

                Call DATA_LINE_DELETE(xRow)
                Call SPR_DEL(vS2, 0, xRow)

                vS2.Focus()

            Case Keys.Enter
                Select Case xCol
                    Case getColumIndex(vS2, "QtyOutBound")
                        Call vSChange(xRow)

                End Select

        End Select


    End Sub


    Private Function CheckBalance() As Boolean
        CheckBalance = False
        Try
            Dim StrMsg As String

            CheckBalance = True
        Catch ex As Exception

        End Try

    End Function
    Private CntS As Integer
    Private Sub txt_GreyFullNo_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_cdSeason.Code = "" Then MsgBoxP("Season Pls!", vbInformation) : Setfocus(txt_cdSeason) : Exit Sub

            txt_Barcode.Code = FormatCut(txt_Barcode.Data)
            txt_Barcode.Data = FormatCut(txt_Barcode.Code)

            If READ_PFK4010_SLNO_SEASON(txt_cdSeason.Code, txt_Barcode.Code) = False Then txt_Barcode.Code = "" : txt_Barcode.Data = "" : Setfocus(txt_Barcode) : Exit Sub

            L4958.SlNo = txt_Barcode.Code
            L4958.SlNoD = txt_Barcode.Code
            L4958.JobCard = D4010.JobCard

            Call DATA_SEARCH_HEAD()

            Call DATA_SEARCH_VS0()
            Call DATA_SEARCH_VS1()
            Call DATA_SEARCH_VS2()

        End If



    End Sub
    Private Sub vS0_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS0.CellDoubleClick
        If e.ColumnHeader = False Then
            Call DATA_SEARCH_VS2()
        End If
    End Sub
#End Region



    Private Sub cmd_Refresh_Click(sender As Object, e As EventArgs) Handles cmd_Refresh.Click
        Call DATA_SEARCH_VS0()
        Call DATA_SEARCH_VS1()
        Call DATA_SEARCH_VS2()
    End Sub

   
    Private Sub txt_CartonCode_Load(sender As Object, e As EventArgs) Handles txt_CartonCode.btnTitleClick
        Try
            If HLP7210A.Link_HLP7210A(txt_CustomerCode.Code, "") = False Then Exit Sub

            txt_CartonCode.Code = D7210.CartonCode

            If READ_PFK7210(txt_CartonCode.Code) = True Then
                txt_CartonCode.Data = D7210.CartonType
                txt_CartonCode.Code = D7210.CartonCode

                txt_CBM.Data = D7210.CBM
                txt_CTHeight.Data = D7210.CTHeight
                txt_CTWidth.Data = D7210.CTWidth
                txt_CTNetWeight.Data = D7210.CTNetWeight
                txt_CTGrossWeight.Data = D7210.CTNetWeight

                txt_CTLength.Data = D7210.CTLength

            End If

        Catch ex As Exception

        End Try


    End Sub
End Class