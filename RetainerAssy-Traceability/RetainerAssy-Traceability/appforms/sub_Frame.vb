Public Class sub_Frame
    Private Sub btn_profile_Click(sender As Object, e As EventArgs) Handles btn_profile.Click
        If user_idno = "" Then
            display_formsub(New Login)
        Else
            If btn_profile.ContextMenuStrip IsNot Nothing Then
                btn_profile.ContextMenuStrip.Show(btn_profile, 0, btn_profile.Height)



            End If
        End If
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        display_form(New Login)
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btn_menu.Click
        If btn_menu.ContextMenuStrip IsNot Nothing Then
            btn_menu.ContextMenuStrip.Show(btn_menu, 0, btn_menu.Height)
        End If
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

    End Sub

    Private Sub QCScanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QCScanningToolStripMenuItem.Click
        display_formsub(qc_scanning)
    End Sub

    Private Sub PartsScanningToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PartsScanningToolStripMenuItem.Click
        display_formsub(parts_line)
    End Sub

    Private Sub ScanINToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScanINToolStripMenuItem.Click
        display_formsub(kitting_IN)
    End Sub

    Private Sub btn_stock_Click(sender As Object, e As EventArgs) Handles btn_stock.Click

    End Sub
End Class