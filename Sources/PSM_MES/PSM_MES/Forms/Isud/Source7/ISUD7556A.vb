Imports System.Data.SqlClient
Imports System.IO
Public Class ISUD7556A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private KEY_SEQ As String

    Private formA As Boolean

    Private CHK(0 To 5) As String

    Private FormName As String
    Private Parameter As String

#End Region

#Region "Link"
    Public Function Link_ISUD7556A(job As Integer, _FormName As String, Value As String) As Boolean
        FormName = "PFK" + Strings.Mid(_FormName, 5, 4)

        Parameter = Value
        wJOB = job
        Link_ISUD7556A = False

        Select Case job
            Case 1
            Case Else

        End Select

        formA = False
        Me.Tag = Tag
        Me.ShowDialog()

        Link_ISUD7556A = isudCHK

    End Function

    Public Function Link_ISUD7556B(job As Integer, _FormName As String, Value As String) As Boolean
        FormName = "PFK" + Strings.Mid(_FormName, 4, 4)

        Parameter = Value
        wJOB = job
        Link_ISUD7556B = False

        Select Case job
            Case 1
            Case Else

        End Select

        formA = False
        Me.Tag = Tag
        Me.ShowDialog()

        Link_ISUD7556B = isudCHK

    End Function
#End Region

