Imports MySql.Data.MySqlClient
Public Class Mainframe
    Private Sub Mainframe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        con.Open()
        Dim query As String = "SELECT `remarks` FROM `trc_device` WHERE PCname='" & PC_name & "'"
        Dim selectline As New MySqlCommand(query, con)
        dr = selectline.ExecuteReader
        If dr.Read = True Then

            PC_line = dr.GetString("remarks")
            If checkline(PC_line) = True Then

                display_form(New Login)
            Else
                MessageBox.Show("Device is not Registered. Please call IT")
                Application.Exit()
            End If
        Else
            MessageBox.Show("Device is not Registered. Please call IT")
            Application.Exit()
        End If

    End Sub
End Class