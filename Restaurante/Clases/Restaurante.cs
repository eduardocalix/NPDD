using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Clases
{
    class Restaurante
    {
        //Se establece el constructor de la clase Restaurante
        public Restaurante() { }
        //Excepcion para modulo de mesero
        private static void ValidarMesero
            (
            string identidad,
            string nombre,
            string apellido
            )
        {
            if (identidad.Length != 15 || nombre.Length == 0 || apellido.Length == 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar el mesero. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar a el mesero:\n" +
                    "Identidad: 1234-1234-12345\n" +
                    "Nombre   : Pedro\n" +
                    "Apellido : Picapiedra",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }
        public static void AgregarMesero
            (
            string identidad,
            string nombre,
            string apellido
            )
        {
            try
            {
                ValidarMesero(identidad, nombre, apellido);
                Clases.Mesero mesero = new Clases.Mesero(
                    identidad,
                    nombre,
                    apellido
                    );
                mesero.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarMesero(
            int id,
            string identidad,
            string nombre,
            string apellido)
        {
            try
            {
                ValidarMesero(identidad, nombre, apellido);
                Clases.Mesero mesero = new Clases.Mesero(
                    id,
                    identidad,
                    nombre,
                   apellido);
                mesero.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void EliminarMesero(int id)
        {
            try
            {
                Clases.Mesero mesero = new Clases.Mesero(id);
                mesero.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarMesero1(int id,int estado)
        {
            try
            {
                Clases.Mesero mesero = new Clases.Mesero(id,estado);
                mesero.Eliminar1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private static void ValidarUsuarios
    (
    string nombre,
    string apellido,
    string clave
    )
        {
            if (apellido.Length == 0 || nombre.Length == 0 || clave.Length == 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar el usuario \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un usuario:\n" +
                    "Nombre   : Pedro\n" +
                    "Apellido  :  Picapiedra\n" +
                    "Clave : yabadabadu",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }
        public static void AgregarUsuario(
            string nombre,
            string apellido,
            string clave)
        {
            try
            {
                ValidarUsuarios(nombre, apellido, clave);
                Clases.Usuarios usuario = new Clases.Usuarios(
                    nombre,
                    apellido,
                    clave,
                    1
                    );
                usuario.Agregar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void ModificarUsuario(
            string usu,
            string nombre,
            string apellido,
            string clave)
        {
            try
            {
                ValidarUsuarios(nombre, apellido, clave);
                Clases.Usuarios usuario = new Clases.Usuarios(
                    usu,
                    nombre,
                    apellido,
                    clave,
                    1
                    );
                usuario.Modificar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static void EliminarUsuario(string usu)
        {
            try
            {
                Clases.Usuarios usuarios = new Clases.Usuarios(usu);
                usuarios.Eliminar();
            }
            catch (Exception es)
            {

                throw es;
            }
        }
        public static void EliminarUsuario1(string usu, int estado)
        {
            try
            {
                Clases.Usuarios usuarios = new Clases.Usuarios(usu,estado);
                usuarios.Eliminar1();
            }
            catch (Exception es)
            {

                throw es;
            }
        }

        //Modulo proveedor
        private static void ValidarProveedor
    (
    string nombre,
    string telefono,
    string direccion
    )
        {
            if (telefono.Length != 9 || nombre.Length == 0 || direccion.Length == 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar un proveedor. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un proveedor:\n" +
                    "Nombre   : Pedro\n" +
                    "Telefono  :  9898-9678\n" +
                    "Direccion : Piedra dura",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }

        public static void AgregarProveedor(string nombre, string telefono, string direccion)
        {
            try
            {
                ValidarProveedor(nombre, telefono, direccion);
                Clases.Proveedores proveedor = new Clases.Proveedores(
                    nombre,
                    telefono,
                    direccion
                    );
                proveedor.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void ModificarProveedor(int id, string nombre, string telefono, string direccion)
        {
            try
            {
                ValidarProveedor(nombre, telefono, direccion);
                Clases.Proveedores proveedor = new Clases.Proveedores(
                    id,
                    nombre,
                    telefono,
                    direccion);
                proveedor.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarProveedor(int id)
        {
            try
            {
                Clases.Proveedores proveedor = new Clases.Proveedores(
                    id);
                proveedor.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarProveedor1(int id,int estado)
        {
            try
            {
                Clases.Proveedores proveedor = new Clases.Proveedores(
                    id,estado);
                proveedor.Eliminar1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarTipoUnidad
         (
            string descripcion

         )
        {
            if (descripcion.Length == 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar un Tipo de Unidad. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un tipo de unidad:\n" +
                    "Descripción   : libras\n",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }

        public static void AgregarTipoUnidad
            (
            string descripcion
            )
        {
            try
            {
                ValidarTipoUnidad(descripcion);
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad(
                    descripcion
                    );
                tipounidad.Agregar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarTipoUnidad
            (
            int id,
            string descripcion
            )
        {
            try
            {
                ValidarTipoUnidad(descripcion);
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad(
                    id,
                    descripcion
                    );
                tipounidad.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarTipoUnidad
            (
            int id
            )
        {
            try
            {
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad(
                     id
                     );
                tipounidad.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarTipoUnidad1
     (
     int id,int estado
     )
        {
            try
            {
                Clases.TipoUnidad tipounidad = new Clases.TipoUnidad(
                     id,estado
                     );
                tipounidad.Eliminar1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarInsumo
                (
                string nombre,
                decimal costo,
                decimal cantidad,
                decimal cantidadminima,
                int idtipounidad,
                string descripcion,
                int idproveedor
                )
        {
            if (nombre.Length == 0 || costo < 0 || cantidad < 0 || cantidadminima < 0 || idtipounidad <= 0 || descripcion.Length == 0 || idproveedor <= 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar el insumo. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el insumo\n" +
                    "Nombre   : Tomate\n" +
                    "Costo    : 12.00\n" +
                    "Cantidad : 12.00\n" +
                    "Cantidad Minima    : 2.00\n" +
                    "Unidad   : Libra\n" +
                    "Descripción   : Comprado Semanalmente\n" +
                    "Proveedor : Don Edgardo",
                    new Exception(),
                    "Clase_Insumo"
                    );
            }
        }
        public static void AgregarInsumo
            (
            string nombre,
            decimal costo,
            decimal cantidad,
            decimal cantidadminima,
            int idtipounidad,
            string descripcion,
            int idproveedor
            )
        {
            try
            {
                ValidarInsumo(nombre, costo, cantidad, cantidadminima, idtipounidad, descripcion, idproveedor);
                Clases.Insumos insumo = new Clases.Insumos(
                    nombre,
                    costo,
                    cantidad,
                    cantidadminima,
                    idtipounidad,
                    descripcion,
                    idproveedor
                    );
                insumo.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarInsumo
            (
            int id,
            string nombre,
            decimal costo,
            decimal cantidad,
            decimal cantidadminima,
            int idtipounidad,
            string descripcion,
            int idproveedor
            )
        {
            try
            {
                ValidarInsumo(nombre, costo, cantidad, cantidadminima, idtipounidad, descripcion, idproveedor);
                Clases.Insumos insumo = new Clases.Insumos(
                    id,
                    nombre,
                    costo,
                    cantidad,
                    cantidadminima,
                    idtipounidad,
                    descripcion,
                    idproveedor)
                    ;
                insumo.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarInsumo
            (
            int id
            )
        {
            try
            {
                Clases.Insumos insumo = new Clases.Insumos(
                    id
                    );
                insumo.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarInsumo1( int id,int estado   )
        {
            try
            {
                Clases.Insumos insumo = new Clases.Insumos(
                    id,estado
                    );
                insumo.Eliminar1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static void ValidarInventario
                (
                string descripcion,
                decimal costo,
                decimal precioventa,
                decimal cantidad,
                decimal cantidadminima,
                int idcategoria,
                int idtipoproducto,
                int idproveedor
                )
        {
            if (descripcion.Length == 0 || costo < 0 || precioventa < 0 || cantidad < 0 || cantidadminima < 0 || idcategoria < 0 || idtipoproducto < 0 || idproveedor < 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar el Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el Inventario\n" +
                    "Producto : Pescado Frito\n" +
                    "Costo    : 80.00\n" +
                    "Precio Venta   : 100.00\n" +
                    "Cantidad   : 20\n" +
                    "Cantidad Min   : 10\n" +
                    "Categoria   : Plato\n" +
                    "Tipo Producto : Elaborado\n" +
                    "Proveedor : Don Edgardo",
                    new Exception(),
                    "Clase_Inventario"
                    );
            }
        }

        public static void AgregarInventario
            (
            string descripcion,
            decimal costo,
            decimal precioventa,
            decimal cantidad,
            decimal cantidadminima,
            int idcategoria,
            int idtipoproducto,
            int idproveedor
            )
        {
            try
            {
                ValidarInventario(descripcion, costo, precioventa, cantidad, cantidadminima, idcategoria, idtipoproducto, idproveedor);
                Clases.Inventario inventario = new Clases.Inventario(
                    descripcion,
                    costo,
                    precioventa,
                    cantidad,
                    cantidadminima,
                    idcategoria,
                    idtipoproducto,
                    idproveedor);
                inventario.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarInventario
            (
            int id,
            string descripcion,
            decimal costo,
            decimal precioventa,
            decimal cantidad,
            decimal cantidadminima,
            int idcategoria,
            int idtipoproducto,
            int idproveedor
            )
        {
            try
            {
                ValidarInventario(descripcion, costo, precioventa, cantidad, cantidadminima, idcategoria, idtipoproducto, idproveedor);
                Clases.Inventario inventario = new Clases.Inventario(
                    id,
                    descripcion,
                    costo,
                    precioventa,
                    cantidad,
                    cantidadminima,
                    idcategoria,
                    idtipoproducto,
                    idproveedor);
                inventario.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarInventario
            (
            int id
            )
        {
            try
            {
                Clases.Inventario inventario = new Clases.Inventario(
                    id);
                inventario.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarInventario1
      (
      int id,int estado
      )
        {
            try
            {
                Clases.Inventario inventario = new Clases.Inventario(
                    id,estado);
                inventario.Eliminar1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarTipoProducto
         (
            string nombre
         )
        {
            if (nombre.Length == 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar un Tipo de Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar un tipo de Producto:\n" +
                    "Nombre   : Elaborado\n",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }

        public static void AgregarTipoProducto
            (
            string nombre
            )
        {
            try
            {
                ValidarTipoProducto(nombre);
                Clases.TipoProducto tipoproducto = new Clases.TipoProducto(
                    nombre
                    );
                tipoproducto.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarTipoProducto
            (
            int id,
            string nombre
            )
        {
            try
            {
                ValidarTipoProducto(nombre);
                Clases.TipoProducto tipoproducto = new Clases.TipoProducto(
                    id,
                    nombre
                    );
                tipoproducto.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarTipoProducto
            (
            int id
            )
        {
            try
            {
                Clases.TipoProducto tipoproducto = new Clases.TipoProducto(
                    id
                    );
                tipoproducto.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarCategoriaProducto
         (
            string nombre
         )
        {
            if (nombre.Length == 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar una Categoria de Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar una Categoria de Producto:\n" +
                    "Nombre   : Bebida\n",
                    new Exception(),
                    "Clase_Restaurante"
                    );
            }
        }
  
        public static void AgregarCategoriaProducto
            (
            string nombre
            )
        {
            try
            {
                ValidarCategoriaProducto(nombre);
                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto(
                    nombre
                    );
                categoria.Agregar();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarCategoriaProducto
            (
            int id,
            string nombre
            )
        {
            try
            {
                ValidarCategoriaProducto(nombre);
                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto(
                    id,
                    nombre
                    );
                categoria.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarCategoriaProducto
            (
            int id
            )
        {
            try
            {
                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto(
                    id
                    );
                categoria.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void EliminarCategoriaProducto1
    (
    int id,int estado
    )
        {
            try
            {
                Clases.CategoriaProducto categoria = new Clases.CategoriaProducto(
                    id,estado
                    );
                categoria.Eliminar1();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void ValidarInsumoProducto
                (
                int idInsumo,
                int idInventario,
                decimal cantidad
                )
        {
            if (idInsumo <= 0 || idInventario <= 0 || cantidad < 0)
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar el insumo del Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el insumo del Producto\n" +
                    "idInsumo  : Tomate\n" +
                    "idInventario   : Pescado\n" +
                    "Cantidad : 4",
                    new Exception(),
                    "Clase_Insumo"
                    );
            }
        }
        public static void AgregarInsumoProducto
            (
            int idInsumo,
            int idInventario,
            decimal cantidad
            )
        {
            try
            {
                ValidarInsumoProducto(idInsumo, idInventario, cantidad);
                Clases.InsumoProductos insumoproducto = new Clases.InsumoProductos(
                    idInsumo,
                    idInventario,
                    cantidad
                    );
                insumoproducto.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarInsumoProducto
            (
            int idInsumoProducto,
            int idInsumo,
            int idInventario,
            decimal cantidad
            )
        {
            try
            {
                ValidarInsumoProducto(idInsumo, idInventario, cantidad);
                Clases.InsumoProductos insumoproducto = new Clases.InsumoProductos(
                    idInsumoProducto,
                    idInsumo,
                    idInventario,
                    cantidad
                    );
                insumoproducto.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarInsumoProducto
            (
            int idInsumoProducto,
            int idInventario
            )
        {
            try
            {
                Clases.InsumoProductos insumoproducto = new Clases.InsumoProductos(
                    idInsumoProducto,
                    idInventario
                    );
                insumoproducto.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///

        private static void ValidarPedido
                (
                string Fecha,
                int idMesa,
                int idMesero
                )
        {
            if (Fecha == "" || idMesa <= 0 ||idMesero<=0 )
            {
                throw new Clases.Excepcion
                    (
                    "Error al insertar el pedido del Producto. \n\n" +
                    "Existen datos obligatorios que se necesitan para poder agregar el pedodo del Producto\n" +
                    "Fecha  : 14/12/2018\n" +
                    "Mesa   : Mesa 1\n" +
                    "Mesero : Pedro Marmol",
                    new Exception(),
                    "Clase_Pedido"
                    );
            }
        }
        public static void AgregarPedido
            (
              string Fecha,
                int idMesa,
                string rtn,
                string nombre,
                int idMesero
            )
        {
            try
            {
                ValidarPedido(Fecha, idMesa, idMesero);
                Clases.Pedidos pedidos = new Clases.Pedidos(
                 Fecha,
                 idMesa,
                 rtn,
                 nombre,
                 idMesero
                    );
                pedidos.Agregar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarPedido
            (
                int id,
                //string Fecha,
                //int idMesa,
                //string rtn,
                //string nombre,
                //int idMesero ,
                int estado   
            )
        {
            try
            {
                //ValidarPedido(Fecha,idMesa, idMesero);
                Clases.Pedidos pedidos = new Clases.Pedidos(
                  id,

                 estado
                    );
                pedidos.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void EliminarPedido
            (
            int id
            )
        {
            try
            {
                Clases.Pedidos pedidos = new Clases.Pedidos(
                    id
                    );
                pedidos.Eliminar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarDetalle
    (
        int id,
        int estado
    )
        {
            try
            {
                Clases.Detalle pedidos = new Clases.Detalle(
                  id,
                 estado
                    );
                pedidos.Modificar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Validacion de datos para la Apertura de Caja.
        /// </summary>
        /// <param name="apertura"></param>
        /// <param name="usuario"></param>
        public static void ValidarAperturaCaja(decimal apertura, string usuario)
        {
            try
            {
                if (apertura < 0 || usuario.Length == 0)
                {
                    throw new Clases.Excepcion
                    (
                    "Error al hacer la Apertura de Caja. \n\n" +
                    "Existen datos obligatorios que se necesitan para hacer la Apertura de Caja.\n" +
                    "Apertura   : L 2000.00 1\n",
                    new Exception(),
                    "Clase Caja"
                    );
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Insercion de la Apertura de Caja.
        /// </summary>
        /// <param name="apertura"></param>
        /// <param name="dolares"></param>
        /// <param name="fiveh"></param>
        /// <param name="hundred"></param>
        /// <param name="fifty"></param>
        /// <param name="twenty"></param>
        /// <param name="ten"></param>
        /// <param name="five"></param>
        /// <param name="two"></param>
        /// <param name="one"></param>
        /// <param name="usuario"></param>
        public static void AperturarCaja(decimal apertura, int dolares, int fiveh,
                                         int hundred, int fifty, int twenty, int ten, int five, int two, int one, 
                                         string usuario)
        {
            try
            {
                ValidarAperturaCaja(apertura, usuario);
                Clases.Caja caja = new Clases.Caja(apertura, dolares, fiveh, hundred,
                                                   fifty, twenty, ten, five, two, one, usuario);
                caja.AgregarApertura();
                MessageBox.Show("Se ha realizado la Apertura de Caja correctamente!", "Mensaje");
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Validacion de datos del Cierre de Caja.
        /// </summary>
        /// <param name="cierre"></param>
        /// <param name="usuario"></param>
        public static void ValidarCierreCaja(decimal cierre, string usuario)
        {
            try
            {
                if (cierre < 0 || usuario.Length == 0)
                {
                    throw new Clases.Excepcion(
                        "Error al hacer el Cierre de Caja. \n\n" +
                        "Existen datos obligatorios que se necesitan para hacer la Apertura de Caja.\n" +
                        "Cierre   : L 2000.00 1\n",
                        new Exception(),
                        "Clase Caja");
                }
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// Insercino del Cierre de Caja.
        /// </summary>
        /// <param name="cierre"></param>
        /// <param name="dolares"></param>
        /// <param name="pos"></param>
        /// <param name="fiveh"></param>
        /// <param name="hundred"></param>
        /// <param name="fifty"></param>
        /// <param name="twenty"></param>
        /// <param name="ten"></param>
        /// <param name="five"></param>
        /// <param name="two"></param>
        /// <param name="one"></param>
        /// <param name="usuario"></param>
        public static void CierreCaja(decimal cierre, int dolares, decimal pos, int fiveh,
                               int hundred, int fifty, int twenty, int ten, int five, int two, int one, 
                               string usuario)
        {
            try
            {
                ValidarAperturaCaja(cierre, usuario);
                Clases.Caja c = new Clases.Caja(cierre, dolares, pos, fiveh, hundred,
                                                fifty, twenty, ten, five, two, one, usuario);

                c.AgregarCierre();
                MessageBox.Show("El Cierre de caja se ha realizado correctamente!", "Mensaje");
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// Validacion de datos de los Pagos de Servicio Publico.
        /// </summary>
        /// <param name="ServicioPublico"></param>
        /// <param name="Monto"></param>
        /// <param name="Usuario"></param>
        public static void ValidarPagoServicioPublico(string ServicioPublico, decimal Monto, string Usuario)
        {
            if (ServicioPublico == "" || Monto <= 0 || Usuario == "")
            {
                throw new Clases.Excepcion
                (
                "Error al insertar un Pago de Servicio Publico. \n\n" +
                "Existen datos obligatorios que se necesitan para hacer la Apertura de Caja.\n" +
                "Servicio Publico   : Agua" +
                "Monto              : L 2000.00" +
                "Usuario            : ECalix",
                new Exception(),
                "Clase Caja"
                );
            }
        }

        /// <summary>
        /// Insercion de los Pagos de Servicios Publicos.
        /// </summary>
        /// <param name="nombreServicioPublico"></param>
        /// <param name="Monto"></param>
        /// <param name="usuario"></param>
        public static void InsertarPagoServicioPublico(string nombreServicioPublico, decimal Monto, string usuario)
        {
            ValidarPagoServicioPublico(nombreServicioPublico, Monto, usuario);
            Clases.ServicioPublico sp = new Clases.ServicioPublico(nombreServicioPublico, Monto, usuario);

            sp.AgregarPagoServicioPublico();
            MessageBox.Show("El pago se inserto existosamente!", "Mensaje");
        }

        /// <summary>
        /// Validacion de datos de las Salidas Varias.
        /// </summary>
        /// <param name="descripcion"></param>
        /// <param name="Monto"></param>
        /// <param name="usuario"></param>
        public static void ValidarSalida(string descripcion, decimal Monto, string usuario)
        {
            if (descripcion == "" || Monto <= 0 || usuario == "")
            {
                throw new Clases.Excepcion
                (
                "Error al insertar la salida. \n\n" +
                "Existen datos obligatorios que se necesitan para hacer la insercion de la salida.\n" +
                "Servicio Publico   : Agua" +
                "Monto              : L 2000.00" +
                "Usuario            : ECalix",
                new Exception(),
                "Clase Caja"
                );
            }
        }

        /// <summary>
        /// Insercion de Salidas Varias.
        /// </summary>
        /// <param name="descripcionSalida"></param>
        /// <param name="Monto"></param>
        /// <param name="usuario"></param>
        public static void InsertarSalida(string descripcionSalida, decimal Monto, string usuario)
        {
            ValidarSalida(descripcionSalida, Monto, usuario);
            Clases.OtrasSalidas s = new Clases.OtrasSalidas(descripcionSalida, Monto, usuario);

            s.AgregarOtraSalida();
            MessageBox.Show("La salida se inserto existosamente!", "Mensaje");
        }
    }
}
