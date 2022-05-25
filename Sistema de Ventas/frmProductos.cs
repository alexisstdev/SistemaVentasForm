using Microsoft.AspNetCore.Http;
using Sistema_de_Ventas.Models;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class frmProductos : Form
    {
        private Producto miProducto;

        public frmProductos(Producto _miProducto)
        {
            InitializeComponent();
            miProducto = _miProducto;
            miProducto.CargarProductos();
            ActualizarDataGrid();
        }

        private void ActualizarDataGrid()
        {
            dtgProductos.Rows.Clear();
            foreach (Producto miProducto in miProducto.misProductos)
            {
                dtgProductos.Rows.Add(miProducto.idproducto, miProducto.nombreProducto, miProducto.stockProducto, miProducto.precioCompra, miProducto.precioVenta);
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
                    indexBusqueda = miProducto.misProductos.FindIndex(x => x.nombreProducto.Contains(txtBusqueda.Text));
                    break;

                case "ID":
                    indexBusqueda = miProducto.misProductos.FindIndex(x => x.idproducto.ToString().Contains(txtBusqueda.Text));
                    break;

                case "stock":
                    indexBusqueda = miProducto.misProductos.FindIndex(x => x.stockProducto == Int32.Parse(txtBusqueda.Text));
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

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await miProducto.EliminarProducto(miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].idproducto);
            ActualizarDataGrid();
            LimpiarDatos();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            string imgBase64 = "";
            string nombreImg = "";
            if (openFileDialog1.FileName != null)
            {
                string ruta = lblImg.Text;
                string base64img = "";
                var ms = new MemoryStream();
                var bitmap = new Bitmap(ruta);
                bitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] data = new byte[ms.Length - 1];
                data = ms.GetBuffer();
                imgBase64 = Convert.ToBase64String(data);


                string[] arr = ruta.Split('\\');
                nombreImg = arr[arr.Length - 1].ToString();
            }
            else
            {
                MessageBox.Show("Selecciona una foto");
            }
            



            foreach (Control control in datosContainer.Controls)
            {
                if (control.Text.Trim() == "" || control.Text == "0.00")
                {
                    MessageBox.Show("Todos los campos son obligatorios");
                    return;
                }
            }

            if (miProducto.misProductos.FindIndex(x => x.idproducto.ToString() == txtID.Text) != -1)
            {
                var messageBox = MessageBox.Show($"Ya existe un producto con el ID: {txtID.Text} ¿Desea sobreescribirlo?", "",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

                if (messageBox == DialogResult.No) return;
                else miProducto.EliminarProducto(miProducto.misProductos.FindIndex(x => x.idproducto.ToString() == txtID.Text));
            }
            var producto = new Producto
            {
                idproducto = int.Parse(txtID.Text),
                nombreProducto = txtNombre.Text,
                stockProducto = int.Parse(nudStock.Value.ToString()),
                precioCompra = decimal.Parse(nudCompra.Value.ToString()),
                precioVenta = decimal.Parse(nudVenta.Value.ToString()),
                imagenProducto = imgBase64,
                NombreImagen = nombreImg
            };

            await miProducto.AñadirProducto(producto);

            ActualizarDataGrid();

            LimpiarDatos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarDatos();
        }

        private void dtgProductos_SelectionChanged(object sender, EventArgs e)
        {
            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData("http://apiventas.somee.com/api/product/img/" + miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].idproducto.ToString());
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);


          

            lblIndex.Text = $"{dtgProductos.CurrentCell.RowIndex}";

            

            if (dtgProductos.CurrentCell.RowIndex >= 0 && dtgProductos.CurrentCell.RowIndex < miProducto.misProductos.Count)
            {
                pct_Imagen.Image = img;
                txtID.Text = miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].idproducto.ToString();
                txtNombre.Text = miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].nombreProducto;
                nudStock.Value = decimal.Parse(miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].stockProducto.ToString());
                nudCompra.Value = (decimal)miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].precioCompra;
                nudVenta.Value = (decimal)miProducto.misProductos[dtgProductos.CurrentCell.RowIndex].precioVenta;
                
            }
        }

        private async void frmProductos_Load(object sender, EventArgs e)
        {
            await miProducto.CargarProductos();
            ActualizarDataGrid();

            LimpiarDatos();
        }

        private void LimpiarDatos()
        {
            foreach (Control control in datosContainer.Controls)
            {
                NumericUpDown nud = control as NumericUpDown;
                if (control is TextBox) control.Text = "";
                if (control is NumericUpDown) nud.Value = 0;
            }
        }

        
        private void btnSelectImg_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                lblImg.Text = openFileDialog1.FileName;
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}