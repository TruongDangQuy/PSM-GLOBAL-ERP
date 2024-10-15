Imports System.Data.SqlClient
Imports System.IO
Public Class PFP96000

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Cms_additem(Cms_1,
                        "JOB SCHEDULE PROCCESING - " & WordConv("INPUT") & "(F5)",
                        "JOB SCHEDULE PROCCESING - " & WordConv("SEARCH") & "(F6)",
                        "JOB SCHEDULE PROCCESING - " & WordConv("UPDATE") & "(F7)",
                        "JOB SCHEDULE PROCCESING - " & WordConv("DELETE") & "(F8)",
                        "JOB SCHEDULE PROCCESING - " & WordConv("COPY") & "(F9)")

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        Me.KeyPreview = True

        vS20.ContextMenuStrip = Cms_1
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
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
    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True

        txt_cdWorkflow.Visible = False
    End Sub

    Private Sub DATA_INIT()

        If READ_PFK7411(Pub.SAW) Then
            txt_cdDepartment.Code = D7411.DevelopmenetCode

            If READ_PFK7171(ListCode("InchargePSM"), txt_cdDepartment.Code) Then
                txt_cdDepartment.Data = D7171.BasicName
            End If

        End If

        Call DATA_SEARCH_VS20()
    End Sub
#End Region

#Region "Function"
    Private Sub MAIN_JOB01()
        Dim cdWorkFlow As String

        cdWorkFlow = txt_cdDepartment.Code

        If ISUD9550A.Link_ISUD9550A(1, "", cdWorkFlowList, Me.Name) = False Then Exit Sub
    End Sub
    Private Function cdWorkFlowList() As String
        cdWorkFlowList = ""

        Dim i As Integer

        For i = 0 To Vs10.ActiveSheet.RowCount - 1
            If getDataM(Vs10, getColumIndex(Vs10, "DCHK"), i) = "1" Then
                cdWorkFlowList = cdWorkFlowList & "''" & getData(Vs10, getColumIndex(Vs10, "KEY_AutoKey"), i) & "''"
                cdWorkFlowList = cdWorkFlowList & ","
            End If

