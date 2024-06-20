Public Class Diary
    Private Sub lstBlogPosts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBlogPosts.SelectedIndexChanged
        ' Check if an item has been selected
        If lstBlogPosts.SelectedIndex <> -1 Then
            ' Get the selected entry from the ListBox
            Dim selectedEntry As String = lstBlogPosts.SelectedItem.ToString()

            ' Display the selected entry's content in the txtContent textbox
            ' Assuming each entry is in the format "Title: Content"
            ' You may need to adjust this based on how your entries are formatted
            Dim entryParts() As String = selectedEntry.Split(":")
            If entryParts.Length > 1 Then
                txtContent.Text = entryParts(1).Trim()
            Else
                ' If the entry format is different, display the entire selected entry
                txtContent.Text = selectedEntry
            End If

            ' Optionally, disable editing of the content
            txtContent.ReadOnly = True
        End If

    End Sub
    Private Sub AddOrUpdateBlogEntry(entry As String)
        ' Check if the entry already exists in the ListBox
        Dim index As Integer = lstBlogPosts.FindStringExact(entry)

        If index <> ListBox.NoMatches Then
            ' If the entry already exists, update it
            lstBlogPosts.Items(index) = entry
        Else
            ' If the entry doesn't exist, add it
            lstBlogPosts.Items.Add(entry)
        End If
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the title and content of the blog post from the text boxes
        Dim title As String = txtTitle.Text
        Dim content As String = txtContent.Text
        Dim message As String = ""

        title = txtTitle.Text
        content = txtContent.Text

        message = title + "_:_" + content
        ' Check if title or content is empty
        If String.IsNullOrWhiteSpace(title) OrElse String.IsNullOrWhiteSpace(content) Then
            MessageBox.Show("Please enter both title and content for the blog post.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Create a new instance of BlogPost
        Dim datePublished As DateTime = DateTime.Now
        Dim blogPost As New BlogPost(title, content, datePublished)

        ' Add the title of the saved blog post to the list box
        lstBlogPosts.Items.Add(blogPost.Title)

        ' Clear the text boxes
        txtTitle.Clear()
        txtContent.Clear()

        ' Display a confirmation message
        MessageBox.Show("Blog post saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the page 
        Close()
    End Sub

    Private Sub btnFoodCounter_Click(sender As Object, e As EventArgs) Handles btnFoodCounter.Click

        ' Shows the new page and then closes the current page to keep the sreen clean and tidy
        calorieCounter.Show()
        Me.Hide()
    End Sub

    Private Sub btnBMI_Click(sender As Object, e As EventArgs) Handles btnBMI.Click

        ' Shows the new page and then closes the current page to keep the sreen clean and tidy
        BMI.Show()
        Me.Hide()
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click

        ' Shows the new page and then closes the current page to keep the sreen clean and tidy
        Report.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Shows the new page and then closes the current page to keep the sreen clean and tidy
        Form1.Show()
        Me.Hide()
    End Sub
End Class