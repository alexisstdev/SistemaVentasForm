using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            var admin = new Usuario();

            Inicio form = new Inicio(admin);
            form.Show();
            this.Hide();
            form.FormClosing += frmClosing;
        }

        private void frmClosing(object sender, FormClosingEventArgs e)
        {
            txtContraseña.Text = "";
            txtNombre.Text = "";
            this.Show();
        }
    }
}