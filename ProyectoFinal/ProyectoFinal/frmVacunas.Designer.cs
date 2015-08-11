namespace ProyectoFinal
{
    partial class frmVacunas
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
            System.Windows.Forms.Label razaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label efectoLabel;
            System.Windows.Forms.Label edadLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVacunas));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.vacunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacunasTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.VacunasTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.vacunasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.vacunasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tlblTodas = new System.Windows.Forms.ToolStripLabel();
            this.tlblNormal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcbxEleccion = new System.Windows.Forms.ToolStripComboBox();
            this.ttxtOpciones = new System.Windows.Forms.ToolStripTextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.razaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.efectoTextBox = new System.Windows.Forms.TextBox();
            this.edadTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.vacunasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            iDLabel = new System.Windows.Forms.Label();
            razaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            efectoLabel = new System.Windows.Forms.Label();
            edadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingNavigator)).BeginInit();
            this.vacunasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.BackColor = System.Drawing.Color.Transparent;
            iDLabel.ForeColor = System.Drawing.Color.White;
            iDLabel.Location = new System.Drawing.Point(341, 110);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // razaLabel
            // 
            razaLabel.AutoSize = true;
            razaLabel.BackColor = System.Drawing.Color.Transparent;
            razaLabel.ForeColor = System.Drawing.Color.White;
            razaLabel.Location = new System.Drawing.Point(341, 136);
            razaLabel.Name = "razaLabel";
            razaLabel.Size = new System.Drawing.Size(35, 13);
            razaLabel.TabIndex = 3;
            razaLabel.Text = "Raza:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.ForeColor = System.Drawing.Color.White;
            nombreLabel.Location = new System.Drawing.Point(341, 162);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 5;
            nombreLabel.Text = "Nombre:";
            // 
            // efectoLabel
            // 
            efectoLabel.AutoSize = true;
            efectoLabel.BackColor = System.Drawing.Color.Transparent;
            efectoLabel.ForeColor = System.Drawing.Color.White;
            efectoLabel.Location = new System.Drawing.Point(341, 188);
            efectoLabel.Name = "efectoLabel";
            efectoLabel.Size = new System.Drawing.Size(41, 13);
            efectoLabel.TabIndex = 7;
            efectoLabel.Text = "Efecto:";
            // 
            // edadLabel
            // 
            edadLabel.AutoSize = true;
            edadLabel.BackColor = System.Drawing.Color.Transparent;
            edadLabel.ForeColor = System.Drawing.Color.White;
            edadLabel.Location = new System.Drawing.Point(341, 214);
            edadLabel.Name = "edadLabel";
            edadLabel.Size = new System.Drawing.Size(35, 13);
            edadLabel.TabIndex = 9;
            edadLabel.Text = "Edad:";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacunasBindingSource
            // 
            this.vacunasBindingSource.DataMember = "Vacunas";
            this.vacunasBindingSource.DataSource = this.protectoraDataSet;
            // 
            // vacunasTableAdapter
            // 
            this.vacunasTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.VacunasTableAdapter = this.vacunasTableAdapter;
            this.tableAdapterManager.VoluntarioTableAdapter = null;
            // 
            // vacunasBindingNavigator
            // 
            this.vacunasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vacunasBindingNavigator.BindingSource = this.vacunasBindingSource;
            this.vacunasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vacunasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vacunasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.vacunasBindingNavigatorSaveItem,
            this.tlblTodas,
            this.tlblNormal,
            this.toolStripSeparator1,
            this.tcbxEleccion,
            this.ttxtOpciones});
            this.vacunasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vacunasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vacunasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vacunasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vacunasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vacunasBindingNavigator.Name = "vacunasBindingNavigator";
            this.vacunasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vacunasBindingNavigator.Size = new System.Drawing.Size(834, 25);
            this.vacunasBindingNavigator.TabIndex = 0;
            this.vacunasBindingNavigator.Text = "bindingNavigator1";
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
            // vacunasBindingNavigatorSaveItem
            // 
            this.vacunasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vacunasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vacunasBindingNavigatorSaveItem.Image")));
            this.vacunasBindingNavigatorSaveItem.Name = "vacunasBindingNavigatorSaveItem";
            this.vacunasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vacunasBindingNavigatorSaveItem.Text = "Guardar datos";
            this.vacunasBindingNavigatorSaveItem.Click += new System.EventHandler(this.vacunasBindingNavigatorSaveItem_Click);
            // 
            // tlblTodas
            // 
            this.tlblTodas.Name = "tlblTodas";
            this.tlblTodas.Size = new System.Drawing.Size(114, 22);
            this.tlblTodas.Text = "Ver Todas las Vacunas";
            this.tlblTodas.Click += new System.EventHandler(this.tlblTodas_Click);
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
            "Raza",
            "Nombre",
            "Efecto",
            "Edad"});
            this.tcbxEleccion.Name = "tcbxEleccion";
            this.tcbxEleccion.Size = new System.Drawing.Size(121, 25);
            this.tcbxEleccion.Visible = false;
            // 
            // ttxtOpciones
            // 
            this.ttxtOpciones.Name = "ttxtOpciones";
            this.ttxtOpciones.Size = new System.Drawing.Size(100, 25);
            this.ttxtOpciones.Visible = false;
            this.ttxtOpciones.Click += new System.EventHandler(this.ttxtOpciones_Click);
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(394, 107);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(118, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // razaTextBox
            // 
            this.razaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "Raza", true));
            this.razaTextBox.Location = new System.Drawing.Point(394, 133);
            this.razaTextBox.Name = "razaTextBox";
            this.razaTextBox.Size = new System.Drawing.Size(241, 20);
            this.razaTextBox.TabIndex = 4;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(394, 159);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(241, 20);
            this.nombreTextBox.TabIndex = 6;
            // 
            // efectoTextBox
            // 
            this.efectoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "Efecto", true));
            this.efectoTextBox.Location = new System.Drawing.Point(394, 185);
            this.efectoTextBox.Name = "efectoTextBox";
            this.efectoTextBox.Size = new System.Drawing.Size(241, 20);
            this.efectoTextBox.TabIndex = 8;
            // 
            // edadTextBox
            // 
            this.edadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacunasBindingSource, "Edad", true));
            this.edadTextBox.Location = new System.Drawing.Point(394, 211);
            this.edadTextBox.Name = "edadTextBox";
            this.edadTextBox.Size = new System.Drawing.Size(241, 20);
            this.edadTextBox.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoFinal.Properties.Resources.perrogato;
            this.pictureBox1.Location = new System.Drawing.Point(45, 279);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(280, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // vacunasDataGridView
            // 
            this.vacunasDataGridView.AutoGenerateColumns = false;
            this.vacunasDataGridView.BackgroundColor = System.Drawing.SystemColors.Desktop;
            this.vacunasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacunasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vacunasDataGridView.DataSource = this.vacunasBindingSource;
            this.vacunasDataGridView.Location = new System.Drawing.Point(33, 82);
            this.vacunasDataGridView.Name = "vacunasDataGridView";
            this.vacunasDataGridView.RowHeadersVisible = false;
            this.vacunasDataGridView.Size = new System.Drawing.Size(603, 366);
            this.vacunasDataGridView.TabIndex = 12;
            this.vacunasDataGridView.Visible = false;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Raza";
            this.dataGridViewTextBoxColumn2.HeaderText = "Raza";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Efecto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Efecto";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Edad";
            this.dataGridViewTextBoxColumn5.HeaderText = "Edad";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 50;
            // 
            // frmVacunas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.playa;
            this.ClientSize = new System.Drawing.Size(834, 480);
            this.Controls.Add(this.vacunasDataGridView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(razaLabel);
            this.Controls.Add(this.razaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(efectoLabel);
            this.Controls.Add(this.efectoTextBox);
            this.Controls.Add(edadLabel);
            this.Controls.Add(this.edadTextBox);
            this.Controls.Add(this.vacunasBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmVacunas";
            this.ShowIcon = false;
            this.Text = "Vacunas";
            this.Load += new System.EventHandler(this.frmVacunas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasBindingNavigator)).EndInit();
            this.vacunasBindingNavigator.ResumeLayout(false);
            this.vacunasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacunasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource vacunasBindingSource;
        private protectoraDataSetTableAdapters.VacunasTableAdapter vacunasTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vacunasBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton vacunasBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.TextBox razaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox efectoTextBox;
        private System.Windows.Forms.TextBox edadTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripLabel tlblTodas;
        private System.Windows.Forms.ToolStripLabel tlblNormal;
        private System.Windows.Forms.DataGridView vacunasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox tcbxEleccion;
        private System.Windows.Forms.ToolStripTextBox ttxtOpciones;
    }
}