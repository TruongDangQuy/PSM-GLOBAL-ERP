Public Class ISUD3471P

#Region "Variable"
    Private wJOB As Integer


    Private W3471 As New T3471_AREA
    Private L3471 As New T3471_AREA

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
    Public Function Link_ISUD3471P(job As Integer, LiquidNo As String, LiquidSeq As String,
                                                     Optional ByVal TAG As String = "",
                                                     Optional ByVal Status1 As String = "1",
                                                     Optional ByVal Status2 As String = "1",
                                                     Optional ByVal Status3 As String = "1",
                                                     Optional ByVal Status4 As String = "1",
                                                     Optional ByVal Status5 As String = "1",
                                                     Optional ByVal Status6 As String = "1") As Boolean

        Me.Tag = TAG

        D3471.LiquidNo = LiquidNo
        D3471.LiquidSeq = LiquidSeq

        L_Status1 = Status1
        L_Status2 = Status2
        L_Status3 = Status3
        L_Status4 = Status4
        L_Status5 = Status5
        L_Status6 = Status6

        wJOB = job : L3471 = D3471

        Link_ISUD3471P = False

        Try

            formA = False
            Me.ShowDialog()
            Link_ISUD3471P = isudCHK

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Link_ISUD3471P"))
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

            If READ_PFK3471(L3471.LiquidNo, L3471.LiquidSeq) = False Then
                Exit Function
            End If

            L3471 = D3471

            K3471_CheckLiquidation(L3471.CheckLiquidation)

            If L3471.CheckLiquidation = "2" Then MsgBoxP("Completed already!") : cmd_OK.Visible = False : Exit Function

            If wJOB = 3 Then If Order_Check(L3471) = False Then MsgBoxP("Order had data already!") : Exit Function
            If wJOB = 4 Then If Order_Check_All(L3471) = False Then MsgBoxP("Order had data already!") : Exit Function

            APPROVAL_CHECK = True

        Catch ex As Exception
            Call MsgBoxP("APPROVAL_CHECK")
        End Try
    End Function

#End Region

#Region "Events"

    Private Function Order_Check(z3471 As T3471_AREA) As Boolean
        Order_Check = False
        Try



            Order_Check = True
        Catch ex As Exception
            Call MsgBoxP("Order_Check")
        End Try
    End Function
    Private Function Order_Check_All(z3471 As T3471_AREA) As Boolean
        Order_Check_All = False
        Try

           

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
    Private Sub K3471_CheckLiquidation(Process As String)
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
    Private Sub K3471_CheckLiquidation()
        If rad_CheckOrder1.Checked = True Then W3471.CheckLiquidation = "1"
        If rad_CheckOrder2.Checked = True Then W3471.CheckLiquidation = "2"
        If rad_CheckOrder3.Checked = True Then W3471.CheckLiquidation = "3"
        If rad_CheckOrder4.Checked = True Then W3471.CheckLiquidation = "4"
        If rad_CheckOrder5.Checked = True Then W3471.CheckLiquidation = "5"
        If rad_CheckOrder6.Checked = True Then W3471.CheckLiquidation = "6"
    End Sub


    Private Function DATA_UPDATE() As Boolean
        DATA_UPDATE = False
        Try
            If READ_PFK3471(L3471.LiquidNo, L3471.LiquidSeq) = True Then
                W3471 = D3471
                K3471_CheckLiquidation()

                If Data_Check() = False Then Exit Function

                D7558_CLEAR()
                D7558.TableName = "PFK3471"
                D7558.Parameter = L3471.LiquidNo + ";" + L3471.LiquidSeq
                D7558.FileName = "APPROVAL FROM MES SYSTEM"
                D7558.FileType = D3471.CheckLiquidation & "-" & W3471.CheckLiquidation
                D7558.TimeInsert = System_Date_time()
                D7558.DateInsert = Pub.DAT
                D7558.InchargeInsert = Pub.DAT

                Call WRITE_PFK7558(D7558)

                If W3471.CheckLiquidation = "4" Then
                    str = InputBox("Reason of canceled order ?")

                    Call PrcExeNoError("USP_ISUD3471P_UPDATE_CANCEL", cn, W3471.LiquidNo, W3471.LiquidSeq, str)

                End If

                If REWRITE_PFK3471(W3471) = True Then
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
        If W3471.CheckLiquidation = "1" Then
            'If READ_PFK1310_LiquidNo(W3471.LiquidNo, W3471.LiquidSeq) Then MsgBoxP("Already Packing Order Data !") : Exit Function
            'If READ_PFK3011_LiquidNo(W3471.LiquidNo, W3471.LiquidSeq) Then MsgBoxP("Already accept Order Trasnmit !--> Purchasing") : Exit Function

            Data_Check = True
        End If

        Data_Check = True
    End Function
    Private Function DATA_UPDATE_ALL() As Boolean
        DATA_UPDATE_ALL = False
        Try
            


            DATA_UPDATE_ALL = True
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE_ALL")
        End Try
    End Function

    Private Function Data_Check_ALL() As Boolean
        Data_Check_ALL = False
        Try

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
