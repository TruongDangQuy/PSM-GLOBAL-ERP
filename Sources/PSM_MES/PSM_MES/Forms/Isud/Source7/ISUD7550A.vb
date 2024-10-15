Imports System.Data.SqlClient
Imports System.IO
Public Class ISUD7550A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private KEY_cdQAProcess As String = "001"

    Private formA As Boolean
    Private CheckManual As Boolean = False

    Private CHK(0 To 5) As String

    Private FormName As String
    Private Parameter As String
    Private QAKey As String

#End Region

#Region "Link"
    Public Function Link_ISUD7550A(job As Integer, _FormName As String, Value As String) As Boolean
        FormName = "PFK" + Strings.Mid(_FormName, 5, 4)
        QAKey = _FormName
        Parameter = Value
        wJOB = job
        Link_ISUD7550A = False

        Select Case job
            Case 1
            Case Else

        End Select

        formA = False
        Me.Tag = Tag
        Me.ShowDialog()

        Link_ISUD7550A = isudCHK

    End Function
    Public Function Link_ISUD7550A_MANUAL(job As Integer, _FormName As String) As Boolean
        FormName = _FormName

        Parameter = "MANUAL"

        wJOB = job
        Link_ISUD7550A_MANUAL = False

        Select Case job
            Case 1
            Case Else

        End Select

        CheckManual = True
        formA = False
        Me.Tag = Tag
        Me.ShowDialog()

        Link_ISUD7550A_MANUAL = isudCHK

    End Function

    Public Function Link_ISUD7550B(job As Integer, _FormName As String, Value As String) As Boolean
        'FormName = _FormName
        FormName = "PFK" + Strings.Mid(_FormName, 4, 4)

        Parameter = Value
        wJOB = job
        Link_ISUD7550B = False

        Select Case job
            Case 1
            Case Else

        End Select

        formA = False
        Me.Tag = Tag
        Me.ShowDialog()

        Link_ISUD7550B = isudCHK

    End Function
#End Region

#Region "Form_load"

    Private Sub ISUD7550A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.V Then
            Call PastePicture()
        End If
    End Sub
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        Me.Form_Initial()
        Me.Form_KeyDown()
        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        'Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))
        CHK(1) = "1"
        CHK(2) = "1"
        CHK(3) = "1"
        CHK(4) = "1"
        CHK(5) = "1"

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                Call KEY_COUNT()
                Call DATA_SEARCH01()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                tst_iDelete.Visible = False

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                tst_iDelete.Visible = False


                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                'Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                txt_FileName.Data = Parameter
                txt_QAKey.Data = QAKey
                txt_QAKey.Enabled = False

                tst_iDelete.Visible = True

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("4", "Form_Activate")
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


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

            Case 11

                Me.Text = Me.Text & " - MANUAL"
                cmdUpload.Visible = False

                Call DATA_SEARCH_MANUAL()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        KEY_CHK = ""
        tst_iClose.Enabled = True
        cmdUpload.Enabled = True
        tst_iDelete.Enabled = True
        tst_iClose.Visible = True
        cmdUpload.Visible = True
        tst_iDelete.Visible = True
        txt_FileName.Enabled = True
        txt_DateQA.Data = Pub.DAT

    End Sub

    Private Sub FORM_INIT()
        CheckSolution = False
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean

        Data_Check = True

    End Function
    Private Sub DATA_MOVE()
        txt_FormName.Data = FormName
    End Sub

    Private Sub DATA_DELETE()
        'If CheckManual = True And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Not Admin ! Can not process!") : Exit Sub
        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Sub
        End If
        Try
            SQL = "DELETE FROM [dbo].[PFK7550] "
            SQL = SQL & " WHERE [K7550_QAKey] = '" + QAKey + "'"
            SQL = SQL & " AND [K7550_DateQA] = '" + txt_DateQA.Data + "'"
            SQL = SQL & " AND [K7550_cdQAProcess] = '" + CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_cdQAProcess"), Vs1.ActiveSheet.ActiveRowIndex)).ToString + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()
            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]")
            Call MsgBoxP("Delete Successfully!", vbInformation)

            Call DATA_SEARCH01()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(K7550_QAKey) AS MAX_CODE FROM [PFK7550] "


        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            QAKey = "0000000001"
        Else
            QAKey = CIntp(rd!MAX_CODE + 1).ToString("0000000000")
        End If

        txt_QAKey.Data = QAKey

        rd.Close()
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH01 = False

        Dim strFormname As String = "ISUD7171A"
        Dim strParameter As String = "920;000"

        DATA_SEARCH01 = True

        DS2 = PrcDS("USP_ISUD7550A_SEARCH_VS1", cn, FormName, strParameter)


        SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7550A_SEARCH_VS1", "Vs1")
    End Function

    Private Function DATA_SEARCH_MANUAL() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH_MANUAL = False

        DATA_SEARCH_MANUAL = True

        DS2 = PrcDS("USP_ISUD7550A_SEARCH_VS1_MANUAL", cn, FormName)

        SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7550A_SEARCH_VS1", "Vs1")

    End Function

