namespace ProyectoFinal
{
    partial class frmColaborador
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
            System.Windows.Forms.Label afinesLabel;
            System.Windows.Forms.Label tipoColaboracionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColaborador));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colaboradorTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.ColaboradorTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.colaboradorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.colaboradorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.afinesTextBox = new System.Windows.Forms.TextBox();
            this.tipoColaboracionTextBox = new System.Windows.Forms.TextBox();
            this.tlblVerTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblVerNormal = new System.Windows.Forms.ToolStripLabel();
            this.colaboradorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            afinesLabel = new System.Windows.Forms.Label();
            tipoColaboracionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingNavigator)).BeginInit();
            this.colaboradorBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(29, 423);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // afinesLabel
            // 
            afinesLabel.AutoSize = true;
            afinesLabel.BackColor = System.Drawing.Color.Transparent;
            afinesLabel.ForeColor = System.Drawing.Color.White;
            afinesLabel.Location = new System.Drawing.Point(29, 449);
            afinesLabel.Name = "afinesLabel";
            afinesLabel.Size = new System.Drawing.Size(39, 13);
            afinesLabel.TabIndex = 3;
            afinesLabel.Text = "Afines:";
            // 
            // tipoColaboracionLabel
            // 
            tipoColaboracionLabel.AutoSize = true;
            tipoColaboracionLabel.BackColor = System.Drawing.Color.Transparent;
            tipoColaboracionLabel.ForeColor = System.Drawing.Color.White;
            tipoColaboracionLabel.Location = new System.Drawing.Point(29, 475);
            tipoColaboracionLabel.Name = "tipoColaboracionLabel";
            tipoColaboracionLabel.Size = new System.Drawing.Size(96, 13);
            tipoColaboracionLabel.TabIndex = 5;
            tipoColaboracionLabel.Text = "Tipo Colaboracion:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colaboradorBindingSource
            // 
            this.colaboradorBindingSource.DataMember = "Colaborador";
            this.colaboradorBindingSource.DataSource = this.protectoraDataSet;
            // 
            // colaboradorTableAdapter
            // 
            this.colaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptantesTableAdapter = null;
            this.tableAdapterManager.AfinesTableAdapter = null;
            this.tableAdapterManager.AnimalesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboradorTableAdapter = this.colaboradorTableAdapter;
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
            // colaboradorBindingNavigator
            // 
            this.colaboradorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.colaboradorBindingNavigator.BindingSource = this.colaboradorBindingSource;
            this.colaboradorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.colaboradorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.colaboradorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.colaboradorBindingNavigatorSaveItem,
            this.tlblVerTodos,
            this.tlblVerNormal});
            this.colaboradorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.colaboradorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.colaboradorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.colaboradorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.colaboradorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.colaboradorBindingNavigator.Name = "colaboradorBindingNavigator";
            this.colaboradorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.colaboradorBindingNavigator.Size = new System.Drawing.Size(814, 25);
            this.colaboradorBindingNavigator.TabIndex = 0;
            this.colaboradorBindingNavigator.Text = "bindingNavigator1";
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
            // colaboradorBindingNavigatorSaveItem
            // 
            this.colaboradorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colaboradorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("colaboradorBindingNavigatorSaveItem.Image")));
            this.colaboradorBindingNavigatorSaveItem.Name = "colaboradorBindingNavigatorSaveItem";
            this.colaboradorBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.colaboradorBindingNavigatorSaveItem.Text = "Guardar datos";
            this.colaboradorBindingNavigatorSaveItem.Click += new System.EventHandler(this.colaboradorBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(131, 420);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(204, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // afinesTextBox
            // 
            this.afinesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "Afines", true));
            this.afinesTextBox.Location = new System.Drawing.Point(131, 446);
            this.afinesTextBox.Name = "afinesTextBox";
            this.afinesTextBox.Size = new System.Drawing.Size(204, 20);
            this.afinesTextBox.TabIndex = 4;
            // 
            // tipoColaboracionTextBox
            // 
            this.tipoColaboracionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "TipoColaboracion", true));
            this.tipoColaboracionTextBox.Location = new System.Drawing.Point(131, 472);
            this.tipoColaboracionTextBox.Name = "tipoColaboracionTextBox";
            this.tipoColaboracionTextBox.Size = new System.Drawing.Size(204, 20);
            this.tipoColaboracionTextBox.TabIndex = 6;
            // 
            // tlblVerTodos
            // 
            this.tlblVerTodos.Name = "tlblVerTodos";
            this.tlblVerTodos.Size = new System.Drawing.Size(55, 22);
            this.tlblVerTodos.Text = "Ver Todos";
            this.tlblVerTodos.Click += new System.EventHandler(this.tlblVerTodos_Click);
            // 
            // tlblVerNormal
            // 
            this.tlblVerNormal.Name = "tlblVerNormal";
            this.tlblVerNormal.Size = new System.Drawing.Size(59, 22);
            this.tlblVerNormal.Text = "Ver Normal";
            this.tlblVerNormal.Visible = false;
            this.tlblVerNormal.Click += new System.EventHandler(this.tlblVerNormal_Click);
            // 
            // colaboradorDataGridView
            // 
            this.colaboradorDataGridView.AutoGenerateColumns = false;
            this.colaboradorDataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            this.colaboradorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.colaboradorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.colaboradorDataGridView.DataSource = this.colaboradorBindingSource;
            this.colaboradorDataGridView.Location = new System.Drawing.Point(32, 76);
            this.colaboradorDataGridView.Name = "colaboradorDataGridView";
            this.colaboradorDataGridView.RowHeadersVisible = false;
            this.colaboradorDataGridView.Size = new System.Drawing.Size(506, 427);
            this.colaboradorDataGridView.TabIndex = 7;
            this.colaboradorDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Afines";
            this.dataGridViewTextBoxColumn2.HeaderText = "Afines";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TipoColaboracion";
            this.dataGridViewTextBoxColumn3.HeaderText = "TipoColaboracion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // frmColaborador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.casa2;
            this.ClientSize = new System.Drawing.Size(814, 541);
            this.Controls.Add(this.colaboradorDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(afinesLabel);
            this.Controls.Add(this.afinesTextBox);
            this.Controls.Add(tipoColaboracionLabel);
            this.Controls.Add(this.tipoColaboracionTextBox);
            this.Controls.Add(this.colaboradorBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmColaborador";
            this.ShowIcon = false;
            this.Text = "Colaboradores";
            this.Load += new System.EventHandler(this.frmColaborador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingNavigator)).EndInit();
            this.colaboradorBindingNavigator.ResumeLayout(false);
            this.colaboradorBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private protectoraDataSetTableAdapters.ColaboradorTableAdapter colaboradorTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator colaboradorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton colaboradorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox afinesTextBox;
        private System.Windows.Forms.TextBox tipoColaboracionTextBox;
        private System.Windows.Forms.ToolStripLabel tlblVerTodos;
        private System.Windows.Forms.ToolStripLabel tlblVerNormal;
        private System.Windows.Forms.DataGridView colaboradorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}