namespace _01Datos
{
    partial class fmComandos
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
            this.components = new System.ComponentModel.Container();
            this.bd_telefonosDataSet = new _01Datos.bd_telefonosDataSet();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonosTableAdapter = new _01Datos.bd_telefonosDataSetTableAdapters.telefonosTableAdapter();
            this.tableAdapterManager = new _01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btNuevo = new System.Windows.Forms.Button();
            this.laPosicion = new System.Windows.Forms.Label();
            this.btUltimo = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btPrimero = new System.Windows.Forms.Button();
            this.dvgTelefonos = new System.Windows.Forms.DataGridView();
            this.stEstado = new System.Windows.Forms.StatusStrip();
            this.tslNombre = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTelefonos)).BeginInit();
            this.stEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // bd_telefonosDataSet
            // 
            this.bd_telefonosDataSet.DataSetName = "bd_telefonosDataSet";
            this.bd_telefonosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // telefonosBindingSource
            // 
            this.telefonosBindingSource.DataMember = "telefonos";
            this.telefonosBindingSource.DataSource = this.bd_telefonosDataSet;
            // 
            // telefonosTableAdapter
            // 
            this.telefonosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.telefonosTableAdapter = this.telefonosTableAdapter;
            this.tableAdapterManager.UpdateOrder = _01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btBorrar);
            this.panel1.Controls.Add(this.btGuardar);
            this.panel1.Controls.Add(this.btNuevo);
            this.panel1.Controls.Add(this.laPosicion);
            this.panel1.Controls.Add(this.btUltimo);
            this.panel1.Controls.Add(this.btSiguiente);
            this.panel1.Controls.Add(this.btAnterior);
            this.panel1.Controls.Add(this.btPrimero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 73);
            this.panel1.TabIndex = 0;
            // 
            // btNuevo
            // 
            this.btNuevo.AutoSize = true;
            this.btNuevo.Location = new System.Drawing.Point(424, 22);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 27);
            this.btNuevo.TabIndex = 5;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // laPosicion
            // 
            this.laPosicion.AutoSize = true;
            this.laPosicion.Location = new System.Drawing.Point(186, 28);
            this.laPosicion.Name = "laPosicion";
            this.laPosicion.Size = new System.Drawing.Size(48, 17);
            this.laPosicion.TabIndex = 4;
            this.laPosicion.Text = "0 de 0";
            // 
            // btUltimo
            // 
            this.btUltimo.AutoSize = true;
            this.btUltimo.Location = new System.Drawing.Point(343, 22);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(75, 27);
            this.btUltimo.TabIndex = 3;
            this.btUltimo.Text = "Último";
            this.btUltimo.UseVisualStyleBackColor = true;
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.AutoSize = true;
            this.btSiguiente.Location = new System.Drawing.Point(251, 22);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(77, 27);
            this.btSiguiente.TabIndex = 2;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.AutoSize = true;
            this.btAnterior.Location = new System.Drawing.Point(103, 22);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(75, 27);
            this.btAnterior.TabIndex = 1;
            this.btAnterior.Text = "Anterior";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btPrimero
            // 
            this.btPrimero.AutoSize = true;
            this.btPrimero.Location = new System.Drawing.Point(11, 22);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(75, 27);
            this.btPrimero.TabIndex = 0;
            this.btPrimero.Text = "Primero";
            this.btPrimero.UseVisualStyleBackColor = true;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
            // 
            // dvgTelefonos
            // 
            this.dvgTelefonos.AutoGenerateColumns = false;
            this.dvgTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dvgTelefonos.DataSource = this.telefonosBindingSource;
            this.dvgTelefonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dvgTelefonos.Location = new System.Drawing.Point(0, 73);
            this.dvgTelefonos.Name = "dvgTelefonos";
            this.dvgTelefonos.RowTemplate.Height = 24;
            this.dvgTelefonos.Size = new System.Drawing.Size(858, 423);
            this.dvgTelefonos.TabIndex = 1;
            this.dvgTelefonos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefonos_CellEnter);
            // 
            // stEstado
            // 
            this.stEstado.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslNombre});
            this.stEstado.Location = new System.Drawing.Point(0, 471);
            this.stEstado.Name = "stEstado";
            this.stEstado.Size = new System.Drawing.Size(858, 25);
            this.stEstado.TabIndex = 2;
            this.stEstado.Text = "statusStrip1";
            // 
            // tslNombre
            // 
            this.tslNombre.Name = "tslNombre";
            this.tslNombre.Size = new System.Drawing.Size(151, 20);
            this.tslNombre.Text = "toolStripStatusLabel1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "observaciones";
            this.dataGridViewTextBoxColumn5.HeaderText = "observaciones";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ciudad";
            this.dataGridViewTextBoxColumn6.HeaderText = "ciudad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "provincia";
            this.dataGridViewTextBoxColumn7.HeaderText = "provincia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pais";
            this.dataGridViewTextBoxColumn8.HeaderText = "pais";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // btGuardar
            // 
            this.btGuardar.AutoSize = true;
            this.btGuardar.Location = new System.Drawing.Point(505, 22);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 27);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.AutoSize = true;
            this.btBorrar.Location = new System.Drawing.Point(586, 23);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 27);
            this.btBorrar.TabIndex = 7;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // fmComandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 496);
            this.Controls.Add(this.stEstado);
            this.Controls.Add(this.dvgTelefonos);
            this.Controls.Add(this.panel1);
            this.Name = "fmComandos";
            this.Text = "fmComandos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmComandos_FormClosing);
            this.Load += new System.EventHandler(this.fmComandos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTelefonos)).EndInit();
            this.stEstado.ResumeLayout(false);
            this.stEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private bd_telefonosDataSet bd_telefonosDataSet;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private bd_telefonosDataSetTableAdapters.telefonosTableAdapter telefonosTableAdapter;
        private bd_telefonosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dvgTelefonos;
        private System.Windows.Forms.Button btPrimero;
        private System.Windows.Forms.Button btUltimo;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.StatusStrip stEstado;
        private System.Windows.Forms.Label laPosicion;
        private System.Windows.Forms.ToolStripStatusLabel tslNombre;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btBorrar;
    }
}