namespace LoginBBDD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxPassw = new TextBox();
            lblInicioDeSesion = new Label();
            textBoxUser = new TextBox();
            lblUser = new Label();
            lblPassword = new Label();
            lblCrearCuenta = new Label();
            iniciarSesion = new Button();
            linklblCrearCuenta = new LinkLabel();
            SuspendLayout();
            // 
            // textBoxPassw
            // 
            textBoxPassw.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxPassw.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxPassw.Location = new Point(1402, 508);
            textBoxPassw.Name = "textBoxPassw";
            textBoxPassw.PasswordChar = '*';
            textBoxPassw.Size = new Size(296, 30);
            textBoxPassw.TabIndex = 2;
            // 
            // lblInicioDeSesion
            // 
            lblInicioDeSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblInicioDeSesion.AutoSize = true;
            lblInicioDeSesion.BackColor = Color.Transparent;
            lblInicioDeSesion.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicioDeSesion.ForeColor = Color.White;
            lblInicioDeSesion.Location = new Point(1444, 283);
            lblInicioDeSesion.Name = "lblInicioDeSesion";
            lblInicioDeSesion.Size = new Size(182, 31);
            lblInicioDeSesion.TabIndex = 1;
            lblInicioDeSesion.Text = "Inicio de Sesión\r\n";
            // 
            // textBoxUser
            // 
            textBoxUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxUser.BackColor = SystemColors.Menu;
            textBoxUser.Cursor = Cursors.IBeam;
            textBoxUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxUser.Location = new Point(1402, 401);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(296, 30);
            textBoxUser.TabIndex = 1;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.White;
            lblUser.Location = new Point(1402, 378);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(45, 23);
            lblUser.TabIndex = 3;
            lblUser.Text = "User";
            // 
            // lblPassword
            // 
            lblPassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(1402, 482);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 23);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password";
            // 
            // lblCrearCuenta
            // 
            lblCrearCuenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCrearCuenta.AutoSize = true;
            lblCrearCuenta.BackColor = Color.Transparent;
            lblCrearCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearCuenta.ForeColor = Color.White;
            lblCrearCuenta.Location = new Point(1422, 618);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(145, 40);
            lblCrearCuenta.TabIndex = 5;
            lblCrearCuenta.Text = "¿No tienes cuenta? \r\n\r\n";
            // 
            // iniciarSesion
            // 
            iniciarSesion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            iniciarSesion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iniciarSesion.Location = new Point(1471, 571);
            iniciarSesion.Name = "iniciarSesion";
            iniciarSesion.Size = new Size(165, 29);
            iniciarSesion.TabIndex = 6;
            iniciarSesion.Text = "Iniciar Sesion";
            iniciarSesion.UseVisualStyleBackColor = true;
            iniciarSesion.Click += btnIniciarSesion_Click;
            // 
            // linklblCrearCuenta
            // 
            linklblCrearCuenta.ActiveLinkColor = Color.Gray;
            linklblCrearCuenta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linklblCrearCuenta.AutoSize = true;
            linklblCrearCuenta.BackColor = Color.Transparent;
            linklblCrearCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linklblCrearCuenta.ForeColor = Color.White;
            linklblCrearCuenta.LinkColor = Color.White;
            linklblCrearCuenta.Location = new Point(1560, 618);
            linklblCrearCuenta.Name = "linklblCrearCuenta";
            linklblCrearCuenta.Size = new Size(122, 20);
            linklblCrearCuenta.TabIndex = 7;
            linklblCrearCuenta.TabStop = true;
            linklblCrearCuenta.Text = "Resgistrate aquí\r\n";
            linklblCrearCuenta.LinkClicked += linkLabelCrearCuenta_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Imagen_de_WhatsApp_2025_01_20_a_las_13_21_39_365e2332;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1761, 991);
            Controls.Add(linklblCrearCuenta);
            Controls.Add(iniciarSesion);
            Controls.Add(lblCrearCuenta);
            Controls.Add(lblPassword);
            Controls.Add(lblUser);
            Controls.Add(textBoxUser);
            Controls.Add(lblInicioDeSesion);
            Controls.Add(textBoxPassw);
            Name = "Form1";
            Text = "Inicio De Sesion";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassw;
        private Label lblInicioDeSesion;
        private TextBox textBoxUser;
        private Label lblUser;
        private Label lblPassword;
        private Label lblCrearCuenta;
        private Button iniciarSesion;
        private LinkLabel linklblCrearCuenta;
    }
}
