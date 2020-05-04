using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class TipoProducto
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public TipoProducto() { }
        ~TipoProducto() { }

        public TipoProducto(string nombre)
        {
            Nombre = nombre;
        }

        public TipoProducto(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
        public TipoProducto(int id)
        {
            Id = id;
        }

        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_InsertarTipoProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_TipoProducto");
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarTipoProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idTipoProducto", SqlDbType.Int));
                cmd.Parameters["idTipoProducto"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_TipoProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarTipoProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idTipoProducto", SqlDbType.Int));
                cmd.Parameters["idTipoProducto"].Value = Id;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_TipoProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerTipoProducto(int id)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT idTipoProducto, nombre FROM Restaurante.TipoProducto WHERE idTipoProducto = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Tipo de Producto", ex.Message), ex, "Clase_TipoProducto"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public static DataView GetDataView(int estado)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.TipoProducto.idTipoProducto     as Código,
                                    Restaurante.TipoProducto.nombre             as Descripción
                            FROM Restaurante.TipoProducto
                            WHERE estado=" + estado + ";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.TipoProducto");
                DataTable dt = ds.Tables["Restaurante.TipoProducto"];
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

        public void ObtenerTipoProductoPorNombre(string nombreTipoProducto)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT idTipoProducto, nombre FROM Restaurante.TipoProducto WHERE nombre = '" + nombreTipoProducto + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Tipo de Producto", ex.Message), ex, "Clase_TipoProducto"); ;
            }
            finally
            {
                conexion.Cerrar();
            }


        }
    }
}
