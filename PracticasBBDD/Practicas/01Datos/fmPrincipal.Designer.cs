
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
            this.btConsultasFiltros = new System.Windows.Forms.Button();
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btComandos
            // 
            this.btComandos.Location = new System.Drawing.Point(28, 25);
            this.btComandos.Name = "btComandos";
            this.btComandos.Size = new System.Drawing.Size(116, 23);
            this.btComandos.TabIndex = 0;
            this.btComandos.Text = "Por comandos";
            this.btComandos.UseVisualStyleBackColor = true;
            this.btComandos.Click += new System.EventHandler(this.btComandos_Click);
            // 
            // btAutomatico
            // 
            this.btAutomatico.Location = new System.Drawing.Point(28, 75);
            this.btAutomatico.Name = "btAutomatico";
            this.btAutomatico.Size = new System.Drawing.Size(116, 23);
            this.btAutomatico.TabIndex = 1;
            this.btAutomatico.Text = "Automático";
            this.btAutomatico.UseVisualStyleBackColor = true;
            this.btAutomatico.Click += new System.EventHandler(this.btAutomatico_Click);
            // 
            // btConsultasFiltros
            // 
            this.btConsultasFiltros.Location = new System.Drawing.Point(28, 124);
            this.btConsultasFiltros.Name = "btConsultasFiltros";
            this.btConsultasFiltros.Size = new System.Drawing.Size(116, 23);
            this.btConsultasFiltros.TabIndex = 2;
            this.btConsultasFiltros.Text = "Consultas y Filtros";
            this.btConsultasFiltros.UseVisualStyleBackColor = true;
            this.btConsultasFiltros.Click += new System.EventHandler(this.btConsultasFiltros_Click);
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.Location = new System.Drawing.Point(191, 98);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(116, 23);
            this.btAcercaDe.TabIndex = 3;
            this.btAcercaDe.Text = "Acerca de";
            this.btAcercaDe.UseVisualStyleBackColor = true;
            this.btAcercaDe.Click += new System.EventHandler(this.btAcercaDe_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(28, 169);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(116, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 224);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAcercaDe);
            this.Controls.Add(this.btConsultasFiltros);
            this.Controls.Add(this.btAutomatico);
            this.Controls.Add(this.btComandos);
            this.Name = "fmPrincipal";
            this.Text = "Pantalla principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btComandos;
        private System.Windows.Forms.Button btAutomatico;
        private System.Windows.Forms.Button btConsultasFiltros;
        private System.Windows.Forms.Button btAcercaDe;
        private System.Windows.Forms.Button btSalir;
    }
}

