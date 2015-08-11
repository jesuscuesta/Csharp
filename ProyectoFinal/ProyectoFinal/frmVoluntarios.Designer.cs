namespace ProyectoFinal
{
    partial class frmVoluntarios
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
            System.Windows.Forms.Label funcionesLabel;
            System.Windows.Forms.Label horarioLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoluntarios));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.voluntarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voluntarioTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.VoluntarioTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.voluntarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.voluntarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.afinesTextBox = new System.Windows.Forms.TextBox();
            this.funcionesTextBox = new System.Windows.Forms.TextBox();
            this.horarioTextBox = new System.Windows.Forms.TextBox();
            this.voluntarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tlblVerTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblNormal = new System.Windows.Forms.ToolStripLabel();
            iDLabel = new System.Windows.Forms.Label();
            afinesLabel = new System.Windows.Forms.Label();
            funcionesLabel = new System.Windows.Forms.Label();
            horarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingNavigator)).BeginInit();
            this.voluntarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(30, 442);
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
            afinesLabel.Location = new System.Drawing.Point(30, 468);
            afinesLabel.Name = "afinesLabel";
            afinesLabel.Size = new System.Drawing.Size(39, 13);
            afinesLabel.TabIndex = 3;
            afinesLabel.Text = "Afines:";
            // 
            // funcionesLabel
            // 
            funcionesLabel.AutoSize = true;
            funcionesLabel.BackColor = System.Drawing.Color.Transparent;
            funcionesLabel.ForeColor = System.Drawing.Color.White;
            funcionesLabel.Location = new System.Drawing.Point(30, 494);
            funcionesLabel.Name = "funcionesLabel";
            funcionesLabel.Size = new System.Drawing.Size(59, 13);
            funcionesLabel.TabIndex = 5;
            funcionesLabel.Text = "Funciones:";
            // 
            // horarioLabel
            // 
            horarioLabel.AutoSize = true;
            horarioLabel.BackColor = System.Drawing.Color.Transparent;
            horarioLabel.ForeColor = System.Drawing.Color.White;
            horarioLabel.Location = new System.Drawing.Point(30, 520);
            horarioLabel.Name = "horarioLabel";
            horarioLabel.Size = new System.Drawing.Size(44, 13);
            horarioLabel.TabIndex = 7;
            horarioLabel.Text = "Horario:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voluntarioBindingSource
            // 
            this.voluntarioBindingSource.DataMember = "Voluntario";
            this.voluntarioBindingSource.DataSource = this.protectoraDataSet;
            // 
            // voluntarioTableAdapter
            // 
            this.voluntarioTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunasTableAdapter = null;
            this.tableAdapterManager.VoluntarioTableAdapter = this.voluntarioTableAdapter;
            // 
            // voluntarioBindingNavigator
            // 
            this.voluntarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.voluntarioBindingNavigator.BindingSource = this.voluntarioBindingSource;
            this.voluntarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.voluntarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.voluntarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.voluntarioBindingNavigatorSaveItem,
            this.tlblVerTodos,
            this.tlblNormal});
            this.voluntarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.voluntarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.voluntarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.voluntarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.voluntarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.voluntarioBindingNavigator.Name = "voluntarioBindingNavigator";
            this.voluntarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.voluntarioBindingNavigator.Size = new System.Drawing.Size(769, 25);
            this.voluntarioBindingNavigator.TabIndex = 0;
            this.voluntarioBindingNavigator.Text = "bindingNavigator1";
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
            // voluntarioBindingNavigatorSaveItem
            // 
            this.voluntarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.voluntarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("voluntarioBindingNavigatorSaveItem.Image")));
            this.voluntarioBindingNavigatorSaveItem.Name = "voluntarioBindingNavigatorSaveItem";
            this.voluntarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.voluntarioBindingNavigatorSaveItem.Text = "Guardar datos";
            this.voluntarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.voluntarioBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntarioBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(95, 439);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(126, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // afinesTextBox
            // 
            this.afinesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntarioBindingSource, "Afines", true));
            this.afinesTextBox.Location = new System.Drawing.Point(95, 465);
            this.afinesTextBox.Name = "afinesTextBox";
            this.afinesTextBox.Size = new System.Drawing.Size(223, 20);
            this.afinesTextBox.TabIndex = 4;
            // 
            // funcionesTextBox
            // 
            this.funcionesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntarioBindingSource, "Funciones", true));
            this.funcionesTextBox.Location = new System.Drawing.Point(95, 491);
            this.funcionesTextBox.Name = "funcionesTextBox";
            this.funcionesTextBox.Size = new System.Drawing.Size(223, 20);
            this.funcionesTextBox.TabIndex = 6;
            // 
            // horarioTextBox
            // 
            this.horarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntarioBindingSource, "Horario", true));
            this.horarioTextBox.Location = new System.Drawing.Point(95, 517);
            this.horarioTextBox.Name = "horarioTextBox";
            this.horarioTextBox.Size = new System.Drawing.Size(223, 20);
            this.horarioTextBox.TabIndex = 8;
            // 
            // voluntarioDataGridView
            // 
            this.voluntarioDataGridView.AutoGenerateColumns = false;
            this.voluntarioDataGridView.BackgroundColor = System.Drawing.Color.Khaki;
            this.voluntarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voluntarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.voluntarioDataGridView.DataSource = this.voluntarioBindingSource;
            this.voluntarioDataGridView.Location = new System.Drawing.Point(33, 119);
            this.voluntarioDataGridView.Name = "voluntarioDataGridView";
            this.voluntarioDataGridView.RowHeadersVisible = false;
            this.voluntarioDataGridView.Size = new System.Drawing.Size(703, 427);
            this.voluntarioDataGridView.TabIndex = 9;
            this.voluntarioDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Funciones";
            this.dataGridViewTextBoxColumn3.HeaderText = "Funciones";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Horario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Horario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // tlblVerTodos
            // 
            this.tlblVerTodos.Name = "tlblVerTodos";
            this.tlblVerTodos.Size = new System.Drawing.Size(55, 22);
            this.tlblVerTodos.Text = "Ver Todos";
            this.tlblVerTodos.Click += new System.EventHandler(this.tlblVerTodos_Click);
            // 
            // tlblNormal
            // 
            this.tlblNormal.Name = "tlblNormal";
            this.tlblNormal.Size = new System.Drawing.Size(59, 22);
            this.tlblNormal.Text = "Ver Normal";
            this.tlblNormal.Visible = false;
            this.tlblNormal.Click += new System.EventHandler(this.tlblNormal_Click);
            // 
            // frmVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.bosque;
            this.ClientSize = new System.Drawing.Size(769, 572);
            this.Controls.Add(this.voluntarioDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(afinesLabel);
            this.Controls.Add(this.afinesTextBox);
            this.Controls.Add(funcionesLabel);
            this.Controls.Add(this.funcionesTextBox);
            this.Controls.Add(horarioLabel);
            this.Controls.Add(this.horarioTextBox);
            this.Controls.Add(this.voluntarioBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVoluntarios";
            this.ShowIcon = false;
            this.Text = "Voluntarios";
            this.Load += new System.EventHandler(this.frmVoluntarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingNavigator)).EndInit();
            this.voluntarioBindingNavigator.ResumeLayout(false);
            this.voluntarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource voluntarioBindingSource;
        private protectoraDataSetTableAdapters.VoluntarioTableAdapter voluntarioTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator voluntarioBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton voluntarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox afinesTextBox;
        private System.Windows.Forms.TextBox funcionesTextBox;
        private System.Windows.Forms.TextBox horarioTextBox;
        private System.Windows.Forms.DataGridView voluntarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripLabel tlblVerTodos;
        private System.Windows.Forms.ToolStripLabel tlblNormal;
    }
}