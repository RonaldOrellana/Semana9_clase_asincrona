using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_clase_asincrona
{
    public class Pedido
    {
        public string Cliente { get; set; }
        public List<string> Productos { get; set; } = new List<string>();
        public string DireccionEnvio { get; set; }
        public string MetodoPago { get; set; }
        public double Descuento { get; set; }
        public double Impuestos { get; set; }

        public void MostrarPedido()
        {
            Console.WriteLine("RESULTADO DE PEDIDO ");
            Console.WriteLine("Cliente: " + Cliente);
            Console.WriteLine("Productos: " + string.Join(", ", Productos));
            Console.WriteLine("Dirección: " + DireccionEnvio);
            Console.WriteLine("Método de pago: " + MetodoPago);
            Console.WriteLine("Descuento: " + Descuento);
            Console.WriteLine("Impuestos: " + Impuestos);
        }
    }
}