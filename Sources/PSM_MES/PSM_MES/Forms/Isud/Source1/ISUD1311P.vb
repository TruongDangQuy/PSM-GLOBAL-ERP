Public Class ISUD1311P

#Region "Variable"
    Private wJOB As Integer

    Private W1311 As New T1311_AREA
    Private L1311 As New T1311_AREA

    Private W1312 As New T1312_AREA
    Private L1312 As New T1312_AREA

    Private L_Status1 As String
    Private L_Status2 As String
    Private L_Status3 As String
    Private L_Status4 As String
    Private L_Status5 As String
    Private L_Status6 As String


    Private WRITE_CHK As String
    Private formA As Boolean

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD1311P(job As Integer, OrderNo As String, OrderNoSeq As String,
                                                     Optional ByVal TAG As String = "",
                                                     Optional ByVal Status1 As String = "1",
                                                     Optional ByVal Status2 As String = "1",
                                                     Optional ByVal Status3 As String = "1",
                                                     Optional ByVal Status4 As String = "1",
                                                     Optional ByVal Status5 As String = "1",
                                                     Optional ByVal Status6 As String = "1") As Boolean

        Me.Tag = TAG

        D1312.OrderNo = OrderNo
        D1312.OrderNoSeq = OrderNoSeq

        L_Status1 = Status1
        L_Status2 = Status2
        L_Status3 = Status3
        L_Status4 = Status4
        L_Status5 = Status5
        L_Status6 = Status6

        wJOB = job : L1312 = D1312

        Link_ISUD1311P = False

        Try

            formA = False
            Me.ShowDialog()
            Link_ISUD1311P = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD1311P"))
        End Try
    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))
        Me.Text = Me.Text & " - UPDATE"
        Frame1.Enabled = True

        If CHK(3) <> "1" And CHK(5) <> "1" Then
            If CHK(2) <> "1" Then
                isudCHK = False
                formA = True
                Me.Dispose()
                Call MsgBoxP("You have no right is this program !")
                Exit Sub
            Else
                Me.Text = Me.Text & " - SEARCH"
                isudCHK = False
                formA = True
                wJOB = 2
                cmd_OK.Visible = False
                Call Error_Message("16", "Form_Activate")
            End If
        End If

        If APPROVAL_CHECK() = False Then
            rad_CheckOrder1.Enabled = False
            rad_CheckOrder2.Enabled = False
            rad_CheckOrder3.Enabled = False
            rad_CheckOrder4.Enabled = False
            rad_CheckOrder5.Enabled = False
            'Crad_CheckOrder4.Enabled = Falseall APPROVAL_CHECK()
            'Crad_CheckOrder5.Enabled = Falseall Block_Check()
            rad_CheckOrder6.Enabled = False
            formA = True
        End If

        Call Block_Check()

    End Sub


#End Region

#Region "Search"
    Private Function APPROVAL_CHECK() As Boolean
        APPROVAL_CHECK = False
        Try

            If READ_PFK1312(L1312.OrderNo, L1312.OrderNoSeq) = False Then
                Exit Function
            End If

            L1312 = D1312

            K1312_OrderDetailStatus(L1312.OrderDetailStatus)

            If L1312.OrderDetailStatus = "2" Then
                MsgBoxP("Completed already!")

                If MsgBoxPPW("Please type the password to un-complete!", const_pwCompleteRemove) = True Then
                    GoTo step1
                End If

                cmd_OK.Visible = False : Exit Function


            End If

step1:

            If wJOB = 3 Then If Order_Check(L1312) = False Then MsgBoxP("Order had data already!") : Exit Function
            If wJOB = 4 Then If Order_Check_All(L1312) = False Then MsgBoxP("Order had data already!") : Exit Function

            APPROVAL_CHECK = True

        Catch ex As Exception
            Call MsgBoxP("APPROVAL_CHECK")
        End Try
    End Function

#End Region

