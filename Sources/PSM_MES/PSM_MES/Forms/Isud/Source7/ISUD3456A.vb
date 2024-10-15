Public Class ISUD3456A
#Region "Variable"
    Private wJOB As Integer

    Private W3452 As T3452_AREA
    Private L3452 As T3452_AREA

    Private W3456 As T3456_AREA
    Private L3456 As T3456_AREA

    Private WRITE_CHK As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD3456A(job As Integer, Autokey_PFK3452 As String, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        D3452.Autokey = Autokey_PFK3452

        If job = "1" Then
            D3452.Autokey = 0
        End If


        wJOB = job : L3452 = D3452

        Link_ISUD3456A = False
        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK3452(Autokey_PFK3452) = False Then
                        Call MsgBoxP("You have no right is this ShoesCode !")
                        Me.Dispose()

                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD3456A = isudCHK


        Catch ex As Exception
            '       Call MsgBoxP("61", WordConv("Autokey_PFK3452"))
        End Try


    End Function
#End Region

#Region "Form"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""
        Me.Form_Initial()
        Me.Form_KeyDown()

        Call DATA_INIT()
        Call FORM_INIT()

        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        Select Case wJOB
            Case 1
                Me.Text = Me.Text & " - INSERT"
                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call KEY_COUNT()
                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                cmd_DEL.Visible = False

                Setfocus(txt_PKO)

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Pal_1.Enabled = False
                cmd_DEL.Visible = False
                cmd_OK.Visible = False

            Case 3
                Me.Text = Me.Text & " - UPDATE"
                If CHK(3) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

                Frame1.Enabled = True
                txt_Autokey_PFK3452.Enabled = False

                cmd_DEL.Visible = False
                cmd_OK.Visible = True

            Case 4
                Me.Text = Me.Text & " - DELETE"
                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If
                Frame1.Enabled = True


                cmd_PRINT.Visible = False

                cmd_DEL.Visible = True
                cmd_OK.Visible = False

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            txt_Autokey_PFK3452.Enabled = False
            Call D3452_CLEAR()
            W3452 = D3452

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        Vs1.AllowRowMove = True
        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Try

            If READ_PFK3452(L3452.Autokey) Then
                L3452.Autokey = D3452.Autokey
            End If

            DS1 = READ_PFK3452(L3452.Autokey, cn)


            DATA_SEARCH01 = True

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_SEARCH01")
        End Try

    End Function

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD3456A_SEARCH_VS1", cn, L3452.Autokey)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3456A_SEARCH_VS1", "Vs1")

            Vs1.ActiveSheet.RowCount = 1
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO_NEW(Vs1, DS1, "USP_ISUD3456A_SEARCH_VS1", "Vs1")
        DATA_SEARCH_VS1 = True


    End Function
#End Region

#Region "Function"

    Private Function Data_Check() As Boolean
        Dim i As Integer

        Data_Check = False

        Try
            If txt_PKO.Data.Trim = "" Then Setfocus(txt_PKO) : Exit Function
            txt_PKO.Data = Replace(txt_PKO.Data, "'", "`")


            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))

        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            W3452.Autokey = txt_Autokey_PFK3452.Data

          
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub KEY_COUNT_MATERIAL()
        

    End Sub

    Private Sub KEY_COUNT_7103()

      

    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try
            Dim i As Integer
            Dim j As Integer
            Dim k As Integer
            Dim l As Integer
            Dim tmpSTR1 As String = ""
            Dim tmpSTR2 As String = ""

            j = 0
            l = 0
            k = 1
            i = 0

            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                j = j + 1
                l = l + 1

                Call D3456_CLEAR() : W3456 = D3456

                W3456.Autokey_PFK3452 = txt_Autokey_PFK3452.Data
               
                If K3456_MOVE(Vs1, i, W3456, W3456.Autokey) = False Then
                    W3456.Autokey_PFK3452 = L3452.Autokey

                    Call WRITE_PFK3456(W3456)



                Else
                 
                    Call REWRITE_PFK3456(W3456)

                End If
skip:
            Next

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub


    Private Sub DATA_INSERT()
        Try
            Call DATA_MOVE()
            Call KEY_COUNT()

            If WRITE_PFK3452(W3452) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True : WRITE_CHK = "*"
                Exit Sub
            End If
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INSERT")
        End Try

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE()
            If REWRITE_PFK3452(W3452) = True Then
                Call DATA_MOVE_WRITE01()

                isudCHK = True
            End If

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try

            If READ_PFK3452(L3452.Autokey) = True Then
                W3452 = D3452

                SQL = "DELETE FROM PFK3456 "
                SQL = SQL & " WHERE K3456_Autokey_PFK3452  = '" & W3452.Autokey & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()

                Call DELETE_PFK3452(W3452)
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

    Private Sub KEY_COUNT()
        Try

         
        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub


    Private Sub KEY_COUNT_SEQ()
       
    End Sub

#End Region

#Region "Event"

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Dim Starting As Object
        Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")


        Try
            Select Case wJOB
                Case 1
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call KEY_COUNT()
                    Call DATA_INSERT()
                    MsgBoxP("Save Successfully!", vbInformation)
                    wJOB = 3
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()

                Case 2
                    Me.Dispose()
                Case 3
                    If Data_Check() = False Then Exit Sub
                    If DataCheck(Me, "PFK7018") = False Then Exit Sub
                    Call DATA_UPDATE()
                    MsgBoxP("Save Successfully!", vbInformation)
                    Call DATA_SEARCH01()
                    Call DATA_SEARCH_VS1()
                Case 4
                    Call DATA_DELETE()
            End Select
        Catch ex As Exception

        Finally
            Starting.close()
        End Try
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

        If str = vbNo Then Exit Sub

        Call DATA_DELETE()

        Me.Dispose()
    End Sub

  
    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub


    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result = vbNo Then Exit Sub

                W3456.Autokey = getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), xROW)

                If READ_PFK3456(W3456.Autokey) Then
                    W3456 = D3456
                    Call DELETE_PFK3456(W3456)
                End If

                SPR_DEL(Vs1, xCOL, xROW)
                Vs1.ActiveSheet.ActiveColumnIndex = xCOL
                Vs1.ActiveSheet.ActiveRowIndex = xROW
                Vs1.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub



    Private Sub txt_BaseBom_Load(sender As Object, e As EventArgs) Handles txt_MasterBom.btnTitleClick
        'Dim xROW As Integer

        'xROW = Vs1.ActiveSheet.ActiveRowIndex
        'If Vs1.ActiveSheet.ActiveRowIndex < 0 Then Exit Sub

        'If HLP3452F.Link_HLP3452F = False Then Exit Sub

        'If hlp0000SeVa = "" Then Exit Sub
        'DS1 = PrcDS("USP_ISUD3456A_SEARCH_VS1", cn, hlp0000SeVaTt)

        'Call READ_SPREAD_N(Vs1, DS1, xROW, GetDsRc(DS1), "USP_ISUD3456A_SEARCH_VS1", "VS1")

    End Sub



#End Region


End Class