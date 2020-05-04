using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Restaurante.Clases
{
    class Pedidos
    {
        public int IdPedido { set; get; }
        public string Fecha { set; get; }
        public int IdMesa { set; get; }
        public string RTN { set; get; }
        public string Nombre { set; get; }
        public int IdMesero { set; get;}
        public int Estado { set; get; }
        public Pedidos() { }
        ~Pedidos() { }
        public Pedidos(string fecha, int idMesa, string rtn,string nombre, int idMesero)
        {
            Fecha = fecha;
            IdMesa = idMesa;
            RTN = rtn;
            Nombre = nombre;
            IdMesero = idMesero;

        }
        public Pedidos(int idPedido ,int estado)
        {
            IdPedido = idPedido;
            Estado = estado;
        }
        public Pedidos(int idPedido) { IdPedido = idPedido; }

        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarPedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("fecha", SqlDbType.NVarChar,19));
                cmd.Parameters["fecha"].Value = Fecha;
                cmd.Parameters.Add(new SqlParameter("idMesa", SqlDbType.Int));
                cmd.Parameters["idMesa"].Value = IdMesa;
                cmd.Parameters.Add(new SqlParameter("RTN", SqlDbType.NVarChar,14));
                cmd.Parameters["RTN"].Value = RTN;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar,50));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("idMesero", SqlDbType.Int));
                cmd.Parameters["idMesero"].Value = IdMesero;

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Pedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarPedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = IdPedido;
                //cmd.Parameters.Add(new SqlParameter("fecha", SqlDbType.NVarChar,19));
                //cmd.Parameters["fecha"].Value = Fecha;
                //cmd.Parameters.Add(new SqlParameter("idMesa", SqlDbType.Int));
                //cmd.Parameters["idMesa"].Value = IdMesa;
                //cmd.Parameters.Add(new SqlParameter("RTN", SqlDbType.NVarChar,14));
                //cmd.Parameters["RTN"].Value = RTN;
                //cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar,50));
                //cmd.Parameters["nombre"].Value = Nombre;
                //cmd.Parameters.Add(new SqlParameter("IdMesero", SqlDbType.Int));
                //cmd.Parameters["IdMesero"].Value = IdMesero;
                cmd.Parameters.Add(new SqlParameter("estado", SqlDbType.Int));
                cmd.Parameters["estado"].Value = Estado;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Pedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarPedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = IdPedido;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Pedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public static DataView GetDataView(int mesa)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.Pedidos.id                      as Código,
                                    Restaurante.Pedidos.NombreCliente           as Nombre
                            FROM Restaurante.Pedidos
                            WHERE Restaurante.Pedidos.estado=1 AND Restaurante.Pedidos.idMesa=" + mesa + ";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.Pedidos");
                DataTable dt = ds.Tables["Restaurante.Pedidos"];
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

        public static DataView GetDataView1(int mesa)
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.Pedidos.id                      as Código,
                                    Restaurante.Pedidos.NombreCliente           as Nombre
                            FROM Restaurante.Pedidos
                            WHERE Restaurante.Pedidos.estado=2 AND Restaurante.Pedidos.idMesa=" + mesa + ";";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                data.Fill(ds, "Restaurante.Pedidos");
                DataTable dt = ds.Tables["Restaurante.Pedidos"];
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

        public void ObtenerPedido(int id, int mesa)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT id,RTN,nombreCliente,idMesero,estado FROM Restaurante.Pedidos WHERE idMesa = " + mesa +" and id ="+id+" ;";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    RTN = dr.GetString(1);
                    Nombre = dr.GetString(2);
                    IdMesero = dr.GetInt32(3);
                   
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Producto", ex.Message), ex, "Clase_Pedido"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }
        public void ObtenerPedido2(int id,int estado)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT Max(id)FROM Restaurante.Pedidos WHERE idMesa =" +id + " and estado="+ estado+";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                        IdPedido = dr.GetInt32(0);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Producto", ex.Message), ex, "Clase_Pedido"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }

        public void ObtenerPedido1(int mesa, int fase)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT id,estado FROM Restaurante.Pedidos WHERE idMesa = " + mesa + " AND estado=" + fase + ";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    IdPedido = dr.GetInt32(0);
                    Estado = dr.GetInt32(4);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "No podemos obtener la informacion del Producto", ex.Message), ex, "Clase_Pedido"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }
    }
}
