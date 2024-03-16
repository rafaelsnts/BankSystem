namespace BankSystem.Forms
{
    partial class formCadastrarTransacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastrarTransacoes));
            txtDescricao = new DevExpress.XtraEditors.TextEdit();
            txtData = new DevExpress.XtraEditors.TextEdit();
            txtUsuarioTransacao = new DevExpress.XtraEditors.TextEdit();
            txtValor = new DevExpress.XtraEditors.TextEdit();
            txtCategoria = new DevExpress.XtraEditors.TextEdit();
            btn_Salvar = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl6 = new DevExpress.XtraEditors.LabelControl();
            gdvTransacoes = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            cmbListaCategoria = new DevExpress.XtraEditors.ComboBoxEdit();
            cmbTipo = new DevExpress.XtraEditors.ComboBoxEdit();
            popupMenu1 = new DevExpress.XtraBars.PopupMenu(components);
            btnEditar = new DevExpress.XtraBars.BarButtonItem();
            btnRemover = new DevExpress.XtraBars.BarButtonItem();
            barManager1 = new DevExpress.XtraBars.BarManager(components);
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)txtDescricao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtData.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuarioTransacao.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtValor.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtCategoria.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gdvTransacoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbListaCategoria.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipo.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
            SuspendLayout();
            // 
            // txtDescricao
            // 
            txtDescricao.EditValue = "";
            txtDescricao.Location = new Point(12, 178);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescricao.Properties.Appearance.Options.UseFont = true;
            txtDescricao.Properties.AutoHeight = false;
            txtDescricao.Size = new Size(474, 62);
            txtDescricao.TabIndex = 1;
            // 
            // txtData
            // 
            txtData.EditValue = "26/08/1995";
            txtData.Location = new Point(654, 23);
            txtData.Name = "txtData";
            txtData.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtData.Properties.Appearance.Options.UseFont = true;
            txtData.Size = new Size(285, 26);
            txtData.TabIndex = 2;
            // 
            // txtUsuarioTransacao
            // 
            txtUsuarioTransacao.EditValue = "";
            txtUsuarioTransacao.Enabled = false;
            txtUsuarioTransacao.Location = new Point(12, 23);
            txtUsuarioTransacao.Name = "txtUsuarioTransacao";
            txtUsuarioTransacao.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuarioTransacao.Properties.Appearance.Options.UseFont = true;
            txtUsuarioTransacao.Size = new Size(474, 26);
            txtUsuarioTransacao.TabIndex = 3;
            // 
            // txtValor
            // 
            txtValor.EditValue = "200";
            txtValor.Location = new Point(654, 77);
            txtValor.Name = "txtValor";
            txtValor.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtValor.Properties.Appearance.Options.UseFont = true;
            txtValor.Size = new Size(285, 26);
            txtValor.TabIndex = 4;
            // 
            // txtCategoria
            // 
            txtCategoria.EditValue = "Exibir o nome da categoria CMB MOSTRAR O LOGADO";
            txtCategoria.Location = new Point(130, 274);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCategoria.Properties.Appearance.Options.UseFont = true;
            txtCategoria.Size = new Size(474, 26);
            txtCategoria.TabIndex = 5;
            // 
            // btn_Salvar
            // 
            btn_Salvar.Location = new Point(718, 187);
            btn_Salvar.Name = "btn_Salvar";
            btn_Salvar.Size = new Size(157, 47);
            btn_Salvar.TabIndex = 7;
            btn_Salvar.Text = "SALVAR";
            btn_Salvar.Click += btn_Salvar_Click;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(13, 160);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(50, 13);
            labelControl1.TabIndex = 8;
            labelControl1.Text = "Descrição:";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(655, 4);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(27, 13);
            labelControl2.TabIndex = 9;
            labelControl2.Text = "Data:";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(12, 4);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(40, 13);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "Usuario:";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(654, 58);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(28, 13);
            labelControl4.TabIndex = 11;
            labelControl4.Text = "Valor:";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(12, 58);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(51, 13);
            labelControl5.TabIndex = 12;
            labelControl5.Text = "Categoria:";
            // 
            // labelControl6
            // 
            labelControl6.Location = new Point(12, 109);
            labelControl6.Name = "labelControl6";
            labelControl6.Size = new Size(24, 13);
            labelControl6.TabIndex = 13;
            labelControl6.Text = "Tipo:";
            // 
            // gdvTransacoes
            // 
            gdvTransacoes.Location = new Point(12, 246);
            gdvTransacoes.MainView = gridView1;
            gdvTransacoes.Name = "gdvTransacoes";
            gdvTransacoes.Size = new Size(927, 202);
            gdvTransacoes.TabIndex = 14;
            gdvTransacoes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gdvTransacoes;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.PopupMenuShowing += gridView1_PopupMenuShowing;
            // 
            // cmbListaCategoria
            // 
            cmbListaCategoria.Location = new Point(13, 77);
            cmbListaCategoria.Name = "cmbListaCategoria";
            cmbListaCategoria.Properties.AutoHeight = false;
            cmbListaCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbListaCategoria.Size = new Size(473, 26);
            cmbListaCategoria.TabIndex = 15;
            // 
            // cmbTipo
            // 
            cmbTipo.Location = new Point(13, 126);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Properties.AutoHeight = false;
            cmbTipo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            cmbTipo.Properties.Items.AddRange(new object[] { "ENTRADA", "SAÍDA" });
            cmbTipo.Size = new Size(473, 26);
            cmbTipo.TabIndex = 16;
            // 
            // popupMenu1
            // 
            popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(btnEditar), new DevExpress.XtraBars.LinkPersistInfo(btnRemover) });
            popupMenu1.Manager = barManager1;
            popupMenu1.Name = "popupMenu1";
            // 
            // btnEditar
            // 
            btnEditar.Caption = "Editar";
            btnEditar.Id = 0;
            btnEditar.ImageOptions.Image = (Image)resources.GetObject("btnEditar.ImageOptions.Image");
            btnEditar.ImageOptions.LargeImage = (Image)resources.GetObject("btnEditar.ImageOptions.LargeImage");
            btnEditar.Name = "btnEditar";
            // 
            // btnRemover
            // 
            btnRemover.Caption = "Remover";
            btnRemover.Id = 1;
            btnRemover.ImageOptions.Image = (Image)resources.GetObject("btnRemover.ImageOptions.Image");
            btnRemover.ImageOptions.LargeImage = (Image)resources.GetObject("btnRemover.ImageOptions.LargeImage");
            btnRemover.Name = "btnRemover";
            // 
            // barManager1
            // 
            barManager1.DockControls.Add(barDockControlTop);
            barManager1.DockControls.Add(barDockControlBottom);
            barManager1.DockControls.Add(barDockControlLeft);
            barManager1.DockControls.Add(barDockControlRight);
            barManager1.Form = this;
            barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { btnEditar, btnRemover });
            barManager1.MaxItemId = 2;
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = DockStyle.Top;
            barDockControlTop.Location = new Point(0, 0);
            barDockControlTop.Manager = barManager1;
            barDockControlTop.Size = new Size(951, 0);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = DockStyle.Bottom;
            barDockControlBottom.Location = new Point(0, 460);
            barDockControlBottom.Manager = barManager1;
            barDockControlBottom.Size = new Size(951, 0);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = DockStyle.Left;
            barDockControlLeft.Location = new Point(0, 0);
            barDockControlLeft.Manager = barManager1;
            barDockControlLeft.Size = new Size(0, 460);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = DockStyle.Right;
            barDockControlRight.Location = new Point(951, 0);
            barDockControlRight.Manager = barManager1;
            barDockControlRight.Size = new Size(0, 460);
            // 
            // formCadastrarTransacoes
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 460);
            Controls.Add(cmbTipo);
            Controls.Add(cmbListaCategoria);
            Controls.Add(gdvTransacoes);
            Controls.Add(labelControl6);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(btn_Salvar);
            Controls.Add(txtCategoria);
            Controls.Add(txtValor);
            Controls.Add(txtUsuarioTransacao);
            Controls.Add(txtData);
            Controls.Add(txtDescricao);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCadastrarTransacoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCadastrarTransacoes";
            ((System.ComponentModel.ISupportInitialize)txtDescricao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtData.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuarioTransacao.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtValor.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtCategoria.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)gdvTransacoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbListaCategoria.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)cmbTipo.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu1).EndInit();
            ((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtDescricao;
        private DevExpress.XtraEditors.TextEdit txtData;
        private DevExpress.XtraEditors.TextEdit txtValor;
        private DevExpress.XtraEditors.TextEdit txtCategoria;
        private DevExpress.XtraEditors.SimpleButton btn_Salvar;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl gdvTransacoes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        public DevExpress.XtraEditors.TextEdit txtUsuarioTransacao;
        private DevExpress.XtraEditors.ComboBoxEdit cmbListaCategoria;
        private DevExpress.XtraEditors.ComboBoxEdit cmbTipo;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnEditar;
        private DevExpress.XtraBars.BarButtonItem btnRemover;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}