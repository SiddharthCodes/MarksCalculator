Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare variables and input values
        Dim marks(4) As Double
        marks(0) = Val(TextBox1.Text) ' Physics
        marks(1) = Val(TextBox2.Text) ' Chemistry
        marks(2) = Val(TextBox3.Text) ' Biology
        marks(3) = Val(TextBox4.Text) ' Mathematics
        marks(4) = Val(TextBox5.Text) ' Computer

        ' Calculate total and percentage
        Dim total As Double = marks.Sum()
        Dim percentage As Double = (total / 500) * 100

        ' Display percentage
        Label6.Text = "Percentage: " & percentage.ToString("F2") & "%"

        ' Determine grade
        Dim grade As String = If(percentage >= 90, "A", If(percentage >= 80, "B", If(percentage >= 70, "C", If(percentage >= 60, "D", If(percentage >= 40, "E", "F")))))
        Label7.Text = "Grade: " & grade
    End Sub
End Class
