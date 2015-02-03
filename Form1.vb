Public Class btn_colorfuente

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Nuevo
    ''' </summary>
    ''' <remarks>Permite crear un nuevo documento de texto.</remarks>
    Private Sub NuevoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoToolStripMenuItem.Click, btn_nuevo.Click
        Me.rtx_texto.Clear()
        Me.rtx_texto.BackColor = Color.White
        Me.rtx_texto.ForeColor = Color.Black
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Abrir
    ''' </summary>
    ''' <remarks>Se encargará de abrir un archivo de texto sobre nuestro richTextBox.</remarks>
    Private Sub AbrirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbrirToolStripMenuItem.Click, btn_abrir.Click
        OpenFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Me.rtx_texto.LoadFile(OpenFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Guardar
    ''' </summary>
    ''' <remarks>Guarda el contenido del richTextBox a nuestro disco duro con un formato txt</remarks>
    Private Sub GuardarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarToolStripMenuItem.Click, btn_guardar.Click
        Me.SaveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If Me.SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Me.rtx_texto.SaveFile(Me.SaveFileDialog1.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Imprimir
    ''' </summary>
    ''' <remarks>Imprime el documento actual.</remarks>
    Private Sub ImprimirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click, btn_imprimir.Click
        If Me.PrintDialog1.ShowDialog() = DialogResult.OK Then
            Me.PrintDialog1.Document.Print()
        End If
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem VistaPreliminar
    ''' </summary>
    ''' <remarks>Establece una vista preliminar de nuestro documento</remarks>
    Private Sub VistaPreliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VistaPreliminarToolStripMenuItem.Click, btn_preliminar.Click
        Me.PrintDocument1.DocumentName = Me.rtx_texto.Text
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.ShowDialog()
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Salir
    ''' </summary>
    ''' <remarks>Sale de la aplicación actual.</remarks>
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Copiar
    ''' </summary>
    ''' <remarks>Permite copiar una zona del texto</remarks>
    Private Sub CopiarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopiarToolStripMenuItem.Click, btn_copiar.Click
        Me.rtx_texto.Copy()
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Cortar
    ''' </summary>
    ''' <remarks>Permite cortar una zona del texto.</remarks>
    Private Sub CortarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CortarToolStripMenuItem.Click, btn_cortar.Click
        Me.rtx_texto.Cut()
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Pegar
    ''' </summary>
    ''' <remarks>Permite pegar en la zona del richTextBox que se desee un texto que se haya cortado o copiado previamente.</remarks>
    Private Sub PegarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PegarToolStripMenuItem.Click, btn_pegar.Click
        Me.rtx_texto.Paste()
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Deshacer
    ''' </summary>
    ''' <remarks>Deshace la última acción hecha por el usuario dentro del documento.</remarks>
    Private Sub DeshacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeshacerToolStripMenuItem.Click, btn_deshacer.Click
        Me.rtx_texto.Undo()
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Rehacer
    ''' </summary>
    ''' <remarks>Rehace la última acción hecha por el usuario.</remarks>
    Private Sub RehacerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RehacerToolStripMenuItem.Click, btn_rehacer.Click
        Me.rtx_texto.Redo()
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem Buscar
    ''' </summary>
    ''' <remarks>Pedirá al usuario una palabra a buscar dentro del richTextBox y si está, la seleccionará.</remarks>
    Private Sub BuscarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarToolStripMenuItem.Click, btn_buscar.Click
        Dim str As String

        str = InputBox("Introduce palabra a buscar", "Buscar palabra")
        Me.rtx_texto.Find(str)
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem BarraDeEstado
    ''' </summary>
    ''' <remarks>Si la barra de estado está checkeada estará visible para el usuario, si no lo está se ocultará.</remarks>
    Private Sub BarraDeEstadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeEstadoToolStripMenuItem.Click
        Me.StatusStrip1.Visible = Me.BarraDeEstadoToolStripMenuItem.Checked
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem BarraDeHerramientas
    ''' </summary>
    ''' <remarks>Si la barra de herramientas está checkeada estará visible para el usuario, si no lo está se ocultará.</remarks>
    Private Sub BarraDeHerramientasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BarraDeHerramientasToolStripMenuItem.Click
        Me.ToolStrip1.Visible = Me.BarraDeHerramientasToolStripMenuItem.Checked
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem CambiarFuente
    ''' </summary>
    ''' <remarks>Permitirá al usuario cambiar la fuente del texto del documento</remarks>
    Private Sub CambiarFuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarFuenteToolStripMenuItem.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Me.rtx_texto.Font = FontDialog1.Font
        End If
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem CambiarColorFondo
    ''' </summary>
    ''' <remarks>Sacará un cuadro de diálogo para que el usuario pueda cambiar el color del fondo del documento.</remarks>
    Private Sub CambiarColorFondoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarColorFondoToolStripMenuItem.Click, btn_colorfondo.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Me.rtx_texto.BackColor() = ColorDialog1.Color
        End If
    End Sub

    ''' <summary>
    ''' Evento click del Toolstripmenuitem CambiarColorFuente
    ''' </summary>
    ''' <remarks>Sacará un cuadro de diálogo para que el usuario puede modificar el color de la fuente del texto del documento.</remarks>
    Private Sub CambiarColorFuenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarColorFuenteToolStripMenuItem.Click, btn_colorfont.Click
        If ColorDialog1.ShowDialog = DialogResult.OK Then
            Me.rtx_texto.ForeColor() = ColorDialog1.Color
        End If
    End Sub

    ''' <summary>
    ''' Evento load del formulario
    ''' </summary>
    ''' <remarks>
    ''' Al cargar el formulario coloca el stick de chequeo sobre la BarraDeEstadoMenuItem y BarraHerramientasMenuItem indicando que inicialmente ambas barras estarán visibles para el usuario,
    ''' además también limpiará la etiqueta de la barra de estado.
    ''' </remarks>
    Private Sub frm_main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BarraDeHerramientasToolStripMenuItem.CheckState = CheckState.Checked
        Me.BarraDeEstadoToolStripMenuItem.CheckState = CheckState.Checked
        Me.lbl_texto.Text = " "
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón nuevo de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón nuevo.</remarks>
    Private Sub btn_nuevo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.MouseHover
        Me.lbl_texto.Text = "Crea un nuevo documento."
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón abrir de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de la barra de estado la acción del botón abrir.</remarks>
    Private Sub btn_abrir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_abrir.MouseHover
        Me.lbl_texto.Text = "Abre un documento."
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón guardar de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón guardar.</remarks>
    Private Sub btn_guardar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.MouseHover
        Me.lbl_texto.Text = "Guarda un documento."
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón imprimir de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón imprimir.</remarks>
    Private Sub btn_imprimir_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_imprimir.MouseHover
        Me.lbl_texto.Text = "Imprime un documento"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón preliminar de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón preliminar.</remarks>
    Private Sub btn_preliminar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_preliminar.MouseHover
        Me.lbl_texto.Text = "Vista preliminar de mi documento"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón copiar de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón copiar.</remarks>
    Private Sub btn_copiar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copiar.MouseHover
        Me.lbl_texto.Text = "Copia un texto del documento"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón cortar de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón cortar.</remarks>
    Private Sub btn_cortar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cortar.MouseHover
        Me.lbl_texto.Text = "Corta un texto del documento"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón pegar de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón pegar.</remarks>
    Private Sub btn_pegar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pegar.MouseHover
        Me.lbl_texto.Text = "Pega un texto del documento"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón deshacer de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón deshacer.</remarks>
    Private Sub btn_deshacer_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deshacer.MouseHover
        Me.lbl_texto.Text = "Deshace la última acción"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón rehacer de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón rehacer.</remarks>
    Private Sub btn_rehacer_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_rehacer.MouseHover
        Me.lbl_texto.Text = "Rehace la última acción"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón buscar
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón buscar.</remarks>
    Private Sub btn_buscar_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_buscar.MouseHover
        Me.lbl_texto.Text = "Busca una palabra dentro del documento"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón colorFont de la barra de herramientas
    ''' </summary>
    ''' <remarks>Indica en la etiqueta de barra de estado la acción del botón colorFont.</remarks>
    Private Sub btn_colorfont_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_colorfont.MouseHover
        Me.lbl_texto.Text = "Cambia el color de la fuente del documento"
    End Sub

    ''' <summary>
    ''' Evento MouseOver del botón colorFondo de la barra de herramientas
    ''' </summary>
    ''' <remarks>Evento MouseOver del botón abrir de la barra de herramientasIndica en la etiqueta de barra de estado la acción del botón colorFondo</remarks>
    Private Sub btn_colorfondo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_colorfondo.MouseHover
        Me.lbl_texto.Text = "Cambia el color del fondo del documento"
    End Sub

    ''' <summary>
    ''' Evento MouseLeave del botón nuevo de la barra de herramientas
    ''' </summary>
    ''' <remarks>Permite limpiar la etiqueta de la barra de estado para que cuando el usuario no esté sobre ningún icono no salga nada en dicha barra.</remarks>
    Private Sub btn_nuevo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.MouseLeave, btn_abrir.MouseLeave, btn_buscar.MouseLeave, btn_colorfondo.MouseLeave, btn_colorfont.MouseLeave, btn_copiar.MouseLeave, btn_cortar.MouseLeave, btn_deshacer.MouseLeave, btn_guardar.MouseLeave, btn_imprimir.MouseLeave, btn_pegar.MouseLeave, btn_preliminar.MouseLeave, btn_rehacer.MouseLeave
        Me.lbl_texto.Text = " "
    End Sub
End Class
