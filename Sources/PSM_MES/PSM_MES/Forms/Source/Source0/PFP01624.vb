Public Class PFP01624

#Region "Variable"
    Private Dsu01 As Long
    Private wGCODE As String
    Private Form_Close As Boolean
#End Region

#Region "Form_load"
    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Call TOOLBAR_CHECKSHOW(ToolStrip1, False, False, False, False, False, False)

        Me.KeyPreview = True

        Call FORM_INIT()
        Call DATA_INIT()

    End Sub
    Private Sub PFP01624_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Call INTERRUPT_TOGGLE(e.KeyCode)
        Call Function_Event(e.KeyValue)
    End Sub
    Overrides Sub Function_Event(PressKey As Integer)
        Try
            Select Case PressKey

            End Select
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FORM_INIT()

    End Sub

    Private Sub DATA_INIT()

        txt_cdMainProcess.Code = "050"

        If READ_PFK7171(ListCode("MainProcess"), txt_cdMainProcess.Code) Then
            txt_cdMainProcess.Data = D7171.BasicName
        End If

        txt_cdMainProcess.Enabled = Not True
        SdateEdate.text1 = Mid(System_Date_8, 1, 6) & "01"
        SdateEdate.text2 = System_Date_8()
    End Sub
#End Region

#Region "Function"

#End Region

