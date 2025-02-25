using MySql.Data.MySqlClient;

namespace LoginBBDD
{
    public partial class Form1 : Form
    {
        public static string UsuarioActual { get; private set; }

        public static class Carrito
        {
            public static List<Juego> JuegosComprados = new List<Juego>();
        }

        public class Juego
        {
            public string Titulo { get; set; }
            public string Descripcion { get; set; }
            public string Precio { get; set; }
            public Image Imagen { get; set; }  // Imagen del juego
        }


        public Form1()
        {
            InitializeComponent();
            //Se inicia en pantalla completa


            //Utilizaremos el DobleBuffered para la redimension de la aplicacion, de esta forma evitaremos el parpadeo de nuestros elementos
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();

            Button iniciarSesion = new Button();
            iniciarSesion.Click += btnIniciarSesion_Click;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Conexión a la base de datos
            string connectionString = "Server=localhost;Port=3306;Database=loginsql;Uid=root;Pwd=1234;";
            string usuario = textBoxUser.Text.Trim();
            string passw = textBoxPassw.Text.Trim();

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(passw))
            {
                MessageBox.Show("No puede haber campos vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Verificar si el usuario existe
                    string verificarUsuario = "SELECT contraseña, admin, estado FROM usuarios WHERE nombre = @usuario;";
                    using (MySqlCommand cmd = new MySqlCommand(verificarUsuario, conn))
                    {
                        cmd.Parameters.AddWithValue("@usuario", usuario);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Usuario encontrado
                            {
                                string contraseñaCorrecta = reader.GetString("contraseña");
                                int admin = reader.GetInt32("admin");
                                int estado = reader.GetInt32("estado");

                                // Comprobar si la contraseña es correcta
                                if (contraseñaCorrecta != passw)
                                {
                                    MessageBox.Show("Contraseña incorrecta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Si el usuario está baneado
                                if (estado == 1)
                                {
                                    MessageBox.Show("Este usuario está baneado.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }

                                // Guardar el usuario en la variable global
                                UsuarioActual = usuario;

                                // Si es administrador
                                if (admin == 1)
                                {
                                    TaskDialogButton btnUsuarios = new TaskDialogButton("usuarios");
                                    TaskDialogButton btnCatalogo = new TaskDialogButton("catalogo");

                                    TaskDialogPage page = new TaskDialogPage()
                                    {
                                        Caption = "Panel de Administración",
                                        Heading = "¿A qué sección deseas acceder?",
                                        Icon = TaskDialogIcon.Information,
                                        Buttons = { btnUsuarios, btnCatalogo }
                                    };

                                    TaskDialogButton respuesta = TaskDialog.ShowDialog(page);

                                    if (respuesta == btnUsuarios)
                                    {
                                        InicioSesionAdmin nuevoInicioSesion = new InicioSesionAdmin($"Has iniciado sesión como {usuario}");
                                        nuevoInicioSesion.Show();
                                    }
                                    else if (respuesta == btnCatalogo)
                                    {
                                        FormCatalogo formCatalogo = new FormCatalogo();
                                        formCatalogo.Show();
                                    }

                                    this.Hide();
                                }
                                else
                                {
                                    // Usuario normal
                                    LoginUsuario inicioSesionUsuario = new LoginUsuario($"Has iniciado sesión como {usuario}");
                                    inicioSesionUsuario.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                // Si el usuario no existe, redirigir a CrearCuenta con los datos prellenados
                                MessageBox.Show("El usuario no existe. Por favor, créalo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                CrearCuenta crearCuentaForm = new CrearCuenta(usuario, passw);
                                crearCuentaForm.Show();
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

        private void linkLabelCrearCuenta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CrearCuenta formularioRegistro = new CrearCuenta();
            formularioRegistro.Show();
        }


        //Metodo que permite el DobleBuffered
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