#End Region

#Region "Event"
    Private Sub cmdUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpload.Click

        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Sub
        End If

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

        Call DATA_SEARCH01()

    End Sub

    Public Function ResizeImage(ByVal image As Image, ByVal size As Size, Optional ByVal preserveAspectRatio As Boolean = True) As Image
        Try
            Dim newWidth As Integer
            Dim newHeight As Integer
            If preserveAspectRatio Then
                Dim originalWidth As Integer = image.Width
                Dim originalHeight As Integer = image.Height
                Dim percentWidth As Single = CSng(size.Width) / CSng(originalWidth)
                Dim percentHeight As Single = CSng(size.Height) / CSng(originalHeight)
                Dim percent As Single = IIf(percentHeight < percentWidth, percentHeight, percentWidth)
                newWidth = CInt(originalWidth * percent)
                newHeight = CInt(originalHeight * percent)
            Else
                newWidth = size.Width
                newHeight = size.Height
            End If

            Dim newImage As Image = New Bitmap(newWidth, newHeight)
            Using graphicsHandle As Graphics = Graphics.FromImage(newImage)
                graphicsHandle.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                graphicsHandle.DrawImage(image, 0, 0, newWidth, newHeight)
            End Using

            Return newImage

        Catch ex As Exception
            Return image
        End Try
    End Function

    Private Sub upLoadImageOrFile(ByVal sFilePath As String, ByVal sFileType As String)
        'If CheckManual = True And Pub.SAW <> PSMADMIN"PSMADMIN" Then MsgBoxP("Not Admin ! Can not process!") : Exit Sub

        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Sub
        End If

        Dim SqlCom As SqlCommand
        Dim MaxByte As Integer = 1024 * 1024 * 10
        Dim imageData As Byte()


        Dim sFileName As String

        Dim qry As String

        Try

            'Convert File to bytes Array
            imageData = ReadFile(sFilePath)
            If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 10 MB!") : Exit Sub
            sFileName = System.IO.Path.GetFileNameWithoutExtension(sFilePath)

            'Set insert query 
            qry = "insert into [PFK7550] ([K7550_QAKey],[K7550_DateQA],[K7550_cdQAProcess],[K7550_FileName],[K7550_ImageData]," & _
            "[K7550_FileType],[K7550_AttachDate],[K7550_AttachIncharge],[K7550_Time]) values (@QAKey, @DateQA,@cdQAProcess,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Call KEY_COUNT()

            SqlCom.Parameters.Add(New SqlParameter("@QAKey", QAKey))
            SqlCom.Parameters.Add(New SqlParameter("@DateQA", txt_DateQA.Data))
            SqlCom.Parameters.Add(New SqlParameter("@cdQAProcess", KEY_cdQAProcess))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

            'Execute the Query
            SqlCom.ExecuteNonQuery()

            ''''''''''''''''''''''''''''''''''''''''''''''SMALL PIC''''''''''''''''''''''''''''''''''''''''''''''''''''''

            'Set insert query 
            qry = "insert into [PFK7556] ([K7556_QAKey],[K7556_DateQA],[K7556_cdQAProcess],[K7556_FileName],[K7556_ImageData]," & _
            "[K7556_FileType],[K7556_AttachDate],[K7556_AttachIncharge],[K7556_Time]) values (@QAKey, @DateQA,@cdQAProcess,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            SqlCom.Parameters.Add(New SqlParameter("@QAKey", QAKey))
            SqlCom.Parameters.Add(New SqlParameter("@DateQA", txt_DateQA.Data))
            SqlCom.Parameters.Add(New SqlParameter("@cdQAProcess", KEY_cdQAProcess))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(ReadFile_Resize(), Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

            'Execute the Query
            SqlCom.ExecuteNonQuery()
            ''''''''''''''''''''''''''''''''''''''''''''''SMALL PIC''''''''''''''''''''''''''''''''''''''''''''''''''''''


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

    Private Function ReadFile_Resize() As Byte()

        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Dim Imagex As Image
        Dim imageConverter As New ImageConverter()
        Dim imageByte As Byte() = DirectCast(imageConverter.ConvertTo(Imagex, GetType(Byte())), Byte())


        Return imageByte

    End Function

    Private Function ReadFile_Resize_Pic(Imagex As Image) As Byte()

        'Initialize byte array with a null value initially. 
        Dim data As Byte() = Nothing

        'Use FileInfo object to get file size. 
        Imagex = ResizeImage(Imagex, New Size(100, 100))

        Dim imageConverter As New ImageConverter()
        Dim imageByte As Byte() = DirectCast(imageConverter.ConvertTo(Imagex, GetType(Byte())), Byte())


        Return imageByte

    End Function
    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub
    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        'If CheckManual = True And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Not Admin ! Can not process!") : Exit Sub

        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Sub
        End If

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If
        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()

    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        'If CheckManual = True And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Not Admin ! Can not process!") : Exit Sub

        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Sub
        End If

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
        'If CheckManual = True And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Not Admin ! Can not process!") : Exit Function

        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Function
        End If

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
            strSql = "Select K7550_ImageData from [PFK7550] "
            strSql = strSql & "WHERE [K7550_QAKey]= '" + getData(Vs1, getColumIndex(Vs1, "Key_QAKey"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   [K7550_DateQA]= '" + getData(Vs1, getColumIndex(Vs1, "Key_DateQA"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   [K7550_cdQAProcess]= '" + getData(Vs1, getColumIndex(Vs1, "KEY_cdQAProcess"), Vs1.ActiveSheet.ActiveRowIndex) + "'"

            Dim sqlCmd As New SqlCommand(strSql, cn)

            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            'Dim sTempFileName As String = Application.StartupPath & "\" & sFileName

            sFileName = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)
            sFileName &= "." & getData(Vs1, getColumIndex(Vs1, "FileType"), Vs1.ActiveSheet.ActiveRowIndex)

            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & sFileName & "_QA" & txt_QAKey.Data


            If Not fileData Is Nothing Then

                'Read image data into a file stream 
                Using fs As New FileStream(sTempFileName, FileMode.OpenOrCreate, FileAccess.Write)
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
            strSql = "Select K7555_ImageData from [PFK7555] "
            strSql = strSql & "WHERE [K7555_TABLE]= '" & getData(Vs1, getColumIndex(Vs1, "Key_TABLE"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7555_PAREMETER]= '" & getData(Vs1, getColumIndex(Vs1, "Key_PAREMETER"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7555_SEQ]= '" & getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex) & "'"


            Dim sqlCmd As New SqlCommand(strSql, cn)

            sFileName = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)
            sFileName &= "." & getData(Vs1, getColumIndex(Vs1, "FileType"), Vs1.ActiveSheet.ActiveRowIndex)



            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())
            Dim strnewfile As String = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex) & "_QA" & txt_QAKey.Data & "." & getData(Vs1, getColumIndex(Vs1, "FileType"), Vs1.ActiveSheet.ActiveRowIndex)
            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & strnewfile

            If System.IO.File.Exists(sTempFileName) = True Then

                System.IO.File.Delete(sTempFileName)


            End If

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

        If FormatCut(txt_FileName.Data) = "" Then MsgBoxP("Content Pls!") : Setfocus(txt_FileName) : Exit Sub
        If FilenameIsOK(txt_FileName.Data) = False Then MsgBox("File Name is not good name !") : Setfocus(txt_FileName) : Exit Sub
        Dim str As String = MsgBoxP("Lưu ý quan trọng! Phải lưu files trước khi thêm dữ liệu ! Do you want to save it?", vbYesNo)

        If str <> vbYes Then Exit Sub


        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Dim SqlCom As SqlCommand
        Dim MaxByte As Integer = 1024 * 1024 * 10
        Dim imageData As Byte()
        Dim sFileName As String
        Dim qry As String
        Dim sFileType As String

        Dim CntFile As Integer

        Dim StrConvert As String

        Try
            'Convert File to bytes Array

            Dim strnewfile As String = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex) & "_QA" & txt_QAKey.Data & "." & getData(Vs1, getColumIndex(Vs1, "FileType"), Vs1.ActiveSheet.ActiveRowIndex)
            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & strnewfile
            Dim sTempFileNameNew As String = sTempFileName.Replace("_QA" & txt_QAKey.Data, "_QA" & System_Date_time())


            If System.IO.File.Exists(sTempFileName) = True Then

                System.IO.File.Copy(sTempFileName, sTempFileNameNew)

            Else
                MsgBoxP("Ko tìm thấy files ! Exit sub !")
                Exit Sub
            End If


            imageData = ReadFile(sTempFileNameNew)

            If imageData.Length > MaxByte And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Image size is not over 10 MB!") : Exit Sub

            'Set insert query 
            qry = "insert into [PFK7550] (K7550_TABLE, K7550_PAREMETER, K7550_SEQ,[K7550_QAKey],[K7550_DateQA],[K7550_cdQAProcess],[K7550_FileName],[K7550_ImageData]," & _
            "[K7550_FileType],[K7550_AttachDate],[K7550_InchargeInsert],[K7550_TimeInsert]) values (@TABLE, @PAREMETER, @SEQ, @QAKey, @DateQA,@cdQAProcess,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Call KEY_COUNT()


            sFileName = KEY_cdQAProcess
            sFileName = QAKey 'THÊM TÊN FILES VÔ CHO CHÍNH XÁC

            SqlCom.Parameters.Add(New SqlParameter("@QAKey", QAKey))
            SqlCom.Parameters.Add(New SqlParameter("@DateQA", txt_DateQA.Data))
            SqlCom.Parameters.Add(New SqlParameter("@cdQAProcess", KEY_cdQAProcess))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", txt_FileName.Data))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))
            sFileType = getData(Vs1, getColumIndex(Vs1, "FileType"), Vs1.ActiveSheet.ActiveRowIndex)

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

            SqlCom.Parameters.Add(New SqlParameter("@TABLE", getData(Vs1, getColumIndex(Vs1, "Key_TABLE"), Vs1.ActiveSheet.ActiveRowIndex)))
            SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", getData(Vs1, getColumIndex(Vs1, "Key_PAREMETER"), Vs1.ActiveSheet.ActiveRowIndex)))
            SqlCom.Parameters.Add(New SqlParameter("@SEQ", getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex)))

            'Execute the Query
            SqlCom.ExecuteNonQuery()

            Try
                My.Computer.FileSystem.DeleteFile(sTempFileNameNew)
            Catch ex As Exception

            End Try

            lblUploadStatus.Data = "File uploaded successfully"

            Me.txtFileToUpload.Data = ""
            Me.Dispose()


        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            lblUploadStatus.Data = "File could not uploaded"

        Finally
            Starting.Close()


        End Try


        'Dim sFileName As String
        'Dim strSql As String

        'Dim SaveFile As New SaveFileDialog
        'SaveFile.FileName = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)
        ''Open the File Dialog to select the file
        'If (SaveFile.ShowDialog(Me) = DialogResult.OK) Then


        '    'For Document
        '    Try
        '        'Get image data from gridview column. 
        '        strSql = "Select K7550_ImageData from [PFK7550] "
        '        strSql = strSql & "WHERE [K7550_QAKey]= '" & getData(Vs1, getColumIndex(Vs1, "Key_QAKey"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
        '        strSql = strSql & "AND   [K7550_DateQA]= '" & getData(Vs1, getColumIndex(Vs1, "Key_DateQA"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
        '        strSql = strSql & "AND   [K7550_cdQAProcess]= '" & getData(Vs1, getColumIndex(Vs1, "KEY_cdQAProcess"), Vs1.ActiveSheet.ActiveRowIndex) & "'"

        '        Dim sqlCmd As New SqlCommand(strSql, cn)

        '        sFileName = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)

        '        'Get image data from DB
        '        Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

        '        Dim sTempFileName As String = SaveFile.FileName & getData(Vs1, getColumIndex(Vs1, "FileType"), Vs1.ActiveSheet.ActiveRowIndex) ' System.IO.Path.GetTempPath & "\" & sFileName

        '        If Not fileData Is Nothing Then

        '            'Read image data into a file stream 
        '            Using fs As New FileStream(sTempFileName, FileMode.OpenOrCreate, FileAccess.Write)
        '                fs.Write(fileData, 0, fileData.Length)
        '                'Set image variable value using memory stream. 
        '                fs.Flush()
        '                fs.Close()
        '            End Using

        '            'Open File


        '        End If


        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try

        'End If
    End Sub

    Private Sub SaveFile3()

        If FormatCut(txt_FileName.Data) = "" Then MsgBoxP("Content Pls!") : Setfocus(txt_FileName) : Exit Sub
        If FilenameIsOK(txt_FileName.Data) = False Then MsgBox("File Name is not good name !") : Setfocus(txt_FileName) : Exit Sub
        Dim str As String = MsgBoxP("Lưu ý quan trọng! Phải lưu files trước khi thêm dữ liệu ! Do you want to save it?", vbYesNo)

        If str <> vbYes Then Exit Sub



        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Dim SqlCom As SqlCommand
        Dim MaxByte As Integer = 1024 * 1024 * 10
        Dim imageData As Byte()
        Dim sFileName As String
        Dim qry As String
        Dim sFileType As String

        Dim CntFile As Integer

        Dim StrConvert As String

        Try
            'Convert File to bytes Array

            Dim strnewfile As String = txt_FileName.Data & "." & "xlsx"

            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & txt_FileName.Data & "_QA" & txt_QAKey.Data & "." & "xlsx"
            Dim sTempFileNameNew As String = sTempFileName.Replace("_QA" & txt_QAKey.Data, "_QA" & System_Date_time())


            If System.IO.File.Exists(sTempFileName) = True Then

                System.IO.File.Copy(sTempFileName, sTempFileNameNew)


            End If


            imageData = ReadFile(sTempFileNameNew)

            If imageData.Length > MaxByte And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Image size is not over 10 MB!") : Exit Sub

            'Set insert query 
            qry = "UPDATE [PFK7550] SET [K7550_ImageData] =  @ImageData , K7550_DateQA =  @DateQA , K7550_FileName = @FileName, K7550_TimeUpdate = @Timeupdate, K7550_InchargeUpdate = @InchargeUpdate " & _
            " WHERE K7550_QAKey = @QAKey "

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 


            sFileName = KEY_cdQAProcess
            sFileName = txt_QAKey.Data 'THÊM TÊN FILES VÔ CHO CHÍNH XÁC

            SqlCom.Parameters.Add(New SqlParameter("@QAKey", txt_QAKey.Data))
            SqlCom.Parameters.Add(New SqlParameter("@FileName", txt_FileName.Data))
            SqlCom.Parameters.Add(New SqlParameter("@DateQA", txt_DateQA.Data))
            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))
            SqlCom.Parameters.Add(New SqlParameter("@TimeUpdate", System_Date_time))
            SqlCom.Parameters.Add(New SqlParameter("@InchargeUpdate", Pub.SAW))
            'Execute the Query

            Call PrcExeNoError("USP_PFK7551_FROM_PFK7550_BACKUP", cn, txt_QAKey.Data, Pub.TIM, Pub.SAW)


            SqlCom.ExecuteNonQuery()

            Try
                File.CreateText(sTempFileNameNew).Close()

                My.Computer.FileSystem.DeleteFile(sTempFileNameNew)
            Catch ex As Exception

            End Try

            Try
                File.CreateText(sTempFileName).Close()

            Catch ex As Exception

            End Try


            lblUploadStatus.Data = "File uploaded successfully"

            Me.txtFileToUpload.Data = ""
            Me.Dispose()


        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            lblUploadStatus.Data = "File could not uploaded"

        Finally
            Starting.Close()


        End Try
    End Sub

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        If wJOB = 1 Then SaveFile()
        If wJOB = 3 Then SaveFile3()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If wJOB = 2 Then Exit Sub

        Dim strSql As String = ""
        Me.lblUploadStatus.Data = ""

        Try

            Call downLoadFile()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private CntPic As Integer = 0
    Private ListPic As New List(Of String)
    Private ConstMargin As Integer = 10
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs)
        PICTURE.PictureBox1.Image = sender.Image
        PICTURE.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PICTURE.ShowDialog()
    End Sub

    Private Sub cmd_Capture_Click(sender As Object, e As EventArgs)
        If frmSnipMain.frmSnipMain_Link(FormName, Parameter) = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub
    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call DATA_DELETE()
        End If
    End Sub



    Private Sub PastePicture()
        'If CheckManual = True And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Not Admin ! Can not upload!") : Exit Sub

        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Sub
        End If

        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Dim SqlCom As SqlCommand
        Dim MaxByte As Integer = 1024 * 1024 * 10
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

                If imageData.Length > MaxByte And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Image size is not over 10 MB!") : Exit Sub
                'Set insert query 
                qry = "insert into [PFK7550] ([K7550_QAKey],[K7550_DateQA],[K7550_cdQAProcess],[K7550_FileName],[K7550_ImageData]," & _
                "[K7550_FileType],[K7550_AttachDate],[K7550_AttachIncharge],[K7550_Time]) values (@QAKey, @DateQA,@cdQAProcess,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()


                sFileName = KEY_cdQAProcess
                sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

                SqlCom.Parameters.Add(New SqlParameter("@QAKey", QAKey))
                SqlCom.Parameters.Add(New SqlParameter("@DateQA", txt_DateQA.Data))
                SqlCom.Parameters.Add(New SqlParameter("@cdQAProcess", KEY_cdQAProcess))

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

            Call DATA_SEARCH01()

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
            lblUploadStatus.Data = "File could not uploaded"

        Finally
            Starting.Close()


        End Try


    End Sub

    Private Sub cmd_Camera_Click(sender As Object, e As EventArgs)
        'If CheckManual = True And Pub.SAW <> "PSMADMIN" Then MsgBoxP("Not Admin ! Can not process!") : Exit Sub

        If CheckManual = True And Pub.SAW <> "PSMADMIN" Then
            If MsgBoxPPW("Please type the password to modify!", "750") = False Then Exit Sub
        End If

        Dim d As New DevExpress.XtraEditors.Camera.TakePictureDialog()
        If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim i As Image = d.Image

            Dim SqlCom As SqlCommand
            Dim MaxByte As Integer = 1024 * 1024 * 10
            Dim imageData As Byte()
            Dim sFileName As String
            Dim qry As String
            Dim sFileType As String = "jpeg"
            Dim Fs As New MemoryStream
            d.Image.Save(Fs, Imaging.ImageFormat.Jpeg)
            imageData = Fs.GetBuffer

            If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 10 MB!") : Exit Sub
            'Set insert query 
            qry = "insert into [PFK7550] ([K7550_QAKey],[K7550_DateQA],[K7550_cdQAProcess],[K7550_FileName],[K7550_ImageData]," & _
            "[K7550_FileType],[K7550_AttachDate],[K7550_AttachIncharge],[K7550_Time]) values (@QAKey, @DateQA,@cdQAProcess,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Call KEY_COUNT()

            sFileName = KEY_cdQAProcess
            SqlCom.Parameters.Add(New SqlParameter("@QAKey", FormName))
            SqlCom.Parameters.Add(New SqlParameter("@DateQA", txt_DateQA.Data))
            SqlCom.Parameters.Add(New SqlParameter("@cdQAProcess", KEY_cdQAProcess))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", "Camera" & KEY_cdQAProcess))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

            'Execute the Query
            SqlCom.ExecuteNonQuery()

            Call DATA_SEARCH01()
        End If
    End Sub

#End Region


End Class