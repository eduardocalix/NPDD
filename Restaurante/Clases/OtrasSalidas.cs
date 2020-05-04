using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Restaurante.Clases
{
    class OtrasSalidas
    {
        //Propiedades
        public string Descripcion { get; set; }
        public decimal Monto { get; set; }
        public string Usuario { get; set; }

        //Constructor vacio
        public OtrasSalidas() { }

        //Destructor
        ~OtrasSalidas() { }

        //Constructor
        public OtrasSalidas(string descripcionSalida, decimal monto, string usuario)
        {
            Descripcion = descripcionSalida;
            Monto = monto;
            Usuario = usuario;
        }

        /// <summary>
        /// Insercion de las Salidas Varias.
        /// </summary>
        public void AgregarOtraSalida()
        {
            Clases.Conexión conn = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_InsertarPago_OtrasSalidas", conn.conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                conn.Abrir();
                cmd.Parameters.Add(new SqlParameter("Descripcion", SqlDbType.NVarChar, 200));
                cmd.Parameters["Descripcion"].Value = Descripcion;
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
        }

        //Se hace la filtracion de las Salidas Varias en el DataView de Resumen de Caja
        public static DataView GetDataView()
        {
            Clases.Conexión conn = new Clases.Conexión();
            string sql = @"SELECT Descripcion, Monto, Fecha, Usuario
                           FROM Restaurante.OtrasSalidas";

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conn.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "Restaurante.OtrasSalidas");
                DataTable dt = ds.Tables["Restaurante.OtrasSalidas"];
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
