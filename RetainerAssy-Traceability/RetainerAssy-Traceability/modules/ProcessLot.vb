Imports System
Imports MySql.Data.MySqlClient
Public Class ProcessLot

    Public Property PartCode As String
    Public Property TotalQty As Integer
    Public Property LotNumber As String
    Public Property MaterialLot As String
    Public Property Mold As String
    Public Property Cavity As String
    Public Property ProdDate As DateTime
    Public Property Material As String
    Public Property SupplierCode As String
    Public Property Serial As String
    Public Property Remarks As String
    Public Property AddSerial As String
    Public Property LotNumber2 As String

    Public Shared Function Parse(qrString As String) As ProcessLot
        Try

            If qrString.Length < 223 Then
                MessageBox.Show("QR code string is too short or corrupted.")
            End If

            Dim data As New ProcessLot()
            Dim index As Integer = 0

            data.PartCode = qrString.Substring(index, 15).Trim()
            index += 15

            data.TotalQty = Integer.Parse(qrString.Substring(index, 5).Trim())
            index += 5

            data.LotNumber = qrString.Substring(index, 20).Trim()
            index += 20

            data.MaterialLot = qrString.Substring(index, 20).Trim()
            index += 20

            data.Mold = qrString.Substring(index, 20).Trim()
            index += 20

            data.Cavity = qrString.Substring(index, 20).Trim()
            index += 30

            data.Material = qrString.Substring(index, 40).Trim()
            index += 40

            data.SupplierCode = qrString.Substring(index, 3).Trim()
            index += 3

            data.Serial = qrString.Substring(index, 10).Trim()
            index += 10

            data.Remarks = qrString.Substring(index, 30).Trim()
            index += 30

            data.AddSerial = qrString.Substring(index, 10).Trim()
            index += 10

            data.LotNumber2 = qrString.Substring(index, 20).Trim()

            Dim rawdate As String = data.LotNumber.Split("-"c)(0)

            ' Convert yyMMdd → Date
            Dim prodDate As Date = Date.ParseExact(rawdate, "yyMMdd", Globalization.CultureInfo.InvariantCulture)

            data.ProdDate = prodDate
            Return data


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try

    End Function

End Class

