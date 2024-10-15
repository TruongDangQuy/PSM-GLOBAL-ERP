Public Class ISUD7106A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7106 As T7106_AREA
    Private L7106 As T7106_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private bolCopyFull As Boolean = True
    Private strShoesCode As String

#End Region

#Region "Link"
    Public Function Link_ISUD7106A(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        strShoesCode = ShoesCode
        D7106.ShoesCode = ShoesCode
        wJOB = job

        Link_ISUD7106A = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7106(D7106.ShoesCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If

                txt_cdSeason.Enabled = False
                txt_CustomerCode.Enabled = False

                If D7106.cdSpecState = "006" Then
                    txt_Line.Enabled = True
                    'If wJOB <> "5" Then txt_Article.Enabled = False
                    txt_cdSpecState.Enabled = False
                End If

        End Select

        L7106 = D7106

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7106A = isudCHK

    End Function

    Private strcdSpecState As String
    Private strArticle As String
    Private CheckClose As Boolean = False
    Public Function Link_ISUD7106A_COPY(job As Integer, ShoesCode As String, cdSpecState As String, Article As String, Optional ByVal TAG As String = "") As Boolean
        strShoesCode = ShoesCode


        D7106.ShoesCode = ShoesCode
        CheckClose = True
        strcdSpecState = cdSpecState
        strArticle = Article

        wJOB = job

        Link_ISUD7106A_COPY = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7106(D7106.ShoesCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If

                txt_cdSeason.Enabled = False
                txt_CustomerCode.Enabled = False

                If D7106.cdSpecState = "006" Then
                    txt_Line.Enabled = True
                    'If wJOB <> "5" Then txt_Article.Enabled = False
                    txt_cdSpecState.Enabled = False
                End If

        End Select

        L7106 = D7106

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7106A_COPY = isudCHK

    End Function
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
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

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call KEY_COUNT()

                txt_ColorCode.Data = "1/0"

                Setfocus(txt_CustomerCode)
            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Search) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Update) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                If Pub.DEVCHK <> "1" Then tst_iDelete.Visible = False


                Block2.Enabled = True

                txt_ShoesCode.Enabled = False

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Delete) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                Block2.Enabled = False

                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()

            Case 5
                Me.Text = Me.Text & " - COPY"

                chk_CopyAll.Visible = True
                chk_CopyAll.Checked = True

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Insert) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                If Pub.DEVCHK <> "1" Then tst_iDelete.Visible = False

                Block2.Enabled = True

                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()
                Call KEY_COUNT()

              

                If READ_PFK7171(ListCode("SpecState"), strcdSpecState) Then
                    txt_CustSpecNo.Data = strArticle
                    txt_CustSpecNo.Enabled = False
                    txt_cdSpecState.Code = strcdSpecState
                    txt_Style.Data = txt_Article.Data

                    txt_cdSpecState.Code = D7171.BasicCode
                    txt_cdSpecState.Data = D7171.BasicName
                    txt_cdSpecState.Enabled = False
                End If

                txt_CustomerCode.Enabled = True

                wJOB = 1




            Case 6
                Me.Text = Me.Text & " - UPDATE LAST CODE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If CheckData_Customer(L7106.Customercode, ISUD.Update) = False Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    MsgBoxP("No Correct Customer !")
                    Exit Sub
                End If

                If Pub.DEVCHK <> "1" Then tst_iDelete.Visible = False

                Block2.Enabled = True

                txt_ShoesCode.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = True

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH()
                Call DATA_SEARCH02()
                Call DisableAllType()

                wJOB = 3
        End Select

        formA = True
    End Sub

    Private Sub DATA_INIT()
        Me.Form_ClearData()

        Call D7106_CLEAR()

        W7106 = D7106

        KEY_CHK = ""


    End Sub
    Private Sub FORM_INIT()
        txt_ShoesCode.Enabled = False

        Call Cms_additem(Cms_1,
                    WordConv("CHECK DEFAULT VERSION"),
                    WordConv("UPDATE INFORMATION"),
                    WordConv("MAKE NEW VERSION"))

        vS0.ContextMenuStrip = Cms_1

    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        If txt_cdSeason.Code = "" Then txt_cdSeason.Code = "000"
        If txt_SizeRange.Code = "" Then txt_SizeRange.Code = "000001"

        If txt_cdSeason.Code = "" Then Setfocus(txt_cdSeason) : MsgBoxP("Season?") : Exit Function
        If txt_CustomerCode.Code = "" Then Setfocus(txt_CustomerCode) : MsgBoxP("CustomerCode?") : Exit Function
        If txt_cdSpecState.Code = "" Then Setfocus(txt_cdSpecState) : MsgBoxP("cdSpecState?") : Exit Function
        If FormatCut(txt_Line.Data) = "" Then Setfocus(txt_Line) : MsgBoxP("Line?") : Exit Function
        If FormatCut(txt_Article.Data) = "" Then Setfocus(txt_Article) : MsgBoxP("Article?") : Exit Function

        'If wJOB = "1" Then If READ_PFK7106_CHECK(txt_cdSpecState.Code, txt_Article.Data, txt_CustomerCode.Code, txt_ColorCode.Data) = True Then MsgBoxP("Check Item Code ! Double") : Exit Function

        Data_Check = True

    End Function

    Private Sub DATA_MOVE()
        Call K7106_MOVE(Me, W7106, 1, L7106.ShoesCode)

        W7106.cdSeason = "000"
        W7106.SizeRange = "000001"
        W7106.SpeciticSize = "1"

        If rad_CheckUse1.Checked = True Then W7106.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then W7106.CheckUse = "2"

        If chk_CheckParent.Checked = True Then W7106.CheckParent = "1"
        If chk_CheckParent.Checked = False Then W7106.CheckParent = "2"

        W7106.seGender = ListCode("Gender")
        W7106.seSeason = ListCode("Season")
        W7106.seSpecState = ListCode("SpecState")

        W7106.seProductType = ListCode("ProductType")
        W7106.seProductSize = ListCode("ProductSize")

        W7106.Remark = txt_Remark.Data
        W7106.VerSAM = txt_VerSAM.Data

        W7106.InchargeDesigner = txt_InchargeDesigner.Code
    End Sub

    Private Sub DATA_INSERT()
        Call DATA_MOVE()

        If CheckRude(W7106.ShoesCode, W7106.Customercode, W7106.Article, W7106.ColorCode, W7106.ColorName, W7106.cdSpecState, W7106.cdSeason, W7106.SizeRange) = True Then Exit Sub

        If READ_PFK7106(W7106.ShoesCode) = True Then
            Call MsgBoxP("5", "DATA_INSERT")

            Call KEY_COUNT()
            Exit Sub
        End If

        If READ_PFK7106_SHOESPARENT(W7106.cdSeason, W7106.cdSpecState, W7106.Article) = False Then
            W7106.CheckParent = "1"
            W7106.ShoesParent = W7106.ShoesCode
        Else
            W7106.ShoesParent = D7106.ShoesCode
            W7106.CheckParent = "2"
        End If

        W7106.DateInsert = Pub.DAT
        W7106.InchargeInsert = Pub.SAW

        If txt_VerSAM.Data = "" Then txt_VerSAM.Data = "1/0"

        W7106.PriceUSD = txt_PriceUSD.Value
        'Call PrcExeNoError("USP_PFK7106A_SHOESCODE_MAKE_NEW_FIRSTVER", cn, L7106.ShoesCode, Pub.SAW)

        If WRITE_PFK7106(W7106) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()

        Call DATA_MOVE()

        If CheckRude(W7106.ShoesCode, W7106.Customercode, W7106.Article, W7106.ColorCode, W7106.ColorName, W7106.cdSpecState, W7106.cdSeason, W7106.SizeRange) = True Then Exit Sub

        W7106.DateUpdate = Pub.DAT
        W7106.InchargeUpdate = Pub.SAW

        If READ_PFK7106_SHOESPARENT(W7106.cdSeason, W7106.cdSpecState, W7106.Article) = False Then
            W7106.CheckParent = "1"
            W7106.ShoesParent = W7106.ShoesCode
        End If

        If READ_PFK7106_SHOESPARENT(W7106.cdSeason, W7106.cdSpecState, W7106.Article) = True Then
            If W7106.CheckParent <> "1" Then
                W7106.ShoesParent = D7106.ShoesCode
                W7106.CheckParent = "2"
            End If
        End If

        If txt_VerSAM.Data = "" Then txt_VerSAM.Data = "1/0"
        W7106.PriceUSD = txt_PriceUSD.Value

        If REWRITE_PFK7106(W7106) = True Then isudCHK = True
        'Call PrcExeNoError("USP_PFK7106A_SHOESCODE_MAKE_NEW_FIRSTVER", cn, L7106.ShoesCode, Pub.SAW)


        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        Dim str As String = MsgBoxP("Do you want to delete ?", vbYesNo)
        If str <> vbYes Then Exit Sub

        If READ_PFK7106(L7106.ShoesCode) Then

            W7106 = D7106
            W7106.CheckUse = "2"
            W7106.DateUpdate = Pub.DAT
            W7106.InchargeUpdate = Pub.SAW
            If REWRITE_PFK7106(W7106) = True Then isudCHK = True

        End If

        If bolCheckRNDPrice = False Then
            If MsgBoxPPW("Please type the password to modify!", const_pwMRNDPrice) = False Then GoTo next1
            bolCheckRNDPrice = True

        End If

        Call PrcExeNoError("USP_PFK7106_DELETE_SHOESCODE", cn, L7106.ShoesCode)


        Me.Dispose()

