Public Class PFP74111

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private a7171() As T7171_AREA
    Private b7171() As T7171_AREA
    Private Form_Close As Boolean

    Private CheckChild As Boolean = False
    Private StrSchild As String
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
        opt_SEL0.Checked = True
        opt_SEL1.Checked = True

    End Sub
    Private Sub DATA_INIT()
        Try
            'If Me.PeaceFormType.Contains("_") Then
            '    Select Case Strings.Right(Me.PeaceFormType, 3)
            '        Case "001"
            '            CheckChild = True
            '            StrSchild = ListCode("KwissBuyer")

            '        Case "002"
            '            CheckChild = True
            '            StrSchild = ListCode("GeoxBuyer")

            '        Case "QCL"
            '            CheckChild = True
            '            StrSchild = "QCL"

            '        Case "040"
            '            CheckChild = True
            '            StrSchild = "MAL"

            '        Case Else
            '            CheckChild = True
            '            StrSchild = Strings.Right(Me.PeaceFormType, 3)
            '    End Select

            'End If

        Catch ex As Exception

        End Try



    End Sub

#End Region

#Region "Link_ISUD"
    'Overrides Sub Function_Event(PressKey As Integer)
    '    Try
    '        Select Case PressKey
    '            Case Keys.F5 : Call MAIN_JOB01()
    '            Case Keys.F6 : Call MAIN_JOB02()
    '            Case Keys.F7 : Call MAIN_JOB03()
    '            Case Keys.F8 : Call MAIN_JOB04()
    '            Case Keys.F9 : Call MAIN_JOB05()
    '        End Select
    '    Catch ex As Exception
    '    End Try
    'End Sub
    'Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
    '    If sender.Equals(tst_1) Then
    '        MAIN_JOB01()
    '    End If
    '    If sender.Equals(tst_2) Then
    '        MAIN_JOB02()
    '    End If

    '    If sender.Equals(tst_3) Then
    '        MAIN_JOB03()
    '    End If

    '    If sender.Equals(tst_4) Then
    '        MAIN_JOB04()
    '    End If
    'End Sub

    'Private Sub MAIN_JOB01()
    '    If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) <> "" Then
    '        If ISUD7171A.Link_ISUD7171A(1, getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub
    '        Call DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
    '    Else
    '        If ISUD7171A.Link_ISUD7171A(1, getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex), "001", Me.Name) = False Then Exit Sub
    '        Call DATA_SEARCH02(getData(Vs1, 1, Vs1.ActiveSheet.ActiveRowIndex))
    '    End If

    'End Sub

    'Private Sub MAIN_JOB02()
    '    If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    '    If ISUD7171A.Link_ISUD7171A(2, getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub


    'End Sub

    'Private Sub MAIN_JOB03()
    '    If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    '    If ISUD7171A.Link_ISUD7171A(3, getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub


    'End Sub

    'Private Sub MAIN_JOB04()
    '    If getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    '    If ISUD7171A.Link_ISUD7171A(4, getData(Vs2, 0, Vs2.ActiveSheet.ActiveRowIndex), getData(Vs2, 1, Vs2.ActiveSheet.ActiveRowIndex), Me.Name) = False Then Exit Sub

    'End Sub

    'Private Sub MAIN_JOB05()
    '    If getData(Vs2, 12, Vs2.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    'End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        Dim CheckUse1 As String = "1"
        Dim CheckUse2 As String = "1"

        If opt_SEL0.Checked Then CheckUse1 = "2"
        If opt_SEL1.Checked Then CheckUse2 = "2"



        DS1 = PrcDS("USP_SEARCH_PFK7411_WEB_CHECK_LOGIN_VS1", cn, CheckUse1, CheckUse2)

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_SEARCH_PFK7411_WEB_CHECK_LOGIN_VS1", "Vs1")

        Dim i As Integer = 0

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            Vs1.ActiveSheet.Cells(i, getColumIndex(Vs1, "WebScan_vS1_Barcode_C39")).Font = New Font("Bar-Code 39", 20)
            Vs1.ActiveSheet.Cells(i, getColumIndex(Vs1, "WebScan_vS1_Barcode")).Font = New Font("Tahoma", 20)
            Vs1.ActiveSheet.Rows(i).Height = 45
        Next

        Vs1.Enabled = True
        DATA_SEARCH01 = True
    End Function

    Private Function DATA_SEARCH02(PassDefaut As String) As Boolean
        'Dim DSNEW As New DataSet

        PassDefaut = "*" + PassDefaut

        Vs2.ActiveSheet.Rows.Clear()
        Vs2.Enabled = False
        DATA_SEARCH02 = False

        Dim CheckUse1 As String = "1"
        Dim CheckUse2 As String = "1"

        If opt_SEL0.Checked Then CheckUse1 = "2"
        If opt_SEL1.Checked Then CheckUse2 = "2"


        Try
            DS2 = PrcDS("USP_SEARCH_PFK7411_WEB_CHECK_LOGIN_VS2", cn, PassDefaut, CheckUse1, CheckUse2)

            If GetDsRc(DS2) = 0 Then
                Vs2.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs2, DS2, "USP_SEARCH_PFK7411_WEB_CHECK_LOGIN_VS2", "Vs2")


            Dim i As Integer = 0

            For i = 0 To Vs2.ActiveSheet.RowCount - 1
                Vs2.ActiveSheet.Cells(i, getColumIndex(Vs2, "WebScan_Barcode_C39")).Font = New Font("Bar-Code 39", 20)
                Vs2.ActiveSheet.Cells(i, getColumIndex(Vs2, "WebScan_Barcode")).Font = New Font("Tahoma", 20)
                Vs2.ActiveSheet.Rows(i).Height = 45
            Next

            Vs2.Enabled = True
            DATA_SEARCH02 = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "EVENT"
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick

        If getData(Vs1, getColumIndex(Vs1, "PassDefaut"), Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
        Vs1.Enabled = False

        Dim row As Integer = 0
        Dim Key_WebScan_AutoKey As String = ""
        Dim PassDefaut As String = getData(Vs1, getColumIndex(Vs1, "PassDefaut"), Vs1.ActiveSheet.ActiveRowIndex)
        Dim PassDefaut1 As String = ""
        Dim DataSetNew As New DataSet

        DataSetNew = PrcDS("USP_INSERT_PFK7411_WEB_CHECK_LOGIN_VS1", cn, PassDefaut1)

        DATA_SEARCH02(PassDefaut)
        Vs1.Enabled = True

        setFocusCell(Vs1, "PassDefaut", PassDefaut)
    End Sub


    Private Sub Vs1_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs1.KeyUp
        Select Case e.KeyCode
            Case Keys.Down, Keys.Up, Keys.PageDown, Keys.PageUp
                Call vS1_Click(Vs1.ActiveSheet.ActiveColumnIndex, Vs1.ActiveSheet.ActiveRowIndex)
            Case Keys.Insert
                Call vS1_AddRow()

        End Select
    End Sub

    'Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus


    'End Sub

    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        'Dim row As Integer = 0
        'Dim Key_WebScan_AutoKey As String = ""
        'Dim PassDefaut As String = ""
        'Dim DataSetNew As New DataSet
        'While row < Vs1.ActiveSheet.RowCount
        '    PassDefaut = getData(Vs1, getColumIndex(Vs1, "PassDefaut"), row)
        '    If PassDefaut <> "" Then
        '        Key_WebScan_AutoKey = getData(Vs1, getColumIndex(Vs1, "Key_WebScan_AutoKey"), row)
        '        If Key_WebScan_AutoKey = "" Then

        '            DataSetNew = PrcDS("USP_INSERT_PFK7411_WEB_CHECK_LOGIN_VS1", cn, PassDefaut)
        '            DataSetNew = New DataSet

        '        End If
        '        row = row + 1
        '    Else
        '        Vs1.ActiveSheet.Rows.Remove(row, 1)

        '    End If
        'End While
        'Vs1.Refresh()
    End Sub

    Private Sub Vs2_Change(sender As Object, e As ChangeEventArgs) Handles Vs2.Change
        If e.Column = getColumIndex(Vs2, "WebScan_Pass") Then

            Dim Pass As String = getData(Vs2, getColumIndex(Vs2, "WebScan_Pass"), e.Row)

            Dim AutoKey As String = getData(Vs2, getColumIndex(Vs2, "Key_WebScan_AutoKey"), e.Row)
            Dim DataSetNew As New DataSet

            DataSetNew = PrcDS("USP_CHANGE_PFK7411_WEB_CHECK_LOGIN_VS2", cn, AutoKey, Pass)
            If DataSetNew.Tables(0).Rows(0)(0) = "0" Then
                Exit Sub
            End If

            Call DATA_SEARCH02(DataSetNew.Tables(0).Rows(0)(1))

        End If

    End Sub
    Private Sub Vs2_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs2.CellClick

        If e.Column = getColumIndex(Vs2, "WebScan_CheckUse") And e.Button = Windows.Forms.MouseButtons.Left Then

            Dim AutoKey As String = getData(Vs2, getColumIndex(Vs2, "Key_WebScan_AutoKey"), e.Row)
            Dim DataSetNew As New DataSet

            DataSetNew = PrcDS("USP_CHANGE_USE_PFK7411_WEB_CHECK_LOGIN_VS2", cn, AutoKey)
            If DataSetNew.Tables(0).Rows(0)(0) = "0" Then
                Exit Sub
            End If

            Call DATA_SEARCH02(DataSetNew.Tables(0).Rows(0)(1))
        End If
    End Sub

    Private Sub Vs2_KeyUp(sender As Object, e As KeyEventArgs) Handles Vs2.KeyUp
        Select Case e.KeyCode
            Case Keys.Insert
                Call vS2_AddRow()
            Case Keys.Delete
                Call vS2_DeleteRow(Vs2.ActiveSheet.ActiveRowIndex)
        End Select
    End Sub

    Private Sub vS1_Click(ByVal Col As Long, ByVal Row As Long)
        If Row < 0 Then Exit Sub
        If getData(Vs1, 12, Row) = "" Then Exit Sub

    End Sub

    Private Sub vS1_AddRow()
        If ISUD7411D.Link_ISUD7411D("1", "", "") Then
            Call DATA_SEARCH01()
        End If

    End Sub

    Private Sub vS2_AddRow()
        Dim AutoKey As String = getData(Vs2, getColumIndex(Vs2, "Key_WebScan_AutoKey"), 0)
        Dim DataSetNew As New DataSet

        DataSetNew = PrcDS("USP_INSERT_PFK7411_WEB_CHECK_LOGIN_VS2", cn, AutoKey)
        If DataSetNew.Tables(0).Rows(0)(0) = "0" Then
            Exit Sub
        End If

        Call DATA_SEARCH02(DataSetNew.Tables(0).Rows(0)(1))

    End Sub

    Private Sub vS2_DeleteRow(ByVal Row As Long)
        Dim AutoKey As String = getData(Vs2, getColumIndex(Vs2, "Key_WebScan_AutoKey"), Row)
        Dim DataSetNew As New DataSet

        If MsgBox("Do you want to delete it? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If

        DataSetNew = PrcDS("USP_DELETE_PFK7411_WEB_CHECK_LOGIN_VS2", cn, AutoKey)
        If DataSetNew.Tables(0).Rows(0)(0) = "0" Then
            Exit Sub
        End If

        Call DATA_SEARCH02(DataSetNew.Tables(0).Rows(0)(1))

    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01() = True Then
        End If
    End Sub

#End Region

End Class