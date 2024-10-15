Public Class ISUD7231B

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7231 As T7231_AREA
    Private L7231 As T7231_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7231B(job As Integer, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean

        D7231.MaterialCode = MaterialCode

        wJOB = job : L7231 = D7231

        Link_ISUD7231B = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7231(L7231.MaterialCode) = True Then
                    If D7231.StatusMaterial = "3" Then Block_1.Enabled = False
                    If D7231.StatusMaterial = "2" Then Block_1.Enabled = False
                    If D7231.StatusMaterial = "4" Then Block_1.Enabled = False
                    If D7231.StatusMaterial = "5" Then Block_1.Enabled = False
                    If D7231.StatusMaterial = "6" Then Block_1.Enabled = False
                End If

                If READ_PFK7231(L7231.MaterialCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7231B = isudCHK

    End Function

    Public Function Link_ISUD7231B_AUTO(job As Integer, ByRef Value As String, MaterialCode As String, MaterialName As String, Optional ByVal TAG As String = "") As Boolean

        D7231.MaterialCode = MaterialCode

        wJOB = job : L7231 = D7231

        Link_ISUD7231B_AUTO = False

        Select Case job
            Case 1, 11
            Case Else
                If READ_PFK7231(L7231.MaterialCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        txt_MaterialPName.Data = MaterialName

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Value = W7231.MaterialCode
        Link_ISUD7231B_AUTO = isudCHK

    End Function

#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        Me.Form_KeyDown()

        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                'tst_iSave2.Visible = False

                Call KEY_COUNT()

                Setfocus(txt_cdLargeGroupMaterial)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                'tst_iSave2.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_MaterialCode.Enabled = False
                txt_cdLargeGroupMaterial.Enabled = True
                txt_cdSemiGroupMaterial.Enabled = True
                txt_cdDetailGroupMaterial.Enabled = True
                txt_Width.Enabled = True
                txt_Height.Enabled = True
                txt_Sizename.Enabled = True

                tst_iDelete.Visible = False
                'tst_iSave2.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCH01()

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                tst_iDelete.Visible = True
                'tst_iSave2.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH01()

            Case 5
                Me.Text = Me.Text & " - COPY"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_MaterialCode.Enabled = False

                tst_iDelete.Visible = False
                'tst_iSave2.Visible = False

                Call DATA_SEARCH01()
                Call KEY_COUNT()

                wJOB = 1

                txt_cdUnitMaterial.Code = ""
                txt_cdUnitMaterial.Data = ""

            Case 11
                Me.Text = Me.Text & " - INSERT AUTO"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                'tst_iSave2.Visible = False

                Call KEY_COUNT()

            Case 91
                Me.Text = Me.Text & " - Approved"
                If CHK(5) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                txt_MaterialCode.Enabled = False

                tst_iDelete.Visible = False
                'tst_iSave2.Visible = True
                tst_iSave.Visible = True

                'tst_iSave2.Text = "NotApproved"
                tst_iSave.Text = "Pending2"

                Call DATA_SEARCH01()


            Case 92
                Me.Text = Me.Text & " - Approved"

                tst_iSave.Visible = True
                'tst_iSave2.Visible = True

                tst_iDelete.Visible = False
                txt_MaterialCode.Enabled = False

                'tst_iSave2.Text = "Pending1"
                tst_iSave.Text = "Approved"

                Call DATA_SEARCH01()

                If CHK(5) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7231_CLEAR()

        W7231 = D7231

        KEY_CHK = ""
        tst_iClose.Enabled = True
        tst_iSave.Enabled = True
        tst_iDelete.Enabled = True
        tst_iClose.Visible = True
        tst_iSave.Visible = True
        tst_iDelete.Visible = True

        txt_QtyBasic.Data = 0
        txt_DayEstimate.Data = 0
        txt_QtyMOQ.Data = 0
        txt_DayOpimum.Data = 0
        txt_ReOrderQty.Data = 0

        txt_QtyOptimum.Data = 0
        txt_MinInventory.Data = 0
        txt_MaxInventory.Data = 0
        txt_PriceMaterial.Data = 0
        txt_ExchangePrice.Data = 0
        txt_PriceVND.Data = 0
        txt_PriceUSD.Data = 0

    End Sub

    Private Sub FORM_INIT()

        txt_cdLargeGroupMaterial.Code = "014"

        If READ_PFK7171("040", "014") = True Then
            txt_cdLargeGroupMaterial.Data = D7171.BasicName
        End If

        txt_cdLargeGroupMaterial.Enabled = False

        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False
    End Sub

#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        If wJOB = 1 Then If READ_PFK7231_CHECKNAME(txt_MaterialName.Data, txt_MaterialPName.Data) Then MsgBoxP("Double Material,pls") : Setfocus(txt_MaterialPName) : Exit Function
        If FormatCut(txt_MaterialName.Data) = "" Then MsgBoxP("Material Name,pls") : Setfocus(txt_MaterialPName) : Exit Function

        Return DataCheck(Me, "PFK7231")
    End Function
    Private Sub DATA_MOVE()
        W7231.MaterialCode = txt_MaterialCode.Data
        W7231.DevelopmentCode = txt_DevelopmentCode.Code
        W7231.ImportCode = txt_ImportCode.Data
        W7231.AccountCode = txt_AccountCode.Data
        W7231.OtherCode1 = txt_OtherCode1.Data

        If FormatCut(W7231.DevelopmentCode) = "" Then W7231.DevelopmentCode = W7231.MaterialCode

        W7231.MaterialName = txt_MaterialName.Data
        W7231.MaterialPName = txt_MaterialPName.Data
        W7231.MaterialSimple = txt_MaterialSimple.Data

        W7231.MaterialForeign1 = txt_MaterialName.Data
        W7231.MaterialForeign2 = txt_MaterialForeign2.Data

        W7231.Width = txt_Width.Data
        W7231.Height = txt_Height.Data
        W7231.SizeName = txt_Sizename.Data

        W7231.SizeRangeTool = txt_SizeRangeTool.Code

        W7231.seLargeGroupMaterial = ListCode("LargeGroupMaterial")
        W7231.seSemiGroupMaterial = ListCode("SemiGroupMaterial")
        W7231.seDetailGroupMaterial = ListCode("DetailGroupMaterial")

        W7231.seUnitMaterial = ListCode("UnitMaterial")
        W7231.seUnitPacking = ListCode("UnitPacking")
        W7231.seUnitPrice = ListCode("UnitPrice")

        W7231.cdLargeGroupMaterial = txt_cdLargeGroupMaterial.Code
        W7231.cdSemiGroupMaterial = txt_cdSemiGroupMaterial.Code
        W7231.cdDetailGroupMaterial = txt_cdDetailGroupMaterial.Code

        W7231.cdUnitMaterial = txt_cdUnitMaterial.Code
        W7231.cdUnitPacking = txt_cdUnitPacking.Code
        W7231.cdUnitPrice = txt_cdUnitPrice.Code

        W7231.seTax1 = ListCode("Tax1")
        W7231.seTax2 = ListCode("Tax2")
        W7231.seTax3 = ListCode("Tax3")

        W7231.cdTax1 = txt_cdTax1.Code
        W7231.cdTax2 = txt_cdTax2.Code
        W7231.cdTax3 = txt_cdTax3.Code

        If READ_PFK7171(W7231.seTax1, W7231.cdTax1) = True Then W7231.PerTax1 = D7171.BasicName
        If READ_PFK7171(W7231.seTax2, W7231.cdTax2) = True Then W7231.PerTax2 = D7171.BasicName
        If READ_PFK7171(W7231.seTax3, W7231.cdTax3) = True Then W7231.PerTax3 = D7171.BasicName

        W7231.QtyBasic = CDecp(txt_QtyBasic.Data)
        W7231.QtyMOQ = CDecp(txt_QtyMOQ.Data)

        W7231.QtyOptimum = CDecp(txt_QtyOptimum.Data)
        W7231.DayEstimate = CDecp(txt_DayEstimate.Data)

        W7231.ReOrderQty = CDecp(txt_ReOrderQty.Data)
        W7231.MaxInventory = CDecp(txt_MaxInventory.Data)
        W7231.MinInventory = CDecp(txt_MinInventory.Data)

        W7231.PriceMaterial = CDecp(txt_PriceMaterial.Data)
        W7231.ExchangePrice = CDecp(txt_ExchangePrice.Data)
        W7231.PriceUSD = CDecp(txt_PriceUSD.Data)
        W7231.PriceVND = CDecp(txt_PriceVND.Data)

        W7231.Remark = txt_Remark.Data

        If opt_XCHK0.Checked = True Then W7231.CheckUse = "1"
        If opt_XCHK1.Checked = True Then W7231.CheckUse = "2"

        If rad_CheckMarketType1.Checked = True Then W7231.CheckMarketType = "1"
        If rad_CheckMarketType2.Checked = True Then W7231.CheckMarketType = "2"

        If chk_BOMType1.Checked = True Then W7231.BOMType = "1"
        If chk_BOMType2.Checked = True Then W7231.BOMType = "2"

        If rad_ApplyType1.Checked = True Then W7231.ApplyType = "1"
        If rad_ApplyType2.Checked = True Then W7231.ApplyType = "2"

        If rad_CheckPosition1.Checked = True Then
            W7231.CheckPosition = "1"
        Else
            W7231.CheckPosition = "2"
        End If

        If wJOB = "1" Then
            W7231.StatusMaterial = "1"  '1.NotApproved 2.Complete  3.Approved ,4.Cancel, 5.Pending 1, 6.Pending 2
            W7231.CheckActive = "1"  '1.Standard 2.R&D Upload 

            W7231.DateActive = Pub.DAT
            W7231.DateStart = Pub.DAT
            W7231.DateInsert = Pub.DAT
            W7231.InchargeInsert = Pub.SAW
        End If
        If wJOB = "3" Then

            W7231.DateUpdate = Pub.DAT
            W7231.InchargeUpdate = Pub.SAW
        End If

        W7231.Check1 = txt_Check1.Data
        W7231.Check2 = txt_Check2.Data
        W7231.Check3 = txt_Check3.Data
        W7231.Check4 = txt_Check4.Data
        W7231.Check5 = txt_Check5.Data

    End Sub
    Private Function DATA_UPDATE_APPROVED(xStatus As String) As Boolean
        DATA_UPDATE_APPROVED = False

        Try
            If READ_PFK7231(L7231.MaterialCode) = True Then
                W7231 = D7231
                Select Case xStatus
                    Case "1"
                        W7231.StatusMaterial = xStatus
                        W7231.DatePending1 = ""

                    Case "3"
                        W7231.StatusMaterial = xStatus
                        W7231.DateApproved = Pub.DAT

                    Case "5"
                        W7231.StatusMaterial = xStatus
                        W7231.DatePending2 = ""

                    Case "6"
                        W7231.StatusMaterial = xStatus
                        W7231.DatePending2 = Pub.DAT

                End Select

                If REWRITE_PFK7231(W7231) = True Then
                    isudCHK = True
                End If
            End If

            DATA_UPDATE_APPROVED = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function



    Private Sub DATA_INSERT()

        Call DATA_MOVE()

        If READ_PFK7231(W7231.MaterialCode) = True Then
            Call MsgBoxP("5", "DATA_INSERT")

            Call KEY_COUNT()
            Setfocus(txt_MaterialCode)
            Exit Sub
        End If

        If WRITE_PFK7231(W7231) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        If READ_PFK7231(txt_MaterialCode.Code) Then
            W7231 = D7231

            Call DATA_MOVE()
            If REWRITE_PFK7231(W7231) = True Then isudCHK = True

            Me.Dispose()
        End If
    End Sub
    Private Sub DATA_DELETE()
        Try
            If READ_PFK7231(L7231.MaterialCode) = True Then
                W7231 = D7231
                'If DELETE_PFK7231(W7231) = True Then isudCHK = True
                W7231.CheckUse = "2"
                W7231.DateDeactive = Pub.DAT
                W7231.InchargeUpdate = Pub.SAW
                If REWRITE_PFK7231(W7231) = True Then isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7231_MaterialCode AS DECIMAL)) AS MAX_CODE FROM PFK7231 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7231.MaterialCode = "000001"
        Else
            L7231.MaterialCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        W7231.MaterialCode = L7231.MaterialCode

        rd.Close()
        If Val(W7231.MaterialCode) > 999999 Then
            Call MsgBoxP("46", "KEY_COUNT")

            Call tst_iClose.PerformClick() : Exit Sub
        End If

        txt_MaterialCode.Data = W7231.MaterialCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK7231(L7231.MaterialCode, cn)

        If GetDsRc(DS1) = 0 Then
            Setfocus(txt_cdLargeGroupMaterial)
            Exit Function
            isudCHK = False
        End If


        If GetDsData(DS1, 0, "K7231_BOMType").ToString() = "2" Then chk_BOMType2.Checked = True
        If GetDsData(DS1, 0, "K7231_CheckMarketType").ToString() = "2" Then rad_CheckMarketType2.Checked = True
        If GetDsData(DS1, 0, "K7231_CheckUse").ToString() = "2" Then opt_XCHK1.Checked = True
        If GetDsData(DS1, 0, "K7231_ApplyType").ToString() = "2" Then rad_ApplyType2.Checked = True
        If GetDsData(DS1, 0, "K7231_CheckPosition").ToString() = "2" Then rad_CheckPosition2.Checked = True

        READER_MOVE(Me, DS1)

        StoreFormat_New(Me)

        Setfocus(txt_MaterialPName)

        DATA_SEARCH01 = True

    End Function

#End Region

#Region "Event"
    Private Sub cmd_Link7234_Load(sender As Object, e As EventArgs) Handles cmd_Link7234.btnTitleClick
        If READ_PFK7231(txt_MaterialCode.Data) = False Then Exit Sub
        Call ISUD7234A.Link_ISUD7234A(3, txt_MaterialCode.Data)
    End Sub
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub

                Call KEY_COUNT()

                Call DATA_INSERT()
                Me.Form_ClearData()
                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_MaterialPName)
            Case 2 : Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
                WRITE_CHK = "*"

            Case 4
                Call DATA_DELETE()
                WRITE_CHK = "*"

            Case 11
                Call DATA_INSERT()
                WRITE_CHK = "*"

                Me.Dispose()

            Case 91
                Call DATA_UPDATE_APPROVED("6")  'PENDDING 2
                WRITE_CHK = "*"

                Me.Dispose()

            Case 92
                Call DATA_UPDATE_APPROVED("3")  'Approved
                WRITE_CHK = "*"

                Me.Dispose()


        End Select

    End Sub
    'Private Sub tst_iSave2_Click(sender As Object, e As EventArgs) Handles tst_iSave2.Click
    '    Select Case wJOB
    '        Case 91
    '            Call DATA_UPDATE_APPROVED("1") 'Not Approved
    '            WRITE_CHK = "*"

    '            Me.Dispose()
    '        Case 92
    '            Call DATA_UPDATE_APPROVED("5") 'Pending 1
    '            WRITE_CHK = "*"

    '            Me.Dispose()

    '    End Select
    'End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If
        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()

    End Sub

    Private Sub txt_PriceMaterial_load(sender As Object, e As EventArgs) Handles txt_PriceMaterial.txtTextChanged, txt_ExchangePrice.txtTextChanged, txt_MaxInventory.txtTextChanged
        If formA = False Then Exit Sub
        Select Case txt_cdUnitPrice.Data

            Case "USD"
                rad_CheckMarketType1.Checked = True
                rad_CheckMarketType2.Checked = False

                If CDecp(txt_PriceMaterial.Data) >= 0 Then
                    txt_PriceUSD.Data = FormatNumber(CDecp(txt_PriceMaterial.Data), txt_PriceUSD.FormatDecimal)
                End If

                If CDecp(txt_cdTax3.Data) >= 0 Then
                    txt_PriceUSD.Data = FormatNumber(CDecp(txt_PriceMaterial.Data) * (1 + CDecp(txt_cdTax3.Data)), txt_PriceUSD.FormatDecimal)
                End If

                If CDecp(txt_ExchangePrice.Data) > 0 Then
                    txt_PriceVND.Data = FormatNumber(CDecp(txt_PriceMaterial.Data) * CDecp(txt_ExchangePrice.Data), txt_PriceUSD.FormatDecimal)
                Else
                    txt_PriceVND.Data = 0
                End If

            Case "VND"
                rad_CheckMarketType1.Checked = False
                rad_CheckMarketType2.Checked = True

                txt_MaxInventory.Data = 0

                If CDecp(txt_PriceMaterial.Data) > 0 Then
                    txt_PriceVND.Data = FormatNumber(txt_PriceMaterial.Data, txt_PriceVND.FormatDecimal)
                Else
                    txt_PriceVND.Data = 0
                End If

                If CDecp(txt_ExchangePrice.Data) > 0 Then
                    txt_PriceUSD.Data = FormatNumber(CDecp(txt_PriceMaterial.Data) / CDecp(txt_ExchangePrice.Data), txt_PriceUSD.FormatDecimal)
                Else
                    txt_PriceUSD.Data = 0
                End If

        End Select

    End Sub

    Private Sub txt_PriceMaterial_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_PriceMaterial.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If CDecp(txt_PriceMaterial.Data) > 0 Then
                txt_PriceMaterial.Data = FormatNumber(CDecp(txt_PriceMaterial.Data), txt_PriceMaterial.FormatDecimal)
            End If
        End If
    End Sub

    Private Sub txt_ExchangePrice_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_ExchangePrice.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            Select Case txt_cdUnitPrice.Data
                Case "USD"
                    If CDecp(txt_ExchangePrice.Data) > 0 Then
                        txt_ExchangePrice.Data = FormatNumber(CDecp(txt_ExchangePrice.Data), txt_ExchangePrice.FormatDecimal, , , TriState.True)
                    End If

                Case "VND"
                    If CDecp(txt_ExchangePrice.Data) > 0 Then
                        txt_ExchangePrice.Data = FormatNumber(CDecp(txt_ExchangePrice.Data), txt_ExchangePrice.FormatDecimal, , , TriState.True)
                    End If

            End Select
        End If
    End Sub

    Private Sub tst_iPrint_Print_Click(sender As Object, e As EventArgs) Handles tst_iPrint_Print.Click
        Call DATA_MOVE_BARCODE()
    End Sub

    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        If txt_cdSemiGroupMaterial.Code = "003" Then
            Call TAG_PRINT_FINAL_OLD()
        Else
            Call TAG_PRINT_MATERIAL_01()
        End If
    End Sub
    Public Sub DATA_MOVE_BARCODE()
        MATERIAL.MaterialInBoundSno = 1

        MATERIAL.MaterialCode = txt_MaterialCode.Data
        MATERIAL.MaterialName = txt_MaterialPName.Data
        MATERIAL.cdUnitMaterialName = txt_cdUnitMaterial.Data
        MATERIAL.cdUnitPackingName = txt_cdUnitPacking.Data

        MATERIAL.DateInBoundMaterial = Pub.DAT

        MATERIAL.BoxInBoundMaterial = 1
        MATERIAL.QtyInBoundMaterial = txt_QtyBasic.Data
        MATERIAL.LCNO = "TEST"

        MATERIAL.InchargeInBoundMaterialName = "TEST"
        MATERIAL.SupplierName = "TEST"

        MATERIAL.CheckInBoundMaterial = 1
        MATERIAL.CheckMaterialType = 1
        MATERIAL.CheckMarketType = 1

        MATERIAL.Barcode = "WH999999999"
        MATERIAL.DateAccept = Pub.DAT

        Try
            Call frm_PrintPreview.LINKDATA(txt_MaterialCode.Code)

            PrintPreviewDialog1 = New PrintPreviewDialog
            PrintPreviewDialog1.Document = PrintDocument1

            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub


#End Region

End Class