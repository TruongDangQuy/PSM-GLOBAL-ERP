Imports System.Data.SqlClient
Imports System.IO
Public Class SaveMe
#Region "Variable"
    Dim dateTime As System.DateTime
    Dim pW, pH As Integer
    Public ImageToSave As Image
    Public Shared activeWindow As Integer
#End Region

#Region "Form_Closing"

    Private Sub Form_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If tstNew.Pressed = True Or tstCancel.Pressed = True Then
            Exit Sub
        End If
        Me.Close()
        'If MsgBox("Discard saving image?", MsgBoxStyle.YesNo, "Are you sure?") = MsgBoxResult.Yes Then
        '    frmSnipMain.Opacity = 100
        '    frmSnipMain.Show()
        '    frmSnipMain.Focus()
        'Else
        '    e.Cancel = True
        'End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        active_Window()

        PictureBox1.Image = ImageToSave
        pW = ImageToSave.Width
        pH = ImageToSave.Height

        Me.SetBounds(0, 0, pW + 216, pH + 271)
        TableLayoutPanel1.Size = New Size(pW + 200, pH + 239)
        TableLayoutPanel2.Size = New Size(pW + 200, pH + 200)
        PictureBox1.Size = New Size(ImageToSave.Size)

        TableLayoutPanel2.Padding = New Padding(100, 100, 100, 100)

        TableLayoutPanel2.AutoScroll = True
        TableLayoutPanel2.AutoScrollMinSize = New Size(PictureBox1.Image.Width + 200, PictureBox1.Image.Height + 200)

        If Me.Bounds.Bottom > Screen.AllScreens(activeWindow).WorkingArea.Bottom Or Me.Bounds.Right > Screen.AllScreens(activeWindow).WorkingArea.Right Then
            Me.WindowState = FormWindowState.Maximized
        End If

        Me.Opacity = 100
        Me.Show()

        Me.Cursor = Cursors.Default
        Me.Focus()
    End Sub
#End Region

#Region "Function"
    Private Sub SaveToClipboard()
        If ImageToSave.Width > 0 Then
            Dim _img = New Bitmap(ImageToSave, ImageToSave.Width, ImageToSave.Height)
            Dim g = Graphics.FromImage(_img)

            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality

            Clipboard.SetImage(_img)
        End If
    End Sub

    Private Sub Save_New()
        Dim SqlCom As SqlClient.SqlCommand
        Dim MaxByte As Integer = 1024 * 1024
        Dim imageData As Byte()

        Dim ms As New MemoryStream

        Dim qry As String

        Try

            If CheckSolution = False Then

                Me.PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageData = ms.GetBuffer

                If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 1 MB!") : Exit Sub

                'Set insert query 
                qry = "insert into [PFK7555] ([K7555_TABLE],[K7555_PAREMETER],[K7555_SEQ],[K7555_FileName],[K7555_ImageData]," & _
                "[K7555_FileType],[K7555_AttachDate],[K7555_AttachIncharge],[K7555_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()

                SqlCom.Parameters.Add(New SqlParameter("@TABLE", FormTableName))
                SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", FormTablePara))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", KEY_SEQ & ".jpeg"))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", "jpeg"))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

                'Execute the Query
                SqlCom.ExecuteNonQuery()

                isudCHK = True

            Else


                Me.PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                imageData = ms.GetBuffer

                If imageData.Length > MaxByte Then MsgBoxP("Image size is not over 1 MB!") : Exit Sub

                'Set insert query 
                qry = "insert into [PFK9172] ([K9172_BasicSel],[K9172_BasicCode],[K9172_SEQ],[K9172_FileName],[K9172_ImageData]," & _
                "[K9172_FileType],[K9172_AttachDate],[K9172_AttachIncharge],[K9172_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()

                SqlCom.Parameters.Add(New SqlParameter("@TABLE", FormTableName))
                SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", FormTablePara))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", KEY_SEQ & ".jpeg"))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", "jpeg"))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

                'Execute the Query
                SqlCom.ExecuteNonQuery()

                isudCHK = True

            End If
        Catch ex As Exception
            isudCHK = False
            MessageBox.Show(ex.ToString())
        End Try

    End Sub
    Private Sub tstSave_Click(sender As Object, e As EventArgs) Handles tstSave.Click
        Save_New()
        tstCancel.PerformClick()
    End Sub

    Private KEY_SEQ As String

    Private Sub KEY_COUNT()
        Dim SQL As String
        Dim rd As SqlClient.SqlDataReader

        If CheckSolution = False Then
            SQL = "SELECT MAX(K7555_SEQ) AS MAX_CODE FROM [PFK7555] "
            SQL = SQL & " WHERE K7555_TABLE     = '" + FormTableName + "'"
            SQL = SQL & " AND [K7555_PAREMETER] = '" + FormTablePara + "'"

        Else
            SQL = "SELECT MAX(K9172_SEQ) AS MAX_CODE FROM [PFK9172] "
            SQL = SQL & " WHERE K9172_BasicSel     = '" + FormTableName + "'"
            SQL = SQL & " AND [K9172_BasicCode] = '" + FormTablePara + "'"

        End If

        cmd = New SqlClient.SqlCommand(SQL, cn)
        rd = cmd.ExecuteReader
        rd.Read()

        If IsDBNull(rd!MAX_CODE) Then
            KEY_SEQ = 1
        Else
            KEY_SEQ = CIntp(rd!MAX_CODE + 1)
        End If

        rd.Close()
    End Sub

    Private Sub upLoadImageOrFile(ByVal sFilePath As String, ByVal sFileType As String)
        Dim SqlCom As SqlClient.SqlCommand
        Dim MaxByte As Integer = 1024 * 1024
        Dim imageData As Byte()


        Dim sFileName As String

        Dim qry As String

        Try

            If CheckSolution = False Then
                'Set insert query 
                qry = "insert into [PFK7555] ([K7555_TABLE],[K7555_PAREMETER],[K7555_SEQ],[K7555_FileName],[K7555_ImageData]," & _
                "[K7555_FileType],[K7555_AttachDate],[K7555_AttachIncharge],[K7555_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()

                SqlCom.Parameters.Add(New SqlParameter("@TABLE", FormTableName))
                SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", FormTablePara))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

                'Execute the Query
                SqlCom.ExecuteNonQuery()

            Else

                qry = "insert into [PFK9172] ([K9172_BasicSel],[K9172_BasicCode],[K9172_SEQ],[K9172_FileName],[K9172_ImageData]," & _
              "[K9172_FileType],[K9172_AttachDate],[K9172_AttachIncharge],[K9172_Time]) values (@TABLE, @PAREMETER,@SEQ,@FileName,@ImageData,@FileType,@AttachDate,@AttachIncharge,@Time)"

                'Initialize SqlCommand object for insert. 
                SqlCom = New SqlCommand(qry, cn)

                'We are passing File Name and Image byte data as sql parameters. 
                Call KEY_COUNT()

                SqlCom.Parameters.Add(New SqlParameter("@TABLE", FormTableName))
                SqlCom.Parameters.Add(New SqlParameter("@PAREMETER", FormTablePara))
                SqlCom.Parameters.Add(New SqlParameter("@SEQ", KEY_SEQ))

                SqlCom.Parameters.Add(New SqlParameter("@FileName", sFileName))

                SqlCom.Parameters.Add(New SqlParameter("@ImageData", DirectCast(imageData, Object)))

                SqlCom.Parameters.Add(New SqlParameter("@FileType", sFileType))
                SqlCom.Parameters.Add(New SqlParameter("@AttachDate", Pub.DAT))
                SqlCom.Parameters.Add(New SqlParameter("@AttachIncharge", Pub.SAW))
                SqlCom.Parameters.Add(New SqlParameter("@Time", System_Date_time))

                'Execute the Query
                SqlCom.ExecuteNonQuery()

            End If

        Catch ex As Exception

            MessageBox.Show(ex.ToString())
        End Try


    End Sub

    Public Shared Function getMouseLocation() As Point
        Return Cursor.Position
    End Function

    Public Shared Sub active_Window()
        For i As Integer = 0 To Screen.AllScreens().Count - 1
            If Screen.AllScreens(i).Bounds.Contains(getMouseLocation()) = True Then
                activeWindow = i
            End If
        Next
    End Sub

