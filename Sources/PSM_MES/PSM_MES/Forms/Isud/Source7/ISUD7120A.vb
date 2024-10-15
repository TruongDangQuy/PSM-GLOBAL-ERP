Public Class ISUD7120A
#Region "Variable"
    Private wJOB As Integer

    Private W7231 As T7231_AREA

    Private L7106 As T7106_AREA

    Private W7120 As T7120_AREA
    Private L7120 As T7120_AREA

    Private W7103 As T7103_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7120A(job As Integer, ShoesCode As String, MAMaID As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7120.ShoesCode = ShoesCode
        D7120.MAMaID = MAMaID

        txt_MAMahang.Code = MAMaID

        If job = "1" Then
            D7120.ShoesCode = ""
            D7120.ShoesCode = ShoesCode
            txt_ShoesCode.Data = ShoesCode
        End If


        wJOB = job : L7120 = D7120 : L7106 = D7106

        Link_ISUD7120A = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7106(ShoesCode) = False Then
                        Call MsgBoxP("You have no right is this ShoesCode !")
                        Me.Dispose()

                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7120A = isudCHK


        Catch ex As Exception
            '       Call MsgBoxP("61", WordConv("ShoesCode"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH01()
                Call DATA_SEARCH_vs0()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                tst_iDelete.Visible = False

                Setfocus(txt_MBDongia_Giay)

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vs0()
                Call DATA_SEARCH_VS1()

                Pal_1.Enabled = True
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vs0()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                txt_ShoesCode.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Frame1.Enabled = True
                cmd_AttachTechnician.Visible = False

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_vs0()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_ShoesCode.Enabled = False
            Call D7120_CLEAR()
            W7120 = D7120

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Vs1.AllowRowMove = True
        'Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = READ_PFK7106(L7120.ShoesCode, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)

            End If

            DS1 = READ_PFK7120_CODE(L7120.ShoesCode, L7120.MAMaID, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)

            txt_MBDongia_Giay.Value = CDecp(GetDsData(DS1, 0, "K7120_MBDongia_Giay"))
            txt_MBSonguoi_Gio.Value = CDecp(GetDsData(DS1, 0, "K7120_MBSonguoi_Gio"))

            txt_MBDongia_Mau.Data = CIntp(txt_MBDongia_Mau.Data)
            txt_MBTongthoigian.Data = CIntp(txt_MBTongthoigian.Data)

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7120A_SEARCH_VS1", cn, L7120.ShoesCode, L7120.MAMaID)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7120A_SEARCH_VS1", "Vs1")

            Vs1.ActiveSheet.RowCount = 1
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7120A_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True


    End Function
    Private Function DATA_SEARCH_vs0() As Boolean
        DATA_SEARCH_vs0 = False

        DS1 = PrcDS("USP_ISUD7120A_SEARCH_vs0", cn, L7120.ShoesCode, L7120.MAMaID)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vs0, , , , OperationMode.Normal)
            SPR_PRO_NEW(vs0, DS1, "USP_ISUD7120A_SEARCH_vs0", "vs0")
            vS0.Enabled = True
            Exit Function
        End If

        SPR_SET(vs0, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS0, DS1, "USP_ISUD7120A_SEARCH_vs0", "vs0")

        DATA_SEARCH_vs0 = True


    End Function

