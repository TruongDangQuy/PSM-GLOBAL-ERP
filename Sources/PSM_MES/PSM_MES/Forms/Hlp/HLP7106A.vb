Public Class HLP7106A

#Region "Variable"

    Protected prg As E_PRG
    Private Dsu01 As Long
    Private Dsu02 As Long
    Private Dsu03 As Long
    Private a7104() As T7104_AREA
    Private b7104() As T7104_AREA
    Private L7104 As T7104_AREA
    Private w7101 As T7101_AREA
    Private Form_Close As Boolean
    Private ChkcdOrderGroup As Boolean = False

#End Region

#Region "Formload"

    Friend Function Link_HLP7106A(Optional CustomerCode As String = "", Optional cdSeason As String = "", Optional _ChkcdOrderGroupMain As Boolean = False) As Boolean
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""

        ChkcdOrderGroup = _ChkcdOrderGroupMain

        Link_HLP7106A = False

        If READ_PFK7101(CustomerCode) = True Then
            txt_CustomerCode.Code = D7101.CustomerCode
            txt_CustomerCode.Data = D7101.CustomerName

        End If

        If ChkcdOrderGroup = True Then
            txt_cdSpecState.Data = "PROD"
            txt_cdSpecState.Code = "006"
        Else
            If txt_cdSpecState.Code = "006" Then MsgBoxEx("Only No Prod!") : Exit Function
        End If


        txt_CustomerCode.Enabled = True

        If READ_PFK7171(ListCode("Season"), cdSeason) Then
            txt_cdSeason.Data = D7171.BasicName
            txt_cdSeason.Code = D7171.BasicCode
        End If

        Try
            Me.ShowDialog()

            Link_HLP7106A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_HLP7106A"))
        End Try


    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.KeyPreview = True
        Call DATA_INIT()

    End Sub

    Private Sub Me_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
    End Sub

    Private Sub DATA_INIT()
        Try
            If Trim$(txt_CustomerCode.Code) <> "" Then
                DATA_SEARCH_VS1()
            End If
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        If txt_CustomerCode.Data = "" Then txt_CustomerCode.Code = ""

        If ChkcdOrderGroup = True Then
            If txt_cdSpecState.Code <> "006" Then MsgBoxEx("Only Prod!") : Exit Function
        Else
            If txt_cdSpecState.Code = "006" Then MsgBoxEx("Only No Prod!") : Exit Function
        End If

        Try

            DS1 = PrcDS("USP_HLP7106A_SEARCH_VS1", cn, txt_CustomerCode.Code, txt_cdSeason.Code, txt_cdSpecState.Code, txt_Line.Data, txt_Article.Data, txt_ColorName.Data)


            If GetDsRc(DS1) = 0 Then
                Vs1.Enabled = True
                Vs1.ActiveSheet.RowCount = 0
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_HLP7106A_SEARCH_VS1", "Vs1")

            Vs1.Enabled = True
            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try

    End Function

  

#End Region

#Region "EVENT"
    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        'cmd_OK.PerformClick()
    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        Try
            DATA_SEARCH_VS1()
        Catch ex As Exception
            MsgBoxP("cmd_SEARCH_Click")
        End Try
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try

            Dim SpecNoList As String
            Dim ShoesCode As String
            Dim cdSpecState_Old As String = ""
            Dim cdSpecState_New As String = ""
            Dim i As Integer

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getDataM(Vs1, getColumIndex(Vs1, "CheckUse"), i) = "1" Then
                    ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), i)

                    SpecNoList = SpecNoList & "''" & getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), i) & "''"
                    SpecNoList = SpecNoList & ","
                End If
next1:
            Next


            If SpecNoList = "" Then Exit Sub

            SpecNoList = Strings.Left(SpecNoList, Len(SpecNoList) - 1)

            If getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex) IsNot Nothing Then
                hlp0000SeVa = SpecNoList
                hlp0000SeVaTt = SpecNoList
                hlp0000SeVaTt1 = SpecNoList
            Else
                hlp0000SeVa = ""
                hlp0000SeVaTt = ""
                hlp0000SeVaTt1 = ""
            End If

            Me.Dispose()

        Catch ex As Exception
            MsgBoxP("cmd_OK_Click")
        End Try
    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        hlp0000SeVaTt1 = ""
        Me.Dispose()
    End Sub

    Private Sub txt_Add_Click(sender As Object, e As EventArgs) Handles txt_Add.Click
        If ISUD7106A.Link_ISUD7106A(1, "", "PFP71060") = False Then Exit Sub
        Call DATA_SEARCH_VS1()
    End Sub
    Private Sub cmd_Update_Click(sender As Object, e As EventArgs) Handles cmd_Update.Click
        Dim ShoesCode As String

        ShoesCode = getData(Vs1, getColumIndex(Vs1, "KEY_ShoesCode"), Vs1.ActiveSheet.ActiveRowIndex)

        If ISUD7106A.Link_ISUD7106A(3, ShoesCode, "PFP71060") = False Then Exit Sub
        Call DATA_SEARCH_VS1()
    End Sub

#End Region

End Class