Public Class ISUD7171A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7171 As T7171_AREA
    Private L7171 As T7171_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region
    
#Region "Link"
    Public Function Link_ISUD7171A(job As Integer, BasicSel As String, BasicCode As String, Optional ByVal TAG As String = "") As Boolean
        D7171.BasicSel = BasicSel
        D7171.BasicCode = BasicCode

        wJOB = job : L7171 = D7171

        Link_ISUD7171A = False

        Select Case job
            Case 1
                If BasicSel = "002" Then

                    If READ_PFK7171("000", "001") Then
                        txt_seBasicMaster.Data = D7171.BasicName
                        txt_seBasicMaster.Code = D7171.BasicCode
                        txt_seBasicMaster.Enabled = False
                        txt_cdBasicMaster.Enabled = False
                    End If


                End If

            Case Else
                If READ_PFK7171(BasicSel, BasicCode) Then
                    txt_seBasicMaster.Code = D7171.seBasicMaster
                    txt_cdBasicMaster.Code = D7171.cdBasicMaster

                    If READ_PFK7171("000", txt_seBasicMaster.Code) Then
                        txt_seBasicMaster.Data = D7171.BasicName
                    End If

                    If READ_PFK7171(txt_seBasicMaster.Code, txt_cdBasicMaster.Code) Then
                        txt_cdBasicMaster.Data = D7171.BasicName
                    End If

                End If

        End Select

        If BasicSel <> "000" Then txt_NameHLPButton.Visible = False Else txt_NameHLPButton.Visible = True


        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7171A = isudCHK
    End Function

    Public Function Link_ISUD7171A(job As Integer, seBasicMaster As String, cdBasicMaster As String, BasicSel As String, BasicCode As String, Optional ByVal TAG As String = "") As Boolean
        If READ_PFK7171("000", seBasicMaster) Then
            txt_seBasicMaster.Data = D7171.BasicName
            txt_seBasicMaster.Enabled = False
        End If

        If READ_PFK7171(seBasicMaster, cdBasicMaster) Then
            txt_cdBasicMaster.Data = D7171.BasicName
            txt_cdBasicMaster.Enabled = False
        End If

        D7171.BasicSel = BasicSel
        D7171.BasicCode = BasicCode

        D7171.seBasicMaster = seBasicMaster
        D7171.cdBasicMaster = cdBasicMaster

        txt_seBasicMaster.Code = seBasicMaster
        txt_cdBasicMaster.Code = cdBasicMaster


        wJOB = job : L7171 = D7171

        Link_ISUD7171A = False

        Select Case job
            Case 1
                If BasicSel = "002" Then

                    If READ_PFK7171("000", "001") Then
                        txt_seBasicMaster.Data = D7171.BasicName
                        txt_seBasicMaster.Code = D7171.BasicCode
                        txt_seBasicMaster.Enabled = False
                        txt_cdBasicMaster.Enabled = False
                    End If
                End If

            Case Else
                If READ_PFK7171(BasicSel, BasicCode) Then
                    txt_seBasicMaster.Code = D7171.seBasicMaster
                    txt_cdBasicMaster.Code = D7171.cdBasicMaster

                    If READ_PFK7171("000", txt_seBasicMaster.Code) Then
                        txt_seBasicMaster.Data = D7171.BasicName
                    End If

                    If READ_PFK7171(txt_seBasicMaster.Code, txt_cdBasicMaster.Code) Then
                        txt_cdBasicMaster.Data = D7171.BasicName
                    End If

                End If

        End Select

        If BasicSel <> "000" Then txt_NameHLPButton.Visible = False Else txt_NameHLPButton.Visible = True

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7171A = isudCHK
    End Function

#End Region

