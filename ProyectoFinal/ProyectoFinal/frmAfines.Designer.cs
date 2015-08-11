namespace ProyectoFinal
{
    partial class frmAfines
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
            System.Windows.Forms.Label dNILabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label localidadLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label correoElectronicoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.Windows.Forms.Label cualidadesLabel;
            System.Windows.Forms.Label lblAdoptantes;
            System.Windows.Forms.Label lblColaborador;
            System.Windows.Forms.Label lblPAdrino;
            System.Windows.Forms.Label lblParticular;
            System.Windows.Forms.Label lblPaseador;
            System.Windows.Forms.Label lblVoluntario;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAfines));
            this.protectoraDataSet = new ProyectoFinal.protectoraDataSet();
            this.afinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.afinesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.AfinesTableAdapter();
            this.tableAdapterManager = new ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager();
            this.adoptantesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.AdoptantesTableAdapter();
            this.colaboradorTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.ColaboradorTableAdapter();
            this.padrinosTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.PadrinosTableAdapter();
            this.particularesTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.ParticularesTableAdapter();
            this.paseadorTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.PaseadorTableAdapter();
            this.voluntarioTableAdapter = new ProyectoFinal.protectoraDataSetTableAdapters.VoluntarioTableAdapter();
            this.afinesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.afinesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tlblTodos = new System.Windows.Forms.ToolStripLabel();
            this.tlblNormal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tcbxEleccion = new System.Windows.Forms.ToolStripComboBox();
            this.ttxtBuscar = new System.Windows.Forms.ToolStripTextBox();
            this.dNITextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.localidadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.correoElectronicoTextBox = new System.Windows.Forms.TextBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cualidadesTextBox = new System.Windows.Forms.TextBox();
            this.adoptantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtAdoptante = new System.Windows.Forms.TextBox();
            this.colaboradorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtColaborador = new System.Windows.Forms.TextBox();
            this.padrinosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPadrino = new System.Windows.Forms.TextBox();
            this.particularesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtParticular = new System.Windows.Forms.TextBox();
            this.paseadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPaseador = new System.Windows.Forms.TextBox();
            this.voluntarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtVoluntario = new System.Windows.Forms.TextBox();
            this.afinesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dNILabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            localidadLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            correoElectronicoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            cualidadesLabel = new System.Windows.Forms.Label();
            lblAdoptantes = new System.Windows.Forms.Label();
            lblColaborador = new System.Windows.Forms.Label();
            lblPAdrino = new System.Windows.Forms.Label();
            lblParticular = new System.Windows.Forms.Label();
            lblPaseador = new System.Windows.Forms.Label();
            lblVoluntario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afinesBindingNavigator)).BeginInit();
            this.afinesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.padrinosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afinesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dNILabel
            // 
            dNILabel.AutoSize = true;
            dNILabel.BackColor = System.Drawing.Color.Transparent;
            dNILabel.Location = new System.Drawing.Point(38, 83);
            dNILabel.Name = "dNILabel";
            dNILabel.Size = new System.Drawing.Size(29, 13);
            dNILabel.TabIndex = 1;
            dNILabel.Text = "DNI:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.BackColor = System.Drawing.Color.Transparent;
            nombreLabel.Location = new System.Drawing.Point(38, 109);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.BackColor = System.Drawing.Color.Transparent;
            direccionLabel.Location = new System.Drawing.Point(38, 135);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 5;
            direccionLabel.Text = "Direccion:";
            // 
            // localidadLabel
            // 
            localidadLabel.AutoSize = true;
            localidadLabel.BackColor = System.Drawing.Color.Transparent;
            localidadLabel.Location = new System.Drawing.Point(38, 161);
            localidadLabel.Name = "localidadLabel";
            localidadLabel.Size = new System.Drawing.Size(56, 13);
            localidadLabel.TabIndex = 7;
            localidadLabel.Text = "Localidad:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel.Location = new System.Drawing.Point(38, 187);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Telefono:";
            // 
            // correoElectronicoLabel
            // 
            correoElectronicoLabel.AutoSize = true;
            correoElectronicoLabel.BackColor = System.Drawing.Color.Transparent;
            correoElectronicoLabel.Location = new System.Drawing.Point(38, 213);
            correoElectronicoLabel.Name = "correoElectronicoLabel";
            correoElectronicoLabel.Size = new System.Drawing.Size(97, 13);
            correoElectronicoLabel.TabIndex = 11;
            correoElectronicoLabel.Text = "Correo Electronico:";
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.BackColor = System.Drawing.Color.Transparent;
            fechaNacimientoLabel.Location = new System.Drawing.Point(38, 240);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(96, 13);
            fechaNacimientoLabel.TabIndex = 13;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // cualidadesLabel
            // 
            cualidadesLabel.AutoSize = true;
            cualidadesLabel.BackColor = System.Drawing.Color.Transparent;
            cualidadesLabel.Location = new System.Drawing.Point(38, 265);
            cualidadesLabel.Name = "cualidadesLabel";
            cualidadesLabel.Size = new System.Drawing.Size(62, 13);
            cualidadesLabel.TabIndex = 15;
            cualidadesLabel.Text = "Cualidades:";
            // 
            // lblAdoptantes
            // 
            lblAdoptantes.AutoSize = true;
            lblAdoptantes.BackColor = System.Drawing.Color.Transparent;
            lblAdoptantes.Location = new System.Drawing.Point(36, 317);
            lblAdoptantes.Name = "lblAdoptantes";
            lblAdoptantes.Size = new System.Drawing.Size(56, 13);
            lblAdoptantes.TabIndex = 17;
            lblAdoptantes.Text = "Adoptante";
            // 
            // lblColaborador
            // 
            lblColaborador.AutoSize = true;
            lblColaborador.BackColor = System.Drawing.Color.Transparent;
            lblColaborador.Location = new System.Drawing.Point(209, 317);
            lblColaborador.Name = "lblColaborador";
            lblColaborador.Size = new System.Drawing.Size(64, 13);
            lblColaborador.TabIndex = 19;
            lblColaborador.Text = "Colaborador";
            // 
            // lblPAdrino
            // 
            lblPAdrino.AutoSize = true;
            lblPAdrino.BackColor = System.Drawing.Color.Transparent;
            lblPAdrino.Location = new System.Drawing.Point(372, 317);
            lblPAdrino.Name = "lblPAdrino";
            lblPAdrino.Size = new System.Drawing.Size(43, 13);
            lblPAdrino.TabIndex = 21;
            lblPAdrino.Text = "Padrino";
            // 
            // lblParticular
            // 
            lblParticular.AutoSize = true;
            lblParticular.BackColor = System.Drawing.Color.Transparent;
            lblParticular.Location = new System.Drawing.Point(41, 356);
            lblParticular.Name = "lblParticular";
            lblParticular.Size = new System.Drawing.Size(51, 13);
            lblParticular.TabIndex = 23;
            lblParticular.Text = "Particular";
            // 
            // lblPaseador
            // 
            lblPaseador.AutoSize = true;
            lblPaseador.BackColor = System.Drawing.Color.Transparent;
            lblPaseador.Location = new System.Drawing.Point(221, 356);
            lblPaseador.Name = "lblPaseador";
            lblPaseador.Size = new System.Drawing.Size(52, 13);
            lblPaseador.TabIndex = 25;
            lblPaseador.Text = "Paseador";
            // 
            // lblVoluntario
            // 
            lblVoluntario.AutoSize = true;
            lblVoluntario.BackColor = System.Drawing.Color.Transparent;
            lblVoluntario.Location = new System.Drawing.Point(361, 356);
            lblVoluntario.Name = "lblVoluntario";
            lblVoluntario.Size = new System.Drawing.Size(54, 13);
            lblVoluntario.TabIndex = 27;
            lblVoluntario.Text = "Voluntario";
            // 
            // protectoraDataSet
            // 
            this.protectoraDataSet.DataSetName = "protectoraDataSet";
            this.protectoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afinesBindingSource
            // 
            this.afinesBindingSource.DataMember = "Afines";
            this.afinesBindingSource.DataSource = this.protectoraDataSet;
            // 
            // afinesTableAdapter
            // 
            this.afinesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdoptantesTableAdapter = this.adoptantesTableAdapter;
            this.tableAdapterManager.AfinesTableAdapter = this.afinesTableAdapter;
            this.tableAdapterManager.AnimalesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColaboradorTableAdapter = this.colaboradorTableAdapter;
            this.tableAdapterManager.ContactosTableAdapter = null;
            this.tableAdapterManager.EventosTableAdapter = null;
            this.tableAdapterManager.LesionTableAdapter = null;
            this.tableAdapterManager.MaterialesTableAdapter = null;
            this.tableAdapterManager.PadrinosTableAdapter = this.padrinosTableAdapter;
            this.tableAdapterManager.ParticularesTableAdapter = this.particularesTableAdapter;
            this.tableAdapterManager.PaseadorTableAdapter = this.paseadorTableAdapter;
            this.tableAdapterManager.ProcedenciaTableAdapter = null;
            this.tableAdapterManager.ProtectoraTableAdapter = null;
            this.tableAdapterManager.SocioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ProyectoFinal.protectoraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacunasTableAdapter = null;
            this.tableAdapterManager.VoluntarioTableAdapter = this.voluntarioTableAdapter;
            // 
            // adoptantesTableAdapter
            // 
            this.adoptantesTableAdapter.ClearBeforeFill = true;
            // 
            // colaboradorTableAdapter
            // 
            this.colaboradorTableAdapter.ClearBeforeFill = true;
            // 
            // padrinosTableAdapter
            // 
            this.padrinosTableAdapter.ClearBeforeFill = true;
            // 
            // particularesTableAdapter
            // 
            this.particularesTableAdapter.ClearBeforeFill = true;
            // 
            // paseadorTableAdapter
            // 
            this.paseadorTableAdapter.ClearBeforeFill = true;
            // 
            // voluntarioTableAdapter
            // 
            this.voluntarioTableAdapter.ClearBeforeFill = true;
            // 
            // afinesBindingNavigator
            // 
            this.afinesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.afinesBindingNavigator.BindingSource = this.afinesBindingSource;
            this.afinesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.afinesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.afinesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.afinesBindingNavigatorSaveItem,
            this.tlblTodos,
            this.tlblNormal,
            this.toolStripSeparator1,
            this.tcbxEleccion,
            this.ttxtBuscar});
            this.afinesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.afinesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.afinesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.afinesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.afinesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.afinesBindingNavigator.Name = "afinesBindingNavigator";
            this.afinesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.afinesBindingNavigator.Size = new System.Drawing.Size(471, 25);
            this.afinesBindingNavigator.TabIndex = 0;
            this.afinesBindingNavigator.Text = "bindingNavigator1";
            this.afinesBindingNavigator.RefreshItems += new System.EventHandler(this.afinesBindingNavigator_RefreshItems);
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
            // afinesBindingNavigatorSaveItem
            // 
            this.afinesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.afinesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("afinesBindingNavigatorSaveItem.Image")));
            this.afinesBindingNavigatorSaveItem.Name = "afinesBindingNavigatorSaveItem";
            this.afinesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.afinesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.afinesBindingNavigatorSaveItem.Click += new System.EventHandler(this.afinesBindingNavigatorSaveItem_Click);
            // 
            // tlblTodos
            // 
            this.tlblTodos.Name = "tlblTodos";
            this.tlblTodos.Size = new System.Drawing.Size(104, 22);
            this.tlblTodos.Text = "Ver Todos los Afines";
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
            // tcbxEleccion
            // 
            this.tcbxEleccion.Items.AddRange(new object[] {
            "DNI",
            "Nombre",
            "Direccion",
            "Localidad",
            "Telefono",
            "CorreoElectronico",
            "FechaNac",
            "Cualidades"});
            this.tcbxEleccion.Name = "tcbxEleccion";
            this.tcbxEleccion.Size = new System.Drawing.Size(121, 21);
            this.tcbxEleccion.Visible = false;
            // 
            // ttxtBuscar
            // 
            this.ttxtBuscar.Name = "ttxtBuscar";
            this.ttxtBuscar.Size = new System.Drawing.Size(100, 21);
            this.ttxtBuscar.Visible = false;
            this.ttxtBuscar.Click += new System.EventHandler(this.ttxtBuscar_Click);
            // 
            // dNITextBox
            // 
            this.dNITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afinesBindingSource, "DNI", true));
            this.dNITextBox.Location = new System.Drawing.Point(141, 80);
            this.dNITextBox.Name = "dNITextBox";
            this.dNITextBox.Size = new System.Drawing.Size(158, 20);
            this.dNITextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afinesBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(141, 106);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(303, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afinesBindingSource, "Direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(141, 132);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(303, 20);
            this.direccionTextBox.TabIndex = 6;
            // 
            // localidadTextBox
            // 
            this.localidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afinesBindingSource, "Localidad", true));
            this.localidadTextBox.Location = new System.Drawing.Point(141, 158);
            this.localidadTextBox.Name = "localidadTextBox";
            this.localidadTextBox.Size = new System.Drawing.Size(303, 20);
            this.localidadTextBox.TabIndex = 8;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afinesBindingSource, "Telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(141, 184);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(303, 20);
            this.telefonoTextBox.TabIndex = 10;
            // 
            // correoElectronicoTextBox
            // 
            this.correoElectronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afinesBindingSource, "CorreoElectronico", true));
            this.correoElectronicoTextBox.Location = new System.Drawing.Point(141, 210);
            this.correoElectronicoTextBox.Name = "correoElectronicoTextBox";
            this.correoElectronicoTextBox.Size = new System.Drawing.Size(303, 20);
            this.correoElectronicoTextBox.TabIndex = 12;
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.afinesBindingSource, "FechaNacimiento", true));
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(141, 236);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(211, 20);
            this.fechaNacimientoDateTimePicker.TabIndex = 14;
            // 
            // cualidadesTextBox
            // 
            this.cualidadesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.afinesBindingSource, "Cualidades", true));
            this.cualidadesTextBox.Location = new System.Drawing.Point(141, 262);
            this.cualidadesTextBox.Name = "cualidadesTextBox";
            this.cualidadesTextBox.Size = new System.Drawing.Size(303, 20);
            this.cualidadesTextBox.TabIndex = 16;
            // 
            // adoptantesBindingSource
            // 
            this.adoptantesBindingSource.DataMember = "AfinesAdoptantes";
            this.adoptantesBindingSource.DataSource = this.afinesBindingSource;
            // 
            // txtAdoptante
            // 
            this.txtAdoptante.BackColor = System.Drawing.Color.Silver;
            this.txtAdoptante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.adoptantesBindingSource, "ID", true));
            this.txtAdoptante.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdoptante.Location = new System.Drawing.Point(112, 314);
            this.txtAdoptante.Name = "txtAdoptante";
            this.txtAdoptante.ReadOnly = true;
            this.txtAdoptante.Size = new System.Drawing.Size(22, 20);
            this.txtAdoptante.TabIndex = 18;
            this.txtAdoptante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdoptante.TextChanged += new System.EventHandler(this.txtAdoptante_TextChanged);
            // 
            // colaboradorBindingSource
            // 
            this.colaboradorBindingSource.DataMember = "AfinesColaborador";
            this.colaboradorBindingSource.DataSource = this.afinesBindingSource;
            // 
            // txtColaborador
            // 
            this.txtColaborador.BackColor = System.Drawing.Color.Silver;
            this.txtColaborador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.colaboradorBindingSource, "ID", true));
            this.txtColaborador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColaborador.Location = new System.Drawing.Point(288, 314);
            this.txtColaborador.Name = "txtColaborador";
            this.txtColaborador.ReadOnly = true;
            this.txtColaborador.Size = new System.Drawing.Size(23, 20);
            this.txtColaborador.TabIndex = 20;
            this.txtColaborador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColaborador.TextChanged += new System.EventHandler(this.txtColaborador_TextChanged);
            // 
            // padrinosBindingSource
            // 
            this.padrinosBindingSource.DataMember = "AfinesPadrinos";
            this.padrinosBindingSource.DataSource = this.afinesBindingSource;
            // 
            // txtPadrino
            // 
            this.txtPadrino.BackColor = System.Drawing.Color.Silver;
            this.txtPadrino.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.padrinosBindingSource, "ID", true));
            this.txtPadrino.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPadrino.Location = new System.Drawing.Point(433, 314);
            this.txtPadrino.Name = "txtPadrino";
            this.txtPadrino.ReadOnly = true;
            this.txtPadrino.Size = new System.Drawing.Size(23, 20);
            this.txtPadrino.TabIndex = 22;
            this.txtPadrino.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPadrino.TextChanged += new System.EventHandler(this.txtPadrino_TextChanged);
            // 
            // particularesBindingSource
            // 
            this.particularesBindingSource.DataMember = "AfinesParticulares";
            this.particularesBindingSource.DataSource = this.afinesBindingSource;
            // 
            // txtParticular
            // 
            this.txtParticular.BackColor = System.Drawing.Color.Silver;
            this.txtParticular.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.particularesBindingSource, "ID", true));
            this.txtParticular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticular.Location = new System.Drawing.Point(112, 353);
            this.txtParticular.Name = "txtParticular";
            this.txtParticular.ReadOnly = true;
            this.txtParticular.Size = new System.Drawing.Size(22, 20);
            this.txtParticular.TabIndex = 24;
            this.txtParticular.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtParticular.TextChanged += new System.EventHandler(this.txtParticular_TextChanged);
            // 
            // paseadorBindingSource
            // 
            this.paseadorBindingSource.DataMember = "AfinesPaseador";
            this.paseadorBindingSource.DataSource = this.afinesBindingSource;
            // 
            // txtPaseador
            // 
            this.txtPaseador.BackColor = System.Drawing.Color.Silver;
            this.txtPaseador.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paseadorBindingSource, "ID", true));
            this.txtPaseador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaseador.Location = new System.Drawing.Point(288, 353);
            this.txtPaseador.Name = "txtPaseador";
            this.txtPaseador.ReadOnly = true;
            this.txtPaseador.Size = new System.Drawing.Size(23, 20);
            this.txtPaseador.TabIndex = 26;
            this.txtPaseador.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPaseador.TextChanged += new System.EventHandler(this.txtPaseador_TextChanged);
            // 
            // voluntarioBindingSource
            // 
            this.voluntarioBindingSource.DataMember = "AfinesVoluntario";
            this.voluntarioBindingSource.DataSource = this.afinesBindingSource;
            // 
            // txtVoluntario
            // 
            this.txtVoluntario.BackColor = System.Drawing.Color.Silver;
            this.txtVoluntario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.voluntarioBindingSource, "ID", true));
            this.txtVoluntario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoluntario.Location = new System.Drawing.Point(433, 353);
            this.txtVoluntario.Name = "txtVoluntario";
            this.txtVoluntario.ReadOnly = true;
            this.txtVoluntario.Size = new System.Drawing.Size(23, 20);
            this.txtVoluntario.TabIndex = 28;
            this.txtVoluntario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVoluntario.TextChanged += new System.EventHandler(this.txtVoluntario_TextChanged);
            // 
            // afinesDataGridView
            // 
            this.afinesDataGridView.AutoGenerateColumns = false;
            this.afinesDataGridView.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.afinesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.afinesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.afinesDataGridView.DataSource = this.afinesBindingSource;
            this.afinesDataGridView.GridColor = System.Drawing.Color.DarkCyan;
            this.afinesDataGridView.Location = new System.Drawing.Point(6, 42);
            this.afinesDataGridView.Name = "afinesDataGridView";
            this.afinesDataGridView.RowHeadersVisible = false;
            this.afinesDataGridView.Size = new System.Drawing.Size(733, 256);
            this.afinesDataGridView.TabIndex = 29;
            this.afinesDataGridView.Visible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DNI";
            this.dataGridViewTextBoxColumn1.HeaderText = "DNI";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Localidad";
            this.dataGridViewTextBoxColumn4.HeaderText = "Localidad";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CorreoElectronico";
            this.dataGridViewTextBoxColumn6.HeaderText = "CorreoElectronico";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "FechaNacimiento";
            this.dataGridViewTextBoxColumn7.HeaderText = "FechaNacimiento";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 60;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Cualidades";
            this.dataGridViewTextBoxColumn8.HeaderText = "Cualidades";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // frmAfines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.cielo;
            this.ClientSize = new System.Drawing.Size(471, 400);
            this.Controls.Add(this.afinesDataGridView);
            this.Controls.Add(lblVoluntario);
            this.Controls.Add(this.txtVoluntario);
            this.Controls.Add(lblPaseador);
            this.Controls.Add(this.txtPaseador);
            this.Controls.Add(lblParticular);
            this.Controls.Add(this.txtParticular);
            this.Controls.Add(lblPAdrino);
            this.Controls.Add(this.txtPadrino);
            this.Controls.Add(lblColaborador);
            this.Controls.Add(this.txtColaborador);
            this.Controls.Add(lblAdoptantes);
            this.Controls.Add(this.txtAdoptante);
            this.Controls.Add(dNILabel);
            this.Controls.Add(this.dNITextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(localidadLabel);
            this.Controls.Add(this.localidadTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(correoElectronicoLabel);
            this.Controls.Add(this.correoElectronicoTextBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(cualidadesLabel);
            this.Controls.Add(this.cualidadesTextBox);
            this.Controls.Add(this.afinesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAfines";
            this.ShowIcon = false;
            this.Text = "Afines";
            this.Load += new System.EventHandler(this.frmAfines_Load);
            ((System.ComponentModel.ISupportInitialize)(this.protectoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afinesBindingNavigator)).EndInit();
            this.afinesBindingNavigator.ResumeLayout(false);
            this.afinesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adoptantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colaboradorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.padrinosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particularesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paseadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voluntarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afinesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private protectoraDataSet protectoraDataSet;
        private System.Windows.Forms.BindingSource afinesBindingSource;
        private protectoraDataSetTableAdapters.AfinesTableAdapter afinesTableAdapter;
        private protectoraDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator afinesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton afinesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dNITextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox localidadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox correoElectronicoTextBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.TextBox cualidadesTextBox;
        private protectoraDataSetTableAdapters.AdoptantesTableAdapter adoptantesTableAdapter;
        private System.Windows.Forms.BindingSource adoptantesBindingSource;
        private protectoraDataSetTableAdapters.ColaboradorTableAdapter colaboradorTableAdapter;
        private System.Windows.Forms.TextBox txtAdoptante;
        private System.Windows.Forms.BindingSource colaboradorBindingSource;
        private System.Windows.Forms.TextBox txtColaborador;
        private protectoraDataSetTableAdapters.PadrinosTableAdapter padrinosTableAdapter;
        private System.Windows.Forms.BindingSource padrinosBindingSource;
        private protectoraDataSetTableAdapters.ParticularesTableAdapter particularesTableAdapter;
        private System.Windows.Forms.TextBox txtPadrino;
        private System.Windows.Forms.BindingSource particularesBindingSource;
        private System.Windows.Forms.TextBox txtParticular;
        private protectoraDataSetTableAdapters.PaseadorTableAdapter paseadorTableAdapter;
        private System.Windows.Forms.BindingSource paseadorBindingSource;
        private protectoraDataSetTableAdapters.VoluntarioTableAdapter voluntarioTableAdapter;
        private System.Windows.Forms.TextBox txtPaseador;
        private System.Windows.Forms.BindingSource voluntarioBindingSource;
        private System.Windows.Forms.TextBox txtVoluntario;
        private System.Windows.Forms.ToolStripLabel tlblTodos;
        private System.Windows.Forms.ToolStripLabel tlblNormal;
        private System.Windows.Forms.DataGridView afinesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.ToolStripComboBox tcbxEleccion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox ttxtBuscar;
    }
}