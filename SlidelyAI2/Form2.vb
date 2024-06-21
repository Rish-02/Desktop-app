Imports System.Net.Http
Imports System.Text
Imports Microsoft.VisualBasic.Logging
Imports Newtonsoft.Json

Public Class Form2
    Private currentSubmissionIndex As Integer = 0
    Private submissions As List(Of Object)
    Private index = 0

    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        DisplaySubmission()
    End Sub

    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Dim url = "http://localhost:3000/read?index=" + index.ToString()
            Dim response = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Object))(json)
            Else
                MessageBox.Show("Error loading submissions.")
            End If
        End Using
    End Function

    Private Async Function LoadNextSubmission() As Task
        Using client As New HttpClient()
            index = index + 1
            Dim url = "http://localhost:3000/read?index=" + index.ToString()
            Dim response = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Object))(json)
            Else
                MessageBox.Show("Error loading submissions. No next submissions available.")
            End If
        End Using
    End Function

    Private Async Function LoadPrevSubmission() As Task
        Using client As New HttpClient()
            index = index - 1
            Dim url = "http://localhost:3000/read?index=" + index.ToString()
            Dim response = Await client.GetAsync(url)
            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                submissions = JsonConvert.DeserializeObject(Of List(Of Object))(json)
            Else
                MessageBox.Show("Error loading submissions. No previous submissions available.")
            End If
        End Using
    End Function

    Private Sub DisplaySubmission()
        If submissions IsNot Nothing AndAlso submissions.Count > 0 Then
            Dim submission = submissions(0)
            TextBox1.Text = submission("name").ToString()
            TextBox2.Text = submission("email").ToString()
            TextBox3.Text = submission("phoneNumber").ToString()
            TextBox4.Text = submission("gitHubRepo").ToString()
        End If
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Await LoadPrevSubmission()
        DisplaySubmission()
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Await LoadNextSubmission()
        DisplaySubmission()
    End Sub

    Private Async Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnDelete.Click
        If MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Using client As New HttpClient()
                Dim url = "http://localhost:3000/delete?index=" + index.ToString()
                Dim response = Await client.GetAsync(url)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted.")
                    index = 0
                    Await LoadSubmissions()
                    DisplaySubmission()
                Else
                    MessageBox.Show("Error deleting submission.")
                End If
            End Using
        End If
    End Sub

    Public Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
    End Class

End Class