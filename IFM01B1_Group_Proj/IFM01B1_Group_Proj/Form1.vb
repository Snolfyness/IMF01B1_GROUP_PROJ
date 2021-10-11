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

Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class frmELearning
    Friend Class Helper
    End Class

    Private subjects() As Subject
    Private nsubjects As Integer
    Private file As FileStream
    Private BF As BinaryFormatter
    Private filename As String = "SaveAnswers.IFM"

    'this button displays the learning material of whatever subjet the learner chooses
    Private Sub btnLearnMaterial_Click(sender As Object, e As EventArgs) Handles btnLearnMaterial.Click
        nsubjects += 1
        ReDim Preserve subjects(nsubjects)

        Dim subject As Integer = CInt(InputBox("Which subject would you like to study?" & Environment.NewLine & "Options: " & Environment.NewLine & "1 - Math" & Environment.NewLine & "2 - English" & Environment.NewLine))

        Dim mark As Integer

        'Choices for the learning material

        Select Case subject

            Case 1 ' mathematics
                txtdisplay.Clear()
                Dim chapter As Integer = CInt(InputBox("Which chapter would you like to focus on?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Addition" & Environment.NewLine & "2 - Subtraction" & Environment.NewLine & "3 - Multiplication" & Environment.NewLine & "4 - Division"))
                Dim maths As math
                Dim type As String = "Maths"
                Dim opt As Integer
                maths = New math(subject, mark, chapter, type, opt)
                subjects(nsubjects) = maths
                txtdisplay.Text &= maths.displayLearningmaterial()

            Case 2 'english
                txtdisplay.Clear()
                Dim chapter As Integer = CInt(InputBox("Which chapter would you like to focus on?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Nouns" & Environment.NewLine & "2 - Verbs" & Environment.NewLine & "3 - Adjectives" & Environment.NewLine & "4 - Adverbs"))
                Dim Eng As English
                Dim type As String = "English"
                Eng = New English(subject, mark, chapter, type)
                subjects(nsubjects) = Eng
                txtdisplay.Text &= Eng.displayLearningmaterial()
        End Select




    End Sub

    'this is the quiz function that is randomized
    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        txtdisplay.Clear()
        Dim choice As Integer
        Dim display As String
        choice = CInt(InputBox("Which Quiz would you like to take? " & Environment.NewLine & "Options:  " & Environment.NewLine & "1 - Math" & Environment.NewLine & "2 - English"))
        Select Case choice
            Case 1 'Maths
                Dim Quiz(10) As MathQuestion
                Dim mark As Integer = 0
                For q As Integer = 1 To 10
                    Dim temp As String
                    Dim question As Integer

                    'question will always be 0, 1, 2 or 3
                    question = q Mod 4

                    Quiz(q) = New MathQuestion(question, mark)
                    Dim type As String = "Maths"
                    temp = InputBox("Answer for: " & Quiz(q).Question)
                    display = Quiz(q).Question & Environment.NewLine
                    display &= "Answer: " & Quiz(q).Answer & Environment.NewLine

                    If Quiz(q).CheckAnswer(CInt(temp)) Then
                        mark += 1
                        display &= "Correct Answer: Marks " & Environment.NewLine
                    Else
                        display &= "Incorrect Answer: Marks " & Environment.NewLine
                    End If
                    display &= "Marks: " & mark & "/10" & Environment.NewLine
                    txtdisplay.Text = display
                Next

            Case 2 'English
                Dim Quiz As EnglishQuestion
                Dim ans(4) As Integer
                Dim type As String = "English"
                ans(1) = 1
                ans(2) = 2
                ans(3) = 1
                ans(4) = 1
                Dim mark As Integer = 0
                Dim name As String = "Math"
                Quiz = New EnglishQuestion(mark)

                Dim temp As String = ""

                Dim question(4) As Integer


                txtdisplay.Clear()
                txtdisplay.Text = Quiz.displayquiz()

                For q As Integer = 1 To 4
                    question(q) = CInt(InputBox("What is the answer for Question " & CStr(q) & " ?", "Question " & CStr(q)))

                    If question(q) = ans(q) Then
                        mark += 1
                        temp &= CStr(q) & ") Correct " & Environment.NewLine
                    Else
                        temp &= CStr(q) & ") Incorredct Answer " & Environment.NewLine


                    End If


                Next q
                MsgBox("Quiz completed")
                txtdisplay.Clear()
                temp &= "Marks: " & mark & "/4" & Environment.NewLine
                txtdisplay.Text = temp



                'if the user enters an invalid option
            Case Else
                txtdisplay.Text = "Please enter a valid option" & Environment.NewLine
        End Select


        'this is polymorphism

        For i As Integer = 1 To nsubjects
            txtdisplay.Text &= subjects(i).displayresults() & Environment.NewLine
        Next i

    End Sub

    'this is the button that allows the user to save their marks
    Private Sub btnSaveMarks_Click(sender As Object, e As EventArgs) Handles btnSaveMarks.Click
        file = New FileStream(filename, FileMode.Create, FileAccess.Write)
        BF = New BinaryFormatter()
        For h As Integer = 1 To nsubjects

            BF.Serialize(file, subjects(h))
        Next h
        file.Close()

        file = Nothing
        BF = Nothing

        MsgBox("File was saved")
    End Sub

    'this button allows the user to view their results
    Private Sub btnViewMarks_Click(sender As Object, e As EventArgs) Handles btnViewMarks.Click
        txtdisplay.Clear()
        file = New FileStream(filename, FileMode.Open, FileAccess.Read)
        BF = New BinaryFormatter()
        While file.Position < file.Length
            Dim s As Subject
            s = DirectCast(BF.Deserialize(file), Subject)
            txtdisplay.Text &= s.displayresults() & Environment.NewLine
        End While

        file.Close()

    End Sub

    Private Sub btnBestMark_Click(sender As Object, e As EventArgs) Handles btnBestMark.Click

    End Sub
End Class