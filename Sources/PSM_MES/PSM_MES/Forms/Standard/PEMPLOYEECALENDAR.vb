Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Microsoft.Win32

Partial Public Class PEMPLOYEECALENDAR
    Private CheckSave As Boolean = False

    Const xmlFile As String = "EmployeeCalendar.xml"

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub PEMPLOYEECALENDAR_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control = True And e.KeyCode = Keys.S Then
            CheckSave = True
            vS1.Save(App_Path & "\EmployeeCalendar.xml", False)
            MsgBoxP("Lưu thành công !", vbInformation)
        End If
    End Sub


    Private Sub XMLStudentCalendar_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            vS1.Open(App_Path & "\EmployeeCalendar.xml")
        Catch ex As Exception
            MsgBoxP("Không thể mở bản kế hoạch. Nó đã bị xóa !", vbCritical)
            MsgBoxP(ex.Message, vbCritical)
        End Try


    End Sub

  
End Class
