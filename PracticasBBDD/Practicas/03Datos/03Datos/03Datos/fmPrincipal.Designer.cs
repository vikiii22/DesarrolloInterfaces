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
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.btClasifica = new System.Windows.Forms.Button();
            this.btCalculaRC = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btConsultar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbDescendente = new System.Windows.Forms.CheckBox();
            this.rbID = new System.Windows.Forms.RadioButton();
            this.rbCapital = new System.Windows.Forms.RadioButton();
            this.rbPIB = new System.Windows.Forms.RadioButton();
            this.rbPoblacion = new System.Windows.Forms.RadioButton();
            this.rbContinente = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContinente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentaCapita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAcercaDe);
            this.panel1.Controls.Add(this.btClasifica);
            this.panel1.Controls.Add(this.btCalculaRC);
            this.panel1.Controls.Add(this.btBorrar);
            this.panel1.Controls.Add(this.btConsultar);
            this.panel1.Controls.Add(this.btModificar);
            this.panel1.Controls.Add(this.btAnyadir);
            this.panel1.Controls.Add(this.btMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 97);
            this.panel1.TabIndex = 1;
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.AutoSize = true;
            this.btAcercaDe.Location = new System.Drawing.Point(900, 35);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(84, 27);
            this.btAcercaDe.TabIndex = 7;
            this.btAcercaDe.Text = "Acerca De";
            this.btAcercaDe.UseVisualStyleBackColor = true;
            // 
            // btClasifica
            // 
            this.btClasifica.AutoSize = true;
            this.btClasifica.Location = new System.Drawing.Point(583, 35);
            this.btClasifica.Name = "btClasifica";
            this.btClasifica.Size = new System.Drawing.Size(137, 27);
            this.btClasifica.TabIndex = 6;
            this.btClasifica.Text = "Clasifica por Renta";
            this.btClasifica.UseVisualStyleBackColor = true;
            // 
            // btCalculaRC
            // 
            this.btCalculaRC.AutoSize = true;
            this.btCalculaRC.Location = new System.Drawing.Point(417, 35);
            this.btCalculaRC.Name = "btCalculaRC";
            this.btCalculaRC.Size = new System.Drawing.Size(150, 27);
            this.btCalculaRC.TabIndex = 5;
            this.btCalculaRC.Text = "Cálcula Renta/Capita";
            this.btCalculaRC.UseVisualStyleBackColor = true;
            this.btCalculaRC.Click += new System.EventHandler(this.btCalculaRC_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.AutoSize = true;
            this.btBorrar.Location = new System.Drawing.Point(336, 35);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 27);
            this.btBorrar.TabIndex = 4;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btConsultar
            // 
            this.btConsultar.AutoSize = true;
            this.btConsultar.Location = new System.Drawing.Point(255, 35);
            this.btConsultar.Name = "btConsultar";
            this.btConsultar.Size = new System.Drawing.Size(78, 27);
            this.btConsultar.TabIndex = 3;
            this.btConsultar.Text = "Consultar";
            this.btConsultar.UseVisualStyleBackColor = true;
            this.btConsultar.Click += new System.EventHandler(this.btConsultar_Click);
            // 
            // btModificar
            // 
            this.btModificar.AutoSize = true;
            this.btModificar.Location = new System.Drawing.Point(174, 35);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 27);
            this.btModificar.TabIndex = 2;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.button3_Click);
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
            this.panel2.Controls.Add(this.cbDescendente);
            this.panel2.Controls.Add(this.rbID);
            this.panel2.Controls.Add(this.rbCapital);
            this.panel2.Controls.Add(this.rbPIB);
            this.panel2.Controls.Add(this.rbPoblacion);
            this.panel2.Controls.Add(this.rbContinente);
            this.panel2.Controls.Add(this.rbPais);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 100);
            this.panel2.TabIndex = 2;
            // 
            // cbDescendente
            // 
            this.cbDescendente.AutoSize = true;
            this.cbDescendente.Location = new System.Drawing.Point(633, 53);
            this.cbDescendente.Name = "cbDescendente";
            this.cbDescendente.Size = new System.Drawing.Size(114, 21);
            this.cbDescendente.TabIndex = 7;
            this.cbDescendente.Text = "Descendente";
            this.cbDescendente.UseVisualStyleBackColor = true;
            this.cbDescendente.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbID
            // 
            this.rbID.AutoSize = true;
            this.rbID.Checked = true;
            this.rbID.Location = new System.Drawing.Point(486, 54);
            this.rbID.Name = "rbID";
            this.rbID.Size = new System.Drawing.Size(106, 21);
            this.rbID.TabIndex = 6;
            this.rbID.TabStop = true;
            this.rbID.Text = "Identificador";
            this.rbID.UseVisualStyleBackColor = true;
            this.rbID.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbCapital
            // 
            this.rbCapital.AutoSize = true;
            this.rbCapital.Location = new System.Drawing.Point(486, 27);
            this.rbCapital.Name = "rbCapital";
            this.rbCapital.Size = new System.Drawing.Size(72, 21);
            this.rbCapital.TabIndex = 5;
            this.rbCapital.TabStop = true;
            this.rbCapital.Text = "Capital";
            this.rbCapital.UseVisualStyleBackColor = true;
            this.rbCapital.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbPIB
            // 
            this.rbPIB.AutoSize = true;
            this.rbPIB.Location = new System.Drawing.Point(361, 53);
            this.rbPIB.Name = "rbPIB";
            this.rbPIB.Size = new System.Drawing.Size(50, 21);
            this.rbPIB.TabIndex = 4;
            this.rbPIB.TabStop = true;
            this.rbPIB.Text = "PIB";
            this.rbPIB.UseVisualStyleBackColor = true;
            this.rbPIB.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbPoblacion
            // 
            this.rbPoblacion.AutoSize = true;
            this.rbPoblacion.Location = new System.Drawing.Point(361, 26);
            this.rbPoblacion.Name = "rbPoblacion";
            this.rbPoblacion.Size = new System.Drawing.Size(91, 21);
            this.rbPoblacion.TabIndex = 3;
            this.rbPoblacion.TabStop = true;
            this.rbPoblacion.Text = "Población";
            this.rbPoblacion.UseVisualStyleBackColor = true;
            this.rbPoblacion.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbContinente
            // 
            this.rbContinente.AutoSize = true;
            this.rbContinente.Location = new System.Drawing.Point(249, 54);
            this.rbContinente.Name = "rbContinente";
            this.rbContinente.Size = new System.Drawing.Size(97, 21);
            this.rbContinente.TabIndex = 2;
            this.rbContinente.TabStop = true;
            this.rbContinente.Text = "Continente";
            this.rbContinente.UseVisualStyleBackColor = true;
            this.rbContinente.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Location = new System.Drawing.Point(249, 27);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(56, 21);
            this.rbPais.TabIndex = 1;
            this.rbPais.TabStop = true;
            this.rbPais.Text = "País";
            this.rbPais.UseVisualStyleBackColor = true;
            this.rbPais.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
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
        private System.Windows.Forms.Button btCalculaRC;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btConsultar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDescendente;
        private System.Windows.Forms.RadioButton rbID;
        private System.Windows.Forms.RadioButton rbCapital;
        private System.Windows.Forms.RadioButton rbPIB;
        private System.Windows.Forms.RadioButton rbPoblacion;
        private System.Windows.Forms.RadioButton rbContinente;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.Button btAcercaDe;
        private System.Windows.Forms.Button btClasifica;
    }
}

