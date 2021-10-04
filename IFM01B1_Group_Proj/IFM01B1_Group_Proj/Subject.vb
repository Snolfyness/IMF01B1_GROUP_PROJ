
' *****************************************************************
' Team Number: assigned to team
' Team Member 1 Details: Lin, J (221179979)
' Team Member 2 Details: Khosa, MTS (221080579)
' Team Member 3 Details: Rasalanavho, Initials (220054293)
' Team Member 4 Details: none
' Practical: Team Project
' Class name: LearningMaterial
' *****************************************************************

Option Explicit On
Option Strict On
Option Infer Off

'this is the abstract or base class
<Serializable()> Public MustInherit Class Subject

    'these are the attributes
    Private _name As Integer
    Private _mark As Double
    Private _total As Double
    Private _average As Double


    'these are the property methods
    Public Property name As Integer
        Get
            Return _name
        End Get
        Set(value As Integer)
            _name = validate(name)
        End Set
    End Property

    Public Property mark As Double
        Get
            Return _mark
        End Get
        Set(value As Double)
            _mark = validate(value)
        End Set
    End Property

    Public Property total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = validate(value)
        End Set
    End Property

    Public Property average As Double
        Get
            Return _average

        End Get
        Set(value As Double)
            _average = validate(value)
        End Set
    End Property

    'END OF PROPERTY METHODS____________________________________________


    'this function generates the learning materials that are needed for the quizes
    Public MustOverride Function displayLearningmaterial() As String


    'this function generates quizes for each subject
    Protected MustOverride Function Quizes() As Integer


    'this function calculates the total score
    Protected Function calctotal() As Double
        'code to add sum of all quizes
    End Function

    'this function calculates the average of all the quizes completed
    Protected Function calcaverage() As Double
        'code to calc average
    End Function

    'this is the constructor
    Public Sub New(name As Integer, mark As Double)
        _name = name
        Me.mark = mark
    End Sub

    'this function validates all integer variable
    Protected Function validate(value As Double) As Integer
        If value < 0 Then
            value = 0
        Else
            Return CInt(value)
        End If
    End Function

End Class
