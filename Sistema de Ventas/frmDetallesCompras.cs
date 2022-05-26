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
    public partial class frmDetallesCompras : Form
    {
        private Compra miCompra = new Compra();

        public frmDetallesCompras()
        {
            InitializeComponent();
        }

        private void frmDetallesCompras_Load(object sender, EventArgs e)
        {
            miCompra.DeserializarListaCompra();
            foreach (Compra compra in miCompra.misCompras)
            {
                cbxID.Items.Add(compra.IDCompra);
            }
        }

        private void ActualizarDataGrid()
        {
            dtgProductosComprados.Rows.Clear();
            foreach (Compra miCompra in miCompra.misCompras)
            {
                foreach (Producto miProducto in miCompra.misProductosCompra)
                {
                    dtgProductosComprados.Rows.Add(miProducto.IDProducto, miProducto.NombreProducto, miProducto.PrecioCompra, miProducto.StockProducto, miProducto.PrecioCompra * miProducto.StockProducto);
                }
            }
        }

        private void cbxID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarDataGrid();

            lblDatos.Text = $"ID de la compra: {miCompra.misCompras[cbxID.SelectedIndex].IDCompra}\n" +
                            $"Fecha: {miCompra.misCompras[cbxID.SelectedIndex].FechaCompra}";

            lblMontoTotal.Text = $"Monto total: {miCompra.misCompras[cbxID.SelectedIndex].TotalCompra}";
        }
    }
}