Public Class ISUD7231M

#Region "Variable"
    Private wJOB As Integer

    Private W7115 As T7115_AREA
    Private L7115 As T7115_AREA

    Private L7108 As T7108_AREA
    Private W7108 As T7108_AREA

    Private W7109 As T7109_AREA
    Private L7109 As T7109_AREA

    Private W7103 As T7103_AREA
    Private W7231 As T7231_AREA


    Private W7121 As T7121_AREA

    Private L7171 As T7171_AREA

    Private WRITE_CHK As String
    Private ChkUpload As Boolean = False
    Private cdGroupComponent As String

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD7231M(job As Integer, ShoesCode As String, Optional ByVal TAG As String = "") As Boolean
        Exit Function

        Me.Tag = TAG
        D7115.ShoesCode = ShoesCode

        wJOB = job : L7115 = D7115

        Link_ISUD7231M = False

        Try
            Select Case job
                Case 1
                Case Else
                    If READ_PFK7106(ShoesCode) = False Then
                        Call MsgBoxP("3", "LINK_ISUD")

                        Me.Dispose()
                        Exit Function
                    End If
            End Select

            formA = False
            Me.ShowDialog()

            Link_ISUD7231M = isudCHK


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("BaseComponentBOM"))
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
                tst_iDelete.Visible = True

                If CHK(1) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

            Case 2
                Me.Text = Me.Text & " - SEARCH"
                tst_iDelete.Visible = True
                tst_iSave.Visible = False

                If CHK(2) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()
            Case 3
                Me.Text = Me.Text & " - UPDATE"

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

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
                        Call MsgBoxP("16", "Form_Activate")
                    End If
                End If

            Case 4                                                      '»èÁ¦
                Me.Text = Me.Text & " - DELETE"

                If CHK(4) <> "1" Then
                    isudCHK = False
                    Me.Dispose()
                    formA = True
                    Call MsgBoxP("You have no right is this program !")
                    Exit Sub
                End If

                Call DATA_SEARCH01()
                Call DATA_SEARCH_VS2()

        End Select

        formA = True
    End Sub
    Private Sub DATA_INIT()
        Try
            Call D7115_CLEAR()
            W7115 = D7115

        Catch ex As Exception
            Call MsgBoxP("35", "DATA_INIT")
        End Try

    End Sub

    Private Sub FORM_INIT()
        tst_iPrint.Visible = False
        tst_iPrint_Print.Visible = False
    End Sub
#End Region

