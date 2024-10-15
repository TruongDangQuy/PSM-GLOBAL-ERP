Imports System.Drawing.Imaging

Public Class SnippedRect
    Inherits Form
#Region "Variable"

    Private _bmp As Bitmap
    Private _left As Integer
    Private _top As Integer
    Private _hRes As Integer
    Private _vRes As Integer

    Sub New(screenShot As Bitmap, x As Integer, y As Integer, width As Integer, height As Integer)
        BackgroundImage = screenShot
        BackgroundImageLayout = ImageLayout.Stretch
        ShowInTaskbar = False
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.Manual
        SetBounds(x, y, width, height)
        WindowState = FormWindowState.Maximized
        DoubleBuffered = True
        Cursor = Cursors.Cross
        TopMost = True
    End Sub

    Public Shared Property Image() As Image
        Get
            Return m_Image
        End Get
        Set(value As Image)
            m_Image = value
        End Set
    End Property
    Private Shared m_Image As Image

    Private Shared _forms As SnippedRect()
    Private _rectSelection As Rectangle
    Private _pointStart As Point
#End Region

#Region "Form_Close"
    Public Shared Sub Form_Close()
        For i As Integer = 0 To ScreenHelper.GetMonitorsInfo.Count - 1
            _forms(i).Dispose()
            _forms(i).Close()
        Next
    End Sub
#End Region

#Region "Function"

    Public Shared Sub Snip()
        Dim screens = ScreenHelper.GetMonitorsInfo()
        _forms = New SnippedRect(screens.Count - 1) {}

        For i As Integer = 0 To screens.Count - 1
            Dim hRes As Integer = screens(i).HorizontalResolution
            Dim vRes As Integer = screens(i).VerticalResolution
            Dim top As Integer = screens(i).MonitorArea.Top
            Dim left As Integer = screens(i).MonitorArea.Left
            Dim bmp = New Bitmap(hRes, vRes, PixelFormat.Format32bppPArgb)

            Using g = Graphics.FromImage(bmp)
                g.CopyFromScreen(left, top, 0, 0, bmp.Size)
            End Using

            _forms(i) = New SnippedRect(bmp, left, top, hRes, vRes)
            _forms(i).Show()
        Next
    End Sub


    Public Shared Sub transferImage(Img As Image)
        SaveMe.ImageToSave = Img
        Form_Close()
        SaveMe.Show()
    End Sub

#End Region

#Region "Event"
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        If e.Button <> MouseButtons.Left Then
            Return
        End If
        _pointStart = e.Location
        _rectSelection = New Rectangle(e.Location, New Size(0, 0))
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If e.Button <> MouseButtons.Left Then
            Return
        End If
        Dim x1 As Integer = Math.Min(e.X, _pointStart.X)
        Dim y1 As Integer = Math.Min(e.Y, _pointStart.Y)
        Dim x2 As Integer = Math.Max(e.X, _pointStart.X)
        Dim y2 As Integer = Math.Max(e.Y, _pointStart.Y)
        _rectSelection = New Rectangle(x1, y1, x2 - x1, y2 - y1)
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        If _rectSelection.Width <= 0 OrElse _rectSelection.Height <= 0 Then
            Return
        End If
        Image = New Bitmap(_rectSelection.Width, _rectSelection.Height)
        Dim hScale = BackgroundImage.Width / CDbl(Width)
        Dim vScale = BackgroundImage.Height / CDbl(Height)

        Using gr As Graphics = Graphics.FromImage(Image)
            gr.DrawImage(BackgroundImage, New Rectangle(0, 0, Image.Width, Image.Height), _
            New Rectangle(CInt(_rectSelection.X * hScale), CInt(_rectSelection.Y * vScale), CInt(_rectSelection.Width * hScale), CInt(_rectSelection.Height * vScale)), GraphicsUnit.Pixel)
        End Using

        transferImage(Image)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using br As Brush = New SolidBrush(Color.FromArgb(120, Color.White))
            Dim x1 As Integer = _rectSelection.X
            Dim x2 As Integer = _rectSelection.X + _rectSelection.Width
            Dim y1 As Integer = _rectSelection.Y
            Dim y2 As Integer = _rectSelection.Y + _rectSelection.Height
            e.Graphics.FillRectangle(br, New Rectangle(0, 0, x1, Height))
            e.Graphics.FillRectangle(br, New Rectangle(x2, 0, Width - x2, Height))
            e.Graphics.FillRectangle(br, New Rectangle(x1, 0, x2 - x1, y1))
            e.Graphics.FillRectangle(br, New Rectangle(x1, y2, x2 - x1, Height - y2))
        End Using

        Using pen As New Pen(Color.Red, 2)
            e.Graphics.DrawRectangle(pen, _rectSelection)
        End Using
    End Sub

    Private Sub Snipped_Keydow(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form_Close()
            frmSnipMain.Opacity = 100
            frmSnipMain.Show()
            frmSnipMain.Focus()
        End If
    End Sub
#End Region

End Class

