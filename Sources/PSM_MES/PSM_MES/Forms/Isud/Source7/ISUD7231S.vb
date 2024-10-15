Public Class ISUD7231S

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7231 As T7231_AREA
    Private L7231 As T7231_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
    Private chkBOM As Boolean = False
#End Region

#Region "Link"
    Public Function Link_ISUD7231S(job As Integer, MaterialCode As String, Optional ByVal TAG As String = "") As Boolean
        D7231.MaterialCode = MaterialCode

        wJOB = job : L7231 = D7231

        Link_ISUD7231S = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7231(L7231.MaterialCode) = True Then
                    If D7231.StatusMaterial = "3" Then tst_iSave.Visible = False : Exit Function
                    If D7231.StatusMaterial = "2" Then tst_iSave.Visible = False : Exit Function
                    If D7231.StatusMaterial = "4" Then tst_iSave.Visible = False : Exit Function
                    If D7231.StatusMaterial = "5" Then tst_iSave.Visible = False : Exit Function
                    If D7231.StatusMaterial = "6" Then tst_iSave.Visible = False : Exit Function

                    If D7231.InchargeInsert <> Pub.SAW Then

                        If MsgBoxPPW("Please input PW, You dont Create it ! Bạn không tạo mã này, nhập pass để thay đổi", const_pwMaterialCode) = False Then Exit Function

                    End If

                End If

                If READ_PFK7231(L7231.MaterialCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7231S = isudCHK
    End Function

    Public Function Link_ISUD7231S_AUTO(job As Integer, ByRef Value As String, MaterialCode As String, MaterialName As String, Optional ByVal TAG As String = "") As Boolean
        D7231.MaterialCode = MaterialCode

        wJOB = job : L7231 = D7231

        Link_ISUD7231S_AUTO = False

        Select Case job
            Case 1, 11
            Case Else
                If READ_PFK7231(L7231.MaterialCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Value = W7231.MaterialCode
        Link_ISUD7231S_AUTO = isudCHK
    End Function

    Public Function Link_ISUD7231S_ADD(job As Integer, cdLargeGroupMaterial As String, cdSemiGroupMaterial As String, cdDetailGroupMaterial As String, Width As String, Height As String, SizeName As String, Optional ByVal cdSpecialName As String = "", Optional ByVal cdUnitMaterial As String = "") As Boolean

        D7231.cdLargeGroupMaterial = cdLargeGroupMaterial
        D7231.cdSemiGroupMaterial = cdSemiGroupMaterial
        D7231.cdDetailGroupMaterial = cdDetailGroupMaterial

        D7231.cdUnitMaterial = cdUnitMaterial


        wJOB = job : L7231 = D7231

        Link_ISUD7231S_ADD = False

        Select Case job
            Case 1, 11
            Case Else
                If READ_PFK7231(L7231.MaterialCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select


        formA = False
        Me.Tag = Tag
        Me.ShowDialog()

        Link_ISUD7231S_ADD = isudCHK

    End Function

    Private _ArrayList As New List(Of String)

    Public Function Link_ISUD7231S_ADD_MULTI(job As Integer, cdLargeGroupMaterial As String, cdSemiGroupMaterial As String, cdDetailGroupMaterial As String, _ArrayList001 As List(Of String), Width As String, Height As String, SizeName As String, Optional ByVal cdSpecialName As String = "", Optional ByVal cdUnitMaterial As String = "") As Boolean
        _ArrayList = _ArrayList001
        D7231.BOMType = "1" : chkBOM = True

        D7231.cdLargeGroupMaterial = cdLargeGroupMaterial
        D7231.cdSemiGroupMaterial = cdSemiGroupMaterial
        D7231.cdDetailGroupMaterial = cdDetailGroupMaterial
        D7231.Width = Width
        D7231.Height = Height
        D7231.SizeName = SizeName
        D7231.cdUnitMaterial = cdUnitMaterial

        If READ_PFK7171_NAME(ListCode("Special"), cdSpecialName) Then
            D7231.cdSpecial = D7171.BasicCode
            D7231.seSpecial = D7171.BasicSel
        End If

        wJOB = job : L7231 = D7231

        Link_ISUD7231S_ADD_MULTI = False

        Select Case job
            Case 1, 11
            Case Else
                If READ_PFK7231(L7231.MaterialCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
        End Select


        formA = False
        Me.Tag = Tag
        Me.ShowDialog()

        Link_ISUD7231S_ADD_MULTI = isudCHK

    End Function
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        Me.Form_KeyDown()

        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        CHK(1) = "1"
        CHK(2) = "1"
        CHK(3) = "1"
        CHK(4) = "2"


        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                Call KEY_COUNT()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                Setfocus(txt_OtherCode1)

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                tst_iSave.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                txt_MaterialCode.Enabled = False

                Call DATA_SEARCH01()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("4", "Form_Activate")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

                Setfocus(txt_cdLargeGroupMaterial)
            Case 4
                Me.Text = Me.Text & " - DELETE"
                tst_iSave.Visible = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

            Case 5
                Me.Text = Me.Text & " - COPY"

                txt_MaterialCode.Enabled = False

                Call DATA_SEARCH01()

                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        Me.Dispose()
                        formA = True
                        Call MsgBoxP("4", "Form_Activate")
                        Exit Sub
                    Else

                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        formA = True
                        wJOB = 2
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

                txt_MaterialPName.TextEnabled = True
                txt_MaterialPName.TextEnabled = True

                txt_MaterialPName.Enabled = True
                txt_MaterialPName.Enabled = True

                Call KEY_COUNT()
                wJOB = 1

            Case 11
                Me.Text = Me.Text & " - INSERT AUTO"

                Call KEY_COUNT()

                If READ_PFK7171(ListCode("LargeGroupMaterial"), L7231.cdLargeGroupMaterial) Then
                    txt_cdLargeGroupMaterial.Code = D7171.BasicCode
                    txt_cdLargeGroupMaterial.Data = D7171.BasicName
                    txt_cdLargeGroupMaterial.Enabled = True
                End If

                If READ_PFK7171(ListCode("UnitMaterial"), L7231.cdUnitMaterial) Then
                    txt_cdUnitMaterial.Code = D7171.BasicCode
                    txt_cdUnitMaterial.Data = D7171.BasicName
                    txt_cdUnitMaterial.Enabled = True
                End If


                If READ_PFK7171(ListCode("SemiGroupMaterial"), L7231.cdSemiGroupMaterial) Then
                    txt_cdSemiGroupMaterial.Code = D7171.BasicCode
                    txt_cdSemiGroupMaterial.Data = D7171.BasicName
                    txt_cdSemiGroupMaterial.Enabled = True
                End If

                If READ_PFK7171(ListCode("DetailGroupMaterial"), L7231.cdDetailGroupMaterial) Then
                    txt_cdDetailGroupMaterial.Code = D7171.BasicCode
                    txt_cdDetailGroupMaterial.Data = D7171.BasicName
                    txt_cdDetailGroupMaterial.Enabled = True
                End If



                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                wJOB = 1

            Case 12
                Me.Text = Me.Text & " - INSERT AUTO"

                Call KEY_COUNT()

                If READ_PFK7171(ListCode("LargeGroupMaterial"), L7231.cdLargeGroupMaterial) Then
                    txt_cdLargeGroupMaterial.Code = D7171.BasicCode
                    txt_cdLargeGroupMaterial.Data = D7171.BasicName
                    txt_cdLargeGroupMaterial.Enabled = True
                End If

                If READ_PFK7171(ListCode("UnitMaterial"), L7231.cdUnitMaterial) Then
                    txt_cdUnitMaterial.Code = D7171.BasicCode
                    txt_cdUnitMaterial.Data = D7171.BasicName
                    txt_cdUnitMaterial.Enabled = True
                End If


                If READ_PFK7171(ListCode("SemiGroupMaterial"), L7231.cdSemiGroupMaterial) Then
                    txt_cdSemiGroupMaterial.Code = D7171.BasicCode
                    txt_cdSemiGroupMaterial.Data = D7171.BasicName
                    txt_cdSemiGroupMaterial.Enabled = True
                End If

                If READ_PFK7171(ListCode("DetailGroupMaterial"), L7231.cdDetailGroupMaterial) Then
                    txt_cdDetailGroupMaterial.Code = D7171.BasicCode
                    txt_cdDetailGroupMaterial.Data = D7171.BasicName
                    txt_cdDetailGroupMaterial.Enabled = True
                End If


                Dim i As Integer

                For i = 0 To _ArrayList.Count - 1
                    If READ_PFK7231(_ArrayList(i)) And i = 0 Then
                        txt_MaterialPName.Data = D7231.MaterialName
                    ElseIf READ_PFK7231(_ArrayList(i)) And i > 0 Then
                        txt_MaterialPName.Data = txt_MaterialPName.Data & " + " & D7231.MaterialName
                    End If

                Next

                txt_MaterialPName.TextEnabled = True
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                wJOB = 1

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7231_CLEAR()

        W7231 = D7231

        KEY_CHK = ""
        tst_iClose.Enabled = True
        tst_iSave.Enabled = True
        tst_iClose.Visible = True
        tst_iSave.Visible = True

        tst_iDelete.Visible = False
    End Sub

    Private Sub FORM_INIT()


    End Sub

#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False

        If wJOB = 1 Then If READ_PFK7231_NAME(txt_MaterialName.Data) Then MsgBoxP("Double Material,pls") : Setfocus(txt_MaterialPName) : Exit Function

        If FormatCut(txt_cdLargeGroupMaterial.Code) = "" Then MsgBoxP("Large Group,pls") : Setfocus(txt_cdLargeGroupMaterial) : Exit Function
        If FormatCut(txt_cdSemiGroupMaterial.Code) = "" Then MsgBoxP("Semi Group,pls") : Setfocus(txt_cdSemiGroupMaterial) : Exit Function
        If FormatCut(txt_cdUnitMaterial.Code) = "" Then MsgBoxP("UnitMaterial,pls") : Setfocus(txt_cdUnitMaterial) : Exit Function
        If FormatCut(txt_cdUnitPacking.Code) = "" Then MsgBoxP("UnitPacking,pls") : Setfocus(txt_cdUnitPacking) : Exit Function

        If FormatCut(txt_MaterialName.Data) = "" Then MsgBoxP("MaterialName,pls") : Setfocus(txt_MaterialName) : Exit Function

        Return DataCheck(Me, "PFK7231")
    End Function
    Private Sub DATA_MOVE()
        W7231.MaterialCode = txt_MaterialCode.Data
        W7231.MaterialName = txt_MaterialName.Data

        W7231.MaterialPName = txt_MaterialPName.Data

        W7231.OtherCode1 = txt_OtherCode1.Data

        W7231.seSpecGroup1 = ListCode("SpecGroup1")
        W7231.cdSpecGroup1 = txt_cdSpecGroup1.Code

        W7231.seSpecGroup2 = ListCode("SpecGroup2")
        W7231.cdSpecGroup2 = txt_cdSpecGroup2.Code

        W7231.seSpecGroup3 = ListCode("SpecGroup3")
        W7231.cdSpecGroup3 = txt_cdSpecGroup3.Code


        W7231.seLargeGroupMaterial = ListCode("LargeGroupMaterial")
        W7231.seSemiGroupMaterial = ListCode("SemiGroupMaterial")
        W7231.seDetailGroupMaterial = ListCode("DetailGroupMaterial")
        W7231.seUnitMaterial = ListCode("UnitMaterial")
        W7231.seUnitPacking = ListCode("UnitPacking")
        W7231.seUnitPrice = ListCode("UnitPrice")
        W7231.seSpecial = ListCode("Special")

        W7231.cdUnitMaterial = txt_cdUnitMaterial.Code
        W7231.cdUnitPacking = txt_cdUnitPacking.Code

        W7231.cdLargeGroupMaterial = txt_cdLargeGroupMaterial.Code
        W7231.cdSemiGroupMaterial = txt_cdSemiGroupMaterial.Code
        W7231.cdDetailGroupMaterial = txt_cdDetailGroupMaterial.Code

        W7231.StatusMaterial = "1"

        W7231.CheckActive = "1"
        W7231.DateActive = Pub.DAT
        W7231.DateStart = Pub.DAT
        W7231.DateInsert = Pub.DAT
        W7231.CheckUse = "1"

        W7231.DevelopmentCode = W7231.MaterialCode

        If opt_XCHK0.Checked = True Then W7231.CheckUse = "1"
        If opt_XCHK1.Checked = True Then W7231.CheckUse = "2"


    End Sub

    Private Sub DATA_INSERT()
        Call KEY_COUNT()
        Call DATA_MOVE()
        W7231.InchargeInsert = Pub.SAW

        W7231.Check1 = Strings.Right(FormatCut(txt_Check1.Data), 1)
        W7231.Check2 = Strings.Right(FormatCut(txt_Check2.Data), 1)

        If READ_PFK7231(W7231.MaterialCode) = True Then
            Call MsgBoxP("5", "DATA_INSERT")

            Call KEY_COUNT()
            Setfocus(txt_MaterialCode)
            Exit Sub
        End If

        If WRITE_PFK7231(W7231) = True Then isudCHK = True : WRITE_CHK = "*"

        Call PrcExe("USP_PFK7231_CLOSINGCODE", cn, W7231.MaterialCode)

    End Sub
    Private Sub DATA_UPDATE()
        Call DATA_MOVE()
        W7231.InchargeUpdate = Pub.SAW


        W7231.Check1 = Strings.Right(FormatCut(txt_Check1.Data), 1)
        W7231.Check2 = Strings.Right(FormatCut(txt_Check2.Data), 1)

        If REWRITE_PFK7231(W7231) = True Then isudCHK = True

        Call PrcExe("USP_PFK7231_CLOSINGCODE", cn, W7231.MaterialCode)

        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        Try

            If READ_PFK7231(L7231.MaterialCode) = True Then
                W7231 = D7231
                W7231.CheckUse = "2"
                W7231.DateDeactive = Pub.DAT
                W7231.InchargeUpdate = Pub.SAW
                If REWRITE_PFK7231(W7231) = True Then isudCHK = True
                Me.Dispose()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7231_MaterialCode AS DECIMAL)) AS MAX_CODE FROM PFK7231 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7231.MaterialCode = "000001"
        Else
            L7231.MaterialCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If

        W7231.MaterialCode = L7231.MaterialCode

        rd.Close()
        If Val(W7231.MaterialCode) > 999999 Then
            Call MsgBoxP("46", "KEY_COUNT")

            Call tst_iClose.PerformClick() : Exit Sub
        End If

        txt_MaterialCode.Data = W7231.MaterialCode
    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK7231(L7231.MaterialCode, cn)

        If GetDsRc(DS1) = 0 Then
            Setfocus(txt_cdLargeGroupMaterial)
            Exit Function
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If GetDsData(DS1, 0, "K7231_CheckUse") = "2" Then opt_XCHK1.Checked = True

        StoreFormat_New(Me)

        Setfocus(txt_MaterialPName)

        DATA_SEARCH01 = True

    End Function

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Dim i As Integer

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                If chkBOM = True Then
                    For i = 0 To _ArrayList.Count - 1
                        D7232_CLEAR()

                        D7232.MaterialCode = W7231.MaterialCode
                        D7232.MaterialCodeBom = _ArrayList(i)
                        D7232.MaterialCodeSeq = (i + 1)

                        Call WRITE_PFK7232(D7232)
                    Next

                End If
                txt_MaterialName.Data = ""
                txt_MaterialPName.Data = ""

                Setfocus(txt_MaterialName)
                Call KEY_COUNT()

            Case 2 : Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_UPDATE()
                Me.Dispose()

            Case 4 : Call DATA_DELETE()

            Case 11
                Call DATA_INSERT()
                txt_MaterialName.Data = ""
                txt_MaterialPName.Data = ""

                Setfocus(txt_MaterialName)
                Call KEY_COUNT()


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
    Private Sub txt_cdLargeGroupMaterial_txtTextChange(sender As Object, e As EventArgs) Handles txt_cdLargeGroupMaterial.txtTextChange
        If formA = False Then Exit Sub

        ChkCdLarge = True : ValueCdLarge = txt_cdLargeGroupMaterial.Code : Exit Sub
    End Sub

    Private Sub txt_cdSemiGroupMaterial_txtTextChange(sender As Object, e As EventArgs) Handles txt_cdSemiGroupMaterial.txtTextChange, txt_cdDetailGroupMaterial.txtTextChange
        If formA = False Then Exit Sub

    End Sub

#End Region


End Class