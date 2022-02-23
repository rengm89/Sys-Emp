<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm002ListadoGeneral
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnListarCodAsc = New System.Windows.Forms.Button()
        Me.lblCantidadVendedores = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListadoGeneral = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnListarNombreAsc = New System.Windows.Forms.Button()
        Me.btnListarSueldoAsc = New System.Windows.Forms.Button()
        Me.btnListarSueldoDesc = New System.Windows.Forms.Button()
        Me.btnListarCodDesc = New System.Windows.Forms.Button()
        Me.btnListarNombreDesc = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnLeer = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.btnExportarCSV = New System.Windows.Forms.Button()
        CType(Me.dgvListadoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnListarCodAsc
        '
        Me.btnListarCodAsc.Location = New System.Drawing.Point(6, 34)
        Me.btnListarCodAsc.Name = "btnListarCodAsc"
        Me.btnListarCodAsc.Size = New System.Drawing.Size(92, 27)
        Me.btnListarCodAsc.TabIndex = 1
        Me.btnListarCodAsc.Text = "Ascendente"
        Me.btnListarCodAsc.UseVisualStyleBackColor = True
        '
        'lblCantidadVendedores
        '
        Me.lblCantidadVendedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidadVendedores.Location = New System.Drawing.Point(154, 416)
        Me.lblCantidadVendedores.Name = "lblCantidadVendedores"
        Me.lblCantidadVendedores.Size = New System.Drawing.Size(100, 23)
        Me.lblCantidadVendedores.TabIndex = 10
        Me.lblCantidadVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImporteTotal.Location = New System.Drawing.Point(154, 362)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblImporteTotal.TabIndex = 9
        Me.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 421)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Cantidad de vendedores:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 367)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Importe total de sueldos:"
        '
        'dgvListadoGeneral
        '
        Me.dgvListadoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListadoGeneral.Location = New System.Drawing.Point(12, 12)
        Me.dgvListadoGeneral.Name = "dgvListadoGeneral"
        Me.dgvListadoGeneral.Size = New System.Drawing.Size(351, 269)
        Me.dgvListadoGeneral.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "Código"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nombre"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column3.HeaderText = "Sueldo"
        Me.Column3.Name = "Column3"
        '
        'btnListarNombreAsc
        '
        Me.btnListarNombreAsc.Location = New System.Drawing.Point(6, 34)
        Me.btnListarNombreAsc.Name = "btnListarNombreAsc"
        Me.btnListarNombreAsc.Size = New System.Drawing.Size(92, 27)
        Me.btnListarNombreAsc.TabIndex = 11
        Me.btnListarNombreAsc.Text = "Ascendente"
        Me.btnListarNombreAsc.UseVisualStyleBackColor = True
        '
        'btnListarSueldoAsc
        '
        Me.btnListarSueldoAsc.Location = New System.Drawing.Point(6, 31)
        Me.btnListarSueldoAsc.Name = "btnListarSueldoAsc"
        Me.btnListarSueldoAsc.Size = New System.Drawing.Size(92, 27)
        Me.btnListarSueldoAsc.TabIndex = 12
        Me.btnListarSueldoAsc.Text = "Ascendente"
        Me.btnListarSueldoAsc.UseVisualStyleBackColor = True
        '
        'btnListarSueldoDesc
        '
        Me.btnListarSueldoDesc.Location = New System.Drawing.Point(6, 79)
        Me.btnListarSueldoDesc.Name = "btnListarSueldoDesc"
        Me.btnListarSueldoDesc.Size = New System.Drawing.Size(92, 27)
        Me.btnListarSueldoDesc.TabIndex = 13
        Me.btnListarSueldoDesc.Text = "Descendente"
        Me.btnListarSueldoDesc.UseVisualStyleBackColor = True
        '
        'btnListarCodDesc
        '
        Me.btnListarCodDesc.Location = New System.Drawing.Point(6, 79)
        Me.btnListarCodDesc.Name = "btnListarCodDesc"
        Me.btnListarCodDesc.Size = New System.Drawing.Size(92, 27)
        Me.btnListarCodDesc.TabIndex = 14
        Me.btnListarCodDesc.Text = "Descendente"
        Me.btnListarCodDesc.UseVisualStyleBackColor = True
        '
        'btnListarNombreDesc
        '
        Me.btnListarNombreDesc.Location = New System.Drawing.Point(6, 79)
        Me.btnListarNombreDesc.Name = "btnListarNombreDesc"
        Me.btnListarNombreDesc.Size = New System.Drawing.Size(92, 27)
        Me.btnListarNombreDesc.TabIndex = 15
        Me.btnListarNombreDesc.Text = "Descendente"
        Me.btnListarNombreDesc.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnListarCodAsc)
        Me.GroupBox1.Controls.Add(Me.btnListarCodDesc)
        Me.GroupBox1.Location = New System.Drawing.Point(392, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(109, 112)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Listar por Código"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnListarNombreAsc)
        Me.GroupBox2.Controls.Add(Me.btnListarNombreDesc)
        Me.GroupBox2.Location = New System.Drawing.Point(392, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(109, 112)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listar por Nombre"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnListarSueldoAsc)
        Me.GroupBox3.Controls.Add(Me.btnListarSueldoDesc)
        Me.GroupBox3.Location = New System.Drawing.Point(392, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(109, 112)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listar por Sueldo"
        '
        'btnLeer
        '
        Me.btnLeer.Location = New System.Drawing.Point(12, 308)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(98, 23)
        Me.btnLeer.TabIndex = 18
        Me.btnLeer.Text = "Listar"
        Me.btnLeer.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(142, 309)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(98, 23)
        Me.btnExportar.TabIndex = 19
        Me.btnExportar.Text = "Exportar"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'btnExportarCSV
        '
        Me.btnExportarCSV.Location = New System.Drawing.Point(265, 309)
        Me.btnExportarCSV.Name = "btnExportarCSV"
        Me.btnExportarCSV.Size = New System.Drawing.Size(98, 23)
        Me.btnExportarCSV.TabIndex = 20
        Me.btnExportarCSV.Text = "Exportar CSV"
        Me.btnExportarCSV.UseVisualStyleBackColor = True
        '
        'frm002ListadoGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(534, 455)
        Me.Controls.Add(Me.btnExportarCSV)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnLeer)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCantidadVendedores)
        Me.Controls.Add(Me.lblImporteTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvListadoGeneral)
        Me.Name = "frm002ListadoGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Listado General de Vendedores"
        CType(Me.dgvListadoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnListarCodAsc As Button
    Friend WithEvents lblCantidadVendedores As Label
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListadoGeneral As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnListarNombreAsc As Button
    Friend WithEvents btnListarSueldoAsc As Button
    Friend WithEvents btnListarSueldoDesc As Button
    Friend WithEvents btnListarCodDesc As Button
    Friend WithEvents btnListarNombreDesc As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnLeer As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents btnExportarCSV As Button
End Class
