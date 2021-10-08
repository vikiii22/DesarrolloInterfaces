namespace ListasYMenus
{
    partial class fmListasYMenus
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
            this.pnActualiza = new System.Windows.Forms.Panel();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.listBoxAlumnos = new System.Windows.Forms.ListBox();
            this.comboBoxGrupos = new System.Windows.Forms.ComboBox();
            this.btMostrarTodos = new System.Windows.Forms.Button();
            this.btMostrarMas = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btFlechaAbajo = new System.Windows.Forms.Button();
            this.btFlechaArriba = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNuevo = new System.Windows.Forms.TextBox();
            this.lbNuevo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnActualiza.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnActualiza
            // 
            this.pnActualiza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnActualiza.Controls.Add(this.btBuscar);
            this.pnActualiza.Controls.Add(this.btInsertar);
            this.pnActualiza.Controls.Add(this.btBorrar);
            this.pnActualiza.Controls.Add(this.btAnyadir);
            this.pnActualiza.Location = new System.Drawing.Point(674, 126);
            this.pnActualiza.Name = "pnActualiza";
            this.pnActualiza.Size = new System.Drawing.Size(200, 208);
            this.pnActualiza.TabIndex = 0;
            this.pnActualiza.Visible = false;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(59, 141);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 17;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(59, 106);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 23);
            this.btInsertar.TabIndex = 16;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(59, 70);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 15;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            // 
            // btAnyadir
            // 
            this.btAnyadir.Location = new System.Drawing.Point(59, 35);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(75, 23);
            this.btAnyadir.TabIndex = 14;
            this.btAnyadir.Text = "Añadir";
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // listBoxAlumnos
            // 
            this.listBoxAlumnos.FormattingEnabled = true;
            this.listBoxAlumnos.ItemHeight = 16;
            this.listBoxAlumnos.Items.AddRange(new object[] {
            "Luis",
            "Paco",
            "Pepe",
            "Ramon",
            "Jose"});
            this.listBoxAlumnos.Location = new System.Drawing.Point(57, 122);
            this.listBoxAlumnos.Name = "listBoxAlumnos";
            this.listBoxAlumnos.Size = new System.Drawing.Size(198, 212);
            this.listBoxAlumnos.TabIndex = 1;
            // 
            // comboBoxGrupos
            // 
            this.comboBoxGrupos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGrupos.FormattingEnabled = true;
            this.comboBoxGrupos.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B"});
            this.comboBoxGrupos.Location = new System.Drawing.Point(56, 62);
            this.comboBoxGrupos.Name = "comboBoxGrupos";
            this.comboBoxGrupos.Size = new System.Drawing.Size(121, 24);
            this.comboBoxGrupos.TabIndex = 2;
            // 
            // btMostrarTodos
            // 
            this.btMostrarTodos.AutoSize = true;
            this.btMostrarTodos.Location = new System.Drawing.Point(258, 406);
            this.btMostrarTodos.Name = "btMostrarTodos";
            this.btMostrarTodos.Size = new System.Drawing.Size(110, 27);
            this.btMostrarTodos.TabIndex = 3;
            this.btMostrarTodos.Text = "Mostrar Todos";
            this.btMostrarTodos.UseVisualStyleBackColor = true;
            this.btMostrarTodos.Click += new System.EventHandler(this.btMostrarTodos_Click);
            // 
            // btMostrarMas
            // 
            this.btMostrarMas.AutoSize = true;
            this.btMostrarMas.Location = new System.Drawing.Point(258, 435);
            this.btMostrarMas.Name = "btMostrarMas";
            this.btMostrarMas.Size = new System.Drawing.Size(108, 27);
            this.btMostrarMas.TabIndex = 4;
            this.btMostrarMas.Text = "Mostrar Mas...";
            this.btMostrarMas.UseVisualStyleBackColor = true;
            this.btMostrarMas.Click += new System.EventHandler(this.btMostrarMas_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.AutoSize = true;
            this.btNuevo.Location = new System.Drawing.Point(293, 482);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 27);
            this.btNuevo.TabIndex = 5;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            // 
            // btAbrir
            // 
            this.btAbrir.AutoSize = true;
            this.btAbrir.Location = new System.Drawing.Point(374, 482);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 27);
            this.btAbrir.TabIndex = 6;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            this.btGuardar.AutoSize = true;
            this.btGuardar.Location = new System.Drawing.Point(455, 482);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 27);
            this.btGuardar.TabIndex = 7;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = true;
            this.btSalir.Location = new System.Drawing.Point(536, 482);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 27);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btOrdenar
            // 
            this.btOrdenar.AutoSize = true;
            this.btOrdenar.Location = new System.Drawing.Point(733, 43);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(75, 27);
            this.btOrdenar.TabIndex = 9;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.AutoSize = true;
            this.btActualizar.BackColor = System.Drawing.Color.DarkRed;
            this.btActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btActualizar.Location = new System.Drawing.Point(733, 72);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(80, 27);
            this.btActualizar.TabIndex = 10;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = false;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btFlechaAbajo
            // 
            this.btFlechaAbajo.Location = new System.Drawing.Point(293, 241);
            this.btFlechaAbajo.Name = "btFlechaAbajo";
            this.btFlechaAbajo.Size = new System.Drawing.Size(41, 93);
            this.btFlechaAbajo.TabIndex = 12;
            this.btFlechaAbajo.UseVisualStyleBackColor = true;
            // 
            // btFlechaArriba
            // 
            this.btFlechaArriba.Location = new System.Drawing.Point(293, 135);
            this.btFlechaArriba.Name = "btFlechaArriba";
            this.btFlechaArriba.Size = new System.Drawing.Size(41, 93);
            this.btFlechaArriba.TabIndex = 13;
            this.btFlechaArriba.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cursos";
            // 
            // tbNuevo
            // 
            this.tbNuevo.Enabled = false;
            this.tbNuevo.Location = new System.Drawing.Point(57, 416);
            this.tbNuevo.Name = "tbNuevo";
            this.tbNuevo.Size = new System.Drawing.Size(100, 22);
            this.tbNuevo.TabIndex = 15;
            this.tbNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevo_KeyPress);
            // 
            // lbNuevo
            // 
            this.lbNuevo.AutoSize = true;
            this.lbNuevo.Enabled = false;
            this.lbNuevo.Location = new System.Drawing.Point(54, 396);
            this.lbNuevo.Name = "lbNuevo";
            this.lbNuevo.Size = new System.Drawing.Size(49, 17);
            this.lbNuevo.TabIndex = 16;
            this.lbNuevo.Text = "Nuevo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Alumnos";
            // 
            // fmListasYMenus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNuevo);
            this.Controls.Add(this.tbNuevo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFlechaArriba);
            this.Controls.Add(this.btFlechaAbajo);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btMostrarMas);
            this.Controls.Add(this.btMostrarTodos);
            this.Controls.Add(this.comboBoxGrupos);
            this.Controls.Add(this.listBoxAlumnos);
            this.Controls.Add(this.pnActualiza);
            this.MaximizeBox = false;
            this.Name = "fmListasYMenus";
            this.Text = "Listas y Menús";
            this.pnActualiza.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnActualiza;
        private System.Windows.Forms.ListBox listBoxAlumnos;
        private System.Windows.Forms.ComboBox comboBoxGrupos;
        private System.Windows.Forms.Button btMostrarTodos;
        private System.Windows.Forms.Button btMostrarMas;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btFlechaAbajo;
        private System.Windows.Forms.Button btFlechaArriba;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNuevo;
        private System.Windows.Forms.Label lbNuevo;
        private System.Windows.Forms.Label label3;
    }
}

