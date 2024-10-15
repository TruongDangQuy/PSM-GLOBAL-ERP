Imports System.IO
Imports System.Net

Public Class SheetReport

#Region "Variable"
    Private formA As Boolean

    Private checkisud As Boolean
    Private Form_T As New Form

    Private CHK(0 To 5) As String

#End Region

#Region "Form_Load"
    Private Sub SheetReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        If cmb_SheetReport.Items.Count = 1 Then
            cmd_OK.PerformClick()
        End If
    End Sub
#End Region

#Region "Methods"

#End Region

#Region "Events"
    Public Function Link_SheetReport(job As Integer, PROG As String, Optional ByRef FORM As Form = Nothing) As Boolean
        Dim i As Integer
        Dim ds As New DataSet
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Link_SheetReport = False

        Form_T = New Form
        Form_T = FORM

        SheetReportName = ""

        SQL = ""
        SQL = " SELECT SHEETREPORT FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
        SQL = SQL & " WHERE PROG = '" & PROG & "' "

        SQL = SQL & "UNION ALL"
        SQL = SQL & " SELECT SHEETREPORT FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING_MULTI] "
        SQL = SQL & " WHERE PROG = '" & PROG & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        da.SelectCommand = cmd
        da.Fill(ds)
        cmb_SheetReport.Items.Clear()

        If GetDsRc(ds) = 0 Then
            Link_SheetReport = False
            Me.Dispose()
            Exit Function
        End If

        For i = 0 To GetDsRc(ds) - 1
            cmb_SheetReport.Items.Add(GetDsData(ds, i, 0))
        Next

        cmb_SheetReport.SelectedIndex = 0
        Me.ShowDialog()

        Link_SheetReport = isudCHK

    End Function
    Public Function Link_SheetReport(job As Integer, PROG As String) As Boolean
        Dim i As Integer
        Dim ds As New DataSet
        Dim SQL As String
        Dim cmd As New SqlClient.SqlCommand
        Link_SheetReport = False

        SheetReportName = ""

        SQL = ""
        SQL = " SELECT SHEETREPORT FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
        SQL = SQL & " WHERE PROG = '" & PROG & "' "

        'SQL = SQL & " UNION ALL "
        'SQL = SQL & " SELECT SHEETREPORT FROM [CS_PRINT].[dbo].[A_SHEETPRINT_MATCHING] "
        'SQL = SQL & " WHERE PROG = '" & PROG & "' "

        cmd = New SqlClient.SqlCommand(SQL, cn)
        da.SelectCommand = cmd
        da.Fill(ds)

        If GetDsRc(ds) = 0 Then
            MsgBoxP("No matching data!")
            Exit Function
        End If

        cmb_SheetReport.Items.Clear()

        For i = 0 To GetDsRc(ds) - 1
            cmb_SheetReport.Items.Add(GetDsData(ds, i, 0))
        Next

        cmb_SheetReport.SelectedIndex = 0
        Me.ShowDialog()

        Link_SheetReport = isudCHK

    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        isudCHK = False
        Me.Dispose()
    End Sub
    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If cmb_SheetReport.Text = "" Then
            isudCHK = False
        Else
            SheetReportName = cmb_SheetReport.Text
            isudCHK = True
        End If
        Me.Dispose()
    End Sub
#End Region

End Class