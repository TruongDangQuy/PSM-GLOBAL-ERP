Module M_DESIGN
#Region "Variable"
    Public FORMWIDTHSIZE, FORMHEIGHTSIZE As Integer

#End Region

#Region "Methods"
    Public Sub FARPOINT_CHKBOXALL(sheet As FarPoint.Win.Spread.SheetView)
        Dim i As Integer
        If sheet.RowCount > 0 Then
            For i = 0 To sheet.RowCount - 1
                sheet.Cells(i, 0).Value = True
            Next
        End If
    End Sub
    Public Sub FARPOINT_CHKBOXCAN(sheet As FarPoint.Win.Spread.SheetView)
        Dim i As Integer
        If sheet.RowCount > 0 Then
            For i = 0 To sheet.RowCount - 1
                sheet.Cells(i, 0).Value = False
            Next
        End If
    End Sub
    Public Sub FARPOINT_CHKBOXALL(SPR As FarPoint.Win.Spread.FpSpread)
        Dim i As Integer
        If SPR.ActiveSheet.RowCount > 0 Then
            For i = 0 To SPR.ActiveSheet.RowCount - 1
                SPR.ActiveSheet.Cells(i, 0).Value = True
            Next
        End If
    End Sub
    Public Sub FARPOINT_CHKBOXCAN(SPR As FarPoint.Win.Spread.FpSpread)
        Dim i As Integer
        If SPR.ActiveSheet.RowCount > 0 Then
            For i = 0 To SPR.ActiveSheet.RowCount - 1
                SPR.ActiveSheet.Cells(i, 0).Value = False
            Next
        End If
    End Sub
    Public Sub CellDoubleClick(sheet As FarPoint.Win.Spread.SheetView, e As FarPoint.Win.Spread.CellClickEventArgs)
        If e.Column = 0 And e.ColumnHeader = True And sheet.Cells(0, 0).Value = True Then
            FARPOINT_CHKBOXCAN(sheet)
        ElseIf e.Column = 0 And e.ColumnHeader = True And sheet.Cells(0, 0).Value = False Then
            FARPOINT_CHKBOXALL(sheet)
        End If

    End Sub
    Public Sub CellDoubleClick(sheet As FarPoint.Win.Spread.SheetView, e As FarPoint.Win.Spread.CellClickEventArgs, Optional ByVal Col As Integer = Nothing)
        Dim i As Integer
        If sheet.Cells(0, Col).Value = False Then
            For i = 0 To sheet.RowCount - 1
                sheet.Cells(i, Col).Value = True
            Next
        Else
            For i = 0 To sheet.RowCount - 1
                sheet.Cells(i, Col).Value = False
            Next
        End If
    End Sub
    Public Sub SPR_AllCan(spr As FarPoint.Win.Spread.FpSpread, e As FarPoint.Win.Spread.CellClickEventArgs, ByVal col As Integer)
        If e.Column = col And e.ColumnHeader = True And spr.ActiveSheet.Cells(0, 0).Value = True Then
            FARPOINT_CHKBOXCAN(spr)
        ElseIf e.Column = 0 And e.ColumnHeader = True And spr.ActiveSheet.Cells(0, 0).Value = False Then
            FARPOINT_CHKBOXALL(spr)
        End If
    End Sub
    Public Sub FORM_DESIGN_MAX(FORM_NAME As Form)
        FORM_NAME.Top = 50
        FORM_NAME.Left = 50
        FORM_NAME.Height = 1080
        FORM_NAME.Width = 1920
    End Sub
    Public Sub FORM_DESIGN_MEDLE(FORM_NAME As Form)
        FORM_NAME.Top = 50
        FORM_NAME.Left = 50
        FORM_NAME.Height = 800
        FORM_NAME.Width = 1400
    End Sub
    Public Sub TAB_RESIZE(FORM_NAME As Form, TOOLSTRIP_NAME As ToolStrip, TAB_NAME As TabControl)
        TAB_NAME.SizeMode = TabSizeMode.Fixed
        TAB_NAME.Width = FORM_NAME.Size.Width - 40
        TAB_NAME.Height = FORM_NAME.Size.Height - TOOLSTRIP_NAME.Size.Height - 40
        TAB_NAME.ItemSize = New Size(TAB_NAME.Width / TAB_NAME.TabCount - 2, 30)
    End Sub
    'Public Sub FRAME_RESIZE(FORM_NAME As Form, FRAME_NAME As FRAME)
    '    If RESIZE_SIZE(FORM_NAME) <= 1 Then
    '        FRAME_NAME.Size = New Size(1380 * RESIZE_SIZE(FORM_NAME), 60 * RESIZE_SIZE(FORM_NAME))
    '        For Each button In FRAME_NAME.Controls
    '            If (TypeOf button Is Button) Then
    '                button.size = New Size(172 * RESIZE_SIZE(FORM_NAME), 52 * RESIZE_SIZE(FORM_NAME))
    '            End If
    '        Next
    '        For Each picture In FRAME_NAME.Controls
    '            If (TypeOf picture Is PictureBox) Then
    '                picture.Size = New Size(172 * RESIZE_SIZE(FORM_NAME), 52 * RESIZE_SIZE(FORM_NAME))
    '            End If
    '        Next
    '    Else
    '    End If
    'End Sub
    Public Sub TOOLBAR_RESIZE(FORM_NAME As Form, TOOLBAR_NAME As ToolStrip)
        If RESIZE_SIZE(FORM_NAME) <= 1 Then
            TOOLBAR_NAME.Size = New Size(1380 * RESIZE_SIZE(FORM_NAME), 60 * RESIZE_SIZE(FORM_NAME))
            Dim a As Object
            For Each a In TOOLBAR_NAME.Controls
                If (TypeOf a Is Button) Then
                    a.Size = New Size(172 * RESIZE_SIZE(FORM_NAME), 52 * RESIZE_SIZE(FORM_NAME))
                End If
            Next
        Else
        End If
    End Sub

    Public Function RESIZE_SIZE(FORM_NAME As Form) As Single
        Dim WIDTHSIZE, HEIGHTSIZE As Single
        If FORMWIDTHSIZE <> 0 And FORMHEIGHTSIZE <> 0 Then
            WIDTHSIZE = FORM_NAME.Size.Width / FORMWIDTHSIZE
            HEIGHTSIZE = FORM_NAME.Size.Height / FORMHEIGHTSIZE
            RESIZE_SIZE = WIDTHSIZE * HEIGHTSIZE
            Return FormatNumber(RESIZE_SIZE, 2)
        Else
            Return 1
        End If
    End Function
#End Region
   
End Module
