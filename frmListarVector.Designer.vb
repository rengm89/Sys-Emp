<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListarVector
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnLeer = New System.Windows.Forms.Button()
        Me.lblCantidadVendedores = New System.Windows.Forms.Label()
        Me.lblImporteTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvListadoGeneral = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvListadoGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLeer
        '
        Me.btnLeer.Location = New System.Drawing.Point(259, 415)
        Me.btnLeer.Name = "btnLeer"
        Me.btnLeer.Size = New System.Drawing.Size(98, 23)
        Me.btnLeer.TabIndex = 24
        Me.btnLeer.Text = "Listar"
        Me.btnLeer.UseVisualStyleBackColor = True
        '
        'lblCantidadVendedores
        '
        Me.lblCantidadVendedores.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCantidadVendedores.Location = New System.Drawing.Point(151, 354)
        Me.lblCantidadVendedores.Name = "lblCantidadVendedores"
        Me.lblCantidadVendedores.Size = New System.Drawing.Size(100, 23)
        Me.lblCantidadVendedores.TabIndex = 23
        Me.lblCantidadVendedores.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblImporteTotal
        '
        Me.lblImporteTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImporteTotal.Location = New System.Drawing.Point(151, 300)
        Me.lblImporteTotal.Name = "lblImporteTotal"
        Me.lblImporteTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblImporteTotal.TabIndex = 22
        Me.lblImporteTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 359)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Cantidad de vendedores:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Importe total de sueldos:"
        '
        'dgvListadoGeneral
        '
        Me.dgvListadoGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListadoGeneral.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvListadoGeneral.Location = New System.Drawing.Point(6, 12)
        Me.dgvListadoGeneral.Name = "dgvListadoGeneral"
        Me.dgvListadoGeneral.Size = New System.Drawing.Size(351, 255)
        Me.dgvListadoGeneral.TabIndex = 19
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Sueldo"
        Me.Column3.Name = "Column3"
        '
        'frmListarVector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(369, 450)
        Me.Controls.Add(Me.btnLeer)
        Me.Controls.Add(Me.lblCantidadVendedores)
        Me.Controls.Add(Me.lblImporteTotal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvListadoGeneral)
        Me.Name = "frmListarVector"
        Me.Text = "Listar Vector"
        CType(Me.dgvListadoGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLeer As Button
    Friend WithEvents lblCantidadVendedores As Label
    Friend WithEvents lblImporteTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvListadoGeneral As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
