namespace MarqueSeuImovel
{
    partial class FrmProperty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProperty));
            this.lblCode = new System.Windows.Forms.Label();
            this.txbCode = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblObjective = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbObjective = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.txbParkingSpots = new System.Windows.Forms.TextBox();
            this.lblParkingSpots = new System.Windows.Forms.Label();
            this.txbBathroom = new System.Windows.Forms.TextBox();
            this.lblBathroom = new System.Windows.Forms.Label();
            this.txbRooms = new System.Windows.Forms.TextBox();
            this.lblRooms = new System.Windows.Forms.Label();
            this.txbDistrict = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txbLandArea = new System.Windows.Forms.TextBox();
            this.lblLandArea = new System.Windows.Forms.Label();
            this.txbLandBuild = new System.Windows.Forms.TextBox();
            this.lblLandBuild = new System.Windows.Forms.Label();
            this.txbIPTUTax = new System.Windows.Forms.TextBox();
            this.lblIPTUTax = new System.Windows.Forms.Label();
            this.txbPriceCondo = new System.Windows.Forms.TextBox();
            this.lblPriceCondo = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pcbImage = new System.Windows.Forms.PictureBox();
            this.pnlOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblCode.Location = new System.Drawing.Point(16, 13);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(67, 23);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "Código";
            this.toolTip1.SetToolTip(this.lblCode, "Coloque o nome completo do usuário!");
            // 
            // txbCode
            // 
            this.txbCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbCode.Enabled = false;
            this.txbCode.Location = new System.Drawing.Point(20, 37);
            this.txbCode.Margin = new System.Windows.Forms.Padding(4);
            this.txbCode.Name = "txbCode";
            this.txbCode.Size = new System.Drawing.Size(93, 26);
            this.txbCode.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbCode, "Digite aqui o nome completo do usuário.");
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.btnShow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnShow.Location = new System.Drawing.Point(769, 419);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 57);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "SALVAR";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblObjective
            // 
            this.lblObjective.AutoSize = true;
            this.lblObjective.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObjective.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblObjective.Location = new System.Drawing.Point(16, 70);
            this.lblObjective.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObjective.Name = "lblObjective";
            this.lblObjective.Size = new System.Drawing.Size(78, 23);
            this.lblObjective.TabIndex = 5;
            this.lblObjective.Text = "Objetivo";
            this.toolTip1.SetToolTip(this.lblObjective, "Coloque o nome completo do usuário!");
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblType.Location = new System.Drawing.Point(16, 132);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 23);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Tipo";
            this.toolTip1.SetToolTip(this.lblType, "Coloque o nome completo do usuário!");
            // 
            // txbCity
            // 
            this.txbCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbCity.Location = new System.Drawing.Point(20, 215);
            this.txbCity.Margin = new System.Windows.Forms.Padding(4);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(160, 26);
            this.txbCity.TabIndex = 4;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblCity.Location = new System.Drawing.Point(16, 191);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(67, 23);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "Cidade";
            // 
            // cmbObjective
            // 
            this.cmbObjective.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.cmbObjective.FormattingEnabled = true;
            this.cmbObjective.Items.AddRange(new object[] {
            "VENDA",
            "LOCAÇÃO"});
            this.cmbObjective.Location = new System.Drawing.Point(20, 94);
            this.cmbObjective.Margin = new System.Windows.Forms.Padding(4);
            this.cmbObjective.Name = "cmbObjective";
            this.cmbObjective.Size = new System.Drawing.Size(160, 27);
            this.cmbObjective.TabIndex = 6;
            // 
            // cmbType
            // 
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "APARTAMENTO",
            "CASA",
            "CHÁCARA",
            "TERRENO"});
            this.cmbType.Location = new System.Drawing.Point(20, 155);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 27);
            this.cmbType.TabIndex = 8;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // pnlOptions
            // 
            this.pnlOptions.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlOptions.Controls.Add(this.txbParkingSpots);
            this.pnlOptions.Controls.Add(this.lblParkingSpots);
            this.pnlOptions.Controls.Add(this.txbBathroom);
            this.pnlOptions.Controls.Add(this.lblBathroom);
            this.pnlOptions.Controls.Add(this.txbRooms);
            this.pnlOptions.Controls.Add(this.lblRooms);
            this.pnlOptions.Location = new System.Drawing.Point(478, 61);
            this.pnlOptions.Margin = new System.Windows.Forms.Padding(4);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(135, 201);
            this.pnlOptions.TabIndex = 9;
            // 
            // txbParkingSpots
            // 
            this.txbParkingSpots.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbParkingSpots.Location = new System.Drawing.Point(17, 164);
            this.txbParkingSpots.Margin = new System.Windows.Forms.Padding(4);
            this.txbParkingSpots.Name = "txbParkingSpots";
            this.txbParkingSpots.Size = new System.Drawing.Size(93, 26);
            this.txbParkingSpots.TabIndex = 10;
            // 
            // lblParkingSpots
            // 
            this.lblParkingSpots.AutoSize = true;
            this.lblParkingSpots.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingSpots.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblParkingSpots.Location = new System.Drawing.Point(13, 140);
            this.lblParkingSpots.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblParkingSpots.Name = "lblParkingSpots";
            this.lblParkingSpots.Size = new System.Drawing.Size(61, 23);
            this.lblParkingSpots.TabIndex = 9;
            this.lblParkingSpots.Text = "Vagas";
            // 
            // txbBathroom
            // 
            this.txbBathroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbBathroom.Location = new System.Drawing.Point(17, 101);
            this.txbBathroom.Margin = new System.Windows.Forms.Padding(4);
            this.txbBathroom.Name = "txbBathroom";
            this.txbBathroom.Size = new System.Drawing.Size(93, 26);
            this.txbBathroom.TabIndex = 8;
            // 
            // lblBathroom
            // 
            this.lblBathroom.AutoSize = true;
            this.lblBathroom.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBathroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblBathroom.Location = new System.Drawing.Point(13, 77);
            this.lblBathroom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBathroom.Name = "lblBathroom";
            this.lblBathroom.Size = new System.Drawing.Size(97, 23);
            this.lblBathroom.TabIndex = 7;
            this.lblBathroom.Text = "Banheiros";
            // 
            // txbRooms
            // 
            this.txbRooms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbRooms.Location = new System.Drawing.Point(17, 39);
            this.txbRooms.Margin = new System.Windows.Forms.Padding(4);
            this.txbRooms.Name = "txbRooms";
            this.txbRooms.Size = new System.Drawing.Size(93, 26);
            this.txbRooms.TabIndex = 6;
            // 
            // lblRooms
            // 
            this.lblRooms.AutoSize = true;
            this.lblRooms.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRooms.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblRooms.Location = new System.Drawing.Point(13, 16);
            this.lblRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRooms.Name = "lblRooms";
            this.lblRooms.Size = new System.Drawing.Size(77, 23);
            this.lblRooms.TabIndex = 5;
            this.lblRooms.Text = "Quartos";
            // 
            // txbDistrict
            // 
            this.txbDistrict.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbDistrict.Location = new System.Drawing.Point(20, 275);
            this.txbDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.txbDistrict.Name = "txbDistrict";
            this.txbDistrict.Size = new System.Drawing.Size(160, 26);
            this.txbDistrict.TabIndex = 11;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistrict.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblDistrict.Location = new System.Drawing.Point(16, 251);
            this.lblDistrict.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(63, 23);
            this.lblDistrict.TabIndex = 10;
            this.lblDistrict.Text = "Bairro";
            // 
            // txbPrice
            // 
            this.txbPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbPrice.Location = new System.Drawing.Point(20, 332);
            this.txbPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(160, 26);
            this.txbPrice.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblPrice.Location = new System.Drawing.Point(16, 308);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(59, 23);
            this.lblPrice.TabIndex = 12;
            this.lblPrice.Text = "Preço";
            // 
            // txbLandArea
            // 
            this.txbLandArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbLandArea.Location = new System.Drawing.Point(20, 389);
            this.txbLandArea.Margin = new System.Windows.Forms.Padding(4);
            this.txbLandArea.Name = "txbLandArea";
            this.txbLandArea.Size = new System.Drawing.Size(160, 26);
            this.txbLandArea.TabIndex = 15;
            // 
            // lblLandArea
            // 
            this.lblLandArea.AutoSize = true;
            this.lblLandArea.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblLandArea.Location = new System.Drawing.Point(16, 365);
            this.lblLandArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLandArea.Name = "lblLandArea";
            this.lblLandArea.Size = new System.Drawing.Size(182, 23);
            this.lblLandArea.TabIndex = 14;
            this.lblLandArea.Text = "Área do terreno (m²)";
            // 
            // txbLandBuild
            // 
            this.txbLandBuild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbLandBuild.Location = new System.Drawing.Point(20, 452);
            this.txbLandBuild.Margin = new System.Windows.Forms.Padding(4);
            this.txbLandBuild.Name = "txbLandBuild";
            this.txbLandBuild.Size = new System.Drawing.Size(160, 26);
            this.txbLandBuild.TabIndex = 17;
            // 
            // lblLandBuild
            // 
            this.lblLandBuild.AutoSize = true;
            this.lblLandBuild.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandBuild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblLandBuild.Location = new System.Drawing.Point(16, 428);
            this.lblLandBuild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLandBuild.Name = "lblLandBuild";
            this.lblLandBuild.Size = new System.Drawing.Size(184, 23);
            this.lblLandBuild.TabIndex = 16;
            this.lblLandBuild.Text = "Área construída (m²)";
            // 
            // txbIPTUTax
            // 
            this.txbIPTUTax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbIPTUTax.Location = new System.Drawing.Point(247, 153);
            this.txbIPTUTax.Margin = new System.Windows.Forms.Padding(4);
            this.txbIPTUTax.Name = "txbIPTUTax";
            this.txbIPTUTax.Size = new System.Drawing.Size(104, 26);
            this.txbIPTUTax.TabIndex = 19;
            // 
            // lblIPTUTax
            // 
            this.lblIPTUTax.AutoSize = true;
            this.lblIPTUTax.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPTUTax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblIPTUTax.Location = new System.Drawing.Point(243, 130);
            this.lblIPTUTax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPTUTax.Name = "lblIPTUTax";
            this.lblIPTUTax.Size = new System.Drawing.Size(49, 23);
            this.lblIPTUTax.TabIndex = 18;
            this.lblIPTUTax.Text = "IPTU";
            // 
            // txbPriceCondo
            // 
            this.txbPriceCondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbPriceCondo.Location = new System.Drawing.Point(247, 215);
            this.txbPriceCondo.Margin = new System.Windows.Forms.Padding(4);
            this.txbPriceCondo.Name = "txbPriceCondo";
            this.txbPriceCondo.Size = new System.Drawing.Size(104, 26);
            this.txbPriceCondo.TabIndex = 21;
            // 
            // lblPriceCondo
            // 
            this.lblPriceCondo.AutoSize = true;
            this.lblPriceCondo.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCondo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblPriceCondo.Location = new System.Drawing.Point(243, 191);
            this.lblPriceCondo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriceCondo.Name = "lblPriceCondo";
            this.lblPriceCondo.Size = new System.Drawing.Size(192, 23);
            this.lblPriceCondo.TabIndex = 20;
            this.lblPriceCondo.Text = "P. do condomínio (R$)";
            // 
            // txbDescription
            // 
            this.txbDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(245)))), ((int)(((byte)(237)))));
            this.txbDescription.Location = new System.Drawing.Point(247, 278);
            this.txbDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(366, 201);
            this.txbDescription.TabIndex = 23;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.lblDescription.Location = new System.Drawing.Point(243, 251);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 23);
            this.lblDescription.TabIndex = 22;
            this.lblDescription.Text = "Descrição";
            // 
            // pcbImage
            // 
            this.pcbImage.Image = global::MarqueSeuImovel.Properties.Resources.casa;
            this.pcbImage.Location = new System.Drawing.Point(639, 61);
            this.pcbImage.Margin = new System.Windows.Forms.Padding(4);
            this.pcbImage.Name = "pcbImage";
            this.pcbImage.Size = new System.Drawing.Size(252, 257);
            this.pcbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbImage.TabIndex = 24;
            this.pcbImage.TabStop = false;
            // 
            // FrmProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(910, 506);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.pcbImage);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txbPriceCondo);
            this.Controls.Add(this.lblPriceCondo);
            this.Controls.Add(this.txbIPTUTax);
            this.Controls.Add(this.lblIPTUTax);
            this.Controls.Add(this.txbLandBuild);
            this.Controls.Add(this.lblLandBuild);
            this.Controls.Add(this.txbLandArea);
            this.Controls.Add(this.lblLandArea);
            this.Controls.Add(this.txbPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txbDistrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbObjective);
            this.Controls.Add(this.lblObjective);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txbCode);
            this.Font = new System.Drawing.Font("Segoe Fluent Icons", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(37)))), ((int)(((byte)(87)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmProperty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MarqueSeuImóvel";
            this.pnlOptions.ResumeLayout(false);
            this.pnlOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txbCode;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblObjective;
        private System.Windows.Forms.ComboBox cmbObjective;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.TextBox txbParkingSpots;
        private System.Windows.Forms.Label lblParkingSpots;
        private System.Windows.Forms.TextBox txbBathroom;
        private System.Windows.Forms.Label lblBathroom;
        private System.Windows.Forms.TextBox txbRooms;
        private System.Windows.Forms.Label lblRooms;
        private System.Windows.Forms.TextBox txbDistrict;
        private System.Windows.Forms.Label lblDistrict;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txbLandArea;
        private System.Windows.Forms.Label lblLandArea;
        private System.Windows.Forms.TextBox txbLandBuild;
        private System.Windows.Forms.Label lblLandBuild;
        private System.Windows.Forms.TextBox txbIPTUTax;
        private System.Windows.Forms.Label lblIPTUTax;
        private System.Windows.Forms.TextBox txbPriceCondo;
        private System.Windows.Forms.Label lblPriceCondo;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.PictureBox pcbImage;
    }
}

