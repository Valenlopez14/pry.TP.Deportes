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
    public partial class frmRegistroDeportista : Form
    {
        public OleDbConnection conexionBD; //declaracion de conexion de Base de Datos
        public OleDbCommand comandoBD; //representa una instruccion 

        //declaracion de la ruta  que esta la BD
        public string RutaBD = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = DEPORTE.accdb";

        public frmRegistroDeportista()
        {
            InitializeComponent();
        }

        private void frmRegistroDeportista_Load(object sender, EventArgs e)
        {
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            //declaracion de variables a grabar
            string IdDeportista = txtCodigoDepor.Text;
            string NombreDeportista = txtNombre.Text;
            string ApellidoDeportista = txtApellido.Text;
            string DireccionDeportista = txtDireccion.Text;
            Int32 TelefonoDeportista = Convert.ToInt32(mskTelefono.Text);
            Int32 EdadDeportista = Convert.ToInt32(mskEdad.Text);
            string Deporte = Convert.ToString(lstDeporte.SelectedItem);


            try
            {
                conexionBD = new OleDbConnection(RutaBD);
                conexionBD.Open();
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;//conexion al origen de datos
                comandoBD.CommandType = CommandType.Text; //comando para insertar datos
                comandoBD.CommandText = "INSERT INTO DEPORTISTA ([CODIGO DEPORTISTA], NOMBRE, APELLIDO, DIRECCION,TELEFONO, EDAD, DEPORTE)" +
                    "VALUES(" + "'"+IdDeportista + "'" +
                    "," +"'" + NombreDeportista + "'"+ "," 
                    + "'" + ApellidoDeportista + "'"+ "," 
                    + "'" + DireccionDeportista + "'" + "," 
                    + "'" + TelefonoDeportista.ToString() + "'"+
                    "," + "'" + EdadDeportista + "'" + "," + "'" + Deporte + "'" + ")";
                comandoBD.ExecuteNonQuery(); //numero de filas afectuadas
                MessageBox.Show("Tus datos fueron ingresados con éxito");
            }
            catch (Exception mensaje)
            {
               MessageBox.Show("Error, datos no cargados." + mensaje.Message);
                //throw;
            }
            //Limpiar todas las cajas de la interfaz para usar sin problemas
            txtCodigoDepor.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            mskTelefono.Text = "";
            mskEdad.Text = "";
            lstDeporte.SelectedIndex = -1;

        }
        private void BuenasPracticas()
        {
            if (txtApellido.Text != "" && txtCodigoDepor.Text != "" && txtDireccion.Text != "" && txtNombre.Text != "" && lstDeporte.SelectedIndex >= 0 && mskEdad.Text != "" && mskTelefono.Text != "") 
            {
                cmdRegistrar.Enabled = true;
            }
            else
            {
                cmdRegistrar.Enabled = false;

            }
        }

        private void txtCodigoDepor_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }

        private void mskTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            BuenasPracticas();
        }

        private void mskEdad_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            BuenasPracticas();
        }

        private void lstDeporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuenasPracticas();
        }
    }
}
