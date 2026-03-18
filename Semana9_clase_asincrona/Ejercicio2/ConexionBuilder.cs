using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_clase_asincrona
{
    public class ConexionBuilder
    {
        private ConexionBD _conexion = new ConexionBD();

        public ConexionBuilder SetServidor(string servidor)
        {
            _conexion.Servidor = servidor;
            return this;
        }

        public ConexionBuilder SetBaseDatos(string bd)
        {
            _conexion.BaseDatos = bd;
            return this;
        }


        public ConexionBuilder SetUsuario(string usuario)
        {
            _conexion.Usuario = usuario;
            return this;
        }

        public ConexionBuilder SetPassword(string password)
        {
            _conexion.Password = password;
            return this;
        }

        public ConexionBuilder SetPuerto(int puerto)
        {
            _conexion.Puerto = puerto;
            return this;
        }

        public ConexionBuilder SetTimeout(int timeout)
        {
            _conexion.Timeout = timeout;
            return this;
        }

        public ConexionBD Build()
        {
            return _conexion;
        }
    }
}