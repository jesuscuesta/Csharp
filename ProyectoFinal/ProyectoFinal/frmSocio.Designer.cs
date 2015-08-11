namespace ProyectoFinal
{
    partial class frmSocio
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
            System.Windows.Forms.Label cuotaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSocio));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.socioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.socioTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.SocioTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.socioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.socioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.afinesTextBox = new System.Windows.Forms.TextBox();
            this.cuotaTextBox = new System.Windows.Forms.TextBox();
            this.socioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlblVerTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblVerNormal = new System.Windows.Forms.ToolStripLabel();
            iDLabel = new System.Windows.Forms.Label();
            afinesLabel = new System.Windows.Forms.Label();
            cuotaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingNavigator)).BeginInit();
            this.socioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(399, 331);
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
            afinesLabel.Location = new System.Drawing.Point(399, 357);
            afinesLabel.Name = "afinesLabel";
            afinesLabel.Size = new System.Drawing.Size(39, 13);
            afinesLabel.TabIndex = 3;
            afinesLabel.Text = "Afines:";
            // 
            // cuotaLabel
            // 
            cuotaLabel.AutoSize = true;
            cuotaLabel.BackColor = System.Drawing.Color.Transparent;
            cuotaLabel.ForeColor = System.Drawing.Color.White;
            cuotaLabel.Location = new System.Drawing.Point(399, 383);
            cuotaLabel.Name = "cuotaLabel";
            cuotaLabel.Size = new System.Drawing.Size(38, 13);
            cuotaLabel.TabIndex = 5;
            cuotaLabel.Text = "Cuota:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // socioBindingSource
            // 
            this.socioBindingSource.DataMember = "Socio";
            this.socioBindingSource.DataSource = this.protectoraDataSet;
            // 
            // socioTableAdapter
            // 
            this.socioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.ParticularesTableAdapter = null;
            this.tableAdapterManager.PaseadorTableAdapter = null;
            this.tableAdapterManager.ProcedenciaTableAdapter = null;
            this.tableAdapterManager.ProtectoraTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = this.socioTableAdapter;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunasTableAdapter = null;
            this.tableAdapterManager.VoluntarioTableAdapter = null;
            // 
            // socioBindingNavigator
            // 
            this.socioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.socioBindingNavigator.BindingSource = this.socioBindingSource;
            this.socioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.socioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.socioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.socioBindingNavigatorSaveItem,
            this.tlblVerTodos,
            this.tlblVerNormal});
            this.socioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.socioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.socioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.socioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.socioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.socioBindingNavigator.Name = "socioBindingNavigator";
            this.socioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.socioBindingNavigator.Size = new System.Drawing.Size(715, 25);
            this.socioBindingNavigator.TabIndex = 0;
            this.socioBindingNavigator.Text = "bindingNavigator1";
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
            // socioBindingNavigatorSaveItem
            // 
            this.socioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.socioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("socioBindingNavigatorSaveItem.Image")));
            this.socioBindingNavigatorSaveItem.Name = "socioBindingNavigatorSaveItem";
            this.socioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.socioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.socioBindingNavigatorSaveItem.Click += new System.EventHandler(this.socioBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(444, 328);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(124, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // afinesTextBox
            // 
            this.afinesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "Afines", true));
            this.afinesTextBox.Location = new System.Drawing.Point(444, 354);
            this.afinesTextBox.Name = "afinesTextBox";
            this.afinesTextBox.Size = new System.Drawing.Size(226, 20);
            this.afinesTextBox.TabIndex = 4;
            // 
            // cuotaTextBox
            // 
            this.cuotaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.socioBindingSource, "Cuota", true));
            this.cuotaTextBox.Location = new System.Drawing.Point(444, 380);
            this.cuotaTextBox.Name = "cuotaTextBox";
            this.cuotaTextBox.Size = new System.Drawing.Size(226, 20);
            this.cuotaTextBox.TabIndex = 6;
            // 
            // socioDataGridView
            // 
            this.socioDataGridView.AutoGenerateColumns = false;
            this.socioDataGridView.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.socioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.socioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.socioDataGridView.DataSource = this.socioBindingSource;
            this.socioDataGridView.Location = new System.Drawing.Point(282, 119);
            this.socioDataGridView.Name = "socioDataGridView";
            this.socioDataGridView.RowHeadersVisible = false;
            this.socioDataGridView.Size = new System.Drawing.Size(407, 293);
            this.socioDataGridView.TabIndex = 7;
            this.socioDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Cuota";
            this.dataGridViewTextBoxColumn3.HeaderText = "Cuota";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
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
            // frmSocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.casa6;
            this.ClientSize = new System.Drawing.Size(715, 450);
            this.Controls.Add(this.socioDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(afinesLabel);
            this.Controls.Add(this.afinesTextBox);
            this.Controls.Add(cuotaLabel);
            this.Controls.Add(this.cuotaTextBox);
            this.Controls.Add(this.socioBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSocio";
            this.ShowIcon = false;
            this.Text = "Socio";
            this.Load += new System.EventHandler(this.frmSocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socioBindingNavigator)).EndInit();
            this.socioBindingNavigator.ResumeLayout(false);
            this.socioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.socioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource socioBindingSource;
        private protectoraDataSetTableAdapters.SocioTableAdapter socioTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator socioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton socioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox afinesTextBox;
        private System.Windows.Forms.TextBox cuotaTextBox;
        private System.Windows.Forms.DataGridView socioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripLabel tlblVerTodos;
        private System.Windows.Forms.ToolStripLabel tlblVerNormal;
    }
}