
Public Class ISUD7420A
#Region "Variable"
    Private checkrn As Boolean = False
    Private W7420 As T7420_AREA


    Private formA As Boolean


#End Region

#Region "Form_load"
    Public Function Link_ISUD7420A(job As Integer, _proname1 As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName
        txt_GroupBase.Code = _proname1
        Link_ISUD7420A = False

        formA = False
        Me.ShowDialog()

        Link_ISUD7420A = isudCHK
    End Function
    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_int()
        data_int()

        Call DATA_SEARCH_vS1()
    End Sub
    Private Sub form_int()

    End Sub
    Private Sub data_int()

    End Sub
#End Region

    Private Function DATA_SEARCH_vS1(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH_vS1 = False

        vS1.Enabled = False

        DS1 = PrcDS("USP_ISUD7420_SEARCH_vS1", cn, txt_GroupBase.Code)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS1, DS1, "USP_ISUD7420_SEARCH_vS1", "vS1")
            vS1.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS1, DS1, "USP_ISUD7420_SEARCH_vS1", "vS1")
        DATA_SEARCH_vS1 = True

        vS1.Enabled = True
    End Function


#Region "Event"

    Private Sub cmd_Save_Click(sender As Object, e As EventArgs) Handles cmd_SAVE.Click
        Dim i As Integer
        Dim StrChk As String = ""

        If Data_Check() = False Then Exit Sub

        Try
            For i = 0 To vS1.ActiveSheet.RowCount - 1
                If K7420_MOVE(vS1, i, W7420, getData(vS1, getColumIndex(vS1, "KEY_GroupBase"), i), getData(vS1, getColumIndex(vS1, "KEY_ItemCode"), i)) Then
                    W7420.GroupBase = txt_GroupBase.Code
                    Call REWRITE_PFK7420(W7420)
                Else
                    W7420.GroupBase = txt_GroupBase.Code
                    If W7420.ItemCode <> "" Then
                        Call WRITE_PFK7420(W7420)
                    End If
                End If
            Next
            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub
#End Region
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer
        Dim StrChk As String = ""

        Try

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function
    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        Me.Dispose()
    End Sub

    Private Sub vS1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS1.ButtonClicked
        If e.Column = getColumIndex(vS1, "CLItemCode") Then
            If HLP9911ALL.Link_HLP9911A("") = False Then Exit Sub

            setData(vS1, getColumIndex(vS1, "ItemCode"), e.Row, D9911.ItemCode)
            setData(vS1, getColumIndex(vS1, "ItemName"), e.Row, D9911.ItemName)

        ElseIf e.Column = getColumIndex(vS1, "CLItem") Then
            If getData(vS1, getColumIndex(vS1, "ItemName"), e.Row) = "" Then Exit Sub
            VScHANGE(sender, "CL" & getData(vS1, getColumIndex(vS1, "ItemName"), e.Row), e.Row, e.Column)
        End If

    End Sub

  
    Private Sub VScHANGE(sender As Object, ItemName As String, XRow As Integer, Xcol As Integer)
        Dim Value() As String



        If READ_PFK9911(ItemName) Then
            If D9911.CheckDev = "1" Then

                Value = D9911.CheckDevValue.Split(";")

                Select Case Value(0)
                    Case "1" ' Customer
                        HLP7101A.ShowDialog()

                    Case "2" ' Buyer
                        If HLP7102A.Link_HLP7102A("1") = False Then Exit Sub

                    Case "3" ' Type Code
                        If Value.Length > 1 Then HLPNA = Value(1)
                        If HLP7103A.Link_HLP7103A(HLPNA, "") = False Then Exit Sub

                    Case "4" ' Tool Code
                        If Value.Length > 1 Then HLPNA = Value(1)
                        If HLP7156A.Link_HLP7156A(HLPNA, "3") = False Then Exit Sub

                    Case "5" ' Odno
                        If HLP7102A.Link_HLP7102A("2") = False Then Exit Sub

                    Case "6" 'HR CODE
                        If Value.Length > 1 Then HLPNA = Value(1)
                        HLP0002.ShowDialog()

                    Case "7" ' Material code Code
                        HLP7231C.ShowDialog()

                        If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                        Call READ_PFK7231(hlp0000SeVaTt)

                    Case "8" 'Basic Code
                        HLPNA = ListCode(Strings.Right(ItemName, Len(ItemName) - 4)) ' 
                        HLP7171ALL.ShowDialog()

                    Case "9"
                        If HLP7155A.Link_HLP7155A(Value(1)) = False Then Exit Sub

                    Case "A" 'HR Basic Code
                        If HLP4471A.Link_HLP4471A(Value(1)) = False Then Exit Sub

                    Case "B" 'ListCode
                        'If HLP7103A.Link_HLP7103A(Value(1)) = False Then Exit Sub

                    Case "x" '

                End Select

                If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub

                If Value(0) = "3" Then
                    setData(sender, Xcol + 1, XRow, hlp0000SeVaTt)
                    setData(sender, Xcol + 2, XRow, hlp0000SeVaTt1)
                    setData(sender, Xcol + 3, XRow, hlp0000SeVa)
                Else
                    setData(sender, Xcol + 1, XRow, hlp0000SeVaTt)
                    setData(sender, Xcol + 2, XRow, hlp0000SeVa)
                End If


            End If
        End If
    End Sub

    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles vS1.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim StrMsg As String = MsgBox("Do you want to delete!", vbYesNo)

            If StrMsg <> vbYes Then Exit Sub

            If READ_PFK7420(getData(vS1, getColumIndex(vS1, "KEY_GroupBase"), vS1.ActiveSheet.ActiveRowIndex), getData(vS1, getColumIndex(vS1, "KEY_ItemCode"), vS1.ActiveSheet.ActiveRowIndex)) Then
                W7420 = D7420
                Call DELETE_PFK7420(W7420)

                SPR_DEL(sender, 0, vS1.ActiveSheet.ActiveRowIndex)
            End If
        End If
    End Sub
End Class