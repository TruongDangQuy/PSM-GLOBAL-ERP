Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class PeaceCheckbox
    Inherits System.Windows.Forms.CheckBox


    Private Sub PeaceCheckbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private m_ButtonTitle As String
    Public Property ButtonTitle() As String
        Get
            Return m_ButtonTitle
        End Get
        Set(ByVal Value As String)
            m_ButtonTitle = Value
            Me.Text = Value
        End Set
    End Property
End Class
