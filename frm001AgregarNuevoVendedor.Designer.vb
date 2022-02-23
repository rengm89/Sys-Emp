<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm001AgregarNuevoVendedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnCargar = New System.Windows.Forms.Button()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.lblSueldo = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCargar
        '
        Me.btnCargar.Location = New System.Drawing.Point(87, 168)
        Me.btnCargar.Name = "btnCargar"
        Me.btnCargar.Size = New System.Drawing.Size(100, 23)
        Me.btnCargar.TabIndex = 4
        Me.btnCargar.Text = "Cargar"
        Me.btnCargar.UseVisualStyleBackColor = True
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(87, 124)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 20)
        Me.txtSueldo.TabIndex = 3
        Me.txtSueldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(87, 72)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(87, 24)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSueldo
        '
        Me.lblSueldo.AutoSize = True
        Me.lblSueldo.Location = New System.Drawing.Point(12, 127)
        Me.lblSueldo.Name = "lblSueldo"
        Me.lblSueldo.Size = New System.Drawing.Size(43, 13)
        Me.lblSueldo.TabIndex = 9
        Me.lblSueldo.Text = "Sueldo:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(12, 75)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 7
        Me.lblNombre.Text = "Nombre:"
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(12, 27)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(43, 13)
        Me.lblCodigo.TabIndex = 5
        Me.lblCodigo.Text = "Código:"
        '
        'frm001AgregarNuevoVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(251, 215)
        Me.Controls.Add(Me.btnCargar)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.lblSueldo)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblCodigo)
        Me.Name = "frm001AgregarNuevoVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Nuevo Vendedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCargar As Button
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents lblSueldo As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblCodigo As Label
End Class
