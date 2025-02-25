namespace LoginBBDD
{
    partial class JuegoControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtTitulo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            pbImagen = new PictureBox();
            btnSeleccionarImagen = new Button();
            btnGuardar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            listBox = new ListBox();
            checkBoxDestacados = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pbImagen).BeginInit();
            SuspendLayout();
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(64, 82);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(403, 27);
            txtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(64, 39);
            label1.Name = "label1";
            label1.Size = new Size(199, 40);
            label1.TabIndex = 1;
            label1.Text = "Ingresa el titulo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(64, 192);
            label2.Name = "label2";
            label2.Size = new Size(267, 40);
            label2.TabIndex = 2;
            label2.Text = "Ingresa la descripción";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(64, 253);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(403, 27);
            txtDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe Print", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(64, 345);
            label3.Name = "label3";
            label3.Size = new Size(207, 40);
            label3.TabIndex = 4;
            label3.Text = "Ingresa el precio";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(64, 419);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(403, 27);
            txtPrecio.TabIndex = 5;
            // 
            // pbImagen
            // 
            pbImagen.BackColor = Color.Transparent;
            pbImagen.Location = new Point(570, 39);
            pbImagen.Name = "pbImagen";
            pbImagen.Size = new Size(390, 386);
            pbImagen.SizeMode = PictureBoxSizeMode.Zoom;
            pbImagen.TabIndex = 6;
            pbImagen.TabStop = false;
            pbImagen.Click += pbImagen_Click;
            // 
            // btnSeleccionarImagen
            // 
            btnSeleccionarImagen.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionarImagen.Location = new Point(513, 450);
            btnSeleccionarImagen.Name = "btnSeleccionarImagen";
            btnSeleccionarImagen.Size = new Size(227, 39);
            btnSeleccionarImagen.TabIndex = 7;
            btnSeleccionarImagen.Text = "Selecciona una imagen";
            btnSeleccionarImagen.UseVisualStyleBackColor = true;
            btnSeleccionarImagen.Click += btnSeleccionarImagen_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(751, 450);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(209, 39);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditar.Location = new Point(998, 450);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(202, 39);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Tempus Sans ITC", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(1206, 450);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(172, 39);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(1025, 41);
            listBox.Name = "listBox";
            listBox.Size = new Size(334, 384);
            listBox.TabIndex = 11;
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // checkBoxDestacados
            // 
            checkBoxDestacados.AutoSize = true;
            checkBoxDestacados.BackColor = Color.Transparent;
            checkBoxDestacados.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBoxDestacados.Location = new Point(64, 465);
            checkBoxDestacados.Name = "checkBoxDestacados";
            checkBoxDestacados.Size = new Size(153, 28);
            checkBoxDestacados.TabIndex = 12;
            checkBoxDestacados.Text = "Destacados";
            checkBoxDestacados.UseVisualStyleBackColor = false;
            // 
            // JuegoControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.white_to_blue_gradient;
            Controls.Add(checkBoxDestacados);
            Controls.Add(listBox);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(btnSeleccionarImagen);
            Controls.Add(pbImagen);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtDescripcion);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitulo);
            Name = "JuegoControl";
            Size = new Size(1418, 568);
            Load += JuegoControl_Load;
            ((System.ComponentModel.ISupportInitialize)pbImagen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitulo;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private Label label3;
        private TextBox txtPrecio;
        private PictureBox pbImagen;
        private Button btnSeleccionarImagen;
        private Button btnGuardar;
        private Button btnEditar;
        private Button btnEliminar;
        private ListBox listBox;
        private CheckBox checkBoxDestacados;
    }
}
