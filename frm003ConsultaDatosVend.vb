Public Class frm003ConsultaDatosVend
    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Dim i As Integer = 0
        While i < IND And Vendedor(i).Codigo <> txtCodigo.Text

            i = i + 1
        End While
        If i = IND Then
            MessageBox.Show("Ingresar Código")
            lblNombre.Text = ""

            lblSueldo.Text = ""
        Else
            lblNombre.Text = Vendedor(i).Nombre

            lblSueldo.Text = Vendedor(i).sueldo
        End If
    End Sub

    Private Sub ControlarDatos()
        If txtCodigo.Text <> "" Then
            cmdBuscar.Enabled = True
        Else
            cmdBuscar.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        ControlarDatos()
    End Sub

    Private Sub btnBuscarArchivo_Click(sender As Object, e As EventArgs) Handles btnBuscarArchivo.Click
        Dim codigo As Integer = 0
        Dim nombre As String = ""
        Dim sueldo As Decimal = 0


        FileOpen(1, ArchiCliente, OpenMode.Input)

        While Not EOF(1)
            Input(1, codigo)
            Input(1, nombre)
            Input(1, sueldo)
            If (codigo = txtCodigo.Text) Then
                lblNombre.Text = nombre
                lblSueldo.Text = sueldo
            End If

        End While

        FileClose(1)

    End Sub
End Class