Imports MySql.Data.MySqlClient
Module user_access

    Public Property user_idno As String
    Public Property user_first As String
    Public Property user_pass As String

    Public Property PC_name As String = Environment.MachineName
    Public Property PC_line As String

    Public Function check_access_user(column As String) As Boolean
        Dim query As String = "SELECT " & column & " FROM trc_user WHERE IDno = @idno"

        Try
            con.Close()
            con.Open()
            Using getdata As New MySqlCommand(query, con)
                getdata.Parameters.AddWithValue("@idno", user_idno)

                Using reader As MySqlDataReader = getdata.ExecuteReader()
                    If reader.Read() Then
                        If reader.GetBoolean(0) Then
                            Return True ' User has access
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving access: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        ' Show error message only when access is denied
        show_error("You don't have access to this feature. Please contact IT support if needed.", 0)
        Return False
    End Function


    Public Function checkline(line As String) As Boolean
        Dim query As String = "SELECT id FROM denso_line WHERE line = '" & line & "'"

        Try
            con.Close()
            con.Open()
            Using getdata As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = getdata.ExecuteReader()
                    If reader.Read() Then
                        If reader.GetBoolean(0) Then
                            Return True ' User has access
                        End If
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error retrieving access: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try

        ' Show error message only when access is denied
        show_error("You don't have access to this feature. Please contact IT support if needed.", 0)
        Return False
    End Function
End Module