next1:
        Next

        If cdWorkFlowList = "" Then Exit Function
        cdWorkFlowList = Strings.Left(cdWorkFlowList, Len(cdWorkFlowList) - 1)

    End Function


    Private Sub MAIN_JOB02()
        If getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim cdWorkFlow As String

        If vS20.Focused = False Then Exit Sub

        cdWorkFlow = getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex)

        If ISUD9550A.Link_ISUD9550A(2, cdWorkFlow, "", Me.Name) = False Then Exit Sub

    End Sub

    Private Sub MAIN_JOB03()
        If getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim cdWorkFlow As String

        If vS20.Focused = False Then Exit Sub

        cdWorkFlow = getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex)

        If ISUD9550A.Link_ISUD9550A(3, cdWorkFlow, "", Me.Name) = False Then Exit Sub
        Call DATA_SEARCH_VS20()
    End Sub

    Private Sub MAIN_JOB04()
        If getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        Dim cdWorkFlow As String

        If vS20.Focused = False Then Exit Sub

        cdWorkFlow = getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex)

        If ISUD9550A.Link_ISUD9550A(4, cdWorkFlow, "", Me.Name) = False Then Exit Sub
        Call DATA_SEARCH_VS20()
    End Sub


    Private Sub MAIN_JOB05()
        If getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Dim cdWorkFlow As String
        Dim i As Integer

        If vS20.Focused = False Then Exit Sub

        cdWorkFlow = getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), vS20.ActiveSheet.ActiveRowIndex)

        If ISUD9550A.Link_ISUD9550A(11, cdWorkFlow, "", Me.Name) = False Then Exit Sub
        Call DATA_SEARCH_VS20()

    End Sub


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False
        Vs10.Enabled = False

        DS1 = PrcDS("USP_PFP96000_SEARCH_VS10", cn, txt_cdDepartment.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs10, DS1, "USP_PFP96000_SEARCH_VS10", "VS10")
            Vs10.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs10, DS1, "USP_PFP96000_SEARCH_VS10", "VS10")

        DATA_SEARCH_VS10 = True

        Vs10.Enabled = True
    End Function

    Private Sub vS20_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles vS20.CellDoubleClick
        If e.ColumnHeader Then Exit Sub

        If e.Column <> getColumIndex(vS20, "JobCardList") And e.Column <> getColumIndex(vS20, "ReportList") And e.Column <> getColumIndex(vS20, "FilesName") Then Exit Sub

        Dim strSql As String = ""
        Dim Starting As Object
        Dim _FileName As String

        _FileName = getData(vS20, e.Column, e.Row)


        Try
            If _FileName.Split(",").Length > 1 Then
                If LinkReport.Link_LinkReport("1", _FileName) = False Then Exit Sub

                _FileName = LinkReportName
            End If

            Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")
            vS20.Enabled = False
            Call downLoadFile(_FileName)

        Catch ex As Exception

        Finally
            vS20.Enabled = True
            Starting.close()
        End Try

    End Sub

    Private Sub downLoadFile(_FileName As String)
        Dim sFileName As String
        Dim strSql As String

        'For Document
        Try
            'Get image data from gridview column. 
            strSql = "Select TOP 1 K9272_ImageData from [PFK9272] "
            strSql = strSql & "WHERE replace(replace(replace(replace(K9272_FileName,'/',''),'-',''),'.',''),' ','') like N'" & Replace(Replace(Replace(Replace(_FileName, "/", ""), "-", ""), ".", ""), " ", "") & "%' and K9272_BasicCode = '001' "

            Dim sqlCmd As New SqlCommand(strSql, cn)
            'Get image data from DB
            Dim fileData As Byte() = DirectCast(sqlCmd.ExecuteScalar(), Byte())

            strSql = "Select TOP 1 K9272_FileName, K9272_FileType from [PFK9272] "
            strSql = strSql & "WHERE replace(replace(replace(replace(K9272_FileName,'/',''),'-',''),'.',''),' ','') like N'" & Replace(Replace(Replace(Replace(_FileName, "/", ""), "-", ""), ".", ""), " ", "") & "%' and K9272_BasicCode = '001' "
            cmd = New SqlCommand(strSql, cn)
            rd = cmd.ExecuteReader

            If rd.HasRows Then
                rd.Read()

                sFileName = rd!K9272_FileName & "." & rd!K9272_FileType

            Else
                MsgBox("Invalid file!")
            End If
           
            rd.Close()

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
    Private Sub vS20_Paint(sender As Object, e As PaintEventArgs) Handles vS20.Paint
        'Try

        '    Dim Mypen As System.Drawing.Pen
        '    Mypen = New System.Drawing.Pen(System.Drawing.Color.Red, 3)

        '    e.Graphics.DrawLine(Mypen, x1, y1, x2, y2)

        'Catch ex As Exception

        'End Try
    End Sub
    Private x1, x2, y1, y2 As Integer

    Dim fcColor1 As Color = Color.Red
    Dim fcColor2 As Color = Color.Blue
    Dim fcColor3 As Color = Color.Orange
    Dim fcColor4 As Color = Color.Gray

    Private Function ModColor(intX As Integer) As Color
        Try
            If (intX Mod 4) = 0 Then Return fcColor1
            If (intX Mod 4) = 1 Then Return fcColor2
            If (intX Mod 4) = 2 Then Return fcColor3
            If (intX Mod 4) = 3 Then Return fcColor4

        Catch ex As Exception
            ModColor = fcColor1
        End Try

    End Function
    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False
        vS20.Enabled = False

      
        Try
            vS20.Refresh()
            vS20.ActiveSheet.ClearShapes()
            vS20.ActiveSheet.ClearControls()

            DS1 = PrcDS("USP_PFP96000_SEARCH_VS20", cn, txt_cdWorkflow.Code)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP96000_SEARCH_VS20", "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP96000_SEARCH_VS20", "VS20")

            'vS20.ActiveSheet.Rows(0, vS20.ActiveSheet.RowCount - 1).BackColor = Color.Transparent
            'vS20.ActiveSheet.Columns(-1).BackColor = Color.Transparent

            Dim xrow As Integer
            Dim xMove As Integer = 0
            Dim kMove As Integer = 0

            For xrow = 0 To vS20.ActiveSheet.RowCount - 1
                If getDataM(vS20, getColumIndex(vS20, "CheckCP"), xrow) = "1" Then
                    Dim intT As Integer

                    Dim rShape As New FarPoint.Win.Spread.DrawingSpace.DiamondShape()

                    rShape.CanRenderText = True
                    rShape.Locked = False
                    rShape.TextWrap = True
                    rShape.Text = getData(vS20, getColumIndex(vS20, "ActionName"), xrow)
                    rShape.AlignText = FarPoint.Win.TextAlign.TextTopPictBottom

                    rShape.ForeColor = Color.Black
                    rShape.BackColor = Color.White

                    rShape.ShapeOutlineColor = ModColor(xMove) 'Color.Red

                    rShape.Width = 180
                    rShape.Height = 60
                    rShape.Top = 10 + 80 * (xrow)
                    rShape.Left = 45
                    vS20.ActiveSheet.AddShape(rShape)

                    DS2 = READ_PFK9550_DSEQ(getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), xrow), getData(vS20, getColumIndex(vS20, "Dseq"), xrow), cn)

                    For Each drDataRow As DataRow In DS2.Tables(0).Rows
                        intT = CIntp(drDataRow("K9550_DseqTo")) - 1

                        If intT >= 79 Then
                            Dim anShape As New FarPoint.Win.Spread.DrawingSpace.LineShape()
                            anShape.ShapeOutlineColor = ModColor(xMove) 'Color.Red
                            anShape.Thickness = 3
                            anShape.StartCap = Drawing2D.LineCap.Square
                            anShape.Enabled = Drawing2D.LineCap.Square
                            anShape.SetBounds(rShape.Location.X + 185, rShape.Location.Y + 20, 20 + xMove * 5, 20)
                            vS20.ActiveSheet.AddShape(anShape)

                            anShape.RotationAngle = -45 + xMove * 5

                            If READ_PFK9550_Dseq(getData(vS20, getColumIndex(vS20, "KEY_cdWorkFlow"), xrow), drDataRow("K9550_DseqTo")) Then
                                setData(vS20, getColumIndex(vS20, "ExceptionName"), xrow, D9550.ActionName & IIf(D9550.Description = "", "", ":" & D9550.Description))

                            End If

                        End If

                        If intT > -1 And intT > CIntp(getData(vS20, getColumIndex(vS20, "Dseq"), xrow)) And intT < 79 Then
                            kMove = kMove + 1

                            Dim anShape As New FarPoint.Win.Spread.DrawingSpace.LineShape()
                            anShape.ShapeOutlineColor = ModColor(kMove) 'Color.Red
                            anShape.Thickness = 3
                            anShape.StartCap = Drawing2D.LineCap.Square
                            anShape.Enabled = Drawing2D.LineCap.Square
                            anShape.SetBounds(rShape.Location.X - 26, rShape.Location.Y + 20, 20 + kMove * 5, 20)
                            vS20.ActiveSheet.AddShape(anShape)

                            anShape.RotationAngle = -45 + kMove * 5


                            Dim anShape1 As New FarPoint.Win.Spread.DrawingSpace.ArrowShape()
                            anShape1.BackColor = ModColor(kMove) 'Color.Red
                            anShape1.ShapeOutlineColor = ModColor(kMove) 'Color.Red
                            anShape1.Enabled = Drawing2D.LineCap.Square

                            anShape1.RotationAngle = 0
                            anShape1.SetBounds(rShape.Location.X - 30, 38 + intT * 80, 28 + kMove * 5, 5)

                            vS20.ActiveSheet.AddShape(anShape1)


                            Dim anShape2 As New FarPoint.Win.Spread.DrawingSpace.RectangleShape()
                            anShape2.BackColor = ModColor(kMove) 'Color.Red
                            anShape2.ShapeOutlineColor = ModColor(kMove) 'Color.Red

                            anShape2.Width = 80 * Math.Abs(xrow - intT)
                            anShape2.Height = 2
                            anShape2.RotationAngle = 90


                            vS20.ActiveSheet.AddShape(anShape2)
                            anShape2.Top = anShape.Location.Y + 2
                            anShape2.Left = 10 + kMove * 5 ' anShape1.Location.Y + 209
                        End If

                        If intT > -1 And intT < CIntp(getData(vS20, getColumIndex(vS20, "Dseq"), xrow)) Then
                            xMove += 1

                            Dim anShape As New FarPoint.Win.Spread.DrawingSpace.LineShape()
                            anShape.ShapeOutlineColor = ModColor(xMove) 'Color.Red
                            anShape.Thickness = 3
                            anShape.StartCap = Drawing2D.LineCap.Square
                            anShape.Enabled = Drawing2D.LineCap.Square
                            anShape.SetBounds(rShape.Location.X + 185, rShape.Location.Y + 20, 20 + xMove * 5, 20)
                            vS20.ActiveSheet.AddShape(anShape)

                            anShape.RotationAngle = -45 + xMove * 5


                            Dim anShape1 As New FarPoint.Win.Spread.DrawingSpace.ArrowShape()
                            anShape1.BackColor = ModColor(xMove) 'Color.Red
                            anShape1.ShapeOutlineColor = ModColor(xMove) 'Color.Red
                            anShape1.Enabled = Drawing2D.LineCap.Square

                            anShape1.RotationAngle = -180
                            anShape1.SetBounds(rShape.Location.X + 180, 38 + intT * 80, 28 + xMove * 5, 5)

                            vS20.ActiveSheet.AddShape(anShape1)


                            Dim anShape2 As New FarPoint.Win.Spread.DrawingSpace.RectangleShape()
                            anShape2.BackColor = ModColor(xMove) 'Color.Red
                            anShape2.ShapeOutlineColor = ModColor(xMove) 'Color.Red

                            anShape2.Width = 80 * Math.Abs(xrow - intT)
                            anShape2.Height = 2
                            anShape2.RotationAngle = 90


                            vS20.ActiveSheet.AddShape(anShape2)
                            anShape2.Top = anShape1.Location.Y + 2
                            anShape2.Left = 210 + 42 + xMove * 5 ' anShape1.Location.Y + 209
                        End If

                        If intT > -1 And (intT = CIntp(getData(vS20, getColumIndex(vS20, "Dseq"), xrow)) Or (intT = 98 And xrow + 1 = vS20.ActiveSheet.RowCount - 1)) Then
                            If xrow >= 0 And xrow < vS20.ActiveSheet.RowCount - 1 Then
                                Dim rArrow As New FarPoint.Win.Spread.DrawingSpace.ArrowShape()
                                rArrow.BackColor = Color.Black
                                rArrow.CanRotate = True
                                rArrow.RotationAngle = 90

                                rArrow.SetBounds(130, -10 + 80 * (xrow + 1), 5, 20)

                                vS20.ActiveSheet.AddShape(rArrow)
                            End If
                        End If

                    Next


                Else

                    Dim rShape As New FarPoint.Win.Spread.DrawingSpace.RectangleShape()

                    rShape.CanRenderText = True
                    rShape.Locked = False
                    rShape.TextWrap = True
                    rShape.Text = getData(vS20, getColumIndex(vS20, "ActionName"), xrow)
                    rShape.AlignText = FarPoint.Win.TextAlign.TextTopPictBottom

                    rShape.ForeColor = Color.Black
                    rShape.BackColor = Color.White
                    rShape.Width = 180
                    rShape.Height = 60
                    rShape.Top = 10 + 80 * (xrow)
                    rShape.Left = 45
                    vS20.ActiveSheet.AddShape(rShape)

                    If xrow >= 0 And xrow < vS20.ActiveSheet.RowCount - 1 Then
                        Dim rArrow As New FarPoint.Win.Spread.DrawingSpace.ArrowShape()
                        rArrow.BackColor = Color.Black
                        rArrow.CanRotate = True
                        rArrow.RotationAngle = 90

                        rArrow.SetBounds(130, -10 + 80 * (xrow + 1), 5, 20)

                        vS20.ActiveSheet.AddShape(rArrow)
                    End If

                End If

              
            Next

            DATA_SEARCH_VS20 = True



            If chk_Full.Checked Then
                SPR_TEXTBOXWARP(vS20, getColumIndex(vS20, "Description"))
                SPR_TEXTBOXWARP(vS20, getColumIndex(vS20, "Receiver"))
               
                SPR_TEXTBOXWARP(vS20, getColumIndex(vS20, "ExceptionName"))

                For i As Integer = 0 To vS20.ActiveSheet.RowCount - 1
                    vS20.ActiveSheet.Rows(i).Height = vS20.ActiveSheet.Rows(i).GetPreferredHeight + txt_Tolerance.Value
                    If vS20.ActiveSheet.Rows(i).Height < 80 Then vS20.ActiveSheet.Rows(i).Height = 80
                Next
            End If

            SPR_TEXTBOXWARP(vS20, getColumIndex(vS20, "JobCardList"))
            SPR_TEXTBOXWARP(vS20, getColumIndex(vS20, "ReportList"))
            SPR_TEXTBOXWARP(vS20, getColumIndex(vS20, "FilesName"))
            SPR_TEXTBOXWARP(vS20, getColumIndex(vS20, "cdFrequencyName"))

            vS20.ActiveSheet.RowCount += 1
            

            Dim strText As String

            If READ_PFK7171(ListCode("WorkFlow"), txt_cdWorkflow.Code) Then

                setData(vS20, getColumIndex(vS20, "WorkFlowName"), vS20.ActiveSheet.RowCount - 1, "Dept: " & D7171.NameSimply)
                'vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "WorkFlowName")).ColumnSpan = 10
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "WorkFlowName")).Font = New Font("Tahoma", 12, FontStyle.Bold)
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ExceptionName")).HorizontalAlignment = CellHorizontalAlignment.Left

                Dim nc As New FarPoint.Win.Spread.CellType.TextCellType
                nc.Multiline = True
                nc.WordWrap = True

                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "WorkFlowName")).CellType = nc
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "WorkFlowName")).HorizontalAlignment = CellHorizontalAlignment.Center

                setData(vS20, getColumIndex(vS20, "ExceptionName"), vS20.ActiveSheet.RowCount - 1, "WorkFlow" & vbLf & D7171.CheckName1 & vbLf & " (" & IIf(FormatCut(D7171.CheckName2) = "", "00", FormatCut(D7171.CheckName2)) & ") ")
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ExceptionName")).Font = New Font("Tahoma", 12, FontStyle.Bold)
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ExceptionName")).HorizontalAlignment = CellHorizontalAlignment.Center
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ExceptionName")).CellType = nc

                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "Description")).VerticalAlignment = CellVerticalAlignment.Center
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "Description")).HorizontalAlignment = CellHorizontalAlignment.Center
                setData(vS20, getColumIndex(vS20, "Description"), vS20.ActiveSheet.RowCount - 1, D7171.BasicName)
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "Description")).Font = New Font("Tahoma", 12, FontStyle.Bold)
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "Description")).CellType = nc

                strText = "Code No : " & D7171.BasicCode & vbLf
                strText &= "Date Make : " & FSDate(D7171.DateInsert) & vbLf
                strText &= "Date Apply : " & FSDate(D7171.DateInsert) & vbLf
                Call READ_PFK7411(D7171.InchargeInsert)
                strText &= "Incharge : " & D7411.Name

                strText = "Code No : " & D7171.BasicCode & vbLf
                strText &= "Date Make : " & vbLf
                strText &= "Date Apply : " & vbLf
                strText &= "Incharge : " & ""


                SPR_TEXTBOXM(vS20, getColumIndex(vS20, "ReportList"))
                setData(vS20, getColumIndex(vS20, "ReportList"), vS20.ActiveSheet.RowCount - 1, strText)
                'vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "FilesName")).RowSpan = 2
                vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ReportList")).HorizontalAlignment = CellHorizontalAlignment.Left
                'vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "FilesName")).VerticalAlignment = CellVerticalAlignment.Top
            End If

            vS20.ActiveSheet.RowCount += 1

            setData(vS20, getColumIndex(vS20, "WorkFlowName"), vS20.ActiveSheet.RowCount - 1, " [CHANG SHUEN - WORKFLOW] " & vbLf & "[PSM ERP 2024]")
            Dim ncx As New FarPoint.Win.Spread.CellType.TextCellType
            ncx.Multiline = True
            vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "WorkFlowName")).CellType = ncx
            vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "WorkFlowName")).HorizontalAlignment = CellHorizontalAlignment.Center

            vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ExceptionName")).HorizontalAlignment = CellHorizontalAlignment.Center
            setData(vS20, getColumIndex(vS20, "ExceptionName"), vS20.ActiveSheet.RowCount - 1, "PSM Incharge : " & vbLf & " [Signature] ")
            vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ExceptionName")).CellType = ncX

            vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "ExceptionName")).ColumnSpan = 2
            setData(vS20, getColumIndex(vS20, "cdFrequencyName"), vS20.ActiveSheet.RowCount - 1, "ChangShuen Incharge : " & vbLf & " [Signature] ")
            vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "cdFrequencyName")).CellType = ncX
            vS20.ActiveSheet.Cells(vS20.ActiveSheet.RowCount - 1, getColumIndex(vS20, "Receiver")).ColumnSpan = 3


            vS20.ActiveSheet.Protect = False
            vS20.Enabled = True
        Catch ex As Exception

        End Try

    End Function


    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

        Dim cdProjectCode As String
        Dim cdModuleCode As String
        Dim cdInchargePSM As String
        Dim DatePlan As String

        cdProjectCode = getData(Vs10, getColumIndex(Vs10, "KEY_cdWorkFlow"), Vs10.ActiveSheet.ActiveRowIndex)
        cdModuleCode = getData(Vs10, getColumIndex(Vs10, "KEY_cdModuleCode"), Vs10.ActiveSheet.ActiveRowIndex)
        DatePlan = getData(Vs10, getColumIndex(Vs10, "KEY_DatePlan"), Vs10.ActiveSheet.ActiveRowIndex)
        cdInchargePSM = getData(Vs10, getColumIndex(Vs10, "KEY_cdInchargePSM"), Vs10.ActiveSheet.ActiveRowIndex)

        Try
            DS1 = PrcDS("USP_PFP96000_SEARCH_VS10_LINE", cn, cdProjectCode, cdModuleCode, DatePlan, cdInchargePSM)

            If GetDsRc(DS1) = 0 Then
                Vs10.Enabled = True
                Exit Function
            End If

            READ_SPREAD(Vs10, DS1, "USP_PFP96000_SEARCH_VS10", "VS10", Vs10.ActiveSheet.ActiveRowIndex)

            Vs10.Enabled = True
            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception
            MsgBoxP("LINE_MOVE_DISPLAY01")
        End Try
    End Function