#Region "Data_Search"
    Private Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        Dim i As Integer

        DS1 = READ_PFK7106(L7115.ShoesCode, cn)

        If GetDsRc(DS1) > 0 Then
            READER_MOVE(Me, DS1)
            txt_GroupComponentBOMName.Data = txt_Line.Data & "-" & txt_Article.Data & "-" & txt_ColorName.Data
        End If

        DS1 = Nothing

        SQL = " SELECT K9001_MappingNo, K9001_MappingName FROM PFK9001 WHERE K9001_CustomerCode = '" + txt_CustomerCode.Code + "'"
        cmd = New SqlClient.SqlCommand(SQL, cn)
        DS1 = PrcDS(cmd, cn)

        txt_MappingNo.Items.Clear()

        If GetDsRc(DS1) > 0 Then
            For i = 0 To GetDsRc(DS1) - 1
                txt_MappingNo.Items.Add(GetDsData(DS1, i, "K9001_MappingNo") & ";" & GetDsData(DS1, i, "K9001_MappingName"))
            Next
            txt_MappingNo.SelectedIndex = 0
        End If


    End Function

    Private Function DATA_SEARCH_VS2() As Boolean
        DATA_SEARCH_VS2 = False
        Dim Value() As String

        Value = txt_MappingNo.Text.Split(";")

        DS1 = PrcDS("USP_ISUD7231M_SEARCH_VS2", cn, Value(0))

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS2, DS1, "USP_ISUD7231M_SEARCH_VS2", "VS2")
            vS2.Enabled = True
            Exit Function
        End If

        SPR_PRO_NEW(vS2, DS1, "USP_ISUD7231M_SEARCH_VS2", "VS2")

        DATA_SEARCH_VS2 = True
    End Function

    Private Structure DVALUE
        Dim RowBegin As Integer
        Dim RowEnd As Integer

        Dim ColBegin As Integer
        Dim ColEnd As Integer

        Dim ItemName As String
    End Structure
    Private Function DATA_SEARCH_VS3() As Boolean
        DATA_SEARCH_VS3 = False
        Dim i As Integer
        Dim j As Integer
        Dim ArrValue As New List(Of DVALUE)
        Dim ArrValue_1 As DVALUE

        DS1 = PrcDS("USP_ISUD7231M_SEARCH_VS3", cn, txt_ShoesCode.Data)
        SPR_PRO_NEW(VS3, DS1, "USP_ISUD7231M_SEARCH_VS3", "VS3")

        If GetDsRc(DS1) > 0 Then Exit Function

        For i = 0 To vS2.ActiveSheet.RowCount - 1
            If CIntp(getData(vS2, getColumIndex(vS2, "RowEnd"), i)) > 0 Then
                ArrValue_1.RowBegin = CIntp(getData(vS2, getColumIndex(vS2, "RowBegin"), i))
                ArrValue_1.RowEnd = CIntp(getData(vS2, getColumIndex(vS2, "RowEnd"), i))

                ArrValue_1.ColBegin = CIntp(getData(vS2, getColumIndex(vS2, "ColBegin"), i))
                ArrValue_1.ColEnd = CIntp(getData(vS2, getColumIndex(vS2, "ColEnd"), i))

                ArrValue_1.ItemName = getData(vS2, getColumIndex(vS2, "ItemName"), i)

                ArrValue.Add(ArrValue_1)
            End If
        Next


        For j = ArrValue(0).RowBegin To ArrValue(0).RowEnd
            VS3.ActiveSheet.RowCount += 1
            For i = 0 To ArrValue.Count - 1
                If ArrValue(i).ItemName = "cdGroupComponentName" Then
                    If READ_PFK7171_NAME(ListCode("GroupComponent"), getData(Vs1, ArrValue(i).ColBegin, j)) Then
                        L7171 = D7171
                        setData(VS3, getColumIndex(VS3, "cdGroupComponentName"), VS3.ActiveSheet.RowCount - 1, D7171.BasicName)
                        setData(VS3, getColumIndex(VS3, "cdGroupComponent"), VS3.ActiveSheet.RowCount - 1, D7171.BasicCode)
                    Else
                        setData(VS3, getColumIndex(VS3, "cdGroupComponentName"), VS3.ActiveSheet.RowCount - 1, L7171.BasicName)
                        setData(VS3, getColumIndex(VS3, "cdGroupComponent"), VS3.ActiveSheet.RowCount - 1, L7171.BasicCode)
                    End If
                ElseIf ArrValue(i).ItemName = "cdUnitMaterialName" Then
                    D7235_CLEAR()
                    If READ_PFK7235_EXCHANGENAME(getData(Vs1, ArrValue(i).ColBegin, j)) Then

                        If READ_PFK7171(ListCode("UnitMaterial"), D7235.cdUnitMaterial) Then
                            setData(VS3, getColumIndex(VS3, "cdUnitMaterial"), VS3.ActiveSheet.RowCount - 1, D7235.cdUnitMaterial)
                            setData(VS3, getColumIndex(VS3, "cdUnitMaterialName"), VS3.ActiveSheet.RowCount - 1, D7171.BasicName)
                            setData(VS3, getColumIndex(VS3, "Width"), VS3.ActiveSheet.RowCount - 1, D7235.Width)
                        End If
                    Else
                        setData(VS3, getColumIndex(VS3, ArrValue(i).ItemName), VS3.ActiveSheet.RowCount - 1, getData(Vs1, ArrValue(i).ColBegin, j))
                    End If
                ElseIf ArrValue(i).ItemName = "Loss" Then
                    setData(VS3, getColumIndex(VS3, ArrValue(i).ItemName), VS3.ActiveSheet.RowCount - 1, 100 * CDecp(getData(Vs1, ArrValue(i).ColBegin, j)))
                Else
                    setData(VS3, getColumIndex(VS3, ArrValue(i).ItemName), VS3.ActiveSheet.RowCount - 1, getData(Vs1, ArrValue(i).ColBegin, j))
                End If
            Next
        Next

        i = 0

        While i < VS3.ActiveSheet.RowCount
            If getData(VS3, getColumIndex(VS3, "Consumption"), i) Is Nothing Then
                SPR_RemoveRow(VS3, i, 1)
            Else
                i += 1
            End If
        End While

        i = 1

        While i < VS3.ActiveSheet.RowCount
            If getData(VS3, getColumIndex(VS3, "ComponentName"), i) = "" Then
                setData(VS3, getColumIndex(VS3, "ComponentName"), i, getData(VS3, getColumIndex(VS3, "ComponentName"), i - 1))
            End If

            If getData(VS3, getColumIndex(VS3, "MaterialName"), i) = "" Then

            End If

            i += 1
        End While

        i = 1

        For i = 0 To VS3.ActiveSheet.RowCount - 1
            If READ_PFK7103_TYPENAME("003", getData(VS3, getColumIndex(VS3, "ComponentName"), i)) Then
                setData(VS3, getColumIndex(VS3, "TypeCode"), i, D7103.TypeCode)
                setData(VS3, getColumIndex(VS3, "cdTypeCode"), i, D7103.cdTypeCode)
            Else
                setData(VS3, getColumIndex(VS3, "TypeCode"), i, "")
                setData(VS3, getColumIndex(VS3, "cdTypeCode"), i, "")
            End If
        Next

        For i = 0 To VS3.ActiveSheet.RowCount - 1
            If READ_PFK7121_NAME(getData(VS3, getColumIndex(VS3, "ColorName"), i)) Then
                setData(VS3, getColumIndex(VS3, "ColorCode"), i, D7121.ColorCode)
                setData(VS3, getColumIndex(VS3, "ColorName"), i, D7121.ColorName)
            End If
        Next

        i = 1

        For i = 0 To VS3.ActiveSheet.RowCount - 1
            If READ_PFK7231_CHECKNAME_FULL(getData(VS3, getColumIndex(VS3, "MaterialName"), i)) Then
                setData(VS3, getColumIndex(VS3, "MaterialCode"), i, D7231.MaterialCode)
            Else
                setData(VS3, getColumIndex(VS3, "MaterialCode"), i, "")
            End If
        Next

        For i = 0 To VS3.ActiveSheet.RowCount - 1
            If getData(VS3, getColumIndex(VS3, "MaterialCode"), i) = "" Or getData(VS3, getColumIndex(VS3, "TypeCode"), i) = "" _
            Or getData(VS3, getColumIndex(VS3, "cdGroupComponent"), i) = "" Or getData(VS3, getColumIndex(VS3, "cdUnitMaterial"), i) = "" Then
                SPR_BACKCOLORCELL(VS3, cRelation3HeaderColor, getColumIndex(VS3, "dseq"), i)

            End If
        Next

        DATA_SEARCH_VS3 = True

    End Function
    'Private Function DATA_SEARCH_VS3() As Boolean
    '    DATA_SEARCH_VS3 = False
    '    Dim i As Integer
    '    Dim j As Integer
    '    Dim Xrow As Integer
    '    Dim ChkRow As Boolean = False

    '    Dim RowBegin As Integer
    '    Dim RowEnd As Integer

    '    Dim ColBegin As Integer
    '    Dim ColEnd As Integer

    '    Dim ItemName As String
    '    Dim ArrValue() As List(Of String)

    '    DS1 = PrcDS("USP_ISUD7231M_SEARCH_VS3", cn, txt_ShoesCode.Data)
    '    SPR_PRO_NEW(VS3, DS1, "USP_ISUD7231M_SEARCH_VS3", "VS3")

    '    If GetDsRc(DS1) > 0 Then Exit Function

    '    For i = 0 To vS2.ActiveSheet.RowCount - 1
    '        If CIntp(getData(vS2, getColumIndex(vS2, "RowEnd"), i)) > 0 Then

    '        End If
    '    Next

    '    For i = 0 To vS2.ActiveSheet.RowCount - 1
    '        If CIntp(getData(vS2, getColumIndex(vS2, "RowEnd"), i)) > 0 Then

    '            RowBegin = CIntp(getData(vS2, getColumIndex(vS2, "RowBegin"), i))
    '            RowEnd = CIntp(getData(vS2, getColumIndex(vS2, "RowEnd"), i))

    '            ColBegin = CIntp(getData(vS2, getColumIndex(vS2, "ColBegin"), i))
    '            ColEnd = CIntp(getData(vS2, getColumIndex(vS2, "ColEnd"), i))

    '            ItemName = getData(vS2, getColumIndex(vS2, "ItemName"), i)
    '            Xrow = 0

    '            If ChkRow = False Then
    '                For j = RowBegin To RowEnd

    '                    VS3.ActiveSheet.RowCount += 1
    '                    setData(VS3, getColumIndex(VS3, ItemName), VS3.ActiveSheet.RowCount - 1, getData(Vs1, ColBegin, j))
    '                Next

    '                ChkRow = True

    '            Else
    '                For j = RowBegin To RowEnd

    '                    setData(VS3, getColumIndex(VS3, ItemName), Xrow, getData(Vs1, ColBegin, j))
    '                    Xrow += 1
    '                Next

    '            End If



    '        End If
    '    Next

    '    DATA_SEARCH_VS3 = True

    'End Function
