using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using gestor_de_inventario.Modelos;

namespace gestor_de_inventario.Servicios
{
    internal class ServicioLogin
    {
        private List<Usuario> usuarios = new List<Usuario>()
        {
            new Usuario("Cesar", "Lopez", "Lopez", "admin"),
            new Usuario("Alberto", "Gonzalez", "Garibaldi", "admin1"),
            new Usuario("Roman", "Gonzalez", "Garcia", "admin2"),
            new Usuario("Alejandro", "Gonzalez", "De santiago","admin3")
        };

        public Usuario Validar(string nombres, string apellidoP, string apellidoM, string contrasena)
        {
            return usuarios.FirstOrDefault(u =>
                u.Nombres.Equals(nombres, System.StringComparison.OrdinalIgnoreCase)
            );
        }
    }
}
