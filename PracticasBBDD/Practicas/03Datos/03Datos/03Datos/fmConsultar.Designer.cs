namespace _03Datos
{
    partial class fmConsultar
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
            this.lvConsultas = new System.Windows.Forms.ListView();
            this.gbContinentes = new System.Windows.Forms.GroupBox();
            this.cbAmerica = new System.Windows.Forms.CheckBox();
            this.cbEuropa = new System.Windows.Forms.CheckBox();
            this.cbAsia = new System.Windows.Forms.CheckBox();
            this.cbAfrica = new System.Windows.Forms.CheckBox();
            this.cbOceania = new System.Windows.Forms.CheckBox();
            this.btConsulta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbConsultaPais = new System.Windows.Forms.TextBox();
            this.btVer = new System.Windows.Forms.Button();
            this.lvId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvContinente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvPIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvRC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbContinentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btVer);
            this.panel1.Controls.Add(this.tbConsultaPais);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btConsulta);
            this.panel1.Controls.Add(this.gbContinentes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 209);
            this.panel1.TabIndex = 0;
            // 
            // lvConsultas
            // 
            this.lvConsultas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvId,
            this.lvNombre,
            this.lvCapital,
            this.lvContinente,
            this.lvPoblacion,
            this.lvPIB,
            this.lvRC});
            this.lvConsultas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvConsultas.HideSelection = false;
            this.lvConsultas.Location = new System.Drawing.Point(0, 209);
            this.lvConsultas.MultiSelect = false;
            this.lvConsultas.Name = "lvConsultas";
            this.lvConsultas.Size = new System.Drawing.Size(800, 241);
            this.lvConsultas.TabIndex = 1;
            this.lvConsultas.UseCompatibleStateImageBehavior = false;
            this.lvConsultas.View = System.Windows.Forms.View.Details;
            // 
            // gbContinentes
            // 
            this.gbContinentes.Controls.Add(this.cbOceania);
            this.gbContinentes.Controls.Add(this.cbAfrica);
            this.gbContinentes.Controls.Add(this.cbAsia);
            this.gbContinentes.Controls.Add(this.cbEuropa);
            this.gbContinentes.Controls.Add(this.cbAmerica);
            this.gbContinentes.Location = new System.Drawing.Point(66, 28);
            this.gbContinentes.Name = "gbContinentes";
            this.gbContinentes.Size = new System.Drawing.Size(238, 163);
            this.gbContinentes.TabIndex = 0;
            this.gbContinentes.TabStop = false;
            this.gbContinentes.Text = "Consulta por Continente";
            // 
            // cbAmerica
            // 
            this.cbAmerica.AutoSize = true;
            this.cbAmerica.Location = new System.Drawing.Point(21, 21);
            this.cbAmerica.Name = "cbAmerica";
            this.cbAmerica.Size = new System.Drawing.Size(81, 21);
            this.cbAmerica.TabIndex = 0;
            this.cbAmerica.Text = "América";
            this.cbAmerica.UseVisualStyleBackColor = true;
            // 
            // cbEuropa
            // 
            this.cbEuropa.AutoSize = true;
            this.cbEuropa.Location = new System.Drawing.Point(21, 48);
            this.cbEuropa.Name = "cbEuropa";
            this.cbEuropa.Size = new System.Drawing.Size(76, 21);
            this.cbEuropa.TabIndex = 1;
            this.cbEuropa.Text = "Europa";
            this.cbEuropa.UseVisualStyleBackColor = true;
            // 
            // cbAsia
            // 
            this.cbAsia.AutoSize = true;
            this.cbAsia.Location = new System.Drawing.Point(21, 75);
            this.cbAsia.Name = "cbAsia";
            this.cbAsia.Size = new System.Drawing.Size(57, 21);
            this.cbAsia.TabIndex = 2;
            this.cbAsia.Text = "Asia";
            this.cbAsia.UseVisualStyleBackColor = true;
            // 
            // cbAfrica
            // 
            this.cbAfrica.AutoSize = true;
            this.cbAfrica.Location = new System.Drawing.Point(21, 102);
            this.cbAfrica.Name = "cbAfrica";
            this.cbAfrica.Size = new System.Drawing.Size(66, 21);
            this.cbAfrica.TabIndex = 3;
            this.cbAfrica.Text = "África";
            this.cbAfrica.UseVisualStyleBackColor = true;
            // 
            // cbOceania
            // 
            this.cbOceania.AutoSize = true;
            this.cbOceania.Location = new System.Drawing.Point(21, 129);
            this.cbOceania.Name = "cbOceania";
            this.cbOceania.Size = new System.Drawing.Size(83, 21);
            this.cbOceania.TabIndex = 4;
            this.cbOceania.Text = "Oceanía";
            this.cbOceania.UseVisualStyleBackColor = true;
            // 
            // btConsulta
            // 
            this.btConsulta.AutoSize = true;
            this.btConsulta.Location = new System.Drawing.Point(334, 87);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(75, 27);
            this.btConsulta.TabIndex = 1;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta por País";
            // 
            // tbConsultaPais
            // 
            this.tbConsultaPais.Location = new System.Drawing.Point(609, 74);
            this.tbConsultaPais.Name = "tbConsultaPais";
            this.tbConsultaPais.Size = new System.Drawing.Size(135, 22);
            this.tbConsultaPais.TabIndex = 3;
            // 
            // btVer
            // 
            this.btVer.AutoSize = true;
            this.btVer.Location = new System.Drawing.Point(635, 103);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 27);
            this.btVer.TabIndex = 4;
            this.btVer.Text = "Ver";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // lvId
            // 
            this.lvId.Text = "ID";
            // 
            // lvNombre
            // 
            this.lvNombre.Text = "Nombre";
            // 
            // lvCapital
            // 
            this.lvCapital.Text = "Capital";
            // 
            // lvContinente
            // 
            this.lvContinente.Text = "Continente";
            // 
            // lvPoblacion
            // 
            this.lvPoblacion.Text = "Población";
            // 
            // lvPIB
            // 
            this.lvPIB.Text = "PIB";
            this.lvPIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lvPIB.Width = 82;
            // 
            // lvRC
            // 
            this.lvRC.Text = "Renta/Cápita";
            this.lvRC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lvRC.Width = 147;
            // 
            // fmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvConsultas);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsultar";
            this.Text = "fmConsultar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbContinentes.ResumeLayout(false);
            this.gbContinentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbContinentes;
        private System.Windows.Forms.ListView lvConsultas;
        private System.Windows.Forms.CheckBox cbOceania;
        private System.Windows.Forms.CheckBox cbAfrica;
        private System.Windows.Forms.CheckBox cbAsia;
        private System.Windows.Forms.CheckBox cbEuropa;
        private System.Windows.Forms.CheckBox cbAmerica;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.TextBox tbConsultaPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader lvId;
        private System.Windows.Forms.ColumnHeader lvNombre;
        private System.Windows.Forms.ColumnHeader lvCapital;
        private System.Windows.Forms.ColumnHeader lvContinente;
        private System.Windows.Forms.ColumnHeader lvPoblacion;
        private System.Windows.Forms.ColumnHeader lvPIB;
        private System.Windows.Forms.ColumnHeader lvRC;
    }
}