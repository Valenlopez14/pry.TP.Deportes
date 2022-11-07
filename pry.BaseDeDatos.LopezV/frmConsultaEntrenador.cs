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
    public partial class frmConsultaEntrenador : Form
    {
        OleDbConnection conexionBase;
        OleDbCommand queQuieroDeportista;
        OleDbDataReader lectorDeportista;

        string RutaEntr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        public frmConsultaEntrenador()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            GrillaConsultaEntr.Rows.Clear();
            try
            {
                conexionBase = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + RutaEntr);
                conexionBase.Open(); //Abrimos la base de datos

                queQuieroDeportista = new OleDbCommand();
                queQuieroDeportista.Connection = conexionBase;
                queQuieroDeportista.CommandType = CommandType.TableDirect;
                queQuieroDeportista.CommandText = "ENTRENADORES";
                lectorDeportista = queQuieroDeportista.ExecuteReader();

                while (lectorDeportista.Read())
                {
                    GrillaConsultaEntr.Rows.Add(lectorDeportista["NOMBRE"], lectorDeportista["APELLIDO"], lectorDeportista["DIRECCION"], 
                        lectorDeportista["PROVINCIA"], lectorDeportista["DEPORTE"]);
                }
                lectorDeportista.Close();
                conexionBase.Close();
            }
            catch (Exception)
            {

                //throw;
            }
        }
    }
}
