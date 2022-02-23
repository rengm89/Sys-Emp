Public Class frm001AgregarNuevoVendedor
    Private Sub btnCargar_Click(sender As Object, e As EventArgs) Handles btnCargar.Click
        Dim c As Integer = 0

        If BuscarCliente(c) = False Then
            If IND < 100 And IND <> txtCodigo.Text Then
                RegVend.Codigo = txtCodigo.Text
                RegVend.Nombre = txtNombre.Text
                RegVend.sueldo = txtSueldo.Text
                IND = IND + 1
                MessageBox.Show("Datos Cargados")
            Else
                MessageBox.Show("No se pueden cargar los datos")
            End If
            ArchivosDeTexto()
            txtCodigo.Text = ""
            txtNombre.Text = ""
            txtSueldo.Text = ""

            FileOpen(1, ArchiCliente, OpenMode.Append)
            Write(1, RegVend.Codigo)
            Write(1, RegVend.Nombre)
            WriteLine(1, RegVend.sueldo)
            FileClose(1)
        Else
            MessageBox.Show("No se pueden cargar los datos. El código ingresado ya existe")
        End If



    End Sub


    Private Sub ArchivosDeTexto()
        Dim cod As Integer = txtCodigo.Text
        Dim nom As String = txtNombre.Text
        Dim sue As Decimal = txtSueldo.Text

        FileOpen(1, ArchiCliente, OpenMode.Append)
        Write(1, cod)
        Write(1, nom)
        WriteLine(1, sue)
        FileClose(1)
    End Sub
    Private Sub ControlarDatos()
        If txtCodigo.Text <> "" And txtNombre.Text <> "" And txtSueldo.Text <> "" Then
            btnCargar.Enabled = True
        Else
            btnCargar.Enabled = False
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged
        ControlarDatos()

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtSueldo_TextChanged(sender As Object, e As EventArgs) Handles txtSueldo.TextChanged
        ControlarDatos()
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Not IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtSueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldo.KeyPress
        If IsNumeric(e.KeyChar) Or e.KeyChar = "." Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class