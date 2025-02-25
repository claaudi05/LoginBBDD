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
    public partial class CrearCuenta : Form
    {
        public CrearCuenta(string usuario = "", string contraseña = "")
        {
            InitializeComponent();

            // Evitar parpadeo en la interfaz
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            // Prellenar los campos si se proporciona información
            txtUsuario.Text = usuario;
            txtContraseña.Text = contraseña;
        }

        private void CrearCuenta_Click(object sender, EventArgs e)
        {
            lblError.Text = "";

            string usuario = txtUsuario.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string repetirContraseña = txtRepetirContraseña.Text.Trim();

            // Validaciones de campos vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña) || string.IsNullOrWhiteSpace(repetirContraseña))
            {
                lblError.Text = "Por favor, complete todos los campos.";
                return;
            }

            // Validación de contraseñas
            if (contraseña != repetirContraseña)
            {
                lblError.Text = "Las contraseñas no coinciden.";
                return;
            }

            // Conexión a la base de datos
            string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verificar si el usuario ya existe
                    string verificarConsulta = "SELECT COUNT(*) FROM usuarios WHERE nombre = @usuario;";
                    using (MySqlCommand cmdVerificar = new MySqlCommand(verificarConsulta, conn))
                    {
                        cmdVerificar.Parameters.AddWithValue("@usuario", usuario);
                        int existe = Convert.ToInt32(cmdVerificar.ExecuteScalar());
                        if (existe > 0)
                        {
                            lblError.Text = "El usuario ya existe.";
                            return;
                        }
                    }

                    // Insertar el usuario en la base de datos
                    string consultaInsertar = "INSERT INTO usuarios (nombre, contraseña, admin, estado) VALUES (@usuario, @contraseña, 0, 0);";
                    using (MySqlCommand cmdInsertar = new MySqlCommand(consultaInsertar, conn))
                    {
                        cmdInsertar.Parameters.AddWithValue("@usuario", usuario);
                        cmdInsertar.Parameters.AddWithValue("@contraseña", contraseña);

                        int filasAfectadas = cmdInsertar.ExecuteNonQuery();
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Usuario registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario. Inténtalo nuevamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al registrar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {
        }
    }
}


