namespace ProyectoFinal
{
    partial class frmEventos
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
            System.Windows.Forms.Label localizacionLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label resultadosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEventos));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.eventosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventosTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.EventosTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.eventosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tlblTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblNormal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcbxQueBusca = new System.Windows.Forms.ToolStripComboBox();
            this.ttxtNombreBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.localizacionTextBox = new System.Windows.Forms.TextBox();
            this.fechaTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.resultadosTextBox = new System.Windows.Forms.TextBox();
            this.eventosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            localizacionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            resultadosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingNavigator)).BeginInit();
            this.eventosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            iDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(129, 436);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(24, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(129, 462);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(54, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // localizacionLabel
            // 
            localizacionLabel.AutoSize = true;
            localizacionLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            localizacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            localizacionLabel.ForeColor = System.Drawing.Color.White;
            localizacionLabel.Location = new System.Drawing.Point(129, 488);
            localizacionLabel.Name = "localizacionLabel";
            localizacionLabel.Size = new System.Drawing.Size(82, 13);
            localizacionLabel.TabIndex = 5;
            localizacionLabel.Text = "Localizacion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.Color.White;
            fechaLabel.Location = new System.Drawing.Point(129, 514);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(46, 13);
            fechaLabel.TabIndex = 7;
            fechaLabel.Text = "Fecha:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.ForeColor = System.Drawing.Color.White;
            descripcionLabel.Location = new System.Drawing.Point(129, 540);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(78, 13);
            descripcionLabel.TabIndex = 9;
            descripcionLabel.Text = "Descripcion:";
            // 
            // resultadosLabel
            // 
            resultadosLabel.AutoSize = true;
            resultadosLabel.BackColor = System.Drawing.Color.DarkOliveGreen;
            resultadosLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            resultadosLabel.ForeColor = System.Drawing.Color.White;
            resultadosLabel.Location = new System.Drawing.Point(129, 566);
            resultadosLabel.Name = "resultadosLabel";
            resultadosLabel.Size = new System.Drawing.Size(74, 13);
            resultadosLabel.TabIndex = 11;
            resultadosLabel.Text = "Resultados:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventosBindingSource
            // 
            this.eventosBindingSource.DataMember = "Eventos";
            this.eventosBindingSource.DataSource = this.protectoraDataSet;
            // 
            // eventosTableAdapter
            // 
            this.eventosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptantesTableAdapter = null;
            this.tableAdapterManager.AfinesTableAdapter = null;
            this.tableAdapterManager.AnimalesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboradorTableAdapter = null;
            this.tableAdapterManager.ContactosTableAdapter = null;
            this.tableAdapterManager.EventosTableAdapter = this.eventosTableAdapter;
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
            // eventosBindingNavigator
            // 
            this.eventosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventosBindingNavigator.BindingSource = this.eventosBindingSource;
            this.eventosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventosBindingNavigatorSaveItem,
            this.tlblTodos,
            this.tlblNormal,
            this.toolStripSeparator1,
            this.tcbxQueBusca,
            this.ttxtNombreBuscar});
            this.eventosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventosBindingNavigator.Name = "eventosBindingNavigator";
            this.eventosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventosBindingNavigator.Size = new System.Drawing.Size(560, 25);
            this.eventosBindingNavigator.TabIndex = 0;
            this.eventosBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(30, 21);
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
            // eventosBindingNavigatorSaveItem
            // 
            this.eventosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.eventosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("eventosBindingNavigatorSaveItem.Image")));
            this.eventosBindingNavigatorSaveItem.Name = "eventosBindingNavigatorSaveItem";
            this.eventosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.eventosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.eventosBindingNavigatorSaveItem.Click += new System.EventHandler(this.eventosBindingNavigatorSaveItem_Click);
            // 
            // tlblTodos
            // 
            this.tlblTodos.Name = "tlblTodos";
            this.tlblTodos.Size = new System.Drawing.Size(55, 22);
            this.tlblTodos.Text = "Ver Todos";
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
            // tcbxQueBusca
            // 
            this.tcbxQueBusca.Items.AddRange(new object[] {
            "ID",
            "Nombre",
            "Localizacion",
            "Fecha",
            "Descripcion",
            "Resultados"});
            this.tcbxQueBusca.Name = "tcbxQueBusca";
            this.tcbxQueBusca.Size = new System.Drawing.Size(121, 25);
            this.tcbxQueBusca.Visible = false;
            // 
            // ttxtNombreBuscar
            // 
            this.ttxtNombreBuscar.Name = "ttxtNombreBuscar";
            this.ttxtNombreBuscar.Size = new System.Drawing.Size(100, 21);
            this.ttxtNombreBuscar.Visible = false;
            this.ttxtNombreBuscar.Click += new System.EventHandler(this.ttxtNombreBuscar_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(229, 433);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(307, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(229, 459);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(307, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // localizacionTextBox
            // 
            this.localizacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "Localizacion", true));
            this.localizacionTextBox.Location = new System.Drawing.Point(229, 485);
            this.localizacionTextBox.Name = "localizacionTextBox";
            this.localizacionTextBox.Size = new System.Drawing.Size(307, 20);
            this.localizacionTextBox.TabIndex = 6;
            // 
            // fechaTextBox
            // 
            this.fechaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "Fecha", true));
            this.fechaTextBox.Location = new System.Drawing.Point(229, 511);
            this.fechaTextBox.Name = "fechaTextBox";
            this.fechaTextBox.Size = new System.Drawing.Size(307, 20);
            this.fechaTextBox.TabIndex = 8;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(229, 537);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(307, 20);
            this.descripcionTextBox.TabIndex = 10;
            // 
            // resultadosTextBox
            // 
            this.resultadosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventosBindingSource, "Resultados", true));
            this.resultadosTextBox.Location = new System.Drawing.Point(229, 563);
            this.resultadosTextBox.Name = "resultadosTextBox";
            this.resultadosTextBox.Size = new System.Drawing.Size(307, 20);
            this.resultadosTextBox.TabIndex = 12;
            // 
            // eventosDataGridView
            // 
            this.eventosDataGridView.AutoGenerateColumns = false;
            this.eventosDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.eventosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.eventosDataGridView.DataSource = this.eventosBindingSource;
            this.eventosDataGridView.Location = new System.Drawing.Point(4, 78);
            this.eventosDataGridView.Name = "eventosDataGridView";
            this.eventosDataGridView.RowHeadersVisible = false;
            this.eventosDataGridView.Size = new System.Drawing.Size(553, 522);
            this.eventosDataGridView.TabIndex = 13;
            this.eventosDataGridView.Visible = false;
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
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Localizacion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Localizacion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn5.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Resultados";
            this.dataGridViewTextBoxColumn6.HeaderText = "Resultados";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.p2;
            this.ClientSize = new System.Drawing.Size(560, 580);
            this.Controls.Add(this.eventosDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(localizacionLabel);
            this.Controls.Add(this.localizacionTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(resultadosLabel);
            this.Controls.Add(this.resultadosTextBox);
            this.Controls.Add(this.eventosBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmEventos";
            this.ShowIcon = false;
            this.Text = "Eventos";
            this.Load += new System.EventHandler(this.frmEventos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventosBindingNavigator)).EndInit();
            this.eventosBindingNavigator.ResumeLayout(false);
            this.eventosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource eventosBindingSource;
        private protectoraDataSetTableAdapters.EventosTableAdapter eventosTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator eventosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton eventosBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox localizacionTextBox;
        private System.Windows.Forms.TextBox fechaTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox resultadosTextBox;
        private System.Windows.Forms.ToolStripLabel tlblTodos;
        private System.Windows.Forms.ToolStripLabel tlblNormal;
        private System.Windows.Forms.DataGridView eventosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tcbxQueBusca;
        private System.Windows.Forms.ToolStripTextBox ttxtNombreBuscar;
    }
}