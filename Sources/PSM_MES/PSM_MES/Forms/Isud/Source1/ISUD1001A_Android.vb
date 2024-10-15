Public Class ISUD1001A_Android

#Region "Variable"
    Private wJOB As Integer

    Private WRITE_CHK As String
    Private KEY_CHK As String

    Private W7171 As T7171_AREA
    Private L7171 As T7171_AREA

    Private formA As Boolean
    Private CHK(0 To 5) As String
#End Region

#Region "Link"
    Public Function Link_ISUD1001A_Android(job As Integer, Optional ByVal TAG As String = "") As Boolean

        formA = False
        Me.Tag = TAG
        Me.ShowDialog()

        Link_ISUD1001A_Android = isudCHK
    End Function

#End Region

#Region "Form_Load"
    Private Sub Form_Activate(sender As Object, e As EventArgs) Handles Me.Load
        If formA = True Then Exit Sub

        WRITE_CHK = ""



        formA = True
    End Sub

    Private Sub Me_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If Me.Width > 30 Then
            ItemMain.ItemSize = New Size((Me.Width - 30) / ItemMain.TabCount, 25)
        End If
    End Sub

    Private Sub DATA_INIT()

    End Sub

    Private Sub FORM_INIT()

    End Sub

#End Region

#Region "Function"
#Region "Form"
    Private Sub SetFormCheckUse(CheckUse As String)
        Try
            Select Case CheckUse
                Case "1"
                    rad_CheckUseForm1.Checked = True
                    rad_CheckUseForm2.Checked = False
                Case "2"
                    rad_CheckUseForm1.Checked = False
                    rad_CheckUseForm2.Checked = True
                Case Else

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Function getFormCheckUse() As String
        getFormCheckUse = ""
        Try
            If rad_CheckUseForm1.Checked Then getFormCheckUse = "1"
            If rad_CheckUseForm2.Checked Then getFormCheckUse = "2"

        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Stored Procedure"
    Private Sub SetStoredProcedureCheckUse(CheckUse As String)
        Try
            Select Case CheckUse
                Case "1"
                    rad_CheckUseStoredProcedure1.Checked = True
                    rad_CheckUseStoredProcedure2.Checked = False
                Case "2"
                    rad_CheckUseStoredProcedure1.Checked = False
                    rad_CheckUseStoredProcedure2.Checked = True
                Case Else

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Function getStoredProcedureCheckUse() As String
        getStoredProcedureCheckUse = ""
        Try
            If rad_CheckUseStoredProcedure1.Checked Then getStoredProcedureCheckUse = "1"
            If rad_CheckUseStoredProcedure2.Checked Then getStoredProcedureCheckUse = "2"

        Catch ex As Exception

        End Try
    End Function

    Private Sub SetStoredProcedureIsDetail(IsDetail As String)
        Try
            Select Case IsDetail
                Case "1"
                    rad_IsDetailStoredProcedure1.Checked = True
                    rad_IsDetailStoredProcedure2.Checked = False
                Case "2"
                    rad_IsDetailStoredProcedure1.Checked = False
                    rad_IsDetailStoredProcedure2.Checked = True
                Case Else

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Function getStoredProcedureIsDetail() As String
        getStoredProcedureIsDetail = ""
        Try
            If rad_IsDetailStoredProcedure1.Checked Then getStoredProcedureIsDetail = "1"
            If rad_IsDetailStoredProcedure2.Checked Then getStoredProcedureIsDetail = "2"

        Catch ex As Exception

        End Try
    End Function
#End Region

#Region "Template"
    Private Sub SetTemplateCheckUse(CheckUse As String)
        Try
            Select Case CheckUse
                Case "1"
                    rad_CheckUseTemplate1.Checked = True
                    rad_CheckUseTemplate2.Checked = False
                Case "2"
                    rad_CheckUseTemplate1.Checked = False
                    rad_CheckUseTemplate2.Checked = True
                Case Else

            End Select

        Catch ex As Exception

        End Try
    End Sub

    Private Function getTemplateCheckUse() As String
        getTemplateCheckUse = ""
        Try
            If rad_CheckUseTemplate1.Checked Then getTemplateCheckUse = "1"
            If rad_CheckUseTemplate2.Checked Then getTemplateCheckUse = "2"

        Catch ex As Exception

        End Try
    End Function
#End Region

#End Region

