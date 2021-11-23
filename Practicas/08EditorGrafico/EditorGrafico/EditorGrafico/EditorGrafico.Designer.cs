namespace EditorGrafico
{
    partial class EditorGrafico
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditorGrafico));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itFiguras = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoLíneaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinuaYPuntosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.punteadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discontinuaYDoblePuntoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itSolidoLinea = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoRellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasVerticalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasHorizontalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineasEnZigZagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mosaicoEscocésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itSolido = new System.Windows.Forms.ToolStripMenuItem();
            this.sinRellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNuevo = new System.Windows.Forms.ToolStripButton();
            this.tsbAbrir = new System.Windows.Forms.ToolStripButton();
            this.tsbGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLapiz = new System.Windows.Forms.ToolStripButton();
            this.tsbGoma = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbColorDeFondo = new System.Windows.Forms.ToolStripButton();
            this.tsbColorLapiz = new System.Windows.Forms.ToolStripButton();
            this.tsbColorRelleno = new System.Windows.Forms.ToolStripButton();
            this.tsbGrosor = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsLateral = new System.Windows.Forms.ToolStrip();
            this.tsbLinea = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tsbTexto = new System.Windows.Forms.ToolStripButton();
            this.tsbBorrarSeleccion = new System.Windows.Forms.ToolStripButton();
            this.stEstado = new System.Windows.Forms.StatusStrip();
            this.tsl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnEditor = new System.Windows.Forms.Panel();
            this.pbEditorGrafico = new System.Windows.Forms.PictureBox();
            this.dlgAbrirDibujo = new System.Windows.Forms.OpenFileDialog();
            this.itAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgGuardar = new System.Windows.Forms.SaveFileDialog();
            this.itGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tsLateral.SuspendLayout();
            this.stEstado.SuspendLayout();
            this.pnEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditorGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.itFiguras,
            this.verToolStripMenuItem,
            this.estiloToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itAbrir,
            this.itGuardar});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // itFiguras
            // 
            this.itFiguras.Name = "itFiguras";
            this.itFiguras.Size = new System.Drawing.Size(68, 24);
            this.itFiguras.Text = "Figuras";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // estiloToolStripMenuItem
            // 
            this.estiloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tipoLíneaToolStripMenuItem,
            this.tipoRellenoToolStripMenuItem});
            this.estiloToolStripMenuItem.Name = "estiloToolStripMenuItem";
            this.estiloToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.estiloToolStripMenuItem.Text = "Estilo";
            // 
            // tipoLíneaToolStripMenuItem
            // 
            this.tipoLíneaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.discontinuaToolStripMenuItem,
            this.discontinuaYPuntosToolStripMenuItem,
            this.punteadaToolStripMenuItem,
            this.discontinuaYDoblePuntoToolStripMenuItem,
            this.itSolidoLinea});
            this.tipoLíneaToolStripMenuItem.Name = "tipoLíneaToolStripMenuItem";
            this.tipoLíneaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.tipoLíneaToolStripMenuItem.Text = "Tipo Línea";
            // 
            // discontinuaToolStripMenuItem
            // 
            this.discontinuaToolStripMenuItem.Name = "discontinuaToolStripMenuItem";
            this.discontinuaToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.discontinuaToolStripMenuItem.Text = "Discontinua";
            // 
            // discontinuaYPuntosToolStripMenuItem
            // 
            this.discontinuaYPuntosToolStripMenuItem.Name = "discontinuaYPuntosToolStripMenuItem";
            this.discontinuaYPuntosToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.discontinuaYPuntosToolStripMenuItem.Text = "Discontinua y Puntos";
            // 
            // punteadaToolStripMenuItem
            // 
            this.punteadaToolStripMenuItem.Name = "punteadaToolStripMenuItem";
            this.punteadaToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.punteadaToolStripMenuItem.Text = "Punteada";
            // 
            // discontinuaYDoblePuntoToolStripMenuItem
            // 
            this.discontinuaYDoblePuntoToolStripMenuItem.Name = "discontinuaYDoblePuntoToolStripMenuItem";
            this.discontinuaYDoblePuntoToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.discontinuaYDoblePuntoToolStripMenuItem.Text = "Discontinua y Doble Punto";
            // 
            // itSolidoLinea
            // 
            this.itSolidoLinea.Name = "itSolidoLinea";
            this.itSolidoLinea.Size = new System.Drawing.Size(260, 26);
            this.itSolidoLinea.Text = "Color sólido";
            // 
            // tipoRellenoToolStripMenuItem
            // 
            this.tipoRellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lineasVerticalesToolStripMenuItem,
            this.cuadriculaToolStripMenuItem,
            this.lineasHorizontalesToolStripMenuItem,
            this.lineasEnZigZagToolStripMenuItem,
            this.mosaicoEscocésToolStripMenuItem,
            this.itSolido,
            this.sinRellenoToolStripMenuItem});
            this.tipoRellenoToolStripMenuItem.Name = "tipoRellenoToolStripMenuItem";
            this.tipoRellenoToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.tipoRellenoToolStripMenuItem.Text = "Tipo Relleno";
            // 
            // lineasVerticalesToolStripMenuItem
            // 
            this.lineasVerticalesToolStripMenuItem.Name = "lineasVerticalesToolStripMenuItem";
            this.lineasVerticalesToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.lineasVerticalesToolStripMenuItem.Text = "Lineas Verticales";
            // 
            // cuadriculaToolStripMenuItem
            // 
            this.cuadriculaToolStripMenuItem.Name = "cuadriculaToolStripMenuItem";
            this.cuadriculaToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.cuadriculaToolStripMenuItem.Text = "Cuadricula";
            // 
            // lineasHorizontalesToolStripMenuItem
            // 
            this.lineasHorizontalesToolStripMenuItem.Name = "lineasHorizontalesToolStripMenuItem";
            this.lineasHorizontalesToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.lineasHorizontalesToolStripMenuItem.Text = "Lineas Horizontales";
            // 
            // lineasEnZigZagToolStripMenuItem
            // 
            this.lineasEnZigZagToolStripMenuItem.Name = "lineasEnZigZagToolStripMenuItem";
            this.lineasEnZigZagToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.lineasEnZigZagToolStripMenuItem.Text = "Lineas en Zig Zag";
            // 
            // mosaicoEscocésToolStripMenuItem
            // 
            this.mosaicoEscocésToolStripMenuItem.Name = "mosaicoEscocésToolStripMenuItem";
            this.mosaicoEscocésToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.mosaicoEscocésToolStripMenuItem.Text = "Mosaico Escocés";
            // 
            // itSolido
            // 
            this.itSolido.Name = "itSolido";
            this.itSolido.Size = new System.Drawing.Size(213, 26);
            this.itSolido.Text = "Color Sólido";
            // 
            // sinRellenoToolStripMenuItem
            // 
            this.sinRellenoToolStripMenuItem.Name = "sinRellenoToolStripMenuItem";
            this.sinRellenoToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.sinRellenoToolStripMenuItem.Text = "Sin Relleno";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNuevo,
            this.tsbAbrir,
            this.tsbGuardar,
            this.toolStripSeparator1,
            this.tsbLapiz,
            this.tsbGoma,
            this.toolStripSeparator2,
            this.tsbColorDeFondo,
            this.tsbColorLapiz,
            this.tsbColorRelleno,
            this.tsbGrosor});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(910, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            this.tsbNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNuevo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNuevo.Image")));
            this.tsbNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevo.Name = "tsbNuevo";
            this.tsbNuevo.Size = new System.Drawing.Size(24, 24);
            this.tsbNuevo.Text = "toolStripButton1";
            // 
            // tsbAbrir
            // 
            this.tsbAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAbrir.Image = ((System.Drawing.Image)(resources.GetObject("tsbAbrir.Image")));
            this.tsbAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAbrir.Name = "tsbAbrir";
            this.tsbAbrir.Size = new System.Drawing.Size(24, 24);
            this.tsbAbrir.Text = "toolStripButton2";
            // 
            // tsbGuardar
            // 
            this.tsbGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsbGuardar.Image")));
            this.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGuardar.Name = "tsbGuardar";
            this.tsbGuardar.Size = new System.Drawing.Size(24, 24);
            this.tsbGuardar.Text = "toolStripButton3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbLapiz
            // 
            this.tsbLapiz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLapiz.Image = global::EditorGrafico.Properties.Resources.lapiz;
            this.tsbLapiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLapiz.Name = "tsbLapiz";
            this.tsbLapiz.Size = new System.Drawing.Size(24, 24);
            this.tsbLapiz.Text = "toolStripButton4";
            this.tsbLapiz.Click += new System.EventHandler(this.tsbLapiz_Click);
            // 
            // tsbGoma
            // 
            this.tsbGoma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbGoma.Image = global::EditorGrafico.Properties.Resources.goma;
            this.tsbGoma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGoma.Name = "tsbGoma";
            this.tsbGoma.Size = new System.Drawing.Size(24, 24);
            this.tsbGoma.Text = "toolStripButton5";
            this.tsbGoma.Click += new System.EventHandler(this.tsbGoma_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tsbColorDeFondo
            // 
            this.tsbColorDeFondo.Image = ((System.Drawing.Image)(resources.GetObject("tsbColorDeFondo.Image")));
            this.tsbColorDeFondo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColorDeFondo.Name = "tsbColorDeFondo";
            this.tsbColorDeFondo.Size = new System.Drawing.Size(143, 24);
            this.tsbColorDeFondo.Text = "toolStripButton6";
            // 
            // tsbColorLapiz
            // 
            this.tsbColorLapiz.Image = ((System.Drawing.Image)(resources.GetObject("tsbColorLapiz.Image")));
            this.tsbColorLapiz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColorLapiz.Name = "tsbColorLapiz";
            this.tsbColorLapiz.Size = new System.Drawing.Size(143, 24);
            this.tsbColorLapiz.Text = "toolStripButton7";
            // 
            // tsbColorRelleno
            // 
            this.tsbColorRelleno.Image = ((System.Drawing.Image)(resources.GetObject("tsbColorRelleno.Image")));
            this.tsbColorRelleno.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbColorRelleno.Name = "tsbColorRelleno";
            this.tsbColorRelleno.Size = new System.Drawing.Size(143, 24);
            this.tsbColorRelleno.Text = "toolStripButton8";
            // 
            // tsbGrosor
            // 
            this.tsbGrosor.Image = ((System.Drawing.Image)(resources.GetObject("tsbGrosor.Image")));
            this.tsbGrosor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGrosor.Name = "tsbGrosor";
            this.tsbGrosor.Size = new System.Drawing.Size(226, 24);
            this.tsbGrosor.Text = "toolStripDropDownButton1";
            // 
            // tsLateral
            // 
            this.tsLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.tsLateral.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsLateral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLinea,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton6,
            this.tsbTexto,
            this.tsbBorrarSeleccion});
            this.tsLateral.Location = new System.Drawing.Point(0, 55);
            this.tsLateral.Name = "tsLateral";
            this.tsLateral.Size = new System.Drawing.Size(25, 514);
            this.tsLateral.TabIndex = 3;
            this.tsLateral.Text = "toolStrip2";
            this.tsLateral.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tsbLinea
            // 
            this.tsbLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLinea.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinea.Image")));
            this.tsbLinea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinea.Name = "tsbLinea";
            this.tsbLinea.Size = new System.Drawing.Size(22, 24);
            this.tsbLinea.Text = "toolStripButton1";
            this.tsbLinea.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(22, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(22, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(22, 24);
            this.toolStripButton6.Text = "toolStripButton6";
            // 
            // tsbTexto
            // 
            this.tsbTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbTexto.Image = ((System.Drawing.Image)(resources.GetObject("tsbTexto.Image")));
            this.tsbTexto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTexto.Name = "tsbTexto";
            this.tsbTexto.Size = new System.Drawing.Size(22, 24);
            this.tsbTexto.Text = "toolStripButton7";
            this.tsbTexto.Click += new System.EventHandler(this.tsbTexto_Click);
            // 
            // tsbBorrarSeleccion
            // 
            this.tsbBorrarSeleccion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBorrarSeleccion.Image = ((System.Drawing.Image)(resources.GetObject("tsbBorrarSeleccion.Image")));
            this.tsbBorrarSeleccion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBorrarSeleccion.Name = "tsbBorrarSeleccion";
            this.tsbBorrarSeleccion.Size = new System.Drawing.Size(22, 24);
            this.tsbBorrarSeleccion.Text = "toolStripButton8";
            this.tsbBorrarSeleccion.Click += new System.EventHandler(this.tsbBorrarSeleccion_Click);
            // 
            // stEstado
            // 
            this.stEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl1,
            this.toolStripStatusLabel2,
            this.tsl2,
            this.toolStripStatusLabel4,
            this.tsl3,
            this.toolStripStatusLabel6,
            this.tsl4});
            this.stEstado.Location = new System.Drawing.Point(25, 544);
            this.stEstado.Name = "stEstado";
            this.stEstado.Size = new System.Drawing.Size(885, 25);
            this.stEstado.TabIndex = 2;
            this.stEstado.Text = "statusStrip1";
            // 
            // tsl1
            // 
            this.tsl1.Name = "tsl1";
            this.tsl1.Size = new System.Drawing.Size(203, 20);
            this.tsl1.Text = "Tamaño del dibujo: 400 x 400";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // tsl2
            // 
            this.tsl2.Name = "tsl2";
            this.tsl2.Size = new System.Drawing.Size(96, 20);
            this.tsl2.Text = "Grosor línea: ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 20);
            // 
            // tsl3
            // 
            this.tsl3.Name = "tsl3";
            this.tsl3.Size = new System.Drawing.Size(104, 20);
            this.tsl3.Text = "Grosor Goma: ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 20);
            // 
            // tsl4
            // 
            this.tsl4.Name = "tsl4";
            this.tsl4.Size = new System.Drawing.Size(40, 20);
            this.tsl4.Text = "X: Y: ";
            // 
            // pnEditor
            // 
            this.pnEditor.AutoScroll = true;
            this.pnEditor.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnEditor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnEditor.Controls.Add(this.pbEditorGrafico);
            this.pnEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEditor.Location = new System.Drawing.Point(25, 55);
            this.pnEditor.Name = "pnEditor";
            this.pnEditor.Size = new System.Drawing.Size(885, 489);
            this.pnEditor.TabIndex = 5;
            // 
            // pbEditorGrafico
            // 
            this.pbEditorGrafico.BackColor = System.Drawing.Color.White;
            this.pbEditorGrafico.Location = new System.Drawing.Point(34, 24);
            this.pbEditorGrafico.Name = "pbEditorGrafico";
            this.pbEditorGrafico.Size = new System.Drawing.Size(400, 400);
            this.pbEditorGrafico.TabIndex = 0;
            this.pbEditorGrafico.TabStop = false;
            this.pbEditorGrafico.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditorGrafico_MouseDown);
            this.pbEditorGrafico.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditorGrafico_MouseMove);
            this.pbEditorGrafico.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbEditorGrafico_MouseUp);
            // 
            // dlgAbrirDibujo
            // 
            this.dlgAbrirDibujo.FileName = "openFileDialog1";
            // 
            // itAbrir
            // 
            this.itAbrir.Name = "itAbrir";
            this.itAbrir.Size = new System.Drawing.Size(216, 26);
            this.itAbrir.Text = "Abrir";
            this.itAbrir.Click += new System.EventHandler(this.itAbrir_Click);
            // 
            // itGuardar
            // 
            this.itGuardar.Name = "itGuardar";
            this.itGuardar.Size = new System.Drawing.Size(216, 26);
            this.itGuardar.Text = "Guardar";
            this.itGuardar.Click += new System.EventHandler(this.itGuardar_Click);
            // 
            // EditorGrafico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(910, 569);
            this.Controls.Add(this.pnEditor);
            this.Controls.Add(this.stEstado);
            this.Controls.Add(this.tsLateral);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditorGrafico";
            this.Text = "Dibujo1";
            this.Load += new System.EventHandler(this.EditorGrafico_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EditorGrafico_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EditorGrafico_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditorGrafico_MouseMove);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tsLateral.ResumeLayout(false);
            this.tsLateral.PerformLayout();
            this.stEstado.ResumeLayout(false);
            this.stEstado.PerformLayout();
            this.pnEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbEditorGrafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itFiguras;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estiloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStrip tsLateral;
        private System.Windows.Forms.StatusStrip stEstado;
        private System.Windows.Forms.ToolStripButton tsbNuevo;
        private System.Windows.Forms.ToolStripButton tsbAbrir;
        private System.Windows.Forms.ToolStripButton tsbGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbLapiz;
        private System.Windows.Forms.ToolStripButton tsbGoma;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbColorDeFondo;
        private System.Windows.Forms.ToolStripButton tsbColorLapiz;
        private System.Windows.Forms.ToolStripButton tsbColorRelleno;
        private System.Windows.Forms.Panel pnEditor;
        private System.Windows.Forms.PictureBox pbEditorGrafico;
        private System.Windows.Forms.ToolStripDropDownButton tsbGrosor;
        private System.Windows.Forms.ToolStripButton tsbLinea;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton tsbTexto;
        private System.Windows.Forms.ToolStripButton tsbBorrarSeleccion;
        private System.Windows.Forms.ToolStripMenuItem tipoLíneaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discontinuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discontinuaYPuntosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem punteadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem discontinuaYDoblePuntoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itSolidoLinea;
        private System.Windows.Forms.ToolStripMenuItem tipoRellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasVerticalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuadriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasHorizontalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineasEnZigZagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mosaicoEscocésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itSolido;
        private System.Windows.Forms.ToolStripMenuItem sinRellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel tsl1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tsl2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tsl3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel tsl4;
        private System.Windows.Forms.OpenFileDialog dlgAbrirDibujo;
        private System.Windows.Forms.ToolStripMenuItem itAbrir;
        private System.Windows.Forms.ToolStripMenuItem itGuardar;
        private System.Windows.Forms.SaveFileDialog dlgGuardar;
    }
}

