using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using gestor_de_inventario.Servicios;
using gestor_de_inventario.Modelos;
using System.IO;

namespace gestor_de_inventario
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nombres = txtNombres.Text.Trim();
            string apellidoP = txtApellidoP.Text.Trim();
            string apellidoM = txtApellidoM.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrEmpty(nombres) ||
                string.IsNullOrEmpty(apellidoP) ||
                string.IsNullOrEmpty(apellidoM) ||
                string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            ServicioLogin servicio = new ServicioLogin();
            Usuario usuarioValido = servicio.Validar(nombres, apellidoP, apellidoM, contrasena);

            if (usuarioValido != null)
            {
                MessageBox.Show("Bienvenido " + usuarioValido.Nombres);

                FormInventario inventario = new FormInventario();
                inventario.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Datos incorrectos.");
            }
        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text.Trim().ToLower();

            // Application.StartupPath nos dice dónde está corriendo el programa (Debug/bin)
            // "Imagenes" es la carpeta que creamos.
            string rutaImagen = Path.Combine(Application.StartupPath, "Imagenes", nombre + ".jpg");
            


            if (File.Exists(rutaImagen) )
            {
                imgfoto.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                imgfoto.Image = null; // O una imagen por defecto
            }
        }
    }
}
