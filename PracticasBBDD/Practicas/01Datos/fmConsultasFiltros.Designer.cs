
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckCiudad = new System.Windows.Forms.CheckBox();
            this.cbCiudad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ckLetras = new System.Windows.Forms.CheckBox();
            this.ckFiltrar = new System.Windows.Forms.CheckBox();
            this.cbLetra = new System.Windows.Forms.ComboBox();
            this.cbProvincia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdSeleccion = new System.Windows.Forms.TextBox();
            this.telefonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bd_telefonosDataSet = new _01Datos.bd_telefonosDataSet();
            this.laIDSeleccionado = new System.Windows.Forms.Label();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.ckOrdenar = new System.Windows.Forms.CheckBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.telefonosTableAdapter = new _01Datos.bd_telefonosDataSetTableAdapters.telefonosTableAdapter();
            this.tableAdapterManager = new _01Datos.bd_telefonosDataSetTableAdapters.TableAdapterManager();
            this.telefonosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.telefonosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).BeginInit();
            this.gbOrdenar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).BeginInit();
            this.telefonosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckCiudad);
            this.panel1.Controls.Add(this.cbCiudad);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ckLetras);
            this.panel1.Controls.Add(this.ckFiltrar);
            this.panel1.Controls.Add(this.cbLetra);
            this.panel1.Controls.Add(this.cbProvincia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btBuscar);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbIdSeleccion);
            this.panel1.Controls.Add(this.laIDSeleccionado);
            this.panel1.Controls.Add(this.gbOrdenar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 387);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(884, 181);
            this.panel1.TabIndex = 0;
            // 
            // ckCiudad
            // 
            this.ckCiudad.AutoSize = true;
            this.ckCiudad.Location = new System.Drawing.Point(710, 74);
            this.ckCiudad.Name = "ckCiudad";
            this.ckCiudad.Size = new System.Drawing.Size(67, 21);
            this.ckCiudad.TabIndex = 14;
            this.ckCiudad.Text = "Filtrar";
            this.ckCiudad.UseVisualStyleBackColor = true;
            this.ckCiudad.CheckedChanged += new System.EventHandler(this.ckCiudad_CheckedChanged);
            // 
            // cbCiudad
            // 
            this.cbCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiudad.FormattingEnabled = true;
            this.cbCiudad.Items.AddRange(new object[] {
            "Alcalá de henares",
            "Argentona",
            "Alcobendas",
            "Alicante",
            "Elche",
            "Gijón",
            "Muxía",
            "Mataporquera"});
            this.cbCiudad.Location = new System.Drawing.Point(710, 43);
            this.cbCiudad.Name = "cbCiudad";
            this.cbCiudad.Size = new System.Drawing.Size(157, 25);
            this.cbCiudad.TabIndex = 13;
            this.cbCiudad.TextChanged += new System.EventHandler(this.ckCiudad_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(707, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Letras";
            // 
            // ckLetras
            // 
            this.ckLetras.AutoSize = true;
            this.ckLetras.Location = new System.Drawing.Point(591, 144);
            this.ckLetras.Name = "ckLetras";
            this.ckLetras.Size = new System.Drawing.Size(261, 21);
            this.ckLetras.TabIndex = 10;
            this.ckLetras.Text = "Filtrar nombres que empiezan por...";
            this.ckLetras.UseVisualStyleBackColor = true;
            this.ckLetras.CheckedChanged += new System.EventHandler(this.ckLetras_CheckedChanged);
            // 
            // ckFiltrar
            // 
            this.ckFiltrar.AutoSize = true;
            this.ckFiltrar.Location = new System.Drawing.Point(505, 74);
            this.ckFiltrar.Name = "ckFiltrar";
            this.ckFiltrar.Size = new System.Drawing.Size(67, 21);
            this.ckFiltrar.TabIndex = 9;
            this.ckFiltrar.Text = "Filtrar";
            this.ckFiltrar.UseVisualStyleBackColor = true;
            this.ckFiltrar.CheckedChanged += new System.EventHandler(this.ckFiltrar_CheckedChanged);
            // 
            // cbLetra
            // 
            this.cbLetra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetra.FormattingEnabled = true;
            this.cbLetra.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbLetra.Location = new System.Drawing.Point(591, 117);
            this.cbLetra.Name = "cbLetra";
            this.cbLetra.Size = new System.Drawing.Size(69, 25);
            this.cbLetra.TabIndex = 8;
            this.cbLetra.TextChanged += new System.EventHandler(this.ckLetras_CheckedChanged);
            // 
            // cbProvincia
            // 
            this.cbProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincia.FormattingEnabled = true;
            this.cbProvincia.Items.AddRange(new object[] {
            "Madrid",
            "Alicante",
            "Cantabria",
            "Barcelona",
            "Sevilla",
            "Asturias",
            "La Coruña"});
            this.cbProvincia.Location = new System.Drawing.Point(505, 43);
            this.cbProvincia.Name = "cbProvincia";
            this.cbProvincia.Size = new System.Drawing.Size(157, 25);
            this.cbProvincia.TabIndex = 7;
            this.cbProvincia.TextChanged += new System.EventHandler(this.ckFiltrar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Provincia";
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(396, 71);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(64, 24);
            this.btBuscar.TabIndex = 5;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(274, 73);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(116, 25);
            this.tbBuscar.TabIndex = 4;
            this.tbBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar nombre:";
            // 
            // tbIdSeleccion
            // 
            this.tbIdSeleccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonosBindingSource, "id", true));
            this.tbIdSeleccion.Location = new System.Drawing.Point(377, 20);
            this.tbIdSeleccion.Name = "tbIdSeleccion";
            this.tbIdSeleccion.ReadOnly = true;
            this.tbIdSeleccion.Size = new System.Drawing.Size(38, 25);
            this.tbIdSeleccion.TabIndex = 2;
            this.tbIdSeleccion.TextChanged += new System.EventHandler(this.tbIdSeleccion_TextChanged);
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
            // laIDSeleccionado
            // 
            this.laIDSeleccionado.AutoSize = true;
            this.laIDSeleccionado.Location = new System.Drawing.Point(272, 23);
            this.laIDSeleccionado.Name = "laIDSeleccionado";
            this.laIDSeleccionado.Size = new System.Drawing.Size(112, 17);
            this.laIDSeleccionado.TabIndex = 1;
            this.laIDSeleccionado.Text = "ID seleccionado";
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.ckOrdenar);
            this.gbOrdenar.Controls.Add(this.rbCodigo);
            this.gbOrdenar.Controls.Add(this.rbNombre);
            this.gbOrdenar.Location = new System.Drawing.Point(14, 27);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(233, 116);
            this.gbOrdenar.TabIndex = 0;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar por...";
            // 
            // ckOrdenar
            // 
            this.ckOrdenar.AutoSize = true;
            this.ckOrdenar.Checked = true;
            this.ckOrdenar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckOrdenar.Location = new System.Drawing.Point(61, 76);
            this.ckOrdenar.Name = "ckOrdenar";
            this.ckOrdenar.Size = new System.Drawing.Size(107, 21);
            this.ckOrdenar.TabIndex = 2;
            this.ckOrdenar.Text = "Ascendente";
            this.ckOrdenar.UseVisualStyleBackColor = true;
            this.ckOrdenar.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Location = new System.Drawing.Point(38, 49);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(93, 21);
            this.rbCodigo.TabIndex = 1;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo ID";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(38, 24);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(81, 21);
            this.rbNombre.TabIndex = 0;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.rbNombre_CheckedChanged);
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
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.telefonosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.telefonosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.telefonosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.telefonosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.telefonosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.telefonosBindingNavigator.Name = "telefonosBindingNavigator";
            this.telefonosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.telefonosBindingNavigator.Size = new System.Drawing.Size(884, 27);
            this.telefonosBindingNavigator.TabIndex = 1;
            this.telefonosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
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
            this.telefonosDataGridView.Size = new System.Drawing.Size(884, 360);
            this.telefonosDataGridView.TabIndex = 2;
            this.telefonosDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.telefonosDataGridView_ColumnHeaderMouseClick);
            this.telefonosDataGridView.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.telefonosDataGridView_DataBindingComplete);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // fmConsultasFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 568);
            this.Controls.Add(this.telefonosDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.telefonosBindingNavigator);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "fmConsultasFiltros";
            this.Text = "Consultas y filtros";
            this.Load += new System.EventHandler(this.fmConsultasFiltros_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).EndInit();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosBindingNavigator)).EndInit();
            this.telefonosBindingNavigator.ResumeLayout(false);
            this.telefonosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.telefonosDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView telefonosDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdSeleccion;
        private System.Windows.Forms.Label laIDSeleccionado;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.CheckBox ckOrdenar;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.ComboBox cbLetra;
        private System.Windows.Forms.ComboBox cbProvincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckLetras;
        private System.Windows.Forms.CheckBox ckFiltrar;
        private System.Windows.Forms.CheckBox ckCiudad;
        private System.Windows.Forms.ComboBox cbCiudad;
        private System.Windows.Forms.Label label4;
    }
}