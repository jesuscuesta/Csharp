using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//PARA PODER CREAR APLICACIONES EN CONSOLA
using System.Runtime.InteropServices;
using System.Security;

namespace ProyectoFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // PARA QUE SE PUEDA CARGAR APLICACIONES EN CONSOLA
        //ESTO LA CREA
        public static int AsignarConsola()
        {
            return AllocConsole() ? 0 : Marshal.GetLastWin32Error();
            
        }
        //ESTO LA QUITA
        public static int LiberarConsola()
        {
            return FreeConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        //PARA PODER USAR LOS METODOS DE ANTES
        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Microsoft.Security",
          "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
          SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Microsoft.Security",
          "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
          SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();

        //System.Diagnostics.Process.Start("aaa");
        private void generalToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void enfermedadesYLesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLesiones les = new frmLesiones();
            les.Show();
        }

        private void materialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmMateriales mate = new frmMateriales();
            mate.Show();
        }

        private void vacunasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVacunas vacu = new frmVacunas();
            vacu.Show();
        }

        private void eventosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEventos even = new frmEventos();
            even.Show();
        }

        private void contactosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmContactos con = new frmContactos();
            con.Show();
        }

        private void ayudaParaLosAnimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAyudaAnimales ayuda = new frmAyudaAnimales();
            ayuda.Show();
        }

        private void ayudaParaLosAfinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlAyudaAfines ayuda = new pnlAyudaAfines();
            ayuda.Show();
        }

        private void generalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAfines afin = new frmAfines();
            afin.Show();
        }

        private void adoptantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAdoptantes adop = new frmAdoptantes();
            adop.Show();
        }

        private void voluntariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVoluntarios vol = new frmVoluntarios();
            vol.Show();
        }

        private void sociosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSocio socio = new frmSocio();
            socio.Show();
        }

        private void particularesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmParticulares part = new frmParticulares();
            part.Show();
        }

        private void paseadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPaseador pasea = new frmPaseador();
            pasea.Show();
        }

        private void padrinosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPadrinos padri = new frmPadrinos();
            padri.Show();
        }

        private void colaboradoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmColaborador col = new frmColaborador();
            col.Show();
        }

        private void formatoEstandarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAnimales ani = new frmAnimales();
            ani.Show();
        }

        private void verTodosLosAnimalesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVerTodosAnimales todos = new frmVerTodosAnimales();
            todos.Show();
        }

        private void entretenimientoToolStripenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Juegos.exe");
        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void entretenimientoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Juegos.exe");
        }
    }
}
