using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginBBDD
{
    public partial class Home : UserControl
    {
        private string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";

        public Home()
        {
            InitializeComponent();
            ConfigurarFlowLayoutPanel(); // Configurar scroll y organización
            CargarCatalogo(); // Cargar datos al inicio
        }

        private void ConfigurarFlowLayoutPanel()
        {

            panel.AutoScroll = true;          // Activar scroll
            panel.FlowDirection = FlowDirection.LeftToRight; // Organizar de izquierda a derecha
            panel.HorizontalScroll.Enabled = true;
            panel.VerticalScroll.Enabled = false;
        }

        private void CargarCatalogo()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT titulo, descripcion, precio, rutaImagen FROM catalogo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            DataTable juegosDataTable = new DataTable();
                            adapter.Fill(juegosDataTable);

                            // Limpiar el FlowLayoutPanel antes de cargar datos nuevos
                            panel.Controls.Clear();

                            // Crear elementos dinámicos para cada juego
                            foreach (DataRow row in juegosDataTable.Rows)
                            {
                                string titulo = row["titulo"].ToString();
                                string descripcion = row["descripcion"].ToString();
                                string precio = row["precio"].ToString();
                                byte[] imgBytes = row["rutaImagen"] as byte[];

                                Image img = ConvertirBlobAImagen(imgBytes);

                                // Crear un Panel para contener la imagen y la info
                                Panel panelJuego = new Panel
                                {
                                    Size = new Size(200, 250),
                                    BorderStyle = BorderStyle.FixedSingle,
                                    Margin = new Padding(10)
                                };

                                // Crear el PictureBox con la imagen
                                PictureBox pbJuego = new PictureBox
                                {
                                    Size = new Size(180, 180),
                                    Location = new Point(10, 10),
                                    SizeMode = PictureBoxSizeMode.Zoom,
                                    Image = img,
                                    Cursor = Cursors.Hand,
                                    Tag = new JuegoData(titulo, descripcion, precio) // Guardar datos en el Tag
                                };
                                pbJuego.Click += PbJuego_Click; // Evento para abrir detalles

                                // Crear un Label con el título
                                Label lblTitulo = new Label
                                {
                                    Text = titulo,
                                    Location = new Point(10, 200),
                                    Size = new Size(180, 20),
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Font = new Font("Stencil", 12, FontStyle.Bold)
                                };

                                // Crear un Label con el precio
                                Label lblPrecio = new Label
                                {
                                    Text = $"{precio}€",
                                    Location = new Point(10, 220),
                                    Size = new Size(180, 20),
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Font = new Font("Arial", 12, FontStyle.Italic)
                                };

                                // Agregar controles al panel
                                panelJuego.Controls.Add(pbJuego);
                                panelJuego.Controls.Add(lblTitulo);
                                panelJuego.Controls.Add(lblPrecio);

                                // Agregar el panel al FlowLayoutPanel
                                panel.Controls.Add(panelJuego);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el catálogo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para convertir BLOB a imagen
        private Image ConvertirBlobAImagen(byte[] blob)
        {
            if (blob == null || blob.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(blob))
            {
                return Image.FromStream(ms);
            }
        }

        // Evento para mostrar detalles al hacer clic en una imagen
        private void PbJuego_Click(object sender, EventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null && pb.Tag is JuegoData juego)
            {
                // Pasar la imagen a DetallesJuego
                DetallesJuego detallesForm = new DetallesJuego(juego.Titulo, juego.Descripcion, juego.Precio, pb.Image);
                detallesForm.ShowDialog();
            }
        }


        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }

    // Clase auxiliar para almacenar datos del juego en el Tag
    public class JuegoData
    {
        public string Titulo { get; }
        public string Descripcion { get; }
        public string Precio { get; }

        public JuegoData(string titulo, string descripcion, string precio)
        {
            Titulo = titulo;
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
