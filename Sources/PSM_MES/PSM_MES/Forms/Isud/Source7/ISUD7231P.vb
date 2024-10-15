Public Class ISUD7231P

#Region "Variable"
    Private wJOB As Integer

    Private W7109 As New T7109_AREA
    Private L7109 As New T7109_AREA

    Private W7231 As New T7231_AREA

    Private ExportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7231P(job As Integer, GroupComponentBOM As String, Optional ByVal TAG As String = "") As Boolean
        Exit Function

        Me.Tag = TAG
        D7109.GroupComponentBOM = GroupComponentBOM

        wJOB = job : L7109 = D7109
        txt_GroupComponentBOM.Data = GroupComponentBOM

        Link_ISUD7231P = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7231P = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try


    End Function

    Private L_7231 As New List(Of T7231_AREA)
    Private chk_Line As Boolean = False
    Public Function Link_ISUD7231P_LIST(job As Integer, M_7231 As Object, Optional ByVal TAG As String = "") As Boolean
        Me.Tag = TAG
        chk_Line = True
        wJOB = job : L7109 = D7109
        L_7231 = M_7231

        Link_ISUD7231P_LIST = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7231P_LIST = isudCHK


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

        Select Case wJOB
            Case 1                                                      'ÀÔ·Â
                Me.Text = Me.Text & " - INSERT"
                cmd_DEL.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                If chk_Line = False Then Call DATA_SEARCH_VS1()
                If chk_Line = True Then Call DATA_SEARCH_VS1_INSERT()

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

                Call DATA_SEARCH_VS1()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                txt_GroupComponentBOM.Enabled = False
                cmd_DEL.Visible = False
                Call DATA_SEARCH_VS1()

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
                        Call MsgBoxP("Only Search !") : cmd_OK.Visible = False
                    End If
                End If

            Case 4                                                      '»èÁ¦
                Me.Text = Me.Text & " - DELETE"

                cmd_OK.Visible = False

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_VS1()

        End Select

        formA = True
    End Sub
#End Region

#Region "Search"

    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7231P_SEARCH_VS1", cn, L7109.GroupComponentBOM)


        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD7231P_SEARCH_VS1", "Vs1")
            Vs1.ActiveSheet.RowCount = 10
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7231P_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True
    End Function

    Private Function DATA_SEARCH_VS1_INSERT() As Boolean
        DATA_SEARCH_VS1_INSERT = False
        Dim i As Integer

        DS1 = PrcDS("USP_ISUD7231P_SEARCH_VS1", cn, L7109.GroupComponentBOM)
        SPR_PRO(Vs1, DS1, "USP_ISUD7231P_SEARCH_VS1", "Vs1")

        Vs1.ActiveSheet.RowCount = L_7231.Count

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If READ_PFK7231_CHECKNAME_FULL(L_7231(i).MaterialName) Then
                setData(Vs1, getColumIndex(Vs1, "MaterialCode"), i, D7231.MaterialCode)
                setData(Vs1, getColumIndex(Vs1, "cdLargeGroupMaterial"), i, D7231.cdLargeGroupMaterial)
                setData(Vs1, getColumIndex(Vs1, "cdSemiGroupMaterial"), i, D7231.cdSemiGroupMaterial)
                setData(Vs1, getColumIndex(Vs1, "cdDetailGroupMaterial"), i, D7231.cdDetailGroupMaterial)
                setData(Vs1, getColumIndex(Vs1, "MaterialName"), i, D7231.MaterialName)
                setData(Vs1, getColumIndex(Vs1, "Width"), i, D7231.Width)
                setData(Vs1, getColumIndex(Vs1, "Height"), i, D7231.Height)
                setData(Vs1, getColumIndex(Vs1, "SizeName"), i, D7231.SizeName)
                setData(Vs1, getColumIndex(Vs1, "cdUnitmaterial"), i, D7231.cdUnitMaterial)

                If READ_PFK7171(ListCode("LargeGroupMaterial"), D7231.cdLargeGroupMaterial) Then
                    setData(Vs1, getColumIndex(Vs1, "cdLargeGroupMaterialName"), i, D7171.BasicName)
                End If
                If READ_PFK7171(ListCode("SemiGroupMaterial"), D7231.cdSemiGroupMaterial) Then
                    setData(Vs1, getColumIndex(Vs1, "cdSemiGroupMaterialName"), i, D7171.BasicName)
                End If
                If READ_PFK7171(ListCode("DetailGroupMaterial"), D7231.cdDetailGroupMaterial) Then
                    setData(Vs1, getColumIndex(Vs1, "cdDetailGroupMaterialName"), i, D7171.BasicName)
                End If
                If READ_PFK7171(ListCode("cdUnitmaterial"), D7231.cdLargeGroupMaterial) Then
                    setData(Vs1, getColumIndex(Vs1, "cdUnitmaterialName"), i, D7171.BasicName)
                End If

            Else
                setData(Vs1, getColumIndex(Vs1, "MaterialCode"), i, "")
                setData(Vs1, getColumIndex(Vs1, "cdLargeGroupMaterial"), i, "")
                setData(Vs1, getColumIndex(Vs1, "cdSemiGroupMaterial"), i, "")
                setData(Vs1, getColumIndex(Vs1, "cdDetailGroupMaterial"), i, "")
                setData(Vs1, getColumIndex(Vs1, "MaterialName"), i, L_7231(i).MaterialName)
                setData(Vs1, getColumIndex(Vs1, "Width"), i, L_7231(i).Width)
                setData(Vs1, getColumIndex(Vs1, "Height"), i, L_7231(i).Height)
                setData(Vs1, getColumIndex(Vs1, "SizeName"), i, L_7231(i).SizeName)
                setData(Vs1, getColumIndex(Vs1, "cdUnitmaterial"), i, "")
            End If


        Next

       

        DATA_SEARCH_VS1_INSERT = True
    End Function

