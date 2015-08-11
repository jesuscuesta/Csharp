namespace ProyectoFinal
{
    partial class frmAyudaAnimales
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlLetras1 = new System.Windows.Forms.Panel();
            this.lblAyuda3 = new System.Windows.Forms.Label();
            this.lblAyuda2 = new System.Windows.Forms.Label();
            this.lblayuda1 = new System.Windows.Forms.Label();
            this.pnlLetras1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLetras1
            // 
            this.pnlLetras1.BackColor = System.Drawing.Color.Transparent;
            this.pnlLetras1.Controls.Add(this.lblAyuda3);
            this.pnlLetras1.Controls.Add(this.lblAyuda2);
            this.pnlLetras1.Controls.Add(this.lblayuda1);
            this.pnlLetras1.Location = new System.Drawing.Point(12, 116);
            this.pnlLetras1.Name = "pnlLetras1";
            this.pnlLetras1.Size = new System.Drawing.Size(327, 184);
            this.pnlLetras1.TabIndex = 0;
            // 
            // lblAyuda3
            // 
            this.lblAyuda3.AutoSize = true;
            this.lblAyuda3.Location = new System.Drawing.Point(17, 115);
            this.lblAyuda3.Name = "lblAyuda3";
            this.lblAyuda3.Size = new System.Drawing.Size(288, 13);
            this.lblAyuda3.TabIndex = 2;
            this.lblAyuda3.Text = "- Mira el listado de vacuinas para saber cual poner al animal";
            // 
            // lblAyuda2
            // 
            this.lblAyuda2.AutoSize = true;
            this.lblAyuda2.Location = new System.Drawing.Point(17, 67);
            this.lblAyuda2.Name = "lblAyuda2";
            this.lblAyuda2.Size = new System.Drawing.Size(298, 13);
            this.lblAyuda2.TabIndex = 1;
            this.lblAyuda2.Text = "- Introduce  que materiales o lesiones que tienen los  animales";
            // 
            // lblayuda1
            // 
            this.lblayuda1.AutoSize = true;
            this.lblayuda1.Location = new System.Drawing.Point(17, 21);
            this.lblayuda1.Name = "lblayuda1";
            this.lblayuda1.Size = new System.Drawing.Size(158, 13);
            this.lblayuda1.TabIndex = 0;
            this.lblayuda1.Text = "- Agrega los datos  de un animal";
            // 
            // frmAyudaAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.jirafa;
            this.ClientSize = new System.Drawing.Size(503, 421);
            this.Controls.Add(this.pnlLetras1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAyudaAnimales";
            this.ShowIcon = false;
            this.Text = "Ayuda para añadir Animales";
            this.pnlLetras1.ResumeLayout(false);
            this.pnlLetras1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLetras1;
        private System.Windows.Forms.Label lblAyuda2;
        private System.Windows.Forms.Label lblayuda1;
        private System.Windows.Forms.Label lblAyuda3;
    }
}