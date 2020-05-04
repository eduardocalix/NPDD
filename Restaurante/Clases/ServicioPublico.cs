using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class ServicioPublico
    {
        //Propiedades
        public string NombreServicioPublico { get; set; }
        public decimal Monto { get; set; }
        public string Usuario { get; set; }

        //Constructor vacio
        public ServicioPublico() { }

        //Destructor
        ~ServicioPublico() { }

        //Constructores
        public ServicioPublico(string nombreServicioPublico, decimal monto, string usuario)
        {
            NombreServicioPublico = nombreServicioPublico;
            Monto = monto;
            Usuario = usuario;
        }

        public ServicioPublico(string descripcion)
        {
            NombreServicioPublico = descripcion;
        }

        /// <summary>
        /// Insercion de los Pagos de Servicios Publicos.
        /// </summary>
        public void AgregarPagoServicioPublico()
        {
            Clases.Conexión conn = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_InsertarPago_ServicioPublico", conn.conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Abrir();
                cmd.Parameters.Add(new SqlParameter("ServicioPublico", SqlDbType.NVarChar, 50));
                cmd.Parameters["ServicioPublico"].Value = NombreServicioPublico;
                cmd.Parameters.Add(new SqlParameter("Monto", SqlDbType.Decimal));
                cmd.Parameters["Monto"].Value = Monto;
                cmd.Parameters.Add(new SqlParameter("Usuario", SqlDbType.NVarChar, 20));
                cmd.Parameters["Usuario"].Value = Usuario;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                //Cerrar conexion
                conn.Cerrar();
            }
        }

        /// <summary>
        /// Se hace el filtro de Servicios Publicos en el GridView de Resumen de Caja.
        /// </summary>
        /// <returns>dv</returns>
        public static DataView GetDataView()
        {
            Clases.Conexión conn = new Clases.Conexión();
            string sql = @"SELECT Restaurante.ServicioPublico.Descripcion, 
	                              Restaurante.DetalleServicioPublico.Monto, 
	                              Restaurante.DetalleServicioPublico.Fecha,
	                              Restaurante.DetalleServicioPublico.Usuario
                           FROM Restaurante.DetalleServicioPublico
                           INNER JOIN Restaurante.ServicioPublico
                           ON Restaurante.DetalleServicioPublico.idServicioPublico = Restaurante.ServicioPublico.id
                              WHERE Restaurante.DetalleServicioPublico.Fecha > 
	                                (SELECT MAX(fecha) FROM Restaurante.Caja WHERE idDetalleCaja = 1)";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "Restaurante.DetalleServicioPublico");
                DataTable dt = ds.Tables["Restaurante.DetalleServicioPublico"];
                DataView dv = new DataView(dt, "", "Descripcion", DataViewRowState.Unchanged);
                return dv;
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                conn.Cerrar();
            }
        } 
    }
}
