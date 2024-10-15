Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel
<ToolboxItem(True)>
Public Class PeacePanel
    'Inherits System.Windows.Forms.Panel
    Inherits DevExpress.XtraEditors.PanelControl

    Private m_Data As New DATASPACE
    Public Property Code() As String
        Get
            If m_Data.CODE = "" Then Return "" Else Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            Me.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            If m_Data.NAME = "" Then Return "" Else Return m_Data.NAME
        End Get
        Set(ByVal Value As String)

            m_Data.NAME = Value
            Me.Text = Value

        End Set
    End Property
End Class
