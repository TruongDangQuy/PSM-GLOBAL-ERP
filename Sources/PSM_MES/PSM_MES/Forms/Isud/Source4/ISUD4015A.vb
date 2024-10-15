
Public Class ISUD4015A

#Region "Variable"
    Private wJOB As Integer

    Private KEY_CHK As String
    Private WRITE_CHK As String

    Private W4015 As T4015_AREA
    Private L4015 As T4015_AREA

    Private formA As Boolean

    Private checkisud As Boolean

    Private CHK(0 To 5) As String

    Private strFormName As String
    Private Value As String = ""

#End Region

#Region "Link_ISUD"
    Public Function Link_ISUD4015A(job As Integer, JobCard As String, Optional CheckName As String = "") As Boolean
        If strFormName = "" Then strFormName = Me.Text
        Me.Tag = CheckName

        D4015.JobCard = JobCard
        txt_JobCard.Data = JobCard

        wJOB = job : L4015 = D4015

        Link_ISUD4015A = False

        Select Case job
            Case 1, 5, 6

            Case Else

        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD4015A = isudCHK
    End Function


#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Activated
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()
        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

begin:
        Select Case wJOB
            Case 1
                Me.Text = strFormName & " - INSERT"
                checkisud = False
                Call KEY_COUNT_NO()
                cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_vS1()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                wJOB = 3
                checkisud = True
            Case 2
                Me.Text = strFormName & " - SEARCH"
                checkisud = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                'Call DisableAllType()

                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_vS1()

            Case 3
                Me.Text = strFormName & " - UPDATE"
                checkisud = True
                cmd_DEL.Visible = False

                Call DATA_SEARCH_HEAD()

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_vS1()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

            Case 4
                Me.Text = strFormName & " - DELETE"
                cmd_DEL.Visible = True

                checkisud = True
                cmd_OK.Visible = False

                Call DATA_SEARCH_HEAD()

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_vS1()

                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = strFormName & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If


            Case 11
                Me.Text = strFormName & " - AUTO"
                checkisud = False

                Call KEY_COUNT_NO()
                cmd_DEL.Visible = False

                Call DATA_SEARCH_vS0()
                Call DATA_SEARCH_vS1()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                checkisud = True

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        KEY_CHK = ""


    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        DS1 = PrcDS("USP_ISUD4015A_SEARCH_HEAD", cn, txt_JobCard.Data)

        If GetDsRc(DS1) = 0 Then Exit Function

        Call STORE_MOVE(Me, DS1)

        DS1 = Nothing

        DATA_SEARCH_HEAD = True

    End Function

    Private Function DATA_SEARCH_vS0() As Boolean
        DATA_SEARCH_vS0 = False

        DS1 = PrcDS("USP_ISUD4015A_SEARCH_vS0", cn, txt_JobCard.Data)

        vS0.Enabled = True

        Dim i As Integer
        Dim j As Integer

        vS0.ActiveSheet.RowCount = GetDsCc(DS1)
        vS0.ActiveSheet.ColumnCount = 2

        For i = 0 To 1
            For j = 0 To GetDsCc(DS1) - 1
                setData(vS0, i, j, GetDsData(DS1, i, j))
            Next
        Next

        SPR_WIDTHCOL(vS0, 0, 50)
        SPR_WIDTHCOL(vS0, 1, 100)

        SPR_NUMBERCOLUMN(vS0, 0, 0, 1)

        vS0.ActiveSheet.OperationMode = OperationMode.SingleSelect
        SPR_TOTALHEAD(vS0, 1, 1)
        DS1 = Nothing

        DATA_SEARCH_vS0 = True
    End Function
    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False
        Dim Szno As String
        Szno = vS0.ActiveSheet.ActiveRowIndex.ToString("00")

        DS1 = PrcDS("USP_ISUD4015A_SEARCH_vS1", cn, txt_JobCard.Data, Szno)

        vS1.Enabled = True

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD4015A_SEARCH_vS1", "vS1")
            vS1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_ISUD4015A_SEARCH_vS1", "vS1")
        vS1.Enabled = True

        DATA_SEARCH_vS1 = True
    End Function


#End Region

#Region "Function"

    Private Sub KEY_COUNT_NO()
        If KEY_CHK = "*" Then Exit Sub
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)


        SQL = "SELECT MAX(CAST(K4015_BarcodeSeq AS DECIMAL)) AS MAX_MCODE FROM PFK4015 "
        SQL = SQL & " WHERE K4015_JobCard = '" & txt_JobCard.Data & "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4015.BarcodeSeq = 1
        Else
            L4015.BarcodeSeq = CIntp(rd!MAX_MCODE + 1)
        End If

        W4015.JobCard = txt_JobCard.Data
        W4015.BarcodeSeq = L4015.BarcodeSeq
        rd.Close()

    End Sub

    Private Sub KEY_COUNT_BARCODE()

        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 2)


        SQL = "SELECT MAX(CAST(SUBSTRING(K4015_BarcodeScan,3,9) AS DECIMAL)) AS MAX_MCODE FROM PFK4015 "
        SQL = SQL & " WHERE LEFT(K4015_JobCard,2) = '" & YRNO.ToString & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L4015.BarcodeScan = YRNO.ToString & "000000001"
        Else
            L4015.BarcodeScan = YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("000000000")
        End If

        W4015.BarcodeScan = L4015.BarcodeScan
        rd.Close()

    End Sub
    Private Function DATA_MOVE_K4015() As Boolean
        DATA_MOVE_K4015 = False
        Try
            Call PrcExe("USP_PFK4015_GENERATE_BARCODE", cn, txt_JobCard.Data)

            DATA_MOVE_K4015 = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Function

