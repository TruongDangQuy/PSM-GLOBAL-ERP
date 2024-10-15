Public Class ISUD3555A

#Region "Variable"
    Private wJOB As Integer

    Private W3550 As New T3550_AREA
    Private L3550 As New T3550_AREA

    Private W3551 As New T3551_AREA
    Private L3551 As New T3551_AREA

    Private W3555 As New T3555_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3555A(job As Integer, LABNo As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        L3550.LABNo = LABNo

        wJOB = job : L3550 = D3550 : L3551 = D3551

        Link_ISUD3555A = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK3550(L3550.LABNo) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L3550 = D3550
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3555A = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Request Order Processing"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_KeyDown()

        Call DATA_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"

                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()


            Case 2
                Me.Text = Me.Text & " - SEARCH"


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
                cmd_DEL.Visible = False

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
                        cmd_OK.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

            Case 4
                Me.Text = Me.Text & " - DELETE"

                cmd_OK.Visible = False


                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

            Case 5
                Me.Text = Me.Text & " - UPDATE AFTER"


                cmd_DEL.Visible = False

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
                        cmd_OK.Visible = False
                        Call Error_Message("16", "Form_Activate")
                    End If
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True

    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try
            Dim SQl = "SELECT * FORM PFK3550 WHERE K3550_LABNo = '" + L3550.LABNo + "' "

            DS1 = PrcDS(SQl, cn, Nothing)

            If GetDsRc(DS1) = 0 Then
                Exit Function
                isudCHK = False
            End If

            Call STORE_MOVE(Me, DS1)

            DATA_SEARCH01 = True
        Catch ex As Exception
            Call MsgBoxP("32", "DATA_SEARCH01")
        End Try
    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Try

            DS1 = PrcDS("USP_ISUD3550A_SEARCH_VS1", cn, L3550.LABNo)

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3550A_SEARCH_VS1", "Vs1")
                Vs1.ActiveSheet.RowCount = 10
                Vs1.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3550A_SEARCH_VS1", "Vs1")

            DATA_SEARCH_VS1 = True

        Catch ex As Exception
            Call MsgBoxP("32", "DATA_SEARCH_VS1")
        End Try

    End Function
#End Region

#Region "Function"
    Private Sub CheckTestStatus(TestStatus As String)
        Select Case TestStatus
            Case "1" : rad_TestStatus1.Checked = True
            Case "2" : rad_TestStatus2.Checked = True
            Case Else : rad_TestStatus1.Checked = True
        End Select
    End Sub

    
    Private Sub DATA_INSERT()

        Try
            If K3555_MOVE(Me, W3555, 1, W3555.LABNo, W3555.LABNoSeq) = True Then

                W3555.DateInspect = Pub.DAT
                W3555.TimeInspect = Pub.TIM

                If rad_TestStatus1.Checked = True Then W3555.TestStatus = "1"
                If rad_TestStatus1.Checked = True Then W3555.TestStatus = "2"

                If WRITE_PFK3555(W3555) = True Then

                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("34", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            If K3555_MOVE(Me, W3555, 1, W3555.LABNo, W3555.LABNoSeq) = True Then

                W3555.DateInspect = Pub.DAT
                W3555.TimeInspect = Pub.TIM

                If rad_TestStatus1.Checked = True Then W3555.TestStatus = "1"
                If rad_TestStatus1.Checked = True Then W3555.TestStatus = "2"

                If REWRITE_PFK3555(W3555) = True Then

                    isudCHK = True
                    Me.Dispose()
                End If
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            W3555.LABNo = txt_LABNo.Data
            W3555.LABNoSeq = txt_LABNoSeq.Data

            If READ_PFK3555(W3555.LABNo, W3555.LABNoSeq) = True Then
                If DELETE_PFK3555(W3555) = True Then
                    isudCHK = True
                    Me.Dispose()
                End If

            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub DATA_INIT()
        Try
            txt_TimeInspect.Data = Pub.TIM
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()

    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = True

        Try

        Catch ex As Exception
            Call MsgBoxP("32", "Data_Check")
        End Try
    End Function

#End Region

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If DataCheck(Me, "PFK3555") = False Then Exit Sub
                If Data_Check() = False Then Exit Sub
                Call DATA_INSERT()

            Case 2
                Me.Dispose()
            Case 3
                If DataCheck(Me, "PFK3555") = False Then Exit Sub
                If Data_Check = False Then Exit Sub

                Call DATA_UPDATE()
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


    Private Sub Vs1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellDoubleClick
        Try
            Dim xCOL As Long
            Dim xROW As Long
            Dim LABNo As String
            Dim LABNoSeq As String

            xCOL = Vs1.ActiveSheet.ActiveColumnIndex
            xROW = Vs1.ActiveSheet.ActiveRowIndex

            LABNo = getData(Vs1, getColumIndex(Vs1, "Key_LABNo"), xROW)
            LABNoSeq = getData(Vs1, getColumIndex(Vs1, "Key_LABNoSeq"), xROW)

            W3555.LABNo = LABNo
            W3555.LABNoSeq = LABNoSeq

            If READ_PFK3555(LABNo, LABNoSeq) = True Then
                txt_LABNo1.Data = D3555.LABNo
                txt_LABNoSeq.Data = D3555.LABNoSeq

                If D3555.TestStatus = "1" Then rad_TestStatus1.Checked = True
                If D3555.TestStatus = "2" Then rad_TestStatus2.Checked = True

                txt_TimeInspect.Data = D3555.TimeInspect
                txt_InchargeInspect.Code = D3555.InchargeInspect

                txt_QtyTest.Data = D3555.QtyTest
                txt_QtyPass.Data = D3555.QtyPass
                txt_QtyFail.Data = D3555.QtyFail

                txt_cdDefect01.Data = D3555.cdDefect01
                txt_cdDefect02.Data = D3555.cdDefect02
                txt_cdDefect03.Data = D3555.cdDefect03
                txt_cdDefect04.Data = D3555.cdDefect04
                txt_cdDefect05.Data = D3555.cdDefect05

                txt_Remark.Data = D3555.Remark

            Else
                If READ_PFK3551(LABNo, LABNoSeq) = True Then
                    txt_LABNo1.Data = D3551.LABNo
                    txt_LABNoSeq.Data = D3551.LABNoSeq

                    rad_TestStatus1.Checked = True

                    txt_TimeInspect.Data = Pub.TIM
                    txt_InchargeInspect.Code = Pub.SAW

                    txt_QtyTest.Data = D3551.QtyTest
                    txt_Remark.Data = D3551.Remark
                End If

            End If
        Catch ex As Exception
            Call MsgBoxP("30", "Vs1_CellClick")
        End Try

    End Sub

#End Region

End Class
