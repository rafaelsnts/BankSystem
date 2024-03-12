using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem
{
    public partial class formCadastrarUsuario : DevExpress.XtraEditors.XtraForm
    {
        public formCadastrarUsuario()
        {
            InitializeComponent();
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            string apiUrl = "https://localhost:7152/Usuario/Inserir";
            // Criar um HttpClient
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string jsonBody = @"{
                    ""usu_nome"": """ + txtUsuario.Text + @""",
                    ""usu_email"": """ + txtEmail.Text + @""",
                    ""usu_senha"": """ + txtSenha.Text + @"""        
                    }";

                    client.DefaultRequestHeaders.Add("Accept", "application/json");

                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(apiUrl, content);

                    string responseBody = "";

                    if (response.IsSuccessStatusCode)
                    {
                        responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseBody);
                    }
                    else
                    {
                        responseBody = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"{responseBody}");
                    }
                }
                catch (HttpRequestException ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao tentar fazer login: {ex.Message}");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}