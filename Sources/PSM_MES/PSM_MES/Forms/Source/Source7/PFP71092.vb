Imports System.Data.SqlClient
Imports System.IO
Public Class PFP71092
#Region "Variable"
    Private Dsu01 As Long     'Data Su
    Private wGCODE As String
    Private W7106 As T7106_AREA
    Private KEY_SEQ As String

    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim xISUD3208O As String
        xISUD3208O = ISUD3208O.Text

        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, False, False, False, False, WordConv("INPUT") & "(F5)")
        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

        Call Cms_additem(Cms_1, "NĂNG SUẤT CON HÀNG" & " - " & WordConv("SEARCH") & "(F6)", _
                                "NĂNG SUẤT CON HÀNG" & " - " & WordConv("UPDATE") & "(F7)",
                                "NĂNG SUẤT CON HÀNG" & " - " & WordConv("DELETE") & "(F8)")



        vS2.ContextMenuStrip = Cms_1

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

        If sender.Equals(tst_5) Then
            MAIN_JOB05()
        End If

    End Sub
    Private Sub MAIN_JOB01()
        Dim ShoesCode As String
        ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7106(ShoesCode) Then
            If ISUD7120A.Link_ISUD7120A(3, ShoesCode, "", Me.Name) = False Then Exit Sub

        End If
    End Sub

    Private Sub MAIN_JOB02()
  

    End Sub

    Private Sub MAIN_JOB03()
        Dim ShoesCode As String
        Dim KEY_MAMaID As String
        ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)
        KEY_MAMaID = getData(Vs1, getColumIndex(Vs1, "KEY_MAMaID"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7106(ShoesCode) Then
            If ISUD7120A.Link_ISUD7120A(2, ShoesCode, Me.Name) = False Then Exit Sub

        End If
    End Sub
    Private Sub MAIN_JOB04()
        Dim ShoesCode As String
        Dim KEY_MAMaID As String
        ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)
        KEY_MAMaID = getData(Vs1, getColumIndex(Vs1, "KEY_MAMaID"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7106(ShoesCode) Then
            If ISUD7120A.Link_ISUD7120A(3, ShoesCode, KEY_MAMaID, Me.Name) = False Then Exit Sub

        End If
    End Sub
    Private Sub MAIN_JOB05()
        Dim ShoesCode As String
        Dim KEY_MAMaID As String
        ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)
        KEY_MAMaID = getData(Vs1, getColumIndex(Vs1, "KEY_MAMaID"), Vs1.ActiveSheet.ActiveRowIndex)

        If READ_PFK7106(ShoesCode) Then
            If ISUD7120A.Link_ISUD7120A(4, ShoesCode, KEY_MAMaID, Me.Name) = False Then Exit Sub
        End If

    End Sub

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Vs1.Enabled = False

        DS1 = PrcDS("USP_PFP71092_SEARCH_VS1", cn, txt_CustomerCode.Code, txt_Article.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(Vs1, DS1, "USP_PFP71092_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(Vs1, DS1, "USP_PFP71092_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True
        Vs1.Enabled = True
    End Function
    Private Function DATA_SEARCH_VS2(KEY_ShoesCode As String) As Boolean
        DATA_SEARCH_VS2 = False
        vS2.Enabled = False

        DS1 = PrcDS("USP_PFP71092_SEARCH_VS2", cn, KEY_ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_PFP71092_SEARCH_VS2", "VS2")

            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_PFP71092_SEARCH_VS2", "VS2")
        DATA_SEARCH_VS2 = True
        vS2.Enabled = True
    End Function

    Private Function LINE_MOVE_DISPLAY01() As Boolean
      
    End Function


#End Region

#Region "Event"
  

    Private Sub vS_Cus_CellClick(sender As Object, e As CellClickEventArgs) Handles vS2.CellDoubleClick
    
    End Sub
   

    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Dim KEY_ShoesCode As String

        KEY_ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)

        Call DATA_SEARCH_VS2(KEY_ShoesCode)
    End Sub

  
    Private Sub txt_GNAME_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Article.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter : cmd_SEARCH.Focus()
        End Select
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        Call DATA_SEARCH_VS1()
    End Sub

    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Call MAIN_JOB03()

            Case Cms_1.Items(1).Selected
                Cms_1.Hide()
                Call MAIN_JOB04()

        End Select
    End Sub

#End Region

End Class