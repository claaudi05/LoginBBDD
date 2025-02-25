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
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();

            JuegoControl juegoControl = new JuegoControl();
            this.Controls.Add(juegoControl);
        }
        private void CerrarSesion_Click(object? sender, EventArgs e)
        {
            Form1 nuevoCerarSesion = new Form1();
            nuevoCerarSesion.Show();
            this.Close();
        }


        private void FormCatalogo_Load(object sender, EventArgs e)
        {

        }
    }
}
