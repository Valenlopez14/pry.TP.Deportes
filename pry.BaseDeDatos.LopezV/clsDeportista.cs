using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
 
namespace pry.BaseDeDatos.LopezV
{
    internal class clsDeportista
    {
        //Conectar a la Base de Datos
        private OleDbConnection conexion = new OleDbConnection();
        //Enviar orden a la BD
        private OleDbCommand comando = new OleDbCommand();
        //Objeto para adaptar los datos de la BD al Visual (.net)
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        //Variable con la ruta de la BD 
        private string RutaBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        //Variable con el nombre de la tabla a trabajar
        private string Tabla = "DEPORTISTA";

        //Declaracion de variables 
        private string CodigoDepor;
        private string NombreDepor;
        private string ApellidoDepor;
        private string DireccionDepor;
        private Int32 TelefonoDepor;
        private Int32 EdadDepor;
        private string Deportes;

        public string CodigoDeportista
        {
            get { return CodigoDepor; }
            set { CodigoDepor = value; }
        }
        public string Nombre
        {
            get { return NombreDepor; }
            set { NombreDepor = value; }
        }
        public string Apellido
        {
            get { return ApellidoDepor; }
            set { ApellidoDepor = value; }
        }
        public string Direccion
        {
            get { return DireccionDepor; }
            set { DireccionDepor = value; }
        }
        public Int32 Telefono
        {
            get { return TelefonoDepor; }
            set { TelefonoDepor = value; }
        }
        public Int32 Edad
        {
            get { return EdadDepor; }
            set { EdadDepor = value; }
        }
        public string Deporte
        {
            get { return Deportes; }
            set { Deportes = value; }
        }

        public void Listar (DataGridView GrillaConsultaDepor)
        {
            //Conectar base de datos
            conexion.ConnectionString = RutaBD;
            conexion.Open();
            //Conectar el comando a la BD
            comando.Connection = conexion;
            //Trae la tabla desde acces
            comando.CommandType = CommandType.TableDirect;
            //Selecciona la tabla
            comando.CommandText = Tabla;
            //Adaptador se conecta a BD, trae datos y los sube a la tabla Virtual de nuestro sistema (memoria RAM)
            adaptador = new OleDbDataAdapter (comando);
            //Almacena todo en una tabla virtual 
            DataSet DS  = new DataSet ();
            adaptador.Fill (DS);
            //Mostrar la grilla con los datos
            GrillaConsultaDepor.DataSource = DS.Tables [0];
            conexion.Close ();
        }

        public void Buscar (string Codigo)
        {
            try
            {
                //Conectar la base de datos
                conexion.ConnectionString = RutaBD;
                //Abrir base
                conexion.Open();
                //Conectar elcomando a la BD
                comando.Connection = conexion;
                //Traer la tabla desde acces
                comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                comando.CommandText = Tabla;
                //Recibir el contenido de la tabla
                OleDbDataReader lector = comando.ExecuteReader ();
                //Si la tabla contiene registros
                if (lector.HasRows)
                {
                    //leer Mientras no sea fin de archivo (EOF)
                    while (lector.Read())
                    {
                        if (lector.GetString(0) == Codigo)
                        {
                            CodigoDepor = lector.GetString (0);
                            NombreDepor = lector.GetString (1);
                            ApellidoDepor = lector.GetString (2);
                            DireccionDepor = lector.GetString (3);
                            TelefonoDepor = Convert.ToInt32(lector.GetString (4));
                            EdadDepor = lector.GetInt32 (5);
                            Deportes = lector.GetString (6);
                        }
                    }
                }
                conexion.Close();


            }
            catch (Exception mensaje)
            {
                MessageBox.Show (mensaje.Message);
                //throw;
            }
        }

        public void Modificar (string varCodigoDepor)
        {
            try
            {
                string SQL = "UPDATE DEPORTISTA SET [NOMBRE] = '" + Nombre + "',[APELLIDO] = '" + Apellido + "',[DIRECCION] = '" + Direccion + "', [TELEFONO] = " + Telefono + ", [EDAD] = " + Edad + ", [DEPORTE] = '" + Deporte + "' WHERE [CODIGO DEPORTISTA] = '" + varCodigoDepor + "'";
                //conectar a la BD
                conexion.ConnectionString = RutaBD;
                conexion.Open();

                //Conectar el comando a la BD
                comando.Connection = conexion;
                //Traer la tabla desde acces
                comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                comando.CommandText = SQL;
                comando.ExecuteNonQuery();

                conexion.Close();

                MessageBox.Show("Cambios Modificados con éxito.");

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                //throw;
            }

        }

        public void Eliminar (string CodigoDeportista)
        {
            try
            {
                string SQL = "DELETE FROM DEPORTISTA WHERE ('" + CodigoDeportista + "'=[CODIGO DEPORTISTA])";
                //conectar a la BD
                conexion.ConnectionString = RutaBD;
                conexion.Open ();

                //Conectar el comando a la BD
                comando.Connection = conexion;
                //Traer la tabla desde acces
                comando.CommandType = CommandType.Text;
                //Selecciona la tabla
                comando.CommandText = SQL;
                comando.ExecuteNonQuery ();

                conexion.Close ();
                MessageBox.Show("Eliminado con éxito.");

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                throw;
            }
        }



    }
}
