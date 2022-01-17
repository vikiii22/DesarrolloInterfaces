namespace _03Datos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContinente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentaCapita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btAnyadir);
            this.panel1.Controls.Add(this.btMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 97);
            this.panel1.TabIndex = 1;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.Location = new System.Drawing.Point(417, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 27);
            this.button6.TabIndex = 5;
            this.button6.Text = "Cálcula Renta/Capita";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.Location = new System.Drawing.Point(336, 35);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Borrar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(255, 35);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Consultar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(174, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Modificar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btAnyadir
            // 
            this.btAnyadir.AutoSize = true;
            this.btAnyadir.Location = new System.Drawing.Point(93, 35);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(75, 27);
            this.btAnyadir.TabIndex = 1;
            this.btAnyadir.Text = "Añadir";
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.AutoSize = true;
            this.btMostrar.Location = new System.Drawing.Point(12, 35);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 27);
            this.btMostrar.TabIndex = 0;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.radioButton5);
            this.panel2.Controls.Add(this.radioButton6);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 100);
            this.panel2.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(633, 53);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(114, 21);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Descendente";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Checked = true;
            this.radioButton5.Location = new System.Drawing.Point(486, 54);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(106, 21);
            this.radioButton5.TabIndex = 6;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Identificador";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(486, 27);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(72, 21);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Capital";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(361, 53);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "PIB";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(361, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(91, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Población";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(249, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 21);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Continente";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(249, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 21);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "País";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KacstOffice", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordenar Por...";
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colNombre,
            this.colCapital,
            this.colContinente,
            this.colPoblacion,
            this.colPIB,
            this.colRentaCapita});
            this.lvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDatos.FullRowSelect = true;
            this.lvDatos.HideSelection = false;
            this.lvDatos.Location = new System.Drawing.Point(0, 97);
            this.lvDatos.MultiSelect = false;
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(996, 253);
            this.lvDatos.TabIndex = 3;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 40;
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 99;
            // 
            // colCapital
            // 
            this.colCapital.Text = "Capital";
            // 
            // colContinente
            // 
            this.colContinente.Text = "Continente";
            this.colContinente.Width = 96;
            // 
            // colPoblacion
            // 
            this.colPoblacion.Text = "Población";
            this.colPoblacion.Width = 82;
            // 
            // colPIB
            // 
            this.colPIB.Text = "PIB";
            // 
            // colRentaCapita
            // 
            this.colRentaCapita.Text = "Renta/Capita";
            this.colRentaCapita.Width = 96;
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.Location = new System.Drawing.Point(583, 35);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 27);
            this.button7.TabIndex = 6;
            this.button7.Text = "Clasifica por Renta";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.Location = new System.Drawing.Point(900, 35);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 27);
            this.button8.TabIndex = 7;
            this.button8.Text = "Acerca De";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 450);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvDatos;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colCapital;
        private System.Windows.Forms.ColumnHeader colContinente;
        private System.Windows.Forms.ColumnHeader colPoblacion;
        private System.Windows.Forms.ColumnHeader colPIB;
        private System.Windows.Forms.ColumnHeader colRentaCapita;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
    }
}

