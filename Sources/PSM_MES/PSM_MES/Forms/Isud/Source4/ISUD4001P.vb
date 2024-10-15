Public Class ISUD4001P

#Region "Variable"
    Private wJOB As Integer

    Private W4002 As T4002_AREA
    Private L4002 As T4002_AREA

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD4001P(job As Integer, WorkOrder As String, WorkOrderSeq As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D4002.WorkOrder = WorkOrder
        D4002.WorkOrderSeq = WorkOrderSeq
        wJOB = job : L4002 = D4002

        Link_ISUD4001P = False
        Try

            Select Case job
                Case 1
                Case Else
                    If READ_PFK4002(L4002.WorkOrder, L4002.WorkOrderSeq) = False Then
                        Call MsgBoxP("LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    Else
                        L4002 = D4002
                        If L4002.WorkOrderStatus = "2" Then
                            Enable_WorkOrderStatus(False, True, True, True, False)
                        Else
                            Enable_WorkOrderStatus(True, True, True, True, True)
                        End If
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD4001P = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
begin:
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Frame1.Enabled = True

                Call DATA_SEARCH01()

                If rad_WorkOrderStatus2.Checked = True Then
                    MsgBoxP("Already completed ! No editing!")
                End If

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
                        cmd_OK.Visible = False
                        GoTo Begin
                    End If
                End If

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False

        DS1 = READ_PFK4002(L4002.WorkOrder, L4002.WorkOrderSeq, cn)
        If GetDsRc(DS1) = 0 Then
            Exit Function : Me.Dispose()
            isudCHK = False
        End If

        Call K4002_WorkOrderStatus(GetDsData(DS1, 0, "K4002_WorkOrderStatus"))

        DATA_SEARCH01 = True

    End Function

#End Region
    Private Sub K4002_WorkOrderStatus(Process As String)
        Select Case Process
            Case "1" : rad_WorkOrderStatus1.Checked = True
            Case "2" : rad_WorkOrderStatus2.Checked = True
            Case "3" : rad_WorkOrderStatus3.Checked = True
            Case "4" : rad_WorkOrderStatus4.Checked = True
            Case "5" : rad_WorkOrderStatus5.Checked = True
            Case Else : rad_WorkOrderStatus1.Checked = True
        End Select
    End Sub
    Private Sub K4002_WorkOrderStatus()
        If rad_WorkOrderStatus1.Checked = True Then W4002.WorkOrderStatus = "1"
        If rad_WorkOrderStatus2.Checked = True Then W4002.WorkOrderStatus = "2"
        If rad_WorkOrderStatus3.Checked = True Then W4002.WorkOrderStatus = "3"
        If rad_WorkOrderStatus4.Checked = True Then W4002.WorkOrderStatus = "4"
        If rad_WorkOrderStatus5.Checked = True Then W4002.WorkOrderStatus = "5"
    End Sub
    Private Sub Enable_WorkOrderStatus(check1 As Boolean, check2 As Boolean, check3 As Boolean, check4 As Boolean, check5 As Boolean)
        rad_WorkOrderStatus1.Enabled = check1
        rad_WorkOrderStatus2.Enabled = check2
        rad_WorkOrderStatus3.Enabled = check3
        rad_WorkOrderStatus4.Enabled = check4
        rad_WorkOrderStatus5.Enabled = check5
    End Sub

    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK4002(L4002.WorkOrder, L4002.WorkOrderSeq) = True Then
                If D4002.WorkOrderStatus = "2" Then
                    If MsgBoxPPW("Please input password to edit !", const_pwPrintUpdate) = False Then Exit Function
                End If

                W4002 = D4002
                K4002_WorkOrderStatus()
                If REWRITE_PFK4002(W4002) = True Then

                    isudCHK = True
                    Me.Dispose()
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
            DS1 = READ_PFK4002_WORKORDER(L4002.WorkOrder, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK4002(RS01!K4002_WorkOrder, RS01!K4002_WorkOrderSeq) = True Then
                    W4002 = D4002
                    K4002_WorkOrderStatus()

                    If REWRITE_PFK4002(W4002) = True Then
                        isudCHK = True
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
            DS1 = READ_PFK4002_WORKORDER(L4002.WorkOrder, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK1312(RS01!K4002_WorkOrder, RS01!K4002_WorkOrderSeq) = True Then
                    W4002 = D4002
                    K4002_WorkOrderStatus()

                    If Data_Check() = False Then Exit Function

                End If
            Next

            Data_Check_ALL = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_ALL")
        End Try
    End Function

    Private Function Data_Check() As Boolean
        Data_Check = False
        If W4002.WorkOrderStatus = "1" Then

            If FormatCut(W4002.DateStitching) <> "" Then MsgBoxP("Stitching Accept Already!" & W4002.OrderNo & W4002.OrderNoSeq) : Exit Function

            If W4002.QtySole > 0 Then MsgBoxP("Qty Sole Already!" & W4002.OrderNo & W4002.OrderNoSeq) : Exit Function
            If W4002.QtyCutting > 0 Then MsgBoxP("Qty Cutting Already!" & W4002.OrderNo & W4002.OrderNoSeq) : Exit Function
            If W4002.QtyShipping > 0 Then MsgBoxP("Qty Shipping Already!" & W4002.OrderNo & W4002.OrderNoSeq) : Exit Function

            If W4002.QtyStitching > 0 Then MsgBoxP("Qty Stitching Already!" & W4002.OrderNo & W4002.OrderNoSeq) : Exit Function
            If W4002.QtyStockfit > 0 Then MsgBoxP("Qty Stockfit Already!" & W4002.OrderNo & W4002.OrderNoSeq) : Exit Function
            If W4002.QtyAssembly > 0 Then MsgBoxP("Qty Assembly Already!" & W4002.OrderNo & W4002.OrderNoSeq) : Exit Function

            Data_Check = True
        End If

        Data_Check = True
    End Function

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Try
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


End Class