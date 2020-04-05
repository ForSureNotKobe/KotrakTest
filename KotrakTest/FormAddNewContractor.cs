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
    public partial class FormAddNewContractor : Form
    {
        public FormAddNewContractor()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            DbHelper.InsertData(
            this.textBoxName.Text,
            this.textBoxCode.Text,
            this.textBoxNip.Text,
            this.textBoxPhone.Text,
            this.textBoxEmail.Text);

            Close();
        }
    }
}
