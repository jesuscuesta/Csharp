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
    public partial class frmColaborador : Form
    {
        public frmColaborador()
        {
            InitializeComponent();
        }

        private void colaboradorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colaboradorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmColaborador_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Colaborador' Puede moverla o quitarla según sea necesario.
            this.colaboradorTableAdapter.Fill(this.protectoraDataSet.Colaborador);

        }

        private void tlblVerTodos_Click(object sender, EventArgs e)
        {
            colaboradorDataGridView.Visible = true;
            tlblVerTodos.Visible = false;
            tlblVerNormal.Visible = true;
        }

        private void tlblVerNormal_Click(object sender, EventArgs e)
        {
            colaboradorDataGridView.Visible = false;
            tlblVerTodos.Visible = true;
            tlblVerNormal.Visible = false;
        }
    }
}
