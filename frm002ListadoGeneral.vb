Imports System.IO
Public Class frm002ListadoGeneral
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListarCodAsc.Click
        OrdenCodigoAsc()
        Listar()


    End Sub

    Private Sub Listar()
        Dim i As Integer = 0
        Dim total As Decimal = 0
        Dim cantidad As Integer = 0
        dgvListadoGeneral.Rows.Clear()

        While i < IND
            dgvListadoGeneral.Rows.Add(Vendedor(i).Codigo, Vendedor(i).Nombre, Vendedor(i).sueldo)
            total = total + Vendedor(i).sueldo
            cantidad = cantidad + 1
            i = i + 1
        End While
        lblImporteTotal.Text = total
        lblCantidadVendedores.Text = cantidad
    End Sub

    Private Sub LeerArchivos()
        Dim codigo As Integer = 0
        Dim nombre As String = ""
        Dim sueldo As Decimal = 0
        Dim total As Decimal = 0
        Dim cantidad As Integer = 0
        dgvListadoGeneral.Rows.Clear()


        FileOpen(1, ArchiCliente, OpenMode.Input)
        While Not EOF(1)
            Input(1, codigo)
            Input(1, nombre)
            Input(1, sueldo)
            dgvListadoGeneral.Rows.Add(codigo, nombre, sueldo)
            total = total + sueldo
            cantidad = cantidad + 1
        End While

        FileClose(1)
        lblCantidadVendedores.Text = cantidad
        lblImporteTotal.Text = total
    End Sub
    Private Sub OrdenCodigoAsc()
        Dim i = 0
        Dim c = 0
        Dim aux As RegistroVendedor

        While c < IND - 1
            i = 0
            While i < IND - 1
                If Vendedor(i).Codigo > Vendedor(i + 1).Codigo Then
                    aux = Vendedor(i)
                    Vendedor(i) = Vendedor(i + 1)
                    Vendedor(i + 1) = aux
                End If
                i = i + 1
            End While
            c = c + 1

        End While
    End Sub

    Private Sub OrdenCodigoDesc()
        Dim i = 0
        Dim c = 0
        Dim aux As RegistroVendedor

        While c < IND - 1
            i = 0
            While i < IND - 1
                If Vendedor(i).Codigo < Vendedor(i + 1).Codigo Then
                    aux = Vendedor(i)
                    Vendedor(i) = Vendedor(i + 1)
                    Vendedor(i + 1) = aux
                End If
                i = i + 1
            End While
            c = c + 1

        End While
    End Sub

    Private Sub OrdenNombreAsc()
        Dim i = 0
        Dim c = 0
        Dim aux As RegistroVendedor

        While c < IND - 1
            i = 0
            While i > IND - 1
                If Vendedor(i).Nombre > Vendedor(i + 1).Nombre Then
                    aux = Vendedor(i)
                    Vendedor(i) = Vendedor(i + 1)
                    Vendedor(i + 1) = aux
                End If
                i = i + 1
            End While
            c = c + 1

        End While
    End Sub

    Private Sub OrdenNombreDesc()
        Dim i = 0
        Dim c = 0
        Dim aux As RegistroVendedor

        While c < IND - 1
            i = 0
            While i < IND - 1
                If Vendedor(i).Nombre < Vendedor(i + 1).Nombre Then
                    aux = Vendedor(i)
                    Vendedor(i) = Vendedor(i + 1)
                    Vendedor(i + 1) = aux
                End If
                i = i + 1
            End While
            c = c + 1

        End While
    End Sub

    Private Sub OrdenSueldoAsc()
        Dim i = 0
        Dim c = 0
        Dim aux As RegistroVendedor

        While c < IND - 1
            i = 0
            While i < IND - 1
                If Vendedor(i).sueldo > Vendedor(i + 1).sueldo Then
                    aux = Vendedor(i)
                    Vendedor(i) = Vendedor(i + 1)
                    Vendedor(i + 1) = aux
                End If
                i = i + 1
            End While
            c = c + 1

        End While
    End Sub

    Private Sub OrdenSueldoDesc()
        Dim i = 0
        Dim c = 0
        Dim aux As RegistroVendedor

        While c < IND - 1
            i = 0
            While i < IND - 1
                If Vendedor(i).sueldo < Vendedor(i + 1).sueldo Then
                    aux = Vendedor(i)
                    Vendedor(i) = Vendedor(i + 1)
                    Vendedor(i + 1) = aux
                End If
                i = i + 1
            End While
            c = c + 1

        End While
    End Sub

    Private Sub btnListarCodDesc_Click(sender As Object, e As EventArgs) Handles btnListarCodDesc.Click
        OrdenCodigoDesc()
        Listar()

    End Sub

    Private Sub btnListarNombreAsc_Click(sender As Object, e As EventArgs) Handles btnListarNombreAsc.Click
        OrdenNombreAsc()
        Listar()

    End Sub

    Private Sub btnListarNombreDesc_Click(sender As Object, e As EventArgs) Handles btnListarNombreDesc.Click
        OrdenNombreDesc()
        Listar()

    End Sub

    Private Sub btnListarSueldoAsc_Click(sender As Object, e As EventArgs) Handles btnListarSueldoAsc.Click
        OrdenSueldoAsc()
        Listar()

    End Sub

    Private Sub btnListarSueldoDesc_Click(sender As Object, e As EventArgs) Handles btnListarSueldoDesc.Click
        OrdenSueldoDesc()
        Listar()

    End Sub

    Private Sub btnLeer_Click(sender As Object, e As EventArgs) Handles btnLeer.Click
        LeerArchivos()
    End Sub

    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click
        Dim codigo As Integer = 0
        Dim nombre As String = ""
        Dim sueldo As Decimal = 0

        FileOpen(1, ArchiCliente, OpenMode.Input)
        FileOpen(2, "DatosExportados.txt", OpenMode.Output)
        While Not EOF(1)
            Input(1, codigo)
            Input(1, nombre)
            Input(1, sueldo)

            Write(2, nombre)
            WriteLine(2, sueldo)
        End While

        FileClose(1)
        FileClose(2)
        MessageBox.Show("Datos Exportados")
    End Sub

    Private Sub btnExportarCSV_Click(sender As Object, e As EventArgs) Handles btnExportarCSV.Click
        Dim objArchivo = New StreamWriter("DatosExportados.csv", False, System.Text.Encoding.UTF8)
        Dim Total As Decimal = 0
        objArchivo.WriteLine("Listado de Vendedores")
        objArchivo.WriteLine("")
        objArchivo.WriteLine("Código;Nombre;Sueldo")
        FileOpen(1, ArchiCliente, OpenMode.Input)
        While Not EOF(1)
            Input(1, RegVend.Codigo)
            Input(1, RegVend.Nombre)
            Input(1, RegVend.sueldo)
            objArchivo.Write(RegVend.Codigo)
            objArchivo.Write(";")
            objArchivo.Write(RegVend.Nombre)
            objArchivo.Write(";")
            objArchivo.WriteLine(RegVend.sueldo)

            Total = Total + RegVend.sueldo
        End While
        objArchivo.WriteLine("")
        objArchivo.Write(";Total: ;")
        objArchivo.WriteLine(Total)

        FileClose(1)
        objArchivo.Close()
        MessageBox.Show("Datos Exportados")
    End Sub


End Class