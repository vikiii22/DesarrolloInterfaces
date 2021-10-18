namespace ArrastrarYSoltar
{
    partial class fmPapelera
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVaciarPapelera = new System.Windows.Forms.Button();
            this.btRestaurarTodo = new System.Windows.Forms.Button();
            this.btRestaurarSeleccionados = new System.Windows.Forms.Button();
            this.lbPapelera = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btRestaurarSeleccionados);
            this.panel1.Controls.Add(this.btRestaurarTodo);
            this.panel1.Controls.Add(this.btVaciarPapelera);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 110);
            this.panel1.TabIndex = 0;
            // 
            // btVaciarPapelera
            // 
            this.btVaciarPapelera.AutoSize = true;
            this.btVaciarPapelera.Location = new System.Drawing.Point(12, 31);
            this.btVaciarPapelera.Name = "btVaciarPapelera";
            this.btVaciarPapelera.Size = new System.Drawing.Size(75, 44);
            this.btVaciarPapelera.TabIndex = 0;
            this.btVaciarPapelera.Text = "Vaciar\r\nPapelera";
            this.btVaciarPapelera.UseVisualStyleBackColor = true;
            // 
            // btRestaurarTodo
            // 
            this.btRestaurarTodo.AutoSize = true;
            this.btRestaurarTodo.Location = new System.Drawing.Point(160, 23);
            this.btRestaurarTodo.Name = "btRestaurarTodo";
            this.btRestaurarTodo.Size = new System.Drawing.Size(84, 61);
            this.btRestaurarTodo.TabIndex = 1;
            this.btRestaurarTodo.Text = "Restaurar\r\nTodos\r\nElementos";
            this.btRestaurarTodo.UseVisualStyleBackColor = true;
            // 
            // btRestaurarSeleccionados
            // 
            this.btRestaurarSeleccionados.AutoSize = true;
            this.btRestaurarSeleccionados.Location = new System.Drawing.Point(324, 23);
            this.btRestaurarSeleccionados.Name = "btRestaurarSeleccionados";
            this.btRestaurarSeleccionados.Size = new System.Drawing.Size(110, 61);
            this.btRestaurarSeleccionados.TabIndex = 2;
            this.btRestaurarSeleccionados.Text = "Restaurar\r\nElementos\r\nSeleccionados";
            this.btRestaurarSeleccionados.UseVisualStyleBackColor = true;
            // 
            // lbPapelera
            // 
            this.lbPapelera.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPapelera.FormattingEnabled = true;
            this.lbPapelera.ItemHeight = 16;
            this.lbPapelera.Location = new System.Drawing.Point(0, 110);
            this.lbPapelera.Name = "lbPapelera";
            this.lbPapelera.Size = new System.Drawing.Size(446, 420);
            this.lbPapelera.TabIndex = 1;
            // 
            // fmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 531);
            this.Controls.Add(this.lbPapelera);
            this.Controls.Add(this.panel1);
            this.Name = "fmPapelera";
            this.Text = "fmPapelera";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btRestaurarSeleccionados;
        private System.Windows.Forms.Button btRestaurarTodo;
        private System.Windows.Forms.Button btVaciarPapelera;
        public System.Windows.Forms.ListBox lbPapelera;
    }
}