
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

        Public Sub UnLik()
            Con.Close()
        End Sub

        Public Function SelectData(ByVal StrSql As String) As DataTable
            Cmd.CommandText = StrSql
            DT = New DataTable()
            Da.Fill(DT)
            Return DT
        End Function

        Public Sub CommandText(ByVal StrSql As String)
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
        End Sub

    End Class
End Namespace