#End Region

#Region "Function"
    Private Sub DATA_MOVE()



    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Dim i As Integer
        Dim j As Integer
        j = 0
        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If Trim(getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)) = "" Then GoTo skip

            j = j + 1
            If READ_PFK7231(getData(Vs1, getColumIndex(Vs1, "KEY_MaterialCode"), i)) = True Then
                W7231 = D7231
                W7231.cdUnitMaterial = getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)
                W7231.cdLargeGroupMaterial = getData(Vs1, getColumIndex(Vs1, "cdLargeGroupMaterial"), i)
                W7231.cdSemiGroupMaterial = getData(Vs1, getColumIndex(Vs1, "cdSemiGroupMaterial"), i)
                W7231.cdDetailGroupMaterial = getData(Vs1, getColumIndex(Vs1, "cdDetailGroupMaterial"), i)

                W7231.seUnitMaterial = ListCode("UnitMaterial")
                W7231.seLargeGroupMaterial = ListCode("LargeGroupMaterial")
                W7231.seSemiGroupMaterial = ListCode("SemiGroupMaterial")
                W7231.seDetailGroupMaterial = ListCode("DetailGroupMaterial")

                W7231.Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                W7231.Height = getData(Vs1, getColumIndex(Vs1, "Height"), i)
                W7231.SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)

                W7231.MaterialName = getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)

                If FormatCut(W7231.cdLargeGroupMaterial) <> "" And FormatCut(W7231.seUnitMaterial) <> "" Then
                    W7231.StatusMaterial = "1"
                    W7231.DateActive = Pub.DAT
                Else
                    W7231.StatusMaterial = "2"
                    W7231.DateActive = ""
                    W7231.DateDeactive = Pub.DAT
                End If

                If REWRITE_PFK7231(W7231) = True Then
                    isudCHK = True
                    WRITE_CHK = "*"
                End If
            Else
                W7231.cdUnitMaterial = getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i)
                W7231.cdLargeGroupMaterial = getData(Vs1, getColumIndex(Vs1, "cdLargeGroupMaterial"), i)
                W7231.cdSemiGroupMaterial = getData(Vs1, getColumIndex(Vs1, "cdSemiGroupMaterial"), i)
                W7231.cdDetailGroupMaterial = getData(Vs1, getColumIndex(Vs1, "cdDetailGroupMaterial"), i)

                W7231.seUnitMaterial = ListCode("UnitMaterial")
                W7231.seLargeGroupMaterial = ListCode("LargeGroupMaterial")
                W7231.seSemiGroupMaterial = ListCode("SemiGroupMaterial")
                W7231.seDetailGroupMaterial = ListCode("DetailGroupMaterial")

                W7231.Width = getData(Vs1, getColumIndex(Vs1, "Width"), i)
                W7231.Height = getData(Vs1, getColumIndex(Vs1, "Height"), i)
                W7231.SizeName = getData(Vs1, getColumIndex(Vs1, "SizeName"), i)

                W7231.MaterialName = getData(Vs1, getColumIndex(Vs1, "MaterialName"), i)
                W7231.StatusMaterial = "1"
                W7231.DateActive = Pub.DAT
                W7231.DateStart = Pub.DAT
                W7231.DateInsert = Pub.DAT

                W7231.DevelopmentCode = W7231.MaterialCode

                KEY_COUNT()

                If WRITE_PFK7231(W7231) = True Then
                    isudCHK = True
                    WRITE_CHK = "*"
                End If

            End If
