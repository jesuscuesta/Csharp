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
    public partial class frmSocio : Form
    {
        public frmSocio()
        {
            InitializeComponent();
        }

        private void socioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.socioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmSocio_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Socio' Puede moverla o quitarla según sea necesario.
            this.socioTableAdapter.Fill(this.protectoraDataSet.Socio);

        }

        private void tlblVerTodos_Click(object sender, EventArgs e)
        {
            socioDataGridView.Visible = true;
            tlblVerNormal.Visible = true;
            tlblVerTodos.Visible = false;
        }

        private void tlblVerNormal_Click(object sender, EventArgs e)
        {
            socioDataGridView.Visible = false;
            tlblVerNormal.Visible = false;
            tlblVerTodos.Visible = true;
        }
    }
}
