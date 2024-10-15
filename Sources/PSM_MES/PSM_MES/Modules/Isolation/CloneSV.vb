Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO
Module CloneSV
    Public Function Clone_SV(ByVal sheetView As SheetView) As SheetView
        Dim m As New MemoryStream
        Dim b As New BinaryFormatter
        sheetView.SheetName = "New"
        b.Serialize(m, sheetView)
        m.Position = 0

        Return b.Deserialize(m)
    End Function
End Module
