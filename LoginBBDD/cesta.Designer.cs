namespace LoginBBDD
{
    partial class cesta
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
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(27, 31);
            label1.Name = "label1";
            label1.Size = new Size(210, 27);
            label1.TabIndex = 0;
            label1.Text = "Cesta de compra";
            // 
            // button1
            // 
            button1.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(218, 559);
            button1.Name = "button1";
            button1.Size = new Size(249, 42);
            button1.TabIndex = 1;
            button1.Text = "confirmar compra";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Location = new Point(27, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 426);
            panel1.TabIndex = 2;
            // 
            // cesta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.white_to_blue_gradient;
            ClientSize = new Size(736, 613);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "cesta";
            Text = "cesta";
            Load += cesta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Panel panel1;
    }
}