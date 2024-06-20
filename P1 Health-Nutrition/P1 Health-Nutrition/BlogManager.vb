
Imports System.IO

    Public Class BlogPost
        Public Property Title As String
        Public Property Content As String
        Public Property DatePublished As DateTime

        Public Sub New(title As String, content As String, datePublished As DateTime)
            Me.Title = title
            Me.Content = content
            Me.DatePublished = datePublished
        End Sub
    End Class

    Public Class BlogManager
        Private ReadOnly blogPostsDirectory As String = "C:\BlogPosts"

        Public Sub New()
            If Not Directory.Exists(blogPostsDirectory) Then
                Directory.CreateDirectory(blogPostsDirectory)
            End If
        End Sub

        Public Sub SaveBlogPost(blogPost As BlogPost)
            Dim fileName = $"{blogPost.DatePublished.ToString("yyyyMMddHHmmss")}_{blogPost.Title.Replace(" ", "_")}.txt"
            Dim filePath = Path.Combine(blogPostsDirectory, fileName)

            Using writer As New StreamWriter(filePath)
                writer.WriteLine(blogPost.Title)
                writer.WriteLine(blogPost.DatePublished.ToString())
                writer.WriteLine(blogPost.Content)
            End Using
        End Sub

        Public Function GetAllBlogPosts() As List(Of BlogPost)
            Dim blogPosts As New List(Of BlogPost)()

            For Each filePath As String In Directory.GetFiles(blogPostsDirectory)
                Using reader As New StreamReader(filePath)
                    Dim title = reader.ReadLine()
                    Dim datePublished = DateTime.Parse(reader.ReadLine())
                    Dim content = reader.ReadToEnd()
                    Dim blogPost As New BlogPost(title, content, datePublished)
                    blogPosts.Add(blogPost)
                End Using
            Next

            Return blogPosts
        End Function
    End Class


