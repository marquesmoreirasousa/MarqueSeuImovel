namespace MarqueSeuImovel
{
    partial class FrmBroker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBroker));
            this.txbBroker = new System.Windows.Forms.TextBox();
            this.panelBackBroker = new System.Windows.Forms.Panel();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblCodeArea = new System.Windows.Forms.Label();
            this.txbCodeArea = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txbTelephone = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.cmbState = new System.Windows.Forms.ComboBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.lblBrokerCode = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBroker = new System.Windows.Forms.Label();
            this.txbBrokerCode = new System.Windows.Forms.TextBox();
            this.ltvBroker = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBrokerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCodeArea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelephone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDelete = new System.Windows.Forms.Button();
            this.ttpBroker = new System.Windows.Forms.ToolTip(this.components);
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelBackBroker.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbBroker
            // 
            this.txbBroker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBroker.Location = new System.Drawing.Point(21, 45);
            this.txbBroker.MaxLength = 70;
            this.txbBroker.Multiline = true;
            this.txbBroker.Name = "txbBroker";
            this.txbBroker.Size = new System.Drawing.Size(736, 32);
            this.txbBroker.TabIndex = 1;
            // 
            // panelBackBroker
            // 
            this.panelBackBroker.BackColor = System.Drawing.Color.OrangeRed;
            this.panelBackBroker.Controls.Add(this.lblPassword);
            this.panelBackBroker.Controls.Add(this.txbPassword);
            this.panelBackBroker.Controls.Add(this.lblCodeArea);
            this.panelBackBroker.Controls.Add(this.txbCodeArea);
            this.panelBackBroker.Controls.Add(this.lblTelephone);
            this.panelBackBroker.Controls.Add(this.txbTelephone);
            this.panelBackBroker.Controls.Add(this.lblEmail);
            this.panelBackBroker.Controls.Add(this.txbEmail);
            this.panelBackBroker.Controls.Add(this.lblState);
            this.panelBackBroker.Controls.Add(this.cmbState);
            this.panelBackBroker.Controls.Add(this.lblBrokerCode);
            this.panelBackBroker.Controls.Add(this.lblBroker);
            this.panelBackBroker.Controls.Add(this.txbBrokerCode);
            this.panelBackBroker.Controls.Add(this.txbBroker);
            this.panelBackBroker.Location = new System.Drawing.Point(12, 12);
            this.panelBackBroker.Name = "panelBackBroker";
            this.panelBackBroker.Size = new System.Drawing.Size(785, 244);
            this.panelBackBroker.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblPassword.Location = new System.Drawing.Point(490, 153);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 24);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Senha";
            // 
            // txbPassword
            // 
            this.txbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPassword.Location = new System.Drawing.Point(494, 184);
            this.txbPassword.MaxLength = 20;
            this.txbPassword.Multiline = true;
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(262, 32);
            this.txbPassword.TabIndex = 15;
            // 
            // lblCodeArea
            // 
            this.lblCodeArea.AutoSize = true;
            this.lblCodeArea.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblCodeArea.Location = new System.Drawing.Point(490, 79);
            this.lblCodeArea.Name = "lblCodeArea";
            this.lblCodeArea.Size = new System.Drawing.Size(52, 24);
            this.lblCodeArea.TabIndex = 14;
            this.lblCodeArea.Text = "DDD";
            // 
            // txbCodeArea
            // 
            this.txbCodeArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodeArea.Location = new System.Drawing.Point(494, 110);
            this.txbCodeArea.MaxLength = 20;
            this.txbCodeArea.Multiline = true;
            this.txbCodeArea.Name = "txbCodeArea";
            this.txbCodeArea.Size = new System.Drawing.Size(68, 32);
            this.txbCodeArea.TabIndex = 13;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelephone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblTelephone.Location = new System.Drawing.Point(588, 79);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(114, 24);
            this.lblTelephone.TabIndex = 12;
            this.lblTelephone.Text = "TELEFONE";
            // 
            // txbTelephone
            // 
            this.txbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelephone.Location = new System.Drawing.Point(592, 110);
            this.txbTelephone.MaxLength = 20;
            this.txbTelephone.Multiline = true;
            this.txbTelephone.Name = "txbTelephone";
            this.txbTelephone.Size = new System.Drawing.Size(165, 32);
            this.txbTelephone.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblEmail.Location = new System.Drawing.Point(17, 153);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 24);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "EMAIL";
            // 
            // txbEmail
            // 
            this.txbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmail.Location = new System.Drawing.Point(21, 184);
            this.txbEmail.MaxLength = 50;
            this.txbEmail.Multiline = true;
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(439, 32);
            this.txbEmail.TabIndex = 9;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblState.Location = new System.Drawing.Point(207, 81);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(91, 24);
            this.lblState.TabIndex = 8;
            this.lblState.Text = "ESTADO";
            // 
            // cmbState
            // 
            this.cmbState.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbState.FormattingEnabled = true;
            this.cmbState.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cmbState.Location = new System.Drawing.Point(211, 110);
            this.cmbState.Name = "cmbState";
            this.cmbState.Size = new System.Drawing.Size(249, 32);
            this.cmbState.TabIndex = 7;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.btnInsert.Location = new System.Drawing.Point(805, 161);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(118, 43);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Inserir";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // lblBrokerCode
            // 
            this.lblBrokerCode.AutoSize = true;
            this.lblBrokerCode.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrokerCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblBrokerCode.Location = new System.Drawing.Point(17, 81);
            this.lblBrokerCode.Name = "lblBrokerCode";
            this.lblBrokerCode.Size = new System.Drawing.Size(70, 24);
            this.lblBrokerCode.TabIndex = 5;
            this.lblBrokerCode.Text = "CRECI";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.btnClear.Location = new System.Drawing.Point(805, 51);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(118, 45);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Limpar";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblBroker
            // 
            this.lblBroker.AutoSize = true;
            this.lblBroker.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblBroker.Location = new System.Drawing.Point(17, 16);
            this.lblBroker.Name = "lblBroker";
            this.lblBroker.Size = new System.Drawing.Size(122, 24);
            this.lblBroker.TabIndex = 3;
            this.lblBroker.Text = "CORRETOR";
            // 
            // txbBrokerCode
            // 
            this.txbBrokerCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbBrokerCode.Location = new System.Drawing.Point(21, 110);
            this.txbBrokerCode.MaxLength = 20;
            this.txbBrokerCode.Multiline = true;
            this.txbBrokerCode.Name = "txbBrokerCode";
            this.txbBrokerCode.Size = new System.Drawing.Size(150, 32);
            this.txbBrokerCode.TabIndex = 2;
            // 
            // ltvBroker
            // 
            this.ltvBroker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmBrokerName,
            this.clmCode,
            this.clmState,
            this.clmCodeArea,
            this.clmTelephone,
            this.clmEmail});
            this.ltvBroker.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltvBroker.FullRowSelect = true;
            this.ltvBroker.HideSelection = false;
            this.ltvBroker.Location = new System.Drawing.Point(12, 282);
            this.ltvBroker.Name = "ltvBroker";
            this.ltvBroker.Size = new System.Drawing.Size(911, 348);
            this.ltvBroker.TabIndex = 7;
            this.ttpBroker.SetToolTip(this.ltvBroker, "Clique duas vezes para alterar um corretor.");
            this.ltvBroker.UseCompatibleStateImageBehavior = false;
            this.ltvBroker.View = System.Windows.Forms.View.Details;
            this.ltvBroker.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltvBroker_MouseDoubleClick);
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            // 
            // clmBrokerName
            // 
            this.clmBrokerName.Text = "Corretor";
            this.clmBrokerName.Width = 243;
            // 
            // clmCode
            // 
            this.clmCode.Text = "CRECI";
            this.clmCode.Width = 74;
            // 
            // clmState
            // 
            this.clmState.Text = "Estado";
            this.clmState.Width = 70;
            // 
            // clmCodeArea
            // 
            this.clmCodeArea.Text = "DDD";
            this.clmCodeArea.Width = 49;
            // 
            // clmTelephone
            // 
            this.clmTelephone.Text = "Telefone";
            this.clmTelephone.Width = 120;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 353;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.btnDelete.Location = new System.Drawing.Point(805, 213);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 43);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Segoe Fluent Icons", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.btnUpdate.Location = new System.Drawing.Point(805, 106);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 45);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Editar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // FrmBroker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(935, 642);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.ltvBroker);
            this.Controls.Add(this.panelBackBroker);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBroker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarqueSeuImóvel";
            this.Load += new System.EventHandler(this.FrmBroker_Load);
            this.panelBackBroker.ResumeLayout(false);
            this.panelBackBroker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txbBroker;
        private System.Windows.Forms.Panel panelBackBroker;
        private System.Windows.Forms.TextBox txbBrokerCode;
        private System.Windows.Forms.Label lblBroker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBrokerCode;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.ComboBox cmbState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txbTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblCodeArea;
        private System.Windows.Forms.TextBox txbCodeArea;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.ListView ltvBroker;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmBrokerName;
        private System.Windows.Forms.ColumnHeader clmCode;
        private System.Windows.Forms.ColumnHeader clmState;
        private System.Windows.Forms.ColumnHeader clmCodeArea;
        private System.Windows.Forms.ColumnHeader clmTelephone;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ToolTip ttpBroker;
        private System.Windows.Forms.Button btnUpdate;
    }
}