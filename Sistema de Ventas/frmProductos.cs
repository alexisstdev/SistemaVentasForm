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
    public partial class frmProductos : Form
    {
        private Producto miProducto = new Producto();

        public frmProductos()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dtgProductos.Rows.Clear();
            foreach (Producto miProducto in miProducto.misProductos)
            {
                dtgProductos.Rows.Add(miProducto.IDProducto, miProducto.NombreProducto);
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
                    indexBusqueda = miProducto.misProductos.FindIndex(x => x.NombreProducto.Contains(txtBusqueda.Text));
                    break;

                case "ID":
                    indexBusqueda = miProducto.misProductos.FindIndex(x => x.IDProducto.Contains(txtBusqueda.Text));
                    break;

                case "stock":
                    indexBusqueda = miProducto.misProductos.FindIndex(x => x.StockProducto == Int32.Parse(txtBusqueda.Text));
                    break;

                default:
                    MessageBox.Show("Seleccione una opción de búsqueda");
                    break;
            }
            if (indexBusqueda == -1)
            {
                MessageBox.Show($"No se encontró un producto con este {cbxBuscar.Text}");
                return;
            }
            dtgProductos.Rows[indexBusqueda].Selected = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miProducto.EliminarProducto(dtgProductos.CurrentCell.RowIndex);
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

            if (miProducto.misProductos.FindIndex(x => x.IDProducto == txtID.Text) != -1)
            {
                var messageBox = MessageBox.Show($"Ya existe un producto con el ID: {txtID.Text} ¿Desea sobreescribirlo?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (messageBox == DialogResult.No) return;
                else miProducto.EliminarProducto(miProducto.misProductos.FindIndex(x => x.IDProducto == txtID.Text));
            }
            var producto = new Producto
            {
                IDProducto = txtID.Text,
                NombreProducto = txtNombre.Text,

            };
            miProducto.AñadirProducto(producto);
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dtgProductos_SelectionChanged(object sender, EventArgs e)
        {
            lblIndex.Text = $"{dtgProductos.CurrentCell.RowIndex}";

            miProducto.DeserializarLista();

            if (dtgProductos.CurrentCell.RowIndex >= 0 && dtgProductos.CurrentCell.RowIndex < miProducto.misProductos.Count)
            {
                txtID.Text = miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].IDProducto;
                txtNombre.Text = miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].NombreProducto;
            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            miProducto.DeserializarLista();
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