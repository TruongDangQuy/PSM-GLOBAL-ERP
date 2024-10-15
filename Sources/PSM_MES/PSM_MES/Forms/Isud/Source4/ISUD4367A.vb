Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4367A

#Region "Variable"
    Private wJOB As Integer

    Private W4073 As New T4073_AREA
    Private L4073 As New T4073_AREA

    Private W4175 As New T4175_AREA
    Private L4175 As New T4175_AREA

    Private W4074 As New T4074_AREA
    Private L4074 As New T4074_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"

    Public Function Link_ISUD4367A(job As Integer, SetKey As String, JobCard As String, cdSubProcess As String, cdFactory As String, cdLineProd As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        txt_SetKey.Data = SetKey

        txt_cdFactory.Data = cdFactory
        txt_cdSubProcess.Data = cdSubProcess
        txt_cdLineProd.Data = cdLineProd

        txt_cdFactory.Code = cdFactory
        txt_cdSubProcess.Code = cdSubProcess
        txt_cdLineProd.Code = cdLineProd

        txt_JobCard.Code = JobCard
        txt_JobCard.Data = JobCard


        wJOB = job : L4073 = D4073

        Link_ISUD4367A = False
        Try
            formA = False


            Select Case job
                Case 1, 11

                Case Else

            End Select

            Me.ShowDialog()

            Link_ISUD4367A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))


begin:

        Select Case wJOB
            Case 1
                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If txt_JobCard.Data <> "" Then
                    Call DATA_SEARCH_HEAD()

                    Call DATA_SEARCH_vS0()
                    Call DATA_SEARCH_VS1()
                    Call DATA_SEARCH_VS2()
                End If

                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False

                txt_cdLineProd.Code = ""
                txt_cdFactory.Code = ""

            Case 2
AgainPoint:
                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Text = Me.Text & " - SEARCH"
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                txt_BatchSizeQ.Visible = False

            Case 3
                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - UPDATE"
                cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                txt_BatchSizeQ.Visible = False
                cmd_OK.Visible = False

            Case 4

                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - DELETE"
                cmd_DEL.Visible = True

                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()
                txt_BatchSizeQ.Visible = False
            Case 5
                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - UPDATE"
                cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 11

                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                cmd_DEL.Visible = True

                cmd_OK.Visible = True

                Call KEY_COUNT()
                Call DATA_SEARCH_HEAD()

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                txt_Barcode.Data = L4073.JobCard

                Call txt_GreyBarcode_txtTextKeyDown(sender, New System.Windows.Forms.KeyEventArgs(Keys.Enter))

                wJOB = 1
                Me.Text = Me.Text & " - INSERT"
                cmd_OK.Visible = True

        End Select

        'If Pub.DEVCHK <> "1" Then cmd_OK.Visible = False
        'If Pub.DEVCHK = "1" Then cmd_OK.Visible = True

        formA = True

    End Sub
#End Region

