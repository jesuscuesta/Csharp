namespace ProyectoFinal
{
    partial class frmLesiones
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
            System.Windows.Forms.Label lesionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLesiones));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.lesionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lesionTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.LesionTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.lesionBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.lesionBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.animalesTextBox = new System.Windows.Forms.TextBox();
            this.lesionTextBox = new System.Windows.Forms.TextBox();
            this.lesionDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            iDLabel = new System.Windows.Forms.Label();
            animalesLabel = new System.Windows.Forms.Label();
            lesionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesionBindingNavigator)).BeginInit();
            this.lesionBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lesionDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(84, 92);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 2;
            iDLabel.Text = "ID:";
            // 
            // animalesLabel
            // 
            animalesLabel.AutoSize = true;
            animalesLabel.BackColor = System.Drawing.Color.Transparent;
            animalesLabel.ForeColor = System.Drawing.Color.White;
            animalesLabel.Location = new System.Drawing.Point(84, 118);
            animalesLabel.Name = "animalesLabel";
            animalesLabel.Size = new System.Drawing.Size(52, 13);
            animalesLabel.TabIndex = 4;
            animalesLabel.Text = "Animales:";
            // 
            // lesionLabel
            // 
            lesionLabel.AutoSize = true;
            lesionLabel.BackColor = System.Drawing.Color.Transparent;
            lesionLabel.ForeColor = System.Drawing.Color.White;
            lesionLabel.Location = new System.Drawing.Point(84, 144);
            lesionLabel.Name = "lesionLabel";
            lesionLabel.Size = new System.Drawing.Size(41, 13);
            lesionLabel.TabIndex = 6;
            lesionLabel.Text = "Lesion:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.crosssmall;
            this.pictureBox1.Location = new System.Drawing.Point(533, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lesionBindingSource
            // 
            this.lesionBindingSource.DataMember = "Lesion";
            this.lesionBindingSource.DataSource = this.protectoraDataSet;
            // 
            // lesionTableAdapter
            // 
            this.lesionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LesionTableAdapter = this.lesionTableAdapter;
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
            // lesionBindingNavigator
            // 
            this.lesionBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.lesionBindingNavigator.BindingSource = this.lesionBindingSource;
            this.lesionBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.lesionBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.lesionBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.lesionBindingNavigatorSaveItem,
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.lesionBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.lesionBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.lesionBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.lesionBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.lesionBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.lesionBindingNavigator.Name = "lesionBindingNavigator";
            this.lesionBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.lesionBindingNavigator.Size = new System.Drawing.Size(573, 25);
            this.lesionBindingNavigator.TabIndex = 1;
            this.lesionBindingNavigator.Text = "bindingNavigator1";
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
            // lesionBindingNavigatorSaveItem
            // 
            this.lesionBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lesionBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("lesionBindingNavigatorSaveItem.Image")));
            this.lesionBindingNavigatorSaveItem.Name = "lesionBindingNavigatorSaveItem";
            this.lesionBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.lesionBindingNavigatorSaveItem.Text = "Guardar datos";
            this.lesionBindingNavigatorSaveItem.Click += new System.EventHandler(this.lesionBindingNavigatorSaveItem_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lesionBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(142, 89);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(114, 20);
            this.iDTextBox.TabIndex = 3;
            // 
            // animalesTextBox
            // 
            this.animalesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lesionBindingSource, "Animales", true));
            this.animalesTextBox.Location = new System.Drawing.Point(142, 115);
            this.animalesTextBox.Name = "animalesTextBox";
            this.animalesTextBox.Size = new System.Drawing.Size(114, 20);
            this.animalesTextBox.TabIndex = 5;
            // 
            // lesionTextBox
            // 
            this.lesionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lesionBindingSource, "Lesion", true));
            this.lesionTextBox.Location = new System.Drawing.Point(142, 141);
            this.lesionTextBox.Name = "lesionTextBox";
            this.lesionTextBox.Size = new System.Drawing.Size(393, 20);
            this.lesionTextBox.TabIndex = 7;
            // 
            // lesionDataGridView
            // 
            this.lesionDataGridView.AutoGenerateColumns = false;
            this.lesionDataGridView.BackgroundColor = System.Drawing.Color.DarkGreen;
            this.lesionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lesionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.lesionDataGridView.DataSource = this.lesionBindingSource;
            this.lesionDataGridView.GridColor = System.Drawing.Color.Chartreuse;
            this.lesionDataGridView.Location = new System.Drawing.Point(38, 89);
            this.lesionDataGridView.Name = "lesionDataGridView";
            this.lesionDataGridView.RowHeadersVisible = false;
            this.lesionDataGridView.Size = new System.Drawing.Size(506, 339);
            this.lesionDataGridView.TabIndex = 8;
            this.lesionDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Animales";
            this.dataGridViewTextBoxColumn2.HeaderText = "Animales";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Lesion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Lesion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 300;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripLabel1.Text = "Ver Todas Lesiones";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Ver Normal";
            this.toolStripLabel2.Visible = false;
            this.toolStripLabel2.Click += new System.EventHandler(this.toolStripLabel2_Click);
            // 
            // frmLesiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.hoja;
            this.ClientSize = new System.Drawing.Size(573, 226);
            this.Controls.Add(this.lesionDataGridView);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(animalesLabel);
            this.Controls.Add(this.animalesTextBox);
            this.Controls.Add(lesionLabel);
            this.Controls.Add(this.lesionTextBox);
            this.Controls.Add(this.lesionBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLesiones";
            this.ShowIcon = false;
            this.Text = "Lesiones y Enfermedades";
            this.Load += new System.EventHandler(this.frmLesiones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lesionBindingNavigator)).EndInit();
            this.lesionBindingNavigator.ResumeLayout(false);
            this.lesionBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lesionDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource lesionBindingSource;
        private protectoraDataSetTableAdapters.LesionTableAdapter lesionTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator lesionBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton lesionBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox animalesTextBox;
        private System.Windows.Forms.TextBox lesionTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.DataGridView lesionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
    }
}