Option Strict On
Option Explicit On
Option Infer Off
Public Class Helper
    Public Function GenerateRand(upper As Integer, lower As Integer) As Integer
        Dim temp As Integer
        temp = CInt((upper * Rnd()) + lower)
        Return temp
    End Function
End Class
