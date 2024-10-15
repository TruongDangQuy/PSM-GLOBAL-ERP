Module M_CommonSelect
    Public Function FUNCTION_OS_PLAN(WCHK_PLAN As String) As Color

        Select Case WCHK_PLAN

            Case "1" : FUNCTION_OS_PLAN = SystemColors.Control
            Case "2" : FUNCTION_OS_PLAN = Color.Violet
            Case "3" : FUNCTION_OS_PLAN = Color.Orange
            Case "4" : FUNCTION_OS_PLAN = Color.Yellow
            Case "5" : FUNCTION_OS_PLAN = Color.Red
            Case "6" : FUNCTION_OS_PLAN = Color.Aqua
            Case Else : FUNCTION_OS_PLAN = Color.White
        End Select

    End Function

    Public Function FUNCTION_MATERIAL_CBD(WCHK_PLAN As String) As Color

        Select Case WCHK_PLAN

            'Case "1" : FUNCTION_MATERIAL_CBD = Color.LightBlue
            Case "2" : FUNCTION_MATERIAL_CBD = Color.LightGreen
            Case "3" : FUNCTION_MATERIAL_CBD = Color.LightYellow
            Case "4" : FUNCTION_MATERIAL_CBD = Color.LightPink
            Case "5" : FUNCTION_MATERIAL_CBD = Color.LightGray
            Case "6" : FUNCTION_MATERIAL_CBD = Color.LightCoral

        End Select

    End Function


    Public Function FUNCTION_BACKCOLOR_SHEET(WCHK_PLAN As String) As Color

        Select Case WCHK_PLAN

            Case "1" : FUNCTION_BACKCOLOR_SHEET = SystemColors.Control
            Case "2" : FUNCTION_BACKCOLOR_SHEET = Color.Violet
            Case "3" : FUNCTION_BACKCOLOR_SHEET = Color.Orange
            Case "4" : FUNCTION_BACKCOLOR_SHEET = Color.Yellow
            Case "5" : FUNCTION_BACKCOLOR_SHEET = Color.Red
            Case "6" : FUNCTION_BACKCOLOR_SHEET = Color.Aqua

            Case "7" : FUNCTION_BACKCOLOR_SHEET = Color.Green
            Case "8" : FUNCTION_BACKCOLOR_SHEET = Color.Lime
            Case "9" : FUNCTION_BACKCOLOR_SHEET = Color.Gold
            Case "10" : FUNCTION_BACKCOLOR_SHEET = Color.Olive
            Case "11" : FUNCTION_BACKCOLOR_SHEET = Color.Navy

            Case "A" : FUNCTION_BACKCOLOR_SHEET = Color.Aquamarine
            Case "B" : FUNCTION_BACKCOLOR_SHEET = Color.Black
            Case "C" : FUNCTION_BACKCOLOR_SHEET = Color.Coral
            Case "D" : FUNCTION_BACKCOLOR_SHEET = Color.DarkBlue
            Case "W" : FUNCTION_BACKCOLOR_SHEET = Color.White
            Case "I" : FUNCTION_BACKCOLOR_SHEET = SystemColors.Info

            Case Else : FUNCTION_BACKCOLOR_SHEET = Color.White



        End Select

    End Function

    Public Function FUNCTION_WEAVING_PLAN(WCHK_PLAN As String) As Color

        Select Case WCHK_PLAN

            Case "1" : FUNCTION_WEAVING_PLAN = SystemColors.Control
            Case "2" : FUNCTION_WEAVING_PLAN = Color.Violet
            Case "3" : FUNCTION_WEAVING_PLAN = Color.Orange
            Case "4" : FUNCTION_WEAVING_PLAN = Color.Yellow
            Case "5" : FUNCTION_WEAVING_PLAN = Color.Red
            Case "6" : FUNCTION_WEAVING_PLAN = Color.Aqua
            Case Else : FUNCTION_WEAVING_PLAN = Color.White
        End Select

    End Function
    Public Function FUNCTION_DYEING_PLAN_BACK(WCHK_PLAN As String) As Color

        Select Case WCHK_PLAN
            Case "1" : FUNCTION_DYEING_PLAN_BACK = Color.WhiteSmoke
            Case "2" : FUNCTION_DYEING_PLAN_BACK = Color.LightGreen
            Case "3" : FUNCTION_DYEING_PLAN_BACK = Color.Violet
            Case "4" : FUNCTION_DYEING_PLAN_BACK = Color.Red
            Case "5" : FUNCTION_DYEING_PLAN_BACK = Color.LightGreen
            Case "6" : FUNCTION_DYEING_PLAN_BACK = Color.LightGreen
            Case Else : FUNCTION_DYEING_PLAN_BACK = Color.WhiteSmoke
        End Select

    End Function

    Public Function FUNCTION_TRADING_BACK(WCHK_PLAN As String) As Color


        Try
            FUNCTION_TRADING_BACK = Color.Empty
            Dim stValue As String
            Dim Dtrrow As DataRow = DS3.Tables(0).Select("CheckStatus_TD = '" + WCHK_PLAN + "'")(0)
            stValue = Dtrrow.Item("NameSimply")

            FUNCTION_TRADING_BACK = System.Drawing.ColorTranslator.FromHtml(stValue)

        Catch ex As Exception

        End Try
       

    End Function

    Public Function FUNCTION_DYEING_PLAN_FORE(WCHK_PLAN As String) As Color

        Select Case WCHK_PLAN
            Case "1" : FUNCTION_DYEING_PLAN_FORE = Color.Black
            Case "2" : FUNCTION_DYEING_PLAN_FORE = Color.Red
            Case "3" : FUNCTION_DYEING_PLAN_FORE = Color.Black
            Case "4" : FUNCTION_DYEING_PLAN_FORE = Color.Black
            Case "5" : FUNCTION_DYEING_PLAN_FORE = Color.Black
            Case "6" : FUNCTION_DYEING_PLAN_FORE = Color.Blue
            Case Else : FUNCTION_DYEING_PLAN_FORE = Color.Black
        End Select

    End Function
    Public Function FUNCTION_CHK_YESNO(tmpYESNO As String)

        Select Case tmpYESNO
            Case "1" : FUNCTION_CHK_YESNO = "X"
            Case "2" : FUNCTION_CHK_YESNO = "O"
            Case Else : FUNCTION_CHK_YESNO = "X"
        End Select

    End Function
    Public Function FUNCTION_APPROVAL_ORDER(ORDER_WCHK As String) As String

        Select Case ORDER_WCHK
            Case "1" : FUNCTION_APPROVAL_ORDER = "PN"
            Case "2" : FUNCTION_APPROVAL_ORDER = "PF"
            Case "3" : FUNCTION_APPROVAL_ORDER = "PA"
            Case "4" : FUNCTION_APPROVAL_ORDER = "PC"
            Case Else : FUNCTION_APPROVAL_ORDER = "PX"
        End Select
    End Function

    Public Function FUNCTION_APPROVAL_KNITTING(KNIT_CHK As String) As String

        Select Case KNIT_CHK
            Case "1" : FUNCTION_APPROVAL_KNITTING = "KN"
            Case "2" : FUNCTION_APPROVAL_KNITTING = "KF"
            Case "3" : FUNCTION_APPROVAL_KNITTING = "KA"
            Case "4" : FUNCTION_APPROVAL_KNITTING = "KC"
            Case Else : FUNCTION_APPROVAL_KNITTING = "KX"
        End Select
    End Function
    Public Function FUNCTION_CBOOLEAN(VALUE As String) As String
        FUNCTION_CBOOLEAN = "False"
        Select Case VALUE
            Case "False" : FUNCTION_CBOOLEAN = "0"
            Case "True" : FUNCTION_CBOOLEAN = "1"
        End Select
    End Function

    Public Function FUNCTION_BOOLEAN(VALUE As String) As String
        FUNCTION_BOOLEAN = "False"
        Select Case VALUE
            Case "0" : FUNCTION_BOOLEAN = "False"
            Case "1" : FUNCTION_BOOLEAN = "True"
        End Select
    End Function


    Public Function FUNCTION_APPROVAL_DYEING(DYEING_CHK As String) As String

        Select Case DYEING_CHK
            Case "1" : FUNCTION_APPROVAL_DYEING = "DN"
            Case "2" : FUNCTION_APPROVAL_DYEING = "DF"
            Case "3" : FUNCTION_APPROVAL_DYEING = "DA"
            Case "4" : FUNCTION_APPROVAL_DYEING = "DC"
            Case Else : FUNCTION_APPROVAL_DYEING = "DX"
        End Select
    End Function

    Public Function FUNCTION_PLANNING_TITLE(Value As String) As String

        Select Case Value
            Case "1" : FUNCTION_PLANNING_TITLE = "Target/Day"
            Case "2" : FUNCTION_PLANNING_TITLE = "W/T Target"
            Case "3" : FUNCTION_PLANNING_TITLE = "Result/Day"
            Case "4" : FUNCTION_PLANNING_TITLE = "W/T"
            Case "5" : FUNCTION_PLANNING_TITLE = "O/T"
            Case "6" : FUNCTION_PLANNING_TITLE = "Workers"
            Case "7" : FUNCTION_PLANNING_TITLE = "PPH"
            Case "8" : FUNCTION_PLANNING_TITLE = "PPMH"
        End Select
    End Function

    Public Function CheckInboundProcessYarn(ProcessYarn As String) As String

        Select Case ProcessYarn
            Case "1" : CheckInboundProcessYarn = "Normal"
            Case "2" : CheckInboundProcessYarn = "Sample"
            Case "3" : CheckInboundProcessYarn = "Return"
            Case "4" : CheckInboundProcessYarn = "Again (Inside)"
            Case "5" : CheckInboundProcessYarn = "Again (Outside)"
            Case Else : CheckInboundProcessYarn = ""
        End Select
    End Function
    Public Function CheckProcessPurchsing(DYEING_CHK As String) As String

        Select Case DYEING_CHK
            Case "1" : CheckProcessPurchsing = "NORMAL"
            Case "2" : CheckProcessPurchsing = "SAMPLE"
            Case "3" : CheckProcessPurchsing = "RETURN"
            Case Else : CheckProcessPurchsing = "NORMAL"
        End Select
    End Function
    Public Function K3111_CheckMarketType(DYEING_CHK As String) As String

        Select Case DYEING_CHK
            Case "1" : K3111_CheckMarketType = "DOMESTIC"
            Case "2" : K3111_CheckMarketType = "EXPORT"
            Case Else : K3111_CheckMarketType = "DOMESTIC"
        End Select
    End Function
    Public Function K3113_CheckRequestPurchasing(DYEING_CHK As String) As String

        Select Case DYEING_CHK
            Case "1" : K3113_CheckRequestPurchasing = "Not Approval"
            Case "2" : K3113_CheckRequestPurchasing = "Complete"
            Case "3" : K3113_CheckRequestPurchasing = "Approval"
            Case "4" : K3113_CheckRequestPurchasing = "Cancel"
            Case "5" : K3113_CheckRequestPurchasing = "Transmit"
            Case "6" : K3113_CheckRequestPurchasing = "Pending"
            Case Else : K3113_CheckRequestPurchasing = "Not Approval"
        End Select
    End Function
    Public Function FUNCTION_MCHK1(MCHK1 As String) As String

        Select Case MCHK1
            Case "1" : FUNCTION_MCHK1 = "HIGH PRESSURE"
            Case "2" : FUNCTION_MCHK1 = "NORMAL PRESSURE"
            Case "3" : FUNCTION_MCHK1 = "NORMAL/HIGH PRESSURE"
            Case Else : FUNCTION_MCHK1 = ""
        End Select

    End Function

    Public Function FUNCTION_APPROVAL_SEWING(SEWING_CHK As String) As String

        Select Case SEWING_CHK
            Case "1" : FUNCTION_APPROVAL_SEWING = "SN"
            Case "2" : FUNCTION_APPROVAL_SEWING = "SF"
            Case "3" : FUNCTION_APPROVAL_SEWING = "SA"
            Case "4" : FUNCTION_APPROVAL_SEWING = "SC"
            Case "5" : FUNCTION_APPROVAL_SEWING = "SM"
            Case Else : FUNCTION_APPROVAL_SEWING = "SX"
        End Select
    End Function
    Public Function FUNCTION_ORDER_PSEL(PSEL As String)

        Select Case PSEL
            Case "1" : FUNCTION_ORDER_PSEL = "FOB"
            Case "2" : FUNCTION_ORDER_PSEL = "CIF"
            Case "3" : FUNCTION_ORDER_PSEL = "CNF"
            Case "4" : FUNCTION_ORDER_PSEL = "CPT"
            Case Else : FUNCTION_ORDER_PSEL = ""
        End Select

    End Function
    Public Function FUNCTION_ORDER_SFSEL(SFSEL As String)

        Select Case SFSEL
            Case "1" : FUNCTION_ORDER_SFSEL = "INSIDE"
            Case "2" : FUNCTION_ORDER_SFSEL = "OUTSIDE"
            Case Else : FUNCTION_ORDER_SFSEL = ""
        End Select

    End Function
    Public Function FUNCTION_ORDER_WJGU(WJGU As String)

        Select Case WJGU
            Case "1" : FUNCTION_ORDER_WJGU = "KNITT"
            Case "2" : FUNCTION_ORDER_WJGU = "WOVEN"
            Case Else : FUNCTION_ORDER_WJGU = ""
        End Select

    End Function
    Public Function FUNCTION_ORDER_SJGU(SJGU As String) As String

        Select Case SJGU
            Case "1" : FUNCTION_ORDER_SJGU = "Domestic"
            Case "2" : FUNCTION_ORDER_SJGU = "export"
            Case Else : FUNCTION_ORDER_SJGU = ""
        End Select

    End Function
    Public Function FUNCTION_WCHK_PLAN(WCHK_PLAN As String) As String

        Select Case WCHK_PLAN

            Case "1" : FUNCTION_WCHK_PLAN = "INCOMPLETE"
            Case "2" : FUNCTION_WCHK_PLAN = "COMPLETE"
            Case "3" : FUNCTION_WCHK_PLAN = "HOLDING"
            Case "4" : FUNCTION_WCHK_PLAN = "CANCEL"
            Case "5" : FUNCTION_WCHK_PLAN = "ACCIDENT"
            Case "6" : FUNCTION_WCHK_PLAN = "PROCESSING"
            Case Else : FUNCTION_WCHK_PLAN = ""
        End Select

    End Function
    Public Function FUNCTION_WEAVING_GLCR(GLCR As String)

        Select Case GLCR
            Case "1" : FUNCTION_WEAVING_GLCR = "LEFT"
            Case "2" : FUNCTION_WEAVING_GLCR = "CENTER"
            Case "3" : FUNCTION_WEAVING_GLCR = "RIGHT"
            Case Else : FUNCTION_WEAVING_GLCR = ""
        End Select

    End Function
    Public Function FUNCTION_POSS_DUY(GLCR As String)
        FUNCTION_POSS_DUY = ""
        Dim cns As ConnectSQL = M_CODE.GetConnect(Pub.pos)

        FUNCTION_POSS_DUY = cns.Name
    End Function
    Public Function FUNCTION_POSS(GLCR As String)
        FUNCTION_POSS = ""
        Select Case GLCR
            Case "1" : FUNCTION_POSS = "INSIDE"
            Case "2" : FUNCTION_POSS = "OUTSIDE"
            Case "3" : FUNCTION_POSS = "EDUCATION"
            Case "4" : FUNCTION_POSS = "HOME"
        End Select
    End Function
    Public Function FUNCTION_BASIC_FBCD(FBCD As String)

        Select Case FBCD
            Case "1" : FUNCTION_BASIC_FBCD = "KNITT"
            Case "2" : FUNCTION_BASIC_FBCD = "WOVEN"
            Case Else : FUNCTION_BASIC_FBCD = ""
        End Select

    End Function
    Public Function FUNCTION_FABRIC_TYPE(FABRIC_TYPE As String)

        Select Case FABRIC_TYPE
            Case "1" : FUNCTION_FABRIC_TYPE = "OPEN"
            Case "2" : FUNCTION_FABRIC_TYPE = "TUBE"
            Case Else : FUNCTION_FABRIC_TYPE = ""
        End Select

    End Function

    Public Function FUNCTION_FABRIC_SIDE(SIDE As String)

        Select Case SIDE
            Case "1" : FUNCTION_FABRIC_SIDE = "INSIDE"
            Case "2" : FUNCTION_FABRIC_SIDE = "OUTSIDE"
            Case Else : FUNCTION_FABRIC_SIDE = ""
        End Select

    End Function

    Public Function FUNCTION_ORDER_WCHK(WCHK As String)

        Select Case WCHK
            Case "1" : FUNCTION_ORDER_WCHK = "Not Approval"
            Case "2" : FUNCTION_ORDER_WCHK = "Complite"
            Case "3" : FUNCTION_ORDER_WCHK = "Approval"
            Case "4" : FUNCTION_ORDER_WCHK = "Cancel"
            Case Else : FUNCTION_ORDER_WCHK = ""
        End Select

    End Function
    Public Function FUNCTION_DIRECTION(DIRECTION As String) As String

        Select Case DIRECTION

            Case "1" : FUNCTION_DIRECTION = "WARP"
            Case "2" : FUNCTION_DIRECTION = "WEFT"
            Case Else : FUNCTION_DIRECTION = ""
        End Select

    End Function
    Public Function FUNCTION_YSEL(YSEL As String) As String

        Select Case YSEL
            Case "1" : FUNCTION_YSEL = "SINGLE"
            Case "2" : FUNCTION_YSEL = "DOUBLE"
            Case Else : FUNCTION_YSEL = "SINGLE"
        End Select

    End Function
    Public Function FUNCTION_KNITTING_INBOUND_BSEL(BSEL As String)

        Select Case BSEL
            Case "1" : FUNCTION_KNITTING_INBOUND_BSEL = "NORMAL"
            Case "2" : FUNCTION_KNITTING_INBOUND_BSEL = "OUTSIDE"
            Case "3" : FUNCTION_KNITTING_INBOUND_BSEL = "AGAIN[INSIDE]"
            Case "4" : FUNCTION_KNITTING_INBOUND_BSEL = "AGAIN[OUTSIDE]"
            Case "5" : FUNCTION_KNITTING_INBOUND_BSEL = "MOVE"
            Case Else : FUNCTION_KNITTING_INBOUND_BSEL = ""
        End Select

    End Function
    Public Function FUNCTION_ORDER_BSEL(BSEL As String) As String

        Select Case BSEL
            Case "1" : FUNCTION_ORDER_BSEL = "Normal"
            Case "2" : FUNCTION_ORDER_BSEL = "Sample"
            Case "3" : FUNCTION_ORDER_BSEL = "Re_Prod"
            Case Else : FUNCTION_ORDER_BSEL = ""
        End Select

    End Function
    Public Function FUNCTION_KNITTING_OUTBOUND_BSEL(BSEL As String)

        Select Case BSEL
            Case "1" : FUNCTION_KNITTING_OUTBOUND_BSEL = "NORMAL"
            Case "2" : FUNCTION_KNITTING_OUTBOUND_BSEL = "OUTSIDE"
            Case "3" : FUNCTION_KNITTING_OUTBOUND_BSEL = "RECALL"
            Case "4" : FUNCTION_KNITTING_OUTBOUND_BSEL = "MOVE"
            Case Else : FUNCTION_KNITTING_OUTBOUND_BSEL = ""
        End Select

    End Function
    Public Function FUNCTION_ORDER_ORGU(ORGU As String)

        Select Case ORGU
            Case "1" : FUNCTION_ORDER_ORGU = "Sample"
            Case "2" : FUNCTION_ORDER_ORGU = "Normal"
            Case "3" : FUNCTION_ORDER_ORGU = "Repeat"
            Case "4" : FUNCTION_ORDER_ORGU = "Compensation"
            Case "5" : FUNCTION_ORDER_ORGU = "Stock"
            Case Else : FUNCTION_ORDER_ORGU = ""
        End Select

    End Function
    Public Function FUNCTION_ORDER_JBGU(JBGU As String) As String

        Select Case JBGU
            Case "1" : FUNCTION_ORDER_JBGU = "Finished"
            Case "2" : FUNCTION_ORDER_JBGU = "Knitting"
            Case "3" : FUNCTION_ORDER_JBGU = "Dyeing"
            Case "4" : FUNCTION_ORDER_JBGU = "Sewing"
            Case Else : FUNCTION_ORDER_JBGU = ""
        End Select

    End Function

    Public Function FUNCTION_WCHK(WCHK As String) As String

        Select Case WCHK

            Case "1" : FUNCTION_WCHK = "INCOMPLETE"
            Case "2" : FUNCTION_WCHK = "COMPLETE"
            Case "3" : FUNCTION_WCHK = "HOLDING"
            Case "4" : FUNCTION_WCHK = "CANCEL"
            Case "5" : FUNCTION_WCHK = "ACCIDENT"
            Case "6" : FUNCTION_WCHK = "PROCESSING"
            Case Else : FUNCTION_WCHK = ""
        End Select

    End Function
    Public Function FUNCTION_JOBORDER_OKIND(OKIND As String)

        Select Case OKIND
            Case "1" : FUNCTION_JOBORDER_OKIND = "INSIDE"
            Case "2" : FUNCTION_JOBORDER_OKIND = "OUTSIDE"
            Case Else : FUNCTION_JOBORDER_OKIND = ""
        End Select

    End Function
    Public Function FUNCTION_BSEL_GREY_OUT(BSEL_GREY_OUT As String) As String

        Select Case BSEL_GREY_OUT
            Case "1" : FUNCTION_BSEL_GREY_OUT = "NORMAL"
            Case "2" : FUNCTION_BSEL_GREY_OUT = "SALES"
            Case Else : FUNCTION_BSEL_GREY_OUT = ""
        End Select

    End Function
    Public Function FUNCTION_YCHK(YCHK As String) As String

        Select Case YCHK

            Case "1" : FUNCTION_YCHK = "R/W"
            Case "2" : FUNCTION_YCHK = "Y/D"
            Case "3" : FUNCTION_YCHK = "MG"
            Case Else : FUNCTION_YCHK = ""
        End Select

    End Function

End Module
