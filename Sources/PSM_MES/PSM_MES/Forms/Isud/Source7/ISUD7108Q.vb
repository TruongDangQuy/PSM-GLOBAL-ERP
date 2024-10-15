Public Class ISUD7108Q
#Region "Variable"
    Private wJOB As Integer

    Private W7231 As T7231_AREA

    Private W7108 As T7108_AREA
    Private L7108 As T7108_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private W7103 As T7103_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7108Q(job As Integer, GroupComponentBOM As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7108.GroupComponentBOM = GroupComponentBOM

        If job = "1" Then
            D7108.GroupComponentBOM = ""
            D7108.ShoesCode = GroupComponentBOM
            txt_ShoesCode.Data = GroupComponentBOM
        End If

        wJOB = job : L7108 = D7108

        Link_ISUD7108Q = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7108(L7108.GroupComponentBOM) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7108Q = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("GroupComponentBOM"))
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
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"

                Frame1.Enabled = True
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Setfocus(txt_GroupComponentBOMName)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                Frame1.Enabled = True
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True
                txt_GroupComponentBOM.Enabled = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        cmd_DEL.Visible = False
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                Frame1.Enabled = True

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_GroupComponentBOM.Enabled = False
            Call D7108_CLEAR()
            W7108 = D7108

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Vs1.AllowRowMove = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            If READ_PFK7108(L7108.GroupComponentBOM) Then
                L7108.ShoesCode = D7108.ShoesCode
            End If

            DS1 = READ_PFK7106(L7108.ShoesCode, cn)

            If GetDsRc(DS1) > 0 Then
                READER_MOVE(Me, DS1)
                txt_GroupComponentBOMName.Data = txt_Line.Data & "-" & txt_Article.Data & "-" & txt_ColorName.Data
            End If

            DS1 = Nothing

            DS1 = READ_PFK7108(L7108.GroupComponentBOM, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            READER_MOVE(Me, DS1)


            Call DATA_SEARCH_IMAGE_TOTAL(pic_Picture, Me.Name, L7108.GroupComponentBOM)

            If READ_PFK7171(GetDsData(DS1, 0, "K7108_selSeasonCode"), GetDsData(DS1, 0, "K7108_cdSeasonCode")) Then
                txt_cdSeason.Code = D7171.BasicCode
                txt_cdSeason.Data = D7171.BasicName
            End If

            If GetDsData(DS1, 0, "K7108_CheckUse") = "1" Then
                rad_CheckUse1.Checked = True
                rad_CheckUse2.Checked = False
            Else
                rad_CheckUse1.Checked = False
                rad_CheckUse2.Checked = True
            End If

            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7108Q_SEARCH_VS1", cn, L7108.GroupComponentBOM)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7108Q_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 1
            Vs1.Enabled = True
            Exit Function
        End If
        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD7108Q_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Dim i As Integer

        Data_Check = False

        Try
            If txt_GroupComponentBOMName.Data.Trim = "" Then Setfocus(txt_GroupComponentBOMName) : Exit Function
            txt_GroupComponentBOMName.Data = Replace(txt_GroupComponentBOMName.Data, "'", "`")

            If wJOB = "1" Then
                If READ_PFK7108(L7108.GroupComponentBOM) = True Then
                    Call MsgBoxP("5", "DATA_INSERT")
                    txt_GroupComponentBOM.Focus()
                    KEY_COUNT()
                    Exit Function
                End If
            End If

            W7108.CheckUse = "1"

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)) = "" Then rad_CheckUse2.Checked = True : W7108.CheckUse = "2"
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "ComponentName"), i)) = "" Then rad_CheckUse2.Checked = True : W7108.CheckUse = "2"
                If FormatCut(getData(Vs1, getColumIndex(Vs1, "cdGroupComponent"), i)) = "" Then rad_CheckUse2.Checked = True : W7108.CheckUse = "2"


            Next

            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try

            W7108.GroupComponentBOM = txt_GroupComponentBOM.Data
            W7108.GroupComponentBOMName = txt_GroupComponentBOMName.Data

            W7108.Remark = txt_Remark.Data
            W7108.ShoesCode = txt_ShoesCode.Data

            If rad_CheckUse1.Checked = True Then W7108.CheckUse = "1"
            If rad_CheckUse2.Checked = True Then W7108.CheckUse = "2"

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

            Dim MaterialName As String
            Dim Width As String
            Dim Height As String
            Dim SizeName As String

            j = 0

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1

                Call D7109_CLEAR() : W7109 = D7109

                W7109.GroupComponentBOM = txt_GroupComponentBOM.Data
                W7109.GroupComponentSeq = CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), i))

                MaterialName = getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)
                Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                Height = getData(Vs1, getColumIndex(Vs1, "Height"), i)
                SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)

                If READ_PFK7231_NAME_RND(MaterialName, Width, Height, SizeName) Then
                    W7231 = D7231
                Else
                    W7231.MaterialName = MaterialName
                    W7231.Width = Width
                    W7231.Height = Height
                    W7231.SizeName = SizeName
                    W7231.seUnitMaterial = ListCode("UnitMaterial")
                    W7231.cdUnitMaterial = getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)
                    W7231.CheckDevRnD = "2"
                    Call KEY_COUNT_MATERIAL()
                    W7231.DevelopmentCode = W7231.MaterialCode
                    W7231.CheckUse = "1"

                    If FormatCut(W7231.MaterialName) <> "" Then Call WRITE_PFK7231(W7231) Else GoTo skip
                End If

                If K7109_MOVE(Vs1, i, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq) = False Then

                    W7109.GroupComponentBOM = L7108.GroupComponentBOM
                    W7109.MaterialCode = W7231.MaterialCode

                    Call KEY_COUNT_SEQ()

                    W7109.Dseq = j

                    W7109.selGroupComponent = ListCode("GroupComponent")
                    W7109.seDepartment = ListCode("Department")
                    W7109.seShoesStatus = ListCode("ShoesStatus")
                    W7109.seUnitMaterial = ListCode("UnitMaterial")
                    W7109.seSubProcess = ListCode("SubProcess")
                    W7109.seSpecialProcess = ListCode("SpecialProcess")

                    W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                    Call WRITE_PFK7109(W7109)
                Else

                    W7109.MaterialCode = W7231.MaterialCode
                    W7109.Dseq = j
                    W7109.GrossUsage = W7109.Consumption * (1 + W7109.Loss / 100)

                    Call REWRITE_PFK7109(W7109)
                End If
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try

            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK7108(W7108) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK7108(W7108) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK7108(L7108.GroupComponentBOM) = True Then
                W7108 = D7108

                SQL = "DELETE FROM PFK7109 "
                SQL = SQL & " WHERE K7109_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK7108(W7108)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7108_GroupComponentBOM AS DECIMAL)) as MAX_CODE FROM PFK7108 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7108.GroupComponentBOM = "000001"
            Else
                W7108.GroupComponentBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            txt_GroupComponentBOM.Data = W7108.GroupComponentBOM
            L7108.GroupComponentBOM = W7108.GroupComponentBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


    Private Sub KEY_COUNT_SEQ()
        Try

            SQL = " SELECT MAX(K7109_GroupComponentSeq) as MAX_CODE FROM PFK7109 "
            SQL = SQL & " WHERE K7109_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)

            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7109.GroupComponentSeq = 1
            Else
                W7109.GroupComponentSeq = CIntp(rd!MAX_CODE + 1)
            End If

            rd.Close()

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
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

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "cmd_DEL_Click")
            Exit Sub
        End If

        Dim str As String = MsgBoxP("Do you want to delete it?", vbYesNo)

        If str <> vbYes Then Exit Sub

        Call DATA_DELETE()

        Me.Dispose()
    End Sub

    Private Sub cmd_AttachID_Click(sender As Object, e As EventArgs) Handles cmd_AttachID.Click
        Call DATA_SEARCH_IMAGE_TOTAL(pic_Picture, Me.Name, L7108.GroupComponentBOM)
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

                W7109.GroupComponentBOM = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentBOM"), xROW)
                W7109.GroupComponentSeq = getData(Vs1, getColumIndex(Vs1, "KEY_GroupComponentSeq"), xROW)

                If READ_PFK7109(W7109.GroupComponentBOM, W7109.GroupComponentSeq) Then
                    W7109 = D7109
                    Call DELETE_PFK7109(W7109)
                End If

                SPR_DEL(Vs1, xCOL, xROW)
                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub



    Private Sub cmd_ChkMaterial_Click(sender As Object, e As EventArgs) Handles cmd_ChkMaterial.Click
        If ISUD7231P.Link_ISUD7231P("3", L7108.GroupComponentBOM, "PFP71080") = False Then Exit Sub
        Call DATA_SEARCH_VS1()
    End Sub
    Private Sub txt_cdRawMaterial_Load(sender As Object, e As EventArgs)
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7110A.Link_HLP7110A("") = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7110A_SEARCH_VS1", cn, hlp0000SeVaTt)
        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7108Q_SEARCH_VS1", "VS1")
    End Sub

    Private Sub txt_BaseBom_Load(sender As Object, e As EventArgs) Handles txt_MasterBom.btnTitleClick
        Dim xROW As Integer

        xROW = Vs1.ActiveSheet.ActiveRowIndex
        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7108F.Link_HLP7108F = False Then Exit Sub

        If hlp0000SeVa = "" Then Exit Sub
        DS1 = PrcDS("USP_ISUD7108Q_SEARCH_VS1", cn, hlp0000SeVaTt)

        Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD7108Q_SEARCH_VS1", "VS1")

    End Sub

    Private Sub cmd_SupplierCost_Load(sender As Object, e As EventArgs) Handles cmd_SupplierCost.btnTitleClick
        Dim xROW As Integer
        Dim MaterialCode As String

        xROW = Vs1.ActiveSheet.ActiveRowIndex

        MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), xROW)

        If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        If HLP7260A.Link_HLP7260A(MaterialCode, "2") = False Then Exit Sub
        If READ_PFK7260(D7261.ContractID) Then
            setData(Vs1, getColumIndex(Vs1, "SupplierCode"), xROW, D7260.CustomerCode)
            setData(Vs1, getColumIndex(Vs1, "PriceMaterial"), xROW, D7261.PriceMaterialVND)

            If READ_PFK7101(D7260.CustomerCode) Then
                setData(Vs1, getColumIndex(Vs1, "SupplierName"), xROW, D7101.CustomerName)
            End If

        End If
    End Sub


    Private Sub cmd_PRINTFULL_Click(sender As Object, e As EventArgs) Handles cmd_PRINTFULL.Click
        If PRINTSHEET_NEW.Link_SheetReport(3, "PFP71080", Me) = True Then

        End If
    End Sub


#End Region






End Class