using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace Restaurante.Clases
{
    class Usuarios
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public int rol { get; set; }
        public int Estado { get; set; }


        public Usuarios() { }

        public Usuarios(string usuario)
        {
            this.usuario = usuario;
        }
        public Usuarios(string usuario,int estado)
        {
            this.usuario = usuario;
            this.Estado = estado;
        }
        public Usuarios(string nombre, string apellido, string clave, int rol)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            this.rol = rol;
        }

        public Usuarios(string usuario, string nombre, string apellido, string clave, int rol)
        {
            this.usuario = usuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.clave = clave;
            this.rol = rol;
        }


        public void ObtenerUsuario(string usuarioRe)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT id, nombre, apellido, usuario, clave, idRol FROM Acceso.Usuarios WHERE usuario = '" + usuarioRe + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    this.id = dr.GetInt32(0);
                    this.nombre = dr.GetString(1);
                    this.apellido = dr.GetString(2);
                    this.usuario = dr.GetString(3);
                    this.clave = dr.GetString(4);
                    this.id = dr.GetInt32(5);
                }
            }
            catch (SqlException excepcion)
            {
                Exception ex = new Exception(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del usuario", excepcion.Message));
                ex.HelpLink = "OscarToledo.com";
                ex.Source = "Clase_Usuario";
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_InsertarUsuario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = this.nombre;
                cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = this.apellido;
                cmd.Parameters.Add(new SqlParameter("Clave", SqlDbType.NVarChar, 20));
                cmd.Parameters["clave"].Value = this.clave;
                cmd.Parameters.Add(new SqlParameter("idRol", SqlDbType.Int));
                cmd.Parameters["idRol"].Value = this.rol;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarUsuario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("UsuarioAnterior", SqlDbType.VarChar, 26));
                cmd.Parameters["usuarioAnterior"].Value = this.usuario;
                cmd.Parameters.Add(new SqlParameter("Nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = this.nombre;
                cmd.Parameters.Add(new SqlParameter("Apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = this.apellido;
                cmd.Parameters.Add(new SqlParameter("Clave", SqlDbType.NVarChar, 20));
                cmd.Parameters["clave"].Value = this.clave;
                cmd.Parameters.Add(new SqlParameter("idRol", SqlDbType.Int));
                cmd.Parameters["idRol"].Value = this.rol;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar1()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarUsuario1", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("Usuario", SqlDbType.VarChar, 26));
                cmd.Parameters["usuario"].Value = this.usuario;
                cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.Int));
                cmd.Parameters["estado"].Value = Estado;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarUsuario", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("Usuario", SqlDbType.VarChar, 26));
                cmd.Parameters["usuario"].Value = this.usuario;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public static DataView GetDataView(int estado)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Acceso.Usuarios.id          as Código,
                                    Acceso.Usuarios.nombre      as Nombre, 
                                    Acceso.Usuarios.apellido    as Apellido, 
                                    Acceso.Usuarios.usuario     as Usuario
                            FROM Acceso.Usuarios
                            WHERE estado=" + estado + ";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Acceso.Usuarios");
                DataTable dt = ds.Tables["Acceso.Usuarios"];
                DataView dv = new DataView(dt,
                    "",
                    "Código",
                    DataViewRowState.Unchanged);
                return dv;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public static DataTable GetDataTableUsuarios()
        {
            DataTable dt = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "select usuario FROM Acceso.Usuarios";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
    }
}
