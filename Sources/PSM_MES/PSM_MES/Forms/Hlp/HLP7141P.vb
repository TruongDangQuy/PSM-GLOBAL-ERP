Imports System.Net
Imports System.IO

Public Class HLP7141P

#Region "Variable"
    Inherits HLP0000
    Private Dsu01 As Long
    Private W1_Head As Integer = 2
    Private wGCHK As String
#End Region

#Region "Form_Load"
    Public Overrides Sub HLP0000_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VS1.Sheets(0).Columns.Count = 6
        SPR_WIDTHCOL(VS1, 0, 50)
        SPR_WIDTHCOL(VS1, 1, 300)
        SPR_WIDTHCOL(VS1, 2, 50)
        SPR_WIDTHCOL(VS1, 3, 50)
        SPR_WIDTHCOL(VS1, 4, 50)
        SPR_WIDTHCOL(VS1, 5, 50)
        SPR_SET(VS1, , , , OperationMode.SingleSelect, False)
        Me.Text = HLPNA
        DATA_SEARCH01(W1_Head)
    End Sub
#End Region

#Region "Methods"
    Public Overrides Function DATA_SEARCH01(Head_No As String) As Boolean
        VS1.Sheets(0).RowCount = 0
        Dim i As Integer
        Dim SQL As String
        Dim ds As New DataSet

        DATA_SEARCH01 = False
        Try
            cmd_OK.Enabled = False
            If Me.Text = "btn_programname" Then GoTo btn_programname
            If Me.Text = "btn_sheetprint" Then GoTo btn_sheetprint
            Dim SWORD As String
            Dim EWORD As String
            SWORD = "" : EWORD = ""
            If charac <> "" Then
                SelectLabelSearch1.PeaceTextbox1.Text = ""
                SWORD = charac
            End If
            HLPSEARCH(HLPNA, SelectLabelSearch1.PeaceTextbox1.Text.Trim, charac, SWORD, EWORD, Head_No)
            charac = ""

            da.SelectCommand = cmd
            da.Fill(ds)
            If ds.Tables(0).Rows.Count = 0 Then
                Call MsgBoxP("150", "NO DATA FIELD")
                Exit Function
            End If
            VS1.ActiveSheet.Columns(0).Visible = True
            VS1.ActiveSheet.Columns(3).Visible = True
            VS1.ActiveSheet.Columns(4).Visible = True
            VS1.ActiveSheet.Columns(5).Visible = True
            VS1.Sheets(0).RowCount = ds.Tables(0).Rows.Count

            If Me.Text = "btn_FabricSearch" Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
                    VS1.Sheets(0).Cells(i, 1).Value = ds.Tables(0).Rows(i).Item(3)
                    VS1.Sheets(0).Cells(i, 2).Value = ds.Tables(0).Rows(i).Item(4)
                    VS1.Sheets(0).Cells(i, 3).Value = ds.Tables(0).Rows(i).Item(5)
                    VS1.Sheets(0).Cells(i, 4).Value = ds.Tables(0).Rows(i).Item(6)
                    VS1.Sheets(0).Cells(i, 5).Value = ds.Tables(0).Rows(i).Item(7)
                Next
            Else
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
                    VS1.Sheets(0).Cells(i, 1).Value = ds.Tables(0).Rows(i).Item(1)
                    VS1.Sheets(0).Cells(i, 2).Value = ds.Tables(0).Rows(i).Item(2)
                    VS1.Sheets(0).Cells(i, 3).Value = ds.Tables(0).Rows(i).Item(3)
                    VS1.Sheets(0).Cells(i, 4).Value = ds.Tables(0).Rows(i).Item(4)
                    VS1.Sheets(0).Cells(i, 5).Value = ds.Tables(0).Rows(i).Item(5)
                Next
            End If
            DATA_SEARCH01 = True
            VS1.Sheets(0).Visible = True
            cmd_OK.Enabled = True
            If Me.Text = "btn_InsMachine" Then
                VS1.ActiveSheet.Columns(0).Visible = False
                VS1.ActiveSheet.Columns(3).Visible = False
                VS1.ActiveSheet.Columns(4).Visible = False
                VS1.ActiveSheet.Columns(5).Visible = False
                VS1.ActiveSheet.Columns(1).Width = 50
                VS1.ActiveSheet.Columns(2).Width = 340
            End If
            Exit Function
btn_programname:
            SQL = ""
            'SQL = "SELECT K9912_ProgramNo FROM PFK9912 "
            'SQL = SQL + " WHERE K9912_ProgramNo LIKE '%" + SelectLabelSearch1.Data.Trim + "%' "
            'SQL = SQL + " GROUP BY K9912_ProgramNo"

            SQL = "SELECT name FROM SYS.procedures"
            SQL = SQL + " WHERE name LIKE '%" + SelectLabelSearch1.Data.Trim + "%' "

            cmd = New SqlClient.SqlCommand(SQL, cn)
            da.SelectCommand = cmd
            da.Fill(ds)
            i = 0
            If GetDsRc(ds) = 0 Then VS1.ActiveSheet.RowCount = 0 : Exit Function
            For i = 0 To ds.Tables(0).Rows.Count - 1
                VS1.ActiveSheet.RowCount = i + 1
                VS1.Sheets(0).Cells(i, 0).Value = ds.Tables(0).Rows(i).Item(0)
                VS1.Sheets(0).Cells(i, 1).Value = ds.Tables(0).Rows(i).Item(0)
            Next
            VS1.ActiveSheet.Columns(0).Visible = False
            VS1.ActiveSheet.Columns(2).Visible = False
            VS1.ActiveSheet.Columns(3).Visible = False
            VS1.ActiveSheet.Columns(4).Visible = False
            VS1.ActiveSheet.Columns(5).Visible = False
            VS1.Sheets(0).Visible = True
            cmd_OK.Enabled = True
            Exit Function

