namespace _01Datos
{
    partial class fmAutomatico
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label observacionesLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label provinciaLabel;
            System.Windows.Forms.Label paisLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAutomatico));
            this.pnAutomatico = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_telefonosDataSet = new _01Datos.bd_telefonosDataSet();
            this.paisTextBox = new System.Windows.Forms.TextBox();
            this.provinciaTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.observacionesTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.telefonosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.telefonosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.telefonosTableAdapter = new _01Datos.bd_telefonosDataSetTableAdapters.telefonosTableAdapter();
            this.tableAdapterManager = new _01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager();
            this.telefonosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            observacionesLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            provinciaLabel = new System.Windows.Forms.Label();
            paisLabel = new System.Windows.Forms.Label();
            this.pnAutomatico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).BeginInit();
            this.telefonosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(38, 66);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "id:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(154, 69);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 17);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(612, 75);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(69, 17);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "direccion:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(419, 72);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(63, 17);
            telefonoLabel.TabIndex = 7;
            telefonoLabel.Text = "telefono:";
            // 
            // observacionesLabel
            // 
            observacionesLabel.AutoSize = true;
            observacionesLabel.Location = new System.Drawing.Point(440, 191);
            observacionesLabel.Name = "observacionesLabel";
            observacionesLabel.Size = new System.Drawing.Size(104, 17);
            observacionesLabel.TabIndex = 9;
            observacionesLabel.Text = "observaciones:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(293, 139);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(54, 17);
            ciudadLabel.TabIndex = 11;
            ciudadLabel.Text = "ciudad:";
            // 
            // provinciaLabel
            // 
            provinciaLabel.AutoSize = true;
            provinciaLabel.Location = new System.Drawing.Point(32, 139);
            provinciaLabel.Name = "provinciaLabel";
            provinciaLabel.Size = new System.Drawing.Size(69, 17);
            provinciaLabel.TabIndex = 13;
            provinciaLabel.Text = "provincia:";
            // 
            // paisLabel
            // 
            paisLabel.AutoSize = true;
            paisLabel.Location = new System.Drawing.Point(529, 139);
            paisLabel.Name = "paisLabel";
            paisLabel.Size = new System.Drawing.Size(38, 17);
            paisLabel.TabIndex = 15;
            paisLabel.Text = "pais:";
            // 
            // pnAutomatico
            // 
            this.pnAutomatico.Controls.Add(this.textBox1);
            this.pnAutomatico.Controls.Add(paisLabel);
            this.pnAutomatico.Controls.Add(this.paisTextBox);
            this.pnAutomatico.Controls.Add(provinciaLabel);
            this.pnAutomatico.Controls.Add(this.provinciaTextBox);
            this.pnAutomatico.Controls.Add(ciudadLabel);
            this.pnAutomatico.Controls.Add(this.ciudadTextBox);
            this.pnAutomatico.Controls.Add(observacionesLabel);
            this.pnAutomatico.Controls.Add(this.observacionesTextBox);
            this.pnAutomatico.Controls.Add(telefonoLabel);
            this.pnAutomatico.Controls.Add(this.telefonoTextBox);
            this.pnAutomatico.Controls.Add(direccionLabel);
            this.pnAutomatico.Controls.Add(this.direccionTextBox);
            this.pnAutomatico.Controls.Add(nombreLabel);
            this.pnAutomatico.Controls.Add(this.nombreTextBox);
            this.pnAutomatico.Controls.Add(idLabel);
            this.pnAutomatico.Controls.Add(this.idTextBox);
            this.pnAutomatico.Controls.Add(this.telefonosBindingNavigator);
            this.pnAutomatico.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAutomatico.Location = new System.Drawing.Point(0, 0);
            this.pnAutomatico.Name = "pnAutomatico";
            this.pnAutomatico.Size = new System.Drawing.Size(866, 314);
            this.pnAutomatico.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.telefonosBindingSource, "nombre", true));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "nombre", true));
            this.textBox1.Location = new System.Drawing.Point(739, 134);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 17;
            this.textBox1.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // telefonosBindingSource
            // 
            this.telefonosBindingSource.DataMember = "telefonos";
            this.telefonosBindingSource.DataSource = this.bd_telefonosDataSet;
            // 
            // bd_telefonosDataSet
            // 
            this.bd_telefonosDataSet.DataSetName = "bd_telefonosDataSet";
            this.bd_telefonosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paisTextBox
            // 
            this.paisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "pais", true));
            this.paisTextBox.Location = new System.Drawing.Point(573, 136);
            this.paisTextBox.Name = "paisTextBox";
            this.paisTextBox.Size = new System.Drawing.Size(100, 22);
            this.paisTextBox.TabIndex = 16;
            this.paisTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // provinciaTextBox
            // 
            this.provinciaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "provincia", true));
            this.provinciaTextBox.Location = new System.Drawing.Point(107, 136);
            this.provinciaTextBox.Name = "provinciaTextBox";
            this.provinciaTextBox.Size = new System.Drawing.Size(100, 22);
            this.provinciaTextBox.TabIndex = 14;
            this.provinciaTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(353, 136);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(100, 22);
            this.ciudadTextBox.TabIndex = 12;
            this.ciudadTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // observacionesTextBox
            // 
            this.observacionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "observaciones", true));
            this.observacionesTextBox.Location = new System.Drawing.Point(550, 188);
            this.observacionesTextBox.Multiline = true;
            this.observacionesTextBox.Name = "observacionesTextBox";
            this.observacionesTextBox.Size = new System.Drawing.Size(277, 104);
            this.observacionesTextBox.TabIndex = 10;
            this.observacionesTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(488, 69);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 22);
            this.telefonoTextBox.TabIndex = 8;
            this.telefonoTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(687, 72);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 22);
            this.direccionTextBox.TabIndex = 6;
            this.direccionTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(220, 66);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(169, 22);
            this.nombreTextBox.TabIndex = 4;
            this.nombreTextBox.Click += new System.EventHandler(this.nombreTextBox_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(67, 63);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(34, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // telefonosBindingNavigator
            // 
            this.telefonosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.telefonosBindingNavigator.BindingSource = this.telefonosBindingSource;
            this.telefonosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.telefonosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.telefonosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.telefonosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.telefonosBindingNavigatorSaveItem});
            this.telefonosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.telefonosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.telefonosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.telefonosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.telefonosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.telefonosBindingNavigator.Name = "telefonosBindingNavigator";
            this.telefonosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.telefonosBindingNavigator.Size = new System.Drawing.Size(866, 27);
            this.telefonosBindingNavigator.TabIndex = 2;
            this.telefonosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            this.bindingNavigatorDeleteItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigatorDeleteItem_MouseDown);
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
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
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
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // telefonosBindingNavigatorSaveItem
            // 
            this.telefonosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.telefonosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("telefonosBindingNavigatorSaveItem.Image")));
            this.telefonosBindingNavigatorSaveItem.Name = "telefonosBindingNavigatorSaveItem";
            this.telefonosBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.telefonosBindingNavigatorSaveItem.Text = "Guardar datos";
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
            // telefonosDataGridView
            // 
            this.telefonosDataGridView.AutoGenerateColumns = false;
            this.telefonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.telefonosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.telefonosDataGridView.DataSource = this.telefonosBindingSource;
            this.telefonosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.telefonosDataGridView.Location = new System.Drawing.Point(0, 314);
            this.telefonosDataGridView.MultiSelect = false;
            this.telefonosDataGridView.Name = "telefonosDataGridView";
            this.telefonosDataGridView.ReadOnly = true;
            this.telefonosDataGridView.RowTemplate.Height = 24;
            this.telefonosDataGridView.Size = new System.Drawing.Size(866, 238);
            this.telefonosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ciudad";
            this.dataGridViewTextBoxColumn6.HeaderText = "ciudad";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "provincia";
            this.dataGridViewTextBoxColumn7.HeaderText = "provincia";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "pais";
            this.dataGridViewTextBoxColumn8.HeaderText = "pais";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // fmAutomatico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 552);
            this.Controls.Add(this.telefonosDataGridView);
            this.Controls.Add(this.pnAutomatico);
            this.Name = "fmAutomatico";
            this.Text = "fmAutomatico";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fmAutomatico_FormClosing);
            this.Load += new System.EventHandler(this.fmAutomatico_Load);
            this.pnAutomatico.ResumeLayout(false);
            this.pnAutomatico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).EndInit();
            this.telefonosBindingNavigator.ResumeLayout(false);
            this.telefonosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnAutomatico;
        private bd_telefonosDataSet bd_telefonosDataSet;
        private System.Windows.Forms.BindingSource telefonosBindingSource;
        private bd_telefonosDataSetTableAdapters.telefonosTableAdapter telefonosTableAdapter;
        private bd_telefonosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView telefonosDataGridView;
        private System.Windows.Forms.BindingNavigator telefonosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton telefonosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox paisTextBox;
        private System.Windows.Forms.TextBox provinciaTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox observacionesTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox textBox1;
    }
}