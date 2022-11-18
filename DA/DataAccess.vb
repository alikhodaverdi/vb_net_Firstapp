Imports DA
Imports System.Data
Imports System.Data.SqlClient


Namespace DA
    Public Class DataAccess
        Private Con As SqlConnection
        Private Da As SqlDataAdapter
        Private Cmd As SqlCommand
        Private DT As DataTable

        Public Sub New()
            Con = New SqlConnection()
            Da = New SqlDataAdapter()
            Cmd = New SqlCommand()
            Cmd.Connection = Con
            Da.SelectCommand = Cmd
        End Sub

        Public Sub Link()
            Con.ConnectionString = "Data Source=.;Initial Catalog=DB_FirstApp;Integrated Security=True"
            Con.Open()
        End Sub

        Public Sub Unlink()
            Con.Close()
        End Sub


    End Class
End Namespace

