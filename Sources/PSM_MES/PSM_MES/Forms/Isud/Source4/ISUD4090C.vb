Public Class ISUD4090C

#Region "Variable"
    Private wJOB As Integer

    Private W4090 As New T4090_AREA
    Private L4090 As New T4090_AREA


    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"
    Public Function Link_ISUD4090C(job As Integer, cdMainProcess As String, ProdDate As String, ProdSeq As String, _
                                                                            JobCard As String, cdFactory As String, cdLineProd As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        ProdDate = FormatCut(ProdDate)

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Code = D7171.BasicCode
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Enabled = False
        End If

        If READ_PFK7171(ListCode("Factory"), cdFactory) Then
            txt_cdFactory.Code = D7171.BasicCode
            txt_cdFactory.Data = D7171.BasicName
            'txt_cdFactory.Enabled = False
        End If

        If READ_PFK7171(ListCode("LineProd"), cdLineProd) Then
            txt_cdLineProd.Code = D7171.BasicCode
            txt_cdLineProd.Data = D7171.BasicName
            txt_cdLineProd.Enabled = False
        End If

        If READ_PFK7171(ListCode("MainProcess"), "001") Then
            txt_cdMainProcess.Code = D7171.BasicCode
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Enabled = False
        End If

        txt_cdSubProcess.Code = "028"
        txt_cdSubProcess.Data = "Outsole Output"
        txt_cdSubProcess.Enabled = False

        D4090.cdMainProcess = cdMainProcess
        D4090.ProdDate = ProdDate
        D4090.ProdSeq = ProdSeq

        D4090.JobCard = JobCard
        D4090.cdFactory = cdFactory
        D4090.cdLineProd = cdLineProd

        wJOB = job : L4090 = D4090

        Link_ISUD4090C = False
        Try

            Select Case job
                Case 1

                Case Else
                    txt_Barcode.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4090C = isudCHK

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
            Case 1
                Me.Text = Me.Text & " - INSERT"

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Show()

                'Call DATA_SEARCH_VS1()

                Application.DoEvents()

                txt_ProdDate.Data = Pub.DAT
                txt_ProdDate.Code = Pub.DAT

                txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                txt_TimeMaterialOutBound.Code = System_Date_time()

                cmd_DEL.Visible = False

                Setfocus(txt_Barcode)

                cmd_OK.Visible = False
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                'Call DATA_SEARCH_VS1()

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

                'Call DATA_SEARCH_VS1()

                txt_Barcode.Enabled = True

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

                'Call DATA_SEARCH_VS1()

                cmd_DEL.Visible = True

                cmd_OK.Visible = False
        End Select

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Dim Starting As Object

        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            DS1 = PrcDS("USP_ISUD4090C_SEARCH_VS1", cn, L4090.ProdDate, _
                                                        L4090.cdFactory, _
                                                        L4090.cdLineProd, _
                                                        L4090.cdMainProcess)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD4090C_SEARCH_VS1", "vS1")

                vS1.Enabled = True

                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD4090C_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        Finally
            Starting.close()
        End Try
    End Function

#End Region

#Region "Function"

    Private Function DATA_MOVE_K4090_LINE(xRow As Integer) As Boolean
        DATA_MOVE_K4090_LINE = False

        Try
            DATA_MOVE_K4090_LINE = True
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_K4090_LINE!")
        End Try
    End Function

    Private Sub DATA_DELETE()
        Dim i As Integer

        If getData(vS1, getColumIndex(vS1, "KEY_ProdDate"), i) = "" Then Exit Sub

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If getDataM(vS1, getColumIndex(vS1, "DCHK"), i) = "1" Then
                    DATA_LINE_DELETE(i)
                End If
            Next

            Call DATA_SEARCH_VS1()

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub
    Private Sub DATA_LINE_DELETE(xrow As Integer)
        Try

            If READ_PFK4090(FormatCut(getData(vS1, getColumIndex(vS1, "KEY_ProdDate"), xrow)),
                            getData(vS1, getColumIndex(vS1, "KEY_ProdSeq"), xrow)) = True Then
                W4090 = D4090

                If DELETE_PFK4090(W4090) = True Then
                    isudCHK = True
                End If

            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
            txt_ProdDate.Data = FSDate(L4090.ProdDate)
            txt_ProdDate.Code = FormatCut(L4090.ProdDate)
            txt_ProdSeq.Data = L4090.ProdSeq

            Setfocus(txt_Barcode)
            txt_Mess.Enabled = True
            txt_Mess.ReadOnly = True
            Me.WindowState = FormWindowState.Maximized

            If READ_PFK7411(Pub.SAW) Then
                txt_InchargeProdution.Data = D7411.Name
                txt_InchargeProdution.Code = D7411.IDNO
                txt_InchargeProdution.Enabled = False
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

        L4090.ProdDate = YRNO

        Try
            SQL = "SELECT MAX(CAST(ISNULL(K4090_ProdSeq, 0) AS DECIMAL)) AS MAX_MCODE FROM PFK4090 "
            SQL = SQL & " WHERE K4090_ProdDate = '" & YRNO & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                W4090.ProdSeq = "001"
            Else
                W4090.ProdSeq = Format(CInt(rd!MAX_MCODE + 1), "000")
            End If

            rd.Close()

            txt_ProdSeq.Data = W4090.ProdSeq
            L4090.ProdSeq = W4090.ProdSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
            Case 2
                Me.Dispose()
            Case 3
            Case 4
        End Select
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



    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles vS1.Change
        Dim xCOL As Integer
        Dim xROW As Integer

        Try
            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)
        Catch ex As Exception

        End Try
    End Sub
    Private Sub vSChange(xROW As Integer)
        If wJOB = 2 Then Exit Sub
        Dim QtyOutBound As Integer
        Dim Barcode As String

        If READ_PFK4090(FormatCut(getData(vS1, getColumIndex(vS1, "KEY_ProdDate"), xROW)),
                           getData(vS1, getColumIndex(vS1, "KEY_ProdSeq"), xROW)) = True Then
            W4090 = D4090

            Barcode = W4090.BatchNo


        End If


    End Sub
    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Dim xCol As Long
        Dim xRow As Long

        xCol = vS1.ActiveSheet.ActiveColumnIndex
        xRow = vS1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Insert
                If getData(vS1, getColumIndex(vS1, "KEY_ProdDate"), vS1.ActiveSheet.RowCount - 1) <> "" Then
                    vS1.ActiveSheet.RowCount += 1
                    vS1.ActiveSheet.ActiveRowIndex = vS1.ActiveSheet.RowCount - 1
                End If

            Case Keys.Delete
                If getData(vS1, getColumIndex(vS1, "KEY_ProdDate"), xRow) = "" Then
                    Call SPR_DEL(vS1, 0, xRow)
                    Exit Sub
                End If

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)
                If Msg_Result <> vbYes Then Exit Sub

                Call DATA_LINE_DELETE(xRow)
                Call SPR_DEL(vS1, 0, xRow)

                vS1.Focus()

        End Select


    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS1.ButtonClicked
        Dim xRow As Integer
        Dim xCol As Integer

        xRow = e.Row
        xCol = e.Column


    End Sub
    Private Function CheckBalance() As Boolean
        CheckBalance = False
        Try
            Dim StrMsg As String

            CheckBalance = True
        Catch ex As Exception

        End Try

    End Function
    Private Sub txt_Barcode_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = True

            If txt_Barcode.Data = "" Then
                Setfocus(txt_Barcode)
                Exit Sub
            End If

            If txt_cdFactory.Code = "" Then
                MsgBoxP("Factory Plz!")
                Setfocus(txt_cdFactory)
                Exit Sub
            End If

            txt_Barcode.Code = FormatCut(txt_Barcode.Data)

            If Len(txt_Barcode.Code) <> 10 Then
                txt_Mess.Text = "BARCODE KHÔNG TỒN TẠI!"
                txt_Mess.ForeColor = Color.Red

                Me.Show()
                Application.DoEvents()

                txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                txt_TimeMaterialOutBound.Code = System_Date_time()

                Setfocus(txt_Barcode)

                Exit Sub
            End If

            L4090.BatchNo = ""
            L4090.BatchNo = txt_Barcode.Code

            If READ_PFK4075_BatchNo(L4090.BatchNo) Then

                L4090.ProdDate = Pub.DAT
                L4090.cdFactory = txt_cdFactory.Code
                L4090.cdLineProd = txt_cdLineProd.Code
                L4090.cdMainProcess = txt_cdMainProcess.Code
                L4090.cdSubProcess = txt_cdSubProcess.Code

                If D4075.cdFactory = "051" Then

                    DS1 = PrcDS("USP_PFK4090A_INSERT_AUTO_PRODUCTION_OUTSOLE_OUTPUT", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, L4090.BatchNo, txt_InchargeProdution.Code)
                Else
                    DS1 = PrcDS("USP_PFK4090A_INSERT_AUTO_PRODUCTION_OUTSOLE_OUTPUT_OT", cn, txt_cdFactory.Code, txt_cdSubProcess.Code, L4090.BatchNo, txt_InchargeProdution.Code)

                End If

                If GetDsData(DS1, 0, 0).Contains("THÀNH CÔNG :  TĂNG") = False Then

                    txt_Mess.Text = GetDsData(DS1, 0, 0)
                    txt_Mess.ForeColor = Color.Red

                    tim_30.Start()
                    txt_T30.Data = 5

                    txt_Barcode.TextEnabled = True
                    txt_Barcode.Data = ""
                    txt_Barcode.Code = ""

                    Me.Show()
                    Application.DoEvents()

                    txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                    txt_TimeMaterialOutBound.Code = System_Date_time()

                    Setfocus(txt_Barcode)

                    Exit Sub

                Else
                    txt_Mess.Text = GetDsData(DS1, 0, 0)
                    txt_Mess.ForeColor = Color.Blue

                    tim_30.Start()
                    txt_T30.Data = 5

                End If

                txt_Barcode.TextEnabled = True
                txt_Barcode.Data = ""
                txt_Barcode.Code = ""

                Me.Show()

                Application.DoEvents()

                txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                txt_TimeMaterialOutBound.Code = System_Date_time()

                Setfocus(txt_Barcode)

            Else

                txt_Barcode.TextEnabled = True
                txt_Barcode.Data = ""
                txt_Barcode.Code = ""

                txt_Mess.Text = "BARCODE KHÔNG TỒN TẠI!"
                txt_Mess.ForeColor = Color.Red
                Me.Show()
                Application.DoEvents()

                txt_TimeMaterialOutBound.Data = FSDateTime(System_Date_time())
                txt_TimeMaterialOutBound.Code = System_Date_time()

                Setfocus(txt_Barcode)


            End If
        End If



    End Sub

    Private Sub tim_30_Tick(sender As Object, e As EventArgs) Handles tim_30.Tick
        Try
            txt_T30.Data = CIntp(txt_T30.Data) - 1

            If txt_T30.Data <= 0 Then
                tim_30.Stop()
                txt_T30.Data = 5

                txt_Mess.Text = ""
                txt_Mess.Text = ""

            End If
        Catch ex As Exception
            tim_30.Stop()
        End Try

    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then Call DATA_SEARCH_VS1()
    End Sub

#End Region


End Class