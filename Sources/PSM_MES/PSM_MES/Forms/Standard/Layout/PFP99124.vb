Public Class PFP99124

#Region "Variable"
    Private checkrn As Boolean = False
    Private W9916 As T9916_AREA
    Private M9911 As T9911_AREA
    Private formA As Boolean


#End Region

#Region "Form_load"
    Public Function Link_ISUD_P_FORM_USER(job As Integer, _proname1 As String, Optional CheckName As String = "") As Boolean
        Me.Tag = CheckName
        txt_Program.Data = _proname1
        Link_ISUD_P_FORM_USER = False

        formA = False
        Me.ShowDialog()

        Link_ISUD_P_FORM_USER = isudCHK
    End Function
    Private Sub SPREAD_SETUP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_int()
        data_int()

        Call DATA_SEARCH_HEAD()
        Call DATA_SEARCH_VS0()

    End Sub
    Private Sub form_int()

    End Sub
    Private Sub data_int()

    End Sub
#End Region
    Private Function DATA_SEARCH_HEAD() As Boolean
        DATA_SEARCH_HEAD = False

        Try
            DS1 = READ_PFK9703(txt_Program.Data, cn)

            If GetDsRc(DS1) = 0 Then Exit Function

            Call READER_MOVE(Me, DS1)
            DATA_SEARCH_HEAD = True

        Catch ex As Exception

        End Try


    End Function

    Private Function DATA_SEARCH_VS0(Optional ByVal xsort As String = "1") As Boolean

        DATA_SEARCH_VS0 = False

        vS0.Enabled = False

        DS1 = PrcDS("USP_ISUD9702_SEARCH_VS0", cn,
        txt_Table1.Data,
        txt_Table2.Data,
        txt_Table3.Data,
        txt_Table4.Data,
        txt_Table5.Data,
        txt_Table6.Data,
        txt_Table7.Data,
        txt_Table8.Data,
        txt_Table9.Data,
        txt_Table10.Data,
        txt_Table11.Data,
        txt_Table12.Data)

        If GetDsRc(DS1) = 0 Then
            SPR_PRO_NEW(vS0, DS1, "USP_ISUD9702_SEARCH_VS0", "VS0")
            vS0.Enabled = True

            Exit Function
        End If

        SPR_PRO_NEW(vS0, DS1, "USP_ISUD9702_SEARCH_VS0", "VS0")
        DATA_SEARCH_VS0 = True

        vS0.Enabled = True
    End Function


#Region "Event"

#End Region


    Private Sub cmdBtn2_Click(sender As Object, e As EventArgs) Handles cmdBtn2.Click
        If READ_PFK9916_2(txt_Program.Data) Then
            If DELETE_PFK9916_1(D9916) Then
                Me.Dispose()
            End If
        End If
    End Sub
    Private W9702 As T9702_AREA
    Private W9703 As T9703_AREA
    Private Sub cmd_Loading_Click(sender As Object, e As EventArgs) Handles cmd_Loading.Click
        If K9703_MOVE(Me, W9703, 1, txt_Program.Data) = False Then
            W9703.ProgramNo = txt_Program.Data
            Call WRITE_PFK9703(W9703)
        Else
            Call REWRITE_PFK9703(W9703)
        End If

        Call DATA_SEARCH_HEAD()
        Call DATA_SEARCH_VS0()

    End Sub


    Private Sub Create_New()

        If Pub.DEVCHK <> "1" Then Exit Sub

        Dim StrMsg As String = MsgBox("Do you want to create new form user?", vbYesNo)
        If StrMsg <> vbYes Then Exit Sub

        Dim Children As New List(Of System.Windows.Forms.Control)
        Dim str As String = ""

        Dim i As Integer
        Dim DSNEW As New DataSet
        Try
            Dim f As Form
            Dim FullTypeName As String
            FullTypeName = "PSMGlobal" & "." & txt_Program.Data
            Dim objType As Type = Type.[GetType](FullTypeName)

            f = DirectCast(Activator.CreateInstance(objType), Form)

            Children = f.FindAllChildren

            For i = 0 To Children.Count - 1
                Dim CheckType As String = Children(i).GetType.ToString.ToUpper

                If TypeOf (Children(i)) Is SelectPeaceHLPButton Or CheckType.Contains("SELECT") Or CheckType.Contains("RADIOBUTTON") Or CheckType.Contains("CHECKBOX") Then
                    If Children(i).Name.Length > 5 Then
                        If READ_PFK9916_1(txt_Program.Data, Mid(Children(i).Name, 5)) = False Then
