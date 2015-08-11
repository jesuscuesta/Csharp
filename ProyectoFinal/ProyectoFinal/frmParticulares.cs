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
    public partial class frmParticulares : Form
    {
        public frmParticulares()
        {
            InitializeComponent();
        }

        private void particularesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.particularesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmParticulares_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Particulares' Puede moverla o quitarla según sea necesario.
            this.particularesTableAdapter.Fill(this.protectoraDataSet.Particulares);

        }

        private void tlblVerTodos_Click(object sender, EventArgs e)
        {
            particularesDataGridView.Visible = true;
            tlblVerNormal.Visible = true;
            tlblVerTodos.Visible = false;
        }

        private void tlblVerNormal_Click(object sender, EventArgs e)
        {
            particularesDataGridView.Visible = false;
            tlblVerNormal.Visible = false;
            tlblVerTodos.Visible = true;
        }
    }
}
