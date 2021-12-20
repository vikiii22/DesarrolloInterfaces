namespace _01Datos
{
    partial class fmConsultasFiltros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConsultasFiltros));
            System.Windows.Forms.Label idLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.bd_telefonosDataSet = new _01Datos.bd_telefonosDataSet();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonosTableAdapter = new _01Datos.bd_telefonosDataSetTableAdapters.telefonosTableAdapter();
            this.tableAdapterManager = new _01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager();
            this.telefonosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.telefonosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.ckOrdenar = new System.Windows.Forms.CheckBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).BeginInit();
            this.telefonosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).BeginInit();
            this.gbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.gbOrdenar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 506);
            this.panel1.TabIndex = 0;
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
            // telefonosBindingNavigator
            // 
            this.telefonosBindingNavigator.AddNewItem = null;
            this.telefonosBindingNavigator.BindingSource = this.telefonosBindingSource;
            this.telefonosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.telefonosBindingNavigator.DeleteItem = null;
            this.telefonosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.telefonosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem});
            this.telefonosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.telefonosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.telefonosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.telefonosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.telefonosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.telefonosBindingNavigator.Name = "telefonosBindingNavigator";
            this.telefonosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.telefonosBindingNavigator.Size = new System.Drawing.Size(894, 27);
            this.telefonosBindingNavigator.TabIndex = 1;
            this.telefonosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // telefonosDataGridView
            // 
            this.telefonosDataGridView.AutoGenerateColumns = false;
            this.telefonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefonosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.telefonosDataGridView.DataSource = this.telefonosBindingSource;
            this.telefonosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefonosDataGridView.Location = new System.Drawing.Point(0, 27);
            this.telefonosDataGridView.Name = "telefonosDataGridView";
            this.telefonosDataGridView.RowTemplate.Height = 24;
            this.telefonosDataGridView.Size = new System.Drawing.Size(894, 265);
            this.telefonosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.ckOrdenar);
            this.gbOrdenar.Controls.Add(this.rbCodigo);
            this.gbOrdenar.Controls.Add(this.rbNombre);
            this.gbOrdenar.Location = new System.Drawing.Point(66, 56);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(200, 129);
            this.gbOrdenar.TabIndex = 0;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar Por";
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(22, 22);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 0;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Location = new System.Drawing.Point(22, 49);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(73, 21);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Código";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // ckOrdenar
            // 
            this.ckOrdenar.AutoSize = true;
            this.ckOrdenar.Checked = true;
            this.ckOrdenar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckOrdenar.Location = new System.Drawing.Point(22, 90);
            this.ckOrdenar.Name = "ckOrdenar";
            this.ckOrdenar.Size = new System.Drawing.Size(105, 21);
            this.ckOrdenar.TabIndex = 2;
            this.ckOrdenar.Text = "Ascendente";
            this.ckOrdenar.UseVisualStyleBackColor = true;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(315, 74);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(112, 17);
            idLabel.TabIndex = 1;
            idLabel.Text = "id Seleccionado:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(433, 69);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // fmConsultasFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 798);
            this.Controls.Add(this.telefonosDataGridView);
            this.Controls.Add(this.telefonosBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsultasFiltros";
            this.Text = "fmConsultasFiltros";
            this.Load += new System.EventHandler(this.fmConsultasFiltros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).EndInit();
            this.telefonosBindingNavigator.ResumeLayout(false);
            this.telefonosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).EndInit();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private bd_telefonosDataSet bd_telefonosDataSet;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private bd_telefonosDataSetTableAdapters.telefonosTableAdapter telefonosTableAdapter;
        private bd_telefonosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator telefonosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.DataGridView telefonosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.CheckBox ckOrdenar;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.TextBox idTextBox;
    }
}