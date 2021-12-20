namespace _01Datos
{
    partial class fmPrincipal
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
            this.btComandos = new System.Windows.Forms.Button();
            this.btAutomatico = new System.Windows.Forms.Button();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btComandos
            // 
            this.btComandos.AutoSize = true;
            this.btComandos.Location = new System.Drawing.Point(170, 117);
            this.btComandos.Name = "btComandos";
            this.btComandos.Size = new System.Drawing.Size(111, 27);
            this.btComandos.TabIndex = 0;
            this.btComandos.Text = "Por Comandos";
            this.btComandos.UseVisualStyleBackColor = true;
            this.btComandos.Click += new System.EventHandler(this.btComandos_Click);
            // 
            // btAutomatico
            // 
            this.btAutomatico.AutoSize = true;
            this.btAutomatico.Location = new System.Drawing.Point(170, 168);
            this.btAutomatico.Name = "btAutomatico";
            this.btAutomatico.Size = new System.Drawing.Size(111, 27);
            this.btAutomatico.TabIndex = 1;
            this.btAutomatico.Text = "Automatico";
            this.btAutomatico.UseVisualStyleBackColor = true;
            this.btAutomatico.Click += new System.EventHandler(this.btAutomatico_Click);
            // 
            // btFiltrar
            // 
            this.btFiltrar.AutoSize = true;
            this.btFiltrar.Location = new System.Drawing.Point(170, 219);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(111, 27);
            this.btFiltrar.TabIndex = 2;
            this.btFiltrar.Text = "Filtrar";
            this.btFiltrar.UseVisualStyleBackColor = true;
            this.btFiltrar.Click += new System.EventHandler(this.btFiltrar_Click);
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btFiltrar);
            this.Controls.Add(this.btAutomatico);
            this.Controls.Add(this.btComandos);
            this.Name = "fmPrincipal";
            this.Text = "Pantalla Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btComandos;
        private System.Windows.Forms.Button btAutomatico;
        private System.Windows.Forms.Button btFiltrar;
    }
}

