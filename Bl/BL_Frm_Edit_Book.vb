Imports DA.DA
Imports System.Data.SqlClient



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
    End Class




End Namespace
