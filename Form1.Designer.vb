<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btn_colorfuente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(btn_colorfuente))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator
        Me.ImprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VistaPreliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PegarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator
        Me.DeshacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RehacerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraDeEstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BarraDeHerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarFuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarColorFondoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CambiarColorFuenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lbl_texto = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.btn_nuevo = New System.Windows.Forms.ToolStripButton
        Me.btn_abrir = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton
        Me.btn_imprimir = New System.Windows.Forms.ToolStripButton
        Me.btn_preliminar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_copiar = New System.Windows.Forms.ToolStripButton
        Me.btn_cortar = New System.Windows.Forms.ToolStripButton
        Me.btn_pegar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_deshacer = New System.Windows.Forms.ToolStripButton
        Me.btn_rehacer = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_buscar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.btn_colorfont = New System.Windows.Forms.ToolStripButton
        Me.btn_colorfondo = New System.Windows.Forms.ToolStripButton
        Me.rtx_texto = New System.Windows.Forms.RichTextBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.VerToolStripMenuItem, Me.FuenteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(357, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.GuardarToolStripMenuItem, Me.ToolStripMenuItem1, Me.ImprimirToolStripMenuItem, Me.VistaPreliminarToolStripMenuItem, Me.ToolStripMenuItem4, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ArchivoToolStripMenuItem.Text = "&Archivo"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = CType(resources.GetObject("NuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.NuevoToolStripMenuItem.Text = "Nuevo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.Image = CType(resources.GetObject("AbrirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.Image = CType(resources.GetObject("GuardarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.G), System.Windows.Forms.Keys)
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 6)
        '
        'ImprimirToolStripMenuItem
        '
        Me.ImprimirToolStripMenuItem.Image = CType(resources.GetObject("ImprimirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        Me.ImprimirToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.ImprimirToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ImprimirToolStripMenuItem.Text = "Imprimir"
        '
        'VistaPreliminarToolStripMenuItem
        '
        Me.VistaPreliminarToolStripMenuItem.Image = CType(resources.GetObject("VistaPreliminarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.VistaPreliminarToolStripMenuItem.Name = "VistaPreliminarToolStripMenuItem"
        Me.VistaPreliminarToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.VistaPreliminarToolStripMenuItem.Text = "Vista preliminar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(160, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopiarToolStripMenuItem, Me.CortarToolStripMenuItem, Me.PegarToolStripMenuItem, Me.ToolStripMenuItem2, Me.DeshacerToolStripMenuItem, Me.RehacerToolStripMenuItem, Me.ToolStripMenuItem3, Me.BuscarToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.EditarToolStripMenuItem.Text = "&Editar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'CortarToolStripMenuItem
        '
        Me.CortarToolStripMenuItem.Image = CType(resources.GetObject("CortarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        Me.CortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CortarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.CortarToolStripMenuItem.Text = "Cortar"
        '
        'PegarToolStripMenuItem
        '
        Me.PegarToolStripMenuItem.Image = CType(resources.GetObject("PegarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PegarToolStripMenuItem.Name = "PegarToolStripMenuItem"
        Me.PegarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PegarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.PegarToolStripMenuItem.Text = "Pegar"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(165, 6)
        '
        'DeshacerToolStripMenuItem
        '
        Me.DeshacerToolStripMenuItem.Image = CType(resources.GetObject("DeshacerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DeshacerToolStripMenuItem.Name = "DeshacerToolStripMenuItem"
        Me.DeshacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.DeshacerToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DeshacerToolStripMenuItem.Text = "Deshacer"
        '
        'RehacerToolStripMenuItem
        '
        Me.RehacerToolStripMenuItem.Image = CType(resources.GetObject("RehacerToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RehacerToolStripMenuItem.Name = "RehacerToolStripMenuItem"
        Me.RehacerToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RehacerToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.RehacerToolStripMenuItem.Text = "Rehacer"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(165, 6)
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Image = CType(resources.GetObject("BuscarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BarraDeEstadoToolStripMenuItem, Me.BarraDeHerramientasToolStripMenuItem})
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.VerToolStripMenuItem.Text = "Ve&r"
        '
        'BarraDeEstadoToolStripMenuItem
        '
        Me.BarraDeEstadoToolStripMenuItem.CheckOnClick = True
        Me.BarraDeEstadoToolStripMenuItem.Name = "BarraDeEstadoToolStripMenuItem"
        Me.BarraDeEstadoToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BarraDeEstadoToolStripMenuItem.Text = "Barra de estado"
        '
        'BarraDeHerramientasToolStripMenuItem
        '
        Me.BarraDeHerramientasToolStripMenuItem.CheckOnClick = True
        Me.BarraDeHerramientasToolStripMenuItem.Name = "BarraDeHerramientasToolStripMenuItem"
        Me.BarraDeHerramientasToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.BarraDeHerramientasToolStripMenuItem.Text = "Barra de herramientas"
        '
        'FuenteToolStripMenuItem
        '
        Me.FuenteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarFuenteToolStripMenuItem, Me.CambiarColorFondoToolStripMenuItem, Me.CambiarColorFuenteToolStripMenuItem})
        Me.FuenteToolStripMenuItem.Name = "FuenteToolStripMenuItem"
        Me.FuenteToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.FuenteToolStripMenuItem.Text = "&Formato"
        '
        'CambiarFuenteToolStripMenuItem
        '
        Me.CambiarFuenteToolStripMenuItem.Image = CType(resources.GetObject("CambiarFuenteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambiarFuenteToolStripMenuItem.Name = "CambiarFuenteToolStripMenuItem"
        Me.CambiarFuenteToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CambiarFuenteToolStripMenuItem.Text = "Cambiar fuente"
        '
        'CambiarColorFondoToolStripMenuItem
        '
        Me.CambiarColorFondoToolStripMenuItem.Image = CType(resources.GetObject("CambiarColorFondoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambiarColorFondoToolStripMenuItem.Name = "CambiarColorFondoToolStripMenuItem"
        Me.CambiarColorFondoToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CambiarColorFondoToolStripMenuItem.Text = "Cambiar color fondo"
        '
        'CambiarColorFuenteToolStripMenuItem
        '
        Me.CambiarColorFuenteToolStripMenuItem.Image = CType(resources.GetObject("CambiarColorFuenteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CambiarColorFuenteToolStripMenuItem.Name = "CambiarColorFuenteToolStripMenuItem"
        Me.CambiarColorFuenteToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.CambiarColorFuenteToolStripMenuItem.Text = "Cambiar color fuente"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lbl_texto})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 317)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(357, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_texto
        '
        Me.lbl_texto.Name = "lbl_texto"
        Me.lbl_texto.Size = New System.Drawing.Size(111, 17)
        Me.lbl_texto.Text = "ToolStripStatusLabel1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nuevo, Me.btn_abrir, Me.ToolStripSeparator1, Me.btn_guardar, Me.btn_imprimir, Me.btn_preliminar, Me.ToolStripSeparator2, Me.btn_copiar, Me.btn_cortar, Me.btn_pegar, Me.ToolStripSeparator3, Me.btn_deshacer, Me.btn_rehacer, Me.ToolStripSeparator4, Me.btn_buscar, Me.ToolStripSeparator5, Me.btn_colorfont, Me.btn_colorfondo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(357, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btn_nuevo
        '
        Me.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_nuevo.Image = CType(resources.GetObject("btn_nuevo.Image"), System.Drawing.Image)
        Me.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(23, 22)
        Me.btn_nuevo.Text = "Nuevo"
        '
        'btn_abrir
        '
        Me.btn_abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_abrir.Image = CType(resources.GetObject("btn_abrir.Image"), System.Drawing.Image)
        Me.btn_abrir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_abrir.Name = "btn_abrir"
        Me.btn_abrir.Size = New System.Drawing.Size(23, 22)
        Me.btn_abrir.Text = "Abrir"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'btn_guardar
        '
        Me.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_guardar.Image = CType(resources.GetObject("btn_guardar.Image"), System.Drawing.Image)
        Me.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(23, 22)
        Me.btn_guardar.Text = "Guardar"
        '
        'btn_imprimir
        '
        Me.btn_imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_imprimir.Image = CType(resources.GetObject("btn_imprimir.Image"), System.Drawing.Image)
        Me.btn_imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_imprimir.Name = "btn_imprimir"
        Me.btn_imprimir.Size = New System.Drawing.Size(23, 22)
        Me.btn_imprimir.Text = "Imprimir"
        '
        'btn_preliminar
        '
        Me.btn_preliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_preliminar.Image = CType(resources.GetObject("btn_preliminar.Image"), System.Drawing.Image)
        Me.btn_preliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_preliminar.Name = "btn_preliminar"
        Me.btn_preliminar.Size = New System.Drawing.Size(23, 22)
        Me.btn_preliminar.Text = "Vista preliminar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'btn_copiar
        '
        Me.btn_copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_copiar.Image = CType(resources.GetObject("btn_copiar.Image"), System.Drawing.Image)
        Me.btn_copiar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_copiar.Name = "btn_copiar"
        Me.btn_copiar.Size = New System.Drawing.Size(23, 22)
        Me.btn_copiar.Text = "Copiar"
        '
        'btn_cortar
        '
        Me.btn_cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_cortar.Image = CType(resources.GetObject("btn_cortar.Image"), System.Drawing.Image)
        Me.btn_cortar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_cortar.Name = "btn_cortar"
        Me.btn_cortar.Size = New System.Drawing.Size(23, 22)
        Me.btn_cortar.Text = "Cortar"
        '
        'btn_pegar
        '
        Me.btn_pegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_pegar.Image = CType(resources.GetObject("btn_pegar.Image"), System.Drawing.Image)
        Me.btn_pegar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_pegar.Name = "btn_pegar"
        Me.btn_pegar.Size = New System.Drawing.Size(23, 22)
        Me.btn_pegar.Text = "Pegar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'btn_deshacer
        '
        Me.btn_deshacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_deshacer.Image = CType(resources.GetObject("btn_deshacer.Image"), System.Drawing.Image)
        Me.btn_deshacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_deshacer.Name = "btn_deshacer"
        Me.btn_deshacer.Size = New System.Drawing.Size(23, 22)
        Me.btn_deshacer.Text = "Deshacer"
        '
        'btn_rehacer
        '
        Me.btn_rehacer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_rehacer.Image = CType(resources.GetObject("btn_rehacer.Image"), System.Drawing.Image)
        Me.btn_rehacer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_rehacer.Name = "btn_rehacer"
        Me.btn_rehacer.Size = New System.Drawing.Size(23, 22)
        Me.btn_rehacer.Text = "Rehacer"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'btn_buscar
        '
        Me.btn_buscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_buscar.Image = CType(resources.GetObject("btn_buscar.Image"), System.Drawing.Image)
        Me.btn_buscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(23, 22)
        Me.btn_buscar.Text = "Buscar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'btn_colorfont
        '
        Me.btn_colorfont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_colorfont.Image = CType(resources.GetObject("btn_colorfont.Image"), System.Drawing.Image)
        Me.btn_colorfont.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_colorfont.Name = "btn_colorfont"
        Me.btn_colorfont.Size = New System.Drawing.Size(23, 22)
        Me.btn_colorfont.Text = "Cambiar color fuente"
        '
        'btn_colorfondo
        '
        Me.btn_colorfondo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_colorfondo.Image = CType(resources.GetObject("btn_colorfondo.Image"), System.Drawing.Image)
        Me.btn_colorfondo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_colorfondo.Name = "btn_colorfondo"
        Me.btn_colorfondo.Size = New System.Drawing.Size(23, 22)
        Me.btn_colorfondo.Text = "Cambiar color fondo"
        '
        'rtx_texto
        '
        Me.rtx_texto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtx_texto.Location = New System.Drawing.Point(0, 49)
        Me.rtx_texto.Name = "rtx_texto"
        Me.rtx_texto.Size = New System.Drawing.Size(357, 268)
        Me.rtx_texto.TabIndex = 3
        Me.rtx_texto.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'btn_colorfuente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(357, 339)
        Me.Controls.Add(Me.rtx_texto)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "btn_colorfuente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procesador de texto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PegarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DeshacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RehacerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarFuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarColorFondoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CambiarColorFuenteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuscarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_abrir As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_imprimir As System.Windows.Forms.ToolStripButton
    Friend WithEvents rtx_texto As System.Windows.Forms.RichTextBox
    Friend WithEvents VistaPreliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraDeEstadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BarraDeHerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents btn_preliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_copiar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_cortar As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_pegar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_deshacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_rehacer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_buscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lbl_texto As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btn_colorfont As System.Windows.Forms.ToolStripButton
    Friend WithEvents btn_colorfondo As System.Windows.Forms.ToolStripButton

End Class
