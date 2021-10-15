namespace ArrastrarYSoltar
{
    partial class fmArrastrarYSoltar
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
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.cbOrdenar = new System.Windows.Forms.CheckBox();
            this.cbOrdenar2 = new System.Windows.Forms.CheckBox();
            this.btBorra1 = new System.Windows.Forms.Button();
            this.btBorraTodo1 = new System.Windows.Forms.Button();
            this.btBorra2 = new System.Windows.Forms.Button();
            this.btBorraTodo2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btPapelera = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AllowDrop = true;
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 16;
            this.lb1.Location = new System.Drawing.Point(107, 178);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(210, 276);
            this.lb1.TabIndex = 0;
            this.lb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb1_DragEnter);
            this.lb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseDown);
            // 
            // lb2
            // 
            this.lb2.AllowDrop = true;
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Location = new System.Drawing.Point(510, 178);
            this.lb2.Name = "lb2";
            this.lb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb2.Size = new System.Drawing.Size(219, 276);
            this.lb2.TabIndex = 1;
            this.lb2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb1_DragEnter);
            this.lb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseDown);
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.AutoSize = true;
            this.cbOrdenar.Location = new System.Drawing.Point(154, 481);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(78, 21);
            this.cbOrdenar.TabIndex = 2;
            this.cbOrdenar.Text = "Ordena";
            this.cbOrdenar.UseVisualStyleBackColor = true;
            // 
            // cbOrdenar2
            // 
            this.cbOrdenar2.AutoSize = true;
            this.cbOrdenar2.Location = new System.Drawing.Point(566, 481);
            this.cbOrdenar2.Name = "cbOrdenar2";
            this.cbOrdenar2.Size = new System.Drawing.Size(78, 21);
            this.cbOrdenar2.TabIndex = 3;
            this.cbOrdenar2.Text = "Ordena";
            this.cbOrdenar2.UseVisualStyleBackColor = true;
            // 
            // btBorra1
            // 
            this.btBorra1.Image = global::ArrastrarYSoltar.Properties.Resources.ELIMINA;
            this.btBorra1.Location = new System.Drawing.Point(107, 140);
            this.btBorra1.Name = "btBorra1";
            this.btBorra1.Size = new System.Drawing.Size(32, 30);
            this.btBorra1.TabIndex = 4;
            this.btBorra1.UseVisualStyleBackColor = true;
            // 
            // btBorraTodo1
            // 
            this.btBorraTodo1.Location = new System.Drawing.Point(242, 149);
            this.btBorraTodo1.Name = "btBorraTodo1";
            this.btBorraTodo1.Size = new System.Drawing.Size(75, 23);
            this.btBorraTodo1.TabIndex = 5;
            this.btBorraTodo1.Text = "button2";
            this.btBorraTodo1.UseVisualStyleBackColor = true;
            // 
            // btBorra2
            // 
            this.btBorra2.Location = new System.Drawing.Point(510, 149);
            this.btBorra2.Name = "btBorra2";
            this.btBorra2.Size = new System.Drawing.Size(75, 23);
            this.btBorra2.TabIndex = 6;
            this.btBorra2.Text = "button3";
            this.btBorra2.UseVisualStyleBackColor = true;
            // 
            // btBorraTodo2
            // 
            this.btBorraTodo2.Location = new System.Drawing.Point(654, 149);
            this.btBorraTodo2.Name = "btBorraTodo2";
            this.btBorraTodo2.Size = new System.Drawing.Size(75, 23);
            this.btBorraTodo2.TabIndex = 7;
            this.btBorraTodo2.Text = "button4";
            this.btBorraTodo2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(210, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 58);
            this.label1.TabIndex = 8;
            this.label1.Text = "Arrastra un Archivo de texto a los ListBox\r\nIntercambia los Elementos entre ellos" +
    "";
            // 
            // btPapelera
            // 
            this.btPapelera.AutoSize = true;
            this.btPapelera.Location = new System.Drawing.Point(374, 450);
            this.btPapelera.Name = "btPapelera";
            this.btPapelera.Size = new System.Drawing.Size(75, 80);
            this.btPapelera.TabIndex = 9;
            this.btPapelera.Text = "Papelera";
            this.btPapelera.UseVisualStyleBackColor = true;
            // 
            // fmArrastrarYSoltar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 552);
            this.Controls.Add(this.btPapelera);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btBorraTodo2);
            this.Controls.Add(this.btBorra2);
            this.Controls.Add(this.btBorraTodo1);
            this.Controls.Add(this.btBorra1);
            this.Controls.Add(this.cbOrdenar2);
            this.Controls.Add(this.cbOrdenar);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "fmArrastrarYSoltar";
            this.Text = "Arrastrar y Soltar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.CheckBox cbOrdenar;
        private System.Windows.Forms.CheckBox cbOrdenar2;
        private System.Windows.Forms.Button btBorra1;
        private System.Windows.Forms.Button btBorraTodo1;
        private System.Windows.Forms.Button btBorra2;
        private System.Windows.Forms.Button btBorraTodo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btPapelera;
    }
}

