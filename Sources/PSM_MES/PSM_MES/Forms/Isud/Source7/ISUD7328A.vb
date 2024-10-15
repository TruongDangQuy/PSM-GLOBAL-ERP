Public Class ISUD7328A
#Region "Variable"
    Private wJOB As Integer

    Private W7328 As T7328_AREA
    Private L7328 As T7328_AREA

    Private W7329 As T7329_AREA
    Private L7329 As T7329_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7328A(job As Integer, cdMainProcess As String, cdSubProcess As String, JobBOMCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7328.JobBOMCode = JobBOMCode
        D7328.cdMainProcess = cdMainProcess
        D7328.cdSubProcess = cdSubProcess
        wJOB = job : L7328 = D7328

        Link_ISUD7328A = False

        If READ_PFK7171(ListCode("MainProcess"), cdMainProcess) Then
            txt_cdMainProcess.Data = D7171.BasicName
            txt_cdMainProcess.Code = D7171.BasicCode
        End If

        If READ_PFK7171(ListCode("SubProcess"), cdSubProcess) Then
            txt_cdSubProcess.Data = D7171.BasicName
            txt_cdSubProcess.Code = D7171.BasicCode
        End If

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7328(L7328.JobBOMCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7328A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("JobBOMCode"))
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
            Case 1
                Me.Text = Me.Text & " - INSERT"
                Setfocus(txt_JobBOMName)
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH02()
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If


                txt_JobBOMCode.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH02()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_JobBOMCode.Enabled = False
            Call D7328_CLEAR()
            W7328 = D7328

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            DS1 = READ_PFK7328(L7328.JobBOMCode, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function : Me.Dispose()
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            If READ_PFK7171(GetDsData(DS1, 0, "K7328_selSeasonCode"), GetDsData(DS1, 0, "K7328_cdSeasonCode")) Then
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Data = D7171.BasicName
            End If

            If GetDsData(DS1, 0, "K7328_CheckUse") = "1" Then
                rad_CheckUse1.Checked = True
                rad_CheckUse2.Checked = False
            Else
                rad_CheckUse1.Checked = False
                rad_CheckUse2.Checked = True
            End If

            Call DATA_SEARCH_IMAGE()

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_IMAGE() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH_IMAGE = False

        DATA_SEARCH_IMAGE = True

        DS2 = PrcDS("USP_ISUD7555A_SEARCH_VS1", cn, "PFK" + Strings.Mid(Me.Name, 5, 4), L7328.JobBOMCode)


        SPR_PRO_NEW(vS_Image, DS2, "USP_ISUD7555A_SEARCH_VS1", "Vs1")
    End Function

    Private Sub vS_Image_CellClick(sender As Object, e As CellClickEventArgs) Handles vS_Image.CellDoubleClick
        Dim strSql As String = ""

        Try
            downLoadFile()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DS1 = PrcDS("USP_ISUD7328A_SEARCH_VS1", cn, L7328.JobBOMCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD7328A_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7328A_SEARCH_VS1", "Vs1")

        DATA_SEARCH02 = True


    End Function

#End Region

#Region "Function"
    Private Sub downLoadFile()
        Dim sFileName As String
        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "Select K7555_ImageData from [PFK7555] "
            strSql = strSql & "WHERE [K7555_TABLE]= '" & getData(vS_Image, getColumIndex(vS_Image, "Key_TABLE"), vS_Image.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7555_PAREMETER]= '" & getData(vS_Image, getColumIndex(vS_Image, "Key_PAREMETER"), vS_Image.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7555_SEQ]= '" & getData(vS_Image, getColumIndex(vS_Image, "KEY_SEQ"), vS_Image.ActiveSheet.ActiveRowIndex) & "'"

            Dim sqlCmd As New SqlClient.SqlCommand(strSql, cn)

            sFileName = getData(vS_Image, getColumIndex(vS_Image, "FileName"), vS_Image.ActiveSheet.ActiveRowIndex)
            sFileName &= "." & getData(vS_Image, getColumIndex(vS_Image, "FileType"), vS_Image.ActiveSheet.ActiveRowIndex)

            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & sFileName

            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New System.IO.FileStream(sFileName, System.IO.FileMode.OpenOrCreate, System.IO.FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()
                End Using

                'Open File

                Process.Start(sFileName)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try
            If txt_JobBOMName.Data.Trim = "" Then Setfocus(txt_JobBOMName) : Exit Function
            txt_JobBOMName.Data = Replace(txt_JobBOMName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7328(L7328.JobBOMCode) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_JobBOMCode.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If


            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            Call K7328_MOVE(Me, W7328, 1, txt_JobBOMCode.Code)

            W7328.seMainProcess = ListCode("MainProcess")
            W7328.seSubProcess = ListCode("SubProcess")
            W7328.seOrderGroup = ListCode("OrderGroup")
            W7328.seSeason = ListCode("Season")
            W7328.seShoesKind = ListCode("ShoesKind")
            W7328.seShoesType = ListCode("ShoesType")
            W7328.seSoleKind = ListCode("SoleKind")

            If rad_CheckUse1.Checked = True Then W7328.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7328.CheckUse = "2"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

            SQL = "DELETE FROM PFK7329 "
            SQL = SQL & " WHERE K7329_JobBOMCode  = '" & W7328.JobBOMCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1

                Call D7329_CLEAR() : W7329 = D7329
                Call K7329_MOVE(Vs1, i, W7329, W7329.JobBOMCode, W7329.JobBOMSeq)

                W7329.JobBOMCode = L7328.JobBOMCode
                W7329.JobBOMSeq = j
                W7329.Dseq = j

                W7329.seGroupJobProcess = ListCode("GroupJobProcess")

                Call WRITE_PFK7329(W7329)
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK7328(W7328) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK7328(W7328) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK7328(L7328.JobBOMCode) = True Then
                W7328 = D7328

                SQL = "DELETE FROM PFK7329 "
                SQL = SQL & " WHERE K7329_JobBOMCode  = '" & W7328.JobBOMCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK7328(W7328)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7328_JobBOMCode AS DECIMAL)) as MAX_CODE FROM PFK7328 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7328.JobBOMCode = "000001"
            Else
                W7328.JobBOMCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_JobBOMCode.Data = W7328.JobBOMCode
            L7328.JobBOMCode = W7328.JobBOMCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7328") = False Then Exit Sub
                'If Data_Check() = False Then Exit Sub
                Call KEY_COUNT()
                Call DATA_INSERT()

                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()

                Setfocus(txt_JobBOMName)
                SPR_CLEAR(Vs1, True)
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7328") = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4
                Call DATA_DELETE()
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

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()
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

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(Vs1, xCOL, xROW)
                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

            Case Keys.Enter

        End Select
    End Sub



    Private Sub txt_cdBaseBOM_Load(sender As Object, e As EventArgs) Handles txt_cdBaseBOM.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7328A.Link_HLP7328A(txt_cdMainProcess.Code, txt_cdSubProcess.Code) = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7328A_SEARCH_VS1", cn, hlp0000SeVaTt)

        DS2 = READ_PFK7328(hlp0000SeVaTt, cn)
        DS2.Tables(0).Columns.Remove("K7328_JobBOMCode")

        Call READER_MOVE(Me, DS2)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7328A_SEARCH_VS1", "VS1")
    End Sub

    Private Sub cmd_AttachID_Click(sender As Object, e As EventArgs) Handles cmd_AttachID.Click
        Call DATA_SEARCH_IMAGE()
    End Sub
#End Region



    
End Class