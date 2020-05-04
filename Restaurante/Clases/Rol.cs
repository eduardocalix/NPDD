using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Rol
    {

        public int id { get; set; }
        public string nombre { get; set; }

        public Rol() { }

        public Rol(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public void ObtenerRol(string rolRe)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT id, rol FROM Acceso.Roles WHERE rol = '" + rolRe + "'";
            Console.WriteLine(conexion.conexion);
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.id = dr.GetInt32(0);
                    this.nombre = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Agregar()
        {

        }
        public void Modificar()
        {

        }
        public void Eliminar()
        {

        }

        public static DataTable GetDataTableRol()
        {
            DataTable dt = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "select departamento FROM Acceso.TipoAcceso";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
