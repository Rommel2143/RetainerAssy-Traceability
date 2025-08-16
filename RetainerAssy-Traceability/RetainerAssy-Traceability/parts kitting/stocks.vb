

Public Class stocks
    Private Sub export_excel_Click(sender As Object, e As EventArgs) Handles export_excel.Click
        exporttoExcel(datagrid1)
    End Sub

    Private Sub Guna2DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles dt_picker1.ValueChanged
        reload("SELECT `qrcode` AS QR, `partno` AS Partno, `qty` AS Qty, `userin` AS Userid, `datein` AS DateIn,
                    CASE
                    WHEN type=1 THEN 'B'
                    WHEN type=2 THEN 'R'
                    WHEN type=3 THEN 'T' END AS Type
        FROM `denso_kitting` WHERE datein='" & dt_picker1.Value.ToString("yyyy-MM-dd") & "'", datagrid1)
    End Sub

    Private Sub kitting_records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_picker1.Value = Date.Now
    End Sub
End Class