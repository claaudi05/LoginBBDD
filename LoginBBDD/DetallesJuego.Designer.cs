namespace LoginBBDD
{
    partial class DetallesJuego
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
            label1 = new Label();
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblPrecio = new Label();
            btnComprar = new Button();
            textTitulo = new TextBox();
            textDescripcion = new TextBox();
            textPrecio = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 116);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(60, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(84, 40);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Titulo";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.BackColor = Color.Transparent;
            lblDescripcion.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.Location = new Point(60, 199);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(150, 40);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripcion";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.BackColor = Color.Transparent;
            lblPrecio.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecio.Location = new Point(60, 367);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(89, 40);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio";
            // 
            // btnComprar
            // 
            btnComprar.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComprar.Location = new Point(502, 440);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(186, 45);
            btnComprar.TabIndex = 5;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // textTitulo
            // 
            textTitulo.Location = new Point(60, 113);
            textTitulo.Name = "textTitulo";
            textTitulo.Size = new Size(272, 27);
            textTitulo.TabIndex = 6;
            // 
            // textDescripcion
            // 
            textDescripcion.Location = new Point(60, 278);
            textDescripcion.Name = "textDescripcion";
            textDescripcion.Size = new Size(272, 27);
            textDescripcion.TabIndex = 7;
            // 
            // textPrecio
            // 
            textPrecio.Location = new Point(60, 440);
            textPrecio.Name = "textPrecio";
            textPrecio.Size = new Size(272, 27);
            textPrecio.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(443, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(331, 326);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // DetallesJuego
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.white_to_blue_gradient;
            ClientSize = new Size(804, 550);
            Controls.Add(pictureBox1);
            Controls.Add(textPrecio);
            Controls.Add(textDescripcion);
            Controls.Add(textTitulo);
            Controls.Add(btnComprar);
            Controls.Add(lblPrecio);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            Controls.Add(label1);
            Name = "DetallesJuego";
            Text = "DetallesJuego";
            Load += DetallesJuego_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblPrecio;
        private Button btnComprar;
        private TextBox textTitulo;
        private TextBox textDescripcion;
        private TextBox textPrecio;
        private PictureBox pictureBox1;
    }
}