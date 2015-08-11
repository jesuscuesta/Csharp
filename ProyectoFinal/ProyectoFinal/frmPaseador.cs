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
    public partial class frmPaseador : Form
    {
        public frmPaseador()
        {
            InitializeComponent();
        }

        private void paseadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paseadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmPaseador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Paseador' Puede moverla o quitarla según sea necesario.
            this.paseadorTableAdapter.Fill(this.protectoraDataSet.Paseador);

        }

        private void tlblTodos_Click(object sender, EventArgs e)
        {
            paseadorDataGridView.Visible = true;
            tlblNormal.Visible = true;
            tlblTodos.Visible = false;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            paseadorDataGridView.Visible = false;
            tlblNormal.Visible = false;
            tlblTodos.Visible = true;
        }
    }
}
