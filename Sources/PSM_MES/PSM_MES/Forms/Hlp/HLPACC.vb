Public Class HLPACC

#Region "Variable"
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String

    Private W7171 As T7171_AREA
    Private vschkbx As New FarPoint.Win.Spread.CellType.CheckBoxCellType
    Private WCHK As String
    Private BasicSel As String
    Private DATASETNEW As New DataSet
    Private DATADA As New SqlClient.SqlDataAdapter
#End Region

#Region "Form_Load"
    Public Function Link_HLPACC(_BasicSel As String) As Boolean
        BasicSel = _BasicSel

        Me.ShowDialog()

        Link_HLPACC = hlpCHK
    End Function

    Private Sub HLP0000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If DATA_SEARCH01() = False Then
            Exit Sub
        End If

    End Sub
#End Region

#Region "Methods"
    Public Overridable Function DATA_SEARCH01() As Boolean
        DATA_SEARCH01 = False
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""

        Try
            DATASETNEW.Reset()

            DATADA.SelectCommand = New SqlClient.SqlCommand(PrcDS_SQL("USP_HLPACC_SEARCH_vS1", "1", BasicSel, txt_Name.Data), cn)
            DATADA.Fill(DATASETNEW, "SP")
            'DATASETNEW = PrcDS("USP_HLPACC_SEARCH_vS1", cn, "1", BasicSel, txt_Name.Data)

            SPR_PRO_NEW(VS1, DATASETNEW, "USP_HLPACC_SEARCH_vS1", "Vs1")
            DATA_SEARCH01 = True

            VS1.ActiveSheet.Columns(0, VS1.ActiveSheet.ColumnCount - 1).Locked = False
            Me.Show()
            Application.DoEvents()
            VS1.Select()

        Catch ex As Exception

            Call MsgBoxP("DATA_SEARCH01", vbCritical)
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub SelectLabelSearch1_Load(sender As Object, e As KeyEventArgs) Handles txt_Name.txtTextKeyDown
        If e.KeyCode = Keys.Enter Then DATA_SEARCH01()
    End Sub

    Public Function PrcDS_SQL(ByVal ProcName As String, ByVal ParamArray Param() As Object) As String

        Dim SQL As String = ""
        Dim i As Integer

        Try

            SQL = "EXEC " & ProcName
            If IsNothing(Param) = False Then
                For i = 0 To UBound(Param)
                    If i <> UBound(Param) Then
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Strings.Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "', "
                                Else
                                    SQL = SQL & " '" & Param(i) & "', "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "', "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "', "
                        End If
                    Else
                        If Param(i) IsNot Nothing Then
                            If Param(i).ToString <> "" Then
                                If Strings.Left(Param(i), 1) = "*" Then
                                    SQL = SQL & " N'" & Mid(Param(i), 2) & "' "
                                Else
                                    SQL = SQL & " '" & Param(i) & "' "
                                End If
                            Else
                                SQL = SQL & " '" & Param(i) & "' "
                            End If
                        Else
                            SQL = SQL & " '" & Param(i) & "' "
                        End If
                    End If
                Next
            End If

            Return SQL
        Catch ex As Exception

        Finally


        End Try
    End Function
    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click

        Me.Close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01()
    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click

        'DS1.Tables(0).Rows(VS1.ActiveSheet.ActiveRowIndex).AcceptChanges()
        Try
            DATADA.UpdateCommand = New SqlClient.SqlCommandBuilder(DATADA).GetUpdateCommand
            DATADA.Update(DATASETNEW.GetChanges, "sp")
            DATASETNEW.AcceptChanges()

        Catch ex As Exception
            DATASETNEW.RejectChanges()
        End Try


    End Sub

    Private Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellClick
        If e.Row < 0 Then Exit Sub
        VS1.ActiveSheet.ActiveRowIndex = e.Row
        VS1.ActiveSheet.ActiveColumnIndex = e.Column
    End Sub

    Private Sub VS1_CellDoubleClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick


    End Sub

    Private Sub VS1_KeyDown(sender As Object, e As KeyEventArgs) Handles VS1.KeyDown
        If e.KeyCode = Keys.Enter Then
            'DS1.Tables(0).Rows(VS1.ActiveSheet.ActiveRowIndex).AcceptChanges()
            Try
                DATADA.UpdateCommand = New SqlClient.SqlCommandBuilder(DATADA).GetUpdateCommand
                DATADA.Update(DATASETNEW.GetChanges, "sp")
                DATASETNEW.AcceptChanges()

            Catch ex As Exception
                DATASETNEW.RejectChanges()
            End Try


        End If
    End Sub
#End Region

End Class