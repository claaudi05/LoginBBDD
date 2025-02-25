using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LoginBBDD.Form1;

namespace LoginBBDD
{
    public partial class DetallesJuego : Form
    {
        public DetallesJuego(string titulo, string descripcion, string precio, Image imagen)
        {
            InitializeComponent();
            textTitulo.Text = titulo;
            textDescripcion.Text = descripcion;
            textPrecio.Text = precio + "€";
            pictureBox1.Image = imagen;  // Mostrar la imagen
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; // Ajustar imagen sin distorsionarla

            textTitulo.ReadOnly = true;
            textDescripcion.ReadOnly = true;
            textPrecio.ReadOnly = true;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            string usuarioActual = Form1.UsuarioActual; // Obtener el usuario actual
            string tituloJuego = textTitulo.Text; // Obtener el título del juego

            if (string.IsNullOrEmpty(usuarioActual))
            {
                MessageBox.Show("Error: No hay un usuario conectado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si el usuario ya tiene el juego en la base de datos
            using (MySqlConnection conexion = new MySqlConnection("server=localhost; database=loginsql; user=root; password=1234"))
            {
                conexion.Open();

                string query = "SELECT COUNT(*) FROM `usuarios-videojuegos` WHERE idJuego = @idJuego AND idUsuario = @idUsuario";

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idJuego", tituloJuego);
                    cmd.Parameters.AddWithValue("@idUsuario", usuarioActual);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Este juego ya lo tienes comprado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // No agregamos el juego a la cesta
                    }
                }
            }

            // Si el juego no está en la base de datos, lo agregamos a la lista
            Juego nuevoJuego = new Juego
            {
                Titulo = tituloJuego,
                Descripcion = textDescripcion.Text,
                Precio = textPrecio.Text,
                Imagen = pictureBox1.Image  // Asignar la imagen actual del PictureBox
            };

            // Agregar a la lista solo si no existe
            if (!Form1.Carrito.JuegosComprados.Any(j => j.Titulo == tituloJuego))
            {
                Form1.Carrito.JuegosComprados.Add(nuevoJuego);

                // Si la cesta ya está abierta, actualizarla
                if (Application.OpenForms["cesta"] is cesta cestaForm)
                {
                    cestaForm.ActualizarCesta();
                }
                else
                {
                    // Crear y mostrar la cesta
                    cesta nuevaCesta = new cesta();
                    nuevaCesta.Show();
                }
            }
        }





        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void DetallesJuego_Load(object sender, EventArgs e)
        {

        }
    }
}
