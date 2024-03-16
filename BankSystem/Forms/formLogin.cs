using BankSystem.Forms;
using BankSystem.ModelsJson;
using DevExpress.DataAccess.Native.Web;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Import.Xls;
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

                    var content = new StringContent(jsonDadosLogin, Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await httpClient.PostAsync(apiUrl, content);

                    string responseData = "";

                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();

                        UsuarioJsonDTO dadosUsuario = JsonConvert.DeserializeObject<UsuarioJsonDTO>(responseData);
                        //MessageBox.Show($"Usuario: {dadosUsuario.UsuNome} \nSenha: {dadosUsuario.UsuSenha} \nEmail: {dadosUsuario.UsuEmail}");

                        formMenuPrincipal menuPrincipal = new formMenuPrincipal(dadosUsuario);
                        menuPrincipal.ShowDialog();
                    }
                    else
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Falha na solicitação, Erro: \n" + responseData);
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
