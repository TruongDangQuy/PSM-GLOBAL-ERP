Public Class HLP0001_M
    Private Dsu01 As Integer
    Protected Pipe As New C_Pipe
    Protected prg As E_PRG
    Private a_CUSTOMER() As T7101_AREA
    Private W_CUSTOMER As T7101_AREA

    Private chkrowview As Integer = -1
    Protected MultiSelect As Boolean = False
    Private wGCHK As String
    Protected W1_Head As Integer
    Public Sub New(ByRef Value As C_Pipe, Optional ByVal GCHK As String = "0")
        MyBase.New()
        InitializeComponent()

        wGCHK = GCHK

        Pipe = Value
        Pipe.Response = Me
    End Sub

    Public Function DATA_SEARCH01(ByVal Head_No As Integer) As Boolean
        DATA_SEARCH01 = False
        Try
            
            Dim SWORD As String = ""
            Dim EWORD As String = ""
            Dim row As Integer = VS1.ActiveSheet.ActiveRowIndex
            Dim r As DataRow
            Dim i As Integer = 0

            cmd_OK.Enabled = False

            SWORD = ""
            EWORD = ""
            If wGCHK = "0" Then
                ' check Customer
                DS1 = PrcDS("USP_HLP7101A_SEARCH_VS1_MULTI", cn, "*" & SelectLabelSearch1.PeaceTextbox1.Text.Trim, _
                                                     PCK1.CheckState, Pck2.CheckState, Pck3.CheckState, _
                                                    Pck4.CheckState, Pck5.CheckState, Pck6.CheckState)

                If GetDsRc(DS1) = 0 Then
                    SPR_SET(VS1, , , , OperationMode.Normal)
                    SPR_PRO(VS1, DS1, "USP_HLP7101A_SEARCH_VS1_MULTI", "VS1")
                    VS1.Visible = True
                    Exit Function

                Else
                    SPR_SET(VS1, , , , OperationMode.Normal)
                    SPR_PRO(VS1, DS1, "USP_HLP7101A_SEARCH_VS1_MULTI", "VS1")
                    cmd_OK.Enabled = True

                    DATA_SEARCH01 = True
                End If
            ElseIf wGCHK = "1" Then
                ' check Fabric
                PrcDS("USP_HLP7111Z_SEARCH_VS1_01", cn, "*" & SelectLabelSearch1.PeaceTextbox1.Text.Trim, "ALL", SWORD, EWORD, 1)
                da.SelectCommand = cmd
                ds.Reset()
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then

                    Vs1.Visible = True
                    Exit Function

                Else

                    Dsu01 = ds.Tables(0).Rows.Count

                    If Dsu01 > cPrgLimit Then PRG_SET(prg, Me, Dsu01)

                    SPR_CLEAR(Vs1)

                    'ReDim a_FABRIC(Dsu01 - 1)

                    Vs1.Visible = False

                    i = 0

                    For Each r In ds.Tables(0).Rows

                        PRG_VALUE(prg, i + 1)

                        'Call K7111_MOVE(r) : a_FABRIC(i) = D7111

                        'setData(Vs1, 2, i, a_FABRIC(i).FNAME)
                        ' setData(Vs1, 0, i, "0", , True)
                        i += 1
                        Vs1.ActiveSheet.RowCount += 1
                    Next

                    SPR_END(Vs1)

                    cmd_OK.Enabled = True

                    DATA_SEARCH01 = True
                End If
            ElseIf wGCHK = "2" Then
                ' check Fabric

                PrcDS("USP_HLP7141A_SEARCH_1", cn, "*" & SelectLabelSearch1.PeaceTextbox1.Text.Trim, "ALL", SWORD, EWORD, 1)
                da.SelectCommand = cmd
                ds.Reset()
                da.Fill(ds)

                If ds.Tables(0).Rows.Count = 0 Then

                    Vs1.Visible = True
                    Exit Function

                Else

                    Dsu01 = ds.Tables(0).Rows.Count

                    If Dsu01 > cPrgLimit Then PRG_SET(prg, Me, Dsu01)

                    SPR_CLEAR(Vs1)

                    'ReDim a_YARN(Dsu01 - 1)

                    Vs1.Visible = False

                    i = 0

                    For Each r In ds.Tables(0).Rows

                        PRG_VALUE(prg, i + 1)

                        '   Call K7141_MOVE(r) : a_YARN(i) = D7141

                        setData(Vs1, 1, i, GetDsData(ds, i, "YCODE"), "00000#")
                        setData(Vs1, 2, i, GetDsData(ds, i, "YNAME"))
                        ' setData(Vs1, 0, i, "0", , True)
                        i += 1
                        Vs1.ActiveSheet.RowCount += 1
                    Next

                    SPR_END(Vs1)

                    cmd_OK.Enabled = True

                    DATA_SEARCH01 = True
                End If
            ElseIf wGCHK = "3" Then
                ' check Customer
                DS1 = PrcDS("USP_HLP7155A_SEARCH_VS1_MULTI", cn, "*" & SelectLabelSearch1.PeaceTextbox1.Text.Trim)

                If GetDsRc(DS1) = 0 Then
                    SPR_SET(VS1, , , , OperationMode.Normal)
                    SPR_PRO(VS1, DS1, "USP_HLP7155A_SEARCH_VS1_MULTI", "VS1")
                    VS1.Visible = True
                    Exit Function

                Else
                    SPR_SET(VS1, , , , OperationMode.Normal)
                    SPR_PRO(VS1, DS1, "USP_HLP7155A_SEARCH_VS1_MULTI", "VS1")
                    cmd_OK.Enabled = True

                    DATA_SEARCH01 = True
                End If
            End If
         
            VS1.Focus()
        Catch ex As Exception

            '    MsgLogBox(ex)

            Return False

        End Try

    End Function
    Public Function DATA_SEARCH02(ByVal Head_No As Integer) As Boolean
        DATA_SEARCH02 = False
        Try
            Dim i As Integer = 0
            cmd_OK.Enabled = False
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, 2, i).ToString.Contains(SelectLabelSearch1.PeaceTextbox1.Text.Trim.ToUpper) = True Then
                    If i > chkrowview And SelectLabelSearch1.PeaceTextbox1.Text.Trim.ToUpper <> "" Then
                        Vs1.SetViewportTopRow(0, i)
                        chkrowview = i
                        Exit For
                    ElseIf SelectLabelSearch1.PeaceTextbox1.Text.Trim.ToUpper = "" Then
                        chkrowview = -1
                        Vs1.SetViewportTopRow(0, 0)
                        cmd_OK.Enabled = True
                    End If
                End If
            Next
            SPR_END(Vs1)
            cmd_OK.Enabled = True
            Return True
        Catch ex As Exception

            Return False

        End Try

    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim row As Integer = Vs1.ActiveSheet.ActiveRowIndex

        If MultiSelect = True Then

            Dim i As Integer
            Dim j As Integer
            Dim s As String = ""

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(VS1, getColumIndex(VS1, "CheckUse"), i) = "1" Then
                    If wGCHK = "1" Then s = s & "[" & getData(VS1, getColumIndex(VS1, "CustomerCode"), i) & "]" & getData(VS1, getColumIndex(VS1, "CustomerName"), i) & ";"
                    If wGCHK = "3" Then s = s & "[" & getData(VS1, getColumIndex(VS1, "MachineCode"), i) & "]" & getData(VS1, getColumIndex(VS1, "MachineName"), i) & ";"

                    j = j + 1
                End If
            Next i

            Pipe.RetValue = s

            Me.Dispose()

        Else

            If getCell(Vs1, 0, row) <> "" Then

                Pipe.RetValue = "[" & Trim(getData(Vs1, 0, row)) & "] " & Trim(getData(Vs1, 1, row))

                Me.Dispose()

            End If

        End If

    End Sub

    Private Sub HLP0001_M_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SPR_CHECKBOX(Vs1, 0)
        MultiSelect = True
        DATA_SEARCH01(W1_Head)
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH01(W1_Head) = False Then Exit Sub
         MultiSelect = True
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.DoubleClick
        CellDoubleClick(Vs1_Sheet1, e)
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Dispose()
    End Sub
End Class