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
    public partial class FrmProperty : Form
    {
        public FrmProperty()
        {
            InitializeComponent();
            
        }
             

        private void btnShow_Click(object sender, EventArgs e)
        {
            string objective = cmbObjective.Text;
            string city = txbCity.Text;
            float price = float.Parse(txbPrice.Text);

            //Cria objeto do tipo da entidade manipulada.
            Property property = new Property(objective, city, price);

            //Cria objeto para interação com o banco de dados.
            PropertyDAO propertyDAO = new PropertyDAO();

            //Chama o insert
            propertyDAO.Insert(property);
            


            var result = MessageBox.Show(
                "Código: " + txbCode.Text, 
                "Informações digitadas",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);

            if (result == DialogResult.OK)
                MessageBox.Show("Cadastro realizado com êxito!");
            
                
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbType.SelectedIndex == 3)
                pnlOptions.Visible = false;
            else
                pnlOptions.Visible = true;
        }

        private void FrmProperty_Load(object sender, EventArgs e)
        {

        }
    }
}
