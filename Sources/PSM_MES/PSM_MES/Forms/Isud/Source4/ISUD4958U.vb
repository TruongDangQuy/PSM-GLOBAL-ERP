Public Class ISUD4958U

#Region "Variable"

    Private wJOB As Integer

    Private W7106 As T7106_AREA
    Private L7171 As T7171_AREA

    Private W1311 As New T1311_AREA
    Private L1311 As New T1311_AREA

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private W4958 As New T4958_AREA
    Private L4958 As New T4958_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False
    Private cdGroupComponent As String

    Private formA As Boolean
    Private CHK(0 To 5) As String


    Private Enum colVs1
        Customer = 0
        Season = 1
        SLNO = 2
        CustomerCountry = 3
        CustomerPO = 4
        SAPPO = 5
        PATTERN = 6
        Material = 7
        Color = 8
        PackType = 9
        CTTYPEFrom = 10
        CTTYPESymbol = 11
        CTTYPETo = 12
        CTNS = 13
        CTTYPE = 14
        QTY_CNT = 15
    End Enum




#End Region

#Region "Link"
    Public Function Link_ISUD4958U(job As Integer, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        '   D7115.ShoesCode = ShoesCode

        wJOB = job

        Link_ISUD4958U = False

        Try
            Select Case job
                Case 1
                Case Else
                    'If READ_PFK7106(ShoesCode) = False Then
                    '    Call MsgBoxP("3", "Link_ISUD4958U")

                    '    Me.Dispose()
                    '    Exit Function
                    'End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4958U = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4958U"))
        End Try

    End Function

#End Region

#Region "Form"

    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        wJOB = 1

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Tag, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = True

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                cmd_DEL.Visible = True
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

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
                Call DATA_SEARCH_VS2()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog

    End Function

    Private Sub FORM_INIT()

    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        'DATA_SEARCH01 = False
        'Dim i As Integer

        'If CIntp(txt_CustomerCode.Code) = 0 Then Exit Function
        'If READ_PFK7101_CODE(txt_CustomerCode.Code) = False Then Exit Function

        'SQL = " SELECT K9001_MappingNo, K9001_MappingName FROM PFK9001 WHERE K9001_CustomerCode = '" + txt_CustomerCode.Code + "'"
        'cmd = New SqlClient.SqlCommand(SQL, cn)
        'DS1 = PrcDS(cmd, cn)

        'txt_MappingNo.Items.Clear()

        'If GetDsRc(DS1) > 0 Then
        '    For i = 0 To GetDsRc(DS1) - 1
        '        txt_MappingNo.Items.Add(GetDsData(DS1, i, "K9001_MappingNo") & ";" & GetDsData(DS1, i, "K9001_MappingName"))
        '    Next
        '    txt_MappingNo.SelectedIndex = 0
        'End If

    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        'DATA_SEARCH_VS2 = False
        'Dim Value() As String

        'Value = txt_MappingNo.Text.Split(";")

        'DS1 = PrcDS("USP_ISUD0101U_SEARCH_VS2", cn, Value(0))

        'If GetDsRc(DS1) = 0 Then
        '    SPR_PRO_NEW(vS2, DS1, "USP_ISUD0101U_SEARCH_VS2", "VS2")
        '    vS2.Enabled = True
        '    Exit Function
        'End If

        'SPR_PRO_NEW(vS2, DS1, "USP_ISUD0101U_SEARCH_VS2", "VS2")

        'DATA_SEARCH_VS2 = True
    End Function


#End Region

#Region "Function"

    Public Function READ_PFK1312_INFO(CustomerCode As String, cdSeason As String, SLNo As String, ByRef Con As SqlClient.SqlConnection) As DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Dim dsnew As New DataSet
        Dim SQL As String
        Try
            SQL = " SELECT  K1312_OrderNo "
            SQL = SQL & " , K1312_OrderNoSeq "
            SQL = SQL & " , K1312_ShoesCode "
            SQL = SQL & " , K1312_FacPO "
            SQL = SQL & " , K1312_SLNo "
            SQL = SQL & " , K1311_cdSeason "
            SQL = SQL & " , K1311_CustomerCode "
            SQL = SQL & " , K1312_CustomerName "
            SQL = SQL & " , K1312_SizeRange "
            SQL = SQL & " , K7104_SizeRangeName "
            SQL = SQL & "   FROM    [dbo].[PFK1312]  "
            SQL = SQL & "   INNER JOIN	PFK1311             with (nolock)               "
            SQL = SQL & "           ON	K1311_OrderNo		=	[K1312_OrderNo]         "
            SQL = SQL & "   LEFT JOIN	PFK7104             AS	Z2  with (nolock)       "
            SQL = SQL & "           ON	K1312_SizeRange		=	Z2.K7104_SizeRange      "
            SQL = SQL & "   WHERE       K1311_CustomerCode	= '" & CustomerCode & "' "
            SQL = SQL & "       AND     K1311_cdSeason	    = '" & cdSeason & "' "
            SQL = SQL & "       AND     K1312_SLNo		    = '" & SLNo & "' "
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(dsnew, "SP")
            Return dsnew

        Catch ex As Exception
            Call MsgBoxP("READ_PFK1312_INFO", vbCritical)
            Return Nothing
        Finally
            da = Nothing
            dsnew = Nothing
        End Try
    End Function

    Public Function READ_PFK7210_CartonType(CartonType As String) As Boolean
        READ_PFK7210_CartonType = False

        Dim cmd As SqlClient.SqlCommand
        Dim SQL As String
        Try
            SQL = " SELECT * FROM PFK7210 "
            SQL = SQL & " WHERE K7210_CartonType		 = '" & CartonType & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Call D7210_CLEAR() : GoTo SKIP_READ_PFK7210

            Call K7210_MOVE(rd)
            READ_PFK7210_CartonType = True

SKIP_READ_PFK7210:
            rd.Close()
            Exit Function
        Catch ex As Exception
            Call MsgBoxP("READ_PFK7210_CartonType", vbCritical)
        End Try
    End Function



    Private Function DATA_MOVE_WRITE_K4958() As Boolean
        DATA_MOVE_WRITE_K4958 = False
        Try
            Dim i As Integer
            Dim j As Integer
            Dim dsnew1 As New DataSet

            Dim rowstart As Integer = 2 + 1
            Dim colstart As Integer = 0

            Dim NoStart As Integer
            Dim NoEnd As Integer

            Dim CustomerCode As String
            Dim cdSeason As String
            Dim SLNo As String

            Dim value_no As Integer


            For i = rowstart To Vs1.ActiveSheet.NonEmptyRowCount - 1

                'kiem tra customercode
                If getData(Vs1, colVs1.Customer, i).ToString.Trim = "" Then Exit Function

                'kiem tra dong tong TTL 11
                If getData(Vs1, 11, i).ToString.Trim.ToUpper = "TTL:" Then Exit Function

                CustomerCode = FormatP(getData(Vs1, 0, i), "000000")
                cdSeason = FormatP(getData(Vs1, 1, i), "000")
                SLNo = Trim(getData(Vs1, 2, i))

                dsnew1 = READ_PFK1312_INFO(CustomerCode, cdSeason, SLNo, cn)

                If GetDsData(dsnew1, 0, "K1312_OrderNo") = "" Or GetDsData(dsnew1, 0, "K1312_OrderNoSeq") = "" Then Call MsgBox("Wrong Order information!") : Exit Function


                '  If GetDsRc(dsnew1) = 0 Then GoTo skip

                W4958.ProductInBoundNo = ""
                W4958.ProductInBoundSeq = ""
                W4958.PackingBatch = ""
                W4958.PackingCusBatch = ""
                W4958.sePackingType = ""

                W4958.cdPackingType = getData(Vs1, colVs1.PackType, i)
                If READ_PFK7171(ListCode("PackingCode"), W4958.cdPackingType) = True Then
                    W4958.PackingTypeName = D7171.BasicName
                Else
                    W4958.PackingTypeName = ""
                End If

                W4958.DatePacking = ""
                W4958.CustomerCode = GetDsData(dsnew1, 0, "K1311_CustomerCode")


                If READ_PFK7210_CartonType(getData(Vs1, colVs1.CTTYPE, i)) = True Then
                    W4958.CartonCode = D7210.CartonCode
                Else
                    W4958.CartonCode = ""
                End If

                W4958.LoadingNo = ""
                W4958.LoadingCode = ""
                W4958.LoadingSeq = ""
                W4958.OrderNo = GetDsData(dsnew1, 0, "K1312_OrderNo")
                W4958.OrderNoSeq = GetDsData(dsnew1, 0, "K1312_OrderNoSeq")
                W4958.FactOrderNo = ""
                W4958.FactOrderSeq = 0
                W4958.JobCard = ""
                W4958.SizeGroup = ""
                W4958.QtyPrs = CDblp(getData(Vs1, colVs1.QTY_CNT, i))

                W4958.SizeQty01 = CDblp(getData(Vs1, colVs1.QTY_CNT + 1, i))
                W4958.SizeQty02 = CDblp(getData(Vs1, colVs1.QTY_CNT + 2, i))
                W4958.SizeQty03 = CDblp(getData(Vs1, colVs1.QTY_CNT + 3, i))
                W4958.SizeQty04 = CDblp(getData(Vs1, colVs1.QTY_CNT + 4, i))
                W4958.SizeQty05 = CDblp(getData(Vs1, colVs1.QTY_CNT + 5, i))
                W4958.SizeQty06 = CDblp(getData(Vs1, colVs1.QTY_CNT + 6, i))
                W4958.SizeQty07 = CDblp(getData(Vs1, colVs1.QTY_CNT + 7, i))
                W4958.SizeQty08 = CDblp(getData(Vs1, colVs1.QTY_CNT + 8, i))
                W4958.SizeQty09 = CDblp(getData(Vs1, colVs1.QTY_CNT + 9, i))
                W4958.SizeQty10 = CDblp(getData(Vs1, colVs1.QTY_CNT + 10, i))
                W4958.SizeQty11 = CDblp(getData(Vs1, colVs1.QTY_CNT + 11, i))
                W4958.SizeQty12 = CDblp(getData(Vs1, colVs1.QTY_CNT + 12, i))
                W4958.SizeQty13 = CDblp(getData(Vs1, colVs1.QTY_CNT + 13, i))
                W4958.SizeQty14 = CDblp(getData(Vs1, colVs1.QTY_CNT + 14, i))
                W4958.SizeQty15 = CDblp(getData(Vs1, colVs1.QTY_CNT + 15, i))
                W4958.SizeQty16 = CDblp(getData(Vs1, colVs1.QTY_CNT + 16, i))
                W4958.SizeQty17 = CDblp(getData(Vs1, colVs1.QTY_CNT + 17, i))
                W4958.SizeQty18 = CDblp(getData(Vs1, colVs1.QTY_CNT + 18, i))
                W4958.SizeQty19 = CDblp(getData(Vs1, colVs1.QTY_CNT + 19, i))
                W4958.SizeQty20 = CDblp(getData(Vs1, colVs1.QTY_CNT + 20, i))
                W4958.SizeQty21 = CDblp(getData(Vs1, colVs1.QTY_CNT + 21, i))
                W4958.SizeQty22 = CDblp(getData(Vs1, colVs1.QTY_CNT + 22, i))
                W4958.SizeQty23 = CDblp(getData(Vs1, colVs1.QTY_CNT + 23, i))
                W4958.SizeQty24 = CDblp(getData(Vs1, colVs1.QTY_CNT + 24, i))
                W4958.SizeQty25 = CDblp(getData(Vs1, colVs1.QTY_CNT + 25, i))
                W4958.SizeQty26 = CDblp(getData(Vs1, colVs1.QTY_CNT + 26, i))
                W4958.SizeQty27 = CDblp(getData(Vs1, colVs1.QTY_CNT + 27, i))
                W4958.SizeQty28 = CDblp(getData(Vs1, colVs1.QTY_CNT + 28, i))
                W4958.SizeQty29 = CDblp(getData(Vs1, colVs1.QTY_CNT + 29, i))
                W4958.SizeQty30 = CDblp(getData(Vs1, colVs1.QTY_CNT + 30, i))

                W4958.PackingCMB = 0
                W4958.PackingGW = 0
                W4958.PackingNW = 0
                W4958.QtyPacking = 0
                W4958.QtyLoading = 0
                W4958.JCPREFIX1 = ""
                W4958.JCPREFIX2 = ""
                W4958.JOBCARDNO = ""
                W4958.ColorCode = ""
                W4958.MCODENAME = ""
                W4958.PONO = ""
                W4958.PKONO = ""
                W4958.SlNoD = ""
                W4958.SlNo = ""
                W4958.SizeRangeName = GetDsData(dsnew1, 0, "K7104_SizeRangeName")
                W4958.seSeason = ListCode("Season")
                W4958.cdSeason = GetDsData(dsnew1, 0, "K1311_cdSeason")

                W4958.DateInsert = Pub.DAT
                W4958.DateUpdate = Pub.DAT
                W4958.InchargeInsert = Pub.SAW
                W4958.InchargeUpdate = Pub.SAW
                W4958.CheckUse = "1"
                W4958.CheckComplete = "2"
                W4958.Remark = "Upload From Excel !"

                NoStart = CDblp(getData(Vs1, colVs1.CTTYPEFrom, i))
                NoEnd = CDblp(getData(Vs1, colVs1.CTTYPETo, i))

                value_no = NoStart

                Do While value_no >= NoStart And value_no <= NoEnd
                    W4958.CartonNo = value_no
                    Call WRITE_PFK4958(W4958)
                    value_no += 1
                Loop

                value_no = 0

                isudCHK = True
skip:
            Next

            DATA_MOVE_WRITE_K4958 = True

        Catch ex As Exception
            MsgBoxP("DATA_MOVE_WRITE_K4958")
        End Try

    End Function


    Private Sub DATA_DELETE()
        Try

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

#End Region

#Region "Event"
   

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        ' If Data_Check() = False Then Exit Sub
        Try
            If DATA_MOVE_WRITE_K4958() = True Then
                MsgBoxP("Upload successfull !")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_Upload_Click(sender As Object, e As EventArgs) Handles cmd_Upload.Click
        Try

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                'Open the File Dialog to select the file
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then

                    Dim File As String
                    Dim DestTemp As String = OpenFileDialog.FileName + ".temp"

                    IO.File.Copy(OpenFileDialog.FileName, DestTemp)

                    Vs1.OpenExcel(DestTemp)

                    IO.File.Delete(DestTemp)

                    ChkUpload = True
                Else 'Cancel

                    Exit Sub

                End If

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_Main.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_Main.ItemSize = New Size((Me.Width - 30) / ptc_Main.TabCount, 25)
        End If
    End Sub

#End Region

End Class