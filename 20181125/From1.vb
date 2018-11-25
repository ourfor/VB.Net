Public Class Form1
    Private Score() = {89, -23, 64, 91, 119, 52, 73}
    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        SortScore(Score)
        tbDisplay.Text = Array(Score)
        MessageBox.Show("输入一个x的值，计算关于x的分段函数的值:")
        Dim xInput As Double
        xInput = InputBox("x=?")
        tbDisplay.Text = MultiFunction(xInput).ToString


    End Sub

    Function SortScore(ByRef Score As Object()) As Object()
        Dim intTemp As Integer

        For index1 As Integer = Score.Length - 2 To 1 Step -1
            For index2 As Integer = 0 To index1 Step 1
                If Score(index2) > Score(index2 + 1) Then
                    intTemp = Score(index2 + 1)
                    Score(index2 + 1) = Score(index2)
                    Score(index2) = intTemp
                End If
            Next index2
        Next index1

        Return Score
    End Function

    Function Array(ByVal a As Object()) As String
        Dim StrDisplay As String = ""
        For Each index As Integer In a
            StrDisplay += index.ToString + " "
        Next index
        Return StrDisplay
    End Function

    Function MultiFunction(ByVal x As Double) As Double
        If x < 0 Then
            Return 1
        ElseIf x >= 0 And x < 100 Then
            Return x + 2
        ElseIf x >= 100 And x < 1000 Then
            Return 2 * x / (3 * x + 2)
        Else
            Return Math.Sqrt(3 * x * x - x)
        End If

    End Function
End Class