next1:
                            If READ_PFK9911(Mid(Children(i).Name, 5)) Then
                                If READ_PFK9916_3(Mid(Children(i).Name, 5)) Then
                                    D9916.CheckDev = D9916.CheckDev
                                    D9916.REMK = D9916.REMK
                                Else
                                    D9916.CheckDev = D9911.CheckDev
                                    D9916.REMK = D9911.REMK
                                End If
                                D9916.ProgramNo = txt_Program.Data
                                D9916.ItemCode = D9911.ItemCode
                                D9916.ItemName = D9911.ItemName
                                D9916.ItemNameSimply = D9911.ItemNameSimply
                                D9916.ItemNameForeign1 = D9911.ItemNameForeign1
                                D9916.ItemNameForeign2 = D9911.ItemNameForeign2
                                D9916.ProdjectName = D9911.ProdjectName
                                D9916.DataType = D9911.DataType
                                D9916.DataSize = D9911.DataSize
                                D9916.DataDecimal = D9911.DataDecimal
                                D9916.TextAlign = D9911.TextAlign
                                D9916.HorizontalAlignment = D9911.HorizontalAlignment
                                D9916.VerticalAlignment = D9911.VerticalAlignment
                                D9916.SizeWidth = D9911.SizeWidth
                                D9916.SizeHeight = D9911.SizeHeight
                                D9916.BackColot = D9911.BackColot
                                D9916.ForeColor = D9911.ForeColor
                                D9916.FontName = D9911.FontName
                                D9916.FontSize = D9911.FontSize
                                D9916.FontBold = D9911.FontBold
                                D9916.Lock = D9911.Lock
                                D9916.Hidden = D9911.Hidden
                                D9916.CheckMerge = D9911.CheckMerge
                                D9916.CheckMergePolicy = D9911.CheckMergePolicy
                                D9916.CheckHead = D9911.CheckHead
                                D9916.CheckHeadType = D9911.CheckHeadType

                                Call WRITE_PFK9916(D9916)

                            Else
                                M9911 = D9911
                                M9911.ItemName = Mid(Children(i).Name, 5)
                                M9911.ItemCode = key_count()
                                M9911.ItemNameSimply = Mid(Children(i).Name, 5)
                                M9911.ItemNameForeign1 = Mid(Children(i).Name, 5)
                                M9911.ItemNameForeign2 = Mid(Children(i).Name, 5)
                                M9911.ProdjectName = "DMS"
                                M9911.DataType = 0
                                M9911.DataSize = 100
                                M9911.DataDecimal = 2
                                M9911.TextAlign = 2
                                M9911.HorizontalAlignment = 2
                                M9911.VerticalAlignment = 2
                                M9911.SizeWidth = 100
                                M9911.SizeHeight = 30
                                M9911.BackColot = "255-255-255"
                                M9911.ForeColor = "0-0-0"
                                M9911.FontName = "Tahoma"
                                M9911.FontSize = "9.00"
                                M9911.FontBold = "0"
                                M9911.Lock = "1"
                                M9911.Hidden = "1"

                                M9911.REMK = ""

                                If WRITE_PFK9911(M9911) = True Then
                                    GoTo next1
                                End If
                            End If
                        End If

                    End If

                End If

                If TypeOf (Children(i)) Is SelectPeaceHLPButton_New Then
                    If Children(i).Name.Length > 5 Then
                        If READ_PFK9916_1(txt_Program.Data, Mid(Children(i).Name, 5)) = False Then
