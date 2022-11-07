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
    public partial class frmRegistroEntrenador : Form
    {
        public OleDbConnection conexionBD; //declaracion de conexion de BD
        public OleDbCommand comandoBD;//representa una instruccion 

        //declaracion de la ruta donde esta alojada la BD
        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";

        public frmRegistroEntrenador()
        {
            InitializeComponent();
        }

        private void cmdRegistrarEntr_Click(object sender, EventArgs e)
        {
            //declaracion de variables a grabar
            string IdEntrenadores = txtCodigoEntr.Text;
            string NombreEntrenador = txtNombreEntr.Text;
            string ApellidoEntrenador = txtApellidoEntr.Text;
            string DireccionEntrenador = Convert.ToString(txtDireccionEntr.Text);
            string ProvinciaEntrenador = Convert.ToString(lstProvinciaEntr.Text);
            string Deporte = Convert.ToString(lstDeporteEntr.SelectedItem);

            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD; //conexion al origen de datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = "INSERT INTO" + " ENTRENADORES ([CODIGO ENTRENADOR], [NOMBRE], [APELLIDO], [DIRECCION], [PROVINCIA], [DEPORTE])" +
                        " VALUES ('" + IdEntrenadores + "','" + NombreEntrenador + "','" + ApellidoEntrenador + "','" + DireccionEntrenador + "','" + ProvinciaEntrenador + "','" + Deporte + "')";

                comandoBD.ExecuteNonQuery();//numero de filas afectadas
                MessageBox.Show("Tus datos fueron ingresados con exito");
            }
            catch (Exception mensaje)
            {
                MessageBox.Show("Error, datos no cargados." + mensaje.Message);

                //throw;
            }
            //luego de grabar debemos limpiar las cajas de textos
            txtCodigoEntr.Text = "";
            txtCodigoEntr.Text = "";
            txtDireccionEntr.Text = "";
            txtNombreEntr.Text = "";
            txtApellidoEntr.Text = "";
            lstProvinciaEntr.SelectedIndex = -1;
            lstDeporteEntr.SelectedIndex = -1;
        }

        private void frmRegistroEntrenador_Load(object sender, EventArgs e)
        {
            cmdRegistrarEntr.Enabled = false;
        }
        private void BuenasPracticas()
        {
            if (txtCodigoEntr.Text != "" && txtNombreEntr.Text != "" && txtApellidoEntr.Text != "" && txtDireccionEntr.Text != "" && lstDeporteEntr.SelectedIndex >=0 && lstProvinciaEntr.SelectedIndex>=0)
            {
                cmdRegistrarEntr.Enabled = true;
            }
            else
            {
                cmdRegistrarEntr.Enabled = false;
            }
        }

        private void txtCodigoEntr_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void txtNombreEntr_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void txtApellidoEntr_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void txtDireccionEntr_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void lstProvinciaEntr_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void lstDeporteEntr_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }
    }
}
