Imports MySql.Data.MySqlClient
Public Class kitting_IN

    Private Sub kitting_IN_load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadRecords()
    End Sub
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Insert_kitting(txtqr.Text.Trim, cmb_type.Text.Substring(0, 1)) Then
                LoadRecords()
            End If
            txtqr.Clear()
            txtqr.Focus()
        End If
    End Sub
    Private Sub LoadRecords()
        ' Load all records into DataGridView
        reload("SELECT `id`, `qrcode`, `partno`, `qty` FROM `denso_kitting` WHERE datein = CURDATE()", datagrid1)

        Try
            ' Define query for grouped data
            Dim query As String = "
          SELECT 
    CASE 
        WHEN dm.type = 1 THEN 'BEZEL'
        WHEN dm.type = 2 THEN 'RETAINER'
        WHEN dm.type = 3 THEN 'TAPE'
        ELSE 'UNKNOWN'
    END AS partname,
    dk.partno, 
    SUM(dk.qty) AS totalqty, 
    COUNT(dk.id) AS totalcount
FROM 
    denso_kitting dk
LEFT JOIN 
    denso_kitting_masterlist dm ON dm.partno = dk.partno
WHERE 
    datein = CURDATE()
GROUP BY 
    dk.partno"

            ' Prepare MySQL command with parameters
            Using selectgroup As New MySqlCommand(query, con)
                ' Ensure the connection is open
                If con.State <> ConnectionState.Open Then con.Open()

                ' Execute query and read results
                Using dr As MySqlDataReader = selectgroup.ExecuteReader()
                    ' Clear existing controls in the FlowLayoutPanel
                    flow1.Controls.Clear()

                    ' Loop through query results
                    Do While dr.Read()
                        Dim partno As String = dr.GetString("partno")
                        Dim totalqty As Integer = dr.GetInt32("totalqty")
                        Dim countqty As Integer = dr.GetInt32("totalcount")
                        Dim partname As String = dr.GetString("partname")
                        ' Add dynamically created objects to the FlowLayoutPanel
                        addobject_group(flow1, partname, partno, totalqty, countqty)

                    Loop
                End Using
            End Using

        Catch ex As Exception
            ' Handle any errors and provide feedback
            MessageBox.Show("Error loading grouped records: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            ' Ensure the connection is closed
            If con.State = ConnectionState.Open Then con.Close()
        End Try
    End Sub

    Private Sub cmb_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_type.SelectedIndexChanged

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        kitting_records.ShowDialog()

    End Sub
End Class