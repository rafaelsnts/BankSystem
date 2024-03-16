namespace BankSystem.Forms
{
    partial class formMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            btnEditarPerfil = new DevExpress.XtraBars.BarButtonItem();
            btnDetalharPerfil = new DevExpress.XtraBars.BarButtonItem();
            btnRemoverUsuario = new DevExpress.XtraBars.BarButtonItem();
            barSubItem3 = new DevExpress.XtraBars.BarSubItem();
            btnCadastrarCategoria = new DevExpress.XtraBars.BarButtonItem();
            btnListarCategorias = new DevExpress.XtraBars.BarButtonItem();
            barSubItem4 = new DevExpress.XtraBars.BarSubItem();
            btnCadastrarTransacao = new DevExpress.XtraBars.BarButtonItem();
            btnEditarTransacao = new DevExpress.XtraBars.BarButtonItem();
            btnListarTransacao = new DevExpress.XtraBars.BarButtonItem();
            btnDetalharTransacao = new DevExpress.XtraBars.BarButtonItem();
            btnObterExtrato = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            pnl_Inicio = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pnl_Inicio).BeginInit();
            SuspendLayout();
            // 
            // barManager1
            // 
            barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barSubItem1, btnRemoverUsuario, barSubItem2, barButtonItem2, barSubItem3, barSubItem4, btnEditarPerfil, btnDetalharPerfil, btnCadastrarCategoria, btnListarCategorias, btnCadastrarTransacao, btnEditarTransacao, btnListarTransacao, btnDetalharTransacao, btnObterExtrato });
            barManager1.MainMenu = bar2;
            barManager1.MaxItemId = 15;
            barManager1.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barSubItem1), new DevExpress.XtraBars.LinkPersistInfo(barSubItem3), new DevExpress.XtraBars.LinkPersistInfo(barSubItem4) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // barSubItem1
            // 
            barSubItem1.Caption = "Usuario";
            barSubItem1.Id = 0;
            barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnEditarPerfil), new DevExpress.XtraBars.LinkPersistInfo(btnDetalharPerfil), new DevExpress.XtraBars.LinkPersistInfo(btnRemoverUsuario) });
            barSubItem1.Name = "barSubItem1";
            // 
            // btnEditarPerfil
            // 
            btnEditarPerfil.Caption = "Editar Perfil";
            btnEditarPerfil.Id = 6;
            btnEditarPerfil.Name = "btnEditarPerfil";
            btnEditarPerfil.ItemClick += btnEditarPerfil_ItemClick;
            // 
            // btnDetalharPerfil
            // 
            btnDetalharPerfil.Caption = "Detalhar Perfil";
            btnDetalharPerfil.Id = 7;
            btnDetalharPerfil.Name = "btnDetalharPerfil";
            btnDetalharPerfil.ItemClick += btnDetalharPerfil_ItemClick;
            // 
            // btnRemoverUsuario
            // 
            btnRemoverUsuario.Caption = "Remover";
            btnRemoverUsuario.Id = 1;
            btnRemoverUsuario.Name = "btnRemoverUsuario";
            btnRemoverUsuario.ItemClick += btnRemoverUsuario_ItemClick;
            // 
            // barSubItem3
            // 
            barSubItem3.Caption = "Categoria";
            barSubItem3.Id = 4;
            barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnCadastrarCategoria), new DevExpress.XtraBars.LinkPersistInfo(btnListarCategorias) });
            barSubItem3.Name = "barSubItem3";
            // 
            // btnCadastrarCategoria
            // 
            btnCadastrarCategoria.Caption = "Cadastrar ";
            btnCadastrarCategoria.Id = 8;
            btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            // 
            // btnListarCategorias
            // 
            btnListarCategorias.Caption = "Listar Categorias";
            btnListarCategorias.Id = 9;
            btnListarCategorias.Name = "btnListarCategorias";
            // 
            // barSubItem4
            // 
            barSubItem4.Caption = "Transação";
            barSubItem4.Id = 5;
            barSubItem4.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnCadastrarTransacao), new DevExpress.XtraBars.LinkPersistInfo(btnEditarTransacao), new DevExpress.XtraBars.LinkPersistInfo(btnListarTransacao), new DevExpress.XtraBars.LinkPersistInfo(btnDetalharTransacao), new DevExpress.XtraBars.LinkPersistInfo(btnObterExtrato) });
            barSubItem4.Name = "barSubItem4";
            // 
            // btnCadastrarTransacao
            // 
            btnCadastrarTransacao.Caption = "Cadastrar";
            btnCadastrarTransacao.Id = 10;
            btnCadastrarTransacao.Name = "btnCadastrarTransacao";
            btnCadastrarTransacao.ItemClick += btnCadastrarTransacao_ItemClick;
            // 
            // btnEditarTransacao
            // 
            btnEditarTransacao.Caption = "Editar";
            btnEditarTransacao.Id = 11;
            btnEditarTransacao.Name = "btnEditarTransacao";
            // 
            // btnListarTransacao
            // 
            btnListarTransacao.Caption = "Listar Transações";
            btnListarTransacao.Id = 12;
            btnListarTransacao.Name = "btnListarTransacao";
            // 
            // btnDetalharTransacao
            // 
            btnDetalharTransacao.Caption = "Detalhar";
            btnDetalharTransacao.Id = 13;
            btnDetalharTransacao.Name = "btnDetalharTransacao";
            // 
            // btnObterExtrato
            // 
            btnObterExtrato.Caption = "Obter Extrato";
            btnObterExtrato.Id = 14;
            btnObterExtrato.Name = "btnObterExtrato";
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(951, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 466);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(951, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 20);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 446);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(951, 20);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 446);
            // 
            // barSubItem2
            // 
            barSubItem2.Caption = "Editar Perfil";
            barSubItem2.Id = 2;
            barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItem2) });
            barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem2
            // 
            barButtonItem2.Caption = "barButtonItem2";
            barButtonItem2.Id = 3;
            barButtonItem2.Name = "barButtonItem2";
            // 
            // pnl_Inicio
            // 
            pnl_Inicio.Location = new Point(0, 26);
            pnl_Inicio.Name = "pnl_Inicio";
            pnl_Inicio.Size = new Size(951, 460);
            pnl_Inicio.TabIndex = 4;
            // 
            // formMenuPrincipal
            // 
            Appearance.Options.UseFont = true;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 486);
            Controls.Add(pnl_Inicio);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "formMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formMenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pnl_Inicio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnRemoverUsuario;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem3;
        private DevExpress.XtraBars.BarSubItem barSubItem4;
        private DevExpress.XtraBars.BarButtonItem btnEditarPerfil;
        private DevExpress.XtraBars.BarButtonItem btnDetalharPerfil;
        private DevExpress.XtraBars.BarButtonItem btnCadastrarCategoria;
        private DevExpress.XtraBars.BarButtonItem btnListarCategorias;
        private DevExpress.XtraBars.BarButtonItem btnCadastrarTransacao;
        private DevExpress.XtraBars.BarButtonItem btnEditarTransacao;
        private DevExpress.XtraBars.BarButtonItem btnListarTransacao;
        private DevExpress.XtraBars.BarButtonItem btnDetalharTransacao;
        private DevExpress.XtraBars.BarButtonItem btnObterExtrato;
        private DevExpress.XtraEditors.PanelControl pnl_Inicio;
    }
}