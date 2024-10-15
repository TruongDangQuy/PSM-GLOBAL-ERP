Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class PeaceCombobox
    Inherits System.Windows.Forms.ComboBox
    Private m_DTValue As Integer = 0
    Private M_DTLen As Integer = 0
    Private m_DTDec As Integer = 0
    Private m_NoClear As Boolean = False
    Private m_InSelected As Integer = 0
    Private m_ListIndex As Integer = 0
    Public Property NoClear() As Boolean
        Get
            Return m_NoClear
        End Get
        Set(ByVal Value As Boolean)

            m_NoClear = Value
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

    Public Property InSelected() As Integer
        Get
            Return m_InSelected
        End Get
        Set(value As Integer)
            m_InSelected = value

            If Me.Items.Count > 0 Then Me.SelectedIndex = value Else Me.SelectedIndex = -1
            'If value >= 0 Then Me.SelectedIndex = value Else Me.SelectedIndex = 0
        End Set
    End Property

    Public Property ListIndex() As Integer
        Get
            Return m_ListIndex
        End Get
        Set(value As Integer)
            m_ListIndex = value
            If Me.Items.Count > 0 Then Me.SelectedIndex = value Else Me.SelectedIndex = -1
        End Set
    End Property


    Public Sub Additem(ByVal Value As String)
        Me.Items.Add(Value)
    End Sub
End Class
