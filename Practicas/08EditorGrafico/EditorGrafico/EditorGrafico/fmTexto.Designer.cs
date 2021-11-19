namespace EditorGrafico
{
    partial class fmTexto
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
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.btFuente = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAplicar = new System.Windows.Forms.Button();
            this.dlgFuente = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(27, 41);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(227, 22);
            this.tbTexto.TabIndex = 0;
            // 
            // btFuente
            // 
            this.btFuente.Location = new System.Drawing.Point(295, 40);
            this.btFuente.Name = "btFuente";
            this.btFuente.Size = new System.Drawing.Size(30, 23);
            this.btFuente.TabIndex = 1;
            this.btFuente.Text = "button1";
            this.btFuente.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSalir.Location = new System.Drawing.Point(367, 40);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(30, 23);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "button2";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btAplicar
            // 
            this.btAplicar.Location = new System.Drawing.Point(331, 40);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(30, 23);
            this.btAplicar.TabIndex = 3;
            this.btAplicar.Text = "button3";
            this.btAplicar.UseVisualStyleBackColor = true;
            // 
            // dlgFuente
            // 
            this.dlgFuente.ShowColor = true;
            // 
            // fmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 109);
            this.ControlBox = false;
            this.Controls.Add(this.btAplicar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btFuente);
            this.Controls.Add(this.tbTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmTexto";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.Button btFuente;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.FontDialog dlgFuente;
    }
}