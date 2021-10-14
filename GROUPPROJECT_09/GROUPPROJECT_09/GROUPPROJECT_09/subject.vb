

Option Explicit On
Option Strict On
Option Infer Off

<Serializable> Public mustinherit Class subject
    Private _name As String
    Private _mark As Integer

    Public Property name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property mark As Integer
        Get
            Return _mark
        End Get
        Set(value As Integer)
            _mark = validate(value)
        End Set
    End Property

    Protected Function validate(value As Integer) As Integer
        If value < 0 Then
            Return 0
        Else
            Return value
        End If

    End Function

    Public Sub New(name As String, mark As Integer)
        Me.name = name
        Me.mark = mark
    End Sub

    Public Overridable Function displayresults() As String

        Dim temp As String

        temp = "Results" & Environment.NewLine & Environment.NewLine
        temp &= "Quize type: " & name & "Quiz" & Environment.NewLine
        temp &= "Marks: " & CStr(mark) & Environment.NewLine

        Return temp

    End Function

    'this function generates the learning materials that are needed for the quizes
    Public MustOverride Function displayLearningmaterial() As String

    'this is the quiz function
    Public Overridable Function takeQuiz() As Integer

        'quiz stuff

    End Function



End Class
