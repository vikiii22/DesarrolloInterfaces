﻿namespace _05MiniEditor
{
    partial class fmEditorTextos
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbAlineacion = new System.Windows.Forms.GroupBox();
            this.rbDerecha = new System.Windows.Forms.RadioButton();
            this.rbCentrada = new System.Windows.Forms.RadioButton();
            this.rbIzquierda = new System.Windows.Forms.RadioButton();
            this.gbEstilo = new System.Windows.Forms.GroupBox();
            this.cbTachado = new System.Windows.Forms.CheckBox();
            this.cbCursiva = new System.Windows.Forms.CheckBox();
            this.cbSubrayado = new System.Windows.Forms.CheckBox();
            this.cbNegrita = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbColores = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.cbTamanio = new System.Windows.Forms.ComboBox();
            this.cbFuente = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.gbAlineacion.SuspendLayout();
            this.gbEstilo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbAlineacion);
            this.panel1.Controls.Add(this.gbEstilo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbColores);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btGuardar);
            this.panel1.Controls.Add(this.btAbrir);
            this.panel1.Controls.Add(this.cbTamanio);
            this.panel1.Controls.Add(this.cbFuente);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 257);
            this.panel1.TabIndex = 10;
            // 
            // gbAlineacion
            // 
            this.gbAlineacion.Controls.Add(this.rbDerecha);
            this.gbAlineacion.Controls.Add(this.rbCentrada);
            this.gbAlineacion.Controls.Add(this.rbIzquierda);
            this.gbAlineacion.Location = new System.Drawing.Point(705, 50);
            this.gbAlineacion.Name = "gbAlineacion";
            this.gbAlineacion.Size = new System.Drawing.Size(251, 157);
            this.gbAlineacion.TabIndex = 21;
            this.gbAlineacion.TabStop = false;
            this.gbAlineacion.Text = "Alineación";
            // 
            // rbDerecha
            // 
            this.rbDerecha.AutoSize = true;
            this.rbDerecha.Location = new System.Drawing.Point(78, 114);
            this.rbDerecha.Name = "rbDerecha";
            this.rbDerecha.Size = new System.Drawing.Size(83, 21);
            this.rbDerecha.TabIndex = 2;
            this.rbDerecha.Text = "Derecha";
            this.rbDerecha.UseVisualStyleBackColor = true;
            this.rbDerecha.CheckedChanged += new System.EventHandler(this.rbIzquierda_CheckedChanged);
            // 
            // rbCentrada
            // 
            this.rbCentrada.AutoSize = true;
            this.rbCentrada.Location = new System.Drawing.Point(78, 74);
            this.rbCentrada.Name = "rbCentrada";
            this.rbCentrada.Size = new System.Drawing.Size(87, 21);
            this.rbCentrada.TabIndex = 1;
            this.rbCentrada.Text = "Centrada";
            this.rbCentrada.UseVisualStyleBackColor = true;
            this.rbCentrada.CheckedChanged += new System.EventHandler(this.rbIzquierda_CheckedChanged);
            // 
            // rbIzquierda
            // 
            this.rbIzquierda.AutoSize = true;
            this.rbIzquierda.Checked = true;
            this.rbIzquierda.Location = new System.Drawing.Point(78, 35);
            this.rbIzquierda.Name = "rbIzquierda";
            this.rbIzquierda.Size = new System.Drawing.Size(87, 21);
            this.rbIzquierda.TabIndex = 0;
            this.rbIzquierda.TabStop = true;
            this.rbIzquierda.Text = "Izquierda";
            this.rbIzquierda.UseVisualStyleBackColor = true;
            this.rbIzquierda.CheckedChanged += new System.EventHandler(this.rbIzquierda_CheckedChanged);
            // 
            // gbEstilo
            // 
            this.gbEstilo.Controls.Add(this.cbTachado);
            this.gbEstilo.Controls.Add(this.cbCursiva);
            this.gbEstilo.Controls.Add(this.cbSubrayado);
            this.gbEstilo.Controls.Add(this.cbNegrita);
            this.gbEstilo.Location = new System.Drawing.Point(502, 50);
            this.gbEstilo.Name = "gbEstilo";
            this.gbEstilo.Size = new System.Drawing.Size(132, 171);
            this.gbEstilo.TabIndex = 20;
            this.gbEstilo.TabStop = false;
            this.gbEstilo.Text = "Estilo";
            // 
            // cbTachado
            // 
            this.cbTachado.AutoSize = true;
            this.cbTachado.Location = new System.Drawing.Point(27, 126);
            this.cbTachado.Name = "cbTachado";
            this.cbTachado.Size = new System.Drawing.Size(86, 21);
            this.cbTachado.TabIndex = 3;
            this.cbTachado.Text = "Tachado";
            this.cbTachado.UseVisualStyleBackColor = true;
            this.cbTachado.CheckedChanged += new System.EventHandler(this.cbNegrita_CheckedChanged);
            // 
            // cbCursiva
            // 
            this.cbCursiva.AutoSize = true;
            this.cbCursiva.Location = new System.Drawing.Point(27, 90);
            this.cbCursiva.Name = "cbCursiva";
            this.cbCursiva.Size = new System.Drawing.Size(77, 21);
            this.cbCursiva.TabIndex = 2;
            this.cbCursiva.Text = "Cursiva";
            this.cbCursiva.UseVisualStyleBackColor = true;
            this.cbCursiva.CheckedChanged += new System.EventHandler(this.cbNegrita_CheckedChanged);
            // 
            // cbSubrayado
            // 
            this.cbSubrayado.AutoSize = true;
            this.cbSubrayado.Location = new System.Drawing.Point(27, 51);
            this.cbSubrayado.Name = "cbSubrayado";
            this.cbSubrayado.Size = new System.Drawing.Size(99, 21);
            this.cbSubrayado.TabIndex = 1;
            this.cbSubrayado.Text = "Subrayado";
            this.cbSubrayado.UseVisualStyleBackColor = true;
            this.cbSubrayado.CheckedChanged += new System.EventHandler(this.cbNegrita_CheckedChanged);
            // 
            // cbNegrita
            // 
            this.cbNegrita.AutoSize = true;
            this.cbNegrita.Location = new System.Drawing.Point(28, 21);
            this.cbNegrita.Name = "cbNegrita";
            this.cbNegrita.Size = new System.Drawing.Size(76, 21);
            this.cbNegrita.TabIndex = 0;
            this.cbNegrita.Text = "Negrita";
            this.cbNegrita.UseVisualStyleBackColor = true;
            this.cbNegrita.CheckedChanged += new System.EventHandler(this.cbNegrita_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Color de la fuente";
            // 
            // lbColores
            // 
            this.lbColores.FormattingEnabled = true;
            this.lbColores.ItemHeight = 16;
            this.lbColores.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Gris",
            "Amarillo",
            "Naranja",
            "Negro"});
            this.lbColores.Location = new System.Drawing.Point(275, 121);
            this.lbColores.Name = "lbColores";
            this.lbColores.Size = new System.Drawing.Size(120, 116);
            this.lbColores.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nombre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tamaño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Fuente";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(45, 151);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 13;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(45, 122);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 12;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            // 
            // cbTamanio
            // 
            this.cbTamanio.FormattingEnabled = true;
            this.cbTamanio.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "24",
            "26",
            "28",
            "32"});
            this.cbTamanio.Location = new System.Drawing.Point(275, 63);
            this.cbTamanio.MaxLength = 2;
            this.cbTamanio.Name = "cbTamanio";
            this.cbTamanio.Size = new System.Drawing.Size(67, 24);
            this.cbTamanio.TabIndex = 11;
            this.cbTamanio.TextChanged += new System.EventHandler(this.cbTamanio_TextChanged);
            this.cbTamanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTamanio_KeyPress);
            // 
            // cbFuente
            // 
            this.cbFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuente.FormattingEnabled = true;
            this.cbFuente.Location = new System.Drawing.Point(42, 63);
            this.cbFuente.Name = "cbFuente";
            this.cbFuente.Size = new System.Drawing.Size(155, 24);
            this.cbFuente.TabIndex = 10;
            this.cbFuente.TextChanged += new System.EventHandler(this.cbFuente_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.ediciónToolStripMenuItem,
            this.formatoToolStripMenuItem1,
            this.ayudaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1003, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem1.Text = "A&rchivo";
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // formatoToolStripMenuItem1
            // 
            this.formatoToolStripMenuItem1.Name = "formatoToolStripMenuItem1";
            this.formatoToolStripMenuItem1.Size = new System.Drawing.Size(77, 24);
            this.formatoToolStripMenuItem1.Text = "&Formato";
            // 
            // ayudaToolStripMenuItem1
            // 
            this.ayudaToolStripMenuItem1.Name = "ayudaToolStripMenuItem1";
            this.ayudaToolStripMenuItem1.Size = new System.Drawing.Size(63, 24);
            this.ayudaToolStripMenuItem1.Text = "Ayuda";
            // 
            // rtbEditor
            // 
            this.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbEditor.Location = new System.Drawing.Point(0, 257);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(1003, 309);
            this.rtbEditor.TabIndex = 11;
            this.rtbEditor.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 100);
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.archivoToolStripMenuItem.Text = "A&rchivo";
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.formatoToolStripMenuItem.Text = "&Formato";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // fmEditorTextos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 566);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fmEditorTextos";
            this.Text = "Editor de textos";
            this.Load += new System.EventHandler(this.fmEditorTextos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbAlineacion.ResumeLayout(false);
            this.gbAlineacion.PerformLayout();
            this.gbEstilo.ResumeLayout(false);
            this.gbEstilo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbColores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.ComboBox cbTamanio;
        private System.Windows.Forms.ComboBox cbFuente;
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.GroupBox gbEstilo;
        private System.Windows.Forms.CheckBox cbNegrita;
        private System.Windows.Forms.CheckBox cbTachado;
        private System.Windows.Forms.CheckBox cbCursiva;
        private System.Windows.Forms.CheckBox cbSubrayado;
        private System.Windows.Forms.GroupBox gbAlineacion;
        private System.Windows.Forms.RadioButton rbDerecha;
        private System.Windows.Forms.RadioButton rbCentrada;
        private System.Windows.Forms.RadioButton rbIzquierda;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem1;
    }
}

