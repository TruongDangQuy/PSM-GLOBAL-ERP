Imports System.Data.SqlClient
Module M_Common

#Region "Variable"

#Region "Structure"
    Public Structure ListConstant
        Public Code As String
        Public Name As String
    End Structure
    Public Structure ListPWConstant
        Public RowID As String
        Public Name As String
    End Structure
    Public Structure BATCH_AREA
        Public BatchQty01 As Double  '			decimal
        Public BatchQty02 As Double  '			decimal
        Public BatchQty03 As Double  '			decimal
        Public BatchQty04 As Double  '			decimal
        Public BatchQty05 As Double  '			decimal
        Public BatchQty06 As Double  '			decimal
        Public BatchQty07 As Double  '			decimal
        Public BatchQty08 As Double  '			decimal
        Public BatchQty09 As Double  '			decimal
        Public BatchQty10 As Double  '			decimal
        Public BatchQty11 As Double  '			decimal
        Public BatchQty12 As Double  '			decimal
        Public BatchQty13 As Double  '			decimal
        Public BatchQty14 As Double  '			decimal
        Public BatchQty15 As Double  '			decimal
        Public BatchQty16 As Double  '			decimal
        Public BatchQty17 As Double  '			decimal
        Public BatchQty18 As Double  '			decimal
        Public BatchQty19 As Double  '			decimal
        Public BatchQty20 As Double  '			decimal
        Public BatchQty21 As Double  '			decimal
        Public BatchQty22 As Double  '			decimal
        Public BatchQty23 As Double  '			decimal
        Public BatchQty24 As Double  '			decimal
        Public BatchQty25 As Double  '			decimal
        Public BatchQty26 As Double  '			decimal
        Public BatchQty27 As Double  '			decimal
        Public BatchQty28 As Double  '			decimal
        Public BatchQty29 As Double  '			decimal
        Public BatchQty30 As Double  '			decimal

        Public QtyBatch01 As Double  '			decimal
        Public QtyBatch02 As Double  '			decimal
        Public QtyBatch03 As Double  '			decimal
        Public QtyBatch04 As Double  '			decimal
        Public QtyBatch05 As Double  '			decimal
        Public QtyBatch06 As Double  '			decimal
        Public QtyBatch07 As Double  '			decimal
        Public QtyBatch08 As Double  '			decimal
        Public QtyBatch09 As Double  '			decimal
        Public QtyBatch10 As Double  '			decimal
        Public QtyBatch11 As Double  '			decimal
        Public QtyBatch12 As Double  '			decimal
        Public QtyBatch13 As Double  '			decimal
        Public QtyBatch14 As Double  '			decimal
        Public QtyBatch15 As Double  '			decimal
        Public QtyBatch16 As Double  '			decimal
        Public QtyBatch17 As Double  '			decimal
        Public QtyBatch18 As Double  '			decimal
        Public QtyBatch19 As Double  '			decimal
        Public QtyBatch20 As Double  '			decimal
        Public QtyBatch21 As Double  '			decimal
        Public QtyBatch22 As Double  '			decimal
        Public QtyBatch23 As Double  '			decimal
        Public QtyBatch24 As Double  '			decimal
        Public QtyBatch25 As Double  '			decimal
        Public QtyBatch26 As Double  '			decimal
        Public QtyBatch27 As Double  '			decimal
        Public QtyBatch28 As Double  '			decimal
        Public QtyBatch29 As Double  '			decimal
        Public QtyBatch30 As Double  '			decimal
        '=========================================================================================================================================================
    End Structure
    Public Structure BAR_AREA
        Public xGNAME As String
        Public xFNAME As String
        Public xCNAME As String
        Public xYCNAME As String
        Public xSTNO As String
        Public xLOTNO As String
        Public xPOG As String
        Public xGYD As String
        Public xGYD1 As String
        Public xGRM As String
        Public xSWGT As String
        Public xSWGT2 As String
        Public xGWGT As String
        Public xSANO As String
        Public xGYULJUM As String
        Public xBUYER As String
        Public xRLNO As String
        Public xWDCD As String
        Public xGDATE As String
        Public xKEY1338 As String

        Public xYARN As String
        Public xLOT As String
        Public XCON As String
        Public xCNNO As String
        Public xONAT As String
        Public XCWGT As String

        Public xJSSEL As String
        Public XBSEL As String
        Public xSBL As String
        Public xJUL As String
        Public xDANNO As String
        Public xREMK As String
        Public xREMK1 As String
        Public xREMK2 As String

        Public xGJCD As String
        Public xGDNO As String
        Public xJAKJI As String
    End Structure
    Public Structure STITCHING_AREA
        Public JobCard As String
        Public BarcodeSeq As String
        Public CheckSide As String
        Public CuttingBatchSno As String
        Public SizeName As String
        Public DatePrint As String
        Public SealNo As String
        Public Barcode As String
        Public Article As String
        Public Line As String
        Public Color As String
        Public Sno As String
        Public QtyBatch As String
        Public QtyProd As String

        Public cdProdLine As Integer
        Public cdFactory As Integer
        Public cdMainProcess As String

        Public NumBer As String

        Public Position As String

    End Structure
    Public Structure CUTTING_AREA_NEW
        Public JobCard As String
        Public BarcodeSeq As String
        Public CheckSide As String
        Public CuttingBatchSno As String
        Public SizeName As String
        Public DatePrint As String
        Public SealNo As String
        Public Barcode As String
        Public Article As String
        Public Line As String
        Public Color As String
        Public Sno As String
        Public QtyBatch As String

        Public cdProdLine As Integer
        Public cdFactory As Integer
        Public cdMainProcess As String

        Public Position As String

        Public ComponentName As String
        Public CuttingBatch As String
        Public CuttingBatchSeq As String
        Public CuttingBatchSzno As String
        Public SizeQty As String

    End Structure
    Public Structure CUTTING_AREA
        Public ComponentName As String
        Public CuttingBatch As String
        Public CuttingBatchSeq As String
        Public CuttingBatchSzno As String
        Public CuttingBatchSno As String
        Public SizeName As String
        Public SizeQty As String
        Public DatePrint As String
        Public SealNo As String
        Public Barcode As String
    End Structure
    Public Structure SOLE_AREA
        Public OSBatch As String
        Public OSBatchSeq As String
        Public OSBatchSzno As String
        Public OSBatchSno As String
        Public SizeName As String
        Public QtySize As String
        Public DatePrint As String
        Public MoldName As String

        Public SlNo As String
        Public ColorName As String

        Public OSColorCode As String
        Public OSColorName As String

        Public LGColorCode As String
        Public LGColorName As String

        Public ISColorCode As String
        Public ISColorName As String

        Public MSColorCode As String
        Public MSColorName As String

        Public Barcode As String
        Public Machine As String
    End Structure
    Public Structure MATERIAL_AREA
        Public PRNo As String
        Public Grade As String
        Public Remark As String

        Public MaterialCode As String
        Public MaterialName As String

        Public cdUnitMaterialName As String
        Public cdUnitPackingName As String

        Public BoxInBoundMaterial As String
        Public QtyInBoundMaterial As String
        Public LCNO As String
        Public ColorName As String

        Public Article As String

        Public DateInBoundMaterial As String
        Public MaterialInBoundSno As String

        Public InchargeInBoundMaterialName As String
        Public SupplierName As String

        Public CheckInBoundMaterial As String
        Public CheckMaterialType As String
        Public CheckMarketType As String

        Public Barcode As String
        Public CustomerCode As String

        Public LotNO As String
        Public LotNoSeq As String
        Public BoxProduction As String
        Public QtyGrossProduction As String
        Public QtyNetProduction As String

        Public PackInBound As String
        Public QtyInBound As String
        Public InvoiceNo As String
        Public InchargeInBoundName As String
        'Public QtyInBound As String

        Public DateAccept As String

        Public DateETD As String
        Public DateETA As String

        Public TimeProduction As String
        Public InchargeProduction As String
        Public CustomerName As String
        Public CheckInBoundProcess As String

    End Structure
    Public Structure MATERIAL_Data
        Dim FACT As String
        Dim IDATE As String
        Dim ISEQ As String
    End Structure
    Public Structure tPLAN_AREA
        Dim FACTORY As String
        Dim YCODE As String
        Dim YNAME As String
        Dim JAKJI_SP As String
        Dim JSEQ_SP As String
        Dim WCHK_JOB As String
    End Structure