#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Select Case wJOB
                Case 1 ' Insert

                    If checkisud = False Then
                        If DataCheck(Me, "PFK4015") = False Then MsgBoxP("Fill correct data !") : Exit Sub

                        If DATA_MOVE_K4015() = True Then
                            Call DATA_SEARCH_vS1()
                            checkisud = True
                        End If

                    End If
                Case 2 ' Search
                    Me.Dispose()

                Case 3 ' Update
                    If checkisud = False Then
                        If DataCheck(Me, "PFK4015") = False Then MsgBoxP("Fill correct data !") : Exit Sub

                        If DATA_MOVE_K4015() = True Then
                            Call DATA_SEARCH_vS1()
                        End If
                        checkisud = True
                    Else
                        If DataCheck(Me, "PFK4015") = False Then Exit Sub

                        If DATA_MOVE_K4015() = True Then
                            Call DATA_SEARCH_vS1()
                        End If

                        checkisud = True
                    End If
            End Select
        Catch ex As Exception
            MsgBoxP("Has error in saving this item!")
        End Try

    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If wJOB = 2 Then
            isudCHK = False
            Me.Dispose()
        Else
            isudCHK = True
            Me.Dispose()
        End If
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If
        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

    End Sub

    Private Sub vS0_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS0.CellDoubleClick
        Call DATA_SEARCH_vS1()
    End Sub

#End Region

#Region "Print"
    Public Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        gpp = e.Graphics
        Call TAG_PRINT_STITCHING_PANEL()
    End Sub
    Private CheckEven As Boolean = False
    Private CheckEnd As Boolean = False
    Private Sub cmd_BarCode_Click(sender As Object, e As EventArgs) Handles cmd_BarCode.Click
        Dim Msg_Result As String
        Dim i As Integer
        Dim j As Integer
        Dim SizeNo As Integer
        Dim Cnt As Integer

        Try
            Msg_Result = MsgBoxP("TAG PRINT?", vbYesNo)
            If Msg_Result = vbYes Then
                For i = 0 To vS1.ActiveSheet.RowCount - 1
                    If getDataM(vS1, getColumIndex(vS1, "DCHK"), i) = "1" Then

                        If READ_PFK4015(getData(vS1, getColumIndex(vS1, "KEY_JobCard"), i),
                                               getData(vS1, getColumIndex(vS1, "KEY_BarcodeSeq"), i)) = True Then
                            W4015 = D4015

                            If W4015.BarcodeScan = "" Then KEY_COUNT_BARCODE()

                            W4015.DateUpdate = Pub.DAT

                            If REWRITE_PFK4015(W4015) Then
                                Cnt += 1
                                If (Cnt Mod 2) = 0 Then

                                    Call DATA_MOVE_BARCODE_2(getData(vS1, getColumIndex(vS1, "KEY_JobCard"), i),
                                        getData(vS1, getColumIndex(vS1, "KEY_BarcodeSeq"), i))

                                    Call DATA_MOVE_BARCODE()
                                    STITCHINGPANEL1 = Nothing
                                    STITCHINGPANEL2 = Nothing

                                Else

                                    Call DATA_MOVE_BARCODE_1(getData(vS1, getColumIndex(vS1, "KEY_JobCard"), i),
                                         getData(vS1, getColumIndex(vS1, "KEY_BarcodeSeq"), i))


                                End If

                            End If

                        End If


next1:

                    End If
                Next i

                If (Cnt Mod 2) = 1 Then
                    Call DATA_MOVE_BARCODE()
                End If


            End If
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try
    End Sub

    Public Sub DATA_MOVE_BARCODE()


        Try
            If chk_Preview = False Then
                PrintDocument1 = New Printing.PrintDocument
                PrintDocument1.Print()

            Else
                PrintDocument1 = New Printing.PrintDocument
                PrintDocument1.Print()

            End If
        Catch ex As Exception
            MsgBoxP("DATA_MOVE_BARCODE")
        End Try

    End Sub

    Public Sub DATA_MOVE_BARCODE_1(JobCard As String, BarcodeSeq As String)
        If READ_PFK4015(JobCard, BarcodeSeq) Then
            If READ_PFK7104(txt_SizeRange.Data) Then
                STITCHINGPANEL1.SizeName = SizeNameFull(D4015.SizeNo)
            End If

            STITCHINGPANEL1.JobCard = JobCard
            STITCHINGPANEL1.BarcodeSeq = BarcodeSeq

            STITCHINGPANEL1.Article = txt_Article.Data
            STITCHINGPANEL1.Line = txt_Line.Data
            STITCHINGPANEL1.Color = txt_Color.Data

            STITCHINGPANEL1.DatePrint = Pub.DAT
            STITCHINGPANEL1.SealNo = txt_SealNo.Data
            STITCHINGPANEL1.Barcode = D4015.BarcodeScan
        End If

    End Sub

    Public Sub DATA_MOVE_BARCODE_2(JobCard As String, BarcodeSeq As String)
        If READ_PFK4015(JobCard, BarcodeSeq) Then
            If READ_PFK7104(txt_SizeRange.Data) Then
                STITCHINGPANEL2.SizeName = SizeNameFull(D4015.SizeNo)
            End If

            STITCHINGPANEL2.JobCard = JobCard
            STITCHINGPANEL2.BarcodeSeq = BarcodeSeq

            STITCHINGPANEL2.Article = txt_Article.Data
            STITCHINGPANEL2.Line = txt_Line.Data
            STITCHINGPANEL1.Color = txt_Color.Data

            STITCHINGPANEL2.DatePrint = Pub.DAT
            STITCHINGPANEL2.SealNo = txt_SealNo.Data
            STITCHINGPANEL2.Barcode = D4015.BarcodeScan

        End If
    End Sub
#End Region

End Class