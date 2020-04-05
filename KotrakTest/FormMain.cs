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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
                SqlConnection sqlConnect = new SqlConnection(DbHelper.defaultConnectionString);

                sqlConnect.Open();
                MessageBox.Show("Connected!");

                sqlConnect.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {            
            this.contractorsTableAdapter.Fill(this.kotrakDBDataSet.Contractors);
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            using (FormAddNewContractor form3 = new FormAddNewContractor())
            {
                form3.ShowDialog();
                FormMain_Load(sender, e);
            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewContractorsTable.Rows)
            {
                if (row.Selected)
                {
                    DbHelper.DeleteRowData(Convert.ToInt32(row.Cells[0].Value));

                    MessageBox.Show("Kontrahent " + Convert.ToString(row.Cells[1].Value) +
                        " został usunięty z bazy.");
                }
            }
            FormMain_Load(sender, e);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            KotrakDBDataSet.ContractorsDataTable kotrakDT = this.kotrakDBDataSet.Contractors;
            contractorsBindingSource.DataSource = kotrakDT;

            contractorsBindingSource.Filter =
                string.Format("code LIKE '%{0}%' OR name LIKE '%{0}%' OR nip LIKE '%{0}%'", textBoxSearch.Text);

            this.contractorsTableAdapter.Fill(kotrakDT);
        }

        private void dataGridViewContractorsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
                dataGridViewContractorsTable.Rows[e.RowIndex].Cells[0]; //takes the contractor_id -> our PK

            using (FormContractorView form2 = new FormContractorView((int)cell.Value))
            {
                form2.ShowDialog();
                FormMain_Load(sender, e);
            }
        }
    }
}
