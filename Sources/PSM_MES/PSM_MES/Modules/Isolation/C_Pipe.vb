Public Class C_Pipe
#Region "구조체 원형 선언 구역"

    Public Structure PIPE

        Public RetKey As String     '전송키
        Public RetValue As String   '전송값

    End Structure

#End Region

#Region "전역 변수 선언 구역"

    Public Request As Object       '요청자
    Public Response As Object      '응답자

    Public Item() As PIPE

#End Region

#Region "프로퍼티 구역"

    Public ReadOnly Property Count() As Integer
        Get
            If IsNothing(Item) = False Then
                Return UBound(Item) + 1
            Else
                Return Nothing
            End If

        End Get
    End Property

    Public Property RetKey() As String
        Get
            If IsNothing(Item) = False Then
                Return Item(0).RetKey
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal Value As String)
            Item(0).RetKey = Value
        End Set
    End Property

    Public Property RetValue() As String
        Get
            If IsNothing(Item) = False Then
                Return Item(0).RetValue
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal Value As String)
            Item(0).RetValue = Value
        End Set
    End Property

#End Region

#Region "클래스 메소드 구역"

    Public Sub New(Optional ByVal ItemCount As Integer = 1)

        If ItemCount > 0 Then

            ReDim Item(ItemCount - 1)

        End If

    End Sub

#End Region

#Region "지역 메소드 구역"

    Public Sub Add()

        If IsNothing(Item) = False Then

            ReDim Preserve Item(UBound(Item) + 1)

        End If

    End Sub

    Public Sub Add(ByVal Key As String)

        If IsNothing(Item) = False Then

            ReDim Preserve Item(UBound(Item) + 1)

            Item(UBound(Item)).RetKey = Key

        End If

    End Sub

    Public Sub Add(ByVal Key As String, ByVal Value As String)

        If IsNothing(Item) = False Then

            ReDim Preserve Item(UBound(Item) + 1)

            Item(UBound(Item)).RetKey = Key
            Item(UBound(Item)).RetValue = Value

        End If

    End Sub

#End Region


    
 
End Class
