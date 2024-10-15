Imports System.Data.SqlClient
Imports System.IO
Public Class PFP99011

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    'Private a9271() As T9271_AREA
    'Private b9271() As T9271_AREA
    Private Form_Close As Boolean

    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private KEY_SEQ As String

    Private formA As Boolean

    Private CHK(0 To 5) As String
    Private W9271 As T9271_AREA

    Private FormName As String
    Private Parameter As String
    Private cdFactory As String
#End Region

#Region "Formload"
    Private strPWC As String
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        strPWC = ""

        If FPassWord.Link_PassWord = True Then
            strPWC = PASSWORDCHECK
            PASSWORDCHECK = ""
        End If


        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

        cms_1.Items.Clear()

        Call Cms_additem(cms_1,
                     "TREEVIEW PROCCESING - " & WordConv("NEW FOLDER") & "(F5)",
                     "TREEVIEW PROCCESING - " & WordConv("RENAME FOLDER") & "(F6)",
                     "TREEVIEW PROCCESING - " & WordConv("DELETE FOLDER") & "(F7)",
                     "TREEVIEW PROCCESING - " & WordConv("REFESH") & "(F8)")

    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()

    End Sub
    Private Sub DATA_INIT()
        Call DATA_SEARCH01()
    End Sub

#End Region

