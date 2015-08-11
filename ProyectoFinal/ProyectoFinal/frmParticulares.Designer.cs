namespace ProyectoFinal
{
    partial class frmParticulares
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
            System.Windows.Forms.Label descripcionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParticulares));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.particularesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.particularesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.ParticularesTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.particularesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.particularesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.afinesTextBox = new System.Windows.Forms.TextBox();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.particularesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlblVerTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblVerNormal = new System.Windows.Forms.ToolStripLabel();
            iDLabel = new System.Windows.Forms.Label();
            afinesLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularesBindingNavigator)).BeginInit();
            this.particularesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.particularesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(56, 475);
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
            afinesLabel.Location = new System.Drawing.Point(56, 501);
            afinesLabel.Name = "afinesLabel";
            afinesLabel.Size = new System.Drawing.Size(39, 13);
            afinesLabel.TabIndex = 3;
            afinesLabel.Text = "Afines:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.ForeColor = System.Drawing.Color.White;
            descripcionLabel.Location = new System.Drawing.Point(56, 527);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 5;
            descripcionLabel.Text = "Descripcion:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // particularesBindingSource
            // 
            this.particularesBindingSource.DataMember = "Particulares";
            this.particularesBindingSource.DataSource = this.protectoraDataSet;
            // 
            // particularesTableAdapter
            // 
            this.particularesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptantesTableAdapter = null;
            this.tableAdapterManager.AfinesTableAdapter = null;
            this.tableAdapterManager.AnimalesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboradorTableAdapter = null;
            this.tableAdapterManager.ContactosTableAdapter = null;
            this.tableAdapterManager.EventosTableAdapter = null;
            this.tableAdapterManager.LesionTableAdapter = null;
            this.tableAdapterManager.MaterialesTableAdapter = null;
            this.tableAdapterManager.PadrinosTableAdapter = null;
            this.tableAdapterManager.ParticularesTableAdapter = this.particularesTableAdapter;
            this.tableAdapterManager.PaseadorTableAdapter = null;
            this.tableAdapterManager.ProcedenciaTableAdapter = null;
            this.tableAdapterManager.ProtectoraTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunasTableAdapter = null;
            this.tableAdapterManager.VoluntarioTableAdapter = null;
            // 
            // particularesBindingNavigator
            // 
            this.particularesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.particularesBindingNavigator.BindingSource = this.particularesBindingSource;
            this.particularesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.particularesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.particularesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.particularesBindingNavigatorSaveItem,
            this.tlblVerTodos,
            this.tlblVerNormal});
            this.particularesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.particularesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.particularesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.particularesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.particularesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.particularesBindingNavigator.Name = "particularesBindingNavigator";
            this.particularesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.particularesBindingNavigator.Size = new System.Drawing.Size(764, 25);
            this.particularesBindingNavigator.TabIndex = 0;
            this.particularesBindingNavigator.Text = "bindingNavigator1";
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
            // particularesBindingNavigatorSaveItem
            // 
            this.particularesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.particularesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("particularesBindingNavigatorSaveItem.Image")));
            this.particularesBindingNavigatorSaveItem.Name = "particularesBindingNavigatorSaveItem";
            this.particularesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.particularesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.particularesBindingNavigatorSaveItem.Click += new System.EventHandler(this.particularesBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.particularesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(128, 472);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(107, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // afinesTextBox
            // 
            this.afinesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.particularesBindingSource, "Afines", true));
            this.afinesTextBox.Location = new System.Drawing.Point(128, 498);
            this.afinesTextBox.Name = "afinesTextBox";
            this.afinesTextBox.Size = new System.Drawing.Size(213, 20);
            this.afinesTextBox.TabIndex = 4;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.particularesBindingSource, "Descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(128, 524);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(213, 20);
            this.descripcionTextBox.TabIndex = 6;
            // 
            // particularesDataGridView
            // 
            this.particularesDataGridView.AutoGenerateColumns = false;
            this.particularesDataGridView.BackgroundColor = System.Drawing.Color.SlateGray;
            this.particularesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.particularesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.particularesDataGridView.DataSource = this.particularesBindingSource;
            this.particularesDataGridView.Location = new System.Drawing.Point(59, 164);
            this.particularesDataGridView.Name = "particularesDataGridView";
            this.particularesDataGridView.RowHeadersVisible = false;
            this.particularesDataGridView.Size = new System.Drawing.Size(557, 380);
            this.particularesDataGridView.TabIndex = 7;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 350;
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
            this.tlblVerNormal.Size = new System.Drawing.Size(55, 22);
            this.tlblVerNormal.Text = "Ver Nomal";
            this.tlblVerNormal.Click += new System.EventHandler(this.tlblVerNormal_Click);
            // 
            // frmParticulares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.casa4;
            this.ClientSize = new System.Drawing.Size(764, 575);
            this.Controls.Add(this.particularesDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(afinesLabel);
            this.Controls.Add(this.afinesTextBox);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(this.particularesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmParticulares";
            this.ShowIcon = false;
            this.Text = "Particulares";
            this.Load += new System.EventHandler(this.frmParticulares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularesBindingNavigator)).EndInit();
            this.particularesBindingNavigator.ResumeLayout(false);
            this.particularesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.particularesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource particularesBindingSource;
        private protectoraDataSetTableAdapters.ParticularesTableAdapter particularesTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator particularesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton particularesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox afinesTextBox;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.DataGridView particularesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripLabel tlblVerTodos;
        private System.Windows.Forms.ToolStripLabel tlblVerNormal;
    }
}