Imports DA.DA
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace BL
    Public Class BL_Frm_Edit_Book

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

        Public Function SelectDataSub_A() As DataTable
            MyBase.Link()
            Dim Query As String = "select * from Tb_Book Where ISBN ='{0}' "
            Query = String.Format(Query, ISBN)
            Dim Output_Q As DataTable = MyBase.SelectData(Query)
            MyBase.UnLik()
            Return Output_Q
        End Function


        Public Sub UpdateData()
            MyBase.Link()
            Dim Query As String = "update Tb_Book set Title=N'{0}',[Subject]=N'{1}',wirter=N'{2}',publishers=N'{3}',YearDate=N'{4}',NumPage='{5}',Price='{6}' where ISBN=N'{7}'"
            Query = String.Format(Query, Title, Subject, Wirter, Publishers, YearDate, NumPage, Price, ISBN)

            MyBase.CommandText(Query)
            MyBase.UnLik()
            MessageBox.Show("Updated !")
        End Sub

    End Class




End Namespace