#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Call READ_PFK7171("000", L7171.BasicSel)
        txt_Selremark.Data = D7171.Remark

        Block1.Enabled = False

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

                Call READ_PFK7171("000", L7171.BasicCode)

                rad_CheckUse1.Checked = True
                tst_iDelete.Visible = False

                Call KEY_COUNT()
                Setfocus(txt_BasicName)
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Bloack2.Enabled = False
                ppan_1.Enabled = False
                tst_iDelete.Visible = False
                tst_iSave.Visible = False

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                tst_iDelete.Visible = False
                tst_iSave.Visible = True
                txt_BasicSel.Enabled = False

                Call DATA_SEARCH01()
            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Bloack2.Enabled = False
                ppan_1.Enabled = False
                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                Call DATA_SEARCH01()

        End Select

        txt_BasicSel.Enabled = True

        txt_BasicSel.Enabled = True : txt_BasicCode.Enabled = True : Block1.Enabled = True

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7171_CLEAR()

        W7171 = D7171
        KEY_CHK = ""
    End Sub
    Private Sub FORM_INIT()
        DisplaySeq.Tag = L7171.BasicSel
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean
        Data_Check = False
        'If CInt(txt_BasicSel.Data) = 6 And IsNumeric(txt_BasicName.Data) = False Then MsgBoxP("Numeric only!") : Exit Function
        If TextCheck("1", txt_BasicSel.Data, "BASIC CODE") = False Then Exit Function

        If Trim$(txt_BasicName.Data) = "" Then
            Call MsgBoxP("148", "DATA_CHECK")
            Exit Function
        End If

        If txt_BasicSel.Data = "002" And txt_cdBasicMaster.Code = "" Then MsgBoxP("Please input Master Relation!") : Exit Function
        Data_Check = True
    End Function
    Private Sub DATA_MOVE()

        W7171.BasicSel = Format(CInt(txt_BasicSel.Data), "000")
        W7171.BasicCode = txt_BasicCode.Data

        W7171.seBasicMaster = txt_seBasicMaster.Code
        W7171.cdBasicMaster = txt_cdBasicMaster.Code
        'If CInt(txt_BasicSel.Data) = 6 And IsNumeric(txt_BasicName.Data) = False Then MsgBoxP("Numeric only!") : Exit Sub

        W7171.BasicName = Trim$(txt_BasicName.Data)
        W7171.ForeignName1 = Trim$(txt_ForeignName1.Data)
        W7171.ForeignName2 = Trim$(txt_ForeignName2.Data)
        W7171.NameSimply = Trim$(txt_NameSimply.Data)

        W7171.DevelopmentCode = Trim$(txt_DevelopmentCode.Data)
        'W7171.DevelopmentCodeP = Trim$(txt_DevelopmentCodeP.Data)

        W7171.Check1 = Trim$(check1.Data)
        W7171.Check2 = Trim$(check2.Data)
        W7171.Check3 = Trim$(check3.Data)
        W7171.Check4 = Trim$(check4.Data)
        W7171.Check5 = Trim$(check5.Data)
        W7171.Check6 = Trim$(check6.Data)
        W7171.Check7 = Trim$(check7.Data)
        W7171.Check8 = Trim$(check8.Data)
        W7171.Check9 = Trim$(check9.Data)
        W7171.Check10 = Trim$(check10.Data)

        W7171.CheckName1 = Checkname1.Data
        W7171.CheckName2 = Checkname2.Data
        W7171.CheckName3 = Checkname3.Data
        W7171.CheckName4 = Checkname4.Data
        W7171.CheckName5 = Checkname5.Data
        W7171.CheckName6 = Checkname6.Data
        W7171.CheckName7 = Checkname7.Data
        W7171.CheckName8 = Checkname8.Data
        W7171.CheckName9 = Checkname9.Data
        W7171.CheckName10 = Checkname10.Data

        W7171.Remark = txt_remark.Data

        If rad_CheckUse1.Checked = True Then W7171.CheckUse = "1"
        If rad_CheckUse2.Checked = True Then W7171.CheckUse = "2"

        W7171.BasicName = Replace(W7171.BasicName, "'", "`")
        W7171.ForeignName1 = Replace(W7171.ForeignName1, "'", "`")
        W7171.ForeignName2 = Replace(W7171.ForeignName2, "'", "`")
        W7171.NameSimply = Replace(W7171.NameSimply, "'", "`")

        W7171.NameHLPButton = Trim$(txt_NameHLPButton.Data)

        W7171.DisplaySeq = CIntp(DisplaySeq.Data)

        If W7171.BasicSel = "002" Then W7171.seBasicMaster = "001"

    End Sub
    Private Sub DATA_INSERT()

        Call DATA_MOVE()

        If READ_PFK7171(W7171.BasicSel, W7171.BasicCode) = True Then
            Call MsgBoxP("294", "DATA_INSERT")
            txt_BasicSel.Focus()
            Call KEY_COUNT()
            Exit Sub
        End If

        W7171.InchargeInsert = Pub.SAW
        W7171.DateInsert = Pub.DAT
        W7171.TimeInsert = System_Date_time()
        W7171.DisplaySeq = CIntp(W7171.BasicCode)

        If WRITE_PFK7171(W7171) = True Then isudCHK = True : WRITE_CHK = "*"

    End Sub
    Private Sub DATA_UPDATE()
        If Data_Check() = False Then Exit Sub
        Call DATA_MOVE()

        W7171.DateUpdate = Pub.DAT
        W7171.TimeUpdate = System_Date_time()
        W7171.InchargeUpdate = Pub.SAW

        If Block1.Enabled = True Then
            If REWRITE_PFK7171(W7171) = True Then isudCHK = True
        Else
            If REWRITE_PFK7171(W7171) = True Then isudCHK = True
        End If

        Me.Dispose()

    End Sub

    Private Sub DATA_DELETE()
        If Pub.DEVCHK <> "1" Then MsgBoxP("DATA_DELETE", "003") : Exit Sub

        DATA_MOVE()
        If DELETE_PFK7171(W7171) = True Then isudCHK = True

        Me.Dispose()
    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = " SELECT MAX(CAST(K7171_BasicCode AS DECIMAL)) AS MAX_CODE FROM PFK7171 "
        SQL = SQL & " WHERE K7171_BasicSel = '" & L7171.BasicSel & "' AND ISNUMERIC(K7171_BasicCode) = 1 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7171.BasicCode = "001"
        Else
            L7171.BasicCode = Format(CInt(rd!MAX_CODE + 1), "000")
        End If

        W7171.BasicSel = L7171.BasicSel
        W7171.BasicCode = L7171.BasicCode

        rd.Close()

        If Val(W7171.BasicCode) > 999 Then
            Call KEY_COUNT_CHAR()
        End If

        txt_BasicSel.Data = W7171.BasicSel
        txt_BasicCode.Data = W7171.BasicCode

    End Sub

    Private Sub KEY_COUNT_CHAR()
        If KEY_CHK = "*" Then Exit Sub
        Dim Cha1 As String
        Dim Cha2 As String
        Dim Cha3 As String

        Dim Value1 As Integer
        Dim Value2 As Integer
        Dim Value3 As Integer

        Dim ValueTotal As Integer

        SQL = " SELECT K7171_BasicCode AS MAX_CODE FROM PFK7171 "
        SQL = SQL & " WHERE K7171_BasicSel = '" & L7171.BasicSel & "' AND ISNUMERIC(K7171_BasicCode) <> 1 ORDER BY K7171_BasicCode DESC "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows = True Then
            L7171.BasicCode = rd!MAX_CODE

            Cha1 = Strings.Mid(L7171.BasicCode, 1, 1)
            Cha2 = Strings.Mid(L7171.BasicCode, 2, 1)
            Cha3 = Strings.Mid(L7171.BasicCode, 3, 1)

            If L7171.BasicCode = "999" Then
                W7171.BasicSel = L7171.BasicSel
                W7171.BasicCode = "AA0"

                txt_BasicSel.Data = W7171.BasicSel
                txt_BasicCode.Data = W7171.BasicCode

                rd.Close()

            Else
                Value1 = Frist_Character_Interger(Cha1)
                Value2 = Second_Character_Interger(Cha2)
                Value3 = CIntp(Cha3)

                ValueTotal = Value1 + Value2 + Value3
                ValueTotal = ValueTotal + 1 ' tằng 1 Value1

                Cha1 = Frist_Character(ValueTotal)
                Cha2 = Second_Character(ValueTotal - Frist_Character_Interger(Cha1))
                Cha3 = (ValueTotal - Frist_Character_Interger(Cha1) - Second_Character_Interger(Cha2))

                W7171.BasicSel = L7171.BasicSel
                W7171.BasicCode = Cha1 + Cha2 + Cha3

                txt_BasicSel.Data = W7171.BasicSel
                txt_BasicCode.Data = W7171.BasicCode

            End If

        Else
            L7171.BasicCode = "AA0"
            W7171.BasicSel = L7171.BasicSel
            W7171.BasicCode = "AA0"

            txt_BasicSel.Data = W7171.BasicSel
            txt_BasicCode.Data = W7171.BasicCode

            rd.Close()

        End If

    End Sub
    Private Function Frist_Character_Interger(value As String) As Integer
        Select Case value
            Case "A" : Return 1000
            Case "B" : Return 1250
            Case "C" : Return 1500
            Case "D" : Return 1750
            Case "E" : Return 2000
            Case "F" : Return 2250
            Case "G" : Return 2500
            Case "H" : Return 2750
            Case "I" : Return 3000
            Case "J" : Return 3250
            Case "K" : Return 3500
            Case "L" : Return 3750
            Case "M" : Return 4000
            Case "N" : Return 4250
            Case "O" : Return 4500
            Case "P" : Return 4750
            Case "Q" : Return 5000
            Case "R" : Return 5250
            Case "S" : Return 5500
            Case "T" : Return 5750
            Case "U" : Return 6000
            Case "V" : Return 6250
            Case "W" : Return 6500
            Case "X" : Return 6750
            Case "Y" : Return 7000
            Case "Z" : Return 7250
        End Select
    End Function

    Private Function Second_Character_Interger(value As String) As Integer
        Select Case value
            Case "A" : Return 0
            Case "B" : Return 10
            Case "C" : Return 20
            Case "D" : Return 30
            Case "E" : Return 40
            Case "F" : Return 50
            Case "G" : Return 60
            Case "H" : Return 70
            Case "I" : Return 80
            Case "J" : Return 90
            Case "K" : Return 100
            Case "L" : Return 110
            Case "M" : Return 120
            Case "N" : Return 130
            Case "O" : Return 140
            Case "P" : Return 150
            Case "Q" : Return 160
            Case "R" : Return 170
            Case "S" : Return 180
            Case "T" : Return 190
            Case "U" : Return 200
            Case "V" : Return 210
            Case "W" : Return 220
            Case "X" : Return 230
            Case "Y" : Return 240
            Case "Z" : Return 250
        End Select
    End Function


    Private Function Frist_Character(value As Integer) As String
        Select Case True
            Case value < 1250 : Return "A"
            Case value < 1500 : Return "B"
            Case value < 1750 : Return "C"
            Case value < 2000 : Return "D"
            Case value < 2250 : Return "E"
            Case value < 2500 : Return "F"
            Case value < 2750 : Return "G"
            Case value < 3000 : Return "H"
            Case value < 3250 : Return "I"
            Case value < 3500 : Return "J"
            Case value < 3750 : Return "K"
            Case value < 4000 : Return "L"
            Case value < 4250 : Return "M"
            Case value < 4500 : Return "N"
            Case value < 4750 : Return "O"
            Case value < 5000 : Return "P"
            Case value < 5250 : Return "Q"
            Case value < 5500 : Return "R"
            Case value < 5750 : Return "S"
            Case value < 6000 : Return "T"
            Case value < 6250 : Return "U"
            Case value < 6500 : Return "V"
            Case value < 6750 : Return "W"
            Case value < 7000 : Return "X"
            Case value < 7250 : Return "Y"
            Case Else : Return "Z"

        End Select
    End Function

    Private Function Second_Character(value As Integer) As String
        Select Case True
            Case value < 10 : Return "A"
            Case value < 20 : Return "B"
            Case value < 30 : Return "C"
            Case value < 40 : Return "D"
            Case value < 50 : Return "E"
            Case value < 60 : Return "F"
            Case value < 70 : Return "G"
            Case value < 80 : Return "H"
            Case value < 90 : Return "I"
            Case value < 100 : Return "J"
            Case value < 110 : Return "K"
            Case value < 120 : Return "L"
            Case value < 130 : Return "M"
            Case value < 140 : Return "N"
            Case value < 150 : Return "O"
            Case value < 160 : Return "P"
            Case value < 170 : Return "Q"
            Case value < 180 : Return "R"
            Case value < 190 : Return "S"
            Case value < 200 : Return "T"
            Case value < 210 : Return "U"
            Case value < 220 : Return "V"
            Case value < 230 : Return "W"
            Case value < 240 : Return "X"
            Case value < 250 : Return "Y"
        End Select
    End Function

    Private Sub ListMenu()
        Try
            ListCons.Clear()

            SQL = " SELECT K7171_BasicCode AS CODE, ISNULL(K7171_NameHLPButton,'') as  NAME FROM PFK7171 "
            SQL = SQL & " WHERE K7171_BasicSel = '000' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            DS1 = PrcDS(cmd, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows
                ListCons.Add(New ListConstant With {.Code = RS01!CODE, .Name = RS01!NAME.ToString.ToUpper})
            Next

        Catch ex As Exception

        Finally
            DS1 = Nothing
        End Try


    End Sub

