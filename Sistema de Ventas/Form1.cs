using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Sistema_de_Ventas
{
    public partial class Inicio : Form
    {
        private static Usuario usuarioActual;
        private static IconMenuItem MenuActivo = null;
        private static Form formularioActivo = null;

        public Inicio(Usuario miUsuario)
        {
            usuarioActual = miUsuario;
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
            string rol = usuarioActual.Rol == 0 ? "Empleado" : "Administrador";
            lblUser.Text = $"Usuario: {usuarioActual.NombreUsuario} ({rol})";

            if (usuarioActual.Rol == 0)
            {
                menuCompras.Visible = false;
            }
        }

        private void AbrirForms(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null) MenuActivo.BackColor = Color.FromArgb(239, 247, 249);

            menu.BackColor = Color.FromArgb(155, 196, 203);
            MenuActivo = menu;

            if (formularioActivo != null) formularioActivo.Close();
            formularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            container.Controls.Add(formulario);
            formulario.Show();
        }

        private void menuVentas_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmVentas());
        }

        private void menuCompras_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmCompras());
        }

        private void menuClientes_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmClientes());
        }

        private void menuProductos_Click(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmProductos());
        }

        private void menuUsuarios_Click_1(object sender, EventArgs e)
        {
            AbrirForms((IconMenuItem)sender, new frmUsuarios());
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void container_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}