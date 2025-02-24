Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Public Class qc_scanning

    Private Sub qc_scanning_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        con.Open()
        Dim query As String = "SELECT `remarks` FROM `trc_device` WHERE PCname='" & PC_name & "'"
        Dim selectline As New MySqlCommand(query, con)
        dr = selectline.ExecuteReader
        If dr.Read = True Then
            lbl_line.Text = dr.GetString("remarks")
            reload("SELECT `qrcode`, `qty`,`timein` FROM `denso_line_traceability` WHERE datein=CURDATE()", datagrid1)
        End If


        reload_parts()


    End Sub

    Private Sub txtqr_KeyDown(sender As Object, e As KeyEventArgs) Handles txtqr.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtqr.Text.Trim = "" Then
                Exit Sub
            End If


            Try
                If check_total() Then

                    deduct_bezel()
                    deduct_retainer()
                    deduct_tape()
                    con.Close()
                    con.Open()
                    ' Insert into denso_line_boxes
                    Dim insertQuery As String = "INSERT INTO `denso_line_traceability`(`qrcode`, `qty`, `line`, `bezel`, `retainer`, `tape`, `timein`, `datein`, `userin`) 
                                                 VALUES ('" & txtqr.Text & "','" & txtqty.Text & "','" & lbl_line.Text & "','" & datagrid_bezel.Rows(0).Cells(0).Value.ToString() & "','" & datagrid_retainer.Rows(0).Cells(0).Value.ToString() & "','" & datagrid_tape.Rows(0).Cells(0).Value.ToString() & "',CURTIME(),CURDATE(),'" & user_idno & "')"
                    Using cmd As New MySqlCommand(insertQuery, con)
                        cmd.ExecuteNonQuery()

                        reload("SELECT `qrcode`, `qty`,`timein` FROM `denso_line_traceability` WHERE datein=CURDATE() ORDER BY id DESC", datagrid1)
                        reload_parts()

                    End Using
                Else
                    Timer1.Start()
                    show_error("No Parts available", 1)

                End If

                txtqr.Clear()
                txtqr.Focus()

            Catch ex As MySqlException When ex.Number = 1062
                show_error("Duplicate entry detected", 2)

            Catch ex As Exception
                show_error($"Error on saving: {ex.Message}", 1)

            Finally
                If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                    con.Close()
                End If
            End Try
        End If
    End Sub

    Private Sub deduct_bezel()
        Dim qty As Integer = Convert.ToInt32(txtqty.Text)
        Try
            con.Close()
            con.Open()

            ' Loop through each row in the DataGridView
            For Each row As DataGridViewRow In datagrid_bezel.Rows
                If row.Cells(1).Value IsNot DBNull.Value Then
                    Dim rowQty As Integer = Convert.ToInt32(row.Cells(1).Value)
                    Dim qrId As String = row.Cells(0).Value.ToString()

                    ' Check if the remaining quantity is less than the row quantity
                    If qty > 0 Then
                        If qty < rowQty Then
                            ' Deduct only the remaining quantity
                            Dim queryUpdate As String = "UPDATE `denso_line_boxes` SET `qty` = `qty` - @qty WHERE qr_id = @qrId"
                            Using cmd As New MySqlCommand(queryUpdate, con)
                                cmd.Parameters.AddWithValue("@qty", qty)
                                cmd.Parameters.AddWithValue("@qrId", qrId)
                                cmd.ExecuteNonQuery()
                            End Using
                            qty = 0 ' All remaining qty is deducted
                            Exit For ' Exit loop after deducting
                        Else
                            ' Deduct the entire row quantity
                            Dim queryUpdate As String = "UPDATE `denso_line_boxes` SET `qty` = `qty` - @qty WHERE qr_id = @qrId"
                            Using cmd As New MySqlCommand(queryUpdate, con)
                                cmd.Parameters.AddWithValue("@qty", rowQty)
                                cmd.Parameters.AddWithValue("@qrId", qrId)
                                cmd.ExecuteNonQuery()
                            End Using
                            qty -= rowQty ' Deduct the row quantity from remaining qty
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            show_error($"Error on saving: {ex.Message}", 1)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub deduct_retainer()
        Dim qty As Integer = Convert.ToInt32(txtqty.Text)
        Try
            con.Close()
            con.Open()

            ' Loop through each row in the DataGridView
            For Each row As DataGridViewRow In datagrid_retainer.Rows
                If row.Cells(1).Value IsNot DBNull.Value Then
                    Dim rowQty As Integer = Convert.ToInt32(row.Cells(1).Value)
                    Dim qrId As String = row.Cells(0).Value.ToString()

                    ' Check if the remaining quantity is less than the row quantity
                    If qty > 0 Then
                        If qty < rowQty Then
                            ' Deduct only the remaining quantity
                            Dim queryUpdate As String = "UPDATE `denso_line_boxes` SET `qty` = `qty` - @qty WHERE qr_id = @qrId"
                            Using cmd As New MySqlCommand(queryUpdate, con)
                                cmd.Parameters.AddWithValue("@qty", qty)
                                cmd.Parameters.AddWithValue("@qrId", qrId)
                                cmd.ExecuteNonQuery()
                            End Using
                            qty = 0 ' All remaining qty is deducted
                            Exit For ' Exit loop after deducting
                        Else
                            ' Deduct the entire row quantity
                            Dim queryUpdate As String = "UPDATE `denso_line_boxes` SET `qty` = `qty` - @qty WHERE qr_id = @qrId"
                            Using cmd As New MySqlCommand(queryUpdate, con)
                                cmd.Parameters.AddWithValue("@qty", rowQty)
                                cmd.Parameters.AddWithValue("@qrId", qrId)
                                cmd.ExecuteNonQuery()
                            End Using
                            qty -= rowQty ' Deduct the row quantity from remaining qty
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            show_error($"Error on saving: {ex.Message}", 1)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub deduct_tape()
        Dim qty As Integer = Convert.ToInt32(txtqty.Text)
        Try
            con.Close()
            con.Open()

            ' Loop through each row in the DataGridView
            For Each row As DataGridViewRow In datagrid_tape.Rows
                If row.Cells(1).Value IsNot DBNull.Value Then
                    Dim rowQty As Integer = Convert.ToInt32(row.Cells(1).Value)
                    Dim qrId As String = row.Cells(0).Value.ToString()

                    ' Check if the remaining quantity is less than the row quantity
                    If qty > 0 Then
                        If qty < rowQty Then
                            ' Deduct only the remaining quantity
                            Dim queryUpdate As String = "UPDATE `denso_line_boxes` SET `qty` = `qty` - @qty WHERE qr_id = @qrId"
                            Using cmd As New MySqlCommand(queryUpdate, con)
                                cmd.Parameters.AddWithValue("@qty", qty)
                                cmd.Parameters.AddWithValue("@qrId", qrId)
                                cmd.ExecuteNonQuery()
                            End Using
                            qty = 0 ' All remaining qty is deducted
                            Exit For ' Exit loop after deducting
                        Else
                            ' Deduct the entire row quantity
                            Dim queryUpdate As String = "UPDATE `denso_line_boxes` SET `qty` = `qty` - @qty WHERE qr_id = @qrId"
                            Using cmd As New MySqlCommand(queryUpdate, con)
                                cmd.Parameters.AddWithValue("@qty", rowQty)
                                cmd.Parameters.AddWithValue("@qrId", qrId)
                                cmd.ExecuteNonQuery()
                            End Using
                            qty -= rowQty ' Deduct the row quantity from remaining qty
                        End If
                    End If
                End If
            Next

        Catch ex As Exception
            show_error($"Error on saving: {ex.Message}", 1)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Function check_total() As Boolean
        If lbl_qtybezel.Text >= Convert.ToInt32(txtqty.Text) And lbl_qtyretainer.Text >= Convert.ToInt32(txtqty.Text) And lbl_qtytape.Text >= Convert.ToInt32(txtqty.Text) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        reload_parts()
    End Sub

    Private Sub reload_parts()
        reload("SELECT `qr_id`,`qty` FROM `denso_line_boxes` WHERE type = 1 and qty > 0", datagrid_bezel)
        reload("SELECT `qr_id`,`qty` FROM `denso_line_boxes` WHERE type = 2 and qty > 0", datagrid_retainer)
        reload("SELECT `qr_id`,`qty` FROM `denso_line_boxes` WHERE type = 3 and qty > 0", datagrid_tape)
        get_total(datagrid_bezel, lbl_qtybezel)
        get_total(datagrid_retainer, lbl_qtyretainer)
        get_total(datagrid_tape, lbl_qtytape)
    End Sub


    Private Sub get_total(datagrid As Guna.UI2.WinForms.Guna2DataGridView, lbl As Label)
        Dim totalQty As Integer = 0

        ' Loop through each row in the DataGridView
        For Each row As DataGridViewRow In datagrid.Rows
            If row.Cells("qty").Value IsNot Nothing Then
                totalQty += Convert.ToInt32(row.Cells("qty").Value)
            End If
        Next

        ' Display totalQty in the label, formatted as a number with commas for thousands
        lbl.Text = totalQty.ToString("N0")
    End Sub
    Private Sub txtqr_TextChanged(sender As Object, e As EventArgs) Handles txtqr.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        reload_parts()
        If check_total() = True Then
            Timer1.Stop()
        Else

            show_error("No Parts available", 1)
        End If
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged

    End Sub

    Private Sub txtqty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtqty.KeyPress
        ' Allow only digits (0-9) and the backspace key
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            ' Suppress the key press (ignore the input)
            e.Handled = True
        End If
    End Sub
End Class