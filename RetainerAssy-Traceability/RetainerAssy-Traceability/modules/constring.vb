Imports MySql.Data.MySqlClient
Module constring

    Public con As MySqlConnection = connection()
    Public da As New MySqlDataAdapter
    Public dr As MySqlDataReader
    Public dt As New DataTable


    Private Function connection() As MySqlConnection
        ' Return New MySqlConnection("server=PTI-027s;user id=Inventory;password=inventory123@;database=trcsystem")
        Return New MySqlConnection("server=localhost;user id=root;password=;database=trcsystem")
    End Function

End Module
