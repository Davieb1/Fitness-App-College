Public Class calorieCounter

    ' Declared and initialised at Global level 
    Private totalCalories As Integer = 0

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ' Closes the page
        Close()
    End Sub

    Private Sub PictureBox_95_Click(sender As Object, e As EventArgs) Handles PictureBox_95.Click

        ' Adds the value to the total calories box & adds any other items together to give a total amount of calories
        totalCalories += 95
        lblTotalCalories.Text = totalCalories.ToString()

        MessageBox.Show("This can be redesigned to take a larger menu by introducing a drop down menu with extensive food options to choose from. Such as the design of a McDonalds menu")
    End Sub

    Private Sub PictureBox117_Click(sender As Object, e As EventArgs) Handles PictureBox_117.Click

        ' Adds the value to the total calories box & adds any other items together to give a total amount of calories
        totalCalories += 117
        lblTotalCalories.Text = totalCalories.ToString()
    End Sub

    Private Sub PictureBox_69_Click(sender As Object, e As EventArgs) Handles PictureBox_69.Click

        ' Adds the value to the total calories box & adds any other items together to give a total amount of calories
        totalCalories += 69
        lblTotalCalories.Text = totalCalories.ToString()
    End Sub

    Private Sub PictureBox_670_Click(sender As Object, e As EventArgs) Handles PictureBox_670.Click

        ' Adds the value to the total calories box & adds any other items together to give a total amount of calories
        totalCalories += 670
        lblTotalCalories.Text = totalCalories.ToString()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' Clears and reset the total calories box to zero 0
        totalCalories = 0
        lblTotalCalories.Text = "0"

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        ' Shows the new page when the buttons has been clicked
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub btnDiary_Click(sender As Object, e As EventArgs) Handles btnDiary.Click

        ' Shows the new page when the buttons has been clicked
        Diary.Show()
        Me.Hide()
    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click

        ' Shows the new page when the buttons has been clicked
        BMI.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Shows the new page when the buttons has been clicked
        Form1.Show()
        Me.Hide()
    End Sub
End Class