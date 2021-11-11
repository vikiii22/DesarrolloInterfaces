namespace _07Dibujo
{
    partial class fmDibujo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDibujo));
            this.tsBarraBotones = new System.Windows.Forms.ToolStrip();
            this.tsbLinea = new System.Windows.Forms.ToolStripButton();
            this.tsbCuadrado = new System.Windows.Forms.ToolStripButton();
            this.tsbRectangulo = new System.Windows.Forms.ToolStripButton();
            this.tsbArco = new System.Windows.Forms.ToolStripButton();
            this.tsbCirculo = new System.Windows.Forms.ToolStripButton();
            this.tsbPol = new System.Windows.Forms.ToolStripButton();
            this.tsbElip = new System.Windows.Forms.ToolStripButton();
            this.tsbPoligono = new System.Windows.Forms.ToolStripButton();
            this.tsbCurvaAbierta = new System.Windows.Forms.ToolStripButton();
            this.tsbCurvaCerrada = new System.Windows.Forms.ToolStripButton();
            this.tsbTXT = new System.Windows.Forms.ToolStripButton();
            this.stGrafico = new System.Windows.Forms.StatusStrip();
            this.tsl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspDemostracion = new System.Windows.Forms.ToolStripProgressBar();
            this.pbEditor = new System.Windows.Forms.PictureBox();
            this.pnColores = new System.Windows.Forms.Panel();
            this.btAplicar = new System.Windows.Forms.Button();
            this.traAzul = new System.Windows.Forms.TrackBar();
            this.traVerde = new System.Windows.Forms.TrackBar();
            this.laAzul = new System.Windows.Forms.Label();
            this.laVerde = new System.Windows.Forms.Label();
            this.traRojo = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.laPrueba = new System.Windows.Forms.Label();
            this.btCambiaColor = new System.Windows.Forms.Button();
            this.ckRelleno = new System.Windows.Forms.CheckBox();
            this.btDemo = new System.Windows.Forms.Button();
            this.pbDemo = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgGuardarDibujo = new System.Windows.Forms.SaveFileDialog();
            this.dlgAbrirDibujo = new System.Windows.Forms.OpenFileDialog();
            this.tsBarraBotones.SuspendLayout();
            this.stGrafico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).BeginInit();
            this.pnColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traRojo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBarraBotones
            // 
            this.tsBarraBotones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBarraBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLinea,
            this.tsbCuadrado,
            this.tsbRectangulo,
            this.tsbArco,
            this.tsbCirculo,
            this.tsbPol,
            this.tsbElip,
            this.tsbPoligono,
            this.tsbCurvaAbierta,
            this.tsbCurvaCerrada,
            this.tsbTXT});
            this.tsBarraBotones.Location = new System.Drawing.Point(0, 28);
            this.tsBarraBotones.Name = "tsBarraBotones";
            this.tsBarraBotones.Size = new System.Drawing.Size(1233, 27);
            this.tsBarraBotones.TabIndex = 0;
            this.tsBarraBotones.Text = "toolStrip1";
            // 
            // tsbLinea
            // 
            this.tsbLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLinea.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinea.Image")));
            this.tsbLinea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinea.Name = "tsbLinea";
            this.tsbLinea.Size = new System.Drawing.Size(35, 24);
            this.tsbLinea.Text = "LIN";
            this.tsbLinea.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbCuadrado
            // 
            this.tsbCuadrado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("tsbCuadrado.Image")));
            this.tsbCuadrado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCuadrado.Name = "tsbCuadrado";
            this.tsbCuadrado.Size = new System.Drawing.Size(42, 24);
            this.tsbCuadrado.Text = "CUA";
            // 
            // tsbRectangulo
            // 
            this.tsbRectangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRectangulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRectangulo.Image")));
            this.tsbRectangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRectangulo.Name = "tsbRectangulo";
            this.tsbRectangulo.Size = new System.Drawing.Size(39, 24);
            this.tsbRectangulo.Text = "REC";
            // 
            // tsbArco
            // 
            this.tsbArco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbArco.Image = ((System.Drawing.Image)(resources.GetObject("tsbArco.Image")));
            this.tsbArco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArco.Name = "tsbArco";
            this.tsbArco.Size = new System.Drawing.Size(52, 24);
            this.tsbArco.Text = "ARCO";
            // 
            // tsbCirculo
            // 
            this.tsbCirculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCirculo.Image = ((System.Drawing.Image)(resources.GetObject("tsbCirculo.Image")));
            this.tsbCirculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCirculo.Name = "tsbCirculo";
            this.tsbCirculo.Size = new System.Drawing.Size(35, 24);
            this.tsbCirculo.Text = "CIR";
            // 
            // tsbPol
            // 
            this.tsbPol.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPol.Image = ((System.Drawing.Image)(resources.GetObject("tsbPol.Image")));
            this.tsbPol.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPol.Name = "tsbPol";
            this.tsbPol.Size = new System.Drawing.Size(39, 24);
            this.tsbPol.Text = "POL";
            // 
            // tsbElip
            // 
            this.tsbElip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbElip.Image = ((System.Drawing.Image)(resources.GetObject("tsbElip.Image")));
            this.tsbElip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbElip.Name = "tsbElip";
            this.tsbElip.Size = new System.Drawing.Size(40, 24);
            this.tsbElip.Text = "ELIP";
            // 
            // tsbPoligono
            // 
            this.tsbPoligono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPoligono.Image = ((System.Drawing.Image)(resources.GetObject("tsbPoligono.Image")));
            this.tsbPoligono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPoligono.Name = "tsbPoligono";
            this.tsbPoligono.Size = new System.Drawing.Size(39, 24);
            this.tsbPoligono.Text = "POL";
            // 
            // tsbCurvaAbierta
            // 
            this.tsbCurvaAbierta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCurvaAbierta.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurvaAbierta.Image")));
            this.tsbCurvaAbierta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurvaAbierta.Name = "tsbCurvaAbierta";
            this.tsbCurvaAbierta.Size = new System.Drawing.Size(51, 24);
            this.tsbCurvaAbierta.Text = "CURA";
            // 
            // tsbCurvaCerrada
            // 
            this.tsbCurvaCerrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCurvaCerrada.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurvaCerrada.Image")));
            this.tsbCurvaCerrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurvaCerrada.Name = "tsbCurvaCerrada";
            this.tsbCurvaCerrada.Size = new System.Drawing.Size(50, 24);
            this.tsbCurvaCerrada.Text = "CURC";
            // 
            // tsbTXT
            // 
            this.tsbTXT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTXT.Image = ((System.Drawing.Image)(resources.GetObject("tsbTXT.Image")));
            this.tsbTXT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTXT.Name = "tsbTXT";
            this.tsbTXT.Size = new System.Drawing.Size(38, 24);
            this.tsbTXT.Text = "TXT";
            // 
            // stGrafico
            // 
            this.stGrafico.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stGrafico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl1,
            this.tsl2,
            this.tspDemostracion});
            this.stGrafico.Location = new System.Drawing.Point(0, 534);
            this.stGrafico.Name = "stGrafico";
            this.stGrafico.Size = new System.Drawing.Size(1233, 25);
            this.stGrafico.TabIndex = 1;
            this.stGrafico.Text = "statusStrip1";
            // 
            // tsl1
            // 
            this.tsl1.AutoSize = false;
            this.tsl1.Name = "tsl1";
            this.tsl1.Size = new System.Drawing.Size(137, 20);
            // 
            // tsl2
            // 
            this.tsl2.AutoSize = false;
            this.tsl2.Name = "tsl2";
            this.tsl2.Size = new System.Drawing.Size(137, 20);
            // 
            // tspDemostracion
            // 
            this.tspDemostracion.ForeColor = System.Drawing.Color.Chartreuse;
            this.tspDemostracion.Name = "tspDemostracion";
            this.tspDemostracion.Size = new System.Drawing.Size(250, 19);
            this.tspDemostracion.Step = 5;
            this.tspDemostracion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // pbEditor
            // 
            this.pbEditor.BackColor = System.Drawing.Color.White;
            this.pbEditor.Location = new System.Drawing.Point(46, 80);
            this.pbEditor.Name = "pbEditor";
            this.pbEditor.Size = new System.Drawing.Size(868, 399);
            this.pbEditor.TabIndex = 2;
            this.pbEditor.TabStop = false;
            this.pbEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbEditor_MouseMove);
            // 
            // pnColores
            // 
            this.pnColores.Controls.Add(this.btAplicar);
            this.pnColores.Controls.Add(this.traAzul);
            this.pnColores.Controls.Add(this.traVerde);
            this.pnColores.Controls.Add(this.laAzul);
            this.pnColores.Controls.Add(this.laVerde);
            this.pnColores.Controls.Add(this.traRojo);
            this.pnColores.Controls.Add(this.label1);
            this.pnColores.Controls.Add(this.laPrueba);
            this.pnColores.Enabled = false;
            this.pnColores.Location = new System.Drawing.Point(984, 80);
            this.pnColores.Name = "pnColores";
            this.pnColores.Size = new System.Drawing.Size(200, 364);
            this.pnColores.TabIndex = 3;
            // 
            // btAplicar
            // 
            this.btAplicar.AutoSize = true;
            this.btAplicar.Location = new System.Drawing.Point(60, 334);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(75, 27);
            this.btAplicar.TabIndex = 7;
            this.btAplicar.Text = "Aplicar";
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Visible = false;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // traAzul
            // 
            this.traAzul.Location = new System.Drawing.Point(30, 278);
            this.traAzul.Maximum = 255;
            this.traAzul.Name = "traAzul";
            this.traAzul.Size = new System.Drawing.Size(139, 56);
            this.traAzul.TabIndex = 6;
            this.traAzul.Scroll += new System.EventHandler(this.traRojo_Scroll);
            // 
            // traVerde
            // 
            this.traVerde.Location = new System.Drawing.Point(30, 169);
            this.traVerde.Maximum = 255;
            this.traVerde.Name = "traVerde";
            this.traVerde.Size = new System.Drawing.Size(132, 56);
            this.traVerde.TabIndex = 5;
            this.traVerde.Scroll += new System.EventHandler(this.traRojo_Scroll);
            // 
            // laAzul
            // 
            this.laAzul.AutoSize = true;
            this.laAzul.Location = new System.Drawing.Point(27, 258);
            this.laAzul.Name = "laAzul";
            this.laAzul.Size = new System.Drawing.Size(35, 17);
            this.laAzul.TabIndex = 4;
            this.laAzul.Text = "Azul";
            // 
            // laVerde
            // 
            this.laVerde.AutoSize = true;
            this.laVerde.Location = new System.Drawing.Point(30, 149);
            this.laVerde.Name = "laVerde";
            this.laVerde.Size = new System.Drawing.Size(46, 17);
            this.laVerde.TabIndex = 3;
            this.laVerde.Text = "Verde";
            // 
            // traRojo
            // 
            this.traRojo.Location = new System.Drawing.Point(30, 73);
            this.traRojo.Maximum = 255;
            this.traRojo.Name = "traRojo";
            this.traRojo.Size = new System.Drawing.Size(132, 56);
            this.traRojo.TabIndex = 2;
            this.traRojo.Scroll += new System.EventHandler(this.traRojo_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rojo";
            // 
            // laPrueba
            // 
            this.laPrueba.AutoSize = true;
            this.laPrueba.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.laPrueba.ForeColor = System.Drawing.Color.White;
            this.laPrueba.Location = new System.Drawing.Point(38, 26);
            this.laPrueba.Name = "laPrueba";
            this.laPrueba.Size = new System.Drawing.Size(124, 17);
            this.laPrueba.TabIndex = 0;
            this.laPrueba.Text = "Prueba de colores";
            // 
            // btCambiaColor
            // 
            this.btCambiaColor.AutoSize = true;
            this.btCambiaColor.Location = new System.Drawing.Point(1017, 47);
            this.btCambiaColor.Name = "btCambiaColor";
            this.btCambiaColor.Size = new System.Drawing.Size(136, 27);
            this.btCambiaColor.TabIndex = 4;
            this.btCambiaColor.Text = "Prueba de Colores";
            this.btCambiaColor.UseVisualStyleBackColor = true;
            this.btCambiaColor.Click += new System.EventHandler(this.btCambiaColor_Click);
            // 
            // ckRelleno
            // 
            this.ckRelleno.AutoSize = true;
            this.ckRelleno.Location = new System.Drawing.Point(46, 53);
            this.ckRelleno.Name = "ckRelleno";
            this.ckRelleno.Size = new System.Drawing.Size(107, 21);
            this.ckRelleno.TabIndex = 5;
            this.ckRelleno.Text = "Con Relleno";
            this.ckRelleno.UseVisualStyleBackColor = true;
            // 
            // btDemo
            // 
            this.btDemo.AutoSize = true;
            this.btDemo.Location = new System.Drawing.Point(105, 499);
            this.btDemo.Name = "btDemo";
            this.btDemo.Size = new System.Drawing.Size(105, 27);
            this.btDemo.TabIndex = 6;
            this.btDemo.Text = "Demostración";
            this.btDemo.UseVisualStyleBackColor = true;
            this.btDemo.Click += new System.EventHandler(this.btDemo_Click);
            // 
            // pbDemo
            // 
            this.pbDemo.Location = new System.Drawing.Point(267, 489);
            this.pbDemo.Name = "pbDemo";
            this.pbDemo.Size = new System.Drawing.Size(447, 37);
            this.pbDemo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbDemo.TabIndex = 7;
            this.pbDemo.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1233, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevo,
            this.toolStripMenuItem1,
            this.tsmAbrir,
            this.tsmGuardar,
            this.toolStripMenuItem2,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(216, 26);
            this.tsmNuevo.Text = "Nuevo";
            this.tsmNuevo.Click += new System.EventHandler(this.tsmNuevo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // tsmAbrir
            // 
            this.tsmAbrir.Name = "tsmAbrir";
            this.tsmAbrir.Size = new System.Drawing.Size(216, 26);
            this.tsmAbrir.Text = "Abrir";
            this.tsmAbrir.Click += new System.EventHandler(this.tsmAbrir_Click);
            // 
            // tsmGuardar
            // 
            this.tsmGuardar.Name = "tsmGuardar";
            this.tsmGuardar.Size = new System.Drawing.Size(216, 26);
            this.tsmGuardar.Text = "Guardar";
            this.tsmGuardar.Click += new System.EventHandler(this.tsmGuardar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca De";
            // 
            // dlgGuardarDibujo
            // 
            this.dlgGuardarDibujo.AutoUpgradeEnabled = false;
            this.dlgGuardarDibujo.DefaultExt = "bmp";
            this.dlgGuardarDibujo.Filter = "Archivo Mapa de Bits (.bmp) | *.bmp | Archivo JPG (.jpg) | *.jpg | Todos los Arch" +
    "ivos (*.*)|*.*";
            this.dlgGuardarDibujo.InitialDirectory = ".\\ficheros";
            // 
            // dlgAbrirDibujo
            // 
            this.dlgAbrirDibujo.AutoUpgradeEnabled = false;
            this.dlgAbrirDibujo.DefaultExt = "bmp";
            this.dlgAbrirDibujo.FileName = "openFileDialog1";
            this.dlgAbrirDibujo.Filter = "Archivo Mapa de Bits (.bmp)|*.bmp | Archivo JPG (.jpg)|*.jpg | Todos los Archivos" +
    " (*.*)|*.*";
            this.dlgAbrirDibujo.InitialDirectory = ".\\ficheros";
            // 
            // fmDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 559);
            this.Controls.Add(this.pbDemo);
            this.Controls.Add(this.btDemo);
            this.Controls.Add(this.ckRelleno);
            this.Controls.Add(this.btCambiaColor);
            this.Controls.Add(this.pnColores);
            this.Controls.Add(this.pbEditor);
            this.Controls.Add(this.stGrafico);
            this.Controls.Add(this.tsBarraBotones);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmDibujo";
            this.Text = "Dibujo";
            this.Load += new System.EventHandler(this.fmDibujo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmDibujo_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.fmDibujo_MouseDown);
            this.tsBarraBotones.ResumeLayout(false);
            this.tsBarraBotones.PerformLayout();
            this.stGrafico.ResumeLayout(false);
            this.stGrafico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).EndInit();
            this.pnColores.ResumeLayout(false);
            this.pnColores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traRojo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraBotones;
        private System.Windows.Forms.ToolStripButton tsbLinea;
        private System.Windows.Forms.StatusStrip stGrafico;
        private System.Windows.Forms.PictureBox pbEditor;
        private System.Windows.Forms.Panel pnColores;
        private System.Windows.Forms.Label laPrueba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar traRojo;
        private System.Windows.Forms.TrackBar traAzul;
        private System.Windows.Forms.TrackBar traVerde;
        private System.Windows.Forms.Label laAzul;
        private System.Windows.Forms.Label laVerde;
        private System.Windows.Forms.Button btCambiaColor;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.ToolStripButton tsbCuadrado;
        private System.Windows.Forms.ToolStripButton tsbRectangulo;
        private System.Windows.Forms.ToolStripButton tsbArco;
        private System.Windows.Forms.ToolStripButton tsbCirculo;
        private System.Windows.Forms.ToolStripButton tsbPol;
        private System.Windows.Forms.ToolStripButton tsbElip;
        private System.Windows.Forms.ToolStripButton tsbPoligono;
        private System.Windows.Forms.ToolStripButton tsbCurvaAbierta;
        private System.Windows.Forms.ToolStripButton tsbCurvaCerrada;
        private System.Windows.Forms.CheckBox ckRelleno;
        private System.Windows.Forms.ToolStripButton tsbTXT;
        private System.Windows.Forms.ToolStripStatusLabel tsl1;
        private System.Windows.Forms.ToolStripStatusLabel tsl2;
        private System.Windows.Forms.ToolStripProgressBar tspDemostracion;
        private System.Windows.Forms.Button btDemo;
        private System.Windows.Forms.ProgressBar pbDemo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsmGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog dlgGuardarDibujo;
        private System.Windows.Forms.OpenFileDialog dlgAbrirDibujo;
    }
}

