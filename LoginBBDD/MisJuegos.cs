using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginBBDD
{
    public partial class MisJuegos : Form
    {
        private string connectionString = "server=localhost; database=loginsql; user=root; password=1234;";
        private string nombreUsuario; // Usuario logueado

        public MisJuegos(string usuario)
        {
            InitializeComponent();
            nombreUsuario = usuario;
            CargarJuegosUsuario();

            flowPanelJuegos.AutoScroll = true;          // Activar scroll
            flowPanelJuegos.FlowDirection = FlowDirection.LeftToRight; // Organizar de izquierda a derecha
            flowPanelJuegos.HorizontalScroll.Enabled = true;
            flowPanelJuegos.VerticalScroll.Enabled = false;
        }

        private void CargarJuegosUsuario()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                    SELECT c.titulo, c.rutaImagen, c.descripcion
                    FROM catalogo c
                    INNER JOIN `usuarios-videojuegos` uv ON c.titulo = uv.idJuego
                    INNER JOIN usuarios u ON uv.idUsuario = u.nombre
                    WHERE u.nombre = @usuario";



                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", nombreUsuario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string titulo = reader["titulo"].ToString();
                                string descripcion = reader["descripcion"].ToString();
                                byte[] imgBytes = reader["rutaImagen"] as byte[];
                                Image imagenJuego = ConvertirBlobAImagen(imgBytes);

                                AgregarJuegoALista(titulo,descripcion, imagenJuego);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los juegos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ConvertirBlobAImagen(byte[] blob)
        {
            if (blob == null || blob.Length == 0)
                //return Properties.Resources.imagen_default; // Imagen por defecto si no hay imagen
                return null;
            using (MemoryStream ms = new MemoryStream(blob))
            {
                return Image.FromStream(ms);
            }
        }

        private void AgregarJuegoALista(string titulo,string descripcion, Image imagen)
        {
            Panel juegoPanel = new Panel
            {
                Size = new Size(200, 300),
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pb = new PictureBox
            {
                Image = imagen,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(180, 180),
                Location = new Point(10, 10)
            };

            Label lblTitulo = new Label
            {
                Text = titulo,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(180, 30),
                Location = new Point(10, 200)
            };

            Label lblDescripcion = new Label
            {
                Text = descripcion,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Size = new Size(180, 30),
                Location = new Point(10, 250)
            };

            juegoPanel.Controls.Add(pb);
            juegoPanel.Controls.Add(lblTitulo);
            juegoPanel.Controls.Add (lblDescripcion);

            flowPanelJuegos.Controls.Add(juegoPanel);
        }
    }
}