#Region "DATA_SEARCH"
#Region "Form"
    Private Function DATA_SEARCH10() As Boolean
        DATA_SEARCH10 = False
        Try
            Vs10.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS10", cn, "", "")

            If GetDsRc(DS1) = 0 Then
                Vs10.Enabled = True
                Vs10.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs10, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS10", "Vs10")

            Vs10.Enabled = True
            DATA_SEARCH10 = True
        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH10(DateForm As String, SeqForm As String) As Boolean
        DATA_SEARCH10 = False
        Try
            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS10", cn, DateForm, SeqForm)

            If GetDsRc(DS1) = 0 Then Exit Function

            txt_DateForm.Data = GetDsData(DS1, 0, "Key_DateForm")
            txt_SeqForm.Data = GetDsData(DS1, 0, "Key_SeqForm")

            txt_cdSiteForm.Code = GetDsData(DS1, 0, "Key_cdSite")
            txt_cdSiteForm.Data = GetDsData(DS1, 0, "SiteName")

            txt_cdSubProcessForm.Code = GetDsData(DS1, 0, "Key_cdSubProcess")
            txt_cdSubProcessForm.Data = GetDsData(DS1, 0, "SubProcessName")

            txt_NameForm.Data = GetDsData(DS1, 0, "NameForm")
            txt_SimplyForm.Data = GetDsData(DS1, 0, "FormSimply")

            SetFormCheckUse(GetDsData(DS1, 0, "CheckUse"))

            txt_RemarkForm.Data = GetDsData(DS1, 0, "Remark")

            DATA_SEARCH10 = True
        Catch ex As Exception

        End Try
    End Function

    Private Sub SaveForm()
        Try
            Dim DateForm As String = ""
            Dim SeqForm As String = ""
            Dim seSiteForm As String = ""
            Dim cdSiteForm As String = ""
            Dim seSubProcessForm As String = ""
            Dim cdSubProcessForm As String = ""
            Dim NameForm As String = ""
            Dim SimplyForm As String = ""
            Dim CheckUse As String = ""
            Dim RemarkForm As String = ""
            Dim IDNO As String = ""

            Dim TypeResult As String = ""
            Dim MesResult As String = ""

            DateForm = txt_DateForm.Data
            SeqForm = txt_SeqForm.Data
            seSiteForm = "471"
            cdSiteForm = txt_cdSiteForm.Code
            seSubProcessForm = "002"
            cdSubProcessForm = txt_cdSubProcessForm.Code
            NameForm = txt_NameForm.Data
            SimplyForm = txt_SimplyForm.Data
            RemarkForm = txt_RemarkForm.Data
            CheckUse = getFormCheckUse()
            IDNO = Pub.SAW

            DS1 = PrcDS("PSM_USP_ISUD1001A_PRI1001_Android", cn, DateForm, SeqForm, _
                        seSiteForm, cdSiteForm, _
                        "*" + NameForm, "*" + SimplyForm, CheckUse, "*" + RemarkForm, _
                        seSubProcessForm, cdSubProcessForm, IDNO)

            If GetDsRc(DS1) > 0 Then
                TypeResult = GetDsData(DS1, 0, "TypeResult")
                MesResult = GetDsData(DS1, 0, "MesResult")
            End If

            MsgBoxP(MesResult)

            If TypeResult = "1" Then
                ClearForm()
                DATA_SEARCH10()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearForm()
        Try
            txt_DateForm.Data = System_Date_8()
            txt_SeqForm.Data = ""
            txt_cdSiteForm.Data = ""
            txt_cdSiteForm.Code = "471"
            txt_cdSubProcessForm.Data = ""
            txt_cdSubProcessForm.Code = "002"
            txt_NameForm.Data = ""
            txt_SimplyForm.Data = ""
            txt_RemarkForm.Data = ""

            txt_NameForm.Focus()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Stored Procedure"
    Private Function DATA_SEARCH21() As Boolean
        DATA_SEARCH21 = False
        Try
            Vs21.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS21", cn, "", "")

            If GetDsRc(DS1) = 0 Then
                Vs21.Enabled = True
                Vs21.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs21, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS21", "Vs21")

            Vs21.Enabled = True
            DATA_SEARCH21 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH21(DateStoredProcedure As String, SeqStoredProcedure As String) As Boolean
        DATA_SEARCH21 = False
        Try
            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS21", cn, DateStoredProcedure, SeqStoredProcedure)

            If GetDsRc(DS1) = 0 Then Exit Function

            txt_DateStoredProcedure.Data = GetDsData(DS1, 0, "Key_DateStoredProcedure")
            txt_SeqStoredProcedure.Data = GetDsData(DS1, 0, "Key_SeqStoredProcedure")

            txt_cdSiteStoredProcedure.Code = GetDsData(DS1, 0, "Key_cdSite")
            txt_cdSiteStoredProcedure.Data = GetDsData(DS1, 0, "SiteName")

            txt_cdSubProcessStoredProcedure.Code = GetDsData(DS1, 0, "Key_cdSubProcess")
            txt_cdSubProcessStoredProcedure.Data = GetDsData(DS1, 0, "SubProcessName")

            txt_NameStoredProcedure.Data = GetDsData(DS1, 0, "NameStoredProcedure")
            txt_SimplyStoredProcedure.Data = GetDsData(DS1, 0, "StoredProcedureSimply")

            SetStoredProcedureCheckUse(GetDsData(DS1, 0, "CheckUse"))
            SetStoredProcedureIsDetail(GetDsData(DS1, 0, "IsDetail"))

            txt_RemarkStoredProcedure.Data = GetDsData(DS1, 0, "Remark")
            DATA_SEARCH21 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH20(DateStoredProcedure As String, SeqStoredProcedure As String) As Boolean
        DATA_SEARCH20 = False
        Try
            Vs20.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS20", cn, DateStoredProcedure, SeqStoredProcedure)

            If GetDsRc(DS1) = 0 Then
                Vs20.Enabled = True
                Vs20.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs20, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS20", "Vs20")

            Vs20.Enabled = True
            DATA_SEARCH20 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH20(DateStoredProcedure As String, SeqStoredProcedure As String, StoredProcedureName As String) As Boolean
        DATA_SEARCH20 = False
        Try
            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS20", cn, DateStoredProcedure, SeqStoredProcedure)

            Dim DS_Parameter As New DataSet
            DS_Parameter = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS20_Parameter", cn, StoredProcedureName)

            Dim Parameter() As String

            ReDim Parameter(GetDsRc(DS_Parameter) - 1)

            For i As Integer = 0 To GetDsRc(DS_Parameter) - 1
                Parameter(i) = GetDsData(DS_Parameter, i, "DataCheck")
            Next

            Dim DS_Field As New DataSet
            DS_Field = PrcDS(StoredProcedureName, cn, Parameter)

            For i As Integer = 0 To GetDsCc(DS_Field) - 1
                Dim FieldColumn As String = DS_Field.Tables(0).Columns(i).ColumnName.ToString

                Dim CheckInsert As Boolean = True

                For iRow As Integer = 0 To GetDsRc(DS1) - 1
                    If GetDsData(DS1, iRow, "StoredProcedureSimply") = FieldColumn Then
                        CheckInsert = False
                        Exit For
                    End If
                Next
                If CheckInsert Then
                    Dim dr As DataRow = DS1.Tables(0).NewRow
                    dr("StoredProcedureSimply") = FieldColumn

                    DS1.Tables(0).Rows.Add(dr)
                End If

            Next

            SPR_PRO_NEW(Vs20, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS20", "Vs20")

            DATA_SEARCH20 = True
        Catch ex As Exception

        End Try
    End Function

    Private Sub SaveStoredProcedure()
        Try
            Dim DateStoredProcedure As String = ""
            Dim SeqStoredProcedure As String = ""
            Dim seSiteStoredProcedure As String = ""
            Dim cdSiteStoredProcedure As String = ""
            Dim seSubProcessStoredProcedure As String = ""
            Dim cdSubProcessStoredProcedure As String = ""
            Dim NameStoredProcedure As String = ""
            Dim SimplyStoredProcedure As String = ""
            Dim RemarkStoredProcedure As String = ""
            Dim CheckUse As String = ""
            Dim IsDetail As String = ""
            Dim IDNO As String = ""

            Dim TypeResult As String = ""
            Dim MesResult As String = ""

            DateStoredProcedure = txt_DateStoredProcedure.Data
            SeqStoredProcedure = txt_SeqStoredProcedure.Data
            seSiteStoredProcedure = "471"
            cdSiteStoredProcedure = txt_cdSiteStoredProcedure.Code
            seSubProcessStoredProcedure = "002"
            cdSubProcessStoredProcedure = txt_cdSubProcessStoredProcedure.Code
            NameStoredProcedure = txt_NameStoredProcedure.Data
            SimplyStoredProcedure = txt_SimplyStoredProcedure.Data
            RemarkStoredProcedure = txt_RemarkStoredProcedure.Data

            CheckUse = getStoredProcedureCheckUse()
            IsDetail = getStoredProcedureIsDetail()
            IDNO = Pub.SAW

            Dim dt As New DataTable("DS")

            dt.Columns.Add(New DataColumn("DateStoredProcedure"))
            dt.Columns.Add(New DataColumn("SeqStoredProcedure"))
            dt.Columns.Add(New DataColumn("FieldStoredProcedure"))
            dt.Columns.Add(New DataColumn("seSite"))
            dt.Columns.Add(New DataColumn("cdSite"))
            dt.Columns.Add(New DataColumn("seSubProcess"))
            dt.Columns.Add(New DataColumn("cdSubProcess"))
            dt.Columns.Add(New DataColumn("NameStoredProcedure"))
            dt.Columns.Add(New DataColumn("NameSimply"))
            dt.Columns.Add(New DataColumn("CheckUse"))
            dt.Columns.Add(New DataColumn("IsDetail"))
            dt.Columns.Add(New DataColumn("Remark"))

            For i As Integer = 0 To Vs20.ActiveSheet.RowCount - 1
                Dim dr As DataRow = dt.NewRow

                dr("DateStoredProcedure") = getData(Vs20, getColumIndex(Vs20, "Key_DateStoredProcedure"), i)
                dr("SeqStoredProcedure") = getData(Vs20, getColumIndex(Vs20, "Key_SeqStoredProcedure"), i)
                dr("FieldStoredProcedure") = getData(Vs20, getColumIndex(Vs20, "Key_FieldStoredProcedure"), i)
                dr("seSite") = getData(Vs20, getColumIndex(Vs20, "Key_seSite"), i)
                dr("cdSite") = getData(Vs20, getColumIndex(Vs20, "Key_cdSite"), i)
                dr("seSubProcess") = getData(Vs20, getColumIndex(Vs20, "Key_seSubProcess"), i)
                dr("cdSubProcess") = getData(Vs20, getColumIndex(Vs20, "Key_cdSubProcess"), i)

                dr("NameStoredProcedure") = getData(Vs20, getColumIndex(Vs20, "NameStoredProcedure"), i)
                dr("NameSimply") = getData(Vs20, getColumIndex(Vs20, "StoredProcedureSimply"), i)

                If Boolean.Parse(getData(Vs20, getColumIndex(Vs20, "CheckUse"), i)) Then
                    dr("CheckUse") = "1"
                Else
                    dr("CheckUse") = "2"
                End If

                'If Boolean.Parse(getData(Vs20, getColumIndex(Vs20, "IsDetail"), i)) Then
                '    dr("IsDetail") = "1"
                'Else
                '    dr("IsDetail") = "2"
                'End If
                dr("IsDetail") = "2"
                dr("Remark") = getData(Vs20, getColumIndex(Vs20, "Remark"), i)

                dt.Rows.Add(dr)

            Next


            Dim XMLOutput As String = ""
            Using sw As System.IO.StringWriter = New System.IO.StringWriter
                dt.WriteXml(sw)
                XMLOutput = sw.ToString()
            End Using

            If cn IsNot Nothing Then
                If cn.State = ConnectionState.Open Then

                    Dim SQL As String = String.Format("PSM_USP_ISUD1001A_PRI2001_Android")

                    rd = Nothing
                    cmd = Nothing
                    cmd = New SqlClient.SqlCommand
                    cmd.Connection = cn
                    cmd.CommandText = SQL

                    Dim parame(12) As SqlClient.SqlParameter
                    parame(0) = New SqlClient.SqlParameter("@DateStoredProcedure", DateStoredProcedure) : parame(0).SqlDbType = SqlDbType.Char
                    parame(1) = New SqlClient.SqlParameter("@SeqStoredProcedure", SeqStoredProcedure) : parame(1).SqlDbType = SqlDbType.Char

                    parame(2) = New SqlClient.SqlParameter("@seSite", seSiteStoredProcedure) : parame(2).SqlDbType = SqlDbType.Char
                    parame(3) = New SqlClient.SqlParameter("@cdSite", cdSiteStoredProcedure) : parame(3).SqlDbType = SqlDbType.Char

                    parame(4) = New SqlClient.SqlParameter("@NameStoredProcedure", NameStoredProcedure) : parame(4).SqlDbType = SqlDbType.NVarChar
                    parame(5) = New SqlClient.SqlParameter("@NameSimply", SimplyStoredProcedure) : parame(5).SqlDbType = SqlDbType.NVarChar

                    parame(6) = New SqlClient.SqlParameter("@CheckUse", CheckUse) : parame(6).SqlDbType = SqlDbType.Char
                    parame(7) = New SqlClient.SqlParameter("@IsDetail", IsDetail) : parame(7).SqlDbType = SqlDbType.Char

                    parame(8) = New SqlClient.SqlParameter("@Remark", RemarkStoredProcedure) : parame(8).SqlDbType = SqlDbType.NVarChar

                    parame(9) = New SqlClient.SqlParameter("@seSubProcess", seSubProcessStoredProcedure) : parame(9).SqlDbType = SqlDbType.Char
                    parame(10) = New SqlClient.SqlParameter("@cdSubProcess", cdSubProcessStoredProcedure) : parame(10).SqlDbType = SqlDbType.Char

                    parame(11) = New SqlClient.SqlParameter("@IDNO", IDNO) : parame(11).SqlDbType = SqlDbType.Char

                    parame(12) = New SqlClient.SqlParameter("@ListDetail", dt) : parame(12).SqlDbType = SqlDbType.Structured

                    cmd.Parameters.AddRange(parame)

                    cmd.CommandType = CommandType.StoredProcedure
                    rd = cmd.ExecuteReader
                    If rd.Read() Then
                        TypeResult = rd("TypeResult").ToString.Trim
                        MesResult = rd("MesResult").ToString.Trim
                        DateStoredProcedure = rd("DateStoredProcedure").ToString.Trim
                        SeqStoredProcedure = rd("SeqStoredProcedure").ToString.Trim

                    End If
                    rd.Close()

                End If
            End If

            MsgBoxP(MesResult)

            If TypeResult = "1" Then
                ClearStoredProcedure()
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearStoredProcedure()
        Try
            txt_DateStoredProcedure.Data = System_Date_8()
            txt_SeqStoredProcedure.Data = ""
            txt_cdSiteStoredProcedure.Data = ""
            txt_cdSiteStoredProcedure.Code = ""
            txt_cdSubProcessStoredProcedure.Data = ""
            txt_cdSubProcessStoredProcedure.Code = ""
            txt_NameStoredProcedure.Data = ""
            txt_SimplyStoredProcedure.Data = ""
            txt_RemarkStoredProcedure.Data = ""

            Vs20.ActiveSheet.Rows.Clear()

            txt_NameStoredProcedure.Focus()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Template"
    Private Function DATA_SEARCH30() As Boolean
        DATA_SEARCH30 = False
        Try
            Vs30.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS30", cn, "", "")

            If GetDsRc(DS1) = 0 Then
                Vs30.Enabled = True
                Vs30.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs30, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS30", "Vs30")

            Vs30.Enabled = True
            DATA_SEARCH30 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH30(DateTemplate As String, SeqTemplate As String) As Boolean
        DATA_SEARCH30 = False
        Try
            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS30", cn, DateTemplate, SeqTemplate)

            If GetDsRc(DS1) = 0 Then Exit Function

            txt_DateTemplate.Data = GetDsData(DS1, 0, "Key_DateTemplate")
            txt_SeqTemplate.Data = GetDsData(DS1, 0, "Key_SeqTemplate")

            txt_cdSiteTemplate.Code = GetDsData(DS1, 0, "Key_cdSite")
            txt_cdSiteTemplate.Data = GetDsData(DS1, 0, "SiteName")

            txt_cdSubProcessTemplate.Code = GetDsData(DS1, 0, "Key_cdSubProcess")
            txt_cdSubProcessTemplate.Data = GetDsData(DS1, 0, "SubProcessName")

            txt_NameTemplate.Data = GetDsData(DS1, 0, "NameTemplate")
            txt_SimplyTemplate.Data = GetDsData(DS1, 0, "TemplateSimply")

            SetTemplateCheckUse(GetDsData(DS1, 0, "CheckUse"))

            txt_RemarkTemplate.Data = GetDsData(DS1, 0, "Remark")

            DATA_SEARCH30 = True

        Catch ex As Exception

        End Try
    End Function

    Private Sub SaveTemplate()
        Try
            Dim DateTemplate As String = ""
            Dim SeqTemplate As String = ""
            Dim seSiteTemplate As String = ""
            Dim cdSiteTemplate As String = ""
            Dim seSubProcessTemplate As String = ""
            Dim cdSubProcessTemplate As String = ""
            Dim NameTemplate As String = ""
            Dim SimplyTemplate As String = ""
            Dim CheckUse As String = ""
            Dim RemarkTemplate As String = ""
            Dim IDNO As String = ""

            Dim TypeResult As String = ""
            Dim MesResult As String = ""

            DateTemplate = txt_DateTemplate.Data
            SeqTemplate = txt_SeqTemplate.Data
            seSiteTemplate = "471"
            cdSiteTemplate = txt_cdSiteTemplate.Code
            seSubProcessTemplate = "002"
            cdSubProcessTemplate = txt_cdSubProcessTemplate.Code
            NameTemplate = txt_NameTemplate.Data
            SimplyTemplate = txt_SimplyTemplate.Data
            RemarkTemplate = txt_RemarkTemplate.Data
            CheckUse = getTemplateCheckUse()
            IDNO = Pub.SAW

            DS1 = PrcDS("PSM_USP_ISUD1001A_PRI3001_Android", cn, DateTemplate, SeqTemplate, _
                        seSiteTemplate, cdSiteTemplate, _
                        "*" + NameTemplate, "*" + SimplyTemplate, CheckUse, "*" + RemarkTemplate, _
                        seSubProcessTemplate, cdSubProcessTemplate, IDNO)

            If GetDsRc(DS1) > 0 Then
                TypeResult = GetDsData(DS1, 0, "TypeResult")
                MesResult = GetDsData(DS1, 0, "MesResult")
            End If

            MsgBoxP(MesResult)

            If TypeResult = "1" Then
                ClearTemplate()
                DATA_SEARCH30()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ClearTemplate()
        Try
            txt_DateTemplate.Data = System_Date_8()
            txt_SeqTemplate.Data = ""
            txt_cdSiteTemplate.Data = ""
            txt_cdSiteTemplate.Code = ""
            txt_cdSubProcessTemplate.Data = ""
            txt_cdSubProcessTemplate.Code = ""
            txt_NameTemplate.Data = ""
            txt_SimplyTemplate.Data = ""
            txt_RemarkTemplate.Data = ""

            txt_NameTemplate.Focus()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Map Template And Form"
    Private Function DATA_SEARCH40() As Boolean
        DATA_SEARCH40 = False
        Try
            Vs40.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS40", cn, "", "")

            If GetDsRc(DS1) = 0 Then
                Vs40.Enabled = True
                Vs40.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs40, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS40", "Vs40")

            Vs40.Enabled = True
            DATA_SEARCH40 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH41(DateTemplate As String, SeqTemplate As String) As Boolean
        DATA_SEARCH41 = False
        Try
            Vs41.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS41", cn, DateTemplate, SeqTemplate)

            If GetDsRc(DS1) = 0 Then
                Vs41.Enabled = True
                Vs41.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs41, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS41", "Vs41")

            Vs41.Enabled = True
            DATA_SEARCH41 = True

        Catch ex As Exception

        End Try
    End Function

    Private Sub SaveMapTemplateAndForm()
        Try
            Dim DateTemplate As String = "", SeqTemplate As String = "", DateForm As String = "", SeqForm As String = "", IDNO As String = ""
            IDNO = Pub.SAW
            Try
                For i As Integer = 0 To Vs41.ActiveSheet.RowCount - 1
                    If Boolean.Parse(getData(Vs41, getColumIndex(Vs41, "CheckUse"), i)) Then
                        DateTemplate = getData(Vs41, getColumIndex(Vs41, "Key_DateTemplate"), i)
                        SeqTemplate = getData(Vs41, getColumIndex(Vs41, "Key_SeqTemplate"), i)
                        DateForm = getData(Vs41, getColumIndex(Vs41, "Key_DateForm"), i)
                        SeqForm = getData(Vs41, getColumIndex(Vs41, "Key_SeqForm"), i)

                        DS1 = PrcDS("PSM_USP_ISUD1001A_PRI3002_Android", cn, DateTemplate, SeqTemplate, DateForm, SeqForm, IDNO)
                    End If
                Next

                MsgBoxP("Lưu thành công")
            Catch ex As Exception
                MsgBoxP("Lưu thất bại")
            End Try
        Catch ex As Exception
            MsgBoxP("Lưu thất bại")
        End Try
    End Sub
#End Region

#Region "Map Template And Stored Procedure"
    Private Function DATA_SEARCH50() As Boolean
        DATA_SEARCH50 = False
        Try
            Vs50.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS50", cn, "", "")

            If GetDsRc(DS1) = 0 Then
                Vs50.Enabled = True
                Vs50.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs50, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS50", "Vs50")

            Vs50.Enabled = True
            DATA_SEARCH50 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH51(DateTemplate As String, SeqTemplate As String) As Boolean
        DATA_SEARCH51 = False
        Try
            Vs51.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS51", cn, DateTemplate, SeqTemplate)

            If GetDsRc(DS1) = 0 Then
                Vs51.Enabled = True
                Vs51.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs51, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS51", "Vs51")

            Vs51.Enabled = True
            DATA_SEARCH51 = True

        Catch ex As Exception

        End Try
    End Function

    Private Sub SaveMapTemplateAndStoredProcedure()
        Try
            Dim DateTemplate As String = "", SeqTemplate As String = "", DateStoredProcedure As String = ""
            Dim SeqStoredProcedure As String = "", IDNO As String = "", Posion As Integer = 0
            IDNO = Pub.SAW
            Try

                For i As Integer = 0 To Vs51.ActiveSheet.RowCount - 1
                    If Boolean.Parse(getData(Vs51, getColumIndex(Vs51, "CheckUse"), i)) Then
                        DateTemplate = getData(Vs51, getColumIndex(Vs51, "Key_DateTemplate"), i)
                        SeqTemplate = getData(Vs51, getColumIndex(Vs51, "Key_SeqTemplate"), i)
                        DateStoredProcedure = getData(Vs51, getColumIndex(Vs51, "Key_DateStoredProcedure"), i)
                        SeqStoredProcedure = getData(Vs51, getColumIndex(Vs51, "Key_SeqStoredProcedure"), i)
                        Posion = Integer.Parse(getData(Vs51, getColumIndex(Vs51, "Posion"), i))

                        DS1 = PrcDS("PSM_USP_ISUD1001A_PRI3003_Android", cn, DateTemplate, SeqTemplate, DateStoredProcedure, SeqStoredProcedure, Posion, IDNO)
                    End If
                Next

                MsgBoxP("Lưu thành công")
            Catch ex As Exception
                MsgBoxP("Lưu thất bại")
            End Try
        Catch ex As Exception
            MsgBoxP("Lưu thất bại")
        End Try
    End Sub
#End Region

#Region "Design Template Print"
    Private Function DATA_SEARCH60() As Boolean
        DATA_SEARCH60 = False
        Try
            Vs60.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS60", cn, "", "")

            If GetDsRc(DS1) = 0 Then
                Vs60.Enabled = True
                Vs60.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs60, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS60", "Vs60")

            Vs60.Enabled = True
            DATA_SEARCH60 = True

        Catch ex As Exception

        End Try
    End Function

    Private Function DATA_SEARCH61(DateForm As String, SeqForm As String, DateTemplate As String, SeqTemplate As String, DateStoredProcedure As String, SeqStoredProcedure As String) As Boolean
        DATA_SEARCH61 = False
        Try
            Vs61.Enabled = False

            DS1 = PrcDS("PSM_USP_ISUD1001A_Android_SEARCH_VS61", cn, DateForm, SeqForm, DateTemplate, SeqTemplate, DateStoredProcedure, SeqStoredProcedure)

            If GetDsRc(DS1) = 0 Then
                Vs61.Enabled = True
                Vs61.ActiveSheet.RowCount = 0
            End If

            SPR_PRO_NEW(Vs61, DS1, "PSM_USP_ISUD1001A_Android_SEARCH_VS61", "Vs61")

            Vs61.Enabled = True
            DATA_SEARCH61 = True

        Catch ex As Exception

        End Try
    End Function
    Private Sub SaveDesignTemplatePrint()
        Try
            Dim DateTemplate As String = ""
            Dim SeqTemplate As String = ""
            Dim DateStoredProcedure As String = ""
            Dim SeqStoredProcedure As String = ""
            Dim StoredProcedureFielName As String = ""

            Dim Posion As Integer = 0

            Dim TypePrint As String = ""

            Dim TypeFace As String = ""

            Dim TypeAlignment As String = ""

            Dim CntLineEnter As Integer = 0

            Dim CntTextFontSize As Integer = 0
            Dim TypeTextFontBold As String = ""
            Dim TypeTextUnderLine As String = ""

            Dim CntBarSymbology As Integer = 0
            Dim CntBarHeight As Integer = 0
            Dim CntBarWidth As Integer = 0
            Dim CntBarTextposition As Integer = 0

            Dim CntQRModulesize As Integer = 0
            Dim CntQRErrorlevel As Integer = 0

            Dim Content As String = ""
            Dim IDNO As String = ""


            IDNO = Pub.SAW

            Try
                For Irow As Integer = 0 To Vs61.ActiveSheet.RowCount - 1
                    DateTemplate = getData(Vs61, getColumIndex(Vs61, "Key_DateTemplate"), Irow).ToString
                    SeqTemplate = getData(Vs61, getColumIndex(Vs61, "Key_SeqTemplate"), Irow).ToString
                    DateStoredProcedure = getData(Vs61, getColumIndex(Vs61, "Key_DateStoredProcedure"), Irow).ToString
                    SeqStoredProcedure = getData(Vs61, getColumIndex(Vs61, "Key_SeqStoredProcedure"), Irow).ToString
                    StoredProcedureFielName = getData(Vs61, getColumIndex(Vs61, "Key_StoredProcedureFielName"), Irow).ToString

                    Posion = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "Posion"), Irow).ToString)

                    TypePrint = getData(Vs61, getColumIndex(Vs61, "TypePrint"), Irow).ToString

                    TypeFace = getData(Vs61, getColumIndex(Vs61, "TypeFace"), Irow).ToString

                    TypeAlignment = getData(Vs61, getColumIndex(Vs61, "TypeAlignment"), Irow).ToString

                    CntLineEnter = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntLineEnter"), Irow).ToString)

                    CntTextFontSize = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntTextFontSize"), Irow).ToString)
                    TypeTextFontBold = getData(Vs61, getColumIndex(Vs61, "TypeTextFontBold"), Irow).ToString
                    TypeTextUnderLine = getData(Vs61, getColumIndex(Vs61, "TypeTextUnderLine"), Irow).ToString

                    CntBarSymbology = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntBarSymbology"), Irow).ToString)
                    CntBarHeight = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntBarHeight"), Irow).ToString)
                    CntBarWidth = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntBarWidth"), Irow).ToString)
                    CntBarTextposition = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntBarTextposition"), Irow).ToString)

                    CntQRModulesize = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntQRModulesize"), Irow).ToString)
                    CntQRErrorlevel = Integer.Parse(getData(Vs61, getColumIndex(Vs61, "CntQRErrorlevel"), Irow).ToString)

                    Content = getData(Vs61, getColumIndex(Vs61, "Content"), Irow).ToString



                    DS1 = PrcDS("PSM_USP_ISUD1001A_PRI3004_Android", cn, DateTemplate, SeqTemplate, _
                                DateStoredProcedure, SeqStoredProcedure, StoredProcedureFielName, _
                                Posion, TypePrint, TypeAlignment, CntLineEnter, CntTextFontSize, TypeTextFontBold, _
                                TypeTextUnderLine, CntBarSymbology, CntBarHeight, CntBarWidth, CntBarTextposition, CntQRModulesize, CntQRErrorlevel, Content, IDNO)




                Next
                
                MsgBoxP("Lưu thành công")
            Catch ex As Exception
                MsgBoxP("Lưu thất bại")
            End Try

        Catch ex As Exception
            MsgBoxP("Lưu thất bại")
        End Try
    End Sub
