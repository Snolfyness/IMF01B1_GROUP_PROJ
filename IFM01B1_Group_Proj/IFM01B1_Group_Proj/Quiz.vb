Option Strict On
Option Explicit On
Option Infer Off

Public Class Quiz
    'private variables
    Private _Question As String
    Private _Answer As Double

    'Property methods
    Public ReadOnly Property Question As String
        Get
            Return _Question
        End Get
    End Property

    Public ReadOnly Property Answer As Double
        Get
            Return _Answer
        End Get
    End Property

    'Constructor
    Public Sub New(options As Integer)
        Select Case options
            Case 1
                GenerateAddition()
            Case 2
            Case 3
            Case 4
            Case Else
                MsgBox("Please select a valid option")
        End Select
    End Sub

    'GenerateAddition method
    Public Sub GenerateAddition()
        Dim a, b As Integer
        a = CInt(100 * Rnd() + 1)
        b = CInt(100 * Rnd() + 1)

        _Question = a & " + " & b & Environment.NewLine
        _Answer = a + b
    End Sub

    'GenerateSubtraction method
    Public Sub GenerateSubtraction()
        Dim a, b As Integer
        a = CInt(100 * Rnd() + 1)
        b = CInt(100 * Rnd() + 1)

        _Question = a & " - " & b & Environment.NewLine
        _Answer = a - b
    End Sub

    'GenerateMultiplication method
    Public Sub GenerateMultiplication()
        Dim a, b As Integer
        a = CInt(100 * Rnd() + 1)
        b = CInt(100 * Rnd() + 1)

        _Question = a & " x " & b & Environment.NewLine
        _Answer = a * b
    End Sub


End Class
