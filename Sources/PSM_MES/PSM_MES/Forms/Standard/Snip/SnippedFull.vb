Imports System.Drawing.Imaging

Public Class SnippedFull
    'Inherits Form
#Region "Variable"

    Private _bmp As Bitmap
    Private _left As Integer
    Private _top As Integer
    Private _hRes As Integer
    Private _vRes As Integer

    Sub New(screenShot As Bitmap, x As Integer, y As Integer, width As Integer, height As Integer)
        InitializeComponent()
        BackgroundImage = screenShot
        BackgroundImageLayout = ImageLayout.Stretch
        ShowInTaskbar = False
        FormBorderStyle = FormBorderStyle.None
        StartPosition = FormStartPosition.Manual
        SetBounds(x, y, width, height)
        WindowState = FormWindowState.Maximized
        DoubleBuffered = True
        Cursor = Cursors.Hand
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

    Private Shared _forms As SnippedFull()
    Private _rectSelection As Rectangle
    Private _pointStart As Point
#End Region

#Region "Form_Close"

    Private FormName As String
    Private Parameter As String

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
        _forms = New SnippedFull(screens.Count - 1) {}

        For i As Integer = 0 To screens.Count - 1
            Dim hRes As Integer = screens(i).HorizontalResolution
            Dim vRes As Integer = screens(i).VerticalResolution
            Dim top As Integer = screens(i).MonitorArea.Top
            Dim left As Integer = screens(i).MonitorArea.Left
            Dim bmp = New Bitmap(hRes, vRes, PixelFormat.Format32bppPArgb)

            Using g = Graphics.FromImage(bmp)
                g.CopyFromScreen(left, top, 0, 0, bmp.Size)
            End Using

            _forms(i) = New SnippedFull(bmp, left, top, hRes, vRes)
            _forms(i).Show()
        Next
    End Sub

    Public Shared Sub transferImage(Img As Image)
        SaveMe.ImageToSave = Img
        Form_Close()
        SaveMe.Show()
        'If isudCHK = True Then frmSnipMain.Dispose()
    End Sub

    Public Shared Function getMouseLocation() As Point
        Return Cursor.Position
    End Function

#End Region

#Region "Event"
    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        For i As Integer = 0 To Screen.AllScreens().Count - 1
            If Screen.AllScreens(i).Bounds.Contains(getMouseLocation()) = True Then
                transferImage(_forms(i).BackgroundImage)
            End If
        Next
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        For i As Integer = 0 To Screen.AllScreens().Count - 1
            If Screen.AllScreens(i).Bounds.Contains(getMouseLocation()) = True Then
                _rectSelection = New Rectangle(0, 0, Width, Height)
            End If
        Next
        Invalidate()
    End Sub

    Protected Overrides Sub OnMouseLeave(e As EventArgs)
        _rectSelection = New Rectangle(0, 0, 0, 0)
        Invalidate()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using br As Brush = New SolidBrush(Color.FromArgb(120, Color.White))
            e.Graphics.FillRectangle(br, _rectSelection)
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

