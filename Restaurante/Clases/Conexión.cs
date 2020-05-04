using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class Conexión
    {
        private const string error = "Hay problemas para conectarse a la base de datos";
        // Creamos el string de conexion.
        private SqlConnection con;
        public SqlConnection conexion
        {
            get
            {
                return con;
            }
        }
        public Conexión()
        {
            //Cambiar la instancia del servidor local de SQL Server.
            this.con = new SqlConnection(@"server = 127.0.0.1;
            integrated security = true; database = DBRestauranteMarias; ");
            //this.con = new SqlConnection("data source=192.168.0.254,1433; initial catalog=DBRestauranteMarias; user id=Restaurante; password=abc123;");

        }
        //Creamos el metodo para abrir la conecion con la base de datos
        public void Abrir()
        {
            try
            {
                con.Open();
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                    String.Format("{0} \n\n{1}",
                    error, excepcion.Message));
                ex.HelpLink = "EduardoCalix.com";
                ex.Source = "Clase_Conexion";
                throw ex;
            }
        }

        //Creamos el metodo para cerrar la conexion con la base de datos.
        public void Cerrar()
        {
            try
            {
                con.Close();
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                    String.Format("{0} \n\n{1}",
                    error, excepcion.Message));
                ex.HelpLink = "EduardoCalix.com";
                ex.Source = "Clase_Conexion";
                throw ex;
            }
        }
    }
}
