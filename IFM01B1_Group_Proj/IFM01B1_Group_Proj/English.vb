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
Public Class English
    Inherits Subject
    'attributes

    Private _choice As Integer

    'these are the property methods
    Public Property choice As Integer
        Get
            Return _choice
        End Get
        Set(value As Integer)
            _choice = validate(value)
        End Set
    End Property
    'END OF PROPERTY METHODS____________________________________________

    'this is the constructor
    Public Sub New(name As Integer, mark As Integer, choice As Integer)
        MyBase.New(name, mark)
        Me.choice = choice
    End Sub

    'this function displays the english learing material to prepare the student for the quizes
    Public Overrides Function displayLearningmaterial() As String
        Select Case choice
            Case 1 ' nouna
                Return displaynouns()

            Case 2 ' verbs
                Return displayverbs()

            Case 3 ' adjectives
                Return displayadjectives()

            Case 4 ' adverbs
                Return displayadverbs()
            Case Else
                Return "Please select a valid choice"
        End Select
    End Function


    'this function displays noun material
    Public Function displaynouns() As String
        Dim temp As String
        temp = "Nouns" & Environment.NewLine & Environment.NewLine

        temp &= "In this section you will learn about parts of speech" & Environment.NewLine
        temp &= "A noun is a person, place, or thing" & Environment.NewLine
        temp &= "Some examples of a person are: sister, friend, Alex, Stephanie, you, me, dog" & Environment.NewLine
        temp &= "Examples of places are: house, beach, New York, playground, the store" & Environment.NewLine
        temp &= "Things (can be physical things or ideas): chair, pencil, thoughts, memories, and knowledg" & Environment.NewLine
        temp &= "" & Environment.NewLine


        Return temp

    End Function

    'this function displays verb material
    Public Function displayverbs() As String
        Dim temp As String
        temp = "Verbs" & Environment.NewLine & Environment.NewLine

        temp &= "Verbs are action words! They are used to describe things that nouns do!" & Environment.NewLine
        temp &= "An example of a verb would be run. Run is a word to describe someone or something who is moving faster than a" & Environment.NewLine
        temp &= "walking speed." & Environment.NewLine
        temp &= "Other examples of verbs include: sing, watch, play, sleep, study, walk, and think." & Environment.NewLine
        temp &= "" & Environment.NewLine

        Return temp

    End Function

    'this function displays adjective material
    Public Function displayadjectives() As String
        Dim temp As String
        temp = "Adjectives" & Environment.NewLine & Environment.NewLine

        temp &= "Adjectives are describing words. They are used to describe nouns." & Environment.NewLine
        temp &= "An example of an adjective would be beautiful. Beautiful is a word to describe someone or" & Environment.NewLine
        temp &= "something. For example, the sky is beautiful. Since the sky is a noun, and beautiful is used to" & Environment.NewLine
        temp &= "describe it, that makes beautiful an adjective." & Environment.NewLine
        temp &= "Other examples of adjectives are: blue, dark, warm, happy, good, and fast." & Environment.NewLine
        temp &= "" & Environment.NewLine

        Return temp

    End Function

    'this function displays adverb material
    Public Function displayadverbs() As String
        Dim temp As String
        temp = "Adverbs" & Environment.NewLine & Environment.NewLine

        temp &= "Adverbs are words that describe verbs." & Environment.NewLine
        temp &= "For example, quickly is an adverb because if you say you walk quickly, walk is the verb, and" & Environment.NewLine
        temp &= "quickly is describing how you walk. Therefore, quickly is an adverb. An easy way to spot an" & Environment.NewLine
        temp &= "adverb is by their ending, since they often end in the letters ly, like quickly." & Environment.NewLine
        temp &= "Other examples of adverbs include: nicely, proudly, slowly, and firmly." & Environment.NewLine
        temp &= "" & Environment.NewLine
        temp &= "" & Environment.NewLine
        temp &= "" & Environment.NewLine


        Return temp

    End Function

End Class
