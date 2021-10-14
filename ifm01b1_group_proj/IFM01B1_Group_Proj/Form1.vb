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
    'these are the attributes

    Private subjects() As subject
    Private nsubjects As Integer
    Private filename As String = "subject.Ifm"
    Private file As FileStream
    Private bf As BinaryFormatter


    'this button allows the user to view learning material
    Private Sub btnLearnMaterial_Click(sender As Object, e As EventArgs) Handles btnLearnMaterial.Click
        nsubjects += 1
        ReDim Preserve subjects(nsubjects)

        Dim choise As Integer = CInt(InputBox("Which subject would you like to study?" & Environment.NewLine & "Options: " & Environment.NewLine & "1 - Math" & Environment.NewLine & "2 - English" & Environment.NewLine))
        Select Case choise

            Case 1 ' mathematics
                txtdisplay.Clear()
                Dim chapter As Integer = CInt(InputBox("Which chapter would you like to focus on?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Addition" & Environment.NewLine & "2 - Subtraction" & Environment.NewLine & "3 - Multiplication" & Environment.NewLine & "4 - Division"))
                Dim maths As Math
                Dim type As String = "Maths"
                Dim opt As Integer = 1
                maths = New Math(type, choise, chapter)
                subjects(nsubjects) = maths
                txtdisplay.Text &= maths.displayLearningmaterial()

            Case 2 'english
                txtdisplay.Clear()
                Dim chapter As Integer = CInt(InputBox("Which chapter would you like to focus on?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Nouns" & Environment.NewLine & "2 - Verbs" & Environment.NewLine & "3 - Adjectives" & Environment.NewLine & "4 - Adverbs"))
                Dim Eng As English
                Dim mark As Integer = 1
                Dim type As String = "English"
                Eng = New English(Name, mark, choise)
                subjects(nsubjects) = Eng
                txtdisplay.Text &= Eng.displayLearningmaterial()
        End Select

        nsubjects -= 1
        ReDim Preserve subjects(nsubjects)

    End Sub


    'this button allows the user to take the quiz
    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click
        txtdisplay.Clear()
        nsubjects += 1
        ReDim Preserve subjects(nsubjects)
        Dim choice As Integer = 1
        Dim opt As Integer = CInt(InputBox("Which Quiz would you like to take? " & Environment.NewLine & "Options:  " & Environment.NewLine & "1 - English" & Environment.NewLine & "2 - Mathematics"))

        Select Case opt
            Case 1
                Dim eng As English
                Dim mark As Integer
                Dim temp As String = ""
                Dim ans(4) As Integer
                ans(1) = 1
                ans(2) = 2
                ans(3) = 1
                ans(4) = 1
                Dim name As String = "English"
                Dim question(4) As Integer

                eng = New English(name, mark, choice)
                subjects(nsubjects) = eng
                txtdisplay.Text &= eng.displayquiz()

                For q As Integer = 1 To 4
                    question(q) = CInt(InputBox("What is the answer for Question " & CStr(q) & " ?", "Question " & CStr(q)))

                    If question(q) = ans(q) Then
                        mark += 1
                        temp &= CStr(q) & ") Correct " & Environment.NewLine
                    Else
                        temp &= CStr(q) & ") Incorredct Answer " & Environment.NewLine


                    End If


                Next q

                eng = New English(name, mark, choice)
                subjects(nsubjects) = eng
                txtdisplay.Text &= eng.displayquiz()


            Case 2 ' maths



                Dim Quiz(10) As Math
                Dim mark As Integer = 0
                Dim type As String = "Maths"

                For q As Integer = 1 To 10
                    Dim temp As String
                    Dim question As Integer
                    Dim display As String
                    'question will always be 0, 1, 2 or 3
                    question = q Mod 4

                    Quiz(q) = New Math(type, mark, question)


                    temp = InputBox("Answer for: " & Quiz(q).question)
                    display = Quiz(q).question & Environment.NewLine
                    display &= "Answer: " & Quiz(q).answer & Environment.NewLine

                    If Quiz(q).CheckAnswer(CInt(temp)) Then
                        mark += 1
                        display &= "Correct Answer: Marks " & Environment.NewLine
                    Else
                        display &= "Incorrect Answer: Marks " & Environment.NewLine
                    End If
                    display &= "Marks: " & mark & "/10" & Environment.NewLine
                    txtdisplay.Text = display

                    subjects(nsubjects) = Quiz(q)
                Next q



            Case Else
                txtdisplay.Text = "Please enter a valid option" & Environment.NewLine



        End Select

        'polimorphism
        txtdisplay.Clear()
        For i As Integer = 1 To nsubjects
            txtdisplay.Text &= subjects(i).displayresults() & Environment.NewLine
        Next
    End Sub

    'this button saves the marks
    Private Sub btnSaveMarks_Click(sender As Object, e As EventArgs) Handles btnSaveMarks.Click
        file = New FileStream(filename, FileMode.Create, FileAccess.Write)
        bf = New BinaryFormatter()

        For I As Integer = 1 To nsubjects
            bf.Serialize(file, subjects(I))
        Next

        file.Close()
        file = Nothing
        bf = Nothing

        MsgBox("File was saved")
        txtdisplay.Clear()
    End Sub

    'this button allows the user to view the marks
    Private Sub btnViewMarks_Click(sender As Object, e As EventArgs) Handles btnViewMarks.Click
        txtdisplay.Clear()
        file = New FileStream(filename, FileMode.Open, FileAccess.Read)
        bf = New BinaryFormatter()

        While file.Position < file.Length

            Dim s As subject
            s = DirectCast(bf.Deserialize(file), subject)
            txtdisplay.Text &= s.displayresults() & Environment.NewLine


        End While

        file.Close()
    End Sub
End Class