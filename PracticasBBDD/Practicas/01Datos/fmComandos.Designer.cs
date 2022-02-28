
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.laPosicion = new System.Windows.Forms.Label();
            this.btUltimo = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btSiguiente = new System.Windows.Forms.Button();
            this.btAnterior = new System.Windows.Forms.Button();
            this.btPrimero = new System.Windows.Forms.Button();
            this.bd_telefonosDataSet = new _01Datos.bd_telefonosDataSet();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonosTableAdapter = new _01Datos.bd_telefonosDataSetTableAdapters.telefonosTableAdapter();
            this.tableAdapterManager = new _01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager();
            this.dgvTelefonos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stEstado = new System.Windows.Forms.StatusStrip();
            this.la1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).BeginInit();
            this.stEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.laPosicion);
            this.panel1.Controls.Add(this.btUltimo);
            this.panel1.Controls.Add(this.btBorrar);
            this.panel1.Controls.Add(this.btGuardar);
            this.panel1.Controls.Add(this.btNuevo);
            this.panel1.Controls.Add(this.btSiguiente);
            this.panel1.Controls.Add(this.btAnterior);
            this.panel1.Controls.Add(this.btPrimero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 71);
            this.panel1.TabIndex = 0;
            // 
            // laPosicion
            // 
            this.laPosicion.AutoSize = true;
            this.laPosicion.Location = new System.Drawing.Point(200, 34);
            this.laPosicion.Name = "laPosicion";
            this.laPosicion.Size = new System.Drawing.Size(35, 14);
            this.laPosicion.TabIndex = 3;
            this.laPosicion.Text = "label1";
            // 
            // btUltimo
            // 
            this.btUltimo.Location = new System.Drawing.Point(349, 24);
            this.btUltimo.Name = "btUltimo";
            this.btUltimo.Size = new System.Drawing.Size(75, 25);
            this.btUltimo.TabIndex = 6;
            this.btUltimo.Text = "Último";
            this.btUltimo.UseVisualStyleBackColor = true;
            this.btUltimo.Click += new System.EventHandler(this.btUltimo_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(701, 24);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 25);
            this.btBorrar.TabIndex = 5;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(620, 24);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 25);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(539, 24);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 25);
            this.btNuevo.TabIndex = 3;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btSiguiente
            // 
            this.btSiguiente.Location = new System.Drawing.Point(268, 24);
            this.btSiguiente.Name = "btSiguiente";
            this.btSiguiente.Size = new System.Drawing.Size(75, 25);
            this.btSiguiente.TabIndex = 2;
            this.btSiguiente.Text = "Siguiente";
            this.btSiguiente.UseVisualStyleBackColor = true;
            this.btSiguiente.Click += new System.EventHandler(this.btSiguiente_Click);
            // 
            // btAnterior
            // 
            this.btAnterior.Location = new System.Drawing.Point(94, 24);
            this.btAnterior.Name = "btAnterior";
            this.btAnterior.Size = new System.Drawing.Size(75, 25);
            this.btAnterior.TabIndex = 1;
            this.btAnterior.Text = "Anterior";
            this.btAnterior.UseVisualStyleBackColor = true;
            this.btAnterior.Click += new System.EventHandler(this.btAnterior_Click);
            // 
            // btPrimero
            // 
            this.btPrimero.Location = new System.Drawing.Point(13, 24);
            this.btPrimero.Name = "btPrimero";
            this.btPrimero.Size = new System.Drawing.Size(75, 25);
            this.btPrimero.TabIndex = 0;
            this.btPrimero.Text = "Primero";
            this.btPrimero.UseVisualStyleBackColor = true;
            this.btPrimero.Click += new System.EventHandler(this.btPrimero_Click);
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
            // dgvTelefonos
            // 
            this.dgvTelefonos.AutoGenerateColumns = false;
            this.dgvTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvTelefonos.DataSource = this.telefonosBindingSource;
            this.dgvTelefonos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTelefonos.Location = new System.Drawing.Point(0, 71);
            this.dgvTelefonos.Name = "dgvTelefonos";
            this.dgvTelefonos.Size = new System.Drawing.Size(881, 438);
            this.dgvTelefonos.TabIndex = 2;
            this.dgvTelefonos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTelefonos_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 4;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 75;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "observaciones";
            this.dataGridViewTextBoxColumn5.HeaderText = "observaciones";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ciudad";
            this.dataGridViewTextBoxColumn6.HeaderText = "ciudad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 75;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "provincia";
            this.dataGridViewTextBoxColumn7.HeaderText = "provincia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pais";
            this.dataGridViewTextBoxColumn8.HeaderText = "pais";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 75;
            // 
            // stEstado
            // 
            this.stEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.la1});
            this.stEstado.Location = new System.Drawing.Point(0, 487);
            this.stEstado.Name = "stEstado";
            this.stEstado.Size = new System.Drawing.Size(881, 22);
            this.stEstado.TabIndex = 3;
            this.stEstado.Text = "statusStrip1";
            // 
            // la1
            // 
            this.la1.Name = "la1";
            this.la1.Size = new System.Drawing.Size(118, 17);
            this.la1.Text = "toolStripStatusLabel1";
            // 
            // fmComandos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 509);
            this.Controls.Add(this.stEstado);
            this.Controls.Add(this.dgvTelefonos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "fmComandos";
            this.Text = "Mantenimiento de Tabla por Órdenes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmComandos_FormClosing);
            this.Load += new System.EventHandler(this.fmComandos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTelefonos)).EndInit();
            this.stEstado.ResumeLayout(false);
            this.stEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private bd_telefonosDataSet bd_telefonosDataSet;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private bd_telefonosDataSetTableAdapters.telefonosTableAdapter telefonosTableAdapter;
        private bd_telefonosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvTelefonos;
        private System.Windows.Forms.Button btUltimo;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btSiguiente;
        private System.Windows.Forms.Button btAnterior;
        private System.Windows.Forms.Button btPrimero;
        private System.Windows.Forms.Label laPosicion;
        private System.Windows.Forms.StatusStrip stEstado;
        private System.Windows.Forms.ToolStripStatusLabel la1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}