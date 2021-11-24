namespace EditorGrafico
{
    partial class fmTamanyo
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
            this.lbIz = new System.Windows.Forms.Label();
            this.lbDer = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIzq = new System.Windows.Forms.TextBox();
            this.tbDer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIz
            // 
            this.lbIz.AutoSize = true;
            this.lbIz.Location = new System.Drawing.Point(66, 60);
            this.lbIz.Name = "lbIz";
            this.lbIz.Size = new System.Drawing.Size(48, 17);
            this.lbIz.TabIndex = 0;
            this.lbIz.Text = "Ancho";
            // 
            // lbDer
            // 
            this.lbDer.AutoSize = true;
            this.lbDer.Location = new System.Drawing.Point(331, 60);
            this.lbDer.Name = "lbDer";
            this.lbDer.Size = new System.Drawing.Size(32, 17);
            this.lbDer.TabIndex = 1;
            this.lbDer.Text = "Alto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "px";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "px";
            // 
            // tbIzq
            // 
            this.tbIzq.Location = new System.Drawing.Point(58, 90);
            this.tbIzq.Name = "tbIzq";
            this.tbIzq.Size = new System.Drawing.Size(100, 22);
            this.tbIzq.TabIndex = 4;
            this.tbIzq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // tbDer
            // 
            this.tbDer.Location = new System.Drawing.Point(319, 90);
            this.tbDer.Name = "tbDer";
            this.tbDer.Size = new System.Drawing.Size(100, 22);
            this.tbDer.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(71, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(332, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 27);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fmTamanyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 245);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbDer);
            this.Controls.Add(this.tbIzq);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbDer);
            this.Controls.Add(this.lbIz);
            this.Name = "fmTamanyo";
            this.Text = "Tamaño de Dibujo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox tbIzq;
        public System.Windows.Forms.TextBox tbDer;
        public System.Windows.Forms.Label lbIz;
        public System.Windows.Forms.Label lbDer;
    }
}