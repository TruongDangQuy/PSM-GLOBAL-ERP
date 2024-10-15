Imports System.Media
Imports System.Runtime.InteropServices
Public Class ISUD4367B
    <DllImport("kernel32.dll")>
    Public Shared Function Beep(ByVal freq As Integer, ByVal duration As Integer) As Boolean

    End Function

#Region "Variable"
    Private wJOB As Integer

    Private wDateProd As String
    Private wcdFactory As String
    Private wcdMainProcess As String
    Private wcdSubProcess As String
    Private wcdLineProd As String
    Private wBatchGroup As String



    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Form"

    Public Function Link_ISUD4367B(job As Integer, DateProd As String, cdFactory As String, cdMainProcess As String, cdLineProd As String, BatchGroup As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        wDateProd = DateProd
        wcdFactory = cdFactory
        wcdMainProcess = cdMainProcess
        wcdLineProd = cdLineProd
        wBatchGroup = BatchGroup
        wcdSubProcess = "001"

        wJOB = job

        Link_ISUD4367B = False
        Try

            Select Case job
                Case 3
                    txt_Barcode_Box.Enabled = False
                Case Else
                    txt_Barcode_Box.Enabled = True
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4367B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4367B"))
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

                Call DATA_SEARCH_HEAD_INSERT()

                txt_Barcode_Box.Enabled = True

                Application.DoEvents()

                cmd_OK.Visible = True
                cmd_OK.Enabled = True

                cmd_DEL.Visible = False

                Setfocus(txt_Barcode_Box)

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD_INSERT()


                txt_Barcode_Box.Data = wBatchGroup
                txt_Barcode_Box.Enabled = False

                Call DATA_SEARCH_VS1()

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

                txt_Barcode_Box.Data = wBatchGroup
                txt_Barcode_Box.Enabled = False

                If DATA_SEARCH_HEAD_INSERT() = True Then
                    Call DATA_SEARCH_VS1()
                End If

                cmd_OK.Visible = True
                cmd_OK.Enabled = True
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

                txt_Barcode_Box.Data = wBatchGroup
                txt_Barcode_Box.Enabled = False

                Call DATA_SEARCH_HEAD_INSERT()
                Call DATA_SEARCH_VS1()
                cmd_DEL.Visible = True

                cmd_OK.Visible = False
            Case 11

        End Select

        formA = True
    End Sub

#End Region

#Region "Search"

    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False


        If READ_PFK7171("300", wcdFactory) = True Then
            txt_cdFactory.Data = D7171.BasicName
            txt_cdFactory.Code = D7171.BasicCode
        End If

        If READ_PFK7171("301", wcdLineProd) = True Then
            txt_cdLineProd.Data = D7171.BasicName
            txt_cdLineProd.Code = D7171.BasicCode
        End If

        If READ_PFK7171("001", wcdMainProcess) = True Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode
        End If

        txt_InchargeProdution.Data = "SYSTEM"
        txt_InchargeProdution.Code = "PSMADMIN"

        DATA_SEARCH_HEAD_INSERT = True

    End Function

    Private Function DATA_INSERT_CUTTING(Szno As String, DateProduction As String, cdSubProcess As String, cdFactory As String, cdLineProd As String, InchargeProdution As String, BatchGroup As String, Optional Qty_Job As Integer = 0) As Boolean
        DATA_INSERT_CUTTING = False

        Try
            DS1 = PrcDS("USP_ISUD4367B_INSERT_BATCHGROUP", cn, Szno, _
                                                                DateProduction,
                                                                cdSubProcess,
                                                                cdFactory,
                                                                cdLineProd,
                                                                InchargeProdution,
                                                                BatchGroup,
                                                                Qty_Job)
            DATA_INSERT_CUTTING = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        Try
            DS1 = PrcDS("USP_ISUD4367B_SEARCH_vS1", cn, wDateProd, _
                                                        wcdFactory, _
                                                        wcdLineProd, _
                                                        wcdSubProcess, _
                                                        txt_Barcode_Box.Data)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD4367B_SEARCH_vS1", "vS1")

                vS1.ActiveSheet.RowCount = 1
                vS1.Enabled = True

                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD4367B_SEARCH_vS1", "vS1")

            Call DATA_SEARCH_VS1_INSERT_MATERIALNAME(txt_Barcode_Box.Data)

            DATA_SEARCH_VS1 = True


            Setfocus(txt_Barcode_Box)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT(BatchGroup As String) As Boolean
        DATA_SEARCH_VS1_INSERT = False


        Try
            DS1 = PrcDS("USP_ISUD4367B_SEARCH_vS1_INSERT", cn, wDateProd, _
                                                        wcdFactory, _
                                                        wcdLineProd, _
                                                        wcdSubProcess, _
                                                        BatchGroup)


            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.Normal)
                SPR_PRO(vS1, DS1, "USP_ISUD4367B_SEARCH_vS1_INSERT", "vS1")

                vS1.ActiveSheet.RowCount = 0
                vS1.Enabled = True

                txt_Mess.Text = "KHÔNG TÌM THẤY SỐ LƯỢNG CỦA BARCODE"
                txt_Mess.ForeColor = Color.Red

                Setfocus(txt_Barcode_Box)

                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.Normal)
            SPR_PRO(vS1, DS1, "USP_ISUD4367B_SEARCH_vS1_INSERT", "vS1")

            txt_Mess.Text = ""

            vS1.Focus()

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1_INSERT")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT_MATERIALNAME(BatchGroup As String) As Boolean
        DATA_SEARCH_VS1_INSERT_MATERIALNAME = False


        Try
            DS1 = PrcDS("USP_ISUD43670_SEARCH_vS1_INSERT_MATERIALNAME", cn, BatchGroup)


            If GetDsRc(DS1) = 0 Then
                txt_MaterialName.Text = ""
                Exit Function
            End If

            txt_MaterialName.Text = CStrp(GetDsData(DS1, 0, 0))
            DATA_SEARCH_VS1_INSERT_MATERIALNAME = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1_INSERT_MATERIALNAME")
        End Try
    End Function