#End Region

    Public ListCons As New List(Of ListConstant)
    Public ListPW As New List(Of ListPWConstant)
    Public FormTableName As String
    Public FormTablePara As String
    Public Batch_1 As BATCH_AREA
    Public BAR As BAR_AREA
    'Public CUTTINGPANEL1 As CUTTING_AREA
    'Public CUTTINGPANEL2 As CUTTING_AREA

    Public STITCHINGPANEL_LIST As New List(Of STITCHING_AREA)
    Public STITCHINGPANEL0 As STITCHING_AREA

    Public CUTTINGPANEL_LIST As New List(Of CUTTING_AREA_NEW)
    Public CUTTINGPANEL0 As CUTTING_AREA_NEW

    Public CUTTINGPANEL1 As CUTTING_AREA_NEW
    Public CUTTINGPANEL2 As CUTTING_AREA_NEW
    Public CUTTINGPANEL3 As CUTTING_AREA_NEW
    Public CUTTINGPANEL4 As CUTTING_AREA_NEW

    Public STITCHINGPANEL1 As STITCHING_AREA
    Public STITCHINGPANEL2 As STITCHING_AREA
    Public STITCHINGPANEL3 As STITCHING_AREA
    Public STITCHINGPANEL4 As STITCHING_AREA

    Public STITCHINGPANEL5 As STITCHING_AREA
    Public STITCHINGPANEL6 As STITCHING_AREA
    Public STITCHINGPANEL7 As STITCHING_AREA
    Public STITCHINGPANEL8 As STITCHING_AREA

    Public OSPANEL1 As SOLE_AREA
    Public OSPANEL2 As SOLE_AREA
    Public OSPANEL3 As SOLE_AREA
    Public OSPANEL4 As SOLE_AREA

    Public MATERIAL As MATERIAL_AREA
    Public MATERIALLIST As New List(Of MATERIAL_AREA)

    Public ZoomSize As Single = 1

    Public USERSANO As String
    Public USERNAME As String
    Public SuperChk As String
    Public USERIP As String  '»ç¿ë IP
    Public IMG_CHK As Boolean

    Public JOBDATE As String

    Public isudCHK As Boolean
    Public hlpCHK As Boolean
    Public prtCHK As Boolean
    Public HlpStr As String

    Public c_PATH As String 'ÆÄÀÏ·Î ÀÎ¼â½Ã °æ·ÎÀúÀå
    Public c_FILE As String 'ÆÄÀÏ·Î ÀÎ¼â½Ã ÆÄÀÏ¸í ÀúÀå

    Public wJOB As Integer
    Public wJOB1 As Integer
    Public wDUNG As Integer
    Public wF1 As String
    Public wCNT As Double  '°¹¼ö

    Public wKeyReturn As String
    Public wAPPROVAL_DYEING As String

    Public MWGT As Double  'Àú¿ï ÀÎÅÍÆäÀÌ½º °ª
    Public MYDS As Double  '¾ßµå±â ÀÎÅÍÆäÀÌ½º °ª

    Public GJNAME As String
    Public CHASU As Integer
    Public PASSWORD As String
    Public FACT_KNITTING As String
    Public CalUnit As Single
    Public AcControl As Control
    Public AcControl1 As Control
    Public Msg_Result As MsgBoxResult

    Public W1_CHK1 As String
    Public W1_CHK2 As String
    Public W1_CHK3 As String  'ÀÔ·Â½Ã
    Public W1_CHK4 As String
    Public W1_CHK5 As String  'ÀÎ¼â½Ã
    Public W1_CHK6 As String
    Public W1_CHK7 As String
    Public W1_CHK8 As String  '°Ë»ö¿¡¼­ ÀÔ·ÂÀ¸·Î
    Public W1_CHK9 As String  '°Ë»ö½Ã HEADº¯°æ
    Public Const cPrgLimit = 10000

    Public MATERIAL_IMSI() As MATERIAL_Data
    Public Itrpt_Chk As Boolean

    Public dPLAN_AREA As tPLAN_AREA


