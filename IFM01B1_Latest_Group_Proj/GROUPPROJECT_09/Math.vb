' *****************************************************************
' Team Number: assigned to team
' Team Member 1 Details: Lin, J (221179979)
' Team Member 2 Details: Khosa, MTS (221080579)
' Team Member 3 Details: Rasalanavho, R (220054293)
' Team Member 4 Details: none
' Practical: Team Project
' Class name: LearningMaterial
' *****************************************************************
Option Explicit On
Option Strict On
Option Infer Off

<Serializable> Public Class Math
    Inherits subject
    Private _choice As Integer
    Private _question As String
    Private _answer As Integer



    'these are the property methods

    Public Property question As String
        Get
            Return _question
        End Get
        Set(value As String)
            _question = value
        End Set
    End Property

    Public Property answer As Integer
        Get
            Return _answer
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property choice As Integer
        Get
            Return _choice
        End Get
        Set(value As Integer)
            _choice = validate(value)
        End Set
    End Property

    'this is the constructor
    Public Sub New(name As String, mark As Integer, choice As Integer)
        MyBase.New(name, mark)
        Me.choice = choice
        Me.mark = mark
        Select Case choice
            Case 0
                GenerateAddition()
            Case 1
                GenerateSubtraction()
            Case 2
                GenerateMultiplication()
            Case 3
                GenerateDivision()
            Case Else
                MsgBox("Please select a valid option")
        End Select

    End Sub

    'this functions displays the learning material
    Public Overrides Function displayLearningmaterial() As String
        Select Case choice
            Case 1 ' addition
                Return displayaddition()

            Case 2 ' subtraction
                Return displaySubtraction()

            Case 3 ' multiplication
                Return displaymultiplication()

            Case 4 ' division
                Return displaydivision()


        End Select
    End Function






    'this function displays addition material
    Public Function displayaddition() As String
        Dim temp As String
        temp = "Chapter 1 - Addition" & Environment.NewLine & Environment.NewLine

        temp &= "Addition is when you add one or more Numbers together for example:" & Environment.NewLine
        temp &= "When you add 1 and 1 you get 2" & "Please note that the symbol for addition is ( + ) " & Environment.NewLine
        temp &= "Mathematically this can be written as ( 1 + 1 = 2)" & Environment.NewLine & Environment.NewLine
        temp &= "More examples Include:" & Environment.NewLine
        temp &= "2 + 3 = 5" & Environment.NewLine
        temp &= "20 + 30 = 50" & Environment.NewLine
        temp &= "200 + 300 = 500" & Environment.NewLine & Environment.NewLine

        Return temp

    End Function

    'this function displays subtraction material
    Public Function displaySubtraction() As String
        Dim temp As String
        temp = "Chapter 2 - Subtraction" & Environment.NewLine & Environment.NewLine

        temp &= "Subtraction is when you minus a smaller number from a bigger number for example:" & Environment.NewLine
        temp &= "When you Minus 5 from 6" & "Please note that the symbol for subtraction is ( - ) " & Environment.NewLine
        temp &= "Mathematically this can be written as ( 6 - 5 = 1)" & Environment.NewLine & Environment.NewLine
        temp &= "More examples Include:" & Environment.NewLine
        temp &= "1 - 1 = 0" & Environment.NewLine
        temp &= "5 - 2 = 3" & Environment.NewLine
        temp &= "1000 - 500 = 500" & Environment.NewLine & Environment.NewLine

        Return temp

    End Function

    'this function displays multiplication material
    Public Function displaymultiplication() As String
        Dim temp As String
        temp = "Chapter 3 - multiplication" & Environment.NewLine & Environment.NewLine

        temp &= "multiplication is when you take one number and multiply by another number for example:" & Environment.NewLine
        temp &= "When you multiply 2 and 3 you get 6" & "Please note that the symbol for multiplication is ( - ) " & Environment.NewLine
        temp &= "This is done by taking the 2 and adding it by itself 3 times" & Environment.NewLine
        temp &= "Mathematically this can be written as ( 2 * 3 = 6)" & Environment.NewLine
        temp &= "To simply it for you, you can also write it as ( 2 + 2 + 2 = 6)" & Environment.NewLine
        temp &= "Notice that the 2 was added to itself 3 times, showing that multiplication is just addition simplified"
        temp &= "More examples Include:" & Environment.NewLine
        temp &= "2 * 1 = 2" & Environment.NewLine
        temp &= "1 * 0 = 0" & Environment.NewLine
        temp &= "100 * 2 = 200" & Environment.NewLine
        temp &= "10 * 3 = 30" & Environment.NewLine & Environment.NewLine

        Return temp

    End Function

    'this function displays division material
    Public Function displaydivision() As String
        Dim temp As String
        temp = "Chapter 4 - Division" & Environment.NewLine & Environment.NewLine

        temp &= "Division is when you take a bugger number and divide it by a smaller number, for example:" & Environment.NewLine
        temp &= "When you divide 2 by 1 you get 2" & "Please note that the symbol for division is ( / ) " & Environment.NewLine
        temp &= "This is done by taking the 1 and checking to see how many 1s are in a 2" & Environment.NewLine
        temp &= "Mathematically this can be written as ( 2 / 1 = 2)" & Environment.NewLine
        temp &= "Please make sure that the smaller number is the one that divides the bigger number" & Environment.NewLine
        temp &= "Notice that the 1 + 1 = 2, Meaning that a 2 is composed of two 1s"
        temp &= "More examples Include:" & Environment.NewLine
        temp &= "2 / 1 = 2" & Environment.NewLine
        temp &= "2 / 0 = undefined or Irrational" & Environment.NewLine
        temp &= "100 / 2 = 50" & Environment.NewLine
        temp &= "10 / 4 = 25" & Environment.NewLine & Environment.NewLine

        Return temp

    End Function


    'this is the quiz side


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

    'this function displays the results
    Public Overrides Function displayresults() As String

        Dim temp As String

        temp = "Results" & Environment.NewLine & Environment.NewLine
        temp &= "Quize type: " & name & " Quiz" & Environment.NewLine
        temp &= "Marks: " & CStr(mark) & "/ 10" & Environment.NewLine

        Return temp

    End Function
End Class
