Public Class ISUD7108B
#Region "Variable"
    Private wJOB As Integer

    Private W7231 As T7231_AREA

    Private W7115 As T7115_AREA
    Private L7115 As T7115_AREA

    Private W7116 As T7116_AREA
    Private L7116 As T7116_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private W7306 As T7306_AREA
    Private L7306 As T7306_AREA

    Private W7103 As T7103_AREA
    Private W7108 As T7108_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7108B(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7115.ShoesCode = ShoesCode

        wJOB = job : L7115 = D7115

        Link_ISUD7108B = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7106(ShoesCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7108B = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("GroupComponentBOM"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"

                Frame1.Enabled = True
                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Setfocus(txt_GroupComponentBOMName)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_GroupComponentBOM.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

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
                        tst_iDelete.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                Frame1.Enabled = True

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_GroupComponentBOM.Enabled = False
            Call D7115_CLEAR()
            W7115 = D7115

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        ptc_Main.ItemSize = New Size((ptc_Main.Width - 15) / ptc_Main.TabCount, 25)

        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            DS1 = READ_PFK7106(L7115.ShoesCode, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)
                txt_GroupComponentBOMName.Data = txt_Line.Data & "-" & txt_Article.Data & "-" & txt_ColorName.Data
            End If

            DS1 = Nothing

            If READ_PFK7115_SHOESCODE(L7115.ShoesCode) Then
                txt_cdUnitPrice.Code = D7115.cdUnitPrice
                If READ_PFK7171(ListCode("UnitPrice"), D7115.cdUnitPrice) Then
                    txt_cdUnitPrice.Data = D7171.BasicName
                End If

                txt_cdUnitPriceLocal.Code = D7115.cdUnitPriceLocal
                If READ_PFK7171(ListCode("UnitPriceLocal"), D7115.cdUnitPriceLocal) Then
                    txt_cdUnitPriceLocal.Data = D7171.BasicName
                End If

                txt_PriceExchange.Data = D7115.PriceExchange
                txt_ProfitRate.Value = CIntp(D7115.ProfitRate)
            End If

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7108B_SEARCH_VS1", cn, L7115.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7108B_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7108B_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True
    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        DS1 = PrcDS("USP_ISUD7108B_SEARCH_VS2", cn, L7115.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs2, DS1, "USP_ISUD7108B_SEARCH_VS2", "VS2")
            Vs2.ActiveSheet.RowCount = 10
            Vs2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs2, DS1, "USP_ISUD7108B_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True
    End Function

    Private Function DATA_SEARCH_VS31() As Boolean
        DATA_SEARCH_VS31 = False

        DS1 = PrcDS("USP_ISUD7108B_SEARCH_VS31", cn, L7115.ShoesCode, "1")

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7108B_SEARCH_VS31_INSERT", cn, ListCode("CBDCost"), "1")
            SPR_PRO_NEW(vS31, DS2, "USP_ISUD7108B_SEARCH_VS31", "vS31")
            SPR_INSERT(vS31)
            Exit Function
        End If

        SPR_PRO_NEW(vS31, DS1, "USP_ISUD7108B_SEARCH_VS31", "VS31")

        DATA_SEARCH_VS31 = True
    End Function

    Private Function DATA_SEARCH_VS32() As Boolean
        DATA_SEARCH_VS32 = False

        DS1 = PrcDS("USP_ISUD7108B_SEARCH_VS32", cn, L7115.ShoesCode, "2")

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7108B_SEARCH_VS32_INSERT", cn, ListCode("CBDCost"), "2")
            SPR_PRO_NEW(vS32, DS2, "USP_ISUD7108B_SEARCH_VS32", "VS32")
            SPR_INSERT(vS32)
            Exit Function
        End If
        SPR_PRO_NEW(vS32, DS1, "USP_ISUD7108B_SEARCH_VS32", "VS32")

        DATA_SEARCH_VS32 = True
    End Function

    Private Function DATA_SEARCH_VS33() As Boolean
        DATA_SEARCH_VS33 = False

        DS1 = PrcDS("USP_ISUD7108B_SEARCH_VS33", cn, L7115.ShoesCode, "3")

        If GetDsRc(DS1) = 0 Then
            DS2 = PrcDS("USP_ISUD7108B_SEARCH_VS33_INSERT", cn, ListCode("CBDCost"), "3")
            SPR_PRO_NEW(vS33, DS2, "USP_ISUD7108B_SEARCH_VS33", "VS33")
            SPR_INSERT(vS33)
            Exit Function
        End If
        SPR_PRO_NEW(vS33, DS1, "USP_ISUD7108B_SEARCH_VS33", "VS33")

        DATA_SEARCH_VS33 = True
    End Function
    Private Function DATA_SEARCH_VS4() As Boolean
        DATA_SEARCH_VS4 = False

        DS1 = PrcDS("USP_ISUD7108B_SEARCH_VS4", cn, L7115.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS4, DS1, "USP_ISUD7108B_SEARCH_VS4", "VS4")
            vS4.ActiveSheet.RowCount = 10
            vS4.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS4, DS1, "USP_ISUD7108B_SEARCH_VS4", "VS4")
        DATA_SEARCH_VS4 = True
    End Function
#End Region

#Region "Function"
    Private Sub KEY_COUNT_7103()

        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7103_TypeCode AS DECIMAL)) AS MAX_CODE FROM PFK7103 "
        SQL = SQL + " WHERE K7103_cdTypeCode = '003' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7103.TypeCode = "000001"
        Else
            W7103.TypeCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        rd.Close()

    End Sub
    Private Sub KEY_COUNT_MATERIAL()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7231_MaterialCode AS DECIMAL)) AS MAX_CODE FROM PFK7231 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7231.MaterialCode = "000001"
        Else
            W7231.MaterialCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If


    End Sub
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim AmtBegin As Decimal
        Dim AmtEnd As Decimal

        Try
            If txt_cdUnitPrice.Code = "" Then MsgBoxP("Unit Price!") : Setfocus(txt_cdUnitPrice) : Exit Function

            If txt_cdUnitPrice.Code = "001" Then txt_PriceExchange.Data = "1"

            If txt_cdUnitPrice.Code <> "001" Then
                If READ_PFK7171(ListCode("UnitPrice"), txt_cdUnitPrice.Code) Then
                    AmtBegin = CDecp(D7171.CheckName9)
                    AmtEnd = CDecp(D7171.CheckName10)

                    If CDecp(txt_PriceExchange.Data) < AmtBegin Or CDecp(txt_PriceExchange.Data) > AmtEnd Then MsgBoxEx("Wrong Price Exchange!") : Setfocus(txt_PriceExchange) : Exit Function

                End If
            End If


            Data_Check = True

        Catch ex As Exception

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            W7115.ProfitRate = txt_ProfitRate.Value
            W7115.CostBOM = L7115.CostBOM
            W7115.ShoesCode = txt_ShoesCode.Data

            W7115.cdUnitPrice = txt_cdUnitPrice.Code
            W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
            W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

            W7115.seUnitPrice = ListCode("UnitPrice")
            W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

            If rad_CheckUse1.Checked = True Then W7115.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7115.CheckUse = "2"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub KEY_COUNT_K7108()
        Try

            SQL = " SELECT MAX(CAST(K7108_GroupComponentBOM AS DECIMAL)) as MAX_CODE FROM PFK7108 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7108.GroupComponentBOM = "000001"
            Else
                W7108.GroupComponentBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()


        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub
    Private Sub DATA_MOVE_WRITE01()
        Try

            If READ_PFK7108_SHOESCODE(txt_ShoesCode.Data) = False Then
                W7108.ShoesCode = txt_ShoesCode.Data
                W7108.GroupComponentBOMName = txt_Line.Data & "-" & txt_Article.Data & "-" & txt_ColorName.Data
                W7108.CheckUse = "1"

                Call KEY_COUNT_K7108()

                If WRITE_PFK7108(W7108) = True Then
                    'SQL = "DELETE FROM PFK7109 "
                    'SQL = SQL & " WHERE K7109_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
                    'cmd = New SqlClient.SqlCommand(SQL, cn)
                    'cmd.ExecuteNonQuery()

                    Dim i As Integer
                    Dim j As Integer
                    j = 0
                    For i = 0 To Vs1.ActiveSheet.RowCount - 1
                        If getData(Vs1, getColumIndex(Vs1, "MaterialName"), i) = "" Then GoTo skip
                        If getData(Vs1, getColumIndex(Vs1, "ComponentName"), i) = "" Then GoTo skip

                        j = j + 1

                        Call D7109_CLEAR() : W7109 = D7109

                        W7109.GroupComponentBOM = txt_GroupComponentBOM.Data
                        W7109.GroupComponentSeq = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), i))

                        If K7109_MOVE(Vs1, i, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) Then
                            W7109.Dseq = j

                            W7109.selGroupComponent = ListCode("GroupComponent")
                            W7109.seDepartment = ListCode("Department")
                            W7109.seShoesStatus = ListCode("ShoesStatus")
                            W7109.seUnitMaterial = ListCode("UnitMaterial")
                            W7109.seSubProcess = ListCode("SubProcess")

                            'If READ_PFK7103_TYPENAME("003", W7109.ComponentName) = False Then
                            '    W7103.TypeName = W7109.ComponentName
                            '    W7103.CustomerCode = txt_CustomerCode.Code
                            '    W7103.seTypeCode = ListCode("TypeCode")
                            '    W7103.cdTypeCode = "003"
                            '    W7103.CheckUse = "1"
                            '    W7103.DateInsert = Pub.DAT
                            '    W7103.InchargeInsert = Pub.SAW
                            '    Call KEY_COUNT_7103()

                            '    Call WRITE_PFK7103(W7103)
                            'End If

                            W7109.GrossUsage = W7109.Consumption * (W7109.Loss / 100 + 1)

                            W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                            W7109.PriceRnD += W7109.ExchangeCost
                            W7109.PriceRnD += W7109.AddedCost
                            W7109.PriceRnD += W7109.ComplicationCost
                            W7109.PriceRnD += W7109.ShippingCost

                            W7109.Price = W7109.PriceRnD
                            W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD
                            W7109.MaterialAMTSales = W7109.GrossUsage * W7109.PriceRnD

                            Call REWRITE_PFK7109(W7109)
                        End If
