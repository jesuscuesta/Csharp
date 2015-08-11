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
    public partial class frmAfines : Form
    {
        public frmAfines()
        {
            InitializeComponent();
        }

        private void afinesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.afinesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmAfines_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Voluntario' Puede moverla o quitarla según sea necesario.
            this.voluntarioTableAdapter.Fill(this.protectoraDataSet.Voluntario);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Paseador' Puede moverla o quitarla según sea necesario.
            this.paseadorTableAdapter.Fill(this.protectoraDataSet.Paseador);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Particulares' Puede moverla o quitarla según sea necesario.
            this.particularesTableAdapter.Fill(this.protectoraDataSet.Particulares);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Padrinos' Puede moverla o quitarla según sea necesario.
            this.padrinosTableAdapter.Fill(this.protectoraDataSet.Padrinos);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Colaborador' Puede moverla o quitarla según sea necesario.
            this.colaboradorTableAdapter.Fill(this.protectoraDataSet.Colaborador);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Adoptantes' Puede moverla o quitarla según sea necesario.
            this.adoptantesTableAdapter.Fill(this.protectoraDataSet.Adoptantes);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Afines' Puede moverla o quitarla según sea necesario.
            this.afinesTableAdapter.Fill(this.protectoraDataSet.Afines);

        }

        private void txtAdoptante_TextChanged(object sender, EventArgs e)
        {
            if (txtAdoptante.Text != "") { txtAdoptante.Text = "X"; txtAdoptante.BackColor = Color.White; }
            else { txtAdoptante.Text = ""; txtAdoptante.BackColor = Color.Silver; }
        }

        private void txtColaborador_TextChanged(object sender, EventArgs e)
        {
            if (txtColaborador.Text != "") { txtColaborador.Text = "X"; txtColaborador.BackColor = Color.White; }
            else { txtColaborador.Text = ""; txtColaborador.BackColor = Color.Silver; }
            
        }

        private void txtPadrino_TextChanged(object sender, EventArgs e)
        {
            if (txtPadrino.Text != "") { txtPadrino.Text = "X"; txtPadrino.BackColor = Color.White; }
            else { txtPadrino.Text = ""; txtPadrino.BackColor = Color.Silver; }
        }

        private void txtParticular_TextChanged(object sender, EventArgs e)
        {
            if (txtParticular.Text != "") { txtParticular.Text = "X"; txtParticular.BackColor = Color.White; }
            else { txtParticular.Text = ""; txtParticular.BackColor = Color.Silver; }
        }

        private void txtPaseador_TextChanged(object sender, EventArgs e)
        {
            if (txtPaseador.Text != "") { txtPaseador.Text = "X"; txtPaseador.BackColor = Color.White; }
            else { txtPaseador.Text = ""; txtPaseador.BackColor = Color.Silver; }
        }

        private void txtVoluntario_TextChanged(object sender, EventArgs e)
        {
            if (txtVoluntario.Text != "") { txtVoluntario.Text = "X"; txtVoluntario.BackColor = Color.White; }
            else {txtVoluntario.Text = ""; txtVoluntario.BackColor = Color.Silver; }
        }

        //477; 432   733; 266
        private void tlblTodos_Click(object sender, EventArgs e)
        {
            afinesDataGridView.Visible = true;
            tlblNormal.Visible = true;
            tlblTodos.Visible = false;
            System.Drawing.Size numeros = new System.Drawing.Size(760, 432);
            this.Size = numeros;
            tcbxEleccion.Visible = true;
            ttxtBuscar.Visible = true;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            afinesDataGridView.Visible = false;
            tlblNormal.Visible = false;
            tlblTodos.Visible = true;
            System.Drawing.Size numeros = new System.Drawing.Size(477, 432);
            this.Size = numeros;
            tcbxEleccion.Visible = false;
            ttxtBuscar.Visible = false;
        }

        private void ttxtBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                afinesDataGridView.DataSource = protectoraDataSet.Afines.Select(tcbxEleccion.Text + " = '" + ttxtBuscar.Text + "'");
            }
            catch (System.Data.EvaluateException)
            {
                MessageBox.Show("Formato no válido. Introduce el correcto");
            }
            
        }

        private void afinesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