#Region "Events"

    Private Function Order_Check(z1312 As T1312_AREA) As Boolean
        Order_Check = False
        Try



            Order_Check = True
        Catch ex As Exception
            Call MsgBoxP("Order_Check")
        End Try
    End Function
    Private Function Order_Check_All(z1312 As T1312_AREA) As Boolean
        Order_Check_All = False
        Try

            DS1 = READ_PFK1312_ORDERNO(z1312.OrderNo, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows
                If READ_PFK1312(RS01!K1312_OrderNo, RS01!K1312_OrderNoSeq) = True Then
                    W1312 = D1312
                    'If W1312.QtyWarehouse > 0 Then Exit Function
                End If
            Next

            Order_Check_All = True

        Catch ex As Exception
            Call MsgBoxP("Order_Check_All")
        End Try
    End Function
    Private Sub Block_Check()
        If L_Status1 = "1" Then rad_CheckOrder1.Enabled = True Else rad_CheckOrder1.Enabled = False
        If L_Status2 = "1" Then rad_CheckOrder2.Enabled = True Else rad_CheckOrder2.Enabled = False
        If L_Status3 = "1" Then rad_CheckOrder3.Enabled = True Else rad_CheckOrder3.Enabled = False
        If L_Status4 = "1" Then rad_CheckOrder4.Enabled = True Else rad_CheckOrder4.Enabled = False
        If L_Status5 = "1" Then rad_CheckOrder5.Enabled = True Else rad_CheckOrder5.Enabled = False
        If L_Status6 = "1" Then rad_CheckOrder6.Enabled = True Else rad_CheckOrder6.Enabled = False
    End Sub
    Private Sub K1312_OrderDetailStatus(Process As String)
        Select Case Process
            Case "1" : rad_CheckOrder1.Checked = True
            Case "2" : rad_CheckOrder2.Checked = True
            Case "3" : rad_CheckOrder3.Checked = True
            Case "4" : rad_CheckOrder4.Checked = True
            Case "5" : rad_CheckOrder5.Checked = True
            Case "6" : rad_CheckOrder6.Checked = True
            Case Else : rad_CheckOrder1.Checked = True
        End Select
    End Sub
    Private Sub K1312_OrderDetailStatus()
        If rad_CheckOrder1.Checked = True Then W1312.OrderDetailStatus = "1"
        If rad_CheckOrder2.Checked = True Then W1312.OrderDetailStatus = "2" : W1312.DateComplete = Pub.DAT
        If rad_CheckOrder3.Checked = True Then W1312.OrderDetailStatus = "3" : W1312.DateApproval = Pub.DAT
        If rad_CheckOrder4.Checked = True Then W1312.OrderDetailStatus = "4" : W1312.DateCancel = Pub.DAT
        If rad_CheckOrder5.Checked = True Then W1312.OrderDetailStatus = "5" : W1312.DatePending = Pub.DAT
        If rad_CheckOrder6.Checked = True Then W1312.OrderDetailStatus = "6" : W1312.DatePending2 = Pub.DAT
    End Sub


    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK1312(L1312.OrderNo, L1312.OrderNoSeq) = True Then
                W1312 = D1312
                K1312_OrderDetailStatus()

                If Data_Check() = False Then Exit Function

                D7558_CLEAR()
                D7558.TableName = "PFK1312"
                D7558.Parameter = L1312.OrderNo + ";" + L1312.OrderNoSeq
                D7558.FileName = "APPROVAL FROM MES SYSTEM"
                D7558.FileType = D1312.OrderDetailStatus & "-" & W1312.OrderDetailStatus
                D7558.TimeInsert = System_Date_time()
                D7558.DateInsert = Pub.DAT
                D7558.InchargeInsert = Pub.DAT

                Call WRITE_PFK7558(D7558)

                If W1312.OrderDetailStatus = "4" Then
                    str = InputBox("Reason of canceled order ?")

                    Call PrcExeNoError("USP_ISUD1311P_UPDATE_CANCEL", cn, W1312.OrderNo, W1312.OrderNoSeq, str)

                End If

                If REWRITE_PFK1312(W1312) = True Then
                    isudCHK = True
                End If
            End If

            DATA_UPDATE = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function

    Private CheckF As Boolean = False
    Private Function Data_Check() As Boolean
        Data_Check = False
        If W1312.OrderDetailStatus = "1" Then
            If READ_PFK1310_ORDERNO(W1312.OrderNo, W1312.OrderNoSeq) Then MsgBoxP("Already Packing Order Data !") : Exit Function
            If READ_PFK3011_ORDERNO(W1312.OrderNo, W1312.OrderNoSeq) Then MsgBoxP("Already accept Order Trasnmit !--> Purchasing") : Exit Function

            Data_Check = True
        End If

        Data_Check = True
    End Function
    Private Function DATA_UPDATE_ALL() As Boolean
        DATA_UPDATE_ALL = False
        Try
            DS1 = READ_PFK1312_ORDERNO(L1312.OrderNo, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK1312(RS01!K1312_OrderNo, RS01!K1312_OrderNoSeq) = True Then
                    W1312 = D1312
                    K1312_OrderDetailStatus()

                    D7558_CLEAR()
                    D7558.TableName = "PFK1312"
                    D7558.Parameter = L1312.OrderNo + ";" + L1312.OrderNoSeq
                    D7558.FileName = "APPROVAL FROM MES SYSTEM"
                    D7558.FileType = D1312.OrderDetailStatus & "-" & W1312.OrderDetailStatus
                    D7558.TimeInsert = System_Date_time()
                    D7558.DateInsert = Pub.DAT
                    D7558.InchargeInsert = Pub.DAT

                    Call WRITE_PFK7558(D7558)

                    If REWRITE_PFK1312(W1312) = True Then

                    End If
                End If
            Next

            DATA_UPDATE_ALL = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_ALL")
        End Try
    End Function

    Private Function Data_Check_ALL() As Boolean
        Data_Check_ALL = False
        Try
            DS1 = READ_PFK1312_ORDERNO(L1312.OrderNo, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK1312(RS01!K1312_OrderNo, RS01!K1312_OrderNoSeq) = True Then
                    W1312 = D1312
                    K1312_OrderDetailStatus()

                    If Data_Check() = False Then Exit Function
                   
                End If
            Next

            Data_Check_ALL = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_ALL")
        End Try
    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

            If CHK(5) <> "1" And rad_CheckOrder3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_CheckOrder2.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            Select Case wJOB
                Case "3"
                    If DATA_UPDATE() = True Then
                        isudCHK = True
                        Me.Dispose()
                    End If

                Case "4"
                    If Data_Check_ALL() = False Then Exit Sub

                    If DATA_UPDATE_ALL() = True Then
                        isudCHK = True
                        Me.Dispose()
                    End If
            End Select

        Catch ex As Exception
            MsgBoxP("Error!")
            Me.Dispose()
        End Try

    End Sub

    Private Sub cmd_Cancel_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub

#End Region

End Class
