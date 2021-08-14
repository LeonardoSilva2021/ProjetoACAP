namespace APP.Foms
{
    partial class FrmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlLogoLogin = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.lblSisCadasLogin = new System.Windows.Forms.Label();
            this.picLogoLogin = new System.Windows.Forms.PictureBox();
            this.pnlLogin = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.btnSairLogin = new System.Windows.Forms.Button();
            this.btnCancelarLogin = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtNovamSnhaLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSenhaLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNomeUsuLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNomeUsuLogin = new System.Windows.Forms.Label();
            this.lblSenhaLogin = new System.Windows.Forms.Label();
            this.lblNovamSenhaLogin = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.eliBordaLogin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pnlLogoLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogoLogin
            // 
            this.pnlLogoLogin.Controls.Add(this.lblSisCadasLogin);
            this.pnlLogoLogin.Controls.Add(this.picLogoLogin);
            this.pnlLogoLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLogoLogin.FillColor = System.Drawing.Color.SteelBlue;
            this.pnlLogoLogin.FillColor2 = System.Drawing.Color.SteelBlue;
            this.pnlLogoLogin.FillColor3 = System.Drawing.Color.SteelBlue;
            this.pnlLogoLogin.FillColor4 = System.Drawing.Color.SteelBlue;
            this.pnlLogoLogin.Location = new System.Drawing.Point(0, 0);
            this.pnlLogoLogin.Name = "pnlLogoLogin";
            this.pnlLogoLogin.ShadowDecoration.Parent = this.pnlLogoLogin;
            this.pnlLogoLogin.Size = new System.Drawing.Size(423, 487);
            this.pnlLogoLogin.TabIndex = 0;
            // 
            // lblSisCadasLogin
            // 
            this.lblSisCadasLogin.AutoSize = true;
            this.lblSisCadasLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.lblSisCadasLogin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSisCadasLogin.ForeColor = System.Drawing.Color.White;
            this.lblSisCadasLogin.Location = new System.Drawing.Point(155, 389);
            this.lblSisCadasLogin.Name = "lblSisCadasLogin";
            this.lblSisCadasLogin.Size = new System.Drawing.Size(122, 20);
            this.lblSisCadasLogin.TabIndex = 1;
            this.lblSisCadasLogin.Text = "Software ACAP";
            // 
            // picLogoLogin
            // 
            this.picLogoLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.picLogoLogin.Image = ((System.Drawing.Image)(resources.GetObject("picLogoLogin.Image")));
            this.picLogoLogin.Location = new System.Drawing.Point(61, 46);
            this.picLogoLogin.Name = "picLogoLogin";
            this.picLogoLogin.Size = new System.Drawing.Size(312, 322);
            this.picLogoLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoLogin.TabIndex = 0;
            this.picLogoLogin.TabStop = false;
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.guna2CircleButton2);
            this.pnlLogin.Controls.Add(this.guna2CircleButton1);
            this.pnlLogin.Controls.Add(this.btnSairLogin);
            this.pnlLogin.Controls.Add(this.btnCancelarLogin);
            this.pnlLogin.Controls.Add(this.btnLogin);
            this.pnlLogin.Controls.Add(this.txtNovamSnhaLogin);
            this.pnlLogin.Controls.Add(this.txtSenhaLogin);
            this.pnlLogin.Controls.Add(this.txtNomeUsuLogin);
            this.pnlLogin.Controls.Add(this.lblNomeUsuLogin);
            this.pnlLogin.Controls.Add(this.lblSenhaLogin);
            this.pnlLogin.Controls.Add(this.lblNovamSenhaLogin);
            this.pnlLogin.Controls.Add(this.lblLogin);
            this.pnlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLogin.Location = new System.Drawing.Point(423, 0);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.ShadowDecoration.Parent = this.pnlLogin;
            this.pnlLogin.Size = new System.Drawing.Size(423, 487);
            this.pnlLogin.TabIndex = 1;
            // 
            // btnSairLogin
            // 
            this.btnSairLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSairLogin.BackgroundImage")));
            this.btnSairLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSairLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSairLogin.FlatAppearance.BorderSize = 0;
            this.btnSairLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSairLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSairLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSairLogin.Location = new System.Drawing.Point(372, 16);
            this.btnSairLogin.Name = "btnSairLogin";
            this.btnSairLogin.Size = new System.Drawing.Size(34, 31);
            this.btnSairLogin.TabIndex = 20;
            this.btnSairLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancelarLogin
            // 
            this.btnCancelarLogin.BorderRadius = 18;
            this.btnCancelarLogin.CheckedState.Parent = this.btnCancelarLogin;
            this.btnCancelarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarLogin.CustomImages.Parent = this.btnCancelarLogin;
            this.btnCancelarLogin.FillColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarLogin.ForeColor = System.Drawing.Color.White;
            this.btnCancelarLogin.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarLogin.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarLogin.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnCancelarLogin.HoverState.Parent = this.btnCancelarLogin;
            this.btnCancelarLogin.Location = new System.Drawing.Point(46, 415);
            this.btnCancelarLogin.Name = "btnCancelarLogin";
            this.btnCancelarLogin.ShadowDecoration.Parent = this.btnCancelarLogin;
            this.btnCancelarLogin.Size = new System.Drawing.Size(326, 39);
            this.btnCancelarLogin.TabIndex = 18;
            this.btnCancelarLogin.Text = "Cancelar";
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 18;
            this.btnLogin.CheckedState.Parent = this.btnLogin;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.CustomImages.Parent = this.btnLogin;
            this.btnLogin.FillColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.HoverState.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.HoverState.CustomBorderColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnLogin.HoverState.Parent = this.btnLogin;
            this.btnLogin.Location = new System.Drawing.Point(46, 370);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.ShadowDecoration.Parent = this.btnLogin;
            this.btnLogin.Size = new System.Drawing.Size(326, 39);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            // 
            // txtNovamSnhaLogin
            // 
            this.txtNovamSnhaLogin.BorderColor = System.Drawing.Color.Black;
            this.txtNovamSnhaLogin.BorderRadius = 18;
            this.txtNovamSnhaLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNovamSnhaLogin.DefaultText = "Insira Novamente a Senha";
            this.txtNovamSnhaLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNovamSnhaLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNovamSnhaLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNovamSnhaLogin.DisabledState.Parent = this.txtNovamSnhaLogin;
            this.txtNovamSnhaLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNovamSnhaLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNovamSnhaLogin.FocusedState.Parent = this.txtNovamSnhaLogin;
            this.txtNovamSnhaLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovamSnhaLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtNovamSnhaLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNovamSnhaLogin.HoverState.Parent = this.txtNovamSnhaLogin;
            this.txtNovamSnhaLogin.Location = new System.Drawing.Point(87, 299);
            this.txtNovamSnhaLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNovamSnhaLogin.Name = "txtNovamSnhaLogin";
            this.txtNovamSnhaLogin.PasswordChar = '\0';
            this.txtNovamSnhaLogin.PlaceholderText = "";
            this.txtNovamSnhaLogin.SelectedText = "";
            this.txtNovamSnhaLogin.SelectionStart = 24;
            this.txtNovamSnhaLogin.ShadowDecoration.Parent = this.txtNovamSnhaLogin;
            this.txtNovamSnhaLogin.Size = new System.Drawing.Size(250, 36);
            this.txtNovamSnhaLogin.TabIndex = 16;
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.BorderColor = System.Drawing.Color.Black;
            this.txtSenhaLogin.BorderRadius = 18;
            this.txtSenhaLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenhaLogin.DefaultText = "Insira a Senha";
            this.txtSenhaLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSenhaLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSenhaLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenhaLogin.DisabledState.Parent = this.txtSenhaLogin;
            this.txtSenhaLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSenhaLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenhaLogin.FocusedState.Parent = this.txtSenhaLogin;
            this.txtSenhaLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtSenhaLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSenhaLogin.HoverState.Parent = this.txtSenhaLogin;
            this.txtSenhaLogin.Location = new System.Drawing.Point(87, 218);
            this.txtSenhaLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '\0';
            this.txtSenhaLogin.PlaceholderText = "";
            this.txtSenhaLogin.SelectedText = "";
            this.txtSenhaLogin.SelectionStart = 14;
            this.txtSenhaLogin.ShadowDecoration.Parent = this.txtSenhaLogin;
            this.txtSenhaLogin.Size = new System.Drawing.Size(250, 36);
            this.txtSenhaLogin.TabIndex = 15;
            // 
            // txtNomeUsuLogin
            // 
            this.txtNomeUsuLogin.BorderColor = System.Drawing.Color.Black;
            this.txtNomeUsuLogin.BorderRadius = 18;
            this.txtNomeUsuLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNomeUsuLogin.DefaultText = "Insira o Nome de Usuário";
            this.txtNomeUsuLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNomeUsuLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNomeUsuLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeUsuLogin.DisabledState.Parent = this.txtNomeUsuLogin;
            this.txtNomeUsuLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNomeUsuLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeUsuLogin.FocusedState.Parent = this.txtNomeUsuLogin;
            this.txtNomeUsuLogin.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeUsuLogin.ForeColor = System.Drawing.Color.Gray;
            this.txtNomeUsuLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNomeUsuLogin.HoverState.Parent = this.txtNomeUsuLogin;
            this.txtNomeUsuLogin.Location = new System.Drawing.Point(87, 140);
            this.txtNomeUsuLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomeUsuLogin.Name = "txtNomeUsuLogin";
            this.txtNomeUsuLogin.PasswordChar = '\0';
            this.txtNomeUsuLogin.PlaceholderText = "";
            this.txtNomeUsuLogin.SelectedText = "";
            this.txtNomeUsuLogin.SelectionStart = 24;
            this.txtNomeUsuLogin.ShadowDecoration.Parent = this.txtNomeUsuLogin;
            this.txtNomeUsuLogin.Size = new System.Drawing.Size(250, 36);
            this.txtNomeUsuLogin.TabIndex = 14;
            // 
            // lblNomeUsuLogin
            // 
            this.lblNomeUsuLogin.AutoSize = true;
            this.lblNomeUsuLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeUsuLogin.Location = new System.Drawing.Point(106, 115);
            this.lblNomeUsuLogin.Name = "lblNomeUsuLogin";
            this.lblNomeUsuLogin.Size = new System.Drawing.Size(146, 21);
            this.lblNomeUsuLogin.TabIndex = 13;
            this.lblNomeUsuLogin.Text = "Nome do Usuario:";
            // 
            // lblSenhaLogin
            // 
            this.lblSenhaLogin.AutoSize = true;
            this.lblSenhaLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaLogin.Location = new System.Drawing.Point(106, 193);
            this.lblSenhaLogin.Name = "lblSenhaLogin";
            this.lblSenhaLogin.Size = new System.Drawing.Size(63, 21);
            this.lblSenhaLogin.TabIndex = 12;
            this.lblSenhaLogin.Text = "Senha:";
            // 
            // lblNovamSenhaLogin
            // 
            this.lblNovamSenhaLogin.AutoSize = true;
            this.lblNovamSenhaLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovamSenhaLogin.Location = new System.Drawing.Point(106, 274);
            this.lblNovamSenhaLogin.Name = "lblNovamSenhaLogin";
            this.lblNovamSenhaLogin.Size = new System.Drawing.Size(162, 21);
            this.lblNovamSenhaLogin.TabIndex = 11;
            this.lblNovamSenhaLogin.Text = "Novamente Senha:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(176, 25);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(92, 36);
            this.lblLogin.TabIndex = 10;
            this.lblLogin.Text = "Login";
            // 
            // eliBordaLogin
            // 
            this.eliBordaLogin.BorderRadius = 30;
            this.eliBordaLogin.TargetControl = this;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.CheckedState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.CustomImages.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.BorderColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.HoverState.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.Location = new System.Drawing.Point(297, 223);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.ShadowDecoration.Parent = this.guna2CircleButton1;
            this.guna2CircleButton1.Size = new System.Drawing.Size(33, 27);
            this.guna2CircleButton1.TabIndex = 21;
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.CheckedState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.CheckedState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton2.CustomImages.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton2.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.HoverState.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton2.Image")));
            this.guna2CircleButton2.Location = new System.Drawing.Point(297, 304);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.ShadowDecoration.Parent = this.guna2CircleButton2;
            this.guna2CircleButton2.Size = new System.Drawing.Size(33, 27);
            this.guna2CircleButton2.TabIndex = 22;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.pnlLogoLogin);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Software ACAP";
            this.pnlLogoLogin.ResumeLayout(false);
            this.pnlLogoLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoLogin)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLogoLogin;
        private System.Windows.Forms.Label lblSisCadasLogin;
        private System.Windows.Forms.PictureBox picLogoLogin;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlLogin;
        private Guna.UI2.WinForms.Guna2Button btnCancelarLogin;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtNovamSnhaLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtSenhaLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtNomeUsuLogin;
        private System.Windows.Forms.Label lblNomeUsuLogin;
        private System.Windows.Forms.Label lblSenhaLogin;
        private System.Windows.Forms.Label lblNovamSenhaLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnSairLogin;
        private Guna.UI2.WinForms.Guna2Elipse eliBordaLogin;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
    }
}