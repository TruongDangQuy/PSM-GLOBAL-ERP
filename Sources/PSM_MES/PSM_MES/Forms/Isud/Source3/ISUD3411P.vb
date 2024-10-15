Public Class ISUD3411P

#Region "Variable"
    Private wJOB As Integer

    Private W3411 As New T3411_AREA
    Private L3411 As New T3411_AREA

    Private W3412 As New T3412_AREA
    Private L3412 As New T3412_AREA

    Private pri_CustomerCode As String
    Private WRITE_CHK As String
    Private formA As Boolean

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3411P(job As Integer, PurchasingOrderNo As String, PurchasingOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Link_ISUD3411P = False

        Try
            Me.Tag = TAG
            wJOB = job

            If PurchasingOrderSeq = "" Then PurchasingOrderSeq = "1"

            D3412.PurchasingOrderNo = PurchasingOrderNo
            D3412.PurchasingOrderSeq = PurchasingOrderSeq

            If READ_PFK3411(PurchasingOrderNo) = False Then
                MsgBox("Error ==>> Try your actions again Data!")

                isudCHK = False
                formA = True
                Exit Function
            End If

            pri_CustomerCode = D3411.CustomerCode
            L3412 = D3412 : L3411 = D3411

            formA = False

            Me.ShowDialog()
            Link_ISUD3411P = isudCHK

        Catch ex As Exception
            '            Call MsgBoxP("61", WordConv("Return Grey Sales PROCESSING"))
        End Try
    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""

        Me.Text = Me.Text & " - UPDATE"
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(5) <> "1" Then
            isudCHK = False
            formA = True
            Me.Dispose()
            Call MsgBoxP("You have no right is this program !")
            Exit Sub
        End If

        If CheckData_Customer(pri_CustomerCode, ISUD.Approval) = False Then
            isudCHK = False
            formA = True
            Me.Dispose()
            MsgBoxP("No Correct Customer !")
            Exit Sub
        End If

        Frame1.Enabled = True

        If APPROVAL_CHECK() = False Then Call Block_Check()

        formA = True
    End Sub
    
#End Region

#Region "Search"
    Private Function APPROVAL_CHECK() As Boolean
        APPROVAL_CHECK = False

        If READ_PFK3412(L3412.PurchasingOrderNo, L3412.PurchasingOrderSeq) = False Then
            Exit Function
        End If

        L3412 = D3412

        K3412_CheckPurchasing(L3412.CheckPurchasing)

        If L3412.CheckPurchasing = "2" Then
            MsgBoxP("Completed already!")

            If MsgBoxPPW("Please type the password to un-complete!", const_pwCompleteRemove) = True Then
                GoTo step1
            End If

            cmd_OK.Visible = False : Exit Function
        End If



step1:

        If wJOB = 3 Then If Purchasing_Check(L3412) = False Then MsgBoxP("Purchasing had data already!") : Exit Function
        If wJOB = 4 Then If Purchasing_Check_All(L3412) = False Then MsgBoxP("Purchasing had data already!") : Exit Function

        APPROVAL_CHECK = True

    End Function

#End Region

#Region "Functions"
    Private Sub Block_Check()
        rad_CheckPurchasing1.Enabled = False
        rad_CheckPurchasing2.Enabled = True
        rad_CheckPurchasing3.Enabled = True
        rad_CheckPurchasing4.Enabled = True
        rad_CheckPurchasing5.Enabled = False
    End Sub
    Private Function Purchasing_Check(z3412 As T3412_AREA) As Boolean
        Purchasing_Check = False

        If z3412.QtyWarehouse > 0 Then Exit Function

        Purchasing_Check = True
    End Function
    Private Function Purchasing_Check_All(z3412 As T3412_AREA) As Boolean
        Purchasing_Check_All = False
        DS1 = READ_PFK3412_1(z3412.PurchasingOrderNo, cn)

        For Each RS01 As DataRow In DS1.Tables(0).Rows
            If READ_PFK3412(RS01!K3412_PurchasingOrderNo, RS01!K3412_PurchasingOrderSeq) = True Then
                W3412 = D3412
                If W3412.QtyWarehouse > 0 Then Exit Function
            End If
        Next

        Purchasing_Check_All = True
    End Function
    Private Sub K3412_CheckPurchasing(Process As String)
        Select Case Process
            Case "1" : rad_CheckPurchasing1.Checked = True
            Case "2" : rad_CheckPurchasing2.Checked = True
            Case "3" : rad_CheckPurchasing3.Checked = True
            Case "4" : rad_CheckPurchasing4.Checked = True
            Case "6" : rad_CheckPurchasing5.Checked = True
            Case Else : rad_CheckPurchasing1.Checked = True
        End Select
    End Sub
    Private Sub K3412_CheckPurchasing()
        If rad_CheckPurchasing1.Checked = True Then W3412.CheckPurchasing = "1"
        If rad_CheckPurchasing2.Checked = True Then W3412.CheckPurchasing = "2"
        If rad_CheckPurchasing3.Checked = True Then W3412.CheckPurchasing = "3"
        If rad_CheckPurchasing4.Checked = True Then W3412.CheckPurchasing = "4"
        If rad_CheckPurchasing5.Checked = True Then W3412.CheckPurchasing = "6"
    End Sub
    Private Sub Enable_CheckPurchasing(check1 As Boolean, check2 As Boolean, check3 As Boolean, check4 As Boolean, check5 As Boolean)
        rad_CheckPurchasing1.Enabled = check1
        rad_CheckPurchasing2.Enabled = check2
        rad_CheckPurchasing3.Enabled = check3
        rad_CheckPurchasing4.Enabled = check4
        rad_CheckPurchasing5.Enabled = check5
    End Sub

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK3412(L3412.PurchasingOrderNo, L3412.PurchasingOrderSeq) = True Then
                Dim int0 As Integer

                int0 = CIntp(PrcExeNoError_Value1("USP_PFK3411_APPROVAL_PFK3421_LINE", cn, L3412.PurchasingOrderNo, L3412.PurchasingOrderSeq))

                If int0 > 0 Then
                    If MsgBoxPPW("Đã có dự liệu phía sau (nhập kho). Nhập password để mở khóa !", const_pwCompleteRemove) = True Then
                        GoTo step1
                    Else
                        cmd_OK.Visible = False : Exit Function
                    End If
                End If


            End If
step1:

            If READ_PFK3412(L3412.PurchasingOrderNo, L3412.PurchasingOrderSeq) = True Then

                If READ_PFK3429_FactOrder(L3412.PurchasingOrderNo, L3412.PurchasingOrderSeq) = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Function
                End If

                W3412 = D3412
                K3412_CheckPurchasing()

                D7558_CLEAR()
                D7558.TableName = "PFK3412"
                D7558.Parameter = L3412.PurchasingOrderNo + ";" + L3412.PurchasingOrderSeq.ToString
                D7558.FileName = "APPROVAL FROM MES SYSTEM"
                D7558.FileType = D3412.CheckPurchasing & "-" & W3412.CheckPurchasing
                D7558.TimeInsert = System_Date_time()
                D7558.DateInsert = Pub.DAT
                D7558.InchargeInsert = Pub.DAT

                Call WRITE_PFK7558(D7558)

                If W3412.CheckPurchasing = "1" Then
                    If W3412.QtyWarehouse = 0 Then
                        If READ_PFK3422_DELETE(W3412.PurchasingOrderNo, W3412.PurchasingOrderSeq) Then
                            Call DELETE_PFK3422(D3422)
                        End If
                    End If
                End If

                If REWRITE_PFK3412(W3412) = True Then
                    isudCHK = True
                End If
            End If

            'Call PrcExeNoError("USP_PFK3411_APPROVAL_PFK3421", cn, L3412.PurchasingOrderNo)

            If READ_PFK3411(L3412.PurchasingOrderNo) Then

                If READ_PFK3429_FactOrder(L3412.PurchasingOrderNo, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Function
                End If


                If D3411.CheckInPurchasingOrder = "2" Then
                    Call PrcExeNoError("USP_PFK3411_APPROVAL_PFK3421_RETURN_PO_IOR", cn, L3412.PurchasingOrderNo)
                    Call PrcExeNoError("USP_PFK3411_APPROVAL_PFK3421_RETURN_PO_OOR", cn, L3412.PurchasingOrderNo)
                Else
                    Call PrcExeNoError("USP_PFK3411_APPROVAL_PFK3421", cn, L3412.PurchasingOrderNo)
                End If
            End If

            DATA_UPDATE = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function
    Private Function DATA_UPDATE_ALL() As Boolean
        DATA_UPDATE_ALL = False
        Try

            If READ_PFK3429_FactOrder(L3412.PurchasingOrderNo, "") = True Then
                MsgBox("Already make Payable can't modify !")
                Exit Function
            End If
            DS1 = READ_PFK3412_1(L3412.PurchasingOrderNo, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK3412(RS01!K3412_PurchasingOrderNo, RS01!K3412_PurchasingOrderSeq) = True Then
                    W3412 = D3412
                    K3412_CheckPurchasing()

                    D7558_CLEAR()
                    D7558.TableName = "PFK3412"
                    D7558.Parameter = L3412.PurchasingOrderNo + ";" + L3412.PurchasingOrderSeq.ToString
                    D7558.FileName = "APPROVAL FROM MES SYSTEM"
                    D7558.FileType = D3412.CheckPurchasing & "-" & W3412.CheckPurchasing
                    D7558.TimeInsert = System_Date_time()
                    D7558.DateInsert = Pub.DAT
                    D7558.InchargeInsert = Pub.DAT

                    Call WRITE_PFK7558(D7558)

                    If W3412.CheckPurchasing = "1" Then
                        If W3412.QtyWarehouse = 0 Then
                            If READ_PFK3422_DELETE(RS01!K3412_PurchasingOrderNo, RS01!K3412_PurchasingOrderSeq) Then
                                Call DELETE_PFK3422(D3422)
                            End If
                        End If
                    End If

                    If REWRITE_PFK3412(W3412) = True Then
                        isudCHK = True
                    End If
                End If
            Next
            '21/09/2016
            'If L3412.CheckPurchasing = "1" Then
            'Call MsgBoxP("Program will make Factory Inbound Request Automatically!", vbInformation)

            If READ_PFK3411(L3412.PurchasingOrderNo) Then

                If READ_PFK3429_FactOrder(L3412.PurchasingOrderNo, "") = True Then
                    MsgBox("Already make Payable can't modify !")
                    Exit Function
                End If

                If D3411.CheckInPurchasingOrder = "2" Then
                    Call PrcExeNoError("USP_PFK3411_APPROVAL_PFK3421_RETURN_PO_IOR", cn, L3412.PurchasingOrderNo)
                    Call PrcExeNoError("USP_PFK3411_APPROVAL_PFK3421_RETURN_PO_OOR", cn, L3412.PurchasingOrderNo)
                Else
                    Call PrcExeNoError("USP_PFK3411_APPROVAL_PFK3421", cn, L3412.PurchasingOrderNo)
                End If
            End If


            'End If

            DATA_UPDATE_ALL = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
            Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

            If CHK(5) <> "1" And rad_CheckPurchasing3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_CheckPurchasing2.Checked = True Then
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
