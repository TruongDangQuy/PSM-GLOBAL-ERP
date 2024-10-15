Public Class HLP7102A

#Region "Variable"
    Private AC As Control
    Private Dsu01 As Long
    Private xCHK As String
    Private W1_Head As Long
    Private RS01 As SqlClient.SqlDataReader
#End Region

#Region "Form_Load"
    Public Function Link_HLP7102A(CHK As String) As Boolean
        Link_BUYER = ""
        Link_ODNO = ""

        xCHK = CHK
        Select Case xCHK
            Case "1" : Me.Text = "Buyer Search (HLP7102A)"
            Case "2" : Me.Text = "ODNO Search (HLP7102A)"
            Case "3" : Me.Text = "PO# Search (HLP7102A)"
        End Select

        Me.ShowDialog()

        Link_HLP7102A = hlpCHK
    End Function

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        W1_Head = 2
        SPR_CLEAR(VS1)
        SPR_SET(VS1, , , , OperationMode.SingleSelect, True)
        txt_Name.Data = HlpStr
        Call DATA_SEARCH_VS1(W1_Head)
    End Sub
#End Region

#Region "Methods"
    Private Function DATA_SEARCH_VS1(Head_No As Long) As Boolean

        Dim i As Double

        DATA_SEARCH_VS1 = False

START_DATA_SEARCH_VS1:

        Me.Cursor = Cursors.Default

        cmd_OK.Enabled = False

        Dim SWORD As String
        Dim EWORD As String

        SWORD = "" : EWORD = ""

        'Select Case xCHK
        '    Case 1
        '        Call USP_HLP7102A_SEARCH_1(txt_Name.Data, "ALL", SWORD, EWORD, Head_No)
        '    Case 2
        '        Call USP_HLP7102A_SEARCH_2(txt_Name.Data, "ALL", SWORD, EWORD, Head_No)
        '    Case 3
        '        Call USP_HLP7102A_SEARCH_3(txt_Name.Data, "ALL", SWORD, EWORD, Head_No)
        'End Select

        'RS01 = cmd.ExecuteReader

        'If RS01.HasRows = False Then
        '    RS01.Close()

        '    vS1.Visible = True
        '    Me.Cursor = Cursors.Default

        '    Call Error_Message("1", "DATE_SEARCH01")

        '    Exit Function
        'End If

        VS1.Visible = False

        i = -1

        Do While RS01.HasRows : Do While RS01.Read()
                i = i + 1
                VS1.ActiveSheet.RowCount = i + 1
                Select Case xCHK
                    Case 1 : setData(VS1, 0, i, RS01![K1331_BUYER])
                    Case 2 : setData(VS1, 0, i, RS01![K1332_ODNO])
                    Case 3 : setData(VS1, 0, i, RS01![K1331_MODEL])
                End Select

            Loop : RS01.NextResult()
        Loop

        RS01.Close()

        DATA_SEARCH_VS1 = True

        Me.Cursor = Cursors.Default

        VS1.ActiveSheet.ColumnCount = 1
        VS1.ActiveSheet.Columns(0).Width = 500

        VS1.Visible = True
        VS1.Enabled = True
        VS1.Select()

        cmd_OK.Enabled = True

    End Function
#End Region

#Region "Events"
    Private Sub vS1_DblClick(sender As Object, e As CellClickEventArgs) Handles VS1.CellDoubleClick

        If e.RowHeader = False Or e.ColumnHeader = False Then Call cmd_OK.PerformClick() : Exit Sub

        If e.Column = 1 Then
            W1_Head = 1
        Else
            W1_Head = 2
        End If

        If DATA_SEARCH_VS1(W1_Head) = False Then Exit Sub

        VS1.Select()

    End Sub

    Private Sub cmd_OK_Click(sender As Object, e As EventArgs) Handles cmd_OK.Click
        If getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub

        hlpCHK = True

        hlp0000SeVa = Trim$(getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex))
        hlp0000SeVaTt = Trim$(getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex))

        Select Case xCHK
            Case 1 : Link_BUYER = Trim$(getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex))
            Case 2 : Link_ODNO = Trim$(getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex))
            Case 3 : Link_MODEL = Trim$(getData(VS1, 0, VS1.ActiveSheet.ActiveRowIndex))
        End Select
        HlpStr = ""
        Me.Close()
    End Sub

    Private Sub cmd_CANCEL_Click(sender As Object, e As EventArgs) Handles cmd_Cancel.Click
        hlpCHK = False
        HlpStr = ""
        hlp0000SeVa = ""
        hlp0000SeVaTt = ""
        Select Case xCHK
            Case 1 : Link_BUYER = ""
            Case 2 : Link_ODNO = ""
            Case 3 : Link_MODEL = ""
        End Select

        Me.Close()
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If DATA_SEARCH_VS1(W1_Head) = False Then Setfocus(txt_Name) : Exit Sub
        VS1.Select()
    End Sub

    Private Sub VS1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VS1.KeyPress
        Select Case e.KeyChar
            Case ChrW(Keys.Enter), ChrW(Keys.Escape) : cmd_OK.PerformClick()
        End Select
    End Sub
#End Region

    
    '----------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------
    

    


   


End Class