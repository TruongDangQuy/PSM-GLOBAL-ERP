Module M_COMBO

#Region "Methods"

    Public Sub COMBO_NATION(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("ENGLISH")
        ctlCombo.Items.Add("KOREAN")
        ctlCombo.Items.Add("CHINA")
        ctlCombo.Items.Add("VIETNAM")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_POS(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("INSIDE")
        ctlCombo.Items.Add("OUTSIDE")
        ctlCombo.Items.Add("EDUCATION")
        ctlCombo.Items.Add("DEVELOPMENT")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_SET(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("SQL SERVER")
        ctlCombo.Items.Add("ORACLE SERVER")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_CCKNO(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("UPSON")
        ctlCombo.Items.Add("DAELIM")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_DATE_YY(tmpCombo As ComboBox)
        Dim i As Integer

        For i = 2000 To 2040
            tmpCombo.Items.Add(i)
        Next i
    End Sub

    Public Sub COMBO_DATE_MM(tmpCombo As ComboBox)

        tmpCombo.Items.Clear()

        tmpCombo.Items.Add("01")
        tmpCombo.Items.Add("02")
        tmpCombo.Items.Add("03")
        tmpCombo.Items.Add("04")
        tmpCombo.Items.Add("05")
        tmpCombo.Items.Add("06")
        tmpCombo.Items.Add("07")
        tmpCombo.Items.Add("08")
        tmpCombo.Items.Add("09")
        tmpCombo.Items.Add("10")
        tmpCombo.Items.Add("11")
        tmpCombo.Items.Add("12")

    End Sub

    Public Sub COMBO_DATE_DD(tmpCombo As ComboBox)
        Dim i As Integer

        tmpCombo.Items.Add("01")
        tmpCombo.Items.Add("02")
        tmpCombo.Items.Add("03")
        tmpCombo.Items.Add("04")
        tmpCombo.Items.Add("05")
        tmpCombo.Items.Add("06")
        tmpCombo.Items.Add("07")
        tmpCombo.Items.Add("08")
        tmpCombo.Items.Add("09")

        For i = 10 To 31
            tmpCombo.Items.Add(i)
        Next i

    End Sub

    Public Sub ComboSetting_MONTH(ctlCombo As ComboBox, Optional tmpMM As Integer = Nothing)
        Dim i As Integer
        Dim j As Integer
        'sau
        'If IsMissing(tmpMM) = False Then
        '    j = 12
        'Else
        '    j = tmpMM
        'End If

        ctlCombo.Items.Clear()

        For i = 1 To j
            ctlCombo.Items.Add(i)
        Next i

        ctlCombo.SelectedIndex = 1
        If j = 12 Then ctlCombo.Text = Mid(Pub.DAT, 5, 2)

    End Sub

    Public Sub COMBO_IPGU(ctlCombo As ComboBox, Optional CHK As Boolean = Nothing)
        ctlCombo.Items.Clear()

        If CHK = True Then ctlCombo.Items.Add("<< ALL >>")

        ctlCombo.Items.Add("DEFINITIVE")
        ctlCombo.Items.Add("RESERVE")

        If CHK = True Then
            ctlCombo.SelectedIndex = 0
        Else
            ctlCombo.SelectedIndex = 0
        End If
    End Sub

    'Public Sub COMBO_YCHK(ctlCombo As ComboBox, Optional CHK As Boolean = Nothing)
    '    ctlCombo.Items.Clear()

    '    If CHK = True Then ctlCombo.Items.Add("<< ALL >>")

    '    ctlCombo.Items.Add("R/W")
    '    ctlCombo.Items.Add("Y/D")
    '    ctlCombo.Items.Add("MG")

    '    If CHK = True Then
    '        ctlCombo.SelectedIndex = 0
    '    Else
    '        ctlCombo.SelectedIndex = 1
    '    End If
    'End Sub

    Public Sub COMBO_ORGU(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Sample")
        ctlCombo.Items.Add("Normal")
        ctlCombo.Items.Add("Repeat")
        ctlCombo.Items.Add("Compensation")
        ctlCombo.Items.Add("Stock")
        ctlCombo.SelectedIndex = 1
    End Sub

    Public Sub COMBO_JBGU(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Finished")
        ctlCombo.Items.Add("Knitting")
        ctlCombo.Items.Add("Dyeing")
        ctlCombo.Items.Add("Sewing")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_WJGU(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("KNITT")
        ctlCombo.Items.Add("WOVEN")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_BSEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("NORMAL")
        ctlCombo.Items.Add("SAMPLE")
        ctlCombo.Items.Add("RE_PROD")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_STCD(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Grey Fabric")
        ctlCombo.Items.Add("Color Fabric")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_UNIT(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Yds")
        ctlCombo.Items.Add("Mts")
        ctlCombo.Items.Add("Yds")
        ctlCombo.Items.Add("Pcs")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_CUNIT(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("VND")
        ctlCombo.Items.Add("$")
        ctlCombo.SelectedIndex = 1
    End Sub

    Public Sub COMBO_PSEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("FOB")
        ctlCombo.Items.Add("CIF")
        ctlCombo.Items.Add("CNF")
        ctlCombo.Items.Add("CPT")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_SJGU(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Domestic")
        ctlCombo.Items.Add("export")
        ctlCombo.SelectedIndex = 1
    End Sub

    Public Sub COMBO_ASEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("FREE OF CHARGE, FREIGHT PREPAID")
        ctlCombo.Items.Add("FREE OF CHARGE,FREIGHT TO COLLECT")
        ctlCombo.Items.Add("PAID,FREIGHT PREPAID")
        ctlCombo.Items.Add("PAID,FREIGHT TO COLLECT")
        ctlCombo.Items.Add("Additional payment for work")

        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_NSEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Kg")
        ctlCombo.Items.Add("Mt")
        ctlCombo.Items.Add("Kg(Loss)")
        ctlCombo.Items.Add("Mt(Loss)")
        ctlCombo.Items.Add("Pcs")

        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_CSEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Kg")
        ctlCombo.Items.Add("Mt")
        ctlCombo.Items.Add("Kg(Loss)")
        ctlCombo.Items.Add("Mt(Loss)")
        ctlCombo.Items.Add("Pcs")

        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_KSEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("DIRECT(L/C)")
        ctlCombo.Items.Add("LOCAL(L/C)")
        ctlCombo.Items.Add("T/T")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_TSEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("BEFOR APPROVAL")
        ctlCombo.Items.Add("AFTER APPROVAL")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_JJGU(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("YARN")
        ctlCombo.Items.Add("GREY FABRIC")
        ctlCombo.Items.Add("DYESTUFFS AND PRESCRIPTION")
        ctlCombo.Items.Add("OTHERS")
        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub ComboSetting_CHECK(ctlCombo As ComboBox, CHK As String)

        ctlCombo.Items.Clear()

        If CHK = "S" Then ctlCombo.Items.Add("<<PROCESSONG TYPE >>")

        ctlCombo.Items.Add("UNFINISHED")
        ctlCombo.Items.Add("FINISHED")
        ctlCombo.Items.Add("CANCEL")

        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub ComboSetting_ASEL(ctlCombo As ComboBox, CHK As String)
        ctlCombo.Items.Clear()

        If CHK = "S" Then ctlCombo.Items.Add("<<  MATERIAL TYPE >>")

        ctlCombo.Items.Add("SELF")
        ctlCombo.Items.Add("OUTSIDE")

        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub ComboSetting_NSEL(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("Kg")
        ctlCombo.Items.Add("MT")
        ctlCombo.Items.Add("PCS")

        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub ComboSetting_JBOM(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("STYLE+FABRIC(PRICE)")
        ctlCombo.Items.Add("STYLE+FABRIC")
        ctlCombo.Items.Add("FABRIC(PRICE)")
        ctlCombo.Items.Add("FABRIC")
        ctlCombo.SelectedIndex = -1
    End Sub

    Public Sub COMBO_TYPE(ctlCombo As ComboBox)
        ctlCombo.Items.Clear()

        ctlCombo.Items.Add("A")
        ctlCombo.Items.Add("B")
        ctlCombo.Items.Add("C")
        ctlCombo.Items.Add("D")
        ctlCombo.Items.Add("E")
        ctlCombo.Items.Add("F")
        ctlCombo.Items.Add("G")
        ctlCombo.Items.Add("H")
        ctlCombo.Items.Add("I")
        ctlCombo.Items.Add("J")
        ctlCombo.Items.Add("K")
        ctlCombo.Items.Add("L")
        ctlCombo.Items.Add("M")
        ctlCombo.Items.Add("N")
        ctlCombo.Items.Add("O")
        ctlCombo.Items.Add("P")
        ctlCombo.Items.Add("Q")
        ctlCombo.Items.Add("R")
        ctlCombo.Items.Add("S")
        ctlCombo.Items.Add("T")
        ctlCombo.Items.Add("U")
        ctlCombo.Items.Add("V")
        ctlCombo.Items.Add("W")
        ctlCombo.Items.Add("X")
        ctlCombo.Items.Add("Y")
        ctlCombo.Items.Add("Z")
    End Sub

    Public Sub ComboSetting_NUMBER(ctlCombo As ComboBox, tmpS1 As Integer, tmpS2 As Integer)

        Dim i As Integer
        For i = tmpS1 To tmpS2
            ctlCombo.Items.Add(Format(i, " 000"))
        Next i

        ctlCombo.SelectedIndex = 0
    End Sub

    Public Sub COMBO_YCHK(ctlCombo As SelectPeaceCombo, Optional CHK As Boolean = False)
        ctlCombo.PeaceCombobox1.Items.Clear()

        If CHK = True Then ctlCombo.PeaceCombobox1.Items.Add("<< ALL >>")

        ctlCombo.PeaceCombobox1.Items.Add("R/W")
        ctlCombo.PeaceCombobox1.Items.Add("Y/D")
        ctlCombo.PeaceCombobox1.Items.Add("MG")

        If CHK = True Then
            ctlCombo.PeaceCombobox1.SelectedIndex = 0
        Else
            ctlCombo.PeaceCombobox1.SelectedIndex = 0
        End If
        '  ctlCombo.PeaceCombobox1.Focus()
    End Sub
    Public Sub COMBO_ORDERGROUP(ctlCombo As ComboBox, Optional CHK As Boolean = False)
        ctlCombo.Items.Clear()

        If CHK = True Then ctlCombo.Items.Add("<< ALL >>")

        ctlCombo.Items.Add("FINISHED")
        ctlCombo.Items.Add("KNITTING-WEAVING")
        ctlCombo.Items.Add("DYEING")
        ctlCombo.Items.Add("SEWING")
        If CHK = True Then
            ctlCombo.SelectedIndex = 0
        Else
            ctlCombo.SelectedIndex = 0
        End If
    End Sub

#End Region

End Module