#End Region

#Region "Function"
    Private Sub KEY_COUNT_7103()

        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7103_TypeCode AS DECIMAL)) AS MAX_CODE FROM PFK7103 "
        SQL = SQL + " WHERE K7103_cdTypeCode = '003' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7103.TypeCode = "000001"
        Else
            W7103.TypeCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        rd.Close()

    End Sub
    Private Sub KEY_COUNT_MATERIAL()
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


    End Sub
    Private Function Data_Check() As Boolean
        Data_Check = False
        Dim i As Integer

        Try
            W7108.CheckUse = "1"

            For i = 0 To VS3.ActiveSheet.RowCount - 1
                'If FormatCut(getData(VS3, getColumIndex(VS3, "MaterialCode"), i)) = "" Then MsgBoxP("MaterialCode at Line" & (i + 1)) : Exit Function

                'If FormatCut(getData(VS3, getColumIndex(VS3, "MaterialName"), i)) = "" Then MsgBoxP("Material Name at Line" & (i + 1)) : Exit Function
                'If FormatCut(getData(VS3, getColumIndex(VS3, "ComponentName"), i)) = "" Then MsgBoxP("Component Name at Line" & (i + 1)) : Exit Function
                'If FormatCut(getData(VS3, getColumIndex(VS3, "cdUnitMaterialName"), i)) = "" Then MsgBoxP("UnitMaterial Name at Line" & (i + 1)) : Exit Function


                If FormatCut(getData(VS3, getColumIndex(VS3, "MaterialCode"), i)) = "" Then W7108.CheckUse = "2"

                If FormatCut(getData(VS3, getColumIndex(VS3, "MaterialName"), i)) = "" Then W7108.CheckUse = "2"
                If FormatCut(getData(VS3, getColumIndex(VS3, "ComponentName"), i)) = "" Then W7108.CheckUse = "2"
                If FormatCut(getData(VS3, getColumIndex(VS3, "cdUnitMaterialName"), i)) = "" Then W7108.CheckUse = "2"

            Next

            Data_Check = True
