Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class ISUD4070P

#Region "Variable"
    Private wJOB As Integer

    Private W4070 As New T4070_AREA
    Private L4070 As New T4070_AREA

    Private W0175 As New T0175_AREA
    Private L0175 As New T0175_AREA

    Private W4071 As New T4071_AREA
    Private L4071 As New T4071_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD4070P(job As Integer, cdFactory As String, cdMainProcess As String, MachineCode As String, MachineTno As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D4070.MachineCode = MachineCode
        D4070.cdFactory = cdFactory
        D4070.cdMainProcess = cdMainProcess
        D4070.MachineTno = MachineTno

        D4071.MachineCode = MachineCode
        D4071.cdFactory = cdFactory
        D4071.cdMainProcess = cdMainProcess
        D4071.MachineTno = MachineTno

        txt_cdFactory.Data = cdFactory
        txt_cdMainProcess.Data = cdMainProcess
        txt_MachineCode.Data = MachineCode
        txt_MachineTno.Data = MachineTno

        txt_cdFactory.Code = cdFactory
        txt_cdMainProcess.Code = cdMainProcess
        txt_MachineCode.Code = MachineCode
        txt_MachineTno.Code = MachineTno

        wJOB = job : L4070 = D4070

        Link_ISUD4070P = False
        Try
            formA = False


            Select Case job
                Case 1

                Case 5

                Case Else
                    If READ_PFK4070(cdFactory, cdMainProcess, MachineCode, MachineTno) Then
                        If D4070.QtyProd > 0 Or D4070.CheckComplete <> "1" Then cmd_DEL.Visible = False : cmd_OK.Visible = False : wJOB = 2
                    Else
                        Exit Function
                    End If

            End Select

            Me.ShowDialog()

            Link_ISUD4070P = isudCHK


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

                Call DATA_SEARCH_HEAD()
                Call DATA_SEARCH_HEAD_TAB1()
                Call K4070_CheckComplete(True, True, True, True, True, True)


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
            SQL = "SELECT MAX(CAST(K4070_MachineTno AS DECIMAL)) AS MAX_MCODE FROM PFK4070 "
            SQL = SQL & " WHERE K4070_cdFactory = '" & txt_cdFactory.Code & "' "
            SQL = SQL & " AND K4070_cdMainProcess = '" & txt_cdMainProcess.Code & "' "
            SQL = SQL & " AND K4070_MachineCode = '" & txt_MachineCode.Code & "' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L4070.MachineTno = "01"
            Else
                L4070.MachineTno = CIntp(rd!MAX_MCODE + 1).ToString("00")
            End If

            W4070.MachineTno = L4070.MachineTno
            txt_MachineTno.Data = L4070.MachineTno

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

            DS1 = PrcDS("USP_ISUD4070P_SEARCH_HEAD", cn, L4070.cdFactory,
                                                         L4070.cdMainProcess,
                                                         L4070.MachineCode,
                                                         L4070.MachineTno)

            If GetDsRc(DS1) = 0 Then
                If READ_PFK7171(ListCode("Factory"), L4070.cdFactory) = True Then
                    txt_cdFactory.Data = D7171.BasicName
                    txt_cdFactory.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("MainProcess"), L4070.cdMainProcess) = True Then
                    txt_cdMainProcess.Data = D7171.BasicName
                    txt_cdMainProcess.Code = D7171.BasicCode
                End If

                If READ_PFK7171(ListCode("LineProd"), L4070.MachineCode) = True Then
                    txt_MachineCode.Data = D7171.BasicName
                    txt_MachineCode.Code = D7171.BasicCode
                End If

                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            L4070.JobCard = GetDsData(DS1, 0, "JobCard")

            Call K4070_CheckComplete(GetDsData(DS1, 0, "CheckComplete"))

            DATA_SEARCH_HEAD = True

            If READ_PFK7171(ListCode("Factory"), L4070.cdFactory) = True Then
                txt_cdFactory.Data = D7171.BasicName
                txt_cdFactory.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("MainProcess"), L4070.cdMainProcess) = True Then
                txt_cdMainProcess.Data = D7171.BasicName
                txt_cdMainProcess.Code = D7171.BasicCode
            End If

            If READ_PFK7171(ListCode("LineProd"), L4070.MachineCode) = True Then
                txt_MachineCode.Data = D7171.BasicName
                txt_MachineCode.Code = D7171.BasicCode
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

        L4070.cdFactory = txt_cdFactory.Code
        L4070.cdMainProcess = txt_cdMainProcess.Code
        L4070.MachineCode = txt_MachineCode.Code
        L4070.MachineTno = txt_MachineTno.Data

        Try
            If READ_PFK4070(L4070.cdFactory,
                            L4070.cdMainProcess,
                            L4070.MachineCode,
                            L4070.MachineTno) = True Then

                L4070.JobCard = D4070.JobCard
            Else
                Exit Function
            End If

            DS1 = PrcDS("USP_ISUD4070P_SEARCH_sTAB1_HEAD", cn, L4070.JobCard)

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
            DS1 = PrcDS("USP_ISUD4070P_SEARCH_vS1", cn, L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno)

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





    Private Function K4070_CheckMethodDyeing5() As String

    End Function

    Private Sub K4070_CheckComplete(Check1 As Boolean, Check2 As Boolean, Check3 As Boolean, Check4 As Boolean, Check5 As Boolean, Check6 As Boolean)
        chk_CheckComplete1.Enabled = Check1
        chk_CheckComplete2.Enabled = Check2
        chk_CheckComplete3.Enabled = Check3
        chk_CheckComplete4.Enabled = Check4
        chk_CheckComplete5.Enabled = Check5
        chk_CheckComplete6.Enabled = Check6
    End Sub
    Private Sub K4070_CheckMethodDyeing5(Value As String)
    End Sub
    Private Sub K4070_CheckComplete(Value As String)
        chk_CheckComplete1.Checked = True
        If Value = "1" Then chk_CheckComplete1.Checked = True : Exit Sub
        If Value = "2" Then chk_CheckComplete2.Checked = True : Exit Sub
        If Value = "3" Then chk_CheckComplete3.Checked = True : Exit Sub
        If Value = "4" Then chk_CheckComplete4.Checked = True : Exit Sub
        If Value = "5" Then chk_CheckComplete5.Checked = True : Exit Sub
        If Value = "6" Then chk_CheckComplete6.Checked = True : Exit Sub
    End Sub

    Private Sub K4070_CheckComplete()
        W4070.CheckComplete = "1"
        If chk_CheckComplete1.Checked = True Then W4070.CheckComplete = "1" : Exit Sub
        If chk_CheckComplete2.Checked = True Then W4070.CheckComplete = "2" : Exit Sub
        If chk_CheckComplete3.Checked = True Then W4070.CheckComplete = "3" : Exit Sub
        If chk_CheckComplete4.Checked = True Then W4070.CheckComplete = "4" : Exit Sub
        If chk_CheckComplete5.Checked = True Then W4070.CheckComplete = "5" : Exit Sub
        If chk_CheckComplete6.Checked = True Then W4070.CheckComplete = "6" : Exit Sub
    End Sub

    Private Sub K4070_CheckProduction()
    End Sub

    Private Sub K4070_CheckProduction(Value As String)
    End Sub




    Private Function DATA_CHECKSTATUS() As Boolean
        DATA_CHECKSTATUS = False
        Try
            If READ_PFK4070(L4070.cdFactory, L4070.cdMainProcess, L4070.MachineCode, L4070.MachineTno) = True Then
                W4070 = D4070
                Call K4070_CheckComplete()
                W4070.ETimeProduction = System_Date_time()

                If REWRITE_PFK4070(W4070) = True Then
                    isudCHK = True
                    WRITE_CHK = "*"
                    DATA_CHECKSTATUS = True
                End If
            End If
        Catch ex As Exception
            MsgBoxP("DATA_CHECKSTATUS!")
        End Try
    End Function
    Private Sub KEY_COUNT_NO()
        Dim YRNO As Integer
        YRNO = Pub.DAT
    End Sub
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



#End Region




End Class