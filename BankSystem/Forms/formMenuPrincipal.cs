using BankSystem.Models;
using BankSystem.ModelsJson;
using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankSystem.Forms
{
    public partial class formMenuPrincipal : DevExpress.XtraEditors.XtraForm
    {
        private UsuarioJsonDTO usuarioLogado;

        public formMenuPrincipal(UsuarioJsonDTO _usuarioLogado)
        {
            InitializeComponent();
            usuarioLogado = _usuarioLogado;
            
        }

      
        public void showChildForminPanel(object Form)
        {
            if (this.pnl_Inicio.Controls.Count > 0)
            {
                this.pnl_Inicio.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pnl_Inicio.Controls.Add(form);
            form.Show();
        }

        private void btnEditarPerfil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnDetalharPerfil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRemoverUsuario_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnCadastrarTransacao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            formCadastrarTransacoes abrircadastrarTransacoes = new formCadastrarTransacoes(usuarioLogado.UsuNome);
            abrircadastrarTransacoes.ShowDialog();
        }
    }
}