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
    public partial class frmMateriales : Form
    {
        public frmMateriales()
        {
            InitializeComponent();
        }

        private void materialesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.materialesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmMateriales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Materiales' Puede moverla o quitarla según sea necesario.
            this.materialesTableAdapter.Fill(this.protectoraDataSet.Materiales);

        }

        private void tlblTodos_Click(object sender, EventArgs e)
        {
            materialesDataGridView.Visible = true;
            tlblTodos.Visible = false;
            tlblNormal.Visible = true;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            materialesDataGridView.Visible = false;
            tlblTodos.Visible = true;
            tlblNormal.Visible = false;
        }
    }
}
