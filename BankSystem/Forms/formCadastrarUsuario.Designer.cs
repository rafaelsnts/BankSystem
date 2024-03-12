namespace BankSystem
{
    partial class formCadastrarUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCadastrarUsuario));
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            txtEmail = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btnCadastrar = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            txtUsuario = new DevExpress.XtraEditors.TextEdit();
            txtSenha = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            SuspendLayout();
            // 
            // separatorControl1
            // 
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.Location = new Point(229, -3);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new Size(25, 252);
            separatorControl1.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(5, 0);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = SystemColors.ButtonFace;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.ZoomAcceleration = 0D;
            pictureEdit1.Size = new Size(223, 249);
            pictureEdit1.TabIndex = 8;
            // 
            // panelControl1
            // 
            panelControl1.AutoSize = true;
            panelControl1.Controls.Add(btnCancelar);
            panelControl1.Controls.Add(labelControl4);
            panelControl1.Controls.Add(txtEmail);
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(btnCadastrar);
            panelControl1.Controls.Add(labelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Controls.Add(txtUsuario);
            panelControl1.Controls.Add(separatorControl1);
            panelControl1.Controls.Add(txtSenha);
            panelControl1.Controls.Add(pictureEdit1);
            panelControl1.Dock = DockStyle.Fill;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(516, 242);
            panelControl1.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Appearance.Options.UseFont = true;
            btnCancelar.Location = new Point(388, 203);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 34);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new Point(283, 68);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(55, 25);
            labelControl4.TabIndex = 10;
            labelControl4.Text = "E-mail";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(283, 99);
            txtEmail.Name = "txtEmail";
            txtEmail.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Properties.Appearance.Options.UseFont = true;
            txtEmail.Size = new Size(204, 26);
            txtEmail.TabIndex = 9;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new Point(63, 184);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(109, 25);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Bank System";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrar.Appearance.Options.UseFont = true;
            btnCadastrar.Location = new Point(283, 203);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(99, 34);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(283, 5);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(65, 25);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Usuario";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(283, 131);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(52, 25);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(283, 36);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Properties.Appearance.Options.UseFont = true;
            txtUsuario.Size = new Size(204, 26);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(283, 162);
            txtSenha.Name = "txtSenha";
            txtSenha.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Properties.Appearance.Options.UseFont = true;
            txtSenha.Size = new Size(204, 26);
            txtSenha.TabIndex = 1;
            // 
            // formCadastrarUsuario
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 242);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formCadastrarUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formCadastrarUsuario";
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtEmail.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCadastrar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
    }
}