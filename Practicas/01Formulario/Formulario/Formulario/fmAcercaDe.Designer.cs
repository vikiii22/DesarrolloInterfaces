namespace Formulario
{
    partial class fmAcercaDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAcercaDe));
            this.lbAutor = new System.Windows.Forms.Label();
            this.lbProyecto = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAutor
            // 
            this.lbAutor.AutoSize = true;
            this.lbAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutor.Location = new System.Drawing.Point(290, 60);
            this.lbAutor.Name = "lbAutor";
            this.lbAutor.Size = new System.Drawing.Size(327, 25);
            this.lbAutor.TabIndex = 0;
            this.lbAutor.Text = "Autor: Jose Antonio Sánchez López";
            // 
            // lbProyecto
            // 
            this.lbProyecto.AutoSize = true;
            this.lbProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProyecto.Location = new System.Drawing.Point(290, 96);
            this.lbProyecto.Name = "lbProyecto";
            this.lbProyecto.Size = new System.Drawing.Size(214, 25);
            this.lbProyecto.TabIndex = 1;
            this.lbProyecto.Text = "Proyecto: El Formulario";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(290, 132);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(254, 75);
            this.lbVersion.TabIndex = 2;
            this.lbVersion.Text = "Versión 1\r\n\r\nFecha: Septiembre de 2021";
            // 
            // pbImagen
            // 
            this.pbImagen.Image = ((System.Drawing.Image)(resources.GetObject("pbImagen.Image")));
            this.pbImagen.Location = new System.Drawing.Point(22, 7);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(244, 229);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagen.TabIndex = 3;
            this.pbImagen.TabStop = false;
            // 
            // btAceptar
            // 
            this.btAceptar.AutoSize = true;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btAceptar.Location = new System.Drawing.Point(581, 338);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(90, 35);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Proyecto para practicar distintos controles, como botones y \r\nlabel en el formula" +
    "rio. Sus propiedades y eventos.";
            // 
            // fmAcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 385);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.pbImagen);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbProyecto);
            this.Controls.Add(this.lbAutor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca De";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAutor;
        private System.Windows.Forms.Label lbProyecto;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Label label1;
    }
}