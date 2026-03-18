using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_clase_asincrona
{
    public class ConexionBD
    {
        public string Servidor { get; set; }
        public string BaseDatos { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public int Puerto { get; set; }
        public int Timeout { get; set; }

        public void MostrarConfiguracion()
        {
            Console.WriteLine("-CREANDO LA CONEXIÓN BD- ");
            Console.WriteLine("Servidor: " + Servidor);
            Console.WriteLine("Base de Datos: " + BaseDatos);
            Console.WriteLine("Usuario: " + Usuario);
            Console.WriteLine("Puerto: " + Puerto);
            Console.WriteLine("Timeout: " + Timeout);
        }
    }
}
