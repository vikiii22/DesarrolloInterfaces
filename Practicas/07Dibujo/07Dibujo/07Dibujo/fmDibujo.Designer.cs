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
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.stGrafico = new System.Windows.Forms.StatusStrip();
            this.pbEditor = new System.Windows.Forms.PictureBox();
            this.pnColores = new System.Windows.Forms.Panel();
            this.traAzul = new System.Windows.Forms.TrackBar();
            this.traVerde = new System.Windows.Forms.TrackBar();
            this.laAzul = new System.Windows.Forms.Label();
            this.laVerde = new System.Windows.Forms.Label();
            this.traRojo = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.laPrueba = new System.Windows.Forms.Label();
            this.btCambiaColor = new System.Windows.Forms.Button();
            this.tsBarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).BeginInit();
            this.pnColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traRojo)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBarraBotones
            // 
            this.tsBarraBotones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBarraBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.tsBarraBotones.Location = new System.Drawing.Point(0, 0);
            this.tsBarraBotones.Name = "tsBarraBotones";
            this.tsBarraBotones.Size = new System.Drawing.Size(976, 27);
            this.tsBarraBotones.TabIndex = 0;
            this.tsBarraBotones.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // stGrafico
            // 
            this.stGrafico.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stGrafico.Location = new System.Drawing.Point(0, 490);
            this.stGrafico.Name = "stGrafico";
            this.stGrafico.Size = new System.Drawing.Size(976, 22);
            this.stGrafico.TabIndex = 1;
            this.stGrafico.Text = "statusStrip1";
            // 
            // pbEditor
            // 
            this.pbEditor.BackColor = System.Drawing.Color.White;
            this.pbEditor.Location = new System.Drawing.Point(47, 73);
            this.pbEditor.Name = "pbEditor";
            this.pbEditor.Size = new System.Drawing.Size(645, 373);
            this.pbEditor.TabIndex = 2;
            this.pbEditor.TabStop = false;
            this.pbEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbEditor_MouseMove);
            // 
            // pnColores
            // 
            this.pnColores.Controls.Add(this.traAzul);
            this.pnColores.Controls.Add(this.traVerde);
            this.pnColores.Controls.Add(this.laAzul);
            this.pnColores.Controls.Add(this.laVerde);
            this.pnColores.Controls.Add(this.traRojo);
            this.pnColores.Controls.Add(this.label1);
            this.pnColores.Controls.Add(this.laPrueba);
            this.pnColores.Enabled = false;
            this.pnColores.Location = new System.Drawing.Point(737, 82);
            this.pnColores.Name = "pnColores";
            this.pnColores.Size = new System.Drawing.Size(200, 364);
            this.pnColores.TabIndex = 3;
            // 
            // traAzul
            // 
            this.traAzul.Location = new System.Drawing.Point(30, 278);
            this.traAzul.Maximum = 255;
            this.traAzul.Name = "traAzul";
            this.traAzul.Size = new System.Drawing.Size(139, 56);
            this.traAzul.TabIndex = 6;
            // 
            // traVerde
            // 
            this.traVerde.Location = new System.Drawing.Point(30, 169);
            this.traVerde.Maximum = 255;
            this.traVerde.Name = "traVerde";
            this.traVerde.Size = new System.Drawing.Size(132, 56);
            this.traVerde.TabIndex = 5;
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
            this.btCambiaColor.Location = new System.Drawing.Point(770, 49);
            this.btCambiaColor.Name = "btCambiaColor";
            this.btCambiaColor.Size = new System.Drawing.Size(136, 27);
            this.btCambiaColor.TabIndex = 4;
            this.btCambiaColor.Text = "Prueba de Colores";
            this.btCambiaColor.UseVisualStyleBackColor = true;
            this.btCambiaColor.Click += new System.EventHandler(this.btCambiaColor_Click);
            // 
            // fmDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 512);
            this.Controls.Add(this.btCambiaColor);
            this.Controls.Add(this.pnColores);
            this.Controls.Add(this.pbEditor);
            this.Controls.Add(this.stGrafico);
            this.Controls.Add(this.tsBarraBotones);
            this.Name = "fmDibujo";
            this.Text = "Dibujo";
            this.Load += new System.EventHandler(this.fmDibujo_Load);
            this.tsBarraBotones.ResumeLayout(false);
            this.tsBarraBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).EndInit();
            this.pnColores.ResumeLayout(false);
            this.pnColores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traRojo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBarraBotones;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
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
    }
}