#End Region

#Region "Event"
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
        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If
    End Sub
    Private Sub VS10_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellClick
        If e.ColumnHeader = True Then Exit Sub
        Vs10.ActiveSheet.ActiveColumnIndex = e.Column
        Vs10.ActiveSheet.ActiveRowIndex = e.Row
        Vs10.ActiveSheet.AddSelection(e.Row, e.Column, 1, 1)

        If e.Column = getColumIndex(Vs10, "DCHK") Then
            Vs10.ActiveSheet.OperationMode = OperationMode.Normal
        Else
            Vs10.ActiveSheet.OperationMode = OperationMode.SingleSelect
        End If

    End Sub

    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        txt_cdWorkflow.Code = getData(Vs10, getColumIndex(Vs10, "KEY_BasicCode"), Vs10.ActiveSheet.ActiveRowIndex)
        txt_cdWorkflow.Data = getData(Vs10, getColumIndex(Vs10, "BasicName"), Vs10.ActiveSheet.ActiveRowIndex)

        If e.Column = getColumIndex(Vs10, "DCHK") Then Exit Sub

        Dim int_row As Integer
        Dim int_sheetindex As Integer = -1

        vS20.Sheets.Count = 1

        For int_row = 0 To Vs10.ActiveSheet.RowCount - 1
            If getDataM(Vs10, getColumIndex(Vs10, "DCHK"), int_row) = "1" Then
                txt_cdWorkflow.Code = getData(Vs10, getColumIndex(Vs10, "KEY_BasicCode"), int_row)
                txt_cdWorkflow.Data = getData(Vs10, getColumIndex(Vs10, "BasicName"), int_row)

                If txt_cdWorkflow.Code <> "" Then

                    int_sheetindex += 1

                    If int_sheetindex = 0 Then vS20.ActiveSheet.SheetName = txt_cdWorkflow.Code : Call DATA_SEARCH_VS20()
                    If int_sheetindex > 0 Then
                        vS20.Sheets.Count += 1
                        vS20.ActiveSheetIndex = vS20.Sheets.Count - 1
                        vS20.ActiveSheet.SheetName = txt_cdWorkflow.Code
                        Call DATA_SEARCH_VS20()
                    End If


                End If

            End If


        Next
        vS20.ActiveSheetIndex = 0
        vS20.AllowSheetMove = False
        ptc_1.SelectedIndex = 1

    End Sub


    Private Sub VS10_GotFocus(sender As Object, e As EventArgs) Handles Vs10.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False)

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub VS10_LostFocus(sender As Object, e As EventArgs) Handles Vs10.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

    End Sub
    Private Sub chk_FSEL_Click(sender As Object, e As EventArgs) Handles chk_FSEL.CheckedChanged
        If chk_FSEL.CheckState = 0 Then                  '
            chk_FSEL.BackColor = clrUncheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("OPEN")
            ssp_WHERE.Visible = False
        Else                                        '
            chk_FSEL.BackColor = clrCheck
            chk_FSEL.ForeColor = Color.Black

            chk_FSEL.Text = WordConv("CLOSE")
            ssp_WHERE.Visible = True
        End If
    End Sub
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then
            vS20.Sheets.Count = 1
            Call DATA_SEARCH_VS20()
            vS20.AllowSheetMove = False
            vS20.ActiveSheet.SheetName = txt_cdWorkflow.Code
        End If

    End Sub
    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB01()

        ElseIf Cms_1.Items(1).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB02()

        ElseIf Cms_1.Items(2).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB03()

        ElseIf Cms_1.Items(3).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB04()

        ElseIf Cms_1.Items(4).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB05()

        End If

    End Sub

    Private Sub ItemMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_1.SelectedIndexChanged
        If ptc_1.SelectedIndex = 0 Then txt_cdWorkflow.Visible = False : txt_cdDepartment.Visible = True
        If ptc_1.SelectedIndex = 1 Then txt_cdWorkflow.Visible = True : txt_cdDepartment.Visible = False
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_1.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_1.ItemSize = New Size((Me.Width - 30) / ptc_1.TabCount, 25)
        End If

    End Sub

#End Region





End Class