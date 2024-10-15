Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Imports Microsoft.Office.Interop

Public Class PeaceToolStrip
    Inherits System.Windows.Forms.ToolStrip

    Public Sub New()
        MyBase.New()
        InitializeComponent()

        Dim NewTst_1 As PSMGlobal.PeaceToolStripButton
        NewTst_1 = New PSMGlobal.PeaceToolStripButton

        NewTst_1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        NewTst_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        NewTst_1.Image = Global.PSMGlobal.My.Resources.Resources.Attachment_16x16
        NewTst_1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        NewTst_1.ImageTransparentColor = System.Drawing.Color.Magenta
        NewTst_1.Name = "ptsb_Attach"
        NewTst_1.Size = New System.Drawing.Size(28, 27)
        NewTst_1.Text = "Attach"
        AddHandler NewTst_1.Click, AddressOf ToolStrip_Click

        'Dim NewTst_2 As PSMGlobal.PeaceToolStripButton
        'NewTst_2 = New PSMGlobal.PeaceToolStripButton

        'NewTst_2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        'NewTst_2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        'NewTst_2.Image = Global.PSMGlobal.My.Resources.Resources.AssignTo_16x16
        'NewTst_2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        'NewTst_2.ImageTransparentColor = System.Drawing.Color.Magenta
        'NewTst_2.Name = "ptsb_Ctc"
        'NewTst_2.Size = New System.Drawing.Size(28, 27)
        'NewTst_2.Text = "Ctc"

        'AddHandler NewTst_2.Click, AddressOf ToolStrip_Click


        Dim NewTst_3 As PSMGlobal.PeaceToolStripButton
        NewTst_3 = New PSMGlobal.PeaceToolStripButton

        NewTst_3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        NewTst_3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        NewTst_3.Image = Global.PSMGlobal.My.Resources.Resources.UserGroup_16x16
        NewTst_3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        NewTst_3.ImageTransparentColor = System.Drawing.Color.Magenta
        NewTst_3.Name = "ptsb_FormUser"
        NewTst_3.Size = New System.Drawing.Size(28, 27)
        NewTst_3.Text = "Option Sheet"

        AddHandler NewTst_3.Click, AddressOf ToolStrip_Click

        Dim NewTst_4 As PSMGlobal.PeaceToolStripButton
        NewTst_4 = New PSMGlobal.PeaceToolStripButton

        NewTst_4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        NewTst_4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        NewTst_4.Image = Global.PSMGlobal.My.Resources.Resources.Print_16x16
        NewTst_4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        NewTst_4.ImageTransparentColor = System.Drawing.Color.Magenta
        NewTst_4.Name = "ptsb_PrintSheet"
        NewTst_4.Size = New System.Drawing.Size(28, 27)
        NewTst_4.Text = "Print Sheet"

        AddHandler NewTst_4.Click, AddressOf ToolStrip_Click

        Dim NewTst_5 As PSMGlobal.PeaceToolStripButton
        NewTst_5 = New PSMGlobal.PeaceToolStripButton

        NewTst_5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        NewTst_5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        NewTst_5.Image = Global.PSMGlobal.My.Resources.Resources.Close_16x16
        NewTst_5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        NewTst_5.ImageTransparentColor = System.Drawing.Color.Magenta
        NewTst_5.Name = "ptsb_Close"
        NewTst_5.Size = New System.Drawing.Size(28, 27)
        NewTst_5.Text = "Close"

        AddHandler NewTst_5.Click, AddressOf ToolStrip_Click



        Dim NewTst_6 As PSMGlobal.PeaceToolStripButton
        NewTst_6 = New PSMGlobal.PeaceToolStripButton

        NewTst_6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        NewTst_6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        NewTst_6.Image = Global.PSMGlobal.My.Resources.Resources.Mail_16x16
        NewTst_6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        NewTst_6.ImageTransparentColor = System.Drawing.Color.Magenta
        NewTst_6.Name = "ptsb_Mail"
        NewTst_6.Size = New System.Drawing.Size(28, 27)
        NewTst_6.Text = "Mail"

        AddHandler NewTst_6.Click, AddressOf ToolStrip_Click

        'Dim NewTst_6 As ToolStripTextBox
        'NewTst_6 = New ToolStripTextBox

        'NewTst_6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        'NewTst_6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        'NewTst_6.Image = Global.PSMGlobal.My.Resources.Resources.Time_16x16
        'NewTst_6.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        'NewTst_6.ImageTransparentColor = System.Drawing.Color.Magenta
        'NewTst_6.Name = "ptsb_Timer"
        'NewTst_6.Size = New System.Drawing.Size(28, 27)
        'NewTst_6.Text = "10"

        'Dim NewTst_7 As ToolStripTextBox
        'NewTst_7 = New ToolStripTextBox

        'NewTst_7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        'NewTst_7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        'NewTst_7.Image = Global.PSMGlobal.My.Resources.Resources.Time_16x16
        'NewTst_7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        'NewTst_7.ImageTransparentColor = System.Drawing.Color.Magenta
        'NewTst_7.Name = "ptsb_Again"
        'NewTst_7.Size = New System.Drawing.Size(28, 27)
        'NewTst_7.Text = "10"

        'Dim NewTst_8 As ToolStripComboBox
        'NewTst_8 = New ToolStripComboBox

        'NewTst_8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        'NewTst_8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        'NewTst_8.Image = Global.PSMGlobal.My.Resources.Resources.Time_16x16
        'NewTst_8.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        'NewTst_8.ImageTransparentColor = System.Drawing.Color.Magenta
        'NewTst_8.Name = "ptsb_Combo"
        'NewTst_8.Size = New System.Drawing.Size(28, 27)
        'NewTst_8.Text = "No"
        'NewTst_8.ComboBox.Items.Add("No")
        'NewTst_8.ComboBox.Items.Add("Yes")

        'AddHandler NewTst_5.Click, AddressOf ToolStrip_Click


        Me.Items.Add(NewTst_5)
        Me.Items.Add(NewTst_6)
        Me.Items.Add(NewTst_4)
        Me.Items.Add(NewTst_3)
        'Me.Items.Add(NewTst_2)
        Me.Items.Add(NewTst_1)

    End Sub

    Private Sub ToolStrip_Click(sender As Object, e As EventArgs)
        Dim i As Integer
        Dim child As List(Of System.Windows.Forms.Control)
        Dim filelocation As String = ""
        Dim pi As FarPoint.Win.Spread.PrintInfo = New FarPoint.Win.Spread.PrintInfo()

        Try


            If sender.Name = "ptsb_Attach" Then
                Dim b As Object
                Dim frm As Form
                frm = CType(Me.FindForm, Form)

                child = frm.FindAllChildren()
                For i = 0 To child.Count - 1
                    If TypeOf child(i) Is FarPoint.Win.Spread.FpSpread Then
                        b = CType(child(i), FarPoint.Win.Spread.FpSpread)
                        If child(i).Focused = True Then
                            b.ActiveSheet.Protect = False

                            If ISUD7555A.Link_ISUD7555B(3, frm.Name, getPrimaryKey(frm.Name, b)) = False Then Exit Sub

                        End If
                    End If
                Next

            ElseIf sender.Name = "ptsb_FormUser" Then
                Dim b As Object
                Dim frm As Form
                frm = CType(Me.FindForm, Form)

                child = frm.FindAllChildren()
                For i = 0 To child.Count - 1
                    If TypeOf child(i) Is FarPoint.Win.Spread.FpSpread Then
                        b = CType(child(i), FarPoint.Win.Spread.FpSpread)
                        If child(i).Focused = True Then

                            Dim program As String
                            Dim Sheetname As String
                            Dim Chuoi() As String

                            Chuoi = Split(child(i).Tag, ";")
                            If UBound(Chuoi) < 1 Then Exit Sub
                            program = Chuoi(0)
                            Sheetname = Chuoi(1)

                            Call P_SPREAD_PROGRAM_USER.Link_ISUD_P_SPREAD_PROGRAM_USER(3, program, Sheetname)


                        End If
                    End If
                Next

            ElseIf sender.Name = "ptsb_PrintSheet" Then
                Dim b As Object
                Dim frm As Form
                frm = CType(Me.FindForm, Form)

                child = frm.FindAllChildren()
                For i = 0 To child.Count - 1
                    If TypeOf child(i) Is FarPoint.Win.Spread.FpSpread Then
                        b = CType(child(i), FarPoint.Win.Spread.FpSpread)
                        If child(i).Focused = True Then

                            Dim StrMsg As String
                            StrMsg = MsgBox("Click yes to print Potrait, no to Print Landscape!", vbYesNoCancel)
                            If StrMsg = vbCancel Then Exit Sub

                            Call Sheet_Print_NotFix(child(i), frm.Text, StrMsg)
                        End If
                    End If
                Next

            ElseIf sender.Name = "ptsb_Ctc" Then
                Call ISUD7421A.Link_ISUD7421A(3, Pub.NAM)


            ElseIf sender.Name = "ptsb_Close" Then
                Dim ob2 As Object
                ob2 = CType(Me.FindForm.Parent, DevExpress.XtraTab.XtraTabPage)
                ob2.dispose()
                Exit Sub


            ElseIf sender.Name = "ptsb_Mail" Then

                Dim b As Object
                Dim frm As Form
                frm = CType(Me.FindForm, Form)

                filelocation = App_Path & "\Temp\" & frm.Name & ".xls"
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
                            SendEmail(filelocation)

                            Exit Sub
                        End If
                    End If
                Next

                Exit Sub

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SendEmail(strFile As String)
        Try
            Dim Outlook As Outlook.Application
            Dim Mail As Outlook.MailItem
            Dim Acc As Outlook.Account

            Outlook = New Outlook.Application()
            Mail = Outlook.CreateItem(Microsoft.Office.Interop.Outlook.OlItemType.olMailItem)
            Mail.To = ""
            Mail.Subject = ""

            'If you have multiple accounts you could change it in sender:
            For Each Acc In Outlook.Session.Accounts
                'Select first pop3 for instance.
                If Acc.AccountType = Microsoft.Office.Interop.Outlook.OlAccountType.olPop3 Then
                    Mail.Sender = Acc
                End If
            Next


            'Attach files
            If (Not System.IO.Directory.Exists(App_Path & "\Report")) Then
                System.IO.Directory.CreateDirectory(App_Path & "\Report")
            End If


            Mail.Attachments.Add(strFile)

            Mail.HTMLBody &= "Please refer to attacted file for your information !"

            Mail.Display()

        Catch ex As Exception
            MsgBoxP("Please check your Outlook Mail configuration ! We can not send your file ! ")

        End Try
    End Sub

End Class
