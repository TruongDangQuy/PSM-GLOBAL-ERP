Module MainClass
    Sub Main(ByVal args() As String)

        SetConnect()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New MdiMenu)
    End Sub
End Module
