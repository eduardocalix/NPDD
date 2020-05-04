using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class CategoriaProducto
    {
        public int Id { set; get; }
        public string Descripcion { set; get; }
        public int Estado { get; set; }
        public CategoriaProducto() { }
        ~CategoriaProducto() { }

        public CategoriaProducto(string descripcion)
        {
            Descripcion = descripcion;
        }

        public CategoriaProducto(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }

        public CategoriaProducto(int id)
        {
            Id = id;
        }
        public CategoriaProducto(int id, int estado)
        {
            Id = id;
            Estado = estado;
        }

        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarCategoriaProducto", conexion.conexion);
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
                throw new Clases.Excepcion(ex.Message, ex, "Clase_CategoriaProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarCategoriaProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idCategoriaProducto", SqlDbType.Int));
                cmd.Parameters["idCategoriaProducto"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 100));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_CategoriaProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarCategoriaProducto", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
                cmd.Parameters["idCategoria"].Value = Id;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_CategoriaProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Eliminar1()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarCategoriaProducto1", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idCategoria", SqlDbType.Int));
                cmd.Parameters["idCategoria"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.Int));
                cmd.Parameters["estado"].Value = Estado;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_CategoriaProducto");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerCategoriaProducto(int id)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT idCategoria, descripcion FROM Restaurante.CategoriaProducto WHERE idCategoria = '" + id + "';";
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
                   "no podemos obtener la informacion de la Categoría del Producto", ex.Message), ex, "Clase_Categorias"); ;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public static DataView GetDataView(int estado)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.CategoriaProducto.idCategoria     as Código,
                                    Restaurante.CategoriaProducto.descripcion     as Descripción
                            FROM Restaurante.CategoriaProducto
                            WHERE Restaurante.CategoriaProducto.estado=" + estado + ";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.CategoriaProducto");
                DataTable dt = ds.Tables["Restaurante.CategoriaProducto"];
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

        public void ObtenerCategoriaProductoPorNombre(string nombreCategoria)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT idCategoria, descripcion FROM Restaurante.CategoriaProducto WHERE descripcion = '" + nombreCategoria + "';";
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
                   "no podemos obtener la informacion de la Categoria del Producto", ex.Message), ex, "Clase_CategoriaProducto"); ;
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public static DataView GetDataView1()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.CategoriaProducto.idCategoria     as Código,
                                    Restaurante.CategoriaProducto.descripcion     as Descripción
                            FROM Restaurante.CategoriaProducto
                            WHERE estado = 1 and idCategoria>3";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.CategoriaProducto");
                DataTable dt = ds.Tables["Restaurante.CategoriaProducto"];
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
    
    }
}
