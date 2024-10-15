Module M_Formatting

#Region "Variable"
    Public Link_BUYER As String
    Public Link_ODNO As String
    Public Link_MODEL As String
    Public Link_STYLE As String
    Public Link_ORIGIN As String
    Public Link_BasicCode As String

    Public App_Path = New System.IO.FileInfo(Application.ExecutablePath).DirectoryName
    Public PRI_FOR As String
    Public PRI_PIT As Integer

    Public KOR_PRI_FOR As String
    Public KOR_PRI_PIT As Integer

    Public USD_PRI_FOR As String
    Public USD_PRI_PIT As Integer

    '±Ý¾× Æ÷¸Ë Çü½Ä º¯¼ö
    Public AMT_FOR As String
    Public AMT_PIT As Integer

    Public KOR_AMT_FOR As String
    Public KOR_AMT_PIT As Integer

    Public USD_AMT_FOR As String
    Public USD_AMT_PIT As Integer

    'JUL,BOX FORMAT TYPE
    Public JUL_FOR As String = 0
    Public JUL_PIT As Integer

    'Áß·® Æ÷¸Ë Çü½Ä º¯¼ö
    Public WGT_FOR As String = 2
    Public WGT_PIT As Integer

    '¸¶¼ö Æ÷¸Ë Çü½Ä º¯¼ö
    Public YDS_FOR As String = 2
    Public YDS_PIT As Integer

    'METER FORMAT TYPE
    Public MTS_FOR As String
    Public MTS_PIT As Integer

    Public Link_LOTNO As String

    Public DECIMAL_FOR0 As String
    Public DECIMAL_PIT0 As Integer

    Public DECIMAL_FOR1 As String
    Public DECIMAL_PIT1 As Integer

    Public DECIMAL_FOR2 As String
    Public DECIMAL_PIT2 As Integer

    Public DECIMAL_FOR3 As String
    Public DECIMAL_PIT3 As Integer

    Public DECIMAL_FOR4 As String
    Public DECIMAL_PIT4 As Integer

    Public DECIMAL_FOR5 As String
    Public DECIMAL_PIT5 As Integer
#End Region

End Module
