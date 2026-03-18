using System;
using System.Collections.Generic;
using System.Text;

namespace Ejemplo_clase_asincrona
{
    public class PedidoBuilder
    {
        private Pedido _pedido = new Pedido();

        public PedidoBuilder SetCliente(string cliente)
        {
            _pedido.Cliente = cliente;
            return this;
        }

        public PedidoBuilder AgregarProducto(string producto)
        {
            _pedido.Productos.Add(producto);
            return this;
        }

        public PedidoBuilder SetDireccion(string direccion)
        {
            _pedido.DireccionEnvio = direccion;
            return this;
        }

        public PedidoBuilder SetMetodoPago(string metodo)
        {
            _pedido.MetodoPago = metodo;
            return this;
        }

        public PedidoBuilder SetDescuento(double descuento)
        {
            _pedido.Descuento = descuento;
            return this;
        }

        public PedidoBuilder SetImpuestos(double impuestos)
        {
            _pedido.Impuestos = impuestos;
            return this;
        }

        public Pedido Build()
        {
            return _pedido;
        }
    }
}