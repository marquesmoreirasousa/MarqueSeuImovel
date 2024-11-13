namespace MarqueSeuImovel
{
    partial class FrmPrincipal
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
            this.mstPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBroker = new System.Windows.Forms.ToolStripMenuItem();
            this.mstPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstPrincipal
            // 
            this.mstPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProperty,
            this.tsmBroker});
            this.mstPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mstPrincipal.Name = "mstPrincipal";
            this.mstPrincipal.Size = new System.Drawing.Size(1272, 24);
            this.mstPrincipal.TabIndex = 0;
            this.mstPrincipal.Text = "menuStrip1";
            // 
            // tsmProperty
            // 
            this.tsmProperty.Name = "tsmProperty";
            this.tsmProperty.Size = new System.Drawing.Size(55, 20);
            this.tsmProperty.Text = "Imóvel";
            this.tsmProperty.Click += new System.EventHandler(this.tsmProperty_Click);
            // 
            // tsmBroker
            // 
            this.tsmBroker.Name = "tsmBroker";
            this.tsmBroker.Size = new System.Drawing.Size(63, 20);
            this.tsmBroker.Text = "Corretor";
            this.tsmBroker.Click += new System.EventHandler(this.tsmBroker_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(1272, 697);
            this.Controls.Add(this.mstPrincipal);
            this.MainMenuStrip = this.mstPrincipal;
            this.Name = "FrmPrincipal";
            this.Text = "MarqueSeuImóvel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mstPrincipal.ResumeLayout(false);
            this.mstPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmProperty;
        private System.Windows.Forms.ToolStripMenuItem tsmBroker;
    }
}