
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
            this.SuspendLayout();
            // 
            // btComandos
            // 
            this.btComandos.Location = new System.Drawing.Point(302, 115);
            this.btComandos.Name = "btComandos";
            this.btComandos.Size = new System.Drawing.Size(116, 23);
            this.btComandos.TabIndex = 0;
            this.btComandos.Text = "Por comandos";
            this.btComandos.UseVisualStyleBackColor = true;
            this.btComandos.Click += new System.EventHandler(this.btComandos_Click);
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btComandos);
            this.Name = "fmPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btComandos;
    }
}

