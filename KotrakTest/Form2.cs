using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KotrakTest
{
    public partial class Form2 : Form
    {
        public int ContractorID;
        public Form2(int ConID)
        {
            ContractorID = ConID;
            InitializeComponent();

            Contractor contractor = new Contractor();
            contractor = contractor.GetContractorData(Convert.ToInt32(ConID),
                contractor.GetContractors());

            this.textBoxName.Text = contractor.Name;
            this.textBoxCode.Text = contractor.Code;
            this.textBoxNip.Text = contractor.Nip;
            this.textBoxPhone.Text = contractor.Phone;
            this.textBoxEmail.Text = contractor.Email;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            DbHelper.UpdateData(ContractorID,
                this.textBoxName.Text,
                this.textBoxCode.Text,
                this.textBoxNip.Text,
                this.textBoxPhone.Text,
                this.textBoxEmail.Text);

            Close();
        }
    }
}
