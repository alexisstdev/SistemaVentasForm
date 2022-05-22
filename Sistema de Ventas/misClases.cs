using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

namespace Sistema_de_Ventas
{
    public class Compra
    {
        public int Cantidad { get; set; }
        public DateTime FechaCompra { get; set; }
        public string IDCompra { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public double TotalCompra { get; set; }
    }

    [Serializable]
    public class Producto
    {
        public List<Producto> misProductos = new List<Producto>();

        public string IDProducto { get; set; }
        public string NombreProducto { get; set; }
        public double PrecioCompra { get; set; }
        public double PrecioVenta { get; set; }
        public int StockProducto { get; set; }

        public void AñadirProducto(Producto miProducto)
        {
            misProductos.Add(miProducto);
            Serializador.Serializar("misProductos.dat", misProductos);
        }

        public void EliminarProducto(int index)
        {
            misProductos.RemoveAt(index);
            Serializador.Serializar("misProductos.dat", misProductos);
        }

        public void DeserializarLista()
        {
            if (Serializador.Deserializar<List<Producto>>("misProductos.dat") == default) return;

            misProductos = Serializador.Deserializar<List<Producto>>("misProductos.dat");
            Serializador.Serializar("misProductos.dat", misProductos);
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

        public void EliminarCliente(int index)
        {
            misClientes.RemoveAt(index);
            Serializador.Serializar("misClientes.dat", misClientes);
        }

        public void DeserializarLista()
        {
            if (Serializador.Deserializar<List<Cliente>>("misClientes.dat") == default) return;

            misClientes = Serializador.Deserializar<List<Cliente>>("misClientes.dat");
            Serializador.Serializar("misClientes.dat", misClientes);
        }
    }

    [Serializable]
    public class Usuario
    {
        public List<Usuario> misUsuarios = new List<Usuario>();
        public string Contraseña { get; set; }
        public string Correo { get; set; }
        public string IDUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }

        public void AñadirUsuario(Usuario miUsuario)
        {
            misUsuarios.Add(miUsuario);
            Serializador.Serializar("misUsuarios.dat", misUsuarios);
        }

        public void EliminarUsuario(int index)
        {
            misUsuarios.RemoveAt(index);
            Serializador.Serializar("misUsuarios.dat", misUsuarios);
        }

        public void DeserializarLista()
        {
            if (Serializador.Deserializar<List<Usuario>>("misUsuarios.dat") == default) return;

            misUsuarios = Serializador.Deserializar<List<Usuario>>("misUsuarios.dat");
            Serializador.Serializar("misUsuarios.dat", misUsuarios);
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

    public static class Serializador
    {
        private static BinaryFormatter bin = new BinaryFormatter();

        public static void Serializar(string nombreArchivo, object miObjeto)
        {
            using (Stream stream = File.Open(nombreArchivo, FileMode.Create))
            {
                try
                {
                    bin.Serialize(stream, miObjeto);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static T Deserializar<T>(string nombreArchivo)
        {
            T objeto;
            using (Stream stream = File.Open(nombreArchivo, FileMode.OpenOrCreate))
            {
                if (stream.Length == 0) return default;
                try
                {
                    objeto = (T)bin.Deserialize(stream);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return objeto;
        }
    }
}