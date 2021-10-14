' *****************************************************************
' Team Number: assigned to team
' Team Member 1 Details: Lin, J (221179979)
' Team Member 2 Details: Khosa, MTS (221080579)
' Team Member 3 Details: Rasalanavho, A (220054293)
' Team Member 4 Details: none
' Practical: Team Project
' Class name: LearningMaterial
' *****************************************************************
Option Strict On
Option Explicit On
Option Infer Off

'this is the english question class that will handle all english quizes
Public Class EnglishQuestion
    'private variables
    Private _Q1 As Integer
    Private _Q2 As Integer
    Private _Q3 As Integer
    Private _Q4 As Integer
    Private _Answer As Integer
    Private _marks As Integer


    'Property methods
    Public Property q1 As Integer
        Get
            Return _Q1
        End Get
        Set(value As Integer)
            _Q1 = value
        End Set
    End Property
    Public Property q2 As Integer
        Get
            Return _Q2
        End Get
        Set(value As Integer)
            _Q2 = value
        End Set
    End Property
    Public Property q3 As Integer
        Get
            Return _Q3
        End Get
        Set(value As Integer)
            _Q3 = value
        End Set
    End Property
    Public Property q4 As Integer
        Get
            Return _Q4
        End Get
        Set(value As Integer)
            _Q4 = value
        End Set
    End Property

    Public Property marks As Integer
        Get
            Return _marks
        End Get
        Set(value As Integer)
            _marks = value
        End Set
    End Property



    Public ReadOnly Property Answer As Integer
        Get
            Return _Answer
        End Get
    End Property

    'these functions will check each question and mark it
    Public Function CheckAnswer(input As Integer) As Boolean

        If input = _Answer Then
            Return True

        Else
            Return False
        End If
    End Function



    'end of marking functions______________________________________

    Public Function displayquiz() As String
        Dim temp As String

        temp = ""
        temp &= "1)  Which of the following is a noun?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Car" & Environment.NewLine & "2 - Fast" & Environment.NewLine & Environment.NewLine
        temp &= "2)  Which of the following is a adjective?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Car" & Environment.NewLine & "2 - Fast" & Environment.NewLine & Environment.NewLine
        temp &= "3)  Which of the following is a verb" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Running" & Environment.NewLine & "2 - Fast" & Environment.NewLine & Environment.NewLine
        temp &= "4)  Which of the following is a adverb?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Quickly" & Environment.NewLine & "2 - Quick" & Environment.NewLine & Environment.NewLine
        temp &= "" & Environment.NewLine

        Return temp
    End Function

    'this is the contructor
    Public Sub New(mark As Integer)
        _marks = mark



    End Sub




End Class
