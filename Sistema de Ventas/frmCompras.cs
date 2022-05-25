using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Sistema_de_Ventas
{
    public partial class frmCompras : Form
    {
        private Compra miCompra = new Compra();
        private Producto miProducto = new Producto();

        public frmCompras()
        {
            InitializeComponent();
        }

        private void ActualizarDataGrid()
        {
            dtgProductosCompra.Rows.Clear();
            foreach (Producto miProductoCompra in miCompra.misProductosCompra)
            {
                dtgProductosCompra.Rows.Add(miProductoCompra.IDProducto, miProductoCompra.NombreProducto, miProductoCompra.Proveedor, miProductoCompra.PrecioCompra, miProductoCompra.StockProducto, miProductoCompra.PrecioCompra * miProductoCompra.StockProducto);
            }
        }

        private void frmCompras_Load(object sender, EventArgs e)
        {
            foreach (Producto producto in miProducto.misProductos)
            {
                cbxID.Items.Add(producto.IDProducto);
            }
        }

        private void btnFinalizarCompra_Click_1(object sender, EventArgs e)
        {
            if (txtIDCompra.Text == "")
            {
                MessageBox.Show("Ingrese un ID para la compra");
                return;
            }

            var compra = new Compra
            {
                FechaCompra = DateTime.Now,
                IDCompra = txtIDCompra.Text,
                TotalCompra = miCompra.TotalCompra,
                misProductosCompra = miCompra.misProductosCompra,
            };
            miCompra.misCompras.Add(compra);
            miCompra.SerializarListaCompra();

            miCompra.FinalizarCompra();
            MessageBox.Show("Los productos se han agregado al inventario");

            ActualizarDataGrid();

            LimpiarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            foreach (Control control in datosContainer.Controls)
            {
                if (control.Text.Trim() == "" || control.Text == "0.00" || control.Text == "0")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }
            }

            var producto = new Producto
            {
                IDProducto = int.Parse(cbxID.Text),
                NombreProducto = txtNombre.Text,
                StockProducto = (int)nudCantidad.Value,
                Proveedor = txtProveedor.Text,
                PrecioCompra = (decimal)nudPrecioCompra.Value,
                PrecioVenta = (decimal)nudPrecioVenta.Value,
            };

            foreach (Producto miProducto in miProducto.misProductos)
            {
                if (miProducto.IDProducto.ToString() == cbxID.Text && miProducto.NombreProducto != txtNombre.Text)
                {
                    MessageBox.Show($"El ID {cbxID.Text} ya está registrado con otro producto, favor de verificar.");
                    return;
                }
            }

            miCompra.misProductosCompra.Add(producto);
            miCompra.CalcularTotal();
            lblPrecioAPagar.Text = $"Precio a pagar: {miCompra.TotalCompra}";
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            miCompra.misProductosCompra.RemoveAt(dtgProductosCompra.CurrentCell.RowIndex);
            miCompra.CalcularTotal();
            lblPrecioAPagar.Text = $"Precio a pagar: {miCompra.TotalCompra}";
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private void dtgProductosCompra_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgProductosCompra.CurrentCell.RowIndex >= 0 && dtgProductosCompra.CurrentCell.RowIndex < miCompra.misProductosCompra.Count)
            {
                cbxID.Text = miCompra.misProductosCompra[dtgProductosCompra.CurrentCell.RowIndex].IDProducto.ToString();
                txtNombre.Text = miCompra.misProductosCompra[dtgProductosCompra.CurrentCell.RowIndex].NombreProducto;
                nudPrecioCompra.Value = (decimal)miCompra.misProductosCompra[dtgProductosCompra.CurrentCell.RowIndex].PrecioCompra;
                nudPrecioVenta.Value = (decimal)miCompra.misProductosCompra[dtgProductosCompra.CurrentCell.RowIndex].PrecioVenta;
                txtProveedor.Text = miCompra.misProductosCompra[dtgProductosCompra.CurrentCell.RowIndex].Proveedor;
            }
        }

        private void LimpiarDatos()
        {
            foreach (Control control in datosContainer.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                ComboBox cbx = control as ComboBox;
                if (control is TextBox) control.Text = "";
                if (control is NumericUpDown) nud.Value = 0;
                if (control is ComboBox) cbx.Text = "";
            }
        }

        private void frmCompras_Load_1(object sender, EventArgs e)
        {
            foreach (Producto producto in miProducto.misProductos)
            {
                cbxID.Items.Add(producto.IDProducto);
            }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxID.Text = miProducto.misProductos[cbxID.SelectedIndex].IDProducto.ToString();
            txtNombre.Text = miProducto.misProductos[cbxID.SelectedIndex].NombreProducto;
            nudPrecioCompra.Value = (decimal)miProducto.misProductos[cbxID.SelectedIndex].PrecioCompra;
            nudPrecioVenta.Value = (decimal)miProducto.misProductos[cbxID.SelectedIndex].PrecioVenta;
            txtProveedor.Text = miProducto.misProductos[cbxID.SelectedIndex].Proveedor;
        }
    }
}