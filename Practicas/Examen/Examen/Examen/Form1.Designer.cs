namespace Examen
{
    partial class fmExamen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAlmacenes1 = new System.Windows.Forms.ComboBox();
            this.cbAlmacenes2 = new System.Windows.Forms.ComboBox();
            this.cbOrdena1 = new System.Windows.Forms.CheckBox();
            this.cbOrdena2 = new System.Windows.Forms.CheckBox();
            this.lbAlmacenes1 = new System.Windows.Forms.ListBox();
            this.lbAlmacenes2 = new System.Windows.Forms.ListBox();
            this.btPasar1 = new System.Windows.Forms.Button();
            this.btPasar2 = new System.Windows.Forms.Button();
            this.btEnviarTodo1 = new System.Windows.Forms.Button();
            this.btEnviarTodo2 = new System.Windows.Forms.Button();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.btElimina = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btGuarda2 = new System.Windows.Forms.Button();
            this.btElimina2 = new System.Windows.Forms.Button();
            this.btNuevo2 = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tbNuevo = new System.Windows.Forms.TextBox();
            this.tbNuevo2 = new System.Windows.Forms.TextBox();
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Organización de Articulos por Almacén";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Almacenes Principales";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(701, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Almacenes Secundarios";
            // 
            // cbAlmacenes1
            // 
            this.cbAlmacenes1.FormattingEnabled = true;
            this.cbAlmacenes1.Items.AddRange(new object[] {
            "Almacen1",
            "Almacen2",
            "Almacen3"});
            this.cbAlmacenes1.Location = new System.Drawing.Point(147, 162);
            this.cbAlmacenes1.Name = "cbAlmacenes1";
            this.cbAlmacenes1.Size = new System.Drawing.Size(121, 24);
            this.cbAlmacenes1.TabIndex = 3;
            this.cbAlmacenes1.Text = "Almacen1";
            this.cbAlmacenes1.SelectedIndexChanged += new System.EventHandler(this.cbAlmacenes1_SelectedIndexChanged);
            // 
            // cbAlmacenes2
            // 
            this.cbAlmacenes2.FormattingEnabled = true;
            this.cbAlmacenes2.Items.AddRange(new object[] {
            "Almacen4",
            "Almacen5",
            "Almacen6"});
            this.cbAlmacenes2.Location = new System.Drawing.Point(704, 162);
            this.cbAlmacenes2.Name = "cbAlmacenes2";
            this.cbAlmacenes2.Size = new System.Drawing.Size(121, 24);
            this.cbAlmacenes2.TabIndex = 4;
            this.cbAlmacenes2.Text = "Almacen4";
            this.cbAlmacenes2.SelectedIndexChanged += new System.EventHandler(this.cbAlmacenes2_SelectedIndexChanged);
            // 
            // cbOrdena1
            // 
            this.cbOrdena1.AutoSize = true;
            this.cbOrdena1.Location = new System.Drawing.Point(147, 207);
            this.cbOrdena1.Name = "cbOrdena1";
            this.cbOrdena1.Size = new System.Drawing.Size(78, 21);
            this.cbOrdena1.TabIndex = 5;
            this.cbOrdena1.Text = "Ordena";
            this.cbOrdena1.UseVisualStyleBackColor = true;
            this.cbOrdena1.CheckedChanged += new System.EventHandler(this.cbOrdena1_CheckedChanged);
            // 
            // cbOrdena2
            // 
            this.cbOrdena2.AutoSize = true;
            this.cbOrdena2.Location = new System.Drawing.Point(704, 207);
            this.cbOrdena2.Name = "cbOrdena2";
            this.cbOrdena2.Size = new System.Drawing.Size(78, 21);
            this.cbOrdena2.TabIndex = 6;
            this.cbOrdena2.Text = "Ordena";
            this.cbOrdena2.UseVisualStyleBackColor = true;
            this.cbOrdena2.CheckedChanged += new System.EventHandler(this.cbOrdena2_CheckedChanged);
            // 
            // lbAlmacenes1
            // 
            this.lbAlmacenes1.AllowDrop = true;
            this.lbAlmacenes1.FormattingEnabled = true;
            this.lbAlmacenes1.ItemHeight = 16;
            this.lbAlmacenes1.Location = new System.Drawing.Point(147, 249);
            this.lbAlmacenes1.Name = "lbAlmacenes1";
            this.lbAlmacenes1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAlmacenes1.Size = new System.Drawing.Size(160, 196);
            this.lbAlmacenes1.TabIndex = 7;
            this.lbAlmacenes1.SelectedIndexChanged += new System.EventHandler(this.lbAlmacenes1_SelectedIndexChanged);
            // 
            // lbAlmacenes2
            // 
            this.lbAlmacenes2.AllowDrop = true;
            this.lbAlmacenes2.FormattingEnabled = true;
            this.lbAlmacenes2.ItemHeight = 16;
            this.lbAlmacenes2.Location = new System.Drawing.Point(704, 249);
            this.lbAlmacenes2.Name = "lbAlmacenes2";
            this.lbAlmacenes2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAlmacenes2.Size = new System.Drawing.Size(160, 196);
            this.lbAlmacenes2.TabIndex = 8;
            this.lbAlmacenes2.SelectedIndexChanged += new System.EventHandler(this.lbAlmacenes2_SelectedIndexChanged);
            // 
            // btPasar1
            // 
            this.btPasar1.Enabled = false;
            this.btPasar1.Location = new System.Drawing.Point(492, 271);
            this.btPasar1.Name = "btPasar1";
            this.btPasar1.Size = new System.Drawing.Size(75, 23);
            this.btPasar1.TabIndex = 9;
            this.btPasar1.Text = ">";
            this.btPasar1.UseVisualStyleBackColor = true;
            this.btPasar1.Click += new System.EventHandler(this.btPasar1_Click);
            // 
            // btPasar2
            // 
            this.btPasar2.Enabled = false;
            this.btPasar2.Location = new System.Drawing.Point(492, 300);
            this.btPasar2.Name = "btPasar2";
            this.btPasar2.Size = new System.Drawing.Size(75, 23);
            this.btPasar2.TabIndex = 10;
            this.btPasar2.Text = "<";
            this.btPasar2.UseVisualStyleBackColor = true;
            this.btPasar2.Click += new System.EventHandler(this.btPasar2_Click);
            // 
            // btEnviarTodo1
            // 
            this.btEnviarTodo1.Location = new System.Drawing.Point(492, 329);
            this.btEnviarTodo1.Name = "btEnviarTodo1";
            this.btEnviarTodo1.Size = new System.Drawing.Size(75, 23);
            this.btEnviarTodo1.TabIndex = 11;
            this.btEnviarTodo1.Text = ">>";
            this.btEnviarTodo1.UseVisualStyleBackColor = true;
            this.btEnviarTodo1.Click += new System.EventHandler(this.btEnviarTodo1_Click);
            // 
            // btEnviarTodo2
            // 
            this.btEnviarTodo2.Location = new System.Drawing.Point(492, 358);
            this.btEnviarTodo2.Name = "btEnviarTodo2";
            this.btEnviarTodo2.Size = new System.Drawing.Size(75, 23);
            this.btEnviarTodo2.TabIndex = 12;
            this.btEnviarTodo2.Text = "<<";
            this.btEnviarTodo2.UseVisualStyleBackColor = true;
            this.btEnviarTodo2.Click += new System.EventHandler(this.btEnviarTodo2_Click);
            // 
            // btAnyadir
            // 
            this.btAnyadir.AutoSize = true;
            this.btAnyadir.Enabled = false;
            this.btAnyadir.Image = global::Examen.Properties.Resources.suma;
            this.btAnyadir.Location = new System.Drawing.Point(147, 472);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(40, 30);
            this.btAnyadir.TabIndex = 13;
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // btElimina
            // 
            this.btElimina.AutoSize = true;
            this.btElimina.Enabled = false;
            this.btElimina.Image = global::Examen.Properties.Resources.resta;
            this.btElimina.Location = new System.Drawing.Point(205, 472);
            this.btElimina.Name = "btElimina";
            this.btElimina.Size = new System.Drawing.Size(40, 30);
            this.btElimina.TabIndex = 14;
            this.btElimina.UseVisualStyleBackColor = true;
            this.btElimina.Click += new System.EventHandler(this.btElimina_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.AutoSize = true;
            this.btGuardar.Image = global::Examen.Properties.Resources.GRABAR;
            this.btGuardar.Location = new System.Drawing.Point(267, 472);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(40, 26);
            this.btGuardar.TabIndex = 15;
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btGuarda2
            // 
            this.btGuarda2.AutoSize = true;
            this.btGuarda2.Image = global::Examen.Properties.Resources.GRABAR;
            this.btGuarda2.Location = new System.Drawing.Point(824, 472);
            this.btGuarda2.Name = "btGuarda2";
            this.btGuarda2.Size = new System.Drawing.Size(40, 26);
            this.btGuarda2.TabIndex = 18;
            this.btGuarda2.UseVisualStyleBackColor = true;
            this.btGuarda2.Click += new System.EventHandler(this.btGuarda2_Click);
            // 
            // btElimina2
            // 
            this.btElimina2.AutoSize = true;
            this.btElimina2.Enabled = false;
            this.btElimina2.Image = global::Examen.Properties.Resources.resta;
            this.btElimina2.Location = new System.Drawing.Point(762, 472);
            this.btElimina2.Name = "btElimina2";
            this.btElimina2.Size = new System.Drawing.Size(40, 30);
            this.btElimina2.TabIndex = 17;
            this.btElimina2.UseVisualStyleBackColor = true;
            this.btElimina2.Click += new System.EventHandler(this.btElimina2_Click);
            // 
            // btNuevo2
            // 
            this.btNuevo2.AutoSize = true;
            this.btNuevo2.Enabled = false;
            this.btNuevo2.Image = global::Examen.Properties.Resources.suma;
            this.btNuevo2.Location = new System.Drawing.Point(704, 472);
            this.btNuevo2.Name = "btNuevo2";
            this.btNuevo2.Size = new System.Drawing.Size(40, 30);
            this.btNuevo2.TabIndex = 16;
            this.btNuevo2.UseVisualStyleBackColor = true;
            this.btNuevo2.Click += new System.EventHandler(this.btNuevo2_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(492, 519);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 19;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // tbNuevo
            // 
            this.tbNuevo.Location = new System.Drawing.Point(168, 520);
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(100, 22);
            this.tbNuevo.TabIndex = 20;
            this.tbNuevo.TextChanged += new System.EventHandler(this.tbNuevo_TextChanged);
            this.tbNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevo_KeyPress);
            // 
            // tbNuevo2
            // 
            this.tbNuevo2.Location = new System.Drawing.Point(725, 520);
            this.tbNuevo2.Name = "tbNuevo2";
            this.tbNuevo2.Size = new System.Drawing.Size(100, 22);
            this.tbNuevo2.TabIndex = 21;
            this.tbNuevo2.TextChanged += new System.EventHandler(this.tbNuevo2_TextChanged);
            this.tbNuevo2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevo2_KeyPress);
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.AutoSize = true;
            this.btAcercaDe.Location = new System.Drawing.Point(907, 542);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(84, 27);
            this.btAcercaDe.TabIndex = 22;
            this.btAcercaDe.Text = "Acerca De";
            this.btAcercaDe.UseVisualStyleBackColor = true;
            this.btAcercaDe.Click += new System.EventHandler(this.btAcercaDe_Click);
            // 
            // fmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 588);
            this.Controls.Add(this.btAcercaDe);
            this.Controls.Add(this.tbNuevo2);
            this.Controls.Add(this.tbNuevo);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btGuarda2);
            this.Controls.Add(this.btElimina2);
            this.Controls.Add(this.btNuevo2);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btElimina);
            this.Controls.Add(this.btAnyadir);
            this.Controls.Add(this.btEnviarTodo2);
            this.Controls.Add(this.btEnviarTodo1);
            this.Controls.Add(this.btPasar2);
            this.Controls.Add(this.btPasar1);
            this.Controls.Add(this.lbAlmacenes2);
            this.Controls.Add(this.lbAlmacenes1);
            this.Controls.Add(this.cbOrdena2);
            this.Controls.Add(this.cbOrdena1);
            this.Controls.Add(this.cbAlmacenes2);
            this.Controls.Add(this.cbAlmacenes1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmExamen";
            this.Text = "Examen 1ª Evaluación curso 21-22";
            this.Load += new System.EventHandler(this.fmExamen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAlmacenes1;
        private System.Windows.Forms.ComboBox cbAlmacenes2;
        private System.Windows.Forms.CheckBox cbOrdena1;
        private System.Windows.Forms.CheckBox cbOrdena2;
        private System.Windows.Forms.ListBox lbAlmacenes1;
        private System.Windows.Forms.ListBox lbAlmacenes2;
        private System.Windows.Forms.Button btPasar1;
        private System.Windows.Forms.Button btPasar2;
        private System.Windows.Forms.Button btEnviarTodo1;
        private System.Windows.Forms.Button btEnviarTodo2;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.Button btElimina;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btGuarda2;
        private System.Windows.Forms.Button btElimina2;
        private System.Windows.Forms.Button btNuevo2;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.TextBox tbNuevo;
        private System.Windows.Forms.TextBox tbNuevo2;
        private System.Windows.Forms.Button btAcercaDe;
    }
}

