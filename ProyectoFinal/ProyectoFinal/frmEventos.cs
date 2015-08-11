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
    public partial class frmEventos : Form
    {
        public frmEventos()
        {
            InitializeComponent();
        }

        private void eventosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmEventos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Eventos' Puede moverla o quitarla según sea necesario.
            this.eventosTableAdapter.Fill(this.protectoraDataSet.Eventos);

        }

        private void tlblTodos_Click(object sender, EventArgs e)
        {
            eventosDataGridView.Visible = true;
            tlblTodos.Visible = false;
            tlblNormal.Visible = true;
            tcbxQueBusca.Visible = true;
            ttxtNombreBuscar.Visible = true;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            eventosDataGridView.Visible = false;
            tlblTodos.Visible = true;
            tlblNormal.Visible = false;
            tcbxQueBusca.Visible = false;
            ttxtNombreBuscar.Visible = false;
        }

        private void ttxtNombreBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                eventosDataGridView.DataSource = protectoraDataSet.Eventos.Select(tcbxQueBusca.Text + " = '" + ttxtNombreBuscar.Text + "'");
            }
            catch (System.Data.EvaluateException)
            {
                MessageBox.Show("Formato no válido. Introduce el correcto");
            }
        }
    }
}