#Region "Form_load"

    Private Sub ISUD7556A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                Call KEY_COUNT()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                cmd_DEL.Visible = False

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                frm_Condition.Enabled = True
                cmd_DEL.Visible = False
                cmdUpload.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                cmd_DEL.Visible = True
                txt_FormName.Enabled = False

                Call DATA_SEARCH01()

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
                        frm_Condition.Enabled = False
                        cmd_DEL.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"
                cmdUpload.Visible = False
                frm_Condition.Enabled = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        KEY_CHK = ""
        frm_Condition.Enabled = True
        cmd_Cancel.Enabled = True
        cmdUpload.Enabled = True
        cmd_DEL.Enabled = True
        cmd_Cancel.Visible = True
        cmdUpload.Visible = True
        cmd_DEL.Visible = True
    End Sub

    Private Sub FORM_INIT()
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
        Try
            SQL = "DELETE FROM [dbo].[PFK7556] "
            SQL = SQL & " WHERE [K7556_TABLE] = '" + FormName + "'"
            SQL = SQL & " AND [K7556_PAREMETER] = '" + Parameter + "'"
            SQL = SQL & " AND [K7556_SEQ] = '" + CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex)).ToString + "'"
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            SPR_CLEAR(Vs1, Vs1.ActiveSheet.ActiveRowIndex, 0, Vs1.ActiveSheet.ActiveRowIndex, Vs1.ActiveSheet.ColumnCount - 1)
            setData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex, "[DELETED]")
            'Call MsgBoxP("Delete Successfully!", vbInformation)

            'Call DATA_SEARCH01()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(K7556_SEQ) AS MAX_CODE FROM [PFK7556] "
        SQL = SQL & " WHERE K7556_TABLE     = '" + FormName + "'"
        SQL = SQL & " AND [K7556_PAREMETER] = '" + Parameter + "'"


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
    Private Function DATA_SEARCH00() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH00 = False

        DATA_SEARCH00 = True

        DS2 = PrcDS("USP_ISUD7556A_SEARCH_VS0", cn, FormName, Parameter)
        SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7556A_SEARCH_VS0", "Vs1")

    End Function

    Private Function DATA_SEARCH01() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH01 = False

        DATA_SEARCH01 = True

        DS2 = PrcDS("USP_ISUD7556A_SEARCH_VS1", cn, FormName, Parameter)


        SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7556A_SEARCH_VS1", "Vs1")
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

        Call DATA_SEARCH01()

    End Sub

    Private Sub upLoadImageOrFile(ByVal sFilePath As String, ByVal sFileType As String)
        Dim SqlCom As SqlCommand
        Dim MaxByte As Integer = 1024 * 1024 * 2
        Dim imageData As Byte()


        Dim sFileName As String

        Dim qry As String

        Try

            'Convert File to bytes Array
            imageData = ReadFile(sFilePath)
            If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
            sFileName = System.IO.Path.GetFileName(sFilePath)

            'Set insert query 
            qry = "insert into [PFK7556] ([K7556_TABLE],[K7556_PAREMETER],[K7556_SEQ],[K7556_FileName],[K7556_ImageData]," & _
            "[K7556_FileType],[K7556_AttachDate],[K7556_AttachIncharge],[K7556_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Call KEY_COUNT()

            SqlCom.Parameters.Add(New SqlParameter("@TABLE", FormName))
            SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", Parameter))
            SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.NAM))
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
            strSql = "Select K7556_ImageData from [PFK7556] "
            strSql = strSql & "WHERE [K7556_TABLE]= '" + getData(Vs1, getColumIndex(Vs1, "Key_TABLE"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   [K7556_PAREMETER]= '" + getData(Vs1, getColumIndex(Vs1, "Key_PAREMETER"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
            strSql = strSql & "AND   [K7556_SEQ]= '" + getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex) + "'"

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
            strSql = "Select K7556_ImageData from [PFK7556] "
            strSql = strSql & "WHERE [K7556_TABLE]= '" & getData(Vs1, getColumIndex(Vs1, "Key_TABLE"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7556_PAREMETER]= '" & getData(Vs1, getColumIndex(Vs1, "Key_PAREMETER"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
            strSql = strSql & "AND   [K7556_SEQ]= '" & getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex) & "'"

            Dim sqlCmd As New SqlCommand(strSql, cn)

            sFileName = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)

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
        SaveFile.FileName = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)
        'Open the File Dialog to select the file
        If (SaveFile.ShowDialog(Me) = DialogResult.OK) Then


            'For Document
            Try
                'Get image data from gridview column. 
                strSql = "Select K7556_ImageData from [PFK7556] "
                strSql = strSql & "WHERE [K7556_TABLE]= '" & getData(Vs1, getColumIndex(Vs1, "Key_TABLE"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
                strSql = strSql & "AND   [K7556_PAREMETER]= '" & getData(Vs1, getColumIndex(Vs1, "Key_PAREMETER"), Vs1.ActiveSheet.ActiveRowIndex) & "'"
                strSql = strSql & "AND   [K7556_SEQ]= '" & getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex) & "'"

                Dim sqlCmd As New SqlCommand(strSql, cn)

                sFileName = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)

                'Get image data from DB
                Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

                Dim sTempFileName As String = SaveFile.FileName & getData(Vs1, getColumIndex(Vs1, "FileType"), Vs1.ActiveSheet.ActiveRowIndex) ' System.IO.Path.GetTempPath & "\" & sFileName

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

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim strSql As String = ""
        Me.lblUploadStatus.Data = ""

        Try

            If chk_MultiView.Checked = False Then
                Select Case getData(Vs1, getColumIndex(Vs1, "FileType"), e.Row)
                    Case "bmp", "jpg", "jpeg", "gif", "png"
                        txtFileToUpload.Data = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)

                        strSql = "Select K7556_ImageData  AS ImageData from [PFK7556] "
                        strSql = strSql & "WHERE [K7556_TABLE]= '" + getData(Vs1, getColumIndex(Vs1, "Key_TABLE"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
                        strSql = strSql & "AND   [K7556_PAREMETER]= '" + getData(Vs1, getColumIndex(Vs1, "Key_PAREMETER"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
                        strSql = strSql & "AND   [K7556_SEQ] = '" & getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex) & "'"

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
                        End If

                    Case Else
                        downLoadFile()

                End Select

            Else
                txtFileToUpload.Data = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)

                If ListPic.Contains(txtFileToUpload.Data) Then Exit Sub

                ListPic.Add(txtFileToUpload.Data)

                Select Case getData(Vs1, getColumIndex(Vs1, "FileType"), e.Row)
                    Case "bmp", "jpg", "jpeg", "gif", "png"
                        txtFileToUpload.Data = getData(Vs1, getColumIndex(Vs1, "FileName"), Vs1.ActiveSheet.ActiveRowIndex)

                        strSql = "Select K7556_ImageData  AS ImageData from [PFK7556] "
                        strSql = strSql & "WHERE [K7556_TABLE]= '" + getData(Vs1, getColumIndex(Vs1, "Key_TABLE"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
                        strSql = strSql & "AND   [K7556_PAREMETER]= '" + getData(Vs1, getColumIndex(Vs1, "Key_PAREMETER"), Vs1.ActiveSheet.ActiveRowIndex) + "'"
                        strSql = strSql & "AND   [K7556_SEQ] = '" & getData(Vs1, getColumIndex(Vs1, "KEY_SEQ"), Vs1.ActiveSheet.ActiveRowIndex) & "'"

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

                            If CntPic = 0 Then

                                shw_PictureBox.Tag = txtFileToUpload.Data

                                shw_PictureBox.Image = newImage
                                shw_PictureBox.SizeMode = cmb_State.SelectedIndex 'PictureBoxSizeMode.StretchImage
                                shw_PictureBox.BorderStyle = BorderStyle.FixedSingle
                                CntPic = 1

                                shw_PictureBox.Size = New Size(pnl_Picture.Size.Width, pnl_Picture.Size.Height)

                            ElseIf CntPic < 4 Then
                                Dim mPictureBox As New PictureBox
                                mPictureBox.Tag = txtFileToUpload.Data
                                mPictureBox.Image = newImage
                                mPictureBox.BorderStyle = BorderStyle.FixedSingle
                                mPictureBox.SizeMode = cmb_State.SelectedIndex ' PictureBoxSizeMode.StretchImage

                                pnl_Picture.Controls.Add(mPictureBox)

                                CntPic += 1

                                For Each M As PictureBox In pnl_Picture.Controls
                                    M.Size = New Size(pnl_Picture.Size.Width / 2 - ConstMargin, pnl_Picture.Size.Height / 2 - ConstMargin)
                                Next

                            ElseIf CntPic < 6 Then
                                Dim mPictureBox As New PictureBox
                                mPictureBox.Tag = txtFileToUpload.Data
                                mPictureBox.Image = newImage
                                mPictureBox.BorderStyle = BorderStyle.FixedSingle
                                mPictureBox.SizeMode = cmb_State.SelectedIndex ' PictureBoxSizeMode.StretchImage

                                pnl_Picture.Controls.Add(mPictureBox)

                                CntPic += 1

                                For Each M As PictureBox In pnl_Picture.Controls
                                    M.Size = New Size(pnl_Picture.Size.Width / 3 - ConstMargin, pnl_Picture.Size.Height / 2 - ConstMargin)
                                Next

                            ElseIf CntPic < 8 Then
                                Dim mPictureBox As New PictureBox
                                mPictureBox.Tag = txtFileToUpload.Data
                                mPictureBox.Image = newImage
                                mPictureBox.BorderStyle = BorderStyle.FixedSingle
                                mPictureBox.SizeMode = cmb_State.SelectedIndex ' PictureBoxSizeMode.StretchImage

                                pnl_Picture.Controls.Add(mPictureBox)

                                CntPic += 1

                                For Each M As PictureBox In pnl_Picture.Controls
                                    M.Size = New Size(pnl_Picture.Size.Width / 3 - ConstMargin, pnl_Picture.Size.Height / 3 - ConstMargin)
                                Next

                            ElseIf CntPic < 12 Then
                                Dim mPictureBox As New PictureBox
                                mPictureBox.Tag = txtFileToUpload.Data
                                mPictureBox.Image = newImage
                                mPictureBox.BorderStyle = BorderStyle.FixedSingle
                                mPictureBox.SizeMode = cmb_State.SelectedIndex ' PictureBoxSizeMode.StretchImage

                                pnl_Picture.Controls.Add(mPictureBox)

                                CntPic += 1

                                For Each M As PictureBox In pnl_Picture.Controls
                                    M.Size = New Size(pnl_Picture.Size.Width / 4 - ConstMargin, pnl_Picture.Size.Height / 3 - ConstMargin)
                                Next

                            ElseIf CntPic < 16 Then
                                Dim mPictureBox As New PictureBox
                                mPictureBox.Tag = txtFileToUpload.Data
                                mPictureBox.Image = newImage
                                mPictureBox.BorderStyle = BorderStyle.FixedSingle
                                mPictureBox.SizeMode = cmb_State.SelectedIndex 'PictureBoxSizeMode.StretchImage

                                pnl_Picture.Controls.Add(mPictureBox)

                                CntPic += 1

                                For Each M As PictureBox In pnl_Picture.Controls
                                    M.Size = New Size(pnl_Picture.Size.Width / 4 - ConstMargin, pnl_Picture.Size.Height / 4 - ConstMargin)
                                Next

                            Else
                                Exit Sub

                            End If


                        End If

                End Select


            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private CntPic As Integer = 0
    Private ListPic As New List(Of String)
    Private ConstMargin As Integer = 10
    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles shw_PictureBox.Click
        PICTURE.PictureBox1.Image = shw_PictureBox.Image
        PICTURE.PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PICTURE.ShowDialog()
    End Sub

    Private Sub cmd_Capture_Click(sender As Object, e As EventArgs) Handles cmd_Capture.Click
        If frmSnipMain.frmSnipMain_Link(FormName, Parameter) = False Then Exit Sub
        Call DATA_SEARCH01()
    End Sub
    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Call DATA_DELETE()
        End If
    End Sub

    Private Sub chk_MultiView_CheckedChanged(sender As Object, e As EventArgs) Handles chk_MultiView.CheckedChanged
        Try
            For Each m As PictureBox In pnl_Picture.Controls
                If m.Name <> "shw_PictureBox" Then m.Dispose()
            Next

            ListPic.Clear()

            shw_PictureBox.Size = New Size(pnl_Picture.Size.Width, pnl_Picture.Size.Height)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PastePicture()
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

                If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
                'Set insert query 
                qry = "insert into [PFK7556] ([K7556_TABLE],[K7556_PAREMETER],[K7556_SEQ],[K7556_FileName],[K7556_ImageData]," & _
                "[K7556_FileType],[K7556_AttachDate],[K7556_AttachIncharge],[K7556_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()

                sFileName = KEY_SEQ
                SqlCom.Parameters.Add(New SqlParameter("@TABLE", FormName))
                SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", Parameter))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.NAM))
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

        End Try


    End Sub

    Private Sub cmd_Camera_Click(sender As Object, e As EventArgs) Handles cmd_Camera.Click
        Dim d As New DevExpress.XtraEditors.Camera.TakePictureDialog()
        If d.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim i As Image = d.Image

            Dim SqlCom As SqlCommand
            Dim MaxByte As Integer = 1024 * 1024 * 2
            Dim imageData As Byte()
            Dim sFileName As String
            Dim qry As String
            Dim sFileType As String = "jpeg"
            Dim Fs As MemoryStream
            d.Image.Save(Fs, Imaging.ImageFormat.Jpeg)
            imageData = Fs.GetBuffer

            If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 2 MB!") : Exit Sub
            'Set insert query 
            qry = "insert into [PFK7556] ([K7556_TABLE],[K7556_PAREMETER],[K7556_SEQ],[K7556_FileName],[K7556_ImageData]," & _
            "[K7556_FileType],[K7556_AttachDate],[K7556_AttachIncharge],[K7556_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

            'Initialize SqlCommand object for insert. 
            SqlCom = New SqlCommand(qry, cn)

            'We are passing File Name and Image byte data as sql parameters. 
            Call KEY_COUNT()

            sFileName = KEY_SEQ
            SqlCom.Parameters.Add(New SqlParameter("@TABLE", FormName))
            SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", Parameter))
            SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

            SqlCom.Parameters.Add(New SqlParameter("@FileName", KEY_SEQ))

            SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

            SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
            SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
            SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.NAM))
            SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

            'Execute the Query
            SqlCom.ExecuteNonQuery()


        End If
    End Sub

#End Region


 
   
End Class