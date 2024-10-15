Imports Spire.Barcode
Module M_REPORT

#Region "Variable"
    Public FontPreview As Integer = 50
    Public chk_Preview As Boolean = False
    Public chk_Print As Boolean = True

    Public chk_TradingExportColor As Boolean = False
#End Region

#Region "Methods"
    Public VAL_AREA As PARAMETER_AREA

    Public Structure PARAMETER_AREA
        Public PR01 As String
        Public PR02 As String
        Public PR03 As String
        Public PR04 As String
        Public PR05 As String
        Public PR06 As String
        Public PR07 As String
        Public PR08 As String
        Public PR09 As String
        Public PR10 As String
        Public PR11 As String
        Public PR12 As String
        Public PR13 As String
        Public PR14 As String
        Public PR15 As String
        Public PR16 As String
        Public PR17 As String
        Public PR18 As String
        Public PR19 As String
        Public PR20 As String
    End Structure

    Public Sub CLEAR_VAL_PARAMETER_AREA()
        VAL_AREA.PR01 = ""
        VAL_AREA.PR02 = ""
        VAL_AREA.PR03 = ""
        VAL_AREA.PR04 = ""
        VAL_AREA.PR05 = ""
        VAL_AREA.PR06 = ""
        VAL_AREA.PR07 = ""
        VAL_AREA.PR08 = ""
        VAL_AREA.PR09 = ""
        VAL_AREA.PR10 = ""
        VAL_AREA.PR11 = ""
        VAL_AREA.PR12 = ""
        VAL_AREA.PR13 = ""
        VAL_AREA.PR14 = ""
        VAL_AREA.PR15 = ""
        VAL_AREA.PR16 = ""
        VAL_AREA.PR17 = ""
        VAL_AREA.PR18 = ""
        VAL_AREA.PR19 = ""
        VAL_AREA.PR20 = ""
    End Sub

    Public Sub TAG_PRINT_STANDARD(strCodeName As String, strStoreName As String, ByVal ParamArray Param() As Object)
        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")
        Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType

        DS1 = PrcDS("USP_PFT9000_SEARCH_VS1", cn, strCodeName)
        DS2 = PrcDS(strStoreName, cn, Param)

        Dim i, j As Integer
        Dim tStr As String
        Dim tStr2() As String

        Dim a, b, c, d, e As Decimal
        Dim px, py As PointF
        Dim newfont As Font
        Dim tname As String
        Dim twtopix As Decimal = (1440 / 96)

        If GetDsRc(DS1) > 0 Then

            For i = 0 To GetDsRc(DS1) - 1
                tStr = GetDsData(DS1, i, "CONTENTS1")
                tStr2 = tStr.Split(";")

                Select Case tStr2(0)
                    Case "L"
                        a = CDecp(tStr2(1) / twtopix)
                        b = CDecp(tStr2(2) / twtopix)
                        c = CDecp(tStr2(3) / twtopix)
                        d = CDecp(tStr2(4) / twtopix)
                        e = CDecp(tStr2(5))
                        px = New PointF(a, b)
                        py = New PointF(c, d)

                        gpp.DrawLine(New Pen(Brushes.Black, e), px, py)

                    Case "T"
                        tname = tStr2(3)

                        If tname.Length > 1 And tname.Contains("@") Then
                            If tname.ToUpper.Contains("BARCODE") Then
                                tname = GetDsData(DS2, 0, Replace(tname, "@", ""))

                                a = CDecp(tStr2(1) / twtopix / twtopi)
                                b = CDecp(tStr2(2) / twtopix / twtopi)

                                Call Code128_Print("P", a, b, 0.025, 0.005, 0.7, 0, FormatCut(tname), Nothing)

                            Else
                                tname = GetDsData(DS2, 0, Replace(tname, "@", ""))
                                newfont = New Font(tStr2(4), CSng(tStr2(5)), If(tStr2(7) = True, FontStyle.Bold, FontStyle.Regular) Or If(tStr2(8) = True, FontStyle.Underline, FontStyle.Regular) Or If(tStr2(9) = True, FontStyle.Italic, FontStyle.Regular))
                                a = CDecp(tStr2(1) / twtopix)
                                b = CDecp(tStr2(2) / twtopix)
                                px = New PointF(a, b)
                                gpp.DrawString(tname, newfont, Brushes.Black, px)

                            End If
                        End If



                    Case "F"
                        tname = GetDsData(DS2, 0, j)
                        j += 1

                        newfont = New Font(tStr2(4), CSng(tStr2(5)), If(tStr2(7) = True, FontStyle.Bold, FontStyle.Regular) Or If(tStr2(8) = True, FontStyle.Underline, FontStyle.Regular) Or If(tStr2(9) = True, FontStyle.Italic, FontStyle.Regular))
                        a = CDecp(tStr2(1) / twtopix)
                        b = CDecp(tStr2(2) / twtopix)
                        px = New PointF(a, b)
                        gpp.DrawString(tname, newfont, Brushes.Black, px)


                    Case "P"
                        settings.Type = BarCodeType.QRCode
                        settings.Unit = GraphicsUnit.Pixel
                        settings.ShowText = False
                        settings.ResolutionType = ResolutionType.UseDpi
                        settings.Data = GetDsData(DS2, 0, "Barcode")
                        'settings.X = 3
                        settings.ForeColor = Color.Black
                        settings.BackColor = Color.White
                        settings.QRCodeECL = QRCodeECL.L
                        settings.ResolutionType = ResolutionType.UseDpi
                        Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)
                        Dim QRbarcode As Image = generator.GenerateImage
                        a = tStr2(1) / twtopix
                        b = tStr2(2) / twtopix
                        c = tStr2(3) / twtopix
                        d = tStr2(4) / twtopix


                        gpp.DrawImage(QRbarcode, a, b, c - a, d - b)




                End Select

            Next i

        End If
    End Sub
    Public Sub TAG_PRINT_OS_PANEL_4Barcode()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        ' Jun change for P570 2019/03/28 11:05 AM

        If OSPANEL1.SlNo <> "" Then


            'DString(gpp, "Arial", True, False, False, 9, OSPANEL1.SizeName, 0, 0.3, 0.2)

            'DString(gpp, "Arial", True, False, True, 9, OSPANEL1.QtySize, 0, 1.8, 0.2)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL1.ColorName, 0, 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL1.MoldName, 0, 0.3, 1.2)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL1.SlNo, 0, 0.3, 1.6)

            'DString(gpp, "Arial", True, False, False, 8, OSPANEL1.Machine, 0, 1.8, 1.6)

            'Call Code128_Print("P", 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL1.Barcode), Nothing)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL1.Barcode, 0, 0.3, 2.7)


            DString(gpp, "Arial", False, False, False, 8, OSPANEL1.SlNo, 0, 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL1.MoldName, 0, 0.3, 0.8)

            DString(gpp, "Arial", True, False, False, 18, OSPANEL1.SizeName, 0, 0.3, 1.2)

            DString(gpp, "Arial", True, False, True, 18, OSPANEL1.QtySize, 0, 1.8, 1.2)

            Call Code128_Print("P", 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL1.Barcode), Nothing)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL1.Barcode, 0, 0.3, 2.7)

        End If


        If OSPANEL2.SlNo <> "" Then


            'DString(gpp, "Arial", True, False, False, 9, OSPANEL2.SizeName, 0, XPlus1 + 0.3, 0.2)

            'DString(gpp, "Arial", True, False, True, 9, OSPANEL2.QtySize, 0, XPlus1 + 1.8, 0.2)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL2.ColorName, 0, XPlus1 + 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL2.MoldName, 0, XPlus1 + 0.3, 1.2)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL2.SlNo, 0, XPlus1 + 0.3, 1.6)

            'DString(gpp, "Arial", True, False, False, 8, OSPANEL2.Machine, 0, XPlus1 + 1.8, 1.6)

            'Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL2.Barcode), Nothing)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL2.Barcode, 0, XPlus1 + 0.3, 2.7)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL2.SlNo, 0, XPlus1 + 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL2.MoldName, 0, XPlus1 + 0.3, 0.8)

            DString(gpp, "Arial", True, False, False, 18, OSPANEL2.SizeName, 0, XPlus1 + 0.3, 1.2)

            DString(gpp, "Arial", True, False, True, 18, OSPANEL2.QtySize, 0, XPlus1 + 1.8, 1.2)

            Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL2.Barcode), Nothing)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL2.Barcode, 0, XPlus1 + 0.3, 2.7)

        End If

        If OSPANEL3.SlNo <> "" Then


            'DString(gpp, "Arial", True, False, False, 9, OSPANEL3.SizeName, 0, XPlus2 + 0.3, 0.2)

            'DString(gpp, "Arial", True, False, True, 9, OSPANEL3.QtySize, 0, XPlus2 + 1.8, 0.2)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL3.ColorName, 0, XPlus2 + 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL3.MoldName, 0, XPlus2 + 0.3, 1.2)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL3.SlNo, 0, XPlus2 + 0.3, 1.6)

            'DString(gpp, "Arial", True, False, False, 8, OSPANEL3.Machine, 0, XPlus2 + 1.8, 1.6)

            'Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL3.Barcode), Nothing)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL3.Barcode, 0, XPlus2 + 0.3, 2.7)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL3.SlNo, 0, XPlus2 + 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL3.MoldName, 0, XPlus2 + 0.3, 0.8)

            DString(gpp, "Arial", True, False, False, 18, OSPANEL3.SizeName, 0, XPlus2 + 0.3, 1.2)

            DString(gpp, "Arial", True, False, True, 18, OSPANEL3.QtySize, 0, XPlus2 + 1.8, 1.2)

            Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL3.Barcode), Nothing)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL3.Barcode, 0, XPlus2 + 0.3, 2.7)

        End If

        If OSPANEL4.SlNo <> "" Then


            'DString(gpp, "Arial", True, False, False, 9, OSPANEL4.SizeName, 0, XPlus3 + 0.3, 0.2)

            'DString(gpp, "Arial", True, False, True, 9, OSPANEL4.QtySize, 0, XPlus3 + 1.8, 0.2)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL4.ColorName, 0, XPlus3 + 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL4.MoldName, 0, XPlus3 + 0.3, 1.2)
            'DString(gpp, "Arial", False, False, False, 8, OSPANEL4.SlNo, 0, XPlus3 + 0.3, 1.6)

            'DString(gpp, "Arial", True, False, False, 8, OSPANEL4.Machine, 0, XPlus3 + 1.8, 1.6)

            'Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL4.Barcode), Nothing)

            'DString(gpp, "Arial", False, False, False, 8, OSPANEL4.Barcode, 0, XPlus3 + 0.3, 2.7)


            DString(gpp, "Arial", False, False, False, 8, OSPANEL4.SlNo, 0, XPlus3 + 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL4.MoldName, 0, XPlus3 + 0.3, 0.8)

            DString(gpp, "Arial", True, False, False, 18, OSPANEL4.SizeName, 0, XPlus3 + 0.3, 1.2)

            DString(gpp, "Arial", True, False, True, 18, OSPANEL4.QtySize, 0, XPlus3 + 1.8, 1.2)

            Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.017, 0.003, 0.6, 0, FormatCut(OSPANEL4.Barcode), Nothing)

            DString(gpp, "Arial", False, False, False, 8, OSPANEL4.Barcode, 0, XPlus3 + 0.3, 2.7)

        End If
        ' End Jun change for P570 2019/03/28 11:05 AM
    End Sub
    Public Sub TAG_PRINT_MATERIAL_01_BACKUP() 'iN THU 
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)

        DLine(gpp, 9.8, 0.3, 9.8, 7.5)

        ' -------- vach ngang --------'
        DLine(gpp, 0.3, 0.4, 9.8, 0.4)  '' thay doi 0.4 coi nhu chuan
        'DLine(gpp, 0.3, 1.2, 9.8, 1.2) '' 

        'DLine(gpp, 0.3, 3.6, 9.8, 3.6)
        'DLine(gpp, 0.3, 4.4, 9.8, 4.4)
        'DLine(gpp, 0.3, 5.2, 9.8, 5.2)

        'DLine(gpp, 0.3, 6.4, 9.8, 6.4)
        'DLine(gpp, 0.3, 7.5, 9.8, 7.5)
        '-----------------------------'

        DLine(gpp, 0.3, 7.8, 9.8, 7.8)
        DLine(gpp, 0.3, 9.3, 9.8, 9.3)
        DLine(gpp, 0.3, 10.1, 9.8, 10.1)

        '-----------vach giua--------'
        DLine(gpp, 0.3, 10.3, 0.3, 12.6)
        DLine(gpp, 0.3, 10.3, 9.8, 10.3)
        DLine(gpp, 9.8, 10.3, 9.8, 12.6)
        DLine(gpp, 0.3, 12.6, 9.8, 12.6)
        '----------------------------'
        DLine(gpp, 0.3, 7.8, 0.3, 10.1)

        DLine(gpp, 9.8, 7.8, 9.8, 10.1)

        'If chk_Preview = False Then
        '    DString(gpp, "Arial", True, False, False, 50, MATERIAL.MaterialName, 0, 0.1, 0.3)
        'Else
        '    DString(gpp, "Arial", True, False, False, FontPreview, MATERIAL.MaterialName, 0, 0.1, 0.3)
        'End If

        DString(gpp, "Arial", True, False, False, FontPreview, MATERIAL.MaterialName, 0, 0.1, 0.3)

        DString(gpp, "Arial", True, False, False, 45, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 0.5, 2.8)

        DString(gpp, "Arial", True, False, False, 30, FSDate(MATERIAL.DateInBoundMaterial) & "  [" & MATERIAL.MaterialInBoundSno & "]", 0, 0.5, 4.7)


        Call Code128_Print("P", 2.5, 6.2, 0.04, 0.003, 0.8, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 3.6, 7)

        ' ------------------------------------------MAIN LABLE----------------------------------------------------

        If MATERIAL.MaterialName.Length > 8 Then
            DString(gpp, "Arial", True, False, False, 20, MATERIAL.MaterialName, 0, 0.3, 7.8)
        Else
            DString(gpp, "Arial", True, False, False, 30, MATERIAL.MaterialName, 0, 0.3, 7.8)
        End If


        DString(gpp, "Arial", True, False, False, 20, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 5.7, 7.8)

        DString(gpp, "Arial", True, False, False, 20, FSDate(MATERIAL.DateInBoundMaterial), 0, 5.7, 8.5)

        DString(gpp, "Arial", True, False, False, 8, "[OUTBOUND]", 0, 0.3, 9.5)

        Call Code128_Print("P", 2.5, 9.4, 0.025, 0.003, 0.5, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 9.3)

        '----------------------------------------------INBOUND LABLE------------------------------------------------

        If MATERIAL.MaterialName.Length > 8 Then
            DString(gpp, "Arial", True, False, False, 20, MATERIAL.MaterialName, 0, 0.3, 10.3)
        Else
            DString(gpp, "Arial", True, False, False, 30, MATERIAL.MaterialName, 0, 0.3, 10.3)
        End If



        DString(gpp, "Arial", True, False, False, 20, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 5.7, 10.3)

        DString(gpp, "Arial", True, False, False, 20, FSDate(MATERIAL.DateInBoundMaterial), 0, 5.7, 11)

        DString(gpp, "Arial", True, False, False, 8, "[INBOUND]", 0, 0.3, 12)

        Call Code128_Print("P", 2.5, 11.9, 0.025, 0.003, 0.5, 0, FormatCut(MATERIAL.Barcode), Nothing)
        'DString(gpp, "code39(2:3)", False, False, False, 16, "*" & MATERIAL.Barcode & "*", 0, 2.5, 11.6)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 12)

        '----------------------------------------------OUTBOUND LABLE------------------------------------------------
    End Sub
    Public Sub TAG_PRINT_MATERIAL_01()
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)

        DLine(gpp, 9.8, 0.3, 9.8, 7.5)

        DLine(gpp, 0.3, 0.4, 9.8, 0.4)

        DLine(gpp, 0.3, 7.8, 9.8, 7.8)
        DLine(gpp, 0.3, 9.3, 9.8, 9.3)
        DLine(gpp, 0.3, 10.1, 9.8, 10.1)

        '-----------vach giua--------'
        DLine(gpp, 0.3, 10.3, 0.3, 12.6)
        DLine(gpp, 0.3, 10.3, 9.8, 10.3)
        DLine(gpp, 9.8, 10.3, 9.8, 12.6)
        DLine(gpp, 0.3, 12.6, 9.8, 12.6)
        '----------------------------'
        DLine(gpp, 0.3, 7.8, 0.3, 10.1)

        DLine(gpp, 9.8, 7.8, 9.8, 10.1)

        If READ_PFK7233(MATERIAL.MaterialCode) = True Then
            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center

            Dim rect2 As New RectangleF(D7233.POSX * 100, D7233.POSY * 50, 380.0F, 120.0F)
            gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), rect2, stringFormat)
            'gpp.DrawRectangle(Pens.Black, Rectangle.Round(rect2))

            'gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), D7233.POSX, D7233.POSY)

            'gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), D7233.POSX, D7233.POSY)
            'DString(gpp, D7233.FontName, CboolP(D7233.FontBold), False, False, D7233.FontSize, MATERIAL.MaterialName, 0, D7233.POSX, D7233.POSY)
        Else
            DString(gpp, "Arial", True, False, False, 50, MATERIAL.MaterialName, 0, 0.1, 0.3)
        End If


        DString(gpp, "Arial", True, False, False, 45, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 0.5, 2.8)

        DString(gpp, "Arial", True, False, False, 30, FSDate(MATERIAL.DateInBoundMaterial) & "  [" & MATERIAL.MaterialInBoundSno & "]", 0, 0.5, 4.7)


        Call Code128_Print("P", 2.5, 6.2, 0.04, 0.003, 0.8, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 3.6, 7)

        ' ------------------------------------------MAIN LABLE----------------------------------------------------

        If MATERIAL.MaterialName.Length > 8 Then
            DString(gpp, "Arial", True, False, False, 20, MATERIAL.MaterialName, 0, 0.3, 7.8)
        Else
            DString(gpp, "Arial", True, False, False, 30, MATERIAL.MaterialName, 0, 0.3, 7.8)
        End If


        DString(gpp, "Arial", True, False, False, 20, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 5.7, 7.8)

        DString(gpp, "Arial", True, False, False, 20, FSDate(MATERIAL.DateInBoundMaterial), 0, 5.7, 8.5)

        DString(gpp, "Arial", True, False, False, 8, "[OUTBOUND]", 0, 0.3, 9.5)

        Call Code128_Print("P", 2.5, 9.4, 0.025, 0.003, 0.5, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 9.3)

        '----------------------------------------------INBOUND LABLE------------------------------------------------

        If MATERIAL.MaterialName.Length > 8 Then
            DString(gpp, "Arial", True, False, False, 20, MATERIAL.MaterialName, 0, 0.3, 10.3)
        Else
            DString(gpp, "Arial", True, False, False, 30, MATERIAL.MaterialName, 0, 0.3, 10.3)
        End If



        DString(gpp, "Arial", True, False, False, 20, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 5.7, 10.3)

        DString(gpp, "Arial", True, False, False, 20, FSDate(MATERIAL.DateInBoundMaterial), 0, 5.7, 11)

        DString(gpp, "Arial", True, False, False, 8, "[INBOUND]", 0, 0.3, 12)

        Call Code128_Print("P", 2.5, 11.9, 0.025, 0.003, 0.5, 0, FormatCut(MATERIAL.Barcode), Nothing)
        'DString(gpp, "code39(2:3)", False, False, False, 16, "*" & MATERIAL.Barcode & "*", 0, 2.5, 11.6)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 12)

        '----------------------------------------------OUTBOUND LABLE------------------------------------------------
    End Sub
    'SHV MATERIAL LABLE
    Public Sub TAG_PRINT_MATERIAL_NEW()
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        DLine(gpp, 0.3, 0.4, 0.3, 10.1)
        DLine(gpp, 0.3, 0.4, 9.8, 0.4)

        DLine(gpp, 9.8, 10.1, 9.8, 0.4)
        DLine(gpp, 9.8, 10.1, 0.3, 10.1)

        DLine(gpp, 0.3, 2.4, 9.8, 2.4)
        DLine(gpp, 6.3, 2.4, 6.3, 10.1)

        'vạch kẻ chỗ ngày tháng 
        DLine(gpp, 6.3, 3.4, 9.8, 3.4)
        DLine(gpp, 8, 2.4, 8, 10.1)

        DString(gpp, "Arial", False, False, False, 9, "Date", 0, 6.8, 2.7)
        DString(gpp, "Arial", False, False, False, 9, "Qty Out", 0, 8.3, 2.7)

        Dim rect01 As New RectangleF(15, 10, 380.0F, 30.0F)
        Dim rect02 As New RectangleF(15, 25, 380.0F, 30.0F)

        If READ_PFK7411(Pub.SAW) = True Then
            If D7411.cdSite = "" Then D7411.cdSite = "001"

            If READ_PFK7171(ListCode("Site"), D7411.cdSite) Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If
        Else
            If READ_PFK7171(ListCode("Site"), "001") Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If

        End If

        'gpp.DrawString("CÔNG TY CỔ PHẦN SUNG HYUN VINA", New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
        'gpp.DrawString("KCN Bình Đường, TX Dĩ An, Bình Dương", New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)

        DString(gpp, "Arial", False, False, False, 9, "Supplier: " & MATERIAL.SupplierName, 0, 0.3, 2.5)

        If READ_PFK7233(MATERIAL.MaterialCode) = True Then
            Dim rect2 As New RectangleF(D7233.POSX * 100, D7233.POSY * 50, 380.0F, 120.0F)
            gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), rect2, stringFormat)
            'gpp.DrawRectangle(Pens.Black, Rectangle.Round(rect2))

            'gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), D7233.POSX, D7233.POSY)

            'gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), D7233.POSX, D7233.POSY)
            'DString(gpp, D7233.FontName, CboolP(D7233.FontBold), False, False, D7233.FontSize, MATERIAL.MaterialName, 0, D7233.POSX, D7233.POSY)
        Else
            DString(gpp, "Arial", True, False, False, 50, MATERIAL.MaterialName, 0, 0.1, 0.3)
        End If

        DString(gpp, "Arial", False, False, False, 9, "Color: " & MATERIAL.LCNO, 0, 0.3, 3)
        DString(gpp, "Arial", False, False, False, 9, "Specification: " & MATERIAL.LCNO, 0, 0.3, 3.5)
        DString(gpp, "Arial", False, False, False, 9, "Lot No: " & MATERIAL.LotNO, 0, 0.3, 4)
        DString(gpp, "Arial", False, False, False, 9, "Seal No: ", 0, 0.3, 4.5)
        DString(gpp, "Arial", True, False, False, 40, Format0(MATERIAL.QtyInBound), 0, 1, 5)
        DString(gpp, "Arial", True, False, False, 20, MATERIAL.cdUnitMaterialName.ToUpper & "/" & MATERIAL.cdUnitPackingName, 0, 3.3, 6.5)
        DString(gpp, "Arial", True, False, False, 9, FSDate(MATERIAL.DateInBoundMaterial) & "  [" & MATERIAL.InchargeInBoundName & "]", 0, 0.3, 7.5)

        Call Code128_Print("P", 1.3, 8.1, 0.03, 0.003, 0.8, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 2, 9)


    End Sub
    Public Sub TAG_PRINT_MATERIAL_NEW_F1()
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center


        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")
        Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType

        DLine(gpp, 0.3, 0.4, 0.3, 4.9) ' vạch ngang đầu
        DLine(gpp, 0.3, 0.4, 9.8, 0.4) ' vạch thẳng đứng

        DLine(gpp, 9.8, 4.9, 9.8, 0.4) ' vạch ngang cuối 
        DLine(gpp, 9.8, 4.9, 0.3, 4.9) ' vạch thẳng cuối

        DLine(gpp, 0.3, 1.2, 9.8, 1.2) ' vạch ngang 2
        'DLine(gpp, 7.2, 1.6, 9.8, 1.6) ' vạch ngang 3

        DLine(gpp, 0.3, 2, 7.2, 2) ' vạch ngang 4
        'DLine(gpp, 7.2, 2.35, 9.8, 2.35) ' vạch ngang 5

        DLine(gpp, 0.3, 2.7, 7.2, 2.7) ' vạch ngang 6
        'DLine(gpp, 7.2, 3.05, 9.8, 3.05) ' vạch ngang 7

        DLine(gpp, 0.3, 3.4, 7.2, 3.4) ' vạch ngang 8
        'DLine(gpp, 7.2, 3.75, 9.8, 3.75) ' vạch ngang 9

        DLine(gpp, 0.3, 4.1, 9.8, 4.1) ' vạch ngang 10

        DLine(gpp, 7.2, 0.4, 7.2, 4.9) ' vạch thẳng 1
        'DLine(gpp, 8.5, 0.4, 8.5, 1.2) ' vạch thẳng 2

        DString(gpp, "Arial", False, False, False, 9, "C.Date", 0, 7.4, 0.45)
        DString(gpp, "Arial", False, False, False, 7, FSDate(MATERIAL.DateInBoundMaterial), 0, 7.2, 0.88)


        DString(gpp, "Arial", False, False, False, 9, "", 0, 8.6, 0.6)

        Dim rect01 As New RectangleF(1, 10, 300.0F, 30.0F)
        Dim rect02 As New RectangleF(1, 25, 300.0F, 30.0F)

        If READ_PFK7411(Pub.SAW) = True Then
            If D7411.cdSite = "" Then D7411.cdSite = "001"

            If READ_PFK7171(ListCode("Site"), D7411.cdSite) Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
            End If

        End If


        DString(gpp, "Arial", False, False, False, 9, "Nhãn hàng", 0, 0.3, 1.3)
        DString(gpp, "Arial", False, False, False, 9, "(Lable)", 0, 0.3, 1.6)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.MaterialCode, 0, 2.2, 1.2)

        If READ_PFK7233(MATERIAL.MaterialCode) = True Then
            Dim rect2 As New RectangleF(D7233.POSX * 400, D7233.POSY * 18, 280.0F, 120.0F)
            gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), rect2, stringFormat)
        Else
            DString(gpp, "Arial", True, False, False, 10, MATERIAL.MaterialName, 0, 2.2, 1.5)
        End If

        DString(gpp, "Arial", False, False, False, 9, "Màu sắc ", 0, 0.3, 2)
        DString(gpp, "Arial", False, False, False, 9, "(Color) ", 0, 0.3, 2.3)
        DString(gpp, "Arial", True, False, False, 9, MATERIAL.ColorName, 0, 2, 2)

        DString(gpp, "Arial", False, False, False, 9, "SO/WI# ", 0, 0.3, 2.7)
        DString(gpp, "Arial", False, False, False, 9, "(Item) ", 0, 0.3, 3)
        DString(gpp, "Arial", True, False, False, 9, MATERIAL.PRNo, 0, 2, 2.7)
        DString(gpp, "Arial", True, False, False, 9, MATERIAL.Article, 0, 2, 3)

        DString(gpp, "Arial", False, False, False, 9, "Số lượng ", 0, 0.3, 3.4)
        DString(gpp, "Arial", False, False, False, 9, "(Quantity) ", 0, 0.3, 3.7)
        DString(gpp, "Arial", True, False, False, 12, MATERIAL.QtyInBound, 0, 2.5, 3.4)
        DString(gpp, "Arial", True, False, False, 12, MATERIAL.cdUnitMaterialName.ToUpper & "/" & MATERIAL.cdUnitPackingName, 0, 5.5, 3.4)

        DString(gpp, "Arial", False, False, False, 7, FSDate(Pub.DAT), 0, 0.3, 4.2)
        DString(gpp, "Arial", False, False, False, 7, MATERIAL.CheckMaterialType & " [" & MATERIAL.Barcode & "]", 0, 0.3, 4.5)

        'If FormatCut(MATERIAL.Barcode).Length >= 15 Then
        '    Call Code128_Print("P", 3, 4.2, 0.025, 0.005, 0.6, 0, FormatCut(MATERIAL.Barcode), Nothing)
        'Else
        '    Call Code128_Print("P", 2.8, 4.2, 0.03, 0.003, 0.6, 0, FormatCut(MATERIAL.Barcode), Nothing)
        'End If
        Dim rect3 As New RectangleF(280, 160, 100.0F, 40.0F)
        gpp.DrawString(MATERIAL.SupplierName, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect3, stringFormat)

        Dim rect4 As New RectangleF(0.26 * 400, 6.67 * 18, 180.0F, 120.0F)
        gpp.DrawString(MATERIAL.Remark, New Font("Arial", 10, FontStyle.Bold), New SolidBrush(Color.Black), rect4, stringFormat)

        settings.Type = BarCodeType.QRCode
        settings.Unit = GraphicsUnit.Pixel
        settings.ShowText = False
        settings.ResolutionType = ResolutionType.UseDpi
        settings.Data = FormatCut(MATERIAL.Barcode)
        settings.X = 3.5
        settings.ForeColor = Color.Black
        settings.BackColor = Color.White
        settings.QRCodeECL = QRCodeECL.L
        settings.LeftMargin = 1
        settings.RightMargin = 1
        settings.BottomMargin = 1
        settings.TopMargin = 1

        settings.ResolutionType = ResolutionType.UseDpi
        Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)

        Dim QRbarcode As Image = generator.GenerateImage


        gpp.DrawImage(QRbarcode, CInt(7.7 * twtopi), CInt(2.2 * twtopi))

        'settings.X = 2
        'Dim generator1 As BarCodeGenerator = New BarCodeGenerator(settings)
        'Dim QRbarcode1 As Image = generator.GenerateImage

        'gpp.DrawImage(QRbarcode1, CInt(0.4 * twtopi), CInt(0.5 * twtopi))
        'gpp.DrawImage(QRbarcode1, CInt(8.6 * twtopi), CInt(0.5 * twtopi))

    End Sub

    Public Sub TAG_PRINT_MATERIAL_NEW_F1_LIST4()
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center


        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")
        Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType

        DLine(gpp, 0.3, 0.4, 0.3, 4.9) ' vạch ngang đầu
        DLine(gpp, 0.3, 0.4, 9.8, 0.4) ' vạch thẳng đứng

        DLine(gpp, 9.8, 4.9, 9.8, 0.4) ' vạch ngang cuối 
        DLine(gpp, 9.8, 4.9, 0.3, 4.9) ' vạch thẳng cuối

        DLine(gpp, 0.3, 1.2, 9.8, 1.2) ' vạch ngang 2
        'DLine(gpp, 7.2, 1.6, 9.8, 1.6) ' vạch ngang 3

        DLine(gpp, 0.3, 2, 7.2, 2) ' vạch ngang 4
        'DLine(gpp, 7.2, 2.35, 9.8, 2.35) ' vạch ngang 5

        DLine(gpp, 0.3, 2.7, 7.2, 2.7) ' vạch ngang 6
        'DLine(gpp, 7.2, 3.05, 9.8, 3.05) ' vạch ngang 7

        DLine(gpp, 0.3, 3.4, 7.2, 3.4) ' vạch ngang 8
        'DLine(gpp, 7.2, 3.75, 9.8, 3.75) ' vạch ngang 9

        DLine(gpp, 0.3, 4.1, 9.8, 4.1) ' vạch ngang 10

        DLine(gpp, 7.2, 0.4, 7.2, 4.9) ' vạch thẳng 1
        DLine(gpp, 8.5, 0.4, 8.5, 1.2) ' vạch thẳng 2

        DString(gpp, "Arial", False, False, False, 9, "Date", 0, 7.4, 0.45)
        DString(gpp, "Arial", False, False, False, 8, Pub.DAT, 0, 7.2, 0.88)
        DString(gpp, "Arial", False, False, False, 9, "BL Qty", 0, 8.6, 0.6)

        Dim rect01 As New RectangleF(1, 10, 300.0F, 30.0F)
        Dim rect02 As New RectangleF(1, 25, 300.0F, 30.0F)

        If READ_PFK7411(Pub.SAW) = True Then
            If D7411.cdSite = "" Then D7411.cdSite = "001"

            If READ_PFK7171(ListCode("Site"), D7411.cdSite) Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If
        Else
            If READ_PFK7171(ListCode("Site"), "001") Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If

        End If


        'DString(gpp, "Arial", False, False, False, 9, "Item 1", 0, 0.3, 1.2)

        If MATERIALLIST.Count > 0 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(0).Article & "[ " & Format2(MATERIALLIST(0).QtyInBound) & " ]", 0, 0.3, 1.2)

        'DString(gpp, "Arial", False, False, False, 9, "Item 2 ", 0, 0.3, 2)
        If MATERIALLIST.Count > 1 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(1).Article & "[ " & Format2(MATERIALLIST(1).QtyInBound) & " ]", 0, 0.3, 2)

        'DString(gpp, "Arial", False, False, False, 9, "Item 3 ", 0, 0.3, 2.7)
        If MATERIALLIST.Count > 2 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(2).Article & "[ " & Format2(MATERIALLIST(2).QtyInBound) & " ]", 0, 0.3, 2.7)

        'DString(gpp, "Arial", False, False, False, 9, "Item 4 ", 0, 0.3, 3.4)
        If MATERIALLIST.Count > 3 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(3).Article & "[ " & Format2(MATERIALLIST(2).QtyInBound) & " ]", 0, 0.3, 3.4)

        DString(gpp, "Arial", False, False, False, 7, FSDate(MATERIAL.DateInBoundMaterial), 0, 0.3, 4.2)
        DString(gpp, "Arial", False, False, False, 7, MATERIAL.CheckMaterialType & " [" & MATERIAL.Barcode & "]", 0, 0.3, 4.5)

        If FormatCut(MATERIAL.Barcode).Length >= 15 Then
            Call Code128_Print("P", 3, 4.2, 0.025, 0.005, 0.6, 0, FormatCut(MATERIAL.Barcode), Nothing)
        Else
            Call Code128_Print("P", 2.8, 4.2, 0.03, 0.003, 0.6, 0, FormatCut(MATERIAL.Barcode), Nothing)
        End If

        settings.Type = BarCodeType.QRCode
        settings.Unit = GraphicsUnit.Pixel
        settings.ShowText = False
        settings.ResolutionType = ResolutionType.UseDpi
        settings.Data = FormatCut(MATERIAL.Barcode)
        settings.X = 3
        settings.ForeColor = Color.Black
        settings.BackColor = Color.White
        settings.QRCodeECL = QRCodeECL.L
        settings.ResolutionType = ResolutionType.UseDpi
        Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)
        Dim QRbarcode As Image = generator.GenerateImage

        gpp.DrawImage(QRbarcode, CInt(7.7 * twtopi), CInt(2 * twtopi))
        'gpp.DrawImage(QRbarcode, CInt(1 * twtopi), CInt(0.5 * twtopi))

        Dim rect3 As New RectangleF(280, 160, 100.0F, 40.0F)
        gpp.DrawString(MATERIAL.ColorName, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect3, stringFormat)

    End Sub
    Public Sub TAG_PRINT_MATERIAL_NEW_F1_LIST8()
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center


        Dim settings As BarcodeSettings = New BarcodeSettings()
        BarcodeSettings.ApplyKey("0H8YP-M0FO1-9O9ZJ-441BF-WJ1NA")
        Dim barc As New FarPoint.Win.Spread.CellType.BarCodeCellType

        DLine(gpp, 0.3, 0.4, 0.3, 4.9) ' vạch ngang đầu
        DLine(gpp, 0.3, 0.4, 9.8, 0.4) ' vạch thẳng đứng

        DLine(gpp, 9.8, 4.9, 9.8, 0.4) ' vạch ngang cuối 
        DLine(gpp, 9.8, 4.9, 0.3, 4.9) ' vạch thẳng cuối

        DLine(gpp, 0.3, 1.2, 9.8, 1.2) ' vạch ngang 2
        'DLine(gpp, 7.2, 1.6, 9.8, 1.6) ' vạch ngang 3

        DLine(gpp, 0.3, 2, 7.2, 2) ' vạch ngang 4
        'DLine(gpp, 7.2, 2.35, 9.8, 2.35) ' vạch ngang 5

        DLine(gpp, 0.3, 2.7, 7.2, 2.7) ' vạch ngang 6
        'DLine(gpp, 7.2, 3.05, 9.8, 3.05) ' vạch ngang 7

        DLine(gpp, 0.3, 3.4, 7.2, 3.4) ' vạch ngang 8
        'DLine(gpp, 7.2, 3.75, 9.8, 3.75) ' vạch ngang 9

        DLine(gpp, 0.3, 4.1, 9.8, 4.1) ' vạch ngang 10

        DLine(gpp, 7.2, 0.4, 7.2, 4.9) ' vạch thẳng 1
        DLine(gpp, 8.5, 0.4, 8.5, 1.2) ' vạch thẳng 2

        DString(gpp, "Arial", False, False, False, 9, "Date", 0, 7.4, 0.45)
        DString(gpp, "Arial", False, False, False, 8, Pub.DAT, 0, 7.2, 0.88)
        DString(gpp, "Arial", False, False, False, 9, "BL Qty", 0, 8.6, 0.6)

        Dim rect01 As New RectangleF(1, 10, 300.0F, 30.0F)
        Dim rect02 As New RectangleF(1, 25, 300.0F, 30.0F)

        If READ_PFK7411(Pub.SAW) = True Then
            If D7411.cdSite = "" Then D7411.cdSite = "001"

            If READ_PFK7171(ListCode("Site"), D7411.cdSite) Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If
        Else
            If READ_PFK7171(ListCode("Site"), "001") Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If

        End If


        DString(gpp, "Arial", False, False, False, 9, "Nhãn Hàng", 0, 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 9, "(Lable)", 0, 0.3, 1.5)

        DString(gpp, "Arial", False, False, False, 9, MATERIAL.MaterialCode, 0, 2.2, 1.2)

        If READ_PFK7233(MATERIAL.MaterialCode) = True Then
            Dim rect2 As New RectangleF(D7233.POSX * 400, D7233.POSY * 18, 280.0F, 120.0F)
            gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), rect2, stringFormat)
        Else
            DString(gpp, "Arial", True, False, False, 10, MATERIAL.MaterialName, 0, 2.2, 1.5)
        End If
        If MATERIALLIST.Count > 4 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(4).Article & "[ " & Format2(MATERIALLIST(4).QtyInBound) & " ]", 0, 0.3, 1.2)

        'DString(gpp, "Arial", False, False, False, 9, "Item 2 ", 0, 0.3, 2)
        If MATERIALLIST.Count > 5 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(5).Article & "[ " & Format2(MATERIALLIST(5).QtyInBound) & " ]", 0, 0.3, 2)

        'DString(gpp, "Arial", False, False, False, 9, "Item 3 ", 0, 0.3, 2.7)
        If MATERIALLIST.Count > 6 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(6).Article & "[ " & Format2(MATERIALLIST(6).QtyInBound) & " ]", 0, 0.3, 2.7)

        'DString(gpp, "Arial", False, False, False, 9, "Item 4 ", 0, 0.3, 3.4)
        If MATERIALLIST.Count > 7 Then DString(gpp, "Arial", True, False, False, 9, MATERIALLIST(7).Article & "[ " & Format2(MATERIALLIST(7).QtyInBound) & " ]", 0, 0.3, 3.4)

        DString(gpp, "Arial", False, False, False, 7, FSDate(MATERIAL.DateInBoundMaterial), 0, 0.3, 4.2)
        DString(gpp, "Arial", False, False, False, 7, MATERIAL.CheckMaterialType & " [" & MATERIAL.Barcode & "]", 0, 0.3, 4.5)

        If FormatCut(MATERIAL.Barcode).Length >= 15 Then
            Call Code128_Print("P", 3, 4.2, 0.025, 0.005, 0.6, 0, FormatCut(MATERIAL.Barcode), Nothing)
        Else
            Call Code128_Print("P", 2.8, 4.2, 0.03, 0.003, 0.6, 0, FormatCut(MATERIAL.Barcode), Nothing)
        End If

        settings.Type = BarCodeType.QRCode
        settings.Unit = GraphicsUnit.Pixel
        settings.ShowText = False
        settings.ResolutionType = ResolutionType.UseDpi
        settings.Data = FormatCut(MATERIAL.Barcode)
        settings.X = 3
        settings.ForeColor = Color.Black
        settings.BackColor = Color.White
        settings.QRCodeECL = QRCodeECL.L
        settings.ResolutionType = ResolutionType.UseDpi
        Dim generator As BarCodeGenerator = New BarCodeGenerator(settings)
        Dim QRbarcode As Image = generator.GenerateImage

        gpp.DrawImage(QRbarcode, CInt(7.7 * twtopi), CInt(2 * twtopi))
        'gpp.DrawImage(QRbarcode, CInt(1 * twtopi), CInt(0.5 * twtopi))

        Dim rect3 As New RectangleF(280, 160, 100.0F, 40.0F)
        gpp.DrawString(MATERIAL.ColorName, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect3, stringFormat)

    End Sub
    Public Sub TAG_PRINT_MATERIAL_NEW_F2()
        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Center
        stringFormat.LineAlignment = StringAlignment.Center

        DLine(gpp, 0.3, 0.4, 0.3, 4.9) ' vạch ngang đầu
        DLine(gpp, 0.3, 0.4, 9.8, 0.4) ' vạch thẳng đứng

        DLine(gpp, 9.8, 4.9, 9.8, 0.4) ' vạch ngang cuối 
        DLine(gpp, 9.8, 4.9, 0.3, 4.9) ' vạch thẳng cuối

        DLine(gpp, 0.3, 1.2, 9.8, 1.2) ' vạch ngang 2
        'DLine(gpp, 7.2, 1.6, 9.8, 1.6) ' vạch ngang 3

        DLine(gpp, 0.3, 2, 9.8, 2) ' vạch ngang 4
        'DLine(gpp, 7.2, 2.35, 9.8, 2.35) ' vạch ngang 5

        DLine(gpp, 0.3, 2.7, 9.8, 2.7) ' vạch ngang 6
        'DLine(gpp, 7.2, 3.05, 9.8, 3.05) ' vạch ngang 7

        DLine(gpp, 0.3, 3.4, 9.8, 3.4) ' vạch ngang 8
        'DLine(gpp, 7.2, 3.75, 9.8, 3.75) ' vạch ngang 9

        DLine(gpp, 0.3, 4.1, 9.8, 4.1) ' vạch ngang 10

        DLine(gpp, 7.2, 0.4, 7.2, 4.9) ' vạch thẳng 1
        DLine(gpp, 8.5, 0.4, 8.5, 4.1) ' vạch thẳng 2

        DString(gpp, "Arial", False, False, False, 9, "Date", 0, 7.4, 0.6)
        DString(gpp, "Arial", False, False, False, 9, "BL Qty", 0, 8.6, 0.6)

        Dim rect01 As New RectangleF(1, 10, 300.0F, 30.0F)
        Dim rect02 As New RectangleF(1, 25, 300.0F, 30.0F)


        If READ_PFK7411(Pub.SAW) = True Then
            If D7411.cdSite = "" Then D7411.cdSite = "001"

            If READ_PFK7171(ListCode("Site"), D7411.cdSite) Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If
        Else
            If READ_PFK7171(ListCode("Site"), "001") Then
                gpp.DrawString(D7171.CheckName1, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
                gpp.DrawString(D7171.CheckName2, New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)
            End If

        End If

        'gpp.DrawString("CÔNG TY CỔ PHẦN SUNG HYUN VINA", New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect01, stringFormat)
        'gpp.DrawString("KCN Bình Đường, TX Dĩ An, Bình Dương", New Font("Arial", 9, FontStyle.Regular), New SolidBrush(Color.Black), rect02, stringFormat)

        DString(gpp, "Arial", False, False, False, 9, "Nhãn Hàng", 0, 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 9, "(Lable)", 0, 0.3, 1.5)

        If READ_PFK7233(MATERIAL.MaterialCode) = True Then
            Dim rect2 As New RectangleF(D7233.POSX * 400, D7233.POSY * 18, 280.0F, 120.0F)
            gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), rect2, stringFormat)
        Else
            DString(gpp, "Arial", True, False, False, 10, MATERIAL.MaterialName, 0, 2.2, 1.5)
        End If

        DString(gpp, "Arial", False, False, False, 9, "Màu sắc ", 0, 0.3, 2)
        DString(gpp, "Arial", False, False, False, 9, "(Color) ", 0, 0.3, 2.3)
        DString(gpp, "Arial", True, False, False, 15, MATERIAL.SupplierName, 0, 2, 2)

        DString(gpp, "Arial", False, False, False, 9, "PR# ", 0, 0.3, 2.7)
        DString(gpp, "Arial", False, False, False, 9, "(Số PR) ", 0, 0.3, 3)
        DString(gpp, "Arial", True, False, False, 15, MATERIAL.PRNo, 0, 2, 2.7)

        DString(gpp, "Arial", False, False, False, 9, "Số lượng ", 0, 0.3, 3.4)
        DString(gpp, "Arial", False, False, False, 9, "(Quantity) ", 0, 0.3, 3.7)
        DString(gpp, "Arial", True, False, False, 20, Format2(MATERIAL.QtyInBound), 0, 2.5, 3.4)
        'DString(gpp, "Arial", True, False, False, 15, MATERIAL.cdUnitMaterialName.ToUpper & "/" & MATERIAL.cdUnitPackingName, 0, 5, 3.5)
        DString(gpp, "Arial", True, False, False, 15, MATERIAL.cdUnitMaterialName.ToUpper, 0, 6, 3.5)

        DString(gpp, "Arial", False, False, False, 7, FSDate(MATERIAL.DateInBoundMaterial), 0, 0.3, 4.2)
        DString(gpp, "Arial", False, False, False, 7, MATERIAL.CheckMaterialType & " [" & MATERIAL.Barcode & "]", 0, 0.3, 4.5)

        Call Code128_Print("P", 2.8, 4.2, 0.03, 0.003, 0.6, 0, FormatCut(MATERIAL.Barcode), Nothing)

        Dim rect3 As New RectangleF(280, 160, 100.0F, 40.0F)
        gpp.DrawString(MATERIAL.ColorName, New Font("Arial", 9, FontStyle.Bold), New SolidBrush(Color.Black), rect3, stringFormat)

    End Sub
    Public Sub TAG_PRINT_CUTTING_PANEL()
        DString(gpp, "Arial", False, False, False, 9, CUTTINGPANEL1.ComponentName, 0, 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 9, CUTTINGPANEL1.SealNo, 0, 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 9, "SIZE: " & CUTTINGPANEL1.SizeName, 0, 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 9, FSDate(Pub.DAT), 0, 0.3, 1.6)

        DString(gpp, "Arial", False, False, False, 30, CUTTINGPANEL1.SizeQty, 0, 2.7, 0.8)

        Call Code128_Print("P", 0.3, 2.0, 0.03, 0.003, 0.6, 0, FormatCut(CUTTINGPANEL1.Barcode), Nothing)

        DString(gpp, "Arial", False, False, False, 9, CUTTINGPANEL1.CuttingBatch &
                "-" & CUTTINGPANEL1.CuttingBatchSeq &
                "-" & CUTTINGPANEL1.CuttingBatchSzno &
                "-" & CUTTINGPANEL1.CuttingBatchSno, 0, 0.6, 2.7)

        Dim XPlus As Decimal
        XPlus = 5

        DString(gpp, "Arial", False, False, False, 9, CUTTINGPANEL2.ComponentName, 0, XPlus + 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 9, CUTTINGPANEL2.SealNo, 0, XPlus + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 9, "SIZE: " & CUTTINGPANEL2.SizeName, 0, XPlus + 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 9, FSDate(Pub.DAT), 0, XPlus + 0.3, 1.6)

        DString(gpp, "Arial", False, False, False, 30, CUTTINGPANEL2.SizeQty, 0, XPlus + 2.7, 0.8)

        Call Code128_Print("P", XPlus + 0.3, 2.0, 0.03, 0.003, 0.6, 0, FormatCut(CUTTINGPANEL2.Barcode), Nothing)

        DString(gpp, "Arial", False, False, False, 9, CUTTINGPANEL2.CuttingBatch &
                "-" & CUTTINGPANEL2.CuttingBatchSeq &
                "-" & CUTTINGPANEL2.CuttingBatchSzno &
                "-" & CUTTINGPANEL2.CuttingBatchSno, 0, XPlus + 0.6, 2.7)

    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL1.SizeName, 0, 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3, 1.6)

        DString(gpp, "Arial", False, False, False, 20, "L", 0, 1.8, 0.8)

        Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, XPlus1 + 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, XPlus1 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL1.SizeName, 0, XPlus1 + 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, XPlus1 + 0.3, 1.6)

        DString(gpp, "Arial", False, False, False, 20, "R", 0, XPlus1 + 1.8, 0.8)

        Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)


        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus2 + 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus2 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL2.SizeName, 0, XPlus2 + 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus2 + 0.3, 1.6)

        DString(gpp, "Arial", False, False, False, 20, "L", 0, XPlus2 + 1.8, 0.8)

        Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)


        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus3 + 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus3 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL2.SizeName, 0, XPlus3 + 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus3 + 0.3, 1.6)

        DString(gpp, "Arial", False, False, False, 20, "R", 0, XPlus3 + 1.8, 0.8)

        Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL_NEW()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3, 0.4)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL1.SizeName, 0, 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3, 1.6)

        If STITCHINGPANEL1.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL1.QtyBatch & "L", 0, 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 20, "L", 0, 1.8, 0.8)

        Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus1 + 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus1 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL2.SizeName, 0, XPlus1 + 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus1 + 0.3, 1.6)

        If STITCHINGPANEL2.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL2.QtyBatch & "R", 0, XPlus1 + 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 20, "R", 0, XPlus1 + 1.8, 0.8)

        Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)


        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.SealNo, 0, XPlus2 + 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Article, 0, XPlus2 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL3.SizeName, 0, XPlus2 + 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Color, 0, XPlus2 + 0.3, 1.6)

        If STITCHINGPANEL3.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL3.QtyBatch & "L", 0, XPlus2 + 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 20, "L", 0, XPlus2 + 1.8, 0.8)

        Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL3.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)


        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.SealNo, 0, XPlus3 + 0.3, 0.4)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Article, 0, XPlus3 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, "SIZE: " & STITCHINGPANEL4.SizeName, 0, XPlus3 + 0.3, 1.2)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Color, 0, XPlus3 + 0.3, 1.6)

        If STITCHINGPANEL4.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL4.QtyBatch & "R", 0, XPlus3 + 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 20, "R", 0, XPlus3 + 1.8, 0.8)

        Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL4.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL_NEW_PROD()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        If STITCHINGPANEL1.SealNo <> "" Then
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3, 0.8)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3, 1.6)

            If STITCHINGPANEL1.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, False, 12, "SF", 0, 1.8, 0.3)

            ElseIf STITCHINGPANEL1.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.QtyBatch & STITCHINGPANEL1.Position, 0, 1.8, 0.4)

            Else
                If STITCHINGPANEL1.QtyBatch <> "1" Then
                    DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL1.QtyBatch & STITCHINGPANEL1.Position, 0, 1.8, 0.8)
                Else
                    DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Position, 0, 1.8, 0.4)
                End If
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL1.cdFactory & "-" & STITCHINGPANEL1.cdProdLine, 0, 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL1.SizeName, 0, 0.2, 1)

            If STITCHINGPANEL1.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.QtyBatch, 0, 1.8, 1)
            Else
                If Len(STITCHINGPANEL1.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.8, 1)
                If Len(STITCHINGPANEL1.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.4, 1)
                If Len(STITCHINGPANEL1.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1, 1)
            End If

            Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        End If

        If STITCHINGPANEL2.SealNo <> "" Then


            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus1 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus1 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus1 + 0.3, 1.6)

            If STITCHINGPANEL2.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, False, 12, "SF", 0, XPlus1 + 1.8, 0.3)

            ElseIf STITCHINGPANEL2.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.QtyBatch & STITCHINGPANEL2.Position, 0, XPlus1 + 1.8, 0.4)

            ElseIf STITCHINGPANEL2.QtyBatch <> "1" Then
                DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL2.QtyBatch & STITCHINGPANEL2.Position, 0, XPlus1 + 1.8, 0.8)
            Else
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Position, 0, XPlus1 + 1.8, 0.4)
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL2.cdFactory & "-" & STITCHINGPANEL2.cdProdLine, 0, XPlus1 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL2.SizeName, 0, XPlus1 + 0.2, 1)

            If STITCHINGPANEL2.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.QtyBatch, 0, XPlus1 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL2.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1.8, 1)
                If Len(STITCHINGPANEL2.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1.4, 1)
                If Len(STITCHINGPANEL2.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1, 1)
            End If

            Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)

        End If

        If STITCHINGPANEL3.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.SealNo, 0, XPlus2 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Article, 0, XPlus2 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Color, 0, XPlus2 + 0.3, 1.6)

            If STITCHINGPANEL3.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, False, 12, "SF", 0, XPlus2 + 1.8, 0.3)

            ElseIf STITCHINGPANEL3.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.QtyBatch & STITCHINGPANEL3.Position, 0, XPlus2 + 1.8, 0.4)

            ElseIf STITCHINGPANEL3.QtyBatch <> "1" Then
                DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL3.QtyBatch & STITCHINGPANEL3.Position, 0, XPlus2 + 1.8, 0.8)
            Else
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Position, 0, XPlus2 + 1.8, 0.4)
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL3.cdFactory & "-" & STITCHINGPANEL3.cdProdLine, 0, XPlus2 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL3.SizeName, 0, XPlus2 + 0.2, 1)

            If STITCHINGPANEL3.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.QtyBatch, 0, XPlus2 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL3.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1.8, 1)
                If Len(STITCHINGPANEL3.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1.4, 1)
                If Len(STITCHINGPANEL3.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1, 1)
            End If

            Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL3.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)
        End If

        If STITCHINGPANEL4.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.SealNo, 0, XPlus3 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Article, 0, XPlus3 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Color, 0, XPlus3 + 0.3, 1.6)

            If STITCHINGPANEL4.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, False, 12, "SF", 0, XPlus3 + 1.8, 0.3)

            ElseIf STITCHINGPANEL4.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.QtyBatch & STITCHINGPANEL4.Position, 0, XPlus3 + 1.8, 0.4)

            ElseIf STITCHINGPANEL4.QtyBatch <> "1" Then
                DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL4.QtyBatch & STITCHINGPANEL4.Position, 0, XPlus3 + 1.8, 0.8)
            Else
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Position, 0, XPlus3 + 1.8, 0.4)
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL4.cdFactory & "-" & STITCHINGPANEL4.cdProdLine, 0, XPlus3 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL4.SizeName, 0, XPlus3 + 0.2, 1)

            If STITCHINGPANEL4.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.QtyBatch, 0, XPlus3 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL4.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1.8, 1)
                If Len(STITCHINGPANEL4.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1.4, 1)
                If Len(STITCHINGPANEL4.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1, 1)
            End If


            Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL4.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

        End If
    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL_NEW_PROD_NEWCONCEPT()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        STITCHINGPANEL1.Position = ""
        STITCHINGPANEL2.Position = ""
        STITCHINGPANEL3.Position = ""
        STITCHINGPANEL4.Position = ""

        STITCHINGPANEL1.NumBer = STITCHINGPANEL1.QtyBatch
        STITCHINGPANEL2.NumBer = STITCHINGPANEL2.QtyBatch
        STITCHINGPANEL3.NumBer = STITCHINGPANEL3.QtyBatch
        STITCHINGPANEL4.NumBer = STITCHINGPANEL4.QtyBatch

        If STITCHINGPANEL1.SealNo <> "" Then
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3, 1.6)

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL1.cdFactory & "-" & STITCHINGPANEL1.cdProdLine, 0, 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL1.SizeName, 0, 0.2, 1)

            If STITCHINGPANEL1.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.QtyBatch, 0, 1.8, 1)
            Else
                If Len(STITCHINGPANEL1.NumBer) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.NumBer, 0, 1.8, 1)
                If Len(STITCHINGPANEL1.NumBer) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.NumBer, 0, 1.4, 1)
                If Len(STITCHINGPANEL1.NumBer) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.NumBer, 0, 1, 1)
            End If

            Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        End If

        If STITCHINGPANEL2.SealNo <> "" Then
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus1 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus1 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus1 + 0.3, 1.6)

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL2.cdFactory & "-" & STITCHINGPANEL2.cdProdLine, 0, XPlus1 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL2.SizeName, 0, XPlus1 + 0.2, 1)

            If STITCHINGPANEL2.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.QtyBatch, 0, XPlus1 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL2.NumBer) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.NumBer, 0, XPlus1 + 1.8, 1)
                If Len(STITCHINGPANEL2.NumBer) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.NumBer, 0, XPlus1 + 1.4, 1)
                If Len(STITCHINGPANEL2.NumBer) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.NumBer, 0, XPlus1 + 1, 1)
            End If

            Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)

        End If

        If STITCHINGPANEL3.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.SealNo, 0, XPlus2 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Article, 0, XPlus2 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Color, 0, XPlus2 + 0.3, 1.6)

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL3.cdFactory & "-" & STITCHINGPANEL3.cdProdLine, 0, XPlus2 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL3.SizeName, 0, XPlus2 + 0.2, 1)

            If STITCHINGPANEL3.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.QtyBatch, 0, XPlus2 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL3.NumBer) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.NumBer, 0, XPlus2 + 1.8, 1)
                If Len(STITCHINGPANEL3.NumBer) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.NumBer, 0, XPlus2 + 1.4, 1)
                If Len(STITCHINGPANEL3.NumBer) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.NumBer, 0, XPlus2 + 1, 1)
            End If

            Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL3.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)
        End If

        If STITCHINGPANEL4.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.SealNo, 0, XPlus3 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Article, 0, XPlus3 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Color, 0, XPlus3 + 0.3, 1.6)

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL4.cdFactory & "-" & STITCHINGPANEL4.cdProdLine, 0, XPlus3 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL4.SizeName, 0, XPlus3 + 0.2, 1)

            If STITCHINGPANEL4.cdMainProcess = "004" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.QtyBatch, 0, XPlus3 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL4.NumBer) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.NumBer, 0, XPlus3 + 1.8, 1)
                If Len(STITCHINGPANEL4.NumBer) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.NumBer, 0, XPlus3 + 1.4, 1)
                If Len(STITCHINGPANEL4.NumBer) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.NumBer, 0, XPlus3 + 1, 1)
            End If


            Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL4.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

        End If
    End Sub
    Public Sub TAG_PRINT_CUTTING_PANEL_NEW_PROD()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        Dim XPlusRec As Decimal

        Dim XRecPos As Decimal = 10
        Dim yRecPos As Decimal = 58

        Dim RecWidth As Single = 100.0F
        Dim RecHeight As Single = 40.0F
        Dim RecFont As Font = New Font("Courier New", 6, FontStyle.Bold)

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        XPlusRec = 100

        Dim stringFormat As New StringFormat()
        stringFormat.Alignment = StringAlignment.Near
        stringFormat.LineAlignment = StringAlignment.Near

        If CUTTINGPANEL1.SealNo <> "" Then
            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL1.SealNo, 0, 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL1.Article, 0, 0.3, 0.8)

            'DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL1.ComponentName, 0, 0.3, 1.6)

            Dim rect2 As New RectangleF(XRecPos, yRecPos, RecWidth, RecHeight)
            gpp.DrawString(CUTTINGPANEL1.ComponentName, RecFont, New SolidBrush(Color.Black), rect2, stringFormat)

            DString(gpp, "Arial", True, False, True, 12, CUTTINGPANEL1.QtyBatch, 0, 1.5, 1)

            DString(gpp, "Arial", True, False, False, 12, CUTTINGPANEL1.SizeName, 0, 0.2, 1)

            Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, Replace(CUTTINGPANEL1.Barcode, "C", ""), Nothing)

            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        End If

        If CUTTINGPANEL2.SealNo <> "" Then


            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL2.SealNo, 0, XPlus1 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL2.Article, 0, XPlus1 + 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL2.ComponentName, 0, XPlus1 + 0.3, 1.5)

            Dim rect2 As New RectangleF(XRecPos + XPlusRec * 1, yRecPos, RecWidth, RecHeight)
            gpp.DrawString(CUTTINGPANEL2.ComponentName, RecFont, New SolidBrush(Color.Black), rect2, stringFormat)

            DString(gpp, "Arial", True, False, False, 12, CUTTINGPANEL2.SizeName, 0, XPlus1 + 0.2, 1)

            DString(gpp, "Arial", True, False, True, 12, CUTTINGPANEL2.QtyBatch, 0, XPlus1 + 1.5, 1)

            Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, Replace(CUTTINGPANEL2.Barcode, "C", ""), Nothing)

            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL2.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)

        End If

        If CUTTINGPANEL3.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL3.SealNo, 0, XPlus2 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL3.Article, 0, XPlus2 + 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL3.ComponentName, 0, XPlus2 + 0.3, 1.5)

            Dim rect2 As New RectangleF(XRecPos + XPlusRec * 2, yRecPos, RecWidth, RecHeight)
            gpp.DrawString(CUTTINGPANEL3.ComponentName, RecFont, New SolidBrush(Color.Black), rect2, stringFormat)

            DString(gpp, "Arial", True, False, False, 12, CUTTINGPANEL3.SizeName, 0, XPlus2 + 0.2, 1)

            DString(gpp, "Arial", True, False, True, 12, CUTTINGPANEL3.QtyBatch, 0, XPlus2 + 1.5, 1)

            Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, Replace(CUTTINGPANEL3.Barcode, "C", ""), Nothing)

            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL3.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)
        End If

        If CUTTINGPANEL4.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL4.SealNo, 0, XPlus3 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL4.Article, 0, XPlus3 + 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL4.ComponentName, 0, XPlus3 + 0.3, 1.5)

            Dim rect2 As New RectangleF(XRecPos + XPlusRec * 3, yRecPos, RecWidth, RecHeight)
            gpp.DrawString(CUTTINGPANEL4.ComponentName, RecFont, New SolidBrush(Color.Black), rect2, stringFormat)

            DString(gpp, "Arial", True, False, False, 12, CUTTINGPANEL4.SizeName, 0, XPlus3 + 0.2, 1)

            DString(gpp, "Arial", True, False, True, 12, CUTTINGPANEL4.QtyBatch, 0, XPlus3 + 1.5, 1)

            Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, Replace(CUTTINGPANEL4.Barcode, "C", ""), Nothing)

            DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL4.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

        End If
    End Sub
    Public Sub TAG_PRINT_FOOTBED_PANEL_NEW_PROD()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        If STITCHINGPANEL1.SealNo <> "" Then
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3, 0.8)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3, 1.6)

            If STITCHINGPANEL1.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, False, 12, "FB", 0, 1.8, 0.3)

            ElseIf STITCHINGPANEL1.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.QtyBatch & "L", 0, 1.8, 0.4)

            Else
                If STITCHINGPANEL1.QtyBatch <> "1" Then
                    DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL1.QtyBatch & "L", 0, 1.8, 0.8)
                Else
                    DString(gpp, "Arial", False, False, False, 8, "L", 0, 1.8, 0.4)
                End If
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL1.cdFactory & "-" & STITCHINGPANEL1.cdProdLine, 0, 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL1.SizeName, 0, 0.2, 1)

            If STITCHINGPANEL1.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.QtyBatch, 0, 1.8, 1)
            Else
                If Len(STITCHINGPANEL1.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.8, 1)
                If Len(STITCHINGPANEL1.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.4, 1)
                If Len(STITCHINGPANEL1.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1, 1)
            End If

            Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        End If

        If STITCHINGPANEL2.SealNo <> "" Then


            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus1 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus1 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus1 + 0.3, 1.6)

            If STITCHINGPANEL2.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, False, 12, "FB", 0, XPlus1 + 1.8, 0.3)

            ElseIf STITCHINGPANEL2.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.QtyBatch & "R", 0, XPlus1 + 1.8, 0.4)

            ElseIf STITCHINGPANEL2.QtyBatch <> "1" Then
                DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL2.QtyBatch & "R", 0, XPlus1 + 1.8, 0.8)
            Else
                DString(gpp, "Arial", False, False, False, 8, "R", 0, XPlus1 + 1.8, 0.4)
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL2.cdFactory & "-" & STITCHINGPANEL2.cdProdLine, 0, XPlus1 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL2.SizeName, 0, XPlus1 + 0.2, 1)

            If STITCHINGPANEL2.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.QtyBatch, 0, XPlus1 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL2.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1.8, 1)
                If Len(STITCHINGPANEL2.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1.4, 1)
                If Len(STITCHINGPANEL2.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1, 1)
            End If

            Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)

        End If

        If STITCHINGPANEL3.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.SealNo, 0, XPlus2 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Article, 0, XPlus2 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Color, 0, XPlus2 + 0.3, 1.6)

            If STITCHINGPANEL3.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, False, 12, "FB", 0, XPlus2 + 1.8, 0.3)

            ElseIf STITCHINGPANEL3.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.QtyBatch & "L", 0, XPlus2 + 1.8, 0.4)

            ElseIf STITCHINGPANEL3.QtyBatch <> "1" Then
                DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL3.QtyBatch & "L", 0, XPlus2 + 1.8, 0.8)
            Else
                DString(gpp, "Arial", False, False, False, 8, "L", 0, XPlus2 + 1.8, 0.4)
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL3.cdFactory & "-" & STITCHINGPANEL3.cdProdLine, 0, XPlus2 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL3.SizeName, 0, XPlus2 + 0.2, 1)

            If STITCHINGPANEL3.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.QtyBatch, 0, XPlus2 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL3.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1.8, 1)
                If Len(STITCHINGPANEL3.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1.4, 1)
                If Len(STITCHINGPANEL3.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1, 1)
            End If

            Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL3.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)
        End If

        If STITCHINGPANEL4.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.SealNo, 0, XPlus3 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Article, 0, XPlus3 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Color, 0, XPlus3 + 0.3, 1.6)

            If STITCHINGPANEL4.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, False, 12, "FB", 0, XPlus3 + 1.8, 0.3)

            ElseIf STITCHINGPANEL4.cdFactory = "002" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.QtyBatch & "R", 0, XPlus3 + 1.8, 0.4)

            ElseIf STITCHINGPANEL4.QtyBatch <> "1" Then
                DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL4.QtyBatch & "R", 0, XPlus3 + 1.8, 0.8)
            Else
                DString(gpp, "Arial", False, False, False, 8, "R", 0, XPlus3 + 1.8, 0.4)
            End If

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL4.cdFactory & "-" & STITCHINGPANEL4.cdProdLine, 0, XPlus3 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL4.SizeName, 0, XPlus3 + 0.2, 1)

            If STITCHINGPANEL4.cdMainProcess = "099" Then
                DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.QtyBatch, 0, XPlus3 + 1.8, 1)
            Else
                If Len(STITCHINGPANEL4.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1.8, 1)
                If Len(STITCHINGPANEL4.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1.4, 1)
                If Len(STITCHINGPANEL4.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1, 1)
            End If


            Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL4.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

        End If
    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL_NEW_PROD_SB2()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        If STITCHINGPANEL1.SealNo <> "" Then
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3, 0.4)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3, 0.8)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3, 1.6)

            DString(gpp, "Arial", True, False, False, 12, "ST", 0, 1.6, 0.3)

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL1.cdFactory & "-" & STITCHINGPANEL1.cdProdLine, 0, 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL1.SizeName, 0, 0.2, 1)

            DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.QtyBatch, 0, 1.8, 1)


            Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        End If

        If STITCHINGPANEL2.SealNo <> "" Then


            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus1 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus1 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus1 + 0.3, 1.6)

            DString(gpp, "Arial", True, False, False, 12, "ST", 0, XPlus1 + 1.6, 0.3)


            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL2.cdFactory & "-" & STITCHINGPANEL2.cdProdLine, 0, XPlus1 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL2.SizeName, 0, XPlus1 + 0.2, 1)

            DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.QtyBatch, 0, XPlus1 + 1.8, 1)

            Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)

        End If

        If STITCHINGPANEL3.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.SealNo, 0, XPlus2 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Article, 0, XPlus2 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Color, 0, XPlus2 + 0.3, 1.6)

            DString(gpp, "Arial", True, False, False, 12, "ST", 0, XPlus2 + 1.6, 0.3)
            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL3.cdFactory & "-" & STITCHINGPANEL3.cdProdLine, 0, XPlus2 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL3.SizeName, 0, XPlus2 + 0.2, 1)

            DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.QtyBatch, 0, XPlus2 + 1.8, 1)

            Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL3.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)
        End If

        If STITCHINGPANEL4.SealNo <> "" Then

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.SealNo, 0, XPlus3 + 0.3, 0.4)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Article, 0, XPlus3 + 0.3, 0.8)
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Color, 0, XPlus3 + 0.3, 1.6)

            DString(gpp, "Arial", True, False, False, 12, "ST", 0, XPlus3 + 1.6, 0.3)

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL4.cdFactory & "-" & STITCHINGPANEL4.cdProdLine, 0, XPlus3 + 1.6, 0.8)
            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL4.SizeName, 0, XPlus3 + 0.2, 1)

            DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.QtyBatch, 0, XPlus3 + 1.8, 1)

            Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL4.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

        End If
    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL_NEW_PROD_A4(PosX As Integer, CntX As Integer, PosY As Integer, CntY As Integer)

        If STITCHINGPANEL1.SealNo <> "" Then
            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3 + PosX * CntX, 0.4 + PosY * CntY)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3 + PosX * CntX, 0.8 + PosY * CntY)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3 + PosX * CntX, 1.6 + PosY * CntY)

            DString(gpp, "Arial", False, False, False, 8, "L", 0, 1.8 + PosX * CntX, 0.4 + PosY * CntY)

            DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL1.cdFactory & "-" & STITCHINGPANEL1.cdProdLine, 0, 1.7 + PosX * CntX, 0.8 + PosY * CntY)

            DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL1.SizeName, 0, 0.2 + PosX * CntX, 1 + PosY * CntY)

            If Len(STITCHINGPANEL1.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.8 + PosX * CntX, 1 + PosY * CntY)
            If Len(STITCHINGPANEL1.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.4 + PosX * CntX, 1 + PosY * CntY)
            If Len(STITCHINGPANEL1.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1 + PosX * CntX, 1 + PosY * CntY)

            Call Code128_Print("P", 0.3 + PosX * CntX, 2.0 + PosY * CntY, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

            DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3 + PosX * CntX, 2.65 + PosY * CntY)

        End If

    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL_NEW_PROD_A4()
        Dim XPlus1 As Decimal
        Dim YPlus1 As Decimal

        XPlus1 = 2.5
        YPlus1 = 3.5

        Dim i As Integer
        Dim XA As Decimal
        Dim YA As Decimal


        For i = 0 To STITCHINGPANEL_LIST.Count - 1
            STITCHINGPANEL0 = STITCHINGPANEL_LIST(i)

            XA = (i Mod 8)
            YA = Math.Floor(i / 8)

            If STITCHINGPANEL0.SealNo <> "" Then
                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL0.SealNo, 0, 0.3 + XPlus1 * XA, 0.4 + YPlus1 * YA)

                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL0.Article, 0, 0.3 + XPlus1 * XA, 0.8 + YPlus1 * YA)

                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL0.Color, 0, 0.3 + XPlus1 * XA, 1.6 + YPlus1 * YA)

                If STITCHINGPANEL0.QtyBatch <> "1" Then
                    DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL0.QtyBatch & STITCHINGPANEL0.Position, 0, 1.8 + XPlus1 * XA, 0.8 + YPlus1 * YA)
                Else
                    DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL0.Position, 0, 1.8 + XPlus1 * XA, 0.4 + YPlus1 * YA)
                End If

                DString(gpp, "Arial", False, False, False, 8, "F" & STITCHINGPANEL0.cdFactory & "-" & STITCHINGPANEL0.cdProdLine, 0, 1.6 + XPlus1 * XA, 0.8 + YPlus1 * YA)
                DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL0.SizeName, 0, 0.2 + XPlus1 * XA, 1 + YPlus1 * YA)

                If Len(STITCHINGPANEL0.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL0.Sno, 0, 1.8 + XPlus1 * XA, 1 + YPlus1 * YA)
                If Len(STITCHINGPANEL0.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL0.Sno, 0, 1.4 + XPlus1 * XA, 1 + YPlus1 * YA)
                If Len(STITCHINGPANEL0.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL0.Sno, 0, 1 + XPlus1 * XA, 1 + YPlus1 * YA)

                Call Code128_Print("P", 0.3 + XPlus1 * XA, 2.0 + YPlus1 * YA, 0.02, 0.003, 0.6, 0, STITCHINGPANEL0.Barcode, Nothing)

                DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL0.BarcodeSeq, 0, 0.3 + XPlus1 * XA, 2.65 + YPlus1 * YA)

            End If

        Next

    End Sub
    Public Sub TAG_PRINT_CUTTING_PANEL_NEW_PROD_A4()
        Dim XPlus1 As Decimal
        Dim YPlus1 As Decimal

        XPlus1 = 2.5
        YPlus1 = 3.5

        Dim i As Integer
        Dim XA As Decimal
        Dim YA As Decimal


        For i = 0 To CUTTINGPANEL_LIST.Count - 1
            CUTTINGPANEL0 = CUTTINGPANEL_LIST(i)

            XA = (i Mod 8)
            YA = Math.Floor(i / 8)

            If CUTTINGPANEL0.SealNo <> "" Then
                DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL0.SealNo, 0, 0.3 + XPlus1 * XA, 0.4 + YPlus1 * YA)

                DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL0.Article, 0, 0.3 + XPlus1 * XA, 0.8 + YPlus1 * YA)

                DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL0.ComponentName, 0, 0.3 + XPlus1 * XA, 1.6 + YPlus1 * YA)

                If CUTTINGPANEL0.QtyBatch <> "1" Then
                    DString(gpp, "Arial", True, False, True, 10, CUTTINGPANEL0.QtyBatch & CUTTINGPANEL0.Position, 0, 1.8 + XPlus1 * XA, 0.8 + YPlus1 * YA)
                Else
                    DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL0.Position, 0, 1.8 + XPlus1 * XA, 0.4 + YPlus1 * YA)
                End If

                DString(gpp, "Arial", False, False, False, 8, "F" & CUTTINGPANEL0.cdFactory & "-" & CUTTINGPANEL0.cdProdLine, 0, 1.6 + XPlus1 * XA, 0.8 + YPlus1 * YA)
                DString(gpp, "Arial", False, False, False, 18, CUTTINGPANEL0.SizeName, 0, 0.2 + XPlus1 * XA, 1 + YPlus1 * YA)

                If Len(CUTTINGPANEL0.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, CUTTINGPANEL0.Sno, 0, 1.8 + XPlus1 * XA, 1 + YPlus1 * YA)
                If Len(CUTTINGPANEL0.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, CUTTINGPANEL0.Sno, 0, 1.4 + XPlus1 * XA, 1 + YPlus1 * YA)
                If Len(CUTTINGPANEL0.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, CUTTINGPANEL0.Sno, 0, 1 + XPlus1 * XA, 1 + YPlus1 * YA)

                Call Code128_Print("P", 0.3 + XPlus1 * XA, 2.0 + YPlus1 * YA, 0.02, 0.003, 0.6, 0, CUTTINGPANEL0.Barcode, Nothing)

                DString(gpp, "Arial", False, False, False, 8, CUTTINGPANEL0.BarcodeSeq, 0, 0.3 + XPlus1 * XA, 2.65 + YPlus1 * YA)

            End If

        Next

    End Sub
    Public Sub TAG_PRINT_STITCHING_PANEL_NEW_PROD_TEST()
        Dim XPlus1 As Decimal
        Dim XPlus2 As Decimal
        Dim XPlus3 As Decimal

        XPlus1 = 2.5
        XPlus2 = 5
        XPlus3 = 7.5

        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.SealNo, 0, 0.3, 0.4)
        Call Code128_Print("P", 0.3, 0.1, 0.02, 0.003, 0.3, 0, STITCHINGPANEL1.Barcode, Nothing)
        Call Code128_Print("P", 0.3, 0.3, 0.02, 0.003, 0.3, 0, STITCHINGPANEL1.Barcode, Nothing)

        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Article, 0, 0.3, 0.8)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.Color, 0, 0.3, 1.6)

        'If STITCHINGPANEL1.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL1.QtyBatch & "L", 0, 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 8, "L", 0, 1.8, 0.4)

        DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL1.SizeName, 0, 0.2, 1)

        If Len(STITCHINGPANEL1.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.8, 1)
        If Len(STITCHINGPANEL1.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1.4, 1)
        If Len(STITCHINGPANEL1.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL1.Sno, 0, 1, 1)

        Call Code128_Print("P", 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL1.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL1.BarcodeSeq, 0, 0.3, 2.65)

        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.SealNo, 0, XPlus1 + 0.3, 0.4)
        Call Code128_Print("P", XPlus1 + 0.3, 0.1, 0.02, 0.003, 0.3, 0, STITCHINGPANEL2.Barcode, Nothing)
        Call Code128_Print("P", XPlus1 + 0.3, 0.3, 0.02, 0.003, 0.3, 0, STITCHINGPANEL2.Barcode, Nothing)

        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Article, 0, XPlus1 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.Color, 0, XPlus1 + 0.3, 1.6)

        'If STITCHINGPANEL2.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL2.QtyBatch & "R", 0, XPlus1 + 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 8, "R", 0, XPlus1 + 1.8, 0.4)

        DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL2.SizeName, 0, XPlus1 + 0.2, 1)

        If Len(STITCHINGPANEL2.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1.8, 1)
        If Len(STITCHINGPANEL2.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1.4, 1)
        If Len(STITCHINGPANEL2.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL2.Sno, 0, XPlus1 + 1, 1)

        Call Code128_Print("P", XPlus1 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL2.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL2.BarcodeSeq, 0, XPlus1 + 0.3, 2.65)


        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.SealNo, 0, XPlus2 + 0.3, 0.4)
        Call Code128_Print("P", XPlus2 + 0.3, 0.1, 0.02, 0.003, 0.3, 0, STITCHINGPANEL3.Barcode, Nothing)
        Call Code128_Print("P", XPlus2 + 0.3, 0.3, 0.02, 0.003, 0.3, 0, STITCHINGPANEL3.Barcode, Nothing)

        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Article, 0, XPlus2 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.Color, 0, XPlus2 + 0.3, 1.6)

        'If STITCHINGPANEL3.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL3.QtyBatch & "L", 0, XPlus2 + 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 8, "L", 0, XPlus2 + 1.8, 0.4)

        DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL3.SizeName, 0, XPlus2 + 0.2, 1)

        If Len(STITCHINGPANEL3.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1.8, 1)
        If Len(STITCHINGPANEL3.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1.4, 1)
        If Len(STITCHINGPANEL3.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL3.Sno, 0, XPlus2 + 1, 1)

        Call Code128_Print("P", XPlus2 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL3.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL3.BarcodeSeq, 0, XPlus2 + 0.3, 2.65)


        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.SealNo, 0, XPlus3 + 0.3, 0.4)
        Call Code128_Print("P", XPlus3 + 0.3, 0.1, 0.02, 0.003, 0.3, 0, STITCHINGPANEL4.Barcode, Nothing)
        Call Code128_Print("P", XPlus3 + 0.3, 0.3, 0.02, 0.003, 0.3, 0, STITCHINGPANEL4.Barcode, Nothing)

        'DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Article, 0, XPlus3 + 0.3, 0.8)
        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.Color, 0, XPlus3 + 0.3, 1.6)

        'If STITCHINGPANEL4.QtyBatch <> "1" Then DString(gpp, "Arial", True, False, True, 10, STITCHINGPANEL4.QtyBatch & "R", 0, XPlus3 + 1.8, 0.8) Else DString(gpp, "Arial", False, False, False, 8, "R", 0, XPlus3 + 1.8, 0.4)

        DString(gpp, "Arial", False, False, False, 18, STITCHINGPANEL4.SizeName, 0, XPlus3 + 0.2, 1)

        If Len(STITCHINGPANEL4.Sno) = 1 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1.8, 1)
        If Len(STITCHINGPANEL4.Sno) = 2 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1.4, 1)
        If Len(STITCHINGPANEL4.Sno) = 3 Then DString(gpp, "Arial", True, False, True, 18, STITCHINGPANEL4.Sno, 0, XPlus3 + 1, 1)

        Call Code128_Print("P", XPlus3 + 0.3, 2.0, 0.02, 0.003, 0.6, 0, STITCHINGPANEL4.Barcode, Nothing)

        DString(gpp, "Arial", False, False, False, 8, STITCHINGPANEL4.BarcodeSeq, 0, XPlus3 + 0.3, 2.65)

    End Sub
    Public Sub TAG_PRINT_OS_PANEL()
        If OSPANEL1.SlNo <> "" Then
            DString(gpp, "Arial", False, False, False, 9, OSPANEL1.SlNo & "-" & OSPANEL1.MoldName, 0, 0.3, 0.4)

            DString(gpp, "Arial", True, False, False, 9, OSPANEL1.Machine, 0, 3.5, 1.1)

            DString(gpp, "Arial", False, False, False, 9, OSPANEL1.ColorName, 0, 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 9, "SIZE: " & OSPANEL1.SizeName, 0, 0.3, 1.2)
            'DString(gpp, "Arial", False, False, False, 9, FSDate(Pub.DAT), 0, 0.3, 1.6)

            DString(gpp, "Arial", False, False, False, 27, OSPANEL1.SizeName, 0, 0.3, 1.1)
            DString(gpp, "Arial", True, False, True, 27, OSPANEL1.QtySize, 0, 2.7, 1)

            Call Code128_Print("P", 0.6, 2.1, 0.03, 0.003, 0.6, 0, FormatCut(OSPANEL1.Barcode), Nothing)

            DString(gpp, "Arial", False, False, False, 9, OSPANEL1.Barcode, 0, 0.9, 2.7)

        End If

        Dim XPlus As Decimal
        XPlus = 5

        If OSPANEL2.SlNo <> "" Then
            DString(gpp, "Arial", False, False, False, 9, OSPANEL2.SlNo & "-" & OSPANEL2.MoldName, 0, XPlus + 0.3, 0.4)

            DString(gpp, "Arial", True, False, False, 9, OSPANEL2.Machine, 0, XPlus + 3.5, 1.1)

            DString(gpp, "Arial", False, False, False, 9, OSPANEL2.ColorName, 0, XPlus + 0.3, 0.8)
            'DString(gpp, "Arial", False, False, False, 9, "SIZE: " & OSPANEL2.SizeName, 0, XPlus + 0.3, 1.2)
            'DString(gpp, "Arial", False, False, False, 9, FSDate(Pub.DAT), 0, XPlus + 0.3, 1.6)

            DString(gpp, "Arial", False, False, False, 27, OSPANEL2.SizeName, 0, XPlus + 0.3, 1.1)
            DString(gpp, "Arial", True, False, True, 27, OSPANEL2.QtySize, 0, XPlus + 2.7, 1)

            Call Code128_Print("P", XPlus + 0.6, 2.1, 0.03, 0.003, 0.6, 0, FormatCut(OSPANEL2.Barcode), Nothing)

            DString(gpp, "Arial", False, False, False, 9, OSPANEL2.Barcode, 0, XPlus + 0.9, 2.7)
        End If

    End Sub
    Public Sub TAG_PRINT_MATERIAL_01_PREVIEW() 'iN THU 
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)

        DLine(gpp, 9.8, 0.3, 9.8, 7.5)

        ' -------- vach ngang --------'
        DLine(gpp, 0.3, 0.4, 9.8, 0.4)  '' thay doi 0.4 coi nhu chuan
        'DLine(gpp, 0.3, 1.2, 9.8, 1.2) '' 

        'DLine(gpp, 0.3, 3.6, 9.8, 3.6)
        'DLine(gpp, 0.3, 4.4, 9.8, 4.4)
        'DLine(gpp, 0.3, 5.2, 9.8, 5.2)

        'DLine(gpp, 0.3, 6.4, 9.8, 6.4)
        'DLine(gpp, 0.3, 7.5, 9.8, 7.5)
        '-----------------------------'

        DLine(gpp, 0.3, 7.8, 9.8, 7.8)
        DLine(gpp, 0.3, 9.3, 9.8, 9.3)
        DLine(gpp, 0.3, 10.1, 9.8, 10.1)

        '-----------vach giua--------'
        DLine(gpp, 0.3, 10.3, 0.3, 12.6)
        DLine(gpp, 0.3, 10.3, 9.8, 10.3)
        DLine(gpp, 9.8, 10.3, 9.8, 12.6)
        DLine(gpp, 0.3, 12.6, 9.8, 12.6)
        '----------------------------'
        DLine(gpp, 0.3, 7.8, 0.3, 10.1)

        DLine(gpp, 9.8, 7.8, 9.8, 10.1)

        DString(gpp, "Arial", True, False, False, FontPreview, MATERIAL.MaterialName, 0, 0.1, 0.3)

        DString(gpp, "Arial", True, False, False, 45, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 0.5, 2.8)

        DString(gpp, "Arial", True, False, False, 30, FSDate(MATERIAL.DateInBoundMaterial) & "  [" & MATERIAL.MaterialInBoundSno & "]", 0, 0.5, 4.7)


        Call Code128_Print("P", 2.5, 6.2, 0.04, 0.003, 0.8, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 3.6, 7)

        ' ------------------------------------------MAIN LABLE----------------------------------------------------

        If MATERIAL.MaterialName.Length > 8 Then
            DString(gpp, "Arial", True, False, False, 20, MATERIAL.MaterialName, 0, 0.3, 7.8)
        Else
            DString(gpp, "Arial", True, False, False, 30, MATERIAL.MaterialName, 0, 0.3, 7.8)
        End If


        DString(gpp, "Arial", True, False, False, 20, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 5.7, 7.8)

        DString(gpp, "Arial", True, False, False, 20, FSDate(MATERIAL.DateInBoundMaterial), 0, 5.7, 8.5)

        DString(gpp, "Arial", True, False, False, 8, "[OUTBOUND]", 0, 0.3, 9.5)

        Call Code128_Print("P", 2.5, 9.4, 0.025, 0.003, 0.5, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 9.3)

        '----------------------------------------------INBOUND LABLE------------------------------------------------

        If MATERIAL.MaterialName.Length > 8 Then
            DString(gpp, "Arial", True, False, False, 20, MATERIAL.MaterialName, 0, 0.3, 10.3)
        Else
            DString(gpp, "Arial", True, False, False, 30, MATERIAL.MaterialName, 0, 0.3, 10.3)
        End If



        DString(gpp, "Arial", True, False, False, 20, FormatNumber(MATERIAL.QtyInBoundMaterial, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 5.7, 10.3)

        DString(gpp, "Arial", True, False, False, 20, FSDate(MATERIAL.DateInBoundMaterial), 0, 5.7, 11)

        DString(gpp, "Arial", True, False, False, 8, "[INBOUND]", 0, 0.3, 12)

        Call Code128_Print("P", 2.5, 11.9, 0.025, 0.003, 0.5, 0, FormatCut(MATERIAL.Barcode), Nothing)
        'DString(gpp, "code39(2:3)", False, False, False, 16, "*" & MATERIAL.Barcode & "*", 0, 2.5, 11.6)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 12)

        '----------------------------------------------OUTBOUND LABLE------------------------------------------------
    End Sub
    Public Sub TAG_PRINT_FINAL_01() 'iN THU 
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)
        DLine(gpp, 0.3, 0.4, 0.3, 7.5)

        DLine(gpp, 9.8, 0.3, 9.8, 7.5)

        '-------- vach ngang --------'
        DLine(gpp, 0.3, 0.4, 9.8, 0.4)  'thay doi 0.4 coi nhu chuan
        DLine(gpp, 0.3, 1.2, 9.8, 1.2)

        'DLine(gpp, 0.3, 2.0, 9.8, 2.0)
        'DLine(gpp, 0.3, 2.8, 9.8, 2.8)
        DLine(gpp, 0.3, 3.6, 9.8, 3.6)
        DLine(gpp, 0.3, 4.4, 9.8, 4.4)
        DLine(gpp, 0.3, 5.2, 9.8, 5.2)

        DLine(gpp, 0.3, 6.4, 9.8, 6.4)
        DLine(gpp, 0.3, 7.5, 9.8, 7.5)

        '-----------------------------'
        DLine(gpp, 0.3, 7.8, 9.8, 7.8)
        DLine(gpp, 0.3, 9.3, 9.8, 9.3)
        DLine(gpp, 0.3, 10.1, 9.8, 10.1)
        '-----------vach giua--------'
        DLine(gpp, 0.3, 10.3, 0.3, 12.6)
        DLine(gpp, 0.3, 10.3, 9.8, 10.3)
        DLine(gpp, 9.8, 10.3, 9.8, 12.6)
        DLine(gpp, 0.3, 12.6, 9.8, 12.6)
        '----------------------------'
        DLine(gpp, 0.3, 7.8, 0.3, 10.1)

        DLine(gpp, 9.8, 7.8, 9.8, 10.1)


        DString(gpp, "Arial", True, False, False, 12, "SHIN KWANG VINA CO ., LTD ", 0, 2.1, 0.3)
        DString(gpp, "Arial", True, False, False, 9, "LOT 9A CN, MY PHUOC INDUSTRIAL PARK, BINH DUONG, VN ", 0, 0.3, 0.8)

        DString(gpp, "Arial", True, False, False, 32, MATERIAL.MaterialName, 0, 1, 0.9)
        DString(gpp, "Arial", False, False, False, 20, "", 0, 3, 1.9)


        DString(gpp, "Arial", False, False, False, 9, "T. Lượng", 0, 0.3, 2.8)
        DString(gpp, "Arial", False, False, False, 9, "(Weight)", 0, 0.3, 3.1)
        DString(gpp, "Arial", True, False, False, 20, MATERIAL.QtyGrossProduction & " " & MATERIAL.cdUnitMaterialName, 0, 2.5, 2.6)

        DString(gpp, "Arial", False, False, False, 9, "C. Từ", 0, 0.3, 3.6)
        DString(gpp, "Arial", False, False, False, 9, "(LCNO)", 0, 0.3, 3.9)
        DString(gpp, "Arial", True, False, False, 18, MATERIAL.LCNO, 0, 2.5, 3.5)


        DString(gpp, "Arial", False, False, False, 9, "Số thứ tự", 0, 6.3, 3.6)
        DString(gpp, "Arial", False, False, False, 9, "(Seq No)", 0, 6.3, 3.9)
        DString(gpp, "Arial", True, False, False, 18, MATERIAL.LotNoSeq, 0, 8, 3.5)


        DString(gpp, "Arial", False, False, False, 9, "Khách hàng", 0, 0.3, 4.4)
        DString(gpp, "Arial", False, False, False, 9, "(Customer)", 0, 0.3, 4.7)
        DString(gpp, "Arial", True, False, False, 9, MATERIAL.CustomerName, 0, 2.5, 4.5)

        DString(gpp, "Arial", False, False, False, 9, "NSX", 0, 6.3, 4.4)
        DString(gpp, "Arial", False, False, False, 9, "(Date)", 0, 6.3, 4.7)
        DString(gpp, "Arial", True, False, False, 9, FSDate(MATERIAL.DateAccept), 0, 7.5, 4.5)


        DString(gpp, "code39(2:3)", False, False, False, 20, "*" & MATERIAL.Barcode & "*", 0, 2.5, 5.3)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 3.6, 6)

        DString(gpp, "Arial", False, False, False, 9, "- Không để cho hóa chất vào mắt, da và quần áo.", 0, 1.5, 6.4)
        DString(gpp, "Arial", False, False, False, 9, "- Rửa thật sạch khi hóa chất tiếp xúc vào da.", 0, 1.5, 6.7)
        DString(gpp, "Arial", False, False, False, 9, "- Không được ăn hoặc hít vào", 0, 1.5, 7)

        ' ------------------------------------------MAIN LABLE----------------------------------------------------

        DString(gpp, "Arial", False, False, False, 8, "Mặt hàng", 0, 0.3, 7.8)
        DString(gpp, "Arial", True, False, False, 8, MATERIAL.MaterialName, 0, 2, 7.8)

        DString(gpp, "Arial", False, False, False, 8, "C. Từ", 0, 0.3, 8.3)
        DString(gpp, "Arial", True, False, False, 8, MATERIAL.LCNO, 0, 2, 8.3)

        DString(gpp, "Arial", False, False, False, 8, "Trọng lượng", 0, 6.5, 8.3)
        DString(gpp, "Arial", True, False, False, 8, MATERIAL.QtyGrossProduction & " " & MATERIAL.cdUnitMaterialName, 0, 8.2, 8.3)

        DString(gpp, "Arial", False, False, False, 8, "Khách hàng", 0, 0.3, 8.8)
        DString(gpp, "Arial", False, False, False, 8, MATERIAL.CustomerName, 0, 2, 8.8)

        DString(gpp, "Arial", False, False, False, 8, "Ngày", 0, 6.5, 8.8)
        DString(gpp, "Arial", False, False, False, 8, FSDate(MATERIAL.DateAccept), 0, 8, 8.8)

        DString(gpp, "Arial", True, False, False, 8, "[OUTBOUND]", 0, 0.3, 9.5)

        DString(gpp, "code39(2:3)", False, False, False, 16, "*" & MATERIAL.Barcode & "*", 0, 2.5, 9.4)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 9.5)

        '----------------------------------------------INBOUND LABLE------------------------------------------------

        DString(gpp, "Arial", False, False, False, 8, "Mặt hàng", 0, 0.3, 10.35)
        DString(gpp, "Arial", True, False, False, 8, MATERIAL.MaterialName, 0, 1.9, 10.35)

        DString(gpp, "Arial", False, False, False, 8, "C. Từ", 0, 0.3, 10.7)
        DString(gpp, "Arial", True, False, False, 8, MATERIAL.LCNO, 0, 2, 10.7)

        DString(gpp, "Arial", False, False, False, 8, "Trọng lượng", 0, 6.5, 10.7)
        DString(gpp, "Arial", True, False, False, 8, MATERIAL.QtyGrossProduction & " " & MATERIAL.cdUnitMaterialName, 0, 8.2, 10.7)

        DString(gpp, "Arial", False, False, False, 8, "Khách hàng", 0, 0.3, 11.1)
        DString(gpp, "Arial", False, False, False, 8, MATERIAL.CustomerName, 0, 2, 11.1)

        DString(gpp, "Arial", False, False, False, 8, "Ngày", 0, 6.5, 11.1)
        DString(gpp, "Arial", False, False, False, 8, FSDate(MATERIAL.DateAccept), 0, 8, 11.1)

        DString(gpp, "Arial", True, False, False, 8, "[INBOUND]", 0, 0.3, 11.7)

        DString(gpp, "code39(2:3)", False, False, False, 16, "*" & MATERIAL.Barcode & "*", 0, 2.5, 11.6)
        DString(gpp, "Arial", False, False, False, 9, MATERIAL.Barcode, 0, 6.8, 11.7)

        '----------------------------------------------OUTBOUND LABLE------------------------------------------------
    End Sub
    Public Sub TAG_PRINT_FINAL_OLD_BACKUP() 'iN THU 
        DString(gpp, "Arial Narrow", True, False, False, 65, MATERIAL.MaterialName, 0, 0.7, 0.5)
        DString(gpp, "Arial Narrow", False, False, False, 30, "LOT NO: " & MATERIAL.LotNO, 0, 1, 3.5)

        DString(gpp, "Arial Narrow", True, False, False, 25, "Net:" & FormatNumber(MATERIAL.QtyNetProduction, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 1.3, 5)
        DString(gpp, "Arial Narrow", True, False, False, 25, "Gross:" & FormatNumber(MATERIAL.QtyGrossProduction, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 7, 5)

        DString(gpp, "Arial Narrow", True, False, False, 12, "Ngày sản xuất: " & FSDateVN(MATERIAL.DateAccept), 0, 1.3, 6.3)

        If MATERIAL.CustomerCode = "000009" Then ' JUNG WOO No Expire date!
            DString(gpp, "Arial Narrow", True, False, False, 12, "Ngày giao hàng:", 0, 7, 6.3)
        Else
            DString(gpp, "Arial Narrow", True, False, False, 12, "Hạn sử dụng:" & FSDateVN(FormatCut(Function_Date_Add(CDate(FSDate(MATERIAL.DateAccept)), 3))), 0, 7, 6.3)
        End If

        DString(gpp, "Arial", False, False, False, 12, "- Không để cho hóa chất vào mắt, da và quần áo.", 0, 1.5, 7)
        DString(gpp, "Arial", False, False, False, 12, "- Rửa thật sạch khi hóa chất tiếp xúc vào da.", 0, 1.5, 7.5)
        DString(gpp, "Arial", False, False, False, 12, "- Không được ăn hoặc hít vào", 0, 1.5, 8)

        DString(gpp, "Arial Narrow", True, False, False, 22, "SHIN KWANG VINA CO ., LTD ", 0, 2.5, 8.5)
        DString(gpp, "Arial Narrow", False, False, False, 12, "TEL: (0650) 356 7778 FAX: (0650) 356 7778 ", 0, 3, 9.3)

        Call Code128_Print("P", 1, 9.8, 0.05, 0.003, 1, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 20, MATERIAL.Barcode, 0, 7, 9.8)

    End Sub
    Public Sub TAG_PRINT_FINAL_OLD() 'iN THU 


        If READ_PFK7233(MATERIAL.MaterialCode) = True Then
            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Center
            stringFormat.LineAlignment = StringAlignment.Center

            Dim rect2 As New RectangleF(D7233.POSX * 10, D7233.POSY * 50, 520.0F, 120.0F)
            gpp.DrawString(MATERIAL.MaterialName, New Font(D7233.FontName, CSng(D7233.FontSize), FontStyle.Bold), New SolidBrush(Color.Black), rect2, stringFormat)
        Else
            DString(gpp, "Arial Narrow", True, False, False, 65, MATERIAL.MaterialName, 0, 0.7, 0.5)
        End If

        If READ_PFK7231(MATERIAL.MaterialCode) Then
            If Trim(D7231.MaterialForeign1) <> "" Then
                Dim stringFormat As New StringFormat()
                stringFormat.Alignment = StringAlignment.Center
                stringFormat.LineAlignment = StringAlignment.Center

                Dim rect2 As New RectangleF(D7233.POSX * 10, D7233.POSY * 200, 520.0F, 120.0F)
                gpp.DrawString(D7231.MaterialForeign1, New Font("Arial Narrow", 25, FontStyle.Regular), New SolidBrush(Color.Black), rect2, stringFormat)
            End If
        End If

        DString(gpp, "Arial Narrow", False, False, False, 30, "LOT NO: " & MATERIAL.LotNO, 0, 1, 3.5)

        DString(gpp, "Arial Narrow", True, False, False, 25, "Net:" & FormatNumber(MATERIAL.QtyNetProduction, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 1.3, 5)
        DString(gpp, "Arial Narrow", True, False, False, 25, "Gross:" & FormatNumber(MATERIAL.QtyGrossProduction, 0) & " " & MATERIAL.cdUnitMaterialName.ToUpper, 0, 7, 5)

        DString(gpp, "Arial Narrow", True, False, False, 12, "Ngày sản xuất: " & FSDateVN(MATERIAL.DateAccept), 0, 1.3, 6.3)

        If MATERIAL.CustomerCode = "000009" Then ' JUNG WOO No Expire date!
            DString(gpp, "Arial Narrow", True, False, False, 12, "Ngày giao hàng:", 0, 7, 6.3)
        Else
            DString(gpp, "Arial Narrow", True, False, False, 12, "Hạn sử dụng:" & FSDateVN(FormatCut(Function_Date_Add(CDate(FSDate(MATERIAL.DateAccept)), 3))), 0, 7, 6.3)
        End If

        DString(gpp, "Arial", False, False, False, 12, "- Không để cho hóa chất vào mắt, da và quần áo.", 0, 1.5, 7)
        DString(gpp, "Arial", False, False, False, 12, "- Rửa thật sạch khi hóa chất tiếp xúc vào da.", 0, 1.5, 7.5)
        DString(gpp, "Arial", False, False, False, 12, "- Không được ăn hoặc hít vào", 0, 1.5, 8)

        DString(gpp, "Arial Narrow", True, False, False, 22, "SHIN KWANG VINA CO ., LTD ", 0, 2.5, 8.5)
        DString(gpp, "Arial Narrow", False, False, False, 12, "TEL: (0650) 356 7778 FAX: (0650) 356 7778 ", 0, 3, 9.3)

        Call Code128_Print("P", 1, 9.8, 0.05, 0.003, 1, 0, FormatCut(MATERIAL.Barcode), Nothing)
        DString(gpp, "Arial", False, False, False, 20, MATERIAL.Barcode, 0, 7, 9.8)

    End Sub
    Public Sub TAG_PRINT_BARCODE_QQ_VKL(mPageNumber As Integer, dsnew As DataSet)

        For Xrow As Integer = 0 To 5

            For Xcol As Integer = 0 To 2

                If GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "SLNo") <> "" Then


                    DLine(gpp, 0.2 + (7 * Xcol), 0.1 + (4.6 * Xrow), 0.2 + (7 * Xcol), 4.5 + (4.6 * Xrow)) ' vạch ngang đầu
                    DLine(gpp, 0.2 + (7 * Xcol), 0.1 + (4.6 * Xrow), 7.0 + (7 * Xcol), 0.1 + (4.6 * Xrow)) ' vạch thẳng đứng

                    DLine(gpp, 7.0 + (7 * Xcol), 4.5 + (4.6 * Xrow), 7.0 + (7 * Xcol), 0.1 + (4.6 * Xrow)) ' vạch thẳng cuối 
                    DLine(gpp, 7.0 + (7 * Xcol), 4.5 + (4.6 * Xrow), 0.2 + (7 * Xcol), 4.5 + (4.6 * Xrow)) ' vạch ngang cuối

                    DLine(gpp, 5.0 + (7 * Xcol), 3.8 + (4.6 * Xrow), 4.2 + (7 * Xcol), 3.8 + (4.6 * Xrow)) ' vạch ngang ngắn
                    DLine(gpp, 6.9 + (7 * Xcol), 3.8 + (4.6 * Xrow), 5.7 + (7 * Xcol), 3.8 + (4.6 * Xrow)) ' vạch ngang ngắn



                    DString(gpp, "Arial Narrow", True, False, False, 14, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "CustomerName"), 0, 0.35 + (7 * Xcol), 0.7 + (4.6 * Xrow))
                    Call Code128_Print("P", 3.5 + (7 * Xcol), 0.6 + (4.6 * Xrow), 0.035, 0.003, 0.6, 0, FormatCut(GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "KEY_Autokey")), Nothing)

                    DString(gpp, "Arial Narrow", True, False, False, 9, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "KEY_Autokey"), 0, 4.2 + (7 * Xcol), 1.3 + (4.6 * Xrow))

                    DString(gpp, "Arial Narrow", True, False, False, 8, "SEAL NO:", 0, 0.35 + (7 * Xcol), 1.9 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 11, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "SLNo"), 0, 1.7 + (7 * Xcol), 1.8 + (4.6 * Xrow))

                    DString(gpp, "Arial Narrow", True, False, False, 8, "PKO:", 0, 3.8 + (7 * Xcol), 1.9 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 11, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "PKONO"), 0, 4.7 + (7 * Xcol), 1.8 + (4.6 * Xrow))

                    DString(gpp, "Arial Narrow", True, False, False, 8, "ART NAME:", 0, 0.35 + (7 * Xcol), 2.4 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 11, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "Article"), 0, 1.7 + (7 * Xcol), 2.3 + (4.6 * Xrow))

                    DString(gpp, "Arial Narrow", True, False, False, 8, "LINE:", 0, 0.35 + (7 * Xcol), 2.9 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 11, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "Line"), 0, 1.7 + (7 * Xcol), 2.8 + (4.6 * Xrow))

                    DString(gpp, "Arial Narrow", True, False, False, 8, "M. CODE:", 0, 0.35 + (7 * Xcol), 3.4 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 11, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "MCODE"), 0, 1.7 + (7 * Xcol), 3.3 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 9, "QTY", 0, 4.3 + (7 * Xcol), 3.3 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 9, "CTNS NO", 0, 5.6 + (7 * Xcol), 3.3 + (4.6 * Xrow))

                    DString(gpp, "Arial Narrow", True, False, False, 8, "C. CODE:", 0, 0.35 + (7 * Xcol), 3.9 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 11, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "ColorCode"), 0, 1.7 + (7 * Xcol), 3.8 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 9, "13", 0, 4.4 + (7 * Xcol), 3.9 + (4.6 * Xrow))
                    DString(gpp, "Arial Narrow", True, False, False, 9, GetDsData(dsnew, ((mPageNumber - 1) * 18) + (Xrow * 3) + (Xcol), "CartonType"), 0, 5.8 + (7 * Xcol), 3.9 + (4.6 * Xrow))

                End If

            Next

        Next

    End Sub
#End Region

End Module