#End Region

#Region "Methods"
    Public Function DateRemain(text1 As String, text2 As String) As Integer
        DateRemain = 0
        Try
            Dim xTimeSpan As TimeSpan
            Dim Sdate As Date
            Dim Edate As Date

            Sdate = New Date(Strings.Left(text1, 4), Mid(text1, 5, 2), Strings.Right(text1, 2))
            Edate = New Date(Strings.Left(text2, 4), Mid(text2, 5, 2), Strings.Right(text2, 2))


            xTimeSpan = Edate - Sdate

            Return xTimeSpan.Days + 1

        Catch ex As Exception

        End Try


    End Function
    Public Function DateNoSunDay(text1 As String, QtyDate As Integer) As String

        DateNoSunDay = text1
        Try
            Dim Sdate As Date
            Dim Edate As Date
            Dim i As Integer
            Dim QtyDateNew As Integer
            QtyDateNew = QtyDate

            Sdate = New Date(Strings.Left(text1, 4), Mid(text1, 5, 2), Strings.Right(text1, 2))

            For i = 1 To QtyDate
                If Sdate.AddDays(i).DayOfWeek = DayOfWeek.Sunday Then QtyDateNew += 1
            Next

            Edate = Sdate.AddDays(QtyDateNew)

            Return Edate.Year.ToString("0000") & Edate.Month.ToString("00") & Edate.Day.ToString("00")

        Catch ex As Exception

        End Try


    End Function
    Public Function ListCode(Value As String) As String
        If Value.Contains("LineProd") Then Value = "LineProd"

        ListCode = ""
        Value = Value.ToUpper
        Try
            Return ListCons.FindAll(Function(p) p.Name = Value)(0).Code
        Catch ex As Exception

        End Try
    End Function
    Public Sub Gadget_Load(Gadget As Object, FormName As String)
        Dim i As Integer

        Try
            Dim Children As New List(Of Object)
            Children = CType(Gadget, Control).FindAllType

            For i = 0 To Children.Count - 1
                If Children(i).Name.Length > 5 Then
                    If READ_PFK7420_ITEMNAME(Pub.GRP, Mid(Children(i).Name, 5)) Then
                        Children(i).Data = D7420.ItemCodeData
                        Children(i).Code = D7420.ItemCodeCode
                        Children(i).Enabled = False

                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then

                            If READ_PFK9916_1(FormName, Strings.Mid(Children(i).Name, 5)) Then
                                If D9916.CheckDev = "1" Then
                                    Select Case D9916.REMK.Split(";")(0)
                                        Case 1
                                            If READ_PFK7101(D7421.ItemCodeCode) Then
                                                Children(i).Data = D7101.CustomerName
                                            End If

                                        Case 6
                                            If READ_PFK7411(D7421.ItemCodeCode) Then
                                                Children(i).Data = D7411.Name
                                            End If

                                        Case 7
                                            If READ_PFK7231(D7421.ItemCodeCode) Then
                                                Children(i).Data = D7231.MaterialName
                                            End If

                                        Case 8
                                            If Children(i).Name.ToString.Length > 6 Then
                                                If READ_PFK7171(ListCode(Strings.Mid(Children(i).Name.ToString, 7)), D7421.ItemCodeCode) Then
                                                    Children(i).Data = D7171.BasicName
                                                End If
                                            End If
                                    End Select

                                End If
                            End If

                        End If

                    ElseIf READ_PFK7421_ITEMNAME(Pub.SAW, Mid(Children(i).Name, 5)) = True Then
                        Children(i).Data = D7421.ItemCodeData
                        Children(i).Code = D7421.ItemCodeCode

                        If TypeOf (Children(i)) Is SelectPeaceHLPButton Then

                            If READ_PFK9916_1(FormName, Strings.Mid(Children(i).Name, 5)) Then
                                If D9916.CheckDev = "1" Then
                                    Select Case D9916.REMK.Split(";")(0)
                                        Case 1
                                            If READ_PFK7101(D7421.ItemCodeCode) Then
                                                Children(i).Data = D7101.CustomerName
                                            End If

                                        Case 6
                                            If READ_PFK7411(D7421.ItemCodeCode) Then
                                                Children(i).Data = D7411.Name
                                            End If

                                        Case 7
                                            If READ_PFK7231(D7421.ItemCodeCode) Then
                                                Children(i).Data = D7231.MaterialName
                                            End If

                                        Case 8
                                            If Children(i).Name.ToString.Length > 6 Then
                                                If READ_PFK7171(ListCode(Strings.Mid(Children(i).Name.ToString, 7)), D7421.ItemCodeCode) Then
                                                    Children(i).Data = D7171.BasicName
                                                End If
                                            End If
                                    End Select

                                End If


                            End If

                        End If
                    End If
                End If
            Next
        Catch ex As Exception

        End Try
    End Sub
    Public Function getPrimaryKey(formname As Form) As String
        getPrimaryKey = ""
        Try
            If formname.Name.Length > 9 Then Exit Function

            SQL = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA + '.' + QUOTENAME(CONSTRAINT_NAME)), 'IsPrimaryKey') = 1 AND TABLE_NAME = 'PFK" + Strings.Mid(formname.Name, 5, 4) + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            DS1 = PrcDS(cmd, cn)

            Dim Children As New List(Of System.Windows.Forms.Control)

            Children = formname.FindAllChildren

            Dim i As Integer = 0
            Dim Value As String

            For i = 0 To GetDsRc(DS1) - 1
                Value = GetDsData(DS1, i, 0)
                Value = Strings.Mid(Value, 7)

                Dim o As New Object
                o = Children.Find(Function(a) a.Name.Contains(Value))

                getPrimaryKey = getPrimaryKey & o.Data & ";"

            Next

            If Len(getPrimaryKey) > 2 Then getPrimaryKey = Strings.Left(getPrimaryKey, Len(getPrimaryKey) - 1)

        Catch ex As Exception

        End Try

    End Function
    Public Function getPrimaryKey(formname As String, Sheet As FarPoint.Win.Spread.FpSpread) As String
        getPrimaryKey = ""
        Try
            If formname.Contains("PFP") Then
                formname = Strings.Left(formname, 8)
            End If
            If formname.Length > 9 Then Exit Function

            SQL = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA + '.' + QUOTENAME(CONSTRAINT_NAME)), 'IsPrimaryKey') = 1 AND TABLE_NAME = 'PFK" + Strings.Mid(formname, 4, 4) + "'"

            cmd = New SqlClient.SqlCommand(SQL, cn)
            DS1 = PrcDS(cmd, cn)

            Dim i As Integer = 0
            Dim Value As String
            Dim Data As String

            For i = 0 To GetDsRc(DS1) - 1
                Value = GetDsData(DS1, i, 0)
                Value = Strings.Mid(Value, 7)

                Data = getData(Sheet, getColumIndex(Sheet, "key_" & Value), Sheet.ActiveSheet.ActiveRowIndex)

                If Data = "" Then
                    Data = getData(Sheet, getColumIndex(Sheet, Value), Sheet.ActiveSheet.ActiveRowIndex)
                End If

                getPrimaryKey = getPrimaryKey & Data & ";"
            Next

            If Len(getPrimaryKey) > 2 Then getPrimaryKey = Strings.Left(getPrimaryKey, Len(getPrimaryKey) - 1)

        Catch ex As Exception

        End Try

    End Function
    Public Sub SetCMBindex(ByRef cmd As SelectPeaceCombo, ByVal index As Integer)
        cmd.PeaceCombobox1.SelectedIndex = index
    End Sub
    Public Function GetCMBindex(ByRef cmd As SelectPeaceCombo) As Integer
        Return cmd.PeaceCombobox1.SelectedIndex
    End Function
    Public Function SizeNameFull(Szno) As String
        SizeNameFull = ""

        Select Case CIntp(Szno)
            Case 1
                Return D7104.Size01
            Case 2
                Return D7104.Size02
            Case 3
                Return D7104.Size03
            Case 4
                Return D7104.Size04
            Case 5
                Return D7104.Size05
            Case 6
                Return D7104.Size06
            Case 7
                Return D7104.Size07
            Case 8
                Return D7104.Size08
            Case 9
                Return D7104.Size09
            Case 10
                Return D7104.Size10

            Case 11
                Return D7104.Size11
            Case 12
                Return D7104.Size12
            Case 13
                Return D7104.Size13
            Case 14
                Return D7104.Size14
            Case 15
                Return D7104.Size15
            Case 16
                Return D7104.Size16
            Case 17
                Return D7104.Size17
            Case 18
                Return D7104.Size18
            Case 19
                Return D7104.Size19
            Case 20
                Return D7104.Size20

            Case 21
                Return D7104.Size21
            Case 22
                Return D7104.Size22
            Case 23
                Return D7104.Size23
            Case 24
                Return D7104.Size24
            Case 25
                Return D7104.Size25
            Case 26
                Return D7104.Size26
            Case 27
                Return D7104.Size27
            Case 28
                Return D7104.Size28
            Case 29
                Return D7104.Size29
            Case 30
                Return D7104.Size30
        End Select

    End Function
    Public Function Error_Message(ByVal MsgSel As String, ByVal MsgTitle As String) As Microsoft.VisualBasic.MsgBoxResult
        On Error GoTo Error_Message
        Dim strMSG As String = ""
        Dim RS99 As SqlClient.SqlDataReader

        SQL = " SELECT K9997_NAT01,K9997_NAT02, K9997_NAT03, K9997_NAT04 FROM PFK9997 "
        SQL = SQL & " WHERE K9997_CODE   = '" & MsgSel & "' "
        SQL = SQL & "   AND K9997_SELECT = '1' "
        cmd = New SqlClient.SqlCommand(SQL, cn) : RS99 = cmd.ExecuteReader : RS99.Read()

        If RS99.HasRows Then
            Select Case Pub.NAT
                Case 1 : strMSG = RS99![K9997_NAT01]
                Case 2 : strMSG = RS99![K9997_NAT02]
                Case 3 : strMSG = RS99![K9997_NAT03]
                Case 4 : strMSG = RS99![K9997_NAT04]
                Case Else : strMSG = RS99![K9997_NAT01]
            End Select

            If Trim(strMSG) = "" Then strMSG = RS99![K9997_NAT01]

            MsgBox(strMSG, vbInformation, MsgTitle)

        End If

        RS99.Close()
        Return strMSG

        Exit Function