skip:
        Next
    End Sub

    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader


        SQL = "SELECT MAX(CAST(K7231_MaterialCode AS DECIMAL)) AS MAX_CODE FROM PFK7231 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7231.MaterialCode = "000001"
        Else
            W7231.MaterialCode = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If


        rd.Close()

    End Sub

    Private Sub DATA_UPDATE()
        Try
            Call DATA_MOVE_WRITE01()
        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
     
    End Sub

    Private Sub DATA_INIT()

    End Sub

    Private Sub FORM_INIT()

    End Sub

#End Region

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "cdLargeGroupMaterial"), i) = "" Then MsgBoxP("No cdLargeGroupMaterial! Pls Input!") : Exit Function
                If getData(Vs1, getColumIndex(Vs1, "cdSemiGroupMaterial"), i) = "" Then MsgBoxP("No cdSemiGroupMaterial! Pls Input!") : Exit Function
                If getData(Vs1, getColumIndex(Vs1, "cdDetailGroupMaterial"), i) = "" Then MsgBoxP("No cdDetailGroupMaterial! Pls Input!") : Exit Function


                If getData(Vs1, getColumIndex(Vs1, "cdUnitMaterial"), i) = "" Then MsgBoxP("No cdUnitMaterial! Pls Input!") : Exit Function

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function

#Region "Event"
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub

                Call DATA_SEARCH_VS1()
                wJOB = 3
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub

                Call DATA_SEARCH_VS1()
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
        Me.Dispose()

    End Sub

    Private Sub Vs1_ButtonClicked(sender As Object, e As EditorNotifyEventArgs) Handles Vs1.ButtonClicked
        'Dim xrow As Integer
        'xrow = e.Row

        'Select Case e.Column
        '    Case getColumIndex(Vs1, "cdMaterialCode")
        '        Dim f As New Form
        '        f = New HLP7231C
        '        f.ShowDialog()
        '        If hlp0000SeVaTt = "" Or hlp0000SeVa = "" Then Exit Sub
        '        If READ_PFK7231(hlp0000SeVaTt) = True Then
        '            setData(Vs1, getColumIndex(Vs1, "MaterialCode"), xrow, D7231.MaterialCode)
        '            setData(Vs1, getColumIndex(Vs1, "MaterialName"), xrow, D7231.MaterialName)
        '            If READ_PFK7171(Const_UnitMaterial, D7231.cdUnitMaterial) = True Then
        '                setData(Vs1, getColumIndex(Vs1, "cdUnitMaterialName"), xrow, D7171.BasicName)
        '            End If
        '        End If

        '    Case getColumIndex(Vs1, "cdUnitPrice")
        '        HLPCHECK("Const_UnitPrice")
        '        If hlp0000SeVa = "" Or hlp0000SeVaTt = "" Then Exit Sub
        '        setData(Vs1, getColumIndex(Vs1, "cdUnitPrice"), xrow, hlp0000SeVaTt)
        '        setData(Vs1, getColumIndex(Vs1, "cdUnitPriceExpenseName"), xrow, hlp0000SeVa)

        'End Select

        'vSChange(e.Row)

    End Sub
    Private Sub Vs1_Change(sender As Object, e As ChangeEventArgs) Handles Vs1.Change
        Dim xCOL As Long
        Dim xROW As Long

        Try

            xROW = e.Row
            xCOL = e.Column

            vSChange(xROW)



        Catch ex As Exception

        End Try

    End Sub

    Private Sub vSChange(xROW As Integer)
      
    End Sub

    Private Sub Vs1_CellClick(sender As Object, e As CellClickEventArgs) Handles Vs1.CellClick
        Vs1.ActiveSheet.ActiveRowIndex = e.Row
        Vs1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub




    Private Sub vS1_KeyDown(sender As Object, e As KeyEventArgs) Handles Vs1.KeyDown
        If wJOB = 2 Then Exit Sub

        Dim xCOL As Long
        Dim xROW As Long

        xCOL = Vs1.ActiveSheet.ActiveColumnIndex
        xROW = Vs1.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Insert
                If xROW = sender.ActiveSheet.RowCount - 1 Then
                    Vs1.ActiveSheet.RowCount += 1
                    Vs1.ActiveSheet.ActiveRowIndex = xROW + 1
                Else
                    Vs1.ActiveSheet.AddRows(xROW, 1)
                End If

            Case Keys.Delete


                SPR_DEL(Vs1, 0, Vs1.ActiveSheet.ActiveRowIndex)
                Vs1.Focus()
            Case Keys.Enter

                vSChange(xROW)
        End Select
    End Sub
#End Region




End Class