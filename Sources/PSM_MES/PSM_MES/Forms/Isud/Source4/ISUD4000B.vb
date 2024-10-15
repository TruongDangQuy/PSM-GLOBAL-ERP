Imports System.Media
Imports System.Runtime.InteropServices

Public Class ISUD4000B

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

    Private ListBarcode As List(Of String)
#End Region

#Region "Form"

    Public Function Link_ISUD4000B() As Boolean
        Me.Tag = Tag

        wDateProd = ""
        wcdFactory = ""
        wcdMainProcess = ""
        wcdLineProd = ""
        wBatchGroup = ""
        wcdSubProcess = "001"

        wJOB = 900
        Dim job As Integer = 900

        Link_ISUD4000B = False
        Try
            formA = False
            Me.ShowDialog()

            Link_ISUD4000B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4000A"))
        End Try

    End Function
    Public Function Link_ISUD4000B(job As Integer, DateProd As String, cdFactory As String, cdMainProcess As String, cdLineProd As String, BatchGroup As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        wDateProd = DateProd
        wcdFactory = cdFactory
        wcdMainProcess = cdMainProcess
        wcdLineProd = cdLineProd
        wBatchGroup = BatchGroup
        wcdSubProcess = "001"

        wJOB = job

        Link_ISUD4000B = False
        Try

            formA = False
            Me.ShowDialog()

            Link_ISUD4000B = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4000A"))
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

                Application.DoEvents()

                tst_iSave.Visible = True
                tst_iSave.Enabled = True


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


                tst_iSave.Visible = False
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

                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

                Call DATA_SEARCH_HEAD_INSERT()


                tst_iSave.Visible = False

            Case 4
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_HEAD_INSERT()


                tst_iSave.Visible = False
            Case 11

            Case 900
                Me.Text = Me.Text & " - UPLOAD"
                'Me.WindowState = FormWindowState.Maximized
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Me.Show()

                Call DATA_SEARCH_HEAD_INSERT_ThanhPham()


                Application.DoEvents()

                tst_iSave.Visible = True
                tst_iSave.Enabled = True


        End Select

        formA = True
    End Sub

#End Region

#Region "Search"
    Private Function DATA_SEARCH_HEAD_INSERT_ThanhPham() As Boolean
        DATA_SEARCH_HEAD_INSERT_ThanhPham = False

        txt_DateProd.Data = System_Date_8()
        txt_cdFactory_ScanOffline.Enabled = True
        txt_cdMainProcess_ScanOffline.Enabled = True
        txt_cdLineProd_ScanOffline.Enabled = True
        txt_InchargeProdution_ScanOffline.Enabled = True

        txt_cdFactory_ScanOffline.Code = ""
        txt_cdFactory_ScanOffline.Data = ""
        txt_cdMainProcess_ScanOffline.Code = ""
        txt_cdMainProcess_ScanOffline.Data = ""
        txt_cdLineProd_ScanOffline.Code = ""
        txt_cdLineProd_ScanOffline.Data = ""

        If READ_PFK7411(Pub.SAW) Then
            txt_InchargeProdution_ScanOffline.Code = Pub.SAW
            txt_InchargeProdution_ScanOffline.Data = D7411.Name
        End If

        DATA_SEARCH_HEAD_INSERT_ThanhPham = True

        txt_cdMainProcess_ScanOffline.Data = "Nhập kho thành phẩm"
        txt_cdMainProcess_ScanOffline.Code = "III"
        txt_cdMainProcess_ScanOffline.Visible = False

    End Function
    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False


        If READ_PFK7171("300", wcdFactory) = True Then
            txt_cdFactory_ScanOffline.Data = D7171.BasicName
            txt_cdFactory_ScanOffline.Code = D7171.BasicCode
        End If

        If READ_PFK7171("301", wcdLineProd) = True Then
            txt_cdLineProd_ScanOffline.Data = D7171.BasicName
            txt_cdLineProd_ScanOffline.Code = D7171.BasicCode
        End If

        If READ_PFK7171("001", wcdMainProcess) = True Then
            txt_cdMainProcess_ScanOffline.Data = D7171.BasicName
            txt_cdMainProcess_ScanOffline.Code = D7171.BasicCode
        End If

        txt_InchargeProdution_ScanOffline.Data = Pub.SSER
        txt_InchargeProdution_ScanOffline.Code = ""

        DATA_SEARCH_HEAD_INSERT = True

    End Function

#End Region

#Region "Function"

    Private Sub DATA_INIT()
        Try
            txt_DateProd.Data = FormatCut(wDateProd)
            txt_DateProd.Code = FormatCut(wDateProd)
            txt_DateProd.Enabled = True
            txt_DateProd.TextEnabled = True
            vS1.InsChk = False
            Me.WindowState = FormWindowState.Normal

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private CntS As Integer
    Private Function DATA_INSERT() As Boolean
        DATA_INSERT = False
        Try

            Dim EDate As String = ""
            Dim cdFactory As String = ""
            Dim cdMainProcess As String = ""
            Dim cdSubProcess As String = ""
            Dim cdLineProd As String = ""
            Dim Incharge As String = ""

            EDate = txt_DateProd.Data
            cdFactory = txt_cdFactory_ScanOffline.Code
            cdMainProcess = txt_cdMainProcess_ScanOffline.Code
            cdLineProd = txt_cdLineProd_ScanOffline.Code
            Incharge = txt_InchargeProdution_ScanOffline.Code

            If cdFactory = "" Then MsgBoxP("Factory Plz!") : Exit Function
            If cdMainProcess = "" Then MsgBoxP("Main Process Plz!") : Exit Function
            If cdLineProd = "" Then MsgBoxP("Line Prod Plz!") : Exit Function
            If Incharge = "" Then MsgBoxP("Incharge Plz!") : Exit Function

            Dim xRow As Integer = 0
            vS1.ActiveSheet.RowCount = xRow

            For Each BatchNo As String In txt_Barcode.Text.Trim().Split(New Char() {Environment.NewLine, " "c})
                BatchNo = BatchNo.Trim()

                If String.IsNullOrEmpty(BatchNo) = False Then
                    Try
                        CDblp(BatchNo)
                        vS1.ActiveSheet.RowCount += 1

                        DS1 = PrcDS("USP_ISUD4000B_TEXTBOX_INSERT", cn, EDate, _
                                                                    cdFactory, _
                                                                    cdMainProcess, _
                                                                    cdSubProcess, _
                                                                    cdLineProd, _
                                                                    Incharge, _
                                                                    BatchNo)

                        If GetDsRc(DS1) > 0 Then
                            Dim StoreName As String = GetDsData(DS1, 0, 0)
                            If StoreName <> "" Then
                                If xRow = 0 Then
                                    SPR_PRO(vS1, DS1, StoreName, "Vs1")
                                Else
                                    READ_SPREAD(vS1, DS1, StoreName, "Vs1", xRow)
                                End If
                            Else
                                If xRow = 0 Then
                                    SPR_PRO(vS1, DS1, "USP_ISUD4000B_TEXTBOX_INSERT", "Vs1")
                                Else
                                    READ_SPREAD(vS1, DS1, "USP_ISUD4000B_TEXTBOX_INSERT", "Vs1", xRow)
                                End If
                            End If

                            If Trim$(getData(vS1, getColumIndex(vS1, "ColorRow"), xRow)) <> "" Then
                                Dim cShare As System.Drawing.Color
                                If Trim$(getData(vS1, getColumIndex(vS1, "ColorRow"), xRow)) = "Red" Then
                                    cShare = Color.Red
                                ElseIf Trim$(getData(vS1, getColumIndex(vS1, "ColorRow"), xRow)) = "Yellow" Then
                                    cShare = Color.Yellow
                                ElseIf Trim$(getData(vS1, getColumIndex(vS1, "ColorRow"), xRow)) = "Blue" Then
                                    cShare = Color.Blue
                                ElseIf Trim$(getData(vS1, getColumIndex(vS1, "ColorRow"), xRow)) = "SkyBlue" Then
                                    cShare = Color.SkyBlue
                                ElseIf Trim$(getData(vS1, getColumIndex(vS1, "ColorRow"), xRow)) = "Orange" Then
                                    cShare = Color.Orange
                                Else
                                    cShare = New System.Drawing.Color
                                    Dim ColorRGB() As String = Trim$(getData(vS1, getColumIndex(vS1, "Color_ScanOffline"), xRow)).Split(New Char() {":"c})
                                    cShare = System.Drawing.Color.FromArgb(CType(CInt(ColorRGB(0)), Integer), CType(CInt(ColorRGB(1)), Integer), CType(CInt(ColorRGB(2)), Integer))
                                End If
                                Call SPR_FORECOLORCELL(vS1, cShare, getColumIndex(vS1, "OutPutMes"), xRow)
                            End If
                        End If


                        xRow += 1

                    Catch ex As Exception

                    End Try

                End If
            Next
            txt_Barcode.Text = ""

            DATA_INSERT = True
        Catch ex As Exception
        End Try

    End Function

    Private Function DATA_DELETE() As Boolean
        DATA_DELETE = False

        Try
            DATA_DELETE = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_DELETE_LINE(xRow As Integer) As Boolean
        DATA_DELETE_LINE = False
        Try


            DATA_DELETE_LINE = True

        Catch ex As Exception
        End Try

    End Function


#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        If txt_DateProd.Data <> Pub.DAT Then
            MsgBoxP("Can not edit because of not today!")
            If MsgBoxPPW("Please type the password to modify!", const_pwFWH) = False Then Exit Sub
        End If

        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try
      
            Call DATA_INSERT()
        Catch ex As Exception

        Finally
            Starting.close()

            Setfocus(txt_Barcode)
        End Try
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click

        txt_Barcode.Text = ""
        vS1.ActiveSheet.RowCount = 0
     

    End Sub

    Private Sub txt_cdFactory_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdFactory_ScanOffline.btnTitleClick
        If HLP7171D_SCANOFFLINE.Link_HLP7171D("999", "", "", "", "999", "") = True Then
            txt_cdFactory_ScanOffline.Code = hlp0000SeVaTt
            txt_cdFactory_ScanOffline.Data = hlp0000SeVa
        End If

    End Sub

    Private Sub txt_cdMainProcess_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdMainProcess_ScanOffline.btnTitleClick
        If txt_cdFactory_ScanOffline.Code = "" Then
            MsgBoxP("Vui lòng chọn Xưởng!")
            Exit Sub
        End If
        If HLP7171D_SCANOFFLINE.Link_HLP7171D("999", "", txt_cdFactory_ScanOffline.Code, "", "999", "") = True Then
            txt_cdMainProcess_ScanOffline.Code = hlp0000SeVaTt
            txt_cdMainProcess_ScanOffline.Data = hlp0000SeVa
        End If

    End Sub

    Private Sub txt_cdLineProd_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdLineProd_ScanOffline.btnTitleClick
        If HLP7171ALL.Link_HLP7171A("301", "") Then
            txt_cdLineProd_ScanOffline.Code = hlp0000SeVaTt
            txt_cdLineProd_ScanOffline.Data = hlp0000SeVa
        End If
    End Sub

    Private Sub txt_InchargeProdution_ScanOffline_btnTitleClick(sender As Object, e As EventArgs) Handles txt_InchargeProdution_ScanOffline.btnTitleClick
        If HLP7411A.Link_HLP7411A("") Then
            txt_InchargeProdution_ScanOffline.Code = hlp0000SeVaTt
            txt_InchargeProdution_ScanOffline.Data = hlp0000SeVa
        End If
    End Sub

    Private Sub txt_InchargeProdution_ScanOffline_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txt_InchargeProdution_ScanOffline.txtTextKeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            If HLP7411A.Link_HLP7411A(txt_InchargeProdution_ScanOffline.Data) Then
                txt_InchargeProdution_ScanOffline.Code = hlp0000SeVaTt
                txt_InchargeProdution_ScanOffline.Data = hlp0000SeVa
            End If
        End If
    End Sub

#End Region

End Class