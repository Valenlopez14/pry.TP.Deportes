using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pry.BaseDeDatos.LopezV
{
    public partial class frmPrincipal : Form
    {
        //declaracion de variables globales
        //ponemos las variables publicas para usarlas en todo el proyecto 

        public OleDbConnection conexionBase;
        public OleDbConnection QueQuieroEnLaBase;
        public OleDbConnection LectorDeConsultas;

        public string varRutaBaseDatos = "DEPORTE.accdb";
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deportistasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroDeportista frmRegistroDeportista = new frmRegistroDeportista();
            frmRegistroDeportista.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRegistroEntrenador frmRegistroEntrenador = new frmRegistroEntrenador();
            frmRegistroEntrenador.ShowDialog();
        }

        private void deportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaDeportista frmConsultaDeportista = new frmConsultaDeportista();
            frmConsultaDeportista.ShowDialog();
        }

        private void entrenadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaEntrenador frmConsultaEntrenador = new frmConsultaEntrenador();
            frmConsultaEntrenador.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            //Si no hay errores funciona normal
            try
            {
                lblFecha.Text = DateTime.Now.ToString();
                conexionBase = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + varRutaBaseDatos);
                conexionBase.Open();
                lblEstado.Text = "Conectado" + conexionBase.ConnectionString;
                statusStrip1.BackColor = Color.GreenYellow;
            }
            // En caso que no funcione o exista algun error el "Catch" lo retiene y lo muestra en modo de mensaje
            catch (Exception mensaje)
            {
                lblEstado.Text = mensaje.Message;
                statusStrip1.BackColor= Color.Red;

                //throw;
            }
        }

        private void deportistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarDeportista frmModificarDeportista = new frmModificarDeportista();
            frmModificarDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarEntrenador frmModificarEntrenador = new frmModificarEntrenador();
            frmModificarEntrenador.ShowDialog();
        }

        private void deportistaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEliminarDeportista frmEliminarDeportista = new frmEliminarDeportista();
            frmEliminarDeportista.ShowDialog();
        }

        private void entrenadorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEliminarEntrenador frmEliminarEntrenador = new frmEliminarEntrenador();
            frmEliminarEntrenador.ShowDialog();
        }
    }
}
