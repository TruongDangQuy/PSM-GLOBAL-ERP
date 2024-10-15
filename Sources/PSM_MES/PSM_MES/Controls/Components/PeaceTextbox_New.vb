Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class PeaceTextbox_New
    Inherits TextBox

    Private m_Data As New DATASPACE

    Private m_DTValue As Integer = 0
    Private M_DTLen As Integer = 0
    Private m_DTDec As Integer = 0
    Private m_NoClear As Boolean = False

    Private m_Multiline As Boolean
    Private m_ScrollBars As Boolean
    Private m_MaxLength As Integer
    Private m_TextAlign As Integer

    Public Event txtTextChanged As EventHandler

    Sub New()
        ' TODO: Complete member initialization 
        Me.BorderStyle = Windows.Forms.BorderStyle.FixedSingle
    End Sub
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
            Return m_Data.CODE
        End Get
        Set(ByVal Value As String)

            m_Data.CODE = Value
            Me.Tag = Value

        End Set
    End Property
    Public Property Data() As String
        Get
            Return m_Data.NAME
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


    Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Data = Me.Text
        Code = Me.Tag
        RaiseEvent txtTextChanged(sender, e)

    End Sub


End Class
