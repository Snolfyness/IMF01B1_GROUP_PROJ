Option Strict On
Option Explicit On
Option Infer Off

Public Class Quiz
    Private Question As String
    Private answer As Double

    Public Sub New(options As Integer)
        Select Case options
            Case 1
            Case 2
            Case 3
            Case 4
            Case Else
                MsgBox("Please select a valid option")
        End Select
    End Sub


End Class
