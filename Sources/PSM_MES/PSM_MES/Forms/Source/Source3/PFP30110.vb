Imports System.Media
Imports System.Runtime.InteropServices

Public Class PFP30110

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

    Public Function Link_PFP30110() As Boolean
        Me.Tag = Tag

        wDateProd = ""
        wcdFactory = ""
        wcdMainProcess = ""
        wcdLineProd = ""
        wBatchGroup = ""
        wcdSubProcess = "001"

        wJOB = 900
        Dim job As Integer = 900

        Link_PFP30110 = False
        Try
            formA = False
            Me.ShowDialog()

            Link_PFP30110 = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4000A"))
        End Try

    End Function
    Public Function Link_PFP30110(job As Integer, DateProd As String, cdFactory As String, cdMainProcess As String, cdLineProd As String, BatchGroup As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        wDateProd = DateProd
        wcdFactory = cdFactory
        wcdMainProcess = cdMainProcess
        wcdLineProd = cdLineProd
        wBatchGroup = BatchGroup
        wcdSubProcess = "001"

        wJOB = job

        Link_PFP30110 = False
        Try

            formA = False
            Me.ShowDialog()

            Link_PFP30110 = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4000A"))
        End Try

    End Function
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load

        Control.CheckForIllegalCrossThreadCalls = False
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        If wJOB = 0 Then wJOB = 1
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

     

        DATA_SEARCH_HEAD_INSERT_ThanhPham = True

      

    End Function
    Private Function DATA_SEARCH_HEAD_INSERT() As Boolean
        DATA_SEARCH_HEAD_INSERT = False


        DS1 = PrcDS("USP_PFP30110_TEXTBOX_INSERT", cn, "", "", "")

        SPR_PRO_NEW(vS1, DS1, "USP_PFP30110_TEXTBOX_INSERT", "vS1")


        DATA_SEARCH_HEAD_INSERT = True

    End Function

#End Region

#Region "Function"

    Private Sub DATA_INIT()
        Try
      
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
            Dim radType As String = "1"

            If rad_MaterialCheck1.Checked Then radType = "1"
            If rad_MaterialCheck2.Checked Then radType = "2"

            Dim xRow As Integer = 0
            vS1.ActiveSheet.RowCount = xRow

            For Each BatchNo As String In txt_Barcode.Text.Trim().Split(New Char() {Environment.NewLine, " "c})
                BatchNo = BatchNo.Trim()

                If String.IsNullOrEmpty(BatchNo) = False Then
                    Try
                        CDblp(BatchNo)
                        vS1.ActiveSheet.RowCount += 1


                        DS1 = PrcDS("USP_PFP30110_TEXTBOX_INSERT", cn, radType, Pub.SAW, BatchNo)

                        If GetDsRc(DS1) > 0 Then
                             READ_SPREAD(vS1, DS1, "USP_PFP30110_TEXTBOX_INSERT", "Vs1", xRow)

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

  

#End Region

End Class