skip:
                    Next

                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub

                End If

            Else
                W7108 = D7108
                W7108.ShoesCode = txt_ShoesCode.Data
                W7108.GroupComponentBOMName = txt_Line.Data & "-" & txt_Article.Data & "-" & txt_ColorName.Data
                W7108.CheckUse = "1"

                If REWRITE_PFK7108(W7108) = True Then
                    'SQL = "DELETE FROM PFK7109 "
                    'SQL = SQL & " WHERE K7109_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
                    'cmd = New SqlClient.SqlCommand(SQL, cn)
                    'cmd.ExecuteNonQuery()

                    Dim i As Integer
                    Dim j As Integer
                    j = 0
                    For i = 0 To Vs1.ActiveSheet.RowCount - 1
                        If getData(Vs1, getColumIndex(Vs1, "MaterialName"), i) = "" Then GoTo skip1
                        If getData(Vs1, getColumIndex(Vs1, "ComponentName"), i) = "" Then GoTo skip1

                        j = j + 1

                        Call D7109_CLEAR() : W7109 = D7109
                        W7109.GroupComponentBOM = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), i)
                        W7109.GroupComponentSeq = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), i)

                        If K7109_MOVE(Vs1, i, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) Then
                            W7109.Dseq = j

                            W7109.selGroupComponent = ListCode("GroupComponent")
                            W7109.seDepartment = ListCode("Department")
                            W7109.seShoesStatus = ListCode("ShoesStatus")
                            W7109.seUnitMaterial = ListCode("UnitMaterial")
                            W7109.seSubProcess = ListCode("SubProcess")
                            W7109.GrossUsage = W7109.Consumption * (W7109.Loss / 100 + 1)

                            W7109.PriceRnD = W7109.PriceMaterial * (1 + W7109.ShippingRate / 100)
                            W7109.PriceRnD += W7109.ExchangeCost
                            W7109.PriceRnD += W7109.AddedCost
                            W7109.PriceRnD += W7109.ComplicationCost
                            W7109.PriceRnD += W7109.ShippingCost

                            W7109.Price = W7109.PriceRnD
                            W7109.MaterialAMT = W7109.GrossUsage * W7109.PriceRnD
                            W7109.MaterialAMTSales = W7109.GrossUsage * W7109.PriceRnD

                            Call REWRITE_PFK7109(W7109)
                        End If
