//using System;

//namespace Ejemplo_clase_asincrona
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var builder = new PedidoBuilder();

//            // Paso 1: seleccionar productos
//            builder.AgregarProducto("Laptop");
//            builder.AgregarProducto("Mouse");

//            // Paso 2: cliente
//            builder.SetCliente("Ronald");

//            // Paso 3: dirección
//            builder.SetDireccion("Chalatenango");  

//            // Paso 4: método de pago
//            builder.SetMetodoPago("Tarjeta");

//            // Extras
//            builder.SetDescuento(10);
//            builder.SetImpuestos(13);

//            // Construcción final
//            var pedido = builder.Build();

//            pedido.MostrarPedido();

//            Console.ReadLine();
//        }
//    }
//}

using System;

namespace Ejemplo_clase_asincrona
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConexionBuilder();

            // Paso 1: servidor
            builder.SetServidor("localhost");

            // Paso 2: base de datos
            builder.SetBaseDatos("TiendaDB");

            // Paso 3: usuario
            builder.SetUsuario("PC_RONALD");

            // Paso 4: contraseña
            builder.SetPassword("1234");

            // Opcionales
            builder.SetPuerto(3306);
            builder.SetTimeout(30);

            var conexion = builder.Build();

            conexion.MostrarConfiguracion();

            Console.ReadLine();

        }
    }
}