#Region "Search"
    Private Sub DATA_INIT()
        Try
            txt_DatePlan.Data = Pub.DAT

            txt_InchargePlan.Data = Pub.NAM
            txt_InchargePlan.Code = Pub.SAW
        Catch ex As Exception
            Call MsgBoxP("DATA_INIT")
        End Try
    End Sub
    Private Sub Calculation()

    End Sub
    Private Sub FORM_INIT()
        RemoveHandler txt_Barcode.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown
        vS1.HorizontalScrollBarPolicy = ScrollBarPolicy.Never
        Me.WindowState = FormWindowState.Maximized
        txt_Barcode.PeaceTextbox1.Properties.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub KEY_COUNT()
        Try
            SQL = "SELECT MAX(CAST(K4073_LineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4073 "
            SQL = SQL & " WHERE K4073_cdFactory = '" & txt_cdFactory.Code & "' "
            SQL = SQL & " AND K4073_cdSubProcess = '" & txt_cdSubProcess.Code & "' "
            SQL = SQL & " AND K4073_cdLineProd = '" & txt_cdLineProd.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4073.LineTno = "01"
            Else
                L4073.LineTno = CIntp(rd!MAX_MCODE + 1).ToString("00")
            End If

            W4073.LineTno = L4073.LineTno

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub


    Private Sub KEY_COUNT_K4175_BatchGroup()
        Dim YRNO As Integer
        YRNO = CIntp(Mid(System_Date_8(), 3, 4))

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K4175_BatchGroup,7,10) AS DECIMAL)) AS MAX_MCODE FROM PFK4175 "
            SQL = SQL & " WHERE SUBSTRING(K4175_BatchGroup,1,6) = 'CW" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4175.BatchGroup = "CW" & YRNO.ToString & "0001"
            Else
                L4175.BatchGroup = "CW" & YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("0000")
            End If

            W4175.BatchGroup = L4175.BatchGroup
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Dim i As Integer
        Dim Scol As Integer
        Dim FixCol As Integer

        Try

            DS1 = PrcDS("USP_ISUD4367A_SEARCH_vS1", cn, txt_JobCard.Data)

            If GetDsRc(DS1) = 0 Then
                vS1.Enabled = True
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD4367A_SEARCH_vS1", "Vs1")
                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD4367A_SEARCH_vS1", "Vs1")
            'Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_JOBBASE", "SizeQty01", txt_JobCard.Data)

            Call VsSizeRangeNew_one(vS1, "USP_PFP01511_SEARCH_VS11_HEAD", getColumIndex(vS1, "QtyTotal"), getData(vS1, getColumIndex(vS1, "OrderNo"), 0), getData(vS1, getColumIndex(vS1, "OrderNoSeq"), 0))
            vS1.ActiveSheet.RowCount += 2

            SPR_CHECKBOXROW(vS1, vS1.ActiveSheet.RowCount - 2)

            Scol = getColumIndex(vS1, "SizeQty01_S50")
            FixCol = getColumIndex(vS1, "SizeQty01_S50")

            Dim int_SumQty As Integer = 0



            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If CIntp(getDataM(vS1, i, 4)) < 0 Then
                    setData(vS1, i, 5, True)
                    setData(vS1, i, 6, Math.Abs(CIntp(getDataM(vS1, i, 4))))
                    int_SumQty += Math.Abs(CIntp(getDataM(vS1, i, 4)))

                End If
            Next
            i = 0
            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                vS1.ActiveSheet.Cells(5, i).Locked = False
                vS1.ActiveSheet.Cells(6, i).Locked = False
            Next

            txt_BatchSizeQ.Value = int_SumQty

            DATA_SEARCH_VS1 = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_vS0() As Boolean
        DATA_SEARCH_vS0 = False
        txt_BatchGroup.Data = ""

        Try

            DS1 = PrcDS("USP_ISUD4367A_SEARCH_VS0", cn, txt_JobCard.Data)

            If GetDsRc(DS1) = 0 Then
                vS0.Enabled = True
                SPR_PRO(vS0, DS1, "USP_ISUD4367A_SEARCH_VS0", "vS0")
                Exit Function
            End If

            SPR_PRO(vS0, DS1, "USP_ISUD4367A_SEARCH_VS0", "vS0")

            DATA_SEARCH_vS0 = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False

        Try

            DS1 = PrcDS("USP_ISUD4367A_SEARCH_VS2", cn, txt_JobCard.Data, txt_SetKey.Data)

            If GetDsRc(DS1) = 0 Then
                DS2 = PrcDS("USP_ISUD4367A_SEARCH_VS2_INSERT", cn, txt_JobCard.Data, txt_SetKey.Data)
                SPR_PRO(vS2, DS2, "USP_ISUD4367A_SEARCH_VS2", "VS2")

                SPR_INSERT(vS2)
                Exit Function
            End If

            SPR_PRO(vS2, DS1, "USP_ISUD4367A_SEARCH_VS2", "VS2")

            DATA_SEARCH_VS2 = True


            DS2 = PrcDS("USP_ISUD4367A_SEARCH_VS2_INFORMATION", cn, txt_JobCard.Data, txt_SetKey.Data)

            If GetDsRc(DS2) > 0 Then
                txt_SetKey.Data = txt_SetKey.Data
                txt_DatePlan.Data = GetDsData(DS2, 0, "ProdDate")
                txt_JobCard.Data = GetDsData(DS2, 0, "JobCard")

                Call READ_PFK7171(ListCode("Factory"), GetDsData(DS2, 0, "cdFactory"))
                txt_cdFactory.Data = D7171.BasicName
                txt_cdFactory.Code = D7171.BasicCode

                Call READ_PFK7171(ListCode("LineProd"), GetDsData(DS2, 0, "cdLineProd"))
                txt_cdLineProd.Data = D7171.BasicName
                txt_cdLineProd.Code = D7171.BasicCode

                Call READ_PFK7171(ListCode("SubProcess"), GetDsData(DS2, 0, "cdSubProcess"))
                txt_cdSubProcess.Data = D7171.BasicName
                txt_cdSubProcess.Code = D7171.BasicCode

                txt_BatchSizeQ.Value = CIntp(GetDsData(DS2, 0, "QtyProductionSet"))
                txt_BatchSizeQ.Visible = True
                txt_Barcode.Data = GetDsData(DS2, 0, "JobCard")
                txt_Barcode.Enabled = False

                txt_DatePlan.Enabled = False
            End If

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try

            DS1 = PrcDS("USP_ISUD4367A_SEARCH_HEAD", cn, txt_JobCard.Data)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            L4073.JobCard = GetDsData(DS1, 0, "JobCard")

            Call K4073_CheckComplete(GetDsData(DS1, 0, "CheckComplete"))

            DATA_SEARCH_HEAD = True

            If READ_PFK7171(ListCode("Factory"), txt_cdFactory.Code) = True Then
                txt_cdFactory.Data = D7171.BasicName
                txt_cdFactory.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("cdSubProcess"), txt_cdSubProcess.Code) = True Then
                txt_cdSubProcess.Data = D7171.BasicName
                txt_cdSubProcess.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("LineProd"), txt_cdLineProd.Code) = True Then
                txt_cdLineProd.Data = D7171.BasicName
                txt_cdLineProd.Code = D7171.BasicCode
            End If



            'Call StoreFormat(Me)


        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH_HEAD_TAB1() As Boolean
        DATA_SEARCH_HEAD_TAB1 = False
        DATA_SEARCH_HEAD_TAB1 = True
        Exit Function


        Try
            DS1 = PrcDS("USP_ISUD4367A_SEARCH_sTAB1_HEAD", cn, txt_JobCard.Data)

            STORE_MOVE(Block1, DS1)

            DATA_SEARCH_HEAD_TAB1 = True

            'Call StoreFormat(Block1)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = PrcDS("USP_ISUD4367A_SEARCH_vS1", cn, txt_JobCard.Data)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH01 = True
            'Call StoreFormat(Me)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_DELETE()
        DATA_DELETE = False
        Try
            If txt_DatePlan.Data <> System_Date_8() Then
                MsgBoxP("Not today!")
                If MsgBoxPPW("Please type the password to modify!", "753") = False Then Exit Function
            End If

            Call PrcExeNoError("USP_PFK4367_DELETE_ALL_SB1", cn, txt_JobCard.Data, txt_SetKey.Data, System_Date_8())
            Call PrcExeNoError("USP_PFK4167_CLOSSING_DATE_ALL_JOBCARD_FULL", cn, txt_JobCard.Data)

            Call Delete_History("PFK4367", txt_SetKey.Data)

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Function DATA_DELETE(xrow As Integer)
        DATA_DELETE = False

    End Function

    Private Function CheckItemCode(ItemCode As String) As Boolean

    End Function


    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False
        Dim xrow As Integer

        If txt_InchargePlan.Code = "" Then MsgBoxP("Please Input Incharge Name!") : Exit Function

        Try
            txt_Barcode.Data = FormatCut(txt_Barcode.Data)

            Call KEY_COUNT()

            DS1 = PrcDS("USP_ISUD4367A_SEARCH_vS1_INSERT", cn, L4073.JobCard)

            If GetDsRc(DS1) = 0 Then
                MsgBoxP("No data. Check, please!")
                Exit Function
            End If

            vS1.ActiveSheet.RowCount += 1
            xrow = vS1.ActiveSheet.RowCount - 1
            vS1.SetViewportTopRow(0, vS1.ActiveSheet.RowCount - 1)
            vS1.ActiveSheet.ActiveRowIndex = xrow

            Call READ_SPREAD(vS1, DS1, "USP_ISUD4367A_SEARCH_vS1", "VS1", xrow)

            If DATA_MOVE() = True Then
                Call DATA_CHECKCOMPLETE()
                Call DATA_SEARCH_VS1()

                DATA_SEARCH_VS1_INSERT = True
            Else
                MsgBoxP("Can not input!")
                vS1.ActiveSheet.RowCount -= 1
            End If

            Call Calculation()
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function K4073_CheckMethodDyeing5() As String

    End Function

    Private Sub K4073_CheckComplete(Check1 As Boolean, Check2 As Boolean, Check3 As Boolean, Check4 As Boolean, Check5 As Boolean, Check6 As Boolean)
      
    End Sub
    Private Sub K4073_CheckMethodDyeing5(Value As String)
    End Sub
    Private Sub K4073_CheckComplete(Value As String)
        
    End Sub

    Private Sub K4073_CheckComplete()
       
    End Sub

    Private Sub K4073_CheckProduction()
    End Sub

    Private Sub K4073_CheckProduction(Value As String)
    End Sub

    Private Function DATA_MOVE() As Boolean
        DATA_MOVE = False
        
    End Function

    Private Function DATA_INSERT_UPDATE() As Boolean
        DATA_INSERT_UPDATE = False
        Try

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

    Private Function DATA_CHECKCOMPLETE() As Boolean
        DATA_CHECKCOMPLETE = False

        Dim YRNO As Integer
        Dim Scol As Integer
        Dim FixCol As Integer
        Dim int_SumQty As Integer
        Dim i, j As Integer
        Dim SetKey As String
        Dim QtySetKey As String
        Dim BatchGroup As String

        YRNO = CIntp(Mid(System_Date_8(), 3, 6))

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K4367_SetKey,7,10) AS DECIMAL)) AS MAX_MCODE FROM PFK4367 "
            SQL = SQL & " WHERE SUBSTRING(K4367_SetKey,1,6) = '" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                SetKey = YRNO.ToString & "0001"
            Else
                SetKey = YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("0000")
            End If
            txt_SetKey.Data = SetKey

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try


        Dim List_Batch As New List(Of String)
        List_Batch.Clear()

        Try
            Scol = getColumIndex(vS1, "SizeQty01_S50")
            FixCol = getColumIndex(vS1, "SizeQty01_S50")

            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If CIntp(getDataM(vS1, i, 6)) > 0 And getDataM(vS1, i, 5) = "1" Then

                    int_SumQty += Math.Abs(CIntp(getDataM(vS1, i, 6)))
                End If
            Next

            QtySetKey = int_SumQty

            For j = 0 To vS0.ActiveSheet.RowCount - 1
                BatchGroup = getData(vS0, getColumIndex(vS0, "BatchGroup"), j)

                If List_Batch.Contains(BatchGroup) = False Then
                    List_Batch.Add(BatchGroup)

                    For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                        If CIntp(getDataM(vS1, i, 6)) > 0 And getDataM(vS1, i, 5) = "1" Then
                            Call PrcExeNoError("USP_PFK4367_INSERT_BARCODE_SETKEY", cn, SetKey _
                                                , QtySetKey _
                                                , txt_JobCard.Data _
                                                , (i - FixCol + 1).ToString("00") _
                                                , txt_DatePlan.Data _
                                                , "050" _
                                                , txt_cdFactory.Code _
                                                , txt_cdLineProd.Code _
                                                , BatchGroup _
                                                , Math.Abs(CIntp(getDataM(vS1, i, 6))))
                        End If
                    Next
                End If

            Next

            Call PrcExeNoError("CLOSING_ALL_SUB_PROCESS_COMPONENT_JOBCARD", cn, System_Date_8(), txt_JobCard.Data)


            DATA_CHECKCOMPLETE = True
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_CHECKSTATUS() As Boolean
        DATA_CHECKSTATUS = False
        
    End Function
    Private Sub KEY_COUNT_NO()
        Dim YRNO As Integer
        YRNO = Pub.DAT
    End Sub
