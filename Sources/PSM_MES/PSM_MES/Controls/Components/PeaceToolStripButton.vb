Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.IO
Imports FarPoint.Win.Spread
Public Class PeaceToolStripButton
    Inherits ToolStripButton
    Protected prg As E_PRG
    Private Sub ClickButton(sender As Object, e As EventArgs) Handles Me.Click
        Try
            Dim i As Integer
            Dim child As List(Of System.Windows.Forms.Control)
            Dim filelocation As String = ""
            Dim pi As FarPoint.Win.Spread.PrintInfo = New FarPoint.Win.Spread.PrintInfo()

            If Me.Name = "ptsb_Manual" Then
                Dim frm As Form
                frm = CType(Me.Parent.Parent.Parent, Form)

                If ISUD7555A.Link_ISUD7555A_MANUAL(11, frm.Name) = False Then Exit Sub

            End If

            If Me.Name = "ptsb_Excel" Then
                Dim b As Object
                Dim frm As Form
                frm = CType(Me.Parent.Parent.Parent, Form)
                Dim a As New SaveFileDialog
                a.FileName = frm.Name
                a.Filter = "Excel Files|*.xls"
                a.DefaultExt = "xls"
                If a.ShowDialog = DialogResult.OK Then
                    filelocation = a.FileName
                    child = frm.FindAllChildren()
                    For i = 0 To child.Count - 1
                        If TypeOf child(i) Is FarPoint.Win.Spread.FpSpread Then
                            b = CType(child(i), FarPoint.Win.Spread.FpSpread)
                            If child(i).Focused = True Then
                                b.ActiveSheet.Protect = False
                                If My.Computer.FileSystem.DirectoryExists(App_Path & "\Temp") = False Then
                                    System.IO.Directory.CreateDirectory(App_Path & "\Temp")
                                End If

                                Dim sv_1 As New SheetView
                                Dim int_CH As Integer
                                Dim Int_Col As Integer

                                int_CH = b.ActiveSheet.ColumnHeader.RowCount

                                sv_1 = Clone_SV(b.ActiveSheet)
                                sv_1.Rows.Add(0, 4 + int_CH)
                                sv_1.Protect = False

                                Int_Col = sv_1.ColumnCount - 1
                                While Int_Col >= 0
                                    If sv_1.Columns(Int_Col).Visible = False Or sv_1.Columns(Int_Col).Width < 10 Then
                                        sv_1.Columns(Int_Col).Remove()
                                        Int_Col = Int_Col - 1
                                    Else
                                        Int_Col = Int_Col - 1
                                    End If
                                End While


                                sv_1.Cells(4, 0, 4 + int_CH - 1, sv_1.ColumnCount - 1).BackColor = Color.Gray
                                sv_1.Cells(4, 0, 4 + int_CH - 1, sv_1.ColumnCount - 1).VerticalAlignment = CellVerticalAlignment.Center
                                sv_1.Cells(4, 0, 4 + int_CH - 1, sv_1.ColumnCount - 1).HorizontalAlignment = CellHorizontalAlignment.Center


                                For Int_Col = 4 To 4 + int_CH
                                    sv_1.Rows(Int_Col).BackColor = Color.Empty
                                Next

                                If Split(b.Tag.ToString, ";").Length = 2 Then
                                    If READ_PFK9914("dms", Split(b.Tag.ToString, ";")(0), Split(b.Tag.ToString, ";")(1)) Then
                                        If D9914.Header = "1" Then sv_1.Cells(4 + int_CH, 0, 4 + int_CH, sv_1.ColumnCount - 1).BackColor = Color.Yellow
                                    End If
                                End If


                                Dim Int_Col2 As Integer
                                Dim Int_List As New List(Of Integer)
                                Dim str_List(sv_1.ColumnHeader.RowCount - 1) As List(Of String)

                                For Int_Col2 = 0 To int_CH - 1
                                    str_List(Int_Col2) = New List(Of String)
                                    str_List(Int_Col2).Clear()
                                Next

                                For Int_Col = 0 To sv_1.ColumnCount - 1
                                    Int_List.Add(Int_Col)

                                    For Int_Col2 = 0 To int_CH - 1
                                        str_List(Int_Col2).Add(sv_1.ColumnHeader.Cells(0 + Int_Col2, Int_Col).Value)

                                        sv_1.Cells(4 + Int_Col2, Int_Col).ColumnSpan = sv_1.ColumnHeader.Cells(0 + Int_Col2, Int_Col).ColumnSpan
                                        sv_1.Cells(4 + Int_Col2, Int_Col).RowSpan = sv_1.ColumnHeader.Cells(0 + Int_Col2, Int_Col).RowSpan

                                        sv_1.Cells(4 + Int_Col2, Int_Col).VerticalAlignment = CellVerticalAlignment.Center
                                        sv_1.Cells(4 + Int_Col2, Int_Col).HorizontalAlignment = CellHorizontalAlignment.Center
                                        sv_1.Cells(4 + Int_Col2, Int_Col).Font = New Font("Tahoma", 8, FontStyle.Bold)
                                    Next

                                Next

                           

                                Dim bottomborder As New FarPoint.Win.ComplexBorderSide(True, Color.Gray, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, Nothing) ' New Single() {0.1, 0.1, 0.1, 0.1, 0.1, 0.1})
                                sv_1.Cells(4, 0, sv_1.RowCount - 1, sv_1.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(bottomborder, bottomborder, bottomborder, bottomborder)

                                Dim bottomborder2 As New FarPoint.Win.ComplexBorderSide(True, Color.Black, 1, System.Drawing.Drawing2D.DashStyle.Solid, Nothing, Nothing) ' New Single() {0.1, 0.1, 0.1, 0.1, 0.1, 0.1})
                                sv_1.Cells(4, 0, 4 + int_CH, sv_1.ColumnCount - 1).Border = New FarPoint.Win.ComplexBorder(bottomborder2, bottomborder2, bottomborder2, bottomborder2)

                                sv_1.Cells(3, 0).Value = b.FindForm.Text
                                sv_1.Cells(3, 0).ColumnSpan = sv_1.ColumnCount

                                sv_1.Cells(0, 0).VerticalAlignment = CellVerticalAlignment.Center
                                sv_1.Cells(0, 0).HorizontalAlignment = CellHorizontalAlignment.Left
                                sv_1.Cells(1, 0).VerticalAlignment = CellVerticalAlignment.Center
                                sv_1.Cells(1, 0).HorizontalAlignment = CellHorizontalAlignment.Left
                                sv_1.Cells(2, 0).VerticalAlignment = CellVerticalAlignment.Center
                                sv_1.Cells(2, 0).HorizontalAlignment = CellHorizontalAlignment.Left
                                sv_1.Cells(3, 0).VerticalAlignment = CellVerticalAlignment.Center
                                sv_1.Cells(3, 0).HorizontalAlignment = CellHorizontalAlignment.Left

                                sv_1.Cells(3, 0).Font = New Font("Tahoma", 16, FontStyle.Bold)

                                Dim fpSpread1 As New FarPoint.Win.Spread.FpSpread()
                                fpSpread1.Sheets.Add(sv_1)
                                fpSpread1.Font = New Font("Tahoma", 8)

                                fpSpread1.ActiveSheet.FrozenColumnCount = 0
                                fpSpread1.ActiveSheet.FrozenRowCount = 0

                                fpSpread1.SaveExcel(filelocation, FarPoint.Excel.ExcelSaveFlags.NoFlagsSet Or FarPoint.Excel.ExcelSaveFlags.NoFormulas Or FarPoint.Excel.ExcelSaveFlags.NoNotes)
                                Call ChangeTitle(b, filelocation, Int_List, str_List)


                                Exit Sub
                            End If
                        End If
                    Next
                End If
                Exit Sub


            ElseIf Me.Name = "ptsb_Help" Then
                Dim b As FarPoint.Win.Spread.FpSpread
                Dim frm As Form
                frm = CType(Me.Parent.Parent.Parent, Form)

                child = frm.FindAllChildren()

                For i = 0 To child.Count - 1
                    If TypeOf child(i) Is FarPoint.Win.Spread.FpSpread Then
                        If child(i).Focused = True Then
                            b = CType(child(i), FarPoint.Win.Spread.FpSpread)

                            If b.DataSource Is Nothing Then Exit Sub

                            P_PIVOT.Link_Pivot(b.DataSource)

                            Exit Sub
                        End If
                    End If
                Next



            End If



        Catch ex As Exception

        End Try
    End Sub
End Class
