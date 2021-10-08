namespace EdicionDatos
{
    partial class fmEdicion
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
            this.tbPesetas = new System.Windows.Forms.TextBox();
            this.tbEuros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btCambiar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btIntDatos = new System.Windows.Forms.Button();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombrePrincipal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.laDNI = new System.Windows.Forms.Label();
            this.laCodigoPostal = new System.Windows.Forms.Label();
            this.laEmail = new System.Windows.Forms.Label();
            this.laTelefono = new System.Windows.Forms.Label();
            this.laLocalidad = new System.Windows.Forms.Label();
            this.laDireccion = new System.Windows.Forms.Label();
            this.lbNombrePrincipal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPesetas
            // 
            this.tbPesetas.Location = new System.Drawing.Point(222, 74);
            this.tbPesetas.Name = "tbPesetas";
            this.tbPesetas.Size = new System.Drawing.Size(140, 22);
            this.tbPesetas.TabIndex = 1;
            this.tbPesetas.Text = "0";
            this.tbPesetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPesetas.Click += new System.EventHandler(this.tbEuros_Click);
            this.tbPesetas.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            this.tbPesetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(31, 74);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(128, 22);
            this.tbEuros.TabIndex = 0;
            this.tbEuros.Text = "0";
            this.tbEuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEuros.Click += new System.EventHandler(this.tbEuros_Click);
            this.tbEuros.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            this.tbEuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Euros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pesetas";
            // 
            // btCambiar
            // 
            this.btCambiar.AutoSize = true;
            this.btCambiar.Enabled = false;
            this.btCambiar.Location = new System.Drawing.Point(127, 131);
            this.btCambiar.Name = "btCambiar";
            this.btCambiar.Size = new System.Drawing.Size(75, 27);
            this.btCambiar.TabIndex = 4;
            this.btCambiar.Text = "Cambiar";
            this.btCambiar.UseVisualStyleBackColor = true;
            this.btCambiar.Click += new System.EventHandler(this.btCambiar_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(641, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Acerca De";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btIntDatos
            // 
            this.btIntDatos.AutoSize = true;
            this.btIntDatos.Location = new System.Drawing.Point(641, 191);
            this.btIntDatos.Name = "btIntDatos";
            this.btIntDatos.Size = new System.Drawing.Size(116, 27);
            this.btIntDatos.TabIndex = 6;
            this.btIntDatos.Text = "Introduce datos";
            this.btIntDatos.UseVisualStyleBackColor = true;
            this.btIntDatos.Click += new System.EventHandler(this.btIntDatos_Click);
            // 
            // pnDatos
            // 
            this.pnDatos.Controls.Add(this.label10);
            this.pnDatos.Controls.Add(this.label9);
            this.pnDatos.Controls.Add(this.label8);
            this.pnDatos.Controls.Add(this.label7);
            this.pnDatos.Controls.Add(this.label6);
            this.pnDatos.Controls.Add(this.label5);
            this.pnDatos.Controls.Add(this.label4);
            this.pnDatos.Controls.Add(this.tbNombrePrincipal);
            this.pnDatos.Controls.Add(this.label3);
            this.pnDatos.Controls.Add(this.laDNI);
            this.pnDatos.Controls.Add(this.laCodigoPostal);
            this.pnDatos.Controls.Add(this.laEmail);
            this.pnDatos.Controls.Add(this.laTelefono);
            this.pnDatos.Controls.Add(this.laLocalidad);
            this.pnDatos.Controls.Add(this.laDireccion);
            this.pnDatos.Controls.Add(this.lbNombrePrincipal);
            this.pnDatos.Location = new System.Drawing.Point(2, 238);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(797, 209);
            this.pnDatos.TabIndex = 7;
            this.pnDatos.Visible = false;
            this.pnDatos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDatos_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(496, 131);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Código postal:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Localidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dirección:";
            // 
            // tbNombrePrincipal
            // 
            this.tbNombrePrincipal.Location = new System.Drawing.Point(57, 51);
            this.tbNombrePrincipal.Name = "tbNombrePrincipal";
            this.tbNombrePrincipal.ReadOnly = true;
            this.tbNombrePrincipal.Size = new System.Drawing.Size(100, 22);
            this.tbNombrePrincipal.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre:";
            // 
            // laDNI
            // 
            this.laDNI.AutoSize = true;
            this.laDNI.Location = new System.Drawing.Point(374, 183);
            this.laDNI.Name = "laDNI";
            this.laDNI.Size = new System.Drawing.Size(17, 17);
            this.laDNI.TabIndex = 7;
            this.laDNI.Text = "X";
            // 
            // laCodigoPostal
            // 
            this.laCodigoPostal.AutoSize = true;
            this.laCodigoPostal.Location = new System.Drawing.Point(600, 131);
            this.laCodigoPostal.Name = "laCodigoPostal";
            this.laCodigoPostal.Size = new System.Drawing.Size(17, 17);
            this.laCodigoPostal.TabIndex = 6;
            this.laCodigoPostal.Text = "X";
            // 
            // laEmail
            // 
            this.laEmail.AutoSize = true;
            this.laEmail.Location = new System.Drawing.Point(123, 183);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(17, 17);
            this.laEmail.TabIndex = 5;
            this.laEmail.Text = "X";
            // 
            // laTelefono
            // 
            this.laTelefono.AutoSize = true;
            this.laTelefono.Location = new System.Drawing.Point(374, 87);
            this.laTelefono.Name = "laTelefono";
            this.laTelefono.Size = new System.Drawing.Size(17, 17);
            this.laTelefono.TabIndex = 4;
            this.laTelefono.Text = "X";
            // 
            // laLocalidad
            // 
            this.laLocalidad.AutoSize = true;
            this.laLocalidad.Location = new System.Drawing.Point(374, 131);
            this.laLocalidad.Name = "laLocalidad";
            this.laLocalidad.Size = new System.Drawing.Size(17, 17);
            this.laLocalidad.TabIndex = 3;
            this.laLocalidad.Text = "X";
            // 
            // laDireccion
            // 
            this.laDireccion.AutoSize = true;
            this.laDireccion.Location = new System.Drawing.Point(122, 131);
            this.laDireccion.Name = "laDireccion";
            this.laDireccion.Size = new System.Drawing.Size(17, 17);
            this.laDireccion.TabIndex = 2;
            this.laDireccion.Text = "X";
            // 
            // lbNombrePrincipal
            // 
            this.lbNombrePrincipal.AutoSize = true;
            this.lbNombrePrincipal.Location = new System.Drawing.Point(123, 87);
            this.lbNombrePrincipal.Name = "lbNombrePrincipal";
            this.lbNombrePrincipal.Size = new System.Drawing.Size(17, 17);
            this.lbNombrePrincipal.TabIndex = 1;
            this.lbNombrePrincipal.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoEllipsis = true;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(165, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(406, 29);
            this.label10.TabIndex = 17;
            this.label10.Text = "LOS DATOS INTRODUCIDOS SON:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnDatos);
            this.Controls.Add(this.btIntDatos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCambiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEuros);
            this.Controls.Add(this.tbPesetas);
            this.Name = "fmEdicion";
            this.Text = "s";
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPesetas;
        private System.Windows.Forms.TextBox tbEuros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btIntDatos;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.Label lbNombrePrincipal;
        private System.Windows.Forms.Label laDNI;
        private System.Windows.Forms.Label laCodigoPostal;
        private System.Windows.Forms.Label laEmail;
        private System.Windows.Forms.Label laTelefono;
        private System.Windows.Forms.Label laLocalidad;
        private System.Windows.Forms.Label laDireccion;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbNombrePrincipal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
    }
}

