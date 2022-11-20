Imports DA.DA
Imports System.Data.SqlClient


Namespace BL
    Public Class BL_Frm_All_Users

        Inherits DataAccess

        Public id As Integer
        Public Name As String
        Public Email As String
        Public Code As Integer

        Public Function SelectDataSub() As DataTable

            MyBase.Link()
            Dim Query As String = "select * from Tb_Users"
            Dim Qutput_Q As DataTable = MyBase.SelectData(Query)
            MyBase.UnLik()
            Return Qutput_Q

        End Function





    End Class
End Namespace