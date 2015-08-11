namespace ProyectoFinal
{
    partial class frmAnimales
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label razaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label edadLabel;
            System.Windows.Forms.Label localizacionLabel;
            System.Windows.Forms.Label vacunas_recibidasLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimales));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.animalesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.AnimalesTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.animalesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.animalesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.razaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.localizacionTextBox = new System.Windows.Forms.TextBox();
            this.vacunas_recibidasTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlLesiones = new System.Windows.Forms.Panel();
            this.lesionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lesionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lesionTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.LesionTableAdapter();
            this.pnlMateriales = new System.Windows.Forms.Panel();
            this.materialesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.MaterialesTableAdapter();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.lblContra = new System.Windows.Forms.Label();
            this.mtxyContrasena = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtAsunto = new System.Windows.Forms.TextBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblAsunto = new System.Windows.Forms.Label();
            this.lblDestinatarios = new System.Windows.Forms.Label();
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            razaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            localizacionLabel = new System.Windows.Forms.Label();
            vacunas_recibidasLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingNavigator)).BeginInit();
            this.animalesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlLesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lesionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesionBindingSource)).BeginInit();
            this.pnlMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingSource)).BeginInit();
            this.pnlEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.Location = new System.Drawing.Point(101, 186);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.Location = new System.Drawing.Point(101, 212);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(31, 13);
            tipoLabel.TabIndex = 3;
            tipoLabel.Text = "Tipo:";
            // 
            // razaLabel
            // 
            razaLabel.AutoSize = true;
            razaLabel.BackColor = System.Drawing.Color.Transparent;
            razaLabel.Location = new System.Drawing.Point(101, 238);
            razaLabel.Name = "razaLabel";
            razaLabel.Size = new System.Drawing.Size(35, 13);
            razaLabel.TabIndex = 5;
            razaLabel.Text = "Raza:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(101, 264);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 7;
            nombreLabel.Text = "Nombre:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.BackColor = System.Drawing.Color.Transparent;
            edadLabel.Location = new System.Drawing.Point(101, 290);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 9;
            edadLabel.Text = "Edad:";
            // 
            // localizacionLabel
            // 
            localizacionLabel.AutoSize = true;
            localizacionLabel.BackColor = System.Drawing.Color.Transparent;
            localizacionLabel.Location = new System.Drawing.Point(101, 316);
            localizacionLabel.Name = "localizacionLabel";
            localizacionLabel.Size = new System.Drawing.Size(69, 13);
            localizacionLabel.TabIndex = 11;
            localizacionLabel.Text = "Localizacion:";
            // 
            // vacunas_recibidasLabel
            // 
            vacunas_recibidasLabel.AutoSize = true;
            vacunas_recibidasLabel.BackColor = System.Drawing.Color.Transparent;
            vacunas_recibidasLabel.Location = new System.Drawing.Point(101, 342);
            vacunas_recibidasLabel.Name = "vacunas_recibidasLabel";
            vacunas_recibidasLabel.Size = new System.Drawing.Size(97, 13);
            vacunas_recibidasLabel.TabIndex = 13;
            vacunas_recibidasLabel.Text = "Vacunas recibidas:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalesBindingSource
            // 
            this.animalesBindingSource.DataMember = "Animales";
            this.animalesBindingSource.DataSource = this.protectoraDataSet;
            // 
            // animalesTableAdapter
            // 
            this.animalesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptantesTableAdapter = null;
            this.tableAdapterManager.AfinesTableAdapter = null;
            this.tableAdapterManager.AnimalesTableAdapter = this.animalesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboradorTableAdapter = null;
            this.tableAdapterManager.ContactosTableAdapter = null;
            this.tableAdapterManager.EventosTableAdapter = null;
            this.tableAdapterManager.LesionTableAdapter = null;
            this.tableAdapterManager.MaterialesTableAdapter = null;
            this.tableAdapterManager.PadrinosTableAdapter = null;
            this.tableAdapterManager.ParticularesTableAdapter = null;
            this.tableAdapterManager.PaseadorTableAdapter = null;
            this.tableAdapterManager.ProcedenciaTableAdapter = null;
            this.tableAdapterManager.ProtectoraTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunasTableAdapter = null;
            this.tableAdapterManager.VoluntarioTableAdapter = null;
            // 
            // animalesBindingNavigator
            // 
            this.animalesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animalesBindingNavigator.BindingSource = this.animalesBindingSource;
            this.animalesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animalesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalesBindingNavigatorSaveItem,
            this.toolStripSeparator1});
            this.animalesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalesBindingNavigator.Name = "animalesBindingNavigator";
            this.animalesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalesBindingNavigator.Size = new System.Drawing.Size(493, 25);
            this.animalesBindingNavigator.TabIndex = 0;
            this.animalesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(38, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // animalesBindingNavigatorSaveItem
            // 
            this.animalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalesBindingNavigatorSaveItem.Image")));
            this.animalesBindingNavigatorSaveItem.Name = "animalesBindingNavigatorSaveItem";
            this.animalesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.animalesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.animalesBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalesBindingNavigatorSaveItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(204, 183);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(238, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalesBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(204, 209);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(238, 20);
            this.tipoTextBox.TabIndex = 4;
            // 
            // razaTextBox
            // 
            this.razaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalesBindingSource, "Raza", true));
            this.razaTextBox.Location = new System.Drawing.Point(204, 235);
            this.razaTextBox.Name = "razaTextBox";
            this.razaTextBox.Size = new System.Drawing.Size(238, 20);
            this.razaTextBox.TabIndex = 6;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(204, 261);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(238, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalesBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(204, 287);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(238, 20);
            this.edadTextBox.TabIndex = 10;
            // 
            // localizacionTextBox
            // 
            this.localizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalesBindingSource, "Localizacion", true));
            this.localizacionTextBox.Location = new System.Drawing.Point(204, 313);
            this.localizacionTextBox.Name = "localizacionTextBox";
            this.localizacionTextBox.Size = new System.Drawing.Size(238, 20);
            this.localizacionTextBox.TabIndex = 12;
            // 
            // vacunas_recibidasTextBox
            // 
            this.vacunas_recibidasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalesBindingSource, "Vacunas recibidas", true));
            this.vacunas_recibidasTextBox.Location = new System.Drawing.Point(204, 339);
            this.vacunas_recibidasTextBox.Name = "vacunas_recibidasTextBox";
            this.vacunas_recibidasTextBox.Size = new System.Drawing.Size(238, 20);
            this.vacunas_recibidasTextBox.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.datosanimales;
            this.pictureBox1.Location = new System.Drawing.Point(69, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pnlLesiones
            // 
            this.pnlLesiones.BackColor = System.Drawing.Color.Transparent;
            this.pnlLesiones.Controls.Add(this.lesionDataGridView);
            this.pnlLesiones.Location = new System.Drawing.Point(464, 163);
            this.pnlLesiones.Name = "pnlLesiones";
            this.pnlLesiones.Size = new System.Drawing.Size(423, 286);
            this.pnlLesiones.TabIndex = 17;
            // 
            // lesionDataGridView
            // 
            this.lesionDataGridView.AutoGenerateColumns = false;
            this.lesionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lesionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3});
            this.lesionDataGridView.DataSource = this.lesionBindingSource;
            this.lesionDataGridView.Location = new System.Drawing.Point(60, 27);
            this.lesionDataGridView.Name = "lesionDataGridView";
            this.lesionDataGridView.ReadOnly = true;
            this.lesionDataGridView.RowHeadersVisible = false;
            this.lesionDataGridView.Size = new System.Drawing.Size(306, 197);
            this.lesionDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lesion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lesion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // lesionBindingSource
            // 
            this.lesionBindingSource.DataMember = "AnimalesLesion";
            this.lesionBindingSource.DataSource = this.animalesBindingSource;
            // 
            // lesionTableAdapter
            // 
            this.lesionTableAdapter.ClearBeforeFill = true;
            // 
            // pnlMateriales
            // 
            this.pnlMateriales.BackColor = System.Drawing.Color.Transparent;
            this.pnlMateriales.Controls.Add(this.materialesDataGridView);
            this.pnlMateriales.Location = new System.Drawing.Point(498, 136);
            this.pnlMateriales.Name = "pnlMateriales";
            this.pnlMateriales.Size = new System.Drawing.Size(389, 286);
            this.pnlMateriales.TabIndex = 20;
            // 
            // materialesDataGridView
            // 
            this.materialesDataGridView.AutoGenerateColumns = false;
            this.materialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.materialesDataGridView.DataSource = this.materialesBindingSource;
            this.materialesDataGridView.Location = new System.Drawing.Point(20, 47);
            this.materialesDataGridView.Name = "materialesDataGridView";
            this.materialesDataGridView.ReadOnly = true;
            this.materialesDataGridView.RowHeadersVisible = false;
            this.materialesDataGridView.Size = new System.Drawing.Size(357, 184);
            this.materialesDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Funciones";
            this.dataGridViewTextBoxColumn6.HeaderText = "Funciones";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // materialesBindingSource
            // 
            this.materialesBindingSource.DataMember = "AnimalesMateriales";
            this.materialesBindingSource.DataSource = this.animalesBindingSource;
            // 
            // materialesTableAdapter
            // 
            this.materialesTableAdapter.ClearBeforeFill = true;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackColor = System.Drawing.Color.Transparent;
            this.pnlEmail.Controls.Add(this.lblContra);
            this.pnlEmail.Controls.Add(this.mtxyContrasena);
            this.pnlEmail.Controls.Add(this.btnCancelar);
            this.pnlEmail.Controls.Add(this.lblRemitente);
            this.pnlEmail.Controls.Add(this.txtRemitente);
            this.pnlEmail.Controls.Add(this.btnEnviar);
            this.pnlEmail.Controls.Add(this.txtTexto);
            this.pnlEmail.Controls.Add(this.txtAsunto);
            this.pnlEmail.Controls.Add(this.txtDestinatario);
            this.pnlEmail.Controls.Add(this.lblTexto);
            this.pnlEmail.Controls.Add(this.lblAsunto);
            this.pnlEmail.Controls.Add(this.lblDestinatarios);
            this.pnlEmail.Location = new System.Drawing.Point(518, 85);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(346, 350);
            this.pnlEmail.TabIndex = 24;
            this.pnlEmail.Visible = false;
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(14, 51);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(61, 13);
            this.lblContra.TabIndex = 20;
            this.lblContra.Text = "Contraseña";
            // 
            // mtxyContrasena
            // 
            this.mtxyContrasena.Location = new System.Drawing.Point(92, 44);
            this.mtxyContrasena.Name = "mtxyContrasena";
            this.mtxyContrasena.Size = new System.Drawing.Size(236, 20);
            this.mtxyContrasena.TabIndex = 19;
            this.mtxyContrasena.UseSystemPasswordChar = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(18, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblRemitente
            // 
            this.lblRemitente.AutoSize = true;
            this.lblRemitente.Location = new System.Drawing.Point(14, 24);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(55, 13);
            this.lblRemitente.TabIndex = 17;
            this.lblRemitente.Text = "Remitente";
            // 
            // txtRemitente
            // 
            this.txtRemitente.Location = new System.Drawing.Point(92, 18);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.Size = new System.Drawing.Size(236, 20);
            this.txtRemitente.TabIndex = 16;
            this.txtRemitente.Text = "Necesario que sea de cuenta gmail";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(253, 314);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 15;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(18, 157);
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(310, 136);
            this.txtTexto.TabIndex = 14;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(92, 107);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Size = new System.Drawing.Size(236, 20);
            this.txtAsunto.TabIndex = 13;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Location = new System.Drawing.Point(92, 74);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(236, 20);
            this.txtDestinatario.TabIndex = 12;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(15, 135);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(34, 13);
            this.lblTexto.TabIndex = 11;
            this.lblTexto.Text = "Texto";
            // 
            // lblAsunto
            // 
            this.lblAsunto.AutoSize = true;
            this.lblAsunto.Location = new System.Drawing.Point(17, 106);
            this.lblAsunto.Name = "lblAsunto";
            this.lblAsunto.Size = new System.Drawing.Size(40, 13);
            this.lblAsunto.TabIndex = 10;
            this.lblAsunto.Text = "Asunto";
            // 
            // lblDestinatarios
            // 
            this.lblDestinatarios.AutoSize = true;
            this.lblDestinatarios.Location = new System.Drawing.Point(15, 77);
            this.lblDestinatarios.Name = "lblDestinatarios";
            this.lblDestinatarios.Size = new System.Drawing.Size(68, 13);
            this.lblDestinatarios.TabIndex = 9;
            this.lblDestinatarios.Text = "Destinatarios";
            // 
            // cbxMenu
            // 
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Items.AddRange(new object[] {
            "Vista Normal",
            "Ver Todos los Animales",
            "Ver Materiales",
            "Ver Lesiones",
            "Crear Documento Word",
            "Enviar Email"});
            this.cbxMenu.Location = new System.Drawing.Point(204, 380);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(121, 21);
            this.cbxMenu.TabIndex = 25;
            this.cbxMenu.Text = "Vista Normal";
            this.cbxMenu.SelectedIndexChanged += new System.EventHandler(this.cbxMenu_SelectedIndexChanged);
            // 
            // frmAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.papel2;
            this.ClientSize = new System.Drawing.Size(493, 449);
            this.Controls.Add(this.cbxMenu);
            this.Controls.Add(this.pnlEmail);
            this.Controls.Add(this.pnlMateriales);
            this.Controls.Add(this.pnlLesiones);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(razaLabel);
            this.Controls.Add(this.razaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(localizacionLabel);
            this.Controls.Add(this.localizacionTextBox);
            this.Controls.Add(vacunas_recibidasLabel);
            this.Controls.Add(this.vacunas_recibidasTextBox);
            this.Controls.Add(this.animalesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAnimales";
            this.ShowIcon = false;
            this.Text = "Animales";
            this.Load += new System.EventHandler(this.frmAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingNavigator)).EndInit();
            this.animalesBindingNavigator.ResumeLayout(false);
            this.animalesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlLesiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lesionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesionBindingSource)).EndInit();
            this.pnlMateriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingSource)).EndInit();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource animalesBindingSource;
        private protectoraDataSetTableAdapters.AnimalesTableAdapter animalesTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animalesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox razaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.TextBox localizacionTextBox;
        private System.Windows.Forms.TextBox vacunas_recibidasTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlLesiones;
        private System.Windows.Forms.BindingSource lesionBindingSource;
        private protectoraDataSetTableAdapters.LesionTableAdapter lesionTableAdapter;
        private System.Windows.Forms.DataGridView lesionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel pnlMateriales;
        private System.Windows.Forms.BindingSource materialesBindingSource;
        private protectoraDataSetTableAdapters.MaterialesTableAdapter materialesTableAdapter;
        private System.Windows.Forms.DataGridView materialesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtAsunto;
        private System.Windows.Forms.TextBox txtDestinatario;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblAsunto;
        private System.Windows.Forms.Label lblDestinatarios;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.MaskedTextBox mtxyContrasena;
        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}