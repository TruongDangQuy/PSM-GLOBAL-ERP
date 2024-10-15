Public Class ISUD7271A

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7271 As T7271_AREA
    Private L7271 As T7271_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7271A(job As Integer, cdWarehouseGroup As String, cdWarehouseCode As String, WarehousePositionCode As String, Optional ByVal TAG As String = "") As Boolean

        D7271.cdWarehouseGroup = cdWarehouseGroup
        D7271.cdWarehouseCode = cdWarehouseCode
        D7271.WarehousePositionCode = WarehousePositionCode

        wJOB = job : L7271 = D7271

        Link_ISUD7271A = False

        Select Case job
            Case 1
            Case Else
                If READ_PFK7271(L7271.cdWarehouseGroup, L7271.cdWarehouseCode, L7271.WarehousePositionCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")

                    Exit Function
                End If
               
        End Select

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD7271A = isudCHK

    End Function
#End Region

#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub
        Me.Form_Initial()
        Me.Form_KeyDown()
        WRITE_CHK = ""
        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1

                If READ_PFK7171(Const_WareHouseGroup, L7271.cdWarehouseGroup) = True Then
                    txt_cdWarehouseGroup.Code = D7171.BasicCode
                    txt_cdWarehouseGroup.Data = D7171.BasicName
                    If READ_PFK7171(D7171.Check6, L7271.cdWarehouseCode) = True Then
                        txt_cdWarehouseCode.Data = D7171.BasicName
                        txt_cdWarehouseCode.Code = D7171.BasicCode
                    End If
                End If
                Me.Text = Me.Text & " - INSERT"

                Call KEY_COUNT()

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                cmd_DEL.Visible = False

            Case 2
                Me.Text = Me.Text & " - SEARCH"

                'frm_Condition.Enabled = False
                cmd_DEL.Visible = False

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
                txt_cdWarehouseGroup.Enabled = False
                txt_cdWarehouseCode.Enabled = False

                cmd_DEL.Visible = True
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
                        frm_Condition.Enabled = False
                        cmd_DEL.Visible = False
                        Call MsgBoxP("Only Search !"): cmd_OK.Visible = False
                    End If
                End If

            Case 4
                Me.Text = Me.Text & " - DELETE"

                frm_Condition.Enabled = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("4", "Form_Activate")
                    Exit Sub
                End If

                Call DATA_SEARCH01()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7271_CLEAR()

        W7271 = D7271
        KEY_CHK = ""
        frm_Condition.Enabled = True
        cmd_Cancel.Enabled = True
        cmd_OK.Enabled = True
        cmd_DEL.Enabled = True
        cmd_Cancel.Visible = True
        cmd_OK.Visible = True
        cmd_DEL.Visible = True


    End Sub
    Private Sub FORM_INIT()
    End Sub
#End Region

#Region "Function"
    Private Function Data_Check() As Boolean

        'If Trim$(txt_cdSemiGroupMaterial.Data) = "" Then txt_cdSemiGroupMaterial.Code = ""
        'If Trim$(txt_cdLargeGroupMaterial.Data) = "" Then txt_cdLargeGroupMaterial.Code = ""


        'txt_MaterialName.Data = Replace(txt_MaterialName.Data, "'", "`")
        'txt_MaterialNameSimply.Data = Replace(txt_MaterialNameSimply.Data, "'", "`")
        'txt_ForeignName1.Data = Replace(txt_ForeignName1.Data, "'", "`")
        'txt_ForeignName2.Data = Replace(txt_ForeignName2.Data, "'", "`")
        'txt_CompenyID.Data = Replace(txt_CompenyID.Data, "'", "`")
        'txt_CompenyItem.Data = Replace(txt_CompenyItem.Data, "'", "`")
        'txt_Representative.Data = Replace(txt_Representative.Data, "'", "`")

        'Data_Check = False

        'If IsDBNull(txt_MaterialCode.Data) = True Or txt_MaterialCode.Data = "" Then
        '    Call MsgBoxP("298", "DATA_CHECK")
        '    txt_MaterialCode.Focus()
        '    Exit Function
        'End If

        'If txt_MaterialName.Data = "" Then
        '    Call MsgBoxP("299", "DATA_CHECK")
        '    txt_MaterialName.Focus()
        '    Exit Function
        'End If

        'If chk_CheckSale.Checked = False And chk_CheckBuying.Checked = False And chk_CheckInbound.Checked = False And _
        '    chk_CheckOutbound.Checked = False And chk_CheckMaterial.Checked = False And chk_CheckOthers.Checked = False Then
        '    Call MsgBoxP("188", "DATA_CHECK")
        '    chk_CheckSale.Focus()
        '    Exit Function
        'End If

        Data_Check = True

    End Function
    Private Sub DATA_MOVE()


        If rad_CheckUse1.Checked = True Then W7271.checkUse = "1"
        If rad_CheckUse2.Checked = True Then W7271.checkUse = "2"


    End Sub

    Private Sub DATA_INSERT()
      
        Call DATA_MOVE()

        If K7271_MOVE(Me, W7271, 1, txt_cdWarehouseGroup.Code, txt_cdWarehouseCode.Code, txt_WarehousePositionCode.Code) = False Then

            'If READ_PFK7271(W7271.cdWarehouseGroup, W7271.cdWarehouseCode, W7271.WarehousePositionCode) = True Then
            '    Call MsgBoxP("5", "DATA_INSERT")

            Call KEY_COUNT()
            '    Setfocus(txt_WarehousePositionName)
            '    Exit Sub
            'End If

            If WRITE_PFK7271(W7271) = True Then isudCHK = True : WRITE_CHK = "*"
        Else

            If REWRITE_PFK7271(W7271) = True Then isudCHK = True : WRITE_CHK = "*"

        End If

    End Sub
    Private Sub DATA_UPDATE()
        'K7271_MOVE(Me, W7271, 3)

        'If REWRITE_PFK7271(W7271) = True Then isudCHK = True
        If K7271_MOVE(Me, W7271, 1, txt_cdWarehouseGroup.Code, txt_cdWarehouseCode.Code, txt_WarehousePositionCode.Code) = False Then

            'If READ_PFK7271(W7271.cdWarehouseGroup, W7271.cdWarehouseCode, W7271.WarehousePositionCode) = True Then
            '    Call MsgBoxP("5", "DATA_INSERT")

            Call KEY_COUNT()
            '    Setfocus(txt_WarehousePositionName)
            '    Exit Sub
            'End If

            If WRITE_PFK7271(W7271) = True Then isudCHK = True : WRITE_CHK = "*"
        Else

            If REWRITE_PFK7271(W7271) = True Then isudCHK = True : WRITE_CHK = "*"

        End If
        Me.Dispose()

    End Sub
    Private Sub DATA_DELETE()
        'K7271_MOVE(Me, W7271, 3)

        If K7271_MOVE(Me, W7271, 1, txt_cdWarehouseGroup.Code, txt_cdWarehouseCode.Code, txt_WarehousePositionCode.Code) = True Then
            If DELETE_PFK7271(W7271) = True Then isudCHK = True
            Me.Dispose()
        End If

    End Sub
    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7271_WarehousePositionCode AS DECIMAL)) AS MAX_CODE FROM PFK7271 "
        SQL = SQL & " WHERE K7271_cdWarehouseGroup  = '" + txt_cdWarehouseGroup.Code + "' "
        SQL = SQL & " AND K7271_cdWarehouseCode = '" + txt_cdWarehouseCode.Code + "' "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            L7271.WarehousePositionCode = "00001"
        Else
            L7271.WarehousePositionCode = Format(CInt(rd!MAX_CODE + 1), "00000")
        End If
        rd.Close()
        W7271.WarehousePositionCode = L7271.WarehousePositionCode

        txt_WarehousePositionCode.Data = W7271.WarehousePositionCode
        txt_WarehousePositionCode.Code = W7271.WarehousePositionCode

    End Sub


#End Region

#Region "DATA_SEARCH"
    Private Function DATA_SEARCH01() As Boolean

        DATA_SEARCH01 = False
        

        DS1 = READ_PFK7271(L7271.cdWarehouseGroup, L7271.cdWarehouseCode, L7271.WarehousePositionCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function : Me.Dispose()
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)

        If READ_PFK7171(Const_WareHouseGroup, L7271.cdWarehouseGroup) = True Then
            If READ_PFK7171(D7171.Check6, L7271.cdWarehouseCode) = True Then
                txt_cdWarehouseCode.Data = D7171.BasicName
                txt_cdWarehouseCode.Code = D7171.BasicCode
            End If
        End If
        DATA_SEARCH01 = True

    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7271") = False Then Exit Sub
                Call DATA_INSERT()
                Me.Form_ClearData()
                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_WarehousePositionName)
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7271") = False Then Exit Sub
                Call DATA_UPDATE()
            Case 4
                If DataCheck(Me, "PFK7271") = False Then Exit Sub
                Call DATA_DELETE()
        End Select

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
    End Sub
    Private Sub txt_cdWarehouseCode_Load(sender As Object, e As EventArgs) Handles txt_cdWarehouseCode.btnTitleClick
        If READ_PFK7171(Const_WareHouseGroup, txt_cdWarehouseGroup.Code) = True Then
            HLPNA = D7171.Check6
            Dim f As New Form
            f = New HLP7171ALL
            f.ShowDialog()
            If hlp0000SeVaTt = "" Or hlp0000SeVaTt = "" Then Exit Sub
            txt_cdWarehouseCode.Data = hlp0000SeVa
            txt_cdWarehouseCode.Code = hlp0000SeVaTt
            KEY_COUNT()
        End If
    End Sub
#End Region


  
End Class