next1:

    End Sub

    Private Function CheckExist(ShoesCode As String) As Boolean
        CheckExist = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD7106A_CHECKEXIST", cn, ShoesCode)

            If rd.HasRows = True Then
                rd.Read()
                RC = rd!RC
                If RC > 0 Then MsgBoxP("Next Data Already!") : rd.Close() : CheckExist = True : Exit Function
            End If

            rd.Close()
        Catch ex As Exception

        Finally

            If rd IsNot Nothing Then
                If rd.IsClosed = False Then
                    rd.Close()
                End If
            End If
        End Try

    End Function

    Private Function CheckRude(ShoesCode As String, Customercode As String, Article As String, ColorCode As String, ColorName As String, cdSpecState As String, cdSeason As String, SizeRange As String) As Boolean
        CheckRude = False

        Dim RC As Integer
        Try
            rd = PrcDR("USP_ISUD7106A_CHECKRULE", cn, ShoesCode, Customercode, Article, ColorCode, ColorName, cdSpecState, cdSeason, SizeRange)

            If rd.HasRows = True Then
                rd.Read()
                RC = rd!RC
                If RC > 0 Then MsgBoxP("Already exist ITEM CODE in this rule!") : rd.Close() : CheckRude = True : Exit Function
            End If

            rd.Close()
        Catch ex As Exception

        Finally

            If rd IsNot Nothing Then
                If rd.IsClosed = False Then
                    rd.Close()
                End If
            End If
        End Try

    End Function

    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7106_ShoesCode AS DECIMAL)) AS MAX_CODE FROM PFK7106 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7106.ShoesCode = "000001"
        Else
            L7106.ShoesCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        W7106.ShoesCode = L7106.ShoesCode

        rd.Close()
        If Val(W7106.ShoesCode) > 999999 Then
            Call MsgBoxP("46", "KEY_COUNT")

            Call tst_iClose.PerformClick() : Exit Sub
        End If

        txt_ShoesCode.Data = W7106.ShoesCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Sub Cms_1_Click(sender As Object, e As EventArgs) Handles Cms_1.ItemClicked
        Dim HistoryCode As String
        Dim CheckDefault As String

        HistoryCode = getData(vS0, getColumIndex(vS0, "KEY_HistoryCode"), vS0.ActiveSheet.ActiveRowIndex)
        CheckDefault = getDataM(vS0, getColumIndex(vS0, "CheckDefault"), vS0.ActiveSheet.ActiveRowIndex)

        Select Case True
            Case Cms_1.Items(0).Selected
                Cms_1.Hide()
                Try
                    Call PrcExeNoError("USP_PFK7106A_SHOESCODE_MAKE_DEFAULT", cn, L7106.ShoesCode, HistoryCode, Pub.SAW)

                Catch ex As Exception

                End Try

            Case Cms_1.Items(1).Selected
                Cms_1.Hide()
                Try
                    Dim HistoryName As String
                    Dim Remark As String
                    Dim HistoryNo As String
                    HistoryCode = getData(vS0, getColumIndex(vS0, "KEY_HistoryCode"), vS0.ActiveSheet.ActiveRowIndex)

                    HistoryName = getData(vS0, getColumIndex(vS0, "HistoryName"), vS0.ActiveSheet.ActiveRowIndex)
                    HistoryNo = getData(vS0, getColumIndex(vS0, "HistoryNo"), vS0.ActiveSheet.ActiveRowIndex)
                    Remark = getData(vS0, getColumIndex(vS0, "Remark"), vS0.ActiveSheet.ActiveRowIndex)

                    If CheckDefault = "1" Then
                        Call PrcExeNoError("USP_PFK7106A_SHOESCODE_UPDATE_HISTORY", cn, HistoryCode, HistoryName, HistoryNo, Remark, Pub.DAT, Pub.SAW)
                    Else
                        MsgBoxP("It's not current verion !") : Exit Select

                    End If

                    Call DATA_SEARCH_HEAD()

                Catch ex As Exception

                End Try

            Case Cms_1.Items(2).Selected
                Cms_1.Hide()
                Try
                    Call PrcExeNoError("USP_PFK7106A_SHOESCODE_MAKE_NEW", cn, L7106.ShoesCode, Pub.SAW)
                    Call DATA_SEARCH_vS0()
                    Call DATA_SEARCH_HEAD()


                Catch ex As Exception

                End Try

        End Select


    End Sub

    Private Function DATA_SEARCH_vS0() As Boolean
        DATA_SEARCH_vS0 = False
        If chk_Group.Checked = False Then Exit Function
        DS1 = PrcDS("USP_ISUD7106A_SEARCH_vS0", cn, L7106.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(vS0, , , , OperationMode.Normal)
            SPR_PRO_NEW(vS0, DS1, "USP_ISUD7106A_SEARCH_vS0", "vS0")

            vS0.Enabled = True
            Exit Function
        End If
        SPR_SET(vS0, , , , OperationMode.Normal)
        SPR_PRO_NEW(vS0, DS1, "USP_ISUD7106A_SEARCH_vS0", "vS0")

        DATA_SEARCH_vS0 = True
    End Function

    Private Function DATA_SEARCH() As Boolean

        DATA_SEARCH = False

        DS1 = READ_PFK7106(L7106.ShoesCode, cn)

        If GetDsRc(DS1) = 0 Then
            Setfocus(txt_CustomerCode)
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        txt_PriceUSD.Value = CDecp(GetDsData(DS1, 0, "K7106_PriceUSD"))

        If GetDsData(DS1, 0, "K7106_CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If GetDsData(DS1, 0, "K7106_CheckUse") = "2" Then rad_CheckUse2.Checked = True

        If GetDsData(DS1, 0, "K7106_CheckParent") = "1" Then chk_CheckParent.Checked = True
        If GetDsData(DS1, 0, "K7106_CheckParent") <> "1" Then chk_CheckParent.Checked = False


        Setfocus(txt_CustomerCode)

        DATA_SEARCH = True

    End Function

    Private Function DATA_SEARCH02() As Boolean
        DATA_SEARCH02 = False

        DATA_SEARCH02 = True

    End Function

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        DS1 = PrcDS("USP_ISUD7106A_SEARCH_BOM", cn, L7106.ShoesCode)

        If GetDsRc(DS1) = 0 Then
            Exit Function
        End If

        cmd_GC.Code = GetDsData(DS1, 0, "GroupComponentBOM")
        If cmd_GC.Code.Trim = "" Then chk_Group.Checked = False Else chk_Group.Checked = True

        cmd_Process.Code = GetDsData(DS1, 0, "ProcessBOMCode")
        If cmd_Process.Code.Trim = "" Then chk_Process.Checked = False Else chk_Process.Checked = True

        cmd_JOB.Code = GetDsData(DS1, 0, "JobBOMCode")
        If cmd_JOB.Code.Trim = "" Then chk_Job.Checked = False Else chk_Job.Checked = True

        DATA_SEARCH_HEAD = True

    End Function

#End Region

#Region "Event"
    Private Sub cmd_UpdateSize_Click(sender As Object, e As EventArgs)
        If HLP7106G.Link_HLP7106G(txt_ShoesCode.Data) Then

        End If

    End Sub
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If CheckData_Customer(Me.FindForm.FindCode("CustomerCode").Code(), wJOB) = False Then
                    MsgBoxP("No Correct Customer !")

                    Setfocus(txt_CustomerCode)
                    Exit Sub
                End If

                If Data_Check() = False Then Exit Sub

                Call KEY_COUNT()
                Call DATA_INSERT()

                If CheckClose = True Then Me.Dispose() : Exit Sub

                If chk_CopyAll.Checked = True And isudCHK = True And WRITE_CHK = "*" Then
                    Call PrcExe("USP_PFK7106_COPY_SHOESCODE_IMAGE", cn, strShoesCode, txt_cdSpecState.Code, L7106.ShoesCode)

                End If

                Me.Form_ClearData()
                Call DATA_INIT()
                Call KEY_COUNT()

                Setfocus(txt_CustomerCode)
            Case 2 : Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4 : Call DATA_DELETE()
        End Select

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
        Call DATA_DELETE()
        Me.Dispose()
    End Sub

    Private Sub cmd_GC_btnTitleClick(sender As Object, e As EventArgs) Handles cmd_GC.btnTitleClick
        If READ_PFK7108_SHOESCODE(txt_ShoesCode.Code) Then
            If ISUD7108A.Link_ISUD7108A(wJOB, D7108.GroupComponentBOM, "PFP71060") = False Then Exit Sub
            Call DATA_SEARCH_HEAD()
        End If
    End Sub

    Private Sub txt_CBDProcess_btnTitleClick(sender As Object, e As EventArgs) Handles txt_CBDProcess.btnTitleClick
        If READ_PFK7108_SHOESCODE(txt_ShoesCode.Code) Then
            If ISUD7108C.Link_ISUD7108C(wJOB, D7108.GroupComponentBOM, "PFP71060") = False Then Exit Sub
            Call DATA_SEARCH_HEAD()
        End If
    End Sub

    Private Sub cmd_Process_btnTitleClick(sender As Object, e As EventArgs) Handles cmd_Process.btnTitleClick
        If READ_PFK7305_SHOESCODE(txt_ShoesCode.Code) Then
            If ISUD7305A.Link_ISUD7305A(wJOB, D7305.ProcessBOMCode, "PFP73050") = False Then Exit Sub
            Call DATA_SEARCH_HEAD()
        End If
    End Sub

    Private Sub cmd_Job_btnTitleClick(sender As Object, e As EventArgs) Handles cmd_JOB.btnTitleClick
        If READ_PFK7311_SHOESCODE(txt_ShoesCode.Code) Then
            If ISUD7311A.Link_ISUD7311A(wJOB, D7311.JobBOMCode, "PFP73110") = False Then Exit Sub
            Call DATA_SEARCH_HEAD()
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then vS0.Visible = True : DATA_SEARCH_vS0()
        If CheckBox1.Checked = False Then vS0.Visible = False
    End Sub
#End Region

End Class