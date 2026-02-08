Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock

Public Class Form2

    Function GetInput(display As String, title As String) As String
        Return InputBox(display, title)
    End Function

    Function GetScore(display As String) As Double
        Dim handleInput As String = InputBox(display, "Score Entry (60-100)")
        Dim score As Double

        If Double.TryParse(handleInput, score) AndAlso score >= 60 AndAlso score <= 100 Then
            Return score
        Else
            MsgBox("Invalid input! Please enter a score between 60 and 100.", MsgBoxStyle.Exclamation, "Incorrect Input")
            Return GetScore(display)
        End If
    End Function

    Function ComputeCS(mq1 As Double, mq2 As Double, mq3 As Double, ml1 As Double, ml2 As Double, ml3 As Double) As Double
        Dim avgQuiz As Double = (mq1 + mq2 + mq3) / 3
        Dim avgLab As Double = (ml1 + ml2 + ml3) / 3
        Return (avgQuiz * (2 / 3)) + (avgLab * (1 / 3))
    End Function

    Function ComputeMG(cs As Double, meGrade As Double) As Double
        Return (cs * (2 / 3)) + (meGrade * (1 / 3))
    End Function

    Function GetPointGrade(grade As Double) As Double
        If grade >= 98 Then
            Return 1.0
        ElseIf grade >= 95 Then
            Return 1.25
        ElseIf grade >= 92 Then
            Return 1.5
        ElseIf grade >= 89 Then
            Return 1.75
        ElseIf grade >= 86 Then
            Return 2.0
        ElseIf grade >= 83 Then
            Return 2.25
        ElseIf grade >= 80 Then
            Return 2.5
        ElseIf grade >= 77 Then
            Return 2.75
        ElseIf grade >= 75 Then
            Return 3.0
        ElseIf grade >= 72 Then
            Return 4.0
        Else
            Return 5.0
        End If
    End Function

    Function GetRemark(point As Double) As String
        If point <= 3.0 Then
            Return "PASSED"
        Else
            Return "FAILED"
        End If
    End Function

    Private Sub BtnCompute_Click(sender As Object, e As EventArgs) Handles BtnCompute.Click
        Dim studname As String = GetInput("Enter Student Name:", "Student Name")
        Dim ID As String = GetInput("Enter ID Number:", "Your ID")

        Dim mq1 As Double = GetScore("Enter Midterm Quiz 1:")
        Dim mq2 As Double = GetScore("Enter Midterm Quiz 2:")
        Dim mq3 As Double = GetScore("Enter Midterm Quiz 3:")
        Dim ml1 As Double = GetScore("Enter Lab 1:")
        Dim ml2 As Double = GetScore("Enter Lab 2:")
        Dim ml3 As Double = GetScore("Enter Lab 3:")
        Dim exam As Double = GetScore("Enter Midterm Exam:")

        Dim classStanding As Double = ComputeCS(mq1, mq2, mq3, ml1, ml2, ml3)
        Dim midtermGrade As Double = ComputeMG(classStanding, exam)
        Dim pointGrade As Double = GetPointGrade(midtermGrade)
        Dim remark As String = GetRemark(pointGrade)

        TxtStud.Text = studname
        TxtID.Text = ID
        TxtMidterm.Text = Format(midtermGrade, "0.00") & "%"
        TxtPointGrade.Text = Format(pointGrade, "0.00")
        TxtRemark.Text = remark

        TxtME.Text = exam
        TxtQ1.Text = mq1
        TxtQ2.Text = mq2
        TxtQ3.Text = mq3
        TxtL1.Text = ml1
        TxtL2.Text = ml2
        TxtL3.Text = ml3


        Dim outputMsg As String = "Student Name: " & studname & vbCrLf &
                                  "ID Number: " & ID & vbCrLf &
                                  "Midterm Grade: " & Format(midtermGrade, "0.00") & "%" & vbCrLf &
                                  "Point Grade: " & Format(pointGrade, "0.00") & vbCrLf &
                                  "Remark: " & remark

        MsgBox(outputMsg, MsgBoxStyle.Information, "Student Result")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class
