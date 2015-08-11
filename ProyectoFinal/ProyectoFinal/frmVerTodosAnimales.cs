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
    public partial class frmVerTodosAnimales : Form
    {
        public frmVerTodosAnimales()
        {
            InitializeComponent();
        }

        private void animalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmVerTodosAnimales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Animales' Puede moverla o quitarla según sea necesario.
            this.animalesTableAdapter.Fill(this.protectoraDataSet.Animales);

        }

        private void btnOcultar_MouseEnter(object sender, EventArgs e)
        {
            animalesDataGridView.Visible = false;
        }

        private void btnOcultar_MouseLeave(object sender, EventArgs e)
        {
            animalesDataGridView.Visible = true;
        }

        private void ttxtNombrebuscar_Click(object sender, EventArgs e)
        {
                    
            try
            {
                animalesDataGridView.DataSource = protectoraDataSet.Animales.Select(tcbxQueBusca.Text + " = '" + ttxtNombrebuscar.Text + "'");
            }
            catch (System.Data.EvaluateException)
            {
                MessageBox.Show("Formato no válido. Introduce el correcto");
            }
            
        }
    }
}
