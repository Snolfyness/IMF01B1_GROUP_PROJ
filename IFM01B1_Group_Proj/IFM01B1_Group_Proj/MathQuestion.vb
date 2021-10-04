' *****************************************************************
' Team Number: assigned to team
' Team Member 1 Details: Lin, J (221179979)
' Team Member 2 Details: Khosa, MTS (221080579)
' Team Member 3 Details: Rasalanavho, Initials (220054293)
' Team Member 4 Details: none
' Practical: Team Project
' Class name: LearningMaterial
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off

Public Class MathQuestion
    'private variables
    Private _Question As String
    Private _Answer As Integer

    'Property methods
    Public ReadOnly Property Question As String
        Get
            Return _Question
        End Get
    End Property

    Public ReadOnly Property Answer As Integer
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
                GenerateSubtraction()
            Case 3
                GenerateMultiplication()
            Case 4
                GenerateDivision()
            Case Else
                MsgBox("Please select a valid option")
        End Select
    End Sub

    'checks input against answer
    Public Function CheckAnswer(input As Integer) As Boolean
        If input = _Answer Then
            Return True
        Else
            Return False
        End If
    End Function

    'GenerateAddition method
    Private Sub GenerateAddition()
        Dim a, b As Integer
        a = CInt(100 * Rnd() + 1) 'Might be ported to the helper class 
        b = CInt(100 * Rnd() + 1)

        _Question = a & " + " & b & Environment.NewLine
        _Answer = a + b
    End Sub

    'GenerateSubtraction method
    Private Sub GenerateSubtraction()
        Dim a, b As Integer
        a = CInt(100 * Rnd() + 1)
        b = CInt(100 * Rnd() + 1)

        While a < b
            a = CInt(100 * Rnd() + 1)
            b = CInt(100 * Rnd() + 1)
        End While

        _Question = a & " - " & b & Environment.NewLine
        _Answer = a - b
    End Sub

    'GenerateMultiplication method
    Private Sub GenerateMultiplication()
        Dim a, b As Integer
        a = CInt(100 * Rnd() + 1)
        b = CInt(100 * Rnd() + 1)

        _Question = a & " x " & b & Environment.NewLine
        _Answer = a * b
    End Sub

    'GenerateDivision method
    Private Sub GenerateDivision()
        Dim a, b As Integer
        a = CInt(100 * Rnd() + 1)
        b = CInt(100 * Rnd() + 1)

        While Not (a Mod b = 0)
            a = CInt(100 * Rnd() + 1)
            b = CInt(100 * Rnd() + 1)
        End While
        _Question = a & " / " & b & Environment.NewLine
        _Answer = CInt(a / b)
    End Sub

End Class
