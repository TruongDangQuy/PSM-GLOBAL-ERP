Imports System.Data.SqlClient
Imports System.IO
Public Class PFP85000

#Region "Variable"
    Protected prg As E_PRG
    Private Dsu01 As Long     'Data Su
    Private Dsu02 As Long     'Data Su
    Private Dsu03 As Long     'Data Su
    Private KEY_SEQ As String

    Private Form_Close As Boolean
#End Region

#Region "Formload"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)
        Me.KeyPreview = True
        Call FORM_INIT()
        Call DATA_INIT()


    End Sub

    Private Sub PFP17811_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub

    Private Sub FORM_INIT()

        DS1 = PrcDS("USP_PFP85000_SEARCH_HEAD", cn)
        Dim i As Integer

        Vs1.Sheets.Count = GetDsRc(DS1)

        For i = 0 To GetDsRc(DS1) - 1
            Vs1.Sheets(i).SheetName = GetDsData(DS1, i, "SheetName")
            Vs1.Sheets(i).Tag = GetDsData(DS1, i, "ChkSizeRange")
        Next

    End Sub


    Private Sub DATA_INIT()
        txt_DateReport.Data = Pub.DAT
    End Sub

#End Region

#Region "Link_ISUD"
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey
                Case Keys.F5 : Call MAIN_JOB01()
                Case Keys.F6 : Call MAIN_JOB02()
                Case Keys.F7 : Call MAIN_JOB03()
                Case Keys.F8 : Call MAIN_JOB04()
                Case Keys.F9 : Call MAIN_JOB05()
            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub tst_1_Click(sender As Object, e As EventArgs) Handles tst_1.Click, tst_2.Click, tst_3.Click, tst_4.Click, tst_5.Click, tst_6.Click
        If sender.Equals(tst_1) Then
            MAIN_JOB01()
        End If
        If sender.Equals(tst_2) Then
            MAIN_JOB02()
        End If
        If sender.Equals(tst_3) Then
            MAIN_JOB03()
        End If
        If sender.Equals(tst_4) Then
            MAIN_JOB04()
        End If
    End Sub

    Private Sub MAIN_JOB01()

    End Sub

    Private Sub MAIN_JOB02()

    End Sub

    Private Sub MAIN_JOB03()

    End Sub

    Private Sub MAIN_JOB04()

    End Sub

    Private Sub MAIN_JOB05()
        If getData(Vs1, 12, Vs1.ActiveSheet.ActiveRowIndex) = "" Then Exit Sub
    End Sub

#End Region