skip_1:
        Catch ex As Exception
            Call MsgBoxP("61", WordConv("YARN PROCESSING"))
        End Try
    End Function


    Private Sub DATA_MOVE()
        Try
            W7108.ShoesCode = txt_ShoesCode.Data
            W7108.GroupComponentBOMName = txt_Line.Data & "-" & txt_Article.Data & "-" & txt_ColorName.Data
            W7108.CheckUse = "1"

        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE"))
        End Try
    End Sub

    Private Sub DATA_MOVE_WRITE01()
        Try
            SQL = "DELETE FROM PFK7109 "
            SQL = SQL & " WHERE K7109_GroupComponentBOM  = '" & W7108.GroupComponentBOM & "' "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            cmd.ExecuteNonQuery()

            Dim i As Integer
            Dim j As Integer
            j = 0
            For i = 0 To VS3.ActiveSheet.RowCount - 1
                'If getData(VS3, getColumIndex(VS3, "MaterialName"), i) = "" Then GoTo skip
                'If getData(VS3, getColumIndex(VS3, "ComponentName"), i) = "" Then GoTo skip

                j = j + 1

                Call D7109_CLEAR() : W7109 = D7109
                Call K7109_MOVE(VS3, i, W7109, W7109.GroupComponentBOM, W7109.GroupComponentSeq)

                W7109.GroupComponentBOM = W7108.GroupComponentBOM
                W7109.GroupComponentSeq = j
                W7109.Dseq = j

                W7109.selGroupComponent = ListCode("GroupComponent")
                W7109.seDepartment = ListCode("Department")
                W7109.seShoesStatus = ListCode("ShoesStatus")
                W7109.seUnitMaterial = ListCode("UnitMaterial")
                W7109.seSubProcess = ListCode("SubProcess")

                If READ_PFK7121_NAME(getData(VS3, getColumIndex(VS3, "ColorName"), i)) = False Then
                    W7121.seColorBase = ListCode("ColorBase")
                    W7121.seColorCategory = ListCode("ColorCategory")
                    W7121.ColorName = getData(VS3, getColumIndex(VS3, "ColorName"), i)
                    Call KEY_COUNT_7121()
                    If WRITE_PFK7121(W7121) = True Then
                        W7109.ColorCode = W7121.ColorCode
                        W7109.ColorName = W7121.ColorName
                    End If
                End If

                'If READ_PFK7103_TYPENAME("003", W7109.ComponentName) = False Then
                '    W7103.TypeName = W7109.ComponentName
                '    W7103.CustomerCode = txt_CustomerCode.Code
                '    W7103.seTypeCode = ListCode("TypeCode")
                '    W7103.cdTypeCode = "003"
                '    W7103.CheckUse = "1"
                '    W7103.DateInsert = Pub.DAT
                '    W7103.InchargeInsert = Pub.SAW
                '    Call KEY_COUNT_7103()

                '    Call WRITE_PFK7103(W7103)
                'End If

                W7109.GrossUsage = W7109.Consumption * (W7109.Loss / 100 + 1)
                W7109.MaterialAMT = W7109.GrossUsage * W7109.Price

                Call WRITE_PFK7109(W7109)