#End Region

#End Region

#Region "Event"

#Region "General"
    Private Sub ItemMain_DoubleClick(sender As Object, e As EventArgs) Handles ItemMain.DoubleClick
        Try
            Select Case ItemMain.SelectedTab.Name.ToString.Trim
                Case "TabPageForm"
                    DATA_SEARCH10()
                    ClearForm()
                Case "TabPageStoredProcedure"
                    DATA_SEARCH21()
                    ClearStoredProcedure()
                Case "TabPageTemplate"
                    DATA_SEARCH30()
                    ClearTemplate()
                Case "TabPageMapTemplateAndForm"
                    DATA_SEARCH40()
                Case "TabPageMapTemplateAndStoredProcedure"
                    DATA_SEARCH50()
                Case "TabPageDesignTemplatePrint"
                    DATA_SEARCH60()
                Case Else

            End Select

        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Form"
    Private Sub Vs10_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs10.CellDoubleClick
        Try
            If e.ColumnHeader = True Then Exit Sub

            Dim DateForm As String = "", SeqForm As String = ""
            DateForm = getData(Vs10, getColumIndex(Vs10, "Key_DateForm"), e.Row)
            SeqForm = getData(Vs10, getColumIndex(Vs10, "Key_SeqForm"), e.Row)

            If DateForm = "" And SeqForm = "" Then Exit Sub

            DATA_SEARCH10(DateForm, SeqForm)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSiteForm_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdSiteForm.btnTitleClick
        Try
            If HLP7171ALL.Link_HLP7171A("471", "") Then
                txt_cdSiteForm.Data = hlp0000SeVa
                txt_cdSiteForm.Code = hlp0000SeVaTt
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSiteForm_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdSiteForm.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If HLP7171ALL.Link_HLP7171A("471", txt_cdSiteForm.Data) Then
                    txt_cdSiteForm.Data = hlp0000SeVa
                    txt_cdSiteForm.Code = hlp0000SeVaTt
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSubProcessForm_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdSubProcessForm.btnTitleClick
        Try
            If HLP7171ALL.Link_HLP7171A("002", "") Then
                txt_cdSubProcessForm.Data = hlp0000SeVa
                txt_cdSubProcessForm.Code = hlp0000SeVaTt
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSubProcessForm_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdSubProcessForm.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If HLP7171ALL.Link_HLP7171A("002", txt_cdSubProcessForm.Data) Then
                    txt_cdSubProcessForm.Data = hlp0000SeVa
                    txt_cdSubProcessForm.Code = hlp0000SeVaTt
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_SaveForm_Click(sender As Object, e As EventArgs) Handles cmd_SaveForm.Click
        Try
            SaveForm()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_ClearForm_Click(sender As Object, e As EventArgs) Handles cmd_ClearForm.Click
        Try
            ClearForm()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Stored Procedure"
    Private Sub Vs21_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs21.CellDoubleClick
        Try
            If e.ColumnHeader = True Then Exit Sub

            Dim DateStoredProcedure As String = "", SeqStoredProcedure As String = "", StoredProcedureSimply As String = ""
            DateStoredProcedure = getData(Vs21, getColumIndex(Vs21, "Key_DateStoredProcedure"), e.Row)
            SeqStoredProcedure = getData(Vs21, getColumIndex(Vs21, "Key_SeqStoredProcedure"), e.Row)
            StoredProcedureSimply = getData(Vs21, getColumIndex(Vs21, "StoredProcedureSimply"), e.Row)

            If DateStoredProcedure = "" And SeqStoredProcedure = "" Then Exit Sub

            DATA_SEARCH20(DateStoredProcedure, SeqStoredProcedure)
            DATA_SEARCH21(DateStoredProcedure, SeqStoredProcedure)
            DATA_SEARCH20(DateStoredProcedure, SeqStoredProcedure, StoredProcedureSimply)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_SimplyStoredProcedure_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_SimplyStoredProcedure.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                Dim StoredProcedureName As String = "", DateStoredProcedure As String = "", SeqStoredProcedure As String = ""
                StoredProcedureName = txt_SimplyStoredProcedure.Data
                DateStoredProcedure = txt_DateStoredProcedure.Data
                SeqStoredProcedure = txt_SeqStoredProcedure.Data

                DATA_SEARCH20(DateStoredProcedure, SeqStoredProcedure, StoredProcedureName)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSiteStoredProcedure_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdSiteStoredProcedure.btnTitleClick
        Try
            If HLP7171ALL.Link_HLP7171A("471", "") Then
                txt_cdSiteStoredProcedure.Data = hlp0000SeVa
                txt_cdSiteStoredProcedure.Code = hlp0000SeVaTt
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSiteStoredProcedure_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdSiteStoredProcedure.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If HLP7171ALL.Link_HLP7171A("471", txt_cdSiteForm.Data) Then
                    txt_cdSiteStoredProcedure.Data = hlp0000SeVa
                    txt_cdSiteStoredProcedure.Code = hlp0000SeVaTt
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSubProcessStoredProcedure_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdSubProcessStoredProcedure.btnTitleClick
        Try
            If HLP7171ALL.Link_HLP7171A("002", "") Then
                txt_cdSubProcessStoredProcedure.Data = hlp0000SeVa
                txt_cdSubProcessStoredProcedure.Code = hlp0000SeVaTt
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSubProcessStoredProcedure_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdSubProcessStoredProcedure.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If HLP7171ALL.Link_HLP7171A("002", txt_cdSubProcessForm.Data) Then
                    txt_cdSubProcessStoredProcedure.Data = hlp0000SeVa
                    txt_cdSubProcessStoredProcedure.Code = hlp0000SeVaTt
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_SaveStoredProcedure_Click(sender As Object, e As EventArgs) Handles cmd_SaveStoredProcedure.Click
        Try
            SaveStoredProcedure()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_ClearStoredProcedure_Click(sender As Object, e As EventArgs) Handles cmd_ClearStoredProcedure.Click
        Try
            ClearStoredProcedure()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Template"
    Private Sub Vs30_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs30.CellDoubleClick
        Try
            If e.ColumnHeader = True Then Exit Sub

            Dim DateTemplate As String = "", SeqTemplate As String = ""
            DateTemplate = getData(Vs30, getColumIndex(Vs30, "Key_DateTemplate"), e.Row)
            SeqTemplate = getData(Vs30, getColumIndex(Vs30, "Key_SeqTemplate"), e.Row)

            If DateTemplate = "" And SeqTemplate = "" Then Exit Sub

            DATA_SEARCH30(DateTemplate, SeqTemplate)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSiteTemplate_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdSiteTemplate.btnTitleClick
        Try
            If HLP7171ALL.Link_HLP7171A("471", "") Then
                txt_cdSiteTemplate.Data = hlp0000SeVa
                txt_cdSiteTemplate.Code = hlp0000SeVaTt
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSiteTemplate_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdSiteTemplate.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If HLP7171ALL.Link_HLP7171A("471", txt_cdSiteForm.Data) Then
                    txt_cdSiteTemplate.Data = hlp0000SeVa
                    txt_cdSiteTemplate.Code = hlp0000SeVaTt
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSubProcessTemplate_btnTitleClick(sender As Object, e As EventArgs) Handles txt_cdSubProcessTemplate.btnTitleClick
        Try
            If HLP7171ALL.Link_HLP7171A("002", "") Then
                txt_cdSubProcessTemplate.Data = hlp0000SeVa
                txt_cdSubProcessTemplate.Code = hlp0000SeVaTt
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txt_cdSubProcessTemplate_txtTextKeyDown(sender As Object, e As KeyEventArgs) Handles txt_cdSubProcessTemplate.txtTextKeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                If HLP7171ALL.Link_HLP7171A("002", txt_cdSubProcessForm.Data) Then
                    txt_cdSubProcessTemplate.Data = hlp0000SeVa
                    txt_cdSubProcessTemplate.Code = hlp0000SeVaTt
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_SaveTemplate_Click(sender As Object, e As EventArgs) Handles cmd_SaveTemplate.Click
        Try
            SaveTemplate()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_ClearTemplate_Click(sender As Object, e As EventArgs) Handles cmd_ClearTemplate.Click
        Try
            ClearTemplate()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Map Template And Form"
    Private Sub Vs40_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs40.CellDoubleClick
        Try
            If e.ColumnHeader = True Then Exit Sub

            Dim DateTemplate As String = "", SeqTemplate As String = ""
            DateTemplate = getData(Vs40, getColumIndex(Vs40, "Key_DateTemplate"), e.Row)
            SeqTemplate = getData(Vs40, getColumIndex(Vs40, "Key_SeqTemplate"), e.Row)

            If DateTemplate = "" And SeqTemplate = "" Then Exit Sub

            DATA_SEARCH41(DateTemplate, SeqTemplate)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_SaveMapTemplateAndForm_Click(sender As Object, e As EventArgs) Handles cmd_SaveMapTemplateAndForm.Click
        Try
            SaveMapTemplateAndForm()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#Region "Map Template And Stored Procedure"
    Private Sub Vs50_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs50.CellDoubleClick
        Try
            If e.ColumnHeader = True Then Exit Sub

            Dim DateTemplate As String = "", SeqTemplate As String = ""
            DateTemplate = getData(Vs50, getColumIndex(Vs50, "Key_DateTemplate"), e.Row)
            SeqTemplate = getData(Vs50, getColumIndex(Vs50, "Key_SeqTemplate"), e.Row)

            If DateTemplate = "" And SeqTemplate = "" Then Exit Sub

            DATA_SEARCH51(DateTemplate, SeqTemplate)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_SaveMapTemplateAndStoredProcedure_Click(sender As Object, e As EventArgs) Handles cmd_SaveMapTemplateAndStoredProcedure.Click
        Try
            SaveMapTemplateAndStoredProcedure()
        Catch ex As Exception

        End Try
    End Sub
