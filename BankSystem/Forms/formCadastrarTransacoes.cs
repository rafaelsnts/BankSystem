using BankSystem.Models;
using BankSystem.ModelsJson;
using DevExpress.Pdf.Native.BouncyCastle.Asn1.Ocsp;
using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Forms
{
    public partial class formCadastrarTransacoes : DevExpress.XtraEditors.XtraForm
    {
        private string nomeUsuario;
        private List<TransacaoJsonTDO> listaTransacoes = new List<TransacaoJsonTDO>();
        public formCadastrarTransacoes(string nomeUsuario)
        {
            InitializeComponent();
            CarregarComboBoxCategoria();
            GdvExibirTransacoes();
            this.nomeUsuario = nomeUsuario;
            txtUsuarioTransacao.Text = nomeUsuario;

            btnEditar.ItemClick += BtnEditar_ItemClick;
            btnRemover.ItemClick += BtnRemover_ItemClick;
        }

        private void BtnRemover_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (gridView1.SelectedRowsCount > 0)
            {
                int selecionarLinha = gridView1.FocusedRowHandle;
                TransacaoJsonTDO transacao = (TransacaoJsonTDO)gridView1.GetRow(selecionarLinha);
                listaTransacoes.Remove(transacao);

                //aqui tem que deletar a transacao la do banco.
                DeletarTransacao(transacao.TraId);
                GdvExibirTransacoes();
            }
            else
            {
                MessageBox.Show("Selecione uma linha na lista para remover.");
            }
        }

        private void BtnEditar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Botao de editar a transacao
        }

        private async void GdvExibirTransacoes()
        {

            string apiUrl = "https://localhost:7152/Transacao/Buscar";

            try
            {
                using (var transacao = new HttpClient())
                {
                    // Faz a requisição HTTP GET para obter a lista em JSON
                    HttpResponseMessage response = await transacao.GetAsync(apiUrl);
                    string responseData = "";
                    // Verifica se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Converte o conteúdo da resposta para uma lista de strings
                        responseData = await response.Content.ReadAsStringAsync();

                        listaTransacoes = JsonConvert.DeserializeObject<List<TransacaoJsonTDO>>(responseData);

                        gdvTransacoes.DataSource = listaTransacoes;

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
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private async void CarregarComboBoxCategoria()
        {
            string apiUrl = "https://localhost:7152/Categoria/Buscar";

            try
            {
                using (var categoria = new HttpClient())
                {
                    // Faz a requisição HTTP GET para obter a lista em JSON
                    HttpResponseMessage response = await categoria.GetAsync(apiUrl);
                    string responseData = "";
                    // Verifica se a requisição foi bem-sucedida
                    if (response.IsSuccessStatusCode)
                    {
                        // Converte o conteúdo da resposta para uma lista de strings
                        responseData = await response.Content.ReadAsStringAsync();

                        // Adiciona os itens da lista na ComboBox
                        var dados = JsonConvert.DeserializeObject<List<CategoriaJsonTDO>>(responseData);

                        foreach (CategoriaJsonTDO categ in dados)
                        {
                            cmbListaCategoria.Properties.Items.Add(categ.CatDescricao);

                        }

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
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private async void btn_Salvar_Click(object sender, EventArgs e)
        {

            string apiUrl = "https://localhost:7152/Transacao/Inserir";

            using (HttpClient transacao = new HttpClient())
            {
                try
                {
                    var jsonBody = new
                    {
                        tra_descricao = txtDescricao.Text,
                        tra_valor = txtValor.Text,
                        tra_data = Convert.ToDateTime(txtData.Text),
                        tra_tipo = cmbTipo.Text,
                        tra_fk_categoria_id = 1,
                        tra_fk_usuario_id = 1
                    };

                    string json = JsonConvert.SerializeObject(jsonBody);


                    transacao.DefaultRequestHeaders.Add("Accept", "application/json");


                    var content = new StringContent(json, Encoding.UTF8, "application/json");


                    HttpResponseMessage response = await transacao.PostAsync(apiUrl, content);

                    string responseData = "";
                    if (response.IsSuccessStatusCode)
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                        MessageBox.Show(responseData);
                    }
                    else
                    {
                        responseData = await response.Content.ReadAsStringAsync();
                        MessageBox.Show("Falha na solicitação, Erro: \n" + responseData);
                    }
                }
                catch (HttpRequestException ex)
                {

                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void gridView1_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            if (e.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.RowCell)
            {
                e.Allow = false;
                popupMenu1.ShowPopup(gdvTransacoes.PointToScreen(e.Point));

            }
        }


        
        private async Task DeletarTransacao(long idTransacao)
        { 

            string url = "https://localhost:7152/Transacao/Deletar?_idTransacao=" + idTransacao;

            using (var deletarId = new HttpClient())
            {
                deletarId.DefaultRequestHeaders.Add("Accept", "application/json");
                HttpResponseMessage response = await deletarId.DeleteAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string deletar = await response.Content.ReadAsStringAsync();
                    MessageBox.Show(deletar);
                }
                else
                {
                    MessageBox.Show("Falha ao deletar transação.");
                }

            }
           
        }
    }
}
    