#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False

        rd = PrcDR("USP_PFP71710_SEARCH_vS2_LINE", cn, L7171.BasicSel, L7171.BasicCode)
        rd.Read()
        If rd.HasRows = False Then
            rd.Close() : isudCHK = False
            Me.Dispose() : Exit Function
        End If

        txt_BasicSel.Data = rd("BasicSel")
        txt_BasicCode.Data = rd("BasicCode")
        txt_BasicName.Data = rd("BasicName")
        txt_ForeignName1.Data = rd("ForeignName1")
        txt_ForeignName2.Data = rd("ForeignName2")
        txt_NameSimply.Data = rd("NameSimply")

        txt_NameHLPButton.Data = rd("NameHLPButton")


        Check1.Data = rd("Check1")
        Check2.Data = rd("Check2")
        Check3.Data = rd("Check3")
        Check4.Data = rd("Check4")
        Check5.Data = rd("Check5")
        Check6.Data = rd("Check6")
        Check7.Data = rd("Check7")
        Check8.Data = rd("Check8")
        Check9.Data = rd("Check9")
        Check10.Data = rd("Check10")

        CheckName1.Data = rd("CheckName1")
        CheckName2.Data = rd("CheckName2")
        CheckName3.Data = rd("CheckName3")
        CheckName4.Data = rd("CheckName4")
        CheckName5.Data = rd("CheckName5")
        CheckName6.Data = rd("CheckName6")
        CheckName7.Data = rd("CheckName7")
        CheckName8.Data = rd("CheckName8")
        CheckName9.Data = rd("CheckName9")
        CheckName10.Data = rd("CheckName10")

        DisplaySeq.Data = rd("DisplaySeq")

        txt_remark.Data = rd("Remark")

        txt_seBasicMaster.Data = rd("seBasicMaster")

        If rd("CheckUse") = "1" Then rad_CheckUse1.Checked = True
        If rd("CheckUse") = "2" Then rad_CheckUse2.Checked = True

        rd.Close()

        If READ_PFK7171(ListCode("BasicMaster"), txt_seBasicMaster.Code) Then
            txt_seBasicMaster.Data = D7171.BasicName
        End If

        DATA_SEARCH01 = True

    End Function