nextZ:
                            If READ_PFK9911(Mid(Children(i).Name, 5)) Then
                                If READ_PFK9916_3(Mid(Children(i).Name, 5)) Then
                                    D9916.CheckDev = D9916.CheckDev
                                    D9916.REMK = D9916.REMK
                                Else
                                    D9916.CheckDev = D9911.CheckDev
                                    D9916.REMK = D9911.REMK
                                End If
                                D9916.ProgramNo = txt_Program.Data
                                D9916.ItemCode = D9911.ItemCode
                                D9916.ItemName = D9911.ItemName
                                D9916.ItemNameSimply = D9911.ItemNameSimply
                                D9916.ItemNameForeign1 = D9911.ItemNameForeign1
                                D9916.ItemNameForeign2 = D9911.ItemNameForeign2
                                D9916.ProdjectName = D9911.ProdjectName
                                D9916.DataType = D9911.DataType
                                D9916.DataSize = D9911.DataSize
                                D9916.DataDecimal = D9911.DataDecimal
                                D9916.TextAlign = D9911.TextAlign
                                D9916.HorizontalAlignment = D9911.HorizontalAlignment
                                D9916.VerticalAlignment = D9911.VerticalAlignment
                                D9916.SizeWidth = D9911.SizeWidth
                                D9916.SizeHeight = D9911.SizeHeight
                                D9916.BackColot = D9911.BackColot
                                D9916.ForeColor = D9911.ForeColor
                                D9916.FontName = D9911.FontName
                                D9916.FontSize = D9911.FontSize
                                D9916.FontBold = D9911.FontBold
                                D9916.Lock = D9911.Lock
                                D9916.Hidden = D9911.Hidden
                                D9916.CheckMerge = D9911.CheckMerge
                                D9916.CheckMergePolicy = D9911.CheckMergePolicy
                                D9916.CheckHead = D9911.CheckHead
                                D9916.CheckHeadType = D9911.CheckHeadType

                                Call WRITE_PFK9916(D9916)

                            Else

                                M9911 = D9911
                                M9911.ItemName = Mid(Children(i).Name, 5)
                                M9911.ItemCode = key_count()
                                M9911.ItemNameSimply = Mid(Children(i).Name, 5)
                                M9911.ItemNameForeign1 = Mid(Children(i).Name, 5)
                                M9911.ItemNameForeign2 = Mid(Children(i).Name, 5)
                                M9911.ProdjectName = "DMS"
                                M9911.DataType = 0
                                M9911.DataSize = 100
                                M9911.DataDecimal = 2
                                M9911.TextAlign = 2
                                M9911.HorizontalAlignment = 2
                                M9911.VerticalAlignment = 2
                                M9911.SizeWidth = 100
                                M9911.SizeHeight = 30
                                M9911.BackColot = "255-255-255"
                                M9911.ForeColor = "0-0-0"
                                M9911.FontName = "Tahoma"
                                M9911.FontSize = "9.00"
                                M9911.FontBold = "0"
                                M9911.Lock = "1"
                                M9911.Hidden = "1"

                                M9911.REMK = ""

                                If WRITE_PFK9911(M9911) = True Then
                                    GoTo nextZ
                                End If
                            End If
                        End If

                    End If

                End If

                If TypeOf (Children(i)) Is PeaceFarpoint Then
                    If Children(i).Name.Length > 2 Then
                        If READ_PFK9916_1(txt_Program.Data, Children(i).Name) = False Then