#Region "Data_search"
    Private Function DATA_SEARCH_VS10(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS10 = False

        Dim xSdate As String
        Dim xEdate As String

        Vs10.Enabled = False
        Try
            xSdate = Mid(SdateEdate.text1, 1, 4) & "0101"
            xEdate = SdateEdate.text2

            DS1 = PrcDS("USP_PFP01624_SEARCH_VS10_PIVOT", cn, xSdate, xEdate, txt_cdFactory.Code, txt_cdMainProcess.Code, "", "")

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(Vs10, DS1, "USP_PFP01624_SEARCH_VS10_PIVOT", "vS10")
                Vs10.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(Vs10, DS1, "USP_PFP01624_SEARCH_VS10_PIVOT", "vS10")

            DATA_SEARCH_VS10 = True

            Vs10.Enabled = True

        Catch ex As Exception

        End Try

    End Function

   

    Private Function DATA_SEARCH_VS20(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS20 = False

        Dim i As Integer
        Dim x1 As Double
        Dim x2 As Double

        Dim xSdate As String
        Dim xEdate As String

        Dim s1, s2 As Double

        vS20.Enabled = False
        Try

            xSdate = Mid(SdateEdate.text1, 1, 4) & "0101"
            xEdate = SdateEdate.text2

            DS1 = PrcDS("USP_PFP01624_SEARCH_VS20_PIVOT", cn, xSdate, xEdate, txt_cdFactory.Code, txt_cdMainProcess.Code, "", "")

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS20, DS1, "USP_PFP01624_SEARCH_VS20_PIVOT", "VS20")
                vS20.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS20, DS1, "USP_PFP01624_SEARCH_VS20_PIVOT", "VS20")

            x1 = getData(vS20, getColumIndex(vS20, "WeenKend"), 1)
            x2 = getData(vS20, getColumIndex(vS20, "WeenKend"), 1)

            For i = 1 To vS20.ActiveSheet.RowCount - 1

                If CDbl(getData(vS20, getColumIndex(vS20, "QtyTargetDay"), i)) > 0 Then
                    x1 = getData(vS20, getColumIndex(vS20, "WeenKend"), i)

                    If x1 <> x2 Then
                        If CDbl(getData(vS20, getColumIndex(vS20, "QtyTargetDay"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "QtyProductDay"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "QtyProductDay"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "QtyTargetDay"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "PerProductDay"), i, s2)
                        End If


                        If CDbl(getData(vS20, getColumIndex(vS20, "D01_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D01_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D01_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D01_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D01_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D02_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D02_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D02_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D02_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D02_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D03_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D03_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D03_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D03_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D03_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D04_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D04_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D04_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D04_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D04_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D05_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D05_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D05_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D05_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D05_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D06_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D06_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D06_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D06_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D06_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D07_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D07_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D07_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D07_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D07_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D08_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D08_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D08_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D08_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D08_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D09_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D09_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D09_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D09_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D09_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D10_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D10_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D10_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D10_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D10_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D11_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D11_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D11_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D11_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D11_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D12_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D12_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D12_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D12_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D12_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D13_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D13_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D13_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D13_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D13_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D14_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D14_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D14_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D14_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D14_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D15_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D15_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D15_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D15_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D15_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D16_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D16_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D16_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D16_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D16_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D17_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D17_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D17_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D17_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D17_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D18_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D18_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D18_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D18_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D18_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D19_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D19_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D19_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D19_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D19_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D20_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D20_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D20_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D20_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D20_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D21_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D21_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D21_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D21_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D21_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D22_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D22_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D22_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D22_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D22_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D23_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D23_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D23_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D23_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D23_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D24_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D24_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D24_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D24_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D24_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D25_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D25_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D25_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D25_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D25_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D26_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D26_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D26_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D26_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D26_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D27_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D27_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D27_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D27_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D27_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D28_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D28_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D28_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D28_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D28_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D29_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D29_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D29_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D29_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D29_C"), i, s2)
                        End If

                        If CDbl(getData(vS20, getColumIndex(vS20, "D30_T"), i)) > 0 And CDbl(getData(vS20, getColumIndex(vS20, "D30_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS20, getColumIndex(vS20, "D30_P"), i)) / CDbl(getData(vS20, getColumIndex(vS20, "D30_T"), i)) * 100
                            Call setData(vS20, getColumIndex(vS20, "D30_C"), i, s2)
                        End If

                        i = i + 1
                        x1 = getData(vS20, getColumIndex(vS20, "WeenKend"), i)
                    End If

                    x2 = getData(vS20, getColumIndex(vS20, "WeenKend"), i)
                End If
            Next


            DATA_SEARCH_VS20 = True

            vS20.Enabled = True

        Catch ex As Exception

        End Try

    End Function

    Private Function DATA_SEARCH_VS30(Optional ByVal xsort As String = "1") As Boolean
        DATA_SEARCH_VS30 = False
        Dim i As Integer
        Dim x1 As Double
        Dim x2 As Double

        Dim s1, s2 As Double

        vS30.Enabled = False
        Try
            DS1 = PrcDS("USP_PFP01624_SEARCH_VS30_PIVOT", cn, SdateEdate.text1, SdateEdate.text2, txt_cdFactory.Code, txt_cdMainProcess.Code, "", "")

            If GetDsRc(DS1) = 0 Then
                SPR_PRO_NEW(vS30, DS1, "USP_PFP01624_SEARCH_VS30_PIVOT", "VS30")
                vS30.Enabled = True
                Exit Function
            End If

            SPR_PRO_NEW(vS30, DS1, "USP_PFP01624_SEARCH_VS30_PIVOT", "VS30")

            x1 = getData(vS30, getColumIndex(vS30, "WeenKend"), 1)
            x2 = getData(vS30, getColumIndex(vS30, "WeenKend"), 1)

            For i = 1 To vS30.ActiveSheet.RowCount - 1

                If CDbl(getData(vS30, getColumIndex(vS30, "QtyTargetDay"), i)) > 0 Then
                    x1 = getData(vS30, getColumIndex(vS30, "WeenKend"), i)

                    If x1 <> x2 Then
                        If CDbl(getData(vS30, getColumIndex(vS30, "QtyTargetDay"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "QtyProductDay"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "QtyProductDay"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "QtyTargetDay"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "PerProductDay"), i, s2)
                        End If


                        If CDbl(getData(vS30, getColumIndex(vS30, "D01_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D01_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D01_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D01_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D01_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D02_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D02_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D02_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D02_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D02_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D03_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D03_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D03_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D03_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D03_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D04_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D04_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D04_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D04_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D04_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D05_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D05_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D05_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D05_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D05_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D06_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D06_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D06_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D06_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D06_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D07_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D07_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D07_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D07_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D07_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D08_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D08_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D08_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D08_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D08_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D09_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D09_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D09_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D09_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D09_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D10_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D10_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D10_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D10_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D10_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D11_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D11_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D11_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D11_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D11_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D12_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D12_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D12_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D12_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D12_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D13_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D13_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D13_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D13_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D13_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D14_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D14_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D14_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D14_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D14_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D15_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D15_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D15_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D15_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D15_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D16_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D16_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D16_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D16_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D16_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D17_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D17_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D17_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D17_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D17_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D18_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D18_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D18_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D18_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D18_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D19_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D19_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D19_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D19_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D19_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D20_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D20_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D20_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D20_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D20_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D21_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D21_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D21_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D21_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D21_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D22_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D22_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D22_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D22_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D22_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D23_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D23_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D23_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D23_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D23_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D24_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D24_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D24_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D24_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D24_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D25_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D25_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D25_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D25_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D25_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D26_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D26_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D26_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D26_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D26_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D27_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D27_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D27_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D27_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D27_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D28_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D28_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D28_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D28_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D28_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D29_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D29_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D29_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D29_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D29_C"), i, s2)
                        End If

                        If CDbl(getData(vS30, getColumIndex(vS30, "D30_T"), i)) > 0 And CDbl(getData(vS30, getColumIndex(vS30, "D30_P"), i)) > 0 Then
                            s2 = CDbl(getData(vS30, getColumIndex(vS30, "D30_P"), i)) / CDbl(getData(vS30, getColumIndex(vS30, "D30_T"), i)) * 100
                            Call setData(vS30, getColumIndex(vS30, "D30_C"), i, s2)
                        End If

                        i = i + 1
                        x1 = getData(vS30, getColumIndex(vS30, "WeenKend"), i)
                    End If

                    x2 = getData(vS30, getColumIndex(vS30, "WeenKend"), i)
                End If
            Next


            DATA_SEARCH_VS30 = True

            vS30.Enabled = True

        Catch ex As Exception

        End Try

    End Function



    Private Function LINE_MOVE_DISPLAY01() As Boolean
        LINE_MOVE_DISPLAY01 = False

    End Function
    Private Function CustomerPurchasing_CHK() As String
        CustomerPurchasing_CHK = "1"
        Return CustomerPurchasing_CHK
    End Function

#End Region

#Region "Event"


    Private Sub ptc_Main_DoubleClick(sender As Object, e As EventArgs) Handles ptc_1.DoubleClick
        If ptc_1.SelectedIndex = -1 Then Exit Sub

        Select Case ptc_1.SelectedIndex
            Case 0 : Call DATA_SEARCH_VS10()
            Case 1 : Call DATA_SEARCH_VS20()
            Case 2 : Call DATA_SEARCH_VS30()
        End Select

    End Sub


    Private Sub cmd_SEARCH_Click(sender As Object, e As EventArgs) Handles cmd_SEARCH.Click

        If ptc_1.SelectedIndex = 0 Then Call DATA_SEARCH_VS10()
        If ptc_1.SelectedIndex = 1 Then Call DATA_SEARCH_VS20()
        If ptc_1.SelectedIndex = 2 Then Call DATA_SEARCH_VS30()
    End Sub

    Private Sub PFP01624_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If ptc_1.TabCount < 1 Then Exit Sub
        If Me.Width > 30 Then
            ptc_1.ItemSize = New Size((Me.Width - 30) / ptc_1.TabCount, 25)
        End If
    End Sub

#End Region

End Class