skip:
            Next


        Catch ex As Exception
            Call MsgBoxP("61", WordConv("DATA_MOVE_WRITE01"))
        End Try

    End Sub
    Private Sub KEY_COUNT_7121()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K7121_ColorCode AS DECIMAL)) AS MAX_CODE FROM PFK7121 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            W7121.ColorCode = "000001"
        Else
            W7121.ColorCode = Format(CIntp(rd!MAX_CODE + 1), "000000")
        End If

        rd.Close()

    End Sub

    Private Sub KEY_COUNT()
        Try

            SQL = " SELECT MAX(CAST(K7108_GroupComponentBOM AS DECIMAL)) as MAX_CODE FROM PFK7108 "
            cmd = New SqlClient.SqlCommand(SQL, cn)
            rd = cmd.ExecuteReader
            rd.Read()
            If IsDBNull(rd!MAX_CODE) Then
                W7108.GroupComponentBOM = "000001"
            Else
                W7108.GroupComponentBOM = Format(CIntp(rd!MAX_CODE + 1), "000000")
            End If

            rd.Close()

            L7108.GroupComponentBOM = W7108.GroupComponentBOM

        Catch ex As Exception
            Call MsgBoxP("35", "KEY_COUNT")
        End Try
    End Sub

    Private Sub DATA_UPDATE()
        Try
            If READ_PFK7108_SHOESCODE(txt_ShoesCode.Data) = False Then
                Call DATA_MOVE()
                Call KEY_COUNT()

                If WRITE_PFK7108(W7108) = True Then
                    Call DATA_MOVE_WRITE01()
                    Call MsgBoxP("Upload Successully!", vbInformation)
                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If

            Else
                W7108 = D7108
                Call DATA_MOVE()

                If REWRITE_PFK7108(W7108) = True Then
                    Call DATA_MOVE_WRITE01()
                    Call MsgBoxP("Upload Successully!", vbInformation)
                    isudCHK = True : WRITE_CHK = "*"
                    Exit Sub
                End If

            End If


        Catch ex As Exception
            Call MsgBoxP("35", "DATA_UPDATE")
        End Try
    End Sub

    Private Sub DATA_DELETE()
        Try
            If READ_PFK7108_SHOESCODE(txt_ShoesCode.Data) = True Then
                SQL = "DELETE FROM PFK7109 "
                SQL = SQL & " WHERE K7109_GroupComponentBOM  = '" & D7108.GroupComponentBOM & "' "
                cmd = New SqlClient.SqlCommand(SQL, cn)
                cmd.ExecuteNonQuery()
            End If

        Catch ex As Exception
            Call MsgBoxP("38", "DATA_DELETE")
        End Try

    End Sub

