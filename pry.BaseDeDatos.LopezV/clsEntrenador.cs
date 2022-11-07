using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pry.BaseDeDatos.LopezV
{
    internal class clsEntrenador
    {
        //Conectar a la BD
        private OleDbConnection conexion = new OleDbConnection();
        //comando para enviar ordenes a la BD
        private  OleDbCommand comando = new OleDbCommand();
        //Objeto para adaptar los datos de la BD a visaul (.net)
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        //Ruta de la BD
        private string RutaBD = "Provider = Microsoft.ACE.OLEDB.12.0;Data Source=" + "DEPORTE.accdb";
        //Nombre de la tabla
        private string Tabla = "ENTRENADORES";

        //Declarar variables a utilizar
        public bool Bandera = true;
        private string CodigoEntr;
        private string NombreEntr;
        private string ApellidoEntr;
        private string DireccionEntr;
        private string ProvinciaEntr;
        private string Deporte;

        public string CodigoEntrenador
        {
            get { return CodigoEntr; }
            set { CodigoEntr = value; }
        }
        public string NombreEntrenador
        {
            get { return NombreEntr; }
            set { NombreEntr = value; }
        }
        public string ApellidoEntrenador
        { 
            get { return ApellidoEntr; }
            set { ApellidoEntr = value;}
            
        }
        public string DireccionEntrenador
        {
            get { return DireccionEntr; }
            set { DireccionEntr = value; }
        }
        public string ProvinciaEntrenador
        {
            get { return ProvinciaEntr; }
            set { ProvinciaEntr = value; }
        }

        public string DeporteEntrenador
        {
            get { return Deporte; }
            set { Deporte = value; }
        }

        public void Listar(DataGridView GrillaConsultaEntr)
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
            adaptador = new OleDbDataAdapter(comando);
            //Almacena todo en una tabla virtual 
            DataSet DS = new DataSet();
            adaptador.Fill(DS);
            //Mostrar la grilla con los datos
            GrillaConsultaEntr.DataSource = DS.Tables[0];
            conexion.Close();
        }

        public void Buscar (string Codigo)
        {
            try
            {
                //Conectar la base de datos
                conexion.ConnectionString = RutaBD;
                conexion.Open ();

                //Conectar el comando a la BD 
                comando.Connection = conexion;
                //Trae la tabla desde acces
                comando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                comando.CommandText = Tabla;
                //Trae el contenido de la tabla 
                OleDbDataReader lector = comando.ExecuteReader();

                //Si hay registros en la tabla
                if (lector.HasRows)
                {
                    //leer Mientras no sea fin de archivo (EOF)
                    while (lector.Read())
                    {
                        if (lector.GetString(0) == Codigo)
                        {
                            Bandera = false;
                            CodigoEntr = lector.GetString(0);
                            NombreEntr = lector.GetString(1);
                            ApellidoEntr = lector.GetString(2);
                            DireccionEntr = lector.GetString(3);
                            ProvinciaEntr = lector.GetString(4);
                            Deporte = lector.GetString(5);
                        }
                    }
                }
                conexion.Close ();

            }
            catch (Exception mensaje)
            {
                MessageBox.Show(mensaje.Message);
                //throw;
            }
        }

        public void Modificar (string CodigoEntrenador)
        {
            try
            {
                string SQL = "UPDATE ENTRENADORES SET [DIRECCION] = '" + DireccionEntrenador + "', [PROVINCIA] = '" + ProvinciaEntrenador + "', [DEPORTE] = '" + DeporteEntrenador + "',[NOMBRE] = '" + NombreEntrenador + "', [APELLIDO] = '"+ ApellidoEntr + "' WHERE [CODIGO ENTRENADOR] = '" + CodigoEntrenador + "'";
                conexion.ConnectionString = RutaBD;
                conexion.Open();

                //Conectar el comando a la BD 
                comando.Connection = conexion;
                //Trae l tabla desde acces
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

        public void Eliminar (string CodigoEntr)
        {
            try
            {
                string SQL = "DELETE FROM ENTRENADORES WHERE ('" + CodigoEntr + "'= [CODIGO ENTRENADOR])";
                //conectar la bd 
                conexion.ConnectionString = RutaBD;
                conexion.Open ();
                //Conectar elcomando a la bd
                comando.Connection= conexion;
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
                //throw;
            }
        }





    }
}
