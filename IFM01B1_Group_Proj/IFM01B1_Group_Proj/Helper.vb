Option Strict On
Option Explicit On
Option Infer Off
Public Class Helper
    'Generate Random Number method
    Public Function GenerateRand(upper As Integer, lower As Integer) As Integer
        Dim temp As Integer
        temp = CInt((upper * Rnd()) + lower)
        Return temp
    End Function

    'Checks if value is within a range
    Public Sub IsInRange(value As String)
        '
    End Sub

    'Checks if parameter is an integer
    Public Sub ValidateInt(value As String)
        '
    End Sub
End Class
