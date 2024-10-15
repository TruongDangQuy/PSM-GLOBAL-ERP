Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4073H

#Region "Variable"
    Private wJOB As Integer

    Private W4073 As New T4073_AREA
    Private L4073 As New T4073_AREA

    Private W4074 As New T4074_AREA
    Private L4074 As New T4074_AREA

    Private W0175 As New T0175_AREA
    Private L0175 As New T0175_AREA

    Private W0171 As New T0171_AREA
    Private L0171 As New T0171_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD4073H(job As Integer, cdFactory As String, cdMainProcess As String, cdLineProd As String, LineTno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4073.cdLineProd = cdLineProd
        D4073.cdFactory = cdFactory
        D4073.cdMainProcess = cdMainProcess
        D4073.LineTno = LineTno

        D0171.cdLineProd = cdLineProd
        D0171.cdFactory = cdFactory
        D0171.cdMainProcess = cdMainProcess
        D0171.LineTno = LineTno

        txt_cdFactory.Data = cdFactory
        txt_cdMainProcess.Data = cdMainProcess
        txt_cdLineProd.Data = cdLineProd
        txt_LineTno.Data = LineTno

        txt_cdFactory.Code = cdFactory
        txt_cdMainProcess.Code = cdMainProcess
        txt_cdLineProd.Code = cdLineProd
        txt_LineTno.Code = LineTno

        wJOB = job : L4073 = D4073

        Link_ISUD4073H = False
        Try
            formA = False


            Select Case job
                Case 4
                    If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
                        If D4073.CheckComplete <> "1" Then cmd_DEL.Visible = False : cmd_OK.Visible = False : wJOB = 2
                    Else
                        Exit Function
                    End If

                Case 5

                Case Else
                    If READ_PFK4073(cdFactory, cdMainProcess, cdLineProd, LineTno) Then
                        If D4073.QtyProd > 0 Or D4073.CheckComplete <> "1" Then cmd_DEL.Visible = False : cmd_OK.Visible = False : wJOB = 2
                    Else
                        Exit Function
                    End If

            End Select

            Me.ShowDialog()

            Link_ISUD4073H = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))


begin:

        Select Case wJOB

            Case 2

                If CHK(2) <> "1" Then
                    isudCHK = False
                    formA = True
                    Me.Dispose()
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                Else
                    Me.Text = Me.Text & " - SEARCH"
                    isudCHK = False
                    wJOB = 2
                    cmd_DEL.Visible = False
                    cmd_OK.Visible = False
                    txt_Barcode.Enabled = False
                    Call DATA_SEARCH_HEAD()
                    Call DATA_SEARCH_HEAD_TAB1()
                    Call K4073_CheckComplete(True, True, True, True, True, True)
                End If
            Case 4
                If CHK(4) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - DELETE"
                cmd_DEL.Visible = True
                cmd_OK.Visible = False
                txt_Barcode.Enabled = False
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call K4073_CheckComplete(True, True, True, True, True, True)


            Case 5
                If CHK(3) <> "1" Then
                    If CHK(2) <> "1" Then
                        isudCHK = False
                        formA = True
                        Me.Dispose()
                        Call MsgBoxP("You have no right is this program !")
                        Exit Sub
                    Else
                        Me.Text = Me.Text & " - SEARCH"
                        isudCHK = False
                        wJOB = 2
                        cmd_DEL.Visible = False
                        GoTo Begin
                    End If
                End If

                Me.Text = Me.Text & " - UPDATE"
                cmd_DEL.Visible = False
                txt_Barcode.Enabled = False
                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call K4073_CheckComplete(True, True, True, True, True, True)


        End Select


        formA = True
    End Sub
#End Region

