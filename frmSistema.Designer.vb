<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistema
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoGeneralDeVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaDeVendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargarVectorDesdeUnArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SistemaToolStripMenuItem, Me.VendedorToolStripMenuItem, Me.VectoresToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem, Me.ToolStripMenuItem1, Me.SalirToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(132, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'VendedorToolStripMenuItem
        '
        Me.VendedorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoVendedorToolStripMenuItem, Me.ListadoGeneralDeVendedoresToolStripMenuItem, Me.ConsultaDeVendedoresToolStripMenuItem})
        Me.VendedorToolStripMenuItem.Name = "VendedorToolStripMenuItem"
        Me.VendedorToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.VendedorToolStripMenuItem.Text = "Vendedor"
        '
        'AgregarNuevoVendedorToolStripMenuItem
        '
        Me.AgregarNuevoVendedorToolStripMenuItem.Name = "AgregarNuevoVendedorToolStripMenuItem"
        Me.AgregarNuevoVendedorToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.AgregarNuevoVendedorToolStripMenuItem.Text = "Agregar nuevo vendedor..."
        '
        'ListadoGeneralDeVendedoresToolStripMenuItem
        '
        Me.ListadoGeneralDeVendedoresToolStripMenuItem.Name = "ListadoGeneralDeVendedoresToolStripMenuItem"
        Me.ListadoGeneralDeVendedoresToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ListadoGeneralDeVendedoresToolStripMenuItem.Text = "Listado general de vendedores..."
        '
        'ConsultaDeVendedoresToolStripMenuItem
        '
        Me.ConsultaDeVendedoresToolStripMenuItem.Name = "ConsultaDeVendedoresToolStripMenuItem"
        Me.ConsultaDeVendedoresToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ConsultaDeVendedoresToolStripMenuItem.Text = "Consulta de vendedores..."
        '
        'VectoresToolStripMenuItem
        '
        Me.VectoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarVectorToolStripMenuItem, Me.CargarVectorDesdeUnArchivoToolStripMenuItem})
        Me.VectoresToolStripMenuItem.Name = "VectoresToolStripMenuItem"
        Me.VectoresToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.VectoresToolStripMenuItem.Text = "Vectores"
        '
        'ListarVectorToolStripMenuItem
        '
        Me.ListarVectorToolStripMenuItem.Name = "ListarVectorToolStripMenuItem"
        Me.ListarVectorToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.ListarVectorToolStripMenuItem.Text = "Listar vector..."
        '
        'CargarVectorDesdeUnArchivoToolStripMenuItem
        '
        Me.CargarVectorDesdeUnArchivoToolStripMenuItem.Name = "CargarVectorDesdeUnArchivoToolStripMenuItem"
        Me.CargarVectorDesdeUnArchivoToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.CargarVectorDesdeUnArchivoToolStripMenuItem.Text = "Cargar vector desde un archivo"
        '
        'frmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistema"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestión de Vendedores"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoVendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoGeneralDeVendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaDeVendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVectorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CargarVectorDesdeUnArchivoToolStripMenuItem As ToolStripMenuItem
End Class
