namespace BankSystem
{
    partial class formLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formLogin));
            txtUsuario = new DevExpress.XtraEditors.TextEdit();
            txtSenha = new DevExpress.XtraEditors.TextEdit();
            separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            btnCadastarSe = new DevExpress.XtraEditors.SimpleButton();
            btnLogar = new DevExpress.XtraEditors.SimpleButton();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(283, 60);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Properties.Appearance.Options.UseFont = true;
            txtUsuario.Size = new Size(204, 26);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(283, 142);
            txtSenha.Name = "txtSenha";
            txtSenha.Properties.Appearance.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtSenha.Properties.Appearance.Options.UseFont = true;
            txtSenha.Size = new Size(204, 26);
            txtSenha.TabIndex = 1;
            // 
            // separatorControl1
            // 
            separatorControl1.LineOrientation = Orientation.Vertical;
            separatorControl1.Location = new Point(234, 5);
            separatorControl1.Name = "separatorControl1";
            separatorControl1.Size = new Size(25, 233);
            separatorControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            panelControl1.AutoSize = true;
            panelControl1.Controls.Add(labelControl3);
            panelControl1.Controls.Add(btnCadastarSe);
            panelControl1.Controls.Add(btnLogar);
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
            panelControl1.TabIndex = 3;
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
            // btnCadastarSe
            // 
            btnCadastarSe.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastarSe.Appearance.Options.UseFont = true;
            btnCadastarSe.Location = new Point(388, 196);
            btnCadastarSe.Name = "btnCadastarSe";
            btnCadastarSe.Size = new Size(99, 34);
            btnCadastarSe.TabIndex = 6;
            btnCadastarSe.Text = "Cadastre-se";
            btnCadastarSe.Click += btnCadastarSe_Click;
            // 
            // btnLogar
            // 
            btnLogar.Appearance.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogar.Appearance.Options.UseFont = true;
            btnLogar.Location = new Point(283, 196);
            btnLogar.Name = "btnLogar";
            btnLogar.Size = new Size(99, 34);
            btnLogar.TabIndex = 5;
            btnLogar.Text = "Logar";
            btnLogar.Click += btnLogar_Click;
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new Point(283, 29);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(65, 25);
            labelControl2.TabIndex = 4;
            labelControl2.Text = "Usuario";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new Point(283, 111);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(52, 25);
            labelControl1.TabIndex = 3;
            labelControl1.Text = "Senha";
            // 
            // pictureEdit1
            // 
            pictureEdit1.EditValue = resources.GetObject("pictureEdit1.EditValue");
            pictureEdit1.Location = new Point(5, 5);
            pictureEdit1.Name = "pictureEdit1";
            pictureEdit1.Properties.Appearance.BackColor = SystemColors.ButtonFace;
            pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.ZoomAcceleration = 0D;
            pictureEdit1.Size = new Size(223, 233);
            pictureEdit1.TabIndex = 8;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 242);
            Controls.Add(panelControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "formLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)txtUsuario.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtSenha.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)separatorControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtSenha;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnCadastarSe;
    }
}