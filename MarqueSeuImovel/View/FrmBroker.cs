using MarqueSeuImovel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarqueSeuImovel
{
    public partial class FrmBroker : Form
    {
        private int Id = -1;
        public FrmBroker()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txbBroker.Clear();
            txbBrokerCode.Clear();
            cmbState.SelectedIndex = 0;
            txbCodeArea.Clear();
            txbTelephone.Clear();
            txbEmail.Clear();
            txbPassword.Clear();
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
        }

        private bool ValidateFields()
        {
            if (txbBrokerCode.Text.Length == 0 || txbPassword.Text.Length == 0)
            {
                MessageBox.Show("Os campos CRECI e Senha são obrigatórios", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void UpdateListView()
        {
            ltvBroker.Items.Clear();

            BrokerDAO brokerDAO = new BrokerDAO();
            List<Broker> brokers = brokerDAO.ListAllBrokers();

            //This code part access all brokers received from database and iterate by them.
            foreach (Broker broker in brokers)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(broker.Id.ToString());
                item.SubItems.Add(broker.BrokerName);
                item.SubItems.Add(broker.BrokerCode);
                item.SubItems.Add(broker.State);
                item.SubItems.Add(broker.CodeArea.ToString());
                item.SubItems.Add(broker.Telephone);
                item.SubItems.Add(broker.Email);
                //Adding the fully line to the listview.
                ltvBroker.Items.Add(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    if (new BrokerDAO().Insert(new Broker(
                        txbBroker.Text, txbBrokerCode.Text, cmbState.Text, int.Parse(txbCodeArea.Text),
                        txbTelephone.Text, txbEmail.Text, txbPassword.Text)))
                        MessageBox.Show("Corretor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void FrmBroker_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ltvBroker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvBroker.FocusedItem.Index;
                Id = int.Parse(ltvBroker.Items[index].SubItems[0].Text);
                txbBroker.Text = ltvBroker.Items[index].SubItems[1].Text;
                txbBrokerCode.Text = ltvBroker.Items[index].SubItems[2].Text;
                cmbState.Text = ltvBroker.Items[index].SubItems[3].Text;
                txbCodeArea.Text = ltvBroker.Items[index].SubItems[4].Text;
                txbTelephone.Text = ltvBroker.Items[index].SubItems[5].Text;
                txbEmail.Text = ltvBroker.Items[index].SubItems[5].Text;

                btnDelete.Visible = true;
                btnUpdate.Visible = true;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BrokerDAO brokerDao = new BrokerDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    brokerDao.Delete(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateFields())
            {
                try
                {
                    //Capture inputed text from fields.
                    new BrokerDAO().Update(new Broker(
                        Id, txbBroker.Text, txbBrokerCode.Text, cmbState.Text, int.Parse(txbCodeArea.Text),
                        txbTelephone.Text, txbEmail.Text, txbPassword.Text));
                    MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }
    }
}
