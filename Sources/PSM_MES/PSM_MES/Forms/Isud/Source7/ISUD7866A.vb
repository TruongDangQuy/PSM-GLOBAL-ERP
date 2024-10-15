Imports System.Data.SqlClient
Imports System.IO
Public Class ISUD7866A
    Private wJOB As Integer

    Private W7866 As T7866_AREA
    Private L7866 As T7866_AREA


    Private WRITE_CHK As String
    Private KEY_SEQ As String

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Public Function Link_ISUD7866A(job As Integer, BugCode As String, ProjectCode As String) As Boolean
        Link_ISUD7866A = False

        D7866.BugCode = BugCode
        D7866.cdProject = ProjectCode

        If READ_PFK7171(ListCode("Project"), ProjectCode) Then
            txt_cdProject.Code = D7171.BasicCode
            txt_cdProject.Data = D7171.BasicName
        Else
            Exit Function
        End If

        wJOB = job : L7866 = D7866


        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7866(L7866.BugCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function

                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7866A = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("PROCESS PRODUCTION PROCESSING"))
        End Try


    End Function

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                txt_BugCode.Code = L7866.BugCode


                Frame1.Enabled = True
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Call MsgBoxP("You have no right is this program !")
                    Me.Dispose()
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                Setfocus(txt_BugFunction)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Call MsgBoxP("You have no right is this program !")
                    Me.Dispose()
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

            Case 3
                Me.Text = Me.Text & " - UPDATE"



                Frame1.Enabled = True

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Call MsgBoxP("You have no right is this program !")

                        Me.Dispose()
                        Exit Sub
                    Else
                        Call MsgBoxP("You have no right is this program !")
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2

                        Frame1.Enabled = False
                        cmd_DEL.Visible = False
                    End If
                End If

                If READ_PFK7171("012", L7866.BugCode) = True Then
                    txt_cdProject.Data = D7171.BasicName
                End If

            Case 4                                                      '»èÁ¦
                Me.Text = Me.Text & " - DELETE"

                Frame1.Enabled = False

                If CHK(4) <> "1" Then
                    Call MsgBoxP("You have no right is this program !")
                    Me.Dispose()
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
                Call DATA_SEARCH_VS2()

        End Select

        formA = True
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False

        Try
            ' 1. Complete & Data Confirm

            If rad_CheckStatus5.Checked And txt_InchargeConfirm.Code = "" Then MsgBoxP("Confirm Incharge !") : Exit Function
            If rad_CheckStatus1.Checked = False And FormatCut(txt_DateConfirm.Data) = "" Then MsgBoxP("Confirm Date !") : Exit Function
            If rad_CheckStatus1.Checked = False And FormatCut(txt_DateAccept.Data) = "" Then MsgBoxP("Accept Date !") : Exit Function

            If txt_BugFunction.Data.Trim = "" Then Setfocus(txt_BugFunction) : MsgBoxP("txt_BugFunction !") : Exit Function
            If txt_cdProject.Code.Trim = "" Then Setfocus(txt_cdProject) : MsgBoxP("txt_cdProject!") : Exit Function
            If txt_cdDepartment.Code.Trim = "" Then Setfocus(txt_cdDepartment) : MsgBoxP("txt_cdDepartment !") : Exit Function
            If txt_cdModule.Code.Trim = "" Then Setfocus(txt_cdModule) : MsgBoxP("txt_cdModule !") : Exit Function

            txt_BugFunction.Data = Replace(txt_BugFunction.Data, "'", "`")


            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK7866(L7866.BugCode, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K7866_CheckComplete") = "1" Or GetDsData(DS1, 0, "K7866_CheckStatus") = "5" Then
            chk_CheckComplete1.Checked = True
            cmd_OK.Visible = False
            cmd_DEL.Visible = False
        Else
            chk_CheckComplete2.Checked = True
        End If

        If GetDsData(DS1, 0, "K7866_CheckBugType") = "1" Then rad_CheckBugType1.Checked = True Else rad_CheckBugType2.Checked = True

        If GetDsData(DS1, 0, "K7866_CheckStatus") = "1" Then rad_CheckStatus1.Checked = True
        If GetDsData(DS1, 0, "K7866_CheckStatus") = "2" Then rad_CheckStatus2.Checked = True
        If GetDsData(DS1, 0, "K7866_CheckStatus") = "3" Then rad_CheckStatus3.Checked = True
        If GetDsData(DS1, 0, "K7866_CheckStatus") = "4" Then rad_CheckStatus4.Checked = True
        If GetDsData(DS1, 0, "K7866_CheckStatus") = "5" Then rad_CheckStatus5.Checked = True

        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        If rad_Data.Checked Then DS1 = PrcDS("USP_ISUD7866A_SEARCH_VS1", cn, L7866.BugCode, "1") Else DS1 = PrcDS("USP_ISUD7866A_SEARCH_VS1", cn, L7866.BugCode, "2")

        If GetDsRc(DS1) = 0 Then
            SPR_PRO(Vs1, DS1, "USP_ISUD7866A_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True

            Exit Function
        End If

        SPR_PRO(Vs1, DS1, "USP_ISUD7866A_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True
    End Function
    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        DATA_SEARCH_VS2 = True
    End Function

    Private Sub DATA_MOVE()
        W7866.BugCode = txt_BugCode.Data
        W7866.BugFunction = txt_BugFunction.Data
        W7866.BugName = txt_BugName.Data

        W7866.cdDepartment = txt_cdDepartment.Code
        W7866.cdProject = txt_cdProject.Code
        W7866.cdModule = txt_cdModule.Code

        W7866.seDepartment = ListCode("Department")
        W7866.seProject = ListCode("Project")
        W7866.seModule = ListCode("Module")

        W7866.InchargeAccept = txt_InchargeAccept.Code
        W7866.InchargeConfirm = txt_InchargeConfirm.Code

        W7866.BugCode_001 = txt_BugCode_001.Data
        W7866.DateAccept = txt_DateAccept.Data

        W7866.BugExplain = txt_BugExplain.Data
        W7866.BugContent = txt_BugContent.Data

        W7866.DateAccept = txt_DateAccept.Data
        W7866.DateStart = txt_DateStart.Data
        W7866.DateFinish = txt_DateFinish.Data
        W7866.DateConfirm = txt_DateConfirm.Data

        If rad_CheckBugType1.Checked Then W7866.CheckBugType = "1" Else W7866.CheckBugType = "2"
        If chk_CheckComplete1.Checked Then W7866.CheckComplete = "1" Else W7866.CheckComplete = "2"

        If rad_CheckStatus1.Checked Then W7866.CheckStatus = "1" : W7866.InchargeConfirm1 = Pub.SAW : W7866.DateConfirm1 = Pub.DAT
        If rad_CheckStatus2.Checked Then W7866.CheckStatus = "2" : W7866.InchargeConfirm2 = Pub.SAW : W7866.DateConfirm2 = Pub.DAT
        If rad_CheckStatus3.Checked Then W7866.CheckStatus = "3" : W7866.InchargeConfirm3 = Pub.SAW : W7866.DateConfirm3 = Pub.DAT
        If rad_CheckStatus4.Checked Then W7866.CheckStatus = "4" : W7866.InchargeConfirm4 = Pub.SAW : W7866.DateConfirm4 = Pub.DAT

        If rad_CheckStatus5.Checked Then W7866.CheckStatus = "5" : W7866.DateFinish = Pub.DAT Else W7866.DateFinish = ""

    End Sub

    Private Sub DATA_MOVE_WRITE01()


    End Sub
    Private Sub DATA_MOVE_WRITE02()



    End Sub

    Private Sub DATA_INSERT()
        Try
            Call KEY_COUNT()
            Call DATA_MOVE()

            W7866.DateInsert = Pub.DAT
            W7866.InchargeInsert = Pub.SAW
            If WRITE_PFK7866(W7866) = True Then
                Call DATA_MOVE_WRITE01()
                Call DATA_MOVE_WRITE02()
                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try

            If READ_PFK7866(L7866.BugCode) Then
                W7866 = D7866
            End If

            Call DATA_MOVE()

            W7866.DateUpdate = Pub.DAT
            W7866.InchargeUpdate = Pub.SAW

            If REWRITE_PFK7866(W7866) = True Then
                Call DATA_MOVE_WRITE01()
                Call DATA_MOVE_WRITE02()
                isudCHK = True

            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK7866(L7866.BugCode) = True Then
                W7866 = D7866

                Call DELETE_PFK7866(W7866)


            End If

            isudCHK = True : Me.Dispose() : Exit Sub

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7866_BugCode AS DECIMAL)) as MAX_CODE FROM PFK7866 "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7866.BugCode = "000001"
            Else
                W7866.BugCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            L7866.BugCode = W7866.BugCode
            txt_BugCode.Code = W7866.BugCode
            txt_BugCode.Data = W7866.BugCode
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_INIT()
        Try
            Call D7866_CLEAR()
            W7866 = D7866
            txt_BugCode.Enabled = False
            Vs1.InsChk = True

            txt_DateAccept.Data = Pub.DAT
            txt_DateStart.Data = Pub.DAT
            txt_DateFinish.Data = Pub.DAT
            txt_DateConfirm.Data = Pub.DAT

            Vs1.CopyPasteChk = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        rad_Data.Visible = True
        TableLayoutPanel5.Visible = True
        rad_Solution.Visible = True
    End Sub


    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                Call MsgBoxP("Insert Succesfully!", vbInformation)

                Msg_Result = MsgBox("Continue input ?", vbYesNo)
                If Msg_Result = vbNo Then
                    wJOB = 3
                Else
                    wJOB = 1
                    txt_BugCode.Data = ""
                    txt_BugFunction.Data = ""

                    txt_cdModule.Code = ""
                    txt_cdModule.Data = ""

                    txt_InchargeAccept.Code = ""
                    txt_InchargeConfirm.Code = ""
                    txt_InchargeAccept.Data = ""
                    txt_InchargeConfirm.Data = ""

                    txt_BugCode_001.Data = ""
                    txt_DateAccept.Data = ""

                    txt_BugExplain.Data = ""
                    txt_BugContent.Data = ""

                    txt_DateAccept.Data = ""
                    txt_DateStart.Data = ""
                    txt_DateFinish.Data = ""
                    Call DATA_INIT()
                    KEY_COUNT()
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()


                End If



            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
                Call MsgBoxP("Update Succesfully!", vbInformation)

                Msg_Result = MsgBox("Continue input ?", vbYesNo)
                If Msg_Result = vbYes Then
                    wJOB = 1
                    txt_BugCode.Data = ""
                    txt_BugFunction.Data = ""

                    txt_cdModule.Code = ""
                    txt_cdModule.Data = ""

                    txt_InchargeAccept.Code = ""
                    txt_InchargeConfirm.Code = ""
                    txt_InchargeAccept.Data = ""
                    txt_InchargeConfirm.Data = ""

                    txt_BugCode_001.Data = ""
                    txt_DateAccept.Data = ""

                    txt_BugExplain.Data = ""
                    txt_BugContent.Data = ""

                    txt_DateAccept.Data = ""
                    txt_DateStart.Data = ""
                    txt_DateFinish.Data = ""
                    Call DATA_INIT()
                    KEY_COUNT()
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()
                End If


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
        Call GROUP_SETTING(Me.Tag, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

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

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim strSql As String = ""

        Try
            If e.Column = getColumIndex(sender, "DoucmentName") Then Exit Sub

            downLoadFile(sender)


        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub

    Private Sub downLoadFile(sender As Object)
        Dim sFileName As String
        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "Select K7867_ImageData from [PFK7867] "
            strSql = strSql & "WHERE [K7867_BugCode]= '" & getData(sender, getColumIndex(sender, "Key_BugCode"), sender.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7867_SEQ]= '" & getData(sender, getColumIndex(sender, "KEY_SEQ"), sender.ActiveSheet.ActiveRowIndex) & "'"

            Dim sqlCmd As New SqlCommand(strSql, cn)

            sFileName = getData(sender, getColumIndex(sender, "FileName"), sender.ActiveSheet.ActiveRowIndex)
            sFileName &= "." & getData(sender, getColumIndex(sender, "FileType"), sender.ActiveSheet.ActiveRowIndex)

            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            Dim sTempFileName As String = System.IO.Path.GetTempPath & sFileName

            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New FileStream(sTempFileName, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(fileData, 0, fileData.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()
                End Using

                'Open File

                Process.Start(sTempFileName)

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Msg_Result = MsgBoxP("Do you want to delete?", vbYesNo)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(Vs1, xCOL, xROW)
                Vs1.Focus()


        End Select

        If e.Control = True And e.KeyCode = Keys.V Then
            Dim BugCode As String
            BugCode = txt_BugCode.Data

            If READ_PFK7866(BugCode) Then
                Call PastePicture(BugCode)

            Else
                MsgBoxP("No bUG Code!")
            End If

        End If

    End Sub
    Private Function ReadFile(ByVal sPath As String) As Byte()

        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Dim fInfo As New FileInfo(sPath)
        Dim numBytes As Long = fInfo.Length

        'Open FileStream to read file 
        Dim fStream As New FileStream(sPath, FileMode.Open, FileAccess.Read)

        'Use BinaryReader to read file stream into byte array. 
        Dim br As New BinaryReader(fStream)

        'When you use BinaryReader, you need to supply number of bytes to read from file. 
        'In this case we want to read entire file. So supplying total number of bytes. 
        data = br.ReadBytes(CInt(numBytes))

        Return data
    End Function
    Private Sub KEY_COUNT_IMAGE(BugCode As String)
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(K7867_SEQ) AS MAX_CODE FROM [PFK7867] "
        SQL = SQL & " WHERE K7867_BugCode     = '" + BugCode + "'"


        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            KEY_SEQ = 1
        Else
            KEY_SEQ = CIntp(rd!MAX_CODE + 1)
        End If

        rd.Close()
    End Sub
    Private Sub PastePicture(BugCode As String)
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Dim SqlCom As SqlCommand
        Dim MaxByte As Integer = 1024 * 1024 * 2
        Dim imageData As Byte()
        Dim sFileName As String
        Dim qry As String
        Dim sFileType As String

        Dim CntFile As Integer

        Dim StrConvert As String

        CntFile = Clipboard.GetFileDropList.Count

        Try
            For i As Integer = 0 To CntFile - 1

                'Convert File to bytes Array
                imageData = ReadFile(Clipboard.GetFileDropList(i))

                StrConvert = StrReverse(Clipboard.GetFileDropList(i))
                sFileType = Strings.Left(StrConvert, StrConvert.IndexOf(".", 0))

                sFileType = StrReverse(sFileType)

                If imageData.Length > MaxByte And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
                'Set insert query 
                qry = "insert into [PFK7867] ([K7867_BugCode],[K7867_SEQ],[K7867_FileName],[K7867_DoucmentName],[K7867_ImageData]," & _
                "[K7867_FileType],[K7867_AttachDate],[K7867_AttachIncharge],[K7867_Time],K7867_CheckType) values (@BugCode, @SEQ,@FileName,@DoucmentName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time,@CheckType)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT_IMAGE(BugCode)

                sFileName = KEY_SEQ
                sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

                SqlCom.Parameters.Add(New SqlParameter("@BugCode", BugCode))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))
                SqlCom.Parameters.Add(New SqlParameter("@DoucmentName", sFileName))


                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))

                If rad_Data.Checked = True Then
                    SqlCom.Parameters.Add(New SqlParameter("@CheckType", "1"))
                Else
                    SqlCom.Parameters.Add(New SqlParameter("@CheckType", "2"))
                End If


                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))
                SqlCom.ExecuteNonQuery()

                'Execute the Query


            Next

            Call DATA_SEARCH_VS1()

        Catch ex As Exception

            MessageBox.Show(ex.ToString())

        Finally
            Starting.Close()


        End Try


    End Sub
    Private Sub rad_Data_CheckedChanged(sender As Object, e As EventArgs) Handles rad_Data.CheckedChanged, rad_Solution.CheckedChanged
        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub cmd_Download_Click(sender As Object, e As EventArgs) Handles cmd_Download.Click
        Dim sFileName As String
        Dim strSql As String
        Dim i As Integer

        Dim SaveFile As New SaveFileDialog

        'Open the File Dialog to select the file
        If (SaveFile.ShowDialog(Me) = DialogResult.OK) Then

            If Strings.Right(SaveFile.FileName, 1) <> "$" Then MsgBoxP("Wrong ID!") : Exit Sub

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                'SaveFile.FileName = getData(Vs1, getColumIndex(Vs1, "FileName"), i)
                'For Document
                Try
                    'Get image data from gridview column. 
                    strSql = "Select K7867_ImageData from [PFK7867] "
                    strSql = strSql & "WHERE [K7867_BugCode]= '" & getData(Vs1, getColumIndex(Vs1, "Key_BugCode"), i) & "'"
                    strSql = strSql & "AND   [K7867_SEQ]= '" & getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), i) & "'"

                    Dim sqlCmd As New SqlCommand(strSql, cn)

                    sFileName = getData(Vs1, getColumIndex(Vs1, "FileName"), i)

                    'Get image data from DB
                    Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

                    Dim sTempFileName As String = Strings.Left(SaveFile.FileName, Len(SaveFile.FileName) - 1) & getData(Vs1, getColumIndex(Vs1, "FileName"), i) & "." & getData(Vs1, getColumIndex(Vs1, "FileType"), i) ' System.IO.Path.GetTempPath & "\" & sFileName

                    If Not fileData Is Nothing Then

                        'Read image data into a file stream 
                        Using fs As New FileStream(sTempFileName, FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(fileData, 0, fileData.Length)
                            'Set image variable value using memory stream. 
                            fs.Flush()
                            fs.Close()
                        End Using

                        'Open File


                    End If



                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
        End If
    End Sub

End Class