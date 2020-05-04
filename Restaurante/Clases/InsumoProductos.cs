using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class InsumoProductos
    {
        public int IdInsumoProducto { set; get; }
        public int IdInsumo { set; get; }
        public int IdInventario { set; get; }
        public decimal Cantidad { set; get; }
        public string Nombre { set; get; }
        public InsumoProductos() { }
        ~InsumoProductos() { }

        public InsumoProductos(int idinsumo, int idinventario, decimal cantidad)
        {
            IdInsumo = idinsumo;
            IdInventario = idinventario;
            Cantidad = cantidad;
        }

        public InsumoProductos(int idinsumoproducto, int idinsumo, int idinventario, decimal cantidad)
        {
            IdInsumoProducto = idinsumoproducto;
            IdInsumo = idinsumo;
            IdInventario = idinventario;
            Cantidad = cantidad;
        }

        public InsumoProductos(int idinsumoproducto, int idInventario)
        {
            IdInsumoProducto = idinsumoproducto;
            IdInventario = idInventario;
        }

        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarInsumosProductos", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = IdInsumo;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Decimal));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_InsumosProductos");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarInsumosProductos", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumoProducto", SqlDbType.Int));
                cmd.Parameters["idInsumoProducto"].Value = IdInsumoProducto;
                cmd.Parameters.Add(new SqlParameter("idInsumo", SqlDbType.Int));
                cmd.Parameters["idInsumo"].Value = IdInsumo;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Decimal));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_InsumosProductos");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarInsumosProductos", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idInsumoProducto", SqlDbType.Int));
                cmd.Parameters["idInsumoProducto"].Value = IdInsumoProducto;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_InsumosProductos");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void ObtenerInsumosProductos(int id)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT IP.idInsumoProducto, IP.idInsumo, IP.idInventario, IP.cantidad, I.nombre FROM Restaurante.InsumosProductos AS IP 
                           INNER JOIN Restaurante.Insumos AS I ON IP.idInsumo = I.idInsumo
                            WHERE IP.idInsumoProducto = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdInsumoProducto = dr.GetInt32(0);
                    IdInsumo = dr.GetInt32(1);
                    IdInventario = dr.GetInt32(2);
                    Cantidad = dr.GetDecimal(3);
                    Nombre = dr.GetString(4);
                }
            }
            catch (Exception ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Producto", ex.Message), ex, "Clase_InsumosProductos"); ;
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public static DataView GetDataView(int IdInventario)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            //string sql = @"SELECT   Restaurante.InsumosProductos.idInsumoProducto    as Código,
            //                        Restaurante.InsumosProductos.idInsumo            as Insumo,
            //                        Restaurante.InsumosProductos.idInventario        as Producto,
            //                        Restaurante.InsumosProductos.cantidad            as Cantidad
            //                FROM Restaurante.InsumosProductos
            //                WHERE idInventario = '" + IdInventario + "'; ";

            string sql = @"SELECT  Restaurante.InsumosProductos.idInsumoProducto    as Código,
                                    Restaurante.Insumos.nombre                       as Insumo,
                                    Restaurante.Inventario.descripcion               as Producto,
                                    Restaurante.InsumosProductos.cantidad            as Cantidad
                             FROM Restaurante.Inventario
                             INNER JOIN Restaurante.InsumosProductos
                             ON Restaurante.Inventario.idInventario = Restaurante.InsumosProductos.idInventario
                             INNER JOIN Restaurante.Insumos
                             ON Restaurante.Insumos.idInsumo = Restaurante.InsumosProductos.idInsumo
                             WHERE Restaurante.InsumosProductos.idInventario = '" + IdInventario + "'; ";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.InsumosProductos");
                DataTable dt = ds.Tables["Restaurante.InsumosProductos"];
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
