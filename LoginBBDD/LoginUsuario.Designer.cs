namespace LoginBBDD
{
    partial class LoginUsuario
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
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            panel1 = new Panel();
            panel2 = new FlowLayoutPanel();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(776, 82);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Font = new Font("Stencil", 12F, FontStyle.Bold);
            button1.Location = new Point(1128, 12);
            button1.Name = "button1";
            button1.Size = new Size(215, 41);
            button1.TabIndex = 2;
            button1.Text = "Cerrar Sesión";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.Blizzard_Entertainment_Logo_2015_svg;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(27, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 100);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(27, 181);
            button2.Name = "button2";
            button2.Size = new Size(186, 45);
            button2.TabIndex = 7;
            button2.Text = "MIS JUEGOS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(27, 316);
            button3.Name = "button3";
            button3.Size = new Size(186, 45);
            button3.TabIndex = 8;
            button3.Text = "MI PERFIL";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(319, 82);
            label2.Name = "label2";
            label2.Size = new Size(157, 29);
            label2.TabIndex = 10;
            label2.Text = "DESTACADOS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(277, 515);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 414);
            panel1.TabIndex = 19;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Location = new Point(287, 127);
            panel2.Name = "panel2";
            panel2.Size = new Size(1064, 382);
            panel2.TabIndex = 20;
            // 
            // button4
            // 
            button4.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(27, 444);
            button4.Name = "button4";
            button4.Size = new Size(186, 45);
            button4.TabIndex = 21;
            button4.Text = "VER CESTA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // LoginUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.white_to_blue_gradient;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1371, 953);
            Controls.Add(button4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Name = "LoginUsuario";
            Text = "LoginUsuario";
            Load += LoginUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicioSesion;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Panel panel1;
        private FlowLayoutPanel panel2;
        private Button button4;
    }
}