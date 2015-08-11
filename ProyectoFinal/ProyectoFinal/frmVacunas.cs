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
    public partial class frmVacunas : Form
    {
        public frmVacunas()
        {
            InitializeComponent();
        }

        private void vacunasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacunasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmVacunas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Vacunas' Puede moverla o quitarla según sea necesario.
            this.vacunasTableAdapter.Fill(this.protectoraDataSet.Vacunas);

        }

        private void tlblTodas_Click(object sender, EventArgs e)
        {
            vacunasDataGridView.Visible = true;
            tlblTodas.Visible = false;
            tlblNormal.Visible = true;
            tcbxEleccion.Visible = true;
            ttxtOpciones.Visible = true;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            vacunasDataGridView.Visible = false;
            tlblTodas.Visible = true;
            tlblNormal.Visible = false;
            tcbxEleccion.Visible = false;
            ttxtOpciones.Visible = false;
        }

        private void ttxtOpciones_Click(object sender, EventArgs e)
        {
            try
            {
                vacunasDataGridView.DataSource = protectoraDataSet.Vacunas.Select(tcbxEleccion.Text + " = '" + ttxtOpciones.Text + "'");
            }
            catch (System.Data.EvaluateException)
            {
                MessageBox.Show("Formato no válido. Introduce el correcto");
            }
            
        }
    }
}
