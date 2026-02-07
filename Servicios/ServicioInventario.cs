using gestor_de_inventario.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_inventario.Servicios
{

    internal class ServicioInventario
    {
        private List<Producto> productos = new List<Producto>();
        private int contadorId = 1;

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }

        public void AgregarProducto(string nombre, int cantidad, decimal precio)
        {
            productos.Add(new Producto
            {
                Id = contadorId++,
                Nombre = nombre,
                Cantidad = cantidad,
                Precio = precio
            });
        }

        public void EliminarProducto(int id)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
                productos.Remove(producto);
        }

        public void EditarPrecio(int id, decimal nuevoPrecio)
        {
            var producto = productos.FirstOrDefault(p => p.Id == id);
            if (producto != null)
                producto.Precio = nuevoPrecio;
        }

        

    }
}
