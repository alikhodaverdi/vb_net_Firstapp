
Imports DA.DA
Imports Bl

Namespace BL
    Public Class BL_Frm_Search
        Inherits DataAccess


        Public TextCommand As String
        Public renge As Integer
        Public Isbn As String

        Public Function Select_Data() As DataTable

            MyBase.Link()
            Dim Query As String = "SELECT Tb_Book.ISBN AS [کد شابک] , dbo.Tb_Book.Title AS [عنوان],Tb_Subject.Subject_Name AS [موضوع] ,dbo.Tb_Book.wirter AS [نویسنده] ,Tb_Book.publishers AS [انتشار],Tb_Book.YearDate AS [تاریخ انتشار] ,dbo.Tb_Book.NumPage AS [تعداد صفحه] ,dbo.Tb_Book.Price AS [قیمت] FROM dbo.Tb_Book,dbo.Tb_Subject
            WHERE dbo.Tb_Book.[Subject]=Tb_Subject.[Subject]"
            Dim Output_Q As DataTable = MyBase.SelectData(Query)
            MyBase.UnLik()
            Return Output_Q

            MyBase.UnLik()
        End Function

        Public Function Select_Data_A() As DataTable
            MyBase.Link()

            Dim Query As String = ""
            Select Case renge
                Case 0
                    Query = "SELECT Tb_Book.ISBN AS [کد شابک] , dbo.Tb_Book.Title AS [عنوان],Tb_Subject.Subject_Name AS [موضوع] ,dbo.Tb_Book.wirter AS [نویسنده] ,Tb_Book.publishers AS [انتشار],Tb_Book.YearDate AS [تاریخ انتشار] ,dbo.Tb_Book.NumPage AS [تعداد صفحه] ,dbo.Tb_Book.Price AS [قیمت] FROM dbo.Tb_Book,dbo.Tb_Subject
            WHERE dbo.Tb_Book.[Subject]=Tb_Subject.[Subject] AND dbo.Tb_Book.ISBN ='{0}'"
                Case 1
                    Query = "SELECT Tb_Book.ISBN AS [کد شابک] , dbo.Tb_Book.Title AS [عنوان],Tb_Subject.Subject_Name AS [موضوع] ,dbo.Tb_Book.wirter AS [نویسنده] ,Tb_Book.publishers AS [انتشار],Tb_Book.YearDate AS [تاریخ انتشار] ,dbo.Tb_Book.NumPage AS [تعداد صفحه] ,dbo.Tb_Book.Price AS [قیمت] FROM dbo.Tb_Book,dbo.Tb_Subject
            WHERE dbo.Tb_Book.[Subject]=Tb_Subject.[Subject] AND dbo.Tb_Book.Title Like '{0}%'"
                Case 2
                    Query = "SELECT Tb_Book.ISBN AS [کد شابک] , dbo.Tb_Book.Title AS [عنوان],Tb_Subject.Subject_Name AS [موضوع] ,dbo.Tb_Book.wirter AS [نویسنده] ,Tb_Book.publishers AS [انتشار],Tb_Book.YearDate AS [تاریخ انتشار] ,dbo.Tb_Book.NumPage AS [تعداد صفحه] ,dbo.Tb_Book.Price AS [قیمت] FROM dbo.Tb_Book,dbo.Tb_Subject
            WHERE dbo.Tb_Book.[Subject]=Tb_Subject.[Subject] AND dbo.Tb_Book.wirter Like '{0}%'"
                Case 3
                    Query = "SELECT Tb_Book.ISBN AS [کد شابک] , dbo.Tb_Book.Title AS [عنوان],Tb_Subject.Subject_Name AS [موضوع] ,dbo.Tb_Book.wirter AS [نویسنده] ,Tb_Book.publishers AS [انتشار],Tb_Book.YearDate AS [تاریخ انتشار] ,dbo.Tb_Book.NumPage AS [تعداد صفحه] ,dbo.Tb_Book.Price AS [قیمت] FROM dbo.Tb_Book,dbo.Tb_Subject
            WHERE dbo.Tb_Book.[Subject]=Tb_Subject.[Subject] AND dbo.Tb_Book.publishers = '{0}'"

            End Select

            Query = String.Format(Query, TextCommand)

            Dim Output_Q As DataTable = MyBase.SelectData(Query)

            MyBase.UnLik()
            Return Output_Q

        End Function

    End Class
End Namespace

