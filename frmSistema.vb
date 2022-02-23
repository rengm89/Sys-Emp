Public Class frmSistema
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeToolStripMenuItem.Click
        frmAcercaDe.Show()
    End Sub

    Private Sub AgregarNuevoVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoVendedorToolStripMenuItem.Click
        frm001AgregarNuevoVendedor.Show()
    End Sub

    Private Sub ListadoGeneralDeVendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoGeneralDeVendedoresToolStripMenuItem.Click
        frm002ListadoGeneral.Show()
    End Sub

    Private Sub ConsultaDeVendedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDeVendedoresToolStripMenuItem.Click
        frm003ConsultaDatosVend.Show()
    End Sub

    Private Sub CargarVectorDesdeUnArchivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarVectorDesdeUnArchivoToolStripMenuItem.Click
        CargarVectorDesdeArchivo()
        MessageBox.Show("Datos Cargados")
    End Sub

    Private Sub ListarVectorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVectorToolStripMenuItem.Click
        frmListarVector.Show()
    End Sub
End Class
