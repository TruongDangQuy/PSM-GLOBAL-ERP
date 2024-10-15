Imports System.Net.Mail
Imports System.Text
Imports System.IO.Ports

Public Class HLP0511A

#Region "Variable"
    Private wJOB As Integer

    Private W0511 As New T0511_AREA
    Private L0511 As New T0511_AREA

    Private W0512 As New T0512_AREA
    Private L0512 As New T0512_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_HLP0511A(job As Integer, SpecNo As String, SpecNoSeq As String) As Boolean
        Me.Tag = TAG

        D0511.SpecNo = SpecNo
        D0511.SpecNoSeq = SpecNoSeq

        wJOB = job : L0511 = D0511 : L0512 = D0512

        Link_HLP0511A = False
        Try
            formA = False


            Select Case job
                Case 1

                Case Else

            End Select

            Me.ShowDialog()

            Link_HLP0511A = hlpCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function


    Private CheckLink As Boolean = False
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""

        Call DATA_SEARCH_HEAD()
        Call DATA_SEARCH_HEAD_TAB1()
        Call DATA_SEARCH_vS0()
        Call DATA_SEARCH_vS1()

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Sub DATA_INIT()
        Try
            Me.WindowState = FormWindowState.Maximized

            txt_STimeProduction.Data = FSDateTime(System_Date_time)
            txt_ETimeProduction.Data = FSDateTime(System_Date_time)
            txt_DateProduction.Data = System_Date_8()

            txt_InchargeProdution.Data = Pub.NAM

            txt_DateProduction.Enabled = True
            txt_MachineCode.Enabled = True

        Catch ex As Exception
            Call MsgBoxP("DATA_INIT")
        End Try
    End Sub

    Private Sub FORM_INIT()
        RemoveHandler txt_ETimeProduction.txtTextKeyDown, AddressOf standard_KeyDown

        txt_ETimeProduction.PeaceTextbox1.EnterMoveNextControl = False

    End Sub
    Private Sub KEY_COUNT_CHANGE()
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)
        Try
            SQL = "SELECT MAX(CAST(RIGHT(K0511_MachineCode,2) AS DECIMAL)) AS MAX_MCODE FROM PFK0511 "
            SQL = SQL & " WHERE K0511_MachineCode = '" & L0511.MachineCode & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                MsgBoxP("They had been deleted already!")
                rd.Close()
                Me.Dispose()
                Exit Sub
            Else
                W0511.MachineCode = Strings.Left(L0511.MachineCode, 11) & Format(CInt(rd!MAX_MCODE + 1), "00")
            End If

            rd.Close()
            L0511.MachineCode = W0511.MachineCode
            'txt_MachineCode.Data = W0511.MachineCode

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub KEY_COUNT()
        Dim YRNO As Integer
        YRNO = Mid(System_Date_8(), 3, 4)
        Try
            SQL = "SELECT MAX(CAST(K0511_ProdSeq AS DECIMAL)) AS MAX_MCODE FROM PFK0511 "
            SQL = SQL & " WHERE K0511_ProdDate = '" & L0511.ProdDate & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()

            If IsDBNull(rd!MAX_MCODE) Then
                L0511.ProdSeq = "00001"
            Else
                L0511.ProdSeq = CInt(rd!MAX_MCODE + 1).ToString("00000")
            End If

            rd.Close()
            W0511.ProdSeq = L0511.ProdSeq

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False
        Try

            DS1 = READ_PFK0511(L0511.ProdDate, L0511.ProdSeq, cn)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            READER_MOVE(Me, DS1)

            Call K0511_PartProduction(GetDsData(DS1, 0, "K0511_PartProduction"))

            L0511.SpecNo = GetDsData(DS1, 0, "K0511_SpecNo")
            L0511.SpecNoSeq = GetDsData(DS1, 0, "K0511_SpecNoSeq")

            txt_cdSpecNoSeq.Data = L0511.SpecNo & L0511.SpecNoSeq

            DATA_SEARCH_HEAD = True

            If READ_PFK7155(GetDsData(DS1, 0, "K0511_MachineCode")) = True Then
                txt_MachineCode.Data = D7155.MachineName
                txt_MachineCode.Code = D7155.MachineCode
            End If

            txt_STimeProduction.Data = FSDateTime(txt_STimeProduction.Data)
            txt_ETimeProduction.Data = FSDateTime(txt_ETimeProduction.Data)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function
    Private Function DATA_SEARCH_HEAD_TAB1() As Boolean
        DATA_SEARCH_HEAD_TAB1 = False
        Try
            DS1 = PrcDS("USP_HLP0511A_SEARCH_HEAD", cn, L0511.SpecNo, L0511.SpecNoSeq)

            If GetDsRc(DS1) = 0 Then
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_vS0() As Boolean
        DATA_SEARCH_vS0 = False
        Try
            DS1 = PrcDS("USP_HLP0511A_SEARCH_vS0", cn, L0511.SpecNo, L0511.SpecNoSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS0, , , , OperationMode.SingleSelect)
                SPR_PRO(vS0, DS1, "USP_HLP0511A_SEARCH_vS0", "vS0")
                vS0.Enabled = True
                Exit Function
            End If

            SPR_SET(vS0, , , , OperationMode.SingleSelect)
            SPR_PRO(vS0, DS1, "USP_HLP0511A_SEARCH_vS0", "vS0")
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_vS1() As Boolean
        DATA_SEARCH_vS1 = False
        Try
            DS1 = PrcDS("USP_HLP0511A_SEARCH_VS1", cn, L0511.ProdDate, L0511.ProdSeq)

            If GetDsRc(DS1) = 0 Then
                SPR_SET(vS1, , , , OperationMode.SingleSelect)
                SPR_PRO(vS1, DS1, "USP_HLP0511A_SEARCH_VS1", "vs1")
                vS1.Enabled = True
                Exit Function
            End If

            SPR_SET(vS1, , , , OperationMode.SingleSelect)
            SPR_PRO(vS1, DS1, "USP_HLP0511A_SEARCH_VS1", "vs1")
            Call VsSizeRangeNew(vS1, "USP_VS_SIZERANGE_ITEMBASE", "SizeQty01", L0511.SpecNo)


        Catch ex As Exception
            MsgBoxP("DATA_SEARCH01")
        End Try
    End Function


    Private Function DATA_DELETE() As Boolean
        DATA_DELETE = False
        Try
            If READ_PFK0511(L0511.ProdDate, L0511.ProdSeq) = True Then
                W0511 = D0511
                If DELETE_PFK0511(W0511) = True Then
                    HLPCHK = True
                    DATA_DELETE = True
                End If
            End If


        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function


    Private Function CheckItemCode(ItemCode As String) As Boolean
        CheckItemCode = False
        Try

        Catch ex As Exception
            MsgBoxP("CheckItemCode")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False

        Try
            txt_cdSpecNoSeq.Data = FormatCut(txt_cdSpecNoSeq.Data)

            If Len(txt_cdSpecNoSeq.Data) <> 12 Then txt_cdSpecNoSeq.Data = "" : Setfocus(txt_cdSpecNoSeq) : Exit Function

            L0511.SpecNo = Strings.Left(txt_cdSpecNoSeq.Data, 9)
            L0511.SpecNoSeq = Strings.Right(txt_cdSpecNoSeq.Data, 3)

            DS1 = PrcDS("USP_HLP0511A_SEARCH_HEAD", cn, L0511.SpecNo, L0511.SpecNoSeq)

            If GetDsRc(DS1) = 0 Then
                txt_cdSpecNoSeq.Data = ""
                MsgBoxP("No data. Check, please!")
                Setfocus(txt_cdSpecNoSeq)
                Exit Function
            End If

            STORE_MOVE(Me, DS1)

            DATA_SEARCH_VS1_INSERT = True
        Catch ex As Exception
            MsgBoxP("DATA_SEARCH_VS1")
        End Try
    End Function




    Private Sub K0511_PartProduction()
        W0511.PartProduction = "1"
        If rad_PartProduction1.Checked = True Then W0511.PartProduction = "1" : Exit Sub
        If rad_PartProduction2.Checked = True Then W0511.PartProduction = "2" : Exit Sub
        If rad_PartProduction3.Checked = True Then W0511.PartProduction = "3" : Exit Sub
    End Sub

    Private Sub K0511_PartProduction(Value As String)
        rad_PartProduction1.Checked = True
        If Value = "1" Then rad_PartProduction1.Checked = True : Exit Sub
        If Value = "2" Then rad_PartProduction2.Checked = True : Exit Sub
        If Value = "3" Then rad_PartProduction3.Checked = True : Exit Sub
    End Sub


    Private Function DATA_INSERT_UPDATE() As Boolean
        DATA_INSERT_UPDATE = False
        Try

        Catch ex As Exception
            MsgBoxP("DATA_MOVE!")
        End Try
    End Function

#End Region

#Region "Event"

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        If WRITE_CHK = "*" Then
            HLPCHK = True
        Else
            HLPCHK = False
        End If

        Me.Dispose()
    End Sub



    Private Sub vS0_CellClick(sender As Object, e As CellClickEventArgs) Handles vS0.CellClick
        Dim KEY_ProdDate As String
        Dim KEY_ProdSeq As String

        KEY_ProdDate = getData(vS0, getColumIndex(vS0, "KEY_ProdDate"), e.Row)
        KEY_ProdSeq = getData(vS0, getColumIndex(vS0, "KEY_ProdSeq"), e.Row)

        If FormatCut(KEY_ProdDate) = "" Then vS1.ActiveSheet.RowCount = 0 : Exit Sub
        L0511.ProdDate = KEY_ProdDate
        L0511.ProdSeq = KEY_ProdSeq

        L0512.ProdDate = KEY_ProdDate
        L0512.ProdSeq = KEY_ProdSeq

        wJOB = 3

        Call DATA_SEARCH_HEAD()
        Call DATA_SEARCH_HEAD_TAB1()
        Call DATA_SEARCH_vS0()
        Call DATA_SEARCH_vS1()

    End Sub

#End Region

End Class