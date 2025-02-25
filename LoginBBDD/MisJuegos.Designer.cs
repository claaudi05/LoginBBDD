namespace LoginBBDD
{
    partial class MisJuegos
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
            flowPanelJuegos = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(28, 23);
            label1.Name = "label1";
            label1.Size = new Size(181, 35);
            label1.TabIndex = 3;
            label1.Text = "MIS JUEGOS";
            // 
            // flowPanelJuegos
            // 
            flowPanelJuegos.BackColor = Color.Transparent;
            flowPanelJuegos.Location = new Point(37, 70);
            flowPanelJuegos.Name = "flowPanelJuegos";
            flowPanelJuegos.Size = new Size(920, 421);
            flowPanelJuegos.TabIndex = 4;
            // 
            // MisJuegos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.white_to_blue_gradient;
            ClientSize = new Size(990, 515);
            Controls.Add(flowPanelJuegos);
            Controls.Add(label1);
            Name = "MisJuegos";
            Text = "MisJuegos";
           // Load += MisJuegos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowPanelJuegos;
    }
}