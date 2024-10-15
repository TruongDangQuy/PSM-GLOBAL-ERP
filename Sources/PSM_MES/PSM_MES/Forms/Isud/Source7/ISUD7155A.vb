Public Class ISUD7155A
    Private wJOB As Integer

    Private KEY_CHK As String
    Private WRITE_CHK As String

    Private W7155 As T7155_AREA
    Private L7155 As T7155_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String

    Public Function Link_ISUD7155A_AUTO(job As Integer, cdFactory As String, cdSubProcess As String, MachineCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7155.cdFactory = cdFactory
        D7155.cdSubProcess = cdSubProcess

        wJOB = job : L7155 = D7155

        Link_ISUD7155A_AUTO = False

        Select Case job
            Case 1
                If READ_PFK7171(ListCode("Factory"), cdFactory) = True Then
                    txt_cdFactory.Code = D7171.BasicCode
                    txt_cdFactory.Data = D7171.BasicName
                End If

                If READ_PFK7171(ListCode("SubProcess"), cdSubProcess) = True Then
                    txt_cdSubProcess.Code = D7171.BasicCode
                    txt_cdSubProcess.Data = D7171.BasicName
                End If

            Case Else
                If READ_PFK7155(L7155.MachineCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")
                    Exit Function
                End If
        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD7155A_AUTO = isudCHK
    End Function

    Public Function Link_ISUD7155A(job As Integer, MachineCode As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D7155.MachineCode = MachineCode

        wJOB = job : L7155 = D7155

        Link_ISUD7155A = False

        Select Case job
            Case 1

            Case Else
                If READ_PFK7155(L7155.MachineCode) = False Then
                    Call MsgBoxP("3", "LINK_ISUD")
                    Exit Function
                End If
        End Select

        formA = False
        Me.ShowDialog()

        Link_ISUD7155A = isudCHK
    End Function
#Region "Form_load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Call MsgBoxP("You have no right is this program !")
                    Me.Dispose()
                    Exit Sub
                End If

                cmd_DEL.Visible = False

                Call KEY_COUNT()
                Setfocus(txt_MachineName)

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Call MsgBoxP("You have no right is this program !")
                    Me.Dispose()
                    Exit Sub
                End If

                cmd_DEL.Visible = False
                cmd_OK.Visible = False

                Call DATA_SEARCH01()

            Case 3
                Me.Text = Me.Text & " - UPDATE"

                If CHK(3) <> "1" Then
                    isudCHK = False
                    Call MsgBoxP("You have no right is this program !")

                    Me.Dispose()
                    Exit Sub
                End If

                cmd_DEL.Visible = False
                cmd_OK.Visible = True

                Call DATA_SEARCH01()
            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    Call MsgBoxP("You have no right is this program !")
                    Me.Dispose()
                    Exit Sub
                End If

                frm_Condition.Enabled = False

                cmd_DEL.Visible = True
                cmd_OK.Visible = False

                Call DATA_SEARCH01()
        End Select

        Call CheckBlock1()

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Call D7155_CLEAR()
        W7155 = D7155

        txt_MachineName.Data = ""
        txt_MachineNameSimply.Data = ""

        txt_VerticalPosition.Data = ""
        txt_HorizontalPosition.Data = ""

        KEY_CHK = ""
    End Sub

#End Region

#Region "Function"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        DS1 = READ_PFK7155(L7155.MachineCode, cn)

        If GetDsRc(DS1) = 0 Then
            Exit Function : Me.Dispose()
            isudCHK = False
        End If

        READER_MOVE(Me, DS1)
        DATA_SEARCH01 = True

    End Function

    Private Sub DATA_MOVE()
        Call K7155_MOVE(Me, W7155, wJOB, txt_MachineCode.Data)

        If chk_CheckFinalProcess1.Checked = True Then W7155.CheckFinalProcess = "1" Else W7155.CheckFinalProcess = "2"
        If chk_CheckProcess1.Checked = True Then W7155.CheckProcess = "1" Else W7155.CheckProcess = "2"
        If chk_checkUse1.Checked = True Then W7155.checkUse = "1" Else W7155.checkUse = "2"
       
        W7155.seMachineType = ListCode("MachineType")
        W7155.seFactory = ListCode("Factory")
        W7155.seSubProcess = ListCode("SubProcess")

        If FormatCut(W7155.DevelopmentCode) = "" Then W7155.DevelopmentCode = W7155.MachineCode

    End Sub

    Private Function DATA_INSERT() As Boolean
        DATA_INSERT = False
        Call DATA_MOVE()
        Call KEY_COUNT()

        If READ_PFK7155(W7155.MachineCode) = True Then
            Call MsgBoxP("5", "DATA_INSERT")
            Call KEY_COUNT()
            Exit Function
        End If


        If WRITE_PFK7155(W7155) = True Then isudCHK = True : WRITE_CHK = "*"
        DATA_INSERT = True
    End Function

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        If DataCheck(Me) = False Then Exit Function

        Call DATA_MOVE()
        If REWRITE_PFK7155(W7155) = True Then isudCHK = True
        DATA_UPDATE = True
        Me.Dispose()
    End Function

    Private Sub DATA_DELETE()
        DATA_MOVE()

        W7155.checkUse = "2"

        If REWRITE_PFK7155(W7155) = True Then isudCHK = True

        Me.Dispose()

    End Sub

    Private Sub KEY_COUNT()
        If KEY_CHK = "*" Then Exit Sub

        SQL = "SELECT MAX(CAST(K7155_MachineCode AS DECIMAL)) AS MAX_MCODE FROM PFK7155 "
        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_MCODE) Then
            L7155.MachineCode = "000001"
        Else
            L7155.MachineCode = Format(CInt(rd!MAX_MCODE + 1), "000000")
        End If

        W7155.MachineCode = L7155.MachineCode
        rd.Close()

        txt_MachineCode.Data = W7155.MachineCode
    End Sub
    Private Sub CheckBlock1()
    
    End Sub
    Private Function Data_Check(HorizontalPosition As Integer, VerticalPosition As Integer) As Boolean
        Data_Check = False

        Try
            SQL = "SELECT *  FROM PFK7155 "
            SQL = SQL & " WHERE K7155_cdMachineType = '" & txt_cdMachineType.Code & "' "
            SQL = SQL & " AND K7155_HorizontalPosition = '" & HorizontalPosition & "' "
            SQL = SQL & " AND K7155_VerticalPosition = '" & VerticalPosition & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If rd.HasRows = False Then Data_Check = True
            MsgBoxP("Vertial and horizon had been inputed already!")
            rd.Close()

        Catch ex As Exception
            MsgBoxP("Data_Check")
        End Try
    End Function
#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK7155") = False Then Exit Sub
                Call KEY_COUNT()
                If DATA_INSERT() = False Then Exit Sub

                Call DATA_INIT()
                Call KEY_COUNT()
                Setfocus(txt_MachineName)
            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK7155") = False Then Exit Sub
                If DATA_UPDATE() = False Then Exit Sub
            Case 4
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
    Private Sub txt_cdMachineType_Load(sender As Object, e As EventArgs) Handles txt_cdMachineType.txtTextChange
        CheckBlock1()
    End Sub
#End Region

 
   
   
End Class