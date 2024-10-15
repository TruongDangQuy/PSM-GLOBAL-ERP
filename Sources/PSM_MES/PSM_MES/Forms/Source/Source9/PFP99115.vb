
Imports System.Net
Imports System.IO
Public Class PFP99115

#Region "Variable"

    Private Dsu01 As Long     'Data Su
    Private Form_Close As Boolean

#End Region

#Region "Formload"

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)

        Call FORM_INIT()
        Call DATA_INIT()
        Call DATA_SEARCH02()
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
        Try

            If Trim(txt_ItemName.Data) = "" Then txt_ItemName.Code = ""

            DS1 = PrcDS("USP_SPREAD_SHEETPRINT_PROG", cn, txt_ItemName.Data)
            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If
            SPR_PRO(Vs1, DS1, "USP_SPREAD_SHEETPRINT_PROG", "Vs1")
            DATA_SEARCH01 = True
            Vs1.Enabled = True

        Catch ex As Exception
            Call MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH02() As Boolean

        Dim RS01 As DataRow = Nothing

        Vs2.Enabled = False

        DATA_SEARCH02 = False
        Dim i As Integer
        Dim abc(1000) As String
        Dim abcd(1000) As String
        Dim j1 As Integer
        Dim counti As Integer
        Dim countj As Integer
        Dim sr1 As System.IO.StreamReader
        Dim client As WebClient = New WebClient()


        client.UseDefaultCredentials = True
        client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials

        Dim LinkReport As String

        LinkReport = "http://"
        LinkReport += Pub.SER
        LinkReport += "/CS_WHM/Report/"

        LinkReport = "http://" & Pub.SER.Replace(",", ":") & "/CS_WHM/Report/"

        sr1 = New StreamReader(client.OpenRead(LinkReport))
        i = 0
        Do While Not sr1.EndOfStream
            abc(i) = sr1.ReadLine
            counti += 1
            i += 1
        Loop

        sr1.Close()
        i = 0
        countj = 0
        For i = 1 To abc(2).Length - 1
            If Mid(abc(2), i, 1) = "." Then
                If Mid(abc(2), i + 1, 6) = "xlsx"">" Then
                    For j1 = i + 7 To abc(2).Length - 1
                        If Mid(abc(2), j1, 1) = "." Then
                            If Mid(abc(2), j1 + 1, 4) = "xlsx" Then
                                abcd(countj) = Strings.Mid(abc(2), i + 7, j1 - (i + 7))
                                countj = countj + 1
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If


        Next
        i = 0
        For i = 0 To countj - 1
            Vs2.ActiveSheet.RowCount = i + 1
            setData(Vs2, 0, i, False, , True)
            setData(Vs2, 1, i, i + 1)
            setData(Vs2, 2, i, abcd(i))
            Vs2.ActiveSheet.Rows(i).Height = cSprRowHeight
            setData(Vs2, 5, i, False, , True)
        Next

        Vs2.ActiveSheet.Columns(1).Locked = True
        Vs2.ActiveSheet.Columns(2).Locked = True
        Vs2.ActiveSheet.ColumnCount = 6

        DATA_SEARCH02 = True
        Vs2.Enabled = True

    End Function


#End Region

#Region "Event"

    'Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs)
    '    Vs1.ActiveSheet.ActiveRowIndex = e.Row
    '    Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    'End Sub

    'Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs)
    '    If e.ColumnHeader = True And e.Column = 0 Then
    '        SPR_CheckAll(Vs1, 0)
    '    End If
    'End Sub
    'Private Sub vS1_GotFocus(sender As Object, e As EventArgs)
    '    Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, False, False, False, WordConv("INPUT") & "(F5)", WordConv("SEARCH") & "(F6)", WordConv("UPDATE") & "(F7)")
    'End Sub

    'Private Sub vS1_LostFocus(sender As Object, e As EventArgs)
    '    Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False)
    'End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Call DATA_SEARCH02()
        Call DATA_SEARCH01()
    End Sub


    Private Sub btn_Print_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim i As Integer
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Dim PROG As String
        Dim counti As Integer
        PROG = getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
        counti = 1
        Try
            SQL = ""
            SQL = " DELETE FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
            SQL = SQL & " WHERE PROG = '" & PROG & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            For i = 0 To Vs2.ActiveSheet.RowCount - 1
                If getDataM(Vs2, 0, i) = "1" Then
                    SQL = "Insert into [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
                    SQL = SQL + " VALUES ('" + PROG + "','" + counti.ToString("00") + "','" + getData(Vs2, 3, i).ToString + "','" + getData(Vs2, 2, i).ToString + "','" + getData(Vs2, 4, i).ToString + "','" + getDataM(Vs2, 5, i).ToString + "','')"
                    cmd = New SqlClient.SqlCommand(SQL, cn)
                    cmd.ExecuteNonQuery()
                    counti += 1
                End If
            Next
            MsgBoxP("Sucessfully save!", vbInformation)

        Catch ex As Exception
            MsgBoxP("btn_Print_Click!")
        End Try
    End Sub


    Private Sub Vs1_CellClick1(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
        Dim PROG As String
        Dim i As Integer

        PROG = getData(Vs1, 0, e.Row)
        For i = 0 To Vs2.ActiveSheet.RowCount - 1
            DS1 = READ_A_SHEETPRINT_MATCHING(PROG, getData(Vs2, 2, i), cn)
            If GetDsRc(DS1) > 0 Then
                setDataChk(Vs2, 0, i, 1)
                setData(Vs2, 3, i, GetDsData(DS1, 0, "DSEQ"))
                setData(Vs2, 4, i, GetDsData(DS1, 0, "SHEETTITLE"))
                setDataChk(Vs2, 5, i, GetDsData(DS1, 0, "CHECKUSE"))
            Else
                setDataChk(Vs2, 0, i, 0)
                setData(Vs2, 3, i, "")
                setData(Vs2, 4, i, "")
                setDataChk(Vs2, 5, i, 0)
            End If
        Next
    End Sub
    Private Function READ_A_SHEETPRINT_MATCHING(PROG As String, SHEETREPORT As String, Con As SqlClient.SqlConnection) As DataSet
        Dim SQL As String
        Dim DS As New DataSet
        Dim da As New SqlClient.SqlDataAdapter
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
            SQL = SQL + " WHERE [PROG] = '" + PROG + "'"
            SQL = SQL + " AND [SHEETREPORT] = '" + SHEETREPORT + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = New SqlClient.SqlCommand(SQL, Con)
            da.Fill(DS, "SP")
            Return DS

        Catch ex As Exception
            MsgBoxP(PROG, vbCritical)
            Return Nothing
        Finally
            da = Nothing
            DS = Nothing
        End Try
    End Function
    Private Function READ_A_SHEETPRINT_MATCHING(PROG As String, SHEETREPORT As String) As Boolean
        READ_A_SHEETPRINT_MATCHING = False
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Try
            SQL = "SELECT *  FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
            SQL = SQL + " WHERE [PROG]          = '" + PROG + "'"
            SQL = SQL + "   AND [SHEETREPORT]   = '" + SHEETREPORT + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            If rd.HasRows = True Then
                READ_A_SHEETPRINT_MATCHING = True
            End If
            rd.Close()

        Catch ex As Exception
            MsgBoxP("READ_A_SHEETPRINT_MATCHING")
        End Try
    End Function

#End Region

End Class