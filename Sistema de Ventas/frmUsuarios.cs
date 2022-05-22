using System;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class frmUsuarios : Form
    {
        private Usuario miUsuario = new Usuario();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dtgUsuarios.Rows.Clear();
            foreach (Usuario miUsuario in miUsuario.misUsuarios)
            {
                dtgUsuarios.Rows.Add(miUsuario.IDUsuario, miUsuario.NombreUsuario, miUsuario.Correo, miUsuario.Rol, miUsuario.Contraseña);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int indexBusqueda = -1;
            if (txtBusqueda.Text == "")
            {
                MessageBox.Show("Campo de búsqueda vacío");
                return;
            }
            switch (cbxBuscar.Text)
            {
                case "Nombre":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.NombreUsuario.Contains(txtBusqueda.Text));
                    break;

                case "ID":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.IDUsuario.Contains(txtBusqueda.Text));
                    break;

                case "Correo":
                    indexBusqueda = miUsuario.misUsuarios.FindIndex(x => x.Correo.Contains(txtBusqueda.Text));
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de búsqueda");
                    break;
            }
            if (indexBusqueda == -1)
            {
                MessageBox.Show($"No se encontró un usuario con este {cbxBuscar.Text}");
                return;
            }
            dtgUsuarios.Rows[indexBusqueda].Selected = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miUsuario.EliminarUsuario(dtgUsuarios.CurrentCell.RowIndex);
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Control control in datosContainer.Controls)
            {
                if (control.Text.Trim() == "" || control.Text == "0.00")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }
            }
            if (txtContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Por favor verifique las contraseñas");
                return;
            }
            if (miUsuario.misUsuarios.FindIndex(x => x.IDUsuario == txtID.Text) != -1)
            {
                var messageBox = MessageBox.Show($"Ya existe un usuario con el ID: {txtID.Text} ¿Desea sobreescribirlo?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (messageBox == DialogResult.No) return;
                else miUsuario.EliminarUsuario(miUsuario.misUsuarios.FindIndex(x => x.IDUsuario == txtID.Text));
            }
            var usuario = new Usuario
            {
                IDUsuario = txtID.Text,
                NombreUsuario = txtNombre.Text,
                Correo = txtCorreo.Text,
                Contraseña = txtContraseña.Text,
                Rol = cbxRol.Text
            };
            miUsuario.AñadirUsuario(usuario);
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dtgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            lblIndex.Text = $"{dtgUsuarios.CurrentCell.RowIndex}";

            miUsuario.DeserializarLista();

            if (dtgUsuarios.CurrentCell.RowIndex >= 0 && dtgUsuarios.CurrentCell.RowIndex < miUsuario.misUsuarios.Count)
            {
                txtID.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].IDUsuario;
                txtNombre.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].NombreUsuario;
                txtCorreo.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Correo;
                cbxRol.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Rol;
                txtContraseña.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Contraseña;
                txtConfirmarContraseña.Text = miUsuario.misUsuarios[dtgUsuarios.CurrentCell.RowIndex].Contraseña;
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            miUsuario.DeserializarLista();
            ActualizarDataGrid();
        }

        private void LimpiarDatos()
        {
            foreach (Control control in datosContainer.Controls)
            {
                if (control is TextBox) control.Text = "";
            }
        }
    }
}