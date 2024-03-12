using DevExpress.XtraEditors;
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
        public formMenuPrincipal()
        {
            InitializeComponent();
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

    }
}