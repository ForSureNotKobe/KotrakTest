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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click_1(object sender, EventArgs e)
        {
            // TODO: Zrobić jakiegoś guesta co będzie wymagał danych logowania a nie jakieś to to co jest
            {
                SqlConnection sqlConnect = new SqlConnection(DbHelper.DefaultConnectionString);

                sqlConnect.Open();
                MessageBox.Show("Connected!");

                /*foreach (Contractor con in listOfContractors)
                {
                    MessageBox.Show("Contractor is on list " + con.ID);
                }*/

                sqlConnect.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            this.contractorsTableAdapter.Fill(this.kotrakDBDataSet.Contractors);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewTextBoxCell cell = (DataGridViewTextBoxCell)
                dataGridView2.Rows[e.RowIndex].Cells[0]; //takes the contractor_id -> our PK

            using (Form2 form2 = new Form2((int)cell.Value))
            {
                form2.ShowDialog();
                Form1_Load(sender, e);
            }

            // TODO: Klasa która ogarnie crud wybranego wiersza, przejście na kartę kontrahenta
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            using (Form3 form3 = new Form3())
            {
                form3.ShowDialog();
                Form1_Load(sender, e);
            }
        }

        private void buttonDeleteRecord_Click(object sender, EventArgs e)
        {
            //dataGridView2.SelectedRows.Clear();                
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Selected)
                {
                    DbHelper.DeleteRowData(Convert.ToInt32(row.Cells[0].Value));
                    MessageBox.Show("Kontrahent " + Convert.ToString(row.Cells[1].Value) +
                        " został usunięty z bazy.");
                }
            }
            Form1_Load(sender, e);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            KotrakDBDataSet.ContractorsDataTable kotrakDT = this.kotrakDBDataSet.Contractors;
            contractorsBindingSource.DataSource = kotrakDT;

            contractorsBindingSource.Filter =
                string.Format("code LIKE '%{0}%' OR name LIKE '%{0}%' OR nip LIKE '%{0}%'", textBoxSearch.Text);

            this.contractorsTableAdapter.Fill(kotrakDT);
        }
    }
}
