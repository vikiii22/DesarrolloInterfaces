namespace _03Datos
{
    partial class fmActualizar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbNPais = new System.Windows.Forms.TextBox();
            this.tbPIB = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.cbContinente = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "capital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "población (En mes)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(509, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre País";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(509, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Continente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(509, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "PIB (En miles de millones)";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(128, 80);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 22);
            this.tbId.TabIndex = 6;
            // 
            // tbCapital
            // 
            this.tbCapital.Location = new System.Drawing.Point(128, 170);
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(100, 22);
            this.tbCapital.TabIndex = 7;
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(128, 259);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(100, 22);
            this.tbPoblacion.TabIndex = 8;
            // 
            // tbNPais
            // 
            this.tbNPais.Location = new System.Drawing.Point(512, 80);
            this.tbNPais.Name = "tbNPais";
            this.tbNPais.Size = new System.Drawing.Size(100, 22);
            this.tbNPais.TabIndex = 9;
            // 
            // tbPIB
            // 
            this.tbPIB.Location = new System.Drawing.Point(512, 259);
            this.tbPIB.Name = "tbPIB";
            this.tbPIB.Size = new System.Drawing.Size(100, 22);
            this.tbPIB.TabIndex = 11;
            // 
            // btAceptar
            // 
            this.btAceptar.AutoSize = true;
            this.btAceptar.Location = new System.Drawing.Point(153, 348);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 27);
            this.btAceptar.TabIndex = 12;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.AutoSize = true;
            this.btCancelar.Location = new System.Drawing.Point(523, 348);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 27);
            this.btCancelar.TabIndex = 13;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // cbContinente
            // 
            this.cbContinente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinente.FormattingEnabled = true;
            this.cbContinente.Location = new System.Drawing.Point(512, 170);
            this.cbContinente.Name = "cbContinente";
            this.cbContinente.Size = new System.Drawing.Size(121, 24);
            this.cbContinente.TabIndex = 14;
            // 
            // fmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbContinente);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbPIB);
            this.Controls.Add(this.tbNPais);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.tbCapital);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmActualizar";
            this.Text = "fmActualizar";
            this.Load += new System.EventHandler(this.fmActualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.TextBox tbId;
        public System.Windows.Forms.TextBox tbCapital;
        public System.Windows.Forms.TextBox tbPoblacion;
        public System.Windows.Forms.TextBox tbNPais;
        public System.Windows.Forms.TextBox tbPIB;
        public System.Windows.Forms.ComboBox cbContinente;
    }
}