#Region "PFP_SEARCH"
    Private Function DATA_SEARCH_VS1() As Boolean
        DATA_SEARCH_VS1 = False
        Dim i As Integer

        Vs1.Enabled = False

        Dim ProcName As String

        ProcName = "USP_PFP85000_SEARCH_VS1_" & Vs1.ActiveSheetIndex.ToString("00")

        DS1 = PrcDS(ProcName, cn, txt_DateReport.Data, txt_cdSeason.Code, txt_CustomerCode.Code)

        Vs1.ActiveSheet.GrayAreaBackColor = Color.White

        If GetDsRc(DS1) = 0 Then
            Vs1.Enabled = True
            SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))
            Exit Function
        End If

        If Vs1.ActiveSheet.SheetName <> "STITCHING PROD SUMMARY " Then
            SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))
        Else
            Vs1.ZoomFactor = 1.23

            Vs1.ActiveSheet.RowHeader.Visible = True
            Vs1.ActiveSheet.RowCount = 0
            Vs1.ActiveSheet.ColumnCount = 0

            Vs1.ActiveSheet.RowCount = 24
            Vs1.ActiveSheet.ColumnCount = 25

            setDataCH(Vs1, 0, 0, "Stitching Production Summary")
            Vs1.ActiveSheet.ColumnHeader.Cells(0, 0).ColumnSpan = 25


            Dim TotalBorder As New FarPoint.Win.ComplexBorderSide(True, Color.Black, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, New Single() {0.1, 0.1, 0.1, 0.1, 0.1, 0.1})


            setData(Vs1, 0, 0, "Fact#")
            setData(Vs1, 0, 1, "Fact#")
            Vs1.ActiveSheet.Cells(0, 0).RowSpan = 2
            setData(Vs1, 0, 2, "F1")
            setData(Vs1, 0, 3, "F3")
            setData(Vs1, 0, 4, "S.Total")
            setData(Vs1, 0, 5, "F2")
            setData(Vs1, 0, 6, "G.Total")

            setData(Vs1, 0, 7, "    ")

            setData(Vs1, 0, 0 + 8, "Fact#")
            setData(Vs1, 0, 1 + 8, "Fact#")
            Vs1.ActiveSheet.Cells(8, 0).RowSpan = 2

            setData(Vs1, 0, 2 + 8, "F1")
            setData(Vs1, 0, 3 + 8, "F3")
            setData(Vs1, 0, 4 + 8, "S.Total")
            setData(Vs1, 0, 5 + 8, "F2")
            setData(Vs1, 0, 6 + 8, "G.Total")

            setData(Vs1, 0, 15, "    ")

            setData(Vs1, 0, 0 + 8 * 2, "Fact#")
            setData(Vs1, 0, 1 + 8 * 2, "Fact#")
            Vs1.ActiveSheet.Cells(16, 0).RowSpan = 2

            setData(Vs1, 0, 2 + 8 * 2, "F1")
            setData(Vs1, 0, 3 + 8 * 2, "F3")
            setData(Vs1, 0, 4 + 8 * 2, "S.Total")
            setData(Vs1, 0, 5 + 8 * 2, "F2")
            setData(Vs1, 0, 6 + 8 * 2, "G.Total")

            Vs1.ActiveSheet.Cells(0, 0, 6, Vs1.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(TotalBorder, TotalBorder, TotalBorder, TotalBorder)
            Vs1.ActiveSheet.Cells(8, 0, 14, Vs1.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(TotalBorder, TotalBorder, TotalBorder, TotalBorder)
            Vs1.ActiveSheet.Cells(16, 0, 22, Vs1.ActiveSheet.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(TotalBorder, TotalBorder, TotalBorder, TotalBorder)


            For i = 1 To Vs1.ActiveSheet.ColumnCount - 1 Step 4
                setData(Vs1, i, 1, "Target")
                setData(Vs1, i + 1, 1, "TTL")
                Vs1.ActiveSheet.Cells(1, i + 1, 1 + 5, i + 1).BackColor = Color.Gray

                setData(Vs1, i + 2, 1, "Prs/Line")
                setData(Vs1, i + 3, 1, "%")

                setData(Vs1, i, 9, "Target")
                setData(Vs1, i + 1, 9, "TTL")
                Vs1.ActiveSheet.Cells(9, i + 1, 9 + 5, i + 1).BackColor = Color.Gray

                setData(Vs1, i + 2, 9, "Prs/Line")
                setData(Vs1, i + 3, 9, "%")

                setData(Vs1, i, 17, "Target")
                setData(Vs1, i + 1, 17, "TTL")
                Vs1.ActiveSheet.Cells(17, i + 1, 17 + 5, i + 1).BackColor = Color.Gray

                setData(Vs1, i + 2, 17, "Prs/Line")
                setData(Vs1, i + 3, 17, "%")

                Vs1.ActiveSheet.Cells(0, i, 0, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(1, i, 1, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(4, i, 4, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(6, i, 6, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)

                Vs1.ActiveSheet.Cells(8, i, 8, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(9, i, 9, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(12, i, 12, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(14, i, 14, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)

                Vs1.ActiveSheet.Cells(16, i, 16, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(17, i, 17, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(20, i, 20, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)
                Vs1.ActiveSheet.Cells(22, i, 22, Vs1.ActiveSheet.ColumnCount - 1).Font = New Font("Tahoma", 9, FontStyle.Bold)

                '''''''''''''''''''''''''''''''date title'''''''''''''''''''''''''''''''''''''''''''

                setData(Vs1, i, 0, Strings.Left(getColumName(DS1, (i - 1) / 4 * 3 + 5), 2) & "/" + Strings.Right(getColumName(DS1, (i - 1) / 4 * 3 + 5), 2))
                setData(Vs1, i, 8, Strings.Left(getColumName(DS1, (i - 1) / 4 * 3 + 5 + 18), 2) & "/" & Strings.Right(getColumName(DS1, (i - 1) / 4 * 3 + 5 + 18), 2))
                setData(Vs1, i, 16, Strings.Left(getColumName(DS1, (i - 1) / 4 * 3 + 5 + 36), 2) & "/" & Strings.Right(getColumName(DS1, (i - 1) / 4 * 3 + 5 + 36), 2))

                Vs1.ActiveSheet.Cells(0, i).ColumnSpan = 4
                Vs1.ActiveSheet.Cells(8, i).ColumnSpan = 4
                Vs1.ActiveSheet.Cells(16, i).ColumnSpan = 4

                Vs1.ActiveSheet.Cells(0, i).HorizontalAlignment = CellHorizontalAlignment.Center
                Vs1.ActiveSheet.Cells(8, i).HorizontalAlignment = CellHorizontalAlignment.Center
                Vs1.ActiveSheet.Cells(16, i).HorizontalAlignment = CellHorizontalAlignment.Center

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                ''''''''''''''''''''''''''''''''''group 1''''''''''''''''''''''''''''''''''''''''
                Dim G1Fact1_F1_1 As Decimal
                Dim G1Fact1_F1_2 As Decimal
                Dim G1Fact1_F1_3 As Decimal

                Dim G1Fact1_F2_1 As Decimal
                Dim G1Fact1_F2_2 As Decimal
                Dim G1Fact1_F2_3 As Decimal

                Dim G1Fact1_F3_1 As Decimal
                Dim G1Fact1_F3_2 As Decimal
                Dim G1Fact1_F3_3 As Decimal

                Dim G1Fact1_Cons1 As Integer = 4
                Dim G1Fact2_Cons1 As Integer = 5
                Dim G1Fact3_Cons1 As Integer = 6

                Dim G1Fact1_Row1 As Integer = 2
                Dim G1Fact3_Row1 As Integer = 3
                Dim G1FactS_Row1 As Integer = 4
                Dim G1Fact2_Row1 As Integer = 5
                Dim G1FactG_Row1 As Integer = 6

                G1Fact1_F1_1 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G1Fact1_Cons1)))
                G1Fact1_F1_2 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G1Fact2_Cons1)))
                G1Fact1_F1_3 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G1Fact3_Cons1)))

                G1Fact1_F2_1 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G1Fact1_Cons1)))
                G1Fact1_F2_2 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G1Fact2_Cons1)))
                G1Fact1_F2_3 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G1Fact3_Cons1)))

                G1Fact1_F3_1 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G1Fact1_Cons1)))
                G1Fact1_F3_2 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G1Fact2_Cons1)))
                G1Fact1_F3_3 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G1Fact3_Cons1)))

                setData(Vs1, i, G1Fact1_Row1, Format0(G1Fact1_F1_1))
                setData(Vs1, i + 1, G1Fact1_Row1, Format0(G1Fact1_F1_2))
                setData(Vs1, i + 2, G1Fact1_Row1, Format0(G1Fact1_F1_3))

                setData(Vs1, i, G1Fact3_Row1, Format0(G1Fact1_F3_1))
                setData(Vs1, i + 1, G1Fact3_Row1, Format0(G1Fact1_F3_2))
                setData(Vs1, i + 2, G1Fact3_Row1, Format0(G1Fact1_F3_3))

                setData(Vs1, i, G1FactS_Row1, Format0(G1Fact1_F1_1 + G1Fact1_F3_1))
                setData(Vs1, i + 1, G1FactS_Row1, Format0(G1Fact1_F1_2 + G1Fact1_F3_2))
                setData(Vs1, i + 2, G1FactS_Row1, Format0(G1Fact1_F1_3 + G1Fact1_F3_3))


                setData(Vs1, i, G1Fact2_Row1, Format0(G1Fact1_F2_1))
                setData(Vs1, i + 1, G1Fact2_Row1, Format0(G1Fact1_F2_2))
                setData(Vs1, i + 2, G1Fact2_Row1, Format0(G1Fact1_F2_3))


                setData(Vs1, i, G1FactG_Row1, Format0(G1Fact1_F2_1 + G1Fact1_F1_1 + G1Fact1_F3_1))
                setData(Vs1, i + 1, G1FactG_Row1, Format0(G1Fact1_F2_2 + G1Fact1_F1_2 + G1Fact1_F3_2))
                setData(Vs1, i + 2, G1FactG_Row1, Format0(G1Fact1_F2_3 + G1Fact1_F1_3 + G1Fact1_F3_3))

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                '''''''''''''''''''''''''''''''''group 2'''''''''''''''''''''''''''''''''''''''''

                Dim G2Fact1_F1_1 As Decimal
                Dim G2Fact1_F1_2 As Decimal
                Dim G2Fact1_F1_3 As Decimal

                Dim G2Fact1_F2_1 As Decimal
                Dim G2Fact1_F2_2 As Decimal
                Dim G2Fact1_F2_3 As Decimal

                Dim G2Fact1_F3_1 As Decimal
                Dim G2Fact1_F3_2 As Decimal
                Dim G2Fact1_F3_3 As Decimal

                Dim G2Fact1_Cons1 As Integer = 19
                Dim G2Fact2_Cons1 As Integer = 20
                Dim G2Fact3_Cons1 As Integer = 21

                Dim G2Fact1_Row1 As Integer = 10
                Dim G2Fact3_Row1 As Integer = 11
                Dim G2FactS_Row1 As Integer = 12
                Dim G2Fact2_Row1 As Integer = 13
                Dim G2FactG_Row1 As Integer = 14

                G2Fact1_F1_1 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G2Fact1_Cons1)))
                G2Fact1_F1_2 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G2Fact2_Cons1)))
                G2Fact1_F1_3 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G2Fact3_Cons1)))

                G2Fact1_F2_1 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G2Fact1_Cons1)))
                G2Fact1_F2_2 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G2Fact2_Cons1)))
                G2Fact1_F2_3 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G2Fact3_Cons1)))

                G2Fact1_F3_1 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G2Fact1_Cons1)))
                G2Fact1_F3_2 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G2Fact2_Cons1)))
                G2Fact1_F3_3 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G2Fact3_Cons1)))

                setData(Vs1, i, G2Fact1_Row1, Format0(G2Fact1_F1_1))
                setData(Vs1, i + 1, G2Fact1_Row1, Format0(G2Fact1_F1_2))
                setData(Vs1, i + 2, G2Fact1_Row1, Format0(G2Fact1_F1_3))

                setData(Vs1, i, G2Fact3_Row1, Format0(G2Fact1_F3_1))
                setData(Vs1, i + 1, G2Fact3_Row1, Format0(G2Fact1_F3_2))
                setData(Vs1, i + 2, G2Fact3_Row1, Format0(G2Fact1_F3_3))

                setData(Vs1, i, G2FactS_Row1, Format0(G2Fact1_F1_1 + G2Fact1_F3_1))
                setData(Vs1, i + 1, G2FactS_Row1, Format0(G2Fact1_F1_2 + G2Fact1_F3_2))
                setData(Vs1, i + 2, G2FactS_Row1, Format0(G2Fact1_F1_3 + G2Fact1_F3_3))


                setData(Vs1, i, G2Fact2_Row1, Format0(G2Fact1_F2_1))
                setData(Vs1, i + 1, G2Fact2_Row1, Format0(G2Fact1_F2_2))
                setData(Vs1, i + 2, G2Fact2_Row1, Format0(G2Fact1_F2_3))


                setData(Vs1, i, G2FactG_Row1, Format0(G2Fact1_F2_1 + G2Fact1_F1_1 + G2Fact1_F3_1))
                setData(Vs1, i + 1, G2FactG_Row1, Format0(G2Fact1_F2_2 + G2Fact1_F1_2 + G2Fact1_F3_2))
                setData(Vs1, i + 2, G2FactG_Row1, Format0(G2Fact1_F2_3 + G2Fact1_F1_3 + G2Fact1_F3_3))

                'setData(Vs1, i, 10, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 18))))
                'setData(Vs1, i + 1, 10, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 19))))
                'setData(Vs1, i + 2, 10, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 20))))

                'setData(Vs1, i, 11, Format0(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 18))))
                'setData(Vs1, i + 1, 11, Format0(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 19))))
                'setData(Vs1, i + 2, 11, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 20))))

                'setData(Vs1, i, 12, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 18)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 18))))
                'setData(Vs1, i + 1, 12, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 19)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 19))))
                'setData(Vs1, i + 2, 12, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 20)) + GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 20))))

                'setData(Vs1, i, 13, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 18))))
                'setData(Vs1, i + 1, 13, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 19))))
                'setData(Vs1, i + 2, 13, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 20))))

                'setData(Vs1, i, 14, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 18)) + GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 18)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 18))))
                'setData(Vs1, i + 1, 14, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 19)) + GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 19)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 19))))
                'setData(Vs1, i + 2, 14, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 20)) + GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 20)) + GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 20))))

                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''


                ''''''''''''''''''''''''''''''''''group 3''''''''''''''''''''''''''''''''''''''''

                Dim G3Fact1_F1_1 As Decimal
                Dim G3Fact1_F1_2 As Decimal
                Dim G3Fact1_F1_3 As Decimal

                Dim G3Fact1_F2_1 As Decimal
                Dim G3Fact1_F2_2 As Decimal
                Dim G3Fact1_F2_3 As Decimal

                Dim G3Fact1_F3_1 As Decimal
                Dim G3Fact1_F3_2 As Decimal
                Dim G3Fact1_F3_3 As Decimal

                Dim G3Fact1_Cons1 As Integer = 37
                Dim G3Fact2_Cons1 As Integer = 38
                Dim G3Fact3_Cons1 As Integer = 39

                Dim G3Fact1_Row1 As Integer = 18
                Dim G3Fact3_Row1 As Integer = 19
                Dim G3FactS_Row1 As Integer = 20
                Dim G3Fact2_Row1 As Integer = 21
                Dim G3FactG_Row1 As Integer = 22

                G3Fact1_F1_1 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G3Fact1_Cons1)))
                G3Fact1_F1_2 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G3Fact2_Cons1)))
                G3Fact1_F1_3 = CDecp(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + G3Fact3_Cons1)))

                G3Fact1_F2_1 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G3Fact1_Cons1)))
                G3Fact1_F2_2 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G3Fact2_Cons1)))
                G3Fact1_F2_3 = CDecp(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + G3Fact3_Cons1)))

                G3Fact1_F3_1 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G3Fact1_Cons1)))
                G3Fact1_F3_2 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G3Fact2_Cons1)))
                G3Fact1_F3_3 = CDecp(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + G3Fact3_Cons1)))

                setData(Vs1, i, G3Fact1_Row1, Format0(G3Fact1_F1_1))
                setData(Vs1, i + 1, G3Fact1_Row1, Format0(G3Fact1_F1_2))
                setData(Vs1, i + 2, G3Fact1_Row1, Format0(G3Fact1_F1_3))

                setData(Vs1, i, G3Fact3_Row1, Format0(G3Fact1_F3_1))
                setData(Vs1, i + 1, G3Fact3_Row1, Format0(G3Fact1_F3_2))
                setData(Vs1, i + 2, G3Fact3_Row1, Format0(G3Fact1_F3_3))

                setData(Vs1, i, G3FactS_Row1, Format0(G3Fact1_F1_1 + G3Fact1_F3_1))
                setData(Vs1, i + 1, G3FactS_Row1, Format0(G3Fact1_F1_2 + G3Fact1_F3_2))
                setData(Vs1, i + 2, G3FactS_Row1, Format0(G3Fact1_F1_3 + G3Fact1_F3_3))


                setData(Vs1, i, G3Fact2_Row1, Format0(G3Fact1_F2_1))
                setData(Vs1, i + 1, G3Fact2_Row1, Format0(G3Fact1_F2_2))
                setData(Vs1, i + 2, G3Fact2_Row1, Format0(G3Fact1_F2_3))


                setData(Vs1, i, G3FactG_Row1, Format0(G3Fact1_F2_1 + G3Fact1_F1_1 + G3Fact1_F3_1))
                setData(Vs1, i + 1, G3FactG_Row1, Format0(G3Fact1_F2_2 + G3Fact1_F1_2 + G3Fact1_F3_2))
                setData(Vs1, i + 2, G3FactG_Row1, Format0(G3Fact1_F2_3 + G3Fact1_F1_3 + G3Fact1_F3_3))

                'setData(Vs1, i, 18, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 36))))
                'setData(Vs1, i + 1, 18, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 37))))
                'setData(Vs1, i + 2, 18, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 38))))

                'setData(Vs1, i, 19, Format0(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 36))))
                'setData(Vs1, i + 1, 19, Format0(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 37))))
                'setData(Vs1, i + 2, 19, Format0(GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 38))))

                'setData(Vs1, i, 20, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 36)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 36))))
                'setData(Vs1, i + 1, 20, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 37)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 37))))
                'setData(Vs1, i + 2, 20, Format0(GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 38)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 38))))

                'setData(Vs1, i, 21, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 36))))
                'setData(Vs1, i + 1, 21, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 37))))
                'setData(Vs1, i + 2, 21, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 38))))

                'setData(Vs1, i, 20, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 36)) + GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 36)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 36))))
                'setData(Vs1, i + 1, 20, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 37)) + GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 37)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 37))))
                'setData(Vs1, i + 2, 20, Format0(GetDsData(DS1, 1, CIntp((i - 1) / 4 * 3 + 4 + 38)) + GetDsData(DS1, 0, CIntp((i - 1) / 4 * 3 + 4 + 38)) + GetDsData(DS1, 2, CIntp((i - 1) / 4 * 3 + 4 + 38))))
                ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            Next

        End If



        If Vs1.ActiveSheet.Tag = "1" Then VsSizeRangeNew_Many(Vs1, "USP_PFPSIZERANGE_MULTI", getColumIndex(Vs1, "SizeQty01") - 1, txt_CustomerCode.Code)

        If Vs1.ActiveSheet.SheetName = "LOAD PLAN" Then
            Dim SCol As Integer = getColumIndex(Vs1, "QtyTarget") + 1

            For i = SCol To Vs1.ActiveSheet.ColumnCount - 1 Step 2
                setDataCH(Vs1, i, 0, getDataCH(Vs1, i, 0) & "/" & Strings.Mid(txt_DateReport.Data, 5, 2))

                Vs1.ActiveSheet.ColumnHeader.Cells(1, i).RowSpan = 1
                Vs1.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 1

                Vs1.ActiveSheet.ColumnHeader.Cells(1, i + 1).RowSpan = 1
                Vs1.ActiveSheet.ColumnHeader.Cells(0, i + 1).RowSpan = 1

                Vs1.ActiveSheet.ColumnHeader.Cells(0, i).ColumnSpan = 2

                Vs1.ActiveSheet.ColumnHeader.Cells(1, i).Value = "Prod"
                Vs1.ActiveSheet.ColumnHeader.Cells(1, i + 1).Value = "%"

                If (i Mod 7) = 0 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightYellow
                If (i Mod 7) = 1 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.PaleGreen
                If (i Mod 7) = 2 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightBlue
                If (i Mod 7) = 3 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightGreen
                If (i Mod 7) = 4 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.Orange
                If (i Mod 7) = 5 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.Aquamarine
                If (i Mod 7) = 6 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightGray

                Vs1.ActiveSheet.ColumnHeader.Cells(0, i).ForeColor = Color.Black
            Next

        End If

        Vs1.Enabled = True
        DATA_SEARCH_VS1 = True


    End Function

    Private Sub DATA_SEARC_VS1_ALL()
        Dim i As Integer

        Try
            Vs1.Enabled = False


            Dim ProcName As String

            For IntAs As Integer = 0 To Vs1.Sheets.Count - 1
                Vs1.ActiveSheetIndex = IntAs

                ProcName = "USP_PFP85000_SEARCH_VS1_" & Vs1.ActiveSheetIndex.ToString("00")

                DS1 = PrcDS(ProcName, cn, txt_DateReport.Data, txt_cdSeason.Code, txt_CustomerCode.Code)

                If GetDsRc(DS1) = 0 Then
                    Vs1.Enabled = True
                    SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))
                    Exit Sub
                End If

                SPR_PRO_NEW(Vs1, DS1, ProcName, "Vs1" & Vs1.ActiveSheetIndex.ToString("00"))

                If Vs1.ActiveSheet.Tag = "1" Then VsSizeRangeNew_Many(Vs1, "USP_PFPSIZERANGE_MULTI", getColumIndex(Vs1, "SizeQty01") - 1, txt_CustomerCode.Code)

                If Vs1.ActiveSheet.SheetName = "LOAD PLAN" Then
                    Dim SCol As Integer = getColumIndex(Vs1, "QtyTarget") + 1

                    For i = SCol To Vs1.ActiveSheet.ColumnCount - 1 Step 2
                        setDataCH(Vs1, i, 0, getDataCH(Vs1, i, 0) & "/" & Strings.Mid(txt_DateReport.Data, 5, 2))

                        Vs1.ActiveSheet.ColumnHeader.Cells(1, i).RowSpan = 1
                        Vs1.ActiveSheet.ColumnHeader.Cells(0, i).RowSpan = 1

                        Vs1.ActiveSheet.ColumnHeader.Cells(1, i + 1).RowSpan = 1
                        Vs1.ActiveSheet.ColumnHeader.Cells(0, i + 1).RowSpan = 1

                        Vs1.ActiveSheet.ColumnHeader.Cells(0, i).ColumnSpan = 2

                        Vs1.ActiveSheet.ColumnHeader.Cells(1, i).Value = "Prod"
                        Vs1.ActiveSheet.ColumnHeader.Cells(1, i + 1).Value = "%"

                        If (i Mod 7) = 0 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightYellow
                        If (i Mod 7) = 1 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.PaleGreen
                        If (i Mod 7) = 2 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightBlue
                        If (i Mod 7) = 3 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightGreen
                        If (i Mod 7) = 4 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.Orange
                        If (i Mod 7) = 5 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.Aquamarine
                        If (i Mod 7) = 6 Then Vs1.ActiveSheet.ColumnHeader.Cells(0, i).BackColor = Color.LightGray

                        Vs1.ActiveSheet.ColumnHeader.Cells(0, i).ForeColor = Color.Black
                    Next

                End If

            Next

            Vs1.Enabled = True

        Catch ex As Exception

        End Try
    End Sub






    Private Sub Vs1_ActiveSheetChanged(sender As Object, e As EventArgs) Handles Vs1.ActiveSheetChanged
        Exit Sub

        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try

            Call DATA_SEARCH_VS1()

        Catch ex As Exception

        Finally
            Starting.close()
        End Try
    End Sub




    Private Sub Vs1_SheetTabDoubleClick(sender As Object, e As SheetTabDoubleClickEventArgs) Handles Vs1.SheetTabDoubleClick
        Dim Starting = New DevExpress.Utils.WaitDialogForm("Loading data...", "PSM")

        Try

            If chk_All.Checked = False Then Call DATA_SEARCH_VS1()
            If chk_All.Checked = True Then Call DATA_SEARC_VS1_ALL()

        Catch ex As Exception

        Finally
            Starting.close()
        End Try

    End Sub

#End Region

#Region "EVENT"

    'GOTFOCUS
    Private Sub vS1_GotFocus(sender As Object, e As EventArgs) Handles Vs1.GotFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, True, True, True, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    'LOSTFOCUS
    Private Sub vS1_LostFocus(sender As Object, e As EventArgs) Handles Vs1.LostFocus
        Call TOOLBAR_CHECKSHOW(ToolStrip1, True, False, False, False, False, False, WordConv("INSERT") & "(F5)")
    End Sub

    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click
        If chk_All.Checked = False Then Call DATA_SEARCH_VS1()
        If chk_All.Checked = True Then Call DATA_SEARC_VS1_ALL()

    End Sub

#End Region



End Class