#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        If MsgBoxPPW("Please type the password to modify!", const_pwPO) = False Then Exit Sub

        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()
                Me.Form_Initial()
                Call FORM_INIT()
                Call DATA_INIT()
                Call KEY_COUNT()
                txt_BasicName.Focus()

                If txt_BasicSel.Data = "000" Then Call ListMenu()

            Case 2
                Me.Dispose()
            Case 3
                Call DATA_UPDATE()

                If txt_BasicSel.Data = "000" Then Call ListMenu()

            Case 4
                Call DATA_DELETE()

                If txt_BasicSel.Data = "000" Then Call ListMenu()

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
        If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub

        Dim Msg_Result As String

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
            Exit Sub
        End If

        Msg_Result = MsgBoxP("Do you want to delete", vbYesNo)
        If Msg_Result <> vbYes Then Exit Sub

        Call DATA_DELETE()
    End Sub

    Private Sub txt_selBasicMaster_txtTextChange(sender As Object, e As EventArgs) Handles txt_seBasicMaster.txtTextChange
        If formA = False Then Exit Sub
        If txt_BasicSel.Data = "002" Then Exit Sub

        If READ_PFK7171(Const_selBasicMaster, txt_seBasicMaster.Code) Then
            txt_cdBasicMaster.ButtonName = D7171.BasicCode
        End If
    End Sub

    Private Sub txt_cdBasicMaster_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdBasicMaster.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_BasicSel.Data = "002" Then
                If HLP7171ALL.Link_HLP7171A("001", "") Then
                    txt_cdBasicMaster.Data = D7171.BasicName
                    txt_cdBasicMaster.Code = D7171.BasicCode
                End If

                Exit Sub
            End If

            If HLP7171ALL.Link_HLP7171A(txt_seBasicMaster.Code, "") Then
                txt_cdBasicMaster.Data = D7171.BasicName
                txt_cdBasicMaster.Code = D7171.BasicCode
            End If

        End If
    End Sub

    Private Sub cmb_Click_Click(sender As Object, e As EventArgs) Handles cmb_Click.Click
        If txt_BasicSel.Data = "002" Then
            If HLP7171ALL.Link_HLP7171A("001", "") Then
                txt_cdBasicMaster.Data = D7171.BasicName
                txt_cdBasicMaster.Code = D7171.BasicCode
            End If

            Exit Sub
        End If


        If HLP7171ALL.Link_HLP7171A(txt_seBasicMaster.Code, "") Then
            txt_cdBasicMaster.Data = D7171.BasicName
            txt_cdBasicMaster.Code = D7171.BasicCode
        End If
    End Sub
#End Region

  
  
    
End Class