Module PropertyHelper

    Public Function SetValueProperty(o As Object, name As String, value As Object) As Object
        Dim info As System.Reflection.PropertyInfo = o.[GetType]().GetProperty(name)
        info.SetValue(o, value, Nothing)
        Return o
    End Function

    Public Function SetValueProperty(o As Object, name As String, value As Object, index As Object()) As Object
        Dim info As System.Reflection.PropertyInfo = o.[GetType]().GetProperty(name)
        info.SetValue(o, value, index)
        Return o
    End Function

End Module
