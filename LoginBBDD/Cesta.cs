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
    public partial class    cesta : Form
    {
        public cesta()
        {
            InitializeComponent();
        }

        public void ActualizarCesta()
        {
            panel1.Controls.Clear(); // Limpiar panel antes de actualizar

            int yOffset = 10; // Posición inicial para los elementos en el panel

            foreach (var juego in Carrito.JuegosComprados)
            {
                // Crear un panel para cada juego
                Panel juegoPanel = new Panel
                {
                    Size = new Size(600, 100),
                    Location = new Point(10, yOffset),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Agregar la imagen del juego
                PictureBox pbImagen = new PictureBox
                {
                    Size = new Size(80, 80),
                    Location = new Point(10, 10),
                    Image = juego.Imagen,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                juegoPanel.Controls.Add(pbImagen);

                // Agregar el título del juego
                Label lblTitulo = new Label
                {
                    Text = juego.Titulo,
                    Location = new Point(100, 10),
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold)
                };
                juegoPanel.Controls.Add(lblTitulo);

                // Agregar la descripción
                Label lblDescripcion = new Label
                {
                    Text = juego.Descripcion,
                    Location = new Point(100, 30),
                    AutoSize = true,
                    Font = new Font("Arial", 9)
                };
                juegoPanel.Controls.Add(lblDescripcion);

                // Agregar el precio
                Label lblPrecio = new Label
                {
                    Text = "Precio: " + juego.Precio,
                    Location = new Point(100, 50),
                    AutoSize = true,
                    Font = new Font("Arial", 9, FontStyle.Italic)
                };
                juegoPanel.Controls.Add(lblPrecio);

                // Botón para eliminar el juego
                Button btnEliminar = new Button
                {
                    Text = "Eliminar",
                    Location = new Point(500, 30),
                    Size = new Size(80, 30)
                };
                btnEliminar.Click += (sender, e) => EliminarJuego(juego.Titulo);
                juegoPanel.Controls.Add(btnEliminar);

                // Agregar el panel del juego al panel principal
                panel1.Controls.Add(juegoPanel);

                yOffset += 110; // Ajustar la posición para el siguiente juego
            }
        }
        private void EliminarJuego(string titulo)
        {
            // Buscar y eliminar el juego de la lista
            Carrito.JuegosComprados.RemoveAll(j => j.Titulo == titulo);

            // Actualizar la cesta en la UI
            ActualizarCesta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Form1.UsuarioActual))
            {
                MessageBox.Show("Error: No hay un usuario conectado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string usuarioActual = Form1.UsuarioActual; // Obtener el usuario actual

            using (MySqlConnection conexion = new MySqlConnection("server=localhost; database=loginsql; user=root; password=1234"))
            {
                conexion.Open();

                foreach (var juego in Form1.Carrito.JuegosComprados)
                {
                    string query = "INSERT INTO `usuarios-videojuegos` (idJuego, idUsuario) VALUES (@idJuego, @idUsuario)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@idJuego", juego.Titulo);
                        cmd.Parameters.AddWithValue("@idUsuario", usuarioActual);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Compra confirmada y guardada en la base de datos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form1.Carrito.JuegosComprados.Clear(); // Vaciar la lista después de la compra
                ActualizarCesta(); // Actualizar la UI de la cesta
            }
        }



        private void cesta_Load(object sender, EventArgs e)
        {
            ActualizarCesta();
        }

    }
}
