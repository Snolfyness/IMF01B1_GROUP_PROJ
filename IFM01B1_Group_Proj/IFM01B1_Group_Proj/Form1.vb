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

Public Class frmELearning
    Private subjects() As Subject
    Private nsubjects As Integer

    'this button displays the learning material of whatever subjet the learner chooses
    Private Sub btnLearnMaterial_Click(sender As Object, e As EventArgs) Handles btnLearnMaterial.Click
        nsubjects += 1
        ReDim Preserve subjects(nsubjects)

        Dim subject As Integer = CInt(InputBox("Which subject would you like to study?" & Environment.NewLine & "Options: " & Environment.NewLine & "1 - Math" & Environment.NewLine & "2 - English" & Environment.NewLine & "3 - Natural Science"))

        Dim mark As Integer

        'Choices for the learning material

        Select Case subject


            Case 1 ' mathematics
                txtdisplay.Clear()
                Dim chapter As Integer = CInt(InputBox("Which chapter would you like to focus on?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Addition" & Environment.NewLine & "2 - Subtraction" & Environment.NewLine & "3 - Multiplication" & Environment.NewLine & "4 - Division"))
                Dim maths As Math
                maths = New Math(subject, mark, chapter)
                subjects(nsubjects) = maths
                txtdisplay.Text &= maths.displayLearningmaterial()

            Case 2 'english
                txtdisplay.Clear()
                Dim chapter As Integer = CInt(InputBox("Which chapter would you like to focus on?" & Environment.NewLine & "Options:" & Environment.NewLine & "1 - Literature" & Environment.NewLine & "2 - Poems" & Environment.NewLine & "3 - " & Environment.NewLine & "4 - Division"))


        End Select

        'this is polymorphism


    End Sub

    Private Sub btnQuiz_Click(sender As Object, e As EventArgs) Handles btnQuiz.Click

    End Sub
End Class