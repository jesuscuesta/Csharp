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
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }

        private void contactosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmContactos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Contactos' Puede moverla o quitarla según sea necesario.
            this.contactosTableAdapter.Fill(this.protectoraDataSet.Contactos);

        }

        private void tlblTodos_Click(object sender, EventArgs e)
        {
            contactosDataGridView.Visible = true;
            tlblNormal.Visible = true;
            tlblTodos.Visible = false;
            tcbxEleccion.Visible = true;
            ttxtOpcion.Visible = true;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            contactosDataGridView.Visible = false;
            tlblNormal.Visible = false;
            tlblTodos.Visible = true;
            tcbxEleccion.Visible = false;
            ttxtOpcion.Visible = false;
        }

        private void ttxtOpcion_Click(object sender, EventArgs e)
        {
            try
            {
                contactosDataGridView.DataSource = protectoraDataSet.Contactos.Select(tcbxEleccion.Text + " = '" + ttxtOpcion.Text + "'");
            }
            catch(System.Data.EvaluateException)
                {
                    MessageBox.Show("Formato no válido. Introduce el correcto");
                }
        }
    }
}
