Imports System.Data.SqlClient

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'create a connection string
        Dim connectionString As String = "Data Source=(localdb)\ProjectsV12;Initial Catalog=TestDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False"
        'create connection
        Using conn As New SqlConnection(connectionString)
            conn.Open()
            'query
            Dim command As New SqlCommand("SELECT * FROM SystemSettings where SettingID=2", conn)
            Using reader As SqlDataReader = command.ExecuteReader()
                reader.Read()
                lbFirst.Text = reader.Item(1)
                ' End While
            End Using
        End Using

    End Sub
End Class
