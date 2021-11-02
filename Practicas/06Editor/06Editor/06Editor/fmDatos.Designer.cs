namespace _06Editor
{
    partial class fmDatos
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
            this.lbDato = new System.Windows.Forms.Label();
            this.tbDato = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDato
            // 
            this.lbDato.AutoSize = true;
            this.lbDato.Location = new System.Drawing.Point(60, 45);
            this.lbDato.Name = "lbDato";
            this.lbDato.Size = new System.Drawing.Size(38, 17);
            this.lbDato.TabIndex = 2;
            this.lbDato.Text = "Dato";
            // 
            // tbDato
            // 
            this.tbDato.Location = new System.Drawing.Point(63, 65);
            this.tbDato.Name = "tbDato";
            this.tbDato.Size = new System.Drawing.Size(349, 22);
            this.tbDato.TabIndex = 1;
            this.tbDato.TextChanged += new System.EventHandler(this.tbDato_TextChanged);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(80, 123);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 0;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(280, 123);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introducción de:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Location = new System.Drawing.Point(192, 175);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(36, 17);
            this.lbTipo.TabIndex = 5;
            this.lbTipo.Text = "Tipo";
            // 
            // fmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 218);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbDato);
            this.Controls.Add(this.lbDato);
            this.Name = "fmDatos";
            this.Text = "Petición dato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbDato;
        public System.Windows.Forms.Label lbTipo;
        public System.Windows.Forms.Button btAceptar;
        public System.Windows.Forms.TextBox tbDato;
    }
}