btn_sheetprint:

            Dim abc(1000) As String
            Dim abcd(1000) As String
            Dim j1 As Integer
            Dim counti As Integer
            Dim countj As Integer
            Dim sr1 As System.IO.StreamReader
            Dim client As WebClient = New WebClient()
            client.UseDefaultCredentials = True
            client.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials

            Dim LinkStr As String
            LinkStr = "http://"
            LinkStr += Pub.SER
            LinkStr += "/SHV/Report/"
            LinkStr = "http://" & Pub.SER.Replace(",", ":") & "/CS_WHM/Report/"

            sr1 = New StreamReader(client.OpenRead(LinkStr))
            i = 0
            Do While Not sr1.EndOfStream
                abc(i) = sr1.ReadLine
                counti += 1
                i += 1
            Loop

            sr1.Close()
            i = 0
            countj = 0
            'For i = 1 To abc(2).Length - 1
            '    If Mid(abc(2), i, 1) = "." Then
            '        If Mid(abc(2), i + 1, 6) = "xlsx"">" Then
            '            For j1 = i + 7 To abc(2).Length - 1
            '                If Mid(abc(2), j1, 1) = "." Then
            '                    If Mid(abc(2), j1 + 1, 4) = "xlsx" Then
            '                        abcd(countj) = Strings.Mid(abc(2), i + 7, j1 - (i + 7))
            '                        countj = countj + 1
            '                        Exit For
            '                    End If
            '                End If
            '            Next
            '        End If
            '    End If

            'Next
            For i = 1 To abc(2).Length - 1
                If Mid(abc(2), i, 1) = "." Then
                    If Mid(abc(2), i + 1, 6) = "xlsx"">" Then

                        For j1 = i + 7 To abc(2).Length - 1
                            If Mid(abc(2), j1, 1) = "." Then
                                If Mid(abc(2), j1 + 1, 4) = "xlsx" Then
                                    abcd(countj) = Strings.Mid(abc(2), i + 7, j1 - (i + 7))
                                    countj = countj + 1
                                    Exit For
                                End If
                            End If
                        Next

                    ElseIf Mid(abc(2), i + 1, 5) = "xls"">" Then

                        For j1 = i + 6 To abc(2).Length - 1
                            If Mid(abc(2), j1, 1) = "." Then
                                If Mid(abc(2), j1 + 1, 3) = "xls" Then
                                    abcd(countj) = Strings.Mid(abc(2), i + 6, j1 - (i + 6))
                                    countj = countj + 1
                                    Exit For
                                End If
                            End If
                        Next


                    End If
                End If


            Next

            i = 0
            For i = 0 To countj - 1
                VS1.ActiveSheet.RowCount = i + 1
                setData(VS1, 0, i, i + 1)
                setData(VS1, 1, i, abcd(i))
            Next
            VS1.ActiveSheet.Columns(0).Visible = True
            VS1.ActiveSheet.Columns(2).Visible = False
            VS1.ActiveSheet.Columns(3).Visible = False
            VS1.ActiveSheet.Columns(4).Visible = False
            VS1.ActiveSheet.Columns(5).Visible = False
            VS1.Sheets(0).Visible = True

            VS1.Sheets(0).Visible = True
            cmd_OK.Enabled = True

            Me.Show()
            Application.DoEvents()
            VS1.Focus()

            Exit Function
        Catch ex As Exception
            Call MsgBoxP("1", "DATE_SEARCH01")
        End Try
    End Function
#End Region

#Region "Events"
    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        DATA_SEARCH01(W1_Head)
    End Sub

    Public Overrides Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If Me.Text = "btn_InsMachine" Then
            hlp0000SeVaTt = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 1).Value
            hlp0000SeVa = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 2).Value
            Me.Close()
            Exit Sub
        End If
        If VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 0).Value IsNot Nothing And VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 1).Value IsNot Nothing Then
            hlp0000SeVaTt = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 0).Value
            hlp0000SeVa = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 1).Value
            Me.Close()
            Exit Sub
        Else
            MsgBoxP("NO VALUE !")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Public Overrides Sub VS1_CellClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick
        If Me.Text = "btn_InsMachine" Then
            hlp0000SeVaTt = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 1).Value
            hlp0000SeVa = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 2).Value
            Me.Close()
            Exit Sub
        End If
        If VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 0).Value IsNot Nothing And VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 1).Value IsNot Nothing Then
            hlp0000SeVaTt = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 0).Value
            hlp0000SeVa = VS1.Sheets(0).Cells(VS1.Sheets(0).ActiveRowIndex, 1).Value
            Me.Close()
            Exit Sub
        Else
            MsgBoxP("NO VALUE !")
            Exit Sub
        End If
        Me.Close()
    End Sub
    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()

        End Select
    End Sub
#End Region

End Class
