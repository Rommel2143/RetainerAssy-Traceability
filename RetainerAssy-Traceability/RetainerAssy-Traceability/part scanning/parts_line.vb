Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class parts_line
    Private Sub parts_line_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_line()
    End Sub
    Private Sub load_line()
        Try
            con.Close()
            con.Open()
            Dim query As String = "SELECT line FROM denso_line"
            Dim selectdata As New MySqlCommand(query, con)
            dr = selectdata.ExecuteReader
            While dr.Read = True
                addobject_line(flow1, dr.GetString("line"), "")
            End While
        Catch ex As Exception

        End Try
    End Sub



    Private Sub flow1_Paint(sender As Object, e As PaintEventArgs) Handles flow1.Paint

    End Sub
End Class