skip1:
                    Next

                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If

            End If




        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub
    '    Private Sub DATA_MOVE_WRITE01()
    '        Try
    '            Dim GroupComponentBOM As String
    '            Dim GroupComponentSeq As String

    '            Dim i As Integer
    '            Dim j As Integer

    '            For i = 0 To Vs1.ActiveSheet.RowCount - 1

    '                GroupComponentBOM = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), i)
    '                GroupComponentSeq = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), i)

    '                If READ_PFK7109(GroupComponentBOM, GroupComponentSeq) Then
    '                    W7109 = D7109
    '                    W7109.Price = CDecp(getData(Vs1, getColumIndex(Vs1, "Price"), i))
    '                    W7109.Loss = CDecp(getData(Vs1, getColumIndex(Vs1, "Loss"), i))
    '                    W7109.Consumption = CDecp(getData(Vs1, getColumIndex(Vs1, "Consumption"), i))

    '                    W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

    '                    W7109.MaterialAMT = CDecp(W7109.Price * (1 + W7109.Loss / 100) * W7109.Consumption)

    '                    Call REWRITE_PFK7109(W7109)
    '                End If

    'skip:
    '            Next

    '        Catch ex As Exception
    '            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
    '        End Try

    '    End Sub

    Private Sub DATA_MOVE_WRITE02()
        Try
            Dim ProcessBOMCode As String
            Dim ProcessBOMSeq As String

            Dim i As Integer
            Dim j As Integer

            For i = 0 To Vs2.ActiveSheet.RowCount - 1

                ProcessBOMCode = getData(Vs2, getColumIndex(Vs2, "KEY_ProcessBOMCode"), i)
                ProcessBOMSeq = getData(Vs2, getColumIndex(Vs2, "KEY_ProcessBOMSeq"), i)

                If READ_PFK7306(ProcessBOMCode, ProcessBOMSeq) Then
                    W7306 = D7306
                    W7306.Cost = CDecp(getData(Vs2, getColumIndex(Vs2, "Cost"), i))
                    W7306.Loss = CDecp(getData(Vs2, getColumIndex(Vs2, "Loss"), i))

                    W7306.AMTProcess = CDecp(W7306.Cost * (1 + W7306.Loss / 100))

                    Call REWRITE_PFK7306(W7306)
                End If

skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_MOVE_WRITE031()
        Try
            SQL = "DELETE FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM  = '" & W7115.CostBOM & "' "
            SQL = SQL & " AND K7116_CostType  = '1' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS31.ActiveSheet.RowCount - 1
                If getData(vS31, getColumIndex(vS31, "cdCBDCost"), i) = "" Then GoTo skip

                j = j + 1

                Call D7116_CLEAR() : W7116 = D7116
                Call K7116_MOVE(vS31, i, W7116, W7116.CostBOM, W7116.CostSeq, "1")

                W7116.CostBOM = W7115.CostBOM
                W7116.CostSeq = j
                W7116.Dseq = j
                W7116.CostType = "1"

                W7116.seCBDCost = ListCode("CBDCost")
                W7116.seCostingType = ListCode("CostingType")

                W7116.Price = CDecp(getData(vS31, getColumIndex(vS31, "Price"), i))
                W7116.QtyCost = CDecp(getData(vS31, getColumIndex(vS31, "QtyCost"), i))
                W7116.AMTCost = CDecp(W7116.Price * W7116.QtyCost)

                Call WRITE_PFK7116(W7116)
skip:
            Next


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_MOVE_WRITE032()
        Try


            SQL = "DELETE FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM  = '" & W7115.CostBOM & "' "
            SQL = SQL & " AND K7116_CostType  = '2' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS32.ActiveSheet.RowCount - 1
                If getData(vS32, getColumIndex(vS32, "cdCBDCost"), i) = "" Then GoTo skip

                j = j + 1

                Call D7116_CLEAR() : W7116 = D7116
                Call K7116_MOVE(vS32, i, W7116, W7116.CostBOM, W7116.CostSeq, "2")

                W7116.CostBOM = W7115.CostBOM
                W7116.CostSeq = j
                W7116.Dseq = j
                W7116.CostType = "2"

                W7116.seCBDCost = ListCode("CBDCost")
                W7116.seCostingType = ListCode("CostingType")

                W7116.Price = CDecp(getData(vS32, getColumIndex(vS32, "Price"), i))
                W7116.QtyCost = CDecp(getData(vS32, getColumIndex(vS32, "QtyCost"), i))
                W7116.AMTCost = CDecp(W7116.Price * W7116.QtyCost)

                Call WRITE_PFK7116(W7116)
