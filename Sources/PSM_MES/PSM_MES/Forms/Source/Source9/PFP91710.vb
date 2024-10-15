Imports System.Data.SqlClient
Imports System.IO
Public Class PFP91710

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    'Private a9171() As T9171_AREA
    'Private b9171() As T9171_AREA
    Private Form_Close As Boolean

    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private KEY_SEQ As String

    Private formA As Boolean

    Private CHK(0 To 5) As String

    Private FormName As String
    Private Parameter As String
#End Region

#Region "Formload"

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()

    End Sub
    Private Sub DATA_INIT()

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
                Case Keys.F9 : Call MAIN_JOB05()
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
    End Sub

    Private Sub MAIN_JOB01()
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
            If ISUD9171A.Link_ISUD9171A(1, getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
            Call DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
        Else
            If ISUD9171A.Link_ISUD9171A(1, getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), "001", Me.Name) = False Then Exit Sub
            Call DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
        End If

    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD9171A.Link_ISUD9171A(3, getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

        If DATA_SEARCH02_LINE(getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex)) = False Then
            SPR_CLEAR(Vs2, Vs2.ActiveSheet.ActiveRowIndex, 0, Vs2.ActiveSheet.ActiveRowIndex, Vs2.ActiveSheet.ColumnCount)
            setData(Vs2, getColumIndex(Vs2, "BasicName"), Vs2.ActiveSheet.ActiveRowIndex, "[DELETED]", Color.Red)
        End If
        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "000" Then DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB03()
        If getData(Vs2, 13, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

    Private Sub MAIN_JOB04()
        If getData(Vs2, 13, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs2, 12, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False
        Vs2.ActiveSheet.RowCount = 0
        vS3.ActiveSheet.RowCount = 0
        Dim opt_CHK As Long

        DS1 = PrcDS("USP_PFP91710_SEARCH_VS1", cn, "000")

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP91710_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02_LINE(BasicSel As String, BasicCode As String) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02_LINE = False

        Try
            DSNEW = PrcDS("USP_PFP91710_SEARCH_vS2_LINE", cn, BasicSel, BasicCode)

            If GetDsRc(DSNEW) = 0 Then
                Exit Function
            End If

            READ_SPREAD(Vs2, DSNEW, "USP_PFP91710_SEARCH_VS2", "Vs2", Vs2.ActiveSheet.ActiveRowIndex)

            DATA_SEARCH02_LINE = True
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH02(KSEL As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH02 = False

        Try
            DSNEW = PrcDS("USP_PFP91710_SEARCH_VS2", cn, KSEL)

            vS3.ActiveSheet.RowCount = 0

            If GetDsRc(DSNEW) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DSNEW, "USP_PFP91710_SEARCH_VS2", "Vs2")

            DATA_SEARCH02 = True
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH03(Optional BasicSel As String = "", Optional BasicCode As String = "") As Boolean
        Dim DSNEW As New DataSet
        DATA_SEARCH03 = False

        If BasicSel = "" Then BasicSel = getData(Vs2, getColumIndex(Vs2, "KEY_BasicSel"), Vs2.ActiveSheet.ActiveRowIndex)
        If BasicCode = "" Then BasicCode = getData(Vs2, getColumIndex(Vs2, "KEY_BasicCode"), Vs2.ActiveSheet.ActiveRowIndex)

        Try
            DSNEW = PrcDS("USP_PFP91710_SEARCH_vS3", cn, BasicSel, BasicCode)

            If GetDsRc(DSNEW) = 0 Then
                SPR_PRO_NEW(vS3, DSNEW, "USP_PFP91710_SEARCH_vS3", "vS3")
                Exit Function
            End If

            SPR_PRO_NEW(vS3, DSNEW, "USP_PFP91710_SEARCH_vS3", "vS3")

            DATA_SEARCH03 = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "EVENT"

    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If e.Row < 0 Then Exit Sub
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
    End Sub
    Private Sub Vs2_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs2.CellClick
        If e.Row < 0 Then Exit Sub
        Vs2.ActiveSheet.ActiveColumnIndex = e.Column
        Vs2.ActiveSheet.ActiveRowIndex = e.Row

        FormName = getData(Vs2, getColumIndex(Vs2, "KEY_BASICSEL"), e.Row)
        Parameter = getData(Vs2, getColumIndex(Vs2, "KEY_BASICCODE"), e.Row)

        If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim BasicSel As String
        Dim BasicCode As String

        BasicSel = getData(Vs2, getColumIndex(Vs2, "KEY_BasicSel"), Vs2.ActiveSheet.ActiveRowIndex)
        BasicCode = getData(Vs2, getColumIndex(Vs2, "KEY_BasicCode"), Vs2.ActiveSheet.ActiveRowIndex)

        vS3.Enabled = False

        Call DATA_SEARCH03(BasicSel, BasicCode)

        vS3.Enabled = True

    End Sub
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        If getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Vs1.Enabled = False
        DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
        Vs1.Enabled = True
    End Sub

    Private Sub Vs2_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellDoubleClick
        'If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        'Dim BasicSel As String
        'Dim BasicCode As String

        'BasicSel = getData(Vs2, getColumIndex(Vs2, "KEY_BasicSel"), Vs2.ActiveSheet.ActiveRowIndex)
        'BasicCode = getData(Vs2, getColumIndex(Vs2, "KEY_BasicCode"), Vs2.ActiveSheet.ActiveRowIndex)

        'vS3.Enabled = False

        'Call DATA_SEARCH03(BasicSel, BasicCode)

        'vS3.Enabled = True
    End Sub

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub vS2_GotFocus(sender As Object, e As EventArgs) Handles Vs2.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, False, False, False, False, WordConv("INSERT") & "(F5)", WordConv("UPDATE") & "(F6)")
    End Sub

    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vs2_LostFocus(sender As Object, e As EventArgs) Handles Vs2.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        If getData(Vs1, 12, Row) = "" Then Exit Sub
        Call DATA_SEARCH02(getData(Vs1, 0, Row), getData(Vs1, 1, Row))
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
            '   Call DATA_SEARCH02(a9171(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)).KCODE, a9171(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex)).KNAME)
        End If
    End Sub

#End Region

    Private Sub btn_Rearrange_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        Dim j As Integer = 1
        Try
            For i = 0 To Vs2.ActiveSheet.RowCount - 1

                If READ_PFK9171(getData(Vs2, getColumIndex(Vs2, "Key_BasicSel"), i), getData(Vs2, getColumIndex(Vs2, "Key_BasicCode"), i)) Then
                    D9171.DisplaySeq = j
                    j += 1

                    Call REWRITE_PFK9171(D9171)
                End If

            Next
            Call MsgBoxP("btn_Rearrange", "023")
        Catch ex As Exception

        End Try



    End Sub

#Region "Solution"
    Private Function Data_Check() As Boolean

        Data_Check = True

    End Function
    Private Sub DATA_MOVE()

    End Sub

    Private Sub DATA_DELETE()
        Try
            SQL = "DELETE FROM [dbo].[PFK9172] "
            SQL = SQL & " WHERE [K9172_BasicSel] = '" + FormName + "'"
            SQL = SQL & " AND [K9172_BasicCode] = '" + Parameter + "'"
            SQL = SQL & " AND [K9172_SEQ] = '" + CIntp(getData(vS3, getColumIndex(vS3, "KEY_SEQ"), vS3.ActiveSheet.ActiveRowIndex)).ToString + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SPR_CLEAR(vS3, vS3.ActiveSheet.ActiveRowIndex, 0, vS3.ActiveSheet.ActiveRowIndex, vS3.ActiveSheet.ColumnCount - 1)
            setData(vS3, getColumIndex(vS3, "FileName"), vS3.ActiveSheet.ActiveRowIndex, "[DELETED]")
            'Call MsgBoxP("Delete Successfully!", vbInformation)

            'Call DATA_SEARCH01()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(K9172_SEQ) AS MAX_CODE FROM [PFK9172] "
        SQL = SQL & " WHERE K9172_BasicSel     = '" + FormName + "'"
        SQL = SQL & " AND [K9172_BasicCode] = '" + Parameter + "'"


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


#End Region

#Region "DATA_SEARCH"

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

    Private MaxByte As Integer = 1024 * 1024 * 2
    Private Sub upLoadImageOrFile(ByVal sFilePath As String, ByVal sFileType As String)
        Dim SqlCom As SqlCommand

        Dim imageData As Byte()


        Dim sFileName As String

        Dim qry As String

        Try

            'Convert File to bytes Array
            imageData = ReadFile(sFilePath)
            If imageData.Length > MaxByte And Pub.DEVCHK <> "1" Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
            sFileName = System.IO.Path.GetFileNameWithoutExtension(sFilePath)

            'Set insert query 
            qry = "insert into [PFK9172] ([K9172_BasicSel],[K9172_BasicCode],[K9172_SEQ],[K9172_FileName],[K9172_ImageData]," & _
            "[K9172_FileType],[K9172_AttachDate],[K9172_AttachIncharge],[K9172_Time]) values (@BasicSel, @BasicCode,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Call KEY_COUNT()

            SqlCom.Parameters.Add(New SqlParameter("@BasicSel", FormName))
            SqlCom.Parameters.Add(New SqlParameter("@BasicCode", Parameter))
            SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

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
                    shw_PictureBox.Image = Image.FromFile(OpenFileDialog.FileName)
                    shw_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage
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

        openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.gif;*.png)|*.bmp;*.jpg;*.jpeg;*.gif;*.png|" + _
            "text files (*.text)|*.txt|doc files (*.doc)|*.doc;*.docx|pdf files (*.pdf)|*.pdf|excels files (*.xls,*.xlsx)|*.xls;*.xlsx|" + _
            "powerpoint files (*.ppt;*.pptx)|*.ppt;*.pptx"

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
            strSql = "Select K9172_ImageData from [PFK9172] "
            strSql = strSql & "WHERE [K9172_BasicSel]= '" + getData(vS3, getColumIndex(vS3, "Key_BasicSel"), vS3.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   [K9172_BasicCode]= '" + getData(vS3, getColumIndex(vS3, "Key_BasicCode"), vS3.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   [K9172_SEQ]= '" + getData(vS3, getColumIndex(vS3, "KEY_SEQ"), vS3.ActiveSheet.ActiveRowIndex) + "'"

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
            strSql = "Select K9172_ImageData from [PFK9172] "
            strSql = strSql & "WHERE [K9172_BasicSel]= '" & getData(vS3, getColumIndex(vS3, "Key_BasicSel"), vS3.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K9172_BasicCode]= '" & getData(vS3, getColumIndex(vS3, "Key_BasicCode"), vS3.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K9172_SEQ]= '" & getData(vS3, getColumIndex(vS3, "KEY_SEQ"), vS3.ActiveSheet.ActiveRowIndex) & "'"

            Dim sqlCmd As New SqlCommand(strSql, cn)

            sFileName = getData(vS3, getColumIndex(vS3, "FileName"), vS3.ActiveSheet.ActiveRowIndex)
            sFileName &= "." & getData(vS3, getColumIndex(vS3, "FileType"), vS3.ActiveSheet.ActiveRowIndex)

            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & sFileName

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
    Private Sub SaveFile()
        Dim sFileName As String
        Dim strSql As String

        Dim SaveFile As New SaveFileDialog
        SaveFile.FileName = getData(vS3, getColumIndex(vS3, "FileName"), vS3.ActiveSheet.ActiveRowIndex)
        'Open the File Dialog to select the file
        If (SaveFile.ShowDialog(Me) = DialogResult.OK) Then


            'For Document
            Try
                'Get image data from gridview column. 
                strSql = "Select K9172_ImageData from [PFK9172] "
                strSql = strSql & "WHERE [K9172_BasicSel]= '" & getData(vS3, getColumIndex(vS3, "Key_BasicSel"), vS3.ActiveSheet.ActiveRowIndex) & "'"
                strSql = strSql & "AND   [K9172_BasicCode]= '" & getData(vS3, getColumIndex(vS3, "Key_BasicCode"), vS3.ActiveSheet.ActiveRowIndex) & "'"
                strSql = strSql & "AND   [K9172_SEQ]= '" & getData(vS3, getColumIndex(vS3, "KEY_SEQ"), vS3.ActiveSheet.ActiveRowIndex) & "'"

                Dim sqlCmd As New SqlCommand(strSql, cn)

                sFileName = getData(vS3, getColumIndex(vS3, "FileName"), vS3.ActiveSheet.ActiveRowIndex)

                'Get image data from DB
                Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

                Dim sTempFileName As String = SaveFile.FileName & getData(vS3, getColumIndex(vS3, "FileType"), vS3.ActiveSheet.ActiveRowIndex) ' System.IO.Path.GetTempPath & "\" & sFileName

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

    Private Sub vS3_CellClick(sender As Object, e As CellClickEventArgs) Handles vS3.CellDoubleClick
        Dim strSql As String = ""
        Me.lblUploadStatus.Data = ""

        Try
            Select Case getData(vS3, getColumIndex(vS3, "FileType"), e.Row)
                Case "bmp", "jpg", "jpeg", "gif", "png"
                    txtFileToUpload.Data = getData(vS3, getColumIndex(vS3, "FileName"), vS3.ActiveSheet.ActiveRowIndex)

                    strSql = "Select K9172_ImageData  AS ImageData from [PFK9172] "
                    strSql = strSql & "WHERE [K9172_BasicSel]= '" + getData(vS3, getColumIndex(vS3, "Key_BasicSel"), vS3.ActiveSheet.ActiveRowIndex) + "'"
                    strSql = strSql & "AND   [K9172_BasicCode]= '" + getData(vS3, getColumIndex(vS3, "Key_BasicCode"), vS3.ActiveSheet.ActiveRowIndex) + "'"
                    strSql = strSql & "AND   [K9172_SEQ] = '" & getData(vS3, getColumIndex(vS3, "KEY_SEQ"), vS3.ActiveSheet.ActiveRowIndex) & "'"

                    Dim sqlCmd As New SqlCommand(strSql, cn)

                    'Get image data from DB
                    Dim imageData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

                    'Initialize image variable 
                    Dim newImage As Image = Nothing

                    If Not imageData Is Nothing Then
                        'Read image data into a memory stream 
                        Using ms As New MemoryStream(imageData, 0, imageData.Length)
                            ms.Write(imageData, 0, imageData.Length)
                            'Set image variable value using memory stream. 
                            newImage = Image.FromStream(ms, True)
                        End Using

                        'Display the picture  in Picture Box

                        shw_PictureBox.Image = newImage
                        shw_PictureBox.SizeMode = cmb_State.SelectedIndex ' PictureBoxSizeMode.StretchImage
                        chk_Visible.Checked = True
                    End If

                Case Else
                    downLoadFile()
                    chk_Visible.Checked = False
            End Select

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private CntPic As Integer = 0
    Private ListPic As New List(Of String)
    Private ConstMargin As Integer = 10
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles shw_PictureBox.Click
        PICTURE.PictureBox1.Image = sender.Image
        PICTURE.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PICTURE.ShowDialog()
    End Sub

    Private Sub cmd_Capture_Click(sender As Object, e As EventArgs) Handles cmd_Capture.Click
        CheckSolution = True
        If frmSnipMain.frmSnipMain_Link(FormName, Parameter) = False Then Exit Sub
        Call DATA_SEARCH03()
    End Sub
    Private Sub vS3_KeyDown(sender As Object, e As KeyEventArgs) Handles vS3.KeyDown
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
        Dim SqlCom As SqlCommand

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

                If imageData.Length > MaxByte And Pub.DEVCHK <> "1" Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
                'Set insert query 
                qry = "insert into [PFK9172] ([K9172_BasicSel],[K9172_BasicCode],[K9172_SEQ],[K9172_FileName],[K9172_ImageData]," & _
                "[K9172_FileType],[K9172_AttachDate],[K9172_AttachIncharge],[K9172_Time]) values (@BasicSel, @BasicCode,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()

                sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

                SqlCom.Parameters.Add(New SqlParameter("@BasicSel", FormName))
                SqlCom.Parameters.Add(New SqlParameter("@BasicCode", Parameter))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

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

    Private Sub cmd_Camera_Click(sender As Object, e As EventArgs) Handles cmd_Camera.Click
        Dim d As New DevExpress.XtraEditors.Camera.TakePictureDialog()
        If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim i As Image = d.Image

            Dim SqlCom As SqlCommand

            Dim imageData As Byte()
            Dim sFileName As String
            Dim qry As String
            Dim sFileType As String = "jpeg"
            Dim Fs As New MemoryStream
            d.Image.Save(Fs, Imaging.ImageFormat.Jpeg)
            imageData = Fs.GetBuffer

            If imageData.Length > MaxByte And Pub.DEVCHK <> "1" Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
            'Set insert query 
            qry = "insert into [PFK9172] ([K9172_BasicSel],[K9172_BasicCode],[K9172_SEQ],[K9172_FileName],[K9172_ImageData]," & _
            "[K9172_FileType],[K9172_AttachDate],[K9172_AttachIncharge],[K9172_Time]) values (@BasicSel, @BasicCode,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Call KEY_COUNT()

            sFileName = KEY_SEQ
            SqlCom.Parameters.Add(New SqlParameter("@BasicSel", FormName))
            SqlCom.Parameters.Add(New SqlParameter("@BasicCode", Parameter))
            SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", "Camera" & KEY_SEQ))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

            'Execute the Query
            SqlCom.ExecuteNonQuery()

            Call DATA_SEARCH03()
        End If
    End Sub
#End Region
    
  
    Private Sub DropPicture(File() As String)
        Dim SqlCom As SqlCommand

        Dim imageData As Byte()
        Dim sFileName As String
        Dim qry As String
        Dim sFileType As String

        Dim CntFile As Integer

        Dim StrConvert As String

        CntFile = File.Length

        Try
            For i As Integer = 0 To CntFile - 1

                'Convert File to bytes Array
                imageData = ReadFile(File(i))

                StrConvert = StrReverse(File(i))
                sFileType = Strings.Left(StrConvert, StrConvert.IndexOf(".", 0))

                sFileType = StrReverse(sFileType)

                If imageData.Length > MaxByte And Pub.DEVCHK <> "1" Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
                'Set insert query 
                qry = "insert into [PFK9172] ([K9172_BasicSel],[K9172_BasicCode],[K9172_SEQ],[K9172_FileName],[K9172_ImageData]," & _
                "[K9172_FileType],[K9172_AttachDate],[K9172_AttachIncharge],[K9172_Time]) values (@BasicSel, @BasicCode,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()

                sFileName = System.IO.Path.GetFileNameWithoutExtension(File(i))

                SqlCom.Parameters.Add(New SqlParameter("@BasicSel", FormName))
                SqlCom.Parameters.Add(New SqlParameter("@BasicCode", Parameter))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

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

    Private Sub chk_Visible_CheckedChanged(sender As Object, e As EventArgs) Handles chk_Visible.CheckedChanged
        If chk_Visible.Checked = True Then
            shw_PictureBox.Visible = True
        Else
            shw_PictureBox.Visible = False
        End If
    End Sub


End Class