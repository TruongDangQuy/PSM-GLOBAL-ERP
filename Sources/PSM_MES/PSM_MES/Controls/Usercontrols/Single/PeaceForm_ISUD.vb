Public Class PeaceForm_ISUD
    Private Sub tst_iPrint_Print_Click(sender As Object, e As EventArgs) Handles tst_iPrint_Print.Click
        Try
            Dim f As New Form
            f = Me.FindForm

            Pub.CLI = "1"

            If READ_FROM_MULTI(f.Tag) Then Pub.CLI = "2"

            If Pub.CLI = "1" Then
                If Not f.Tag Is Nothing Then
                    If READ_SHEETPRINT_MATCHING(f.Tag) = True Then
                        If SheetReport.Link_SheetReport(3, f.Tag, f) = True Then

                            If READ_SHEETPRINT_MATCHING_MULTI(f.Tag, SheetReportName) = True Then
                                ChuoiValue1 = ""
                                ChuoiValue2 = ""

                                If PRINTSHEET_MULTI.Link_PrintSheet(SheetReportName, ChuoiValue1, ChuoiValue2, f) = True Then
                                End If
                            Else
                                ChuoiValue1 = ""
                                ChuoiValue2 = ""

                                If GETCHUOI1(ChuoiValue1, SheetReportName) = False Then Exit Sub

                                If GETCHUOI2_01(f, ChuoiValue2, SheetReportName, ChuoiValue1) = False Then Exit Sub

                                If PRINTSHEET.Link_PrintSheet2019(SheetReportName, f.Name, getPrimaryKey(Me), ChuoiValue1, ChuoiValue2) = True Then

                                End If
                            End If
                        End If
                    Else

                    End If
                Else

                End If

            ElseIf Pub.CLI = "2" Then
                If PRINTSHEET_NEW_F1.Link_SheetReport(3, f.Tag, f) = True Then

                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub PeaceForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Exit Sub
        Try
            If Me.Name.Contains("ISUD") Then
                Select Case e.KeyCode
                    Case Keys.F1
                        If tst_iNew.Visible = True And tst_iNew.Enabled = True Then tst_iNew.PerformClick()
                        If isudCHK = True Then
                            Select Case wJOB
                                Case 1, 3
                                    MsgBoxP("Save Sucessfully!", vbInformation)

                                Case 4
                                    MsgBoxP("Delete Sucessfully!", vbInformation)

                            End Select
                        End If

                    Case Keys.F2
                        If tst_iSave.Visible = True And tst_iSave.Enabled = True Then tst_iSave.PerformClick()
                        If isudCHK = True Then
                            Select Case wJOB
                                Case 1, 3
                                    MsgBoxP("Save Sucessfully!", vbInformation)

                                Case 4
                                    MsgBoxP("Delete Sucessfully!", vbInformation)

                            End Select
                        End If

                    Case Keys.F3
                        If tst_iDelete.Visible = True And tst_iDelete.Enabled = True Then tst_iDelete.PerformClick()
                        If isudCHK = True Then
                            Select Case wJOB
                                Case 1, 3
                                    MsgBoxP("Save Sucessfully!", vbInformation)

                                Case 4
                                    MsgBoxP("Delete Sucessfully!", vbInformation)

                            End Select
                        End If

                    Case Keys.F4
                        If tst_iClose.Visible = True And tst_iClose.Enabled = True Then tst_iClose.PerformClick()
                    Case Keys.F5
                        If tst_iPrint.Visible = True And tst_iPrint_Print.Enabled = True Then tst_iPrint_Print.PerformClick()

                    Case Keys.F6
                        If tst_iUtilities.Visible = True And tst_iAttach.Enabled = True Then tst_iAttach.PerformClick()

                End Select


            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub tst_iAttach_Click(sender As Object, e As EventArgs) Handles tst_iAttach.Click
        Try
            Dim f As PeaceForm
            f = CType(Me.FindForm, PeaceForm)

            If f.chk_Attach = False Then Exit Sub
            If ISUD7555A.Link_ISUD7555A(3, Me.FindForm.Name, getPrimaryKey(Me.FindForm)) = False Then Exit Sub

        Catch ex As Exception

        End Try
    End Sub


    Private Sub tst_iSave_Click(sender As Object, e As EventArgs) Handles tst_iSave.Click
        Try
            Call System_Date_time()

            DS1 = PrcDS("EXP_CLOSSING_TABLE", cn, Me.FindForm.Name)
            If GetDsRc(DS1) > 0 Then
                Dim i As Integer
                Dim Arr_String As New List(Of String)

                For i = 0 To GetDsRc(DS1) - 1
                    Arr_String.Add(Me.FindForm.FindCodeExactily(DS1.Tables(0).Rows(i).Item(1)).Data)
                Next

                Call PrcExeNoError(GetDsData(DS1, 0, 0), cn, Arr_String.ToArray)

            End If

        Catch ex As Exception

        End Try
    End Sub
End Class
