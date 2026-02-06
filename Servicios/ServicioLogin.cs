using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using gestor_de_inventario.Modelos;

namespace gestor_de_inventario.Servicios
{
    internal class ServicioLogin
    {
        private List<Usuario> usuarios;

        public ServicioLogin()
        {
            usuarios = new List<Usuario>()
            {
                new Usuario("Cesar", "Lopez", "Lopez", "1234"),
                new Usuario("Alberto", "Gonzalez", "Garibaldi", "alberto"),
                

            };
        }
    }
}
