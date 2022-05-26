using Newtonsoft.Json;
using Sistema_de_Ventas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Ventas
{
    public partial class Login : Form
    {
        private AuthRequest user = new AuthRequest();

        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            string url = "http://apiventas.somee.com/api/userauth/login";

            user.Email = txtNombre.Text;
            user.Password = txtContraseña.Text;

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(user.Email);

            if (!match.Success)
            {
                MessageBox.Show("Ingrese una direccion de correo valida");
            }
            else
            {
                var stringPayload = JsonConvert.SerializeObject(user);
                var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
                var httpClient = new HttpClient();
                var httpResponse = await httpClient.PostAsync(url, httpContent);
                var responseContent = await httpResponse.Content.ReadAsStringAsync();
                Usuario obj = JsonConvert.DeserializeObject<Usuario>(responseContent);

                if (obj.mensaje == "Sesion iniciada correctamente" && obj.mensaje != "ninguna sesion activa")
                {
                    Inicio form = new Inicio(obj);
                    form.Show();
                    this.Hide();
                    form.FormClosing += frmClosing;
                }
                else
                {
                    MessageBox.Show("Datos incorrectos");
                }
            }
        }

        private async void frmClosing(object sender, FormClosingEventArgs e)
        {
            string url = "http://apiventas.somee.com/api/userauth/logout";
            var stringPayload = JsonConvert.SerializeObject(user);
            var httpContent = new StringContent(stringPayload, Encoding.UTF8, "application/json");
            var httpClient = new HttpClient();
            var httpResponse = await httpClient.PostAsync(url, httpContent);
            var responseContent = await httpResponse.Content.ReadAsStringAsync();
            Usuario obj = JsonConvert.DeserializeObject<Usuario>(responseContent);
            txtContraseña.Text = "";
            txtNombre.Text = "";
            this.Show();
        }
    }
}