skip:
            Next


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Sub DATA_MOVE_WRITE033()
        Try


            SQL = "DELETE FROM PFK7116 "
            SQL = SQL & " WHERE K7116_CostBOM  = '" & W7115.CostBOM & "' "
            SQL = SQL & " AND K7116_CostType  = '3' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To vS33.ActiveSheet.RowCount - 1
                If getData(vS33, getColumIndex(vS33, "cdCBDCost"), i) = "" Then GoTo skip

                j = j + 1

                Call D7116_CLEAR() : W7116 = D7116
                Call K7116_MOVE(vS33, i, W7116, W7116.CostBOM, W7116.CostSeq, "3")

                W7116.CostBOM = W7115.CostBOM
                W7116.CostSeq = j
                W7116.Dseq = j
                W7116.CostType = "3"

                W7116.seCBDCost = ListCode("CBDCost")
                W7116.seCostingType = ListCode("CostingType")

                W7116.Price = CDecp(getData(vS33, getColumIndex(vS33, "Price"), i))
                W7116.QtyCost = CDecp(getData(vS33, getColumIndex(vS33, "QtyCost"), i))
                W7116.AMTCost = CDecp(W7116.Price * W7116.QtyCost)

                Call WRITE_PFK7116(W7116)
skip:
            Next


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub
    Private Sub DATA_INSERT()
        Try

            If READ_PFK7115_SHOESCODE(txt_ShoesCode.Data) = True Then
                W7115 = D7115
                W7115.ProfitRate = txt_ProfitRate.Value
                W7115.cdUnitPrice = txt_cdUnitPrice.Code
                W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                W7115.PriceExchange = txt_PriceExchange.Data

                If REWRITE_PFK7115(W7115) Then

                End If

            Else
                Call KEY_COUNT()
                Call DATA_MOVE()

                If WRITE_PFK7115(W7115) = True Then


                End If
            End If

            If ptc_Main.SelectedIndex = 0 Then Call DATA_MOVE_WRITE01() : Call DATA_SEARCH_VS1()
            If ptc_Main.SelectedIndex = 1 Then Call DATA_MOVE_WRITE02() : Call DATA_SEARCH_VS2()

            If ptc_Main.SelectedIndex = 2 Then
                Call KEY_COUNT()
                Call DATA_MOVE()

                If WRITE_PFK7115(W7115) = True Then
                    Call DATA_MOVE_WRITE031()
                    Call DATA_MOVE_WRITE032()
                    Call DATA_MOVE_WRITE033()

                    Call DATA_SEARCH_VS31()
                    Call DATA_SEARCH_VS32()
                    Call DATA_SEARCH_VS33()
                End If
            End If

            If ptc_Main.SelectedIndex = 3 Then
                If READ_PFK7115_SHOESCODE(txt_ShoesCode.Data) = True Then
                    W7115 = D7115
                    W7115.ProfitRate = txt_ProfitRate.Value

                    If REWRITE_PFK7115(W7115) Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If

                Else
                    Call KEY_COUNT()
                    Call DATA_MOVE()

                    If WRITE_PFK7115(W7115) = True Then

                    End If
                End If

                Call DATA_SEARCH_VS4()
            End If

            isudCHK = True : WRITE_CHK = "*"

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            If READ_PFK7115_SHOESCODE(txt_ShoesCode.Data) = True Then
                W7115 = D7115
                W7115.ProfitRate = txt_ProfitRate.Value
                W7115.cdUnitPrice = txt_cdUnitPrice.Code
                W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

                W7115.seUnitPrice = ListCode("UnitPrice")
                W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

                If REWRITE_PFK7115(W7115) Then

                End If

            Else
                Call KEY_COUNT()
                Call DATA_MOVE()

                If WRITE_PFK7115(W7115) = True Then


                End If
            End If

            If ptc_Main.SelectedIndex = 0 Then Call DATA_MOVE_WRITE01() : Call DATA_SEARCH_VS1()
            If ptc_Main.SelectedIndex = 1 Then Call DATA_MOVE_WRITE02() : Call DATA_SEARCH_VS2()

            If ptc_Main.SelectedIndex = 2 Then
                If READ_PFK7115_SHOESCODE(txt_ShoesCode.Data) = True Then
                    W7115 = D7115
                    W7115.ProfitRate = txt_ProfitRate.Value
                    W7115.cdUnitPrice = txt_cdUnitPrice.Code
                    W7115.cdUnitPriceLocal = txt_cdUnitPriceLocal.Code
                    W7115.PriceExchange = CDecp(txt_PriceExchange.Data)

                    W7115.seUnitPrice = ListCode("UnitPrice")
                    W7115.seUnitPriceLocal = ListCode("UnitPriceLocal")

                    If REWRITE_PFK7115(W7115) Then
                        Call DATA_MOVE_WRITE031()
                        Call DATA_MOVE_WRITE032()
                        Call DATA_MOVE_WRITE033()

                        Call DATA_SEARCH_VS31()
                        Call DATA_SEARCH_VS32()
                        Call DATA_SEARCH_VS33()

                        isudCHK = True : WRITE_CHK = "*"
                    End If

                Else
                    Call KEY_COUNT()
                    Call DATA_MOVE()

                    If WRITE_PFK7115(W7115) = True Then
                        Call DATA_MOVE_WRITE031()
                        Call DATA_MOVE_WRITE032()
                        Call DATA_MOVE_WRITE033()

                        Call DATA_SEARCH_VS31()
                        Call DATA_SEARCH_VS32()
                        Call DATA_SEARCH_VS33()
                    End If
                End If
            End If

            If ptc_Main.SelectedIndex = 3 Then
                If READ_PFK7115_SHOESCODE(txt_ShoesCode.Data) = True Then
                    W7115 = D7115
                    W7115.ProfitRate = txt_ProfitRate.Value

                    If REWRITE_PFK7115(W7115) Then
                        isudCHK = True : WRITE_CHK = "*"
                    End If

                Else
                    Call KEY_COUNT()
                    Call DATA_MOVE()

                    If WRITE_PFK7115(W7115) = True Then

                    End If
                End If

                Call DATA_SEARCH_VS4()
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()

        Try
            SQL = " SELECT MAX(CAST(K7115_CostBOM AS DECIMAL)) as MAX_CODE FROM PFK7115 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7115.CostBOM = "000001"
            Else
                W7115.CostBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            L7115.CostBOM = W7115.CostBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK7018") = False Then Exit Sub
                Call DATA_INSERT()
                wJOB = 3
                Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK7018") = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4
                Call DATA_DELETE()
        End Select
    End Sub

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

        Me.Dispose()
    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        Dim xCOL As Integer
        Dim xROW As Integer
        Dim MaterialCode As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(Vs1, "CLSupplierPrice")

                MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), xROW)

                If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

                If HLP7260A.Link_HLP7260A(MaterialCode, "2") = False Then Exit Sub
                If READ_PFK7260(D7261.ContractID) Then
                    setData(Vs1, getColumIndex(Vs1, "ContractID"), xROW, D7260.ContractID)
                    setData(Vs1, getColumIndex(Vs1, "KEY_ContractID"), xROW, D7260.ContractID)

                    setData(Vs1, getColumIndex(Vs1, "SupplierCode"), xROW, D7260.CustomerCode)
                    setData(Vs1, getColumIndex(Vs1, "PriceMaterial"), xROW, D7261.PriceMaterialVND)

                    setData(Vs1, getColumIndex(Vs1, "PriceMaterial"), xROW, D7261.PriceMaterialVND)

                    If READ_PFK7101(D7260.CustomerCode) Then
                        setData(Vs1, getColumIndex(Vs1, "SupplierName"), xROW, D7101.CustomerName)
                    End If

                End If


        End Select
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                'Call Select_Message("3", WordConv("PROCESSING"), 2)

                'If Msg_Result <> vbYes Then Exit Sub

                'W7109.GroupComponentBOM = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), xROW)
                'W7109.GroupComponentSeq = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), xROW)

                'If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) Then
                '    W7109 = D7109
                '    Call DELETE_PFK7109(W7109)
                'End If

                'SPR_DEL(Vs1, xCOL, xROW)
                'Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                'Vs1.ActiveSheet.ActiveRowIndex = xROW
                'Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub

    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_Main.DoubleClick
        If formA = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS1()
            Case 1
                Call DATA_SEARCH_VS2()
            Case 2
                Call DATA_SEARCH_VS31()
                Call DATA_SEARCH_VS32()
                Call DATA_SEARCH_VS33()
            Case 3
                Call DATA_SEARCH_VS4()
        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        If formA = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0
                Call DATA_SEARCH_VS1()
            Case 1
                Call DATA_SEARCH_VS2()
            Case 2
                Call DATA_SEARCH_VS31()
                Call DATA_SEARCH_VS32()
                Call DATA_SEARCH_VS33()
            Case 3
                Call DATA_SEARCH_VS4()
        End Select

    End Sub
    Private Sub cmd_ChkMaterial_Click(sender As Object, e As EventArgs) Handles cmd_ChkMaterial.Click
        If READ_PFK7108_SHOESCODE(txt_ShoesCode.Data) Then
            If ISUD7231P.Link_ISUD7231P("3", D7108.GroupComponentBOM, "PFP71080") = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        End If
    End Sub
    Private Sub cmd_AttachMaterialToSupplier_Click(sender As Object, e As EventArgs) Handles cmd_AttachMaterialToSupplier.Click
        If READ_PFK7108_SHOESCODE(txt_ShoesCode.Data) Then
            If ISUD7108F.Link_ISUD7108F("3", D7108.GroupComponentBOM, "PFP71080") = False Then Exit Sub
            Call DATA_SEARCH_VS1()
        End If
    End Sub



#End Region

End Class