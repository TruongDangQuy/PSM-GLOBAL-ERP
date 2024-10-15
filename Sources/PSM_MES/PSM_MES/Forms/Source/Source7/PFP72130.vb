Public Class PFP72130

#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG

    Private W7213 As T7213_AREA
    Private L7213 As T7213_AREA

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
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

    End Sub

    Private Sub DATA_INIT()

    End Sub
#End Region

#Region "Function"
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
    End Sub
    Private Sub MAIN_JOB01()
        If ISUD7213A.Link_ISUD7213A(1, "000000", Me.Name) = False Then Exit Sub

        Call DATA_SEARCH01()

    End Sub
    Private Sub MAIN_JOB02()
        Dim CartonCode As String

        CartonCode = getData(Vs1, getColumIndex(Vs1, "Key_CartonCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7213A.Link_ISUD7213A(2, CartonCode, Me.Name) = False Then Exit Sub

    End Sub
    Private Sub MAIN_JOB03()
        Dim CartonCode As String

        CartonCode = getData(Vs1, getColumIndex(Vs1, "Key_CartonCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7213A.Link_ISUD7213A(3, CartonCode, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01()

    End Sub
    Private Sub MAIN_JOB04()
        Dim CartonCode As String

        CartonCode = getData(Vs1, getColumIndex(Vs1, "Key_CartonCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7213A.Link_ISUD7213A(4, CartonCode, Me.Name) = False Then Exit Sub

        Call LINE_MOVE_DISPLAY01()

    End Sub
    Private Sub MAIN_JOB05()
        If getData(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

    End Sub

   

    Public Function DATA_SEARCH_HEAD_vS_Line() As Boolean
        DATA_SEARCH_HEAD_vS_Line = False
        Dim cdSeason As String
        Dim CustomerCode As String



        Try
            DS1 = PrcDS("USP_PFP72130_SEARCH_vS_Line", cn, txt_Customercode.Code)
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP72130_SEARCH_vS_Line", "Vs1")


            DS1 = Nothing
            DATA_SEARCH_HEAD_vS_Line = True

        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function



#End Region

#Region "Data_search"

   

    Private Function DATA_SEARCH01() As Boolean

        Dim Article As String

        DATA_SEARCH01 = False

        Vs1.Enabled = False

        Article = getData(Vs1, getColumIndex(Vs1, "Article"), Vs1.ActiveSheet.ActiveRowIndex)

        DS1 = PrcDS("USP_PFP72130_SEARCH_VS4", cn, Article)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_PFP72130_SEARCH_VS4", "Vs4")
            vS2.ActiveSheet.RowCount = "1"
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_PFP72130_SEARCH_VS4", "Vs4")
        vS2.ActiveSheet.RowCount = vS2.ActiveSheet.RowCount + 1
        DATA_SEARCH01 = True

        Vs1.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim CartonCode As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = Vs1.ActiveSheet.ActiveRowIndex
            CartonCode = getData(Vs1, getColumIndex(Vs1, "CartonCode"), xrow)
            DS1 = PrcDS("USP_PFP72100_SEARCH_VS1_LINE", cn, CartonCode)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP72100_SEARCH_VS1", "Vs1", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Event"
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs)
        If e.ColumnHeader = False Then
            Call MAIN_JOB02()
        End If
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Call DATA_SEARCH_HEAD_vS_Line()

    End Sub

   

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Call DATA_SEARCH01()
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs)

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INPUT") & "(F5)", WordConv("CHANGE") & "(F6)")

    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs)

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INPUT") & "(F5)")

    End Sub


#End Region



    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Dim i As Integer
        Dim autokey As Integer
        Dim CartonCode As String

        For i = 0 To vS2.ActiveSheet.RowCount - 1 Step 1

            autokey = getData(vS2, getColumIndex(vS2, "Key_autokey"), i)
            CartonCode = getData(vS2, getColumIndex(vS2, "KEY_CartonCode"), i)

            If Trim(CartonCode) = "" Then Call DATA_SEARCH01() : Exit Sub

            If READ_PFK7213(autokey) = False Then

                Call READ_PFK7210(CartonCode)

                W7213 = D7213

                W7213.CartonCode = D7210.CartonCode
                W7213.Article = getData(Vs1, getColumIndex(Vs1, "Article"), Vs1.ActiveSheet.ActiveRowIndex)

                W7213.FromSize = getData(vS2, getColumIndex(vS2, "FromSize"), i)
                W7213.ToSize = getData(vS2, getColumIndex(vS2, "ToSize"), i)

                W7213.CTQty = getData(vS2, getColumIndex(vS2, "CTQty"), i)

                W7213.CartonCode_Mix = getData(vS2, getColumIndex(vS2, "CartonCode_Mix"), i)

                WRITE_PFK7213(W7213)

            Else

                Call READ_PFK7210(CartonCode)

                W7213 = D7213


                W7213.Autokey = autokey
                W7213.CartonCode = D7210.CartonCode
                W7213.Article = getData(Vs1, getColumIndex(Vs1, "Article"), Vs1.ActiveSheet.ActiveRowIndex)


                W7213.FromSize = getData(vS2, getColumIndex(vS2, "FromSize"), i)
                W7213.ToSize = getData(vS2, getColumIndex(vS2, "ToSize"), i)

                W7213.CTQty = getData(vS2, getColumIndex(vS2, "CTQty"), i)

                W7213.CartonCode_Mix = getData(vS2, getColumIndex(vS2, "CartonCode_Mix"), i)

                REWRITE_PFK7213(W7213)

            End If
        Next

        Call DATA_SEARCH01()

    End Sub

    Private Sub vS2_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles vS2.ButtonClicked

        Dim xCOL As Integer
        Dim xROW As Integer
        Dim i As Integer
        Dim Value1() As String
        Dim Value2(5) As String

        xROW = e.Row
        xCOL = e.Column

        Select Case xCOL
            Case getColumIndex(vS2, "Btn_CartonCode")

                If HLP7210.Link_HLP7210(txt_Customercode.Code) = True Then

                    If hlp0000SeVa = "" Then Exit Sub
                    Value1 = hlp0000SeVa.Split("|")

                    For i = 0 To Value1.Length - 1
                        Value2 = Value1(i).Split(",")

                        If READ_PFK7210(Value2(0)) = True Then
                            vS2.ActiveSheet.RowCount += 1

                            setData(sender, getColumIndex(vS2, "KEY_CartonCode"), xROW, D7210.CartonCode)
                            setData(sender, getColumIndex(vS2, "CustomerCode"), xROW, D7210.CustomerCode)
                            setData(sender, getColumIndex(vS2, "CartonType"), xROW, D7210.CartonType)

                            vS2.ActiveSheet.ActiveColumnIndex += 1 : vS2.ActiveSheet.ActiveRowIndex = xROW

                            xROW = xROW + 1

                        End If
                    Next

                End If

                'End If

        End Select

        vS2.Focus()

    End Sub


    Private Sub vS2_KeyDown(sender As Object, e As KeyEventArgs) Handles vS2.KeyDown

        Select Case e.KeyCode

            Case Keys.Delete

                Dim autokey As Integer

                autokey = CInt(getData(vS2, getColumIndex(vS2, "Key_autokey"), vS2.ActiveSheet.ActiveRowIndex))

                If autokey <> "0" Then

                    READ_PFK7213(autokey)

                    W7213 = D7213

                    Call DELETE_PFK7213(W7213)

                    Call DATA_SEARCH01()

                End If

        End Select

        vS2.Focus()

    End Sub

End Class