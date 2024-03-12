using BankSystem.Forms;
using BankSystem.ModelsJson;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        formMenuPrincipal menuPrincipal = new formMenuPrincipal();

        public formLogin()
        {
            InitializeComponent();
        }
        private async void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                var dadosLogin = new
                {
                    usu_nome = txtUsuario.Text,
                    usu_senha = txtSenha.Text,
                };

                string jsonDadosLogin = JsonConvert.SerializeObject(dadosLogin);

                string apiUrl = $"https://localhost:7152/Usuario/Login?nomeUsuario={dadosLogin.usu_nome}&senha={dadosLogin.usu_senha}";

                using (var httpClient = new HttpClient())
                {
                    httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseBody = await response.Content.ReadAsStringAsync();

                        //UsuarioJsonDTO usuario = JsonConvert.DeserializeObject<UsuarioJsonDTO>(responseBody);

                        MessageBox.Show(responseBody);
                        menuPrincipal.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show($"Falha no login. Status: {response.StatusCode}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar fazer login: {ex.Message}");
            }

        }

        private void btnCadastarSe_Click(object sender, EventArgs e)
        {
            formCadastrarUsuario formCadastrarUsuario = new formCadastrarUsuario();
            formCadastrarUsuario.ShowDialog();
        }
    }
}
