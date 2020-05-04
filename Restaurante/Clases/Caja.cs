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
    class Caja
    { 
        //Propiedades
        public int Id { get; set; }
        public decimal Apertura { get; set; }
        public decimal Cierre { get; set; }
        public int Dolares { get; set; }
        public decimal Pos { get; set; }
        public int Fiveh { get; set; }
        public int Hundred { get; set; }
        public int Fifty { get; set; }
        public int Twenty { get; set; }
        public int Ten { get; set; }
        public int Five { get; set; }
        public int Two { get; set; }
        public int One { get; set; }
        public string Fecha { get; set; }
        public int DetalleCaja { get; set; }
        public string Usuario {get; set; }

        //Constructor Vacio
        public Caja() { }

        //Destructor
        ~Caja() { }

        //Constructores
        public Caja(decimal apertura, int dolares, int fiveh,
                    int hundred, int fifty, int twenty, int ten, int five, int two, int one, string usuario)
        {
            Apertura = apertura;
            Dolares = dolares;
            Fiveh = fiveh;
            Hundred = hundred;
            Fifty = fifty;
            Twenty = twenty;
            Ten = ten;
            Five = five;
            Two = two;
            One = one;
            Usuario = usuario;
        }

        public Caja(decimal cierre, int dolares, decimal pos, int fiveh,
                    int hundred, int fifty, int twenty, int ten, int five, int two, int one, string usuario)
        {
            Cierre = cierre;
            Dolares = dolares;
            Pos = pos;
            Fiveh = fiveh;
            Hundred = hundred;
            Fifty = fifty;
            Twenty = twenty;
            Ten = ten;
            Five = five;
            Two = two;
            One = one;
            Usuario = usuario;
        }

        /// <summary>
        /// Insercion de la Apertura de Caja.
        /// </summary>
        public void AgregarApertura()
        {
            Clases.Conexión conexión = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_Agregar_AperturaCaja", conexión.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                //Abrir Conexion
                conexión.Abrir();
                cmd.Parameters.Add(new SqlParameter("Apertura", SqlDbType.Decimal));
                cmd.Parameters["Apertura"].Value = Apertura;
                cmd.Parameters.Add(new SqlParameter("Dolares", SqlDbType.Int));
                cmd.Parameters["Dolares"].Value = Dolares;
                cmd.Parameters.Add(new SqlParameter("Fiveh", SqlDbType.Int));
                cmd.Parameters["Fiveh"].Value = Fiveh;
                cmd.Parameters.Add(new SqlParameter("Hundred", SqlDbType.Int));
                cmd.Parameters["Hundred"].Value = Hundred;
                cmd.Parameters.Add(new SqlParameter("Fifty", SqlDbType.Int));
                cmd.Parameters["Fifty"].Value = Fifty;
                cmd.Parameters.Add(new SqlParameter("Twenty", SqlDbType.Int));
                cmd.Parameters["Twenty"].Value = Twenty;
                cmd.Parameters.Add(new SqlParameter("Ten", SqlDbType.Int));
                cmd.Parameters["Ten"].Value = Ten;
                cmd.Parameters.Add(new SqlParameter("Five", SqlDbType.Int));
                cmd.Parameters["Five"].Value = Five;
                cmd.Parameters.Add(new SqlParameter("Two", SqlDbType.Int));
                cmd.Parameters["Two"].Value = Two;
                cmd.Parameters.Add(new SqlParameter("One", SqlDbType.Int));
                cmd.Parameters["One"].Value = One;
                cmd.Parameters.Add(new SqlParameter("User", SqlDbType.NVarChar));
                cmd.Parameters["User"].Value = Usuario;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                //Cerrar conexion
                conexión.Cerrar();
            }
        }
        /// <summary>
        /// Insercion del Cierre de Caja.
        /// </summary>
        public void AgregarCierre()
        {
            Clases.Conexión conexión = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_Agregar_CierreCaja", conexión.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexión.Abrir();
                cmd.Parameters.Add(new SqlParameter("Cierre", SqlDbType.Decimal));
                cmd.Parameters["Cierre"].Value = Cierre;
                cmd.Parameters.Add(new SqlParameter("Dolares", SqlDbType.Int));
                cmd.Parameters["Dolares"].Value = Dolares;
                cmd.Parameters.Add(new SqlParameter("POS", SqlDbType.Decimal));
                cmd.Parameters["POS"].Value = Pos;
                cmd.Parameters.Add(new SqlParameter("Fiveh", SqlDbType.Int));
                cmd.Parameters["Fiveh"].Value = Fiveh;
                cmd.Parameters.Add(new SqlParameter("Hundred", SqlDbType.Int));
                cmd.Parameters["Hundred"].Value = Hundred;
                cmd.Parameters.Add(new SqlParameter("Fifty", SqlDbType.Int));
                cmd.Parameters["Fifty"].Value = Fifty;
                cmd.Parameters.Add(new SqlParameter("Twenty", SqlDbType.Int));
                cmd.Parameters["Twenty"].Value = Twenty;
                cmd.Parameters.Add(new SqlParameter("Ten", SqlDbType.Int));
                cmd.Parameters["Ten"].Value = Ten;
                cmd.Parameters.Add(new SqlParameter("Five", SqlDbType.Int));
                cmd.Parameters["Five"].Value = Five;
                cmd.Parameters.Add(new SqlParameter("Two", SqlDbType.Int));
                cmd.Parameters["Two"].Value = Two;
                cmd.Parameters.Add(new SqlParameter("One", SqlDbType.Int));
                cmd.Parameters["One"].Value = One;
                cmd.Parameters.Add(new SqlParameter("User", SqlDbType.NVarChar));
                cmd.Parameters["User"].Value = Usuario;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                conexión.Cerrar();
            }
        }

        /// <summary>
        /// Se carga el DataView General (con todos los registros del movimiento de Caja).
        /// </summary>
        /// <returns>dv</returns>
        public static DataView GetDataViewGeneral()
        {
            Clases.Conexión conexión = new Clases.Conexión();
            string sql = @" SELECT Restaurante.DetalleCaja.Descripcion	 AS Descripcion,
	                               Restaurante.Caja.Monto			     AS Monto,
	                               Restaurante.Caja.fecha                AS Fecha,
	                               Restaurante.Caja.Usuario				 AS Usuario
                            FROM Restaurante.Caja
                            INNER JOIN Restaurante.DetalleCaja
                            ON Restaurante.Caja.idDetalleCaja = Restaurante.DetalleCaja.id
                            WHERE Restaurante.Caja.fecha >= (SELECT MAX(fecha) FROM Restaurante.Caja WHERE idDetalleCaja = 1)
                            UNION
                            SELECT Restaurante.ServicioPublico.Descripcion		   AS Descripcion,
	                               Restaurante.DetalleServicioPublico.Monto		   AS Monto,
	                               Restaurante.DetalleServicioPublico.Fecha	       AS Fecha,
	                               Restaurante.DetalleServicioPublico.Usuario      AS Fecha
                            FROM Restaurante.ServicioPublico
                            INNER JOIN Restaurante.DetalleServicioPublico
                            ON Restaurante.ServicioPublico.id = Restaurante.DetalleServicioPublico.idServicioPublico
                            WHERE Restaurante.DetalleServicioPublico.Fecha > (SELECT MAX(fecha) FROM Restaurante.Caja WHERE idDetalleCaja = 1)
                            UNION
                            SELECT Descripcion		  AS Usuario,
	                               Monto			  AS Descripcion,
	                               Fecha			  AS Fecha,
	                               Usuario			  AS Usuario
                            FROM Restaurante.OtrasSalidas
                            WHERE Restaurante.OtrasSalidas.Fecha > (SELECT MAX(fecha) FROM Restaurante.Caja WHERE idDetalleCaja = 1)
                            ORDER BY Fecha, Usuario, Descripcion, Monto ";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conexión.conexion);
                System.Data.DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "Restaurante.Caja");
                DataTable dt = ds.Tables["Restaurante.Caja"];
                DataView dv = new DataView(dt, "", "Descripcion", DataViewRowState.Unchanged);
                return dv;
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                conexión.Cerrar();
            }
        }

        //Se captura el Monto de la ultima Apertura o Cierre.
        public static void saldoUltimo(TextBox text)
        {
            Clases.Conexión conn = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand(@"Select Monto FROM Restaurante.Caja WHERE
                                              fecha = (SELECT MAX(fecha) FROM Restaurante.Caja)", conn.conexion);
            try
            {
                conn.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    text.Text = Convert.ToString(dr["Monto"]);
                }
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

        //public static void saldoUltimaApertura(TextBox text)
        //{
        //    Clases.Conexión conn = new Clases.Conexión();
        //    SqlCommand cmd = new SqlCommand(@"Select Monto FROM Restaurante.Caja WHERE idDetalleCaja = 1 and 
        //                                      fecha = (SELECT MAX(fecha) FROM Restaurante.Caja)", conn.conexion);
        //    try
        //    {
        //        conn.Abrir();
        //        SqlDataReader dr = cmd.ExecuteReader();
        //        if (dr.Read())
        //        {
        //            text.Text = Convert.ToString(dr["Monto"]);
        //        }
        //    }
        //    catch (SqlException ex)
        //    {
        //        throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
        //    }
        //    finally
        //    {
        //        conn.Cerrar();
        //    }

        //}
    }
}
