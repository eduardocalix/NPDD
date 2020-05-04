using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class Insumos
    {

        public int Id { set; get; }
        public string Nombre { set; get; }
        public decimal Costo { set; get; }
        public decimal Cantidad { set; get; }
        public decimal CantidadMinima { set; get; }
        public int IdTipoUnidad { set; get; }
        public string Descripcion { set; get; }
        public int IdProveedor { set; get; }
        public int Estado { get; set; }

        ~Insumos() { }

        public Insumos(int id, string nombre, decimal costo, decimal cantidad, decimal cantidadminima, int idtipounidad, string descripcion, int proveedor)
        {
            Id = id;
            Nombre = nombre;
            Costo = costo;
            Cantidad = cantidad;
            CantidadMinima = cantidadminima;
            IdTipoUnidad = idtipounidad;
            Descripcion = descripcion;
            IdProveedor = proveedor;
        }

        public Insumos(string nombre, decimal costo, decimal cantidad, decimal cantidadminima, int idtipounidad, string descripcion, int proveedor)
        {
            Nombre = nombre;
            Costo = costo;
            Cantidad = cantidad;
            CantidadMinima = cantidadminima;
            IdTipoUnidad = idtipounidad;
            Descripcion = descripcion;
            IdProveedor = proveedor;
        }

        public Insumos(int id)
        {
            Id = id;
        }
        public Insumos(int id, int estado)
        {
            Id = id;
            Estado = estado;
        }
        public Insumos()
        {

        }

        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarInsumo", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("costo", SqlDbType.Decimal));
                cmd.Parameters["costo"].Value = Costo;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Decimal));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.Parameters.Add(new SqlParameter("cantidadMinima", SqlDbType.Decimal));
                cmd.Parameters["cantidadMinima"].Value = CantidadMinima;
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = IdTipoUnidad;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 200));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = IdProveedor;

                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Insumo");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarInsumo", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 100));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("costo", SqlDbType.Decimal));
                cmd.Parameters["costo"].Value = Costo;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Decimal));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.Parameters.Add(new SqlParameter("cantidadMinima", SqlDbType.Decimal));
                cmd.Parameters["cantidadMinima"].Value = CantidadMinima;
                cmd.Parameters.Add(new SqlParameter("idTipoUnidad", SqlDbType.Int));
                cmd.Parameters["idTipoUnidad"].Value = IdTipoUnidad;
                cmd.Parameters.Add(new SqlParameter("descripcion", SqlDbType.NVarChar, 200));
                cmd.Parameters["descripcion"].Value = Descripcion;
                cmd.Parameters.Add(new SqlParameter("idProveedor", SqlDbType.Int));
                cmd.Parameters["idProveedor"].Value = IdProveedor;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Insumo");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarInsumo", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = Id;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Insumo");
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public void Eliminar1()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarInsumo1", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.Int));
                cmd.Parameters["estado"].Value = Estado;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Insumo");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerInsumo(int id)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT idInsumo, nombre, costo, cantidad, cantidadMinima, idTipoUnidad, descripcion, idProveedor FROM Restaurante.Insumos WHERE idInsumo = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Nombre = dr.GetString(1);
                    Costo = dr.GetDecimal(2);
                    Cantidad = dr.GetDecimal(3);
                    CantidadMinima = dr.GetDecimal(4);
                    IdTipoUnidad = dr.GetInt32(5);
                    Descripcion = dr.GetString(6);
                    IdProveedor = dr.GetInt32(7);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Insumo", ex.Message), ex, "Clase_Insumo"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public static DataView GetDataView(int estado)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.Insumos.idInsumo        as Código,
                                    Restaurante.Insumos.nombre          as Insumo,
                                    Restaurante.Insumos.costo           as Costo,
                                    Restaurante.Insumos.cantidad        as Cantidad,
                                    Restaurante.Insumos.cantidadMinima  as CantidadMin,
                                    Restaurante.TipoUnidad.descripcion  as Unidad,
                                    Restaurante.Insumos.descripcion     as Descripción,
                                    Restaurante.Proveedores.nombre      as Proveedor
                            FROM Restaurante.Proveedores
                            INNER JOIN Restaurante.Insumos
                            ON Restaurante.Proveedores.idProveedor = Restaurante.Insumos.idProveedor
                            INNER JOIN Restaurante.TipoUnidad
                            ON Restaurante.TipoUnidad.idTipoUnidad = Restaurante.Insumos.idTipoUnidad
                            AND Restaurante.Insumos.estado=" + estado + ";";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.Insumos");
                DataTable dt = ds.Tables["Restaurante.Insumos"];
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


        public static DataView GetDataViewInsumo(string descripcion)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.Insumos.idInsumo        as Código,
                                    Restaurante.Insumos.nombre          as Insumo,
                                    Restaurante.Insumos.costo           as Costo,
                                    Restaurante.Insumos.cantidad        as Cantidad,
                                    Restaurante.TipoUnidad.descripcion  as Unidad
                            FROM Restaurante.TipoUnidad
                            INNER JOIN Restaurante.Insumos
                            ON Restaurante.TipoUnidad.idTipoUnidad = Restaurante.Insumos.idTipoUnidad
                            WHERE nombre = '" + descripcion + "'; ";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.Insumos");
                DataTable dt = ds.Tables["Restaurante.Insumos"];
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
