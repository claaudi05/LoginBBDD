namespace LoginBBDD
{
    partial class CrearCuenta
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
            lblCrearCuenta = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            txtRepetirContraseña = new TextBox();
            label1 = new Label();
            btnCrear = new Button();
            lblError = new Label();
            SuspendLayout();
            // 
            // lblCrearCuenta
            // 
            lblCrearCuenta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCrearCuenta.AutoSize = true;
            lblCrearCuenta.BackColor = Color.Transparent;
            lblCrearCuenta.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearCuenta.ForeColor = SystemColors.ButtonHighlight;
            lblCrearCuenta.Location = new Point(113, 42);
            lblCrearCuenta.Name = "lblCrearCuenta";
            lblCrearCuenta.Size = new Size(180, 31);
            lblCrearCuenta.TabIndex = 0;
            lblCrearCuenta.Text = "CREAR CUENTA";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.BackColor = Color.Transparent;
            lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.ForeColor = SystemColors.ButtonHighlight;
            lblUsuario.Location = new Point(42, 138);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUsuario.Location = new Point(42, 161);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(336, 27);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContraseña.Location = new Point(42, 244);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(336, 27);
            txtContraseña.TabIndex = 4;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.BackColor = Color.Transparent;
            lblContraseña.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(42, 221);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(88, 20);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña";
            // 
            // txtRepetirContraseña
            // 
            txtRepetirContraseña.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtRepetirContraseña.Location = new Point(42, 332);
            txtRepetirContraseña.Name = "txtRepetirContraseña";
            txtRepetirContraseña.PasswordChar = '*';
            txtRepetirContraseña.Size = new Size(336, 27);
            txtRepetirContraseña.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(42, 309);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 5;
            label1.Text = "Repetir Contraseña";
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnCrear.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrear.Location = new Point(100, 450);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(208, 36);
            btnCrear.TabIndex = 7;
            btnCrear.Text = "Crear";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += CrearCuenta_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.BackColor = Color.Transparent;
            lblError.ForeColor = Color.Tomato;
            lblError.Location = new Point(42, 372);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 8;
            // 
            // CrearCuenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.white_to_blue_gradient;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(414, 604);
            Controls.Add(lblError);
            Controls.Add(btnCrear);
            Controls.Add(txtRepetirContraseña);
            Controls.Add(label1);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(lblCrearCuenta);
            Name = "CrearCuenta";
            Text = "CrearCuenta";
            Load += CrearCuenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrearCuenta;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label lblContraseña;
        private TextBox txtRepetirContraseña;
        private Label label1;
        private Button btnCrear;
        private Label lblError;
    }
}