Error_Message:
        Select Case RS99.IsClosed
            Case False : RS99.Close()
        End Select

        MsgBox(" MESSAGE ERROR ", vbInformation, "ERROR_MESSAGE")
    End Function
    Public Sub Setfocus(abc As Object)
        Application.DoEvents()
        If TypeOf (abc) Is PeaceTextbox Then abc.select() : Exit Sub
        Dim c As Object
        For Each c In abc.controls
            If TypeOf (c) Is TableLayoutPanel Then
                Dim d As Object
                For Each d In c.controls
                    If TypeOf (d) Is PeaceTextbox Then
                        d.select() : Exit Sub
                    End If
                Next
            End If
        Next
    End Sub
    Public Function NumCheck(Num As Object, MSG As String) As Boolean
        NumCheck = False

        If Trim$(Num) = " " Then Num = "0"

        If Not IsNumeric(Num) Then
            Call MsgBoxP("44", MSG)
            Exit Function
        End If

        NumCheck = True
    End Function
    Public Sub INTERRUPT_TOGGLE(KeyCode As Integer)
        'Itrpt_Chk = True
        'If KeyCode = Keys.F11 Then Itrpt_Chk = False
    End Sub
    Public Function INTERRUPT_BREAK() As Boolean

        'INTERRUPT_BREAK = False

        'If Itrpt_Chk = False Then
        '    Itrpt_Chk = True
        '    INTERRUPT_BREAK = True
        'End If

    End Function
    Public Sub Cms_additem(ByRef cms As ContextMenuStrip, ParamArray items() As String)
        Dim i As Integer
        For i = 0 To UBound(items)
            cms.Items.Add(items(i))
        Next
    End Sub
    Public Sub TEXT_FOCUS(tmpText As Control)
        'tmpText.SelStart = 0
        'tmpText.SelLength = 100
    End Sub
    Public Function FormatIPNO(IPNO As String) As String
        Return Left(IPNO, 2) & "-" & Mid(IPNO, 3, 4) & "-" & Mid(IPNO, 7)
    End Function
    Public Sub PRG_SET(ByRef prg As E_PRG, ByRef Base As Form, Optional ByVal MaxValue As Integer = 100)

        prg = Nothing

        prg = New E_PRG(MaxValue)

        '     prg.Parent = Base

        prg.StartPosition = FormStartPosition.CenterScreen

        prg.TopMost = True

        ' prg.ShowDialog()
        prg.Show()
    End Sub
    Public Sub PRG_SET(ByRef prg As E_PRG, Optional ByVal MaxValue As Integer = 100)
        Try
            prg = Nothing

            prg = New E_PRG(MaxValue)

            Itrpt_Chk = True
            prg.StartPosition = FormStartPosition.CenterScreen

            prg.TopMost = True

            prg.Show()
        Catch ex As Exception

        End Try

        '    prg.ShowDialog()
    End Sub
    Public Function PRG_VALUE(ByRef prg As E_PRG, ByVal Value As Integer) As Boolean
        PRG_VALUE = False
        Try
            If Not (prg Is Nothing) Then
                prg.Value = Value
                ' prg.BGW.RunWorkerAsync()
            End If
            PRG_VALUE = True
        Catch ex As Exception

        End Try


    End Function
    Public Sub SQL_MAKE(ByRef AC As SelectMulti, ByVal CodeName As String, Optional ByVal PreName As String = "", Optional ByVal SqlSize As Integer = 8000)

        Dim j As Integer
        Dim strTemp As String = ""

        If Not (AC.Data Is Nothing) Then

            If CBO_CHK(AC.cboText.Text, 10) = False Then Exit Sub

            If AC.cboText.Text <> "X" Then

                If AC.cboText.SelectedIndex > 0 Then

                    strTemp = " AND " & PreName & CodeName & "=''" & STR2CODE(AC.cboText.SelectedItem.ToString, 6) & "'' "

                Else

                    strTemp = " AND ("

                    '3337년09월10일 저장프로시저와 동적쿼리시 값의 ' 구분이 틀려서 ' 구분을 제거함 

                    For j = 0 To UBound(AC.Data) - 1
                        If j <> UBound(AC.Data) - 1 Then strTemp = strTemp & PreName & CodeName & "=''" & AC.Data(j).CODE & "'' OR "
                        If j = UBound(AC.Data) - 1 Then strTemp = strTemp & PreName & CodeName & "=''" & AC.Data(j).CODE & "'') "
                    Next

                End If

            End If

        End If

        If Len(AC.SQL) > SqlSize Then

            MsgBoxP("검색조건 범위가 너무 큽니다.")

            AC.SQL = ""

        Else

            AC.SQL = strTemp

        End If

    End Sub
    Public Function CBO_CHK(ByVal A As String, ByVal B As Integer) As Boolean
        CBO_CHK = False
        Try
            Dim i As Integer
            Dim k As Integer
            Dim tStr As String

            For i = 1 To B

                tStr = Mid(A.Trim, i, 1)

                If tStr <> "" Then
                    If tStr = "C" Then k = k + 1
                    If (Asc(tStr)) < 0 Then
                        If tStr = "C" Then k = k + 1
                    Else
                        If (Asc(tStr)) = 91 Or (Asc(tStr)) = 93 Then
                            Return True : Exit For
                        End If
                    End If

                End If

            Next

            If k = 1 Then Return True

        Catch ex As Exception

        End Try
    End Function
    Public Function STR2CODE(ByVal Value As String, Optional ByVal CodeLength As Integer = 0, _
    Optional ByVal Sep1 As String = "[", Optional ByVal Sep2 As String = "]")

        Dim strTemp As String = ""
        Dim i As Integer = 0

        If Value = "" Then Return False
        If CodeLength < 0 Then Return False

        i = Value.IndexOf(Sep1)

        If CodeLength > 0 Then

            If Value.Length >= i + CodeLength + 1 Or i >= 0 Then

                strTemp = Mid(Value, i + 2, CodeLength)

            End If

        Else

            If Value.Length >= i + 1 Or i >= 0 Then

                strTemp = Trim(Mid(Value, i + 2))

            End If

        End If

        Return strTemp

    End Function
    Public Function OBJ_GCODE(ByRef AC As SelectMulti, Optional ByVal SqlCodeName As String = "", Optional ByVal SqlPreName As String = "", Optional ByVal GCHK As String = "0") As Boolean

        Dim AA() As String
        Dim i As Integer

        Dim Pipe As New C_Pipe

        Dim frm As New HLP0001_M(Pipe, GCHK)

        frm.ShowDialog()

        AC.SelectedCount = 0

        AC.SqlCodeName = SqlCodeName
        AC.SqlPreName = SqlPreName

        If Pipe.RetValue <> "" Then

            AA = Split(Pipe.RetValue, ";")

            AC.cboText.Items.Clear()

            Select Case UBound(AA)

                Case -1

                    AC.cboText.Items.Add(" ALL SELECT")

                    AC.SelectedCount = -1

                Case 0

                    AC.cboText.Items.Add(" X")

                Case Else

                    AC.cboText.Items.Add(" " & UBound(AA) & "C")

                    ReDim AC.Data(UBound(AA))

                    For i = 0 To UBound(AA) - 1

                        AC.cboText.Items.Add(AA(i))

                        AC.Data(i).CODE = STR2CODE(AA(i), 6)
                        AC.Data(i).NAME = STR2CODE(AA(i), , "]")

                    Next

                    AC.SelectedCount = UBound(AA)

            End Select

            AC.cboText.SelectedIndex = 0

            Return True

        Else

            Return False

        End If

    End Function
    Public Sub Production_DateName()
        Pub.DAT = System_Date_8()
        '   Pub.TIM = Format(RS09![System_Time], "hhmmss"

        Pub.TIM = Strings.Right(System_Date_time(), 6)

        If Left(Pub.TIM, 6) >= "000000" And Left(Pub.TIM, 6) <= "055959" Then
            Pub.DAT = System_Date_Add(0, -1)
        End If

        If Left(Pub.TIM, 6) >= "060000" And Left(Pub.TIM, 6) <= "140000" Then
            Pub.JUY = "1"
        ElseIf Left(Pub.TIM, 6) > "140000" And Left(Pub.TIM, 6) <= "233300" Then
            Pub.JUY = "2"
        Else
            Pub.JUY = "3"
        End If

    End Sub
    Public Function JPNO_DISPLAY() As String
        JPNO_DISPLAY = False
    End Function
    Public Function MsgBoxPPW(ByVal Content As String, ByVal Pass As String) As Boolean
        MsgBoxPPW = False
        MsgBox(Content, vbCritical)
        Dim tmpPW_CHK As String
        Try
            If Pass = "PSM@." And Pub.SAW = "PSMADMIN" Then Return True
            PASSWORDCHECK = ""

            If Pass = "XXXX" Then
                tmpPW_CHK = "PSM@."

                If FPassWord.Link_PassWord = True Then
                    If PASSWORDCHECK <> tmpPW_CHK Then Call MsgBoxP("Wrong Pass!", vbCritical) : Exit Function
                    MsgBoxPPW = True

                Else
                    MsgBoxPPW = False
                End If

                Exit Function
            End If

            If READ_PFK7171(Const_PASSWORD, Pass) = True Then
                If D7171.NameSimply = "" Then
                    tmpPW_CHK = "PSM@."
                Else
                    tmpPW_CHK = D7171.NameSimply.ToUpper
                End If
                If FPassWord.Link_PassWord = True Then
                    If PASSWORDCHECK <> tmpPW_CHK Then Call MsgBoxP("Wrong Pass!", vbCritical) : Exit Function

                    MsgBoxPPW = True
                Else
                    MsgBoxPPW = False
                End If

            End If

        Catch ex As Exception
            MsgBox("Try your actions again!")
        End Try
    End Function

    Public Function MsgBoxPPW_Management(ByVal Content As String, ByVal Pass As String) As Boolean
        MsgBoxPPW_Management = False
        MsgBox(Content, vbCritical)
        Dim tmpPW_CHK As String
        Try
            If Pass = "XXXX" Then
                tmpPW_CHK = Pub.SITE & Pub.DAT
                tmpPW_CHK = tmpPW_CHK.ToUpper

                If FPassWord.Link_PassWord = True Then
                    If PASSWORDCHECK <> tmpPW_CHK Then Call MsgBoxP("Wrong Pass!", vbCritical) : Exit Function
                    MsgBoxPPW_Management = True

                Else
                    MsgBoxPPW_Management = False
                End If

                Exit Function
            End If

        Catch ex As Exception
            MsgBox("Try your actions again!")
        End Try
    End Function

    Public Function MsgBoxP(ByVal Content As String, Optional ByVal ex As Microsoft.VisualBasic.MsgBoxStyle = MsgBoxStyle.Critical, Optional ByVal Title As String = Nothing) As Microsoft.VisualBasic.MsgBoxResult
        Dim Pipe As New C_Pipe

        Dim frm As New E_MSG(Pipe, Content, ex, Nothing, Nothing, Nothing, String.Empty, String.Empty, String.Empty)


        frm.ShowDialog()

        Return Pipe.RetValue

        Exit Function

        If cn.State = ConnectionState.Closed Then
            MsgBox("Check the network connection! You are disconnected from the server!")
            APP_EXIT()
            Exit Function

            MsgBox("Your network is disconnection! We try to connection!", vbCritical)
            LoadingForm2.ShowDialog()
            If kndl() = True Then
                MsgBox("Your network is successfully connected! Try your actions again!", vbInformation)
                Return Nothing
                Exit Function
            End If
        End If
        Return MsgBox(Content, ex, Title)
    End Function
    Public Function MsgBoxP(ByVal Content As String, ByVal ex As String) As Microsoft.VisualBasic.MsgBoxResult
        Dim Pipe As New C_Pipe

        Dim frm As New E_MSG(Pipe, Content, _MSG_STYLE.OKOnly, Nothing, Nothing, Nothing, String.Empty, String.Empty, String.Empty)


        frm.ShowDialog()

        Exit Function

        If cn.State = ConnectionState.Closed Then
            MsgBox("Check the network connection! You are disconnected from the server!")
            APP_EXIT()
            Return MsgBox(Content & ex)
            Exit Function

            MsgBox("Your network is disconnection! We try to connection!", vbCritical)
            LoadingForm2.ShowDialog()
            If kndl() = True Then
                MsgBox("Your network is successfully connected! Try your actions again!", vbInformation)
                Return Nothing
                Exit Function
            End If
        End If
        Return MsgBox(Content & ex)
    End Function
    Public Function WordConv(Word As String) As String
        WordConv = ""
        WordConv = Word.Trim
    End Function
    Public Function CDblp(sender As Object) As Decimal
        Try
            If IsNumeric(sender) Then Return CDbl(sender) Else Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function CIntp(sender As Object) As Integer
        Try
            If IsNumeric(sender) = False Then Return 0 Else Return CInt(sender)

        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function CIntp_S(sender As Object) As Integer
        Try
            If IsNumeric(sender) Then Return CInt(sender) Else Return 1
        Catch ex As Exception
            Return 1
        End Try
    End Function
    Public Function CDecp(sender As Object) As Decimal
        Try
            If IsNumeric(sender) Then Return CDec(sender) Else Return 0
        Catch ex As Exception
            Return 0
        End Try
    End Function
    Public Function CStrp(sender As Object) As String
        Try
            Return CStr(sender)
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function CboolP(value As Object) As Boolean
        CboolP = False
        Try
            If value = "1" Then Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function Decrypt(ByVal value As String, ByVal ipassword As String, ByVal isalt As String) As String
        Decrypt = ""
        Try
            If String.IsNullOrWhiteSpace(value) Then Exit Function
            Dim byteArray() As Byte = System.Convert.FromBase64String(value)
            Dim fullPassword As String = PasswordDuy + SaltDuy
            Dim sha256 As System.Security.Cryptography.SHA256 = System.Security.Cryptography.SHA256.Create()
            Dim key() As Byte = sha256.ComputeHash(System.Text.UnicodeEncoding.Unicode.GetBytes(fullPassword))
            Dim aes As System.Security.Cryptography.Aes = New System.Security.Cryptography.AesCryptoServiceProvider() : aes.KeySize = 256 : aes.Key = key
            If byteArray.Length < 16 Then Exit Function
            aes.IV = byteArray.Take(16).ToArray()

            Dim decryptor As System.Security.Cryptography.ICryptoTransform = aes.CreateDecryptor()
            Dim result() As Byte = Nothing
            Try
                result = decryptor.TransformFinalBlock(byteArray, 16, byteArray.Length - 16)
            Catch ex As Exception

            End Try
            Decrypt = System.Text.UnicodeEncoding.Unicode.GetString(result)

        Catch ex As Exception

        End Try
    End Function


#End Region
    

End Module
