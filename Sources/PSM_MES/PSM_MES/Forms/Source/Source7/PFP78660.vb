Imports System.Data.SqlClient
Imports System.IO
Public Class PFP78660

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long

    Private Form_Close As Boolean
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()
    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub
    Private Sub DATA_INIT()
        rad_CheckCustomerStatus1.CheckState = CheckState.Checked
        rad_CheckCustomerStatus2.CheckState = CheckState.Checked
        rad_CheckCustomerStatus3.CheckState = CheckState.Checked
        rad_CheckCustomerStatus4.CheckState = CheckState.Unchecked
        rad_CheckCustomerStatus5.CheckState = CheckState.Unchecked

        txt_cdProject.Enabled = True

        'Try
        '    Call READ_PFK7171(ListCode("Project"), Strings.Right(Me.PeaceFormType, 3).ToUpper)
        '    txt_cdProject.Code = D7171.BasicCode
        '    txt_cdProject.Data = D7171.BasicName

        'Catch ex As Exception

        'End Try
   
    End Sub

#End Region

#Region "Link_ISUD"
    Private Sub Function_Event(PressKey As Integer)
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

        If ISUD7866A.Link_ISUD7866A(1, getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex), txt_cdProject.Code) = False Then Exit Sub

        Call DATA_SEARCH_VS2(getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex))
        DATA_SEARCH01()
    End Sub

    Private Sub MAIN_JOB02()
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        If ISUD7866A.Link_ISUD7866A(3, getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex), txt_cdProject.Code) = False Then Exit Sub

        Call DATA_SEARCH_VS2(getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex))
        DATA_SEARCH01()
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

        DS1 = PrcDS("USP_PFP78660_SEARCH_VS1", cn, txt_cdProject.Code, txt_cdDepartment.Code, txt_cdModule.Code, txt_InchargeAccept.Code, rad_CheckCustomerStatus1.CheckState _
                    , rad_CheckCustomerStatus2.CheckState _
                    , rad_CheckCustomerStatus3.CheckState _
                    , rad_CheckCustomerStatus4.CheckState _
                    , rad_CheckCustomerStatus5.CheckState)
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            SPR_PRO(Vs1, DS1, "USP_PFP78660_SEARCH_VS1", "Vs1")
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.SingleSelect)
        SPR_PRO(Vs1, DS1, "USP_PFP78660_SEARCH_VS1", "Vs1")

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH_VS2(KSEL As String, Optional KNAME As String = Nothing) As Boolean
        Dim DSNEW As New DataSet

        DATA_SEARCH_VS2 = False

        Try
            DSNEW = PrcDS("USP_PFP78660_SEARCH_VS2", cn, KSEL)

            If GetDsRc(DSNEW) = 0 Then
                SPR_PRO(Vs2, DSNEW, "USP_PFP78660_SEARCH_VS2", "Vs2")
                Exit Function
            End If

            SPR_PRO(Vs2, DSNEW, "USP_PFP78660_SEARCH_VS2", "Vs2")

            DATA_SEARCH_VS2 = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "EVENT"
    Private Sub Vs2_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellDoubleClick
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


    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row

        If e.Row < 0 Then Exit Sub
        If getData(Vs1, 1, e.Row) = "" Then Exit Sub
        Vs1.Enabled = False
        DATA_SEARCH_VS2(getData(Vs1, 0, e.Row))
        Vs1.Enabled = True
    End Sub

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, False, False, False, False, WordConv("INSERT") & "(F5)", WordConv("UPDATE") & "(F6)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

    End Sub

    Private Sub vS2_GotFocus(sender As Object, e As EventArgs) Handles Vs2.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, False, False, False, False, WordConv("INSERT") & "(F5)", WordConv("UPDATE") & "(F6)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

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
        Call DATA_SEARCH_VS2(getData(Vs1, 0, Row), getData(Vs1, 1, Row))
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False

        If DATA_SEARCH01() = True Then

        End If
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

#End Region

End Class