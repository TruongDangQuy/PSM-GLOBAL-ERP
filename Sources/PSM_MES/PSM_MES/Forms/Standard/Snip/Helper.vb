Imports System.Runtime.InteropServices

#Region "Device Info"
Public Class DeviceInfo
    Public Property DeviceName() As String
        Get
            Return m_DeviceName
        End Get
        Set(value As String)
            m_DeviceName = value
        End Set
    End Property
    Private m_DeviceName As String
    Public Property VerticalResolution() As Integer
        Get
            Return m_VerticalResolution
        End Get
        Set(value As Integer)
            m_VerticalResolution = value
        End Set
    End Property
    Private m_VerticalResolution As Integer
    Public Property HorizontalResolution() As Integer
        Get
            Return m_HorizontalResolution
        End Get
        Set(value As Integer)
            m_HorizontalResolution = value
        End Set
    End Property
    Private m_HorizontalResolution As Integer
    Public Property MonitorArea() As Rectangle
        Get
            Return m_MonitorArea
        End Get
        Set(value As Rectangle)
            m_MonitorArea = value
        End Set
    End Property
    Private m_MonitorArea As Rectangle
End Class
#End Region

#Region "Screen Helper"
Public NotInheritable Class ScreenHelper
    Private Sub New()
    End Sub
    Private Const DektopVertRes As Integer = 117
    Private Const DesktopHorzRes As Integer = 118
    <StructLayout(LayoutKind.Sequential)>
    Friend Structure Rect
        Public left As Integer
        Public top As Integer
        Public right As Integer
        Public bottom As Integer
    End Structure
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)>
    Friend Structure MONITORINFOEX
        Public Size As Integer
        Public Monitor As Rect
        Public WorkArea As Rect
        Public Flags As UInteger
        <MarshalAs(UnmanagedType.ByValTStr, SizeConst:=32)>
        Public DeviceName As String
    End Structure
    Private Delegate Function MonitorEnumDelegate(hMonitor As IntPtr, hdcMonitor As IntPtr, ByRef lprcMonitor As Rect, dwData As IntPtr) As Boolean
    <DllImport("user32.dll")>
    Private Shared Function EnumDisplayMonitors(hdc As IntPtr, lprcClip As IntPtr, lpfnEnum As MonitorEnumDelegate, dwData As IntPtr) As Boolean
    End Function
    <DllImport("gdi32.dll")>
    Private Shared Function CreateDC(lpszDriver As String, lpszDevice As String, lpszOutput As String, lpInitData As IntPtr) As IntPtr
    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Unicode)>
    Private Shared Function GetMonitorInfo(hMonitor As IntPtr, ByRef lpmi As MONITORINFOEX) As Boolean
    End Function
    <DllImport("User32.dll")>
    Private Shared Function ReleaseDC(hwnd As IntPtr, dc As IntPtr) As Integer
    End Function
    <DllImport("gdi32.dll")>
    Private Shared Function GetDeviceCaps(hdc As IntPtr, nIndex As Integer) As Integer
    End Function

    Private Shared _result As List(Of DeviceInfo)

    Public Shared Function GetMonitorsInfo() As List(Of DeviceInfo)
        _result = New List(Of DeviceInfo)()
        EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, AddressOf MonitorEnum, IntPtr.Zero)
        Return _result
    End Function

    Private Shared Function MonitorEnum(hMonitor As IntPtr, hdcMonitor As IntPtr, ByRef lprcMonitor As Rect, dwData As IntPtr) As Boolean
        Dim mi = New MONITORINFOEX()
        mi.Size = Marshal.SizeOf(GetType(MONITORINFOEX))
        Dim success As Boolean = GetMonitorInfo(hMonitor, mi)
        If success Then
            Dim dc = CreateDC(mi.DeviceName, mi.DeviceName, Nothing, IntPtr.Zero)
            Dim di = New DeviceInfo()
            With di
                .DeviceName = mi.DeviceName
                .MonitorArea = New Rectangle(mi.Monitor.left, mi.Monitor.top, mi.Monitor.right - mi.Monitor.right, mi.Monitor.bottom - mi.Monitor.top)
                .VerticalResolution = GetDeviceCaps(dc, DektopVertRes)
                .HorizontalResolution = GetDeviceCaps(dc, DesktopHorzRes)
            End With
            ReleaseDC(IntPtr.Zero, dc)
            _result.Add(di)
        End If
        Return True
    End Function

End Class
#End Region


