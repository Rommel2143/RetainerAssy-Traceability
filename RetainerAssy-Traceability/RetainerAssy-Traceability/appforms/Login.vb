Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        submitLogin()
    End Sub

    Private Sub submitLogin()
        Try

            Dim idwithA As String = "A" & txt_user.Text & "A"
            Dim idwithoutA As String = txt_user.Text.TrimStart("A"c).TrimEnd("A"c)
            Dim idwithoutasmall As String = txt_user.Text.TrimStart("a"c).TrimEnd("a"c)


            con.Close()
            con.Open()
            Dim query As String = "Select IDno,firstname,password FROM trc_user WHERE ( password='" & txt_pass.Text & "' OR password IS NULL ) and (IDno='" & txt_user.Text.Trim & "' OR IDno = '" & idwithA & "' OR IDno = '" & idwithoutA & "' OR IDno = '" & idwithoutasmall & "')"
            Dim selectuser As New MySqlCommand(query, con)
            dr = selectuser.ExecuteReader
            If dr.Read = True Then
                user_idno = dr.GetString("IDno")
                user_first = dr.GetString("firstname")
                sub_Frame.btn_user.Text = "Hello, " & user_first
                display_form(sub_Frame)
                Me.Close()
            Else
                show_error("Invalid Credentials.", 0)
            End If
        Catch ex As Exception
            show_error("Something went wrong. Please try again", 0)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CheckBox1.CheckedChanged
        If Guna2CheckBox1.Checked = True Then
            txt_pass.PasswordChar = Nothing
        Else
            txt_pass.PasswordChar = "*"
        End If
    End Sub

    Private Sub txt_pass_TextChanged(sender As Object, e As EventArgs) Handles txt_pass.TextChanged

    End Sub

    Private Sub txt_pass_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_pass.KeyDown
        If e.KeyCode = Keys.Enter Then
            submitLogin()
        End If
    End Sub
End Class