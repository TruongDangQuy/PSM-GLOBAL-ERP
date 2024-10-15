Public Class ISUD7231R

#Region "Variable"
    Private wJOB As Integer

    Private W7109 As New T7109_AREA
    Private L7109 As New T7109_AREA

    Private W7231 As New T7231_AREA
    Private W3011 As New T3011_AREA

    Private ExportTax As Decimal
    Private EnvironmentTax As Decimal
    Private VatTax As Decimal

    Private WRITE_CHK As String
    Private formA As Boolean
    Private CHK(0 To 5) As String

    Private L_CustomerCode As String
    Private L_cdSeason As String
    Private L_Line As String
    Private L_cdLargeGroupMaterial As String
    Private L_cdSemiGroupMaterial As String
    Private L_checkSample As String

#End Region

#Region "Link"
    Public Function Link_ISUD7231R(job As Integer, cdSeason As String, CustomerCode As String, _Line As String, _cdLargeGroupMaterial As String, _cdSemiGroupMaterial As String, _checkSample As String) As Boolean
        Me.Tag = Tag

        L_CustomerCode = CustomerCode
        L_cdSeason = cdSeason
        L_Line = _Line
        L_cdLargeGroupMaterial = _cdLargeGroupMaterial
        L_cdSemiGroupMaterial = _cdSemiGroupMaterial
        L_checkSample = _checkSample

        wJOB = job

        Link_ISUD7231R = False
        Try

            Select Case job
                Case 1
                Case Else

            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7231R = isudCHK


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
                tst_iDelete.Visible = False

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH_VS1()
            Case 2
                Me.Text = Me.Text & " - SEARCH"

                tst_iDelete.Visible = False
                tst_iSave.Visible = False

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
                tst_iDelete.Visible = False
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
                        tst_iDelete.Visible = False
                        Call MsgBoxP("Only Search !") : tst_iSave.Visible = False
                    End If
                End If

            Case 4                                                      '»èÁ¦
                Me.Text = Me.Text & " - DELETE"

                tst_iSave.Visible = False

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
    Private Sub DATA_INIT()

    End Sub

    Private Sub FORM_INIT()

        tst_iUtilities.Visible = True
        tst_iAttach.Visible = True
        tst_iHistory.Visible = False

        Me.WindowState = FormWindowState.Maximized
    End Sub
#End Region

#Region "Search"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False

        DS1 = PrcDS("USP_ISUD7231R_SEARCH_VS1", cn, L_cdSeason, L_CustomerCode, L_Line, L_cdLargeGroupMaterial, L_cdSemiGroupMaterial, L_checkSample)

        If GetDsRc(DS1) = 0 Then
            SPR_SET(Vs1, , , , OperationMode.Normal)
            SPR_PRO(Vs1, DS1, "USP_ISUD7231R_SEARCH_VS1", "Vs1")
            Vs1.Enabled = True
            Exit Function
        End If

        SPR_SET(Vs1, , , , OperationMode.Normal)
        SPR_PRO(Vs1, DS1, "USP_ISUD7231R_SEARCH_VS1", "Vs1")

        DATA_SEARCH_VS1 = True
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
            If CIntp(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), i)) = 0 Then GoTo skip1

            If READ_PFK3011(getData(Vs1, getColumIndex(Vs1, "KEY_Autokey"), i)) = True Then
                W3011 = D3011
                W3011.SupplierCode = getData(Vs1, getColumIndex(Vs1, "SupplierCode"), i)

                Call REWRITE_PFK3011(W3011)

            End If
skip1:
        Next


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

    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            For i = 0 To Vs1.ActiveSheet.RowCount - 1
                If getData(Vs1, getColumIndex(Vs1, "SupplierCode"), i) = "" Then MsgBoxP("No SupplierCode! Pls Input!") : Exit Function

            Next

            Data_Check = True
        Catch ex As Exception

        End Try
    End Function

#End Region

#Region "Event"
    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCH_VS1()
                wJOB = 3
            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub
                Call DATA_MOVE_WRITE01()
                Call DATA_SEARCH_VS1()
            Case 4
                Call DATA_DELETE()
        End Select
    End Sub

    Private Sub tst_iClose_Click(sender As Object, e As EventArgs) Handles tst_iClose.Click
        If WRITE_CHK = "*" Then
            isudCHK = True
        Else
            isudCHK = False
        End If

        Me.Dispose()
    End Sub

    Private Sub tst_iDelete_Click(sender As Object, e As EventArgs) Handles tst_iDelete.Click
        Call GROUP_SETTING(Me.Name, CHK(1), CHK(2), CHK(3), CHK(4), CHK(5))

        If CHK(4) <> "1" Then
            Call MsgBoxP("4", "tst_iDelete_Click")
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
        Dim i As Integer
        Dim SupplierCode As String
        Dim SupplierName As String

        SupplierCode = getData(Vs1, getColumIndex(Vs1, "SupplierCode"), xROW)
        SupplierName = getData(Vs1, getColumIndex(Vs1, "SupplierName"), xROW)

        For i = 0 To Vs1.ActiveSheet.RowCount - 1
            If getDataM(Vs1, getColumIndex(Vs1, "dchk"), i) = "1" Then
                setData(Vs1, getColumIndex(Vs1, "SupplierCode"), i, SupplierCode)
                setData(Vs1, getColumIndex(Vs1, "SupplierName"), i, SupplierName)
            End If

        Next
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

    Private Sub cmd_GetSupplier_Click(sender As Object, e As EventArgs) Handles cmd_GetSupplier.Click
        Dim i As Integer
        Dim StrMsg As Integer
        Dim MaterialCode As String

        StrMsg = InputBox("Chọn chế độ quét nhà cung (0. Xóa hết , 1. chính xác , 2. Gần chính xác")

        If StrMsg <> "1" And StrMsg <> "2" And StrMsg <> "0" Then MsgBoxP("Chế độ sai!") : Exit Sub

        Try
            If StrMsg = "0" Then
                For i = 0 To Vs1.ActiveSheet.RowCount - 1

                    setData(Vs1, getColumIndex(Vs1, "SupplierCode"), i, "")
                    setData(Vs1, getColumIndex(Vs1, "SupplierName"), i, "")

                Next

            ElseIf StrMsg = "1" Then
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)

                    If READ_PFK7261_GETEXACTLY(MaterialCode) Then
                        If READ_PFK7260(D7261.ContractID) Then
                            Call READ_PFK7101(D7260.CustomerCode)
                            setData(Vs1, getColumIndex(Vs1, "SupplierCode"), i, D7260.CustomerCode)
                            setData(Vs1, getColumIndex(Vs1, "SupplierName"), i, D7101.CustomerNameSimply)

                        End If
                    End If

                Next

            ElseIf StrMsg = "2" Then
                For i = 0 To Vs1.ActiveSheet.RowCount - 1
                    MaterialCode = getData(Vs1, getColumIndex(Vs1, "MaterialCode"), i)

                    If READ_PFK7261_GETEXACTLY_NO(MaterialCode) Then
                        If READ_PFK7260(D7261.ContractID) Then
                            Call READ_PFK7101(D7260.CustomerCode)
                            setData(Vs1, getColumIndex(Vs1, "SupplierCode"), i, D7260.CustomerCode)
                            setData(Vs1, getColumIndex(Vs1, "SupplierName"), i, D7101.CustomerNameSimply)

                        End If
                    End If

                Next
            End If


        Catch ex As Exception

        End Try
    End Sub
#End Region

End Class