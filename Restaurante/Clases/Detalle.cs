using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Detalle
    {
        public int IdDetallePedido { set; get; }
        public int IdPedido { set; get; }
        public int IdInventario { set; get; }
        public int Cantidad { set; get; }
        public decimal SubTotal { set; get; }
        public int Estado { set; get; }
        

        public Detalle() { }
        ~Detalle() { }
        public Detalle(int idPedido, int idInventario, int cantidad,decimal subTotal)
        {
            IdPedido = idPedido;
            IdInventario = idInventario;
            Cantidad = cantidad;
            SubTotal = subTotal;
        }
        public Detalle(int idDetallePedido, int estado)
        {
            IdDetallePedido = idDetallePedido;
            Estado = estado;
        }
        public Detalle(int idDetallePedido) { IdDetallePedido = idDetallePedido; }
        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarDetallePedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idPedido", SqlDbType.Int));
                cmd.Parameters["idPedido"].Value = IdPedido;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Int));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.Parameters.Add(new SqlParameter("subTotal", SqlDbType.Decimal));
                cmd.Parameters["subTotal"].Value = SubTotal;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_DetallePedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarDetallePedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idDetalle", SqlDbType.Int));
                cmd.Parameters["idDetalle"].Value = IdDetallePedido;
                //cmd.Parameters.Add(new SqlParameter("idPedido", SqlDbType.Int));
                //cmd.Parameters["idPedido"].Value = IdPedido;
                //cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                //cmd.Parameters["idInventario"].Value = IdInventario;
                //cmd.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Int));
                //cmd.Parameters["Cantidad"].Value = Cantidad;
                //cmd.Parameters.Add(new SqlParameter("subTotal", SqlDbType.Decimal));
                //cmd.Parameters["subTotal"].Value = SubTotal;
                cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.Int));
                cmd.Parameters["estado"].Value = Estado;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_DetallePedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarDetallePedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idDetalle", SqlDbType.Int));
                cmd.Parameters["idDetalle"].Value = IdDetallePedido;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_DetallePedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public static DataView GetDataView(int id)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.DetallePedidos.idDetallePedido                  as id,
                                    Restaurante.Inventario.descripcion                          as Nombre,
                                    Restaurante.DetallePedidos.cantidad                         as Cantidad
                            FROM Restaurante.Inventario
                            INNER JOIN Restaurante.DetallePedidos 
                            ON Restaurante.Inventario.idInventario = Restaurante.DetallePedidos.idInventario 
                            INNER JOIN Restaurante.Pedidos
                            ON Restaurante.DetallePedidos.idPedido = Restaurante.Pedidos.id
                            and Restaurante.Inventario.idCategoria >= 3
							and Restaurante.DetallePedidos.estado = 1
                            and Restaurante.Pedidos.id =" + id+";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.DetallePedidos");
                DataTable dt = ds.Tables["Restaurante.DetallePedidos"];
                DataView dv = new DataView(dt,
                    "",
                    "id",
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
        public static DataView GetDataView1(int id)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.DetallePedidos.idDetallePedido                  as id,
                                    Restaurante.Inventario.descripcion                          as Nombre,
                                    Restaurante.DetallePedidos.cantidad                         as Cantidad,
                                    Restaurante.DetallePedidos.subTotal                         as importe,
                                    Restaurante.Inventario.idCategoria                          as C
                            FROM Restaurante.Inventario
                            INNER JOIN Restaurante.DetallePedidos 
                            ON Restaurante.Inventario.idInventario = Restaurante.DetallePedidos.idInventario       
                            INNER JOIN Restaurante.Pedidos
                            ON Restaurante.DetallePedidos.idPedido = Restaurante.Pedidos.id
                            and Restaurante.Pedidos.id=" + id+ ";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.DetallePedidos");
                DataTable dt = ds.Tables["Restaurante.DetallePedidos"];
                DataView dv = new DataView(dt,
                    "",
                    "Nombre",
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
