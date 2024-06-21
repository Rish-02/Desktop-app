Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class Form3

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phoneNumber = TxtPhoneNumber.Text,
            .gitHubRepo = txtGitHubRepo.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Using client As New HttpClient()
            Dim content As New StringContent(json, Encoding.UTF8, "application/json")
            Try
                Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!")
                    Me.Close()
                Else
                    MessageBox.Show("Error submitting the form: " & response.StatusCode.ToString())
                End If
            Catch ex As Exception
                MessageBox.Show("Error submitting the form: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub
End Class