Public Class Worker
    Inherits System.ComponentModel.BackgroundWorker

    Private _LineOrig As String = ""
    Private _LineConv As String = ""
    Private _DownloadLink As String = ""
    Private _Finished As Boolean = False

    Public Property Finished() As Boolean
        Get
            Return _Finished
        End Get
        Set(ByVal Value As Boolean)

            _Finished = Value
        End Set
    End Property

    Public Property LineOrig() As String
        Get
            Return _LineOrig
        End Get
        Set(ByVal Value As String)

            _LineOrig = Value
        End Set
    End Property
    Public Property LineConv() As String
        Get
            Return _LineConv
        End Get
        Set(ByVal Value As String)

            _LineConv = Value

        End Set
    End Property
    Public Property DownloadLink() As String
        Get
            Return _DownloadLink
        End Get
        Set(ByVal Value As String)

            _DownloadLink = Value

        End Set
    End Property

End Class
