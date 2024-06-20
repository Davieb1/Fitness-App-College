Public Class BMI

    ' Declares the variables used within the page for Height, Weight & Total
    Dim height As Double
    Dim weight As Double
    Dim total As Double

    ' Event handler for Exit button click
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the page
        Close()
    End Sub

    ' Event handler for Reset button click
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Resets the content in each box to be cleared
        txtHeight.Clear()
        txtWeight.Clear()
        txtBMI.Text = ""
        ' Reset the radio buttons to unselected state
        rbtnMetric.Checked = False
        rbtnImperial.Checked = False
        ' Reset the BMI text box background color to default
        txtBMI.BackColor = SystemColors.Window
    End Sub

    ' Event handler for Calculate BMI button click
    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        ' Validate the measurement system selection
        If Not rbtnMetric.Checked And Not rbtnImperial.Checked Then
            ' Show a message box if no measurement system is selected
            MsgBox("Please select a measurement system (Metric or Imperial).")
            Return
        End If

        ' Validate and parse height input
        If Not Double.TryParse(txtHeight.Text, height) Then
            ' Show a message box if height input is invalid
            MsgBox("Please enter a valid height.")
            Return
        End If

        ' Validate and parse weight input
        If Not Double.TryParse(txtWeight.Text, weight) Then
            ' Show a message box if weight input is invalid
            MsgBox("Please enter a valid weight.")
            Return
        End If

        ' Calculate BMI based on the selected measurement system
        If rbtnMetric.Checked Then
            ' Metric system (height in meters, weight in kg)
            total = weight / (height * height)
        ElseIf rbtnImperial.Checked Then
            ' Imperial system (height in inches, weight in lbs)
            total = (weight * 703) / (height * height)
        End If

        ' Display the BMI result in the text box
        txtBMI.Text = String.Format("{0:f}", total)

        ' Color code the BMI result based on the BMI value
        If total <= 18.5 Then
            ' Underweight category
            txtBMI.BackColor = Color.Gold
        ElseIf total < 24.9 Then
            ' Normal weight category
            txtBMI.BackColor = Color.Green
        ElseIf total < 29.9 Then
            ' Overweight category
            txtBMI.BackColor = Color.Orange
        ElseIf total >= 30 Then
            ' Obesity category
            txtBMI.BackColor = Color.Red
        End If
    End Sub

    ' Event handler for Calorie Counter button click
    Private Sub btnCalorieCounter_Click(sender As Object, e As EventArgs) Handles btnCalorieCounter.Click
        ' Shows the Calorie Counter page and hides the current page to keep the screen clean and tidy
        calorieCounter.Show()
        Me.Hide()
    End Sub

    ' Event handler for Report button click
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        ' Shows the Report page and hides the current page to keep the screen clean and tidy
        Report.Show()
        Me.Hide()
    End Sub

    ' Event handler for Diary button click
    Private Sub btnDiary_Click(sender As Object, e As EventArgs) Handles btnDiary.Click
        ' Shows the Diary page and hides the current page to keep the screen clean and tidy
        Diary.Show()
        Me.Hide()
    End Sub

    ' Event handler for Form1 button click
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Shows the Form1 page and hides the current page to keep the screen clean and tidy
        Form1.Show()
        Me.Hide()
    End Sub

End Class