#End Region

#Region "Design Template Print"
    Private Sub Vs60_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs60.CellDoubleClick
        Try
            If e.ColumnHeader = True Then Exit Sub

            Dim DateForm As String = "", SeqForm As String = ""
            Dim DateTemplate As String = "", SeqTemplate As String = ""
            Dim DateStoredProcedure As String = "", SeqStoredProcedure As String = ""
            DateForm = getData(Vs60, getColumIndex(Vs60, "Key_DateForm"), e.Row)
            SeqForm = getData(Vs60, getColumIndex(Vs60, "Key_SeqForm"), e.Row)

            DateTemplate = getData(Vs60, getColumIndex(Vs60, "Key_DateTemplate"), e.Row)
            SeqTemplate = getData(Vs60, getColumIndex(Vs60, "Key_SeqTemplate"), e.Row)

            DateStoredProcedure = getData(Vs60, getColumIndex(Vs60, "Key_DateStoredProcedure"), e.Row)
            SeqStoredProcedure = getData(Vs60, getColumIndex(Vs60, "Key_SeqStoredProcedure"), e.Row)

            If DateForm = "" And SeqForm = "" And DateTemplate = "" And SeqTemplate = "" And DateStoredProcedure = "" And SeqStoredProcedure = "" Then Exit Sub

            DATA_SEARCH61(DateForm, SeqForm, DateTemplate, SeqTemplate, DateStoredProcedure, SeqStoredProcedure)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Vs61_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles Vs61.CellDoubleClick
        Try
            If e.ColumnHeader = True Then Exit Sub

            Dim Posion As String, NameStoredProcedure As String
            Dim StoredProcedureFielName As String, TypePrint As String, TypeFace As String, TypeAlignment As String, CntLineEnter As String
            Dim CntTextFontSize As String, TypeTextFontBold As String, TypeTextUnderLine As String
            Dim CntBarSymbology As String, CntBarHeight As String, CntBarWidth As String, CntBarTextposition As String
            Dim CntQRModulesize As String, CntQRErrorlevel As String, Content As String

            Posion = getData(Vs61, getColumIndex(Vs61, "Posion"), e.Row)
            NameStoredProcedure = getData(Vs61, getColumIndex(Vs61, "NameStoredProcedure"), e.Row)

            StoredProcedureFielName = getData(Vs61, getColumIndex(Vs61, "StoredProcedureFielName"), e.Row)
            TypePrint = getData(Vs61, getColumIndex(Vs61, "TypePrint"), e.Row)
            TypeFace = getData(Vs61, getColumIndex(Vs61, "TypeFace"), e.Row)
            TypeAlignment = getData(Vs61, getColumIndex(Vs61, "TypeAlignment"), e.Row)
            CntLineEnter = getData(Vs61, getColumIndex(Vs61, "CntLineEnter"), e.Row)

            CntTextFontSize = getData(Vs61, getColumIndex(Vs61, "CntTextFontSize"), e.Row)
            TypeTextFontBold = getData(Vs61, getColumIndex(Vs61, "TypeTextFontBold"), e.Row)
            TypeTextUnderLine = getData(Vs61, getColumIndex(Vs61, "TypeTextUnderLine"), e.Row)

            CntBarSymbology = getData(Vs61, getColumIndex(Vs61, "CntBarSymbology"), e.Row)
            CntBarHeight = getData(Vs61, getColumIndex(Vs61, "CntBarHeight"), e.Row)
            CntBarWidth = getData(Vs61, getColumIndex(Vs61, "CntBarWidth"), e.Row)
            CntBarTextposition = getData(Vs61, getColumIndex(Vs61, "CntBarTextposition"), e.Row)

            CntQRModulesize = getData(Vs61, getColumIndex(Vs61, "CntQRModulesize"), e.Row)
            CntQRErrorlevel = getData(Vs61, getColumIndex(Vs61, "CntQRErrorlevel"), e.Row)
            Content = getData(Vs61, getColumIndex(Vs61, "Content"), e.Row)




            If HLP1001A_Android.Link_HLP1001A_Android(Posion, NameStoredProcedure, StoredProcedureFielName, TypePrint, TypeFace,
                                                   TypeAlignment, CntLineEnter, CntTextFontSize, TypeTextFontBold, TypeTextUnderLine,
                                                   CntBarSymbology, CntBarHeight, CntBarWidth, CntBarTextposition, CntQRModulesize,
                                                   CntQRErrorlevel, Content) Then




                setData(Vs61, getColumIndex(Vs61, "Posion"), e.Row, Array_hlp0000SeVaTt(0))

                setData(Vs61, getColumIndex(Vs61, "TypePrint"), e.Row, Array_hlp0000SeVaTt(1))
                setData(Vs61, getColumIndex(Vs61, "TypeAlignment"), e.Row, Array_hlp0000SeVaTt(2))
                setData(Vs61, getColumIndex(Vs61, "CntLineEnter"), e.Row, Array_hlp0000SeVaTt(3))

                setData(Vs61, getColumIndex(Vs61, "CntTextFontSize"), e.Row, Array_hlp0000SeVaTt(4))
                setData(Vs61, getColumIndex(Vs61, "TypeTextFontBold"), e.Row, Array_hlp0000SeVaTt(5))
                setData(Vs61, getColumIndex(Vs61, "TypeTextUnderLine"), e.Row, Array_hlp0000SeVaTt(6))

                setData(Vs61, getColumIndex(Vs61, "CntBarSymbology"), e.Row, Array_hlp0000SeVaTt(7))
                setData(Vs61, getColumIndex(Vs61, "CntBarHeight"), e.Row, Array_hlp0000SeVaTt(8))
                setData(Vs61, getColumIndex(Vs61, "CntBarWidth"), e.Row, Array_hlp0000SeVaTt(9))
                setData(Vs61, getColumIndex(Vs61, "CntBarTextposition"), e.Row, Array_hlp0000SeVaTt(10))

                setData(Vs61, getColumIndex(Vs61, "CntQRModulesize"), e.Row, Array_hlp0000SeVaTt(11))
                setData(Vs61, getColumIndex(Vs61, "CntQRErrorlevel"), e.Row, Array_hlp0000SeVaTt(12))
                setData(Vs61, getColumIndex(Vs61, "Content"), e.Row, Array_hlp0000SeVaTt(13))


            End If



        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmd_SaveDesignTemplatePrint_Click(sender As Object, e As EventArgs) Handles cmd_SaveDesignTemplatePrint.Click
        Try
            SaveDesignTemplatePrint()
        Catch ex As Exception

        End Try
    End Sub

#End Region

#End Region


End Class