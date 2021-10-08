namespace Formulario
{
    partial class fmFormulario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmFormulario));
            this.laBienvenido = new System.Windows.Forms.Label();
            this.btArriba = new System.Windows.Forms.Button();
            this.btIzquierda = new System.Windows.Forms.Button();
            this.btDerecha = new System.Windows.Forms.Button();
            this.btAbajo = new System.Windows.Forms.Button();
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btSalir = new System.Windows.Forms.Button();
            this.btControlPanel = new System.Windows.Forms.Button();
            this.btControlFor = new System.Windows.Forms.Button();
            this.btDetras = new System.Windows.Forms.Button();
            this.btDelante = new System.Windows.Forms.Button();
            this.btAumenta = new System.Windows.Forms.Button();
            this.btDisminuye = new System.Windows.Forms.Button();
            this.labelMover = new System.Windows.Forms.Label();
            this.labelTamanyo = new System.Windows.Forms.Label();
            this.btVisible = new System.Windows.Forms.Button();
            this.btAcerca = new System.Windows.Forms.Button();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            this.btTresSender = new System.Windows.Forms.Button();
            this.btDosSender = new System.Windows.Forms.Button();
            this.btUnoSender = new System.Windows.Forms.Button();
            this.panelBotones.SuspendLayout();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // laBienvenido
            // 
            this.laBienvenido.BackColor = System.Drawing.Color.LightBlue;
            this.laBienvenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.laBienvenido.Dock = System.Windows.Forms.DockStyle.Top;
            this.laBienvenido.Font = new System.Drawing.Font("Marlett", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laBienvenido.ForeColor = System.Drawing.Color.DarkCyan;
            this.laBienvenido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.laBienvenido.Location = new System.Drawing.Point(0, 0);
            this.laBienvenido.Name = "laBienvenido";
            this.laBienvenido.Size = new System.Drawing.Size(1000, 54);
            this.laBienvenido.TabIndex = 1;
            this.laBienvenido.Text = "Bienvenido a la Aplicación";
            this.laBienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btArriba
            // 
            this.btArriba.Location = new System.Drawing.Point(115, 162);
            this.btArriba.Name = "btArriba";
            this.btArriba.Size = new System.Drawing.Size(97, 32);
            this.btArriba.TabIndex = 2;
            this.btArriba.Text = "Arriba";
            this.btArriba.UseVisualStyleBackColor = true;
            this.btArriba.Click += new System.EventHandler(this.btArriba_Click);
            // 
            // btIzquierda
            // 
            this.btIzquierda.Location = new System.Drawing.Point(12, 212);
            this.btIzquierda.Name = "btIzquierda";
            this.btIzquierda.Size = new System.Drawing.Size(98, 32);
            this.btIzquierda.TabIndex = 1;
            this.btIzquierda.Text = "Izquierda";
            this.btIzquierda.UseVisualStyleBackColor = true;
            this.btIzquierda.Click += new System.EventHandler(this.btIzquierda_Click);
            // 
            // btDerecha
            // 
            this.btDerecha.Location = new System.Drawing.Point(218, 212);
            this.btDerecha.Name = "btDerecha";
            this.btDerecha.Size = new System.Drawing.Size(97, 32);
            this.btDerecha.TabIndex = 3;
            this.btDerecha.Text = "Derecha";
            this.btDerecha.UseVisualStyleBackColor = true;
            this.btDerecha.Click += new System.EventHandler(this.btDerecha_Click);
            // 
            // btAbajo
            // 
            this.btAbajo.Location = new System.Drawing.Point(115, 261);
            this.btAbajo.Name = "btAbajo";
            this.btAbajo.Size = new System.Drawing.Size(97, 32);
            this.btAbajo.TabIndex = 4;
            this.btAbajo.Text = "Abajo";
            this.btAbajo.UseVisualStyleBackColor = true;
            this.btAbajo.Click += new System.EventHandler(this.btAbajo_Click);
            // 
            // panelBotones
            // 
            this.panelBotones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelBotones.Controls.Add(this.btSalir);
            this.panelBotones.Controls.Add(this.btControlPanel);
            this.panelBotones.Controls.Add(this.btControlFor);
            this.panelBotones.Controls.Add(this.btDetras);
            this.panelBotones.Controls.Add(this.btDelante);
            this.panelBotones.Controls.Add(this.btAumenta);
            this.panelBotones.Controls.Add(this.btDisminuye);
            this.panelBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBotones.Location = new System.Drawing.Point(0, 494);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(1000, 68);
            this.panelBotones.TabIndex = 6;
            // 
            // btSalir
            // 
            this.btSalir.AutoSize = true;
            this.btSalir.Location = new System.Drawing.Point(648, 19);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(103, 30);
            this.btSalir.TabIndex = 8;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btControlPanel
            // 
            this.btControlPanel.AutoSize = true;
            this.btControlPanel.Location = new System.Drawing.Point(522, 19);
            this.btControlPanel.Name = "btControlPanel";
            this.btControlPanel.Size = new System.Drawing.Size(120, 30);
            this.btControlPanel.TabIndex = 7;
            this.btControlPanel.Text = "ControlPan";
            this.btControlPanel.UseVisualStyleBackColor = true;
            this.btControlPanel.Click += new System.EventHandler(this.btControlPan);
            // 
            // btControlFor
            // 
            this.btControlFor.AutoSize = true;
            this.btControlFor.Location = new System.Drawing.Point(413, 19);
            this.btControlFor.Name = "btControlFor";
            this.btControlFor.Size = new System.Drawing.Size(103, 30);
            this.btControlFor.TabIndex = 6;
            this.btControlFor.Text = "Control For";
            this.btControlFor.UseVisualStyleBackColor = true;
            this.btControlFor.Click += new System.EventHandler(this.btControlFor_Click);
            // 
            // btDetras
            // 
            this.btDetras.AutoSize = true;
            this.btDetras.Location = new System.Drawing.Point(309, 19);
            this.btDetras.Name = "btDetras";
            this.btDetras.Size = new System.Drawing.Size(98, 30);
            this.btDetras.TabIndex = 4;
            this.btDetras.Text = "Detrás";
            this.btDetras.UseVisualStyleBackColor = true;
            this.btDetras.Click += new System.EventHandler(this.btDetras_Click);
            // 
            // btDelante
            // 
            this.btDelante.AutoSize = true;
            this.btDelante.Location = new System.Drawing.Point(205, 19);
            this.btDelante.Name = "btDelante";
            this.btDelante.Size = new System.Drawing.Size(98, 30);
            this.btDelante.TabIndex = 3;
            this.btDelante.Text = "Delante";
            this.btDelante.UseVisualStyleBackColor = true;
            this.btDelante.Click += new System.EventHandler(this.btDelante_Click);
            // 
            // btAumenta
            // 
            this.btAumenta.AutoSize = true;
            this.btAumenta.Location = new System.Drawing.Point(10, 19);
            this.btAumenta.Name = "btAumenta";
            this.btAumenta.Size = new System.Drawing.Size(85, 30);
            this.btAumenta.TabIndex = 1;
            this.btAumenta.Text = "Aumenta";
            this.btAumenta.UseVisualStyleBackColor = true;
            this.btAumenta.Click += new System.EventHandler(this.button6_Click);
            // 
            // btDisminuye
            // 
            this.btDisminuye.AutoSize = true;
            this.btDisminuye.Location = new System.Drawing.Point(101, 19);
            this.btDisminuye.Name = "btDisminuye";
            this.btDisminuye.Size = new System.Drawing.Size(98, 30);
            this.btDisminuye.TabIndex = 2;
            this.btDisminuye.Text = "Disminuye";
            this.btDisminuye.UseVisualStyleBackColor = true;
            this.btDisminuye.Click += new System.EventHandler(this.btDisminuye_Click);
            // 
            // labelMover
            // 
            this.labelMover.AutoSize = true;
            this.labelMover.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labelMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMover.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelMover.Location = new System.Drawing.Point(402, 212);
            this.labelMover.Name = "labelMover";
            this.labelMover.Size = new System.Drawing.Size(212, 31);
            this.labelMover.TabIndex = 2;
            this.labelMover.Text = "XXXXXXXXXXX";
            this.labelMover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMover.Click += new System.EventHandler(this.labelMover_Click);
            // 
            // labelTamanyo
            // 
            this.labelTamanyo.AutoSize = true;
            this.labelTamanyo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTamanyo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.labelTamanyo.Location = new System.Drawing.Point(12, 455);
            this.labelTamanyo.Name = "labelTamanyo";
            this.labelTamanyo.Size = new System.Drawing.Size(49, 36);
            this.labelTamanyo.TabIndex = 7;
            this.labelTamanyo.Text = "16";
            // 
            // btVisible
            // 
            this.btVisible.AutoSize = true;
            this.btVisible.Location = new System.Drawing.Point(859, 455);
            this.btVisible.Name = "btVisible";
            this.btVisible.Size = new System.Drawing.Size(92, 30);
            this.btVisible.TabIndex = 5;
            this.btVisible.Text = "No visible";
            this.btVisible.UseVisualStyleBackColor = true;
            this.btVisible.Click += new System.EventHandler(this.btVisible_Click);
            // 
            // btAcerca
            // 
            this.btAcerca.AutoSize = true;
            this.btAcerca.Location = new System.Drawing.Point(852, 401);
            this.btAcerca.Name = "btAcerca";
            this.btAcerca.Size = new System.Drawing.Size(99, 30);
            this.btAcerca.TabIndex = 8;
            this.btAcerca.Text = "Acerca De";
            this.btAcerca.UseVisualStyleBackColor = true;
            this.btAcerca.Click += new System.EventHandler(this.btAcerca_Click);
            // 
            // gbBotones
            // 
            this.gbBotones.BackColor = System.Drawing.Color.LightBlue;
            this.gbBotones.Controls.Add(this.btTresSender);
            this.gbBotones.Controls.Add(this.btDosSender);
            this.gbBotones.Controls.Add(this.btUnoSender);
            this.gbBotones.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbBotones.Location = new System.Drawing.Point(684, 103);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(267, 129);
            this.gbBotones.TabIndex = 9;
            this.gbBotones.TabStop = false;
            this.gbBotones.Text = "Prueba de Sender";
            // 
            // btTresSender
            // 
            this.btTresSender.AutoSize = true;
            this.btTresSender.Location = new System.Drawing.Point(175, 61);
            this.btTresSender.Name = "btTresSender";
            this.btTresSender.Size = new System.Drawing.Size(75, 30);
            this.btTresSender.TabIndex = 2;
            this.btTresSender.Text = "Tres";
            this.btTresSender.UseVisualStyleBackColor = true;
            this.btTresSender.Click += new System.EventHandler(this.btUnoSender_Click);
            // 
            // btDosSender
            // 
            this.btDosSender.AutoSize = true;
            this.btDosSender.Location = new System.Drawing.Point(93, 59);
            this.btDosSender.Name = "btDosSender";
            this.btDosSender.Size = new System.Drawing.Size(75, 30);
            this.btDosSender.TabIndex = 1;
            this.btDosSender.Text = "Dos";
            this.btDosSender.UseVisualStyleBackColor = true;
            this.btDosSender.Click += new System.EventHandler(this.btUnoSender_Click);
            // 
            // btUnoSender
            // 
            this.btUnoSender.AutoSize = true;
            this.btUnoSender.Location = new System.Drawing.Point(12, 59);
            this.btUnoSender.Name = "btUnoSender";
            this.btUnoSender.Size = new System.Drawing.Size(75, 30);
            this.btUnoSender.TabIndex = 0;
            this.btUnoSender.Text = "Uno";
            this.btUnoSender.UseVisualStyleBackColor = true;
            this.btUnoSender.Click += new System.EventHandler(this.btUnoSender_Click);
            // 
            // fmFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.btAcerca);
            this.Controls.Add(this.btVisible);
            this.Controls.Add(this.labelTamanyo);
            this.Controls.Add(this.labelMover);
            this.Controls.Add(this.panelBotones);
            this.Controls.Add(this.btAbajo);
            this.Controls.Add(this.btDerecha);
            this.Controls.Add(this.btIzquierda);
            this.Controls.Add(this.btArriba);
            this.Controls.Add(this.laBienvenido);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmFormulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto Formulario";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.fmFormulario_Click);
            this.panelBotones.ResumeLayout(false);
            this.panelBotones.PerformLayout();
            this.gbBotones.ResumeLayout(false);
            this.gbBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laBienvenido;
        private System.Windows.Forms.Button btArriba;
        private System.Windows.Forms.Button btIzquierda;
        private System.Windows.Forms.Button btDerecha;
        private System.Windows.Forms.Button btAbajo;
        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.Button btAumenta;
        private System.Windows.Forms.Button btDisminuye;
        private System.Windows.Forms.Label labelMover;
        private System.Windows.Forms.Button btDelante;
        private System.Windows.Forms.Label labelTamanyo;
        private System.Windows.Forms.Button btDetras;
        private System.Windows.Forms.Button btVisible;
        private System.Windows.Forms.Button btControlFor;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btControlPanel;
        private System.Windows.Forms.Button btAcerca;
        private System.Windows.Forms.GroupBox gbBotones;
        private System.Windows.Forms.Button btTresSender;
        private System.Windows.Forms.Button btDosSender;
        private System.Windows.Forms.Button btUnoSender;
    }
}

