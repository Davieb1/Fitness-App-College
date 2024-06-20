Public Class Report

    ' Creates an array holding user weights that include floats
    Dim weights() As Double = {30, 55.5, 47.5, 78.3}

    ' List to store the saved report details
    Private savedReports As New List(Of String)

    ' Event handler for form load
    Private Sub ReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Add controls to the form
        InitializeControls()
    End Sub

    ' Initialize and add controls to the form
    Private Sub InitializeControls()
        ' Add labels
        Dim lblDateRange As New Label()
        lblDateRange.Text = "Date Range:"
        lblDateRange.AutoSize = True
        lblDateRange.Location = New Point(10, 10)
        Me.Controls.Add(lblDateRange)

        ' Add Date Picker
        Dim datePicker As New DateTimePicker()
        datePicker.Format = DateTimePickerFormat.Short
        datePicker.Location = New Point(lblDateRange.Right + 10, 10)
        datePicker.Name = "datePicker" ' Name the date picker for easy reference
        Me.Controls.Add(datePicker)

        ' Add Generate Report Button
        Dim btnGenerateReport As New Button()
        btnGenerateReport.Text = "Generate Report"
        btnGenerateReport.Location = New Point(datePicker.Right + 10, 5)
        AddHandler btnGenerateReport.Click, AddressOf btnGenerateReport_Click
        Me.Controls.Add(btnGenerateReport)

        ' Add BMI Information Section
        Dim lblBMIInfo As New Label()
        lblBMIInfo.Text = "BMI Information"
        lblBMIInfo.Font = New Font(lblBMIInfo.Font, FontStyle.Bold)
        lblBMIInfo.Location = New Point(10, lblDateRange.Bottom + 20)
        Me.Controls.Add(lblBMIInfo)

        ' Add ListView for BMI Data
        Dim listViewBMI As New ListView()
        listViewBMI.View = View.Details
        listViewBMI.Columns.Add("Date", 100)
        listViewBMI.Columns.Add("BMI", 100)
        listViewBMI.Columns.Add("Notes", 200)
        listViewBMI.FullRowSelect = True
        listViewBMI.GridLines = True
        listViewBMI.Location = New Point(10, lblBMIInfo.Bottom + 10)
        listViewBMI.Size = New Size(400, 150)
        listViewBMI.Name = "listViewBMI" ' Name the ListView for easy reference
        Me.Controls.Add(listViewBMI)

        ' Add TextBox for BMI Details
        Dim txtBMIDetails As New TextBox()
        txtBMIDetails.Multiline = True
        txtBMIDetails.ScrollBars = ScrollBars.Vertical
        txtBMIDetails.Location = New Point(listViewBMI.Right + 10, lblBMIInfo.Bottom + 10)
        txtBMIDetails.Size = New Size(300, 150)
        txtBMIDetails.Name = "txtBMIDetails" ' Name the TextBox for easy reference
        Me.Controls.Add(txtBMIDetails)

        ' Add Save Button
        Dim btnSave As New Button()
        btnSave.Text = "Save Report"
        btnSave.Location = New Point(10, Math.Max(listViewBMI.Bottom, txtBMIDetails.Bottom) + 20)
        btnSave.BackColor = Color.Green
        AddHandler btnSave.Click, AddressOf btnSave_Click
        Me.Controls.Add(btnSave)

        ' Add Clear Button
        Dim btnClear As New Button()
        btnClear.Text = "Clear Report"
        btnClear.Location = New Point(btnSave.Right + 10, Math.Max(listViewBMI.Bottom, txtBMIDetails.Bottom) + 20)
        AddHandler btnClear.Click, AddressOf btnClear_Click
        Me.Controls.Add(btnClear)

        ' Add Reload Button
        Dim btnReload As New Button()
        btnReload.Text = "Reload Report"
        btnReload.Location = New Point(btnClear.Right + 10, Math.Max(listViewBMI.Bottom, txtBMIDetails.Bottom) + 20)
        AddHandler btnReload.Click, AddressOf btnReload_Click
        Me.Controls.Add(btnReload)

        ' Adds label for min weight 
        Dim lblMinWeight As New Label()
        lblMinWeight.Text = "Displays the minimum weight:"
        lblMinWeight.AutoSize = True
        lblMinWeight.Location = New Point(10, btnSave.Bottom + 10)
        Me.Controls.Add(lblMinWeight)

        ' Adds  button for min weight 
        Dim btnMin As New Button()
        btnMin.Text = "Min Weight"
        btnMin.Location = New Point(lblMinWeight.Right + 10, lblMinWeight.Top - 5)
        AddHandler btnMin.Click, AddressOf btnMin_Click
        Me.Controls.Add(btnMin)

        ' Adds label for max weight
        Dim lblMaxWeight As New Label()
        lblMaxWeight.Text = "Displays the maximum weight:"
        lblMaxWeight.AutoSize = True
        lblMaxWeight.Location = New Point(10, lblMinWeight.Bottom + 10)
        Me.Controls.Add(lblMaxWeight)

        ' Adds buttons for max weight 
        Dim btnMax As New Button()
        btnMax.Text = "Max Weight"
        btnMax.Location = New Point(lblMaxWeight.Right + 10, lblMaxWeight.Top - 5)
        AddHandler btnMax.Click, AddressOf btnMaximum_Click
        Me.Controls.Add(btnMax)

        ' Adds label for average weight
        Dim lblAvgWeight As New Label()
        lblAvgWeight.Text = "Displays the average weight:"
        lblAvgWeight.AutoSize = True
        lblAvgWeight.Location = New Point(10, lblMaxWeight.Bottom + 10)
        Me.Controls.Add(lblAvgWeight)

        ' Adds buttons for average weight 
        Dim btnAverage As New Button()
        btnAverage.Text = "Average Weight"
        btnAverage.Location = New Point(lblAvgWeight.Right + 10, lblAvgWeight.Top - 5)
        AddHandler btnAverage.Click, AddressOf btnAverage_Click
        Me.Controls.Add(btnAverage)
    End Sub

    ' Event handler for Calorie Counter button click
    Private Sub btnFoodCounter_Click(sender As Object, e As EventArgs) Handles btnFoodCounter.Click
        ' Shows the Calorie Counter page and hides the current page to keep the screen clean and tidy
        calorieCounter.Show()
        Me.Hide()
    End Sub

    ' Event handler for BMI button click
    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click
        ' Shows the BMI page and hides the current page to keep the screen clean and tidy
        BMI.Show()
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

    ' Event handler for Generate Report button click
    Private Sub btnGenerateReport_Click(sender As Object, e As EventArgs)
        ' Get the selected date from the DateTimePicker
        Dim selectedDate As String = Me.Controls.OfType(Of DateTimePicker)().FirstOrDefault(Function(d) d.Name = "datePicker").Value.ToShortDateString()

        ' Example code to populate the ListView with BMI data
        Dim listViewBMI As ListView = Me.Controls.OfType(Of ListView)().FirstOrDefault(Function(l) l.Name = "listViewBMI")
        If listViewBMI IsNot Nothing Then
            listViewBMI.Items.Clear()
            listViewBMI.Items.Add(New ListViewItem({selectedDate, "22.5", "Normal weight"}))
            listViewBMI.Items.Add(New ListViewItem({selectedDate, "24.0", "Normal weight"}))
            listViewBMI.Items.Add(New ListViewItem({selectedDate, "26.5", "Overweight"}))
            listViewBMI.Items.Add(New ListViewItem({selectedDate, "29.0", "Overweight"}))
            listViewBMI.Items.Add(New ListViewItem({selectedDate, "17.0", "Underweight"}))
            listViewBMI.Items.Add(New ListViewItem({selectedDate, "16.0", "Underweight"}))
        End If

        ' Optional: Show a message box to explain the report
        MsgBox("The report has been generated and displayed in the list. It shows the BMI values over time along with notes.")
    End Sub

    ' Event handler for Save Report button click
    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        ' Save the details from the ListView to the TextBox for BMI Details
        Dim listViewBMI As ListView = Me.Controls.OfType(Of ListView)().FirstOrDefault(Function(l) l.Name = "listViewBMI")
        Dim txtBMIDetails As TextBox = Me.Controls.OfType(Of TextBox)().FirstOrDefault(Function(t) t.Multiline And t.Name = "txtBMIDetails")

        If listViewBMI IsNot Nothing AndAlso txtBMIDetails IsNot Nothing Then
            For Each item As ListViewItem In listViewBMI.Items
                Dim reportLine As String = String.Format("Date: {0}, BMI: {1}, Notes: {2}{3}", item.SubItems(0).Text, item.SubItems(1).Text, item.SubItems(2).Text, Environment.NewLine)
                txtBMIDetails.AppendText(reportLine)
                savedReports.Add(reportLine) ' Add to the saved reports list
            Next
        End If
    End Sub

    ' Event handler for Clear Report button click
    Private Sub btnClear_Click(sender As Object, e As EventArgs)
        ' Clear the ListView and TextBox for BMI Details
        Dim listViewBMI As ListView = Me.Controls.OfType(Of ListView)().FirstOrDefault(Function(l) l.Name = "listViewBMI")
        Dim txtBMIDetails As TextBox = Me.Controls.OfType(Of TextBox)().FirstOrDefault(Function(t) t.Multiline And t.Name = "txtBMIDetails")

        If listViewBMI IsNot Nothing Then
            listViewBMI.Items.Clear()
        End If

        If txtBMIDetails IsNot Nothing Then
            txtBMIDetails.Clear()
        End If
    End Sub

    ' Event handler for Reload Report button click
    Private Sub btnReload_Click(sender As Object, e As EventArgs)
        ' Reload the saved reports into the TextBox for BMI Details
        Dim txtBMIDetails As TextBox = Me.Controls.OfType(Of TextBox)().FirstOrDefault(Function(t) t.Multiline And t.Name = "txtBMIDetails")

        If txtBMIDetails IsNot Nothing Then
            txtBMIDetails.Clear()
            For Each reportLine As String In savedReports
                txtBMIDetails.AppendText(reportLine)
            Next
        End If
    End Sub

    ' Event handler for Max Weight button click
    Private Sub btnMaximum_Click(sender As Object, e As EventArgs)
        ' Finds and displays the maximum weight from the weights array
        Dim maxWeight As Double = FindMaxWeight()
        MessageBox.Show("This text has been genrated to show the Maximum weight." & vbCrLf & " The maximum weight is : " & maxWeight.ToString())
    End Sub

    ' Function to find the maximum weight
    Private Function FindMaxWeight() As Double
        ' Declares variable and initializes
        Dim maxWeight As Double = weights(0)

        ' Iterates through the weights array to find the maximum weight
        For Each weight As Double In weights
            If weight > maxWeight Then
                maxWeight = weight
            End If
        Next

        Return maxWeight
    End Function

    ' Event handler for Min Weight button click
    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        ' Finds and displays the minimum weight from the weights array
        Dim minWeight As Double = FindMinWeight()
        MessageBox.Show("This text has been genrated to show the minimum weight." & vbCrLf & " The Minimum Weight is : " & minWeight.ToString())
    End Sub

    ' Function to find the minimum weight
    Private Function FindMinWeight() As Double
        ' Declares the variable and initializes
        Dim minWeight As Double = weights(0)

        ' Iterates through the weights array to find the minimum weight
        For Each weight As Double In weights
            If weight < minWeight Then
                minWeight = weight
            End If
        Next

        Return minWeight
    End Function

    ' Event handler for Average Weight button click
    Private Sub btnAverage_Click(sender As Object, e As EventArgs)
        ' Finds and displays the average weight from the weights array
        Dim averageWeight As Double = CalculateAverageWeight()
        MessageBox.Show("This text has been genrated to show the average weight." & vbCrLf & " The Average Weight is: " & averageWeight.ToString())
    End Sub

    ' Function to calculate the average weight
    Private Function CalculateAverageWeight() As Double
        ' Declares the variable and initializes
        Dim totalWeight As Double = 0
        Dim counter As Integer = 0

        ' Iterates through the weights array to calculate the total weight
        For Each weight As Double In weights
            totalWeight += weight
            counter += 1
        Next

        ' Returns the average weight
        Return totalWeight / counter
    End Function

End Class
