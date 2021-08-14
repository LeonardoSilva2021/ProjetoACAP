namespace APP
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.pnlMenuLat = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btnMensalidade = new Guna.UI2.WinForms.Guna2Button();
            this.btnInscrição = new Guna.UI2.WinForms.Guna2Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picSlide = new System.Windows.Forms.PictureBox();
            this.eliBordaMenu = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlForms = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.topFecharMenu = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.pnlMenuLat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuLat
            // 
            this.pnlMenuLat.Controls.Add(this.btnSair);
            this.pnlMenuLat.Controls.Add(this.guna2Button2);
            this.pnlMenuLat.Controls.Add(this.guna2Button1);
            this.pnlMenuLat.Controls.Add(this.btnMensalidade);
            this.pnlMenuLat.Controls.Add(this.btnInscrição);
            this.pnlMenuLat.Controls.Add(this.picLogo);
            this.pnlMenuLat.Controls.Add(this.picSlide);
            this.pnlMenuLat.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenuLat.Location = new System.Drawing.Point(0, 6);
            this.pnlMenuLat.Name = "pnlMenuLat";
            this.pnlMenuLat.Size = new System.Drawing.Size(214, 576);
            this.pnlMenuLat.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSair.BackgroundImage")));
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(164, 528);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(40, 36);
            this.btnSair.TabIndex = 5;
            this.topFecharMenu.SetToolTip(this.btnSair, "Fechar");
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 20;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.CheckedState.Image")));
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Location = new System.Drawing.Point(11, 421);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 4;
            this.guna2Button2.Text = "Inscrição";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.CheckedChanged += new System.EventHandler(this.Guna2Button2_CheckedChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 20;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.CheckedState.Image")));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Location = new System.Drawing.Point(11, 339);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Inscrição";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.CheckedChanged += new System.EventHandler(this.Guna2Button2_CheckedChanged);
            // 
            // btnMensalidade
            // 
            this.btnMensalidade.BackColor = System.Drawing.Color.Transparent;
            this.btnMensalidade.BorderRadius = 20;
            this.btnMensalidade.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnMensalidade.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnMensalidade.CheckedState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensalidade.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnMensalidade.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnMensalidade.CheckedState.Image")));
            this.btnMensalidade.CheckedState.Parent = this.btnMensalidade;
            this.btnMensalidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMensalidade.CustomImages.Parent = this.btnMensalidade;
            this.btnMensalidade.FillColor = System.Drawing.Color.SteelBlue;
            this.btnMensalidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensalidade.ForeColor = System.Drawing.Color.White;
            this.btnMensalidade.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnMensalidade.HoverState.Parent = this.btnMensalidade;
            this.btnMensalidade.Image = ((System.Drawing.Image)(resources.GetObject("btnMensalidade.Image")));
            this.btnMensalidade.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnMensalidade.Location = new System.Drawing.Point(11, 264);
            this.btnMensalidade.Name = "btnMensalidade";
            this.btnMensalidade.ShadowDecoration.Parent = this.btnMensalidade;
            this.btnMensalidade.Size = new System.Drawing.Size(180, 45);
            this.btnMensalidade.TabIndex = 2;
            this.btnMensalidade.Text = "Mensalidade";
            this.btnMensalidade.UseTransparentBackground = true;
            this.btnMensalidade.CheckedChanged += new System.EventHandler(this.Guna2Button2_CheckedChanged);
            // 
            // btnInscrição
            // 
            this.btnInscrição.BackColor = System.Drawing.Color.Transparent;
            this.btnInscrição.BorderRadius = 20;
            this.btnInscrição.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnInscrição.Checked = true;
            this.btnInscrição.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnInscrição.CheckedState.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscrição.CheckedState.ForeColor = System.Drawing.Color.Black;
            this.btnInscrição.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("btnInscrição.CheckedState.Image")));
            this.btnInscrição.CheckedState.Parent = this.btnInscrição;
            this.btnInscrição.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscrição.CustomImages.Parent = this.btnInscrição;
            this.btnInscrição.FillColor = System.Drawing.Color.SteelBlue;
            this.btnInscrição.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscrição.ForeColor = System.Drawing.Color.White;
            this.btnInscrição.HoverState.FillColor = System.Drawing.Color.SteelBlue;
            this.btnInscrição.HoverState.Parent = this.btnInscrição;
            this.btnInscrição.Image = ((System.Drawing.Image)(resources.GetObject("btnInscrição.Image")));
            this.btnInscrição.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInscrição.Location = new System.Drawing.Point(11, 175);
            this.btnInscrição.Name = "btnInscrição";
            this.btnInscrição.ShadowDecoration.Parent = this.btnInscrição;
            this.btnInscrição.Size = new System.Drawing.Size(180, 45);
            this.btnInscrição.TabIndex = 1;
            this.btnInscrição.Text = "Inscrição";
            this.btnInscrição.UseTransparentBackground = true;
            this.btnInscrição.CheckedChanged += new System.EventHandler(this.Guna2Button2_CheckedChanged);
            // 
            // picLogo
            // 
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(11, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(190, 126);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picSlide
            // 
            this.picSlide.BackColor = System.Drawing.Color.Transparent;
            this.picSlide.Image = ((System.Drawing.Image)(resources.GetObject("picSlide.Image")));
            this.picSlide.Location = new System.Drawing.Point(175, 144);
            this.picSlide.Name = "picSlide";
            this.picSlide.Size = new System.Drawing.Size(39, 104);
            this.picSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSlide.TabIndex = 1;
            this.picSlide.TabStop = false;
            // 
            // eliBordaMenu
            // 
            this.eliBordaMenu.BorderRadius = 30;
            this.eliBordaMenu.TargetControl = this;
            // 
            // pnlForms
            // 
            this.pnlForms.BorderRadius = 20;
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(214, 6);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.ShadowDecoration.Parent = this.pnlForms;
            this.pnlForms.Size = new System.Drawing.Size(900, 576);
            this.pnlForms.TabIndex = 1;
            this.pnlForms.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlForms_Paint);
            // 
            // topFecharMenu
            // 
            this.topFecharMenu.AllowLinksHandling = true;
            this.topFecharMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topFecharMenu.ForeColor = System.Drawing.Color.Black;
            this.topFecharMenu.MaximumSize = new System.Drawing.Size(0, 0);
            this.topFecharMenu.ShowAlways = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1120, 588);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.pnlMenuLat);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMenu";
            this.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrição - Software ACAP";
            this.pnlMenuLat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuLat;
        private Guna.UI2.WinForms.Guna2Button btnMensalidade;
        private Guna.UI2.WinForms.Guna2Button btnInscrição;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picSlide;
        private Guna.UI2.WinForms.Guna2Elipse eliBordaMenu;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pnlForms;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button btnSair;
        private Guna.UI2.WinForms.Guna2HtmlToolTip topFecharMenu;
    }
}

