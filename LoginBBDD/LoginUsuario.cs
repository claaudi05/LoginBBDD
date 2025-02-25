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

namespace LoginBBDD
{
    public partial class LoginUsuario : Form
    {


        public LoginUsuario(string usuario)
        {
            InitializeComponent();

            // Home home = new Home();
            //this.Controls.Add(home);

            //Utilizaremos el DobleBuffered para la redimension de la aplicacion, de esta forma evitaremos el parpadeo de nuestros elementos
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            // lblInicioSesion.Text = usuario;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();
            inicio.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MisJuegos misJuegos = new MisJuegos(Form1.UsuarioActual);
            misJuegos.Show();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            // Verificar que haya un usuario conectado
            if (string.IsNullOrEmpty(Form1.UsuarioActual))
            {
                MessageBox.Show("No hay ningún usuario conectado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar el nombre del usuario con un mensaje
            MessageBox.Show($"👤 Nombre de usuario: {Form1.UsuarioActual}", "Perfil de Usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void LoginUsuario_Load(object sender, EventArgs e)
        {
            Home homeControl = new Home();
            homeControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(homeControl);

            // Configurar panel2 como FlowLayoutPanel
            panel2.AutoScroll = true;
            panel2.FlowDirection = FlowDirection.LeftToRight; // Scroll horizontal
            panel2.WrapContents = false; // Evita que los elementos bajen de línea

            CargarJuegosDestacados();
        }

        private void CargarJuegosDestacados()
        {
            string connectionString = "server=localhost; database=loginsql; user=root; password=1234;";

            using (MySqlConnection conexion = new MySqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT titulo, descripcion, precio, rutaImagen FROM catalogo WHERE destacados = 1";

                    using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string titulo = reader.GetString("titulo");
                                string descripcion = reader.GetString("descripcion");
                                string precio = reader.GetDecimal("precio").ToString("0.00");
                                byte[] imgData = (byte[])reader["rutaImagen"];

                                // Convertir imagen de bytes a Image
                                Image imagenJuego;
                                using (MemoryStream ms = new MemoryStream(imgData))
                                {
                                    imagenJuego = Image.FromStream(ms);
                                }

                                // Crear el panel del juego
                                Panel panelJuego = new Panel
                                {
                                    Size = new Size(250, 350),
                                    BorderStyle = BorderStyle.FixedSingle
                                };

                                // Crear la imagen del juego
                                PictureBox pictureBox = new PictureBox
                                {
                                    Size = new Size(200, 200),
                                    Image = imagenJuego,
                                    SizeMode = PictureBoxSizeMode.StretchImage,
                                    Cursor = Cursors.Hand
                                };

                                // Evento para abrir DetallesJuego
                                pictureBox.Click += (sender, e) =>
                                {
                                    DetallesJuego detalles = new DetallesJuego(titulo, descripcion, precio, imagenJuego);
                                    detalles.Show();
                                };

                                // Crear la etiqueta del título
                                Label lblTitulo = new Label
                                {
                                    Text = titulo,
                                    Font = new Font("Arial", 10, FontStyle.Bold),
                                    AutoSize = true
                                };

                                // Agregar controles al panel
                                panelJuego.Controls.Add(pictureBox);
                                panelJuego.Controls.Add(lblTitulo);

                                pictureBox.Location = new Point(25, 20);
                                lblTitulo.Location = new Point(25, 230);

                                // Agregar el panel al FlowLayoutPanel (panel2)
                                panel2.Controls.Add(panelJuego);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Verifica si la cesta ya está abierta
            Form formularioCesta = Application.OpenForms["cesta"];

            if (formularioCesta == null) // Si no está abierta, crea una nueva
            {
                cesta cestaForm = new cesta();
                cestaForm.Show();
            }
            else // Si ya está abierta, solo la trae al frente
            {
                formularioCesta.BringToFront();
            }
        }
    }

}