next2:
                            If READ_PFK9911(Children(i).Name) Then
                                D9916.ProgramNo = txt_Program.Data
                                D9916.ItemCode = D9911.ItemCode
                                D9916.ItemName = D9911.ItemName
                                D9916.ItemNameSimply = D9911.ItemNameSimply
                                D9916.ItemNameForeign1 = D9911.ItemNameForeign1
                                D9916.ItemNameForeign2 = D9911.ItemNameForeign2
                                D9916.ProdjectName = D9911.ProdjectName
                                D9916.DataType = D9911.DataType
                                D9916.DataSize = D9911.DataSize
                                D9916.DataDecimal = D9911.DataDecimal
                                D9916.TextAlign = D9911.TextAlign
                                D9916.HorizontalAlignment = D9911.HorizontalAlignment
                                D9916.VerticalAlignment = D9911.VerticalAlignment
                                D9916.SizeWidth = D9911.SizeWidth
                                D9916.SizeHeight = D9911.SizeHeight
                                D9916.BackColot = D9911.BackColot
                                D9916.ForeColor = D9911.ForeColor
                                D9916.FontName = D9911.FontName
                                D9916.FontSize = D9911.FontSize
                                D9916.FontBold = D9911.FontBold
                                D9916.Lock = D9911.Lock
                                D9916.Hidden = D9911.Hidden
                                D9916.CheckMerge = D9911.CheckMerge
                                D9916.CheckMergePolicy = D9911.CheckMergePolicy
                                D9916.CheckHead = D9911.CheckHead
                                D9916.CheckHeadType = D9911.CheckHeadType
                                D9916.CheckDev = D9911.CheckDev
                                D9916.REMK = D9911.REMK
                                Call WRITE_PFK9916(D9916)

                            Else

                                M9911 = D9911
                                M9911.ItemName = Children(i).Name
                                M9911.ItemCode = key_count()
                                M9911.ItemNameSimply = Children(i).Name
                                M9911.ItemNameForeign1 = Children(i).Name
                                M9911.ItemNameForeign2 = Children(i).Name
                                M9911.ProdjectName = "DMS"
                                M9911.DataType = 0
                                M9911.DataSize = 100
                                M9911.DataDecimal = 2
                                M9911.TextAlign = 2
                                M9911.HorizontalAlignment = 2
                                M9911.VerticalAlignment = 2
                                M9911.SizeWidth = 100
                                M9911.SizeHeight = 30
                                M9911.BackColot = "255-255-255"
                                M9911.ForeColor = "0-0-0"
                                M9911.FontName = "Tahoma"
                                M9911.FontSize = "9.00"
                                M9911.FontBold = "0"
                                M9911.Lock = "1"
                                M9911.Hidden = "1"

                                If M9911.ItemName.Contains("Amount") Or M9911.ItemName.Contains("amount") _
                                  Or M9911.ItemName.Contains("Price") _
                                 Or M9911.ItemName.Contains("price") _
                                  Or M9911.ItemName.Contains("quantity") _
                                  Or M9911.ItemName.Contains("Balance") _
                                  Or M9911.ItemName.Contains("balance") _
                                  Or M9911.ItemName.Contains("Qty") _
                                  Or M9911.ItemName.Contains("qty") _
                                   Or M9911.ItemName.Contains("Quantity") Then
                                    M9911.DataType = 1
                                    M9911.HorizontalAlignment = 3
                                End If

                                M9911.REMK = ""
                                If WRITE_PFK9911(M9911) = True Then
                                    GoTo next2
                                End If
                            End If
                        End If

                    End If

                End If
            Next

        Catch ex As Exception

        End Try

    End Sub
    Private Function key_count() As String
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        SQL = "SELECT MAX(CAST(K9911_ItemCode AS DECIMAL)) AS MAX_CODE FROM PFK9911 "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            key_count = "000001"
        Else
            key_count = Format(CInt(rd!MAX_CODE + 1), "000000")
        End If
        rd.Close()
    End Function


    Private Sub cmd_SaveLayout_Click(sender As Object, e As EventArgs) Handles cmd_SaveLayout.Click
        Dim i As Integer

        If Trim(txt_Program.Data) = "" Then MsgBoxP("Check form name!") : Exit Sub

        Try
            Call DELETE_PFK9702_ALL(W9702.FormName, W9702.User)

            For i = 0 To vS0.ActiveSheet.RowCount - 1
                W9702 = D9702
                W9702.FormName = txt_Program.Data
                W9702.User = Pub.SAW
                W9702.ItemName = getData(vS0, getColumIndex(vS0, "ItemName"), i)
                W9702.ControlName = Mid(W9702.ItemName, 7)
                W9702.ControlData1 = Mid(W9702.ItemName, 7)
                W9702.CreateDate = Pub.DAT
                Call WRITE_PFK9702(W9702)
            Next

            Me.Dispose()
        Catch ex As Exception

        End Try
    End Sub

End Class