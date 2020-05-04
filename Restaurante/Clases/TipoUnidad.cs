using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Restaurante.Clases
{
    class TipoUnidad
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public int Estado { get; set; }
        public TipoUnidad() { }
        ~TipoUnidad() { }

        public TipoUnidad(string descripcion)
        {
            Descripcion = descripcion;
        }

        public TipoUnidad(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public TipoUnidad(int id)
        {
            Id = id;
        }
        public TipoUnidad(int id,int estado)
        {
            Id = id;
            Estado = estado;
        }

        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_InsertarTipoUnidad", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_TipoUnidad");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarTipoUnidad1", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_TipoUnidad");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarTipoUnidad", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = Id;
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
            SqlCommand cmd = new SqlCommand("SP_EliminarTipoUnidad", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = Id;
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

        public void ObtenerTipoUnidad(int id)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT idTipoUnidad, descripcion FROM Restaurante.TipoUnidad WHERE idTipoUnidad = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Descripcion = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Tipo de Unidad", ex.Message), ex, "Clase_TipoUnidad"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public static DataView GetDataView(int estado)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.TipoUnidad.idTipoUnidad     as Código,
                                    Restaurante.TipoUnidad.descripcion      as Descripción
                            FROM Restaurante.TipoUnidad
                            WHERE estado=" + estado + ";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.TipoUnidad");
                DataTable dt = ds.Tables["Restaurante.TipoUnidad"];
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

        public void ObtenerTipoUnidadPorNombre(string nombreTipoUnidad)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT idTipoUnidad, descripcion FROM Restaurante.TipoUnidad WHERE descripcion = '" + nombreTipoUnidad + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Descripcion = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Tipo de Unidad", ex.Message), ex, "Clase_TipoUnidad"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }
    }
}
