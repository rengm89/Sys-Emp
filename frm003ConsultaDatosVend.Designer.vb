<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm003ConsultaDatosVend
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
        Me.cmdBuscar = New System.Windows.Forms.Button()
        Me.grpDatos = New System.Windows.Forms.GroupBox()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarArchivo = New System.Windows.Forms.Button()
        Me.grpDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdBuscar
        '
        Me.cmdBuscar.Location = New System.Drawing.Point(83, 222)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.Size = New System.Drawing.Size(100, 23)
        Me.cmdBuscar.TabIndex = 4
        Me.cmdBuscar.Text = "Buscar"
        Me.cmdBuscar.UseVisualStyleBackColor = True
        '
        'grpDatos
        '
        Me.grpDatos.Controls.Add(Me.lblSueldo)
        Me.grpDatos.Controls.Add(Me.lblNombre)
        Me.grpDatos.Controls.Add(Me.Label1)
        Me.grpDatos.Controls.Add(Me.Label2)
        Me.grpDatos.Location = New System.Drawing.Point(6, 69)
        Me.grpDatos.Name = "grpDatos"
        Me.grpDatos.Size = New System.Drawing.Size(198, 117)
        Me.grpDatos.TabIndex = 6
        Me.grpDatos.TabStop = False
        '
        'lblSueldo
        '
        Me.lblSueldo.BackColor = System.Drawing.Color.White
        Me.lblSueldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSueldo.Location = New System.Drawing.Point(77, 79)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(100, 23)
        Me.lblSueldo.TabIndex = 3
        Me.lblSueldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.Color.White
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Location = New System.Drawing.Point(77, 33)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(100, 23)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Sueldo:"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(83, 20)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Código:"
        '
        'btnBuscarArchivo
        '
        Me.btnBuscarArchivo.Location = New System.Drawing.Point(83, 252)
        Me.btnBuscarArchivo.Name = "btnBuscarArchivo"
        Me.btnBuscarArchivo.Size = New System.Drawing.Size(100, 36)
        Me.btnBuscarArchivo.TabIndex = 10
        Me.btnBuscarArchivo.Text = "Buscar en Archivo"
        Me.btnBuscarArchivo.UseVisualStyleBackColor = True
        '
        'frm003ConsultaDatosVend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(222, 300)
        Me.Controls.Add(Me.btnBuscarArchivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.cmdBuscar)
        Me.Controls.Add(Me.grpDatos)
        Me.Name = "frm003ConsultaDatosVend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de datos del vendedor"
        Me.grpDatos.ResumeLayout(False)
        Me.grpDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdBuscar As Button
    Friend WithEvents grpDatos As GroupBox
    Friend WithEvents lblSueldo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarArchivo As Button
End Class
