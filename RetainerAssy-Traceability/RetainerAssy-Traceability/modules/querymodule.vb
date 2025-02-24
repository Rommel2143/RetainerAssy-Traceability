Imports MySql.Data.MySqlClient
Module querymodule



    Public Sub reload(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            dt = New DataTable()
            If con.State = ConnectionState.Open Then con.Close()
            con.Open()

            Using loadSql As New MySqlCommand(sql, con)
                Using da As New MySqlDataAdapter(loadSql)
                    da.Fill(dt)
                    dtg.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            show_error("Unable to load data: " & ex.Message, 0)
        Finally
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Public Sub cmb_display(query As String, cmb As ComboBox)
        Try
            ' Establish MySQL connection
            con.Close()
            con.Open()
            ' Execute the query
            Using cmd As New MySqlCommand(query, con)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    ' Clear the ComboBox items
                    cmb.Items.Clear()

                    ' Loop through the query results and add them to the ComboBox
                    While reader.Read()
                        cmb.Items.Add(reader.GetString(0)) ' Assuming the first column is the desired data
                    End While

                    ' Optionally set the first item as selected

                End Using
            End Using

        Catch ex As Exception
            ' Handle errors (e.g., display an error message)
            MessageBox.Show("Error loading data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
