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
    public partial class frmAdoptantes : Form
    {
        public frmAdoptantes()
        {
            InitializeComponent();
        }

        private void adoptantesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.adoptantesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmAdoptantes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Adoptantes' Puede moverla o quitarla según sea necesario.
            this.adoptantesTableAdapter.Fill(this.protectoraDataSet.Adoptantes);

        }

        private void tlblTodos_Click(object sender, EventArgs e)
        {
            adoptantesDataGridView.Visible = true;
            tlblNormal.Visible = true;
            tlblTodos.Visible = false;
        }

        private void tlblNormal_Click(object sender, EventArgs e)
        {
            adoptantesDataGridView.Visible = false;
            tlblNormal.Visible = false;
            tlblTodos.Visible = true;
        }
    }
}
