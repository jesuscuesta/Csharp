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
    public partial class frmLesiones : Form
    {
        public frmLesiones()
        {
            InitializeComponent();
        }

        private void lesionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lesionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmLesiones_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Lesion' Puede moverla o quitarla según sea necesario.
            this.lesionTableAdapter.Fill(this.protectoraDataSet.Lesion);

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            lesionDataGridView.Visible = true;
            toolStripLabel1.Visible = false;
            toolStripLabel2.Visible = true;
            System.Drawing.Size numeros = new System.Drawing.Size(579, 486);
            this.Size = numeros;
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            lesionDataGridView.Visible = false;
            toolStripLabel1.Visible = true;
            toolStripLabel2.Visible = false;
            System.Drawing.Size numeros = new System.Drawing.Size(579, 258);
            this.Size = numeros;
        }
    }
}
