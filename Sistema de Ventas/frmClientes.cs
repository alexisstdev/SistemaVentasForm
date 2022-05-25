using System;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class frmClientes : Form
    {
        private Cliente miCliente = new Cliente();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dtgClientes.Rows.Clear();
            foreach (Cliente miCliente in miCliente.misClientes)
            {
                dtgClientes.Rows.Add(miCliente.IDCliente, miCliente.NombreCliente, miCliente.Correo, miCliente.Telefono);
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
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.NombreCliente.Contains(txtBusqueda.Text));
                    break;

                case "ID":
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.IDCliente.Contains(txtBusqueda.Text));
                    break;

                case "Correo":
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.Correo.Contains(txtBusqueda.Text));
                    break;

                case "Teléfono":
                    indexBusqueda = miCliente.misClientes.FindIndex(x => x.Telefono.Contains(txtBusqueda.Text));
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de búsqueda");
                    break;
            }
            if (indexBusqueda == -1)
            {
                MessageBox.Show($"No se encontró un cliente con este {cbxBuscar.Text}");
                return;
            }
            dtgClientes.Rows[indexBusqueda].Selected = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miCliente.misClientes.RemoveAt(dtgClientes.CurrentCell.RowIndex);
            miCliente.SerializarLista();
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

            if (miCliente.misClientes.FindIndex(x => x.IDCliente == txtID.Text) != -1)
            {
                var messageBox = MessageBox.Show($"Ya existe un cliente con el ID: {txtID.Text} ¿Desea sobreescribirlo?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (messageBox == DialogResult.No) return;
                else miCliente.misClientes.RemoveAt(miCliente.misClientes.FindIndex(x => x.IDCliente == txtID.Text));
            }
            var cliente = new Cliente
            {
                IDCliente = txtID.Text,
                NombreCliente = txtNombre.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTeléfono.Text
            };

            miCliente.misClientes.Add(cliente);
            miCliente.SerializarLista();
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dtgClientes_SelectionChanged(object sender, EventArgs e)
        {
            lblIndex.Text = $"{dtgClientes.CurrentCell.RowIndex}";
            miCliente.DeserializarLista();
            if (dtgClientes.CurrentCell.RowIndex >= 0 && dtgClientes.CurrentCell.RowIndex < miCliente.misClientes.Count)
            {
                txtID.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].IDCliente;
                txtNombre.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].NombreCliente;
                txtCorreo.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].Correo;
                txtTeléfono.Text = miCliente.misClientes[dtgClientes.CurrentCell.RowIndex].Telefono;
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            miCliente.DeserializarLista();
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