#End Region

#Region "Function"


    Private Sub DATA_INIT()
        Try
            'txt_DateProd.Data = FormatCut(wDateProd)
            'txt_DateProd.Code = FormatCut(wDateProd)

            txt_DateProd.Data = FormatCut(System_Date_8())
            txt_DateProd.Code = FormatCut(System_Date_8())

            txt_Barcode_Box.Data = ""

            txt_Mess.Text = ""


            Setfocus(txt_Barcode_Box)

            vS1.InsChk = False
            RemoveHandler txt_Barcode_Box.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub



#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                Call DATA_INSERT()
                Setfocus(txt_Barcode_Box)
            Case 2
                Me.Dispose()
            Case 3
                Dim i As Integer
                Dim Autokey As String

                Dim QtyProduction As String

                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    If Trim(getDataM(vS1, getColumIndex(vS1, "DCHK"), i)) = "1" Then
                        Autokey = getData(vS1, getColumIndex(vS1, "KEY_Autokey"), i)
                        QtyProduction = CDecp(getData(vS1, getColumIndex(vS1, "QtyProduction"), i))

                        SQL = " UPDATE PFK4367 SET "
                        SQL = SQL & "    K4367_QtyProduction      = N'" & FormatSQL(QtyProduction) & "', "
                        SQL = SQL & "    K4367_QtyProductionA      = N'" & FormatSQL(QtyProduction) & "', "
                        SQL = SQL & "    K4367_QtyProductionLA      = N'" & FormatSQL(QtyProduction) & "', "
                        SQL = SQL & "    K4367_QtyProductionRA      = N'" & FormatSQL(QtyProduction) & "' "
                        SQL = SQL & " WHERE K4367_Autokey		 = '" & Autokey & "' "

                        cmd = New SqlClient.SqlCommand(SQL, cn)
                        cmd.ExecuteNonQuery()

                    End If
                Next

                Call PrcExeNoError("CLOSING_ALL_SUB_PROCESS_COMPONENT_JOBCARD_COMPONENT_BATCHGROUP", cn, System_Date_8(), Trim$(txt_Barcode_Box.Data))

                Me.Dispose()
            Case 4
                Me.Dispose()
        End Select
    End Sub


    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_CANCEL.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click

        If txt_DateProd.Data <> Pub.DAT Then
            MsgBoxP("Not today! Can't delete!")
            Exit Sub
        Else
            Call DATA_DELETE()
            Me.Dispose()
        End If


    End Sub
    Private CntS As Integer

    Private Sub txt_Barcode_Box_txtTextGotFocus(sender As Object, e As EventArgs) Handles txt_Barcode_Box.txtTextGotFocus

        Me.Show()
        Application.DoEvents()
        txt_Barcode_Box.PeaceTextbox1.Select()
        txt_Barcode_Box.PeaceTextbox1.SelectAll()
    End Sub


    Private Sub txt_Barcode_Box_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode_Box.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then

            e.Handled = True
            Call DATA_SEARCH_VS1_INSERT_MATERIALNAME(Trim$(txt_Barcode_Box.Data))
            Call DATA_SEARCH_VS1_INSERT(Trim$(txt_Barcode_Box.Data))
        End If

    End Sub

    Private Function DATA_INSERT() As Boolean

        Dim bWrite_chek As Boolean
        Dim i As Integer

        Dim Szno As String
        Dim DateProduction As String
        Dim cdSubProcess As String
        Dim cdFactory As String
        Dim cdLineProd As String
        Dim InchargeProdution As String
        Dim BatchGroup As String
        Dim Qty_Job As Integer

        DATA_INSERT = False

        Try

            bWrite_chek = False
            If Trim$(txt_Barcode_Box.Data) <> "" Then
                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    If Trim(getDataM(vS1, getColumIndex(vS1, "DCHK"), i)) = "1" Then
                        Szno = getData(vS1, getColumIndex(vS1, "Szno"), i)
                        DateProduction = txt_DateProd.Data.Replace("/", "")
                        cdSubProcess = wcdSubProcess
                        cdFactory = wcdFactory
                        cdLineProd = wcdLineProd
                        InchargeProdution = txt_InchargeProdution.Code
                        BatchGroup = Trim$(txt_Barcode_Box.Data)

                        Qty_Job = CDecp(getData(vS1, getColumIndex(vS1, "QtyScan"), i))


                        If DATA_INSERT_CUTTING(Szno, DateProduction, cdSubProcess, cdFactory, cdLineProd, InchargeProdution, BatchGroup, Qty_Job) = False Then
                            Setfocus(txt_Barcode_Box)
                            bWrite_chek = False
                            GoTo step1
                        End If



                    End If
                Next
                bWrite_chek = True
            End If

