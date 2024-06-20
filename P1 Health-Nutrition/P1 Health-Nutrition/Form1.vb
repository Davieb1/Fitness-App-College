Public Class Form1
    ' Declare a list of Tuple to store username and password for each registered user
    Private userList As New List(Of Tuple(Of String, String))

    ' Constructor for calorieCounter
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add a default user
        userList.Add(Tuple.Create("Admin", "Admin"))
    End Sub

    ' Function to validate login credentials
    Private Function ValidateLogin(username As String, password As String) As Boolean
        ' Check if the username and/or password fields are empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            ' Show a message box if either field is empty
            MsgBox("Please enter a username and password")
            Return False
        End If

        ' Check if the username and password match an existing user
        Dim isValidUser As Boolean = userList.Exists(Function(user) user.Item1 = username AndAlso user.Item2 = password)
        If isValidUser Then
            ' Show success message if credentials are valid
            MsgBox("Login Successful")
            Return True
        Else
            ' Show failure message if credentials are invalid
            MsgBox("Login Failed. Username or Password Incorrect")
            Return False
        End If
    End Function

    ' Function to register a new user
    Private Function RegisterUser(username As String, password As String) As Boolean
        ' Check if the username and/or password fields are empty
        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            ' Show a message box if either field is empty
            MsgBox("Please enter a username and password")
            Return False
        End If

        ' Check if the username already exists
        Dim userExists As Boolean = userList.Exists(Function(user) user.Item1 = username)
        If Not userExists Then
            ' Add the new user to the user list if username is unique
            userList.Add(Tuple.Create(username, password))
            ' Show success message if registration is successful
            MsgBox("Registration Successful")
            Return True
        Else
            ' Show failure message if username already exists
            MsgBox("Username already exists. Please use another username")
            Return False
        End If
    End Function

    ' Event handler for login button click
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' Get the username and password from textboxes
        Dim username As String = txtLoginUser.Text
        Dim password As String = txtLoginPass.Text

        ' Call ValidateLogin function and pass the username and password as parameters
        If ValidateLogin(username, password) Then
            ' Hide the current form if login is successful
            Me.Hide()
            ' Show the calorieCounter form
            Dim form2 As New calorieCounter()
            form2.Show()
        Else
            ' Clear the textboxes if login fails
            txtLoginUser.Text = ""
            txtLoginPass.Text = ""
        End If
    End Sub

    ' Event handler for register button click
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        ' Get the username and password from textboxes
        Dim username As String = txtRegUser.Text
        Dim password As String = txtRegPass.Text

        ' Call RegisterUser function and pass the username and password as parameters
        If RegisterUser(username, password) Then
            ' Hide the current form if registration is successful
            Me.Hide()
            ' Show the calorieCounter form
            Dim form2 As New calorieCounter()
            form2.Show()
        Else
            ' Clear the textboxes if registration fails
            txtRegUser.Text = ""
            txtRegPass.Text = ""
        End If
    End Sub
End Class