#End Region

#Region "Event"
    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_Main.DoubleClick
        If formA = False Then ptc_Main.SelectedIndex = 0

        Select Case ptc_Main.SelectedIndex
            Case 0

            Case 1
                Call DATA_SEARCH_VS2()
            Case 2
                Call DATA_SEARCH_VS3()
        End Select
    End Sub
    Private Sub ptc_Main_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ptc_Main.SelectedIndexChanged
        If formA = False Then ptc_Main.SelectedIndex = 0

        'Select Case ptc_Main.SelectedIndex
        '     Case 0

        '     Case 1
        '         Call DATA_SEARCH_VS2()
        '     Case 2
        '         Call DATA_SEARCH_VS3()
        ' End Select

    End Sub

    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Select Case wJOB
            Case 1
                If Data_Check() = False Then Exit Sub
                If DataCheck(Me, "PFK7115") = False Then Exit Sub

                Call DATA_UPDATE()
                Call DATA_SEARCH_VS3()
                wJOB = 3

            Case 2
                Me.Dispose()
            Case 3
                If Data_Check() = False Then Exit Sub

                If DataCheck(Me, "PFK7115") = False Then Exit Sub
                Call DATA_UPDATE()
                Call DATA_SEARCH_VS3()

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
        Call DATA_SEARCH_VS3()

    End Sub


    Private Sub Vs3_CellClick(sender As Object, e As CellClickEventArgs) Handles VS3.CellClick
        VS3.ActiveSheet.ActiveRowIndex = e.Row
        VS3.ActiveSheet.ActiveColumnIndex = e.Column

    End Sub


    Private Sub cmd_Upload_Click(sender As Object, e As EventArgs) Handles cmd_Upload.Click
        Try

            Using OpenFileDialog As OpenFileDialog = Me.GetOpenFileDialog()

                'Open the File Dialog to select the file
                If (OpenFileDialog.ShowDialog(Me) = DialogResult.OK) Then
                    Vs1.OpenExcel(OpenFileDialog.FileName)
                    ChkUpload = True
                Else 'Cancel

                    Exit Sub

                End If

            End Using

        Catch ex As Exception

        End Try
    End Sub

    Friend Shared Function GetExcelFile(ByVal strFileName As String, ByVal strPath As String) As DataTable

        Try

            Dim dt As New DataTable

            Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strPath & ";Extended Properties=""Text;HDR=Yes;FMT=Delimited\"""
            Dim conn As New OleDb.OleDbConnection(ConStr)
            Dim da As New OleDb.OleDbDataAdapter("Select * from " & strFileName, conn)
            da.Fill(dt)

            Return dt

        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Private Function GetOpenFileDialog() As OpenFileDialog

        Dim openFileDialog As New OpenFileDialog

        openFileDialog.CheckFileExists = True
        openFileDialog.Multiselect = False
        openFileDialog.AddExtension = True
        openFileDialog.ValidateNames = True
        openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

        Return openFileDialog


    End Function
    Private Sub cmd_Rule_Click(sender As Object, e As EventArgs) Handles cmd_Rule.Click
        Dim Value() As String

        Value = txt_MappingNo.Text.Split(";")


        If txt_MappingNo.Text <> "" Then
            If ISUD9001A.Link_ISUD9001A(3, Value(0), "") Then

            End If
        Else
            If ISUD9001A.Link_ISUD9001A(1, txt_CustomerCode.Code, "") Then

            End If

        End If


        Call DATA_SEARCH01()

    End Sub


    Private Sub cmd_ChkMaterial_Click(sender As Object, e As EventArgs)
        Dim i, j As Integer
        Dim L_7231 As New List(Of T7231_AREA)

        For i = 0 To VS3.ActiveSheet.RowCount - 1
            D7231_CLEAR()
            D7231.MaterialName = getData(VS3, getColumIndex(VS3, "MaterialName"), i)
            D7231.MaterialCode = getData(VS3, getColumIndex(VS3, "MaterialCode"), i)

            If D7231.MaterialName = "" Then GoTo next1
            If D7231.MaterialCode <> "" Then GoTo next1

            D7231.MaterialName = getData(VS3, getColumIndex(VS3, "MaterialName"), i)
            D7231.Width = getData(VS3, getColumIndex(VS3, "Width"), i)
            D7231.Height = getData(VS3, getColumIndex(VS3, "Height"), i)
            D7231.SizeName = getData(VS3, getColumIndex(VS3, "SizeName"), i)

            If L_7231.Count >= 1 Then
                For j = 0 To L_7231.Count - 1
                    If L_7231(j).MaterialName = D7231.MaterialName Then
                        GoTo next1
                    End If
                Next
            End If

            L_7231.Add(D7231)
