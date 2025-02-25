using MySql.Data.MySqlClient;
using System;
using System.Collections;
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
    public partial class InicioSesionAdmin : Form
    {
        public InicioSesionAdmin(string usuario)
        {
            InitializeComponent();

            //Utilizaremos el DobleBuffered para la redimension de la aplicacion, de esta forma evitaremos el parpadeo de nuestros elementos
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            //Se inicia en pantalla completa

            lblUsuarioIncio.Text = usuario;

            ConectarConBBDD();

            // Manejar el evento SelectedIndexChanged del ListBox
            var listBoxBBDD = this.Controls["listBoxBBDD"] as ListBox;
            if (listBoxBBDD != null)
            {
                listBoxBBDD.SelectedIndexChanged += ListBoxBBDD_SelectedIndexChanged;
            }
        }

        private void ConectarConBBDD()
        {
            string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";
            string sentencia = "SELECT nombre, contraseña, estado, admin FROM `usuarios` LIMIT 10";  // Limitar a 10 usuarios

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sentencia, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Obtenemos la referencia al ListBox
                    var listBoxBBDD = this.Controls["listBoxBBDD"] as ListBox;
                    // Limpiamos los resultados anteriores
                    listBoxBBDD.Items.Clear();

                    // Leemos los resultados y los mostramos en el ListBox
                    while (reader.Read())
                    {
                        string admin = reader.GetInt32("admin") == 1 ? "Admin" : "No Admin";
                        string estado = reader.GetInt32("estado") == 1 ? "Baneado" : "No Baneado"; // Estado baneado
                        string contraseña = reader.GetString("contraseña"); // Obtener la contraseña

                        listBoxBBDD.Items.Add($"{reader.GetString("nombre")}|{contraseña}|{admin}|{estado}");
                    }
                }
            }
        }



        private void ListBoxBBDD_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Obtenemos el ListBox
            var listBoxBBDD = sender as ListBox;

            if (listBoxBBDD != null && listBoxBBDD.SelectedItem != null)
            {
                // Obtenemos el item seleccionado
                string itemSeleccionado = listBoxBBDD.SelectedItem.ToString();

                // Dividimos el item en 4 partes (nombre, contraseña, admin, estado)
                string[] parts = itemSeleccionado.Split('|');
                if (parts.Length == 4)
                {
                    string usuario = parts[0]; // Primer campo (nombre)
                    string contraseña = parts[1]; // Segundo campo (contraseña)
                    string admin = parts[2]; // Tercer campo (admin/no admin)
                    string estado = parts[3]; // Cuarto campo (baneado/no baneado)

                    textBoxUsuario.Text = usuario;
                    textBoxPassw.Text = contraseña;  // Mostrar la contraseña
                    chbAdmin.Checked = admin == "Admin";
                    checkBox1.Checked = estado == "Baneado";  // Actualizar el checkbox para indicar si está baneado
                }
            }
        }



        private void btnActualizar_click(object? sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string usuario = textBoxUsuario.Text;
            string password = textBoxPassw.Text;
            bool admin = chbAdmin.Checked;
            bool esBaneado = checkBox1.Checked; // Checkbox de banear

            // Validamos que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertimos el estado de administrador y baneo a valores 1 o 0 para la base de datos
            int valorAdmin = admin ? 1 : 0;
            int estado = esBaneado ? 1 : 0; // 1 para baneado, 0 para no baneado

            // Cadena de conexión
            string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";

            // Consulta para actualizar el usuario
            string consulta = "UPDATE `usuarios` SET contraseña = @password, admin = @admin, estado = @estado WHERE nombre = @usuario;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrimos la conexión
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@admin", valorAdmin);
                        cmd.Parameters.AddWithValue("@estado", estado); // Actualizamos el estado

                        // Ejecutamos la consulta
                        int modificar = cmd.ExecuteNonQuery();

                        if (modificar > 0)
                        {
                            MessageBox.Show("Datos actualizados correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ConectarConBBDD(); // Recargamos el ListBox
                        }
                        else
                        {
                            MessageBox.Show("No se pudo actualizar la información. Verifica que el usuario exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void CerrarSesion_Click(object? sender, EventArgs e)
        {
            Form1 nuevoCerarSesion = new Form1();
            nuevoCerarSesion.Show();
            this.Close();
        }

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {
            //Obtener el usuario del TextBox
            string usuario = textBoxUsuario.Text;

            //Validar que hay un usuario en el TextBox
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Por favor, selecciona un usuario del ListBox.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Mostramos una ventana de confirmación
            DialogResult confirmacion = MessageBox.Show($"¿Estás seguro de que deseas eliminar al usuario '{usuario}'?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Si se confirma entonces se procede con la eliminación
            if (confirmacion == DialogResult.Yes)
            {
                //Conexión con la base de datos
                string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";
                string consulta = "DELETE FROM `usuarios` WHERE nombre = @usuario;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();

                        using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                        {
                            //Agregamos el parámetro para evitar inyecciones
                            cmd.Parameters.AddWithValue("@usuario", usuario);

                            //Ejecutamos la consulta
                            int filasAfectadas = cmd.ExecuteNonQuery();

                            if (filasAfectadas > 0)
                            {
                                MessageBox.Show("Usuario eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Limpiamos los textbox y actualizamos el listBox
                                textBoxUsuario.Clear();
                                textBoxPassw.Clear();
                                chbAdmin.Checked = false;
                                ConectarConBBDD();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo eliminar el usuario. Es posible que ya no exista.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los controles
            string usuario = textBoxUsuario.Text;
            string password = textBoxPassw.Text;
            bool esAdmin = chbAdmin.Checked;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor, completa todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Convertir el estado del administrador a un valor 1 o 0
            int valorAdmin = esAdmin ? 1 : 0;

            // Estado por defecto (0)
            int estado = 0;

            // Cadena de conexión con la base de datos
            string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";

            // Consulta para insertar un nuevo usuario
            string consulta = "INSERT INTO `usuarios` (nombre, contraseña, admin, estado) VALUES (@usuario, @password, @admin, @estado);";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    // Abrir la conexión
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        // Agregar los parámetros para evitar inyecciones SQL
                        cmd.Parameters.AddWithValue("@usuario", usuario);
                        cmd.Parameters.AddWithValue("@password", password);
                        cmd.Parameters.AddWithValue("@admin", valorAdmin);
                        cmd.Parameters.AddWithValue("@estado", estado);

                        // Ejecutar la consulta
                        int filasInsertadas = cmd.ExecuteNonQuery();

                        if (filasInsertadas > 0)
                        {
                            MessageBox.Show("Usuario creado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpiar los TextBox y actualizar el ListBox
                            textBoxUsuario.Clear();
                            textBoxPassw.Clear();
                            chbAdmin.Checked = false;
                            ConectarConBBDD();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo crear el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al crear el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BuscarUsuario_Click(object sender, EventArgs e)
        {
            string usuarioABuscar = textBoxBuscar.Text;

            // Validar que el cuadro de búsqueda no esté vacío
            if (string.IsNullOrWhiteSpace(usuarioABuscar))
            {
                MessageBox.Show("Por favor, introduce un nombre de usuario para buscar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";
            string consulta = "SELECT nombre, contraseña, estado, admin FROM `usuarios` WHERE nombre = @nombre LIMIT 1;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (MySqlCommand cmd = new MySqlCommand(consulta, conn))
                    {
                        cmd.Parameters.AddWithValue("@nombre", usuarioABuscar);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Si se encuentra el usuario, rellenamos los campos
                                textBoxUsuario.Text = reader.GetString("nombre");
                                textBoxPassw.Text = reader.GetString("contraseña");
                                chbAdmin.Checked = reader.GetInt32("admin") == 1;
                                checkBox1.Checked = reader.GetInt32("estado") == 1; // Estado de baneo
                            }
                            else
                            {
                                // Si no se encuentra el usuario
                                MessageBox.Show("Usuario no encontrado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Limpiamos los campos
                                textBoxUsuario.Clear();
                                textBoxPassw.Clear();
                                chbAdmin.Checked = false;
                                checkBox1.Checked = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al buscar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }



        private void InicioSesionAdmin_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

