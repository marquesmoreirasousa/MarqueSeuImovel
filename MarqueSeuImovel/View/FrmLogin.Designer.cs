namespace MarqueSeuImovel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pcbLogo = new System.Windows.Forms.PictureBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.panelBackLogin = new System.Windows.Forms.Panel();
            this.btnInsertProperty = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.txbPass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).BeginInit();
            this.panelBackLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbLogo
            // 
            this.pcbLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pcbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbLogo.Image = global::MarqueSeuImovel.Properties.Resources.Logo_corretor_de_imóveis_azul_e_laranja_1;
            this.pcbLogo.Location = new System.Drawing.Point(259, 3);
            this.pcbLogo.Name = "pcbLogo";
            this.pcbLogo.Size = new System.Drawing.Size(506, 351);
            this.pcbLogo.TabIndex = 0;
            this.pcbLogo.TabStop = false;
            this.pcbLogo.Tag = "Logo";
            // 
            // txbUser
            // 
            this.txbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUser.Location = new System.Drawing.Point(48, 268);
            this.txbUser.MaxLength = 20;
            this.txbUser.Multiline = true;
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(284, 32);
            this.txbUser.TabIndex = 1;
            // 
            // panelBackLogin
            // 
            this.panelBackLogin.BackColor = System.Drawing.Color.OrangeRed;
            this.panelBackLogin.Controls.Add(this.btnInsertProperty);
            this.panelBackLogin.Controls.Add(this.lblPass);
            this.panelBackLogin.Controls.Add(this.btnLogin);
            this.panelBackLogin.Controls.Add(this.lblUser);
            this.panelBackLogin.Controls.Add(this.txbPass);
            this.panelBackLogin.Controls.Add(this.txbUser);
            this.panelBackLogin.Location = new System.Drawing.Point(327, 146);
            this.panelBackLogin.Name = "panelBackLogin";
            this.panelBackLogin.Size = new System.Drawing.Size(370, 450);
            this.panelBackLogin.TabIndex = 2;
            // 
            // btnInsertProperty
            // 
            this.btnInsertProperty.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertProperty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.btnInsertProperty.Location = new System.Drawing.Point(135, 399);
            this.btnInsertProperty.Name = "btnInsertProperty";
            this.btnInsertProperty.Size = new System.Drawing.Size(116, 35);
            this.btnInsertProperty.TabIndex = 6;
            this.btnInsertProperty.Text = "Cadastrar";
            this.btnInsertProperty.UseVisualStyleBackColor = true;
            this.btnInsertProperty.Click += new System.EventHandler(this.btnInsertProperty_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblPass.Location = new System.Drawing.Point(44, 318);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(77, 24);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "SENHA";
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.btnLogin.Location = new System.Drawing.Point(257, 399);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 35);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblUser.Location = new System.Drawing.Point(44, 239);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(98, 24);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "USUÁRIO";
            // 
            // txbPass
            // 
            this.txbPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPass.Location = new System.Drawing.Point(48, 345);
            this.txbPass.MaxLength = 20;
            this.txbPass.Multiline = true;
            this.txbPass.Name = "txbPass";
            this.txbPass.Size = new System.Drawing.Size(284, 32);
            this.txbPass.TabIndex = 2;
            // 
            // FrmBroker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1004, 747);
            this.Controls.Add(this.pcbLogo);
            this.Controls.Add(this.panelBackLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBroker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarqueSeuImóvel";
            ((System.ComponentModel.ISupportInitialize)(this.pcbLogo)).EndInit();
            this.panelBackLogin.ResumeLayout(false);
            this.panelBackLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbLogo;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Panel panelBackLogin;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnInsertProperty;
    }
}