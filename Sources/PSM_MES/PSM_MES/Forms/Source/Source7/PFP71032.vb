Public Class PFP71032
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Protected prg As E_PRG


    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INPUT") & "(F5)")
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
        chk_FSEL.CheckState = 1
        chk_FSEL.BackColor = clrCheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("CLOSE")
        ssp_WHERE.Visible = True
    End Sub

    Private Sub DATA_INIT()
        If READ_PFK7171(ListCode("TypeCode"), "003") Then
            txt_cdTypeCode.Code = D7171.BasicCode
            txt_cdTypeCode.Data = D7171.BasicName

            txt_cdTypeCode.Enabled = False
        End If



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
      

    End Sub
    Private Sub MAIN_JOB02()
      

    End Sub
    Private Sub MAIN_JOB03()
        


    End Sub
    Private Sub MAIN_JOB04()
       

    End Sub
    Private Sub MAIN_JOB05()


    End Sub

    Private Sub MAIN_JOB11()
     
    End Sub


#End Region

#Region "Data_search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71032_SEARCH_VS1", cn, txt_cdTypeCode.Code, "*" & txt_TypeName.Data)

        If GetDsRc(DS1) = 0 Then
            Vs1.ActiveSheet.RowCount = 0
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71032_SEARCH_VS1", "Vs1")
        DATA_SEARCH01 = True

        Vs1.Enabled = True
    End Function
    Private Function LINE_MOVE_DISPLAY01() As Boolean
        Dim Autokey As String
        Dim xrow As Integer
        LINE_MOVE_DISPLAY01 = False
        Try
            xrow = Vs1.ActiveSheet.ActiveRowIndex
            Autokey = getData(Vs1, getColumIndex(Vs1, "Autokey"), xrow)
            DS1 = PrcDS("USP_PFP71032_SEARCH_VS1_LINE", cn, Autokey)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If
            READ_SPREAD(Vs1, DS1, "USP_PFP71032_SEARCH_VS1", "Vs1", xrow)

            LINE_MOVE_DISPLAY01 = True
        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Event"
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        If e.ColumnHeader = False Then
            Call MAIN_JOB02()
        End If
    End Sub

    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INPUT") & "(F5)", WordConv("CHANGE") & "(F6)")

        chk_FSEL.CheckState = 0
        chk_FSEL.BackColor = clrUncheck
        chk_FSEL.ForeColor = Color.Black

        chk_FSEL.Text = WordConv("OPEN")
        ssp_WHERE.Visible = False
    End Sub
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_TypeName.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False, WordConv("INPUT") & "(F5)")

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

        Call DATA_SEARCH01()

    End Sub

    Private Sub Cms_1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles Cms_1.ItemClicked
        If Cms_1.Items(0).Selected = True Then
            Cms_1.Hide()
            MAIN_JOB11()

        End If

    End Sub

    Private Sub vS1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        If e.Column = getColumIndex(Vs1, "QtyBatchS") Then
            If READ_PFK7103(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), e.Row)) Then
                D7103.QtyBatchS = CIntp(getData(Vs1, getColumIndex(Vs1, "QtyBatchS"), e.Row))
                Call REWRITE_PFK7103(D7103)
            End If
        End If

    End Sub

    Private Sub Vs1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If READ_PFK7103(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), Vs1.ActiveSheet.ActiveRowIndex)) Then
                D7103.QtyBatchS = CIntp(getData(Vs1, getColumIndex(Vs1, "QtyBatchS"), Vs1.ActiveSheet.ActiveRowIndex))
                Call REWRITE_PFK7103(D7103)
            End If
        End If
    End Sub
#End Region



 
  
End Class