#Region "Link_ISUD"
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F12 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub MAIN_JOB01()

        If getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex) <> "" Then Exit Sub

        If ISUD9901A.Link_ISUD9901A(1, System_Date_8, 0, Me.Name) = False Then Exit Sub
        DATA_SEARCH01()

    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9901A.Link_ISUD9901A(2, getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "NotifyCateSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        DATA_SEARCH01()

    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9901A.Link_ISUD9901A(3, getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "NotifyCateSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9901A.Link_ISUD9901A(4, getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, getColumIndex(Vs1, "NotifyCateSeq"), Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
        DATA_SEARCH01()
    End Sub
    Private Sub MAIN_JOB05()
        'If getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9900A.Link_ISUD9900A(3, "", "", Me.Name) = False Then Exit Sub
        DATA_SEARCH01()
    End Sub
#End Region

#Region "EVENT"

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Row < 0 Then Exit Sub
        Vs2.Enabled = False
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row

        Dim NotifyCate As String = getData(Vs1, getColumIndex(Vs1, "NotifyCate"), e.Row)
        Dim NotifyCateSeq As String = getData(Vs1, getColumIndex(Vs1, "NotifyCateSeq"), e.Row)


        hlp0000SeVaTt = NotifyCate
        hlp0000SeVaTt1 = NotifyCateSeq
        Call DATA_SEARCH02(NotifyCate, NotifyCateSeq)
        Vs2.Enabled = True
    End Sub

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("MODIFY") & "(F7)", WordConv("DELETE") & "(F8)")
    End Sub


    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                'Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vs2_GotFocus(sender As Object, e As EventArgs) Handles Vs2.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
            Vs1.ActiveSheet.ActiveRowIndex = 0
            DATA_SEARCH03()
        End If
    End Sub

#End Region

#Region "Solution"

    Private Sub DATA_DELETE()
        Msg_Result = MsgBoxP("Do you want to delete", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub

        Try
            Dim NotifyCate As String = getData(Vs2, getColumIndex(Vs2, "NotifyCate"), Vs2.ActiveSheet.ActiveRowIndex)
            Dim NotifyCateSeq As String = CDblp(getData(Vs2, getColumIndex(Vs2, "NotifyCateSeq"), Vs2.ActiveSheet.ActiveRowIndex))
            Dim Notify As String = getData(Vs2, getColumIndex(Vs2, "Notify"), Vs2.ActiveSheet.ActiveRowIndex)
            Dim NotifySeq As String = CDblp(getData(Vs2, getColumIndex(Vs2, "NotifySeq"), Vs2.ActiveSheet.ActiveRowIndex))

            If READ_PFK9902(NotifyCate, NotifyCateSeq, Notify, NotifySeq) = False Then Exit Sub

            SQL = "UPDATE PFK9902 SET "
            SQL = SQL & "  K9902_IsInsert = '0' "
            SQL = SQL & " WHERE K9902_NotifyCate = '" + NotifyCate + "'"
            SQL = SQL & " AND K9902_NotifyCateSeq = " + NotifyCateSeq + ""
            SQL = SQL & " AND K9902_Notify = '" + Notify + "'"
            SQL = SQL & " AND K9902_NotifySeq = " + NotifySeq + ""
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            'SPR_CLEAR(Vs2, Vs2.ActiveSheet.ActiveRowIndex, 0, Vs2.ActiveSheet.ActiveRowIndex, Vs2.ActiveSheet.ColumnCount - 1)
            'setData(Vs2, getColumIndex(Vs2, "FileName"), Vs2.ActiveSheet.ActiveRowIndex, "[DELETED]")
            Call MsgBoxP("Delete Successfully!", vbInformation)

            Call DATA_SEARCH02(NotifyCate, NotifyCateSeq)

        Catch ex As Exception

        End Try
    End Sub
    Private Function KEY_COUNT(NotifyCate As String, NotifyCateSeq As String, Notify As String) As String
        KEY_COUNT = ""
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Function

        SQL = "SELECT MAX(K9902_NotifySeq) MAX_CODE FROM PFK9902 WITH (NOLOCK) "
        SQL = SQL & " WHERE K9902_NotifyCate = '" + NotifyCate + "' AND K9902_NotifyCateSeq = " + NotifyCateSeq + " AND K9902_Notify = '" + Notify + "'"

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            KEY_COUNT = 1
        Else
            KEY_COUNT = CIntp(rd!MAX_CODE + 1)
        End If

        rd.Close()
    End Function

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP99001_SEARCH_vS1", cn, "0")

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP99001_SEARCH_vS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02(NotifyCate As String, NotifyCateSeq As String) As Boolean
        DATA_SEARCH02 = False

        Vs2.Enabled = False

        If NotifyCate Is Nothing And NotifyCateSeq Is Nothing Then
            Vs2.Enabled = True
            Vs2.ActiveSheet.RowCount = 0
        End If

        DS1 = PrcDS("USP_PFP99001_SEARCH_Vs2", cn, NotifyCate, NotifyCateSeq)

        If GetDsRc(DS1) = 0 Then
            Vs2.Enabled = True
            Vs2.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs2, DS1, "USP_PFP99001_SEARCH_Vs2", "Vs2")

        Vs2.Enabled = True
        DATA_SEARCH02 = True
    End Function

    Private Function DATA_SEARCH03() As Boolean
        DATA_SEARCH03 = False

        Vs2.Enabled = False

        Dim NotifyCate As String = getData(Vs1, getColumIndex(Vs1, "NotifyCate"), Vs1.ActiveSheet.ActiveRowIndex)
        Dim NotifyCateSeq As String = getData(Vs1, getColumIndex(Vs1, "NotifyCateSeq"), Vs1.ActiveSheet.ActiveRowIndex)

        If NotifyCate Is Nothing And NotifyCateSeq Is Nothing Then
            Vs2.Enabled = True
            Vs2.ActiveSheet.RowCount = 0
        End If

        DS1 = PrcDS("USP_PFP99001_SEARCH_Vs2", cn, NotifyCate, NotifyCateSeq)

        If GetDsRc(DS1) = 0 Then
            Vs2.Enabled = True
            Vs2.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs2, DS1, "USP_PFP99001_SEARCH_Vs2", "Vs2")

        Vs2.Enabled = True
        DATA_SEARCH03 = True
    End Function
#End Region

