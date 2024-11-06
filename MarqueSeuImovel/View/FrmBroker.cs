using MarqueSeuImovel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarqueSeuImovel
{
    public partial class FrmBroker : Form
    {
        public FrmBroker()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Capture inputed text from fields.
                if (new BrokerDAO().Insert(new Broker(
                    txbBroker.Text, txbBrokerCode.Text, cmbState.Text, int.Parse(txbCodeArea.Text),
                    txbTelephone.Text, txbEmail.Text, txbPassword.Text)))
                    MessageBox.Show("Corretor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception error)
            {
                MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
