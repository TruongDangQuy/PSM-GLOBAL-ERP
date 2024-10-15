Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.ComponentModel
Public Class PeaceDatetimepicker
    Inherits System.Windows.Forms.DateTimePicker
#Region "a"
    Protected Sub New()
        InitializeComponent()

        ' InitializeComponent() 호출 뒤에 초기화 코드를 추가하십시오.

        Me.Format = DateTimePickerFormat.Short

        Me.Size = New System.Drawing.Size(97, 21)

        Me.Font = New System.Drawing.Font( _
        "Tahoma", 10, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    End Sub
#End Region
End Class
