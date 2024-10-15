Public Class ISUD3011P

#Region "Variable"
    Private wJOB As Integer

    Private W3011 As New T3011_AREA
    Private L3011 As New T3011_AREA

    Private WRITE_CHK As String
    Private formA As Boolean

    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3011P(job As Integer, PRNO As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG

        D3011.PRNO = PRNO

        wJOB = job : L3011 = D3011

        Link_ISUD3011P = False

        Try

            formA = False
            Me.ShowDialog()

            Link_ISUD3011P = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("Return Grey Sales PROCESSING"))
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
    
#End Region

#Region "Search"
    Private Function APPROVAL_CHECK() As Boolean
        APPROVAL_CHECK = False

        If READ_PFK3011_1(L3011.PRNo) = False Then
            Exit Function
        End If

        L3011 = D3011

        K3011_CheckOrderMaterial(L3011.CheckOrderMaterial)

        If Purchasing_Check_All(L3011) = False Then MsgBoxP("Purchasing had data already!") : Exit Function

        APPROVAL_CHECK = True

    End Function

#End Region

#Region "Functions"
    Private Sub Block_Check()
        rad_CheckOrderMaterial1.Enabled = False
        rad_CheckOrderMaterial2.Enabled = True
        rad_CheckOrderMaterial3.Enabled = True
        rad_CheckOrderMaterial4.Enabled = True
        rad_CheckOrderMaterial5.Enabled = False
    End Sub
    Private Function Purchasing_Check(z3011 As T3011_AREA) As Boolean
        Purchasing_Check = False

        If z3011.QtyPurchasing > 0 Then Exit Function

        Purchasing_Check = True
    End Function
    Private Function Purchasing_Check_All(z3011 As T3011_AREA) As Boolean
        Purchasing_Check_All = False
        DS1 = READ_PFK3011_1(z3011.PRNO, cn)

        For Each RS01 As DataRow In DS1.Tables(0).Rows
            If READ_PFK3011(RS01!K3011_Autokey) = True Then
                W3011 = D3011
                If W3011.QtyPurchasing > 0 Then Exit Function
            End If
        Next

        Purchasing_Check_All = True
    End Function
    Private Sub K3011_CheckOrderMaterial(Process As String)
        Select Case Process
            Case "1" : rad_CheckOrderMaterial1.Checked = True
            Case "2" : rad_CheckOrderMaterial2.Checked = True
            Case "3" : rad_CheckOrderMaterial3.Checked = True
            Case "4" : rad_CheckOrderMaterial4.Checked = True
            Case "6" : rad_CheckOrderMaterial5.Checked = True
            Case Else : rad_CheckOrderMaterial1.Checked = True
        End Select
    End Sub
    Private Sub K3011_CheckOrderMaterial()
        If rad_CheckOrderMaterial1.Checked = True Then W3011.CheckOrderMaterial = "1"
        If rad_CheckOrderMaterial2.Checked = True Then W3011.CheckOrderMaterial = "2" : W3011.DateOrderMaterialComplete = Pub.DAT
        If rad_CheckOrderMaterial3.Checked = True Then W3011.CheckOrderMaterial = "3" : W3011.DateOrderMaterialApproval = Pub.DAT
        If rad_CheckOrderMaterial4.Checked = True Then W3011.CheckOrderMaterial = "4" : W3011.DateOrderMaterialCancel = Pub.DAT
        If rad_CheckOrderMaterial5.Checked = True Then W3011.CheckOrderMaterial = "6"
    End Sub
    Private Sub Enable_CheckOrderMaterial(check1 As Boolean, check2 As Boolean, check3 As Boolean, check4 As Boolean, check5 As Boolean)
        rad_CheckOrderMaterial1.Enabled = check1
        rad_CheckOrderMaterial2.Enabled = check2
        rad_CheckOrderMaterial3.Enabled = check3
        rad_CheckOrderMaterial4.Enabled = check4
        rad_CheckOrderMaterial5.Enabled = check5
    End Sub

    Private Function DATA_UPDATE_ALL() As Boolean
        DATA_UPDATE_ALL = False
        Try
            DS1 = READ_PFK3011_1(L3011.PRNO, cn)

            For Each RS01 As DataRow In DS1.Tables(0).Rows

                If READ_PFK3011(RS01!K3011_Autokey) = True Then
                    W3011 = D3011
                    K3011_CheckOrderMaterial()
                    If REWRITE_PFK3011(W3011) = True Then
                        isudCHK = True
                    End If
                End If

            Next

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

            If CHK(5) <> "1" And rad_CheckOrderMaterial3.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If

            If CHK(5) <> "1" And rad_CheckOrderMaterial2.Checked = True Then
                Call MsgBoxP("No right to update this!")
                Exit Sub
            End If


            If DATA_UPDATE_ALL() = True Then
                isudCHK = True
                Me.Dispose()
            End If

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
