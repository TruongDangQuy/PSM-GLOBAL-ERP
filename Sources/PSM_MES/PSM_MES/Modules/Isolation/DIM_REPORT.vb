Module DIM_REPORT

#Region "Variable"
    Public gpp As Graphics
    Public gpp1 As Graphics
    Public gpp2 As Graphics
    Public gpp3 As Graphics
    Public twtopi As Decimal = 39.5
    Public lR, UD As Integer

    Public Enum _MSG_RESULT
        OK = 1
        Cancel = 2
        Abort = 3
        Retry = 4
        Ignore = 5
        Yes = 6
        No = 7
        Button1 = 8
        Button2 = 9
        Button3 = 10
    End Enum
    Public Enum _MSG_STYLE
        OKOnly = 0
        OKCancel = 1
        AbortRetryIgnore = 2
        YesNoCancel = 3
        YesNo = 4
        RetryCancel = 5
        CustomButton = 6
    End Enum

#End Region

#Region "Methods"
    Public Function MsgBoxEx( _
ByVal text As String, _
Optional ByVal Buttons As _MSG_STYLE = _MSG_STYLE.OKOnly, _
Optional ByVal Title As Object = Nothing, _
Optional ByRef ctr As Control = Nothing, _
Optional ByRef err As ErrorProvider = Nothing, _
Optional ByVal Button1Text As String = "", _
Optional ByVal Button2Text As String = "", _
Optional ByVal Button3Text As String = "") _
As _MSG_RESULT

        Dim Pipe As New C_Pipe

        Dim frm As New E_MSG(Pipe, text, Buttons, Title, ctr, err, Button1Text, Button2Text, Button3Text)

        frm.ShowDialog()

        If IsNothing(ctr) = False And IsNothing(err) = False Then

            err.SetIconPadding(ctr, -20)

            err.SetError(ctr, text)

            If ctr.Enabled = True And ctr.Visible = True Then ctr.Focus()

        End If

        Return Pipe.RetValue

    End Function
    'Public Sub DLine(ByRef gp As Graphics, ParamArray dayso() As Double)
    '    Try
    '        gp.DrawLine(New Pen(Brushes.Black, 1), CInt(dayso(0) * twtopi), CInt(dayso(1) * twtopi), CInt(dayso(2) * twtopi), CInt(dayso(3) * twtopi))
    '    Catch ex As Exception

    '    End Try

    'End Sub


    'Public Sub DString(ByRef gp As Graphics, s1 As String, c1 As Boolean, c2 As Boolean, c3 As Boolean, fsize As Integer, s2 As String, i As Integer, x1 As Double, y1 As Double)
    '    Dim tname As String
    '    Dim newfont As Font
    '    tname = s2
    '    newfont = New Font(s1, fsize, If(c1 = True, FontStyle.Bold, FontStyle.Regular) Or If(c2 = True, FontStyle.Underline, FontStyle.Regular) Or If(c3 = True, FontStyle.Italic, FontStyle.Regular))
    '    gpp.DrawString(tname, newfont, Brushes.Black, CInt(x1 * twtopi), CInt(y1 * twtopi))
    'End Sub
    Public Sub DString(ByRef gp As Graphics, s1 As String, c1 As Boolean, c2 As Boolean, c3 As Boolean, fsize As Integer, s2 As String, i As Integer, x1 As Double, y1 As Double)
        Dim tname As String
        Dim newfont As Font
        tname = s2
        newfont = New Font(s1, fsize, FontStyle.Regular)

        If c1 = True Then
            If c2 = True Then
                If c3 = True Then
                    newfont = New Font(s1, fsize, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline)
                ElseIf c3 = False Then
                    newfont = New Font(s1, fsize, FontStyle.Bold Or FontStyle.Italic)
                End If

            ElseIf c2 = False Then
                If c3 = True Then
                    newfont = New Font(s1, fsize, FontStyle.Bold Or FontStyle.Underline)
                ElseIf c3 = False Then
                    newfont = New Font(s1, fsize, FontStyle.Bold)
                End If
            End If

        ElseIf c1 = False Then
            If c2 = True Then
                If c3 = True Then
                    newfont = New Font(s1, fsize, FontStyle.Italic Or FontStyle.Underline)
                ElseIf c3 = False Then
                    newfont = New Font(s1, fsize, FontStyle.Italic)
                End If

            ElseIf c2 = False Then
                If c3 = True Then
                    newfont = New Font(s1, fsize, FontStyle.Underline)
                ElseIf c3 = False Then
                    newfont = New Font(s1, fsize, FontStyle.Regular)
                End If
            End If
        End If

        'newfont = New Font(s1, fsize, If(c1 = True, FontStyle.Bold, FontStyle.Regular) Or If(c2 = True, FontStyle.Underline, FontStyle.Regular) Or If(c3 = True, FontStyle.Italic, FontStyle.Regular))
        gp.DrawString(tname, newfont, Brushes.Black, CInt(x1 * twtopi), CInt(y1 * twtopi))
    End Sub
    Public Sub DStringRed(ByRef gp As Graphics, s1 As String, c1 As Boolean, c2 As Boolean, c3 As Boolean, fsize As Integer, s2 As String, i As Integer, x1 As Double, y1 As Double)
        Dim tname As String
        Dim newfont As Font
        tname = s2
        newfont = New Font(s1, fsize, If(c1 = True, FontStyle.Bold, FontStyle.Regular) Or If(c2 = True, FontStyle.Underline, FontStyle.Regular) Or If(c3 = True, FontStyle.Italic, FontStyle.Regular))
        gp.DrawString(tname, newfont, Brushes.Red, CInt(x1 * twtopi), CInt(y1 * twtopi))
    End Sub
    Public Sub DStringBlue(ByRef gp As Graphics, s1 As String, c1 As Boolean, c2 As Boolean, c3 As Boolean, fsize As Integer, s2 As String, i As Integer, x1 As Double, y1 As Double)
        Dim tname As String
        Dim newfont As Font
        tname = s2
        newfont = New Font(s1, fsize, If(c1 = True, FontStyle.Bold, FontStyle.Regular) Or If(c2 = True, FontStyle.Underline, FontStyle.Regular) Or If(c3 = True, FontStyle.Italic, FontStyle.Regular))
        gp.DrawString(tname, newfont, Brushes.Blue, CInt(x1 * twtopi), CInt(y1 * twtopi))
    End Sub
    Public Sub TAG_PRINT_NEW_YARN_01()
        DLine(gpp, 0.3, 0.2, 0.3, 7.5)
        DLine(gpp, 0.3, 0.2, 0.3, 7.5)
        DLine(gpp, 0.3, 0.2, 0.3, 7.5)
        DLine(gpp, 0.3, 0.2, 9.8, 0.2)
        DLine(gpp, 9.8, 0.2, 9.8, 7.5)
        DLine(gpp, 0.3, 7.5, 9.8, 7.5)

        DLine(gpp, 0.3, 1.2, 9.8, 1.2)
        DLine(gpp, 0.3, 5.8, 9.8, 5.8)

        DLine(gpp, 0.3, 9.1, 9.8, 9.1)
        DLine(gpp, 0.3, 9.1, 9.8, 9.1)
        DLine(gpp, 0.3, 11.5, 9.8, 11.5)


        DLine(gpp, 7.8, 5.8, 7.8, 7.5)
        DLine(gpp, 7.8, 6.4, 9.8, 6.4)



        DLine(gpp, 0.3, 7.8, 0.3, 10.1)
        DLine(gpp, 0.3, 7.8, 9.8, 7.8)
        DLine(gpp, 9.8, 7.8, 9.8, 10.1)
        DLine(gpp, 0.3, 10.1, 9.8, 10.1)


        DLine(gpp, 0.3, 10.3, 0.3, 12.6)
        DLine(gpp, 0.3, 10.3, 9.8, 10.3)
        DLine(gpp, 9.8, 10.3, 9.8, 12.6)
        DLine(gpp, 0.3, 12.6, 9.8, 12.6)

        If MdiMenu.M20002.Checked = True Then

            DString(gpp, "Tahoma", True, False, False, 13, " Công ty cổ phần SY VINA ", 0, 1.7, 0.5)
            DString(gpp, "Tahoma", True, False, False, 12, "Sợi : ", 0, 0.4, 1.4)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xYARN, 0, 2.2, 1.4)
            DString(gpp, "Tahoma", True, False, False, 11, "Nhà Cung :", 0, 0.4, 2)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xGNAME, 0, 3.1, 2)

            DString(gpp, "Tahoma", True, False, False, 12, "Xuất xứ  : ", 0, 0.4, 2.6)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xONAT, 0, 2.4, 2.6)

            DString(gpp, "Tahoma", True, False, False, 13, "Màu : ", 0, 5.5, 2.6)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xYCNAME, 0, 7.5, 2.6)

            DString(gpp, "Tahoma", True, False, False, 12, "Số lô : ", 0, 0.4, 3.2)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xLOT, 0, 2.2, 3.2)
            DString(gpp, "Tahoma", True, False, False, 14, "Thùng : ", 0, 5.5, 3.2)
            DString(gpp, "Tahoma", True, False, False, 14, BAR.xGWGT & " Kg", 0, 7.3, 3.2)
            DString(gpp, "Tahoma", True, False, False, 12, "Loại : ", 0, 0.4, 3.9)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.XBSEL, 0, 2, 3.9)
            DString(gpp, "Tahoma", True, False, False, 14, "Số lượng : ", 0, 5.5, 3.9)
            DString(gpp, "Tahoma", True, False, False, 14, BAR.XCON & " Con", 0, 7.3, 3.9)
            DString(gpp, "Tahoma", True, False, False, 12, "Ngày : ", 0, 0.4, 4.5)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xGDATE, 0, 2.1, 4.5)
            DString(gpp, "Tahoma", True, False, False, 14, "Côn  :", 0, 5.5, 4.5)
            DString(gpp, "Tahoma", True, False, False, 14, BAR.XCWGT & " Kg", 0, 7.3, 4.5)
            DString(gpp, "Tahoma", True, False, False, 12, "Người làm : ", 0, 0.4, 5.2)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xSANO, 0, 2.8, 5.2)
            DString(gpp, "Tahoma", True, False, False, 12, " [ Kho ] ", 0, 0.4, 6.2)

            DString(gpp, "Tahoma", True, False, False, 13, " Số", 0, 8.2, 5.9)
            DString(gpp, "Tahoma", True, False, False, 14, CInt(Mid(BAR.xKEY1338.ToString, 11)).ToString("000"), 0, 8.3, 6.7)

            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.1)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.2)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.3)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.4)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.5)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.6)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.7)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.8)
            DString(gpp, "Tahoma", False, False, False, 7, BAR.xKEY1338, 0, 3.2, 7.2)
            DString(gpp, "Tahoma", True, False, False, 8, "N. Cung:", 0, 0.5, 7.9)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xGNAME, 0, 1.9, 7.9)

            DString(gpp, "Tahoma", True, False, False, 8, "Số lô  : ", 0, 7, 7.9)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xLOT, 0, 8.2, 7.9)

            DString(gpp, "Tahoma", True, False, False, 8, "Sợi : ", 0, 0.5, 8.3)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYARN, 0, 1.9, 8.3)


            DString(gpp, "Tahoma", True, False, False, 8, "Màu:", 0, 7, 8.3)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYCNAME, 0, 8.1, 8.3)

            DString(gpp, "Tahoma", True, False, False, 8, "Xuất xứ  : ", 0, 0.5, 8.7)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xONAT, 0, 1.9, 8.7)

            DString(gpp, "Tahoma", True, False, False, 8, "[ " & "1 Thùng : " & BAR.xGWGT & "KG, " & Int(BAR.XCON) & "Côn, " & BAR.XCWGT & "Kg" & "]", 0, 4.5, 8.7)

            DString(gpp, "Tahoma", True, False, False, 10, "[Xuất kho]", 0, 0.4, 9.5)

            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.3)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.4)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.5)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.6)
            DString(gpp, "Tahoma", False, False, False, 10, BAR.xKEY1338, 0, 6, 9.5)



            DString(gpp, "Tahoma", True, False, False, 8, "N. Cung:", 0, 0.5, 10.35)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xGNAME, 0, 1.9, 10.35)

            DString(gpp, "Tahoma", True, False, False, 8, "Số lô  : ", 0, 7, 10.35)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xLOT, 0, 8.2, 10.35)

            DString(gpp, "Tahoma", True, False, False, 8, "Sợi : ", 0, 0.5, 10.7)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYARN, 0, 1.9, 10.7)

            DString(gpp, "Tahoma", True, False, False, 8, "Màu : ", 0, 7, 10.7)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYCNAME, 0, 8.2, 10.7)

            DString(gpp, "Tahoma", True, False, False, 8, "Xuất xứ : ", 0, 0.5, 11.1)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xONAT, 0, 1.9, 11.1)

            DString(gpp, "Tahoma", True, False, False, 8, "[ " & "1 Thùng : " & BAR.xGWGT & "KG, " & Int(BAR.XCON) & "Côn, " & BAR.XCWGT & "Kg" & "]", 0, 4.5, 11.1)

            DString(gpp, "Tahoma", True, False, False, 10, "[Nhập kho ]", 0, 0.4, 11.9)

            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 11.7)
            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 11.8)
            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 11.9)
            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 12)
            DString(gpp, "Tahoma", False, False, False, 10, BAR.xKEY1338, 0, 6, 11.9)

        Else

            DString(gpp, "Tahoma", True, False, False, 13, " SY VINA Joint Stock Company ", 0, 1.7, 0.5)
            DString(gpp, "Tahoma", True, False, False, 12, "Yarn : ", 0, 0.4, 1.4)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xYARN, 0, 2.2, 1.4)
            DString(gpp, "Tahoma", True, False, False, 11, "Supplier :", 0, 0.4, 2)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xGNAME, 0, 3.1, 2)

            DString(gpp, "Tahoma", True, False, False, 12, "Origin  : ", 0, 0.4, 2.6)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xONAT, 0, 2.4, 2.6)

            DString(gpp, "Tahoma", True, False, False, 13, "Color : ", 0, 5.5, 2.6)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xYCNAME, 0, 7.5, 2.6)

            DString(gpp, "Tahoma", True, False, False, 12, "Lot no : ", 0, 0.4, 3.2)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xLOT, 0, 2.2, 3.2)
            DString(gpp, "Tahoma", True, False, False, 14, "Box : ", 0, 5.5, 3.2)
            DString(gpp, "Tahoma", True, False, False, 14, BAR.xGWGT & " Kg", 0, 7.3, 3.2)
            DString(gpp, "Tahoma", True, False, False, 12, "Rate : ", 0, 0.4, 3.9)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.XBSEL, 0, 2, 3.9)
            DString(gpp, "Tahoma", True, False, False, 14, "Qty : ", 0, 5.5, 3.9)
            DString(gpp, "Tahoma", True, False, False, 14, BAR.XCON & " Cone", 0, 7.3, 3.9)
            DString(gpp, "Tahoma", True, False, False, 12, "Date : ", 0, 0.4, 4.5)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xGDATE, 0, 2.1, 4.5)
            DString(gpp, "Tahoma", True, False, False, 14, "Cone  :", 0, 5.5, 4.5)
            DString(gpp, "Tahoma", True, False, False, 14, BAR.XCWGT & " Kg", 0, 7.3, 4.5)
            DString(gpp, "Tahoma", True, False, False, 12, "Incharge : ", 0, 0.4, 5.2)
            DString(gpp, "Tahoma", True, False, False, 12, BAR.xSANO, 0, 2.8, 5.2)
            DString(gpp, "Tahoma", True, False, False, 12, " [ W/H ] ", 0, 0.4, 6.2)

            DString(gpp, "Tahoma", True, False, False, 13, " No", 0, 8.2, 5.9)
            DString(gpp, "Tahoma", True, False, False, 14, CInt(Mid(BAR.xKEY1338.ToString, 11)).ToString("000"), 0, 8.3, 6.7)

            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.1)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.2)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.3)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.4)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.5)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.6)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.7)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 6.8)
            DString(gpp, "Tahoma", False, False, False, 7, BAR.xKEY1338, 0, 3.2, 7.2)
            DString(gpp, "Tahoma", True, False, False, 8, "Supplier:", 0, 0.5, 7.9)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xGNAME, 0, 1.9, 7.9)

            DString(gpp, "Tahoma", True, False, False, 8, "Lot No  : ", 0, 7, 7.9)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xLOT, 0, 8.2, 7.9)

            DString(gpp, "Tahoma", True, False, False, 8, "Yarn : ", 0, 0.5, 8.3)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYARN, 0, 1.9, 8.3)


            DString(gpp, "Tahoma", True, False, False, 8, "Color:", 0, 7, 8.3)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYCNAME, 0, 8.1, 8.3)

            DString(gpp, "Tahoma", True, False, False, 8, "Origin  : ", 0, 0.5, 8.7)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xONAT, 0, 1.9, 8.7)

            DString(gpp, "Tahoma", True, False, False, 8, "[ " & "1 Box : " & BAR.xGWGT & "Kg, " & Int(BAR.XCON) & "Cone, " & BAR.XCWGT & "Kg" & "]", 0, 4.5, 8.7)

            DString(gpp, "Tahoma", True, False, False, 10, "[Outbound]", 0, 0.4, 9.5)

            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.3)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.4)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.5)
            DString(gpp, "code39(1:3)", False, False, False, 11, "*" & BAR.xKEY1338 & "*", 0, 2.5, 9.6)
            DString(gpp, "Tahoma", False, False, False, 10, BAR.xKEY1338, 0, 6, 9.5)



            DString(gpp, "Tahoma", True, False, False, 8, "Supplier:", 0, 0.5, 10.35)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xGNAME, 0, 1.9, 10.35)

            DString(gpp, "Tahoma", True, False, False, 8, "Lot No  : ", 0, 7, 10.35)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xLOT, 0, 8.2, 10.35)

            DString(gpp, "Tahoma", True, False, False, 8, "Yarn : ", 0, 0.5, 10.7)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYARN, 0, 1.9, 10.7)

            DString(gpp, "Tahoma", True, False, False, 8, "Color : ", 0, 7, 10.7)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xYCNAME, 0, 8.2, 10.7)

            DString(gpp, "Tahoma", True, False, False, 8, "Origin : ", 0, 0.5, 11.1)
            DString(gpp, "Tahoma", True, False, False, 8, BAR.xONAT, 0, 1.9, 11.1)

            DString(gpp, "Tahoma", True, False, False, 8, "[ " & "1 Box : " & BAR.xGWGT & "Kg, " & Int(BAR.XCON) & "Cone, " & BAR.XCWGT & "Kg" & "]", 0, 4.5, 11.1)

            DString(gpp, "Tahoma", True, False, False, 10, "[Inbound]", 0, 0.4, 11.9)

            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 11.7)
            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 11.8)
            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 11.9)
            DString(gpp, "code39(1:3)", False, False, False, 11, Chr(42) & BAR.xKEY1338 & Chr(42), 0, 2.5, 12)
            DString(gpp, "Tahoma", False, False, False, 10, BAR.xKEY1338, 0, 6, 11.9)
        End If

    End Sub
    Public Sub DLine(ByRef gp As Graphics, ParamArray dayso() As Double)
        Try
            'gp.DrawLine(New Pen(Brushes.Black, 1), CSng(dayso(0) * twtopi), CSng(dayso(1) * twtopi), CSng(dayso(2) * twtopi), CSng(dayso(3) * twtopi))

            Dim a, b As New PointF
            a = New PointF(dayso(0) * twtopi, dayso(1) * twtopi)
            b = New PointF(dayso(2) * twtopi, dayso(3) * twtopi)

            gp.DrawLine(New Pen(Brushes.Black, 1), a, b)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub DFRact(ByRef gp As Graphics, ByVal LineColor As Object, ParamArray dayso() As Double)
        Try
            'gp.DrawRectangle(New Pen(Brushes.Black, 1), CInt(dayso(0) * twtopi), CInt(dayso(1) * twtopi), CInt(dayso(2) * twtopi), CInt(dayso(3) * twtopi))
            Dim a As New RectangleF
            a = New RectangleF(CDbl(dayso(0) * twtopi), CDbl(dayso(1) * twtopi), CDbl(dayso(2) - dayso(0)) * twtopi, CDbl(dayso(3) - dayso(1)) * twtopi)
            gp.FillRectangle(New SolidBrush(LineColor), a)
        Catch ex As Exception

        End Try

    End Sub
    Public Sub DRact(ByRef gp As Graphics, ParamArray dayso() As Double)
        Try
            'gp.DrawRectangle(New Pen(Brushes.Black, 1), CInt(dayso(0) * twtopi), CInt(dayso(1) * twtopi), (CDecp(dayso(2) - CDecp(dayso(0))) * twtopi), (CDecp(dayso(3) - CDecp(dayso(1))) * twtopi))
        Catch ex As Exception

        End Try

    End Sub
    Public Sub Code128_Print(SCR$, PX As Object, PY As Object, wID As Object, NAR As Object, HIG As Object, Rotation As Object, BarData$, PR As Object)
        Dim i, BAR$, chck, NUMERICTMP$
        Dim j, CHECKCOUNT, BARTMP$
        If IsNumeric(Mid$(BarData$, 1, 2)) Then
            BAR$ = "11010011100"     'CODE C STATR
            chck = 105
        Else
            BAR$ = "11010010000"     'CODE B START
            chck = 104
        End If
        CHECKCOUNT = 1

        NUMERICTMP$ = ""
        For i = 1 To Len(BarData$)
            If IsNumeric(Mid$(BarData$, i, 1)) Then
                NUMERICTMP$ = NUMERICTMP$ + Mid$(BarData$, i, 1)
            Else
                BAR$ = BAR$ + Pattern_Code128B$(Asc(Mid$(BarData$, i, 1)) - 32)
                chck = chck + CHECKCOUNT * (Asc(Mid$(BarData$, i, 1)) - 32)
                CHECKCOUNT = CHECKCOUNT + 1
            End If
        Next i

        If NUMERICTMP$ <> "" Then
            If Len(NUMERICTMP$) > 2 Then
                If Len(NUMERICTMP$) Mod 2 <> 0 Then
                    If CHECKCOUNT = 1 Then
                        BARTMP$ = Mid$(NUMERICTMP$, Len(NUMERICTMP$), 1)
                        NUMERICTMP$ = Mid$(NUMERICTMP$, 1, Len(NUMERICTMP$) - 1)
                    Else
                        BAR$ = BAR$ + Pattern_Code128B$(Asc(Mid$(NUMERICTMP$, 1, 1)) - 32)
                        chck = chck + CHECKCOUNT * (Asc(Mid$(NUMERICTMP$, 1, 1)) - 32)
                        CHECKCOUNT = CHECKCOUNT + 1
                        NUMERICTMP$ = Mid$(NUMERICTMP$, 2, Len(NUMERICTMP$) - 1)
                    End If
                End If
                If CHECKCOUNT <> 1 Then
                    BAR$ = BAR$ + Pattern_Code128B$(99) 'CODE-C·Îº¯°æ
                    chck = chck + CHECKCOUNT * 99
                    CHECKCOUNT = CHECKCOUNT + 1
                End If
                For j = 1 To Len(NUMERICTMP$) Step 2
                    BAR$ = BAR$ + Pattern_Code128B$(Val(Mid$(NUMERICTMP$, j, 2)))
                    chck = chck + CHECKCOUNT * Val(Mid$(NUMERICTMP$, j, 2))
                    CHECKCOUNT = CHECKCOUNT + 1
                Next j
                If BARTMP$ <> "" Then
                    BAR$ = BAR$ + Pattern_Code128B$(100)
                    chck = chck + CHECKCOUNT * 100
                    CHECKCOUNT = CHECKCOUNT + 1
                    BAR$ = BAR$ + Pattern_Code128B$(Asc(BARTMP$) - 32)
                    chck = chck + CHECKCOUNT * (Asc(BARTMP$) - 32)
                    CHECKCOUNT = CHECKCOUNT + 1
                End If

                If (i < Len(BarData$)) And (BARTMP$ = "") Then
                    BAR$ = BAR$ + Pattern_Code128B$(100)
                    chck = chck + CHECKCOUNT * 100
                    CHECKCOUNT = CHECKCOUNT + 1
                End If
            Else
                If Len(NUMERICTMP$) = 2 Then
                    BAR$ = BAR$ + Pattern_Code128B$(Val(Mid$(NUMERICTMP$, 1, 2)))
                    chck = chck + CHECKCOUNT * Val(Mid$(NUMERICTMP$, 1, 2))
                    CHECKCOUNT = CHECKCOUNT + 1
                Else
                    BAR$ = BAR$ + Pattern_Code128B$(Asc(Mid$(NUMERICTMP$, 1, 1)) - 32)
                    chck = chck + CHECKCOUNT * (Asc(Mid$(NUMERICTMP$, 1, 1)) - 32)
                    CHECKCOUNT = CHECKCOUNT + 1
                End If
            End If
            NUMERICTMP$ = ""
            BARTMP$ = ""
        End If

        chck = chck Mod 103
        BAR$ = Trim(BAR$ + Pattern_Code128B$(chck) + "11000111010110")

        Call Barcode_Print(SCR$, PX, PY, wID, NAR, HIG, Rotation, BAR$, PR)
    End Sub
    Public Sub Barcode_Print(SCR$, PX As Object, PY As Object, wID As Object, NAR As Object, HIG As Object, Rotation As Object, Bar$, PR As Object)
        Dim i, BarPos, j
        BarPos = 0
        wID = wID

        For i = 1 To Len(Bar$)
            If Mid$(Bar$, i, 1) = "1" Then
                Select Case Rotation
                    Case 0
                        If NAR < 0.01 Then
                            Call Tec_Line(SCR$, PX + BarPos, PY, PX + wID + BarPos, PY + HIG, Color.Black, 2, PR)
                            BarPos = BarPos + wID
                        End If

                        For j = 0.01 To NAR Step 0.01
                            Call Tec_Line(SCR$, PX + BarPos, PY, PX + wID + BarPos, PY + HIG, Color.Black, 2, PR)
                            BarPos = BarPos + wID
                        Next j
                    Case 1
                        Call Tec_Line(SCR$, PX - HIG - 100, PY + BarPos, PX, PY + BarPos + wID, Color.Black, 2, PR)
                        BarPos = BarPos + wID
                End Select

            Else
                Select Case Rotation
                    Case 0
                        If NAR < 0.01 Then
                            Call Tec_Line(SCR$, PX + BarPos, PY, PX + wID + BarPos, PY + HIG, Color.White, 2, PR)
                            BarPos = BarPos + wID
                        End If

                        For j = 0.01 To NAR Step 0.01
                            Call Tec_Line(SCR$, PX + BarPos, PY, PX + wID + BarPos, PY + HIG, Color.White, 2, PR)
                            BarPos = BarPos + wID
                        Next j

                    Case 1
                        Call Tec_Line(SCR$, PX - HIG - 100, PY + BarPos, PX, PY + BarPos + wID, Color.White, 2, PR)
                        BarPos = BarPos + wID
                End Select
            End If

        Next i

    End Sub
    Public Sub Tec_Line(SCR$, TopX As Object, TopY As Object, BottomX As Object, BottomY As Object, LineColor As Object, LineType As Object, PR As Object)
        If UCase$(SCR$) = "P" Then
            Select Case LineType
                Case 0
                    DLine(gpp, TopX + lR, TopY + UD, BottomX + lR, BottomY + UD)
                Case 1
                    DRact(gpp, TopX + lR, TopY + UD, BottomX + lR, BottomY + UD)
                Case 2
                    DFRact(gpp, LineColor, TopX + lR, TopY + UD, BottomX + lR, BottomY + UD)
            End Select
        Else
            DRact(gpp, TopX, TopY, BottomX, BottomY)
        End If
    End Sub
    Public Function Pattern_Code128B$(Pat)
        Pattern_Code128B$ = "11011001100"

        Select Case Pat
            '                                BARCODE       CODE A   CODE B   CODE C
            '                             ==========================================
            Case 0 : Pattern_Code128B$ = "11011001100"  ' Space     Space     00
            Case 1 : Pattern_Code128B$ = "11001101100"  '   !         !       01
            Case 2 : Pattern_Code128B$ = "11001100110"  '   "         "       02
            Case 3 : Pattern_Code128B$ = "10010011000"  '   #         #       03
            Case 4 : Pattern_Code128B$ = "10010001100"  '   $         $       04
            Case 5 : Pattern_Code128B$ = "10001001100"  '   %         %       05
            Case 6 : Pattern_Code128B$ = "10011001000"  '   &         &       06
            Case 7 : Pattern_Code128B$ = "10011000100"  '   '         '       07
            Case 8 : Pattern_Code128B$ = "10001100100"  '   (         (       08
            Case 9 : Pattern_Code128B$ = "11001001000"  '   )         )       09
            Case 10 : Pattern_Code128B$ = "11001000100" '   *         *       10
            Case 11 : Pattern_Code128B$ = "11000100100" '   +         +       11
            Case 12 : Pattern_Code128B$ = "10110011100" '   ,         ,       12
            Case 13 : Pattern_Code128B$ = "10011011100" '   -         -       13
            Case 14 : Pattern_Code128B$ = "10011001110" '   .         .       14
            Case 15 : Pattern_Code128B$ = "10111001100" '   /         /       15
            Case 16 : Pattern_Code128B$ = "10011101100" '   0         0       16
            Case 17 : Pattern_Code128B$ = "10011100110" '   1         1       17
            Case 18 : Pattern_Code128B$ = "11001110010" '   2         2       18
            Case 19 : Pattern_Code128B$ = "11001011100" '   3         3       19
            Case 20 : Pattern_Code128B$ = "11001001110" '   4         4       20
            Case 21 : Pattern_Code128B$ = "11011100100" '   5         5       21
            Case 22 : Pattern_Code128B$ = "11001110100" '   6         6       22
            Case 23 : Pattern_Code128B$ = "11101101110" '   7         7       23
            Case 24 : Pattern_Code128B$ = "11101001100" '   8         8       24
            Case 25 : Pattern_Code128B$ = "11100101100" '   9         9       25
            Case 26 : Pattern_Code128B$ = "11100100110" '   :         :       26
            Case 27 : Pattern_Code128B$ = "11101100100" '   ;         ;       27
            Case 28 : Pattern_Code128B$ = "11100110100" '   <         <       28
            Case 29 : Pattern_Code128B$ = "11100110010" '   =         =       29
            Case 30 : Pattern_Code128B$ = "11011011000" '   >         >       30
            Case 31 : Pattern_Code128B$ = "11011000110" '   ?         ?       31
            Case 32 : Pattern_Code128B$ = "11000110110" '   @         @       32
            Case 33 : Pattern_Code128B$ = "10100011000" '   A         A       33
            Case 34 : Pattern_Code128B$ = "10001011000" '   B         B       34
            Case 35 : Pattern_Code128B$ = "10001000110" '   C         C       35
            Case 36 : Pattern_Code128B$ = "10110001000" '   D         D       36
            Case 37 : Pattern_Code128B$ = "10001101000" '   E         E       37
            Case 38 : Pattern_Code128B$ = "10001100010" '   F         F       38
            Case 39 : Pattern_Code128B$ = "11010001000" '   G         G       39
            Case 40 : Pattern_Code128B$ = "11000101000" '   H         H       40
            Case 41 : Pattern_Code128B$ = "11000100010" '   I         I       41
            Case 42 : Pattern_Code128B$ = "10110111000" '   J         J       42
            Case 43 : Pattern_Code128B$ = "10110001110" '   K         K       43
            Case 44 : Pattern_Code128B$ = "10001101110" '   L         L       44
            Case 45 : Pattern_Code128B$ = "10111011000" '   M         M       45
            Case 46 : Pattern_Code128B$ = "10111000110" '   N         N       46
            Case 47 : Pattern_Code128B$ = "10001110110" '   O         O       47
            Case 48 : Pattern_Code128B$ = "11101110110" '   P         P       48
            Case 49 : Pattern_Code128B$ = "11010001110" '   Q         Q       49
            Case 50 : Pattern_Code128B$ = "11000101110" '   R         R       50
            Case 51 : Pattern_Code128B$ = "11011101000" '   S         S       51
            Case 52 : Pattern_Code128B$ = "11011100010" '   T         T       52
            Case 53 : Pattern_Code128B$ = "11011101110" '   U         U       53
            Case 54 : Pattern_Code128B$ = "11101011000" '   V         V       54
            Case 55 : Pattern_Code128B$ = "11101000110" '   W         W       55
            Case 56 : Pattern_Code128B$ = "11100010110" '   X         X       56
            Case 57 : Pattern_Code128B$ = "11101101000" '   Y         Y       57
            Case 58 : Pattern_Code128B$ = "11101100010" '   Z         Z       58
            Case 59 : Pattern_Code128B$ = "11100011010" '   [         [       59
            Case 60 : Pattern_Code128B$ = "11101111010" '   \         \       60
            Case 61 : Pattern_Code128B$ = "11001000010" '   ]         ]       61
            Case 62 : Pattern_Code128B$ = "11110001010" '   ^         ^       62
            Case 63 : Pattern_Code128B$ = "10100110000" '   _         _       63
            Case 64 : Pattern_Code128B$ = "10100001100" '  NUL        `       64
            Case 65 : Pattern_Code128B$ = "10010110000" '  SOH        a       65
            Case 66 : Pattern_Code128B$ = "10010000110" '  STX        b       66
            Case 67 : Pattern_Code128B$ = "10000101100" '  ETX        c       67
            Case 68 : Pattern_Code128B$ = "10000100110" '  EOT        d       68
            Case 69 : Pattern_Code128B$ = "10110010000" '  END        e       69
            Case 70 : Pattern_Code128B$ = "10110000100" '  ACK        f       70
            Case 71 : Pattern_Code128B$ = "10011010000" '  BEL        g       71
            Case 72 : Pattern_Code128B$ = "10011000010" '  BS         h       72
            Case 73 : Pattern_Code128B$ = "10000110100" '  HT         i       73
            Case 74 : Pattern_Code128B$ = "10000110010" '  LF         j       74
            Case 75 : Pattern_Code128B$ = "11000010010" '  VT         k       75
            Case 76 : Pattern_Code128B$ = "11001010000" '  FF         l       76
            Case 77 : Pattern_Code128B$ = "11110111010" '  CR         m       77
            Case 78 : Pattern_Code128B$ = "11000010100" '  SO         n       78
            Case 79 : Pattern_Code128B$ = "10001111010" '  SI         o       79
            Case 80 : Pattern_Code128B$ = "10100111100" '  DLE        p       80
            Case 81 : Pattern_Code128B$ = "10010111100" '  DC1        q       81
            Case 82 : Pattern_Code128B$ = "10010011110" '  DC2        r       82
            Case 83 : Pattern_Code128B$ = "10111100100" '  DC3        s       83
            Case 84 : Pattern_Code128B$ = "10011110100" '  DC4        t       84
            Case 85 : Pattern_Code128B$ = "10011110010" '  NAK        u       85
            Case 86 : Pattern_Code128B$ = "11110100100" '  SYN        v       86
            Case 87 : Pattern_Code128B$ = "11110010100" '  ETB        w       87
            Case 88 : Pattern_Code128B$ = "11110010010" '  CAN        x       88
            Case 89 : Pattern_Code128B$ = "11011011110" '  EM         y       89
            Case 90 : Pattern_Code128B$ = "11011110110" '  SUB        z       90
            Case 91 : Pattern_Code128B$ = "11110110110" '  ESC        {       91
            Case 92 : Pattern_Code128B$ = "10101111000" '  FS         |       92
            Case 93 : Pattern_Code128B$ = "10100011110" '  GS         }       93
            Case 94 : Pattern_Code128B$ = "10001011110" '  RS         ~       94
            Case 95 : Pattern_Code128B$ = "10111101000" '  US        DEL      95
            Case 96 : Pattern_Code128B$ = "10111100010" ' FNC3      FNC3      96
            Case 97 : Pattern_Code128B$ = "11110101000" ' FNC2      FNC2      97
            Case 98 : Pattern_Code128B$ = "11110100010" ' Shift     Shift     98
            Case 99 : Pattern_Code128B$ = "10111011110" ' Code C    Code C    99
            Case 100 : Pattern_Code128B$ = "10111101110" ' Code B    FNC4     Code B
            Case 101 : Pattern_Code128B$ = "11101011110" ' FNC4      Code A   Code A
            Case 102 : Pattern_Code128B$ = "11110101110" ' FNC1      FNC1     FNC 1
            Case 103 : Pattern_Code128B$ = "11010000100" '     START (CODE A)
            Case 104 : Pattern_Code128B$ = "11010010000" '     START (CODE B)
            Case 105 : Pattern_Code128B$ = "11010011100" '     START (CODE C
        End Select

    End Function
#End Region

    

    
End Module