#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Dim i As Integer
        Dim cd_List, cd_ListName As String

        Data_Check = False

        Try

            For i = 0 To vS0.ActiveSheet.RowCount - 1
                If getDataM(vS0, getColumIndex(vS0, "DCHK"), i) = "1" Then
                    cd_List += getDataM(vS0, getColumIndex(vS0, "cdLineProd"), i) + ";"
                    cd_ListName += getDataM(vS0, getColumIndex(vS0, "cdLineProdName"), i) + "+"
                End If

            Next

            If Len(cd_List) > 1 Then cd_List = Strings.Left(cd_List, Len(cd_List) - 1)
            If Len(cd_ListName) > 1 Then cd_ListName = Strings.Left(cd_ListName, Len(cd_ListName) - 1)

            If FormatCut(cd_List) = "" Then MsgBoxP("Vui lòng chọn chuyền!") : Exit Function
            If CIntp(txt_MBDongia_Giay.Value) = 0 Then MsgBoxP("Vui lòng chọn đơn giá!") : Exit Function
            If CIntp(txt_MBSonguoi_Gio.Value) = 0 Then MsgBoxP("Vui lòng chọn số người!") : Exit Function

            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            W7120.ShoesCode = L7120.ShoesCode

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub KEY_COUNT_MATERIAL()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7231_MaterialCode AS DECIMAL)) AS MAX_CODE FROM PFK7231 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7231.MaterialCode = "000001"
        Else
            W7231.MaterialCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If


    End Sub

    Private Sub KEY_COUNT_7103()

        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7103_TypeCode AS DECIMAL)) AS MAX_CODE FROM PFK7103 "
        SQL = SQL + " WHERE K7103_cdTypeCode = '003' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7103.TypeCode = "000001"
        Else
            W7103.TypeCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        rd.Close()

    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer
            Dim tmpSTR1 As String = ""
            Dim tmpSTR2 As String = ""

            Dim cd_List As String = ""
            Dim cd_ListName As String = ""

            For i = 0 To vS0.ActiveSheet.RowCount - 1
                If getDataM(vS0, getColumIndex(vS0, "DCHK"), i) = "1" Then
                    cd_List += getDataM(vS0, getColumIndex(vS0, "cdLineProd"), i) + ";"
                    cd_ListName += getDataM(vS0, getColumIndex(vS0, "cdLineProdName"), i) + "+"
                End If

            Next

            If Len(cd_List) > 1 Then cd_List = Strings.Left(cd_List, Len(cd_List) - 1)
            If Len(cd_ListName) > 1 Then cd_ListName = Strings.Left(cd_ListName, Len(cd_ListName) - 1)



            SQL = "DELETE FROM PFK7120 "
            SQL = SQL & " WHERE K7120_ShoesCode  = '" & L7120.ShoesCode & "' "
            SQL = SQL & " AND  K7120_MAMaID = '" & L7120.MAMaID & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()


            j = 0
            l = 0
            k = 1
            i = 0

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1
                l = l + 1

                Call D7120_CLEAR() : W7120 = D7120

                W7120.ShoesCode = L7120.ShoesCode

                If K7120_MOVE(Vs1, i, W7120, W7120.AutoKey) = False Then
                    W7120.ShoesCode = L7120.ShoesCode
                    W7120.MBDongia_Giay = CDecp(txt_MBDongia_Giay.Value)
                    W7120.MBSonguoi_Gio = CDecp(txt_MBSonguoi_Gio.Value)
 

                    If W7120.MCSoConThucTe > W7120.MCSoConQuiDinh Then
                        W7120.MCDongia = (W7120.MCSoConThucTe - W7120.MCSoConQuiDinh) * W7120.MBDongia_Giay * W7120.MCThoigian_chophep
                    Else
                        W7120.MCDongia = 0

                    End If


                    W7120.Remark = txt_Remark.Data

                    W7120.MAMaID = cd_List
                    W7120.MAMahang = txt_Article.Data + "(" + txt_ProductCode.Data + ")" + cd_ListName

                    W7120.seGroupJobProcess = ListCode("GroupJobProcess")
                    Call WRITE_PFK7120(W7120)


                End If
skip:
            Next

            Call PrcExeNoError("USP_ISUD7120A_SEARCH_VS1_CLOSING", cn, W7120.ShoesCode, W7120.MAMaID)

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            Call DATA_MOVE_WRITE01()

            isudCHK = True : WRITE_CHK = "*"
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            Call DATA_MOVE_WRITE01()

            isudCHK = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK7120(L7120.ShoesCode) = True Then
                W7120 = D7120

                SQL = "DELETE FROM PFK7120 "
                SQL = SQL & " WHERE K7120_ShoesCode  = '" & W7120.ShoesCode & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK7120(W7120)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7120_ShoesCode AS DECIMAL)) as MAX_CODE FROM PFK7120 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7120.ShoesCode = "000001"
            Else
                W7120.ShoesCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_ShoesCode.Data = W7120.ShoesCode
            L7120.ShoesCode = W7120.ShoesCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


    Private Sub KEY_COUNT_SEQ()
        Try



        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

#End Region

#Region "Event"

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Select Case wJOB
                Case 1
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call KEY_COUNT()
                    Call DATA_INSERT()
                    MsgBoxP("Save Successfully!", vbInformation)
                    wJOB = 3
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()

                Case 2
                    Me.Dispose()
                Case 3
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call DATA_UPDATE()
                    MsgBoxP("Save Successfully!", vbInformation)
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()
                Case 4
                    Call DATA_DELETE()
            End Select
        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()

        Me.Dispose()
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                'W7120.AutoKey = getData(Vs1, getColumIndex(Vs1, "KEY_AutoKey"), xROW)

                'If READ_PFK7120(W7120.AutoKey) Then
                '    W7120 = D7120
                '    Call DELETE_PFK7120(W7120)
                'End If

                SPR_DEL(Vs1, xCOL, xROW)
                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub

    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change

    End Sub

    Private Sub PeaceButton1_Click(sender As Object, e As EventArgs) Handles cmd_AttachTechnician.Click
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7120A.Link_HLP7120A = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7120A_SEARCH_VS1_INSERT", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7120A_SEARCH_VS1", "VS1")
        Try
            txt_MBDongia_Giay.Value = CDecp(GetDsData(DS1, 0, "MBDongia_Giay"))
            txt_MBDongia_Mau.Data = CIntp(GetDsData(DS1, 0, "MBDongia_Mau"))
            txt_MBSonguoi_Gio.Value = CDecp(GetDsData(DS1, 0, "MBSonguoi_Gio"))
            txt_MBTongthoigian.Data = CIntp(GetDsData(DS1, 0, "MBTongthoigian"))
        Catch ex As Exception

        End Try
     


    End Sub



#End Region



  
End Class