#End Region


#Region "Event"

    Private Sub vS1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        Try
            Dim int_SumQty As Integer = 0

            Dim i As Integer
            Dim Scol As Integer
            Dim FixCol As Integer
            Scol = getColumIndex(vS1, "SizeQty01_S50")
            FixCol = getColumIndex(vS1, "SizeQty01_S50")


            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If CIntp(getDataM(vS1, i, 6)) > 0 And getDataM(vS1, i, 5) = "1" Then

                    int_SumQty += Math.Abs(CIntp(getDataM(vS1, i, 6)))
                End If
            Next

            txt_BatchSizeQ.Value = int_SumQty

        Catch ex As Exception

        End Try

    End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles vS1.LostFocus
        Try
            Dim int_SumQty As Integer = 0

            Dim i As Integer
            Dim Scol As Integer
            Dim FixCol As Integer
            Scol = getColumIndex(vS1, "SizeQty01_S50")
            FixCol = getColumIndex(vS1, "SizeQty01_S50")


            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If CIntp(getDataM(vS1, i, 6)) > 0 And getDataM(vS1, i, 5) = "1" Then

                    int_SumQty += Math.Abs(CIntp(getDataM(vS1, i, 6)))
                End If
            Next

            txt_BatchSizeQ.Value = int_SumQty

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles vS1.CellClick
        Try
            Dim int_SumQty As Integer = 0

            Dim i As Integer
            Dim Scol As Integer
            Dim FixCol As Integer
            Scol = getColumIndex(vS1, "SizeQty01_S50")
            FixCol = getColumIndex(vS1, "SizeQty01_S50")


            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If CIntp(getDataM(vS1, i, 6)) > 0 And getDataM(vS1, i, 5) = "1" Then

                    int_SumQty += Math.Abs(CIntp(getDataM(vS1, i, 6)))
                End If
            Next

            txt_BatchSizeQ.Value = int_SumQty

        Catch ex As Exception

        End Try


    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Try
            Dim int_SumQty As Integer = 0

            Dim i As Integer
            Dim Scol As Integer
            Dim FixCol As Integer
            Scol = getColumIndex(vS1, "SizeQty01_S50")
            FixCol = getColumIndex(vS1, "SizeQty01_S50")


            For i = Scol To vS1.ActiveSheet.ColumnCount - 1
                If CIntp(getDataM(vS1, i, 6)) > 0 And getDataM(vS1, i, 5) = "1" Then

                    int_SumQty += Math.Abs(CIntp(getDataM(vS1, i, 6)))
                End If
            Next

            txt_BatchSizeQ.Value = int_SumQty

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

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Select
                Call DATA_CHECKCOMPLETE()
                Call MsgBoxP("Insert Succesfully!", vbInformation)
                Call DATA_SEARCH_VS1()

                Call DATA_SEARCH_VS2()
                Me.Dispose()

            Case 2
                Me.Dispose()
            Case 3
                'If Data_Check() = False Then Exit Select

                'If txt_DatePlan.Data <> Pub.DAT Then
                '    MsgBoxP("Can not edit because of not today!")
                '    If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub
                'End If

                'Call DATA_CHECKCOMPLETE()
                'Call MsgBoxP("Update Succesfully!", vbInformation)
                'Call DATA_SEARCH_VS1()
                'Call DATA_SEARCH_VS2()
            Case 4
                Call DATA_DELETE()

            Case 5
                Call DATA_CHECKSTATUS()
                Me.Dispose()
        End Select

    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click

        If CHK(4) <> "1" Then MsgBoxP("You have no right in this program!") : Exit Sub
        Msg_Result = MsgBoxP("Do you want to delete all worksheet?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub

        'If MsgBoxPPW("Please type the password to modify!", "002") = False Then Exit Sub

        Try
            Call DATA_DELETE()
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_DEL_Click")
        End Try
    End Sub


    Private Sub txt_GreyBarcode_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If wJOB = 1 Then
                txt_Barcode.Data = Trim(txt_Barcode.Data)

                If READ_PFK4175_BatchGroup(txt_Barcode.Data) = True Then
                    txt_JobCard.Data = D4175.JobCard
                    Call DATA_SEARCH_HEAD()

                    Call DATA_SEARCH_vS0()
                    Call DATA_SEARCH_VS1()
                    Call DATA_SEARCH_VS2()

                    Me.Show()

                    Application.DoEvents()
                    Setfocus(txt_Barcode)
                    Exit Sub
                End If

                If Trim(txt_Barcode.Data).Length >= 8 Then
                    If READ_PFK7171_NAME(ListCode("Season"), Strings.Left(txt_Barcode.Data, 4)) Then

                        If READ_PFK4010_SLNO_SEASON(D7171.BasicCode, Strings.Mid(txt_Barcode.Data, 5)) = True Then
                            txt_JobCard.Data = D4010.JobCard
                            Call DATA_SEARCH_HEAD()

                            Call DATA_SEARCH_vS0()
                            Call DATA_SEARCH_VS1()
                            Call DATA_SEARCH_VS2()

                            Me.Show()

                            Application.DoEvents()
                            Setfocus(txt_Barcode)
                            Exit Sub
                        End If
                    End If

                End If


                If READ_PFK4175_BatchGroup(txt_Barcode.Data) = False Then
                    If READ_PFK4010(txt_Barcode.Data) Then
                        txt_JobCard.Data = D4010.JobCard

                        Call DATA_SEARCH_HEAD()

                        Call DATA_SEARCH_vS0()
                        Call DATA_SEARCH_VS1()
                        Call DATA_SEARCH_VS2()

                        Me.Show()

                        Application.DoEvents()
                        Setfocus(txt_Barcode)
                        Exit Sub

                    End If
                End If

                Call MsgBoxP("Check data of barcode !") : txt_Barcode.Data = ""

            End If
        End If
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False
        If txt_cdFactory.Code = "" Then MsgBoxEx("Factory !") : Exit Function
        If txt_cdLineProd.Code = "" Then MsgBoxEx("Line !") : Exit Function

        Data_Check = True
    End Function


  Private Sub txt_cdLineProd_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdLineProd.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            Setfocus(cmd_OK)
        End If
    End Sub


#End Region
  


    
    
End Class