#End Region

#Region "Event"
    Private Sub tstNew_Click(sender As Object, e As EventArgs) Handles tstNew.Click
        Me.Close()
        frmSnipMain.Opacity = 100
        frmSnipMain.Show()
        frmSnipMain.Focus()
    End Sub

    Private Sub tstCopy_Click(sender As Object, e As EventArgs) Handles tstCopy.Click
        Call SaveToClipboard()
    End Sub

    Private Sub tst_CancelClick(sender As Object, e As EventArgs) Handles tstCancel.Click
        Me.Opacity = 0
        Me.Close()
        If frmSnipMain.mniRect.CheckState = CheckState.Checked Then
            SnippedRect.Snip()
        ElseIf frmSnipMain.mniFull.CheckState = CheckState.Checked Then
            SnippedFull.Snip()
        End If
    End Sub

    Private Sub OnFormResize(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.SetBounds(0, 0, pW + 216, pH + 271)
        TableLayoutPanel1.Size = New Size(pW + 200, pH + 239)
        TableLayoutPanel2.Size = New Size(pW + 200, pH + 200)
        PictureBox1.Size = New Size(ImageToSave.Size)

        TableLayoutPanel2.Padding = New Padding(100, 100, 100, 100)

        TableLayoutPanel2.AutoScroll = True
        TableLayoutPanel2.AutoScrollMinSize = New Size(PictureBox1.Image.Width + 200, PictureBox1.Image.Height + 200)

        If Me.Bounds.Bottom > Screen.AllScreens(activeWindow).WorkingArea.Bottom Or Me.Bounds.Right > Screen.AllScreens(activeWindow).WorkingArea.Right Then
            Me.WindowState = FormWindowState.Maximized
        End If

    End Sub

    Private Sub Form_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'If e.Control = True Then
        '    If e.KeyCode = Keys.S Then
        '        tstSave.PerformClick()
        '    ElseIf e.KeyCode = Keys.C Then
        '        tstCopy.PerformClick()
        '    ElseIf e.KeyCode = Keys.N Then
        '        tstNew.PerformClick()
        '    End If
        'End If
        'If e.KeyCode = Keys.Escape Then
        '    Me.Close()
        'End If

        If e.KeyCode = Keys.Enter Then
            Save_New()
            Call tstCancel.PerformClick()

        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
            'frmSnipMain.Dispose()
        End If

    End Sub
#End Region

End Class