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
    Private _Question As String
    Private _Answer As Integer
    Private _marks As Integer


    'Property methods

    Public ReadOnly Property marks As Integer
        Get
            Return _marks
        End Get
    End Property

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

    'checks input against answer
    Public Function CheckAnswer(input As Integer) As Boolean
        If input = _Answer Then
            Return True
        Else
            Return False
        End If
    End Function

    'this is the contructor
    Public Sub New(answer As Integer)

    End Sub



End Class
