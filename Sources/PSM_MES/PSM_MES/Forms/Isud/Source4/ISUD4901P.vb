Public Class ISUD4901P

#Region "Variable"
    Private wJOB As Integer

    Private W4901 As New T4901_AREA
    Private L4901 As New T4901_AREA

    Private W4902 As New T4902_AREA
    Private L4902 As New T4902_AREA

    Private WRITE_CHK As String
    Private formA As Boolean

    Private CHK(0 To 5) As String
#End Region


#Region "Link"
    Public Function Link_ISUD4901P(job As Integer, ShippingWorkOrder As String, ShippingWorkOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D4902.ShippingWorkOrder = ShippingWorkOrder
        D4902.ShippingWorkOrderSeq = ShippingWorkOrderSeq

        wJOB = job : L4902 = D4902

        Link_ISUD4901P = False

        Try

            formA = False
            Me.ShowDialog()
            Link_ISUD4901P = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD4901P"))
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

        If APPROVAL_CHECK() = False Then Call Block_Check()

        formA = True
    End Sub
    Private Sub Block_Check()
        rad_CheckOrder1.Enabled = False
        rad_CheckOrder2.Enabled = True
        rad_CheckOrder3.Enabled = True
        rad_CheckOrder4.Enabled = True
        rad_CheckOrder5.Enabled = False
    End Sub
#End Region

#Region "Search"
    Private Function APPROVAL_CHECK() As Boolean
        APPROVAL_CHECK = False
        Try

            If READ_PFK4902(L4902.ShippingWorkOrder, L4902.ShippingWorkOrderSeq) = False Then
                Exit Function
            End If

            L4902 = D4902

            K4902_CheckOrder(L4902.ShippingWorkOrderStatus)

            If wJOB = 3 Then If Order_Check(L4902) = False Then MsgBoxP("Order had data already!") : Exit Function
            If wJOB = 4 Then If Order_Check_All(L4902) = False Then MsgBoxP("Order had data already!") : Exit Function

            APPROVAL_CHECK = True

        Catch ex As Exception
            Call MsgBoxP("APPROVAL_CHECK")
        End Try
    End Function

#End Region

#Region "Events"

    Private Function Order_Check(z4902 As T4902_AREA) As Boolean
        Order_Check = False
        Try
            ' If z4902.qty > 0 Then Exit Function

            Order_Check = True
        Catch ex As Exception
            Call MsgBoxP("Order_Check")
        End Try
    End Function
    Private Function Order_Check_All(z4902 As T4902_AREA) As Boolean
        Order_Check_All = False
        Try

            DS1 = READ_PFK4902_ShippingWorkOrder(z4902.ShippingWorkOrder, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows
                If READ_PFK4902(RS01!K4902_ShippingWorkOrder, RS01!K4902_ShippingWorkOrderSeq) = True Then
                    W4902 = D4902
                    'If W4902.QtyWarehouse > 0 Then Exit Function
                End If
            Next

            Order_Check_All = True

        Catch ex As Exception
            Call MsgBoxP("Order_Check_All")
        End Try
    End Function
    Private Sub K4902_CheckOrder(Process As String)
        Select Case Process
            Case "1" : rad_CheckOrder1.Checked = True
            Case "2" : rad_CheckOrder2.Checked = True
            Case "3" : rad_CheckOrder3.Checked = True
            Case "4" : rad_CheckOrder4.Checked = True
            Case "5" : rad_CheckOrder5.Checked = True
            Case Else : rad_CheckOrder1.Checked = True
        End Select
    End Sub
    Private Sub K4902_CheckOrder()
        If rad_CheckOrder1.Checked = True Then W4902.ShippingWorkOrderStatus = "1"
        If rad_CheckOrder2.Checked = True Then W4902.ShippingWorkOrderStatus = "2" : W4902.DateComplete = Pub.DAT
        If rad_CheckOrder3.Checked = True Then W4902.ShippingWorkOrderStatus = "3" : W4902.DateApproval = Pub.DAT
        If rad_CheckOrder4.Checked = True Then W4902.ShippingWorkOrderStatus = "4" : W4902.DateCancel = Pub.DAT
        If rad_CheckOrder5.Checked = True Then W4902.ShippingWorkOrderStatus = "5" : W4902.DatePending = Pub.DAT
    End Sub
    Private Sub Enable_CheckOrder(check1 As Boolean, check2 As Boolean, check3 As Boolean, check4 As Boolean, check5 As Boolean)
        rad_CheckOrder1.Enabled = check1
        rad_CheckOrder2.Enabled = check2
        rad_CheckOrder3.Enabled = check3
        rad_CheckOrder4.Enabled = check4
        rad_CheckOrder5.Enabled = check5
    End Sub

    Private Function Data_Check() As Boolean
        Data_Check = False
        If W4902.ShippingWorkOrderStatus = "1" Then

            If W4902.QtyOutbound > 0 Then MsgBoxP("Qty Outbound Already!" & W4902.ShippingWorkOrder & W4902.ShippingWorkOrderSeq) : Exit Function
            Data_Check = True
        End If

        Data_Check = True
    End Function

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK4902(L4902.ShippingWorkOrder, L4902.ShippingWorkOrderSeq) = True Then
                W4902 = D4902
                K4902_CheckOrder()

                  If Data_Check() = False Then Exit Function

                If W4902.ShippingWorkOrderStatus = "3" Then
                    Call PrcExeNoError("USP_PFK4901_APPROVAL_PFK3451_ALL", cn, L4902.ShippingWorkOrder)
                    Call PrcExeNoError("USP_PFK4901_APPROVAL_PFK2456_ALL", cn, L4902.ShippingWorkOrder)
                End If

                If W4902.ShippingWorkOrderStatus = "1" Then
                    Call PrcExeNoError("USP_PFK4901_DELETE_PFK3451_LINE", cn, W4902.ShippingWorkOrder, W4902.ShippingWorkOrderSeq)
                End If

                If REWRITE_PFK4902(W4902) = True Then
                    isudCHK = True
                End If
            End If



            DATA_UPDATE = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Function

    Private Function Data_Check_ALL() As Boolean
        Data_Check_ALL = False
        Try
            DS1 = READ_PFK4902_ShippingWorkOrder(L4902.ShippingWorkOrder, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK4902(RS01!K4902_ShippingWorkOrder, RS01!K4902_ShippingWorkOrderSeq) = True Then
                    W4902 = D4902
                    K4902_CheckOrder()

                    If Data_Check() = False Then Exit Function
                End If
            Next

            Data_Check_ALL = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_ALL")
        End Try
    End Function
    Private Function DATA_UPDATE_ALL() As Boolean
        DATA_UPDATE_ALL = False
        Try
            DS1 = READ_PFK4902_ShippingWorkOrder(L4902.ShippingWorkOrder, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK4902(RS01!K4902_ShippingWorkOrder, RS01!K4902_ShippingWorkOrderSeq) = True Then
                    W4902 = D4902
                    K4902_CheckOrder()

                    If W4902.ShippingWorkOrderStatus = "3" Then
                        Call PrcExeNoError("USP_PFK4901_APPROVAL_PFK3451_ALL", cn, L4902.ShippingWorkOrder)
                        Call PrcExeNoError("USP_PFK4901_APPROVAL_PFK2456_ALL", cn, L4902.ShippingWorkOrder)

                    End If

                    If W4902.ShippingWorkOrderStatus = "1" Then
                        Call PrcExeNoError("USP_PFK4901_DELETE_PFK3451_LINE", cn, W4902.ShippingWorkOrder, W4902.ShippingWorkOrderSeq)
                    End If

                    If REWRITE_PFK4902(W4902) = True Then
                        isudCHK = True
                    End If
                End If
            Next

            'Call PrcExeNoError("USP_PFK4901_APPROVAL_PFK3451_ALL", cn, L4902.ShippingWorkOrder)

            DATA_UPDATE_ALL = True
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
