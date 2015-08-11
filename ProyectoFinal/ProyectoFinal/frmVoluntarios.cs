using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmVoluntarios : Form
    {
        public frmVoluntarios()
        {
            InitializeComponent();
        }

        private void voluntarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.voluntarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmVoluntarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Voluntario' Puede moverla o quitarla según sea necesario.
            this.voluntarioTableAdapter.Fill(this.protectoraDataSet.Voluntario);

        }

        private void tlblVerTodos_Click(object sender, EventArgs e)
        {
            voluntarioDataGridView.Visible = true;
            tlblNormal.Visible = true;
            tlblVerTodos.Visible = false;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            voluntarioDataGridView.Visible = false;
            tlblNormal.Visible = false;
            tlblVerTodos.Visible = true;
        }
    }
}