#Region "Search"
    Private Sub DATA_INIT()
        Try
            txt_DatePlan.Data = Pub.DAT

            txt_InchargePlan.Data = Pub.NAM
            txt_InchargePlan.Code = Pub.SAW
        Catch ex As Exception
            Call MsgBoxP("DATA_INIT")
        End Try
    End Sub
    Private Sub Calculation()

    End Sub
    Private Sub FORM_INIT()
        RemoveHandler txt_Barcode.PeaceTextbox1.KeyDown, AddressOf standard_KeyDown

        txt_Barcode.PeaceTextbox1.Properties.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub KEY_COUNT()
        Try
            SQL = "SELECT MAX(CAST(K4073_LineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4073 "
            SQL = SQL & " WHERE K4073_cdFactory = '" & txt_cdFactory.Code & "' "
            SQL = SQL & " AND K4073_cdMainProcess = '" & txt_cdMainProcess.Code & "' "
            SQL = SQL & " AND K4073_cdLineProd = '" & txt_cdLineProd.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4073.LineTno = "01"
            Else
                L4073.LineTno = CIntp(rd!MAX_MCODE + 1).ToString("00")
            End If

            W4073.LineTno = L4073.LineTno
            txt_LineTno.Data = L4073.LineTno

            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_K0175_BATCHNO()
        Dim YRNO As Integer
        YRNO = CIntp(Mid(System_Date_8(), 3, 2))

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K0175_BatchNo,3,8) AS DECIMAL)) AS MAX_MCODE FROM PFK0175 "
            SQL = SQL & " WHERE SUBSTRING(K0175_BatchNo,1,2) = '" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L0175.BatchNo = YRNO.ToString & "00000001"
            Else
                L0175.BatchNo = YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("00000000")
            End If

            W0175.BatchNo = L0175.BatchNo
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT_K0175_BatchGroup()
        Dim YRNO As Integer
        YRNO = CIntp(Mid(System_Date_8(), 3, 4))

        Try
            SQL = "SELECT MAX(CAST(SUBSTRING(K0175_BatchGroup,7,10) AS DECIMAL)) AS MAX_MCODE FROM PFK0175 "
            SQL = SQL & " WHERE SUBSTRING(K0175_BatchGroup,1,6) = 'CT" & YRNO.ToString & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L0175.BatchGroup = "CT" & YRNO.ToString & "0001"
            Else
                L0175.BatchGroup = "CT" & YRNO.ToString & CIntp(rd!MAX_MCODE + 1).ToString("0000")
            End If

            W0175.BatchGroup = L0175.BatchGroup
            rd.Close()
        Catch ex As Exception
            Call MsgBoxP("KEY_COUNT")
        End Try
    End Sub

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try

            DS1 = PrcDS("USP_ISUD4073P_SEARCH_HEAD", cn, L4073.cdFactory,
                                                         L4073.cdMainProcess,
                                                         L4073.cdLineProd,
                                                         L4073.LineTno)

            If GetDsRc(DS1) = 0 Then
                If READ_PFK7171(ListCode("Factory"), L4073.cdFactory) = True Then
                    txt_cdFactory.Data = D7171.BasicName
                    txt_cdFactory.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("MainProcess"), L4073.cdMainProcess) = True Then
                    txt_cdMainProcess.Data = D7171.BasicName
                    txt_cdMainProcess.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("LineProd"), L4073.cdLineProd) = True Then
                    txt_cdLineProd.Data = D7171.BasicName
                    txt_cdLineProd.Code = D7171.BasicCode
                End If

                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            L4073.JobCard = GetDsData(DS1, 0, "JobCard")

            Call K4073_CheckComplete(GetDsData(DS1, 0, "CheckComplete"))

            DATA_SEARCH_HEAD = True

            If READ_PFK7171(ListCode("Factory"), L4073.cdFactory) = True Then
                txt_cdFactory.Data = D7171.BasicName
                txt_cdFactory.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("MainProcess"), L4073.cdMainProcess) = True Then
                txt_cdMainProcess.Data = D7171.BasicName
                txt_cdMainProcess.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("LineProd"), L4073.cdLineProd) = True Then
                txt_cdLineProd.Data = D7171.BasicName
                txt_cdLineProd.Code = D7171.BasicCode
            End If

            Call StoreFormat(Me)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH_HEAD_TAB1() As Boolean
        DATA_SEARCH_HEAD_TAB1 = False
        DATA_SEARCH_HEAD_TAB1 = True
        Exit Function

        L4073.cdFactory = txt_cdFactory.Code
        L4073.cdMainProcess = txt_cdMainProcess.Code
        L4073.cdLineProd = txt_cdLineProd.Code
        L4073.LineTno = txt_LineTno.Data

        Try
            If READ_PFK4073(L4073.cdFactory,
                            L4073.cdMainProcess,
                            L4073.cdLineProd,
                            L4073.LineTno) = True Then

                L4073.JobCard = D4073.JobCard
            Else
                Exit Function
            End If

            DS1 = PrcDS("USP_ISUD4073P_SEARCH_sTAB1_HEAD", cn, L4073.JobCard)

            STORE_MOVE(Block1, DS1)

            DATA_SEARCH_HEAD_TAB1 = True

            Call StoreFormat(Block1)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            DS1 = PrcDS("USP_ISUD4073P_SEARCH_vS1", cn, L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH01 = True
            Call StoreFormat(Me)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function





    Private Function K4073_CheckMethodDyeing5() As String

    End Function

    Private Sub K4073_CheckComplete(Check1 As Boolean, Check2 As Boolean, Check3 As Boolean, Check4 As Boolean, Check5 As Boolean, Check6 As Boolean)
        chk_CheckComplete1.Enabled = Check1
        chk_CheckComplete2.Enabled = Check2
        chk_CheckComplete3.Enabled = Check3
        chk_CheckComplete4.Enabled = Check4
        chk_CheckComplete5.Enabled = Check5
        chk_CheckComplete6.Enabled = Check6

        If Check1 = True Then Setfocus(chk_CheckComplete1)
        If Check2 = True Then Setfocus(chk_CheckComplete2)
        If Check6 = True Then Setfocus(chk_CheckComplete6)

    End Sub
    Private Sub K4073_CheckMethodDyeing5(Value As String)
    End Sub
    Private Sub K4073_CheckComplete(Value As String)
        chk_CheckComplete1.Checked = True
        If Value = "1" Then chk_CheckComplete1.Checked = True : Exit Sub
        If Value = "2" Then chk_CheckComplete2.Checked = True : Exit Sub
        If Value = "3" Then chk_CheckComplete3.Checked = True : Exit Sub
        If Value = "4" Then chk_CheckComplete4.Checked = True : Exit Sub
        If Value = "5" Then chk_CheckComplete5.Checked = True : Exit Sub
        If Value = "6" Then chk_CheckComplete6.Checked = True : Exit Sub
    End Sub

    Private Sub K4073_CheckComplete()
        W4073.CheckComplete = "1"
        If chk_CheckComplete1.Checked = True Then W4073.CheckComplete = "1" : Exit Sub
        If chk_CheckComplete2.Checked = True Then W4073.CheckComplete = "2" : Exit Sub
        If chk_CheckComplete3.Checked = True Then W4073.CheckComplete = "3" : Exit Sub
        If chk_CheckComplete4.Checked = True Then W4073.CheckComplete = "4" : Exit Sub
        If chk_CheckComplete5.Checked = True Then W4073.CheckComplete = "5" : Exit Sub
        If chk_CheckComplete6.Checked = True Then W4073.CheckComplete = "6" : Exit Sub
    End Sub

    Private Sub K4073_CheckProduction()
    End Sub

    Private Sub K4073_CheckProduction(Value As String)
    End Sub




    Private Function DATA_CHECKSTATUS() As Boolean
        DATA_CHECKSTATUS = False
        Try
            If READ_PFK4073(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno) = True Then
                W4073 = D4073
                Call K4073_CheckComplete()
                W4073.ETimeProduction = System_Date_time()

                If REWRITE_PFK4073(W4073) = True Then
                    isudCHK = True
                    WRITE_CHK = "*"
                    DATA_CHECKSTATUS = True
                End If
            End If

            If L4073.cdMainProcess = "013" And W4073.CheckComplete = "2" Then

                Call PrcExeNoError("USP_DISABLE_TRIGGER", cn, "''PFK4074''")
                Call DELETE_PFK4073(W4073)


            End If

        Catch ex As Exception
            MsgBoxP("DATA_CHECKSTATUS!")

        Finally
            Call PrcExeNoError("USP_ENABLE_TRIGGER", cn, "''PFK4074''")

        End Try
    End Function
    Private Sub KEY_COUNT_NO()
        Dim YRNO As Integer
        YRNO = Pub.DAT
    End Sub


    Private Function DATA_DELETE()
        DATA_DELETE = False
        Try

            If READ_PFK4073(D4073.cdFactory, D4073.cdMainProcess, D4073.cdLineProd, D4073.LineTno) Then
                W4073 = D4073

                Dim i As Integer
                Dim Scol As Integer
                Dim FixCol As Integer

                For i = 1 To 30
                    If READ_PFK4074(L4073.cdFactory, L4073.cdMainProcess, L4073.cdLineProd, L4073.LineTno, i.ToString("00")) Then
                        W4074 = D4074
                        Call DELETE_PFK4074(W4074)
                    End If
                Next

                If DELETE_PFK4073(W4073) = True Then
                    DATA_DELETE = True
                    isudCHK = True
                End If
            End If

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function


#End Region

#Region "Event"

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 5
                Call DATA_CHECKSTATUS()
                isudCHK = True
                Me.Dispose()
        End Select

    End Sub



    Private Sub txt_GreyBarcode_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_Barcode.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then
            If txt_DatePlan.Data = "" Then txt_DatePlan.Data = Pub.DAT
            If txt_cdFactory.Code = "" Then MsgBoxP("No Factory!") : Exit Sub

            If txt_DatePlan.Data <> Pub.DAT Then
                MsgBoxP("Can not edit because of not today!")
                If MsgBoxPPW("Please type the password to modify!", const_pwPrintUpdate) = False Then Exit Sub
            End If

            txt_Barcode.Data = ""
            Me.Show()

            Application.DoEvents()
            Setfocus(txt_Barcode)
        End If
    End Sub

    Private Sub cmd_DEL_Click(sender As Object, e As EventArgs) Handles cmd_DEL.Click

        If CHK(4) <> "1" Then MsgBoxP("You have no right in this program!") : Exit Sub
        Msg_Result = MsgBoxP("Do you want to delete this plan?", vbYesNo)

        If Msg_Result <> vbYes Then Exit Sub

        If MsgBoxPPW("Please type the password to modify!", "002") = False Then Exit Sub

        Try
            Call DATA_DELETE()
            Me.Dispose()
        Catch ex As Exception
            MsgBoxP("cmd_DEL_Click")
        End Try
    End Sub

#End Region

   
End Class