#Region "Event"
    Private Sub cmdUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click

        Me.lblUploadStatus.Data = ""

        If LTrim(RTrim(txtFileToUpload.Data)) = "" Then

            lblUploadStatus.Data = "Enter File Name"

            txtFileToUpload.Focus()

            Exit Sub

        End If

        'Call Upload Images Or File
        Dim sFileToUpload As String = ""

        sFileToUpload = LTrim(RTrim(txtFileToUpload.Data))

        Dim Extension As String = System.IO.Path.GetExtension(sFileToUpload)

        '//Call the Upload method based on the type of file

        If StrComp(Extension, ".bmp", CompareMethod.Text) = 0 Or _
        StrComp(Extension, ".jpg", CompareMethod.Text) = 0 Or _
        StrComp(Extension, ".jpeg", CompareMethod.Text) = 0 Or _
        StrComp(Extension, ".png", CompareMethod.Text) = 0 Or _
        StrComp(Extension, ".gif", CompareMethod.Text) = 0 Then

            upLoadImageOrFile(sFileToUpload, FormatCut(Extension))


        Else 'Pass the extension

            upLoadImageOrFile(sFileToUpload, Extension)

        End If

        Call DATA_SEARCH03()

    End Sub

    Private MaxByte As Integer = 1024 * 1024 * 20
    Private Sub upLoadImageOrFile(ByVal sFilePath As String, ByVal sFileType As String)
        Dim SqlCom As SqlCommand

        Dim imageData As Byte()
        Dim SysTempDate8 As String = System_Date_8()


        Dim sFileName As String
        Dim NotifyCate As String = hlp0000SeVaTt
        Dim NotifyCateSeq As String = hlp0000SeVaTt1
        Dim qry As String

        Try

            'Convert File to bytes Array
            imageData = ReadFile(sFilePath)
            If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 20 MB!") : Exit Sub
            sFileName = System.IO.Path.GetFileNameWithoutExtension(sFilePath)

            'Set insert query 
            qry = "INSERT INTO PFK9902( K9902_NotifyCate, K9902_NotifyCateSeq, K9902_Notify, K9902_NotifySeq, K9902_DSeq, K9902_cdFactory," & _
                "K9902_DoucmentName, K9902_FileName, K9902_ImageData, K9902_FileType, K9902_CheckMain, K9902_CheckType, K9902_AttachDate, K9902_AttachIncharge," & _
                "K9902_Time, K9902_IsInsert, K9902_DateInsert, K9902_DateUpdate)" & _
                "VALUES( @NotifyCate, @NotifyCateSeq, @Notify, @NotifySeq, @DSeq, @cdFactory," & _
                "@DoucmentName, @FileName, @ImageData, @FileType, @CheckMain, @CheckType, @AttachDate, @AttachIncharge, @Time, @IsInsert, @DateInsert, @DateUpdate)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)


            Dim NotifySeq = KEY_COUNT(NotifyCate, NotifyCateSeq, SysTempDate8)

            SqlCom.Parameters.Add(New SqlParameter("@NotifyCate", NotifyCate))
            SqlCom.Parameters.Add(New SqlParameter("@NotifyCateSeq", NotifyCateSeq))
            SqlCom.Parameters.Add(New SqlParameter("@Notify", SysTempDate8))
            SqlCom.Parameters.Add(New SqlParameter("@NotifySeq", NotifySeq))
            SqlCom.Parameters.Add(New SqlParameter("@DSeq", NotifySeq))
            SqlCom.Parameters.Add(New SqlParameter("@cdFactory", cdFactory))
            SqlCom.Parameters.Add(New SqlParameter("@DoucmentName", sFileName))
            SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))
            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))
            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@CheckMain", ""))
            SqlCom.Parameters.Add(New SqlParameter("@CheckType", ""))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.NAM))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))
            SqlCom.Parameters.Add(New SqlParameter("@IsInsert", "1"))
            SqlCom.Parameters.Add(New SqlParameter("@DateInsert", SysTempDate8))
            SqlCom.Parameters.Add(New SqlParameter("@DateUpdate", ""))


            'Execute the Query
            SqlCom.ExecuteNonQuery()


            lblUploadStatus.Data = "File uploaded successfully"

            Me.txtFileToUpload.Data = ""

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            lblUploadStatus.Data = "File could not uploaded"

        End Try


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

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click

        Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

            'Open the File Dialog to select the file
            If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then

                If OpenFileDialog.FilterIndex = 1 Then
                    txtFileToUpload.Data = OpenFileDialog.FileName
                Else
                    txtFileToUpload.Data = OpenFileDialog.FileName
                End If

            Else 'Cancel

                Exit Sub

            End If

        End Using

    End Sub

    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckPathExists = True

        openFileDialog.CheckFileExists = True

        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png"

        'openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|" + _
        '   "text files (*.text)|*.txt|doc files (*.doc)|*.doc;*.docx|pdf files (*.pdf)|*.pdf|excels files (*.xls,*.xlsx)|*.xls;*.xlsx|" + _
        '   "powerpoint files (*.ppt;*.pptx)|*.ppt;*.pptx"

        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function

    Private Sub downLoadFile(ByVal iFileId As Long, ByVal sFileName As String, ByVal sFileExtension As String)

        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "SELECT K9902_ImageData  FROM PFK9902  "
            strSql = strSql & "WHERE K9902_NotifyCate = '" + getData(Vs2, getColumIndex(Vs2, "NotifyCate"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   K9902_NotifyCateSeq = '" + getData(Vs2, getColumIndex(Vs2, "NotifyCateSeq"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   K9902_Notify = '" + getData(Vs2, getColumIndex(Vs2, "Notify"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   K9902_NotifySeq = '" + getData(Vs2, getColumIndex(Vs2, "NotifySeq"), Vs2.ActiveSheet.ActiveRowIndex) + "'"

            Dim sqlCmd As New SqlCommand(strSql, cn)

            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            Dim sTempFileName As String = Application.StartupPath & "\" & sFileName

            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New FileStream(sFileName, FileMode.OpenOrCreate, FileAccess.Write)
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

    Private Sub downLoadFile()
        Dim sFileName As String
        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "SELECT K9902_ImageData  FROM PFK9902  "
            strSql = strSql & "WHERE K9902_NotifyCate = '" + getData(Vs2, getColumIndex(Vs2, "NotifyCate"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   K9902_NotifyCateSeq = '" + getData(Vs2, getColumIndex(Vs2, "NotifyCateSeq"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   K9902_Notify = '" + getData(Vs2, getColumIndex(Vs2, "Notify"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   K9902_NotifySeq = '" + getData(Vs2, getColumIndex(Vs2, "NotifySeq"), Vs2.ActiveSheet.ActiveRowIndex) + "'"

            Dim sqlCmd As New SqlCommand(strSql, cn)

            sFileName = getData(Vs2, getColumIndex(Vs2, "FileName"), Vs2.ActiveSheet.ActiveRowIndex)
            sFileName &= "." & getData(Vs2, getColumIndex(Vs2, "FileType"), Vs2.ActiveSheet.ActiveRowIndex)

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
    Private Sub SaveFile()
        Dim sFileName As String
        Dim strSql As String

        Dim SaveFile As New SaveFileDialog
        SaveFile.FileName = getData(Vs2, getColumIndex(Vs2, "FileName"), Vs2.ActiveSheet.ActiveRowIndex)
        'Open the File Dialog to select the file
        If (SaveFile.ShowDialog(Me) = DialogResult.OK) Then
            ACTION_JOB05()

            'For Document
            Try
                'Get image data from gridview column. 
                strSql = "SELECT K9902_ImageData  FROM PFK9902  "
                strSql = strSql & "WHERE K9902_NotifyCate = '" + getData(Vs2, getColumIndex(Vs2, "NotifyCate"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
                strSql = strSql & "AND   K9902_NotifyCateSeq = '" + getData(Vs2, getColumIndex(Vs2, "NotifyCateSeq"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
                strSql = strSql & "AND   K9902_Notify = '" + getData(Vs2, getColumIndex(Vs2, "Notify"), Vs2.ActiveSheet.ActiveRowIndex) + "'"
                strSql = strSql & "AND   K9902_NotifySeq = '" + getData(Vs2, getColumIndex(Vs2, "NotifySeq"), Vs2.ActiveSheet.ActiveRowIndex) + "'"

                Dim sqlCmd As New SqlCommand(strSql, cn)

                sFileName = getData(Vs2, getColumIndex(Vs2, "FileName"), Vs2.ActiveSheet.ActiveRowIndex)

                'Get image data from DB
                Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

                Dim sTempFileName As String = SaveFile.FileName & getData(Vs2, getColumIndex(Vs2, "FileType"), Vs2.ActiveSheet.ActiveRowIndex) ' System.IO.Path.GetTempPath & "\" & sFileName

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

        End If
    End Sub
    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_Save.Click
        Call SaveFile()
    End Sub


    Private CntPic As Integer = 0
    Private ListPic As New List(Of String)
    Private ConstMargin As Integer = 10
    Dim NotifyCate As String = ""
    Dim NotifyCateSeq As String = ""
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs)
        PICTURE.PictureBox1.Image = sender.Image
        PICTURE.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PICTURE.ShowDialog()
    End Sub

    Private Sub cmd_Capture_Click(sender As Object, e As EventArgs) Handles cmd_Capture.Click
        If READ_PFK9271(FormName, Parameter) = False Then Exit Sub

        CheckSolution = True
        If frmSnipMain.frmSnipMain_Link(FormName, Parameter) = False Then Exit Sub
        Call DATA_SEARCH03()
    End Sub
    Private Sub Vs2_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs2.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call DATA_DELETE()
        End If
    End Sub

    Private Sub ISUD7555A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.V Then
            Call PastePicture()
        End If
    End Sub

    Private Sub PastePicture()
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")
        Dim SqlCom As SqlCommand

        Dim imageData As Byte()
        Dim sFileName As String
        Dim qry As String
        Dim sFileType As String
        Dim SysTempDate8 As String = System_Date_8()

        Dim CntFile As Integer

        Dim StrConvert As String

        CntFile = Clipboard.GetFileDropList.Count

        ACTION_JOB05()

        NotifyCate = hlp0000SeVaTt
        NotifyCateSeq = hlp0000SeVaTt1

        If NotifyCate Is Nothing And NotifyCateSeq Is Nothing Then MsgBoxP("Please select group of images!") : Exit Sub
        If NotifyCate = "" And NotifyCateSeq = "" Then MsgBoxP("Please select group of images!") : Exit Sub



        Try
            For i As Integer = 0 To CntFile - 1

                'Convert File to bytes Array
                imageData = ReadFile(Clipboard.GetFileDropList(i))

                StrConvert = StrReverse(Clipboard.GetFileDropList(i))
                sFileType = Strings.Left(StrConvert, StrConvert.IndexOf(".", 0))

                sFileType = StrReverse(sFileType)

                'If "*.bmp;*.jpg;*.jpeg;*.gif;*.png".ToUpper().Contains(sFileType) = False Then MsgBoxP("Only Image!") : Exit Sub
                If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 20 MB!") : Exit Sub
                'Set insert query 
                qry = "INSERT INTO PFK9902( K9902_NotifyCate, K9902_NotifyCateSeq, K9902_Notify, K9902_NotifySeq, K9902_DSeq, K9902_cdFactory," & _
                    "K9902_DoucmentName, K9902_FileName, K9902_ImageData, K9902_FileType, K9902_CheckMain, K9902_CheckType, K9902_AttachDate, K9902_AttachIncharge," & _
                    "K9902_Time, K9902_IsInsert, K9902_DateInsert, K9902_DateUpdate)" & _
                    "VALUES( @NotifyCate, @NotifyCateSeq, @Notify, @NotifySeq, @DSeq, @cdFactory," & _
                    "@DoucmentName, @FileName, @ImageData, @FileType, @CheckMain, @CheckType, @AttachDate, @AttachIncharge, @Time, @IsInsert, @DateInsert, @DateUpdate)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                If cdFactory = Nothing Then
                    cdFactory = ""
                End If

                Dim NotifySeq = KEY_COUNT(NotifyCate, NotifyCateSeq, SysTempDate8)

                sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

                SqlCom.Parameters.Add(New SqlParameter("@NotifyCate", NotifyCate))
                SqlCom.Parameters.Add(New SqlParameter("@NotifyCateSeq", NotifyCateSeq))
                SqlCom.Parameters.Add(New SqlParameter("@Notify", SysTempDate8))
                SqlCom.Parameters.Add(New SqlParameter("@NotifySeq", NotifySeq))
                SqlCom.Parameters.Add(New SqlParameter("@DSeq", NotifySeq))
                SqlCom.Parameters.Add(New SqlParameter("@cdFactory", cdFactory))
                SqlCom.Parameters.Add(New SqlParameter("@DoucmentName", sFileName))
                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))
                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))
                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@CheckMain", ""))
                SqlCom.Parameters.Add(New SqlParameter("@CheckType", ""))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.NAM))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))
                SqlCom.Parameters.Add(New SqlParameter("@IsInsert", "1"))
                SqlCom.Parameters.Add(New SqlParameter("@DateInsert", SysTempDate8))
                SqlCom.Parameters.Add(New SqlParameter("@DateUpdate", ""))

                'Execute the Query
                SqlCom.ExecuteNonQuery()


                lblUploadStatus.Data = "File uploaded successfully"

                Me.txtFileToUpload.Data = ""
            Next

            Call DATA_SEARCH03()

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            lblUploadStatus.Data = "File could not uploaded"

        Finally
            Starting.Close()

        End Try


    End Sub

    Private Sub cmd_Camera_Click(sender As Object, e As EventArgs) Handles cmd_Camera.Click
        Dim d As New DevExpress.XtraEditors.Camera.TakePictureDialog()
        If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim i As Image = d.Image
            ACTION_JOB05()
            Dim SqlCom As SqlCommand

            Dim imageData As Byte()
            Dim sFileName As String
            Dim qry As String
            Dim sFileType As String = "jpeg"
            Dim Fs As New MemoryStream
            d.Image.Save(Fs, Imaging.ImageFormat.Jpeg)
            imageData = Fs.GetBuffer

            'If "*.bmp;*.jpg;*.jpeg;*.gif;*.png".ToUpper().Contains(sFileType) = False Then MsgBoxP("Only Image!") : Exit Sub
            If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 20 MB!") : Exit Sub

            Dim NotifyCate As String = hlp0000SeVaTt
            Dim NotifyCateSeq As String = hlp0000SeVaTt1

            Dim SysTempDate8 As String = System_Date_8()
            'Set insert query 
            qry = "INSERT INTO PFK9902( K9902_NotifyCate, K9902_NotifyCateSeq, K9902_Notify, K9902_NotifySeq, K9902_DSeq, K9902_cdFactory," & _
                    "K9902_DoucmentName, K9902_FileName, K9902_ImageData, K9902_FileType, K9902_CheckMain, K9902_CheckType, K9902_AttachDate, K9902_AttachIncharge," & _
                    "K9902_Time, K9902_IsInsert, K9902_DateInsert, K9902_DateUpdate)" & _
                    "VALUES( @NotifyCate, @NotifyCateSeq, @Notify, @NotifySeq, @DSeq, @cdFactory," & _
                    "@DoucmentName, @FileName, @ImageData, @FileType, @CheckMain, @CheckType, @AttachDate, @AttachIncharge, @Time, @IsInsert, @DateInsert, @DateUpdate)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Dim NotifySeq = KEY_COUNT(NotifyCate, NotifyCateSeq, SysTempDate8)

            sFileName = "Camera" & NotifySeq

            SqlCom.Parameters.Add(New SqlParameter("@NotifyCate", NotifyCate))
            SqlCom.Parameters.Add(New SqlParameter("@NotifyCateSeq", NotifyCateSeq))
            SqlCom.Parameters.Add(New SqlParameter("@Notify", SysTempDate8))
            SqlCom.Parameters.Add(New SqlParameter("@NotifySeq", NotifySeq))
            SqlCom.Parameters.Add(New SqlParameter("@DSeq", NotifySeq))
            SqlCom.Parameters.Add(New SqlParameter("@cdFactory", cdFactory))
            SqlCom.Parameters.Add(New SqlParameter("@DoucmentName", sFileName))
            SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))
            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))
            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@CheckMain", ""))
            SqlCom.Parameters.Add(New SqlParameter("@CheckType", ""))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.NAM))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))
            SqlCom.Parameters.Add(New SqlParameter("@IsInsert", "1"))
            SqlCom.Parameters.Add(New SqlParameter("@DateInsert", SysTempDate8))
            SqlCom.Parameters.Add(New SqlParameter("@DateUpdate", ""))

            'Execute the Query
            SqlCom.ExecuteNonQuery()

            Call DATA_SEARCH03()
        End If
    End Sub

    Private Sub DropPicture(File() As String)
        Dim SqlCom As SqlCommand

        Dim imageData As Byte()
        Dim sFileName As String
        Dim qry As String
        Dim sFileType As String

        Dim CntFile As Integer

        Dim StrConvert As String

        CntFile = File.Length
        ACTION_JOB05()
        Try
            For i As Integer = 0 To CntFile - 1

                'Convert File to bytes Array
                imageData = ReadFile(File(i))

                StrConvert = StrReverse(File(i))
                sFileType = Strings.Left(StrConvert, StrConvert.IndexOf(".", 0))

                sFileType = StrReverse(sFileType)

                'If "*.bmp;*.jpg;*.jpeg;*.gif;*.png".ToUpper().Contains(sFileType) = False Then MsgBoxP("Only Image!") : Exit Sub
                If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 20 MB!") : Exit Sub
                'Set insert query 
                Dim NotifyCate As String = hlp0000SeVaTt
                Dim NotifyCateSeq As String = hlp0000SeVaTt1
                Dim SysTempDate8 As String = System_Date_8()
                'Set insert query 
                qry = "INSERT INTO PFK9902( K9902_NotifyCate, K9902_NotifyCateSeq, K9902_Notify, K9902_NotifySeq, K9902_DSeq, K9902_cdFactory," & _
                      "K9902_DoucmentName, K9902_FileName, K9902_ImageData, K9902_FileType, K9902_CheckMain, K9902_CheckType, K9902_AttachDate, K9902_AttachIncharge," & _
                      "K9902_Time, K9902_IsInsert, K9902_DateInsert, K9902_DateUpdate)" & _
                      "VALUES( @NotifyCate, @NotifyCateSeq, @Notify, @NotifySeq, @DSeq, @cdFactory," & _
                      "@DoucmentName, @FileName, @ImageData, @FileType, @CheckMain, @CheckType, @AttachDate, @AttachIncharge, @Time, @IsInsert, @DateInsert, @DateUpdate)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Dim NotifySeq = KEY_COUNT(NotifyCate, NotifyCateSeq, SysTempDate8)

                sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

                SqlCom.Parameters.Add(New SqlParameter("@NotifyCate", NotifyCate))
                SqlCom.Parameters.Add(New SqlParameter("@NotifyCateSeq", NotifyCateSeq))
                SqlCom.Parameters.Add(New SqlParameter("@Notify", SysTempDate8))
                SqlCom.Parameters.Add(New SqlParameter("@NotifySeq", NotifySeq))
                SqlCom.Parameters.Add(New SqlParameter("@DSeq", NotifySeq))
                SqlCom.Parameters.Add(New SqlParameter("@cdFactory", cdFactory))
                SqlCom.Parameters.Add(New SqlParameter("@DoucmentName", sFileName))
                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))
                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))
                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@CheckMain", ""))
                SqlCom.Parameters.Add(New SqlParameter("@CheckType", ""))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.NAM))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))
                SqlCom.Parameters.Add(New SqlParameter("@IsInsert", "1"))
                SqlCom.Parameters.Add(New SqlParameter("@DateInsert", SysTempDate8))
                SqlCom.Parameters.Add(New SqlParameter("@DateUpdate", ""))

                'Execute the Query
                SqlCom.ExecuteNonQuery()


                lblUploadStatus.Data = "File uploaded successfully"

                Me.txtFileToUpload.Data = ""
            Next

            Call DATA_SEARCH03()

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            lblUploadStatus.Data = "File could not uploaded"

        End Try


    End Sub
    Private Sub Form1_DragDrop(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Call DropPicture(files)
    End Sub
    Private Sub Form1_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs) Handles Me.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles cms_1.ItemClicked
        If cms_1.Items(0).Selected = True Then
            cms_1.Hide()

        ElseIf cms_1.Items(1).Selected = True Then
            cms_1.Hide()

        ElseIf cms_1.Items(2).Selected = True Then
            cms_1.Hide()

        ElseIf cms_1.Items(3).Selected = True Then
            cms_1.Hide()
            ACTION_JOB04()

        End If

    End Sub
    Private Sub ACTION_JOB04()
        Try
            Call DATA_SEARCH03()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ACTION_JOB05()
        Try
            'Call DATA_SEARCH03()
            Dim from As Form
            from = New HLP99011A
            from.ShowDialog()

            cdFactory = hlp0000SeVa

            NotifyCate = hlp0000SeVaTt
            NotifyCateSeq = hlp0000SeVaTt1

        Catch ex As Exception

        End Try
    End Sub

#End Region

End Class