﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public static class Serializador
    {
        private static string carpeta = @"..\..\..\DatosJson\";

        public static void Serializar(string nombreArchivo, object miObjeto)
        {
            Directory.CreateDirectory(carpeta);

            using (Stream stream = File.Open(carpeta + nombreArchivo, FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(stream);
                try
                {
                    sw.Write(JsonConvert.SerializeObject(miObjeto));
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static T Deserializar<T>(string nombreArchivo)
        {
            Directory.CreateDirectory(carpeta);

            T objeto;
            using (Stream stream = File.Open(carpeta + nombreArchivo, FileMode.OpenOrCreate))
            {
                if (stream.Length == 0) return default;
                try
                {
                    objeto = JsonConvert.DeserializeObject<T>(stream.ToString());
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return objeto;
        }
    }

    [Serializable]
    public class Cliente
    {
        public List<Cliente> misClientes = new List<Cliente>();

        public string Correo { get; set; }
        public string IDCliente { get; set; }
        public string NombreCliente { get; set; }
        public string Telefono { get; set; }

        public void AñadirCliente(Cliente miCliente)
        {
            misClientes.Add(miCliente);
            Serializador.Serializar("misClientes.dat", misClientes);
        }

        public void DeserializarLista()
        {
            if (Serializador.Deserializar<List<Cliente>>("misClientes.dat") == default) return;

            misClientes = Serializador.Deserializar<List<Cliente>>("misClientes.dat");
            Serializador.Serializar("misClientes.dat", misClientes);
        }

        public void EliminarCliente(int index)
        {
            misClientes.RemoveAt(index);
            Serializador.Serializar("misClientes.dat", misClientes);
        }
    }

    [Serializable]
    public class Compra
    {
        public List<Compra> misCompras = new List<Compra>();
        public List<Producto> misProductosCompra = new List<Producto>();

        public DateTime FechaCompra { get; set; }
        public string IDCompra { get; set; }
        public decimal TotalCompra { get; set; }

        public decimal CalcularTotal()
        {
            TotalCompra = 0;
            foreach (Producto miProducto in misProductosCompra)
            {
                TotalCompra += miProducto.PrecioCompra * miProducto.StockProducto;
            }
            return TotalCompra;
        }

        public void FinalizarCompra()
        {
            List<Producto> productosEnMemoria = Serializador.Deserializar<List<Producto>>("misProductos.json");

            foreach (Producto miProducto in misProductosCompra)
            {
                int i = productosEnMemoria.FindIndex(x => x.IDProducto == miProducto.IDProducto);
                if (i == -1)
                {
                    productosEnMemoria.Add(miProducto);
                }
                else
                {
                    productosEnMemoria[i].StockProducto += miProducto.StockProducto;
                    productosEnMemoria[i].PrecioCompra = miProducto.PrecioCompra;
                    productosEnMemoria[i].PrecioVenta = miProducto.PrecioVenta;
                }
            }

            Serializador.Serializar("misProductos.json", productosEnMemoria);
        }

        public void SerializarListaCompra()
        {
            Serializador.Serializar("misCompras.json", misCompras);
        }

        public List<Compra> DeserializarListaCompra()
        {
            if (Serializador.Deserializar<List<Compra>>("misCompras.json") == default) return misCompras;
            return misCompras = Serializador.Deserializar<List<Compra>>("misCompras.json");
        }
    }

    [Serializable]
    public class Producto
    {
        public List<Producto> misProductos = new List<Producto>();

        public int IDProducto { get; set; }
        public string imagenProducto { get; set; }
        public string NombreImagen { get; set; }
        public string Proveedor { get; set; } //Se agregó proveedor
        public string NombreProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockProducto { get; set; }

        public async Task<string> AñadirProducto(Producto miProducto)
        {
            var oProducto = new Producto();
            oProducto.IDProducto = miProducto.IDProducto;
            oProducto.NombreProducto = miProducto.NombreProducto;
            //oProducto.Proveedor = miProducto.Proveedor;
            oProducto.PrecioCompra = miProducto.PrecioCompra;
            oProducto.PrecioVenta = miProducto.PrecioVenta;
            oProducto.StockProducto = miProducto.StockProducto;
            oProducto.imagenProducto = miProducto.imagenProducto;
            oProducto.NombreImagen = miProducto.NombreImagen;
            string posturl = "http://apiventas.somee.com/api/product";

            var stringPayload = JsonConvert.SerializeObject(oProducto);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();
            var httpResponse = await httpClient.PostAsync(posturl, httpContent);
            var responseContent = await httpResponse.Content.ReadAsStringAsync();
            Producto obj = JsonConvert.DeserializeObject<Producto>(responseContent);

            CargarProductos();
            return "Producto agregado";
        }

        public async Task<string> CargarProductos()
        {
            string uri = "http://apiventas.somee.com/api/product/";
            string respuesta = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                respuesta = reader.ReadToEnd();
            }

            misProductos = JsonConvert.DeserializeObject<List<Producto>>(respuesta);

            return "Lista cargada";
        }

        public async Task<HttpWebResponse> EliminarProducto(int index)
        {
            string sURL = "http://apiventas.somee.com/api/product/" + index.ToString();

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            CargarProductos();
            return response;
        }

        public async Task<Stream> GetImageFromUrl(string url)
        {
            var httpClient = new HttpClient();
            var stream = await httpClient.GetStreamAsync(url);
            return stream;
        }
    }

    [Serializable]
    public class Usuario
    {
        public List<Usuario> misUsuarios = new List<Usuario>();

        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public int IDUsuario { get; set; }
        public string mensaje { get; set; }
        public string NombreUsuario { get; set; }
        public int Rol { get; set; }

        public async Task<string> AñadirUsuario(Usuario miUsuario)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(miUsuario.Correo);

            if (!match.Success)
            {
                MessageBox.Show("Ingrese una direccion de correo valida");
            }
            else
            {
                var usuario = new Usuario();
                usuario.IDUsuario = miUsuario.IDUsuario;
                usuario.Correo = miUsuario.Correo;
                usuario.Contraseña = miUsuario.Contraseña;
                usuario.Rol = miUsuario.Rol;
                usuario.NombreUsuario = miUsuario.NombreUsuario;
                string posturl = "http://apiventas.somee.com/api/userauth/register";

                var stringPayload = JsonConvert.SerializeObject(usuario);
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                var httpClient = new HttpClient();
                var httpResponse = await httpClient.PostAsync(posturl, httpContent);
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                Usuario obj = JsonConvert.DeserializeObject<Usuario>(responseContent);

                CargarLista();
            }
            return "Usuario agregado correctamente";
        }

        public void CargarLista()
        {
            string url = "http://apiventas.somee.com/api/user";
            string respuesta = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                respuesta = reader.ReadToEnd();
            }

            misUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(respuesta);
        }

        public async Task<HttpWebResponse> EliminarUsuario(int index)
        {
            string sURL = "http://apiventas.somee.com/api/user/" + index.ToString();

            WebRequest request = WebRequest.Create(sURL);
            request.Method = "DELETE";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            CargarLista();
            return response;
        }
    }

    public class Venta
    {
        public int Cantidad { get; set; }
        public DateTime FechaVenta { get; set; }
        public string IDVenta { get; set; }
        public double Montocambio { get; set; }
        public double MontoPago { get; set; }
        public double Precio { get; set; }
        public double TotalCompra { get; set; }
    }
}