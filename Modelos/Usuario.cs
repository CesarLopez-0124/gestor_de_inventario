using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestor_de_inventario.Modelos
{
    internal class Usuario
    {
        public string Nombres { get; set; }
        public string ApellidoP {  get; set; }
        public string ApellidoM { get; set; }
        public string Contrasena { get; set; }

        public Usuario(string nombre, string apellidoP, string apellidoM, string contrasena)
        {
            Nombres = nombre;
            ApellidoP = apellidoP;
            ApellidoM = apellidoM;
            Contrasena = contrasena;
        }
    }
}
