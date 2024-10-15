Public Class PFP99111
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean

    Private W9911 As New T9911_AREA
    Private L9911 As New T9911_AREA


    Private Enum colvS1
        SANO = 1
        NAME = 2
        BUSEO = 3
        JIKUI = 4
        SITE = 5
        NAT = 6
        SOSOK = 7
        EMPL = 8
        ABC = 9
    End Enum
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()
        SPR_SET(Vs1, 1, , , OperationMode.SingleSelect, True)
    End Sub

    Private Sub DATA_INIT()

    End Sub
#End Region

#Region "Function"
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



#End Region

#Region "Link_isud"
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
    Private Sub MAIN_JOB01()


    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()

    End Sub
#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        Dim RS01 As DataRow = Nothing

        Vs1.Enabled = False

        DATA_SEARCH01 = False

        If Trim(txt_ItemName.Data) = "" Then txt_ItemName.Code = ""

        DS1 = PrcDS("USP_SPREAD_PROGRAM_ITEM_SEARCH", cn, txt_ItemName.Data, txt_ItemNameSimply.Data)
        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            Vs1.ActiveSheet.RowCount = 0
            Exit Function
        End If
        SPR_SET(Vs1, 6, , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_SPREAD_PROGRAM_ITEM_SEARCH", "Vs1")
        DATA_SEARCH01 = True
        Vs1.Enabled = True

    End Function

#End Region

#Region "Event"

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = True And e.Column = 0 Then
            SPR_CheckAll(Vs1, 0)
        End If
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        If K9911_MOVE(Vs1, e.Row, W9911, getData(Vs1, getColumIndex(Vs1, "ItemCode"), e.Row), getData(Vs1, getColumIndex(Vs1, "ItemName"), e.Row)) Then
            REWRITE_PFK9911(W9911)
        End If
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH01()
    End Sub
#End Region

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim i As Integer
        Try

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, 0, i) = "1" Then
                    If K9911_MOVE(Vs1, i, W9911, getData(Vs1, getColumIndex(Vs1, "ItemCode"), i), getData(Vs1, getColumIndex(Vs1, "ItemName"), i)) Then
                        REWRITE_PFK9911(W9911)
                    Else
                        W9911.ItemCode = key_count()
                        WRITE_PFK9911(W9911)
                    End If
                End If
            Next
            MsgBoxP("Sucessfully save!", vbInformation)

        Catch ex As Exception
            MsgBoxP("btn_Print_Click!")
        End Try
    End Sub

    Private Function key_count() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9911_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9911 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count = "000001"
        Else
            key_count = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function
End Class