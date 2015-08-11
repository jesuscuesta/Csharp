namespace ProyectoFinal
{
    partial class frmVerTodosAnimales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerTodosAnimales));
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
            this.tcbxQueBusca = new System.Windows.Forms.ToolStripComboBox();
            this.ttxtNombrebuscar = new System.Windows.Forms.ToolStripTextBox();
            this.animalesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOcultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingNavigator)).BeginInit();
            this.animalesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalesDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripSeparator1,
            this.tcbxQueBusca,
            this.ttxtNombrebuscar});
            this.animalesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalesBindingNavigator.Name = "animalesBindingNavigator";
            this.animalesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalesBindingNavigator.Size = new System.Drawing.Size(806, 25);
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
            // tcbxQueBusca
            // 
            this.tcbxQueBusca.Items.AddRange(new object[] {
            "ID",
            "Tipo",
            "Raza",
            "Nombre",
            "Edad",
            "Localizacion"});
            this.tcbxQueBusca.Name = "tcbxQueBusca";
            this.tcbxQueBusca.Size = new System.Drawing.Size(121, 25);
            // 
            // ttxtNombrebuscar
            // 
            this.ttxtNombrebuscar.Name = "ttxtNombrebuscar";
            this.ttxtNombrebuscar.Size = new System.Drawing.Size(100, 25);
            this.ttxtNombrebuscar.Click += new System.EventHandler(this.ttxtNombrebuscar_Click);
            // 
            // animalesDataGridView
            // 
            this.animalesDataGridView.AutoGenerateColumns = false;
            this.animalesDataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.animalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.animalesDataGridView.DataSource = this.animalesBindingSource;
            this.animalesDataGridView.Location = new System.Drawing.Point(10, 132);
            this.animalesDataGridView.Name = "animalesDataGridView";
            this.animalesDataGridView.RowHeadersVisible = false;
            this.animalesDataGridView.Size = new System.Drawing.Size(805, 370);
            this.animalesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Raza";
            this.dataGridViewTextBoxColumn3.HeaderText = "Raza";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Localizacion";
            this.dataGridViewTextBoxColumn6.HeaderText = "Localizacion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Vacunas recibidas";
            this.dataGridViewTextBoxColumn7.HeaderText = "Vacunas recibidas";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 200;
            // 
            // btnOcultar
            // 
            this.btnOcultar.Location = new System.Drawing.Point(794, 103);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(21, 23);
            this.btnOcultar.TabIndex = 2;
            this.btnOcultar.Text = "X";
            this.btnOcultar.UseVisualStyleBackColor = true;
            this.btnOcultar.MouseEnter += new System.EventHandler(this.btnOcultar_MouseEnter);
            this.btnOcultar.MouseLeave += new System.EventHandler(this.btnOcultar_MouseLeave);
            // 
            // frmVerTodosAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.animales1;
            this.ClientSize = new System.Drawing.Size(806, 538);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.animalesDataGridView);
            this.Controls.Add(this.animalesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVerTodosAnimales";
            this.ShowIcon = false;
            this.Text = "Todos Los Animales";
            this.Load += new System.EventHandler(this.frmVerTodosAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalesBindingNavigator)).EndInit();
            this.animalesBindingNavigator.ResumeLayout(false);
            this.animalesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalesDataGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView animalesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tcbxQueBusca;
        private System.Windows.Forms.ToolStripTextBox ttxtNombrebuscar;
    }
}