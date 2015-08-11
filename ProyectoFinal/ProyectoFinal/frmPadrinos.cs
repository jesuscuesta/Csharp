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
    public partial class frmPadrinos : Form
    {
        public frmPadrinos()
        {
            InitializeComponent();
        }

        private void padrinosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.padrinosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmPadrinos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Padrinos' Puede moverla o quitarla según sea necesario.
            this.padrinosTableAdapter.Fill(this.protectoraDataSet.Padrinos);

        }

        private void tlblVerTodos_Click(object sender, EventArgs e)
        {
            padrinosDataGridView.Visible = true;
            tlblVerNormal.Visible = true;
            tlblVerTodos.Visible = false;
        }

        private void tlblVerNormal_Click(object sender, EventArgs e)
        {
            padrinosDataGridView.Visible = false;
            tlblVerNormal.Visible = false;
            tlblVerTodos.Visible = true;
        }
    }
}
