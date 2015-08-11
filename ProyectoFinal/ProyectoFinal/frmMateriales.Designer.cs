namespace ProyectoFinal
{
    partial class frmMateriales
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
            System.Windows.Forms.Label animalesLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label funcionesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMateriales));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.materialesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.MaterialesTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.materialesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.materialesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.animalesTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.funcionesTextBox = new System.Windows.Forms.TextBox();
            this.tlblTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblNormal = new System.Windows.Forms.ToolStripLabel();
            this.materialesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            animalesLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            funcionesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingNavigator)).BeginInit();
            this.materialesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.Location = new System.Drawing.Point(33, 272);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // animalesLabel
            // 
            animalesLabel.AutoSize = true;
            animalesLabel.BackColor = System.Drawing.Color.Transparent;
            animalesLabel.Location = new System.Drawing.Point(33, 298);
            animalesLabel.Name = "animalesLabel";
            animalesLabel.Size = new System.Drawing.Size(52, 13);
            animalesLabel.TabIndex = 3;
            animalesLabel.Text = "Animales:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(33, 324);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Location = new System.Drawing.Point(33, 350);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 7;
            estadoLabel.Text = "Estado:";
            // 
            // funcionesLabel
            // 
            funcionesLabel.AutoSize = true;
            funcionesLabel.BackColor = System.Drawing.Color.Transparent;
            funcionesLabel.Location = new System.Drawing.Point(33, 376);
            funcionesLabel.Name = "funcionesLabel";
            funcionesLabel.Size = new System.Drawing.Size(59, 13);
            funcionesLabel.TabIndex = 9;
            funcionesLabel.Text = "Funciones:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialesBindingSource
            // 
            this.materialesBindingSource.DataMember = "Materiales";
            this.materialesBindingSource.DataSource = this.protectoraDataSet;
            // 
            // materialesTableAdapter
            // 
            this.materialesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MaterialesTableAdapter = this.materialesTableAdapter;
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
            // materialesBindingNavigator
            // 
            this.materialesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.materialesBindingNavigator.BindingSource = this.materialesBindingSource;
            this.materialesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.materialesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.materialesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.materialesBindingNavigatorSaveItem,
            this.tlblTodos,
            this.tlblNormal});
            this.materialesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.materialesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.materialesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.materialesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.materialesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.materialesBindingNavigator.Name = "materialesBindingNavigator";
            this.materialesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.materialesBindingNavigator.Size = new System.Drawing.Size(502, 25);
            this.materialesBindingNavigator.TabIndex = 0;
            this.materialesBindingNavigator.Text = "bindingNavigator1";
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
            // materialesBindingNavigatorSaveItem
            // 
            this.materialesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.materialesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("materialesBindingNavigatorSaveItem.Image")));
            this.materialesBindingNavigatorSaveItem.Name = "materialesBindingNavigatorSaveItem";
            this.materialesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.materialesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.materialesBindingNavigatorSaveItem.Click += new System.EventHandler(this.materialesBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(98, 269);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(87, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // animalesTextBox
            // 
            this.animalesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "Animales", true));
            this.animalesTextBox.Location = new System.Drawing.Point(98, 295);
            this.animalesTextBox.Name = "animalesTextBox";
            this.animalesTextBox.Size = new System.Drawing.Size(87, 20);
            this.animalesTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(98, 321);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(382, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "Estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(98, 347);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(382, 20);
            this.estadoTextBox.TabIndex = 8;
            // 
            // funcionesTextBox
            // 
            this.funcionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.materialesBindingSource, "Funciones", true));
            this.funcionesTextBox.Location = new System.Drawing.Point(98, 373);
            this.funcionesTextBox.Name = "funcionesTextBox";
            this.funcionesTextBox.Size = new System.Drawing.Size(382, 20);
            this.funcionesTextBox.TabIndex = 10;
            // 
            // tlblTodos
            // 
            this.tlblTodos.Name = "tlblTodos";
            this.tlblTodos.Size = new System.Drawing.Size(123, 22);
            this.tlblTodos.Text = "Ver Todos los Materiales";
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
            // materialesDataGridView
            // 
            this.materialesDataGridView.AutoGenerateColumns = false;
            this.materialesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.materialesDataGridView.DataSource = this.materialesBindingSource;
            this.materialesDataGridView.Location = new System.Drawing.Point(27, 91);
            this.materialesDataGridView.Name = "materialesDataGridView";
            this.materialesDataGridView.RowHeadersVisible = false;
            this.materialesDataGridView.Size = new System.Drawing.Size(463, 310);
            this.materialesDataGridView.TabIndex = 11;
            this.materialesDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Animales";
            this.dataGridViewTextBoxColumn2.HeaderText = "Animales";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Estado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Funciones";
            this.dataGridViewTextBoxColumn5.HeaderText = "Funciones";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // frmMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.rail_walking2;
            this.ClientSize = new System.Drawing.Size(502, 413);
            this.Controls.Add(this.materialesDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(animalesLabel);
            this.Controls.Add(this.animalesTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(funcionesLabel);
            this.Controls.Add(this.funcionesTextBox);
            this.Controls.Add(this.materialesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMateriales";
            this.ShowIcon = false;
            this.Text = "Materiales";
            this.Load += new System.EventHandler(this.frmMateriales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialesBindingNavigator)).EndInit();
            this.materialesBindingNavigator.ResumeLayout(false);
            this.materialesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource materialesBindingSource;
        private protectoraDataSetTableAdapters.MaterialesTableAdapter materialesTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator materialesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton materialesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox animalesTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox funcionesTextBox;
        private System.Windows.Forms.ToolStripLabel tlblTodos;
        private System.Windows.Forms.ToolStripLabel tlblNormal;
        private System.Windows.Forms.DataGridView materialesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}