step1:

            If bWrite_chek = True Then
                txt_Mess.Text = "QUÉT SẢN LƯỢNG THÀNH CÔNG!"
                txt_Mess.ForeColor = Color.Blue
            Else
                txt_Mess.Text = "QUÉT SẢN LƯỢNG CÓ LỖI VUI LÒNG KIỂM TRA LẠI!"
                txt_Mess.ForeColor = Color.Red
            End If

            Call DATA_SEARCH_VS1()

            DATA_INSERT = True

        Catch ex As Exception
            txt_Mess.Text = "QUÉT SẢN LƯỢNG CÓ LỖI VUI LÒNG KIỂM TRA LẠI!"
            txt_Mess.ForeColor = Color.Red
        End Try

    End Function


    Private Function DATA_DELETE() As Boolean
        DATA_DELETE = False

        Try


            If Trim$(txt_Barcode_Box.Data) <> "" Then

                DS1 = PrcDS("USP_ISUD4367B_DELETE_BATCHGROUP", cn, txt_DateProd.Data,
                                                                wcdFactory,
                                                                wcdLineProd,
                                                                wcdSubProcess,
                                                                txt_Barcode_Box.Data)

                If GetDsData(DS1, 0, 0) = "1" Then
                    txt_Mess.Text = CStrp(GetDsData(DS1, 0, 1))
                    txt_Mess.ForeColor = Color.Blue
                End If

                If GetDsData(DS1, 0, 0) = "0" Then
                    txt_Mess.Text = CStrp(GetDsData(DS1, 0, 1))
                    txt_Mess.ForeColor = Color.Red
                End If
            End If
            DATA_DELETE = True

            Call Delete_History("PFK4367B", txt_DateProd.Data & "-" & wcdFactory & "-" & wcdLineProd & "-" & wcdSubProcess & "-" & txt_Barcode_Box.Data)

        Catch ex As Exception
            txt_Mess.Text = "XÓA SẢN LƯỢNG CÓ LỖI VUI LÒNG KIỂM TRA LẠI!"
            txt_Mess.ForeColor = Color.Red
        End Try

    End Function

    Private Function DATA_DELETE_LINE(xRow As Integer) As Boolean
        DATA_DELETE_LINE = False

        Dim Szno As String

        Dim Autokey As String = 0

        Szno = getData(vS1, getColumIndex(vS1, "Szno"), xRow)
        Autokey = getData(vS1, getColumIndex(vS1, "KEY_Autokey"), xRow)

        Try


            If Trim$(txt_Barcode_Box.Data) <> "" Then

                'DS1 = PrcDS("USP_ISUD4367B_DELETE_BATCHGROUP_SZNO", cn, txt_DateProd.Data,
                '                                                wcdFactory,
                '                                                wcdLineProd,
                '                                                wcdSubProcess,
                '                                                txt_Barcode_Box.Data,
                '                                                Szno)


                DS1 = PrcDS("USP_ISUD4367B_DELETE_AUTOKEY", cn, txt_DateProd.Data,
                                                              wcdFactory,
                                                              wcdLineProd,
                                                              wcdSubProcess,
                                                              txt_Barcode_Box.Data,
                                                              Autokey)

                If GetDsData(DS1, 0, 0) = "1" Then
                    txt_Mess.Text = CStrp(GetDsData(DS1, 0, 1))
                    txt_Mess.ForeColor = Color.Blue
                End If

                If GetDsData(DS1, 0, 0) = "0" Then
                    txt_Mess.Text = CStrp(GetDsData(DS1, 0, 1))
                    txt_Mess.ForeColor = Color.Red
                End If
            End If
            DATA_DELETE_LINE = True

            Call Delete_History("PFK4367B", txt_DateProd.Data & "-" & wcdFactory & "-" & wcdLineProd & "-" & wcdSubProcess & "-" & txt_Barcode_Box.Data & "-" & Autokey)

        Catch ex As Exception
            txt_Mess.Text = "XÓA SẢN LƯỢNG CÓ LỖI VUI LÒNG KIỂM TRA LẠI!"
            txt_Mess.ForeColor = Color.Red
        End Try

    End Function

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        Dim xCol As Long
        Dim xRow As Long

        xCol = vS1.ActiveSheet.ActiveColumnIndex
        xRow = vS1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)
                If Msg_Result <> vbYes Then Exit Sub
                If txt_DateProd.Data <> Pub.DAT Then
                    MsgBoxP("Not today! Can't delete!")
                    Exit Sub
                Else

                    If getData(vS1, getColumIndex(vS1, "KEY_Autokey"), xRow) <> "0" Then
                        Call DATA_DELETE_LINE(xRow)
                    End If
                    Call SPR_DEL(vS1, 0, xRow)
                End If

        End Select

    End Sub

#End Region


End Class
