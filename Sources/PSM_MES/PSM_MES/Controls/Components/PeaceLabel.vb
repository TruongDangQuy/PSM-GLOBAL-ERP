Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class PeaceLabel
    'Inherits System.Windows.Forms.Label
    'Inherits System.Windows.Forms.Label
    Inherits DevExpress.XtraEditors.LabelControl

    Private m_Data As New DATASPACE

    Private m_DTValue As Integer = 0
    Private M_DTLen As Integer = 0
    Private m_DTDec As Integer = 0
    Private m_NoClear As Boolean = False

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

    Private m_TextAlign As DevExpress.Utils.HorzAlignment
    Public Property TextAlign() As DevExpress.Utils.HorzAlignment
        Get
            Return m_TextAlign
        End Get
        Set(value As DevExpress.Utils.HorzAlignment)
            m_TextAlign = value
            Me.Appearance.TextOptions.HAlignment = value
        End Set
    End Property

    Public Property NoClear() As Boolean
        Get
            Return m_NoClear
        End Get
        Set(ByVal Value As Boolean)

            m_NoClear = Value
        End Set
    End Property
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
    Public Property DTValue() As Integer
        Get
            Return m_DTValue
        End Get
        Set(value As Integer)
            m_DTValue = value
        End Set
    End Property

    Public Property DTLen() As Integer
        Get
            Return M_DTLen
        End Get
        Set(value As Integer)
            M_DTLen = value
        End Set
    End Property

    Public Property DTDec() As Integer
        Get
            Return m_DTDec
        End Get
        Set(value As Integer)
            m_DTDec = value
        End Set
    End Property
End Class
