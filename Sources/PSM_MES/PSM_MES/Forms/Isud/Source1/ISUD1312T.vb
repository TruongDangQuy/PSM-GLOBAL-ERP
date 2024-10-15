Imports System.Data.SqlClient
Imports System.IO
Public Class ISUD1312T
#Region "Variable"
    Private wJOB As Integer

    Private W1312 As T1312_AREA
    Private L1312 As T1312_AREA

    Private W1360 As T1360_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False

    Private KEY_CHK As String
    Private KEY_SEQ As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private FormName As String
    Private Parameter As String
#End Region

#Region "Link"
    Public Function Link_ISUD1312T(job As Integer, OrderNo As String, OrderNoSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D1312.OrderNo = OrderNo
        D1312.OrderNoSeq = OrderNoSeq

        FormName = Me.Name
        Parameter = OrderNo & ";" & OrderNoSeq

        wJOB = job : L1312 = D1312

        Link_ISUD1312T = False

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK1312(L1312.OrderNo, L1312.OrderNoSeq) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD1312T = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("BaseComponentBOM"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub ISUD7555A_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.V Then
            Call PastePicture()
        End If
    End Sub

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
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH01()

                Setfocus(txt_Color)
            Case 2
                Me.Text = "GROUP COMPONENT BOM ISUD1312T" & " - SEARCH"
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH01()
            Case 3
                Me.Text = "GROUP COMPONENT BOM ISUD1312T" & " - UPDATE"
                txt_OrderNo.Enabled = False

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
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH01()

            Case 4                                                      '»èÁ¦
                Me.Text = "GROUP COMPONENT BOM ISUD1312T" & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH01()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_OrderNo.Enabled = False
            Call D1312_CLEAR()
            W1312 = D1312

            txt_DateTesting.Data = Pub.DAT
            txt_DateFitting.Data = Pub.DAT

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        txt_OrderNo.Data = L1312.OrderNo
        txt_OrderNoSeq.Data = L1312.OrderNoSeq

        If READ_PFK1312(L1312.OrderNo, L1312.OrderNoSeq) Then
            If READ_PFK7106(D1312.ShoesCode) Then
                txt_Article.Data = D7106.Article
                txt_Line.Data = D7106.Line
                txt_Color.Data = D7106.ColorName
            End If

            txt_RemarkOther.Data = D1312.RemarkOther

            If D1312.CheckFitting = "1" Then rad_CheckFitting1.Checked = True
            If D1312.CheckFitting = "2" Then rad_CheckFitting2.Checked = True
            If D1312.CheckFitting = "3" Then rad_CheckFitting3.Checked = True

            If D1312.CheckTesting = "1" Then rad_CheckTesting1.Checked = True
            If D1312.CheckTesting = "2" Then rad_CheckTesting2.Checked = True
            If D1312.CheckTesting = "3" Then rad_CheckTesting3.Checked = True

            DATA_SEARCH_HEAD = True

        End If

    End Function


#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Data_Check = False
        Try
            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            If READ_PFK1312(L1312.OrderNo, L1312.OrderNoSeq) Then
                W1312 = D1312
                If rad_CheckFitting1.Checked = True Then W1312.CheckFitting = "1"
                If rad_CheckFitting2.Checked = True Then W1312.CheckFitting = "2"
                If W1312.CheckFitting <> "" Then W1312.InchargeFitting = Pub.SAW : W1312.DateFitting = txt_DateFitting.Data

                If rad_CheckFitting3.Checked = True Then W1312.CheckFitting = "3" : W1312.InchargeFitting = Pub.SAW : W1312.DateFitting = txt_DateFitting.Data

                If rad_CheckTesting1.Checked = True Then W1312.CheckTesting = "1"
                If rad_CheckTesting2.Checked = True Then W1312.CheckTesting = "2"
                If W1312.CheckTesting <> "" Then W1312.InchargeTesting = Pub.SAW : W1312.DateTesting = txt_DateTesting.Data

                If rad_CheckTesting3.Checked = True Then W1312.CheckTesting = "3" : W1312.InchargeTesting = Pub.SAW : W1312.DateTesting = txt_DateTesting.Data

                W1312.RemarkOther = txt_RemarkOther.Data

                isudCHK = True
                WRITE_CHK = "*"

                If REWRITE_PFK1312(W1312) = True Then
                    D1360_CLEAR()
                    W1360 = D1360

                    W1360.OrderNo = D1312.OrderNo
                    W1360.OrderNoSeq = D1312.OrderNoSeq

                    W1360.DateFitting = D1312.DateFitting
                    W1360.CheckFitting = D1312.CheckFitting
                    W1360.InchargeFitting = D1312.InchargeTesting

                    W1360.DateInsert = Pub.DAT
                    W1360.InchargeInsert = D1312.InchargeTesting

                    W1360.DateTesting = D1312.DateTesting
                    W1360.CheckTesting = D1312.CheckTesting
                    W1360.InchargeTesting = D1312.InchargeTesting

                    W1360.Remark = txt_RemarkOther.Data

                    Call WRITE_PFK1360(W1360)

                End If

            End If

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub

    Private Function DATA_SEARCH01() As Boolean
        Dim ds As New DataSet
        DATA_SEARCH01 = False

        DATA_SEARCH01 = True

        DS2 = PrcDS("USP_ISUD7555A_SEARCH_VS1", cn, FormName, Parameter)


        SPR_PRO_NEW(Vs1, DS2, "USP_ISUD7555A_SEARCH_VS1", "Vs1")
    End Function

    Private Sub DATA_INSERT()
        Try
            Call DATA_MOVE()
            Call DATA_MOVE_WRITE01()
            isudCHK = True : WRITE_CHK = "*"
            Exit Sub
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            isudCHK = True : WRITE_CHK = "*"

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK1312(L1312.OrderNo, L1312.OrderNoSeq) = True Then

                SQL = "UPDATE PFK1312 SET"
                SQL = SQL & "   K1312_CheckFitting      = ''"
                SQL = SQL & " , K1312_DateFitting       = ''"
                SQL = SQL & " , K1312_CheckTesting      = ''"
                SQL = SQL & " , K1312_DateTesting       = ''"
                SQL = SQL & " , K1312_RemarkOther       = ''"

                SQL = SQL & " WHERE	K1312_OrderNo       = '" & L1312.OrderNo & "'"
                SQL = SQL & " AND	K1312_OrderNoSeq    = '" & L1312.OrderNoSeq & "'"

                'SQL = "DELETE FROM PFK1312 "
                'SQL = SQL & " WHERE K1312_OrderNo  = '" & L1312.OrderNo & "' "
                'SQL = SQL & " AND  K1312_OrderNoSeq  = '" & L1312.OrderNoSeq & "' "

                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                isudCHK = True : WRITE_CHK = "*"
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

#End Region

#Region "Event"

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim strSql As String = ""

        Try
            downLoadFile()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())
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

            Dim sTempFileName As String = System.IO.Path.GetTempPath & "\" & sFileName

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

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK1312") = False Then Exit Sub
                Call DATA_INSERT()
                 Me.Dispose()
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK1312") = False Then Exit Sub
                Call DATA_UPDATE()
                Me.Dispose()
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
        Me.Dispose()
    End Sub



    Private Sub cmd_Upload_Click(sender As Object, e As EventArgs)
        Try

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                'Open the File Dialog to select the file
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    Vs1.OpenExcel(OpenFileDialog.FileName)
                    ChkUpload = True
                Else 'Cancel

                    Exit Sub

                End If

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Friend Shared Function GetExcelFile(ByVal strFileName As String, ByVal strPath As String) As DataTable

        Try

            Dim dt As New DataTable

            Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strPath & ";Extended Properties=""Text;HDR=Yes;FMT=Delimited\"""
            Dim conn As New OleDb.OleDbConnection(ConStr)
            Dim da As New OleDb.OleDbDataAdapter("Select * from " & strFileName, conn)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function

    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(K7555_SEQ) AS MAX_CODE FROM [PFK7555] "
        SQL = SQL & " WHERE K7555_TABLE     = '" + FormName + "'"
        SQL = SQL & " AND [K7555_PAREMETER] = '" + Parameter + "'"


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

    Private Sub PastePicture()

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
                qry = "insert into [PFK7555] ([K7555_TABLE],[K7555_PAREMETER],[K7555_SEQ],[K7555_FileName],[K7555_ImageData]," & _
                "[K7555_FileType],[K7555_AttachDate],[K7555_AttachIncharge],[K7555_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()


                sFileName = KEY_SEQ
                sFileName = System.IO.Path.GetFileNameWithoutExtension(Clipboard.GetFileDropList(i))

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

            Next

            Call DATA_SEARCH01()

        Catch ex As Exception
            MessageBox.Show(ex.ToString())

        Finally
            Starting.Close()


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

#End Region

End Class