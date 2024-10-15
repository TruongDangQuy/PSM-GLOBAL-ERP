Public Class PeaceLookUpEdit
    Inherits DevExpress.XtraEditors.LookUpEdit

    Private m_Data As New DATASPACE

    Public Event txtTextChanged As EventHandler

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
    Private Sub txtText_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.TextChanged
        Data = Me.Text
        Code = Me.Tag
        RaiseEvent txtTextChanged(sender, e)

    End Sub
End Class
