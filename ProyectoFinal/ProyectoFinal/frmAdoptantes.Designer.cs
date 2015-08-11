namespace ProyectoFinal
{
    partial class frmAdoptantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdoptantes));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.adoptantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adoptantesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.AdoptantesTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.adoptantesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.adoptantesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.afinesTextBox = new System.Windows.Forms.TextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlblTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblNormal = new System.Windows.Forms.ToolStripLabel();
            this.adoptantesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            afinesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesBindingNavigator)).BeginInit();
            this.adoptantesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(368, 375);
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
            afinesLabel.Location = new System.Drawing.Point(368, 401);
            afinesLabel.Name = "afinesLabel";
            afinesLabel.Size = new System.Drawing.Size(39, 13);
            afinesLabel.TabIndex = 3;
            afinesLabel.Text = "Afines:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adoptantesBindingSource
            // 
            this.adoptantesBindingSource.DataMember = "Adoptantes";
            this.adoptantesBindingSource.DataSource = this.protectoraDataSet;
            // 
            // adoptantesTableAdapter
            // 
            this.adoptantesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptantesTableAdapter = this.adoptantesTableAdapter;
            this.tableAdapterManager.AfinesTableAdapter = null;
            this.tableAdapterManager.AnimalesTableAdapter = null;
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
            // adoptantesBindingNavigator
            // 
            this.adoptantesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.adoptantesBindingNavigator.BindingSource = this.adoptantesBindingSource;
            this.adoptantesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.adoptantesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.adoptantesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.adoptantesBindingNavigatorSaveItem,
            this.toolStripSeparator1,
            this.tlblTodos,
            this.tlblNormal});
            this.adoptantesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.adoptantesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.adoptantesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.adoptantesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.adoptantesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.adoptantesBindingNavigator.Name = "adoptantesBindingNavigator";
            this.adoptantesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.adoptantesBindingNavigator.Size = new System.Drawing.Size(637, 25);
            this.adoptantesBindingNavigator.TabIndex = 0;
            this.adoptantesBindingNavigator.Text = "bindingNavigator1";
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
            // adoptantesBindingNavigatorSaveItem
            // 
            this.adoptantesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.adoptantesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("adoptantesBindingNavigatorSaveItem.Image")));
            this.adoptantesBindingNavigatorSaveItem.Name = "adoptantesBindingNavigatorSaveItem";
            this.adoptantesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.adoptantesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.adoptantesBindingNavigatorSaveItem.Click += new System.EventHandler(this.adoptantesBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adoptantesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(413, 372);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(166, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // afinesTextBox
            // 
            this.afinesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adoptantesBindingSource, "Afines", true));
            this.afinesTextBox.Location = new System.Drawing.Point(413, 398);
            this.afinesTextBox.Name = "afinesTextBox";
            this.afinesTextBox.Size = new System.Drawing.Size(166, 20);
            this.afinesTextBox.TabIndex = 4;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // adoptantesDataGridView
            // 
            this.adoptantesDataGridView.AutoGenerateColumns = false;
            this.adoptantesDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.adoptantesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adoptantesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.adoptantesDataGridView.DataSource = this.adoptantesBindingSource;
            this.adoptantesDataGridView.GridColor = System.Drawing.Color.DarkGoldenrod;
            this.adoptantesDataGridView.Location = new System.Drawing.Point(371, 73);
            this.adoptantesDataGridView.Name = "adoptantesDataGridView";
            this.adoptantesDataGridView.RowHeadersVisible = false;
            this.adoptantesDataGridView.Size = new System.Drawing.Size(215, 382);
            this.adoptantesDataGridView.TabIndex = 5;
            this.adoptantesDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // frmAdoptantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.casa1;
            this.ClientSize = new System.Drawing.Size(637, 478);
            this.Controls.Add(this.adoptantesDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(afinesLabel);
            this.Controls.Add(this.afinesTextBox);
            this.Controls.Add(this.adoptantesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdoptantes";
            this.ShowIcon = false;
            this.Text = "Adoptantes";
            this.Load += new System.EventHandler(this.frmAdoptantes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesBindingNavigator)).EndInit();
            this.adoptantesBindingNavigator.ResumeLayout(false);
            this.adoptantesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource adoptantesBindingSource;
        private protectoraDataSetTableAdapters.AdoptantesTableAdapter adoptantesTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator adoptantesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton adoptantesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox afinesTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel tlblTodos;
        private System.Windows.Forms.ToolStripLabel tlblNormal;
        private System.Windows.Forms.DataGridView adoptantesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}