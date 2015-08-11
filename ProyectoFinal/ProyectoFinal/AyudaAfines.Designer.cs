namespace ProyectoFinal
{
    partial class pnlAyudaAfines
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Gray;
            this.richTextBox1.Location = new System.Drawing.Point(256, 224);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(308, 123);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "\n- Introduce los datos de una persona nueva en Afines\n\n- Si realiza alguna tarea " +
                ", agrégalo también en su apartado con el DNI\n\n- Pulsa \"+\" e introduce los datos," +
                " cuando termines pulsa el disquet\n";
            // 
            // pnlAyudaAfines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal.Properties.Resources.buho2;
            this.ClientSize = new System.Drawing.Size(576, 411);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "pnlAyudaAfines";
            this.ShowIcon = false;
            this.Text = "Ayuda para los Afines";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}