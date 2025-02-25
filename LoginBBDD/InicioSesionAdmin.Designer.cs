namespace LoginBBDD
{
    partial class InicioSesionAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuarioIncio = new Label();
            btnCerrarSesion = new Button();
            listBoxBBDD = new ListBox();
            textBoxUsuario = new TextBox();
            lblUsuario = new Label();
            lblPassw = new Label();
            textBoxPassw = new TextBox();
            chbAdmin = new CheckBox();
            btnActualizar = new Button();
            btnBorrarUsuario = new Button();
            button1 = new Button();
            checkBox1 = new CheckBox();
            textBoxBuscar = new TextBox();
            buttonBuscar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblUsuarioIncio
            // 
            lblUsuarioIncio.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuarioIncio.AutoSize = true;
            lblUsuarioIncio.BackColor = Color.Transparent;
            lblUsuarioIncio.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuarioIncio.ForeColor = Color.White;
            lblUsuarioIncio.Location = new Point(1282, 27);
            lblUsuarioIncio.Name = "lblUsuarioIncio";
            lblUsuarioIncio.Size = new Size(214, 23);
            lblUsuarioIncio.TabIndex = 0;
            lblUsuarioIncio.Text = "Has iniciado sesion como ";
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrarSesion.Location = new Point(1587, 19);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(162, 40);
            btnCerrarSesion.TabIndex = 1;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += CerrarSesion_Click;
            // 
            // listBoxBBDD
            // 
            listBoxBBDD.BackColor = Color.FromArgb(1, 62, 123);
            listBoxBBDD.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxBBDD.ForeColor = Color.White;
            listBoxBBDD.FormattingEnabled = true;
            listBoxBBDD.ItemHeight = 23;
            listBoxBBDD.Location = new Point(27, 333);
            listBoxBBDD.Name = "listBoxBBDD";
            listBoxBBDD.Size = new Size(327, 510);
            listBoxBBDD.TabIndex = 2;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxUsuario.Location = new Point(1443, 289);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(277, 27);
            textBoxUsuario.TabIndex = 3;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(1443, 263);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(70, 23);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // lblPassw
            // 
            lblPassw.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPassw.AutoSize = true;
            lblPassw.BackColor = Color.Transparent;
            lblPassw.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassw.ForeColor = Color.White;
            lblPassw.Location = new Point(1443, 357);
            lblPassw.Name = "lblPassw";
            lblPassw.Size = new Size(57, 23);
            lblPassw.TabIndex = 5;
            lblPassw.Text = "Passw";
            // 
            // textBoxPassw
            // 
            textBoxPassw.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPassw.Location = new Point(1443, 383);
            textBoxPassw.Name = "textBoxPassw";
            textBoxPassw.Size = new Size(277, 27);
            textBoxPassw.TabIndex = 6;
            // 
            // chbAdmin
            // 
            chbAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chbAdmin.AutoSize = true;
            chbAdmin.BackColor = Color.Transparent;
            chbAdmin.ForeColor = Color.White;
            chbAdmin.Location = new Point(1443, 433);
            chbAdmin.Name = "chbAdmin";
            chbAdmin.Size = new Size(75, 24);
            chbAdmin.TabIndex = 7;
            chbAdmin.Text = "Admin";
            chbAdmin.UseVisualStyleBackColor = false;
            // 
            // btnActualizar
            // 
            btnActualizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnActualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.Location = new Point(1479, 514);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(201, 28);
            btnActualizar.TabIndex = 8;
            btnActualizar.Text = "Actualizar Usuario";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_click;
            // 
            // btnBorrarUsuario
            // 
            btnBorrarUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBorrarUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrarUsuario.Location = new Point(1479, 557);
            btnBorrarUsuario.Name = "btnBorrarUsuario";
            btnBorrarUsuario.Size = new Size(201, 28);
            btnBorrarUsuario.TabIndex = 9;
            btnBorrarUsuario.Text = "Borrar Usuario\r\n";
            btnBorrarUsuario.UseVisualStyleBackColor = true;
            btnBorrarUsuario.Click += btnBorrarUsuario_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1479, 600);
            button1.Name = "button1";
            button1.Size = new Size(201, 28);
            button1.TabIndex = 10;
            button1.Text = "Añadir Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCrearUsuario_Click;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(1585, 433);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(77, 24);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Banear";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // textBoxBuscar
            // 
            textBoxBuscar.Location = new Point(27, 100);
            textBoxBuscar.Name = "textBoxBuscar";
            textBoxBuscar.Size = new Size(227, 27);
            textBoxBuscar.TabIndex = 12;
            textBoxBuscar.TextChanged += textBox1_TextChanged;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(260, 97);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(94, 31);
            buttonBuscar.TabIndex = 13;
            buttonBuscar.Text = "buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            buttonBuscar.Click += BuscarUsuario_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(251, 23);
            label1.TabIndex = 14;
            label1.Text = "Buscar por nombre de usuario";
            // 
            // InicioSesionAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_01_20_a_las_13_21_39_365e2332;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1761, 991);
            Controls.Add(label1);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxBuscar);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(btnBorrarUsuario);
            Controls.Add(btnActualizar);
            Controls.Add(chbAdmin);
            Controls.Add(textBoxPassw);
            Controls.Add(lblPassw);
            Controls.Add(lblUsuario);
            Controls.Add(textBoxUsuario);
            Controls.Add(listBoxBBDD);
            Controls.Add(btnCerrarSesion);
            Controls.Add(lblUsuarioIncio);
            Name = "InicioSesionAdmin";
            Text = "InicioSesionAdmin";
            Load += InicioSesionAdmin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuarioIncio;
        private Button btnCerrarSesion;
        private ListBox listBoxBBDD;
        private TextBox textBoxUsuario;
        private Label lblUsuario;
        private Label lblPassw;
        private TextBox textBoxPassw;
        private CheckBox chbAdmin;
        private Button btnActualizar;
        private Button btnBorrarUsuario;
        private Button button1;
        private CheckBox checkBox1;
        private TextBox textBoxBuscar;
        private Button buttonBuscar;
        private Label label1;
    }
}