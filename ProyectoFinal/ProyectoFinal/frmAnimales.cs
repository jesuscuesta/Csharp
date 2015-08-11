using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using System.Net.Mail;
using System.Threading;

namespace ProyectoFinal
{
    public partial class frmAnimales : Form
    {
        public frmAnimales()
        {
            InitializeComponent();
        }

        private void animalesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.protectoraDataSet);

        }

        private void frmAnimales_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Materiales' Puede moverla o quitarla según sea necesario.
            this.materialesTableAdapter.Fill(this.protectoraDataSet.Materiales);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Lesion' Puede moverla o quitarla según sea necesario.
            this.lesionTableAdapter.Fill(this.protectoraDataSet.Lesion);
            // TODO: esta línea de código carga datos en la tabla 'protectoraDataSet.Animales' Puede moverla o quitarla según sea necesario.
            this.animalesTableAdapter.Fill(this.protectoraDataSet.Animales);

        }

        void VerLesiones()
        {
            AumentarTamañoFormulario();
            pnlLesiones.Visible = true;
        }

        void VerMateriales()
        {
            AumentarTamañoFormulario();
            pnlMateriales.Visible = true;
        }
        //System.Drawing.Size numeros = new System.Drawing.Size(599, 481);

        void CrearDocumentoWord()
        {
            //Objeto del Tipo Word Application
            Word.Application objWordApplication;
            //Objeto del Tipo Word Document
            Word.Document objWordDocument;
            // Objeto para interactuar con el Interop
            Object oMissing = System.Reflection.Missing.Value;

            //Creamos una instancia de una Aplicación Word.
            objWordApplication = new Word.Application();
            //A la aplicación Word, le añadimos un documento.
            objWordDocument = objWordApplication.Documents.Add(ref oMissing,
                                                             ref oMissing,
                                                             ref oMissing, ref oMissing);

            //Activamos el documento recien creado, de forma que podamos escribir en el
            objWordDocument.Activate();
            //Empezamos a escribir
            objWordApplication.Selection.Font.Color = Word.WdColor.wdColorBlue;
            objWordApplication.Selection.Font.Name = "Arial"; //Cambiamos el nombre
            objWordApplication.Selection.Font.Size = 24; //Cambiamos el tamaño
            //Alinearemos el texto que vamos a escribir al centro
            
            objWordApplication.Selection.ParagraphFormat.Alignment =
               Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
            
            objWordApplication.Selection.TypeText("NUEVO AMIGO");
            ;
            //Indicamos que el texto anterior es parte de un párrafo.
            objWordApplication.Selection.TypeParagraph();

            //Ahora veamos como cambiar el tipo y tamaño de la letra
            objWordApplication.Selection.Font.Color = Word.WdColor.wdColorBlack;
            objWordApplication.Selection.Font.Name = "Arial"; //Cambiamos el nombre
            objWordApplication.Selection.Font.Size = 12; //Cambiamos el tamaño
            //Alinearemos el texto que vamos a escribir al centro
            objWordApplication.Selection.ParagraphFormat.Alignment =
               Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphJustify;
            //Agregamos al texto
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();

            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("ID: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeText(iDTextBox.Text);
            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();

            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Nombre: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeText(nombreTextBox.Text);
            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();

            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Tipo: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeText(tipoTextBox.Text);
            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();


            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Raza: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeText(razaTextBox.Text);
            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();

            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Edad: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeText(edadTextBox.Text);
            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();

            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Localización: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeText(localizacionTextBox.Text);
            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();

            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Vacunas Recibidas: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeText(vacunas_recibidasTextBox.Text);
            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();


            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Lesiones o Enfermedades: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            for (int pos = 0; pos < lesionDataGridView.ColumnCount; pos++)
            {
                objWordApplication.Selection.TypeText(lesionDataGridView[0, pos].Value.ToString()+";");
            }

            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.Font.Bold = 1;
            objWordApplication.Selection.TypeText("Materiales: ");
            objWordApplication.Selection.Font.Bold = 0;
            objWordApplication.Selection.Font.Italic = 1;
            objWordApplication.Selection.TypeParagraph();
            for (int fil = 0; fil < materialesDataGridView.RowCount - 1; fil++)
            {
                objWordApplication.Selection.TypeText("Nombre: ");
                objWordApplication.Selection.TypeText(materialesDataGridView[0, fil].Value.ToString());
                objWordApplication.Selection.TypeParagraph();
                objWordApplication.Selection.TypeText("Estado: ");
                objWordApplication.Selection.TypeText(materialesDataGridView[1, fil].Value.ToString());
                objWordApplication.Selection.TypeParagraph();
                objWordApplication.Selection.TypeText("Descripción: ");
                objWordApplication.Selection.TypeText(materialesDataGridView[2, fil].Value.ToString());
                objWordApplication.Selection.TypeParagraph();
                objWordApplication.Selection.TypeParagraph();
                
            }

            objWordApplication.Selection.Font.Italic = 0;
            //Indicamos que el texto anterior es un párrafo
            objWordApplication.Selection.TypeParagraph();
            objWordApplication.Selection.TypeParagraph();

            objWordApplication.Visible = true;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string mensajazo = txtTexto.Text + "\n\n\n" + "- DATOS DEL ANIMAL -" + "\n\n- Nombre :" + nombreTextBox.Text + "\n\n- Tipo: " + tipoTextBox.Text + "\n\n- Raza: " + razaTextBox.Text + "\n\n- Edad: " + edadTextBox.Text + "\n\n- Vacunas: " + vacunas_recibidasTextBox.Text;


            //La cadena "servidor" es el servidor de correo que enviará tu mensaje
            string servidor = "smtp.gmail.com";
            // Crea el mensaje estableciendo quién lo manda y quién lo recibe
            MailMessage mensaje = new MailMessage(
               txtRemitente.Text,
               txtDestinatario.Text,
               txtAsunto.Text,
               mensajazo);

            //Envía el mensaje.
            SmtpClient cliente = new SmtpClient(servidor);

            cliente.UseDefaultCredentials = false;
            cliente.Credentials = new System.Net.NetworkCredential(txtRemitente.Text, mtxyContrasena.Text);
            cliente.Port = 587;
            cliente.Host = servidor;
            cliente.EnableSsl = true;

            //Añade credenciales si el servidor lo requiere.
            //cliente.Credentials = CredentialCache.DefaultNetworkCredentials;
            cliente.Send(mensaje);

            vaciarContenidoEmail();
        }

        //LO QUE MUESTRA Y OCULTA CUANDO PULSAMOS EL BOTON DE ENVIAR EMAIL
        void EnviarEmail()
        {
            AumentarTamañoFormulario();
            pnlEmail.Visible = true;
        }

        void AumentarTamañoFormulario()
        {
            System.Drawing.Size numeros = new System.Drawing.Size(900, 481);
            this.Size = numeros;
        }

        void vaciarContenidoEmail()
        {
            System.Drawing.Size numeros = new System.Drawing.Size(499, 481);
            this.Size = numeros;
            pnlEmail.Visible = false;
            txtAsunto.Text = "";
            txtDestinatario.Text = "";
            txtRemitente.Text = "Necesario de que sea de cuenta gmail";
            txtTexto.Text = "";
            mtxyContrasena.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            vaciarContenidoEmail();
        }

        void ReiniciarValores()
        {
            pnlMateriales.Visible = false;
            pnlLesiones.Visible = false;
            vaciarContenidoEmail();
        }

        private void cbxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbxMenu.Text)
            {
                case "Ver Todos los Animales":
                    frmVerTodosAnimales todos = new frmVerTodosAnimales();
                    todos.Show();
                    break;
                case "Ver Materiales":
                    ReiniciarValores();
                    VerMateriales();
                    break;
                case "Ver Lesiones":
                    ReiniciarValores();
                    VerLesiones();
                    break;
                case "Enviar Email":
                    ReiniciarValores();
                    EnviarEmail();
                    break;
                case "Crear Documento Word":
                    ReiniciarValores();
                    CrearDocumentoWord();
                    break;
                case "Vista Normal":
                    ReiniciarValores();
                    break;
                default:
                    break;
            }
        }

       
    }
}
