Imports DA.DA

Imports System.Data.SqlClient


Namespace BL
    Public Class BL_Frm_New_Book
        Inherits DataAccess

        Public ISBN As String
        Public Title As String
        Public Subject As Integer
        Public Wirter As String
        Public Publishers As String
        Public YearDate As String
        Public NumPage As Integer
        Public Price As Integer


        Public Function SelectDataSub() As DataTable
            MyBase.Link()
            Dim Query As String = "select * from Tb_Subject"
            Dim Output_Q As DataTable = MyBase.SelectData(Query)
            MyBase.UnLik()
            Return Output_Q
        End Function

        Public Sub Insertdata()
            MyBase.Link()
            Dim Query As String = "insert into Tb_book (ISBN,Title,[Subject],Wirter,Publishers,YearDate,NumPage,Price)values(N'{0}',N'{1}','{2}',N'{3}',N'{4}',N'{5}','{6}','{7}')"
            Query = String.Format(Query, ISBN)

            MyBase.UnLik()
        End Sub



    End Class

End Namespace
