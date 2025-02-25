using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace LoginBBDD
{
    public partial class JuegoControl : UserControl
    {
        private string rutaImagen = "";
        private string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";
        private DataTable juegosDataTable;
        private string juegoSeleccionadoTitulo = "";

        public JuegoControl()
        {
            InitializeComponent();
            CargarListaJuegos();
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
        }

        // 🔹 Seleccionar imagen
        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Seleccionar Imagen";
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaImagen = openFileDialog.FileName;
                    pbImagen.Image = Image.FromFile(rutaImagen);
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string precioTexto = txtPrecio.Text.Trim();
            bool destacado = checkBoxDestacados.Checked; // Obtener estado del CheckBox

            if (string.IsNullOrWhiteSpace(titulo) ||
                string.IsNullOrWhiteSpace(descripcion) ||
                string.IsNullOrWhiteSpace(precioTexto) ||
                pbImagen.Image == null)
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imagenBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imagenBytes = ms.ToArray();
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO catalogo (titulo, descripcion, precio, rutaImagen, destacados) VALUES (@titulo, @descripcion, @precio, @imagen, @destacados);";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@precio", precio);
                        cmd.Parameters.Add("@imagen", MySqlDbType.LongBlob).Value = imagenBytes;
                        cmd.Parameters.AddWithValue("@destacados", destacado ? 1 : 0); // Guardar como 1 si está marcado, 0 si no

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Juego guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimpiarCampos();
                        CargarListaJuegos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el juego: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // 🔹 Cargar juegos en el ListBox, incluyendo destacados
        private void CargarListaJuegos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT titulo, descripcion, precio, rutaImagen, destacados FROM catalogo";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                        {
                            juegosDataTable = new DataTable();
                            adapter.Fill(juegosDataTable);

                            listBox.Items.Clear();
                            foreach (DataRow row in juegosDataTable.Rows)
                            {
                                listBox.Items.Add(row["titulo"].ToString());
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
        // 🔹 Seleccionar juego para editar o eliminar
        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                DataRow row = juegosDataTable.Rows[listBox.SelectedIndex];
                juegoSeleccionadoTitulo = row["titulo"].ToString(); // Guardar título del juego

                txtTitulo.Text = row["titulo"].ToString();
                txtDescripcion.Text = row["descripcion"].ToString();
                txtPrecio.Text = row["precio"].ToString();

                byte[] imgBytes = row["rutaImagen"] as byte[];
                pbImagen.Image = ConvertirBlobAImagen(imgBytes);

                checkBoxDestacados.Checked = Convert.ToInt32(row["destacados"]) == 1; // Cargar estado del CheckBox
            }
        }

        // 🔹 Convertir un BLOB a una imagen
        private Image ConvertirBlobAImagen(byte[] blob)
        {
            if (blob == null || blob.Length == 0)
                return null;
            //return Properties.Resources.imagen_default;

            using (MemoryStream ms = new MemoryStream(blob))
            {
                return Image.FromStream(ms);
            }
        }

        // 🔹 EDITAR juego (incluye destacado)
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(juegoSeleccionadoTitulo))
            {
                MessageBox.Show("Seleccione un juego para editar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string titulo = txtTitulo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string precioTexto = txtPrecio.Text.Trim();
            bool destacado = checkBoxDestacados.Checked;

            if (!decimal.TryParse(precioTexto, out decimal precio))
            {
                MessageBox.Show("El precio debe ser un valor numérico válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imagenBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                pbImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imagenBytes = ms.ToArray();
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE catalogo SET titulo=@tituloNuevo, descripcion=@descripcion, precio=@precio, rutaImagen=@imagen, destacados=@destacados WHERE titulo=@tituloAntiguo";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@tituloNuevo", titulo);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.Add("@imagen", MySqlDbType.LongBlob).Value = imagenBytes;
                    cmd.Parameters.AddWithValue("@destacados", destacado ? 1 : 0); // Guardar 1 o 0 según CheckBox
                    cmd.Parameters.AddWithValue("@tituloAntiguo", juegoSeleccionadoTitulo);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Juego actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    CargarListaJuegos();
                }
            }
        }

        // 🔹 ELIMINAR juego (basado en el título)
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(juegoSeleccionadoTitulo))
            {
                MessageBox.Show("Seleccione un juego para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirmación antes de eliminar
            DialogResult resultado = MessageBox.Show($"¿Está seguro de que desea eliminar el juego '{juegoSeleccionadoTitulo}' y todas sus referencias?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.No)
                return;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Eliminar primero las referencias en "usuarios-videojuegos"
                    string queryEliminarReferencias = "DELETE FROM `usuarios-videojuegos` WHERE idJuego = @titulo";
                    using (MySqlCommand cmdReferencias = new MySqlCommand(queryEliminarReferencias, conn))
                    {
                        cmdReferencias.Parameters.AddWithValue("@titulo", juegoSeleccionadoTitulo);
                        cmdReferencias.ExecuteNonQuery();
                    }

                    // Eliminar el juego de la tabla "catalogo"
                    string queryEliminarJuego = "DELETE FROM catalogo WHERE titulo = @titulo";
                    using (MySqlCommand cmdJuego = new MySqlCommand(queryEliminarJuego, conn))
                    {
                        cmdJuego.Parameters.AddWithValue("@titulo", juegoSeleccionadoTitulo);
                        int filasAfectadas = cmdJuego.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Juego eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                            CargarListaJuegos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el juego en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el juego: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LimpiarCampos()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            pbImagen.Image = null;
            rutaImagen = "";
            juegoSeleccionadoTitulo = "";
            checkBoxDestacados.Checked = false; // Resetear el CheckBox
        }

        private void pbImagen_Click(object sender, EventArgs e)
        {

        }

        private void JuegoControl_Load(object sender, EventArgs e)
        {

        }
    }
}