next1:
        Next


        If ISUD7231P.Link_ISUD7231P_LIST("1", L_7231, "PFP71080") = False Then Exit Sub

        For i = 0 To VS3.ActiveSheet.RowCount - 1
            D7231.MaterialName = getData(VS3, getColumIndex(VS3, "MaterialName"), i)
            D7231.Width = getData(VS3, getColumIndex(VS3, "Width"), i)
            D7231.Height = getData(VS3, getColumIndex(VS3, "Height"), i)
            D7231.SizeName = getData(VS3, getColumIndex(VS3, "SizeName"), i)

            If READ_PFK7231_CHECKNAME(D7231.MaterialName, D7231.Width, D7231.Height, D7231.SizeName) Then
                setData(VS3, getColumIndex(VS3, "MaterialCode"), i, D7231.MaterialCode)
            End If
        Next


    End Sub

    Private Sub cmd_Link7235_Load(sender As Object, e As EventArgs) Handles cmd_Link7235.btnTitleClick
        If ISUD7235A.Link_ISUD7235A("3", "PFP71080") = False Then Exit Sub
    End Sub

    Private Sub VS3_KeyDown(sender As Object, e As KeyEventArgs) Handles VS3.KeyDown
        Dim xCOL As Long
        Dim xROW As Long
        xCOL = VS3.ActiveSheet.ActiveColumnIndex
        xROW = VS3.ActiveSheet.ActiveRowIndex

        Select Case e.KeyCode
            Case Keys.Delete

                Call Select_Message("3", WordConv("PROCESSING"), 2)

                If Msg_Result <> vbYes Then Exit Sub

                SPR_DEL(VS3, xCOL, xROW)
                VS3.ActiveSheet.ActiveColumnIndex = xCOL
                VS3.ActiveSheet.ActiveRowIndex = xROW
                VS3.Focus()

            Case Keys.Enter
                Select Case xCOL

                End Select
        End Select
    End Sub
#End Region

End Class