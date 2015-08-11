namespace ProyectoFinal
{
    partial class frmContactos
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label paginaWebLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label localizacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContactos));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.ContactosTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.contactosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.contactosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tlblTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblNormal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcbxEleccion = new System.Windows.Forms.ToolStripComboBox();
            this.ttxtOpcion = new System.Windows.Forms.ToolStripTextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.paginaWebTextBox = new System.Windows.Forms.TextBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.localizacionTextBox = new System.Windows.Forms.TextBox();
            this.contactosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            paginaWebLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            localizacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingNavigator)).BeginInit();
            this.contactosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(25, 265);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(25, 291);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel.ForeColor = System.Drawing.Color.White;
            telefonoLabel.Location = new System.Drawing.Point(25, 317);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 5;
            telefonoLabel.Text = "Telefono:";
            // 
            // paginaWebLabel
            // 
            paginaWebLabel.AutoSize = true;
            paginaWebLabel.BackColor = System.Drawing.Color.Transparent;
            paginaWebLabel.ForeColor = System.Drawing.Color.White;
            paginaWebLabel.Location = new System.Drawing.Point(25, 343);
            paginaWebLabel.Name = "paginaWebLabel";
            paginaWebLabel.Size = new System.Drawing.Size(69, 13);
            paginaWebLabel.TabIndex = 7;
            paginaWebLabel.Text = "Pagina Web:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.BackColor = System.Drawing.Color.Transparent;
            correoElectronicoLabel.ForeColor = System.Drawing.Color.White;
            correoElectronicoLabel.Location = new System.Drawing.Point(25, 369);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(97, 13);
            correoElectronicoLabel.TabIndex = 9;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.ForeColor = System.Drawing.Color.White;
            descripcionLabel.Location = new System.Drawing.Point(25, 395);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 11;
            descripcionLabel.Text = "Descripcion:";
            // 
            // localizacionLabel
            // 
            localizacionLabel.AutoSize = true;
            localizacionLabel.BackColor = System.Drawing.Color.Transparent;
            localizacionLabel.ForeColor = System.Drawing.Color.White;
            localizacionLabel.Location = new System.Drawing.Point(25, 421);
            localizacionLabel.Name = "localizacionLabel";
            localizacionLabel.Size = new System.Drawing.Size(69, 13);
            localizacionLabel.TabIndex = 13;
            localizacionLabel.Text = "Localizacion:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosBindingSource
            // 
            this.contactosBindingSource.DataMember = "Contactos";
            this.contactosBindingSource.DataSource = this.protectoraDataSet;
            // 
            // contactosTableAdapter
            // 
            this.contactosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptantesTableAdapter = null;
            this.tableAdapterManager.AfinesTableAdapter = null;
            this.tableAdapterManager.AnimalesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboradorTableAdapter = null;
            this.tableAdapterManager.ContactosTableAdapter = this.contactosTableAdapter;
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
            // contactosBindingNavigator
            // 
            this.contactosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.contactosBindingNavigator.BindingSource = this.contactosBindingSource;
            this.contactosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.contactosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.contactosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.contactosBindingNavigatorSaveItem,
            this.tlblTodos,
            this.tlblNormal,
            this.toolStripSeparator1,
            this.tcbxEleccion,
            this.ttxtOpcion});
            this.contactosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.contactosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.contactosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.contactosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.contactosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.contactosBindingNavigator.Name = "contactosBindingNavigator";
            this.contactosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.contactosBindingNavigator.Size = new System.Drawing.Size(994, 25);
            this.contactosBindingNavigator.TabIndex = 0;
            this.contactosBindingNavigator.Text = "bindingNavigator1";
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
            // contactosBindingNavigatorSaveItem
            // 
            this.contactosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.contactosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("contactosBindingNavigatorSaveItem.Image")));
            this.contactosBindingNavigatorSaveItem.Name = "contactosBindingNavigatorSaveItem";
            this.contactosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.contactosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.contactosBindingNavigatorSaveItem.Click += new System.EventHandler(this.contactosBindingNavigatorSaveItem_Click);
            // 
            // tlblTodos
            // 
            this.tlblTodos.Name = "tlblTodos";
            this.tlblTodos.Size = new System.Drawing.Size(123, 22);
            this.tlblTodos.Text = "Ver Todos los Contactos";
            this.tlblTodos.Click += new System.EventHandler(this.tlblTodos_Click);
            // 
            // tlblNormal
            // 
            this.tlblNormal.Name = "tlblNormal";
            this.tlblNormal.Size = new System.Drawing.Size(59, 22);
            this.tlblNormal.Text = "Ver Normal";
            this.tlblNormal.Visible = false;
            this.tlblNormal.Click += new System.EventHandler(this.tlblNormal_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tcbxEleccion
            // 
            this.tcbxEleccion.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Telefono",
            "PaginaWeb",
            "CorreoElectronico",
            "Descripcion",
            "Localizacion"});
            this.tcbxEleccion.Name = "tcbxEleccion";
            this.tcbxEleccion.Size = new System.Drawing.Size(121, 25);
            this.tcbxEleccion.Visible = false;
            // 
            // ttxtOpcion
            // 
            this.ttxtOpcion.Name = "ttxtOpcion";
            this.ttxtOpcion.Size = new System.Drawing.Size(100, 25);
            this.ttxtOpcion.Visible = false;
            this.ttxtOpcion.Click += new System.EventHandler(this.ttxtOpcion_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(128, 262);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(108, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(128, 288);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(381, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(128, 314);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(381, 20);
            this.telefonoTextBox.TabIndex = 6;
            // 
            // paginaWebTextBox
            // 
            this.paginaWebTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "PaginaWeb", true));
            this.paginaWebTextBox.Location = new System.Drawing.Point(128, 340);
            this.paginaWebTextBox.Name = "paginaWebTextBox";
            this.paginaWebTextBox.Size = new System.Drawing.Size(381, 20);
            this.paginaWebTextBox.TabIndex = 8;
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(128, 366);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(381, 20);
            this.correoElectronicoTextBox.TabIndex = 10;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(128, 392);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(381, 20);
            this.descripcionTextBox.TabIndex = 12;
            // 
            // localizacionTextBox
            // 
            this.localizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "Localizacion", true));
            this.localizacionTextBox.Location = new System.Drawing.Point(128, 418);
            this.localizacionTextBox.Name = "localizacionTextBox";
            this.localizacionTextBox.Size = new System.Drawing.Size(381, 20);
            this.localizacionTextBox.TabIndex = 14;
            // 
            // contactosDataGridView
            // 
            this.contactosDataGridView.AutoGenerateColumns = false;
            this.contactosDataGridView.BackgroundColor = System.Drawing.Color.DarkCyan;
            this.contactosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.contactosDataGridView.DataSource = this.contactosBindingSource;
            this.contactosDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.contactosDataGridView.Location = new System.Drawing.Point(28, 84);
            this.contactosDataGridView.Name = "contactosDataGridView";
            this.contactosDataGridView.RowHeadersVisible = false;
            this.contactosDataGridView.Size = new System.Drawing.Size(943, 367);
            this.contactosDataGridView.TabIndex = 15;
            this.contactosDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn3.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PaginaWeb";
            this.dataGridViewTextBoxColumn4.HeaderText = "PaginaWeb";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CorreoElectronico";
            this.dataGridViewTextBoxColumn5.HeaderText = "CorreoElectronico";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 200;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Localizacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "Localizacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 180;
            // 
            // frmContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.tierra;
            this.ClientSize = new System.Drawing.Size(994, 487);
            this.Controls.Add(this.contactosDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(paginaWebLabel);
            this.Controls.Add(this.paginaWebTextBox);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(localizacionLabel);
            this.Controls.Add(this.localizacionTextBox);
            this.Controls.Add(this.contactosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmContactos";
            this.ShowIcon = false;
            this.Text = "Contactos";
            this.Load += new System.EventHandler(this.frmContactos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingNavigator)).EndInit();
            this.contactosBindingNavigator.ResumeLayout(false);
            this.contactosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource contactosBindingSource;
        private protectoraDataSetTableAdapters.ContactosTableAdapter contactosTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator contactosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton contactosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox paginaWebTextBox;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox localizacionTextBox;
        private System.Windows.Forms.ToolStripLabel tlblTodos;
        private System.Windows.Forms.ToolStripLabel tlblNormal;
        private System.Windows.Forms.DataGridView contactosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tcbxEleccion;
        private System.Windows.Forms.ToolStripTextBox ttxtOpcion;
    }
}