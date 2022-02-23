Public Class frmListarVector
    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        Dim i As Integer = 0
        Dim cantidad As Integer = 0
        Dim total As Decimal = 0
        dgvListadoGeneral.Rows.Clear()

        While i < IND
            dgvListadoGeneral.Rows.Add(Vendedor(i).Codigo, Vendedor(i).Nombre, Vendedor(i).sueldo)
            cantidad = cantidad + 1
            total = total + Vendedor(i).sueldo
            i = i + 1
        End While
        lblCantidadVendedores.Text = cantidad
        lblImporteTotal.Text = total
    End Sub
End Class